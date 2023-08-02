using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000084 RID: 132
	public partial class FormTapKet : Form
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x0017DA63 File Offset: 0x0017BC63
		public FormTapKet()
		{
			FormTapKet.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0017DA94 File Offset: 0x0017BC94
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0017E790 File Offset: 0x0017C990
		public static int smethod_0(int int_5)
		{
			try
			{
				bool flag = !FormTapKet.bool_1;
				if (flag)
				{
					FormTapKet.bool_1 = true;
					FormTapKet.smethod_2();
				}
				return FormTapKet.smethod_1(int_5);
			}
			catch
			{
			}
			return -1;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0017E7DC File Offset: 0x0017C9DC
		public static int smethod_1(int int_5)
		{
			int result = 0;
			int num = 0;
			GStruct49 gstruct = default(GStruct49);
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			string text = null;
			string text2 = null;
			uint[] array = null;
			uint[] array2 = null;
			long long_ = 0L;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			for (;;)
			{
				Thread.Sleep(300);
				int num9 = Class81.smethod_3(Form1.gstruct49_0, int_5);
				bool flag = !Class12.bool_0 && num9 >= 0 && Form1.int_114 > 0 && Form1.int_20 == 0 && FormTapKet.gstruct62_0 != null && !FormMayphu.bool_7;
				if (!flag)
				{
					goto IL_7EA;
				}
				gstruct = Form1.gstruct49_0[num9];
				bool flag2 = Class70.smethod_3(gstruct, Class70.uint_48, 4) > 0 || !gstruct.bool_25 || gstruct.int_20[0] > 0 || gstruct.int_133[0] > 0 || gstruct.bool_54 || gstruct.int_25 > 0 || gstruct.bool_15;
				if (flag2)
				{
					break;
				}
				uint num10 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num11 = Class22.smethod_30(num10 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num12 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num13 = num12 + num11 * Class53.gstruct51_15.uint_0;
				int num14 = (int)Class22.smethod_30(num13 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num15 = (int)Class22.smethod_30(num13 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num16 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
				bool flag3 = FormMayphu.bool_6 && Class56.smethod_0(num16) != null;
				if (flag3)
				{
					break;
				}
				bool flag4 = num14 == 10 || num14 == 21 || num15 == 0 || num14 == 0 || num16 == 0;
				if (flag4)
				{
					bool flag5 = num15 == 0 || num14 == 0;
					if (!flag5)
					{
						goto IL_206;
					}
					num++;
					bool flag6 = num < 10;
					if (!flag6)
					{
						goto IL_205;
					}
					Thread.Sleep(100);
				}
				else
				{
					int num17 = (int)Class22.smethod_30(num13 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					bool flag7 = num17 <= 0;
					if (!flag7)
					{
						goto IL_7E3;
					}
					int i = 0;
					int num18 = 0;
					int num19 = 0;
					while (i < 255)
					{
						i++;
						bool flag8 = FormTapKet.gstruct62_0.Length > num2;
						if (!flag8)
						{
							goto IL_329;
						}
						bool flag9 = FormTapKet.gstruct62_0[num2].int_0 == 0 && FormTapKet.gstruct62_0[num2].int_1 != num16;
						if (!flag9)
						{
							text = FormTapKet.gstruct62_0[num2].string_0;
							array = FormTapKet.gstruct62_0[num2].uint_0;
							text2 = FormTapKet.gstruct62_0[num2].string_1;
							num18 = FormTapKet.gstruct62_0[num2].int_2;
							num19 = FormTapKet.gstruct62_0[num2].int_3;
							num7 = FormTapKet.gstruct62_0[num2].int_4;
							num8 = FormTapKet.gstruct62_0[num2].int_0;
							num6 = 0;
							break;
						}
						num2++;
						Thread.Sleep(100);
					}
					num = 0;
					uint[] array3 = new uint[]
					{
						Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					bool flag10 = num8 <= 0;
					if (flag10)
					{
						bool flag11 = array == null || array[0] == 0U || array[1] == 0U;
						if (flag11)
						{
							goto IL_A48;
						}
						long num20 = Class60.smethod_18(array3, array);
						bool flag12 = num20 > 800000L;
						if (flag12)
						{
							Class60.smethod_29(gstruct, false);
							bool flag13 = num3 < 6;
							if (flag13)
							{
								uint[,] array4 = Class42.smethod_1(num16, array3, array, null, false);
								bool flag14 = array4 != null;
								if (flag14)
								{
									Class60.smethod_22(gstruct, array4, array3, array, num16, true, 100000, false);
								}
								else
								{
									num3 = 6;
								}
								num3++;
								continue;
							}
							bool flag15 = array2 == null;
							if (flag15)
							{
								array2 = new uint[]
								{
									array3[0],
									array3[1]
								};
								num4 = 0;
							}
							bool flag16 = num4 > 6;
							if (flag16)
							{
								bool flag17 = array2 != null && Class60.smethod_18(array2, array3) < 180000L;
								array2 = null;
								bool flag18 = flag17;
								if (flag18)
								{
									Class60.smethod_2(gstruct, array3, array, 600);
									continue;
								}
								num4 = 0;
							}
							bool flag19 = Class12.smethod_28(long_) > 4500L;
							if (flag19)
							{
								bool flag20 = Class14.smethod_1(gstruct, array) <= 0;
								if (flag20)
								{
									Class60.smethod_12(gstruct, true);
								}
								num4++;
								long_ = Class12.smethod_27();
							}
						}
						i = 0;
						Class14.smethod_2(gstruct, false);
						Class86.smethod_8(gstruct, -1);
						Thread.Sleep(100);
						while (!Class12.bool_0)
						{
							array3 = new uint[]
							{
								Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num13 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							bool flag21 = Class60.smethod_18(array3, array) <= 22500L;
							if (flag21)
							{
								break;
							}
							bool flag22 = i <= 15;
							if (!flag22)
							{
								Class14.smethod_1(gstruct, array);
								Thread.Sleep(3000);
								break;
							}
							Class70.smethod_61(gstruct, array);
							i++;
							Thread.Sleep(300);
						}
						Class14.smethod_2(gstruct, false);
						bool flag23 = num6 <= 0;
						if (flag23)
						{
							Thread.Sleep(300);
							num6 = Class98.smethod_13(gstruct, text, 3, 0 <= text.IndexOf("Xa phu"), -1, 80);
						}
						bool flag24 = num6 <= 0;
						if (flag24)
						{
							Class60.smethod_10(gstruct, "Dang tim " + text + " !");
							num5++;
							bool flag25 = num5 > 6;
							if (flag25)
							{
								Class60.smethod_12(gstruct, true);
								num5 = 0;
							}
							continue;
						}
					}
					num5 = 0;
					i = 0;
					for (;;)
					{
						bool flag26 = !Class12.bool_0;
						if (!flag26)
						{
							goto IL_7AC;
						}
						bool flag27 = Form1.int_114 <= 0;
						if (flag27)
						{
							break;
						}
						bool flag28 = num7 > 0 && Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
						if (flag28)
						{
							string string_ = Class45.smethod_4(gstruct);
							Class45.smethod_5(gstruct, Class12.smethod_10(string_, false, false).ToString(), true);
							Thread.Sleep(300);
						}
						bool flag29 = i % 10 == 0;
						if (flag29)
						{
							bool flag30 = num8 <= 0;
							if (flag30)
							{
								Class36.smethod_10(gstruct, (uint)num6);
							}
							else
							{
								uint[] array5 = Class79.smethod_29(gstruct, text, 3, false);
								bool flag31 = array5 == null;
								if (flag31)
								{
									goto Block_52;
								}
								Class70.smethod_43(gstruct, array5[0], (int)array5[2], (int)array5[3], 3);
							}
							Thread.Sleep(300);
							num5++;
						}
						Thread.Sleep(100);
						bool flag32 = 0 > Class86.smethod_0(gstruct);
						if (!flag32)
						{
							goto IL_7AB;
						}
						bool flag33 = !Class86.Class89.smethod_4(gstruct);
						if (!flag33)
						{
							goto IL_7A3;
						}
						i++;
						bool flag34 = num5 > 6;
						if (flag34)
						{
							goto Block_55;
						}
					}
					continue;
					Block_55:
					Class60.smethod_12(gstruct, true);
					num5 = 0;
					continue;
					IL_7AC:
					Thread.Sleep(150);
					string[] array6 = text2.Split(new char[]
					{
						',',
						'.',
						'|',
						'/'
					});
					int num21 = 0;
					for (;;)
					{
						bool flag35 = num21 < array6.Length;
						if (!flag35)
						{
							goto IL_99E;
						}
						bool flag36 = Class86.smethod_0(gstruct) < 0;
						if (flag36)
						{
							break;
						}
						int num22 = Class12.smethod_11(array6[num21]) - 1;
						bool flag37 = num22 < 0;
						if (!flag37)
						{
							int num23 = Class86.smethod_0(gstruct);
							int num24 = Class86.smethod_1(gstruct, num23);
							string text3 = string.Empty;
							for (int j = 0; j < num24; j++)
							{
								text3 += Class86.smethod_3(gstruct, j, num23, 128);
							}
							Class86.smethod_5(gstruct, num22);
							Thread.Sleep(300);
							for (i = 0; i < 10; i++)
							{
								int num25 = Class86.smethod_0(gstruct);
								bool flag38 = num25 != num23;
								if (flag38)
								{
									break;
								}
								int num26 = Class86.smethod_1(gstruct, num25);
								bool flag39 = num26 != num24;
								if (flag39)
								{
									break;
								}
								string text4 = string.Empty;
								for (int k = 0; k < num26; k++)
								{
									text4 += Class86.smethod_3(gstruct, k, num25, 128);
								}
								bool flag40 = text3 != text4;
								if (flag40)
								{
									break;
								}
								Thread.Sleep(100);
							}
							Thread.Sleep(150);
							int num27 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
							int num28 = (int)Class22.smethod_30(num13 + Class53.gstruct51_43.uint_0, gstruct.int_137);
							bool flag41 = (num27 == 0 || num27 == num16) && num28 <= 0;
							if (!flag41)
							{
								goto IL_99D;
							}
						}
						num21++;
					}
					IL_A46:
					goto IL_A48;
					IL_99E:
					bool flag42 = num18 <= 0;
					if (flag42)
					{
						goto IL_A46;
					}
					i = 0;
					while (i < 10)
					{
						bool flag43 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) == 0U;
						if (!flag43)
						{
							break;
						}
						i++;
						Thread.Sleep(100);
					}
					bool flag44 = Class12.smethod_9(Class45.smethod_6(gstruct)) <= 1;
					if (flag44)
					{
						Class45.smethod_5(gstruct, num19.ToString(), true);
					}
					else
					{
						Class22.smethod_4(gstruct.uint_4, 13U);
					}
					goto IL_A46;
					IL_99D:
					goto IL_99E;
					goto IL_A46;
					IL_7AB:
					goto IL_7AC;
					IL_7A3:
					Class86.Class89.smethod_5(gstruct);
					goto IL_7AB;
					Block_52:
					IL_A48:
					int num29 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					int num30 = (int)Class22.smethod_30(num13 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					bool flag45 = (num29 == 0 || num29 == num16) && num30 <= 0;
					if (!flag45)
					{
						goto IL_AA4;
					}
					num2++;
					Class86.smethod_8(gstruct, -1);
				}
			}
			return result;
			IL_205:
			IL_206:
			return -1;
			IL_329:
			return 1;
			IL_7E3:
			return 1;
			IL_7EA:
			return 0;
			IL_AA4:
			result = 1;
			return result;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0017F2A8 File Offset: 0x0017D4A8
		public static void smethod_2()
		{
			FormTapKet.gstruct62_0 = null;
			string text = Class12.smethod_33(Class53.string_9 + "\\Tapket.txt", 0, 0, 1);
			bool flag = text == null || text == string.Empty;
			if (!flag)
			{
				string[] array = text.Split(new char[]
				{
					'\r',
					'\n'
				});
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2 = array[i] == null || array[i] == string.Empty;
					if (!flag2)
					{
						string[] array2 = array[i].Split(new char[]
						{
							';'
						});
						bool flag3 = array2.Length < 5;
						if (!flag3)
						{
							string text2 = array2[0];
							uint num = Class12.smethod_12(array2[1]);
							uint num2 = Class12.smethod_12(array2[2]);
							string text3 = array2[3];
							int num3 = Class12.smethod_11(array2[4]);
							int num4 = 0;
							int num5 = 0;
							int num6 = 0;
							int num7 = 0;
							bool flag4 = array2.Length > 6;
							if (flag4)
							{
								num4 = Class12.smethod_11(array2[5]);
								num5 = Class12.smethod_11(array2[6]);
							}
							bool flag5 = array2.Length > 7;
							if (flag5)
							{
								num6 = Class12.smethod_11(array2[7]);
							}
							bool flag6 = array2.Length > 8;
							if (flag6)
							{
								num7 = Class12.smethod_11(array2[8]);
							}
							bool flag7 = text2 != null && !(text2 == string.Empty) && ((num != 0U && num2 != 0U && text3 != null && !(text3 == string.Empty)) || num7 != 0);
							if (flag7)
							{
								bool flag8 = FormTapKet.gstruct62_0 != null;
								if (flag8)
								{
									Array.Resize<GStruct62>(ref FormTapKet.gstruct62_0, FormTapKet.gstruct62_0.Length + 1);
								}
								else
								{
									FormTapKet.gstruct62_0 = new GStruct62[1];
								}
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].string_0 = text2;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].uint_0 = new uint[]
								{
									num,
									num2
								};
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].string_1 = text3;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].int_1 = num3;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].int_2 = num4;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].int_3 = num5;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].int_4 = num6;
								FormTapKet.gstruct62_0[FormTapKet.gstruct62_0.Length - 1].int_0 = num7;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0017F548 File Offset: 0x0017D748
		private static void smethod_3()
		{
			string text = string.Empty;
			bool flag = FormTapKet.gstruct62_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormTapKet.gstruct62_0.Length; i++)
				{
					bool flag2 = FormTapKet.gstruct62_0[i].string_0 != null && !(FormTapKet.gstruct62_0[i].string_0 == string.Empty) && ((FormTapKet.gstruct62_0[i].uint_0 != null && FormTapKet.gstruct62_0[i].uint_0[0] != 0U && FormTapKet.gstruct62_0[i].uint_0[1] != 0U) || FormTapKet.gstruct62_0[i].int_0 != 0);
					if (flag2)
					{
						bool flag3 = FormTapKet.gstruct62_0[i].string_1 == null;
						if (flag3)
						{
							FormTapKet.gstruct62_0[i].string_1 = string.Empty;
						}
						FormTapKet.gstruct62_0[i].string_1 = FormTapKet.gstruct62_0[i].string_1.Replace(";", ",");
						bool flag4 = text != string.Empty;
						if (flag4)
						{
							text += Class53.string_7;
						}
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							FormTapKet.gstruct62_0[i].string_0,
							";",
							FormTapKet.gstruct62_0[i].uint_0[0],
							";",
							FormTapKet.gstruct62_0[i].uint_0[1],
							";",
							FormTapKet.gstruct62_0[i].string_1,
							";",
							FormTapKet.gstruct62_0[i].int_1,
							";",
							FormTapKet.gstruct62_0[i].int_2,
							";",
							FormTapKet.gstruct62_0[i].int_3,
							";",
							FormTapKet.gstruct62_0[i].int_4,
							";",
							FormTapKet.gstruct62_0[i].int_0
						});
					}
				}
			}
			Class12.smethod_34(Class53.string_9 + "\\Tapket.txt", text, 1);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0017F7D8 File Offset: 0x0017D9D8
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTapKet.smethod_3();
			this.int_1 = 0;
			this.int_2 = 0;
			FormTapKet.int_0 = 0;
			FormTapKet.bool_0 = false;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0017F7FC File Offset: 0x0017D9FC
		private void FormTapKet_Load(object sender, EventArgs e)
		{
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
			bool flag4 = !FormTapKet.bool_1;
			if (flag4)
			{
				FormTapKet.bool_1 = true;
				FormTapKet.smethod_2();
			}
			bool flag5 = FormTapKet.gstruct62_0 != null;
			if (flag5)
			{
				for (int i = 0; i < FormTapKet.gstruct62_0.Length; i++)
				{
					int int_ = FormTapKet.gstruct62_0[i].int_1;
					bool flag6 = FormTapKet.gstruct62_0[i].int_0 > 0;
					if (flag6)
					{
						int_ = -1;
					}
					this.method_0(this.listView1, FormTapKet.gstruct62_0[i].string_0, FormTapKet.gstruct62_0[i].uint_0, FormTapKet.gstruct62_0[i].string_1, int_, FormTapKet.gstruct62_0[i].int_2, FormTapKet.gstruct62_0[i].int_3, FormTapKet.gstruct62_0[i].int_4);
				}
				for (int j = 0; j < FormTapKet.gstruct62_0.Length; j++)
				{
					bool flag7 = j < this.listView1.Items.Count && FormTapKet.gstruct62_0[j].int_0 > 0;
					if (flag7)
					{
						this.listView1.Items[j].ForeColor = Color.Blue;
					}
				}
			}
			for (int k = 0; k < FormTapKet.string_0.Length; k++)
			{
				this.comboBoxNpc.Items.Add(FormTapKet.string_0[k]);
			}
			this.comboBoxNpc.Text = FormTapKet.string_0[0];
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0017FA48 File Offset: 0x0017DC48
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTapKet.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0017FA6C File Offset: 0x0017DC6C
		private void method_0(ListView listView_0, string string_2, uint[] uint_0, string string_3, int int_5, int int_6, int int_7, int int_8)
		{
			try
			{
				string text = "1";
				bool flag = listView_0.Items != null && listView_0.Items.Count > 0;
				if (flag)
				{
					text = (listView_0.Items.Count + 1).ToString();
				}
				string text2 = string.Empty;
				bool flag2 = int_5 < 0;
				if (flag2)
				{
					text2 = "Vật phẩm";
				}
				else
				{
					text2 = Class37.smethod_1(int_5, true);
					bool flag3 = text2 == null || text2 == string.Empty;
					if (flag3)
					{
						text2 = int_5.ToString();
					}
				}
				string[] array = new string[]
				{
					text,
					Class10.smethod_1(string_2, 1, false),
					uint_0[0].ToString() + "," + uint_0[1].ToString(),
					string_3,
					text2,
					int_6.ToString() + ":" + int_7.ToString(),
					int_8.ToString()
				};
				ListViewItem listViewItem = new ListViewItem(array[0]);
				bool flag4 = array.Length > 1;
				if (flag4)
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

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0017FBE0 File Offset: 0x0017DDE0
		private void buttonThem_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxChon.Text;
			int num = 0;
			for (int i = 0; i < FormTapKet.string_0.Length; i++)
			{
				bool flag = this.comboBoxNpc.Text == FormTapKet.string_0[i];
				if (flag)
				{
					num = i;
					break;
				}
			}
			bool flag2 = text == null || text == string.Empty || (num <= 0 && FormTapKet.gstruct23_0 == null) || (num > 0 && FormTapKet.string_1 == null);
			if (!flag2)
			{
				string text2 = this.textBoxMenu.Text;
				text2 = ((text2 != null && !(text2 == string.Empty)) ? text2.Replace(";", ",") : "0");
				string text3 = null;
				uint[] array = null;
				int int_ = 0;
				bool flag3 = num > 0;
				if (flag3)
				{
					for (int j = 0; j < FormTapKet.string_1.Length; j++)
					{
						bool flag4 = text == Class10.smethod_1(FormTapKet.string_1[j], 1, false);
						if (flag4)
						{
							text3 = FormTapKet.string_1[j];
							array = new uint[]
							{
								1U,
								1U
							};
							break;
						}
					}
					int_ = -1;
				}
				else
				{
					for (int k = 0; k < FormTapKet.gstruct23_0.Length; k++)
					{
						bool flag5 = text == Class10.smethod_1(FormTapKet.gstruct23_0[k].string_0, 1, false);
						if (flag5)
						{
							text3 = FormTapKet.gstruct23_0[k].string_0;
							uint[] array3;
							if (FormTapKet.gstruct23_0[k].uint_0 == null)
							{
								uint[] array2 = new uint[2];
								array2[0] = 1U;
								array3 = array2;
								array2[1] = 1U;
							}
							else
							{
								uint[] array4 = new uint[2];
								array4[0] = FormTapKet.gstruct23_0[k].uint_0[0];
								array3 = array4;
								array4[1] = FormTapKet.gstruct23_0[k].uint_0[1];
							}
							array = array3;
							int_ = FormTapKet.gstruct23_0[k].int_0;
							break;
						}
					}
				}
				bool flag6 = text3 != null && !(text3 == string.Empty);
				if (flag6)
				{
					bool flag7 = FormTapKet.gstruct62_0 != null;
					if (flag7)
					{
						Array.Resize<GStruct62>(ref FormTapKet.gstruct62_0, FormTapKet.gstruct62_0.Length + 1);
					}
					else
					{
						FormTapKet.gstruct62_0 = new GStruct62[1];
					}
					int num2 = FormTapKet.gstruct62_0.Length;
					int int_2 = (int)Convert.ToByte(this.checkBoxNhapSL.Checked);
					int int_3 = Class12.smethod_11(this.textBoxNhapSL.Text);
					int int_4 = (int)Convert.ToByte(this.checkBoxMatMa.Checked);
					FormTapKet.gstruct62_0[num2 - 1].string_0 = text3;
					FormTapKet.gstruct62_0[num2 - 1].uint_0 = new uint[]
					{
						array[0],
						array[1]
					};
					FormTapKet.gstruct62_0[num2 - 1].int_1 = int_;
					FormTapKet.gstruct62_0[num2 - 1].string_1 = text2;
					FormTapKet.gstruct62_0[num2 - 1].int_2 = int_2;
					FormTapKet.gstruct62_0[num2 - 1].int_3 = int_3;
					FormTapKet.gstruct62_0[num2 - 1].int_4 = int_4;
					FormTapKet.gstruct62_0[num2 - 1].int_0 = num;
					this.method_0(this.listView1, text3, array, text2, int_, int_2, int_3, int_4);
					bool flag8 = num > 0;
					if (flag8)
					{
						this.listView1.Items[this.listView1.Items.Count - 1].ForeColor = Color.Blue;
					}
				}
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0017FF78 File Offset: 0x0017E178
		private void buttonXoa_Click(object sender, EventArgs e)
		{
			bool flag = FormTapKet.gstruct62_0 != null;
			if (flag)
			{
				int num = -1;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						num = i;
						this.listView1.Items.RemoveAt(num);
						break;
					}
				}
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = 0;
					GStruct62[] array = new GStruct62[FormTapKet.gstruct62_0.Length];
					for (int j = 0; j < FormTapKet.gstruct62_0.Length; j++)
					{
						bool flag3 = num != j;
						if (flag3)
						{
							ref GStruct62 ptr = ref array[num2];
							ptr = FormTapKet.gstruct62_0[j];
							num2++;
						}
					}
					bool flag4 = num2 != 0;
					if (flag4)
					{
						FormTapKet.gstruct62_0 = new GStruct62[num2];
						for (int k = 0; k < num2; k++)
						{
							ref GStruct62 ptr2 = ref FormTapKet.gstruct62_0[k];
							ptr2 = array[k];
						}
					}
					else
					{
						this.listView1.Items.Clear();
						FormTapKet.gstruct62_0 = null;
					}
				}
			}
			else
			{
				this.listView1.Items.Clear();
			}
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x001800DC File Offset: 0x0017E2DC
		private void comboBoxChon_MouseDown(object sender, MouseEventArgs e)
		{
			FormTapKet.gstruct23_0 = null;
			FormTapKet.string_1 = null;
			int num = 0;
			for (int i = 0; i < FormTapKet.string_0.Length; i++)
			{
				bool flag = this.comboBoxNpc.Text == FormTapKet.string_0[i];
				if (flag)
				{
					num = i;
					break;
				}
			}
			bool flag2 = num <= 0;
			if (flag2)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, FormTapKet.int_0);
				bool flag3 = 0 <= num2;
				if (flag3)
				{
					Class98.smethod_26(Form1.gstruct49_0[num2], ref FormTapKet.gstruct23_0, 3, null);
				}
				bool flag4 = FormTapKet.gstruct23_0 == null && Form1.gstruct49_0 != null;
				if (flag4)
				{
					for (int j = 0; j < Form1.gstruct49_0.Length; j++)
					{
						Class98.smethod_26(Form1.gstruct49_0[j], ref FormTapKet.gstruct23_0, 3, null);
					}
				}
			}
			else
			{
				int num3 = Class81.smethod_3(Form1.gstruct49_0, FormTapKet.int_0);
				bool flag5 = 0 <= num3;
				if (flag5)
				{
					FormTapKet.string_1 = Class79.smethod_34(Form1.gstruct49_0[num3], null, 0);
				}
				bool flag6 = FormTapKet.string_1 == null && Form1.gstruct49_0 != null;
				if (flag6)
				{
					for (int k = 0; k < Form1.gstruct49_0.Length; k++)
					{
						Class79.smethod_35(Form1.gstruct49_0[k], ref FormTapKet.string_1, 3, null, false);
					}
				}
			}
			string text = this.comboBoxChon.Text;
			string text2 = string.Empty;
			this.comboBoxChon.Items.Clear();
			bool flag7 = num > 0;
			if (flag7)
			{
				bool flag8 = FormTapKet.string_1 != null;
				if (flag8)
				{
					for (int l = 0; l < FormTapKet.string_1.Length; l++)
					{
						string text3 = Class10.smethod_1(FormTapKet.string_1[l], 1, false);
						this.comboBoxChon.Items.Add(text3);
						bool flag9 = l == 0 || text3 == text;
						if (flag9)
						{
							text2 = text3;
						}
					}
				}
			}
			else
			{
				bool flag10 = FormTapKet.gstruct23_0 != null;
				if (flag10)
				{
					for (int m = 0; m < FormTapKet.gstruct23_0.Length; m++)
					{
						string text4 = Class10.smethod_1(FormTapKet.gstruct23_0[m].string_0, 1, false);
						this.comboBoxChon.Items.Add(text4);
						bool flag11 = m == 0 || text4 == text;
						if (flag11)
						{
							text2 = text4;
						}
					}
				}
			}
			this.comboBoxChon.Text = text2;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0018037C File Offset: 0x0017E57C
		private void buttonSua_Click(object sender, EventArgs e)
		{
			int num = 0;
			for (int i = 0; i < FormTapKet.string_0.Length; i++)
			{
				bool flag = this.comboBoxNpc.Text == FormTapKet.string_0[i];
				if (flag)
				{
					num = i;
					break;
				}
			}
			int num2 = -1;
			for (int j = 0; j < this.listView1.Items.Count; j++)
			{
				bool selected = this.listView1.Items[j].Selected;
				if (selected)
				{
					num2 = j;
					break;
				}
			}
			bool flag2 = num2 < 0;
			if (!flag2)
			{
				bool flag3 = FormTapKet.gstruct62_0 == null || FormTapKet.gstruct62_0.Length <= num2;
				if (flag3)
				{
					this.listView1.Items.Clear();
					FormTapKet.gstruct62_0 = null;
				}
				else
				{
					string text = this.comboBoxChon.Text;
					string text2 = this.textBoxMenu.Text;
					bool flag4 = text2 == null || text2 == string.Empty;
					if (flag4)
					{
						text2 = "0";
					}
					int num3 = (int)Convert.ToByte(this.checkBoxNhapSL.Checked);
					int num4 = Class12.smethod_11(this.textBoxNhapSL.Text);
					int num5 = (int)Convert.ToByte(this.checkBoxMatMa.Checked);
					bool flag5 = text != null && !(text == string.Empty);
					if (flag5)
					{
						string text3 = string.Empty;
						string text4 = string.Empty;
						uint[] array = null;
						int num6 = 0;
						bool flag6 = num <= 0;
						if (flag6)
						{
							for (int k = 0; k < FormTapKet.gstruct23_0.Length; k++)
							{
								bool flag7 = text == Class10.smethod_1(FormTapKet.gstruct23_0[k].string_0, 1, false);
								if (flag7)
								{
									text3 = FormTapKet.gstruct23_0[k].string_0;
									bool flag8 = FormTapKet.gstruct23_0[k].uint_0 != null;
									if (flag8)
									{
										array = new uint[]
										{
											FormTapKet.gstruct23_0[k].uint_0[0],
											FormTapKet.gstruct23_0[k].uint_0[1]
										};
									}
									num6 = FormTapKet.gstruct23_0[k].int_0;
									break;
								}
							}
							text4 = Class37.smethod_1(num6, true);
							bool flag9 = text4 == null || text4 == string.Empty;
							if (flag9)
							{
								text4 = num6.ToString();
							}
						}
						else
						{
							for (int l = 0; l < FormTapKet.string_1.Length; l++)
							{
								bool flag10 = text == Class10.smethod_1(FormTapKet.string_1[l], 1, false);
								if (flag10)
								{
									text3 = FormTapKet.string_1[l];
									array = new uint[]
									{
										1U,
										1U
									};
									break;
								}
							}
							text4 = "Vật phẩm";
						}
						FormTapKet.gstruct62_0[num2].int_2 = num3;
						FormTapKet.gstruct62_0[num2].int_3 = num4;
						FormTapKet.gstruct62_0[num2].string_1 = text2;
						FormTapKet.gstruct62_0[num2].int_4 = num5;
						FormTapKet.gstruct62_0[num2].int_0 = num;
						FormTapKet.gstruct62_0[num2].int_1 = num6;
						FormTapKet.gstruct62_0[num2].string_0 = text3;
						this.listView1.Items[num2].SubItems[1].Text = text;
						this.listView1.Items[num2].SubItems[3].Text = text2;
						this.listView1.Items[num2].SubItems[4].Text = text4;
						this.listView1.Items[num2].SubItems[5].Text = num3.ToString() + ":" + num4.ToString();
						this.listView1.Items[num2].SubItems[6].Text = num5.ToString();
						bool flag11 = array != null;
						if (flag11)
						{
							FormTapKet.gstruct62_0[num2].uint_0 = new uint[]
							{
								array[0],
								array[1]
							};
							this.listView1.Items[num2].SubItems[2].Text = array[0].ToString() + "," + array[1].ToString();
						}
						bool flag12 = num == 0;
						if (flag12)
						{
							this.listView1.Items[num2].ForeColor = Color.Black;
						}
						else
						{
							this.listView1.Items[num2].ForeColor = Color.Blue;
						}
					}
					else
					{
						FormTapKet.gstruct62_0[num2].int_2 = num3;
						FormTapKet.gstruct62_0[num2].int_3 = num4;
						FormTapKet.gstruct62_0[num2].string_1 = text2;
						FormTapKet.gstruct62_0[num2].int_4 = num5;
						FormTapKet.gstruct62_0[num2].int_0 = num;
						this.listView1.Items[num2].SubItems[3].Text = text2;
						this.listView1.Items[num2].SubItems[5].Text = num3.ToString() + ":" + num4.ToString();
						this.listView1.Items[num2].SubItems[6].Text = num5.ToString();
					}
				}
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00180948 File Offset: 0x0017EB48
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			string string_ = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(string_);
			if (flag)
			{
				string_ = Class62.smethod_0();
			}
			Class22.smethod_40(string_, "", "https://youtu.be/H7NtepyTDAY", 0, false, false);
		}

		// Token: 0x04000BE7 RID: 3047
		private IContainer icontainer_0 = null;

		// Token: 0x04000BFF RID: 3071
		public static bool bool_0 = false;

		// Token: 0x04000C00 RID: 3072
		public static int int_0 = 0;

		// Token: 0x04000C01 RID: 3073
		public static bool bool_1 = false;

		// Token: 0x04000C02 RID: 3074
		public static GStruct62[] gstruct62_0 = null;

		// Token: 0x04000C03 RID: 3075
		public int int_1;

		// Token: 0x04000C04 RID: 3076
		public int int_2;

		// Token: 0x04000C05 RID: 3077
		public int int_3;

		// Token: 0x04000C06 RID: 3078
		public int int_4;

		// Token: 0x04000C07 RID: 3079
		private static string[] string_0 = new string[]
		{
			"NPC",
			"Vật phẩm"
		};

		// Token: 0x04000C08 RID: 3080
		private static GStruct23[] gstruct23_0 = null;

		// Token: 0x04000C0A RID: 3082
		private static string[] string_1 = null;
	}
}
