using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200000C RID: 12
	internal class Class14
	{
		// Token: 0x06000083 RID: 131 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		public static uint smethod_0(uint[] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 == null || uint_1 == null || uint_0[0] == 0U || uint_0[1] == 0U || uint_1[0] == 0U || uint_1[1] == 0U;
			uint result;
			if (flag)
			{
				result = 2147483647U;
			}
			else
			{
				long num = (long)(uint_0[0] - uint_1[0]);
				long num2 = (long)(uint_0[1] - uint_1[1]);
				long num3 = num * num + num2 * num2;
				bool flag2 = num3 == 0L;
				if (flag2)
				{
					num3 = 1L;
				}
				result = (uint)num3;
			}
			return result;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000CF24 File Offset: 0x0000B124
		public static int smethod_1(GStruct49 gstruct49_0, uint[] uint_0)
		{
			bool flag = uint_0 != null && gstruct49_0.uint_87 != 0U && uint_0[0] != 0U && uint_0[1] > 0U;
			int result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2;
				int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num7 = Class83.smethod_39(gstruct49_0);
				int num8 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				bool flag2 = num6 == 0 || num5 == 0 || num5 == 10 || num5 == 21 || num8 == 0 || num7 <= 1;
				if (flag2)
				{
					result = 0;
				}
				else
				{
					bool flag3 = !Class70.smethod_63(gstruct49_0, uint_0);
					if (flag3)
					{
						result = -1;
					}
					else
					{
						int num9 = 0;
						int num10 = 0;
						int num11 = 0;
						byte[] array = new byte[1];
						while (!Class12.bool_0 && num9 < 60)
						{
							bool flag4 = num11 != 0;
							if (flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_87 - 4U, array, 1, ref num10);
								bool flag5 = array[0] <= 0 && Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137) == 3U;
								if (flag5)
								{
									return 1;
								}
							}
							else
							{
								bool flag6 = Class14.smethod_3(gstruct49_0);
								if (flag6)
								{
									num11 = 1;
								}
							}
							num9++;
							Thread.Sleep(10);
						}
						result = -1;
					}
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		public static bool smethod_2(GStruct49 gstruct49_0, bool bool_0)
		{
			return Class22.smethod_31(gstruct49_0.uint_7 + Class53.gstruct51_178.uint_0, gstruct49_0.int_137, Convert.ToUInt32(bool_0), 4);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000D12C File Offset: 0x0000B32C
		public static bool smethod_3(GStruct49 gstruct49_0)
		{
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_178.uint_0;
			int num = (int)Class22.smethod_30(uint_, gstruct49_0.int_137);
			return num > 0;
		}
	}
}
