using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000007 RID: 7
	internal class Class103
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00008678 File Offset: 0x00006878
		public static void smethod_0()
		{
			int int_ = Class103.int_0;
			Class103.int_0 = 0;
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
							Form1.gstruct49_0[num].bool_38 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_38;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_38 = true;
						flag = true;
					}
					Class103.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00008758 File Offset: 0x00006958
		private static void smethod_1(int int_2)
		{
			int num = -1;
			int num2 = 0;
			int num3 = 0;
			long num4 = 0L;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				num3--;
				Thread.Sleep(100);
				bool flag = num3 <= 0;
				if (flag)
				{
					int num5 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag2 = Class12.bool_0 || num5 < 0 || !Form1.gstruct49_0[num5].bool_25;
					if (flag2)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num5];
					num3 = 10;
				}
				bool flag3 = DateTime.Now.Ticks < num4 + (long)(num2 * 10000);
				if (!flag3)
				{
					num4 = DateTime.Now.Ticks;
					num2 = 1000;
					int num6 = -1;
					uint num7;
					for (;;)
					{
						num++;
						bool flag4 = num < 0 || num > 2;
						if (flag4)
						{
							num = 0;
						}
						bool flag5 = gstruct.gstruct46_1[num].int_0 > 0;
						if (flag5)
						{
							num7 = (uint)gstruct.gstruct46_1[num].int_1;
							bool flag6 = num7 > 0U;
							if (flag6)
							{
								goto Block_9;
							}
						}
						bool flag7 = num6 < 0;
						if (flag7)
						{
							num6 = num;
						}
						else
						{
							bool flag8 = num == num6;
							if (flag8)
							{
								goto Block_12;
							}
						}
					}
					continue;
					Block_12:
					num = -1;
					continue;
					Block_9:
					num2 = gstruct.gstruct46_1[num].int_2;
					int num8 = Class77.smethod_14(gstruct);
					bool flag9 = (long)num8 != (long)((ulong)num7);
					if (flag9)
					{
						Class70.smethod_32(gstruct, num7);
						Class77.smethod_15(gstruct, num7, true);
					}
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000088F4 File Offset: 0x00006AF4
		public static void smethod_2()
		{
			int int_ = Class103.int_1;
			Class103.int_1 = 0;
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
							Form1.gstruct49_0[num].bool_37 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_37;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_37 = true;
						flag = true;
					}
					Class103.smethod_3(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000089D4 File Offset: 0x00006BD4
		private static void smethod_3(int int_2)
		{
			int num = 0;
			int num2 = -1;
			int num3 = -1;
			int num4 = 0;
			long num5 = 0L;
			byte[] array = new byte[4];
			int num6 = -1;
			uint num7 = 0U;
			uint num8 = 0U;
			GStruct49 gstruct = default(GStruct49);
			int num9 = 0;
			for (;;)
			{
				num9--;
				Thread.Sleep(300);
				bool flag = num9 <= 0;
				if (flag)
				{
					int num10 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag2 = Class12.bool_0 || num10 < 0 || !Form1.gstruct49_0[num10].bool_25;
					if (flag2)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num10];
					num9 = 4;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num11 = BitConverter.ToInt32(array, 0);
				bool flag3 = num11 != 0;
				if (flag3)
				{
					bool flag4 = num6 != num11 || num7 == 0U;
					if (flag4)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
						uint num12 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_13.uint_0, array, 4, ref num);
						uint num13 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
						num8 = BitConverter.ToUInt32(array, 0);
						num7 = num8 + num13 * Class53.gstruct51_15.uint_0;
						num6 = num11;
					}
					Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_50.uint_0, array, 4, ref num);
					int num14 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_55.uint_0, array, 4, ref num);
					int num15 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_43.uint_0, array, 4, ref num);
					int num16 = BitConverter.ToInt32(array, 0);
					int num17 = Class83.smethod_39(gstruct);
					bool flag5 = num14 == 0 || num17 <= 1 || num15 == 0;
					if (flag5)
					{
						num6 = -1;
						Thread.Sleep(300);
					}
					else
					{
						bool flag6 = num15 == 10 || num15 == 21;
						if (flag6)
						{
							Thread.Sleep(300);
						}
						else
						{
							bool flag7 = gstruct.gstruct46_2.int_0 > 0;
							if (flag7)
							{
								uint num18 = (uint)gstruct.gstruct46_2.int_1;
								bool flag8 = num16 != 0 && num18 > 0U;
								if (flag8)
								{
									bool flag9 = gstruct.gstruct46_2.int_3 > 0 && gstruct.gstruct46_2.int_2 > 0;
									if (flag9)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_46.uint_0, array, 4, ref num);
										long num19 = (long)BitConverter.ToInt32(array, 0);
										bool flag10 = num19 <= (long)gstruct.gstruct46_2.int_2;
										if (flag10)
										{
											goto IL_43B;
										}
									}
									Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_72.uint_0, array, 4, ref num);
									uint num20 = BitConverter.ToUInt32(array, 0);
									bool flag11 = num20 > 0U;
									if (flag11)
									{
										uint num21 = num8 + num20 * Class53.gstruct51_15.uint_0;
										Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_50.uint_0, array, 4, ref num);
										bool flag12 = BitConverter.ToInt32(array, 0) != 0;
										if (flag12)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_52.uint_0, array, 4, ref num);
											bool flag13 = BitConverter.ToInt32(array, 0) == 0;
											if (flag13)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_26.uint_0 + 8U, array, 4, ref num);
												bool flag14 = BitConverter.ToInt32(array, 0) != 0;
												if (flag14)
												{
													int num22 = Class77.smethod_13(gstruct);
													bool flag15 = (long)num22 != (long)((ulong)num18);
													if (flag15)
													{
														Class70.smethod_31(gstruct, num18);
														Class77.smethod_15(gstruct, num18, false);
													}
													Class70.smethod_2(gstruct, Class70.uint_44, 1, 4);
													continue;
												}
											}
										}
									}
								}
								IL_43B:;
							}
							Class70.smethod_2(gstruct, Class70.uint_44, 0, 4);
							num3++;
							bool flag16 = num3 < 0 || num3 > 2;
							if (flag16)
							{
								num3 = 0;
							}
							GStruct46 gstruct2 = gstruct.gstruct46_0[num3];
							bool flag17 = gstruct2.int_0 > 0;
							if (flag17)
							{
								int int_3 = gstruct2.int_3;
								uint num18 = (uint)gstruct2.int_1;
								bool flag18 = int_3 > 0 && num18 > 0U;
								if (flag18)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_45.uint_0, array, 4, ref num);
									long num23 = (long)BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_46.uint_0, array, 4, ref num);
									long num24 = (long)BitConverter.ToInt32(array, 0);
									double num25 = -1.0;
									double num26 = -1.0;
									int num27 = 0;
									bool flag19 = int_3 != 5;
									if (flag19)
									{
										bool flag20 = int_3 == 6 || int_3 == 7;
										if (flag20)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.uint_7, array, 4, ref num);
											num27 = BitConverter.ToInt32(array, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.uint_8, array, 4, ref num);
											int num28 = BitConverter.ToInt32(array, 0);
											bool flag21 = num27 < num28 && num28 < num27 * 3;
											if (flag21)
											{
												num27 = num28;
											}
										}
									}
									else
									{
										Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_47.uint_0, array, 4, ref num);
										long num29 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_47.uint_0 + 4U, array, 4, ref num);
										long num30 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_48.uint_0, array, 4, ref num);
										long num31 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_48.uint_0 + 4U, array, 4, ref num);
										long num32 = (long)BitConverter.ToInt32(array, 0);
										bool flag22 = num30 > num29 && num30 < 5000000L;
										if (flag22)
										{
											num29 = num30;
										}
										bool flag23 = num32 > num31 && num32 < 5000000L;
										if (flag23)
										{
											num31 = num32;
										}
										num25 = (double)(num23 * 100L / num29);
										num26 = (double)(num24 * 100L / num31);
									}
									bool flag24 = (int_3 == 1 && num24 <= (long)gstruct2.int_2) || (int_3 == 2 && num24 > (long)gstruct2.int_2) || (int_3 == 3 && num23 <= (long)gstruct2.int_2) || (int_3 == 4 && num23 > (long)gstruct2.int_2) || (int_3 == 5 && num25 >= (double)gstruct2.int_2 && num26 >= (double)gstruct2.int_2) || (int_3 == 6 && num27 <= gstruct2.int_2) || (int_3 == 7 && num27 > gstruct2.int_2);
									int num33 = Class77.smethod_13(gstruct);
									bool flag25 = flag24 && (long)num33 != (long)((ulong)num18);
									if (flag25)
									{
										Class70.smethod_31(gstruct, num18);
										Class77.smethod_15(gstruct, num18, false);
									}
								}
							}
							bool flag26 = DateTime.Now.Ticks < (long)(num4 * 10000) + num5;
							if (!flag26)
							{
								num5 = DateTime.Now.Ticks;
								num4 = 1000;
								int num34 = -1;
								uint num18;
								for (;;)
								{
									num2++;
									bool flag27 = num2 < 0 || num2 > 2;
									if (flag27)
									{
										num2 = 0;
									}
									gstruct2 = gstruct.gstruct46_0[num2];
									bool flag28 = gstruct2.int_0 > 0 && gstruct2.int_3 == 0;
									if (flag28)
									{
										num18 = (uint)gstruct2.int_1;
										bool flag29 = num18 > 0U;
										if (flag29)
										{
											goto Block_53;
										}
									}
									bool flag30 = num34 < 0;
									if (flag30)
									{
										num34 = num2;
									}
									else
									{
										bool flag31 = num2 == num34;
										if (flag31)
										{
											goto Block_56;
										}
									}
								}
								continue;
								Block_56:
								num2 = -1;
								continue;
								Block_53:
								num4 = gstruct2.int_2;
								int num35 = Class77.smethod_13(gstruct);
								bool flag32 = (long)num35 != (long)((ulong)num18);
								if (flag32)
								{
									Class70.smethod_31(gstruct, num18);
									Class77.smethod_15(gstruct, num18, false);
								}
							}
						}
					}
				}
				else
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x0400000C RID: 12
		public static int int_0;

		// Token: 0x0400000D RID: 13
		public static int int_1;
	}
}
