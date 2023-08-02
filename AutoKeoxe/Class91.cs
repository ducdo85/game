using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000058 RID: 88
	internal class Class91
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x000EA68C File Offset: 0x000E888C
		static Class91()
		{
			uint[,] array_ = new uint[4, 2];
			Class11.smethod_4(array_, 371175);
			Class91.uint_0 = array_;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000EA6B4 File Offset: 0x000E88B4
		public static int smethod_0(GStruct49 gstruct49_0, bool bool_0 = false, uint[] uint_1 = null)
		{
			int int_ = gstruct49_0.int_136;
			int result = 0;
			int num = 0;
			long long_ = 0L;
			bool flag = false;
			Class60.smethod_10(gstruct49_0, "Luu ruong...");
			string string_ = "R­¬ng chøa|R­¬ng ®å|R­¬ng §å|chøa ®å|chøa §å|B¶o r­¬ng";
			for (;;)
			{
				IL_CF8:
				uint num7;
				int num12;
				for (;;)
				{
					IL_2E:
					Thread.Sleep(300);
					int num2 = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num2 < 0 || Class22.smethod_52(Form1.gstruct49_0[num2].process_0) || !Form1.gstruct49_0[num2].bool_25;
					if (flag2)
					{
						goto Block_4;
					}
					gstruct49_0 = Form1.gstruct49_0[num2];
					uint num3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
					uint num4 = Class22.smethod_30(num3 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
					uint num5 = num4 * Class53.gstruct51_15.uint_0;
					uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
					num7 = num6 + num5;
					int num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					int num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					int num10 = (int)Class22.smethod_30(num7 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
					bool flag3 = num10 <= 0;
					if (!flag3)
					{
						goto IL_446;
					}
					int num11 = Class83.smethod_39(gstruct49_0);
					bool flag4 = num9 != 0 && num8 != 0 && num8 != 10 && num8 != 21 && num11 > 1;
					if (!flag4)
					{
						goto IL_440;
					}
					uint[] array = new uint[]
					{
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag5 = array[0] == 0U || array[1] == 0U;
					if (!flag5)
					{
						num12 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
						string string_2 = "R­¬ng chøa ®å";
						bool flag6 = num12 == 999;
						if (flag6)
						{
							string_2 = "R­¬ng";
						}
						int[] array2 = Class60.smethod_9(num12);
						bool flag7 = array2 == null;
						if (flag7)
						{
							flag = true;
							uint_1 = Class43.smethod_10(array, num12, string_2, true);
							bool flag8 = uint_1 == null;
							if (flag8)
							{
								int num13 = Class98.smethod_13(gstruct49_0, string_, -1, false, -1, 80);
								bool flag9 = num13 <= 0;
								if (flag9)
								{
									goto Block_16;
								}
								uint_1 = Class98.smethod_19(gstruct49_0, num13);
							}
						}
						bool flag10 = uint_1 == null;
						if (flag10)
						{
							uint_1 = Class43.smethod_10(array, num12, string_2, true);
							bool flag11 = uint_1 == null;
							if (flag11)
							{
								int num14 = Class98.smethod_13(gstruct49_0, string_, -1, false, -1, 80);
								bool flag12 = num14 <= 0;
								if (flag12)
								{
									goto Block_19;
								}
								uint_1 = Class98.smethod_19(gstruct49_0, num14);
							}
						}
						long num15 = Class60.smethod_18(array, uint_1);
						bool flag13 = num15 > 90000L;
						if (!flag13)
						{
							goto IL_43E;
						}
						Class60.smethod_29(gstruct49_0, false);
						uint[,] array3 = (num12 == 341) ? Class91.uint_0 : Class42.smethod_1(num12, array, uint_1, "RUONGDO", false);
						bool flag14 = array3 != null;
						if (flag14)
						{
							for (int i = 0; i < 3; i++)
							{
								array = new uint[]
								{
									Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								Class14.smethod_2(gstruct49_0, false);
								bool flag15 = Class60.smethod_22(gstruct49_0, array3, array, uint_1, num12, true, 15000, num12 == 333) > 0;
								if (flag15)
								{
									break;
								}
								int num16 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
								bool flag16 = num16 != num12;
								if (flag16)
								{
									goto IL_2E;
								}
								num10 = (int)Class22.smethod_30(num7 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
								bool flag17 = num10 <= 0;
								if (!flag17)
								{
									goto IL_42C;
								}
							}
							goto IL_43C;
						}
						goto IL_43D;
					}
				}
				continue;
				IL_4A6:
				bool flag18 = uint_1 != null;
				if (flag18)
				{
					uint[] array4 = new uint[]
					{
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					long num17 = Class60.smethod_18(array4, uint_1);
					bool flag19 = num17 > 90000L;
					if (flag19)
					{
						Class60.smethod_29(gstruct49_0, false);
						int num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
						bool flag20 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_) > 6000L;
						if (flag20)
						{
							Class14.smethod_1(gstruct49_0, uint_1);
							long_ = Class12.smethod_27();
						}
						continue;
					}
					Class14.smethod_2(gstruct49_0, false);
					for (int j = 0; j < 10; j++)
					{
						array4 = new uint[]
						{
							Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						bool flag21 = Class60.smethod_18(array4, uint_1) < 12500L;
						if (flag21)
						{
							break;
						}
						Class70.smethod_61(gstruct49_0, uint_1);
						Thread.Sleep(300);
					}
				}
				uint num18 = 0U;
				int num19 = 0;
				int num20 = 15;
				int num21 = 0;
				byte[] array5 = new byte[num20];
				byte[] array6 = new byte[4];
				uint[] array7 = null;
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_124.uint_0 + Class53.gstruct51_125.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array6, 4, ref num19);
				int num22 = BitConverter.ToInt32(array6, 0);
				bool flag22 = num22 > 0 && num12 != 999;
				if (flag22)
				{
					int num23 = 0;
					uint num24 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
					for (uint num25 = 1U; num25 < 256U; num25 += 1U)
					{
						bool flag23 = !Class12.bool_0;
						if (!flag23)
						{
							goto IL_908;
						}
						bool flag24 = num22 <= num23 && num21 > 5;
						if (flag24)
						{
							break;
						}
						uint num26 = num24 + num25 * Class53.gstruct51_127.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num26, array6, 4, ref num19);
						int num27 = BitConverter.ToInt32(array6, 0);
						bool flag25 = num27 <= 0;
						if (flag25)
						{
							num21++;
						}
						else
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_138.uint_0, array5, 1, ref num19);
							bool flag26 = array5[0] == 0;
							if (flag26)
							{
								num21++;
							}
							else
							{
								num21 = 0;
								num23++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_138.uint_0, array5, num20, ref num19);
								string string_3 = Class10.smethod_3(array5);
								bool flag27 = 0 > Class12.smethod_1(string_3, "r­¬ng") || Class12.smethod_1(string_3, "Tr­¬ng") >= 0;
								if (!flag27)
								{
									num18 = num25;
									array7 = new uint[]
									{
										Class22.smethod_30(num26 + Class53.gstruct51_133.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num26 + Class53.gstruct51_134.uint_0, gstruct49_0.int_137)
									};
									byte[] array8 = new byte[4];
									Class22.WriteProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_133.uint_0, array8, 4, ref num19);
									Class22.WriteProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_134.uint_0, array8, 4, ref num19);
									Class83.smethod_34(gstruct49_0, 1);
									int k = 0;
									while (k < 10)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_133.uint_0, array8, 4, ref num19);
										uint num28 = BitConverter.ToUInt32(array8, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_134.uint_0, array8, 4, ref num19);
										uint num29 = BitConverter.ToUInt32(array8, 0);
										bool flag28 = num28 == 0U || num29 == 0U;
										if (!flag28)
										{
											array7 = new uint[]
											{
												num28,
												num29
											};
											break;
										}
										k++;
										Thread.Sleep(100);
									}
									Class83.smethod_34(gstruct49_0, -1);
									break;
								}
							}
						}
					}
				}
				bool flag29 = false;
				bool flag30 = num18 == 0U;
				if (flag30)
				{
					bool flag31 = !flag;
					if (flag31)
					{
						goto Block_45;
					}
					int num30 = -1;
					long num31 = 0L;
					string string_4 = string.Empty;
					uint[] array9 = null;
					int num32 = 0;
					byte[] array10 = new byte[4];
					uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array10, 4, ref num32);
					int num33 = BitConverter.ToInt32(array10, 0);
					int num34 = 0;
					for (uint num35 = 1U; num35 < 256U; num35 += 1U)
					{
						bool flag32 = num33 <= num34;
						if (flag32)
						{
							break;
						}
						uint num4;
						bool flag33 = num35 == num4;
						if (flag33)
						{
							num34++;
						}
						else
						{
							uint num6;
							uint num36 = num6 + num35 * Class53.gstruct51_15.uint_0;
							uint uint_3 = num36 + Class53.gstruct51_16.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array10, 4, ref num32);
							bool flag34 = array10[0] == 0;
							if (!flag34)
							{
								num34++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num36 + Class53.gstruct51_50.uint_0, array10, 4, ref num32);
								bool flag35 = BitConverter.ToInt32(array10, 0) > 0;
								if (flag35)
								{
									uint num37 = Class22.smethod_30(num36 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
									bool flag36 = num37 == 3U;
									if (flag36)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array5, num20, ref num19);
										string_4 = Class10.smethod_3(array5).ToLower();
										uint[] array11 = new uint[]
										{
											Class22.smethod_30(num36 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num36 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										bool flag37 = (0 <= Class12.smethod_1(string_4, "r­¬ng") && Class12.smethod_1(string_4, "Tr­¬ng") < 0) || 0 <= Class12.smethod_1(string_4, "hñ kh");
										if (flag37)
										{
											num18 = num35;
											array7 = new uint[]
											{
												array11[0],
												array11[1]
											};
											flag29 = true;
											break;
										}
										long num38 = Class60.smethod_18(uint_1, array11);
										bool flag38 = num38 <= 40000L && (num30 < 0 || num38 < num31);
										if (flag38)
										{
											num30 = (int)num35;
											num31 = num38;
											array9 = new uint[]
											{
												array11[0],
												array11[1]
											};
										}
									}
								}
								else
								{
									num21++;
								}
							}
						}
					}
					bool flag39 = num18 == 0U;
					if (flag39)
					{
						bool flag40 = num30 <= 0;
						if (flag40)
						{
							goto Block_57;
						}
						num18 = (uint)num30;
						array7 = new uint[]
						{
							array9[0],
							array9[1]
						};
						flag29 = true;
					}
				}
				int num39 = 0;
				while (!Class12.bool_0)
				{
					bool flag41 = !Class45.smethod_8(gstruct49_0);
					if (!flag41)
					{
						goto IL_CDE;
					}
					uint[] array12 = new uint[]
					{
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag42 = Class60.smethod_18(array12, array7) > 11500L;
					if (flag42)
					{
						Class70.smethod_61(gstruct49_0, array7);
						Thread.Sleep(300);
					}
					bool flag43 = flag29;
					if (flag43)
					{
						Class36.smethod_10(gstruct49_0, num18);
					}
					else
					{
						Class70.smethod_48(gstruct49_0, num18);
					}
					Thread.Sleep(300);
					num39++;
					bool flag44 = num39 % 10 != 0;
					if (!flag44)
					{
						Class60.smethod_12(gstruct49_0, true);
						num++;
						bool flag45 = num <= 3;
						if (flag45)
						{
							goto IL_CF8;
						}
						goto IL_46A;
					}
				}
				goto IL_CF3;
				Block_16:
				Block_19:
				IL_43E:
				goto IL_4A6;
				IL_43D:
				goto IL_43E;
				IL_43C:
				goto IL_43D;
				goto IL_43C;
			}
			Block_4:
			return 0;
			IL_42C:
			result = -5;
			goto IL_474;
			IL_440:
			result = -6;
			goto IL_449;
			IL_446:
			result = -5;
			IL_449:
			goto IL_474;
			IL_46A:
			result = 1;
			IL_474:
			Class70.smethod_52(gstruct49_0, "Ket thuc luu ruong !", 1);
			bool flag46 = Class45.smethod_8(gstruct49_0) && bool_0;
			if (flag46)
			{
				Class22.smethod_4(gstruct49_0.uint_4, 27U);
			}
			return result;
			IL_908:
			return 0;
			Block_45:
			result = -1;
			goto IL_474;
			Block_57:
			result = 1;
			goto IL_474;
			IL_CDE:
			result = 1;
			IL_CF3:
			goto IL_474;
		}

		// Token: 0x04000407 RID: 1031
		private static uint[,] uint_0;
	}
}
