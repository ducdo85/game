using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000037 RID: 55
	internal class Class58
	{
		// Token: 0x06000338 RID: 824 RVA: 0x00096CFC File Offset: 0x00094EFC
		public static uint[] smethod_0(GStruct49 gstruct49_0, uint[] uint_0, bool bool_2, bool bool_3)
		{
			int num = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_124.uint_0 + Class53.gstruct51_125.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
			int num2 = BitConverter.ToInt32(array, 0);
			bool flag = num2 > 0;
			uint[] result;
			if (flag)
			{
				byte[] array2 = new byte[60];
				int num3 = 40000;
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num6 = num5 * Class53.gstruct51_15.uint_0;
				uint num7 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num8 = num7 + num6;
				uint num9 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
				int num10 = gstruct49_0.int_52 * gstruct49_0.int_52;
				uint[] array3 = null;
				int num11 = 0;
				int num12 = 0;
				for (uint num13 = 0U; num13 < 256U; num13 += 1U)
				{
					bool flag2 = !Class12.bool_0 && (num2 > num11 || num12 <= 5);
					if (!flag2)
					{
						return null;
					}
					uint num14 = num9 + num13 * Class53.gstruct51_127.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num14, array, 4, ref num);
					int num15 = BitConverter.ToInt32(array, 0);
					bool flag3 = num15 > 0;
					if (flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_138.uint_0, array2, 1, ref num);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_137.uint_0, array, 4, ref num);
						bool flag4 = array2[0] == 0 || BitConverter.ToInt32(array, 0) <= 0;
						if (flag4)
						{
							num12++;
						}
						else
						{
							num12 = 0;
							num11++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_133.uint_0, array, 4, ref num);
							uint num16 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_134.uint_0, array, 4, ref num);
							uint num17 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_128.uint_0, array, 4, ref num);
							int num18 = BitConverter.ToInt32(array, 0);
							int num19 = -1;
							bool flag5 = num18 != 4;
							if (flag5)
							{
								bool flag6 = num18 != 3;
								if (flag6)
								{
									goto IL_77F;
								}
								GStruct38[] array4 = bool_3 ? Class58.gstruct38_0 : gstruct49_0.gstruct38_0;
								bool flag7 = array4 != null;
								if (flag7)
								{
									try
									{
										bool flag8 = false;
										for (int i = 0; i < array4.Length; i++)
										{
											bool flag9 = i > 0 && i % 50 == 0;
											if (flag9)
											{
												Thread.Sleep(15);
											}
											bool flag10 = num15 == array4[i].int_0 && Class12.smethod_28(array4[i].long_0) < (long)Class58.int_0;
											if (flag10)
											{
												flag8 = true;
												break;
											}
										}
										bool flag11 = !flag8;
										if (flag11)
										{
											goto IL_352;
										}
									}
									catch
									{
										goto IL_352;
									}
									goto IL_77F;
								}
								IL_352:
								bool flag12 = gstruct49_0.string_4 != null;
								if (flag12)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_138.uint_0, array2, array2.Length, ref num);
									string string_ = Class10.smethod_3(array2);
									bool flag13 = false;
									for (int j = 0; j < gstruct49_0.string_4.Length; j++)
									{
										bool flag14 = Class12.smethod_2(string_, gstruct49_0.string_4[j], false);
										if (flag14)
										{
											flag13 = true;
											break;
										}
									}
									bool flag15 = flag13;
									if (flag15)
									{
										goto IL_77F;
									}
								}
								Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_129.uint_0, array, 4, ref num);
								int num20 = BitConverter.ToInt32(array, 0);
								bool flag16 = num20 != 1 && num20 != 2 && num20 <= 4;
								if (flag16)
								{
									bool flag17 = gstruct49_0.int_62 <= 0 || (num20 == 4 && gstruct49_0.int_42 > 0);
									if (flag17)
									{
										goto IL_77F;
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_130.uint_0, array, 4, ref num);
									int num21 = BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_131.uint_0, array, 4, ref num);
									int num22 = BitConverter.ToInt32(array, 0);
									bool flag18 = gstruct49_0.int_62 != 10 && (gstruct49_0.int_62 != 9 || num20 <= 0) && (gstruct49_0.int_62 != 1 || num21 * num22 > 1) && (gstruct49_0.int_62 != 2 || num21 * num22 > 1 || num20 <= 0) && (gstruct49_0.int_62 != 3 || num21 * num22 > 2) && (gstruct49_0.int_62 != 4 || num21 * num22 > 2 || num20 <= 0) && (gstruct49_0.int_62 != 5 || num21 * num22 > 3) && (gstruct49_0.int_62 != 6 || num21 * num22 > 3 || num20 <= 0) && (gstruct49_0.int_62 != 7 || num21 * num22 > 4) && (gstruct49_0.int_62 != 8 || num21 * num22 > 4 || num20 <= 0);
									if (flag18)
									{
										goto IL_77F;
									}
								}
							}
							else
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_132.uint_0, array, 4, ref num);
								num19 = BitConverter.ToInt32(array, 0);
							}
							bool flag19 = Class22.smethod_30(num14 + Class53.gstruct51_140.uint_0, gstruct49_0.int_137) > 0U;
							if (flag19)
							{
								uint[] uint_2 = new uint[]
								{
									Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								uint[] array5 = new uint[]
								{
									num16,
									num17
								};
								long num23 = Class60.smethod_18(uint_2, array5);
								bool flag20 = num23 > (long)num3;
								if (flag20)
								{
									bool flag21 = gstruct49_0.int_54 <= 0 || num23 > 200000L;
									if (flag21)
									{
										bool flag22 = num19 > 1;
										if (flag22)
										{
											bool flag23 = uint_0 != null && uint_0[0] > 0U;
											if (flag23)
											{
												num23 = Class60.smethod_18(uint_0, array5);
											}
											bool flag24 = (array3 == null || num23 < (long)((ulong)array3[1])) && gstruct49_0.int_51 > 0 && num23 <= (long)num10;
											if (flag24)
											{
												array3 = new uint[]
												{
													num13,
													(uint)num23,
													num16,
													num17,
													(uint)num15
												};
											}
										}
										goto IL_77F;
									}
									for (int k = 0; k < 10; k++)
									{
										uint_2 = new uint[]
										{
											Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										num23 = Class60.smethod_18(uint_2, array5);
										bool flag25 = num23 <= (long)num3;
										if (flag25)
										{
											break;
										}
										Class70.smethod_61(gstruct49_0, array5);
										Thread.Sleep(150);
									}
								}
								Class70.smethod_48(gstruct49_0, num13);
								Thread.Sleep(10 + FormLocdo.int_5);
							}
							else
							{
								Class70.smethod_48(gstruct49_0, num13);
								Thread.Sleep(10 + FormLocdo.int_5);
							}
						}
					}
					else
					{
						num12++;
					}
					IL_77F:;
				}
				result = array3;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000974C0 File Offset: 0x000956C0
		public static void smethod_1()
		{
			int int_ = Class58.int_1;
			Class58.int_1 = 0;
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
							Form1.gstruct49_0[num].bool_32 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_32;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_32 = true;
						flag = true;
					}
					Class58.smethod_2(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000975A0 File Offset: 0x000957A0
		private static void smethod_2(int int_2)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = -1;
			long num3 = 0L;
			long long_ = 0L;
			for (;;)
			{
				Thread.Sleep(600);
				int num4 = Class81.smethod_3(Form1.gstruct49_0, int_2);
				bool flag = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25;
				if (flag)
				{
					break;
				}
				Form1.gstruct49_0[num4].bool_9 = false;
				gstruct = Form1.gstruct49_0[num4];
				bool flag2 = Class12.smethod_28(long_) > 3000L;
				if (flag2)
				{
					int num5 = 0;
					uint num6 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct.int_137);
					int num7 = 0;
					byte[] byte_ = new byte[1];
					byte[] array = new byte[4];
					while (gstruct.gstruct38_0 != null && num5 < 60)
					{
						int num8 = -1;
						for (int i = 0; i < gstruct.gstruct38_0.Length; i++)
						{
							bool flag3 = i > 0 && i % 30 == 0;
							if (flag3)
							{
								Thread.Sleep(15);
							}
							uint num9 = num6 + gstruct.gstruct38_0[i].uint_0 * Class53.gstruct51_127.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_138.uint_0, byte_, 1, ref num7);
							Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_137.uint_0, array, 4, ref num7);
							long num10 = Class12.smethod_28(gstruct.gstruct38_0[i].long_0);
							bool flag4 = (array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num10 > 3000L;
							if (flag4)
							{
								gstruct.gstruct38_0[i].long_0 = Class12.smethod_27() - (long)Class58.int_0 + 3000L;
								num5++;
							}
							bool flag5 = Class12.smethod_28(gstruct.gstruct38_0[i].long_0) > (long)Class58.int_0;
							if (flag5)
							{
								num8 = i;
								break;
							}
						}
						bool flag6 = num8 < 0;
						if (flag6)
						{
							break;
						}
						Class58.smethod_5(ref gstruct.gstruct38_0, gstruct.gstruct38_0[num8].uint_0, gstruct.gstruct38_0[num8].int_0);
						num5++;
					}
					bool flag7 = num5 > 0;
					if (flag7)
					{
						bool flag8 = gstruct.gstruct38_0 != null && gstruct.gstruct38_0.Length != 0;
						if (flag8)
						{
							Form1.gstruct49_0[num4].gstruct38_0 = new GStruct38[gstruct.gstruct38_0.Length];
							for (int j = 0; j < gstruct.gstruct38_0.Length; j++)
							{
								Form1.gstruct49_0[num4].gstruct38_0[j].int_0 = gstruct.gstruct38_0[j].int_0;
								Form1.gstruct49_0[num4].gstruct38_0[j].long_0 = gstruct.gstruct38_0[j].long_0;
								Form1.gstruct49_0[num4].gstruct38_0[j].uint_0 = gstruct.gstruct38_0[j].uint_0;
							}
						}
						else
						{
							Form1.gstruct49_0[num4].gstruct38_0 = null;
						}
					}
					bool flag9 = !Class58.bool_0;
					if (flag9)
					{
						Class58.bool_0 = true;
						while (Class58.gstruct38_0 != null && num5 <= 255)
						{
							int num8 = -1;
							for (int k = 0; k < Class58.gstruct38_0.Length; k++)
							{
								bool flag10 = k > 0 && k % 30 == 0;
								if (flag10)
								{
									Thread.Sleep(15);
								}
								uint num11 = num6 + Class58.gstruct38_0[k].uint_0 * Class53.gstruct51_127.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_138.uint_0, byte_, 1, ref num7);
								Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_137.uint_0, array, 4, ref num7);
								long num12 = Class12.smethod_28(Class58.gstruct38_0[k].long_0);
								bool flag11 = (array[0] == 0 || BitConverter.ToInt32(array, 0) <= 0) && num12 > 3000L;
								if (flag11)
								{
									Class58.gstruct38_0[k].long_0 = Class12.smethod_27() - (long)Class58.int_0 + 3000L;
								}
								bool flag12 = Class12.smethod_28(Class58.gstruct38_0[k].long_0) > (long)Class58.int_0;
								if (flag12)
								{
									num8 = k;
									break;
								}
							}
							bool flag13 = 0 > num8;
							if (flag13)
							{
								break;
							}
							num5++;
							Class58.smethod_5(ref Class58.gstruct38_0, Class58.gstruct38_0[num8].uint_0, Class58.gstruct38_0[num8].int_0);
						}
						Class58.bool_0 = false;
					}
					long_ = Class12.smethod_27();
				}
				uint num13 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num14 = Class22.smethod_30(num13 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num15 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num16 = num15 + num14 * Class53.gstruct51_15.uint_0;
				int num17 = (int)Class22.smethod_30(num16 + Class53.gstruct51_43.uint_0, gstruct.int_137);
				bool flag14 = gstruct.int_61 <= 0 || gstruct.int_25 <= 0 || num17 <= 0 || gstruct.int_62 <= 0 || gstruct.int_40 <= 0;
				if (!flag14)
				{
					int num18 = Class79.smethod_4(gstruct);
					bool flag15 = num18 <= num2 && num == 0;
					if (flag15)
					{
						num2 = num18;
					}
					else
					{
						num++;
						bool flag16 = num3 == 0L;
						if (flag16)
						{
							num3 = Class12.smethod_27();
						}
						bool flag17 = !gstruct.bool_7 && !gstruct.bool_8 && Class12.smethod_28(num3) >= 3000L;
						if (flag17)
						{
							try
							{
								Class58.smethod_3(gstruct);
								num = 0;
								num3 = 0L;
								num2 = Class79.smethod_4(gstruct);
							}
							catch
							{
							}
						}
						else
						{
							num2 = num18;
						}
					}
				}
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00097C2C File Offset: 0x00095E2C
		public static bool smethod_3(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[80];
			byte[] array2 = new byte[4];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			bool flag = false;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			int num6 = 0;
			byte[] array3 = new byte[4];
			uint num7 = 1U;
			while ((ulong)num7 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				int num8 = 0;
				while ((gstruct49_0.bool_7 || gstruct49_0.bool_8) && num8 < 1000)
				{
					Thread.Sleep(10);
					num8++;
				}
				bool flag2 = num7 % 10U == 0U;
				if (flag2)
				{
					Thread.Sleep(15);
				}
				uint num9 = num3 + num7 * Class53.gstruct51_106.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num6);
				bool flag3 = BitConverter.ToInt32(array3, 0) != 0;
				if (!flag3)
				{
					uint uint_ = num9 + Class53.gstruct51_107.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array3, 1, ref num6);
					bool flag4 = array3[0] == 0;
					if (!flag4)
					{
						uint num10 = Class79.smethod_1(gstruct49_0, num7);
						bool flag5 = num10 == 0U;
						if (!flag5)
						{
							num5++;
							bool flag6 = !Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num) || array[0] == 0;
							if (!flag6)
							{
								uint num11 = Class22.smethod_30(num2 + num10 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
								bool flag7 = num10 <= 0U || (num11 != 3U && num11 != 1U);
								if (!flag7)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_108.uint_0, array2, 4, ref num);
									int num12 = BitConverter.ToInt32(array2, 0);
									bool flag8 = num12 > 0;
									if (!flag8)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_109.uint_0, array2, 4, ref num);
										int num13 = BitConverter.ToInt32(array2, 0);
										bool flag9 = num13 == 1 || num13 == 2 || num13 == 4;
										if (!flag9)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_120.uint_0, array2, 4, ref num);
											bool flag10 = BitConverter.ToInt32(array2, 0) != 0;
											if (!flag10)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
												int num14 = BitConverter.ToInt32(array2, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num);
												int num15 = BitConverter.ToInt32(array2, 0);
												bool flag11 = num14 == 0 && num15 > 0;
												if (!flag11)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
													string text = Class10.smethod_3(array).Trim();
													bool flag12 = text == null || text == string.Empty;
													if (!flag12)
													{
														bool flag13 = gstruct49_0.string_4 != null;
														if (flag13)
														{
															for (int i = 0; i < gstruct49_0.string_4.Length; i++)
															{
																bool flag14 = 0 > Class12.smethod_1(text, gstruct49_0.string_4[i]);
																if (!flag14)
																{
																	goto IL_79B;
																}
															}
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_110.uint_0, array2, 4, ref num);
														int num16 = BitConverter.ToInt32(array2, 0);
														bool flag15 = num16 > 9;
														if (flag15)
														{
															goto IL_B33;
														}
														bool flag16 = gstruct49_0.int_43[0] <= 0 || num16 != 3;
														if (flag16)
														{
															bool flag17 = gstruct49_0.int_44[0] > 0 && num16 == 4;
															if (flag17)
															{
																bool flag18 = gstruct49_0.int_44[1] <= 0;
																if (flag18)
																{
																	goto IL_B33;
																}
																Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_44[1] - 1) * 16), array2, 4, ref num);
																bool flag19 = BitConverter.ToInt32(array2, 0) != 0;
																if (flag19)
																{
																	goto IL_B33;
																}
															}
															else
															{
																bool flag20 = gstruct49_0.int_45[0] > 0 && num16 == 9;
																if (flag20)
																{
																	bool flag21 = gstruct49_0.int_45[1] <= 0;
																	if (flag21)
																	{
																		goto IL_B33;
																	}
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_45[1] - 1) * 16), array2, 4, ref num);
																	bool flag22 = BitConverter.ToInt32(array2, 0) != 0;
																	if (flag22)
																	{
																		goto IL_B33;
																	}
																}
															}
														}
														else
														{
															bool flag23 = gstruct49_0.int_43[1] <= 0;
															if (flag23)
															{
																goto IL_B33;
															}
															Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + (uint)((gstruct49_0.int_43[1] - 1) * 16), array2, 4, ref num);
															bool flag24 = BitConverter.ToInt32(array2, 0) != 0;
															if (flag24)
															{
																goto IL_B33;
															}
														}
														bool flag25 = gstruct49_0.int_47[0] > 0;
														if (flag25)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_114.uint_0, array2, 4, ref num);
															bool flag26 = gstruct49_0.int_47[1] <= BitConverter.ToInt32(array2, 0);
															if (flag26)
															{
																goto IL_B33;
															}
														}
														bool flag27 = gstruct49_0.int_48[0] > 0;
														if (flag27)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_115.uint_0, array2, 4, ref num);
															bool flag28 = gstruct49_0.int_48[1] == BitConverter.ToInt32(array2, 0);
															if (flag28)
															{
																goto IL_B33;
															}
														}
														bool flag29 = gstruct49_0.int_50 > 0;
														if (flag29)
														{
															int num17 = 0;
															int num18 = 0;
															for (int j = 0; j < gstruct49_0.gstruct37_0.Length; j++)
															{
																bool flag30 = gstruct49_0.gstruct37_0[j].int_0 <= 0;
																if (!flag30)
																{
																	num18++;
																	bool flag31 = false;
																	for (uint num19 = 0U; num19 < 6U; num19 += 1U)
																	{
																		Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num19 * 16U, array2, 4, ref num);
																		int num20 = BitConverter.ToInt32(array2, 0);
																		bool flag32 = gstruct49_0.gstruct37_0[j].int_1 == num20;
																		if (flag32)
																		{
																			Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num19 * 16U + 4U, array2, 4, ref num);
																			int num21 = BitConverter.ToInt32(array2, 0);
																			Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num19 * 16U + 12U, array2, 4, ref num);
																			int num22 = BitConverter.ToInt32(array2, 0);
																			bool flag33 = gstruct49_0.gstruct37_0[j].int_2 <= num21 && num21 > 0;
																			bool flag34 = gstruct49_0.gstruct37_0[j].int_2 <= num22 && num22 > 0;
																			bool flag35 = gstruct49_0.gstruct37_0[j].int_2 <= 0;
																			bool flag36 = flag33 || flag34 || flag35;
																			if (flag36)
																			{
																				num17++;
																				flag31 = true;
																				break;
																			}
																		}
																	}
																	bool flag37 = flag31 || gstruct49_0.int_41 <= 0;
																	if (!flag37)
																	{
																		goto IL_79B;
																	}
																}
															}
															bool flag38 = num18 == 0 || (gstruct49_0.int_41 > 0 && num18 <= num17) || (gstruct49_0.int_41 <= 0 && num17 > 0);
															if (flag38)
															{
																goto IL_B33;
															}
														}
														IL_79B:
														bool flag39 = !flag;
														if (flag39)
														{
															int num23 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
															bool flag40 = 0 <= num23;
															if (flag40)
															{
																Form1.gstruct49_0[num23].bool_9 = true;
															}
															flag = true;
															Class58.bool_1 = true;
															Thread.Sleep(300);
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + num10 * 20U + Class53.gstruct51_100.uint_0 - 4U, array2, 4, ref num);
														uint num24 = BitConverter.ToUInt32(array2, 0);
														Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + num10 * 20U + Class53.gstruct51_100.uint_0, array2, 4, ref num);
														uint num25 = BitConverter.ToUInt32(array2, 0);
														Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
														int num26 = BitConverter.ToInt32(array2, 0);
														bool flag41 = num26 > 0;
														if (flag41)
														{
															Class70.smethod_121(gstruct49_0);
															Thread.Sleep(300);
														}
														int k = 0;
														num26 = 0;
														while (k < 150)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
															bool flag42 = BitConverter.ToInt32(array2, 0) <= 0;
															if (!flag42)
															{
																num26 = 1;
																break;
															}
															bool flag43 = k % 40 == 0;
															if (flag43)
															{
																Class70.smethod_46(gstruct49_0, num24, num25, 3U, num24, num25, 1U);
															}
															k++;
															Thread.Sleep(10);
														}
														bool flag44 = num26 <= 0;
														if (!flag44)
														{
															uint[] array4 = null;
															uint num27 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
															for (uint num28 = 1U; num28 < 256U; num28 += 1U)
															{
																bool flag45 = num28 % 10U == 0U;
																if (flag45)
																{
																	Thread.Sleep(15);
																}
																uint num29 = num27 + num28 * Class53.gstruct51_127.uint_0;
																Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_138.uint_0, array, 1, ref num);
																bool flag46 = array[0] > 0;
																if (flag46)
																{
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_137.uint_0, array2, 4, ref num);
																	bool flag47 = BitConverter.ToInt32(array2, 0) > 0;
																	if (flag47)
																	{
																		Class12.smethod_40(ref array4, num28);
																	}
																}
															}
															Class70.smethod_121(gstruct49_0);
															Thread.Sleep(300);
															for (uint num30 = 1U; num30 < 256U; num30 += 1U)
															{
																bool flag48 = num30 % 10U == 0U;
																if (flag48)
																{
																	Thread.Sleep(15);
																}
																uint num31 = num27 + num30 * Class53.gstruct51_127.uint_0;
																Class22.ReadProcessMemory(gstruct49_0.int_137, num31 + Class53.gstruct51_138.uint_0, array, 1, ref num);
																byte b = (byte)text[0];
																bool flag49 = array[0] != b;
																if (!flag49)
																{
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num31 + Class53.gstruct51_137.uint_0, array2, 4, ref num);
																	bool flag50 = BitConverter.ToInt32(array2, 0) <= 0;
																	if (!flag50)
																	{
																		bool flag51 = array4 != null;
																		if (flag51)
																		{
																			bool flag52 = false;
																			for (int l = 0; l < array4.Length; l++)
																			{
																				bool flag53 = array4[l] == num30;
																				if (flag53)
																				{
																					flag52 = true;
																					break;
																				}
																			}
																			bool flag54 = flag52;
																			if (flag54)
																			{
																				goto IL_B1A;
																			}
																		}
																		Class22.ReadProcessMemory(gstruct49_0.int_137, num31, array2, 4, ref num);
																		int int_ = BitConverter.ToInt32(array2, 0);
																		Class58.smethod_4(ref gstruct49_0.gstruct38_0, num30, int_, 0L);
																		Class58.smethod_4(ref Class58.gstruct38_0, num30, int_, 0L);
																	}
																}
																IL_B1A:;
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
				}
				IL_B33:
				num7 += 1U;
			}
			bool flag55 = !flag;
			bool result;
			if (flag55)
			{
				result = false;
			}
			else
			{
				Class58.bool_1 = false;
				int num23 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
				bool flag56 = num23 < 0;
				if (flag56)
				{
					result = false;
				}
				else
				{
					bool flag57 = gstruct49_0.gstruct38_0 == null || gstruct49_0.gstruct38_0.Length == 0;
					if (flag57)
					{
						Form1.gstruct49_0[num23].gstruct38_0 = null;
					}
					else
					{
						Form1.gstruct49_0[num23].gstruct38_0 = new GStruct38[gstruct49_0.gstruct38_0.Length];
						for (int m = 0; m < gstruct49_0.gstruct38_0.Length; m++)
						{
							Form1.gstruct49_0[num23].gstruct38_0[m].uint_0 = gstruct49_0.gstruct38_0[m].uint_0;
							Form1.gstruct49_0[num23].gstruct38_0[m].long_0 = gstruct49_0.gstruct38_0[m].long_0;
							Form1.gstruct49_0[num23].gstruct38_0[m].int_0 = gstruct49_0.gstruct38_0[m].int_0;
						}
					}
					Thread.Sleep(600);
					Form1.gstruct49_0[num23].bool_9 = false;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000988F0 File Offset: 0x00096AF0
		public static void smethod_4(ref GStruct38[] gstruct38_1, uint uint_0, int int_2, long long_0 = 0L)
		{
			try
			{
				bool flag = long_0 == 0L;
				if (flag)
				{
					long_0 = Class12.smethod_27();
				}
				bool flag2 = gstruct38_1 == null || gstruct38_1.Length == 0;
				if (flag2)
				{
					gstruct38_1 = new GStruct38[]
					{
						new GStruct38
						{
							uint_0 = uint_0,
							int_0 = int_2,
							long_0 = long_0
						}
					};
				}
				else
				{
					int num = gstruct38_1.Length;
					GStruct38[] array = new GStruct38[num + 1];
					int i = 0;
					for (;;)
					{
						bool flag3 = i < num;
						if (!flag3)
						{
							goto IL_102;
						}
						bool flag4 = gstruct38_1[i].uint_0 == uint_0 && gstruct38_1[i].int_0 == int_2;
						if (flag4)
						{
							break;
						}
						array[i].int_0 = gstruct38_1[i].int_0;
						array[i].uint_0 = gstruct38_1[i].uint_0;
						array[i].long_0 = gstruct38_1[i].long_0;
						i++;
					}
					gstruct38_1[i].long_0 = long_0;
					return;
					IL_102:
					ref GStruct38 ptr = ref array[num];
					ptr = new GStruct38
					{
						uint_0 = uint_0,
						int_0 = int_2,
						long_0 = long_0
					};
					gstruct38_1 = new GStruct38[num + 1];
					for (i = 0; i <= num; i++)
					{
						gstruct38_1[i].int_0 = array[i].int_0;
						gstruct38_1[i].uint_0 = array[i].uint_0;
						gstruct38_1[i].long_0 = array[i].long_0;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00098ADC File Offset: 0x00096CDC
		public static void smethod_5(ref GStruct38[] gstruct38_1, uint uint_0, int int_2)
		{
			try
			{
				bool flag = gstruct38_1 != null && gstruct38_1.GetLength(0) != 0;
				if (flag)
				{
					int num = gstruct38_1.Length;
					int num2 = 0;
					GStruct38[] array = new GStruct38[num];
					for (int i = 0; i < num; i++)
					{
						bool flag2 = gstruct38_1[i].uint_0 != uint_0 || gstruct38_1[i].int_0 != int_2;
						if (flag2)
						{
							array[num2].uint_0 = gstruct38_1[i].uint_0;
							array[num2].int_0 = gstruct38_1[i].int_0;
							array[num2].long_0 = gstruct38_1[i].long_0;
							num2++;
						}
					}
					bool flag3 = num2 == 0;
					if (flag3)
					{
						gstruct38_1 = null;
					}
					else
					{
						bool flag4 = num2 < num;
						if (flag4)
						{
							gstruct38_1 = new GStruct38[num2];
							for (int j = 0; j < num2; j++)
							{
								gstruct38_1[j].uint_0 = array[j].uint_0;
								gstruct38_1[j].int_0 = array[j].int_0;
								gstruct38_1[j].long_0 = array[j].long_0;
							}
						}
					}
				}
				else
				{
					gstruct38_1 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00098C6C File Offset: 0x00096E6C
		public static GStruct31 smethod_6(GStruct49 gstruct49_0)
		{
			GStruct31 gstruct = default(GStruct31);
			bool flag = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) <= 0U;
			GStruct31 result;
			if (flag)
			{
				result = gstruct;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[80];
				byte[] array2 = new byte[4];
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				byte[] array3 = new byte[4];
				int num4 = 0;
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 1U;
				while ((ulong)num7 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num5 <= num6;
					if (flag2)
					{
						break;
					}
					uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num4);
					bool flag3 = BitConverter.ToInt32(array3, 0) != 0;
					if (!flag3)
					{
						uint uint_ = num8 + Class53.gstruct51_107.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array3, 1, ref num4);
						bool flag4 = array3[0] == 0;
						if (!flag4)
						{
							uint num9 = Class79.smethod_1(gstruct49_0, num7);
							bool flag5 = num9 > 0U;
							if (flag5)
							{
								num6++;
								uint num10 = Class22.smethod_30(num2 + num9 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
								bool flag6 = num9 > 0U && num10 == 1U;
								if (flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
									gstruct.string_0 = Class10.smethod_3(array);
									gstruct.uint_1 = num7;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_111.uint_0, array2, 4, ref num);
									gstruct.uint_4 = BitConverter.ToUInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_112.uint_0, array2, 4, ref num);
									gstruct.uint_5 = BitConverter.ToUInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_109.uint_0, array2, 4, ref num);
									gstruct.int_2 = BitConverter.ToInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_110.uint_0, array2, 4, ref num);
									gstruct.int_1 = BitConverter.ToInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array2, 4, ref num);
									gstruct.int_0 = BitConverter.ToInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_120.uint_0, array2, 4, ref num);
									gstruct.int_3 = BitConverter.ToInt32(array2, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8, array2, 4, ref num);
									gstruct.uint_0 = BitConverter.ToUInt32(array2, 0);
									break;
								}
							}
						}
					}
					num7 += 1U;
				}
				result = gstruct;
			}
			return result;
		}

		// Token: 0x040002D9 RID: 729
		public static int int_0 = 180000;

		// Token: 0x040002DA RID: 730
		public static GStruct38[] gstruct38_0 = null;

		// Token: 0x040002DB RID: 731
		public static bool bool_0 = false;

		// Token: 0x040002DC RID: 732
		public static bool bool_1 = false;

		// Token: 0x040002DD RID: 733
		public static int int_1 = 0;
	}
}
