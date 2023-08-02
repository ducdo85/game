using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007D RID: 125
	public partial class FormPhongKy1 : Form
	{
		// Token: 0x060009FA RID: 2554 RVA: 0x00169D78 File Offset: 0x00167F78
		public FormPhongKy1()
		{
			FormPhongKy1.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00169DA8 File Offset: 0x00167FA8
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = FormPhongKy1.bool_2 || FormPhongKy1.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].string_3 != null;
					if (flag3)
					{
						Class36.smethod_50(Form1.gstruct49_0[num], Form1.gstruct49_0[num].string_3);
					}
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
			FormPhongKy1.bool_1 = false;
			FormPhongKy1.bool_2 = false;
			FormPhongKy1.bool_3 = false;
			FormPhongKy1.bool_4 = false;
			FormPhongKy1.bool_0 = false;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00169E50 File Offset: 0x00168050
		private void FormPhongKy1_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = Class12.bool_0 || num < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = this.int_0 >= 0 && this.int_1 >= 0;
				if (flag2)
				{
					int num2 = this.int_0 - base.Width;
					int num3 = this.int_1 + this.int_3 - base.Height;
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
				this.listViewPk1.Items.Clear();
				bool flag5 = gstruct.uint_2 != null;
				if (flag5)
				{
					for (int i = 0; i < gstruct.uint_2.GetLength(0); i++)
					{
						this.method_0(this.listViewPk1, new uint[]
						{
							gstruct.uint_2[i, 0],
							gstruct.uint_2[i, 1]
						});
					}
				}
				this.listViewPk2.Items.Clear();
				bool flag6 = gstruct.uint_3 != null;
				if (flag6)
				{
					for (int j = 0; j < gstruct.uint_3.GetLength(0); j++)
					{
						this.method_0(this.listViewPk2, new uint[]
						{
							gstruct.uint_3[j, 0],
							gstruct.uint_3[j, 1]
						});
					}
				}
				this.buttonStopWritePathPk.Enabled = false;
				this.buttonStopWritePathPk2.Enabled = false;
				this.timer_0.Interval = 100;
				this.timer_0.Enabled = true;
				base.TopMost = true;
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0016A038 File Offset: 0x00168238
		private void method_0(ListView listView_0, uint[] uint_0)
		{
			try
			{
				int num = 0;
				bool flag = listView_0.Items != null;
				if (flag)
				{
					num = listView_0.Items.Count;
				}
				string[] array = new string[]
				{
					num.ToString(),
					uint_0[0].ToString() + "," + uint_0[1].ToString()
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
				listViewItem.SubItems.Add(item);
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0016A0E0 File Offset: 0x001682E0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormPhongKy1.bool_0;
			if (flag)
			{
				bool flag2 = FormPhongKy1.bool_3;
				if (flag2)
				{
					FormPhongKy1.bool_3 = false;
					bool flag3 = FormPhongKy1.bool_1;
					if (flag3)
					{
						this.method_1();
					}
				}
				bool flag4 = FormPhongKy1.bool_4;
				if (flag4)
				{
					FormPhongKy1.bool_4 = false;
					bool flag5 = FormPhongKy1.bool_2;
					if (flag5)
					{
						this.method_2();
					}
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0016A148 File Offset: 0x00168348
		private void method_1()
		{
			bool flag = FormPhongKy1.bool_2 || !FormPhongKy1.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					int num2 = Class37.smethod_0(gstruct);
					bool flag3 = num2 != gstruct.int_35 && gstruct.int_35 > 0;
					if (flag3)
					{
						this.listViewPk1.Items.Clear();
						Form1.gstruct49_0[num].uint_2 = null;
					}
					Form1.gstruct49_0[num].int_35 = num2;
					uint[] array = Class36.smethod_30(gstruct);
					bool flag4 = gstruct.uint_2 != null;
					if (flag4)
					{
						for (int i = 0; i < gstruct.uint_2.GetLength(0); i++)
						{
							bool flag5 = gstruct.uint_2[i, 0] == array[0] && gstruct.uint_2[i, 1] == array[1];
							if (flag5)
							{
								return;
							}
						}
					}
					Class12.smethod_54(ref Form1.gstruct49_0[num].uint_2, array);
					this.method_0(this.listViewPk1, array);
					this.method_3(this.listViewPk1, this.listViewPk1.Items.Count - 1);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					string string_ = string.Concat(new string[]
					{
						"#",
						(Form1.gstruct49_0[num].uint_2.GetLength(0) - 1).ToString(),
						" (",
						array[0].ToString(),
						",",
						array[1].ToString(),
						")"
					});
					Class36.smethod_50(gstruct, string_);
				}
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0016A334 File Offset: 0x00168534
		private void method_2()
		{
			bool flag = !FormPhongKy1.bool_2 || FormPhongKy1.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					int num2 = Class37.smethod_0(gstruct);
					bool flag3 = num2 != gstruct.int_36 && gstruct.int_36 > 0;
					if (flag3)
					{
						this.listViewPk2.Items.Clear();
						Form1.gstruct49_0[num].uint_3 = null;
					}
					Form1.gstruct49_0[num].int_36 = num2;
					gstruct = Form1.gstruct49_0[num];
					uint[] array = Class36.smethod_30(gstruct);
					bool flag4 = gstruct.uint_3 != null;
					if (flag4)
					{
						for (int i = 0; i < gstruct.uint_3.GetLength(0); i++)
						{
							bool flag5 = gstruct.uint_3[i, 0] == array[0] && gstruct.uint_3[i, 1] == array[1];
							if (flag5)
							{
								return;
							}
						}
					}
					Class12.smethod_54(ref Form1.gstruct49_0[num].uint_3, array);
					this.method_0(this.listViewPk2, array);
					this.method_3(this.listViewPk2, this.listViewPk2.Items.Count - 1);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					string string_ = string.Concat(new string[]
					{
						"##",
						(Form1.gstruct49_0[num].uint_3.GetLength(0) - 1).ToString(),
						" (",
						array[0].ToString(),
						",",
						array[1].ToString(),
						")"
					});
					Class36.smethod_50(gstruct, string_);
				}
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0016A528 File Offset: 0x00168728
		private void buttonOpenPathPk_Click(object sender, EventArgs e)
		{
			string text = Class53.string_8 + "\\Toado";
			Class12.smethod_23(text);
			string text2 = Class53.smethod_26(text, "", "*.pxy", "");
			bool flag = text2 == string.Empty;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
				bool flag2 = num < 0;
				if (flag2)
				{
					base.Close();
				}
				else
				{
					this.listViewPk1.Items.Clear();
					string text3 = Class12.smethod_15(Class12.smethod_33(text2, 0, 0, 1));
					bool flag3 = !(text3 == string.Empty);
					if (flag3)
					{
						string[] array = text3.Split(new char[]
						{
							'|'
						});
						bool flag4 = array.Length == 2;
						if (flag4)
						{
							int num2 = Class12.smethod_11(array[0]);
							bool flag5 = num2 != 0;
							if (flag5)
							{
								bool flag6 = num2 < 387 || num2 > 389;
								if (flag6)
								{
									Class12.smethod_29(ref Class12.string_16, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
								}
								Form1.gstruct49_0[num].int_35 = num2;
								Form1.gstruct49_0[num].uint_2 = null;
								string[] array2 = array[1].Split(new char[]
								{
									':'
								});
								bool flag7 = array2 != null && array2.Length != 0;
								if (flag7)
								{
									Form1.gstruct49_0[num].uint_2 = new uint[array2.Length, 2];
									for (int i = 0; i < array2.Length; i++)
									{
										string[] array3 = array2[i].Split(new char[]
										{
											';'
										});
										bool flag8 = array3.Length == 2;
										if (flag8)
										{
											for (int j = 0; j < 2; j++)
											{
												Form1.gstruct49_0[num].uint_2[i, j] = Class12.smethod_12(array3[j]);
											}
										}
										this.method_0(this.listViewPk1, new uint[]
										{
											Form1.gstruct49_0[num].uint_2[i, 0],
											Form1.gstruct49_0[num].uint_2[i, 1]
										});
									}
								}
								Class65.int_0 = Form1.gstruct49_0[num].int_136;
								return;
							}
						}
					}
					Form1.gstruct49_0[num].int_35 = 0;
					Form1.gstruct49_0[num].uint_2 = null;
					Class65.int_0 = Form1.gstruct49_0[num].int_136;
				}
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0016A7CC File Offset: 0x001689CC
		private void buttonOpenPathPk2_Click(object sender, EventArgs e)
		{
			string text = Class53.string_8 + "\\Toado";
			Class12.smethod_23(text);
			string text2 = Class53.smethod_26(text, "", "*.txy", "");
			bool flag = text2 == string.Empty;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
				bool flag2 = num < 0;
				if (flag2)
				{
					base.Close();
				}
				else
				{
					this.listViewPk2.Items.Clear();
					string text3 = Class12.smethod_15(Class12.smethod_33(text2, 0, 0, 1));
					bool flag3 = !(text3 == string.Empty);
					if (flag3)
					{
						string[] array = text3.Split(new char[]
						{
							'|'
						});
						bool flag4 = array.Length == 2;
						if (flag4)
						{
							int num2 = Class12.smethod_11(array[0]);
							bool flag5 = num2 != 0;
							if (flag5)
							{
								bool flag6 = num2 < 387 || num2 > 389;
								if (flag6)
								{
									Class12.smethod_29(ref Class12.string_16, "FORM:Thông báo: Tệp Tọa độ này không phải của map Phong kỳ.");
								}
								Form1.gstruct49_0[num].int_36 = num2;
								Form1.gstruct49_0[num].uint_3 = null;
								string[] array2 = array[1].Split(new char[]
								{
									':'
								});
								bool flag7 = array2 != null && array2.Length != 0;
								if (flag7)
								{
									Form1.gstruct49_0[num].uint_3 = new uint[array2.Length, 2];
									for (int i = 0; i < array2.Length; i++)
									{
										string[] array3 = array2[i].Split(new char[]
										{
											';'
										});
										bool flag8 = array3.Length == 2;
										if (flag8)
										{
											for (int j = 0; j < 2; j++)
											{
												Form1.gstruct49_0[num].uint_3[i, j] = Class12.smethod_12(array3[j]);
											}
										}
										this.method_0(this.listViewPk2, new uint[]
										{
											Form1.gstruct49_0[num].uint_3[i, 0],
											Form1.gstruct49_0[num].uint_3[i, 1]
										});
									}
								}
								Class65.int_0 = Form1.gstruct49_0[num].int_136;
								return;
							}
						}
					}
					Form1.gstruct49_0[num].int_36 = 0;
					Form1.gstruct49_0[num].uint_3 = null;
					Class65.int_0 = Form1.gstruct49_0[num].int_136;
				}
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0016AA70 File Offset: 0x00168C70
		private void buttonSavePathPk_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text = Class53.string_8 + "\\Toado";
				Class12.smethod_23(text);
				string text2 = Class53.smethod_27(text, Class10.smethod_1(gstruct.string_22, 1, false) + ".pxy");
				bool flag2 = text2 == string.Empty;
				if (!flag2)
				{
					string text3 = string.Empty;
					bool flag3 = gstruct.uint_2 != null;
					if (flag3)
					{
						for (int i = 0; i < gstruct.uint_2.GetLength(0); i++)
						{
							bool flag4 = text3 != string.Empty;
							if (flag4)
							{
								text3 += ":";
							}
							object obj = text3;
							text3 = string.Concat(new object[]
							{
								obj,
								gstruct.uint_2[i, 0],
								";",
								gstruct.uint_2[i, 1]
							});
						}
					}
					string string_ = gstruct.int_35.ToString() + "|" + text3;
					Class12.smethod_34(text2, Class12.smethod_16(string_), 2);
				}
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0016ABD4 File Offset: 0x00168DD4
		private void buttonSavePathPk2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text = Class53.string_8 + "\\Toado";
				Class12.smethod_23(text);
				string text2 = Class53.smethod_27(text, Class10.smethod_1(gstruct.string_22, 1, false) + ".txy");
				bool flag2 = text2 == string.Empty;
				if (!flag2)
				{
					string text3 = string.Empty;
					bool flag3 = gstruct.uint_3 != null;
					if (flag3)
					{
						for (int i = 0; i < gstruct.uint_3.GetLength(0); i++)
						{
							bool flag4 = text3 != string.Empty;
							if (flag4)
							{
								text3 += ":";
							}
							object obj = text3;
							text3 = string.Concat(new object[]
							{
								obj,
								gstruct.uint_3[i, 0],
								";",
								gstruct.uint_3[i, 1]
							});
						}
					}
					string string_ = gstruct.int_36.ToString() + "|" + text3;
					Class12.smethod_34(text2, Class12.smethod_16(string_), 2);
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0016AD3C File Offset: 0x00168F3C
		private void buttonWritePathPk_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				bool flag2 = !FormPhongKy1.bool_2 && !FormPhongKy1.bool_1;
				if (flag2)
				{
					FormPhongKy1.bool_1 = true;
					this.buttonWritePathPk.Enabled = false;
					this.buttonStopWritePathPk.Enabled = true;
					Form1.gstruct49_0[num].string_3 = Class36.smethod_49(Form1.gstruct49_0[num]);
					Class36.smethod_50(Form1.gstruct49_0[num], "BÊm Space ®Ó ghi ®­êng dÉn");
					GClass0.smethod_1();
					GClass0.smethod_0();
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0016ADEC File Offset: 0x00168FEC
		private void buttonWritePathPk2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				bool flag2 = !FormPhongKy1.bool_1 && !FormPhongKy1.bool_2;
				if (flag2)
				{
					FormPhongKy1.bool_2 = true;
					this.buttonWritePathPk2.Enabled = false;
					this.buttonStopWritePathPk2.Enabled = true;
					Form1.gstruct49_0[num].string_3 = Class36.smethod_49(Form1.gstruct49_0[num]);
					Class36.smethod_50(Form1.gstruct49_0[num], "BÊm Space ®Ó ghi to¹ ®é");
					GClass0.smethod_1();
					GClass0.smethod_0();
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0016AE9C File Offset: 0x0016909C
		private void buttonStopWritePathPk_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				this.buttonWritePathPk.Enabled = true;
				this.buttonStopWritePathPk.Enabled = false;
				bool flag2 = FormPhongKy1.bool_1 && Form1.gstruct49_0[num].string_3 != null;
				if (flag2)
				{
					Class36.smethod_50(Form1.gstruct49_0[num], Form1.gstruct49_0[num].string_3);
				}
				FormPhongKy1.bool_1 = false;
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0016AF34 File Offset: 0x00169134
		private void buttonStopWritePathPk2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num >= 0;
			if (flag)
			{
				this.buttonWritePathPk2.Enabled = true;
				this.buttonStopWritePathPk2.Enabled = false;
				bool flag2 = FormPhongKy1.bool_2 && Form1.gstruct49_0[num].string_3 != null;
				if (flag2)
				{
					Class36.smethod_50(Form1.gstruct49_0[num], Form1.gstruct49_0[num].string_3);
				}
				FormPhongKy1.bool_2 = false;
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0016AFCC File Offset: 0x001691CC
		private void method_3(ListView listView_0, int int_5 = 0)
		{
			bool flag = listView_0.Items == null;
			if (!flag)
			{
				int count = listView_0.Items.Count;
				bool flag2 = count != 0;
				if (flag2)
				{
					bool flag3 = int_5 >= count;
					if (flag3)
					{
						int_5 = count - 1;
					}
					listView_0.TopItem = listView_0.Items[int_5];
					listView_0.Items[int_5].Focused = true;
					listView_0.Items[int_5].Selected = true;
				}
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0016B048 File Offset: 0x00169248
		private void buttonXoaPk_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = this.listViewPk1.Items != null && this.listViewPk1.Items.Count > 0 && gstruct.uint_2 != null && gstruct.uint_2.GetLength(0) != 0;
				if (flag2)
				{
					int num2 = -1;
					for (int i = 0; i < this.listViewPk1.Items.Count; i++)
					{
						bool selected = this.listViewPk1.Items[i].Selected;
						if (selected)
						{
							num2 = i;
							break;
						}
					}
					bool flag3 = num2 < 0;
					if (!flag3)
					{
						string[] array = this.listViewPk1.Items[num2].SubItems[1].Text.Split(new char[]
						{
							','
						});
						bool flag4 = array.Length < 2;
						if (!flag4)
						{
							uint num3 = Class12.smethod_12(array[0]);
							uint num4 = Class12.smethod_12(array[1]);
							int num5 = 0;
							uint[,] array2 = new uint[gstruct.uint_2.GetLength(0), 2];
							for (int j = 0; j < gstruct.uint_2.GetLength(0); j++)
							{
								bool flag5 = gstruct.uint_2[j, 0] != num3 && gstruct.uint_2[j, 1] != num4;
								if (flag5)
								{
									array2[num5, 0] = gstruct.uint_2[j, 0];
									array2[num5, 1] = gstruct.uint_2[j, 1];
									num5++;
								}
							}
							bool flag6 = num5 != 0;
							if (flag6)
							{
								bool flag7 = num5 == gstruct.uint_2.GetLength(0);
								if (!flag7)
								{
									try
									{
										Class65.int_0 = Form1.gstruct49_0[num].int_136;
										Form1.gstruct49_0[num].uint_2 = new uint[num5, 2];
										for (int k = 0; k < num5; k++)
										{
											Form1.gstruct49_0[num].uint_2[k, 0] = array2[k, 0];
											Form1.gstruct49_0[num].uint_2[k, 1] = array2[k, 1];
										}
									}
									catch
									{
										num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
										bool flag8 = num < 0;
										if (flag8)
										{
											base.Close();
											return;
										}
									}
									this.listViewPk1.Items.RemoveAt(num2);
									for (int l = 0; l < this.listViewPk1.Items.Count; l++)
									{
										this.listViewPk1.Items[l].SubItems[0].Text = l.ToString();
									}
									bool flag9 = this.listViewPk1.Items.Count <= num2;
									if (flag9)
									{
										bool flag10 = num2 == 0;
										if (flag10)
										{
											Form1.gstruct49_0[num].uint_2 = null;
											this.listViewPk1.Items.Clear();
											return;
										}
										num2 = this.listViewPk1.Items.Count - 1;
									}
									this.method_3(this.listViewPk1, num2);
								}
							}
							else
							{
								Form1.gstruct49_0[num].uint_2 = null;
								this.listViewPk1.Items.Clear();
							}
						}
					}
				}
				else
				{
					Form1.gstruct49_0[num].uint_2 = null;
					this.listViewPk1.Items.Clear();
				}
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0016B444 File Offset: 0x00169644
		private void buttonXoaPk2_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = this.listViewPk2.Items != null && this.listViewPk2.Items.Count > 0 && gstruct.uint_3 != null && gstruct.uint_3.GetLength(0) != 0;
				if (flag2)
				{
					int num2 = -1;
					for (int i = 0; i < this.listViewPk2.Items.Count; i++)
					{
						bool selected = this.listViewPk2.Items[i].Selected;
						if (selected)
						{
							num2 = i;
							break;
						}
					}
					bool flag3 = num2 < 0;
					if (!flag3)
					{
						string[] array = this.listViewPk2.Items[num2].SubItems[1].Text.Split(new char[]
						{
							','
						});
						bool flag4 = array.Length < 2;
						if (!flag4)
						{
							uint num3 = Class12.smethod_12(array[0]);
							uint num4 = Class12.smethod_12(array[1]);
							int num5 = 0;
							uint[,] array2 = new uint[gstruct.uint_3.GetLength(0), 2];
							for (int j = 0; j < gstruct.uint_3.GetLength(0); j++)
							{
								bool flag5 = gstruct.uint_3[j, 0] != num3 && gstruct.uint_3[j, 1] != num4;
								if (flag5)
								{
									array2[num5, 0] = gstruct.uint_3[j, 0];
									array2[num5, 1] = gstruct.uint_3[j, 1];
									num5++;
								}
							}
							bool flag6 = num5 == 0;
							if (flag6)
							{
								Form1.gstruct49_0[num].uint_3 = null;
								this.listViewPk2.Items.Clear();
							}
							else
							{
								bool flag7 = num5 == gstruct.uint_3.GetLength(0);
								if (!flag7)
								{
									try
									{
										Class65.int_0 = Form1.gstruct49_0[num].int_136;
										Form1.gstruct49_0[num].uint_3 = new uint[num5, 2];
										for (int k = 0; k < num5; k++)
										{
											Form1.gstruct49_0[num].uint_3[k, 0] = array2[k, 0];
											Form1.gstruct49_0[num].uint_3[k, 1] = array2[k, 1];
										}
									}
									catch
									{
										num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
										bool flag8 = num < 0;
										if (flag8)
										{
											base.Close();
											return;
										}
									}
									this.listViewPk2.Items.RemoveAt(num2);
									for (int l = 0; l < this.listViewPk2.Items.Count; l++)
									{
										this.listViewPk2.Items[l].SubItems[0].Text = l.ToString();
									}
									bool flag9 = this.listViewPk2.Items.Count <= num2;
									if (flag9)
									{
										bool flag10 = num2 == 0;
										if (flag10)
										{
											Form1.gstruct49_0[num].uint_3 = null;
											this.listViewPk2.Items.Clear();
											return;
										}
										num2 = this.listViewPk2.Items.Count - 1;
									}
									this.method_3(this.listViewPk2, num2);
								}
							}
						}
					}
				}
				else
				{
					Form1.gstruct49_0[num].uint_3 = null;
					this.listViewPk2.Items.Clear();
				}
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0016B840 File Offset: 0x00169A40
		private void buttonXoahet1_Click(object sender, EventArgs e)
		{
			this.listViewPk1.Items.Clear();
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				Form1.gstruct49_0[num].uint_2 = null;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0016B894 File Offset: 0x00169A94
		private void buttonXoahet2_Click(object sender, EventArgs e)
		{
			this.listViewPk2.Items.Clear();
			int num = Class81.smethod_3(Form1.gstruct49_0, FormPhongKy1.int_4);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				Form1.gstruct49_0[num].uint_3 = null;
			}
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0016B8E8 File Offset: 0x00169AE8
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000ABD RID: 2749
		public int int_0;

		// Token: 0x04000ABE RID: 2750
		public int int_1;

		// Token: 0x04000ABF RID: 2751
		public int int_2;

		// Token: 0x04000AC0 RID: 2752
		public int int_3;

		// Token: 0x04000AC1 RID: 2753
		public static bool bool_0;

		// Token: 0x04000AC2 RID: 2754
		public static int int_4;

		// Token: 0x04000AC3 RID: 2755
		public static bool bool_1;

		// Token: 0x04000AC4 RID: 2756
		public static bool bool_2;

		// Token: 0x04000AC5 RID: 2757
		public static bool bool_3;

		// Token: 0x04000AC6 RID: 2758
		public static bool bool_4;

		// Token: 0x04000AC7 RID: 2759
		private IContainer icontainer_0 = null;
	}
}
