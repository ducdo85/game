using System;

namespace AutoKeoxe
{
	// Token: 0x0200002D RID: 45
	internal class Class49
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x00076914 File Offset: 0x00074B14
		public static bool smethod_0(int int_0, uint uint_0)
		{
			uint num = 0U;
			uint num2 = Class22.CreateRemoteThread(int_0, IntPtr.Zero, 0U, uint_0, 0U, 0U, out num);
			Class22.WaitForSingleObject(num2, 1000U);
			Class22.smethod_32((int)num2);
			return num2 > 0U;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00076954 File Offset: 0x00074B54
		private static uint smethod_1(ref GStruct0 gstruct0_0, uint uint_0, string string_0, string string_1 = "")
		{
			bool flag = gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				byte[] array = Class12.smethod_8(string.Concat(new string[]
				{
					"60",
					string_0,
					"E8 00 00 00 00",
					string_1,
					"61 C3"
				}), true);
				int num = 0;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
				Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num);
				int num3 = string_1.Replace(" ", "").Length / 2;
				uint uint_ = (uint)((ulong)(gstruct0_0.uint_1 + uint_0) - ((ulong)num2 + (ulong)((long)array.Length) - 2UL - (ulong)((long)num3)));
				Class22.smethod_31((uint)((ulong)num2 + (ulong)((long)array.Length) - 6UL - (ulong)((long)num3)), gstruct0_0.int_2, uint_, 4);
				gstruct0_0.uint_3 += (uint)(array.Length + 4);
				result = num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00076A38 File Offset: 0x00074C38
		public static int smethod_2(ref GStruct0 gstruct0_0)
		{
			int int_ = gstruct0_0.int_1;
			gstruct0_0.int_1 = 0;
			bool flag = !Class22.smethod_52(gstruct0_0.process_0);
			int result;
			if (flag)
			{
				gstruct0_0.uint_3 = 0U;
				gstruct0_0.uint_2 = Class22.smethod_1(gstruct0_0.int_2, 512U, GEnum1.flag_2);
				bool flag2 = gstruct0_0.uint_2 > 0U;
				if (flag2)
				{
					gstruct0_0.int_1 = int_;
					gstruct0_0.uint_4 = Class49.smethod_13(ref gstruct0_0);
					gstruct0_0.uint_5 = Class49.smethod_12(ref gstruct0_0);
					gstruct0_0.uint_6 = Class49.smethod_10(ref gstruct0_0);
					gstruct0_0.uint_7 = Class49.smethod_11(ref gstruct0_0);
					gstruct0_0.uint_8 = Class49.smethod_9(ref gstruct0_0);
					gstruct0_0.uint_9 = Class49.smethod_8(ref gstruct0_0);
					gstruct0_0.uint_10 = Class49.smethod_7(ref gstruct0_0);
					gstruct0_0.uint_11 = Class49.smethod_6(ref gstruct0_0);
					gstruct0_0.uint_12 = Class49.smethod_5(ref gstruct0_0);
					gstruct0_0.uint_13 = Class49.smethod_4(ref gstruct0_0);
					gstruct0_0.uint_14 = Class49.smethod_3(ref gstruct0_0);
					bool flag3 = gstruct0_0.uint_8 != 0U && gstruct0_0.uint_9 != 0U && gstruct0_0.uint_11 != 0U && gstruct0_0.uint_12 != 0U && gstruct0_0.uint_10 > 0U;
					if (flag3)
					{
						result = gstruct0_0.int_1;
					}
					else
					{
						gstruct0_0.int_1 = 0;
						Class22.smethod_32(gstruct0_0.int_2);
						result = -5;
					}
				}
				else
				{
					Class22.smethod_32(gstruct0_0.int_2);
					result = -4;
				}
			}
			else
			{
				result = -2;
			}
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00076B94 File Offset: 0x00074D94
		private static uint smethod_3(ref GStruct0 gstruct0_0)
		{
			string str = Class12.smethod_45((gstruct0_0.uint_2 + gstruct0_0.uint_3).ToString(), 8, false, true);
			gstruct0_0.uint_3 += 128U;
			string string_ = "68" + str;
			return Class49.smethod_1(ref gstruct0_0, Class9.uint_65, string_, "83 C4 04");
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00076BF0 File Offset: 0x00074DF0
		private static uint smethod_4(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			if (flag)
			{
				bool flag2 = gstruct0_0.uint_2 == 0U;
				if (!flag2)
				{
					string string_ = string.Concat(new string[]
					{
						"60B8 000000008B0D",
						Class12.smethod_45(Class9.uint_53, 8, false, true),
						"85 C9 74 2B69C0",
						Class12.smethod_45(Class9.uint_54, 8, false, true),
						"05",
						Class12.smethod_45(Class9.uint_55, 8, false, true),
						"03 C8 6A 00 51 68 65 05 00 00 8B 51 60 8B 12 8B 49 60 8B 42 10 85 C0 74 04 FF D0 EB 03 58 58 58 61 C3"
					});
					byte[] array = Class12.smethod_8(string_, true);
					int num = 0;
					uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
					byte b = Convert.ToByte(Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num));
					uint num3 = (uint)((int)b * (array.Length + 4));
					gstruct0_0.uint_3 += num3;
					return num2 * (uint)b;
				}
			}
			return 0U;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00076CF0 File Offset: 0x00074EF0
		public static uint smethod_5(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_38;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
				string string_ = string.Concat(new string[]
				{
					"60B9",
					Class12.smethod_45(num, 8, false, true),
					"8B 09 85 C9 74 17 8B F181 C6",
					Class12.smethod_45(Class9.uint_30, 8, false, true),
					"8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 4);
				result = (uint)Convert.ToByte(value) * num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00076DC8 File Offset: 0x00074FC8
		public static uint smethod_6(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_31;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
				string string_ = string.Concat(new string[]
				{
					"60B9",
					Class12.smethod_45(num, 8, false, true),
					"8B 09 85 C9 74 17 8B F181 C6",
					Class12.smethod_45(Class9.uint_29, 8, false, true),
					"8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 4);
				result = (uint)Convert.ToByte(value) * num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00076EA0 File Offset: 0x000750A0
		public static uint smethod_7(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || gstruct0_0.uint_2 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_31;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
				string string_ = string.Concat(new string[]
				{
					"60BA 00 00 00 00B9",
					Class12.smethod_45(num, 8, false, true),
					"8B 09 85 C9 74 1F 8B F181 C6",
					Class12.smethod_45(Class9.uint_32, 8, false, true),
					"69 D2",
					Class12.smethod_45(Class9.uint_33, 8, false, true),
					"03 F2 8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 4);
				result = (uint)Convert.ToByte(value) * num2;
			}
			return result;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00076F94 File Offset: 0x00075194
		public static uint smethod_8(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_34;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
				string string_ = string.Concat(new string[]
				{
					"60B9",
					Class12.smethod_45(num, 8, false, true),
					"8B 09 85 C9 74 17 8B F181 C6",
					Class12.smethod_45(Class9.uint_28, 8, false, true),
					"8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 4);
				result = (uint)Convert.ToByte(value) * num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0007706C File Offset: 0x0007526C
		public static uint smethod_9(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			if (flag)
			{
				bool flag2 = gstruct0_0.uint_2 > 0U;
				if (flag2)
				{
					uint num = gstruct0_0.uint_1 + Class9.uint_23;
					uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3;
					string string_ = string.Concat(new string[]
					{
						"608B 0D",
						Class12.smethod_45(num, 8, false, true),
						"8B F181 C6",
						Class12.smethod_45(Class9.uint_27, 8, false, true),
						"8B 11 8B 42 10 6A 00 56 68 65 05 00 00 FF D0 61 C3"
					});
					int num3 = 0;
					byte[] array = Class12.smethod_8(string_, false);
					bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
					gstruct0_0.uint_3 += (uint)(array.Length + 4);
					return (uint)Convert.ToByte(value) * num2;
				}
			}
			return 0U;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00077154 File Offset: 0x00075354
		public static uint smethod_10(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_23;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 2U;
				string string_ = string.Concat(new string[]
				{
					"60 B8 02 00 00 008B 0D",
					Class12.smethod_45(num, 8, false, true),
					"8B F181 C6",
					Class12.smethod_45(Class9.uint_25, 8, false, true),
					"89 86",
					Class12.smethod_45(Class9.uint_24, 8, false, true),
					"8B 11 8B 52 10 50 56 68 91 06 00 00 FF D2 61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 6);
				result = (uint)Convert.ToByte(value) * num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00077248 File Offset: 0x00075448
		public static uint smethod_11(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			if (flag)
			{
				bool flag2 = gstruct0_0.uint_2 == 0U;
				if (!flag2)
				{
					uint num = gstruct0_0.uint_1 + Class9.uint_23;
					uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 2U;
					string string_ = string.Concat(new string[]
					{
						"60 B8 02 00 00 008B 0D",
						Class12.smethod_45(num, 8, false, true),
						"8B F181 C6",
						Class12.smethod_45(Class9.uint_26, 8, false, true),
						"89 86",
						Class12.smethod_45(Class9.uint_24, 8, false, true),
						"6A 00 56 68 02 02 00 00 8B 11 8B 52 10 FF D2 61 C3"
					});
					int num3 = 0;
					byte[] array = Class12.smethod_8(string_, false);
					bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
					gstruct0_0.uint_3 += (uint)(array.Length + 6);
					return (uint)Convert.ToByte(value) * num2;
				}
			}
			return 0U;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00077350 File Offset: 0x00075550
		public static uint smethod_12(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 <= 0 || gstruct0_0.uint_2 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_21;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 6U;
				string string_ = string.Concat(new string[]
				{
					"60B9",
					Class12.smethod_45(num2 - 6U, 8, false, true),
					"6A 00 51 68 65 05 00 00 81 E9",
					Class12.smethod_45(Class9.uint_22, 8, false, true),
					"E8",
					Class12.smethod_45(num - (num2 + 25U), 8, false, true),
					"61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 10);
				result = (uint)Convert.ToByte(value) * num2;
			}
			return result;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0007744C File Offset: 0x0007564C
		public static uint smethod_13(ref GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 > 0 && gstruct0_0.uint_2 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct0_0.uint_1 + Class9.uint_19;
				uint num2 = gstruct0_0.uint_2 + gstruct0_0.uint_3 + 6U;
				string string_ = string.Concat(new string[]
				{
					"60B9",
					Class12.smethod_45(num2 - 6U, 8, false, true),
					"5181 E9",
					Class12.smethod_45(Class9.uint_20, 8, false, true),
					"E8",
					Class12.smethod_45(num - (num2 + 18U), 8, false, true),
					"61 C3"
				});
				int num3 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
				gstruct0_0.uint_3 += (uint)(array.Length + 10);
				result = (uint)Convert.ToByte(value) * num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00077548 File Offset: 0x00075748
		public static uint smethod_14(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || Class9.uint_38 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint uint_ = gstruct0_0.uint_1 + Class9.uint_38;
				uint num = Class22.smethod_30(uint_, gstruct0_0.int_2);
				bool flag2 = num > 0U;
				if (flag2)
				{
					result = num + Class9.uint_39;
				}
				else
				{
					result = 0U;
				}
			}
			return result;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000775A4 File Offset: 0x000757A4
		public static bool smethod_15(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || gstruct0_0.uint_4 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_4);
				result = true;
			}
			return result;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000775E8 File Offset: 0x000757E8
		public static bool smethod_16(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			if (flag)
			{
				bool flag2 = gstruct0_0.uint_5 == 0U;
				if (!flag2)
				{
					Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_5);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00077638 File Offset: 0x00075838
		public static bool smethod_17(GStruct0 gstruct0_0, int int_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_6 > 0U;
			bool result;
			if (flag)
			{
				bool flag2 = !Class22.smethod_31(gstruct0_0.uint_6 + 2U, gstruct0_0.int_2, (uint)int_0, 4);
				if (flag2)
				{
					result = false;
				}
				else
				{
					Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_6);
					result = true;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0007769C File Offset: 0x0007589C
		public static bool smethod_18(GStruct0 gstruct0_0, int int_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_7 > 0U;
			bool result;
			if (flag)
			{
				bool flag2 = Class22.smethod_31(gstruct0_0.uint_7 + 2U, gstruct0_0.int_2, (uint)int_0, 4);
				if (flag2)
				{
					Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_7);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000776FC File Offset: 0x000758FC
		public static bool smethod_19(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_8 > 0U;
			bool result;
			if (flag)
			{
				Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_8);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00077740 File Offset: 0x00075940
		public static bool smethod_20(GStruct0 gstruct0_0, string string_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || gstruct0_0.uint_1 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = Class22.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = false;
				}
				else
				{
					uint uint_ = num + Class9.uint_36 + Class9.uint_35;
					uint num2 = Class22.smethod_30(uint_, gstruct0_0.int_2);
					bool flag3 = num2 > 0U;
					if (flag3)
					{
						int num3 = 0;
						byte[] array = Class12.smethod_46(string_0, true);
						bool flag4 = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
						bool flag5 = Class22.smethod_31(num2 - 32U, gstruct0_0.int_2, (uint)string_0.Length, 4);
						bool flag6 = Class22.smethod_31(num2 - 56U + 4U, gstruct0_0.int_2, (uint)string_0.Length, 4);
						result = (flag4 && flag5 && flag6);
					}
					else
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00077828 File Offset: 0x00075A28
		public static bool smethod_21(GStruct0 gstruct0_0, string string_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_1 > 0U;
			bool result;
			if (flag)
			{
				uint num = Class22.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
				bool flag2 = num > 0U;
				if (flag2)
				{
					uint uint_ = num + Class9.uint_37 + Class9.uint_35;
					uint num2 = Class22.smethod_30(uint_, gstruct0_0.int_2);
					bool flag3 = num2 > 0U;
					if (flag3)
					{
						int num3 = 0;
						byte[] array = Class12.smethod_46(string_0, true);
						bool flag4 = Class22.WriteProcessMemory(gstruct0_0.int_2, num2, array, array.Length, ref num3);
						bool flag5 = Class22.smethod_31(num2 - 32U, gstruct0_0.int_2, (uint)string_0.Length, 4);
						bool flag6 = Class22.smethod_31(num2 - 56U + 4U, gstruct0_0.int_2, (uint)string_0.Length, 4);
						result = (flag4 && flag5 && flag6);
					}
					else
					{
						result = false;
					}
				}
				else
				{
					result = false;
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00077914 File Offset: 0x00075B14
		public static bool smethod_22(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			if (flag)
			{
				bool flag2 = gstruct0_0.uint_9 > 0U;
				if (flag2)
				{
					Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_9);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00077964 File Offset: 0x00075B64
		public static bool smethod_23(GStruct0 gstruct0_0, int int_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || gstruct0_0.uint_10 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag3;
				bool flag2 = flag3 = Class22.smethod_31(gstruct0_0.uint_10 + 2U, gstruct0_0.int_2, (uint)int_0, 4);
				if (flag3)
				{
					Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_10);
				}
				result = flag2;
			}
			return result;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000779C0 File Offset: 0x00075BC0
		public static bool smethod_24(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || gstruct0_0.uint_11 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_11);
				result = true;
			}
			return result;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00077A04 File Offset: 0x00075C04
		public static string smethod_25(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0;
			string result;
			if (flag)
			{
				uint num = Class49.smethod_14(gstruct0_0);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = string.Empty;
				}
				else
				{
					result = Class22.smethod_28(num, gstruct0_0.int_2, 80);
				}
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00077A54 File Offset: 0x00075C54
		public static bool smethod_26(GStruct0 gstruct0_0, string string_0)
		{
			bool flag = gstruct0_0.int_1 == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = Class49.smethod_14(gstruct0_0);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = false;
				}
				else
				{
					int num2 = 0;
					byte[] array = Class12.smethod_46(string_0, true);
					result = Class22.WriteProcessMemory(gstruct0_0.int_2, num, array, array.Length, ref num2);
				}
			}
			return result;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00077AAC File Offset: 0x00075CAC
		public static bool smethod_27(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 != 0 && gstruct0_0.uint_12 > 0U;
			bool result;
			if (flag)
			{
				Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_12);
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00077AF0 File Offset: 0x00075CF0
		public static void smethod_28(GStruct0 gstruct0_0, string string_0)
		{
			bool flag = string_0.Length >= 127;
			if (flag)
			{
				string_0 = string_0.Substring(0, 127);
			}
			bool flag2 = 128 <= string_0.Length;
			if (flag2)
			{
				string_0 = string_0.Substring(0, 127);
			}
			byte[] array = Class12.smethod_46(string_0, true);
			int num = 0;
			uint uint_ = gstruct0_0.uint_14 - 128U;
			Class22.WriteProcessMemory(gstruct0_0.int_2, uint_, array, array.Length, ref num);
			Class49.smethod_0(gstruct0_0.int_2, gstruct0_0.uint_14);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00077B78 File Offset: 0x00075D78
		public static string smethod_29(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || Class9.uint_34 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				uint num = Class22.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
				bool flag2 = num > 0U;
				if (flag2)
				{
					uint uint_ = num + Class9.uint_36 + Class9.uint_35;
					uint num2 = Class22.smethod_30(uint_, gstruct0_0.int_2);
					bool flag3 = num2 > 0U;
					if (flag3)
					{
						result = Class22.smethod_28(num2, gstruct0_0.int_2, 50);
					}
					else
					{
						result = string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00077C14 File Offset: 0x00075E14
		public static string smethod_30(GStruct0 gstruct0_0)
		{
			bool flag = gstruct0_0.int_1 == 0 || Class9.uint_34 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				uint num = Class22.smethod_30(gstruct0_0.uint_1 + Class9.uint_34, gstruct0_0.int_2);
				bool flag2 = num > 0U;
				if (flag2)
				{
					uint uint_ = num + Class9.uint_37 + Class9.uint_35;
					uint num2 = Class22.smethod_30(uint_, gstruct0_0.int_2);
					bool flag3 = num2 > 0U;
					if (flag3)
					{
						result = Class22.smethod_28(num2, gstruct0_0.int_2, 50);
					}
					else
					{
						result = string.Empty;
					}
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00077CB0 File Offset: 0x00075EB0
		public static int smethod_31(GStruct0 gstruct0_0)
		{
			uint uint_ = gstruct0_0.uint_1 + Class9.uint_66 + Class9.uint_67;
			int num = 0;
			byte[] array = new byte[2];
			Class22.ReadProcessMemory(gstruct0_0.int_2, uint_, array, 2, ref num);
			return (int)array[0] + (int)array[1] * 256;
		}
	}
}
