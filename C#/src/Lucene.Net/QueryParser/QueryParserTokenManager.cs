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

/* Generated By:JavaCC: Do not edit this line. QueryParserTokenManager.java */

using System;

using Analyzer = Lucene.Net.Analysis.Analyzer;
using CachingTokenFilter = Lucene.Net.Analysis.CachingTokenFilter;
using TokenStream = Lucene.Net.Analysis.TokenStream;
using PositionIncrementAttribute = Lucene.Net.Analysis.Tokenattributes.PositionIncrementAttribute;
using TermAttribute = Lucene.Net.Analysis.Tokenattributes.TermAttribute;
using DateField = Lucene.Net.Documents.DateField;
using DateTools = Lucene.Net.Documents.DateTools;
using Term = Lucene.Net.Index.Term;
using Parameter = Lucene.Net.Util.Parameter;
using BooleanClause = Lucene.Net.Search.BooleanClause;
using BooleanQuery = Lucene.Net.Search.BooleanQuery;
using FuzzyQuery = Lucene.Net.Search.FuzzyQuery;
using MatchAllDocsQuery = Lucene.Net.Search.MatchAllDocsQuery;
using MultiPhraseQuery = Lucene.Net.Search.MultiPhraseQuery;
using MultiTermQuery = Lucene.Net.Search.MultiTermQuery;
using PhraseQuery = Lucene.Net.Search.PhraseQuery;
using PrefixQuery = Lucene.Net.Search.PrefixQuery;
using Query = Lucene.Net.Search.Query;
using TermQuery = Lucene.Net.Search.TermQuery;
using TermRangeQuery = Lucene.Net.Search.TermRangeQuery;
using WildcardQuery = Lucene.Net.Search.WildcardQuery;

namespace Lucene.Net.QueryParsers
{
	
	/// <summary>Token Manager. </summary>
	public class QueryParserTokenManager : QueryParserConstants
	{
		private void  InitBlock()
		{
			System.IO.StreamWriter temp_writer;
			temp_writer = new System.IO.StreamWriter(System.Console.OpenStandardOutput(), System.Console.Out.Encoding);
			temp_writer.AutoFlush = true;
			debugStream = temp_writer;
		}
		
