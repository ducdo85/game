using System;
using Microsoft.Win32;

namespace AutoKeoxe
{
	// Token: 0x0200003C RID: 60
	internal class Class62
	{
		// Token: 0x06000370 RID: 880 RVA: 0x000A5E78 File Offset: 0x000A4078
		public static string smethod_0()
		{
			try
			{
				string name = "HTTP\\shell\\open\\command";
				using (RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(name, false))
				{
					return ((string)registryKey.GetValue(null, null)).Split(new char[]
					{
						'"'
					})[1];
				}
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000A5EF4 File Offset: 0x000A40F4
		public static string smethod_1(string string_1, string string_2, byte byte_0 = 0, string string_3 = "")
		{
			string text = string.Empty;
			try
			{
				RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.OpenSubKey(string_1) : Registry.LocalMachine.OpenSubKey(string_1);
				string_2 = string_2.ToUpper();
				string[] valueNames = registryKey.GetValueNames();
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					bool flag = text2.ToUpper() == string_2;
					if (flag)
					{
						text = registryKey.GetValue(text2).ToString();
						break;
					}
				}
				bool flag2 = text == string.Empty;
				if (flag2)
				{
					text = string_3;
				}
				registryKey.Close();
			}
			catch
			{
				text = string_3;
				Class62.smethod_11(string_1, byte_0);
			}
			return text;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		public static string smethod_2(string string_1, byte byte_0 = 0, string string_2 = "")
		{
			string text = string.Empty;
			try
			{
				bool flag = byte_0 == 0;
				RegistryKey registryKey;
				if (flag)
				{
					bool flag2 = Class62.registryKey_0 == null;
					if (flag2)
					{
						Class62.registryKey_0 = Registry.LocalMachine.OpenSubKey(Class53.string_3);
					}
					registryKey = Class62.registryKey_0;
				}
				else
				{
					bool flag3 = Class62.registryKey_1 == null;
					if (flag3)
					{
						Class62.registryKey_1 = Registry.CurrentUser.OpenSubKey(Class53.string_3);
					}
					registryKey = Class62.registryKey_1;
				}
				string_1 = string_1.ToUpper();
				string[] valueNames = registryKey.GetValueNames();
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					bool flag4 = text2.ToUpper() == string_1;
					if (flag4)
					{
						text = registryKey.GetValue(text2).ToString();
						break;
					}
				}
				bool flag5 = text == string.Empty;
				if (flag5)
				{
					text = string_2;
				}
			}
			catch
			{
				text = string_2;
				Class62.smethod_11(Class53.string_3, byte_0);
				Class62.registryKey_0 = null;
				Class62.registryKey_1 = null;
			}
			return text;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000A60D8 File Offset: 0x000A42D8
		public static int smethod_3(string string_1, byte byte_0 = 0, string string_2 = "")
		{
			int result = 0;
			string text = Class62.smethod_2(string_1, byte_0, string_2);
			bool flag = text != null;
			if (flag)
			{
				bool flag2 = text != string.Empty;
				if (flag2)
				{
					try
					{
						result = Convert.ToInt32(text);
					}
					catch
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000A6144 File Offset: 0x000A4344
		public static uint smethod_4(string string_1, byte byte_0 = 0, string string_2 = "")
		{
			uint result = 0U;
			string text = Class62.smethod_2(string_1, byte_0, string_2);
			bool flag = text != null && text != string.Empty;
			if (flag)
			{
				try
				{
					result = Convert.ToUInt32(text);
				}
				catch
				{
					result = 0U;
				}
			}
			return result;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000A619C File Offset: 0x000A439C
		public static long smethod_5(string string_1, byte byte_0 = 0, string string_2 = "")
		{
			long result = 0L;
			string text = Class62.smethod_2(string_1, byte_0, string_2);
			bool flag = text != null && text != string.Empty;
			if (flag)
			{
				try
				{
					result = Convert.ToInt64(text);
				}
				catch
				{
					result = 0L;
				}
			}
			return result;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000A61F4 File Offset: 0x000A43F4
		public static string smethod_6(string string_1, byte byte_0 = 0, string string_2 = "")
		{
			return Class62.smethod_2(string_1, byte_0, string_2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000A6210 File Offset: 0x000A4410
		public static string smethod_7(string string_1, string string_2, byte byte_0 = 0, string string_3 = "")
		{
			string text = string.Empty;
			try
			{
				string_2 = string_2.ToUpper();
				RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.OpenSubKey(string_1) : Registry.LocalMachine.OpenSubKey(string_1);
				string[] valueNames = registryKey.GetValueNames();
				string[] array = valueNames;
				foreach (string text2 in array)
				{
					bool flag = text2.ToUpper() == string_2;
					if (flag)
					{
						object value = registryKey.GetValue(text2);
						bool flag2 = Class12.smethod_1(value.ToString().ToUpper(), "STRING[]") > 0;
						if (flag2)
						{
							string[] array3 = (string[])value;
							text = array3[0];
						}
						else
						{
							text = value.ToString();
						}
						break;
					}
				}
				bool flag3 = text == "";
				if (flag3)
				{
					text = string_3;
				}
				registryKey.Close();
			}
			catch
			{
				text = string_3;
				Class62.smethod_11(string_1, byte_0);
			}
			return text;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000A6310 File Offset: 0x000A4510
		public static string[] smethod_8(string string_1, bool bool_0 = false)
		{
			try
			{
				RegistryKey registryKey = (!bool_0) ? Registry.LocalMachine.OpenSubKey(string_1, true) : Registry.CurrentUser.OpenSubKey(string_1, true);
				bool flag = registryKey != null;
				if (flag)
				{
					string[] subKeyNames = registryKey.GetSubKeyNames();
					registryKey.Close();
					return subKeyNames;
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000A6378 File Offset: 0x000A4578
		public static string[] smethod_9(string string_1, bool bool_0 = false, bool bool_1 = false, int int_0 = 0)
		{
			try
			{
				RegistryKey registryKey = (!bool_0) ? Registry.LocalMachine.OpenSubKey(string_1, true) : Registry.CurrentUser.OpenSubKey(string_1, true);
				bool flag = registryKey != null;
				if (flag)
				{
					string[] array = null;
					bool flag2 = int_0 > 0;
					if (flag2)
					{
						bool flag3 = int_0 != 1;
						if (flag3)
						{
							array = registryKey.GetValueNames();
							bool flag4 = array == null || array.Length == 0;
							if (flag4)
							{
								array = registryKey.GetSubKeyNames();
							}
							else
							{
								string[] subKeyNames = registryKey.GetSubKeyNames();
								bool flag5 = subKeyNames != null;
								if (flag5)
								{
									int num = array.Length;
									Array.Resize<string>(ref array, num + subKeyNames.Length);
									for (int i = 0; i < subKeyNames.Length; i++)
									{
										array[num + i] = subKeyNames[i];
									}
								}
							}
						}
						else
						{
							array = registryKey.GetSubKeyNames();
						}
					}
					else
					{
						array = registryKey.GetValueNames();
					}
					bool flag6 = bool_1 && array != null;
					if (flag6)
					{
						for (int j = 0; j < array.Length; j++)
						{
							array[j] = registryKey.Name + "\\" + array[j];
						}
					}
					registryKey.Close();
					return array;
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000A64D0 File Offset: 0x000A46D0
		public static bool smethod_10(string string_1, string string_2, object object_0, string string_3 = "", byte byte_0 = 0)
		{
			try
			{
				RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.CreateSubKey(string_1) : Registry.LocalMachine.CreateSubKey(string_1);
				bool flag = registryKey != null;
				if (flag)
				{
					bool flag2 = object_0 == null;
					if (flag2)
					{
						registryKey.SetValue(string_2, string.Empty, Class62.smethod_13(string_3));
					}
					else
					{
						registryKey.SetValue(string_2, object_0, Class62.smethod_13(string_3));
					}
					registryKey.Close();
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000A655C File Offset: 0x000A475C
		private static void smethod_11(string string_1, byte byte_0 = 0)
		{
			try
			{
				bool flag = byte_0 == 0;
				if (flag)
				{
					Registry.LocalMachine.CreateSubKey(string_1);
				}
				else
				{
					Registry.CurrentUser.CreateSubKey(string_1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000A65A8 File Offset: 0x000A47A8
		public static void smethod_12(string string_1, string string_2, byte byte_0 = 0)
		{
			try
			{
				bool flag = byte_0 == 3;
				if (flag)
				{
					bool flag2 = string_1.IndexOf("HKEY_LOCAL_MACHINE\\") == 0;
					if (flag2)
					{
						byte_0 = 0;
						string_1 = string_1.Replace("HKEY_LOCAL_MACHINE\\", string.Empty);
					}
					else
					{
						bool flag3 = string_1.IndexOf("HKEY_CURRENT_USER\\") == 0;
						if (flag3)
						{
							byte_0 = 2;
							string_1 = string_1.Replace("HKEY_CURRENT_USER\\", string.Empty);
						}
					}
				}
				RegistryKey registryKey = (byte_0 != 0) ? Registry.CurrentUser.OpenSubKey(string_1, true) : Registry.LocalMachine.OpenSubKey(string_1, true);
				bool flag4 = registryKey != null;
				if (flag4)
				{
					registryKey.DeleteValue(string_2);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000A6668 File Offset: 0x000A4868
		private static RegistryValueKind smethod_13(string string_1 = "")
		{
			RegistryValueKind result = RegistryValueKind.String;
			string_1 = string_1.ToUpper();
			bool flag = !(string_1 == "DWORD");
			if (flag)
			{
				bool flag2 = string_1 == "BINARY";
				if (flag2)
				{
					result = RegistryValueKind.Binary;
				}
			}
			else
			{
				result = RegistryValueKind.DWord;
			}
			return result;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000A66B0 File Offset: 0x000A48B0
		public static void smethod_14(string string_1)
		{
			try
			{
				for (int i = 0; i < 10; i++)
				{
					int num = Class22.smethod_54("Regedit");
					bool flag = num == 0;
					if (flag)
					{
						break;
					}
					Class22.smethod_48(num);
				}
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Applets\\Regedit", "LastKey", string_1);
				Class22.smethod_40("regedit.exe", "", "", 0, false, false);
			}
			catch
			{
			}
		}

		// Token: 0x040002E3 RID: 739
		private static RegistryKey registryKey_0 = null;

		// Token: 0x040002E4 RID: 740
		private static RegistryKey registryKey_1 = null;

		// Token: 0x040002E5 RID: 741
		public static string string_0 = Class12.smethod_15("U29mdHdhcmVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcRXhwbG9yZXJcRGlzYWxsb3dSdW4=");
	}
}
