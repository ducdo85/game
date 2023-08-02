using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200003D RID: 61
	internal class Class63
	{
		// Token: 0x06000381 RID: 897 RVA: 0x000A6750 File Offset: 0x000A4950
		public static void smethod_0(int int_0)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = -1;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[4];
			int[] array2 = new int[5];
			GStruct49 gstruct = default(GStruct49);
			long long_ = 0L;
			long long_2 = 0L;
			int[] array3 = new int[10];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = 4;
			}
			for (;;)
			{
				uint num13;
				int num16;
				int num17;
				for (;;)
				{
					IL_70:
					Thread.Sleep(100);
					int num8 = Class81.smethod_3(Form1.gstruct49_0, int_0);
					bool flag = Class12.bool_0 || num8 < 0 || Form1.int_20 != 3;
					if (flag)
					{
						return;
					}
					gstruct = Form1.gstruct49_0[num8];
					bool flag2 = !gstruct.bool_25 || gstruct.int_20[0] > 0 || gstruct.int_133[0] > 0 || gstruct.bool_54 || gstruct.int_25 > 0 || gstruct.bool_55;
					if (flag2)
					{
						return;
					}
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_42 * 4U, array, 1, ref num);
					bool flag3 = array[0] > 0 || gstruct.bool_15 || Class70.smethod_3(gstruct, Class70.uint_48, 4) > 0;
					if (!flag3)
					{
						bool flag4 = gstruct.gstruct47_0.int_0 > 0 && !gstruct.bool_45 && Class99.int_0 <= 0;
						if (flag4)
						{
							Class99.int_0 = int_0;
							new Thread(new ThreadStart(Class99.smethod_3)).Start();
							Thread.Sleep(300);
						}
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref array3[1]);
						uint num9 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_13.uint_0, array, 4, ref array3[2]);
						uint num10 = BitConverter.ToUInt32(array, 0);
						uint num11 = num10 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref array3[3]);
						uint num12 = BitConverter.ToUInt32(array, 0);
						num13 = num12 + num11;
						Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_55.uint_0, array, 4, ref array3[4]);
						int num14 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_50.uint_0, array, 4, ref array3[5]);
						int num15 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref array3[6]);
						num16 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_43.uint_0, array, 4, ref array3[7]);
						num17 = BitConverter.ToInt32(array, 0);
						int num18 = Class83.smethod_12(gstruct);
						bool flag5 = gstruct.int_136 != Class76.gstruct49_0.int_136 || (num18 != 1 && num18 != 2);
						if (!flag5)
						{
							goto IL_1C49;
						}
						bool flag6 = num3 <= 0;
						if (flag6)
						{
							array2[0] = 0;
							array2[1] = 0;
							array2[2] = 0;
							array2[3] = 0;
							array2[4] = 0;
						}
						num3 = 0;
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						int num19 = Class83.smethod_39(gstruct);
						bool flag7 = num15 == 0 || num14 == 0 || num16 == 0 || num19 <= 1 || num14 == 10 || num14 == 21 || array4[0] == 0U || array4[1] == 0U;
						if (flag7)
						{
							goto Block_28;
						}
						int num20 = 7;
						int num21 = 0;
						for (;;)
						{
							bool flag8 = num21 <= num20;
							if (!flag8)
							{
								break;
							}
							bool flag9 = array3[num21] == 0;
							if (flag9)
							{
								goto Block_30;
							}
							num21++;
						}
						bool flag10 = num4 == num16;
						if (!flag10)
						{
							goto IL_81E;
						}
						bool flag11 = num5 != num17;
						if (flag11)
						{
							int num22 = 0;
							while (num17 == 0 && num22 < 30 && num17 != num5)
							{
								Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
								bool flag12 = num == 4;
								if (flag12)
								{
									num9 = BitConverter.ToUInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_13.uint_0, array, 4, ref num);
									num10 = BitConverter.ToUInt32(array, 0);
									num11 = num10 * Class53.gstruct51_15.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
									bool flag13 = num == 4;
									if (flag13)
									{
										num12 = BitConverter.ToUInt32(array, 0);
										num13 = num12 + num11;
										Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_43.uint_0, array, 4, ref num);
										num17 = BitConverter.ToInt32(array, 0);
										Thread.Sleep(10);
										num22++;
										continue;
									}
								}
								goto IL_70;
							}
							goto Block_37;
						}
						goto IL_57D;
					}
				}
				continue;
				Block_28:
				Thread.Sleep(60);
				continue;
				IL_1C49:
				bool flag14 = num2 > 0;
				if (flag14)
				{
					Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
				}
				bool flag15 = Form1.int_121 > 0;
				if (flag15)
				{
					Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num);
				}
				num2 = 0;
				num3 = 0;
				continue;
				IL_57D:
				bool flag16 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
				if (flag16)
				{
					long num23 = Class12.smethod_28(long_);
					bool flag17 = num23 < 300L;
					if (flag17)
					{
						continue;
					}
					bool flag18 = num23 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
					if (flag18)
					{
						Thread.Sleep(80);
						long_ = Class12.smethod_27();
						continue;
					}
				}
				for (int j = 0; j < Class53.int_0; j++)
				{
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num);
					bool flag19 = array[0] == 0;
					if (flag19)
					{
						break;
					}
					Thread.Sleep(1);
				}
				uint[] array5 = new uint[2];
				int num24 = 0;
				int int_ = 600;
				bool flag20 = gstruct.int_98 > 0;
				if (flag20)
				{
					int_ = gstruct.int_99;
				}
				int num25 = gstruct.int_97;
				bool flag21 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
				if (flag21)
				{
					num25 = gstruct.int_96;
				}
				bool flag22 = num25 <= 0;
				if (flag22)
				{
					num25 = 500;
				}
				bool flag23 = (463 < num16 && num16 < 472) || (479 < num16 && num16 < 496);
				bool flag24 = !gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0);
				bool flag25 = FormDame.int_6 <= 0 || gstruct.int_126 != 0;
				if (flag25)
				{
					goto IL_C28;
				}
				bool flag26 = flag24 || FormDame.int_10 > 0;
				if (flag26)
				{
					int num26 = 0;
					bool flag27 = FormDame.int_9 == 0;
					if (!flag27)
					{
						bool flag28 = Class44.gstruct33_0.int_8 == 1;
						bool flag29 = FormDame.int_9 == 1;
						if (flag29)
						{
							bool flag30 = flag28;
							if (flag30)
							{
								goto IL_9DD;
							}
							bool flag31 = FormDame.int_11 > 0;
							if (!flag31)
							{
								bool flag32 = num2 > 0;
								if (flag32)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
								}
								num2 = 0;
								goto IL_818;
							}
						}
						else
						{
							bool flag33 = FormDame.int_9 != 2 || flag28;
							if (!flag33)
							{
								bool flag34 = num2 > 0;
								if (flag34)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
								}
								num2 = 0;
								goto IL_818;
							}
						}
						goto IL_C28;
						IL_818:
						goto IL_819;
					}
					IL_9DD:
					Class60.smethod_30(gstruct);
					bool flag35 = gstruct.int_127[0] != 2;
					if (flag35)
					{
						bool flag36 = gstruct.int_127[0] > 0;
						if (flag36)
						{
							bool flag37 = gstruct.int_127[1] > 0 && gstruct.int_127[2] > 0;
							bool flag38 = gstruct.int_127[3] > 0 && gstruct.int_127[4] > 0;
							bool flag39 = flag37 && !flag38;
							if (flag39)
							{
								num26 = gstruct.int_127[2];
							}
							else
							{
								bool flag40 = !flag38 || flag37;
								if (flag40)
								{
									bool flag41 = flag37 && flag38;
									if (flag41)
									{
										num26 = ((0 <= num6 && num6 <= 25) ? gstruct.int_127[2] : gstruct.int_127[4]);
										bool flag42 = num6 > 35;
										if (flag42)
										{
											num6 = 0;
										}
										num6++;
									}
								}
								else
								{
									num26 = gstruct.int_127[4];
								}
							}
						}
						bool flag43 = num26 <= 0;
						if (flag43)
						{
							num26 = Class77.smethod_13(gstruct);
						}
						Class77.smethod_9(gstruct, null);
						Class77.smethod_5(gstruct, num26, 6, 1);
						for (int k = 0; k < 3; k++)
						{
							Class22.smethod_76(gstruct.uint_4, 117);
							bool flag44 = k < 2;
							if (flag44)
							{
								Thread.Sleep(60);
							}
						}
					}
					else
					{
						Class60.smethod_0(gstruct.uint_4, gstruct.int_129, FormDame.int_12);
					}
				}
				IL_819:
				IL_B55:
				bool flag45 = !gstruct.bool_58 || gstruct.int_83 <= 0;
				if (flag45)
				{
					continue;
				}
				bool flag46 = Form1.int_99 != 0;
				if (flag46)
				{
					bool flag47 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
					if (flag47)
					{
						Class36.smethod_54(gstruct, null, true, 10);
						bool flag48 = Class12.smethod_28(long_2) > gstruct.long_8;
						if (flag48)
						{
							Class36.smethod_55(gstruct);
							long_2 = Class12.smethod_27();
						}
					}
				}
				else
				{
					bool flag49 = num24 > 0 && Class12.smethod_28(long_2) > gstruct.long_8;
					if (flag49)
					{
						Class36.smethod_54(gstruct, array5, false, 10);
						Class36.smethod_55(gstruct);
						long_2 = Class12.smethod_27();
					}
				}
				continue;
				IL_C28:
				bool flag50 = flag24;
				if (flag50)
				{
					bool flag51 = Class44.smethod_7(gstruct, ref num7) || Class83.smethod_12(gstruct) == 1;
					if (flag51)
					{
						Thread.Sleep(100);
						num2 = 0;
					}
					else
					{
						num16 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag52 = gstruct.int_119 <= 0 || gstruct.int_3 == null;
						if (flag52)
						{
							int[,] array6 = Class7.smethod_5(gstruct, 0U, int_, array4, Class7.int_0, false, false, false);
							bool flag53 = array6 == null;
							if (!flag53)
							{
								bool flag54 = array6[0, 0] == -100;
								if (flag54)
								{
									continue;
								}
								int num27 = 0;
								for (;;)
								{
									bool flag55 = array6[num27, 1] > 0;
									if (!flag55)
									{
										goto IL_120E;
									}
									array5 = new uint[]
									{
										(uint)array6[num27, 4],
										(uint)array6[num27, 5]
									};
									bool flag56 = Class60.smethod_18(array4, array5) > (long)(num25 * num25) && gstruct.int_95 <= 0;
									if (!flag56)
									{
										goto IL_DC8;
									}
									bool flag57 = gstruct.int_88 != 1 || num27 != 0;
									if (flag57)
									{
										break;
									}
									num27 = 1;
								}
								IL_1243:
								goto IL_1244;
								IL_120E:
								bool flag58 = num2 > 0;
								if (flag58)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
								}
								num2 = 0;
								goto IL_1243;
								IL_DC8:
								int num28 = array6[num27, 0];
								num24 = array6[num27, 1];
								int num29 = array6[num27, 2];
								bool flag59 = gstruct.int_95 > 0 && array2[1] > 0;
								uint num12;
								if (flag59)
								{
									int num30 = array2[0];
									int num31 = array2[1];
									int num32 = array2[4];
									uint num33 = num12 + (uint)(num31 * (int)Class53.gstruct51_15.uint_0);
									Class22.ReadProcessMemory(gstruct.int_137, num33 + Class53.gstruct51_50.uint_0, array, 4, ref num);
									bool flag60 = BitConverter.ToInt32(array, 0) > 0;
									if (flag60)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num33 + Class53.gstruct51_45.uint_0, array, 4, ref num);
										long num34 = (long)BitConverter.ToInt32(array, 0);
										bool flag61 = num34 != 0L;
										if (flag61)
										{
											bool flag62 = Class22.smethod_30(num33 + Class53.gstruct51_52.uint_0, gstruct.int_137) != 3U;
											if (flag62)
											{
												array5 = new uint[]
												{
													Class22.smethod_30(num33 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
													Class22.smethod_30(num33 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
												};
												long num35 = Class60.smethod_18(array5, array5);
												bool flag63 = num35 <= (long)((num25 - 100) * (num25 - 100));
												if (flag63)
												{
													num28 = num30;
													num24 = num31;
													num29 = num32;
												}
											}
										}
									}
								}
								bool flag64 = Form1.int_50 > 0 && (num28 <= 0 || num28 == array2[0]) && array2[1] > 0 && array2[2] == num16 && array2[3] > 0;
								if (flag64)
								{
									int num36 = array2[0];
									int num37 = array2[1];
									int num38 = array2[4];
									uint num39 = num12 + (uint)(num37 * (int)Class53.gstruct51_15.uint_0);
									Class22.ReadProcessMemory(gstruct.int_137, num39 + Class53.gstruct51_50.uint_0, array, 4, ref num);
									bool flag65 = BitConverter.ToInt32(array, 0) > 0;
									if (flag65)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num39 + Class53.gstruct51_45.uint_0, array, 4, ref num);
										long num40 = (long)BitConverter.ToInt32(array, 0);
										bool flag66 = num40 != 0L;
										if (flag66)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num39 + Class53.gstruct51_43.uint_0, array, 4, ref num);
											bool flag67 = num36 <= 0 || BitConverter.ToInt32(array, 0) > 0;
											if (flag67)
											{
												array5 = new uint[]
												{
													Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
													Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
												};
												long num41 = Class60.smethod_18(array4, array5);
												bool flag68 = num41 <= (long)(num25 * num25);
												if (flag68)
												{
													num28 = num36;
													num24 = num37;
													num29 = num38;
												}
											}
										}
									}
								}
								array2[0] = num28;
								array2[1] = num24;
								array2[2] = num16;
								array2[3] = 0;
								array2[4] = num29;
								bool flag69 = num24 <= 0;
								if (!flag69)
								{
									array2[3] = 1;
									num2 = 1;
									num3 = 1;
									Class60.smethod_30(gstruct);
									for (int l = 0; l < Class53.int_0; l++)
									{
										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num);
										bool flag70 = array[0] == 0;
										if (flag70)
										{
											break;
										}
										Thread.Sleep(1);
									}
									bool flag71 = gstruct.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct, (uint)num24) <= 0;
									if (flag71)
									{
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num);
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num25), 4, ref num);
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num24), 4, ref num);
									}
								}
							}
							IL_1244:;
						}
						else
						{
							int[,] array6 = Class7.smethod_6(gstruct, 0U, int_, array4, null, false, false, false);
							bool flag72 = array6 != null && array6[0, 0] >= 0;
							if (flag72)
							{
								int num42 = -1;
								bool flag73 = false;
								bool flag74 = false;
								num2 = 0;
								for (;;)
								{
									int m = 0;
									int num43 = 400;
									while (m <= 0)
									{
										num42++;
										bool flag75 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num42 && gstruct.int_4 != null;
										if (!flag75)
										{
											goto IL_130D;
										}
										m = gstruct.int_3[num42, 0];
										bool flag76 = m > 0;
										if (flag76)
										{
											num43 = Class77.smethod_20(gstruct, m, gstruct.int_3[num42, 1]);
											break;
										}
									}
									Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_55.uint_0, array, 4, ref num);
									int num14 = BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_50.uint_0, array, 4, ref num);
									int num15 = BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_43.uint_0, array, 4, ref num);
									num17 = BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
									int num44 = BitConverter.ToInt32(array, 0);
									bool flag77 = num17 > 0 && num16 == num44 && num14 != 11 && num14 != 22 && num15 != 0;
									if (!flag77)
									{
										goto IL_16F0;
									}
									for (int n = 0; n < array6.GetLength(0); n++)
									{
										bool flag78 = Class44.smethod_7(gstruct, ref num7) || Class83.smethod_12(gstruct) == 1;
										if (flag78)
										{
											goto Block_139;
										}
										int num45 = array6[n, 0];
										num24 = array6[n, 1];
										bool flag79 = num24 <= 0;
										if (!flag79)
										{
											uint num12;
											uint num46 = num12 + (uint)(num24 * (int)Class53.gstruct51_15.uint_0);
											Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_50.uint_0, array, 4, ref num);
											bool flag80 = BitConverter.ToInt32(array, 0) <= 0;
											if (!flag80)
											{
												bool flag81 = num45 > 0;
												if (flag81)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_43.uint_0, array, 4, ref num);
													bool flag82 = BitConverter.ToInt32(array, 0) <= 0;
													if (flag82)
													{
														goto IL_16D0;
													}
												}
												flag73 = true;
												bool flag83 = !flag74 || num45 > 0;
												if (!flag83)
												{
													goto IL_16CE;
												}
												bool flag84 = num45 > 0;
												if (flag84)
												{
													flag74 = true;
												}
												bool flag85 = Class98.smethod_31(gstruct, num24, m) != 0;
												if (!flag85)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
													array5[0] = BitConverter.ToUInt32(array, 0);
													Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
													array5[1] = BitConverter.ToUInt32(array, 0);
													array4 = new uint[]
													{
														Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													bool flag86 = Class60.smethod_18(array4, array5) > (long)(num43 * num43) && gstruct.int_95 <= 0;
													if (!flag86)
													{
														for (int num47 = 0; num47 < Class53.int_0; num47++)
														{
															Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num);
															bool flag87 = array[0] == 0;
															if (flag87)
															{
																break;
															}
															Thread.Sleep(1);
														}
														Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(m), 4, ref num);
														Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num43), 4, ref num);
														Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num24), 4, ref num);
														Thread.Sleep(10);
														num2 = 1;
													}
												}
											}
										}
										IL_16D0:;
									}
								}
								IL_1C2C:
								goto IL_1C2D;
								IL_1720:
								bool flag88 = num2 <= 0 && gstruct.int_6 <= 0 && flag73;
								if (flag88)
								{
									long num48 = 0L;
									array4 = new uint[]
									{
										Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
										Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
									};
									num24 = -1;
									flag74 = false;
									int num49 = 0;
									int length = array6.GetLength(1);
									uint num12;
									for (int num50 = 0; num50 < array6.GetLength(0); num50++)
									{
										int num51 = array6[num50, 0];
										int num52 = array6[num50, 1];
										int num53 = array6[num50, 2];
										int num54 = 0;
										bool flag89 = length > 10;
										if (flag89)
										{
											num54 = array6[num50, 10];
										}
										bool flag90 = num52 <= 0;
										if (!flag90)
										{
											uint num46 = num12 + (uint)(num52 * (int)Class53.gstruct51_15.uint_0);
											Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_50.uint_0, array, 4, ref num);
											bool flag91 = BitConverter.ToInt32(array, 0) <= 0;
											if (!flag91)
											{
												bool flag92 = num51 > 0;
												if (flag92)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_43.uint_0, array, 4, ref num);
													bool flag93 = BitConverter.ToInt32(array, 0) <= 0;
													if (flag93)
													{
														goto IL_1980;
													}
												}
												bool flag94 = flag74 && num51 <= 0 && num24 > 0;
												if (flag94)
												{
													break;
												}
												Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
												array5[0] = BitConverter.ToUInt32(array, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
												array5[1] = BitConverter.ToUInt32(array, 0);
												long num55 = Class60.smethod_18(array4, array5);
												bool flag95 = (num24 <= 0 || num48 >= num55) && (num55 <= (long)(num25 * num25) || gstruct.int_95 > 0);
												if (flag95)
												{
													bool flag96 = num51 > 0;
													if (flag96)
													{
														flag74 = true;
													}
													num24 = num52;
													num49 = num54;
													num48 = num55;
												}
											}
										}
										IL_1980:;
									}
									bool flag97 = num24 <= 0;
									if (!flag97)
									{
										bool flag98 = Form1.int_116 > 0 && flag23;
										if (flag98)
										{
											bool flag99 = num49 <= 0;
											if (flag99)
											{
												uint num46 = num12 + (uint)(num24 * (int)Class53.gstruct51_15.uint_0);
												Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
												array5[0] = BitConverter.ToUInt32(array, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num46 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
												array5[1] = BitConverter.ToUInt32(array, 0);
												bool flag100 = Class7.smethod_4(gstruct.int_137, num16, array5) != 0;
												if (flag100)
												{
													num49 = 1;
												}
												else
												{
													uint num56 = num12 + (uint)(num24 * (int)Class53.gstruct51_15.uint_0) + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0;
													for (uint num57 = 0U; num57 < 6U; num57 += 1U)
													{
														Class22.ReadProcessMemory(gstruct.int_137, num56 + Class53.gstruct51_3.uint_0 * num57, array, 4, ref num);
														bool flag101 = BitConverter.ToInt32(array, 0) == 45;
														if (flag101)
														{
															num49 = 1;
															break;
														}
													}
												}
											}
											bool flag102 = num49 > 0;
											if (flag102)
											{
												num24 = 0;
												num2 = 0;
												goto IL_1C2C;
											}
										}
										Class60.smethod_30(gstruct);
										for (int num58 = 0; num58 < Class53.int_0; num58++)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array, 1, ref num);
											bool flag103 = array[0] == 0;
											if (flag103)
											{
												break;
											}
											Thread.Sleep(1);
										}
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num);
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num25), 4, ref num);
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num24), 4, ref num);
									}
								}
								else
								{
									bool flag104 = flag73 && num2 <= 0 && gstruct.int_6 > 0;
									if (flag104)
									{
										Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
									}
								}
								goto IL_1C2C;
								IL_130D:
								goto IL_1720;
								IL_16F0:
								bool flag105 = num2 > 0;
								if (flag105)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
								}
								num2 = 0;
								goto IL_1C2C;
								Block_139:
								num2 = 0;
								Thread.Sleep(100);
								goto IL_1C2C;
								IL_16CE:
								goto IL_1720;
							}
							IL_1C2D:;
						}
					}
				}
				goto IL_B55;
				Block_37:
				num5 = num17;
				bool flag106 = num17 <= 0;
				if (!flag106)
				{
					goto IL_57D;
				}
				Block_30:
				continue;
				IL_81E:
				int num59 = 0;
				for (;;)
				{
					bool flag107 = num4 != num16;
					if (!flag107)
					{
						goto IL_9CA;
					}
					int num60 = Class83.smethod_39(gstruct);
					Class22.WriteProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
					num2 = 0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
					bool flag108 = num != 4;
					if (flag108)
					{
						break;
					}
					uint num9 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_13.uint_0, array, 4, ref num);
					uint num10 = BitConverter.ToUInt32(array, 0);
					uint num11 = num10 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
					bool flag109 = num != 4;
					if (flag109)
					{
						break;
					}
					uint num12 = BitConverter.ToUInt32(array, 0);
					num13 = num12 + num11;
					Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_50.uint_0, array, 4, ref num);
					int num15 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
					num16 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_43.uint_0, array, 4, ref num);
					num17 = BitConverter.ToInt32(array, 0);
					bool flag110 = num17 <= 0 && num59 <= 10 && (num60 == 0 || num60 == 1 || num15 <= 0 || num16 <= 0);
					if (!flag110)
					{
						goto IL_9C9;
					}
					num59++;
					Thread.Sleep(100);
				}
				continue;
				IL_9CA:
				num4 = num16;
				continue;
				IL_9C9:
				goto IL_9CA;
			}
		}
	}
}
