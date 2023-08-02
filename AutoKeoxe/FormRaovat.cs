using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000080 RID: 128
	public partial class FormRaovat : Form
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x0016EA78 File Offset: 0x0016CC78
		public FormRaovat()
		{
			FormRaovat.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0016EAB0 File Offset: 0x0016CCB0
		public static void smethod_0()
		{
			int int_ = FormRaovat.int_1;
			FormRaovat.int_1 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || Form1.gstruct49_0[num].int_69[0] <= 0;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_48 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_48;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_48 = true;
						flag = true;
					}
					FormRaovat.smethod_1(int_);
				}
				catch
				{
				}
				Thread.Sleep(600);
			}
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0016EB94 File Offset: 0x0016CD94
		private static void smethod_1(int int_2)
		{
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[4];
			GStruct49 gstruct = default(GStruct49);
			int[] array2 = new int[FormRaovat.string_2.GetLength(0)];
			array2[0] = 80;
			array2[1] = 20;
			array2[2] = 10;
			long long_ = 0L;
			string text = null;
			uint uint_ = 38U;
			uint uint_2 = 13U;
			for (;;)
			{
				Thread.Sleep(800);
				num--;
				bool flag = num <= 0;
				if (flag)
				{
					int num3 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag2 = Class12.bool_0 || num3 < 0 || Form1.gstruct49_0[num3].int_69[0] <= 0;
					if (flag2)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num3];
					text = null;
					num = 3;
				}
				bool flag3 = gstruct.string_10 == null || gstruct.string_10 == string.Empty;
				if (!flag3)
				{
					long num4 = Class12.smethod_28(long_);
					bool flag4 = num4 < 1200L || num4 < (long)gstruct.int_69[2];
					if (!flag4)
					{
						bool flag5 = gstruct.int_69[4] > 0;
						if (flag5)
						{
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num2);
							uint num5 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num5 + Class53.gstruct51_13.uint_0, array, 4, ref num2);
							uint num6 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num2);
							uint num7 = BitConverter.ToUInt32(array, 0);
							uint num8 = num7 + num6;
							Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_46.uint_0, array, 4, ref num2);
							int num9 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_48.uint_0, array, 4, ref num2);
							int num10 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_48.uint_0 + 4U, array, 4, ref num2);
							int num11 = BitConverter.ToInt32(array, 0);
							bool flag6 = num11 > num10 && num11 < 5000000;
							if (flag6)
							{
								num10 = num11;
							}
							int num12 = array2[gstruct.int_69[1]] * num10;
							bool flag7 = num9 * 100 < num12 && Class32.smethod_6(gstruct, 1, 1, false) > 0;
							if (flag7)
							{
								int i = 0;
								int num13 = num9;
								while (i < 7)
								{
									bool flag8 = Class12.bool_0;
									if (flag8)
									{
										break;
									}
									Thread.Sleep(800);
									Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_46.uint_0, array, 4, ref num2);
									num9 = BitConverter.ToInt32(array, 0);
									bool flag9 = num12 <= num9 * 100 || num9 <= num13;
									if (flag9)
									{
										break;
									}
									num13 = num9;
									i++;
								}
							}
						}
						bool flag10 = gstruct.int_69[3] <= 0;
						if (flag10)
						{
							bool flag11 = text == null || text == string.Empty;
							if (flag11)
							{
								text = gstruct.string_10.Replace("\n", string.Empty);
							}
							Class70.smethod_57(gstruct, string.Concat(new string[]
							{
								"Chat('",
								FormRaovat.string_2[gstruct.int_69[1], 1],
								"', '",
								text,
								"')"
							}));
						}
						else
						{
							Class70.smethod_57(gstruct, "Focus([[commandline]])");
							Thread.Sleep(300);
							Class22.smethod_4(gstruct.uint_4, uint_);
							Thread.Sleep(100);
							Class22.smethod_4(gstruct.uint_4, uint_2);
						}
						long_ = Class12.smethod_27();
					}
				}
			}
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0016EF5C File Offset: 0x0016D15C
		private void FormRaovat_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < FormRaovat.string_2.GetLength(0); i++)
			{
				this.comboBoxRaoVat.Items.Add(FormRaovat.string_2[i, 0]);
			}
			int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = gstruct.string_10 == "null";
				if (flag2)
				{
					string string_ = Class12.smethod_53(FormRaovat.string_3);
					Form1.gstruct49_0[num].string_10 = string_;
					gstruct.string_10 = string_;
				}
				this.textBoxTextRaoVat.Text = gstruct.string_10;
				this.checkBoxRaoVat.Checked = (gstruct.int_69[0] > 0);
				this.comboBoxRaoVat.Text = FormRaovat.string_2[gstruct.int_69[1], 0];
				this.textBoxTimeRaoVat.Text = gstruct.int_69[2].ToString();
				this.checkBoxRaoHinhanh.Checked = (gstruct.int_69[3] > 0);
				this.checkBoxBomNoiluc.Checked = (gstruct.int_69[4] > 0);
				this.textBoxTextRaoVat.Enabled = (gstruct.int_69[3] <= 0);
				this.comboBoxRaoVat.Enabled = (gstruct.int_69[3] <= 0);
				this.groupBoxRaovat.Text = Class10.smethod_1(gstruct.string_22, 1, false);
				this.checkBoxAceptBH.Checked = gstruct.bool_17;
			}
			else
			{
				this.groupBoxRaovat.Enabled = false;
				this.checkBoxAceptBH.Enabled = false;
				this.textBoxTextRaoVat.Text = "Hãy chọn 1 ac trước rồi bấm nút Rao vặt để vào đây thiết lập";
			}
			FormRaovat.string_0 = Class7.smethod_0(FormRaovat.string_1);
			bool flag3 = FormRaovat.string_0 != null;
			if (flag3)
			{
				for (int j = 0; j < FormRaovat.string_0.Length; j++)
				{
					bool flag4 = FormRaovat.string_0[j] != null;
					if (flag4)
					{
						this.method_1(this.listView2, Class10.smethod_1(FormRaovat.string_0[j], 1, false));
					}
				}
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0016F209 File Offset: 0x0016D409
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormRaovat.bool_0 = false;
			FormRaovat.int_0 = 0;
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0016F218 File Offset: 0x0016D418
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormRaovat.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0016F23C File Offset: 0x0016D43C
		private void checkBoxRaoVat_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_69[0] = (int)Convert.ToByte(this.checkBoxRaoVat.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0016F2AC File Offset: 0x0016D4AC
		private void comboBoxRaoVat_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxRaoVat.Text;
					for (int i = 0; i < FormRaovat.string_2.Length; i++)
					{
						bool flag3 = text == FormRaovat.string_2[i, 0];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_69[1] = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0016F35C File Offset: 0x0016D55C
		private void textBoxTimeRaoVat_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_69[2] = Class12.smethod_11(this.textBoxTimeRaoVat.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0016F3CC File Offset: 0x0016D5CC
		private void textBoxTextRaoVat_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].string_10 = this.textBoxTextRaoVat.Text;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0016F438 File Offset: 0x0016D638
		private void checkBoxRaoHinhanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_69[3] = (int)Convert.ToByte(this.checkBoxRaoHinhanh.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.textBoxTextRaoVat.Enabled = (Form1.gstruct49_0[num].int_69[3] <= 0);
					this.comboBoxRaoVat.Enabled = (Form1.gstruct49_0[num].int_69[3] <= 0);
				}
			}
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0016F4F4 File Offset: 0x0016D6F4
		private void checkBoxBomNoiluc_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_69[4] = (int)Convert.ToByte(this.checkBoxBomNoiluc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0016F564 File Offset: 0x0016D764
		private void comboBoxKhongdanhAc_MouseDown(object sender, MouseEventArgs e)
		{
			this.string_4 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class98.smethod_25(Form1.gstruct49_0[i], ref this.string_4, 1, null);
				}
			}
			this.comboBoxKhongdanhAc.Items.Clear();
			bool flag2 = this.string_4 != null;
			if (flag2)
			{
				Array.Sort<string>(this.string_4);
				for (int j = 0; j < this.string_4.Length; j++)
				{
					this.comboBoxKhongdanhAc.Items.Add(Class10.smethod_1(this.string_4[j], 1, false));
				}
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0016F624 File Offset: 0x0016D824
		private void comboBoxKhongdanhAc_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_0(this.listView2, this.comboBoxKhongdanhAc.Text, this.string_4, ref FormRaovat.string_0);
			Class7.smethod_1(FormRaovat.string_0, FormRaovat.string_1);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0016F65C File Offset: 0x0016D85C
		private void method_0(ListView listView_0, string string_5, string[] string_6, ref string[] string_7)
		{
			bool flag = string_5 == null || string_5 == string.Empty || string_6 == null;
			if (!flag)
			{
				bool flag2 = string_7 != null;
				if (flag2)
				{
					for (int i = 0; i < string_7.Length; i++)
					{
						bool flag3 = string_5 == Class10.smethod_1(string_7[i], 1, false);
						if (flag3)
						{
							return;
						}
					}
				}
				for (int j = 0; j < string_6.Length; j++)
				{
					bool flag4 = string_5 == Class10.smethod_1(string_6[j], 1, false);
					if (flag4)
					{
						string_5 = string_6[j];
						break;
					}
				}
				bool flag5 = string_7 == null;
				if (flag5)
				{
					string_7 = new string[]
					{
						string_5
					};
				}
				else
				{
					string[] array = new string[string_7.Length + 1];
					for (int k = 0; k < string_7.Length; k++)
					{
						array[k] = string_7[k];
					}
					string_7 = new string[array.Length];
					for (int l = 0; l < string_7.Length; l++)
					{
						string_7[l] = array[l];
					}
					string_7[string_7.Length - 1] = string_5;
				}
				this.method_1(listView_0, Class10.smethod_1(string_5, 1, false));
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0016F7A4 File Offset: 0x0016D9A4
		private void method_1(ListView listView_0, string string_5)
		{
			try
			{
				string[] array = new string[]
				{
					string_5
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

		// Token: 0x06000A3F RID: 2623 RVA: 0x0016F828 File Offset: 0x0016DA28
		private void checkBoxAceptBH_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].bool_17 = this.checkBoxAceptBH.Checked;
				}
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0016F87D File Offset: 0x0016DA7D
		private void buttonXoaDanhAc_Click(object sender, EventArgs e)
		{
			this.method_2(this.listView2, ref FormRaovat.string_0);
			Class7.smethod_1(FormRaovat.string_0, FormRaovat.string_1);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0016F8A4 File Offset: 0x0016DAA4
		private void method_2(ListView listView_0, ref string[] string_5)
		{
			bool flag = string_5 != null && string_5.Length != 0;
			if (flag)
			{
				string text = string.Empty;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					bool selected = listView_0.Items[i].Selected;
					if (selected)
					{
						text = listView_0.Items[i].SubItems[0].Text;
						listView_0.Items.RemoveAt(i);
						break;
					}
				}
				bool flag2 = text == null || text == string.Empty;
				if (!flag2)
				{
					string[] array = new string[string_5.Length];
					int num = 0;
					for (int j = 0; j < string_5.Length; j++)
					{
						bool flag3 = text != Class10.smethod_1(string_5[j], 1, false);
						if (flag3)
						{
							array[num] = string_5[j];
							num++;
						}
					}
					bool flag4 = num != 0;
					if (flag4)
					{
						string_5 = new string[num];
						for (int k = 0; k < num; k++)
						{
							string_5[k] = array[k];
						}
					}
					else
					{
						listView_0.Items.Clear();
						string_5 = null;
					}
				}
			}
			else
			{
				listView_0.Items.Clear();
				string_5 = null;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0016F9FC File Offset: 0x0016DBFC
		private void button1_Click(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormRaovat.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					string text = Class12.smethod_53(FormRaovat.string_3);
					Form1.gstruct49_0[num].string_10 = text;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.textBoxTextRaoVat.Text = text;
				}
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0016FA74 File Offset: 0x0016DC74
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00170828 File Offset: 0x0016EA28
		// Note: this type is marked as 'beforefieldinit'.
		static FormRaovat()
		{
			string[,] array = new string[5, 2];
			array[0, 0] = "Thế giới";
			array[0, 1] = "CH_WORLD";
			array[1, 0] = "Thành thị";
			array[1, 1] = "CH_CITY";
			array[2, 0] = "Bang hội";
			array[2, 1] = "CH_TONG";
			array[3, 0] = "Phòng tán";
			array[3, 1] = "CH_CHATROOM";
			array[4, 0] = "Phụ cận";
			array[4, 1] = "CH_NEARBY";
			FormRaovat.string_2 = array;
			FormRaovat.string_3 = "ᓯᓥᔍᕪᔞᓕᔀᔎᔀᔚᔤᔭᔚᓕᔦᔪᔖᓕᔥᔝᖩᓕᔩᔧᖣᓕᔗᕿᔢᓕᔘᖀᔥᓕᔣᔝᖀᔩᓕᔖᔪᔩᔤᓕᔣᔝᖅᓕᔘᕭᔘᓕᔩᔝᖒᔢᓡᓕᕣᕬᓕᔘᖘᓕᔬᔚᔗᓕᔧᖚᔞᓕᓖᓣᓣᓣ";
		}

		// Token: 0x04000B09 RID: 2825
		public static bool bool_0 = false;

		// Token: 0x04000B0A RID: 2826
		public static int int_0 = 0;

		// Token: 0x04000B0B RID: 2827
		public static int int_1 = 0;

		// Token: 0x04000B0C RID: 2828
		public static string[] string_0 = null;

		// Token: 0x04000B0D RID: 2829
		public static string string_1 = "NoAcceptBho.txt";

		// Token: 0x04000B0E RID: 2830
		public static string[,] string_2;

		// Token: 0x04000B0F RID: 2831
		private static string string_3;

		// Token: 0x04000B10 RID: 2832
		private string[] string_4 = null;

		// Token: 0x04000B11 RID: 2833
		private IContainer icontainer_0 = null;
	}
}
