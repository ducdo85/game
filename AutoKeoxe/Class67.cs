using System;
using System.IO;
using System.Net;

namespace AutoKeoxe
{
	// Token: 0x02000041 RID: 65
	internal class Class67
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x000B4A98 File Offset: 0x000B2C98
		public static FileInfo smethod_0(string string_0, string string_1)
		{
			string value = "drive.google.com";
			string value2 = "https://drive.google.com";
			bool flag = !string_0.StartsWith(value) && !string_0.StartsWith(value2);
			FileInfo result;
			if (flag)
			{
				result = Class67.smethod_1(string_0, string_1, null);
			}
			else
			{
				result = Class67.smethod_2(string_0, string_1);
			}
			return result;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000B4AE4 File Offset: 0x000B2CE4
		private static FileInfo smethod_1(string string_0, string string_1, WebClient webClient_0)
		{
			FileInfo result;
			try
			{
				bool flag = webClient_0 == null;
				if (flag)
				{
					WebClient webClient;
					webClient_0 = (webClient = new WebClient());
					try
					{
						webClient_0.DownloadFile(string_0, string_1);
						return new FileInfo(string_1);
					}
					finally
					{
						if (webClient != null)
						{
							((IDisposable)webClient).Dispose();
						}
					}
				}
				webClient_0.DownloadFile(string_0, string_1);
				result = new FileInfo(string_1);
			}
			catch (WebException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000B4B58 File Offset: 0x000B2D58
		private static FileInfo smethod_2(string string_0, string string_1)
		{
			string_0 = Class67.smethod_3(string_0);
			FileInfo result;
			using (GClass2 gclass = new GClass2())
			{
				int num = 0;
				FileInfo fileInfo;
				for (;;)
				{
					bool flag = num < 2;
					if (!flag)
					{
						goto IL_138;
					}
					fileInfo = Class67.smethod_1(string_0, string_1, gclass);
					bool flag2 = fileInfo == null;
					if (flag2)
					{
						break;
					}
					bool flag3 = fileInfo.Length <= 60000L;
					if (!flag3)
					{
						goto IL_133;
					}
					string text;
					using (StreamReader streamReader = fileInfo.OpenText())
					{
						char[] array = new char[20];
						int num2 = streamReader.ReadBlock(array, 0, 20);
						bool flag4 = num2 < 20 || !new string(array).Contains("<!DOCTYPE html>");
						if (flag4)
						{
							return fileInfo;
						}
						text = streamReader.ReadToEnd();
					}
					int num3 = text.LastIndexOf("href=\"/uc?");
					bool flag5 = num3 >= 0;
					if (!flag5)
					{
						goto IL_12E;
					}
					num3 += 6;
					int num4 = text.IndexOf('"', num3);
					bool flag6 = num4 >= 0;
					if (!flag6)
					{
						goto IL_129;
					}
					string_0 = "https://drive.google.com" + text.Substring(num3, num4 - num3).Replace("&amp;", "&");
					num++;
				}
				return null;
				IL_129:
				return fileInfo;
				IL_12E:
				return fileInfo;
				IL_133:
				return fileInfo;
				IL_138:
				result = Class67.smethod_1(string_0, string_1, gclass);
			}
			return result;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000B4CF8 File Offset: 0x000B2EF8
		private static string smethod_3(string string_0)
		{
			int num = string_0.IndexOf("id=");
			bool flag = num <= 0;
			int num2;
			if (flag)
			{
				num = string_0.IndexOf("file/d/");
				bool flag2 = num < 0;
				if (flag2)
				{
					return string.Empty;
				}
				num += 7;
				num2 = string_0.IndexOf('/', num);
				bool flag3 = num2 < 0;
				if (flag3)
				{
					num2 = string_0.IndexOf('?', num);
					bool flag4 = num2 < 0;
					if (flag4)
					{
						num2 = string_0.Length;
					}
				}
			}
			else
			{
				num += 3;
				num2 = string_0.IndexOf('&', num);
				bool flag5 = num2 < 0;
				if (flag5)
				{
					num2 = string_0.Length;
				}
			}
			return "https://drive.google.com/uc?id=" + string_0.Substring(num, num2 - num) + "&export=download";
		}
	}
}
