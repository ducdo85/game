using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000011 RID: 17
	internal class Class19
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000F004 File Offset: 0x0000D204
		public static void smethod_0(int int_0)
		{
			GStruct49 gstruct = default(GStruct49);
			long long_ = 0L;
			long long_2 = 0L;
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			long long_3 = 0L;
			new Random();
			uint[] array = null;
			uint num4 = 0U;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			long num12 = 0L;
			long num13 = 0L;
			long long_4 = 0L;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			int num18 = -1;
			int[] array2 = new int[4];
			int num19 = 0;
			byte[] byte_ = new byte[4];
			byte[] array3 = new byte[4];
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			int[] array4 = new int[10];
			for (int i = 0; i < array4.Length; i++)
			{
				array4[i] = 4;
			}
			for (;;)
			{
				Thread.Sleep(200);
				int num20 = Class81.smethod_3(Form1.gstruct49_0, int_0);
				bool flag8 = Class12.bool_0 || num20 < 0 || Form1.int_20 != 2 || Form1.int_24 != 2;
				if (flag8)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num20];
				bool flag9 = !gstruct.bool_25 || gstruct.bool_54 || gstruct.int_25 > 0 || gstruct.int_133[0] > 0 || gstruct.int_20[0] > 0;
				if (flag9)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array4[0]);
				uint num21 = BitConverter.ToUInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_13.uint_0, array3, 4, ref array4[1]);
				uint num22 = BitConverter.ToUInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array4[2]);
				uint num23 = BitConverter.ToUInt32(array3, 0);
				uint num24 = num22 * Class53.gstruct51_15.uint_0;
				uint num25 = num23 + num24;
				Class22.ReadProcessMemory(gstruct.int_137, num25, array3, 4, ref array4[3]);
				uint num26 = BitConverter.ToUInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_55.uint_0, array3, 4, ref array4[4]);
				int num27 = BitConverter.ToInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_50.uint_0, array3, 4, ref array4[5]);
				int num28 = BitConverter.ToInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array4[6]);
				int num29 = BitConverter.ToInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_43.uint_0, array3, 4, ref array4[7]);
				int num30 = BitConverter.ToInt32(array3, 0);
				int num31 = Class83.smethod_12(gstruct);
				bool flag10 = (gstruct.int_136 != Class76.gstruct49_0.int_136 && gstruct.int_136 != Class44.gstruct33_0.int_0) || (num31 != 1 && num31 != 2);
				if (flag10)
				{
					bool flag11 = num17 <= 0;
					if (flag11)
					{
						array2[0] = 0;
						array2[1] = 0;
						array2[2] = 0;
						array2[3] = 0;
					}
					num17 = 0;
					int num32 = Class83.smethod_39(gstruct);
					bool flag12 = num28 != 0 && num27 != 0 && num29 != 0 && num27 != 10 && num27 != 21 && num32 > 1;
					if (flag12)
					{
						bool flag13 = flag5;
						if (flag13)
						{
							flag5 = false;
							Thread.Sleep(300);
						}
						else
						{
							int num33 = 7;
							int num34 = 0;
							for (;;)
							{
								bool flag14 = num34 <= num33;
								if (!flag14)
								{
									goto IL_3C6;
								}
								bool flag15 = array4[num34] == 0;
								if (flag15)
								{
									break;
								}
								num34++;
							}
							continue;
							IL_3C6:
							Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num19);
							bool flag16 = array3[0] > 0;
							if (flag16)
							{
								flag3 = false;
								array3[0] = 0;
								Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num19);
							}
							uint[] array5 = new uint[]
							{
								Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							bool flag17 = array5[0] == 0U || array5[1] == 0U;
							if (!flag17)
							{
								uint[] array6 = new uint[2];
								bool flag18 = num2 == num29;
								if (flag18)
								{
									bool flag19 = num3 == num30;
									if (flag19)
									{
										int num35 = 600;
										bool flag20 = gstruct.int_98 > 0;
										if (flag20)
										{
											num35 = gstruct.int_99;
										}
										bool flag21 = gstruct.int_136 != Class44.gstruct33_0.int_0;
										if (flag21)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num19);
											gstruct.int_97 = BitConverter.ToInt32(array3, 0);
										}
										int num36 = gstruct.int_97;
										bool flag22 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
										if (flag22)
										{
											num36 = gstruct.int_96;
										}
										bool flag23 = num36 <= 0;
										if (flag23)
										{
											num36 = 500;
										}
										int num37 = Form1.int_23;
										bool flag24 = gstruct.int_136 != Class44.gstruct33_0.int_0;
										if (flag24)
										{
											bool flag25 = num36 <= 180 && num37 < Form1.int_51;
											if (flag25)
											{
												num37 = Form1.int_51;
											}
											bool flag26 = gstruct.int_131[0] > 0 && Form1.int_27 > 0 && num37 > 180;
											if (flag26)
											{
												num37 = 180;
											}
											bool flag27 = flag7;
											if (flag27)
											{
												bool flag28 = num30 > 0;
												if (flag28)
												{
													num37 = gstruct.gstruct48_0.int_9;
												}
												flag7 = false;
											}
										}
										uint[] uint_ = array5;
										bool bool_ = false;
										int num38 = 0;
										int num39 = 0;
										bool flag29 = false;
										bool flag30 = num29 != Form1.int_26;
										if (flag30)
										{
											bool flag31 = Form1.int_113 <= 0 || Class44.gstruct33_0.int_0 != gstruct.int_136;
											if (flag31)
											{
												int[] array7 = Class60.smethod_9(num29);
												bool flag32 = array7 == null;
												if (flag32)
												{
													flag3 = false;
													bool flag33 = Class56.smethod_1(num29) != null;
													if (flag33)
													{
														Class50.smethod_5(gstruct, 11);
														flag6 = true;
														continue;
													}
													bool flag34 = Class56.smethod_0(num29) != null || 0 <= Class56.smethod_2(num29);
													if (flag34)
													{
														continue;
													}
													bool flag35 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0 && num5 < 6;
													if (flag35)
													{
														Class35.smethod_140(gstruct, 11, "®«ng|§«ng", null, false);
														num5++;
														continue;
													}
													bool flag36 = num30 > 0 && num6 < 6;
													if (flag36)
													{
														Class60.smethod_14(gstruct, true);
														num6++;
														bool flag37 = num6 > 3;
														if (flag37)
														{
															num5 = 0;
														}
														continue;
													}
												}
												bool flag38 = array7 != null && array7[1] == 0;
												if (flag38)
												{
													int num40 = Class79.smethod_4(gstruct);
													bool flag39 = flag3 && num >= 0 && num == num40;
													if (flag39)
													{
														bool flag40 = flag6 && num30 == 0;
														if (flag40)
														{
															flag6 = (Class91.smethod_0(gstruct, true, null) < 0);
														}
														else
														{
															Class50.smethod_2(gstruct, "Tam M«n §µi", null, null, 0);
														}
													}
													else
													{
														bool flag41 = !Form1.bool_4;
														if (flag41)
														{
															bool flag42 = Class40.smethod_0(gstruct) == 0;
															if (flag42)
															{
																Thread.Sleep(300);
																continue;
															}
															int num41 = Class34.smethod_3(gstruct, Form1.int_98 <= 0);
															bool flag43 = num41 == 0 || (num41 < 0 && !flag4);
															if (flag43)
															{
																Thread.Sleep(300);
																flag4 = (num41 < 0);
																continue;
															}
														}
														flag3 = true;
														flag4 = false;
														num = Class79.smethod_4(gstruct);
														bool flag44 = gstruct.int_65 > 0;
														if (flag44)
														{
															Class60.smethod_3(gstruct, ref flag);
														}
													}
												}
												else
												{
													Class50.smethod_5(gstruct, 11);
													flag6 = true;
												}
											}
											else
											{
												bool flag45 = Class12.smethod_28(long_4) > 30000L;
												if (flag45)
												{
													Class70.smethod_52(gstruct, "<color=yellow>Dang o che do ac chinh nguoi dung Tu dieu khien...", 1);
													long_4 = Class12.smethod_27();
												}
											}
										}
										else
										{
											flag3 = false;
											bool flag46 = Class22.smethod_30(num25 + Class53.gstruct51_43.uint_0, gstruct.int_137) == 0U;
											if (!flag46)
											{
												bool flag47 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && (Class44.gstruct33_1.int_3 > 0 || Form1.int_22 > 0) && Class44.gstruct33_1.int_4 > 0 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0);
												bool flag48 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_6 > 0 && Class44.gstruct33_0.int_4 == num29 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class44.gstruct33_0.int_3 > 0;
												bool flag49 = !gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0);
												array5 = new uint[]
												{
													Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
													Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
												};
												bool flag50 = flag48 && gstruct.int_136 != Class44.gstruct33_0.int_0;
												if (flag50)
												{
													array5 = new uint[]
													{
														Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													long num42 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
													bool flag51 = gstruct.int_130[0] > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0 && num30 == Class44.gstruct33_0.int_3 && num30 > 0;
													if (flag51)
													{
														int num43 = gstruct.int_130[1] + Form1.int_23;
														bool flag52 = num42 <= (long)(num43 * num43) && Class64.smethod_0(gstruct, Class44.gstruct33_0.uint_4, gstruct.int_130[1]) > 0;
														if (flag52)
														{
															goto IL_1628;
														}
													}
													bool flag53 = flag2 || num42 > (long)(num37 * num37);
													if (!flag53)
													{
														Class14.smethod_2(gstruct, false);
														int num44 = num8;
														num8 = 0;
														num7 = 0;
														bool flag54 = num30 > 0 && !gstruct.bool_22 && gstruct.int_93 == 1 && Form1.int_102 > 0 && (Form1.int_31 > 0 || Form1.int_30 > 0 || Form1.int_32 > 0) && Class22.smethod_30(num25 + Class53.gstruct51_43.uint_0, gstruct.int_137) > 0U;
														if (flag54)
														{
															Class60.smethod_30(gstruct);
														}
														bool flag55 = num13 <= 0L || Class12.smethod_28(num13) >= 1500L;
														if (flag55)
														{
															uint[] uint_2 = new uint[]
															{
																array5[0],
																array5[1]
															};
															bool flag56 = Class44.smethod_5(num26, ref array5, ref num4) > 0;
															if (flag56)
															{
																long num45 = Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4);
																long num46 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																bool flag57 = num46 <= (long)(num37 * num37);
																if (flag57)
																{
																	num13 = Class12.smethod_27();
																	bool flag58 = num16 > 0;
																	if (flag58)
																	{
																		Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																	}
																	num16 = 0;
																	Class44.smethod_6(gstruct, array5, Class44.gstruct33_0.uint_4, num45 <= 5625L);
																	goto IL_15A1;
																}
																bool flag59 = num44 > 0;
																if (flag59)
																{
																	uint[] uint_3 = Class60.smethod_5(array5, Class44.gstruct33_0.uint_4, -100);
																	Class70.smethod_61(gstruct, uint_3);
																	Thread.Sleep(120);
																}
																goto IL_3069;
															}
															else
															{
																num13 = 0L;
																bool flag60 = num16 == 0 && Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4) > (long)(Form1.int_23 * Form1.int_23);
																if (flag60)
																{
																	num9++;
																	bool flag61 = num9 > 3;
																	if (flag61)
																	{
																		Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
																		Thread.Sleep(150);
																		num9 = 0;
																	}
																}
																bool flag62 = Form1.int_27 > 0 && num30 > 0 && gstruct.int_131[0] > 0 && Class70.smethod_3(gstruct, Class70.uint_31, 4) == 0;
																if (flag62)
																{
																	Class70.smethod_2(gstruct, Class70.uint_31, 1, 4);
																}
															}
														}
														num7 = 0;
														array = null;
														uint_ = Class44.gstruct33_0.uint_4;
														bool_ = true;
														goto IL_1042;
													}
													IL_3069:
													flag2 = (num42 > 40000L);
													Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
													num16 = 0;
													bool flag63 = array == null;
													if (flag63)
													{
														array = new uint[]
														{
															array5[0],
															array5[1]
														};
														num7 = 0;
													}
													bool flag64 = num7 > 6;
													if (flag64)
													{
														long num47 = Class60.smethod_18(array, array5);
														array = null;
														bool flag65 = num47 < 180000L;
														if (flag65)
														{
															Class14.smethod_2(gstruct, false);
															Class60.smethod_2(gstruct, array5, Class44.gstruct33_0.uint_4, 600);
															goto IL_15A1;
														}
														num7 = 0;
													}
													bool flag66 = num42 > (long)(Form1.int_101 * Form1.int_101);
													if (flag66)
													{
														Class60.smethod_29(gstruct, false);
													}
													bool flag67 = num42 >= 900000L || num8 >= 6;
													if (flag67)
													{
														bool flag68 = Class44.gstruct33_0.uint_4 != null && (!Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 4000L);
														if (flag68)
														{
															Class14.smethod_1(gstruct, Class44.gstruct33_0.uint_4);
															Thread.Sleep(300);
															long_ = Class12.smethod_27();
															num7++;
															num8 = 0;
														}
														continue;
													}
													num8++;
													Class14.smethod_2(gstruct, false);
													Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
													Thread.Sleep(150);
													goto IL_15A1;
												}
												else
												{
													bool flag69 = gstruct.int_68 != null && gstruct.int_68[0] > 0 && !FormMayphu.bool_3;
													if (flag69)
													{
														bool flag70 = num12 <= 0L || Class12.smethod_28(num12) >= 1000L;
														if (flag70)
														{
															uint[] array8 = Class60.smethod_26(gstruct, ref num11);
															bool flag71 = array8 == null;
															if (flag71)
															{
																num12 = Class12.smethod_27();
															}
															else
															{
																num12 = 0L;
																long num48 = Class60.smethod_18(array5, array8);
																bool flag72 = num48 < 8000L;
																if (flag72)
																{
																	goto IL_12E6;
																}
																bool flag73 = num48 >= 15000L && num48 >= (long)(gstruct.int_68[1] * gstruct.int_68[1]);
																if (flag73)
																{
																	bool flag74 = num48 < 360000L;
																	if (flag74)
																	{
																		Class14.smethod_2(gstruct, false);
																		bool flag75 = num16 > 0;
																		if (flag75)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																		num16 = 0;
																		Class70.smethod_61(gstruct, array8);
																		Thread.Sleep(150);
																		continue;
																	}
																	bool flag76 = num48 < 1200000L;
																	if (flag76)
																	{
																		bool flag77 = Class12.smethod_28(long_) > 3000L;
																		if (flag77)
																		{
																			Class14.smethod_1(gstruct, array8);
																			long_ = Class12.smethod_27();
																		}
																		continue;
																	}
																}
																else
																{
																	bool flag78 = num27 <= 3 && num48 > 7500L;
																	if (flag78)
																	{
																		bool flag79 = num16 > 0;
																		if (flag79)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																		num16 = 0;
																		Class70.smethod_61(gstruct, array8);
																		Thread.Sleep(150);
																		goto IL_15A1;
																	}
																}
															}
														}
													}
													bool flag80 = flag47;
													if (flag80)
													{
														int num49 = FormMayphu.smethod_10(gstruct, ref long_, ref num7, ref array);
														bool flag81 = num49 <= 0;
														if (flag81)
														{
															Thread.Sleep(100);
															continue;
														}
														num27 = (int)Class22.smethod_30(num25 + Class53.gstruct51_55.uint_0, gstruct.int_137);
														bool flag82 = num27 < 3;
														if (flag82)
														{
															array5 = new uint[]
															{
																Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															bool flag83 = Class60.smethod_18(array5, Class44.gstruct33_1.uint_4) > 5625L;
															if (flag83)
															{
																bool flag84 = num16 > 0;
																if (flag84)
																{
																	Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																}
																num16 = 0;
																Class70.smethod_61(gstruct, Class44.gstruct33_1.uint_4);
																Thread.Sleep(150);
															}
														}
													}
												}
												IL_12E6:
												bool flag85 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
												if (flag85)
												{
													long num50 = Class12.smethod_28(long_2);
													bool flag86 = num50 < 300L;
													if (flag86)
													{
														continue;
													}
													bool flag87 = num50 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
													if (flag87)
													{
														Thread.Sleep(80);
														long_2 = Class12.smethod_27();
														continue;
													}
												}
												for (int j = 0; j < Class53.int_0; j++)
												{
													Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num19);
													bool flag88 = array3[0] == 0;
													if (flag88)
													{
														break;
													}
													Thread.Sleep(1);
												}
												bool bool_2 = gstruct.bool_22;
												if (bool_2)
												{
													bool flag89 = gstruct.int_136 != Class44.gstruct33_0.int_0;
													if (flag89)
													{
														Class60.smethod_29(gstruct, false);
													}
												}
												else
												{
													bool flag90 = gstruct.int_128[0] > 0 && gstruct.int_128[1] > 0 && gstruct.int_128[2] > 0;
													bool flag91 = gstruct.int_128[0] > 0 && gstruct.int_128[3] > 0 && gstruct.int_128[4] > 0;
													bool flag92 = gstruct.int_128[0] > 0 && gstruct.int_128[5] > 0 && gstruct.int_128[6] > 0;
													flag29 = ((flag90 || flag91 || flag92) && gstruct.string_23 == "DUONGMON");
													bool flag93 = FormDame.int_6 <= 0 || gstruct.int_126 != 0 || flag29;
													if (!flag93)
													{
														bool flag94 = flag49 || FormDame.int_10 > 0;
														if (flag94)
														{
															int num51 = 0;
															bool flag95 = FormDame.int_9 == 0;
															if (!flag95)
															{
																bool flag96 = Class44.gstruct33_0.int_8 == 1 || (flag47 && Class44.gstruct33_1.int_8 == 1);
																bool flag97 = FormDame.int_9 != 1;
																if (flag97)
																{
																	bool flag98 = FormDame.int_9 != 2 || flag96;
																	if (!flag98)
																	{
																		bool flag99 = num16 > 0;
																		if (flag99)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																		num16 = 0;
																		goto IL_159D;
																	}
																}
																else
																{
																	bool flag100 = flag96;
																	if (flag100)
																	{
																		goto IL_16F8;
																	}
																	bool flag101 = FormDame.int_11 > 0;
																	if (!flag101)
																	{
																		bool flag102 = num16 > 0;
																		if (flag102)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																		num16 = 0;
																		goto IL_159D;
																	}
																}
																goto IL_1AB9;
																IL_159D:
																goto IL_159E;
															}
															IL_16F8:
															uint num52 = 0U;
															uint[] array9 = null;
															uint[] uint_4 = null;
															bool flag103 = !flag47;
															if (flag103)
															{
																bool flag104 = gstruct.int_136 != Class44.gstruct33_0.int_0 && gstruct.int_136 != Class76.gstruct49_0.int_136 && Class44.gstruct33_0.uint_5 > 0U;
																if (flag104)
																{
																	uint num53 = Class44.gstruct33_0.uint_5 >> 16;
																	uint int_ = Class44.gstruct33_0.uint_5 - (num53 << 16);
																	array9 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)int_, (int)num53);
																	uint[] array10 = Class83.smethod_10(array5, array9);
																	num52 = (array10[1] << 16) + array10[0];
																	uint_4 = Class44.gstruct33_0.uint_4;
																	Class83.smethod_7(gstruct, num52);
																	Thread.Sleep(10);
																}
															}
															else
															{
																uint num54 = Class44.gstruct33_1.uint_5 >> 16;
																uint int_2 = Class44.gstruct33_1.uint_5 - (num54 << 16);
																array9 = Class83.smethod_11(Class44.gstruct33_1.uint_4, (int)int_2, (int)num54);
																uint[] array11 = Class83.smethod_10(array5, array9);
																num52 = (array11[1] << 16) + array11[0];
																uint_4 = Class44.gstruct33_1.uint_4;
																Class83.smethod_7(gstruct, num52);
																Thread.Sleep(10);
															}
															Class60.smethod_30(gstruct);
															bool flag105 = gstruct.int_127[0] != 2;
															if (flag105)
															{
																bool flag106 = gstruct.int_127[0] > 0;
																if (flag106)
																{
																	bool flag107 = gstruct.int_127[1] > 0 && gstruct.int_127[2] > 0;
																	bool flag108 = gstruct.int_127[3] > 0 && gstruct.int_127[4] > 0;
																	bool flag109 = !flag107 || flag108;
																	if (flag109)
																	{
																		bool flag110 = flag108 && !flag107;
																		if (flag110)
																		{
																			num51 = gstruct.int_127[4];
																		}
																		else
																		{
																			bool flag111 = flag107 && flag108;
																			if (flag111)
																			{
																				num51 = ((0 > num10 || num10 > 25) ? gstruct.int_127[4] : gstruct.int_127[2]);
																				bool flag112 = num10 > 35;
																				if (flag112)
																				{
																					num10 = 0;
																				}
																				num10++;
																			}
																		}
																	}
																	else
																	{
																		num51 = gstruct.int_127[2];
																	}
																}
																bool flag113 = num51 <= 0;
																if (flag113)
																{
																	num51 = Class77.smethod_13(gstruct);
																}
																bool flag114 = gstruct.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
																if (flag114)
																{
																	Class77.smethod_9(gstruct, null);
																}
																Class77.smethod_5(gstruct, num51, 6, 1);
																for (int k = 0; k < 3; k++)
																{
																	Class22.smethod_76(gstruct.uint_4, 117);
																	bool flag115 = k < 2;
																	if (flag115)
																	{
																		Thread.Sleep(60);
																	}
																}
															}
															else
															{
																Class60.smethod_0(gstruct.uint_4, gstruct.int_129, FormDame.int_12);
															}
															bool flag116 = num52 != 0U && gstruct.int_136 != Class76.gstruct49_0.int_136;
															if (flag116)
															{
																bool flag117 = gstruct.int_95 <= 0;
																if (flag117)
																{
																	Class22.smethod_30(num25 + Class53.gstruct51_31.uint_0, gstruct.int_137);
																	int num55 = Class77.smethod_13(gstruct);
																	bool flag118 = num55 == 53 || num55 <= 1;
																	if (flag118)
																	{
																		goto IL_15A1;
																	}
																	bool flag119 = num55 <= 100;
																	if (flag119)
																	{
																	}
																}
																string string_ = Class83.smethod_20(gstruct);
																bool flag120 = Class12.smethod_2(string_, "iÓm qu¸ x", false);
																if (flag120)
																{
																	uint[] array12 = Class60.smethod_5(uint_4, array9, -1 * (Form1.int_23 - 50));
																	long num56 = Class60.smethod_18(array5, array12);
																	bool flag121 = num56 > 7000L;
																	if (flag121)
																	{
																		Class70.smethod_61(gstruct, array12);
																		Thread.Sleep(150);
																		Class83.smethod_21(gstruct, "0K..");
																	}
																}
															}
														}
														IL_159E:
														goto IL_159F;
													}
													IL_1AB9:
													bool flag122 = flag49;
													if (flag122)
													{
														bool flag123 = Class44.smethod_7(gstruct, ref num18) || Class83.smethod_12(gstruct) == 1;
														if (flag123)
														{
															Thread.Sleep(100);
															num16 = 0;
														}
														else
														{
															num29 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
															array5 = new uint[]
															{
																Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															uint[] uint_5 = array5;
															bool flag124 = flag48 && Class44.gstruct33_0.int_4 == num29 && Class44.gstruct33_0.int_3 > 0 && Class44.gstruct33_0.uint_4 != null;
															if (flag124)
															{
																uint_5 = Class44.gstruct33_0.uint_4;
																num35 += num37;
															}
															uint num57 = 0U;
															bool flag125 = Form1.int_33 > 0 && (flag47 || flag48);
															if (flag125)
															{
																bool flag126 = flag47;
																if (flag126)
																{
																	bool flag127 = Class44.gstruct33_1.int_4 == num29 && Class44.gstruct33_1.uint_3 != num26;
																	if (flag127)
																	{
																		num57 = Class44.gstruct33_1.uint_3;
																	}
																}
																else
																{
																	bool flag128 = flag48 && Class44.gstruct33_0.int_4 == num29 && Class44.gstruct33_0.uint_3 != num26;
																	if (flag128)
																	{
																		num57 = Class44.gstruct33_0.uint_3;
																	}
																}
																bool flag129 = num57 == 0U && Form1.int_34 <= 0;
																if (flag129)
																{
																	goto IL_15A1;
																}
															}
															bool flag130 = gstruct.int_119 <= 0 || gstruct.int_3 == null;
															if (flag130)
															{
																bool flag131;
																flag49 = (flag131 = (!gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0)));
																if (flag131)
																{
																	int[,] array13 = Class7.smethod_5(gstruct, num57, num35, uint_5, null, false, Form1.int_94 > 0, true);
																	bool flag132 = array13 == null;
																	if (flag132)
																	{
																		flag49 = false;
																	}
																	else
																	{
																		bool flag133 = array13[0, 0] == -100;
																		if (flag133)
																		{
																			continue;
																		}
																		int num58 = 0;
																		int num60;
																		for (;;)
																		{
																			bool flag134 = array13[num58, 1] > 0;
																			if (!flag134)
																			{
																				goto IL_1E7B;
																			}
																			array6 = new uint[]
																			{
																				(uint)array13[num58, 4],
																				(uint)array13[num58, 5]
																			};
																			bool flag135 = flag48;
																			if (flag135)
																			{
																				int num59 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																				num60 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																				bool flag136 = num59 - num36 > 0;
																				if (!flag136)
																				{
																					goto IL_1E2B;
																				}
																				bool flag137 = num60 > num59;
																				if (flag137)
																				{
																					int num61 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																					bool flag138 = num61 + (num59 - num36) <= num37 + 10;
																					if (flag138)
																					{
																						goto Block_242;
																					}
																				}
																				bool flag139 = gstruct.int_88 == 1 && num58 == 0;
																				if (!flag139)
																				{
																					goto IL_1DE6;
																				}
																				num58 = 1;
																			}
																			else
																			{
																				bool flag140 = Class60.smethod_18(array5, array6) > (long)(num36 * num36) && gstruct.int_95 <= 0;
																				if (!flag140)
																				{
																					goto IL_1E79;
																				}
																				bool flag141 = gstruct.int_88 != 1 || num58 != 0;
																				if (flag141)
																				{
																					break;
																				}
																				num58 = 1;
																			}
																		}
																		IL_22EA:
																		goto IL_22EB;
																		IL_1EAC:
																		num38 = array13[num58, 0];
																		num39 = array13[num58, 1];
																		array13[num58, 2];
																		bool flag142 = Form1.int_50 > 0 && (num38 <= 0 || num38 == array2[0]) && array2[1] > 0 && array2[2] == num29 && array2[3] > 0;
																		if (flag142)
																		{
																			int num62 = array2[0];
																			int num63 = array2[1];
																			uint num64 = num23 + (uint)(num63 * (int)Class53.gstruct51_15.uint_0);
																			Class22.ReadProcessMemory(gstruct.int_137, num64 + Class53.gstruct51_50.uint_0, array3, 4, ref num19);
																			bool flag143 = BitConverter.ToInt32(array3, 0) > 0;
																			if (flag143)
																			{
																				Class22.ReadProcessMemory(gstruct.int_137, num64 + Class53.gstruct51_45.uint_0, array3, 4, ref num19);
																				long num65 = (long)BitConverter.ToInt32(array3, 0);
																				bool flag144 = num65 != 0L;
																				if (flag144)
																				{
																					Class22.ReadProcessMemory(gstruct.int_137, num64 + Class53.gstruct51_43.uint_0, array3, 4, ref num19);
																					bool flag145 = num62 <= 0 || BitConverter.ToInt32(array3, 0) > 0;
																					if (flag145)
																					{
																						array6 = new uint[]
																						{
																							Class22.smethod_30(num64 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																							Class22.smethod_30(num64 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																						};
																						long num66 = Class60.smethod_18(array5, array6);
																						bool flag146 = !flag48;
																						if (flag146)
																						{
																							bool flag147 = num66 <= (long)(num36 * num36);
																							if (flag147)
																							{
																								num38 = num62;
																								num39 = num63;
																							}
																						}
																						else
																						{
																							int num67 = (int)Math.Sqrt((double)num66);
																							int num68 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																							bool flag148 = num67 - num36 <= 0;
																							if (flag148)
																							{
																								num38 = num62;
																								num39 = num63;
																							}
																							else
																							{
																								bool flag149 = num68 > num67;
																								if (flag149)
																								{
																									int num69 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																									bool flag150 = num69 + (num67 - num36) <= num37 + 10;
																									if (flag150)
																									{
																										num38 = num62;
																										num39 = num63;
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		array2[0] = num38;
																		array2[1] = num39;
																		array2[2] = num29;
																		array2[3] = 0;
																		bool flag151 = num39 <= 0;
																		if (flag151)
																		{
																			goto IL_22EA;
																		}
																		array2[3] = 1;
																		num16 = 1;
																		num17 = 1;
																		Class60.smethod_30(gstruct);
																		for (int l = 0; l < Class53.int_0; l++)
																		{
																			Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num19);
																			bool flag152 = array3[0] == 0;
																			if (flag152)
																			{
																				break;
																			}
																			Thread.Sleep(1);
																		}
																		bool flag153 = gstruct.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct, (uint)num39) <= 0;
																		if (flag153)
																		{
																			int value = Class77.smethod_13(gstruct);
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(value), 4, ref num19);
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num36), 4, ref num19);
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num39), 4, ref num19);
																		}
																		flag7 = (gstruct.gstruct48_0.int_0 > 0 && gstruct.gstruct48_0.int_1 > 0 && gstruct.gstruct48_0.int_8 > 0 && gstruct.gstruct48_0.int_9 > 0);
																		goto IL_22EA;
																		IL_1E79:
																		goto IL_1EAC;
																		IL_1E2B:
																		goto IL_1E79;
																		IL_1DE6:
																		bool flag154 = num37 + num36 <= num60;
																		if (flag154)
																		{
																			bool flag155 = num16 > 0;
																			if (flag155)
																			{
																				Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																			}
																			num16 = 0;
																			goto IL_22EA;
																		}
																		Block_242:
																		goto IL_1EAC;
																		IL_1E7B:
																		bool flag156 = num16 > 0;
																		if (flag156)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																		num16 = 0;
																	}
																	IL_22EB:;
																}
																else
																{
																	flag49 = false;
																}
															}
															else
															{
																int[,] array13 = (gstruct.int_5 > 0) ? Class7.smethod_5(gstruct, num57, num35, uint_5, null, false, Form1.int_94 > 0, true) : Class7.smethod_6(gstruct, num57, num35, uint_5, null, false, Form1.int_94 > 0, true);
																bool flag157 = array13 != null && array13[0, 0] >= 0;
																if (flag157)
																{
																	int num70 = -1;
																	int int_3 = Class44.gstruct33_0.int_4;
																	num16 = 0;
																	bool flag158 = false;
																	bool flag159 = false;
																	for (;;)
																	{
																		int m = 0;
																		int num71 = 400;
																		while (m <= 0)
																		{
																			num70++;
																			bool flag160 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num70 && gstruct.int_4 != null;
																			if (!flag160)
																			{
																				goto IL_2445;
																			}
																			m = gstruct.int_3[num70, 0];
																			bool flag161 = m > 0;
																			if (flag161)
																			{
																				num71 = Class77.smethod_20(gstruct, m, gstruct.int_3[num70, 1]);
																				break;
																			}
																		}
																		num27 = (int)Class22.smethod_30(num25 + Class53.gstruct51_55.uint_0, gstruct.int_137);
																		num28 = (int)Class22.smethod_30(num25 + Class53.gstruct51_50.uint_0, gstruct.int_137);
																		num30 = (int)Class22.smethod_30(num25 + Class53.gstruct51_43.uint_0, gstruct.int_137);
																		int num72 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																		bool flag162 = num30 > 0 && num29 == num72 && num27 != 11 && num27 != 22 && num28 != 0;
																		if (!flag162)
																		{
																			goto IL_2A07;
																		}
																		for (int n = 0; n < array13.GetLength(0); n++)
																		{
																			bool flag163 = Class44.smethod_7(gstruct, ref num18) || Class83.smethod_12(gstruct) == 1;
																			if (flag163)
																			{
																				goto Block_286;
																			}
																			num38 = array13[n, 0];
																			num39 = array13[n, 1];
																			bool flag164 = num39 <= 0;
																			if (!flag164)
																			{
																				uint num73 = num23 + (uint)(num39 * (int)Class53.gstruct51_15.uint_0);
																				Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_50.uint_0, array3, 4, ref num19);
																				bool flag165 = BitConverter.ToInt32(array3, 0) <= 0;
																				if (!flag165)
																				{
																					bool flag166 = num38 > 0;
																					if (flag166)
																					{
																						Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_43.uint_0, array3, 4, ref num19);
																						bool flag167 = BitConverter.ToInt32(array3, 0) <= 0;
																						if (flag167)
																						{
																							goto IL_29D3;
																						}
																					}
																					flag158 = true;
																					bool flag168 = !flag159 || num38 > 0;
																					if (!flag168)
																					{
																						goto IL_29D1;
																					}
																					bool flag169 = num38 > 0;
																					if (flag169)
																					{
																						flag159 = true;
																					}
																					bool flag170 = Class98.smethod_31(gstruct, num39, m) != 0;
																					if (!flag170)
																					{
																						num36 = num71;
																						Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num19);
																						array6[0] = BitConverter.ToUInt32(array3, 0);
																						Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num19);
																						array6[1] = BitConverter.ToUInt32(array3, 0);
																						array5 = new uint[]
																						{
																							Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																							Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																						};
																						bool flag171 = flag48;
																						if (flag171)
																						{
																							array5 = new uint[]
																							{
																								Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																								Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																							};
																							long num74 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																							bool flag172 = int_3 != Class44.gstruct33_0.int_4 || num74 > (long)(num37 * num37);
																							if (flag172)
																							{
																								goto Block_297;
																							}
																							int num75 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																							int num76 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																							int num77 = num75 - num37 + 10;
																							bool flag173 = num75 > num37 && num36 < num77 && (num76 > num75 || (num76 < num75 && num36 < num76));
																							if (flag173)
																							{
																								num36 = num77;
																							}
																						}
																						bool flag174 = Class60.smethod_18(array5, array6) > (long)(num36 * num36) && gstruct.int_95 <= 0;
																						if (!flag174)
																						{
																							for (int num78 = 0; num78 < Class53.int_0; num78++)
																							{
																								Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num19);
																								bool flag175 = array3[0] == 0;
																								if (flag175)
																								{
																									break;
																								}
																								Thread.Sleep(1);
																							}
																							Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(m), 4, ref num19);
																							Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num36), 4, ref num19);
																							Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num39), 4, ref num19);
																							Thread.Sleep(10);
																							num16 = 1;
																						}
																					}
																				}
																			}
																			IL_29D3:;
																		}
																	}
																	IL_3060:
																	goto IL_3061;
																	IL_2A51:
																	bool flag176 = num16 <= 0 && gstruct.int_6 <= 0 && flag158;
																	if (flag176)
																	{
																		long num79 = 0L;
																		array5 = new uint[]
																		{
																			Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																			Class22.smethod_30(num25 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																		};
																		num38 = -1;
																		num39 = -1;
																		flag159 = false;
																		num36 = gstruct.int_97;
																		bool flag177 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
																		if (flag177)
																		{
																			num36 = gstruct.int_96;
																		}
																		bool flag178 = num36 <= 0;
																		if (flag178)
																		{
																			num36 = 500;
																		}
																		Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_44 * 4U, array3, 1, ref num19);
																		int num80 = (int)array3[0];
																		bool flag179 = num80 > 0 && num36 > gstruct.int_97 && gstruct.int_97 > 0;
																		if (flag179)
																		{
																			num36 = gstruct.int_97;
																		}
																		for (int num81 = 0; num81 < array13.GetLength(0); num81++)
																		{
																			int num82 = array13[num81, 0];
																			int num83 = array13[num81, 1];
																			int num84 = num36;
																			bool flag180 = num83 <= 0;
																			if (!flag180)
																			{
																				uint num73 = num23 + (uint)(num83 * (int)Class53.gstruct51_15.uint_0);
																				Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_50.uint_0, array3, 4, ref num19);
																				bool flag181 = BitConverter.ToInt32(array3, 0) <= 0;
																				if (!flag181)
																				{
																					bool flag182 = num82 > 0;
																					if (flag182)
																					{
																						Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_43.uint_0, array3, 4, ref num19);
																						bool flag183 = BitConverter.ToInt32(array3, 0) <= 0;
																						if (flag183)
																						{
																							goto IL_2EB6;
																						}
																					}
																					bool flag184 = flag159 && num82 <= 0 && num39 > 0;
																					if (flag184)
																					{
																						break;
																					}
																					Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num19);
																					array6[0] = BitConverter.ToUInt32(array3, 0);
																					Class22.ReadProcessMemory(gstruct.int_137, num73 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num19);
																					array6[1] = BitConverter.ToUInt32(array3, 0);
																					long num85 = Class60.smethod_18(array5, array6);
																					bool flag185 = num39 > 0 && num79 < num85;
																					if (!flag185)
																					{
																						bool flag186 = flag48;
																						if (flag186)
																						{
																							int num86 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																							int num87 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																							int num88 = num86 - num37 + 10;
																							bool flag187 = num86 > num37 && num84 < num88 && (num87 > num86 || (num87 < num86 && num84 < num87));
																							if (flag187)
																							{
																								num84 = num88;
																							}
																						}
																						bool flag188 = num85 <= (long)(num84 * num84) || gstruct.int_95 > 0;
																						if (flag188)
																						{
																							bool flag189 = num82 > 0;
																							if (flag189)
																							{
																								flag159 = true;
																							}
																							num39 = num83;
																							num38 = num82;
																							num79 = num85;
																							num36 = num84;
																						}
																					}
																				}
																			}
																			IL_2EB6:;
																		}
																		bool flag190 = num39 <= 0;
																		if (!flag190)
																		{
																			Class60.smethod_30(gstruct);
																			for (int num89 = 0; num89 < Class53.int_0; num89++)
																			{
																				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num19);
																				bool flag191 = array3[0] == 0;
																				if (flag191)
																				{
																					break;
																				}
																				Thread.Sleep(1);
																			}
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num19);
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num36), 4, ref num19);
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num39), 4, ref num19);
																		}
																	}
																	else
																	{
																		bool flag192 = flag158 && num16 <= 0 && gstruct.int_6 > 0;
																		if (flag192)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																		}
																	}
																	goto IL_3060;
																	IL_29D1:
																	IL_2445:
																	goto IL_2A51;
																	IL_2A07:
																	bool flag193 = num16 > 0;
																	if (flag193)
																	{
																		Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																	}
																	num16 = 0;
																	goto IL_3060;
																	Block_297:
																	Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
																	goto IL_3060;
																	Block_286:
																	Thread.Sleep(100);
																	num16 = 0;
																}
																IL_3061:;
															}
														}
													}
												}
												IL_159F:
												goto IL_15A1;
												IL_1042:
												goto IL_12E6;
												IL_1628:
												bool flag194 = !gstruct.bool_58 || gstruct.int_83 <= 0;
												if (flag194)
												{
													continue;
												}
												bool flag195 = Form1.int_99 == 0;
												if (flag195)
												{
													bool flag196 = num39 > 0 && num38 > 0 && Class12.smethod_28(long_3) > gstruct.long_8;
													if (flag196)
													{
														Class36.smethod_54(gstruct, array6, false, 10);
														Class36.smethod_55(gstruct);
														long_3 = Class12.smethod_27();
													}
												}
												else
												{
													bool flag197 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
													if (flag197)
													{
														Class36.smethod_54(gstruct, null, true, 10);
														bool flag198 = Class12.smethod_28(long_3) > gstruct.long_8;
														if (flag198)
														{
															Class36.smethod_55(gstruct);
															long_3 = Class12.smethod_27();
														}
													}
												}
												continue;
												IL_15A1:
												bool flag199 = !flag49 && gstruct.int_136 != Class44.gstruct33_0.int_0 && Class36.smethod_58(gstruct, new int[]
												{
													0,
													1
												}) > 0U;
												if (flag199)
												{
													bool flag200 = num16 > 0;
													if (flag200)
													{
														Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
													}
													num16 = 0;
												}
												bool flag201 = flag29 && num39 <= 0;
												if (flag201)
												{
													FormDuongMon.smethod_0(gstruct, ref num14, uint_, ref num15, bool_);
												}
												goto IL_1628;
											}
										}
									}
									else
									{
										array = null;
										num7 = 0;
										int num90 = 0;
										while (num30 == 0 && num90 < 30 && num30 != num3)
										{
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num19);
											num21 = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_13.uint_0, array3, 4, ref num19);
											num22 = BitConverter.ToUInt32(array3, 0);
											num24 = num22 * Class53.gstruct51_15.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num19);
											num23 = BitConverter.ToUInt32(array3, 0);
											num25 = num23 + num24;
											Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_43.uint_0, array3, 4, ref num19);
											num30 = BitConverter.ToInt32(array3, 0);
											Thread.Sleep(10);
											num90++;
										}
										num3 = num30;
										Thread.Sleep(100);
										Class86.smethod_8(gstruct, -1);
									}
								}
								else
								{
									flag3 = false;
									flag = false;
									array = null;
									num7 = 0;
									int num91 = 0;
									while (num2 != num29)
									{
										int num92 = Class83.smethod_39(gstruct);
										Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num19);
										num21 = BitConverter.ToUInt32(array3, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_13.uint_0, array3, 4, ref num19);
										num22 = BitConverter.ToUInt32(array3, 0);
										num24 = num22 * Class53.gstruct51_15.uint_0;
										Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num19);
										num23 = BitConverter.ToUInt32(array3, 0);
										num25 = num23 + num24;
										Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_50.uint_0, array3, 4, ref num19);
										num28 = BitConverter.ToInt32(array3, 0);
										Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num19);
										num29 = BitConverter.ToInt32(array3, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_43.uint_0, array3, 4, ref num19);
										num30 = BitConverter.ToInt32(array3, 0);
										Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
										num16 = 0;
										bool flag202 = num30 > 0 || num91 > 8 || (num92 != 0 && num92 != 1 && num28 > 0 && num29 > 0);
										if (flag202)
										{
											break;
										}
										num91++;
										Thread.Sleep(100);
									}
									num2 = num29;
								}
							}
						}
					}
					else
					{
						bool flag203 = num32 <= 1;
						if (flag203)
						{
							flag = false;
						}
						flag5 = (num27 == 10 || num27 == 21);
						Thread.Sleep(60);
					}
				}
				else
				{
					bool flag204 = num16 > 0;
					if (flag204)
					{
						Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_72.uint_0, byte_, 4, ref num19);
					}
					bool flag205 = Form1.int_121 > 0;
					if (flag205)
					{
						Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num19);
					}
					num16 = 0;
					num17 = 0;
				}
			}
		}
	}
}
