using System;
using System.Diagnostics;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200005E RID: 94
	internal class Class97
	{
		// Token: 0x0600054E RID: 1358 RVA: 0x000ED1F4 File Offset: 0x000EB3F4
		public static void smethod_0(string string_2)
		{
			bool flag = FormLogin.bool_0;
			if (flag)
			{
				Class12.smethod_29(ref FormLogin.string_0, string_2);
			}
			else
			{
				Class12.smethod_29(ref Class12.string_16, string_2);
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000ED228 File Offset: 0x000EB428
		public static void smethod_1()
		{
			bool flag = Class12.smethod_28(Class97.long_0) >= 600L;
			if (flag)
			{
				Class97.long_0 = Class12.smethod_27();
				new Thread(new ThreadStart(Class97.smethod_2)).Start();
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x000ED274 File Offset: 0x000EB474
		private static void smethod_2()
		{
			bool flag = !Form1.bool_1 && (Form1.bool_0 || GClass1.bool_1 || GClass1.string_1 == null || GClass1.string_1 == string.Empty || Form1.int_3 > Form1.int_2);
			if (!flag)
			{
				try
				{
					bool flag2 = FormLogin.int_10 > 0 && FormLogin.string_1 != null && FormLogin.string_1 != string.Empty;
					if (flag2)
					{
						Class97.smethod_3();
					}
					else
					{
						Class97.smethod_6();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000ED314 File Offset: 0x000EB514
		public static Process smethod_3()
		{
			try
			{
				return Class97.smethod_4();
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000ED348 File Offset: 0x000EB548
		private static Process smethod_4()
		{
			bool flag = Class12.smethod_17(FormLogin.string_1);
			Process result;
			if (flag)
			{
				int[] array = Class22.smethod_24(Class53.string_21, null, false);
				string[] array2 = Class12.smethod_14(FormLogin.string_1, '\\');
				int num = 0;
				while (num < 100 && Class97.process_0 != null)
				{
					num++;
					Thread.Sleep(10);
				}
				Class97.process_0 = Class22.smethod_40(FormLogin.string_1, array2[0], Class97.string_1, 0, false, false);
				bool flag2 = Class97.process_0 == null;
				if (flag2)
				{
					Class97.smethod_0("Không thể mở game, hãy kiểm tra lại file khác trong nút Login -> Thiết lập khác");
					result = null;
				}
				else
				{
					int id = Class97.process_0.Id;
					bool flag3 = false;
					num = 0;
					while (!Class12.bool_0)
					{
						Thread.Sleep(10);
						bool flag4 = !flag3 && num % 20 == 0;
						if (flag4)
						{
							GStruct8[] array3 = Class22.smethod_62(id, "WIN_CLASS:#32770|CTR_CLASS:Button", 0);
							bool flag5 = array3 != null && array3.Length != 0 && array3[0].gstruct7_0 != null;
							if (flag5)
							{
								for (int i = 0; i < array3[0].gstruct7_0.Length; i++)
								{
									bool flag6 = array3[0].gstruct7_0[i].int_0 == 1;
									if (flag6)
									{
										Class22.smethod_4(array3[0].gstruct7_0[i].uint_0, 13U);
										flag3 = true;
										break;
									}
								}
							}
						}
						num++;
						bool flag7 = num % 30 == 0 && Class22.smethod_52(Class97.process_0);
						if (flag7)
						{
							break;
						}
						bool flag8 = num > 450;
						if (flag8)
						{
							Class97.smethod_0("Không thể mở game, hãy kiểm tra lại file khác trong nút Login -> Thiết lập khác");
							return null;
						}
					}
					long long_ = Class12.smethod_27();
					for (;;)
					{
						bool flag9 = !Class12.bool_0;
						if (!flag9)
						{
							goto IL_230;
						}
						Thread.Sleep(100);
						bool flag10 = Class46.bool_0;
						if (flag10)
						{
							break;
						}
						long num2 = Class12.smethod_28(long_);
						bool flag11 = num2 <= (long)FormLogin.int_6;
						if (!flag11)
						{
							goto IL_22F;
						}
						Class46.int_2 = (int)((long)FormLogin.int_6 - num2);
					}
					return null;
					IL_22F:
					IL_230:
					int[] array4 = Class22.smethod_24(Class53.string_21, null, false);
					Process process = null;
					bool flag12 = array4 != null && array4.Length != 0;
					if (flag12)
					{
						bool flag13 = array != null && array.Length != 0;
						if (flag13)
						{
							foreach (int num3 in array4)
							{
								for (int k = 0; k < array.Length; k++)
								{
									bool flag14 = num3 == array[k];
									if (flag14)
									{
										num3 = 0;
										break;
									}
								}
								bool flag15 = num3 > 0;
								if (flag15)
								{
									process = Process.GetProcessById(num3);
									break;
								}
							}
						}
						else
						{
							process = Process.GetProcessById(array4[0]);
						}
					}
					new Thread(new ThreadStart(Class97.smethod_5)).Start();
					result = process;
				}
			}
			else
			{
				Class97.smethod_0("Hãy sửa lại file khác trong nút Login -> Thiết lập khác.");
				result = null;
			}
			return result;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000ED66C File Offset: 0x000EB86C
		private static void smethod_5()
		{
			Process process = Class97.process_0;
			Class97.process_0 = null;
			int num = 0;
			for (;;)
			{
				bool flag = num < 20;
				if (!flag)
				{
					goto IL_3D;
				}
				bool flag2 = !Class22.smethod_52(process);
				if (!flag2)
				{
					break;
				}
				Thread.Sleep(150);
				num++;
			}
			return;
			IL_3D:
			Class22.smethod_53(process);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x000ED6C4 File Offset: 0x000EB8C4
		public static Process smethod_6()
		{
			try
			{
				return Class97.smethod_7();
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x000ED6F8 File Offset: 0x000EB8F8
		private static Process smethod_7()
		{
			int num = 0;
			string text = Class97.string_0;
			bool flag = text == null || !(text != string.Empty) || !Class12.smethod_17(text);
			if (flag)
			{
				text = null;
				int[] array = Class22.smethod_24(Class53.string_21, null, false);
				bool flag2 = array != null && array.Length != 0;
				if (flag2)
				{
					num = array.Length;
					int i = 0;
					while (i < num)
					{
						try
						{
							Process processById = Process.GetProcessById(array[i]);
							text = processById.MainModule.FileName;
							string a = Class62.smethod_6("PathGame", 0, "");
							bool flag3 = text == null || !(text != string.Empty);
							if (!flag3)
							{
								bool flag4 = a != text;
								if (flag4)
								{
									Class62.smethod_10(Class53.string_3, "PathGame", text, "", 0);
									Class22.smethod_71(text, false);
								}
								break;
							}
						}
						catch
						{
						}
						IL_E6:
						i++;
						continue;
						goto IL_E6;
					}
				}
				bool flag5 = text == null || text == string.Empty;
				if (flag5)
				{
					num = 0;
					text = Class62.smethod_6("PathGame", 0, "");
					bool flag6 = text == null || text == string.Empty || !Class12.smethod_17(text);
					if (flag6)
					{
						Class97.smethod_0("Không thể mở game, vào tab Cài game xem lại thư mục game.");
						return null;
					}
				}
			}
			string[] array2 = Class12.smethod_14(text, '\\');
			string text2 = "KernelBase.dll";
			bool bool_ = Form1.bool_6;
			if (bool_)
			{
				text2 = "Kernel32.dll";
			}
			string text3 = "User32.dll";
			int num2 = 0;
			int num3 = 0;
			Process process = null;
			Process process2 = null;
			GStruct4 gstruct;
			for (;;)
			{
				gstruct = Class22.smethod_41(text, array2[0], false, Class97.string_1);
				bool flag7 = Class12.bool_0 || gstruct.uint_0 == 0U;
				if (flag7)
				{
					break;
				}
				int uint_ = (int)gstruct.uint_0;
				try
				{
					process2 = Process.GetProcessById(uint_);
				}
				catch
				{
				}
				bool flag8 = (Class97.bool_0 || num <= 2) && num <= Class97.int_0;
				if (!flag8)
				{
					goto IL_557;
				}
				uint num4 = 0U;
				uint num5 = 0U;
				int num6 = 0;
				while (!Class12.bool_0)
				{
					bool flag9 = num6 <= 500;
					if (!flag9)
					{
						goto IL_245;
					}
					bool flag10 = num5 == 0U;
					if (flag10)
					{
						num5 = Class22.smethod_37(uint_, text2);
					}
					bool flag11 = FormLogin.int_9 <= 0 && num5 > 0U;
					if (flag11)
					{
						break;
					}
					bool flag12 = num4 == 0U;
					if (flag12)
					{
						num4 = Class22.smethod_37(uint_, text3);
					}
					bool flag13 = num5 != 0U && num4 > 0U;
					if (flag13)
					{
						break;
					}
					Class22.smethod_44(gstruct);
					Thread.Sleep(1);
					Class22.smethod_42(gstruct);
					num6++;
				}
				uint num7 = 0U;
				uint num8 = 0U;
				num6 = 0;
				while (!Class12.bool_0)
				{
					bool flag14 = num6 <= 500;
					if (!flag14)
					{
						goto IL_2FA;
					}
					bool flag15 = num8 == 0U;
					if (flag15)
					{
						num8 = Class22.GetProcAddress(num5, "CreateMutexA");
					}
					bool flag16 = FormLogin.int_9 <= 0 && num8 > 0U;
					if (flag16)
					{
						break;
					}
					bool flag17 = num7 == 0U;
					if (flag17)
					{
						num7 = Class22.GetProcAddress(num4, "EnumWindows");
					}
					bool flag18 = num8 != 0U && num7 > 0U;
					if (flag18)
					{
						break;
					}
					Class22.smethod_44(gstruct);
					Thread.Sleep(1);
					Class22.smethod_42(gstruct);
					num6++;
				}
				int int_ = (int)gstruct.intptr_0;
				num6 = 0;
				int num9 = 0;
				byte[] array3 = new byte[1];
				while (!Class12.bool_0)
				{
					bool flag19 = num6 <= 500;
					if (!flag19)
					{
						Class97.smethod_0("Lỗi (3): Quá thời gian.");
						break;
					}
					Class22.ReadProcessMemory(int_, num8 + 5U, array3, 1, ref num9);
					bool flag20 = array3[0] != 0 && array3[0] != 204;
					if (flag20)
					{
						break;
					}
					Class22.smethod_44(gstruct);
					Thread.Sleep(1);
					Class22.smethod_42(gstruct);
					num6++;
				}
				uint num10 = Class22.smethod_1(int_, 598U, GEnum1.flag_2);
				uint num11 = num8 - (num10 + 42U) + 5U;
				uint value = num10 - num8 - 5U;
				string string_ = "3E 83 7C 24 0C 00 74 18 50 3E 8B 44 24 10 81 38 4D 75 74 65 75 09 3E C7 44 24 10 00 00 00 00 58 8B FF 55 8B ECE9" + Class12.smethod_45(num11, 8, false, true);
				array3 = Class12.smethod_8(string_, false);
				bool flag21 = Class22.WriteProcessMemory(int_, num10, array3, array3.Length, ref num9);
				bool flag22 = Class22.WriteProcessMemory(int_, num8, new byte[]
				{
					233
				}, 1, ref num9);
				array3 = BitConverter.GetBytes(value);
				bool flag23 = Class22.WriteProcessMemory(int_, num8 + 1U, array3, array3.Length, ref num9);
				num6 = 0;
				while (!Class12.bool_0 && FormLogin.int_9 > 0)
				{
					bool flag24 = num6 <= 500;
					if (!flag24)
					{
						Class97.smethod_0("Lỗi (4): Quá thời gian.");
						break;
					}
					Class22.ReadProcessMemory(int_, num7 + 2U, array3, 1, ref num9);
					bool flag25 = array3[0] == 85;
					if (flag25)
					{
						break;
					}
					Class22.smethod_44(gstruct);
					Thread.Sleep(1);
					Class22.smethod_42(gstruct);
					num6++;
				}
				bool flag26 = true;
				bool flag27 = FormLogin.int_9 > 0;
				if (flag27)
				{
					byte[] array4 = new byte[3];
					array4[0] = 194;
					array4[1] = 8;
					array3 = array4;
					flag26 = Class22.WriteProcessMemory(int_, num7, array3, array3.Length, ref num9);
				}
				Class22.smethod_44(gstruct);
				Class22.smethod_32(int_);
				bool flag28 = num3 == 0 && (!flag21 || !flag22 || !flag23 || !flag26);
				if (!flag28)
				{
					goto IL_554;
				}
				bool flag29 = num2 <= 0;
				if (!flag29)
				{
					goto IL_548;
				}
				process = process2;
				num2 = 1;
			}
			Class97.smethod_0("Không thể mở game, qua tab Cài đặt xem lại thư mục game có đúng không.");
			return null;
			IL_245:
			Class97.smethod_0("Lỗi (1): Quá thời gian.");
			goto IL_56F;
			IL_2FA:
			Class97.smethod_0("Lỗi (2): Quá thời gian.");
			goto IL_56F;
			IL_548:
			Class97.smethod_0("Không thể mở game, chú ý mở auto bằng run as administrators.");
			IL_554:
			goto IL_55F;
			IL_557:
			Class22.smethod_44(gstruct);
			IL_55F:
			IL_56F:
			bool flag30 = process != null;
			if (flag30)
			{
				Class22.smethod_53(process);
			}
			long long_ = Class12.smethod_27();
			while (!Class12.bool_0)
			{
				Thread.Sleep(100);
				bool flag31 = !Class46.bool_0;
				if (!flag31)
				{
					return null;
				}
				long num12 = Class12.smethod_28(long_);
				bool flag32 = num12 > (long)FormLogin.int_6;
				if (flag32)
				{
					break;
				}
				Class46.int_2 = (int)((long)FormLogin.int_6 - num12);
			}
			Class97.smethod_0("Đã mở " + (num + 1).ToString() + " cửa sổ game.");
			return process2;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000EDDC4 File Offset: 0x000EBFC4
		public static void smethod_8(string string_2)
		{
			bool flag = string_2 == null || string_2 == string.Empty;
			if (!flag)
			{
				string string_3 = string_2 + "\\UserData\\uicommon.ini";
				string text = Class12.smethod_33(string_3, 0, 0, 1);
				bool flag2 = text == string.Empty;
				if (flag2)
				{
					Class12.smethod_23(string_2 + "\\UserData");
					Class12.smethod_34(string_3, Class12.smethod_71("JYu7CgIxEAD7/ZoTvDKNWCoqAa8Qi7AuZuHcHPsQ7u+N2s3AzO20ODexO+xXKS/GAz+rpwEmKl5JO51JbSF0flO3jEoklygz+5o2sNPvIGSWxgGOYYzXMscvbSGPv2xHyLWpY3gm7xt8AA=="), 1);
				}
				else
				{
					string[] array = text.Split(new char[]
					{
						'\r',
						'\n'
					});
					text = string.Empty;
					for (int i = 0; i < array.Length; i++)
					{
						bool flag3 = array[i] == null || array[i] == string.Empty;
						if (!flag3)
						{
							string text2 = array[i];
							string text3 = text2.ToUpper();
							bool flag4 = text3.IndexOf("WEATHER") == 0;
							if (flag4)
							{
								text2 = "Weather=0";
							}
							else
							{
								bool flag5 = text3.IndexOf("MUSIC") == 0;
								if (flag5)
								{
									text2 = "MusicValue=0";
								}
								else
								{
									bool flag6 = text3.IndexOf("SOUND") != 0;
									if (flag6)
									{
										bool flag7 = text3.IndexOf("SHORTCUT") == 0;
										if (flag7)
										{
											text2 = "ShortcutSet=1";
										}
									}
									else
									{
										int num = text3.IndexOf("=");
										bool flag8 = num > 0;
										if (flag8)
										{
											num = Class12.smethod_11(text3.Substring(num + 1));
											bool flag9 = num > 50;
											if (flag9)
											{
												text2 = "SoundValue=50";
											}
										}
									}
								}
							}
							text = text + text2 + "\r\n";
						}
					}
					Class12.smethod_34(string_3, text, 1);
				}
			}
		}

		// Token: 0x04000410 RID: 1040
		private static int int_0 = 5;

		// Token: 0x04000411 RID: 1041
		public static bool bool_0 = false;

		// Token: 0x04000412 RID: 1042
		public static string string_0 = string.Empty;

		// Token: 0x04000413 RID: 1043
		public static string string_1 = null;

		// Token: 0x04000414 RID: 1044
		private static long long_0 = 0L;

		// Token: 0x04000415 RID: 1045
		private static Process process_0 = null;
	}
}
