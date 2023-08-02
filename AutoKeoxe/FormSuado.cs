using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000082 RID: 130
	public partial class FormSuado : Form
	{
		// Token: 0x06000A98 RID: 2712 RVA: 0x00178CD9 File Offset: 0x00176ED9
		public FormSuado()
		{
			FormSuado.int_0 = 1;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00178D10 File Offset: 0x00176F10
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00179B3F File Offset: 0x00177D3F
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormSuado.int_0 = 0;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00179B48 File Offset: 0x00177D48
		private void FormSuado_Load(object sender, EventArgs e)
		{
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
			this.textBoxValueDobenThap.Text = Form1.int_80.ToString();
			this.checkBoxThodiaphuDobenThap.Checked = (Form1.int_81 > 0);
			this.checkBoxOutGameKhidobenThap.Checked = (Form1.int_79 > 0);
			this.checkBoxKhongSuaTK.Checked = (Form1.int_56 > 0);
			this.checkBoxOutGameKhidobenThap.Enabled = (Form1.int_81 > 0);
			this.checkBoxLuonSuaKhiMuathuoc.Checked = (Form1.int_57 > 0);
			this.checkBoxBachKim.Checked = (Form1.int_58 > 0);
			this.textBoxPhanTram.Text = Form1.int_60[0].ToString();
			this.textBoxDiem.Text = Form1.int_60[1].ToString();
			this.checkBoxPhiChiendau.Checked = (Form1.int_59 > 0);
			this.textBox1.Text = Form1.int_82.ToString();
			this.checkBoxPhimTat.Checked = (Form1.int_62 > 0);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			this.bool_0 = true;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00179CC4 File Offset: 0x00177EC4
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormSuado.int_0 == 0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00179CE8 File Offset: 0x00177EE8
		private void checkBoxThodiaphuDobenThap_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_0;
			if (flag)
			{
				Form1.int_81 = (int)Convert.ToByte(this.checkBoxThodiaphuDobenThap.Checked);
				Class62.smethod_10(Class53.string_3, "flagThodiaphuDobenThap", Form1.int_81, "", 0);
				this.checkBoxOutGameKhidobenThap.Enabled = (Form1.int_81 > 0);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00179D5C File Offset: 0x00177F5C
		private void textBoxValueDobenThap_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_0;
			if (flag)
			{
				Form1.int_80 = Class12.smethod_11(this.textBoxValueDobenThap.Text);
				bool flag2 = Form1.int_80 < 3;
				if (flag2)
				{
					Form1.int_80 = 3;
				}
				Class62.smethod_10(Class53.string_3, "nDobenThap", Form1.int_80, "", 0);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00179DD0 File Offset: 0x00177FD0
		private void checkBoxOutGameKhidobenThap_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_0;
				if (!flag)
				{
					Form1.int_79 = (int)Convert.ToByte(this.checkBoxOutGameKhidobenThap.Checked);
					Class62.smethod_10(Class53.string_3, "nDobenOut", Form1.int_79, "", 0);
				}
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00179E3C File Offset: 0x0017803C
		private void checkBoxKhongSuaTK_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_0;
			if (flag)
			{
				Form1.int_56 = (int)Convert.ToByte(this.checkBoxKhongSuaTK.Checked);
				Class62.smethod_10(Class53.string_3, "flagKhongSuaTK", Form1.int_56, "", 0);
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00179E9C File Offset: 0x0017809C
		private void checkBoxLuonSuaKhiMuathuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_0;
				if (!flag2)
				{
					Form1.int_57 = (int)Convert.ToByte(this.checkBoxLuonSuaKhiMuathuoc.Checked);
					Class62.smethod_10(Class53.string_3, "flagLuonSuaMua", Form1.int_57, "", 0);
				}
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00179F08 File Offset: 0x00178108
		private void checkBoxBachKim_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_0;
				if (!flag2)
				{
					Form1.int_58 = (int)Convert.ToByte(this.checkBoxBachKim.Checked);
					Class62.smethod_10(Class53.string_3, "flagSudoBachKim", Form1.int_58, "", 0);
				}
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00179F72 File Offset: 0x00178172
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormSuado.int_0 = 0;
			base.Close();
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00179F84 File Offset: 0x00178184
		private void textBoxPhanTram_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_0;
			if (flag)
			{
				Form1.int_60[0] = Class12.smethod_11(this.textBoxPhanTram.Text);
				bool flag2 = Form1.int_60[0] <= 10;
				if (flag2)
				{
					Form1.int_60[0] = 10;
				}
				Class62.smethod_10(Class53.string_3, "fSuado1_0", Form1.int_60[0], "", 0);
			}
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0017A004 File Offset: 0x00178204
		private void textBoxDiem_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_0;
				if (!flag)
				{
					Form1.int_60[1] = Class12.smethod_11(this.textBoxDiem.Text);
					bool flag2 = Form1.int_60[1] < 5;
					if (flag2)
					{
						Form1.int_60[1] = 5;
					}
					Class62.smethod_10(Class53.string_3, "fSuado1_1", Form1.int_60[1], "", 0);
				}
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0017A088 File Offset: 0x00178288
		private void textBoxDiem_Leave(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_0;
				if (!flag)
				{
					Form1.int_60[1] = Class12.smethod_11(this.textBoxDiem.Text);
					bool flag2 = Form1.int_60[1] < 5;
					if (flag2)
					{
						Form1.int_60[1] = 5;
						this.textBoxDiem.Text = "5";
					}
				}
			}
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0017A100 File Offset: 0x00178300
		private void checkBoxPhiChiendau_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_0;
				if (!flag)
				{
					Form1.int_59 = (int)Convert.ToByte(this.checkBoxPhiChiendau.Checked);
					Class62.smethod_10(Class53.string_3, "fSuaPhichiendau", Form1.int_59, "", 0);
				}
			}
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0017A16C File Offset: 0x0017836C
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Form1.int_82 = Class12.smethod_11(this.textBox1.Text);
			bool flag = Form1.int_82 < 10;
			if (flag)
			{
				Form1.int_82 = 10;
			}
			else
			{
				bool flag2 = Form1.int_82 > 180;
				if (flag2)
				{
					Form1.int_82 = 180;
				}
			}
			Class62.smethod_10(Class53.string_3, "ThoigianSua", Form1.int_82, "", 0);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0017A1E4 File Offset: 0x001783E4
		private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_0;
			if (flag)
			{
				Form1.int_62 = (int)Convert.ToByte(this.checkBoxPhimTat.Checked);
				Class62.smethod_10(Class53.string_3, "flagPhimTatSuado", Form1.int_62, "", 0);
			}
		}

		// Token: 0x04000BA7 RID: 2983
		private IContainer icontainer_0 = null;

		// Token: 0x04000BBB RID: 3003
		public static int int_0;

		// Token: 0x04000BBD RID: 3005
		private bool bool_0 = false;
	}
}
