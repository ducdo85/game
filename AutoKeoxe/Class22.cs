using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000014 RID: 20
	internal class Class22
	{
		// Token: 0x060000A8 RID: 168
		[DllImport("shell32.dll")]
		public static extern bool SHGetSpecialFolderPath(IntPtr intptr_0, [Out] StringBuilder stringBuilder_0, int int_35, bool bool_0);

		// Token: 0x060000A9 RID: 169
		[DllImport("kernel32.dll")]
		public static extern int GetUserDefaultLCID();

		// Token: 0x060000AA RID: 170
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(uint uint_11, ref GStruct13 gstruct13_0);

		// Token: 0x060000AB RID: 171
		[DllImport("User32.Dll")]
		public static extern bool ClientToScreen(uint uint_11, ref GStruct12 gstruct12_0);

		// Token: 0x060000AC RID: 172
		[DllImport("user32.dll")]
		public static extern uint SendInput(uint uint_11, [MarshalAs(UnmanagedType.LPArray)] [In] GStruct9[] gstruct9_0, int int_35);

		// Token: 0x060000AD RID: 173
		[DllImport("Kernel32.dll")]
		public static extern uint QueryFullProcessImageName(IntPtr intptr_0, uint uint_11, StringBuilder stringBuilder_0, out uint uint_12);

		// Token: 0x060000AE RID: 174
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

		// Token: 0x060000AF RID: 175
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int GetScrollPos(IntPtr intptr_0, int int_35);

		// Token: 0x060000B0 RID: 176
		[DllImport("user32.dll")]
		public static extern int SetScrollPos(IntPtr intptr_0, int int_35, int int_36, bool bool_0);

		// Token: 0x060000B1 RID: 177
		[DllImport("user32.dll")]
		public static extern bool GetScrollRange(IntPtr intptr_0, int int_35, out int int_36, out int int_37);

		// Token: 0x060000B2 RID: 178
		[DllImport("user32.dll")]
		public static extern bool PostMessageA(IntPtr intptr_0, int int_35, int int_36, int int_37);

		// Token: 0x060000B3 RID: 179
		[DllImport("User32.Dll")]
		public static extern bool GetCursorPos(ref GStruct12 gstruct12_0);

		// Token: 0x060000B4 RID: 180
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr intptr_0);

		// Token: 0x060000B5 RID: 181
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr intptr_0);

		// Token: 0x060000B6 RID: 182
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(GEnum2 genum2_0, bool bool_0, uint uint_11);

		// Token: 0x060000B7 RID: 183
		[DllImport("kernel32.dll")]
		private static extern bool TerminateThread(IntPtr intptr_0, uint uint_11);

		// Token: 0x060000B8 RID: 184
		[DllImport("ntdll.dll", SetLastError = true)]
		private static extern int NtQueryInformationThread(IntPtr intptr_0, int int_35, IntPtr intptr_1, int int_36, IntPtr intptr_2);

		// Token: 0x060000B9 RID: 185
		[DllImport("User32.Dll")]
		public static extern long SetCursorPos(int int_35, int int_36);

		// Token: 0x060000BA RID: 186
		[DllImport("kernel32.dll")]
		public static extern bool CreateProcess(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, GEnum3 genum3_0, IntPtr intptr_2, string string_2, ref GStruct3 gstruct3_0, out GStruct4 gstruct4_0);

		// Token: 0x060000BB RID: 187
		[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr OpenSCManagerW(string string_0, string string_1, uint uint_11);

		// Token: 0x060000BC RID: 188
		[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenService(IntPtr intptr_0, string string_0, uint uint_11);

		// Token: 0x060000BD RID: 189
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool ControlService(IntPtr intptr_0, int int_35, ref GStruct6 gstruct6_0);

		// Token: 0x060000BE RID: 190
		[DllImport("advapi32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseServiceHandle(IntPtr intptr_0);

		// Token: 0x060000BF RID: 191 RVA: 0x00012974 File Offset: 0x00010B74
		public static bool smethod_0(string string_0, ref int int_35, int int_36 = 1)
		{
			bool result = false;
			GStruct6 gstruct = default(GStruct6);
			IntPtr intPtr = Class22.OpenSCManagerW("", null, 983103U);
			bool flag = intPtr != IntPtr.Zero;
			if (flag)
			{
				IntPtr intPtr2 = Class22.OpenService(intPtr, string_0, 983103U);
				bool flag2 = intPtr2 != IntPtr.Zero;
				if (flag2)
				{
					result = Class22.ControlService(intPtr2, 1, ref gstruct);
					int_35 = gstruct.int_1;
					Class22.CloseServiceHandle(intPtr2);
				}
				Class22.CloseServiceHandle(intPtr);
			}
			return result;
		}

		// Token: 0x060000C0 RID: 192
		[DllImport("User32.dll")]
		public static extern int FindWindow(string string_0, string string_1);

		// Token: 0x060000C1 RID: 193
		[DllImport("User32.dll")]
		public static extern uint FindWindowEx(uint uint_11, uint uint_12, string string_0, string string_1);

		// Token: 0x060000C2 RID: 194
		[DllImport("user32.dll")]
		public static extern uint GetWindowThreadProcessId(uint uint_11, out int int_35);

		// Token: 0x060000C3 RID: 195
		[DllImport("user32.dll")]
		public static extern int GetWindowText(uint uint_11, StringBuilder stringBuilder_0, int int_35);

		// Token: 0x060000C4 RID: 196
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int GetClassName(uint uint_11, StringBuilder stringBuilder_0, int int_35);

		// Token: 0x060000C5 RID: 197
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
		public static extern uint GetWindowThreadProcessId_1(uint uint_11, out uint uint_12);

		// Token: 0x060000C6 RID: 198
		[DllImport("kernel32.dll")]
		public static extern int OpenProcess(int int_35, bool bool_0, int int_36);

		// Token: 0x060000C7 RID: 199
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CloseHandle(IntPtr intptr_0);

		// Token: 0x060000C8 RID: 200
		[DllImport("kernel32.dll")]
		public static extern uint VirtualAllocEx(int int_35, uint uint_11, uint uint_12, GEnum0 genum0_0, GEnum1 genum1_0);

		// Token: 0x060000C9 RID: 201
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern uint VirtualAllocEx2(int hProcess, uint lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x060000CA RID: 202
		[DllImport("kernel32.dll")]
		public static extern bool VirtualFreeEx(int int_35, uint uint_11, uint uint_12, uint uint_13);

		// Token: 0x060000CB RID: 203
		[DllImport("kernel32.dll")]
		public static extern uint CreateRemoteThread(int int_35, IntPtr intptr_0, uint uint_11, uint uint_12, uint uint_13, uint uint_14, out uint uint_15);

		// Token: 0x060000CC RID: 204
		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread2(int hProcess, IntPtr lpThreadAttributes, uint dwStackSize, uint lpStartAddress, uint lpParameter, uint dwCreationFlags, uint lpThreadId);

		// Token: 0x060000CD RID: 205
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(uint uint_11, uint uint_12);

		// Token: 0x060000CE RID: 206 RVA: 0x000129FC File Offset: 0x00010BFC
		public static uint smethod_1(int int_35, uint uint_11 = 512U, GEnum1 genum1_0 = GEnum1.flag_2)
		{
			uint uint_12 = 0U;
			GEnum0 genum0_ = GEnum0.flag_0 | GEnum0.flag_1;
			return Class22.VirtualAllocEx(int_35, uint_12, uint_11, genum0_, genum1_0);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00012A20 File Offset: 0x00010C20
		public static bool smethod_2(int int_35, uint uint_11)
		{
			return Class22.VirtualFreeEx(int_35, uint_11, 0U, 32768U);
		}

		// Token: 0x060000D0 RID: 208
		[DllImport("kernel32", CharSet = CharSet.Ansi)]
		public static extern uint GetProcAddress(uint uint_11, string string_0);

		// Token: 0x060000D1 RID: 209
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint GetModuleHandle(string string_0);

		// Token: 0x060000D2 RID: 210
		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(int int_35, uint uint_11, byte[] byte_0, int int_36, ref int int_37);

		// Token: 0x060000D3 RID: 211
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(int int_35, uint uint_11, byte[] byte_0, int int_36, ref int int_37);

		// Token: 0x060000D4 RID: 212
		[DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
		public static extern bool WriteProcessMemory_1(int int_35, uint uint_11, ref GStruct5 gstruct5_0, int int_36, int int_37 = 0);

		// Token: 0x060000D5 RID: 213
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory_2(int hProcess, uint lpBaseAddress, IntPtr lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

		// Token: 0x060000D6 RID: 214
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory_3(int hProcess, uint lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x060000D7 RID: 215
		[DllImport("user32.dll")]
		public static extern bool EnableWindow(uint uint_11, bool bool_0);

		// Token: 0x060000D8 RID: 216
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowEnabled(uint uint_11);

		// Token: 0x060000D9 RID: 217
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(uint uint_11, int int_35);

		// Token: 0x060000DA RID: 218
		[DllImport("user32.dll")]
		public static extern IntPtr SetForegroundWindow(uint uint_11);

		// Token: 0x060000DB RID: 219
		[DllImport("user32.dll")]
		public static extern uint GetForegroundWindow();

		// Token: 0x060000DC RID: 220
		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		public static extern short VkKeyScan(int int_35);

		// Token: 0x060000DD RID: 221
		[DllImport("User32.Dll", EntryPoint = "PostMessageA")]
		public static extern bool PostMessageA_1(uint uint_11, int int_35, uint uint_12, uint uint_13);

		// Token: 0x060000DE RID: 222
		[DllImport("user32.dll")]
		public static extern int SendMessage(uint uint_11, int int_35, int int_36, uint uint_12);

		// Token: 0x060000DF RID: 223
		[DllImport("user32.dll")]
		public static extern int MapVirtualKey(uint uint_11, uint uint_12);

		// Token: 0x060000E0 RID: 224 RVA: 0x00012A3F File Offset: 0x00010C3F
		public static void smethod_3(uint uint_11, uint uint_12)
		{
			Class22.PostMessageA_1(uint_11, Class22.int_22, uint_12, 0U);
			Class22.PostMessageA_1(uint_11, Class22.int_23, uint_12, 0U);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00012A60 File Offset: 0x00010C60
		public static void smethod_4(uint uint_11, uint uint_12)
		{
			short uint_13 = Class22.VkKeyScan((int)uint_12);
			short num = (short)Class22.MapVirtualKey((uint)uint_13, 0U);
			uint num2 = (uint)((int)num << 16 | 1);
			uint uint_14 = (uint)((ulong)num2 | 18446744072635809792UL);
			Class22.PostMessageA_1(uint_11, Class22.int_22, uint_12, num2);
			Class22.PostMessageA_1(uint_11, Class22.int_23, uint_12, uint_14);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00012AAC File Offset: 0x00010CAC
		public static void smethod_5(string string_0)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = Class12.smethod_0(Class12.char_4),
					Arguments = "/c " + string_0
				}
			}.Start();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00012B00 File Offset: 0x00010D00
		private static uint smethod_6(int int_35)
		{
			return (uint)((uint)int_35 << 12);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00012B18 File Offset: 0x00010D18
		public static int smethod_7(uint uint_11)
		{
			return Class22.SendMessage(uint_11, 4100, 0, 0U);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00012B38 File Offset: 0x00010D38
		public static int smethod_8(int int_35, uint uint_11, string string_0, uint uint_12 = 0U, bool bool_0 = true, bool bool_1 = true)
		{
			bool flag = string_0 == null;
			if (!flag)
			{
				bool flag2 = string_0 == "";
				if (!flag2)
				{
					int num = Class22.SendMessage(uint_11, 4100, 0, 0U);
					bool flag3 = num <= 0;
					if (flag3)
					{
						return -1;
					}
					string a = Class10.smethod_1(string_0, 1, true);
					string a2 = Class10.smethod_1(string_0, 0, true);
					int i = 0;
					while (i < num)
					{
						string b = Class22.smethod_12(int_35, uint_11, i, 0, uint_12);
						bool flag4 = !(string_0 == b) && !(a == b);
						if (flag4)
						{
							bool flag5 = !(a2 == b);
							if (flag5)
							{
								i++;
								continue;
							}
						}
						return i;
					}
					return -1;
				}
			}
			return -1;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00012C14 File Offset: 0x00010E14
		public static int smethod_9(uint uint_11)
		{
			return Class22.SendMessage(uint_11, 4146, 0, 0U);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00012C34 File Offset: 0x00010E34
		public static bool smethod_10(uint uint_11, int int_35)
		{
			int num = Class22.SendMessage(uint_11, 4140, int_35, 2U);
			int num2 = 2 & num;
			return num2 > 0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00012C5C File Offset: 0x00010E5C
		public static int smethod_11(uint uint_11, int int_35, bool bool_0 = false)
		{
			int num = int_35 << 16 | 4;
			bool flag = !bool_0;
			int result;
			if (flag)
			{
				result = Class22.SendMessage(uint_11, 4116, 0, (uint)num);
			}
			else
			{
				result = Class22.SendMessage(uint_11, 4116, num, 0U);
			}
			return result;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00012C9C File Offset: 0x00010E9C
		public static string smethod_12(int int_35, uint uint_11, int int_36, int int_37 = 0, uint uint_12 = 0U)
		{
			string result = null;
			bool flag = false;
			try
			{
				int num = Marshal.SizeOf(typeof(GStruct5));
				byte[] array = new byte[256];
				bool flag2 = uint_12 == 0U;
				if (flag2)
				{
					uint_12 = Class22.smethod_1(int_35, (uint)array.Length, GEnum1.flag_2);
					bool flag3 = uint_12 == 0U;
					if (flag3)
					{
						return null;
					}
					flag = true;
				}
				GStruct5 gstruct = default(GStruct5);
				gstruct.uint_0 = 1U;
				gstruct.int_0 = int_36;
				gstruct.int_1 = int_37;
				gstruct.intptr_0 = (IntPtr)((long)((ulong)uint_12 + (ulong)((long)num)));
				gstruct.int_2 = 50;
				bool flag4 = Class22.WriteProcessMemory_1(int_35, uint_12, ref gstruct, num, 0);
				if (flag4)
				{
					Class22.SendMessage(uint_11, 4171, 0, uint_12);
					int num2 = 0;
					bool flag5 = Class22.ReadProcessMemory(int_35, uint_12 + (uint)num, array, 60, ref num2);
					if (flag5)
					{
						int num3 = 0;
						while (num3 < num2 / 2 && array[num3 * 2] + array[num3 * 2 + 1] > 0)
						{
							num3++;
						}
						bool flag6 = num3 > 0;
						if (flag6)
						{
							result = Encoding.Unicode.GetString(array, 0, num3 * 2);
						}
					}
				}
			}
			catch
			{
			}
			bool flag7 = flag && uint_12 > 0U;
			if (flag7)
			{
				Class22.smethod_2(int_35, uint_12);
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012E08 File Offset: 0x00011008
		public static int smethod_13(int int_35, uint uint_11, int int_36, uint uint_12 = 0U)
		{
			int int_37 = Marshal.SizeOf(typeof(GStruct5));
			byte[] array = new byte[256];
			bool flag = false;
			bool flag2 = uint_12 == 0U;
			if (flag2)
			{
				uint_12 = Class22.smethod_1(int_35, (uint)array.Length, GEnum1.flag_2);
				bool flag3 = uint_12 == 0U;
				if (flag3)
				{
					return -1;
				}
				flag = true;
			}
			GStruct5 gstruct = default(GStruct5);
			gstruct.uint_0 = 8U;
			gstruct.uint_1 = 0U;
			gstruct.uint_2 = 3U;
			int result = 0;
			bool flag4 = Class22.WriteProcessMemory_1(int_35, uint_12, ref gstruct, int_37, 0);
			if (flag4)
			{
				result = Class22.SendMessage(uint_11, 4139, int_36, uint_12);
			}
			bool flag5 = flag && uint_12 > 0U;
			if (flag5)
			{
				Class22.smethod_2(int_35, uint_12);
			}
			return result;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012EC0 File Offset: 0x000110C0
		public static int smethod_14(int int_35, uint uint_11, int int_36, uint uint_12 = 0U)
		{
			int int_37 = Marshal.SizeOf(typeof(GStruct5));
			byte[] array = new byte[256];
			bool flag = false;
			bool flag2 = uint_12 == 0U;
			if (flag2)
			{
				uint_12 = Class22.smethod_1(int_35, (uint)array.Length, GEnum1.flag_2);
				bool flag3 = uint_12 == 0U;
				if (flag3)
				{
					return -1;
				}
				flag = true;
			}
			GStruct5 gstruct = default(GStruct5);
			gstruct.uint_0 = 8U;
			gstruct.uint_1 = 3U;
			gstruct.uint_2 = 3U;
			int result = 0;
			bool flag4 = Class22.WriteProcessMemory_1(int_35, uint_12, ref gstruct, int_37, 0);
			if (flag4)
			{
				result = Class22.SendMessage(uint_11, 4139, int_36, uint_12);
			}
			bool flag5 = flag && uint_12 > 0U;
			if (flag5)
			{
				Class22.smethod_2(int_35, uint_12);
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00012F78 File Offset: 0x00011178
		public static void smethod_15(int int_35, uint uint_11, int int_36, uint uint_12 = 0U)
		{
			int num = Class22.smethod_7(uint_11);
			for (int i = 0; i < num; i++)
			{
				bool flag = Class22.smethod_10(uint_11, i);
				if (flag)
				{
					Class22.smethod_13(int_35, uint_11, i, uint_12);
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00012FB4 File Offset: 0x000111B4
		public static int smethod_16(int int_35, uint uint_11, int int_36, uint uint_12 = 0U)
		{
			int int_37 = Marshal.SizeOf(typeof(GStruct5));
			byte[] array = new byte[256];
			bool flag = false;
			bool flag2 = uint_12 == 0U;
			if (flag2)
			{
				uint_12 = Class22.smethod_1(int_35, (uint)array.Length, GEnum1.flag_2);
				bool flag3 = uint_12 == 0U;
				if (flag3)
				{
					return -1;
				}
				flag = true;
			}
			GStruct5 gstruct = default(GStruct5);
			gstruct.uint_0 = 8U;
			gstruct.uint_1 = Class22.smethod_6(2);
			gstruct.uint_2 = 61440U;
			int result = 0;
			bool flag4 = Class22.WriteProcessMemory_1(int_35, uint_12, ref gstruct, int_37, 0);
			if (flag4)
			{
				result = Class22.SendMessage(uint_11, 4139, int_36, uint_12);
			}
			bool flag5 = flag && uint_12 > 0U;
			if (flag5)
			{
				Class22.smethod_2(int_35, uint_12);
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00013078 File Offset: 0x00011278
		public static int smethod_17(int int_35, uint uint_11, string string_0, uint uint_12 = 0U, bool bool_0 = true, bool bool_1 = true)
		{
			int num = Class22.smethod_8(int_35, uint_11, string_0, uint_12, bool_0, bool_1);
			bool flag = num >= 0;
			int result;
			if (flag)
			{
				result = Class22.smethod_16(int_35, uint_11, num, uint_12);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000130B0 File Offset: 0x000112B0
		public static int smethod_18(int int_35, uint uint_11, int int_36, uint uint_12 = 0U)
		{
			int int_37 = Marshal.SizeOf(typeof(GStruct5));
			byte[] array = new byte[256];
			bool flag = false;
			bool flag2 = uint_12 == 0U;
			if (flag2)
			{
				uint_12 = Class22.smethod_1(int_35, (uint)array.Length, GEnum1.flag_2);
				bool flag3 = uint_12 == 0U;
				if (flag3)
				{
					return -1;
				}
				flag = true;
			}
			GStruct5 gstruct = default(GStruct5);
			gstruct.uint_0 = 8U;
			gstruct.uint_1 = Class22.smethod_6(1);
			gstruct.uint_2 = 61440U;
			int result = 0;
			bool flag4 = Class22.WriteProcessMemory_1(int_35, uint_12, ref gstruct, int_37, 0);
			if (flag4)
			{
				result = Class22.SendMessage(uint_11, 4139, int_36, uint_12);
			}
			bool flag5 = flag && uint_12 > 0U;
			if (flag5)
			{
				Class22.smethod_2(int_35, uint_12);
			}
			return result;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00013174 File Offset: 0x00011374
		public static int smethod_19(int int_35, uint uint_11, string string_0, uint uint_12 = 0U, bool bool_0 = true, bool bool_1 = true)
		{
			int num = Class22.smethod_8(int_35, uint_11, string_0, uint_12, bool_0, bool_1);
			bool flag = num >= 0;
			int result;
			if (flag)
			{
				result = Class22.smethod_18(int_35, uint_11, num, uint_12);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000131AC File Offset: 0x000113AC
		private static string smethod_20(string string_0, string string_1, int int_35, char char_0 = ':')
		{
			bool flag = Class12.smethod_1(string_0.ToUpper(), string_1.ToUpper() + ":") >= 0;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					char_0
				});
				bool flag2 = array.Length > int_35;
				if (flag2)
				{
					return array[int_35];
				}
			}
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00013208 File Offset: 0x00011408
		private static void smethod_21(ref GStruct7[] gstruct7_0, uint uint_11, int int_35)
		{
			GStruct7 gstruct = new GStruct7
			{
				uint_0 = uint_11,
				int_0 = int_35
			};
			bool flag = gstruct7_0 == null;
			if (flag)
			{
				gstruct7_0 = new GStruct7[]
				{
					gstruct
				};
			}
			else
			{
				GStruct7[] array = new GStruct7[gstruct7_0.Length + 1];
				for (int i = 0; i < gstruct7_0.Length; i++)
				{
					ref GStruct7 ptr = ref array[i];
					ptr = gstruct7_0[i];
					bool flag2 = gstruct7_0[i].uint_0 == uint_11;
					if (flag2)
					{
						gstruct7_0[i].int_0 = int_35;
						return;
					}
				}
				array[array.Length - 1] = gstruct;
				gstruct7_0 = array;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000132C8 File Offset: 0x000114C8
		private static void smethod_22(ref GStruct8[] gstruct8_0, uint uint_11)
		{
			GStruct8 gstruct = new GStruct8
			{
				uint_0 = uint_11,
				gstruct7_0 = null
			};
			bool flag = gstruct8_0 != null;
			if (flag)
			{
				GStruct8[] array = new GStruct8[gstruct8_0.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < gstruct8_0.Length;
					if (!flag2)
					{
						goto IL_85;
					}
					ref GStruct8 ptr = ref array[num];
					ptr = gstruct8_0[num];
					bool flag3 = gstruct8_0[num].uint_0 != uint_11;
					if (!flag3)
					{
						break;
					}
					num++;
				}
				goto IL_9B;
				IL_85:
				array[array.Length - 1] = gstruct;
				gstruct8_0 = array;
				IL_9B:;
			}
			else
			{
				gstruct8_0 = new GStruct8[]
				{
					gstruct
				};
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00013384 File Offset: 0x00011584
		public static int smethod_23(string string_0, string string_1 = null, int[] int_35 = null, bool bool_0 = false)
		{
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(num);
			uint num2 = 0U;
			int num3 = 0;
			bool flag = string_1 == null;
			if (flag)
			{
				string_1 = string.Empty;
			}
			bool flag2 = string_1 != string.Empty;
			if (flag2)
			{
				string_1 = string_1.ToLower();
			}
			for (;;)
			{
				for (;;)
				{
					IL_42:
					num2 = Class22.FindWindowEx(0U, num2, string_0, null);
					bool flag3 = num2 > 0U;
					if (!flag3)
					{
						goto IL_104;
					}
					bool flag4 = Class22.GetWindowText(num2, stringBuilder, num) <= 0;
					if (!flag4)
					{
						bool flag5 = string_1 != string.Empty;
						if (flag5)
						{
							string text = stringBuilder.ToString().ToLower();
							bool flag6 = !(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1));
							if (flag6)
							{
								break;
							}
						}
						num3 = 0;
						Class22.GetWindowThreadProcessId(num2, out num3);
						bool flag7 = int_35 == null;
						if (flag7)
						{
							goto Block_9;
						}
						for (int i = 0; i < int_35.Length; i++)
						{
							bool flag8 = num3 != int_35[i];
							if (!flag8)
							{
								goto IL_42;
							}
						}
						goto Block_11;
					}
				}
			}
			Block_9:
			Block_11:
			goto IL_111;
			IL_104:
			return 0;
			IL_111:
			return num3;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000134AC File Offset: 0x000116AC
		public static int[] smethod_24(string string_0, string string_1 = null, bool bool_0 = false)
		{
			int num = 256;
			StringBuilder stringBuilder = new StringBuilder(num);
			uint num2 = 0U;
			int num3 = 0;
			int[] array = null;
			bool flag = string_1 == null;
			if (flag)
			{
				string_1 = string.Empty;
			}
			bool flag2 = string_1 != string.Empty;
			if (flag2)
			{
				string_1 = string_1.ToLower();
			}
			for (;;)
			{
				num2 = Class22.FindWindowEx(0U, num2, string_0, null);
				bool flag3 = num2 == 0U;
				if (flag3)
				{
					break;
				}
				bool flag4 = Class22.GetWindowText(num2, stringBuilder, num) <= 0;
				if (!flag4)
				{
					bool flag5 = string_1 != string.Empty;
					if (flag5)
					{
						string text = stringBuilder.ToString().ToLower();
						bool flag6 = !(text == string_1) && (bool_0 || 0 > text.IndexOf(string_1));
						if (flag6)
						{
							continue;
						}
					}
					num3 = 0;
					Class22.GetWindowThreadProcessId(num2, out num3);
					bool flag7 = array == null;
					if (flag7)
					{
						array = new int[]
						{
							num3
						};
					}
					else
					{
						int num4 = array.Length;
						int num5 = 0;
						for (;;)
						{
							bool flag8 = num5 < num4;
							if (!flag8)
							{
								goto IL_113;
							}
							bool flag9 = num3 == array[num5];
							if (flag9)
							{
								break;
							}
							num5++;
						}
						continue;
						IL_113:
						Array.Resize<int>(ref array, num4 + 1);
						array[num4] = num3;
					}
				}
			}
			return array;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000135F8 File Offset: 0x000117F8
		public static string smethod_25(int int_35, string string_0, bool bool_0 = true, bool bool_1 = true)
		{
			string_0 = string_0.ToUpper();
			int num = 256;
			uint num2 = 0U;
			StringBuilder stringBuilder = new StringBuilder(num);
			string text = "";
			while (int_35 > 0 || bool_0)
			{
				num2 = Class22.FindWindowEx(0U, num2, null, null);
				bool flag = num2 == 0U;
				if (flag)
				{
					break;
				}
				int num3 = 0;
				Class22.GetWindowThreadProcessId(num2, out num3);
				bool flag2 = num3 != int_35 && (!bool_0 || string_0 == "");
				if (!flag2)
				{
					int windowText = Class22.GetWindowText(num2, stringBuilder, num);
					bool flag3 = windowText <= 0;
					if (!flag3)
					{
						string text2 = stringBuilder.ToString().ToUpper();
						bool flag4 = text2 != "" && (string_0 == "" || text2 == string_0 || (!bool_1 && Class12.smethod_1(text2, string_0) >= 0));
						if (flag4)
						{
							bool flag5 = text != "";
							if (flag5)
							{
								text = ";" + text;
							}
							text = num2.ToString() + text;
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00013728 File Offset: 0x00011928
		public static string smethod_26(byte[] byte_0, int int_35 = 0)
		{
			string text = "";
			bool flag = int_35 > 0;
			string result;
			if (flag)
			{
				int num = 0;
				while (num < byte_0.Length && byte_0[num] > 0)
				{
					string str = text;
					char c = (char)byte_0[num];
					text = str + c.ToString();
					num += 2;
				}
				result = text;
			}
			else
			{
				int num2 = 0;
				while (num2 < byte_0.Length && byte_0[num2] > 0)
				{
					string str2 = text;
					char c = (char)byte_0[num2];
					text = str2 + c.ToString();
					num2++;
				}
				result = text;
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000137BC File Offset: 0x000119BC
		public static string smethod_27(byte[] byte_0, int int_35, int int_36)
		{
			bool flag = byte_0 != null && byte_0.Length != 0 && int_36 != 0;
			string result;
			if (flag)
			{
				string text = null;
				int num = int_35 + int_36;
				for (int i = int_35; i < num; i++)
				{
					string str = text;
					char c = (char)byte_0[i];
					text = str + c.ToString();
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0001381C File Offset: 0x00011A1C
		public static string smethod_28(uint uint_11, int int_35, int int_36 = 40)
		{
			int num = 0;
			byte[] array;
			for (;;)
			{
				array = new byte[int_36];
				bool flag = Class22.ReadProcessMemory(int_35, uint_11, array, array.Length, ref num);
				if (flag)
				{
					break;
				}
				bool flag2 = int_36 <= 0;
				if (flag2)
				{
					break;
				}
				int_36--;
			}
			int num2 = Array.IndexOf<byte>(array, 0);
			num2 = ((num2 >= 0) ? num2 : array.Length);
			return Encoding.UTF7.GetString(array, 0, num2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00013890 File Offset: 0x00011A90
		public static string smethod_29(uint uint_11, int int_35, int int_36 = 40)
		{
			bool flag = int_36 > 512;
			if (flag)
			{
				int_36 = 512;
			}
			int num = 0;
			byte[] array = new byte[int_36];
			bool flag2 = Class22.ReadProcessMemory(int_35, uint_11, array, array.Length, ref num);
			string result;
			if (flag2)
			{
				int num2 = array.Length;
				int num3 = 0;
				while (num3 < array.Length && array[num2 - num3 - 1] <= 0)
				{
					int_36--;
					num3++;
				}
				bool flag3 = int_36 != 0;
				if (flag3)
				{
					result = Encoding.UTF7.GetString(array, 0, int_36);
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
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00013934 File Offset: 0x00011B34
		public static uint smethod_30(uint uint_11, int int_35)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(int_35, uint_11, array, 4, ref num);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00013964 File Offset: 0x00011B64
		public static bool smethod_31(uint uint_11, int int_35, uint uint_12, int int_36 = 4)
		{
			int num = 0;
			byte[] array = BitConverter.GetBytes(uint_12);
			int int_37 = array.Length;
			bool flag = int_36 > 0;
			if (flag)
			{
				byte[] array2 = new byte[int_36];
				for (int i = 0; i < int_36; i++)
				{
					bool flag2 = i < array.Length;
					if (flag2)
					{
						array2[i] = array[i];
					}
				}
				array = array2;
				int_37 = int_36;
			}
			else
			{
				bool flag3 = uint_12 >> 8 == 0U;
				if (flag3)
				{
					int_37 = 1;
				}
				else
				{
					bool flag4 = uint_12 >> 16 == 0U;
					if (flag4)
					{
						int_37 = 2;
					}
				}
			}
			return Class22.WriteProcessMemory(int_35, uint_11, array, int_37, ref num);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000139FC File Offset: 0x00011BFC
		public static void smethod_32(int int_35)
		{
			try
			{
				Class22.CloseHandle((IntPtr)int_35);
			}
			catch
			{
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00013A30 File Offset: 0x00011C30
		public static uint smethod_33(string string_0, string string_1, int int_35 = 0)
		{
			bool flag = int_35 == 0;
			if (flag)
			{
				int_35 = Process.GetCurrentProcess().Id;
			}
			uint num = Class22.smethod_35(int_35, string_0);
			uint procAddress = Class22.GetProcAddress(num, string_1);
			bool flag2 = procAddress == 0U;
			uint result;
			if (flag2)
			{
				result = 0U;
			}
			else
			{
				result = procAddress - num;
			}
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00013A78 File Offset: 0x00011C78
		public static string smethod_34(int int_35, string string_0 = "")
		{
			string result;
			try
			{
				result = Process.GetProcessById(int_35).MainModule.FileName;
			}
			catch
			{
				result = string_0;
			}
			return result;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00013AB8 File Offset: 0x00011CB8
		public static uint smethod_35(int int_35, string string_0)
		{
			try
			{
				string_0 = string_0.ToUpper();
				ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
				int count = modules.Count;
				for (int i = 0; i < count; i++)
				{
					bool flag = modules[count - i - 1].ModuleName.ToUpper() == string_0;
					if (flag)
					{
						return (uint)((int)modules[count - i - 1].BaseAddress);
					}
				}
			}
			catch
			{
			}
			return 0U;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00013B50 File Offset: 0x00011D50
		private static void smethod_36(ref Class22.Struct6[] struct6_0, string string_0, uint uint_11)
		{
			Class22.Struct6 @struct = new Class22.Struct6
			{
				uint_0 = uint_11,
				string_0 = string_0
			};
			bool flag = struct6_0 != null && struct6_0.Length != 0;
			if (flag)
			{
				Class22.Struct6[] array = new Class22.Struct6[struct6_0.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < struct6_0.Length;
					if (!flag2)
					{
						goto IL_A9;
					}
					bool flag3 = !(struct6_0[num].string_0 == string_0) || struct6_0[num].uint_0 != uint_11;
					if (!flag3)
					{
						break;
					}
					ref Class22.Struct6 ptr = ref array[num];
					ptr = struct6_0[num];
					num++;
				}
				goto IL_BF;
				IL_A9:
				array[array.Length - 1] = @struct;
				struct6_0 = array;
				IL_BF:;
			}
			else
			{
				struct6_0 = new Class22.Struct6[]
				{
					@struct
				};
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00013C30 File Offset: 0x00011E30
		public static uint smethod_37(int int_35, string string_0)
		{
			try
			{
				string_0 = string_0.ToUpper();
				ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
				int count = modules.Count;
				for (int i = 0; i < count; i++)
				{
					bool flag = modules[count - i - 1].ModuleName.ToUpper() == string_0;
					if (flag)
					{
						return (uint)((int)modules[count - i - 1].BaseAddress);
					}
				}
			}
			catch
			{
			}
			return 0U;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00013CC8 File Offset: 0x00011EC8
		public static void smethod_38(int int_35, string string_0, ref Class22.Struct6[] struct6_0)
		{
			try
			{
				string_0 = string_0.ToUpper();
				ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
				int count = modules.Count;
				for (int i = 0; i < count; i++)
				{
					string text = modules[count - i - 1].ModuleName.ToUpper();
					bool flag = Class12.smethod_1(text, string_0) >= 0;
					if (flag)
					{
						Class22.smethod_36(ref struct6_0, text, (uint)((int)modules[count - i - 1].BaseAddress));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00013D64 File Offset: 0x00011F64
		public static GStruct4 smethod_39(ref GStruct3 gstruct3_0, string string_0, string string_1 = null, string string_2 = null)
		{
			GStruct4 result = default(GStruct4);
			bool flag = !Class22.CreateProcess(string_0, string_2, IntPtr.Zero, IntPtr.Zero, false, GEnum3.flag_10, IntPtr.Zero, string_1, ref gstruct3_0, out result);
			if (flag)
			{
				result.uint_0 = 0U;
				result.uint_1 = 0U;
				result.intptr_0 = IntPtr.Zero;
				result.intptr_1 = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00013DCC File Offset: 0x00011FCC
		public static Process smethod_40(string string_0, string string_1 = "", string string_2 = "", byte byte_0 = 0, bool bool_0 = false, bool bool_1 = false)
		{
			Process process = new Process();
			try
			{
				bool flag = string_2 == null;
				if (flag)
				{
					string_2 = string.Empty;
				}
				process.StartInfo.FileName = string_0;
				bool flag2 = string_1 != "";
				if (flag2)
				{
					process.StartInfo.WorkingDirectory = string_1;
				}
				process.StartInfo.Arguments = string_2;
				if (bool_0)
				{
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				}
				process.StartInfo.UseShellExecute = bool_1;
				process.Start();
				bool flag3 = byte_0 > 0;
				if (flag3)
				{
					process.WaitForInputIdle();
				}
			}
			catch
			{
				process = null;
			}
			return process;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00013E80 File Offset: 0x00012080
		public static GStruct4 smethod_41(string string_0, string string_1 = null, bool bool_0 = false, string string_2 = null)
		{
			GStruct3 gstruct = default(GStruct3);
			if (bool_0)
			{
				gstruct.uint_8 = 1U;
				gstruct.short_0 = 0;
			}
			return Class22.smethod_39(ref gstruct, string_0, string_1, string_2);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00013EBC File Offset: 0x000120BC
		public static void smethod_42(GStruct4 gstruct4_0)
		{
			IntPtr intptr_ = gstruct4_0.intptr_1;
			Class22.SuspendThread(intptr_);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00013ED8 File Offset: 0x000120D8
		public static void smethod_43(Process process_0)
		{
			try
			{
				bool flag = process_0.ProcessName == null || process_0.ProcessName == "";
				if (!flag)
				{
					foreach (object obj in process_0.Threads)
					{
						ProcessThread processThread = (ProcessThread)obj;
						IntPtr intPtr = Class22.OpenThread(GEnum2.flag_1, false, (uint)processThread.Id);
						bool flag2 = !(intPtr == IntPtr.Zero);
						if (flag2)
						{
							Class22.SuspendThread(intPtr);
							Class22.CloseHandle(intPtr);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00013F9C File Offset: 0x0001219C
		public static void smethod_44(GStruct4 gstruct4_0)
		{
			IntPtr intptr_ = gstruct4_0.intptr_1;
			Class22.ResumeThread(intptr_);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00013FB8 File Offset: 0x000121B8
		public static void smethod_45(Process process_0)
		{
			try
			{
				bool flag = process_0.ProcessName == null || process_0.ProcessName == "";
				if (!flag)
				{
					foreach (object obj in process_0.Threads)
					{
						ProcessThread processThread = (ProcessThread)obj;
						IntPtr intPtr = Class22.OpenThread(GEnum2.flag_1, false, (uint)processThread.Id);
						bool flag2 = !(intPtr == IntPtr.Zero);
						if (flag2)
						{
							int num;
							do
							{
								num = Class22.ResumeThread(intPtr);
							}
							while (num > 0);
							Class22.CloseHandle(intPtr);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00014090 File Offset: 0x00012290
		public static void smethod_46(int int_35)
		{
			Class22.smethod_43(Process.GetProcessById(int_35));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001409F File Offset: 0x0001229F
		public static void smethod_47(int int_35)
		{
			Class22.smethod_45(Process.GetProcessById(int_35));
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000140B0 File Offset: 0x000122B0
		public static void smethod_48(int int_35)
		{
			long long_ = Class12.smethod_27();
			while (int_35 > 0 && Class22.smethod_51(int_35) && Class12.smethod_28(long_) < 3000L)
			{
				try
				{
					Process processById = Process.GetProcessById(int_35);
					processById.Kill();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00014110 File Offset: 0x00012310
		public static void smethod_49(Process process_0)
		{
			try
			{
				long long_ = Class12.smethod_27();
				while (!Class22.smethod_52(process_0) && Class12.smethod_28(long_) < 3000L)
				{
					process_0.Kill();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00014168 File Offset: 0x00012368
		public static void smethod_50(Process process_0)
		{
			try
			{
				process_0.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00014198 File Offset: 0x00012398
		public static bool smethod_51(int int_35)
		{
			Process process = null;
			try
			{
				process = Process.GetProcessById(int_35);
			}
			catch
			{
			}
			return process != null && process.Id > 0;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000141DC File Offset: 0x000123DC
		public static bool smethod_52(Process process_0)
		{
			try
			{
				return process_0 == null || process_0.HasExited;
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00014214 File Offset: 0x00012414
		public static void smethod_53(Process process_0)
		{
			bool flag = process_0 != null;
			if (flag)
			{
				try
				{
					process_0.Kill();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001424C File Offset: 0x0001244C
		public static int smethod_54(string string_0)
		{
			try
			{
				Process[] processesByName = Process.GetProcessesByName(string_0);
				bool flag = processesByName != null;
				if (flag)
				{
					bool flag2 = processesByName.Length != 0;
					if (flag2)
					{
						return processesByName[0].Id;
					}
				}
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000142B0 File Offset: 0x000124B0
		public static int smethod_55(Process process_0)
		{
			try
			{
				return process_0.Id;
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000142E4 File Offset: 0x000124E4
		public static int smethod_56()
		{
			return Process.GetCurrentProcess().Id;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00014300 File Offset: 0x00012500
		public static bool smethod_57(ref Process process_0, int int_35)
		{
			try
			{
				process_0 = Process.GetProcessById(int_35);
				return process_0.Id > 0;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00014340 File Offset: 0x00012540
		public static uint smethod_58(Process process_0)
		{
			try
			{
				return (uint)((int)process_0.MainModule.BaseAddress);
			}
			catch
			{
			}
			return 0U;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0001437C File Offset: 0x0001257C
		public static uint smethod_59(int int_35)
		{
			try
			{
				Process processById = Process.GetProcessById(int_35);
				return (uint)((int)processById.MainModule.BaseAddress);
			}
			catch
			{
			}
			return 0U;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000143C0 File Offset: 0x000125C0
		public static string smethod_60(int int_35, bool bool_0)
		{
			try
			{
				Process processById = Process.GetProcessById(int_35);
				bool flag = !bool_0;
				if (flag)
				{
					return processById.MainModule.ModuleName;
				}
				return processById.MainModule.FileName;
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00014418 File Offset: 0x00012618
		public static uint[] smethod_61(int int_35, string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				'|'
			});
			uint[] array2 = new uint[array.Length];
			try
			{
				ProcessModuleCollection modules = Process.GetProcessById(int_35).Modules;
				int count = modules.Count;
				for (int i = 0; i < count; i++)
				{
					for (int j = 0; j < array.Length; j++)
					{
						string b = array[j].ToUpper();
						bool flag = modules[count - i - 1].ModuleName.ToUpper() == b;
						if (flag)
						{
							array2[j] = (uint)((int)modules[count - i - 1].BaseAddress);
						}
					}
				}
			}
			catch
			{
			}
			return array2;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000144F0 File Offset: 0x000126F0
		public static GStruct8[] smethod_62(int int_35, string string_0, int int_36 = 0)
		{
			GStruct8[] array = null;
			bool flag = string_0 == null || string_0 == "";
			GStruct8[] result;
			if (flag)
			{
				result = array;
			}
			else
			{
				string text = null;
				string text2 = null;
				string text3 = null;
				string text4 = null;
				string[] array2 = string_0.Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array2.Length; i++)
				{
					bool flag2 = text == null;
					if (flag2)
					{
						text = Class22.smethod_20(array2[i], "WIN_TITLE", 1, ':');
					}
					bool flag3 = text2 == null;
					if (flag3)
					{
						text2 = Class22.smethod_20(array2[i], "WIN_CLASS", 1, ':');
					}
					bool flag4 = text3 == null;
					if (flag4)
					{
						text3 = Class22.smethod_20(array2[i], "CTR_CLASS", 1, ':');
					}
					bool flag5 = text4 == null;
					if (flag5)
					{
						text4 = Class22.smethod_20(array2[i], "CTR_INSTANCE", 1, ':');
					}
				}
				int num = -1;
				bool flag6 = text4 != null;
				if (flag6)
				{
					num = Class12.smethod_11(text4);
				}
				int num2 = 256;
				uint num3 = 0U;
				StringBuilder stringBuilder = new StringBuilder(num2);
				while (int_35 > 0)
				{
					num3 = Class22.FindWindowEx(0U, num3, text2, null);
					bool flag7 = num3 == 0U;
					if (flag7)
					{
						break;
					}
					int num4 = 0;
					Class22.GetWindowThreadProcessId(num3, out num4);
					bool flag8 = num4 != int_35;
					if (!flag8)
					{
						bool flag9 = text != null && text != "";
						if (flag9)
						{
							int windowText = Class22.GetWindowText(num3, stringBuilder, num2);
							bool flag10 = windowText <= 0;
							if (flag10)
							{
								continue;
							}
							string text5 = stringBuilder.ToString().ToUpper();
							bool flag11 = text5 == "" || Class12.smethod_1(text5, text.ToUpper()) < 0;
							if (flag11)
							{
								continue;
							}
						}
						bool flag12 = text2 != null && text2 != "";
						if (flag12)
						{
							int className = Class22.GetClassName(num3, stringBuilder, num2);
							bool flag13 = className <= 0;
							if (flag13)
							{
								continue;
							}
							string a = stringBuilder.ToString().ToUpper();
							bool flag14 = a != text2.ToUpper();
							if (flag14)
							{
								continue;
							}
						}
						Class22.smethod_22(ref array, num3);
						uint num5 = 0U;
						int num6 = 0;
						for (;;)
						{
							num6++;
							num5 = Class22.FindWindowEx(num3, num5, text3, null);
							bool flag15 = num5 == 0U;
							if (flag15)
							{
								break;
							}
							bool flag16 = num < 0 || num6 == num;
							if (flag16)
							{
								Class22.smethod_21(ref array[array.Length - 1].gstruct7_0, num5, num6);
								bool flag17 = num > 0;
								if (flag17)
								{
									goto Block_23;
								}
							}
							bool flag18 = int_36 > 0;
							if (flag18)
							{
								Thread.Sleep(int_36);
							}
						}
						bool flag19 = int_36 > 0;
						if (flag19)
						{
							Thread.Sleep(int_36);
						}
						continue;
						Block_23:
						return array;
					}
				}
				result = array;
			}
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000147C0 File Offset: 0x000129C0
		public static uint[] smethod_63(int int_35, string string_0)
		{
			bool flag = string_0 != null;
			uint[] result;
			if (flag)
			{
				string text = string_0.ToUpper();
				uint num = 0U;
				uint[] array = null;
				int num2 = 256;
				StringBuilder stringBuilder = new StringBuilder(num2);
				while (int_35 > 0)
				{
					num = Class22.FindWindowEx(0U, num, text, null);
					bool flag2 = num == 0U;
					if (flag2)
					{
						break;
					}
					int num3 = 0;
					Class22.GetWindowThreadProcessId(num, out num3);
					bool flag3 = num3 != int_35;
					if (!flag3)
					{
						int className = Class22.GetClassName(num, stringBuilder, num2);
						bool flag4 = className > 0 && !(stringBuilder.ToString().ToUpper() != text);
						if (flag4)
						{
							bool flag5 = array == null;
							if (flag5)
							{
								array = new uint[1];
							}
							else
							{
								Array.Resize<uint>(ref array, array.Length + 1);
							}
							array[array.Length - 1] = num;
						}
					}
				}
				result = array;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000148A4 File Offset: 0x00012AA4
		public static uint[] smethod_64(int int_35, uint uint_11, string string_0, bool bool_0 = false)
		{
			int num = 0;
			while (!Class12.bool_0 && num < 20)
			{
				uint[] array = Class22.smethod_66(int_35, uint_11, string_0);
				bool flag = array == null;
				if (!flag)
				{
					return array;
				}
				Thread.Sleep(300);
				num++;
			}
			bool flag2 = !bool_0;
			if (flag2)
			{
				Class12.smethod_29(ref Class12.string_16, "RVA không hợp lệ !");
			}
			return null;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00014914 File Offset: 0x00012B14
		public static uint[] smethod_65(int int_35, uint uint_11, int int_36 = 10)
		{
			uint[] array = new uint[int_36];
			uint num = Class22.smethod_30(uint_11 + 60U, int_35);
			array[0] = Class22.smethod_30(uint_11 + num + 44U, int_35);
			uint num2 = 1U;
			while ((ulong)num2 < (ulong)((long)array.Length))
			{
				array[(int)num2] = Class22.smethod_30(uint_11 + num + 256U + (num2 - 1U) * 40U, int_35);
				num2 += 1U;
			}
			return array;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001497C File Offset: 0x00012B7C
		public static uint[] smethod_66(int int_35, uint uint_11, string string_0 = null)
		{
			bool flag = string_0 == null || string_0 == string.Empty;
			if (flag)
			{
				string_0 = ".text";
			}
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			int num = 0;
			byte[] array = new byte[2];
			Class22.ReadProcessMemory(int_35, uint_11 + 60U, array, 2, ref num);
			uint num2 = (uint)BitConverter.ToInt16(array, 0);
			uint num3 = num2;
			int num4 = bytes.Length;
			array = new byte[num4];
			for (;;)
			{
				num = 0;
				bool flag3;
				bool flag2 = (flag3 = Class22.ReadProcessMemory(int_35, uint_11 + num2, array, num4, ref num)) && num2 <= 4095U;
				if (!flag2)
				{
					goto IL_D3;
				}
				for (int i = 0; i < num4; i++)
				{
					bool flag4 = array[i] != bytes[i];
					if (flag4)
					{
						flag3 = false;
						break;
					}
				}
				bool flag5 = !flag3;
				if (!flag5)
				{
					break;
				}
				num2 += 1U;
			}
			goto IL_F4;
			IL_D3:
			bool flag6 = !(string_0 == ".text");
			if (flag6)
			{
				return new uint[2];
			}
			num2 = num3 + 248U;
			IL_F4:
			num2 += 8U;
			num = 0;
			array = new byte[4];
			Class22.ReadProcessMemory(int_35, uint_11 + num2, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			num = 0;
			array = new byte[4];
			Class22.ReadProcessMemory(int_35, uint_11 + num2 + 4U, array, 4, ref num);
			uint num6 = BitConverter.ToUInt32(array, 0);
			return new uint[]
			{
				num5,
				num6
			};
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00014AEC File Offset: 0x00012CEC
		public static bool smethod_67(int int_35, string string_0)
		{
			int num = Class22.OpenProcess(2035711, false, int_35);
			bool flag = num == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = false;
				uint num2 = 0U;
				uint procAddress = Class22.GetProcAddress(Class22.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
				bool flag3 = procAddress > 0U;
				if (flag3)
				{
					uint num3 = Class22.smethod_1(num, (uint)string_0.Length, GEnum1.flag_2);
					bool flag4 = num3 > 0U;
					if (flag4)
					{
						byte[] bytes = Encoding.ASCII.GetBytes(string_0);
						int num4 = 0;
						bool flag5;
						flag2 = (flag5 = Class22.WriteProcessMemory(num, num3, bytes, bytes.Length, ref num4));
						if (flag5)
						{
							uint num5 = 0U;
							num2 = Class22.CreateRemoteThread(num, IntPtr.Zero, 0U, procAddress, num3, 0U, out num5);
						}
					}
				}
				Class22.smethod_32(num);
				result = (flag2 && num2 > 0U);
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00014BB4 File Offset: 0x00012DB4
		public static int smethod_68(Process process_0, string string_0)
		{
			int num = 0;
			try
			{
				num = process_0.Id;
			}
			catch
			{
			}
			bool flag = Class22.smethod_52(process_0) || num == 0;
			int result;
			if (flag)
			{
				result = -2;
			}
			else
			{
				uint num2 = Class22.smethod_35(num, string_0);
				bool flag2 = num2 == 0U;
				if (flag2)
				{
					result = -3;
				}
				else
				{
					int num3 = Class22.OpenProcess(2035711, true, num);
					bool flag3 = num3 != 0;
					if (flag3)
					{
						uint[] array = Class22.smethod_66(num3, num2, null);
						uint num4 = array[0];
						uint num5 = num2 + 4096U;
						uint num6 = num5 + num4;
						int num7 = 0;
						for (int i = 0; i < process_0.Threads.Count; i++)
						{
							uint num8 = Class22.smethod_70(process_0.Threads[i].Id);
							bool flag4 = num8 > num5 && num8 < num6;
							if (flag4)
							{
								bool value = Class22.smethod_69((uint)process_0.Threads[i].Id);
								num7 += (int)Convert.ToByte(value);
							}
						}
						Class22.smethod_32(num3);
						result = num7;
					}
					else
					{
						result = -4;
					}
				}
			}
			return result;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00014CE8 File Offset: 0x00012EE8
		private static bool smethod_69(uint uint_11)
		{
			IntPtr intPtr = Class22.OpenThread(GEnum2.flag_0, false, uint_11);
			bool flag = intPtr == IntPtr.Zero;
			return !flag && Class22.TerminateThread(intPtr, 0U);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00014D20 File Offset: 0x00012F20
		private static uint smethod_70(int int_35)
		{
			int int_36 = 9;
			IntPtr intPtr = Class22.OpenThread(GEnum2.flag_5, false, (uint)int_35);
			bool flag = !(intPtr == IntPtr.Zero);
			if (flag)
			{
				IntPtr intPtr2 = Marshal.AllocHGlobal(IntPtr.Size);
				try
				{
					bool flag2 = Class22.NtQueryInformationThread(intPtr, int_36, intPtr2, IntPtr.Size, IntPtr.Zero) == 0;
					if (flag2)
					{
						return (uint)((int)Marshal.ReadIntPtr(intPtr2));
					}
					return Convert.ToUInt32(-1);
				}
				finally
				{
					Class22.CloseHandle(intPtr);
					Marshal.FreeHGlobal(intPtr2);
				}
			}
			return 0U;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00014DB8 File Offset: 0x00012FB8
		public static void smethod_71(string string_0 = null, bool bool_0 = true)
		{
			try
			{
				bool flag = string_0 == null;
				if (flag)
				{
					Process currentProcess = Process.GetCurrentProcess();
					string_0 = currentProcess.MainModule.FileName.ToUpper();
				}
				string string_ = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
				string text = "RUNASADMIN";
				string text2 = string.Empty;
				string text3 = Class62.smethod_1(string_, string_0, 0, "");
				string text4 = Class62.smethod_1(string_, string_0, 1, "");
				bool flag2 = text3 != text4 && text4 != string.Empty;
				if (flag2)
				{
					text3 = text4;
				}
				bool flag3 = text3 != string.Empty && text3 != null;
				if (flag3)
				{
					string[] array = text3.Split(new char[]
					{
						' '
					});
					for (int i = 0; i < array.Length; i++)
					{
						bool flag4 = array[i].ToUpper().IndexOf(text) < 0;
						if (flag4)
						{
							bool flag5 = text2 != string.Empty;
							if (flag5)
							{
								text2 += " ";
							}
							text2 += array[i];
						}
					}
				}
				if (bool_0)
				{
					bool flag6 = text2 != string.Empty;
					if (flag6)
					{
						text = text + " " + text2;
					}
				}
				else
				{
					text = text2;
				}
				Class62.smethod_10(string_, string_0, text, "", 0);
				Class62.smethod_10(string_, string_0, text, "", 1);
			}
			catch
			{
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00014F3C File Offset: 0x0001313C
		public static void smethod_72()
		{
			string string_ = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Associations";
			string string_2 = "LowRiskFileTypes";
			Class62.smethod_10(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 0);
			Class62.smethod_10(string_, string_2, ".exe;.bat;.cmd;.vbs", "", 1);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00014F7C File Offset: 0x0001317C
		public static void smethod_73(string string_0, string string_1, string string_2 = null, int int_35 = 1)
		{
			Environment.SpecialFolder folder = Environment.SpecialFolder.DesktopDirectory;
			bool flag = int_35 == 2;
			if (flag)
			{
			}
			Interface0 @interface = (Interface0)new Class21();
			@interface.imethod_4("AutoKeoXe, http://canhtrang.com/");
			@interface.imethod_17(string_1);
			bool flag2 = string_2 == null;
			if (flag2)
			{
				string[] array = Class12.smethod_14(string_1, '\\');
				string_2 = array[0];
			}
			@interface.imethod_6(string_2);
			IPersistFile persistFile = (IPersistFile)@interface;
			string folderPath = Environment.GetFolderPath(folder);
			persistFile.Save(Path.Combine(folderPath, string_0 + ".lnk"), false);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00015004 File Offset: 0x00013204
		public static bool smethod_74(string string_0)
		{
			try
			{
				Process processById = Process.GetProcessById(Class22.smethod_56());
				Class22.smethod_73(string_0, processById.MainModule.FileName, null, 1);
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00015050 File Offset: 0x00013250
		public static string smethod_75()
		{
			try
			{
				Process currentProcess = Process.GetCurrentProcess();
				return currentProcess.MainModule.FileName.ToUpper();
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00015094 File Offset: 0x00013294
		public static void smethod_76(uint uint_11, int int_35)
		{
			short uint_12 = Class22.VkKeyScan(int_35);
			short num = (short)Class22.MapVirtualKey((uint)uint_12, 0U);
			uint uint_13 = (uint)((int)num << 16 | 1);
			Class22.PostMessageA_1(uint_11, Class22.int_22, (uint)int_35, uint_13);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000150C8 File Offset: 0x000132C8
		public static Mutex smethod_77(ref bool bool_0, string string_0)
		{
			bool_0 = false;
			try
			{
				return new Mutex(true, string_0, ref bool_0);
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00015100 File Offset: 0x00013300
		public static void smethod_78(Mutex mutex_0)
		{
			try
			{
				mutex_0.ReleaseMutex();
			}
			catch
			{
			}
		}

		// Token: 0x04000067 RID: 103
		public const int int_0 = 1;

		// Token: 0x04000068 RID: 104
		public const int int_1 = 277;

		// Token: 0x04000069 RID: 105
		public const int int_2 = 4;

		// Token: 0x0400006A RID: 106
		private const int int_3 = 4096;

		// Token: 0x0400006B RID: 107
		private const int int_4 = 4100;

		// Token: 0x0400006C RID: 108
		private const int int_5 = 4101;

		// Token: 0x0400006D RID: 109
		private const int int_6 = 4102;

		// Token: 0x0400006E RID: 110
		private const int int_7 = 4139;

		// Token: 0x0400006F RID: 111
		private const int int_8 = 4140;

		// Token: 0x04000070 RID: 112
		private const int int_9 = 4146;

		// Token: 0x04000071 RID: 113
		private const int int_10 = 4171;

		// Token: 0x04000072 RID: 114
		private const uint uint_0 = 1U;

		// Token: 0x04000073 RID: 115
		private const uint uint_1 = 1U;

		// Token: 0x04000074 RID: 116
		private const uint uint_2 = 2U;

		// Token: 0x04000075 RID: 117
		private const uint uint_3 = 8U;

		// Token: 0x04000076 RID: 118
		private const uint uint_4 = 4096U;

		// Token: 0x04000077 RID: 119
		private const uint uint_5 = 8192U;

		// Token: 0x04000078 RID: 120
		private const uint uint_6 = 61440U;

		// Token: 0x04000079 RID: 121
		private const uint uint_7 = 2035711U;

		// Token: 0x0400007A RID: 122
		private const uint uint_8 = 4096U;

		// Token: 0x0400007B RID: 123
		private const uint uint_9 = 32768U;

		// Token: 0x0400007C RID: 124
		private const uint uint_10 = 4U;

		// Token: 0x0400007D RID: 125
		private const int int_11 = 4116;

		// Token: 0x0400007E RID: 126
		private const int int_12 = 16;

		// Token: 0x0400007F RID: 127
		private const int int_13 = 1;

		// Token: 0x04000080 RID: 128
		private const int int_14 = 4;

		// Token: 0x04000081 RID: 129
		private const int int_15 = 2;

		// Token: 0x04000082 RID: 130
		private const int int_16 = 23;

		// Token: 0x04000083 RID: 131
		public static int int_17 = 16;

		// Token: 0x04000084 RID: 132
		public static int int_18 = 0;

		// Token: 0x04000085 RID: 133
		public static int int_19 = 5;

		// Token: 0x04000086 RID: 134
		public static int int_20 = 6;

		// Token: 0x04000087 RID: 135
		public static int int_21 = 9;

		// Token: 0x04000088 RID: 136
		public static int int_22 = 256;

		// Token: 0x04000089 RID: 137
		public static int int_23 = 257;

		// Token: 0x0400008A RID: 138
		public static int int_24 = 39;

		// Token: 0x0400008B RID: 139
		public static int int_25 = 512;

		// Token: 0x0400008C RID: 140
		public static int int_26 = 516;

		// Token: 0x0400008D RID: 141
		public static int int_27 = 517;

		// Token: 0x0400008E RID: 142
		public static int int_28 = 518;

		// Token: 0x0400008F RID: 143
		public static int int_29 = 2;

		// Token: 0x04000090 RID: 144
		public static int int_30 = 513;

		// Token: 0x04000091 RID: 145
		public static int int_31 = 514;

		// Token: 0x04000092 RID: 146
		public static int int_32 = 515;

		// Token: 0x04000093 RID: 147
		public static int int_33 = 1;

		// Token: 0x04000094 RID: 148
		public static int int_34 = Class62.smethod_3("RunAdmin", 0, "1");

		// Token: 0x020000E8 RID: 232
		public struct Struct6
		{
			// Token: 0x04001217 RID: 4631
			public string string_0;

			// Token: 0x04001218 RID: 4632
			public uint uint_0;
		}
	}
}
