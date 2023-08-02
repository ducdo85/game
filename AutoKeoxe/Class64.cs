using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200003E RID: 62
	internal class Class64
	{
		// Token: 0x06000383 RID: 899 RVA: 0x000A8414 File Offset: 0x000A6614
		public static int smethod_0(GStruct49 gstruct49_0, uint[] uint_0, int int_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_37 * 4U, array, 4, ref num);
			int num2 = BitConverter.ToInt32(array, 0);
			bool flag = num2 != int_0;
			if (flag)
			{
				array = BitConverter.GetBytes(int_0);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_37 * 4U, array, 4, ref num);
				double num3 = 200.0;
				double num4 = Math.Sqrt((double)(int_0 * int_0) + num3 * num3);
				double num5 = num3 / num4;
				int num6 = (int)Math.Round(num5 * 180.0 / 3.14, 0);
				array = BitConverter.GetBytes(num6);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 1U) * 4U, array, 4, ref num);
				array = BitConverter.GetBytes(360 / num6);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 2U) * 4U, array, 4, ref num);
				array = new byte[4];
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 3U) * 4U, array, 4, ref num);
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 1U) * 4U, array, 4, ref num);
			uint num7 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 2U) * 4U, array, 4, ref num);
			uint num8 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 3U) * 4U, array, 4, ref num);
			uint num9 = BitConverter.ToUInt32(array, 0);
			bool flag2 = num9 < 0U || num8 <= num9;
			if (flag2)
			{
				num9 = 0U;
				array = BitConverter.GetBytes(num9);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 3U) * 4U, array, 4, ref num);
			}
			uint num10 = num9 * num7;
			bool flag3 = num10 == 0U || num10 > 360U;
			if (flag3)
			{
				num10 = 10U;
			}
			uint[] array2 = new uint[2];
			double num11 = num10 * 3.14 / 180.0;
			array2[0] = (uint)(uint_0[0] + (double)int_0 * Math.Cos(num11));
			array2[1] = (uint)(uint_0[1] - (double)int_0 * Math.Sin(num11));
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num12 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_13.uint_0, array, 4, ref num);
			uint num13 = BitConverter.ToUInt32(array, 0);
			uint num14 = num13 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
			uint num15 = BitConverter.ToUInt32(array, 0);
			uint num16 = num15 + num14;
			uint[] array3 = new uint[2];
			int num17 = 3;
			for (int i = 0; i <= num17; i++)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
				array3[0] = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
				array3[1] = BitConverter.ToUInt32(array, 0);
				bool flag4 = Class60.smethod_18(array3, array2) < 11500L;
				if (flag4)
				{
					break;
				}
				Class70.smethod_61(gstruct49_0, array2);
				bool flag5 = i > 0 && i < num17;
				if (flag5)
				{
					Thread.Sleep(100);
				}
			}
			array = BitConverter.GetBytes((int)(num9 + 1U));
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + (Class70.uint_37 + 3U) * 4U, array, 4, ref num);
			return 1;
		}
	}
}
