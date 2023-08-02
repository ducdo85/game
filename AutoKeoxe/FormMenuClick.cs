using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000079 RID: 121
	public partial class FormMenuClick : Form
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x0016489D File Offset: 0x00162A9D
		public FormMenuClick()
		{
			FormMenuClick.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x001648DC File Offset: 0x00162ADC
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0016527A File Offset: 0x0016347A
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormMenuClick.bool_0 = false;
			FormMenuClick.bool_1 = false;
			FormMenuClick.string_0 = null;
			FormMenuClick.int_2 = null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00165298 File Offset: 0x00163498
		public static int[] smethod_0(string string_1 = null)
		{
			int[] array = null;
			string text = string.Empty;
			bool flag = FormMenuClick.int_2 != null;
			if (flag)
			{
				array = new int[FormMenuClick.int_2.Length];
				for (int i = 0; i < FormMenuClick.int_2.Length; i++)
				{
					array[i] = FormMenuClick.int_2[i];
					bool flag2 = text != null && text != string.Empty;
					if (flag2)
					{
						text += ",";
					}
					text += FormMenuClick.int_2[i].ToString();
				}
			}
			bool flag3 = string_1 != null && string_1 != string.Empty;
			if (flag3)
			{
				Class62.smethod_10(Class53.string_3, string_1, text, "", 0);
			}
			return array;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00165358 File Offset: 0x00163558
		private void FormMenuClick_Load(object sender, EventArgs e)
		{
			bool flag = 0 <= this.int_0 && 0 <= this.int_1;
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
			bool flag4 = FormMenuClick.int_2 != null;
			if (flag4)
			{
				for (int i = 0; i < FormMenuClick.int_2.Length; i++)
				{
					FormMenuClick.smethod_1(this.listView1, FormMenuClick.int_2[i]);
				}
				this.textBoxDiengiai.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
			}
			for (int j = 1; j < 30; j++)
			{
				this.comboBoxDong.Items.Add(j);
			}
			this.comboBoxDong.Text = "1";
			base.TopMost = true;
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00165494 File Offset: 0x00163694
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormMenuClick.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x001654B8 File Offset: 0x001636B8
		public static void smethod_1(ListView listView_0, int int_3)
		{
			try
			{
				ListViewItem value = new ListViewItem(int_3.ToString());
				listView_0.Items.Add(value);
			}
			catch
			{
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x001654FC File Offset: 0x001636FC
		private void buttonThem_Click(object sender, EventArgs e)
		{
			int num = Class12.smethod_11(this.comboBoxDong.Text);
			bool flag = FormMenuClick.int_2 != null;
			if (flag)
			{
				bool flag2 = FormMenuClick.int_2.Length == 0;
				if (!flag2)
				{
					Array.Resize<int>(ref FormMenuClick.int_2, FormMenuClick.int_2.Length + 1);
					FormMenuClick.int_2[FormMenuClick.int_2.Length - 1] = num;
					goto IL_6E;
				}
			}
			FormMenuClick.int_2 = new int[]
			{
				num
			};
			IL_6E:
			FormMenuClick.smethod_1(this.listView1, num);
			this.textBoxDiengiai.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
			FormMenuClick.bool_1 = true;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x001655A4 File Offset: 0x001637A4
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = FormMenuClick.int_2 != null && FormMenuClick.int_2.Length != 0;
			if (flag)
			{
				int num = -1;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						num = i;
						break;
					}
				}
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = 0;
					int[] array = new int[FormMenuClick.int_2.Length];
					for (int j = 0; j < FormMenuClick.int_2.Length; j++)
					{
						bool flag3 = j != num;
						if (flag3)
						{
							array[num2] = FormMenuClick.int_2[j];
							num2++;
						}
					}
					bool flag4 = num2 == 0;
					if (flag4)
					{
						this.listView1.Items.Clear();
						FormMenuClick.int_2 = null;
					}
					else
					{
						this.listView1.Items.RemoveAt(num);
						FormMenuClick.int_2 = new int[num2];
						for (int k = 0; k < num2; k++)
						{
							FormMenuClick.int_2[k] = array[k];
						}
					}
					this.textBoxDiengiai.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
					FormMenuClick.bool_1 = true;
				}
			}
			else
			{
				this.listView1.Items.Clear();
				FormMenuClick.int_2 = null;
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00165716 File Offset: 0x00163916
		private void buttonXoahet_Click(object sender, EventArgs e)
		{
			FormMenuClick.int_2 = null;
			this.listView1.Items.Clear();
			this.textBoxDiengiai.Text = string.Empty;
			FormMenuClick.bool_1 = true;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00165748 File Offset: 0x00163948
		private void buttonSua_Click(object sender, EventArgs e)
		{
			bool flag = FormMenuClick.int_2 == null || FormMenuClick.int_2.Length == 0;
			if (!flag)
			{
				int num = Class12.smethod_11(this.comboBoxDong.Text);
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						FormMenuClick.int_2[i] = num;
						this.listView1.Items[i].SubItems[0].Text = num.ToString();
						break;
					}
				}
				this.textBoxDiengiai.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
				FormMenuClick.bool_1 = true;
			}
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00165812 File Offset: 0x00163A12
		private void buttonDong_Click(object sender, EventArgs e)
		{
			FormMenuClick.bool_0 = false;
			base.Close();
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00165824 File Offset: 0x00163A24
		private void buttonVidu_Click(object sender, EventArgs e)
		{
			FormMenuClick.int_2 = new int[]
			{
				3,
				11,
				4,
				1
			};
			this.listView1.Items.Clear();
			for (int i = 0; i < FormMenuClick.int_2.Length; i++)
			{
				FormMenuClick.smethod_1(this.listView1, FormMenuClick.int_2[i]);
			}
			this.textBoxDiengiai.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
		}

		// Token: 0x04000A61 RID: 2657
		private IContainer icontainer_0 = null;

		// Token: 0x04000A70 RID: 2672
		public static bool bool_0;

		// Token: 0x04000A71 RID: 2673
		public static bool bool_1;

		// Token: 0x04000A72 RID: 2674
		public static string string_0;

		// Token: 0x04000A73 RID: 2675
		public int int_0 = 0;

		// Token: 0x04000A74 RID: 2676
		public int int_1 = 0;

		// Token: 0x04000A76 RID: 2678
		public static int[] int_2;
	}
}
