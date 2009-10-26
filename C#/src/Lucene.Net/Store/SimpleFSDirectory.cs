/* 
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Lucene.Net.Store
{
	
	/// <summary>A straightforward implementation of {@link FSDirectory}
	/// using java.io.RandomAccessFile.  However, this class has
	/// poor concurrent performance (multiple threads will
	/// bottleneck) as it synchronizes when multiple threads
	/// read from the same file.  It's usually better to use
	/// {@link NIOFSDirectory} or {@link MMapDirectory} instead. 
	/// </summary>
	public class SimpleFSDirectory:FSDirectory
	{
		
		/// <summary>Create a new SimpleFSDirectory for the named location.
		/// 
		/// </summary>
		/// <param name="path">the path of the directory
		/// </param>
		/// <param name="lockFactory">the lock factory to use, or null for the default.
		/// </param>
		/// <throws>  IOException </throws>
		public SimpleFSDirectory(System.IO.FileInfo path, LockFactory lockFactory):base(path, lockFactory)
		{
		}
		
		/// <summary>Create a new SimpleFSDirectory for the named location and the default lock factory.
		/// 
		/// </summary>
		/// <param name="path">the path of the directory
		/// </param>
		/// <throws>  IOException </throws>
		public SimpleFSDirectory(System.IO.FileInfo path):base(path, null)
		{
		}
		
		// back compatibility so FSDirectory can instantiate via reflection
		/// <deprecated> 
		/// </deprecated>
		internal SimpleFSDirectory()
		{
		}
		
		/// <summary>Creates an IndexOutput for the file with the given name. </summary>
		public override IndexOutput CreateOutput(System.String name)
		{
			InitOutput(name);
			return new SimpleFSIndexOutput(new System.IO.FileInfo(System.IO.Path.Combine(directory.FullName, name)));
		}
		
		/// <summary>Creates an IndexInput for the file with the given name. </summary>
		public override IndexInput OpenInput(System.String name, int bufferSize)
		{
			EnsureOpen();
			return new SimpleFSIndexInput(new System.IO.FileInfo(System.IO.Path.Combine(directory.FullName, name)), bufferSize, GetReadChunkSize());
		}
		
		public /*protected internal*/class SimpleFSIndexInput:BufferedIndexInput, System.ICloneable
		{
			
			protected internal class Descriptor:System.IO.BinaryReader
			{
				// remember if the file is open, so that we don't try to close it
				// more than once
				protected internal volatile bool isOpen;
				internal long position;
				internal long length;
				
				public Descriptor(/*FSIndexInput enclosingInstance,*/ System.IO.FileInfo file, System.IO.FileAccess mode) 
					: base(new System.IO.FileStream(file.FullName, System.IO.FileMode.Open, mode, System.IO.FileShare.ReadWrite))
				{
					isOpen = true;
					length = file.Length;
				}
				
				public override void  Close()
				{
					if (isOpen)
					{
						isOpen = false;
						base.Close();
					}
				}
			
				~Descriptor()
				{
					try
					{
						Close();
					}
					finally
					{
					}
				}
			}
			
			protected internal Descriptor file;
			internal bool isClone;
			//  LUCENE-1566 - maximum read length on a 32bit JVM to prevent incorrect OOM 
			protected internal int chunkSize;
			
			/// <deprecated> Please use ctor taking chunkSize 
			/// </deprecated>
			public SimpleFSIndexInput(System.IO.FileInfo path):this(path, BufferedIndexInput.BUFFER_SIZE, SimpleFSDirectory.DEFAULT_READ_CHUNK_SIZE)
			{
			}
			
			/// <deprecated> Please use ctor taking chunkSize 
			/// </deprecated>
			public SimpleFSIndexInput(System.IO.FileInfo path, int bufferSize):this(path, bufferSize, SimpleFSDirectory.DEFAULT_READ_CHUNK_SIZE)
			{
			}
			
			public SimpleFSIndexInput(System.IO.FileInfo path, int bufferSize, int chunkSize):base(bufferSize)
			{
				file = new Descriptor(path, System.IO.FileAccess.Read);
				this.chunkSize = chunkSize;
			}
			
			/// <summary>IndexInput methods </summary>
			public override void  ReadInternal(byte[] b, int offset, int len)
			{
				lock (file)
				{
					long position = GetFilePointer();
					if (position != file.position)
					{
						file.BaseStream.Seek(position, System.IO.SeekOrigin.Begin);
						file.position = position;
					}
					int total = 0;
					
					try
					{
						do 
						{
							int readLength;
							if (total + chunkSize > len)
							{
								readLength = len - total;
							}
							else
							{
								// LUCENE-1566 - work around JVM Bug by breaking very large reads into chunks
								readLength = chunkSize;
							}
							int i = file.Read(b, offset + total, readLength);
							if (i == - 1)
							{
								throw new System.IO.IOException("read past EOF");
							}
							file.position += i;
							total += i;
						}
						while (total < len);
					}
					catch (System.OutOfMemoryException e)
					{
						// propagate OOM up and add a hint for 32bit VM Users hitting the bug
						// with a large chunk size in the fast path.
						System.OutOfMemoryException outOfMemoryError = new System.OutOfMemoryException("OutOfMemoryError likely caused by the Sun VM Bug described in " + "https://issues.apache.org/jira/browse/LUCENE-1566; try calling FSDirectory.setReadChunkSize " + "with a a value smaller than the current chunks size (" + chunkSize + ")", e);
						throw outOfMemoryError;
					}
				}
			}
			
			public override void  Close()
			{
				// only close the file if this is not a clone
				if (!isClone)
					file.Close();
			}
			
			public override void  SeekInternal(long position)
			{
			}
			
			public override long Length()
			{
				return file.length;
			}
			
			public override System.Object Clone()
			{
				SimpleFSIndexInput clone = (SimpleFSIndexInput) base.Clone();
				clone.isClone = true;
				return clone;
			}
			
			/// <summary>Method used for testing. Returns true if the underlying
			/// file descriptor is valid.
			/// </summary>
			internal virtual bool IsFDValid()
			{
				return file.BaseStream != null;
			}
		}
		
		/*protected internal*/ public class SimpleFSIndexOutput:BufferedIndexOutput
		{
			internal System.IO.FileStream file = null;
			
			// remember if the file is open, so that we don't try to close it
			// more than once
			private volatile bool isOpen;
			
			public SimpleFSIndexOutput(System.IO.FileInfo path)
			{
				file = new System.IO.FileStream(path.FullName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite);
				isOpen = true;
			}
			
			/// <summary>output methods: </summary>
			public override void  FlushBuffer(byte[] b, int offset, int size)
			{
				file.Write(b, offset, size);
			}
			public override void  Close()
			{
				// only close the file if it has not been closed yet
				if (isOpen)
				{
					bool success = false;
					try
					{
						base.Close();
						success = true;
					}
					finally
					{
						isOpen = false;
						if (!success)
						{
							try
							{
								file.Close();
							}
							catch (System.Exception t)
							{
								// Suppress so we don't mask original exception
							}
						}
						else
							file.Close();
					}
				}
			}
			
			/// <summary>Random-access methods </summary>
			public override void  Seek(long pos)
			{
				base.Seek(pos);
				file.Seek(pos, System.IO.SeekOrigin.Begin);
			}
			public override long Length()
			{
				return file.Length;
			}
			public override void  SetLength(long length)
			{
				file.SetLength(length);
			}
		}
	}
}