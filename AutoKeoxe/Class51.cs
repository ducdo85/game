using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000030 RID: 48
	internal class Class51
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x0007ABC8 File Offset: 0x00078DC8
		public static void smethod_0()
		{
			int int_ = Class51.int_0;
			Class51.int_0 = 0;
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
							Form1.gstruct49_0[num].bool_30 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_30;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_30 = true;
						flag = true;
					}
					Class51.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0007ACA8 File Offset: 0x00078EA8
		private static void smethod_1(int int_1)
		{
			int num = 0;
			byte[] array = new byte[1];
			GStruct49 gstruct = default(GStruct49);
			int num2 = 0;
			long num3 = 0L;
			long long_ = 0L;
			byte[] array2 = new byte[4];
			byte[] byte_ = array2;
			byte[] byte_2 = new byte[4];
			byte[] array3 = new byte[4];
			array3[0] = 5;
			byte[] byte_3 = array3;
			byte[] bytes = BitConverter.GetBytes(716);
			byte[] byte_4 = new byte[4];
			byte[] byte_5 = new byte[4];
			int num4 = 0;
			for (;;)
			{
				num2--;
				Thread.Sleep(300);
				bool flag = num2 < 0;
				if (flag)
				{
					num4 = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag2 = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25;
					if (flag2)
					{
						break;
					}
					num2 = 10;
				}
				gstruct = Form1.gstruct49_0[num4];
				bool flag3 = gstruct.int_80 <= 0 || !gstruct.bool_57 || gstruct.gstruct47_0.int_0 > 0 || Class70.smethod_3(gstruct, Class70.uint_6, 4) > 0;
				if (!flag3)
				{
					uint num5 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num7 = num6 * Class53.gstruct51_15.uint_0;
					uint num8 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num9 = num8 + num7;
					int num10 = (int)Class22.smethod_30(num9 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					int num11 = (int)Class22.smethod_30(num9 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num12 = (int)Class22.smethod_30(num9 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					bool flag4 = num12 <= 0 || num11 == 0 || num10 == 0;
					if (!flag4)
					{
						bool flag5 = num10 != 10 && num10 != 21;
						if (flag5)
						{
							byte[] array4 = null;
							bool flag6 = gstruct.int_82 <= 0;
							if (flag6)
							{
								bool flag7 = Class12.smethod_28(long_) < gstruct.long_8;
								if (flag7)
								{
									continue;
								}
								bool flag8 = gstruct.int_81 > 0 && num10 == 9;
								if (flag8)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_38.uint_0 + 4U, array, 1, ref num);
									bool flag9 = array[0] == 0;
									if (flag9)
									{
										goto IL_352;
									}
								}
								bool flag10 = num3 == 0L;
								if (flag10)
								{
									for (int i = 0; i < Class53.int_2.Length; i++)
									{
										for (uint num13 = 0U; num13 < 6U; num13 += 1U)
										{
											uint num14 = Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num13, gstruct.int_137);
											bool flag11 = (ulong)num14 == (ulong)((long)Class53.int_2[i]);
											if (flag11)
											{
												num3 = Class12.smethod_27();
												break;
											}
										}
									}
									continue;
								}
								bool flag12 = Class12.smethod_28(num3) <= (long)gstruct.int_85;
								if (flag12)
								{
									continue;
								}
							}
							else
							{
								bool flag13 = Class12.smethod_28(long_) < (long)gstruct.int_87;
								if (flag13)
								{
									continue;
								}
							}
							IL_352:
							int num15 = 0;
							Class70.smethod_2(gstruct, Class70.uint_6, 1, 4);
							byte[] array5 = new byte[4];
							bool flag14 = array4 == null;
							if (flag14)
							{
								array4 = new byte[4];
								Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_31.uint_0, array4, 4, ref num);
								Class22.ReadProcessMemory(gstruct.int_137, num5 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_68.uint_0, byte_2, 4, ref num);
							}
							for (;;)
							{
								int j = 0;
								int num16 = -1;
								while (j < 300)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
									Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_55.uint_0, array5, 1, ref num);
									bool flag15 = array5[0] < 4 && (num16 == -1 || num16 > 80);
									if (flag15)
									{
										break;
									}
									num16 = ((array5[0] <= 3) ? (num16 + 1) : 0);
									Thread.Sleep(1);
									j++;
								}
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_31.uint_0, byte_, 4, ref num);
								Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, byte_4, 4, ref num);
								Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, byte_5, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_37.uint_0, byte_4, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_38.uint_0, byte_5, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_36.uint_0, bytes, bytes.Length, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_35.uint_0, byte_3, 4, ref num);
								for (j = 0; j < 60; j++)
								{
									for (uint num17 = 0U; num17 < 6U; num17 += 1U)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num17, array5, 4, ref num);
										bool flag16 = BitConverter.ToInt32(array5, 0) == 122;
										if (flag16)
										{
											goto Block_29;
										}
									}
									Thread.Sleep(10);
								}
								bool flag17 = num15 > 0;
								if (flag17)
								{
									break;
								}
								num15++;
							}
							IL_5F2:
							bool flag18 = array4 != null;
							if (flag18)
							{
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_31.uint_0, array4, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_161.uint_0 - 8U, byte_2, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_35.uint_0, byte_, 4, ref num);
							}
							Class70.smethod_2(gstruct, Class70.uint_6, 0, 4);
							num3 = 0L;
							long_ = Class12.smethod_27();
							continue;
							Block_29:
							goto IL_5F2;
							goto IL_352;
						}
						long_ = 0L;
						num3 = 0L;
					}
				}
			}
		}

		// Token: 0x0400017C RID: 380
		public static int int_0;
	}
}
