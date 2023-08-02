using System;
using System.Diagnostics;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000006 RID: 6
	internal class Class102
	{
		// Token: 0x06000018 RID: 24 RVA: 0x000076AC File Offset: 0x000058AC
		public static int smethod_0(string string_0, string string_1, ref byte[] byte_0, ref uint[] uint_0, ref uint uint_1, string string_2, ref byte[] byte_1, ref uint[] uint_2, ref uint uint_3, string string_3, ref byte[] byte_2, ref uint[] uint_4, ref uint uint_5, string string_4)
		{
			uint_0 = null;
			uint_2 = null;
			uint_4 = null;
			byte_0 = null;
			byte_1 = null;
			byte_2 = null;
			bool flag = string_2 == null || string_2 == string.Empty;
			if (flag)
			{
				string_2 = ".text";
			}
			bool flag2 = string_3 == null || string_3 == string.Empty;
			if (flag2)
			{
				string_3 = ".text";
			}
			bool flag3 = string_4 == null || string_4 == string.Empty;
			if (flag3)
			{
				string_4 = ".text";
			}
			int[] array = Class22.smethod_24(string_0, string_1, false);
			bool flag4 = array != null;
			int result;
			if (flag4)
			{
				Process process = null;
				int num = 0;
				long num2 = 0L;
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						Process processById = Process.GetProcessById(array[i]);
						bool flag5 = num2 < processById.StartTime.Ticks;
						if (flag5)
						{
							process = processById;
							num = array[i];
							num2 = processById.StartTime.Ticks;
						}
					}
					catch
					{
					}
				}
				bool flag6 = process != null && !Class22.smethod_52(process);
				if (flag6)
				{
					long num3 = 0L;
					int num4 = Class22.OpenProcess(2035711, false, num);
					int num5 = 0;
					while (!Class12.bool_0)
					{
						try
						{
							uint num6 = (uint)((int)process.MainModule.EntryPointAddress);
							uint_3 = Class22.smethod_37(num, "engine.dll");
							uint_5 = Class22.smethod_37(num, "lualibdll.dll");
							uint_1 = (uint)((int)process.MainModule.BaseAddress);
							bool flag7 = uint_1 == 0U || num6 == 0U || uint_3 == 0U || uint_5 == 0U;
							if (flag7)
							{
								goto IL_1A3;
							}
						}
						catch
						{
							goto IL_1A3;
						}
						break;
						IL_1A3:
						num3 += 1L;
						bool flag8 = num3 <= 3000L;
						if (flag8)
						{
							Class22.smethod_45(process);
							Thread.Sleep(1);
							Class22.smethod_43(process);
							continue;
						}
						return -2;
						break;
					}
					uint_0 = Class22.smethod_66(num4, uint_1, string_2);
					bool flag9 = uint_0 == null || uint_0[0] == 0U || uint_0[1] == 0U;
					if (flag9)
					{
						uint[] array2 = Class22.smethod_65(num4, uint_1, 10);
						bool flag10 = array2 == null || array2[0] == 0U || array2[1] == 0U;
						if (flag10)
						{
							goto IL_636;
						}
						uint_0 = new uint[]
						{
							array2[1],
							4096U
						};
					}
					uint_2 = Class22.smethod_66(num4, uint_3, string_3);
					bool flag11 = uint_2 == null;
					if (flag11)
					{
						uint[] array3 = Class22.smethod_65(num4, uint_3, 10);
						bool flag12 = array3 == null || array3[0] == 0U || array3[1] == 0U;
						if (flag12)
						{
							goto IL_636;
						}
						uint_2 = new uint[]
						{
							array3[1],
							4096U
						};
					}
					uint_4 = Class22.smethod_66(num4, uint_5, string_4);
					bool flag13 = uint_4 == null;
					if (flag13)
					{
						uint[] array4 = Class22.smethod_65(num4, uint_5, 10);
						bool flag14 = array4 == null || array4[0] == 0U || array4[1] == 0U;
						if (flag14)
						{
							goto IL_636;
						}
						uint_4 = new uint[]
						{
							array4[1],
							4096U
						};
					}
					byte_0 = new byte[uint_0[0]];
					bool flag15 = uint_0[0] >= 2147483647U;
					if (flag15)
					{
						num3 = 0L;
						while (num3 < (long)((ulong)uint_0[0]))
						{
							int num7 = int.MaxValue;
							bool flag16 = num3 + (long)num7 > (long)((ulong)uint_0[0]);
							if (flag16)
							{
								num7 = (int)((ulong)uint_0[1] - (ulong)num3);
							}
							byte[] array5 = new byte[num7];
							bool flag17 = Class22.ReadProcessMemory(num4, (uint)((ulong)(uint_1 + uint_0[1]) + (ulong)num3), array5, num7, ref num5);
							for (int j = 0; j < num7; j++)
							{
								byte_0[(int)(checked((IntPtr)(unchecked((long)j + num3))))] = array5[j];
							}
							num3 += (long)num7;
							bool flag18 = flag17;
							if (!flag18)
							{
								byte_0 = null;
								goto IL_636;
							}
						}
					}
					else
					{
						bool flag19 = !Class22.ReadProcessMemory(num4, uint_1 + uint_0[1], byte_0, byte_0.Length, ref num5);
						if (flag19)
						{
							byte_0 = null;
							goto IL_636;
						}
					}
					byte_1 = new byte[uint_2[0]];
					bool flag20 = uint_2[0] >= 2147483647U;
					if (flag20)
					{
						num3 = 0L;
						while (num3 < (long)((ulong)uint_2[0]))
						{
							int num8 = int.MaxValue;
							bool flag21 = num3 + (long)num8 > (long)((ulong)uint_2[0]);
							if (flag21)
							{
								num8 = (int)((ulong)uint_2[1] - (ulong)num3);
							}
							byte[] array6 = new byte[num8];
							int num9 = 0;
							bool flag17 = Class22.ReadProcessMemory(num4, (uint)((ulong)(uint_3 + uint_2[1]) + (ulong)num3), array6, num8, ref num9);
							for (int k = 0; k < num8; k++)
							{
								byte_1[(int)(checked((IntPtr)(unchecked((long)k + num3))))] = array6[k];
							}
							num3 += (long)num8;
							bool flag22 = flag17;
							if (!flag22)
							{
								uint_2 = null;
								byte_1 = null;
								goto IL_636;
							}
						}
					}
					else
					{
						int num10 = 0;
						bool flag23 = !Class22.ReadProcessMemory(num4, uint_3 + uint_2[1], byte_1, byte_1.Length, ref num10);
						if (flag23)
						{
							uint_2 = null;
							byte_1 = null;
						}
					}
					byte_2 = new byte[uint_4[0]];
					bool flag24 = uint_4[0] < 2147483647U;
					if (flag24)
					{
						int num11 = 0;
						bool flag25 = !Class22.ReadProcessMemory(num4, uint_5 + uint_4[1], byte_2, byte_2.Length, ref num11);
						if (flag25)
						{
							uint_4 = null;
							byte_2 = null;
						}
					}
					else
					{
						num3 = 0L;
						while (num3 < (long)((ulong)uint_4[0]))
						{
							int num12 = int.MaxValue;
							bool flag26 = num3 + (long)num12 > (long)((ulong)uint_4[0]);
							if (flag26)
							{
								num12 = (int)((ulong)uint_4[1] - (ulong)num3);
							}
							byte[] array7 = new byte[num12];
							int num13 = 0;
							bool flag17 = Class22.ReadProcessMemory(num4, (uint)((ulong)(uint_3 + uint_4[1]) + (ulong)num3), array7, num12, ref num13);
							for (int l = 0; l < num12; l++)
							{
								byte_2[(int)(checked((IntPtr)(unchecked((long)l + num3))))] = array7[l];
							}
							num3 += (long)num12;
							bool flag27 = !flag17;
							if (flag27)
							{
								uint_4 = null;
								byte_2 = null;
								break;
							}
						}
					}
					IL_636:
					bool value = byte_0 != null && byte_1 != null && uint_0 != null && uint_2 != null && uint_0[1] != 0U && uint_2[1] > 0U;
					result = num4 * (int)Convert.ToByte(value);
				}
				else
				{
					result = -1;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007D50 File Offset: 0x00005F50
		public static bool smethod_1(ref GStruct51 gstruct51_0, string[,] string_0)
		{
			string b = Class12.smethod_6(gstruct51_0.string_0).ToString();
			bool flag = string_0 != null;
			if (flag)
			{
				for (int i = 0; i < string_0.GetLength(0); i++)
				{
					bool flag2 = string_0[i, 0] == b;
					if (flag2)
					{
						gstruct51_0.uint_0 = Class12.smethod_12(string_0[i, 1]);
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00007DCC File Offset: 0x00005FCC
		private static string smethod_2(string[] string_0, string string_1, string string_2 = "", bool bool_0 = true)
		{
			string_1 = "[" + string_1 + "]";
			for (int i = 0; i < string_0.Length; i++)
			{
				bool flag = Class12.smethod_1(string_0[i], string_1) >= 0;
				if (flag)
				{
					string_2 = string_0[i].Replace(string_1, "").Trim();
					if (bool_0)
					{
						string_2.Replace(" ", "");
					}
					return string_2;
				}
			}
			return string_2;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00007E4C File Offset: 0x0000604C
		private static bool smethod_3(ref GStruct51 gstruct51_0, GStruct51[] gstruct51_1)
		{
			bool flag = gstruct51_1 == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string b = gstruct51_0.string_0.ToUpper();
				for (int i = 0; i < gstruct51_1.GetLength(0); i++)
				{
					bool flag2 = gstruct51_1[i].string_0 == b;
					if (flag2)
					{
						gstruct51_0.int_7 = gstruct51_1[i].int_7;
						gstruct51_0.int_8 = gstruct51_1[i].int_8;
						gstruct51_0.int_0 = gstruct51_1[i].int_0;
						gstruct51_0.int_4 = gstruct51_1[i].int_4;
						gstruct51_0.int_2 = gstruct51_1[i].int_2;
						gstruct51_0.string_1 = gstruct51_1[i].string_1;
						gstruct51_0.int_1 = gstruct51_1[i].int_1;
						gstruct51_0.int_5 = gstruct51_1[i].int_5;
						gstruct51_0.int_3 = gstruct51_1[i].int_3;
						gstruct51_0.string_2 = gstruct51_1[i].string_2;
						return true;
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00007F70 File Offset: 0x00006170
		public static long smethod_4(uint uint_0, byte[] byte_0, ref GStruct51 gstruct51_0, long long_0 = 0L, uint uint_1 = 0U, int int_0 = 0, bool bool_0 = false)
		{
			int num = 0;
			long num2 = 0L;
			gstruct51_0.uint_0 = 0U;
			long num3;
			int num5;
			int num6;
			for (;;)
			{
				bool flag = long_0 < 0L;
				if (flag)
				{
					long_0 = 0L;
				}
				num3 = long_0;
				bool flag2 = num != 0;
				byte[] array;
				int num4;
				if (flag2)
				{
					bool flag3 = gstruct51_0.string_2 == null || gstruct51_0.string_2.Length == 0;
					if (flag3)
					{
						Class102.smethod_3(ref gstruct51_0, Class53.gstruct51_0);
					}
					array = Class12.smethod_8(gstruct51_0.string_2, true);
					num4 = gstruct51_0.int_1;
					num5 = gstruct51_0.int_3;
					num6 = gstruct51_0.int_5;
				}
				else
				{
					bool flag4 = gstruct51_0.string_1 == null || gstruct51_0.string_1.Length == 0;
					if (flag4)
					{
						Class102.smethod_3(ref gstruct51_0, Class53.gstruct51_0);
					}
					array = Class12.smethod_8(gstruct51_0.string_1, true);
					num4 = gstruct51_0.int_0;
					num5 = gstruct51_0.int_2;
					num6 = gstruct51_0.int_4;
				}
				gstruct51_0.uint_0 = 0U;
				gstruct51_0.byte_2 = null;
				gstruct51_0.uint_2 = uint_0;
				bool flag5 = byte_0 == null || array == null;
				if (flag5)
				{
					break;
				}
				int num7 = array.Length;
				long num8 = (long)byte_0.Length;
				int num9 = 0;
				bool flag6 = gstruct51_0.int_7 > 0 && uint_1 == 0U;
				if (flag6)
				{
					uint_1 = 4194304U;
				}
				for (;;)
				{
					IL_1B0:
					int i = 0;
					while (i < num7)
					{
						byte b = byte_0[(int)(checked((IntPtr)(unchecked(num3 + (long)i))))];
						bool flag7 = array[i] == 63 || array[i] == b;
						if (flag7)
						{
							i++;
						}
						else
						{
							IL_191:
							num3 += 1L;
							bool flag8 = num3 + (long)num7 < num8;
							if (flag8)
							{
								goto IL_1B0;
							}
							goto IL_1AB;
						}
					}
					num9++;
					bool flag9 = num9 >= num4;
					if (flag9)
					{
						goto Block_14;
					}
					goto IL_191;
				}
				IL_1AB:
				bool flag10 = num != 0;
				if (flag10)
				{
					break;
				}
				num++;
			}
			goto IL_421;
			Block_14:
			bool flag11 = num6 > 0;
			if (flag11)
			{
				byte[] array2 = new byte[num6];
				for (int j = 0; j < num6; j++)
				{
					array2[j] = byte_0[(int)(checked((IntPtr)(unchecked((long)num5 + num3 + (long)j))))];
				}
				bool flag12 = array2.Length < 4;
				if (flag12)
				{
					byte[] array3 = new byte[4];
					for (int k = 0; k < array2.Length; k++)
					{
						array3[k] = array2[k];
					}
					array2 = array3;
				}
				gstruct51_0.uint_0 = BitConverter.ToUInt32(array2, 0);
				bool flag13 = gstruct51_0.int_7 > 0;
				if (flag13)
				{
					bool flag14 = gstruct51_0.int_6 > 0 && int_0 > 0;
					if (flag14)
					{
						gstruct51_0.uint_0 = Class22.smethod_30(gstruct51_0.uint_0, int_0);
					}
					gstruct51_0.uint_0 -= uint_1;
				}
				bool flag15 = gstruct51_0.int_8 > 0;
				if (flag15)
				{
					uint num10 = (uint)(num3 + (long)num5 + (long)((ulong)gstruct51_0.uint_2));
					gstruct51_0.uint_0 += num10 + 4U;
				}
			}
			else
			{
				gstruct51_0.uint_0 = (uint)((long)num5 + num3 + (long)((ulong)gstruct51_0.uint_2));
				bool flag16 = gstruct51_0.int_7 > 0 && uint_1 < gstruct51_0.uint_0;
				if (flag16)
				{
					gstruct51_0.uint_0 -= uint_1;
				}
			}
			bool flag17 = gstruct51_0.int_12 > 0;
			if (flag17)
			{
				gstruct51_0.byte_2 = new byte[gstruct51_0.int_12];
				for (int l = 0; l < gstruct51_0.int_12; l++)
				{
					gstruct51_0.byte_2[l] = byte_0[(int)(checked((IntPtr)(unchecked(num3 + (long)l + (long)num5 + (long)gstruct51_0.int_11))))];
				}
			}
			bool flag18 = gstruct51_0.byte_1 != null && gstruct51_0.byte_1[0] == 0;
			if (flag18)
			{
				byte b2 = 1;
				for (int m = 0; m < gstruct51_0.byte_1.Length - 1; m++)
				{
					byte b3 = byte_0[(int)(checked((IntPtr)(unchecked(num3 + (long)m + (long)num5 + (long)gstruct51_0.int_11))))];
					bool flag19 = gstruct51_0.byte_1[m + 1] != 63;
					if (flag19)
					{
						bool flag20 = gstruct51_0.byte_1[m + 1] != b3;
						if (flag20)
						{
							b2 = 0;
							break;
						}
					}
					else
					{
						gstruct51_0.byte_1[m + 1] = b3;
					}
				}
				gstruct51_0.byte_1[0] = b2;
			}
			num2 = num3;
			IL_421:
			long result;
			if (bool_0)
			{
				result = num2;
			}
			else
			{
				bool flag21 = Class53.gstruct50_0 == null;
				if (flag21)
				{
					Class53.gstruct50_0 = new GStruct50[1];
					Class53.gstruct50_0[0].string_1 = "Stt|Name\t\t|flgTruBaseAddr|flgGetCall|FindCount|GetPtr|DeltaSize|ByteSearch|FindCount2|GetPtr2|DeltaSize2|ByteSearch2";
				}
				Array.Resize<GStruct50>(ref Class53.gstruct50_0, Class53.gstruct50_0.Length + 1);
				int num11 = gstruct51_0.int_2;
				string text = string.Empty;
				string text2 = string.Empty;
				bool flag22 = num11 < 0;
				if (flag22)
				{
					text = "-";
					num11 = Math.Abs(num11);
				}
				text += Class12.smethod_45(num11, 2, false, false);
				num11 = gstruct51_0.int_3;
				bool flag23 = num11 < 0;
				if (flag23)
				{
					text2 = "-";
					num11 = Math.Abs(num11);
				}
				text2 += Class12.smethod_45(num11, 2, false, false);
				Class53.gstruct50_0[Class53.gstruct50_0.Length - 1].string_0 = gstruct51_0.string_0;
				Class53.gstruct50_0[Class53.gstruct50_0.Length - 1].uint_0 = gstruct51_0.uint_0;
				Class53.gstruct50_0[Class53.gstruct50_0.Length - 1].string_1 = string.Concat(new string[]
				{
					Class53.gstruct50_0.Length.ToString(),
					"|",
					gstruct51_0.string_0,
					"\t\t|",
					Class12.smethod_45(gstruct51_0.int_7, 2, false, false),
					"|",
					Class12.smethod_45(gstruct51_0.int_8, 2, false, false),
					"|",
					Class12.smethod_45(gstruct51_0.int_0, 2, false, false),
					"|",
					Class12.smethod_45(gstruct51_0.int_4, 2, false, false),
					"|",
					text,
					"|",
					gstruct51_0.string_1,
					"|",
					Class12.smethod_45(gstruct51_0.int_1, 2, false, false),
					"|",
					Class12.smethod_45(gstruct51_0.int_5, 2, false, false),
					"|",
					text2,
					"|",
					gstruct51_0.string_2
				});
				result = num2;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00008608 File Offset: 0x00006808
		private static string smethod_5(string string_0, int int_0, int int_1, int int_2)
		{
			bool flag = string_0 == "";
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				char[] array = string_0.ToCharArray();
				string_0 = "";
				for (int i = 0; i < array.Length; i++)
				{
					int num = i % int_2 + int_1;
					string_0 += ((char)((int)((byte)array[i]) + int_0 * num)).ToString();
				}
				result = string_0;
			}
			return result;
		}
	}
}
