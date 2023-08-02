using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006E RID: 110
	public partial class FormDuongMon : Form
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x001447A9 File Offset: 0x001429A9
		public FormDuongMon()
		{
			FormDuongMon.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x001447E0 File Offset: 0x001429E0
		public static void smethod_0(GStruct49 gstruct49_0, ref int int_6, uint[] uint_0, ref int int_7, bool bool_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
			bool flag = Class60.smethod_29(gstruct49_0, true);
			if (flag)
			{
				Thread.Sleep(150);
			}
			bool flag2 = bool_2 && FormDuongMon.int_4 > 0;
			if (flag2)
			{
				int[] array = new int[]
				{
					10,
					90,
					170,
					250,
					330,
					70,
					150,
					230,
					310,
					350,
					50,
					130,
					210,
					290,
					30,
					110,
					190,
					270
				};
				bool flag3 = int_7 < 0 || array.Length <= int_7;
				if (flag3)
				{
					int_7 = 0;
				}
				int num5 = FormDuongMon.int_5;
				bool flag4 = num5 > 50;
				if (flag4)
				{
					Random random = new Random();
					num5 = random.Next(50, num5);
				}
				double num6 = (double)Math.Abs(array[int_7]) * 3.14 / 180.0;
				uint[] array2 = new uint[]
				{
					(uint)(uint_0[0] + (double)num5 * Math.Cos(num6)),
					(uint)(uint_0[1] - (double)num5 * Math.Sin(num6))
				};
				int i = 0;
				int num7 = 0;
				while (i < 40)
				{
					int num8 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					num7 = ((num8 <= 1) ? (num7 + 1) : 0);
					bool flag5 = num7 > 10;
					if (flag5)
					{
						break;
					}
					Thread.Sleep(10);
					i++;
				}
				bool flag6 = i > 39;
				if (flag6)
				{
					Class70.smethod_57(gstruct49_0, "Switch([[sit]])");
					Thread.Sleep(150);
				}
				int num9 = 0;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, new byte[4], 4, ref num9);
				for (i = 0; i < 8; i++)
				{
					uint[] uint_ = new uint[]
					{
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					long num10 = Class60.smethod_18(uint_, array2);
					bool flag7 = num10 < 7800L;
					if (flag7)
					{
						break;
					}
					Class70.smethod_61(gstruct49_0, array2);
					Thread.Sleep(200);
				}
				int_7++;
			}
			int[,] array3 = new int[3, 2];
			array3[0, 0] = gstruct49_0.int_128[1];
			array3[0, 1] = gstruct49_0.int_128[2];
			array3[1, 0] = gstruct49_0.int_128[3];
			array3[1, 1] = gstruct49_0.int_128[4];
			array3[2, 0] = gstruct49_0.int_128[5];
			array3[2, 1] = gstruct49_0.int_128[6];
			int[,] array4 = array3;
			int num11 = 0;
			do
			{
				int length = array4.GetLength(0);
				bool flag8 = int_6 < 0 || length <= int_6;
				if (flag8)
				{
					int_6 = 0;
				}
				int num12 = int_6;
				while (array4[int_6, 0] <= 0 || array4[int_6, 1] <= 0)
				{
					int_6++;
					bool flag9 = length <= int_6;
					if (flag9)
					{
						int_6 = 0;
					}
					bool flag10 = num12 != int_6;
					if (!flag10)
					{
						return;
					}
				}
				bool flag11 = gstruct49_0.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
				if (flag11)
				{
					Class77.smethod_9(gstruct49_0, null);
				}
				Class77.smethod_5(gstruct49_0, array4[int_6, 1], 6, 1);
				int j = 0;
				int num13 = 0;
				while (j < 15)
				{
					int num14 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					num13 = ((num14 < 3) ? (num13 + 1) : 0);
					bool flag12 = num13 > 6;
					if (flag12)
					{
						break;
					}
					Thread.Sleep(10);
					j++;
				}
				j = 0;
				num13 = 0;
				while (j < 60)
				{
					bool flag13 = j % 15 == 0;
					if (flag13)
					{
						Class22.smethod_76(gstruct49_0.uint_4, 117);
					}
					int num15 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					num13 = ((num15 < 4) ? (num13 + 1) : 0);
					bool flag14 = num13 > 6;
					if (flag14)
					{
						break;
					}
					Thread.Sleep(10);
					j++;
				}
				int_6++;
				num11++;
			}
			while (num11 < FormDuongMon.int_3);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00144C85 File Offset: 0x00142E85
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.int_0 = 0;
			this.int_1 = 0;
			FormDuongMon.int_2 = 0;
			FormDuongMon.bool_0 = false;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00144CA4 File Offset: 0x00142EA4
		private void FormDuongMon_Load(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			this.bool_1 = false;
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
			GStruct49 gstruct = new GStruct49
			{
				int_136 = 0
			};
			int num3 = -1;
			int num4 = -1;
			bool flag4 = Form1.gstruct49_0 != null;
			if (flag4)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					string a = Class77.smethod_18(Form1.gstruct49_0[i], null);
					bool flag5 = a == "DUONGMON";
					if (flag5)
					{
						this.comboBoxTenAc.Items.Add(Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
						bool flag6 = num3 <= 0;
						if (flag6)
						{
							num3 = Form1.gstruct49_0[i].int_136;
							gstruct = Form1.gstruct49_0[i];
						}
					}
				}
			}
			bool flag7 = FormDuongMon.int_2 > 0;
			if (flag7)
			{
				int num5 = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag8 = 0 <= num5;
				if (flag8)
				{
					string a2 = Class77.smethod_18(Form1.gstruct49_0[num5], null);
					bool flag9 = a2 == "DUONGMON";
					if (flag9)
					{
						num4 = Form1.gstruct49_0[num5].int_136;
						gstruct = Form1.gstruct49_0[num5];
					}
				}
			}
			bool flag10 = num4 <= 0 && num3 > 0;
			if (flag10)
			{
				num4 = num3;
			}
			FormDuongMon.int_2 = 0;
			this.groupBox1.Enabled = (num4 > 0);
			bool flag11 = num4 > 0;
			if (flag11)
			{
				FormDuongMon.int_2 = num4;
				this.comboBoxTenAc.Text = Class10.smethod_1(gstruct.string_22, 1, false);
				GStruct56[] gstruct56_ = Class77.smethod_22(gstruct, -1);
				this.method_1(this.comboBoxBoom1, gstruct56_);
				this.method_1(this.comboBoxBoom2, gstruct56_);
				this.method_1(this.comboBoxBoom3, gstruct56_);
				this.checkBoxPhim1.Checked = (gstruct.int_128[1] > 0);
				this.checkBoxPhim2.Checked = (gstruct.int_128[3] > 0);
				this.checkBoxPhim3.Checked = (gstruct.int_128[5] > 0);
				this.comboBoxBoom1.Text = this.method_2(gstruct56_, gstruct.int_128[2]);
				this.comboBoxBoom2.Text = this.method_2(gstruct56_, gstruct.int_128[4]);
				this.comboBoxBoom3.Text = this.method_2(gstruct56_, gstruct.int_128[6]);
			}
			for (int j = 1; j < 5; j++)
			{
				this.comboBoxSolanNhoiboom.Items.Add(j);
			}
			this.checkBoxDatXungQuanh.Checked = (FormDuongMon.int_4 > 0);
			this.textBoxKhoangCach.Text = FormDuongMon.int_5.ToString();
			this.comboBoxSolanNhoiboom.Text = FormDuongMon.int_3.ToString();
			Thread.Sleep(100);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			this.bool_1 = true;
			base.TopMost = true;
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0014504C File Offset: 0x0014324C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormDuongMon.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00145070 File Offset: 0x00143270
		private void checkBoxPhim1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_128[1] = (int)Convert.ToByte(this.checkBoxPhim1.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x001450F8 File Offset: 0x001432F8
		private void checkBoxPhim2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !this.bool_1;
				if (!flag2)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_128[3] = (int)Convert.ToByte(this.checkBoxPhim2.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00145180 File Offset: 0x00143380
		private void checkBoxPhim3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_128[5] = (int)Convert.ToByte(this.checkBoxPhim3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x001451FC File Offset: 0x001433FC
		private void checkBoxDatXungQuanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDuongMon.int_4 = (int)Convert.ToByte(this.checkBoxDatXungQuanh.Checked);
				Class62.smethod_10(Class53.string_3, "flagDatXungquanhAcChinh", FormDuongMon.int_4, "", 0);
			}
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00145250 File Offset: 0x00143450
		private void textBoxKhoangCach_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDuongMon.int_5 = Class12.smethod_11(this.textBoxKhoangCach.Text);
				bool flag = FormDuongMon.int_5 < 0;
				if (flag)
				{
					FormDuongMon.int_5 = 0;
				}
				Class62.smethod_10(Class53.string_3, "KhoangCachDatBoom", FormDuongMon.int_5, "", 0);
			}
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x001452B8 File Offset: 0x001434B8
		private void method_0(object sender, EventArgs e)
		{
			string text = "https://youtu.be/NPL9IJdsf3g";
			Class12.smethod_29(ref Class12.string_16, "Xem video hướng dẫn tại: " + text);
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x001452F8 File Offset: 0x001434F8
		private bool method_1(ComboBox comboBox_0, GStruct56[] gstruct56_0)
		{
			comboBox_0.Items.Clear();
			bool flag = gstruct56_0 != null;
			bool result;
			if (flag)
			{
				for (int i = 0; i < gstruct56_0.Length; i++)
				{
					comboBox_0.Items.Add(gstruct56_0[i].string_0);
				}
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00145350 File Offset: 0x00143550
		private string method_2(GStruct56[] gstruct56_0, int int_6)
		{
			bool flag = int_6 > 0 && gstruct56_0 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct56_0.Length; i++)
				{
					bool flag2 = gstruct56_0[i].int_1 == int_6;
					if (flag2)
					{
						return gstruct56_0[i].string_0;
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x001453B0 File Offset: 0x001435B0
		private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				FormDuongMon.int_2 = -1;
				string text = this.comboBoxTenAc.Text;
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
						if (flag3)
						{
							FormDuongMon.int_2 = Form1.gstruct49_0[i].int_136;
							break;
						}
					}
				}
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag4 = num >= 0;
				if (flag4)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					this.bool_1 = false;
					GStruct56[] gstruct56_ = Class77.smethod_22(gstruct, -1);
					this.method_1(this.comboBoxBoom1, gstruct56_);
					this.method_1(this.comboBoxBoom2, gstruct56_);
					this.method_1(this.comboBoxBoom3, gstruct56_);
					this.checkBoxPhim1.Checked = (gstruct.int_128[1] > 0);
					this.checkBoxPhim2.Checked = (gstruct.int_128[3] > 0);
					this.checkBoxPhim3.Checked = (gstruct.int_128[5] > 0);
					this.comboBoxBoom1.Text = this.method_2(gstruct56_, gstruct.int_128[2]);
					this.comboBoxBoom2.Text = this.method_2(gstruct56_, gstruct.int_128[4]);
					this.comboBoxBoom3.Text = this.method_2(gstruct56_, gstruct.int_128[5]);
					Thread.Sleep(60);
					this.bool_1 = true;
				}
			}
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00145578 File Offset: 0x00143778
		private void comboBoxBoom1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					GStruct56[] array = Class77.smethod_22(gstruct49_, -1);
					bool flag3 = array == null;
					if (!flag3)
					{
						int num2 = 0;
						string text = this.comboBoxBoom1.Text;
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = text == array[i].string_0;
							if (flag4)
							{
								num2 = array[i].int_1;
								break;
							}
						}
						num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
						bool flag5 = 0 <= num;
						if (flag5)
						{
							Form1.gstruct49_0[num].int_128[2] = num2;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
				}
			}
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00145684 File Offset: 0x00143884
		private void comboBoxBoom2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					GStruct56[] array = Class77.smethod_22(gstruct49_, -1);
					bool flag3 = array == null;
					if (!flag3)
					{
						int num2 = 0;
						string text = this.comboBoxBoom2.Text;
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = text == array[i].string_0;
							if (flag4)
							{
								num2 = array[i].int_1;
								break;
							}
						}
						num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
						bool flag5 = 0 <= num;
						if (flag5)
						{
							Form1.gstruct49_0[num].int_128[4] = num2;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
				}
			}
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00145790 File Offset: 0x00143990
		private void comboBoxBoom3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					GStruct56[] array = Class77.smethod_22(gstruct49_, -1);
					bool flag3 = array == null;
					if (!flag3)
					{
						int num2 = 0;
						string text = this.comboBoxBoom3.Text;
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = text == array[i].string_0;
							if (flag4)
							{
								num2 = array[i].int_1;
								break;
							}
						}
						num = Class81.smethod_3(Form1.gstruct49_0, FormDuongMon.int_2);
						bool flag5 = 0 <= num;
						if (flag5)
						{
							Form1.gstruct49_0[num].int_128[6] = num2;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
				}
			}
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x0014589C File Offset: 0x00143A9C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x040008B6 RID: 2230
		public int int_0;

		// Token: 0x040008B7 RID: 2231
		public int int_1;

		// Token: 0x040008B8 RID: 2232
		public static bool bool_0 = false;

		// Token: 0x040008B9 RID: 2233
		public static int int_2 = 0;

		// Token: 0x040008BA RID: 2234
		public static int int_3 = Class62.smethod_3("SolanNhoiBoom", 0, "3");

		// Token: 0x040008BB RID: 2235
		public static int int_4 = Class62.smethod_3("flagDatXungquanhAcChinh", 0, "1");

		// Token: 0x040008BC RID: 2236
		public static int int_5 = Class62.smethod_3("KhoangCachDatBoom", 0, "200");

		// Token: 0x040008BD RID: 2237
		private bool bool_1 = false;

		// Token: 0x040008BE RID: 2238
		private IContainer icontainer_0 = null;
	}
}
