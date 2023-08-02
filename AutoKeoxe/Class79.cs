using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200004D RID: 77
	internal class Class79
	{
		// Token: 0x060004AC RID: 1196 RVA: 0x000D7AFC File Offset: 0x000D5CFC
		public static void smethod_0(GStruct49 gstruct49_0, int int_0, uint uint_2 = 0U, uint uint_3 = 0U)
		{
			bool flag = uint_3 == 0U;
			if (flag)
			{
				uint_3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
			}
			Class22.smethod_31((uint)((ulong)uint_3 + (ulong)((long)(int_0 * 20)) + (ulong)Class53.gstruct51_101.uint_0), gstruct49_0.int_137, uint_2, 4);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000D7B58 File Offset: 0x000D5D58
		public static uint smethod_1(GStruct49 gstruct49_0, uint uint_2)
		{
			int num = 0;
			byte[] array = new byte[4];
			uint num2 = 0U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			bool flag = num3 != 0U && Class53.gstruct51_97.uint_0 > 0U;
			if (flag)
			{
				uint num4 = num3 + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_19 + uint_2 * 4U, array, 4, ref num);
				num2 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num2 > 0U;
				if (flag2)
				{
					uint num5 = num2 * 5U + Class53.gstruct51_99.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + num5 * 4U, array, 4, ref num);
					int num6 = BitConverter.ToInt32(array, 0);
					bool flag3 = (long)num6 == (long)((ulong)uint_2);
					if (flag3)
					{
						return num2;
					}
				}
				uint num7 = num4 + Class53.gstruct51_98.uint_0;
				uint num8 = 0U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + 8U, array, 4, ref num);
				uint num9 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7, array, 4, ref num);
				uint num10 = BitConverter.ToUInt32(array, 0);
				num2 = 0U;
				while (num8 < num9 && num10 > 0U)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + num8 * 8U + 4U, array, 4, ref num);
					num8 = BitConverter.ToUInt32(array, 0);
					bool flag4 = num8 == 0U;
					if (flag4)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
					uint num11 = BitConverter.ToUInt32(array, 0);
					bool flag5 = num11 == uint_2;
					if (flag5)
					{
						num2 = num8;
						break;
					}
				}
			}
			array = BitConverter.GetBytes(num2);
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_19 + uint_2 * 4U, array, 4, ref num);
			return num2;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000D7D30 File Offset: 0x000D5F30
		public static uint smethod_2(GStruct49 gstruct49_0, uint uint_2)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (uint_2 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000D7DA8 File Offset: 0x000D5FA8
		public static bool smethod_3(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			bool flag = num == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num2 = num + uint_2 * Class53.gstruct51_106.uint_0;
				uint uint_3 = num2 + Class53.gstruct51_106.uint_0 - 4U;
				uint num3 = Class22.smethod_30(uint_3, gstruct49_0.int_137);
				result = (num3 == 0U);
			}
			return result;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000D7E10 File Offset: 0x000D6010
		public static int smethod_4(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
			uint num2 = num + Class53.gstruct51_98.uint_0;
			return (int)Class22.smethod_30(num2 + 4U, gstruct49_0.int_137);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000D7E60 File Offset: 0x000D6060
		public static uint smethod_5(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			bool flag = num > 0U;
			uint result;
			if (flag)
			{
				result = Class22.smethod_30(num + Class53.gstruct51_97.uint_0 + uint_2 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000D7EC0 File Offset: 0x000D60C0
		public static uint smethod_6(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			bool flag = num > 0U;
			uint result;
			if (flag)
			{
				result = Class22.smethod_30(num + Class53.gstruct51_97.uint_0 + uint_2 * 20U + Class53.gstruct51_100.uint_0 - 4U, gstruct49_0.int_137);
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000D7F20 File Offset: 0x000D6120
		public static uint smethod_7(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			bool flag = num > 0U;
			uint result;
			if (flag)
			{
				result = Class22.smethod_30(num + Class53.gstruct51_97.uint_0 + uint_2 * 20U + Class53.gstruct51_100.uint_0, gstruct49_0.int_137);
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000D7F7C File Offset: 0x000D617C
		public static string smethod_8(GStruct49 gstruct49_0, uint uint_2, uint uint_3 = 0U, bool bool_1 = false, int int_0 = 48)
		{
			uint_3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			bool flag = uint_3 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				uint num = uint_3 + uint_2 * Class53.gstruct51_106.uint_0;
				bool flag2 = Class22.smethod_30(num + Class53.gstruct51_106.uint_0 - 4U, gstruct49_0.int_137) == 0U;
				if (flag2)
				{
					string text = Class22.smethod_28(num + Class53.gstruct51_107.uint_0, gstruct49_0.int_137, int_0);
					bool flag3 = bool_1 && text != string.Empty;
					if (flag3)
					{
						text = Class10.smethod_1(text, 1, false);
					}
					result = text;
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000D8030 File Offset: 0x000D6230
		public static int smethod_9(GStruct49 gstruct49_0, uint uint_2)
		{
			bool flag = Class53.gstruct51_108.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = 0;
				}
				else
				{
					num += uint_2 * Class53.gstruct51_106.uint_0;
					result = (int)Class22.smethod_30(num + Class53.gstruct51_108.uint_0, gstruct49_0.int_137);
				}
			}
			return result;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000D80A0 File Offset: 0x000D62A0
		public static int smethod_10(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = Class53.gstruct51_109.uint_0 > 0U;
			int result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = 0;
				}
				else
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					result = (int)Class22.smethod_30(num + Class53.gstruct51_109.uint_0, gstruct49_0.int_137);
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000D8110 File Offset: 0x000D6310
		public static int smethod_11(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = Class53.gstruct51_110.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					result = (int)Class22.smethod_30(num + Class53.gstruct51_110.uint_0, gstruct49_0.int_137);
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000D8180 File Offset: 0x000D6380
		public static uint smethod_12(GStruct49 gstruct49_0, uint uint_2)
		{
			bool flag = Class53.gstruct51_111.uint_0 > 0U;
			uint result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += uint_2 * Class53.gstruct51_106.uint_0;
					result = Class22.smethod_30(num + Class53.gstruct51_111.uint_0, gstruct49_0.int_137);
				}
				else
				{
					result = 0U;
				}
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000D81F4 File Offset: 0x000D63F4
		public static uint smethod_13(GStruct49 gstruct49_0, uint uint_2)
		{
			bool flag = Class53.gstruct51_112.uint_0 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += uint_2 * Class53.gstruct51_106.uint_0;
					result = Class22.smethod_30(num + Class53.gstruct51_112.uint_0, gstruct49_0.int_137);
				}
				else
				{
					result = 0U;
				}
			}
			return result;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000D8264 File Offset: 0x000D6464
		public static int smethod_14(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			bool flag = num == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
				result = (int)Class22.smethod_30(num + Class53.gstruct51_113.uint_0, gstruct49_0.int_137);
			}
			return result;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000D82C0 File Offset: 0x000D64C0
		public static int smethod_15(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = Class53.gstruct51_114.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = 0;
				}
				else
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					result = (int)Class22.smethod_30(num + Class53.gstruct51_114.uint_0, gstruct49_0.int_137);
				}
			}
			return result;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000D8330 File Offset: 0x000D6530
		public static int smethod_16(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = Class53.gstruct51_115.uint_0 > 0U;
			int result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					result = (int)Class22.smethod_30(num + Class53.gstruct51_115.uint_0, gstruct49_0.int_137);
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000D83A4 File Offset: 0x000D65A4
		public static string smethod_17(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = Class53.gstruct51_116.uint_0 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = string.Empty;
				}
				else
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					result = Class22.smethod_28(num + Class53.gstruct51_116.uint_0, gstruct49_0.int_137, 255);
				}
			}
			return result;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000D8420 File Offset: 0x000D6620
		public static uint[] smethod_18(GStruct49 gstruct49_0, int int_0, int int_1 = 0)
		{
			uint[] array = new uint[4];
			uint[] array2 = array;
			bool flag = Class53.gstruct51_118.uint_0 > 0U;
			uint[] result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					array2[0] = Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_118.uint_0) + (ulong)((long)(int_1 * 16))), gstruct49_0.int_137);
					array2[1] = Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_118.uint_0) + (ulong)((long)(int_1 * 16)) + 4UL), gstruct49_0.int_137);
					array2[2] = Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_118.uint_0) + (ulong)((long)(int_1 * 16)) + 8UL), gstruct49_0.int_137);
					array2[3] = Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_118.uint_0) + (ulong)((long)(int_1 * 16)) + 12UL), gstruct49_0.int_137);
					result = array2;
				}
				else
				{
					result = array2;
				}
			}
			else
			{
				result = array2;
			}
			return result;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000D8524 File Offset: 0x000D6724
		public static int[] smethod_19(GStruct49 gstruct49_0, int int_0, int int_1 = 0)
		{
			int[] array = new int[4];
			int[] array2 = array;
			bool flag = Class53.gstruct51_117.uint_0 > 0U;
			int[] result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					num += (uint)(int_0 * (int)Class53.gstruct51_106.uint_0);
					array2[0] = (int)Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_117.uint_0) + (ulong)((long)(int_1 * 16))), gstruct49_0.int_137);
					array2[1] = (int)Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_117.uint_0) + (ulong)((long)(int_1 * 16)) + 4UL), gstruct49_0.int_137);
					array2[2] = (int)Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_117.uint_0) + (ulong)((long)(int_1 * 16)) + 8UL), gstruct49_0.int_137);
					array2[3] = (int)Class22.smethod_30((uint)((ulong)(num + Class53.gstruct51_117.uint_0) + (ulong)((long)(int_1 * 16)) + 12UL), gstruct49_0.int_137);
					result = array2;
				}
				else
				{
					result = array2;
				}
			}
			else
			{
				result = array2;
			}
			return result;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000D8628 File Offset: 0x000D6828
		public static int[] smethod_20(GStruct49 gstruct49_0, uint uint_2)
		{
			int[] array = new int[2];
			int[] array2 = array;
			bool flag = Class53.gstruct51_119.uint_0 > 0U;
			int[] result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				uint num2 = num + uint_2 * Class53.gstruct51_106.uint_0;
				array2[0] = (int)Class22.smethod_30(num2 + Class53.gstruct51_119.uint_0, gstruct49_0.int_137);
				array2[1] = (int)Class22.smethod_30(num2 + Class53.gstruct51_119.uint_0 + 4U, gstruct49_0.int_137);
				result = array2;
			}
			else
			{
				result = array2;
			}
			return result;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x000D86BC File Offset: 0x000D68BC
		public static int smethod_21(GStruct49 gstruct49_0, uint uint_2)
		{
			bool flag = Class53.gstruct51_120.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				num += uint_2 * Class53.gstruct51_106.uint_0;
				result = (int)Class22.smethod_30(num + Class53.gstruct51_120.uint_0, gstruct49_0.int_137);
			}
			return result;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000D8720 File Offset: 0x000D6920
		public static bool smethod_22(GStruct49 gstruct49_0)
		{
			int num = (int)Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137);
			return num > 0;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000D874C File Offset: 0x000D694C
		public static uint[] smethod_23(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
			bool flag = BitConverter.ToInt32(array, 0) == 0;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
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
					uint num7 = num2 + num6 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
					uint num8 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num8 == 0U;
					if (!flag3)
					{
						uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] > 0;
							if (flag5)
							{
								num5++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag6 = array[0] == 1;
								if (flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array, 1, ref num);
									uint num10 = (uint)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array, 1, ref num);
									uint num11 = (uint)array[0];
									return new uint[]
									{
										num6,
										num8,
										num10,
										num11
									};
								}
							}
						}
					}
					num6 += 1U;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000D8978 File Offset: 0x000D6B78
		public static int smethod_24(GStruct49 gstruct49_0, uint uint_2)
		{
			uint[] array = Class79.smethod_23(gstruct49_0);
			bool flag = array != null;
			int result;
			if (flag)
			{
				uint[] array2 = Class79.smethod_26(gstruct49_0, uint_2, array[2], array[3]);
				bool flag2 = array2 != null;
				if (flag2)
				{
					int i = 0;
					int num = 0;
					byte[] array3 = new byte[4];
					while (i < 100)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array3, 4, ref num);
						bool flag3 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag3)
						{
							return 1;
						}
						bool flag4 = i % 40 == 0;
						if (flag4)
						{
							Class70.smethod_46(gstruct49_0, array2[0], array2[1], uint_2, array2[0], array2[1], uint_2);
						}
						i++;
						Thread.Sleep(10);
					}
					result = -2;
				}
				else
				{
					result = -1;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000D8A48 File Offset: 0x000D6C48
		public static int smethod_25(GStruct49 gstruct49_0, uint uint_2 = 3U)
		{
			int[] array = Class45.smethod_0(uint_2);
			int num = array[0] * array[1];
			int num2 = 0;
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num2);
			uint num3 = BitConverter.ToUInt32(array3, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array3, 4, ref num2);
			uint num4 = BitConverter.ToUInt32(array3, 0);
			int num5 = Class79.smethod_4(gstruct49_0);
			int num6 = 0;
			uint num7 = 1U;
			while ((ulong)num7 < (ulong)((long)Class53.int_1))
			{
				bool flag = num5 <= num6;
				if (flag)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
				uint num8 = BitConverter.ToUInt32(array3, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					uint num9 = num4 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
					bool flag3 = BitConverter.ToInt32(array3, 0) != 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
						bool flag4 = array2[0] > 0;
						if (flag4)
						{
							num6++;
							uint num10 = num3 + num7 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
							bool flag5 = (uint)array2[0] == uint_2;
							if (flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array2, 1, ref num2);
								int num11 = (int)array2[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array2, 1, ref num2);
								int num12 = (int)array2[0];
								num -= num11 * num12;
							}
						}
					}
				}
				num7 += 1U;
			}
			return num;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000D8C54 File Offset: 0x000D6E54
		public static uint[] smethod_26(GStruct49 gstruct49_0, uint uint_2, uint uint_3 = 1U, uint uint_4 = 1U)
		{
			int[] array = Class45.smethod_0(uint_2);
			int[,] array2 = new int[array[0], array[1]];
			int num = 0;
			int num2 = 0;
			byte[] array3 = new byte[1];
			byte[] array4 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array4, 4, ref num2);
			uint num3 = BitConverter.ToUInt32(array4, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array4, 4, ref num2);
			uint num4 = BitConverter.ToUInt32(array4, 0);
			int num5 = Class79.smethod_4(gstruct49_0);
			int num6 = 0;
			uint num7 = 1U;
			while ((ulong)num7 < (ulong)((long)Class53.int_1))
			{
				bool flag = num5 <= num6;
				if (flag)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array4, 4, ref num2);
				uint num8 = BitConverter.ToUInt32(array4, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					uint num9 = num4 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array4, 4, ref num2);
					bool flag3 = BitConverter.ToInt32(array4, 0) != 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array3, 1, ref num2);
						bool flag4 = array3[0] == 0;
						if (!flag4)
						{
							num6++;
							uint num10 = num3 + num7 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array3, 1, ref num2);
							bool flag5 = (uint)array3[0] != uint_2;
							if (!flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 4U, array3, 1, ref num2);
								int num11 = (int)array3[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0, array3, 1, ref num2);
								int num12 = (int)array3[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array3, 1, ref num2);
								int num13 = (int)array3[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array3, 1, ref num2);
								int num14 = (int)array3[0];
								bool flag6 = num11 < 0 || num12 < 0 || num13 <= 0 || num14 <= 0;
								if (!flag6)
								{
									num += num13 * num14;
									for (int i = 0; i < num13; i++)
									{
										for (int j = 0; j < num14; j++)
										{
											bool flag7 = num11 + i < array[0] && num12 + j < array[1];
											if (flag7)
											{
												array2[num11 + i, num12 + j] = 1;
											}
										}
									}
								}
							}
						}
					}
				}
				num7 += 1U;
			}
			bool flag8 = (long)(array[0] * array[1] - num) >= (long)((ulong)(uint_3 * uint_4));
			if (flag8)
			{
				for (int k = 0; k < array[1]; k++)
				{
					for (int l = 0; l < array[0]; l++)
					{
						bool flag9 = true;
						int num15 = 0;
						while ((long)num15 < (long)((ulong)uint_3))
						{
							int num16 = 0;
							while ((long)num16 < (long)((ulong)uint_4))
							{
								bool flag10 = l + num15 >= array[0] || k + num16 >= array[1] || array2[l + num15, k + num16] != 0;
								if (flag10)
								{
									flag9 = false;
									break;
								}
								num16++;
							}
							bool flag11 = !flag9;
							if (flag11)
							{
								break;
							}
							num15++;
						}
						bool flag12 = flag9;
						if (flag12)
						{
							return new uint[]
							{
								(uint)l,
								(uint)k
							};
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000D9034 File Offset: 0x000D7234
		public static int[,] smethod_27(GStruct49 gstruct49_0)
		{
			int[,] array = new int[6, 10];
			int num = 0;
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			int[,] array3 = new int[8, 3];
			Class11.smethod_4(array3, 347037);
			int[,] array4 = array3;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				uint num7 = num2 + num6 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array2, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag3)
					{
						num5++;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array2, 1, ref num);
						bool flag4 = array2[0] == 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array2, 4, ref num);
							uint num10 = BitConverter.ToUInt32(array2, 0);
							bool flag5 = num10 != 3U;
							if (!flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num);
								int num11 = (int)array2[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0, array2, 1, ref num);
								int num12 = (int)array2[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array2, 1, ref num);
								int num13 = (int)array2[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array2, 1, ref num);
								int num14 = (int)array2[0];
								for (int i = num11; i < num11 + num13; i++)
								{
									for (int j = num12; j < num12 + num14; j++)
									{
										bool flag6 = i < 6 && j < 10;
										if (flag6)
										{
											array[i, j] = 1;
										}
									}
								}
							}
						}
					}
				}
				num6 += 1U;
			}
			int num15 = 0;
			for (int k = 0; k < 6; k++)
			{
				for (int l = 0; l < 10; l++)
				{
					bool flag7 = array[k, l] > 0;
					if (!flag7)
					{
						int num16 = 0;
						for (int m = 0; m < array4.GetLength(0); m++)
						{
							bool flag8 = array4[m, 0] > 0;
							if (flag8)
							{
								num16++;
							}
							else
							{
								int num17 = array4[m, 1];
								int num18 = array4[m, 2];
								bool flag9 = 6 < k + num17 || 10 < l + num18;
								if (!flag9)
								{
									int num19 = 1;
									for (int n = k; n < k + num17; n++)
									{
										for (int num20 = l; num20 < l + num18; num20++)
										{
											bool flag10 = array[n, num20] <= 0;
											if (!flag10)
											{
												num19 = 0;
												goto IL_383;
											}
										}
									}
									IL_383:
									bool flag11 = num19 > 0;
									if (flag11)
									{
										array4[m, 0] = 1;
										num15++;
									}
								}
							}
						}
						bool flag12 = num16 == array4.GetLength(0);
						if (flag12)
						{
							return array4;
						}
					}
				}
			}
			bool flag13 = num15 == 0;
			if (flag13)
			{
				array4[0, 0] = -2;
			}
			return array4;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000D9460 File Offset: 0x000D7660
		public static uint smethod_28(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			uint num2 = uint_2 * Class53.gstruct51_106.uint_0;
			uint uint_3 = num + num2 + Class53.gstruct51_103.uint_0;
			return Class22.smethod_30(uint_3, gstruct49_0.int_137);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000D94B0 File Offset: 0x000D76B0
		public static uint[] smethod_29(GStruct49 gstruct49_0, string string_0, int int_0 = 3, bool bool_1 = false)
		{
			bool flag = string_0 != null;
			uint[] result;
			if (flag)
			{
				int num = 1;
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2 = array[i] == null;
					if (flag2)
					{
						array[i] = string.Empty;
					}
					bool flag3 = num < array[i].Length;
					if (flag3)
					{
						num = array[i].Length;
					}
					array[i] = array[i].ToLower();
				}
				num += 4;
				int num2 = 0;
				byte[] array2 = new byte[1];
				byte[] array3 = new byte[4];
				byte[] byte_ = new byte[num];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array3, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array3, 0) + Class53.gstruct51_97.uint_0;
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 1U;
				while ((ulong)num7 < (ulong)((long)Class53.int_1))
				{
					bool flag4 = num5 <= num6;
					if (flag4)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
					uint num8 = BitConverter.ToUInt32(array3, 0);
					bool flag5 = num8 == 0U;
					if (!flag5)
					{
						uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
						bool flag6 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
							bool flag7 = array2[0] == 0;
							if (!flag7)
							{
								num6++;
								uint num10 = num4 + num7 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
								uint num11 = (uint)array2[0];
								bool flag8 = int_0 > 0 && (ulong)num11 != (ulong)((long)int_0);
								if (!flag8)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, byte_, num, ref num2);
									string text = Class10.smethod_3(byte_).ToLower();
									int length = text.Length;
									char[] array4 = text.ToCharArray();
									int num12 = array4.Length;
									for (int j = 0; j < array.Length; j++)
									{
										bool flag9 = bool_1 && length != array[j].Length;
										if (!flag9)
										{
											bool flag10 = true;
											char[] array5 = array[j].ToCharArray();
											for (int k = 0; k < array5.Length; k++)
											{
												bool flag11 = num12 > k;
												if (!flag11)
												{
													flag10 = false;
													break;
												}
												bool flag12 = array5[k] != '?' && array4[k] != array5[k];
												if (flag12)
												{
													flag10 = false;
													break;
												}
											}
											bool flag13 = flag10;
											if (flag13)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_108.uint_0, array2, 1, ref num2);
												uint num13 = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_110.uint_0, array2, 1, ref num2);
												uint num14 = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num2);
												uint num15 = (uint)array2[0];
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0, array2, 1, ref num2);
												uint num16 = (uint)array2[0];
												return new uint[]
												{
													num8,
													num7,
													num15,
													num16,
													num11,
													num13,
													num14
												};
											}
										}
									}
								}
							}
						}
					}
					num7 += 1U;
				}
				result = null;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000D98B8 File Offset: 0x000D7AB8
		public static uint smethod_30(GStruct49 gstruct49_0, string string_0, bool bool_1 = false, uint uint_2 = 3U, bool bool_2 = false)
		{
			bool flag = string_0 == null || string_0 == string.Empty;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				int num = string_0.Length + 2;
				int num2 = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				byte[] byte_ = new byte[num];
				string object_ = string_0.Trim().ToLower();
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array2, 0);
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 1U;
				while ((ulong)num7 < (ulong)((long)Class53.int_1) && num5 > num6)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num2);
					uint num8 = BitConverter.ToUInt32(array2, 0);
					bool flag2 = num8 == 0U;
					if (!flag2)
					{
						uint num9 = num4 + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num2);
						bool flag3 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
							bool flag4 = array[0] == 0;
							if (!flag4)
							{
								num6++;
								uint num10 = num3 + num7 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
								bool flag5 = (uint)array[0] != uint_2;
								if (!flag5)
								{
									bool flag6 = bool_2 && Class53.gstruct51_120.uint_0 > 0U;
									if (flag6)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_120.uint_0, array2, 4, ref num2);
										bool flag7 = BitConverter.ToUInt32(array2, 0) > 0U;
										if (flag7)
										{
											goto IL_24E;
										}
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, byte_, num, ref num2);
									string text = Class10.smethod_3(byte_);
									string string_ = text.ToLower();
									bool flag8 = text == string_0 || (!bool_1 && Class12.smethod_1(string_, object_) == 0);
									if (flag8)
									{
										return num8;
									}
								}
							}
						}
					}
					IL_24E:
					num7 += 1U;
				}
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x000D9B40 File Offset: 0x000D7D40
		public static int smethod_31(GStruct49 gstruct49_0, string string_0, int int_0 = 3, bool bool_1 = false, bool bool_2 = false)
		{
			bool flag = string_0 == null || string_0 == string.Empty;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				int num2 = string_0.Length + 4;
				int num3 = 0;
				byte[] array = new byte[4];
				byte[] byte_ = new byte[num2];
				string value = string_0.Trim().ToLower();
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num3);
				uint num4 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num3);
				uint num5 = BitConverter.ToUInt32(array, 0);
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = 1U;
				while ((ulong)num8 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num6 <= num7;
					if (flag2)
					{
						break;
					}
					uint num9 = num4 + num8 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num3);
					uint num10 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num10 == 0U;
					if (!flag3)
					{
						uint num11 = num5 + num10 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num3);
						bool flag4 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag4)
						{
							num7++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_107.uint_0, array, 1, ref num3);
							bool flag5 = array[0] == 0;
							if (!flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num3);
								bool flag6 = (int)array[0] != int_0;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_107.uint_0, byte_, num2, ref num3);
									string text = Class10.smethod_3(byte_);
									string text2 = text.ToLower();
									bool flag7 = text == string_0 || (!bool_2 && 0 <= text2.IndexOf(value));
									if (flag7)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_108.uint_0, array, 1, ref num3);
										bool flag8 = array[0] > 0 && bool_1;
										if (flag8)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_119.uint_0, array, 4, ref num3);
											int num12 = BitConverter.ToInt32(array, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_119.uint_0 + 4U, array, 4, ref num3);
											int num13 = BitConverter.ToInt32(array, 0);
											num = ((num13 > 1 && num12 >= 0) ? (num + num12) : (num + 1));
										}
										else
										{
											num++;
										}
									}
								}
							}
						}
					}
					num8 += 1U;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000D9E14 File Offset: 0x000D8014
		public static int smethod_32(GStruct49 gstruct49_0, string string_0, bool bool_1 = false, uint uint_2 = 3U)
		{
			bool flag = string_0 == null;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array2, 0);
				string[] array3 = string_0.Split(new char[]
				{
					'|'
				});
				string[] array4 = new string[array3.Length];
				int num5 = 1;
				for (int i = 0; i < array3.Length; i++)
				{
					bool flag2 = array3[i] == null;
					if (flag2)
					{
						array3[i] = string.Empty;
					}
					bool flag3 = array3[i].Length > num5;
					if (flag3)
					{
						num5 = array3[i].Length;
					}
					array4[i] = array3[i].Trim().ToLower();
				}
				num5 += 2;
				byte[] byte_ = new byte[num5];
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = 1U;
				while ((ulong)num8 < (ulong)((long)Class53.int_1))
				{
					bool flag4 = num6 <= num7;
					if (flag4)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num2);
					uint num9 = BitConverter.ToUInt32(array2, 0);
					bool flag5 = num9 == 0U;
					if (!flag5)
					{
						uint num10 = num4 + num9 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num2);
						bool flag6 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
							bool flag7 = array[0] == 0;
							if (!flag7)
							{
								num7++;
								uint num11 = num3 + num8 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
								bool flag8 = (uint)array[0] != uint_2;
								if (!flag8)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, byte_, num5, ref num2);
									string text = Class10.smethod_3(byte_);
									string string_ = text.ToLower();
									bool flag9 = false;
									for (int j = 0; j < array3.Length; j++)
									{
										bool flag10 = text == array3[j] || (!bool_1 && 0 <= Class12.smethod_1(string_, array4[j]));
										if (flag10)
										{
											flag9 = true;
											break;
										}
									}
									bool flag11 = !flag9;
									if (!flag11)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array, 1, ref num2);
										bool flag12 = array[0] == 0;
										if (flag12)
										{
											num++;
										}
										else
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num2);
											int num12 = BitConverter.ToInt32(array2, 0);
											bool flag13 = num12 <= 0;
											if (flag13)
											{
												num++;
											}
											else
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num2);
												int num13 = BitConverter.ToInt32(array2, 0);
												num += num13;
											}
										}
									}
								}
							}
						}
					}
					num8 += 1U;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000DA198 File Offset: 0x000D8398
		public static uint[] smethod_33(GStruct49 gstruct49_0, string string_0, int int_0)
		{
			bool flag = string_0 == null || string_0 == string.Empty;
			if (!flag)
			{
				bool flag2 = int_0 <= 0;
				if (flag2)
				{
					int_0 = 1;
				}
				int num = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				byte[] array3 = new byte[string_0.Length + 4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
				uint num4 = 0U;
				bool flag3 = false;
				uint num9;
				uint num10;
				uint num13;
				uint num14;
				uint num15;
				uint num16;
				int num17;
				int num18;
				for (;;)
				{
					uint num5 = 0U;
					int num6 = Class79.smethod_4(gstruct49_0);
					int num7 = 0;
					uint num8 = 1U;
					while ((ulong)num8 < (ulong)((long)Class53.int_1))
					{
						bool flag4 = num6 <= num7;
						if (flag4)
						{
							break;
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
						num9 = BitConverter.ToUInt32(array2, 0);
						bool flag5 = num9 == 0U;
						if (!flag5)
						{
							num10 = num3 + num9 * Class53.gstruct51_106.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
							bool flag6 = BitConverter.ToInt32(array2, 0) != 0;
							if (!flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, 1, ref num);
								bool flag7 = array[0] == 0;
								if (!flag7)
								{
									num7++;
									num5 = num2 + num8 * 20U;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
									bool flag8 = array[0] != 3;
									if (!flag8)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
										string a = Class10.smethod_3(array3);
										bool flag9 = !(a != string_0);
										if (flag9)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
											int num11 = BitConverter.ToInt32(array2, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num);
											int num12 = BitConverter.ToInt32(array2, 0);
											num4 = num8;
											bool flag10 = num12 <= 0 || num11 <= int_0;
											if (flag10)
											{
												break;
											}
										}
									}
								}
							}
						}
						num8 += 1U;
					}
					bool flag11 = num4 == 0U;
					if (flag11)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num4 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
					num9 = BitConverter.ToUInt32(array2, 0);
					bool flag12 = num9 > 0U;
					if (!flag12)
					{
						goto IL_495;
					}
					num10 = num3 + num9 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_111.uint_0, array2, 1, ref num);
					num13 = (uint)array2[0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_112.uint_0, array2, 1, ref num);
					num14 = (uint)array2[0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
					num15 = (uint)array[0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0, array, 1, ref num);
					num16 = (uint)array[0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
					num17 = BitConverter.ToInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num);
					num18 = BitConverter.ToInt32(array2, 0);
					bool flag13 = num18 > 0 && num17 > int_0;
					if (!flag13)
					{
						goto IL_493;
					}
					uint[] array4 = Class79.smethod_26(gstruct49_0, 3U, num13, num13);
					bool flag14 = array4 != null;
					if (flag14)
					{
						int num19 = 0;
						for (;;)
						{
							bool flag15 = !Class12.bool_0;
							if (!flag15)
							{
								break;
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
							int num20 = BitConverter.ToInt32(array2, 0);
							bool flag16 = num20 <= 0;
							if (!flag16)
							{
								break;
							}
							bool flag17 = num19 % 20 == 0;
							if (flag17)
							{
								Class70.smethod_71(gstruct49_0, num9, (uint)int_0, 89);
							}
							bool flag18 = num19 > 42;
							if (flag18)
							{
								goto Block_20;
							}
							Thread.Sleep(10);
							num19++;
						}
						IL_481:
						num19 = 0;
						while (!Class12.bool_0)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
							bool flag19 = BitConverter.ToInt32(array2, 0) == 0;
							if (flag19)
							{
								break;
							}
							bool flag20 = num19 % 20 == 0;
							if (flag20)
							{
								Class70.smethod_46(gstruct49_0, array4[0], array4[1], 3U, array4[0], array4[1], 3U);
							}
							bool flag21 = num19 <= 42;
							if (!flag21)
							{
								goto IL_5B1;
							}
							Thread.Sleep(10);
							num19++;
						}
						bool flag22 = !flag3;
						if (flag22)
						{
							flag3 = true;
							continue;
						}
						goto IL_5D8;
						goto IL_481;
					}
					goto IL_492;
				}
				return null;
				Block_20:
				IL_492:
				IL_493:
				goto IL_49D;
				IL_495:
				return null;
				IL_49D:
				Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array, 1, ref num);
				uint num21 = (uint)array[0];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_110.uint_0, array, 1, ref num);
				uint num22 = (uint)array[0];
				return new uint[]
				{
					num4,
					num9,
					num15,
					num16,
					num13,
					num14,
					num21,
					num22,
					(uint)num17,
					(uint)num18
				};
				IL_5B1:
				Class70.smethod_46(gstruct49_0, num15, num16, 3U, num15, num16, 3U);
				IL_5D8:
				goto IL_49D;
			}
			return null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000DA794 File Offset: 0x000D8994
		public static string[] smethod_34(GStruct49 gstruct49_0, string[] string_0 = null, int int_0 = 3)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			byte[] array3 = new byte[80];
			string[] result = null;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				bool flag = num7 == 0U;
				if (!flag)
				{
					uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag3 = array[0] == 0;
						if (!flag3)
						{
							num5++;
							uint num9 = num2 + num6 * 20U;
							bool flag4 = int_0 > 0;
							if (flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag5 = (int)array[0] != int_0;
								if (flag5)
								{
									goto IL_1FF;
								}
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
							string text = Class10.smethod_3(array3);
							bool flag6 = false;
							bool flag7 = string_0 != null;
							if (flag7)
							{
								for (int i = 0; i < string_0.Length; i++)
								{
									bool flag8 = text == string_0[i];
									if (flag8)
									{
										flag6 = true;
										break;
									}
								}
							}
							bool flag9 = !flag6;
							if (flag9)
							{
								Class12.smethod_29(ref result, text);
							}
						}
					}
				}
				IL_1FF:
				num6 += 1U;
			}
			return result;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000DA9CC File Offset: 0x000D8BCC
		public static void smethod_35(GStruct49 gstruct49_0, ref string[] string_0, int int_0 = 3, int[] int_1 = null, bool bool_1 = false)
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
			while ((ulong)num6 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				uint num7 = num2 + num6 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array2, 0);
				bool flag = num8 == 0U;
				if (!flag)
				{
					uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag3 = array[0] == 0;
						if (!flag3)
						{
							num5++;
							bool flag4 = int_0 > 0;
							if (flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag5 = (int)array[0] != int_0;
								if (flag5)
								{
									goto IL_2A4;
								}
							}
							bool flag6 = false;
							bool flag7 = int_1 != null;
							if (flag7)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								int num10 = (int)array[0];
								for (int i = 0; i < int_1.Length; i++)
								{
									bool flag8 = num10 == int_1[i];
									if (flag8)
									{
										flag6 = true;
										break;
									}
								}
								bool flag9 = (bool_1 && !flag6) || (!bool_1 && flag6);
								if (flag9)
								{
									goto IL_2A4;
								}
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
							string text = Class10.smethod_3(array3);
							bool flag10 = string_0 != null;
							if (flag10)
							{
								flag6 = false;
								bool flag11 = string_0 != null;
								if (flag11)
								{
									for (int j = 0; j < string_0.Length; j++)
									{
										bool flag12 = text == string_0[j];
										if (flag12)
										{
											flag6 = true;
											break;
										}
									}
								}
								bool flag13 = !flag6;
								if (flag13)
								{
									Array.Resize<string>(ref string_0, string_0.Length + 1);
									string_0[string_0.Length - 1] = text;
								}
							}
							else
							{
								string_0 = new string[]
								{
									text
								};
							}
						}
					}
				}
				IL_2A4:
				num6 += 1U;
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000DACA0 File Offset: 0x000D8EA0
		public static GStruct57[] smethod_36(GStruct49 gstruct49_0, object object_0 = null, int[] int_0 = null, bool bool_1 = false)
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
			int[] array4 = null;
			bool flag = object_0 != null;
			if (flag)
			{
				int[] array5;
				if (object_0.GetType().ToString().IndexOf("[") > 0)
				{
					array5 = (int[])object_0;
				}
				else
				{
					(array5 = new int[1])[0] = Class12.smethod_11(object_0.ToString());
				}
				array4 = array5;
			}
			GStruct57[] array6 = null;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				bool flag2 = num7 == 0U;
				if (!flag2)
				{
					uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num5++;
							uint num9 = num2 + num6 * 20U;
							bool flag5 = array4 != null;
							if (flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								int num10 = (int)array[0];
								bool flag6 = false;
								for (int i = 0; i < array4.Length; i++)
								{
									bool flag7 = num10 == array4[i];
									if (flag7)
									{
										flag6 = true;
										break;
									}
								}
								bool flag8 = !flag6;
								if (flag8)
								{
									goto IL_37B;
								}
							}
							bool flag9 = false;
							bool flag10 = int_0 != null;
							if (flag10)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								int num11 = (int)array[0];
								for (int j = 0; j < int_0.Length; j++)
								{
									bool flag11 = num11 == int_0[j];
									if (flag11)
									{
										flag9 = true;
										break;
									}
								}
								bool flag12 = (bool_1 && !flag9) || (!bool_1 && flag9);
								if (flag12)
								{
									goto IL_37B;
								}
							}
							bool flag13 = array6 == null;
							if (flag13)
							{
								array6 = new GStruct57[1];
							}
							else
							{
								Array.Resize<GStruct57>(ref array6, array6.Length + 1);
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
							array6[array6.Length - 1].string_0 = Class10.smethod_3(array3);
							array6[array6.Length - 1].uint_0 = num6;
							array6[array6.Length - 1].uint_1 = num7;
							bool flag14 = Class53.uint_0 != null;
							if (flag14)
							{
								array6[array6.Length - 1].int_0 = new int[Class53.uint_0.Length];
								for (int k = 0; k < Class53.uint_0.Length; k++)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.uint_0[k], array2, 4, ref num);
									array6[array6.Length - 1].int_0[k] = BitConverter.ToInt32(array2, 0);
								}
							}
						}
					}
				}
				IL_37B:
				num6 += 1U;
			}
			return array6;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000DB054 File Offset: 0x000D9254
		public static GStruct32[] smethod_37(GStruct49 gstruct49_0, int int_0, int int_1, bool bool_1 = true)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] byte_ = new byte[29];
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int int_2 = 7;
			string text = string.Empty;
			GStruct32[] array3 = null;
			uint num5 = Class36.smethod_41(gstruct49_0, false);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num6 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			uint num8 = num7 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
			uint num9 = BitConverter.ToUInt32(array2, 0);
			uint num10 = num9 + num8;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_43.uint_0, array2, 4, ref num);
			int num11 = BitConverter.ToInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
			int num12 = BitConverter.ToInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num13 = BitConverter.ToUInt32(array2, 0);
			uint num14 = num6 + Class53.gstruct51_97.uint_0;
			int num15 = Class79.smethod_4(gstruct49_0);
			int num16 = 0;
			uint num17 = 1U;
			while ((ulong)num17 < (ulong)((long)Class53.int_1))
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_43.uint_0, array2, 4, ref num);
				int num18 = BitConverter.ToInt32(array2, 0);
				bool flag3 = num18 != num11;
				if (flag3)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
				int num19 = BitConverter.ToInt32(array2, 0);
				bool flag4 = num19 != num12;
				if (flag4)
				{
					break;
				}
				int num20 = 0;
				while (Class83.smethod_12(gstruct49_0) == 1)
				{
					Thread.Sleep(100);
					bool flag5 = num20 > 100;
					if (flag5)
					{
						break;
					}
					num20++;
				}
				bool flag6 = num15 <= num16;
				if (flag6)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + (num17 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
				uint num21 = BitConverter.ToUInt32(array2, 0);
				bool flag7 = num21 == 0U;
				if (!flag7)
				{
					uint num22 = num13 + num21 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag8 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag8)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag9 = array[0] == 0;
						if (!flag9)
						{
							num16++;
							uint num23 = num14 + num17 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num23 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							int num24 = (int)array[0];
							bool flag10 = num24 != 2;
							if (!flag10)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								int num25 = (int)array[0];
								bool flag11 = num25 != 0;
								if (!flag11)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_110.uint_0, array, 1, ref num);
									int num26 = (int)array[0];
									bool flag12 = num26 == 3 || num26 == 4 || num26 > 8;
									if (!flag12)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
										int num27 = BitConverter.ToInt32(array2, 0);
										bool flag13 = num27 <= 0;
										if (!flag13)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num);
											int num28 = BitConverter.ToInt32(array2, 0);
											bool flag14 = num28 <= 0 || num28 <= num27 || ((int_1 <= 0 || num27 > int_1) && (int_0 <= 0 || num27 * 100 / num28 > int_0) && (int_1 > 0 || int_0 > 0));
											if (!flag14)
											{
												string text2 = null;
												string text3 = null;
												int i = 0;
												int num29 = 0;
												bool flag15 = !flag && num11 <= 0;
												if (flag15)
												{
													uint num30 = Class36.smethod_41(gstruct49_0, true);
													bool flag16 = Form1.int_61[0] <= 0;
													if (flag16)
													{
														bool flag17 = num30 > 6000000U;
														if (flag17)
														{
															num30 = 6000000U;
														}
													}
													else
													{
														bool flag18 = (ulong)num30 > (ulong)((long)(Form1.int_61[1] * 10000));
														if (flag18)
														{
															num30 = (uint)(Form1.int_61[1] * 10000);
														}
													}
													bool flag19 = num30 != 0U && Class70.smethod_37(gstruct49_0, num30);
													if (flag19)
													{
														while (i < 10)
														{
															Thread.Sleep(100);
															Class36.smethod_41(gstruct49_0, true);
															bool flag20 = Class36.smethod_41(gstruct49_0, true) != num30;
															if (flag20)
															{
																break;
															}
															i++;
														}
													}
													flag = true;
												}
												uint num31 = Class36.smethod_41(gstruct49_0, false);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_107.uint_0, byte_, 29, ref num);
												string text4 = Class10.smethod_3(byte_);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_119.uint_0 + Class79.uint_0, array2, 4, ref num);
												int num32 = BitConverter.ToInt32(array2, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_109.uint_0, array2, 4, ref num);
												int num33 = BitConverter.ToInt32(array2, 0);
												bool flag21 = num33 != 1 && num33 != 4;
												if (!flag21)
												{
													goto IL_645;
												}
												int num34 = Class70.smethod_22(gstruct49_0, num21);
												bool flag22 = num34 > 0;
												if (!flag22)
												{
													goto IL_645;
												}
												bool flag23 = (long)num34 > (long)((ulong)num31);
												if (flag23)
												{
													uint num35 = Class36.smethod_41(gstruct49_0, true);
													bool flag24 = num35 == 0U || (long)num34 - (long)((ulong)num31) > (long)((ulong)num35);
													if (flag24)
													{
														num29 = 1;
														goto IL_9BE;
													}
													Class70.smethod_37(gstruct49_0, (uint)((long)num34 - (long)((ulong)num31)));
													Thread.Sleep(150);
												}
												bool flag25 = !flag2 && (bool_1 || num11 > 0);
												if (flag25)
												{
													Class83.smethod_4(gstruct49_0);
													Thread.Sleep(600 - num11 * 300);
													Class70.smethod_27(gstruct49_0);
													flag2 = true;
												}
												Class70.smethod_20(gstruct49_0, num21);
												IL_9BE:
												Thread.Sleep(100);
												bool flag26 = num2 > 0;
												if (flag26)
												{
													Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
													num2 = 0;
												}
												num4 += num29;
												string text5 = string.Empty;
												text5 = ((num29 > 0) ? Class12.smethod_60("...", int_2, ' ') : ((text2 != null || text3 != null) ? Class12.smethod_60(text2 + "," + text3, int_2, ' ') : ((num34 <= 0) ? Class12.smethod_60("Bá qua", int_2, ' ') : Class12.smethod_60(num34, int_2, ' '))));
												object obj = text;
												text = string.Concat(new object[]
												{
													obj,
													'\r',
													Class12.smethod_60(num27.ToString() + "/" + num28.ToString(), int_2, ' '),
													"|",
													text5,
													"|",
													text4
												});
												bool flag27 = array3 == null;
												if (flag27)
												{
													array3 = new GStruct32[1];
												}
												else
												{
													Array.Resize<GStruct32>(ref array3, array3.Length + 1);
												}
												int num36 = array3.Length - 1;
												num22 = num13 + num21 * Class53.gstruct51_106.uint_0;
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
												num27 = BitConverter.ToInt32(array2, 0);
												array3[num36].int_0 = num27;
												array3[num36].int_1 = num28;
												array3[num36].int_2 = num32;
												array3[num36].int_3 = num33;
												array3[num36].uint_0 = num17;
												array3[num36].uint_1 = num21;
												array3[num36].string_0 = text4;
												goto IL_B82;
												IL_645:
												bool flag28 = num33 != 4 || (Form1.int_58 > 0 && num32 <= 5);
												if (flag28)
												{
													Class86.smethod_8(gstruct49_0, -1);
													bool flag29 = !flag2 && (bool_1 || num11 > 0);
													if (flag29)
													{
														Class83.smethod_4(gstruct49_0);
														Thread.Sleep(600 - num11 * 300);
														Class70.smethod_27(gstruct49_0);
														flag2 = true;
													}
													i = 0;
													while (i < 100 && Class70.smethod_3(gstruct49_0, Class70.uint_5, 4) > 0)
													{
														i++;
														Thread.Sleep(100);
													}
													num2 = 1;
													num3++;
													Class70.smethod_2(gstruct49_0, Class70.uint_5, 1, 4);
													Class70.smethod_20(gstruct49_0, num21);
													i = 0;
													int num37 = 0;
													for (;;)
													{
														bool flag30 = num37 <= 0;
														if (!flag30)
														{
															goto IL_770;
														}
														Thread.Sleep(30);
														bool flag31 = 0 <= Class86.smethod_0(gstruct49_0);
														if (flag31)
														{
															num25 = Class86.smethod_0(gstruct49_0);
															num37 = Class86.smethod_1(gstruct49_0, num25);
														}
														bool flag32 = i <= 35;
														if (!flag32)
														{
															goto IL_768;
														}
														i++;
													}
													IL_9B6:
													goto IL_9BC;
													IL_770:
													int num38 = -1;
													string text6 = null;
													for (int j = 0; j < num37; j++)
													{
														string text7 = Class86.smethod_3(gstruct49_0, j, num25, 128);
														string string_ = text7.ToLower();
														bool flag33 = Class12.smethod_1(string_, "Söa".ToLower()) >= 0;
														if (flag33)
														{
															num38 = j;
															text6 = text7;
															bool flag34 = 0 <= Class12.smethod_1(string_, "kü".ToLower());
															if (flag34)
															{
																break;
															}
														}
													}
													bool flag35 = num38 < 0;
													if (flag35)
													{
														Class86.smethod_8(gstruct49_0, -1);
														num34 = 0;
														goto IL_9B6;
													}
													int num39 = 0;
													int num40 = 0;
													for (int k = 0; k < text6.Length; k++)
													{
														bool flag36 = '0' <= text6[k] && text6[k] <= '9';
														bool flag37 = num39 != 0 || !flag36;
														if (flag37)
														{
															bool flag38 = num39 == 1 && !flag36;
															if (flag38)
															{
																num39 = 2;
															}
														}
														else
														{
															num39 = 1;
														}
														bool flag39 = num39 == 1;
														if (flag39)
														{
															text2 += text6[k].ToString();
														}
														bool flag40 = num39 == 2;
														if (flag40)
														{
															bool flag41 = num40 == 0 && flag36;
															if (flag41)
															{
																num40 = 1;
															}
															else
															{
																bool flag42 = num40 == 1 && !flag36;
																if (flag42)
																{
																	break;
																}
															}
															bool flag43 = num40 == 1;
															if (flag43)
															{
																text3 += text6[k].ToString();
															}
														}
													}
													num34 = Class12.smethod_11(text2) * 10000 + Class12.smethod_11(text3);
													bool flag44 = (long)num34 > (long)((ulong)num31);
													if (flag44)
													{
														Class86.smethod_8(gstruct49_0, -1);
														num29 = 1;
														goto IL_9B6;
													}
													i = 0;
													Class86.smethod_5(gstruct49_0, num38);
													while (!Class12.bool_0)
													{
														Thread.Sleep(30);
														bool flag45 = !Class86.Class89.smethod_4(gstruct49_0);
														if (!flag45)
														{
															Class86.Class89.smethod_5(gstruct49_0);
															break;
														}
														bool flag46 = Class86.smethod_0(gstruct49_0) < 0;
														if (flag46)
														{
															break;
														}
														bool flag47 = i <= 30;
														if (!flag47)
														{
															Class86.smethod_8(gstruct49_0, -1);
															break;
														}
														i++;
													}
													goto IL_9B6;
													IL_768:
													num34 = 0;
												}
												else
												{
													num34 = 0;
												}
												IL_9BC:
												goto IL_9BE;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_B82:
				num17 += 1U;
			}
			bool flag48 = flag;
			if (flag48)
			{
				uint num41 = Class36.smethod_41(gstruct49_0, false);
				bool flag49 = num41 > num5;
				if (flag49)
				{
					Class70.smethod_38(gstruct49_0, num41 - num5);
				}
			}
			bool flag50 = text != null && text != string.Empty;
			if (flag50)
			{
				string text8 = string.Empty;
				bool flag51 = num4 > 0;
				if (flag51)
				{
					text8 = " (thiÕu tiÒn söa: " + num4.ToString() + ")";
				}
				bool flag52 = Form1.int_65 > 0;
				if (flag52)
				{
					Class70.smethod_52(gstruct49_0, text, 1);
				}
				else
				{
					Class70.smethod_52(gstruct49_0, string.Concat(new string[]
					{
						"<bclr=yellow>Söa §å T¹i Chç",
						text8,
						"<bclr><color=green>\r",
						Class12.smethod_60("§é bÒn", int_2, ' '),
						"|",
						Class12.smethod_60("TiÒn", int_2, ' '),
						"|Tªn trang bÞ<bclr=blue>",
						text
					}), 1);
				}
			}
			Thread.Sleep(300);
			bool flag53 = array3 != null;
			if (flag53)
			{
				for (int l = 0; l < array3.Length; l++)
				{
					uint num42 = num13 + array3[l].uint_1 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num42 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
					array3[l].int_0 = BitConverter.ToInt32(array2, 0);
				}
			}
			bool flag54 = num3 > 0;
			if (flag54)
			{
				Class86.smethod_8(gstruct49_0, -1);
				Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			num6 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
			num7 = BitConverter.ToUInt32(array2, 0);
			num8 = num7 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
			num9 = BitConverter.ToUInt32(array2, 0);
			num10 = num9 + num8;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_43.uint_0, array2, 4, ref num);
			int num43 = BitConverter.ToInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
			int num44 = BitConverter.ToInt32(array2, 0);
			bool flag55 = num43 != num11 || num44 != num12;
			if (flag55)
			{
				array3 = new GStruct32[]
				{
					new GStruct32
					{
						string_0 = "CHANGE"
					}
				};
			}
			return array3;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000DBEA0 File Offset: 0x000DA0A0
		public static uint[,] smethod_38(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			string text = "ThÇn Hµnh Phï";
			string value = text.Replace(" ", string.Empty).ToLower();
			byte[] array3 = new byte[text.Length + 2];
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint[,] array4 = new uint[2, 2];
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				bool flag2 = array4[1, 0] != 0U && array4[0, 0] > 0U;
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
							uint num9 = num2 + num6 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							int num10 = (int)array[0];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array, 1, ref num);
							int num11 = (int)array[0];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_110.uint_0, array, 1, ref num);
							int num12 = (int)array[0];
							bool flag6 = num10 != 3;
							if (flag6)
							{
								bool flag7 = num10 == 2 && num11 == 0 && num12 == 10;
								if (flag7)
								{
									array4[0, 0] = num6;
									array4[0, 1] = num7;
								}
							}
							else
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
								string text2 = Class10.smethod_3(array3);
								bool flag8 = !(text2 != text) || text2.Replace(" ", string.Empty).ToLower().IndexOf(value) >= 0;
								if (flag8)
								{
									array4[1, 0] = num6;
									array4[1, 1] = num7;
								}
							}
						}
					}
				}
				num6 += 1U;
			}
			return array4;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000DC198 File Offset: 0x000DA398
		public static uint[] smethod_39(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[25];
			string[] array4 = new string[]
			{
				"th????a?ph",
				"h?i?th?nh?ph",
				"ÍÁµØ·û"
			};
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array2, 0);
				bool flag = num7 == 0U;
				if (!flag)
				{
					uint num8 = num2 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag3 = array[0] == 0;
						if (!flag3)
						{
							num5++;
							uint num9 = num3 + num6 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							int num10 = (int)array[0];
							bool flag4 = num10 != 3;
							if (!flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								int num11 = (int)array[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_110.uint_0, array, 1, ref num);
								int num12 = (int)array[0];
								bool flag5 = num11 != 5 || num12 != 0;
								if (flag5)
								{
									bool flag6 = num11 != 6 || num12 != 1;
									if (flag6)
									{
										goto IL_335;
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
									bool flag7 = true;
									for (int i = 0; i < array4.Length; i++)
									{
										flag7 = true;
										char[] array5 = array4[i].ToCharArray();
										for (int j = 0; j < array5.Length; j++)
										{
											byte b = array3[j];
											char c = array5[j];
											bool flag8 = c != '?' && (char)b != c && (b < 65 || 90 < b || (char)(b + 32) != c);
											if (flag8)
											{
												flag7 = false;
												break;
											}
										}
										bool flag9 = flag7;
										if (flag9)
										{
											break;
										}
									}
									bool flag10 = !flag7;
									if (flag10)
									{
										goto IL_335;
									}
								}
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
								uint num13 = (uint)array[0];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0, array, 1, ref num);
								uint num14 = (uint)array[0];
								return new uint[]
								{
									num7,
									num6,
									num13,
									num14
								};
							}
						}
					}
				}
				IL_335:
				num6 += 1U;
			}
			return null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000DC504 File Offset: 0x000DA704
		public static string smethod_40(GStruct49 gstruct49_0)
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
			string text = "ID\tIdex\tBox\tKind\tGenre\tParticular\tChungLoai\tWidth\tHeigh\tName\tNameU\t 6 dòng thuộc tính {ID:Min:Max}...";
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				uint num7 = num2 + num6 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array2, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					string text2 = num6.ToString() + "\t" + num8.ToString();
					uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num5++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							text2 = text2 + "\t" + array[0].ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_108.uint_0, array2, 1, ref num);
							text2 = text2 + "\t" + array2[0].ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_110.uint_0, array2, 4, ref num);
							text2 = text2 + "\t" + BitConverter.ToInt32(array2, 0).ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class79.uint_1, array2, 4, ref num);
							text2 = text2 + "\t" + BitConverter.ToInt32(array2, 0).ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class79.uint_1 + 4U, array2, 4, ref num);
							text2 = text2 + "\t" + BitConverter.ToInt32(array2, 0).ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array2, 1, ref num);
							text2 = text2 + "\t" + array2[0].ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array2, 1, ref num);
							text2 = text2 + "\t" + array2[0].ToString();
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
							string text3 = Class10.smethod_3(array3);
							string text4 = text2;
							text2 = string.Concat(new string[]
							{
								text4,
								"\t|",
								text3,
								"|\t|",
								Class10.smethod_1(text3, 1, false),
								"|"
							});
							string text5 = string.Empty;
							for (uint num10 = 0U; num10 < 6U; num10 += 1U)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num10 * 16U, array2, 4, ref num);
								int num11 = BitConverter.ToInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num10 * 16U + 4U, array2, 4, ref num);
								int num12 = BitConverter.ToInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_118.uint_0 + num10 * 16U + 12U, array2, 4, ref num);
								int num13 = BitConverter.ToInt32(array2, 0);
								bool flag5 = text5 != string.Empty;
								if (flag5)
								{
									text5 += " ";
								}
								object obj = text5;
								text5 = string.Concat(new object[]
								{
									obj,
									num10,
									"{",
									num11,
									":",
									num12,
									":",
									num13,
									"}"
								});
							}
							text2 = text2 + "\t" + text5;
							text = text + Class53.string_7 + text2;
						}
					}
				}
				num6 += 1U;
			}
			return text;
		}

		// Token: 0x040003B0 RID: 944
		public static bool bool_0 = false;

		// Token: 0x040003B1 RID: 945
		public static uint uint_0 = 48U;

		// Token: 0x040003B2 RID: 946
		public static uint uint_1 = 16U;
	}
}
