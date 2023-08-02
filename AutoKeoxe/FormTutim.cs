using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008A RID: 138
	public partial class FormTutim : Form
	{
		// Token: 0x06000B53 RID: 2899 RVA: 0x001899BC File Offset: 0x00187BBC
		public FormTutim()
		{
			FormTutim.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00189A1C File Offset: 0x00187C1C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0018A1C6 File Offset: 0x001883C6
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTutim.bool_0 = false;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0018A1D0 File Offset: 0x001883D0
		private void FormTutim_Load(object sender, EventArgs e)
		{
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
			int num3 = -1;
			for (int i = 0; i < Form1.string_4.GetLength(0); i++)
			{
				this.method_0(this.listView1, Form1.string_4[i, 0]);
				bool flag4 = Form1.string_3 == Form1.string_4[i, 0];
				if (flag4)
				{
					num3 = this.listView1.Items.Count - 1;
				}
			}
			bool flag5 = 0 <= num3;
			if (flag5)
			{
				this.listView1.Items[num3].ForeColor = Color.Blue;
				this.listView1.Items[num3].Selected = true;
			}
			string text = "Nếu không tìm được WEB trong danh sách, thì tự làm như sau||1. Bỏ check tên ac phụ trên auto.|2. Đem ac chính lên bản đồ khó đi nào đó.|3. Chọn web XXX nào đó, ví dụ XXX là " + Form1.string_4[0, 0] + "|4. Check lại tên ac phụ, để ac phụ tiến hành tìm ac chính.||Nếu ac phụ đi Thần Hành phù lên được chỗ ac chính thì quá tốt, dừng lại, THP của web đang chọn là dùng được, ta chọn web đó.||Nếu ac phụ không đi được Thần Hành phù, thì tiếp tục làm lại bước 3. ";
			this.richTextBox1.Text = text.Replace("|", Class53.string_7);
			this.textBoxTukhoa.Text = Form1.string_11;
			Thread.Sleep(300);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0018A37C File Offset: 0x0018857C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTutim.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0018A3A0 File Offset: 0x001885A0
		private void method_0(ListView listView_0, string string_0)
		{
			try
			{
				string text = "1";
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				bool flag = listView_0.Items != null;
				if (flag)
				{
					text = (listView_0.Items.Count + 1).ToString();
				}
				ListViewItem listViewItem = new ListViewItem(text);
				bool flag2 = array.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < array.Length; i++)
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

		// Token: 0x06000B5A RID: 2906 RVA: 0x0018A458 File Offset: 0x00188658
		private void method_1(ListView listView_0, int int_6)
		{
			bool flag = this.int_4 <= 0 && listView_0.Items.Count > 0;
			if (flag)
			{
				this.int_4 = listView_0.Height / (listView_0.GetItemRect(0).Height + 1);
			}
			bool flag2 = this.int_4 > 0 && (listView_0.TopItem.Index + this.int_4 <= int_6 || int_6 < listView_0.TopItem.Index);
			if (flag2)
			{
				listView_0.TopItem = listView_0.Items[int_6];
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0018A4EC File Offset: 0x001886EC
		private void method_2()
		{
			string text = this.textBoxTukhoa.Text;
			bool flag = text == null || text == string.Empty || this.listView1.Items.Count <= 0;
			if (!flag)
			{
				string[] array = text.ToUpper().Split(new char[]
				{
					'_',
					' ',
					'/',
					':'
				});
				int num = 0;
				bool flag2 = this.int_5 > 0;
				if (flag2)
				{
					num = this.int_5 + 1;
				}
				bool flag3 = false;
				int i;
				for (;;)
				{
					for (i = num; i < this.listView1.Items.Count; i++)
					{
						for (int j = 0; j < this.listView1.Items[i].SubItems.Count; j++)
						{
							string text2 = this.listView1.Items[i].SubItems[j].Text.ToUpper();
							foreach (string text in array)
							{
								bool flag4 = text == null || text == string.Empty;
								if (!flag4)
								{
									bool flag5 = text.IndexOf(".") > 0;
									if (flag5)
									{
										text = text.Split(new char[]
										{
											'.'
										})[0];
									}
									bool flag6 = text != null && !(text == string.Empty);
									if (flag6)
									{
										text = text.ToUpper();
										bool flag7 = !(text == "HTTP") && !(text == "HTTPS") && 0 <= text2.IndexOf(text);
										if (flag7)
										{
											goto Block_12;
										}
									}
								}
							}
						}
					}
					bool flag8 = flag3 || num <= 0;
					if (flag8)
					{
						goto Block_17;
					}
					num = 0;
					flag3 = true;
				}
				Block_12:
				this.method_1(this.listView1, i);
				this.method_3(i);
				return;
				Block_17:
				Class12.smethod_61(this.richTextBox1, "Không tìm thấy \"" + this.textBoxTukhoa.Text + "\"", false);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0018A730 File Offset: 0x00188930
		private void buttonChonWeb_Click(object sender, EventArgs e)
		{
			bool flag = this.int_5 >= 0 && Form1.int_0 != this.int_5;
			if (flag)
			{
				Form1.int_0 = this.int_5;
				base.Close();
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0018A772 File Offset: 0x00188972
		private void buttonTim_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0018A77C File Offset: 0x0018897C
		private void textBoxTukhoa_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.timer_0.Enabled && e.KeyCode == Keys.Return;
			if (flag)
			{
				this.method_2();
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0018A7B0 File Offset: 0x001889B0
		private void method_3(int int_6)
		{
			bool flag = 0 <= this.int_5 && this.int_5 < this.listView1.Items.Count;
			if (flag)
			{
				this.listView1.Items[this.int_5].BackColor = this.color_0;
				this.listView1.Items[this.int_5].ForeColor = this.color_1;
			}
			bool flag2 = 0 <= int_6 && int_6 < this.listView1.Items.Count;
			if (flag2)
			{
				this.color_0 = this.listView1.Items[int_6].BackColor;
				this.color_1 = this.listView1.Items[int_6].ForeColor;
				this.listView1.Items[int_6].BackColor = Color.Green;
				this.listView1.Items[int_6].ForeColor = Color.Yellow;
				this.int_5 = int_6;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0018A8C4 File Offset: 0x00188AC4
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count != 0;
			if (flag)
			{
				this.method_3(this.listView1.SelectedIndices[0]);
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0018A904 File Offset: 0x00188B04
		private void buttonHuongdan_Click(object sender, EventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			string string_2 = "https://youtu.be/Rpk5_QNsA3g";
			Class22.smethod_40(string_, "", string_2, 0, false, false);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0018A940 File Offset: 0x00188B40
		private void textBoxTukhoa_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.string_11 = this.textBoxTukhoa.Text;
				Class62.smethod_10(Class53.string_3, "textFindWeb", Form1.string_11, "", 0);
			}
		}

		// Token: 0x04000CDD RID: 3293
		private IContainer icontainer_0 = null;

		// Token: 0x04000CE9 RID: 3305
		public static bool bool_0;

		// Token: 0x04000CEA RID: 3306
		public int int_0;

		// Token: 0x04000CEB RID: 3307
		public int int_1;

		// Token: 0x04000CEC RID: 3308
		public int int_2;

		// Token: 0x04000CED RID: 3309
		public int int_3;

		// Token: 0x04000CEE RID: 3310
		private int int_4 = -1;

		// Token: 0x04000CEF RID: 3311
		private int int_5 = -1;

		// Token: 0x04000CF0 RID: 3312
		private Color color_0 = default(Color);

		// Token: 0x04000CF2 RID: 3314
		private Color color_1 = default(Color);
	}
}
