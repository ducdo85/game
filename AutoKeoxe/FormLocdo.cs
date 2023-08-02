using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000073 RID: 115
	public partial class FormLocdo : Form
	{
		// Token: 0x060008FD RID: 2301 RVA: 0x0014DCA0 File Offset: 0x0014BEA0
		public FormLocdo()
		{
			FormLocdo.bool_0 = true;
			try
			{
				this.InitializeComponent();
				base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			}
			catch
			{
			}
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x0014DD50 File Offset: 0x0014BF50
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = false;
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag2 = 0 <= num;
			if (flag2)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
				flag = true;
			}
			bool flag3 = Form1.gstruct49_0 != null;
			if (flag3)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag4 = !flag;
					if (flag4)
					{
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
			}
			Class62.smethod_10(Class53.string_3, "FormLocdo", this.tabControl1.SelectedIndex, "", 0);
			this.int_0 = 0;
			this.int_1 = 0;
			FormLocdo.int_4 = 0;
			FormLocdo.bool_0 = false;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x0014DE1C File Offset: 0x0014C01C
		private void FormLocdo_Load(object sender, EventArgs e)
		{
			try
			{
				this.method_0();
			}
			catch
			{
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0014DE4C File Offset: 0x0014C04C
		private void method_0()
		{
			this.timer_0.Enabled = false;
			bool flag = this.int_0 >= 0 && this.int_1 >= 0;
			if (flag)
			{
				int num = this.int_0 - base.Width;
				int num2 = this.int_1 + this.int_3 - base.Height;
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
			this.tabControl1.SelectedIndex = Class62.smethod_3("FormLocdo", 0, "0");
			base.TopMost = true;
			for (int i = 0; i < this.string_0.Length; i++)
			{
				this.comboBoxHe.Items.Add(this.string_0[i]);
			}
			for (int j = 0; j <= 10; j++)
			{
				this.comboBoxCap.Items.Add(j.ToString());
			}
			for (int k = 0; k < this.string_1.Length; k++)
			{
				this.comboBoxBando.Items.Add(this.string_1[k]);
			}
			this.textBoxTocdoNhat.Text = FormLocdo.int_5.ToString();
			int num3 = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag4 = 0 <= num3;
			if (flag4)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num3];
				this.checkBoxBando.Checked = (gstruct.int_46[0] > 0);
				this.comboBoxBando.Text = this.string_1[gstruct.int_46[1]];
				this.checkBoxGiudoTheoCap.Checked = (gstruct.int_47[0] > 0);
				this.checkBoxGiudoTheoHe.Checked = (gstruct.int_48[0] > 0);
				this.checkBoxGiudoTim.Checked = (gstruct.int_49 > 0);
				this.checkBoxNhatTrongthanh.Checked = (gstruct.int_39 > 0);
				this.checkBoxNhatTheoThuoctinh.Checked = (gstruct.int_40 > 0);
				this.checkBoxGiudoTheoThuoctinh.Checked = (gstruct.int_50 > 0);
				this.checkBoxThoahet.Checked = (gstruct.int_41 > 0);
				this.checkBoxThoahet.Enabled = (gstruct.int_50 > 0);
				this.checkBoxKhongNhatdoTim.Checked = (gstruct.int_42 > 0);
				this.checkBoxGiuTrangsuc.Checked = (gstruct.int_43[0] > 0);
				this.textBoxDongNhan.Text = gstruct.int_43[1].ToString();
				this.checkBoxNgocBoi.Checked = (gstruct.int_45[0] > 0);
				this.textBoxDongNB.Text = gstruct.int_45[1].ToString();
				this.checkBoxDaychuyen.Checked = (gstruct.int_44[0] > 0);
				this.textBoxDongDC.Text = gstruct.int_44[1].ToString();
				this.comboBoxHe.Text = this.string_0[gstruct.int_48[1]];
				this.comboBoxCap.Text = gstruct.int_47[1].ToString();
				bool flag5 = gstruct.gstruct37_0 != null;
				if (flag5)
				{
					for (int l = 0; l < gstruct.gstruct37_0.Length; l++)
					{
						this.method_1(gstruct.gstruct37_0[l]);
					}
					for (int m = 0; m < gstruct.gstruct37_0.Length; m++)
					{
						bool flag6 = m < this.listView1.Items.Count && gstruct.gstruct37_0[m].int_0 > 0;
						if (flag6)
						{
							this.listView1.Items[m].Checked = true;
							this.listView1.Items[m].ForeColor = this.color_0;
						}
					}
				}
				bool flag7 = gstruct.string_4 != null;
				if (flag7)
				{
					for (int n = 0; n < gstruct.string_4.Length; n++)
					{
						this.method_2(Class10.smethod_1(gstruct.string_4[n], 1, false));
					}
				}
			}
			else
			{
				GStruct37 gstruct37_ = new GStruct37
				{
					string_0 = "Chưa chọn ac, bấm Lọc sau khi chọn 1 ac nhé."
				};
				this.method_1(gstruct37_);
				this.tabControl1.Enabled = false;
				this.buttonApdungAll.Enabled = false;
				this.method_3("Loc do * Chua chon ac nao");
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0014E34C File Offset: 0x0014C54C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormLocdo.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormLocdo.long_0 > 0L;
				if (flag2)
				{
					bool flag3 = Class12.smethod_28(FormLocdo.long_0) <= 300L;
					if (!flag3)
					{
						this.buttonApdungAll.Enabled = true;
						this.buttonAppdungAll2.Enabled = true;
						FormLocdo.long_0 = 0L;
					}
				}
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0014E3C4 File Offset: 0x0014C5C4
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
					gstruct37_0.int_2.ToString()
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

		// Token: 0x06000903 RID: 2307 RVA: 0x0014E498 File Offset: 0x0014C698
		private void method_2(string string_3)
		{
			int num = 0;
			try
			{
				bool flag = this.listView2.Items != null;
				if (flag)
				{
					num = this.listView2.Items.Count;
				}
				string[] array = new string[]
				{
					num.ToString(),
					string_3
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
				this.listView2.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0014E558 File Offset: 0x0014C758
		private void checkBoxBando_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_46[0] = (int)Convert.ToByte(this.checkBoxBando.Checked);
				}
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0014E5B4 File Offset: 0x0014C7B4
		private void comboBoxBando_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxBando.Text;
					for (int i = 0; i < this.string_1.Length; i++)
					{
						bool flag3 = text == this.string_1[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_46[1] = i;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0014E648 File Offset: 0x0014C848
		private void checkBoxGiudoTheoCap_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_47[0] = (int)Convert.ToByte(this.checkBoxGiudoTheoCap.Checked);
				}
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0014E6A4 File Offset: 0x0014C8A4
		private void checkBoxGiudoTheoHe_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_48[0] = (int)Convert.ToByte(this.checkBoxGiudoTheoHe.Checked);
				}
			}
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0014E700 File Offset: 0x0014C900
		private void checkBoxGiudoTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_50 = (int)Convert.ToByte(this.checkBoxGiudoTheoThuoctinh.Checked);
					this.checkBoxThoahet.Enabled = this.checkBoxGiudoTheoThuoctinh.Checked;
				}
			}
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0014E774 File Offset: 0x0014C974
		private void comboBoxCap_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_47[1] = Class12.smethod_11(this.comboBoxCap.Text);
				}
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0014E7D0 File Offset: 0x0014C9D0
		private void comboBoxHe_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxHe.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < this.string_0.Length;
						if (!flag3)
						{
							goto IL_70;
						}
						bool flag4 = this.string_0[num2] == text;
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].int_48[1] = num2;
					IL_70:;
				}
			}
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0014E868 File Offset: 0x0014CA68
		private void checkBoxNhatTrongthanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_39 = (int)Convert.ToByte(this.checkBoxNhatTrongthanh.Checked);
				}
			}
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0014E8C4 File Offset: 0x0014CAC4
		private void checkBoxNhatTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_40 = (int)Convert.ToByte(this.checkBoxNhatTheoThuoctinh.Checked);
				}
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0014E920 File Offset: 0x0014CB20
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.Items == null;
			if (!flag)
			{
				bool flag2 = this.listView1.Items.Count == 0;
				if (!flag2)
				{
					for (int i = 0; i < this.listView1.Items.Count; i++)
					{
						bool selected = this.listView1.Items[i].Selected;
						if (selected)
						{
							this.textBoxName.Text = i.ToString() + ". " + this.listView1.Items[i].SubItems[1].Text;
							this.textBoxMin.Text = this.listView1.Items[i].SubItems[2].Text;
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0014EA18 File Offset: 0x0014CC18
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
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

		// Token: 0x06000910 RID: 2320 RVA: 0x0014EAE0 File Offset: 0x0014CCE0
		private void buttonSua_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				int num2 = 0;
				for (;;)
				{
					bool flag2 = num2 < this.listView1.Items.Count;
					if (!flag2)
					{
						goto IL_5F;
					}
					bool selected = this.listView1.Items[num2].Selected;
					if (selected)
					{
						break;
					}
					num2++;
				}
				Form1.gstruct49_0[num].gstruct37_0[num2].int_2 = Class12.smethod_11(this.textBoxMin.Text);
				this.listView1.Items[num2].SubItems[2].Text = this.textBoxMin.Text;
				IL_5F:;
			}
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x0014EBAC File Offset: 0x0014CDAC
		private void checkBoxGiudoTim_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_49 = (int)Convert.ToByte(this.checkBoxGiudoTim.Checked);
				}
			}
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0014EC08 File Offset: 0x0014CE08
		private void checkBoxKhongNhatdoTim_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_42 = (int)Convert.ToByte(this.checkBoxKhongNhatdoTim.Checked);
				}
			}
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0014EC64 File Offset: 0x0014CE64
		private void checkBoxThoahet_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_41 = (int)Convert.ToByte(this.checkBoxThoahet.Checked);
				}
			}
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0014ECC0 File Offset: 0x0014CEC0
		private void checkBoxGiuTrangsuc_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_43[0] = (int)Convert.ToByte(this.checkBoxGiuTrangsuc.Checked);
				}
			}
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0014ED1C File Offset: 0x0014CF1C
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				string text = null;
				try
				{
					for (int i = 0; i < this.listView2.Items.Count; i++)
					{
						bool flag2 = !this.listView2.Items[i].Selected;
						if (!flag2)
						{
							text = this.listView2.Items[i].SubItems[1].Text;
							this.listView2.Items.RemoveAt(i);
							bool flag3 = this.listView2.Items.Count > 0;
							if (flag3)
							{
								bool flag4 = this.listView2.Items.Count <= i;
								if (flag4)
								{
									i--;
								}
								this.listView2.Items[i].Selected = true;
								this.listView2.Items[i].Focused = true;
							}
						}
					}
				}
				catch
				{
				}
				bool flag5 = text == null || Form1.gstruct49_0[num].string_4 == null;
				if (!flag5)
				{
					int i = 0;
					for (;;)
					{
						bool flag6 = i < Form1.gstruct49_0[num].string_4.Length;
						if (!flag6)
						{
							goto IL_187;
						}
						bool flag7 = Class10.smethod_1(Form1.gstruct49_0[num].string_4[i], 1, false) == text;
						if (flag7)
						{
							break;
						}
						i++;
					}
					Class12.smethod_30(ref Form1.gstruct49_0[num].string_4, Form1.gstruct49_0[num].string_4[i], false);
					Form1.gstruct49_0[num].bool_10 = true;
					IL_187:;
				}
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0014EF04 File Offset: 0x0014D104
		private void buttonThem_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = FormLocdo.string_2 == null || num < 0;
			if (!flag)
			{
				string text = null;
				string text2 = this.comboBoxTenVatpham.Text;
				for (int i = 0; i < FormLocdo.string_2.Length; i++)
				{
					bool flag2 = text2 == Class10.smethod_1(FormLocdo.string_2[i], 1, false);
					if (flag2)
					{
						text = FormLocdo.string_2[i].Trim();
						break;
					}
				}
				bool flag3 = text == null;
				if (flag3)
				{
					text = Class10.smethod_2(text2);
				}
				bool flag4 = Form1.gstruct49_0[num].string_4 != null;
				if (flag4)
				{
					for (int j = 0; j < Form1.gstruct49_0[num].string_4.Length; j++)
					{
						bool flag5 = Form1.gstruct49_0[num].string_4[j] == text;
						if (flag5)
						{
							return;
						}
					}
				}
				this.method_2(Class10.smethod_1(text, 1, false));
				Class12.smethod_29(ref Form1.gstruct49_0[num].string_4, text);
				Form1.gstruct49_0[num].bool_10 = true;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0014F040 File Offset: 0x0014D240
		private void listView2_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.Items == null || this.listView1.Items.Count == 0;
			if (!flag)
			{
				string text = null;
				try
				{
					for (int i = 0; i < this.listView2.Items.Count; i++)
					{
						bool selected = this.listView2.Items[i].Selected;
						if (selected)
						{
							text = this.listView2.Items[i].SubItems[1].Text;
							break;
						}
					}
				}
				catch
				{
				}
				bool flag2 = text != null && text != this.comboBoxTenVatpham.Text;
				if (flag2)
				{
					this.comboBoxTenVatpham.Items.Clear();
					this.comboBoxTenVatpham.Items.Add(text);
					this.comboBoxTenVatpham.Text = text;
				}
			}
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0014F148 File Offset: 0x0014D348
		private void comboBoxTenVatpham_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				FormLocdo.string_2 = Class79.smethod_34(Form1.gstruct49_0[num], null, 3);
				this.comboBoxTenVatpham.Items.Clear();
				bool flag2 = FormLocdo.string_2 != null;
				if (flag2)
				{
					for (int i = 0; i < FormLocdo.string_2.Length; i++)
					{
						this.comboBoxTenVatpham.Items.Add(Class10.smethod_1(FormLocdo.string_2[i], 1, false));
					}
				}
			}
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0014F1E0 File Offset: 0x0014D3E0
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				this.buttonApdungAll.Enabled = false;
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag2 = num >= 0;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = num != i;
						if (flag3)
						{
							Form1.gstruct49_0[i].int_47 = new int[]
							{
								Form1.gstruct49_0[num].int_47[0],
								Form1.gstruct49_0[num].int_47[1]
							};
							Form1.gstruct49_0[i].int_48 = new int[]
							{
								Form1.gstruct49_0[num].int_48[0],
								Form1.gstruct49_0[num].int_48[1]
							};
							Form1.gstruct49_0[i].int_49 = Form1.gstruct49_0[num].int_49;
							Form1.gstruct49_0[i].int_50 = Form1.gstruct49_0[num].int_50;
							bool flag4 = Form1.gstruct49_0[i].gstruct37_0 == null;
							if (flag4)
							{
								Form1.gstruct49_0[i].gstruct37_0 = Class53.smethod_1();
							}
							for (int j = 0; j < Form1.gstruct49_0[i].gstruct37_0.Length; j++)
							{
								Form1.gstruct49_0[i].gstruct37_0[j].int_0 = Form1.gstruct49_0[num].gstruct37_0[j].int_0;
								Form1.gstruct49_0[i].gstruct37_0[j].int_2 = Form1.gstruct49_0[num].gstruct37_0[j].int_2;
							}
							Form1.gstruct49_0[i].int_39 = Form1.gstruct49_0[num].int_39;
							Form1.gstruct49_0[i].int_40 = Form1.gstruct49_0[num].int_40;
							Form1.gstruct49_0[i].int_46 = new int[]
							{
								Form1.gstruct49_0[num].int_46[0],
								Form1.gstruct49_0[num].int_46[1]
							};
							Form1.gstruct49_0[i].int_61 = Form1.gstruct49_0[num].int_61;
							Form1.gstruct49_0[i].int_62 = Form1.gstruct49_0[num].int_62;
							Form1.gstruct49_0[i].int_42 = Form1.gstruct49_0[num].int_42;
							for (int k = 0; k < 2; k++)
							{
								Form1.gstruct49_0[i].int_43[k] = Form1.gstruct49_0[num].int_43[k];
								Form1.gstruct49_0[i].int_44[k] = Form1.gstruct49_0[num].int_44[k];
								Form1.gstruct49_0[i].int_45[k] = Form1.gstruct49_0[num].int_45[k];
							}
						}
					}
				}
				else
				{
					int int_ = (int)Convert.ToByte(this.checkBoxKhongNhatdoTim.Checked);
					int int_2 = (int)Convert.ToByte(this.checkBoxNhatTrongthanh.Checked);
					int int_3 = (int)Convert.ToByte(this.checkBoxNhatTheoThuoctinh.Checked);
					int[] array = new int[]
					{
						(int)Convert.ToByte(this.checkBoxGiuTrangsuc.Checked),
						Class12.smethod_11(this.textBoxDongNhan.Text)
					};
					int[] array2 = new int[]
					{
						(int)Convert.ToByte(this.checkBoxDaychuyen.Checked),
						Class12.smethod_11(this.textBoxDongDC.Text)
					};
					int[] array3 = new int[]
					{
						(int)Convert.ToByte(this.checkBoxNgocBoi.Checked),
						Class12.smethod_11(this.textBoxDongNB.Text)
					};
					int num2 = (int)Convert.ToByte(this.checkBoxBando.Checked);
					int num3 = 0;
					for (int l = 0; l < this.string_1.Length; l++)
					{
						bool flag5 = this.string_1[l] == this.comboBoxBando.Text;
						if (flag5)
						{
							num3 = l;
							break;
						}
					}
					int num4 = (int)Convert.ToByte(this.checkBoxGiudoTheoHe.Checked);
					int num5 = 0;
					for (int m = 0; m < this.string_0.Length; m++)
					{
						bool flag6 = this.string_0[m] == this.comboBoxHe.Text;
						if (flag6)
						{
							num5 = m;
							break;
						}
					}
					int num6 = (int)Convert.ToByte(this.checkBoxGiudoTheoCap.Checked);
					int num7 = Class12.smethod_11(this.comboBoxCap.Text);
					int int_4 = (int)Convert.ToByte(this.checkBoxGiudoTim.Checked);
					int int_5 = (int)Convert.ToByte(this.checkBoxGiudoTheoThuoctinh.Checked);
					for (int n = 0; n < Form1.gstruct49_0.Length; n++)
					{
						Form1.gstruct49_0[n].int_47 = new int[]
						{
							num6,
							num7
						};
						Form1.gstruct49_0[n].int_48 = new int[]
						{
							num4,
							num5
						};
						Form1.gstruct49_0[n].int_49 = int_4;
						Form1.gstruct49_0[n].int_50 = int_5;
						bool flag7 = Form1.gstruct49_0[n].gstruct37_0 == null;
						if (flag7)
						{
							Form1.gstruct49_0[n].gstruct37_0 = Class53.smethod_1();
						}
						try
						{
							for (int num8 = 0; num8 < Form1.gstruct49_0[n].gstruct37_0.Length; num8++)
							{
								Form1.gstruct49_0[n].gstruct37_0[num8].int_0 = (int)Convert.ToByte(this.listView1.Items[n].Checked);
								Form1.gstruct49_0[n].gstruct37_0[num8].int_2 = Class12.smethod_11(this.listView1.Items[n].SubItems[2].Text);
							}
						}
						catch
						{
						}
						Form1.gstruct49_0[n].int_46 = new int[]
						{
							num2,
							num3
						};
						Form1.gstruct49_0[n].int_39 = int_2;
						Form1.gstruct49_0[n].int_40 = int_3;
						Form1.gstruct49_0[n].int_42 = int_;
						for (int num9 = 0; num9 < 2; num9++)
						{
							Form1.gstruct49_0[n].int_43[num9] = array[num9];
							Form1.gstruct49_0[n].int_44[num9] = array2[num9];
							Form1.gstruct49_0[n].int_45[num9] = array3[num9];
						}
					}
				}
				this.textBoxName.Text = "Đã áp dụng cho tất cả ac đang online.";
				FormLocdo.long_0 = Class12.smethod_27();
			}
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0014F974 File Offset: 0x0014DB74
		private void buttonAppdungAll2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				this.buttonAppdungAll2.Enabled = false;
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = num == i;
						if (!flag3)
						{
							Form1.gstruct49_0[i].string_4 = null;
							bool flag4 = Form1.gstruct49_0[num].string_4 != null;
							if (flag4)
							{
								Form1.gstruct49_0[i].string_4 = new string[Form1.gstruct49_0[num].string_4.Length];
								for (int j = 0; j < Form1.gstruct49_0[num].string_4.Length; j++)
								{
									Form1.gstruct49_0[i].string_4[j] = Form1.gstruct49_0[num].string_4[j];
								}
							}
							Form1.gstruct49_0[i].bool_10 = true;
						}
					}
				}
				FormLocdo.long_0 = Class12.smethod_27();
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0014FAAC File Offset: 0x0014DCAC
		private void checkBoxNgocBoi_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_45[0] = (int)Convert.ToByte(this.checkBoxNgocBoi.Checked);
				}
			}
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0014FB08 File Offset: 0x0014DD08
		private void checkBoxDaychuyen_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_44[0] = (int)Convert.ToByte(this.checkBoxDaychuyen.Checked);
				}
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0014FB64 File Offset: 0x0014DD64
		private void textBoxTocdoNhat_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLocdo.int_5 = Class12.smethod_11(this.textBoxTocdoNhat.Text);
				bool flag = FormLocdo.int_5 < 0;
				if (flag)
				{
					FormLocdo.int_5 = 0;
				}
				Class62.smethod_10(Class53.string_3, "TocdoNhatdoExx", FormLocdo.int_5, "", 0);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0014FBCC File Offset: 0x0014DDCC
		private void textBoxDongNhan_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_43[1] = Class12.smethod_11(this.textBoxDongNhan.Text);
				}
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0014FC28 File Offset: 0x0014DE28
		private void textBoxDongNB_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_45[1] = Class12.smethod_11(this.textBoxDongNB.Text);
				}
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0014FC84 File Offset: 0x0014DE84
		private void textBoxDongDC_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_44[1] = Class12.smethod_11(this.textBoxDongDC.Text);
				}
			}
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0014FCE0 File Offset: 0x0014DEE0
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
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag2 = num >= 0 && Form1.gstruct49_0[num].gstruct37_0 != null;
			if (flag2)
			{
				for (int j = 0; j < Form1.gstruct49_0[num].gstruct37_0.Length; j++)
				{
					Form1.gstruct49_0[num].gstruct37_0[j].int_0 = 0;
				}
			}
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0014FDB8 File Offset: 0x0014DFB8
		private void buttonO_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				string text = Class53.string_8 + "\\Badlist";
				Class12.smethod_23(text);
				string text2 = Class53.smethod_26(text, "", "*.txt", "");
				bool flag2 = text2 == string.Empty;
				if (!flag2)
				{
					Form1.gstruct49_0[num].string_4 = null;
					this.listView2.Items.Clear();
					string text3 = Class12.smethod_15(Class12.smethod_33(text2, 0, 0, 1));
					bool flag3 = text3 == null || !(text3 != string.Empty);
					if (!flag3)
					{
						string[] array = text3.Split(new char[]
						{
							'\r'
						});
						int num2 = 0;
						Form1.gstruct49_0[num].string_4 = new string[array.Length];
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = array[i] != null && !(array[i] == string.Empty);
							if (flag4)
							{
								Form1.gstruct49_0[num].string_4[num2] = array[i];
								num2++;
								this.method_2(Class10.smethod_1(array[i], 1, false));
							}
						}
						bool flag5 = num2 != 0;
						if (flag5)
						{
							bool flag6 = num2 != array.Length;
							if (flag6)
							{
								Array.Resize<string>(ref Form1.gstruct49_0[num].string_4, num2);
							}
						}
						else
						{
							Form1.gstruct49_0[num].string_4 = null;
						}
					}
				}
			}
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0014FF60 File Offset: 0x0014E160
		private void buttonS_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num < 0;
			if (!flag)
			{
				string str = Class10.smethod_1(Form1.gstruct49_0[num].string_22, 1, false);
				string[] string_ = Form1.gstruct49_0[num].string_4;
				string text = string.Empty;
				bool flag2 = string_ != null && string_.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < string_.Length; i++)
					{
						bool flag3 = text != string.Empty;
						if (flag3)
						{
							text += "\r";
						}
						text += string_[i];
					}
					text = Class12.smethod_16(text);
				}
				string text2 = Class53.string_8 + "\\Badlist";
				Class12.smethod_23(text2);
				string text3 = Class53.smethod_27(text2, str + "_badlist.txt");
				bool flag4 = text3 != null && text3 != string.Empty;
				if (flag4)
				{
					Class12.smethod_34(text3, text, 2);
				}
			}
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00150068 File Offset: 0x0014E268
		private void buttonXj_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLocdo.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				Form1.gstruct49_0[num].string_4 = null;
				this.listView2.Items.Clear();
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x001500B8 File Offset: 0x0014E2B8
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_3(string string_3)
		{
			base.Text = string_3;
		}

		// Token: 0x04000939 RID: 2361
		public int int_0;

		// Token: 0x0400093A RID: 2362
		public int int_1;

		// Token: 0x0400093B RID: 2363
		public int int_2;

		// Token: 0x0400093C RID: 2364
		public int int_3;

		// Token: 0x0400093D RID: 2365
		public static bool bool_0 = false;

		// Token: 0x0400093E RID: 2366
		public static int int_4 = 0;

		// Token: 0x0400093F RID: 2367
		private string[] string_0 = new string[]
		{
			"Kim",
			"Mộc",
			"Thủy",
			"Hỏa",
			"Thổ"
		};

		// Token: 0x04000940 RID: 2368
		private string[] string_1 = new string[]
		{
			"Giữ đồ theo thuộc tính",
			"Bán tất cả"
		};

		// Token: 0x04000941 RID: 2369
		public static int int_5 = Class62.smethod_3("TocdoNhatdoExx", 0, "80");

		// Token: 0x04000942 RID: 2370
		private Color color_0 = Color.MidnightBlue;

		// Token: 0x04000943 RID: 2371
		private static long long_0 = 0L;

		// Token: 0x04000944 RID: 2372
		private static string[] string_2 = null;

		// Token: 0x04000945 RID: 2373
		private IContainer icontainer_0 = null;
	}
}
