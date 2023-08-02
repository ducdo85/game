using System;
using System.Text;

namespace AutoKeoxe
{
	// Token: 0x02000003 RID: 3
	internal class Class10
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000205C File Offset: 0x0000025C
		static Class10()
		{
			Class10.char_1 = new char[256];
			for (int i = 0; i < 256; i++)
			{
				Class10.char_1[i] = (char)i;
			}
			for (int j = 0; j < Class10.char_2.Length; j++)
			{
				Class10.char_1[(int)Class10.char_2[j]] = Class10.char_3[j];
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002104 File Offset: 0x00000304
		public static bool smethod_0(char char_4)
		{
			for (int i = 0; i < Class10.char_0.Length; i++)
			{
				bool flag = char_4 == Class10.char_0[i];
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002144 File Offset: 0x00000344
		public static string smethod_1(string string_0, byte byte_0 = 1, bool bool_0 = false)
		{
			bool flag = string_0 != null && !(string_0 == string.Empty);
			string result;
			if (flag)
			{
				bool flag2 = byte_0 <= 0;
				if (flag2)
				{
					Class10.char_1[217] = 'Ù';
				}
				else
				{
					Class10.char_1[217] = '\u00a0';
				}
				char[] array = string_0.ToCharArray();
				for (int i = 0; i < array.Length; i++)
				{
					bool flag3 = array[i] < 'Ā';
					if (flag3)
					{
						bool flag4 = array[i] != Class10.char_1[(int)array[i]];
						if (flag4)
						{
							array[i] = Class10.char_1[(int)array[i]];
						}
						else
						{
							bool flag5 = bool_0 && (byte)array[i] > 127;
							if (flag5)
							{
								array[i] = ' ';
							}
						}
					}
				}
				result = new string(array);
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002220 File Offset: 0x00000420
		public static string smethod_2(string string_0)
		{
			char[] array = string_0.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = array[i] <= '\u007f';
				if (!flag)
				{
					for (int j = 0; j < Class10.char_3.Length; j++)
					{
						bool flag2 = array[i] == Class10.char_3[j];
						if (flag2)
						{
							array[i] = Class10.char_2[j];
							break;
						}
					}
				}
			}
			return new string(array);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022A0 File Offset: 0x000004A0
		public static string smethod_3(byte[] byte_0)
		{
			int num = Array.IndexOf<byte>(byte_0, 0);
			num = ((num < 0) ? byte_0.Length : num);
			string text = Encoding.UTF7.GetString(byte_0, 0, num);
			bool flag = text == null;
			if (flag)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022E4 File Offset: 0x000004E4
		public static string smethod_4(byte[] byte_0)
		{
			bool flag = byte_0 != null && byte_0.Length != 0;
			string result;
			if (flag)
			{
				int num = byte_0.Length;
				int i = 0;
				string text = string.Empty;
				while (i < num)
				{
					int num2 = (int)byte_0[i] + (int)byte_0[i + 1] * 256;
					bool flag2 = num2 == 0;
					if (flag2)
					{
						break;
					}
					text += ((char)num2).ToString();
					i += 2;
				}
				result = text;
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002364 File Offset: 0x00000564
		public static string[] smethod_5(ref string[] string_0, bool bool_0)
		{
			bool flag = string_0 != null && string_0.Length != 0;
			string[] result;
			if (flag)
			{
				string[] array = new string[string_0.Length];
				for (int i = 0; i < string_0.Length; i++)
				{
					bool flag2 = string_0[i] == null;
					if (flag2)
					{
						string_0[i] = string.Empty;
					}
					else
					{
						string_0[i] = string_0[i].Trim();
					}
					array[i] = Class10.smethod_1(string_0[i], 1, false);
					if (bool_0)
					{
						array[i] = array[i].ToUpper();
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

		// Token: 0x04000001 RID: 1
		public static char[] char_0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzàáảãạăằắẳẵặâầấẩẫậđèéẻẽẹêềếểễệìíỉĩịòóỏõọôồốổỗộơờớởỡợùúủũụưừứửữựỳýỷỹỵĂÂĐÊÔƠƯÙ".ToCharArray();

		// Token: 0x04000002 RID: 2
		private static char[] char_1;

		// Token: 0x04000003 RID: 3
		private static char[] char_2 = new char[]
		{
			'µ',
			'¸',
			'¶',
			'·',
			'¹',
			'¨',
			'»',
			'¾',
			'¼',
			'½',
			'Æ',
			'©',
			'Ç',
			'Ê',
			'È',
			'É',
			'Ë',
			'®',
			'Ì',
			'Ð',
			'Î',
			'Ï',
			'Ñ',
			'ª',
			'Ò',
			'Õ',
			'Ó',
			'Ô',
			'Ö',
			'×',
			'Ý',
			'Ø',
			'Ü',
			'Þ',
			'ß',
			'ã',
			'á',
			'â',
			'ä',
			'«',
			'å',
			'è',
			'æ',
			'ç',
			'é',
			'¬',
			'ê',
			'í',
			'ë',
			'ì',
			'î',
			'ï',
			'ó',
			'ñ',
			'ò',
			'ô',
			'­',
			'õ',
			'ø',
			'ö',
			'÷',
			'ù',
			'ú',
			'ý',
			'û',
			'ü',
			'þ',
			'¡',
			'¢',
			'§',
			'£',
			'¤',
			'¥',
			'¦',
			'Ù'
		};

		// Token: 0x04000004 RID: 4
		private static char[] char_3 = new char[]
		{
			'à',
			'á',
			'ả',
			'ã',
			'ạ',
			'ă',
			'ằ',
			'ắ',
			'ẳ',
			'ẵ',
			'ặ',
			'â',
			'ầ',
			'ấ',
			'ẩ',
			'ẫ',
			'ậ',
			'đ',
			'è',
			'é',
			'ẻ',
			'ẽ',
			'ẹ',
			'ê',
			'ề',
			'ế',
			'ể',
			'ễ',
			'ệ',
			'ì',
			'í',
			'ỉ',
			'ĩ',
			'ị',
			'ò',
			'ó',
			'ỏ',
			'õ',
			'ọ',
			'ô',
			'ồ',
			'ố',
			'ổ',
			'ỗ',
			'ộ',
			'ơ',
			'ờ',
			'ớ',
			'ở',
			'ỡ',
			'ợ',
			'ù',
			'ú',
			'ủ',
			'ũ',
			'ụ',
			'ư',
			'ừ',
			'ứ',
			'ử',
			'ữ',
			'ự',
			'ỳ',
			'ý',
			'ỷ',
			'ỹ',
			'ỵ',
			'Ă',
			'Â',
			'Đ',
			'Ê',
			'Ô',
			'Ơ',
			'Ư',
			'Ù'
		};
	}
}
