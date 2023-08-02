using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006A RID: 106
	public partial class FormCompatibility : Form
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0013C469 File Offset: 0x0013A669
		public FormCompatibility()
		{
			FormCompatibility.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0013C498 File Offset: 0x0013A698
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0013D344 File Offset: 0x0013B544
		public static string[] smethod_0()
		{
			try
			{
				return FormCompatibility.smethod_1();
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0013D378 File Offset: 0x0013B578
		private static string[] smethod_1()
		{
			OperatingSystem osversion = Environment.OSVersion;
			Version version = osversion.Version;
			string[] array = new string[]
			{
				string.Empty,
				string.Empty
			};
			bool flag = osversion.Platform != PlatformID.Win32Windows;
			if (flag)
			{
				bool flag2 = osversion.Platform == PlatformID.Win32NT;
				if (flag2)
				{
					switch (version.Major)
					{
					case 3:
						array[0] = "NT3.51";
						break;
					case 4:
						array[0] = "NT4.0";
						break;
					case 5:
					{
						bool flag3 = version.Minor == 0;
						if (flag3)
						{
							array[0] = "2000";
						}
						else
						{
							array[0] = "XP";
						}
						break;
					}
					case 6:
					{
						bool flag4 = version.Minor == 0;
						if (flag4)
						{
							array[0] = "VISTA";
						}
						else
						{
							bool flag5 = version.Minor != 1;
							if (flag5)
							{
								bool flag6 = version.Minor == 2;
								if (flag6)
								{
									array[0] = "8";
								}
								else
								{
									array[0] = "8.1";
								}
							}
							else
							{
								array[0] = "7";
							}
						}
						break;
					}
					case 10:
						array[0] = "10";
						break;
					}
				}
			}
			else
			{
				int minor = version.Minor;
				int num = minor;
				if (num != 0)
				{
					if (num != 10)
					{
						if (num == 90)
						{
							array[0] = "ME";
						}
					}
					else
					{
						bool flag7 = !(version.Revision.ToString() == "2222A");
						if (flag7)
						{
							array[0] = "98";
						}
						else
						{
							array[0] = "98SE";
						}
					}
				}
				else
				{
					array[0] = "95";
				}
			}
			bool flag8 = array[0] != string.Empty;
			if (flag8)
			{
				array[1] = "Windows " + array[0];
				bool flag9 = osversion.ServicePack != "";
				if (flag9)
				{
					string[] array2;
					(array2 = array)[1] = array2[1] + " " + osversion.ServicePack;
				}
			}
			return array;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0013D580 File Offset: 0x0013B780
		public static bool smethod_2(string[] string_4)
		{
			return string_4 != null && string_4[0] != "10" && string_4[0] != "8.1" && string_4[0] != "8" && string_4[0] != "7" && string_4[0] != "VISTA";
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0013D5E1 File Offset: 0x0013B7E1
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormCompatibility.bool_0 = false;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0013D5EC File Offset: 0x0013B7EC
		private void FormCompatibility_Load(object sender, EventArgs e)
		{
			bool flag = this.int_0 > 0 && this.int_1 > 0;
			if (flag)
			{
				int num = this.int_0 - base.Width - 10;
				int num2 = this.int_1 - base.Height - 10;
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
			try
			{
				FormCompatibility.string_0 = FormCompatibility.smethod_0();
			}
			catch
			{
			}
			bool flag4 = FormCompatibility.string_0 == null || !(FormCompatibility.string_0[0] != string.Empty);
			if (flag4)
			{
				this.textBoxPhienBan.Text = "Không xác định";
			}
			else
			{
				this.textBoxPhienBan.Text = FormCompatibility.string_0[1];
			}
			int num3 = 0;
			byte[] array = new byte[2];
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array, 2, ref num3);
			this.textBoxThongso.Text = string.Concat(new string[]
			{
				"[ ",
				array[0].ToString(),
				".",
				array[1].ToString(),
				" ]"
			});
			bool flag5 = Form1.gstruct49_0 != null;
			if (flag5)
			{
				byte[] array2 = new byte[4];
				string text = string.Empty;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class22.ReadProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_20 + Class66.uint_0, array2, 4, ref num3);
					int num4 = BitConverter.ToInt32(array2, 0);
					Class22.ReadProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_20, array2, 4, ref num3);
					int num5 = BitConverter.ToInt32(array2, 0);
					bool flag6 = num4 > 0;
					if (flag6)
					{
						bool flag7 = text != null && text != string.Empty;
						if (flag7)
						{
							text += Class53.string_7;
						}
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							Class12.smethod_45(Form1.gstruct49_0[i].uint_20, 8, false, true),
							": ",
							Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false),
							" có tổng ",
							num4,
							" lỗi game, ",
							num5,
							" lần fix."
						});
					}
					Class83.smethod_40(Form1.gstruct49_0[i]);
				}
				bool flag8 = text != null && text != string.Empty;
				if (flag8)
				{
					this.richTextBox1.Text = text;
				}
			}
			this.method_0();
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0013D928 File Offset: 0x0013BB28
		private void method_0()
		{
			this.listView1.Items.Clear();
			string[] array = null;
			string[] array2 = null;
			string string_ = "ᓌᓤᓬᒫᒩᒨᒧᓃᓤᓙᓚᓑ";
			string string_2 = "ᒼᓛᓐᓒ";
			string text = Class12.smethod_53(FormCompatibility.string_1);
			string[] array3 = new string[]
			{
				text.Replace(Class12.smethod_53(string_2), ""),
				text,
				text.Replace(Class12.smethod_53(string_), "").Replace(Class12.smethod_53(string_2), ""),
				text.Replace(Class12.smethod_53(string_), "")
			};
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < array3.Length; j++)
				{
					string[] array4 = Class62.smethod_9(array3[j], i > 0, true, 0);
					bool flag = array4 == null;
					if (!flag)
					{
						for (int k = 0; k < array4.Length; k++)
						{
							bool flag2 = array2 == null;
							if (flag2)
							{
								array2 = new string[1];
							}
							else
							{
								Array.Resize<string>(ref array2, array2.Length + 1);
							}
							array2[array2.Length - 1] = array4[k];
						}
					}
				}
			}
			bool flag3 = FormCompatibility.string_3 == null || FormCompatibility.string_3 == string.Empty;
			if (flag3)
			{
				StringBuilder stringBuilder = new StringBuilder(260);
				Class22.SHGetSpecialFolderPath(IntPtr.Zero, stringBuilder, 22, false);
				FormCompatibility.string_3 = stringBuilder.ToString();
			}
			bool flag4 = FormCompatibility.string_3 != null && FormCompatibility.string_3 != string.Empty;
			if (flag4)
			{
				array = Directory.GetFiles(FormCompatibility.string_3 + "\\Programs\\Startup", "*.*");
			}
			Color foreColor = Color.Black;
			bool flag5 = array != null && array.Length != 0;
			if (flag5)
			{
				for (int l = 0; l < array.Length; l++)
				{
					string[] array5 = array[l].Split(new char[]
					{
						'\\'
					});
					string[] string_3 = new string[]
					{
						array5[array5.Length - 1],
						array[l]
					};
					this.method_1(string_3);
				}
				foreColor = Color.DarkBlue;
			}
			bool flag6 = array2 != null && array2.Length != 0;
			if (flag6)
			{
				for (int m = 0; m < array2.Length; m++)
				{
					string[] array6 = array2[m].Split(new char[]
					{
						'\\'
					});
					string[] string_4 = new string[]
					{
						array6[array6.Length - 1],
						array2[m]
					};
					this.method_1(string_4);
					this.listView1.Items[this.listView1.Items.Count - 1].ForeColor = foreColor;
				}
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0013DBEC File Offset: 0x0013BDEC
		private void method_1(string[] string_4)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem((this.listView1.Items.Count + 1).ToString());
				for (int i = 0; i < string_4.Length; i++)
				{
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, string_4[i]));
				}
				this.listView1.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0013DC70 File Offset: 0x0013BE70
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormCompatibility.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0013DC94 File Offset: 0x0013BE94
		private static void smethod_3(string string_4, string string_5, bool bool_1 = true)
		{
			try
			{
				string text = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
				bool flag = !bool_1;
				if (flag)
				{
					Class62.smethod_12(text, string_4, 0);
					Class62.smethod_12(text, string_4, 1);
				}
				else
				{
					Class62.smethod_10(text, string_4, string_5, "", 0);
					Class62.smethod_10(text, string_4, string_5, "", 1);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0013DD00 File Offset: 0x0013BF00
		private void buttonFix_Click(object sender, EventArgs e)
		{
			string string_ = string.Empty;
			bool flag = FormCompatibility.string_0 != null && FormCompatibility.string_0[0] != string.Empty && (FormCompatibility.string_0[0] == "10" || FormCompatibility.string_0[0] == "8.1" || FormCompatibility.string_0[0] == "8");
			if (flag)
			{
				string_ = "16BITCOLOR";
			}
			string text = null;
			int[] array = Class22.smethod_24(Class53.string_21, null, false);
			bool flag2 = array != null && array.Length != 0;
			if (flag2)
			{
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						Process processById = Process.GetProcessById(array[i]);
						text = processById.MainModule.FileName;
						string a = Class62.smethod_6("PathGame", 0, "");
						bool flag3 = text != null && text != string.Empty;
						if (flag3)
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
				}
			}
			bool flag5 = text == null || text == string.Empty;
			if (flag5)
			{
				text = Class62.smethod_6("PathGame", 0, "");
				bool flag6 = text == null || text == string.Empty || !Class12.smethod_17(text);
				if (flag6)
				{
					this.richTextBox1.Text = "Hãy mở 1 cửa sổ game lên trước khi bấm nút Fix này.";
					return;
				}
			}
			FormCompatibility.smethod_3(text, string_, true);
			string[] array2 = Class12.smethod_14(text, '\\');
			string string_2 = array2[0] + "\\config.ini";
			bool flag7 = Class12.smethod_17(string_2);
			if (flag7)
			{
				string text2 = Class12.smethod_33(string_2, 0, 0, 1);
				string[] array3 = text2.Split(new char[]
				{
					'\r',
					'\n'
				});
				string text3 = string.Empty;
				for (int j = 0; j < array3.Length; j++)
				{
					bool flag8 = array3[j].ToLower().IndexOf("epresent") > 0;
					if (flag8)
					{
						text3 = array3[j];
						break;
					}
				}
				text2 = ((!(text3 != string.Empty)) ? Class12.smethod_71("NYoxC8IwFAb392skolum1LoIBkNxKB0e5cME0md4Rqn/3nRwuztuDNAPdKIzL9jYP7Xaw9EY6iCJ89/3RKPLCVIncizXAhk03yPktKZqd9S/cw6zAtLkhqJ4tdka6n1opfsKL2m+pEfcbsfFc432Bw==") : text2.Replace(text3, "Represent=2"));
				Class12.smethod_34(string_2, text2, 1);
			}
			this.richTextBox1.Text = "Đã chuyển game sang chạy ở chế độ 16bit";
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0013DF98 File Offset: 0x0013C198
		private void buttonDefender_Click(object sender, EventArgs e)
		{
			string str = "SOFTWARE\\Policies\\Microsoft\\Windows Defender";
			Class62.smethod_10(str, "DisableAntiSpyware", 1, "DWORD", 0);
			Class62.smethod_10(str, "DisableAntiSpyware", 1, "DWORD", 1);
			this.richTextBox1.Text = "Đã tắt Windows Denfender, khởi động lại máy tính mới có hiệu lực. Nếu muốn khôi phục thì xóa nhánh sau trong registry:" + Class53.string_7 + str;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0013DFF8 File Offset: 0x0013C1F8
		private static int smethod_4(string string_4, int int_4)
		{
			ServiceController serviceController = new ServiceController(string_4);
			try
			{
				TimeSpan timeout = TimeSpan.FromMilliseconds((double)int_4);
				string text = serviceController.Status.ToString().ToUpper();
				bool flag = text.IndexOf("STOP") < 0;
				if (flag)
				{
					serviceController.Stop();
					serviceController.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
				}
				return 1;
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0013E078 File Offset: 0x0013C278
		public static int smethod_5()
		{
			try
			{
				bool flag = FormCompatibility.string_0 == null;
				if (flag)
				{
					FormCompatibility.string_0 = FormCompatibility.smethod_0();
				}
			}
			catch
			{
			}
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = "Firewall set opmode disable";
				process.StartInfo.FileName = "netsh.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
			catch
			{
			}
			bool flag2 = FormCompatibility.string_0 != null && !(FormCompatibility.string_0[0] == string.Empty);
			int result;
			if (flag2)
			{
				bool flag3 = !(FormCompatibility.string_0[0] == "7") && !(FormCompatibility.string_0[0] == "VISTA");
				if (flag3)
				{
					bool flag4 = !(FormCompatibility.string_0[0] != "10") || !(FormCompatibility.string_0[0] != "8.1") || !(FormCompatibility.string_0[0] != "8");
					if (flag4)
					{
						result = 0;
					}
					else
					{
						result = FormCompatibility.smethod_4("ShareAccess", 10000);
					}
				}
				else
				{
					result = FormCompatibility.smethod_4("MpsSvc", 10000);
				}
			}
			else
			{
				FormCompatibility.smethod_4("MpsSvc", 10000);
				result = FormCompatibility.smethod_4("ShareAccess", 10000);
			}
			return result;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0013E210 File Offset: 0x0013C410
		private void method_2(string string_4, string string_5)
		{
			bool flag = string_4 == null || string_4 == string.Empty;
			if (!flag)
			{
				bool flag2 = string_4[1] == ':';
				if (flag2)
				{
					string processName = string_5.ToUpper().Replace(".EXE", "");
					Process[] processesByName = Process.GetProcessesByName(processName);
					bool flag3 = processesByName != null && processesByName.Length != 0;
					if (flag3)
					{
						for (int i = 0; i < processesByName.Length; i++)
						{
							Class22.smethod_53(processesByName[i]);
						}
						Thread.Sleep(600);
					}
					Class12.smethod_20(string_4);
					Class12.smethod_17(string_4);
				}
				else
				{
					string[] array = Class12.smethod_14(string_4, '\\');
					Class62.smethod_12(array[0], array[1], 3);
				}
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0013E2D8 File Offset: 0x0013C4D8
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count != 0;
			if (flag)
			{
				int index = this.listView1.SelectedIndices[0];
				string text = this.listView1.Items[index].SubItems[2].Text;
				string text2 = this.listView1.Items[index].SubItems[1].Text;
				this.listView1.Items.RemoveAt(index);
				this.method_2(text, text2);
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0013E370 File Offset: 0x0013C570
		private void buttonOpen_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count == 0;
			if (!flag)
			{
				int index = this.listView1.SelectedIndices[0];
				string text = this.listView1.Items[index].SubItems[2].Text;
				bool flag2 = text == null || text == string.Empty;
				if (!flag2)
				{
					string[] array = Class12.smethod_14(text, '\\');
					bool flag3 = text[1] != ':';
					if (flag3)
					{
						bool flag4 = array.Length > 1;
						if (flag4)
						{
							Class62.smethod_14(array[0]);
						}
					}
					else
					{
						Class22.smethod_40("explorer.exe", "", array[0], 0, false, false);
					}
				}
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0013E433 File Offset: 0x0013C633
		private void buttonReFresh_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0013E440 File Offset: 0x0013C640
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count != 0;
			if (flag)
			{
				this.textBoxItem.Text = this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[2].Text;
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0013E4A4 File Offset: 0x0013C6A4
		private void buttonXoahet_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.Items == null || this.listView1.Items.Count == 0;
			if (!flag)
			{
				string text = "Bạn chắc chắn muốn xóa hết tất cả ?";
				bool flag2 = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) != DialogResult.No;
				if (flag2)
				{
					string[] array = new string[this.listView1.Items.Count];
					string[] array2 = new string[this.listView1.Items.Count];
					for (int i = 0; i < this.listView1.Items.Count; i++)
					{
						array[i] = this.listView1.Items[i].SubItems[2].Text;
						array2[i] = this.listView1.Items[i].SubItems[1].Text;
					}
					this.listView1.Items.Clear();
					for (int j = 0; j < array.Length; j++)
					{
						this.method_2(array[j], array2[j]);
					}
				}
			}
		}

		// Token: 0x04000834 RID: 2100
		private IContainer icontainer_0 = null;

		// Token: 0x0400084A RID: 2122
		public int int_0;

		// Token: 0x0400084B RID: 2123
		public int int_1;

		// Token: 0x0400084C RID: 2124
		public int int_2;

		// Token: 0x0400084D RID: 2125
		public int int_3;

		// Token: 0x0400084E RID: 2126
		public static bool bool_0 = false;

		// Token: 0x0400084F RID: 2127
		public static string[] string_0 = null;

		// Token: 0x04000850 RID: 2128
		public static string string_1 = "ᓹᓵᓬᓺᓽᓧᓸᓫᔂᓽᔕᔝᓜᓚᓙᓘᓴᔕᔊᔋᔂᓳᔏᔉᔘᔕᔙᔕᔌᔚᔂᓽᔏᔔᔊᔕᔝᔙᔂᓩᔛᔘᔘᔋᔔᔚᓼᔋᔘᔙᔏᔕᔔᔂᓸᔛᔔᓵᔔᔉᔋ";

		// Token: 0x04000851 RID: 2129
		public static string string_2 = "ᔃᔟᔖᔤᔧᔑᔢᔕᔌᓽᔙᔓᔢᔟᔣᔟᔖᔤᔌᔇᔙᔞᔔᔟᔧᔣᔌᓳᔥᔢᔢᔕᔞᔤᔆᔕᔢᔣᔙᔟᔞᔌᔀᔟᔜᔙᔓᔙᔕᔣᔌᓵᔨᔠᔜᔟᔢᔕᔢᔌᓴᔙᔣᔑᔜᔜᔟᔧᔂᔥᔞ";

		// Token: 0x04000853 RID: 2131
		private static string string_3 = null;
	}
}
