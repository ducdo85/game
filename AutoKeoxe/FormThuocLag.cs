using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000086 RID: 134
	public partial class FormThuocLag : Form
	{
		// Token: 0x06000B17 RID: 2839 RVA: 0x00184CAE File Offset: 0x00182EAE
		public FormThuocLag()
		{
			FormThuocLag.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00184CE4 File Offset: 0x00182EE4
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			this.int_2 = 0;
			this.int_3 = 0;
			FormThuocLag.int_1 = -1;
			FormThuocLag.int_0 = 0;
			FormThuocLag.bool_0 = false;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00184D40 File Offset: 0x00182F40
		private void FormThuocLag_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_0);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				FormThuocLag.gstruct49_0 = Form1.gstruct49_0[num];
				bool flag2 = this.int_2 > 0 && this.int_3 > 0;
				if (flag2)
				{
					int num2 = this.int_2 - base.Width - 10;
					int num3 = this.int_3 - base.Height - 10;
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
					this.method_0(Form1.gstruct49_0[num].string_6);
				}
				else
				{
					this.buttonThem.Enabled = false;
					this.listView1.Enabled = false;
				}
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				FormThuocLag.bool_1 = true;
				base.TopMost = true;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00184E7C File Offset: 0x0018307C
		private void method_0(string[] string_1)
		{
			this.listView1.Items.Clear();
			bool flag = string_1 != null && string_1.Length != 0;
			if (flag)
			{
				for (int i = 0; i < string_1.Length; i++)
				{
					this.method_1(this.listView1, Class10.smethod_1(string_1[i], 1, false));
				}
			}
			this.int_6 = -1;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00184EE0 File Offset: 0x001830E0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormThuocLag.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormThuocLag.int_1 != FormThuocLag.int_0;
				if (flag2)
				{
					FormThuocLag.int_1 = FormThuocLag.int_0;
					int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_1);
					bool flag3 = num >= 0;
					if (flag3)
					{
						this.buttonThem.Enabled = true;
						this.listView1.Enabled = true;
						this.method_0(Form1.gstruct49_0[num].string_6);
					}
					else
					{
						this.buttonThem.Enabled = false;
						this.listView1.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00184F94 File Offset: 0x00183194
		private void method_1(ListView listView_0, string string_1)
		{
			try
			{
				string[] array = new string[]
				{
					string_1
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

		// Token: 0x06000B1D RID: 2845 RVA: 0x00185018 File Offset: 0x00183218
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
				bool flag2 = this.int_6 >= 0 && text != null && text != this.comboBoxTenTuiMauHotro.Text;
				if (flag2)
				{
					this.comboBoxTenTuiMauHotro.Items.Clear();
					this.comboBoxTenTuiMauHotro.Items.Add(text);
					this.comboBoxTenTuiMauHotro.Text = text;
				}
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0018511C File Offset: 0x0018331C
		private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
		{
			FormThuocLag.string_0 = Class79.smethod_34(FormThuocLag.gstruct49_0, null, 3);
			this.comboBoxTenTuiMauHotro.Items.Clear();
			bool flag = FormThuocLag.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormThuocLag.string_0.Length; i++)
				{
					this.comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(FormThuocLag.string_0[i], 1, false));
				}
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00185194 File Offset: 0x00183394
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormThuocLag.bool_1 || FormThuocLag.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = null;
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					for (int i = 0; i < FormThuocLag.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(FormThuocLag.string_0[i], 1, false);
						if (flag3)
						{
							text = FormThuocLag.string_0[i];
							break;
						}
					}
					bool flag4 = text == null;
					if (!flag4)
					{
						bool flag5 = Form1.gstruct49_0[num].string_6 != null;
						if (flag5)
						{
							for (int j = 0; j < Form1.gstruct49_0[num].string_6.Length; j++)
							{
								bool flag6 = Form1.gstruct49_0[num].string_6[j] == text;
								if (flag6)
								{
									return;
								}
							}
						}
						this.method_1(this.listView1, Class10.smethod_1(text, 1, false));
						Class12.smethod_29(ref Form1.gstruct49_0[num].string_6, text);
					}
				}
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x001852DC File Offset: 0x001834DC
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_1);
			bool flag = num < 0;
			if (!flag)
			{
				string text = this.comboBoxTenTuiMauHotro.Text;
				bool flag2 = Form1.gstruct49_0[num].string_6 != null;
				int i;
				if (flag2)
				{
					for (i = 0; i < Form1.gstruct49_0[num].string_6.Length; i++)
					{
						bool flag3 = Class10.smethod_1(Form1.gstruct49_0[num].string_6[i], 1, false) == text;
						if (flag3)
						{
							Class12.smethod_30(ref Form1.gstruct49_0[num].string_6, Form1.gstruct49_0[num].string_6[i], false);
							break;
						}
					}
				}
				i = 0;
				for (;;)
				{
					bool flag4 = i < this.listView1.Items.Count;
					if (!flag4)
					{
						goto IL_10F;
					}
					bool flag5 = text == this.listView1.Items[i].SubItems[0].Text;
					if (flag5)
					{
						break;
					}
					i++;
				}
				this.listView1.Items.RemoveAt(i);
				IL_10F:;
			}
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00185414 File Offset: 0x00183614
		private void buttonAppAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocLag.int_1);
			bool flag = num < 0 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Form1.gstruct49_0[i].int_63 = 1;
						bool flag2 = i == num;
						if (!flag2)
						{
							Form1.gstruct49_0[i].string_6 = null;
							bool flag3 = Form1.gstruct49_0[num].string_6 != null;
							if (flag3)
							{
								Form1.gstruct49_0[i].string_6 = new string[Form1.gstruct49_0[num].string_6.Length];
								for (int j = 0; j < Form1.gstruct49_0[num].string_6.Length; j++)
								{
									Form1.gstruct49_0[i].string_6[j] = Form1.gstruct49_0[num].string_6[j];
								}
							}
							Class53.smethod_13(Form1.gstruct49_0[i], null);
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00185558 File Offset: 0x00183758
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000C73 RID: 3187
		public static bool bool_0 = false;

		// Token: 0x04000C74 RID: 3188
		public static int int_0 = 0;

		// Token: 0x04000C75 RID: 3189
		public static int int_1 = -1;

		// Token: 0x04000C76 RID: 3190
		public int int_2;

		// Token: 0x04000C77 RID: 3191
		public int int_3;

		// Token: 0x04000C78 RID: 3192
		public int int_4;

		// Token: 0x04000C79 RID: 3193
		public int int_5;

		// Token: 0x04000C7A RID: 3194
		private int int_6 = -1;

		// Token: 0x04000C7B RID: 3195
		private static bool bool_1 = false;

		// Token: 0x04000C7C RID: 3196
		private static GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000C7D RID: 3197
		private static string[] string_0 = null;

		// Token: 0x04000C7E RID: 3198
		private IContainer icontainer_0 = null;
	}
}
