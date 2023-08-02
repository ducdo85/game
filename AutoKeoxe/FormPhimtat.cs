using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007C RID: 124
	public partial class FormPhimtat : Form
	{
		// Token: 0x060009EF RID: 2543 RVA: 0x001694FD File Offset: 0x001676FD
		public FormPhimtat()
		{
			FormPhimtat.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0016952C File Offset: 0x0016772C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00169B03 File Offset: 0x00167D03
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormPhimtat.bool_0 = false;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00169B0C File Offset: 0x00167D0C
		private void FormPhimtat_Load(object sender, EventArgs e)
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
			for (int i = 0; i < FormPhimtat.string_0.Length; i++)
			{
				this.comboBoxKieuPhimtat.Items.Add(FormPhimtat.string_0[i]);
			}
			this.comboBoxKieuPhimtat.Text = FormPhimtat.string_0[Form1.int_18];
			this.checkBoxLuonGanKetHop.Checked = (Form1.int_17 > 0);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00169C0C File Offset: 0x00167E0C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormPhimtat.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00169C30 File Offset: 0x00167E30
		private void checkBoxLuonGanKetHop_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_17 = (int)Convert.ToByte(this.checkBoxLuonGanKetHop.Checked);
				Class62.smethod_10(Class53.string_3, "LuonGanPhimtat", Form1.int_17, "", 0);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00169C84 File Offset: 0x00167E84
		private void comboBoxKieuPhimtat_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBoxKieuPhimtat.Text;
				for (int i = 0; i < FormPhimtat.string_0.Length; i++)
				{
					bool flag2 = text == FormPhimtat.string_0[i];
					if (flag2)
					{
						Form1.int_18 = i;
						Class62.smethod_10(Class53.string_3, "flagKieuPhimTat", Form1.int_18, "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00169D08 File Offset: 0x00167F08
		private void buttonGanPhimALL_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class70.smethod_14(Form1.gstruct49_0[i], Form1.int_18 > 0);
				}
			}
		}

		// Token: 0x04000AAE RID: 2734
		private IContainer icontainer_0 = null;

		// Token: 0x04000AB6 RID: 2742
		public int int_0;

		// Token: 0x04000AB7 RID: 2743
		public int int_1;

		// Token: 0x04000AB8 RID: 2744
		public int int_2;

		// Token: 0x04000AB9 RID: 2745
		public int int_3;

		// Token: 0x04000ABA RID: 2746
		public static bool bool_0 = false;

		// Token: 0x04000ABC RID: 2748
		private static string[] string_0 = new string[]
		{
			"Mặc định",
			"Kết hợp"
		};
	}
}
