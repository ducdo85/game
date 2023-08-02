using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000039 RID: 57
	internal class Class6
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000997BC File Offset: 0x000979BC
		public static void smethod_0(int int_1)
		{
			try
			{
				Class6.smethod_1(int_1);
			}
			catch
			{
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000997EC File Offset: 0x000979EC
		public static int smethod_1(int int_1)
		{
			GStruct49 gstruct = default(GStruct49);
			Random random = new Random();
			GStruct26 gstruct2 = default(GStruct26);
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = 0;
			int num5 = -1;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			uint[,] array = new uint[3, 2];
			Class11.smethod_4(array, 595);
			uint[,] array2 = array;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			uint[] array3 = null;
			uint[] array4 = null;
			int[,] array5 = null;
			uint[] array6 = null;
			uint[] uint_ = null;
			uint[] uint_2 = null;
			uint[] array7 = null;
			int num10 = -1;
			uint[] array8 = null;
			long long_ = 0L;
			int[] int_2 = null;
			long long_2 = 0L;
			long num11 = 0L;
			long num12 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			long long_5 = 0L;
			long long_6 = 0L;
			long long_7 = 0L;
			long long_8 = 0L;
			long long_9 = 0L;
			long long_10 = 0L;
			long num13 = 0L;
			long long_11 = 0L;
			long num14 = -1L;
			uint num15 = 0U;
			int num16 = -1;
			int num17 = 0;
			int num18 = 0;
			int num19 = 0;
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			int num23 = 0;
			byte[] byte_ = new byte[4];
			byte[] array9 = new byte[4];
			bool flag10 = false;
			for (;;)
			{
				Thread.Sleep(200);
				int num24 = Class81.smethod_3(Form1.gstruct49_0, int_1);
				bool flag11 = Class12.bool_0 || num24 < 0 || !Form1.gstruct49_0[num24].bool_25 || Form1.gstruct49_0[num24].int_25 <= 0;
				if (flag11)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num24];
				bool flag12 = gstruct.int_32 <= 0 || gstruct.int_54 <= 0 || gstruct.int_55 <= 0;
				if (flag12)
				{
					bool flag13 = !gstruct.bool_15;
					if (flag13)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array9, 4, ref num18);
						uint num25 = BitConverter.ToUInt32(array9, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_13.uint_0, array9, 4, ref num18);
						uint num26 = BitConverter.ToUInt32(array9, 0);
						uint num27 = num26 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array9, 4, ref num18);
						uint num28 = BitConverter.ToUInt32(array9, 0);
						uint num29 = num28 + num27;
						Class22.ReadProcessMemory(gstruct.int_137, num29, array9, 4, ref num18);
						uint num30 = BitConverter.ToUInt32(array9, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_55.uint_0, array9, 4, ref num18);
						int num31 = BitConverter.ToInt32(array9, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_50.uint_0, array9, 4, ref num18);
						int num32 = BitConverter.ToInt32(array9, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array9, 4, ref num18);
						int num33 = BitConverter.ToInt32(array9, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_43.uint_0, array9, 4, ref num18);
						int num34 = BitConverter.ToInt32(array9, 0);
						int num35 = Class83.smethod_39(gstruct);
						bool flag14 = num32 != 0 && num31 != 0 && num33 != 0 && num31 != 10 && num31 != 21 && num35 > 1;
						if (flag14)
						{
							int num36 = (int)Class22.smethod_30(num25 + Class53.gstruct51_30.uint_0 + Class53.gstruct51_65.uint_0, gstruct.int_137);
							uint[] array10 = new uint[]
							{
								Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							bool flag15 = array10[0] == 0U || array10[1] == 0U;
							if (!flag15)
							{
								bool flag16 = flag10;
								if (flag16)
								{
									flag10 = false;
									flag6 = false;
									Thread.Sleep(300);
								}
								else
								{
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array9, 1, ref num18);
									bool flag17 = array9[0] > 0;
									if (flag17)
									{
										flag3 = false;
										gstruct.bool_12 = false;
										array9[0] = 0;
										Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array9, 1, ref num18);
										num24 = Class81.smethod_3(Form1.gstruct49_0, int_1);
										bool flag18 = 0 <= num24;
										if (flag18)
										{
											Form1.gstruct49_0[num24].bool_12 = false;
										}
									}
									bool flag19 = num2 == num34 && num == num33;
									if (flag19)
									{
										bool flag20 = Class12.smethod_28(long_6) > 30000L;
										if (flag20)
										{
											int_2 = null;
											long_6 = Class12.smethod_27();
										}
										bool flag21 = num34 <= 0 || Class83.smethod_12(gstruct) <= 0;
										if (flag21)
										{
											num21 = 0;
											int num37 = Class79.smethod_4(gstruct);
											bool flag22 = num8 != num37 || Class12.smethod_28(long_9) > 60000L;
											if (flag22)
											{
												num19 += (int)Convert.ToByte(!gstruct.bool_7 && num8 != num37 && gstruct.int_37 > 0 && Class6.int_0 <= 0 && num34 > 0);
												num20 += (int)Convert.ToByte(num8 < num37 && gstruct.int_60 != null && gstruct.int_60[0] > 0 && num34 > 0);
												num8 = num37;
												long_9 = Class12.smethod_27();
											}
											bool flag23 = num20 > 0;
											if (flag23)
											{
												bool flag24 = num20 == 1;
												if (flag24)
												{
													int[,] array11 = Class79.smethod_27(gstruct);
													int length = array11.GetLength(0);
													int num38 = 0;
													for (int i = 0; i < length; i++)
													{
														bool flag25 = array11[i, 0] > 0;
														if (flag25)
														{
															int num39 = array11[i, 1] * array11[i, 2];
															bool flag26 = num38 < num39;
															if (flag26)
															{
																num38 = num39;
															}
														}
													}
													int[] array12 = new int[]
													{
														1,
														2,
														3,
														4,
														6
													};
													int num40 = array12[gstruct.int_60[1]];
													bool flag27 = num40 <= num38;
													if (flag27)
													{
														num20 = 0;
													}
												}
												bool flag28 = num20 > 0 && Class12.smethod_28(long_5) > 1000L;
												if (flag28)
												{
													long_5 = Class12.smethod_27();
													num20 = 0;
													bool flag29 = Class32.smethod_0(num33);
													if (flag29)
													{
														flag4 = true;
														continue;
													}
													bool flag30 = !Class60.smethod_14(gstruct, true) && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
													if (flag30)
													{
														Class35.smethod_140(gstruct, 1, "t©m", null, false);
													}
												}
											}
											bool flag31 = num19 > 0;
											if (flag31)
											{
												bool flag32 = num17 <= 0;
												if (flag32)
												{
													num17 = gstruct.int_38;
													bool flag33 = num17 > 1000;
													if (flag33)
													{
														num17 = random.Next(num17 - 1000, num17 + 1000);
													}
												}
												bool flag34 = Class12.smethod_28(long_8) > (long)num17;
												if (flag34)
												{
													num19 = 0;
													Class6.int_0 = int_1;
													long_8 = Class12.smethod_27();
													num17 = 0;
													new Thread(new ThreadStart(Class6.smethod_5)).Start();
												}
											}
											bool flag35 = gstruct.int_104[0] > 0 && gstruct.int_104[1] <= num36;
											if (flag35)
											{
												bool flag36 = num34 <= 0;
												if (flag36)
												{
													int j = 0;
													byte[] array13 = Class12.smethod_46("Kh«ng thÓ tiÕp tôc v× PK qu¸ cao (co the thay doi trong muc Hau can).", true);
													while (j < 6)
													{
														Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_251.uint_0, array13, array13.Length, ref num18);
														Thread.Sleep(100);
														j++;
													}
													continue;
												}
												bool flag37 = !Class32.smethod_0(num33);
												if (flag37)
												{
													bool flag38 = !Class60.smethod_14(gstruct, true) && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
													if (flag38)
													{
														Class35.smethod_140(gstruct, 162, "b¾c", null, false);
													}
												}
												else
												{
													bool flag39 = Class44.gstruct33_0.int_0 > 0;
													if (flag39)
													{
														Class70.smethod_50(gstruct, Class44.gstruct33_0.string_0, Class10.smethod_2("Thoát game vì PK quá cao, Thím có thể thiết lập lại trong mục Hậu cần nhé."));
														Thread.Sleep(600);
													}
													Class22.smethod_53(gstruct.process_0);
												}
											}
											int num41 = 0;
											bool flag40 = gstruct.uint_0 != null;
											if (flag40)
											{
												num41 = gstruct.uint_0.GetLength(0);
											}
											int num42 = 302500;
											bool flag41 = gstruct.int_98 > 0 && gstruct.int_99 > 0;
											if (flag41)
											{
												num42 = gstruct.int_99 * gstruct.int_99;
											}
											bool flag42 = gstruct.int_119 > 0 && gstruct.int_3 != null && gstruct.int_4 != null;
											bool flag43 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_4 == num33 && Class44.gstruct33_0.int_3 == num34 && Class44.gstruct33_0.int_3 > 0 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class44.gstruct33_0.bool_2;
											bool flag44 = num34 <= 0;
											if (flag44)
											{
												bool flag45 = Class44.gstruct33_0.int_0 == gstruct.int_136;
												if (flag45)
												{
													Class44.gstruct33_0.bool_2 = false;
												}
												num11 = 0L;
												flag7 = false;
												flag8 = false;
												flag4 = false;
												int_2 = null;
												flag9 = (gstruct.int_30 <= 0);
												num20 = 0;
												num19 = 0;
												bool flag46 = !flag3;
												if (flag46)
												{
													Class6.smethod_2(gstruct, num29, ref num12, true);
													bool flag47 = gstruct.int_46 != null && gstruct.int_46[0] > 0;
													if (flag47)
													{
														Class6.smethod_4(gstruct);
													}
													bool flag48 = gstruct.int_53 != null && (gstruct.int_53[0] > 0 || gstruct.int_53[1] > 0 || gstruct.int_53[2] > 0 || gstruct.int_53[3] > 0 || gstruct.int_53[4] > 0);
													if (flag48)
													{
														Class6.smethod_3(gstruct);
													}
													bool flag49 = Class40.smethod_0(gstruct) == 0 || Class34.smethod_3(gstruct, Form1.int_98 <= 0) == 0;
													if (flag49)
													{
														continue;
													}
													flag3 = true;
													long num43 = (long)((ulong)Class22.smethod_30(num29 + Class53.gstruct51_45.uint_0, gstruct.int_137));
													long num44 = (long)((ulong)(Class22.smethod_30(num29 + Class53.gstruct51_47.uint_0, gstruct.int_137) + 1U));
													long num45 = (long)((ulong)(Class22.smethod_30(num29 + Class53.gstruct51_47.uint_0 + 4U, gstruct.int_137) + 1U));
													long num46 = (long)((ulong)Class22.smethod_30(num29 + Class53.gstruct51_46.uint_0, gstruct.int_137));
													long num47 = (long)((ulong)(Class22.smethod_30(num29 + Class53.gstruct51_48.uint_0, gstruct.int_137) + 1U));
													long num48 = (long)((ulong)(Class22.smethod_30(num29 + Class53.gstruct51_48.uint_0 + 4U, gstruct.int_137) + 1U));
													bool flag50 = num45 > num44 && num45 < 150000L;
													if (flag50)
													{
														num44 = num45;
													}
													bool flag51 = num48 > num47 && num48 < 150000L;
													if (flag51)
													{
														num47 = num48;
													}
													double num49 = (double)(num43 * 100L / num44);
													double num50 = (double)(num46 * 100L / num47);
													bool flag52 = num44 > 100L && num49 <= 60.0;
													if (flag52)
													{
														Class32.smethod_6(gstruct, 0, 1, false);
													}
													bool flag53 = num47 > 50L && num50 <= 60.0;
													if (flag53)
													{
														Class32.smethod_6(gstruct, 1, 1, false);
													}
													Thread.Sleep(600);
													num8 = Class79.smethod_4(gstruct);
													bool flag54 = gstruct.int_65 > 0;
													if (flag54)
													{
														Class60.smethod_3(gstruct, ref flag);
													}
													bool flag55 = gstruct.int_25 > 0 && gstruct.int_26 > 0 && gstruct.int_28 > 0;
													if (flag55)
													{
														uint num51 = Class36.smethod_41(gstruct, false);
														bool flag56 = num51 < 2000U;
														if (flag56)
														{
															Class70.smethod_37(gstruct, 2000U - num51);
														}
													}
													continue;
												}
											}
											else
											{
												bool flag57 = !flag3 && (flag4 || (flag4 = (gstruct.bool_12 && (gstruct.int_115 > 0 || gstruct.int_117 > 0))));
												if (flag57)
												{
													uint[] array14 = null;
													uint[] array15 = null;
													bool flag58 = !flag8 && num33 == 341;
													if (flag58)
													{
														int num52 = Class60.smethod_20(array2, array10);
														bool flag59 = 0 <= num52;
														if (flag59)
														{
															array15 = new uint[]
															{
																array2[num52, 0],
																array2[num52, 1]
															};
														}
													}
													bool flag60 = !flag8 && array15 != null;
													if (flag60)
													{
														bool flag61 = Class60.smethod_18(array10, array15) < 22500L;
														if (flag61)
														{
															flag8 = true;
														}
														else
														{
															array14 = new uint[]
															{
																array15[0],
																array15[1]
															};
														}
													}
													bool flag62 = array14 == null;
													if (flag62)
													{
														array14 = Class43.smethod_10(array10, num33, "HIEUTHUOC", false);
													}
													bool flag63 = array14 != null;
													if (flag63)
													{
														bool flag64 = Class44.gstruct33_0.int_0 == gstruct.int_136;
														if (flag64)
														{
															Class44.gstruct33_0.bool_2 = false;
														}
														flag7 = false;
														flag9 = (gstruct.int_30 <= 0);
														bool flag65 = num23 > 0;
														if (flag65)
														{
															Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
														}
														num23 = 0;
														Class6.smethod_2(gstruct, num29, ref num12, true);
														long num53 = Class60.smethod_18(array10, array14);
														bool flag66 = num53 < 250000L;
														if (flag66)
														{
															Class70.smethod_61(gstruct, array14);
															Thread.Sleep(100);
														}
														else
														{
															bool flag67 = Class12.smethod_28(long_2) > 3000L;
															if (flag67)
															{
																Class14.smethod_1(gstruct, array14);
																long_2 = Class12.smethod_27();
															}
														}
														Thread.Sleep(150);
														flag4 = true;
														continue;
													}
													bool flag68 = Class12.smethod_28(long_5) > 1000L && !Class32.smethod_0(num33);
													if (flag68)
													{
														bool flag69 = !Class60.smethod_14(gstruct, true) && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
														if (flag69)
														{
															Class35.smethod_140(gstruct, 1, "t©m", null, false);
														}
														long_5 = Class12.smethod_27();
													}
												}
												bool flag70 = gstruct.int_26 > 0 && !gstruct.bool_6 && Class12.smethod_28(long_10) > 60000L;
												if (flag70)
												{
													Class23.int_0 = int_1;
													new Thread(new ThreadStart(new Class23().method_1)).Start();
													long_10 = Class12.smethod_27();
												}
											}
											bool flag71 = num34 <= 0 && Class60.smethod_9(num33) != null;
											if (flag71)
											{
												bool flag72 = flag6;
												if (flag72)
												{
													flag6 = false;
													Class50.smethod_2(gstruct, "®iÓm c", null, null, 0);
													Class60.smethod_11(gstruct, 15000);
													continue;
												}
												num5 = -1;
												bool flag73 = !flag5 && num33 != gstruct.int_32;
												if (flag73)
												{
													flag5 = true;
													Class50.smethod_4(gstruct, gstruct.int_32);
													Class60.smethod_11(gstruct, 15000);
													continue;
												}
											}
											bool flag74 = num33 != gstruct.int_32;
											if (flag74)
											{
												num5 = -1;
												bool flag75 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
												if (flag75)
												{
													int num54 = gstruct.int_32;
													int num55 = Class35.smethod_137(num54);
													bool flag76 = num55 < 0 && gstruct.int_32 == 76;
													if (flag76)
													{
														num54 = 75;
														num55 = Class35.smethod_137(num54);
													}
													bool flag77 = 0 > num55 || !Class35.smethod_140(gstruct, num54, null, null, false);
													if (flag77)
													{
														bool flag78 = num33 != 103 && num33 != 114 && num33 != 110 && (gstruct.int_32 == 110 || gstruct.int_32 == 114) && Class35.smethod_140(gstruct, 103, null, null, false);
														if (flag78)
														{
															Thread.Sleep(300);
															Class60.smethod_11(gstruct, 15000);
															Thread.Sleep(600);
															int num56 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
															bool flag79 = num56 != num33;
															if (flag79)
															{
																continue;
															}
														}
													}
													else
													{
														Thread.Sleep(300);
														Class60.smethod_11(gstruct, 15000);
														Thread.Sleep(600);
														int num57 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
														bool flag80 = num57 != num33;
														if (flag80)
														{
															continue;
														}
													}
												}
												gstruct2 = Class43.smethod_4(num33, gstruct.int_32);
												bool flag81 = gstruct2.int_0 != num33 || gstruct2.int_1 != gstruct.int_32;
												if (flag81)
												{
													int num58 = Class60.smethod_7(num33, gstruct.int_32, ref gstruct2);
													bool flag82 = num58 != 0;
													if (flag82)
													{
														bool flag83 = num58 > 0;
														if (flag83)
														{
															int[] array16 = Class60.smethod_9(num33);
															bool flag84 = array16 != null;
															if (flag84)
															{
																bool flag85 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0 && num9 < 3;
																if (flag85)
																{
																	num9++;
																	bool flag86 = Class35.smethod_140(gstruct, num58, null, null, false);
																	if (flag86)
																	{
																		continue;
																	}
																}
																Class50.smethod_5(gstruct, num58);
																num9 = 0;
															}
															else
															{
																bool flag87 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
																if (flag87)
																{
																	uint[] uint_3 = null;
																	bool flag88 = Class60.smethod_7(num58, gstruct.int_32, ref gstruct2) == 0 && gstruct2.uint_0 != null;
																	if (flag88)
																	{
																		uint_3 = new uint[]
																		{
																			gstruct2.uint_0[0, 0],
																			gstruct2.uint_0[0, 1]
																		};
																	}
																	bool flag89 = !Class35.smethod_140(gstruct, num58, null, uint_3, false);
																	if (flag89)
																	{
																		Class35.smethod_140(gstruct, 1, "t©m", null, false);
																	}
																	continue;
																}
															}
														}
														bool flag90 = gstruct2.int_0 != num33 || gstruct2.int_1 != gstruct.int_32;
														if (flag90)
														{
															num34 = (int)Class22.smethod_30(num29 + Class53.gstruct51_43.uint_0, gstruct.int_137);
															bool flag91 = num34 > 0;
															if (flag91)
															{
																bool flag92 = gstruct.int_59 > 0 && num33 > 0 && !Class32.smethod_0(num33);
																if (flag92)
																{
																	Class60.smethod_14(gstruct, true);
																}
															}
															else
															{
																bool flag93 = Class12.smethod_28(long_11) > 30000L;
																if (flag93)
																{
																	string text = "Kh«ng t×m ®­îc ®­êng lªn b·i train.";
																	bool flag94 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
																	if (flag94)
																	{
																		text += " Xem l¹i tab Cµi game cña auto ®· thiÕt lËp ®óng trang web sö dông hay ch­a ?";
																	}
																	Class70.smethod_52(gstruct, text, 1);
																	long_11 = Class12.smethod_27();
																}
															}
															goto IL_2507;
														}
													}
												}
												bool flag95 = gstruct2.uint_0 != null;
												if (flag95)
												{
													bool flag96 = num23 > 0;
													if (flag96)
													{
														Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
													}
													num23 = 0;
													Class6.smethod_2(gstruct, num29, ref num12, true);
													array10 = new uint[]
													{
														Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													int int_3 = 0;
													int int_4 = 0;
													bool flag97 = gstruct2.uint_0.GetLength(0) > 1;
													if (flag97)
													{
														int_3 = Class60.smethod_20(gstruct2.uint_0, array10);
													}
													Class60.smethod_8(gstruct2.uint_0, int_3, ref array6, ref uint_, ref int_4);
													bool flag98 = Class60.smethod_18(array10, array6) > 90000L;
													if (flag98)
													{
														bool flag99 = Class12.smethod_28(long_2) > 3000L;
														if (flag99)
														{
															Class14.smethod_1(gstruct, array6);
															Thread.Sleep(300);
															long_2 = Class12.smethod_27();
														}
													}
													else
													{
														Class60.smethod_23(gstruct, array6, int_4, uint_, gstruct2.int_1);
													}
													continue;
												}
												int num59 = Class86.smethod_0(gstruct);
												Class70.smethod_59(gstruct, 0, (int)Convert.ToByte(num59 != 0));
											}
											else
											{
												bool flag100 = num34 <= 0;
												if (flag100)
												{
													num5 = -1;
												}
												bool flag101 = num33 == gstruct.int_32;
												if (flag101)
												{
													bool flag102 = gstruct.int_93 == 0;
													if (flag102)
													{
														Class6.smethod_2(gstruct, num29, ref num12, true);
													}
													else
													{
														bool flag103 = gstruct.int_93 == 1;
														if (flag103)
														{
															bool flag104 = flag7;
															if (flag104)
															{
																Class6.smethod_2(gstruct, num29, ref num12, false);
															}
														}
														else
														{
															bool flag105 = Class22.smethod_30(num29 + Class53.gstruct51_44.uint_0, gstruct.int_137) > 0U;
															if (flag105)
															{
																int num60 = Class70.smethod_3(gstruct, Class70.uint_46, 4);
																bool flag106 = num60 > 0;
																if (flag106)
																{
																	Class6.smethod_2(gstruct, num29, ref num12, false);
																}
															}
														}
													}
													bool flag107 = false;
													bool flag108 = num34 <= 0;
													if (!flag108)
													{
														flag3 = false;
														flag5 = false;
														flag6 = true;
														int num61 = gstruct.int_96;
														int num62 = gstruct.int_52 * gstruct.int_52;
														uint num63 = (uint)Class77.smethod_13(gstruct);
														bool flag109 = gstruct.int_95 <= 0;
														if (flag109)
														{
															num61 = (int)Class22.smethod_30(num29 + Class53.gstruct51_31.uint_0, gstruct.int_137);
															bool flag110 = num63 != 53U && num63 > 1U;
															if (flag110)
															{
																bool flag111 = num61 <= 100;
																if (flag111)
																{
																	num61 = 400;
																}
															}
															else
															{
																num61 = 75;
															}
														}
														bool flag112 = gstruct.int_61 > 0 && !gstruct.bool_9 && (!flag43 || !Class58.bool_1);
														if (flag112)
														{
															bool flag113 = !flag43 && array7 != null;
															if (flag113)
															{
																uint num64 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct.int_137);
																uint num65 = num64 + array7[0] * Class53.gstruct51_127.uint_0;
																int num66 = 0;
																byte[] array17 = new byte[1];
																Class22.ReadProcessMemory(gstruct.int_137, num65 + Class53.gstruct51_138.uint_0, array17, 1, ref num66);
																Class22.ReadProcessMemory(gstruct.int_137, num65 + Class53.gstruct51_137.uint_0, array9, 4, ref num66);
																bool flag114 = array17[0] == 0 || BitConverter.ToInt32(array9, 0) <= 0;
																if (flag114)
																{
																	array7 = null;
																}
															}
															bool flag115 = flag43 || array7 == null;
															if (flag115)
															{
																array7 = Class58.smethod_0(gstruct, array3, !flag43, Form1.int_21 > 0);
															}
															bool flag116 = !flag43 && array7 != null;
															if (flag116)
															{
																uint[] array18 = new uint[]
																{
																	array7[2],
																	array7[3]
																};
																long num67 = Class60.smethod_18(array10, array18);
																bool flag117 = num67 <= (long)num62;
																if (flag117)
																{
																	num11 = 0L;
																	bool flag118 = (long)num10 == (long)((ulong)array7[0]) && array8 != null && array8[0] == array7[2] && array8[1] == array7[3];
																	if (flag118)
																	{
																		uint uint_4 = array7[0];
																		uint num68 = array7[2];
																		uint num69 = array7[3];
																		int int_5 = (int)array7[4];
																		long long_12 = 0L;
																		long num70 = Class12.smethod_28(long_);
																		bool flag119 = num70 > 6000L;
																		if (!flag119)
																		{
																			bool flag120 = num70 > 1500L;
																			if (flag120)
																			{
																				bool flag121 = gstruct.int_27 <= 0 || gstruct.int_99 <= 1;
																				if (flag121)
																				{
																					flag107 = false;
																					goto IL_2727;
																				}
																				string string_ = Class83.smethod_20(gstruct);
																				bool flag122 = 0 < Class12.smethod_1(string_, "qu¸ xa") || 0 < Class12.smethod_1(string_, "o¶ng trèn");
																				if (flag122)
																				{
																					long_12 = Class12.smethod_27() - (long)Class58.int_0 + 6000L;
																					Class83.smethod_21(gstruct, "0K..");
																					bool flag123 = Class22.smethod_30(num29 + Class53.gstruct51_44.uint_0, gstruct.int_137) == 0U;
																					if (flag123)
																					{
																						Class70.smethod_57(gstruct, "Switch([[sit]])");
																					}
																					goto IL_2682;
																				}
																			}
																			goto IL_1813;
																		}
																		IL_2682:
																		Class58.smethod_4(ref gstruct.gstruct38_0, uint_4, int_5, long_12);
																		num10 = -1;
																		array7 = null;
																		long_ = Class12.smethod_27();
																		flag107 = false;
																		goto IL_2727;
																	}
																	num10 = (int)array7[0];
																	array8 = new uint[]
																	{
																		array7[2],
																		array7[3]
																	};
																	long_ = Class12.smethod_27();
																	IL_1813:
																	flag107 = true;
																	bool flag124 = num67 > 40000L;
																	if (flag124)
																	{
																		Class70.smethod_61(gstruct, array18);
																		Thread.Sleep(150);
																	}
																	Class70.smethod_48(gstruct, array7[0]);
																}
															}
														}
														IL_2727:
														array10 = new uint[]
														{
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
														};
														bool flag125 = flag9;
														if (flag125)
														{
															flag2 = true;
														}
														else
														{
															bool flag126 = gstruct.int_101[0] <= 0 || gstruct.int_101[1] <= 0 || !(gstruct.string_23 == "NGAMY");
															if (!flag126)
															{
																long num71 = Class12.smethod_28(long_4);
																bool flag127 = num71 >= 300L;
																if (flag127)
																{
																	bool flag128 = num71 <= (long)gstruct.int_101[4] || !Class7.smethod_3(gstruct);
																	if (flag128)
																	{
																		goto IL_2089;
																	}
																	Thread.Sleep(80);
																	long_4 = Class12.smethod_27();
																	flag2 = true;
																}
																else
																{
																	flag2 = true;
																}
																goto IL_284A;
															}
															IL_2089:
															array5 = null;
															bool flag129 = !gstruct.bool_22 && gstruct.int_99 > 1 && (gstruct.int_27 > 0 || Form1.int_30 > 0);
															if (flag129)
															{
																uint uint_5 = 0U;
																uint[] uint_6 = array10;
																bool flag130 = flag43;
																if (flag130)
																{
																	bool flag131 = Form1.int_33 > 0 && Class44.gstruct33_0.int_4 == num33 && Class44.gstruct33_0.uint_3 != 0U && Class44.gstruct33_0.uint_3 != num30;
																	if (flag131)
																	{
																		uint_5 = Class44.gstruct33_0.uint_3;
																	}
																	uint_6 = array3;
																}
																Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array9, 4, ref num18);
																gstruct.int_97 = BitConverter.ToInt32(array9, 0);
																int int_6 = 600;
																bool flag132 = gstruct.int_98 > 0;
																if (flag132)
																{
																	int_6 = gstruct.int_99;
																}
																int num72 = gstruct.int_97;
																bool flag133 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
																if (flag133)
																{
																	num72 = gstruct.int_96;
																}
																bool flag134 = num72 <= 0;
																if (flag134)
																{
																}
																array5 = Class7.smethod_9(gstruct, uint_5, int_6, uint_6, int_2, true);
																bool flag135 = array5 != null && array5[0, 0] >= 0;
																if (flag135)
																{
																	int num73 = array5[0, 0];
																	int num74 = array5[0, 1];
																	uint[] array19 = new uint[]
																	{
																		(uint)array5[0, 4],
																		(uint)array5[0, 5]
																	};
																	uint num75 = num28 + (uint)(num74 * (int)Class53.gstruct51_15.uint_0);
																	bool flag136 = num73 <= 0;
																	if (flag136)
																	{
																		goto IL_1AA8;
																	}
																	bool flag137 = false;
																	bool flag138 = gstruct.int_33 == 1;
																	if (flag138)
																	{
																		bool flag139 = !Class32.smethod_0(num33);
																		if (flag139)
																		{
																			Class60.smethod_14(gstruct, true);
																			Thread.Sleep(150);
																		}
																		flag137 = true;
																	}
																	bool flag140 = gstruct.int_33 != 0 && !flag137;
																	if (flag140)
																	{
																		bool flag141 = gstruct.int_33 != 2;
																		if (flag141)
																		{
																			bool flag142 = gstruct.int_33 != 3;
																			if (flag142)
																			{
																				goto IL_1AA8;
																			}
																			string text2 = Class10.smethod_2("Thoát game vì bị đồ sát.");
																			bool flag143 = Class44.gstruct33_0.int_0 > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0;
																			if (flag143)
																			{
																				Class70.smethod_50(gstruct, Class44.gstruct33_0.string_0, text2);
																			}
																			Class70.smethod_57(gstruct, "Chat('CH_TONG', '" + text2 + "')");
																			Thread.Sleep(150);
																			Class22.smethod_53(gstruct.process_0);
																		}
																	}
																	else
																	{
																		bool flag144 = num23 > 0;
																		if (flag144)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																		}
																		num23 = 0;
																		bool flag145 = num41 <= 1;
																		if (flag145)
																		{
																			uint[] uint_7 = (num41 == 1 && array3 != null && Class60.smethod_18(array10, array3) > 500000L) ? array3 : Class60.smethod_5(array19, array10, 600);
																			Class70.smethod_61(gstruct, uint_7);
																			Thread.Sleep(100);
																			goto IL_2507;
																		}
																		flag2 = true;
																		goto IL_2491;
																	}
																	IL_2B09:
																	long num76 = Class60.smethod_18(array3, array19);
																	long num77 = Class60.smethod_18(array10, array3);
																	bool flag146 = num76 > (long)num42 || (flag43 && num77 > (long)(Form1.int_23 * Form1.int_23));
																	if (flag146)
																	{
																		flag2 = true;
																		bool flag147 = num23 > 0;
																		if (flag147)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																		}
																		num23 = 0;
																		goto IL_2499;
																	}
																	bool flag148 = flag42;
																	if (flag148)
																	{
																		int num78 = -1;
																		while (!Class12.bool_0)
																		{
																			num16++;
																			bool flag149 = num16 < 0 || gstruct.int_3.GetLength(0) <= num16;
																			if (flag149)
																			{
																				num16 = 0;
																			}
																			bool flag150 = num78 < 0;
																			if (flag150)
																			{
																				num78 = num16;
																			}
																			else
																			{
																				bool flag151 = num78 == num16;
																				if (flag151)
																				{
																					num16 = -1;
																					break;
																				}
																			}
																			bool flag152 = gstruct.int_3[num16, 0] > 0;
																			if (flag152)
																			{
																				int num79 = Class12.smethod_43(gstruct.int_4, gstruct.int_3[num16, 0], 0);
																				bool flag153 = num79 >= 0 && Class98.smethod_31(gstruct, num74, gstruct.int_3[num16, 0]) != 0;
																				if (flag153)
																				{
																					num63 = (uint)gstruct.int_3[num16, 0];
																					break;
																				}
																			}
																		}
																	}
																	bool flag154 = Class70.smethod_3(gstruct, Class70.uint_6, 4) <= 0;
																	if (flag154)
																	{
																		Class36.smethod_51(gstruct, num61);
																		Class77.smethod_15(gstruct, num63, false);
																		Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num74), 4, ref num18);
																	}
																	bool flag155 = gstruct.bool_58 && gstruct.int_83 > 0 && Form1.int_99 == 0 && Class12.smethod_28(long_3) > gstruct.long_8;
																	if (flag155)
																	{
																		Class36.smethod_54(gstruct, array19, false, 10);
																		Class36.smethod_55(gstruct);
																		long_3 = Class12.smethod_27();
																	}
																	num11 = 0L;
																	num23 = 1;
																	bool flag156 = flag43;
																	if (flag156)
																	{
																		goto IL_26A8;
																	}
																	goto IL_2507;
																	IL_1AA8:
																	int num80 = (int)Class22.smethod_30(num75 + Class53.gstruct51_26.uint_0 + 8U, gstruct.int_137);
																	int num81 = (int)Class22.smethod_30(num75 + Class53.gstruct51_26.uint_0 + 12U, gstruct.int_137);
																	int num82 = (int)Class22.smethod_30(num75 + Class53.gstruct51_51.uint_0, gstruct.int_137);
																	bool flag157 = gstruct.int_57 <= 0 || num73 > 0 || num80 <= 0 || num81 <= 15 || num82 <= 0;
																	if (flag157)
																	{
																		bool flag158 = num80 <= 0 || num81 <= 15 || num82 <= 0;
																		if (flag158)
																		{
																			bool flag159 = num3 != num74;
																			if (flag159)
																			{
																				num3 = num74;
																				num14 = (long)((ulong)Class22.smethod_30(num75 + Class53.gstruct51_45.uint_0, gstruct.int_137));
																				long_7 = Class12.smethod_27();
																			}
																			else
																			{
																				long num83 = (long)((ulong)Class22.smethod_30(num75 + Class53.gstruct51_45.uint_0, gstruct.int_137));
																				bool flag160 = num83 < num14;
																				if (flag160)
																				{
																					long_7 = Class12.smethod_27();
																					num14 = num83;
																				}
																				else
																				{
																					long num84 = Class12.smethod_28(long_7);
																					bool flag161 = num84 >= 7000L;
																					if (flag161)
																					{
																						bool flag162 = num23 > 0;
																						if (flag162)
																						{
																							Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																						}
																						num23 = 0;
																						Class12.smethod_37(ref int_2, num3);
																						num5 = -1;
																						num6 = 0;
																						num3 = -1;
																						bool flag163 = Class22.smethod_30(num29 + Class53.gstruct51_44.uint_0, gstruct.int_137) == 0U;
																						if (flag163)
																						{
																							Class70.smethod_57(gstruct, "Switch([[sit]])");
																							Thread.Sleep(600);
																						}
																						long_7 = Class12.smethod_27();
																						long_6 = Class12.smethod_27();
																					}
																				}
																			}
																		}
																		goto IL_2B09;
																	}
																	flag2 = true;
																}
																IL_2491:;
															}
															else
															{
																flag2 = true;
															}
														}
														IL_284A:
														goto IL_2499;
														goto IL_2727;
													}
													flag2 = true;
													IL_2499:
													bool flag164 = !flag2 && array5 != null && array5[0, 0] >= 0;
													if (!flag164)
													{
														goto IL_24F7;
													}
													bool flag165 = array5[0, 1] <= 0;
													if (flag165)
													{
														goto IL_24F7;
													}
													int num85 = 0;
													IL_284F:
													bool flag166 = num85 != 0;
													if (flag166)
													{
														flag2 = false;
														num3 = -1;
														array10 = new uint[]
														{
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
														};
														bool flag167 = Class44.gstruct33_0.int_0 == gstruct.int_136;
														if (flag167)
														{
															Class44.gstruct33_0.bool_2 = (flag7 || gstruct.uint_0 == null || num41 <= 0);
														}
														bool flag168 = num13 <= 0L || Class12.smethod_28(num13) >= 1000L;
														if (flag168)
														{
															uint[] array20 = Class60.smethod_26(gstruct, ref num4);
															bool flag169 = array20 != null;
															if (flag169)
															{
																num13 = 0L;
																array3 = array20;
																long num86 = Class60.smethod_18(array10, array20);
																bool flag170 = num86 >= 8000L;
																if (flag170)
																{
																	bool flag171 = num23 > 0;
																	if (flag171)
																	{
																		Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																	}
																	num23 = 0;
																	bool flag172 = num86 >= 15000L && num86 >= (long)(gstruct.int_68[1] * gstruct.int_68[1]);
																	if (flag172)
																	{
																		bool flag173 = num86 < 360000L;
																		if (flag173)
																		{
																			Class14.smethod_2(gstruct, false);
																			Class70.smethod_61(gstruct, array20);
																			Thread.Sleep(100);
																		}
																		else
																		{
																			bool flag174 = num86 >= 1200000L;
																			if (flag174)
																			{
																				goto IL_1CC5;
																			}
																			bool flag175 = Class12.smethod_28(long_2) > 3000L;
																			if (flag175)
																			{
																				Class14.smethod_1(gstruct, array20);
																				long_2 = Class12.smethod_27();
																			}
																		}
																	}
																	else
																	{
																		bool flag176 = num31 <= 3 && num86 > 7500L;
																		if (flag176)
																		{
																			Class70.smethod_61(gstruct, array20);
																			Thread.Sleep(100);
																		}
																	}
																}
																goto IL_2507;
															}
															num13 = Class12.smethod_27();
														}
														IL_1CC5:
														bool flag177 = flag43;
														if (flag177)
														{
															array3 = Class44.gstruct33_0.uint_4;
														}
														else
														{
															bool flag178 = gstruct.uint_0 == null || num41 <= 0;
															if (flag178)
															{
																array3 = array10;
																flag7 = true;
																flag9 = false;
																goto IL_2507;
															}
															bool flag179 = array3 == null || num5 < 0 || num41 <= num5 || num6 == 0;
															if (flag179)
															{
																num5 = Class60.smethod_20(gstruct.uint_0, array10);
																bool flag180 = num5 < 0 || num41 == 1;
																if (flag180)
																{
																	num5 = 0;
																}
																array3 = new uint[]
																{
																	gstruct.uint_0[num5, 0],
																	gstruct.uint_0[num5, 1]
																};
																num6 = 1;
															}
														}
														bool flag181 = Class60.smethod_18(array10, array3) <= 8100L;
														if (flag181)
														{
															num22 = 0;
															num11 = 0L;
															flag7 = true;
															flag9 = false;
															bool flag182 = flag43;
															if (flag182)
															{
																goto IL_26A8;
															}
															num5 += num6;
															bool flag183 = gstruct.int_29 <= 0;
															if (flag183)
															{
																bool flag184 = num5 < 0;
																if (flag184)
																{
																	num5 = ((num41 != 1) ? 1 : 0);
																	num6 = 1;
																}
																else
																{
																	bool flag185 = num41 <= num5;
																	if (flag185)
																	{
																		num5 = ((num41 != 1) ? (num41 - 2) : 0);
																		num6 = -1;
																	}
																}
															}
															else
															{
																bool flag186 = num5 < 0 || num41 <= num5;
																if (flag186)
																{
																	num5 = 0;
																}
																num6 = 1;
															}
															array3 = new uint[]
															{
																gstruct.uint_0[num5, 0],
																gstruct.uint_0[num5, 1]
															};
														}
														bool flag187 = num23 > 0;
														if (flag187)
														{
															Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
														}
														num23 = 0;
														array10 = new uint[]
														{
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
															Class22.smethod_30(num29 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
														};
														long num87 = Class60.smethod_18(array10, array3);
														bool flag188 = num87 > 1500000L;
														if (!flag188)
														{
															flag7 = true;
															flag9 = false;
															Class14.smethod_2(gstruct, false);
															bool flag189 = num11 == 0L;
															if (flag189)
															{
																num11 = Class12.smethod_27();
															}
															bool flag190 = num22 <= 6;
															if (flag190)
															{
																bool flag191 = Class12.smethod_28(num11) > 6000L;
																if (flag191)
																{
																	num22++;
																	bool flag192 = num22 > 2;
																	if (flag192)
																	{
																		bool flag193 = num22 == 3;
																		if (flag193)
																		{
																			Class60.smethod_2(gstruct, array10, array3, 800);
																		}
																		num7 = 0;
																		goto IL_25B4;
																	}
																	bool flag194 = Class22.smethod_30(num29 + Class53.gstruct51_44.uint_0, gstruct.int_137) > 0U;
																	if (flag194)
																	{
																		Class60.smethod_29(gstruct, true);
																	}
																	else
																	{
																		Class70.smethod_57(gstruct, "Switch([[sit]])");
																		Thread.Sleep(600);
																		num11 = Class12.smethod_27();
																	}
																}
																Class70.smethod_61(gstruct, array3);
																Thread.Sleep(100);
																goto IL_2507;
															}
															num5 = -1;
															num22 = 0;
															num11 = 0L;
															flag9 = (gstruct.int_30 <= 0);
															continue;
														}
														IL_25B4:
														flag9 = (gstruct.int_30 <= 0);
														bool flag195 = array4 == null || Class60.smethod_18(array10, array4) > 90000L;
														if (flag195)
														{
															array4 = new uint[]
															{
																array10[0],
																array10[1]
															};
															num7 = 0;
														}
														bool flag196 = num7 > 5;
														if (flag196)
														{
															Class60.smethod_2(gstruct, array10, array3, 800);
															array4 = null;
														}
														bool flag197 = !flag7;
														if (flag197)
														{
															Class6.smethod_2(gstruct, num29, ref num12, true);
														}
														bool flag198 = Class12.smethod_28(long_2) > 2500L;
														if (flag198)
														{
															Class14.smethod_1(gstruct, array3);
															long_2 = Class12.smethod_27();
															num7++;
														}
														goto IL_26A8;
														goto IL_1CC5;
													}
													goto IL_2507;
													IL_24F7:
													num85 = ((!flag107) ? 1 : 0);
													goto IL_284F;
													IL_26A8:
													bool flag199 = flag43;
													if (flag199)
													{
														bool flag200 = Class44.smethod_5(num30, ref array10, ref num15) > 0;
														if (flag200)
														{
															Class12.smethod_27();
															bool flag201 = num23 > 0;
															if (flag201)
															{
																Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
															}
															num23 = 0;
															Class44.smethod_6(gstruct, array10, uint_2, false);
														}
													}
												}
											}
											IL_2507:
											bool flag202 = Class83.smethod_12(gstruct) <= 0 && Class22.smethod_30(num29 + Class53.gstruct51_43.uint_0, gstruct.int_137) != 0U && gstruct.bool_58 && gstruct.int_83 > 0 && Form1.int_99 > 0 && Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
											if (flag202)
											{
												Class36.smethod_54(gstruct, null, true, 10);
												bool flag203 = Class12.smethod_28(long_3) > gstruct.long_8;
												if (flag203)
												{
													Class36.smethod_55(gstruct);
													long_3 = Class12.smethod_27();
												}
											}
											continue;
											goto IL_2507;
										}
										bool flag204 = num23 > 0;
										if (flag204)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
										}
										num23 = 0;
										num21++;
										bool flag205 = num21 > 2;
										if (flag205)
										{
											num5 = -1;
										}
										bool flag206 = Form1.int_121 > 0;
										if (flag206)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num18);
										}
									}
									else
									{
										Class14.smethod_2(gstruct, false);
										bool flag207 = num23 > 0;
										if (flag207)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
										}
										num23 = 0;
										int j = 0;
										while (num34 == 0 && j < 3 && num34 != num2)
										{
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array9, 4, ref num18);
											num25 = BitConverter.ToUInt32(array9, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_13.uint_0, array9, 4, ref num18);
											num26 = BitConverter.ToUInt32(array9, 0);
											num27 = num26 * Class53.gstruct51_15.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array9, 4, ref num18);
											num28 = BitConverter.ToUInt32(array9, 0);
											num29 = num28 + num27;
											Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_50.uint_0, array9, 4, ref num18);
											num32 = BitConverter.ToInt32(array9, 0);
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array9, 4, ref num18);
											num33 = BitConverter.ToInt32(array9, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_43.uint_0, array9, 4, ref num18);
											num34 = BitConverter.ToInt32(array9, 0);
											Thread.Sleep(100);
											j++;
										}
										num = num33;
										num2 = num34;
										bool flag208 = num34 <= 0;
										if (flag208)
										{
											Class86.smethod_8(gstruct, -1);
										}
									}
								}
							}
						}
						else
						{
							flag10 = (num31 == 10 || num31 == 21);
						}
					}
					else
					{
						Thread.Sleep(100);
					}
				}
				else
				{
					FormLuomrac.smethod_0(int_1);
				}
			}
			return -1;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0009C5A4 File Offset: 0x0009A7A4
		public static bool smethod_2(GStruct49 gstruct49_0, uint uint_0, ref long long_0, bool bool_0)
		{
			bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_20, 4) == 0 || Class12.smethod_28(long_0) < 800L;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag3;
				bool flag2 = (!(flag3 = (Class22.smethod_30(uint_0 + Class53.gstruct51_44.uint_0, gstruct49_0.int_137) > 0U)) || bool_0) && (flag3 || !bool_0);
				if (flag2)
				{
					result = true;
				}
				else
				{
					Class70.smethod_57(gstruct49_0, "Switch([[horse]])");
					long_0 = Class12.smethod_27();
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0009C62C File Offset: 0x0009A82C
		public static void smethod_3(GStruct49 gstruct49_0)
		{
			int int_ = gstruct49_0.int_136;
			int num = 0;
			string[] array = new string[]
			{
				"ThÇn Hµnh Phï",
				"Håi thµnh phï",
				"LÖnh Bµi ADMIN",
				"Tiªn Th¶o Lé",
				"TiÒn ®ång",
				"TiÒn §ång"
			};
			bool flag = false;
			int num2 = 0;
			for (;;)
			{
				uint num7;
				int num8;
				int num9;
				for (;;)
				{
					IL_52:
					Thread.Sleep(300);
					int num3 = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num3 < 0 || !Form1.gstruct49_0[num3].bool_25 || Form1.gstruct49_0[num3].int_53 == null;
					if (flag2)
					{
						goto Block_4;
					}
					byte[] byte_ = new byte[]
					{
						1
					};
					Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_34 * 4U, byte_, 1, ref num2);
					gstruct49_0 = Form1.gstruct49_0[num3];
					string[] string_ = gstruct49_0.string_5;
					bool flag3 = gstruct49_0.int_53[0] <= 0 && gstruct49_0.int_53[1] <= 0 && gstruct49_0.int_53[2] <= 0 && gstruct49_0.int_53[3] <= 0 && gstruct49_0.int_53[4] <= 0;
					if (flag3)
					{
						goto Block_9;
					}
					uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
					uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
					uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
					num7 = num6 + num5 * Class53.gstruct51_15.uint_0;
					Class22.smethod_30(num7, gstruct49_0.int_137);
					num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					bool flag4 = num9 == 0 || num8 == 0 || num8 == 10 || num8 == 21;
					if (flag4)
					{
						break;
					}
					int num10 = (int)Class22.smethod_30(num7 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
					bool flag5 = num10 > 0;
					if (flag5)
					{
						goto Block_16;
					}
					int num11 = 0;
					byte[] array2 = new byte[80];
					byte[] array3 = new byte[4];
					uint num12 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
					uint num13 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
					int num14 = Class79.smethod_4(gstruct49_0);
					int num15 = 0;
					uint num16 = 1U;
					while ((ulong)num16 < (ulong)((long)Class53.int_1))
					{
						bool flag6 = num14 <= num15;
						if (flag6)
						{
							break;
						}
						uint num17 = num13 + num16 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
						bool flag7 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag7)
						{
							uint uint_ = num17 + Class53.gstruct51_107.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array3, 1, ref num2);
							bool flag8 = array3[0] == 0;
							if (!flag8)
							{
								uint num18 = Class79.smethod_1(gstruct49_0, num16);
								bool flag9 = num18 <= 0U;
								if (!flag9)
								{
									num15++;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_108.uint_0, array3, 4, ref num11);
									int num19 = BitConverter.ToInt32(array3, 0);
									bool flag10 = num19 == 1 || num19 == 5;
									if (!flag10)
									{
										uint num20 = num12 + num18 * 20U;
										uint num21 = Class22.smethod_30(num20 + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
										bool flag11 = num21 != 3U;
										if (!flag11)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, array2.Length, ref num11);
											string text = Class10.smethod_3(array2).Trim();
											bool flag12 = text == null || text == string.Empty;
											if (!flag12)
											{
												bool flag13 = false;
												bool flag14 = string_ != null;
												if (flag14)
												{
													for (int i = 0; i < string_.Length; i++)
													{
														bool flag15 = Class12.smethod_2(text, string_[i].Trim(), false);
														if (flag15)
														{
															flag13 = true;
															break;
														}
													}
												}
												bool flag16 = flag13;
												if (!flag16)
												{
													bool flag17 = array != null;
													if (flag17)
													{
														for (int j = 0; j < array.Length; j++)
														{
															bool flag18 = Class12.smethod_2(text, array[j].Trim(), false);
															if (flag18)
															{
																flag13 = true;
																break;
															}
														}
													}
													bool flag19 = flag13;
													if (!flag19)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_119.uint_0, array3, 4, ref num11);
														int num22 = BitConverter.ToInt32(array3, 0);
														Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_119.uint_0 + 4U, array3, 4, ref num11);
														int num23 = BitConverter.ToInt32(array3, 0);
														bool flag20 = num19 == 6 && num22 < num23;
														if (!flag20)
														{
															uint uint_2 = Class22.smethod_30(num20 + Class53.gstruct51_100.uint_0 - 4U, gstruct49_0.int_137);
															uint uint_3 = Class22.smethod_30(num20 + Class53.gstruct51_100.uint_0, gstruct49_0.int_137);
															uint num24 = Class22.smethod_30(num17 + Class53.gstruct51_111.uint_0, gstruct49_0.int_137);
															uint num25 = Class22.smethod_30(num17 + Class53.gstruct51_112.uint_0, gstruct49_0.int_137);
															uint num26 = 4U;
															uint[] array4 = null;
															bool flag21 = gstruct49_0.int_53[0] > 0;
															if (flag21)
															{
																num26 = 4U;
																array4 = Class79.smethod_26(gstruct49_0, num26, num24, num25);
															}
															bool flag22 = array4 == null && gstruct49_0.int_53[1] > 0;
															if (flag22)
															{
																num26 = 9U;
																array4 = Class79.smethod_26(gstruct49_0, num26, num24, num25);
															}
															bool flag23 = array4 == null && gstruct49_0.int_53[2] > 0;
															if (flag23)
															{
																num26 = 10U;
																array4 = Class79.smethod_26(gstruct49_0, num26, num24, num25);
															}
															bool flag24 = array4 == null && gstruct49_0.int_53[3] > 0;
															if (flag24)
															{
																num26 = 11U;
																array4 = Class79.smethod_26(gstruct49_0, num26, num24, num25);
															}
															bool flag25 = array4 == null && gstruct49_0.int_53[4] > 0;
															if (flag25)
															{
																num26 = 23U;
																array4 = Class79.smethod_26(gstruct49_0, num26, num24, num25);
															}
															bool flag26 = array4 != null;
															if (flag26)
															{
																bool flag27 = num <= 0;
																if (flag27)
																{
																	num = Class91.smethod_0(gstruct49_0, false, null);
																	bool flag28 = num < 0;
																	if (flag28)
																	{
																		Class60.smethod_12(gstruct49_0, true);
																	}
																}
																bool flag29 = !Class45.smethod_8(gstruct49_0);
																if (flag29)
																{
																	goto IL_52;
																}
																bool flag30 = !flag && gstruct49_0.string_15 != null && gstruct49_0.string_15 != string.Empty;
																if (flag30)
																{
																	uint num27 = Class12.smethod_12(gstruct49_0.string_15);
																	bool flag31 = num27 > 0U;
																	if (flag31)
																	{
																		Class70.smethod_117(gstruct49_0, num27);
																		flag = true;
																		Thread.Sleep(300);
																	}
																}
																int k = 0;
																Class70.smethod_46(gstruct49_0, uint_2, uint_3, num21, array4[0], array4[1], num26);
																while (k < 30)
																{
																	uint num28 = Class22.smethod_30(num20 + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
																	bool flag32 = num28 != num21;
																	if (flag32)
																	{
																		break;
																	}
																	Thread.Sleep(10);
																	k++;
																}
															}
															else
															{
																bool flag33 = num24 <= 1U && num25 <= 1U;
																if (flag33)
																{
																	break;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						num16 += 1U;
					}
					goto IL_7E6;
				}
				int num29 = 0;
				while (num9 == 0 && num29 < 10)
				{
					num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					bool flag34 = num9 != 0;
					if (flag34)
					{
						break;
					}
					Thread.Sleep(80);
					num29++;
				}
				num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			}
			Block_4:
			Block_9:
			Block_16:
			IL_7E6:
			Class70.smethod_2(gstruct49_0, Class70.uint_33, 0, 4);
			Class70.smethod_2(gstruct49_0, Class70.uint_34, 0, 4);
			bool flag35 = Class45.smethod_8(gstruct49_0);
			if (flag35)
			{
				Class45.smethod_11(gstruct49_0);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0009CE58 File Offset: 0x0009B058
		public static void smethod_4(GStruct49 gstruct49_0)
		{
			int int_ = gstruct49_0.int_136;
			int num = Class81.smethod_3(Form1.gstruct49_0, int_);
			bool flag = num >= 0;
			if (flag)
			{
				int num2 = 0;
				byte[] byte_ = new byte[]
				{
					1
				};
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_35 * 4U, byte_, 1, ref num2);
				gstruct49_0 = Form1.gstruct49_0[num];
				string[] string_ = gstruct49_0.string_4;
				int num3 = 0;
				byte[] array = new byte[80];
				byte[] array2 = new byte[4];
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
				uint num5 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				uint num6 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num7 = Class22.smethod_30(num6 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num8 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num9 = num8 + num7 * Class53.gstruct51_15.uint_0;
				for (uint num10 = 1U; num10 < 210U; num10 += 1U)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_43.uint_0, array2, 4, ref num3);
					bool flag2 = BitConverter.ToInt32(array2, 0) > 0;
					if (flag2)
					{
						break;
					}
					bool flag3 = num10 != 0U && num10 % 10U == 0U;
					if (flag3)
					{
						Thread.Sleep(15);
					}
					bool flag4 = !Class79.smethod_3(gstruct49_0, num10);
					if (!flag4)
					{
						uint num11 = num5 + num10 * Class53.gstruct51_106.uint_0;
						uint uint_ = num11 + Class53.gstruct51_107.uint_0;
						bool flag5 = !Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num3) || array[0] == 0;
						if (!flag5)
						{
							uint num12 = Class79.smethod_1(gstruct49_0, num10);
							uint num13 = Class22.smethod_30(num4 + num12 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
							bool flag6 = num12 <= 0U || num13 != 3U;
							if (!flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_108.uint_0, array2, 4, ref num3);
								int num14 = BitConverter.ToInt32(array2, 0);
								bool flag7 = num14 > 0;
								if (!flag7)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_109.uint_0, array2, 4, ref num3);
									int num15 = BitConverter.ToInt32(array2, 0);
									bool flag8 = num15 == 1 || num15 == 4;
									if (!flag8)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_120.uint_0, array2, 4, ref num3);
										bool flag9 = BitConverter.ToInt32(array2, 0) != 0;
										if (!flag9)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_119.uint_0, array2, 4, ref num3);
											int num16 = BitConverter.ToInt32(array2, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num3);
											int num17 = BitConverter.ToInt32(array2, 0);
											bool flag10 = num16 == 0 && num17 > 0;
											if (!flag10)
											{
												bool flag11 = gstruct49_0.int_46[1] <= 0;
												if (flag11)
												{
													bool flag12 = string_ != null;
													if (flag12)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num3);
														string text = Class10.smethod_3(array).Trim();
														bool flag13 = text == null || text == string.Empty;
														if (flag13)
														{
															goto IL_914;
														}
														for (int i = 0; i < string_.Length; i++)
														{
															bool flag14 = 0 > Class12.smethod_1(text, string_[i]);
															if (!flag14)
															{
																goto IL_825;
															}
														}
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_110.uint_0, array2, 4, ref num3);
													int num18 = BitConverter.ToInt32(array2, 0);
													bool flag15 = num18 > 9;
													if (flag15)
													{
														goto IL_914;
													}
													bool flag16 = gstruct49_0.int_43[0] > 0 && num18 == 3;
													if (flag16)
													{
														bool flag17 = gstruct49_0.int_43[1] <= 0;
														if (flag17)
														{
															goto IL_914;
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_43[1] - 1) * 16), array2, 4, ref num3);
														bool flag18 = BitConverter.ToInt32(array2, 0) != 0;
														if (flag18)
														{
															goto IL_914;
														}
													}
													else
													{
														bool flag19 = gstruct49_0.int_44[0] > 0 && num18 == 4;
														if (flag19)
														{
															bool flag20 = gstruct49_0.int_44[1] <= 0;
															if (flag20)
															{
																goto IL_914;
															}
															Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_44[1] - 1) * 16), array2, 4, ref num3);
															bool flag21 = BitConverter.ToInt32(array2, 0) != 0;
															if (flag21)
															{
																goto IL_914;
															}
														}
														else
														{
															bool flag22 = gstruct49_0.int_45[0] > 0 && num18 == 9;
															if (flag22)
															{
																bool flag23 = gstruct49_0.int_45[1] <= 0;
																if (flag23)
																{
																	goto IL_914;
																}
																Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_45[1] - 1) * 16), array2, 4, ref num3);
																bool flag24 = BitConverter.ToInt32(array2, 0) != 0;
																if (flag24)
																{
																	goto IL_914;
																}
															}
														}
													}
													bool flag25 = gstruct49_0.int_49 > 0 && num15 == 2;
													if (flag25)
													{
														goto IL_914;
													}
													bool flag26 = gstruct49_0.int_47[0] > 0;
													if (flag26)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_114.uint_0, array2, 4, ref num3);
														bool flag27 = gstruct49_0.int_47[1] <= BitConverter.ToInt32(array2, 0);
														if (flag27)
														{
															goto IL_914;
														}
													}
													bool flag28 = gstruct49_0.int_48[0] > 0;
													if (flag28)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_115.uint_0, array2, 4, ref num3);
														bool flag29 = gstruct49_0.int_48[1] == BitConverter.ToInt32(array2, 0);
														if (flag29)
														{
															goto IL_914;
														}
													}
													bool flag30 = gstruct49_0.int_50 > 0;
													if (flag30)
													{
														int num19 = 0;
														int num20 = 0;
														for (int j = 0; j < gstruct49_0.gstruct37_0.Length; j++)
														{
															bool flag31 = gstruct49_0.gstruct37_0[j].int_0 <= 0;
															if (!flag31)
															{
																num20++;
																bool flag32 = false;
																for (uint num21 = 0U; num21 < 6U; num21 += 1U)
																{
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + num21 * 16U, array2, 4, ref num3);
																	int num22 = BitConverter.ToInt32(array2, 0);
																	bool flag33 = gstruct49_0.gstruct37_0[j].int_1 == num22;
																	if (flag33)
																	{
																		Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + num21 * 16U + 4U, array2, 4, ref num3);
																		int num23 = BitConverter.ToInt32(array2, 0);
																		Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_118.uint_0 + num21 * 16U + 12U, array2, 4, ref num3);
																		int num24 = BitConverter.ToInt32(array2, 0);
																		bool flag34 = gstruct49_0.gstruct37_0[j].int_2 <= num23 && num23 > 0;
																		bool flag35 = gstruct49_0.gstruct37_0[j].int_2 <= num24 && num24 > 0;
																		bool flag36 = gstruct49_0.gstruct37_0[j].int_2 <= 0;
																		bool flag37 = flag34 || flag35 || flag36;
																		if (flag37)
																		{
																			num19++;
																			flag32 = true;
																			break;
																		}
																	}
																}
																bool flag38 = flag32 || gstruct49_0.int_41 <= 0;
																if (!flag38)
																{
																	goto IL_825;
																}
															}
														}
														bool flag39 = num20 == 0 || (gstruct49_0.int_41 > 0 && num20 <= num19) || (gstruct49_0.int_41 <= 0 && num19 > 0);
														if (flag39)
														{
															goto IL_914;
														}
													}
												}
												IL_825:
												int num25 = 0;
												while (!Class12.bool_0 && num25 < 150)
												{
													bool flag40 = num25 % 30 == 0;
													if (flag40)
													{
														Class70.smethod_35(gstruct49_0, num10);
													}
													Thread.Sleep(10);
													bool flag41 = num25 % 10 == 0;
													if (flag41)
													{
														string string_2 = Class83.smethod_22(gstruct49_0);
														bool flag42 = Class12.smethod_1(string_2, "hÊt b¹i") > 0;
														if (flag42)
														{
															Class83.smethod_23(gstruct49_0, "0K..");
															break;
														}
													}
													bool flag43 = Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num3) && array[0] > 0;
													if (!flag43)
													{
														break;
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_43.uint_0, array2, 4, ref num3);
													bool flag44 = BitConverter.ToInt32(array2, 0) <= 0;
													if (!flag44)
													{
														break;
													}
													num25++;
												}
												goto IL_914;
												goto IL_825;
											}
										}
									}
								}
							}
						}
					}
					IL_914:;
				}
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_35, 0, 4);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0009D7A0 File Offset: 0x0009B9A0
		public static void smethod_5()
		{
			int num = Class6.int_0;
			Class6.int_0 = 0;
			int num2 = 0;
			int num3 = 0;
			byte[] array = new byte[1];
			int num4;
			bool flag16;
			do
			{
				for (;;)
				{
					IL_21:
					Thread.Sleep(300);
					num4 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25 || Form1.gstruct49_0[num4].int_37 <= 0;
					if (flag)
					{
						goto Block_4;
					}
					Form1.gstruct49_0[num4].bool_7 = true;
					GStruct49 gstruct = Form1.gstruct49_0[num4];
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_35 * 4U, array, 1, ref num3);
					bool flag2 = array[0] > 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_34 * 4U, array, 1, ref num3);
						bool flag3 = array[0] > 0;
						if (!flag3)
						{
							uint num5 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
							uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_13.uint_0, gstruct.int_137);
							uint num7 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
							uint num8 = num7 + num6 * Class53.gstruct51_15.uint_0;
							Class22.smethod_30(num8, gstruct.int_137);
							bool flag4 = Class22.smethod_30(num8 + Class53.gstruct51_50.uint_0, gstruct.int_137) > 0U;
							if (!flag4)
							{
								goto IL_4D3;
							}
							bool flag5 = Class45.smethod_21(gstruct) < 0;
							if (flag5)
							{
								goto Block_8;
							}
							byte[] array2 = new byte[80];
							byte[] array3 = new byte[4];
							uint num9 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_97.uint_0;
							uint num10 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
							int num11 = Class79.smethod_4(gstruct);
							int num12 = 0;
							uint num13 = 1U;
							while ((ulong)num13 < (ulong)((long)Class53.int_1))
							{
								Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_35 * 4U, array, 1, ref num3);
								bool flag6 = array[0] <= 0;
								if (flag6)
								{
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_34 * 4U, array, 1, ref num3);
									bool flag7 = array[0] <= 0;
									if (flag7)
									{
										bool flag8 = num13 != 0U && num13 % 50U == 0U;
										if (flag8)
										{
											Thread.Sleep(10);
										}
										bool flag9 = num11 <= num12;
										if (flag9)
										{
											break;
										}
										uint num14 = num10 + num13 * Class53.gstruct51_106.uint_0;
										Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num3);
										bool flag10 = BitConverter.ToInt32(array3, 0) == 0;
										if (flag10)
										{
											uint uint_ = num14 + Class53.gstruct51_107.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, uint_, array3, 1, ref num3);
											bool flag11 = array3[0] > 0;
											if (flag11)
											{
												uint num15 = Class79.smethod_1(gstruct, num13);
												bool flag12 = num15 > 0U;
												if (flag12)
												{
													num12++;
													uint num16 = num9 + num15 * 20U;
													uint num17 = Class22.smethod_30(num16 + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
													bool flag13 = num17 == 3U;
													if (flag13)
													{
														uint num18 = Class22.smethod_30(num16 + Class53.gstruct51_100.uint_0 - 4U, gstruct.int_137);
														uint num19 = Class22.smethod_30(num16 + Class53.gstruct51_100.uint_0, gstruct.int_137);
														uint uint_2 = Class22.smethod_30(num14 + Class53.gstruct51_111.uint_0, gstruct.int_137);
														uint uint_3 = Class22.smethod_30(num14 + Class53.gstruct51_112.uint_0, gstruct.int_137);
														Class22.ReadProcessMemory(gstruct.int_137, uint_, array2, array2.Length, ref num3);
														Class10.smethod_3(array2).Trim();
														uint num20 = 3U;
														uint[] array4 = Class79.smethod_26(gstruct, num20, uint_2, uint_3);
														bool flag14 = array4 != null && array4[1] <= num19 && (array4[1] != num19 || num18 >= array4[0]);
														if (flag14)
														{
															Class70.smethod_46(gstruct, num18, num19, num17, array4[0], array4[1], num20);
															for (int i = 0; i < 30; i++)
															{
																uint num21 = Class22.smethod_30(num16 + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
																bool flag15 = num17 != num21;
																if (flag15)
																{
																	break;
																}
																Thread.Sleep(10);
															}
														}
													}
												}
											}
										}
										num13 += 1U;
										continue;
									}
								}
								goto IL_21;
							}
							goto IL_4D1;
						}
					}
				}
				continue;
				IL_4D3:
				num2++;
				flag16 = (num2 > 3);
			}
			while (!flag16);
			Block_4:
			Block_8:
			IL_4D1:
			num4 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag17 = 0 <= num4;
			if (flag17)
			{
				Form1.gstruct49_0[num4].bool_7 = false;
				Class45.smethod_21(Form1.gstruct49_0[num4]);
			}
		}

		// Token: 0x040002DF RID: 735
		public static int int_0;
	}
}
