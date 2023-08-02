using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000044 RID: 68
	internal class Class70
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x000BB71C File Offset: 0x000B991C
		public static void smethod_0(GStruct49 gstruct49_0, uint uint_53)
		{
			DateTime now = DateTime.Now;
			int int_ = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
			Class70.smethod_2(gstruct49_0, uint_53, int_, 4);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000BB75C File Offset: 0x000B995C
		public static int smethod_1(GStruct49 gstruct49_0, uint uint_53)
		{
			DateTime now = DateTime.Now;
			int num = now.Second + now.Minute * 60 + now.Hour * 60 * 60;
			int num2 = Class70.smethod_3(gstruct49_0, uint_53, 4);
			return Math.Abs(num2 - num);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000BB7A8 File Offset: 0x000B99A8
		public static void smethod_2(GStruct49 gstruct49_0, uint uint_53, int int_0, byte byte_0 = 4)
		{
			int num = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + uint_53 * 4U, bytes, (int)byte_0, ref num);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000BB7DC File Offset: 0x000B99DC
		public static int smethod_3(GStruct49 gstruct49_0, uint uint_53, byte byte_0 = 4)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + uint_53 * 4U, array, 4, ref num);
			bool flag = byte_0 > 3 && (array[1] > 0 || array[2] > 0 || array[3] > 0);
			int result;
			if (flag)
			{
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = (int)array[0];
			}
			return result;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000BB840 File Offset: 0x000B9A40
		public static uint smethod_4(uint uint_53, uint uint_54, uint uint_55, uint uint_56)
		{
			long num = (long)(uint_53 - uint_55);
			long num2 = (long)(uint_54 - uint_56);
			return (uint)(num * num + num2 * num2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000BB864 File Offset: 0x000B9A64
		private static void smethod_5(int int_0, uint uint_53, byte[] byte_0)
		{
			int num = 0;
			Class22.WriteProcessMemory(int_0, uint_53, byte_0, byte_0.Length, ref num);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000BB884 File Offset: 0x000B9A84
		private static void smethod_6(int int_0, uint uint_53, string string_0, bool bool_0 = true)
		{
			byte[] byte_ = Class12.smethod_46(string_0, bool_0);
			Class70.smethod_5(int_0, uint_53, byte_);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000BB8A4 File Offset: 0x000B9AA4
		public static bool smethod_7(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			uint num4 = num3 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			uint num6 = num5 + num4;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
			int num7 = BitConverter.ToInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
			int num8 = BitConverter.ToInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
			int num9 = BitConverter.ToInt32(array, 0);
			int num10 = Class83.smethod_39(gstruct49_0);
			return num8 > 0 && num9 > 0 && num7 > 0 && num10 > 1;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000BB9D0 File Offset: 0x000B9BD0
		public static void smethod_8(ref GStruct49 gstruct49_0)
		{
			bool flag = Class70.uint_52 == 0U;
			if (flag)
			{
				uint num = Class22.smethod_37(Class22.smethod_56(), "ntdll.dll");
				Class70.uint_52 = Class22.GetProcAddress(num, "RtlExitUserThread");
			}
			gstruct49_0.uint_17 = 4096U;
			gstruct49_0.uint_97 = Class70.smethod_9(ref gstruct49_0);
			gstruct49_0.uint_50 = Class70.smethod_60(ref gstruct49_0);
			gstruct49_0.uint_87 = Class70.smethod_62(ref gstruct49_0);
			gstruct49_0.uint_83 = Class70.smethod_56(ref gstruct49_0);
			gstruct49_0.uint_80 = Class70.smethod_53(ref gstruct49_0);
			gstruct49_0.uint_81 = Class70.smethod_51(ref gstruct49_0);
			gstruct49_0.uint_82 = Class70.smethod_49(ref gstruct49_0);
			gstruct49_0.uint_42 = Class70.smethod_47(ref gstruct49_0);
			gstruct49_0.uint_43 = Class70.smethod_45(ref gstruct49_0);
			gstruct49_0.uint_45 = Class70.smethod_42(ref gstruct49_0);
			gstruct49_0.uint_70 = Class70.smethod_40(ref gstruct49_0);
			gstruct49_0.uint_59 = Class70.smethod_86(ref gstruct49_0);
			gstruct49_0.uint_61 = Class70.smethod_36(ref gstruct49_0);
			gstruct49_0.uint_60 = Class70.smethod_34(ref gstruct49_0);
			gstruct49_0.uint_55 = Class70.smethod_33(ref gstruct49_0);
			gstruct49_0.uint_39 = Class70.smethod_30(ref gstruct49_0, false);
			gstruct49_0.uint_40 = Class70.smethod_30(ref gstruct49_0, true);
			gstruct49_0.uint_77 = Class70.smethod_23(ref gstruct49_0);
			gstruct49_0.uint_78 = Class70.smethod_24(ref gstruct49_0);
			gstruct49_0.uint_57 = Class70.smethod_19(ref gstruct49_0);
			gstruct49_0.uint_58 = Class70.smethod_21(ref gstruct49_0);
			gstruct49_0.uint_89 = Class70.smethod_101(ref gstruct49_0);
			gstruct49_0.uint_91 = Class70.smethod_17(ref gstruct49_0);
			gstruct49_0.uint_66 = Class70.smethod_90(ref gstruct49_0);
			gstruct49_0.uint_67 = Class70.smethod_91(ref gstruct49_0);
			gstruct49_0.uint_68 = Class70.smethod_92(ref gstruct49_0);
			gstruct49_0.uint_69 = Class70.smethod_93(ref gstruct49_0);
			gstruct49_0.uint_93 = Class70.smethod_74(ref gstruct49_0);
			gstruct49_0.uint_94 = Class70.smethod_15(ref gstruct49_0);
			gstruct49_0.uint_95 = Class70.smethod_72(ref gstruct49_0);
			gstruct49_0.uint_52 = Class70.smethod_81(ref gstruct49_0);
			gstruct49_0.uint_53 = Class70.smethod_82(ref gstruct49_0);
			gstruct49_0.uint_54 = Class70.smethod_78(ref gstruct49_0);
			gstruct49_0.uint_41 = Class70.smethod_79(ref gstruct49_0);
			gstruct49_0.uint_44 = Class70.smethod_83(ref gstruct49_0);
			gstruct49_0.uint_46 = Class70.smethod_70(ref gstruct49_0);
			gstruct49_0.uint_48 = Class70.smethod_68(ref gstruct49_0);
			gstruct49_0.uint_47 = Class70.smethod_66(ref gstruct49_0);
			gstruct49_0.uint_90 = Class70.smethod_65(ref gstruct49_0);
			gstruct49_0.uint_49 = Class70.smethod_84(ref gstruct49_0);
			gstruct49_0.uint_56 = Class70.smethod_98(ref gstruct49_0);
			gstruct49_0.uint_62 = Class70.smethod_85(ref gstruct49_0);
			gstruct49_0.uint_63 = Class70.smethod_88(ref gstruct49_0);
			gstruct49_0.uint_65 = Class70.smethod_87(ref gstruct49_0);
			gstruct49_0.uint_64 = Class70.smethod_89(ref gstruct49_0);
			gstruct49_0.uint_71 = Class70.smethod_94(ref gstruct49_0);
			gstruct49_0.uint_79 = Class70.smethod_97(ref gstruct49_0);
			gstruct49_0.uint_76 = Class70.smethod_25(ref gstruct49_0);
			gstruct49_0.uint_84 = Class70.smethod_76(ref gstruct49_0);
			gstruct49_0.uint_85 = Class70.smethod_77(ref gstruct49_0);
			gstruct49_0.uint_86 = Class70.smethod_99(ref gstruct49_0);
			gstruct49_0.uint_88 = Class70.smethod_100(ref gstruct49_0);
			gstruct49_0.uint_96 = Class70.smethod_13(ref gstruct49_0);
			gstruct49_0.uint_72 = Class70.smethod_95(ref gstruct49_0);
			gstruct49_0.uint_73 = Class70.smethod_96(ref gstruct49_0);
			gstruct49_0.uint_74 = Class70.smethod_58(ref gstruct49_0, 0);
			gstruct49_0.uint_75 = Class70.smethod_58(ref gstruct49_0, 1);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000BBCC8 File Offset: 0x000B9EC8
		private static uint smethod_9(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = Class70.uint_52 - (num + 8U);
			string string_ = "33 C0 50E8" + Class12.smethod_45(num2, 8, false, true);
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 > 0U);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000BBD60 File Offset: 0x000B9F60
		public static string smethod_10(uint uint_53)
		{
			string result = "C3";
			bool flag = uint_53 != 0U && Class70.uint_52 > 0U;
			if (flag)
			{
				result = "3EC70424" + Class12.smethod_45(uint_53, 8, false, true) + "C3";
			}
			return result;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000BBDAC File Offset: 0x000B9FAC
		public static uint smethod_11(ref GStruct49 gstruct49_0, uint uint_53, string string_0, string string_1 = "", uint uint_54 = 0U)
		{
			bool flag = gstruct49_0.uint_16 > 0U;
			uint result;
			if (flag)
			{
				string text = Class70.smethod_10(gstruct49_0.uint_97);
				uint num = (uint)(text.Length / 2 - 1);
				byte[] array = Class12.smethod_8(string.Concat(new string[]
				{
					"60",
					string_0,
					"E8 00 00 00 00",
					string_1,
					"61",
					text
				}), true);
				int num2 = 204;
				uint num3 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array, array.Length, ref num2);
				int num4 = string_1.Replace(" ", "").Length / 2;
				uint num5 = gstruct49_0.uint_7;
				bool flag2 = uint_54 > 0U;
				if (flag2)
				{
					num5 = uint_54;
				}
				uint num6 = num5 + uint_53;
				uint num7 = num3 + (uint)array.Length - (uint)num4 - 2U - num;
				uint num8 = num6 - num7;
				uint num9 = num3 + (uint)array.Length - (uint)num4 - 6U - num;
				Class22.smethod_31(num9, gstruct49_0.int_137, num8, 4);
				gstruct49_0.uint_17 += (uint)(array.Length + 4);
				result = num3;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000BBECC File Offset: 0x000BA0CC
		public static bool smethod_12(int int_0, uint uint_53)
		{
			bool flag = int_0 != 0 && uint_53 > 0U;
			bool result;
			if (flag)
			{
				uint num = 0U;
				uint num2 = Class22.CreateRemoteThread(int_0, IntPtr.Zero, 0U, uint_53, 0U, 0U, out num);
				bool flag2 = num2 > 0U;
				if (flag2)
				{
					Class22.WaitForSingleObject(num2, 30000U);
					Class22.smethod_32((int)num2);
				}
				result = (num > 0U);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000BBF2C File Offset: 0x000BA12C
		private static uint smethod_13(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = "6A 00 6A 01";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_90.uint_0, string_, "83 C4 08", 0U);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000BBF68 File Offset: 0x000BA168
		public static bool smethod_14(GStruct49 gstruct49_0, bool bool_0)
		{
			bool flag = gstruct49_0.uint_96 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] byte_ = new byte[]
				{
					Convert.ToByte(bool_0)
				};
				bool flag2 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_96 + 4U, byte_, 1, ref num);
				result = (!flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_96));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x000BBFD8 File Offset: 0x000BA1D8
		private static uint smethod_15(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_196.uint_0 - (num + 32U);
			string string_ = string.Concat(new string[]
			{
				"60BA C8283F1581C2",
				Class12.smethod_45(Class53.gstruct51_205.uint_0, 8, false, true),
				"B8 010000008B0D",
				Class12.smethod_45(Class53.gstruct51_224.uint_0, 8, false, true),
				"5052 6A 05E8",
				Class12.smethod_45(num2, 8, false, true),
				"61",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_196.uint_0 != 0U && Class53.gstruct51_224.uint_0 > 0U);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000BC0FC File Offset: 0x000BA2FC
		public static bool smethod_16(GStruct49 gstruct49_0, uint uint_53, byte byte_0 = 0)
		{
			bool flag = gstruct49_0.uint_94 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = BitConverter.GetBytes(uint_53);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_94 + 2U, array, array.Length, ref num);
				bool flag3 = byte_0 != 1;
				if (flag3)
				{
					byte_0 = 0;
				}
				array = new byte[]
				{
					byte_0
				};
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_94 + 13U, array, 1, ref num);
				bool flag5 = !flag2 || !flag4;
				result = (!flag5 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_94));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000BC1A8 File Offset: 0x000BA3A8
		private static uint smethod_17(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			string string_ = "60BE 184D4028BF 2BBC418BBB 010000008B0D" + Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_197.uint_0, 8, false, true) + "8B 01 8B 50 3C 6A 00 56 57 53 FF D261" + Class70.smethod_10(gstruct49_0.uint_97);
			int num2 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_197.uint_0 > 0U);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x000BC260 File Offset: 0x000BA460
		public static bool smethod_18(GStruct49 gstruct49_0, object object_0)
		{
			bool flag = gstruct49_0.uint_91 != 0U && object_0 != null;
			bool result;
			if (flag)
			{
				uint num = Class12.smethod_12(object_0.ToString());
				bool flag2 = num == 0U;
				if (flag2)
				{
					num = Class12.smethod_6(object_0.ToString());
					bool flag3 = num == 0U;
					if (flag3)
					{
						return false;
					}
				}
				int num2 = 0;
				byte[] array = new byte[4];
				byte[] array2 = new byte[4];
				byte[] byte_ = new byte[4];
				byte[] bytes = BitConverter.GetBytes(num);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_13.uint_0, array, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array, 0);
				uint num5 = num4 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num2);
				uint num6 = BitConverter.ToUInt32(array, 0);
				uint num7 = num6 + num5;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_88.uint_0, array2, 4, ref num2);
				bool flag4 = BitConverter.ToUInt32(array2, 0) == 0U;
				if (flag4)
				{
					result = false;
				}
				else
				{
					uint num8 = num3 + Class53.gstruct51_189.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + 40U, byte_, 4, ref num2);
					bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_91 + 2U, bytes, bytes.Length, ref num2);
					bool flag6 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_91 + 7U, array2, 4, ref num2);
					bool flag7 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_91 + 12U, byte_, 4, ref num2);
					bool flag8 = flag5 && flag6 && flag7;
					result = (flag8 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_91));
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000BC43C File Offset: 0x000BA63C
		private static uint smethod_19(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_237.uint_0 - (num + 38U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 25 C6 00 018B0D",
				Class12.smethod_45(Class53.gstruct51_236.uint_0, 8, false, true),
				"85 C9 74 11 B8 00 00 00 00 55 89 E5 50E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_237.uint_0 != 0U && Class53.gstruct51_236.uint_0 > 0U);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000BC578 File Offset: 0x000BA778
		public static bool smethod_20(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_57 != 0U && Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] bytes = BitConverter.GetBytes(uint_53);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_57 + 25U, bytes, bytes.Length, ref num);
				result = (flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_57));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000BC5E4 File Offset: 0x000BA7E4
		private static uint smethod_21(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 8U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_238.uint_0 - (num + 44U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 2F C6 00 01A1",
				Class12.smethod_45(Class53.gstruct51_105.uint_0, 8, false, true),
				"85 C0 74 18 B9 00 00 00 0069C9",
				Class12.smethod_45(Class53.gstruct51_106.uint_0, 8, false, true),
				"01 C1 55 89 E5E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DBF",
				Class12.smethod_45(num - 4U, 8, false, true),
				"C6 07 00 89 47 FC 61",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_238.uint_0 != 0U && Class53.gstruct51_105.uint_0 != 0U && Class53.gstruct51_106.uint_0 > 0U);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000BC750 File Offset: 0x000BA950
		public static int smethod_22(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_58 == 0U;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int i = 0;
				int num = 0;
				byte[] array = new byte[1];
				while (i < 300)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_58 - 4U, array, 1, ref num);
					bool flag2 = array[0] == 0;
					if (flag2)
					{
						break;
					}
					i++;
					Thread.Sleep(1);
				}
				array = BitConverter.GetBytes(uint_53);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_58 + 24U, array, array.Length, ref num);
				if (flag3)
				{
					array = new byte[4];
					bool flag4 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_58 - 8U, array, array.Length, ref num);
					if (flag4)
					{
						result = -1;
					}
					else
					{
						bool flag5 = !Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_58);
						if (flag5)
						{
							result = -1;
						}
						else
						{
							i = 0;
							int num2 = 0;
							while (i < 30)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_58 - 8U, array, 4, ref num);
								num2 = BitConverter.ToInt32(array, 0);
								bool flag6 = num2 > 0;
								if (flag6)
								{
									break;
								}
								i++;
								Thread.Sleep(10);
							}
							result = num2;
						}
					}
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000BC894 File Offset: 0x000BAA94
		private static uint smethod_23(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += 80U;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_225.uint_0 - (num2 + 46U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 2D C6 00 01 90 90 90 908B0D",
				Class12.smethod_45(Class53.gstruct51_224.uint_0, 8, false, true),
				"85 C9 74 15B8",
				Class12.smethod_45(num, 8, false, true),
				"55 89 E5 6A 00 50 6A 70E8",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_225.uint_0 != 0U && Class53.gstruct51_224.uint_0 > 0U);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000BCA04 File Offset: 0x000BAC04
		private static uint smethod_24(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_232.uint_0 - (num + 9U);
			string string_ = "60 55 89 E5E8" + Class12.smethod_45(num2, 8, false, true) + "89 EC 5D61" + Class70.smethod_10(gstruct49_0.uint_97);
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_232.uint_0 > 0U);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x000BCAC8 File Offset: 0x000BACC8
		private static uint smethod_25(ref GStruct49 gstruct49_0)
		{
			string string_ = "B8 " + Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true) + "89 45 08 C7 00 10 00 00 00 66 C7 40 04 00 00 66 C7 40 06 A0 08 6A 00 50 6A 188B 0D " + Class12.smethod_45(Class53.gstruct51_224.uint_0, 8, false, true);
			gstruct49_0.uint_17 += 16U;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, "", 0U);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x000BCB40 File Offset: 0x000BAD40
		public static bool smethod_26(GStruct49 gstruct49_0, string string_0)
		{
			bool flag = gstruct49_0.uint_77 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = 0;
				byte[] array = Class12.smethod_46(string_0, true);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_77 - 80U, array, array.Length, ref num);
				result = (flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_77));
			}
			return result;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x000BCBA4 File Offset: 0x000BADA4
		public static bool smethod_27(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_78 > 0U;
			return flag && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_78);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000BCBD8 File Offset: 0x000BADD8
		public static bool smethod_28(GStruct49 gstruct49_0, int int_0, int int_1 = 0)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_76 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				int value = int_1 * 16 + 2208;
				byte[] bytes = BitConverter.GetBytes(value);
				byte[] bytes2 = BitConverter.GetBytes(int_0);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_76 + 19U, bytes2, 2, ref num);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_76 + 25U, bytes, 2, ref num);
				bool flag4 = !flag2 || !flag3;
				result = (!flag4 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_76));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000BCC84 File Offset: 0x000BAE84
		public static int smethod_29(GStruct49 gstruct49_0)
		{
			uint num = 2712668U + gstruct49_0.uint_7;
			uint num2 = 508U;
			uint num3 = 16U;
			int num4 = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, 4, ref num4);
			uint num5 = BitConverter.ToUInt32(array, 0);
			bool flag = num5 > 0U;
			int result;
			if (flag)
			{
				uint num6 = num5 + num2 + num3;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6, array, 4, ref num4);
				uint num7 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num7 > 0U;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num7, array, 1, ref num4);
					bool flag3 = array[0] == 16;
					if (flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + 6U, array, 2, ref num4);
						result = (int)array[1] * 256 + (int)array[0];
					}
					else
					{
						result = -1000002;
					}
				}
				else
				{
					result = -1000001;
				}
			}
			else
			{
				result = -1000000;
			}
			return result;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000BCD78 File Offset: 0x000BAF78
		private static uint smethod_30(ref GStruct49 gstruct49_0, bool bool_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = bool_0 ? Class53.gstruct51_69.uint_0 : Class53.gstruct51_67.uint_0;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + num - (num2 + 44U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 2B C6 00 018B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 1781C1",
				Class12.smethod_45(Class53.gstruct51_12.uint_0, 8, false, true),
				"BB 53 00 00 00 55 89 E5 53E8",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && num != 0U && Class53.gstruct51_11.uint_0 != 0U && Class53.gstruct51_12.uint_0 > 0U);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000BCEEC File Offset: 0x000BB0EC
		public static bool smethod_31(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_39 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				int num2 = 0;
				while (!Class12.bool_0)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_39 - 4U, array, 1, ref num);
					bool flag2 = array[0] == 0;
					if (flag2)
					{
						break;
					}
					num2++;
					bool flag3 = num2 <= 350;
					if (!flag3)
					{
						return false;
					}
					Thread.Sleep(1);
				}
				array = BitConverter.GetBytes(uint_53);
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_39 + 31U, array, array.Length, ref num);
				result = (flag4 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_39));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x000BCFBC File Offset: 0x000BB1BC
		public static bool smethod_32(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_40 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				int num2 = 0;
				while (!Class12.bool_0)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_40 - 4U, array, 1, ref num);
					bool flag2 = array[0] == 0;
					if (flag2)
					{
						break;
					}
					num2++;
					bool flag3 = num2 <= 350;
					if (!flag3)
					{
						return false;
					}
					Thread.Sleep(1);
				}
				array = BitConverter.GetBytes(uint_53);
				bool flag4 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_40 + 31U, array, array.Length, ref num);
				result = (!flag4 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_40));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000BD08C File Offset: 0x000BB28C
		private static uint smethod_33(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_169.uint_0 - (num + 36U);
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 23 C6 01 018B0D",
				Class12.smethod_45(Class53.gstruct51_165.uint_0, 8, false, true),
				"85 C9 74 0F 55 89 E5 6A 00 6A 00E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_169.uint_0 != 0U && Class53.gstruct51_165.uint_0 > 0U);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000BD1C8 File Offset: 0x000BB3C8
		private static uint smethod_34(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_104.uint_0 - (num + 51U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 32 C6 00 01A1",
				Class12.smethod_45(Class53.gstruct51_105.uint_0, 8, false, true),
				"85 C0 74 1F B9 00 00 00 0069C9",
				Class12.smethod_45(Class53.gstruct51_106.uint_0, 8, false, true),
				"01 C88B88",
				Class12.smethod_45(Class53.gstruct51_103.uint_0, 8, false, true),
				"55 89 E5 51E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_105.uint_0 != 0U && Class53.gstruct51_106.uint_0 != 0U && Class53.gstruct51_103.uint_0 != 0U && Class53.gstruct51_104.uint_0 > 0U);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000BD364 File Offset: 0x000BB564
		public static bool smethod_35(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_60 != 0U && Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				int i = 0;
				while (i < 300)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_60 - 4U, array, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array, 0) == 0;
					if (flag2)
					{
						break;
					}
					i++;
					Thread.Sleep(1);
				}
				byte[] bytes = BitConverter.GetBytes(uint_53);
				bool flag3 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_60 + 24U, bytes, bytes.Length, ref num);
				if (flag3)
				{
					result = false;
				}
				else
				{
					array = new byte[4];
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
					uint num2 = BitConverter.ToUInt32(array, 0);
					array = new byte[4];
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + 35664U, array, 4, ref num);
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + 55416U, array, 4, ref num);
					result = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_60);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000BD48C File Offset: 0x000BB68C
		private static uint smethod_36(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_225.uint_0 - (num + 41U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 28 C6 00 018B0D",
				Class12.smethod_45(Class53.gstruct51_224.uint_0, 8, false, true),
				"85 C9 74 14 55 89 E5 68 00 01 00 00 6A 00 6A 05E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_224.uint_0 != 0U && Class53.gstruct51_225.uint_0 > 0U);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000BD5C8 File Offset: 0x000BB7C8
		public static bool smethod_37(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_61 != 0U && Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 - 4U, array, 1, ref num);
				bool flag2 = array[0] <= 0;
				if (flag2)
				{
					array[0] = 0;
					byte[] bytes = BitConverter.GetBytes(uint_53);
					bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 + 33U, array, 1, ref num);
					bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 + 28U, bytes, 4, ref num);
					bool flag5 = !flag3 || !flag4;
					result = (!flag5 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_61));
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

		// Token: 0x06000409 RID: 1033 RVA: 0x000BD698 File Offset: 0x000BB898
		public static bool smethod_38(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_61 == 0U;
			if (!flag)
			{
				bool flag2 = Class70.smethod_7(gstruct49_0);
				if (flag2)
				{
					int num = 0;
					byte[] array = new byte[1];
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 - 4U, array, 1, ref num);
					bool flag3 = array[0] > 0;
					if (flag3)
					{
						return false;
					}
					array[0] = 1;
					byte[] bytes = BitConverter.GetBytes(uint_53);
					bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 + 33U, array, 1, ref num);
					bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_61 + 28U, bytes, 4, ref num);
					bool flag6 = flag4;
					if (flag6)
					{
						bool flag7 = flag5;
						if (flag7)
						{
							return Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_61);
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000BD784 File Offset: 0x000BB984
		public static uint smethod_39(GStruct49 gstruct49_0, int int_0 = 1)
		{
			uint num = Class53.gstruct51_74.uint_0;
			bool flag = int_0 == 1 || int_0 == 3;
			if (flag)
			{
				num = Class53.gstruct51_73.uint_0;
			}
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
			uint num3 = num2 + Class53.gstruct51_75.uint_0 + num;
			return Class22.smethod_30(num3, gstruct49_0.int_137);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000BD7FC File Offset: 0x000BB9FC
		private static uint smethod_40(ref GStruct49 gstruct49_0)
		{
			string string_ = string.Concat(new string[]
			{
				"B8",
				Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true),
				"80 38 0075 3D8B 0D",
				Class12.smethod_45(Class53.gstruct51_224.uint_0, 8, false, true),
				"85 C974 33C6 00 01 83 C0 04 89 45 08C7 00 0B 00 00 00C7 40 04 01 00 00 006A 00 50 6A 18"
			});
			string string_2 = "B8" + Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true) + "FE 48 0180 78 01 007F C866 C7 00 00 00";
			gstruct49_0.uint_17 += 256U;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, string_2, 0U);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000BD8B8 File Offset: 0x000BBAB8
		public static uint smethod_41(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = gstruct49_0.uint_70 == 0U || !Class70.smethod_7(gstruct49_0);
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = gstruct49_0.uint_70 - 256U;
				int num2 = 0;
				byte[] array = new byte[1];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, 1, ref num2);
				bool flag2 = array[0] == 0;
				if (flag2)
				{
					array = BitConverter.GetBytes(int_0);
					bool flag3 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_70 + 39U, array, 4, ref num2);
					if (flag3)
					{
						return 0U;
					}
					bool flag4 = !Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_70);
					if (flag4)
					{
						return 0U;
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000BD970 File Offset: 0x000BBB70
		private static uint smethod_42(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_121.uint_0 - (num + 51U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 32 C6 00 018B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 1E81C1",
				Class12.smethod_45(Class53.gstruct51_12.uint_0, 8, false, true),
				"55 89 E5 6A 00 6A 09 6A 05 6A 03 68 01 00 00 00E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_121.uint_0 > 0U);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000BDAC4 File Offset: 0x000BBCC4
		public static bool smethod_43(GStruct49 gstruct49_0, uint uint_53, int int_0, int int_1, int int_2 = 3)
		{
			bool flag = gstruct49_0.uint_45 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] bytes = BitConverter.GetBytes(uint_53);
				byte[] byte_ = new byte[]
				{
					(byte)int_2
				};
				byte[] byte_2 = new byte[]
				{
					(byte)int_0
				};
				byte[] byte_3 = new byte[]
				{
					(byte)int_1
				};
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_45 + 36U, byte_3, 1, ref num);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_45 + 38U, byte_2, 1, ref num);
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_45 + 40U, byte_, 1, ref num);
				bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_45 + 42U, bytes, 4, ref num);
				bool flag6 = flag2 && flag3 && flag4 && flag5;
				result = (flag6 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_45));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000BDBB0 File Offset: 0x000BBDB0
		public static bool smethod_44(GStruct49 gstruct49_0, string string_0, bool bool_0 = false, int int_0 = -1, bool bool_1 = false)
		{
			bool flag = string_0 != null && !(string_0 == string.Empty) && gstruct49_0.uint_17 != 0U && gstruct49_0.uint_45 != 0U && Class53.gstruct51_121.uint_0 != 0U && Class53.gstruct51_11.uint_0 != 0U && Class53.gstruct51_12.uint_0 > 0U;
			bool result;
			if (flag)
			{
				int num = 1;
				string[] array = string_0.Split(new char[]
				{
					'|',
					',',
					';'
				});
				string[] array2 = new string[array.Length];
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
					array2[i] = array[i].Trim().ToLower();
				}
				num += 3;
				int num2 = 0;
				byte[] array3 = new byte[4];
				byte[] array4 = new byte[1];
				byte[] byte_ = new byte[num];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array3, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array3, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array3, 0);
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 0U;
				int int_ = 0;
				int int_2 = 0;
				uint num8 = 0U;
				int num9 = 0;
				int num10 = 0;
				uint num11 = 1U;
				while ((ulong)num11 < (ulong)((long)Class53.int_1) && num5 > num6)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num11 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
					uint num12 = BitConverter.ToUInt32(array3, 0);
					bool flag4 = num12 == 0U;
					if (!flag4)
					{
						uint num13 = num4 + num12 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
						bool flag5 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag5)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_107.uint_0, array4, 1, ref num2);
							bool flag6 = array4[0] == 0;
							if (!flag6)
							{
								num6++;
								uint num14 = num3 + num11 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0 - 8U, array4, 1, ref num2);
								bool flag7 = array4[0] != 3;
								if (!flag7)
								{
									bool flag8 = 0 <= int_0;
									if (flag8)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_108.uint_0, array3, 4, ref num2);
										int num15 = BitConverter.ToInt32(array3, 0);
										bool flag9 = num15 != int_0;
										if (flag9)
										{
											goto IL_40E;
										}
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0 - 4U, array4, 1, ref num2);
									int num16 = (int)array4[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0, array4, 1, ref num2);
									int num17 = (int)array4[0];
									bool flag10 = array != null;
									if (flag10)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_107.uint_0, byte_, num, ref num2);
										string text = Class10.smethod_3(byte_);
										string text2 = text.Trim().ToLower();
										for (int j = 0; j < array.Length; j++)
										{
											bool flag11 = !(text == array[j]) && !(text2 == array2[j]);
											if (!flag11)
											{
												return Class70.smethod_43(gstruct49_0, num12, num16, num17, 3);
											}
											bool flag12 = !bool_0;
											if (flag12)
											{
												bool flag13 = 0 <= text2.IndexOf(array2[j]);
												if (flag13)
												{
													num7 = num12;
													int_ = num16;
													int_2 = num17;
													break;
												}
												bool flag14 = 0 <= array2[j].IndexOf(text2);
												if (flag14)
												{
													num8 = num12;
													num9 = num16;
													num10 = num17;
													break;
												}
											}
										}
									}
									bool flag15 = !bool_1 && (num7 != 0U || num8 > 0U);
									if (flag15)
									{
										break;
									}
								}
							}
						}
					}
					IL_40E:
					num11 += 1U;
				}
				bool flag16 = num7 == 0U && num8 > 0U;
				if (flag16)
				{
					num7 = num8;
					int_ = num9;
					int_2 = num10;
				}
				bool flag17 = num7 == 0U;
				result = (!flag17 && Class70.smethod_43(gstruct49_0, num7, int_, int_2, 3));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000BE038 File Offset: 0x000BC238
		private static uint smethod_45(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_102.uint_0 - (num + 50U);
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 31 C6 01 018B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 1D81C1",
				Class12.smethod_45(Class53.gstruct51_12.uint_0, 8, false, true),
				"55 89 E5 6A 00 6A 00 6A 01 6A 02 6A 02 6A 03E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_102.uint_0 > 0U);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000BE18C File Offset: 0x000BC38C
		public static void smethod_46(GStruct49 gstruct49_0, uint uint_53, uint uint_54, uint uint_55, uint uint_56, uint uint_57, uint uint_58)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_43 != 0U && Class70.smethod_7(gstruct49_0);
			if (flag)
			{
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[1];
				while (Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 - 4U, array, 1, ref num) && array[0] > 0 && num2 < 150)
				{
					Thread.Sleep(1);
					num2++;
				}
				byte[] byte_ = new byte[]
				{
					(byte)uint_56
				};
				byte[] byte_2 = new byte[]
				{
					(byte)uint_57
				};
				byte[] byte_3 = new byte[]
				{
					(byte)uint_58
				};
				byte[] byte_4 = new byte[]
				{
					(byte)uint_53
				};
				byte[] byte_5 = new byte[]
				{
					(byte)uint_54
				};
				byte[] byte_6 = new byte[]
				{
					(byte)uint_55
				};
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 34U, byte_2, 1, ref num);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 36U, byte_, 1, ref num);
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 38U, byte_3, 1, ref num);
				bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 40U, byte_5, 1, ref num);
				bool flag6 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 42U, byte_4, 1, ref num);
				bool flag7 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_43 + 44U, byte_6, 1, ref num);
				bool flag8 = flag2 && flag3 && flag4 && flag5 && flag6 && flag7;
				if (flag8)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_43);
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000BE324 File Offset: 0x000BC524
		private static uint smethod_47(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_142.uint_0 - (num + 44U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 2B C6 00 01 B8 00 00 00 008B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 1281C1",
				Class12.smethod_45(Class53.gstruct51_12.uint_0, 8, false, true),
				"55 89 E5 50E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_142.uint_0 > 0U);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000BE478 File Offset: 0x000BC678
		public static void smethod_48(GStruct49 gstruct49_0, uint uint_53 = 0U)
		{
			bool flag = gstruct49_0.uint_42 > 0U;
			if (flag)
			{
				int num = 0;
				byte[] bytes = BitConverter.GetBytes(uint_53);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_42 + 15U, bytes, bytes.Length, ref num);
				if (flag2)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_42);
				}
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000BE4D0 File Offset: 0x000BC6D0
		private static uint smethod_49(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += Class70.uint_3;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_218.uint_0 - (num2 + 50U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 31 C6 00 01B8",
				Class12.smethod_45(num, 8, false, true),
				"BF",
				Class12.smethod_45(num + 32U, 8, false, true),
				"8B D7 8A 1A 84 DB 74 03 42 EB F7 2B D7 7E 0E 55 89 E5 52 57 50E8",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_218.uint_0 > 0U);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000BE630 File Offset: 0x000BC830
		public static void smethod_50(GStruct49 gstruct49_0, string string_0, string string_1)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_82 != 0U && string_0 != null && !(string_0 == string.Empty) && string_1 != null && !(string_1 == string.Empty);
			if (flag)
			{
				bool flag2 = 127 <= string_1.Length;
				if (flag2)
				{
					string_1 = string_1.Substring(0, 126);
				}
				bool flag3 = (ulong)Class70.uint_3 <= (ulong)((long)string_1.Length);
				if (flag3)
				{
					string_1 = string_1.Substring(0, (int)(Class70.uint_3 - 1U));
				}
				int num = 0;
				byte[] array = Class12.smethod_46(string_1, true);
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_82 - Class70.uint_3 + 32U, array, array.Length, ref num);
				byte[] array2 = Class12.smethod_46(string_0, true);
				bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_82 - Class70.uint_3, array2, array2.Length, ref num);
				bool flag6 = flag4 && flag5;
				if (flag6)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_82);
				}
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000BE734 File Offset: 0x000BC934
		private static uint smethod_51(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += Class70.uint_1;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_219.uint_0 - (num2 + 40U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 27 C6 00 01 B8 00 00 00 00BA",
				Class12.smethod_45(num, 8, false, true),
				"B9 01 00 00 00 55 89 E5 51 50 52E8",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_219.uint_0 > 0U);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000BE878 File Offset: 0x000BCA78
		public static void smethod_52(GStruct49 gstruct49_0, string string_0, int int_0 = 1)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_81 > 0U;
			if (flag)
			{
				bool flag2 = string_0 == null;
				if (!flag2)
				{
					bool flag3 = (ulong)Class70.uint_1 <= (ulong)((long)(string_0.Length - 1));
					if (flag3)
					{
						string_0 = string_0.Substring(0, (int)(Class70.uint_1 - 1U));
					}
					int num = 0;
					byte[] array = Class12.smethod_46(string_0, true);
					byte[] bytes = BitConverter.GetBytes(string_0.Length);
					byte[] bytes2 = BitConverter.GetBytes(int_0);
					bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_81 - Class70.uint_1, array, array.Length, ref num);
					bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_81 + 15U, bytes, 4, ref num);
					bool flag6 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_81 + 25U, bytes2, 4, ref num);
					bool flag7 = flag4 && flag5;
					if (flag7)
					{
						bool flag8 = !flag6;
						if (!flag8)
						{
							Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_81);
						}
					}
				}
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000BE98C File Offset: 0x000BCB8C
		private static uint smethod_53(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += Class70.uint_2;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_217.uint_0 - (num2 + 31U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 1E C6 00 01 55 89 E5 6A 0068",
				Class12.smethod_45(num, 8, false, true),
				"6A 01E8",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_217.uint_0 > 0U);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000BEAD0 File Offset: 0x000BCCD0
		public static void smethod_54(GStruct49 gstruct49_0, string string_0, int int_0)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_80 > 0U;
			if (flag)
			{
				bool flag2 = string_0.Length >= 127;
				if (flag2)
				{
					string_0 = string_0.Substring(0, 126);
				}
				bool flag3 = (long)string_0.Length >= (long)((ulong)Class70.uint_2);
				if (flag3)
				{
					string_0 = string_0.Substring(0, (int)(Class70.uint_2 - 1U));
				}
				int num = 0;
				byte[] array = Class12.smethod_46(string_0, true);
				byte[] byte_ = new byte[]
				{
					(byte)string_0.Length
				};
				byte[] byte_2 = new byte[]
				{
					(byte)int_0
				};
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_80 - Class70.uint_2, array, array.Length, ref num);
				bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_80 + 18U, byte_, 1, ref num);
				bool flag6 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_80 + 25U, byte_2, 1, ref num);
				bool flag7 = flag4 && flag5 && flag6;
				if (flag7)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_80);
				}
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000BEBE0 File Offset: 0x000BCDE0
		public static void smethod_55(GStruct49 gstruct49_0, string string_0, object object_0 = null)
		{
			bool flag = object_0 == null;
			if (flag)
			{
				object_0 = 1;
			}
			bool flag2 = !(object_0.GetType() != string.Empty.GetType());
			if (flag2)
			{
				Class70.smethod_57(gstruct49_0, string.Concat(new string[]
				{
					"Chat('",
					object_0.ToString(),
					"', '",
					string_0,
					"')"
				}));
			}
			else
			{
				Class70.smethod_54(gstruct49_0, string_0, (int)object_0);
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000BEC64 File Offset: 0x000BCE64
		private static uint smethod_56(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += Class70.uint_4;
			uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_221.uint_0 - (num2 + 27U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"80 38 00 75 1A C6 00 01 55 89 E5 68",
				Class12.smethod_45(num, 8, false, true),
				" E8 ",
				Class12.smethod_45(num3, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num2 - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num4 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num4);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num2 * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_221.uint_0 > 0U);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000BEDA8 File Offset: 0x000BCFA8
		public static void smethod_57(GStruct49 gstruct49_0, string string_0)
		{
			bool flag = gstruct49_0.uint_83 == 0U || string_0 == null;
			if (!flag)
			{
				bool flag2 = string_0.Length > 126;
				if (flag2)
				{
					string_0 = string_0.Substring(0, 126);
				}
				bool flag3 = (ulong)Class70.uint_4 <= (ulong)((long)string_0.Length);
				if (flag3)
				{
					string_0 = string_0.Substring(0, (int)(Class70.uint_4 - 1U));
				}
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[1];
				for (;;)
				{
					bool flag4 = !Class12.bool_0;
					if (!flag4)
					{
						goto IL_C3;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_83 - 4U, array, 1, ref num);
					bool flag5 = array[0] > 0;
					if (!flag5)
					{
						goto IL_C2;
					}
					num2++;
					bool flag6 = num2 <= 150;
					if (!flag6)
					{
						break;
					}
					Thread.Sleep(1);
				}
				return;
				IL_C2:
				IL_C3:
				array = Class12.smethod_46(string_0, true);
				bool flag7 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_83 - Class70.uint_4, array, array.Length, ref num);
				if (flag7)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_83);
				}
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000BEEC0 File Offset: 0x000BD0C0
		private static uint smethod_58(ref GStruct49 gstruct49_0, int int_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = Class53.gstruct51_147.uint_0;
			uint num3 = Class53.gstruct51_147.uint_0;
			uint num4 = Class53.gstruct51_144.uint_0;
			bool flag = int_0 > 0;
			if (flag)
			{
				num3 = Class53.gstruct51_149.uint_0;
				num4 = Class53.gstruct51_145.uint_0;
				num2 = Class53.gstruct51_151.uint_0;
			}
			int num5 = 0;
			new byte[4];
			long num6 = Class12.smethod_36(Class53.int_5.ToString() + Class53.int_6.ToString());
			byte b = Convert.ToByte(false);
			uint num7 = gstruct49_0.uint_7 + num4 - (uint)Convert.ToByte(b == 0) * 256U;
			uint num8 = num + 47U;
			uint num9 = num7 - num8;
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 2F C6 01 018B0D",
				Class12.smethod_45(gstruct49_0.uint_7 + num3, 8, false, true),
				"85 C9 74 1A BA 00 00 00 00833D",
				Class12.smethod_45(gstruct49_0.uint_7 + num2, 8, false, true),
				"0074 0C55 89 E5 52E8",
				Class12.smethod_45(num9, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			byte[] array = Class12.smethod_8(string_, false);
			bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num5);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag2 && gstruct49_0.uint_16 > 0U);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000BF094 File Offset: 0x000BD294
		public static bool smethod_59(GStruct49 gstruct49_0, int int_0, int int_1)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			uint num2 = Class53.gstruct51_147.uint_0;
			uint num3 = gstruct49_0.uint_74;
			bool flag = int_1 > 0;
			if (flag)
			{
				num3 = gstruct49_0.uint_75;
				num2 = Class53.gstruct51_151.uint_0;
			}
			bool flag2 = num3 == 0U;
			bool result;
			if (flag2)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < 300; i++)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 - 4U, array, 1, ref num);
					bool flag3 = array[0] == 0;
					if (flag3)
					{
						break;
					}
					Thread.Sleep(1);
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + num2, array2, 4, ref num);
				bool flag4 = BitConverter.ToUInt32(array2, 0) != 0U && array[0] == 0;
				if (flag4)
				{
					array2 = BitConverter.GetBytes(int_0);
					bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, num3 + 25U, array2, 4, ref num);
					if (flag5)
					{
						bool flag6 = Class70.smethod_12(gstruct49_0.int_137, num3);
						for (int j = 0; j < 300; j++)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + num2, array2, 4, ref num);
							bool flag7 = BitConverter.ToInt32(array2, 0) == 0;
							if (flag7)
							{
								break;
							}
							Thread.Sleep(1);
						}
						result = flag6;
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
			return result;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000BF200 File Offset: 0x000BD400
		private static uint smethod_60(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_223.uint_0 - (num + 71U);
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 46 C6 01 018B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 328B89",
				Class12.smethod_45(Class53.gstruct51_13.uint_0, 8, false, true),
				"85 C9 74 28A1",
				Class12.smethod_45(Class53.gstruct51_14.uint_0, 8, false, true),
				"85 C0 74 1F69C9",
				Class12.smethod_45(Class53.gstruct51_15.uint_0, 8, false, true),
				"01 C1 55 89 E5 6A 00 68 9E A3 01 00 68 4A A7 00 00E8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 > 0U);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000BF390 File Offset: 0x000BD590
		public static void smethod_61(GStruct49 gstruct49_0, uint[] uint_53)
		{
			bool flag = gstruct49_0.uint_50 != 0U && uint_53 != null && uint_53[0] != 0U && uint_53[1] != 0U && Class70.smethod_7(gstruct49_0);
			if (flag)
			{
				int num = 0;
				byte[] bytes = BitConverter.GetBytes(uint_53[0]);
				byte[] bytes2 = BitConverter.GetBytes(uint_53[1]);
				bool flag2 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_50 + 57U, bytes2, 4, ref num);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_50 + 62U, bytes, 4, ref num);
				bool flag4 = flag2 && flag3;
				if (flag4)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_50);
				}
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000BF428 File Offset: 0x000BD628
		private static uint smethod_62(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_225.uint_0 - (num + 47U);
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 2E C6 01 018B0D",
				Class12.smethod_45(Class53.gstruct51_236.uint_0, 8, false, true),
				"83 F9 00 74 19 B8 FF FF FF FF BB FF FF FF FF 55 89 E5 53 50 6A 7EE8",
				Class12.smethod_45(num2, 8, false, true),
				"89 EC 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 > 0U);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000BF54C File Offset: 0x000BD74C
		public static bool smethod_63(GStruct49 gstruct49_0, uint[] uint_53)
		{
			bool flag = uint_53 != null && gstruct49_0.uint_87 > 0U;
			if (flag)
			{
				bool flag2 = !Class70.smethod_7(gstruct49_0);
				if (!flag2)
				{
					int num = (int)Math.Round(uint_53[0] / 32m);
					int num2 = (int)Math.Round(uint_53[1] / 32m);
					bool flag3 = num > 0;
					if (flag3)
					{
						bool flag4 = num2 > 0;
						if (flag4)
						{
							int num3 = 0;
							byte[] bytes = BitConverter.GetBytes(num);
							byte[] bytes2 = BitConverter.GetBytes(num2);
							bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_87 + 26U, bytes, 4, ref num3);
							bool flag6 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_87 + 31U, bytes2, 4, ref num3);
							bool flag7 = flag5;
							if (flag7)
							{
								bool flag8 = flag6;
								if (flag8)
								{
									return Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_87);
								}
							}
							return false;
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000BF67C File Offset: 0x000BD87C
		public static bool smethod_64(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_182.uint_0 != 0U && Class53.gstruct51_262.uint_0 > 0U;
			if (flag)
			{
				bool flag2 = gstruct49_0.uint_90 > 0U;
				if (flag2)
				{
					return Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_90);
				}
			}
			return false;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000BF6E4 File Offset: 0x000BD8E4
		private static uint smethod_65(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = "33 C0 50 6A 01 50 6A 56 40A3" + Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_262.uint_0, 8, false, true);
			string string_2 = "83 C4 10";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_182.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000BF744 File Offset: 0x000BD944
		private static uint smethod_655(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = "33 C0 50 6A 01 50 6A 56 40A3" + Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_262.uint_0, 8, false, true);
			string string_2 = "83 C4 14";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_182.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000BF7A4 File Offset: 0x000BD9A4
		private static uint smethod_66(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += 48U;
			string string_ = string.Concat(new string[]
			{
				"B9",
				Class12.smethod_45(num, 8, false, true),
				"8B 01 85 C0 75 23 40 89 01 83 C1 04 8B C18B 0D",
				Class12.smethod_45(Class53.gstruct51_236.uint_0, 8, false, true),
				"85 C9 74 0A 6A 00 50 6A 65"
			});
			string string_2 = "C6 05" + Class12.smethod_45(num, 8, false, true) + "00";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000BF85C File Offset: 0x000BDA5C
		public static bool smethod_67(GStruct49 gstruct49_0, uint uint_53, uint uint_54, uint uint_55)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_225.uint_0 != 0U && Class53.gstruct51_236.uint_0 != 0U && gstruct49_0.uint_47 > 0U;
			bool result;
			if (flag)
			{
				uint num = gstruct49_0.uint_47 - 48U;
				int num2 = 0;
				byte[] array = new byte[1];
				bool flag2 = Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, 1, ref num2) && array[0] <= 0;
				if (flag2)
				{
					byte[] array2 = new byte[8];
					array2[4] = 3;
					array = array2;
					byte[] bytes = BitConverter.GetBytes(uint_53);
					byte[] bytes2 = BitConverter.GetBytes(uint_54);
					byte[] bytes3 = BitConverter.GetBytes(uint_55);
					bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U, array, 8, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 8U, bytes, 4, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 12U, bytes2, 4, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 16U, bytes3, 4, ref num2);
					result = (flag3 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_47));
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

		// Token: 0x06000428 RID: 1064 RVA: 0x000BF984 File Offset: 0x000BDB84
		private static uint smethod_68(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			gstruct49_0.uint_17 += 48U;
			string string_ = string.Concat(new string[]
			{
				"B8",
				Class12.smethod_45(num, 8, false, true),
				"80 38 0075 218B 0D",
				Class12.smethod_45(Class53.gstruct51_236.uint_0, 8, false, true),
				"85 C974 17C6 00 0183 C0 046A 0050 6A 65"
			});
			string string_2 = "C6 05" + Class12.smethod_45(num, 8, false, true) + "00";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000BFA3C File Offset: 0x000BDC3C
		public static bool smethod_69(GStruct49 gstruct49_0, uint uint_53, uint uint_54, uint uint_55)
		{
			bool flag = gstruct49_0.uint_16 == 0U || Class53.gstruct51_225.uint_0 == 0U || Class53.gstruct51_236.uint_0 == 0U || gstruct49_0.uint_48 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = gstruct49_0.uint_48 - 48U;
				int num2 = 0;
				byte[] array = new byte[1];
				bool flag2 = !Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, 1, ref num2) || array[0] > 0;
				if (flag2)
				{
					result = false;
				}
				else
				{
					byte[] array2 = new byte[8];
					array2[0] = 1;
					array2[4] = 3;
					array = array2;
					byte[] bytes = BitConverter.GetBytes(uint_53);
					byte[] bytes2 = BitConverter.GetBytes(uint_54);
					byte[] bytes3 = BitConverter.GetBytes(uint_55);
					bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U, array, array.Length, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 8U, bytes, 4, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 8U + 4U, bytes2, 4, ref num2) && Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U + 8U + 4U + 4U, bytes3, 4, ref num2);
					result = (flag3 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_48));
				}
			}
			return result;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x000BFB6C File Offset: 0x000BDD6C
		private static uint smethod_70(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = string.Concat(new string[]
			{
				"B8 00 00 00 00BA 00 00 00 008B 0D",
				Class12.smethod_45(Class53.gstruct51_236.uint_0, 8, false, true),
				"85 C974 17C6 05",
				Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true),
				"0150526A 59"
			});
			string string_2 = "C6 05" + Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true) + "00";
			gstruct49_0.uint_17 += 4U;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, string_2, 0U);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000BFC2C File Offset: 0x000BDE2C
		public static bool smethod_71(GStruct49 gstruct49_0, uint uint_53, uint uint_54, byte byte_0 = 89)
		{
			bool flag = gstruct49_0.uint_16 == 0U || Class53.gstruct51_225.uint_0 == 0U || Class53.gstruct51_236.uint_0 == 0U || gstruct49_0.uint_46 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[1];
				bool flag2 = !Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_46 - 4U, array, 1, ref num) || array[0] > 0;
				if (flag2)
				{
					result = false;
				}
				else
				{
					array[0] = byte_0;
					bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_46 + 31U, array, 1, ref num);
					if (flag3)
					{
						array = BitConverter.GetBytes(uint_54);
						bool flag4 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_46 + 2U, array, 4, ref num);
						if (flag4)
						{
							result = false;
						}
						else
						{
							array = BitConverter.GetBytes(uint_53);
							bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_46 + 7U, array, 4, ref num);
							result = (flag5 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_46));
						}
					}
					else
					{
						result = false;
					}
				}
			}
			return result;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000BFD38 File Offset: 0x000BDF38
		private static uint smethod_72(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_192.uint_0 - (num + 53U);
			string string_ = string.Concat(new string[]
			{
				"60 B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 37 C6 00 01B8 05000000B9",
				Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_191.uint_0, 8, false, true),
				"8B 1D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"81 C3",
				Class12.smethod_45(Class53.gstruct51_189.uint_0, 8, false, true),
				"8B 5B",
				Class12.smethod_45(Class53.gstruct51_190.uint_0, 2, false, true),
				"55 6A 00 6A 00 50 53 6A 01E8",
				Class12.smethod_45(num2, 8, false, true),
				"83 C4 04 8B E5 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_192.uint_0 > 0U);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000BFED8 File Offset: 0x000BE0D8
		public static bool smethod_73(GStruct49 gstruct49_0, int int_0)
		{
			int num = 0;
			byte[] bytes = BitConverter.GetBytes(int_0);
			bool flag = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_95 + 15U, bytes, 4, ref num);
			return !flag && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_95);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000BFF28 File Offset: 0x000BE128
		private static uint smethod_74(ref GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_188.uint_0 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17 + 4U;
				gstruct49_0.uint_17 += 8U;
				uint num3 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				string string_ = string.Concat(new string[]
				{
					"60BA",
					Class12.smethod_45(num, 8, false, true),
					"C6 42 04 018B0D",
					Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_188.uint_0, 8, false, true),
					"85 C9 74 19 8B 01 85 C0 74 13 8B 40 1C 85 C0 74 0C 6A 00 6A 04 52 68 15 80 00 00 FF D0C6 05",
					Class12.smethod_45(num2, 8, false, true),
					"0061",
					Class70.smethod_10(gstruct49_0.uint_97)
				});
				int num4 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool value = Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array, array.Length, ref num4);
				num3 *= (uint)Convert.ToByte(value);
				gstruct49_0.uint_17 += (uint)(array.Length + 4);
				result = num3;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000C0054 File Offset: 0x000BE254
		public static bool smethod_75(GStruct49 gstruct49_0, string string_0, uint uint_53 = 32769U, uint uint_54 = 4U, uint uint_55 = 0U)
		{
			bool flag = gstruct49_0.uint_93 != 0U && Class53.gstruct51_191.uint_0 > 0U;
			bool result;
			if (flag)
			{
				uint num = Class12.smethod_6(string_0);
				bool flag2 = !Class22.smethod_31(gstruct49_0.uint_93 - 8U, gstruct49_0.int_137, num, 4);
				if (flag2)
				{
					result = false;
				}
				else
				{
					Class22.smethod_31(gstruct49_0.uint_93 + 39U, gstruct49_0.int_137, uint_53, 4);
					Class22.smethod_31(gstruct49_0.uint_93 + 36U, gstruct49_0.int_137, uint_54, 1);
					Class22.smethod_31(gstruct49_0.uint_93 + 34U, gstruct49_0.int_137, uint_55, 1);
					result = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_93);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000C0108 File Offset: 0x000BE308
		private static uint smethod_76(ref GStruct49 gstruct49_0)
		{
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = num + 80U;
			gstruct49_0.uint_17 += Class70.uint_1;
			string string_ = string.Concat(new string[]
			{
				"B8 03 00 00 00BA 3B 00 00 008B 35",
				Class12.smethod_45(Class53.gstruct51_209.uint_0.ToString(), 8, false, true),
				"8D 8E",
				Class12.smethod_45(Class53.gstruct51_208.uint_0.ToString(), 8, false, true),
				"6A 00 6A 00 51 5268",
				Class12.smethod_45(num2.ToString(), 8, false, true),
				"68",
				Class12.smethod_45(num.ToString(), 8, false, true),
				"50 8B CE"
			});
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_210.uint_0, string_, "", 0U);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000C01E0 File Offset: 0x000BE3E0
		private static uint smethod_77(ref GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_16 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				string string_ = string.Concat(new string[]
				{
					"60B8 000000008B0D",
					Class12.smethod_45(Class53.gstruct51_209.uint_0.ToString(), 8, false, true),
					"85 C9 74 2B69C0",
					Class12.smethod_45(Class53.gstruct51_215.uint_0.ToString(), 8, false, true),
					"05",
					Class12.smethod_45(Class53.gstruct51_216.uint_0.ToString(), 8, false, true),
					"03 C8 6A 00 51 68 65 05 00 00 8B 51 60 8B 12 8B 49 60 8B 42 10 85 C0 74 04 FF D0 EB 03 58 58 58 61",
					Class70.smethod_10(gstruct49_0.uint_97)
				});
				byte[] array = Class12.smethod_8(string_, true);
				int num = 0;
				uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				byte b = Convert.ToByte(Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num));
				uint num3 = (uint)((int)b * (array.Length + 4));
				gstruct49_0.uint_17 += num3;
				result = num2 * (uint)b;
			}
			return result;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000C02E0 File Offset: 0x000BE4E0
		private static uint smethod_78(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_166.uint_0.ToString(), 8, false, true);
			string string_ = "B9 00 00 00 00 6A 01 51 8B 0D " + str + "81 C1 " + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_220.uint_0, string_, "", 0U);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000C034C File Offset: 0x000BE54C
		private static uint smethod_79(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_164.uint_0 - (num + 43U);
			string string_ = string.Concat(new string[]
			{
				"60B8",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 38 00 75 27 C6 00 01BE 96 00 00 008B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85 C9 74 0E81C1",
				Class12.smethod_45(Class53.gstruct51_12.uint_0, 8, false, true),
				"6A 01 56E8",
				Class12.smethod_45(num2, 8, false, true),
				"C605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_164.uint_0 != 0U && Class53.gstruct51_11.uint_0 != 0U && Class53.gstruct51_12.uint_0 > 0U);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x000C04B8 File Offset: 0x000BE6B8
		public static bool smethod_80(GStruct49 gstruct49_0, uint uint_53, int int_0)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_41 > 0U;
			bool result;
			if (flag)
			{
				bool flag2 = int_0 > 57;
				if (flag2)
				{
					int_0 = 57;
				}
				int num = 0;
				byte[] byte_ = new byte[]
				{
					(byte)int_0
				};
				byte[] bytes = BitConverter.GetBytes(uint_53);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_41 + 15U, bytes, 4, ref num);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_41 + 36U, byte_, 1, ref num);
				result = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_41);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000C0554 File Offset: 0x000BE754
		private static uint smethod_81(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "8B 0D " + str + " 81 C1 " + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_201.uint_0, string_, "", 0U);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000C05C0 File Offset: 0x000BE7C0
		private static uint smethod_82(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "8B 0D " + str + " 81 C1 " + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_206.uint_0, string_, "", 0U);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000C062C File Offset: 0x000BE82C
		private static uint smethod_83(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "8B 0D" + str + "81 C1" + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_122.uint_0, string_, "", 0U);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000C0698 File Offset: 0x000BE898
		private static uint smethod_84(ref GStruct49 gstruct49_0)
		{
			string string_ = "6A 00 B9 6D 01 00 00 BA 13 01 00 00 51 52";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_222.uint_0, string_, "", 0U);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000C06C8 File Offset: 0x000BE8C8
		private static uint smethod_85(ref GStruct49 gstruct49_0)
		{
			string string_ = "BA 00 00 00 008B 0D" + Class12.smethod_45(Class53.gstruct51_236.uint_0.ToString(), 8, false, true) + "85 C9 74 0A 52 6A 05 6A 58";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, "", 0U);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000C0718 File Offset: 0x000BE918
		private static uint smethod_86(ref GStruct49 gstruct49_0)
		{
			string string_ = "6A 00 6A 00 6A 47";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_225.uint_0, string_, "", 0U);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000C0748 File Offset: 0x000BE948
		private static uint smethod_87(ref GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_16 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				string string_ = "6068 00 00 00 0083 EC 108B 0D" + Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_187.uint_0, 8, false, true) + "85 C9 8B 44 24 10 C6 04 24 84 C6 44 24 01 04 89 44 24 02 C7 44 24 06 00 00 00 00 74 0E 8B 11 8B52 10 6A 0E 8D 44 24 04 50 FF D2 83 C4 14 61" + Class70.smethod_10(gstruct49_0.uint_97);
				gstruct49_0.uint_17 += 8U;
				byte[] array = Class12.smethod_8(string_, true);
				int num2 = 0;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
				gstruct49_0.uint_17 += (uint)(array.Length + 4);
				result = num;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000C07F4 File Offset: 0x000BE9F4
		private static uint smethod_88(ref GStruct49 gstruct49_0)
		{
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_185.uint_0, "6A 01", "83 C4 04", 0U);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000C0824 File Offset: 0x000BEA24
		private static uint smethod_89(ref GStruct49 gstruct49_0)
		{
			string string_ = "6A 00 68 A1 00 00 00 68 11 01 00 00 B9 74 93 68 11";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_186.uint_0, string_, "", 0U);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000C0854 File Offset: 0x000BEA54
		private static uint smethod_90(ref GStruct49 gstruct49_0)
		{
			string string_ = "6A 01 68 00 00 00 00";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_226.uint_0, string_, "83 C4 08", 0U);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000C0884 File Offset: 0x000BEA84
		private static uint smethod_91(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "6A 01A1" + str + "8D 88" + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_227.uint_0, string_, "", 0U);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000C08F0 File Offset: 0x000BEAF0
		private static uint smethod_92(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "6A 01A1" + str + "8D 88" + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_228.uint_0, string_, "", 0U);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000C095C File Offset: 0x000BEB5C
		private static uint smethod_93(ref GStruct49 gstruct49_0)
		{
			string str = Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true);
			string str2 = Class12.smethod_45(Class53.gstruct51_12.uint_0.ToString(), 8, false, true);
			string string_ = "B9 00 00 00 00 518B 0D" + str + "81 C1" + str2;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_229.uint_0, string_, "", 0U);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000C09C8 File Offset: 0x000BEBC8
		private static uint smethod_94(ref GStruct49 gstruct49_0)
		{
			string string_ = string.Concat(new string[]
			{
				"BB 00000000B9",
				Class12.smethod_45(gstruct49_0.uint_16 + gstruct49_0.uint_17, 8, false, true),
				"C701 01000000 51 6A 00 538B0D",
				Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true),
				"85C9 7E 198B89",
				Class12.smethod_45(Class53.gstruct51_13.uint_0, 8, false, true),
				"69C9",
				Class12.smethod_45(Class53.gstruct51_15.uint_0, 8, false, true),
				"030D",
				Class12.smethod_45(Class53.gstruct51_14.uint_0, 8, false, true)
			});
			string string_2 = "EB 02 59 59 59 C701 00000000";
			gstruct49_0.uint_17 += 4U;
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_233.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000C0ABC File Offset: 0x000BECBC
		private static uint smethod_95(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_264.uint_0 - (num + 24U);
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 1A C6 01 01 55 8B EC6A 01E8",
				Class12.smethod_45(num2, 8, false, true),
				"83 C4 04 8B E5 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num3 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num3);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 > 0U);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000C0BBC File Offset: 0x000BEDBC
		private static uint smethod_96(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45(num - 4U, 8, false, true),
				"80 39 00 75 29 C6 01 018B 0D",
				Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, 8, false, true),
				"85 C9 74 15 8B 11 85 D2 74 0F 8B 42 24 85 C0 74 08 55 8B EC FF D0 8B E5 5DC605",
				Class12.smethod_45(num - 4U, 8, false, true),
				"0061",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			int num2 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool flag = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(flag && gstruct49_0.uint_16 != 0U && Class53.gstruct51_151.uint_0 > 0U);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000C0CBC File Offset: 0x000BEEBC
		private static uint smethod_97(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = string.Concat(new string[]
			{
				"60B9",
				Class12.smethod_45((gstruct49_0.uint_16 + gstruct49_0.uint_17).ToString(), 8, false, true),
				"C6 01 00 51B9",
				Class12.smethod_45((gstruct49_0.uint_7 + Class53.gstruct51_234.uint_0).ToString(), 8, false, true),
				"8B C105",
				Class12.smethod_45(Class53.gstruct51_235.uint_0.ToString(), 8, false, true),
				"6A 00 50 68 65 05 00 00 89 48 60 8B 11 85 D2 74 09 8B 42 10 85 C0 74 02 FF D059 C6 01 0161",
				Class70.smethod_10(gstruct49_0.uint_97)
			});
			gstruct49_0.uint_17 += 4U;
			uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
			int num2 = 0;
			byte[] array = Class12.smethod_8(string_, false);
			bool value = Class22.WriteProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
			gstruct49_0.uint_17 += (uint)(array.Length + 4);
			return num * (uint)Convert.ToByte(value);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000C0DC4 File Offset: 0x000BEFC4
		private static uint smethod_98(ref GStruct49 gstruct49_0)
		{
			gstruct49_0.uint_17 += 4U;
			string string_ = "B8 12 00 00 00 B9 01 00 00 00 BA 01 00 00 00 6A 00 51 52 50";
			string string_2 = "83 C4 10";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_182.uint_0, string_, string_2, 0U);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x000C0E00 File Offset: 0x000BF000
		private static uint smethod_99(ref GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_174.uint_0 != 0U && Class53.gstruct51_176.uint_0 != 0U && Class53.gstruct51_175.uint_0 > 0U;
			uint result;
			if (flag)
			{
				uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				gstruct49_0.uint_17 += 22U;
				uint num2 = gstruct49_0.uint_16 + gstruct49_0.uint_17 - 4U;
				string string_ = string.Concat(new string[]
				{
					"A1",
					Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_174.uint_0, 8, false, true),
					"85 C0 74 3A8B 0D",
					Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_175.uint_0, 8, false, true),
					"85 C9 74 30803D",
					Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_176.uint_0, 8, false, true),
					"0074 27C605",
					Class12.smethod_45(num2, 8, false, true),
					"016A 00 6A 00 6A 08 6A 03 6A 01 5068",
					Class12.smethod_45(num, 8, false, true),
					"51"
				});
				string string_2 = "83 C4 20C605" + Class12.smethod_45(num2, 8, false, true) + "00";
				result = Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_176.uint_0, string_, string_2, 0U);
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x000C0F6C File Offset: 0x000BF16C
		private static uint smethod_100(ref GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_174.uint_0 == 0U || Class53.gstruct51_176.uint_0 == 0U || Class53.gstruct51_175.uint_0 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = gstruct49_0.uint_16 + gstruct49_0.uint_17;
				gstruct49_0.uint_17 += 80U;
				string string_ = string.Concat(new string[]
				{
					"B8",
					Class12.smethod_45(gstruct49_0.uint_7 + Class53.gstruct51_177.uint_0, 8, false, true),
					"B9",
					Class12.smethod_45(num, 8, false, true),
					"6A 00 6A 01 6A 20 6A 06 6A 01 50 51 51"
				});
				string string_2 = "83 C4 20";
				result = Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_176.uint_0, string_, string_2, 0U);
			}
			return result;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000C1040 File Offset: 0x000BF240
		private static uint smethod_101(ref GStruct49 gstruct49_0)
		{
			string string_ = "BA 01 00 00 00 6A 00 52 6A 26";
			return Class70.smethod_11(ref gstruct49_0, Class53.gstruct51_196.uint_0, string_, "", 0U);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000C1070 File Offset: 0x000BF270
		public static bool smethod_102(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_16 == 0U || Class53.gstruct51_196.uint_0 == 0U || gstruct49_0.uint_89 == 0U || !Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = Class22.smethod_31(gstruct49_0.uint_89 + 2U, gstruct49_0.int_137, uint_53, 4);
				result = (flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_89));
			}
			return result;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000C10E0 File Offset: 0x000BF2E0
		public static bool smethod_103(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_225.uint_0 != 0U && gstruct49_0.uint_62 > 0U;
			if (flag)
			{
				bool flag2 = !Class70.smethod_7(gstruct49_0);
				if (!flag2)
				{
					bool flag3 = Class22.smethod_31(gstruct49_0.uint_62 + 2U, gstruct49_0.int_137, uint_53, 4);
					return flag3 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_62);
				}
			}
			return false;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000C1168 File Offset: 0x000BF368
		public static bool smethod_104(GStruct49 gstruct49_0, object object_0 = null)
		{
			bool flag = gstruct49_0.uint_86 != 0U && Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_86 - 4U, array, 1, ref num);
				bool flag2 = array[0] <= 0;
				if (flag2)
				{
					string string_ = "0/0";
					bool flag3 = object_0 != null;
					if (flag3)
					{
						bool flag4 = Class12.smethod_1(object_0.GetType().ToString(), "[") > 0;
						if (flag4)
						{
							uint[] array2 = (uint[])object_0;
							decimal num2 = Math.Round(array2[0] / 256m);
							decimal num3 = Math.Round(array2[1] / 512m);
							string_ = num2.ToString() + "/" + num3.ToString();
						}
						else
						{
							string_ = object_0.ToString();
						}
					}
					array = Class12.smethod_46(string_, true);
					bool flag5 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_86 - 22U, array, array.Length, ref num);
					result = (!flag5 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_86));
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

		// Token: 0x0600044D RID: 1101 RVA: 0x000C12B4 File Offset: 0x000BF4B4
		public static bool smethod_105(GStruct49 gstruct49_0, string string_0)
		{
			bool flag = gstruct49_0.uint_88 != 0U && Class70.smethod_7(gstruct49_0);
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = Class12.smethod_46(string_0, true);
				bool flag2 = !Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_88 - 80U, array, array.Length, ref num);
				result = (!flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_88));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000C1324 File Offset: 0x000BF524
		public static bool smethod_106(GStruct49 gstruct49_0, uint uint_53, uint uint_54 = 1U, uint uint_55 = 1U)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_182.uint_0 > 0U;
			if (flag)
			{
				bool flag2 = gstruct49_0.uint_56 > 0U;
				if (flag2)
				{
					bool flag3 = Class22.smethod_31(gstruct49_0.uint_56 + 2U, gstruct49_0.int_137, uint_53, 4);
					bool flag4 = Class22.smethod_31(gstruct49_0.uint_56 + 7U, gstruct49_0.int_137, uint_54, 4);
					bool flag5 = Class22.smethod_31(gstruct49_0.uint_56 + 12U, gstruct49_0.int_137, uint_55, 4);
					bool flag6 = flag3 && flag4;
					if (flag6)
					{
						bool flag7 = flag5;
						if (flag7)
						{
							Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_56);
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000C13EC File Offset: 0x000BF5EC
		public static bool smethod_107(GStruct49 gstruct49_0, object object_0)
		{
			bool flag = gstruct49_0.uint_16 == 0U || Class53.gstruct51_186.uint_0 == 0U || gstruct49_0.uint_64 == 0U || Class53.gstruct51_96.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = 500U;
				uint num2 = 297U;
				uint[] array = new uint[]
				{
					151U,
					181U,
					166U,
					196U
				};
				long long_ = Class12.smethod_27();
				uint num3;
				while ((num3 = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_96.uint_0, gstruct49_0.int_137)) == 0U)
				{
					bool flag2 = Class12.smethod_28(long_) <= 3000L;
					if (!flag2)
					{
						return false;
					}
					Class70.smethod_57(gstruct49_0, "Open([[status]])");
					Thread.Sleep(600);
				}
				uint num4 = 0U;
				string[] array2 = typeof(int).ToString().Split(new char[]
				{
					'.'
				});
				string value = array2[array2.Length - 1].ToUpper();
				bool flag3 = object_0.GetType().ToString().ToUpper().IndexOf(value) >= 0;
				if (flag3)
				{
					string a = object_0.ToString().ToUpper();
					bool flag4 = a == "THANPHAP" || a == "TP";
					if (flag4)
					{
						num4 = 1U;
					}
					else
					{
						bool flag5 = a == "SINHKHI" || a == "SK";
						if (flag5)
						{
							num4 = 2U;
						}
						else
						{
							bool flag6 = a == "NOICONG" || a == "NC";
							if (flag6)
							{
								num4 = 3U;
							}
						}
					}
				}
				else
				{
					num4 = Class12.smethod_12(object_0.ToString());
					bool flag7 = num4 > 3U;
					if (flag7)
					{
						num4 = 3U;
					}
				}
				bool flag8 = Class22.smethod_31(gstruct49_0.uint_64 + 2U, gstruct49_0.int_137, num4, 1);
				bool flag9 = Class22.smethod_31(gstruct49_0.uint_64 + 4U, gstruct49_0.int_137, array[(int)num4], 4);
				bool flag10 = Class22.smethod_31(gstruct49_0.uint_64 + 9U, gstruct49_0.int_137, num2, 4);
				bool flag11 = Class22.smethod_31(gstruct49_0.uint_64 + 14U, gstruct49_0.int_137, num3 + num, 4);
				bool flag12 = flag8 && flag9 && flag10 && flag11;
				if (flag12)
				{
					bool flag14;
					bool flag13 = flag14 = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_64);
					if (flag14)
					{
						Thread.Sleep(300);
					}
					result = flag13;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000C166C File Offset: 0x000BF86C
		public static bool smethod_108(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_16 != 0U && gstruct49_0.uint_79 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				uint num4 = num3 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num5 = BitConverter.ToUInt32(array, 0);
				uint num6 = num5 + num4;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
				int num7 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num8 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num9 = BitConverter.ToInt32(array, 0);
				int num10 = Class83.smethod_39(gstruct49_0);
				bool flag2 = num8 == 0 || num9 == 0 || num7 == 0 || num10 <= 1;
				if (flag2)
				{
					result = false;
				}
				else
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
					int num11 = BitConverter.ToInt32(array, 0);
					bool flag3 = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_79);
					if (flag3)
					{
						int num12 = 0;
						int i = 0;
						byte[] array2 = new byte[1];
						while (i < 10)
						{
							Thread.Sleep(100);
							Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_79 - 4U, array2, 1, ref num12);
							bool flag4 = array2[0] > 0;
							if (flag4)
							{
								array2[0] = 0;
								Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_79 - 4U, array2, 1, ref num12);
								break;
							}
							i++;
						}
						i = 0;
						while (!Class12.bool_0 && i < 50)
						{
							Thread.Sleep(300);
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
							num2 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
							num3 = BitConverter.ToUInt32(array, 0);
							num4 = num3 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
							num5 = BitConverter.ToUInt32(array, 0);
							num6 = num5 + num4;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
							num7 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
							num8 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
							int num13 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
							int num14 = BitConverter.ToInt32(array, 0);
							num10 = Class83.smethod_39(gstruct49_0);
							bool flag5 = num8 > 0 && num14 > 0 && num7 > 0 && num10 > 1 && (num14 != num9 || num13 != num11);
							if (flag5)
							{
								break;
							}
							i++;
						}
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x000C1A04 File Offset: 0x000BFC04
		public static void smethod_109(GStruct49 gstruct49_0, int int_0)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_71 != 0U && Class53.gstruct51_11.uint_0 != 0U && Class53.gstruct51_233.uint_0 != 0U && Class53.gstruct51_13.uint_0 != 0U && Class53.gstruct51_15.uint_0 > 0U;
			if (flag)
			{
				bool flag2 = Class53.gstruct51_14.uint_0 == 0U;
				if (!flag2)
				{
					int num = 0;
					byte[] array = new byte[1];
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_71 - 4U, array, 1, ref num);
					bool flag3 = array[0] <= 0;
					if (flag3)
					{
						Class22.smethod_31(gstruct49_0.uint_71 + 2U, gstruct49_0.int_137, (uint)int_0, 4);
						Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_71);
					}
				}
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000C1AD4 File Offset: 0x000BFCD4
		public static bool smethod_110(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_17 != 0U && Class53.gstruct51_185.uint_0 > 0U;
			bool result;
			if (flag)
			{
				uint num = Convert.ToUInt32(bool_0);
				Class22.smethod_31(gstruct49_0.uint_63 + 2U, gstruct49_0.int_137, num, 1);
				result = Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_63);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000C1B38 File Offset: 0x000BFD38
		public static void smethod_111(GStruct49 gstruct49_0, uint uint_53 = 1U)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_67 > 0U;
			if (flag)
			{
				bool flag2 = uint_53 != 1U;
				if (flag2)
				{
					uint_53 = 0U;
				}
				Class22.smethod_31(gstruct49_0.uint_67 + 2U, gstruct49_0.int_137, uint_53, 1);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_67);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000C1B98 File Offset: 0x000BFD98
		public static void smethod_112(GStruct49 gstruct49_0, uint uint_53 = 1U)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_68 > 0U;
			if (flag)
			{
				bool flag2 = uint_53 != 1U;
				if (flag2)
				{
					uint_53 = 0U;
					uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
					uint num2 = num + Class53.gstruct51_75.uint_0;
					uint num3 = (4U + Class53.gstruct51_230.uint_0) * 7U;
					Class22.smethod_31(num2 + num3 * 4U, gstruct49_0.int_137, 0U, 4);
				}
				Class22.smethod_31(gstruct49_0.uint_68 + 2U, gstruct49_0.int_137, uint_53, 1);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_68);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000C1C50 File Offset: 0x000BFE50
		public static uint smethod_113(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
			uint num2 = num + Class53.gstruct51_75.uint_0;
			uint num3 = (4U + Class53.gstruct51_230.uint_0) * 7U;
			return Class22.smethod_30(num2 + num3 * 4U, gstruct49_0.int_137);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000C1CB0 File Offset: 0x000BFEB0
		public static void smethod_114(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_69 > 0U;
			if (flag)
			{
				Class22.smethod_31(gstruct49_0.uint_69 + 2U, gstruct49_0.int_137, uint_53, 4);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_69);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000C1D00 File Offset: 0x000BFF00
		public static void smethod_115(GStruct49 gstruct49_0, string[] string_0 = null)
		{
			bool flag = gstruct49_0.uint_17 == 0U || gstruct49_0.uint_66 == 0U;
			if (!flag)
			{
				string text = Class52.smethod_2(gstruct49_0, true);
				string[] array = text.Split(new char[]
				{
					';'
				});
				bool flag2 = array.Length < 2;
				if (!flag2)
				{
					bool flag3 = string_0 != null && string_0.Length != 0;
					if (flag3)
					{
						for (int i = 0; i < string_0.Length; i++)
						{
							bool flag4 = array[1] == string_0[i] || Class10.smethod_1(array[1], 1, false) == string_0[i];
							if (flag4)
							{
								Class52.smethod_0(gstruct49_0);
								return;
							}
						}
					}
					uint num = Class12.smethod_12(array[0]);
					Class22.smethod_31(gstruct49_0.uint_66 + 4U, gstruct49_0.int_137, num, 4);
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_66);
				}
			}
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000C1DE8 File Offset: 0x000BFFE8
		public static void smethod_116(GStruct49 gstruct49_0, uint uint_53, uint uint_54)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_49 > 0U;
			if (flag)
			{
				Class22.smethod_31(gstruct49_0.uint_49 + 4U, gstruct49_0.int_137, uint_54, 4);
				Class22.smethod_31(gstruct49_0.uint_49 + 9U, gstruct49_0.int_137, uint_53, 4);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_49);
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000C1E50 File Offset: 0x000C0050
		public static bool smethod_117(GStruct49 gstruct49_0, uint uint_53)
		{
			bool flag = gstruct49_0.uint_16 != 0U && Class53.gstruct51_187.uint_0 != 0U && gstruct49_0.uint_65 > 0U;
			bool result;
			if (flag)
			{
				bool flag2 = Class22.smethod_31(gstruct49_0.uint_65 + 2U, gstruct49_0.int_137, uint_53, 4);
				result = (flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_65));
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000C1EB9 File Offset: 0x000C00B9
		public static void smethod_118(GStruct49 gstruct49_0)
		{
			Class70.smethod_106(gstruct49_0, 34U, 1U, 1U);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000C1EC7 File Offset: 0x000C00C7
		public static void smethod_119(GStruct49 gstruct49_0)
		{
			Class70.smethod_106(gstruct49_0, 18U, 1U, 1U);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x000C1ED8 File Offset: 0x000C00D8
		public static void smethod_120(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_17 == 0U;
			if (!flag)
			{
				bool flag2 = gstruct49_0.uint_59 == 0U;
				if (!flag2)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_59);
				}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000C1F1C File Offset: 0x000C011C
		public static void smethod_121(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_44 > 0U;
			if (flag)
			{
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_44);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000C1F54 File Offset: 0x000C0154
		public static string smethod_122(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			string text = "";
			string text2 = "";
			uint[] array = Class36.smethod_30(gstruct49_0);
			bool flag = array == null;
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				uint uint_ = array[0];
				uint uint_2 = array[1];
				uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
				int num3 = 25;
				for (int i = 0; i < 256; i++)
				{
					uint num4 = num + (uint)(i * (int)Class53.gstruct51_15.uint_0);
					int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					bool flag2 = num5 > 0;
					if (flag2)
					{
						int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
						uint num7 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
						uint num8 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
						long num9 = (long)((ulong)Class70.smethod_4(uint_, uint_2, num7, num8));
						string text3 = "\"" + Class22.smethod_28(num4 + Class53.gstruct51_16.uint_0, gstruct49_0.int_137, 40) + "\"";
						while (text3.Length < num3)
						{
							text3 += " ";
						}
						string text4 = text;
						text = string.Concat(new string[]
						{
							text4,
							"-- ",
							i.ToString(),
							"\t",
							num6.ToString(),
							"   \t",
							text3,
							" {",
							num7.ToString(),
							",",
							num8.ToString(),
							"}, ( ",
							(num7 / 256U).ToString(),
							",",
							(num8 / 512U).ToString(),
							" )\t",
							num9.ToString(),
							"\t",
							Math.Round(Math.Sqrt((double)num9), 0).ToString(),
							Class53.string_7
						});
					}
					int num10 = (int)Class22.smethod_30(num2 + (uint)(i * (int)Class53.gstruct51_127.uint_0), gstruct49_0.int_137);
					bool flag3 = num10 > 0;
					if (flag3)
					{
						int num11 = Class78.smethod_6(gstruct49_0, i, num2);
						uint[] array2 = Class78.smethod_3(gstruct49_0, i, num2);
						bool flag4 = array2 == null;
						if (flag4)
						{
							uint[] array3 = new uint[2];
							array2 = array3;
						}
						long num12 = (long)((ulong)Class70.smethod_4(uint_, uint_2, array2[0], array2[1]));
						string text5 = "\"" + Class78.smethod_5(gstruct49_0, i, num2, false) + "\"";
						while (text5.Length < num3)
						{
							text5 += " ";
						}
						string text6 = text2;
						text2 = string.Concat(new string[]
						{
							text6,
							"-- ",
							i.ToString(),
							"\t",
							num11.ToString(),
							"   \t",
							text5,
							" {",
							array2[0].ToString(),
							",",
							array2[1].ToString(),
							"}, ( ",
							(array2[0] / 256U).ToString(),
							",",
							(array2[1] / 512U).ToString(),
							" )\t",
							num12.ToString(),
							"\t",
							Math.Round(Math.Sqrt((double)num12), 0).ToString(),
							Class53.string_7
						});
					}
				}
				string text7 = string.Concat(new string[]
				{
					"MapID = ",
					Class37.smethod_0(gstruct49_0).ToString(),
					Class53.string_7,
					"MapName = \"",
					Class37.smethod_2(gstruct49_0),
					"\"",
					Class53.string_7,
					"PosXY = ",
					uint_.ToString(),
					",",
					uint_2.ToString(),
					Class53.string_7,
					"=============================================================================================",
					Class53.string_7,
					"-- STT\tKind\tNPC name    \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)",
					Class53.string_7,
					"[npc]",
					Class53.string_7,
					"=============================================================================================",
					Class53.string_7,
					"-- STT\tKind\tObject name  \t\t  {posx, posy}\t   x/y screen\tLength\tSqrt(Length)",
					Class53.string_7,
					"[object]",
					Class53.string_7
				});
				text7 = text7.Replace("[npc]", text).Replace("[object]", text2) + Class53.string_7 + "=============================================================================================";
				if (bool_0)
				{
					string string_ = "Software\\Microsoft\\Notepad";
					string text8 = Class62.smethod_1(string_, "lfFaceName", 0, "");
					Class53.smethod_25("object_npc_info.txt", text7, true, "VK Sans Serif", 12, 870, 425, 200, 280);
					bool flag5 = text8 != "";
					if (flag5)
					{
						Class62.smethod_10(string_, "lfFaceName", text8, "", 1);
					}
				}
				result = text7;
			}
			return result;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000C2508 File Offset: 0x000C0708
		public static string smethod_123(GStruct49 gstruct49_0, int int_0 = 0)
		{
			uint[] array = Class36.smethod_30(gstruct49_0);
			bool flag = array == null;
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				int num = Class36.smethod_17(gstruct49_0);
				uint uint_ = array[0];
				uint uint_2 = array[1];
				uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
				int num4 = -1;
				long num5 = 0L;
				uint[] array2 = null;
				string text = "";
				int num6 = -1;
				long num7 = 0L;
				uint[] array3 = null;
				string text2 = "";
				for (int i = 0; i < 256; i++)
				{
					uint num8 = num2 + (uint)(i * (int)Class53.gstruct51_15.uint_0);
					int num9 = (int)Class22.smethod_30(num8 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					bool flag2 = i != num && num9 > 0;
					if (flag2)
					{
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						long num10 = (long)((ulong)Class70.smethod_4(uint_, uint_2, array4[0], array4[1]));
						bool flag3 = num4 < 0 || num10 < num5;
						if (flag3)
						{
							num4 = i;
							num5 = num10;
							array2 = array4;
							text = Class22.smethod_28(num8 + Class53.gstruct51_16.uint_0, gstruct49_0.int_137, 40);
						}
					}
					int num11 = (int)Class22.smethod_30(num3 + (uint)(i * (int)Class53.gstruct51_127.uint_0), gstruct49_0.int_137);
					bool flag4 = num11 > 0;
					if (flag4)
					{
						uint[] array5 = Class78.smethod_3(gstruct49_0, i, num3);
						bool flag5 = array5 == null;
						if (flag5)
						{
							uint[] array6 = new uint[2];
							array5 = array6;
						}
						long num12 = (long)((ulong)Class70.smethod_4(uint_, uint_2, array5[0], array5[1]));
						bool flag6 = num6 < 0 || num12 < num7;
						if (flag6)
						{
							num6 = i;
							num7 = num12;
							array3 = array5;
							text2 = Class78.smethod_5(gstruct49_0, i, num3, false);
						}
					}
				}
				bool flag7 = num6 > 0 && (num4 < 0 || num7 < num5);
				if (flag7)
				{
					num4 = num6;
					num5 = num7;
					array2 = array3;
					text = text2;
				}
				string text3 = "";
				if (int_0 != 1)
				{
					if (int_0 != 2)
					{
						bool flag8 = num4 > 0 && array2 != null;
						if (flag8)
						{
							text3 = string.Concat(new string[]
							{
								num4.ToString(),
								"|",
								text,
								"|X = ",
								array2[0].ToString(),
								", Y = ",
								array2[1].ToString(),
								"|",
								num5.ToString()
							});
						}
					}
					else
					{
						text3 = string.Concat(new string[]
						{
							"{ X = ",
							array2[0].ToString(),
							", Y = ",
							array2[1].ToString(),
							" }"
						});
					}
				}
				else
				{
					text3 = text;
				}
				result = text3;
			}
			return result;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000C2858 File Offset: 0x000C0A58
		public static string smethod_124(GStruct49 gstruct49_0, int int_0)
		{
			uint[] array = Class36.smethod_30(gstruct49_0);
			bool flag = array != null;
			string result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct49_0.int_137);
				uint num2 = num + (uint)(int_0 * (int)Class53.gstruct51_15.uint_0);
				int num3 = (int)Class22.smethod_30(num2 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num4 = (int)Class22.smethod_30(num2 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
				uint uint_ = Class22.smethod_30(num2 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
				uint uint_2 = Class22.smethod_30(num2 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
				long num5 = (long)((ulong)Class70.smethod_4(array[0], array[1], uint_, uint_2));
				string text = "\"" + Class22.smethod_28(num2 + Class53.gstruct51_16.uint_0, gstruct49_0.int_137, 40) + "\"";
				result = string.Concat(new string[]
				{
					"MapID = ",
					Class37.smethod_0(gstruct49_0).ToString(),
					Class53.string_7,
					Class37.smethod_2(gstruct49_0),
					Class53.string_7,
					"=============================",
					Class53.string_7,
					"- Exist\t: ",
					num3.ToString(),
					Class53.string_7,
					"- Kind\t: ",
					num4.ToString(),
					Class53.string_7,
					"- Name\t: ",
					text,
					Class53.string_7,
					"- NOPos\t: {",
					array[0].ToString(),
					",",
					array[1].ToString(),
					"}",
					Class53.string_7,
					"- Length\t: ",
					num5.ToString(),
					Class53.string_7,
					"- Sqrt(L)\t: ",
					((int)Math.Sqrt((double)num5)).ToString()
				});
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000C2A98 File Offset: 0x000C0C98
		public static void TestCall(GStruct49 gstruct49_0, RemoteThreadParams _parameters)
		{
			int num = 0;
			uint num2 = 5475584U;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(_parameters));
			Console.WriteLine(intPtr);
			Marshal.StructureToPtr(_parameters, intPtr, false);
			uint value = Class22.smethod_1(gstruct49_0.int_137, (uint)Marshal.SizeOf(_parameters), GEnum1.flag_2);
			Console.WriteLine(value);
			Class22.WriteProcessMemory(gstruct49_0.int_137, value, BitConverter.GetBytes(intPtr.ToInt32()), Marshal.SizeOf(_parameters), ref num);
			Marshal.FreeHGlobal(intPtr);
			uint num3 = 0U;
			uint num4 = Class22.CreateRemoteThread(gstruct49_0.int_137, IntPtr.Zero, 0U, num2, value, 0U, out num3);
			bool flag = num4 > 0U;
			if (flag)
			{
				Class22.WaitForSingleObject(num4, 30000U);
				Class22.smethod_32((int)num4);
			}
		}

		// Token: 0x04000354 RID: 852
		public static uint uint_0 = 65536U;

		// Token: 0x04000355 RID: 853
		public static uint uint_1 = 512U;

		// Token: 0x04000356 RID: 854
		private static uint uint_2 = 256U;

		// Token: 0x04000357 RID: 855
		private static uint uint_3 = 256U;

		// Token: 0x04000358 RID: 856
		private static uint uint_4 = 256U;

		// Token: 0x04000359 RID: 857
		public static uint uint_5 = 1U;

		// Token: 0x0400035A RID: 858
		public static uint uint_6 = 2U;

		// Token: 0x0400035B RID: 859
		public static uint uint_7 = 3U;

		// Token: 0x0400035C RID: 860
		public static uint uint_8 = 4U;

		// Token: 0x0400035D RID: 861
		public static uint uint_9 = 5U;

		// Token: 0x0400035E RID: 862
		public static uint uint_10 = 6U;

		// Token: 0x0400035F RID: 863
		public static uint uint_11 = 7U;

		// Token: 0x04000360 RID: 864
		public static uint uint_12 = 8U;

		// Token: 0x04000361 RID: 865
		public static uint uint_13 = 9U;

		// Token: 0x04000362 RID: 866
		public static uint uint_14 = 10U;

		// Token: 0x04000363 RID: 867
		public static uint uint_15 = 11U;

		// Token: 0x04000364 RID: 868
		public static uint uint_16 = 12U;

		// Token: 0x04000365 RID: 869
		public static uint uint_17 = 15U;

		// Token: 0x04000366 RID: 870
		public static uint uint_18 = 16U;

		// Token: 0x04000367 RID: 871
		public static uint uint_19 = 18U;

		// Token: 0x04000368 RID: 872
		public static uint uint_20 = 20U;

		// Token: 0x04000369 RID: 873
		public static uint uint_21 = 22U;

		// Token: 0x0400036A RID: 874
		public static uint uint_22 = 24U;

		// Token: 0x0400036B RID: 875
		public static uint uint_23 = 25U;

		// Token: 0x0400036C RID: 876
		public static uint uint_24 = 26U;

		// Token: 0x0400036D RID: 877
		public static uint uint_25 = 27U;

		// Token: 0x0400036E RID: 878
		public static uint uint_26 = 29U;

		// Token: 0x0400036F RID: 879
		public static uint uint_27 = 32U;

		// Token: 0x04000370 RID: 880
		public static uint uint_28 = 33U;

		// Token: 0x04000371 RID: 881
		public static uint uint_29 = 34U;

		// Token: 0x04000372 RID: 882
		public static uint uint_30 = 35U;

		// Token: 0x04000373 RID: 883
		public static uint uint_31 = 36U;

		// Token: 0x04000374 RID: 884
		public static uint uint_32 = 37U;

		// Token: 0x04000375 RID: 885
		public static uint uint_33 = 39U;

		// Token: 0x04000376 RID: 886
		public static uint uint_34 = 40U;

		// Token: 0x04000377 RID: 887
		public static uint uint_35 = 41U;

		// Token: 0x04000378 RID: 888
		public static uint uint_36 = 48U;

		// Token: 0x04000379 RID: 889
		public static uint uint_37 = 50U;

		// Token: 0x0400037A RID: 890
		public static uint uint_38 = 64U;

		// Token: 0x0400037B RID: 891
		public static uint uint_39 = 66U;

		// Token: 0x0400037C RID: 892
		public static uint uint_40 = 67U;

		// Token: 0x0400037D RID: 893
		public static uint uint_41 = 68U;

		// Token: 0x0400037E RID: 894
		public static uint uint_42 = 69U;

		// Token: 0x0400037F RID: 895
		public static uint uint_43 = 70U;

		// Token: 0x04000380 RID: 896
		public static uint uint_44 = 71U;

		// Token: 0x04000381 RID: 897
		public static uint uint_45 = 72U;

		// Token: 0x04000382 RID: 898
		public static uint uint_46 = 75U;

		// Token: 0x04000383 RID: 899
		public static uint uint_47 = 76U;

		// Token: 0x04000384 RID: 900
		public static uint uint_48 = 78U;

		// Token: 0x04000385 RID: 901
		public static uint uint_49 = 79U;

		// Token: 0x04000386 RID: 902
		public static uint uint_50 = 80U;

		// Token: 0x04000387 RID: 903
		public static uint uint_51 = 256U;

		// Token: 0x04000388 RID: 904
		public static uint uint_52 = 0U;
	}
}
