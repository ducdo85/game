using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000081 RID: 129
	public partial class FormRauria : Form
	{
		// Token: 0x06000A46 RID: 2630 RVA: 0x001708F0 File Offset: 0x0016EAF0
		public FormRauria()
		{
			FormRauria.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00170944 File Offset: 0x0016EB44
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00175A8C File Offset: 0x00173C8C
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormRauria.bool_0 = false;
			Class62.smethod_10(Class53.string_3, "tabRRControl1", this.tabControl1.SelectedIndex, "", 0);
			Class62.smethod_10(Class53.string_3, "tabRRControl2", this.tabControlKeoLienmay.SelectedIndex, "", 0);
			int num = Class81.smethod_3(Form1.gstruct49_0, FormRauria.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00175B1C File Offset: 0x00173D1C
		private void FormRauria_Load(object sender, EventArgs e)
		{
			bool flag = GClass1.LienMay == null || GClass1.LienMay != "True";
			if (flag)
			{
				this.tabControl1.Controls.Remove(this.tabPageLienMay);
			}
			this.timer_0.Enabled = false;
			bool flag2 = FormRauria.string_2 == null;
			if (flag2)
			{
				FormRauria.string_2 = this.richTextBoxStatus.Text;
			}
			bool flag3 = this.int_2 >= 0 && this.int_3 >= 0;
			if (flag3)
			{
				int num = this.int_2 - base.Width;
				int num2 = this.int_3 + this.int_5 - base.Height;
				bool flag4 = num < 0;
				if (flag4)
				{
					num = 0;
				}
				bool flag5 = num2 < 0;
				if (flag5)
				{
					num2 = 0;
				}
				base.SetBounds(num, num2, base.Width, base.Height);
			}
			bool flag6 = false;
			bool flag7 = !FormMayphu.bool_1 && Form1.gstruct49_0 == null;
			if (flag7)
			{
				int num3 = -1;
				bool flag8 = GClass1.gstruct15_0.bool_0 && GClass1.gstruct15_0.uint_1 != null && GClass1.gstruct16_0 != null;
				if (flag8)
				{
					for (int i = 0; i < GClass1.gstruct16_0.Length; i++)
					{
						bool flag9 = GClass1.gstruct16_0[i].long_0 <= GClass1.long_1;
						if (!flag9)
						{
							for (int j = 0; j < GClass1.gstruct15_0.uint_1.Length; j++)
							{
								bool flag10 = GClass1.gstruct16_0[i].uint_0 != GClass1.gstruct15_0.uint_1[j];
								if (!flag10)
								{
									num3 = i;
									goto IL_1C7;
								}
							}
						}
					}
					IL_1C7:;
				}
				bool flag11 = 0 <= num3;
				if (flag11)
				{
					DateTime dateTime = new DateTime(GClass1.gstruct16_0[num3].long_0);
					FormMayphu.int_1 = new int[]
					{
						dateTime.Day,
						dateTime.Month,
						dateTime.Year
					};
					FormMayphu.string_1 = GClass1.gstruct16_0[num3].string_1;
					FormMayphu.bool_2 = (GClass1.gstruct16_0[num3].int_0 == 1);
					flag6 = true;
				}
			}
			bool flag12 = FormMayphu.bool_1 || flag6;
			if (flag12)
			{
				this.tabPageLienMay.Controls.Remove(this.tabControlKeoLienmay);
				this.labelThongbao1.Visible = true;
				this.labelThongbao2.Visible = true;
				bool flag13 = FormMayphu.int_1 != null;
				if (flag13)
				{
					this.labelThongbao2.Text = "Không thể sử dụng";
				}
				bool flag14 = FormMayphu.string_1 != null && FormMayphu.string_1 != string.Empty;
				if (flag14)
				{
					this.labelThongbao1.Text = "Chức năng kéo nhiều máy đã bị khóa";
				}
			}
			this.tabControl1.SelectedIndex = Class62.smethod_3("tabRRControl1", 0, "0");
			this.tabControlKeoLienmay.SelectedIndex = Class62.smethod_3("tabRRControl2", 0, "0");
			this.checkBoxBaoCuusat.Checked = (Form1.int_14 > 0);
			this.checkBoxBaoCuusatPhucan.Checked = (Form1.int_16 > 0);
			this.checkBoxBaoCsKenhbang.Checked = (Form1.int_15 > 0);
			this.checkBoxChayNhay.Checked = (Form1.int_35 > 0);
			this.textBoxKhoangCachlenNgua.Text = Form1.int_101.ToString();
			this.checkBoxKhongDanhAccCungbang.Checked = (Form1.int_103 > 0);
			this.checkBoxSuado.Checked = (Form1.int_55 > 0);
			this.checkBoxDoiPKTheoAccChinh.Checked = (Form1.int_83 > 0);
			this.checkBoxTroLaiDiemcu.Checked = (Form1.int_84 > 0);
			this.checkBoxKhongdanhCapnho.Checked = (Form1.int_86 > 0);
			this.numericUpDownKhongdanhCapnho.Value = Form1.int_87;
			this.checkBoxKhongChaybo.Checked = (Form1.int_19 > 0);
			this.checkBoxAcChinhNghelenh.Checked = (Form1.int_7 > 0);
			this.checkBoxDanhKhongten.Checked = (Form1.int_117 > 0);
			this.checkBoxTHP_Smdb.Checked = (Form1.int_11 > 0);
			this.checkBoxXuongngua.Checked = (Form1.int_102 > 0);
			this.checkBoxRoom.Checked = (Form1.int_8 > 0);
			this.checkBoxKhoaChatmat.Checked = (Form1.int_9 > 0);
			this.checkBoxDelay.Checked = (Form1.int_69 > 0);
			this.textBoxValueDelay.Text = Form1.int_70.ToString();
			this.checkBoxLuongThuyTHP.Checked = (Class35.int_0 > 0);
			this.checkBoxPassword.Checked = (Form1.int_47 > 0);
			this.numericUpDownPassword.Value = Form1.int_48;
			this.numericUpDown1.Value = Form1.int_49;
			this.checkBoxDanhDenchet.Checked = (Form1.int_50 > 0);
			bool flag15 = FormMayphu.string_2 == null || FormMayphu.string_2 == string.Empty;
			if (flag15)
			{
				FormMayphu.string_2 = "|";
			}
			this.textBoxKytuLenh.Text = FormMayphu.string_2[0].ToString();
			this.textBox1.Text = FormMayphu.int_2.ToString();
			this.checkBoxThongbaoTHP.Checked = (Form1.int_119 > 0);
			this.checkBoxTienToida.Checked = (Form1.int_61[0] > 0);
			this.textBoxTienToida.Text = Form1.int_61[1].ToString();
			this.checkBoxNhapMatma.Checked = (Form1.int_85 > 0);
			this.checkBoxTatThongbaoDame.Checked = (Form1.int_120 > 0);
			this.checkBoxMouseDrag.Checked = (Form1.int_121 > 0);
			this.checkBoxLuonDanhbang.Checked = (Class7.int_1 > 0);
			bool bool_ = FormMayphu.bool_4;
			if (bool_)
			{
				this.checkBoxKhongdanhBang.Text = Class12.smethod_15("S2jDs2EgYuG7n2kgYWRnYW1l");
				this.checkBoxKhongdanhBang.Enabled = false;
				this.comboBoxKhongDanh.Enabled = false;
				Class7.int_2 = 0;
			}
			this.checkBoxKhongdanhBang.Checked = (Class7.int_2 > 0);
			this.checkBoxKhongdanhAc.Checked = (Class7.int_3 > 0);
			this.textBoxTiepCan.Text = Form1.int_51.ToString();
			bool flag16 = Class7.string_4 != null;
			if (flag16)
			{
				for (int k = 0; k < Class7.string_4.Length; k++)
				{
					bool flag17 = Class7.string_4[k] != null;
					if (flag17)
					{
						this.method_0(this.listViewLuonDanh, Class10.smethod_1(Class7.string_4[k], 1, false));
					}
				}
			}
			bool flag18 = Class7.string_3 != null;
			if (flag18)
			{
				for (int l = 0; l < Class7.string_3.Length; l++)
				{
					bool flag19 = Class7.string_3[l] != null;
					if (flag19)
					{
						this.method_0(this.listViewKhongDanh, Class10.smethod_1(Class7.string_3[l], 1, false));
					}
				}
			}
			bool flag20 = Class7.string_5 != null;
			if (flag20)
			{
				for (int m = 0; m < Class7.string_5.Length; m++)
				{
					bool flag21 = Class7.string_5[m] != null;
					if (flag21)
					{
						this.method_0(this.listViewKhongdanhAc, Class10.smethod_1(Class7.string_5[m], 1, false));
					}
				}
			}
			string text = null;
			string[] array = Class72.smethod_0();
			bool flag22 = array != null;
			if (flag22)
			{
				bool flag23 = Class72.string_1 == null || Class72.string_1 == string.Empty;
				if (flag23)
				{
					Class72.string_1 = array[0];
				}
				for (int n = 0; n < array.Length; n++)
				{
					this.comboBoxTabAddr.Items.Add(array[n]);
					bool flag24 = Class72.string_1 == array[n];
					if (flag24)
					{
						text = Class72.string_1;
					}
				}
			}
			bool flag25 = text == null && Class72.string_1 != null && Class72.string_1 != string.Empty;
			if (flag25)
			{
				this.comboBoxTabAddr.Items.Add(Class72.string_1);
				text = Class72.string_1;
			}
			bool flag26 = text != null;
			if (flag26)
			{
				this.comboBoxTabAddr.Text = text;
			}
			bool flag27 = Class72.int_2 <= 0;
			if (flag27)
			{
				Class72.int_2 = FormRauria.random_0.Next(FormRauria.int_9, FormRauria.int_10);
				Class62.smethod_10(Class53.string_3, "PortServer", Class72.int_2, "", 0);
			}
			this.textBoxPassServer.Text = Class72.int_2.ToString();
			this.textBoxIPConnect.Text = Class72.string_2;
			this.textBoxConnectPass.Text = Class72.int_3.ToString();
			for (int num4 = 0; num4 < FormRauria.string_1.Length; num4++)
			{
				this.comboBoxConnect.Items.Add(FormRauria.string_1[num4]);
			}
			this.comboBoxConnect.Text = FormRauria.string_1[Class72.int_1];
			this.groupBoxHientai.Enabled = (Class72.int_1 == 0);
			this.groupBoxConnect.Enabled = (Class72.int_1 > 0);
			string text2 = FormRauria.string_2.Replace("|", Class53.string_7);
			bool flag28 = Class72.string_0 != null && Class72.string_0 != string.Empty;
			if (flag28)
			{
				text2 = text2 + Class53.string_7 + Class72.string_0;
			}
			this.richTextBoxStatus.Text = text2;
			FormRauria.int_7 = -1;
			FormRauria.long_0 = Class72.long_0;
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.timer_0.Interval = 100;
			this.timer_0.Enabled = true;
			this.bool_1 = true;
			base.TopMost = true;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00176538 File Offset: 0x00174738
		private void method_0(ListView listView_0, string string_7)
		{
			try
			{
				string[] array = new string[]
				{
					string_7
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag = array.Length > 1;
				if (flag)
				{
					for (int i = 1; i < array.Length; i++)
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

		// Token: 0x06000A4C RID: 2636 RVA: 0x001765BC File Offset: 0x001747BC
		public static void smethod_0(RichTextBox richTextBox_0, string string_7, bool bool_3 = false)
		{
			bool flag = string_7 != null && !(string_7 == string.Empty);
			if (flag)
			{
				bool flag2 = richTextBox_0.Text != string.Empty;
				if (flag2)
				{
					string_7 = Class53.string_7 + string_7;
				}
				int num = Class22.GetScrollPos(richTextBox_0.Handle, 1);
				richTextBox_0.AppendText(string_7);
				bool flag3 = !bool_3;
				if (flag3)
				{
					int num2;
					int num3;
					Class22.GetScrollRange(richTextBox_0.Handle, 1, out num2, out num3);
					int num4 = (richTextBox_0.ClientSize.Height - SystemInformation.HorizontalScrollBarHeight) / richTextBox_0.Font.Height;
					num = num3 - num4;
				}
				Class22.SetScrollPos(richTextBox_0.Handle, 1, num, true);
				Class22.PostMessageA(richTextBox_0.Handle, 277, 4 + 65536 * num, 0);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0017668C File Offset: 0x0017488C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormRauria.bool_2 && !FormMayphu.bool_8;
			if (flag)
			{
				this.buttonEpDanhBang.Enabled = true;
				FormRauria.bool_2 = false;
			}
			bool flag2 = !FormRauria.bool_0;
			if (flag2)
			{
				base.Close();
			}
			else
			{
				bool flag3 = FormRauria.int_1 > 0;
				if (flag3)
				{
					FormRauria.int_1++;
					bool flag4 = FormRauria.int_1 > 12;
					if (flag4)
					{
						this.checkBoxAcChihuy.Enabled = true;
						FormRauria.int_1 = 0;
					}
				}
				bool flag5 = Class72.int_0 > 0;
				bool flag6 = FormRauria.int_7 != Class72.int_0;
				if (flag6)
				{
					this.buttonBatdau.Enabled = !flag5;
					this.buttonKetthuc.Enabled = flag5;
					this.comboBoxConnect.Enabled = !flag5;
					this.buttonRandom.Enabled = !flag5;
					this.comboBoxTabAddr.Enabled = !flag5;
					FormRauria.int_7 = Class72.int_0;
					this.textBoxIPConnect.ReadOnly = (Class72.int_0 > 0);
					this.textBoxConnectPass.ReadOnly = (Class72.int_0 > 0);
					this.textBoxPassServer.ReadOnly = (Class72.int_0 > 0);
				}
				FormRauria.int_8++;
				bool flag7 = FormRauria.long_0 == Class72.long_0;
				if (flag7)
				{
					bool flag8 = FormRauria.int_8 > 10;
					if (flag8)
					{
						this.progressBar1.Style = ProgressBarStyle.Continuous;
						this.progressBar1.MarqueeAnimationSpeed = 0;
					}
				}
				else
				{
					FormRauria.long_0 = Class72.long_0;
					bool flag9 = this.progressBar1.MarqueeAnimationSpeed != 300;
					if (flag9)
					{
						this.progressBar1.Style = ProgressBarStyle.Marquee;
						this.progressBar1.MarqueeAnimationSpeed = 300;
					}
					FormRauria.int_8 = 0;
				}
				bool flag10 = Class72.string_0 != null && Class72.string_0 != string.Empty;
				if (flag10)
				{
					FormRauria.smethod_0(this.richTextBoxStatus, Class72.string_0, false);
					Class72.string_0 = null;
				}
				bool flag11 = this.int_6 == FormRauria.int_0;
				if (!flag11)
				{
					this.bool_1 = false;
					bool flag12 = this.int_6 > 0;
					if (flag12)
					{
						int num = Class81.smethod_3(Form1.gstruct49_0, this.int_6);
						bool flag13 = 0 <= num;
						if (flag13)
						{
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
					this.int_6 = FormRauria.int_0;
					int num2 = Class81.smethod_3(Form1.gstruct49_0, FormRauria.int_0);
					flag5 = (0 <= num2);
					string text = "[chưa chọn ac]";
					bool flag14 = flag5;
					if (flag14)
					{
						this.gstruct49_0 = Form1.gstruct49_0[num2];
						text = "[" + Class10.smethod_1(this.gstruct49_0.string_22, 1, false) + "]";
						this.checkBoxAcChihuy.Checked = (this.gstruct49_0.int_2 > 0);
					}
					this.textBoxTen.Text = text;
					this.checkBoxAcChihuy.Enabled = flag5;
					Thread.Sleep(100);
					this.bool_1 = true;
				}
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x001769B4 File Offset: 0x00174BB4
		private void checkBoxChayNhay_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_35 = (int)Convert.ToByte(this.checkBoxChayNhay.Checked);
				Class62.smethod_10(Class53.string_3, "flagDanhNguoiChayNhay", Form1.int_35, "", 0);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00176A14 File Offset: 0x00174C14
		private void checkBoxKhongdanhCapnho_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_86 = (int)Convert.ToByte(this.checkBoxKhongdanhCapnho.Checked);
				Class62.smethod_10(Class53.string_3, "flagKhongDanhCapnho", Form1.int_86, "", 0);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00176A74 File Offset: 0x00174C74
		private void numericUpDownKhongdanhCapnho_ValueChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					Form1.int_87 = (int)this.numericUpDownKhongdanhCapnho.Value;
					Class62.smethod_10(Class53.string_3, "ValueCapBoqua", Form1.int_87, "", 0);
				}
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00176AE0 File Offset: 0x00174CE0
		private void numericUpDownKhongdanhCapnho_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_87 = (int)this.numericUpDownKhongdanhCapnho.Value;
				Class62.smethod_10(Class53.string_3, "ValueCapBoqua", Form1.int_87, "", 0);
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00176B40 File Offset: 0x00174D40
		private void textBoxKhoangCachlenNgua_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Form1.int_101 = Class12.smethod_11(this.textBoxKhoangCachlenNgua.Text);
					Class62.smethod_10(Class53.string_3, "KhoangCachLenNguaEx", Form1.int_101, "", 0);
				}
			}
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00176BAC File Offset: 0x00174DAC
		private void checkBoxDoiPKTheoAccChinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_83 = (int)Convert.ToByte(this.checkBoxDoiPKTheoAccChinh.Checked);
				Class62.smethod_10(Class53.string_3, "flagDoiPKTheoAccChinh", Form1.int_83, "", 0);
			}
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00176C0C File Offset: 0x00174E0C
		private void checkBoxKhongDanhAccCungbang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_103 = (int)Convert.ToByte(this.checkBoxKhongDanhAccCungbang.Checked);
				Class62.smethod_10(Class53.string_3, "KhongdanhCungBang", Form1.int_103, "", 0);
			}
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00176C6C File Offset: 0x00174E6C
		private void checkBoxBaoCuusat_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_14 = (int)Convert.ToByte(this.checkBoxBaoCuusat.Checked);
				Class62.smethod_10(Class53.string_3, "flagBaoCuusatMat", Form1.int_14, "", 0);
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00176CCC File Offset: 0x00174ECC
		private void checkBoxSuado_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					Form1.int_55 = (int)Convert.ToByte(this.checkBoxSuado.Checked);
					Class62.smethod_10(Class53.string_3, "flagSuadoTaichoEx", Form1.int_55, "", 0);
				}
			}
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00176D38 File Offset: 0x00174F38
		private void buttonThietlapSuado_Click(object sender, EventArgs e)
		{
			bool flag = FormSuado.int_0 > 0;
			if (flag)
			{
				FormSuado.int_0 = 0;
			}
			else
			{
				try
				{
					FormSuado formSuado = new FormSuado();
					formSuado.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00176D84 File Offset: 0x00174F84
		private void checkBoxTroLaiDiemcu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_84 = (int)Convert.ToByte(this.checkBoxTroLaiDiemcu.Checked);
				Class62.smethod_10(Class53.string_3, "flagTrolaiDiemcu", Form1.int_84, "", 0);
			}
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00176DE4 File Offset: 0x00174FE4
		private void checkBoxKhongChaybo_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					Form1.int_19 = (int)Convert.ToByte(this.checkBoxKhongChaybo.Checked);
					Class62.smethod_10(Class53.string_3, "flagKhongChaybo", Form1.int_19, "", 0);
				}
			}
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00176E50 File Offset: 0x00175050
		private void labelBoqua_Click(object sender, EventArgs e)
		{
			string text = "Các bản đồ bỏ qua không chạy bộ:|";
			bool flag = Class43.int_1 != null;
			if (flag)
			{
				for (int i = 0; i < Class43.int_1.Length; i++)
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						(i + 1).ToString(),
						". ",
						Class10.smethod_1(Class37.smethod_1(Class43.int_1[i], false), 1, false),
						"|"
					});
				}
			}
			FormTip.smethod_0(Form1.string_1, text, 600000, 280, 280, false, -1, -1, false, false, false);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00176EF8 File Offset: 0x001750F8
		private void checkBoxAcChinhNghelenh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_7 = (int)Convert.ToByte(this.checkBoxAcChinhNghelenh.Checked);
				Class62.smethod_10(Class53.string_3, "flagKeo2", Form1.int_7, "", 0);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00176F58 File Offset: 0x00175158
		private void checkBoxAcChihuy_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRauria.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(this.checkBoxAcChihuy.Checked);
					Form1.gstruct49_0[num].int_2 = num2;
					bool flag3 = num2 > 0;
					if (flag3)
					{
						Form1.int_7 = 0;
						this.checkBoxAcChinhNghelenh.Checked = false;
						FormMayphu.int_0 = Form1.gstruct49_0[num].int_136;
						new Thread(new ThreadStart(FormMayphu.smethod_3)).Start();
					}
					else
					{
						FormRauria.int_1 = 1;
						this.checkBoxAcChihuy.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0017702C File Offset: 0x0017522C
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			string newValue = "https://www.youtube.com/watch?v=5UU-GeLlKZI";
			string text = Class12.smethod_71("dVRPaxNBFL/vp3hHlXWh8RZESNPQSmwqtqV6TCZld0kzm252C3uUHoqIYOmpiJg15KBNsBpB3EFymNjvMd/E92Z386/2Mklm3vz+vTfZ2t+pbcJGqQYbTyv7UK3swMsKbJdeQXWrVDaM547bBufmWokP3IamSq44BCqJXZiey89REQ4q67vGPeZ1ImjKmMOJ7HkQ+HLIHWiGkRJnAXCVTEJoOfInYrSV+ISXCbLP7luGsemqpA9dJUbA5BgK0JZxZOoVGkjFsdpV4jUh4OcpB1uJdy4cyV5atJYVt9z6fLOAyA9gW58XjYewrpGY40GdQcdRYgCcpKKNMS7TU5TGHZWMOqmFjiN/4FYgNT/SYvkYgtRDQ8YenCjxlpyOCJE5csQdC6ppAZdfOebxG78uAjF9yJS45LaZFh1pysUi38V9OyNF/BiTbBDXcaiSQQS+EueuhZbKziFrpWox1AGDxyVGpiIMM/lzt0jLeoK3a8ROeRRMeDQPhWnRy4EsqkO6rOb/WaSys15r2dxWybcA1cs+t+ddKVBXSrmorGkrxOxWgmnD73SfgQVy2EZ9h4vCAt9DEN/z2lkAezhNySTIOqCru/WwmM/Isq78ePVkbWbYTVnzyaZ4hnpmmEPPAMf2OKzPcYiFrsZgo4xRgMHs4rYex0Y2q0q8gRMc+TNGIYoLF+jtLPGuPA1rNVGqS99qmCq65YzOtSqitoya7cmeC37dzJ5tLiYzgaqSiSa/hIPSCxPKe2Vcnk3fm4RAw4qdjt3ZL25TIB9x4+YaNdBwQ8Prdk3d5F+BxrowodPCvuB/i7jKlWu9M8cFYH+/0Bgo8T3lp6eUyyIHlvEP").Replace("WEBS", newValue);
			FormTip.smethod_0(Form1.string_1, text, 600000, 440, 300, false, -1, -1, false, false, false);
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", newValue, 0, false, false);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x001770B0 File Offset: 0x001752B0
		private void checkBoxTHP_Smdb_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_11 = (int)Convert.ToByte(this.checkBoxTHP_Smdb.Checked);
				Class62.smethod_10(Class53.string_3, "flagLienthongMapAB", Form1.int_11, "", 0);
			}
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00177110 File Offset: 0x00175310
		private void labelLienthongGiaithich_Click(object sender, EventArgs e)
		{
			string text = "CHẠY BỘ Ở CÁC MAP LIÊN THÔNG:||Map liên thông là 2 bản đồ kề nhau, chỉ cần đi qua 1 cổng là tới liền. Ví dụ map liên thông:||* Sa mạc 1, 2, 3 -> liên thông Sa mạc địa biểu|* La tiêu sơn -> Lưỡng thủy động.|* v.v..||Tại sao phải chạy bộ?||Bởi nếu sử dụng Thần hành phù thì có thể nó lên đầu cổng, khoảng cách đến ac chính có khi lại xa hơn khi chạy bộ qua cổng.||Đó là chưa kể sẽ bị lag (ví dụ cầu thang ở smđb) hoặc bị sai vị trí (ví dụ lưỡng thủy động có 2 động, cần đến động 1 nhưng thần hành phù lại đến động 2)....||Khi không có map liên thông, hoặc chạy bộ không thành công thì auto sẽ xét đến Thần hành phù.|";
			FormTip.smethod_0(Form1.string_1, text, 600000, 380, 320, false, -1, -1, false, false, false);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00177148 File Offset: 0x00175348
		private void checkBoxBaoCuusatPhucan_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_16 = (int)Convert.ToByte(this.checkBoxBaoCuusatPhucan.Checked);
				Class62.smethod_10(Class53.string_3, "flagBaoCuusatPhucan", Form1.int_16, "", 0);
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x001771A8 File Offset: 0x001753A8
		private void buttonCacChucNangDkTuxa_Click(object sender, EventArgs e)
		{
			string text = "CÁC MỤC MÁY CHÍNH ĐIỀU KHIỂN ĐƯỢC MÁY PHỤ:||1. Tìm ac chính, tìm trong thành|2. Đánh người, quái, ưu tiên boss.|3. Đổi Pk theo ac chính, dame mặc định|4. Đánh Chiến long động: Chọn cổng lên|5. Chiến trường CTC: Thất thành và tam trụ.|6. Đánh Tống Kim: Báo danh, ac chính ac phụ ra khỏi hậu doanh.||7. Phần chuyển thuốc từ hành rương Bang Hội sang Hành trang:|- Máy phụ bạn phải chọn trước tên túi thuốc cần chuyển.|- Máy phụ luôn mặc định là chuyển 5 túi / lần.||8. Web của game (mục cài game): luôn lấy theo máy chính.|9. CTC: mục dùng THP luôn lấy theo máy chính.|10. Đến tọa độ canh boss|12. Danh sách đánh bang hội, không đánh bang hội và không đánh ac.";
			FormTip.smethod_0(Form1.string_1, text, 600000, 420, 230, false, -1, -1, false, false, false);
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x001771E0 File Offset: 0x001753E0
		private void checkBoxXuongngua_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_102 = (int)Convert.ToByte(this.checkBoxXuongngua.Checked);
				Class62.smethod_10(Class53.string_3, "flagXuongNguaSansang", Form1.int_102, "", 0);
			}
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00177240 File Offset: 0x00175440
		private void buttonDanhsachMayphu_Click(object sender, EventArgs e)
		{
			bool flag = FormMayphu.bool_0;
			if (flag)
			{
				FormMayphu.bool_0 = false;
			}
			else
			{
				try
				{
					new FormMayphu
					{
						int_3 = Cursor.Position.X,
						int_4 = Cursor.Position.Y,
						int_5 = base.Width,
						int_6 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x001772C8 File Offset: 0x001754C8
		private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Form1.int_8 = (int)Convert.ToByte(this.checkBoxRoom.Checked);
					Class62.smethod_10(Class53.string_3, "flagBaoroom", Form1.int_8, "", 0);
				}
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00177334 File Offset: 0x00175534
		private void checkBoxKhoaChatmat_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Form1.int_9 = (int)Convert.ToByte(this.checkBoxKhoaChatmat.Checked);
					Class62.smethod_10(Class53.string_3, "flagKhoaChatmat", Form1.int_9, "", 0);
				}
			}
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x001773A0 File Offset: 0x001755A0
		private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_47 = (int)Convert.ToByte(this.checkBoxPassword.Checked);
				Class62.smethod_10(Class53.string_3, "flagPassKeoNhieumay", Form1.int_47, "", 0);
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00177400 File Offset: 0x00175600
		private void numericUpDownPassword_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_48 = (int)this.numericUpDownPassword.Value;
				Class62.smethod_10(Class53.string_3, "PassKeoNhieumay", Form1.int_48, "", 0);
			}
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00177460 File Offset: 0x00175660
		private void numericUpDownPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_48 = (int)this.numericUpDownPassword.Value;
				Class62.smethod_10(Class53.string_3, "PassKeoNhieumay", Form1.int_48, "", 0);
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x001774C0 File Offset: 0x001756C0
		private void method_1(ListView listView_0, ref string[] string_7)
		{
			bool flag = string_7 == null || string_7.Length == 0;
			if (flag)
			{
				listView_0.Items.Clear();
				string_7 = null;
			}
			else
			{
				string text = string.Empty;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					bool selected = listView_0.Items[i].Selected;
					if (selected)
					{
						text = listView_0.Items[i].SubItems[0].Text;
						listView_0.Items.RemoveAt(i);
						break;
					}
				}
				bool flag2 = text == null || text == string.Empty;
				if (!flag2)
				{
					string[] array = new string[string_7.Length];
					int num = 0;
					for (int j = 0; j < string_7.Length; j++)
					{
						bool flag3 = text != Class10.smethod_1(string_7[j], 1, false);
						if (flag3)
						{
							array[num] = string_7[j];
							num++;
						}
					}
					bool flag4 = num != 0;
					if (flag4)
					{
						string_7 = new string[num];
						for (int k = 0; k < num; k++)
						{
							string_7[k] = array[k];
						}
					}
					else
					{
						listView_0.Items.Clear();
						string_7 = null;
					}
				}
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00177614 File Offset: 0x00175814
		private void method_2(ListView listView_0, string string_7, string[] string_8, ref string[] string_9)
		{
			bool flag = string_7 == null || string_7 == string.Empty || string_8 == null;
			if (!flag)
			{
				bool flag2 = string_9 != null;
				if (flag2)
				{
					for (int i = 0; i < string_9.Length; i++)
					{
						bool flag3 = string_7 == Class10.smethod_1(string_9[i], 1, false);
						if (flag3)
						{
							return;
						}
					}
				}
				for (int j = 0; j < string_8.Length; j++)
				{
					bool flag4 = string_7 == Class10.smethod_1(string_8[j], 1, false);
					if (flag4)
					{
						string_7 = string_8[j];
						break;
					}
				}
				bool flag5 = string_9 != null;
				if (flag5)
				{
					string[] array = new string[string_9.Length + 1];
					for (int k = 0; k < string_9.Length; k++)
					{
						array[k] = string_9[k];
					}
					string_9 = new string[array.Length];
					for (int l = 0; l < string_9.Length; l++)
					{
						string_9[l] = array[l];
					}
					string_9[string_9.Length - 1] = string_7;
				}
				else
				{
					string_9 = new string[]
					{
						string_7
					};
				}
				this.method_0(listView_0, Class10.smethod_1(string_7, 1, false));
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0017775C File Offset: 0x0017595C
		private void comboBoxLuonDanh_MouseDown(object sender, MouseEventArgs e)
		{
			FormRauria.string_4 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class98.smethod_24(Form1.gstruct49_0[i], ref FormRauria.string_4);
				}
			}
			this.comboBoxLuonDanh.Items.Clear();
			bool flag2 = FormRauria.string_4 != null;
			if (flag2)
			{
				Array.Sort<string>(FormRauria.string_4);
				for (int j = 0; j < FormRauria.string_4.Length; j++)
				{
					this.comboBoxLuonDanh.Items.Add(Class10.smethod_1(FormRauria.string_4[j], 1, false));
				}
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00177814 File Offset: 0x00175A14
		private void comboBoxKhongDanh_MouseDown(object sender, MouseEventArgs e)
		{
			FormRauria.string_5 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class98.smethod_24(Form1.gstruct49_0[i], ref FormRauria.string_5);
				}
			}
			this.comboBoxKhongDanh.Items.Clear();
			bool flag2 = FormRauria.string_5 != null;
			if (flag2)
			{
				Array.Sort<string>(FormRauria.string_5);
				for (int j = 0; j < FormRauria.string_5.Length; j++)
				{
					this.comboBoxKhongDanh.Items.Add(Class10.smethod_1(FormRauria.string_5[j], 1, false));
				}
			}
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x001778CC File Offset: 0x00175ACC
		private void comboBoxKhongdanhAc_MouseDown(object sender, MouseEventArgs e)
		{
			FormRauria.string_6 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class98.smethod_25(Form1.gstruct49_0[i], ref FormRauria.string_6, 1, null);
				}
			}
			this.comboBoxKhongdanhAc.Items.Clear();
			bool flag2 = FormRauria.string_6 != null;
			if (flag2)
			{
				Array.Sort<string>(FormRauria.string_6);
				for (int j = 0; j < FormRauria.string_6.Length; j++)
				{
					this.comboBoxKhongdanhAc.Items.Add(Class10.smethod_1(FormRauria.string_6[j], 1, false));
				}
			}
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00177988 File Offset: 0x00175B88
		private void checkBoxLuonDanhbang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Class7.int_1 = (int)Convert.ToByte(this.checkBoxLuonDanhbang.Checked);
				Class62.smethod_10(Class53.string_3, "flagLuonDanhBHO", Class7.int_1, "", 0);
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x001779E8 File Offset: 0x00175BE8
		private void checkBoxKhongdanhBang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Class7.int_2 = (int)Convert.ToByte(this.checkBoxKhongdanhBang.Checked);
				Class62.smethod_10(Class53.string_3, "flagKhongDanhBHO", Class7.int_2, "", 0);
			}
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00177A48 File Offset: 0x00175C48
		private void checkBoxKhongdanhAc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Class7.int_3 = (int)Convert.ToByte(this.checkBoxKhongdanhAc.Checked);
				Class62.smethod_10(Class53.string_3, "flagKhongdanhAc", Class7.int_3, "", 0);
			}
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00177AA8 File Offset: 0x00175CA8
		private void checkBoxDanhDenchet_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_50 = (int)Convert.ToByte(this.checkBoxDanhDenchet.Checked);
				Class62.smethod_10(Class53.string_3, "flagDanhDenchet", Form1.int_50, "", 0);
			}
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00177B08 File Offset: 0x00175D08
		private void textBoxTiepCan_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_51 = Class12.smethod_11(this.textBoxTiepCan.Text);
				Class62.smethod_10(Class53.string_3, "KCAcdanhTiepcan", Form1.int_51, "", 0);
			}
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00177B68 File Offset: 0x00175D68
		private void labelTiepcan_Click(object sender, EventArgs e)
		{
			string text = "KHOẢNG CÁCH TÌM AC CHÍNH CỦA AC ĐÁNH TIẾP CẬN||- Ac đánh tiếp cận ở đây là ac sử dụng chiêu đánh có phạm vi hiệu quả <= 180.|- Yêu cầu: Có check vào mục tiếp cận ở Bảng 1 của auto, và ô giá trị tiếp cận ghi 180 trở xuống.|";
			FormTip.smethod_0(Form1.string_1, text, 600000, 380, 140, false, -1, -1, false, false, false);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00177BA0 File Offset: 0x00175DA0
		private void buttonRandom_Click(object sender, EventArgs e)
		{
			this.bool_1 = false;
			Class72.int_2 = FormRauria.random_0.Next(FormRauria.int_9, FormRauria.int_10);
			this.textBoxPassServer.Text = Class72.int_2.ToString();
			Class62.smethod_10(Class53.string_3, "PortServer", Class72.int_2, "", 0);
			this.bool_1 = true;
			MessageBox.Show("Lưu ý ở máy phụ phải ghi đúng passowrd là " + Class72.int_2.ToString() + " thì mới kết nối được.", Form1.string_1, MessageBoxButtons.OK);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00177C30 File Offset: 0x00175E30
		private void textBoxIPConnect_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Class72.string_2 = this.textBoxIPConnect.Text.Trim();
				Class62.smethod_10(Class53.string_3, "ConnectIP", Class72.string_2, "", 0);
			}
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x00177C8C File Offset: 0x00175E8C
		private void textBoxConnectPass_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Class72.int_3 = Class12.smethod_11(this.textBoxConnectPass.Text.Trim());
					Class62.smethod_10(Class53.string_3, "nPort", Class72.int_3, "", 0);
				}
			}
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x00177CFC File Offset: 0x00175EFC
		private void comboBoxConnect_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				for (int i = 0; i < FormRauria.string_1.Length; i++)
				{
					bool flag2 = this.comboBoxConnect.Text == FormRauria.string_1[i];
					if (flag2)
					{
						Class72.int_1 = i;
						break;
					}
				}
				this.groupBoxHientai.Enabled = (Class72.int_1 == 0);
				this.groupBoxConnect.Enabled = (Class72.int_1 > 0);
				Class62.smethod_10(Class53.string_3, "KieuConnect", Class72.int_1, "", 0);
			}
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00177DB0 File Offset: 0x00175FB0
		private void buttonBatdau_Click(object sender, EventArgs e)
		{
			bool flag = Class72.int_1 > 0;
			if (flag)
			{
				bool flag2 = Class72.int_3 < FormRauria.int_9 || Class72.int_3 > FormRauria.int_10;
				if (flag2)
				{
					MessageBox.Show("Pasword không hợp lệ, nó phải giống như password ở máy chính.", Form1.string_1, MessageBoxButtons.OK);
					return;
				}
				FormCompatibility.smethod_5();
				Thread.Sleep(300);
				Class72.int_0 = 1;
				Class72.class74_0 = new Class74();
				new Thread(new ThreadStart(Class72.class74_0.method_1)).Start();
			}
			else
			{
				bool flag3 = Class72.string_2 == null || Class72.string_2 == string.Empty;
				if (flag3)
				{
					Class72.string_2 = this.comboBoxTabAddr.Text;
				}
				bool flag4 = Class72.int_2 < FormRauria.int_9 || Class72.int_2 > FormRauria.int_10;
				if (flag4)
				{
					Class72.int_2 = FormRauria.random_0.Next(FormRauria.int_9, FormRauria.int_10);
					Class62.smethod_10(Class53.string_3, "PortServer", Class72.int_2, "", 0);
					this.textBoxPassServer.Text = Class72.int_2.ToString();
					MessageBox.Show(string.Concat(new string[]
					{
						"Password phải là số từ ",
						FormRauria.int_9.ToString(),
						" -> ",
						FormRauria.int_10.ToString(),
						", auto tự động lấy lại password khác là ",
						Class72.int_2.ToString()
					}), Form1.string_1, MessageBoxButtons.OK);
				}
				FormCompatibility.smethod_5();
				Thread.Sleep(300);
				Class72.int_0 = 1;
				Class72.class73_0 = new Class73();
				new Thread(new ThreadStart(Class72.class73_0.method_1)).Start();
			}
			FormRauria.int_7 = -1;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00177F80 File Offset: 0x00176180
		private void buttonKetthuc_Click(object sender, EventArgs e)
		{
			Form1.int_6 = 0;
			this.checkBoxAcChinhNghelenh.Checked = false;
			Class72.int_0 = 0;
			try
			{
				bool flag = Class72.int_1 <= 0;
				if (flag)
				{
					Class72.class73_0.method_2();
				}
				else
				{
					Class72.class74_0.method_2();
				}
			}
			catch
			{
			}
			FormRauria.int_7 = -1;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00177FF0 File Offset: 0x001761F0
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			this.richTextBoxStatus.Text = string.Empty;
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00178004 File Offset: 0x00176204
		private void textBoxPassServer_Leave(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class12.smethod_11(this.textBoxPassServer.Text);
				bool flag2 = num < FormRauria.int_9 || num > FormRauria.int_10;
				if (flag2)
				{
					num = FormRauria.random_0.Next(FormRauria.int_9, FormRauria.int_10);
					this.textBoxPassServer.Text = num.ToString();
					MessageBox.Show(string.Concat(new string[]
					{
						"Password phải là số từ ",
						FormRauria.int_9.ToString(),
						" -> ",
						FormRauria.int_10.ToString(),
						", auto tự động lấy lại password khác là ",
						num.ToString()
					}), Form1.string_1, MessageBoxButtons.OK);
				}
				Class72.int_2 = num;
				Class62.smethod_10(Class53.string_3, "PortServer", Class72.int_2, "", 0);
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x001780FC File Offset: 0x001762FC
		private void textBoxKytuLenh_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				string text = this.textBoxKytuLenh.Text;
				bool flag2 = text == string.Empty;
				if (flag2)
				{
					text = "|";
				}
				FormMayphu.string_2 = text[0].ToString();
				Class62.smethod_10(Class53.string_3, "SMayphu", FormMayphu.string_2, "", 0);
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00178178 File Offset: 0x00176378
		private void comboBoxTabAddr_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Class72.string_1 = this.comboBoxTabAddr.Text;
				}
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x001781C0 File Offset: 0x001763C0
		private void buttonCopy_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.comboBoxTabAddr.Text);
			}
			catch
			{
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x001781F8 File Offset: 0x001763F8
		private void checkBoxThongbaoTHP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					Form1.int_119 = (int)Convert.ToByte(this.checkBoxThongbaoTHP.Checked);
					Class62.smethod_10(Class53.string_3, "fThongbaoTHP", Form1.int_119, "", 0);
				}
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00178264 File Offset: 0x00176464
		private void checkBoxBaoCsKenhbang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_15 = (int)Convert.ToByte(this.checkBoxBaoCsKenhbang.Checked);
				Class62.smethod_10(Class53.string_3, "flagBaoCuusatBang", Form1.int_15, "", 0);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x001782C4 File Offset: 0x001764C4
		private void comboBoxLuonDanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2(this.listViewLuonDanh, this.comboBoxLuonDanh.Text, FormRauria.string_4, ref Class7.string_4);
			Class7.smethod_1(Class7.string_4, Class7.string_0);
			Class7.uint_1 = Class7.smethod_2(Class7.string_4);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x00178314 File Offset: 0x00176514
		private void comboBoxKhongDanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2(this.listViewKhongDanh, this.comboBoxKhongDanh.Text, FormRauria.string_5, ref Class7.string_3);
			Class7.smethod_1(Class7.string_3, Class7.string_1);
			Class7.uint_0 = Class7.smethod_2(Class7.string_3);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00178363 File Offset: 0x00176563
		private void comboBoxKhongdanhAc_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2(this.listViewKhongdanhAc, this.comboBoxKhongdanhAc.Text, FormRauria.string_6, ref Class7.string_5);
			Class7.smethod_1(Class7.string_5, Class7.string_2);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00178398 File Offset: 0x00176598
		private void buttonXoaLuonDanh_Click(object sender, EventArgs e)
		{
			this.method_1(this.listViewLuonDanh, ref Class7.string_4);
			Class7.smethod_1(Class7.string_4, Class7.string_0);
			Class7.uint_1 = Class7.smethod_2(Class7.string_4);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x001783CC File Offset: 0x001765CC
		private void buttonKhongDanhBang_Click(object sender, EventArgs e)
		{
			this.method_1(this.listViewKhongDanh, ref Class7.string_3);
			Class7.smethod_1(Class7.string_3, Class7.string_1);
			Class7.uint_0 = Class7.smethod_2(Class7.string_3);
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x00178400 File Offset: 0x00176600
		private void buttonXoaDanhAc_Click(object sender, EventArgs e)
		{
			this.method_1(this.listViewKhongdanhAc, ref Class7.string_5);
			Class7.smethod_1(Class7.string_5, Class7.string_2);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00178428 File Offset: 0x00176628
		private void buttonPhimHd1_Click(object sender, EventArgs e)
		{
			string str = "https://youtu.be/i3Z-5BdmXF0";
			string text = "Phim hướng dẫn tại đây: " + str + "||(copy dán vào trình duyệt nếu không mở được)";
			FormTip.smethod_0(Form1.string_1, text, 600000, 440, 100, false, -1, -1, false, false, false);
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", str, 0, false, false);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x001784A4 File Offset: 0x001766A4
		private void buttonEpPT_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				int num = 0;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					GStruct59 gstruct = Class82.smethod_5(Form1.gstruct49_0[i]);
					bool flag2 = gstruct.int_0 <= 0;
					if (!flag2)
					{
						for (int j = 0; j < gstruct.int_0; j++)
						{
							bool flag3 = false;
							bool flag4 = Class7.string_5 != null;
							if (flag4)
							{
								for (int k = 0; k < Class7.string_5.Length; k++)
								{
									bool flag5 = Class7.string_5[k] == gstruct.gstruct58_0[j].string_0;
									if (flag5)
									{
										flag3 = true;
										break;
									}
								}
							}
							bool flag6 = !flag3;
							if (flag6)
							{
								bool flag7 = num == 0;
								if (flag7)
								{
									Class7.string_5 = new string[0];
									num = 1;
								}
								Array.Resize<string>(ref Class7.string_5, Class7.string_5.Length + 1);
								Class7.string_5[Class7.string_5.Length - 1] = gstruct.gstruct58_0[j].string_0;
							}
						}
					}
				}
				bool flag8 = num > 0;
				if (flag8)
				{
					this.listViewKhongdanhAc.Items.Clear();
					for (int l = 0; l < Class7.string_5.Length; l++)
					{
						this.method_0(this.listViewKhongdanhAc, Class10.smethod_1(Class7.string_5[l], 1, false));
					}
					Class7.smethod_1(Class7.string_5, Class7.string_2);
				}
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00178650 File Offset: 0x00176850
		private void buttonEpDanhBang_Click(object sender, EventArgs e)
		{
			bool flag = Form1.int_6 <= 0;
			if (flag)
			{
				bool flag2 = Form1.int_7 > 0;
				if (!flag2)
				{
					FormMayphu.bool_8 = true;
					FormRauria.bool_2 = true;
					this.buttonEpDanhBang.Enabled = false;
				}
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x001786A0 File Offset: 0x001768A0
		private void checkBoxLuongThuyTHP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Class35.int_0 = (int)Convert.ToByte(this.checkBoxLuongThuyTHP.Checked);
				Class62.smethod_10(Class53.string_3, "fChayboLThuydong", Class35.int_0, "", 0);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00178700 File Offset: 0x00176900
		private void checkBoxDelay_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_69 = (int)Convert.ToByte(this.checkBoxDelay.Checked);
				Class62.smethod_10(Class53.string_3, "fNguoiChoiTuGiam", Form1.int_69, "", 0);
				Class86.int_0 = -1;
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00178768 File Offset: 0x00176968
		private void textBoxValueDelay_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_70 = Class12.smethod_11(this.textBoxValueDelay.Text);
				bool flag2 = Form1.int_70 < 0;
				if (flag2)
				{
					Form1.int_70 = 0;
				}
				else
				{
					bool flag3 = Form1.int_70 > 1500;
					if (flag3)
					{
						Form1.int_70 = 1500;
					}
				}
				Class62.smethod_10(Class53.string_3, "vGiamDelay", Form1.int_70, "", 0);
				Class86.int_0 = -1;
			}
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00178800 File Offset: 0x00176A00
		private void checkBoxTienToida_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_61[0] = (int)Convert.ToByte(this.checkBoxTienToida.Checked);
				Class62.smethod_10(Class53.string_3, "RuttienMax_00", Form1.int_61[0], "", 0);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00178864 File Offset: 0x00176A64
		private void textBoxTienToida_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_61[1] = Class12.smethod_11(this.textBoxTienToida.Text);
				bool flag2 = Form1.int_61[1] < 30;
				if (flag2)
				{
					Form1.int_61[1] = 30;
				}
				Class62.smethod_10(Class53.string_3, "RuttienMax_01", Form1.int_61[1], "", 0);
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x001788E0 File Offset: 0x00176AE0
		private void checkBoxNhapMatma_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_85 = (int)Convert.ToByte(this.checkBoxNhapMatma.Checked);
				Class62.smethod_10(Class53.string_3, "fMatmaXaphu", Form1.int_85, "", 0);
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x00178940 File Offset: 0x00176B40
		private void labelMatma_Click(object sender, EventArgs e)
		{
			string str = "https://youtu.be/muQA6ZLOsmk";
			string text = "Phim hướng dẫn tại đây: " + str + "||(copy dán vào trình duyệt nếu không mở được)";
			FormTip.smethod_0(Form1.string_1, text, 600000, 440, 100, false, -1, -1, false, false, false);
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", str, 0, false, false);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x001789BC File Offset: 0x00176BBC
		private void checkBoxTatThongbaoDame_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_120 = (int)Convert.ToByte(this.checkBoxTatThongbaoDame.Checked);
				Class62.smethod_10(Class53.string_3, "fTatBaoDame", Form1.int_120, "", 0);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00178A1C File Offset: 0x00176C1C
		private void checkBoxMouseDrag_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_121 = (int)Convert.ToByte(this.checkBoxMouseDrag.Checked);
				Class62.smethod_10(Class53.string_3, "fBatMouseDrag", Form1.int_121, "", 0);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00178A7C File Offset: 0x00176C7C
		private void checkBoxDanhKhongten_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				Form1.int_117 = (int)Convert.ToByte(this.checkBoxDanhKhongten.Checked);
				Class62.smethod_10(Class53.string_3, "flagDanhKhongten", Form1.int_117, "", 0);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00178ADC File Offset: 0x00176CDC
		private void buttonTatFirewall_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/KuE7OasngXc";
			string text2 = string.Concat(new string[]
			{
				"Phim hướng dẫn tại đây: ",
				text,
				Class53.string_7,
				Class53.string_7,
				"(copy dán vào trình duyệt nếu không mở được)"
			});
			this.richTextBoxStatus.Text = text2;
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", text, 0, false, false);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00178B68 File Offset: 0x00176D68
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					FormMayphu.int_2 = Class12.smethod_11(this.textBox1.Text);
					Class62.smethod_10(Class53.string_3, "TocdoBaoToado", FormMayphu.int_2, "", 0);
				}
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00178BD4 File Offset: 0x00176DD4
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_1;
				if (!flag)
				{
					Form1.int_49 = (int)this.numericUpDown1.Value;
					Class62.smethod_10(Class53.string_3, "Mahoatoado", Form1.int_49, "", 0);
				}
			}
		}

		// Token: 0x04000B26 RID: 2854
		private IContainer icontainer_0 = null;

		// Token: 0x04000B8E RID: 2958
		public static bool bool_0 = false;

		// Token: 0x04000B8F RID: 2959
		public static int int_0 = 0;

		// Token: 0x04000B90 RID: 2960
		public static string string_0 = null;

		// Token: 0x04000B91 RID: 2961
		private static int int_1 = 0;

		// Token: 0x04000B92 RID: 2962
		public int int_2;

		// Token: 0x04000B93 RID: 2963
		public int int_3;

		// Token: 0x04000B94 RID: 2964
		public int int_4;

		// Token: 0x04000B95 RID: 2965
		public int int_5;

		// Token: 0x04000B96 RID: 2966
		private int int_6 = -1;

		// Token: 0x04000B97 RID: 2967
		private GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000B98 RID: 2968
		private static string[] string_1 = new string[]
		{
			"Đây là máy chính",
			"Đây là máy phụ"
		};

		// Token: 0x04000B99 RID: 2969
		private static string string_2 = null;

		// Token: 0x04000B9A RID: 2970
		private bool bool_1 = false;

		// Token: 0x04000B9B RID: 2971
		private static int int_7 = -1;

		// Token: 0x04000B9C RID: 2972
		private static int int_8 = 0;

		// Token: 0x04000B9D RID: 2973
		private static long long_0 = -1L;

		// Token: 0x04000B9E RID: 2974
		private static string string_3 = string.Empty;

		// Token: 0x04000B9F RID: 2975
		private static int int_9 = 5000;

		// Token: 0x04000BA0 RID: 2976
		private static int int_10 = 65000;

		// Token: 0x04000BA1 RID: 2977
		private static string[] string_4 = null;

		// Token: 0x04000BA2 RID: 2978
		private static string[] string_5 = null;

		// Token: 0x04000BA3 RID: 2979
		private static string[] string_6 = null;

		// Token: 0x04000BA4 RID: 2980
		private static Random random_0 = new Random();

		// Token: 0x04000BA6 RID: 2982
		private static bool bool_2 = false;
	}
}
