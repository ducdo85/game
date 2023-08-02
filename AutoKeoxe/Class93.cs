using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200005A RID: 90
	internal class Class93
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x000EB8D8 File Offset: 0x000E9AD8
		public static void smethod_0()
		{
			int int_ = Class93.int_0;
			Class93.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_34 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_34;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_34 = true;
						flag = true;
					}
					Class93.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000EB9B8 File Offset: 0x000E9BB8
		private static void smethod_1(int int_1)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[48];
			for (;;)
			{
				Thread.Sleep(800);
				int num3 = Class81.smethod_3(Form1.gstruct49_0, int_1);
				bool flag = Class12.bool_0 || num3 < 0 || !Form1.gstruct49_0[num3].bool_25;
				if (flag)
				{
					break;
				}
				num++;
				bool flag2 = num < 10 || Form1.gstruct49_0[num3].int_121[0] == 0;
				if (!flag2)
				{
					try
					{
						gstruct = Form1.gstruct49_0[num3];
					}
					catch
					{
						continue;
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num2);
					bool flag3 = num2 != 4;
					if (!flag3)
					{
						uint num4 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num4 + Class53.gstruct51_13.uint_0, array, 4, ref num2);
						uint num5 = BitConverter.ToUInt32(array, 0);
						uint num6 = num5 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num2);
						bool flag4 = num2 != 4;
						if (!flag4)
						{
							uint num7 = BitConverter.ToUInt32(array, 0);
							uint num8 = num7 + num6;
							Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_55.uint_0, array, 4, ref num2);
							int num9 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_50.uint_0, array, 4, ref num2);
							int num10 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num2);
							int num11 = BitConverter.ToInt32(array, 0);
							int num12 = Class83.smethod_39(gstruct);
							bool flag5 = num10 <= 0 || num11 <= 0 || num9 <= 0 || num12 <= 1;
							if (!flag5)
							{
								num = 0;
								bool flag6 = num11 == 962 || num11 == 963 || (849 <= num11 && num11 <= 862) || (464 <= num11 && num11 <= 471) || (480 <= num11 && num11 <= 495);
								if (!flag6)
								{
									int[] array3 = Class56.smethod_0(num11);
									bool flag7 = array3 == null || Class56.smethod_2(num11) >= 0;
									if (flag7)
									{
										string text = Class26.smethod_10(gstruct);
										GStruct59 gstruct2 = Class82.smethod_5(gstruct);
										bool flag8 = gstruct.int_121[4] > 0;
										if (flag8)
										{
											byte[] array4 = new byte[1];
											bool flag9 = gstruct2.int_0 > 0;
											if (flag9)
											{
												array4 = Class12.smethod_46("PT(" + gstruct2.int_0.ToString() + ")-" + gstruct2.string_0, true);
											}
											else
											{
												bool flag10 = text != string.Empty;
												if (flag10)
												{
													array4 = Class12.smethod_46(text, true);
												}
											}
											Class22.WriteProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_89.uint_0, array4, array4.Length, ref num2);
										}
										bool flag11 = gstruct.int_121[1] != 0;
										if (flag11)
										{
											bool flag12 = (463 >= num11 || num11 >= 472) && (479 >= num11 || num11 >= 496);
											if (flag12)
											{
												bool flag13 = gstruct2.int_0 == 0;
												if (flag13)
												{
													Class82.smethod_1(gstruct);
												}
												else
												{
													bool flag14 = !(gstruct2.string_0 != gstruct.string_22);
													if (flag14)
													{
														int num13 = (int)Class22.smethod_30(num4 + Class53.gstruct51_23.uint_0, gstruct.int_137);
														bool flag15 = (4 <= gstruct2.int_0 && num13 < 6) || (5 <= gstruct2.int_0 && num13 < 12) || (6 <= gstruct2.int_0 && num13 < 19) || (7 <= gstruct2.int_0 && num13 < 19) || 8 <= gstruct2.int_0;
														if (flag15)
														{
															continue;
														}
													}
													else
													{
														Class82.smethod_2(gstruct);
														Thread.Sleep(600);
														Class82.smethod_1(gstruct);
													}
												}
												uint uint_ = gstruct.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
												Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 4, ref num2);
												int num14 = BitConverter.ToInt32(array, 0);
												bool flag16 = num14 <= 1;
												if (!flag16)
												{
													int num15 = 0;
													string[] array5 = null;
													for (uint num16 = 1U; num16 < 256U; num16 += 1U)
													{
														bool flag17 = num16 % 60U == 0U;
														if (flag17)
														{
															Thread.Sleep(100);
														}
														bool flag18 = num14 <= num15;
														if (flag18)
														{
															break;
														}
														bool flag19 = num16 == num5;
														if (flag19)
														{
															num15++;
														}
														else
														{
															uint num17 = num7 + num16 * Class53.gstruct51_15.uint_0;
															Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_16.uint_0, array, 4, ref num2);
															bool flag20 = array[0] == 0;
															if (!flag20)
															{
																num15++;
																Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_50.uint_0, array, 4, ref num2);
																bool flag21 = BitConverter.ToInt32(array, 0) <= 0 || Class22.smethod_30(num17 + Class53.gstruct51_52.uint_0, gstruct.int_137) != 1U;
																if (!flag21)
																{
																	Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num2);
																	string text2 = Class10.smethod_3(array2);
																	bool flag22 = text2.Length < 5;
																	if (!flag22)
																	{
																		bool flag23 = gstruct2.gstruct58_0 != null;
																		if (flag23)
																		{
																			bool flag24 = false;
																			for (int i = 1; i < gstruct2.gstruct58_0.Length; i++)
																			{
																				bool flag25 = text2 == gstruct2.gstruct58_0[i].string_0;
																				if (flag25)
																				{
																					flag24 = true;
																					break;
																				}
																			}
																			bool flag26 = flag24;
																			if (flag26)
																			{
																				goto IL_7F6;
																			}
																		}
																		bool flag27 = gstruct.int_121[2] > 0 && gstruct.string_19 != null;
																		if (flag27)
																		{
																			for (int j = 0; j < gstruct.string_19.Length; j++)
																			{
																				bool flag28 = !(text2 == gstruct.string_19[j]);
																				if (!flag28)
																				{
																					Class12.smethod_29(ref array5, text2);
																					goto IL_7C3;
																				}
																			}
																		}
																		bool flag29 = gstruct.int_121[3] > 0 && text != string.Empty;
																		if (flag29)
																		{
																			Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_89.uint_0, array2, array2.Length, ref num2);
																			string string_ = Class10.smethod_3(array2);
																			bool flag30 = 0 <= Class12.smethod_1(string_, text);
																			if (flag30)
																			{
																				goto IL_7C3;
																			}
																		}
																		bool flag31 = gstruct.int_121[2] > 0 || gstruct.int_121[3] > 0;
																		if (flag31)
																		{
																			goto IL_7F6;
																		}
																		uint[] uint_2 = new uint[]
																		{
																			Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																			Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																		};
																		uint[] uint_3 = new uint[]
																		{
																			Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																			Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																		};
																		long num18 = Class60.smethod_18(uint_2, uint_3);
																		bool flag32 = num18 > 500000L;
																		if (flag32)
																		{
																			goto IL_7F6;
																		}
																		IL_7C3:
																		Class70.smethod_57(gstruct, "InviteTeam('" + text2 + "')");
																		Thread.Sleep(300);
																	}
																}
															}
														}
														IL_7F6:;
													}
													bool flag33 = array5 != null;
													if (flag33)
													{
														for (int k = 0; k < array5.Length; k++)
														{
															Class70.smethod_57(gstruct, "InviteTeam('" + array5[k] + "')");
															Thread.Sleep(600);
														}
													}
												}
											}
											else
											{
												Thread.Sleep(800);
											}
										}
										else
										{
											string text3 = Class52.smethod_2(gstruct, true);
											bool flag34 = text3 == string.Empty;
											if (!flag34)
											{
												bool flag35 = gstruct2.int_0 != 0;
												if (flag35)
												{
													bool flag36 = gstruct2.int_0 > 1;
													if (flag36)
													{
														bool flag37 = gstruct.int_121[2] > 0 && gstruct.string_19 != null;
														if (flag37)
														{
															for (int l = 0; l < gstruct.string_19.Length; l++)
															{
																bool flag38 = !(gstruct2.string_0 == gstruct.string_19[l]);
																if (!flag38)
																{
																	goto IL_B0A;
																}
															}
														}
													}
													else
													{
														Class82.smethod_2(gstruct);
														Thread.Sleep(600);
													}
													goto IL_92F;
												}
												goto IL_92F;
												IL_B0A:
												bool flag39 = text3 == null || Class12.smethod_1(text3, "giao dÞch") >= 0;
												if (flag39)
												{
													continue;
												}
												uint num19 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct.int_137);
												uint num20 = Class22.smethod_30(num19 + Class53.gstruct51_167.uint_0, gstruct.int_137);
												bool flag40 = num20 == 0U;
												if (flag40)
												{
													continue;
												}
												uint num21 = Class22.smethod_30(num20, gstruct.int_137);
												bool flag41 = num21 > 0U;
												if (flag41)
												{
													string text4 = Class22.smethod_28(num21, gstruct.int_137, 78);
													bool flag42 = text4 != null && !(text4 == string.Empty);
													if (flag42)
													{
														Class70.smethod_12(gstruct.int_137, gstruct.uint_55);
													}
												}
												continue;
												IL_92F:
												bool flag43 = Class12.smethod_1(text3, "mêi tæ") > 0;
												if (flag43)
												{
													string[] array6 = text3.Split(new char[]
													{
														'|'
													});
													int m = 0;
													while (m < array6.Length)
													{
														bool flag44 = Class12.smethod_1(array6[m], "mêi tæ") <= 0;
														if (flag44)
														{
															m++;
														}
														else
														{
															bool flag45 = gstruct.int_121[2] <= 0 || gstruct.string_19 == null;
															string text5;
															if (!flag45)
															{
																for (int n = 0; n < gstruct.string_19.Length; n++)
																{
																	bool flag46 = Class12.smethod_1(array6[m], gstruct.string_19[n]) <= 0;
																	if (!flag46)
																	{
																		text5 = array6[m];
																		goto IL_A07;
																	}
																}
																break;
															}
															text5 = array6[m];
															IL_A07:
															bool flag47 = text5 == null;
															if (flag47)
															{
																break;
															}
															string[] array7 = text5.Split(new char[]
															{
																';'
															});
															bool flag48 = array7.Length != 2 || (gstruct2.string_0 != null && Class12.smethod_1(array7[1], gstruct2.string_0 + " ") == 0);
															if (flag48)
															{
																break;
															}
															uint num22 = Class12.smethod_12(array7[0]);
															bool flag49 = num22 > 0U;
															if (flag49)
															{
																Class22.smethod_31(gstruct.uint_54 + 2U, gstruct.int_137, num22, 4);
																Class22.smethod_31(gstruct.uint_54 + 7U, gstruct.int_137, 1U, 1);
																for (int n = 0; n < 3; n++)
																{
																	Class70.smethod_12(gstruct.int_137, gstruct.uint_54);
																	Thread.Sleep(999);
																}
															}
															break;
														}
													}
												}
												goto IL_B0A;
											}
										}
									}
									else
									{
										Thread.Sleep(800);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04000408 RID: 1032
		public static int int_0;
	}
}
