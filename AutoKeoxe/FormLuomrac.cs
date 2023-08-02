using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000076 RID: 118
	public partial class FormLuomrac : Form
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0015C6C8 File Offset: 0x0015A8C8
		public FormLuomrac()
		{
			FormLuomrac.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0015C6FE File Offset: 0x0015A8FE
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormLuomrac.int_0 = 0;
			FormLuomrac.bool_0 = false;
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0015C710 File Offset: 0x0015A910
		private void FormLuomrac_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormLuomrac.int_0);
			bool flag = num < 0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				Form1.gstruct49_0[num].int_55 = 0;
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = this.int_1 >= 0 && this.int_2 >= 0;
				if (flag2)
				{
					int num2 = this.int_1 - base.Width - 10;
					int num3 = this.int_2 - base.Height - 10;
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
				this.checkBoxAccept.Checked = (gstruct.int_55 > 0);
				this.checkBoxBanTheoThuoctinh.Checked = (gstruct.int_56 > 0);
				this.textBoxThoigianTre.Text = FormLuomrac.int_5.ToString();
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				this.bool_1 = true;
				base.TopMost = true;
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0015C844 File Offset: 0x0015AA44
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormLuomrac.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0015C868 File Offset: 0x0015AA68
		private void checkBoxBanTheoThuoctinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLuomrac.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_56 = (int)Convert.ToByte(this.checkBoxBanTheoThuoctinh.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0015C8E4 File Offset: 0x0015AAE4
		private void checkBoxAccept_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLuomrac.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_55 = (int)Convert.ToByte(this.checkBoxAccept.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0015C960 File Offset: 0x0015AB60
		private void buttonPhichiendau_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !this.bool_1;
			if (!flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormLuomrac.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					string text = string.Concat(new string[]
					{
						Class10.smethod_1(Form1.gstruct49_0[num].string_22, 1, false),
						": ",
						Class53.string_7,
						"Khi làm phi chiến đấu, ac phải lưu rương khác map. ",
						Class53.string_7,
						"Ví dụ làm ở Mạc Cao Quật thì không được lưu rương Thành đô, ở Sa mạc 1, 2, 3 thì không được lưu rương Lâm an...",
						Class53.string_7,
						"Sau khi làm phi chiến đấu, ac sẽ tự thoát game và bạn phải log lại. Bạn chắc chắn muốn làm phi chiến đấu cho ac ?"
					});
					bool flag3 = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) != DialogResult.No;
					if (flag3)
					{
						Class60.smethod_28(Form1.gstruct49_0[num]);
					}
				}
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonDong_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0015CA38 File Offset: 0x0015AC38
		private void textBoxThoigianTre_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && this.bool_1;
			if (flag)
			{
				FormLuomrac.int_5 = Class12.smethod_11(this.textBoxThoigianTre.Text);
				Class62.smethod_10(Class53.string_3, "ThoigiantrePCD", FormLuomrac.int_5, "", 0);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0015CA98 File Offset: 0x0015AC98
		public static void smethod_0(int int_6)
		{
			try
			{
				FormLuomrac.smethod_1(int_6);
			}
			catch
			{
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0015CAC8 File Offset: 0x0015ACC8
		private static void smethod_1(int int_6)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = -1;
			int num2 = 0;
			long long_ = 0L;
			long long_2 = 0L;
			int num3 = -1;
			int num4 = 0;
			uint[] array = null;
			string[] array2 = null;
			bool flag = false;
			long long_3 = 0L;
			long long_4 = 0L;
			uint[] array3 = null;
			uint[] array4 = null;
			int num5 = -1;
			long num6 = 0L;
			for (;;)
			{
				Thread.Sleep(300);
				int num7 = Class81.smethod_3(Form1.gstruct49_0, int_6);
				bool flag2 = Class12.bool_0 || num7 < 0 || !Form1.gstruct49_0[num7].bool_25 || Form1.gstruct49_0[num7].int_25 <= 0 || Form1.gstruct49_0[num7].int_54 <= 0 || Form1.gstruct49_0[num7].int_55 <= 0 || Form1.gstruct49_0[num7].int_32 <= 0;
				if (flag2)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num7];
				bool flag3 = !flag;
				if (flag3)
				{
					Class70.smethod_52(gstruct, "<color=yellow>Chay Rac: " + Class37.smethod_1(gstruct.int_32, false), 1);
					flag = true;
				}
				bool flag4 = gstruct.bool_15 || gstruct.gstruct47_0.int_0 > 0 || Class83.smethod_12(gstruct) > 0;
				if (!flag4)
				{
					uint num8 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num9 = Class22.smethod_30(num8 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num10 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num11 = num10 + num9 * Class53.gstruct51_15.uint_0;
					int num12 = (int)Class22.smethod_30(num11 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					int num13 = (int)Class22.smethod_30(num11 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num14 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					uint[] array5 = new uint[]
					{
						Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					int num15 = Class83.smethod_39(gstruct);
					bool flag5 = num13 == 0 || num12 == 0 || num14 == 0 || num12 == 10 || num12 == 21 || num15 <= 1;
					if (!flag5)
					{
						Class60.smethod_29(gstruct, false);
						bool flag6 = Class12.smethod_28(long_2) > 300000L;
						if (flag6)
						{
							array = null;
							array2 = new string[]
							{
								"ThÇn Hµnh Phï",
								"Thæ ®Þa phï",
								"Håi thµnh phï"
							};
							long_2 = Class12.smethod_27();
						}
						bool flag7 = gstruct.int_26 > 0 && !gstruct.bool_6 && Class12.smethod_28(long_3) > 15000L;
						if (flag7)
						{
							Class23.int_0 = int_6;
							new Thread(new ThreadStart(new Class23().method_1)).Start();
							long_3 = Class12.smethod_27();
						}
						bool flag8 = num14 == gstruct.int_32;
						if (flag8)
						{
							bool flag9 = gstruct.int_61 > 0;
							if (flag9)
							{
								bool flag10 = array3 != null;
								if (flag10)
								{
									uint num16 = Class22.smethod_30(Class53.gstruct51_126.uint_0, gstruct.int_137);
									uint num17 = num16 + array3[0] * Class53.gstruct51_127.uint_0;
									int num18 = 0;
									byte[] array6 = new byte[1];
									byte[] array7 = new byte[4];
									Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_138.uint_0, array6, 1, ref num18);
									Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_137.uint_0, array7, 4, ref num18);
									bool flag11 = array6[0] == 0 || BitConverter.ToInt32(array7, 0) <= 0;
									if (flag11)
									{
										array3 = null;
									}
								}
								bool flag12 = array3 == null;
								if (flag12)
								{
									array3 = Class58.smethod_0(gstruct, array5, true, false);
								}
								bool flag13 = array3 != null;
								if (flag13)
								{
									uint[] array8 = new uint[]
									{
										array3[2],
										array3[3]
									};
									long num19 = Class60.smethod_18(array5, array8);
									bool flag14 = num19 <= (long)(gstruct.int_52 * gstruct.int_52);
									if (flag14)
									{
										bool flag15 = (long)num5 != (long)((ulong)array3[0]) || array4 == null || array4[0] != array3[2] || array4[1] != array3[3];
										if (!flag15)
										{
											uint uint_ = array3[0];
											uint num20 = array3[2];
											uint num21 = array3[3];
											int num22 = (int)array3[4];
											long long_5 = 0L;
											bool flag16 = Class12.smethod_28(long_4) > 12000L;
											if (!flag16)
											{
												bool flag17 = Class12.smethod_28(long_4) > 3000L;
												if (flag17)
												{
													string string_ = Class83.smethod_20(gstruct);
													bool flag18 = 0 < Class12.smethod_1(string_, "qu¸ xa") || 0 < Class12.smethod_1(string_, "o¶ng trèn");
													if (flag18)
													{
														long_5 = Class12.smethod_27() - (long)Class58.int_0 + 6000L;
														Class83.smethod_21(gstruct, "0K..");
														bool flag19 = Class22.smethod_30(num11 + Class53.gstruct51_44.uint_0, gstruct.int_137) == 0U;
														if (flag19)
														{
															Class70.smethod_57(gstruct, "Switch([[sit]])");
														}
														goto IL_6FF;
													}
												}
												goto IL_56B;
											}
											IL_6FF:
											Class58.smethod_4(ref gstruct.gstruct38_0, uint_, num22, long_5);
											num5 = -1;
											array3 = null;
											long_4 = Class12.smethod_27();
											goto IL_5CC;
										}
										num5 = (int)array3[0];
										array4 = new uint[]
										{
											array3[2],
											array3[3]
										};
										long_4 = Class12.smethod_27();
										IL_56B:
										bool flag20 = num19 > 40000L && gstruct.int_54 <= 0;
										if (flag20)
										{
											Class70.smethod_61(gstruct, array8);
											Thread.Sleep(150);
										}
										Class70.smethod_48(gstruct, array3[0]);
										Thread.Sleep(150);
									}
								}
							}
							IL_5CC:
							bool flag21 = num6 > 0L && Class12.smethod_28(num6) < 1000L;
							if (!flag21)
							{
								uint[] array9 = Class60.smethod_26(gstruct, ref num4);
								bool flag22 = array9 != null;
								if (flag22)
								{
									num6 = 0L;
									long num23 = Class60.smethod_18(array5, array9);
									bool flag23 = num23 >= 8000L;
									if (flag23)
									{
										bool flag24 = num23 >= 22500L && num23 >= (long)(gstruct.int_68[1] * gstruct.int_68[1]);
										if (flag24)
										{
											bool flag25 = num23 >= 360000L;
											if (flag25)
											{
												bool flag26 = num23 >= 1200000L;
												if (flag26)
												{
													goto IL_725;
												}
												bool flag27 = Class12.smethod_28(long_) > 3000L;
												if (flag27)
												{
													Class14.smethod_1(gstruct, array9);
													long_ = Class12.smethod_27();
												}
											}
											else
											{
												Class14.smethod_2(gstruct, false);
												Class70.smethod_61(gstruct, array9);
												Thread.Sleep(100);
											}
										}
										else
										{
											Class70.smethod_61(gstruct, array9);
											Thread.Sleep(100);
										}
									}
								}
								else
								{
									num6 = Class12.smethod_27();
								}
								goto IL_8AC;
							}
							IL_725:
							bool flag28 = gstruct.uint_0 != null;
							if (flag28)
							{
								int length = gstruct.uint_0.GetLength(0);
								bool flag29 = num < 0 || num2 == 0;
								if (flag29)
								{
									num = 0;
									bool flag30 = length > 1;
									if (flag30)
									{
										num = Class60.smethod_20(gstruct.uint_0, array5);
										bool flag31 = num < 0;
										if (flag31)
										{
											num = 0;
										}
									}
									num2 = 1;
								}
								uint[] array10 = new uint[]
								{
									gstruct.uint_0[num, 0],
									gstruct.uint_0[num, 1]
								};
								long num24 = Class60.smethod_18(array5, array10);
								bool flag32 = num24 > 600000L;
								if (flag32)
								{
									bool flag33 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 10000L;
									if (flag33)
									{
										Class14.smethod_1(gstruct, array10);
										long_ = Class12.smethod_27();
									}
									continue;
								}
								bool flag34 = num24 > 16000L;
								if (flag34)
								{
									Class70.smethod_61(gstruct, array10);
									Thread.Sleep(100);
									continue;
								}
								bool flag35 = length > 1;
								if (flag35)
								{
									num += num2;
									bool flag36 = gstruct.int_29 > 0;
									if (flag36)
									{
										bool flag37 = num < 0 || length <= num;
										if (flag37)
										{
											num = 0;
										}
										num2 = 1;
									}
									else
									{
										bool flag38 = num < 0;
										if (flag38)
										{
											num = 0;
											num2 = 1;
											bool flag39 = length > 1;
											if (flag39)
											{
												num++;
											}
										}
										else
										{
											bool flag40 = length <= num;
											if (flag40)
											{
												num = length - 1;
												num2 = -1;
												bool flag41 = length > 1;
												if (flag41)
												{
													num--;
												}
											}
										}
									}
								}
							}
							goto IL_8AC;
							goto IL_5CC;
						}
						Class60.smethod_10(gstruct, "Sai map (toa do chay khong phai cua map nay) !");
						IL_8AC:
						int num25 = (int)Class22.smethod_30(num11 + Class53.gstruct51_43.uint_0, gstruct.int_137);
						bool flag42 = num25 > 0;
						if (!flag42)
						{
							int num26 = Class79.smethod_4(gstruct);
							bool flag43 = num3 != num26;
							if (flag43)
							{
								bool flag44 = gstruct.int_56 > 0;
								if (flag44)
								{
									Class6.smethod_4(gstruct);
								}
								else
								{
									FormLuomrac.smethod_2(gstruct, ref array, ref array2);
								}
								num3 = Class79.smethod_4(gstruct);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0015D3F8 File Offset: 0x0015B5F8
		private static void smethod_2(GStruct49 gstruct49_0, ref uint[] uint_0, ref string[] string_0)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			byte[] array3 = new byte[80];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			byte[] array4 = new byte[4];
			int num4 = 0;
			int num5 = Class79.smethod_4(gstruct49_0);
			int num6 = 0;
			uint num7 = 1U;
			while ((ulong)num7 < (ulong)((long)Class53.int_1) && num5 > num6)
			{
				uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array4, 4, ref num4);
				bool flag = BitConverter.ToInt32(array4, 0) != 0;
				if (!flag)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array4, 1, ref num4);
					bool flag2 = array4[0] == 0;
					if (!flag2)
					{
						uint num9 = Class79.smethod_1(gstruct49_0, num7);
						bool flag3 = num9 == 0U;
						if (!flag3)
						{
							num6++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_120.uint_0, array2, 4, ref num);
							bool flag4 = BitConverter.ToInt32(array2, 0) != 0;
							if (!flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array2, 4, ref num);
								int num10 = BitConverter.ToInt32(array2, 0);
								bool flag5 = num10 > 3;
								if (!flag5)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_109.uint_0, array2, 4, ref num);
									int num11 = BitConverter.ToInt32(array2, 0);
									bool flag6 = num11 == 1 || num11 == 4;
									if (!flag6)
									{
										bool flag7 = uint_0 != null;
										if (flag7)
										{
											bool flag8 = false;
											for (int i = 0; i < uint_0.Length; i++)
											{
												bool flag9 = num7 == uint_0[i];
												if (flag9)
												{
													flag8 = true;
													break;
												}
											}
											bool flag10 = flag8;
											if (flag10)
											{
												goto IL_415;
											}
										}
										bool flag11 = string_0 != null;
										if (flag11)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
											string string_ = Class10.smethod_3(array3).ToLower();
											bool flag12 = false;
											for (int j = 0; j < string_0.Length; j++)
											{
												bool flag13 = Class12.smethod_1(string_, string_0[j].ToLower()) == 0;
												if (flag13)
												{
													flag12 = true;
													break;
												}
											}
											bool flag14 = flag12;
											if (flag14)
											{
												goto IL_415;
											}
										}
										uint num12 = Class22.smethod_30(num2 + num9 * 20U + Class53.gstruct51_100.uint_0 - 8U, gstruct49_0.int_137);
										bool flag15 = num9 <= 0U || num12 != 3U;
										if (!flag15)
										{
											uint num13 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
											uint num14 = Class22.smethod_30(num13 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
											uint num15 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
											uint num16 = num15 + num14 * Class53.gstruct51_15.uint_0;
											Class70.smethod_35(gstruct49_0, num7);
											int num17 = 0;
											while (!Class12.bool_0 && Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num) && array[0] > 0)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_43.uint_0, array2, 4, ref num);
												bool flag16 = BitConverter.ToInt32(array2, 0) > 0;
												if (flag16)
												{
													break;
												}
												num17++;
												Thread.Sleep(100);
												bool flag17 = num17 > 15;
												if (flag17)
												{
													string string_2 = Class83.smethod_22(gstruct49_0);
													bool flag18 = Class12.smethod_1(string_2, "hÊt b¹i") > 0;
													if (flag18)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num);
														string string_3 = Class10.smethod_3(array3);
														Class12.smethod_29(ref string_0, string_3);
														Class12.smethod_40(ref uint_0, num7);
														Class83.smethod_23(gstruct49_0, "0K..");
														break;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_415:
				num7 += 1U;
			}
			Thread.Sleep(100);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0015D848 File Offset: 0x0015BA48
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/dDYR4Al3LIg";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
			"Xem video hướng dẫn tại: " + Class53.string_7 + text;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0015D884 File Offset: 0x0015BA84
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000A0F RID: 2575
		public static bool bool_0 = false;

		// Token: 0x04000A10 RID: 2576
		public static int int_0 = 0;

		// Token: 0x04000A11 RID: 2577
		public int int_1;

		// Token: 0x04000A12 RID: 2578
		public int int_2;

		// Token: 0x04000A13 RID: 2579
		public int int_3;

		// Token: 0x04000A14 RID: 2580
		public int int_4;

		// Token: 0x04000A15 RID: 2581
		public static int int_5 = Class62.smethod_3("ThoigiantrePCD", 0, "100");

		// Token: 0x04000A16 RID: 2582
		private bool bool_1 = false;

		// Token: 0x04000A17 RID: 2583
		private IContainer icontainer_0 = null;
	}
}
