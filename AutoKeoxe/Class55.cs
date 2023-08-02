using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000034 RID: 52
	internal class Class55
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00090FB8 File Offset: 0x0008F1B8
		public static int smethod_0(GStruct49 gstruct49_0, uint[] uint_0 = null)
		{
			int int_ = gstruct49_0.int_136;
			long long_ = 0L;
			long num10;
			for (;;)
			{
				Thread.Sleep(300);
				int num = Class81.smethod_3(Form1.gstruct49_0, int_);
				bool flag = Class12.bool_0 || num < 0 || Class22.smethod_52(Form1.gstruct49_0[num].process_0) || !Form1.gstruct49_0[num].bool_25;
				if (flag)
				{
					break;
				}
				gstruct49_0 = Form1.gstruct49_0[num];
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3;
				int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				int num7 = (int)Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num8 = (int)Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num9 = Class83.smethod_39(gstruct49_0);
				bool flag2 = num8 != 0 && num7 != 0 && num7 != 10 && num7 != 21 && num6 != 0 && num9 > 1;
				if (!flag2)
				{
					goto IL_31D;
				}
				uint[] array = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag3 = array[0] == 0U || array[1] == 0U;
				if (!flag3)
				{
					uint_0 = Class43.smethod_10(array, num6, "DÞch quan", true);
					bool flag4 = uint_0 != null;
					if (!flag4)
					{
						goto IL_317;
					}
					num10 = Class60.smethod_18(array, uint_0);
					bool flag5 = num10 >= 90000L;
					if (!flag5)
					{
						goto IL_264;
					}
					uint[,] array2 = Class42.smethod_1(num6, array, uint_0, "DÞch quan", false);
					bool flag6 = array2 == null;
					if (flag6)
					{
						bool flag7 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_) > 6000L;
						if (flag7)
						{
							Class14.smethod_1(gstruct49_0, uint_0);
							long_ = Class12.smethod_27();
						}
					}
					else
					{
						Class60.smethod_22(gstruct49_0, array2, array, uint_0, num6, false, 0, false);
					}
				}
			}
			return 0;
			IL_264:
			int num11 = 0;
			while (num10 > 11500L && num11 < 10)
			{
				uint num5;
				uint[] array = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag8 = Class60.smethod_18(array, uint_0) <= 11500L;
				if (flag8)
				{
					break;
				}
				Class70.smethod_61(gstruct49_0, uint_0);
				Thread.Sleep(300);
				num11++;
			}
			return 1;
			IL_317:
			return -2;
			IL_31D:
			return -1;
		}
	}
}
