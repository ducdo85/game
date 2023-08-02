using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000078 RID: 120
	public partial class FormMayphu : Form
	{
		// Token: 0x060009A6 RID: 2470 RVA: 0x0015FB40 File Offset: 0x0015DD40
		public FormMayphu()
		{
			FormMayphu.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0015FB90 File Offset: 0x0015DD90
		public static string smethod_0()
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = Class7.string_4 != null;
			if (flag)
			{
				for (int i = 0; i < Class7.string_4.Length; i++)
				{
					bool flag2 = Class7.string_4[i] != null && !(Class7.string_4[i] == string.Empty);
					if (flag2)
					{
						bool flag3 = text != string.Empty;
						if (flag3)
						{
							text += ";";
						}
						text += Class7.string_4[i];
					}
				}
			}
			bool flag4 = Class7.string_3 != null;
			if (flag4)
			{
				for (int j = 0; j < Class7.string_3.Length; j++)
				{
					bool flag5 = Class7.string_3[j] != null && !(Class7.string_3[j] == string.Empty);
					if (flag5)
					{
						bool flag6 = text2 != string.Empty;
						if (flag6)
						{
							text2 += ";";
						}
						text2 += Class7.string_3[j];
					}
				}
			}
			bool flag7 = Class7.string_5 != null;
			if (flag7)
			{
				for (int k = 0; k < Class7.string_5.Length; k++)
				{
					bool flag8 = Class7.string_5[k] != null && !(Class7.string_5[k] == string.Empty);
					if (flag8)
					{
						bool flag9 = text3 != string.Empty;
						if (flag9)
						{
							text3 += ";";
						}
						text3 += Class7.string_5[k];
					}
				}
			}
			string string_ = string.Concat(new string[]
			{
				Class7.int_1.ToString(),
				"|",
				Class7.int_2.ToString(),
				"|",
				Class7.int_3.ToString(),
				"|",
				text,
				"|",
				text2,
				"|",
				text3
			});
			return Class12.smethod_63(string_);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0015FDB4 File Offset: 0x0015DFB4
		public static void smethod_1(string string_4)
		{
			string text = Class12.smethod_64(string_4);
			string[] array = text.Split(new char[]
			{
				'|'
			});
			bool flag = array.Length < 3;
			if (!flag)
			{
				Class7.int_1 = Class12.smethod_11(array[0]);
				Class7.int_2 = Class12.smethod_11(array[1]);
				Class7.int_3 = Class12.smethod_11(array[2]);
				bool flag2 = array.Length > 3;
				if (flag2)
				{
					Class7.string_4 = null;
					bool flag3 = array[3] != null && array[3] != string.Empty;
					if (flag3)
					{
						Class7.string_4 = array[3].Split(new char[]
						{
							';'
						});
					}
				}
				bool flag4 = array.Length > 4;
				if (flag4)
				{
					Class7.string_3 = null;
					bool flag5 = array[4] != null && array[4] != string.Empty;
					if (flag5)
					{
						Class7.string_3 = array[4].Split(new char[]
						{
							';'
						});
					}
				}
				bool flag6 = array.Length > 5;
				if (flag6)
				{
					Class7.string_5 = null;
					bool flag7 = array[5] != null && array[5] != string.Empty;
					if (flag7)
					{
						Class7.string_5 = array[5].Split(new char[]
						{
							';'
						});
					}
				}
				Class7.uint_1 = Class7.smethod_2(Class7.string_4);
				Class7.uint_0 = Class7.smethod_2(Class7.string_3);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0015FF04 File Offset: 0x0015E104
		private static string smethod_2(string string_4, int int_7, bool bool_10 = false)
		{
			bool flag = string_4 != null && !(string_4 == string.Empty);
			string result;
			if (flag)
			{
				bool flag2 = int_7 <= 0;
				if (flag2)
				{
					result = string_4;
				}
				else if (bool_10)
				{
					bool flag3 = int_7 > 9;
					if (flag3)
					{
						string text = string.Empty;
						foreach (char c in string_4)
						{
							bool flag4 = c < '\u0080';
							if (flag4)
							{
								c += '\u0080';
							}
							else
							{
								bool flag5 = c > '\u0080';
								if (flag5)
								{
									c -= '\u0080';
								}
							}
							text += c.ToString();
						}
						string_4 = Class12.smethod_71(text);
						result = string_4;
					}
					else
					{
						string text2 = string.Empty;
						for (int j = 0; j < string_4.Length; j++)
						{
							text2 += ((char)((int)string_4[j] - int_7 - j % 10)).ToString();
						}
						result = text2;
					}
				}
				else
				{
					bool flag6 = int_7 <= 9;
					if (flag6)
					{
						string text3 = string.Empty;
						for (int k = 0; k < string_4.Length; k++)
						{
							text3 += ((char)((int)string_4[k] + int_7 + k % 10)).ToString();
						}
						result = text3;
					}
					else
					{
						string_4 = Class12.smethod_70(string_4);
						bool flag7 = string_4 != null && string_4 != string.Empty;
						if (flag7)
						{
							string text4 = string.Empty;
							foreach (char c2 in string_4)
							{
								bool flag8 = c2 >= '\u0080';
								if (flag8)
								{
									bool flag9 = c2 > '\u0080';
									if (flag9)
									{
										c2 -= '\u0080';
									}
								}
								else
								{
									c2 += '\u0080';
								}
								text4 += c2.ToString();
							}
							string_4 = text4;
						}
						result = string_4;
					}
				}
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00160138 File Offset: 0x0015E338
		public static void smethod_3()
		{
			int int_ = FormMayphu.int_0;
			FormMayphu.int_0 = 0;
			for (;;)
			{
				try
				{
					FormMayphu.smethod_4(int_);
					break;
				}
				catch
				{
					Thread.Sleep(100);
				}
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00160184 File Offset: 0x0015E384
		public static void smethod_4(int int_7)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = -1000;
			long num6 = 0L;
			byte[] array = new byte[4];
			string text = null;
			string string_ = string.Empty;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				num2--;
				Thread.Sleep(100);
				bool flag = Class12.bool_0;
				if (flag)
				{
					break;
				}
				bool flag2 = num2 <= 0;
				if (flag2)
				{
					num4 = Class81.smethod_3(Form1.gstruct49_0, int_7);
					bool flag3 = num4 < 0;
					if (flag3)
					{
						break;
					}
					num2 = 30;
					Class83.smethod_41(gstruct, Form1.int_9 > 0);
				}
				gstruct = Form1.gstruct49_0[num4];
				bool flag4 = num5 == -1000;
				if (flag4)
				{
					num5 = GClass1.smethod_5(gstruct);
				}
				bool flag5 = gstruct.int_2 > 0 && num5 > 0;
				if (!flag5)
				{
					goto IL_75C;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array, 0);
				uint num9 = num8 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num10 = BitConverter.ToUInt32(array, 0);
				uint num11 = num10 + num9;
				Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_55.uint_0, array, 4, ref num);
				int num12 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num13 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num14 = BitConverter.ToInt32(array, 0);
				int num15 = Class83.smethod_39(gstruct);
				bool flag6 = num13 == 0 || num12 == 0 || num14 == 0 || num15 <= 1;
				if (!flag6)
				{
					int num16 = 0;
					bool flag7 = Form1.int_47 > 0;
					if (flag7)
					{
						num16 = Form1.int_48;
					}
					bool flag8 = FormMayphu.bool_8;
					if (flag8)
					{
						bool flag9 = FormMayphu.long_0 == 0L || text == null;
						if (flag9)
						{
							FormMayphu.long_0 = Class12.smethod_27();
							text = "UP:" + num16.ToString() + ":" + FormMayphu.smethod_0();
						}
						bool flag10 = Class12.smethod_28(FormMayphu.long_0) < FormMayphu.long_1;
						if (flag10)
						{
							string_ = text;
							goto IL_772;
						}
						FormMayphu.bool_8 = false;
						FormMayphu.long_0 = 0L;
						text = null;
					}
					uint num17 = 0U;
					uint num18 = 0U;
					int num19 = Class44.gstruct33_0.int_4;
					bool flag11 = Class44.gstruct33_0.uint_4 != null;
					if (flag11)
					{
						num17 = Class44.gstruct33_0.uint_4[0];
						num18 = Class44.gstruct33_0.uint_4[1];
					}
					bool flag12 = num17 == 0U || num18 == 0U || num19 <= 0;
					if (flag12)
					{
						continue;
					}
					string text2 = "0";
					bool flag13 = Class56.int_0 > 0;
					if (flag13)
					{
						bool flag14 = Class12.smethod_28(Class56.long_0) >= 1500L;
						if (flag14)
						{
							Class56.int_0 = 0;
						}
						else
						{
							text2 = Class56.int_0.ToString();
						}
					}
					string_ = string.Concat(new string[]
					{
						FormMayphu.string_2,
						num19.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_3.ToString(),
						FormMayphu.string_2,
						num17.ToString(),
						FormMayphu.string_2,
						num18.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_6.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.uint_3.ToString(),
						FormMayphu.string_2,
						Form1.int_115.ToString(),
						FormMayphu.string_2,
						Form1.int_20.ToString(),
						FormMayphu.string_2,
						Form1.int_106.ToString(),
						FormMayphu.string_2,
						Form1.int_108.ToString(),
						FormMayphu.string_2,
						Class18.int_0.ToString(),
						FormMayphu.string_2,
						Form1.int_22.ToString(),
						FormMayphu.string_2,
						Form1.int_30.ToString(),
						FormMayphu.string_2,
						Form1.int_31.ToString(),
						FormMayphu.string_2,
						Form1.int_32.ToString(),
						FormMayphu.string_2,
						Form1.int_25.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_2.ToString(),
						FormMayphu.string_2,
						Form1.int_24.ToString(),
						FormMayphu.string_2,
						Form1.int_88.ToString(),
						FormMayphu.string_2,
						Form1.int_89.ToString(),
						FormMayphu.string_2,
						FormDame.int_6.ToString(),
						FormMayphu.string_2,
						FormDame.int_9.ToString(),
						FormMayphu.string_2,
						FormDame.int_11.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.uint_5.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_7.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.uint_3.ToString(),
						FormMayphu.string_2,
						Form1.int_33.ToString(),
						FormMayphu.string_2,
						Form1.int_34.ToString(),
						FormMayphu.string_2,
						Form1.int_21.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_9.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.uint_2.ToString(),
						FormMayphu.string_2,
						Form1.int_90.ToString(),
						FormMayphu.string_2,
						Class44.gstruct33_0.int_8.ToString(),
						FormMayphu.string_2,
						num16.ToString(),
						FormMayphu.string_2,
						Form1.int_44[0].ToString(),
						FormMayphu.string_2,
						Form1.int_44[1].ToString(),
						FormMayphu.string_2,
						Form1.int_0.ToString(),
						FormMayphu.string_2,
						Class35.int_1.ToString(),
						FormMayphu.string_2,
						Form1.int_105.ToString(),
						FormMayphu.string_2,
						Form1.int_109.ToString(),
						FormMayphu.string_2,
						Form1.int_83.ToString(),
						FormMayphu.string_2,
						Form1.int_75.ToString(),
						FormMayphu.string_2,
						Form1.int_114.ToString(),
						FormMayphu.string_2,
						text2
					});
					IL_772:
					string str = FormMayphu.smethod_2(string_, Form1.int_49, false);
					Class44.gstruct33_0.int_9 = 0;
					bool flag15 = FormMayphu.string_0 != null;
					if (flag15)
					{
						int num20 = FormMayphu.string_0.Length;
						bool flag16 = num3 < 0 || num20 <= num3;
						if (flag16)
						{
							num3 = 0;
						}
						int num21 = num3;
						string text3 = null;
						while (text3 == null || text3 == string.Empty || text3 == gstruct.string_22)
						{
							try
							{
								text3 = FormMayphu.string_0[num3];
							}
							catch
							{
								break;
							}
							num3++;
							bool flag17 = num3 < 0 || num20 <= num3;
							if (flag17)
							{
								num3 = 0;
							}
							bool flag18 = num21 == num3 || FormMayphu.string_0 == null || FormMayphu.string_0.Length <= num21;
							if (flag18)
							{
								break;
							}
						}
						bool flag19 = text3 != null && text3 != string.Empty && gstruct.string_22 != text3;
						if (flag19)
						{
							Class70.smethod_50(gstruct, text3, str);
							Thread.Sleep(80 + 200 / num20 + FormMayphu.int_2);
						}
					}
					bool flag20 = Form1.int_8 > 0 && Class12.smethod_28(num6) >= (long)(2500 + FormMayphu.int_2);
					if (flag20)
					{
						Class70.smethod_57(gstruct, "Chat('CH_CHATROOM', '" + str + "')");
						num6 = Class12.smethod_27();
					}
				}
			}
			goto IL_8E6;
			IL_75C:
			Form1.gstruct49_0[num4].int_2 = 0;
			IL_8E6:
			Class83.smethod_41(gstruct, false);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00160A90 File Offset: 0x0015EC90
		public static void smethod_5(GStruct49 gstruct49_0)
		{
			bool flag = Form1.int_7 <= 0;
			if (!flag)
			{
				bool flag2 = GClass1.long_1 != 0L && !FormMayphu.bool_1;
				if (flag2)
				{
					string text = Class83.smethod_22(gstruct49_0);
					bool flag3 = text != null && text.Length >= 10;
					if (flag3)
					{
						int num = text.IndexOf(":");
						bool flag4 = 0 <= num && text.Length > num;
						if (flag4)
						{
							text = text.Substring(num + 1).Trim();
						}
						string text2 = FormMayphu.smethod_2(text, Form1.int_49, true);
						bool flag5 = text2 != null && !(text2 == string.Empty);
						if (flag5)
						{
							int num2 = text2.IndexOf("UP:");
							bool flag6 = 0 <= num2;
							if (flag6)
							{
								FormMayphu.bool_9 = true;
								string text3 = text2.Substring(num2);
								string[] array = text3.Split(new char[]
								{
									':'
								});
								bool flag7 = array.Length >= 3 && array[2] != null && !(array[2] == string.Empty) && (Form1.int_47 <= 0 || Class12.smethod_11(array[1]) == Form1.int_48);
								if (flag7)
								{
									string text4 = array[2];
									int length = text4.Length;
									bool flag8 = length % 2 > 0;
									if (flag8)
									{
										text4 = text4.Substring(0, length - 1);
									}
									FormMayphu.smethod_1(text4);
									return;
								}
							}
							else
							{
								bool flag9 = FormMayphu.bool_9;
								if (flag9)
								{
									Form1.bool_3 = true;
									FormMayphu.bool_9 = false;
								}
								bool flag10 = FormMayphu.string_2 == null || FormMayphu.string_2 == string.Empty;
								if (flag10)
								{
									FormMayphu.string_2 = "|";
								}
								string[] array2 = text2.Split(new char[]
								{
									FormMayphu.string_2[0]
								});
								int num3 = array2.Length;
								bool flag11 = num3 >= 43;
								if (flag11)
								{
									try
									{
										bool flag12 = Form1.int_47 <= 0 || Class12.smethod_11(FormMayphu.smethod_8(array2, 34, num3)) == Form1.int_48;
										if (flag12)
										{
											bool flag13 = Class44.gstruct33_1.uint_4 == null;
											if (flag13)
											{
												Class44.gstruct33_1.uint_4 = new uint[2];
											}
											Form1.int_113 = 0;
											Class44.gstruct33_1.int_4 = Class12.smethod_11(FormMayphu.smethod_8(array2, 1, num3));
											Class44.gstruct33_1.int_3 = Class12.smethod_11(FormMayphu.smethod_8(array2, 2, num3));
											Class44.gstruct33_1.uint_4[0] = Class12.smethod_12(FormMayphu.smethod_8(array2, 3, num3));
											Class44.gstruct33_1.uint_4[1] = Class12.smethod_12(FormMayphu.smethod_8(array2, 4, num3));
											Class44.gstruct33_1.int_6 = Class12.smethod_11(FormMayphu.smethod_8(array2, 5, num3));
											Class44.gstruct33_1.uint_3 = Class12.smethod_12(FormMayphu.smethod_8(array2, 6, num3));
											Form1.int_115 = Class12.smethod_11(FormMayphu.smethod_8(array2, 7, num3));
											Form1.int_20 = Class12.smethod_11(FormMayphu.smethod_8(array2, 8, num3));
											Form1.int_106 = Class12.smethod_11(FormMayphu.smethod_8(array2, 9, num3));
											Form1.int_108 = Class12.smethod_11(FormMayphu.smethod_8(array2, 10, num3));
											Class18.int_0 = Class12.smethod_11(FormMayphu.smethod_8(array2, 11, num3));
											Form1.int_22 = Class12.smethod_11(FormMayphu.smethod_8(array2, 12, num3));
											Form1.int_30 = Class12.smethod_11(FormMayphu.smethod_8(array2, 13, num3));
											Form1.int_31 = Class12.smethod_11(FormMayphu.smethod_8(array2, 14, num3));
											Form1.int_32 = Class12.smethod_11(FormMayphu.smethod_8(array2, 15, num3));
											Class44.gstruct33_1.int_10 = Class12.smethod_11(FormMayphu.smethod_8(array2, 16, num3));
											Class44.gstruct33_1.int_2 = Class12.smethod_11(FormMayphu.smethod_8(array2, 17, num3));
											Form1.int_24 = Class12.smethod_11(FormMayphu.smethod_8(array2, 18, num3));
											Form1.int_88 = 1;
											Form1.int_89 = Class12.smethod_11(FormMayphu.smethod_8(array2, 20, num3));
											FormDame.int_6 = Class12.smethod_11(FormMayphu.smethod_8(array2, 21, num3));
											FormDame.int_9 = Class12.smethod_11(FormMayphu.smethod_8(array2, 22, num3));
											FormDame.int_11 = Class12.smethod_11(FormMayphu.smethod_8(array2, 23, num3));
											Class44.gstruct33_1.uint_5 = Class12.smethod_12(FormMayphu.smethod_8(array2, 24, num3));
											Class44.gstruct33_1.int_7 = Class12.smethod_11(FormMayphu.smethod_8(array2, 25, num3));
											Class44.gstruct33_1.uint_3 = Class12.smethod_12(FormMayphu.smethod_8(array2, 26, num3));
											Form1.int_33 = Class12.smethod_11(FormMayphu.smethod_8(array2, 27, num3));
											Form1.int_34 = Class12.smethod_11(FormMayphu.smethod_8(array2, 28, num3));
											Form1.int_21 = Class12.smethod_11(FormMayphu.smethod_8(array2, 29, num3));
											Class44.gstruct33_1.int_9 = Class12.smethod_11(FormMayphu.smethod_8(array2, 30, num3));
											Class44.gstruct33_1.uint_2 = Class12.smethod_12(FormMayphu.smethod_8(array2, 31, num3));
											Form1.int_90 = Class12.smethod_11(FormMayphu.smethod_8(array2, 32, num3));
											Class44.gstruct33_1.int_8 = Class12.smethod_11(FormMayphu.smethod_8(array2, 33, num3));
											Class44.gstruct33_0.int_8 = Class44.gstruct33_1.int_8;
											Form1.int_44[0] = Class12.smethod_11(FormMayphu.smethod_8(array2, 35, num3));
											Form1.int_44[1] = Class12.smethod_11(FormMayphu.smethod_8(array2, 36, num3));
											Form1.int_0 = Class12.smethod_11(FormMayphu.smethod_8(array2, 37, num3));
											Class35.int_1 = Class12.smethod_11(FormMayphu.smethod_8(array2, 38, num3));
											Form1.int_105 = Class12.smethod_11(FormMayphu.smethod_8(array2, 39, num3));
											Form1.int_109 = Class12.smethod_11(FormMayphu.smethod_8(array2, 40, num3));
											Form1.int_83 = Class12.smethod_11(FormMayphu.smethod_8(array2, 41, num3));
											Form1.int_75 = Class12.smethod_11(FormMayphu.smethod_8(array2, 42, num3));
											Form1.int_114 = Class12.smethod_11(FormMayphu.smethod_8(array2, 43, num3));
											bool flag14 = num3 > 44;
											if (flag14)
											{
												int num4 = Class12.smethod_11(FormMayphu.smethod_8(array2, 44, num3));
												bool flag15 = num4 > 0 && Form1.gstruct49_0 != null;
												if (flag15)
												{
													for (int i = 0; i < Form1.gstruct49_0.Length; i++)
													{
														bool flag16 = num4 != 1 || !Form1.gstruct49_0[i].bool_25;
														if (flag16)
														{
															Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 0, 4);
														}
														else
														{
															Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 1, 4);
														}
													}
												}
											}
											goto IL_761;
										}
									}
									catch
									{
										goto IL_761;
									}
									goto IL_6C1;
									IL_761:
									Class44.gstruct33_1.long_1 = Class12.smethod_27();
									return;
								}
								IL_6C1:;
							}
						}
					}
					bool flag17 = Class12.smethod_28(Class44.gstruct33_1.long_1) > 6000L;
					if (flag17)
					{
						Class83.smethod_41(gstruct49_0, false);
						bool flag18 = Class12.smethod_2(text, "g­êi nµy", false);
						if (flag18)
						{
							Class83.smethod_23(gstruct49_0, "0K..");
							Class70.smethod_57(gstruct49_0, "Switch([[trade]])");
							Thread.Sleep(50);
						}
						Class44.gstruct33_1.int_4 = 0;
						Class44.gstruct33_1.long_1 = Class12.smethod_27();
					}
				}
				else
				{
					Class44.gstruct33_1.int_4 = 0;
					Class44.gstruct33_1.int_0 = 0;
					Class44.gstruct33_1.int_6 = 0;
				}
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0016122C File Offset: 0x0015F42C
		private void FormMayphu_Load(object sender, EventArgs e)
		{
			bool flag = this.int_3 >= 0 && this.int_4 >= 0;
			if (flag)
			{
				int num = this.int_3 - base.Width - 10;
				int num2 = this.int_4 - base.Height - 10;
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
			this.listView1.Items.Clear();
			bool flag4 = FormMayphu.string_0 != null;
			if (flag4)
			{
				for (int i = 0; i < FormMayphu.string_0.Length; i++)
				{
					bool flag5 = FormMayphu.string_0[i] != null && FormMayphu.string_0[i] != string.Empty;
					if (flag5)
					{
						FormMayphu.smethod_6(ref this.listView1, Class10.smethod_1(FormMayphu.string_0[i], 1, false));
					}
				}
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0016134A File Offset: 0x0015F54A
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormMayphu.bool_0 = false;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00161354 File Offset: 0x0015F554
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormMayphu.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00161378 File Offset: 0x0015F578
		public static void smethod_6(ref ListView listView_0, string string_4)
		{
			bool flag = string_4 != null;
			if (flag)
			{
				try
				{
					ListViewItem listViewItem = new ListViewItem((listView_0.Items.Count + 1).ToString());
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, string_4);
					listViewItem.SubItems.Add(item);
					listView_0.Items.Add(listViewItem);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x001613E8 File Offset: 0x0015F5E8
		private int method_0(ListView listView_0)
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

		// Token: 0x060009B2 RID: 2482 RVA: 0x00161444 File Offset: 0x0015F644
		private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
		{
			this.string_3 = null;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class98.smethod_25(Form1.gstruct49_0[i], ref this.string_3, 1, null);
				}
			}
			this.comboBoxThemAcc.Items.Clear();
			bool flag2 = this.string_3 != null;
			if (flag2)
			{
				Array.Sort<string>(this.string_3);
				for (int j = 0; j < this.string_3.Length; j++)
				{
					this.comboBoxThemAcc.Items.Add(Class10.smethod_1(this.string_3[j], 1, false));
				}
			}
			this.comboBoxThemAcc.Items.Add(string.Empty);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0016151C File Offset: 0x0015F71C
		private void buttonThemAcc_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxThemAcc.Text;
			bool flag = this.listView1.Items.Count > 0;
			if (flag)
			{
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool flag2 = text == this.listView1.Items[i].SubItems[1].Text;
					if (flag2)
					{
						this.comboBoxThemAcc.Items.Clear();
						this.comboBoxThemAcc.Text = "";
						return;
					}
				}
			}
			bool flag3 = this.string_3 != null;
			if (flag3)
			{
				for (int j = 0; j < this.string_3.Length; j++)
				{
					bool flag4 = text == Class10.smethod_1(this.string_3[j], 1, false);
					if (flag4)
					{
						text = this.string_3[j];
						break;
					}
				}
			}
			Class12.smethod_29(ref FormMayphu.string_0, text);
			FormMayphu.smethod_6(ref this.listView1, text);
			this.comboBoxThemAcc.Items.Clear();
			this.comboBoxThemAcc.Text = "";
			FormMayphu.smethod_7();
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00161660 File Offset: 0x0015F860
		private void buttonXoaAcc_Click(object sender, EventArgs e)
		{
			int num = this.method_0(this.listView1);
			bool flag = num < 0 || num > this.listView1.Items.Count - 1;
			if (!flag)
			{
				string text = this.listView1.Items[num].SubItems[1].Text;
				bool flag2 = FormMayphu.string_0 != null;
				if (flag2)
				{
					for (int i = 0; i < FormMayphu.string_0.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(FormMayphu.string_0[i], 1, false);
						if (flag3)
						{
							Class12.smethod_30(ref FormMayphu.string_0, FormMayphu.string_0[i], false);
							break;
						}
					}
				}
				this.listView1.Items.RemoveAt(num);
				for (int j = 0; j < this.listView1.Items.Count; j++)
				{
					this.listView1.Items[j].SubItems[0].Text = (j + 1).ToString();
				}
				FormMayphu.smethod_7();
			}
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0016178F File Offset: 0x0015F98F
		private void buttonClose_Click(object sender, EventArgs e)
		{
			FormMayphu.bool_0 = false;
			base.Close();
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x001617A0 File Offset: 0x0015F9A0
		private static void smethod_7()
		{
			string text = string.Empty;
			bool flag = FormMayphu.string_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormMayphu.string_0.Length; i++)
				{
					bool flag2 = text != string.Empty;
					if (flag2)
					{
						text += "|";
					}
					text += FormMayphu.string_0[i];
				}
				text = Class12.smethod_16(text);
			}
			Class12.smethod_34(Class53.string_15, text, 1);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0016181C File Offset: 0x0015FA1C
		private static string smethod_8(string[] string_4, int int_7, int int_8 = 0)
		{
			bool flag = (int_8 <= 0 || int_8 > int_7) && string_4 != null;
			if (flag)
			{
				bool flag2 = string_4.Length > int_7;
				if (flag2)
				{
					return string_4[int_7];
				}
			}
			return string.Empty;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00161864 File Offset: 0x0015FA64
		public static int smethod_9(GStruct49 gstruct49_0, ref long long_2, ref int int_7, ref uint[] uint_0)
		{
			Form1.int_113 = 0;
			bool flag = !Class12.smethod_62(Class44.gstruct33_1.uint_4);
			int result;
			if (flag)
			{
				result = 1;
			}
			else
			{
				int num = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				bool flag2 = !Class101.smethod_0(num);
				if (flag2)
				{
					result = 1;
				}
				else
				{
					uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
					uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
					uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
					uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
					int num6 = (int)Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					int num7 = (int)Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
					int num8 = Class83.smethod_39(gstruct49_0);
					bool flag3 = num6 == 10 || num6 == 21 || num7 == 0 || num8 <= 1;
					if (flag3)
					{
						result = 1;
					}
					else
					{
						uint[] array = new uint[]
						{
							Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						int num9 = (int)Class22.smethod_30(num5 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
						bool flag4 = num == Class44.gstruct33_1.int_4;
						if (flag4)
						{
							long num10 = Class60.smethod_18(array, Class44.gstruct33_1.uint_4);
							bool flag5 = gstruct49_0.int_130[0] > 0 && gstruct49_0.int_136 != Class44.gstruct33_1.int_0 && num9 == Class44.gstruct33_1.int_3 && num9 > 0;
							if (flag5)
							{
								int num11 = gstruct49_0.int_130[1] + Form1.int_23;
								bool flag6 = num10 <= (long)(num11 * num11) && Class64.smethod_0(gstruct49_0, Class44.gstruct33_1.uint_4, gstruct49_0.int_130[1]) > 0;
								if (flag6)
								{
									return 3;
								}
							}
							bool flag7 = num10 > (long)(Form1.int_23 * Form1.int_23);
							if (flag7)
							{
								int num12 = 0;
								int int_8 = gstruct49_0.int_137;
								uint uint_ = num5 + Class53.gstruct51_72.uint_0;
								byte[] byte_ = new byte[4];
								Class22.WriteProcessMemory(int_8, uint_, byte_, 4, ref num12);
								bool flag8 = num10 > (long)(Form1.int_101 * Form1.int_101);
								if (flag8)
								{
									Class60.smethod_29(gstruct49_0, false);
								}
								bool flag9 = int_7 > 6;
								if (flag9)
								{
									bool flag10 = uint_0 != null && Class60.smethod_18(uint_0, array) < 180000L;
									uint_0 = null;
									int_7 = 0;
									bool flag11 = flag10;
									if (flag11)
									{
										int num13 = 0;
										int int_9 = gstruct49_0.int_137;
										uint uint_2 = num5 + Class53.gstruct51_72.uint_0;
										byte_ = new byte[4];
										Class22.WriteProcessMemory(int_9, uint_2, byte_, 4, ref num13);
										Class60.smethod_2(gstruct49_0, array, Class44.gstruct33_1.uint_4, 600);
										return -1;
									}
								}
								bool flag12 = num10 >= 810000L;
								if (flag12)
								{
									bool flag13 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 3000L;
									if (flag13)
									{
										int_7++;
										Class14.smethod_1(gstruct49_0, Class44.gstruct33_1.uint_4);
										long_2 = Class12.smethod_27();
									}
									result = -1;
								}
								else
								{
									Class14.smethod_2(gstruct49_0, false);
									Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
									Thread.Sleep(100);
									result = -1;
								}
							}
							else
							{
								Class14.smethod_2(gstruct49_0, false);
								bool flag14 = num10 > 20000L;
								if (flag14)
								{
									Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
									Thread.Sleep(100);
								}
								int_7 = 0;
								uint_0 = null;
								result = 3;
							}
						}
						else
						{
							bool flag15 = !Class101.smethod_0(Class44.gstruct33_1.int_4);
							if (flag15)
							{
								result = 1;
							}
							else
							{
								array = new uint[]
								{
									Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								uint[] array2 = Class101.smethod_1(num, array, Class44.gstruct33_1.int_4, Class44.gstruct33_1.uint_4);
								bool flag16 = array2 != null;
								if (flag16)
								{
									int num14 = 0;
									int int_10 = gstruct49_0.int_137;
									uint uint_3 = num5 + Class53.gstruct51_72.uint_0;
									byte[] byte_2 = new byte[4];
									Class22.WriteProcessMemory(int_10, uint_3, byte_2, 4, ref num14);
									uint[] array3 = new uint[]
									{
										array2[0],
										array2[1]
									};
									int num15 = (int)array2[2];
									long num16 = Class60.smethod_18(array, array3);
									bool flag17 = num16 >= 90000L;
									if (flag17)
									{
										Class60.smethod_29(gstruct49_0, false);
										bool flag18 = uint_0 == null;
										if (flag18)
										{
											uint_0 = new uint[]
											{
												array[0],
												array[1]
											};
											int_7 = 0;
										}
										bool flag19 = int_7 > 6;
										if (flag19)
										{
											bool flag20 = uint_0 != null && Class60.smethod_18(uint_0, array) < 180000L;
											uint_0 = null;
											int_7 = 0;
											bool flag21 = flag20;
											if (flag21)
											{
												Class60.smethod_2(gstruct49_0, array, Class44.gstruct33_1.uint_4, 600);
												return -1;
											}
										}
										bool flag22 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 3000L;
										if (flag22)
										{
											int_7++;
											Class14.smethod_1(gstruct49_0, array3);
											long_2 = Class12.smethod_27();
										}
										return -1;
									}
									int_7 = 0;
									uint_0 = null;
									for (int i = 0; i < 10; i++)
									{
										array = new uint[]
										{
											Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										long num17 = Class60.smethod_18(array, array3);
										bool flag23 = num17 < 11500L || (ulong)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137) != (ulong)((long)num);
										if (flag23)
										{
											break;
										}
										Class70.smethod_61(gstruct49_0, array3);
										Thread.Sleep(300);
									}
									for (int j = 0; j < 5; j++)
									{
										Class60.smethod_25(gstruct49_0, num15);
										Thread.Sleep(300);
										uint num18 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
										bool flag24 = (ulong)num18 != (ulong)((long)num);
										if (flag24)
										{
											break;
										}
									}
								}
								result = -1;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00161F48 File Offset: 0x00160148
		public static int smethod_10(GStruct49 gstruct49_0, ref long long_2, ref int int_7, ref uint[] uint_0)
		{
			bool flag = !Class12.smethod_62(Class44.gstruct33_1.uint_4);
			int result;
			if (flag)
			{
				result = 1;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
				int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num7 = Class83.smethod_39(gstruct49_0);
				bool flag2 = num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1;
				if (flag2)
				{
					int num8 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
					bool flag3 = num8 == Class44.gstruct33_1.int_4;
					if (flag3)
					{
						int num9 = (int)Class22.smethod_30(num4 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
						bool flag4 = num9 <= 0 || (num9 > 0 && Class44.gstruct33_1.int_3 <= 0);
						if (flag4)
						{
							result = 1;
						}
						else
						{
							uint[] array = new uint[]
							{
								Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							long num10 = Class60.smethod_18(array, Class44.gstruct33_1.uint_4);
							bool flag5 = gstruct49_0.int_130[0] > 0 && gstruct49_0.int_136 != Class44.gstruct33_1.int_0 && num9 == Class44.gstruct33_1.int_3 && num9 > 0;
							if (flag5)
							{
								int num11 = gstruct49_0.int_130[1] + Form1.int_23;
								bool flag6 = num10 <= (long)(num11 * num11) && Class64.smethod_0(gstruct49_0, Class44.gstruct33_1.uint_4, gstruct49_0.int_130[1]) > 0;
								if (flag6)
								{
									return 3;
								}
							}
							bool flag7 = num10 <= (long)(Form1.int_23 * Form1.int_23);
							if (flag7)
							{
								Class14.smethod_2(gstruct49_0, false);
								bool flag8 = num10 > 20000L;
								if (flag8)
								{
									Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
									Thread.Sleep(110);
								}
								int_7 = 0;
								uint_0 = null;
								result = 3;
							}
							else
							{
								int num12 = 0;
								int int_8 = gstruct49_0.int_137;
								uint uint_ = num4 + Class53.gstruct51_72.uint_0;
								byte[] byte_ = new byte[4];
								Class22.WriteProcessMemory(int_8, uint_, byte_, 4, ref num12);
								bool flag9 = num10 > (long)(Form1.int_101 * Form1.int_101);
								if (flag9)
								{
									Class60.smethod_29(gstruct49_0, false);
								}
								bool flag10 = uint_0 == null;
								if (flag10)
								{
									uint_0 = new uint[]
									{
										array[0],
										array[1]
									};
									int_7 = 0;
								}
								bool flag11 = int_7 > 6;
								if (flag11)
								{
									bool flag12 = uint_0 != null && Class60.smethod_18(uint_0, array) < 180000L;
									uint_0 = null;
									int_7 = 0;
									bool flag13 = flag12;
									if (flag13)
									{
										Class60.smethod_2(gstruct49_0, array, Class44.gstruct33_1.uint_4, 600);
										return -1;
									}
								}
								bool flag14 = num10 < 810000L;
								if (flag14)
								{
									Class14.smethod_2(gstruct49_0, false);
									Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
									Thread.Sleep(100);
									result = -1;
								}
								else
								{
									bool flag15 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 3000L;
									if (flag15)
									{
										int_7++;
										Class14.smethod_1(gstruct49_0, Class44.gstruct33_1.uint_4);
										long_2 = Class12.smethod_27();
									}
									result = -1;
								}
							}
						}
					}
					else
					{
						result = 1;
					}
				}
				else
				{
					result = 1;
				}
			}
			return result;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00162330 File Offset: 0x00160530
		public static int smethod_11(GStruct49 gstruct49_0, ref bool bool_10, ref long long_2, ref int int_7, ref uint[] uint_0)
		{
			bool flag = Class12.smethod_62(Class44.gstruct33_1.uint_4);
			int result;
			if (flag)
			{
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2 * Class53.gstruct51_15.uint_0;
				int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num7 = Class83.smethod_39(gstruct49_0);
				bool flag2 = num5 != 10 && num5 != 21 && num6 != 0 && num7 > 1;
				if (flag2)
				{
					uint[] array = new uint[]
					{
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					int num8 = (int)Class22.smethod_30(num4 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
					int num9 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
					bool flag3 = num9 == Class44.gstruct33_1.int_4;
					if (flag3)
					{
						bool flag4 = Class56.smethod_0(num9) != null || Class56.smethod_2(num9) > 0;
						bool flag5 = num8 > 0 && flag4 && Class44.gstruct33_1.int_3 <= 0;
						if (flag5)
						{
							result = 3;
						}
						else
						{
							long num10 = Class60.smethod_18(array, Class44.gstruct33_1.uint_4);
							bool flag6 = gstruct49_0.int_130[0] > 0 && gstruct49_0.int_136 != Class44.gstruct33_1.int_0 && num8 == Class44.gstruct33_1.int_3 && num8 > 0;
							if (flag6)
							{
								int num11 = gstruct49_0.int_130[1] + Form1.int_23;
								bool flag7 = num10 <= (long)(num11 * num11) && Class64.smethod_0(gstruct49_0, Class44.gstruct33_1.uint_4, gstruct49_0.int_130[1]) > 0;
								if (flag7)
								{
									return 4;
								}
							}
							bool flag8 = num10 > (long)(Form1.int_23 * Form1.int_23);
							if (flag8)
							{
								bool flag9 = num9 == 336;
								if (flag9)
								{
									int num12 = 0;
									int num13 = 0;
									long num14 = Class60.smethod_21(Class41.uint_0, array);
									long num15 = Class60.smethod_21(Class41.uint_1, array);
									bool flag10 = num14 < num15;
									if (flag10)
									{
										num12 = 1;
									}
									num14 = Class60.smethod_21(Class41.uint_0, Class44.gstruct33_1.uint_4);
									num15 = Class60.smethod_21(Class41.uint_1, Class44.gstruct33_1.uint_4);
									bool flag11 = num14 < num15;
									if (flag11)
									{
										num13 = 1;
									}
									bool flag12 = num12 != num13;
									if (flag12)
									{
										return 5;
									}
								}
								int num16 = 0;
								int int_8 = gstruct49_0.int_137;
								uint uint_ = num4 + Class53.gstruct51_72.uint_0;
								byte[] byte_ = new byte[4];
								Class22.WriteProcessMemory(int_8, uint_, byte_, 4, ref num16);
								bool flag13 = uint_0 == null;
								if (flag13)
								{
									uint_0 = new uint[]
									{
										array[0],
										array[1]
									};
									int_7 = 0;
								}
								bool flag14 = int_7 > 6;
								if (flag14)
								{
									bool flag15 = uint_0 != null && Class60.smethod_18(uint_0, array) < 180000L;
									uint_0 = null;
									int_7 = 0;
									bool flag16 = flag15;
									if (flag16)
									{
										Class60.smethod_2(gstruct49_0, array, Class44.gstruct33_1.uint_4, 600);
										return -1;
									}
								}
								bool flag17 = num10 > (long)(Form1.int_101 * Form1.int_101);
								if (flag17)
								{
									Class60.smethod_29(gstruct49_0, false);
								}
								bool flag18 = num10 >= 22500L;
								if (flag18)
								{
									bool flag19 = num10 >= 810000L;
									if (flag19)
									{
										int[] array2 = Class60.smethod_9(num9);
										bool flag20 = array2 != null && num8 > 0 && Class44.gstruct33_1.int_3 <= 0;
										if (flag20)
										{
											bool flag21 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, Class44.gstruct33_1.uint_4, false);
											if (flag21)
											{
												return -2;
											}
											bool flag22 = Class60.smethod_14(gstruct49_0, true);
											if (flag22)
											{
												return -2;
											}
										}
										bool flag23 = bool_10 && !flag4 && num8 == 0 && array2 != null && array2[1] == 0 && (Class44.gstruct33_1.int_3 > 0 || Class44.gstruct33_0.int_3 > 0);
										if (flag23)
										{
											bool_10 = false;
											uint[] uint_2 = null;
											bool flag24 = Class44.gstruct33_1.int_4 == num9;
											if (flag24)
											{
												uint_2 = Class44.gstruct33_1.uint_4;
											}
											bool flag25 = Class50.smethod_2(gstruct49_0, "®iÓm c", uint_2, null, 0) > 0;
											if (flag25)
											{
												Thread.Sleep(300);
												Class60.smethod_11(gstruct49_0, 15000);
												return -2;
											}
										}
										bool flag26 = Class44.gstruct33_1.int_3 > 0;
										if (flag26)
										{
											uint[] array3 = Class43.smethod_10(Class44.gstruct33_1.uint_4, num9, "NGOAITHANH", true);
											bool flag27 = array3 != null;
											if (flag27)
											{
												long num17 = Class60.smethod_18(Class44.gstruct33_1.uint_4, array3);
												bool flag28 = num17 <= 100000000L;
												if (flag28)
												{
													uint[,] array4 = Class42.smethod_1(num9, array, array3, null, false);
													bool flag29 = array4 != null;
													if (flag29)
													{
														int num18 = Class60.smethod_20(array4, array3);
														bool flag30 = num18 >= 0;
														if (flag30)
														{
															uint[] uint_3 = new uint[]
															{
																array4[num18, 0],
																array4[num18, 1]
															};
															long num19 = Class60.smethod_18(array, uint_3);
															bool flag31 = num19 > 500000L;
															if (flag31)
															{
																Class14.smethod_2(gstruct49_0, false);
																Class60.smethod_22(gstruct49_0, array4, array, array3, num9, true, 8000, false);
																num8 = (int)Class22.smethod_30(num4 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
																bool flag32 = num8 <= 0;
																if (flag32)
																{
																	return -1;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											uint[,] array4 = Class42.smethod_1(num9, Class44.gstruct33_1.uint_4, null, null, false);
											bool flag33 = array4 != null;
											if (flag33)
											{
												int num18 = Class60.smethod_20(array4, Class44.gstruct33_1.uint_4);
												bool flag34 = num18 >= 0;
												if (flag34)
												{
													uint[] uint_3 = new uint[]
													{
														array4[num18, 0],
														array4[num18, 1]
													};
													long num19 = Class60.smethod_18(array, uint_3);
													num8 = (int)Class22.smethod_30(num4 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
													bool flag35 = num19 >= 90000L && num8 <= 0;
													if (flag35)
													{
														Class14.smethod_2(gstruct49_0, false);
														Class60.smethod_22(gstruct49_0, array4, array, Class44.gstruct33_1.uint_4, num9, true, 8000, false);
														return -1;
													}
												}
											}
										}
										bool flag36 = num9 == 53 && Class44.gstruct33_1.int_4 == 53 && num8 <= 0;
										if (flag36)
										{
											uint[] array5 = Class44.gstruct33_1.uint_4;
											bool flag37 = Class84.gstruct21_0 == null;
											if (flag37)
											{
												Class84.gstruct21_0 = Class84.smethod_1();
											}
											bool flag38 = Class44.gstruct33_1.int_3 > 0;
											if (flag38)
											{
												array5 = Class84.smethod_0(array5);
											}
											uint[,] uint_4 = Class43.smethod_9(Class84.gstruct21_0, array, array5, 60000);
											uint[] array6 = array;
											int num20 = Class60.smethod_22(gstruct49_0, uint_4, array, array5, 53, true, 8000, false);
											array = new uint[]
											{
												Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
												Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
											};
											bool flag39 = array6 != null && num20 > 0 && (array6[0] != array[0] || array6[1] != array[1]);
											if (flag39)
											{
												return -3;
											}
										}
										num10 = Class60.smethod_18(array, Class44.gstruct33_1.uint_4);
										uint[] array7 = new uint[]
										{
											Class44.gstruct33_1.uint_4[0],
											Class44.gstruct33_1.uint_4[1]
										};
										bool flag40 = num9 == 333;
										if (flag40)
										{
											bool flag41 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && num10 > 15354505L && Form1.string_3 == "vltrungnguyen.com";
											if (flag41)
											{
												num10 = -1L;
												int num21 = -1;
												for (int i = 0; i < Class94.gstruct23_0.Length; i++)
												{
													long num22 = Class60.smethod_18(Class44.gstruct33_1.uint_4, Class94.gstruct23_0[i].uint_0);
													bool flag42 = num21 < 0 || num22 < num10;
													if (flag42)
													{
														num21 = i;
														num10 = num22;
													}
												}
												bool flag43 = Class35.smethod_141(gstruct49_0, "b¶n ®å|§Æc BiÖt|" + Class94.gstruct23_0[num21].string_0);
												if (flag43)
												{
													Thread.Sleep(200);
													return -3;
												}
											}
											bool flag44 = Class94.smethod_0(array);
											bool flag45 = Class94.smethod_0(Class44.gstruct33_1.uint_4);
											bool flag46 = flag44 != flag45;
											if (flag46)
											{
												uint[,] array8 = Class94.smethod_1(Class44.gstruct33_1.uint_4);
												uint[,] array9 = Class94.smethod_1(array);
												int length = array8.GetLength(0);
												int length2 = array9.GetLength(0);
												bool flag47 = flag44;
												long num23;
												long num24;
												if (flag47)
												{
													num23 = Class60.smethod_19(array, array8[length - 1, 0], array8[length - 1, 1]);
													num23 += Class60.smethod_19(new uint[]
													{
														array8[0, 0],
														array8[0, 1]
													}, array8[length - 1, 0], array8[length - 1, 1]);
													num23 += Class60.smethod_19(Class44.gstruct33_1.uint_4, array8[0, 0], array8[0, 1]);
													num24 = Class60.smethod_19(array, array9[length2 - 1, 0], array9[length2 - 1, 1]);
													num24 += Class60.smethod_19(new uint[]
													{
														array9[0, 0],
														array9[0, 1]
													}, array9[length2 - 1, 0], array9[length2 - 1, 1]);
													num24 += Class60.smethod_19(Class44.gstruct33_1.uint_4, array9[0, 0], array9[0, 1]);
												}
												else
												{
													num23 = Class60.smethod_19(array, array8[0, 0], array8[0, 1]);
													num23 += Class60.smethod_19(new uint[]
													{
														array8[0, 0],
														array8[0, 1]
													}, array8[length - 1, 0], array8[length - 1, 1]);
													num23 += Class60.smethod_19(Class44.gstruct33_1.uint_4, array8[length - 1, 0], array8[length - 1, 1]);
													num24 = Class60.smethod_19(array, array9[0, 0], array9[0, 1]);
													num24 += Class60.smethod_19(new uint[]
													{
														array9[0, 0],
														array9[0, 1]
													}, array9[length2 - 1, 0], array9[length2 - 1, 1]);
													num24 += Class60.smethod_19(Class44.gstruct33_1.uint_4, array9[length2 - 1, 0], array9[length2 - 1, 1]);
												}
												uint[,] array10 = (num23 <= num24) ? array8 : array9;
												uint[] array11 = new uint[]
												{
													array10[0, 0],
													array10[0, 1]
												};
												uint[] array12 = new uint[]
												{
													array10[array10.GetLength(0) - 1, 0],
													array10[array10.GetLength(0) - 1, 1]
												};
												num10 = Class60.smethod_21(array10, array);
												bool flag48 = num10 <= 300000L;
												if (flag48)
												{
													bool flag49 = flag44;
													if (flag49)
													{
														Class60.smethod_22(gstruct49_0, array10, array, array11, num9, false, 6000, true);
													}
													else
													{
														Class60.smethod_22(gstruct49_0, array10, array, array12, num9, false, 6000, true);
													}
													return -3;
												}
												bool flag50 = !flag44;
												if (flag50)
												{
													array7[0] = array11[0];
													array7[1] = array11[1];
												}
												else
												{
													array7[0] = array12[0];
													array7[1] = array12[1];
												}
											}
											else
											{
												bool flag51 = !flag44;
												if (flag51)
												{
													long num25 = Class60.smethod_21(Class94.uint_0, array);
													long num26 = Class60.smethod_21(Class94.uint_0, Class44.gstruct33_1.uint_4);
													long num27 = Class60.smethod_18(array, Class44.gstruct33_1.uint_4);
													bool flag52 = num25 > 1500000L && num26 > 1500000L && num27 > 1500000L;
													if (flag52)
													{
														uint[,] array13 = Class94.smethod_1(array);
														num10 = Class60.smethod_21(array13, array);
														bool flag53 = num10 <= 300000L;
														if (flag53)
														{
															Class60.smethod_22(gstruct49_0, array13, array, null, num9, false, 6000, true);
															return -3;
														}
														array7[0] = array13[0, 0];
														array7[1] = array13[0, 1];
													}
												}
											}
										}
										bool flag54 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 4000L;
										if (flag54)
										{
											int_7++;
											Class14.smethod_1(gstruct49_0, array7);
											Thread.Sleep(600);
											long_2 = Class12.smethod_27();
										}
										result = -3;
									}
									else
									{
										Class14.smethod_2(gstruct49_0, false);
										Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
										Thread.Sleep(100);
										result = 2;
									}
								}
								else
								{
									Class14.smethod_2(gstruct49_0, false);
									result = 4;
								}
							}
							else
							{
								Class14.smethod_2(gstruct49_0, false);
								bool flag55 = num10 > 20000L;
								if (flag55)
								{
									Class70.smethod_61(gstruct49_0, Class44.gstruct33_1.uint_4);
									Thread.Sleep(100);
								}
								int_7 = 0;
								uint_0 = null;
								result = 4;
							}
						}
					}
					else
					{
						bool flag56 = Class18.smethod_0(Class44.gstruct33_1.int_4);
						if (flag56)
						{
							Class18.smethod_1(gstruct49_0, true, true);
							result = -4;
						}
						else
						{
							bool flag57 = (num9 == 221 || num9 == 539) && Class50.smethod_0(gstruct49_0, null) > 0;
							if (flag57)
							{
								result = -5;
							}
							else
							{
								num9 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
								bool flag58 = Class18.smethod_0(num9);
								if (flag58)
								{
									bool flag59 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, Class44.gstruct33_1.uint_4, false);
									if (flag59)
									{
										int j = 0;
										while (j < 10)
										{
											bool flag60 = (ulong)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137) == (ulong)((long)num9);
											if (!flag60)
											{
												return -5;
											}
											j++;
											Thread.Sleep(100);
										}
									}
									uint[] array14 = Class18.smethod_2(gstruct49_0);
									bool flag61 = array14 != null;
									if (flag61)
									{
										int num28 = 0;
										int int_9 = gstruct49_0.int_137;
										uint uint_5 = num4 + Class53.gstruct51_72.uint_0;
										byte[] byte_2 = new byte[4];
										Class22.WriteProcessMemory(int_9, uint_5, byte_2, 4, ref num28);
										bool flag62 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 3000L;
										if (flag62)
										{
											Class14.smethod_1(gstruct49_0, array14);
											long_2 = Class12.smethod_27();
										}
									}
									result = -5;
								}
								else
								{
									array = new uint[]
									{
										Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									GStruct26 gstruct = default(GStruct26);
									int num29 = 0;
									uint[] array15 = null;
									uint[] uint_6 = null;
									bool flag63 = num9 == 336 || Class44.gstruct33_1.int_4 != 341;
									if (flag63)
									{
										bool flag64 = num9 == 175 || num9 == 195;
										if (flag64)
										{
											string text = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
											bool flag65 = Class70.smethod_44(gstruct49_0, text, false, -1, false);
											if (flag65)
											{
												Thread.Sleep(300);
												Class86.smethod_5(gstruct49_0, 0);
												return -6;
											}
										}
										bool flag66 = num9 != 175;
										if (flag66)
										{
											bool flag67 = Class43.smethod_1(num9) && !Class43.smethod_1(Class44.gstruct33_1.int_4);
											if (flag67)
											{
												int num30 = 11;
												int[] array16 = Class60.smethod_9(Class44.gstruct33_1.int_4);
												bool flag68 = array16 != null;
												if (flag68)
												{
													num30 = Class60.int_0[array16[0], 0];
												}
												Class50.smethod_5(gstruct49_0, num30);
												return -9;
											}
											bool flag69 = Form1.int_22 <= 0 && Class44.gstruct33_1.int_3 <= 0;
											if (flag69)
											{
												return 7;
											}
											bool flag70 = num8 > 0 && Class44.gstruct33_1.int_3 <= 0;
											if (flag70)
											{
												gstruct = Class43.smethod_4(num9, Class44.gstruct33_1.int_4);
												bool flag71 = gstruct.int_0 != num9 || gstruct.int_1 != Class44.gstruct33_1.int_4;
												if (flag71)
												{
													bool flag72 = Class12.smethod_1(Class44.gstruct33_1.string_1, "Õn thuyÒ") <= 0;
													if (!flag72)
													{
														return 8;
													}
													bool flag73 = Form1.int_84 > 0 && num9 != 195;
													if (flag73)
													{
														bool flag74 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, Class44.gstruct33_1.uint_4, false);
														if (flag74)
														{
															return -7;
														}
														bool flag75 = Class60.smethod_14(gstruct49_0, true);
														if (flag75)
														{
															return -8;
														}
													}
													bool flag76 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, Class44.gstruct33_1.uint_4, false);
													if (flag76)
													{
														bool flag77 = num9 == 195 || num9 == 195;
														if (flag77)
														{
															try
															{
																int num31 = 0;
																byte[] byte_3 = new byte[]
																{
																	1
																};
																Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_33 * 4U, byte_3, 1, ref num31);
															}
															catch
															{
															}
														}
														return -7;
													}
													bool flag78 = num9 != 195;
													if (!flag78)
													{
														return 9;
													}
													bool flag79 = Class60.smethod_14(gstruct49_0, true);
													if (flag79)
													{
														Thread.Sleep(300);
														Class60.smethod_11(gstruct49_0, 15000);
														Thread.Sleep(600);
														int num32 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
														bool flag80 = num32 != num9;
														if (flag80)
														{
															return -9;
														}
													}
													string text2 = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
													bool flag81 = !Class70.smethod_44(gstruct49_0, text2, false, -1, false);
													if (flag81)
													{
														return -8;
													}
													Thread.Sleep(300);
													Class86.smethod_5(gstruct49_0, 0);
													return -6;
												}
											}
											else
											{
												bool flag82 = num8 <= 0 && Class44.gstruct33_1.int_3 <= 0;
												if (flag82)
												{
													bool flag83 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, Class44.gstruct33_1.uint_4, false);
													if (flag83)
													{
														return -7;
													}
													Class50.smethod_5(gstruct49_0, Class44.gstruct33_1.int_4);
													return -9;
												}
												else
												{
													bool flag84 = num8 != 0 || Class44.gstruct33_1.int_3 <= 0;
													if (flag84)
													{
														bool flag85 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct49_0, Class44.gstruct33_1.int_4, null, null, false);
														if (flag85)
														{
															Thread.Sleep(300);
															Class60.smethod_11(gstruct49_0, 15000);
															Thread.Sleep(600);
															int num33 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
															bool flag86 = num33 != num9;
															if (flag86)
															{
																return -7;
															}
														}
														gstruct = Class43.smethod_4(num9, Class44.gstruct33_1.int_4);
														bool flag87 = gstruct.int_0 != num9 || gstruct.int_1 != Class44.gstruct33_1.int_4;
														if (flag87)
														{
															int num34 = Class60.smethod_7(num9, Class44.gstruct33_1.int_4, ref gstruct);
															bool flag88 = num34 != 0;
															if (flag88)
															{
																bool_10 = false;
																bool flag89 = num34 > 0;
																if (flag89)
																{
																	bool flag90 = num9 == 336;
																	if (flag90)
																	{
																		long num35 = Class60.smethod_21(Class41.uint_0, array);
																		long num36 = Class60.smethod_21(Class41.uint_1, array);
																		bool flag91 = num35 > num36;
																		if (flag91)
																		{
																			gstruct = Class43.smethod_4(num9, 121);
																			goto IL_1C36;
																		}
																	}
																	bool flag92 = Class60.smethod_14(gstruct49_0, true);
																	if (flag92)
																	{
																		Thread.Sleep(300);
																		Class60.smethod_11(gstruct49_0, 15000);
																		Thread.Sleep(600);
																		int num37 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																		bool flag93 = num37 != num9;
																		if (flag93)
																		{
																			return -8;
																		}
																	}
																}
																return 1;
															}
														}
													}
													else
													{
														gstruct = Class43.smethod_4(num9, Class44.gstruct33_1.int_4);
														bool flag94 = gstruct.int_0 != num9 || gstruct.int_1 != Class44.gstruct33_1.int_4;
														if (flag94)
														{
															bool flag95 = Form1.int_84 > 0 || Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) == 0;
															if (flag95)
															{
																bool flag96 = bool_10;
																if (flag96)
																{
																	bool_10 = false;
																	uint[] uint_7 = null;
																	bool flag97 = Form1.int_21 > 0 && Class44.gstruct33_1.int_0 > 0 && Class44.gstruct33_1.int_4 == num9;
																	if (flag97)
																	{
																		uint_7 = Class44.gstruct33_1.uint_4;
																	}
																	bool flag98 = Class50.smethod_2(gstruct49_0, "®iÓm c", uint_7, null, 0) > 0;
																	if (flag98)
																	{
																		Class60.smethod_11(gstruct49_0, 15000);
																		goto IL_1C24;
																	}
																}
																bool flag99 = Class50.smethod_4(gstruct49_0, Class44.gstruct33_1.int_4) > 0;
																if (flag99)
																{
																	Thread.Sleep(300);
																	Class60.smethod_11(gstruct49_0, 15000);
																	Thread.Sleep(600);
																	int num38 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																	bool flag100 = num38 != num9;
																	if (flag100)
																	{
																		goto IL_1C24;
																	}
																}
															}
															bool flag101 = Class44.gstruct33_1.int_4 == 181 && Class35.int_0 > 0;
															bool flag102 = Class70.smethod_3(gstruct49_0, Class70.uint_19, 4) > 0 && !flag101;
															if (flag102)
															{
																int num39 = Class44.gstruct33_1.int_4;
																int num40 = Class35.smethod_137(num39);
																bool flag103 = num40 < 0 && Class44.gstruct33_1.int_4 == 76;
																if (flag103)
																{
																	num39 = 75;
																	num40 = Class35.smethod_137(num39);
																}
																bool flag104 = 0 > num40 || !Class35.smethod_140(gstruct49_0, num39, null, null, false);
																if (flag104)
																{
																	bool flag105 = num9 != 103 && num9 != 114 && num9 != 110 && (Class44.gstruct33_1.int_4 == 110 || Class44.gstruct33_1.int_4 == 114) && Class35.smethod_140(gstruct49_0, 103, null, null, false);
																	if (flag105)
																	{
																		Thread.Sleep(300);
																		Class60.smethod_11(gstruct49_0, 15000);
																		Thread.Sleep(600);
																		int num41 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																		bool flag106 = num41 != num9;
																		if (flag106)
																		{
																			goto IL_1C24;
																		}
																	}
																}
																else
																{
																	Thread.Sleep(300);
																	Class60.smethod_11(gstruct49_0, 15000);
																	Thread.Sleep(600);
																	int num42 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																	bool flag107 = num42 != num9;
																	if (flag107)
																	{
																		goto IL_1C24;
																	}
																}
															}
															bool flag108 = Class60.smethod_9(num9) == null && Class44.gstruct33_1.int_4 > 0 && Class56.smethod_1(num9) != null && Class56.smethod_0(Class44.gstruct33_1.int_4) == null;
															if (flag108)
															{
																Class50.smethod_5(gstruct49_0, 11);
																Thread.Sleep(600);
																int num43 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																bool flag109 = num43 != num9;
																if (flag109)
																{
																	int num44 = 0;
																	byte[] byte_4 = new byte[]
																	{
																		1
																	};
																	Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_33 * 4U, byte_4, 1, ref num44);
																	goto IL_1C24;
																}
															}
															bool flag110 = Class18.smethod_0(Class44.gstruct33_1.int_4);
															bool flag111;
															if (flag110)
															{
																Class50.smethod_2(gstruct49_0, "ChiÕn Long|H¸i Qu¶ H|L­ìng Thñy ", null, null, 0);
																flag111 = true;
															}
															else
															{
																bool flag112 = Class44.gstruct33_1.int_4 == 181;
																if (flag112)
																{
																	Class50.smethod_2(gstruct49_0, "h÷ng n¬i ®· ®i q|L­ìng Thñy|" + Class44.gstruct33_1.string_1, null, null, 0);
																	flag111 = true;
																}
																else
																{
																	bool flag113 = Class44.gstruct33_1.int_4 != 224;
																	if (flag113)
																	{
																		bool flag114 = Class44.gstruct33_1.int_4 != 993;
																		if (flag114)
																		{
																			Class50.smethod_4(gstruct49_0, Class44.gstruct33_1.int_4);
																			flag111 = true;
																		}
																		else
																		{
																			Class50.smethod_2(gstruct49_0, "NguyÖt Ca", null, null, 0);
																			flag111 = true;
																		}
																	}
																	else
																	{
																		Class50.smethod_2(gstruct49_0, "h÷ng n¬i ®· ®i q|Sa M¹c", null, null, 0);
																		flag111 = true;
																	}
																}
															}
															bool flag115 = flag111;
															if (flag115)
															{
																Thread.Sleep(150);
																Class60.smethod_11(gstruct49_0, 15000);
																int k = 0;
																while (k < 8)
																{
																	int num45 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
																	bool flag116 = num45 == num9;
																	if (!flag116)
																	{
																		goto IL_1C24;
																	}
																	k++;
																	Thread.Sleep(100);
																}
															}
															int num46 = -1;
															bool flag117 = Form1.int_19 > 0;
															if (flag117)
															{
																num46 = Class43.smethod_3(Class44.gstruct33_1.int_4);
															}
															bool flag118 = num46 < 0;
															if (flag118)
															{
																int num34 = Class60.smethod_7(num9, Class44.gstruct33_1.int_4, ref gstruct);
																bool flag119 = num34 == 0;
																if (flag119)
																{
																	goto IL_1C36;
																}
																bool flag120 = num34 > 0;
																if (flag120)
																{
																	Class50.smethod_5(gstruct49_0, num34);
																	goto IL_1C24;
																}
															}
															return -9;
															IL_1C24:
															Class86.smethod_8(gstruct49_0, -1);
															return -9;
														}
													}
												}
											}
										}
										else
										{
											gstruct = Class43.smethod_4(num9, 195);
										}
									}
									else
									{
										long num47 = Class60.smethod_21(Class41.uint_0, array);
										long num48 = Class60.smethod_21(Class41.uint_1, array);
										bool flag121 = num47 > num48;
										if (flag121)
										{
											return 6;
										}
										gstruct = Class43.smethod_4(num9, Class44.gstruct33_1.int_4);
									}
									IL_1C36:
									num8 = (int)Class22.smethod_30(num4 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
									bool flag122 = num8 > 0;
									if (flag122)
									{
										bool_10 = true;
									}
									bool flag123 = gstruct.uint_0 != null;
									if (flag123)
									{
										int num49 = 0;
										int int_10 = gstruct49_0.int_137;
										uint uint_8 = num4 + Class53.gstruct51_72.uint_0;
										byte[] byte_5 = new byte[4];
										Class22.WriteProcessMemory(int_10, uint_8, byte_5, 4, ref num49);
										uint[] array17 = new uint[]
										{
											Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										int num50 = 0;
										bool flag124 = gstruct.uint_0.GetLength(0) > 1;
										if (flag124)
										{
											num50 = Class60.smethod_20(gstruct.uint_0, array17);
										}
										Class60.smethod_8(gstruct.uint_0, num50, ref array15, ref uint_6, ref num29);
										long num51 = Class60.smethod_18(array17, array15);
										bool flag125 = num51 > 90000L;
										if (flag125)
										{
											bool flag126 = uint_0 == null;
											if (flag126)
											{
												uint_0 = new uint[]
												{
													array17[0],
													array17[1]
												};
												int_7 = 0;
											}
											bool flag127 = int_7 > 6;
											if (flag127)
											{
												bool flag128 = uint_0 != null && Class60.smethod_18(uint_0, array17) < 180000L;
												uint_0 = null;
												int_7 = 0;
												bool flag129 = flag128;
												if (flag129)
												{
													Class60.smethod_2(gstruct49_0, array17, array15, 600);
													return -1;
												}
											}
											Class60.smethod_29(gstruct49_0, false);
											bool flag130 = !Class14.smethod_3(gstruct49_0) || Class12.smethod_28(long_2) > 3000L;
											if (flag130)
											{
												int_7++;
												Class14.smethod_1(gstruct49_0, array15);
												long_2 = Class12.smethod_27();
											}
											result = -4;
										}
										else
										{
											int_7 = 0;
											uint_0 = null;
											Class60.smethod_23(gstruct49_0, array15, num29, uint_6, gstruct.int_1);
											result = -4;
										}
									}
									else
									{
										int num52 = Class86.smethod_0(gstruct49_0);
										Class70.smethod_59(gstruct49_0, 0, (int)Convert.ToByte(num52 != 0));
										result = 12;
									}
								}
							}
						}
					}
				}
				else
				{
					result = 1;
				}
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0016419C File Offset: 0x0016239C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000A3F RID: 2623
		public static int int_0 = 0;

		// Token: 0x04000A40 RID: 2624
		public static bool bool_0 = false;

		// Token: 0x04000A41 RID: 2625
		public static string[] string_0 = null;

		// Token: 0x04000A42 RID: 2626
		public static bool bool_1 = false;

		// Token: 0x04000A43 RID: 2627
		public static int[] int_1 = null;

		// Token: 0x04000A44 RID: 2628
		public static string string_1 = null;

		// Token: 0x04000A45 RID: 2629
		public static bool bool_2 = false;

		// Token: 0x04000A46 RID: 2630
		public static bool bool_3 = false;

		// Token: 0x04000A47 RID: 2631
		public static bool bool_4 = false;

		// Token: 0x04000A48 RID: 2632
		public static bool bool_5 = false;

		// Token: 0x04000A49 RID: 2633
		public static bool bool_6 = false;

		// Token: 0x04000A4A RID: 2634
		public static bool bool_7 = false;

		// Token: 0x04000A4B RID: 2635
		public static string string_2 = Class62.smethod_6("SMayphu", 0, "|");

		// Token: 0x04000A4C RID: 2636
		public static int int_2 = Class62.smethod_3("TocdoBaoToado", 0, "100");

		// Token: 0x04000A4D RID: 2637
		public int int_3 = 0;

		// Token: 0x04000A4E RID: 2638
		public int int_4 = 0;

		// Token: 0x04000A4F RID: 2639
		public int int_5;

		// Token: 0x04000A50 RID: 2640
		public int int_6;

		// Token: 0x04000A51 RID: 2641
		public static bool bool_8 = false;

		// Token: 0x04000A52 RID: 2642
		public static long long_0 = 0L;

		// Token: 0x04000A53 RID: 2643
		public static long long_1 = 4000L;

		// Token: 0x04000A54 RID: 2644
		private static bool bool_9 = false;

		// Token: 0x04000A55 RID: 2645
		private string[] string_3 = null;

		// Token: 0x04000A56 RID: 2646
		private IContainer icontainer_0 = null;
	}
}
