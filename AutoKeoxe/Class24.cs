using System;
using System.IO;
using System.Net;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000016 RID: 22
	internal class Class24
	{
		// Token: 0x06000132 RID: 306 RVA: 0x000160C8 File Offset: 0x000142C8
		public static void smethod_0()
		{
			int num = 0;
			for (;;)
			{
				try
				{
					Class24.smethod_1();
					break;
				}
				catch
				{
					Thread.Sleep(300);
					num++;
					bool flag = num < 3;
					if (!flag)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00016118 File Offset: 0x00014318
		public static void smethod_1()
		{
			bool flag = Class24.string_0 == null || Class24.string_0.Length == 0;
			if (!flag)
			{
				int num = 0;
				GStruct14[] array = new GStruct14[Class24.string_0.Length];
				for (int i = 0; i < Class24.string_0.Length; i++)
				{
					string text = Class24.string_0[i];
					bool flag2 = text == null || text == string.Empty;
					if (!flag2)
					{
						string[] array2 = text.Split(new char[]
						{
							'|'
						});
						bool flag3 = array2[0] == string.Empty || array2[0] == null;
						if (!flag3)
						{
							array[num].string_1 = array2[0];
							array[num].string_2 = null;
							array[num].int_1 = 30000;
							bool flag4 = array2.Length > 1;
							if (flag4)
							{
								array[num].string_2 = array2[1];
							}
							bool flag5 = array2.Length > 2 && array2[2] != null && array2[2] != string.Empty;
							if (flag5)
							{
								string[] array3 = array2[2].Split(new char[]
								{
									'.',
									'/',
									'-'
								});
								bool flag6 = array3.Length == 3;
								if (flag6)
								{
									int num2 = Class12.smethod_11(array3[0]);
									int num3 = Class12.smethod_11(array3[1]);
									int num4 = Class12.smethod_11(array3[2]);
									bool flag7 = 0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0;
									if (flag7)
									{
										long ticks = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
										array[num].long_0 = ticks;
										array[num].bool_0 = (GClass1.long_1 > ticks);
									}
									array[num].string_3 = array2[2];
								}
							}
							bool flag8 = array2.Length > 3 && array2[3] != null && array2[3] != string.Empty;
							if (flag8)
							{
								int num5 = Class12.smethod_11(array2[3]);
								bool flag9 = num5 > 0;
								if (flag9)
								{
									array[num].int_1 = num5;
								}
							}
							array[num].int_0 = Class12.smethod_11(array[num].string_2);
							bool flag10 = array[num].int_0 <= 0;
							if (flag10)
							{
								array[num].string_0 = Class24.smethod_4(array[num].string_1);
								bool flag11 = array[num].string_0 == null;
								if (flag11)
								{
									goto IL_286;
								}
							}
							num++;
						}
					}
					IL_286:;
				}
				bool flag12 = num > 0;
				if (flag12)
				{
					Class24.gstruct14_0 = new GStruct14[num];
					for (int j = 0; j < num; j++)
					{
						Class24.gstruct14_0[j].string_0 = array[j].string_0;
						Class24.gstruct14_0[j].string_1 = array[j].string_1;
						Class24.gstruct14_0[j].string_2 = array[j].string_2;
						Class24.gstruct14_0[j].long_0 = array[j].long_0;
						Class24.gstruct14_0[j].int_0 = array[j].int_0;
						Class24.gstruct14_0[j].bool_0 = array[j].bool_0;
						Class24.gstruct14_0[j].string_3 = array[j].string_3;
						Class24.gstruct14_0[j].int_1 = array[j].int_1;
					}
				}
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000164EC File Offset: 0x000146EC
		private static byte[] smethod_2(string string_1, int int_0 = 15000)
		{
			try
			{
				Uri requestUri = new Uri(string_1);
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
				httpWebRequest.Timeout = int_0;
				httpWebRequest.ReadWriteTimeout = int_0;
				HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				MemoryStream memoryStream = new MemoryStream();
				httpWebResponse.GetResponseStream().CopyTo(memoryStream);
				return memoryStream.ToArray();
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00016564 File Offset: 0x00014764
		private static byte[] smethod_3(string string_1)
		{
			try
			{
				WebClient webClient = new WebClient();
				Uri address = new Uri(string_1);
				byte[] result = webClient.DownloadData(address);
				webClient.CancelAsync();
				return result;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000165B0 File Offset: 0x000147B0
		private static string smethod_4(string string_1)
		{
			string text = null;
			try
			{
				byte[] array = Class24.smethod_2(string_1, 15000);
				bool flag = array == null || array.Length == 0;
				if (flag)
				{
					array = Class24.smethod_3(string_1);
				}
				bool flag2 = array != null && array.Length != 0;
				if (flag2)
				{
					string text2 = Path.GetTempPath();
					bool flag3 = text2 == null;
					if (flag3)
					{
						text2 = Class53.string_10;
					}
					while (text2 != null && text2 != string.Empty && (text2[text2.Length - 1] == '\\' || text2[text2.Length - 1] == '/'))
					{
						text2 = text2.Substring(0, text2.Length - 1);
					}
					string[] array2 = string_1.Split(new char[]
					{
						'/',
						'\\'
					});
					text = text2 + "\\" + array2[array2.Length - 1];
					Class12.smethod_50(text, array);
				}
			}
			catch
			{
			}
			return text;
		}

		// Token: 0x04000097 RID: 151
		public static string[] string_0;

		// Token: 0x04000098 RID: 152
		public static GStruct14[] gstruct14_0;
	}
}
