using System;

namespace AutoKeoxe
{
	// Token: 0x02000036 RID: 54
	internal class Class57
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00096900 File Offset: 0x00094B00
		public static int smethod_0(GStruct49 gstruct49_0, int int_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			bool flag = num2 == 0U;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				uint num3 = num2 + Class53.gstruct51_12.uint_0 + Class57.uint_0 + Class57.uint_1;
				uint num4 = num3;
				uint num5 = Class22.smethod_30(num4 + 4U, gstruct49_0.int_137);
				uint num6 = Class22.smethod_30(num5 + 4U, gstruct49_0.int_137);
				for (;;)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + 21U, array, 4, ref num);
					bool flag2 = array[0] > 0;
					if (flag2)
					{
						break;
					}
					uint num7 = Class22.smethod_30(num6 + 12U, gstruct49_0.int_137);
					bool flag3 = (ulong)num7 < (ulong)((long)int_0);
					if (flag3)
					{
						num6 = Class22.smethod_30(num6 + 8U, gstruct49_0.int_137);
					}
					else
					{
						num5 = num6;
						num6 = Class22.smethod_30(num6, gstruct49_0.int_137);
					}
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + 16U, array, 4, ref num);
				result = BitConverter.ToInt32(array, 0);
			}
			return result;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00096A20 File Offset: 0x00094C20
		public static int smethod_1(GStruct49 gstruct49_0)
		{
			int int_ = 1027;
			return Class57.smethod_0(gstruct49_0, int_);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00096A40 File Offset: 0x00094C40
		public static int smethod_2(GStruct49 gstruct49_0)
		{
			int int_ = 1044;
			return Class57.smethod_0(gstruct49_0, int_);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00096A60 File Offset: 0x00094C60
		public static bool smethod_3(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			bool flag = num2 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_265.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				result = (num2 == num3);
			}
			return result;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00096AE4 File Offset: 0x00094CE4
		public static void smethod_4(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
			bool flag = BitConverter.ToUInt32(array, 0) > 0U;
			if (flag)
			{
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_73);
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_147.uint_0, array, 4, ref num);
			bool flag2 = BitConverter.ToUInt32(array, 0) > 0U;
			if (flag2)
			{
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_72);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00096B80 File Offset: 0x00094D80
		public static string[] smethod_5(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_265.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			bool flag = num2 > 0U;
			string[] result;
			if (flag)
			{
				bool flag2 = !bool_0;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
					uint num3 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num3 != num2;
					if (flag3)
					{
						return null;
					}
				}
				string[] array2 = new string[3];
				uint uint_ = num2 + Class53.gstruct51_266.uint_0 + Class53.gstruct51_157.uint_0;
				uint uint_2 = num2 + Class53.gstruct51_267.uint_0 + Class53.gstruct51_157.uint_0;
				uint uint_3 = num2 + Class53.gstruct51_268.uint_0 + Class53.gstruct51_157.uint_0;
				byte[] array3 = new byte[60];
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array3, array3.Length, ref num);
				array2[0] = Class10.smethod_3(array3);
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array3, array3.Length, ref num);
				array2[1] = Class10.smethod_3(array3);
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array3, array3.Length, ref num);
				array2[2] = Class10.smethod_3(array3);
				result = array2;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x040002D7 RID: 727
		public static uint uint_0 = 34180U;

		// Token: 0x040002D8 RID: 728
		public static uint uint_1 = 1356U;
	}
}
