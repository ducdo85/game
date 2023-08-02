using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000087 RID: 135
	public partial class FormThuocTocdoDanh : Form
	{
		// Token: 0x06000B26 RID: 2854 RVA: 0x00185BB2 File Offset: 0x00183DB2
		public FormThuocTocdoDanh()
		{
			FormThuocTocdoDanh.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00185BE4 File Offset: 0x00183DE4
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			this.int_2 = 0;
			this.int_3 = 0;
			FormThuocTocdoDanh.int_1 = -1;
			FormThuocTocdoDanh.int_0 = 0;
			FormThuocTocdoDanh.bool_0 = false;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00185C40 File Offset: 0x00183E40
		private void FormThuocTocdoDanh_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_0);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				FormThuocTocdoDanh.gstruct49_0 = Form1.gstruct49_0[num];
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
				bool flag5 = num < 0;
				if (flag5)
				{
					this.buttonThem.Enabled = false;
					this.listView1.Enabled = false;
				}
				else
				{
					this.buttonThem.Enabled = true;
					this.listView1.Enabled = true;
					this.method_0(Form1.gstruct49_0[num].string_8, Form1.gstruct49_0[num].string_7);
				}
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				FormThuocTocdoDanh.bool_1 = true;
				base.TopMost = true;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00185D88 File Offset: 0x00183F88
		private void method_0(string[] string_1, string[] string_2)
		{
			this.listView1.Items.Clear();
			this.listViewThuong.Items.Clear();
			bool flag = string_2 != null;
			if (flag)
			{
				bool flag2 = string_2.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < string_2.Length; i++)
					{
						this.method_1(this.listView1, Class10.smethod_1(string_2[i], 1, false));
					}
				}
			}
			bool flag3 = string_1 != null;
			if (flag3)
			{
				bool flag4 = string_1.Length != 0;
				if (flag4)
				{
					for (int j = 0; j < string_1.Length; j++)
					{
						this.method_1(this.listViewThuong, Class10.smethod_1(string_1[j], 1, false));
					}
				}
			}
			IL_40:
			this.textBoxGiay.Text = FormThuocTocdoDanh.gstruct49_0.int_64[2].ToString();
			return;
			goto IL_40;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00185E8C File Offset: 0x0018408C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormThuocTocdoDanh.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormThuocTocdoDanh.int_1 != FormThuocTocdoDanh.int_0;
				if (flag2)
				{
					FormThuocTocdoDanh.int_1 = FormThuocTocdoDanh.int_0;
					int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
					bool flag3 = num < 0;
					if (flag3)
					{
						this.buttonThem.Enabled = false;
						this.listView1.Enabled = false;
					}
					else
					{
						this.buttonThem.Enabled = true;
						this.listView1.Enabled = true;
						this.method_0(Form1.gstruct49_0[num].string_8, Form1.gstruct49_0[num].string_7);
					}
				}
			}
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00185F50 File Offset: 0x00184150
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

		// Token: 0x06000B2C RID: 2860 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00185FD4 File Offset: 0x001841D4
		private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
		{
			FormThuocTocdoDanh.string_0 = Class79.smethod_34(FormThuocTocdoDanh.gstruct49_0, null, 3);
			this.comboBoxTenTuiMauHotro.Items.Clear();
			bool flag = FormThuocTocdoDanh.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormThuocTocdoDanh.string_0.Length; i++)
				{
					this.comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(FormThuocTocdoDanh.string_0[i], 1, false));
				}
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0018604C File Offset: 0x0018424C
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormThuocTocdoDanh.bool_1 || FormThuocTocdoDanh.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = null;
					string text2 = this.comboBoxTenTuiMauHotro.Text;
					for (int i = 0; i < FormThuocTocdoDanh.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(FormThuocTocdoDanh.string_0[i], 1, false);
						if (flag3)
						{
							text = FormThuocTocdoDanh.string_0[i];
							break;
						}
					}
					bool flag4 = text == null;
					if (!flag4)
					{
						bool flag5 = Form1.gstruct49_0[num].string_7 != null;
						if (flag5)
						{
							for (int j = 0; j < Form1.gstruct49_0[num].string_7.Length; j++)
							{
								bool flag6 = Form1.gstruct49_0[num].string_7[j] == text;
								if (flag6)
								{
									return;
								}
							}
						}
						this.method_1(this.listView1, Class10.smethod_1(text, 1, false));
						Class12.smethod_29(ref Form1.gstruct49_0[num].string_7, text);
					}
				}
			}
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00186194 File Offset: 0x00184394
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count == 0;
			if (!flag)
			{
				int index = this.listView1.SelectedIndices[0];
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.listView1.Items[index].SubItems[0].Text;
					bool flag3 = Form1.gstruct49_0[num].string_7 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].string_7.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].string_7[i], 1, false) == text;
							if (flag4)
							{
								Class12.smethod_30(ref Form1.gstruct49_0[num].string_7, Form1.gstruct49_0[num].string_7[i], false);
								break;
							}
						}
					}
					this.listView1.Items.RemoveAt(index);
				}
			}
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x001862BC File Offset: 0x001844BC
		private void buttonAppAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
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
							bool flag3 = Form1.gstruct49_0[num].string_7 != null && Form1.gstruct49_0[num].string_7.Length != 0;
							if (flag3)
							{
								Form1.gstruct49_0[i].string_7 = new string[Form1.gstruct49_0[num].string_7.Length];
								for (int j = 0; j < Form1.gstruct49_0[num].string_7.Length; j++)
								{
									Form1.gstruct49_0[i].string_7[j] = Form1.gstruct49_0[num].string_7[j];
								}
							}
							else
							{
								Form1.gstruct49_0[i].string_7 = null;
							}
							bool flag4 = Form1.gstruct49_0[num].string_8 == null || Form1.gstruct49_0[num].string_8.Length == 0;
							if (flag4)
							{
								Form1.gstruct49_0[i].string_8 = null;
							}
							else
							{
								Form1.gstruct49_0[i].string_8 = new string[Form1.gstruct49_0[num].string_8.Length];
								for (int k = 0; k < Form1.gstruct49_0[num].string_8.Length; k++)
								{
									Form1.gstruct49_0[i].string_8[k] = Form1.gstruct49_0[num].string_8[k];
								}
							}
							bool flag5 = Form1.gstruct49_0[num].int_64 != null;
							if (flag5)
							{
								bool flag6 = Form1.gstruct49_0[i].int_64 == null;
								if (flag6)
								{
									Form1.gstruct49_0[i].int_64 = new int[Form1.gstruct49_0[num].int_64.Length];
								}
								for (int l = 0; l < Form1.gstruct49_0[num].int_64.Length; l++)
								{
									bool flag7 = l != 1;
									if (flag7)
									{
										Form1.gstruct49_0[i].int_64[l] = Form1.gstruct49_0[num].int_64[l];
									}
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

		// Token: 0x06000B31 RID: 2865 RVA: 0x00186588 File Offset: 0x00184788
		private void textBoxGiay_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormThuocTocdoDanh.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxGiay.Text);
					bool flag3 = num2 < 3;
					if (flag3)
					{
						num2 = 3;
					}
					Form1.gstruct49_0[num].int_64[2] = num2;
				}
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00186604 File Offset: 0x00184804
		private void comboBoxThuong_MouseDown(object sender, MouseEventArgs e)
		{
			FormThuocTocdoDanh.string_0 = Class79.smethod_34(FormThuocTocdoDanh.gstruct49_0, null, 3);
			this.comboBoxThuong.Items.Clear();
			bool flag = FormThuocTocdoDanh.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormThuocTocdoDanh.string_0.Length; i++)
				{
					this.comboBoxThuong.Items.Add(Class10.smethod_1(FormThuocTocdoDanh.string_0[i], 1, false));
				}
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0018667C File Offset: 0x0018487C
		private void buttonThuong_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormThuocTocdoDanh.bool_1 || FormThuocTocdoDanh.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = null;
					string text2 = this.comboBoxThuong.Text;
					for (int i = 0; i < FormThuocTocdoDanh.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(FormThuocTocdoDanh.string_0[i], 1, false);
						if (flag3)
						{
							text = FormThuocTocdoDanh.string_0[i];
							break;
						}
					}
					bool flag4 = text == null;
					if (!flag4)
					{
						bool flag5 = Form1.gstruct49_0[num].string_8 != null;
						if (flag5)
						{
							for (int j = 0; j < Form1.gstruct49_0[num].string_8.Length; j++)
							{
								bool flag6 = Form1.gstruct49_0[num].string_8[j] == text;
								if (flag6)
								{
									return;
								}
							}
						}
						this.method_1(this.listViewThuong, Class10.smethod_1(text, 1, false));
						Class12.smethod_29(ref Form1.gstruct49_0[num].string_8, text);
					}
				}
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x001867C4 File Offset: 0x001849C4
		private void buttonXoaThuong_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewThuong.SelectedIndices.Count == 0;
			if (!flag)
			{
				int index = this.listViewThuong.SelectedIndices[0];
				int num = Class81.smethod_3(Form1.gstruct49_0, FormThuocTocdoDanh.int_1);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.listViewThuong.Items[index].SubItems[0].Text;
					bool flag3 = Form1.gstruct49_0[num].string_8 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct49_0[num].string_8.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.gstruct49_0[num].string_8[i], 1, false) == text;
							if (flag4)
							{
								Class12.smethod_30(ref Form1.gstruct49_0[num].string_8, Form1.gstruct49_0[num].string_8[i], false);
								break;
							}
						}
					}
					this.listViewThuong.Items.RemoveAt(index);
				}
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x001868EC File Offset: 0x00184AEC
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000C88 RID: 3208
		public static bool bool_0 = false;

		// Token: 0x04000C89 RID: 3209
		public static int int_0 = 0;

		// Token: 0x04000C8A RID: 3210
		public static int int_1 = -1;

		// Token: 0x04000C8B RID: 3211
		public int int_2;

		// Token: 0x04000C8C RID: 3212
		public int int_3;

		// Token: 0x04000C8D RID: 3213
		public int int_4;

		// Token: 0x04000C8E RID: 3214
		public int int_5;

		// Token: 0x04000C8F RID: 3215
		private static bool bool_1 = false;

		// Token: 0x04000C90 RID: 3216
		private static GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000C91 RID: 3217
		private static string[] string_0 = null;

		// Token: 0x04000C92 RID: 3218
		private IContainer icontainer_0 = null;
	}
}
