using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x020000E0 RID: 224
	public partial class ThemXoaDanhsach : Form
	{
		// Token: 0x06000BF2 RID: 3058 RVA: 0x00196DF0 File Offset: 0x00194FF0
		public ThemXoaDanhsach()
		{
			ThemXoaDanhsach.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00196E50 File Offset: 0x00195050
		private void ThemXoaDanhsach_Load(object sender, EventArgs e)
		{
			bool flag = this.int_2 >= 0 && this.int_3 >= 0;
			if (flag)
			{
				int num = this.int_2 - base.Width;
				int num2 = this.int_3;
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
			this.bool_1 = false;
			bool flag4 = Class53.bool_1;
			if (flag4)
			{
				new Thread(new ThreadStart(this.method_0)).Start();
			}
			bool flag5 = Form1.string_21 != null && Form1.string_21.Length != 0;
			if (flag5)
			{
				for (int i = 0; i < Form1.string_21.Length; i++)
				{
					this.method_1(this.listViewOff, Form1.string_21[i]);
				}
				this.listViewOff.Items[0].Selected = true;
				this.listViewOff.Items[0].Focused = true;
			}
			int num3 = 0;
			byte[] array = new byte[2];
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array, 2, ref num3);
			this.buttonStickAll.Enabled = (array[1] <= 0 || array[0] > 0);
			this.timer_0.Interval = 1;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x00196FCC File Offset: 0x001951CC
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.gstruct27_0 != null;
			if (flag)
			{
				for (int i = 0; i < this.gstruct27_0.Length; i++)
				{
					Class22.smethod_32(this.gstruct27_0[i].int_1);
				}
			}
			bool flag2 = this.gstruct27_1 != null;
			if (flag2)
			{
				for (int j = 0; j < this.gstruct27_1.Length; j++)
				{
					Class22.smethod_32(this.gstruct27_1[j].int_1);
				}
			}
			ThemXoaDanhsach.bool_0 = false;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00197068 File Offset: 0x00195268
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !ThemXoaDanhsach.bool_0;
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
					this.listView1.Items.Clear();
					this.listView2.Items.Clear();
					bool flag3 = this.gstruct27_0 != null;
					if (flag3)
					{
						for (int i = 0; i < this.gstruct27_0.Length; i++)
						{
							this.method_2(this.listView1, this.gstruct27_0[i]);
						}
						this.method_3(this.listView1);
					}
					bool flag4 = this.gstruct27_1 != null;
					if (flag4)
					{
						for (int j = 0; j < this.gstruct27_1.Length; j++)
						{
							this.method_2(this.listView2, this.gstruct27_1[j]);
						}
						this.method_3(this.listView2);
					}
					this.timer_0.Interval = 300;
				}
				int num = 0;
				int num2 = 0;
				bool flag5 = this.gstruct27_0 != null;
				if (flag5)
				{
					num = this.gstruct27_0.Length;
				}
				bool flag6 = this.gstruct27_1 != null;
				if (flag6)
				{
					num2 = this.gstruct27_1.Length;
				}
				string text = string.Concat(new string[]
				{
					"Tổng có ",
					(num + num2).ToString(),
					" nhân vật (trái: ",
					num.ToString(),
					"; phải: ",
					num2.ToString(),
					")"
				});
				bool flag7 = this.labelThongtin.Text != text;
				if (flag7)
				{
					this.labelThongtin.Text = text;
				}
			}
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00197230 File Offset: 0x00195430
		private void method_0()
		{
			this.gstruct27_1 = null;
			bool flag = Form1.gstruct49_0 != null && Form1.gstruct49_0.Length != 0;
			if (flag)
			{
				this.gstruct27_1 = new GStruct27[Form1.gstruct49_0.Length];
				for (int i = 0; i < this.gstruct27_1.Length; i++)
				{
					this.gstruct27_1[i].int_0 = Form1.gstruct49_0[i].int_136;
					this.gstruct27_1[i].int_1 = Class22.OpenProcess(2035711, false, this.gstruct27_1[i].int_0);
					this.gstruct27_1[i].string_0 = Form1.gstruct49_0[i].string_22;
				}
			}
			int num = 0;
			byte[] array = new byte[1];
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_4 * 4U, array, 1, ref num);
			int[] array2 = Class22.smethod_24(Class53.string_21, null, false);
			bool flag2 = array2 == null || array[0] > 0;
			if (flag2)
			{
				this.bool_1 = true;
			}
			else
			{
				for (int j = 0; j < array2.Length; j++)
				{
					try
					{
						int num2 = array2[j];
						bool flag3 = this.gstruct27_1 != null;
						if (flag3)
						{
							for (int k = 0; k < this.gstruct27_1.Length; k++)
							{
								bool flag4 = num2 == this.gstruct27_1[k].int_0;
								if (flag4)
								{
									num2 = 0;
									break;
								}
							}
						}
						bool flag5 = num2 != 0;
						if (flag5)
						{
							int num3 = Class22.OpenProcess(2035711, false, num2);
							uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, num3);
							uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, num3) * Class53.gstruct51_15.uint_0;
							uint num6 = num5 + Class22.smethod_30(Class53.gstruct51_14.uint_0, num3);
							string text = Class22.smethod_28(num6 + Class53.gstruct51_16.uint_0, num3, 32);
							bool flag6 = !(text == string.Empty) && text.Length >= 6;
							if (flag6)
							{
								ThemXoaDanhsach.smethod_0(ref this.gstruct27_0, num2, num3, text);
							}
						}
					}
					catch
					{
					}
				}
				this.bool_1 = true;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x001974B8 File Offset: 0x001956B8
		private static void smethod_0(ref GStruct27[] gstruct27_2, int int_8, int int_9, string string_0)
		{
			GStruct27 gstruct = new GStruct27
			{
				int_0 = int_8,
				int_1 = int_9,
				string_0 = string_0
			};
			bool flag = gstruct27_2 != null && gstruct27_2.Length != 0;
			if (flag)
			{
				GStruct27[] array = new GStruct27[gstruct27_2.Length + 1];
				for (int i = 0; i < gstruct27_2.Length; i++)
				{
					ref GStruct27 ptr = ref array[i];
					ptr = gstruct27_2[i];
					bool flag2 = array[i].int_0 == int_8;
					if (flag2)
					{
						gstruct27_2[i] = gstruct;
						return;
					}
				}
				array[array.Length - 1] = gstruct;
				gstruct27_2 = array;
			}
			else
			{
				gstruct27_2 = new GStruct27[]
				{
					gstruct
				};
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00197580 File Offset: 0x00195780
		private static void smethod_1(ref GStruct27[] gstruct27_2, int int_8)
		{
			bool flag = gstruct27_2 != null && gstruct27_2.Length != 0;
			if (flag)
			{
				int num = 0;
				GStruct27[] array = new GStruct27[gstruct27_2.Length];
				for (int i = 0; i < gstruct27_2.Length; i++)
				{
					bool flag2 = gstruct27_2[i].int_0 != int_8;
					if (flag2)
					{
						ref GStruct27 ptr = ref array[num];
						ptr = gstruct27_2[i];
						num++;
					}
				}
				bool flag3 = num != 0;
				if (flag3)
				{
					GStruct27[] array2 = new GStruct27[num];
					for (int j = 0; j < num; j++)
					{
						ref GStruct27 ptr2 = ref array2[j];
						ptr2 = array[j];
					}
					gstruct27_2 = array2;
				}
				else
				{
					gstruct27_2 = null;
				}
			}
			else
			{
				gstruct27_2 = null;
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00197654 File Offset: 0x00195854
		private static int smethod_2(GStruct27[] gstruct27_2, int int_8)
		{
			bool flag = gstruct27_2 != null && gstruct27_2.Length != 0 && int_8 != 0;
			int result;
			if (flag)
			{
				for (int i = 0; i < gstruct27_2.Length; i++)
				{
					bool flag2 = gstruct27_2[i].int_0 == int_8;
					if (flag2)
					{
						return i;
					}
				}
				result = -1;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x001976AC File Offset: 0x001958AC
		private static int smethod_3(GStruct27[] gstruct27_2, ListView listView_0, int int_8)
		{
			bool flag = gstruct27_2 != null && listView_0.Items != null && int_8 >= 0;
			if (flag)
			{
				bool flag2 = int_8 >= listView_0.Items.Count;
				if (!flag2)
				{
					int num = Class12.smethod_11(listView_0.Items[int_8].SubItems[listView_0.Items[int_8].SubItems.Count - 1].Text);
					for (int i = 0; i < gstruct27_2.Length; i++)
					{
						bool flag3 = num == gstruct27_2[i].int_0;
						if (flag3)
						{
							return i;
						}
					}
					return -1;
				}
			}
			return -1;
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00197770 File Offset: 0x00195970
		private static int smethod_4(ListView listView_0, int int_8)
		{
			bool flag = listView_0.Items != null && listView_0.Items.Count != 0;
			int result;
			if (flag)
			{
				int index = listView_0.Items[0].SubItems.Count - 1;
				for (int i = 0; i < listView_0.Items.Count; i++)
				{
					bool flag2 = int_8 == Class12.smethod_11(listView_0.Items[i].SubItems[index].Text);
					if (flag2)
					{
						return i;
					}
				}
				result = -1;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0019780C File Offset: 0x00195A0C
		private void method_1(ListView listView_0, string string_0)
		{
			try
			{
				string text = "1";
				bool flag = listView_0.Items != null && listView_0.Items.Count > 0;
				if (flag)
				{
					text = (listView_0.Items.Count + 1).ToString();
				}
				string[] array = new string[]
				{
					text,
					Class10.smethod_1(string_0, 1, false)
				};
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
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x001978DC File Offset: 0x00195ADC
		private void method_2(ListView listView_0, GStruct27 gstruct27_2)
		{
			try
			{
				string[] array = new string[]
				{
					Class10.smethod_1(gstruct27_2.string_0, 1, false),
					gstruct27_2.int_0.ToString()
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

		// Token: 0x06000BFE RID: 3070 RVA: 0x0019797C File Offset: 0x00195B7C
		private void method_3(ListView listView_0)
		{
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				bool flag = Form1.string_17 == listView_0.Items[i].SubItems[0].Text || Form1.string_17 == Class10.smethod_1(listView_0.Items[i].SubItems[1].Text, 1, false);
				if (flag)
				{
					listView_0.Items[i].ForeColor = Color.Blue;
				}
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00197A1C File Offset: 0x00195C1C
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.Items != null;
			if (flag)
			{
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						this.int_6 = i;
						return;
					}
				}
			}
			this.int_6 = -1;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00197A8C File Offset: 0x00195C8C
		private void listView2_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listView2.Items != null;
			if (flag)
			{
				for (int i = 0; i < this.listView2.Items.Count; i++)
				{
					bool selected = this.listView2.Items[i].Selected;
					if (selected)
					{
						this.int_7 = i;
						return;
					}
				}
			}
			this.int_6 = -1;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00197AFC File Offset: 0x00195CFC
		private void buttonDemqua_Click(object sender, EventArgs e)
		{
			bool flag = this.int_6 < 0 || (this.gstruct27_1 != null && this.gstruct27_1.GetLength(0) >= GClass1.GameLimit);
			if (!flag)
			{
				int num = ThemXoaDanhsach.smethod_3(this.gstruct27_0, this.listView1, this.int_6);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.labelThongtin.Text = "Thông tin:...";
					bool flag3 = Class22.smethod_51(this.gstruct27_0[num].int_0);
					if (flag3)
					{
						ThemXoaDanhsach.smethod_0(ref this.gstruct27_1, this.gstruct27_0[num].int_0, this.gstruct27_0[num].int_1, this.gstruct27_0[num].string_0);
					}
					Class12.smethod_37(ref ThemXoaDanhsach.int_0, this.gstruct27_0[num].int_0);
					int num2 = ThemXoaDanhsach.smethod_2(this.gstruct27_1, this.gstruct27_0[num].int_0);
					ThemXoaDanhsach.smethod_1(ref this.gstruct27_0, this.gstruct27_0[num].int_0);
					this.listView1.Items.RemoveAt(this.int_6);
					bool flag4 = num2 >= 0;
					if (flag4)
					{
						this.method_2(this.listView2, this.gstruct27_1[num2]);
						this.method_3(this.listView2);
					}
				}
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00197C78 File Offset: 0x00195E78
		private void buttonTrave_Click(object sender, EventArgs e)
		{
			bool flag = this.int_7 < 0;
			if (!flag)
			{
				int num = ThemXoaDanhsach.smethod_3(this.gstruct27_1, this.listView2, this.int_7);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Class22.smethod_51(this.gstruct27_1[num].int_0);
					if (flag3)
					{
						ThemXoaDanhsach.smethod_0(ref this.gstruct27_0, this.gstruct27_1[num].int_0, this.gstruct27_1[num].int_1, this.gstruct27_1[num].string_0);
					}
					Class12.smethod_37(ref ThemXoaDanhsach.int_1, this.gstruct27_1[num].int_0);
					int num2 = ThemXoaDanhsach.smethod_2(this.gstruct27_0, this.gstruct27_1[num].int_0);
					ThemXoaDanhsach.smethod_1(ref this.gstruct27_1, this.gstruct27_1[num].int_0);
					this.listView2.Items.RemoveAt(this.int_7);
					bool flag4 = num2 >= 0;
					if (flag4)
					{
						this.method_2(this.listView1, this.gstruct27_0[num2]);
						this.method_3(this.listView1);
					}
				}
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00197DC0 File Offset: 0x00195FC0
		private void buttonAddAll_Click(object sender, EventArgs e)
		{
			int[] array = null;
			this.labelThongtin.Text = "Thông tin: ...";
			while (this.gstruct27_0 != null && this.gstruct27_0.Length != 0)
			{
				bool flag = this.gstruct27_1 != null && this.gstruct27_1.GetLength(0) >= GClass1.GameLimit;
				if (flag)
				{
					break;
				}
				int num = ThemXoaDanhsach.smethod_4(this.listView1, this.gstruct27_0[0].int_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					this.listView1.Items.RemoveAt(num);
				}
				bool flag3 = Class22.smethod_51(this.gstruct27_0[0].int_0);
				if (flag3)
				{
					ThemXoaDanhsach.smethod_0(ref this.gstruct27_1, this.gstruct27_0[0].int_0, this.gstruct27_0[0].int_1, this.gstruct27_0[0].string_0);
				}
				Class12.smethod_37(ref array, this.gstruct27_0[0].int_0);
				int num2 = ThemXoaDanhsach.smethod_2(this.gstruct27_1, this.gstruct27_0[0].int_0);
				ThemXoaDanhsach.smethod_1(ref this.gstruct27_0, this.gstruct27_0[0].int_0);
				bool flag4 = num2 >= 0;
				if (flag4)
				{
					this.method_2(this.listView2, this.gstruct27_1[num2]);
					this.method_3(this.listView2);
				}
			}
			ThemXoaDanhsach.int_0 = array;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00197F58 File Offset: 0x00196158
		private void buttonXoatatca_Click(object sender, EventArgs e)
		{
			int[] array = null;
			this.listView2.Items.Clear();
			while (this.gstruct27_1 != null && this.gstruct27_1.Length != 0)
			{
				bool flag = Class22.smethod_51(this.gstruct27_1[0].int_0);
				if (flag)
				{
					ThemXoaDanhsach.smethod_0(ref this.gstruct27_0, this.gstruct27_1[0].int_0, this.gstruct27_1[0].int_1, this.gstruct27_1[0].string_0);
				}
				Class12.smethod_37(ref array, this.gstruct27_1[0].int_0);
				int num = ThemXoaDanhsach.smethod_2(this.gstruct27_0, this.gstruct27_1[0].int_0);
				ThemXoaDanhsach.smethod_1(ref this.gstruct27_1, this.gstruct27_1[0].int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.method_2(this.listView1, this.gstruct27_0[num]);
					this.method_3(this.listView1);
				}
			}
			ThemXoaDanhsach.int_1 = array;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00198083 File Offset: 0x00196283
		private void buttonClose_Click(object sender, EventArgs e)
		{
			ThemXoaDanhsach.bool_0 = false;
			base.Close();
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00198093 File Offset: 0x00196293
		private void buttonStickAll_Click(object sender, EventArgs e)
		{
			Form1.int_130 = 0;
			Form1.bool_12 = true;
			ThemXoaDanhsach.bool_0 = false;
			base.Close();
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x001980B0 File Offset: 0x001962B0
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewOff.Items.Count <= 0;
			if (!flag)
			{
				int num = -1;
				for (int i = 0; i < this.listViewOff.Items.Count; i++)
				{
					bool selected = this.listViewOff.Items[i].Selected;
					if (selected)
					{
						num = i;
						break;
					}
				}
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.listViewOff.Items[num].SubItems[1].Text;
					this.listViewOff.Items.RemoveAt(num);
					bool flag3 = Form1.string_21 != null && Form1.string_21.Length != 0;
					if (flag3)
					{
						for (int j = 0; j < Form1.string_21.Length; j++)
						{
							bool flag4 = Class10.smethod_1(Form1.string_21[j], 1, false) == text;
							if (flag4)
							{
								text = Form1.string_21[j];
								Class12.smethod_30(ref Form1.string_21, text, false);
								break;
							}
						}
					}
					string text2 = string.Empty;
					bool flag5 = Form1.string_21 != null && Form1.string_21.Length != 0;
					if (flag5)
					{
						for (int k = 0; k < Form1.string_21.Length; k++)
						{
							text2 = ((!(text2 != string.Empty)) ? Form1.string_21[k] : (text2 + "|" + Form1.string_21[k]));
						}
						text2 = Class12.smethod_16(text2);
					}
					Class12.smethod_34(Class53.string_13, text2, 1);
					bool flag6 = this.listViewOff.Items != null && this.listViewOff.Items.Count > 0;
					if (flag6)
					{
						for (int l = 0; l < this.listViewOff.Items.Count; l++)
						{
							this.listViewOff.Items[l].SubItems[0].Text = (l + 1).ToString();
						}
						bool flag7 = this.listViewOff.Items.Count <= num;
						if (flag7)
						{
							num--;
						}
						this.listViewOff.Items[num].Focused = true;
						this.listViewOff.Items[num].Selected = true;
					}
				}
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0019832C File Offset: 0x0019652C
		private void buttonXoahet_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewOff.Items != null && this.listViewOff.Items.Count > 0;
			if (flag)
			{
				this.listViewOff.Items.Clear();
			}
			Form1.string_21 = null;
			Class12.smethod_20(Class53.string_13);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00198384 File Offset: 0x00196584
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0400110D RID: 4365
		public static bool bool_0;

		// Token: 0x0400110E RID: 4366
		public static int[] int_0;

		// Token: 0x0400110F RID: 4367
		public static int[] int_1;

		// Token: 0x04001110 RID: 4368
		private GStruct27[] gstruct27_0 = null;

		// Token: 0x04001111 RID: 4369
		private GStruct27[] gstruct27_1 = null;

		// Token: 0x04001112 RID: 4370
		public int int_2;

		// Token: 0x04001113 RID: 4371
		public int int_3;

		// Token: 0x04001114 RID: 4372
		public int int_4;

		// Token: 0x04001115 RID: 4373
		public int int_5;

		// Token: 0x04001116 RID: 4374
		private int int_6 = -1;

		// Token: 0x04001117 RID: 4375
		private int int_7 = -1;

		// Token: 0x04001118 RID: 4376
		private bool bool_1 = false;

		// Token: 0x04001119 RID: 4377
		private IContainer icontainer_0 = null;
	}
}
