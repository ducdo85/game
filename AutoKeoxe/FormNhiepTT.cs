using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200007B RID: 123
	public partial class FormNhiepTT : Form
	{
		// Token: 0x060009D7 RID: 2519 RVA: 0x0016621C File Offset: 0x0016441C
		public FormNhiepTT()
		{
			FormNhiepTT.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x0016627C File Offset: 0x0016447C
		static FormNhiepTT()
		{
			string[,] array = new string[7, 2];
			array[0, 0] = "Lâm An";
			array[0, 1] = "176";
			FormNhiepTT.int_7 = Class62.smethod_3("NTT_KieuPT", 0, "0");
			FormNhiepTT.string_4 = "bVJPSyMxFL/3U7yjBVvUo4cFz8IiOHhP0zIZ7Mx0pxnBo4h4EvToYbHdUkRWoa7CQsKyh3T7PfJN9vcy49CCl8kkee/37+VQlVlMceLt9306kDT25g9pb1+p56Y59UWmSBc5as7cL3x3d2iknNHbNBZlsyOt3DPazDSlLF4tUNi0d1utE/dCfW/n1ENFRlJ5e5Nxc80bukVNvsbr7U9UKep84QX1W2g185TBnnQbkiaUefO3rIF1McgZ51spIMNNzkm59zQoDRTy3xOULe+cCU5Uw6kToIyYcC43lC9vofCipFMs19k+tTp0BAmzhKR7o2M31RTBzSM7MbOMtlTuzW/5yc3Q2yvCwf2IOiRKna9FnXr70IYuby8Jv6zwR9moXS28ncnt2infVwMpVovVFGuV3ibiEDGdUyFgoUMRNpokZLDh5V1CJwFTU3DCvLA4qn2pgTzlZHOWhTgixpPDBKdfVZVTpDBQXXjzCMcsqCegY6/dpYNNGQx9jyuYfxXVLkEjsz+EJzX5QI6i2v96+k3YGO+LrjwG3KOo5uVoMcoqvAt+jPxI+8l4TLFIB+uJ5HEYN94C4n2rwIBTjb77Hw==";
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x001662D4 File Offset: 0x001644D4
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x001670B4 File Offset: 0x001652B4
		public static void smethod_0()
		{
			int int_ = FormNhiepTT.int_0;
			FormNhiepTT.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25 || Form1.gstruct49_0[num].int_123 <= 0;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_36 = false;
							Class70.smethod_57(Form1.gstruct49_0[num], "Chat('CH_NEARBY', '(hod)<color=green>" + Form1.string_1 + "<color=white> ChÕ ®é b¸o danh v­ît ¶i kÕt thóc !')");
							int num2 = 0;
							byte[] array = new byte[1];
							byte[] byte_ = array;
							Class22.WriteProcessMemory(Form1.gstruct49_0[num].int_137, Form1.gstruct49_0[num].uint_15 + Class70.uint_42 * 4U, byte_, 1, ref num2);
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_36;
						if (bool_)
						{
							break;
						}
						flag = true;
						Form1.gstruct49_0[num].bool_36 = true;
						Class70.smethod_57(Form1.gstruct49_0[num], "Chat('CH_NEARBY', '(lvd)<color=green>" + Form1.string_1 + "<color=white> ChÕ ®é chê ®îi b¸o danh v­ît ¶i b¾t ®Çu s½n sµng!')");
					}
					FormNhiepTT.smethod_3(int_);
				}
				catch
				{
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00167248 File Offset: 0x00165448
		private static string smethod_1(int int_12)
		{
			string result = "t©m";
			if (int_12 != 11)
			{
				if (int_12 == 176)
				{
					result = "b¾c";
				}
			}
			else
			{
				result = "®«ng|§«ng";
			}
			return result;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00167288 File Offset: 0x00165488
		private static int smethod_2(GStruct49 gstruct49_0, uint[] uint_0)
		{
			uint num = 3U;
			bool flag = uint_0 != null && uint_0[4] != num;
			int result;
			if (flag)
			{
				uint uint_ = 1U;
				uint uint_2 = 2U;
				Class79.smethod_24(gstruct49_0, 3U);
				for (;;)
				{
					uint[] array = Class79.smethod_26(gstruct49_0, num, uint_, uint_2);
					bool flag2 = array == null;
					if (!flag2)
					{
						goto IL_81;
					}
					int num2 = Class32.smethod_6(gstruct49_0, 1, 1, false);
					int num3 = Class32.smethod_6(gstruct49_0, 0, 1, false);
					bool flag3 = num2 <= 0 && num3 <= 0;
					if (flag3)
					{
						break;
					}
					Thread.Sleep(10);
				}
				return -1;
				IL_81:
				int num4 = 0;
				int i = 0;
				byte[] array2 = new byte[4];
				while (i < 20)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num4);
					int num5 = (int)array2[0];
					bool flag4 = num5 > 0;
					if (flag4)
					{
						break;
					}
					bool flag5 = i % 4 == 0;
					if (flag5)
					{
						Class70.smethod_46(gstruct49_0, uint_0[2], uint_0[3], uint_0[4], uint_0[2], uint_0[3], uint_0[4]);
					}
					bool flag6 = i > 20;
					if (flag6)
					{
						break;
					}
					Thread.Sleep(300);
					i++;
				}
				i = 0;
				for (;;)
				{
					bool flag7 = i < 20;
					if (!flag7)
					{
						goto IL_191;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num4);
					bool flag8 = array2[0] == 0;
					if (flag8)
					{
						break;
					}
					bool flag9 = i % 4 == 0;
					if (flag9)
					{
						uint[] array;
						Class70.smethod_46(gstruct49_0, array[0], array[1], num, array[0], array[1], num);
					}
					i++;
					Thread.Sleep(300);
				}
				return 1;
				IL_191:
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 1, ref num4);
				bool flag10 = array2[0] > 0;
				if (flag10)
				{
					Class70.smethod_46(gstruct49_0, uint_0[2], uint_0[3], uint_0[4], uint_0[2], uint_0[3], uint_0[4]);
					Thread.Sleep(300);
				}
				result = 0;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0016749C File Offset: 0x0016569C
		public static void smethod_3(int int_12)
		{
			int num = 0;
			byte[] array = new byte[4];
			int[] array2 = new int[10];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = 4;
			}
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long ticks = new TimeSpan(0, 0, 10, 0, 0).Ticks;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 100;
			int num14 = 0;
			uint[,] array3 = new uint[7, 3];
			Class11.smethod_4(array3, 20687);
			uint[,] array4 = array3;
			int num15 = 0;
			string b = null;
			for (;;)
			{
				IL_1518:
				Thread.Sleep(1000);
				int num16 = Class81.smethod_3(Form1.gstruct49_0, int_12);
				bool flag = Class12.bool_0 || num16 < 0 || !Form1.gstruct49_0[num16].bool_25 || Form1.gstruct49_0[num16].int_123 <= 0;
				if (flag)
				{
					break;
				}
				GStruct49 gstruct = Form1.gstruct49_0[num16];
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num17 = BitConverter.ToInt32(array, 0);
				bool flag2 = (463 >= num17 || num17 >= 472) && (479 >= num17 || num17 >= 496);
				if (flag2)
				{
					bool flag3 = FormNhiepTT.string_1 == null || FormNhiepTT.string_1 == string.Empty;
					if (flag3)
					{
						bool flag4 = Class12.smethod_28(long_) > 15000L;
						if (flag4)
						{
							Class70.smethod_52(gstruct, "- Lçi b¸o danh V­ît ¶i: b¹n ch­a chän khung giê...", 1);
							long_ = Class12.smethod_27();
						}
						continue;
					}
					int num18 = Class83.smethod_12(gstruct);
					bool flag5 = num18 > 0;
					if (flag5)
					{
						continue;
					}
					DateTime now = DateTime.Now;
					long ticks2 = new TimeSpan(0, now.Hour, now.Minute, now.Second, now.Millisecond).Ticks;
					string[] array5 = FormNhiepTT.string_1.Split(new char[]
					{
						',',
						';',
						'-'
					});
					for (int j = 0; j < array5.Length; j++)
					{
						long ticks3 = new TimeSpan(0, Class12.smethod_11(array5[j]), FormNhiepTT.int_2, 0, 0).Ticks;
						long num19 = ticks2 - ticks3;
						bool flag6 = 0L > num19 || num19 > ticks;
						if (!flag6)
						{
							bool flag7 = num5 == 0;
							if (flag7)
							{
								Class70.smethod_57(gstruct, string.Concat(new string[]
								{
									"Chat('CH_NEARBY', '(lvd)<color=green>",
									Form1.string_1,
									"<color=white> ",
									Class12.smethod_53("ᓕᓖᒡᓅᓐᓏᓈᒡᓃᓂᓐᒡᓅᓂᓏᓉᒡᓗᓖᓐᓕᒡᓂᓊ"),
									"')"
								}));
								num5 = 1;
							}
							bool flag8 = num2 < 0 || num4 != FormNhiepTT.int_3;
							if (flag8)
							{
								num2 = FormNhiepTT.int_3;
								num4 = FormNhiepTT.int_3;
							}
							bool flag9 = num3 == num17;
							if (flag9)
							{
								Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref array2[0]);
								uint num20 = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_13.uint_0, array, 4, ref array2[1]);
								uint num21 = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref array2[2]);
								uint num22 = BitConverter.ToUInt32(array, 0);
								uint num23 = num22 + num21 * Class53.gstruct51_15.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_55.uint_0, array, 4, ref array2[3]);
								int num24 = BitConverter.ToInt32(array, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_50.uint_0, array, 4, ref array2[4]);
								int num25 = BitConverter.ToInt32(array, 0);
								int num26 = Class83.smethod_39(gstruct);
								bool flag10 = num25 == 0 || num24 == 0 || num24 == 10 || num24 == 21 || num26 <= 1;
								if (!flag10)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_43.uint_0, array, 4, ref array2[5]);
									int num27 = BitConverter.ToInt32(array, 0);
									int k = 0;
									for (;;)
									{
										bool flag11 = k <= 5;
										if (!flag11)
										{
											goto IL_4FC;
										}
										bool flag12 = array2[k] == 0;
										if (flag12)
										{
											break;
										}
										k++;
									}
									IL_14FC:
									goto IL_1517;
									IL_4FC:
									bool flag13 = num27 <= 0;
									if (flag13)
									{
										array[0] = 1;
										Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_42 * 4U, array, 1, ref num);
										bool flag14 = num17 != num2;
										if (flag14)
										{
											bool flag15 = num10 < 5 && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
											if (flag15)
											{
												Class35.smethod_140(gstruct, num2, FormNhiepTT.smethod_1(num2), null, false);
												num10++;
											}
											else
											{
												Class50.smethod_5(gstruct, num2);
											}
											Thread.Sleep(1000);
										}
										else
										{
											bool flag16 = num8 > 0;
											if (flag16)
											{
												bool flag17 = FormNhiepTT.int_6 > 0;
												if (flag17)
												{
													bool flag18 = FormNhiepTT.int_1 < 0;
													if (flag18)
													{
														FormNhiepTT.int_1 = 1;
													}
													bool flag19 = FormNhiepTT.string_2 == null || FormNhiepTT.string_2 == string.Empty;
													if (flag19)
													{
														FormNhiepTT.string_2 = "Long HuyÕt Hoµn";
													}
													bool flag20 = num9 < FormNhiepTT.int_1;
													if (flag20)
													{
														Class70.smethod_44(gstruct, FormNhiepTT.string_2, true, -1, false);
														Thread.Sleep(300);
														Class86.smethod_8(gstruct, -1);
														num9++;
													}
												}
												bool flag21 = num7 < 3;
												if (flag21)
												{
													num7++;
													bool flag22 = 0 <= Class34.smethod_3(gstruct, true);
													if (flag22)
													{
														num7 = 3;
													}
													Thread.Sleep(300);
												}
												else
												{
													uint[] array6 = new uint[2];
													for (k = 0; k < array4.GetLength(0); k++)
													{
														bool flag23 = (long)num2 == (long)((ulong)array4[k, 0]);
														if (flag23)
														{
															array6[0] = array4[k, 1];
															array6[1] = array4[k, 2];
														}
													}
													uint[] array7 = new uint[2];
													Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
													array7[0] = BitConverter.ToUInt32(array, 0);
													Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
													array7[1] = BitConverter.ToUInt32(array, 0);
													long num28 = Class60.smethod_18(array7, array6);
													bool flag24 = num28 < 300000L;
													if (flag24)
													{
														num12 = 0;
														num13++;
														bool flag25 = num13 <= 100;
														if (flag25)
														{
															bool flag26 = num28 > 11250L;
															if (flag26)
															{
																Class70.smethod_61(gstruct, array6);
																Thread.Sleep(300);
															}
														}
														else
														{
															num13 = 0;
															Class70.smethod_61(gstruct, new uint[]
															{
																array6[0] + 120U,
																array6[1] + 120U
															});
															Thread.Sleep(300);
														}
														GStruct59 gstruct2 = Class82.smethod_5(gstruct);
														bool flag27 = gstruct2.string_0 != gstruct.string_22;
														if (flag27)
														{
															string text = Class83.smethod_22(gstruct);
															bool flag28 = text != null && text.Length > 6;
															if (flag28)
															{
																int num29 = text.IndexOf(":");
																bool flag29 = 0 <= num29 && text.Length > num29;
																if (flag29)
																{
																	text = text.Substring(num29 + 1).Trim();
																}
																string text2 = Class12.smethod_71(text);
																num29 = text2.IndexOf("m=");
																bool flag30 = 0 <= num29;
																if (flag30)
																{
																	int num30 = Class12.smethod_11(text2.Substring(num29 + 2));
																	bool flag31 = num30 > 0 && FormNhiepTT.int_3 != num30;
																	if (flag31)
																	{
																		for (k = 0; k < array4.GetLength(0); k++)
																		{
																			bool flag32 = (long)num30 != (long)((ulong)array4[k, 0]);
																			if (!flag32)
																			{
																				FormNhiepTT.int_3 = num30;
																				for (int l = 0; l < FormNhiepTT.string_0.GetLength(0); l++)
																				{
																					bool flag33 = FormNhiepTT.string_0[l, 1] == num30.ToString();
																					if (flag33)
																					{
																						bool flag34 = Class12.smethod_28(long_) > 30000L;
																						if (flag34)
																						{
																							Class70.smethod_57(gstruct, "Chat('CH_NEARBY', '" + Class10.smethod_2("<color=pink>Đã đầy, chuyển sang " + FormNhiepTT.string_0[l, 0]) + "')");
																							long_ = Class12.smethod_27();
																						}
																						break;
																					}
																				}
																				break;
																			}
																		}
																	}
																}
															}
															bool flag35 = Class12.smethod_28(long_) > 30000L;
															if (flag35)
															{
																Class83.smethod_32(gstruct, 1U);
																Thread.Sleep(300);
																Class70.smethod_57(gstruct, string.Concat(new string[]
																{
																	"Chat('CH_NEARBY', '(lvd)<color=green>",
																	Form1.string_1,
																	"<color=white> ",
																	Class12.smethod_53("ᔯᓩᓶᓯᒨᓫᓰᕲᒨᔶᕱᓱᒨᓼᓺᓽᕳᓶᓯᒨᓪᕀᓷᒨᓬᓩᓶᓰᒶᒶᒶ"),
																	"')"
																}));
																long_ = Class12.smethod_27();
															}
														}
														else
														{
															bool flag36 = gstruct2.int_0 > 3;
															if (flag36)
															{
																bool flag37 = FormNhiepTT.int_7 > 0 && gstruct.string_19 != null;
																if (flag37)
																{
																	int num31 = 0;
																	bool flag38 = gstruct2.int_0 > 0;
																	if (flag38)
																	{
																		for (k = 0; k < gstruct2.gstruct58_0.GetLength(0); k++)
																		{
																			string text3 = gstruct2.gstruct58_0[k].string_0;
																			bool flag39 = text3 == null || text3 == string.Empty;
																			if (!flag39)
																			{
																				for (int m = 0; m < gstruct.string_19.Length; m++)
																				{
																					bool flag40 = text3 == gstruct.string_19[m];
																					if (flag40)
																					{
																						num31++;
																						break;
																					}
																				}
																			}
																		}
																	}
																	bool flag41 = num31 <= 7 && num31 != gstruct.string_19.Length;
																	if (flag41)
																	{
																		goto IL_14FC;
																	}
																}
																uint[] array8 = null;
																bool flag42 = num15 > 0;
																if (flag42)
																{
																	string a = Class98.smethod_16(gstruct, num15, ref array8, 40);
																	bool flag43 = a == b;
																	if (flag43)
																	{
																		goto IL_FC3;
																	}
																}
																num15 = Class98.smethod_15(gstruct, "NhiÕp |Ý TrÇn", ref array8, 3, false, -1, null);
																bool flag44 = num15 <= 0;
																if (flag44)
																{
																	bool flag45 = Class12.smethod_28(long_) > 30000L;
																	if (flag45)
																	{
																		Class70.smethod_52(gstruct, "- Kh«ng t×m thÊy NPC NhiÕp ThÝ TrÇn...", 1);
																		long_ = Class12.smethod_27();
																	}
																	goto IL_14FC;
																}
																b = Class98.smethod_16(gstruct, num15, ref array8, 40);
																IL_FC3:
																for (;;)
																{
																	IL_14EA:
																	int num31 = 0;
																	while (!Class12.bool_0 && num31 < 10)
																	{
																		Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
																		array7[0] = BitConverter.ToUInt32(array, 0);
																		Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
																		array7[1] = BitConverter.ToUInt32(array, 0);
																		bool flag46 = Class60.smethod_18(array7, array8) < 22500L;
																		if (flag46)
																		{
																			break;
																		}
																		Class70.smethod_61(gstruct, array8);
																		Thread.Sleep(300);
																		num31++;
																	}
																	Class86.smethod_8(gstruct, -1);
																	Class86.Class88.smethod_2(gstruct, null);
																	Class36.smethod_10(gstruct, (uint)num15);
																	Thread.Sleep(300);
																	num31 = 0;
																	while (Class86.smethod_0(gstruct) < 0)
																	{
																		num31++;
																		Thread.Sleep(100);
																		bool flag47 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
																		if (flag47)
																		{
																			string text4 = Class45.smethod_4(gstruct);
																			bool flag48 = text4.IndexOf("è l­în") <= 0;
																			if (flag48)
																			{
																				Class45.smethod_3(gstruct, null);
																			}
																			else
																			{
																				Class45.smethod_3(gstruct, "1");
																			}
																		}
																		bool flag49 = Class86.Class89.smethod_4(gstruct);
																		if (flag49)
																		{
																			Class86.Class89.smethod_5(gstruct);
																		}
																		bool flag50 = num31 <= 10;
																		if (!flag50)
																		{
																			num14++;
																			bool flag51 = num14 > 3;
																			if (flag51)
																			{
																				goto Block_126;
																			}
																			goto IL_14EA;
																		}
																	}
																	goto Block_107;
																}
																IL_14F2:
																goto IL_14FC;
																Block_126:
																Class60.smethod_12(gstruct, true);
																num14 = 0;
																goto IL_14F2;
																Block_107:
																num14 = 0;
																bool flag52 = num6 <= 0;
																if (flag52)
																{
																	uint num32 = num20 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
																	Class22.ReadProcessMemory(gstruct.int_137, num32 + Class53.gstruct51_73.uint_0, array, 4, ref num);
																	int num33 = BitConverter.ToInt32(array, 0);
																	int num34 = 100000;
																	bool flag53 = num33 < num34;
																	if (flag53)
																	{
																		Class22.ReadProcessMemory(gstruct.int_137, num32 + Class53.gstruct51_74.uint_0, array, 4, ref num);
																		int num35 = BitConverter.ToInt32(array, 0);
																		int num36 = num34 - num33;
																		bool flag54 = num36 <= num35;
																		if (flag54)
																		{
																			bool flag55 = gstruct.string_15 != null && gstruct.string_15 != string.Empty;
																			if (flag55)
																			{
																				uint num37 = Class12.smethod_12(gstruct.string_15);
																				bool flag56 = num37 > 0U;
																				if (flag56)
																				{
																					Class70.smethod_117(gstruct, num37);
																					Thread.Sleep(300);
																				}
																			}
																			Class70.smethod_37(gstruct, (uint)num36);
																			Thread.Sleep(300);
																		}
																	}
																	num6 = 1;
																}
																string text5 = "luyÖn s¸t thñ|khiªu chiÕn|dÉn d¾t ®éi";
																Class86.smethod_6(gstruct, text5, false, false, false, false);
																string string_ = Class86.Class88.smethod_1(gstruct);
																Class86.smethod_8(gstruct, -1);
																bool flag57 = FormNhiepTT.int_4 == 0 || Class12.smethod_1(string_, "h«ng cßn chç") < 0;
																if (!flag57)
																{
																	int num38 = -1;
																	for (k = 0; k < array4.GetLength(0); k++)
																	{
																		bool flag58 = (long)FormNhiepTT.int_3 == (long)((ulong)array4[k, 0]);
																		if (flag58)
																		{
																			k = ((array4.GetLength(0) - 1 > k) ? (k + 1) : 0);
																			num38 = (int)array4[k, 0];
																			break;
																		}
																	}
																	bool flag59 = num38 <= 0 || FormNhiepTT.int_3 == num38;
																	if (!flag59)
																	{
																		GStruct59 gstruct3 = Class82.smethod_5(gstruct);
																		bool flag60 = gstruct3.int_0 > 0;
																		if (flag60)
																		{
																			string text6 = Class12.smethod_70("m=" + num38.ToString());
																			for (int n = 0; n < 3; n++)
																			{
																				for (k = 0; k < gstruct3.gstruct58_0.GetLength(0); k++)
																				{
																					bool flag61 = gstruct.string_22 != gstruct3.gstruct58_0[k].string_0 && gstruct3.gstruct58_0[k].string_0 != null && gstruct3.gstruct58_0[k].string_0 != string.Empty;
																					if (flag61)
																					{
																						Class70.smethod_50(gstruct, gstruct3.gstruct58_0[k].string_0, text6);
																						Thread.Sleep(100);
																					}
																				}
																				Thread.Sleep(600);
																			}
																		}
																		for (k = 0; k < FormNhiepTT.string_0.GetLength(0); k++)
																		{
																			bool flag62 = FormNhiepTT.string_0[k, 1] == num38.ToString();
																			if (flag62)
																			{
																				Class70.smethod_52(gstruct, Class10.smethod_2("Đã đầy, chuyển sang " + FormNhiepTT.string_0[k, 0]), 1);
																				break;
																			}
																		}
																		FormNhiepTT.int_3 = num38;
																	}
																}
															}
															else
															{
																bool flag63 = Class12.smethod_28(long_) > 30000L;
																if (flag63)
																{
																	Class70.smethod_52(gstruct, "- Tæ ®éi ®ang cã " + gstruct2.int_0.ToString() + " thµnh viªn, ®ang chê ®ñ...", 1);
																	long_ = Class12.smethod_27();
																}
															}
														}
													}
													else
													{
														Class60.smethod_29(gstruct, false);
														bool flag64 = num12 < 5;
														if (flag64)
														{
															uint[,] array9 = Class42.smethod_1(num17, array7, array6, null, false);
															bool flag65 = array9 != null;
															if (flag65)
															{
																num12++;
																bool flag66 = 0 <= Class60.smethod_22(gstruct, array9, array7, array6, num17, false, 16000, false);
																if (flag66)
																{
																	num12 = 0;
																}
																goto IL_14FC;
															}
														}
														bool flag67 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_2) > 6000L;
														if (flag67)
														{
															Class14.smethod_1(gstruct, array6);
															long_2 = Class12.smethod_27();
														}
													}
												}
											}
											else
											{
												bool flag68 = Class12.smethod_28(long_3) >= 10000L;
												if (flag68)
												{
													int[] array10 = new int[]
													{
														3,
														23,
														4,
														9,
														10
													};
													string text7 = "S¸t thñ gi¶n";
													uint[] array11 = null;
													for (k = 0; k < array10.Length; k++)
													{
														array11 = Class79.smethod_29(gstruct, text7, array10[k], true);
														bool flag69 = array11 != null;
														if (flag69)
														{
															break;
														}
													}
													bool flag70 = array11 != null;
													if (flag70)
													{
														bool flag71 = array11[4] == 3U;
														if (flag71)
														{
															num8 = 1;
															goto IL_14FC;
														}
														bool flag72 = array11[4] == 23U;
														if (flag72)
														{
															FormNhiepTT.smethod_2(gstruct, array11);
															Thread.Sleep(300);
															goto IL_14FC;
														}
													}
													uint[] array12 = null;
													string text8 = "S¸t Thñ Gi¶n lÔ hép";
													for (k = 0; k < array10.Length; k++)
													{
														array12 = Class79.smethod_29(gstruct, text8, array10[k], true);
														bool flag73 = array12 != null;
														if (flag73)
														{
															break;
														}
													}
													bool flag74 = array12 != null;
													if (flag74)
													{
														bool flag75 = array12[4] == 3U;
														if (flag75)
														{
															Class70.smethod_43(gstruct, array12[0], (int)array12[2], (int)array12[3], 3);
															Thread.Sleep(300);
															Class86.smethod_6(gstruct, "m|t|h", false, false, false, false);
															Thread.Sleep(300);
															goto IL_14FC;
														}
														bool flag76 = array12[4] == 23U;
														if (flag76)
														{
															FormNhiepTT.smethod_2(gstruct, array12);
															Thread.Sleep(300);
															goto IL_14FC;
														}
													}
													bool flag77 = array11 != null && (array11[4] == 4U || array11[4] == 9U || array11[4] == 10U);
													bool flag78 = array12 != null && (array12[4] == 4U || array12[4] == 9U || array12[4] == 10U);
													bool flag79 = !flag77 && !flag78;
													if (flag79)
													{
														long_3 = Class12.smethod_27();
													}
													else
													{
														bool flag80 = Class45.smethod_8(gstruct);
														if (flag80)
														{
															bool flag81 = flag77;
															if (flag81)
															{
																FormNhiepTT.smethod_2(gstruct, array11);
															}
															else
															{
																bool flag82 = flag78;
																if (flag82)
																{
																	FormNhiepTT.smethod_2(gstruct, array12);
																}
															}
															Class45.smethod_11(gstruct);
														}
														else
														{
															Class91.smethod_0(gstruct, false, null);
														}
													}
												}
												else
												{
													bool flag83 = Class12.smethod_28(long_) > 30000L;
													if (flag83)
													{
														Class70.smethod_52(gstruct, "- Kh«ng t×m thÊy S¸t Thñ gi¶n...", 1);
														long_ = Class12.smethod_27();
													}
												}
											}
										}
									}
									else
									{
										bool flag84 = FormNhiepTT.int_5 > 0;
										if (flag84)
										{
											bool flag85 = num10 < 5;
											if (flag85)
											{
												bool flag86 = Class70.smethod_3(gstruct, Class70.uint_19, 4) <= 0;
												if (flag86)
												{
													num10 = 5;
												}
												else
												{
													Class35.smethod_140(gstruct, num2, FormNhiepTT.smethod_1(num2), null, false);
												}
												num10++;
												num11 = 0;
											}
											else
											{
												bool flag87 = num11 < 5;
												if (flag87)
												{
													Class60.smethod_14(gstruct, true);
													num11++;
													num10 = 0;
												}
											}
											Thread.Sleep(300);
										}
										else
										{
											bool flag88 = Class12.smethod_28(long_) > 30000L;
											if (flag88)
											{
												Class70.smethod_52(gstruct, "- Kh«ng thÓ b¸o danh v­ît ¶i do ®ang ë n¬i chiÕn ®Êu, vµo b¶ng 2 auto ®Ó thiÕt lËp l¹i nÕu muèn...", 1);
												long_ = Class12.smethod_27();
											}
											array[0] = 0;
											Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_42 * 4U, array, 1, ref num);
										}
									}
								}
							}
							else
							{
								num3 = num17;
								num10 = 0;
								num11 = 0;
								num6 = 0;
								num7 = 0;
								num8 = 0;
								num9 = 0;
							}
							IL_1517:
							goto IL_1518;
						}
					}
				}
				array[0] = 0;
				Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_42 * 4U, array, 1, ref num);
				bool flag89 = num15 > 0;
				if (flag89)
				{
					Thread.Sleep(1000);
					Class86.smethod_8(gstruct, -1);
				}
				num2 = -1;
				num3 = -1;
				num7 = 0;
				num8 = 0;
				num9 = 0;
				num15 = 0;
				b = null;
				num14 = 0;
				num6 = 0;
				num5 = 0;
				Thread.Sleep(300);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x001689C9 File Offset: 0x00166BC9
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			this.int_8 = 0;
			this.int_9 = 0;
			FormNhiepTT.int_0 = 0;
			FormNhiepTT.bool_0 = false;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x001689E8 File Offset: 0x00166BE8
		private void FormNhiepTT_Load(object sender, EventArgs e)
		{
			Thread.Sleep(100);
			bool flag = this.int_8 > 0 && this.int_9 > 0;
			if (flag)
			{
				int num = this.int_8 - base.Width - 10;
				int num2 = this.int_9 - base.Height - 10;
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
			for (int i = 0; i < FormNhiepTT.string_0.GetLength(0); i++)
			{
				this.comboBox1.Items.Add(FormNhiepTT.string_0[i, 0]);
				bool flag4 = FormNhiepTT.int_3 == Class12.smethod_11(FormNhiepTT.string_0[i, 1]);
				if (flag4)
				{
					this.comboBox1.Text = FormNhiepTT.string_0[i, 0];
				}
			}
			for (int j = 0; j < this.string_3.GetLength(0); j++)
			{
				this.comboBox2.Items.Add(this.string_3[j]);
				bool flag5 = j == FormNhiepTT.int_7;
				if (flag5)
				{
					this.comboBox2.Text = this.string_3[j];
				}
			}
			for (int k = 0; k < 24; k++)
			{
				this.method_0(this.listView1, k.ToString() + " giờ");
			}
			bool flag6 = FormNhiepTT.string_1 != null && FormNhiepTT.string_1 != string.Empty;
			if (flag6)
			{
				string[] array = FormNhiepTT.string_1.Split(new char[]
				{
					',',
					';',
					'-'
				});
				for (int l = 0; l < array.Length; l++)
				{
					this.listView1.Items[Class12.smethod_11(array[l])].Checked = true;
				}
			}
			this.checkBoxTuchuyenThanh.Checked = (FormNhiepTT.int_4 > 0);
			this.checkBoxTDP.Checked = (FormNhiepTT.int_5 > 0);
			this.checkBoxLongHH.Checked = (FormNhiepTT.int_6 > 0);
			this.richTextBox1.Text = Class12.smethod_71(FormNhiepTT.string_4);
			this.numericUpDown1.Value = FormNhiepTT.int_2;
			this.string_5 = null;
			bool flag7 = FormNhiepTT.string_2 != null && FormNhiepTT.string_2 != string.Empty;
			if (flag7)
			{
				this.string_5 = new string[]
				{
					FormNhiepTT.string_2
				};
				string text = Class10.smethod_1(FormNhiepTT.string_2, 1, false);
				this.comboBoxAn.Items.Add(text);
				this.comboBoxAn.Text = text;
			}
			this.textBoxSL.Text = FormNhiepTT.int_1.ToString();
			Thread.Sleep(100);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00168D08 File Offset: 0x00166F08
		private void method_0(ListView listView_0, string string_6)
		{
			try
			{
				ListViewItem value = new ListViewItem(string_6);
				listView_0.Items.Add(value);
			}
			catch
			{
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00168D44 File Offset: 0x00166F44
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormNhiepTT.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonThoat_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00168D68 File Offset: 0x00166F68
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				int index = e.Index;
				int num = (int)Convert.ToByte(e.NewValue);
				bool flag2 = num > 0;
				if (flag2)
				{
					bool flag3 = FormNhiepTT.string_1 == null || FormNhiepTT.string_1 == string.Empty;
					if (flag3)
					{
						FormNhiepTT.string_1 = index.ToString();
						return;
					}
					string[] array = FormNhiepTT.string_1.Split(new char[]
					{
						',',
						';',
						'-'
					});
					for (int i = 0; i < array.Length; i++)
					{
						bool flag4 = index == Class12.smethod_11(array[i]);
						if (flag4)
						{
							return;
						}
					}
					FormNhiepTT.string_1 = FormNhiepTT.string_1 + "," + index.ToString();
				}
				else
				{
					bool flag5 = FormNhiepTT.string_1 == null || FormNhiepTT.string_1 == string.Empty;
					if (flag5)
					{
						return;
					}
					string[] array2 = FormNhiepTT.string_1.Split(new char[]
					{
						',',
						';',
						'-'
					});
					FormNhiepTT.string_1 = null;
					for (int j = 0; j < array2.Length; j++)
					{
						bool flag6 = index != Class12.smethod_11(array2[j]);
						if (flag6)
						{
							bool flag7 = FormNhiepTT.string_1 != null && FormNhiepTT.string_1 != string.Empty;
							if (flag7)
							{
								FormNhiepTT.string_1 += ",";
							}
							FormNhiepTT.string_1 += array2[j];
						}
					}
				}
				Class62.smethod_10(Class53.string_3, "NTT_Khunggio", FormNhiepTT.string_1, "", 0);
			}
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00168F34 File Offset: 0x00167134
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBox2.Text;
				for (int i = 0; i < this.string_3.Length; i++)
				{
					bool flag2 = text == this.string_3[i];
					if (flag2)
					{
						FormNhiepTT.int_7 = i;
						Class62.smethod_10(Class53.string_3, "NTT_KieuPT", FormNhiepTT.int_7, "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00168FB8 File Offset: 0x001671B8
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = this.comboBox1.Text;
				for (int i = 0; i < FormNhiepTT.string_0.GetLength(0); i++)
				{
					bool flag2 = text == FormNhiepTT.string_0[i, 0];
					if (flag2)
					{
						FormNhiepTT.int_3 = Class12.smethod_11(FormNhiepTT.string_0[i, 1]);
						Class62.smethod_10(Class53.string_3, "NTT_MapId", FormNhiepTT.int_3, "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00169054 File Offset: 0x00167254
		private void checkBoxTuchuyenThanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormNhiepTT.int_4 = (int)Convert.ToByte(this.checkBoxTuchuyenThanh.Checked);
				Class62.smethod_10(Class53.string_3, "NTT_ChuyenThanh", FormNhiepTT.int_4, "", 0);
			}
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x001690A8 File Offset: 0x001672A8
		private void checkBoxTDP_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormNhiepTT.int_5 = (int)Convert.ToByte(this.checkBoxTDP.Checked);
				Class62.smethod_10(Class53.string_3, "NTT_Thodiaphu", FormNhiepTT.int_5, "", 0);
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x001690FC File Offset: 0x001672FC
		private void checkBoxLongHH_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormNhiepTT.int_6 = (int)Convert.ToByte(this.checkBoxLongHH.Checked);
				Class62.smethod_10(Class53.string_3, "NTT_LongHH", FormNhiepTT.int_6, "", 0);
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00169150 File Offset: 0x00167350
		private void button1_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				this.listView1.Items[i].Checked = (i == 0);
			}
			this.listView1.TopItem = this.listView1.Items[0];
			this.listView1.Items[0].Selected = true;
			FormNhiepTT.string_1 = "0";
			Class62.smethod_10(Class53.string_3, "NTT_Khunggio", FormNhiepTT.string_1, "", 0);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x001691F4 File Offset: 0x001673F4
		private void comboBoxAn_MouseDown(object sender, MouseEventArgs e)
		{
			this.string_5 = null;
			this.comboBoxAn.Items.Clear();
			this.timer_0.Enabled = false;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class79.smethod_35(Form1.gstruct49_0[i], ref this.string_5, 0, null, false);
				}
			}
			bool flag2 = FormNhiepTT.string_2 != null && FormNhiepTT.string_2 != string.Empty;
			if (flag2)
			{
				bool flag3 = this.string_5 != null;
				if (flag3)
				{
					Array.Resize<string>(ref this.string_5, this.string_5.Length + 1);
				}
				else
				{
					this.string_5 = new string[1];
				}
				this.string_5[this.string_5.Length - 1] = FormNhiepTT.string_2;
			}
			this.comboBoxAn.Items.Add("");
			bool flag4 = this.string_5 != null;
			if (flag4)
			{
				Array.Sort<string>(this.string_5);
				for (int j = 0; j < this.string_5.Length; j++)
				{
					this.comboBoxAn.Items.Add(Class10.smethod_1(this.string_5[j], 1, false));
				}
				bool flag5 = FormNhiepTT.string_2 != null && FormNhiepTT.string_2 != string.Empty;
				if (flag5)
				{
					this.comboBoxAn.Text = Class10.smethod_1(FormNhiepTT.string_2, 1, false);
				}
			}
			this.timer_0.Enabled = true;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0016938C File Offset: 0x0016758C
		private void comboBoxAn_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				string text = string.Empty;
				string text2 = this.comboBoxAn.Text;
				bool flag2 = this.string_5 != null;
				if (flag2)
				{
					for (int i = 0; i < this.string_5.Length; i++)
					{
						bool flag3 = text2 == Class10.smethod_1(this.string_5[i], 1, false);
						if (flag3)
						{
							text = this.string_5[i];
							break;
						}
					}
				}
				FormNhiepTT.string_2 = text;
				Class62.smethod_10(Class53.string_3, "NTT_TenVatphamAn", Class12.smethod_70(FormNhiepTT.string_2), "", 0);
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00169440 File Offset: 0x00167640
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormNhiepTT.int_2 = (int)this.numericUpDown1.Value;
				Class62.smethod_10(Class53.string_3, "NTT_TimeDelta", FormNhiepTT.int_2, "", 0);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00169494 File Offset: 0x00167694
		private void textBoxSL_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormNhiepTT.int_1 = Class12.smethod_11(this.textBoxSL.Text);
				bool flag = FormNhiepTT.int_1 <= 0;
				if (flag)
				{
					FormNhiepTT.int_1 = 1;
				}
				Class62.smethod_10(Class53.string_3, "NTT_SLVatphamAn", FormNhiepTT.int_1, "", 0);
			}
		}

		// Token: 0x04000A86 RID: 2694
		private IContainer icontainer_0 = null;

		// Token: 0x04000A9A RID: 2714
		public static int int_0 = 0;

		// Token: 0x04000A9B RID: 2715
		public static string[,] string_0;

		// Token: 0x04000A9C RID: 2716
		public static bool bool_0;

		// Token: 0x04000A9D RID: 2717
		public static string string_1;

		// Token: 0x04000A9E RID: 2718
		public static string string_2;

		// Token: 0x04000A9F RID: 2719
		public static int int_1;

		// Token: 0x04000AA0 RID: 2720
		public static int int_2;

		// Token: 0x04000AA1 RID: 2721
		public static int int_3;

		// Token: 0x04000AA2 RID: 2722
		public static int int_4;

		// Token: 0x04000AA3 RID: 2723
		public static int int_5;

		// Token: 0x04000AA4 RID: 2724
		public static int int_6;

		// Token: 0x04000AA5 RID: 2725
		public static int int_7;

		// Token: 0x04000AA6 RID: 2726
		public int int_8;

		// Token: 0x04000AA7 RID: 2727
		public int int_9;

		// Token: 0x04000AA8 RID: 2728
		public int int_10;

		// Token: 0x04000AA9 RID: 2729
		public int int_11;

		// Token: 0x04000AAA RID: 2730
		private string[] string_3 = new string[]
		{
			"1. Chỉ cần 4ac trở đi thì click vượt ải",
			"2. Chờ đủ người chung tổ đội có trong danh sách PT (ở bảng 1)"
		};

		// Token: 0x04000AAB RID: 2731
		private static string string_4;

		// Token: 0x04000AAD RID: 2733
		private string[] string_5 = null;
	}
}
