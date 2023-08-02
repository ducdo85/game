using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000054 RID: 84
	internal class Class85
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x000E61C4 File Offset: 0x000E43C4
		public static void smethod_0(int int_0)
		{
			for (;;)
			{
				try
				{
					Class85.smethod_1(int_0);
					break;
				}
				catch
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000E6204 File Offset: 0x000E4404
		public static void smethod_1(int int_0)
		{
			bool flag = false;
			bool flag2 = false;
			GStruct49 gstruct = default(GStruct49);
			int num = -1;
			string text = "MËt ®å thÇn bÝ";
			int num2 = -1;
			string text2 = "LÖnh bµi Vi S¬n";
			int num3 = 0;
			int num4 = -1;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			int num8 = 0;
			int num9 = 0;
			bool flag3 = false;
			int num10;
			for (;;)
			{
				IL_1407:
				Thread.Sleep(200);
				num10 = Class81.smethod_3(Form1.gstruct49_0, int_0);
				bool flag4 = Class12.bool_0 || num10 < 0;
				if (flag4)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num10];
				bool flag5 = gstruct.bool_25 && gstruct.bool_55 && !flag;
				if (!flag5)
				{
					goto IL_E78;
				}
				bool flag6 = !flag2;
				if (flag6)
				{
					uint num11 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num12 = Class22.smethod_30(num11 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num13 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num14 = num13 + num12 * Class53.gstruct51_15.uint_0;
					int num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					int num16 = (int)Class22.smethod_30(num14 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					int num17 = (int)Class22.smethod_30(num14 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					int num18 = (int)Class22.smethod_30(num14 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num19 = Class83.smethod_39(gstruct);
					bool flag7 = num18 <= 0 || num15 <= 0 || num17 == 10 || num17 == 21 || num19 <= 1 || (gstruct.int_136 == Class76.gstruct49_0.int_136 && Class83.smethod_12(gstruct) == 1);
					if (!flag7)
					{
						uint[] array3 = new uint[]
						{
							Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag8 = array3[0] == 0U || array3[1] == 0U;
						if (!flag8)
						{
							bool flag9 = num15 != 342;
							if (flag9)
							{
								bool flag10 = Class56.smethod_1(num15) == null;
								if (flag10)
								{
									uint num20 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_97.uint_0;
									uint num21 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
									int num22 = Class79.smethod_4(gstruct);
									int num23 = 0;
									bool flag11 = num2 == -1;
									if (flag11)
									{
										num2 = 0;
										num = 0;
										uint num24 = 1U;
										while ((ulong)num24 < (ulong)((long)Class53.int_1) && num22 > num23)
										{
											uint num25 = num21 + num24 * Class53.gstruct51_106.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num7);
											bool flag12 = BitConverter.ToInt32(array, 0) != 0;
											if (!flag12)
											{
												uint num26 = Class79.smethod_1(gstruct, num24);
												bool flag13 = num26 <= 0U;
												if (!flag13)
												{
													num23++;
													uint uint_ = num25 + Class53.gstruct51_107.uint_0;
													Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 1, ref num7);
													bool flag14 = array[0] == 0 || Class22.smethod_30(num25 + Class53.gstruct51_108.uint_0, gstruct.int_137) <= 0U;
													if (!flag14)
													{
														uint num27 = Class22.smethod_30(num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
														bool flag15 = num27 != 23U && num27 != 3U && num27 != 1U;
														if (!flag15)
														{
															Class22.ReadProcessMemory(gstruct.int_137, uint_, array2, array2.Length, ref num7);
															string text3 = Class10.smethod_3(array2).ToLower();
															bool flag16 = 0 > text3.IndexOf(text2.ToLower());
															if (flag16)
															{
																bool flag17 = num > 0;
																if (flag17)
																{
																	goto IL_46D;
																}
																uint num28 = Class22.smethod_30(num25 + Class53.gstruct51_119.uint_0, gstruct.int_137);
																bool flag18 = num28 != 100U || 0 > text3.IndexOf(text.ToLower());
																if (flag18)
																{
																	goto IL_46D;
																}
																num = (int)num24;
															}
															else
															{
																num2 = (int)num24;
															}
															bool flag19 = num2 <= 0;
															if (flag19)
															{
																goto IL_1407;
															}
															num26 = Class79.smethod_1(gstruct, (uint)num2);
															uint num29 = num20 + num26 * 20U;
															uint num30 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0 - 4U, gstruct.int_137);
															uint num31 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0, gstruct.int_137);
															uint num32 = Class22.smethod_30(num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
															bool flag20 = num32 != 3U;
															if (flag20)
															{
																uint[] array4 = Class79.smethod_26(gstruct, 3U, 1U, 1U);
																bool flag21 = array4 != null;
																if (flag21)
																{
																	Class70.smethod_46(gstruct, num30, num31, num32, array4[0], array4[1], 3U);
																	for (int i = 0; i < 150; i++)
																	{
																		Class22.ReadProcessMemory(gstruct.int_137, num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, array, 4, ref num7);
																		bool flag22 = BitConverter.ToUInt32(array, 0) == 3U;
																		if (flag22)
																		{
																			break;
																		}
																		Thread.Sleep(10);
																	}
																}
																num6++;
															}
															num32 = Class22.smethod_30(num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
															bool flag23 = num32 == 3U;
															if (flag23)
															{
																num30 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0 - 4U, gstruct.int_137);
																num31 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0, gstruct.int_137);
																int i = 0;
																while (i < 50)
																{
																	Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_45 - 4U, array, 1, ref num7);
																	bool flag24 = array[0] == 0;
																	if (flag24)
																	{
																		break;
																	}
																	i++;
																	Thread.Sleep(10);
																}
																Class70.smethod_43(gstruct, (uint)num2, (int)num30, (int)num31, 3);
																i = 0;
																for (;;)
																{
																	bool flag25 = i < 150;
																	if (!flag25)
																	{
																		goto IL_110E;
																	}
																	Class22.ReadProcessMemory(gstruct.int_137, num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, array, 4, ref num7);
																	bool flag26 = BitConverter.ToUInt32(array, 0) != 3U;
																	if (flag26)
																	{
																		break;
																	}
																	int num33 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																	bool flag27 = num33 != num15;
																	if (flag27)
																	{
																		break;
																	}
																	Thread.Sleep(10);
																	i++;
																}
																goto IL_1154;
																IL_110E:
																Thread.Sleep(300);
															}
															else
															{
																bool flag28 = num6 < 3;
																if (flag28)
																{
																	Thread.Sleep(150);
																	num2 = -1;
																}
																else
																{
																	Class70.smethod_52(gstruct, "Khong the chuyen lenh bai vsd ra hanh trang, ket thuc!", 1);
																	flag = true;
																}
															}
															IL_1154:
															goto IL_1407;
														}
													}
												}
											}
											IL_46D:
											num24 += 1U;
										}
									}
									num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
									bool flag29 = num15 != 342;
									if (flag29)
									{
										bool flag30 = num15 == 175;
										if (flag30)
										{
											bool flag31 = num2 > 0 || num > 0;
											if (flag31)
											{
												bool flag32 = num15 != 175;
												if (flag32)
												{
													continue;
												}
												uint num34 = Class36.smethod_41(gstruct, false);
												bool flag33 = num34 < 500U;
												if (flag33)
												{
													Class70.smethod_37(gstruct, 500U - num34);
													Thread.Sleep(300);
												}
												long long_ = 0L;
												uint[] array5 = new uint[]
												{
													54912U,
													99968U
												};
												while (!Class12.bool_0)
												{
													num10 = Class81.smethod_3(Form1.gstruct49_0, int_0);
													bool flag34 = !Class12.bool_0 && num10 >= 0 && Form1.gstruct49_0[num10].bool_25 && Form1.gstruct49_0[num10].bool_55;
													if (!flag34)
													{
														goto IL_63F;
													}
													array3 = new uint[]
													{
														Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													bool flag35 = Class60.smethod_18(array3, array5) < 120000L;
													if (flag35)
													{
														break;
													}
													bool flag36 = Class12.smethod_28(long_) > 6000L;
													if (flag36)
													{
														Class14.smethod_1(gstruct, array5);
														long_ = Class12.smethod_27();
													}
													Thread.Sleep(600);
												}
												int i;
												for (i = 0; i < 10; i++)
												{
													array3 = new uint[]
													{
														Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													bool flag37 = Class60.smethod_18(array3, array5) < 11500L;
													if (flag37)
													{
														break;
													}
													Class70.smethod_61(gstruct, array5);
													Thread.Sleep(300);
												}
												uint num35 = Class85.smethod_2(gstruct);
												bool flag38 = num35 > 0U;
												if (flag38)
												{
													Class86.smethod_8(gstruct, -1);
													bool flag39 = Class45.smethod_8(gstruct);
													if (flag39)
													{
														Class45.smethod_11(gstruct);
													}
													Thread.Sleep(100);
													int num36 = 0;
													bool flag40 = false;
													uint num26;
													string text4;
													for (;;)
													{
														IL_B7A:
														Class45.smethod_21(gstruct);
														int num37 = num2;
														bool flag41 = num37 <= 0;
														if (flag41)
														{
															num37 = num;
														}
														num26 = Class79.smethod_1(gstruct, (uint)num37);
														bool flag42 = num26 > 0U;
														if (!flag42)
														{
															goto IL_B54;
														}
														num21 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
														uint num25 = num21 + (uint)(num37 * (int)Class53.gstruct51_106.uint_0);
														uint uint_ = num25 + Class53.gstruct51_107.uint_0;
														Class22.ReadProcessMemory(gstruct.int_137, uint_, array2, array2.Length, ref num7);
														string text3 = Class10.smethod_3(array2).ToLower();
														uint num38 = Class22.smethod_30(num25 + Class53.gstruct51_119.uint_0, gstruct.int_137);
														bool flag43 = (num38 == 0U || num38 >= 100U) && (text3.IndexOf(text2.ToLower()) >= 0 || text3.IndexOf(text.ToLower()) >= 0);
														if (!flag43)
														{
															goto IL_B4F;
														}
														Class22.WriteProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num35), 4, ref num7);
														while (Class86.smethod_0(gstruct) < 0)
														{
															bool flag44 = Class86.Class89.smethod_4(gstruct);
															if (flag44)
															{
																Class86.Class89.smethod_5(gstruct);
															}
															i++;
															Thread.Sleep(100);
															bool flag45 = i <= 10;
															if (!flag45)
															{
																num36++;
																bool flag46 = num36 <= 3;
																if (flag46)
																{
																	goto IL_B7A;
																}
																goto IL_B70;
															}
														}
														bool flag47 = !(flag40 = !flag40);
														if (flag47)
														{
															Class86.smethod_5(gstruct, 0);
														}
														else
														{
															Class86.smethod_6(gstruct, "Ta", false, false, false, false);
														}
														for (i = 0; i < 10; i++)
														{
															Thread.Sleep(100 + Class86.int_0);
															bool flag48 = Class45.smethod_8(gstruct);
															if (flag48)
															{
																i = -1;
																break;
															}
														}
														bool flag49 = i != -1;
														if (!flag49)
														{
															goto IL_952;
														}
														text4 = Class86.smethod_2(gstruct, -1);
														Class86.smethod_8(gstruct, -1);
														bool flag50 = text4 != string.Empty && 0 < Class12.smethod_1(text4, "cÊp 100 kh«ng");
														if (flag50)
														{
															goto Block_58;
														}
													}
													continue;
													IL_B54:
													num2 = -1;
													continue;
													IL_B4F:
													num2 = -1;
													continue;
													IL_952:
													num20 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_97.uint_0;
													uint num29 = num20 + num26 * 20U;
													uint num30 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0 - 4U, gstruct.int_137);
													uint num31 = Class22.smethod_30(num29 + Class53.gstruct51_100.uint_0, gstruct.int_137);
													uint num39 = Class22.smethod_30(num20 + num26 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
													i = 0;
													Class70.smethod_46(gstruct, num30, num31, num39, num30, num31, num39);
													for (;;)
													{
														bool flag51 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) <= 0U;
														if (!flag51)
														{
															goto IL_A4F;
														}
														Thread.Sleep(150);
														i++;
														bool flag52 = i > 10;
														if (flag52)
														{
															goto Block_60;
														}
													}
													continue;
													IL_A4F:
													i = 0;
													Class70.smethod_46(gstruct, 0U, 0U, 12U, 0U, 0U, 12U);
													for (;;)
													{
														bool flag53 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) > 0U;
														if (!flag53)
														{
															goto IL_ABE;
														}
														Thread.Sleep(150);
														i++;
														bool flag54 = i > 10;
														if (flag54)
														{
															goto Block_63;
														}
													}
													continue;
													Block_63:
													bool flag55 = Class45.smethod_8(gstruct);
													if (flag55)
													{
														Class45.smethod_11(gstruct);
													}
													continue;
													IL_ABE:
													Class45.smethod_13(gstruct, true);
													Thread.Sleep(300);
													for (i = 0; i < 10; i++)
													{
														int num40 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
														int num41 = (int)Class22.smethod_30(num14 + Class53.gstruct51_43.uint_0, gstruct.int_137);
														bool flag56 = num40 != num15 || num41 > 0;
														if (flag56)
														{
															break;
														}
														Thread.Sleep(100);
													}
													continue;
													Block_60:
													bool flag57 = Class45.smethod_8(gstruct);
													if (flag57)
													{
														Class45.smethod_11(gstruct);
													}
													continue;
													Block_58:
													Class70.smethod_52(gstruct, text4, 1);
													flag = true;
													continue;
													IL_B70:
													Class60.smethod_12(gstruct, true);
												}
												else
												{
													Class60.smethod_12(gstruct, true);
												}
												continue;
											}
										}
										else
										{
											num4 = -1;
											num5 = 0;
											array3 = new uint[]
											{
												Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
												Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
											};
											bool flag58 = num15 == 195;
											if (flag58)
											{
												GStruct26 gstruct2 = Class43.smethod_4(195, 175);
												bool flag59 = gstruct2.uint_0 != null;
												if (flag59)
												{
													int int_ = 0;
													int int_2 = 0;
													uint[] uint_2 = null;
													uint[] array6 = null;
													bool flag60 = gstruct2.uint_0.GetLength(0) > 1;
													if (flag60)
													{
														int_ = Class60.smethod_20(gstruct2.uint_0, array3);
													}
													Class60.smethod_8(gstruct2.uint_0, int_, ref array6, ref uint_2, ref int_2);
													long num42 = Class60.smethod_18(array3, array6);
													bool flag61 = num42 < 5000000L;
													if (flag61)
													{
														Class60.smethod_23(gstruct, array6, int_2, uint_2, gstruct2.int_1);
														continue;
													}
												}
											}
											bool flag62 = Class70.smethod_3(gstruct, Class70.uint_20, 4) != 0;
											if (flag62)
											{
												bool flag63 = num8 <= 3 || num15 != 336;
												if (flag63)
												{
													Class35.smethod_140(gstruct, 175, null, null, false);
													Thread.Sleep(600);
													num8++;
													bool flag64 = num8 > 6;
													if (flag64)
													{
														Class70.smethod_52(gstruct, "Khong the Than Hanh Phu len Tay Son thon, ket thuc!", 1);
														flag = true;
													}
												}
												else
												{
													bool flag65 = num9 >= 3 || !Class60.smethod_14(gstruct, true);
													if (flag65)
													{
														GStruct26 gstruct3 = Class43.smethod_4(num15, 121);
														bool flag66 = gstruct3.uint_0 != null;
														if (flag66)
														{
															int int_3 = 0;
															int int_4 = 0;
															uint[] uint_3 = null;
															uint[] uint_4 = null;
															bool flag67 = gstruct3.uint_0.GetLength(0) > 1;
															if (flag67)
															{
																int_3 = Class60.smethod_20(gstruct3.uint_0, array3);
															}
															Class60.smethod_8(gstruct3.uint_0, int_3, ref uint_4, ref uint_3, ref int_4);
															Class60.smethod_23(gstruct, uint_4, int_4, uint_3, gstruct3.int_1);
														}
														else
														{
															Class70.smethod_52(gstruct, "Khong the qua map Long Mon tran, ket thuc !", 1);
															flag = true;
														}
													}
													else
													{
														num9++;
														Thread.Sleep(300);
													}
												}
												continue;
											}
											bool flag68 = !flag3;
											if (flag68)
											{
												bool flag69 = num16 <= 0;
												if (flag69)
												{
													flag3 = true;
													goto IL_1159;
												}
												bool flag70 = num9 < 3 && Class60.smethod_14(gstruct, true);
												if (flag70)
												{
													num9++;
													Thread.Sleep(300);
													continue;
												}
											}
											Class70.smethod_52(gstruct, "Khong co Than Hanh phu, ket thuc !", 1);
											flag = true;
											continue;
										}
										IL_1159:
										for (;;)
										{
											bool flag71 = Form1.int_104 > 3;
											if (!flag71)
											{
												goto IL_13ED;
											}
											num10 = Class81.smethod_3(Form1.gstruct49_0, int_0);
											bool flag72 = Class12.bool_0 || num10 < 0;
											if (flag72)
											{
												goto Block_96;
											}
											gstruct = Form1.gstruct49_0[num10];
											bool flag73 = gstruct.bool_25 && gstruct.bool_55 && !flag;
											if (!flag73)
											{
												goto IL_13D9;
											}
											int num43 = Class79.smethod_31(gstruct, text2, 3, false, false);
											bool flag74 = num43 <= 0;
											if (!flag74)
											{
												goto IL_13D4;
											}
											bool flag75 = num3 <= 3;
											if (!flag75)
											{
												goto IL_13C3;
											}
											bool flag76 = 0 > num4;
											if (flag76)
											{
												Struct23[] array7 = Class83.smethod_1(gstruct);
												bool flag77 = array7 == null;
												if (flag77)
												{
													goto Block_103;
												}
												int num44 = -1;
												string value = text2.ToLower();
												GStruct1[] array8;
												int j;
												for (;;)
												{
													num44++;
													bool flag78 = array7.Length <= num44;
													if (flag78)
													{
														break;
													}
													Class70.smethod_26(gstruct, array7[num44].string_0);
													Thread.Sleep(300);
													Class70.smethod_27(gstruct);
													array8 = Class17.smethod_1(gstruct);
													bool flag79 = array8 == null || array8.Length == 0;
													if (!flag79)
													{
														for (j = 0; j < array8.Length; j++)
														{
															string text5 = array8[j].string_0.ToLower().Trim();
															bool flag80 = text5.IndexOf(value) != 0;
															if (!flag80)
															{
																goto IL_12CF;
															}
														}
													}
												}
												goto IL_131B;
												IL_12CF:
												num4 = array8[j].int_0;
												num5 = array7[num44].int_0 - array7[0].int_0;
											}
											IL_131B:
											bool flag81 = num4 >= 0;
											if (!flag81)
											{
												goto IL_13B2;
											}
											Class52.smethod_0(gstruct);
											int num45 = Class79.smethod_4(gstruct);
											Class70.smethod_28(gstruct, num4, num5 + Form1.int_5);
											int k = 0;
											while (k < 10)
											{
												k++;
												Thread.Sleep(150);
												bool flag82 = Class79.smethod_4(gstruct) != num45;
												if (flag82)
												{
													break;
												}
												string text6 = Class52.smethod_2(gstruct, false);
												bool flag83 = text6.IndexOf("kh«ng ®ñ") > 0;
												if (flag83)
												{
													num3 = 4;
													break;
												}
											}
											num3++;
										}
										continue;
										IL_13ED:
										flag = true;
										Class70.smethod_52(gstruct, "Khong co mat do than bi hoac lenh bai vi son dao, ket thuc.", 1);
										continue;
										IL_13D4:
										num2 = -1;
										continue;
										IL_13C3:
										flag = true;
										Class70.smethod_52(gstruct, "Khong mua duoc lenh bai vi son dao, ket thuc.", 1);
										continue;
										IL_13B2:
										flag = true;
										Class70.smethod_52(gstruct, "Khong tim thay Lenh bai Vi son dao trong Ky tran cac, ket thuc !", 1);
										continue;
										Block_103:
										flag = true;
									}
									else
									{
										flag = true;
									}
								}
								else
								{
									flag2 = (Class50.smethod_5(gstruct, 11) > 0);
								}
							}
							else
							{
								flag = true;
							}
						}
					}
				}
				else
				{
					flag2 = (Class91.smethod_0(gstruct, true, null) <= 0);
				}
			}
			IL_63F:
			return;
			IL_E78:
			Form1.gstruct49_0[num10].bool_55 = false;
			Block_96:
			return;
			IL_13D9:
			Form1.gstruct49_0[num10].bool_55 = false;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000E7620 File Offset: 0x000E5820
		private static uint smethod_2(GStruct49 gstruct49_0)
		{
			string text = "T©y s¬n";
			uint[] uint_ = new uint[]
			{
				54912U,
				99968U
			};
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
			Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
			int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag = num6 == 175;
			uint result;
			if (flag)
			{
				Class22.smethod_30(num5 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 4, ref num);
				int num7 = BitConverter.ToInt32(array, 0);
				bool flag2 = num7 > 1;
				if (flag2)
				{
					int num8 = 0;
					long num9 = 0L;
					uint num10 = 0U;
					uint[] array4 = new uint[2];
					for (uint num11 = 1U; num11 < 256U; num11 += 1U)
					{
						bool flag3 = num7 <= num8;
						if (flag3)
						{
							break;
						}
						uint num12 = num4 + num11 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array, 4, ref num);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num8++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_52.uint_0, array, 4, ref num);
							uint num13 = BitConverter.ToUInt32(array, 0);
							bool flag5 = num13 == 3U;
							if (flag5)
							{
								uint[] array5 = new uint[2];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
								array5[0] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
								array5[1] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num);
								string text2 = Class10.smethod_3(array2);
								string string_ = text2.ToLower();
								bool flag6 = 0 <= Class12.smethod_1(string_, text.ToLower());
								if (flag6)
								{
									return num11;
								}
								long num14 = Class60.smethod_18(uint_, array5);
								bool flag7 = num14 < 40000L && (num10 == 0U || num14 < num9);
								if (flag7)
								{
									num9 = num14;
									array4[0] = array5[0];
									array4[1] = array5[1];
									num10 = num11;
								}
							}
						}
					}
					result = num10;
				}
				else
				{
					result = 0U;
				}
			}
			else
			{
				result = 0U;
			}
			return result;
		}
	}
}
