using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000038 RID: 56
	internal class Class59
	{
		// Token: 0x06000341 RID: 833 RVA: 0x00098F94 File Offset: 0x00097194
		public static void smethod_0()
		{
			int int_ = Class59.int_0;
			Class59.int_0 = 0;
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
							Form1.gstruct49_0[num].bool_31 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_31;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_31 = true;
						flag = true;
					}
					Class59.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00099074 File Offset: 0x00097274
		private static void smethod_1(int int_1)
		{
			int num = 0;
			int num2 = 52900;
			GStruct49 gstruct = default(GStruct49);
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			int num6 = -1;
			int num7 = 0;
			for (;;)
			{
				num4--;
				Thread.Sleep(100);
				bool flag = num4 <= num5;
				if (flag)
				{
					num = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						break;
					}
					num4 = 8;
					num5 = 0;
				}
				gstruct = Form1.gstruct49_0[num];
				bool flag3 = gstruct.int_61 <= 0 || gstruct.int_25 > 0 || gstruct.gstruct47_0.int_0 > 0;
				if (flag3)
				{
					Thread.Sleep(300);
					num5 = 5;
				}
				else
				{
					uint num8 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num9 = Class22.smethod_30(num8 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num10 = num9 * Class53.gstruct51_15.uint_0;
					uint num11 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num12 = num11 + num10;
					int num13 = (int)Class22.smethod_30(num12 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num14 = (int)Class22.smethod_30(num12 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					int num15 = Class83.smethod_39(gstruct);
					int num16 = (int)Class22.smethod_30(num12 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					bool flag4 = num13 != 0 && num16 != 10 && num16 != 21 && num15 > 1 && (num14 > 0 || gstruct.int_39 > 0);
					if (flag4)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num3);
						bool flag5 = BitConverter.ToInt32(array, 0) <= 0;
						if (flag5)
						{
							num6 = -1;
						}
						else
						{
							int num17 = Class79.smethod_4(gstruct);
							bool flag6 = num6 != num17;
							if (flag6)
							{
								num7 = Class79.smethod_25(gstruct, 3U);
								num6 = num17;
							}
							bool flag7 = num7 <= 0;
							if (flag7)
							{
								continue;
							}
						}
						uint uint_ = gstruct.uint_7 + Class53.gstruct51_124.uint_0 + Class53.gstruct51_125.uint_0 + 4U;
						Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 4, ref num3);
						int num18 = BitConverter.ToInt32(array, 0);
						bool flag8 = num18 <= 0;
						if (!flag8)
						{
							int num19 = 0;
							int num20 = 0;
							uint num21 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct.int_137);
							uint num22 = 1U;
							while (num22 < 256U)
							{
								bool flag9 = num22 % 50U == 0U;
								if (flag9)
								{
									Thread.Sleep(30);
									bool bool_ = Class12.bool_0;
									if (bool_)
									{
										break;
									}
								}
								bool flag10 = num18 <= num19 && num20 > 5;
								if (flag10)
								{
									break;
								}
								uint num23 = num21 + num22 * Class53.gstruct51_127.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_138.uint_0, array2, 1, ref num3);
								Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_137.uint_0, array, 4, ref num3);
								bool flag11 = array2[0] != 0 && BitConverter.ToInt32(array, 0) > 0;
								if (flag11)
								{
									num20 = 0;
									num19++;
									Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_128.uint_0, array, 1, ref num3);
									bool flag12 = array[0] == 4;
									if (flag12)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_132.uint_0, array, 4, ref num3);
										bool flag13 = BitConverter.ToUInt32(array, 0) <= 1U;
										if (flag13)
										{
											goto IL_70E;
										}
									}
									else
									{
										bool flag14 = gstruct.string_4 != null;
										if (flag14)
										{
											bool flag15 = false;
											Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_138.uint_0, array2, array2.Length, ref num3);
											string string_ = Class10.smethod_3(array2);
											for (int i = 0; i < gstruct.string_4.Length; i++)
											{
												bool flag16 = Class12.smethod_2(string_, gstruct.string_4[i], false);
												if (flag16)
												{
													flag15 = true;
													break;
												}
											}
											bool flag17 = flag15;
											if (flag17)
											{
												goto IL_70E;
											}
										}
										Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_129.uint_0, array, 4, ref num3);
										int num24 = BitConverter.ToInt32(array, 0);
										bool flag18 = num24 != 1 && num24 != 2 && num24 <= 4;
										if (flag18)
										{
											bool flag19 = gstruct.int_62 <= 0 || (num24 == 4 && gstruct.int_42 > 0);
											if (flag19)
											{
												goto IL_70E;
											}
											Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_130.uint_0, array, 4, ref num3);
											int num25 = BitConverter.ToInt32(array, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_131.uint_0, array, 4, ref num3);
											int num26 = BitConverter.ToInt32(array, 0);
											bool flag20 = gstruct.int_62 != 10 && (gstruct.int_62 != 9 || num24 <= 0) && (gstruct.int_62 != 1 || num25 * num26 > 1) && (gstruct.int_62 != 2 || num25 * num26 > 1 || num24 <= 0) && (gstruct.int_62 != 3 || num25 * num26 > 2) && (gstruct.int_62 != 4 || num25 * num26 > 2 || num24 <= 0) && (gstruct.int_62 != 5 || num25 * num26 > 3) && (gstruct.int_62 != 6 || num25 * num26 > 3 || num24 <= 0) && (gstruct.int_62 != 7 || num25 * num26 > 4) && (gstruct.int_62 != 8 || num25 * num26 > 4 || num24 <= 0);
											if (flag20)
											{
												goto IL_70E;
											}
										}
									}
									bool flag21 = Class22.smethod_30(num23 + Class53.gstruct51_140.uint_0, gstruct.int_137) > 0U;
									if (flag21)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_133.uint_0, array, 4, ref num3);
										uint num27 = BitConverter.ToUInt32(array, 0);
										Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_134.uint_0, array, 4, ref num3);
										uint num28 = BitConverter.ToUInt32(array, 0);
										uint[] uint_2 = new uint[]
										{
											Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										uint[] uint_3 = new uint[]
										{
											num27,
											num28
										};
										long num29 = Class60.smethod_18(uint_2, uint_3);
										bool flag22 = num29 > (long)num2;
										if (flag22)
										{
											goto IL_70E;
										}
									}
									Class70.smethod_48(gstruct, num22);
									Thread.Sleep(10 + FormLocdo.int_5);
								}
								else
								{
									num20++;
								}
								IL_70E:
								num22 += 1U;
								continue;
								goto IL_70E;
							}
						}
					}
					else
					{
						Thread.Sleep(60);
					}
				}
			}
		}

		// Token: 0x040002DE RID: 734
		public static int int_0;
	}
}
