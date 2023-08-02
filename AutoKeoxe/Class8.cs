using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace AutoKeoxe
{
	// Token: 0x0200004E RID: 78
	internal class Class8
	{
		// Token: 0x060004D7 RID: 1239 RVA: 0x000DC9F8 File Offset: 0x000DABF8
		public void method_0()
		{
			try
			{
				string text = Class12.smethod_71(this.string_0);
				string text2 = string.Empty;
				string text3 = Class12.smethod_53(Class12.string_5);
				string text4 = Class12.smethod_53(Class12.string_7);
				string text5 = Class12.smethod_53(Class12.string_2);
				string text6 = Class12.smethod_53(Class12.string_4);
				bool flag = text[0] != text4[0];
				if (flag)
				{
					TcpClient tcpClient = new TcpClient(text, 13);
					StreamReader streamReader = new StreamReader(tcpClient.GetStream());
					string text7 = streamReader.ReadToEnd();
					tcpClient.Close();
					bool flag2 = text7.Length > 24;
					if (flag2)
					{
						text2 = ((Class12.smethod_1(text7.ToUpper(), Class12.smethod_0(Class12.char_27)) <= 0) ? Convert.ToDateTime(text7.Substring(0, 20)).ToString(Class12.smethod_0(Class12.char_28)) : text7.Substring(7, 17));
					}
				}
				else
				{
					WebClient webClient = new WebClient();
					byte[] array = webClient.DownloadData(Class12.smethod_0(Class12.char_12) + text.Substring(1));
					string @string = Encoding.Default.GetString(array, 0, array.Length);
					string text8 = @string.Substring(Class12.smethod_1(@string, Class12.smethod_0(Class12.char_13)) + 12);
					string text9 = text8.Substring(0, Class12.smethod_1(text8, "<")).Replace(" ", "");
					string[] array2 = text9.Split(new char[]
					{
						text6[0],
						text5[0],
						text4[0],
						text3[0]
					});
					bool flag3 = array2.Length == 6;
					if (flag3)
					{
						bool flag4 = array2[2].Length > 2;
						if (flag4)
						{
							int length = array2[2].Length;
							array2[2] = array2[2].Substring(length - 2);
						}
						text2 = string.Concat(new string[]
						{
							array2[2],
							text3,
							array2[1],
							text3,
							array2[0],
							" ",
							array2[3],
							text4,
							array2[4],
							text4,
							array2[5]
						});
					}
					webClient.CancelAsync();
				}
				bool flag5 = text2 != null && text2 != string.Empty;
				if (flag5)
				{
					Console.WriteLine(text2);
					Console.WriteLine(Class12.smethod_0(Class12.char_28));
					CultureInfo cultureInfo = new CultureInfo(CultureInfo.CurrentCulture.Name);
					cultureInfo.Calendar.TwoDigitYearMax = 2099;
					DateTime dateTime = DateTime.ParseExact(text2, Class12.smethod_0(Class12.char_28), cultureInfo, DateTimeStyles.AssumeUniversal);
					Console.WriteLine(dateTime.Ticks);
					bool flag6 = GClass1.long_1 < dateTime.Ticks;
					if (flag6)
					{
						GClass1.long_1 = dateTime.Ticks;
					}
					Console.WriteLine(GClass1.long_1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x040003B3 RID: 947
		public string string_0 = null;
	}
}
