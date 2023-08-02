using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200000A RID: 10
	internal class Class12
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00009450 File Offset: 0x00007650
		public static string smethod_0(char[] char_41)
		{
			bool flag = char_41 == null;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string text = string.Concat<char>(char_41);
				bool flag2 = char_41[0] > 'ᎇ';
				if (flag2)
				{
					text = Class12.smethod_53(text);
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00009490 File Offset: 0x00007690
		public static int smethod_1(string string_17, object object_0)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty) && object_0 != null;
			int result;
			if (flag)
			{
				string text = object_0.ToString();
				bool flag2 = !(text == string.Empty);
				if (flag2)
				{
					int num = string_17.IndexOf(text);
					bool flag3 = 0 > num;
					if (flag3)
					{
						char[] array = string_17.ToCharArray();
						char[] array2 = text.ToCharArray();
						int num2 = array.Length;
						int num3 = array2.Length;
						int num4 = 0;
						for (;;)
						{
							bool flag4 = num4 < num2;
							if (!flag4)
							{
								goto IL_110;
							}
							bool flag5 = num2 - num4 < num3;
							if (flag5)
							{
								break;
							}
							bool flag6 = array[num4] == array2[0];
							if (flag6)
							{
								bool flag7 = num3 == 1;
								if (flag7)
								{
									goto Block_9;
								}
								bool flag8 = true;
								for (int i = 1; i < num3; i++)
								{
									bool flag9 = array2[i] != array[num4 + i];
									if (flag9)
									{
										flag8 = false;
										break;
									}
								}
								bool flag10 = flag8;
								if (flag10)
								{
									goto Block_11;
								}
							}
							num4++;
						}
						return -1;
						Block_9:
						return num4;
						Block_11:
						return num4;
						IL_110:
						result = -1;
					}
					else
					{
						result = num;
					}
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

		// Token: 0x0600002F RID: 47 RVA: 0x000095D0 File Offset: 0x000077D0
		public static bool smethod_2(string string_17, string string_18, bool bool_1 = false)
		{
			bool flag = string_17 == null || string_18 == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = string_17 == string_18;
				if (flag2)
				{
					result = true;
				}
				else
				{
					string text = Class10.smethod_1(string_17, 1, false).ToUpper();
					string text2 = Class10.smethod_1(string_18, 1, false).ToUpper();
					bool flag3 = text == text2 || text == text2.Replace("*", "");
					if (flag3)
					{
						result = true;
					}
					else if (bool_1)
					{
						result = (text == text2 || text == string_18 || string_17 == text2 || text == string_18.ToUpper() || string_17.ToUpper() == text2);
					}
					else
					{
						result = (0 <= Class12.smethod_1(string_17, string_18.Replace("*", "")) || 0 <= Class12.smethod_1(text, text2.Replace("*", "")) || 0 <= Class12.smethod_1(string_17.ToUpper(), text2.Replace("*", "")) || 0 <= Class12.smethod_1(text, string_18.ToUpper()) || 0 <= Class12.smethod_1(string_17.ToUpper(), text2));
					}
				}
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000970C File Offset: 0x0000790C
		public static string[] smethod_3(string[] string_17, bool bool_1, bool bool_2 = false)
		{
			bool flag = string_17 == null || string_17.Length == 0;
			string[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				for (int i = 0; i < string_17.Length; i++)
				{
					bool flag2 = string_17[i] == null;
					if (flag2)
					{
						string_17[i] = string.Empty;
					}
					else
					{
						if (bool_1)
						{
							string_17[i] = string_17[i].Replace(" ", string.Empty).Replace("Ù", string.Empty);
						}
						else
						{
							string_17[i] = string_17[i].Trim();
						}
						if (bool_2)
						{
							string_17[i] = string_17[i].ToLower();
						}
					}
				}
				result = string_17;
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000097A8 File Offset: 0x000079A8
		public static bool smethod_4(string string_17, byte[] byte_0)
		{
			try
			{
				FileStream fileStream = new FileStream(string_17, FileMode.Create, FileAccess.Write);
				fileStream.Write(byte_0, 0, byte_0.Length);
				fileStream.Close();
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000097F4 File Offset: 0x000079F4
		public static uint smethod_5(uint[] uint_2, uint[] uint_3)
		{
			bool flag = uint_2 != null && uint_3 != null && uint_2[0] != 0U && uint_2[1] != 0U && uint_3[0] != 0U && uint_3[1] > 0U;
			uint result;
			if (flag)
			{
				long num = (long)(uint_2[0] - uint_3[0]);
				long num2 = (long)(uint_2[1] - uint_3[1]);
				long num3 = num * num + num2 * num2;
				bool flag2 = num3 == 0L;
				if (flag2)
				{
					num3 = 1L;
				}
				result = (uint)num3;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000985C File Offset: 0x00007A5C
		public static uint smethod_6(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num = 0U;
				char[] array = string_17.ToCharArray();
				uint num2 = 0U;
				while ((ulong)num2 < (ulong)((long)array.Length))
				{
					uint num3 = (uint)((byte)array[(int)num2]);
					bool flag2 = num3 > 127U;
					if (flag2)
					{
						num3 = 4294967040U + num3;
					}
					uint num4 = num2 + 1U;
					num4 *= num3;
					num4 += num;
					num = 2147483659U;
					num3 = num4 % num;
					num4 = num3;
					num4 = (uint)(Math.Abs((long)((ulong)num4)) * -1L);
					num4 <<= 4;
					num4 -= num3;
					num = num4;
					num2 += 1U;
				}
				result = (num ^ 305419896U);
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00009914 File Offset: 0x00007B14
		public static string smethod_7(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty || !Class12.smethod_17(string_17);
			string empty;
			if (flag)
			{
				empty = string.Empty;
			}
			else
			{
				try
				{
					using (MD5 md = MD5.Create())
					{
						using (FileStream fileStream = File.OpenRead(string_17))
						{
							return BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", string.Empty).ToLower();
						}
					}
				}
				catch
				{
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000099C8 File Offset: 0x00007BC8
		public static byte[] smethod_8(string string_17, bool bool_1 = true)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			byte[] result;
			if (flag)
			{
				string_17 = string_17.Replace(" ", "");
				bool flag2 = string_17.Length % 2 == 0 && !(string_17 == "");
				if (flag2)
				{
					int num = string_17.Length / 2;
					byte[] array = new byte[num];
					for (int i = 0; i < array.Length; i++)
					{
						string text = string_17.Substring(i * 2, 2);
						bool flag3 = !bool_1 || !(text == "??");
						if (flag3)
						{
							array[i] = byte.Parse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
						}
						else
						{
							array[i] = 63;
						}
					}
					result = array;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00009AA4 File Offset: 0x00007CA4
		public static int smethod_9(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int num = 0;
				for (int i = 0; i < string_17.Length; i++)
				{
					bool flag2 = string_17[i] >= '0' && string_17[i] <= '9';
					if (!flag2)
					{
						return -1;
					}
					bool flag3 = string_17[i] != '0' || num > 0;
					if (flag3)
					{
						num++;
					}
				}
				bool flag4 = num > 0;
				if (flag4)
				{
					num = Class12.smethod_11(string_17);
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00009B40 File Offset: 0x00007D40
		public static int smethod_10(string string_17, bool bool_1 = false, bool bool_2 = false)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			int result;
			if (flag)
			{
				bool flag2 = false;
				string text = "0";
				for (int i = 0; i < string_17.Length; i++)
				{
					bool flag3 = '0' <= string_17[i] && string_17[i] <= '9';
					if (flag3)
					{
						text += string_17[i].ToString();
						flag2 = true;
					}
					else
					{
						bool flag4 = flag2 && !bool_2;
						if (flag4)
						{
							break;
						}
					}
				}
				result = Class12.smethod_11(text);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00009BEC File Offset: 0x00007DEC
		public static int smethod_11(string string_17)
		{
			int result = 0;
			bool flag = string_17 != null && string_17 != "";
			if (flag)
			{
				try
				{
					result = Convert.ToInt32(string_17);
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00009C38 File Offset: 0x00007E38
		public static uint smethod_12(string string_17)
		{
			uint result = 0U;
			bool flag = string_17 != null;
			if (flag)
			{
				bool flag2 = string_17 != string.Empty;
				if (flag2)
				{
					try
					{
						result = Convert.ToUInt32(string_17);
					}
					catch
					{
						result = 0U;
					}
				}
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00009C98 File Offset: 0x00007E98
		public static void smethod_13(ref string string_17, string string_18, string string_19 = "")
		{
			bool flag = string_19 == "";
			if (flag)
			{
				string_19 = Class53.string_7;
			}
			bool flag2 = string_17 != "";
			if (flag2)
			{
				string_17 += string_19;
			}
			string_17 += string_18;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00009CE0 File Offset: 0x00007EE0
		public static string[] smethod_14(string string_17, char char_41 = '\\')
		{
			string[] array = new string[]
			{
				string.Empty,
				string.Empty
			};
			bool flag = string_17 != null && string_17 != string.Empty;
			if (flag)
			{
				string[] array2 = string_17.Split(new char[]
				{
					char_41
				});
				array[1] = array2[array2.Length - 1];
				for (int i = 0; i < array2.Length - 1; i++)
				{
					bool flag2 = array[0] != string.Empty;
					string[] array3;
					if (flag2)
					{
						(array3 = array)[0] = array3[0] + char_41.ToString();
					}
					(array3 = array)[0] = array3[0] + array2[i];
				}
			}
			return array;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00009D94 File Offset: 0x00007F94
		public static string smethod_15(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty;
			string empty;
			if (flag)
			{
				empty = string.Empty;
			}
			else
			{
				try
				{
					byte[] array = Convert.FromBase64String(string_17);
					return Encoding.UTF8.GetString(array, 0, array.Length);
				}
				catch
				{
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00009DF8 File Offset: 0x00007FF8
		public static string smethod_16(string string_17)
		{
			bool flag = string_17 == null;
			if (!flag)
			{
				bool flag2 = string_17 == string.Empty;
				if (!flag2)
				{
					try
					{
						byte[] bytes = Encoding.UTF8.GetBytes(string_17);
						return Convert.ToBase64String(bytes);
					}
					catch
					{
					}
					return string.Empty;
				}
			}
			return string.Empty;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009E68 File Offset: 0x00008068
		public static bool smethod_17(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				try
				{
					return File.Exists(string_17);
				}
				catch
				{
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00009EB4 File Offset: 0x000080B4
		public static string[] smethod_18(string string_17, string string_18 = "*.*", SearchOption searchOption_0 = SearchOption.AllDirectories)
		{
			try
			{
				return Directory.GetFiles(string_17, string_18, searchOption_0);
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00009EE8 File Offset: 0x000080E8
		public static bool smethod_19(string string_17, string string_18)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty) && string_18 != null;
			if (flag)
			{
				bool flag2 = string_18 == string.Empty;
				if (!flag2)
				{
					try
					{
						File.Move(string_17, string_18);
						return true;
					}
					catch
					{
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009F58 File Offset: 0x00008158
		public static bool smethod_20(string string_17)
		{
			try
			{
				bool flag = File.Exists(string_17);
				if (flag)
				{
					File.Delete(string_17);
				}
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00009F98 File Offset: 0x00008198
		public static bool smethod_21(string string_17, FileAttributes fileAttributes_0)
		{
			try
			{
				bool flag = File.Exists(string_17);
				if (flag)
				{
					File.SetAttributes(string_17, File.GetAttributes(string_17) | fileAttributes_0);
				}
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009FE0 File Offset: 0x000081E0
		public static int smethod_22(string string_17, string string_18)
		{
			bool flag = !File.Exists(string_17);
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				bool flag2 = File.Exists(string_18) && !Class12.smethod_20(string_18);
				if (flag2)
				{
					Random random = new Random();
					try
					{
						File.Move(string_18, string_18 + "." + random.Next(10000, int.MaxValue).ToString());
					}
					catch
					{
						return -2;
					}
				}
				try
				{
					File.Copy(string_17, string_18, true);
					return 1;
				}
				catch
				{
				}
				result = -3;
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000A08C File Offset: 0x0000828C
		public static void smethod_23(string string_17)
		{
			bool flag = !File.Exists(string_17);
			if (flag)
			{
				try
				{
					Directory.CreateDirectory(string_17);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A0C8 File Offset: 0x000082C8
		public static string[] smethod_24(string string_17, string string_18 = "*.*", SearchOption searchOption_0 = SearchOption.AllDirectories)
		{
			try
			{
				return Directory.GetDirectories(string_17, string_18, searchOption_0);
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A0FC File Offset: 0x000082FC
		public static bool smethod_25(string string_17)
		{
			try
			{
				bool flag = Directory.Exists(string_17);
				if (flag)
				{
					Directory.Delete(string_17, true);
				}
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000A13C File Offset: 0x0000833C
		public static void smethod_26(string string_17)
		{
			string[] array = Class12.smethod_18(string_17, "*.*", SearchOption.AllDirectories);
			bool flag = array != null && array.Length != 0;
			if (flag)
			{
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_20(array[i]);
				}
			}
			array = Class12.smethod_24(string_17, "*.*", SearchOption.AllDirectories);
			bool flag2 = array != null && array.Length != 0;
			if (flag2)
			{
				int num = array.Length;
				for (int j = 0; j < num; j++)
				{
					Class12.smethod_25(array[num - j - 1]);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000A1D4 File Offset: 0x000083D4
		public static long smethod_27()
		{
			return DateTime.Now.Ticks;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public static long smethod_28(long long_1)
		{
			TimeSpan timeSpan = new TimeSpan(DateTime.Now.Ticks - long_1);
			return (long)timeSpan.TotalMilliseconds;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000A224 File Offset: 0x00008424
		public static void smethod_29(ref string[] string_17, string string_18)
		{
			bool flag = string_17 == null;
			if (flag)
			{
				string_17 = new string[]
				{
					string_18
				};
			}
			else
			{
				try
				{
					string[] array = new string[string_17.Length + 1];
					for (int i = 0; i < string_17.Length; i++)
					{
						bool flag2 = !(string_17[i] == string_18);
						if (!flag2)
						{
							return;
						}
						array[i] = string_17[i];
					}
					array[array.Length - 1] = string_18;
					string_17 = array;
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000A2B0 File Offset: 0x000084B0
		public static void smethod_30(ref string[] string_17, string string_18, bool bool_1 = false)
		{
			bool flag = string_17 != null && string_17.Length != 0;
			if (flag)
			{
				int num = 0;
				bool flag2 = false;
				for (int i = 0; i < string_17.Length; i++)
				{
					bool flag3 = string_17[i] != string_18 || flag2;
					if (flag3)
					{
						string_17[num] = string_17[i];
						num++;
					}
					else if (bool_1)
					{
						flag2 = true;
					}
				}
				bool flag4 = num == 0;
				if (flag4)
				{
					string_17 = null;
				}
				else
				{
					bool flag5 = num < string_17.Length;
					if (flag5)
					{
						Array.Resize<string>(ref string_17, num);
					}
				}
			}
			else
			{
				string_17 = null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000A344 File Offset: 0x00008544
		public static int smethod_31(string[] string_17, string string_18, bool bool_1 = false)
		{
			bool flag = string_17 != null;
			if (flag)
			{
				for (int i = 0; i < string_17.Length; i++)
				{
					bool flag2 = string_18 == string_17[i] || (!bool_1 && (0 <= Class12.smethod_1(string_17[i], string_18) || 0 <= Class12.smethod_1(string_18, string_17[i])));
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000A3B4 File Offset: 0x000085B4
		public static bool smethod_32(string string_17)
		{
			bool flag = false;
			bool result;
			try
			{
				FileAttributes attributes = File.GetAttributes(string_17);
				flag = ((attributes & FileAttributes.Directory) == FileAttributes.Directory);
				result = flag;
			}
			catch
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public static string smethod_33(string string_17, int int_2 = 0, int int_3 = 0, byte byte_0 = 1)
		{
			bool flag = string_17 != null && !(string_17 == "") && File.Exists(string_17);
			string result;
			if (flag)
			{
				string text = "";
				try
				{
					switch (byte_0)
					{
					case 1:
						text = File.ReadAllText(string_17);
						break;
					case 2:
						text = File.ReadAllText(string_17, Encoding.ASCII);
						break;
					case 3:
						text = File.ReadAllText(string_17, Encoding.UTF7);
						break;
					case 4:
						text = File.ReadAllText(string_17, Encoding.UTF8);
						break;
					case 5:
						text = File.ReadAllText(string_17, Encoding.UTF32);
						break;
					case 6:
						text = File.ReadAllText(string_17, Encoding.Unicode);
						break;
					default:
						text = File.ReadAllText(string_17, Encoding.Default);
						break;
					}
					bool flag2 = int_2 > 0;
					if (flag2)
					{
						text = text.Replace(" ", "");
					}
					bool flag3 = int_3 > 0;
					if (flag3)
					{
						text = text.Replace("\n", "");
					}
				}
				catch
				{
					text = "";
				}
				result = text;
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000A510 File Offset: 0x00008710
		public static void smethod_34(string string_17, string string_18, byte byte_0 = 1)
		{
			bool flag = string_17 == null || string_17 == "";
			if (!flag)
			{
				bool flag2 = string_18 == null;
				if (flag2)
				{
					string_18 = "";
				}
				try
				{
					switch (byte_0)
					{
					case 1:
						File.WriteAllText(string_17, string_18);
						break;
					case 2:
						File.WriteAllText(string_17, string_18, Encoding.ASCII);
						break;
					case 3:
						File.WriteAllText(string_17, string_18, Encoding.UTF7);
						break;
					case 4:
						File.WriteAllText(string_17, string_18, Encoding.UTF8);
						break;
					case 5:
						File.WriteAllText(string_17, string_18, Encoding.UTF32);
						break;
					case 6:
						File.WriteAllText(string_17, string_18, Encoding.Unicode);
						break;
					default:
						File.WriteAllText(string_17, string_18, Encoding.Default);
						break;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000A5EC File Offset: 0x000087EC
		public static string smethod_35(string string_17, string string_18, byte[] byte_0 = null)
		{
			bool flag = string_17 == null || string_17 == "";
			string empty;
			if (flag)
			{
				empty = string.Empty;
			}
			else
			{
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_18, byte_0);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_17)))
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream))
							{
								return streamReader.ReadToEnd();
							}
						}
					}
				}
				catch
				{
				}
				empty = string.Empty;
			}
			return empty;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000A704 File Offset: 0x00008904
		public static long smethod_36(string string_17)
		{
			long result = 0L;
			bool flag = string_17 != null;
			if (flag)
			{
				bool flag2 = string_17 != "";
				if (flag2)
				{
					try
					{
						result = Convert.ToInt64(string_17);
					}
					catch
					{
						result = 0L;
					}
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000A768 File Offset: 0x00008968
		public static void smethod_37(ref int[] int_2, int int_3)
		{
			bool flag = int_2 == null || int_2.Length == 0;
			if (flag)
			{
				int_2 = new int[]
				{
					int_3
				};
			}
			else
			{
				int[] array = new int[int_2.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < int_2.Length;
					if (!flag2)
					{
						goto IL_5E;
					}
					bool flag3 = int_2[num] != int_3;
					if (!flag3)
					{
						break;
					}
					array[num] = int_2[num];
					num++;
				}
				return;
				IL_5E:
				array[array.Length - 1] = int_3;
				int_2 = array;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000A7E8 File Offset: 0x000089E8
		public static void smethod_38(ref int[] int_2, int int_3)
		{
			bool flag = int_2 == null || int_2.Length == 0;
			if (flag)
			{
				int_2 = null;
			}
			else
			{
				int num = 0;
				int[] array = new int[int_2.Length];
				for (int i = 0; i < int_2.Length; i++)
				{
					bool flag2 = int_2[i] != int_3;
					if (flag2)
					{
						array[num] = int_2[i];
						num++;
					}
				}
				bool flag3 = num == 0;
				if (flag3)
				{
					int_2 = null;
				}
				else
				{
					bool flag4 = num < int_2.Length;
					if (flag4)
					{
						int[] array2 = new int[num];
						for (int j = 0; j < num; j++)
						{
							array2[j] = array[j];
						}
						int_2 = array2;
					}
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000A89C File Offset: 0x00008A9C
		public static int smethod_39(ref long[,] long_1, int int_2 = 1, int int_3 = 2)
		{
			bool flag = int_2 < 1;
			if (flag)
			{
				int_2 = 1;
			}
			bool flag2 = long_1 != null;
			int result;
			if (flag2)
			{
				int length = long_1.GetLength(0);
				int_3 = long_1.GetLength(1);
				long[,] array = new long[length + int_2, int_3];
				for (int i = 0; i < length; i++)
				{
					for (int j = 0; j < int_3; j++)
					{
						array[i, j] = long_1[i, j];
					}
				}
				long_1 = array;
				result = length + int_2;
			}
			else
			{
				bool flag3 = int_3 > 0;
				if (flag3)
				{
					long_1 = new long[int_2, int_3];
				}
				result = int_2;
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A948 File Offset: 0x00008B48
		public static void smethod_40(ref uint[] uint_2, uint uint_3)
		{
			bool flag = uint_2 != null && uint_2.Length != 0;
			if (flag)
			{
				uint[] array = new uint[uint_2.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < uint_2.Length;
					if (!flag2)
					{
						goto IL_50;
					}
					bool flag3 = uint_2[num] != uint_3;
					if (!flag3)
					{
						break;
					}
					array[num] = uint_2[num];
					num++;
				}
				goto IL_62;
				IL_50:
				array[array.Length - 1] = uint_3;
				uint_2 = array;
				IL_62:;
			}
			else
			{
				uint_2 = new uint[]
				{
					uint_3
				};
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		public static bool smethod_41(ref uint[] uint_2, uint uint_3)
		{
			bool flag = uint_2 != null && uint_2.Length != 0;
			bool result;
			if (flag)
			{
				int num = 0;
				uint[] array = new uint[uint_2.Length];
				for (int i = 0; i < uint_2.Length; i++)
				{
					bool flag2 = uint_2[i] != uint_3;
					if (flag2)
					{
						array[num] = uint_2[i];
						num++;
					}
				}
				bool flag3 = num != 0;
				if (flag3)
				{
					bool flag4 = num < uint_2.Length;
					if (flag4)
					{
						uint[] array2 = new uint[num];
						for (int j = 0; j < num; j++)
						{
							array2[j] = array[j];
						}
						uint_2 = array2;
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					uint_2 = null;
					result = true;
				}
			}
			else
			{
				uint_2 = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000AA90 File Offset: 0x00008C90
		public static int smethod_42(int[] int_2, int int_3)
		{
			bool flag = int_2 != null;
			if (flag)
			{
				for (int i = 0; i < int_2.Length; i++)
				{
					bool flag2 = int_2[i] == int_3;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public static int smethod_43(int[,] int_2, int int_3, int int_4)
		{
			bool flag = int_2 != null;
			if (flag)
			{
				for (int i = 0; i < int_2.GetLength(0); i++)
				{
					bool flag2 = int_2[i, int_4] == int_3;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000AB20 File Offset: 0x00008D20
		public static string smethod_44(string string_17)
		{
			string text = "";
			bool flag = string_17 != null;
			if (flag)
			{
				foreach (char c in string_17)
				{
					text = (((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && (c < '0' || c > '9')) ? (text + ((byte)c).ToString()) : (text + c.ToString()));
				}
			}
			return text;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000ABAC File Offset: 0x00008DAC
		public static string smethod_45(object object_0, int int_2 = 8, bool bool_1 = true, bool bool_2 = false)
		{
			string text = string.Empty;
			bool flag = object_0 == null || object_0.ToString() == "";
			if (flag)
			{
				object_0 = "00";
			}
			try
			{
				long num = Convert.ToInt64(object_0);
				bool flag2 = num < 0L;
				if (flag2)
				{
					int num2 = 4;
					byte[] bytes = BitConverter.GetBytes(num);
					bool flag3 = bytes.Length == 8 && (bytes[4] != byte.MaxValue || bytes[5] != byte.MaxValue || bytes[6] != byte.MaxValue || bytes[7] != byte.MaxValue);
					if (flag3)
					{
						num2 = 8;
					}
					int num3 = bytes.Length;
					byte[] array = new byte[num2];
					for (int i = 0; i < num2; i++)
					{
						int num4 = num2 - i - 1;
						bool flag4 = num3 <= num4;
						if (flag4)
						{
							break;
						}
						array[i] = bytes[num4];
					}
					text = BitConverter.ToString(array).Replace("-", string.Empty);
				}
				else
				{
					text = long.Parse(num.ToString()).ToString("x").ToUpper();
				}
			}
			catch
			{
			}
			while (text.Length < int_2)
			{
				text = "0" + text;
			}
			bool flag5 = !bool_2;
			string result;
			if (flag5)
			{
				if (bool_1)
				{
					text = "0x" + text;
				}
				result = text;
			}
			else
			{
				string text2 = "";
				bool flag6 = text.Length % 2 != 0;
				if (flag6)
				{
					text = "0" + text;
				}
				while (text != string.Empty)
				{
					text2 += text.Substring(text.Length - 2, 2);
					text = text.Remove(text.Length - 2);
				}
				result = text2;
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000AD90 File Offset: 0x00008F90
		public static byte[] smethod_46(string string_17, bool bool_1 = true)
		{
			bool flag = string_17 != null && !(string_17 == "");
			byte[] result;
			if (flag)
			{
				int num = string_17.Length;
				if (bool_1)
				{
					num++;
				}
				byte[] array = new byte[num];
				char[] array2 = string_17.ToCharArray();
				for (int i = 0; i < array2.Length; i++)
				{
					array[i] = (byte)array2[i];
				}
				if (bool_1)
				{
					array[num - 1] = 0;
				}
				result = array;
			}
			else if (bool_1)
			{
				result = new byte[1];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000AE24 File Offset: 0x00009024
		public static byte[] smethod_47(string string_17, bool bool_1 = true)
		{
			bool flag = string_17 == null || string_17 == "";
			byte[] result;
			if (flag)
			{
				if (bool_1)
				{
					result = new byte[2];
				}
				else
				{
					result = null;
				}
			}
			else
			{
				int num = string_17.Length;
				if (bool_1)
				{
					num++;
				}
				byte[] array = new byte[num * 2];
				char[] array2 = string_17.ToCharArray();
				for (int i = 0; i < array2.Length; i++)
				{
					int num2 = (int)array2[i];
					array[i * 2] = (byte)(num2 % 256);
					array[i * 2 + 1] = (byte)(num2 / 256);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000AEC8 File Offset: 0x000090C8
		public static int smethod_48(string string_17, string string_18)
		{
			int num = 0;
			int num2 = 0;
			while ((num2 = string_17.IndexOf(string_18, num2)) != -1)
			{
				num2 += string_18.Length;
				num++;
			}
			return num;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000AF04 File Offset: 0x00009104
		public static long[] smethod_49(string string_17, string string_18 = "*.*")
		{
			long num = 0L;
			long num2 = 0L;
			try
			{
				string[] files = Directory.GetFiles(string_17, string_18);
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						FileInfo fileInfo = new FileInfo(files[i]);
						num2 += 1L;
						num += fileInfo.Length;
						File.Delete(files[i]);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			return new long[]
			{
				num2,
				num
			};
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000AF9C File Offset: 0x0000919C
		public static bool smethod_50(string string_17, byte[] byte_0)
		{
			try
			{
				File.WriteAllBytes(string_17, byte_0);
				return true;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000AFD4 File Offset: 0x000091D4
		public static void smethod_51(string string_17, string string_18, bool bool_1)
		{
			bool flag = string_17 == null || string_17 == string.Empty || !Class12.smethod_17(string_17);
			if (!flag)
			{
				byte[] array = null;
				try
				{
					array = File.ReadAllBytes(string_17);
				}
				catch
				{
				}
				bool flag2 = array == null || array.Length < 2;
				if (!flag2)
				{
					int num = array.Length;
					bool flag3 = !bool_1;
					if (flag3)
					{
						bool flag4 = array[num - 2] != 0 || array[num - 1] > 0;
						if (flag4)
						{
							return;
						}
					}
					else
					{
						bool flag5 = array[num - 2] != 254 || array[num - 1] != byte.MaxValue;
						if (flag5)
						{
							return;
						}
					}
					for (long num2 = 0L; num2 < (long)(num - 2); num2 += 1L)
					{
						bool flag6 = array[(int)(checked((IntPtr)num2))] >= 128;
						if (flag6)
						{
							byte[] array2 = array;
							IntPtr intPtr = checked((IntPtr)num2);
							array2[(int)intPtr] = array2[(int)intPtr] - 128;
						}
						else
						{
							byte[] array3 = array;
							IntPtr intPtr2 = checked((IntPtr)num2);
							array3[(int)intPtr2] = array3[(int)intPtr2] + 128;
						}
					}
					bool flag7 = !bool_1;
					if (flag7)
					{
						array[num - 2] = 254;
						array[num - 1] = byte.MaxValue;
					}
					else
					{
						array[num - 2] = 0;
						array[num - 1] = 0;
					}
					try
					{
						File.WriteAllBytes(string_18, array);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000B140 File Offset: 0x00009340
		public static byte[] smethod_52(byte[] byte_0, bool bool_1)
		{
			bool flag = byte_0 == null || byte_0.Length < 2;
			byte[] result;
			if (flag)
			{
				result = byte_0;
			}
			else
			{
				int num = byte_0.Length;
				if (bool_1)
				{
					bool flag2 = byte_0[num - 2] != 254 || byte_0[num - 1] != byte.MaxValue;
					if (flag2)
					{
						return byte_0;
					}
				}
				else
				{
					bool flag3 = byte_0[num - 2] != 0 || byte_0[num - 1] > 0;
					if (flag3)
					{
						return byte_0;
					}
				}
				for (long num2 = 0L; num2 < (long)(num - 2); num2 += 1L)
				{
					bool flag4 = byte_0[(int)(checked((IntPtr)num2))] < 128;
					if (flag4)
					{
						IntPtr intPtr = checked((IntPtr)num2);
						byte_0[(int)intPtr] = byte_0[(int)intPtr] + 128;
					}
					else
					{
						IntPtr intPtr2 = checked((IntPtr)num2);
						byte_0[(int)intPtr2] = byte_0[(int)intPtr2] - 128;
					}
				}
				if (bool_1)
				{
					byte_0[num - 2] = 0;
					byte_0[num - 1] = 0;
				}
				else
				{
					byte_0[num - 2] = 254;
					byte_0[num - 1] = byte.MaxValue;
				}
				result = byte_0;
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000B248 File Offset: 0x00009448
		public static string smethod_53(string string_17)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			string result;
			if (flag)
			{
				string text = string.Empty;
				int length = string_17.Length;
				foreach (char c in string_17)
				{
					bool flag2 = c > 'ᎇ';
					if (flag2)
					{
						c = (char)((int)c - (5225 + length));
					}
					text += c.ToString();
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000B2D8 File Offset: 0x000094D8
		public static void smethod_54(ref uint[,] uint_2, uint[] uint_3)
		{
			bool flag = uint_2 != null;
			if (flag)
			{
				int length = uint_2.GetLength(0);
				int length2 = uint_2.GetLength(1);
				bool flag2 = uint_3 == null || uint_3.Length == 0 || length2 != uint_3.Length;
				if (!flag2)
				{
					uint[,] array = new uint[length + 1, length2];
					for (int i = 0; i < length; i++)
					{
						for (int j = 0; j < length2; j++)
						{
							array[i, j] = uint_2[i, j];
						}
					}
					for (int k = 0; k < length2; k++)
					{
						array[length, k] = uint_3[k];
					}
					length = array.GetLength(0);
					uint_2 = new uint[length, length2];
					for (int l = 0; l < length; l++)
					{
						for (int m = 0; m < length2; m++)
						{
							uint_2[l, m] = array[l, m];
						}
					}
				}
			}
			else
			{
				uint_2 = new uint[1, uint_3.Length];
				for (int n = 0; n < uint_3.Length; n++)
				{
					uint_2[0, n] = uint_3[n];
				}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000B428 File Offset: 0x00009628
		public static void smethod_55(ref uint[,] uint_2, uint[] uint_3)
		{
			bool flag = uint_2 == null || uint_2.GetLength(0) == 0;
			if (flag)
			{
				uint_2 = null;
			}
			else
			{
				bool flag2 = uint_3 == null || uint_3.Length == 0 || uint_2.GetLength(1) != uint_3.Length;
				if (!flag2)
				{
					int length = uint_2.GetLength(0);
					int length2 = uint_2.GetLength(1);
					int num = 0;
					uint[,] array = new uint[length, length2];
					for (int i = 0; i < length; i++)
					{
						bool flag3 = true;
						for (int j = 0; j < length2; j++)
						{
							flag3 = (flag3 && uint_3[j] == uint_2[i, j]);
							array[num, j] = uint_2[i, j];
						}
						bool flag4 = !flag3;
						if (flag4)
						{
							num++;
						}
					}
					bool flag5 = num == 0;
					if (flag5)
					{
						uint_2 = null;
					}
					else
					{
						bool flag6 = num >= length;
						if (!flag6)
						{
							uint_2 = new uint[num, length2];
							for (int k = 0; k < num; k++)
							{
								for (int l = 0; l < length2; l++)
								{
									uint_2[k, l] = array[k, l];
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000B578 File Offset: 0x00009778
		public static void smethod_56(ref long[,] long_1, long[] long_2)
		{
			try
			{
				bool flag = long_1 != null;
				if (flag)
				{
					int length = long_1.GetLength(0);
					int length2 = long_1.GetLength(1);
					bool flag2 = long_2 == null || long_2.Length == 0 || length2 != long_2.Length;
					if (!flag2)
					{
						long[,] array = new long[length + 1, length2];
						for (int i = 0; i < length; i++)
						{
							for (int j = 0; j < length2; j++)
							{
								array[i, j] = long_1[i, j];
							}
						}
						for (int k = 0; k < length2; k++)
						{
							array[length, k] = long_2[k];
						}
						length = array.GetLength(0);
						long_1 = new long[length, length2];
						for (int l = 0; l < length; l++)
						{
							for (int m = 0; m < length2; m++)
							{
								long_1[l, m] = array[l, m];
							}
						}
					}
				}
				else
				{
					long_1 = new long[1, long_2.Length];
					for (int n = 0; n < long_2.Length; n++)
					{
						long_1[0, n] = long_2[n];
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000B6E8 File Offset: 0x000098E8
		public static void smethod_57(ref long[,] long_1, long[] long_2)
		{
			try
			{
				bool flag = long_1 != null && long_1.GetLength(0) != 0;
				if (flag)
				{
					bool flag2 = long_2 == null || long_2.Length == 0 || long_1.GetLength(1) != long_2.Length;
					if (!flag2)
					{
						int length = long_1.GetLength(0);
						int length2 = long_1.GetLength(1);
						int num = 0;
						long[,] array = new long[length, length2];
						for (int i = 0; i < length; i++)
						{
							bool flag3 = true;
							for (int j = 0; j < length2; j++)
							{
								flag3 = (flag3 && long_2[j] == long_1[i, j]);
								array[num, j] = long_1[i, j];
							}
							bool flag4 = !flag3;
							if (flag4)
							{
								num++;
							}
						}
						bool flag5 = num == 0;
						if (flag5)
						{
							long_1 = null;
						}
						else
						{
							bool flag6 = num >= length;
							if (!flag6)
							{
								long_1 = new long[num, length2];
								for (int k = 0; k < num; k++)
								{
									for (int l = 0; l < length2; l++)
									{
										long_1[k, l] = array[k, l];
									}
								}
							}
						}
					}
				}
				else
				{
					long_1 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000B85C File Offset: 0x00009A5C
		public static int smethod_58(long[,] long_1, long long_2, int int_2 = 0)
		{
			bool flag = long_1 != null;
			if (flag)
			{
				for (int i = 0; i < long_1.GetLength(0); i++)
				{
					bool flag2 = long_2 == long_1[i, int_2];
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		public static string smethod_59(string string_17)
		{
			bool flag = string_17 != null;
			if (flag)
			{
				string_17 = string_17.Replace(" ", string.Empty);
				bool flag2 = string_17 != string.Empty;
				if (flag2)
				{
					byte[] array = new byte[string_17.Length / 2];
					try
					{
						for (int i = 0; i < array.Length; i++)
						{
							array[i] = Convert.ToByte(string_17.Substring(i * 2, 2), 16);
						}
						return Encoding.ASCII.GetString(array);
					}
					catch
					{
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000B94C File Offset: 0x00009B4C
		public static string smethod_60(object object_0, int int_2, char char_41 = ' ')
		{
			string text = string.Empty;
			bool flag = object_0 != null;
			if (flag)
			{
				text = object_0.ToString();
			}
			while (text.Length < int_2)
			{
				text += char_41.ToString();
			}
			return text;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000B994 File Offset: 0x00009B94
		public static void smethod_61(RichTextBox richTextBox_0, string string_17, bool bool_1 = false)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			if (flag)
			{
				bool flag2 = richTextBox_0.Text != string.Empty;
				if (flag2)
				{
					string_17 = Class53.string_7 + string_17;
				}
				int num = Class22.GetScrollPos(richTextBox_0.Handle, 1);
				richTextBox_0.AppendText(string_17);
				bool flag3 = !bool_1;
				if (flag3)
				{
					int num2;
					int num3;
					Class22.GetScrollRange(richTextBox_0.Handle, 1, out num2, out num3);
					int num4 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
					num = num3 - num4;
				}
				Class22.SetScrollPos(richTextBox_0.Handle, 1, num, true);
				Class22.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000BA64 File Offset: 0x00009C64
		public static bool smethod_62(uint[] uint_2)
		{
			return uint_2 != null && uint_2.Length > 1 && uint_2[0] != 0U && uint_2[1] > 0U;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000BA90 File Offset: 0x00009C90
		public static string smethod_63(string string_17)
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] bytes = Encoding.Unicode.GetBytes(string_17);
			byte[] array = bytes;
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		public static string smethod_64(string string_17)
		{
			byte[] array = new byte[string_17.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Convert.ToByte(string_17.Substring(i * 2, 2), 16);
			}
			return Encoding.Unicode.GetString(array);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000BB44 File Offset: 0x00009D44
		public static int smethod_65(string string_17)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			int result;
			if (flag)
			{
				bool flag2 = string_17.IndexOf("0x") >= 0;
				if (flag2)
				{
					string_17 = string_17.Replace("0x", "");
				}
				int num = 0;
				try
				{
					num = int.Parse(string_17.Trim(), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
				}
				catch
				{
					num = 0;
				}
				result = num;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		public static string smethod_66(byte[] byte_0, bool bool_1 = true)
		{
			try
			{
				return BitConverter.ToString(byte_0).Replace("-", string.Empty);
			}
			catch
			{
			}
			return string.Empty;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000BC18 File Offset: 0x00009E18
		public static string smethod_67(string string_17, char char_41, char char_42, char char_43)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			string result;
			if (flag)
			{
				string text = string.Empty;
				for (int i = 0; i < string_17.Length; i++)
				{
					text = ((char_41 <= string_17[i] && string_17[i] <= char_42) ? (text + char_43.ToString()) : (text + string_17[i].ToString()));
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		public static string smethod_68(int[] int_2, char char_41 = ',')
		{
			string text = string.Empty;
			bool flag = int_2 == null;
			if (!flag)
			{
				bool flag2 = int_2.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < int_2.Length; i++)
					{
						bool flag3 = text != null;
						if (flag3)
						{
							bool flag4 = !(text != string.Empty);
							if (!flag4)
							{
								text += char_41.ToString();
							}
						}
						text += int_2[i].ToString();
					}
				}
			}
			return text;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public static int[] smethod_69(string string_17, object object_0 = null)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			int[] result;
			if (flag)
			{
				char[] separator = new char[]
				{
					','
				};
				bool flag2 = object_0 != null;
				if (flag2)
				{
					string[] array = typeof(char).ToString().Split(new char[]
					{
						'.'
					});
					string value = array[array.Length - 1].ToUpper();
					string text = object_0.GetType().ToString().ToUpper();
					bool flag3 = 0 <= text.IndexOf("[");
					if (flag3)
					{
						separator = (char[])object_0;
					}
					else
					{
						bool flag4 = 0 <= text.IndexOf(value);
						if (flag4)
						{
							string text2 = object_0.ToString();
							bool flag5 = text2 != string.Empty;
							if (flag5)
							{
								separator = text2.ToCharArray();
							}
						}
					}
				}
				string[] array2 = string_17.Split(separator);
				int[] array3 = new int[array2.Length];
				int num = 0;
				for (int i = 0; i < array2.Length; i++)
				{
					bool flag6 = array2[i] != null && array2[i] != string.Empty;
					if (flag6)
					{
						string_17 = array2[i].Trim();
						bool flag7 = string_17 != string.Empty;
						if (flag7)
						{
							array3[num] = Class12.smethod_11(array2[i]);
							num++;
						}
					}
				}
				bool flag8 = num == 0;
				if (flag8)
				{
					result = null;
				}
				else
				{
					bool flag9 = num < array3.Length;
					if (flag9)
					{
						Array.Resize<int>(ref array3, num);
					}
					result = array3;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		public static string smethod_70(string string_17)
		{
			bool flag = string_17 == null || string_17 == string.Empty;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				byte[] inArray = null;
				string text = string.Empty;
				try
				{
					using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(string_17)))
					{
						using (MemoryStream memoryStream2 = new MemoryStream())
						{
							using (DeflateStream deflateStream = new DeflateStream(memoryStream2, CompressionMode.Compress, true))
							{
								memoryStream.CopyTo(deflateStream);
							}
							inArray = memoryStream2.ToArray();
						}
					}
					text = Convert.ToBase64String(inArray);
				}
				catch
				{
				}
				result = text;
			}
			return result;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000BFC4 File Offset: 0x0000A1C4
		public static string smethod_71(string string_17)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			string result;
			if (flag)
			{
				byte[] bytes = null;
				string text = string.Empty;
				try
				{
					MemoryStream stream = new MemoryStream(Convert.FromBase64String(string_17));
					using (DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress))
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							deflateStream.CopyTo(memoryStream);
							bytes = memoryStream.ToArray();
						}
					}
					text = Encoding.UTF8.GetString(bytes);
				}
				catch
				{
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000C090 File Offset: 0x0000A290
		public static string smethod_72(string string_17)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			string result;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					byte[] bytes = Encoding.UTF8.GetBytes(string_17);
					MemoryStream memoryStream = new MemoryStream();
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
					{
						gzipStream.Write(bytes, 0, bytes.Length);
					}
					memoryStream.Position = 0L;
					new MemoryStream();
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Read(array, 0, array.Length);
					byte[] array2 = new byte[array.Length + 4];
					Buffer.BlockCopy(array, 0, array2, 4, array.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(bytes.Length), 0, array2, 0, 4);
					text = Convert.ToBase64String(array2);
				}
				catch
				{
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000C190 File Offset: 0x0000A390
		public static string smethod_73(string string_17)
		{
			bool flag = string_17 != null && !(string_17 == string.Empty);
			string result;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					byte[] array = Convert.FromBase64String(string_17);
					using (MemoryStream memoryStream = new MemoryStream())
					{
						int num = BitConverter.ToInt32(array, 0);
						memoryStream.Write(array, 4, array.Length - 4);
						byte[] array2 = new byte[num];
						memoryStream.Position = 0L;
						using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
						{
							gzipStream.Read(array2, 0, array2.Length);
						}
						text = Encoding.UTF8.GetString(array2);
					}
				}
				catch
				{
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000C27C File Offset: 0x0000A47C
		public static string EncryptString(string plainText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000C30C File Offset: 0x0000A50C
		public static string DecryptString(string cipherText)
		{
			string s = "mihR9pppgXDn7bQV";
			SHA256 sha = SHA256.Create();
			byte[] key = sha.ComputeHash(Encoding.ASCII.GetBytes(s));
			byte[] bytes = Encoding.ASCII.GetBytes("89HOJDH1EOZ1E282");
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = bytes;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array2 = memoryStream.ToArray();
				result = Encoding.UTF8.GetString(array2, 0, array2.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		public static string EncryptoText(string mText, string mPassword, byte[] mByteCode = null)
		{
			string result = string.Empty;
			bool flag = !string.IsNullOrEmpty(mText) && !string.IsNullOrEmpty(mPassword);
			if (flag)
			{
				bool flag2 = mByteCode == null;
				if (flag2)
				{
					return string.Empty;
				}
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				try
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(mPassword, mByteCode);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream memoryStream = new MemoryStream())
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
						{
							using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
							{
								streamWriter.Write(mText);
							}
						}
						result = Convert.ToBase64String(memoryStream.ToArray());
					}
				}
				finally
				{
					bool flag3 = rijndaelManaged != null;
					if (flag3)
					{
						rijndaelManaged.Clear();
					}
				}
			}
			return result;
		}

		// Token: 0x04000013 RID: 19
		public static char[] char_0 = new char[]
		{
			'ᒟ',
			'ᒞ',
			'ᒜ',
			'ᒤ',
			'ᒦ'
		};

		// Token: 0x04000014 RID: 20
		public static char[] char_1 = new char[]
		{
			'ᒱ',
			'ᓱ',
			'ᓵ',
			'ᓡ',
			'ᓮ',
			'ᓧ',
			'ᓣ',
			'ᓡ',
			'ᓯ',
			'ᒯ',
			'ᓋ',
			'ᓙ',
			'ᓋ',
			'ᓥ',
			'ᓯ',
			'ᓸ',
			'ᓥ',
			'ᓐ',
			'ᓢ',
			'ᒮ',
			'ᓴ',
			'ᓸ',
			'ᓴ'
		};

		// Token: 0x04000015 RID: 21
		public static char[] char_2 = new char[]
		{
			'ᒲ',
			'ᓲ',
			'ᓶ',
			'ᓢ',
			'ᓯ',
			'ᓨ',
			'ᓤ',
			'ᓢ',
			'ᓰ',
			'ᒰ',
			'ᓌ',
			'ᓚ',
			'ᓒ',
			'ᓶ',
			'ᓢ',
			'ᓯ',
			'ᓨ',
			'ᓤ',
			'ᓢ',
			'ᓰ',
			'ᒯ',
			'ᓵ',
			'ᓹ',
			'ᓵ'
		};

		// Token: 0x04000016 RID: 22
		public static char[] char_3 = new char[]
		{
			'ᒰ',
			'ᓰ',
			'ᓴ',
			'ᓠ',
			'ᓭ',
			'ᓦ',
			'ᓢ',
			'ᓠ',
			'ᓮ',
			'ᒮ',
			'ᓊ',
			'ᓘ',
			'ᓌ',
			'ᓠ',
			'ᓸ',
			'ᓯ',
			'ᓧ',
			'ᓴ',
			'ᒭ',
			'ᓳ',
			'ᓷ',
			'ᓳ'
		};

		// Token: 0x04000017 RID: 23
		public static int int_0 = 0;

		// Token: 0x04000018 RID: 24
		public static char[] char_4 = new char[]
		{
			'ᓓ',
			'ᓝ',
			'ᓔ',
			'ᒞ',
			'ᓕ',
			'ᓨ',
			'ᓕ'
		};

		// Token: 0x04000019 RID: 25
		public static char[] char_5 = new char[]
		{
			'ᒻ',
			'ᓉ',
			'ᒻ',
			'ᒵ',
			'ᒿ',
			'ᓈ',
			'ᒵ'
		};

		// Token: 0x0400001A RID: 26
		public static char[] char_6 = new char[]
		{
			'ᒳ',
			'ᓀ',
			'ᓀ',
			'ᓅ',
			'ᓃ',
			'ᓀ',
			'ᓀ',
			'ᒾ'
		};

		// Token: 0x0400001B RID: 27
		public static char[] char_7 = new char[]
		{
			'ᒡ',
			'ᒡ',
			'ᒡ',
			'ᒡ',
			'ᒡ',
			'ᒡ',
			'ᒡ',
			'ᒡ'
		};

		// Token: 0x0400001C RID: 28
		public static string string_0 = "ᔋᔲᔾᔻᔾᕁᔌᔿᔸᔽᔺᔍᖺᓯᔱᖅᔽᓯᕽᖴᓯᔽᖄᕈᓻᓯᔰᔳᔶᔰᔼᔴᓯᕽᖆᓯᔺᔷᖲᔰᓯᔲᔷᗇᔲᓯᔽᕷᔽᔶᓯᕃᖦᔼᓯᔰᔲᓯᔲᔷᖬᔽᔷᓻᓯᕃᖚᔿᓯᔺᖤᕃᓻᓯᕃᗈᓯᔲᔷᖈᕈᓯᕁᔰᓯᔺᔷᖰᔸᓯᔷᖚᕄᓯᔳᔾᔰᔽᔷᓽᓽᓽ";

		// Token: 0x0400001D RID: 29
		public static char[] char_8 = new char[]
		{
			'ᔛ',
			'ᓹ',
			'ᔎ',
			'ᔅ',
			'ᔥ',
			'ᔲ',
			'ᔖ',
			'ᔇ',
			'ᔫ',
			'ᔬ',
			'ᔪ',
			'ᔑ',
			'ᔄ',
			'ᓶ',
			'ᔋ',
			'ᔦ',
			'ᔍ',
			'ᔣ',
			'ᔺ',
			'ᔙ',
			'ᔏ',
			'ᔑ',
			'ᔲ',
			'ᓳ',
			'ᓱ',
			'ᔹ',
			'ᔘ',
			'ᔇ',
			'ᓲ',
			'ᔉ',
			'ᔻ',
			'ᔌ',
			'ᔮ',
			'ᔈ',
			'ᔬ',
			'ᔓ',
			'ᔲ',
			'ᔖ',
			'ᔵ',
			'ᔴ',
			'ᔗ',
			'ᔄ',
			'ᔷ',
			'ᓱ',
			'ᔄ',
			'ᔌ',
			'ᔎ',
			'ᓺ',
			'ᔆ',
			'ᔓ',
			'ᔦ',
			'ᔗ',
			'ᔊ',
			'ᔤ',
			'ᔨ',
			'ᔥ',
			'ᔑ',
			'ᔉ',
			'ᔎ',
			'ᓺ',
			'ᔘ',
			'ᔈ',
			'ᔋ',
			'ᓰ',
			'ᔤ',
			'ᔑ',
			'ᔥ',
			'ᓰ',
			'ᔴ',
			'ᓴ',
			'ᔊ',
			'ᔖ',
			'ᔰ',
			'ᔬ',
			'ᔣ',
			'ᔳ',
			'ᔔ',
			'ᓷ',
			'ᔻ',
			'ᔶ',
			'ᔌ',
			'ᔹ',
			'ᔚ',
			'ᔏ',
			'ᔆ',
			'ᔒ',
			'ᓾ',
			'ᓾ'
		};

		// Token: 0x0400001E RID: 30
		public static char[] char_9 = new char[]
		{
			'ᒨ',
			'ᒧ',
			'ᒧ',
			'ᒨ',
			'ᒧ',
			'ᒧ',
			'ᒨ',
			'ᒧ',
			'ᒧ',
			'ᒨ',
			'ᒧ',
			'ᒧ',
			'ᒨ',
			'ᒧ'
		};

		// Token: 0x0400001F RID: 31
		public static char[] char_10 = new char[]
		{
			'ᓋ',
			'ᓮ',
			'ᓱ',
			'ᓫ',
			'ᓷ',
			'ᓯ',
			'ᒪ',
			'ᖛ',
			'ᕭ',
			'ᒪ',
			'ᓵ',
			'ᓲ',
			'ᕽ',
			'ᓫ',
			'ᒪ',
			'ᓭ',
			'ᓲ',
			'㍳',
			'ᓭ',
			'ᒪ',
			'ᓸ',
			'ᖍ',
			'ᓸ',
			'ᓱ',
			'ᒪ',
			'ᓾ',
			'ᓲ',
			'ᓯ',
			'ᓹ',
			'ᒪ',
			'ᓽ',
			'ᓫ',
			'ᓿ'
		};

		// Token: 0x04000020 RID: 32
		public static char[] char_11 = new char[]
		{
			'ᒛ',
			'ᓡ',
			'ᓥ',
			'ᓡ'
		};

		// Token: 0x04000021 RID: 33
		public static char[] char_12 = new char[]
		{
			'ᓘ',
			'ᓤ',
			'ᓤ',
			'ᓠ',
			'ᒪ',
			'ᒟ',
			'ᒟ'
		};

		// Token: 0x04000022 RID: 34
		public static char[] char_13 = new char[]
		{
			'ᒱ',
			'ᓨ',
			'ᓥ',
			'ᓖ',
			'ᓣ',
			'ᒕ',
			'ᓞ',
			'ᓙ',
			'ᒲ',
			'ᓩ',
			'ᒦ',
			'ᒳ'
		};

		// Token: 0x04000023 RID: 35
		public static char[] char_14 = new char[]
		{
			'ᓎ',
			'ᓢ',
			'ᕮ',
			'ᓨ',
			'ᓡ',
			'ᒚ',
			'ᓮ',
			'ᓣ',
			'ᓨ',
			'ᒚ',
			'ᖋ',
			'ᕽ',
			'ᓨ',
			'ᓡ',
			'ᒚ',
			'ᓥ',
			'ᕷ'
		};

		// Token: 0x04000024 RID: 36
		public static char[] char_15 = new char[]
		{
			'ᓎ',
			'ᓳ',
			'ᘻ',
			'ᓬ',
			'ᒫ',
			'ᖜ',
			'ᖎ',
			'ᓹ',
			'ᓲ',
			'ᒫ',
			'ᓶ',
			'ᖈ',
			'ᒫ',
			'ᓳ',
			'ᓺ',
			'㍂',
			'ᓮ',
			'ᒫ',
			'ᓳ',
			'㍊',
			'ᓿ',
			'ᒫ',
			'ᓳ',
			'㌬',
			'ᓹ',
			'ᒫ',
			'ᓾ',
			'㍸',
			'ᒫ',
			'ᓯ',
			'㍰',
			'ᓹ',
			'ᓲ',
			'ᒹ'
		};

		// Token: 0x04000025 RID: 37
		public static char[] char_16 = new char[]
		{
			'ᓞ',
			'ᓣ',
			'ᘫ',
			'ᓜ',
			'ᒛ',
			'ᓦ',
			'ᓤ',
			'㌾',
			'ᓨ',
			'ᒛ',
			'ᓯ',
			'ᓭ',
			'ᓜ',
			'ᒛ',
			'ᖌ',
			'ᘫ',
			'㍞',
			'ᓞ'
		};

		// Token: 0x04000026 RID: 38
		public static char[] char_17 = new char[]
		{
			'ᓙ',
			'ᓭ',
			'ᕹ',
			'ᓳ',
			'ᓬ',
			'ᒥ',
			'ᓹ',
			'ᓮ',
			'ᓳ',
			'ᒥ',
			'ᒭ',
			'ᓱ',
			'ᓮ',
			'ᓨ',
			'ᒥ',
			'ᓰ',
			'ᓭ',
			'ᕹ',
			'ᓳ',
			'ᓬ',
			'ᒥ',
			'ᓭ',
			'㍨',
			'ᓵ',
			'ᒥ',
			'ᓱ',
			'㍌',
			'ᒮ'
		};

		// Token: 0x04000027 RID: 39
		public static char[] char_18 = new char[]
		{
			'ᒶ',
			'ᓁ',
			'ᒲ',
			'ᒨ',
			'ᒎ'
		};

		// Token: 0x04000028 RID: 40
		public static char[] char_19 = new char[]
		{
			'ᒎ',
			'ᓜ',
			'ᓕ',
			'ᕎ',
			'ᓧ'
		};

		// Token: 0x04000029 RID: 41
		public static char[] char_20 = new char[]
		{
			'ᒶ',
			'ᒱ',
			'ᒧ',
			'ᒍ'
		};

		// Token: 0x0400002A RID: 42
		public static char[] char_21 = new char[]
		{
			'ᓯ',
			'㍒',
			'ᔚ',
			'ᓍ',
			'ᔛ',
			'ᖧ',
			'ᔡ',
			'ᓍ',
			'ᔈ',
			'ᓮ',
			'ᔊ',
			'ᓍ',
			'ᖾ',
			'㍰',
			'ᓍ',
			'ᖖ',
			'ᔝ',
			'ᓍ',
			'ᔡ',
			'ᖗ',
			'ᔛ',
			'ᓍ',
			'ᔎ',
			'ᔐ',
			'ᓍ',
			'ᔣ',
			'ᖍ',
			'ᔜ',
			'ᓍ',
			'ᔎ',
			'ᔢ',
			'ᔡ',
			'ᔜ',
			'ᓛ',
			'ᓍ',
			'ᓯ',
			'㍒',
			'ᔚ',
			'ᓍ',
			'ᔝ',
			'ᔕ',
			'㎒',
			'ᓍ',
			'ᔡ',
			'ᔟ',
			'㎐',
			'ᓍ',
			'ᖾ',
			'㍰',
			'ᓍ',
			'ᔥ',
			'ᔒ',
			'ᔚ',
			'ᓍ',
			'ᔝ',
			'ᔕ',
			'ᔖ',
			'ᔚ',
			'ᓍ',
			'ᔕ',
			'ᙝ',
			'㎈',
			'ᔛ',
			'ᔔ',
			'ᓍ',
			'ᔑ',
			'㍘',
			'ᔛ'
		};

		// Token: 0x0400002B RID: 43
		public static char[] char_22 = new char[]
		{
			'ᔦ',
			'ᔊ',
			'ᔤ',
			'ᔗ',
			'ᕉ',
			'ᔍ',
			'ᔽ',
			'ᔗ',
			'ᔪ',
			'ᕌ',
			'ᔟ',
			'ᕊ',
			'ᔡ',
			'ᔿ',
			'ᕂ',
			'ᔧ',
			'ᕉ',
			'ᔬ',
			'ᕍ',
			'ᔻ',
			'ᕊ',
			'ᕇ',
			'ᔙ',
			'ᔋ',
			'ᕉ',
			'ᔋ',
			'ᔗ',
			'ᕄ',
			'ᔖ',
			'ᔡ',
			'ᔞ',
			'ᔤ',
			'ᔹ',
			'ᔈ',
			'ᔗ',
			'ᔹ',
			'ᕊ',
			'ᕄ',
			'ᕁ',
			'ᔛ',
			'ᔦ',
			'ᔅ',
			'ᕆ',
			'ᔞ',
			'ᔞ',
			'ᔎ',
			'ᔟ',
			'ᕏ',
			'ᔆ',
			'ᕇ',
			'ᔫ',
			'ᔄ',
			'ᔉ',
			'ᕅ',
			'ᔆ',
			'ᔟ',
			'ᔍ',
			'ᔻ',
			'ᕎ',
			'ᔎ',
			'ᔾ',
			'ᔾ',
			'ᔼ',
			'ᕇ',
			'ᔜ',
			'ᕂ',
			'ᔛ',
			'ᔞ',
			'ᕄ',
			'ᔨ',
			'ᔮ',
			'ᕁ',
			'ᔌ',
			'ᔷ',
			'ᕄ',
			'ᕅ',
			'ᔅ',
			'ᕊ',
			'ᔊ',
			'ᔯ',
			'ᔜ',
			'ᔄ',
			'ᔨ',
			'ᔭ',
			'ᔘ',
			'ᔠ',
			'ᔈ',
			'ᔝ',
			'ᔆ',
			'ᔙ',
			'ᔛ',
			'ᔣ',
			'ᔭ',
			'ᔫ',
			'ᔅ',
			'ᕎ',
			'ᔭ',
			'ᕌ',
			'ᔋ',
			'ᔿ',
			'ᕋ',
			'ᕌ',
			'ᔌ',
			'ᔻ',
			'ᔚ',
			'ᔺ',
			'ᔪ',
			'ᔒ'
		};

		// Token: 0x0400002C RID: 44
		public static string string_1 = "ᒘ";

		// Token: 0x0400002D RID: 45
		public static string string_2 = "ᒖ";

		// Token: 0x0400002E RID: 46
		public static string string_3 = "ᓦ";

		// Token: 0x0400002F RID: 47
		public static string string_4 = "ᒙ";

		// Token: 0x04000030 RID: 48
		public static string string_5 = "ᒗ";

		// Token: 0x04000031 RID: 49
		public static string string_6 = "ᓉ";

		// Token: 0x04000032 RID: 50
		public static string string_7 = "ᒤ";

		// Token: 0x04000033 RID: 51
		public static string string_8 = "ᒒ";

		// Token: 0x04000034 RID: 52
		public static string string_9 = "ᒓ";

		// Token: 0x04000035 RID: 53
		public static string string_10 = "ᒔ";

		// Token: 0x04000036 RID: 54
		public static string string_11 = "ᓅ";

		// Token: 0x04000037 RID: 55
		public static string string_12 = "ᓇ";

		// Token: 0x04000038 RID: 56
		public static string string_13 = "ᒚ";

		// Token: 0x04000039 RID: 57
		public static char[] char_23 = new char[]
		{
			'ᓘ',
			'ᓖ',
			'ᓚ',
			'ᓦ'
		};

		// Token: 0x0400003A RID: 58
		public static string string_14 = "ᓔᒿᒽᓼᓕᓴᓷᓗᓗᓝᓪᓔᓜᓜᓷᓔᓕᓎᓼᓽᓔᓸᒾᓓᓕᓞᓴᓐᓊᓊᓆᓆ";

		// Token: 0x0400003B RID: 59
		public static string[] string_15 = new string[]
		{
			"ᓲᒱᒰᓆᓫᓎᓳᓇᒩᒱᓭᓅᓅᓊᒾᒺ",
			"ᓲᒱᒰᓆᓫᓎᓳᓇᒩᒱᓯᓆᓌᓰᓆᒺ"
		};

		// Token: 0x0400003C RID: 60
		public static char[] char_24 = new char[]
		{
			'ᓓ',
			'ᒕ'
		};

		// Token: 0x0400003D RID: 61
		public static char[] char_25 = new char[]
		{
			'ᓕ',
			'ᒗ',
			'ᒛ',
			'ᒗ'
		};

		// Token: 0x0400003E RID: 62
		public static char[] char_26 = new char[]
		{
			'ᒾ',
			'ᒶ',
			'ᒽ',
			'ᓂ',
			'ᒽ'
		};

		// Token: 0x0400003F RID: 63
		public static char[] char_27 = new char[]
		{
			'ᓇ',
			'ᓆ',
			'ᒵ',
			'ᒚ',
			'ᓀ',
			'ᒻ',
			'ᓅ',
			'ᓆ',
			'ᒛ'
		};

		// Token: 0x04000040 RID: 64
		public static char[] char_28 = new char[]
		{
			'ᓳ',
			'ᓳ',
			'ᒧ',
			'ᓇ',
			'ᓇ',
			'ᒧ',
			'ᓞ',
			'ᓞ',
			'ᒚ',
			'ᓂ',
			'ᓂ',
			'ᒴ',
			'ᓧ',
			'ᓧ',
			'ᒴ',
			'ᓭ',
			'ᓭ'
		};

		// Token: 0x04000041 RID: 65
		public static char[] char_29 = new char[]
		{
			'ᓾ',
			'ᔗ',
			'ᕥ',
			'ᔩ',
			'ᓐ',
			'ᔗ',
			'ᔙ',
			'ᖚ',
			'ᓐ',
			'ᔓ',
			'ᖡ',
			'ᔑ',
			'ᓐ',
			'ᔝ',
			'ᕨ',
			'ᔩ',
			'ᓐ',
			'ᔤ',
			'ᖍ',
			'ᔞ',
			'ᔘ',
			'ᓐ',
			'ᔒ',
			'ᖎ',
			'ᓐ',
			'ᔣ',
			'ᔑ',
			'ᔙ',
			'ᓜ',
			'ᓐ',
			'ᔘ',
			'ᕧ',
			'ᔩ',
			'ᓐ',
			'ᕞ',
			'ᔙ',
			'ᖂ',
			'ᔥ',
			'ᓐ',
			'ᔓ',
			'ᔘ',
			'ᖈ',
			'ᔞ',
			'ᔘ',
			'ᓐ',
			'ᔜ',
			'ᕩ',
			'ᔙ',
			'ᓐ',
			'ᔝ',
			'ᖝ',
			'ᔙ',
			'ᓐ',
			'ᔣ',
			'ᖦ',
			'ᓐ',
			'ᔔ',
			'ᖤ',
			'ᔞ',
			'ᔗ',
			'ᓐ',
			'ᕞ',
			'ᕝ',
			'ᖞ',
			'ᔓ',
			'ᓐ',
			'ᔑ',
			'ᔥ',
			'ᔤ',
			'ᔟ',
			'ᓞ'
		};

		// Token: 0x04000042 RID: 66
		public static char[] char_30 = new char[]
		{
			'ᒿ',
			'ᓍ',
			'ᒿ',
			'ᓙ',
			'ᓣ',
			'ᓬ',
			'ᓙ',
			'ᒢ',
			'ᓨ',
			'ᓬ',
			'ᓨ'
		};

		// Token: 0x04000043 RID: 67
		public static char[] char_31 = new char[]
		{
			'ᓄ',
			'ᓁ',
			'ᒻ',
			'ᓗ',
			'ᓃ',
			'ᓑ',
			'ᓃ',
			'ᓝ',
			'ᓧ',
			'ᓰ',
			'ᓝ',
			'ᒦ',
			'ᓬ',
			'ᓰ',
			'ᓬ'
		};

		// Token: 0x04000044 RID: 68
		public static char[] char_32 = new char[]
		{
			'ᔟ',
			'ᔨ',
			'ᔫ',
			'ᓙ',
			'ᓞ',
			'ᔚ',
			'ᓙ',
			'ᔢ',
			'ᔧ',
			'ᓙ',
			'ᓡ',
			'ᔰ',
			'ᓥ',
			'ᔳ',
			'ᓥ',
			'ᔲ',
			'ᓥ',
			'ᔱ',
			'ᓥ',
			'ᔯ',
			'ᓥ',
			'ᔮ',
			'ᓥ',
			'ᔭ',
			'ᓥ',
			'ᔬ',
			'ᓥ',
			'ᔫ',
			'ᓥ',
			'ᔪ',
			'ᓥ',
			'ᔩ',
			'ᓥ',
			'ᔨ',
			'ᓥ',
			'ᔧ',
			'ᓥ',
			'ᔦ',
			'ᓥ',
			'ᔥ',
			'ᓥ',
			'ᔤ',
			'ᓥ',
			'ᔠ',
			'ᓥ',
			'ᔢ',
			'ᓥ',
			'ᔡ',
			'ᓥ',
			'ᔠ',
			'ᓥ',
			'ᔟ',
			'ᓥ',
			'ᔞ',
			'ᓥ',
			'ᔝ',
			'ᓥ',
			'ᔜ',
			'ᓢ',
			'ᓙ',
			'ᔝ',
			'ᔨ',
			'ᓙ',
			'ᔝ',
			'ᔞ',
			'ᔥ',
			'ᓙ',
			'ᓞ',
			'ᔚ',
			'ᓳ',
			'ᔕ',
			'ᓣ',
			'ᓧ',
			'ᓣ',
			'ᓨ',
			'ᔬ',
			'ᓨ',
			'ᔟ',
			'ᓨ',
			'ᔪ'
		};

		// Token: 0x04000045 RID: 69
		public static char[] char_33 = new char[]
		{
			'ᓰ',
			'ᓨ',
			'ᓶ',
			'ᓶ',
			'ᓝ',
			'ᓥ',
			'㍄',
			'ᔑ',
			'ᓃ',
			'ᖴ',
			'ᔄ',
			'ᔑ',
			'ᔊ',
			'ᓃ',
			'ᔖ',
			'㎐',
			'ᓃ',
			'ᔇ',
			'㎈',
			'ᔑ',
			'ᔊ',
			'ᓃ',
			'ᔆ',
			'ᔕ',
			'ᔄ',
			'ᔆ',
			'ᔎ',
			'ᓃ',
			'ᔄ',
			'ᔘ',
			'ᔗ',
			'ᔒ',
			'ᓏ',
			'ᓃ',
			'ᔅ',
			'㍄',
			'ᔑ',
			'ᓃ',
			'ᔆ',
			'ᖃ',
			'ᔌ',
			'ᓃ',
			'ᔏ',
			'㍄',
			'ᔌ',
			'ᓃ',
			'ᓺ',
			'ᔌ',
			'ᔑ',
			'ᔇ',
			'ᔒ',
			'ᔚ',
			'ᔖ',
			'ᓃ',
			'ᔑ',
			'ᔋ',
			'ᖌ',
			'ᓑ'
		};

		// Token: 0x04000046 RID: 70
		public static char[] char_34 = new char[]
		{
			'ᔋ',
			'㎖',
			'ᔨ',
			'ᓟ',
			'ᔪ',
			'ᔧ',
			'ᖳ',
			'ᔭ',
			'ᔦ',
			'ᓟ',
			'ᔷ',
			'ᖠ',
			'ᔢ',
			'ᓟ',
			'ᗐ',
			'㎊',
			'ᔭ',
			'ᔧ',
			'ᓟ',
			'ᗐ',
			'ᙯ',
			'㎢',
			'ᔢ',
			'ᓟ',
			'ᔯ',
			'ᔧ',
			'ᔨ',
			'ᖩ',
			'ᔭ',
			'ᓟ',
			'ᔡ',
			'㍢',
			'ᔭ',
			'ᓟ',
			'ᔠ',
			'ᔴ',
			'ᔳ',
			'ᔮ',
			'ᓟ',
			'ᗐ',
			'ᔠ',
			'ᔭ',
			'ᔦ',
			'ᓟ',
			'ᔲ',
			'㎬',
			'ᓟ',
			'ᔣ',
			'㎤',
			'ᔭ',
			'ᔦ',
			'ᓟ',
			'ᔧ',
			'ᔮ',
			'㍶',
			'ᔢ',
			'ᓟ',
			'ᔠ',
			'ᔴ',
			'ᔳ',
			'ᔮ',
			'ᓟ',
			'ᗐ',
			'ᖢ',
			'ᓟ',
			'ᔢ',
			'ᖲ',
			'ᓟ',
			'ᔯ',
			'ᔧ',
			'ᔨ',
			'ᖩ',
			'ᔭ',
			'ᓟ',
			'ᔡ',
			'㍢',
			'ᔭ',
			'ᓟ',
			'ᔬ',
			'㎚',
			'ᔨ',
			'ᓟ',
			'ᔧ',
			'ᙠ',
			'ᔭ',
			'ᓭ'
		};

		// Token: 0x04000047 RID: 71
		public static char[] char_35 = new char[]
		{
			'ᔗ',
			'ᔾ',
			'ᕊ',
			'ᕇ',
			'ᕊ',
			'ᕍ',
			'ᔘ',
			'ᕒ',
			'ᕃ',
			'ᕄ',
			'ᕏ',
			'ᕀ',
			'ᔙ',
			'ᔞ',
			'ᕃ',
			'ᖈ',
			'ᔼ',
			'ᓻ',
			'ᖉ',
			'ᖃ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᕆ',
			'ᗘ',
			'ᔕ',
			'ᓻ',
			'ᔗ',
			'ᔾ',
			'ᕊ',
			'ᕇ',
			'ᕊ',
			'ᕍ',
			'ᔘ',
			'ᕔ',
			'ᕀ',
			'ᕇ',
			'ᕇ',
			'ᕊ',
			'ᕒ',
			'ᔙ',
			'ᔞ',
			'ᕃ',
			'ᖈ',
			'ᔼ',
			'ᓻ',
			'ᖉ',
			'ᖃ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᕆ',
			'ᗘ',
			'ᓻ',
			'ᕎ',
			'ᗑ',
			'ᓻ',
			'ᔿ',
			'ᗏ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᕉ',
			'ᖅ',
			'ᕉ',
			'ᓻ',
			'ᕆ',
			'ᕃ',
			'ᖆ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᕏ',
			'ᕃ',
			'ᖮ',
			'ᓻ',
			'ᔿ',
			'ᗊ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᖉ',
			'ᖈ',
			'ᗉ',
			'ᔾ',
			'ᔇ',
			'ᓻ',
			'ᕇ',
			'ᕄ',
			'ᖅ',
			'ᕉ',
			'ᓻ',
			'ᕃ',
			'ᖱ',
			'ᓻ',
			'ᔦ',
			'ᕄ',
			'ᕈ',
			'ᓻ',
			'ᔴ',
			'ᖰ',
			'ᕉ',
			'ᓻ',
			'ᖉ',
			'ᖮ',
			'ᓻ',
			'ᖉ',
			'ᖃ',
			'ᕉ',
			'ᕂ',
			'ᓻ',
			'ᕆ',
			'ᗘ',
			'ᔉ'
		};

		// Token: 0x04000048 RID: 72
		public static char[] char_36 = new char[]
		{
			'ᔓ',
			'ᔺ',
			'ᕆ',
			'ᕃ',
			'ᕆ',
			'ᕉ',
			'ᔔ',
			'ᕎ',
			'ᔿ',
			'ᕀ',
			'ᕋ',
			'ᔼ',
			'ᔕ',
			'ᔚ',
			'ᔿ',
			'ᖄ',
			'ᔸ',
			'ᓷ',
			'ᖅ',
			'ᕿ',
			'ᕅ',
			'ᔾ',
			'ᓷ',
			'ᕂ',
			'ᗔ',
			'ᔑ',
			'ᓷ',
			'ᔓ',
			'ᔺ',
			'ᕆ',
			'ᕃ',
			'ᕆ',
			'ᕉ',
			'ᔔ',
			'ᕐ',
			'ᔼ',
			'ᕃ',
			'ᕃ',
			'ᕆ',
			'ᕎ',
			'ᔕ',
			'ᔣ',
			'ᔠ',
			'ᔚ',
			'ᓷ',
			'ᖅ',
			'ᕿ',
			'ᕅ',
			'ᔾ',
			'ᓷ',
			'ᕂ',
			'ᗔ',
			'ᓷ',
			'ᔺ',
			'ᖺ',
			'ᓷ',
			'ᕄ',
			'ᖎ',
			'ᓷ',
			'ᕏ',
			'ᖏ',
			'ᔺ',
			'ᓷ',
			'ᕋ',
			'ᔿ',
			'ᗐ',
			'ᔺ',
			'ᓷ',
			'ᕂ',
			'ᔿ',
			'ᖂ',
			'ᕅ',
			'ᔾ',
			'ᓷ',
			'ᖅ',
			'ᗊ',
			'ᕅ',
			'ᔾ',
			'ᔃ',
			'ᓷ',
			'ᕃ',
			'ᕀ',
			'ᖁ',
			'ᕅ',
			'ᓷ',
			'ᔿ',
			'ᖭ',
			'ᓷ',
			'ᔢ',
			'ᕀ',
			'ᕄ',
			'ᓷ',
			'ᔰ',
			'ᖬ',
			'ᕅ',
			'ᓷ',
			'ᖅ',
			'ᖪ',
			'ᓷ',
			'ᖅ',
			'ᕀ',
			'ᖩ',
			'ᕌ',
			'ᓷ',
			'ᔺ',
			'ᔿ',
			'ᖯ',
			'ᕅ',
			'ᔿ',
			'ᔅ'
		};

		// Token: 0x04000049 RID: 73
		public static char[] char_37 = new char[]
		{
			'ᔕ',
			'ᔼ',
			'ᕈ',
			'ᕅ',
			'ᕈ',
			'ᕋ',
			'ᔖ',
			'ᕐ',
			'ᕁ',
			'ᕂ',
			'ᕍ',
			'ᔾ',
			'ᔗ',
			'ᔥ',
			'ᗀ',
			'ᕂ',
			'ᓹ',
			'ᕑ',
			'ᖑ',
			'ᔼ',
			'ᓹ',
			'ᕍ',
			'ᕁ',
			'ᗒ',
			'ᔼ',
			'ᔓ',
			'ᓹ',
			'ᔢ',
			'ᔩ',
			'ᓹ',
			'ᕀ',
			'ᔺ',
			'ᕆ',
			'ᔾ',
			'ᓹ',
			'ᕄ',
			'ᕁ',
			'ᖑ',
			'ᔼ',
			'ᓹ',
			'ᕏ',
			'ᗆ',
			'ᕂ',
			'ᓹ',
			'ᔢ',
			'ᔩ',
			'ᓹ',
			'ᖇ',
			'ᖐ',
			'ᓹ',
			'ᖇ',
			'ᖁ',
			'ᕇ',
			'ᕀ',
			'ᓹ',
			'ᕄ',
			'ᗖ',
			'ᓹ',
			'ᕍ',
			'ᕋ',
			'ᕈ',
			'ᕇ',
			'ᕀ',
			'ᓹ',
			'ᕅ',
			'ᕂ',
			'ᔼ',
			'ᓹ',
			'ᔻ',
			'ᔺ',
			'ᕇ',
			'ᕀ',
			'ᓹ',
			'ᕁ',
			'ᗂ',
			'ᕂ',
			'ᔅ',
			'ᓹ',
			'ᕁ',
			'ᖐ',
			'ᕒ',
			'ᓹ',
			'ᕅ',
			'ᕂ',
			'ᖃ',
			'ᕇ',
			'ᓹ',
			'ᕁ',
			'ᖯ',
			'ᓹ',
			'ᔤ',
			'ᕂ',
			'ᕆ',
			'ᓹ',
			'ᔲ',
			'ᖮ',
			'ᕇ',
			'ᓹ',
			'ᖇ',
			'ᖬ',
			'ᓹ',
			'ᖇ',
			'ᕂ',
			'ᖫ',
			'ᕎ',
			'ᓹ',
			'ᔼ',
			'ᕁ',
			'ᖱ',
			'ᕇ',
			'ᕁ',
			'ᔇ'
		};

		// Token: 0x0400004A RID: 74
		public static char[] char_38 = new char[]
		{
			'ᓃ',
			'ᓪ',
			'ᓶ',
			'ᓳ',
			'ᓶ',
			'ᓹ',
			'ᓄ',
			'ᓾ',
			'ᓯ',
			'ᓰ',
			'ᓻ',
			'ᓬ',
			'ᓅ',
			'ᓈ',
			'ᓼ',
			'ᓻ',
			'ᓶ',
			'ᒧ',
			'ᔵ',
			'ᓨ',
			'ᓵ',
			'ᓮ',
			'ᒧ',
			'ᓪ',
			'ᓯ',
			'ᕀ',
			'ᔀ',
			'ᒵ',
			'ᒵ',
			'ᒵ'
		};

		// Token: 0x0400004B RID: 75
		public static char[] char_39 = new char[]
		{
			'ᓷ',
			'ᔀ',
			'ᔃ',
			'ᒱ',
			'ᒶ',
			'ᓲ',
			'ᒱ',
			'ᓺ',
			'ᓿ',
			'ᒱ',
			'ᒹ',
			'ᓷ',
			'ᒽ',
			'ᓶ',
			'ᒽ',
			'ᓵ',
			'ᒽ',
			'ᓴ',
			'ᒺ',
			'ᒱ',
			'ᓵ',
			'ᔀ',
			'ᒱ',
			'ᓵ',
			'ᓶ',
			'ᓽ',
			'ᒱ',
			'ᒶ',
			'ᓲ',
			'ᓋ',
			'ᓭ',
			'ᒻ',
			'ᒿ',
			'ᒻ',
			'ᓀ',
			'ᔄ',
			'ᓀ',
			'ᓷ',
			'ᓀ',
			'ᔂ'
		};

		// Token: 0x0400004C RID: 76
		public static char[] char_40 = new char[]
		{
			'ᔱ',
			'ᕆ',
			'ᕴ',
			'ᕸ',
			'ᕎ',
			'ᕭ',
			'ᕢ',
			'ᕱ',
			'ᕈ',
			'ᕅ',
			'ᕫ',
			'ᕰ',
			'ᕩ',
			'ᕉ',
			'ᔴ',
			'ᕔ',
			'ᕈ',
			'ᕻ',
			'ᕆ',
			'ᕊ',
			'ᕤ',
			'ᕗ',
			'ᕋ',
			'ᔳ',
			'ᕈ',
			'ᕌ',
			'ᕎ',
			'ᕤ',
			'ᕒ',
			'ᔲ',
			'ᕥ',
			'ᕪ',
			'ᕷ',
			'ᕪ',
			'ᕨ',
			'ᕫ',
			'ᕏ',
			'ᕕ',
			'ᔳ',
			'ᕄ',
			'ᕯ',
			'ᕶ',
			'ᔶ',
			'ᕱ',
			'ᕮ',
			'ᕆ',
			'ᕄ',
			'ᕅ',
			'ᕱ',
			'ᔸ',
			'ᕓ',
			'ᔵ',
			'ᕚ',
			'ᕘ',
			'ᕉ',
			'ᕔ',
			'ᕣ',
			'ᕬ',
			'ᕈ',
			'ᕤ',
			'ᕵ',
			'ᕪ',
			'ᕖ',
			'ᔰ',
			'ᕪ',
			'ᕈ',
			'ᕧ',
			'ᕬ',
			'ᕩ',
			'ᕏ',
			'ᕗ',
			'ᔶ',
			'ᕤ',
			'ᕦ',
			'ᔸ',
			'ᕫ',
			'ᕓ',
			'ᕘ',
			'ᕺ',
			'ᕛ',
			'ᕔ',
			'ᕈ',
			'ᔴ',
			'ᕊ',
			'ᕋ',
			'ᕘ',
			'ᕋ',
			'ᕋ',
			'ᕲ',
			'ᕛ',
			'ᔵ',
			'ᕺ',
			'ᕊ',
			'ᔱ',
			'ᕸ',
			'ᕖ',
			'ᕤ',
			'ᕻ',
			'ᕚ',
			'ᔶ',
			'ᕸ',
			'ᕂ',
			'ᕉ',
			'ᕹ',
			'ᕗ',
			'ᔷ',
			'ᕵ',
			'ᕳ',
			'ᕵ',
			'ᕳ',
			'ᕄ',
			'ᕴ',
			'ᕑ',
			'ᔹ',
			'ᔰ',
			'ᕉ',
			'ᕺ',
			'ᕒ',
			'ᕐ',
			'ᕚ',
			'ᕶ',
			'ᕅ',
			'ᕪ',
			'ᕮ',
			'ᔰ',
			'ᕹ',
			'ᕄ',
			'ᔶ',
			'ᕥ',
			'ᕘ',
			'ᕋ',
			'ᕗ',
			'ᕭ',
			'ᕴ',
			'ᕬ',
			'ᕋ',
			'ᕵ',
			'ᕤ',
			'ᕛ',
			'ᕒ',
			'ᕈ',
			'ᕰ',
			'ᕥ',
			'ᔲ',
			'ᔲ',
			'ᔴ',
			'ᔳ',
			'ᕐ',
			'ᕩ',
			'ᕸ',
			'ᔾ',
			'ᔾ'
		};

		// Token: 0x0400004D RID: 77
		public static string[] string_16 = null;

		// Token: 0x0400004E RID: 78
		public static bool bool_0 = false;

		// Token: 0x0400004F RID: 79
		public static uint uint_0 = 0U;

		// Token: 0x04000050 RID: 80
		public static uint uint_1 = 0U;

		// Token: 0x04000051 RID: 81
		public static int int_1 = 0;

		// Token: 0x04000052 RID: 82
		public static long long_0 = 0L;
	}
}
