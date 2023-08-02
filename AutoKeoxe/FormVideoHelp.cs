using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008E RID: 142
	public partial class FormVideoHelp : Form
	{
		// Token: 0x06000BA9 RID: 2985 RVA: 0x00192330 File Offset: 0x00190530
		public FormVideoHelp()
		{
			FormVideoHelp.bool_0 = true;
			this.InitializeComponent();
			this.bool_1 = (FormVideoHelp.string_4 != null);
			bool flag = !this.bool_1;
			if (flag)
			{
				new Thread(new ThreadStart(this.method_0)).Start();
			}
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x001923AC File Offset: 0x001905AC
		public void method_0()
		{
			Uri address = new Uri(FormVideoHelp.string_3);
			WebClient webClient = new WebClient();
			string[] array = null;
			try
			{
				byte[] array2 = webClient.DownloadData(address);
				bool flag = array2 != null;
				if (flag)
				{
					string @string = Encoding.Unicode.GetString(array2, 0, array2.Length);
					array = @string.Split(new char[]
					{
						'\r',
						'\n'
					});
				}
			}
			catch
			{
			}
			webClient.CancelAsync();
			bool flag2 = array == null;
			if (!flag2)
			{
				string[] array3 = new string[array.Length];
				string[] array4 = new string[array.Length];
				int num = 0;
				for (int i = 0; i < array.Length; i++)
				{
					bool flag3 = array[i] != null && !(array[i] == string.Empty);
					if (flag3)
					{
						string[] array5 = array[i].Split(new char[]
						{
							'|'
						});
						bool flag4 = array5.Length == 2;
						if (flag4)
						{
							array3[num] = array5[0];
							array4[num] = array5[1];
							num++;
						}
					}
				}
				bool flag5 = num != 0;
				if (flag5)
				{
					FormVideoHelp.string_4 = new string[num, 2];
					for (int j = 0; j < num; j++)
					{
						FormVideoHelp.string_4[j, 0] = array3[j];
						FormVideoHelp.string_4[j, 1] = array4[j];
					}
					this.bool_1 = true;
				}
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00192528 File Offset: 0x00190728
		private void FormVideoHelp_Load(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			bool flag = this.int_0 >= 0 && this.int_1 >= 0;
			if (flag)
			{
				int num = this.int_0 - base.Width;
				int num2 = this.int_1 + this.int_3 - base.Height;
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
			this.string_1 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag4 = !Class12.smethod_17(this.string_1);
			if (flag4)
			{
				this.string_1 = Class62.smethod_0();
			}
			for (int i = 0; i < FormVideoHelp.string_2.GetLength(0); i++)
			{
				this.method_1(this.listView1, FormVideoHelp.string_2[i, 0] + "|" + FormVideoHelp.string_2[i, 1]);
				bool flag5 = i <= 1;
				if (flag5)
				{
					this.listView1.Items[i].ForeColor = Color.Blue;
				}
			}
			this.listView1.Items[0].Selected = true;
			this.textBoxDienGiai.Text = this.listView1.Items[0].SubItems[1].Text;
			this.textBoxLink.Text = this.listView1.Items[0].SubItems[2].Text;
			this.timer_0.Interval = 100;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x001926FB File Offset: 0x001908FB
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.bool_1 = false;
			FormVideoHelp.bool_0 = false;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0019270C File Offset: 0x0019090C
		private void method_1(ListView listView_0, string string_6)
		{
			try
			{
				string str = "0";
				bool flag = listView_0.Items != null;
				if (flag)
				{
					str = listView_0.Items.Count.ToString();
				}
				string[] array = (str + "|" + string_6).Split(new char[]
				{
					'|'
				});
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag2 = array.Length > 1;
				if (flag2)
				{
					for (int i = 1; i < array.Length; i++)
					{
						ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
						listViewItem.SubItems.Add(item);
					}
				}
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x001927D0 File Offset: 0x001909D0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormVideoHelp.bool_0;
			if (flag)
			{
				bool flag2 = this.bool_1 && FormVideoHelp.string_4 != null;
				if (flag2)
				{
					this.bool_1 = false;
					for (int i = 0; i < FormVideoHelp.string_4.GetLength(0); i++)
					{
						this.method_1(this.listView1, FormVideoHelp.string_4[i, 0] + "|" + FormVideoHelp.string_4[i, 1]);
					}
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00192860 File Offset: 0x00190A60
		private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_10 = (int)Convert.ToByte(this.checkBoxKhongHienthi.Checked);
				Class62.smethod_10(Class53.string_3, "KhongHienThiVideoHelp", Form1.int_10, "", 0);
				bool flag = Form1.int_10 > 0;
				if (flag)
				{
					this.checkBoxKhongHienthi.Text = "Xem lại thì vào Phụ trợ của auto bấm nút Phim hướng dẫn";
				}
				else
				{
					this.checkBoxKhongHienthi.Text = "Không hiển thị bảng hướng dẫn này nữa.";
				}
			}
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x001928E4 File Offset: 0x00190AE4
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			string str = FormVideoHelp.string_5;
			bool flag = GClass1.string_2 != null && GClass1.string_2 != string.Empty;
			if (flag)
			{
				str = str + "|==============================================|LƯU Ý:||" + GClass1.string_2;
			}
			bool flag2 = Form1.string_7 != null && Form1.string_7 != string.Empty;
			if (flag2)
			{
				str = str + "|==============================================|PHIÊN BẢN MỚI:||" + Form1.string_7;
			}
			FormTip.smethod_0(Form1.string_1, str, 600000, 450, 540, false, Form1.int_46[2], Form1.int_46[3], false, false, false);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00192981 File Offset: 0x00190B81
		private void linkLabelLinkWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Class22.smethod_40(this.string_1, "", "http://canhtrang.com/", 0, false, false);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x001929A0 File Offset: 0x00190BA0
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.SelectedIndices == null;
			if (!flag)
			{
				bool flag2 = this.listView1.SelectedIndices.Count == 0;
				if (!flag2)
				{
					int index = this.listView1.SelectedIndices[0];
					this.textBoxDienGiai.Text = this.listView1.Items[index].SubItems[1].Text;
					this.textBoxLink.Text = this.listView1.Items[index].SubItems[2].Text;
				}
			}
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x00192A50 File Offset: 0x00190C50
		private void buttonCopy_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices == null;
			if (!flag)
			{
				bool flag2 = this.listView1.SelectedIndices.Count == 0;
				if (!flag2)
				{
					try
					{
						Clipboard.SetText(this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[2].Text);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x00192AE0 File Offset: 0x00190CE0
		private void buttonXem_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices != null;
			if (flag)
			{
				bool flag2 = this.listView1.SelectedIndices.Count == 0;
				if (!flag2)
				{
					string text = this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[2].Text;
					Class22.smethod_40(this.string_1, "", text, 0, false, false);
				}
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00192B6C File Offset: 0x00190D6C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00193500 File Offset: 0x00191700
		// Note: this type is marked as 'beforefieldinit'.
		static FormVideoHelp()
		{
			string[,] array = new string[14, 2];
			array[0, 0] = "Hướng dẫn chung về cài đặt và sử dụng";
			array[0, 1] = "https://youtu.be/5H9Ita4GE9k";
			array[1, 0] = "Hướng dẫn tự tìm Web của game";
			array[1, 1] = "https://youtu.be/Rpk5_QNsA3g";
			array[2, 0] = "Hướng dẫn bơm thuốc phục hồi (hậu cần)";
			array[2, 1] = "http://keoxe365.net/phuchoi.htm";
			array[3, 0] = "Hướng dẫn nhồi thuốc (hậu cần - nút nhồi thuốc)";
			array[3, 1] = "https://youtu.be/1duqVxbJRKk";
			array[4, 0] = "Phim Kéo xe nhiều máy liên máy (nút mở rộng - bảng 1)";
			array[4, 1] = "https://youtu.be/5UU-GeLlKZI";
			array[5, 0] = "Phim đánh chiến trường CTC (thất thành)";
			array[5, 1] = "https://youtu.be/5H9Ita4GE9k?t=473";
			array[6, 0] = "Phim đánh chiến trường CTC (tam trụ)";
			array[6, 1] = "https://youtu.be/NHJWNV6zKJI";
			array[7, 0] = "Hướng dẫn click NPC, lọc kiếm đồ HK + xanh ngon. ăn các Event ...";
			array[7, 1] = "https://youtu.be/Dup5PcJOV5Y";
			array[8, 0] = "Phim chạy nhím chế tạo huyền tinh";
			array[8, 1] = "https://youtu.be/GP7cr4qJIHA";
			array[9, 0] = "Cách Tinh luyện, nâng cấp huyền tinh";
			array[9, 1] = "https://youtu.be/LLMBuNwXzLw";
			array[10, 0] = "Chuyển thuốc từ rương bang hội ra hành trang";
			array[10, 1] = "https://youtu.be/XRljjxiuyk8";
			array[11, 0] = "Hướng dẫn sử dụng auto Login (phần phụ trợ)";
			array[11, 1] = "https://youtu.be/U8VlHTvbIyU";
			array[12, 0] = "Tống Kim chạy về mua máu khi hết máu";
			array[12, 1] = FormVideoHelp.string_0;
			array[13, 0] = "Hướng dẫn làm trạng thái phi chiến đấu";
			array[13, 1] = "https://youtu.be/dDYR4Al3LIg";
			FormVideoHelp.string_2 = array;
			FormVideoHelp.string_3 = "http://keoxe365.net/kykeoxe/phimhuongdan_kykeoxe.txt";
			FormVideoHelp.string_4 = null;
			FormVideoHelp.string_5 = Class12.smethod_71("lVRNT9tAEL37V8wxkVJTrpF6oJFQpfQD9UMIVT04azdeJV6nZE3CGVWoQhXlWHEhIIQoRNBSCdUW4rAp/8P/pDOzdjDH5mDZzux7M++9cXutHcTjAGptGcFant4qaJvTGMZB3XHe5NkU/Dw7Vl2Y7d1d5tmRABHGEObpSULXWw3CTAR0vSiAfp5O8a3Ms20FOk8n0oWXWJNgzRWYG+hJJpjtmStE7JqrAYylAqk68Rj60vxQiJltw7yXpvMIljtNCLUeDJsLC6PRyP3oiaATxz1XxNGCl+jY7cloM1BYuhoUtVhqX7oq0I7zIk+vBdLm2Y4KoRdKiPJsX8KwMt8wT2+gbw6gi00eRdBaeUdVpwIWoRaZA2zNnONpnhSfE8QLVL1h5+/gtIquxxEsLz5mri18znZLPMVCREme7SnHeX53mbAiofmN5IpG980fvBVhgtcN7o+mo5KJaMCGOefOq1XryKdpgM/gy+GQe3OdJ//1c5w2ogpzIKnp9FpbVvTyRPEbNFqzNbUwZh2xtzMPkoHv6YAp66BRm0KDAabiSMKnxAPtdaBFwFSEQqG3XxWMgg7iejzE3URCzSpTKEFJKdFQS9/8ogOYxRbJrEPJmaOkDZgKmyTcC2uJMocJa79r/ZyH1kwGpdFWOkqxZvkE9gueEIWTDyksNjkNxfTMw55U2ajuS5VlnSQrabIzvEUK14qNo13oUttKBhvF0IVQkUf85crgPwnUVpdel4203rbqLjzlE5qqBthQquH90ocifp7vIysm5yBuwNBLePFKdI822UxV2IBxTPnXUvS4FjS5rUJzqNDrdKoLODyYTjbLlbb12pxH91DWufvH2R6FClVq0Eu0KzsufZFYG8TcEaoy+0YE44CxFPWAq7NjQ11Jg53v1XI5IB3wPSQaoh1hZcZ+3CUDMV1sbKGY+Hs6TxgdL1eJt1zNtvABD+IHSeTZiWf3wBKhhT/59rutKcBtcvmLMO8Xp1kJ8fsVUvL2sdzP0zPF2QqrZjdL63BJVlgZvY5RrXCXcSjMZdRnD1Bd5x8=");
		}

		// Token: 0x04000D67 RID: 3431
		public int int_0;

		// Token: 0x04000D68 RID: 3432
		public int int_1;

		// Token: 0x04000D69 RID: 3433
		public int int_2;

		// Token: 0x04000D6A RID: 3434
		public int int_3;

		// Token: 0x04000D6B RID: 3435
		public static bool bool_0 = false;

		// Token: 0x04000D6C RID: 3436
		public static string string_0 = "https://youtu.be/D7jHTsNEwYU";

		// Token: 0x04000D6D RID: 3437
		private string string_1 = null;

		// Token: 0x04000D6E RID: 3438
		private static string[,] string_2;

		// Token: 0x04000D6F RID: 3439
		private static string string_3;

		// Token: 0x04000D70 RID: 3440
		private static string[,] string_4;

		// Token: 0x04000D71 RID: 3441
		private bool bool_1 = false;

		// Token: 0x04000D72 RID: 3442
		public static string string_5;

		// Token: 0x04000D73 RID: 3443
		private IContainer icontainer_0 = null;
	}
}
