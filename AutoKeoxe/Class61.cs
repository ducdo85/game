using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200003B RID: 59
	internal class Class61
	{
		// Token: 0x0600036C RID: 876 RVA: 0x000A1BDC File Offset: 0x0009FDDC
		public static void smethod_0(int int_1)
		{
			try
			{
				GStruct49 gstruct = default(GStruct49);
				long long_ = 0L;
				long long_2 = 0L;
				int num = -1;
				int num2 = 0;
				int num3 = -1;
				int num4 = -1;
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				long long_3 = 0L;
				new Random();
				uint num5 = 0U;
				uint[] array = null;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				long num11 = 0L;
				long num12 = 0L;
				long long_4 = 0L;
				int num13 = 0;
				int num14 = 0;
				int num15 = 0;
				int num16 = 0;
				int num17 = -1;
				int[] array2 = new int[4];
				int num18 = 0;
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
					int num19 = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag8 = Class12.bool_0 || num19 < 0 || Form1.int_20 != 1;
					if (flag8)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num19];
					bool flag9 = !gstruct.bool_25 || gstruct.bool_54 || gstruct.int_25 > 0 || gstruct.int_133[0] > 0 || gstruct.int_20[0] > 0;
					if (flag9)
					{
						break;
					}
					bool flag10 = gstruct.bool_15 || Class70.smethod_3(gstruct, Class70.uint_48, 4) > 0;
					if (flag10)
					{
						flag4 = false;
					}
					else
					{
						bool flag11 = Form1.int_92 > 0 && !gstruct.bool_44 && Class61.int_0 <= 0;
						if (flag11)
						{
							Class61.int_0 = int_1;
							new Thread(new ThreadStart(Class61.smethod_1)).Start();
							Thread.Sleep(300);
						}
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array4[0]);
						uint num20 = BitConverter.ToUInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_13.uint_0, array3, 4, ref array4[1]);
						uint num21 = BitConverter.ToUInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array4[2]);
						uint num22 = BitConverter.ToUInt32(array3, 0);
						uint num23 = num21 * Class53.gstruct51_15.uint_0;
						uint num24 = num22 + num23;
						Class22.ReadProcessMemory(gstruct.int_137, num24, array3, 4, ref array4[3]);
						uint num25 = BitConverter.ToUInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_55.uint_0, array3, 4, ref array4[4]);
						int num26 = BitConverter.ToInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_50.uint_0, array3, 4, ref array4[5]);
						int num27 = BitConverter.ToInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array4[6]);
						int num28 = BitConverter.ToInt32(array3, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_43.uint_0, array3, 4, ref array4[7]);
						int num29 = BitConverter.ToInt32(array3, 0);
						int num30 = 7;
						int num31 = Class83.smethod_12(gstruct);
						bool flag12 = (gstruct.int_136 != Class76.gstruct49_0.int_136 && gstruct.int_136 != Class44.gstruct33_0.int_0) || (num31 != 1 && num31 != 2);
						if (flag12)
						{
							bool flag13 = num16 <= 0;
							if (flag13)
							{
								array2[0] = 0;
								array2[1] = 0;
								array2[2] = 0;
								array2[3] = 0;
							}
							num16 = 0;
							int num32 = Class83.smethod_39(gstruct);
							bool flag14 = num27 == 0 || num26 == 0 || num28 == 0 || num26 == 10 || num26 == 21 || num32 <= 1;
							if (flag14)
							{
								bool flag15 = num32 <= 1;
								if (flag15)
								{
									flag = false;
								}
								flag5 = (num26 == 10 || num26 == 21);
								Thread.Sleep(60);
							}
							else
							{
								int num33 = 0;
								for (;;)
								{
									bool flag16 = num33 <= num30;
									if (!flag16)
									{
										goto IL_449;
									}
									bool flag17 = array4[num33] == 0;
									if (flag17)
									{
										break;
									}
									num33++;
								}
								continue;
								IL_449:
								uint[] array5 = new uint[]
								{
									Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								uint[] array6 = new uint[2];
								bool flag18 = array5[0] == 0U || array5[1] == 0U;
								if (!flag18)
								{
									bool flag19 = flag5;
									if (flag19)
									{
										flag5 = false;
										Thread.Sleep(300);
									}
									else
									{
										bool flag20 = num3 != num28;
										if (flag20)
										{
											flag4 = false;
											flag = false;
											array = null;
											num6 = 0;
											int num34 = 0;
											int num35 = 0;
											while (num3 != num28 && num34 < 15)
											{
												num34++;
												Thread.Sleep(100);
												Class83.smethod_39(gstruct);
												Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num18);
												num20 = BitConverter.ToUInt32(array3, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_13.uint_0, array3, 4, ref num18);
												num21 = BitConverter.ToUInt32(array3, 0);
												num23 = num21 * Class53.gstruct51_15.uint_0;
												Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num18);
												num22 = BitConverter.ToUInt32(array3, 0);
												num24 = num22 + num23;
												Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_50.uint_0, array3, 4, ref num18);
												num27 = BitConverter.ToInt32(array3, 0);
												Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num18);
												num28 = BitConverter.ToInt32(array3, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_43.uint_0, array3, 4, ref num18);
												num29 = BitConverter.ToInt32(array3, 0);
												Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
												num15 = 0;
												bool flag21 = num32 <= 1 || num27 <= 0 || num28 <= 0 || num26 <= 0;
												if (flag21)
												{
													num35 = 0;
												}
												else
												{
													bool flag22 = num29 > 0 || num35 > 3;
													if (flag22)
													{
														break;
													}
													num35++;
												}
											}
											num3 = num28;
										}
										else
										{
											bool flag23 = num4 != num29;
											if (flag23)
											{
												array = null;
												num6 = 0;
												int num36 = 0;
												while (num29 == 0 && num36 < 10 && num29 != num4)
												{
													Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num18);
													num20 = BitConverter.ToUInt32(array3, 0);
													Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_13.uint_0, array3, 4, ref num18);
													num21 = BitConverter.ToUInt32(array3, 0);
													num23 = num21 * Class53.gstruct51_15.uint_0;
													Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num18);
													num22 = BitConverter.ToUInt32(array3, 0);
													num24 = num22 + num23;
													Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_43.uint_0, array3, 4, ref num18);
													num29 = BitConverter.ToInt32(array3, 0);
													Thread.Sleep(100);
													num36++;
												}
												num4 = num29;
												Thread.Sleep(100);
												Class86.smethod_8(gstruct, -1);
											}
											else
											{
												int num37 = 600;
												bool flag24 = gstruct.int_98 > 0;
												if (flag24)
												{
													num37 = gstruct.int_99;
												}
												bool flag25 = gstruct.int_136 != Class44.gstruct33_0.int_0;
												if (flag25)
												{
													Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num18);
													gstruct.int_97 = BitConverter.ToInt32(array3, 0);
												}
												int num38 = gstruct.int_97;
												bool flag26 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
												if (flag26)
												{
													num38 = gstruct.int_96;
												}
												bool flag27 = num38 <= 0;
												if (flag27)
												{
													num38 = 500;
												}
												int num39 = Form1.int_23;
												bool flag28 = gstruct.int_136 != Class44.gstruct33_0.int_0;
												if (flag28)
												{
													bool flag29 = num38 <= 180 && num39 < Form1.int_51;
													if (flag29)
													{
														num39 = Form1.int_51;
													}
													bool flag30 = gstruct.int_131[0] > 0 && Form1.int_27 > 0 && num39 > 180;
													if (flag30)
													{
														num39 = 180;
													}
													bool flag31 = flag7;
													if (flag31)
													{
														bool flag32 = num29 > 0;
														if (flag32)
														{
															num39 = gstruct.gstruct48_0.int_9;
														}
														flag7 = false;
													}
												}
												uint[] uint_ = array5;
												bool bool_ = false;
												int num40 = 0;
												int num41 = 0;
												bool flag33 = false;
												int[] array7 = Class56.smethod_0(num28);
												int num42 = Class56.smethod_2(num28);
												bool flag34 = array7 == null && 0 > num42 && (Class60.smethod_9(num28) != null || Class56.smethod_1(num28) != null || 0 > Class56.smethod_3(array5, num28));
												if (flag34)
												{
													Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num18);
													bool flag35 = array3[0] > 0;
													if (flag35)
													{
														flag4 = false;
														array3[0] = 0;
														Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num18);
													}
													array3[0] = 0;
													Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_22 * 4U, array3, 1, ref num18);
													bool flag36 = num28 == 221 || num28 == 539;
													if (flag36)
													{
														Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
														bool flag37 = Class50.smethod_0(gstruct, null) > 0;
														if (flag37)
														{
															continue;
														}
													}
													bool flag38 = Class12.smethod_28(long_4) > 30000L;
													if (flag38)
													{
														Class70.smethod_52(gstruct, "<color=yellow>[*] TONG KIM - PHLT...", 1);
														long_4 = Class12.smethod_27();
													}
													bool flag39 = Form1.int_44[0] > 0;
													if (flag39)
													{
														Class56.smethod_9(int_1);
														continue;
													}
													bool flag40 = num29 <= 0;
													if (flag40)
													{
														Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num18);
														int num43 = (int)array3[0];
														bool flag41 = !flag3 || num43 <= 0;
														if (flag41)
														{
															uint num44 = num20 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
															uint num45 = Class22.smethod_30(num44 + Class53.gstruct51_73.uint_0, gstruct.int_137);
															int num46 = gstruct.int_66;
															bool flag42 = num46 < 2500000;
															if (flag42)
															{
																num46 = 2500000;
															}
															bool flag43 = !flag3 && (long)num46 > (long)((ulong)num45);
															if (flag43)
															{
																uint num47 = Class22.smethod_30(num44 + Class53.gstruct51_74.uint_0, gstruct.int_137);
																bool flag44 = num47 > 0U;
																if (flag44)
																{
																	int num48 = num46 - (int)num45;
																	bool flag45 = (long)num48 > (long)((ulong)num47);
																	if (flag45)
																	{
																		num48 = (int)num47;
																	}
																	bool flag46 = !flag && gstruct.string_15 != null && gstruct.string_15 != string.Empty;
																	if (flag46)
																	{
																		uint num49 = Class12.smethod_12(gstruct.string_15);
																		bool flag47 = num49 > 0U;
																		if (flag47)
																		{
																			Class70.smethod_117(gstruct, num49);
																			flag = true;
																			Thread.Sleep(300);
																		}
																	}
																	Class70.smethod_37(gstruct, (uint)num48);
																}
															}
															else
															{
																flag3 = false;
															}
															bool flag48 = Class44.gstruct33_0.int_4 == 977 || ((Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 == 977);
															if (flag48)
															{
																Thread.Sleep(1000);
																Class35.smethod_140(gstruct, 977, null, null, false);
															}
														}
														else
														{
															bool value = false;
															bool flag49 = num29 == 0;
															if (flag49)
															{
																value = (Class91.smethod_0(gstruct, true, null) != 1);
															}
															array3[0] = Convert.ToByte(value);
															Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num18);
														}
														continue;
													}
													flag3 = false;
												}
												bool flag50 = Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct.int_137) != 0U && !flag6;
												if (flag50)
												{
													flag4 = false;
													bool flag51 = Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct.int_137) == 0U;
													if (!flag51)
													{
														bool flag52 = array7 != null;
														if (flag52)
														{
															Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_22 * 4U, array3, 1, ref num18);
															bool flag53 = array3[0] > 0;
															if (flag53)
															{
																bool flag54 = Class56.uint_0 != null && Class56.uint_0[0] != 0U && Class56.uint_0[1] != 0U && Class56.uint_1 != null && Class56.uint_1[0] != 0U && Class56.uint_1[1] != 0U && Class56.int_1 == num28;
																if (flag54)
																{
																	array5 = new uint[]
																	{
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																	};
																	long num50 = Class60.smethod_18(array5, Class56.uint_1);
																	bool flag55 = !flag6;
																	if (flag55)
																	{
																		Class60.smethod_29(gstruct, false);
																		bool flag56 = num50 > 160000L;
																		if (flag56)
																		{
																			bool flag57 = Class12.smethod_28(long_) > 4000L;
																			if (flag57)
																			{
																				Class14.smethod_1(gstruct, Class56.uint_1);
																				long_ = Class12.smethod_27();
																			}
																			continue;
																		}
																		Class14.smethod_2(gstruct, false);
																		bool flag58 = !(flag6 = (num50 <= 12500L));
																		if (flag58)
																		{
																			Class70.smethod_61(gstruct, Class56.uint_1);
																		}
																	}
																	bool flag59 = flag6;
																	if (flag59)
																	{
																		uint[] uint_2 = Class60.smethod_5(Class56.uint_0, Class56.uint_1, 1000);
																		Class70.smethod_61(gstruct, uint_2);
																	}
																	Thread.Sleep(150);
																	continue;
																}
																flag6 = true;
															}
															bool flag60 = flag6;
															if (flag60)
															{
																array3[0] = 0;
																Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_22 * 4U, array3, 1, ref num18);
															}
														}
														bool flag61 = gstruct.int_63 > 0 && (num < 0 || num != Class79.smethod_4(gstruct));
														if (flag61)
														{
															Class60.smethod_15(gstruct, gstruct.string_6);
															num = Class79.smethod_4(gstruct);
														}
														bool flag62 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && (Class44.gstruct33_1.int_3 > 0 || Form1.int_22 > 0) && Class44.gstruct33_1.int_4 > 0 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0);
														bool flag63 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_6 > 0 && Class44.gstruct33_0.int_4 == num28 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class44.gstruct33_0.int_3 > 0;
														bool flag64 = !gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0);
														array5 = new uint[]
														{
															Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
															Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
														};
														bool flag65 = flag63 && gstruct.int_136 != Class44.gstruct33_0.int_0;
														if (!flag65)
														{
															bool flag66 = gstruct.int_68 != null && gstruct.int_68[0] > 0 && !FormMayphu.bool_3;
															if (flag66)
															{
																bool flag67 = num11 <= 0L || Class12.smethod_28(num11) >= 1000L;
																if (flag67)
																{
																	uint[] array8 = Class60.smethod_26(gstruct, ref num10);
																	bool flag68 = array8 == null;
																	if (flag68)
																	{
																		num11 = Class12.smethod_27();
																	}
																	else
																	{
																		num11 = 0L;
																		long num51 = Class60.smethod_18(array5, array8);
																		bool flag69 = num51 < 8000L;
																		if (flag69)
																		{
																			goto IL_1CA2;
																		}
																		bool flag70 = num51 >= 15000L && num51 >= (long)(gstruct.int_68[1] * gstruct.int_68[1]);
																		if (flag70)
																		{
																			bool flag71 = num51 < 360000L;
																			if (flag71)
																			{
																				Class14.smethod_2(gstruct, false);
																				bool flag72 = num15 > 0;
																				if (flag72)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				num15 = 0;
																				Class70.smethod_61(gstruct, array8);
																				Thread.Sleep(150);
																				continue;
																			}
																			bool flag73 = num51 < 1200000L;
																			if (flag73)
																			{
																				bool flag74 = Class12.smethod_28(long_) > 3000L;
																				if (flag74)
																				{
																					Class14.smethod_1(gstruct, array8);
																					long_ = Class12.smethod_27();
																				}
																				continue;
																			}
																		}
																		else
																		{
																			bool flag75 = num26 <= 3 && num51 > 7500L;
																			if (flag75)
																			{
																				bool flag76 = num15 > 0;
																				if (flag76)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				num15 = 0;
																				Class70.smethod_61(gstruct, array8);
																				Thread.Sleep(150);
																				goto IL_3746;
																			}
																		}
																	}
																}
															}
															bool flag77 = flag62;
															if (flag77)
															{
																int num52 = FormMayphu.smethod_10(gstruct, ref long_, ref num6, ref array);
																bool flag78 = num52 <= 0;
																if (flag78)
																{
																	Thread.Sleep(100);
																	continue;
																}
																num26 = (int)Class22.smethod_30(num24 + Class53.gstruct51_55.uint_0, gstruct.int_137);
																bool flag79 = num26 < 3;
																if (flag79)
																{
																	array5 = new uint[]
																	{
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																	};
																	bool flag80 = Class60.smethod_18(array5, Class44.gstruct33_1.uint_4) > 5625L;
																	if (flag80)
																	{
																		bool flag81 = num15 > 0;
																		if (flag81)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																		}
																		num15 = 0;
																		Class70.smethod_61(gstruct, Class44.gstruct33_1.uint_4);
																		Thread.Sleep(150);
																	}
																}
															}
															goto IL_1691;
														}
														array5 = new uint[]
														{
															Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
															Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
														};
														long num53 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
														bool flag82 = gstruct.int_130[0] > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0 && num29 == Class44.gstruct33_0.int_3 && num29 > 0;
														if (flag82)
														{
															int num54 = gstruct.int_130[1] + Form1.int_23;
															bool flag83 = num53 <= (long)(num54 * num54) && Class64.smethod_0(gstruct, Class44.gstruct33_0.uint_4, gstruct.int_130[1]) > 0;
															if (flag83)
															{
																goto IL_1BD2;
															}
														}
														bool flag84 = flag2 || num53 > (long)(num39 * num39);
														if (!flag84)
														{
															Class14.smethod_2(gstruct, false);
															int num55 = num7;
															num7 = 0;
															num6 = 0;
															bool flag85 = num29 > 0 && !gstruct.bool_22 && gstruct.int_93 == 1 && Form1.int_102 > 0 && (Form1.int_31 > 0 || Form1.int_30 > 0 || Form1.int_32 > 0) && Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct.int_137) > 0U;
															if (flag85)
															{
																Class60.smethod_30(gstruct);
															}
															bool flag86 = num12 <= 0L || Class12.smethod_28(num12) >= 1500L;
															if (flag86)
															{
																uint[] uint_3 = new uint[]
																{
																	array5[0],
																	array5[1]
																};
																bool flag87 = Class44.smethod_5(num25, ref array5, ref num5) > 0;
																if (flag87)
																{
																	long num56 = Class60.smethod_18(uint_3, Class44.gstruct33_0.uint_4);
																	long num57 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																	bool flag88 = num57 <= (long)(num39 * num39);
																	if (flag88)
																	{
																		num12 = Class12.smethod_27();
																		bool flag89 = num15 > 0;
																		if (flag89)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																		}
																		num15 = 0;
																		Class44.smethod_6(gstruct, array5, Class44.gstruct33_0.uint_4, num56 <= 5625L);
																		goto IL_3746;
																	}
																	bool flag90 = num55 > 0;
																	if (flag90)
																	{
																		uint[] uint_4 = Class60.smethod_5(array5, Class44.gstruct33_0.uint_4, -100);
																		Class70.smethod_61(gstruct, uint_4);
																		Thread.Sleep(120);
																	}
																	goto IL_3CE7;
																}
																else
																{
																	num12 = 0L;
																	bool flag91 = num15 == 0 && Class60.smethod_18(uint_3, Class44.gstruct33_0.uint_4) > (long)(Form1.int_23 * Form1.int_23);
																	if (flag91)
																	{
																		num8++;
																		bool flag92 = num8 > 3;
																		if (flag92)
																		{
																			Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
																			Thread.Sleep(150);
																			num8 = 0;
																		}
																	}
																	bool flag93 = Form1.int_27 > 0 && num29 > 0 && gstruct.int_131[0] > 0 && Class70.smethod_3(gstruct, Class70.uint_31, 4) == 0;
																	if (flag93)
																	{
																		Class70.smethod_2(gstruct, Class70.uint_31, 1, 4);
																	}
																}
															}
															num6 = 0;
															array = null;
															uint_ = Class44.gstruct33_0.uint_4;
															bool_ = true;
															goto IL_1691;
														}
														IL_3CE7:
														flag2 = (num53 > 40000L);
														Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
														num15 = 0;
														bool flag94 = array == null;
														if (flag94)
														{
															array = new uint[]
															{
																array5[0],
																array5[1]
															};
															num6 = 0;
														}
														bool flag95 = num6 > 6;
														if (flag95)
														{
															long num58 = Class60.smethod_18(array, array5);
															array = null;
															bool flag96 = num58 < 180000L;
															if (flag96)
															{
																Class14.smethod_2(gstruct, false);
																Class60.smethod_2(gstruct, array5, Class44.gstruct33_0.uint_4, 600);
																goto IL_3746;
															}
															num6 = 0;
														}
														bool flag97 = num53 > (long)(Form1.int_101 * Form1.int_101);
														if (flag97)
														{
															Class60.smethod_29(gstruct, false);
														}
														bool flag98 = num53 < 900000L && num7 < 6;
														if (flag98)
														{
															num7++;
															Class14.smethod_2(gstruct, false);
															Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
															Thread.Sleep(150);
															goto IL_3746;
														}
														bool flag99 = Class44.gstruct33_0.uint_4 != null && (!Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 4000L);
														if (flag99)
														{
															Class14.smethod_1(gstruct, Class44.gstruct33_0.uint_4);
															Thread.Sleep(300);
															long_ = Class12.smethod_27();
															num6++;
															num7 = 0;
														}
														continue;
														IL_1BD2:
														bool flag100 = !gstruct.bool_58 || gstruct.int_83 <= 0;
														if (flag100)
														{
															continue;
														}
														bool flag101 = Form1.int_99 == 0;
														if (flag101)
														{
															bool flag102 = num41 > 0 && num40 > 0 && Class12.smethod_28(long_3) > gstruct.long_8;
															if (flag102)
															{
																Class36.smethod_54(gstruct, array6, false, 10);
																Class36.smethod_55(gstruct);
																long_3 = Class12.smethod_27();
															}
														}
														else
														{
															bool flag103 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
															if (flag103)
															{
																Class36.smethod_54(gstruct, null, true, 10);
																bool flag104 = Class12.smethod_28(long_3) > gstruct.long_8;
																if (flag104)
																{
																	Class36.smethod_55(gstruct);
																	long_3 = Class12.smethod_27();
																}
															}
														}
														continue;
														IL_3746:
														bool flag105 = !flag64 && gstruct.int_136 != Class44.gstruct33_0.int_0 && Class36.smethod_58(gstruct, new int[]
														{
															0,
															1
														}) > 0U;
														if (flag105)
														{
															bool flag106 = num15 > 0;
															if (flag106)
															{
																Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
															}
															num15 = 0;
														}
														bool flag107 = flag33 && num41 <= 0;
														if (flag107)
														{
															FormDuongMon.smethod_0(gstruct, ref num13, uint_, ref num14, bool_);
														}
														goto IL_1BD2;
														IL_1CA2:
														bool flag108 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
														if (flag108)
														{
															long num59 = Class12.smethod_28(long_2);
															bool flag109 = num59 < 300L;
															if (flag109)
															{
																continue;
															}
															bool flag110 = num59 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
															if (flag110)
															{
																Thread.Sleep(80);
																long_2 = Class12.smethod_27();
																continue;
															}
														}
														for (int j = 0; j < Class53.int_0; j++)
														{
															Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num18);
															bool flag111 = array3[0] == 0;
															if (flag111)
															{
																break;
															}
															Thread.Sleep(1);
														}
														bool bool_2 = gstruct.bool_22;
														if (bool_2)
														{
															bool flag112 = gstruct.int_136 != Class44.gstruct33_0.int_0;
															if (flag112)
															{
																Class60.smethod_29(gstruct, false);
															}
														}
														else
														{
															bool flag113 = gstruct.int_128[0] > 0 && gstruct.int_128[1] > 0 && gstruct.int_128[2] > 0;
															bool flag114 = gstruct.int_128[0] > 0 && gstruct.int_128[3] > 0 && gstruct.int_128[4] > 0;
															bool flag115 = gstruct.int_128[0] > 0 && gstruct.int_128[5] > 0 && gstruct.int_128[6] > 0;
															flag33 = ((flag113 || flag114 || flag115) && gstruct.string_23 == "DUONGMON");
															bool flag116 = FormDame.int_6 <= 0 || gstruct.int_126 != 0 || flag33;
															if (!flag116)
															{
																bool flag117 = flag64 || FormDame.int_10 > 0;
																if (flag117)
																{
																	int num60 = 0;
																	bool flag118 = FormDame.int_9 == 0;
																	if (!flag118)
																	{
																		bool flag119 = Class44.gstruct33_0.int_8 == 1 || (flag62 && Class44.gstruct33_1.int_8 == 1);
																		bool flag120 = FormDame.int_9 == 1;
																		if (flag120)
																		{
																			bool flag121 = flag119;
																			if (flag121)
																			{
																				goto IL_37E8;
																			}
																			bool flag122 = FormDame.int_11 > 0;
																			if (!flag122)
																			{
																				bool flag123 = num15 > 0;
																				if (flag123)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				num15 = 0;
																				goto IL_1F56;
																			}
																		}
																		else
																		{
																			bool flag124 = FormDame.int_9 != 2 || flag119;
																			if (!flag124)
																			{
																				bool flag125 = num15 > 0;
																				if (flag125)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				num15 = 0;
																				goto IL_1F56;
																			}
																		}
																		goto IL_1F5D;
																		IL_1F56:
																		goto IL_1F57;
																	}
																	IL_37E8:
																	uint num61 = 0U;
																	uint[] array9 = null;
																	uint[] uint_5 = null;
																	bool flag126 = flag62;
																	if (flag126)
																	{
																		uint num62 = Class44.gstruct33_1.uint_5 >> 16;
																		uint num63 = Class44.gstruct33_1.uint_5 - (num62 << 16);
																		array9 = Class83.smethod_11(Class44.gstruct33_1.uint_4, (int)num63, (int)num62);
																		uint[] array10 = Class83.smethod_10(array5, array9);
																		num61 = (array10[1] << 16) + array10[0];
																		uint_5 = Class44.gstruct33_1.uint_4;
																		Class83.smethod_7(gstruct, num61);
																		Thread.Sleep(10);
																	}
																	else
																	{
																		bool flag127 = gstruct.int_136 != Class44.gstruct33_0.int_0 && gstruct.int_136 != Class76.gstruct49_0.int_136 && Class44.gstruct33_0.uint_5 > 0U;
																		if (flag127)
																		{
																			uint num64 = Class44.gstruct33_0.uint_5 >> 16;
																			uint num65 = Class44.gstruct33_0.uint_5 - (num64 << 16);
																			array9 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)num65, (int)num64);
																			uint[] array11 = Class83.smethod_10(array5, array9);
																			num61 = (array11[1] << 16) + array11[0];
																			uint_5 = Class44.gstruct33_0.uint_4;
																			Class83.smethod_7(gstruct, num61);
																			Thread.Sleep(10);
																		}
																	}
																	Class60.smethod_30(gstruct);
																	bool flag128 = gstruct.int_127[0] == 2;
																	if (flag128)
																	{
																		Class60.smethod_0(gstruct.uint_4, gstruct.int_129, FormDame.int_12);
																	}
																	else
																	{
																		bool flag129 = gstruct.int_127[0] == 0;
																		if (flag129)
																		{
																			bool flag130 = gstruct.int_127[1] > 0 && gstruct.int_127[2] > 0;
																			bool flag131 = gstruct.int_127[3] > 0 && gstruct.int_127[4] > 0;
																			bool flag132 = !flag130 || flag131;
																			if (flag132)
																			{
																				bool flag133 = flag131 && !flag130;
																				if (flag133)
																				{
																					num60 = gstruct.int_127[4];
																				}
																				else
																				{
																					bool flag134 = flag130 && flag131;
																					if (flag134)
																					{
																						num60 = ((0 > num9 || num9 > 25) ? gstruct.int_127[4] : gstruct.int_127[2]);
																						bool flag135 = num9 > 35;
																						if (flag135)
																						{
																							num9 = 0;
																						}
																						num9++;
																					}
																				}
																			}
																			else
																			{
																				num60 = gstruct.int_127[2];
																			}
																		}
																		bool flag136 = num60 <= 0;
																		if (flag136)
																		{
																			num60 = Class77.smethod_13(gstruct);
																		}
																		bool flag137 = gstruct.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
																		if (flag137)
																		{
																			Class77.smethod_9(gstruct, null);
																		}
																		Class77.smethod_5(gstruct, num60, 6, 1);
																		for (int k = 0; k < 3; k++)
																		{
																			Class22.smethod_76(gstruct.uint_4, 117);
																			bool flag138 = k < 2;
																			if (flag138)
																			{
																				Thread.Sleep(60);
																			}
																		}
																	}
																	bool flag139 = num61 != 0U && gstruct.int_136 != Class76.gstruct49_0.int_136;
																	if (flag139)
																	{
																		bool flag140 = gstruct.int_95 <= 0;
																		if (flag140)
																		{
																			Class22.smethod_30(num24 + Class53.gstruct51_31.uint_0, gstruct.int_137);
																			int num66 = Class77.smethod_13(gstruct);
																			bool flag141 = num66 == 53 || num66 <= 1;
																			if (flag141)
																			{
																				goto IL_3746;
																			}
																			bool flag142 = num66 <= 100;
																			if (flag142)
																			{
																			}
																		}
																		string string_ = Class83.smethod_20(gstruct);
																		bool flag143 = Class12.smethod_2(string_, "iÓm qu¸ x", false);
																		if (flag143)
																		{
																			uint[] array12 = Class60.smethod_5(uint_5, array9, -1 * (Form1.int_23 - 50));
																			long num67 = Class60.smethod_18(array5, array12);
																			bool flag144 = num67 > 7000L;
																			if (flag144)
																			{
																				Class70.smethod_61(gstruct, array12);
																				Thread.Sleep(150);
																				Class83.smethod_21(gstruct, "0K..");
																			}
																		}
																	}
																}
																IL_1F57:
																goto IL_1F58;
															}
															IL_1F5D:
															bool flag145 = flag64;
															if (flag145)
															{
																bool flag146 = !Class44.smethod_7(gstruct, ref num17) && Class83.smethod_12(gstruct) != 1;
																if (flag146)
																{
																	num28 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																	array5 = new uint[]
																	{
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																		Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																	};
																	uint[] uint_6 = array5;
																	bool flag147 = flag63 && Class44.gstruct33_0.int_4 == num28 && Class44.gstruct33_0.int_3 > 0 && Class44.gstruct33_0.uint_4 != null;
																	if (flag147)
																	{
																		uint_6 = Class44.gstruct33_0.uint_4;
																		num37 += num39;
																	}
																	uint num68 = 0U;
																	bool flag148 = Form1.int_33 > 0 && (flag62 || flag63);
																	if (flag148)
																	{
																		bool flag149 = !flag62;
																		if (flag149)
																		{
																			bool flag150 = flag63 && Class44.gstruct33_0.int_4 == num28 && Class44.gstruct33_0.uint_3 != num25;
																			if (flag150)
																			{
																				num68 = Class44.gstruct33_0.uint_3;
																			}
																		}
																		else
																		{
																			bool flag151 = Class44.gstruct33_1.int_4 == num28 && Class44.gstruct33_1.uint_3 != num25;
																			if (flag151)
																			{
																				num68 = Class44.gstruct33_1.uint_3;
																			}
																		}
																		bool flag152 = num68 == 0U && Form1.int_34 <= 0;
																		if (flag152)
																		{
																			goto IL_3746;
																		}
																	}
																	bool flag153 = gstruct.int_119 > 0 && gstruct.int_3 != null;
																	if (flag153)
																	{
																		int[,] array13 = (gstruct.int_5 > 0) ? Class7.smethod_5(gstruct, num68, num37, uint_6, null, false, Form1.int_94 > 0, false) : Class7.smethod_6(gstruct, num68, num37, uint_6, null, false, Form1.int_94 > 0, false);
																		bool flag154 = array13 != null && array13[0, 0] >= 0;
																		if (flag154)
																		{
																			int num69 = -1;
																			int int_2 = Class44.gstruct33_0.int_4;
																			num15 = 0;
																			bool flag155 = false;
																			bool flag156 = false;
																			for (;;)
																			{
																				int l = 0;
																				int num70 = 400;
																				while (l <= 0)
																				{
																					num69++;
																					bool flag157 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num69 && gstruct.int_4 != null;
																					if (!flag157)
																					{
																						goto IL_2249;
																					}
																					l = gstruct.int_3[num69, 0];
																					bool flag158 = l > 0;
																					if (flag158)
																					{
																						num70 = Class77.smethod_20(gstruct, l, gstruct.int_3[num69, 1]);
																						break;
																					}
																				}
																				num26 = (int)Class22.smethod_30(num24 + Class53.gstruct51_55.uint_0, gstruct.int_137);
																				num27 = (int)Class22.smethod_30(num24 + Class53.gstruct51_50.uint_0, gstruct.int_137);
																				num29 = (int)Class22.smethod_30(num24 + Class53.gstruct51_43.uint_0, gstruct.int_137);
																				int num71 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																				bool flag159 = num29 > 0 && num28 == num71 && num26 != 11 && num26 != 22 && num27 != 0;
																				if (!flag159)
																				{
																					goto IL_27F7;
																				}
																				for (int m = 0; m < array13.GetLength(0); m++)
																				{
																					bool flag160 = Class44.smethod_7(gstruct, ref num17) || Class83.smethod_12(gstruct) == 1;
																					if (flag160)
																					{
																						goto Block_289;
																					}
																					num40 = array13[m, 0];
																					num41 = array13[m, 1];
																					bool flag161 = num41 <= 0;
																					if (!flag161)
																					{
																						uint num72 = num22 + (uint)(num41 * (int)Class53.gstruct51_15.uint_0);
																						Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_50.uint_0, array3, 4, ref num18);
																						bool flag162 = BitConverter.ToInt32(array3, 0) <= 0;
																						if (!flag162)
																						{
																							bool flag163 = num40 > 0;
																							if (flag163)
																							{
																								Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_43.uint_0, array3, 4, ref num18);
																								bool flag164 = BitConverter.ToInt32(array3, 0) <= 0;
																								if (flag164)
																								{
																									goto IL_27C3;
																								}
																							}
																							flag155 = true;
																							bool flag165 = !flag156 || num40 > 0;
																							if (!flag165)
																							{
																								goto IL_27C1;
																							}
																							bool flag166 = num40 > 0;
																							if (flag166)
																							{
																								flag156 = true;
																							}
																							bool flag167 = Class98.smethod_31(gstruct, num41, l) != 0;
																							if (!flag167)
																							{
																								num38 = num70;
																								Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num18);
																								array6[0] = BitConverter.ToUInt32(array3, 0);
																								Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num18);
																								array6[1] = BitConverter.ToUInt32(array3, 0);
																								array5 = new uint[]
																								{
																									Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																									Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																								};
																								bool flag168 = flag63;
																								if (flag168)
																								{
																									array5 = new uint[]
																									{
																										Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																										Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																									};
																									long num73 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																									bool flag169 = int_2 != Class44.gstruct33_0.int_4 || num73 > (long)(num39 * num39);
																									if (flag169)
																									{
																										goto Block_300;
																									}
																									int num74 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																									int num75 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																									int num76 = num74 - num39 + 10;
																									bool flag170 = num74 > num39 && num38 < num76 && (num75 > num74 || (num75 < num74 && num38 < num75));
																									if (flag170)
																									{
																										num38 = num76;
																									}
																								}
																								bool flag171 = Class60.smethod_18(array5, array6) > (long)(num38 * num38) && gstruct.int_95 <= 0;
																								if (!flag171)
																								{
																									for (int j = 0; j < Class53.int_0; j++)
																									{
																										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num18);
																										bool flag172 = array3[0] == 0;
																										if (flag172)
																										{
																											break;
																										}
																										Thread.Sleep(1);
																									}
																									Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(l), 4, ref num18);
																									Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num38), 4, ref num18);
																									Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num18);
																									Thread.Sleep(10);
																									num15 = 1;
																								}
																							}
																						}
																					}
																					IL_27C3:;
																				}
																			}
																			IL_2DDE:
																			goto IL_2DDF;
																			IL_2841:
																			bool flag173 = num15 > 0 || gstruct.int_6 > 0 || !flag155;
																			if (flag173)
																			{
																				bool flag174 = flag155 && num15 <= 0 && gstruct.int_6 > 0;
																				if (flag174)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				goto IL_2DDE;
																			}
																			long num77 = 0L;
																			array5 = new uint[]
																			{
																				Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																				Class22.smethod_30(num24 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																			};
																			num40 = -1;
																			num41 = -1;
																			flag156 = false;
																			num38 = gstruct.int_97;
																			bool flag175 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
																			if (flag175)
																			{
																				num38 = gstruct.int_96;
																			}
																			bool flag176 = num38 <= 0;
																			if (flag176)
																			{
																				num38 = 500;
																			}
																			for (int n = 0; n < array13.GetLength(0); n++)
																			{
																				int num78 = array13[n, 0];
																				int num79 = array13[n, 1];
																				int num80 = num38;
																				bool flag177 = num79 <= 0;
																				if (!flag177)
																				{
																					uint num72 = num22 + (uint)(num79 * (int)Class53.gstruct51_15.uint_0);
																					Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_50.uint_0, array3, 4, ref num18);
																					bool flag178 = BitConverter.ToInt32(array3, 0) <= 0;
																					if (!flag178)
																					{
																						bool flag179 = num78 > 0;
																						if (flag179)
																						{
																							Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_43.uint_0, array3, 4, ref num18);
																							bool flag180 = BitConverter.ToInt32(array3, 0) <= 0;
																							if (flag180)
																							{
																								goto IL_2C8E;
																							}
																						}
																						bool flag181 = flag156 && num78 <= 0 && num41 > 0;
																						if (flag181)
																						{
																							break;
																						}
																						Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num18);
																						array6[0] = BitConverter.ToUInt32(array3, 0);
																						Class22.ReadProcessMemory(gstruct.int_137, num72 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num18);
																						array6[1] = BitConverter.ToUInt32(array3, 0);
																						long num81 = Class60.smethod_18(array5, array6);
																						bool flag182 = num41 > 0 && num77 < num81;
																						if (!flag182)
																						{
																							bool flag183 = flag63;
																							if (flag183)
																							{
																								int num82 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																								int num83 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																								int num84 = num82 - num39 + 10;
																								bool flag184 = num82 > num39 && num80 < num84 && (num83 > num82 || (num83 < num82 && num80 < num83));
																								if (flag184)
																								{
																									num80 = num84;
																								}
																							}
																							bool flag185 = num81 <= (long)(num80 * num80) || gstruct.int_95 > 0;
																							if (flag185)
																							{
																								bool flag186 = num78 > 0;
																								if (flag186)
																								{
																									flag156 = true;
																								}
																								num41 = num79;
																								num40 = num78;
																								num77 = num81;
																								num38 = num80;
																							}
																						}
																					}
																				}
																				IL_2C8E:;
																			}
																			bool flag187 = num41 <= 0;
																			if (flag187)
																			{
																				goto IL_2DDE;
																			}
																			Class60.smethod_30(gstruct);
																			for (int j = 0; j < Class53.int_0; j++)
																			{
																				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num18);
																				bool flag188 = array3[0] == 0;
																				if (flag188)
																				{
																					break;
																				}
																				Thread.Sleep(1);
																			}
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num18);
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num38), 4, ref num18);
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num18);
																			goto IL_2DDE;
																			IL_27C1:
																			IL_2249:
																			goto IL_2841;
																			IL_27F7:
																			bool flag189 = num15 > 0;
																			if (flag189)
																			{
																				Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																			}
																			num15 = 0;
																			goto IL_2DDE;
																			Block_300:
																			Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																			goto IL_2DDE;
																			Block_289:
																			Thread.Sleep(100);
																			num15 = 0;
																		}
																		IL_2DDF:;
																	}
																	else
																	{
																		bool flag190 = !(flag64 = (!gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0)));
																		if (flag190)
																		{
																			flag64 = false;
																		}
																		else
																		{
																			int[,] array13 = Class7.smethod_5(gstruct, num68, num37, uint_6, null, false, Form1.int_94 > 0, false);
																			bool flag191 = array13 != null;
																			if (flag191)
																			{
																				bool flag192 = array13[0, 0] == -100;
																				if (flag192)
																				{
																					continue;
																				}
																				int num85 = 0;
																				int num87;
																				for (;;)
																				{
																					bool flag193 = array13[num85, 1] > 0;
																					if (!flag193)
																					{
																						goto IL_308C;
																					}
																					array6 = new uint[]
																					{
																						(uint)array13[num85, 4],
																						(uint)array13[num85, 5]
																					};
																					bool flag194 = flag63;
																					if (flag194)
																					{
																						int num86 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																						num87 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																						bool flag195 = num86 - num38 > 0;
																						if (!flag195)
																						{
																							goto IL_3024;
																						}
																						bool flag196 = num87 > num86;
																						if (flag196)
																						{
																							int num88 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																							bool flag197 = num88 + (num86 - num38) <= num39 + 10;
																							if (flag197)
																							{
																								goto Block_349;
																							}
																						}
																						bool flag198 = gstruct.int_88 == 1 && num85 == 0;
																						if (!flag198)
																						{
																							goto IL_2FCB;
																						}
																						num85 = 1;
																					}
																					else
																					{
																						bool flag199 = Class60.smethod_18(array5, array6) > (long)(num38 * num38) && gstruct.int_95 <= 0;
																						if (!flag199)
																						{
																							goto IL_308A;
																						}
																						bool flag200 = gstruct.int_88 != 1 || num85 != 0;
																						if (flag200)
																						{
																							break;
																						}
																						num85 = 1;
																					}
																				}
																				IL_372C:
																				goto IL_3732;
																				IL_30C5:
																				num40 = array13[num85, 0];
																				num41 = array13[num85, 1];
																				array13[num85, 2];
																				bool flag201 = gstruct.int_95 > 0 && array2[1] > 0;
																				if (flag201)
																				{
																					int num89 = array2[0];
																					int num90 = array2[1];
																					uint num91 = num22 + (uint)(num90 * (int)Class53.gstruct51_15.uint_0);
																					Class22.ReadProcessMemory(gstruct.int_137, num91 + Class53.gstruct51_50.uint_0, array3, 4, ref num17);
																					bool flag202 = BitConverter.ToInt32(array3, 0) > 0;
																					if (flag202)
																					{
																						Class22.ReadProcessMemory(gstruct.int_137, num91 + Class53.gstruct51_45.uint_0, array3, 4, ref num17);
																						long num92 = (long)BitConverter.ToInt32(array3, 0);
																						bool flag203 = num92 != 0L;
																						if (flag203)
																						{
																							bool flag204 = Class22.smethod_30(num91 + Class53.gstruct51_52.uint_0, gstruct.int_137) == 0U;
																							if (flag204)
																							{
																								array6 = new uint[]
																								{
																									Class22.smethod_30(num91 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																									Class22.smethod_30(num91 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																								};
																								long num93 = Class60.smethod_18(array5, array6);
																								bool flag205 = num93 <= (long)((num38 - 100) * (num38 - 100));
																								if (flag205)
																								{
																									num40 = num89;
																									num41 = num90;
																								}
																							}
																						}
																					}
																				}
																				bool flag206 = Form1.int_50 > 0 && (num40 <= 0 || num40 == array2[0]) && array2[1] > 0 && array2[2] == num28 && array2[3] > 0;
																				if (flag206)
																				{
																					int num94 = array2[0];
																					int num95 = array2[1];
																					uint num96 = num22 + (uint)(num95 * (int)Class53.gstruct51_15.uint_0);
																					Class22.ReadProcessMemory(gstruct.int_137, num96 + Class53.gstruct51_50.uint_0, array3, 4, ref num18);
																					bool flag207 = BitConverter.ToInt32(array3, 0) > 0;
																					if (flag207)
																					{
																						Class22.ReadProcessMemory(gstruct.int_137, num96 + Class53.gstruct51_45.uint_0, array3, 4, ref num18);
																						long num97 = (long)BitConverter.ToInt32(array3, 0);
																						bool flag208 = num97 != 0L;
																						if (flag208)
																						{
																							Class22.ReadProcessMemory(gstruct.int_137, num96 + Class53.gstruct51_43.uint_0, array3, 4, ref num18);
																							bool flag209 = num94 <= 0 || BitConverter.ToInt32(array3, 0) > 0;
																							if (flag209)
																							{
																								array6 = new uint[]
																								{
																									Class22.smethod_30(num96 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																									Class22.smethod_30(num96 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																								};
																								long num98 = Class60.smethod_18(array5, array6);
																								bool flag210 = !flag63;
																								if (flag210)
																								{
																									bool flag211 = num98 <= (long)(num38 * num38);
																									if (flag211)
																									{
																										num40 = num94;
																										num41 = num95;
																									}
																								}
																								else
																								{
																									int num99 = (int)Math.Sqrt((double)num98);
																									int num100 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																									bool flag212 = num99 - num38 > 0;
																									if (flag212)
																									{
																										bool flag213 = num100 > num99;
																										if (flag213)
																										{
																											int num101 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																											bool flag214 = num101 + (num99 - num38) <= num39 + 10;
																											if (flag214)
																											{
																												num40 = num94;
																												num41 = num95;
																											}
																										}
																									}
																									else
																									{
																										num40 = num94;
																										num41 = num95;
																									}
																								}
																							}
																						}
																					}
																				}
																				array2[0] = num40;
																				array2[1] = num41;
																				array2[2] = num28;
																				array2[3] = 0;
																				bool flag215 = num41 <= 0;
																				if (flag215)
																				{
																					goto IL_372C;
																				}
																				array2[3] = 1;
																				num15 = 1;
																				num16 = 1;
																				Class60.smethod_30(gstruct);
																				for (int num102 = 0; num102 < Class53.int_0; num102++)
																				{
																					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num18);
																					bool flag216 = array3[0] == 0;
																					if (flag216)
																					{
																						break;
																					}
																					Thread.Sleep(1);
																				}
																				bool flag217 = gstruct.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct, (uint)num41) <= 0;
																				if (flag217)
																				{
																					int value2 = Class77.smethod_13(gstruct);
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(value2), 4, ref num18);
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num38), 4, ref num18);
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num18);
																				}
																				flag7 = (gstruct.gstruct48_0.int_0 > 0 && gstruct.gstruct48_0.int_1 > 0 && gstruct.gstruct48_0.int_8 > 0 && gstruct.gstruct48_0.int_9 > 0);
																				goto IL_372C;
																				IL_308A:
																				goto IL_30C5;
																				IL_3024:
																				goto IL_308A;
																				IL_2FCB:
																				bool flag218 = num39 + num38 <= num87;
																				if (flag218)
																				{
																					bool flag219 = num15 > 0;
																					if (flag219)
																					{
																						Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																					}
																					num15 = 0;
																					goto IL_372C;
																				}
																				Block_349:
																				goto IL_30C5;
																				IL_308C:
																				bool flag220 = num15 > 0;
																				if (flag220)
																				{
																					Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
																				}
																				num15 = 0;
																			}
																			else
																			{
																				flag64 = false;
																			}
																			IL_3732:;
																		}
																	}
																}
																else
																{
																	Thread.Sleep(100);
																	num15 = 0;
																}
															}
														}
														IL_1F58:
														goto IL_3746;
														IL_1691:
														goto IL_1CA2;
													}
												}
												else
												{
													array3[0] = 0;
													Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_22 * 4U, array3, 1, ref num18);
													bool flag221 = gstruct.int_136 == Class44.gstruct33_0.int_0 && Form1.int_88 <= 0 && ((Form1.int_6 <= 0 && Form1.int_7 <= 0) || Class44.gstruct33_1.int_4 <= 0);
													if (flag221)
													{
														Thread.Sleep(300);
													}
													else
													{
														bool flag222 = Form1.int_91 <= 0 && (!flag4 || flag6 || num < 0 || num != Class79.smethod_4(gstruct));
														if (flag222)
														{
															bool flag223 = !Form1.bool_4;
															if (flag223)
															{
																num2++;
																int num103 = Class56.smethod_7(gstruct);
																bool flag224 = num103 <= 0 && num2 < 6;
																if (flag224)
																{
																	Class60.smethod_13(gstruct);
																	Thread.Sleep(300);
																	continue;
																}
															}
															num2 = 0;
															flag4 = true;
															flag6 = false;
															num = Class79.smethod_4(gstruct);
															uint num104 = 1500000U;
															uint num105 = num20 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
															uint num106 = Class22.smethod_30(num105 + Class53.gstruct51_73.uint_0, gstruct.int_137);
															uint num107 = Class22.smethod_30(num105 + Class53.gstruct51_74.uint_0, gstruct.int_137);
															bool flag225 = num106 <= num104;
															if (flag225)
															{
																bool flag226 = num107 == 0U || num106 >= num104 / 2U;
																if (!flag226)
																{
																	int num108 = (int)(num104 - num106);
																	bool flag227 = (long)num108 > (long)((ulong)num107);
																	if (flag227)
																	{
																		num108 = (int)num107;
																	}
																	bool flag228 = !flag && gstruct.string_15 != null && gstruct.string_15 != string.Empty;
																	if (flag228)
																	{
																		uint num109 = Class12.smethod_12(gstruct.string_15);
																		bool flag229 = num109 > 0U;
																		if (flag229)
																		{
																			Class70.smethod_117(gstruct, num109);
																			flag = true;
																			Thread.Sleep(300);
																		}
																	}
																	Class70.smethod_37(gstruct, (uint)num108);
																}
															}
															else
															{
																Class70.smethod_38(gstruct, num106 - num104);
															}
														}
														else
														{
															flag6 = false;
															bool flag230 = 0 <= num42;
															if (flag230)
															{
																bool flag231 = (gstruct.int_136 == Class44.gstruct33_0.int_0 && (Form1.int_88 > 0 || ((Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 > 0))) || (gstruct.int_136 != Class44.gstruct33_0.int_0 && (Form1.int_89 <= 0 || Class44.gstruct33_0.int_3 > 0));
																if (flag231)
																{
																	Class60.smethod_22(gstruct, Class56.uint_3, null, null, num28, false, 0, false);
																}
															}
															else
															{
																Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num18);
																num28 = BitConverter.ToInt32(array3, 0);
																bool flag232 = num28 != 977;
																if (flag232)
																{
																	int num110 = 0;
																	bool flag233 = Form1.int_90 > 0;
																	if (flag233)
																	{
																		num110 = Class56.smethod_4(gstruct);
																	}
																	bool flag234 = num110 <= 0;
																	if (flag234)
																	{
																		num110 = Class56.smethod_6(gstruct);
																	}
																	bool flag235 = 0 <= Class86.smethod_0(gstruct);
																	if (flag235)
																	{
																		Class86.smethod_5(gstruct, 0);
																		Thread.Sleep(100);
																	}
																	bool flag236 = num110 != 2;
																	if (flag236)
																	{
																		continue;
																	}
																}
																else
																{
																	bool flag237 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_6 > 0 && Class44.gstruct33_0.int_4 == num28 && Class12.smethod_62(Class44.gstruct33_0.uint_4);
																	bool flag238 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && Class44.gstruct33_1.int_4 == num28 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0);
																	int num111 = 8;
																	int num112 = Class60.smethod_20(Class43.uint_0, array5);
																	bool flag239 = Form1.int_89 > 0;
																	if (flag239)
																	{
																		bool flag240 = (flag237 && Class44.gstruct33_0.int_3 <= 0) || (flag238 && Class44.gstruct33_1.int_3 <= 0);
																		if (flag240)
																		{
																			continue;
																		}
																		bool flag241 = flag237;
																		if (flag241)
																		{
																			num111 = Class60.smethod_20(Class43.uint_0, Class44.gstruct33_0.uint_4);
																		}
																		else
																		{
																			bool flag242 = flag238;
																			if (flag242)
																			{
																				num111 = Class60.smethod_20(Class43.uint_0, Class44.gstruct33_1.uint_4);
																			}
																		}
																	}
																	int num113 = Class56.smethod_5(gstruct, new uint[]
																	{
																		Class43.uint_0[num112, 0],
																		Class43.uint_0[num112, 1]
																	}, "D­îc §iÕm|inh s¸t", "tËp kÕt|" + num111.ToString());
																	bool flag243 = num113 != 2;
																	if (flag243)
																	{
																		Thread.Sleep(100);
																		continue;
																	}
																}
																bool flag244 = Class12.smethod_28(long_4) > 10000L;
																if (flag244)
																{
																	Class70.smethod_52(gstruct, Class12.smethod_53(Class12.string_0), 1);
																	long_4 = Class12.smethod_27();
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
						else
						{
							bool flag245 = num15 > 0;
							if (flag245)
							{
								Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_72.uint_0, byte_, 4, ref num18);
							}
							bool flag246 = Form1.int_121 > 0;
							if (flag246)
							{
								Class22.WriteProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num18);
							}
							num15 = 0;
							num16 = 0;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.StackTrace);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000A5B40 File Offset: 0x000A3D40
		private static void smethod_1()
		{
			int int_ = Class61.int_0;
			Class61.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25 || (Form1.int_20 != 1 && Form1.int_20 != 3) || Form1.int_92 <= 0;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_44 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_44;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_44 = true;
						flag = true;
					}
					Class61.smethod_2(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000A5C3C File Offset: 0x000A3E3C
		private static void smethod_2(int int_1)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			GStruct49 gstruct = default(GStruct49);
			uint uint_ = 0U;
			byte[] array;
			for (;;)
			{
				num2--;
				Thread.Sleep(300);
				bool flag = Class12.bool_0 || (Form1.int_20 != 1 && Form1.int_20 != 3) || Form1.int_92 <= 0;
				if (flag)
				{
					break;
				}
				bool flag2 = num2 <= 0;
				if (flag2)
				{
					num = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag3 = num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag3)
					{
						break;
					}
					num2 = 3;
				}
				gstruct = Form1.gstruct49_0[num];
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num6 = num5 * Class53.gstruct51_15.uint_0;
				uint num7 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num8 = num7 + num6;
				uint_ = num8 + Class53.gstruct51_89.uint_0;
				int num9 = Class83.smethod_36(gstruct, false);
				int num10 = num9 / 3600;
				int num11 = num9 / 60 - num10 * 60;
				int num12 = num9 % 60;
				int num13 = Class83.smethod_38(gstruct);
				int num14 = Class83.smethod_37(gstruct);
				string string_ = string.Concat(new string[]
				{
					"K:",
					Class83.smethod_35(gstruct, false).ToString(),
					" - T:",
					Class83.smethod_35(gstruct, true).ToString(),
					" (",
					num11.ToString(),
					":",
					num12.ToString(),
					") ",
					num14.ToString(),
					"/",
					num13.ToString()
				});
				array = Class12.smethod_46(string_, true);
				Class22.WriteProcessMemory(gstruct.int_137, uint_, array, array.Length, ref num3);
			}
			string string_2 = Class26.smethod_10(gstruct);
			array = Class12.smethod_46(string_2, true);
			Class22.WriteProcessMemory(gstruct.int_137, uint_, array, array.Length, ref num3);
		}

		// Token: 0x040002E2 RID: 738
		private static int int_0;
	}
}
