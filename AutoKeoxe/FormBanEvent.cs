using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000066 RID: 102
	public partial class FormBanEvent : Form
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x0012F0C8 File Offset: 0x0012D2C8
		public FormBanEvent()
		{
			FormBanEvent.bool_1 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0012F0F8 File Offset: 0x0012D2F8
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0012F828 File Offset: 0x0012DA28
		private static string[] smethod_0()
		{
			string text = Class12.smethod_33(Class53.string_9 + "\\VatphamRac.txt", 0, 0, 1);
			bool flag = text == null || text == string.Empty;
			string[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				string text2 = Class12.smethod_15(text);
				bool flag2 = text2 == null || text2 == string.Empty;
				if (flag2)
				{
					result = null;
				}
				else
				{
					string[] array = text2.Split(new char[]
					{
						'|'
					});
					int num = array.Length;
					int num2 = 0;
					string[] array2 = new string[num];
					for (int i = 0; i < num; i++)
					{
						bool flag3 = array[i] != null && array[i] != string.Empty;
						if (flag3)
						{
							array2[num2] = array[i];
							num2++;
						}
					}
					bool flag4 = num2 == 0;
					if (flag4)
					{
						array2 = null;
					}
					else
					{
						bool flag5 = num2 < num;
						if (flag5)
						{
							Array.Resize<string>(ref array2, num2);
						}
					}
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0012F92C File Offset: 0x0012DB2C
		private static void smethod_1(string[] string_2)
		{
			string text = string.Empty;
			bool flag = string_2 != null;
			if (flag)
			{
				for (int i = 0; i < string_2.Length; i++)
				{
					bool flag2 = string_2[i] != null && string_2[i] != string.Empty;
					if (flag2)
					{
						bool flag3 = text != string.Empty;
						if (flag3)
						{
							text += "|";
						}
						text += string_2[i];
					}
				}
			}
			Class12.smethod_34(Class53.string_9 + "\\VatphamRac.txt", Class12.smethod_16(text), 1);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0012F9C0 File Offset: 0x0012DBC0
		public static void smethod_2()
		{
			int int_ = FormBanEvent.int_0;
			FormBanEvent.int_0 = 0;
			bool flag = false;
			bool flag2 = FormBanEvent.string_0 == null && !FormBanEvent.bool_0;
			if (flag2)
			{
				FormBanEvent.string_0 = FormBanEvent.smethod_0();
				FormBanEvent.bool_0 = true;
			}
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag3 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25 || Form1.gstruct49_0[num].int_12[0] <= 0;
					if (flag3)
					{
						bool flag4 = 0 <= num;
						if (flag4)
						{
							Form1.gstruct49_0[num].bool_3 = false;
							Class70.smethod_52(Form1.gstruct49_0[num], "<color=green>KÕt thóc xö lý vËt phÈm trong danh s¸ch !", 1);
						}
						break;
					}
					bool flag5 = !flag;
					if (flag5)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_3;
						if (bool_)
						{
							break;
						}
						flag = true;
						Form1.gstruct49_0[num].bool_3 = true;
						Class70.smethod_52(Form1.gstruct49_0[num], "<color=green>§ang ch¹y xö lý vËt phÈm trong danh s¸ch (tab event - b¸n)...", 1);
					}
					FormBanEvent.smethod_4(int_, false);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0012FB14 File Offset: 0x0012DD14
		public static void smethod_3()
		{
			try
			{
				int int_ = FormBanEvent.int_0;
				FormBanEvent.int_0 = 0;
				FormBanEvent.smethod_4(int_, true);
			}
			catch
			{
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0012FB50 File Offset: 0x0012DD50
		private static void smethod_4(int int_6, bool bool_2 = false)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[60];
			int num4 = -1;
			for (;;)
			{
				num2--;
				num4--;
				Thread.Sleep(100);
				bool flag = num2 <= 0;
				if (flag)
				{
					int num5 = Class81.smethod_3(Form1.gstruct49_0, int_6);
					bool flag2 = Class12.bool_0 || num5 < 0 || !Form1.gstruct49_0[num5].bool_25;
					if (flag2)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num5];
					bool flag3 = !bool_2 && gstruct.int_12[0] <= 0;
					if (flag3)
					{
						break;
					}
					num2 = 10;
				}
				bool flag4 = FormBanEvent.string_0 != null && FormBanEvent.string_0.Length != 0;
				if (flag4)
				{
					int num6 = Class79.smethod_4(gstruct);
					bool flag5 = !bool_2 && num == num6;
					if (flag5)
					{
						bool flag6 = 0 <= num4;
						if (flag6)
						{
							continue;
						}
						int num7 = FormBanEvent.int_1 % 100;
						bool flag7 = num7 > 0;
						if (flag7)
						{
							Thread.Sleep(num7);
						}
						num4 = FormBanEvent.int_1 / 100;
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num3);
					uint num8 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_13.uint_0, array, 4, ref num3);
					uint num9 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num3);
					uint num10 = BitConverter.ToUInt32(array, 0);
					uint num11 = num10 + num9;
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_50.uint_0, array, 4, ref num3);
					int num12 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_55.uint_0, array, 4, ref num3);
					int num13 = BitConverter.ToInt32(array, 0);
					int num14 = Class83.smethod_39(gstruct);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_43.uint_0, array, 4, ref num3);
					int num15 = BitConverter.ToInt32(array, 0);
					bool flag8 = num12 != 0 && num14 > 1 && num13 != 0 && num13 != 10 && num13 != 21 && (num15 <= 0 || gstruct.int_12[1] != 0);
					if (flag8)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num3);
						uint num16 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num3);
						uint num17 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
						num6 = Class79.smethod_4(gstruct);
						int num18 = 0;
						uint num19 = 1U;
						while ((ulong)num19 < (ulong)((long)Class53.int_1) && num6 > num18)
						{
							Class22.ReadProcessMemory(gstruct.int_137, num17 + (num19 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num3);
							uint num20 = BitConverter.ToUInt32(array, 0);
							bool flag9 = num20 == 0U;
							if (!flag9)
							{
								uint num21 = num16 + num20 * Class53.gstruct51_106.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num3);
								bool flag10 = BitConverter.ToInt32(array, 0) != 0;
								if (!flag10)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_107.uint_0, array2, 1, ref num3);
									bool flag11 = array2[0] == 0;
									if (!flag11)
									{
										num18++;
										uint num22 = num17 + num19 * 20U;
										Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num3);
										bool flag12 = array2[0] != 3;
										if (!flag12)
										{
											bool flag13 = Class53.gstruct51_120.uint_0 > 0U;
											if (flag13)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_120.uint_0, array, 4, ref num3);
												bool flag14 = BitConverter.ToUInt32(array, 0) > 0U;
												if (flag14)
												{
													goto IL_60F;
												}
											}
											bool flag15 = FormBanEvent.string_0 == null || FormBanEvent.string_0.Length == 0;
											if (flag15)
											{
												break;
											}
											Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num3);
											string a = Class10.smethod_3(array3);
											bool flag16 = false;
											try
											{
												for (int i = 0; i < FormBanEvent.string_0.Length; i++)
												{
													bool flag17 = a == FormBanEvent.string_0[i];
													if (flag17)
													{
														flag16 = true;
														break;
													}
												}
											}
											catch
											{
												break;
											}
											bool flag18 = !flag16;
											if (!flag18)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num3);
												int num23 = (int)array2[0];
												Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_100.uint_0, array2, 1, ref num3);
												int num24 = (int)array2[0];
												int num25 = 0;
												int num26 = 800;
												Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_119.uint_0, array, 4, ref num3);
												int num27 = BitConverter.ToInt32(array, 0);
												int num28 = num27;
												while (!Class12.bool_0 && num25 <= num26)
												{
													bool flag19 = num25 % num26 == 0;
													if (flag19)
													{
														bool flag20 = gstruct.int_12[1] != 0;
														if (flag20)
														{
															Class70.smethod_43(gstruct, num20, num23, num24, 3);
														}
														else
														{
															Class70.smethod_35(gstruct, num20);
														}
													}
													Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_107.uint_0, array2, 1, ref num3);
													bool flag21 = array2[0] == 0;
													if (flag21)
													{
														break;
													}
													num25++;
													Thread.Sleep(1);
													Class22.ReadProcessMemory(gstruct.int_137, num21 + Class53.gstruct51_119.uint_0, array, 4, ref num3);
													num27 = BitConverter.ToInt32(array, 0);
													bool flag22 = num28 != num27;
													if (flag22)
													{
														num28 = num27;
														num25 = 0;
													}
												}
											}
										}
									}
								}
							}
							IL_60F:
							num19 += 1U;
						}
					}
				}
				IL_636:
				bool flag23 = !bool_2;
				if (flag23)
				{
					num = Class79.smethod_4(gstruct);
					continue;
				}
				break;
				goto IL_636;
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x001301C4 File Offset: 0x0012E3C4
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormBanEvent.smethod_1(FormBanEvent.string_0);
			FormBanEvent.bool_1 = false;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x001301D8 File Offset: 0x0012E3D8
		private void FormBanEvent_Load(object sender, EventArgs e)
		{
			bool flag = this.int_2 > 0 && this.int_3 > 0;
			if (flag)
			{
				int num = this.int_2 - base.Width - 10;
				int num2 = this.int_3 - base.Height - 10;
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
			FormBanEvent.string_0 = FormBanEvent.smethod_0();
			bool flag4 = FormBanEvent.string_0 != null;
			if (flag4)
			{
				for (int i = 0; i < FormBanEvent.string_0.Length; i++)
				{
					this.method_0(this.listView1, Class10.smethod_1(FormBanEvent.string_0[i], 1, false));
				}
			}
			this.textBoxTocdoban.Text = FormBanEvent.int_1.ToString();
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x001302E0 File Offset: 0x0012E4E0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormBanEvent.bool_1;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00130304 File Offset: 0x0012E504
		private void method_0(ListView listView_0, string string_2)
		{
			try
			{
				string[] array = new string[]
				{
					string_2
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

		// Token: 0x060007E8 RID: 2024 RVA: 0x00130388 File Offset: 0x0012E588
		private void comboBoxTenTuiMauHotro_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				FormBanEvent.string_1 = null;
				int num = 0;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = num > 10 && FormBanEvent.string_1 != null;
					if (flag2)
					{
						break;
					}
					Class79.smethod_35(Form1.gstruct49_0[i], ref FormBanEvent.string_1, 3, null, false);
				}
				this.comboBoxTenTuiMauHotro.Items.Clear();
				bool flag3 = FormBanEvent.string_1 != null;
				if (flag3)
				{
					Array.Sort<string>(FormBanEvent.string_1);
					for (int j = 0; j < FormBanEvent.string_1.Length; j++)
					{
						this.comboBoxTenTuiMauHotro.Items.Add(Class10.smethod_1(FormBanEvent.string_1[j], 1, false));
					}
				}
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00130464 File Offset: 0x0012E664
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count <= 0 || FormBanEvent.string_0 == null;
			if (!flag)
			{
				int index = this.listView1.SelectedIndices[0];
				int num = FormBanEvent.string_0.Length;
				string text = this.listView1.Items[index].SubItems[0].Text;
				int num2 = -1;
				for (int i = 0; i < num; i++)
				{
					bool flag2 = Class10.smethod_1(FormBanEvent.string_0[i], 1, false) == text;
					if (flag2)
					{
						num2 = i;
						break;
					}
				}
				bool flag3 = num2 < 0;
				if (!flag3)
				{
					this.listView1.Items.RemoveAt(index);
					int num3 = 0;
					for (int j = 0; j < num; j++)
					{
						bool flag4 = j != num2;
						if (flag4)
						{
							FormBanEvent.string_0[num3] = FormBanEvent.string_0[j];
							num3++;
						}
					}
					bool flag5 = num3 != 0;
					if (flag5)
					{
						Array.Resize<string>(ref FormBanEvent.string_0, num3);
					}
					else
					{
						FormBanEvent.string_0 = null;
					}
				}
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00130594 File Offset: 0x0012E794
		private void buttonThem_Click(object sender, EventArgs e)
		{
			bool flag = FormBanEvent.string_1 == null;
			if (!flag)
			{
				string text = null;
				string text2 = this.comboBoxTenTuiMauHotro.Text;
				for (int i = 0; i < FormBanEvent.string_1.Length; i++)
				{
					bool flag2 = text2 == Class10.smethod_1(FormBanEvent.string_1[i], 1, false);
					if (flag2)
					{
						text = FormBanEvent.string_1[i];
						break;
					}
				}
				bool flag3 = text == null;
				if (!flag3)
				{
					bool flag4 = FormBanEvent.string_0 != null;
					if (flag4)
					{
						for (int j = 0; j < FormBanEvent.string_0.Length; j++)
						{
							bool flag5 = FormBanEvent.string_0[j] == text;
							if (flag5)
							{
								return;
							}
						}
						Array.Resize<string>(ref FormBanEvent.string_0, FormBanEvent.string_0.Length + 1);
						FormBanEvent.string_0[FormBanEvent.string_0.Length - 1] = text;
					}
					else
					{
						FormBanEvent.string_0 = new string[]
						{
							text
						};
					}
					this.method_0(this.listView1, Class10.smethod_1(text, 1, false));
				}
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0013069D File Offset: 0x0012E89D
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormBanEvent.bool_1 = false;
			base.Close();
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x001306B0 File Offset: 0x0012E8B0
		private void textBoxTocdoban_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormBanEvent.int_1 = Class12.smethod_11(this.textBoxTocdoban.Text);
				bool flag = FormBanEvent.int_1 < 0;
				if (flag)
				{
					FormBanEvent.int_1 = 0;
				}
				Class62.smethod_10(Class53.string_3, "TocdoBanEvent", FormBanEvent.int_1, "", 0);
			}
		}

		// Token: 0x040007B1 RID: 1969
		private IContainer icontainer_0 = null;

		// Token: 0x040007BC RID: 1980
		public static int int_0 = 0;

		// Token: 0x040007BD RID: 1981
		private static bool bool_0 = false;

		// Token: 0x040007BE RID: 1982
		public static string[] string_0 = null;

		// Token: 0x040007BF RID: 1983
		public static int int_1 = Class62.smethod_3("TocdoBanEvent", 0, "300");

		// Token: 0x040007C0 RID: 1984
		public static bool bool_1 = false;

		// Token: 0x040007C1 RID: 1985
		public int int_2;

		// Token: 0x040007C2 RID: 1986
		public int int_3;

		// Token: 0x040007C3 RID: 1987
		public int int_4;

		// Token: 0x040007C4 RID: 1988
		public int int_5;

		// Token: 0x040007C6 RID: 1990
		private static string[] string_1 = null;
	}
}
