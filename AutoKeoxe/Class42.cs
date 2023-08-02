using System;
using System.IO;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000026 RID: 38
	internal class Class42
	{
		// Token: 0x06000275 RID: 629 RVA: 0x00060644 File Offset: 0x0005E844
		public static void smethod_0()
		{
			bool flag = Class42.bool_0;
			if (!flag)
			{
				Class42.bool_0 = true;
				int num = 0;
				string text = Class53.string_9 + "\\tbRoad.txt";
				string text2;
				for (;;)
				{
					text2 = Class12.smethod_33(text, 0, 0, 1);
					bool flag2 = text2 != null && !(text2 == string.Empty);
					if (flag2)
					{
						while (text2 != null && text2 != string.Empty && (text2[0] == '\r' || text2[0] == '\n'))
						{
							text2 = text2.Substring(1);
						}
						bool flag3 = text2 != null && !(text2 == string.Empty) && text2.IndexOf("=") <= 4;
						if (flag3)
						{
							break;
						}
					}
					for (;;)
					{
						num++;
						string text3 = null;
						bool flag4 = num == 1;
						if (flag4)
						{
							text3 = "ᔣᔯᔯᔫᔮᓵᓪᓪᔟᔭᔤᔱᔠᓩᔢᔪᔪᔢᔧᔠᓩᔞᔪᔨᓪᔡᔤᔧᔠᓪᔟᓪᓬᔍᔥᔪᔔᔡᓰᔰᔃᔞᓽᔪᔄᔜᔰᔱᔬᔃᓨᔡᔔᔵᔴᔝᔓᔏᔮᓫᓼᔑᔴᓳᓯᓪᔱᔤᔠᔲᓺᔰᔮᔫᓸᔮᔣᔜᔭᔤᔩᔢ";
						}
						else
						{
							bool flag5 = num == 2;
							if (flag5)
							{
								text3 = "ᓸᔄᔄᔀᓊᒿᒿᓻᓹᓽᔉᓵᓾᒾᓾᓵᔄᒿᔅᔀᓼᓿᓱᓴᒿᔄᓽᔀᒿᔄᓲᓢᓿᓱᓴᒾᔄᔈᔄ";
							}
						}
						bool flag6 = text3 == null || text3 == string.Empty;
						if (flag6)
						{
							goto Block_25;
						}
						try
						{
							Class12.smethod_23(Class53.string_9);
							FileInfo fileInfo = Class67.smethod_0(Class12.smethod_53(text3), text);
							bool flag7 = fileInfo != null && fileInfo.Exists;
							if (flag7)
							{
								break;
							}
						}
						catch
						{
							break;
						}
					}
				}
				string[] array = text2.Split(new char[]
				{
					'\r',
					'\n'
				});
				int[,] array2 = new int[10, 2];
				Class11.smethod_4(array2, 185362);
				int[,] array3 = array2;
				bool flag8 = Class42.bool_1;
				if (flag8)
				{
					int[,] array4 = new int[17, 2];
					Class11.smethod_4(array4, 185455);
					array3 = array4;
				}
				int num2 = 0;
				Class42.gstruct19_0 = new GStruct19[array.Length + array3.GetLength(0) + 1];
				foreach (string text4 in array)
				{
					bool flag9 = text4 == null || text4 == string.Empty;
					if (!flag9)
					{
						int num3 = text4.IndexOf("=");
						bool flag10 = num3 < 0;
						if (!flag10)
						{
							int num4 = Class12.smethod_11(text4.Substring(0, num3));
							bool flag11 = num4 == 0;
							if (!flag11)
							{
								string text5 = Class12.smethod_71(text4.Substring(num3 + 1).Trim());
								bool flag12 = text5 == null || text5 == string.Empty;
								if (!flag12)
								{
									ref GStruct19 ptr = ref Class42.gstruct19_0[num2];
									ptr = Class42.smethod_9(text5, num4, null);
									num2++;
									for (int j = 0; j < array3.GetLength(0); j++)
									{
										bool flag13 = num4 == array3[j, 0];
										if (flag13)
										{
											ref GStruct19 ptr2 = ref Class42.gstruct19_0[num2];
											ptr2 = Class42.smethod_9(text5, array3[j, 1], null);
											array3[j, 0] = -1;
											num2++;
										}
									}
								}
							}
						}
					}
				}
				bool flag14 = num2 != 0;
				if (flag14)
				{
					bool flag15 = num2 < Class42.gstruct19_0.Length;
					if (flag15)
					{
						Array.Resize<GStruct19>(ref Class42.gstruct19_0, num2);
					}
				}
				else
				{
					Class42.gstruct19_0 = null;
				}
				Block_25:
				Class42.bool_0 = false;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000609C0 File Offset: 0x0005EBC0
		public static uint[,] smethod_1(int int_0, uint[] uint_0, uint[] uint_1 = null, string string_0 = null, bool bool_3 = false)
		{
			int num = 0;
			while (Class42.bool_2 && num < 1000)
			{
				num++;
				Thread.Sleep(1);
			}
			Class42.bool_2 = true;
			uint[,] result = null;
			bool flag = Class42.gstruct19_0 != null;
			if (flag)
			{
				for (int i = 0; i < Class42.gstruct19_0.Length; i++)
				{
					bool flag2 = int_0 == Class42.gstruct19_0[i].int_0;
					if (flag2)
					{
						result = Class42.smethod_4(Class42.gstruct19_0[i], uint_0, uint_1, string_0, bool_3);
						break;
					}
				}
			}
			Class42.bool_2 = false;
			return result;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00060A6C File Offset: 0x0005EC6C
		public static int smethod_2(int int_0)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < Class42.gstruct19_0.Length;
				if (!flag)
				{
					goto IL_34;
				}
				bool flag2 = int_0 == Class42.gstruct19_0[num].int_0;
				if (flag2)
				{
					break;
				}
				num++;
			}
			return num;
			IL_34:
			return -1;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00060ABC File Offset: 0x0005ECBC
		public static uint[] smethod_3(GStruct19 gstruct19_1, uint[] uint_0, string string_0, bool bool_3 = false)
		{
			bool flag = gstruct19_1.uint_0 != null && gstruct19_1.uint_0.GetLength(0) != 0;
			uint[] result;
			if (flag)
			{
				int length = gstruct19_1.uint_0.GetLength(0);
				bool flag2 = string_0 != null && string_0 != string.Empty && gstruct19_1.string_0 != null;
				if (flag2)
				{
					string[] array = string_0.ToLower().Split(new char[]
					{
						'|'
					});
					int num = gstruct19_1.string_0.Length;
					long num2 = -1L;
					int num3 = -1;
					for (int i = 0; i < gstruct19_1.int_1; i++)
					{
						bool flag3 = i >= num;
						if (!flag3)
						{
							for (int j = 0; j < array.Length; j++)
							{
								string text = gstruct19_1.string_0[i].ToLower();
								bool flag4 = (text == array[j] || (!bool_3 && 0 <= text.IndexOf(array[j]))) && i < length;
								if (flag4)
								{
									uint[] uint_ = new uint[]
									{
										gstruct19_1.uint_0[i, 0],
										gstruct19_1.uint_0[i, 1]
									};
									long num4 = Class42.smethod_6(uint_0, uint_);
									bool flag5 = num3 < 0 || num4 < num2;
									if (flag5)
									{
										num3 = i;
										num2 = num4;
									}
								}
							}
						}
					}
					bool flag6 = 0 <= num3;
					if (flag6)
					{
						return new uint[]
						{
							gstruct19_1.uint_0[num3, 0],
							gstruct19_1.uint_0[num3, 1]
						};
					}
				}
				result = null;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00060C74 File Offset: 0x0005EE74
		public static uint[,] smethod_4(GStruct19 gstruct19_1, uint[] uint_0, uint[] uint_1 = null, string string_0 = null, bool bool_3 = false)
		{
			bool flag = gstruct19_1.uint_0 != null && gstruct19_1.uint_0.GetLength(0) != 0;
			uint[,] result;
			if (flag)
			{
				int length = gstruct19_1.uint_0.GetLength(0);
				bool flag2 = (uint_1 == null || uint_1[0] == 0U || uint_1[1] == 0U) && string_0 != null && string_0 != string.Empty && gstruct19_1.string_0 != null;
				if (flag2)
				{
					string[] array = string_0.ToLower().Split(new char[]
					{
						'|'
					});
					int num = gstruct19_1.string_0.Length;
					long num2 = -1L;
					int num3 = -1;
					for (int i = 0; i < gstruct19_1.int_1; i++)
					{
						bool flag3 = i >= num;
						if (!flag3)
						{
							for (int j = 0; j < array.Length; j++)
							{
								string text = gstruct19_1.string_0[i].ToLower();
								bool flag4 = (text == array[j] || (!bool_3 && 0 <= text.IndexOf(array[j]))) && i < length;
								if (flag4)
								{
									uint[] uint_2 = new uint[]
									{
										gstruct19_1.uint_0[i, 0],
										gstruct19_1.uint_0[i, 1]
									};
									long num4 = Class42.smethod_6(uint_0, uint_2);
									bool flag5 = num3 < 0 || num4 < num2;
									if (flag5)
									{
										num3 = i;
										num2 = num4;
									}
								}
							}
						}
					}
					bool flag6 = 0 <= num3;
					if (flag6)
					{
						uint_1 = new uint[]
						{
							gstruct19_1.uint_0[num3, 0],
							gstruct19_1.uint_0[num3, 1]
						};
					}
				}
				bool flag7 = uint_1 != null && uint_1[0] != 0U && uint_1[1] > 0U;
				if (flag7)
				{
					int num5 = -1;
					int num6 = -1;
					long num7 = -1L;
					long num8 = -1L;
					for (int k = 0; k < length; k++)
					{
						uint[] uint_3 = new uint[]
						{
							gstruct19_1.uint_0[k, 0],
							gstruct19_1.uint_0[k, 1]
						};
						long num9 = Class42.smethod_6(uint_0, uint_3);
						long num10 = Class42.smethod_6(uint_1, uint_3);
						bool flag8 = num5 < 0 || num9 < num7;
						if (flag8)
						{
							num5 = k;
							num7 = num9;
						}
						bool flag9 = num6 < 0 || num10 < num8;
						if (flag9)
						{
							num6 = k;
							num8 = num10;
						}
					}
					bool flag10 = num5 == num6;
					if (flag10)
					{
						result = null;
					}
					else
					{
						int[] array2 = Class42.smethod_5(gstruct19_1.int_4, num5, num6);
						bool flag11 = array2 != null && array2.Length != 0;
						if (flag11)
						{
							uint[,] array3 = new uint[array2.Length, 2];
							for (int l = 0; l < array2.Length; l++)
							{
								array3[l, 0] = gstruct19_1.uint_0[array2[l], 0];
								array3[l, 1] = gstruct19_1.uint_0[array2[l], 1];
							}
							result = array3;
						}
						else
						{
							result = null;
						}
					}
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00060F9C File Offset: 0x0005F19C
		public static int[] smethod_5(int[,] int_0, int int_1, int int_2)
		{
			bool flag = int_0 == null;
			int[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int length = int_0.GetLength(0);
				bool flag2 = int_1 < 0 || length <= int_1 || int_2 < 0 || length <= int_2;
				if (flag2)
				{
					result = null;
				}
				else
				{
					bool flag3 = int_1 == int_2;
					if (flag3)
					{
						result = new int[]
						{
							int_1
						};
					}
					else
					{
						int num = 599999999;
						int[] array = new int[length];
						int[] array2 = new int[length];
						int[] array3 = new int[length];
						byte[] array4 = new byte[length];
						array[int_1] = 0;
						array2[int_1] = 0;
						int num2 = int_1;
						int num3;
						while (num2 != int_2)
						{
							num3 = -1;
							int num4 = num;
							for (int i = 0; i < length; i++)
							{
								bool flag4 = array4[i] == 0;
								if (flag4)
								{
									array[i] = -1;
									array2[i] = num;
									array3[i] = 0;
									array4[i] = 1;
								}
								bool flag5 = array3[i] == 0;
								if (flag5)
								{
									int num5 = int_0[num2, i];
									int num6 = array2[num2] + num5;
									bool flag6 = num2 == 0;
									if (flag6)
									{
										num6 = num5;
									}
									bool flag7 = num5 > 0 && array2[i] > num6;
									if (flag7)
									{
										array2[i] = num6;
										array[i] = num2;
									}
									bool flag8 = num4 > array2[i];
									if (flag8)
									{
										num4 = array2[i];
										num3 = i;
									}
								}
							}
							bool flag9 = num3 >= 0;
							if (!flag9)
							{
								return null;
							}
							num2 = num3;
							array3[num2] = 1;
						}
						num2 = 0;
						num3 = int_2;
						int[] array5 = new int[length];
						while (num3 != int_1)
						{
							bool flag10 = num2 > 0;
							if (flag10)
							{
								num3 = array[num3];
							}
							array5[num2] = num3;
							num2++;
						}
						int[] array6 = new int[num2];
						for (int j = 0; j < num2; j++)
						{
							array6[j] = array5[num2 - j - 1];
						}
						result = array6;
					}
				}
			}
			return result;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000611A4 File Offset: 0x0005F3A4
		public static long smethod_6(uint[] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 != null && uint_1 != null && uint_0[0] != 0U && uint_0[1] != 0U && uint_1[0] != 0U && uint_1[1] > 0U;
			long result;
			if (flag)
			{
				long num = (long)(uint_0[0] - uint_1[0]);
				long num2 = (long)(uint_0[1] - uint_1[1]);
				long num3 = num * num + num2 * num2;
				bool flag2 = num3 == 0L;
				if (flag2)
				{
					num3 = 1L;
				}
				result = (long)((ulong)((uint)num3));
			}
			else
			{
				result = 2147483647L;
			}
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00061210 File Offset: 0x0005F410
		private static int smethod_7(string string_0)
		{
			bool flag = string_0 != null && !(string_0 == string.Empty);
			int result;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					' ',
					',',
					'=',
					'\t'
				});
				int num = 1;
				for (;;)
				{
					bool flag2 = num < array.Length;
					if (!flag2)
					{
						goto IL_65;
					}
					bool flag3 = array[num] != null && array[num] != string.Empty;
					if (flag3)
					{
						break;
					}
					num++;
				}
				return Class12.smethod_11(array[num]);
				IL_65:
				result = 0;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000612A0 File Offset: 0x0005F4A0
		private static uint[] smethod_8(string string_0)
		{
			bool flag = string_0 != null && !(string_0 == string.Empty);
			uint[] result;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					' ',
					',',
					'=',
					'\t'
				});
				uint[] array2 = new uint[2];
				int num = 0;
				for (int i = 1; i < array.Length; i++)
				{
					bool flag2 = array[i] != string.Empty && array[i] != null;
					if (flag2)
					{
						array2[num] = Class12.smethod_12(array[i]);
						bool flag3 = 1 <= num;
						if (flag3)
						{
							return array2;
						}
						num++;
					}
				}
				result = null;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00061358 File Offset: 0x0005F558
		public static GStruct19 smethod_9(string string_0, int int_0 = 0, string string_1 = null)
		{
			GStruct19 gstruct = new GStruct19
			{
				int_4 = null
			};
			bool flag = string_0 != null && !(string_0 == string.Empty);
			GStruct19 result;
			if (flag)
			{
				string[] array = string_0.Replace("\r\n", "\n").Split(new char[]
				{
					'\r',
					'\n'
				});
				int num = 0;
				int i = -1;
				int num2 = 0;
				gstruct.int_1 = 0;
				gstruct.uint_0 = new uint[array.Length, 2];
				gstruct.string_0 = new string[array.Length];
				gstruct.int_3 = new int[array.Length, 3];
				gstruct.string_1 = string_1;
				gstruct.int_0 = int_0;
				char[] array2 = new char[]
				{
					' ',
					',',
					'\t'
				};
				while (i < array.Length - 1)
				{
					i++;
					string_0 = array[i];
					bool flag2 = string_0 == null || string_0.Length < 2 || (string_0[0] == '/' && string_0[1] == '/');
					if (!flag2)
					{
						bool flag3 = string_0 == "0 0" || string_0 == "0,0";
						if (flag3)
						{
							num2++;
						}
						int num3 = num2;
						int num4 = num3;
						if (num4 != 1)
						{
							if (num4 == 2)
							{
								break;
							}
							int num5 = -1;
							for (int j = 0; j < array2.Length; j++)
							{
								int num6 = string_0.IndexOf(array2[j]);
								bool flag4 = 0 <= num6 && (num5 < 0 || num6 < num5);
								if (flag4)
								{
									num5 = num6;
								}
							}
							bool flag5 = num5 < 0;
							if (!flag5)
							{
								string text = string_0.Substring(0, num5);
								string text2 = text.ToUpper();
								string a = text2;
								if (!(a == "POSOUT"))
								{
									if (!(a == "RATIOOUT"))
									{
										if (!(a == "MAPID"))
										{
											if (!(a == "RATIOIN"))
											{
												if (!(a == "POSIN"))
												{
													uint num7 = Class12.smethod_12(text);
													uint num8 = 0U;
													string text3 = string.Empty;
													do
													{
														string_0 = string_0.Substring(num5 + 1);
														num5 = -1;
														for (int k = 0; k < array2.Length; k++)
														{
															int num9 = string_0.IndexOf(array2[k]);
															bool flag6 = 0 <= num9 && (num5 < 0 || num9 < num5);
															if (flag6)
															{
																num5 = num9;
															}
														}
													}
													while (num5 == 0);
													bool flag7 = num5 > 0;
													if (flag7)
													{
														string string_2 = string_0.Substring(0, num5);
														num8 = Class12.smethod_12(string_2);
														bool flag8 = num5 + 1 < string_0.Length;
														if (flag8)
														{
															text3 = string_0.Substring(num5 + 1);
														}
													}
													bool flag9 = num7 != 0U && num8 > 0U;
													if (flag9)
													{
														gstruct.uint_0[gstruct.int_1, 0] = num7;
														gstruct.uint_0[gstruct.int_1, 1] = num8;
														gstruct.string_0[gstruct.int_1] = text3;
														gstruct.int_1++;
													}
												}
												else
												{
													gstruct.uint_1 = Class42.smethod_8(string_0);
												}
											}
											else
											{
												gstruct.int_5 = Class42.smethod_7(string_0);
											}
										}
										else
										{
											gstruct.int_0 = Class42.smethod_7(string_0);
										}
									}
									else
									{
										gstruct.int_6 = Class42.smethod_7(string_0);
									}
								}
								else
								{
									gstruct.uint_2 = Class42.smethod_8(string_0);
								}
							}
						}
						else
						{
							string[] array3 = string_0.Split(new char[]
							{
								' ',
								','
							});
							bool flag10 = array3.Length < 2 || (array3[0] == "0" && array3[1] == "0");
							if (!flag10)
							{
								int num10 = Class12.smethod_11(array3[0]);
								int num11 = Class12.smethod_11(array3[1]);
								bool flag11 = gstruct.int_1 > num10 && gstruct.int_1 > num11;
								if (flag11)
								{
									bool flag12 = array3.Length >= 3;
									int num12;
									if (flag12)
									{
										num12 = Class12.smethod_11(array3[2]);
									}
									else
									{
										uint[] uint_ = new uint[]
										{
											gstruct.uint_0[num10, 0],
											gstruct.uint_0[num10, 1]
										};
										uint[] uint_2 = new uint[]
										{
											gstruct.uint_0[num11, 0],
											gstruct.uint_0[num11, 1]
										};
										num12 = (int)Math.Sqrt((double)Class42.smethod_6(uint_, uint_2));
									}
									bool flag13 = 0 <= num10 && num10 != num11 && num12 > 0;
									if (flag13)
									{
										gstruct.int_3[num, 0] = num10;
										gstruct.int_3[num, 1] = num11;
										gstruct.int_3[num, 2] = num12;
										num++;
									}
								}
							}
						}
					}
				}
				bool flag14 = gstruct.int_1 == 0 || num == 0;
				if (flag14)
				{
					result = gstruct;
				}
				else
				{
					gstruct.int_4 = new int[gstruct.int_1, gstruct.int_1];
					for (int l = 0; l < gstruct.int_1; l++)
					{
						for (int m = 0; m < gstruct.int_1; m++)
						{
							bool flag15 = l != m;
							if (flag15)
							{
								gstruct.int_4[l, m] = -1;
							}
						}
					}
					for (int n = 0; n < num; n++)
					{
						int num13 = gstruct.int_3[n, 0];
						int num14 = gstruct.int_3[n, 1];
						int num15 = gstruct.int_3[n, 2];
						bool flag16 = num13 < gstruct.int_1 && num14 < gstruct.int_1;
						if (flag16)
						{
							gstruct.int_4[num13, num14] = num15;
							gstruct.int_4[num14, num13] = num15;
						}
					}
					result = gstruct;
				}
			}
			else
			{
				result = gstruct;
			}
			return result;
		}

		// Token: 0x0400015A RID: 346
		public static GStruct19[] gstruct19_0;

		// Token: 0x0400015B RID: 347
		private static bool bool_0;

		// Token: 0x0400015C RID: 348
		public static bool bool_1;

		// Token: 0x0400015D RID: 349
		private static bool bool_2;
	}
}
