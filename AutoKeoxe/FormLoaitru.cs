using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000072 RID: 114
	public partial class FormLoaitru : Form
	{
		// Token: 0x060008EE RID: 2286 RVA: 0x0014CCEB File Offset: 0x0014AEEB
		public FormLoaitru()
		{
			FormLoaitru.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0014CD24 File Offset: 0x0014AF24
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x0014D3DC File Offset: 0x0014B5DC
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			string text = "";
			bool flag = Class53.string_6 != null;
			if (flag)
			{
				for (int i = 0; i < Class53.string_6.Length; i++)
				{
					bool flag2 = !(Class53.string_6[i] != "");
					if (!flag2)
					{
						bool flag3 = text != "";
						if (flag3)
						{
							text += "|";
						}
						text += Class53.string_6[i];
						bool flag4 = Form1.gstruct49_0 == null;
						if (!flag4)
						{
							for (int j = 0; j < Form1.gstruct49_0.Length; j++)
							{
								bool flag5 = Class53.string_6[i] == Form1.gstruct49_0[j].string_22;
								if (flag5)
								{
									Form1.gstruct49_0[j].bool_22 = true;
									break;
								}
							}
						}
					}
				}
			}
			Class62.smethod_10(Class53.string_3, Class53.string_5, Class12.smethod_16(text), "", 0);
			this.int_0 = 0;
			this.int_1 = 0;
			FormLoaitru.bool_0 = false;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0014D500 File Offset: 0x0014B700
		private void FormLoaitru_Load(object sender, EventArgs e)
		{
			bool flag = this.int_0 > 0 && this.int_1 > 0;
			if (flag)
			{
				int num = this.int_0 - base.Width - 10;
				int num2 = this.int_1 - base.Height - 10;
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
			bool flag4 = Class53.string_6 != null && Class53.string_6.Length != 0;
			if (flag4)
			{
				for (int i = 0; i < Class53.string_6.Length; i++)
				{
					bool flag5 = Class53.string_6[i] != "";
					if (flag5)
					{
						this.method_0(this.listView1, Class10.smethod_1(Class53.string_6[i], 1, false));
					}
				}
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			this.method_1("Danh sach loai tru");
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0014D618 File Offset: 0x0014B818
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormLoaitru.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0014D63C File Offset: 0x0014B83C
		private void method_0(ListView listView_0, string string_0)
		{
			try
			{
				ListViewItem value = new ListViewItem(string_0);
				listView_0.Items.Add(value);
			}
			catch
			{
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0014D678 File Offset: 0x0014B878
		private void comboBoxAcc_DropDown(object sender, EventArgs e)
		{
			this.comboBoxAcc.Items.Clear();
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = false;
					bool flag3 = Class53.string_6 != null;
					if (flag3)
					{
						for (int j = 0; j < Class53.string_6.Length; j++)
						{
							bool flag4 = Class53.string_6[j] == Form1.gstruct49_0[i].string_22;
							if (flag4)
							{
								flag2 = true;
								break;
							}
						}
					}
					bool flag5 = !flag2;
					if (flag5)
					{
						string item = Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
						this.comboBoxAcc.Items.Add(item);
					}
				}
			}
			this.comboBoxAcc.Text = "";
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0014D768 File Offset: 0x0014B968
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null || Form1.gstruct49_0.Length == 0;
			if (!flag)
			{
				string text = this.comboBoxAcc.Text;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = !(Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false) == text);
					if (!flag2)
					{
						bool flag3 = false;
						bool flag4 = Class53.string_6 != null;
						if (flag4)
						{
							for (int j = 0; j < Class53.string_6.Length; j++)
							{
								bool flag5 = Class53.string_6[j] == Form1.gstruct49_0[i].string_22;
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
							Class12.smethod_29(ref Class53.string_6, Form1.gstruct49_0[i].string_22);
							Form1.gstruct49_0[i].bool_22 = true;
							this.method_0(this.listView1, Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
						}
						break;
					}
				}
				this.comboBoxAcc.Items.Clear();
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0014D8B0 File Offset: 0x0014BAB0
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices == null || this.listView1.SelectedIndices.Count == 0;
			if (!flag)
			{
				string text = this.listView1.Items[this.listView1.SelectedIndices[0]].SubItems[0].Text;
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false) == text;
						if (flag3)
						{
							Form1.gstruct49_0[i].bool_22 = false;
							break;
						}
					}
				}
				for (int j = 0; j < this.listView1.Items.Count; j++)
				{
					bool flag4 = this.listView1.Items[j].SubItems[0].Text == text;
					if (flag4)
					{
						this.listView1.Items.RemoveAt(j);
						break;
					}
				}
				bool flag5 = Class53.string_6 != null;
				if (flag5)
				{
					for (int k = 0; k < Class53.string_6.Length; k++)
					{
						bool flag6 = Class10.smethod_1(Class53.string_6[k], 1, false) == text;
						if (flag6)
						{
							Class12.smethod_30(ref Class53.string_6, Class53.string_6[k], false);
							break;
						}
					}
				}
				this.comboBoxAcc.Items.Clear();
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0014DA58 File Offset: 0x0014BC58
		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			this.int_4 = -1;
			bool flag = this.listView1.Items == null;
			if (!flag)
			{
				string text = this.comboBoxAcc.Text;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						this.int_4 = i;
						string text2 = this.listView1.Items[i].SubItems[0].Text;
						bool flag2 = text != text2;
						if (flag2)
						{
							this.comboBoxAcc.Items.Clear();
							this.comboBoxAcc.Items.Add(text2);
							this.comboBoxAcc.Text = text2;
						}
						break;
					}
				}
			}
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0014DB44 File Offset: 0x0014BD44
		private void buttonXoahet_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxAcc.Text;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].bool_22 = false;
				}
			}
			Class53.string_6 = null;
			this.listView1.Items.Clear();
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0014DBAC File Offset: 0x0014BDAC
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null || Form1.gstruct49_0.Length == 0;
			if (!flag)
			{
				Class53.string_6 = null;
				this.listView1.Items.Clear();
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					string string_ = Form1.gstruct49_0[i].string_22;
					bool flag2 = string_ != null && !(string_ == string.Empty);
					if (flag2)
					{
						bool flag3 = Class53.string_6 == null;
						if (flag3)
						{
							Class53.string_6 = new string[1];
						}
						else
						{
							Array.Resize<string>(ref Class53.string_6, Class53.string_6.Length + 1);
						}
						Form1.gstruct49_0[i].bool_22 = true;
						Class53.string_6[Class53.string_6.Length - 1] = string_;
						this.method_0(this.listView1, Class10.smethod_1(string_, 1, false));
					}
				}
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_1(string string_0)
		{
			base.Text = string_0;
		}

		// Token: 0x04000927 RID: 2343
		private IContainer icontainer_0 = null;

		// Token: 0x04000932 RID: 2354
		public static bool bool_0;

		// Token: 0x04000933 RID: 2355
		public int int_0;

		// Token: 0x04000934 RID: 2356
		public int int_1;

		// Token: 0x04000935 RID: 2357
		public int int_2;

		// Token: 0x04000936 RID: 2358
		public int int_3;

		// Token: 0x04000938 RID: 2360
		private int int_4 = -1;
	}
}
