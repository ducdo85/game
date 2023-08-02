using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200006D RID: 109
	public partial class FormDoiMauBang : Form
	{
		// Token: 0x06000882 RID: 2178 RVA: 0x0014297C File Offset: 0x00140B7C
		public FormDoiMauBang()
		{
			FormDoiMauBang.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x001429DC File Offset: 0x00140BDC
		public static void smethod_0(uint uint_0)
		{
			bool flag = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 <= 0;
			if (flag)
			{
				Class12.string_16 = new string[]
				{
					"Đổi màu bang: Hãy chọn tên ac đổi màu trước."
				};
			}
			else
			{
				bool flag2 = FormDoiMauBang.int_2 != FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 || FormDoiMauBang.gstruct2_0.int_3 <= 0;
				if (flag2)
				{
					FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.gstruct49_0);
					bool flag3 = FormDoiMauBang.gstruct2_0.int_3 <= 0;
					if (flag3)
					{
						return;
					}
					FormDoiMauBang.int_2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136;
				}
				Class26.smethod_11(FormDoiMauBang.gstruct2_0.gstruct49_0, uint_0);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00142AA0 File Offset: 0x00140CA0
		public static void smethod_1()
		{
			for (;;)
			{
				try
				{
					bool flag = !Class12.bool_0 && FormDoiMauBang.gstruct2_0.int_0 > 0;
					if (!flag)
					{
						break;
					}
					Class70.smethod_52(FormDoiMauBang.gstruct2_0.gstruct49_0, "<bclr=blue><color=green>§æi mµu bang tù ®éng...", 1);
					FormDoiMauBang.smethod_2();
					Class70.smethod_52(FormDoiMauBang.gstruct2_0.gstruct49_0, "<bclr=blue><color=green>KÕt thóc tù ®éng ®æi mµu bang !", 1);
				}
				catch
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00142B2C File Offset: 0x00140D2C
		private static void smethod_2()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 32;
			int num4 = 0;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[num3];
			byte[] array2 = new byte[12];
			uint num5 = 0U;
			for (;;)
			{
				Thread.Sleep(300);
				bool bool_ = FormMayphu.bool_5;
				if (bool_)
				{
					FormDoiMauBang.gstruct2_0.int_0 = 0;
				}
				bool flag = Class12.bool_0 || FormDoiMauBang.gstruct2_0.int_0 <= 0;
				if (flag)
				{
					break;
				}
				bool flag2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 <= 0;
				if (flag2)
				{
					num2 = 0;
				}
				else
				{
					num2--;
					bool flag3 = num2 <= 0;
					if (flag3)
					{
						FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.gstruct49_0);
						num2 = 100;
					}
					bool flag4 = FormDoiMauBang.gstruct2_0.int_3 <= 0;
					if (!flag4)
					{
						bool flag5 = num4 <= 0;
						if (flag5)
						{
							bool flag6 = FormDoiMauBang.gstruct2_0.int_2 > 0;
							if (flag6)
							{
								bool flag7 = FormDoiMauBang.gstruct2_0.string_2 == null || FormDoiMauBang.gstruct2_0.string_2 == string.Empty;
								if (flag7)
								{
									continue;
								}
							}
							else
							{
								bool flag8 = FormDoiMauBang.gstruct2_0.string_1 == null || FormDoiMauBang.gstruct2_0.string_1 == string.Empty;
								if (flag8)
								{
									continue;
								}
							}
							int int_ = FormDoiMauBang.gstruct2_0.gstruct49_0.int_137;
							Class22.ReadProcessMemory(int_, Class53.gstruct51_11.uint_0, array, 4, ref num);
							uint num6 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(int_, num6 + Class53.gstruct51_13.uint_0, array, 4, ref num);
							uint num7 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(int_, Class53.gstruct51_14.uint_0, array, 4, ref num);
							uint num8 = BitConverter.ToUInt32(array, 0);
							uint num9 = num8 + num7;
							bool flag9 = num5 > 0U;
							uint num10;
							if (flag9)
							{
								num10 = num8 + num5 * Class53.gstruct51_15.uint_0;
								Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_50.uint_0, array, 4, ref num);
								bool flag10 = BitConverter.ToInt32(array, 0) > 0;
								if (flag10)
								{
									Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_16.uint_0, array, 1, ref num);
									bool flag11 = array[0] > 0;
									if (flag11)
									{
										Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_54.uint_0, array, 1, ref num);
										int num11 = (int)array[0];
										bool flag12 = num11 > 0 && num11 <= 3;
										if (flag12)
										{
											bool flag13 = FormDoiMauBang.gstruct2_0.int_2 != 0;
											if (flag13)
											{
												bool flag14 = FormDoiMauBang.gstruct2_0.uint_0 > 0U;
												if (flag14)
												{
													Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_88.uint_0, array, 4, ref num);
													uint num12 = BitConverter.ToUInt32(array, 0);
													bool flag15 = num12 == FormDoiMauBang.gstruct2_0.uint_0;
													if (flag15)
													{
														goto IL_64D;
													}
												}
											}
											else
											{
												Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_16.uint_0, byte_, num3, ref num);
												string a = Class10.smethod_3(byte_);
												bool flag16 = a != string.Empty && a == FormDoiMauBang.gstruct2_0.string_1;
												if (flag16)
												{
													goto IL_64D;
												}
											}
										}
									}
								}
							}
							num5 = 0U;
							FormDoiMauBang.gstruct2_0.uint_0 = 0U;
							uint uint_ = FormDoiMauBang.gstruct2_0.gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
							Class22.ReadProcessMemory(int_, uint_, array, 4, ref num);
							int num13 = BitConverter.ToInt32(array, 0);
							int num14 = 0;
							uint num15 = 1U;
							while (num15 < 256U && num13 > num14)
							{
								num10 = num8 + num15 * Class53.gstruct51_15.uint_0;
								Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_50.uint_0, array, 4, ref num);
								bool flag17 = BitConverter.ToInt32(array, 0) <= 0;
								if (!flag17)
								{
									Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_16.uint_0, array, 4, ref num);
									bool flag18 = array[0] == 0;
									if (!flag18)
									{
										num14++;
										Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_52.uint_0, array, 4, ref num);
										uint num16 = BitConverter.ToUInt32(array, 0);
										bool flag19 = num16 != 1U;
										if (!flag19)
										{
											Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_54.uint_0, array, 1, ref num);
											int num17 = (int)array[0];
											bool flag20 = num17 <= 0 || num17 > 3;
											if (!flag20)
											{
												bool flag21 = FormDoiMauBang.gstruct2_0.int_2 <= 0;
												if (flag21)
												{
													Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_16.uint_0, byte_, num3, ref num);
													string text = Class10.smethod_3(byte_);
													bool flag22 = !(Class10.smethod_1(text, 1, false) == FormDoiMauBang.gstruct2_0.string_1);
													if (!flag22)
													{
														num5 = num15;
														goto IL_64D;
													}
												}
												else
												{
													Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_88.uint_0, array, 4, ref num);
													uint num12 = BitConverter.ToUInt32(array, 0);
													bool flag23 = num12 == 0U;
													if (!flag23)
													{
														Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_89.uint_0, array2, array2.Length, ref num);
														bool flag24 = array2[0] == 0;
														if (!flag24)
														{
															string text2 = Class10.smethod_3(array2);
															bool flag25 = Class12.smethod_6(text2) != num12;
															if (flag25)
															{
																string text3 = string.Empty;
																for (int i = 0; i < text2.Length; i++)
																{
																	text3 += text2[i].ToString();
																	bool flag26 = Class12.smethod_6(text3) == num12;
																	if (flag26)
																	{
																		text2 = text3;
																		break;
																	}
																}
															}
															bool flag27 = !(text2 == FormDoiMauBang.gstruct2_0.string_2);
															if (!flag27)
															{
																num5 = num15;
																FormDoiMauBang.gstruct2_0.uint_0 = num12;
																goto IL_64D;
															}
														}
													}
												}
											}
										}
									}
								}
								num15 += 1U;
							}
							num4 = 10;
							continue;
							IL_64D:
							num10 = num8 + num5 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(int_, num10 + Class53.gstruct51_54.uint_0, array, 4, ref num);
							uint num18 = (uint)array[0];
							bool flag28 = num18 == 0U || num18 > 3U;
							if (!flag28)
							{
								Class22.ReadProcessMemory(int_, num9 + Class53.gstruct51_54.uint_0, array, 4, ref num);
								uint num19 = (uint)array[0];
								bool flag29 = num19 == 0U;
								if (!flag29)
								{
									uint num20 = 0U;
									bool flag30 = FormDoiMauBang.gstruct2_0.int_1 > 0;
									if (flag30)
									{
										bool flag31 = num19 == num18;
										if (flag31)
										{
											num20 = num18 + 1U;
											bool flag32 = num20 > 3U;
											if (flag32)
											{
												num20 = 1U;
											}
										}
									}
									else
									{
										bool flag33 = num19 != num18;
										if (flag33)
										{
											num20 = num18;
										}
									}
									bool flag34 = num20 > 0U;
									if (flag34)
									{
										FormDoiMauBang.smethod_0(num20);
										Thread.Sleep(100);
									}
								}
							}
						}
						else
						{
							num4--;
						}
					}
				}
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00143274 File Offset: 0x00141474
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormDoiMauBang.bool_0 = false;
			this.bool_1 = false;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00143284 File Offset: 0x00141484
		private void FormDoiMauBang_Load(object sender, EventArgs e)
		{
			try
			{
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
				this.radioButton1.Checked = (FormDoiMauBang.gstruct2_0.int_2 == 0);
				this.radioButton2.Checked = (FormDoiMauBang.gstruct2_0.int_2 > 0);
				this.checkBoxNghichMau.Checked = (FormDoiMauBang.gstruct2_0.int_1 > 0);
				this.checkBoxTudong.Checked = (!FormMayphu.bool_5 && FormDoiMauBang.gstruct2_0.int_0 > 0);
				bool flag4 = FormDoiMauBang.gstruct2_0.string_1 != null && FormDoiMauBang.gstruct2_0.string_1 != string.Empty;
				if (flag4)
				{
					this.comboBoxThemAcc.Items.Add(Class10.smethod_1(FormDoiMauBang.gstruct2_0.string_1, 1, false));
					this.comboBoxThemAcc.Text = this.comboBoxThemAcc.Items[0].ToString();
				}
				bool flag5 = FormDoiMauBang.gstruct2_0.string_2 != null && FormDoiMauBang.gstruct2_0.string_2 != string.Empty;
				if (flag5)
				{
					this.comboBoxTenBHO.Items.Add(Class10.smethod_1(FormDoiMauBang.gstruct2_0.string_2, 1, false));
					this.comboBoxTenBHO.Text = this.comboBoxTenBHO.Items[0].ToString();
				}
				bool bool_ = FormMayphu.bool_5;
				if (bool_)
				{
					FormDoiMauBang.gstruct2_0.int_0 = 0;
					this.checkBoxTudong.Enabled = false;
					this.labelAdminGame.Text = "( Adgame đã khóa rồi !!! )";
				}
				this.Text = "DOI MAU BANG";
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				this.bool_1 = true;
				base.TopMost = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x001434DC File Offset: 0x001416DC
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormDoiMauBang.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x001434FD File Offset: 0x001416FD
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormDoiMauBang.bool_0 = false;
			base.Close();
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00143510 File Offset: 0x00141710
		public static void smethod_3(GStruct49 gstruct49_0, ref string[] string_2, string[] string_3 = null, bool bool_2 = false)
		{
			byte[] array = new byte[53];
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num2 = 0;
			byte[] array2 = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num2);
			int num3 = BitConverter.ToInt32(array2, 0);
			int num4 = 0;
			uint num5 = 1U;
			while (num5 < 256U && num3 > num4)
			{
				uint num6 = num + num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array2, 4, ref num2);
				bool flag = BitConverter.ToInt32(array2, 0) <= 0;
				if (!flag)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, 4, ref num2);
					bool flag2 = array2[0] == 0;
					if (!flag2)
					{
						num4++;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_52.uint_0, array2, 4, ref num2);
						uint num7 = BitConverter.ToUInt32(array2, 0);
						bool flag3 = num7 != 1U;
						if (!flag3)
						{
							string text = string.Empty;
							if (bool_2)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_88.uint_0, array2, 4, ref num2);
								uint num8 = BitConverter.ToUInt32(array2, 0);
								bool flag4 = num8 == 0U;
								if (flag4)
								{
									goto IL_324;
								}
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_89.uint_0, array, array.Length, ref num2);
								string text2 = Class10.smethod_3(array);
								bool flag5 = text2 == null || text2 == string.Empty;
								if (flag5)
								{
									goto IL_324;
								}
								string text3 = string.Empty;
								bool flag6 = Class12.smethod_6(text2) == num8;
								if (flag6)
								{
									text = text2;
								}
								else
								{
									for (int i = 0; i < text2.Length; i++)
									{
										text3 += text2[i].ToString();
										bool flag7 = Class12.smethod_6(text3) == num8;
										if (flag7)
										{
											text = text3;
											break;
										}
									}
								}
							}
							else
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, array.Length, ref num2);
								text = Class10.smethod_3(array);
							}
							bool flag8 = text == string.Empty;
							if (!flag8)
							{
								bool flag9 = string_3 != null;
								if (flag9)
								{
									bool flag10 = false;
									for (int j = 0; j < string_3.Length; j++)
									{
										bool flag11 = text == string_3[j];
										if (flag11)
										{
											flag10 = true;
											break;
										}
									}
									bool flag12 = flag10;
									if (flag12)
									{
										goto IL_324;
									}
								}
								bool flag13 = string_2 == null;
								if (flag13)
								{
									string_2 = new string[]
									{
										text
									};
								}
								else
								{
									bool flag14 = false;
									for (int k = 0; k < string_2.Length; k++)
									{
										bool flag15 = text == string_2[k];
										if (flag15)
										{
											flag14 = true;
											break;
										}
									}
									bool flag16 = !flag14;
									if (flag16)
									{
										Array.Resize<string>(ref string_2, string_2.Length + 1);
										string_2[string_2.Length - 1] = text;
									}
								}
							}
						}
					}
				}
				IL_324:
				num5 += 1U;
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00143864 File Offset: 0x00141A64
		private void comboBoxThemAcc_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_1 = false;
			this.comboBoxThemAcc.Items.Clear();
			this.string_1 = null;
			bool flag = FormDoiMauBang.gstruct2_0.string_1 != null && FormDoiMauBang.gstruct2_0.string_1 != string.Empty;
			if (flag)
			{
				this.string_1 = new string[]
				{
					FormDoiMauBang.gstruct2_0.string_1
				};
			}
			FormDoiMauBang.smethod_3(FormDoiMauBang.gstruct2_0.gstruct49_0, ref this.string_1, new string[]
			{
				FormDoiMauBang.gstruct2_0.gstruct49_0.string_22
			}, false);
			bool flag2 = this.string_1 != null;
			if (flag2)
			{
				Array.Sort<string>(this.string_1);
				for (int i = 0; i < this.string_1.Length; i++)
				{
					this.comboBoxThemAcc.Items.Add(Class10.smethod_1(this.string_1[i], 1, false));
				}
			}
			this.comboBoxThemAcc.Items.Add(string.Empty);
			this.bool_1 = true;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00143974 File Offset: 0x00141B74
		private void comboBoxThemAcc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1 || this.string_1 == null;
			if (!flag)
			{
				string text = this.comboBoxThemAcc.Text;
				for (int i = 0; i < this.string_1.Length; i++)
				{
					bool flag2 = Class10.smethod_1(this.string_1[i], 1, false) == text;
					if (flag2)
					{
						FormDoiMauBang.gstruct2_0.string_1 = this.string_1[i];
						Class62.smethod_10(Class53.string_3, "DoiTheoTenAcc", Class12.smethod_16(FormDoiMauBang.gstruct2_0.string_1), "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00143A24 File Offset: 0x00141C24
		private void comboBoxTenBHO_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_1 = false;
			this.comboBoxTenBHO.Items.Clear();
			this.string_0 = null;
			bool flag = FormDoiMauBang.gstruct2_0.string_2 != null && FormDoiMauBang.gstruct2_0.string_2 != string.Empty;
			if (flag)
			{
				this.string_0 = new string[]
				{
					FormDoiMauBang.gstruct2_0.string_2
				};
			}
			FormDoiMauBang.smethod_3(FormDoiMauBang.gstruct2_0.gstruct49_0, ref this.string_0, new string[]
			{
				FormDoiMauBang.gstruct2_0.gstruct49_0.string_20
			}, true);
			bool flag2 = this.string_0 != null;
			if (flag2)
			{
				Array.Sort<string>(this.string_0);
				for (int i = 0; i < this.string_0.Length; i++)
				{
					this.comboBoxTenBHO.Items.Add(Class10.smethod_1(this.string_0[i], 1, false));
				}
			}
			this.comboBoxTenBHO.Items.Add(string.Empty);
			this.bool_1 = true;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00143B34 File Offset: 0x00141D34
		private void comboBoxTenBHO_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1 || this.string_0 == null;
			if (!flag)
			{
				string text = this.comboBoxTenBHO.Text;
				for (int i = 0; i < this.string_0.Length; i++)
				{
					bool flag2 = Class10.smethod_1(this.string_0[i], 1, false) == text;
					if (flag2)
					{
						FormDoiMauBang.gstruct2_0.string_2 = this.string_0[i];
						FormDoiMauBang.gstruct2_0.uint_0 = 0U;
						Class62.smethod_10(Class53.string_3, "DoiTheoTenBang", Class12.smethod_16(FormDoiMauBang.gstruct2_0.string_2), "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00143BF4 File Offset: 0x00141DF4
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				bool flag2 = !this.radioButton1.Checked;
				if (!flag2)
				{
					this.radioButton2.Checked = false;
					FormDoiMauBang.gstruct2_0.int_2 = 0;
					FormDoiMauBang.gstruct2_0.uint_0 = 0U;
					Class62.smethod_10(Class53.string_3, "fDoituong", FormDoiMauBang.gstruct2_0.int_2, "", 0);
				}
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00143C84 File Offset: 0x00141E84
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1 && this.radioButton2.Checked;
			if (flag)
			{
				this.radioButton1.Checked = false;
				FormDoiMauBang.gstruct2_0.int_2 = 1;
				FormDoiMauBang.gstruct2_0.uint_0 = 0U;
				Class62.smethod_10(Class53.string_3, "fDoituong", FormDoiMauBang.gstruct2_0.int_2, "", 0);
			}
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00143D04 File Offset: 0x00141F04
		private void checkBoxNghichMau_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1 && this.radioButton2.Checked;
			if (flag)
			{
				FormDoiMauBang.gstruct2_0.int_1 = (int)Convert.ToByte(this.checkBoxNghichMau.Checked);
				Class62.smethod_10(Class53.string_3, "fNghichmau", FormDoiMauBang.gstruct2_0.int_1, "", 0);
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00143D7C File Offset: 0x00141F7C
		private void checkBoxTudong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1 && this.radioButton2.Checked;
			if (flag)
			{
				FormDoiMauBang.gstruct2_0.int_0 = (int)Convert.ToByte(this.checkBoxTudong.Checked);
				Class62.smethod_10(Class53.string_3, "fTudong", FormDoiMauBang.gstruct2_0.int_0, "", 0);
				bool flag2 = FormDoiMauBang.gstruct2_0.int_0 > 0;
				if (flag2)
				{
					new Thread(new ThreadStart(FormDoiMauBang.smethod_1)).Start();
				}
			}
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00143E1C File Offset: 0x0014201C
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			string string_ = "1. Đổi theo màu ac của đối phương||- Bạn phải đem ac đổi màu của bạn đứng gần ac của đối phương.|- Lưu ý tránh trường hợp chọn ac đối phương đang có PT (cờ) trên đầu, vì khi bang hội đối phương đổi màu thì ac này sẽ không bị đổi màu theo. Tốt nhất chọn ac đang ngồi bán hàng trong thành.||2. Đổi màu theo màu ac của bang hội.||- Ưu điểm: ac của bạn chỉ cần đứng gần ac (bất kỳ) trong bang hội của đối phương thì sẽ đổi màu được.|- Khuyết điểm: Nếu ac bạn đang đánh nhau mà bị chết về thành, nếu trong thành không có ac của đối phương thì sẽ ko đổi màu được.||";
			FormTip.smethod_0(Form1.string_1, string_, 600000, 400, 260, false, -1, -1, false, false, false);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00143E54 File Offset: 0x00142054
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x040008A2 RID: 2210
		public static bool bool_0 = false;

		// Token: 0x040008A3 RID: 2211
		public static GStruct2 gstruct2_0 = new GStruct2
		{
			string_0 = Class12.smethod_15(Class62.smethod_6("TenAccdoiMau", 0, "Li4u")),
			string_1 = Class12.smethod_15(Class62.smethod_6("DoiTheoTenAcc", 0, "")),
			string_2 = Class12.smethod_15(Class62.smethod_6("DoiTheoTenBang", 0, "")),
			int_2 = Class62.smethod_3("fDoituong", 0, "0"),
			int_1 = Class62.smethod_3("fNghichmau", 0, "0"),
			int_0 = 0
		};

		// Token: 0x040008A4 RID: 2212
		public int int_0 = 0;

		// Token: 0x040008A5 RID: 2213
		public int int_1 = 0;

		// Token: 0x040008A6 RID: 2214
		private bool bool_1 = false;

		// Token: 0x040008A7 RID: 2215
		private string[] string_0 = null;

		// Token: 0x040008A8 RID: 2216
		private string[] string_1 = null;

		// Token: 0x040008A9 RID: 2217
		public static int int_2 = -1;

		// Token: 0x040008AA RID: 2218
		private IContainer icontainer_0 = null;
	}
}
