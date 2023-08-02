using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000074 RID: 116
	public partial class FormLocdoTest : Form
	{
		// Token: 0x06000929 RID: 2345 RVA: 0x00152209 File Offset: 0x00150409
		public FormLocdoTest()
		{
			FormLocdoTest.bool_2 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00152244 File Offset: 0x00150444
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00153CD8 File Offset: 0x00151ED8
		public static GStruct61[] smethod_0()
		{
			string text = Class12.smethod_15(Class12.smethod_33(Class53.string_9 + "\\LocNop.txt", 0, 0, 1));
			bool flag = text != null;
			if (flag)
			{
				bool flag2 = text == string.Empty;
				if (!flag2)
				{
					string[] array = text.Split(new char[]
					{
						'|'
					});
					GStruct61[] array2 = new GStruct61[array.Length];
					int num = 0;
					for (int i = 0; i < array.Length; i++)
					{
						bool flag3 = array[i] != null;
						if (flag3)
						{
							bool flag4 = array[i] == string.Empty;
							if (!flag4)
							{
								string[] array3 = array[i].Split(new char[]
								{
									';'
								});
								bool flag5 = array3.Length == 2;
								if (flag5)
								{
									array2[num].string_0 = array3[0];
									array2[num].int_0 = Class12.smethod_11(array3[1]);
									num++;
								}
							}
						}
					}
					bool flag6 = num == 0;
					if (flag6)
					{
						return null;
					}
					bool flag7 = num < array2.Length;
					if (flag7)
					{
						Array.Resize<GStruct61>(ref array2, num);
					}
					return array2;
				}
			}
			return null;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00153E1C File Offset: 0x0015201C
		public static void smethod_1(GStruct61[] gstruct61_1)
		{
			string text = string.Empty;
			bool flag = gstruct61_1 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct61_1.Length; i++)
				{
					bool flag2 = text != string.Empty;
					if (flag2)
					{
						text += "|";
					}
					object obj = text;
					text = string.Concat(new object[]
					{
						obj,
						gstruct61_1[i].string_0,
						";",
						gstruct61_1[i].int_0
					});
				}
				text = Class12.smethod_16(text);
			}
			Class12.smethod_34(Class53.string_9 + "\\LocNop.txt", text, 1);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00153EC8 File Offset: 0x001520C8
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormLocdoTest.smethod_1(FormLocdoTest.gstruct61_0);
			this.int_14 = 0;
			this.int_15 = 0;
			FormLocdoTest.bool_2 = false;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00153EEC File Offset: 0x001520EC
		private void FormLocdoTest_Load(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			bool flag = this.int_14 >= 0 && this.int_15 >= 0;
			if (flag)
			{
				int num = this.int_14 - base.Width;
				int num2 = this.int_15 + this.int_17 - base.Height;
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
			base.TopMost = true;
			FormLocdoTest.gstruct61_0 = FormLocdoTest.smethod_0();
			bool flag4 = FormLocdoTest.gstruct61_0 != null;
			if (flag4)
			{
				for (int i = 0; i < FormLocdoTest.gstruct61_0.Length; i++)
				{
					this.method_0(FormLocdoTest.gstruct61_0[i]);
				}
			}
			this.checkBoxCoNopVP.Checked = (FormLocdoTest.int_6 > 0);
			this.checkBox1.Checked = (FormLocdoTest.int_7[0] > 0);
			this.textBox1.Text = FormLocdoTest.int_7[1].ToString();
			this.checkBox2.Checked = (FormLocdoTest.int_8[0] > 0);
			this.textBox2.Text = FormLocdoTest.int_8[1].ToString();
			this.checkBox3.Checked = (FormLocdoTest.int_9[0] > 0);
			this.textBox3.Text = FormLocdoTest.int_9[1].ToString();
			this.checkBox4.Checked = (FormLocdoTest.int_10[0] > 0);
			this.textBox4.Text = FormLocdoTest.int_10[1].ToString();
			this.checkBox5.Checked = (FormLocdoTest.int_11[0] > 0);
			this.textBox5.Text = FormLocdoTest.int_11[1].ToString();
			this.checkBox6.Checked = (FormLocdoTest.int_12[0] > 0);
			this.textBox6.Text = FormLocdoTest.int_12[1].ToString();
			this.checkBoxBanVpHoagkimTest.Checked = FormLocdoTest.bool_1;
			this.checkBoxThoahet.Checked = FormLocdoTest.bool_0;
			this.checkBoxLocTrangbi.Checked = (FormLocdoTest.int_5[0] > 0);
			for (int j = 0; j < FormLocdoTest.string_2.Length; j++)
			{
				this.comboBoxLocTrangbi.Items.Add(FormLocdoTest.string_2[j]);
			}
			this.comboBoxLocTrangbi.Text = FormLocdoTest.string_2[FormLocdoTest.int_5[1]];
			int num3 = Class81.smethod_3(Form1.gstruct49_0, FormLocdoTest.int_0);
			bool flag5 = 0 > num3;
			if (flag5)
			{
				GStruct37 gstruct37_ = new GStruct37
				{
					string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé."
				};
				this.method_1(gstruct37_);
				this.method_2("Loc do * Chua chon ac nao");
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num3];
				bool flag6 = gstruct.gstruct37_0 != null;
				if (flag6)
				{
					for (int k = 0; k < gstruct.gstruct37_0.Length; k++)
					{
						this.method_1(gstruct.gstruct37_0[k]);
					}
					for (int l = 0; l < gstruct.gstruct37_0.Length; l++)
					{
						bool flag7 = l < this.listView1.Items.Count && gstruct.gstruct37_0[l].int_0 > 0;
						if (flag7)
						{
							this.listView1.Items[l].Checked = true;
							this.listView1.Items[l].ForeColor = this.color_0;
						}
					}
				}
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x001542E4 File Offset: 0x001524E4
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormLocdoTest.bool_2;
			if (flag)
			{
				bool flag2 = FormLocdoTest.long_0 > 0L && Class12.smethod_28(FormLocdoTest.long_0) > 300L;
				if (flag2)
				{
					this.buttonApdungAll.Enabled = true;
					FormLocdoTest.long_0 = 0L;
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00154340 File Offset: 0x00152540
		private void method_0(GStruct61 gstruct61_1)
		{
			bool flag = gstruct61_1.string_0 == null || gstruct61_1.string_0 == string.Empty;
			if (!flag)
			{
				int num = 0;
				try
				{
					bool flag2 = this.listView2.Items != null;
					if (flag2)
					{
						num = this.listView2.Items.Count;
					}
					string[] array = new string[]
					{
						num.ToString(),
						Class10.smethod_1(gstruct61_1.string_0, 1, false),
						gstruct61_1.int_0.ToString()
					};
					ListViewItem listViewItem = new ListViewItem(array[0]);
					bool flag3 = array.Length > 1;
					if (flag3)
					{
						for (int i = 1; i < array.Length; i++)
						{
							ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
							listViewItem.SubItems.Add(item);
						}
					}
					this.listView2.Items.Add(listViewItem);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00154440 File Offset: 0x00152640
		private void method_1(GStruct37 gstruct37_0)
		{
			int num = 0;
			try
			{
				bool flag = this.listView1.Items != null;
				if (flag)
				{
					num = this.listView1.Items.Count;
				}
				string[] array = new string[]
				{
					num.ToString(),
					gstruct37_0.string_0,
					gstruct37_0.int_2.ToString(),
					gstruct37_0.int_3.ToString()
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag2 = array.Length > 1;
				if (flag2)
				{
					for (int i = 1; i < array.Length; i++)
					{
						ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
						listViewItem.SubItems.Add(item);
					}
				}
				this.listView1.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00154524 File Offset: 0x00152724
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.Items == null || this.listView1.Items.Count == 0;
			if (!flag)
			{
				int num = 0;
				for (;;)
				{
					bool flag2 = num < this.listView1.Items.Count;
					if (!flag2)
					{
						goto IL_6C;
					}
					bool selected = this.listView1.Items[num].Selected;
					if (selected)
					{
						break;
					}
					num++;
				}
				this.textBoxName.Text = num.ToString() + ". " + this.listView1.Items[num].SubItems[1].Text;
				this.textBoxMin.Text = this.listView1.Items[num].SubItems[2].Text;
				this.textBoxDong.Text = this.listView1.Items[num].SubItems[3].Text;
				IL_6C:;
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00154640 File Offset: 0x00152840
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdoTest.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(e.NewValue);
					Form1.gstruct49_0[num].gstruct37_0[e.Index].int_0 = num2;
					bool flag3 = num2 > 0;
					if (flag3)
					{
						this.listView1.Items[e.Index].ForeColor = this.color_0;
					}
					else
					{
						this.listView1.Items[e.Index].ForeColor = Color.Black;
					}
				}
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00154708 File Offset: 0x00152908
		private void buttonSua_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdoTest.int_0);
			bool flag = num < 0;
			if (!flag)
			{
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						Form1.gstruct49_0[num].gstruct37_0[i].int_2 = Class12.smethod_11(this.textBoxMin.Text);
						Form1.gstruct49_0[num].gstruct37_0[i].int_3 = Class12.smethod_11(this.textBoxDong.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
						this.listView1.Items[i].SubItems[2].Text = Class12.smethod_11(this.textBoxMin.Text).ToString();
						this.listView1.Items[i].SubItems[3].Text = Class12.smethod_11(this.textBoxDong.Text).ToString();
						break;
					}
				}
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0015485C File Offset: 0x00152A5C
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdoTest.int_0);
			bool flag = Form1.gstruct49_0 == null || num < 0;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = num != i;
					if (flag2)
					{
						bool flag3 = Form1.gstruct49_0[i].gstruct37_0 == null;
						if (flag3)
						{
							Form1.gstruct49_0[i].gstruct37_0 = Class53.smethod_1();
						}
						for (int j = 0; j < Form1.gstruct49_0[i].gstruct37_0.Length; j++)
						{
							Form1.gstruct49_0[i].gstruct37_0[j].int_0 = Form1.gstruct49_0[num].gstruct37_0[j].int_0;
							Form1.gstruct49_0[i].gstruct37_0[j].int_2 = Form1.gstruct49_0[num].gstruct37_0[j].int_2;
							Form1.gstruct49_0[i].gstruct37_0[j].int_3 = Form1.gstruct49_0[num].gstruct37_0[j].int_3;
							Class53.smethod_13(Form1.gstruct49_0[i], null);
						}
					}
				}
				this.textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
				FormLocdoTest.long_0 = Class12.smethod_27();
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x001549F4 File Offset: 0x00152BF4
		private void checkBoxBanVpHoagkimTest_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.bool_1 = this.checkBoxBanVpHoagkimTest.Checked;
				Class62.smethod_10(Class53.string_3, "flagBanTrangbiHoangKimTest", Convert.ToByte(FormLocdoTest.bool_1), "", 0);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00154A48 File Offset: 0x00152C48
		private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.bool_0 = this.checkBoxThoahet.Checked;
				Class62.smethod_10(Class53.string_3, "flagLocThoahetDieukien", Convert.ToByte(FormLocdoTest.bool_0), "", 0);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00154A9C File Offset: 0x00152C9C
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_7[0] = (int)Convert.ToByte(this.checkBox1.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong1_0", FormLocdoTest.int_7[0], "", 0);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00154AF4 File Offset: 0x00152CF4
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_7[1] = Class12.smethod_11(this.textBox1.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong1_1", FormLocdoTest.int_7[1], "", 0);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00154B4C File Offset: 0x00152D4C
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_8[0] = (int)Convert.ToByte(this.checkBox2.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong2_0", FormLocdoTest.int_8[0], "", 0);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00154BA4 File Offset: 0x00152DA4
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_8[1] = Class12.smethod_11(this.textBox2.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong2_1", FormLocdoTest.int_8[1], "", 0);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00154BFC File Offset: 0x00152DFC
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_9[0] = (int)Convert.ToByte(this.checkBox3.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong3_0", FormLocdoTest.int_9[0], "", 0);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00154C54 File Offset: 0x00152E54
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_9[1] = Class12.smethod_11(this.textBox3.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong3_1", FormLocdoTest.int_9[1], "", 0);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00154CAC File Offset: 0x00152EAC
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_10[0] = (int)Convert.ToByte(this.checkBox4.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong4_0", FormLocdoTest.int_10[0], "", 0);
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00154D04 File Offset: 0x00152F04
		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_10[1] = Class12.smethod_11(this.textBox4.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong4_1", FormLocdoTest.int_10[1], "", 0);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00154D5C File Offset: 0x00152F5C
		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_11[0] = (int)Convert.ToByte(this.checkBox5.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong5_0", FormLocdoTest.int_11[0], "", 0);
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00154DB4 File Offset: 0x00152FB4
		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_11[1] = Class12.smethod_11(this.textBox5.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong5_1", FormLocdoTest.int_11[1], "", 0);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00154E0C File Offset: 0x0015300C
		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_12[0] = (int)Convert.ToByte(this.checkBox6.Checked);
				Class62.smethod_10(Class53.string_3, "TrangbiDong6_0", FormLocdoTest.int_12[0], "", 0);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00154E64 File Offset: 0x00153064
		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_12[1] = Class12.smethod_11(this.textBox6.Text);
				Class62.smethod_10(Class53.string_3, "TrangbiDong6_1", FormLocdoTest.int_12[1], "", 0);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00154EBC File Offset: 0x001530BC
		private void checkBoxCoNopVP_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_6 = (int)Convert.ToByte(this.checkBoxCoNopVP.Checked);
				Class62.smethod_10(Class53.string_3, "fLocNopVP", FormLocdoTest.int_6, "", 0);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00154F10 File Offset: 0x00153110
		private void comboBoxNopVP_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || Form1.gstruct49_0 == null;
			if (!flag)
			{
				FormLocdoTest.string_3 = null;
				bool flag2 = FormLocdoTest.gstruct61_0 != null;
				if (flag2)
				{
					FormLocdoTest.string_3 = new string[FormLocdoTest.gstruct61_0.Length];
					for (int i = 0; i < FormLocdoTest.gstruct61_0.Length; i++)
					{
						FormLocdoTest.string_3[i] = FormLocdoTest.gstruct61_0[i].string_0;
					}
				}
				for (int j = 0; j < Form1.gstruct49_0.Length; j++)
				{
					Class79.smethod_35(Form1.gstruct49_0[j], ref FormLocdoTest.string_3, 3, null, false);
				}
				bool flag3 = FormLocdoTest.string_3 == null;
				if (!flag3)
				{
					string text = this.comboBoxNopVP.Text;
					string text2 = null;
					Array.Sort<string>(FormLocdoTest.string_3);
					FormLocdoTest.bool_3 = true;
					this.comboBoxNopVP.Items.Clear();
					for (int k = 0; k < FormLocdoTest.string_3.Length; k++)
					{
						string text3 = Class10.smethod_1(FormLocdoTest.string_3[k], 1, false);
						bool flag4 = text3 == text;
						if (flag4)
						{
							text2 = text;
						}
						this.comboBoxNopVP.Items.Add(text3);
					}
					bool flag5 = text2 == null;
					if (flag5)
					{
						text2 = this.comboBoxNopVP.Items[0].ToString();
					}
					this.comboBoxNopVP.Text = text2;
					FormLocdoTest.bool_3 = false;
				}
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0015509C File Offset: 0x0015329C
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || FormLocdoTest.bool_3 || Form1.gstruct49_0 == null || FormLocdoTest.string_3 == null;
			if (!flag)
			{
				int num = Class12.smethod_11(this.textBoxSoluongNop.Text);
				string text = this.comboBoxNopVP.Text;
				string text2 = null;
				for (int i = 0; i < FormLocdoTest.string_3.Length; i++)
				{
					bool flag2 = text != null && text != string.Empty && Class10.smethod_1(FormLocdoTest.string_3[i], 1, false) == text;
					if (flag2)
					{
						text2 = FormLocdoTest.string_3[i];
						break;
					}
				}
				bool flag3 = text2 == null;
				if (!flag3)
				{
					GStruct61 gstruct = new GStruct61
					{
						string_0 = text2,
						int_0 = num
					};
					bool flag4 = FormLocdoTest.gstruct61_0 == null;
					if (flag4)
					{
						FormLocdoTest.gstruct61_0 = new GStruct61[]
						{
							gstruct
						};
						this.listView2.Items.Clear();
						this.method_0(gstruct);
					}
					else
					{
						int num2 = 0;
						for (;;)
						{
							bool flag5 = num2 < FormLocdoTest.gstruct61_0.Length;
							if (!flag5)
							{
								goto IL_155;
							}
							bool flag6 = !(text2 == FormLocdoTest.gstruct61_0[num2].string_0);
							if (!flag6)
							{
								break;
							}
							num2++;
						}
						return;
						IL_155:
						this.method_0(gstruct);
						Array.Resize<GStruct61>(ref FormLocdoTest.gstruct61_0, FormLocdoTest.gstruct61_0.Length + 1);
						FormLocdoTest.gstruct61_0[FormLocdoTest.gstruct61_0.Length - 1] = gstruct;
					}
				}
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00155238 File Offset: 0x00153438
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			string text = null;
			for (int i = 0; i < this.listView2.Items.Count; i++)
			{
				bool selected = this.listView2.Items[i].Selected;
				if (selected)
				{
					text = this.listView2.Items[i].SubItems[1].Text;
					this.listView2.Items.RemoveAt(i);
					break;
				}
			}
			bool flag = text == null || text == string.Empty || FormLocdoTest.gstruct61_0 == null;
			if (!flag)
			{
				int num = 0;
				int num2 = 0;
				GStruct61[] array = new GStruct61[FormLocdoTest.gstruct61_0.Length];
				for (int j = 0; j < FormLocdoTest.gstruct61_0.Length; j++)
				{
					string a = Class10.smethod_1(FormLocdoTest.gstruct61_0[j].string_0, 1, false);
					bool flag2 = num2 != 0 || !(a == text);
					if (flag2)
					{
						array[num].string_0 = FormLocdoTest.gstruct61_0[j].string_0;
						array[num].int_0 = FormLocdoTest.gstruct61_0[j].int_0;
						num++;
					}
					else
					{
						num2 = 1;
					}
				}
				bool flag3 = num2 == 0;
				if (!flag3)
				{
					bool flag4 = num == 0;
					if (flag4)
					{
						FormLocdoTest.gstruct61_0 = null;
						this.listView2.Items.Clear();
					}
					else
					{
						FormLocdoTest.gstruct61_0 = new GStruct61[num];
						for (int k = 0; k < num; k++)
						{
							FormLocdoTest.gstruct61_0[k].string_0 = array[k].string_0;
							FormLocdoTest.gstruct61_0[k].int_0 = array[k].int_0;
						}
					}
				}
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00155424 File Offset: 0x00153624
		public static void smethod_2()
		{
			int int_ = FormLocdoTest.int_1;
			FormLocdoTest.int_1 = 0;
			for (;;)
			{
				try
				{
					FormLocdoTest.smethod_3(int_);
					break;
				}
				catch
				{
					Thread.Sleep(1000);
				}
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00155470 File Offset: 0x00153670
		public static void smethod_3(int int_18)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			byte[] array = new byte[4];
			int num2 = 0;
			int num3 = 0;
			uint[] array2 = null;
			bool flag = false;
			FormLocdoTest.gstruct61_0 = FormLocdoTest.smethod_0();
			for (;;)
			{
				num2--;
				Thread.Sleep(30);
				bool flag2 = num2 <= 0;
				if (flag2)
				{
					int num4 = Class81.smethod_3(Form1.gstruct49_0, int_18);
					bool flag3 = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25 || FormLocdoTest.string_0 == null || FormLocdoTest.string_0 == string.Empty;
					if (flag3)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num4];
					bool flag4 = !flag;
					if (flag4)
					{
						flag = true;
						Class70.smethod_52(gstruct, Class10.smethod_2("<color=yellow>Bắt đầu mở lọc trang bị vật phẩm Test..."), 1);
					}
					num2 = 10;
				}
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_10 * 4U, array, 1, ref num);
				bool flag5 = array[0] == 0;
				if (flag5)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_11 * 4U, array, 4, ref num);
				int num5 = BitConverter.ToInt32(array, 0);
				bool flag6 = num5 < 0;
				if (flag6)
				{
					num5 = 0;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num6 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num6 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				uint num8 = num7 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num9 = BitConverter.ToUInt32(array, 0);
				uint num10 = num9 + num8;
				Class22.ReadProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_55.uint_0, array, 4, ref num);
				int num11 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num12 = BitConverter.ToInt32(array, 0);
				int num13 = Class83.smethod_39(gstruct);
				bool flag7 = num12 != 0 && num11 != 0 && num13 > 1;
				if (flag7)
				{
					bool flag8 = FormLocdoTest.int_4 <= 0;
					if (flag8)
					{
						uint[] array3 = Class79.smethod_29(gstruct, FormLocdoTest.string_0, 3, false);
						bool flag9 = array3 == null;
						if (flag9)
						{
							num3++;
							bool flag10 = num3 > 300;
							if (flag10)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							num3 = 0;
							Class70.smethod_43(gstruct, array3[0], (int)array3[2], (int)array3[3], 3);
						}
					}
					else
					{
						uint[] array3 = new uint[]
						{
							(uint)Class98.smethod_14(gstruct, FormLocdoTest.string_0, ref array2, 3)
						};
						bool flag11 = gstruct.int_25 > 0;
						if (flag11)
						{
							int i = 0;
							byte[] array4 = Class12.smethod_46("§ang Train kh«ng thÓ läc ®å " + FormLocdoTest.string_0, true);
							while (i < 10)
							{
								Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array4, array4.Length, ref num);
								Thread.Sleep(300);
								i++;
							}
							continue;
						}
						bool flag12 = array3[0] == 0U || array2 == null;
						if (flag12)
						{
							int j = 0;
							byte[] array5 = Class12.smethod_46("Khong tim thay NPC " + FormLocdoTest.string_0, true);
							while (j < 10)
							{
								Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array5, array5.Length, ref num);
								Thread.Sleep(300);
								j++;
							}
							continue;
						}
						uint[] uint_ = new uint[]
						{
							Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag13 = Class60.smethod_18(uint_, array2) > 22500L;
						if (flag13)
						{
							Class70.smethod_61(gstruct, array2);
							continue;
						}
						Class86.smethod_8(gstruct, -1);
						Class36.smethod_10(gstruct, array3[0]);
					}
					bool flag14 = FormLocdoTest.int_13 != null;
					if (flag14)
					{
						int num14 = 0;
						int num15 = FormLocdoTest.int_13.Length;
						long num16 = 0L;
						int num17 = Class79.smethod_4(gstruct);
						for (;;)
						{
							bool flag15 = num16 == 0L;
							if (flag15)
							{
								num16 = (long)(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);
							}
							bool flag16 = num15 <= num14 || Class79.smethod_4(gstruct) > num17 || Math.Abs((long)(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - num16) > 1000L;
							if (flag16)
							{
								break;
							}
							bool flag17 = Class86.Class89.smethod_4(gstruct);
							if (flag17)
							{
								Class22.smethod_4(gstruct.uint_4, 32U);
							}
							int num18 = Class86.smethod_0(gstruct);
							int num19 = Class86.smethod_1(gstruct, num18);
							bool flag18 = num18 >= 0 && num19 != 0;
							if (flag18)
							{
								int num20 = FormLocdoTest.int_13[num14] - 1;
								bool flag19 = num20 >= 0 && num19 > num20;
								if (flag19)
								{
									string b = Class86.smethod_3(gstruct, num20, num18, 40);
									Class86.smethod_5(gstruct, num20);
									num16 = (long)(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond);
									while ((long)(DateTime.Now.Second * 1000 + DateTime.Now.Millisecond) - num16 < 1200L)
									{
										Thread.Sleep(1 + num5);
										int num21 = Class86.smethod_0(gstruct);
										int num22 = Class86.smethod_1(gstruct, num21);
										string a = Class86.smethod_3(gstruct, num20, num18, 40);
										bool flag20 = (num21 != num18 && num21 != 2) || num22 != num19 || num22 <= num20 || a != b;
										if (flag20)
										{
											break;
										}
									}
								}
								num14++;
								num16 = 0L;
							}
							else
							{
								Thread.Sleep(10);
							}
						}
						bool flag21 = FormLocdoTest.int_3 > 0;
						if (flag21)
						{
							int num23 = FormLocdoTest.int_2;
							bool flag22 = num23 <= 0;
							if (flag22)
							{
								num23 = 1;
							}
							int k = 0;
							while (k < 150)
							{
								bool flag23 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) == 0U;
								if (!flag23)
								{
									Class45.smethod_5(gstruct, num23.ToString(), true);
									Thread.Sleep(150);
									break;
								}
								k++;
								Thread.Sleep(10);
							}
						}
					}
					bool flag24 = FormLocdoTest.int_6 > 0 && FormLocdoTest.gstruct61_0 != null;
					if (flag24)
					{
						try
						{
							for (int l = 0; l < FormLocdoTest.gstruct61_0.Length; l++)
							{
								FormLocdoTest.smethod_4(gstruct, FormLocdoTest.gstruct61_0[l].string_0, FormLocdoTest.gstruct61_0[l].int_0);
							}
						}
						catch
						{
						}
						int num24 = Class79.smethod_4(gstruct);
						Thread.Sleep(300);
						Class45.smethod_13(gstruct, true);
						int m;
						for (m = 0; m < 10; m++)
						{
							bool flag25 = !Class45.smethod_8(gstruct);
							if (flag25)
							{
								break;
							}
							Thread.Sleep(100);
						}
						Thread.Sleep(100);
						m = 0;
						while (m < 6 && Class79.smethod_4(gstruct) == num24)
						{
							bool flag26 = !Class86.Class89.smethod_4(gstruct);
							if (flag26)
							{
								bool flag27 = 0 <= Class86.smethod_0(gstruct);
								if (flag27)
								{
									Class86.smethod_5(gstruct, 0);
								}
							}
							else
							{
								Class22.smethod_4(gstruct.uint_4, 32U);
							}
							m++;
							Thread.Sleep(100);
						}
					}
					FormLocdoTest.smethod_5(gstruct, FormLocdoTest.bool_0);
					int num25 = Class86.smethod_0(gstruct);
					bool flag28 = num25 > 1;
					if (flag28)
					{
						Class86.smethod_5(gstruct, Class86.smethod_1(gstruct, 1) - 1);
						Thread.Sleep(100);
						Class86.smethod_5(gstruct, Class86.smethod_1(gstruct, 0) - 1);
						Thread.Sleep(100);
					}
				}
				else
				{
					Thread.Sleep(300);
				}
			}
			goto IL_86F;
			Block_15:
			Class70.smethod_52(gstruct, Class10.smethod_2("<color=yellow>Không tìm thấy vật phẩm XXX trong hành trang. Kết thúc !").Replace("XXX", FormLocdoTest.string_0), 1);
			IL_86F:
			Class70.smethod_2(gstruct, Class70.uint_10, 0, 4);
			Class70.smethod_52(gstruct, "<color=yellow>Ket thuc mo loc trang bi test!", 1);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00155D18 File Offset: 0x00153F18
		private static void smethod_4(GStruct49 gstruct49_0, string string_4, int int_18)
		{
			bool flag = string_4 == null || string_4 == string.Empty;
			if (!flag)
			{
				int num = 0;
				for (;;)
				{
					bool flag2 = !Class45.smethod_8(gstruct49_0);
					if (!flag2)
					{
						break;
					}
					Thread.Sleep(10);
					num++;
					if (num > 150)
					{
						return;
					}
				}
				int num2 = 0;
				byte[] array = new byte[string_4.Length + 3];
				byte[] array2 = new byte[1];
				byte[] array3 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array3, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array3, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array3, 0);
				uint num5 = 12U;
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = 1U;
				while ((ulong)num8 < (ulong)((long)Class53.int_1) && num6 > num7)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
					uint num9 = BitConverter.ToUInt32(array3, 0);
					bool flag3 = num9 == 0U;
					if (!flag3)
					{
						uint num10 = num4 + num9 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
						bool flag4 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
							bool flag5 = array2[0] == 0;
							if (!flag5)
							{
								num7++;
								bool flag6 = (char)array2[0] != string_4[0];
								if (!flag6)
								{
									uint num11 = num3 + num8 * 20U;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
									uint num12 = (uint)array2[0];
									bool flag7 = num12 != 3U && num12 != 1U;
									if (!flag7)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, array.Length, ref num2);
										string a = Class10.smethod_3(array);
										bool flag8 = a != string_4;
										if (!flag8)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array3, 4, ref num2);
											int num13 = BitConverter.ToInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array3, 4, ref num2);
											int num14 = BitConverter.ToInt32(array3, 0);
											bool flag9 = num14 == 0;
											if (flag9)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0 + 4U, array3, 4, ref num2);
												int num15 = BitConverter.ToInt32(array3, 0);
												bool flag10 = num13 == 0 && num15 > 0;
												if (flag10)
												{
													goto IL_960;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_110.uint_0, array3, 4, ref num2);
												int num16 = BitConverter.ToInt32(array3, 0);
												bool flag11 = num16 <= 9;
												if (flag11)
												{
													int[] array4 = null;
													for (uint num17 = 0U; num17 < 6U; num17 += 1U)
													{
														switch (num17)
														{
														case 0U:
															array4 = FormLocdoTest.int_7;
															break;
														case 1U:
															array4 = FormLocdoTest.int_8;
															break;
														case 2U:
															array4 = FormLocdoTest.int_9;
															break;
														case 3U:
															array4 = FormLocdoTest.int_10;
															break;
														case 4U:
															array4 = FormLocdoTest.int_11;
															break;
														case 5U:
															array4 = FormLocdoTest.int_12;
															break;
														}
														bool flag12 = array4[0] <= 0;
														if (!flag12)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_118.uint_0 + num17 * 16U + 4U, array3, 4, ref num2);
															int num18 = BitConverter.ToInt32(array3, 0);
															bool flag13 = num18 >= array4[1];
															if (!flag13)
															{
																goto IL_636;
															}
														}
													}
													bool flag14 = !FormLocdoTest.bool_0;
													if (flag14)
													{
														goto IL_960;
													}
													int num19 = 0;
													int num20 = 0;
													for (int i = 0; i < gstruct49_0.gstruct37_0.Length; i++)
													{
														bool flag15 = gstruct49_0.gstruct37_0[i].int_0 <= 0;
														if (!flag15)
														{
															num20++;
															bool flag16 = false;
															for (uint num21 = 0U; num21 < 6U; num21 += 1U)
															{
																Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_118.uint_0 + num21 * 16U, array3, 4, ref num2);
																int num22 = BitConverter.ToInt32(array3, 0);
																bool flag17 = gstruct49_0.gstruct37_0[i].int_1 != num22;
																if (!flag17)
																{
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_118.uint_0 + num21 * 16U + 4U, array3, 4, ref num2);
																	int num23 = BitConverter.ToInt32(array3, 0);
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_118.uint_0 + num21 * 16U + 12U, array3, 4, ref num2);
																	int num24 = BitConverter.ToInt32(array3, 0);
																	bool flag18 = gstruct49_0.gstruct37_0[i].int_2 <= num23 && num23 > 0;
																	bool flag19 = gstruct49_0.gstruct37_0[i].int_2 <= num24 && num24 > 0;
																	bool flag20 = gstruct49_0.gstruct37_0[i].int_2 <= 0;
																	bool flag21 = gstruct49_0.gstruct37_0[i].int_3 == 0;
																	if (flag21)
																	{
																		goto IL_5A7;
																	}
																	bool flag22 = (long)gstruct49_0.gstruct37_0[i].int_3 == (long)((ulong)(num21 + 1U));
																	if (flag22)
																	{
																		goto IL_5A7;
																	}
																	int num25 = 1;
																	IL_58D:
																	bool flag23 = num25 == 0;
																	if (flag23)
																	{
																		num19++;
																		flag16 = true;
																		break;
																	}
																	goto IL_5BC;
																	IL_5A7:
																	num25 = ((!flag18 && !flag19 && !flag20) ? 1 : 0);
																	goto IL_58D;
																}
																IL_5BC:;
															}
															bool flag24 = flag16 || !FormLocdoTest.bool_0;
															if (!flag24)
															{
																goto IL_636;
															}
														}
													}
													bool flag25 = num20 == 0 || (FormLocdoTest.bool_0 && num20 <= num19) || (!FormLocdoTest.bool_0 && num19 > 0);
													if (flag25)
													{
														goto IL_960;
													}
												}
											}
											IL_636:
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_111.uint_0, array3, 4, ref num2);
											uint uint_ = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_112.uint_0, array3, 4, ref num2);
											uint uint_2 = BitConverter.ToUInt32(array3, 0);
											uint[] array5 = Class79.smethod_26(gstruct49_0, num5, uint_, uint_2);
											bool flag26 = array5 == null;
											if (flag26)
											{
												break;
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 4U, array3, 4, ref num2);
											uint num26 = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0, array3, 4, ref num2);
											uint num27 = BitConverter.ToUInt32(array3, 0);
											int j = 0;
											bool flag27 = num13 <= 0 || num14 <= 1 || int_18 <= 0 || num13 <= int_18;
											if (flag27)
											{
												while (Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) <= 0U)
												{
													bool flag28 = j % 80 == 0;
													if (flag28)
													{
														Class70.smethod_46(gstruct49_0, num26, num27, num12, num26, num27, num12);
													}
													Thread.Sleep(10);
													j++;
													bool flag29 = j > 200;
													if (flag29)
													{
														break;
													}
												}
												bool flag30 = num13 <= 0;
												if (flag30)
												{
													num13 = 1;
												}
											}
											else
											{
												while (!Class12.bool_0 && Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) == 0U)
												{
													bool flag31 = j % 80 == 0;
													if (flag31)
													{
														Class70.smethod_71(gstruct49_0, num9, (uint)int_18, 89);
													}
													Thread.Sleep(100);
													j++;
													bool flag32 = j > 200;
													if (flag32)
													{
														break;
													}
												}
												num13 = int_18;
											}
											bool flag33 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) > 0U;
											if (flag33)
											{
												for (j = 0; j < 200; j++)
												{
													bool flag34 = j % 80 == 0;
													if (flag34)
													{
														Class70.smethod_46(gstruct49_0, array5[0], array5[1], num5, array5[0], array5[1], num5);
													}
													bool flag35 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) > 0U;
													if (!flag35)
													{
														int_18 -= num13;
														break;
													}
													Thread.Sleep(100);
												}
											}
											bool flag36 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) > 0U;
											if (flag36)
											{
												j = 0;
												bool flag37 = num12 == 1U;
												if (flag37)
												{
													array5 = Class79.smethod_26(gstruct49_0, 3U, uint_, uint_2);
													bool flag38 = array5 != null;
													if (flag38)
													{
														num12 = 3U;
														num26 = array5[0];
														num27 = array5[1];
													}
												}
												while (j < 200)
												{
													bool flag39 = j % 80 == 0;
													if (flag39)
													{
														Class70.smethod_46(gstruct49_0, num26, num27, num12, num26, num27, num12);
													}
													bool flag40 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) == 0U;
													if (flag40)
													{
														break;
													}
													Thread.Sleep(100);
													j++;
												}
											}
											bool flag41 = int_18 <= 0;
											if (flag41)
											{
												break;
											}
											goto IL_960;
											goto IL_636;
										}
									}
								}
							}
						}
					}
					IL_960:
					num8 += 1U;
				}
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x001566C0 File Offset: 0x001548C0
		public static void smethod_5(GStruct49 gstruct49_0, bool bool_4)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0);
			uint num4 = num3 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array2, 0);
			uint num6 = num5 + num4;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num7 = BitConverter.ToUInt32(array2, 0);
			uint num8 = num2 + Class53.gstruct51_97.uint_0;
			int num9 = Class79.smethod_4(gstruct49_0);
			int num10 = 0;
			int num11 = 0;
			uint num12 = 1U;
			while ((ulong)num12 < (ulong)((long)Class53.int_1))
			{
				int num13 = Class79.smethod_4(gstruct49_0);
				bool flag = num9 != num13 || num11 > 0;
				if (flag)
				{
					num9 = num13;
					num10 = 0;
					num12 = 1U;
				}
				num11 = 0;
				bool flag2 = num9 <= num10;
				if (flag2)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 1, ref num);
				bool flag3 = array[0] > 0;
				if (flag3)
				{
					break;
				}
				uint num14 = num8 + num12 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
				uint num15 = BitConverter.ToUInt32(array2, 0);
				bool flag4 = num15 == 0U;
				if (!flag4)
				{
					uint num16 = num7 + num15 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
					bool flag5 = BitConverter.ToInt32(array2, 0) != 0;
					if (!flag5)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag6 = array[0] == 0;
						if (!flag6)
						{
							num10++;
							byte[] array3 = new byte[40];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
							Class10.smethod_3(array3);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							bool flag7 = array[0] != 3;
							if (!flag7)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_108.uint_0, array, 1, ref num);
								bool flag8 = array[0] > 0;
								if (!flag8)
								{
									bool flag9 = !FormLocdoTest.bool_1;
									if (flag9)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_109.uint_0, array, 1, ref num);
										bool flag10 = array[0] == 1 || array[0] == 4;
										if (flag10)
										{
											goto IL_837;
										}
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_120.uint_0, array2, 4, ref num);
									bool flag11 = BitConverter.ToInt32(array2, 0) != 0;
									if (!flag11)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
										int num17 = BitConverter.ToInt32(array2, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_119.uint_0 + 4U, array2, 4, ref num);
										int num18 = BitConverter.ToInt32(array2, 0);
										bool flag12 = num17 == 0 && num18 > 0;
										if (!flag12)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_110.uint_0, array2, 4, ref num);
											int num19 = BitConverter.ToInt32(array2, 0);
											bool flag13 = num19 > 9;
											if (!flag13)
											{
												bool flag14 = FormLocdoTest.int_5[0] <= 0 || num19 == FormLocdoTest.int_5[1] || (num19 == 0 && FormLocdoTest.int_5[1] == 1) || (num19 == 1 && FormLocdoTest.int_5[1] == 0);
												if (flag14)
												{
													int[] array4 = null;
													for (uint num20 = 0U; num20 < 6U; num20 += 1U)
													{
														switch (num20)
														{
														case 0U:
															array4 = FormLocdoTest.int_7;
															break;
														case 1U:
															array4 = FormLocdoTest.int_8;
															break;
														case 2U:
															array4 = FormLocdoTest.int_9;
															break;
														case 3U:
															array4 = FormLocdoTest.int_10;
															break;
														case 4U:
															array4 = FormLocdoTest.int_11;
															break;
														case 5U:
															array4 = FormLocdoTest.int_12;
															break;
														}
														bool flag15 = array4[0] <= 0;
														if (!flag15)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_118.uint_0 + num20 * 16U + 4U, array2, 4, ref num);
															int num21 = BitConverter.ToInt32(array2, 0);
															bool flag16 = num21 >= array4[1];
															if (!flag16)
															{
																goto IL_6E5;
															}
														}
													}
													bool flag17 = !bool_4;
													if (flag17)
													{
														goto IL_837;
													}
													int num22 = 0;
													int num23 = 0;
													for (int i = 0; i < gstruct49_0.gstruct37_0.Length; i++)
													{
														bool flag18 = gstruct49_0.gstruct37_0[i].int_0 <= 0;
														if (!flag18)
														{
															num23++;
															bool flag19 = false;
															for (uint num24 = 0U; num24 < 6U; num24 += 1U)
															{
																Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_118.uint_0 + num24 * 16U, array2, 4, ref num);
																int num25 = BitConverter.ToInt32(array2, 0);
																bool flag20 = gstruct49_0.gstruct37_0[i].int_1 == num25;
																if (flag20)
																{
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_118.uint_0 + num24 * 16U + 4U, array2, 4, ref num);
																	int num26 = BitConverter.ToInt32(array2, 0);
																	Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_118.uint_0 + num24 * 16U + 12U, array2, 4, ref num);
																	int num27 = BitConverter.ToInt32(array2, 0);
																	bool flag21 = gstruct49_0.gstruct37_0[i].int_2 <= num26 && num26 > 0;
																	bool flag22 = gstruct49_0.gstruct37_0[i].int_2 <= num27 && num27 > 0;
																	bool flag23 = gstruct49_0.gstruct37_0[i].int_2 <= 0;
																	bool flag24 = (gstruct49_0.gstruct37_0[i].int_3 == 0 || (long)gstruct49_0.gstruct37_0[i].int_3 == (long)((ulong)(num24 + 1U))) && (flag21 || flag22 || flag23);
																	if (flag24)
																	{
																		num22++;
																		flag19 = true;
																		break;
																	}
																}
															}
															bool flag25 = flag19 || !FormLocdoTest.bool_0;
															if (!flag25)
															{
																goto IL_6E5;
															}
														}
													}
													bool flag26 = num23 == 0 || (FormLocdoTest.bool_0 && num23 <= num22) || (!FormLocdoTest.bool_0 && num22 > 0);
													if (flag26)
													{
														goto IL_837;
													}
												}
												IL_6E5:
												int num28 = 0;
												uint uint_ = num16 + Class53.gstruct51_107.uint_0;
												while (!Class12.bool_0)
												{
													bool flag27 = num28 % 10 == 0 && num15 > 0U;
													if (flag27)
													{
														Class70.smethod_35(gstruct49_0, num15);
													}
													Thread.Sleep(30);
													bool flag28 = num28 % 15 == 0;
													if (flag28)
													{
														string string_ = Class83.smethod_22(gstruct49_0);
														bool flag29 = Class12.smethod_1(string_, "hÊt b¹i") > 0;
														if (flag29)
														{
															Class83.smethod_23(gstruct49_0, "0K..");
															break;
														}
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
													num15 = BitConverter.ToUInt32(array2, 0);
													Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
													int num29 = BitConverter.ToInt32(array2, 0);
													Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 1, ref num);
													byte b = array[0];
													Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num);
													byte b2 = array[0];
													bool flag30 = num15 != 0U && num29 == 0 && b2 != 0 && b <= 0;
													if (!flag30)
													{
														break;
													}
													bool flag31 = num28 > 100;
													if (flag31)
													{
														break;
													}
													num28++;
												}
												goto IL_837;
												goto IL_6E5;
											}
										}
									}
								}
							}
						}
					}
				}
				IL_837:
				num12 += 1U;
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00156F20 File Offset: 0x00155120
		private void linkLabelLuuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = "Nếu trùng luyện các vật phẩm Hoàng Kim thì không được check vào mục []Bán luôn trang bị Hoàng Kim.||Đối với các vật phẩm đem nộp là trang bị (như Vũ khí, áo, mão ... ) nếu thỏa điều kiện của thuộc tính bên dưới thì nó sẽ giữ lại không nộp. Do vậy, sẽ có thể xảy ra trường hợp có vật phẩm nhưng auto không nộp.||Ví dụ trùng luyện vật phẩm Vũ khí Kim Ô, cần: 1 Vũ khí Kim Ô, 4 Kim Ô trùng luyện ngọc.||Nhưng có thể xảy ra trường hợp auto chỉ nộp 4 Kim Ô trùng luyện ngọc, mà không nộp vũ khí Kim Ô.||Nguyên nhân: Có thể bạn check vào dòng giữ lại [v] Tốc độ đánh = 40, mà vũ khí Kim Ô thì có tốc độ đánh 126, đã thỏa điều kiện nên nó không nộp.||Giải quyết: Check luôn dòng [v] Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ.||Lúc này nếu auto giữ lại không nộp vũ khí, thì vũ khí đó đã đạt yêu cầu, bạn có thể tắt auto và đem vũ khí cất đi cho an toàn.";
			FormTip.smethod_0("LOC TRANG BỊ", string_, 60000000, 420, 340, false, -1, -1, false, false, false);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00156F58 File Offset: 0x00155158
		private void buttonBoCheck_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.Items.Count > 0;
			if (flag)
			{
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					this.listView1.Items[i].Checked = false;
				}
			}
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdoTest.int_0);
			bool flag2 = num >= 0 && Form1.gstruct49_0[num].gstruct37_0 != null;
			if (flag2)
			{
				for (int j = 0; j < Form1.gstruct49_0[num].gstruct37_0.Length; j++)
				{
					Form1.gstruct49_0[num].gstruct37_0[j].int_0 = 0;
				}
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00157030 File Offset: 0x00155230
		private void checkBoxLocTrangbi_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdoTest.int_5[0] = (int)Convert.ToByte(this.checkBoxLocTrangbi.Checked);
				Class62.smethod_10(Class53.string_3, "flagChiLocLayTrangbi_0", FormLocdoTest.int_5[0], "", 0);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00157088 File Offset: 0x00155288
		private void comboBoxLocTrangbi_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBoxLocTrangbi.Text;
				for (int i = 0; i < FormLocdoTest.string_2.Length; i++)
				{
					bool flag2 = text == FormLocdoTest.string_2[i];
					if (flag2)
					{
						FormLocdoTest.int_5[1] = i;
						Class62.smethod_10(Class53.string_3, "flagChiLocLayTrangbi_1", i, "", 0);
					}
				}
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_2(string string_4)
		{
			base.Text = string_4;
		}

		// Token: 0x04000976 RID: 2422
		private IContainer icontainer_0 = null;

		// Token: 0x0400099F RID: 2463
		public static int int_0 = 0;

		// Token: 0x040009A0 RID: 2464
		public static int int_1 = 0;

		// Token: 0x040009A1 RID: 2465
		public static string string_0 = Class12.smethod_15(Class62.smethod_6("TenVatPhamNhanTrangbiTest", 0, ""));

		// Token: 0x040009A2 RID: 2466
		public static int int_2 = Class62.smethod_3("NhapSoluongTest", 0, "10");

		// Token: 0x040009A3 RID: 2467
		public static int int_3 = Class62.smethod_3("fCoNhapSLTest", 0, "0");

		// Token: 0x040009A4 RID: 2468
		public static int int_4 = Class62.smethod_3("DayLaNPC", 0, "0");

		// Token: 0x040009A5 RID: 2469
		public static bool bool_0 = Class62.smethod_3("flagLocThoahetDieukien", 0, "0") > 0;

		// Token: 0x040009A6 RID: 2470
		public static bool bool_1 = Class62.smethod_3("flagBanTrangbiHoangKimTest", 0, "0") > 0;

		// Token: 0x040009A7 RID: 2471
		public static int[] int_5 = new int[]
		{
			Class62.smethod_3("flagChiLocLayTrangbi_0", 0, "0"),
			Class62.smethod_3("flagChiLocLayTrangbi_1", 0, "0")
		};

		// Token: 0x040009A8 RID: 2472
		public static GStruct61[] gstruct61_0 = null;

		// Token: 0x040009A9 RID: 2473
		public static int int_6 = Class62.smethod_3("fLocNopVP", 0, "0");

		// Token: 0x040009AA RID: 2474
		public static int[] int_7 = new int[]
		{
			Class62.smethod_3("TrangbiDong1_0", 0, "0"),
			Class62.smethod_3("TrangbiDong1_1", 0, "0")
		};

		// Token: 0x040009AB RID: 2475
		public static int[] int_8 = new int[]
		{
			Class62.smethod_3("TrangbiDong2_0", 0, "0"),
			Class62.smethod_3("TrangbiDong2_1", 0, "0")
		};

		// Token: 0x040009AC RID: 2476
		public static int[] int_9 = new int[]
		{
			Class62.smethod_3("TrangbiDong3_0", 0, "0"),
			Class62.smethod_3("TrangbiDong3_1", 0, "0")
		};

		// Token: 0x040009AD RID: 2477
		public static int[] int_10 = new int[]
		{
			Class62.smethod_3("TrangbiDong4_0", 0, "0"),
			Class62.smethod_3("TrangbiDong4_1", 0, "0")
		};

		// Token: 0x040009AE RID: 2478
		public static int[] int_11 = new int[]
		{
			Class62.smethod_3("TrangbiDong5_0", 0, "0"),
			Class62.smethod_3("TrangbiDong5_1", 0, "0")
		};

		// Token: 0x040009AF RID: 2479
		public static int[] int_12 = new int[]
		{
			Class62.smethod_3("TrangbiDong6_0", 0, "0"),
			Class62.smethod_3("TrangbiDong6_1", 0, "0")
		};

		// Token: 0x040009B0 RID: 2480
		public static string string_1 = "ClickMenuTest";

		// Token: 0x040009B1 RID: 2481
		public static int[] int_13 = Class12.smethod_69(Class62.smethod_6(FormLocdoTest.string_1, 0, "9,1"), null);

		// Token: 0x040009B2 RID: 2482
		public int int_14;

		// Token: 0x040009B3 RID: 2483
		public int int_15;

		// Token: 0x040009B4 RID: 2484
		public int int_16;

		// Token: 0x040009B5 RID: 2485
		public int int_17;

		// Token: 0x040009B6 RID: 2486
		public static bool bool_2 = false;

		// Token: 0x040009B7 RID: 2487
		private Color color_0 = Color.DarkGreen;

		// Token: 0x040009B8 RID: 2488
		private static long long_0 = 0L;

		// Token: 0x040009B9 RID: 2489
		private static string[] string_2 = new string[]
		{
			"Vũ khí cận chiến",
			"Vũ khí tầm xa",
			"Lấy áo",
			"Lấy nhẫn",
			"Lấy dây chuyền",
			"Lấy giầy",
			"Lấy đai lưng",
			"Lấy nón",
			"Lấy bao tay",
			"Lấy ngọc bội"
		};

		// Token: 0x040009BA RID: 2490
		private static bool bool_3 = false;

		// Token: 0x040009BC RID: 2492
		private static string[] string_3 = null;
	}
}
