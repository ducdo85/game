using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000068 RID: 104
	public partial class FormChayMuaMauTK : Form
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x001364A2 File Offset: 0x001346A2
		public FormChayMuaMauTK()
		{
			FormChayMuaMauTK.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x001364D4 File Offset: 0x001346D4
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00136BEC File Offset: 0x00134DEC
		private void FormChayMuaMauTK_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormChayMuaMauTK.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				int num2 = Class37.smethod_0(Form1.gstruct49_0[num]);
				bool flag2 = num2 != Class56.int_1 && Class56.smethod_0(num2) != null;
				if (flag2)
				{
					Class56.uint_0 = new uint[2];
					Class56.uint_1 = new uint[2];
					Class56.int_1 = 0;
					Class62.smethod_10(Class53.string_3, "CongHauDoanhNgoai_0", Class56.uint_0[0], "", 0);
					Class62.smethod_10(Class53.string_3, "CongHauDoanhNgoai_1", Class56.uint_0[1], "", 0);
					Class62.smethod_10(Class53.string_3, "CongHauDoanhTrong_0", Class56.uint_1[0], "", 0);
					Class62.smethod_10(Class53.string_3, "CongHauDoanhTrong_1", Class56.uint_1[1], "", 0);
					Class62.smethod_10(Class53.string_3, "MapIDCongTongKim", Class56.int_1, "", 0);
					Class62.smethod_10(Class53.string_3, "ThongTinMapTK", "", "", 0);
				}
			}
			this.textBoxText.Text = Class62.smethod_6("ThongTinMapTK", 0, "");
			this.textBoxCong1.Text = Class56.uint_0[0].ToString() + "," + Class56.uint_0[1].ToString();
			this.textBoxCong2.Text = Class56.uint_1[0].ToString() + "," + Class56.uint_1[1].ToString();
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00136E13 File Offset: 0x00135013
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormChayMuaMauTK.bool_0 = false;
			FormChayMuaMauTK.int_0 = 0;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00136E24 File Offset: 0x00135024
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormChayMuaMauTK.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00136E48 File Offset: 0x00135048
		private void buttonPhim_Click(object sender, EventArgs e)
		{
			string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(text);
			if (flag)
			{
				text = Class62.smethod_0();
			}
			Class22.smethod_40(text, "", FormVideoHelp.string_0, 0, false, false);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00136E92 File Offset: 0x00135092
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormChayMuaMauTK.bool_0 = false;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00136E9C File Offset: 0x0013509C
		private void buttonLay1_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormChayMuaMauTK.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				Class56.uint_0 = Class36.smethod_30(Form1.gstruct49_0[num]);
				bool flag2 = Class56.uint_0 == null;
				if (flag2)
				{
					Class56.uint_0 = new uint[2];
				}
				Class56.int_1 = Class37.smethod_0(Form1.gstruct49_0[num]);
				string text = Class10.smethod_1(Class37.smethod_2(Form1.gstruct49_0[num]), 1, false) + " (" + Class56.int_1.ToString() + ")";
				this.textBoxCong1.Text = Class56.uint_0[0].ToString() + "," + Class56.uint_0[1].ToString();
				this.textBoxText.Text = text;
				Class62.smethod_10(Class53.string_3, "CongHauDoanhNgoai_0", Class56.uint_0[0], "", 0);
				Class62.smethod_10(Class53.string_3, "CongHauDoanhNgoai_1", Class56.uint_0[1], "", 0);
				Class62.smethod_10(Class53.string_3, "MapIDCongTongKim", Class56.int_1, "", 0);
				Class62.smethod_10(Class53.string_3, "ThongTinMapTK", text, "", 0);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00136FFC File Offset: 0x001351FC
		private void buttonLay2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormChayMuaMauTK.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				Class56.uint_1 = Class36.smethod_30(Form1.gstruct49_0[num]);
				bool flag2 = Class56.uint_1 == null;
				if (flag2)
				{
					Class56.uint_1 = new uint[2];
				}
				Class56.int_1 = Class37.smethod_0(Form1.gstruct49_0[num]);
				string text = Class10.smethod_1(Class37.smethod_2(Form1.gstruct49_0[num]), 1, false) + " (" + Class56.int_1.ToString() + ")";
				this.textBoxCong2.Text = Class56.uint_1[0].ToString() + "," + Class56.uint_1[1].ToString();
				this.textBoxText.Text = text;
				Class62.smethod_10(Class53.string_3, "CongHauDoanhTrong_0", Class56.uint_1[0], "", 0);
				Class62.smethod_10(Class53.string_3, "CongHauDoanhTrong_1", Class56.uint_1[1], "", 0);
				Class62.smethod_10(Class53.string_3, "MapIDCongTongKim", Class56.int_1, "", 0);
				Class62.smethod_10(Class53.string_3, "ThongTinMapTK", text, "", 0);
			}
		}

		// Token: 0x040007F3 RID: 2035
		private IContainer icontainer_0 = null;

		// Token: 0x040007FF RID: 2047
		public static bool bool_0;

		// Token: 0x04000801 RID: 2049
		public static int int_0;
	}
}
