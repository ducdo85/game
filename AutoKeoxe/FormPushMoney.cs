using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007F RID: 127
	public partial class FormPushMoney : Form
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x0016DD15 File Offset: 0x0016BF15
		public FormPushMoney()
		{
			FormPushMoney.int_0 = 1;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0016DD50 File Offset: 0x0016BF50
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0016E6CC File Offset: 0x0016C8CC
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
			bool flag = 0 <= num;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			FormPushMoney.int_1 = 0;
			FormPushMoney.int_0 = 0;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0016E714 File Offset: 0x0016C914
		private void FormPushMoney_Load(object sender, EventArgs e)
		{
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
			bool flag = num < 0;
			if (flag)
			{
				this.textBoxTen.Text = Class12.smethod_53("ᒼᓡᘩᓚᒙᓜᓡ㍆ᓧᒙᓚᓜᒙᓧᕙᓨ");
			}
			else
			{
				this.textBoxTen.Text = Class10.smethod_1(Form1.gstruct49_0[num].string_22, 1, false);
				this.checkBoxTudong.Checked = (Form1.gstruct49_0[num].int_67[0] > 0);
				this.textBox2.Text = Form1.gstruct49_0[num].int_67[1].ToString();
				int num2 = Form1.gstruct49_0[num].int_67[2];
				this.textBox1.Text = num2.ToString();
				this.label1.Text = (num2 / 10000).ToString() + " vạn " + (num2 % 10000).ToString() + " lượng";
			}
			this.richTextBox1.Text = Class12.smethod_53(this.string_0);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0016E89C File Offset: 0x0016CA9C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormPushMoney.int_0 == 0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0016E8C0 File Offset: 0x0016CAC0
		private void checkBoxTudong_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
				bool flag = 0 <= num;
				if (flag)
				{
					Form1.gstruct49_0[num].int_67[0] = (int)Convert.ToByte(this.checkBoxTudong.Checked);
				}
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0016E91C File Offset: 0x0016CB1C
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
				bool flag = 0 <= num;
				if (flag)
				{
					Form1.gstruct49_0[num].int_67[1] = Class12.smethod_11(this.textBox2.Text);
				}
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0016E978 File Offset: 0x0016CB78
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class12.smethod_11(this.textBox1.Text);
				this.label1.Text = (num / 10000).ToString() + " vạn " + (num % 10000).ToString() + " lượng";
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
				bool flag = 0 <= num2;
				if (flag)
				{
					Form1.gstruct49_0[num2].int_67[2] = num;
				}
			}
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0016EA14 File Offset: 0x0016CC14
		private void buttonPush_Click(object sender, EventArgs e)
		{
			int num = Class12.smethod_11(this.textBox1.Text);
			int num2 = Class81.smethod_3(Form1.gstruct49_0, FormPushMoney.int_1);
			bool flag = num2 >= 0;
			if (flag)
			{
				Class70.smethod_73(Form1.gstruct49_0[num2], num);
			}
			else
			{
				this.richTextBox1.Text = Class12.smethod_53("ᔐᔵᙽᔮᓭᔰᔵ㎚ᔻᓭᔮᔰᓭᔻᖭᔼᓻᓭᔕᖰᕆᓭᔯ㍲ᔺᓭᔻᗇᕁᓭᗞᗀᔻᔴᓹᓭᕁᔿᖷᔻᓭᔮᕂᕁᔼᓭᔯ㍲ᔺᓭᔰᔵ㎚ᔻᓭᕁᖷᔻᓭᔮᔰᓹᓭᕀᔮᕂᓭᗞᗀᓭᔯ㍲ᔺᓭᔹ㍮ᔶᓭᔻᗇᕁᓭᔔ㎺ᔶᓭᕁᔶ㎎ᔻᓭᔹᖷᔻᓭᔯᔮᔻᔴᓻ");
			}
		}

		// Token: 0x04000AF7 RID: 2807
		private IContainer icontainer_0 = null;

		// Token: 0x04000B05 RID: 2821
		public static int int_0;

		// Token: 0x04000B06 RID: 2822
		public static int int_1;

		// Token: 0x04000B08 RID: 2824
		private string string_0 = "㑱ᖳᘀ㑬ᘇᖳᘆ㑤ᖳᘆᗸᘅᘉᗸᘅᖳᘇᗸᘆᘇᖳᗵ㐴ᘁᖳᗶᚆᖳᘇᗻ㑖ᖳᗾ㑒ᘇᖳᗻ㑶ᘃᖳᘎᖳᘃᗻ㑸ᖳᘇᘅ㑶ᖳᗀᗑᖳᗸᘉᗸᘁᘇᖳᗀᗑᖳᗿ㑠ᗶᖳᚤ㑦ᖳᘇᗸᘆᘇᖳᗻᘂ㑊ᗶᖳᗶᗿᗼᗶᗾᖳᘁᘃᗶᖳᘐᖳᖳᚤ㑖ᖳᘁᗻ㑀ᘁᖳᘇᗼ㑔ᘁᖳᘀᗼ㑘ᘁᖳᘃᗻ\u1680ᖳᘇᘅᘂᘁᗺᖳᗿ㑚ᘁᗻᖳᗵᙳᗼᖳᘇᙵᘁᖳᘇᗻ㑺ᖿᖳᘆᗴᘈᖳᚤᚆᖳᘇ㒄ᖳᚤ㑬ᘁᗺᖳᗺ㒀ᗼᖳᗿᙽᘁᖳᗵᗴᘁᗺᗁᖳᖝᖝᗟᝃᘈᖳᚐᖳᗶᗻ㑜ᖳᗺ㒀ᗼᖳᘇᗼ㑔ᘁᖳ㑲ᖳᗻᙳᘁᗻᖳᘇᘅᗴᘁᗺᖿᖳᗾᗻᚇᘁᗺᖳᗶᚆᖳᘅᚍᘇᖳᘇᘅᘂᘁᗺᖳᘅᝃ᜴ᘁᗺᖳᚤ㑖ᖳᗺ㒀ᗼᗁᖳᗠ㑪ᗼᖳᗿ㐺ᘁᖳᗴᘈᘇᘂᖳᗶᗻ㑜ᖳᗺ㒀ᗼᖳᘇ㑤ᗼᖳᚤᗴᖳᗄᖳᘉ㐴ᘁᖳᗿᝃ㑶ᘁᗺᖳᚤ㑖ᖳᘇᘅᙴᘁᗻᖳᗿ㑪ᗼᖳᘆᗸᘉᗸᘅᖳᗺᗴᘀᗸ";
	}
}
