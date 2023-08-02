using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000062 RID: 98
	public partial class Dangky : Form
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x000F481C File Offset: 0x000F2A1C
		public Dangky()
		{
			Dangky.int_0 = 1;
			string text = string.Empty;
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			this.string_0 = new string[]
			{
				environmentVariable + "\\" + Class12.smethod_0(Class12.char_30),
				Class53.string_9 + "\\" + Class12.smethod_0(Class12.char_30)
			};
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			base.TopMost = true;
			bool flag = Class29.string_2 == null || !(Class29.string_2 != string.Empty);
			if (flag)
			{
				this.dkidcode.Text = Class29.string_1;
			}
			else
			{
				this.dkidcode.Text = Class29.string_2;
			}
			bool flag2 = false;
			bool flag3 = this.string_0 != null;
			if (flag3)
			{
				for (int i = 0; i < this.string_0.Length; i++)
				{
					string text2 = Class12.smethod_33(this.string_0[i], 1, 1, 1);
					bool flag4 = text2 != null && text2 != string.Empty;
					if (flag4)
					{
						text = text2;
						flag2 = true;
						break;
					}
				}
			}
			this.dksr.Text = text;
			this.dksr.ReadOnly = flag2;
			this.buttonCapnhatlic.Enabled = flag2;
			this.dkdanvao.Enabled = !flag2;
			this.dkxoahet.Enabled = !flag2;
			this.dkdangky.Enabled = !flag2;
			this.checkBoxOcungThu2.Checked = (Class29.int_1 > 0);
			Class12.smethod_23(Class53.string_9);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x000F49FC File Offset: 0x000F2BFC
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000F5574 File Offset: 0x000F3774
		private void dkcopy_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dkidcode.Text == null;
				if (!flag)
				{
					bool flag2 = this.dkidcode.Text != string.Empty;
					if (flag2)
					{
						Clipboard.SetText(this.dkidcode.Text);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000F55E8 File Offset: 0x000F37E8
		private void dkxoahet_Click(object sender, EventArgs e)
		{
			this.dksr.Text = "";
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x000F55FC File Offset: 0x000F37FC
		private void dkdanvao_Click(object sender, EventArgs e)
		{
			try
			{
				this.dksr.Text = Clipboard.GetText();
			}
			catch
			{
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000F5634 File Offset: 0x000F3834
		private void dkdangky_Click(object sender, EventArgs e)
		{
			string text = this.dksr.Text.Trim();
			bool flag = text == this.dkidcode.Text.Trim();
			if (flag)
			{
				string text2 = Class12.smethod_71("88t4uGt5rkLRw92TM3UUjkw8vKhSIefwAoXcw4uBeGGljkJ2xuEteekKBUCFizMVilOLMhNz9Lg8Di+uVEh6uGtprkLe4V0lCsn5BZVwTRDjFNIf7l6bqVBYmqjgnZmrEPlw1/48oA0PdzeDbMiFGgUUOdIMND/78F49AA==");
				MessageBox.Show(text2, Form1.string_1);
			}
			else
			{
				text = text.Replace(":", "").Replace("\t", "").Replace(" ", "");
				bool flag2 = text != "" && Class12.smethod_1(text, " ") < 0 && Class12.smethod_1(text, "à") < 0;
				if (flag2)
				{
					for (int i = 0; i < this.string_0.Length; i++)
					{
						Class12.smethod_34(this.string_0[i], text, 1);
					}
					char[] char_ = new char[]
					{
						'ᕳ',
						'ᕤ',
						'ᕡ',
						'ᕛ',
						'ᔸ',
						'ᕙ',
						'ᖍ',
						'ᖌ',
						'ᖇ',
						'ᔸ',
						'ᕙ',
						'ᕙ',
						'ᕙ',
						'ᕙ',
						'ᕵ',
						'ᔸ',
						'ᔢ',
						'ᕥ',
						'ᕹ',
						'ᔸ',
						'ᖅ',
						'ᕹ',
						'ᖑ',
						'ᔡ',
						'ᕒ',
						'ᔸ',
						'ᕰ',
						'ᕰ',
						'ᕰ',
						'ᕰ',
						'ᔢ',
						'ᕫ',
						'ᕽ',
						'ᖊ',
						'ᖁ',
						'ᕹ',
						'ᖄ',
						'ᔡ',
						'ᕒ',
						'ᔸ',
						'ᕱ',
						'ᕱ',
						'ᕱ',
						'ᕱ',
						'ᔢ',
						'ᔢ',
						'ᕛ',
						'ᕹ',
						'ᕻ',
						'ᖀ',
						'ᔸ',
						'ᖄ',
						'ᕹ',
						'ᖅ',
						'ᕒ',
						'ᔸ',
						'ᕛ',
						'ᖇ',
						'ᖈ',
						'ᖑ',
						'ᔸ',
						'ᖈ',
						'ᖀ',
						'ᖁ',
						'ᕹ',
						'ᔸ',
						'ᖋ',
						'ᕹ',
						'ᖍ',
						'ᔸ',
						'ᕻ',
						'ᖀ',
						'ᖍ',
						'ᖇ',
						'ᖁ',
						'ᔸ',
						'ᕫ',
						'ᕽ',
						'ᖊ',
						'ᖁ',
						'ᕹ',
						'ᖄ',
						'ᔸ',
						'ᕻ',
						'ᖀ',
						'ᖇ',
						'ᔸ',
						'ᕼ',
						'ᕽ',
						'ᖆ',
						'ᔸ',
						'ᖀ',
						'ᕽ',
						'ᖌ',
						'ᔸ',
						'ᕀ',
						'ᖃ',
						'ᕽ',
						'ᔸ',
						'ᕻ',
						'ᕹ',
						'ᔸ',
						'ᕊ',
						'ᔸ',
						'ᕼ',
						'ᕹ',
						'ᖍ',
						'ᔸ',
						'ᕕ',
						'ᕕ',
						'ᔸ',
						'ᕻ',
						'ᖍ',
						'ᖇ',
						'ᖁ',
						'ᔸ',
						'ᕻ',
						'ᖍ',
						'ᖆ',
						'ᕿ',
						'ᔸ',
						'ᖆ',
						'ᕽ',
						'ᖍ',
						'ᔸ',
						'ᕻ',
						'ᖇ',
						'ᕁ',
						'ᔢ',
						'ᕫ',
						'ᕹ',
						'ᖍ',
						'ᔸ',
						'ᕼ',
						'ᖇ',
						'ᔸ',
						'ᕼ',
						'ᕹ',
						'ᖆ',
						'ᔸ',
						'ᖎ',
						'ᕹ',
						'ᖇ',
						'ᔸ',
						'ᕺ',
						'ᖇ',
						'ᖐ',
						'ᔸ',
						'ᖋ',
						'ᕽ',
						'ᖊ',
						'ᖁ',
						'ᕹ',
						'ᖄ',
						'ᔸ',
						'ᖎ',
						'ᕹ',
						'ᔸ',
						'ᖆ',
						'ᖀ',
						'ᕹ',
						'ᖆ',
						'ᔸ',
						'ᖆ',
						'ᖍ',
						'ᖌ',
						'ᔸ',
						'ᕼ',
						'ᕹ',
						'ᖆ',
						'ᕿ',
						'ᔸ',
						'ᖃ',
						'ᖑ',
						'ᕆ'
					};
					string text3 = Class12.smethod_0(char_);
					text3 = text3.Replace(Class12.smethod_0(new char[]
					{
						'ᒮ',
						'ᒮ',
						'ᒮ',
						'ᒮ'
					}), Form1.string_1);
					text3 = text3.Replace("\n", Class53.string_7);
					text3 = text3.Replace(Class12.smethod_0(new char[]
					{
						'ᓅ',
						'ᓅ',
						'ᓅ',
						'ᓅ'
					}), Class29.string_1);
					text3 = text3.Replace(Class12.smethod_0(new char[]
					{
						'ᓆ',
						'ᓆ',
						'ᓆ',
						'ᓆ'
					}), text);
					Class12.smethod_34(Class12.smethod_0(Class12.char_31), text3, 1);
					string string_ = "PY49CsJAEIV7T/E8gDmArY21WNguibjBZCJk1wtYW1iKTYJYqRjUahex2JB7zE0cLezm/X3MuGvYH2iBhN2ZkIUqR8auTkG6a1AqO+wNMGV3M1DWFCJG2rLfG6w0u2OKdaiKX4RYs98SknAX3sQSVAmV5ClFUSS72fyPZve2iMMDgqgJJfurPOBPsjM6XNDu2o3cy/D66oq0lJ9i9Hsf";
					MessageBox.Show(Class12.smethod_71(string_), Form1.string_1);
					TryNewVersion.int_0 = 2;
					base.Close();
				}
			}
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000F57F4 File Offset: 0x000F39F4
		private void Dangky_Load(object sender, EventArgs e)
		{
			int num = Cursor.Position.X;
			int num2 = Cursor.Position.Y;
			num -= base.Width;
			num2 -= base.Height;
			bool flag = num <= 0;
			if (flag)
			{
				num = 1;
			}
			bool flag2 = num2 <= 0;
			if (flag2)
			{
				num2 = 1;
			}
			base.SetBounds(num, num2, base.Width, base.Height);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000F5861 File Offset: 0x000F3A61
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			Dangky.int_0 = 0;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x000F586C File Offset: 0x000F3A6C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = Dangky.int_0 == 0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x000F5890 File Offset: 0x000F3A90
		private void buttonCapnhatlic_Click(object sender, EventArgs e)
		{
			this.dksr.ReadOnly = false;
			this.dksr.BackColor = Color.White;
			this.buttonCapnhatlic.Enabled = false;
			this.dkdanvao.Enabled = true;
			this.dkxoahet.Enabled = true;
			this.dkdangky.Enabled = true;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000F58F0 File Offset: 0x000F3AF0
		private void checkBoxOcungThu2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class29.int_1 = (int)Convert.ToByte(this.checkBoxOcungThu2.Checked);
				Class62.smethod_10(Class53.string_3, "fMultiHd", Class29.int_1, "", 0);
			}
		}

		// Token: 0x0400043D RID: 1085
		private IContainer icontainer_0 = null;

		// Token: 0x0400044C RID: 1100
		public static int int_0;

		// Token: 0x0400044E RID: 1102
		private string[] string_0 = null;
	}
}
