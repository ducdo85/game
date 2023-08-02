using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200001E RID: 30
	internal class Class34
	{
		// Token: 0x06000183 RID: 387 RVA: 0x0001E924 File Offset: 0x0001CB24
		public static int[] smethod_0(GStruct49 gstruct49_0)
		{
			bool flag = Class79.smethod_25(gstruct49_0, 3U) == 0;
			int[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int[] array = new int[]
				{
					100,
					100,
					100
				};
				bool flag2 = gstruct49_0.int_71[0] > 0 && gstruct49_0.int_71[2] > 0 && gstruct49_0.string_11 != null && gstruct49_0.string_11 != string.Empty;
				if (flag2)
				{
					array[0] = Class79.smethod_31(gstruct49_0, gstruct49_0.string_11, 3, false, false);
				}
				bool flag3 = gstruct49_0.int_72[0] > 0 && gstruct49_0.int_72[2] > 0 && gstruct49_0.string_12 != null && gstruct49_0.string_12 != string.Empty;
				if (flag3)
				{
					array[1] = Class79.smethod_31(gstruct49_0, gstruct49_0.string_12, 3, false, false);
				}
				bool flag4 = gstruct49_0.int_73[0] > 0 && gstruct49_0.int_73[2] > 0 && gstruct49_0.string_13 != null && gstruct49_0.string_13 != string.Empty;
				if (flag4)
				{
					array[2] = Class79.smethod_31(gstruct49_0, gstruct49_0.string_13, 3, false, false);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001EA38 File Offset: 0x0001CC38
		public static int smethod_1(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			string[] array = new string[]
			{
				gstruct49_0.string_11,
				gstruct49_0.string_12,
				gstruct49_0.string_13
			};
			int[,] array2 = new int[3, 3];
			array2[0, 0] = gstruct49_0.int_71[0];
			array2[0, 1] = gstruct49_0.int_71[2];
			array2[1, 0] = gstruct49_0.int_72[0];
			array2[1, 1] = gstruct49_0.int_72[2];
			array2[2, 0] = gstruct49_0.int_73[0];
			array2[2, 1] = gstruct49_0.int_73[2];
			int[,] array3 = array2;
			bool flag = false;
			for (int i = 0; i < array3.GetLength(0); i++)
			{
				bool flag2 = array3[i, 0] > 0 && array[i] != null && !(array[i] == string.Empty);
				if (flag2)
				{
					int num = Class79.smethod_31(gstruct49_0, array[i].Trim(), 3, false, false);
					array3[i, 2] = array3[i, 1] - num;
					bool flag3 = array3[i, 2] > 0 && (bool_0 || num <= Form1.int_54);
					if (flag3)
					{
						flag = true;
					}
				}
			}
			int result = 1;
			bool flag4 = flag;
			if (flag4)
			{
				result = -1;
				for (int j = 0; j < array3.GetLength(0); j++)
				{
					bool flag5 = array3[j, 2] <= 0;
					if (!flag5)
					{
						try
						{
							int num2 = Class34.smethod_2(gstruct49_0, Class17.string_0[j], array[j], array3[j, 2]);
							bool flag6 = num2 > 0;
							if (flag6)
							{
								result = 1;
							}
							bool flag7 = num2 != -2;
							if (flag7)
							{
								goto IL_1B1;
							}
						}
						catch
						{
							Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
							goto IL_1B1;
						}
						break;
					}
					IL_1B1:;
				}
			}
			return result;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001EC28 File Offset: 0x0001CE28
		public static int smethod_2(GStruct49 gstruct49_0, string string_0, string string_1, int int_0)
		{
			Struct23[] array = Class83.smethod_1(gstruct49_0);
			bool flag = array == null;
			int result;
			if (flag)
			{
				Class70.smethod_52(gstruct49_0, "Khong the su dung chuc nang mua o Bao vat.", 1);
				Thread.Sleep(1000);
				result = 1;
			}
			else
			{
				int num = -1;
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2 = string_0 == array[i].string_0;
					if (flag2)
					{
						num = i;
						break;
					}
				}
				bool flag3 = num >= 0;
				if (flag3)
				{
					string_1 = string_1.Trim().ToLower();
					int num2 = -1;
					int num3 = array[num].int_0 - array[0].int_0;
					Class70.smethod_26(gstruct49_0, string_0);
					Thread.Sleep(300);
					Class70.smethod_27(gstruct49_0);
					GStruct1[] array2 = Class17.smethod_1(gstruct49_0);
					bool flag4 = array2 != null && array2.Length != 0;
					if (flag4)
					{
						for (int j = 0; j < array2.Length; j++)
						{
							bool flag5 = string_1 == array2[j].string_0.ToLower().Trim();
							if (flag5)
							{
								num2 = array2[j].int_0;
								break;
							}
						}
						bool flag6 = num2 < 0;
						if (flag6)
						{
							result = -1;
						}
						else
						{
							int k = 0;
							uint num4 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
							while (k < 4)
							{
								uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
								bool flag7 = num5 > 0U;
								if (flag7)
								{
									uint num6 = Class22.smethod_30(num5 + (uint)(k * 4), gstruct49_0.int_137);
									bool flag8 = num6 != 0U && Class22.smethod_30(num6, gstruct49_0.int_137) > 0U;
									if (flag8)
									{
										Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
										Thread.Sleep(100);
									}
								}
								k++;
							}
							int num7 = 0;
							byte[] array3 = new byte[15];
							for (int l = 1; l < 60; l++)
							{
								bool flag9 = l % 5 == 0;
								if (flag9)
								{
									int num8 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
									bool flag10 = Class12.bool_0 || num8 < 0 || !Form1.gstruct49_0[num8].bool_25;
									if (flag10)
									{
										return -2;
									}
								}
								int num9 = Class79.smethod_4(gstruct49_0);
								Class70.smethod_28(gstruct49_0, num2, num3 + Form1.int_5);
								Thread.Sleep(100);
								k = 0;
								bool flag11 = false;
								while (k < 80)
								{
									bool flag12 = num9 == Class79.smethod_4(gstruct49_0);
									if (!flag12)
									{
										flag11 = true;
										int_0--;
										break;
									}
									Thread.Sleep(10);
									k++;
								}
								bool flag13 = !flag11 || int_0 <= 0;
								if (flag13)
								{
									break;
								}
								uint num10 = Class22.smethod_30(num4 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
								bool flag14 = num10 == 0U;
								if (!flag14)
								{
									uint num11 = Class22.smethod_30(num10, gstruct49_0.int_137);
									bool flag15 = num11 > 0U;
									if (flag15)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num11, array3, array3.Length, ref num7);
										string text = Class10.smethod_3(array3);
										bool flag16 = text != string.Empty && Class12.smethod_1(text, "kh«ng") > 0;
										if (flag16)
										{
											break;
										}
										Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
										Thread.Sleep(100);
									}
								}
							}
							result = 1;
						}
					}
					else
					{
						result = -1;
					}
				}
				else
				{
					Class70.smethod_52(gstruct49_0, "Kh«ng thÓ mua ë b¶o vËt, bÊm nót <KTC, B¶o vËt> cña auto ®Ó chän l¹i.", 1);
					Thread.Sleep(1000);
					result = 1;
				}
			}
			return result;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
		public static int smethod_3(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			int result;
			for (;;)
			{
				try
				{
					bool flag = gstruct49_0.int_77 > 0;
					if (flag)
					{
						Class34.smethod_1(gstruct49_0, false);
						result = 1;
						break;
					}
					result = Class34.smethod_4(gstruct49_0, bool_0);
					break;
				}
				catch
				{
					Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
				}
			}
			return result;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001F040 File Offset: 0x0001D240
		private static int smethod_4(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_32 * 4U, array, 1, ref num);
			bool flag = array[0] > 0;
			int result;
			if (flag)
			{
				result = 1;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num2 = BitConverter.ToInt32(array, 0);
				bool flag2 = Class56.smethod_1(num2) != null;
				if (flag2)
				{
					result = 1;
				}
				else
				{
					byte[] byte_ = new byte[4];
					byte[] array2 = new byte[3];
					int num3 = 0;
					int num4 = 0;
					int num5 = 0;
					int num6 = 0;
					int num7 = 0;
					int num8 = 0;
					int num9 = 0;
					int num10 = 0;
					int num11 = 0;
					int num12 = 0;
					int num13 = 0;
					int num14 = -1;
					int num15 = 0;
					int num16 = 0;
					int num17 = 0;
					int i = 0;
					int num18 = 0;
					int num19 = 0;
					int num20 = 0;
					int num21 = 0;
					int num22 = 0;
					int num23 = 0;
					long long_ = 0L;
					string text = null;
					string b = null;
					uint[] array3 = null;
					string string_ = "Giao|ua d­îc p|Më shop|Trao ®æi|chØ ®Õn";
					GStruct1[] array4 = null;
					int num24 = 0;
					for (;;)
					{
						IL_175E:
						Thread.Sleep(300);
						int num25 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
						bool flag3 = !Class12.bool_0 && num25 >= 0 && Form1.gstruct49_0[num25].bool_25 && !Form1.bool_4;
						if (!flag3)
						{
							goto IL_78E;
						}
						bool flag4 = num17 > 0;
						if (flag4)
						{
							Form1.gstruct49_0[num25].int_70 = 0;
							num17 = 0;
						}
						gstruct49_0 = Form1.gstruct49_0[num25];
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
						uint num26 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_13.uint_0, array, 4, ref num);
						uint num27 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
						uint num28 = BitConverter.ToUInt32(array, 0);
						uint num29 = num28 + num27;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_50.uint_0, array, 4, ref num);
						int num30 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_55.uint_0, array, 4, ref num);
						int num31 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_43.uint_0, array, 4, ref num);
						int num32 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
						num2 = BitConverter.ToInt32(array, 0);
						int num33 = Class83.smethod_39(gstruct49_0);
						bool flag5 = num30 != 0 && num31 != 0 && num2 != 0 && num33 > 1 && num31 != 10 && num31 != 21;
						if (flag5)
						{
							num9 = 0;
							bool flag6 = gstruct49_0.int_79 > 0 && Form1.int_96 > 0 && num23 == 0;
							if (flag6)
							{
								num23 = 1;
								string text2 = Form1.string_30;
								bool flag7 = gstruct49_0.string_11 != null && gstruct49_0.string_11 != string.Empty;
								if (flag7)
								{
									bool flag8 = text2 != null && text2 != string.Empty;
									if (flag8)
									{
										text2 += "|";
									}
									text2 += gstruct49_0.string_11;
								}
								bool flag9 = text2 != null && text2 != string.Empty;
								if (flag9)
								{
									bool flag10 = Class34.smethod_6(gstruct49_0, text2) != 1;
									if (flag10)
									{
										num16 = 2;
									}
									continue;
								}
							}
							int num34 = Class79.smethod_25(gstruct49_0, 3U);
							bool flag11 = num34 != 0;
							if (!flag11)
							{
								goto IL_767;
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
							num2 = BitConverter.ToInt32(array, 0);
							bool flag12 = num14 != num2 && num4 > 0 && num14 > 0;
							if (flag12)
							{
								num4 = 0;
								num14 = num2;
								Class91.smethod_0(gstruct49_0, true, null);
							}
							else
							{
								string text3 = Class22.smethod_28(gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct49_0.int_137, 20);
								bool flag13 = num2 == 540 || num2 == 541 || num2 == 542 || 0 <= Class12.smethod_1(text3, "tr­êng §¹") || 0 <= Class12.smethod_1(text3.ToLower(), "tr­êng li".ToLower());
								bool flag14 = num2 == 13;
								bool flag15 = num2 == 333;
								if (flag15)
								{
									Class12.smethod_1(text3, "Hoa");
								}
								string string_2 = (num2 == 977 && (0 <= Class12.smethod_1(text3, "Cæ") || 0 <= Class12.smethod_1(text3, "Hßa B"))) ? "Qu©n Nhu|D­îc §iÕm|d­îc ®iÕm|¸n thuèc|D­îc th­¬ng|iÖu thuèc|HËu cÇn H|u doanh q|ThÇn Y|D­îc S­" : ((flag14 && gstruct49_0.int_70 > 0) ? "DiÖu KhiÕt" : "D­îc §iÕm|d­îc ®iÕm|¸n thuèc|D­îc th­¬ng|iÖu thuèc|HËu cÇn H|u doanh q|ThÇn Y|D­îc S­");
								uint[] array5 = new uint[]
								{
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								int num35 = 0;
								bool flag16 = gstruct49_0.int_78 > 0 && num15 == 0 && Form1.int_125 != null && Form1.string_30 != null && Form1.string_30 != string.Empty;
								if (flag16)
								{
									int num36 = Class79.smethod_31(gstruct49_0, Form1.string_30, 3, false, false);
									bool flag17 = num36 <= Form1.int_54;
									if (flag17)
									{
										text = Form1.string_30;
										num15 = 1;
										num21 = 1;
										num35 = 1;
									}
								}
								bool flag18 = num15 != 1;
								if (flag18)
								{
									num19 = -1;
									num20 = -1;
									for (int j = 0; j < 3; j++)
									{
										int num37 = j;
										int num38 = num37;
										int[] array6;
										if (num38 != 0)
										{
											if (num38 != 1)
											{
												array6 = gstruct49_0.int_73;
												text = gstruct49_0.string_13;
											}
											else
											{
												array6 = gstruct49_0.int_72;
												text = gstruct49_0.string_12;
											}
										}
										else
										{
											array6 = gstruct49_0.int_71;
											text = gstruct49_0.string_11;
										}
										bool flag19 = array2[j] > 0 || array6[0] <= 0 || array6[2] <= 0 || array6 == null || text == null || text == string.Empty || 0 <= text.IndexOf("H·y mua");
										if (!flag19)
										{
											int num39 = Class79.smethod_31(gstruct49_0, text, 3, false, false);
											int num40 = array6[2] - num39;
											bool flag20 = num40 <= 0 || (num39 > Form1.int_54 && (num22 != 2 || j != 0));
											if (!flag20)
											{
												bool flag21 = j == 0;
												if (flag21)
												{
													num35 = 1;
												}
												num19 = num40;
												num20 = j;
												break;
											}
											array2[j] = 1;
										}
									}
									bool flag22 = num19 <= 0;
									if (flag22)
									{
										break;
									}
									bool flag23 = array4 != null && Class45.smethod_8(gstruct49_0);
									if (flag23)
									{
										goto IL_13FC;
									}
								}
								bool flag24 = num13 == 0;
								if (flag24)
								{
									bool flag25 = Class45.smethod_8(gstruct49_0);
									if (flag25)
									{
										Class45.smethod_11(gstruct49_0);
									}
									Class22.WriteProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
									Class70.smethod_2(gstruct49_0, Class70.uint_32, 257, 4);
									num13 = 1;
									Class70.smethod_52(gstruct49_0, "<color=green><bclr=blue>* Mua thuèc...", 1);
								}
								bool flag26 = i > 0;
								if (!flag26)
								{
									goto IL_762;
								}
								string a = Class98.smethod_16(gstruct49_0, i, ref array3, 40);
								bool flag27 = a == b;
								if (!flag27)
								{
									goto IL_762;
								}
								IL_796:
								num5 = 0;
								array5 = new uint[]
								{
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								long num41 = Class60.smethod_18(array5, array3);
								bool flag28 = num41 <= 300000L;
								if (!flag28)
								{
									Class60.smethod_29(gstruct49_0, false);
									bool flag29 = num10 < 5;
									if (flag29)
									{
										uint[,] array7 = Class42.smethod_1(num2, array5, array3, null, false);
										bool flag30 = array7 != null;
										if (flag30)
										{
											num10++;
											bool flag31 = 0 <= Class60.smethod_22(gstruct49_0, array7, array5, array3, num2, false, 16000, false);
											if (flag31)
											{
												num10 = 0;
											}
											continue;
										}
									}
									bool flag32 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_) > 6000L;
									if (flag32)
									{
										Class14.smethod_1(gstruct49_0, array3);
										long_ = Class12.smethod_27();
									}
									continue;
								}
								array5 = new uint[]
								{
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								int num42 = 0;
								while (!Class12.bool_0)
								{
									Class70.smethod_61(gstruct49_0, array3);
									Thread.Sleep(300);
									array5 = new uint[]
									{
										Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									bool flag33 = Class60.smethod_18(array5, array3) < 22500L;
									if (flag33)
									{
										break;
									}
									num42++;
									bool flag34 = num42 <= 15;
									if (!flag34)
									{
										goto IL_905;
									}
								}
								IL_D46:
								while (i > 0)
								{
									bool flag35 = Class45.smethod_8(gstruct49_0);
									if (flag35)
									{
										Class45.smethod_11(gstruct49_0);
									}
									Class86.smethod_8(gstruct49_0, -1);
									Class86.Class89.smethod_1(gstruct49_0, null);
									Thread.Sleep(100);
									Class36.smethod_10(gstruct49_0, (uint)i);
									Thread.Sleep(150);
									num42 = 0;
									bool flag36 = Class45.smethod_8(gstruct49_0);
									for (;;)
									{
										bool flag37 = Class86.smethod_0(gstruct49_0) < 0 && !flag36;
										if (!flag37)
										{
											break;
										}
										num42++;
										Thread.Sleep(100);
										bool flag38 = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) > 0U;
										if (flag38)
										{
											string text4 = Class45.smethod_4(gstruct49_0);
											bool flag39 = text4.IndexOf("è l­în") > 0;
											if (flag39)
											{
												Class45.smethod_3(gstruct49_0, "1");
											}
											else
											{
												Class45.smethod_3(gstruct49_0, null);
											}
										}
										bool flag40 = Class86.Class89.smethod_4(gstruct49_0);
										if (flag40)
										{
											string text5 = Class86.Class89.smethod_0(gstruct49_0);
											Class86.Class89.smethod_5(gstruct49_0);
											bool flag41 = text5.IndexOf("h­ëng m«n c") > 0 && num2 == 13;
											if (flag41)
											{
												goto Block_75;
											}
										}
										bool flag42 = flag36 == Class45.smethod_8(gstruct49_0);
										if (!flag42)
										{
											break;
										}
										bool flag43 = num42 < 10;
										if (!flag43)
										{
											goto IL_A55;
										}
									}
									IL_A5E:
									num7 = 0;
									bool flag44 = num12 < 3;
									if (flag44)
									{
										bool flag45 = gstruct49_0.string_15 != null && gstruct49_0.string_15 != string.Empty;
										if (flag45)
										{
											uint num43 = Class12.smethod_12(gstruct49_0.string_15);
											bool flag46 = num43 > 0U;
											if (flag46)
											{
												Class70.smethod_117(gstruct49_0, num43);
												Thread.Sleep(300);
											}
										}
										uint num44 = num26 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
										long num45 = (long)((ulong)Class22.smethod_30(num44 + Class53.gstruct51_74.uint_0, gstruct49_0.int_137));
										bool flag47 = num45 > 0L;
										if (flag47)
										{
											bool flag48 = Form1.int_61[0] <= 0;
											if (flag48)
											{
												bool flag49 = num45 > 6000000L;
												if (flag49)
												{
													num45 = 6000000L;
												}
											}
											else
											{
												bool flag50 = num45 > (long)(Form1.int_61[1] * 10000);
												if (flag50)
												{
													num45 = (long)(Form1.int_61[1] * 10000);
												}
											}
											Class70.smethod_37(gstruct49_0, (uint)num45);
											Thread.Sleep(300);
										}
										num12 = 3;
									}
									int num46 = Class79.smethod_4(gstruct49_0);
									bool flag51 = num15 != 1 || 0 > Class86.smethod_0(gstruct49_0);
									if (flag51)
									{
										bool flag52 = Class86.smethod_6(gstruct49_0, string_, false, false, false, false) > 0;
										flag36 = Class45.smethod_8(gstruct49_0);
										bool flag53 = !flag52 && !flag36;
										if (flag53)
										{
											bool flag54 = num18 == 0;
											if (flag54)
											{
												num18 = 1;
												string string_3 = "Mua M¸u";
												bool flag55 = Class86.smethod_6(gstruct49_0, string_3, false, false, false, false) <= 0;
												if (flag55)
												{
													Class86.smethod_5(gstruct49_0, 0);
												}
												int num47 = 0;
												while (num47 < 10 && !Class45.smethod_8(gstruct49_0))
												{
													num47++;
													Thread.Sleep(60);
												}
											}
											Class86.smethod_8(gstruct49_0, -1);
										}
										num42 = 0;
										flag36 = Class45.smethod_8(gstruct49_0);
										while (!flag36)
										{
											num42++;
											bool flag56 = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) > 0U;
											if (flag56)
											{
												string text6 = Class45.smethod_4(gstruct49_0);
												bool flag57 = text6.IndexOf("è l­în") > 0;
												if (flag57)
												{
													Class45.smethod_3(gstruct49_0, "1");
												}
												else
												{
													Class45.smethod_3(gstruct49_0, null);
												}
											}
											Thread.Sleep(100);
											flag36 = Class45.smethod_8(gstruct49_0);
											bool flag58 = num42 < 10;
											if (!flag58)
											{
												num8++;
												bool flag59 = num8 == 2;
												if (flag59)
												{
													i = 0;
													Class60.smethod_12(gstruct49_0, true);
													goto IL_175E;
												}
												bool flag60 = num8 <= 3;
												if (flag60)
												{
													goto IL_D46;
												}
												goto IL_D15;
											}
										}
										num21 = 2;
										goto IL_13FC;
									}
									num24 = 1;
									Class70.smethod_52(gstruct49_0, "* mua miÔn phÝ...", 1);
									int num48 = 0;
									bool flag61 = Form1.int_125 != null;
									if (flag61)
									{
										for (int k = 0; k < Form1.int_125.Length; k++)
										{
											bool flag62 = Form1.int_125[k] > 0;
											if (flag62)
											{
												Class86.smethod_5(gstruct49_0, Form1.int_125[k] - 1);
												Thread.Sleep(450);
												num48++;
											}
										}
									}
									bool flag63 = num48 == 0 || 0 <= Class86.smethod_0(gstruct49_0);
									if (flag63)
									{
										Class86.smethod_5(gstruct49_0, 0);
										Thread.Sleep(450);
									}
									int l = 0;
									int num49 = 0;
									while (l < 8)
									{
										bool flag64 = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) != 0U && !Class45.smethod_3(gstruct49_0, null);
										if (flag64)
										{
											bool flag65 = Form1.int_97 <= 0 && Class12.smethod_9(Class45.smethod_6(gstruct49_0)) != num34;
											if (flag65)
											{
												int num50 = num34;
												bool flag66 = num50 <= 0;
												if (flag66)
												{
													num50 = 99;
												}
												Class45.smethod_5(gstruct49_0, num50.ToString(), true);
											}
											else
											{
												Class22.smethod_4(gstruct49_0.uint_4, 13U);
											}
											num49 = 1;
										}
										bool flag67 = Class79.smethod_4(gstruct49_0) <= num46;
										if (!flag67)
										{
											Thread.Sleep(300);
											bool flag68 = 0 <= Class86.smethod_0(gstruct49_0);
											if (flag68)
											{
												int num51 = Class86.smethod_1(gstruct49_0, -1);
												Class86.smethod_5(gstruct49_0, num51 - 1);
											}
											break;
										}
										bool flag69 = num49 > 0;
										if (flag69)
										{
											num49++;
											bool flag70 = num49 > 10;
											if (flag70)
											{
												break;
											}
										}
										Thread.Sleep(100 + Class86.int_0);
										l++;
									}
									bool flag71 = num16 > 1 || Class79.smethod_4(gstruct49_0) <= num46;
									if (flag71)
									{
										num15 = 2;
										goto IL_175E;
									}
									goto IL_FC3;
									goto IL_A5E;
									IL_A55:
									num7++;
									bool flag72 = num7 == 2;
									if (flag72)
									{
										i = 0;
										Class60.smethod_12(gstruct49_0, true);
										goto IL_175E;
									}
									bool flag73 = num7 <= 3;
									if (flag73)
									{
										continue;
									}
									goto IL_D41;
									Block_75:
									Class70.smethod_52(gstruct49_0, "<color=yellow>Kh«ng thÓ mua m¸u ë Nga my !...", 1);
									num17 = 1;
									i = 0;
									goto IL_175E;
								}
								bool flag74 = num11 == 0;
								if (!flag74)
								{
									goto IL_D6B;
								}
								num11++;
								IL_1268:
								bool flag75 = gstruct49_0.int_70 > 0;
								if (!flag75)
								{
									goto IL_12E4;
								}
								bool flag76 = num2 == 13;
								if (!flag76)
								{
									bool flag77 = num6 < 3 && num2 != 13 && Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0;
									if (flag77)
									{
										num6++;
										bool flag78 = Class35.smethod_140(gstruct49_0, 13, null, null, false);
										if (flag78)
										{
											Class60.smethod_11(gstruct49_0, 15000);
											Thread.Sleep(100);
										}
										continue;
									}
									goto IL_12E4;
								}
								IL_E4D:
								b = null;
								array3 = null;
								i = Class98.smethod_15(gstruct49_0, string_2, ref array3, 3, false, -1, null);
								bool flag79 = i <= 0;
								if (flag79)
								{
									bool flag80 = num32 > 0;
									if (flag80)
									{
										goto Block_110;
									}
									bool flag81 = num2 == 13;
									if (flag81)
									{
										array3 = new uint[]
										{
											61929U,
											157207U
										};
									}
									else
									{
										bool flag82 = flag13;
										if (flag82)
										{
											array3 = new uint[]
											{
												49792U,
												97600U
											};
										}
										else
										{
											int num52 = Class42.smethod_2(num2);
											bool flag83 = 0 <= num52;
											if (flag83)
											{
												array3 = Class42.smethod_3(Class42.gstruct19_0[num52], array5, "HIEUTHUOC", false);
											}
											bool flag84 = array3 == null;
											if (flag84)
											{
												array3 = Class43.smethod_10(array5, num2, "HIEUTHUOC", true);
											}
										}
									}
									bool flag85 = array3 == null;
									if (flag85)
									{
										goto Block_115;
									}
								}
								else
								{
									b = Class98.smethod_16(gstruct49_0, i, ref array3, 40);
								}
								goto IL_796;
								IL_12E4:
								int[] array8 = Class60.smethod_9(num2);
								bool flag86 = bool_0 && array8 != null && array8[1] != 0;
								if (flag86)
								{
									int num53 = 1;
									bool flag87 = array8 != null;
									if (flag87)
									{
										num53 = Class60.int_0[array8[0], 0];
									}
									num4 = 1;
									bool flag88 = num5 < 3 && Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0;
									if (flag88)
									{
										string string_4 = "t©m";
										bool flag89 = num14 <= 0;
										if (flag89)
										{
											bool flag90 = num53 == 11 || num53 == 176;
											if (flag90)
											{
												string_4 = "®«ng|§«ng";
											}
										}
										else
										{
											string_4 = null;
										}
										num5++;
										bool flag91 = Class35.smethod_140(gstruct49_0, num53, string_4, null, false);
										if (flag91)
										{
											Class60.smethod_11(gstruct49_0, 15000);
											Thread.Sleep(100);
										}
										continue;
									}
									bool flag92 = num3 <= 0;
									if (flag92)
									{
										num3++;
										Class50.smethod_5(gstruct49_0, num53);
										Class60.smethod_11(gstruct49_0, 15000);
										Thread.Sleep(100);
										continue;
									}
								}
								goto IL_E4D;
								IL_762:
								goto IL_1268;
								IL_13FC:
								num24 = 2;
								bool flag93 = array4 == null;
								if (flag93)
								{
									array4 = Class17.smethod_1(gstruct49_0);
									bool flag94 = array4 == null;
									if (flag94)
									{
										goto Block_162;
									}
								}
								int num54 = -1;
								int num55 = -1;
								string a2 = text.Trim();
								string object_ = text.ToUpper();
								bool flag95 = array4 != null;
								if (flag95)
								{
									for (int m = 0; m < array4.Length; m++)
									{
										bool flag96 = 0 <= Class12.smethod_1(array4[m].string_0.ToUpper(), object_);
										if (flag96)
										{
											num55 = array4[m].int_0;
										}
										bool flag97 = a2 == array4[m].string_0.Trim();
										if (flag97)
										{
											num54 = array4[m].int_0;
											break;
										}
									}
								}
								bool flag98 = num54 < 0;
								if (flag98)
								{
									num54 = num55;
									bool flag99 = num54 < 0;
									if (flag99)
									{
										array2[num20] = 1;
										continue;
									}
								}
								int n = 0;
								uint num56 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
								while (n < 6)
								{
									uint num57 = Class22.smethod_30(num56 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
									bool flag100 = num57 > 0U;
									if (flag100)
									{
										uint num58 = Class22.smethod_30(num57 + (uint)(n * 4), gstruct49_0.int_137);
										bool flag101 = num58 != 0U && Class22.smethod_30(num58, gstruct49_0.int_137) > 0U;
										if (flag101)
										{
											Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
											Thread.Sleep(300);
										}
									}
									n++;
								}
								int num59 = 0;
								bool flag102 = false;
								byte[] array9 = new byte[20];
								for (int num60 = 0; num60 < num19; num60++)
								{
									int num61 = Class79.smethod_4(gstruct49_0);
									Class70.smethod_41(gstruct49_0, num54);
									int num62;
									for (num62 = 0; num62 < 30; num62++)
									{
										bool flag103 = Class79.smethod_4(gstruct49_0) == num61;
										if (!flag103)
										{
											num62 = -1;
											num59 = 0;
											break;
										}
										Thread.Sleep(10);
									}
									bool flag104 = num62 == -1;
									if (!flag104)
									{
										num59++;
										bool flag105 = num59 <= 3;
										if (flag105)
										{
											uint num63 = Class22.smethod_30(num56 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
											bool flag106 = num63 == 0U;
											if (!flag106)
											{
												uint num64 = Class22.smethod_30(num63, gstruct49_0.int_137);
												bool flag107 = num64 == 0U;
												if (!flag107)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, num64, array9, array9.Length, ref num);
													string text7 = Class10.smethod_3(array9);
													bool flag108 = text7 != string.Empty;
													if (flag108)
													{
														bool flag109 = Class12.smethod_1(text7, "tói kh«ng") > 0 || Class12.smethod_1(text7, "ho¶ng trèng") > 0;
														if (flag109)
														{
															flag102 = true;
															Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
															break;
														}
														bool flag110 = Class12.smethod_1(text7, "µng kh") > 0 || (Class12.smethod_1(text7, "iÒn") > 0 && Class12.smethod_1(text7, "kh«ng") > 0);
														if (flag110)
														{
															goto Block_182;
														}
													}
													Thread.Sleep(10);
												}
											}
										}
										else
										{
											bool flag111 = Class79.smethod_25(gstruct49_0, 3U) == 0;
											if (!flag111)
											{
												array4 = null;
												goto IL_175E;
											}
											flag102 = true;
											IL_F60:
											bool flag112 = !flag102 || (num20 <= 0 && gstruct49_0.int_79 > 0 && num16 != 2);
											if (flag112)
											{
												bool flag113 = num20 == 0;
												if (flag113)
												{
													num22 = 1;
												}
												goto IL_FC3;
											}
											goto IL_F98;
										}
									}
								}
								goto IL_F60;
								IL_FC3:
								Thread.Sleep(150);
								bool flag114 = num35 <= 0 || gstruct49_0.int_79 <= 0 || num16 >= 2 || text == null || !(text != string.Empty);
								if (!flag114)
								{
									num16 = Class34.smethod_6(gstruct49_0, text);
									bool flag115 = num16 != 1;
									if (flag115)
									{
										num16 = 2;
										bool flag116 = num20 == 0 && num22 == 1;
										if (flag116)
										{
											num22 = 2;
										}
									}
								}
							}
						}
						else
						{
							bool flag117 = num9 < 5;
							if (!flag117)
							{
								goto IL_786;
							}
							num9++;
						}
					}
					int num65 = 1;
					goto IL_1766;
					IL_767:
					num65 = 1;
					goto IL_1766;
					IL_786:
					num65 = -1;
					goto IL_1766;
					IL_78E:
					num65 = 0;
					goto IL_1766;
					IL_905:
					num65 = -3;
					Class60.smethod_12(gstruct49_0, true);
					goto IL_1766;
					IL_D15:
					num65 = -6;
					goto IL_1766;
					IL_D41:
					num65 = -5;
					goto IL_1766;
					IL_D6B:
					num65 = -5;
					goto IL_1766;
					Block_110:
					num65 = 1;
					goto IL_1766;
					Block_115:
					num65 = -2;
					Class60.smethod_10(gstruct49_0, "Chua dinh nghia NPC map nay.");
					goto IL_1766;
					IL_F98:
					num65 = 1;
					goto IL_1766;
					Block_162:
					num65 = -7;
					goto IL_1766;
					Block_182:
					num65 = 1;
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
					IL_1766:
					bool flag118 = num24 > 0 && Form1.int_55 > 0 && Form1.int_57 > 0;
					if (flag118)
					{
						Class79.smethod_37(gstruct49_0, 0, 0, num24 == 1);
					}
					bool flag119 = num21 > 0;
					if (flag119)
					{
						bool flag120 = Class45.smethod_8(gstruct49_0);
						if (flag120)
						{
							Class45.smethod_11(gstruct49_0);
						}
						bool flag121 = gstruct49_0.int_65 > 0;
						if (flag121)
						{
							bool flag122 = true;
							Class60.smethod_3(gstruct49_0, ref flag122);
						}
					}
					bool flag123 = num13 > 0;
					if (flag123)
					{
						Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
						Class70.smethod_52(gstruct49_0, "<color=green><bclr=blue>* KÕt thóc !", 1);
					}
					result = num65;
				}
			}
			return result;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0002084C File Offset: 0x0001EA4C
		private static int smethod_5(string[] string_0, string string_1)
		{
			bool flag = string_0 != null && string_1 != null && !(string_1 == string.Empty);
			int result;
			if (flag)
			{
				string[] array = string_1.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < string_0.Length; i++)
				{
					for (int j = 0; j < array.Length; j++)
					{
						bool flag2 = 0 <= Class12.smethod_1(string_0[i], array[j]);
						if (flag2)
						{
							return i;
						}
					}
				}
				result = -1;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000208DC File Offset: 0x0001EADC
		public static int smethod_6(GStruct49 gstruct49_0, string string_0)
		{
			bool flag = string_0 == null || string_0 == string.Empty;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				int num = 1;
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = array[i].ToLower();
					bool flag2 = num < array[i].Length;
					if (flag2)
					{
						num = array[i].Length;
					}
				}
				int num2 = 0;
				byte[] array2 = new byte[4];
				byte[] array3 = new byte[num + 4];
				long long_ = Class12.smethod_27();
				uint num3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				int num5 = 1;
				uint num6 = 23U;
				int num7 = Class79.smethod_4(gstruct49_0);
				int num8 = 0;
				int num9 = 0;
				uint num10 = 1U;
				while ((ulong)num10 < (ulong)((long)Class53.int_1))
				{
					bool flag3 = Class12.smethod_28(long_) > 3000L;
					if (flag3)
					{
						int num11 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
						bool flag4 = num11 < 0 || !Form1.gstruct49_0[num11].bool_25;
						if (flag4)
						{
							return 0;
						}
						long_ = Class12.smethod_27();
					}
					bool flag5 = !Class12.bool_0;
					if (!flag5)
					{
						return 0;
					}
					bool flag6 = num7 <= num8;
					if (flag6)
					{
						break;
					}
					uint num12 = num3 + num10 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num2);
					uint num13 = BitConverter.ToUInt32(array2, 0);
					bool flag7 = num13 == 0U;
					if (!flag7)
					{
						uint num14 = num4 + num13 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num2);
						bool flag8 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag8)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
							bool flag9 = array2[0] == 0;
							if (!flag9)
							{
								num8++;
								bool flag10 = false;
								byte b = array2[0];
								for (int j = 0; j < array.Length; j++)
								{
									bool flag11 = (char)b == array[j][0] || (char)(b + 32) == array[j][0];
									if (flag11)
									{
										flag10 = true;
										break;
									}
								}
								bool flag12 = !flag10;
								if (!flag12)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
									uint num15 = (uint)array2[0];
									bool flag13 = num15 != 3U && num15 != 1U;
									if (!flag13)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_108.uint_0, array2, 1, ref num2);
										bool flag14 = array2[0] == 0;
										if (!flag14)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num2);
											string text = Class10.smethod_3(array3).ToLower();
											flag10 = false;
											for (int k = 0; k < array.Length; k++)
											{
												bool flag15 = 0 <= text.IndexOf(array[k]);
												if (flag15)
												{
													flag10 = true;
													break;
												}
											}
											bool flag16 = !flag10;
											if (!flag16)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num2);
												uint uint_ = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_100.uint_0, array2, 1, ref num2);
												uint uint_2 = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_111.uint_0, array2, 1, ref num2);
												uint uint_3 = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_112.uint_0, array2, 1, ref num2);
												uint uint_4 = (uint)array2[0];
												uint[] array4 = Class79.smethod_26(gstruct49_0, num6, uint_3, uint_4);
												bool flag17 = array4 != null;
												if (!flag17)
												{
													num5 = 2;
													break;
												}
												num5 = 1;
												int l;
												for (l = 0; l < 120; l++)
												{
													bool flag18 = l % 8 == 0;
													if (flag18)
													{
														Class70.smethod_46(gstruct49_0, uint_, uint_2, num15, array4[0], array4[1], num6);
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_100.uint_0 - 8U, array2, 4, ref num2);
													int num16 = BitConverter.ToInt32(array2, 0);
													bool flag19 = (long)num16 == (long)((ulong)num15);
													if (!flag19)
													{
														l = -1;
														break;
													}
													Thread.Sleep(10);
												}
												bool flag20 = l == -1;
												if (flag20)
												{
													num9 = 0;
												}
												else
												{
													bool flag21 = num9 <= 0;
													if (!flag21)
													{
														num5 = -1;
														break;
													}
													num9++;
												}
											}
										}
									}
								}
							}
						}
					}
					num10 += 1U;
				}
				Thread.Sleep(100);
				Class45.smethod_21(gstruct49_0);
				result = num5;
			}
			return result;
		}
	}
}
