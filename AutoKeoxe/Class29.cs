using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace AutoKeoxe
{
	// Token: 0x0200001B RID: 27
	internal class Class29
	{
		// Token: 0x06000153 RID: 339
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern int CloseHandle(IntPtr intptr_0);

		// Token: 0x06000154 RID: 340
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr CreateFile(string string_3, uint uint_1, uint uint_2, IntPtr intptr_0, uint uint_3, uint uint_4, IntPtr intptr_1);

		// Token: 0x06000155 RID: 341
		[DllImport("kernel32.dll")]
		private static extern int DeviceIoControl(IntPtr intptr_0, uint uint_1, IntPtr intptr_1, uint uint_2, ref Struct7 struct7_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_2);

		// Token: 0x06000156 RID: 342
		[DllImport("kernel32.dll", EntryPoint = "DeviceIoControl")]
		private static extern int DeviceIoControl_1(IntPtr intptr_0, uint uint_1, ref Struct8 struct8_0, uint uint_2, ref Struct11 struct11_0, uint uint_3, ref uint uint_4, [Out] IntPtr intptr_1);

		// Token: 0x06000157 RID: 343
		[DllImport("Iphlpapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		internal static extern int GetAdaptersInfo(IntPtr intptr_0, ref uint uint_1);

		// Token: 0x06000158 RID: 344
		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		internal static extern bool DeviceIoControl_2([In] IntPtr intptr_0, [In] uint uint_1, [In] [Optional] IntPtr intptr_1, [In] uint uint_2, [Out] [Optional] IntPtr intptr_2, [In] uint uint_3, out uint uint_4, [In] [Out] [Optional] IntPtr intptr_3);

		// Token: 0x06000159 RID: 345
		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateFile", SetLastError = true)]
		internal static extern IntPtr CreateFile_1([In] string string_3, [In] GEnum5 genum5_0, [In] GEnum6 genum6_0, [In] [Optional] IntPtr intptr_0, [In] GEnum4 genum4_0, [In] uint uint_1, [In] [Optional] IntPtr intptr_1);

		// Token: 0x0600015A RID: 346
		[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_2, [In] [Out] byte[] byte_1, IntPtr intptr_1);

		// Token: 0x0600015B RID: 347
		[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_2, out int int_3);

		// Token: 0x0600015C RID: 348
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern bool GetVolumeInformation(string string_3, StringBuilder stringBuilder_0, uint uint_1, out uint uint_2, out uint uint_3, out uint uint_4, StringBuilder stringBuilder_1, uint uint_5);

		// Token: 0x0600015D RID: 349 RVA: 0x00018528 File Offset: 0x00016728
		public static void smethod_0()
		{
			char[] char_ = new char[]
			{
				'ᓪ',
				'ᒴ',
				'ᓢ',
				'ᓙ',
				'ᓦ',
				'ᓕ',
				'ᓢ'
			};
			char[] char_2 = new char[]
			{
				'ᓅ',
				'ᒻ',
				'ᒰ',
				'ᓤ',
				'ᓣ',
				'ᓞ'
			};
			char[] char_3 = new char[]
			{
				'ᓂ',
				'ᓨ',
				'ᓢ',
				'ᓣ',
				'ᓔ',
				'ᓜ'
			};
			int num = 0;
			string[] array = new string[]
			{
				Class12.smethod_0(char_),
				Class12.smethod_0(char_2),
				Class12.smethod_0(char_3)
			};
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					bool flag = Class22.smethod_0(Class12.smethod_15(array[i]), ref num, 1) && num == 1;
					if (flag)
					{
						return;
					}
				}
				catch
				{
				}
			}
			Class29.string_2 = string.Empty;
			Class29.string_0 = Class29.smethod_6(0);
			int num2 = Class29.smethod_5(Class29.string_0);
			bool flag2 = num2 > 0 && Class29.int_1 > 0 && !Class29.bool_0;
			if (flag2)
			{
				for (byte b = 1; b < 16; b += 1)
				{
					string[] array2 = Class29.smethod_6(b);
					int num3 = Class29.smethod_5(array2);
					bool flag3 = num3 <= 0 || !Class29.bool_0;
					if (!flag3)
					{
						for (int j = 0; j < Class29.string_0.Length; j++)
						{
							bool flag4 = Class29.string_2 != null && Class29.string_2 != string.Empty;
							if (flag4)
							{
								Class29.string_2 += "-";
							}
							Class29.string_2 += Class29.string_0[j];
							Class29.string_0[j] = array2[j];
						}
						break;
					}
				}
			}
			Class29.string_1 = string.Empty;
			for (int k = 0; k < Class29.string_0.Length; k++)
			{
				bool flag5 = Class29.string_1 != null && Class29.string_1 != string.Empty;
				if (flag5)
				{
					Class29.string_1 += "-";
				}
				Class29.string_1 += Class29.string_0[k];
				bool flag6 = k == Class29.string_0.Length - 2;
				if (flag6)
				{
					Class29.uint_0 = Class12.smethod_6(Class29.string_0[k]);
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0001878C File Offset: 0x0001698C
		private static GStruct17 smethod_1(byte byte_0)
		{
			char[] char_ = new char[]
			{
				'ᓑ',
				'ᓑ',
				'ᒣ',
				'ᓑ',
				'ᓈ',
				'ᓢ',
				'ᓖ',
				'ᓧ',
				'ᓩ',
				'ᓫ',
				'ᓨ',
				'ᓙ'
			};
			GStruct17 result = new GStruct17
			{
				md = "",
				sr = "",
				fr = "",
				cap = 0U
			};
			try
			{
				Struct7 @struct = default(Struct7);
				Struct8 struct2 = default(Struct8);
				Struct11 struct3 = default(Struct11);
				IntPtr intPtr = Class29.CreateFile(Class12.smethod_0(char_), 0U, 0U, IntPtr.Zero, 1U, 0U, IntPtr.Zero);
				bool flag = intPtr == IntPtr.Zero;
				if (flag)
				{
					return result;
				}
				uint num = 0U;
				bool flag2 = Class29.DeviceIoControl(intPtr, 475264U, IntPtr.Zero, 0U, ref @struct, (uint)Marshal.SizeOf(@struct), ref num, IntPtr.Zero) != 0 && (@struct.uint_0 & 1U) > 0U;
				if (flag2)
				{
					struct2.struct9_0.byte_5 = 160;
					bool flag3 = (byte_0 & 1) > 0;
					if (flag3)
					{
						struct2.struct9_0.byte_5 = 176;
					}
					bool flag4 = ((ulong)@struct.uint_0 & (ulong)((long)(16 >> (int)byte_0))) == 0UL;
					if (flag4)
					{
						struct2.struct9_0.byte_6 = 236;
						struct2.byte_0 = byte_0;
						struct2.struct9_0.byte_1 = 1;
						struct2.struct9_0.byte_2 = 1;
						struct2.uint_0 = 512U;
						bool flag5 = Class29.DeviceIoControl_1(intPtr, 508040U, ref struct2, (uint)Marshal.SizeOf(struct2), ref struct3, (uint)Marshal.SizeOf(struct3), ref num, IntPtr.Zero) != 0;
						if (flag5)
						{
							result = Class29.smethod_3(struct3.struct12_0);
						}
					}
				}
				Class29.CloseHandle(intPtr);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0001897C File Offset: 0x00016B7C
		private static GStruct17 smethod_2(byte byte_0)
		{
			GStruct17 result = new GStruct17
			{
				md = string.Empty,
				sr = string.Empty,
				fr = string.Empty,
				cap = 0U
			};
			try
			{
				Struct7 @struct = default(Struct7);
				Struct8 struct2 = default(Struct8);
				Struct11 struct3 = default(Struct11);
				string format = Class12.smethod_0(Class29.char_0);
				string string_ = string.Format(format, byte_0);
				IntPtr intPtr = Class29.CreateFile(string_, 3221225472U, 3U, IntPtr.Zero, 3U, 0U, IntPtr.Zero);
				bool flag = intPtr == IntPtr.Zero;
				if (flag)
				{
					return result;
				}
				uint num = 0U;
				bool flag2 = Class29.DeviceIoControl(intPtr, 475264U, IntPtr.Zero, 0U, ref @struct, (uint)Marshal.SizeOf(@struct), ref num, IntPtr.Zero) != 0 && (@struct.uint_0 & 1U) > 0U;
				if (flag2)
				{
					struct2.struct9_0.byte_5 = 160;
					bool flag3 = (byte_0 & 1) > 0;
					if (flag3)
					{
						struct2.struct9_0.byte_5 = 176;
					}
					bool flag4 = ((ulong)@struct.uint_0 & (ulong)((long)(16 >> (int)byte_0))) == 0UL;
					if (flag4)
					{
						struct2.struct9_0.byte_6 = 236;
						struct2.byte_0 = byte_0;
						struct2.struct9_0.byte_1 = 1;
						struct2.struct9_0.byte_2 = 1;
						struct2.uint_0 = 512U;
						bool flag5 = Class29.DeviceIoControl_1(intPtr, 508040U, ref struct2, (uint)Marshal.SizeOf(struct2), ref struct3, (uint)Marshal.SizeOf(struct3), ref num, IntPtr.Zero) != 0;
						if (flag5)
						{
							result = Class29.smethod_3(struct3.struct12_0);
						}
					}
				}
				Class29.CloseHandle(intPtr);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00018B70 File Offset: 0x00016D70
		private static GStruct17 smethod_3(Struct12 struct12_0)
		{
			GStruct17 result = new GStruct17
			{
				md = "",
				sr = "",
				fr = "",
				cap = 0U
			};
			try
			{
				Class29.smethod_4(struct12_0.byte_2);
				result.md = Encoding.ASCII.GetString(struct12_0.byte_2).Trim().Replace(" ", "").ToUpper();
				Class29.smethod_4(struct12_0.byte_1);
				result.fr = Encoding.ASCII.GetString(struct12_0.byte_1).Trim().Replace(" ", "").ToUpper();
				Class29.smethod_4(struct12_0.byte_0);
				result.sr = Encoding.ASCII.GetString(struct12_0.byte_0).Trim().Replace(" ", "").ToUpper();
				result.cap = struct12_0.uint_1 / 2U / 1024U;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00018C9C File Offset: 0x00016E9C
		private static void smethod_4(byte[] byte_0)
		{
			int num = 0;
			for (;;)
			{
				sbyte b = 0;
				bool flag = num < byte_0.Length;
				if (flag)
				{
					b = 1;
				}
				bool flag2 = b != 0;
				if (!flag2)
				{
					break;
				}
				byte b2 = byte_0[num];
				byte_0[num] = byte_0[num + 1];
				byte_0[num + 1] = b2;
				num += 2;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00018CEC File Offset: 0x00016EEC
		private static int smethod_5(string[] string_3)
		{
			int result = 0;
			long num = 0L;
			bool flag = string_3 == null || string_3.Length < 2;
			if (flag)
			{
				string_3 = new string[]
				{
					Class12.smethod_0(Class12.char_5),
					Class12.smethod_0(Class12.char_5)
				};
			}
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			string[] array = new string[]
			{
				Class53.string_9 + "\\" + Class12.smethod_0(Class12.char_30),
				environmentVariable + "\\" + Class12.smethod_0(Class12.char_30)
			};
			string text = null;
			int num2 = 0;
			int int_ = Class22.OpenProcess(2035711, false, Process.GetCurrentProcess().Id);
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[8];
			string text2 = null;
			uint num3 = 3U;
			Class22.ReadProcessMemory(int_, Class12.uint_0 + num3 * 256U, array2, 4, ref num2);
			int num4 = BitConverter.ToInt32(array2, 0);
			bool flag2 = num4 > 0;
			byte[] array4;
			if (flag2)
			{
				array4 = new byte[num4];
				Class22.ReadProcessMemory(int_, Class12.uint_0 + num3 * 256U + 4U, array4, num4, ref num2);
				string text3 = Class10.smethod_4(array4);
				string text4 = string.Empty;
				int length = text3.Length;
				foreach (char c in text3)
				{
					bool flag3 = c > 'ᎅ';
					if (flag3)
					{
						c = (char)((int)c - (5225 + length));
					}
					text4 += c.ToString();
				}
				array3 = Encoding.ASCII.GetBytes(text4);
			}
			for (int j = 0; j < array.Length; j++)
			{
				string string_4 = array[j];
				string text5 = Class12.smethod_33(string_4, 1, 1, 1);
				bool flag4 = text5 != null && text5 != string.Empty;
				if (flag4)
				{
					text = Class12.smethod_35(text5, string_3[0], array3);
					bool flag5 = text != null && text != string.Empty;
					if (flag5)
					{
						string string_5 = array[array.Length - 1 - j];
						Class12.smethod_34(string_5, text5, 1);
						break;
					}
				}
			}
			int num5 = 0;
			bool flag6 = text != null && !(text == string.Empty);
			if (flag6)
			{
				string[] array5 = text.Split(new char[]
				{
					'|'
				});
				int num6 = array5.Length;
				bool flag7 = num6 == 9;
				if (flag7)
				{
					int num7 = num6 - 2;
					string text6 = Class12.smethod_15(array5[num7]);
					bool flag8 = text6 != string.Empty;
					if (flag8)
					{
						int length2 = array5[num6 - 1].Length;
						num5 = Class12.smethod_11(text6);
						num5 = num5 - (text.Length - array5[num6 - 2].Length - length2) + 1;
					}
					string[] array6 = new string[num6 - 1];
					array6[0] = Class12.smethod_35(array5[0], string_3[0], array3);
					for (int k = 0; k < array6.Length; k++)
					{
						bool flag9 = k < array6.Length - 1;
						if (flag9)
						{
							array6[k + 1] = Class12.smethod_35(array5[k + 1], array6[k], array3);
						}
						bool flag10 = array6[k] != null && array6[k] != string.Empty;
						if (flag10)
						{
							bool flag11 = text2 != null && text2 != string.Empty;
							if (flag11)
							{
								text2 += "\u0001";
							}
							text2 += array6[k];
						}
						bool flag12 = k < string_3.Length;
						if (flag12)
						{
							bool flag13 = k == 0;
							if (flag13)
							{
								Class29.bool_0 = (array6[k] == string_3[k]);
							}
							Class29.bool_0 = (Class29.bool_0 && array6[k] == string_3[k]);
						}
					}
					num = Class12.smethod_36(array6[6]);
					Class29.long_0 = Class12.smethod_36(array5[num6 - 1]);
					result = 1;
				}
				else
				{
					Class29.bool_0 = false;
				}
			}
			else
			{
				Class29.bool_0 = false;
				result = 0;
			}
			bool flag14 = array3 != null;
			if (flag14)
			{
				for (int l = 0; l < array3.Length; l++)
				{
					array3[l] = 0;
				}
			}
			num3 = 4U;
			array2 = BitConverter.GetBytes(Convert.ToInt32((int)Convert.ToByte(Class29.bool_0 && num5 > 0) * num5 + (int)(Convert.ToByte(!Class29.bool_0 || num5 <= 0) * 10)));
			Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U, array2, array2.Length, ref num2);
			array2 = BitConverter.GetBytes(Convert.ToInt32((int)Convert.ToByte(Class29.bool_0 && num5 > 0) * int.MaxValue + (int)(Convert.ToByte(!Class29.bool_0 || num5 <= 0) * 2)));
			Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U + 4U, array2, array2.Length, ref num2);
			string text7 = num.ToString();
			array2 = BitConverter.GetBytes(text7.Length);
			Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U + 8U, array2, array2.Length, ref num2);
			array4 = Encoding.ASCII.GetBytes(text7);
			Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U + 12U, array4, array4.Length, ref num2);
			text2 = Class12.smethod_16(text2);
			bool flag15 = text2 != null && text2 != string.Empty;
			if (flag15)
			{
				array2 = BitConverter.GetBytes(text2.Length);
				Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U + 32U, array2, array2.Length, ref num2);
				array4 = Encoding.ASCII.GetBytes(text2);
				Class22.WriteProcessMemory(int_, Class12.uint_0 + num3 * 256U + 36U, array4, array4.Length, ref num2);
			}
			Class22.smethod_32(int_);
			return result;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000192E0 File Offset: 0x000174E0
		private static string[] smethod_6(byte byte_0)
		{
			string[] array = new string[]
			{
				Class12.smethod_0(Class12.char_5),
				Class12.smethod_0(Class12.char_6),
				Class12.smethod_0(Class12.char_7),
				Class12.smethod_0(Class12.char_7),
				Class12.smethod_0(Class12.char_7),
				Class12.smethod_0(Class12.char_7)
			};
			GStruct17 gstruct = default(GStruct17);
			bool flag = Environment.OSVersion.Platform == PlatformID.Win32Windows;
			if (flag)
			{
				gstruct = Class29.smethod_1(byte_0);
			}
			else
			{
				bool flag2 = Environment.OSVersion.Platform == PlatformID.Win32NT;
				if (flag2)
				{
					gstruct = Class29.smethod_2(byte_0);
				}
			}
			bool flag3 = gstruct.sr == null || gstruct.sr == string.Empty;
			if (flag3)
			{
				gstruct.sr = Class29.smethod_12();
			}
			bool flag4 = gstruct.md != null && gstruct.md != string.Empty;
			if (flag4)
			{
				string text = gstruct.md.Replace(" ", string.Empty).ToUpper();
				bool flag5 = text.Length > 6;
				if (flag5)
				{
					text = text.Substring(0, 6);
				}
				while (text.Length < 6)
				{
					text += "0";
				}
				array[1] = string.Empty;
				foreach (char c in text)
				{
					bool flag6 = ('0' <= c && c <= '9') || ('A' <= c && c <= 'Z');
					if (flag6)
					{
						string[] array2;
						(array2 = array)[1] = array2[1] + c.ToString();
					}
					else
					{
						string[] array3;
						(array3 = array)[1] = array3[1] + ((byte)c).ToString();
					}
				}
			}
			string str = Class29.smethod_9();
			string string_ = (gstruct.fr + gstruct.cap.ToString() + gstruct.sr + str).ToUpper();
			string text3 = Class29.smethod_8(string_);
			bool flag7 = text3 != null && text3 != string.Empty;
			if (flag7)
			{
				int num = 1;
				int num2 = -1;
				for (int j = 0; j < text3.Length; j++)
				{
					bool flag8 = num2 < 0 || num2 > 10;
					if (flag8)
					{
						num2 = 0;
						num++;
						bool flag9 = array.Length <= num;
						if (flag9)
						{
							break;
						}
						array[num] = string.Empty;
					}
					string[] array5;
					string[] array4 = array5 = array;
					int num3 = num;
					IntPtr value = (IntPtr)num3;
					array5[num3] = array4[(int)(checked((IntPtr)((long)value)))] + text3[j].ToString();
					num2++;
				}
			}
			array[5] = Class29.smethod_7(null);
			return array;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000195C4 File Offset: 0x000177C4
		private static string smethod_7(string string_3 = null)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			StringBuilder stringBuilder2 = new StringBuilder(256);
			char[] char_ = new char[]
			{
				'ᒺ',
				'ᓁ',
				'ᒿ',
				'ᒷ',
				'ᒶ',
				'ᓄ',
				'ᒻ',
				'ᓈ',
				'ᒷ'
			};
			bool flag = string_3 == null;
			if (flag)
			{
				string_3 = Environment.GetEnvironmentVariable(Class12.smethod_0(char_));
				bool flag2 = string_3 == string.Empty || string_3 == null;
				if (flag2)
				{
					return string.Empty;
				}
				string_3 = string_3[0].ToString() + ":\\";
			}
			uint num;
			uint num2;
			uint num3;
			Class29.GetVolumeInformation(string_3, stringBuilder, (uint)(stringBuilder.Capacity - 1), out num, out num2, out num3, stringBuilder2, (uint)(stringBuilder2.Capacity - 1));
			return num.ToString();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00019680 File Offset: 0x00017880
		public static string smethod_8(string string_3)
		{
			string text = string.Empty;
			bool flag = string_3 != null && string_3 != string.Empty;
			if (flag)
			{
				using (MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider())
				{
					byte[] array = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_3));
					bool flag2 = array != null;
					if (flag2)
					{
						for (int i = 0; i < array.Length; i++)
						{
							text += array[i].ToString("X2");
						}
					}
				}
			}
			while (text.Length < 33)
			{
				text += "0";
			}
			return text;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00019748 File Offset: 0x00017948
		public static string smethod_9()
		{
			byte[] value = new byte[8];
			bool flag = Class29.smethod_10(ref value);
			string result;
			if (flag)
			{
				result = string.Format("{0}{1}", BitConverter.ToUInt32(value, 4).ToString("X8"), BitConverter.ToUInt32(value, 0).ToString("X8"));
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000197A8 File Offset: 0x000179A8
		private static bool smethod_10(ref byte[] byte_0)
		{
			byte[] array = new byte[]
			{
				85,
				137,
				229,
				87,
				139,
				125,
				16,
				106,
				1,
				88,
				83,
				15,
				162,
				137,
				7,
				137,
				87,
				4,
				91,
				95,
				137,
				236,
				93,
				194,
				16,
				0
			};
			byte[] array2 = new byte[]
			{
				83,
				72,
				199,
				192,
				1,
				0,
				0,
				0,
				15,
				162,
				65,
				137,
				0,
				65,
				137,
				80,
				4,
				91,
				195
			};
			byte[] array3 = (IntPtr.Size == 8) ? array2 : array;
			IntPtr intPtr = new IntPtr(array3.Length);
			int num;
			bool flag = !Class29.VirtualProtect(array3, intPtr, 64, out num);
			if (flag)
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			intPtr = new IntPtr(byte_0.Length);
			try
			{
				return Class29.CallWindowProcW(array3, IntPtr.Zero, 0, byte_0, intPtr) != IntPtr.Zero;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00019858 File Offset: 0x00017A58
		private static bool smethod_11(string string_3)
		{
			try
			{
				IntPtr intPtr = IntPtr.Zero;
				string format = Class12.smethod_0(Class29.char_0);
				for (int i = 0; i < 16; i++)
				{
					string string_4 = string.Format(format, i);
					intPtr = Class29.CreateFile_1(string_4, (GEnum5)3221225472U, GEnum6.flag_1 | GEnum6.flag_2, IntPtr.Zero, GEnum4.const_2, 0U, IntPtr.Zero);
					bool flag = (int)intPtr > 0;
					if (flag)
					{
						string text = Class29.smethod_13(intPtr);
						bool flag2 = text == null || text.Length == 0;
						if (flag2)
						{
							text = Class29.smethod_14(intPtr);
						}
						Class29.CloseHandle(intPtr);
						bool flag3 = string_3 == text;
						if (flag3)
						{
							return true;
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00019928 File Offset: 0x00017B28
		private static string smethod_12()
		{
			string text = string.Empty;
			try
			{
				IntPtr intPtr = IntPtr.Zero;
				string format = Class12.smethod_0(Class29.char_0);
				for (int i = 0; i < 16; i++)
				{
					string string_ = string.Format(format, i);
					intPtr = Class29.CreateFile_1(string_, (GEnum5)3221225472U, GEnum6.flag_1 | GEnum6.flag_2, IntPtr.Zero, GEnum4.const_2, 0U, IntPtr.Zero);
					bool flag = (int)intPtr > 0;
					if (flag)
					{
						text = Class29.smethod_13(intPtr);
						bool flag2 = text == null || text.Length == 0;
						if (flag2)
						{
							text = Class29.smethod_14(intPtr);
						}
						Class29.CloseHandle(intPtr);
						bool flag3 = text != null && text.Length > 0;
						if (flag3)
						{
							break;
						}
					}
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00019A04 File Offset: 0x00017C04
		private static string smethod_13(IntPtr intptr_0)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(32);
			IntPtr intPtr2 = Marshal.AllocHGlobal(24);
			string result = string.Empty;
			uint num = 0U;
			try
			{
				bool flag = Class29.DeviceIoControl_2(intptr_0, 475264U, IntPtr.Zero, 0U, intPtr2, 24U, out num, IntPtr.Zero) && (Marshal.ReadInt32(intPtr2, 4) & 4) > 0;
				if (flag)
				{
					Class29.Class30 structure = new Class29.Class30();
					intPtr2 = Marshal.ReAllocHGlobal(intPtr2, (IntPtr)528);
					Marshal.StructureToPtr(structure, intPtr, true);
					bool flag2 = Class29.DeviceIoControl_2(intptr_0, 508040U, intPtr, 32U, intPtr2, 528U, out num, IntPtr.Zero);
					if (flag2)
					{
						string text = Marshal.PtrToStringAnsi((IntPtr)(intPtr2.ToInt32() + 36), 20);
						bool flag3 = text.Length != 0;
						if (flag3)
						{
							char[] array = text.ToCharArray();
							for (int i = 0; i <= array.Length - 2; i += 2)
							{
								char c = array[i];
								array[i] = array[i + 1];
								array[i + 1] = c;
							}
							result = new string(array).Trim();
						}
					}
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
				Marshal.FreeHGlobal(intPtr2);
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00019B50 File Offset: 0x00017D50
		private static string smethod_14(IntPtr intptr_0)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(12);
			IntPtr intPtr2 = Marshal.AllocHGlobal(1024);
			Class29.Class31 structure = new Class29.Class31();
			string result = string.Empty;
			uint num = 0U;
			try
			{
				Marshal.StructureToPtr(structure, intPtr, true);
				bool flag = Class29.DeviceIoControl_2(intptr_0, 2954240U, intPtr, 12U, intPtr2, 1024U, out num, IntPtr.Zero);
				if (flag)
				{
					int num2 = intPtr2.ToInt32();
					int num3 = Marshal.ReadInt32(intPtr2, 24);
					bool flag2 = num3 != 0;
					if (flag2)
					{
						string text = Marshal.PtrToStringAnsi((IntPtr)(num2 + num3));
						bool flag3 = text.Length != 0;
						if (flag3)
						{
							StringBuilder stringBuilder = new StringBuilder();
							for (int i = 0; i < text.Length; i += 4)
							{
								for (int j = 1; j >= 0; j--)
								{
									int num4 = 0;
									for (int k = 0; k < 2; k++)
									{
										num4 *= 16;
										char c = text[i + j * 2 + k];
										char c2 = c;
										switch (c2)
										{
										case '0':
											num4 = num4;
											break;
										case '1':
											num4++;
											break;
										case '2':
											num4 += 2;
											break;
										case '3':
											num4 += 3;
											break;
										case '4':
											num4 += 4;
											break;
										case '5':
											num4 += 5;
											break;
										case '6':
											num4 += 6;
											break;
										case '7':
											num4 += 7;
											break;
										case '8':
											num4 += 8;
											break;
										case '9':
											num4 += 9;
											break;
										default:
											switch (c2)
											{
											case 'a':
												num4 += 10;
												break;
											case 'b':
												num4 += 11;
												break;
											case 'c':
												num4 += 12;
												break;
											case 'd':
												num4 += 13;
												break;
											case 'e':
												num4 += 14;
												break;
											case 'f':
												num4 += 15;
												break;
											}
											break;
										}
									}
									bool flag4 = num4 > 0;
									if (flag4)
									{
										stringBuilder.Append((char)num4);
									}
								}
							}
							result = stringBuilder.ToString().Trim();
						}
					}
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
				Marshal.FreeHGlobal(intPtr2);
			}
			return result;
		}

		// Token: 0x040000DC RID: 220
		private const int int_0 = 64;

		// Token: 0x040000DD RID: 221
		public static long long_0;

		// Token: 0x040000DE RID: 222
		public static bool bool_0 = false;

		// Token: 0x040000DF RID: 223
		public static string[] string_0 = null;

		// Token: 0x040000E0 RID: 224
		public static string string_1 = string.Empty;

		// Token: 0x040000E1 RID: 225
		public static string string_2 = string.Empty;

		// Token: 0x040000E2 RID: 226
		public static uint uint_0 = 0U;

		// Token: 0x040000E3 RID: 227
		public static int int_1 = Class62.smethod_3("fMultiHd", 0, "0");

		// Token: 0x040000E4 RID: 228
		private static char[] char_0 = new char[]
		{
			'ᓙ',
			'ᓙ',
			'ᒫ',
			'ᓙ',
			'ᓍ',
			'ᓥ',
			'ᓶ',
			'ᓰ',
			'ᓦ',
			'ᓠ',
			'ᓞ',
			'ᓩ',
			'ᓁ',
			'ᓯ',
			'ᓦ',
			'ᓳ',
			'ᓢ',
			'ᓸ',
			'ᒭ',
			'ᓺ'
		};

		// Token: 0x020000EA RID: 234
		[StructLayout(LayoutKind.Sequential)]
		private class Class30
		{
			// Token: 0x0400121B RID: 4635
			private int int_0 = 528;

			// Token: 0x0400121C RID: 4636
			private byte byte_0 = 0;

			// Token: 0x0400121D RID: 4637
			private byte byte_1 = 1;

			// Token: 0x0400121E RID: 4638
			private byte byte_2 = 1;

			// Token: 0x0400121F RID: 4639
			private byte byte_3 = 0;

			// Token: 0x04001220 RID: 4640
			private byte byte_4 = 0;

			// Token: 0x04001221 RID: 4641
			private byte byte_5 = 160;

			// Token: 0x04001222 RID: 4642
			private byte byte_6 = 236;

			// Token: 0x04001223 RID: 4643
			private byte byte_7 = 0;

			// Token: 0x04001224 RID: 4644
			private byte byte_8 = 0;

			// Token: 0x04001225 RID: 4645
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
			private byte[] byte_9 = new byte[16];
		}

		// Token: 0x020000EB RID: 235
		[StructLayout(LayoutKind.Sequential)]
		private class Class31
		{
			// Token: 0x04001226 RID: 4646
			private int int_0;

			// Token: 0x04001227 RID: 4647
			private int int_1;

			// Token: 0x04001228 RID: 4648
			private int int_2;
		}
	}
}
