using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200000D RID: 13
	internal class Class15
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000D164 File Offset: 0x0000B364
		public static void smethod_0()
		{
			int int_ = Class15.int_0;
			Class15.int_0 = 0;
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
							Form1.gstruct49_0[num].bool_39 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_39;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_39 = true;
						flag = true;
					}
					Class15.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D244 File Offset: 0x0000B444
		private static void smethod_1(int int_1)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = -1;
			int num3 = -1;
			int num4 = 0;
			long num5 = 0L;
			long num6 = 0L;
			byte[] array = new byte[4];
			int num7 = -1;
			int num8 = 0;
			uint num9 = 0U;
			uint[,] array2 = null;
			for (;;)
			{
				num8--;
				Thread.Sleep(300);
				bool flag = num8 <= 0;
				if (flag)
				{
					int num10 = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag2 = Class12.bool_0 || num10 < 0 || !Form1.gstruct49_0[num10].bool_25;
					if (flag2)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num10];
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num11 = BitConverter.ToInt32(array, 0);
				bool flag3 = num11 != 0 && (gstruct.gstruct45_0[0].int_0 > 0 || gstruct.gstruct45_0[1].int_0 > 0);
				if (flag3)
				{
					bool flag4 = num7 != num11 || num9 == 0U;
					if (flag4)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
						uint num12 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_13.uint_0, array, 4, ref num);
						uint num13 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
						uint num14 = BitConverter.ToUInt32(array, 0);
						num9 = num14 + num13 * Class53.gstruct51_15.uint_0;
						num7 = num11;
						num6 = 0L;
					}
					Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_50.uint_0, array, 4, ref num);
					int num15 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_55.uint_0, array, 4, ref num);
					int num16 = BitConverter.ToInt32(array, 0);
					int num17 = Class83.smethod_39(gstruct);
					bool flag5 = num15 != 0 && num17 > 1 && num16 != 0;
					if (flag5)
					{
						bool flag6 = num16 != 10 && num16 != 21;
						if (flag6)
						{
							bool flag7 = num6 == 0L || Class12.smethod_28(num6) > 15000L;
							if (flag7)
							{
								array2 = null;
								uint[] array3 = Class15.smethod_3(gstruct, gstruct.gstruct45_0[0].string_0, gstruct.gstruct45_0[0].int_5);
								uint[] array4 = Class15.smethod_3(gstruct, gstruct.gstruct45_0[1].string_0, gstruct.gstruct45_0[1].int_5);
								bool flag8 = array3 != null && array4 != null;
								if (flag8)
								{
									uint[,] array5 = new uint[2, 2];
									array5[0, 0] = array3[0];
									array5[0, 1] = array3[1];
									array5[1, 0] = array4[0];
									array5[1, 1] = array4[1];
									array2 = array5;
								}
								num6 = Class12.smethod_27();
							}
							bool flag9 = array2 == null;
							if (flag9)
							{
								Thread.Sleep(300);
							}
							else
							{
								num3++;
								bool flag10 = num3 != 0 && num3 != 1;
								if (flag10)
								{
									num3 = 0;
								}
								bool flag11 = gstruct.gstruct45_0[num3].int_0 > 0 && gstruct.gstruct45_0[num3].int_1 > 0 && gstruct.gstruct45_0[num3].int_5 != null;
								if (flag11)
								{
									int int_2 = gstruct.gstruct45_0[num3].int_1;
									int int_3 = gstruct.gstruct45_0[num3].int_2;
									Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_45.uint_0, array, 4, ref num);
									long num18 = (long)BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_46.uint_0, array, 4, ref num);
									long num19 = (long)BitConverter.ToInt32(array, 0);
									double num20 = -1.0;
									double num21 = -1.0;
									int num22 = -1;
									bool flag12 = int_2 == 5;
									if (flag12)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_47.uint_0, array, 4, ref num);
										long num23 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_47.uint_0 + 4U, array, 4, ref num);
										long num24 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_48.uint_0, array, 4, ref num);
										long num25 = (long)BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_48.uint_0 + 4U, array, 4, ref num);
										long num26 = (long)BitConverter.ToInt32(array, 0);
										bool flag13 = num24 > num23 && num24 < 5000000L;
										if (flag13)
										{
											num23 = num24;
										}
										bool flag14 = num26 > num25 && num26 < 5000000L;
										if (flag14)
										{
											num25 = num26;
										}
										num20 = (double)(num18 * 100L / num23);
										num21 = (double)(num19 * 100L / num25);
									}
									else
									{
										bool flag15 = int_2 == 6 || int_2 == 7;
										if (flag15)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.uint_7, array, 4, ref num);
											num22 = BitConverter.ToInt32(array, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.uint_8, array, 4, ref num);
											int num27 = BitConverter.ToInt32(array, 0);
											bool flag16 = num22 < num27 && num27 < num22 * 3;
											if (flag16)
											{
												num22 = num27;
											}
										}
									}
									bool flag17 = ((int_2 == 1 && num19 <= (long)int_3) || (int_2 == 2 && num19 > (long)int_3) || (int_2 == 3 && num18 <= (long)int_3) || (int_2 == 4 && num18 > (long)int_3) || (int_2 == 5 && num20 >= (double)int_3 && num21 >= (double)int_3) || (int_2 == 6 && num22 <= int_3) || (int_2 == 7 && num22 > int_3)) && !Class15.smethod_2(gstruct, array2[num3, 0], array2[num3, 1]);
									if (flag17)
									{
										array2 = null;
										num6 = 0L;
										continue;
									}
								}
								bool flag18 = DateTime.Now.Ticks < (long)(num4 * 10000) + num5;
								if (!flag18)
								{
									num5 = DateTime.Now.Ticks;
									num4 = 1000;
									int num28 = -1;
									for (;;)
									{
										num2++;
										bool flag19 = num2 != 0 && num2 != 1;
										if (flag19)
										{
											num2 = 0;
										}
										bool flag20 = gstruct.gstruct45_0[num2].int_0 <= 0 || gstruct.gstruct45_0[num2].int_1 != 0 || gstruct.gstruct45_0[num2].int_5 == null || Class15.smethod_2(gstruct, array2[num2, 0], array2[num2, 1]);
										if (!flag20)
										{
											goto IL_6F9;
										}
										bool flag21 = num28 < 0;
										if (flag21)
										{
											num28 = num2;
										}
										else
										{
											bool flag22 = num2 == num28;
											if (flag22)
											{
												goto Block_51;
											}
										}
									}
									continue;
									IL_6F9:
									array2 = null;
									num6 = 0L;
									continue;
									Block_51:
									num2 = -1;
								}
							}
						}
						else
						{
							Thread.Sleep(300);
							num6 = 0L;
						}
					}
					else
					{
						num7 = -1;
						num6 = 0L;
						Thread.Sleep(300);
					}
				}
				else
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		private static bool smethod_2(GStruct49 gstruct49_0, uint uint_0, uint uint_1)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (uint_0 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			bool flag = num3 != uint_1;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num4 = num2 + uint_0 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
				bool flag2 = array[0] == 3;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
					int num5 = (int)array[0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_100.uint_0, array, 1, ref num);
					int int_ = (int)array[0];
					Class70.smethod_43(gstruct49_0, num3, num5, int_, 3);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		private static uint[] smethod_3(GStruct49 gstruct49_0, string string_0, int[] int_1)
		{
			bool flag = Class53.uint_0 != null && string_0 != null && !(string_0 == string.Empty) && int_1 != null;
			uint[] result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
				byte[] array3 = new byte[80];
				int num4 = Class79.smethod_4(gstruct49_0);
				int num5 = 0;
				uint num6 = 1U;
				while ((ulong)num6 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num4 <= num5;
					if (flag2)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array2, 0);
					bool flag3 = num7 == 0U;
					if (!flag3)
					{
						uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] == 0;
							if (!flag5)
							{
								num5++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								bool flag6 = array[0] > 0;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_110.uint_0, array, 1, ref num);
									bool flag7 = array[0] != 0 && array[0] != 1;
									if (!flag7)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
										bool flag8 = Class10.smethod_3(array3) != string_0;
										if (!flag8)
										{
											bool flag9 = true;
											for (int i = 0; i < Class53.uint_0.Length; i++)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.uint_0[i], array2, 4, ref num);
												int num9 = BitConverter.ToInt32(array2, 0);
												bool flag10 = num9 != int_1[i];
												if (flag10)
												{
													flag9 = false;
													break;
												}
											}
											bool flag11 = flag9;
											if (flag11)
											{
												return new uint[]
												{
													num6,
													num7
												};
											}
										}
									}
								}
							}
						}
					}
					num6 += 1U;
				}
				result = null;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000059 RID: 89
		public static int int_0;
	}
}
