using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000020 RID: 32
	internal class Class36
	{
		// Token: 0x0600021E RID: 542 RVA: 0x00050858 File Offset: 0x0004EA58
		public static uint smethod_0(uint[] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 != null && uint_1 != null && uint_0[0] != 0U && uint_0[1] != 0U && uint_1[0] > 0U;
			if (flag)
			{
				bool flag2 = uint_1[1] > 0U;
				if (flag2)
				{
					long num = (long)(uint_0[0] - uint_1[0]);
					long num2 = (long)(uint_0[1] - uint_1[1]);
					long num3 = num * num + num2 * num2;
					bool flag3 = num3 == 0L;
					if (flag3)
					{
						num3 = 1L;
					}
					return (uint)num3;
				}
			}
			return 2147483647U;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000508D4 File Offset: 0x0004EAD4
		public static uint smethod_1(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			return num3 + num2;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00050938 File Offset: 0x0004EB38
		private static void smethod_2(GStruct49 gstruct49_0, uint uint_0, int int_0)
		{
			uint num = Class36.smethod_1(gstruct49_0);
			Class22.smethod_31(num + uint_0, gstruct49_0.int_137, (uint)int_0, 4);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00050960 File Offset: 0x0004EB60
		private static uint smethod_3(GStruct49 gstruct49_0, uint uint_0)
		{
			uint num = Class36.smethod_1(gstruct49_0);
			return Class22.smethod_30(num + uint_0, gstruct49_0.int_137);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00050988 File Offset: 0x0004EB88
		public static int smethod_4(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			int num5 = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_85.uint_0, array, 4, ref num5);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00050A20 File Offset: 0x0004EC20
		public static string smethod_5(GStruct49 gstruct49_0)
		{
			string result = Class36.string_0;
			bool flag = gstruct49_0.int_137 > 0;
			if (flag)
			{
				uint num = Class36.smethod_1(gstruct49_0);
				string text = Class22.smethod_28(num + Class53.gstruct51_16.uint_0, gstruct49_0.int_137, 40);
				bool flag2 = text != "";
				if (flag2)
				{
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00050A80 File Offset: 0x0004EC80
		public static int smethod_6(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_11.uint_0 > 0U;
			if (flag)
			{
				bool flag2 = Class53.gstruct51_23.uint_0 == 0U;
				if (!flag2)
				{
					uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
					return (int)Class22.smethod_30(num + Class53.gstruct51_23.uint_0, gstruct49_0.int_137);
				}
			}
			return 0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00050AF4 File Offset: 0x0004ECF4
		public static bool smethod_7(GStruct49 gstruct49_0, ref GStruct43 gstruct43_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_30.uint_0;
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_61.uint_0, gstruct49_0.int_137);
			bool flag = num2 > 0U;
			if (flag)
			{
				bool flag2 = gstruct43_0.uint_0 != num2;
				if (flag2)
				{
					gstruct43_0.uint_0 = num2;
					gstruct43_0.uint_1 = Class22.smethod_30(num + 12U, gstruct49_0.int_137);
					gstruct43_0.uint_2 = Class22.smethod_30(num + Class53.gstruct51_62.uint_0, gstruct49_0.int_137);
					gstruct43_0.string_0 = Class22.smethod_28(num + Class53.gstruct51_60.uint_0, gstruct49_0.int_137, 32);
					gstruct43_0.bool_0 = false;
				}
			}
			else
			{
				bool flag3 = gstruct43_0.uint_0 > 0U;
				if (flag3)
				{
					gstruct43_0.uint_0 = 0U;
					gstruct43_0.string_0 = null;
				}
			}
			return num2 > 0U;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00050BE4 File Offset: 0x0004EDE4
		public static int smethod_8(GStruct49 gstruct49_0, uint uint_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			int num4 = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num4);
			int num5 = BitConverter.ToInt32(array, 0);
			bool flag = num5 > 1;
			int result;
			if (flag)
			{
				int num6 = 0;
				int i = 1;
				while (i < 256)
				{
					bool flag2 = num5 <= num6;
					if (flag2)
					{
						break;
					}
					bool flag3 = (long)i != (long)((ulong)num3);
					if (flag3)
					{
						uint num7 = num + (uint)(i * (int)Class53.gstruct51_15.uint_0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_16.uint_0, array, 4, ref num4);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num6++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_50.uint_0, array, 4, ref num4);
							bool flag5 = BitConverter.ToInt32(array, 0) <= 0 || Class22.smethod_30(num7 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137) <= 0U;
							if (!flag5)
							{
								int num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
								bool flag6 = num8 != 10 && num8 != 21;
								if (flag6)
								{
									int num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
									bool flag7 = num9 == 1 && uint_0 == Class22.smethod_30(num7, gstruct49_0.int_137);
									if (flag7)
									{
										return i;
									}
								}
							}
						}
					}
					else
					{
						num6++;
					}
					IL_1E4:
					i++;
					continue;
					goto IL_1E4;
				}
				result = 0;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00050DFC File Offset: 0x0004EFFC
		public static int[] smethod_9(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_32.uint_0, gstruct49_0.int_137);
			bool flag = num == 0U;
			int[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3;
				uint num6 = Class22.smethod_30(num5 + 4160U, gstruct49_0.int_137);
				uint num7 = Class22.smethod_30(num + Class53.gstruct51_34.uint_0, gstruct49_0.int_137);
				uint num8 = Class22.smethod_30(num7 + num6 * Class53.gstruct51_33.uint_0 + Class53.gstruct51_40.uint_0, gstruct49_0.int_137);
				int[] array = null;
				while (num8 > 0U)
				{
					uint num9 = Class22.smethod_30(num8 + 4U, gstruct49_0.int_137);
					uint num10 = Class22.smethod_30(num8 + 16U, gstruct49_0.int_137);
					uint num11 = Class22.smethod_30(Class53.gstruct51_41.uint_0, gstruct49_0.int_137);
					num8 = num9;
					bool flag2 = num11 == 0U;
					if (!flag2)
					{
						uint uint_ = num10 * Class53.gstruct51_15.uint_0 + num11 + Class53.gstruct51_42.uint_0;
						uint num12 = Class22.smethod_30(uint_, gstruct49_0.int_137);
						while (num12 > 0U)
						{
							uint num13 = Class22.smethod_30(num12 + 4U, gstruct49_0.int_137);
							int num14 = (int)Class22.smethod_30(num12 + 24U, gstruct49_0.int_137);
							num12 = num13;
							bool flag3 = num14 > 0 && num14 < 6001;
							if (flag3)
							{
								Class12.smethod_37(ref array, num14);
							}
						}
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00050FD4 File Offset: 0x0004F1D4
		public static bool smethod_10(GStruct49 gstruct49_0, uint uint_0)
		{
			bool bool_ = gstruct49_0.bool_23;
			bool result;
			if (bool_)
			{
				result = true;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint uint_ = num3 + num2 + Class53.gstruct51_72.uint_0;
				result = Class22.smethod_31(uint_, gstruct49_0.int_137, uint_0, 4);
			}
			return result;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00051068 File Offset: 0x0004F268
		public static void smethod_11(GStruct49 gstruct49_0, int int_0, uint uint_0 = 0U)
		{
			uint uint_ = 5U;
			uint uint_2 = uint.MaxValue;
			uint uint_3 = uint_0;
			uint num = Class36.smethod_1(gstruct49_0);
			bool flag = uint_0 == 0U;
			if (flag)
			{
				uint_2 = Class22.smethod_30(num + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
				uint_3 = Class22.smethod_30(num + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
			}
			Class22.smethod_31(num + Class53.gstruct51_37.uint_0, gstruct49_0.int_137, uint_2, 4);
			Class22.smethod_31(num + Class53.gstruct51_38.uint_0, gstruct49_0.int_137, uint_3, 4);
			Class22.smethod_31(num + Class53.gstruct51_36.uint_0, gstruct49_0.int_137, (uint)int_0, 4);
			Class22.smethod_31(num + Class53.gstruct51_35.uint_0, gstruct49_0.int_137, uint_, 4);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00051140 File Offset: 0x0004F340
		public static string smethod_12(GStruct49 gstruct49_0)
		{
			uint num = Class36.smethod_1(gstruct49_0);
			string result = "";
			bool flag = gstruct49_0.int_137 > 0 && num > 0U;
			if (flag)
			{
				result = Class22.smethod_28(num + Class53.gstruct51_89.uint_0, gstruct49_0.int_137, 32);
			}
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00051190 File Offset: 0x0004F390
		public static uint smethod_13(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			return Class22.smethod_30(num4 + Class53.gstruct51_88.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00051210 File Offset: 0x0004F410
		public static int smethod_14(GStruct49 gstruct49_0, uint uint_0 = 0U, uint uint_1 = 0U)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			bool flag = uint_1 > 0U;
			uint uint_2;
			if (flag)
			{
				switch (uint_0)
				{
				case 0U:
					uint_2 = Class53.gstruct51_78.uint_0;
					break;
				case 1U:
					uint_2 = Class53.gstruct51_80.uint_0;
					break;
				case 2U:
					uint_2 = Class53.gstruct51_82.uint_0;
					break;
				default:
					uint_2 = Class53.gstruct51_84.uint_0;
					break;
				}
			}
			else
			{
				switch (uint_0)
				{
				case 0U:
					uint_2 = Class53.gstruct51_77.uint_0;
					break;
				case 1U:
					uint_2 = Class53.gstruct51_79.uint_0;
					break;
				case 2U:
					uint_2 = Class53.gstruct51_81.uint_0;
					break;
				default:
					uint_2 = Class53.gstruct51_83.uint_0;
					break;
				}
			}
			return (int)Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + uint_2, gstruct49_0.int_137);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00051304 File Offset: 0x0004F504
		public static int smethod_15(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return (int)Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + Class53.gstruct51_76.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00051350 File Offset: 0x0004F550
		public static int smethod_16(GStruct49 gstruct49_0)
		{
			uint uint_ = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return (int)Class22.smethod_30(uint_, gstruct49_0.int_137);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00051384 File Offset: 0x0004F584
		public static int smethod_17(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000513C4 File Offset: 0x0004F5C4
		public static bool smethod_18(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_105.uint_0 != 0U && Class53.gstruct51_106.uint_0 != 0U && Class53.gstruct51_110.uint_0 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
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
								bool flag6 = array[0] == 2;
								if (flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_110.uint_0, array, 1, ref num);
									uint num10 = (uint)array[0];
									bool flag7 = num10 == 10U;
									if (flag7)
									{
										return true;
									}
								}
							}
						}
					}
					num6 += 1U;
				}
				result = false;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000515D0 File Offset: 0x0004F7D0
		public static bool smethod_19(GStruct49 gstruct49_0)
		{
			int num = (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_44.uint_0);
			return num > 0;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000515F8 File Offset: 0x0004F7F8
		public static long smethod_20(GStruct49 gstruct49_0)
		{
			return (long)((ulong)Class36.smethod_3(gstruct49_0, Class53.gstruct51_45.uint_0));
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0005161C File Offset: 0x0004F81C
		public static long smethod_21(GStruct49 gstruct49_0)
		{
			return (long)((ulong)Class36.smethod_3(gstruct49_0, Class53.gstruct51_47.uint_0));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00051640 File Offset: 0x0004F840
		public static long smethod_22(GStruct49 gstruct49_0)
		{
			return (long)((ulong)Class36.smethod_3(gstruct49_0, Class53.gstruct51_47.uint_0 + 4U));
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00051668 File Offset: 0x0004F868
		public static long smethod_23(GStruct49 gstruct49_0)
		{
			return (long)((ulong)Class36.smethod_3(gstruct49_0, Class53.gstruct51_46.uint_0));
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0005168C File Offset: 0x0004F88C
		public static long smethod_24(GStruct49 gstruct49_0)
		{
			return (long)((ulong)Class36.smethod_3(gstruct49_0, Class53.gstruct51_48.uint_0));
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000516B0 File Offset: 0x0004F8B0
		public static long smethod_25(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_12.uint_0;
			int num3 = 0;
			byte[] array = new byte[8];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_24.uint_0, array, 8, ref num3);
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00051714 File Offset: 0x0004F914
		public static long smethod_26(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_12.uint_0;
			int num3 = 0;
			byte[] array = new byte[8];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_24.uint_0 + 8U, array, 8, ref num3);
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0005177C File Offset: 0x0004F97C
		public static int smethod_27(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_43.uint_0);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000517A0 File Offset: 0x0004F9A0
		public static int smethod_28(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_50.uint_0);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000517C4 File Offset: 0x0004F9C4
		public static int smethod_29(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_53.uint_0);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000517E8 File Offset: 0x0004F9E8
		public static uint[] smethod_30(GStruct49 gstruct49_0)
		{
			uint num = Class36.smethod_3(gstruct49_0, Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0);
			uint num2 = Class36.smethod_3(gstruct49_0, Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0);
			bool flag = num > 0U;
			if (flag)
			{
				bool flag2 = num2 > 0U;
				if (flag2)
				{
					return new uint[]
					{
						num,
						num2
					};
				}
			}
			return null;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00051864 File Offset: 0x0004FA64
		public static int smethod_31(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_55.uint_0);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00051888 File Offset: 0x0004FA88
		public static int smethod_32(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_66.uint_0);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000518AC File Offset: 0x0004FAAC
		public static int smethod_33(GStruct49 gstruct49_0)
		{
			int num = (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_54.uint_0);
			bool flag = num > 4;
			if (flag)
			{
				num = 5;
			}
			return num;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000518DC File Offset: 0x0004FADC
		public static int smethod_34(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_51.uint_0);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00051900 File Offset: 0x0004FB00
		public static int smethod_35(GStruct49 gstruct49_0)
		{
			return (int)Class36.smethod_3(gstruct49_0, Class53.gstruct51_56.uint_0);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00051924 File Offset: 0x0004FB24
		public static bool smethod_36(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_30.uint_0 + Class53.gstruct51_62.uint_0, gstruct49_0.int_137);
			return num2 == 2U;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00051974 File Offset: 0x0004FB74
		public static uint smethod_37(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return Class22.smethod_30(num + Class53.gstruct51_30.uint_0 + Class53.gstruct51_61.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000519C0 File Offset: 0x0004FBC0
		public static int smethod_38(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_30.uint_0 + Class53.gstruct51_61.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num4 = 0;
			byte[] array = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num4);
			int num5 = BitConverter.ToInt32(array, 0);
			bool flag = num5 > 1;
			int result;
			if (flag)
			{
				int num6 = (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				int num7 = 0;
				for (uint num8 = 1U; num8 < 256U; num8 += 1U)
				{
					bool flag2 = num5 <= num7;
					if (flag2)
					{
						break;
					}
					bool flag3 = (ulong)num8 == (ulong)((long)num6);
					if (flag3)
					{
						num7++;
					}
					else
					{
						uint num9 = num3 + num8 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_16.uint_0, array, 4, ref num4);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num7++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_50.uint_0, array, 4, ref num4);
							bool flag5 = BitConverter.ToInt32(array, 0) > 0;
							if (flag5)
							{
								uint num10 = Class22.smethod_30(num9, gstruct49_0.int_137);
								bool flag6 = num10 == num2;
								if (flag6)
								{
									return (int)num8;
								}
							}
						}
					}
				}
				result = 0;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00051B80 File Offset: 0x0004FD80
		public static int smethod_39(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint uint_ = num + Class53.gstruct51_30.uint_0 + Class53.gstruct51_65.uint_0;
			return (int)Class22.smethod_30(uint_, gstruct49_0.int_137);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00051BCC File Offset: 0x0004FDCC
		public static string smethod_40(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return Class22.smethod_28(num + Class53.gstruct51_30.uint_0 + Class53.gstruct51_60.uint_0, gstruct49_0.int_137, 32);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00051C18 File Offset: 0x0004FE18
		public static uint smethod_41(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			uint uint_ = Class53.gstruct51_73.uint_0;
			if (bool_0)
			{
				uint_ = Class53.gstruct51_74.uint_0;
			}
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
			uint uint_2 = num + Class53.gstruct51_75.uint_0 + uint_;
			return Class22.smethod_30(uint_2, gstruct49_0.int_137);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00051C84 File Offset: 0x0004FE84
		public static void smethod_42(GStruct49 gstruct49_0, uint uint_0, bool bool_0 = true)
		{
			uint uint_ = Class53.gstruct51_74.uint_0;
			if (bool_0)
			{
				uint_ = Class53.gstruct51_73.uint_0;
			}
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
			uint uint_2 = num + Class53.gstruct51_75.uint_0 + uint_;
			Class22.smethod_31(uint_2, gstruct49_0.int_137, uint_0, 4);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00051CEC File Offset: 0x0004FEEC
		public static int[] smethod_43(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return new int[]
			{
				(int)Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + Class53.gstruct51_76.uint_0 + (uint)(int_0 * 4) + 8U, gstruct49_0.int_137),
				(int)Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + Class53.gstruct51_76.uint_0 + (uint)(int_0 * 4) + 32U, gstruct49_0.int_137)
			};
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00051D74 File Offset: 0x0004FF74
		public static int smethod_44(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return (int)Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + Class53.gstruct51_76.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00051DC0 File Offset: 0x0004FFC0
		public static bool smethod_45(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_96.uint_0, gstruct49_0.int_137);
			return num > 0U;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00051DF4 File Offset: 0x0004FFF4
		public static int smethod_46(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * (uint)int_0;
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
			return (int)Class22.smethod_30(num5 + num, gstruct49_0.int_137);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00051E90 File Offset: 0x00050090
		public static bool smethod_47(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			int num5 = 0;
			for (uint num6 = 0U; num6 < 6U; num6 += 1U)
			{
				uint num7 = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num6;
				int num8 = (int)Class22.smethod_30(num4 + num7 + 20U, gstruct49_0.int_137);
				bool flag = num8 == 1;
				if (flag)
				{
					num5++;
				}
			}
			return num5 > 5;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00051F64 File Offset: 0x00050164
		public static bool smethod_48(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			int num5 = 0;
			byte[] array = new byte[1];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_38.uint_0 + 4U, array, 1, ref num5);
			return array[0] > 0;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00051FFC File Offset: 0x000501FC
		public static string smethod_49(GStruct49 gstruct49_0)
		{
			uint num = Class36.smethod_1(gstruct49_0);
			bool flag = gstruct49_0.int_137 != 0 && num > 0U;
			string result;
			if (flag)
			{
				byte[] array = new byte[80];
				int num2 = 0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num + Class53.gstruct51_89.uint_0, array, array.Length, ref num2);
				result = Class10.smethod_3(array);
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00052064 File Offset: 0x00050264
		public static void smethod_50(GStruct49 gstruct49_0, string string_4)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2;
			bool flag = gstruct49_0.int_137 == 0 || num4 == 0U;
			if (!flag)
			{
				byte[] array = new byte[4];
				byte[] array2 = array;
				bool flag2 = string_4 != "";
				if (flag2)
				{
					char[] array3 = string_4.ToCharArray();
					array2 = new byte[array3.Length + 1];
					for (int i = 0; i < array3.Length; i++)
					{
						array2[i] = (byte)array3[i];
					}
					array2[array2.Length - 1] = 0;
				}
				int num5 = 0;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_89.uint_0, array2, array2.Length, ref num5);
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00052166 File Offset: 0x00050366
		public static void smethod_51(GStruct49 gstruct49_0, int int_0 = 75)
		{
			Class36.smethod_2(gstruct49_0, Class53.gstruct51_31.uint_0, int_0);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0005217B File Offset: 0x0005037B
		public static void smethod_52(GStruct49 gstruct49_0, int int_0)
		{
			Class36.smethod_2(gstruct49_0, Class53.gstruct51_43.uint_0, int_0);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00052190 File Offset: 0x00050390
		public static void smethod_53(GStruct49 gstruct49_0, int int_0 = 0)
		{
			Class36.smethod_2(gstruct49_0, Class53.gstruct51_56.uint_0, int_0);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000521A8 File Offset: 0x000503A8
		public static void smethod_54(GStruct49 gstruct49_0, uint[] uint_0, bool bool_0, int int_0 = 10)
		{
			bool flag = !bool_0 && (uint_0 == null || uint_0[0] == 0U || uint_0[1] == 0U);
			if (!flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
				int i = 0;
				int num5 = 0;
				byte[] array = new byte[4];
				byte[] byte_ = array;
				while (i < int_0)
				{
					if (bool_0)
					{
						uint num6 = Class44.gstruct33_0.uint_5 >> 16;
						uint int_ = Class44.gstruct33_0.uint_5 - (num6 << 16);
						uint_0 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)int_, (int)num6);
					}
					bool flag2 = uint_0 != null && uint_0[0] != 0U && uint_0[1] > 0U;
					if (!flag2)
					{
						break;
					}
					bool flag3 = uint_0 != null;
					if (flag3)
					{
						Class70.smethod_61(gstruct49_0, uint_0);
						Thread.Sleep(200);
					}
					Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, byte_, 4, ref num5);
					uint[] uint_ = new uint[]
					{
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag4 = Class36.smethod_0(uint_, uint_0) < 11250U;
					if (flag4)
					{
						break;
					}
					i++;
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0005235C File Offset: 0x0005055C
		public static void smethod_55(GStruct49 gstruct49_0)
		{
			for (int i = 0; i < 80; i++)
			{
				bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_6, 4) <= 0;
				if (flag)
				{
					break;
				}
				Thread.Sleep(10);
			}
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			int num5 = 0;
			int value = 75;
			byte[] array = new byte[4];
			byte[] byte_ = array;
			array = new byte[4];
			byte[] byte_2 = array;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(value), 4, ref num5);
			uint uint_ = 5U;
			uint uint_2 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
			uint uint_3 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
			for (int j = 0; j < 3; j++)
			{
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, byte_, 4, ref num5);
				Thread.Sleep(10);
				Class22.smethod_31(num4 + Class53.gstruct51_37.uint_0, gstruct49_0.int_137, uint_2, 4);
				Class22.smethod_31(num4 + Class53.gstruct51_38.uint_0, gstruct49_0.int_137, uint_3, 4);
				Class22.smethod_31(num4 + Class53.gstruct51_36.uint_0, gstruct49_0.int_137, 715U, 4);
				Class22.smethod_31(num4 + Class53.gstruct51_35.uint_0, gstruct49_0.int_137, uint_, 4);
				Thread.Sleep(210 - j * 100);
			}
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_35.uint_0, byte_, 4, ref num5);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000525A0 File Offset: 0x000507A0
		public static bool smethod_56(GStruct49 gstruct49_0)
		{
			int i;
			for (i = 0; i < 80; i++)
			{
				bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_6, 4) <= 0;
				if (flag)
				{
					break;
				}
				Thread.Sleep(10);
			}
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			int num5 = 0;
			byte[] array = new byte[4];
			for (uint num6 = 0U; num6 < 6U; num6 += 1U)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num6, array, 4, ref num5);
				int num7 = BitConverter.ToInt32(array, 0);
				bool flag2 = num7 == 122;
				if (flag2)
				{
					return true;
				}
			}
			byte[] array2 = new byte[4];
			byte[] byte_ = array2;
			byte[] byte_2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num5);
			i = 0;
			int num8 = -1;
			while (i < 150)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_55.uint_0, array, 1, ref num5);
				bool flag3 = array[0] < 4 && (num8 == -1 || num8 > 80);
				if (flag3)
				{
					break;
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, byte_, 4, ref num5);
				num8 = ((array[0] <= 3) ? (num8 + 1) : 0);
				Thread.Sleep(1);
				i++;
			}
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, byte_, 4, ref num5);
			byte[] array3 = new byte[4];
			array3[0] = 5;
			byte[] byte_3 = array3;
			byte[] bytes = BitConverter.GetBytes(716);
			byte[] byte_4 = new byte[4];
			byte[] byte_5 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, byte_4, 4, ref num5);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, byte_5, 4, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_37.uint_0, byte_4, 4, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_38.uint_0, byte_5, 4, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_36.uint_0, bytes, bytes.Length, ref num5);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_35.uint_0, byte_3, 4, ref num5);
			Thread.Sleep(100);
			Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num5);
			return false;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000528B4 File Offset: 0x00050AB4
		public static void smethod_57(GStruct49 gstruct49_0, string string_4)
		{
			uint num = Class36.smethod_1(gstruct49_0);
			bool flag = gstruct49_0.int_137 != 0 && num > 0U;
			if (flag)
			{
				bool flag2 = Class53.gstruct51_251.uint_0 == 0U;
				if (!flag2)
				{
					byte[] array = Class12.smethod_46(string_4, true);
					int num2 = 0;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num + Class53.gstruct51_251.uint_0, array, array.Length, ref num2);
				}
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00052924 File Offset: 0x00050B24
		public static uint smethod_58(GStruct49 gstruct49_0, int[] int_0)
		{
			bool flag = int_0 == null;
			if (flag)
			{
				int_0 = new int[]
				{
					1
				};
			}
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_72.uint_0, gstruct49_0.int_137);
			bool flag2 = num5 <= 0U;
			uint result;
			if (flag2)
			{
				result = 0U;
			}
			else
			{
				uint num6 = num3 + num5 * Class53.gstruct51_15.uint_0;
				bool flag3 = Class22.smethod_30(num6 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137) == 0U;
				if (flag3)
				{
					result = 0U;
				}
				else
				{
					int num7 = (int)Class22.smethod_30(num6 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
					for (int i = 0; i < int_0.Length; i++)
					{
						bool flag4 = num7 == int_0[i];
						if (flag4)
						{
							return num5;
						}
					}
					result = 0U;
				}
			}
			return result;
		}

		// Token: 0x04000144 RID: 324
		public static string string_0 = "<no name>";

		// Token: 0x04000145 RID: 325
		public static string[] string_1 = new string[]
		{
			"tiÕn hµnh",
			"®ang"
		};

		// Token: 0x04000146 RID: 326
		public static string[] string_2 = new string[]
		{
			"Chat('CH_NEARBY', '<color=green>XXX<color=white> YYY <color=red>cõu s¸t<color=white> víi b¹n.')",
			"<color=white>* <color=green>XXX<color=yellow> YYY <color=red>cõu s¸t<color=yellow> víi b¹n.",
			"------------------------------------------",
			"<color=white>* <color=green>KÕt thóc cõu s¸t"
		};

		// Token: 0x04000147 RID: 327
		public static string string_3 = "Chat('CH_TONG', '<color=green>XXX<color=white> YYY <color=red>cõu s¸t<color=white> víi b¹n.')";
	}
}
