using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000083 RID: 131
	public partial class FormTangdiem : Form
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x0017A244 File Offset: 0x00178444
		public FormTangdiem()
		{
			FormTangdiem.bool_0 = true;
			new Thread(new ThreadStart(FormTangdiem.smethod_2)).Start();
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0017A2A4 File Offset: 0x001784A4
		private static void smethod_0(FormTangdiem.Struct13[] struct13_1, string string_3 = null)
		{
			bool flag = struct13_1 == null;
			if (flag)
			{
				struct13_1 = new FormTangdiem.Struct13[10];
			}
			string text = null;
			for (int i = 0; i < struct13_1.Length; i++)
			{
				int[] array = struct13_1[i].int_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new int[4];
				}
				string text2 = null;
				for (int j = 0; j < array.Length; j++)
				{
					bool flag3 = text2 != null && text2 != string.Empty;
					if (flag3)
					{
						text2 += ";";
					}
					text2 += array[j].ToString();
				}
				bool flag4 = text != null && text != string.Empty;
				if (flag4)
				{
					text += "\r\n";
				}
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					i,
					"=",
					text2
				});
			}
			bool flag5 = string_3 == null || string_3 == string.Empty;
			if (flag5)
			{
				string_3 = Class53.string_8 + "\\" + FormTangdiem.string_2;
			}
			string[] array2 = Class12.smethod_14(string_3, '\\');
			Class12.smethod_23(array2[0]);
			Class12.smethod_34(string_3, text, 1);
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0017A3F4 File Offset: 0x001785F4
		private static FormTangdiem.Struct13[] smethod_1(string string_3 = null, bool bool_2 = false)
		{
			bool flag = string_3 == null || string_3 == string.Empty;
			if (flag)
			{
				string_3 = Class53.string_8 + "\\" + FormTangdiem.string_2;
			}
			int num = 10;
			FormTangdiem.Struct13[] array = new FormTangdiem.Struct13[num];
			array[0].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				10,
				0,
				14,
				0,
				8,
				0,
				4,
				0,
				6,
				0,
				15,
				0,
				16,
				0,
				20,
				0,
				271,
				0,
				11,
				0,
				19,
				0,
				273,
				0,
				21,
				0
			};
			array[1].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				29,
				0,
				34,
				0,
				30,
				0,
				26,
				0,
				23,
				0,
				24,
				0,
				33,
				0,
				37,
				0,
				35,
				0,
				31,
				0,
				40,
				0,
				42,
				0,
				32,
				0,
				36,
				0,
				41,
				0,
				324,
				0
			};
			array[2].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				45,
				0,
				43,
				0,
				347,
				0,
				303,
				0,
				50,
				0,
				54,
				0,
				47,
				0,
				343,
				0,
				345,
				0,
				349,
				0,
				249,
				0,
				48,
				0,
				58,
				0,
				341,
				0,
				351,
				0,
				1110,
				0
			};
			array[3].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				63,
				0,
				65,
				0,
				62,
				0,
				60,
				0,
				67,
				0,
				70,
				0,
				66,
				0,
				68,
				0,
				384,
				0,
				64,
				0,
				69,
				0,
				356,
				0,
				73,
				0,
				72,
				0,
				71,
				0,
				75,
				0,
				74,
				0,
				390,
				0
			};
			array[4].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				80,
				0,
				101,
				0,
				85,
				0,
				77,
				0,
				79,
				0,
				93,
				0,
				385,
				0,
				82,
				0,
				89,
				0,
				86,
				0,
				92,
				0,
				88,
				0,
				252,
				0,
				91,
				0,
				282,
				0,
				332,
				0
			};
			array[5].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				99,
				0,
				102,
				0,
				95,
				0,
				97,
				0,
				269,
				0,
				105,
				0,
				113,
				0,
				100,
				0,
				109,
				0,
				108,
				0,
				114,
				0,
				111,
				0
			};
			array[6].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				117,
				0,
				122,
				0,
				119,
				0,
				116,
				0,
				115,
				0,
				129,
				0,
				274,
				0,
				124,
				0,
				277,
				0,
				128,
				0,
				125,
				0,
				130,
				0,
				360,
				0
			};
			array[7].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				135,
				0,
				145,
				0,
				132,
				0,
				131,
				0,
				136,
				0,
				137,
				0,
				141,
				0,
				138,
				0,
				140,
				0,
				364,
				0,
				143,
				0,
				142,
				0,
				150,
				0,
				148,
				0,
				391,
				0
			};
			array[8].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				153,
				0,
				155,
				0,
				152,
				0,
				151,
				0,
				159,
				0,
				164,
				0,
				158,
				0,
				160,
				0,
				157,
				0,
				165,
				0,
				166,
				0,
				267,
				0
			};
			array[9].int_0 = new int[]
			{
				0,
				0,
				0,
				2,
				0,
				0,
				1,
				0,
				0,
				3,
				0,
				0,
				169,
				0,
				179,
				0,
				167,
				0,
				168,
				0,
				392,
				0,
				171,
				0,
				174,
				0,
				178,
				0,
				172,
				0,
				393,
				0,
				173,
				0,
				175,
				0,
				181,
				0,
				176,
				0,
				90,
				0,
				275,
				0,
				182,
				0,
				630,
				0,
				394,
				0
			};
			FormTangdiem.Struct13[] array2 = new FormTangdiem.Struct13[num];
			string text = Class12.smethod_33(string_3, 0, 0, 1);
			bool flag2 = !bool_2 && text != null && !(text == string.Empty);
			if (flag2)
			{
				int[] array3 = new int[num];
				string[] array4 = text.Split(new char[]
				{
					'\r',
					'\n'
				});
				int num2 = 0;
				for (;;)
				{
					bool flag3 = num2 < array4.Length;
					if (!flag3)
					{
						goto IL_2EB;
					}
					bool flag4 = array4[num2] != null && !(array4[num2] == string.Empty);
					if (flag4)
					{
						string[] array5 = array4[num2].Split(new char[]
						{
							'='
						});
						bool flag5 = array5.Length == 2;
						if (flag5)
						{
							int num3 = Class12.smethod_11(array5[0].Trim());
							bool flag6 = num3 >= 0 && num > num3;
							if (flag6)
							{
								string[] array6 = array5[1].Trim().Split(new char[]
								{
									';',
									','
								});
								bool flag7 = array6.Length != array[num3].int_0.Length;
								if (flag7)
								{
									break;
								}
								array2[num3].int_0 = new int[array6.Length];
								for (int i = 0; i < array6.Length; i++)
								{
									array2[num3].int_0[i] = Class12.smethod_11(array6[i].Trim());
								}
								array3[num3] = 1;
							}
						}
					}
					num2++;
				}
				goto IL_360;
				IL_2EB:
				num2 = 0;
				for (;;)
				{
					bool flag8 = num2 < array.Length;
					if (!flag8)
					{
						goto IL_349;
					}
					bool flag9 = array2[num2].int_0 == null || array2[num2].int_0.Length != array[num2].int_0.Length || array3[num2] == 0;
					if (flag9)
					{
						break;
					}
					num2++;
				}
				goto IL_360;
				IL_349:
				return array2;
				IL_360:;
			}
			array2 = new FormTangdiem.Struct13[array.Length];
			for (int j = 0; j < array.Length; j++)
			{
				bool flag10 = array[j].int_0 != null;
				if (flag10)
				{
					array2[j].int_0 = new int[array[j].int_0.Length];
					for (int k = 0; k < array[j].int_0.Length; k++)
					{
						array2[j].int_0[k] = array[j].int_0[k];
					}
				}
			}
			return array2;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0017A814 File Offset: 0x00178A14
		private void method_0()
		{
			int num = FormTangdiem.int_4;
			FormTangdiem.int_4 = 0;
			try
			{
				this.method_1(num);
			}
			catch
			{
				int num2 = 0;
				byte[] byte_ = new byte[4];
				bool flag = Form1.gstruct49_0 == null;
				if (!flag)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag2 = num == Form1.gstruct49_0[i].int_136;
						if (flag2)
						{
							Class22.WriteProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_15 + Class70.uint_40 * 4U, byte_, 1, ref num2);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0017A8D8 File Offset: 0x00178AD8
		private void method_1(int int_7)
		{
			bool flag = int_7 == 0 || FormTangdiem.struct13_0 == null;
			if (!flag)
			{
				GStruct49 gstruct = default(GStruct49);
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = int_7 == Form1.gstruct49_0[i].int_136;
						if (flag3)
						{
							gstruct = Form1.gstruct49_0[i];
							break;
						}
					}
				}
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_40 * 4U, array, 1, ref num);
				bool flag4 = array[0] > 0;
				if (!flag4)
				{
					array[0] = 1;
					Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_40 * 4U, array, 1, ref num);
					Class70.smethod_52(gstruct, "<bclr=blue><color=green>* B¾t ®Çu t¨ng ®iÓm tiÒm n¨ng vµ kü n¨ng", 1);
					bool flag5 = false;
					string text = Class77.smethod_18(gstruct, null);
					int num2 = -1;
					bool flag6 = text != null && text != string.Empty;
					if (flag6)
					{
						for (int j = 0; j < FormTangdiem.string_1.GetLength(0); j++)
						{
							bool flag7 = text == FormTangdiem.string_1[j, 1];
							if (flag7)
							{
								num2 = j;
								break;
							}
						}
					}
					bool flag8 = num2 >= 0;
					if (flag8)
					{
						int[] array2 = null;
						int[] array3 = null;
						for (int k = 0; k < 4; k++)
						{
							bool flag9 = FormTangdiem.struct13_0[num2].int_0[k * 3 + 1] != 0;
							if (flag9)
							{
								bool flag10 = array2 != null;
								if (flag10)
								{
									Array.Resize<int>(ref array2, array2.Length + 1);
									Array.Resize<int>(ref array3, array3.Length + 1);
								}
								else
								{
									array2 = new int[1];
									array3 = new int[1];
								}
								array2[array2.Length - 1] = FormTangdiem.struct13_0[num2].int_0[k * 3];
								array3[array3.Length - 1] = FormTangdiem.struct13_0[num2].int_0[k * 3 + 2];
							}
						}
						int num3 = 0;
						int num4 = 0;
						int num5 = 0;
						int num6 = 0;
						int num7 = 0;
						for (;;)
						{
							Thread.Sleep(100);
							bool flag11 = Class12.bool_0 || Class22.smethod_52(gstruct.process_0) || num2 < 0;
							if (flag11)
							{
								break;
							}
							Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_40 * 4U, array, 1, ref num);
							bool flag12 = array[0] == 0;
							if (flag12)
							{
								break;
							}
							bool flag13 = !flag5 && array2 != null && array2.Length > num3;
							if (flag13)
							{
								int num8 = Class36.smethod_44(gstruct);
								bool flag14 = num8 != 0;
								if (flag14)
								{
									int num9 = array2[num3];
									int num10 = Class36.smethod_43(gstruct, num9)[1];
									bool flag15 = num10 <= array3[num3];
									if (flag15)
									{
										int num11 = array3[num3] - num10;
										bool flag16 = num11 > 233;
										if (flag16)
										{
											num11 = 233;
										}
										bool flag17 = num11 > num8;
										if (flag17)
										{
											num11 = num8;
										}
										bool flag18 = num11 > 0;
										if (flag18)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_7 + Class53.gstruct51_172.uint_0, array, 4, ref num);
											bool flag19 = BitConverter.ToUInt32(array, 0) > 0U;
											if (flag19)
											{
												Class22.smethod_4(gstruct.uint_4, 13U);
												Thread.Sleep(100);
											}
											bool flag20 = !Class70.smethod_107(gstruct, num9);
											if (flag20)
											{
												bool flag21 = num5 < 3;
												if (flag21)
												{
													Thread.Sleep(800);
													num5++;
													continue;
												}
											}
											else
											{
												num5 = 0;
												int l;
												for (l = 0; l < 100; l++)
												{
													Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_7 + Class53.gstruct51_172.uint_0, array, 4, ref num);
													bool flag22 = BitConverter.ToUInt32(array, 0) == 0U;
													if (!flag22)
													{
														l = -1;
														break;
													}
													Thread.Sleep(10);
												}
												bool flag23 = l < 0;
												if (flag23)
												{
													Class45.smethod_5(gstruct, num11.ToString(), true);
													for (l = 0; l < 100; l++)
													{
														int num12 = Class36.smethod_43(gstruct, num9)[1];
														bool flag24 = num12 <= num10;
														if (!flag24)
														{
															l = -1;
															break;
														}
														Thread.Sleep(10);
													}
													bool flag25 = l < 0;
													if (flag25)
													{
														continue;
													}
												}
												bool flag26 = num6 < 3;
												if (flag26)
												{
													num6++;
													Thread.Sleep(800);
													continue;
												}
											}
										}
									}
									num3++;
									num5 = 0;
									num6 = 0;
									continue;
								}
								flag5 = true;
							}
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
							uint uint_ = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_71.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 4, ref num);
							int num13 = BitConverter.ToInt32(array, 0);
							bool flag27 = num13 <= 0;
							if (flag27)
							{
								break;
							}
							int num14 = -1;
							for (int m = 12 + num4; m < FormTangdiem.struct13_0[num2].int_0.Length; m++)
							{
								bool flag28 = FormTangdiem.struct13_0[num2].int_0[m] > 0 && FormTangdiem.struct13_0[num2].int_0[m + 1] > 0;
								if (flag28)
								{
									int num15 = Class77.smethod_16(gstruct, FormTangdiem.struct13_0[num2].int_0[m]);
									bool flag29 = FormTangdiem.struct13_0[num2].int_0[m + 1] > num15;
									if (flag29)
									{
										num4 = m - 12;
										num14 = m;
										break;
									}
								}
								m++;
							}
							bool flag30 = num14 < 0;
							if (flag30)
							{
								break;
							}
							int num16 = FormTangdiem.struct13_0[num2].int_0[num14];
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
							uint num17 = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_13.uint_0, array, 4, ref num);
							uint num18 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
							uint num19 = BitConverter.ToUInt32(array, 0);
							uint num20 = num18 + num19 + Class53.gstruct51_161.uint_0 + Class53.gstruct51_162.uint_0;
							int n = 0;
							int num21 = -1;
							while (n < 80)
							{
								n++;
								Class22.ReadProcessMemory(gstruct.int_137, num20, array, 4, ref num);
								bool flag31 = (ulong)BitConverter.ToUInt32(array, 0) != (ulong)((long)num16);
								if (!flag31)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num20 + 4U, array, 4, ref num);
									num21 = BitConverter.ToInt32(array, 0);
									break;
								}
								num20 += Class53.gstruct51_163.uint_0;
							}
							int num22 = FormTangdiem.struct13_0[num2].int_0[num14 + 1] - num21;
							bool flag32 = num21 >= 0 && num22 > 0;
							if (flag32)
							{
								bool flag33 = num22 > num13;
								if (flag33)
								{
									num22 = num13;
								}
								bool flag34 = num22 + num21 > 20;
								if (flag34)
								{
									num22 = 20 - num21;
								}
								bool flag35 = num22 <= 0;
								if (flag35)
								{
									num22 = 1;
								}
								byte[] byte_ = new byte[]
								{
									(byte)num22
								};
								byte[] bytes = BitConverter.GetBytes(num16);
								Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_41 + 15U, bytes, 4, ref num);
								Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_41 + 36U, byte_, 1, ref num);
								Class70.smethod_12(gstruct.int_137, gstruct.uint_41);
								for (int num23 = 0; num23 < 100; num23++)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num20 + 4U, array, 4, ref num);
									int num24 = BitConverter.ToInt32(array, 0);
									bool flag36 = num24 <= num21;
									if (!flag36)
									{
										break;
									}
									Thread.Sleep(10);
								}
								Class22.ReadProcessMemory(gstruct.int_137, num20 + 4U, array, 4, ref num);
								int num25 = BitConverter.ToInt32(array, 0);
								bool flag37 = FormTangdiem.struct13_0[num2].int_0[num14 + 1] > num25;
								if (flag37)
								{
									bool flag38 = num25 > num21;
									if (flag38)
									{
										num7 = 0;
										continue;
									}
									bool flag39 = num7 < 2;
									if (flag39)
									{
										num7++;
										continue;
									}
								}
							}
							num4++;
							num7 = 0;
						}
					}
					array[0] = 0;
					Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_40 * 4U, array, 1, ref num);
					Class70.smethod_52(gstruct, "<bclr=blue><color=green>* KÕt thóc t¨ng ®iÓm", 1);
				}
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0017B1B4 File Offset: 0x001793B4
		private static void smethod_2()
		{
			bool flag = FormTangdiem.bool_1;
			if (!flag)
			{
				FormTangdiem.bool_1 = true;
				int num = 0;
				string string_ = Class53.string_9 + "\\tbSkill.txt";
				string[] array = null;
				for (;;)
				{
					string text = Class12.smethod_33(string_, 0, 0, 1);
					bool flag2 = text == null;
					if (!flag2)
					{
						goto IL_E6;
					}
					for (;;)
					{
						num++;
						string text2 = null;
						bool flag3 = num == 1;
						if (flag3)
						{
							text2 = "ᔣᔯᔯᔫᔮᓵᓪᓪᔟᔭᔤᔱᔠᓩᔢᔪᔪᔢᔧᔠᓩᔞᔪᔨᓪᔡᔤᔧᔠᓪᔟᓪᓬᔚᔉᔆᔵᔢᔆᓫᔂᔝᔆᓮᔄᔂᓨᓫᔦᔱᔜᔎᔩᔁᔕᔎᔓᔉᓱᔧᔪᔱᔠᔂᔐᓪᔱᔤᔠᔲᓺᔰᔮᔫᓸᔮᔣᔜᔭᔤᔩᔢ";
						}
						else
						{
							bool flag4 = num == 2;
							if (flag4)
							{
								text2 = "ᓹᔅᔅᔁᓋᓀᓀᓼᓺᓾᔊᓶᓿᒿᓿᓶᔅᓀᔆᔁᓽᔀᓲᓵᓀᔅᓾᔁᓀᔅᓳᓤᓼᓺᓽᓽᒿᔅᔉᔅ";
							}
						}
						bool flag5 = text2 == null || text2 == string.Empty;
						if (flag5)
						{
							goto Block_6;
						}
						try
						{
							Class12.smethod_23(Class53.string_9);
							FileInfo fileInfo = Class67.smethod_0(Class12.smethod_53(text2), string_);
							bool flag6 = fileInfo != null && fileInfo.Exists;
							if (flag6)
							{
								break;
							}
						}
						catch
						{
							break;
						}
					}
				}
				Block_6:
				goto IL_1E2;
				IL_E6:
				int num2 = 0;
				FormTangdiem.gstruct56_0 = new GStruct56[array.Length];
				foreach (string text3 in array)
				{
					bool flag7 = text3 != null && !(text3 == string.Empty);
					if (flag7)
					{
						int num3 = text3.IndexOf("=");
						bool flag8 = num3 >= 0;
						if (flag8)
						{
							string string_2 = text3.Substring(0, num3);
							string text4 = text3.Substring(num3 + 1);
							FormTangdiem.gstruct56_0[num2].int_1 = Class12.smethod_11(string_2);
							FormTangdiem.gstruct56_0[num2].string_0 = text4;
							num2++;
						}
					}
				}
				bool flag9 = num2 != 0;
				if (flag9)
				{
					bool flag10 = num2 < FormTangdiem.gstruct56_0.Length;
					if (flag10)
					{
						Array.Resize<GStruct56>(ref FormTangdiem.gstruct56_0, num2);
					}
				}
				else
				{
					FormTangdiem.gstruct56_0 = null;
				}
				IL_1E2:
				FormTangdiem.bool_1 = false;
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0017B3BC File Offset: 0x001795BC
		private static GStruct56 smethod_3(int int_7)
		{
			bool flag = FormTangdiem.gstruct56_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormTangdiem.gstruct56_0.Length; i++)
				{
					bool flag2 = int_7 == FormTangdiem.gstruct56_0[i].int_1;
					if (flag2)
					{
						return FormTangdiem.gstruct56_0[i];
					}
				}
			}
			return new GStruct56
			{
				int_1 = -1,
				string_0 = string.Empty
			};
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0017B43B File Offset: 0x0017963B
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTangdiem.smethod_0(FormTangdiem.struct13_0, null);
			FormTangdiem.bool_0 = false;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0017B450 File Offset: 0x00179650
		private void FormTangdiem_Load(object sender, EventArgs e)
		{
			try
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
				this.method_3();
				Color color = Color.DarkRed;
				for (int i = 0; i < FormTangdiem.string_1.GetLength(0); i++)
				{
					this.listViewMonPhai.Items.Add(FormTangdiem.string_1[i, 0]);
					bool flag4 = i % 2 == 0;
					if (flag4)
					{
						color = ((color != Color.DarkRed) ? Color.DarkRed : Color.DarkBlue);
					}
					this.listViewMonPhai.Items[this.listViewMonPhai.Items.Count - 1].ForeColor = color;
				}
				this.listViewMonPhai.Items[0].Selected = true;
				FormTangdiem.int_5 = 0;
				FormTangdiem.int_6 = -1;
				this.timer_0.Interval = 100;
				this.timer_0.Enabled = true;
				base.TopMost = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0017B5D8 File Offset: 0x001797D8
		private void method_2(ListView listView_0, string[] string_3)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem(string_3[0]);
				for (int i = 1; i < string_3.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_3[i]);
					listViewItem.SubItems.Add(item);
				}
				listView_0.Items.Add(listViewItem);
			}
			catch
			{
			}
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0017B640 File Offset: 0x00179840
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTangdiem.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormTangdiem.int_6 != FormTangdiem.int_5 && FormTangdiem.gstruct56_0 != null && !FormTangdiem.bool_1;
				if (flag2)
				{
					FormTangdiem.int_6 = FormTangdiem.int_5;
					this.method_4();
					this.method_5();
					this.labelTong.Text = this.method_6();
				}
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0017B6B4 File Offset: 0x001798B4
		private void method_3()
		{
			this.comboBoxAc.Items.Clear();
			string text = string.Empty;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					string str = Class10.smethod_1(Class77.smethod_18(Form1.gstruct49_0[i], Class77.smethod_18(Form1.gstruct49_0[i], null)), 1, false);
					string text2 = Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false) + " ( " + str + ")";
					bool flag2 = text == string.Empty;
					if (flag2)
					{
						text = text2;
					}
					this.comboBoxAc.Items.Add(text2);
				}
			}
			bool flag3 = text != null && text != string.Empty;
			if (flag3)
			{
				this.comboBoxAc.Text = text;
			}
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0017B7A4 File Offset: 0x001799A4
		private void method_4()
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count <= 0;
			if (!flag)
			{
				int num = this.listViewMonPhai.SelectedIndices[0];
				bool flag2 = FormTangdiem.struct13_0 == null;
				if (flag2)
				{
					FormTangdiem.struct13_0 = FormTangdiem.smethod_1(null, false);
				}
				bool flag3 = this.listViewTiemNang.Items.Count > 0;
				if (flag3)
				{
					this.listViewTiemNang.Items.Clear();
				}
				for (int i = 0; i < FormTangdiem.string_0.Length; i++)
				{
					int num2 = FormTangdiem.struct13_0[num].int_0[i * 3];
					int num3 = FormTangdiem.struct13_0[num].int_0[i * 3 + 2];
					this.method_2(this.listViewTiemNang, new string[]
					{
						FormTangdiem.string_0[num2],
						num3.ToString()
					});
				}
				for (int j = 0; j < FormTangdiem.string_0.Length; j++)
				{
					bool flag4 = j < this.listViewTiemNang.Items.Count;
					if (flag4)
					{
						int num4 = FormTangdiem.struct13_0[num].int_0[j * 3 + 1];
						bool flag5 = num4 > 0;
						if (flag5)
						{
							this.listViewTiemNang.Items[j].Checked = true;
						}
					}
				}
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0017B910 File Offset: 0x00179B10
		private void method_5()
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count <= 0;
			if (!flag)
			{
				int num = this.listViewMonPhai.SelectedIndices[0];
				bool flag2 = FormTangdiem.struct13_0 == null;
				if (flag2)
				{
					FormTangdiem.struct13_0 = FormTangdiem.smethod_1(null, false);
				}
				bool flag3 = this.listViewKyNang.Items.Count > 0;
				if (flag3)
				{
					this.listViewKyNang.Items.Clear();
				}
				int num2 = 12;
				int num3 = FormTangdiem.struct13_0[num].int_0.Length;
				bool flag4 = FormTangdiem.struct13_0[num].string_0 == null;
				if (flag4)
				{
					FormTangdiem.struct13_0[num].string_0 = new string[num3];
				}
				for (int i = num2; i < num3; i++)
				{
					int int_ = FormTangdiem.struct13_0[num].int_0[i];
					int num4 = FormTangdiem.struct13_0[num].int_0[i + 1];
					bool flag5 = FormTangdiem.struct13_0[num].string_0[i] == null || FormTangdiem.struct13_0[num].string_0[i] == string.Empty;
					if (flag5)
					{
						FormTangdiem.struct13_0[num].string_0[i] = FormTangdiem.smethod_3(int_).string_0;
					}
					this.method_2(this.listViewKyNang, new string[]
					{
						FormTangdiem.struct13_0[num].string_0[i],
						num4.ToString(),
						int_.ToString()
					});
					i++;
				}
			}
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0017BAB8 File Offset: 0x00179CB8
		private string method_6()
		{
			int num = 0;
			for (int i = 0; i < this.listViewKyNang.Items.Count; i++)
			{
				int num2 = Class12.smethod_11(this.listViewKyNang.Items[i].SubItems[1].Text);
				num += num2;
			}
			return num.ToString();
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0017BB24 File Offset: 0x00179D24
		private void listViewMonPhai_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count > 0;
			if (flag)
			{
				FormTangdiem.int_5 = this.listViewMonPhai.SelectedIndices[0];
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0017BB60 File Offset: 0x00179D60
		private void listViewTiemNang_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count > 0;
			if (flag)
			{
				int num = this.listViewMonPhai.SelectedIndices[0];
				int index = e.Index;
				FormTangdiem.struct13_0[num].int_0[index * 3 + 1] = (int)Convert.ToByte(e.NewValue == CheckState.Checked);
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0017BBC4 File Offset: 0x00179DC4
		private void listViewTiemNang_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listViewTiemNang.SelectedIndices.Count > 0;
			if (flag)
			{
				int index = this.listViewTiemNang.SelectedIndices[0];
				this.textBoxTiemNang.Text = this.listViewTiemNang.Items[index].SubItems[1].Text;
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0017BC2C File Offset: 0x00179E2C
		private void listViewKyNang_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.listViewKyNang.SelectedIndices.Count > 0;
			if (flag)
			{
				int index = this.listViewKyNang.SelectedIndices[0];
				this.textBoxKyNang.Text = this.listViewKyNang.Items[index].SubItems[1].Text;
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0017BC94 File Offset: 0x00179E94
		private void buttonLen_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count <= 0 || this.listViewTiemNang.SelectedIndices.Count <= 0;
			if (!flag)
			{
				int num = this.listViewTiemNang.SelectedIndices[0];
				bool flag2 = num > 0;
				if (flag2)
				{
					int num2 = this.listViewMonPhai.SelectedIndices[0];
					int[] array = new int[]
					{
						FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3],
						FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3 + 1],
						FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3 + 2]
					};
					FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3] = FormTangdiem.struct13_0[num2].int_0[num * 3];
					FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3 + 1] = FormTangdiem.struct13_0[num2].int_0[num * 3 + 1];
					FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3 + 2] = FormTangdiem.struct13_0[num2].int_0[num * 3 + 2];
					FormTangdiem.struct13_0[num2].int_0[num * 3] = array[0];
					FormTangdiem.struct13_0[num2].int_0[num * 3 + 1] = array[1];
					FormTangdiem.struct13_0[num2].int_0[num * 3 + 2] = array[2];
					for (int i = 0; i < this.listViewTiemNang.Items[num].SubItems.Count; i++)
					{
						string text = this.listViewTiemNang.Items[num - 1].SubItems[i].Text;
						this.listViewTiemNang.Items[num - 1].SubItems[i].Text = this.listViewTiemNang.Items[num].SubItems[i].Text;
						this.listViewTiemNang.Items[num].SubItems[i].Text = text;
					}
					this.listViewTiemNang.Items[num - 1].Selected = true;
					this.listViewTiemNang.Items[num - 1].Checked = (FormTangdiem.struct13_0[num2].int_0[(num - 1) * 3 + 1] > 0);
					this.listViewTiemNang.Items[num].Selected = false;
					this.listViewTiemNang.Items[num].Checked = (FormTangdiem.struct13_0[num2].int_0[num * 3 + 1] > 0);
				}
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0017BF94 File Offset: 0x0017A194
		private void buttonXuong_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count <= 0 || this.listViewTiemNang.SelectedIndices.Count <= 0;
			if (!flag)
			{
				int num = this.listViewTiemNang.SelectedIndices[0];
				bool flag2 = num <= 2;
				if (flag2)
				{
					int num2 = this.listViewMonPhai.SelectedIndices[0];
					int[] array = new int[]
					{
						FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3],
						FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3 + 1],
						FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3 + 2]
					};
					FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3] = FormTangdiem.struct13_0[num2].int_0[num * 3];
					FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3 + 1] = FormTangdiem.struct13_0[num2].int_0[num * 3 + 1];
					FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3 + 2] = FormTangdiem.struct13_0[num2].int_0[num * 3 + 2];
					FormTangdiem.struct13_0[num2].int_0[num * 3] = array[0];
					FormTangdiem.struct13_0[num2].int_0[num * 3 + 1] = array[1];
					FormTangdiem.struct13_0[num2].int_0[num * 3 + 2] = array[2];
					for (int i = 0; i < this.listViewTiemNang.Items[num].SubItems.Count; i++)
					{
						string text = this.listViewTiemNang.Items[num + 1].SubItems[i].Text;
						this.listViewTiemNang.Items[num + 1].SubItems[i].Text = this.listViewTiemNang.Items[num].SubItems[i].Text;
						this.listViewTiemNang.Items[num].SubItems[i].Text = text;
					}
					this.listViewTiemNang.Items[num + 1].Selected = true;
					this.listViewTiemNang.Items[num + 1].Checked = (FormTangdiem.struct13_0[num2].int_0[(num + 1) * 3 + 1] > 0);
					this.listViewTiemNang.Items[num].Selected = false;
					this.listViewTiemNang.Items[num].Checked = (FormTangdiem.struct13_0[num2].int_0[num * 3 + 1] > 0);
				}
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0017C294 File Offset: 0x0017A494
		private void textBoxTiemNang_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count > 0 && this.listViewTiemNang.SelectedIndices.Count > 0;
			if (flag)
			{
				int num = this.listViewTiemNang.SelectedIndices[0];
				int num2 = this.listViewMonPhai.SelectedIndices[0];
				FormTangdiem.struct13_0[num2].int_0[num * 3 + 2] = Class12.smethod_11(this.textBoxTiemNang.Text);
				this.listViewTiemNang.Items[num].SubItems[1].Text = FormTangdiem.struct13_0[num2].int_0[num * 3 + 2].ToString();
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0017C360 File Offset: 0x0017A560
		private void textBoxKyNang_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = this.listViewMonPhai.SelectedIndices.Count > 0 && this.listViewKyNang.SelectedIndices.Count > 0;
			if (flag)
			{
				int num = this.listViewKyNang.SelectedIndices[0];
				int num2 = this.listViewMonPhai.SelectedIndices[0];
				FormTangdiem.struct13_0[num2].int_0[12 + num * 2 + 1] = Class12.smethod_11(this.textBoxKyNang.Text);
				this.listViewKyNang.Items[num].SubItems[1].Text = FormTangdiem.struct13_0[num2].int_0[12 + num * 2 + 1].ToString();
				this.labelTong.Text = this.method_6();
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0017C444 File Offset: 0x0017A644
		private void buttonLuu_Click(object sender, EventArgs e)
		{
			string[] array = Class12.smethod_14(Class53.string_8 + "\\" + FormTangdiem.string_2, '\\');
			Class12.smethod_23(array[0]);
			string text = Class53.smethod_27(array[0], "MAU_TANG_DIEM.TXT");
			bool flag = !(text == string.Empty);
			if (flag)
			{
				FormTangdiem.smethod_0(FormTangdiem.struct13_0, text);
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0017C4A4 File Offset: 0x0017A6A4
		private void buttonDocLuu_Click(object sender, EventArgs e)
		{
			string[] array = Class12.smethod_14(Class53.string_8 + "\\" + FormTangdiem.string_2, '\\');
			Class12.smethod_23(array[0]);
			string text = Class53.smethod_26(array[0], "", "*.TXT", "");
			bool flag = !(text == string.Empty);
			if (flag)
			{
				FormTangdiem.struct13_0 = FormTangdiem.smethod_1(text, false);
				this.listViewMonPhai.Items[0].Selected = true;
				FormTangdiem.int_5 = 0;
				FormTangdiem.int_6 = -1;
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0017C533 File Offset: 0x0017A733
		private void buttonXoaAll_Click(object sender, EventArgs e)
		{
			FormTangdiem.struct13_0 = FormTangdiem.smethod_1(null, true);
			this.listViewMonPhai.Items[0].Selected = true;
			FormTangdiem.int_5 = 0;
			FormTangdiem.int_6 = -1;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0017C568 File Offset: 0x0017A768
		private void buttonTangdiem_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxAc.Text;
			bool flag = text == null || text == string.Empty;
			if (!flag)
			{
				int num = text.IndexOf("(");
				bool flag2 = num > 0;
				if (flag2)
				{
					text = text.Substring(0, num - 1);
				}
				int num2 = 0;
				bool flag3 = Form1.gstruct49_0 != null;
				if (flag3)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag4 = text == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
						if (flag4)
						{
							num2 = Form1.gstruct49_0[i].int_136;
							break;
						}
					}
				}
				bool flag5 = num2 > 0;
				if (flag5)
				{
					FormTangdiem.int_4 = num2;
					new Thread(new ThreadStart(this.method_0)).Start();
				}
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0017C650 File Offset: 0x0017A850
		private void buttonTangAll_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Form1.gstruct49_0 == null;
				if (!flag)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						int num = 0;
						while (FormTangdiem.int_4 > 0 && num < 100)
						{
							Thread.Sleep(10);
							num++;
						}
						FormTangdiem.int_4 = Form1.gstruct49_0[i].int_136;
						new Thread(new ThreadStart(this.method_0)).Start();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0017C6F4 File Offset: 0x0017A8F4
		private void buttonStop_Click(object sender, EventArgs e)
		{
			int num = 0;
			byte[] byte_ = new byte[1];
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class22.WriteProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_15 + Class70.uint_40 * 4U, byte_, 1, ref num);
				}
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0017C765 File Offset: 0x0017A965
		private void buttonReFresh_Click(object sender, EventArgs e)
		{
			this.method_3();
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0017C76F File Offset: 0x0017A96F
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormTangdiem.bool_0 = false;
			base.Close();
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0017C780 File Offset: 0x0017A980
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0017D8E4 File Offset: 0x0017BAE4
		// Note: this type is marked as 'beforefieldinit'.
		static FormTangdiem()
		{
			string[,] array = new string[10, 2];
			array[0, 0] = "Thiếu Lâm";
			array[0, 1] = "THIEULAM";
			array[1, 0] = "Thiên Vương";
			array[1, 1] = "THIENVUONG";
			array[2, 0] = "Đường Môn";
			array[2, 1] = "DUONGMON";
			array[3, 0] = "Ngũ Độc";
			array[3, 1] = "NGUDOC";
			array[4, 0] = "Nga My";
			array[4, 1] = "NGAMY";
			array[5, 0] = "Thúy Yên";
			array[5, 1] = "THUYYEN";
			array[6, 0] = "Cái Bang";
			array[6, 1] = "CAIBANG";
			array[7, 0] = "Thiên Nhẫn";
			array[7, 1] = "THIENNHAN";
			array[8, 0] = "Võ Đang";
			array[8, 1] = "VODANG";
			array[9, 0] = "Côn Lôn";
			array[9, 1] = "CONLON";
			FormTangdiem.string_1 = array;
			FormTangdiem.struct13_0 = null;
			FormTangdiem.string_2 = "TANGDIEM\\Tangdiem.txt";
			FormTangdiem.int_4 = 0;
			FormTangdiem.gstruct56_0 = null;
			FormTangdiem.bool_1 = false;
			FormTangdiem.int_5 = 0;
			FormTangdiem.int_6 = -1;
		}

		// Token: 0x04000BBE RID: 3006
		public static bool bool_0 = false;

		// Token: 0x04000BBF RID: 3007
		public int int_0 = 0;

		// Token: 0x04000BC0 RID: 3008
		public int int_1 = 0;

		// Token: 0x04000BC1 RID: 3009
		public int int_2;

		// Token: 0x04000BC2 RID: 3010
		public int int_3;

		// Token: 0x04000BC3 RID: 3011
		private static string[] string_0 = new string[]
		{
			"Sức mạnh",
			"Thân pháp",
			"Sinh khí",
			"Nội công"
		};

		// Token: 0x04000BC4 RID: 3012
		private static string[,] string_1;

		// Token: 0x04000BC5 RID: 3013
		private static FormTangdiem.Struct13[] struct13_0;

		// Token: 0x04000BC6 RID: 3014
		private static string string_2;

		// Token: 0x04000BC7 RID: 3015
		private static int int_4;

		// Token: 0x04000BC8 RID: 3016
		private static GStruct56[] gstruct56_0;

		// Token: 0x04000BC9 RID: 3017
		private static bool bool_1;

		// Token: 0x04000BCA RID: 3018
		private static int int_5;

		// Token: 0x04000BCB RID: 3019
		private static int int_6;

		// Token: 0x04000BCC RID: 3020
		private IContainer icontainer_0 = null;

		// Token: 0x020000FF RID: 255
		private struct Struct13
		{
			// Token: 0x04001271 RID: 4721
			public int[] int_0;

			// Token: 0x04001272 RID: 4722
			public string[] string_0;
		}
	}
}
