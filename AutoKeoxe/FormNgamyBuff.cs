using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007A RID: 122
	public partial class FormNgamyBuff : Form
	{
		// Token: 0x060009CC RID: 2508 RVA: 0x0016589C File Offset: 0x00163A9C
		public FormNgamyBuff()
		{
			FormNgamyBuff.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x001658CC File Offset: 0x00163ACC
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00165E23 File Offset: 0x00164023
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormNgamyBuff.bool_0 = false;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00165E2C File Offset: 0x0016402C
		private void FormNgamyBuff_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormNgamyBuff.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = this.int_0 > 0 && this.int_1 > 0;
				if (flag2)
				{
					int num2 = this.int_0 - base.Width - 10;
					int num3 = this.int_1 - base.Height - 10;
					bool flag3 = num2 < 0;
					if (flag3)
					{
						num2 = 0;
					}
					bool flag4 = num3 < 0;
					if (flag4)
					{
						num3 = 0;
					}
					base.SetBounds(num2, num3, base.Width, base.Height);
				}
				for (int i = 0; i < FormNgamyBuff.string_0.Length; i++)
				{
					this.comboBoxNgaMyBuff.Items.Add(FormNgamyBuff.string_0[i]);
				}
				this.comboBoxNgaMyBuff.Text = FormNgamyBuff.string_0[gstruct.int_101[2]];
				this.checkBoxnttk.Checked = (gstruct.int_101[6] > 0);
				this.labelPhimKethop.Enabled = (gstruct.int_101[6] > 0);
				Thread.Sleep(100);
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				base.TopMost = true;
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00165F8C File Offset: 0x0016418C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = Class12.bool_0 || !FormNgamyBuff.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00165FB7 File Offset: 0x001641B7
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormNgamyBuff.bool_0 = false;
			base.Close();
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00165FC8 File Offset: 0x001641C8
		private void checkBoxnttk_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormNgamyBuff.int_4);
				bool flag2 = num < 0;
				if (flag2)
				{
					base.Close();
				}
				else
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					int num2 = 0;
					int num3 = 0;
					this.labelPhimKethop.Enabled = this.checkBoxnttk.Checked;
					bool @checked = this.checkBoxnttk.Checked;
					if (@checked)
					{
						num2 = 1114 * (int)Convert.ToByte(Class77.smethod_16(gstruct49_, 1114) > 0);
						num3 = 470;
					}
					bool flag3 = num2 == 0;
					if (flag3)
					{
						num2 = (int)(93 * Convert.ToByte(Class77.smethod_16(gstruct49_, 93) > 0));
						num3 = 400;
					}
					Form1.gstruct49_0[num].int_101[6] = (int)Convert.ToByte(this.checkBoxnttk.Checked);
					Form1.gstruct49_0[num].int_101[1] = num2;
					Form1.gstruct49_0[num].int_101[5] = num3;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x001660F0 File Offset: 0x001642F0
		private void comboBoxNgaMyBuff_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormNgamyBuff.int_4);
				bool flag2 = num < 0;
				if (flag2)
				{
					base.Close();
				}
				else
				{
					string text = this.comboBoxNgaMyBuff.Text;
					for (int i = 0; i < FormNgamyBuff.string_0.Length; i++)
					{
						bool flag3 = text == FormNgamyBuff.string_0[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_101[2] = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x001661A0 File Offset: 0x001643A0
		private void buttonPhim_Click(object sender, EventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", "https://youtu.be/ngCGdG4dYAI", 0, false, false);
		}

		// Token: 0x04000A77 RID: 2679
		private IContainer icontainer_0 = null;

		// Token: 0x04000A7E RID: 2686
		public int int_0;

		// Token: 0x04000A7F RID: 2687
		public int int_1;

		// Token: 0x04000A80 RID: 2688
		public int int_2;

		// Token: 0x04000A81 RID: 2689
		public int int_3;

		// Token: 0x04000A82 RID: 2690
		public static bool bool_0 = false;

		// Token: 0x04000A83 RID: 2691
		public static int int_4 = 0;

		// Token: 0x04000A85 RID: 2693
		public static string[] string_0 = new string[]
		{
			"Ưu tiên buff cho ac chính",
			"Buff ac chính và ac phụ",
			"Chỉ buff cho bản thân"
		};
	}
}
