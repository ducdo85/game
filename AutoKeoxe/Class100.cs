using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000004 RID: 4
	internal class Class100
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002400 File Offset: 0x00000600
		public static void smethod_0(int int_4)
		{
			GStruct49 gstruct = default(GStruct49);
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			long long_5 = 0L;
			long long_6 = 0L;
			long num = 0L;
			long num2 = 0L;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = -1;
			int num10 = -1;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[4];
			byte[] array2 = new byte[2];
			byte[] array3 = new byte[1];
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			bool flag12 = false;
			int num11 = -1;
			int num12 = -1;
			GStruct59 gstruct2 = default(GStruct59);
			for (;;)
			{
				Thread.Sleep(200);
				int num13 = Class81.smethod_3(Form1.gstruct49_0, int_4);
				bool flag13 = Class12.bool_0 || num13 < 0;
				if (flag13)
				{
					break;
				}
				bool flag14 = flag10;
				if (flag14)
				{
					Form1.gstruct49_0[num13].int_133[1] = num4;
					flag10 = false;
				}
				gstruct = Form1.gstruct49_0[num13];
				bool flag15 = !gstruct.bool_25 || gstruct.int_133[0] <= 0;
				if (flag15)
				{
					break;
				}
				Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array2, 2, ref num3);
				uint num14 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num15 = Class22.smethod_30(num14 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num16 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num17 = num16 + num15 * Class53.gstruct51_15.uint_0;
				int num18 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
				int num19 = (int)Class22.smethod_30(num17 + Class53.gstruct51_43.uint_0, gstruct.int_137);
				int num20 = (int)Class22.smethod_30(num17 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num21 = (int)Class22.smethod_30(num17 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num22 = Class83.smethod_39(gstruct);
				bool flag16 = num21 <= 0 || num18 <= 0 || num20 == 10 || num20 == 21 || num22 <= 1;
				if (!flag16)
				{
					int num23 = Class83.smethod_12(gstruct);
					bool flag17 = (gstruct.int_136 != Class76.gstruct49_0.int_136 && gstruct.int_136 != Class44.gstruct33_0.int_0) || (num23 != 1 && num23 != 2);
					if (flag17)
					{
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag18 = array4[0] == 0U || array4[1] == 0U;
						if (!flag18)
						{
							int num24 = 0;
							for (;;)
							{
								bool flag19 = num9 != num18;
								if (!flag19)
								{
									goto IL_3BC;
								}
								int num25 = Class83.smethod_39(gstruct);
								Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
								num6 = 0;
								num21 = (int)Class22.smethod_30(num17 + Class53.gstruct51_50.uint_0, gstruct.int_137);
								num18 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
								num19 = (int)Class22.smethod_30(num17 + Class53.gstruct51_43.uint_0, gstruct.int_137);
								bool flag20 = num19 <= 0 && num24 <= 8 && (num25 == 0 || num25 == 1 || num21 <= 0 || num18 <= 0);
								if (!flag20)
								{
									goto IL_3B3;
								}
								num24++;
								Thread.Sleep(100);
							}
							IL_1B2A:
							continue;
							IL_3BC:
							int num26 = gstruct.int_133[3];
							int num27 = Class100.struct27_0[num26].int_0;
							bool flag21 = num11 != num26 || num4 <= 0;
							if (flag21)
							{
								num = -1L;
								num11 = num26;
								flag11 = false;
								flag7 = false;
								Form1.gstruct49_0[num13].int_133[1] = 0;
								num4 = Class100.smethod_1(int_4);
								flag10 = true;
								Class70.smethod_57(gstruct, "ClearMessage()");
								continue;
							}
							bool flag22 = Class100.int_2 <= 0 || num5 > 0;
							if (!flag22)
							{
								Class100.smethod_3(int_4);
								num5 = 1;
								continue;
							}
							bool flag23 = num4 == 2;
							if (flag23)
							{
								Form1.gstruct49_0[num13].int_133[0] = 0;
								Form1.gstruct49_0[num13].int_133[1] = 0;
								bool flag24 = num19 > 0;
								if (flag24)
								{
									bool flag25 = !Class60.smethod_14(gstruct, true);
									if (flag25)
									{
										Class35.smethod_140(gstruct, Class100.struct27_0[num26].int_0, Class100.struct27_0[num26].string_2, null, false);
									}
									Thread.Sleep(1000);
								}
								Class70.smethod_52(gstruct, "<color=yellow>KET THUC, DA 8 LAN GIET SAT THU.", 1);
								continue;
							}
							Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_2 * 4U, array3, 1, ref num3);
							bool flag26 = num19 <= 0;
							if (flag26)
							{
								int num28 = Class79.smethod_4(gstruct);
								bool flag27 = gstruct.int_134 <= 0 && (!flag9 || num12 < 0 || num12 != num28);
								if (flag27)
								{
									bool flag28 = Class40.smethod_0(gstruct) != 0;
									if (flag28)
									{
										int num29 = Class34.smethod_3(gstruct, Form1.int_98 <= 0);
										bool flag29 = num29 == 0 || (num29 < 0 && !flag12);
										if (flag29)
										{
											Thread.Sleep(300);
											flag12 = (num29 < 0);
										}
										else
										{
											flag9 = true;
											flag12 = false;
											num12 = Class79.smethod_4(gstruct);
										}
									}
									else
									{
										Thread.Sleep(300);
									}
									continue;
								}
								bool flag30 = !flag && gstruct.int_65 > 0;
								if (flag30)
								{
									Class60.smethod_3(gstruct, ref flag2);
									flag = true;
								}
							}
							bool flag31 = Class12.smethod_28(long_) > 30000L;
							if (flag31)
							{
								Class83.smethod_32(gstruct, 0U);
								long_ = Class12.smethod_27();
							}
							string[] array5 = Class83.smethod_26(gstruct, 8U);
							bool flag32 = false;
							bool flag33 = array5 != null;
							if (flag33)
							{
								for (int i = 0; i < array5.Length; i++)
								{
									string string_ = array5[i].ToLower();
									bool flag34;
									flag32 = (flag34 = (Class12.smethod_1(string_, ", hoµn thµnh nh".ToLower()) > 0 || Class12.smethod_1(string_, "thñ ®· bÞ tiªu di".ToLower()) > 0 || Class12.smethod_1(string_, "c tªn s¸t thñ".ToLower()) > 0 || Class12.smethod_1(string_, "s¸t thñ lÖnh cÊp 90".ToLower()) > 0 || Class12.smethod_1(string_, "s¸t thñ, hoµn thµnh".ToLower()) > 0));
									if (flag34)
									{
										break;
									}
								}
							}
							bool flag35 = flag32 || flag8;
							if (flag35)
							{
								num4 = 0;
								num5 = 0;
								flag10 = true;
								bool flag36 = num26 + 1 < Class100.struct27_0.Length && Class100.struct27_0[num26 + 1].int_0 == num27;
								if (flag36)
								{
									num26++;
								}
								else
								{
									for (int j = 0; j < Class100.struct27_0.Length; j++)
									{
										bool flag37 = Class100.struct27_0[j].int_0 == num27;
										if (flag37)
										{
											num26 = j;
											break;
										}
									}
								}
								num13 = Class81.smethod_3(Form1.gstruct49_0, int_4);
								bool flag38 = 0 <= num13;
								if (flag38)
								{
									Form1.gstruct49_0[num13].int_133[3] = num26;
								}
								bool flag39 = flag8;
								if (flag39)
								{
									gstruct2 = Class82.smethod_5(gstruct);
									bool flag40 = gstruct2.int_0 > 1 && gstruct2.gstruct58_0 != null && gstruct2.gstruct58_0.Length > 1 && gstruct.string_22 == gstruct2.string_0;
									if (flag40)
									{
										for (int k = 0; k < Form1.gstruct49_0.Length; k++)
										{
											for (int l = 0; l < gstruct2.gstruct58_0.Length; l++)
											{
												bool flag41 = Form1.gstruct49_0[k].bool_25 && Form1.gstruct49_0[k].string_22 == gstruct2.gstruct58_0[l].string_0 && Form1.gstruct49_0[k].int_136 != gstruct.int_136 && Form1.gstruct49_0[k].int_133[0] > 0;
												if (flag41)
												{
													Form1.gstruct49_0[k].int_133[3] = num26;
													Form1.gstruct49_0[k].int_133[1] = 0;
												}
											}
										}
									}
								}
								string str = "TiÕp theo lµ bos <" + Class10.smethod_2(Class100.struct27_0[num26].string_0) + ">";
								bool flag42 = Class82.smethod_5(gstruct).int_0 > 0;
								if (flag42)
								{
									Class70.smethod_57(gstruct, "Chat('CH_TEAM', '" + str + "')");
								}
								else
								{
									Class70.smethod_52(gstruct, "<color=yellow>" + str, 1);
								}
								flag8 = false;
								Thread.Sleep(3000);
								continue;
							}
							bool flag43 = gstruct.int_133[4] > 0;
							if (flag43)
							{
								continue;
							}
							bool flag44 = !flag11 && Form1.gstruct49_0 != null;
							if (flag44)
							{
								gstruct2 = Class82.smethod_5(gstruct);
								bool flag45;
								flag11 = (flag45 = (gstruct2.int_0 <= 1 || gstruct2.gstruct58_0 == null || gstruct2.gstruct58_0.Length <= 1));
								if (flag45)
								{
									continue;
								}
								try
								{
									string text = null;
									bool flag46 = gstruct.string_22 == gstruct2.string_0;
									if (flag46)
									{
										for (int m = 0; m < Form1.gstruct49_0.Length; m++)
										{
											for (int n = 0; n < gstruct2.gstruct58_0.Length; n++)
											{
												bool flag47 = Form1.gstruct49_0[m].bool_25 && Form1.gstruct49_0[m].string_22 == gstruct2.gstruct58_0[n].string_0 && Form1.gstruct49_0[m].int_136 != gstruct.int_136 && Form1.gstruct49_0[m].int_133[0] > 0 && (Form1.gstruct49_0[m].int_133[3] != num26 || Form1.gstruct49_0[m].int_133[1] <= 0);
												if (flag47)
												{
													Form1.gstruct49_0[m].int_133[3] = num26;
													text = gstruct2.gstruct58_0[n].string_0;
												}
											}
										}
										bool flag48 = text == null;
										if (!flag48)
										{
											bool flag49 = Class12.smethod_28(long_3) > 8000L;
											if (flag49)
											{
												Class70.smethod_52(gstruct, "§ang chê " + text + " nhËn xong nhiÖm vô.", 1);
												long_3 = Class12.smethod_27();
											}
											Thread.Sleep(300);
											continue;
										}
									}
									else
									{
										int m = 0;
										while (m < Form1.gstruct49_0.Length)
										{
											int num30 = 0;
											for (;;)
											{
												bool flag50 = num30 < gstruct2.gstruct58_0.Length;
												if (!flag50)
												{
													break;
												}
												bool flag51 = !Form1.gstruct49_0[m].bool_25 || !(Form1.gstruct49_0[m].string_22 == gstruct2.gstruct58_0[num30].string_0) || Form1.gstruct49_0[m].int_133[0] <= 0 || Form1.gstruct49_0[m].int_133[1] > 0;
												if (!flag51)
												{
													goto IL_BE4;
												}
												num30++;
											}
											m++;
											continue;
											IL_BE4:
											bool flag52 = Class12.smethod_28(long_3) > 8000L;
											if (flag52)
											{
												Class70.smethod_52(gstruct, "§ang chê " + gstruct2.gstruct58_0[num30].string_0 + " nhËn xong nhiÖm vô.", 1);
												long_3 = Class12.smethod_27();
											}
											Thread.Sleep(300);
											goto IL_1B1F;
										}
									}
									flag11 = true;
									Class70.smethod_52(gstruct, "TÊt c¶ ®· nhËn nhiÖm vô.", 1);
								}
								catch
								{
								}
								IL_1B1F:
								continue;
							}
							else
							{
								int num31 = Class100.struct27_0[num26].int_3;
								int[] array6 = Class100.struct27_0[num26].int_2;
								uint[] uint_ = Class100.struct27_0[num26].uint_0;
								bool flag53 = num18 == num27;
								if (flag53)
								{
									flag3 = false;
									flag4 = false;
									flag5 = false;
									flag = false;
									flag9 = false;
									num7 = 0;
									num8 = 0;
									long num32 = Class60.smethod_18(array4, uint_);
									int num33 = 90000;
									bool flag54 = num31 > 0;
									if (flag54)
									{
										num33 = num31;
									}
									bool flag55 = flag6 || num32 > (long)num33;
									if (flag55)
									{
										flag7 = false;
										flag6 = (num32 > 25600L);
										Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
										bool flag56 = num32 < 160000L;
										if (flag56)
										{
											Class14.smethod_2(gstruct, false);
											Class70.smethod_61(gstruct, uint_);
											Thread.Sleep(150);
											continue;
										}
										Class60.smethod_29(gstruct, false);
										bool flag57 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_2) > 5000L;
										if (flag57)
										{
											Class14.smethod_1(gstruct, uint_);
											long_2 = Class12.smethod_27();
										}
										continue;
									}
									else
									{
										bool flag58 = !flag7;
										if (flag58)
										{
											flag7 = true;
											num2 = 0L;
										}
										bool flag59 = Class22.smethod_30(num17 + Class53.gstruct51_43.uint_0, gstruct.int_137) <= 0U;
										if (flag59)
										{
											continue;
										}
										bool flag60 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
										if (flag60)
										{
											long num34 = Class12.smethod_28(long_5);
											bool flag61 = num34 < 300L;
											if (flag61)
											{
												continue;
											}
											bool flag62 = num34 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
											if (flag62)
											{
												Thread.Sleep(80);
												long_5 = Class12.smethod_27();
												continue;
											}
										}
										for (int num35 = 0; num35 < Class53.int_0; num35++)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num3);
											bool flag63 = array[0] == 0;
											if (flag63)
											{
												break;
											}
											Thread.Sleep(1);
										}
										int[,] array7 = Class7.smethod_5(gstruct, 0U, 1000, array4, null, false, false, false);
										bool flag64 = flag7 && Class100.int_0 > 0;
										if (flag64)
										{
											gstruct2 = Class82.smethod_5(gstruct);
											bool flag65 = gstruct2.int_0 < 2 || gstruct2.gstruct58_0 == null || gstruct2.gstruct58_0.Length < 2 || gstruct.string_22 == gstruct2.string_0;
											if (flag65)
											{
												flag8 = false;
												bool flag66 = (array7 != null && array7[0, 1] > 0) || num2 <= 0L || Class12.smethod_28(num2) > 9999999L;
												if (flag66)
												{
													num2 = Class12.smethod_27();
												}
												else
												{
													bool flag67 = Class12.smethod_28(num2) > 60000L;
													if (flag67)
													{
														flag8 = true;
														num2 = 0L;
														continue;
													}
												}
											}
										}
										bool flag68 = !gstruct.bool_22;
										if (!flag68)
										{
											bool flag69 = num6 > 0;
											if (flag69)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
											}
											num6 = 0;
											continue;
										}
										bool flag70 = Class83.smethod_12(gstruct) == 1 || Class44.smethod_7(gstruct, ref num10);
										if (flag70)
										{
											Thread.Sleep(180);
											num6 = 0;
											continue;
										}
										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array, 4, ref num3);
										int num36 = BitConverter.ToInt32(array, 0);
										int num37 = num36;
										bool flag71 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
										if (flag71)
										{
											num37 = gstruct.int_96;
										}
										bool flag72 = num37 <= 0;
										if (flag72)
										{
											num37 = 400;
										}
										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_44 * 4U, array, 1, ref num3);
										int num38 = (int)array[0];
										bool flag73 = num38 > 0 && num37 > num36 && num36 > 0;
										if (flag73)
										{
											num37 = num36;
										}
										uint[] array8 = new uint[]
										{
											Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										bool flag74 = array7 == null || array7[0, 0] < 0;
										if (flag74)
										{
											continue;
										}
										int num39 = array7[0, 0];
										int num40 = array7[0, 1];
										bool flag75 = num40 <= 0;
										if (flag75)
										{
											continue;
										}
										uint num41 = num16 + (uint)(num40 * (int)Class53.gstruct51_15.uint_0);
										uint[] uint_2 = new uint[]
										{
											Class22.smethod_30(num41 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num41 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										Class22.ReadProcessMemory(gstruct.int_137, num41 + Class53.gstruct51_45.uint_0, array, 4, ref num3);
										long num42 = (long)BitConverter.ToInt32(array, 0);
										bool flag76 = gstruct.int_119 > 0 && gstruct.int_3 != null;
										if (flag76)
										{
											int num43 = -1;
											int num44 = -1;
											long long_7 = 0L;
											while (Class83.smethod_12(gstruct) != 1 && !Class44.smethod_7(gstruct, ref num10))
											{
												int num45 = 0;
												int value = 400;
												while (num45 <= 0)
												{
													num43++;
													bool flag77 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num43 && gstruct.int_4 != null;
													if (!flag77)
													{
														goto IL_1896;
													}
													num45 = gstruct.int_3[num43, 0];
													bool flag78 = num45 > 0;
													if (flag78)
													{
														value = Class77.smethod_20(gstruct, num45, gstruct.int_3[num43, 1]);
														break;
													}
												}
												bool flag79 = Class98.smethod_31(gstruct, num40, num45) != 0;
												if (!flag79)
												{
													bool flag80 = num39 <= 0;
													if (flag80)
													{
														bool flag81 = num44 >= 0 && num44 == num43;
														if (flag81)
														{
															bool flag82 = Class12.smethod_28(long_7) > 8000L;
															if (flag82)
															{
																Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
																Class60.smethod_12(gstruct, true);
																goto IL_1B2A;
															}
														}
														else
														{
															num44 = num43;
															long_7 = Class12.smethod_27();
														}
													}
													for (int num46 = 0; num46 < Class53.int_0; num46++)
													{
														Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num3);
														bool flag83 = array[0] == 0;
														if (flag83)
														{
															break;
														}
														Thread.Sleep(1);
													}
													Class60.smethod_30(gstruct);
													Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(num45), 4, ref num3);
													Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(value), 4, ref num3);
													Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num40 + (int)array3[0]), 4, ref num3);
													Thread.Sleep(30);
													num6 = 1;
												}
											}
											Thread.Sleep(100);
											num6 = 0;
											continue;
										}
										IL_1896:
										bool flag84 = num39 <= 0;
										if (flag84)
										{
											bool flag85 = num <= 0L || num42 < num;
											if (flag85)
											{
												num = num42;
												long_6 = Class12.smethod_27();
											}
											bool flag86 = Class12.smethod_28(long_6) > 12000L;
											if (flag86)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
												Class60.smethod_12(gstruct, gstruct.int_93 > 0);
												for (int num47 = 0; num47 < 12; num47++)
												{
													array4 = new uint[]
													{
														Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													bool flag87 = Class60.smethod_18(array4, uint_) < 11500L;
													if (flag87)
													{
														break;
													}
													Class70.smethod_61(gstruct, uint_);
													Thread.Sleep(150);
												}
												num = num42;
												long_6 = Class12.smethod_27();
												continue;
											}
										}
										Class60.smethod_30(gstruct);
										bool flag88 = gstruct.bool_58 && gstruct.int_83 > 0 && Form1.int_99 == 0 && Class12.smethod_28(long_4) > gstruct.long_8;
										if (flag88)
										{
											Class36.smethod_54(gstruct, uint_2, false, 10);
											Class36.smethod_55(gstruct);
											long_4 = Class12.smethod_27();
											Thread.Sleep(100);
										}
										num40 = (int)(array2[0] * array2[1]) * num40 + (int)array3[0];
										for (int num48 = 0; num48 < Class53.int_0; num48++)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num3);
											bool flag89 = array[0] == 0;
											if (flag89)
											{
												break;
											}
											Thread.Sleep(1);
										}
										Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num3);
										Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num37), 4, ref num3);
										Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num40), 4, ref num3);
										num6 = 1;
										continue;
									}
								}
								else
								{
									flag7 = false;
									bool flag90 = !flag3;
									if (flag90)
									{
										Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
										Class70.smethod_52(gstruct, string.Concat(new string[]
										{
											"<color=yellow>§¸nh boss <",
											Class10.smethod_2(Class100.struct27_0[num26].string_0),
											"> t¹i (",
											(uint_[0] / 256U).ToString(),
											",",
											(uint_[1] / 512U).ToString(),
											") ",
											Class37.smethod_1(Class100.struct27_0[num26].int_0, false)
										}), 1);
										flag3 = true;
									}
									bool flag91 = num19 <= 0 && Class60.smethod_9(num18) != null;
									if (flag91)
									{
										bool flag92 = !flag4;
										if (flag92)
										{
											bool flag93 = Class50.smethod_2(gstruct, "®iÓm c", null, null, 0) > 0;
											if (flag93)
											{
												Class60.smethod_11(gstruct, 15000);
											}
											flag4 = true;
											continue;
										}
										bool flag94 = !flag5;
										if (flag94)
										{
											bool flag95 = Class50.smethod_4(gstruct, num27) > 0;
											if (flag95)
											{
												Class60.smethod_11(gstruct, 15000);
											}
											flag5 = true;
											continue;
										}
									}
									bool flag96 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0 && num7 < 3 && Class35.smethod_140(gstruct, num27, null, null, false);
									if (flag96)
									{
										num7++;
										continue;
									}
									int num49 = -1;
									int num50 = -1;
									for (int num51 = 0; num51 < array6.Length; num51++)
									{
										bool flag97 = array6[num51] == num18;
										if (flag97)
										{
											num49 = array6[num51];
											bool flag98 = num51 < array6.Length - 1;
											if (flag98)
											{
												num50 = array6[num51 + 1];
											}
											break;
										}
									}
									bool flag99 = num49 <= 0;
									if (flag99)
									{
										bool flag100 = num19 > 0 && num8 < 3;
										if (flag100)
										{
											num8++;
											Class60.smethod_14(gstruct, true);
										}
										else
										{
											bool flag101 = Class12.smethod_28(long_3) > 30000L;
											if (flag101)
											{
												Class70.smethod_52(gstruct, "<color=yellow>§¸nh bos S¸t thñ: Kh«ng thÓ T§P vµ THP, kh«ng t×m ®­îc ®­êng ®i", 1);
												num7 = 0;
												flag5 = false;
												long_3 = Class12.smethod_27();
											}
										}
									}
									else
									{
										bool flag102 = num49 == num27 || num50 < 0;
										if (!flag102)
										{
											GStruct26 gstruct3 = Class43.smethod_4(num49, num50);
											bool flag103 = gstruct3.uint_0 == null;
											if (flag103)
											{
												bool flag104 = Class12.smethod_28(long_3) > 30000L;
												if (flag104)
												{
													Class70.smethod_52(gstruct, "<color=yellow>§¸nh boss s¸t thñ: Auto ch­a ®Þnh nghÜa ®­êng ®i", 1);
													long_3 = Class12.smethod_27();
												}
											}
											else
											{
												int num52 = 0;
												bool flag105 = gstruct3.uint_0.GetLength(0) > 1;
												if (flag105)
												{
													num52 = Class60.smethod_20(gstruct3.uint_0, array4);
												}
												uint[] array9 = null;
												uint[] uint_3 = null;
												int num53 = 0;
												Class60.smethod_8(gstruct3.uint_0, num52, ref array9, ref uint_3, ref num53);
												bool flag106 = Class60.smethod_18(array4, array9) < 240000L;
												if (flag106)
												{
													Class60.smethod_23(gstruct, array9, num53, uint_3, gstruct3.int_1);
												}
												else
												{
													int[] array10 = Class60.smethod_9(num18);
													num19 = (int)Class22.smethod_30(num17 + Class53.gstruct51_43.uint_0, gstruct.int_137);
													bool flag107 = num19 <= 0 && array10 != null && array10[1] == 0;
													if (flag107)
													{
														uint[] array11 = Class43.smethod_10(array9, num18, "NGOAITHANH", true);
														bool flag108 = array11 != null;
														if (flag108)
														{
															long num54 = Class60.smethod_18(array9, array11);
															bool flag109 = num54 <= 400000000L;
															if (flag109)
															{
																uint[,] array12 = Class42.smethod_1(num18, array4, array11, null, false);
																bool flag110 = array12 != null;
																if (flag110)
																{
																	int num55 = Class60.smethod_20(array12, array11);
																	bool flag111 = num55 >= 0;
																	if (flag111)
																	{
																		uint[] uint_4 = new uint[]
																		{
																			array12[num55, 0],
																			array12[num55, 1]
																		};
																		long num56 = Class60.smethod_18(array4, uint_4);
																		bool flag112 = num56 > 90000L;
																		if (flag112)
																		{
																			Class14.smethod_2(gstruct, false);
																			Class60.smethod_22(gstruct, array12, array4, array11, num18, true, 6000, false);
																			continue;
																		}
																	}
																}
															}
														}
													}
													bool flag113 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_2) > 5000L;
													if (flag113)
													{
														Class14.smethod_1(gstruct, array9);
														long_2 = Class12.smethod_27();
														Thread.Sleep(300);
													}
													Class60.smethod_29(gstruct, false);
												}
											}
										}
									}
									continue;
								}
							}
							IL_3B3:
							num9 = num18;
						}
					}
					else
					{
						bool flag114 = num6 > 0;
						if (flag114)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
						}
						bool flag115 = Form1.int_121 > 0;
						if (flag115)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num3);
						}
						num6 = 0;
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003FC4 File Offset: 0x000021C4
		private static int smethod_1(int int_4)
		{
			int num = 0;
			string text = "NhiÕp|Nhiªp| TrÇn|p Thi Tr";
			GStruct49 gstruct = default(GStruct49);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = -1;
			long long_ = 0L;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			int result = 0;
			int num8 = -1;
			int num9 = 0;
			string text3;
			for (;;)
			{
				int num15;
				int num16;
				uint[] array;
				int num20;
				uint[] array2;
				for (;;)
				{
					Thread.Sleep(300);
					int num10 = Class81.smethod_3(Form1.gstruct49_0, int_4);
					bool flag8 = Class12.bool_0 || num10 < 0;
					if (flag8)
					{
						goto Block_2;
					}
					gstruct = Form1.gstruct49_0[num10];
					bool flag9 = !gstruct.bool_25 || gstruct.int_133[0] <= 0;
					if (flag9)
					{
						goto Block_4;
					}
					uint num11 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num12 = Class22.smethod_30(num11 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num13 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num14 = num13 + num12 * Class53.gstruct51_15.uint_0;
					num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					num16 = (int)Class22.smethod_30(num14 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					int num17 = (int)Class22.smethod_30(num14 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					int num18 = (int)Class22.smethod_30(num14 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num19 = Class83.smethod_39(gstruct);
					bool flag10 = num18 > 0 && num15 > 0 && num17 != 10 && num17 != 21 && num19 > 1 && Class83.smethod_12(gstruct) != 1;
					if (!flag10)
					{
						goto IL_F63;
					}
					bool flag11 = num8 != num15;
					if (flag11)
					{
						num8 = num15;
					}
					bool flag12 = num7 < 0 || num7 != num16;
					if (flag12)
					{
						goto Block_13;
					}
					bool flag13 = num16 == 0;
					if (flag13)
					{
						Class60.smethod_29(gstruct, false);
					}
					array = new uint[]
					{
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					num20 = Class100.struct27_0[gstruct.int_133[3]].int_1;
					int num21 = Class100.struct27_0[gstruct.int_133[3]].int_0;
					bool flag14 = !flag2;
					if (flag14)
					{
						flag2 = (num15 != num20 && num15 != num21);
					}
					string string_ = Class100.struct27_0[gstruct.int_133[3]].string_2;
					Class43.smethod_11(num20, "NhiÕp ThÝ TrÇn", false);
					bool flag15 = num16 > 0 || (num15 != num20 && (Class100.int_1 <= 0 || Class60.smethod_9(num15) == null));
					if (flag15)
					{
						flag4 = false;
						bool flag16 = num16 > 0;
						if (flag16)
						{
							bool flag17 = flag6;
							if (flag17)
							{
								goto Block_24;
							}
							bool flag18 = num3 < 3;
							if (flag18)
							{
								num3++;
								bool flag19 = Class60.smethod_14(gstruct, true);
								if (flag19)
								{
									break;
								}
							}
						}
						bool flag20 = num2 < 3 && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
						if (flag20)
						{
							array2 = Class43.smethod_11(num20, "NhiÕp ThÝ TrÇn", false);
							bool flag21 = Class35.smethod_140(gstruct, num20, string_, array2, false);
							if (flag21)
							{
								goto Block_29;
							}
						}
						bool flag22 = num16 > 0;
						if (flag22)
						{
							goto Block_30;
						}
						bool flag23 = Class60.smethod_9(num15) == null;
						if (flag23)
						{
							goto Block_33;
						}
						bool flag24 = Class100.int_1 <= 0;
						if (flag24)
						{
							goto Block_34;
						}
					}
					bool flag25 = flag3 || !flag2 || Class100.int_1 > 0;
					if (!flag25)
					{
						goto IL_F47;
					}
					bool flag26 = flag4;
					if (!flag26)
					{
						goto IL_EC3;
					}
					array = new uint[]
					{
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					array2 = Class43.smethod_11(num15, "NhiÕp ThÝ TrÇn", false);
					long num22 = Class60.smethod_18(array, array2);
					bool flag27 = num22 <= 350000L;
					if (!flag27)
					{
						goto IL_E6B;
					}
					Class14.smethod_2(gstruct, false);
					int i = 0;
					while (i < 15)
					{
						array = new uint[]
						{
							Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						num22 = Class60.smethod_18(array, array2);
						bool flag28 = num22 < 11500L;
						if (flag28)
						{
							break;
						}
						Class70.smethod_61(gstruct, array2);
						i++;
						Thread.Sleep(300);
					}
					for (;;)
					{
						IL_E5E:
						num10 = Class81.smethod_3(Form1.gstruct49_0, int_4);
						bool flag29 = Class12.bool_0 || num10 < 0;
						if (flag29)
						{
							goto Block_42;
						}
						gstruct = Form1.gstruct49_0[num10];
						bool flag30 = !gstruct.bool_25 || gstruct.int_133[0] <= 0;
						if (flag30)
						{
							goto Block_44;
						}
						num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
						bool flag31 = num8 <= 0 || num8 == num15 || !flag6;
						if (!flag31)
						{
							goto IL_BC8;
						}
						uint[] array3 = null;
						bool flag32 = num > 0;
						if (flag32)
						{
							string text2 = Class98.smethod_16(gstruct, num, ref array3, 30);
							bool flag33 = false;
							bool flag34 = text2 != null && text2 != string.Empty;
							if (flag34)
							{
								string[] array4 = text.Split(new char[]
								{
									'|'
								});
								string string_2 = text2.ToLower();
								for (int j = 0; j < array4.Length; j++)
								{
									bool flag35 = array4[j] != null && 0 <= Class12.smethod_1(string_2, array4[j].ToLower());
									if (flag35)
									{
										flag33 = true;
										break;
									}
								}
							}
							bool flag36 = !flag33;
							if (flag36)
							{
								num = 0;
								array3 = null;
							}
						}
						bool flag37 = num <= 0;
						if (flag37)
						{
							num = Class98.smethod_15(gstruct, text, ref array3, 3, false, -1, null);
							bool flag38 = num <= 0;
							if (flag38)
							{
								break;
							}
						}
						num4 = 0;
						i = 0;
						num3 = 0;
						num2 = 0;
						while (i < 10)
						{
							bool flag39 = num <= 0;
							if (flag39)
							{
								break;
							}
							bool flag40 = array3 == null;
							if (flag40)
							{
								break;
							}
							array = new uint[]
							{
								Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							long num23 = Class60.smethod_18(array, array3);
							bool flag41 = num23 < 11250L;
							if (flag41)
							{
								break;
							}
							Class70.smethod_61(gstruct, array3);
							Thread.Sleep(300);
							i++;
						}
						Class86.smethod_8(gstruct, -1);
						Thread.Sleep(100);
						Class36.smethod_10(gstruct, (uint)num);
						Thread.Sleep(100);
						i = 0;
						while (Class86.smethod_0(gstruct) < 0)
						{
							i++;
							bool flag42 = i <= 10;
							if (flag42)
							{
								Thread.Sleep(100);
							}
							else
							{
								Class60.smethod_12(gstruct, true);
								num5++;
								bool flag43 = num5 <= 8;
								if (!flag43)
								{
									goto IL_E4F;
								}
								bool flag44 = num5 % 3 != 0;
								if (flag44)
								{
									goto IL_E5E;
								}
								goto IL_E4A;
							}
						}
						Thread.Sleep(600);
						int num24 = Class86.smethod_0(gstruct);
						int num25 = Class86.smethod_1(gstruct, num24);
						bool flag45 = num25 > 0;
						if (!flag45)
						{
							goto IL_BBB;
						}
						string[] array5 = new string[]
						{
							"cÊp 90",
							"NhËn NhiÖm Vô S¸t",
							"NhiÖm Vô S¸t Thñ Ph"
						};
						bool flag46 = !flag;
						if (flag46)
						{
							array5 = new string[]
							{
								"hñy bá"
							};
						}
						for (int k = 0; k < array5.Length; k++)
						{
							string object_ = array5[k].ToUpper();
							for (int l = 0; l < num25; l++)
							{
								string string_3 = Class86.smethod_3(gstruct, l, num24, 128).ToUpper();
								bool flag47 = 0 <= Class12.smethod_1(string_3, object_);
								if (flag47)
								{
									int num26 = l;
									Class86.smethod_5(gstruct, num26);
									Thread.Sleep(600);
									break;
								}
							}
						}
						string string_4 = Class86.smethod_2(gstruct, -1);
						bool flag48 = flag && Class12.smethod_1(string_4, "hñy bá nhi") <= 0;
						if (flag48)
						{
							string[] array6 = Class100.struct27_0[gstruct.int_133[3]].string_1.ToLower().Split(new char[]
							{
								'|'
							});
							for (;;)
							{
								Thread.Sleep(300);
								num24 = Class86.smethod_0(gstruct);
								num25 = Class86.smethod_1(gstruct, num24);
								bool flag49 = num25 <= 0;
								if (flag49)
								{
									break;
								}
								bool flag50 = num25 == 1;
								if (flag50)
								{
									string string_5 = Class86.smethod_2(gstruct, num24);
									bool flag51 = Class12.smethod_1(string_5, "khinh k") > 0;
									if (flag51)
									{
										goto Block_70;
									}
								}
								int num26 = -1;
								int num27 = -1;
								for (int m = 0; m < num25; m++)
								{
									string string_6 = Class86.smethod_3(gstruct, m, num24, 128).ToLower();
									bool flag52 = false;
									for (int n = 0; n < array6.Length; n++)
									{
										bool flag53 = Class12.smethod_1(string_6, array6[n]) == 0;
										if (flag53)
										{
											flag52 = true;
											break;
										}
									}
									bool flag54 = !flag52;
									if (!flag54)
									{
										num26 = m;
										Class86.smethod_5(gstruct, num26);
										Thread.Sleep(600);
										break;
									}
									bool flag55 = 0 <= Class12.smethod_1(string_6, "trang k") || 0 <= Class12.smethod_1(string_6, "trang s");
									if (flag55)
									{
										num27 = m;
									}
								}
								bool flag56 = num26 < 0 && 0 <= num27;
								if (!flag56)
								{
									goto IL_B70;
								}
								Class86.smethod_5(gstruct, num27);
								Thread.Sleep(600);
							}
							Class86.smethod_8(gstruct, -1);
							num5++;
							bool flag57 = num5 > 8;
							if (flag57)
							{
								goto Block_77;
							}
							continue;
							IL_B70:
							Thread.Sleep(600);
							num24 = Class86.smethod_0(gstruct);
							num25 = Class86.smethod_1(gstruct, num24);
							text3 = Class86.smethod_2(gstruct, num24);
							bool flag58 = Class12.smethod_1(text3, "khinh k") <= 0;
							if (!flag58)
							{
								goto IL_E0D;
							}
							bool flag59 = num25 > 0;
							if (flag59)
							{
								Class86.smethod_5(gstruct, 0);
								Thread.Sleep(600);
							}
							string text4 = string.Empty;
							bool flag60 = Class86.Class89.smethod_4(gstruct);
							if (flag60)
							{
								text4 = Class86.Class89.smethod_0(gstruct);
							}
							bool flag61 = num9 <= 0 && text4 != null && text4 != string.Empty && text4.IndexOf("ng©n l­îng") > 0;
							if (flag61)
							{
								bool flag62 = gstruct.string_15 != null && gstruct.string_15 != string.Empty;
								if (flag62)
								{
									uint num28 = Class12.smethod_12(gstruct.string_15);
									bool flag63 = num28 > 0U;
									if (flag63)
									{
										Class70.smethod_117(gstruct, num28);
										Thread.Sleep(300);
									}
								}
								uint num29 = Class36.smethod_41(gstruct, true);
								bool flag64 = num29 > 0U;
								if (flag64)
								{
									bool flag65 = num29 > 2000000U;
									if (flag65)
									{
										num29 = 2000000U;
									}
									Class70.smethod_37(gstruct, num29);
								}
								num9 = 1;
								num6 = 0;
							}
							flag6 = true;
							bool flag66 = num9 == 1 || (num6 < 2 && Class12.smethod_1(text3, "ng­¬i th¾ng") < 0);
							if (!flag66)
							{
								goto IL_D51;
							}
							bool flag67 = num9 == 1;
							if (flag67)
							{
								num9 = 2;
							}
							num6++;
						}
						else
						{
							Class86.smethod_5(gstruct, 0);
							Thread.Sleep(300);
							flag = true;
							num6 = 0;
						}
					}
					Class60.smethod_12(gstruct, true);
					num4++;
					bool flag68 = num4 > 10;
					if (flag68)
					{
						goto Block_56;
					}
					IL_E4A:;
				}
				continue;
				Block_29:
				num3 = 0;
				num2++;
				continue;
				Block_30:
				uint[] array7 = Class43.smethod_10(array, num15, "Xa phu", true);
				bool flag69 = array7 != null;
				if (flag69)
				{
					bool flag70 = Class12.smethod_28(long_) > 4000L;
					if (flag70)
					{
						Class14.smethod_1(gstruct, array7);
						long_ = Class12.smethod_27();
					}
				}
				else
				{
					num3 = 0;
					num2 = 0;
				}
				continue;
				Block_34:
				Class50.smethod_5(gstruct, num20);
				continue;
				IL_E6B:
				uint[,] array8 = Class25.smethod_0(num15, array, array2);
				bool flag71 = (array8 == null || Class60.smethod_22(gstruct, array8, array, array2, num15, true, 10000, false) <= 0) && Class12.smethod_28(long_) > 4000L;
				if (flag71)
				{
					Class14.smethod_1(gstruct, array2);
					long_ = Class12.smethod_27();
				}
				continue;
				IL_EC3:
				bool flag72 = Class40.smethod_0(gstruct) == 0;
				if (flag72)
				{
					Thread.Sleep(300);
				}
				else
				{
					int num30 = Class34.smethod_3(gstruct, Form1.int_98 <= 0);
					bool flag73 = num30 != 0 && (num30 >= 0 || flag7);
					if (flag73)
					{
						flag4 = true;
						flag7 = false;
						bool flag74 = gstruct.int_65 > 0;
						if (flag74)
						{
							Class60.smethod_3(gstruct, ref flag5);
						}
					}
					else
					{
						Thread.Sleep(300);
						flag7 = (num30 < 0);
					}
				}
				continue;
				IL_F63:
				Thread.Sleep(100);
				continue;
				IL_F47:
				bool flag75 = Class91.smethod_0(gstruct, true, null) > 0;
				if (flag75)
				{
					flag3 = true;
					flag2 = false;
					continue;
				}
				continue;
				Block_13:
				for (int num31 = 0; num31 < 8; num31++)
				{
					bool flag76 = num16 == num7;
					if (flag76)
					{
						break;
					}
					bool flag77 = num7 <= 0;
					if (flag77)
					{
						break;
					}
					uint num14;
					num16 = (int)Class22.smethod_30(num14 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					Thread.Sleep(100);
				}
				num7 = num16;
			}
			Block_2:
			Block_4:
			goto IL_F74;
			Block_24:
			result = 1;
			goto IL_F74;
			Block_33:
			Class70.smethod_52(gstruct, "<color=yellow>Khong the ve thanh, that bai !", 1);
			Block_42:
			Block_44:
			goto IL_E66;
			Block_56:
			Class70.smethod_52(gstruct, "<color=yellow>Loi (1): Bi LAG, khong the nhan nhiem vu !", 1);
			goto IL_E66;
			Block_70:
			Class86.smethod_5(gstruct, 0);
			return 2;
			Block_77:
			goto IL_E66;
			IL_BBB:
			Class86.smethod_8(gstruct, -1);
			goto IL_E66;
			IL_BC8:
			result = 1;
			goto IL_E66;
			IL_D51:
			int num32 = Class12.smethod_1(text3, ":");
			int num33 = Class12.smethod_1(text3, ")");
			string str = (num32 <= 0 || num33 <= num32) ? ("§· nhËn giÕt <" + Class10.smethod_2(Class100.struct27_0[gstruct.int_133[3]].string_0) + ">") : ("§· nhËn giÕt " + text3.Substring(num32 + 2, num33 - num32 - 1));
			bool flag78 = Class82.smethod_5(gstruct).int_0 <= 0;
			if (flag78)
			{
				Class70.smethod_52(gstruct, "<color=yellow>" + str, 1);
			}
			else
			{
				Class70.smethod_57(gstruct, "Chat('CH_TEAM', '" + str + "')");
			}
			result = 1;
			goto IL_E66;
			IL_E0D:
			Class86.smethod_5(gstruct, 0);
			return 2;
			IL_E4F:
			Class70.smethod_52(gstruct, "<color=yellow>Loi (2): Bi LAG, khong the nhan nhiem vu !", 1);
			IL_E66:
			IL_F74:
			bool flag79 = num9 > 0 && gstruct.int_65 > 0;
			if (flag79)
			{
				Class60.smethod_3(gstruct, ref flag5);
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00004F70 File Offset: 0x00003170
		public static void smethod_2()
		{
			int int_ = Class100.int_3;
			Class100.int_3 = 0;
			try
			{
				Class100.smethod_3(int_);
			}
			catch
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004FAC File Offset: 0x000031AC
		public static void smethod_3(int int_4)
		{
			int num = 0;
			string text = "NhiÕp|Nhiªp| TrÇn|p Thi Tr";
			GStruct49 gstruct = default(GStruct49);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = -1;
			long long_ = 0L;
			int num6 = 0;
			string text2 = "S¸t Thñ lÖnh";
			byte[] array = new byte[text2.Length + 1];
			uint num7 = 12U;
			for (;;)
			{
				IL_B24:
				Thread.Sleep(300);
				int num8 = Class81.smethod_3(Form1.gstruct49_0, int_4);
				bool flag = Class12.bool_0 || num8 < 0 || Form1.int_20 != 0 || !Form1.gstruct49_0[num8].bool_25;
				if (flag)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num8];
				bool flag2 = Class100.smethod_4(gstruct, -1) < 5;
				if (flag2)
				{
					break;
				}
				bool flag3 = Class45.smethod_21(gstruct) >= 0;
				if (!flag3)
				{
					goto IL_AF1;
				}
				uint num9 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num10 = Class22.smethod_30(num9 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num11 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num12 = num11 + num10 * Class53.gstruct51_15.uint_0;
				int num13 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
				int num14 = (int)Class22.smethod_30(num12 + Class53.gstruct51_43.uint_0, gstruct.int_137);
				int num15 = (int)Class22.smethod_30(num12 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num16 = (int)Class22.smethod_30(num12 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num17 = Class83.smethod_39(gstruct);
				bool flag4 = num16 <= 0 || num13 <= 0 || num15 == 10 || num15 == 21 || num17 <= 1;
				if (!flag4)
				{
					bool flag5 = num5 >= 0 && num5 == num14;
					if (flag5)
					{
						bool flag6 = num14 == 0;
						if (flag6)
						{
							Class60.smethod_29(gstruct, false);
						}
						uint[] array2 = new uint[]
						{
							Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						int[] array3 = Class60.smethod_9(num13);
						bool flag7 = array3 == null || array3[1] != 0 || num14 > 0;
						if (flag7)
						{
							bool flag8 = num2 >= 3 || !Class35.smethod_140(gstruct, 80, "t©y", null, false);
							if (flag8)
							{
								bool flag9 = num14 <= 0 || num3 >= 3 || !Class60.smethod_14(gstruct, true);
								if (flag9)
								{
									bool flag10 = array3 == null;
									if (!flag10)
									{
										bool flag11 = num14 <= 0;
										if (flag11)
										{
											Class50.smethod_7(gstruct);
										}
										else
										{
											uint[] array4 = Class43.smethod_10(array2, num13, "Xa phu", true);
											bool flag12 = array4 != null && Class12.smethod_28(long_) > 4000L;
											if (flag12)
											{
												Class14.smethod_1(gstruct, array4);
												long_ = Class12.smethod_27();
											}
										}
									}
								}
								else
								{
									num3++;
								}
							}
							else
							{
								num2++;
							}
						}
						else
						{
							uint[] array5 = Class43.smethod_11(num13, "NhiÕp ThÝ TrÇn", false);
							long num18 = Class60.smethod_18(array2, array5);
							bool flag13 = num18 > 350000L;
							if (flag13)
							{
								uint[,] array6 = Class25.smethod_0(num13, array2, array5);
								bool flag14 = (array6 == null || Class60.smethod_22(gstruct, array6, array2, array5, num13, true, 10000, false) <= 0) && Class12.smethod_28(long_) > 4000L;
								if (flag14)
								{
									Class14.smethod_1(gstruct, array5);
									long_ = Class12.smethod_27();
								}
							}
							else
							{
								Class14.smethod_2(gstruct, false);
								int i = 0;
								while (i < 15)
								{
									array2 = new uint[]
									{
										Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
										Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
									};
									num18 = Class60.smethod_18(array2, array5);
									bool flag15 = num18 < 11500L;
									if (flag15)
									{
										break;
									}
									Class70.smethod_61(gstruct, array5);
									i++;
									Thread.Sleep(300);
								}
								uint[] array7 = null;
								bool flag16 = num > 0;
								if (flag16)
								{
									string text3 = Class98.smethod_16(gstruct, num, ref array7, 30);
									bool flag17 = false;
									bool flag18 = text3 != null && text3 != string.Empty;
									if (flag18)
									{
										string[] array8 = text.Split(new char[]
										{
											'|'
										});
										string string_ = text3.ToLower();
										for (int j = 0; j < array8.Length; j++)
										{
											bool flag19 = array8[j] != null && 0 <= Class12.smethod_1(string_, array8[j].ToLower());
											if (flag19)
											{
												flag17 = true;
												break;
											}
										}
									}
									bool flag20 = !flag17;
									if (flag20)
									{
										num = 0;
										array7 = null;
									}
								}
								bool flag21 = num <= 0;
								if (flag21)
								{
									num = Class98.smethod_15(gstruct, text, ref array7, 3, false, -1, null);
									bool flag22 = num <= 0;
									if (flag22)
									{
										Class60.smethod_12(gstruct, true);
										num4++;
										bool flag23 = num4 <= 10;
										if (flag23)
										{
											continue;
										}
										goto IL_55F;
									}
								}
								Class86.smethod_8(gstruct, -1);
								Thread.Sleep(100);
								Class36.smethod_10(gstruct, (uint)num);
								Thread.Sleep(100);
								i = 0;
								while (Class86.smethod_0(gstruct) < 0)
								{
									i++;
									bool flag24 = i <= 10;
									if (!flag24)
									{
										Class60.smethod_12(gstruct, true);
										goto IL_B24;
									}
									Thread.Sleep(100);
								}
								Thread.Sleep(600);
								int num19 = Class86.smethod_0(gstruct);
								int num20 = Class86.smethod_1(gstruct, num19);
								bool flag25 = num20 > 0;
								if (flag25)
								{
									bool flag26 = false;
									for (int k = 0; k < num20; k++)
									{
										string string_2 = Class86.smethod_3(gstruct, k, num19, 128).ToLower();
										bool flag27 = 0 <= Class12.smethod_1(string_2, "p th");
										if (flag27)
										{
											Class86.smethod_5(gstruct, k);
											Thread.Sleep(600);
											i = 0;
											while (i < 10 && Class86.smethod_0(gstruct) >= 0)
											{
												i++;
												Thread.Sleep(100);
											}
											flag26 = Class45.smethod_8(gstruct);
											Class86.smethod_8(gstruct, -1);
											break;
										}
									}
									bool flag28 = flag26;
									if (flag28)
									{
										int num21 = 0;
										byte[] array9 = new byte[4];
										uint num22 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_97.uint_0;
										uint num23 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
										int num24 = Class79.smethod_4(gstruct);
										int num25 = 0;
										int num26 = 0;
										int num27 = 0;
										uint num28 = 1U;
										while ((ulong)num28 < (ulong)((long)Class53.int_1))
										{
											bool flag29 = num26 > 3;
											if (flag29)
											{
												num27 = Class100.smethod_4(gstruct, (int)num7);
											}
											bool flag30 = num24 <= num25 || num27 > 4;
											if (flag30)
											{
												break;
											}
											uint num29 = num23 + num28 * Class53.gstruct51_106.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_106.uint_0 - 4U, array9, 4, ref num21);
											bool flag31 = BitConverter.ToInt32(array9, 0) != 0;
											if (!flag31)
											{
												uint num30 = Class79.smethod_1(gstruct, num28);
												bool flag32 = num30 <= 0U;
												if (!flag32)
												{
													num25++;
													uint uint_ = num29 + Class53.gstruct51_107.uint_0;
													Class22.ReadProcessMemory(gstruct.int_137, uint_, array9, 1, ref num21);
													bool flag33 = (array9[0] != 83 && array9[0] != 115) || Class22.smethod_30(num29 + Class53.gstruct51_108.uint_0, gstruct.int_137) <= 0U;
													if (!flag33)
													{
														Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_114.uint_0, array9, 4, ref num21);
														bool flag34 = BitConverter.ToInt32(array9, 0) != 90;
														if (!flag34)
														{
															uint num31 = Class22.smethod_30(num22 + num30 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct.int_137);
															bool flag35 = num31 != 23U && num31 != 3U;
															if (!flag35)
															{
																Class22.ReadProcessMemory(gstruct.int_137, uint_, array, array.Length, ref num21);
																string string_3 = Class10.smethod_3(array).ToLower();
																bool flag36 = Class12.smethod_1(string_3, text2.ToLower()) != 0;
																if (!flag36)
																{
																	uint num32 = num22 + num30 * 20U;
																	uint num33 = Class22.smethod_30(num32 + Class53.gstruct51_100.uint_0 - 4U, gstruct.int_137);
																	uint num34 = Class22.smethod_30(num32 + Class53.gstruct51_100.uint_0, gstruct.int_137);
																	uint uint_2 = Class22.smethod_30(num29 + Class53.gstruct51_111.uint_0, gstruct.int_137);
																	uint uint_3 = Class22.smethod_30(num29 + Class53.gstruct51_112.uint_0, gstruct.int_137);
																	uint[] array10 = Class79.smethod_26(gstruct, num7, uint_2, uint_3);
																	bool flag37 = array10 == null;
																	if (flag37)
																	{
																		goto Block_58;
																	}
																	Class70.smethod_46(gstruct, num33, num34, num31, num33, num34, num31);
																	i = 0;
																	while (Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) <= 0U)
																	{
																		i++;
																		bool flag38 = i <= 10;
																		if (!flag38)
																		{
																			Class45.smethod_13(gstruct, false);
																			goto IL_B24;
																		}
																		Thread.Sleep(100);
																	}
																	Class70.smethod_46(gstruct, array10[0], array10[1], num7, array10[0], array10[1], num7);
																	i = 0;
																	while (Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) > 0U)
																	{
																		i++;
																		bool flag39 = i <= 10;
																		if (!flag39)
																		{
																			Class45.smethod_13(gstruct, false);
																			goto IL_B24;
																		}
																		Thread.Sleep(100);
																	}
																	num26++;
																}
															}
														}
													}
												}
											}
											num28 += 1U;
										}
										bool flag40 = num27 < 5;
										if (flag40)
										{
											num27 = Class100.smethod_4(gstruct, (int)num7);
										}
										bool flag41 = num27 <= 4;
										if (flag41)
										{
											break;
										}
										Class45.smethod_13(gstruct, true);
										Thread.Sleep(300);
										Class86.smethod_8(gstruct, -1);
									}
									else
									{
										bool flag42 = num6 > 3;
										if (flag42)
										{
											break;
										}
									}
								}
								else
								{
									Class60.smethod_12(gstruct, true);
								}
							}
						}
					}
					else
					{
						for (int l = 0; l < 8; l++)
						{
							bool flag43 = num14 == num5;
							if (flag43)
							{
								break;
							}
							bool flag44 = num5 <= 0;
							if (flag44)
							{
								break;
							}
							num14 = (int)Class22.smethod_30(num12 + Class53.gstruct51_43.uint_0, gstruct.int_137);
							Thread.Sleep(100);
						}
						num5 = num14;
					}
				}
			}
			goto IL_B2C;
			IL_55F:
			Class70.smethod_52(gstruct, "<color=yellow>Loi (1): Bi LAG, khong the nhan nhiem vu !", 1);
			Block_58:
			goto IL_B2C;
			IL_AF1:
			Class70.smethod_52(gstruct, "<color=yellow>Kh«ng thÓ ®Æt vËt phÈm xuèng.", 1);
			IL_B2C:
			bool flag45 = Class45.smethod_8(gstruct);
			if (flag45)
			{
				Class45.smethod_13(gstruct, false);
			}
			Class86.smethod_8(gstruct, -1);
			Class70.smethod_52(gstruct, "<color=green>KÕt thóc ghÐp s¸t thñ gi¶n.", 1);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00005B10 File Offset: 0x00003D10
		public static int smethod_4(GStruct49 gstruct49_0, int int_4 = -1)
		{
			string text = "S¸t Thñ lÖnh".ToLower();
			int num = 0;
			byte[] array = new byte[text.Length + 1];
			byte[] array2 = new byte[4];
			int num2 = Class79.smethod_4(gstruct49_0);
			int num3 = 0;
			uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
			uint num5 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			int num6 = 0;
			uint num7 = 1U;
			while ((ulong)num7 < (ulong)((long)Class53.int_1) && num2 > num3)
			{
				uint num8 = num5 + num7 * Class53.gstruct51_106.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
				bool flag = BitConverter.ToInt32(array2, 0) != 0;
				if (!flag)
				{
					uint num9 = Class79.smethod_1(gstruct49_0, num7);
					bool flag2 = num9 <= 0U;
					if (!flag2)
					{
						num3++;
						uint uint_ = num8 + Class53.gstruct51_107.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 1, ref num);
						bool flag3 = (array2[0] != 83 && array2[0] != 115) || Class22.smethod_30(num8 + Class53.gstruct51_108.uint_0, gstruct49_0.int_137) <= 0U;
						if (!flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_114.uint_0, array2, 4, ref num);
							bool flag4 = BitConverter.ToInt32(array2, 0) != 90;
							if (!flag4)
							{
								uint num10 = Class22.smethod_30(num4 + num9 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
								bool flag5 = int_4 <= 0;
								if (flag5)
								{
									bool flag6 = num10 != 23U && num10 != 3U;
									if (flag6)
									{
										goto IL_20A;
									}
								}
								else
								{
									bool flag7 = (long)int_4 != (long)((ulong)num10);
									if (flag7)
									{
										goto IL_20A;
									}
								}
								Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
								string string_ = Class10.smethod_3(array).ToLower();
								bool flag8 = Class12.smethod_1(string_, text.ToLower()) == 0;
								if (flag8)
								{
									num6++;
								}
							}
						}
					}
				}
				IL_20A:
				num7 += 1U;
			}
			return num6;
		}

		// Token: 0x04000005 RID: 5
		public static int int_0 = Class62.smethod_3("BosSatthuTuHuyNhiemvu", 0, "1");

		// Token: 0x04000006 RID: 6
		public static int int_1 = Class62.smethod_3("BosSatthuKhongLuuRuong", 0, "0");

		// Token: 0x04000007 RID: 7
		public static int int_2 = Class62.smethod_3("TuGhepSTG", 0, "1");

		// Token: 0x04000008 RID: 8
		public static Class100.Struct27[] struct27_0 = new Class100.Struct27[]
		{
			new Class100.Struct27
			{
				string_1 = "Gi¶|Cæ Giíi",
				string_0 = "1. Giả Giới Nhân",
				int_0 = 93,
				int_1 = 80,
				uint_0 = new uint[]
				{
					52715U,
					104877U
				},
				string_2 = "t©y",
				int_2 = new int[]
				{
					80,
					92,
					93
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "Chu",
				string_0 = "2. Chu Sở Bá",
				int_0 = 93,
				int_1 = 80,
				uint_0 = new uint[]
				{
					55437U,
					102868U
				},
				string_2 = "t©y",
				int_2 = new int[]
				{
					80,
					92,
					93
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Trang",
				string_0 = "3. Trang Minh Trung",
				int_0 = 93,
				int_1 = 80,
				uint_0 = new uint[]
				{
					51491U,
					100875U
				},
				string_2 = "t©y",
				int_2 = new int[]
				{
					92,
					93
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "TrÞnh",
				string_0 = "4. Trịnh Cửu Nhật",
				int_0 = 93,
				int_1 = 80,
				uint_0 = new uint[]
				{
					52796U,
					97834U
				},
				string_2 = "t©y",
				int_2 = new int[]
				{
					80,
					92,
					93
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "NhËm",
				string_0 = "1. Nhậm Thương Khung",
				int_0 = 340,
				int_1 = 11,
				uint_0 = new uint[]
				{
					61824U,
					88288U
				},
				string_2 = "b¾c",
				int_2 = new int[]
				{
					121,
					340
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "§o¹n",
				string_0 = "2. Đoạn Lăng Nguyệt",
				int_0 = 340,
				int_1 = 11,
				uint_0 = new uint[]
				{
					55163U,
					88546U
				},
				string_2 = "b¾c",
				int_2 = new int[]
				{
					121,
					340
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "T¶ ",
				string_0 = "3. Tả Dật Minh",
				int_0 = 340,
				int_1 = 11,
				uint_0 = new uint[]
				{
					40831U,
					87887U
				},
				string_2 = "b¾c",
				int_2 = new int[]
				{
					121,
					340
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "Trö",
				string_0 = "4. Trử Thiên Mẫn",
				int_0 = 340,
				int_1 = 11,
				uint_0 = new uint[]
				{
					39012U,
					87703U
				},
				string_2 = "b¾c",
				int_2 = new int[]
				{
					121,
					340
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "VÖ ",
				string_0 = "1. Vệ Biên Thành",
				int_0 = 75,
				int_1 = 1,
				uint_0 = new uint[]
				{
					56098U,
					99813U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					53,
					74,
					76,
					75
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Gia",
				string_0 = "2. Gia Các Kinh Hồng",
				int_0 = 75,
				int_1 = 1,
				uint_0 = new uint[]
				{
					52614U,
					101114U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					53,
					74,
					76,
					75
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "T¨ng",
				string_0 = "3. Tăng Chỉ Oán",
				int_0 = 75,
				int_1 = 1,
				uint_0 = new uint[]
				{
					54681U,
					101997U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					53,
					74,
					76,
					75
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Cè ",
				string_0 = "4. Cố Thủ Đằng",
				int_0 = 75,
				int_1 = 1,
				uint_0 = new uint[]
				{
					58573U,
					102167U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					53,
					74,
					76,
					75
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Hµ ",
				string_0 = "1. Hà Sinh Vong",
				int_0 = 225,
				int_1 = 176,
				uint_0 = new uint[]
				{
					45570U,
					99521U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					121,
					131,
					136,
					224,
					225
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Vò ",
				string_0 = "2. Vũ Nhất Thế",
				int_0 = 225,
				int_1 = 176,
				uint_0 = new uint[]
				{
					40353U,
					103922U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					121,
					131,
					136,
					224,
					225
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "D­¬ng",
				string_0 = "3. Dương Phong Dật",
				int_0 = 225,
				int_1 = 176,
				uint_0 = new uint[]
				{
					46454U,
					107993U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					121,
					131,
					136,
					224,
					225
				},
				int_3 = 90000
			},
			new Class100.Struct27
			{
				string_1 = "Cam",
				string_0 = "4. Cam Chính Cô",
				int_0 = 225,
				int_1 = 176,
				uint_0 = new uint[]
				{
					50786U,
					106322U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					121,
					131,
					136,
					224,
					225
				},
				int_3 = 160000
			},
			new Class100.Struct27
			{
				string_1 = "V¹n",
				string_0 = "1. Vạn Hồ Tinh",
				int_0 = 321,
				int_1 = 1,
				uint_0 = new uint[]
				{
					35616U,
					82208U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					37,
					319,
					320,
					321
				},
				int_3 = 640000
			},
			new Class100.Struct27
			{
				string_1 = "Bµo",
				string_0 = "2. Bào Triệt Sơn",
				int_0 = 321,
				int_1 = 1,
				uint_0 = new uint[]
				{
					41206U,
					83718U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					37,
					319,
					320,
					321
				},
				int_3 = 640000
			},
			new Class100.Struct27
			{
				string_1 = "Liªn",
				string_0 = "3. Liên Hình Thái",
				int_0 = 321,
				int_1 = 1,
				uint_0 = new uint[]
				{
					47565U,
					87988U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					37,
					319,
					320,
					321
				},
				int_3 = 640000
			},
			new Class100.Struct27
			{
				string_1 = "Phan",
				string_0 = "4. Phan Ngạt Nhạn",
				int_0 = 321,
				int_1 = 1,
				uint_0 = new uint[]
				{
					40093U,
					95276U
				},
				string_2 = "nam",
				int_2 = new int[]
				{
					37,
					319,
					320,
					321
				},
				int_3 = 640000
			}
		};

		// Token: 0x04000009 RID: 9
		public static int int_3 = 0;

		// Token: 0x020000E5 RID: 229
		public struct Struct27
		{
			// Token: 0x04001206 RID: 4614
			public string string_0;

			// Token: 0x04001207 RID: 4615
			public string string_1;

			// Token: 0x04001208 RID: 4616
			public int int_0;

			// Token: 0x04001209 RID: 4617
			public int int_1;

			// Token: 0x0400120A RID: 4618
			public uint[] uint_0;

			// Token: 0x0400120B RID: 4619
			public string string_2;

			// Token: 0x0400120C RID: 4620
			public int[] int_2;

			// Token: 0x0400120D RID: 4621
			public int int_3;
		}
	}
}
