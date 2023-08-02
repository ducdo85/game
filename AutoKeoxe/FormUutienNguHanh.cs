using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008D RID: 141
	public partial class FormUutienNguHanh : Form
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x00190A84 File Offset: 0x0018EC84
		public FormUutienNguHanh()
		{
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00190D18 File Offset: 0x0018EF18
		private void FormUutienNguHanh_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				FormUutienNguHanh.int_3 = FormUutienNguHanh.int_0;
				FormUutienNguHanh.gstruct49_0 = Form1.gstruct49_0[num];
				bool flag2 = this.int_1 >= 0 && this.int_2 >= 0;
				if (flag2)
				{
					int num2 = this.int_1 - base.Width;
					int num3 = this.int_2;
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
				for (int i = 0; i < FormUutienNguHanh.gstruct49_0.int_90.Length; i++)
				{
					this.method_1(this.listView1, this.struct17_0[FormUutienNguHanh.gstruct49_0.int_90[i]].string_0);
				}
				for (int j = 0; j < FormUutienNguHanh.gstruct49_0.int_91.Length; j++)
				{
					this.method_1(this.listView2, this.struct17_1[FormUutienNguHanh.gstruct49_0.int_91[j] - 1].string_0);
				}
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				this.method_2(Class10.smethod_1(FormUutienNguHanh.gstruct49_0.string_22, 1, false) + " ( hệ " + this.struct17_0[Class36.smethod_29(FormUutienNguHanh.gstruct49_0)].string_0 + ")");
				base.TopMost = true;
			}
			else
			{
				FormUutienNguHanh.int_0 = 0;
				base.Close();
			}
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00190ED8 File Offset: 0x0018F0D8
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormUutienNguHanh.int_0 = 0;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00190EE4 File Offset: 0x0018F0E4
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormUutienNguHanh.int_0 == 0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00190F08 File Offset: 0x0018F108
		private void buttonLen1_Click(object sender, EventArgs e)
		{
			int num = this.method_0(this.listView1);
			bool flag = num > 0;
			if (flag)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
				bool flag2 = num2 < 0;
				if (flag2)
				{
					FormUutienNguHanh.int_0 = 0;
					base.Close();
				}
				else
				{
					int num3 = Form1.gstruct49_0[num2].int_90[num];
					Form1.gstruct49_0[num2].int_90[num] = Form1.gstruct49_0[num2].int_90[num - 1];
					Form1.gstruct49_0[num2].int_90[num - 1] = num3;
					Class53.smethod_13(Form1.gstruct49_0[num2], null);
					string text = this.listView1.Items[num].SubItems[1].Text;
					this.listView1.Items[num].SubItems[1].Text = this.listView1.Items[num - 1].SubItems[1].Text;
					this.listView1.Items[num - 1].SubItems[1].Text = text;
					this.listView1.Items[num - 1].Selected = true;
					this.listView1.Items[num - 1].Focused = true;
				}
			}
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00191080 File Offset: 0x0018F280
		private void buttonXuong1_Click(object sender, EventArgs e)
		{
			int num = this.method_0(this.listView1);
			bool flag = num >= 0 && num < this.listView1.Items.Count - 1;
			if (flag)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					int num3 = Form1.gstruct49_0[num2].int_90[num];
					Form1.gstruct49_0[num2].int_90[num] = Form1.gstruct49_0[num2].int_90[num + 1];
					Form1.gstruct49_0[num2].int_90[num + 1] = num3;
					Class53.smethod_13(Form1.gstruct49_0[num2], null);
					string text = this.listView1.Items[num].SubItems[1].Text;
					this.listView1.Items[num].SubItems[1].Text = this.listView1.Items[num + 1].SubItems[1].Text;
					this.listView1.Items[num + 1].SubItems[1].Text = text;
					this.listView1.Items[num + 1].Selected = true;
					this.listView1.Items[num + 1].Focused = true;
				}
				else
				{
					FormUutienNguHanh.int_0 = 0;
					base.Close();
				}
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00191218 File Offset: 0x0018F418
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

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00191274 File Offset: 0x0018F474
		private void method_1(ListView listView_0, string string_1)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, string_1));
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x001912D8 File Offset: 0x0018F4D8
		private void buttonUuTienMacdinh_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
			bool flag = num < 0;
			if (flag)
			{
				FormUutienNguHanh.int_0 = 0;
				base.Close();
			}
			else
			{
				int int_ = Class36.smethod_29(Form1.gstruct49_0[num]);
				Form1.gstruct49_0[num].int_90 = Class53.smethod_14(int_);
				Class53.smethod_13(Form1.gstruct49_0[num], null);
				GStruct49 gstruct = Form1.gstruct49_0[num];
				this.listView1.Items.Clear();
				for (int i = 0; i < gstruct.int_90.Length; i++)
				{
					this.method_1(this.listView1, this.struct17_0[gstruct.int_90[i]].string_0);
				}
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x001913AC File Offset: 0x0018F5AC
		private void buttonLenMP_Click(object sender, EventArgs e)
		{
			int num = this.method_0(this.listView2);
			bool flag = num > 0;
			if (flag)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					int num3 = Form1.gstruct49_0[num2].int_91[num];
					Form1.gstruct49_0[num2].int_91[num] = Form1.gstruct49_0[num2].int_91[num - 1];
					Form1.gstruct49_0[num2].int_91[num - 1] = num3;
					Class53.smethod_13(Form1.gstruct49_0[num2], null);
					string text = this.listView2.Items[num].SubItems[1].Text;
					this.listView2.Items[num].SubItems[1].Text = this.listView2.Items[num - 1].SubItems[1].Text;
					this.listView2.Items[num - 1].SubItems[1].Text = text;
					this.listView2.Items[num - 1].Selected = true;
					this.listView2.Items[num - 1].Focused = true;
				}
				else
				{
					FormUutienNguHanh.int_0 = 0;
					base.Close();
				}
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0019152C File Offset: 0x0018F72C
		private void buttonXuongMP_Click(object sender, EventArgs e)
		{
			int num = this.method_0(this.listView2);
			bool flag = num >= 0 && num < this.listView2.Items.Count - 1;
			if (flag)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					int num3 = Form1.gstruct49_0[num2].int_91[num];
					Form1.gstruct49_0[num2].int_91[num] = Form1.gstruct49_0[num2].int_91[num + 1];
					Form1.gstruct49_0[num2].int_91[num + 1] = num3;
					Class53.smethod_13(Form1.gstruct49_0[num2], null);
					string text = this.listView2.Items[num].SubItems[1].Text;
					this.listView2.Items[num].SubItems[1].Text = this.listView2.Items[num + 1].SubItems[1].Text;
					this.listView2.Items[num + 1].SubItems[1].Text = text;
					this.listView2.Items[num + 1].Selected = true;
					this.listView2.Items[num + 1].Focused = true;
				}
				else
				{
					FormUutienNguHanh.int_0 = 0;
					base.Close();
				}
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x001916C4 File Offset: 0x0018F8C4
		private void buttonMacdinhMP_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormUutienNguHanh.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				this.listView2.Items.Clear();
				Form1.gstruct49_0[num].int_91 = new int[Class77.gstruct55_0.Length];
				for (int i = 0; i < Class77.gstruct55_0.Length; i++)
				{
					Form1.gstruct49_0[num].int_91[i] = Class77.gstruct55_0[i].int_0;
					this.method_1(this.listView2, this.struct17_1[Form1.gstruct49_0[num].int_91[i] - 1].string_0);
				}
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			else
			{
				FormUutienNguHanh.int_0 = 0;
				base.Close();
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x001917B0 File Offset: 0x0018F9B0
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_2(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x04000D4D RID: 3405
		public static int int_0;

		// Token: 0x04000D4E RID: 3406
		public static string string_0;

		// Token: 0x04000D4F RID: 3407
		public int int_1;

		// Token: 0x04000D50 RID: 3408
		public int int_2;

		// Token: 0x04000D51 RID: 3409
		private static int int_3;

		// Token: 0x04000D52 RID: 3410
		private static GStruct49 gstruct49_0;

		// Token: 0x04000D53 RID: 3411
		private FormUutienNguHanh.Struct17[] struct17_0 = new FormUutienNguHanh.Struct17[]
		{
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 0,
				string_0 = "Kim"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 1,
				string_0 = "Mộc"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 2,
				string_0 = "Thủy"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 3,
				string_0 = "Hỏa"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 4,
				string_0 = "Thổ"
			}
		};

		// Token: 0x04000D54 RID: 3412
		private FormUutienNguHanh.Struct17[] struct17_1 = new FormUutienNguHanh.Struct17[]
		{
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 1,
				string_0 = "Thiếu Lâm"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 2,
				string_0 = "Võ Đang"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 3,
				string_0 = "Nga My"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 4,
				string_0 = "Côn Lôn"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 5,
				string_0 = "Đường Môn"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 6,
				string_0 = "Thúy Yên"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 7,
				string_0 = "Cái Bang"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 8,
				string_0 = "Thiên Vương"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 9,
				string_0 = "Ngũ Độc"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 10,
				string_0 = "Thiên Nhẫn"
			},
			new FormUutienNguHanh.Struct17
			{
				byte_0 = 11,
				string_0 = "Hoa Sơn"
			}
		};

		// Token: 0x04000D55 RID: 3413
		private IContainer icontainer_0 = null;

		// Token: 0x02000100 RID: 256
		private struct Struct17
		{
			// Token: 0x04001273 RID: 4723
			public string string_0;

			// Token: 0x04001274 RID: 4724
			public byte byte_0;
		}
	}
}
