using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000077 RID: 119
	public partial class FormMagic : Form
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x0015E23B File Offset: 0x0015C43B
		public FormMagic()
		{
			FormMagic.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0015E26C File Offset: 0x0015C46C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0015EBA8 File Offset: 0x0015CDA8
		private void FormMagic_Load(object sender, EventArgs e)
		{
			FormMagic.int_2 = FormMagic.int_0;
			int num = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_2);
			bool flag = num >= 0;
			if (flag)
			{
				FormMagic.gstruct49_0 = Form1.gstruct49_0[num];
				this.checkBoxBuaXongRoidanh.Checked = (FormMagic.gstruct49_0.int_5 > 0);
				this.checkBoxChiBuff.Checked = (FormMagic.gstruct49_0.int_6 > 0);
				this.checkBoxPhimTat.Checked = (FormMagic.int_1 > 0);
				bool flag2 = !(FormMagic.string_0 == "NGUDOC");
				if (flag2)
				{
					bool flag3 = !(FormMagic.string_0 == "THIENNHAN");
					if (flag3)
					{
						bool flag4 = FormMagic.string_0 == "CONLON";
						if (flag4)
						{
							FormMagic.gstruct36_3 = FormMagic.gstruct36_2;
						}
					}
					else
					{
						FormMagic.gstruct36_3 = FormMagic.gstruct36_1;
					}
				}
				else
				{
					FormMagic.gstruct36_3 = FormMagic.gstruct36_0;
				}
				bool flag5 = FormMagic.gstruct36_3 != null;
				if (flag5)
				{
					string text = string.Empty;
					for (int i = 0; i < FormMagic.gstruct36_3.Length; i++)
					{
						FormMagic.gstruct36_3[i].int_1 = Class77.smethod_16(FormMagic.gstruct49_0, FormMagic.gstruct36_3[i].int_0);
						bool flag6 = FormMagic.gstruct36_3[i].int_1 > 0;
						if (flag6)
						{
							string text2 = FormMagic.gstruct36_3[i].string_0 + " (" + FormMagic.gstruct36_3[i].int_1.ToString() + ")";
							this.comboBoxChieuthuc.Items.Add(text2);
							bool flag7 = text == string.Empty;
							if (flag7)
							{
								text = text2;
							}
						}
					}
					this.comboBoxChieuthuc.Text = text;
					bool flag8 = FormMagic.gstruct49_0.int_3 != null;
					if (flag8)
					{
						int num2 = 0;
						for (int j = 0; j < FormMagic.gstruct49_0.int_3.GetLength(0); j++)
						{
							for (int k = 0; k < FormMagic.gstruct36_3.Length; k++)
							{
								bool flag9 = FormMagic.gstruct49_0.int_3[j, 0] == FormMagic.gstruct36_3[k].int_0 && FormMagic.gstruct36_3[k].int_1 > 0;
								if (flag9)
								{
									this.method_0(FormMagic.gstruct36_3[k]);
									num2++;
									break;
								}
							}
							bool flag10 = num2 > 3;
							if (flag10)
							{
								break;
							}
						}
						this.buttonThem.Enabled = (num2 < 4);
						this.buttonXoa.Enabled = (num2 > 0);
					}
				}
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				base.TopMost = true;
				base.Top = Cursor.Position.Y - base.Height - 10;
				base.Left = Cursor.Position.X - base.Width - 10;
				this.method_1(FormMagic.string_0 + " [" + Class10.smethod_1(FormMagic.gstruct49_0.string_22, 1, false) + "]");
			}
			else
			{
				FormMagic.int_0 = 0;
				base.Close();
			}
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0015EF28 File Offset: 0x0015D128
		private void method_0(GStruct36 gstruct36_4)
		{
			try
			{
				string[] array = new string[]
				{
					gstruct36_4.string_0,
					gstruct36_4.int_1.ToString()
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
				this.listView1.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0015EFC4 File Offset: 0x0015D1C4
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormMagic.bool_0 = false;
			int num = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_2);
			bool flag = num >= 0;
			if (flag)
			{
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0015F008 File Offset: 0x0015D208
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormMagic.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0015F02C File Offset: 0x0015D22C
		private void checkBoxBuaXongRoidanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_0);
				bool flag = num < 0;
				if (flag)
				{
					FormMagic.int_0 = 0;
				}
				else
				{
					Form1.gstruct49_0[num].int_5 = (int)Convert.ToByte(this.checkBoxBuaXongRoidanh.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0015F0A0 File Offset: 0x0015D2A0
		private void buttonThem_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_2);
			bool flag = num < 0 || (Form1.gstruct49_0[num].int_3 != null && Form1.gstruct49_0[num].int_3.GetLength(0) > 3);
			if (!flag)
			{
				string text = this.comboBoxChieuthuc.Text;
				int num2 = -1;
				for (int i = 0; i < FormMagic.gstruct36_3.Length; i++)
				{
					bool flag2 = Class12.smethod_1(text, FormMagic.gstruct36_3[i].string_0) == 0;
					if (flag2)
					{
						num2 = i;
						break;
					}
				}
				bool flag3 = num2 < 0 || FormMagic.gstruct36_3[num2].int_1 <= 0;
				if (!flag3)
				{
					int[] array = null;
					bool flag4 = Form1.gstruct49_0[num].int_3 != null;
					if (flag4)
					{
						int length = Form1.gstruct49_0[num].int_3.GetLength(0);
						array = new int[length];
						for (int j = 0; j < length; j++)
						{
							bool flag5 = Form1.gstruct49_0[num].int_3[j, 0] != FormMagic.gstruct36_3[num2].int_0;
							if (!flag5)
							{
								return;
							}
							array[j] = Form1.gstruct49_0[num].int_3[j, 0];
						}
					}
					bool flag6 = array != null;
					if (flag6)
					{
						Array.Resize<int>(ref array, array.Length + 1);
					}
					else
					{
						array = new int[1];
					}
					array[array.Length - 1] = FormMagic.gstruct36_3[num2].int_0;
					Form1.gstruct49_0[num].int_3 = new int[array.Length, 2];
					for (int k = 0; k < array.Length; k++)
					{
						Form1.gstruct49_0[num].int_3[k, 0] = array[k];
						Form1.gstruct49_0[num].int_3[k, 1] = Class77.smethod_16(Form1.gstruct49_0[num], array[k]);
					}
					this.method_0(FormMagic.gstruct36_3[num2]);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.buttonThem.Enabled = (Form1.gstruct49_0[num].int_3 == null || Form1.gstruct49_0[num].int_3.GetLength(0) < 4);
					this.buttonXoa.Enabled = (Form1.gstruct49_0[num].int_3 != null && Form1.gstruct49_0[num].int_3.GetLength(0) > 0);
				}
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0015F374 File Offset: 0x0015D574
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			int num = -1;
			string text = null;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					text = this.listView1.Items[i].SubItems[0].Text;
					num = i;
					break;
				}
			}
			bool flag = num < 0 || text == null;
			if (!flag)
			{
				this.listView1.Items.RemoveAt(num);
				bool flag2 = this.listView1.Items.Count > 0;
				if (flag2)
				{
					int num2 = num;
					bool flag3 = this.listView1.Items.Count <= num2;
					if (flag3)
					{
						num2 = this.listView1.Items.Count - 1;
					}
					this.listView1.Items[num2].Focused = true;
					this.listView1.Items[num2].Selected = true;
				}
				int num3 = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_2);
				bool flag4 = num3 < 0;
				if (!flag4)
				{
					bool flag5 = Form1.gstruct49_0[num3].int_3 != null;
					if (flag5)
					{
						int num4 = -1;
						for (int j = 0; j < FormMagic.gstruct36_3.Length; j++)
						{
							bool flag6 = Class12.smethod_1(text, FormMagic.gstruct36_3[j].string_0) == 0;
							if (flag6)
							{
								num4 = FormMagic.gstruct36_3[j].int_0;
								break;
							}
						}
						bool flag7 = num4 > 0;
						if (flag7)
						{
							int[,] array = new int[Form1.gstruct49_0[num3].int_3.GetLength(0), 2];
							int num5 = 0;
							for (int k = 0; k < array.GetLength(0); k++)
							{
								bool flag8 = Form1.gstruct49_0[num3].int_3[k, 0] != num4;
								if (flag8)
								{
									array[num5, 0] = Form1.gstruct49_0[num3].int_3[k, 0];
									array[num5, 1] = Form1.gstruct49_0[num3].int_3[k, 1];
									num5++;
								}
							}
							bool flag9 = num5 != 0;
							if (flag9)
							{
								bool flag10 = num5 < array.GetLength(0);
								if (flag10)
								{
									Form1.gstruct49_0[num3].int_3 = new int[num5, 2];
									for (int l = 0; l < num5; l++)
									{
										Form1.gstruct49_0[num3].int_3[l, 0] = array[l, 0];
										Form1.gstruct49_0[num3].int_3[l, 1] = array[l, 1];
									}
								}
							}
							else
							{
								Form1.gstruct49_0[num3].int_3 = null;
							}
						}
					}
					Class53.smethod_13(Form1.gstruct49_0[num3], null);
					this.buttonXoa.Enabled = (Form1.gstruct49_0[num3].int_3 != null && Form1.gstruct49_0[num3].int_3.GetLength(0) > 0);
					this.buttonThem.Enabled = (Form1.gstruct49_0[num3].int_3 == null || Form1.gstruct49_0[num3].int_3.GetLength(0) < 4);
				}
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0015F720 File Offset: 0x0015D920
		private void checkBoxChiBuff_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormMagic.int_0);
				bool flag = num >= 0;
				if (flag)
				{
					Form1.gstruct49_0[num].int_6 = (int)Convert.ToByte(this.checkBoxChiBuff.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
				else
				{
					FormMagic.int_0 = 0;
				}
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0015F798 File Offset: 0x0015D998
		private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormMagic.int_1 = (int)Convert.ToByte(this.checkBoxPhimTat.Checked);
				Class62.smethod_10(Class53.string_3, "flagCtrlTab", FormMagic.int_1, "", 0);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_1(string string_1)
		{
			base.Text = string_1;
		}

		// Token: 0x04000A26 RID: 2598
		private IContainer icontainer_0 = null;

		// Token: 0x04000A34 RID: 2612
		public static bool bool_0 = false;

		// Token: 0x04000A35 RID: 2613
		public static int int_0 = 0;

		// Token: 0x04000A36 RID: 2614
		public static string string_0 = null;

		// Token: 0x04000A37 RID: 2615
		public static int int_1 = Class62.smethod_3("flagCtrlTab", 0, "1");

		// Token: 0x04000A38 RID: 2616
		private static GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000A39 RID: 2617
		private static GStruct36[] gstruct36_0 = new GStruct36[]
		{
			new GStruct36
			{
				int_0 = 73,
				string_0 = "Vạn Độc Thực Tâm (Thời gian trúng độc)"
			},
			new GStruct36
			{
				int_0 = 390,
				string_0 = "Đoạn Cân Hủ Cốt (Âm Kháng tất cả)"
			},
			new GStruct36
			{
				int_0 = 356,
				string_0 = "Xuyên Y Phá Giáp (Âm Phòng thủ)"
			},
			new GStruct36
			{
				int_0 = 72,
				string_0 = "Xuyên Tâm Độc Thích (Âm Kháng độc)"
			},
			new GStruct36
			{
				int_0 = 64,
				string_0 = "Băng Lam Huyền Tinh (Âm Kháng băng)"
			},
			new GStruct36
			{
				int_0 = 70,
				string_0 = "Xích Diệm Thực Thiên (Âm Kháng hỏa)"
			},
			new GStruct36
			{
				int_0 = 67,
				string_0 = "Cửu Thiên Cuồng Lôi (Âm Kháng lôi)"
			}
		};

		// Token: 0x04000A3A RID: 2618
		private static GStruct36[] gstruct36_1 = new GStruct36[]
		{
			new GStruct36
			{
				int_0 = 391,
				string_0 = "Tâm pháp Nhiếp Hồn Loạn Tâm (Chiến đấu)"
			},
			new GStruct36
			{
				int_0 = 136,
				string_0 = "Hỏa Liên Phần Hoa (Phản đòn)"
			},
			new GStruct36
			{
				int_0 = 137,
				string_0 = "Ảo Ảnh Phi Hồ (Tỉ lệ công kích chính xác)"
			},
			new GStruct36
			{
				int_0 = 140,
				string_0 = "Phi Hồng Vô Tích (Né tránh)"
			},
			new GStruct36
			{
				int_0 = 364,
				string_0 = "Bi Tô Thanh Phong (Thời gian phục hồi)"
			},
			new GStruct36
			{
				int_0 = 143,
				string_0 = "Lịch Ma Đoạt Hồn (Sát thương Vật lý ngoại công)"
			}
		};

		// Token: 0x04000A3B RID: 2619
		private static GStruct36[] gstruct36_2 = new GStruct36[]
		{
			new GStruct36
			{
				int_0 = 394,
				string_0 = "Túy Tiên Tá Cốt (Phản đòn, làm chậm, choáng)"
			},
			new GStruct36
			{
				int_0 = 392,
				string_0 = "Thúc Phược Chú (Âm phản đòn tầm xa)"
			},
			new GStruct36
			{
				int_0 = 174,
				string_0 = "Kỷ Bán phù (Âm tốc độ di chuyển)"
			},
			new GStruct36
			{
				int_0 = 393,
				string_0 = "Bắc Minh Đáo Hải (Âm phục hồi Sinh lực, Nội lực)"
			},
			new GStruct36
			{
				int_0 = 175,
				string_0 = "Khi Hàn Ngạo Tuyết (Âm tốc độ đánh)"
			},
			new GStruct36
			{
				int_0 = 90,
				string_0 = "Mê Tung ảo ảnh (Thời gian làm chậm, choáng)"
			}
		};

		// Token: 0x04000A3C RID: 2620
		private static GStruct36[] gstruct36_3 = null;

		// Token: 0x04000A3E RID: 2622
		private static int int_2 = 0;
	}
}
