using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000064 RID: 100
	public partial class FormAchinh : Form
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x0012CBCB File Offset: 0x0012ADCB
		public FormAchinh()
		{
			FormAchinh.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0012CC04 File Offset: 0x0012AE04
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0012D25E File Offset: 0x0012B45E
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormAchinh.bool_0 = false;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0012D268 File Offset: 0x0012B468
		private void FormAchinh_Load(object sender, EventArgs e)
		{
			bool flag = this.int_2 > 0 && this.int_3 > 0;
			if (flag)
			{
				int num = this.int_2 - base.Width;
				int num2 = this.int_3;
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
			this.checkBoxBamPhim.Checked = (FormAchinh.int_0 > 0);
			this.checkBoxAnhien.Checked = (FormAchinh.int_1 > 0);
			bool flag4 = FormAchinh.string_0 != null && FormAchinh.string_0 != string.Empty;
			if (flag4)
			{
				this.comboBoxAc.Items.Add(FormAchinh.string_0);
				this.comboBoxAc.Text = FormAchinh.string_0;
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			this.bool_1 = true;
			base.TopMost = true;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0012D370 File Offset: 0x0012B570
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormAchinh.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0012D39C File Offset: 0x0012B59C
		private void comboBoxAc_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				this.bool_1 = false;
				Thread.Sleep(100);
				string text = this.comboBoxAc.Text;
				string text2 = null;
				string text3 = string.Empty;
				this.comboBoxAc.Items.Clear();
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					text3 = Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
					this.comboBoxAc.Items.Add(text3);
					bool flag2 = text == text3;
					if (flag2)
					{
						text2 = text3;
					}
				}
				bool flag3 = text2 == null;
				if (flag3)
				{
					bool flag4 = text != string.Empty && text != null;
					if (flag4)
					{
						this.comboBoxAc.Items.Add(text);
						text2 = text;
					}
					else
					{
						text2 = text3;
					}
				}
				this.comboBoxAc.Items.Add("");
				this.comboBoxAc.Text = text2;
				this.bool_1 = true;
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0012D4B4 File Offset: 0x0012B6B4
		private void comboBoxAc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1 && this.timer_0.Enabled;
			if (flag)
			{
				FormAchinh.string_0 = this.comboBoxAc.Text;
				Class62.smethod_10(Class53.string_3, "AccChinh2", Class12.smethod_16(FormAchinh.string_0), "", 0);
			}
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0012D510 File Offset: 0x0012B710
		private void checkBoxBamPhim_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1;
			if (flag)
			{
				bool flag2 = !this.timer_0.Enabled;
				if (!flag2)
				{
					FormAchinh.int_0 = (int)Convert.ToByte(this.checkBoxBamPhim.Checked);
					Class62.smethod_10(Class53.string_3, "flagPhim2", FormAchinh.int_0, "", 0);
				}
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0012D57C File Offset: 0x0012B77C
		private void checkBoxAnhien_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1 && this.timer_0.Enabled;
			if (flag)
			{
				FormAchinh.int_1 = (int)Convert.ToByte(this.checkBoxAnhien.Checked);
				Class62.smethod_10(Class53.string_3, "flagAnHien", FormAchinh.int_1, "", 0);
			}
		}

		// Token: 0x04000787 RID: 1927
		private IContainer icontainer_0 = null;

		// Token: 0x04000790 RID: 1936
		public static string string_0 = Class12.smethod_15(Class62.smethod_6("AccChinh2", 0, ""));

		// Token: 0x04000791 RID: 1937
		public static int int_0 = Class62.smethod_3("flagPhim2", 0, "0");

		// Token: 0x04000792 RID: 1938
		public static int int_1 = Class62.smethod_3("flagAnHien", 0, "1");

		// Token: 0x04000793 RID: 1939
		public int int_2;

		// Token: 0x04000794 RID: 1940
		public int int_3;

		// Token: 0x04000795 RID: 1941
		public int int_4;

		// Token: 0x04000796 RID: 1942
		public int int_5;

		// Token: 0x04000797 RID: 1943
		public static bool bool_0 = false;

		// Token: 0x04000799 RID: 1945
		private bool bool_1 = false;
	}
}
