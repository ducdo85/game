using System;
using System.Net;
using System.Net.Sockets;

namespace AutoKeoxe
{
	// Token: 0x02000046 RID: 70
	internal class Class72
	{
		// Token: 0x06000468 RID: 1128 RVA: 0x000C3B70 File Offset: 0x000C1D70
		public static string[] smethod_0()
		{
			string[] array = null;
			try
			{
				IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
				bool flag = addressList != null;
				if (flag)
				{
					for (int i = 0; i <= addressList.Length; i++)
					{
						bool flag2 = addressList[i].AddressFamily == AddressFamily.InterNetwork && (!addressList[i].ToString().Contains(":") & !addressList.ToString().Contains("%"));
						if (flag2)
						{
							bool flag3 = array != null;
							if (flag3)
							{
								Array.Resize<string>(ref array, array.Length + 1);
								array[array.Length - 1] = addressList[i].ToString();
							}
							else
							{
								array = new string[]
								{
									addressList[i].ToString()
								};
							}
						}
					}
				}
			}
			catch
			{
			}
			return array;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000C3C58 File Offset: 0x000C1E58
		private static string smethod_1(string string_3, int int_4 = 2)
		{
			bool flag = string_3 == null;
			if (flag)
			{
				string_3 = string.Empty;
			}
			while (string_3.Length < int_4)
			{
				string_3 = "0" + string_3;
			}
			return string_3;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000C3C98 File Offset: 0x000C1E98
		public static string smethod_2()
		{
			DateTime now = DateTime.Now;
			string text = Class72.smethod_1(now.Hour.ToString(), 2);
			string text2 = Class72.smethod_1(now.Minute.ToString(), 2);
			string text3 = Class72.smethod_1(now.Second.ToString(), 2);
			return string.Concat(new string[]
			{
				text,
				":",
				text2,
				":",
				text3
			});
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000C3D20 File Offset: 0x000C1F20
		private static string smethod_3(string[] string_3, int int_4, int int_5 = 0)
		{
			bool flag = (int_5 <= 0 || int_5 > int_4) && string_3 != null;
			if (flag)
			{
				bool flag2 = string_3.Length > int_4;
				if (flag2)
				{
					return string_3[int_4];
				}
			}
			return string.Empty;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000C3D68 File Offset: 0x000C1F68
		public static void smethod_4(string string_3)
		{
			Form1.int_7 = 0;
			Form1.int_6 = 1;
			bool flag = GClass1.long_1 != 0L && !FormMayphu.bool_1;
			if (flag)
			{
				bool flag2 = string_3 == null || string_3 == string.Empty;
				if (!flag2)
				{
					try
					{
						bool flag3 = string_3[0] == 'U' && string_3[1] == 'P' && string_3[2] == ':';
						if (flag3)
						{
							string text = string_3.Substring(3);
							int length = text.Length;
							bool flag4 = length % 2 > 0;
							if (flag4)
							{
								text = text.Substring(0, length - 1);
							}
							FormMayphu.smethod_1(text);
							Class72.bool_0 = true;
						}
						else
						{
							bool flag5 = Class72.bool_0;
							if (flag5)
							{
								Class72.bool_0 = false;
								Form1.bool_3 = true;
							}
							int num;
							int num2;
							for (;;)
							{
								num = string_3.IndexOf('@');
								num2 = string_3.IndexOf('*');
								bool flag6 = num2 >= num;
								if (flag6)
								{
									break;
								}
								string_3 = string_3.Substring(num);
							}
							bool flag7 = num < 0 || num2 < 0;
							if (!flag7)
							{
								string text2 = string_3.Substring(num, num2 + 1);
								string[] array = text2.Split(new char[]
								{
									'|'
								});
								int num3 = array.Length;
								bool flag8 = num3 < 44;
								if (!flag8)
								{
									bool flag9 = Class44.gstruct33_1.uint_4 == null;
									if (flag9)
									{
										Class44.gstruct33_1.uint_4 = new uint[2];
									}
									bool flag10 = Class44.gstruct33_1.int_11 == null;
									if (flag10)
									{
										Class44.gstruct33_1.int_11 = new int[4];
									}
									Form1.int_113 = 0;
									Class44.gstruct33_1.int_4 = Class12.smethod_11(Class72.smethod_3(array, 1, num3));
									Class44.gstruct33_1.int_3 = Class12.smethod_11(Class72.smethod_3(array, 2, num3));
									Class44.gstruct33_1.uint_4[0] = Class12.smethod_12(Class72.smethod_3(array, 3, num3));
									Class44.gstruct33_1.uint_4[1] = Class12.smethod_12(Class72.smethod_3(array, 4, num3));
									Class44.gstruct33_1.int_6 = Class12.smethod_11(Class72.smethod_3(array, 5, num3));
									Class44.gstruct33_1.uint_3 = Class12.smethod_12(Class72.smethod_3(array, 6, num3));
									Form1.int_115 = Class12.smethod_11(Class72.smethod_3(array, 7, num3));
									Form1.int_20 = Class12.smethod_11(Class72.smethod_3(array, 8, num3));
									Form1.int_106 = Class12.smethod_11(Class72.smethod_3(array, 9, num3));
									Form1.int_108 = Class12.smethod_11(Class72.smethod_3(array, 10, num3));
									Class18.int_0 = Class12.smethod_11(Class72.smethod_3(array, 11, num3));
									Form1.int_22 = Class12.smethod_11(Class72.smethod_3(array, 12, num3));
									Form1.int_30 = Class12.smethod_11(Class72.smethod_3(array, 13, num3));
									Form1.int_31 = Class12.smethod_11(Class72.smethod_3(array, 14, num3));
									Form1.int_32 = Class12.smethod_11(Class72.smethod_3(array, 15, num3));
									Class44.gstruct33_1.int_10 = Class12.smethod_11(Class72.smethod_3(array, 16, num3));
									Class44.gstruct33_1.int_2 = Class12.smethod_11(Class72.smethod_3(array, 17, num3));
									Form1.int_24 = Class12.smethod_11(Class72.smethod_3(array, 18, num3));
									Form1.int_88 = 1;
									Form1.int_89 = Class12.smethod_11(Class72.smethod_3(array, 20, num3));
									FormDame.int_6 = Class12.smethod_11(Class72.smethod_3(array, 21, num3));
									FormDame.int_9 = Class12.smethod_11(Class72.smethod_3(array, 22, num3));
									FormDame.int_11 = Class12.smethod_11(Class72.smethod_3(array, 23, num3));
									Class44.gstruct33_1.uint_5 = Class12.smethod_12(Class72.smethod_3(array, 24, num3));
									Class44.gstruct33_1.int_7 = Class12.smethod_11(Class72.smethod_3(array, 25, num3));
									Class44.gstruct33_1.uint_3 = Class12.smethod_12(Class72.smethod_3(array, 26, num3));
									Form1.int_33 = Class12.smethod_11(Class72.smethod_3(array, 27, num3));
									Form1.int_34 = Class12.smethod_11(Class72.smethod_3(array, 28, num3));
									Form1.int_21 = Class12.smethod_11(Class72.smethod_3(array, 29, num3));
									Class44.gstruct33_1.int_9 = Class12.smethod_11(Class72.smethod_3(array, 30, num3));
									Class44.gstruct33_1.uint_2 = Class12.smethod_12(Class72.smethod_3(array, 31, num3));
									Form1.int_90 = Class12.smethod_11(Class72.smethod_3(array, 32, num3));
									Class44.gstruct33_1.int_8 = Class12.smethod_11(Class72.smethod_3(array, 33, num3));
									Class44.gstruct33_0.int_8 = Class12.smethod_11(Class72.smethod_3(array, 34, num3));
									Form1.int_44[0] = Class12.smethod_11(Class72.smethod_3(array, 35, num3));
									Form1.int_44[1] = Class12.smethod_11(Class72.smethod_3(array, 36, num3));
									Form1.int_0 = Class12.smethod_11(Class72.smethod_3(array, 37, num3));
									Class35.int_1 = Class12.smethod_11(Class72.smethod_3(array, 38, num3));
									Form1.int_105 = Class12.smethod_11(Class72.smethod_3(array, 39, num3));
									Form1.int_109 = Class12.smethod_11(Class72.smethod_3(array, 40, num3));
									Form1.int_83 = Class12.smethod_11(Class72.smethod_3(array, 41, num3));
									Form1.int_75 = Class12.smethod_11(Class72.smethod_3(array, 42, num3));
									Form1.int_114 = Class12.smethod_11(Class72.smethod_3(array, 43, num3));
									bool flag11 = num3 <= 44;
									if (!flag11)
									{
										int num4 = Class12.smethod_11(Class72.smethod_3(array, 44, num3));
										bool flag12 = num4 <= 0 || Form1.gstruct49_0 == null;
										if (!flag12)
										{
											for (int i = 0; i < Form1.gstruct49_0.Length; i++)
											{
												bool flag13 = num4 == 1 && Form1.gstruct49_0[i].bool_25;
												if (flag13)
												{
													Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 1, 4);
												}
												else
												{
													Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 0, 4);
												}
											}
										}
									}
								}
							}
						}
					}
					catch
					{
					}
				}
			}
			else
			{
				Class44.gstruct33_1.int_4 = 0;
				Class44.gstruct33_1.int_0 = 0;
				Class44.gstruct33_1.int_6 = 0;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000C43C8 File Offset: 0x000C25C8
		public static string smethod_5()
		{
			Form1.int_6 = 0;
			uint num = 0U;
			uint num2 = 0U;
			int int_ = Class44.gstruct33_0.int_4;
			bool flag = Class44.gstruct33_0.uint_4 != null;
			if (flag)
			{
				num = Class44.gstruct33_0.uint_4[0];
				num2 = Class44.gstruct33_0.uint_4[1];
			}
			bool flag2 = num != 0U && num2 != 0U && int_ > 0;
			string result;
			if (flag2)
			{
				string text = "0";
				bool flag3 = Class56.int_0 > 0;
				if (flag3)
				{
					bool flag4 = Class12.smethod_28(Class56.long_0) < 1500L;
					if (flag4)
					{
						text = Class56.int_0.ToString();
					}
					else
					{
						Class56.int_0 = 0;
					}
				}
				string text2 = string.Concat(new string[]
				{
					"@|",
					int_.ToString(),
					"|",
					Class44.gstruct33_0.int_3.ToString(),
					"|",
					num.ToString(),
					"|",
					num2.ToString(),
					"|",
					Class44.gstruct33_0.int_6.ToString(),
					"|",
					Class44.gstruct33_0.uint_3.ToString(),
					"|",
					Form1.int_115.ToString(),
					"|",
					Form1.int_20.ToString(),
					"|",
					Form1.int_106.ToString(),
					"|",
					Form1.int_108.ToString(),
					"|",
					Class18.int_0.ToString(),
					"|",
					Form1.int_22.ToString(),
					"|",
					Form1.int_30.ToString(),
					"|",
					Form1.int_31.ToString(),
					"|",
					Form1.int_32.ToString(),
					"|",
					Form1.int_25.ToString(),
					"|",
					Class44.gstruct33_0.int_2.ToString(),
					"|",
					Form1.int_24.ToString(),
					"|",
					Form1.int_88.ToString(),
					"|",
					Form1.int_89.ToString(),
					"|",
					FormDame.int_6.ToString(),
					"|",
					FormDame.int_9.ToString(),
					"|",
					FormDame.int_11.ToString(),
					"|",
					Class44.gstruct33_0.uint_5.ToString(),
					"|",
					Class44.gstruct33_0.int_7.ToString(),
					"|",
					Class44.gstruct33_0.uint_3.ToString(),
					"|",
					Form1.int_33.ToString(),
					"|",
					Form1.int_34.ToString(),
					"|",
					Form1.int_21.ToString(),
					"|",
					Class44.gstruct33_0.int_9.ToString(),
					"|",
					Class44.gstruct33_0.uint_2.ToString(),
					"|",
					Form1.int_90.ToString(),
					"|",
					Class44.gstruct33_0.int_8.ToString(),
					"|",
					Class44.gstruct33_0.int_8.ToString(),
					"|",
					Form1.int_44[0].ToString(),
					"|",
					Form1.int_44[1].ToString(),
					"|",
					Form1.int_0.ToString(),
					"|",
					Class35.int_1.ToString(),
					"|",
					Form1.int_105.ToString(),
					"|",
					Form1.int_109.ToString(),
					"|",
					Form1.int_83.ToString(),
					"|",
					Form1.int_75.ToString(),
					"|",
					Form1.int_114.ToString(),
					"|",
					text,
					"|*"
				});
				Class44.gstruct33_0.int_9 = 0;
				result = text2;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0400038A RID: 906
		public static Class73 class73_0 = null;

		// Token: 0x0400038B RID: 907
		public static Class74 class74_0 = null;

		// Token: 0x0400038C RID: 908
		public static long long_0 = 0L;

		// Token: 0x0400038D RID: 909
		public static int int_0 = 0;

		// Token: 0x0400038E RID: 910
		public static int int_1 = Class62.smethod_3("KieuConnect", 0, "0");

		// Token: 0x0400038F RID: 911
		public static string string_0 = null;

		// Token: 0x04000390 RID: 912
		public static int int_2 = Class62.smethod_3("PortServer", 0, "0");

		// Token: 0x04000391 RID: 913
		public static string string_1 = string.Empty;

		// Token: 0x04000392 RID: 914
		public static int int_3 = Class62.smethod_3("nPort", 0, "0");

		// Token: 0x04000393 RID: 915
		public static string string_2 = Class62.smethod_6("ConnectIP", 0, "");

		// Token: 0x04000394 RID: 916
		private static bool bool_0 = false;
	}
}
