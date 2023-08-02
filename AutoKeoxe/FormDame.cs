using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006C RID: 108
	public partial class FormDame : Form
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x0013F6D5 File Offset: 0x0013D8D5
		public FormDame()
		{
			FormDame.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x0013F704 File Offset: 0x0013D904
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x001411C8 File Offset: 0x0013F3C8
		public static void smethod_0()
		{
			int num = FormDame.int_0;
			FormDame.int_0 = 0;
			int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag = num2 < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num2];
				int num3 = 0;
				byte[] array = new byte[]
				{
					1
				};
				Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_12 * 4U, array, 1, ref num3);
				int num4 = 0;
				uint uint_ = gstruct.uint_4;
				long num5 = 0L;
				for (;;)
				{
					num4--;
					Thread.Sleep(10);
					bool flag2 = num5 > 0L;
					if (flag2)
					{
						long num6 = DateTime.Now.Ticks - num5;
						bool flag3 = num6 < 3000000L || num6 < (long)(FormDame.int_13 * 10000);
						if (flag3)
						{
							goto IL_196;
						}
						num5 = 0L;
					}
					bool flag4 = Class12.bool_0;
					if (flag4)
					{
						break;
					}
					bool flag5 = num4 <= 0;
					if (flag5)
					{
						num2 = Class81.smethod_3(Form1.gstruct49_0, num);
						bool flag6 = num2 < 0;
						if (flag6)
						{
							break;
						}
						uint_ = Form1.gstruct49_0[num2].uint_4;
						num4 = 60;
					}
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_12 * 4U + 1U, array, 1, ref num3);
					bool flag7 = array[0] > 0;
					if (!flag7)
					{
						Thread.Sleep(200);
						continue;
					}
					array[0] = 0;
					Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_12 * 4U + 1U, array, 1, ref num3);
					num5 = DateTime.Now.Ticks;
					IL_196:
					Class22.smethod_76(uint_, 117);
				}
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x0014137F File Offset: 0x0013F57F
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.int_1 = 0;
			this.int_2 = 0;
			FormDame.bool_0 = false;
			Class62.smethod_10(Class53.string_3, "tabControlDame", this.tabControl1.SelectedIndex, "", 0);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x001413BC File Offset: 0x0013F5BC
		private bool method_0(GStruct56[] gstruct56_0)
		{
			this.comboBoxSkill1.Items.Clear();
			this.comboBoxSkill2.Items.Clear();
			bool flag = gstruct56_0 == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				for (int i = 0; i < gstruct56_0.Length; i++)
				{
					this.comboBoxSkill1.Items.Add(gstruct56_0[i].string_0);
					this.comboBoxSkill2.Items.Add(gstruct56_0[i].string_0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0014144C File Offset: 0x0013F64C
		private string method_1(GStruct56[] gstruct56_0, int int_15)
		{
			bool flag = int_15 > 0 && gstruct56_0 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct56_0.Length; i++)
				{
					bool flag2 = gstruct56_0[i].int_1 == int_15;
					if (flag2)
					{
						return gstruct56_0[i].string_0;
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x001414AC File Offset: 0x0013F6AC
		private void FormDame_Load(object sender, EventArgs e)
		{
			FormDame.int_14 = FormDame.int_5;
			FormDame.bool_1 = false;
			bool flag = this.int_1 > 0 && this.int_2 > 0;
			if (flag)
			{
				int num = this.int_1 - base.Width - 10;
				int num2 = this.int_2 - base.Height - 10;
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
			for (int i = 0; i < FormDame.string_2.GetLength(0); i++)
			{
				string item = FormDame.string_2[i, 0];
				this.comboBoxF_1.Items.Add(item);
				this.comboBoxF_2.Items.Add(item);
				this.comboBoxF_3.Items.Add(item);
			}
			for (int j = 0; j < FormDame.string_1.Length; j++)
			{
				this.comboBoxKieuXuatchieu.Items.Add(FormDame.string_1[j]);
			}
			bool flag4 = Form1.gstruct49_0 != null;
			if (flag4)
			{
				for (int k = 0; k < Form1.gstruct49_0.Length; k++)
				{
					string text = Class10.smethod_1(Form1.gstruct49_0[k].string_22, 1, false);
					this.comboBoxTenAc.Items.Add(text);
					this.method_2(this.listView1, text + "|" + Form1.gstruct49_0[k].int_136.ToString());
				}
				for (int l = 0; l < Form1.gstruct49_0.Length; l++)
				{
					bool flag5 = Form1.gstruct49_0[l].int_126 > 0 && l < this.listView1.Items.Count;
					if (flag5)
					{
						this.listView1.Items[l].Checked = true;
					}
				}
			}
			int num3 = 0;
			int num4 = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
			bool flag6 = 0 <= num4;
			if (flag6)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num4];
				this.comboBoxTenAc.Text = Class10.smethod_1(Form1.gstruct49_0[num4].string_22, 1, false);
				GStruct56[] gstruct56_ = Class77.smethod_22(gstruct, -1);
				this.method_0(gstruct56_);
				this.checkBoxSkill1.Checked = (gstruct.int_127[1] > 0);
				this.comboBoxSkill1.Text = this.method_1(gstruct56_, gstruct.int_127[2]);
				this.checkBoxSkill2.Checked = (gstruct.int_127[3] > 0);
				this.comboBoxSkill2.Text = this.method_1(gstruct56_, gstruct.int_127[4]);
				this.checkBoxF_1.Checked = (gstruct.int_129[0] > 0);
				this.checkBoxF_2.Checked = (gstruct.int_129[1] > 0);
				this.checkBoxF_3.Checked = (gstruct.int_129[2] > 0);
				this.comboBoxF_1.Text = FormDame.smethod_1(gstruct.int_129[3]);
				this.comboBoxF_2.Text = FormDame.smethod_1(gstruct.int_129[4]);
				this.comboBoxF_3.Text = FormDame.smethod_1(gstruct.int_129[5]);
				num3 = gstruct.int_127[0];
			}
			this.comboBoxKieuXuatchieu.Text = FormDame.string_1[num3];
			this.method_3(num3);
			for (int m = 0; m < FormDame.string_0.Length; m++)
			{
				this.comboBoxKieudanh.Items.Add(FormDame.string_0[m]);
			}
			this.comboBoxKieudanh.Text = FormDame.string_0[FormDame.int_9];
			this.checkBoxTuDanhbinhthuong.Checked = (FormDame.int_11 > 0);
			this.checkBoxTuDanhbinhthuong.Enabled = (FormDame.int_9 == 1);
			this.checkBoxCtrlShift.Checked = (FormDame.int_8 > 0);
			this.checkBoxAllwayAttack.Checked = (FormDame.int_10 > 0);
			this.textBoxTocdo.Text = FormDame.int_13.ToString();
			this.textBoxDeLay.Text = FormDame.int_12.ToString();
			base.TopMost = true;
			this.tabControl1.SelectedIndex = Class62.smethod_3("tabControlDame", 0, "0");
			Thread.Sleep(60);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			FormDame.bool_1 = true;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00141974 File Offset: 0x0013FB74
		private void method_2(ListView listView_0, string string_3)
		{
			string[] array = string_3.Split(new char[]
			{
				'|'
			});
			try
			{
				ListViewItem listViewItem = new ListViewItem(array[0]);
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
				this.listView1.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x001419F8 File Offset: 0x0013FBF8
		private static string smethod_1(int int_15)
		{
			bool flag = int_15 > 0;
			if (flag)
			{
				for (int i = 0; i < FormDame.string_2.GetLength(0); i++)
				{
					bool flag2 = int_15 == Class12.smethod_11(FormDame.string_2[i, 1]);
					if (flag2)
					{
						return FormDame.string_2[i, 0];
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00141A60 File Offset: 0x0013FC60
		private static int smethod_2(string string_3)
		{
			bool flag = string_3 != null && string_3 != string.Empty;
			if (flag)
			{
				for (int i = 0; i < FormDame.string_2.GetLength(0); i++)
				{
					bool flag2 = string_3 == FormDame.string_2[i, 0];
					if (flag2)
					{
						return Class12.smethod_11(FormDame.string_2[i, 1]);
					}
				}
			}
			return 0;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00141AD4 File Offset: 0x0013FCD4
		private void method_3(int int_15)
		{
			this.tabPageSendKey.Enabled = (int_15 == 2);
			this.tabPageChieu12.Enabled = (int_15 == 1);
			bool flag = int_15 > 0;
			if (flag)
			{
				this.tabControl1.SelectedIndex = int_15 - 1;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00141B1C File Offset: 0x0013FD1C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormDame.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00141B40 File Offset: 0x0013FD40
		private void comboBoxKieudanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBoxKieudanh.Text;
				for (int i = 0; i < FormDame.string_0.Length; i++)
				{
					bool flag2 = text == FormDame.string_0[i];
					if (flag2)
					{
						FormDame.int_9 = i;
						break;
					}
				}
				Class62.smethod_10(Class53.string_3, "IdexKieudanh", FormDame.int_9, "", 0);
				this.checkBoxTuDanhbinhthuong.Enabled = (FormDame.int_9 == 1);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00141BD8 File Offset: 0x0013FDD8
		private void checkBoxTuDanhbinhthuong_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDame.int_11 = (int)Convert.ToByte(this.checkBoxTuDanhbinhthuong.Checked);
				Class62.smethod_10(Class53.string_3, "SwicthDame", FormDame.int_11, "", 0);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00141C2C File Offset: 0x0013FE2C
		private void comboBoxTenAc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormDame.bool_1;
			if (!flag)
			{
				FormDame.int_14 = -1;
				string text = this.comboBoxTenAc.Text;
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
						if (flag3)
						{
							FormDame.int_14 = Form1.gstruct49_0[i].int_136;
							break;
						}
					}
				}
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag4 = num >= 0;
				if (flag4)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					FormDame.bool_1 = false;
					GStruct56[] gstruct56_ = Class77.smethod_22(gstruct, -1);
					this.method_0(gstruct56_);
					this.checkBoxSkill1.Checked = (gstruct.int_127[1] > 0);
					this.comboBoxSkill1.Text = this.method_1(gstruct56_, gstruct.int_127[2]);
					this.checkBoxSkill2.Checked = (gstruct.int_127[3] > 0);
					this.comboBoxSkill2.Text = this.method_1(gstruct56_, gstruct.int_127[4]);
					this.checkBoxF_1.Checked = (gstruct.int_129[0] > 0);
					this.checkBoxF_2.Checked = (gstruct.int_129[1] > 0);
					this.checkBoxF_3.Checked = (gstruct.int_129[2] > 0);
					this.comboBoxF_1.Text = FormDame.smethod_1(gstruct.int_129[3]);
					this.comboBoxF_2.Text = FormDame.smethod_1(gstruct.int_129[4]);
					this.comboBoxF_3.Text = FormDame.smethod_1(gstruct.int_129[5]);
					this.comboBoxKieuXuatchieu.Text = FormDame.string_1[gstruct.int_127[0]];
					this.method_3(gstruct.int_127[0]);
					Thread.Sleep(60);
					FormDame.bool_1 = true;
				}
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00141E58 File Offset: 0x00140058
		private void checkBoxSkill1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormDame.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_127[1] = (int)Convert.ToByte(this.checkBoxSkill1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00141ED4 File Offset: 0x001400D4
		private void checkBoxSkill2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormDame.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_127[3] = (int)Convert.ToByte(this.checkBoxSkill2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00141F50 File Offset: 0x00140150
		private void comboBoxSkill1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormDame.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					GStruct56[] array = Class77.smethod_22(gstruct49_, -1);
					bool flag3 = array == null;
					if (!flag3)
					{
						int num2 = 0;
						string text = this.comboBoxSkill1.Text;
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = text == array[i].string_0;
							if (flag4)
							{
								num2 = array[i].int_1;
								break;
							}
						}
						num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
						bool flag5 = 0 <= num;
						if (flag5)
						{
							Form1.gstruct49_0[num].int_127[2] = num2;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
				}
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0014205C File Offset: 0x0014025C
		private void comboBoxSkill2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormDame.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					GStruct56[] array = Class77.smethod_22(gstruct49_, -1);
					bool flag3 = array == null;
					if (!flag3)
					{
						int num2 = 0;
						string text = this.comboBoxSkill2.Text;
						for (int i = 0; i < array.Length; i++)
						{
							bool flag4 = text == array[i].string_0;
							if (flag4)
							{
								num2 = array[i].int_1;
								break;
							}
						}
						num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
						bool flag5 = 0 <= num;
						if (flag5)
						{
							Form1.gstruct49_0[num].int_127[4] = num2;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
					}
				}
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00142168 File Offset: 0x00140368
		private void checkBoxAllwayAttack_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDame.int_10 = (int)Convert.ToByte(this.checkBoxAllwayAttack.Checked);
				Class62.smethod_10(Class53.string_3, "AllwayAttack", FormDame.int_10, "", 0);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x001421BC File Offset: 0x001403BC
		private void comboBoxKieuXuatchieu_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !FormDame.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = -1;
					for (int i = 0; i < FormDame.string_1.Length; i++)
					{
						bool flag3 = this.comboBoxKieuXuatchieu.Text == FormDame.string_1[i];
						if (flag3)
						{
							num2 = i;
							break;
						}
					}
					bool flag4 = num2 >= 0;
					if (flag4)
					{
						Form1.gstruct49_0[num].int_127[0] = num2;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
						this.method_3(num2);
					}
				}
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00142288 File Offset: 0x00140488
		private void textBoxDeLay_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDame.int_12 = Class12.smethod_11(this.textBoxDeLay.Text);
				Class62.smethod_10(Class53.string_3, "TimerKeyXuat", FormDame.int_12, "", 0);
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x001422DC File Offset: 0x001404DC
		private void checkBoxF_1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !FormDame.bool_1;
				if (!flag2)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_129[0] = (int)Convert.ToByte(this.checkBoxF_1.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00142364 File Offset: 0x00140564
		private void checkBoxF_2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !FormDame.bool_1;
				if (!flag)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_129[1] = (int)Convert.ToByte(this.checkBoxF_2.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x001423EC File Offset: 0x001405EC
		private void checkBoxF_3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormDame.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_129[2] = (int)Convert.ToByte(this.checkBoxF_3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00142468 File Offset: 0x00140668
		private void comboBoxF_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !FormDame.bool_1;
				if (!flag)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_129[3] = FormDame.smethod_2(this.comboBoxF_1.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x001424F0 File Offset: 0x001406F0
		private void comboBoxF_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !FormDame.bool_1;
				if (!flag2)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_129[4] = FormDame.smethod_2(this.comboBoxF_2.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00142578 File Offset: 0x00140778
		private void comboBoxF_3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormDame.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormDame.int_14);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_129[5] = FormDame.smethod_2(this.comboBoxF_3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x001425F4 File Offset: 0x001407F4
		private void textBoxTocdo_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDame.int_13 = Class12.smethod_11(this.textBoxTocdo.Text);
				Class62.smethod_10(Class53.string_3, "TocdoDame", FormDame.int_13, "", 0);
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00142648 File Offset: 0x00140848
		private void checkBoxCtrlShift_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormDame.int_8 = (int)Convert.ToByte(this.checkBoxCtrlShift.Checked);
				Class62.smethod_10(Class53.string_3, "flagCtrlShift", FormDame.int_8, "", 0);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0014269C File Offset: 0x0014089C
		private void buttonNotCheckAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].int_126 = 0;
					Class53.smethod_13(Form1.gstruct49_0[i], null);
				}
			}
			for (int j = 0; j < this.listView1.Items.Count; j++)
			{
				this.listView1.Items[j].Checked = false;
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00142730 File Offset: 0x00140930
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int num = Class12.smethod_11(this.listView1.Items[e.Index].SubItems[1].Text);
				bool flag2 = num == 0 || Form1.gstruct49_0 == null;
				if (!flag2)
				{
					try
					{
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							bool flag3 = Form1.gstruct49_0[i].int_136 == num;
							if (flag3)
							{
								Form1.gstruct49_0[i].int_126 = (int)Convert.ToByte(e.NewValue == CheckState.Checked);
								Class53.smethod_13(Form1.gstruct49_0[i], null);
								break;
							}
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00142818 File Offset: 0x00140A18
		// Note: this type is marked as 'beforefieldinit'.
		static FormDame()
		{
			string[,] array = new string[3, 2];
			array[0, 0] = "F3";
			array[0, 1] = "114";
			array[1, 0] = "F4";
			array[1, 1] = "115";
			array[2, 0] = "F5";
			array[2, 1] = "116";
			FormDame.string_2 = array;
			FormDame.int_14 = 0;
			FormDame.bool_1 = false;
		}

		// Token: 0x04000869 RID: 2153
		private IContainer icontainer_0 = null;

		// Token: 0x0400088D RID: 2189
		public static int int_0 = 0;

		// Token: 0x0400088E RID: 2190
		public int int_1;

		// Token: 0x0400088F RID: 2191
		public int int_2;

		// Token: 0x04000890 RID: 2192
		public int int_3;

		// Token: 0x04000891 RID: 2193
		public int int_4;

		// Token: 0x04000892 RID: 2194
		public static bool bool_0 = false;

		// Token: 0x04000893 RID: 2195
		public static int int_5 = 0;

		// Token: 0x04000894 RID: 2196
		public static int int_6 = Class62.smethod_3("flagDameMacdinh", 0, "0");

		// Token: 0x04000895 RID: 2197
		public static int int_7 = 0;

		// Token: 0x04000896 RID: 2198
		public static int int_8 = Class62.smethod_3("flagCtrlShift", 0, "1");

		// Token: 0x04000897 RID: 2199
		public static int int_9 = Class62.smethod_3("IdexKieudanh", 0, "1");

		// Token: 0x04000898 RID: 2200
		public static int int_10 = Class62.smethod_3("AllwayAttack", 0, "0");

		// Token: 0x04000899 RID: 2201
		public static int int_11 = Class62.smethod_3("SwicthDame", 0, "1");

		// Token: 0x0400089A RID: 2202
		public static int int_12 = Class62.smethod_3("TimerKeyXuat", 0, "300");

		// Token: 0x0400089B RID: 2203
		public static int int_13 = Class62.smethod_3("TocdoDame", 0, "100");

		// Token: 0x0400089C RID: 2204
		private static string[] string_0 = new string[]
		{
			"1. Tự động đánh vào vị trí chuột",
			"2. Bấm và giữ phím tắt - Đánh vào vị trí chuột",
			"3. Bấm và giữ phím tắt - Tự động quét tìm đánh đối thủ"
		};

		// Token: 0x0400089D RID: 2205
		private static string[] string_1 = new string[]
		{
			"Sử dụng chiêu tay trái",
			"Đánh ra chiêu 1 2 bên dưới",
			"Đánh ra chiêu đã gán phím tắt"
		};

		// Token: 0x0400089E RID: 2206
		public static string[,] string_2;

		// Token: 0x0400089F RID: 2207
		private static int int_14;

		// Token: 0x040008A1 RID: 2209
		private static bool bool_1;
	}
}
