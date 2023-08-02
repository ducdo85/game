using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000069 RID: 105
	public partial class FormClickNPC : Form
	{
		// Token: 0x06000812 RID: 2066 RVA: 0x0013715C File Offset: 0x0013535C
		public FormClickNPC()
		{
			FormClickNPC.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x001371AC File Offset: 0x001353AC
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00138BE0 File Offset: 0x00136DE0
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
			this.int_1 = 0;
			this.int_2 = 0;
			FormClickNPC.bool_0 = false;
			this.bool_2 = false;
			this.string_0 = null;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00138C40 File Offset: 0x00136E40
		private void FormClickNPC_Load(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			this.bool_2 = false;
			bool flag = this.int_1 > 0 && this.int_2 > 0;
			if (flag)
			{
				int num = this.int_1 - base.Width;
				int num2 = this.int_2;
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
			int num3 = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
			bool flag4 = num3 < 0;
			if (flag4)
			{
				this.textBoxMenuVatpham.Enabled = false;
				this.checkBoxCosudungVatpham.Enabled = false;
				this.checkBoxDoithoaiTruoc.Enabled = false;
				this.comboBoxVatpham.Enabled = false;
				this.checkBoxClickNpcNopVP.Enabled = false;
				this.checkBoxCoMuaVatpham.Enabled = false;
				this.checkBoxRuthettien.Enabled = false;
				this.comboBoxTabKTC.Enabled = false;
				this.comboBoxMuaVP.Enabled = false;
				this.comboBoxNop.Enabled = false;
				this.checkBoxTach.Enabled = false;
				this.checkBoxMuaKhiHet.Enabled = false;
				this.textBoxMuaKhicon.Enabled = false;
				this.checkBoxMuaKTC.Enabled = false;
				this.textBoxSoluongMua.Enabled = false;
				this.checkBoxCoNhapSL.Enabled = false;
				this.textBoxCoNhapSL.Enabled = false;
				this.method_0(this.listView1, "Cần phải chọn ac để thiết lập|...");
				this.labelTenac.Text = "[Bạn chưa chọn ac nào cả ]";
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num3];
				this.labelTenac.Text = "[ " + Class10.smethod_1(gstruct.string_22, 1, false) + "]";
				this.checkBoxCosudungVatpham.Checked = (gstruct.int_13[0] > 0);
				this.checkBoxCoNhapSL.Checked = (gstruct.int_13[1] > 0);
				this.textBoxCoNhapSL.Text = gstruct.int_13[2].ToString();
				bool flag5 = gstruct.string_1 != null && gstruct.string_1 != string.Empty;
				if (flag5)
				{
					string text = Class10.smethod_1(gstruct.string_1, 1, false);
					this.comboBoxVatpham.Items.Add(text);
					this.comboBoxVatpham.Text = text;
				}
				bool flag6 = gstruct.int_14 != null;
				if (flag6)
				{
					string text2 = null;
					for (int i = 0; i < gstruct.int_14.Length; i++)
					{
						bool flag7 = text2 != null;
						if (flag7)
						{
							text2 += ",";
						}
						text2 += gstruct.int_14[i].ToString();
					}
					this.textBoxMenuVatpham.Text = text2;
				}
				this.checkBoxDoithoaiTruoc.Checked = (gstruct.int_15 > 0);
				this.checkBoxClickNpcNopVP.Checked = (gstruct.int_16[0] > 0);
				this.checkBoxTach.Checked = (gstruct.int_16[1] > 0);
				this.checkBoxCoMuaVatpham.Checked = (gstruct.int_17[0] > 0);
				this.checkBoxRuthettien.Checked = (gstruct.int_17[1] > 0);
				this.checkBoxMuaKTC.Checked = (gstruct.int_17[2] > 0);
				this.checkBoxMuaKhiHet.Checked = (gstruct.int_17[3] > 0);
				this.textBoxMuaKhicon.Text = gstruct.int_17[4].ToString();
				bool flag8 = gstruct.gstruct31_1.string_0 != null && gstruct.gstruct31_1.string_0 != string.Empty;
				if (flag8)
				{
					string text3 = Class10.smethod_1(gstruct.gstruct31_1.string_0, 1, false);
					this.comboBoxMuaVP.Items.Add(text3);
					this.comboBoxMuaVP.Text = text3;
				}
				this.textBoxSoluongMua.Text = gstruct.gstruct31_1.int_4.ToString();
				string text4 = null;
				FormClickNPC.struct23_0 = Class83.smethod_1(gstruct);
				bool flag9 = FormClickNPC.struct23_0 != null;
				if (flag9)
				{
					for (int j = 0; j < FormClickNPC.struct23_0.Length; j++)
					{
						string text5 = Class10.smethod_1(FormClickNPC.struct23_0[j].string_0, 1, false);
						bool flag10 = gstruct.string_2 == FormClickNPC.struct23_0[j].string_0;
						if (flag10)
						{
							text4 = text5;
						}
						this.comboBoxTabKTC.Items.Add(text5);
					}
					bool flag11 = text4 == null || text4 == string.Empty;
					if (flag11)
					{
						num3 = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
						bool flag12 = 0 <= num3;
						if (flag12)
						{
							Form1.gstruct49_0[num3].string_2 = FormClickNPC.struct23_0[0].string_0;
						}
						text4 = Class10.smethod_1(FormClickNPC.struct23_0[0].string_0, 1, false);
					}
					this.comboBoxTabKTC.Text = text4;
				}
			}
			this.bool_2 = true;
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			this.bool_1 = true;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x001391C4 File Offset: 0x001373C4
		private void method_0(ListView listView_0, string string_1)
		{
			bool flag = string_1 == null || string_1 == string.Empty;
			if (!flag)
			{
				try
				{
					string[] array = string_1.Split(new char[]
					{
						'|'
					});
					ListViewItem listViewItem = new ListViewItem(array[0]);
					bool flag2 = array.Length > 1;
					if (flag2)
					{
						for (int i = 1; i < array.Length; i++)
						{
							ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
							listViewItem.SubItems.Add(item);
						}
					}
					this.listView1.Items.Add(listViewItem);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00139270 File Offset: 0x00137470
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormClickNPC.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = this.bool_1;
				if (flag2)
				{
					this.bool_1 = false;
					int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
					bool flag3 = 0 <= num && Form1.gstruct49_0[num].gstruct31_0 != null;
					if (flag3)
					{
						this.listView1.Items.Clear();
						GStruct31[] gstruct31_ = Form1.gstruct49_0[num].gstruct31_0;
						for (int i = 0; i < gstruct31_.Length; i++)
						{
							this.method_0(this.listView1, Class10.smethod_1(gstruct31_[i].string_0, 1, false) + "|" + gstruct31_[i].int_4.ToString());
						}
					}
				}
				bool flag4 = !this.buttonApdungAll.Enabled;
				if (flag4)
				{
					this.buttonApdungAll.Enabled = true;
				}
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0013937C File Offset: 0x0013757C
		private static int[] smethod_0(string string_1)
		{
			bool flag = !(string_1 == string.Empty) && string_1 != null;
			int[] result;
			if (flag)
			{
				string[] array = string_1.Split(new char[]
				{
					',',
					'.',
					':',
					'/',
					'|',
					'=',
					'-',
					'+',
					';'
				});
				int[] array2 = new int[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = Class12.smethod_11(array[i]);
				}
				result = array2;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x001393F4 File Offset: 0x001375F4
		private void checkBoxCosudungVatpham_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_13[0] = (int)Convert.ToByte(this.checkBoxCosudungVatpham.Checked);
				}
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0013945C File Offset: 0x0013765C
		private void textBoxMenuVatpham_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_14 = FormClickNPC.smethod_0(this.textBoxMenuVatpham.Text);
				}
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x001394C4 File Offset: 0x001376C4
		private void comboBoxVatpham_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.method_1(Form1.gstruct49_0[num], this.comboBoxVatpham);
				}
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00139524 File Offset: 0x00137724
		private void comboBoxVatpham_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_2 || this.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxVatpham.Text;
					for (int i = 0; i < this.string_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(this.string_0[i], 1, false);
						if (flag3)
						{
							Form1.gstruct49_0[num].string_1 = this.string_0[i];
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x001395D8 File Offset: 0x001377D8
		private void checkBoxDoithoaiTruoc_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_2;
				if (!flag)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_15 = (int)Convert.ToByte(this.checkBoxDoithoaiTruoc.Checked);
					}
				}
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0013964C File Offset: 0x0013784C
		private void buttonApdungAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
			bool flag = num < 0 || Form1.gstruct49_0 == null || num < 0;
			if (!flag)
			{
				this.buttonApdungAll.Enabled = false;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = i == num;
					if (!flag2)
					{
						Form1.gstruct49_0[i].int_13 = null;
						bool flag3 = Form1.gstruct49_0[num].int_14 != null;
						if (flag3)
						{
							Form1.gstruct49_0[i].int_13 = new int[Form1.gstruct49_0[num].int_13.Length];
							for (int j = 0; j < Form1.gstruct49_0[num].int_13.Length; j++)
							{
								Form1.gstruct49_0[i].int_13[j] = Form1.gstruct49_0[num].int_13[j];
							}
						}
						Form1.gstruct49_0[i].string_1 = Form1.gstruct49_0[num].string_1;
						Form1.gstruct49_0[i].int_15 = Form1.gstruct49_0[num].int_15;
						Form1.gstruct49_0[i].int_14 = null;
						bool flag4 = Form1.gstruct49_0[num].int_14 != null;
						if (flag4)
						{
							Form1.gstruct49_0[i].int_14 = new int[Form1.gstruct49_0[num].int_14.Length];
							for (int k = 0; k < Form1.gstruct49_0[num].int_14.Length; k++)
							{
								Form1.gstruct49_0[i].int_14[k] = Form1.gstruct49_0[num].int_14[k];
							}
						}
						Form1.gstruct49_0[i].int_17 = null;
						bool flag5 = Form1.gstruct49_0[num].int_17 != null;
						if (flag5)
						{
							Form1.gstruct49_0[i].int_17 = new int[Form1.gstruct49_0[num].int_17.Length];
							for (int l = 0; l < Form1.gstruct49_0[num].int_17.Length; l++)
							{
								Form1.gstruct49_0[i].int_17[l] = Form1.gstruct49_0[num].int_17[l];
							}
						}
						Form1.gstruct49_0[i].gstruct31_1 = new GStruct31
						{
							string_0 = Form1.gstruct49_0[num].gstruct31_1.string_0,
							int_4 = Form1.gstruct49_0[num].gstruct31_1.int_4
						};
						Form1.gstruct49_0[i].string_2 = Form1.gstruct49_0[num].string_2;
						Form1.gstruct49_0[i].int_16 = null;
						bool flag6 = Form1.gstruct49_0[num].int_16 != null;
						if (flag6)
						{
							Form1.gstruct49_0[i].int_16 = new int[Form1.gstruct49_0[num].int_16.Length];
							for (int m = 0; m < Form1.gstruct49_0[i].int_16.Length; m++)
							{
								Form1.gstruct49_0[i].int_16[m] = Form1.gstruct49_0[num].int_16[m];
							}
						}
						Form1.gstruct49_0[i].gstruct31_0 = null;
						bool flag7 = Form1.gstruct49_0[num].gstruct31_0 != null;
						if (flag7)
						{
							Form1.gstruct49_0[i].gstruct31_0 = new GStruct31[Form1.gstruct49_0[num].gstruct31_0.Length];
							for (int n = 0; n < Form1.gstruct49_0[num].gstruct31_0.Length; n++)
							{
								ref GStruct31 ptr = ref Form1.gstruct49_0[i].gstruct31_0[n];
								ptr = new GStruct31
								{
									string_0 = Form1.gstruct49_0[num].gstruct31_0[n].string_0,
									int_4 = Form1.gstruct49_0[num].gstruct31_0[n].int_4
								};
							}
						}
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonDong_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00139B00 File Offset: 0x00137D00
		public static void smethod_1()
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = !Form1.gstruct49_0[i].bool_25;
					if (!flag2)
					{
						for (int j = 0; j < 100; j++)
						{
							bool flag3 = FormClickNPC.int_7 <= 0;
							if (flag3)
							{
								break;
							}
							Thread.Sleep(1);
						}
						FormClickNPC.int_7 = Form1.gstruct49_0[i].int_136;
						new Thread(new ThreadStart(FormClickNPC.smethod_2)).Start();
					}
				}
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00139BB0 File Offset: 0x00137DB0
		public static void smethod_2()
		{
			int num = FormClickNPC.int_7;
			FormClickNPC.int_7 = 0;
			int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag = num2 < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num2];
				int num3 = 0;
				byte[] array = new byte[4];
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num7 = num6 + num5 * Class53.gstruct51_15.uint_0;
				uint[] uint_ = new uint[]
				{
					Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
					Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
				};
				uint uint_2 = gstruct.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct.int_137, uint_2, array, 4, ref num3);
				int num8 = BitConverter.ToInt32(array, 0);
				bool flag2 = num8 <= 1;
				if (!flag2)
				{
					int num9 = 0;
					uint num10 = 0U;
					long num11 = 0L;
					uint[] array2 = new uint[2];
					for (uint num12 = 1U; num12 < 256U; num12 += 1U)
					{
						bool flag3 = num8 <= num9;
						if (flag3)
						{
							break;
						}
						uint num13 = num6 + num12 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_16.uint_0, array, 4, ref num3);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num9++;
							Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_52.uint_0, array, 4, ref num3);
							uint num14 = BitConverter.ToUInt32(array, 0);
							bool flag5 = num14 == 3U;
							if (flag5)
							{
								uint[] array3 = new uint[2];
								Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num3);
								array3[0] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num3);
								array3[1] = BitConverter.ToUInt32(array, 0);
								long num15 = Class60.smethod_18(uint_, array3);
								bool flag6 = num10 == 0U || num15 < num11;
								if (flag6)
								{
									num11 = num15;
									array2[0] = array3[0];
									array2[1] = array3[1];
									num10 = num12;
								}
							}
						}
					}
					bool flag7 = num10 == 0U;
					if (!flag7)
					{
						for (int i = 0; i < 10; i++)
						{
							uint_ = new uint[]
							{
								Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							long num16 = Class60.smethod_18(uint_, array2);
							bool flag8 = num16 <= 11500L;
							if (flag8)
							{
								break;
							}
							Class70.smethod_61(gstruct, array2);
							Thread.Sleep(300);
						}
						array = BitConverter.GetBytes(num10);
						Class22.WriteProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_72.uint_0, array, 4, ref num3);
					}
				}
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00139F4C File Offset: 0x0013814C
		public static void smethod_3()
		{
			int int_ = FormClickNPC.int_8;
			FormClickNPC.int_8 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = num < 0;
					if (flag2)
					{
						break;
					}
					GStruct49 gstruct49_ = Form1.gstruct49_0[num];
					bool flag3 = !flag;
					if (flag3)
					{
						bool flag4 = Class70.smethod_3(gstruct49_, Class70.uint_48, 4) > 0;
						if (flag4)
						{
							break;
						}
						Class70.smethod_2(gstruct49_, Class70.uint_48, 1, 4);
						Class70.smethod_52(gstruct49_, "<color=green><bclr=blue>ClickNPC b¾t ®Çu...", 1);
						flag = true;
					}
					FormClickNPC.smethod_4(int_);
					Class70.smethod_2(gstruct49_, Class70.uint_48, 0, 4);
					Class70.smethod_52(gstruct49_, "<color=green><bclr=blue>ClickNPC kÕt thóc !", 1);
					break;
				}
				catch
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0013A024 File Offset: 0x00138224
		public static void smethod_4(int int_9)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			int i = 0;
			int num3 = 0;
			uint[] array = null;
			int num4 = -1;
			int num5 = 0;
			byte[] array2 = new byte[4];
			new byte[4];
			uint[] array3 = null;
			bool flag = true;
			long long_ = 0L;
			for (;;)
			{
				int num14;
				for (;;)
				{
					IL_46:
					num--;
					Thread.Sleep(10);
					bool flag2 = Class12.bool_0;
					if (flag2)
					{
						return;
					}
					bool flag3 = num <= 0;
					if (flag3)
					{
						int num6 = Class81.smethod_3(Form1.gstruct49_0, int_9);
						bool flag4 = num6 < 0 || !Form1.gstruct49_0[num6].bool_25;
						if (flag4)
						{
							return;
						}
						bool flag5 = Form1.gstruct49_0[num6].int_9 == null;
						if (flag5)
						{
							Form1.gstruct49_0[num6].int_9 = new int[]
							{
								2,
								1,
								1
							};
						}
						bool flag6 = Form1.gstruct49_0[num6].int_7 == null;
						if (flag6)
						{
							Form1.gstruct49_0[num6].int_7 = new int[]
							{
								0,
								3
							};
						}
						gstruct = Form1.gstruct49_0[num6];
						Class70.smethod_2(gstruct, Class70.uint_49, gstruct.int_10, 4);
						num = 15;
					}
					bool flag7 = Class70.smethod_3(gstruct, Class70.uint_48, 4) == 0;
					if (flag7)
					{
						return;
					}
					int num7 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					bool flag8 = num4 < 0;
					if (flag8)
					{
						num4 = num7;
					}
					else
					{
						bool flag9 = num4 != num7;
						if (flag9)
						{
							return;
						}
					}
					uint num8 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num9 = Class22.smethod_30(num8 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num10 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num11 = num10 + num9 * Class53.gstruct51_15.uint_0;
					int num12 = (int)Class22.smethod_30(num11 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num13 = Class83.smethod_39(gstruct);
					bool flag10 = num12 != 0 && num13 > 1;
					if (!flag10)
					{
						goto IL_742;
					}
					bool flag11 = Class83.smethod_12(gstruct) != 1;
					if (!flag11)
					{
						goto IL_735;
					}
					num14 = Class70.smethod_3(gstruct, Class70.uint_49, 4);
					bool flag13;
					bool flag12 = (flag13 = (gstruct.int_17[0] > 0 && gstruct.gstruct31_1.int_4 > 0 && gstruct.gstruct31_1.string_0 != null && gstruct.gstruct31_1.string_0 != string.Empty)) && !flag && gstruct.int_17[1] > 0;
					if (flag12)
					{
						bool flag14 = gstruct.string_15 != null && gstruct.string_15 != string.Empty;
						if (flag14)
						{
							uint num15 = Class12.smethod_12(gstruct.string_15);
							bool flag15 = num15 > 0U;
							if (flag15)
							{
								Class70.smethod_117(gstruct, num15);
								Thread.Sleep(100);
							}
						}
						uint num16 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
						long num17 = (long)((ulong)Class22.smethod_30(num16 + Class53.gstruct51_74.uint_0, gstruct.int_137));
						bool flag16 = num17 > 0L;
						if (flag16)
						{
							Class70.smethod_37(gstruct, (uint)num17);
						}
						flag = true;
					}
					bool flag17 = flag13 && gstruct.int_17[2] > 0 && gstruct.string_2 != null && gstruct.string_2 != string.Empty;
					if (flag17)
					{
						bool flag18 = true;
						bool flag19 = gstruct.int_17[3] > 0;
						if (flag19)
						{
							int num18 = Class79.smethod_31(gstruct, gstruct.gstruct31_1.string_0, 3, false, true);
							flag18 = (num18 <= gstruct.int_17[4]);
						}
						bool flag20 = flag18;
						if (flag20)
						{
							Class34.smethod_2(gstruct, gstruct.string_2, gstruct.gstruct31_1.string_0, gstruct.gstruct31_1.int_4);
						}
					}
					GStruct31[] array4 = null;
					bool flag21 = gstruct.int_16[0] > 0 && gstruct.int_16[1] > 0 && gstruct.gstruct31_0 != null;
					if (flag21)
					{
						array4 = new GStruct31[gstruct.gstruct31_0.Length];
						for (int j = 0; j < gstruct.gstruct31_0.Length; j++)
						{
							uint[] array5 = Class79.smethod_33(gstruct, gstruct.gstruct31_0[j].string_0, gstruct.gstruct31_0[j].int_4);
							bool flag22 = array5 != null;
							if (flag22)
							{
								ref GStruct31 ptr = ref array4[j];
								ptr = new GStruct31
								{
									string_0 = gstruct.gstruct31_0[j].string_0,
									uint_0 = array5[0],
									uint_1 = array5[1],
									uint_2 = array5[2],
									uint_3 = array5[3],
									uint_4 = array5[4],
									uint_5 = array5[5],
									int_4 = (int)array5[8],
									int_5 = (int)array5[9]
								};
							}
						}
					}
					bool flag23 = gstruct.int_13[0] > 0;
					if (flag23)
					{
						bool flag24 = gstruct.string_1 == null || gstruct.string_1 == string.Empty;
						if (flag24)
						{
							break;
						}
						bool flag25 = array3 != null;
						if (flag25)
						{
							string a = Class79.smethod_8(gstruct, array3[0], 0U, false, gstruct.string_1.Length + 4);
							bool flag26 = a != gstruct.string_1;
							if (flag26)
							{
								array3 = null;
							}
						}
						bool flag27 = array3 == null;
						if (flag27)
						{
							array3 = Class79.smethod_29(gstruct, gstruct.string_1, 3, false);
						}
						bool flag28 = array3 == null;
						if (flag28)
						{
							goto Block_40;
						}
					}
					bool flag29 = Form1.int_4 > 0;
					if (!flag29)
					{
						goto IL_730;
					}
					bool flag30 = gstruct.string_0 == null || gstruct.string_0 == string.Empty;
					if (flag30)
					{
						goto Block_44;
					}
					bool flag31 = num3 > 0;
					if (!flag31)
					{
						goto IL_6C8;
					}
					string a2 = Class98.smethod_16(gstruct, num3, ref array, gstruct.string_0.Length + 2);
					bool flag32 = a2 == gstruct.string_0;
					if (!flag32)
					{
						goto IL_6C8;
					}
					IL_1111:
					for (int k = 0; k < 30; k++)
					{
						bool flag33 = Class83.smethod_12(gstruct) != 1;
						if (!flag33)
						{
							goto IL_46;
						}
						uint[] uint_ = new uint[]
						{
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag34 = Class60.smethod_18(uint_, array) < 11500L;
						if (flag34)
						{
							break;
						}
						Class70.smethod_61(gstruct, array);
						Thread.Sleep(300);
					}
					goto IL_11CE;
					IL_6C8:
					num3 = Class98.smethod_15(gstruct, gstruct.string_0, ref array, 3, true, -1, null);
					bool flag35 = num3 <= 0;
					if (flag35)
					{
						goto Block_48;
					}
					goto IL_1111;
				}
				bool flag36 = Class12.smethod_28(long_) > 15000L;
				if (flag36)
				{
					Class70.smethod_52(gstruct, "<color=blue>=> ClickNPC: B¹n ch­a lÊy tªn vËt phÈm cÇn sö dông...", 1);
					long_ = Class12.smethod_27();
				}
				continue;
				Block_40:
				bool flag37 = Class12.smethod_28(long_) > 15000L;
				if (flag37)
				{
					Class70.smethod_52(gstruct, "<color=blue>=> ClickNPC: Kh«ng t×m thÊy vËt phÈm <" + gstruct.string_1 + ">...", 1);
					long_ = Class12.smethod_27();
				}
				continue;
				Block_44:
				bool flag38 = Class12.smethod_28(long_) > 15000L;
				if (flag38)
				{
					Class70.smethod_52(gstruct, "<color=blue>=> ClickNPC: b¹n ch­a lÊy tªn npc...", 1);
					long_ = Class12.smethod_27();
				}
				continue;
				Block_48:
				bool flag39 = Class12.smethod_28(long_) > 15000L;
				if (flag39)
				{
					Class70.smethod_52(gstruct, "<color=blue>=> ClickNPC: Kh«ng t×m thÊy npc <" + gstruct.string_0 + ">...", 1);
					long_ = Class12.smethod_27();
				}
				continue;
				IL_735:
				Thread.Sleep(100);
				continue;
				IL_742:
				num3 = 0;
				array3 = null;
				flag = false;
				continue;
				IL_10EB:
				int[] array6 = new int[2];
				int[] array7 = array6;
				bool flag40 = gstruct.int_15 > 0;
				if (flag40)
				{
					goto IL_F1E;
				}
				goto IL_750;
				IL_96E:
				bool flag41 = array7[0] <= 0;
				if (!flag41)
				{
					bool flag42 = array7[1] <= 0;
					if (flag42)
					{
						goto IL_750;
					}
					bool flag13;
					bool flag43 = flag13 && gstruct.int_17[2] <= 0;
					if (flag43)
					{
						bool flag44 = true;
						bool flag45 = gstruct.int_17[3] > 0;
						if (flag45)
						{
							int num19 = Class79.smethod_31(gstruct, gstruct.gstruct31_1.string_0, 3, false, true);
							flag44 = (num19 <= gstruct.int_17[4]);
						}
						bool flag46 = flag44;
						if (flag46)
						{
							while (i < 1000)
							{
								bool flag47 = Class45.smethod_8(gstruct);
								if (flag47)
								{
									break;
								}
								Thread.Sleep(1);
								i++;
							}
							FormClickNPC.smethod_5(gstruct, gstruct.gstruct31_1.string_0, gstruct.gstruct31_1.int_4);
						}
					}
					bool flag48 = gstruct.int_16[0] > 0 && gstruct.gstruct31_0 != null && Class45.smethod_8(gstruct);
					if (flag48)
					{
						uint num20 = 3U;
						uint num21 = 12U;
						for (int l = 0; l < gstruct.gstruct31_0.Length; l++)
						{
							string text = gstruct.gstruct31_0[l].string_0;
							int num22 = gstruct.gstruct31_0[l].int_4;
							int num23 = 0;
							bool flag49 = false;
							GStruct31[] array4;
							bool flag50 = array4 != null && l < array4.Length && array4[l].uint_0 != 0U && array4[l].string_0 == text && array4[l].int_4 <= num22;
							if (flag50)
							{
								while (!Class12.bool_0 && num23 <= 60)
								{
									uint uint_2 = array4[l].uint_4;
									uint uint_3 = array4[l].uint_5;
									uint[] array8 = Class79.smethod_26(gstruct, num21, uint_2, uint_3);
									bool flag51 = array8 == null;
									if (flag51)
									{
										break;
									}
									uint uint_4 = array4[l].uint_2;
									uint uint_5 = array4[l].uint_3;
									uint num8;
									uint num24 = num8 + Class53.gstruct51_97.uint_0;
									uint num25 = num24 + array4[l].uint_0 * 20U;
									i = 0;
									while (!Class12.bool_0)
									{
										Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num5);
										int num26 = (int)array2[0];
										bool flag52 = num26 > 0;
										if (flag52)
										{
											break;
										}
										bool flag53 = i % 30 == 0;
										if (flag53)
										{
											Class70.smethod_46(gstruct, uint_4, uint_5, num20, uint_4, uint_5, num20);
										}
										bool flag54 = i > 100;
										if (flag54)
										{
											break;
										}
										Thread.Sleep(10);
										i++;
									}
									i = 0;
									while (!Class12.bool_0)
									{
										Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num5);
										bool flag55 = array2[0] == 0;
										if (flag55)
										{
											break;
										}
										Class22.ReadProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num5);
										bool flag56 = BitConverter.ToInt32(array2, 0) == 0;
										if (flag56)
										{
											break;
										}
										bool flag57 = i % 30 == 0;
										if (flag57)
										{
											Class70.smethod_46(gstruct, array8[0], array8[1], num21, array8[0], array8[1], num21);
										}
										bool flag58 = i > 100;
										if (flag58)
										{
											break;
										}
										i++;
										Thread.Sleep(10);
									}
									Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num5);
									bool flag59 = array2[0] <= 0;
									if (!flag59)
									{
										Class70.smethod_46(gstruct, uint_4, uint_5, num20, uint_4, uint_5, num20);
										for (i = 0; i < 30; i++)
										{
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num5);
											bool flag60 = array2[0] == 0;
											if (flag60)
											{
												break;
											}
											Thread.Sleep(10);
										}
										break;
									}
									bool flag61 = num22 <= 1;
									if (flag61)
									{
										break;
									}
									int num27 = Class79.smethod_31(gstruct, text, (int)num21, true, true);
									bool flag62 = num22 <= num27;
									if (flag62)
									{
										break;
									}
									uint[] array9 = Class79.smethod_33(gstruct, text, num22 - num27);
									bool flag63 = array9 == null;
									if (flag63)
									{
										break;
									}
									array4[l].uint_0 = array9[0];
									array4[l].uint_1 = array9[1];
									array4[l].uint_2 = array9[2];
									array4[l].uint_3 = array9[3];
									array4[l].int_4 = (int)array9[8];
									array4[l].int_5 = (int)array9[9];
									num23++;
								}
								flag49 = true;
							}
							bool flag64 = !flag49;
							if (flag64)
							{
								Class45.smethod_17(gstruct, num20, num21, text, num22, true, false);
							}
						}
						Class45.smethod_13(gstruct, true);
						Thread.Sleep(300);
					}
					i = 0;
					while (Class86.Class89.smethod_4(gstruct) && i < 10)
					{
						Class22.smethod_4(gstruct.uint_4, 32U);
						Thread.Sleep(10);
						i++;
					}
					bool flag65 = Class86.smethod_1(gstruct, -1) > 0;
					if (flag65)
					{
						Class86.smethod_8(gstruct, num14);
					}
					bool flag66 = num2 < 2147483646;
					if (flag66)
					{
						num2++;
					}
					bool flag67 = gstruct.int_7[0] == 0 || num2 < gstruct.int_7[1];
					if (flag67)
					{
						continue;
					}
					break;
				}
				IL_F1E:
				array7[0] = 1;
				bool flag68 = Form1.int_4 > 0 && num3 > 0;
				if (flag68)
				{
					uint num11;
					Class22.WriteProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num3), 4, ref num5);
					Thread.Sleep(10);
					bool flag69 = gstruct.int_8 > 0;
					if (flag69)
					{
						i = 0;
						int num28 = 0;
						while (i < 1000 && Class86.smethod_0(gstruct) < 0)
						{
							i++;
							Thread.Sleep(1);
							bool flag70 = Class86.Class89.smethod_4(gstruct);
							if (flag70)
							{
								Class86.Class89.smethod_5(gstruct);
								num28 = -1;
							}
						}
						bool flag71 = num28 == 0 && Class86.Class89.smethod_4(gstruct);
						if (flag71)
						{
							Class86.Class89.smethod_5(gstruct);
						}
						bool flag72 = 0 <= Class86.smethod_0(gstruct) || Class86.smethod_1(gstruct, -1) > 0;
						if (flag72)
						{
							int num29 = num14 - i;
							bool flag73 = num29 < 10;
							if (flag73)
							{
								num29 = 10;
							}
							Thread.Sleep(1 + num29);
							for (int m = 0; m < gstruct.int_9.Length; m++)
							{
								bool flag74 = gstruct.int_9[m] > 0;
								if (flag74)
								{
									Class86.smethod_5(gstruct, gstruct.int_9[m] - 1);
									Thread.Sleep(1 + num14);
								}
							}
						}
					}
					i = 0;
					while (FormClickNPC.int_5 > 0 && FormClickNPC.int_6 > 0 && i < 1000)
					{
						bool flag75 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) == 0U;
						if (!flag75)
						{
							Class45.smethod_5(gstruct, FormClickNPC.int_6.ToString(), true);
							break;
						}
						Thread.Sleep(1);
						i++;
					}
				}
				else
				{
					num3 = 0;
				}
				goto IL_96E;
				IL_750:
				array7[1] = 1;
				bool flag76 = gstruct.int_13[0] > 0 && array3 != null;
				if (flag76)
				{
					Class70.smethod_43(gstruct, array3[0], (int)array3[2], (int)array3[3], 3);
					Thread.Sleep(10);
					bool flag77 = gstruct.int_14 != null;
					if (flag77)
					{
						i = 0;
						int num30 = 0;
						while (i < 1000 && Class86.smethod_0(gstruct) < 0)
						{
							i++;
							Thread.Sleep(1);
							bool flag78 = Class86.Class89.smethod_4(gstruct);
							if (flag78)
							{
								Class86.Class89.smethod_5(gstruct);
								num30 = -1;
							}
						}
						bool flag79 = num30 == 0 && Class86.Class89.smethod_4(gstruct);
						if (flag79)
						{
							Class86.Class89.smethod_5(gstruct);
						}
						bool flag80 = 0 <= Class86.smethod_0(gstruct) || Class86.smethod_1(gstruct, -1) > 0;
						if (flag80)
						{
							int num31 = num14 - i;
							bool flag81 = num31 < 10;
							if (flag81)
							{
								num31 = 10;
							}
							Thread.Sleep(1 + num31);
							for (int n = 0; n < gstruct.int_14.Length; n++)
							{
								bool flag82 = gstruct.int_14[n] > 0;
								if (flag82)
								{
									Class86.smethod_5(gstruct, gstruct.int_14[n] - 1);
									Thread.Sleep(1 + num14);
								}
							}
						}
						i = 0;
						bool flag83 = gstruct.int_13[1] <= 0;
						if (flag83)
						{
							bool flag84 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
							if (flag84)
							{
								Class45.smethod_5(gstruct, "0", true);
							}
						}
						else
						{
							bool flag85 = gstruct.int_13[2] <= 0;
							if (flag85)
							{
								gstruct.int_13[2] = 0;
							}
							while (i < 1000)
							{
								bool flag86 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) == 0U;
								if (!flag86)
								{
									Class45.smethod_5(gstruct, gstruct.int_13[2].ToString(), true);
									break;
								}
								Thread.Sleep(1);
								i++;
							}
						}
					}
				}
				else
				{
					array3 = null;
				}
				goto IL_96E;
				IL_11CE:
				IL_730:
				goto IL_10EB;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0013B20C File Offset: 0x0013940C
		public static void smethod_5(GStruct49 gstruct49_0, string string_1, int int_9)
		{
			int num = 0;
			int num2 = -1;
			string_1.Trim().ToUpper();
			int num3 = 0;
			bool flag = false;
			uint num4 = 0U;
			int num5 = 0;
			int num6 = 0;
			byte[] array = null;
			int num7 = 0;
			byte[] array2 = null;
			int num8;
			for (;;)
			{
				IL_3A2:
				num8 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
				bool flag2 = Class12.bool_0 || num8 < 0;
				if (flag2)
				{
					break;
				}
				gstruct49_0 = Form1.gstruct49_0[num8];
				bool flag3 = flag;
				if (flag3)
				{
					bool flag4 = !gstruct49_0.bool_8;
					if (flag4)
					{
						break;
					}
				}
				else
				{
					Form1.gstruct49_0[num8].bool_8 = true;
					flag = true;
				}
				int num9 = int_9 - Class79.smethod_32(gstruct49_0, string_1, false, 3U);
				bool flag5 = num9 <= 0;
				if (flag5)
				{
					break;
				}
				int num10 = Class79.smethod_25(gstruct49_0, 3U);
				bool flag6 = num10 <= 0;
				if (flag6)
				{
					break;
				}
				bool flag7 = num <= 0;
				int num11 = Class79.smethod_4(gstruct49_0);
				bool flag8;
				flag7 = (flag8 = (num9 <= 60));
				if (flag8)
				{
					goto IL_241;
				}
				num4 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
				goto IL_235;
				IL_354:
				try
				{
					num8 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
					bool flag9 = !Class12.bool_0 && num8 >= 0 && Form1.gstruct49_0[num8].bool_25;
					if (flag9)
					{
						goto IL_257;
					}
				}
				catch
				{
					goto IL_257;
				}
				break;
				IL_257:
				uint num12 = Class22.smethod_30(num4 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
				bool flag10 = num12 != 0U;
				if (flag10)
				{
					for (uint num13 = 0U; num13 < 2U; num13 += 1U)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + num13 * 4U, array, 4, ref num7);
						uint num14 = BitConverter.ToUInt32(array, 0);
						bool flag11 = num14 <= 0U;
						if (!flag11)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num14, array2, array2.Length, ref num7);
							string text = Class10.smethod_3(array2);
							bool flag12 = !(text != string.Empty);
							if (!flag12)
							{
								Class52.smethod_0(gstruct49_0);
								bool flag13 = Class12.smethod_1(text, "ho¶ng trèng") > 0;
								if (flag13)
								{
									goto IL_3A2;
								}
								bool flag14 = Class12.smethod_1(text, "kh«ng ®") > 0;
								if (flag14)
								{
									goto Block_9;
								}
								break;
							}
						}
					}
				}
				IL_1D0:
				for (;;)
				{
					num5++;
					bool flag15 = num5 >= num9;
					if (flag15)
					{
						break;
					}
					Class70.smethod_41(gstruct49_0, num2);
					Thread.Sleep(8 + Form1.int_112);
					bool flag16 = (num5 == 0 || num5 % 8 != 0) && num5 + 1 != num9;
					if (!flag16)
					{
						goto IL_226;
					}
				}
				continue;
				IL_226:
				num6 = Class79.smethod_4(gstruct49_0);
				bool flag17 = num6 == num11;
				if (flag17)
				{
					num3++;
					flag7 = (num3 <= 10);
					goto IL_241;
				}
				goto IL_235;
				goto IL_1D0;
				IL_235:
				num11 = num6;
				num3 = 0;
				goto IL_354;
				IL_241:
				bool flag18 = !flag7;
				if (flag18)
				{
					break;
				}
				goto IL_354;
			}
			goto IL_3AA;
			Block_9:
			int num15 = 0;
			Class70.smethod_2(gstruct49_0, Class70.uint_21, 3, 4);
			while (!Class12.bool_0 && Class70.smethod_3(gstruct49_0, Class70.uint_21, 4) == 3 && num15 < 3000)
			{
				Thread.Sleep(10);
				num15++;
			}
			IL_3AA:
			num8 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
			bool flag19 = 0 <= num8;
			if (flag19)
			{
				Form1.gstruct49_0[num8].bool_8 = false;
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0013B608 File Offset: 0x00139808
		private void checkBoxCoMuaVatpham_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_17[0] = (int)Convert.ToByte(this.checkBoxCoMuaVatpham.Checked);
				}
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0013B670 File Offset: 0x00139870
		private void textBoxSoluongMua_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !this.bool_2;
				if (!flag)
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].gstruct31_1.int_4 = Class12.smethod_11(this.textBoxSoluongMua.Text);
					}
				}
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0013B6E8 File Offset: 0x001398E8
		private void method_1(GStruct49 gstruct49_0, ComboBox comboBox_0)
		{
			this.bool_2 = false;
			this.string_0 = Class79.smethod_34(gstruct49_0, null, 0);
			comboBox_0.Items.Clear();
			bool flag = this.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < this.string_0.Length; i++)
				{
					string item = Class10.smethod_1(this.string_0[i], 1, false);
					comboBox_0.Items.Add(item);
				}
			}
			Thread.Sleep(10);
			this.bool_2 = true;
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0013B76C File Offset: 0x0013996C
		private void comboBoxMuaVP_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.method_1(Form1.gstruct49_0[num], this.comboBoxMuaVP);
				}
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0013B7CC File Offset: 0x001399CC
		private void comboBoxMuaVP_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_2 || this.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxMuaVP.Text;
					for (int i = 0; i < this.string_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(this.string_0[i], 1, false);
						if (flag3)
						{
							Form1.gstruct49_0[num].gstruct31_1.string_0 = this.string_0[i];
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0013B888 File Offset: 0x00139A88
		private void linkLabelMuaPhaohoa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = "https://youtu.be/qdrw1B2yHFc";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
			string string_ = "Xem video hướng dẫn tại: " + Class53.string_7 + text;
			FormTip.smethod_0(Form1.string_1, string_, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0013B8E0 File Offset: 0x00139AE0
		private void checkBoxRuthettien_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_17[1] = (int)Convert.ToByte(this.checkBoxRuthettien.Checked);
				}
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0013B948 File Offset: 0x00139B48
		private void checkBoxClickNpcNopVP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_16[0] = (int)Convert.ToByte(this.checkBoxClickNpcNopVP.Checked);
				}
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0013B9B0 File Offset: 0x00139BB0
		private void checkBoxMuaKTC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_17[2] = (int)Convert.ToByte(this.checkBoxMuaKTC.Checked);
				}
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0013BA18 File Offset: 0x00139C18
		private void comboBoxTabKTC_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_2 || FormClickNPC.struct23_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTabKTC.Text;
					for (int i = 0; i < FormClickNPC.struct23_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(FormClickNPC.struct23_0[i].string_0, 1, false);
						if (flag3)
						{
							Form1.gstruct49_0[num].string_2 = FormClickNPC.struct23_0[i].string_0;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0013BADC File Offset: 0x00139CDC
		private void comboBoxNop_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.method_1(Form1.gstruct49_0[num], this.comboBoxNop);
				}
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0013BB3C File Offset: 0x00139D3C
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_2 || this.string_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = null;
					string text2 = this.comboBoxNop.Text;
					for (int i = 0; i < this.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(this.string_0[i], 1, false);
						if (flag3)
						{
							text = this.string_0[i];
							break;
						}
					}
					bool flag4 = text != null && !(text == string.Empty);
					if (flag4)
					{
						int num2 = Class12.smethod_11(this.textBoxSoluongNop.Text);
						this.method_0(this.listView1, Class10.smethod_1(text, 1, false) + "|" + num2.ToString());
						bool flag5 = Form1.gstruct49_0[num].gstruct31_0 == null;
						if (flag5)
						{
							Form1.gstruct49_0[num].gstruct31_0 = new GStruct31[1];
						}
						else
						{
							Array.Resize<GStruct31>(ref Form1.gstruct49_0[num].gstruct31_0, Form1.gstruct49_0[num].gstruct31_0.Length + 1);
						}
						ref GStruct31 ptr = ref Form1.gstruct49_0[num].gstruct31_0[Form1.gstruct49_0[num].gstruct31_0.Length - 1];
						ptr = new GStruct31
						{
							string_0 = text,
							int_4 = num2
						};
					}
				}
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0013BCE8 File Offset: 0x00139EE8
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count == 0;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					bool flag3 = this.listView1.Items.Count != 0 && Form1.gstruct49_0[num].gstruct31_0 != null && Form1.gstruct49_0[num].gstruct31_0.Length == this.listView1.Items.Count;
					if (flag3)
					{
						int num2 = 0;
						int num3 = this.listView1.SelectedIndices[0];
						for (int i = 0; i < Form1.gstruct49_0[num].gstruct31_0.Length; i++)
						{
							bool flag4 = i != num3;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct31_0[num2].string_0 = Form1.gstruct49_0[num].gstruct31_0[i].string_0;
								Form1.gstruct49_0[num].gstruct31_0[num2].int_4 = Form1.gstruct49_0[num].gstruct31_0[i].int_4;
								num2++;
							}
						}
						bool flag5 = num2 != 0;
						if (flag5)
						{
							bool flag6 = num2 < Form1.gstruct49_0[num].gstruct31_0.Length;
							if (flag6)
							{
								Array.Resize<GStruct31>(ref Form1.gstruct49_0[num].gstruct31_0, num2);
								this.listView1.Items.RemoveAt(num3);
								bool flag7 = this.listView1.Items.Count <= num3 && num3 > 0;
								if (flag7)
								{
									num3 = this.listView1.Items.Count - 1;
								}
								this.listView1.Items[num3].Selected = true;
								this.listView1.Items[num3].Focused = true;
							}
						}
						else
						{
							this.listView1.Items.Clear();
							Form1.gstruct49_0[num].gstruct31_0 = null;
						}
					}
					else
					{
						this.listView1.Items.Clear();
						Form1.gstruct49_0[num].gstruct31_0 = null;
					}
				}
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0013BF60 File Offset: 0x0013A160
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count != 0;
			if (flag)
			{
				int index = this.listView1.SelectedIndices[0];
				string text = this.listView1.Items[index].SubItems[0].Text;
				this.comboBoxNop.Items.Clear();
				this.comboBoxNop.Items.Add(text);
				this.comboBoxNop.Text = text;
				this.textBoxSoluongNop.Text = this.listView1.Items[index].SubItems[1].Text;
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0013C01C File Offset: 0x0013A21C
		private void buttonSuaNopVP_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count == 0;
			if (!flag)
			{
				int num = this.listView1.SelectedIndices[0];
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num2 < 0 || Form1.gstruct49_0[num2].gstruct31_0 == null || Form1.gstruct49_0[num2].gstruct31_0.Length <= num;
				if (!flag2)
				{
					string a = Class10.smethod_1(Form1.gstruct49_0[num2].gstruct31_0[num].string_0, 1, false);
					bool flag3 = a != this.listView1.Items[num].SubItems[0].Text;
					if (!flag3)
					{
						int num3 = Class12.smethod_11(this.textBoxSoluongNop.Text);
						Form1.gstruct49_0[num2].gstruct31_0[num].int_4 = num3;
						this.listView1.Items[num].SubItems[1].Text = num3.ToString();
						string text = null;
						string text2 = this.comboBoxNop.Text;
						bool flag4 = this.string_0 != null;
						if (flag4)
						{
							for (int i = 0; i < this.string_0.Length; i++)
							{
								bool flag5 = text2 == Class10.smethod_1(this.string_0[i], 1, false);
								if (flag5)
								{
									text = this.string_0[i];
									break;
								}
							}
						}
						bool flag6 = text != null;
						if (flag6)
						{
							Form1.gstruct49_0[num2].gstruct31_0[num].string_0 = text;
							this.listView1.Items[num].SubItems[0].Text = text2;
						}
					}
				}
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0013C20C File Offset: 0x0013A40C
		private void checkBoxTach_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_16[1] = (int)Convert.ToByte(this.checkBoxTach.Checked);
				}
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0013C274 File Offset: 0x0013A474
		private void checkBoxMuaKhiHet_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_17[3] = (int)Convert.ToByte(this.checkBoxMuaKhiHet.Checked);
				}
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0013C2DC File Offset: 0x0013A4DC
		private void textBoxMuaKhicon_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_17[4] = Class12.smethod_11(this.textBoxMuaKhicon.Text);
				}
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0013C344 File Offset: 0x0013A544
		private void checkBoxCoNhapSL_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_13[1] = (int)Convert.ToByte(this.checkBoxCoNhapSL.Checked);
				}
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0013C3AC File Offset: 0x0013A5AC
		private void textBoxCoNhapSL_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_2;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormClickNPC.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_13[2] = Class12.smethod_11(this.textBoxCoNhapSL.Text);
				}
			}
		}

		// Token: 0x04000802 RID: 2050
		private IContainer icontainer_0 = null;

		// Token: 0x04000825 RID: 2085
		public static bool bool_0 = false;

		// Token: 0x04000826 RID: 2086
		public static int int_0 = 0;

		// Token: 0x04000827 RID: 2087
		public int int_1;

		// Token: 0x04000828 RID: 2088
		public int int_2;

		// Token: 0x04000829 RID: 2089
		public int int_3;

		// Token: 0x0400082A RID: 2090
		public int int_4;

		// Token: 0x0400082B RID: 2091
		public static int int_5 = Class62.smethod_3("fNhapSoluongClickNPC", 0, "0");

		// Token: 0x0400082C RID: 2092
		public static int int_6 = Class62.smethod_3("iNhapSoluongClickNPC", 0, "3");

		// Token: 0x0400082D RID: 2093
		private bool bool_1 = false;

		// Token: 0x0400082E RID: 2094
		private bool bool_2 = false;

		// Token: 0x0400082F RID: 2095
		private string[] string_0 = null;

		// Token: 0x04000830 RID: 2096
		private static Struct23[] struct23_0 = null;

		// Token: 0x04000831 RID: 2097
		public static int int_7 = 0;

		// Token: 0x04000833 RID: 2099
		public static int int_8 = 0;
	}
}
