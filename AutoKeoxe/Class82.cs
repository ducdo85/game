using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000051 RID: 81
	internal class Class82
	{
		// Token: 0x060004E9 RID: 1257 RVA: 0x000E30A6 File Offset: 0x000E12A6
		public static void smethod_0(GStruct49 gstruct49_0)
		{
			Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_52);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x000E30BB File Offset: 0x000E12BB
		public static void smethod_1(GStruct49 gstruct49_0)
		{
			Class70.smethod_57(gstruct49_0, "CreateTeam()");
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x000E30CA File Offset: 0x000E12CA
		public static void smethod_2(GStruct49 gstruct49_0)
		{
			Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_53);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000E30DF File Offset: 0x000E12DF
		public static void smethod_3(GStruct49 gstruct49_0, string string_0)
		{
			Class70.smethod_57(gstruct49_0, "InviteTeam('" + string_0 + "')");
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000E30FC File Offset: 0x000E12FC
		public static bool smethod_4(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			return Class22.smethod_30(num + Class53.gstruct51_12.uint_0 + Class53.gstruct51_202.uint_0, gstruct49_0.int_137) > 0U;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000E314C File Offset: 0x000E134C
		public static GStruct59 smethod_5(GStruct49 gstruct49_0)
		{
			GStruct58[] array = new GStruct58[8];
			int num = 0;
			string string_ = string.Empty;
			for (int i = 0; i < 8; i++)
			{
				string text = Class22.smethod_28(Class53.gstruct51_203.uint_0 + gstruct49_0.uint_7 + (uint)(i * (int)Class53.gstruct51_198.uint_0), gstruct49_0.int_137, 32);
				bool flag = text != string.Empty;
				if (flag)
				{
					num++;
					bool flag2 = i == 0;
					if (flag2)
					{
						string_ = text;
					}
					array[i].string_0 = text;
					array[i].int_1 = i;
					array[i].int_0 = (int)Class22.smethod_30((uint)((ulong)(Class53.gstruct51_200.uint_0 + gstruct49_0.uint_7) + (ulong)((long)i * (long)((ulong)Class53.gstruct51_199.uint_0))), gstruct49_0.int_137);
				}
			}
			return new GStruct59
			{
				int_0 = num,
				string_0 = string_,
				gstruct58_0 = array
			};
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000E325C File Offset: 0x000E145C
		public static void smethod_6(GStruct49 gstruct49_0, string[] string_0 = null, bool bool_0 = true)
		{
			string text = Class52.smethod_2(gstruct49_0, true);
			string[] array = text.Split(new char[]
			{
				';'
			});
			bool flag = array.Length < 2;
			if (!flag)
			{
				bool flag2 = string_0 != null && string_0.Length != 0;
				if (flag2)
				{
					bool flag3 = false;
					array[1] = Class10.smethod_1(array[1], 1, false);
					for (int i = 0; i < string_0.Length; i++)
					{
						bool flag4 = array[1] == string_0[i];
						if (flag4)
						{
							flag3 = true;
							break;
						}
					}
					bool flag5 = !flag3;
					if (flag5)
					{
						return;
					}
				}
				uint uint_ = Class12.smethod_12(array[0]);
				Class22.smethod_31(gstruct49_0.uint_54 + 2U, gstruct49_0.int_137, uint_, 4);
				Class22.smethod_31(gstruct49_0.uint_54 + 7U, gstruct49_0.int_137, (uint)Convert.ToByte(bool_0), 1);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_54);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000E3344 File Offset: 0x000E1544
		private int method_0(GStruct49[] gstruct49_0, int int_1)
		{
			bool flag = gstruct49_0 != null;
			if (flag)
			{
				bool flag2 = gstruct49_0.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < gstruct49_0.Length; i++)
					{
						bool flag3 = int_1 == gstruct49_0[i].int_136;
						if (flag3)
						{
							return i;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000E33AC File Offset: 0x000E15AC
		public void method_1()
		{
			int int_ = this.int_0;
			int num = 1;
			int num2 = 255;
			long long_ = 0L;
			string[] array = new string[]
			{
				"chó",
				"thÝm"
			};
			GStruct60 gstruct = default(GStruct60);
			while (!Class12.bool_0)
			{
				Thread.Sleep(300);
				int num3 = this.method_0(Form1.gstruct49_0, int_);
				bool flag = num3 < 0;
				if (flag)
				{
					break;
				}
				GStruct49 gstruct2 = Form1.gstruct49_0[num3];
				bool flag2 = !gstruct2.bool_25;
				if (flag2)
				{
					break;
				}
				bool flag3 = gstruct.string_0 == null || gstruct.string_0 == "";
				if (!flag3)
				{
					string[] array2 = gstruct.string_0.Split(new char[]
					{
						','
					});
					bool flag4 = array2 == null || array2.Length == 0;
					if (!flag4)
					{
						int num4 = -1;
						for (int i = 0; i < array2.Length; i++)
						{
							bool flag5 = array2[i] == gstruct2.string_22 || array2[i] == Class10.smethod_1(gstruct2.string_22, 1, false);
							if (flag5)
							{
								num4 = i;
								break;
							}
						}
						bool flag6 = num4 < 0;
						if (!flag6)
						{
							gstruct.int_0 = (int)(Convert.ToByte(num4 == 0) + 3 * Convert.ToByte(num4 != 0));
							uint num5 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct2.int_137);
							uint num6 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct2.int_137);
							uint uint_ = Class22.smethod_30(num6 + Class53.gstruct51_167.uint_0, gstruct2.int_137);
							uint num7 = Class22.smethod_30(uint_, gstruct2.int_137);
							string text = Class22.smethod_28(num7, gstruct2.int_137, 60);
							GStruct59 gstruct3 = Class82.smethod_5(gstruct2);
							bool flag7 = Class82.smethod_4(gstruct2);
							bool flag8 = gstruct.int_0 == 1 && (array2 == null || array2.Length == 0);
							if (!flag8)
							{
								bool flag9 = gstruct.int_0 <= 1;
								if (flag9)
								{
									bool flag10 = flag7;
									if (flag10)
									{
										bool flag11 = !(gstruct3.string_0 != gstruct2.string_22);
										if (flag11)
										{
											bool flag12 = gstruct3.int_0 != 8;
											if (flag12)
											{
												bool flag13 = num >= num2;
												if (flag13)
												{
													num = 1;
												}
												int num8 = 0;
												for (int j = num; j < num2; j++)
												{
													num8++;
													uint num9 = (uint)(j * (int)Class53.gstruct51_15.uint_0);
													uint num10 = Class22.smethod_30(num5 + num9 + Class53.gstruct51_52.uint_0, gstruct2.int_137);
													bool flag14 = num10 != 1U || Class22.smethod_30(num5 + num9 + Class53.gstruct51_50.uint_0, gstruct2.int_137) == 0U;
													if (!flag14)
													{
														string text2 = Class22.smethod_28(num5 + num9 + Class53.gstruct51_16.uint_0, gstruct2.int_137, 32);
														bool flag15 = text2 == "" || text2 == gstruct2.string_22;
														if (!flag15)
														{
															bool bool_ = Class12.bool_0;
															if (bool_)
															{
																return;
															}
															Thread.Sleep(200);
															bool flag16 = false;
															string a = Class10.smethod_1(text2, 1, false);
															bool flag17 = gstruct3.int_0 > 0 && gstruct3.gstruct58_0 != null;
															if (flag17)
															{
																for (int k = 0; k < gstruct3.gstruct58_0.Length; k++)
																{
																	bool flag18 = gstruct3.gstruct58_0[k].string_0 != null && gstruct3.gstruct58_0[k].string_0 != "" && gstruct3.gstruct58_0[k].string_0 == text2;
																	if (flag18)
																	{
																		flag16 = true;
																		break;
																	}
																}
															}
															bool flag19 = flag16;
															if (!flag19)
															{
																bool flag20 = gstruct.int_0 == 1;
																if (flag20)
																{
																	flag16 = true;
																	bool flag21 = array2 != null && array2.Length != 0;
																	if (flag21)
																	{
																		for (int l = 0; l < array2.Length; l++)
																		{
																			bool flag22 = text2 == array2[l] || a == array2[l];
																			if (flag22)
																			{
																				flag16 = false;
																				break;
																			}
																		}
																	}
																}
																bool flag23 = !flag16;
																if (flag23)
																{
																	Class82.smethod_3(gstruct2, text2);
																	bool flag24 = Class12.smethod_28(long_) > 3000L;
																	if (flag24)
																	{
																		int num11 = (int)Convert.ToByte(Class98.smethod_10(gstruct2, j) > 0);
																		string str = string.Concat(new string[]
																		{
																			"<color=green>",
																			text2,
																			"<color=white> vµo pt ®i ",
																			array[num11],
																			" :B"
																		});
																		Class70.smethod_57(gstruct2, "Chat('CH_NEARBY', '" + str + "')");
																		long_ = Class12.smethod_27();
																	}
																	break;
																}
															}
														}
													}
												}
												num = ((num8 == 0) ? (num + 1) : (num + num8));
											}
										}
										else
										{
											Class82.smethod_2(gstruct2);
										}
									}
									else
									{
										Class82.smethod_1(gstruct2);
									}
								}
								else
								{
									bool flag25 = text == string.Empty;
									if (flag25)
									{
										continue;
									}
									bool flag26 = flag7;
									if (flag26)
									{
										bool flag27 = gstruct.int_0 == 2 || array2 == null || array2.Length == 0;
										if (flag27)
										{
											bool flag28 = gstruct3.string_0 != gstruct2.string_22;
											if (flag28)
											{
												goto IL_7ED;
											}
											Class82.smethod_2(gstruct2);
											flag7 = false;
											Thread.Sleep(450);
										}
										bool flag29 = gstruct3.gstruct58_0 != null;
										if (flag29)
										{
											for (int m = 0; m < gstruct3.gstruct58_0.Length; m++)
											{
												Thread.Sleep(100);
												string text3 = gstruct3.gstruct58_0[m].string_0;
												bool flag30 = text3 == null || text3 == "" || text3 == gstruct2.string_22;
												if (!flag30)
												{
													text3 = Class10.smethod_1(text3, 1, false);
													for (int n = 0; n < array2.Length; n++)
													{
														bool flag31 = !(text3 == array2[n]);
														if (!flag31)
														{
															goto IL_7ED;
														}
														Thread.Sleep(100);
													}
												}
											}
										}
									}
									bool flag32 = Class12.smethod_1(text, "mêi tæ ®éi") > 0;
									if (flag32)
									{
										string text4 = Class22.smethod_28(num7 + Class53.gstruct51_205.uint_0, gstruct2.int_137, 25);
										bool flag33 = !(text4 == string.Empty);
										if (flag33)
										{
											bool flag34 = !flag7 || gstruct.int_0 <= 2 || array2 == null || array2.Length == 0;
											if (!flag34)
											{
												text4 = Class10.smethod_1(text4, 1, false);
												for (int num12 = 0; num12 < array2.Length; num12++)
												{
													bool flag35 = !(text4 == array2[num12]);
													if (!flag35)
													{
														goto IL_73D;
													}
												}
												goto IL_736;
											}
											IL_73D:
											uint num13 = Class22.smethod_30(num7 + Class53.gstruct51_170.uint_0, gstruct2.int_137);
											bool flag36 = num13 != 0U && num13 < 2147483647U;
											if (flag36)
											{
												Class22.smethod_31(gstruct2.uint_54 + 2U, gstruct2.int_137, num13, 4);
												Class22.smethod_31(gstruct2.uint_54 + 7U, gstruct2.int_137, 1U, 1);
												Class70.smethod_12(gstruct2.int_137, gstruct2.uint_54);
												bool flag37 = Class12.smethod_28(long_) > 2500L;
												if (flag37)
												{
													Class70.smethod_57(gstruct2, "Chat('CH_NEARBY', 'C¸m ¬n thÝm ®· mêi !:0')");
													long_ = Class12.smethod_27();
												}
												Thread.Sleep(500);
												continue;
											}
										}
										IL_736:;
									}
								}
								IL_7ED:
								bool flag38 = text != string.Empty;
								if (flag38)
								{
									Class70.smethod_12(gstruct2.int_137, gstruct2.uint_55);
								}
								Thread.Sleep(300);
								continue;
								goto IL_7ED;
							}
						}
					}
				}
			}
		}

		// Token: 0x040003B4 RID: 948
		public int int_0 = 0;
	}
}
