using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006F RID: 111
	public partial class FormHaucanTuithuoc : Form
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00146588 File Offset: 0x00144788
		public FormHaucanTuithuoc()
		{
			FormHaucanTuithuoc.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x001465E8 File Offset: 0x001447E8
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = false;
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_0);
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
			this.int_2 = 0;
			this.int_3 = 0;
			FormHaucanTuithuoc.int_1 = -1;
			FormHaucanTuithuoc.int_0 = 0;
			FormHaucanTuithuoc.bool_0 = false;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00146694 File Offset: 0x00144894
		private void FormHaucanTuithuoc_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				FormHaucanTuithuoc.gstruct49_0 = Form1.gstruct49_0[num];
				bool flag2 = this.int_2 >= 0 && this.int_3 >= 0;
				if (flag2)
				{
					int num2 = this.int_2 - base.Width;
					int num3 = this.int_3 + this.int_5 - base.Height;
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
				bool flag5 = num >= 0;
				if (flag5)
				{
					this.buttonThem.Enabled = true;
					this.listView1.Enabled = true;
					FormHaucanTuithuoc.gstruct49_0 = Form1.gstruct49_0[num];
					this.method_0(FormHaucanTuithuoc.gstruct49_0.gstruct34_0);
					this.int_6 = -1;
					bool flag6 = FormHaucanTuithuoc.gstruct49_0.gstruct34_0 != null;
					if (flag6)
					{
						this.int_6 = 0;
						this.method_1(FormHaucanTuithuoc.gstruct49_0.gstruct34_0[0]);
					}
				}
				else
				{
					this.buttonThem.Enabled = false;
					this.listView1.Enabled = false;
				}
				this.textBoxSoluongMax.Text = Form1.int_12.ToString();
				this.checkBoxKhongMo.Checked = (Form1.int_13 > 0);
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				FormHaucanTuithuoc.bool_1 = true;
				base.TopMost = true;
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00146848 File Offset: 0x00144A48
		private void method_0(GStruct34[] gstruct34_0)
		{
			this.listView1.Items.Clear();
			this.int_6 = -1;
			bool flag = gstruct34_0 != null && gstruct34_0.Length != 0;
			if (flag)
			{
				for (int i = 0; i < gstruct34_0.Length; i++)
				{
					this.method_2(this.listView1, gstruct34_0[i]);
				}
				this.int_6 = 0;
				this.listView1.Items[this.int_6].Focused = true;
				this.listView1.Items[this.int_6].Selected = true;
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x001468E8 File Offset: 0x00144AE8
		private void method_1(GStruct34 gstruct34_0)
		{
			FormHaucanTuithuoc.bool_1 = false;
			this.comboBoxTenTuiMauHotro.Text = Class10.smethod_1(gstruct34_0.string_0, 1, false);
			this.checkBoxMoTheoThoigian.Checked = (gstruct34_0.int_0 > 0);
			this.textBoxThoigian.Text = gstruct34_0.int_3.ToString();
			this.checkBoxMoTheoSoluong.Checked = (gstruct34_0.int_4 > 0);
			this.textBoxMothuocKhicon.Text = gstruct34_0.int_5.ToString();
			this.checkBoxClickMenu.Checked = (gstruct34_0.int_7 > 0);
			string text = "1,1";
			bool flag = gstruct34_0.int_8 != null;
			if (flag)
			{
				text = null;
				for (int i = 0; i < gstruct34_0.int_8.Length; i++)
				{
					bool flag2 = text != null;
					if (flag2)
					{
						text += ",";
					}
					text += gstruct34_0.int_8[i].ToString();
				}
			}
			this.textBoxMenu.Text = text;
			this.checkBoxCoNhapSoluong.Checked = (gstruct34_0.int_6 > 0);
			this.checkBoxTrangThai.Checked = (gstruct34_0.int_1 > 0);
			this.checkBoxTamDung.Checked = (gstruct34_0.int_2 > 0);
			this.checkBoxTamDung.Enabled = (gstruct34_0.int_1 > 0);
			Thread.Sleep(100);
			FormHaucanTuithuoc.bool_1 = true;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00146A54 File Offset: 0x00144C54
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormHaucanTuithuoc.bool_0;
			if (flag)
			{
				bool flag2 = FormHaucanTuithuoc.int_1 == FormHaucanTuithuoc.int_0;
				if (!flag2)
				{
					FormHaucanTuithuoc.int_1 = FormHaucanTuithuoc.int_0;
					int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
					bool flag3 = num >= 0;
					if (flag3)
					{
						this.buttonThem.Enabled = true;
						this.listView1.Enabled = true;
						FormHaucanTuithuoc.gstruct49_0 = Form1.gstruct49_0[num];
						this.method_0(FormHaucanTuithuoc.gstruct49_0.gstruct34_0);
						this.int_6 = -1;
						bool flag4 = FormHaucanTuithuoc.gstruct49_0.gstruct34_0 != null;
						if (flag4)
						{
							this.int_6 = 0;
							this.method_1(FormHaucanTuithuoc.gstruct49_0.gstruct34_0[0]);
						}
					}
					else
					{
						this.buttonThem.Enabled = false;
						this.listView1.Enabled = false;
					}
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00146B48 File Offset: 0x00144D48
		private void method_2(ListView listView_0, GStruct34 gstruct34_0)
		{
			try
			{
				string text = gstruct34_0.int_5.ToString();
				bool flag = gstruct34_0.int_4 > 0;
				if (flag)
				{
					text = "* " + text;
				}
				string text2 = gstruct34_0.int_3.ToString();
				bool flag2 = gstruct34_0.int_0 > 0;
				if (flag2)
				{
					text2 = "* " + text2;
				}
				string text3 = "không";
				bool flag3 = gstruct34_0.int_7 > 0;
				if (flag3)
				{
					text3 = "có";
				}
				string[] array = new string[]
				{
					Class10.smethod_1(gstruct34_0.string_0, 1, false),
					text,
					text2,
					this.string_1[(int)Convert.ToByte(gstruct34_0.int_6 > 0)],
					text3,
					gstruct34_0.int_1.ToString()
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag4 = array.Length > 1;
				if (flag4)
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

		// Token: 0x060008B3 RID: 2227 RVA: 0x00146C8C File Offset: 0x00144E8C
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			this.int_6 = -1;
			bool flag = this.listView1.Items == null || this.listView1.Items.Count == 0;
			if (!flag)
			{
				string text = null;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						this.int_6 = i;
						text = this.listView1.Items[i].SubItems[0].Text;
						break;
					}
				}
				bool flag2 = this.int_6 < 0 || text == null;
				if (!flag2)
				{
					bool flag3 = text != this.comboBoxTenTuiMauHotro.Text;
					if (flag3)
					{
						this.comboBoxTenTuiMauHotro.Items.Clear();
						this.comboBoxTenTuiMauHotro.Items.Add(text);
						this.comboBoxTenTuiMauHotro.Text = text;
					}
					int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
					bool flag4 = num < 0 || Form1.gstruct49_0[num].gstruct34_0 == null;
					if (!flag4)
					{
						for (int j = 0; j < Form1.gstruct49_0[num].gstruct34_0.Length; j++)
						{
							bool flag5 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[j].string_0, 1, false) == text;
							if (flag5)
							{
								this.method_1(Form1.gstruct49_0[num].gstruct34_0[j]);
							}
						}
					}
				}
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00146E48 File Offset: 0x00145048
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxTenTuiMauHotro.Text;
			this.comboBoxTenTuiMauHotro.Items.Clear();
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
			bool flag = num < 0 || Form1.gstruct49_0[num].gstruct34_0 == null || Form1.gstruct49_0[num].gstruct34_0.Length == 0;
			if (flag)
			{
				bool flag2 = this.listView1.Items.Count > 0;
				if (flag2)
				{
					this.listView1.Items.Clear();
				}
				this.int_6 = -1;
			}
			else
			{
				bool flag3 = Form1.gstruct49_0[num].gstruct34_0.Length == 1;
				if (flag3)
				{
					bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[0].string_0, 1, false) == text;
					if (flag4)
					{
						Form1.gstruct49_0[num].gstruct34_0 = null;
						this.int_6 = -1;
						this.listView1.Items.Clear();
					}
				}
				else
				{
					GStruct34[] array = new GStruct34[Form1.gstruct49_0[num].gstruct34_0.Length];
					int num2 = 0;
					for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
					{
						bool flag5 = !(Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) != text);
						if (!flag5)
						{
							array[num2].string_0 = Form1.gstruct49_0[num].gstruct34_0[i].string_0;
							array[num2].int_4 = Form1.gstruct49_0[num].gstruct34_0[i].int_4;
							array[num2].int_5 = Form1.gstruct49_0[num].gstruct34_0[i].int_5;
							array[num2].int_0 = Form1.gstruct49_0[num].gstruct34_0[i].int_0;
							array[num2].int_3 = Form1.gstruct49_0[num].gstruct34_0[i].int_3;
							array[num2].int_6 = Form1.gstruct49_0[num].gstruct34_0[i].int_6;
							array[num2].int_7 = Form1.gstruct49_0[num].gstruct34_0[i].int_7;
							bool flag6 = Form1.gstruct49_0[num].gstruct34_0[i].int_8 != null;
							if (flag6)
							{
								array[num2].int_8 = new int[Form1.gstruct49_0[num].gstruct34_0[i].int_8.Length];
								for (int j = 0; j < Form1.gstruct49_0[num].gstruct34_0[i].int_8.Length; j++)
								{
									array[num2].int_8[j] = Form1.gstruct49_0[num].gstruct34_0[i].int_8[j];
								}
							}
							num2++;
						}
					}
					for (int k = 0; k < this.listView1.Items.Count; k++)
					{
						bool flag7 = this.listView1.Items[k].SubItems[0].Text == text;
						if (flag7)
						{
							this.listView1.Items.RemoveAt(k);
							break;
						}
					}
					bool flag8 = num2 == Form1.gstruct49_0[num].gstruct34_0.Length;
					if (flag8)
					{
						this.int_6 = 0;
						this.listView1.Items[this.int_6].Focused = true;
						this.listView1.Items[this.int_6].Selected = true;
						this.method_1(Form1.gstruct49_0[num].gstruct34_0[this.int_6]);
					}
					else
					{
						Form1.gstruct49_0[num].gstruct34_0 = new GStruct34[num2];
						for (int l = 0; l < num2; l++)
						{
							Form1.gstruct49_0[num].gstruct34_0[l].string_0 = array[l].string_0;
							Form1.gstruct49_0[num].gstruct34_0[l].int_4 = array[l].int_4;
							Form1.gstruct49_0[num].gstruct34_0[l].int_5 = array[l].int_5;
							Form1.gstruct49_0[num].gstruct34_0[l].int_0 = array[l].int_0;
							Form1.gstruct49_0[num].gstruct34_0[l].int_3 = array[l].int_3;
							Form1.gstruct49_0[num].gstruct34_0[l].int_6 = array[l].int_6;
							Form1.gstruct49_0[num].gstruct34_0[l].int_7 = array[l].int_7;
							bool flag9 = array[l].int_8 != null;
							if (flag9)
							{
								Form1.gstruct49_0[num].gstruct34_0[l].int_8 = new int[array[l].int_8.Length];
								for (int m = 0; m < array[l].int_8.Length; m++)
								{
									Form1.gstruct49_0[num].gstruct34_0[l].int_8[m] = array[l].int_8[m];
								}
							}
						}
						bool flag10 = this.listView1.Items.Count <= this.int_6;
						if (flag10)
						{
							this.int_6--;
						}
						bool flag11 = 0 <= this.int_6;
						if (flag11)
						{
							this.listView1.Items[this.int_6].Focused = true;
							this.listView1.Items[this.int_6].Selected = true;
							this.method_1(Form1.gstruct49_0[num].gstruct34_0[this.int_6]);
						}
					}
				}
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00147540 File Offset: 0x00145740
		private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
		{
			FormHaucanTuithuoc.string_0 = Class79.smethod_34(FormHaucanTuithuoc.gstruct49_0, null, 3);
			this.comboBoxTenTuiMauHotro.Items.Clear();
			bool flag = FormHaucanTuithuoc.string_0 != null;
			if (flag)
			{
				Array.Sort<string>(FormHaucanTuithuoc.string_0);
				for (int i = 0; i < FormHaucanTuithuoc.string_0.Length; i++)
				{
					this.comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(FormHaucanTuithuoc.string_0[i], 1, false));
				}
			}
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x001475C0 File Offset: 0x001457C0
		private void checkBoxMoTheoSoluong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = "0";
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text2;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_4 = (int)Convert.ToByte(this.checkBoxMoTheoSoluong.Checked);
								text = Form1.gstruct49_0[num].gstruct34_0[i].int_5.ToString();
								break;
							}
						}
					}
					bool @checked = this.checkBoxMoTheoSoluong.Checked;
					if (@checked)
					{
						text = "* " + text;
					}
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						bool flag5 = this.listView1.Items[j].SubItems[0].Text == text2;
						if (flag5)
						{
							this.listView1.Items[j].SubItems[1].Text = text;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00147788 File Offset: 0x00145988
		private void textBoxMothuocKhicon_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = "0";
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					int i;
					if (flag3)
					{
						for (i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text2;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_5 = Class12.smethod_11(this.textBoxMothuocKhicon.Text);
								text = Form1.gstruct49_0[num].gstruct34_0[i].int_5.ToString();
								break;
							}
						}
					}
					bool @checked = this.checkBoxMoTheoSoluong.Checked;
					if (@checked)
					{
						text = "* " + text;
					}
					i = 0;
					for (;;)
					{
						bool flag5 = i < this.listView1.Items.Count;
						if (!flag5)
						{
							goto IL_18C;
						}
						bool flag6 = this.listView1.Items[i].SubItems[0].Text == text2;
						if (flag6)
						{
							break;
						}
						i++;
					}
					this.listView1.Items[i].SubItems[1].Text = text;
					IL_18C:;
				}
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x0014794C File Offset: 0x00145B4C
		private void checkBoxMoTheoThoigian_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = "0";
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					int i;
					if (flag3)
					{
						for (i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text2;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_0 = (int)Convert.ToByte(this.checkBoxMoTheoThoigian.Checked);
								text = Form1.gstruct49_0[num].gstruct34_0[i].int_3.ToString();
								break;
							}
						}
					}
					bool @checked = this.checkBoxMoTheoThoigian.Checked;
					if (@checked)
					{
						text = "* " + text;
					}
					i = 0;
					for (;;)
					{
						bool flag5 = i < this.listView1.Items.Count;
						if (!flag5)
						{
							goto IL_18C;
						}
						bool flag6 = this.listView1.Items[i].SubItems[0].Text == text2;
						if (flag6)
						{
							break;
						}
						i++;
					}
					this.listView1.Items[i].SubItems[2].Text = text;
					IL_18C:;
				}
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00147B10 File Offset: 0x00145D10
		private void textBoxThoigian_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = "0";
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text2;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_3 = Class12.smethod_11(this.textBoxThoigian.Text);
								text = Form1.gstruct49_0[num].gstruct34_0[i].int_3.ToString();
								break;
							}
						}
					}
					bool @checked = this.checkBoxMoTheoThoigian.Checked;
					if (@checked)
					{
						text = "* " + text;
					}
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						bool flag5 = this.listView1.Items[j].SubItems[0].Text == text2;
						if (flag5)
						{
							this.listView1.Items[j].SubItems[2].Text = text;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00147CD8 File Offset: 0x00145ED8
		private void checkBoxClickMenu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_7 = (int)Convert.ToByte(this.checkBoxClickMenu.Checked);
								break;
							}
						}
					}
					string text2 = "không";
					bool @checked = this.checkBoxClickMenu.Checked;
					if (@checked)
					{
						text2 = "có";
					}
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						bool flag5 = this.listView1.Items[j].SubItems[0].Text == text;
						if (flag5)
						{
							this.listView1.Items[j].SubItems[4].Text = text2;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00147E74 File Offset: 0x00146074
		private void checkBoxCoNhapSoluong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					int i;
					if (flag3)
					{
						for (i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_6 = (int)Convert.ToByte(this.checkBoxCoNhapSoluong.Checked);
								break;
							}
						}
					}
					string text2 = this.string_1[(int)Convert.ToByte(this.checkBoxCoNhapSoluong.Checked)];
					i = 0;
					for (;;)
					{
						bool flag5 = i < this.listView1.Items.Count;
						if (!flag5)
						{
							goto IL_15A;
						}
						bool flag6 = this.listView1.Items[i].SubItems[0].Text == text;
						if (flag6)
						{
							break;
						}
						i++;
					}
					this.listView1.Items[i].SubItems[3].Text = text2;
					IL_15A:;
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00148008 File Offset: 0x00146208
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1 || FormHaucanTuithuoc.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct34 gstruct = default(GStruct34);
					string text = this.comboBoxTenTuiMauHotro.Text;
					for (int i = 0; i < FormHaucanTuithuoc.string_0.Length; i++)
					{
						bool flag3 = Class10.smethod_1(FormHaucanTuithuoc.string_0[i], 1, false) == text;
						if (flag3)
						{
							gstruct.string_0 = FormHaucanTuithuoc.string_0[i];
							gstruct.int_4 = (int)Convert.ToByte(this.checkBoxMoTheoSoluong.Checked);
							gstruct.int_5 = Class12.smethod_11(this.textBoxMothuocKhicon.Text);
							gstruct.int_0 = (int)Convert.ToByte(this.checkBoxMoTheoThoigian.Checked);
							gstruct.int_3 = Class12.smethod_11(this.textBoxThoigian.Text);
							gstruct.int_6 = (int)Convert.ToByte(this.checkBoxCoNhapSoluong.Checked);
							gstruct.int_7 = (int)Convert.ToByte(this.checkBoxClickMenu.Checked);
							gstruct.int_8 = Form1.smethod_2(this.textBoxMenu.Text);
							gstruct.int_1 = (int)Convert.ToByte(this.checkBoxTrangThai.Checked);
							gstruct.int_2 = (int)Convert.ToByte(this.checkBoxTamDung.Checked);
							break;
						}
					}
					bool flag4 = gstruct.int_8 == null;
					if (flag4)
					{
						gstruct.int_8 = new int[]
						{
							1,
							1
						};
					}
					bool flag5 = Form1.gstruct49_0[num].gstruct34_0 == null || Form1.gstruct49_0[num].gstruct34_0.Length == 0;
					if (flag5)
					{
						Form1.gstruct49_0[num].gstruct34_0 = new GStruct34[1];
						Form1.gstruct49_0[num].gstruct34_0[0].string_0 = gstruct.string_0;
						Form1.gstruct49_0[num].gstruct34_0[0].int_4 = gstruct.int_4;
						Form1.gstruct49_0[num].gstruct34_0[0].int_5 = gstruct.int_5;
						Form1.gstruct49_0[num].gstruct34_0[0].int_0 = gstruct.int_0;
						Form1.gstruct49_0[num].gstruct34_0[0].int_3 = gstruct.int_3;
						Form1.gstruct49_0[num].gstruct34_0[0].int_6 = gstruct.int_6;
						Form1.gstruct49_0[num].gstruct34_0[0].int_7 = gstruct.int_7;
						Form1.gstruct49_0[num].gstruct34_0[0].int_8 = new int[gstruct.int_8.Length];
						for (int j = 0; j < gstruct.int_8.Length; j++)
						{
							Form1.gstruct49_0[num].gstruct34_0[0].int_8[j] = gstruct.int_8[j];
						}
						Form1.gstruct49_0[num].gstruct34_0[0].int_1 = gstruct.int_1;
						Form1.gstruct49_0[num].gstruct34_0[0].int_2 = gstruct.int_2;
						this.listView1.Items.Clear();
						this.int_6 = 0;
					}
					else
					{
						GStruct34[] array = new GStruct34[Form1.gstruct49_0[num].gstruct34_0.Length + 1];
						for (int k = 0; k < Form1.gstruct49_0[num].gstruct34_0.Length; k++)
						{
							bool flag6 = !(gstruct.string_0 == Form1.gstruct49_0[num].gstruct34_0[k].string_0);
							if (!flag6)
							{
								return;
							}
							array[k].string_0 = Form1.gstruct49_0[num].gstruct34_0[k].string_0;
							array[k].int_4 = Form1.gstruct49_0[num].gstruct34_0[k].int_4;
							array[k].int_5 = Form1.gstruct49_0[num].gstruct34_0[k].int_5;
							array[k].int_0 = Form1.gstruct49_0[num].gstruct34_0[k].int_0;
							array[k].int_3 = Form1.gstruct49_0[num].gstruct34_0[k].int_3;
							array[k].int_6 = Form1.gstruct49_0[num].gstruct34_0[k].int_6;
							array[k].int_7 = Form1.gstruct49_0[num].gstruct34_0[k].int_7;
							bool flag7 = Form1.gstruct49_0[num].gstruct34_0[k].int_8 == null;
							if (flag7)
							{
								Form1.gstruct49_0[num].gstruct34_0[k].int_8 = new int[]
								{
									1,
									1
								};
							}
							array[k].int_8 = new int[Form1.gstruct49_0[num].gstruct34_0[k].int_8.Length];
							for (int l = 0; l < array[k].int_8.Length; l++)
							{
								array[k].int_8[l] = Form1.gstruct49_0[num].gstruct34_0[k].int_8[l];
							}
							array[k].int_1 = Form1.gstruct49_0[num].gstruct34_0[k].int_1;
							array[k].int_2 = Form1.gstruct49_0[num].gstruct34_0[k].int_2;
						}
						int num2 = array.Length - 1;
						array[num2].string_0 = gstruct.string_0;
						array[num2].int_4 = gstruct.int_4;
						array[num2].int_5 = gstruct.int_5;
						array[num2].int_0 = gstruct.int_0;
						array[num2].int_3 = gstruct.int_3;
						array[num2].int_6 = gstruct.int_6;
						array[num2].int_7 = gstruct.int_7;
						bool flag8 = gstruct.int_8 == null;
						if (flag8)
						{
							gstruct.int_8 = new int[]
							{
								1,
								1
							};
						}
						array[num2].int_8 = new int[gstruct.int_8.Length];
						for (int m = 0; m < gstruct.int_8.Length; m++)
						{
							array[num2].int_8[m] = gstruct.int_8[m];
						}
						array[num2].int_1 = gstruct.int_1;
						array[num2].int_2 = gstruct.int_2;
						Form1.gstruct49_0[num].gstruct34_0 = new GStruct34[array.Length];
						for (int n = 0; n < Form1.gstruct49_0[num].gstruct34_0.Length; n++)
						{
							Form1.gstruct49_0[num].gstruct34_0[n].string_0 = array[n].string_0;
							Form1.gstruct49_0[num].gstruct34_0[n].int_4 = array[n].int_4;
							Form1.gstruct49_0[num].gstruct34_0[n].int_5 = array[n].int_5;
							Form1.gstruct49_0[num].gstruct34_0[n].int_0 = array[n].int_0;
							Form1.gstruct49_0[num].gstruct34_0[n].int_3 = array[n].int_3;
							Form1.gstruct49_0[num].gstruct34_0[n].int_6 = array[n].int_6;
							Form1.gstruct49_0[num].gstruct34_0[n].int_7 = array[n].int_7;
							Form1.gstruct49_0[num].gstruct34_0[n].int_8 = new int[array[n].int_8.Length];
							for (int num3 = 0; num3 < gstruct.int_8.Length; num3++)
							{
								Form1.gstruct49_0[num].gstruct34_0[n].int_8[num3] = array[n].int_8[num3];
							}
							Form1.gstruct49_0[num].gstruct34_0[n].int_1 = array[n].int_1;
							Form1.gstruct49_0[num].gstruct34_0[n].int_2 = array[n].int_2;
						}
					}
					this.method_2(this.listView1, gstruct);
					bool flag9 = 0 <= this.int_6 && this.int_6 < this.listView1.Items.Count;
					if (flag9)
					{
						this.listView1.Items[this.int_6].Focused = true;
						this.listView1.Items[this.int_6].Selected = true;
					}
				}
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00148A78 File Offset: 0x00146C78
		private void buttonAppAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
			bool flag = num < 0 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = i == num;
					if (!flag2)
					{
						Form1.gstruct49_0[i].gstruct34_0 = null;
						bool flag3 = Form1.gstruct49_0[num].gstruct34_0 == null || Form1.gstruct49_0[num].gstruct34_0.Length == 0;
						if (!flag3)
						{
							Form1.gstruct49_0[i].gstruct34_0 = new GStruct34[Form1.gstruct49_0[num].gstruct34_0.Length];
							for (int j = 0; j < Form1.gstruct49_0[num].gstruct34_0.Length; j++)
							{
								Form1.gstruct49_0[i].gstruct34_0[j].string_0 = Form1.gstruct49_0[num].gstruct34_0[j].string_0;
								Form1.gstruct49_0[i].gstruct34_0[j].int_4 = Form1.gstruct49_0[num].gstruct34_0[j].int_4;
								Form1.gstruct49_0[i].gstruct34_0[j].int_5 = Form1.gstruct49_0[num].gstruct34_0[j].int_5;
								Form1.gstruct49_0[i].gstruct34_0[j].int_0 = Form1.gstruct49_0[num].gstruct34_0[j].int_0;
								Form1.gstruct49_0[i].gstruct34_0[j].int_3 = Form1.gstruct49_0[num].gstruct34_0[j].int_3;
								Form1.gstruct49_0[i].gstruct34_0[j].int_7 = Form1.gstruct49_0[num].gstruct34_0[j].int_7;
								bool flag4 = Form1.gstruct49_0[num].gstruct34_0[j].int_8 == null;
								if (flag4)
								{
									Form1.gstruct49_0[num].gstruct34_0[j].int_8 = new int[]
									{
										1,
										1
									};
								}
								Form1.gstruct49_0[i].gstruct34_0[j].int_8 = new int[Form1.gstruct49_0[num].gstruct34_0[j].int_8.Length];
								for (int k = 0; k < Form1.gstruct49_0[num].gstruct34_0[j].int_8.Length; k++)
								{
									Form1.gstruct49_0[i].gstruct34_0[j].int_8[k] = Form1.gstruct49_0[num].gstruct34_0[j].int_8[k];
								}
								Form1.gstruct49_0[i].gstruct34_0[j].int_6 = Form1.gstruct49_0[num].gstruct34_0[j].int_6;
								Form1.gstruct49_0[i].gstruct34_0[j].int_1 = Form1.gstruct49_0[num].gstruct34_0[j].int_1;
								Form1.gstruct49_0[i].gstruct34_0[j].int_2 = Form1.gstruct49_0[num].gstruct34_0[j].int_2;
								Class53.smethod_13(Form1.gstruct49_0[i], null);
							}
						}
					}
				}
			}
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00148E84 File Offset: 0x00147084
		private void checkBoxTrangThai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = "0";
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					int num2 = (int)Convert.ToByte(this.checkBoxTrangThai.Checked);
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text2;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_1 = num2;
								text = num2.ToString();
								break;
							}
						}
					}
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						bool flag5 = this.listView1.Items[j].SubItems[0].Text == text2;
						if (flag5)
						{
							this.listView1.Items[j].SubItems[5].Text = text;
							break;
						}
					}
					this.checkBoxTamDung.Enabled = (num2 > 0);
				}
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00149024 File Offset: 0x00147224
		private void checkBoxTamDung_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 == null;
					if (!flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_2 = (int)Convert.ToByte(this.checkBoxTamDung.Checked);
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00149124 File Offset: 0x00147324
		private void textBoxMenu_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormHaucanTuithuoc.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHaucanTuithuoc.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenTuiMauHotro.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct34_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct34_0.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].gstruct34_0[i].string_0, 1, false) == text;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct34_0[i].int_8 = Form1.smethod_2(this.textBoxMenu.Text);
								break;
							}
						}
					}
					string text2 = "không";
					bool @checked = this.checkBoxClickMenu.Checked;
					if (@checked)
					{
						text2 = "có";
					}
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						bool flag5 = this.listView1.Items[j].SubItems[0].Text == text;
						if (flag5)
						{
							this.listView1.Items[j].SubItems[4].Text = text2;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x001492C0 File Offset: 0x001474C0
		private void textBoxSoluongMax_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHaucanTuithuoc.bool_1;
			if (flag)
			{
				Form1.int_12 = Class12.smethod_11(this.textBoxSoluongMax.Text);
				Class62.smethod_10(Class53.string_3, "SoluongThuocMoilanMo", Form1.int_12, "", 0);
			}
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00149320 File Offset: 0x00147520
		private void checkBoxKhongMo_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHaucanTuithuoc.bool_1;
			if (flag)
			{
				Form1.int_13 = (int)Convert.ToByte(this.checkBoxKhongMo.Checked);
				Class62.smethod_10(Class53.string_3, "PCDKhongMoTui", Form1.int_13, "", 0);
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00149380 File Offset: 0x00147580
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x040008D0 RID: 2256
		public static bool bool_0 = false;

		// Token: 0x040008D1 RID: 2257
		public static int int_0 = 0;

		// Token: 0x040008D2 RID: 2258
		public static int int_1 = -1;

		// Token: 0x040008D3 RID: 2259
		public int int_2;

		// Token: 0x040008D4 RID: 2260
		public int int_3;

		// Token: 0x040008D5 RID: 2261
		public int int_4;

		// Token: 0x040008D6 RID: 2262
		public int int_5;

		// Token: 0x040008D7 RID: 2263
		private int int_6 = -1;

		// Token: 0x040008D8 RID: 2264
		private static bool bool_1 = false;

		// Token: 0x040008D9 RID: 2265
		private static GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x040008DA RID: 2266
		private static string[] string_0 = null;

		// Token: 0x040008DB RID: 2267
		private string[] string_1 = new string[]
		{
			"không",
			"có"
		};

		// Token: 0x040008DC RID: 2268
		private IContainer icontainer_0 = null;
	}
}
