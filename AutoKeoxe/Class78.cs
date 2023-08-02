using System;

namespace AutoKeoxe
{
	// Token: 0x0200004C RID: 76
	internal class Class78
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x000D7528 File Offset: 0x000D5728
		public static int smethod_0(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_124.uint_0 != 0U && Class53.gstruct51_125.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_124.uint_0 + Class53.gstruct51_125.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000D75AC File Offset: 0x000D57AC
		public static int smethod_1(GStruct49 gstruct49_0, string string_0, bool bool_0 = false, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			for (int i = 1; i < 256; i++)
			{
				uint num = uint_0 + (uint)(i * (int)Class53.gstruct51_127.uint_0);
				string text = Class22.smethod_28(num + Class53.gstruct51_138.uint_0, gstruct49_0.int_137, 40);
				bool flag2 = string_0 == text || (!bool_0 && Class12.smethod_1(text, string_0) >= 0);
				if (flag2)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x000D764C File Offset: 0x000D584C
		public static uint smethod_2(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000D769C File Offset: 0x000D589C
		public static uint[] smethod_3(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			uint[] result = null;
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			uint num = Class22.smethod_30(uint_0 + Class53.gstruct51_133.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(uint_0 + Class53.gstruct51_134.uint_0, gstruct49_0.int_137);
			bool flag2 = num > 0U;
			if (flag2)
			{
				bool flag3 = num2 > 0U;
				if (flag3)
				{
					result = new uint[]
					{
						num,
						num2
					};
				}
			}
			return result;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000D7748 File Offset: 0x000D5948
		public static int[] smethod_4(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			int num = (int)Class22.smethod_30(uint_0 + Class53.gstruct51_130.uint_0, gstruct49_0.int_137);
			int num2 = (int)Class22.smethod_30(uint_0 + Class53.gstruct51_131.uint_0, gstruct49_0.int_137);
			return new int[]
			{
				num,
				num2
			};
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000D77C8 File Offset: 0x000D59C8
		public static string smethod_5(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U, bool bool_0 = false)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			string text = Class22.smethod_28(uint_0 + Class53.gstruct51_138.uint_0, gstruct49_0.int_137, 32);
			if (bool_0)
			{
				text = Class10.smethod_1(text, 1, false);
			}
			return text;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000D7834 File Offset: 0x000D5A34
		public static int smethod_6(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return (int)Class22.smethod_30(uint_0 + Class53.gstruct51_128.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000D788C File Offset: 0x000D5A8C
		public static bool smethod_7(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			uint num = Class22.smethod_30(uint_0 + Class53.gstruct51_141.uint_0, gstruct49_0.int_137);
			return num == 0U;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000D78EC File Offset: 0x000D5AEC
		public static uint smethod_8(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_140.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x000D7944 File Offset: 0x000D5B44
		public static uint smethod_9(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_129.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x000D799C File Offset: 0x000D5B9C
		public static uint smethod_10(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_139.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x000D79F4 File Offset: 0x000D5BF4
		public static uint smethod_11(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_136.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000D7A4C File Offset: 0x000D5C4C
		public static uint smethod_12(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_137.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000D7AA4 File Offset: 0x000D5CA4
		public static uint smethod_13(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_0 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
			}
			uint_0 += (uint)(int_0 * (int)Class53.gstruct51_127.uint_0);
			return Class22.smethod_30(uint_0 + Class53.gstruct51_132.uint_0, gstruct49_0.int_137);
		}
	}
}
