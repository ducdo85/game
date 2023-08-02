using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000088 RID: 136
	public partial class FormTienSkill : Form
	{
		// Token: 0x06000B38 RID: 2872 RVA: 0x00187450 File Offset: 0x00185650
		public FormTienSkill()
		{
			FormTienSkill.bool_0 = true;
			this.bool_1 = false;
			this.bool_2 = false;
			this.uint_0 = 0U;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x001874D8 File Offset: 0x001856D8
		private void FormTienSkill_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				FormTienSkill.gstruct56_0 = Class77.smethod_22(gstruct, -1);
				bool flag2 = FormTienSkill.gstruct56_0 != null;
				if (flag2)
				{
					int int_ = Form1.gstruct49_0[num].gstruct48_0.int_1;
					string text = null;
					for (int i = 0; i < FormTienSkill.gstruct56_0.Length; i++)
					{
						this.comboBoxChieuthuc.Items.Add(FormTienSkill.gstruct56_0[i].string_0);
						bool flag3 = int_ > 0 && FormTienSkill.gstruct56_0[i].int_1 == int_;
						if (flag3)
						{
							text = FormTienSkill.gstruct56_0[i].string_0;
						}
					}
					bool flag4 = text != null && text != string.Empty;
					if (flag4)
					{
						this.comboBoxChieuthuc.Text = text;
					}
				}
				for (int j = 0; j < this.string_0.Length; j++)
				{
					this.comboBoxKieudanh.Items.Add(this.string_0[j]);
				}
				this.comboBoxKieudanh.Text = this.string_0[gstruct.gstruct48_0.int_2];
				this.textBoxThoigian.Text = gstruct.gstruct48_0.int_3.ToString();
				this.textBoxKhoangCach.Text = gstruct.gstruct48_0.int_7.ToString();
				this.checkBoxKethop.Checked = (gstruct.gstruct48_0.int_4 > 0);
				this.checkBoxQuai.Checked = (gstruct.gstruct48_0.int_5 > 0);
				this.textBoxThoigian.Enabled = (gstruct.gstruct48_0.int_2 == 1);
				this.textBoxKhoangCach.Enabled = (gstruct.gstruct48_0.int_2 == 2);
				for (int k = 0; k < 100; k++)
				{
					this.comboBoxHieuUng.Items.Add(k);
				}
				this.comboBoxHieuUng.Text = gstruct.gstruct48_0.int_6.ToString();
				this.checkBoxDieuchinh.Checked = (gstruct.gstruct48_0.int_8 > 0);
				this.textBoxDieuchinh.Text = gstruct.gstruct48_0.int_9.ToString();
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				this.bool_1 = true;
				base.TopMost = true;
				base.Top = Cursor.Position.Y - base.Height - 10;
				base.Left = Cursor.Position.X - base.Width - 10;
			}
			else
			{
				FormTienSkill.int_0 = 0;
				FormTienSkill.bool_0 = false;
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x001877E0 File Offset: 0x001859E0
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				bool flag2 = this.bool_2;
				if (flag2)
				{
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
				bool flag3 = this.uint_0 > 0U;
				if (flag3)
				{
					Class77.smethod_15(Form1.gstruct49_0[num], this.uint_0, false);
					Class70.smethod_31(Form1.gstruct49_0[num], this.uint_0);
				}
			}
			FormTienSkill.int_0 = 0;
			this.uint_0 = 0U;
			FormTienSkill.bool_0 = false;
			this.bool_2 = false;
			this.bool_1 = false;
			FormTienSkill.gstruct56_0 = null;
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0018788C File Offset: 0x00185A8C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTienSkill.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x001878B0 File Offset: 0x00185AB0
		private void textBoxThoigian_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_3 = Class12.smethod_11(this.textBoxThoigian.Text);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00187924 File Offset: 0x00185B24
		private void comboBoxChieuthuc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1 || FormTienSkill.gstruct56_0 == null;
			if (!flag)
			{
				int num = -1;
				string text = this.comboBoxChieuthuc.Text;
				for (int i = 0; i < FormTienSkill.gstruct56_0.Length; i++)
				{
					bool flag2 = text == FormTienSkill.gstruct56_0[i].string_0;
					if (flag2)
					{
						num = FormTienSkill.gstruct56_0[i].int_1;
						break;
					}
				}
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag3 = num > 0 && 0 <= num2;
				if (flag3)
				{
					Form1.gstruct49_0[num2].gstruct48_0.int_1 = num;
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x001879FC File Offset: 0x00185BFC
		private void buttonThuGanChieu_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
			bool flag = num < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = gstruct.gstruct48_0.int_1 > 0;
				if (flag2)
				{
					bool flag3 = this.uint_0 == 0U;
					if (flag3)
					{
						this.uint_0 = (uint)Class77.smethod_13(gstruct);
					}
					Class77.smethod_15(gstruct, (uint)gstruct.gstruct48_0.int_1, false);
					Class70.smethod_31(gstruct, (uint)gstruct.gstruct48_0.int_1);
				}
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x00187A84 File Offset: 0x00185C84
		private void comboBoxKieudanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxKieudanh.Text;
					for (int i = 0; i < this.string_0.Length; i++)
					{
						bool flag3 = text == this.string_0[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].gstruct48_0.int_2 = i;
							this.textBoxThoigian.Enabled = (i == 1);
							this.textBoxKhoangCach.Enabled = (i == 2);
							this.bool_2 = true;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00187B54 File Offset: 0x00185D54
		private void checkBoxKethop_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_4 = (int)Convert.ToByte(this.checkBoxKethop.Checked);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00187BC8 File Offset: 0x00185DC8
		private void checkBoxQuai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_5 = (int)Convert.ToByte(this.checkBoxQuai.Checked);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00187C3C File Offset: 0x00185E3C
		private void comboBoxHieuUng_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_6 = Class12.smethod_11(this.comboBoxHieuUng.Text);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00187CB0 File Offset: 0x00185EB0
		private void textBoxKhoangCach_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_7 = Class12.smethod_11(this.textBoxKhoangCach.Text);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x00187D24 File Offset: 0x00185F24
		private void checkBoxDieuchinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_8 = (int)Convert.ToByte(this.checkBoxDieuchinh.Checked);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00187D98 File Offset: 0x00185F98
		private void textBoxDieuchinh_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTienSkill.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_9 = Class12.smethod_11(this.textBoxDieuchinh.Text);
					this.bool_2 = true;
				}
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00187E0C File Offset: 0x0018600C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000CA4 RID: 3236
		public static bool bool_0;

		// Token: 0x04000CA5 RID: 3237
		public static int int_0;

		// Token: 0x04000CA6 RID: 3238
		private static GStruct56[] gstruct56_0;

		// Token: 0x04000CA7 RID: 3239
		private bool bool_1 = false;

		// Token: 0x04000CA8 RID: 3240
		private bool bool_2 = false;

		// Token: 0x04000CA9 RID: 3241
		private uint uint_0 = 0U;

		// Token: 0x04000CAA RID: 3242
		private string[] string_0 = new string[]
		{
			"Chỉ phát chiêu 1 lần khi vừa gặp địch",
			"Phát chiêu lặp lại theo thời gian",
			"Phát và dừng chiêu theo khoảng cách"
		};

		// Token: 0x04000CAB RID: 3243
		private IContainer icontainer_0 = null;
	}
}
