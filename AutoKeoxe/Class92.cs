using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000059 RID: 89
	internal class Class92
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x000EB3C8 File Offset: 0x000E95C8
		public static bool smethod_0(GStruct49 gstruct49_0, uint uint_0)
		{
			Class92.Struct26 @struct = new Class92.Struct26
			{
				int_0 = gstruct49_0.int_136,
				int_1 = Class22.OpenProcess(2035711, false, gstruct49_0.int_136),
				uint_0 = Class22.smethod_1(gstruct49_0.int_137, 512U, GEnum1.flag_2)
			};
			bool flag = @struct.int_0 <= 0 || @struct.int_1 == 0 || @struct.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = gstruct49_0.uint_7 + Class53.gstruct51_192.uint_0 - (@struct.uint_0 + 49U);
				string string_ = string.Concat(new string[]
				{
					"60 B9 ",
					Class12.smethod_45(@struct.uint_0.ToString(), 8, false, true),
					"51 B8 ",
					Class12.smethod_45(uint_0.ToString(), 8, false, true),
					"B9",
					Class12.smethod_45((gstruct49_0.uint_7 + Class53.gstruct51_191.uint_0).ToString(), 8, false, true),
					"8B 1D",
					Class12.smethod_45(Class53.gstruct51_11.uint_0.ToString(), 8, false, true),
					"81 C3",
					Class12.smethod_45(Class53.gstruct51_189.uint_0.ToString(), 8, false, true),
					"8B 5B",
					Class12.smethod_45(Class53.gstruct51_190.uint_0.ToString(), 2, false, true),
					"6A 00 6A 00 50 53 6A 00E8",
					Class12.smethod_45(num.ToString(), 8, false, true),
					"83 C4 04 59 C6 01 0161 C3"
				});
				bool flag2 = false;
				int num2 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, @struct.uint_0 + 4U, array, array.Length, ref num2);
				if (flag3)
				{
					byte[] array2 = new byte[1];
					array = array2;
					Class22.WriteProcessMemory(@struct.int_1, @struct.uint_0, array, 1, ref num2);
					Class92.smethod_4(@struct.int_1, @struct.uint_0 + 4U);
					long long_ = Class12.smethod_27();
					while (Class12.smethod_28(long_) < 10000L)
					{
						Thread.Sleep(150);
						Class22.ReadProcessMemory(@struct.int_1, @struct.uint_0, array, 1, ref num2);
						bool flag4 = array[0] > 0;
						if (flag4)
						{
							break;
						}
					}
					Thread.Sleep(300);
					flag2 = true;
				}
				Class22.smethod_2(@struct.int_1, @struct.uint_0);
				Class22.smethod_32(@struct.int_1);
				result = flag2;
			}
			return result;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000EB658 File Offset: 0x000E9858
		private static bool smethod_1(GStruct49 gstruct49_0, uint uint_0)
		{
			return Class92.smethod_3(gstruct49_0, uint_0, 0);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000EB674 File Offset: 0x000E9874
		private static bool smethod_2(GStruct49 gstruct49_0, uint uint_0)
		{
			return Class92.smethod_3(gstruct49_0, uint_0, 1);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000EB690 File Offset: 0x000E9890
		private static bool smethod_3(GStruct49 gstruct49_0, uint uint_0, int int_0)
		{
			Class92.Struct26 @struct = new Class92.Struct26
			{
				int_0 = gstruct49_0.int_136,
				int_1 = Class22.OpenProcess(2035711, false, gstruct49_0.int_136),
				uint_0 = Class22.smethod_1(gstruct49_0.int_137, 512U, GEnum1.flag_2)
			};
			bool flag = @struct.int_0 <= 0 || @struct.int_1 == 0 || @struct.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = gstruct49_0.uint_7 + Class53.gstruct51_225.uint_0 - (@struct.uint_0 + 38U);
				string string_ = string.Concat(new string[]
				{
					"60 8B EC 50 51B9 ",
					Class12.smethod_45(@struct.uint_0.ToString(), 8, false, true),
					"51 B8 ",
					Class12.smethod_45(uint_0.ToString(), 8, false, true),
					"50 B8 ",
					Class12.smethod_45(int_0.ToString(), 8, false, true),
					"50 B8 05 00 00 0050 E8 ",
					Class12.smethod_45(num.ToString(), 8, false, true),
					"59 C6 01 0159 58 61 C3"
				});
				bool flag2 = false;
				int num2 = 0;
				byte[] array = Class12.smethod_8(string_, false);
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, @struct.uint_0 + 4U, array, array.Length, ref num2);
				if (flag3)
				{
					byte[] array2 = new byte[1];
					array = array2;
					Class22.WriteProcessMemory(@struct.int_1, @struct.uint_0, array, 1, ref num2);
					Class92.smethod_4(@struct.int_1, @struct.uint_0 + 4U);
					long long_ = Class12.smethod_27();
					while (Class12.smethod_28(long_) < 10000L)
					{
						Thread.Sleep(150);
						Class22.ReadProcessMemory(@struct.int_1, @struct.uint_0, array, 1, ref num2);
						bool flag4 = array[0] > 0;
						if (flag4)
						{
							break;
						}
					}
					Thread.Sleep(300);
					flag2 = true;
				}
				Class22.smethod_2(@struct.int_1, @struct.uint_0);
				Class22.smethod_32(@struct.int_1);
				result = flag2;
			}
			return result;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000EB8A0 File Offset: 0x000E9AA0
		private static void smethod_4(int int_0, uint uint_0)
		{
			uint num = 0U;
			uint num2 = Class22.CreateRemoteThread(int_0, IntPtr.Zero, 0U, uint_0, 0U, 0U, out num);
			Class22.WaitForSingleObject(num2, 30000U);
			Class22.smethod_32((int)num2);
		}

		// Token: 0x020000FD RID: 253
		public struct Struct26
		{
			// Token: 0x0400126B RID: 4715
			public int int_0;

			// Token: 0x0400126C RID: 4716
			public int int_1;

			// Token: 0x0400126D RID: 4717
			public uint uint_0;
		}
	}
}