		/// <summary>Debug output. </summary>
		public System.IO.StreamWriter debugStream;
		/// <summary>Set debug output. </summary>
		public virtual void  SetDebugStream(System.IO.StreamWriter ds)
		{
			debugStream = ds;
		}
		private int JjStopStringLiteralDfa_3(int pos, long active0)
		{
			switch (pos)
			{
				
				default: 
					return - 1;
				
			}
		}
		private int JjStartNfa_3(int pos, long active0)
		{
			return JjMoveNfa_3(JjStopStringLiteralDfa_3(pos, active0), pos + 1);
		}
		private int JjStopAtPos(int pos, int kind)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			return pos + 1;
		}
		private int JjMoveStringLiteralDfa0_3()
		{
			switch (curChar)
			{
				
				case (char) (40): 
					return JjStopAtPos(0, 13);
				
				case (char) (41): 
					return JjStopAtPos(0, 14);
				
				case (char) (42): 
					return JjStartNfaWithStates_3(0, 16, 36);
				
				case (char) (43): 
					return JjStopAtPos(0, 11);
				
				case (char) (45): 
					return JjStopAtPos(0, 12);
				
				case (char) (58): 
					return JjStopAtPos(0, 15);
				
				case (char) (91): 
					return JjStopAtPos(0, 23);
				
				case (char) (94): 
					return JjStopAtPos(0, 17);
				
				case (char) (123): 
					return JjStopAtPos(0, 24);
				
				default: 
					return JjMoveNfa_3(0, 0);
				
			}
		}
		private int JjStartNfaWithStates_3(int pos, int kind, int state)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (System.IO.IOException e)
			{
				return pos + 1;
			}
			return JjMoveNfa_3(state, pos + 1);
		}
		internal static readonly ulong[] jjbitVec0 = new ulong[]{0x1L, 0x0L, 0x0L, 0x0L};
		internal static readonly ulong[] jjbitVec1 = new ulong[]{0xfffffffffffffffeL, 0xffffffffffffffffL, 0xffffffffffffffffL, 0xffffffffffffffffL};
		internal static readonly ulong[] jjbitVec3 = new ulong[]{0x0L, 0x0L, 0xffffffffffffffffL, 0xffffffffffffffffL};
		internal static readonly ulong[] jjbitVec4 = new ulong[]{0xfffefffffffffffeL, 0xffffffffffffffffL, 0xffffffffffffffffL, 0xffffffffffffffffL};
		private int JjMoveNfa_3(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 36;
			int i = 1;
			jjstateSet[0] = startState;
			int kind = 0x7fffffff;
			for (; ; )
			{
				if (++jjround == 0x7fffffff)
					ReInitRounds();
				if (curChar < 64)
				{
					ulong l = (ulong) (1L << (int) curChar);
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 36: 
							case 25: 
								if ((0xfbfffcf8ffffd9ffL & l) == (ulong) 0L)
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 0: 
								if ((0xfbffd4f8ffffd9ffL & l) != (ulong) 0L)
								{
									if (kind > 22)
										kind = 22;
									JjCheckNAddTwoStates(25, 26);
								}
								else if ((0x100002600L & l) != 0L)
								{
									if (kind > 7)
										kind = 7;
								}
								else if (curChar == 34)
									JjCheckNAddStates(0, 2);
								else if (curChar == 33)
								{
									if (kind > 10)
										kind = 10;
								}
								if ((0x7bffd0f8ffffd9ffL & l) != 0L)
								{
									if (kind > 19)
										kind = 19;
									JjCheckNAddStates(3, 7);
								}
								else if (curChar == 42)
								{
									if (kind > 21)
										kind = 21;
								}
								if (curChar == 38)
									jjstateSet[jjnewStateCnt++] = 4;
								break;
							
							case 4: 
								if (curChar == 38 && kind > 8)
									kind = 8;
								break;
							
							case 5: 
								if (curChar == 38)
									jjstateSet[jjnewStateCnt++] = 4;
								break;
							
							case 13: 
								if (curChar == 33 && kind > 10)
									kind = 10;
								break;
							
							case 14: 
								if (curChar == 34)
									JjCheckNAddStates(0, 2);
								break;
							
							case 15: 
								if ((0xfffffffbffffffffL & l) != (ulong) 0L)
									JjCheckNAddStates(0, 2);
								break;
							
							case 17: 
								JjCheckNAddStates(0, 2);
								break;
							
							case 18: 
								if (curChar == 34 && kind > 18)
									kind = 18;
								break;
							
							case 20: 
								if ((0x3ff000000000000L & l) == 0L)
									break;
								if (kind > 20)
									kind = 20;
								JjAddStates(8, 9);
								break;
							
							case 21: 
								if (curChar == 46)
									JjCheckNAdd(22);
								break;
							
							case 22: 
								if ((0x3ff000000000000L & l) == 0L)
									break;
								if (kind > 20)
									kind = 20;
								JjCheckNAdd(22);
								break;
							
							case 23: 
								if (curChar == 42 && kind > 21)
									kind = 21;
								break;
							
							case 24: 
								if ((0xfbffd4f8ffffd9ffL & l) == (ulong) 0L)
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 27: 
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 28: 
								if ((0x7bffd0f8ffffd9ffL & l) == 0L)
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddStates(3, 7);
								break;
							
							case 29: 
								if ((0x7bfff8f8ffffd9ffL & l) == 0L)
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 31: 
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 32: 
								if ((0x7bfff8f8ffffd9ffL & l) != 0L)
									JjCheckNAddStates(10, 12);
								break;
							
							case 34: 
								JjCheckNAddStates(10, 12);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else if (curChar < 128)
				{
					ulong l = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 36: 
								if ((0x97ffffff87ffffffL & l) != (ulong) 0L)
								{
									if (kind > 22)
										kind = 22;
									JjCheckNAddTwoStates(25, 26);
								}
								else if (curChar == 92)
									JjCheckNAddTwoStates(27, 27);
								break;
							
							case 0: 
								if ((0x97ffffff87ffffffL & l) != (ulong) 0L)
								{
									if (kind > 19)
										kind = 19;
									JjCheckNAddStates(3, 7);
								}
								else if (curChar == 92)
									JjCheckNAddStates(13, 15);
								else if (curChar == 126)
								{
									if (kind > 20)
										kind = 20;
									jjstateSet[jjnewStateCnt++] = 20;
								}
								if ((0x97ffffff87ffffffL & l) != (ulong) 0L)
								{
									if (kind > 22)
										kind = 22;
									JjCheckNAddTwoStates(25, 26);
								}
								if (curChar == 78)
									jjstateSet[jjnewStateCnt++] = 11;
								else if (curChar == 124)
									jjstateSet[jjnewStateCnt++] = 8;
								else if (curChar == 79)
									jjstateSet[jjnewStateCnt++] = 6;
								else if (curChar == 65)
									jjstateSet[jjnewStateCnt++] = 2;
								break;
							
							case 1: 
								if (curChar == 68 && kind > 8)
									kind = 8;
								break;
							
							case 2: 
								if (curChar == 78)
									jjstateSet[jjnewStateCnt++] = 1;
								break;
							
							case 3: 
								if (curChar == 65)
									jjstateSet[jjnewStateCnt++] = 2;
								break;
							
							case 6: 
								if (curChar == 82 && kind > 9)
									kind = 9;
								break;
							
							case 7: 
								if (curChar == 79)
									jjstateSet[jjnewStateCnt++] = 6;
								break;
							
							case 8: 
								if (curChar == 124 && kind > 9)
									kind = 9;
								break;
							
							case 9: 
								if (curChar == 124)
									jjstateSet[jjnewStateCnt++] = 8;
								break;
							
							case 10: 
								if (curChar == 84 && kind > 10)
									kind = 10;
								break;
							
							case 11: 
								if (curChar == 79)
									jjstateSet[jjnewStateCnt++] = 10;
								break;
							
							case 12: 
								if (curChar == 78)
									jjstateSet[jjnewStateCnt++] = 11;
								break;
							
							case 15: 
								if ((0xffffffffefffffffL & l) != (ulong) 0L)
									JjCheckNAddStates(0, 2);
								break;
							
							case 16: 
								if (curChar == 92)
									jjstateSet[jjnewStateCnt++] = 17;
								break;
							
							case 17: 
								JjCheckNAddStates(0, 2);
								break;
							
							case 19: 
								if (curChar != 126)
									break;
								if (kind > 20)
									kind = 20;
								jjstateSet[jjnewStateCnt++] = 20;
								break;
							
							case 24: 
								if ((0x97ffffff87ffffffL & l) == (ulong) 0L)
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 25: 
								if ((0x97ffffff87ffffffL & l) == (ulong) 0L)
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 26: 
								if (curChar == 92)
									JjCheckNAddTwoStates(27, 27);
								break;
							
							case 27: 
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 28: 
								if ((0x97ffffff87ffffffL & l) == (ulong) 0L)
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddStates(3, 7);
								break;
							
							case 29: 
								if ((0x97ffffff87ffffffL & l) == (ulong) 0L)
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 30: 
								if (curChar == 92)
									JjCheckNAddTwoStates(31, 31);
								break;
							
							case 31: 
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 32: 
								if ((0x97ffffff87ffffffL & l) != (ulong) 0L)
									JjCheckNAddStates(10, 12);
								break;
							
							case 33: 
								if (curChar == 92)
									JjCheckNAddTwoStates(34, 34);
								break;
							
							case 34: 
								JjCheckNAddStates(10, 12);
								break;
							
							case 35: 
								if (curChar == 92)
									JjCheckNAddStates(13, 15);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else
				{
					int hiByte = (int) (curChar >> 8);
					int i1 = hiByte >> 6;
					ulong l1 = (ulong) (1L << (hiByte & 63));
					int i2 = (curChar & 0xff) >> 6;
					ulong l2 = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 36: 
							case 25: 
								if (!JjCanMove_2(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 0: 
								if (JjCanMove_0(hiByte, i1, i2, l1, l2))
								{
									if (kind > 7)
										kind = 7;
								}
								if (JjCanMove_2(hiByte, i1, i2, l1, l2))
								{
									if (kind > 22)
										kind = 22;
									JjCheckNAddTwoStates(25, 26);
								}
								if (JjCanMove_2(hiByte, i1, i2, l1, l2))
								{
									if (kind > 19)
										kind = 19;
									JjCheckNAddStates(3, 7);
								}
								break;
							
							case 15: 
							case 17: 
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
									JjCheckNAddStates(0, 2);
								break;
							
							case 24: 
								if (!JjCanMove_2(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 27: 
								if (!JjCanMove_1(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 22)
									kind = 22;
								JjCheckNAddTwoStates(25, 26);
								break;
							
							case 28: 
								if (!JjCanMove_2(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddStates(3, 7);
								break;
							
							case 29: 
								if (!JjCanMove_2(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 31: 
								if (!JjCanMove_1(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 19)
									kind = 19;
								JjCheckNAddTwoStates(29, 30);
								break;
							
							case 32: 
								if (JjCanMove_2(hiByte, i1, i2, l1, l2))
									JjCheckNAddStates(10, 12);
								break;
							
							case 34: 
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
									JjCheckNAddStates(10, 12);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				if (kind != 0x7fffffff)
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = 0x7fffffff;
				}
				++curPos;
				if ((i = jjnewStateCnt) == (startsAt = 36 - (jjnewStateCnt = startsAt)))
					return curPos;
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (System.IO.IOException e)
				{
					return curPos;
				}
			}
		}
		private int JjStopStringLiteralDfa_1(int pos, long active0)
		{
			switch (pos)
			{
				
				case 0: 
					if ((active0 & 0x40000000L) != 0L)
					{
						jjmatchedKind = 33;
						return 6;
					}
					return - 1;
				
				default: 
					return - 1;
				
			}
		}
		private int JjStartNfa_1(int pos, long active0)
		{
			return JjMoveNfa_1(JjStopStringLiteralDfa_1(pos, active0), pos + 1);
		}
		private int JjMoveStringLiteralDfa0_1()
		{
			switch (curChar)
			{
				
				case (char) (84): 
					return JjMoveStringLiteralDfa1_1(0x40000000L);
				
				case (char) (125): 
					return JjStopAtPos(0, 31);
				
				default: 
					return JjMoveNfa_1(0, 0);
				
			}
		}
		private int JjMoveStringLiteralDfa1_1(long active0)
		{
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (System.IO.IOException e)
			{
				JjStopStringLiteralDfa_1(0, active0);
				return 1;
			}
			switch (curChar)
			{
				
				case (char) (79): 
					if ((active0 & 0x40000000L) != 0L)
						return JjStartNfaWithStates_1(1, 30, 6);
					break;
				
				default: 
					break;
				
			}
			return JjStartNfa_1(0, active0);
		}
		private int JjStartNfaWithStates_1(int pos, int kind, int state)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (System.IO.IOException e)
			{
				return pos + 1;
			}
			return JjMoveNfa_1(state, pos + 1);
		}
		private int JjMoveNfa_1(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 7;
			int i = 1;
			jjstateSet[0] = startState;
			int kind = 0x7fffffff;
			for (; ; )
			{
				if (++jjround == 0x7fffffff)
					ReInitRounds();
				if (curChar < 64)
				{
					ulong l = (ulong) (1L << (int) curChar);
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
								if ((0xfffffffeffffffffL & l) != (ulong) 0L)
								{
									if (kind > 33)
										kind = 33;
									JjCheckNAdd(6);
								}
								if ((0x100002600L & l) != 0L)
								{
									if (kind > 7)
										kind = 7;
								}
								else if (curChar == 34)
									JjCheckNAddTwoStates(2, 4);
								break;
							
							case 1: 
								if (curChar == 34)
									JjCheckNAddTwoStates(2, 4);
								break;
							
							case 2: 
								if ((0xfffffffbffffffffL & l) != (ulong) 0L)
									JjCheckNAddStates(16, 18);
								break;
							
							case 3: 
								if (curChar == 34)
									JjCheckNAddStates(16, 18);
								break;
							
							case 5: 
								if (curChar == 34 && kind > 32)
									kind = 32;
								break;
							
							case 6: 
								if ((0xfffffffeffffffffL & l) == (ulong) 0L)
									break;
								if (kind > 33)
									kind = 33;
								JjCheckNAdd(6);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else if (curChar < 128)
				{
					ulong l = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
							case 6: 
								if ((0xdfffffffffffffffL & l) == (ulong) 0L)
									break;
								if (kind > 33)
									kind = 33;
								JjCheckNAdd(6);
								break;
							
							case 2: 
								JjAddStates(16, 18);
								break;
							
							case 4: 
								if (curChar == 92)
									jjstateSet[jjnewStateCnt++] = 3;
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else
				{
					int hiByte = (int) (curChar >> 8);
					int i1 = hiByte >> 6;
					ulong l1 = (ulong) (1L << (hiByte & 63));
					int i2 = (curChar & 0xff) >> 6;
					ulong l2 = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
								if (JjCanMove_0(hiByte, i1, i2, l1, l2))
								{
									if (kind > 7)
										kind = 7;
								}
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
								{
									if (kind > 33)
										kind = 33;
									JjCheckNAdd(6);
								}
								break;
							
							case 2: 
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
									JjAddStates(16, 18);
								break;
							
							case 6: 
								if (!JjCanMove_1(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 33)
									kind = 33;
								JjCheckNAdd(6);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				if (kind != 0x7fffffff)
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = 0x7fffffff;
				}
				++curPos;
				if ((i = jjnewStateCnt) == (startsAt = 7 - (jjnewStateCnt = startsAt)))
					return curPos;
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (System.IO.IOException e)
				{
					return curPos;
				}
			}
		}
		private int JjMoveStringLiteralDfa0_0()
		{
			return JjMoveNfa_0(0, 0);
		}
		private int JjMoveNfa_0(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 3;
			int i = 1;
			jjstateSet[0] = startState;
			int kind = 0x7fffffff;
			for (; ; )
			{
				if (++jjround == 0x7fffffff)
					ReInitRounds();
				if (curChar < 64)
				{
					ulong l = (ulong) (1L << (int) curChar);
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
								if ((0x3ff000000000000L & l) == 0L)
									break;
								if (kind > 25)
									kind = 25;
								JjAddStates(19, 20);
								break;
							
							case 1: 
								if (curChar == 46)
									JjCheckNAdd(2);
								break;
							
							case 2: 
								if ((0x3ff000000000000L & l) == 0L)
									break;
								if (kind > 25)
									kind = 25;
								JjCheckNAdd(2);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else if (curChar < 128)
				{
					ulong l = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else
				{
					int hiByte = (int) (curChar >> 8);
					int i1 = hiByte >> 6;
					long l1 = 1L << (hiByte & 63);
					int i2 = (curChar & 0xff) >> 6;
					long l2 = 1L << (curChar & 63);
					do 
					{
						switch (jjstateSet[--i])
						{
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				if (kind != 0x7fffffff)
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = 0x7fffffff;
				}
				++curPos;
				if ((i = jjnewStateCnt) == (startsAt = 3 - (jjnewStateCnt = startsAt)))
					return curPos;
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (System.IO.IOException e)
				{
					return curPos;
				}
			}
		}
		private int JjStopStringLiteralDfa_2(int pos, long active0)
		{
			switch (pos)
			{
				
				case 0: 
					if ((active0 & 0x4000000L) != 0L)
					{
						jjmatchedKind = 29;
						return 6;
					}
					return - 1;
				
				default: 
					return - 1;
				
			}
		}
		private int JjStartNfa_2(int pos, long active0)
		{
			return JjMoveNfa_2(JjStopStringLiteralDfa_2(pos, active0), pos + 1);
		}
		private int JjMoveStringLiteralDfa0_2()
		{
			switch (curChar)
			{
				
				case (char) (84): 
					return JjMoveStringLiteralDfa1_2(0x4000000L);
				
				case (char) (93): 
					return JjStopAtPos(0, 27);
				
				default: 
					return JjMoveNfa_2(0, 0);
				
			}
		}
		private int JjMoveStringLiteralDfa1_2(long active0)
		{
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (System.IO.IOException e)
			{
				JjStopStringLiteralDfa_2(0, active0);
				return 1;
			}
			switch (curChar)
			{
				
				case (char) (79): 
					if ((active0 & 0x4000000L) != 0L)
						return JjStartNfaWithStates_2(1, 26, 6);
					break;
				
				default: 
					break;
				
			}
			return JjStartNfa_2(0, active0);
		}
		private int JjStartNfaWithStates_2(int pos, int kind, int state)
		{
			jjmatchedKind = kind;
			jjmatchedPos = pos;
			try
			{
				curChar = input_stream.ReadChar();
			}
			catch (System.IO.IOException e)
			{
				return pos + 1;
			}
			return JjMoveNfa_2(state, pos + 1);
		}
		private int JjMoveNfa_2(int startState, int curPos)
		{
			int startsAt = 0;
			jjnewStateCnt = 7;
			int i = 1;
			jjstateSet[0] = startState;
			int kind = 0x7fffffff;
			for (; ; )
			{
				if (++jjround == 0x7fffffff)
					ReInitRounds();
				if (curChar < 64)
				{
					ulong l = (ulong) (1L << (int) curChar);
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
								if ((0xfffffffeffffffffL & l) != (ulong) 0L)
								{
									if (kind > 29)
										kind = 29;
									JjCheckNAdd(6);
								}
								if ((0x100002600L & l) != 0L)
								{
									if (kind > 7)
										kind = 7;
								}
								else if (curChar == 34)
									JjCheckNAddTwoStates(2, 4);
								break;
							
							case 1: 
								if (curChar == 34)
									JjCheckNAddTwoStates(2, 4);
								break;
							
							case 2: 
								if ((0xfffffffbffffffffL & l) != (ulong) 0L)
									JjCheckNAddStates(16, 18);
								break;
							
							case 3: 
								if (curChar == 34)
									JjCheckNAddStates(16, 18);
								break;
							
							case 5: 
								if (curChar == 34 && kind > 28)
									kind = 28;
								break;
							
							case 6: 
								if ((0xfffffffeffffffffL & l) == (ulong) 0L)
									break;
								if (kind > 29)
									kind = 29;
								JjCheckNAdd(6);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else if (curChar < 128)
				{
					ulong l = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
							case 6: 
								if ((0xffffffffdfffffffL & l) == (ulong) 0L)
									break;
								if (kind > 29)
									kind = 29;
								JjCheckNAdd(6);
								break;
							
							case 2: 
								JjAddStates(16, 18);
								break;
							
							case 4: 
								if (curChar == 92)
									jjstateSet[jjnewStateCnt++] = 3;
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				else
				{
					int hiByte = (int) (curChar >> 8);
					int i1 = hiByte >> 6;
					ulong l1 = (ulong) (1L << (hiByte & 63));
					int i2 = (curChar & 0xff) >> 6;
					ulong l2 = (ulong) (1L << (curChar & 63));
					do 
					{
						switch (jjstateSet[--i])
						{
							
							case 0: 
								if (JjCanMove_0(hiByte, i1, i2, l1, l2))
								{
									if (kind > 7)
										kind = 7;
								}
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
								{
									if (kind > 29)
										kind = 29;
									JjCheckNAdd(6);
								}
								break;
							
							case 2: 
								if (JjCanMove_1(hiByte, i1, i2, l1, l2))
									JjAddStates(16, 18);
								break;
							
							case 6: 
								if (!JjCanMove_1(hiByte, i1, i2, l1, l2))
									break;
								if (kind > 29)
									kind = 29;
								JjCheckNAdd(6);
								break;
							
							default:  break;
							
						}
					}
					while (i != startsAt);
				}
				if (kind != 0x7fffffff)
				{
					jjmatchedKind = kind;
					jjmatchedPos = curPos;
					kind = 0x7fffffff;
				}
				++curPos;
				if ((i = jjnewStateCnt) == (startsAt = 7 - (jjnewStateCnt = startsAt)))
					return curPos;
				try
				{
					curChar = input_stream.ReadChar();
				}
				catch (System.IO.IOException e)
				{
					return curPos;
				}
			}
		}
		internal static readonly int[] jjnextStates = new int[]{15, 16, 18, 29, 32, 23, 33, 30, 20, 21, 32, 23, 33, 31, 34, 27, 2, 4, 5, 0, 1};
		private static bool JjCanMove_0(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 48: 
					return ((jjbitVec0[i2] & l2) != (ulong) 0L);
				
				default: 
					return false;
				
			}
		}
		private static bool JjCanMove_1(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 0: 
					return ((jjbitVec3[i2] & l2) != (ulong) 0L);
				
				default: 
					if ((jjbitVec1[i1] & l1) != (ulong) 0L)
						return true;
					return false;
				
			}
		}
		private static bool JjCanMove_2(int hiByte, int i1, int i2, ulong l1, ulong l2)
		{
			switch (hiByte)
			{
				
				case 0: 
					return ((jjbitVec3[i2] & l2) != (ulong) 0L);
				
				case 48: 
					return ((jjbitVec1[i2] & l2) != (ulong) 0L);
				
				default: 
					if ((jjbitVec4[i1] & l1) != (ulong) 0L)
						return true;
					return false;
				
			}
		}
		
		/// <summary>Token literal values. </summary>
		public static readonly System.String[] jjstrLiteralImages = new System.String[]{"", null, null, null, null, null, null, null, null, null, null, "\x002B", "\x002D", "\x0028", "\x0029", "\x003A", "\x002A", "\x005E", null, null, null, null, null, "\x005B", "\x007B", null, "\x0054\x004F", "\x005D", null, null, "\x0054\x004F", "\x007D", null, null};
		
		/// <summary>Lexer state names. </summary>
		public static readonly System.String[] lexStateNames = new System.String[]{"Boost", "RangeEx", "RangeIn", "DEFAULT"};
		
		/// <summary>Lex State array. </summary>
		public static readonly int[] jjnewLexState = new int[]{- 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, - 1, 0, - 1, - 1, - 1, - 1, - 1, 2, 1, 3, - 1, 3, - 1, - 1, - 1, 3, - 1, - 1};
		internal static readonly ulong[] jjtoToken = new ulong[]{0x3ffffff01L};
		internal static readonly long[] jjtoSkip = new long[]{0x80L};
		protected internal CharStream input_stream;
		private uint[] jjrounds = new uint[36];
		private int[] jjstateSet = new int[72];
		protected internal char curChar;
		/// <summary>Constructor. </summary>
		public QueryParserTokenManager(CharStream stream)
		{
			InitBlock();
			input_stream = stream;
		}
		
		/// <summary>Constructor. </summary>
		public QueryParserTokenManager(CharStream stream, int lexState):this(stream)
		{
			SwitchTo(lexState);
		}
		
		/// <summary>Reinitialise parser. </summary>
		public virtual void  ReInit(CharStream stream)
		{
			jjmatchedPos = jjnewStateCnt = 0;
			curLexState = defaultLexState;
			input_stream = stream;
			ReInitRounds();
		}
		private void  ReInitRounds()
		{
			int i;
			jjround = 0x80000001;
			for (i = 36; i-- > 0; )
				jjrounds[i] = 0x80000000;
		}
		
		/// <summary>Reinitialise parser. </summary>
		public virtual void  ReInit(CharStream stream, int lexState)
		{
			ReInit(stream);
			SwitchTo(lexState);
		}
		
		/// <summary>Switch to specified lex state. </summary>
		public virtual void  SwitchTo(int lexState)
		{
			if (lexState >= 4 || lexState < 0)
				throw new TokenMgrError("Error: Ignoring invalid lexical state : " + lexState + ". State unchanged.", TokenMgrError.INVALID_LEXICAL_STATE);
			else
				curLexState = lexState;
		}
		
		protected internal virtual Token JjFillToken()
		{
			Token t;
			System.String curTokenImage;
			int beginLine;
			int endLine;
			int beginColumn;
			int endColumn;
			System.String im = jjstrLiteralImages[jjmatchedKind];
			curTokenImage = (im == null)?input_stream.GetImage():im;
			beginLine = input_stream.GetBeginLine();
			beginColumn = input_stream.GetBeginColumn();
			endLine = input_stream.GetEndLine();
			endColumn = input_stream.GetEndColumn();
			t = Token.NewToken(jjmatchedKind, curTokenImage);
			
			t.beginLine = beginLine;
			t.endLine = endLine;
			t.beginColumn = beginColumn;
			t.endColumn = endColumn;
			
			return t;
		}
		
		internal int curLexState = 3;
		internal int defaultLexState = 3;
		internal int jjnewStateCnt;
		internal uint jjround;
		internal int jjmatchedPos;
		internal int jjmatchedKind;
		
		/// <summary>Get the next Token. </summary>
		public virtual Token GetNextToken()
		{
			Token matchedToken;
			int curPos = 0;
			
			for (; ; )
			{
				try
				{
					curChar = input_stream.BeginToken();
				}
				catch (System.IO.IOException e)
				{
					jjmatchedKind = 0;
					matchedToken = JjFillToken();
					return matchedToken;
				}
				
				switch (curLexState)
				{
					
					case 0: 
						jjmatchedKind = 0x7fffffff;
						jjmatchedPos = 0;
						curPos = JjMoveStringLiteralDfa0_0();
						break;
					
					case 1: 
						jjmatchedKind = 0x7fffffff;
						jjmatchedPos = 0;
						curPos = JjMoveStringLiteralDfa0_1();
						break;
					
					case 2: 
						jjmatchedKind = 0x7fffffff;
						jjmatchedPos = 0;
						curPos = JjMoveStringLiteralDfa0_2();
						break;
					
					case 3: 
						jjmatchedKind = 0x7fffffff;
						jjmatchedPos = 0;
						curPos = JjMoveStringLiteralDfa0_3();
						break;
					}
				if (jjmatchedKind != 0x7fffffff)
				{
					if (jjmatchedPos + 1 < curPos)
						input_stream.Backup(curPos - jjmatchedPos - 1);
					if ((jjtoToken[jjmatchedKind >> 6] & ((ulong) 1L << (jjmatchedKind & 63))) != (ulong) 0L)
					{
						matchedToken = JjFillToken();
						if (jjnewLexState[jjmatchedKind] != - 1)
							curLexState = jjnewLexState[jjmatchedKind];
						return matchedToken;
					}
					else
					{
						if (jjnewLexState[jjmatchedKind] != - 1)
							curLexState = jjnewLexState[jjmatchedKind];
						goto EOFLoop;
					}
				}
				int error_line = input_stream.GetEndLine();
				int error_column = input_stream.GetEndColumn();
				System.String error_after = null;
				bool EOFSeen = false;
				try
				{
					input_stream.ReadChar(); input_stream.Backup(1);
				}
				catch (System.IO.IOException e1)
				{
					EOFSeen = true;
					error_after = curPos <= 1?"":input_stream.GetImage();
					if (curChar == '\n' || curChar == '\r')
					{
						error_line++;
						error_column = 0;
					}
					else
						error_column++;
				}
				if (!EOFSeen)
				{
					input_stream.Backup(1);
					error_after = curPos <= 1?"":input_stream.GetImage();
				}
				throw new TokenMgrError(EOFSeen, curLexState, error_line, error_column, error_after, curChar, TokenMgrError.LEXICAL_ERROR);

EOFLoop: ;
			}
		}
		
		private void  JjCheckNAdd(int state)
		{
			if (jjrounds[state] != jjround)
			{
				jjstateSet[jjnewStateCnt++] = state;
				jjrounds[state] = jjround;
			}
		}
		private void  JjAddStates(int start, int end)
		{
			do 
			{
				jjstateSet[jjnewStateCnt++] = jjnextStates[start];
			}
			while (start++ != end);
		}
		private void  JjCheckNAddTwoStates(int state1, int state2)
		{
			JjCheckNAdd(state1);
			JjCheckNAdd(state2);
		}
		
		private void  JjCheckNAddStates(int start, int end)
		{
			do 
			{
				JjCheckNAdd(jjnextStates[start]);
			}
			while (start++ != end);
		}
	}
}