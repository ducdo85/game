using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000061 RID: 97
	public partial class Combo : Form
	{
		// Token: 0x06000580 RID: 1408 RVA: 0x000F15F0 File Offset: 0x000EF7F0
		public Combo()
		{
			Combo.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000F1644 File Offset: 0x000EF844
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000F2A3F File Offset: 0x000F0C3F
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_0(false);
			GClass0.smethod_1();
			GClass0.smethod_0();
			Combo.bool_0 = false;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000F2A5C File Offset: 0x000F0C5C
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !Combo.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000F2A80 File Offset: 0x000F0C80
		private void Combo_Load(object sender, EventArgs e)
		{
			bool flag = this.int_0 > 0 && this.int_1 > 0;
			if (flag)
			{
				int num = this.int_0 - base.Width - 2;
				int num2 = this.int_1 + this.int_3 - base.Height;
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
			bool flag4 = this.gstruct49_0.int_136 <= 0;
			if (flag4)
			{
				this.method_12("COMBO NHOI THUOC");
				this.buttonApdung.Enabled = false;
			}
			else
			{
				this.method_12("COMBO NHOI THUOC [ " + Class10.smethod_1(this.gstruct49_0.string_22, 1, false) + " ]");
				this.buttonApdung.Enabled = true;
			}
			this.numericUpDown2.Value = Combo.int_4;
			this.comboBoxThuoc.Items.Clear();
			this.method_3(this.gstruct49_0.gstruct42_0);
			this.method_1(this.gstruct49_0.gstruct42_0);
			this.method_2(Class27.gstruct40_1, this.gstruct49_0.gstruct42_0);
			this.checkBoxDungchung.Checked = (Combo.int_5 > 0);
			this.checkBoxPhiChiendau.Checked = (Combo.int_6 > 0);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000F2C14 File Offset: 0x000F0E14
		private bool method_0(bool bool_1 = false)
		{
			bool flag = Form1.gstruct49_0 == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = !bool_1;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = Form1.gstruct49_0[i].int_136 == this.gstruct49_0.int_136;
						if (flag3)
						{
							Form1.gstruct49_0[i].gstruct42_0 = this.gstruct49_0.gstruct42_0;
							Class53.smethod_13(Form1.gstruct49_0[i], null);
							break;
						}
					}
				}
				else
				{
					for (int j = 0; j < Form1.gstruct49_0.Length; j++)
					{
						Form1.gstruct49_0[j].gstruct42_0 = this.gstruct49_0.gstruct42_0;
						Class53.smethod_13(Form1.gstruct49_0[j], null);
					}
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x000F2D04 File Offset: 0x000F0F04
		private void method_1(GStruct42[] gstruct42_0)
		{
			bool flag = gstruct42_0 != null && gstruct42_0[0].gstruct41_0 != null;
			if (flag)
			{
				Combo.string_0 = null;
				for (int i = 0; i < gstruct42_0[0].gstruct41_0.Length; i++)
				{
					Class12.smethod_29(ref Combo.string_0, gstruct42_0[0].gstruct41_0[i].string_0);
					this.comboBoxThuoc.Items.Add(Class10.smethod_1(gstruct42_0[0].gstruct41_0[i].string_0, 1, false));
				}
				this.comboBoxThuoc.Text = Class10.smethod_1(gstruct42_0[0].gstruct41_0[0].string_0, 1, false);
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000F2DD0 File Offset: 0x000F0FD0
		private void method_2(GStruct40[] gstruct40_0, GStruct42[] gstruct42_0)
		{
			bool flag = gstruct40_0 == null;
			if (!flag)
			{
				string text = null;
				for (int i = 0; i < gstruct40_0.GetLength(0); i++)
				{
					bool flag2 = true;
					bool flag3 = gstruct42_0 != null;
					if (flag3)
					{
						for (int j = 0; j < gstruct42_0.Length; j++)
						{
							bool flag4 = gstruct40_0[i].int_0 == gstruct42_0[j].int_0;
							if (flag4)
							{
								flag2 = false;
								break;
							}
						}
					}
					bool flag5 = flag2;
					if (flag5)
					{
						bool flag6 = text == null;
						if (flag6)
						{
							text = gstruct40_0[i].string_0;
						}
						this.comboBoxPhim.Items.Add(gstruct40_0[i].string_0);
					}
				}
				bool flag7 = text != null;
				if (flag7)
				{
					this.comboBoxPhim.Text = text;
				}
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x000F2EB0 File Offset: 0x000F10B0
		private void method_3(GStruct42[] gstruct42_0)
		{
			Combo.int_7 = -1;
			bool flag = gstruct42_0 == null;
			if (!flag)
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					string text = Class27.smethod_1(Class27.gstruct40_1, gstruct42_0[i].int_0);
					this.listView1.Items.Add(new ListViewItem(text));
				}
				Combo.int_7 = 0;
				GStruct41[] gstruct41_ = gstruct42_0[0].gstruct41_0;
				bool flag2 = gstruct41_ != null;
				if (flag2)
				{
					for (int j = 0; j < gstruct41_.Length; j++)
					{
						this.method_4(Class10.smethod_1(gstruct41_[j].string_0, 1, false), gstruct41_[j].int_0);
					}
					this.listView1.Items[0].Focused = true;
					this.listView1.Items[0].Selected = true;
					this.listView2.Items[0].Focused = true;
					this.listView2.Items[0].Selected = true;
				}
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000F2FDC File Offset: 0x000F11DC
		private void method_4(string string_1, int int_8)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem(string_1);
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, int_8.ToString()));
				this.listView2.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000F3038 File Offset: 0x000F1238
		private void method_5(bool bool_1 = true)
		{
			int num = this.method_6(this.listView1);
			this.labelThemThuoc.Enabled = (num >= 0);
			this.labelXoaPhim.Enabled = (num >= 0);
			bool flag = num < 0 || (bool_1 && num == Combo.int_7);
			if (flag)
			{
				Combo.int_7 = num;
			}
			else
			{
				int num2 = Class27.smethod_0(Class27.gstruct40_1, this.listView1.Items[num].SubItems[0].Text);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					int num3 = Combo.smethod_1(this.gstruct49_0.gstruct42_0, num2);
					bool flag3 = num3 < 0;
					if (!flag3)
					{
						Combo.int_7 = num;
						GStruct42 gstruct = this.gstruct49_0.gstruct42_0[num3];
						this.listView2.Items.Clear();
						bool flag4 = gstruct.gstruct41_0 != null;
						if (flag4)
						{
							for (int i = 0; i < gstruct.gstruct41_0.Length; i++)
							{
								this.method_4(Class10.smethod_1(gstruct.gstruct41_0[i].string_0, 1, false), gstruct.gstruct41_0[i].int_0);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x000F3188 File Offset: 0x000F1388
		private int method_6(ListView listView_0)
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

		// Token: 0x0600058D RID: 1421 RVA: 0x000F31E4 File Offset: 0x000F13E4
		public static int smethod_0(ListView listView_0, MouseEventArgs mouseEventArgs_0, int int_8 = 0)
		{
			ListViewItem itemAt = listView_0.GetItemAt(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			bool flag = itemAt != null;
			if (flag)
			{
				string text = itemAt.SubItems[int_8].Text;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					string text2 = listView_0.Items[i].SubItems[int_8].Text;
					bool flag2 = text == text2;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000F3278 File Offset: 0x000F1478
		private static int smethod_1(GStruct42[] gstruct42_0, int int_8)
		{
			bool flag = gstruct42_0 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					bool flag2 = int_8 == gstruct42_0[i].int_0;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000F32C4 File Offset: 0x000F14C4
		private static int smethod_2(GStruct41[] gstruct41_0, string string_1)
		{
			bool flag = gstruct41_0 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct41_0.Length; i++)
				{
					bool flag2 = string_1 == gstruct41_0[i].string_0 || Class10.smethod_1(string_1, 1, false) == gstruct41_0[i].string_0 || string_1 == Class10.smethod_1(gstruct41_0[i].string_0, 1, false);
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000F334C File Offset: 0x000F154C
		private void method_7(ref GStruct42[] gstruct42_0, string string_1)
		{
			int num = Class27.smethod_0(Class27.gstruct40_1, string_1);
			bool flag = num < 0 || gstruct42_0 == null || gstruct42_0.Length == 0;
			if (!flag)
			{
				int num2 = 0;
				GStruct42[] array = new GStruct42[gstruct42_0.Length];
				for (int i = 0; i < gstruct42_0.Length; i++)
				{
					bool flag2 = gstruct42_0[i].int_0 != num;
					if (flag2)
					{
						ref GStruct42 ptr = ref array[num2];
						ptr = gstruct42_0[i];
						num2++;
					}
				}
				bool flag3 = num2 == 0;
				if (flag3)
				{
					gstruct42_0 = null;
				}
				else
				{
					GStruct42[] array2 = new GStruct42[num2];
					for (int j = 0; j < num2; j++)
					{
						ref GStruct42 ptr2 = ref array2[j];
						ptr2 = array[j];
					}
					gstruct42_0 = array2;
				}
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000F3430 File Offset: 0x000F1630
		private void method_8(ref GStruct42[] gstruct42_0, string string_1)
		{
			GStruct42 gstruct = new GStruct42
			{
				int_0 = Class27.smethod_0(Class27.gstruct40_1, string_1),
				gstruct41_0 = null
			};
			bool flag = gstruct42_0 != null && gstruct42_0.Length != 0;
			if (flag)
			{
				GStruct42[] array = new GStruct42[gstruct42_0.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < gstruct42_0.Length;
					if (!flag2)
					{
						goto IL_9C;
					}
					ref GStruct42 ptr = ref array[num];
					ptr = gstruct42_0[num];
					bool flag3 = gstruct42_0[num].int_0 != gstruct.int_0;
					if (!flag3)
					{
						break;
					}
					num++;
				}
				goto IL_B2;
				IL_9C:
				array[array.Length - 1] = gstruct;
				gstruct42_0 = array;
				IL_B2:;
			}
			else
			{
				gstruct42_0 = new GStruct42[]
				{
					gstruct
				};
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x000F3504 File Offset: 0x000F1704
		private void method_9(ref GStruct41[] gstruct41_0, string string_1, int int_8)
		{
			GStruct41 gstruct = new GStruct41
			{
				string_0 = string_1,
				int_0 = int_8
			};
			bool flag = gstruct41_0 == null || gstruct41_0.Length == 0;
			if (flag)
			{
				gstruct41_0 = new GStruct41[]
				{
					gstruct
				};
			}
			else
			{
				GStruct41[] array = new GStruct41[gstruct41_0.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < gstruct41_0.Length;
					if (!flag2)
					{
						goto IL_A3;
					}
					ref GStruct41 ptr = ref array[num];
					ptr = gstruct41_0[num];
					bool flag3 = !(gstruct41_0[num].string_0 == string_1) || string_1 == null;
					if (!flag3)
					{
						break;
					}
					num++;
				}
				return;
				IL_A3:
				array[array.Length - 1] = gstruct;
				gstruct41_0 = array;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000F35CC File Offset: 0x000F17CC
		private void method_10(ref GStruct41[] gstruct41_0, string string_1)
		{
			bool flag = string_1 == null || string_1 == "";
			if (!flag)
			{
				int num = 0;
				GStruct41[] array = new GStruct41[gstruct41_0.Length];
				for (int i = 0; i < gstruct41_0.Length; i++)
				{
					bool flag2 = !(gstruct41_0[i].string_0 == string_1) && !(Class10.smethod_1(gstruct41_0[i].string_0, 1, false) == string_1) && !(gstruct41_0[i].string_0 == Class10.smethod_1(string_1, 1, false));
					if (flag2)
					{
						ref GStruct41 ptr = ref array[num];
						ptr = gstruct41_0[i];
						num++;
					}
				}
				bool flag3 = num == 0;
				if (flag3)
				{
					gstruct41_0 = null;
				}
				else
				{
					GStruct41[] array2 = new GStruct41[num];
					for (int j = 0; j < num; j++)
					{
						ref GStruct41 ptr2 = ref array2[j];
						ptr2 = array[j];
					}
					gstruct41_0 = array2;
				}
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000F36E8 File Offset: 0x000F18E8
		private void comboBoxThuoc_MouseDown(object sender, MouseEventArgs e)
		{
			string text = this.comboBoxThuoc.Text;
			string text2 = null;
			this.comboBoxThuoc.Items.Clear();
			bool flag = this.gstruct49_0.int_136 == 0 || !Class22.smethod_51(this.gstruct49_0.int_136);
			if (flag)
			{
				bool flag2 = this.gstruct49_0.int_136 > 0;
				if (flag2)
				{
					this.buttonApdung.Enabled = false;
					this.gstruct49_0.int_136 = 0;
				}
			}
			else
			{
				Combo.string_0 = Class79.smethod_34(this.gstruct49_0, null, 3);
				bool flag3 = Combo.string_0 != null;
				if (flag3)
				{
					Array.Sort<string>(Combo.string_0);
					for (int i = 0; i < Combo.string_0.Length; i++)
					{
						string text3 = Class10.smethod_1(Combo.string_0[i], 1, false);
						this.comboBoxThuoc.Items.Add(text3);
						bool flag4 = text2 == null || text3 == text;
						if (flag4)
						{
							text2 = text;
						}
					}
				}
				bool flag5 = text2 != null;
				if (flag5)
				{
					this.comboBoxThuoc.Text = text2;
				}
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x000F380C File Offset: 0x000F1A0C
		private void listView1_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Combo.smethod_0(this.listView1, e, 0);
			this.labelThemThuoc.Enabled = (num >= 0);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000F383B File Offset: 0x000F1A3B
		private void listView1_MouseClick(object sender, MouseEventArgs e)
		{
			this.method_5(true);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000F3848 File Offset: 0x000F1A48
		private void listView2_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Combo.smethod_0(this.listView2, e, 0);
			this.labelXoaThuoc.Enabled = (num >= 0);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000F3878 File Offset: 0x000F1A78
		private void listView2_MouseClick(object sender, MouseEventArgs e)
		{
			int num = this.method_6(this.listView2);
			this.labelXoaThuoc.Enabled = (num >= 0);
			bool flag = num >= 0;
			if (flag)
			{
				this.comboBoxThuoc.Text = this.listView2.Items[num].SubItems[0].Text;
				this.numericUpDown1.Value = Class12.smethod_11(this.listView2.Items[num].SubItems[1].Text);
			}
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x000F3918 File Offset: 0x000F1B18
		private void method_11()
		{
			int num = this.method_6(this.listView2);
			bool flag = num < 0 || Combo.int_7 < 0 || Combo.int_7 >= this.listView1.Items.Count;
			if (!flag)
			{
				int num2 = Class27.smethod_0(Class27.gstruct40_1, this.listView1.Items[Combo.int_7].SubItems[0].Text);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					int num3 = Combo.smethod_1(this.gstruct49_0.gstruct42_0, num2);
					bool flag3 = num3 >= 0;
					if (flag3)
					{
						int num4 = Combo.smethod_2(this.gstruct49_0.gstruct42_0[num3].gstruct41_0, this.listView2.Items[num].SubItems[0].Text);
						bool flag4 = num4 >= 0;
						if (flag4)
						{
							this.listView2.Items[num].SubItems[1].Text = this.numericUpDown1.Value.ToString();
							this.gstruct49_0.gstruct42_0[num3].gstruct41_0[num4].int_0 = (int)this.numericUpDown1.Value;
						}
					}
				}
			}
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x000F3A7E File Offset: 0x000F1C7E
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.method_11();
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000F3A7E File Offset: 0x000F1C7E
		private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
		{
			this.method_11();
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000F3A88 File Offset: 0x000F1C88
		private void numericUpDown2_KeyUp(object sender, KeyEventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Combo.int_4 = (int)this.numericUpDown2.Value;
				Class62.smethod_10(Class53.string_3, "flagTileBom", Combo.int_4, "", 0);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000F3ADC File Offset: 0x000F1CDC
		private void numericUpDown2_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Combo.int_4 = (int)this.numericUpDown2.Value;
				Class62.smethod_10(Class53.string_3, "flagBomDelay", Combo.int_4, "", 0);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000F3B30 File Offset: 0x000F1D30
		private void buttonApdung_Click(object sender, EventArgs e)
		{
			string string_ = (!this.method_0(false)) ? ("Lưu cấu hình thất bại (không tồn tại " + Class10.smethod_1(this.gstruct49_0.string_22, 1, false) + ").") : (Class10.smethod_1(this.gstruct49_0.string_22, 1, false) + ": đã lưu cấu hình combo.");
			GClass0.smethod_1();
			GClass0.smethod_0();
			Class12.smethod_29(ref Class12.string_16, string_);
			base.Close();
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000F3BA8 File Offset: 0x000F1DA8
		private void buttonXoaFilecauhinh_Click(object sender, EventArgs e)
		{
			Class12.smethod_49(Class53.string_11, "*.*");
			this.gstruct49_0.gstruct42_0 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].gstruct42_0 = null;
				}
			}
			this.comboBoxPhim.Items.Clear();
			bool flag2 = Class27.gstruct40_1 != null;
			if (flag2)
			{
				for (int j = 0; j < Class27.gstruct40_1.Length; j++)
				{
					this.comboBoxPhim.Items.Add(Class27.gstruct40_1[j].string_0);
				}
				this.comboBoxPhim.Text = Class27.gstruct40_1[0].string_0;
			}
			this.listView1.Items.Clear();
			this.listView2.Items.Clear();
			this.labelStatus.Text = "Đã xóa cấu hình combo của tất cả nhân vật.";
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000F3CB8 File Offset: 0x000F1EB8
		private void checkBoxDungchung_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Combo.int_5 = (int)Convert.ToByte(this.checkBoxDungchung.Checked);
				Class62.smethod_10(Class53.string_3, "flagBomChungThuoc", Combo.int_5, "", 0);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x000F3D0C File Offset: 0x000F1F0C
		private void labelThemThuoc_Click(object sender, EventArgs e)
		{
			bool flag = Combo.string_0 == null;
			if (!flag)
			{
				string text = this.comboBoxThuoc.Text;
				bool flag2 = text == "" || Combo.int_7 < 0 || Combo.int_7 >= this.listView1.Items.Count;
				if (flag2)
				{
					this.labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
				}
				else
				{
					int num = Class27.smethod_0(Class27.gstruct40_1, this.listView1.Items[Combo.int_7].SubItems[0].Text);
					bool flag3 = num >= 0;
					if (flag3)
					{
						int num2 = Combo.smethod_1(this.gstruct49_0.gstruct42_0, num);
						bool flag4 = num2 < 0;
						if (flag4)
						{
							this.labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
						}
						else
						{
							bool flag5 = this.listView2.Items.Count > 0;
							if (flag5)
							{
								for (int i = 0; i < this.listView2.Items.Count; i++)
								{
									bool flag6 = text == this.listView2.Items[i].SubItems[0].Text;
									if (flag6)
									{
										return;
									}
								}
							}
							string text2 = null;
							for (int j = 0; j < Combo.string_0.Length; j++)
							{
								bool flag7 = text == Class10.smethod_1(Combo.string_0[j], 1, false);
								if (flag7)
								{
									text2 = Combo.string_0[j];
									break;
								}
							}
							bool flag8 = text2 != null;
							if (flag8)
							{
								int int_ = (int)this.numericUpDown1.Value;
								this.method_4(Class10.smethod_1(text2, 1, false), int_);
								this.method_9(ref this.gstruct49_0.gstruct42_0[num2].gstruct41_0, text2, int_);
							}
						}
					}
					else
					{
						this.labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
					}
				}
			}
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x000F3F20 File Offset: 0x000F2120
		private void labelXoaThuoc_Click(object sender, EventArgs e)
		{
			int num = this.method_6(this.listView2);
			bool flag = num < 0 || Combo.int_7 < 0 || Combo.int_7 >= this.listView1.Items.Count;
			if (!flag)
			{
				int num2 = Class27.smethod_0(Class27.gstruct40_1, this.listView1.Items[Combo.int_7].SubItems[0].Text);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					int num3 = Combo.smethod_1(this.gstruct49_0.gstruct42_0, num2);
					bool flag3 = num3 >= 0;
					if (flag3)
					{
						this.method_10(ref this.gstruct49_0.gstruct42_0[num3].gstruct41_0, this.listView2.Items[num].SubItems[0].Text);
						this.listView2.Items.RemoveAt(num);
						this.labelXoaThuoc.Enabled = (this.listView2.Items.Count > 0);
					}
				}
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x000F4040 File Offset: 0x000F2240
		private void labelXoaPhim_Click(object sender, EventArgs e)
		{
			int num = this.method_6(this.listView1);
			bool flag = num < 0;
			if (!flag)
			{
				string text = this.listView1.Items[num].SubItems[0].Text;
				this.listView1.Items.RemoveAt(num);
				this.method_7(ref this.gstruct49_0.gstruct42_0, text);
				bool flag2 = num > this.listView1.Items.Count - 1;
				if (flag2)
				{
					num = this.listView1.Items.Count - 1;
				}
				this.labelXoaThuoc.Enabled = (num >= 0);
				bool flag3 = num < 0;
				if (flag3)
				{
					this.listView2.Items.Clear();
				}
				else
				{
					this.listView1.Items[num].Selected = true;
					this.listView1.Items[num].Focused = true;
					this.method_5(false);
				}
				Combo.int_7 = num;
				int num2 = 0;
				for (;;)
				{
					bool flag4 = num2 < this.comboBoxPhim.Items.Count;
					if (!flag4)
					{
						goto IL_156;
					}
					bool flag5 = !(text == this.comboBoxPhim.Items[num2].ToString());
					if (!flag5)
					{
						break;
					}
					num2++;
				}
				return;
				IL_156:
				this.comboBoxPhim.Items.Add(text);
				this.comboBoxPhim.Sorted = true;
				bool flag6 = this.comboBoxPhim.Text == "";
				if (flag6)
				{
					this.comboBoxPhim.Text = text;
				}
				this.labelXoaPhim.Enabled = (this.listView1.Items.Count > 0);
				this.labelThemThuoc.Enabled = (Combo.int_7 >= 0);
			}
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000F422C File Offset: 0x000F242C
		private void buttonTaoPhim_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxPhim.Text;
			bool flag = text == "";
			if (!flag)
			{
				bool flag2 = this.listView1.Items.Count > 0;
				if (flag2)
				{
					for (int i = 0; i < this.listView1.Items.Count; i++)
					{
						bool flag3 = text == this.listView1.Items[i].SubItems[0].Text;
						if (flag3)
						{
							return;
						}
					}
				}
				this.listView1.Items.Add(new ListViewItem(text));
				this.method_8(ref this.gstruct49_0.gstruct42_0, text);
				for (int j = 0; j < this.comboBoxPhim.Items.Count; j++)
				{
					bool flag4 = text == this.comboBoxPhim.Items[j].ToString();
					if (flag4)
					{
						this.comboBoxPhim.Items.RemoveAt(j);
						bool flag5 = j >= this.comboBoxPhim.Items.Count;
						if (flag5)
						{
							j = this.comboBoxPhim.Items.Count - 1;
						}
						bool flag6 = j >= 0;
						if (flag6)
						{
							this.comboBoxPhim.Text = this.comboBoxPhim.Items[j].ToString();
						}
						break;
					}
				}
				this.labelXoaPhim.Enabled = (this.listView1.Items.Count > 0);
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000F43DC File Offset: 0x000F25DC
		private void buttonPhimHuongdan_Click(object sender, EventArgs e)
		{
			string string_ = "https://www.youtube.com/watch?v=1duqVxbJRKk";
			Class22.smethod_40(Class62.smethod_0(), "", string_, 0, false, false);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000F4404 File Offset: 0x000F2604
		private void labelTile_Click(object sender, EventArgs e)
		{
			string string_ = "Tỉ lệ bơm thuốc:|Giả sử ac thao tác để bơm Ngũ Hoa 10 bình, Cửu chuyển 10 bình thì:||Ví dụ tỉ lệ 1/2 (1 chia 2 = 0,50 => Số dư 0):|- Ac thao tác bơm đúng 10 bình Ngũ Hoa và 10 bình Cửu chuyển.|- Các ac còn lại bơm theo tỉ lệ 1/2 (tức 0,5) nên sẽ bơm 5 bình Ngũ Hoa và 5 bình Cửu chuyển.||Ví dụ tỉ lệ 1/3 (1 chia 3 = 0,33 => Số dư 3 > 0):|- Ac thao tác bơm đúng 10 bình Ngũ Hoa và 10 bình Cửu chuyển.|- Do số dư > 0 nên ac thao tác sẽ bơm với số lượng + 1, tức sẽ bơm 4 bình ngũ hoa và 4 bình Cửu chuyển.||Lưu ý: ac thao tác là ac trên cửa sổ game mà bạn đang cầm chuột điều khiển, bất kể đó là ac chính hay ac phụ cũng được. Khi combo, ac đang ở trong thành thì sẽ không bơm thuốc.";
			FormTip.smethod_0("BOM THUOC", string_, 600000, 420, 250, false, -1, -1, false, false, false);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x000F443C File Offset: 0x000F263C
		private void checkBoxPhiChiendau_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Combo.int_6 = (int)Convert.ToByte(this.checkBoxPhiChiendau.Checked);
				Class62.smethod_10(Class53.string_3, "flagPhiCD", Combo.int_6, "", 0);
			}
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x000F4490 File Offset: 0x000F2690
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = Combo.string_0 == null;
			if (!flag)
			{
				string text = this.comboBoxThuoc.Text;
				bool flag2 = text == "" || Combo.int_7 < 0 || Combo.int_7 >= this.listView1.Items.Count;
				if (flag2)
				{
					this.labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
				}
				else
				{
					int num = Class27.smethod_0(Class27.gstruct40_1, this.listView1.Items[Combo.int_7].SubItems[0].Text);
					bool flag3 = num < 0;
					if (flag3)
					{
						this.labelStatus.Text = "Hãy chọn phím bơm và chọn tên thuốc rồi bấm nút thêm.";
					}
					else
					{
						int num2 = Class81.smethod_3(Form1.gstruct49_0, this.gstruct49_0.int_136);
						bool flag4 = num2 < 0 || Form1.gstruct49_0 == null;
						if (!flag4)
						{
							for (int i = 0; i < Form1.gstruct49_0.Length; i++)
							{
								bool flag5 = Form1.gstruct49_0[i].int_136 == this.gstruct49_0.int_136;
								if (!flag5)
								{
									Form1.gstruct49_0[i].gstruct42_0 = null;
									bool flag6 = this.gstruct49_0.gstruct42_0 != null;
									if (flag6)
									{
										Form1.gstruct49_0[i].gstruct42_0 = new GStruct42[this.gstruct49_0.gstruct42_0.GetLength(0)];
										for (int j = 0; j < this.gstruct49_0.gstruct42_0.Length; j++)
										{
											Form1.gstruct49_0[i].gstruct42_0[j].int_0 = this.gstruct49_0.gstruct42_0[j].int_0;
											Form1.gstruct49_0[i].gstruct42_0[j].gstruct41_0 = null;
											bool flag7 = this.gstruct49_0.gstruct42_0[j].gstruct41_0 != null;
											if (flag7)
											{
												Form1.gstruct49_0[i].gstruct42_0[j].gstruct41_0 = new GStruct41[this.gstruct49_0.gstruct42_0[j].gstruct41_0.Length];
												for (int k = 0; k < this.gstruct49_0.gstruct42_0[j].gstruct41_0.GetLength(0); k++)
												{
													Form1.gstruct49_0[i].gstruct42_0[j].gstruct41_0[k].string_0 = this.gstruct49_0.gstruct42_0[j].gstruct41_0[k].string_0;
													Form1.gstruct49_0[i].gstruct42_0[j].gstruct41_0[k].int_0 = this.gstruct49_0.gstruct42_0[j].gstruct41_0[k].int_0;
												}
											}
										}
									}
									Class53.smethod_13(Form1.gstruct49_0[i], null);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_12(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x04000417 RID: 1047
		private IContainer icontainer_0 = null;

		// Token: 0x04000431 RID: 1073
		public static bool bool_0 = false;

		// Token: 0x04000432 RID: 1074
		public int int_0 = 0;

		// Token: 0x04000433 RID: 1075
		public int int_1 = 0;

		// Token: 0x04000434 RID: 1076
		public int int_2;

		// Token: 0x04000435 RID: 1077
		public int int_3;

		// Token: 0x04000436 RID: 1078
		public static int int_4 = Class62.smethod_3("flagTileBom", 0, "1");

		// Token: 0x04000437 RID: 1079
		public static int int_5;

		// Token: 0x04000438 RID: 1080
		public static int int_6;

		// Token: 0x04000439 RID: 1081
		public GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x0400043A RID: 1082
		private static int int_7;

		// Token: 0x0400043C RID: 1084
		private static string[] string_0 = null;
	}
}
