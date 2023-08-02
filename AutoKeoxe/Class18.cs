using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000010 RID: 16
	internal class Class18
	{
		// Token: 0x0600009A RID: 154 RVA: 0x0000E164 File Offset: 0x0000C364
		static Class18()
		{
			uint[,] array_ = new uint[4, 2];
			Class11.smethod_4(array_, 43830);
			Class18.uint_0 = array_;
			uint[,] array_2 = new uint[4, 2];
			Class11.smethod_4(array_2, 43871);
			Class18.uint_1 = array_2;
			uint[,] array_3 = new uint[3, 2];
			Class11.smethod_4(array_3, 43912);
			Class18.uint_2 = array_3;
			uint[,] array_4 = new uint[3, 2];
			Class11.smethod_4(array_4, 43945);
			Class18.uint_3 = array_4;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000E23C File Offset: 0x0000C43C
		public static bool smethod_0(int int_2)
		{
			return int_2 == 959 || int_2 == 991 || int_2 == 990;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000E26C File Offset: 0x0000C46C
		public static int smethod_1(GStruct49 gstruct49_0, bool bool_0 = false, bool bool_1 = false)
		{
			int result = 0;
			int int_ = gstruct49_0.int_136;
			int i = 0;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			long long_ = 0L;
			string object_ = Class18.string_0.ToUpper();
			string str = "ChiÕn Long|H¸i-Qu¶|H¸i Qu¶ H|L­ìng Thñy |nhÆt H¹t-Hoµng|H¸iQu¶";
			int num4 = 0;
			for (;;)
			{
				Thread.Sleep(200);
				int num5 = Class81.smethod_3(Form1.gstruct49_0, int_);
				bool flag = !Class12.bool_0 && num5 >= 0 && Class83.smethod_12(gstruct49_0) <= 0 && Class83.smethod_39(gstruct49_0) > 1;
				if (!flag)
				{
					goto IL_94A;
				}
				bool flag2 = bool_1 || Form1.int_115 > 0;
				if (!flag2)
				{
					goto IL_943;
				}
				gstruct49_0 = Form1.gstruct49_0[num5];
				bool flag3 = Class70.smethod_3(gstruct49_0, Class70.uint_48, 4) > 0 || !gstruct49_0.bool_25 || gstruct49_0.int_20[0] > 0 || gstruct49_0.int_133[0] > 0 || gstruct49_0.bool_54 || gstruct49_0.int_25 > 0 || gstruct49_0.bool_15;
				if (flag3)
				{
					break;
				}
				bool flag4 = bool_0 || Form1.int_20 == 0;
				if (!flag4)
				{
					goto IL_93C;
				}
				uint num6 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				bool flag5 = num6 == 0U;
				if (!flag5)
				{
					uint num7 = Class22.smethod_30(num6 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
					uint num8 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
					bool flag6 = num8 == 0U;
					if (!flag6)
					{
						uint num9 = num8 + num7 * Class53.gstruct51_15.uint_0;
						int num10 = (int)Class22.smethod_30(num9 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
						int num11 = (int)Class22.smethod_30(num9 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
						int num12 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
						int num13 = (int)Class22.smethod_30(num9 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
						bool flag7 = num10 == 10 || num10 == 21 || num11 == 0 || num10 == 0 || num12 == 0;
						if (flag7)
						{
							bool flag8 = num11 == 0 || num10 == 0;
							if (!flag8)
							{
								goto IL_23D;
							}
							num3++;
							bool flag9 = num3 < 10;
							if (!flag9)
							{
								goto IL_23C;
							}
							Thread.Sleep(100);
						}
						else
						{
							num3 = 0;
							uint[] array = new uint[]
							{
								Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							bool flag10 = array[0] == 0U || array[1] == 0U;
							if (!flag10)
							{
								bool flag11 = !Class18.smethod_0(num12);
								if (flag11)
								{
									bool flag12 = num13 <= 0;
									if (flag12)
									{
										string text = null;
										bool flag13 = Class18.int_0 == 1;
										if (flag13)
										{
											text = "La Tiªu|Cæng 1";
										}
										else
										{
											bool flag14 = Class18.int_0 != 2;
											if (flag14)
											{
												bool flag15 = Class18.int_0 == 3;
												if (flag15)
												{
													text = "T­êng V©n|Cæng 3";
												}
											}
											else
											{
												text = "Vò Di|Cæng 2";
											}
										}
										bool flag16 = Class18.int_1 < 0;
										if (flag16)
										{
											Class18.int_1 = 0;
											Class18.string_2 = null;
											bool flag17 = Class35.struct14_0 != null;
											if (flag17)
											{
												int j = 0;
												while (j < Class35.struct14_0.Length)
												{
													bool flag18 = !Class18.smethod_0(Class35.struct14_0[j].int_0);
													if (flag18)
													{
														j++;
													}
													else
													{
														Class18.int_1 = Class35.struct14_0[j].int_0;
														bool flag19 = Class35.struct14_0[j].string_2 == null || !(Class35.struct14_0[j].string_2 != string.Empty);
														if (flag19)
														{
															break;
														}
														string[] array2 = Class35.struct14_0[j].string_2.Split(new char[]
														{
															'|'
														});
														Class18.string_2 = new string[3];
														for (int k = 0; k < Class18.string_2.Length; k++)
														{
															bool flag20 = k < array2.Length;
															if (flag20)
															{
																Class18.string_2[k] = array2[k];
															}
															else
															{
																Class18.string_2[k] = array2[array2.Length - 1];
															}
														}
														break;
													}
												}
											}
										}
										bool flag21 = (Form1.int_110 <= 0 || Form1.int_111 <= 0) && (num4 < 3 || (Form1.int_110 > 0 && Form1.int_111 == 0)) && Class18.int_1 > 0;
										if (flag21)
										{
											bool flag22 = Class18.string_2 != null;
											if (flag22)
											{
												bool flag23 = text != null;
												if (flag23)
												{
													text += "|";
												}
												text = ((Class18.int_0 <= 0) ? (text + Class18.string_2[Class18.random_0.Next(0, 2)]) : (text + Class18.string_2[Class18.int_0 - 1]));
											}
											Class35.smethod_140(gstruct49_0, Class18.int_1, text, null, false);
											Thread.Sleep(100);
											Class86.smethod_8(gstruct49_0, -1);
											num4++;
										}
										else
										{
											int[] array3 = Class60.smethod_9(num12);
											bool flag24 = array3 != null && array3[1] != 0;
											if (flag24)
											{
												goto Block_48;
											}
											Class50.smethod_2(gstruct49_0, str + "|" + text, null, null, 0);
											Class86.smethod_8(gstruct49_0, -1);
										}
										continue;
									}
								}
								else
								{
									bool flag25 = num4 > 0;
									if (flag25)
									{
										num4 = 0;
									}
								}
								bool flag26 = Class18.smethod_0(num12) && Class18.int_0 != 0;
								if (!flag26)
								{
									goto IL_935;
								}
								long num14 = Class60.smethod_21(Class18.uint_1, array);
								long num15 = Class60.smethod_21(Class18.uint_0, array);
								long num16 = Class60.smethod_21(Class18.uint_2, array);
								bool flag27 = (Class18.int_0 != 1 || num16 > num14 || num16 > num15) && (Class18.int_0 != 2 || num14 > num16 || num14 > num15) && (Class18.int_0 != 3 || num15 > num16 || num15 > num14);
								if (!flag27)
								{
									goto IL_92E;
								}
								bool flag28 = Class12.smethod_28(long_) > 3000L;
								if (flag28)
								{
									Class70.smethod_52(gstruct49_0, "§ang chän l¹i cæng lªn cl®...", 1);
									long_ = Class12.smethod_27();
								}
								bool flag29 = Form1.int_110 <= 0 || Form1.int_111 != 0 || Class18.int_1 <= 0;
								if (flag29)
								{
									uint[,] array4 = (num16 <= num15 && num16 <= num14) ? Class18.uint_2 : ((num14 <= num15 && num14 <= num16) ? Class18.uint_1 : Class18.uint_0);
									int length = array4.GetLength(0);
									uint[] array5 = new uint[]
									{
										array4[length - 1, 0],
										array4[length - 1, 1]
									};
									long num17 = Class60.smethod_18(array, array5);
									bool flag30 = num17 > 90000L;
									if (flag30)
									{
										i++;
										bool flag31 = i < 3;
										if (flag31)
										{
											Class56.smethod_11(gstruct49_0, array4, array5, true, 10000, false);
											continue;
										}
									}
									for (i = 0; i < 10; i++)
									{
										array = new uint[]
										{
											Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										bool flag32 = Class60.smethod_18(array, array5) <= 11500L;
										if (flag32)
										{
											break;
										}
										Class70.smethod_61(gstruct49_0, array5);
										Thread.Sleep(300);
									}
									i = 0;
									bool flag33 = num > 0;
									if (!flag33)
									{
										goto IL_811;
									}
									string text2 = Class98.smethod_16(gstruct49_0, num, ref array5, 32);
									bool flag34 = text2 != null && 0 <= Class12.smethod_1(text2.ToUpper(), object_);
									if (flag34)
									{
										goto IL_99D;
									}
									goto IL_811;
									IL_951:
									num2++;
									Thread.Sleep(100);
									bool flag35 = num2 > 10;
									if (flag35)
									{
										Class60.smethod_29(gstruct49_0, true);
										Thread.Sleep(300);
										Class70.smethod_57(gstruct49_0, "Switch([[sit]])");
										Thread.Sleep(300);
										num2 = 0;
									}
									continue;
									IL_99D:
									int num18 = 0;
									byte[] bytes = BitConverter.GetBytes(num);
									Class22.WriteProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_72.uint_0, bytes, 4, ref num18);
									Thread.Sleep(100);
									i = 0;
									while (Class86.smethod_0(gstruct49_0) < 0)
									{
										i++;
										Thread.Sleep(100);
										bool flag36 = i <= 10;
										if (!flag36)
										{
											goto IL_951;
										}
									}
									i = 0;
									Class86.smethod_5(gstruct49_0, 0);
									num = 0;
									continue;
									IL_811:
									num = Class98.smethod_15(gstruct49_0, Class18.string_0, ref array5, 3, false, -1, null);
									bool flag37 = num > 0;
									if (flag37)
									{
										goto IL_99D;
									}
									goto IL_951;
								}
								else
								{
									string text3 = null;
									bool flag38 = Class18.int_0 != 1;
									if (flag38)
									{
										bool flag39 = Class18.int_0 != 2;
										if (flag39)
										{
											bool flag40 = Class18.int_0 == 3;
											if (flag40)
											{
												text3 = "T­êng V©n|Cæng 3";
											}
										}
										else
										{
											text3 = "Vò Di|Cæng 2";
										}
									}
									else
									{
										text3 = "La Tiªu|Cæng 1";
									}
									bool flag41 = Class18.string_2 != null;
									if (flag41)
									{
										bool flag42 = text3 != null;
										if (flag42)
										{
											text3 += "|";
										}
										text3 = ((Class18.int_0 > 0) ? (text3 + Class18.string_2[Class18.int_0 - 1]) : (text3 + Class18.string_2[Class18.random_0.Next(0, 2)]));
									}
									GStruct49 gstruct49_ = gstruct49_0;
									object object_2 = Class18.int_1;
									string str2 = text3;
									string[] array6 = Class18.string_2;
									bool flag43 = Class35.smethod_140(gstruct49_, object_2, str2 + ((array6 != null) ? array6.ToString() : null), null, false);
									if (flag43)
									{
										Class86.smethod_8(gstruct49_0, -1);
										num4++;
									}
								}
							}
						}
					}
				}
			}
			return result;
			IL_23C:
			IL_23D:
			return -1;
			Block_48:
			Class50.smethod_7(gstruct49_0);
			return -2;
			IL_92E:
			return 1;
			IL_935:
			return 1;
			IL_93C:
			return 1;
			IL_943:
			return -1;
			IL_94A:
			result = -1;
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		public static uint[] smethod_2(GStruct49 gstruct49_0)
		{
			uint[,] array = new uint[4, 2];
			Class11.smethod_4(array, 43585);
			uint[,] array2 = array;
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2;
			Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num4 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
			int num5 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag = Class18.smethod_0(num5);
			uint[] result;
			if (flag)
			{
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				int num6 = Class60.smethod_20(array2, array3);
				bool flag2 = num6 < 0;
				if (flag2)
				{
					result = null;
				}
				else
				{
					uint[] array4 = new uint[]
					{
						array2[num6, 0],
						array2[num6, 1]
					};
					long num7 = Class60.smethod_18(array3, array4);
					bool flag3 = num7 <= 90000L;
					if (flag3)
					{
						long long_ = Class12.smethod_27();
						while (!Class12.bool_0)
						{
							array3 = new uint[]
							{
								Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							num7 = Class60.smethod_18(array3, array4);
							bool flag4 = num7 < 22500L;
							if (flag4)
							{
								break;
							}
							bool flag5 = Class12.smethod_28(long_) <= 6000L;
							if (!flag5)
							{
								return null;
							}
							uint num8 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag6 = (ulong)num8 == (ulong)((long)num5);
							if (!flag6)
							{
								return null;
							}
							Class70.smethod_61(gstruct49_0, array4);
							Thread.Sleep(300);
						}
						string text = "ruyÒn tèng";
						int num9 = Class98.smethod_13(gstruct49_0, text, 3, false, -1, 80);
						bool flag7 = num9 > 0;
						if (flag7)
						{
							bool flag8 = false;
							for (;;)
							{
								Class86.smethod_8(gstruct49_0, -1);
								Thread.Sleep(100);
								int num10 = 0;
								byte[] bytes = BitConverter.GetBytes(num9);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, bytes, 4, ref num10);
								Thread.Sleep(100);
								for (int i = 0; i < 10; i++)
								{
									Thread.Sleep(150);
									bool flag9 = 0 <= Class86.smethod_0(gstruct49_0) && Class86.smethod_1(gstruct49_0, -1) > 0;
									if (flag9)
									{
										goto Block_9;
									}
								}
								bool flag10 = flag8;
								if (flag10)
								{
									goto Block_11;
								}
								flag8 = true;
							}
							Block_9:
							Class70.smethod_59(gstruct49_0, 0, 0);
							return null;
							Block_11:
							result = null;
						}
						else
						{
							result = null;
						}
					}
					else
					{
						result = array4;
					}
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0400005D RID: 93
		private static string string_0 = "truyÒn tèng";

		// Token: 0x0400005E RID: 94
		public static string[] string_1 = new string[]
		{
			"Bất kỳ",
			"La tiêu sơn",
			"Vũ di sơn",
			"Tường vân động"
		};

		// Token: 0x0400005F RID: 95
		public static int int_0 = Class62.smethod_3("IndexChienlongdong", 0, "0");

		// Token: 0x04000060 RID: 96
		public static int int_1 = -1;

		// Token: 0x04000061 RID: 97
		private static string[] string_2 = null;

		// Token: 0x04000062 RID: 98
		private static Random random_0 = new Random();

		// Token: 0x04000063 RID: 99
		private static uint[,] uint_0;

		// Token: 0x04000064 RID: 100
		private static uint[,] uint_1;

		// Token: 0x04000065 RID: 101
		private static uint[,] uint_2;

		// Token: 0x04000066 RID: 102
		private static uint[,] uint_3;
	}
}
