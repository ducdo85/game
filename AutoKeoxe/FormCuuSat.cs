using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006B RID: 107
	public partial class FormCuuSat : Form
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x0013E604 File Offset: 0x0013C804
		public FormCuuSat()
		{
			FormCuuSat.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0013E65C File Offset: 0x0013C85C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0013EDFC File Offset: 0x0013CFFC
		private void FormCuuSat_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.int_1 > 0 && this.int_2 > 0;
				if (flag)
				{
					int num = this.int_1 - base.Width - 2;
					int num2 = this.int_2 + this.int_4 - base.Height;
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
				int num3 = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
				bool flag4 = num3 >= 0;
				if (flag4)
				{
					FormCuuSat.gstruct49_0 = Form1.gstruct49_0[num3];
					this.checkBoxCuusatTheoDs.Checked = (FormCuuSat.gstruct49_0.int_120 > 0);
					this.listView1.Items.Clear();
					bool flag5 = FormCuuSat.gstruct49_0.string_18 != null;
					if (flag5)
					{
						for (int i = 0; i < FormCuuSat.gstruct49_0.string_18.Length; i++)
						{
							bool flag6 = FormCuuSat.gstruct49_0.string_18[i] != null && FormCuuSat.gstruct49_0.string_18[i] != string.Empty;
							if (flag6)
							{
								FormCuuSat.smethod_0(ref this.listView1, Class10.smethod_1(FormCuuSat.gstruct49_0.string_18[i], 1, false));
							}
						}
					}
					string str = Class10.smethod_1(FormCuuSat.gstruct49_0.string_22, 1, false);
					this.Text = "DS CUU SAT CUA [ " + str + " ]";
					this.groupBox1.Text = "Danh sách cừu sát của (" + str + ")";
					this.bool_1 = true;
					this.timer_0.Interval = 300;
					this.timer_0.Enabled = true;
					base.TopMost = true;
				}
				else
				{
					FormCuuSat.bool_0 = false;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0013EFFC File Offset: 0x0013D1FC
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
			catch
			{
			}
			FormCuuSat.bool_0 = false;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0013F058 File Offset: 0x0013D258
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormCuuSat.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0013F07C File Offset: 0x0013D27C
		public static void smethod_0(ref ListView listView_0, string string_1)
		{
			bool flag = string_1 != null;
			if (flag)
			{
				try
				{
					ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_1);
					listViewItem.SubItems.Add(item);
					listView_0.Items.Add(listViewItem);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0013F0EC File Offset: 0x0013D2EC
		private int method_0(ListView listView_0)
		{
			bool flag = listView_0.Items != null;
			if (flag)
			{
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					bool selected = listView_0.Items[i].Selected;
					if (selected)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0013F148 File Offset: 0x0013D348
		private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
			bool flag = num < 0;
			if (flag)
			{
				FormCuuSat.bool_0 = false;
			}
			else
			{
				this.bool_1 = false;
				FormCuuSat.gstruct49_0 = Form1.gstruct49_0[num];
				this.comboBoxThemAcc.Items.Clear();
				for (int i = 1; i < 256; i++)
				{
					string text = Class98.smethod_22(FormCuuSat.gstruct49_0, i, 1);
					bool flag2 = text == string.Empty;
					if (!flag2)
					{
						bool flag3 = true;
						bool flag4 = this.comboBoxThemAcc.Items.Count > 0;
						if (flag4)
						{
							for (int j = 0; j < this.comboBoxThemAcc.Items.Count; j++)
							{
								bool flag5 = this.comboBoxThemAcc.Items[j].ToString() == text;
								if (flag5)
								{
									flag3 = false;
									break;
								}
							}
						}
						bool flag6 = flag3;
						if (flag6)
						{
							this.comboBoxThemAcc.Items.Add(Class10.smethod_1(text, 1, false));
							Class12.smethod_29(ref this.string_0, text);
						}
					}
				}
				this.comboBoxThemAcc.Items.Add(string.Empty);
				this.bool_1 = true;
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x0013F2A0 File Offset: 0x0013D4A0
		private void buttonThemAcc_Click(object sender, EventArgs e)
		{
			bool flag = !this.bool_1 || this.string_0 == null || this.comboBoxThemAcc.Text == "" || Form1.gstruct49_0 == null || Form1.gstruct49_0.Length == 0;
			if (!flag)
			{
				bool flag2 = this.listView1.Items.Count <= 9;
				if (flag2)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						string text = this.comboBoxThemAcc.Text;
						bool flag4 = this.listView1.Items.Count > 0;
						if (flag4)
						{
							for (int i = 0; i < this.listView1.Items.Count; i++)
							{
								bool flag5 = text == this.listView1.Items[i].SubItems[1].Text;
								if (flag5)
								{
									this.comboBoxThemAcc.Items.Clear();
									this.comboBoxThemAcc.Text = "";
									return;
								}
							}
						}
						for (int j = 0; j < this.string_0.Length; j++)
						{
							bool flag6 = text == Class10.smethod_1(this.string_0[j], 1, false);
							if (flag6)
							{
								Class12.smethod_29(ref Form1.gstruct49_0[num].string_18, this.string_0[j]);
								FormCuuSat.smethod_0(ref this.listView1, text);
								this.comboBoxThemAcc.Items.Clear();
								this.comboBoxThemAcc.Text = "";
								break;
							}
						}
						bool flag7 = this.listView1.Items.Count > 3;
						if (flag7)
						{
							this.buttonThemAcc.Enabled = false;
							this.comboBoxThemAcc.Enabled = false;
						}
					}
					else
					{
						FormCuuSat.bool_0 = false;
					}
				}
				else
				{
					FormTip.smethod_0("DANH SACH CHO PHEP", "Nhằm để tránh CPU quá cao gây lag, diss... nên danh sách cừu sát sẽ bị hạn chế ở mức tối đa là 10 acc.||Danh sách đề nghị tốt nhất chỉ nên chứa 1 - 3 acc.", 12000, 280, 110, false, -1, -1, false, false, false);
				}
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0013F4CC File Offset: 0x0013D6CC
		private void buttonXoaAcc_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
			bool flag = num < 0;
			if (flag)
			{
				FormCuuSat.bool_0 = false;
			}
			else
			{
				int num2 = this.method_0(this.listView1);
				bool flag2 = num2 < 0 || num2 > this.listView1.Items.Count - 1;
				if (!flag2)
				{
					string text = this.listView1.Items[num2].SubItems[1].Text;
					bool flag3 = Form1.gstruct49_0[num].string_18 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].string_18.Length; i++)
						{
							bool flag4 = text == Class10.smethod_1(Form1.gstruct49_0[num].string_18[i], 1, false);
							if (flag4)
							{
								Class12.smethod_30(ref Form1.gstruct49_0[num].string_18, Form1.gstruct49_0[num].string_18[i], false);
								break;
							}
						}
					}
					this.listView1.Items.RemoveAt(num2);
					for (int j = 0; j < this.listView1.Items.Count; j++)
					{
						this.listView1.Items[j].SubItems[0].Text = (j + 1).ToString();
					}
					bool enabled = this.listView1.Items.Count < 4;
					this.buttonThemAcc.Enabled = enabled;
					this.comboBoxThemAcc.Enabled = enabled;
				}
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x0013F684 File Offset: 0x0013D884
		private void checkBoxCuusatTheoDs_CheckedChanged(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormCuuSat.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				Form1.gstruct49_0[num].int_120 = (int)Convert.ToByte(this.checkBoxCuusatTheoDs.Checked);
			}
			else
			{
				FormCuuSat.bool_0 = false;
			}
		}

		// Token: 0x04000854 RID: 2132
		private IContainer icontainer_0 = null;

		// Token: 0x0400085F RID: 2143
		public static bool bool_0;

		// Token: 0x04000860 RID: 2144
		public static int int_0;

		// Token: 0x04000861 RID: 2145
		public int int_1 = 0;

		// Token: 0x04000862 RID: 2146
		public int int_2 = 0;

		// Token: 0x04000863 RID: 2147
		public int int_3;

		// Token: 0x04000864 RID: 2148
		public int int_4;

		// Token: 0x04000865 RID: 2149
		private bool bool_1 = false;

		// Token: 0x04000866 RID: 2150
		private static GStruct49 gstruct49_0;

		// Token: 0x04000868 RID: 2152
		private string[] string_0 = null;
	}
}
