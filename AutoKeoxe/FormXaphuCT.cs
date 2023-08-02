using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008F RID: 143
	public partial class FormXaphuCT : Form
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x001936BF File Offset: 0x001918BF
		public FormXaphuCT()
		{
			FormXaphuCT.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x001936EE File Offset: 0x001918EE
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormXaphuCT.int_0 = -2;
			FormXaphuCT.bool_0 = false;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x00193700 File Offset: 0x00191900
		private void FormXaphuCT_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormXaphuCT.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				bool flag2 = this.int_2 >= 0 && this.int_3 >= 0;
				if (flag2)
				{
					int num2 = this.int_2 - base.Width;
					int num3 = this.int_3 + this.int_5 - base.Height;
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
				for (int i = 0; i < Class101.struct29_0.Length; i++)
				{
					this.method_0(Class101.struct29_0[i]);
				}
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				base.TopMost = true;
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00193800 File Offset: 0x00191A00
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormXaphuCT.bool_0;
			if (flag)
			{
				base.Close();
			}
			bool flag2 = 0 <= FormXaphuCT.int_1;
			if (flag2)
			{
				string text = Class101.struct29_0[FormXaphuCT.int_1].string_0;
				uint[] array = new uint[]
				{
					Class101.struct29_0[FormXaphuCT.int_1].uint_0[0],
					Class101.struct29_0[FormXaphuCT.int_1].uint_0[1]
				};
				this.listViewXaphuCongthanh.Items[FormXaphuCT.int_1].SubItems[1].Text = Class10.smethod_1(text, 1, false);
				this.listViewXaphuCongthanh.Items[FormXaphuCT.int_1].SubItems[2].Text = (array[0] / 256U).ToString() + "," + (array[1] / 512U).ToString();
				FormXaphuCT.int_1 = -1;
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0019390C File Offset: 0x00191B0C
		private void method_0(Class101.Struct29 struct29_0)
		{
			try
			{
				string text = "...";
				string text2 = "...";
				bool flag = struct29_0.uint_0 != null;
				if (flag)
				{
					text = (struct29_0.uint_0[0] / 256U).ToString() + "," + (struct29_0.uint_0[1] / 512U).ToString();
				}
				bool flag2 = struct29_0.string_0 != null && struct29_0.string_0 != string.Empty;
				if (flag2)
				{
					text2 = Class10.smethod_1(struct29_0.string_0, 1, false);
				}
				string[] array = new string[]
				{
					struct29_0.string_2,
					text2,
					text,
					struct29_0.int_0.ToString()
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
				this.listViewXaphuCongthanh.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00193A2C File Offset: 0x00191C2C
		private void comboBoxCongThanhQuan_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormXaphuCT.int_0);
			bool flag = num < 0;
			if (!flag)
			{
				this.timer_0.Enabled = false;
				this.comboBoxCongThanhQuan.Items.Clear();
				FormXaphuCT.string_0 = null;
				Class98.smethod_25(Form1.gstruct49_0[num], ref FormXaphuCT.string_0, 3, null);
				FormXaphuCT.int_6 = Class37.smethod_0(Form1.gstruct49_0[num]);
				bool flag2 = FormXaphuCT.string_0 != null;
				if (flag2)
				{
					for (int i = 0; i < FormXaphuCT.string_0.Length; i++)
					{
						this.comboBoxCongThanhQuan.Items.Add(Class10.smethod_1(FormXaphuCT.string_0[i], 1, false));
					}
				}
				this.timer_0.Enabled = true;
			}
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00193AFC File Offset: 0x00191CFC
		private void buttonLayCongThanhQuan_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormXaphuCT.int_0);
			bool flag = num < 0;
			if (!flag)
			{
				int num2 = Class37.smethod_0(Form1.gstruct49_0[num]);
				bool flag2 = FormXaphuCT.string_0 != null && num2 == FormXaphuCT.int_6;
				if (flag2)
				{
					string text = null;
					string text2 = this.comboBoxCongThanhQuan.Text;
					for (int i = 0; i < FormXaphuCT.string_0.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(FormXaphuCT.string_0[i], 1, false);
						if (flag3)
						{
							text = FormXaphuCT.string_0[i];
							break;
						}
					}
					bool flag4 = text == null;
					if (!flag4)
					{
						uint[] array = null;
						int num3 = Class98.smethod_15(Form1.gstruct49_0[num], text, ref array, 3, true, -1, null);
						bool flag5 = num3 <= 0;
						if (!flag5)
						{
							bool flag6 = false;
							for (int j = 0; j < Class101.struct29_0.Length; j++)
							{
								bool flag7 = num2 == Class101.struct29_0[j].int_0;
								if (flag7)
								{
									Class101.struct29_0[j].string_0 = text;
									Class101.struct29_0[j].uint_0 = new uint[]
									{
										array[0],
										array[1]
									};
									this.listViewXaphuCongthanh.Items[j].SubItems[1].Text = Class10.smethod_1(text, 1, false);
									this.listViewXaphuCongthanh.Items[j].SubItems[2].Text = (array[0] / 256U).ToString() + "," + (array[1] / 512U).ToString();
									flag6 = true;
									break;
								}
							}
							bool flag8 = flag6;
							if (flag8)
							{
								Class101.smethod_4();
							}
						}
					}
				}
				else
				{
					Class12.smethod_29(ref Class12.string_16, "Hãy chọn vị trí Xa phu công thành quan trước nhé.");
				}
			}
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00193D0C File Offset: 0x00191F0C
		private void buttonXoaCongThanhQuan_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.listViewXaphuCongthanh.Items.Count; i++)
			{
				bool selected = this.listViewXaphuCongthanh.Items[i].Selected;
				if (selected)
				{
					this.listViewXaphuCongthanh.Items[i].SubItems[1].Text = "...";
					this.listViewXaphuCongthanh.Items[i].SubItems[2].Text = "...";
					Class101.struct29_0[i].string_0 = null;
					Class101.struct29_0[i].uint_0 = null;
					Class101.smethod_4();
				}
			}
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00193DD4 File Offset: 0x00191FD4
		private void buttonTudongLayvitri_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormXaphuCT.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				bool flag2 = Form1.gstruct49_0[num].bool_0;
				if (!flag2)
				{
					Form1.gstruct49_0[num].bool_0 = true;
					new Thread(new ThreadStart(FormXaphuCT.smethod_0)).Start();
				}
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00193E44 File Offset: 0x00192044
		private static void smethod_0()
		{
			int int_ = FormXaphuCT.int_0;
			try
			{
				FormXaphuCT.smethod_1(int_);
			}
			catch
			{
			}
			int num = Class81.smethod_3(Form1.gstruct49_0, FormXaphuCT.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				Form1.gstruct49_0[num].bool_0 = false;
			}
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00193EA4 File Offset: 0x001920A4
		private static void smethod_1(int int_7)
		{
			GStruct49 gstruct = default(GStruct49);
			string[] array = new string[]
			{
				"Xa Phu C«ng Thµnh",
				"Çu C«ng Thµnh ChiÕn",
				"ThÊt thµnh",
				"tiÕp dÉn"
			};
			uint[,] array2 = new uint[7, 3];
			Class11.smethod_4(array2, 31721);
			uint[,] array3 = array2;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			uint[] array4 = new uint[2];
			long long_ = 0L;
			byte[] array5 = new byte[4];
			byte[] array6 = new byte[60];
			int num4;
			for (;;)
			{
				Thread.Sleep(300);
				num4 = Class81.smethod_3(Form1.gstruct49_0, int_7);
				bool flag = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25 || !Form1.gstruct49_0[num4].bool_0;
				if (flag)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num4];
				bool flag2 = array3.GetLength(0) > num;
				if (!flag2)
				{
					goto IL_689;
				}
				uint num5 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num7 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num8 = num7 + num6 * Class53.gstruct51_15.uint_0;
				int num9 = (int)Class22.smethod_30(num8 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num10 = (int)Class22.smethod_30(num8 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num11 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
				Class22.smethod_30(num8 + Class53.gstruct51_43.uint_0, gstruct.int_137);
				int num12 = Class83.smethod_39(gstruct);
				bool flag3 = num10 == 0 || num9 == 0 || num11 == 0 || num12 <= 1;
				if (!flag3)
				{
					uint[] uint_ = new uint[]
					{
						Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					int num13 = (int)array3[num, 0];
					array4[0] = array3[num, 1];
					array4[1] = array3[num, 2];
					bool flag4 = num11 != num13;
					if (flag4)
					{
						bool flag5 = !Class35.smethod_140(gstruct, num13, null, array4, false);
						if (flag5)
						{
							Class50.smethod_5(gstruct, num13);
						}
						num3 = 0;
					}
					else
					{
						long num14 = Class60.smethod_18(uint_, array4);
						bool flag6 = num14 <= 640000L;
						if (flag6)
						{
							Class14.smethod_2(gstruct, false);
							bool flag7 = num14 > 160000L;
							if (flag7)
							{
								Class70.smethod_61(gstruct, array4);
								Thread.Sleep(150);
							}
							else
							{
								uint uint_2 = gstruct.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
								Class22.ReadProcessMemory(gstruct.int_137, uint_2, array5, 4, ref num2);
								int num15 = BitConverter.ToInt32(array5, 0);
								bool flag8 = num15 > 1;
								if (flag8)
								{
									string text = null;
									long num16 = 0L;
									uint[] array7 = new uint[2];
									int num17 = 0;
									for (uint num18 = 1U; num18 < 256U; num18 += 1U)
									{
										bool flag9 = num15 <= num17;
										if (flag9)
										{
											break;
										}
										bool flag10 = num18 == num6;
										if (flag10)
										{
											num17++;
										}
										else
										{
											uint num19 = num7 + num18 * Class53.gstruct51_15.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_16.uint_0, array5, 4, ref num2);
											bool flag11 = array5[0] == 0;
											if (!flag11)
											{
												num17++;
												Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_50.uint_0, array5, 4, ref num2);
												bool flag12 = BitConverter.ToInt32(array5, 0) <= 0;
												if (!flag12)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_52.uint_0, array5, 4, ref num2);
													uint num20 = BitConverter.ToUInt32(array5, 0);
													bool flag13 = num20 != 3U;
													if (!flag13)
													{
														uint[] array8 = new uint[2];
														Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array5, 4, ref num2);
														array8[0] = BitConverter.ToUInt32(array5, 0);
														Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array5, 4, ref num2);
														array8[1] = BitConverter.ToUInt32(array5, 0);
														Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_16.uint_0, array6, array6.Length, ref num2);
														string text2 = Class10.smethod_3(array6);
														string string_ = text2.ToLower();
														bool flag14 = false;
														for (int i = 0; i < array.Length; i++)
														{
															bool flag15 = 0 <= Class12.smethod_1(string_, array[i].ToLower());
															if (flag15)
															{
																flag14 = true;
																break;
															}
														}
														bool flag16 = !flag14;
														if (!flag16)
														{
															array7[0] = array8[0];
															array7[1] = array8[1];
															text = text2;
															break;
														}
														long num21 = Class60.smethod_18(array4, array8);
														bool flag17 = num21 < 160000L && (text == null || num21 < num16);
														if (flag17)
														{
															num16 = num21;
															array7[0] = array8[0];
															array7[1] = array8[1];
															text = text2;
														}
													}
												}
											}
										}
									}
									bool flag18 = text == null;
									if (!flag18)
									{
										for (int j = 0; j < Class101.struct29_0.Length; j++)
										{
											bool flag19 = num11 == Class101.struct29_0[j].int_0;
											if (flag19)
											{
												Class101.struct29_0[j].string_0 = text;
												Class101.struct29_0[j].uint_0 = new uint[]
												{
													array7[0],
													array7[1]
												};
												Class101.smethod_4();
												FormXaphuCT.int_1 = j;
												break;
											}
										}
										num++;
										num3 = 0;
									}
								}
								else
								{
									num3++;
									bool flag20 = num3 > 10;
									if (flag20)
									{
										Class60.smethod_12(gstruct, true);
										num3 = 0;
									}
									Thread.Sleep(300);
								}
							}
						}
						else
						{
							bool flag21 = Class12.smethod_28(long_) > 6000L;
							if (flag21)
							{
								Class14.smethod_1(gstruct, array4);
								long_ = Class12.smethod_27();
							}
						}
					}
				}
			}
			return;
			IL_689:
			Form1.gstruct49_0[num4].bool_0 = false;
			Class70.smethod_52(gstruct, "<color=yellow>DA LAY XONG TAT CA VI TRI", 1);
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00194564 File Offset: 0x00192764
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000D83 RID: 3459
		public static bool bool_0 = false;

		// Token: 0x04000D84 RID: 3460
		public static int int_0 = 0;

		// Token: 0x04000D85 RID: 3461
		private static int int_1 = -1;

		// Token: 0x04000D86 RID: 3462
		public int int_2;

		// Token: 0x04000D87 RID: 3463
		public int int_3;

		// Token: 0x04000D88 RID: 3464
		public int int_4;

		// Token: 0x04000D89 RID: 3465
		public int int_5;

		// Token: 0x04000D8A RID: 3466
		private static string[] string_0 = null;

		// Token: 0x04000D8B RID: 3467
		private static int int_6 = 0;

		// Token: 0x04000D8C RID: 3468
		private IContainer icontainer_0 = null;
	}
}
