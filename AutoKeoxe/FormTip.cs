using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000089 RID: 137
	public partial class FormTip : Form
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x00188BB8 File Offset: 0x00186DB8
		public FormTip()
		{
			FormTip.bool_0 = !FormTip.bool_0;
			this.InitializeComponent();
			this.webBrowser1 = new WebBrowser();
			this.webBrowser1.Location = this.richTextBoxStatus.Location;
			this.webBrowser1.MinimumSize = this.richTextBoxStatus.MaximumSize;
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = this.richTextBoxStatus.Size;
			this.webBrowser1.TabIndex = 5;
			base.Controls.Add(this.webBrowser1);
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00188CE4 File Offset: 0x00186EE4
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00189150 File Offset: 0x00187350
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTip.bool_0 = false;
			this.bool_2 = false;
			this.string_0 = null;
			this.string_2 = null;
			this.int_4 = -1;
			this.string_1 = null;
			this.int_5 = 0;
			this.int_6 = 0;
			this.bool_5 = false;
			this.bool_6 = false;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x001891A4 File Offset: 0x001873A4
		private void FormTip_Load(object sender, EventArgs e)
		{
			bool webLoad = this.WebLoad;
			if (webLoad)
			{
				this.richTextBoxStatus.Visible = false;
				bool flag = this.bool_4;
				if (flag)
				{
					this.buttonDong.Visible = false;
					bool flag2 = this.int_5 <= 0;
					if (flag2)
					{
						this.int_5 = 281;
					}
					bool flag3 = this.int_6 <= 0;
					if (flag3)
					{
						this.int_6 = 130;
					}
					this.webBrowser1.Width = this.int_5 - 7;
					this.webBrowser1.Height = this.int_6 - 27;
					this.webBrowser1.Top = 0;
					this.webBrowser1.Left = 0;
					base.Width = this.int_5;
					bool flag4 = !this.bool_5;
					if (flag4)
					{
						base.Height = this.int_6 + 2;
					}
					else
					{
						base.Height = this.int_6 + 30;
						this.buttonCopy.Top = this.richTextBoxStatus.Top + this.richTextBoxStatus.Height + 5;
						this.buttonCopy.Left = (base.Width - this.buttonCopy.Width) / 2;
					}
				}
				else
				{
					base.StartPosition = FormStartPosition.CenterScreen;
				}
				bool flag5 = this.int_0 > 0 && this.int_1 > 0;
				if (flag5)
				{
					this.checkBoxKhongHienthi.Visible = false;
					int num = this.int_0 - base.Width - 5;
					int num2 = this.int_1 - base.Height - 5;
					bool flag6 = num < 0;
					if (flag6)
					{
						num = 0;
					}
					bool flag7 = num2 < 0;
					if (flag7)
					{
						num2 = 0;
					}
					base.SetBounds(num, num2, base.Width, base.Height);
				}
				int maxValue = Class104.string_1.Length;
				this.webBrowser1.Url = new Uri(Class12.smethod_71(Class104.string_1[new Random().Next(0, maxValue)]) + this.LinkWeb, UriKind.Absolute);
			}
			else
			{
				base.Hide();
				this.buttonCopy.Visible = this.bool_5;
				bool flag8 = this.bool_4;
				if (flag8)
				{
					this.buttonDong.Visible = false;
					bool flag9 = this.int_5 <= 0;
					if (flag9)
					{
						this.int_5 = 281;
					}
					bool flag10 = this.int_6 <= 0;
					if (flag10)
					{
						this.int_6 = 130;
					}
					this.richTextBoxStatus.Width = this.int_5 - 7;
					this.richTextBoxStatus.Height = this.int_6 - 27;
					this.richTextBoxStatus.Top = 0;
					this.richTextBoxStatus.Left = 0;
					this.richTextBoxStatus.Font = new Font("Verdana", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					base.Width = this.int_5;
					bool flag11 = !this.bool_5;
					if (flag11)
					{
						base.Height = this.int_6 + 2;
					}
					else
					{
						base.Height = this.int_6 + 30;
						this.buttonCopy.Top = this.richTextBoxStatus.Top + this.richTextBoxStatus.Height + 5;
						this.buttonCopy.Left = (base.Width - this.buttonCopy.Width) / 2;
					}
				}
				else
				{
					base.StartPosition = FormStartPosition.CenterScreen;
				}
				bool flag12 = this.int_0 > 0 && this.int_1 > 0;
				if (flag12)
				{
					this.checkBoxKhongHienthi.Visible = false;
					int num3 = this.int_0 - base.Width - 5;
					int num4 = this.int_1 - base.Height - 5;
					bool flag13 = num3 < 0;
					if (flag13)
					{
						num3 = 0;
					}
					bool flag14 = num4 < 0;
					if (flag14)
					{
						num4 = 0;
					}
					base.SetBounds(num3, num4, base.Width, base.Height);
				}
				bool flag15 = this.string_0 != null;
				if (flag15)
				{
					string text = this.string_0;
					bool flag16 = !this.bool_2;
					if (flag16)
					{
						text = text.Replace("|", Class53.string_7).Replace("\\n", Class53.string_7).Replace("\\t", '\t'.ToString());
					}
					this.richTextBoxStatus.Text = text;
				}
			}
			this.checkBoxKhongHienthi.Enabled = !this.bool_1;
			this.richTextBoxStatus.WordWrap = !this.bool_3;
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			FormTip.long_0 = Class12.smethod_27();
			bool flag17 = this.string_1 != null;
			if (flag17)
			{
				this.Text = this.string_1;
			}
			this.string_3 = this.Text;
			base.TopMost = true;
			base.Show();
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonDong_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0018968C File Offset: 0x0018788C
		private void checkBoxKhongHienthi_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = Form1.string_7 == null;
			if (flag)
			{
				Form1.string_7 = string.Empty;
			}
			string str = "Không hiện bảng thông báo này nữa";
			string str2 = string.Empty;
			bool flag2 = !this.checkBoxKhongHienthi.Checked;
			if (flag2)
			{
				bool flag3 = this.string_2 != null && this.string_2 != string.Empty;
				if (flag3)
				{
					Class62.smethod_10(Class53.string_3, this.string_2, string.Empty, "", 0);
				}
				else
				{
					Class62.smethod_10(Class53.string_3, "UpdateNew", 0, "", 0);
				}
			}
			else
			{
				bool flag4 = this.string_2 != null && this.string_2 != string.Empty;
				if (flag4)
				{
					Class62.smethod_10(Class53.string_3, this.string_2, this.string_0, "", 0);
				}
				else
				{
					Class62.smethod_10(Class53.string_3, "UpdateNew", this.string_0.Length, "", 0);
				}
				str2 = " (có thể xem lại ở Phụ trợ - Phim)";
			}
			this.checkBoxKhongHienthi.Text = str + str2;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x001897B0 File Offset: 0x001879B0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormTip.bool_0;
			if (flag)
			{
				bool flag2 = this.int_4 > 0;
				if (flag2)
				{
					long num = (long)this.int_4 - Class12.smethod_28(FormTip.long_0);
					this.Text = this.string_3 + " (" + (num / 1000L).ToString() + "s)";
					bool flag3 = num < 0L;
					if (flag3)
					{
						base.Close();
					}
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00189834 File Offset: 0x00187A34
		public static void smethod_0(string string_4, string string_5, int int_7 = 60000, int int_8 = 345, int int_9 = 200, bool bool_7 = false, int int_10 = -1, int int_11 = -1, bool bool_8 = false, bool bool_9 = false, bool bool_10 = false)
		{
			bool flag = int_8 < 0;
			if (flag)
			{
				int_8 = 345;
			}
			bool flag2 = int_9 < 0;
			if (flag2)
			{
				int_9 = 200;
			}
			bool flag3 = int_7 < 0;
			if (flag3)
			{
				int_7 = 60000;
			}
			FormTip formTip = new FormTip();
			formTip.string_0 = string_5;
			formTip.bool_2 = bool_10;
			bool flag4 = int_10 >= 0 && int_11 >= 0;
			if (flag4)
			{
				formTip.int_0 = int_10 + 5;
				formTip.int_1 = int_11 + int_9 + 5;
			}
			else
			{
				formTip.int_0 = Cursor.Position.X;
				formTip.int_1 = Cursor.Position.Y;
			}
			formTip.bool_5 = bool_8;
			formTip.bool_6 = bool_9;
			formTip.int_2 = Form1.int_46[0];
			formTip.int_3 = Form1.int_46[1];
			formTip.bool_4 = true;
			formTip.bool_3 = bool_7;
			formTip.int_5 = int_8;
			formTip.int_6 = int_9;
			formTip.int_4 = int_7;
			formTip.string_1 = string_4;
			formTip.Show();
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00189940 File Offset: 0x00187B40
		private void buttonCopy_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.richTextBoxStatus.Text;
				bool flag = text.IndexOf("\r") < 0;
				if (flag)
				{
					text = text.Replace("\n", "\r\n");
				}
				bool flag2 = this.bool_6;
				if (flag2)
				{
					text = text + "\r\nSign: " + Class12.smethod_16(text);
				}
				Clipboard.SetText(text);
			}
			catch
			{
			}
		}

		// Token: 0x04000CC0 RID: 3264
		private IContainer icontainer_0 = null;

		// Token: 0x04000CC6 RID: 3270
		public static bool bool_0;

		// Token: 0x04000CC7 RID: 3271
		public bool bool_1 = false;

		// Token: 0x04000CC8 RID: 3272
		public bool bool_2 = false;

		// Token: 0x04000CC9 RID: 3273
		public string string_0 = null;

		// Token: 0x04000CCA RID: 3274
		public string string_1 = null;

		// Token: 0x04000CCB RID: 3275
		public string string_2 = null;

		// Token: 0x04000CCC RID: 3276
		public int int_0;

		// Token: 0x04000CCD RID: 3277
		public int int_1;

		// Token: 0x04000CCE RID: 3278
		public int int_2;

		// Token: 0x04000CCF RID: 3279
		public int int_3;

		// Token: 0x04000CD0 RID: 3280
		public int int_4 = 0;

		// Token: 0x04000CD1 RID: 3281
		public bool bool_3 = false;

		// Token: 0x04000CD2 RID: 3282
		public bool bool_4 = false;

		// Token: 0x04000CD3 RID: 3283
		public int int_5 = 0;

		// Token: 0x04000CD4 RID: 3284
		public int int_6 = 0;

		// Token: 0x04000CD5 RID: 3285
		public bool bool_5 = false;

		// Token: 0x04000CD6 RID: 3286
		public bool bool_6 = false;

		// Token: 0x04000CD7 RID: 3287
		public bool WebLoad = false;

		// Token: 0x04000CD8 RID: 3288
		public string LinkWeb = null;

		// Token: 0x04000CD9 RID: 3289
		private string string_3 = null;

		// Token: 0x04000CDB RID: 3291
		private static long long_0;

		// Token: 0x04000CDC RID: 3292
		private WebBrowser webBrowser1;
	}
}
