using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007E RID: 126
	public partial class FormPT : Form
	{
		// Token: 0x06000A10 RID: 2576 RVA: 0x0016C6DA File Offset: 0x0016A8DA
		public FormPT()
		{
			FormPT.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x0016C718 File Offset: 0x0016A918
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x0016D1A0 File Offset: 0x0016B3A0
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPT.gstruct49_0.int_136);
			bool flag = 0 <= num;
			if (flag)
			{
				Form1.gstruct49_0[num].string_19 = FormPT.gstruct49_0.string_19;
				Form1.gstruct49_0[num].int_121 = FormPT.gstruct49_0.int_121;
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			FormPT.gstruct49_0.int_136 = 0;
			this.int_0 = 0;
			this.int_1 = 0;
			FormPT.bool_0 = false;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0016D238 File Offset: 0x0016B438
		private void FormPT_Load(object sender, EventArgs e)
		{
			this.bool_1 = false;
			bool flag = FormPT.gstruct49_0.int_136 == 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = this.int_0 > 0 && this.int_1 > 0;
				if (flag2)
				{
					int num = this.int_0 - base.Width - 10;
					int num2 = this.int_1 - base.Height - 10;
					bool flag3 = num < 0;
					if (flag3)
					{
						num = 0;
					}
					bool flag4 = num2 < 0;
					if (flag4)
					{
						num2 = 0;
					}
					base.SetBounds(num, num2, base.Width, base.Height);
				}
				bool flag5 = FormPT.gstruct49_0.string_19 != null && FormPT.gstruct49_0.string_19.Length != 0;
				if (flag5)
				{
					for (int i = 0; i < FormPT.gstruct49_0.string_19.Length; i++)
					{
						bool flag6 = FormPT.gstruct49_0.string_19[i] != null && FormPT.gstruct49_0.string_19[i] != string.Empty;
						if (flag6)
						{
							this.method_0(this.listView1, Class10.smethod_1(FormPT.gstruct49_0.string_19[i], 1, false));
						}
					}
				}
				bool flag7 = FormPT.gstruct49_0.int_121 == null || FormPT.gstruct49_0.int_121.Length < 5;
				if (flag7)
				{
					FormPT.gstruct49_0.int_121 = new int[]
					{
						0,
						0,
						0,
						0,
						5
					};
				}
				this.checkBoxLuonLamDoitruong.Checked = (FormPT.gstruct49_0.int_121[1] > 0);
				this.checkBoxTheoDSnhom.Checked = (FormPT.gstruct49_0.int_121[2] > 0);
				this.checkBoxPTtheoBHO.Checked = (FormPT.gstruct49_0.int_121[3] > 0);
				this.checkBoxPTtheoBHO.Enabled = (FormPT.gstruct49_0.int_121[1] > 0);
				this.checkBoxHienThiSonguoi.Checked = (FormPT.gstruct49_0.int_121[4] > 0);
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				base.TopMost = true;
				this.method_1("PT ( " + Class10.smethod_1(FormPT.gstruct49_0.string_22, 1, false) + " )");
				this.bool_1 = true;
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0016D480 File Offset: 0x0016B680
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormPT.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0016D4A4 File Offset: 0x0016B6A4
		private void method_0(ListView listView_0, string string_1)
		{
			try
			{
				ListViewItem value = new ListViewItem(string_1);
				listView_0.Items.Add(value);
			}
			catch
			{
			}
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0016D4E0 File Offset: 0x0016B6E0
		private void comboBoxAcc_DropDown(object sender, EventArgs e)
		{
			this.comboBoxAcc.Items.Clear();
			FormPT.string_0 = null;
			Class98.smethod_25(FormPT.gstruct49_0, ref FormPT.string_0, 1, FormPT.gstruct49_0.string_19);
			bool flag = FormPT.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormPT.string_0.Length; i++)
				{
					this.comboBoxAcc.Items.Add(Class10.smethod_1(FormPT.string_0[i], 1, false));
				}
			}
			this.comboBoxAcc.Text = string.Empty;
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0016D578 File Offset: 0x0016B778
		private void buttonThem_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxAcc.Text;
			this.comboBoxAcc.Items.Clear();
			bool flag = FormPT.string_0 == null || text == string.Empty;
			if (!flag)
			{
				string text2 = null;
				for (int i = 0; i < FormPT.string_0.Length; i++)
				{
					bool flag2 = FormPT.string_0[i] == text || Class10.smethod_1(FormPT.string_0[i], 1, false) == text;
					if (flag2)
					{
						text2 = FormPT.string_0[i];
						break;
					}
				}
				bool flag3 = text2 == null;
				if (!flag3)
				{
					bool flag4 = FormPT.gstruct49_0.string_19 != null && FormPT.gstruct49_0.string_19.Length != 0;
					if (flag4)
					{
						for (int j = 0; j < FormPT.gstruct49_0.string_19.Length; j++)
						{
							bool flag5 = FormPT.gstruct49_0.string_19[j] == text2;
							if (flag5)
							{
								return;
							}
						}
					}
					Class12.smethod_29(ref FormPT.gstruct49_0.string_19, text2);
					this.method_0(this.listView1, Class10.smethod_1(text2, 1, false));
				}
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0016D6AC File Offset: 0x0016B8AC
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxAcc.Text;
			this.comboBoxAcc.Items.Clear();
			bool flag = FormPT.gstruct49_0.string_19 == null || text == string.Empty;
			if (!flag)
			{
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool flag2 = text == this.listView1.Items[i].SubItems[0].Text;
					if (flag2)
					{
						this.listView1.Items.RemoveAt(i);
						break;
					}
				}
				bool flag3 = FormPT.gstruct49_0.string_19.Length != 1 || (!(FormPT.gstruct49_0.string_19[0] == text) && !(Class10.smethod_1(FormPT.gstruct49_0.string_19[0], 1, false) == text));
				if (flag3)
				{
					int num = 0;
					string[] array = new string[FormPT.gstruct49_0.string_19.Length];
					for (int j = 0; j < FormPT.gstruct49_0.string_19.Length; j++)
					{
						bool flag4 = !(FormPT.gstruct49_0.string_19[j] == text) && !(Class10.smethod_1(FormPT.gstruct49_0.string_19[j], 1, false) == text);
						if (flag4)
						{
							array[num] = FormPT.gstruct49_0.string_19[j];
							num++;
						}
					}
					bool flag5 = num == 0;
					if (flag5)
					{
						FormPT.gstruct49_0.string_19 = null;
						this.listView1.Items.Clear();
					}
					else
					{
						FormPT.gstruct49_0.string_19 = new string[num];
						for (int k = 0; k < num; k++)
						{
							FormPT.gstruct49_0.string_19[k] = array[k];
						}
					}
				}
				else
				{
					FormPT.gstruct49_0.string_19 = null;
					this.listView1.Items.Clear();
				}
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0016D8C4 File Offset: 0x0016BAC4
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

		// Token: 0x06000A1B RID: 2587 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0016D9B0 File Offset: 0x0016BBB0
		private void checkBoxLuonLamDoitruong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1;
			if (flag)
			{
				FormPT.gstruct49_0.int_121[1] = (int)Convert.ToByte(this.checkBoxLuonLamDoitruong.Checked);
				this.checkBoxPTtheoBHO.Enabled = (FormPT.gstruct49_0.int_121[1] > 0);
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0016DA04 File Offset: 0x0016BC04
		private void checkBoxTheoDSnhom_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1;
			if (flag)
			{
				FormPT.gstruct49_0.int_121[2] = (int)Convert.ToByte(this.checkBoxTheoDSnhom.Checked);
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0016DA38 File Offset: 0x0016BC38
		private void checkBoxPTtheoBHO_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1;
			if (flag)
			{
				FormPT.gstruct49_0.int_121[3] = (int)Convert.ToByte(this.checkBoxPTtheoBHO.Checked);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0016DA6C File Offset: 0x0016BC6C
		private void checkBoxHienThiSonguoi_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_1;
			if (flag)
			{
				FormPT.gstruct49_0.int_121[4] = (int)Convert.ToByte(this.checkBoxHienThiSonguoi.Checked);
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0016DAA0 File Offset: 0x0016BCA0
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null || Form1.gstruct49_0.Length == 0;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = Form1.gstruct49_0[i].int_136 == FormPT.gstruct49_0.int_136;
					if (!flag2)
					{
						Form1.gstruct49_0[i].string_19 = null;
						bool flag3 = FormPT.gstruct49_0.int_121 != null;
						if (flag3)
						{
							int num = 0;
							bool flag4 = Form1.gstruct49_0[i].int_121 == null;
							if (flag4)
							{
								Form1.gstruct49_0[i].int_121 = new int[FormPT.gstruct49_0.int_121.Length];
							}
							else
							{
								num = Form1.gstruct49_0[i].int_121[1];
							}
							for (int j = 0; j < FormPT.gstruct49_0.int_121.Length; j++)
							{
								Form1.gstruct49_0[i].int_121[j] = FormPT.gstruct49_0.int_121[j];
							}
							Form1.gstruct49_0[i].int_121[1] = num;
						}
						bool flag5 = FormPT.gstruct49_0.string_19 != null;
						if (flag5)
						{
							Form1.gstruct49_0[i].string_19 = new string[FormPT.gstruct49_0.string_19.Length];
							for (int k = 0; k < FormPT.gstruct49_0.string_19.Length; k++)
							{
								Form1.gstruct49_0[i].string_19[k] = FormPT.gstruct49_0.string_19[k];
							}
						}
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0016DC6C File Offset: 0x0016BE6C
		private void buttonAllAc_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null && Form1.gstruct49_0.Length != 0;
			if (flag)
			{
				this.listView1.Items.Clear();
				FormPT.gstruct49_0.string_19 = new string[Form1.gstruct49_0.Length];
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					FormPT.gstruct49_0.string_19[i] = Form1.gstruct49_0[i].string_22;
					this.method_0(this.listView1, Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
				}
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_1(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x04000ADE RID: 2782
		private IContainer icontainer_0 = null;

		// Token: 0x04000AED RID: 2797
		public static bool bool_0;

		// Token: 0x04000AEE RID: 2798
		public static GStruct49 gstruct49_0;

		// Token: 0x04000AEF RID: 2799
		private static string[] string_0;

		// Token: 0x04000AF0 RID: 2800
		public int int_0;

		// Token: 0x04000AF1 RID: 2801
		public int int_1;

		// Token: 0x04000AF2 RID: 2802
		public int int_2;

		// Token: 0x04000AF3 RID: 2803
		public int int_3;

		// Token: 0x04000AF4 RID: 2804
		private int int_4 = -1;

		// Token: 0x04000AF6 RID: 2806
		private bool bool_1 = false;
	}
}
