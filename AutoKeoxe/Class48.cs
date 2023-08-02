using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200002C RID: 44
	internal class Class48
	{
		// Token: 0x060002BF RID: 703
		[DllImport("iphlpapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern uint GetExtendedTcpTable(IntPtr intptr_0, ref int int_1, bool bool_0, int int_2, Class48.Enum0 enum0_0, uint uint_0 = 0U);

		// Token: 0x060002C0 RID: 704 RVA: 0x00076308 File Offset: 0x00074508
		public static GStruct28[] smethod_0(int[] int_1 = null)
		{
			GStruct28[] array = null;
			try
			{
				int cb = 0;
				uint extendedTcpTable = Class48.GetExtendedTcpTable(IntPtr.Zero, ref cb, true, 2, Class48.Enum0.const_5, 0U);
				IntPtr intPtr = Marshal.AllocHGlobal(cb);
				bool flag = Class48.GetExtendedTcpTable(intPtr, ref cb, true, 2, Class48.Enum0.const_5, 0U) > 0U;
				if (flag)
				{
					return null;
				}
				Class48.Struct19 @struct = (Class48.Struct19)Marshal.PtrToStructure(intPtr, typeof(Class48.Struct19));
				bool flag2 = @struct.uint_0 == 0U;
				if (flag2)
				{
					return null;
				}
				IntPtr intPtr2 = (IntPtr)((long)intPtr + (long)Marshal.SizeOf(@struct.uint_0));
				array = ((int_1 != null) ? new GStruct28[int_1.Length] : new GStruct28[@struct.uint_0]);
				int num = 0;
				int num2 = 0;
				while ((long)num2 < (long)((ulong)@struct.uint_0))
				{
					Class48.Struct18 struct2 = (Class48.Struct18)Marshal.PtrToStructure(intPtr2, typeof(Class48.Struct18));
					intPtr2 = (IntPtr)((long)intPtr2 + (long)Marshal.SizeOf(struct2));
					bool flag3 = int_1 != null;
					if (!flag3)
					{
						goto IL_13A;
					}
					int num3 = -1;
					for (int i = 0; i < int_1.Length; i++)
					{
						bool flag4 = int_1[i] == struct2.int_0;
						if (flag4)
						{
							num3 = i;
							break;
						}
					}
					bool flag5 = num3 < 0;
					if (!flag5)
					{
						goto IL_13A;
					}
					IL_248:
					num2++;
					continue;
					IL_13A:
					bool flag6 = array.Length <= num;
					if (flag6)
					{
						Array.Resize<GStruct28>(ref array, num + 1);
					}
					array[num].int_0 = struct2.int_0;
					array[num].string_1 = new IPAddress((long)((ulong)struct2.uint_0)).ToString();
					array[num].int_1 = (int)BitConverter.ToUInt16(new byte[]
					{
						struct2.byte_0[1],
						struct2.byte_0[0]
					}, 0);
					string text = new IPAddress((long)((ulong)struct2.uint_1)).ToString();
					array[num].string_2 = text;
					array[num].int_2 = (int)BitConverter.ToUInt16(new byte[]
					{
						struct2.byte_1[1],
						struct2.byte_1[0]
					}, 0);
					array[num].string_0 = struct2.c6b3f8f0bd286eb5563fde5358cf7b375_0.ToString();
					array[num].uint_0 = Class12.smethod_6(text);
					num++;
					goto IL_248;
				}
			}
			catch
			{
			}
			return array;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000765A4 File Offset: 0x000747A4
		public static long smethod_1(string string_0)
		{
			bool flag = string_0 != null;
			long result;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				int num = 0;
				do
				{
					try
					{
						bool flag2 = array[num] != null && array[num] != string.Empty;
						if (flag2)
						{
							Ping ping = new Ping();
							PingReply pingReply = ping.Send(array[num]);
							return pingReply.RoundtripTime;
						}
					}
					catch
					{
					}
					num++;
				}
				while (num < array.Length);
				result = 0L;
			}
			else
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00076640 File Offset: 0x00074840
		private static string[] smethod_2(int int_1)
		{
			string[] array = null;
			try
			{
				int cb = 0;
				uint extendedTcpTable = Class48.GetExtendedTcpTable(IntPtr.Zero, ref cb, true, 2, Class48.Enum0.const_5, 0U);
				IntPtr intPtr = Marshal.AllocHGlobal(cb);
				bool flag = Class48.GetExtendedTcpTable(intPtr, ref cb, true, 2, Class48.Enum0.const_5, 0U) > 0U;
				if (flag)
				{
					return null;
				}
				Class48.Struct19 @struct = (Class48.Struct19)Marshal.PtrToStructure(intPtr, typeof(Class48.Struct19));
				bool flag2 = @struct.uint_0 == 0U;
				if (flag2)
				{
					return null;
				}
				IntPtr intPtr2 = (IntPtr)((long)intPtr + (long)Marshal.SizeOf(@struct.uint_0));
				int num = 0;
				while ((long)num < (long)((ulong)@struct.uint_0))
				{
					Class48.Struct18 struct2 = (Class48.Struct18)Marshal.PtrToStructure(intPtr2, typeof(Class48.Struct18));
					intPtr2 = (IntPtr)((long)intPtr2 + (long)Marshal.SizeOf(struct2));
					bool flag3 = struct2.int_0 == int_1;
					if (flag3)
					{
						string text = new IPAddress((long)((ulong)struct2.uint_1)).ToString();
						bool flag4 = array != null;
						if (flag4)
						{
							Array.Resize<string>(ref array, array.Length + 1);
						}
						else
						{
							array = new string[1];
						}
						array[array.Length - 1] = text;
					}
					num++;
				}
			}
			catch
			{
			}
			return array;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000767AC File Offset: 0x000749AC
		public static void smethod_3()
		{
			for (;;)
			{
				bool flag = !GClass1.bool_0;
				if (!flag)
				{
					break;
				}
				Thread.Sleep(600);
				if (Class12.bool_0)
				{
					return;
				}
			}
			string[] array = new string[]
			{
				"RyG7pxx01TeoPcVaQSSp1g==",
				"8eRA7LRbNqCC6bLlFfvyUQ=="
			};
			string[] array2 = Class48.smethod_2(Class22.smethod_56());
			bool flag2 = array2 == null;
			if (!flag2)
			{
				int num = 0;
				for (int i = 0; i < array2.Length; i++)
				{
					string[] array3 = array2[i].Split(new char[]
					{
						'/',
						':'
					});
					for (int j = 0; j < array3.Length; j++)
					{
						bool flag3 = array3[j] == null || !(array3[j] != string.Empty) || array3[j].IndexOf('.') <= 0;
						if (!flag3)
						{
							for (int k = 0; k < array.Length; k++)
							{
								string string_ = Class12.smethod_71("M7Y0NjIEAA==");
								int num2 = Class12.smethod_11(string_);
								bool flag4 = num2 > 0;
								if (flag4)
								{
									byte[] bytes = BitConverter.GetBytes(num2);
									Class22.WriteProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_3 * 4U, bytes, 4, ref num);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x04000173 RID: 371
		private const int int_0 = 2;

		// Token: 0x020000EF RID: 239
		private enum Enum0
		{
			// Token: 0x0400123A RID: 4666
			const_0,
			// Token: 0x0400123B RID: 4667
			const_1,
			// Token: 0x0400123C RID: 4668
			const_2,
			// Token: 0x0400123D RID: 4669
			const_3,
			// Token: 0x0400123E RID: 4670
			const_4,
			// Token: 0x0400123F RID: 4671
			const_5,
			// Token: 0x04001240 RID: 4672
			const_6,
			// Token: 0x04001241 RID: 4673
			const_7,
			// Token: 0x04001242 RID: 4674
			const_8
		}

		// Token: 0x020000F0 RID: 240
		private enum Enum1
		{
			// Token: 0x04001244 RID: 4676
			CLOSED = 1,
			// Token: 0x04001245 RID: 4677
			LISTENING,
			// Token: 0x04001246 RID: 4678
			SYN_SENT,
			// Token: 0x04001247 RID: 4679
			SYN_RCVD,
			// Token: 0x04001248 RID: 4680
			ESTABLISHED,
			// Token: 0x04001249 RID: 4681
			FIN_WAIT1,
			// Token: 0x0400124A RID: 4682
			FIN_WAIT2,
			// Token: 0x0400124B RID: 4683
			CLOSE_WAIT,
			// Token: 0x0400124C RID: 4684
			CLOSING,
			// Token: 0x0400124D RID: 4685
			LAST_ACK,
			// Token: 0x0400124E RID: 4686
			TIME_WAIT,
			// Token: 0x0400124F RID: 4687
			DELETE_TCB,
			// Token: 0x04001250 RID: 4688
			NONE = 0
		}

		// Token: 0x020000F1 RID: 241
		private struct Struct18
		{
			// Token: 0x04001251 RID: 4689
			public Class48.Enum1 c6b3f8f0bd286eb5563fde5358cf7b375_0;

			// Token: 0x04001252 RID: 4690
			public uint uint_0;

			// Token: 0x04001253 RID: 4691
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public byte[] byte_0;

			// Token: 0x04001254 RID: 4692
			public uint uint_1;

			// Token: 0x04001255 RID: 4693
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
			public byte[] byte_1;

			// Token: 0x04001256 RID: 4694
			public int int_0;
		}

		// Token: 0x020000F2 RID: 242
		private struct Struct19
		{
			// Token: 0x04001257 RID: 4695
			public uint uint_0;

			// Token: 0x04001258 RID: 4696
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
			public Class48.Struct18[] struct18_0;
		}
	}
}
