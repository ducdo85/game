using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000023 RID: 35
	internal class Class39
	{
		// Token: 0x06000264 RID: 612 RVA: 0x0005CA30 File Offset: 0x0005AC30
		static Class39()
		{
			uint[,] array_ = new uint[6, 2];
			Class11.smethod_4(array_, 175420);
			Class39.uint_0 = array_;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0005CA64 File Offset: 0x0005AC64
		public static int smethod_0(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			string text = "truyÒn tèng";
			long long_ = 0L;
			uint[] array2 = null;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			for (;;)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num6 = BitConverter.ToInt32(array, 0);
				bool flag = num6 == Class39.int_0;
				if (!flag)
				{
					goto IL_4A5;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array, 0);
				uint num9 = num8 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num10 = BitConverter.ToUInt32(array, 0);
				uint num11 = num10 + num9;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_43.uint_0, array, 4, ref num);
				BitConverter.ToInt32(array, 0);
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				int num12 = Class60.smethod_20(Class39.uint_0, array3);
				uint[] array4 = new uint[]
				{
					Class39.uint_0[num12, 0],
					Class39.uint_0[num12, 1]
				};
				long num13 = Class60.smethod_18(array3, array4);
				int num14 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
				bool flag2 = Class12.bool_0 || num14 < 0;
				if (flag2)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_55.uint_0, array, 4, ref num);
				int num15 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num16 = BitConverter.ToInt32(array, 0);
				int num17 = Class83.smethod_39(gstruct49_0);
				bool flag3 = num16 != 0 && num15 != 0 && num6 != 0 && num17 > 1 && num15 != 10 && num15 != 21;
				if (!flag3)
				{
					goto IL_49D;
				}
				Thread.Sleep(300);
				bool flag4 = array2 == null;
				if (flag4)
				{
					array2 = new uint[]
					{
						array3[0],
						array3[1]
					};
					num2 = 0;
				}
				bool flag5 = num2 > 6;
				if (flag5)
				{
					long num18 = Class60.smethod_18(array2, array3);
					array2 = null;
					bool flag6 = num18 < 180000L;
					if (flag6)
					{
						Class14.smethod_2(gstruct49_0, false);
						Class60.smethod_2(gstruct49_0, array3, Class44.gstruct33_0.uint_4, 600);
						continue;
					}
					num2 = 0;
				}
				bool flag7 = num13 >= 22500L;
				if (flag7)
				{
					Class60.smethod_29(gstruct49_0, false);
					bool flag8 = num13 < 1000000L;
					if (flag8)
					{
						Class14.smethod_2(gstruct49_0, false);
						Class70.smethod_61(gstruct49_0, array4);
						num2++;
						Thread.Sleep(200);
					}
					else
					{
						bool flag9 = Class12.smethod_28(long_) > 4000L;
						if (flag9)
						{
							Class14.smethod_1(gstruct49_0, array4);
							long_ = Class12.smethod_27();
							num2 += 2;
						}
					}
				}
				else
				{
					int i;
					for (i = 0; i < 10; i++)
					{
						Class70.smethod_61(gstruct49_0, array4);
						Thread.Sleep(300);
						array3 = new uint[]
						{
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						long num19 = Class60.smethod_18(array3, array4);
						bool flag10 = num19 < 11250L;
						if (flag10)
						{
							break;
						}
					}
					bool flag11 = num3 > 0;
					if (flag11)
					{
						string text2 = Class98.smethod_16(gstruct49_0, num3, ref array4, 32);
						bool flag12 = text2 != null && 0 <= Class12.smethod_1(text2.ToUpper(), text.ToUpper());
						if (flag12)
						{
							goto IL_4AD;
						}
					}
					num3 = Class98.smethod_15(gstruct49_0, text, ref array4, 3, false, -1, null);
					bool flag13 = num3 <= 0;
					if (flag13)
					{
						bool flag14 = num4 <= 0;
						if (flag14)
						{
							Class60.smethod_29(gstruct49_0, true);
							Thread.Sleep(300);
							Class70.smethod_57(gstruct49_0, "Switch([[sit]])");
							Thread.Sleep(300);
							continue;
						}
						goto IL_493;
					}
					IL_4AD:
					Class86.smethod_8(gstruct49_0, -1);
					Thread.Sleep(100);
					Class36.smethod_10(gstruct49_0, (uint)num3);
					Thread.Sleep(200);
					i = 0;
					do
					{
						bool flag15 = Class86.smethod_0(gstruct49_0) < 0;
						if (!flag15)
						{
							goto IL_4F6;
						}
						i++;
						Thread.Sleep(100);
					}
					while (i <= 15);
					bool flag16 = num5 <= 2;
					if (!flag16)
					{
						goto IL_544;
					}
					num5++;
					Class60.smethod_12(gstruct49_0, true);
					Thread.Sleep(300);
				}
			}
			return 1;
			IL_493:
			return 1;
			IL_49D:
			return 1;
			IL_4A5:
			return 1;
			IL_4F6:
			Class86.smethod_6(gstruct49_0, "khái khu", false, false, false, false);
			return 1;
			IL_544:
			return 1;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0005CFCC File Offset: 0x0005B1CC
		public static int smethod_1(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			long long_ = 0L;
			uint[] array2 = null;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			string text = "truyÒn tèng";
			string[] array3 = new string[]
			{
				"12h",
				"6h",
				"9h",
				"3h"
			};
			uint[,] array4 = new uint[4, 2];
			Class11.smethod_4(array4, 174527);
			uint[,] array5 = array4;
			int[] array6 = new int[10];
			for (int i = 0; i < array6.Length; i++)
			{
				array6[i] = 4;
			}
			int num15;
			for (;;)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num6 = BitConverter.ToInt32(array, 0);
				bool flag = num6 == Class39.int_0;
				if (!flag)
				{
					goto IL_72F;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref array6[0]);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_13.uint_0, array, 4, ref array6[1]);
				uint num8 = BitConverter.ToUInt32(array, 0);
				uint num9 = num8 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref array6[2]);
				uint num10 = BitConverter.ToUInt32(array, 0);
				uint num11 = num10 + num9;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_43.uint_0, array, 4, ref array6[3]);
				BitConverter.ToInt32(array, 0);
				uint[] array7 = new uint[]
				{
					Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				uint[] array8 = new uint[2];
				bool flag2 = (Form1.int_6 <= 0 && Form1.int_7 <= 0) || Class44.gstruct33_1.int_4 != Class39.int_0 || Class44.gstruct33_1.uint_4 == null;
				if (flag2)
				{
					bool flag3 = Class44.gstruct33_0.uint_4 != null;
					if (flag3)
					{
						array8[0] = Class44.gstruct33_0.uint_4[0];
						array8[1] = Class44.gstruct33_0.uint_4[1];
					}
				}
				else
				{
					array8[0] = Class44.gstruct33_1.uint_4[0];
					array8[1] = Class44.gstruct33_1.uint_4[1];
				}
				long num12 = Class60.smethod_18(array7, array8);
				int num13 = Class60.smethod_20(Class39.uint_0, array7);
				uint[] array9 = new uint[]
				{
					Class39.uint_0[num13, 0],
					Class39.uint_0[num13, 1]
				};
				long num14 = Class60.smethod_18(array7, array9);
				num15 = Class60.smethod_20(array5, array8);
				uint[] uint_ = new uint[]
				{
					array5[num15, 0],
					array5[num15, 1]
				};
				long num16 = Class60.smethod_18(array8, uint_);
				bool flag4 = num12 < num14 + num16 || num15 == num13;
				if (flag4)
				{
					break;
				}
				int num17 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
				bool flag5 = !Class12.bool_0 && num17 >= 0;
				if (!flag5)
				{
					goto IL_72A;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_55.uint_0, array, 4, ref array6[4]);
				int num18 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_50.uint_0, array, 4, ref array6[5]);
				int num19 = BitConverter.ToInt32(array, 0);
				int num20 = Class83.smethod_39(gstruct49_0);
				bool flag6 = num19 != 0 && num18 != 0 && num6 != 0 && num20 > 1 && num18 != 10 && num18 != 21;
				if (!flag6)
				{
					goto IL_725;
				}
				int num21 = 5;
				int num22 = 0;
				for (;;)
				{
					bool flag7 = num22 <= num21;
					if (!flag7)
					{
						goto IL_410;
					}
					bool flag8 = array6[num22] == 0;
					if (flag8)
					{
						break;
					}
					num22++;
				}
				continue;
				IL_410:
				Thread.Sleep(300);
				bool flag9 = array2 == null;
				if (flag9)
				{
					array2 = new uint[]
					{
						array7[0],
						array7[1]
					};
					num2 = 0;
				}
				bool flag10 = num2 > 6;
				if (flag10)
				{
					long num23 = Class60.smethod_18(array2, array7);
					array2 = null;
					bool flag11 = num23 < 180000L;
					if (flag11)
					{
						Class14.smethod_2(gstruct49_0, false);
						Class60.smethod_2(gstruct49_0, array7, Class44.gstruct33_0.uint_4, 600);
						continue;
					}
					num2 = 0;
				}
				bool flag12 = num14 < 22500L;
				if (flag12)
				{
					int j;
					for (j = 0; j < 10; j++)
					{
						Class70.smethod_61(gstruct49_0, array9);
						Thread.Sleep(300);
						array7 = new uint[]
						{
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						long num24 = Class60.smethod_18(array7, array9);
						bool flag13 = num24 < 11250L;
						if (flag13)
						{
							break;
						}
					}
					bool flag14 = num3 > 0;
					if (flag14)
					{
						string text2 = Class98.smethod_16(gstruct49_0, num3, ref array9, 32);
						bool flag15 = text2 != null && 0 <= Class12.smethod_1(text2.ToUpper(), text.ToUpper());
						if (flag15)
						{
							goto IL_66C;
						}
					}
					num3 = Class98.smethod_15(gstruct49_0, text, ref array9, 3, false, -1, null);
					bool flag16 = num3 <= 0;
					if (flag16)
					{
						bool flag17 = num4 <= 0;
						if (flag17)
						{
							Class60.smethod_29(gstruct49_0, true);
							Thread.Sleep(300);
							Class70.smethod_57(gstruct49_0, "Switch([[sit]])");
							Thread.Sleep(300);
							continue;
						}
						goto IL_5EF;
					}
					IL_66C:
					Class86.smethod_8(gstruct49_0, -1);
					Thread.Sleep(100);
					Class36.smethod_10(gstruct49_0, (uint)num3);
					Thread.Sleep(200);
					j = 0;
					do
					{
						bool flag18 = Class86.smethod_0(gstruct49_0) < 0;
						if (!flag18)
						{
							goto IL_6C8;
						}
						j++;
						Thread.Sleep(100);
						bool flag19 = Class86.Class89.smethod_4(gstruct49_0);
						if (flag19)
						{
							Class86.Class89.smethod_5(gstruct49_0);
						}
					}
					while (j <= 15);
					bool flag20 = num5 <= 2;
					if (!flag20)
					{
						goto IL_716;
					}
					num5++;
					Class60.smethod_12(gstruct49_0, true);
					Thread.Sleep(300);
				}
				else
				{
					Class60.smethod_29(gstruct49_0, false);
					bool flag21 = num14 >= 1000000L;
					if (flag21)
					{
						bool flag22 = Class12.smethod_28(long_) > 4000L;
						if (flag22)
						{
							Class14.smethod_1(gstruct49_0, array9);
							long_ = Class12.smethod_27();
							num2 += 2;
						}
					}
					else
					{
						Class14.smethod_2(gstruct49_0, false);
						Class70.smethod_61(gstruct49_0, array9);
						num2++;
						Thread.Sleep(200);
					}
				}
			}
			return 0;
			IL_5EF:
			return 1;
			IL_6C8:
			Class86.smethod_6(gstruct49_0, array3[num15], false, false, false, false);
			return 1;
			IL_716:
			return 1;
			IL_725:
			return 1;
			IL_72A:
			return 1;
			IL_72F:
			return 1;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0005D71C File Offset: 0x0005B91C
		public static int smethod_2(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			long long_ = 0L;
			int num3;
			uint[] uint_;
			int num10;
			uint[] array3;
			for (;;)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				num3 = BitConverter.ToInt32(array, 0);
				bool flag3 = num3 != Class39.int_0;
				if (!flag3)
				{
					goto IL_33C;
				}
				Thread.Sleep(300);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num4 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num5 = BitConverter.ToUInt32(array, 0);
				uint num6 = num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				uint num8 = num7 + num6;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_43.uint_0, array, 4, ref num);
				int num9 = BitConverter.ToInt32(array, 0);
				uint_ = new uint[]
				{
					Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag4 = num9 > 0;
				if (flag4)
				{
					bool flag5 = !flag && Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0;
					if (flag5)
					{
						flag = true;
						bool flag6 = Class35.smethod_140(gstruct49_0, 78, "b¾c", null, false);
						if (flag6)
						{
							Class60.smethod_11(gstruct49_0, 15000);
							Thread.Sleep(100);
							continue;
						}
					}
					bool flag7 = !flag2;
					if (flag7)
					{
						flag2 = true;
						bool flag8 = Class60.smethod_14(gstruct49_0, true);
						if (flag8)
						{
							Class60.smethod_11(gstruct49_0, 15000);
							Thread.Sleep(100);
							continue;
						}
					}
				}
				int[] array2 = Class60.smethod_9(num3);
				bool flag9 = array2 == null;
				if (flag9)
				{
					break;
				}
				bool flag10 = array2[1] != 0;
				if (!flag10)
				{
					goto IL_302;
				}
				num10 = Class60.int_0[array2[0], 0];
				bool flag11 = !flag && Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0;
				if (flag11)
				{
					flag = true;
					bool flag12 = Class35.smethod_140(gstruct49_0, num10, null, null, false);
					if (flag12)
					{
						Class60.smethod_11(gstruct49_0, 15000);
						Thread.Sleep(100);
						continue;
					}
				}
				bool flag13 = num9 > 0;
				if (!flag13)
				{
					goto IL_2EB;
				}
				array3 = Class43.smethod_10(uint_, num10, "Xa phu", true);
				bool flag14 = array3 != null && num2 <= 5;
				if (!flag14)
				{
					goto IL_2E5;
				}
				bool flag15 = Class12.smethod_28(long_) > 4000L;
				if (flag15)
				{
					Class14.smethod_1(gstruct49_0, array3);
					long_ = Class12.smethod_27();
				}
			}
			return -1;
			IL_2E5:
			return -2;
			IL_2EB:
			Class14.smethod_2(gstruct49_0, false);
			Class50.smethod_5(gstruct49_0, num10);
			return -2;
			IL_302:
			array3 = Class43.smethod_10(uint_, num3, "Xa phu", true);
			bool flag16 = array3 != null;
			if (flag16)
			{
				Class50.smethod_2(gstruct49_0, "ChiÕn Long Th", array3, null, 0);
				return 2;
			}
			return -3;
			IL_33C:
			return 1;
		}

		// Token: 0x04000151 RID: 337
		public static int int_0 = 878;

		// Token: 0x04000152 RID: 338
		private static uint[,] uint_0;
	}
}
