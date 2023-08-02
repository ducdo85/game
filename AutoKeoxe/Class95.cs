using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200005C RID: 92
	internal class Class95
	{
		// Token: 0x0600054A RID: 1354 RVA: 0x000EC830 File Offset: 0x000EAA30
		public static void smethod_0()
		{
			int int_ = Class95.int_0;
			Class95.int_0 = 0;
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
							Form1.gstruct49_0[num].bool_18 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_18;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_18 = true;
						flag = true;
					}
					Class95.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x000EC910 File Offset: 0x000EAB10
		private static void smethod_1(int int_1)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			long long_ = 0L;
			uint num5 = 0U;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[4];
			byte[] array2 = new byte[4];
			array2[0] = 5;
			byte[] byte_2 = array2;
			byte[] bytes = BitConverter.GetBytes(171);
			byte[] bytes2 = BitConverter.GetBytes(173);
			uint[] array3 = new uint[2];
			int num6 = 0;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				num--;
				Thread.Sleep(500);
				bool flag = num < 0;
				if (flag)
				{
					int num7 = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag2 = Class12.bool_0 || num7 < 0 || !Form1.gstruct49_0[num7].bool_25;
					if (flag2)
					{
						break;
					}
					num = 5;
					gstruct = Form1.gstruct49_0[num7];
				}
				bool flag3 = Class44.gstruct33_0.int_0 <= 0 || gstruct.int_136 == Class44.gstruct33_0.int_0 || Class12.smethod_28(long_) < 1000L;
				if (!flag3)
				{
					num6 = 1 - num6;
					bool flag4 = num6 > 0;
					if (flag4)
					{
						bool flag5 = gstruct.int_84[0] <= 0;
						if (flag5)
						{
							continue;
						}
						bool flag6 = num3 <= 0;
						if (flag6)
						{
							num3 = Class77.smethod_16(gstruct, 171);
						}
						bool flag7 = num3 <= 0;
						if (flag7)
						{
							continue;
						}
					}
					else
					{
						bool flag8 = gstruct.int_84[1] <= 0;
						if (flag8)
						{
							continue;
						}
						bool flag9 = num4 <= 0;
						if (flag9)
						{
							num4 = Class77.smethod_16(gstruct, 173);
						}
						bool flag10 = num4 <= 0;
						if (flag10)
						{
							continue;
						}
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num2);
					uint num8 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_13.uint_0, array, 4, ref num2);
					uint num9 = BitConverter.ToUInt32(array, 0);
					uint num10 = num9 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num2);
					uint num11 = BitConverter.ToUInt32(array, 0);
					uint num12 = num11 + num10;
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_54.uint_0, array, 4, ref num2);
					int num13 = BitConverter.ToInt32(array, 0);
					bool flag11 = num13 <= 0 || num13 == 4;
					if (!flag11)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_55.uint_0, array, 4, ref num2);
						int num14 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_50.uint_0, array, 4, ref num2);
						int num15 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num2);
						int num16 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_43.uint_0, array, 4, ref num2);
						int num17 = BitConverter.ToInt32(array, 0);
						bool flag12 = num17 <= 0 || num15 == 0 || num16 != Class44.gstruct33_0.int_4 || num14 == 0 || num14 == 10 || num14 == 21;
						if (!flag12)
						{
							uint[] uint_ = new uint[]
							{
								Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							bool flag13 = Class60.smethod_18(uint_, Class44.gstruct33_0.uint_4) > 400000L;
							if (!flag13)
							{
								int i = 0;
								bool flag14 = num5 > 0U;
								uint num18;
								if (flag14)
								{
									num18 = num11 + num5 * Class53.gstruct51_15.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, num18, array, 4, ref num2);
									int num19 = BitConverter.ToInt32(array, 0);
									bool flag15 = (long)num19 == (long)((ulong)Class44.gstruct33_0.uint_2);
									if (flag15)
									{
										goto IL_52E;
									}
								}
								num5 = 0U;
								uint uint_2 = gstruct.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
								Class22.ReadProcessMemory(gstruct.int_137, uint_2, array, 4, ref num2);
								int num20 = BitConverter.ToInt32(array, 0);
								bool flag16 = num20 <= 1;
								if (flag16)
								{
									continue;
								}
								int num21 = 0;
								uint num22 = 1U;
								while (num22 < 256U && num20 > num21)
								{
									num18 = num11 + num22 * Class53.gstruct51_15.uint_0;
									uint uint_3 = num18 + Class53.gstruct51_16.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, uint_3, array, 4, ref num2);
									bool flag17 = array[0] == 0;
									if (!flag17)
									{
										num21++;
										Class22.ReadProcessMemory(gstruct.int_137, num18, array, 4, ref num2);
										int num23 = BitConverter.ToInt32(array, 0);
										bool flag18 = (long)num23 != (long)((ulong)Class44.gstruct33_0.uint_2);
										if (!flag18)
										{
											num5 = num22;
											goto IL_52E;
										}
									}
									num22 += 1U;
								}
								IL_8AB:
								bool flag19 = i > 0;
								if (flag19)
								{
									Class70.smethod_2(gstruct, Class70.uint_6, 0, 4);
								}
								long_ = Class12.smethod_27();
								continue;
								IL_52E:
								Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_43.uint_0, array, 4, ref num2);
								bool flag20 = BitConverter.ToInt32(array, 0) > 0;
								if (flag20)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_55.uint_0, array, 4, ref num2);
									int num24 = BitConverter.ToInt32(array, 0);
									bool flag21 = num24 != 10 && num24 != 21;
									if (flag21)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_54.uint_0, array, 4, ref num2);
										int num25 = BitConverter.ToInt32(array, 0);
										bool flag22 = num25 == num13;
										if (flag22)
										{
											while (i <= 1)
											{
												for (uint num26 = 0U; num26 < 6U; num26 += 1U)
												{
													uint num27 = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num26;
													Class22.ReadProcessMemory(gstruct.int_137, num18 + num27, array, 4, ref num2);
													int num28 = BitConverter.ToInt32(array, 0);
													bool flag23 = (num6 <= 0 || num28 != 17) && (num6 != 0 || num28 != 13);
													if (!flag23)
													{
														goto IL_8AB;
													}
												}
												Class70.smethod_2(gstruct, Class70.uint_6, 1, 4);
												Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_72.uint_0, byte_, 4, ref num2);
												Thread.Sleep(100);
												for (int j = 0; j < 10; j++)
												{
													uint_ = new uint[]
													{
														Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num2);
													array3[0] = BitConverter.ToUInt32(array, 0);
													Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num2);
													array3[1] = BitConverter.ToUInt32(array, 0);
													bool flag24 = Class60.smethod_18(uint_, array3) < 160000L;
													if (flag24)
													{
														break;
													}
													Class70.smethod_61(gstruct, array3);
													Thread.Sleep(180);
												}
												uint maxValue = uint.MaxValue;
												uint value = num5;
												byte[] bytes3 = BitConverter.GetBytes(maxValue);
												byte[] bytes4 = BitConverter.GetBytes(value);
												Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_37.uint_0, bytes3, 4, ref num2);
												Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_38.uint_0, bytes4, 4, ref num2);
												bool flag25 = num6 > 0;
												if (flag25)
												{
													Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_36.uint_0, bytes, 4, ref num2);
												}
												else
												{
													Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_36.uint_0, bytes2, 4, ref num2);
												}
												Class22.WriteProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_35.uint_0, byte_2, 4, ref num2);
												i++;
												Thread.Sleep(450);
											}
										}
									}
								}
								goto IL_8AB;
							}
						}
					}
				}
			}
		}

		// Token: 0x0400040F RID: 1039
		public static int int_0;
	}
}
