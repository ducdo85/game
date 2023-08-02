using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008B RID: 139
	public partial class FormTuychon : Form
	{
		// Token: 0x06000B64 RID: 2916 RVA: 0x0018A98A File Offset: 0x00188B8A
		public FormTuychon()
		{
			FormTuychon.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0018A9C0 File Offset: 0x00188BC0
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0018D058 File Offset: 0x0018B258
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = FormTuychon.int_1 <= 0;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_82 = (int)Convert.ToByte(this.checkBoxTheoThoigian.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
			bool flag3 = FormTuychon.int_2 > 0;
			if (flag3)
			{
				FormTuychon.int_2 = 2;
			}
			FormTuychon.int_0 = 0;
			FormTuychon.bool_0 = false;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0018D0E4 File Offset: 0x0018B2E4
		private void FormTuychon_Load(object sender, EventArgs e)
		{
			int num = FormTuychon.int_1 / 100;
			int num2 = FormTuychon.int_1 % 100;
			bool flag = num > 0;
			if (flag)
			{
				FormTuychon.int_1 = num;
			}
			FormTuychon.int_2 = 0;
			this.tabControl1.SelectedIndex = FormTuychon.int_1;
			bool flag2 = FormTuychon.int_1 > 0;
			if (flag2)
			{
				bool flag3 = FormTuychon.int_1 != 1;
				if (flag3)
				{
					bool flag4 = FormTuychon.int_1 == 2;
					if (flag4)
					{
						this.tabControl1.Controls.Remove(this.tabPage1);
						this.tabControl1.Controls.Remove(this.tabPage2);
						this.tabControl1.Controls.Remove(this.tabPage4);
						this.tabControl1.Controls.Remove(this.tabPage5);
						this.tabControl1.Controls.Remove(this.tabPage6);
						this.tabControl1.Controls.Remove(this.tabPage7);
						this.tabControl1.Controls.Remove(this.tabPage8);
						this.checkBoxTutimMuctieu.Checked = (Form1.int_34 > 0);
						this.checkBoxBossTruocNguoiSau.Checked = (Form1.int_36 > 0);
						this.checkBoxChetNamImAll.Checked = (Form1.int_38 > 0);
						switch (num2)
						{
						case 1:
							this.tabPage3.Text = "Ưu tiên đánh boss";
							this.checkBoxBossTruocNguoiSau.Location = new Point(6, 6);
							this.checkBoxTutimMuctieu.Visible = false;
							this.checkBoxChetNamImAll.Visible = false;
							break;
						case 2:
							this.tabPage3.Text = "Mục tiêu";
							this.checkBoxTutimMuctieu.Location = new Point(6, 6);
							this.checkBoxBossTruocNguoiSau.Visible = false;
							this.checkBoxChetNamImAll.Visible = false;
							break;
						case 3:
							this.tabPage3.Text = "Chết nằm im";
							this.checkBoxChetNamImAll.Location = new Point(6, 6);
							this.checkBoxTutimMuctieu.Visible = false;
							this.checkBoxBossTruocNguoiSau.Visible = false;
							FormTuychon.int_2 = 1;
							break;
						}
						this.tabControl1.Size = new Size(230, 75);
						base.ClientSize = new Size(235, 80);
					}
					else
					{
						bool flag5 = FormTuychon.int_1 != 3;
						if (flag5)
						{
							bool flag6 = FormTuychon.int_1 != 4;
							if (flag6)
							{
								bool flag7 = FormTuychon.int_1 != 5;
								if (flag7)
								{
									bool flag8 = FormTuychon.int_1 != 6;
									if (flag8)
									{
										bool flag9 = FormTuychon.int_1 == 7;
										if (flag9)
										{
											this.tabControl1.Controls.Remove(this.tabPage1);
											this.tabControl1.Controls.Remove(this.tabPage2);
											this.tabControl1.Controls.Remove(this.tabPage3);
											this.tabControl1.Controls.Remove(this.tabPage4);
											this.tabControl1.Controls.Remove(this.tabPage5);
											this.tabControl1.Controls.Remove(this.tabPage6);
											this.tabControl1.Controls.Remove(this.tabPage7);
											this.tabPage8.Text = "Quăng tiếp thuốc";
											this.checkBoxQuangThuoc.Checked = (Form1.int_27 > 0);
											this.checkBoxTDP.Checked = (Form1.int_28 > 0);
										}
									}
									else
									{
										this.tabControl1.Controls.Remove(this.tabPage1);
										this.tabControl1.Controls.Remove(this.tabPage2);
										this.tabControl1.Controls.Remove(this.tabPage3);
										this.tabControl1.Controls.Remove(this.tabPage4);
										this.tabControl1.Controls.Remove(this.tabPage5);
										this.tabControl1.Controls.Remove(this.tabPage6);
										this.tabControl1.Controls.Remove(this.tabPage8);
										this.tabPage7.Text = "Kiểu mua thuốc ở Bảo vật (toàn cục)";
										base.ClientSize = new Size(330, 275);
										this.checkBoxMuaNoiChiendau.Checked = (Form1.int_29 > 0);
										this.textBoxSaisoBaovat.Text = Form1.int_5.ToString();
										bool flag10 = this.struct23_0 == null && Form1.gstruct49_0 != null;
										if (flag10)
										{
											for (int i = 0; i < Form1.gstruct49_0.Length; i++)
											{
												this.struct23_0 = Class83.smethod_1(Form1.gstruct49_0[i]);
												bool flag11 = this.struct23_0 != null;
												if (flag11)
												{
													break;
												}
											}
										}
										bool flag12 = Class17.string_0 == null;
										if (flag12)
										{
											Class17.string_0 = new string[3];
										}
										bool flag13 = this.struct23_0 == null;
										if (flag13)
										{
											bool flag14 = Class17.string_0[0] != null && Class17.string_0[0] != string.Empty;
											if (flag14)
											{
												string text = Class10.smethod_1(Class17.string_0[0], 1, false);
												this.comboBox1.Items.Add(text);
												this.comboBox1.Text = text;
											}
											bool flag15 = Class17.string_0[1] != null && Class17.string_0[1] != string.Empty;
											if (flag15)
											{
												string text2 = Class10.smethod_1(Class17.string_0[1], 1, false);
												this.comboBox2.Items.Add(text2);
												this.comboBox2.Text = text2;
											}
											bool flag16 = Class17.string_0[2] != null && Class17.string_0[2] != string.Empty;
											if (flag16)
											{
												string text3 = Class10.smethod_1(Class17.string_0[2], 1, false);
												this.comboBox3.Items.Add(text3);
												this.comboBox3.Text = text3;
											}
										}
										else
										{
											bool flag17 = false;
											bool flag18 = false;
											bool flag19 = false;
											for (int j = 0; j < this.struct23_0.Length; j++)
											{
												string text4 = Class10.smethod_1(this.struct23_0[j].string_0, 1, false);
												this.comboBox1.Items.Add(text4);
												this.comboBox2.Items.Add(text4);
												this.comboBox3.Items.Add(text4);
												bool flag20 = this.struct23_0[j].string_0 == Class17.string_0[0];
												if (flag20)
												{
													this.comboBox1.Text = text4;
													flag17 = true;
												}
												bool flag21 = this.struct23_0[j].string_0 == Class17.string_0[1];
												if (flag21)
												{
													this.comboBox2.Text = text4;
													flag18 = true;
												}
												bool flag22 = this.struct23_0[j].string_0 == Class17.string_0[2];
												if (flag22)
												{
													this.comboBox3.Text = text4;
													flag19 = true;
												}
											}
											bool flag23 = !flag17;
											if (flag23)
											{
												this.comboBox1.Text = this.comboBox1.Items[0].ToString();
												Class17.string_0[0] = this.struct23_0[0].string_0;
												Class62.smethod_10(Class53.string_3, "KTCTabName0", Class12.smethod_16(this.struct23_0[0].string_0), "", 0);
											}
											bool flag24 = !flag18;
											if (flag24)
											{
												this.comboBox2.Text = this.comboBox2.Items[0].ToString();
												Class17.string_0[1] = this.struct23_0[0].string_0;
												Class62.smethod_10(Class53.string_3, "KTCTabName1", Class12.smethod_16(this.struct23_0[0].string_0), "", 0);
											}
											bool flag25 = !flag19;
											if (flag25)
											{
												this.comboBox3.Text = this.comboBox3.Items[0].ToString();
												Class17.string_0[2] = this.struct23_0[0].string_0;
												Class62.smethod_10(Class53.string_3, "KTCTabName2", Class12.smethod_16(this.struct23_0[0].string_0), "", 0);
											}
										}
									}
								}
								else
								{
									this.tabControl1.Controls.Remove(this.tabPage1);
									this.tabControl1.Controls.Remove(this.tabPage2);
									this.tabControl1.Controls.Remove(this.tabPage3);
									this.tabControl1.Controls.Remove(this.tabPage4);
									this.tabControl1.Controls.Remove(this.tabPage5);
									this.tabControl1.Controls.Remove(this.tabPage7);
									this.tabControl1.Controls.Remove(this.tabPage8);
									this.tabPage6.Text = "Báo Boss";
									this.tabControl1.Size = new Size(170, 175);
									base.ClientSize = new Size(175, 178);
									this.checkBoxBosKenhKhac.Checked = (Class90.int_0[0] > 0);
									this.checkBoxBosKenhBang.Checked = (Class90.int_0[2] > 0);
									this.checkBoxBosPhongTan.Checked = (Class90.int_0[1] > 0);
									this.textBoxBosGiay.Text = Class90.int_0[3].ToString();
									this.checkBoxChiTiet.Checked = (Class90.int_1 > 0);
								}
							}
							else
							{
								this.tabControl1.Controls.Remove(this.tabPage1);
								this.tabControl1.Controls.Remove(this.tabPage2);
								this.tabControl1.Controls.Remove(this.tabPage3);
								this.tabControl1.Controls.Remove(this.tabPage4);
								this.tabControl1.Controls.Remove(this.tabPage6);
								this.tabControl1.Controls.Remove(this.tabPage7);
								this.tabControl1.Controls.Remove(this.tabPage8);
								this.tabPage5.Text = "Sửa đồ";
							}
						}
						else
						{
							this.tabControl1.Controls.Remove(this.tabPage1);
							this.tabControl1.Controls.Remove(this.tabPage2);
							this.tabControl1.Controls.Remove(this.tabPage3);
							this.tabControl1.Controls.Remove(this.tabPage5);
							this.tabControl1.Controls.Remove(this.tabPage6);
							this.tabControl1.Controls.Remove(this.tabPage7);
							this.tabControl1.Controls.Remove(this.tabPage8);
							this.tabPage4.Text = "Đánh khoảng cách";
						}
					}
				}
				else
				{
					for (int k = 0; k < Class27.gstruct40_0.Length; k++)
					{
						this.comboBoxPhim.Items.Add(Class27.gstruct40_0[k].string_0);
					}
					this.comboBoxPhim.Text = Class27.gstruct40_0[Form1.int_100].string_0;
					this.checkBoxBamphim.Checked = (Form1.int_99 > 0);
					this.tabControl1.Controls.Remove(this.tabPage1);
					this.tabControl1.Controls.Remove(this.tabPage3);
					this.tabControl1.Controls.Remove(this.tabPage4);
					this.tabControl1.Controls.Remove(this.tabPage5);
					this.tabControl1.Controls.Remove(this.tabPage6);
					this.tabControl1.Controls.Remove(this.tabPage7);
					this.tabControl1.Controls.Remove(this.tabPage8);
					this.tabPage2.Text = "Skill 120 Thiên Nhẫn";
				}
			}
			else
			{
				int num3 = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
				bool flag26 = 0 <= num3;
				if (flag26)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num3];
					this.textBoxGiaiBua.Text = gstruct.int_85.ToString();
					this.checkBoxDinhbangsat.Checked = (gstruct.int_81 > 0);
					this.checkBoxTheoBua.Checked = (gstruct.int_82 <= 0);
					this.checkBoxTheoThoigian.Checked = (gstruct.int_82 > 0);
					this.textBoxThoigianGiaibua.Text = gstruct.int_87.ToString();
					this.checkBoxApdungAllThoigian.Checked = true;
					this.struct23_0 = Class83.smethod_1(gstruct);
				}
				this.tabControl1.Controls.Remove(this.tabPage2);
				this.tabControl1.Controls.Remove(this.tabPage3);
				this.tabControl1.Controls.Remove(this.tabPage4);
				this.tabControl1.Controls.Remove(this.tabPage5);
				this.tabControl1.Controls.Remove(this.tabPage6);
				this.tabControl1.Controls.Remove(this.tabPage7);
				this.tabControl1.Controls.Remove(this.tabPage8);
				this.tabPage1.Text = "Skill 120 Võ Đang";
			}
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0018DF88 File Offset: 0x0018C188
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTuychon.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0018DFAC File Offset: 0x0018C1AC
		private void checkBoxDinhbangsat_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				this.buttonApdungAll.Enabled = true;
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_81 = (int)Convert.ToByte(this.checkBoxDinhbangsat.Checked);
				}
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0018E014 File Offset: 0x0018C214
		private void textBoxGiaiBua_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				this.buttonApdungAll.Enabled = true;
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_85 = Class12.smethod_11(this.textBoxGiaiBua.Text);
				}
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0018E07C File Offset: 0x0018C27C
		private void checkBoxTheoBua_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				this.checkBoxTheoThoigian.Checked = !this.checkBoxTheoBua.Checked;
				this.buttonApdungAll.Enabled = true;
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0018E0C4 File Offset: 0x0018C2C4
		private void checkBoxTheoThoigian_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				this.checkBoxTheoBua.Checked = !this.checkBoxTheoThoigian.Checked;
				this.buttonApdungAll.Enabled = true;
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0018E10C File Offset: 0x0018C30C
		private void textBoxThoigianGiaibua_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				this.buttonApdungAll.Enabled = true;
				int num = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_87 = Class12.smethod_11(this.textBoxThoigianGiaibua.Text);
				}
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0018E174 File Offset: 0x0018C374
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				int int_ = Class12.smethod_11(this.textBoxGiaiBua.Text);
				int int_2 = (int)Convert.ToByte(this.checkBoxTheoThoigian.Checked);
				int int_3 = Class12.smethod_11(this.textBoxThoigianGiaibua.Text);
				int int_4 = (int)Convert.ToByte(this.checkBoxDinhbangsat.Checked);
				bool @checked = this.checkBoxApdungAllThoigian.Checked;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					string a = Class77.smethod_18(Form1.gstruct49_0[i], null);
					bool flag2 = a != "VODANG";
					if (!flag2)
					{
						int num = Class77.smethod_16(Form1.gstruct49_0[i], 716);
						bool flag3 = num > 0;
						if (flag3)
						{
							Form1.gstruct49_0[i].int_82 = int_2;
							Form1.gstruct49_0[i].int_81 = int_4;
							bool flag4 = @checked;
							if (flag4)
							{
								Form1.gstruct49_0[i].int_85 = int_;
								Form1.gstruct49_0[i].int_87 = int_3;
							}
						}
					}
				}
				this.buttonApdungAll.Enabled = false;
			}
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0018E2B8 File Offset: 0x0018C4B8
		private void checkBoxBamphim_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_99 = (int)Convert.ToByte(this.checkBoxBamphim.Checked);
				Class62.smethod_10(Class53.string_3, "flagTNBamPhim", Form1.int_99, "", 0);
				bool flag = Form1.int_99 > 0 && Form1.int_63 <= 0;
				if (flag)
				{
					Form1.int_63 = 1;
					GClass0.smethod_1();
					GClass0.smethod_0();
				}
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0018E33C File Offset: 0x0018C53C
		private void comboBoxPhim_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBoxPhim.Text;
				for (int i = 0; i < Class27.gstruct40_0.Length; i++)
				{
					bool flag2 = text == Class27.gstruct40_0[i].string_0;
					if (flag2)
					{
						bool flag3 = Form1.int_100 != i;
						if (flag3)
						{
							Form1.int_100 = i;
							Class62.smethod_10(Class53.string_3, "TNIdexPhim", Form1.int_100, "", 0);
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0018E3DC File Offset: 0x0018C5DC
		private void checkBoxTutimMuctieu_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_34 = (int)Convert.ToByte(this.checkBoxTutimMuctieu.Checked);
				Class62.smethod_10(Class53.string_3, "flagTutimMuctieu", Form1.int_34, "", 0);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0018E430 File Offset: 0x0018C630
		private void buttonApdung_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].int_88 = 0;
					Class53.smethod_13(Form1.gstruct49_0[i], null);
				}
			}
			FormTuychon.bool_0 = false;
			base.Close();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0018E494 File Offset: 0x0018C694
		private void checkBoxBossTruocNguoiSau_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_36 = (int)Convert.ToByte(this.checkBoxBossTruocNguoiSau.Checked);
				Class62.smethod_10(Class53.string_3, "BossTruocNguoiSau", Form1.int_36, "", 0);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0018E4E8 File Offset: 0x0018C6E8
		private void checkBoxChetNamImAll_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_38 = (int)Convert.ToByte(this.checkBoxChetNamImAll.Checked);
				Class62.smethod_10(Class53.string_3, "fNamImONOFF", Form1.int_38, "", 0);
			}
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0018E53C File Offset: 0x0018C73C
		private void checkBoxBosKenhKhac_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class90.int_0[0] = (int)Convert.ToByte(this.checkBoxBosKenhKhac.Checked);
				Class62.smethod_10(Class53.string_3, "KenhKhac", Class90.int_0[0], "", 0);
			}
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0018E594 File Offset: 0x0018C794
		private void checkBoxBosPhongTan_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class90.int_0[1] = (int)Convert.ToByte(this.checkBoxBosPhongTan.Checked);
				Class62.smethod_10(Class53.string_3, "PhongTan", Class90.int_0[1], "", 0);
			}
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0018E5EC File Offset: 0x0018C7EC
		private void checkBoxBosKenhBang_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class90.int_0[2] = (int)Convert.ToByte(this.checkBoxBosKenhBang.Checked);
				Class62.smethod_10(Class53.string_3, "KenhBang", Class90.int_0[2], "", 0);
			}
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0018E644 File Offset: 0x0018C844
		private void textBoxBosGiay_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class90.int_0[3] = Class12.smethod_11(this.textBoxBosGiay.Text);
				Class62.smethod_10(Class53.string_3, "BaoTime", Class90.int_0[3], "", 0);
			}
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0018E69C File Offset: 0x0018C89C
		private void checkBoxMuaNoiChiendau_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_29 = (int)Convert.ToByte(this.checkBoxMuaNoiChiendau.Checked);
				Class62.smethod_10(Class53.string_3, "fMuaNoiChiendau", Form1.int_29, "", 0);
			}
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0018E6F0 File Offset: 0x0018C8F0
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || this.struct23_0 == null;
			if (!flag)
			{
				string text = this.comboBox1.Text;
				for (int i = 0; i < this.struct23_0.Length; i++)
				{
					string a = Class10.smethod_1(this.struct23_0[i].string_0, 1, false);
					bool flag2 = a == text;
					if (flag2)
					{
						Class17.string_0[0] = this.struct23_0[i].string_0;
						Class62.smethod_10(Class53.string_3, "KTCTabName0", Class12.smethod_16(this.struct23_0[i].string_0), "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0018E7B8 File Offset: 0x0018C9B8
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || this.struct23_0 == null;
			if (!flag)
			{
				string text = this.comboBox2.Text;
				int num = 0;
				for (;;)
				{
					bool flag2 = num < this.struct23_0.Length;
					if (!flag2)
					{
						goto IL_74;
					}
					string a = Class10.smethod_1(this.struct23_0[num].string_0, 1, false);
					bool flag3 = a == text;
					if (flag3)
					{
						break;
					}
					num++;
				}
				Class17.string_0[1] = this.struct23_0[num].string_0;
				Class62.smethod_10(Class53.string_3, "KTCTabName1", Class12.smethod_16(this.struct23_0[num].string_0), "", 0);
				IL_74:;
			}
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0018E884 File Offset: 0x0018CA84
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || this.struct23_0 == null;
			if (!flag)
			{
				string text = this.comboBox3.Text;
				for (int i = 0; i < this.struct23_0.Length; i++)
				{
					string a = Class10.smethod_1(this.struct23_0[i].string_0, 1, false);
					bool flag2 = a == text;
					if (flag2)
					{
						Class17.string_0[2] = this.struct23_0[i].string_0;
						Class62.smethod_10(Class53.string_3, "KTCTabName2", Class12.smethod_16(this.struct23_0[i].string_0), "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0018E94C File Offset: 0x0018CB4C
		private void checkBoxChiTiet_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class90.int_1 = (int)Convert.ToByte(this.checkBoxChiTiet.Checked);
				Class62.smethod_10(Class53.string_3, "Chitiet", Class90.int_1, "", 0);
			}
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0018E9A0 File Offset: 0x0018CBA0
		private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_27 = (int)Convert.ToByte(this.checkBoxQuangThuoc.Checked);
				Class62.smethod_10(Class53.string_3, "fQuangThuocAchinh", Form1.int_27, "", 0);
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0018E9F4 File Offset: 0x0018CBF4
		private void checkBoxTDP_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Form1.int_28 = (int)Convert.ToByte(this.checkBoxTDP.Checked);
				Class62.smethod_10(Class53.string_3, "fQuangThuocTDP", Form1.int_28, "", 0);
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0018EA48 File Offset: 0x0018CC48
		private void buttonBaovatXoaSaiso_Click(object sender, EventArgs e)
		{
			Form1.int_5 = 0;
			Class62.smethod_10(Class53.string_3, "SaisoBaovat", Form1.int_5, "", 0);
			this.textBoxSaisoBaovat.Text = Form1.int_5.ToString();
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0018EA88 File Offset: 0x0018CC88
		private void buttonTimSaiso_Click(object sender, EventArgs e)
		{
			string string_ = "Hãy chọn 1 ac rồi bấm nút < Bảo vật > và bấm nút < " + this.buttonTimSaiso.Text + "> này.";
			int num = -1000000;
			int num2 = Class81.smethod_3(Form1.gstruct49_0, FormTuychon.int_0);
			bool flag = 0 <= num2;
			if (flag)
			{
				num = Class70.smethod_29(Form1.gstruct49_0[num2]);
			}
			bool flag2 = -1000002 <= num && num <= -1000000 && Form1.gstruct49_0 != null;
			if (flag2)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					num = Class70.smethod_29(Form1.gstruct49_0[i]);
					bool flag3 = num > -1000000 || num < -1000002;
					if (flag3)
					{
						break;
					}
				}
			}
			bool flag4 = num <= -1000000 && num >= -1000002;
			if (flag4)
			{
				int num3 = num;
				int num4 = num3;
				if (num4 != -1000001)
				{
					if (num4 != -1000000)
					{
						string_ = "Hãy bấm nút Mua cho ac <" + Class10.smethod_1(Form1.gstruct49_0[num2].string_22, 1, false) + "> sau đó lấy lại giá trị.";
					}
					else
					{
						string_ = "Hãy chọn 1 ac rồi bấm nút < Bảo vật > và bấm nút < " + this.buttonTimSaiso.Text + "> này.";
					}
				}
				else
				{
					string_ = "Không lấy được giá trị, hãy mở Bảo vật và bấm nút Mua cho ac <" + Class10.smethod_1(Form1.gstruct49_0[num2].string_22, 1, false) + "> sau đó lấy lại giá trị.";
				}
			}
			else
			{
				int num5 = Form1.int_5 = (num - 2208) / 16;
				Class62.smethod_10(Class53.string_3, "SaisoBaovat", Form1.int_5, "", 0);
				this.textBoxSaisoBaovat.Text = num5.ToString();
				string_ = string.Concat(new string[]
				{
					"Đã lấy được giá trị sai số là: ",
					num5.ToString(),
					". ",
					Class53.string_7,
					"Có thể mua vật phẩm ở Bảo vật được rồi !"
				});
			}
			FormTip.smethod_0(Form1.string_1, string_, 60000, 250, 100, false, -1, -1, false, false, false);
		}

		// Token: 0x04000CF3 RID: 3315
		private IContainer icontainer_0 = null;

		// Token: 0x04000D26 RID: 3366
		public static bool bool_0;

		// Token: 0x04000D27 RID: 3367
		public static int int_0;

		// Token: 0x04000D28 RID: 3368
		public static int int_1;

		// Token: 0x04000D29 RID: 3369
		public static int int_2;

		// Token: 0x04000D2B RID: 3371
		private Struct23[] struct23_0 = null;
	}
}
