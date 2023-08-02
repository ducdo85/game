using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000071 RID: 113
	public partial class FormKhongCatdo : Form
	{
		// Token: 0x060008DF RID: 2271 RVA: 0x0014BE5F File Offset: 0x0014A05F
		public FormKhongCatdo()
		{
			FormKhongCatdo.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0014BE98 File Offset: 0x0014A098
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0014C4C5 File Offset: 0x0014A6C5
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.int_2 = 0;
			this.int_3 = 0;
			FormKhongCatdo.int_1 = -1;
			FormKhongCatdo.int_0 = 0;
			FormKhongCatdo.bool_0 = false;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0014C4E8 File Offset: 0x0014A6E8
		private void FormKhongCatdo_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormKhongCatdo.int_0);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				FormKhongCatdo.gstruct49_0 = Form1.gstruct49_0[num];
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
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				FormKhongCatdo.bool_1 = true;
				base.TopMost = true;
			}
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x0014C5C8 File Offset: 0x0014A7C8
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

		// Token: 0x060008E5 RID: 2277 RVA: 0x0014C62C File Offset: 0x0014A82C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormKhongCatdo.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormKhongCatdo.int_1 != FormKhongCatdo.int_0;
				if (flag2)
				{
					FormKhongCatdo.int_1 = FormKhongCatdo.int_0;
					int num = Class81.smethod_3(Form1.gstruct49_0, FormKhongCatdo.int_1);
					bool flag3 = num >= 0;
					if (flag3)
					{
						this.buttonThem.Enabled = true;
						this.listView1.Enabled = true;
						this.method_0(Form1.gstruct49_0[num].string_5);
					}
					else
					{
						this.buttonThem.Enabled = false;
						this.listView1.Enabled = false;
					}
				}
			}
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x0014C6E0 File Offset: 0x0014A8E0
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

		// Token: 0x060008E7 RID: 2279 RVA: 0x0014C764 File Offset: 0x0014A964
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

		// Token: 0x060008E8 RID: 2280 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x0014C868 File Offset: 0x0014AA68
		private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
		{
			FormKhongCatdo.string_0 = Class79.smethod_34(FormKhongCatdo.gstruct49_0, null, 3);
			this.comboBoxTenTuiMauHotro.Items.Clear();
			bool flag = FormKhongCatdo.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormKhongCatdo.string_0.Length; i++)
				{
					this.comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(FormKhongCatdo.string_0[i], 1, false));
				}
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0014C8E0 File Offset: 0x0014AAE0
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormKhongCatdo.bool_1 || FormKhongCatdo.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormKhongCatdo.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = null;
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					for (int i = 0; i < FormKhongCatdo.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(FormKhongCatdo.string_0[i], 1, false);
						if (flag3)
						{
							text = FormKhongCatdo.string_0[i];
							break;
						}
					}
					bool flag4 = text == null;
					if (!flag4)
					{
						bool flag5 = Form1.gstruct49_0[num].string_5 != null;
						if (flag5)
						{
							for (int j = 0; j < Form1.gstruct49_0[num].string_5.Length; j++)
							{
								bool flag6 = Form1.gstruct49_0[num].string_5[j] == text;
								if (flag6)
								{
									return;
								}
							}
						}
						this.method_1(this.listView1, Class10.smethod_1(text, 1, false));
						Class12.smethod_29(ref Form1.gstruct49_0[num].string_5, text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0014CA3C File Offset: 0x0014AC3C
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormKhongCatdo.int_1);
			bool flag = num < 0;
			if (!flag)
			{
				string text = this.comboBoxTenTuiMauHotro.Text;
				bool flag2 = Form1.gstruct49_0[num].string_5 != null;
				int i;
				if (flag2)
				{
					for (i = 0; i < Form1.gstruct49_0[num].string_5.Length; i++)
					{
						bool flag3 = Class10.smethod_1(Form1.gstruct49_0[num].string_5[i], 1, false) == text;
						if (flag3)
						{
							Class12.smethod_30(ref Form1.gstruct49_0[num].string_5, Form1.gstruct49_0[num].string_5[i], false);
							Class53.smethod_13(Form1.gstruct49_0[num], null);
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
						goto IL_127;
					}
					bool flag5 = text == this.listView1.Items[i].SubItems[0].Text;
					if (flag5)
					{
						break;
					}
					i++;
				}
				this.listView1.Items.RemoveAt(i);
				IL_127:;
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0014CB8C File Offset: 0x0014AD8C
		private void buttonAppAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormKhongCatdo.int_1);
			bool flag = num < 0 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag2 = i == num;
						if (!flag2)
						{
							Form1.gstruct49_0[i].string_5 = null;
							bool flag3 = Form1.gstruct49_0[num].string_5 != null;
							if (flag3)
							{
								Form1.gstruct49_0[i].string_5 = new string[Form1.gstruct49_0[num].string_5.Length];
								for (int j = 0; j < Form1.gstruct49_0[num].string_5.Length; j++)
								{
									Form1.gstruct49_0[i].string_5[j] = Form1.gstruct49_0[num].string_5[j];
								}
								Class53.smethod_13(Form1.gstruct49_0[i], null);
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000912 RID: 2322
		private IContainer icontainer_0 = null;

		// Token: 0x0400091B RID: 2331
		public static bool bool_0 = false;

		// Token: 0x0400091C RID: 2332
		public static int int_0 = 0;

		// Token: 0x0400091D RID: 2333
		public static int int_1 = -1;

		// Token: 0x0400091E RID: 2334
		public int int_2;

		// Token: 0x0400091F RID: 2335
		public int int_3;

		// Token: 0x04000920 RID: 2336
		public int int_4;

		// Token: 0x04000921 RID: 2337
		public int int_5;

		// Token: 0x04000922 RID: 2338
		private int int_6 = -1;

		// Token: 0x04000923 RID: 2339
		private static bool bool_1 = false;

		// Token: 0x04000924 RID: 2340
		private static GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000926 RID: 2342
		private static string[] string_0 = null;
	}
}
