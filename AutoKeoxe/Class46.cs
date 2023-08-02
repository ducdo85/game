using System;
using System.Diagnostics;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200002A RID: 42
	internal class Class46
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x00074D0C File Offset: 0x00072F0C
		private static void smethod_0()
		{
			Process[] processesByName = Process.GetProcessesByName("WerFault");
			bool flag = processesByName != null && processesByName.Length != 0;
			if (flag)
			{
				for (int i = 0; i < processesByName.Length; i++)
				{
					Class22.smethod_53(processesByName[i]);
				}
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00074D54 File Offset: 0x00072F54
		private static void smethod_1()
		{
			string text = Class62.smethod_6(Class53.string_4, 0, "");
			bool flag = text == null || text == string.Empty;
			if (!flag)
			{
				Class62.smethod_10(Class53.string_3, Class53.string_4, "", "", 0);
				string[] array = text.Split(new char[]
				{
					'|'
				});
				bool flag2 = false;
				for (int i = 0; i < array.Length; i++)
				{
					int num = Class12.smethod_11(array[i]);
					bool flag3 = num > 0;
					if (flag3)
					{
						flag2 = true;
						Class12.smethod_37(ref ThemXoaDanhsach.int_0, num);
					}
				}
				bool flag4 = flag2;
				if (flag4)
				{
					Form1.string_21 = null;
					Form1.int_130 = 0;
					Form1.bool_12 = true;
				}
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00074E18 File Offset: 0x00073018
		public static void smethod_2()
		{
			for (;;)
			{
				bool flag = !Class53.bool_1;
				if (!flag)
				{
					goto IL_2A;
				}
				bool flag2 = !Class12.bool_0;
				if (!flag2)
				{
					break;
				}
				Thread.Sleep(100);
			}
			return;
			IL_2A:
			Class20.smethod_2();
			Class20.smethod_3();
			for (;;)
			{
				try
				{
					Class46.smethod_3();
					break;
				}
				catch
				{
				}
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00074E88 File Offset: 0x00073088
		private static void smethod_3()
		{
			int num = -1;
			int num2 = 0;
			Process process = null;
			uint num3 = 0U;
			int num4 = 0;
			int num5 = 0;
			string string_ = string.Empty;
			int num6 = 200;
			long long_ = 0L;
			long long_2 = 0L;
			for (;;)
			{
				Thread.Sleep(450);
				bool flag = Class12.bool_0;
				if (flag)
				{
					break;
				}
				bool flag2 = Class12.smethod_28(long_) > 60000L;
				if (flag2)
				{
					Class46.smethod_0();
					long_ = Class12.smethod_27();
				}
				bool flag3 = Class12.smethod_28(long_2) > 6000L;
				if (flag3)
				{
					Class46.smethod_1();
					long_2 = Class12.smethod_27();
				}
				Class46.int_2 = -1;
				bool flag4 = Class46.bool_0;
				if (flag4)
				{
					bool flag5 = Class46.int_0 != null;
					if (flag5)
					{
						Class97.smethod_0("Login dừng lại bởi người dùng.");
						Class46.int_0 = null;
					}
					process = null;
					Class46.bool_0 = false;
					Class46.int_2 = 0;
					num = -1;
				}
				bool flag6 = 0 <= num;
				if (!flag6)
				{
					bool flag7 = Class46.bool_1 || Class46.int_0 == null || Class46.int_0.Length == 0;
					if (flag7)
					{
						continue;
					}
					bool flag8 = !Form1.bool_1 && (Form1.bool_0 || GClass1.bool_1 || GClass1.string_1 == null || GClass1.string_1 == string.Empty || Form1.int_3 > Form1.int_2);
					if (flag8)
					{
						Class46.int_0 = null;
						continue;
					}
					num = Class46.int_0[0];
					bool flag9 = num >= 0 && FormLogin.gstruct0_0.Length > num;
					if (flag9)
					{
						GStruct0 gstruct = FormLogin.gstruct0_0[num];
						bool flag10 = gstruct.int_1 > 0 && !Class22.smethod_52(gstruct.process_0);
						if (flag10)
						{
							uint num7 = Class22.smethod_30(Class9.uint_0, gstruct.int_2);
							uint num8 = Class22.smethod_30(num7 + Class9.uint_2, gstruct.int_2) * Class9.uint_4;
							uint num9 = Class22.smethod_30(Class9.uint_3, gstruct.int_2);
							uint num10 = num9 + num8;
							int num11 = Class49.smethod_31(gstruct);
							bool flag11 = num11 > 1;
							if (flag11)
							{
								string text = Class22.smethod_28(num10 + Class9.uint_5, gstruct.int_2, 40);
								bool flag12 = text != null && text.Length > 5;
								if (flag12)
								{
									goto IL_D87;
								}
							}
							Class22.smethod_48(gstruct.int_1);
						}
						bool flag13 = Class46.bool_2 && Class76.int_4 > 0;
						if (flag13)
						{
							int[] array = Class22.smethod_24(Class53.string_21, null, false);
							bool flag14 = array != null && Class76.int_4 <= array.Length;
							if (flag14)
							{
								goto IL_D87;
							}
						}
						string text2 = Class12.smethod_15(FormLogin.gstruct0_0[num].string_1);
						bool flag15 = text2 != null && !(text2 == string.Empty) && (int)text2[0] <= text2.Length - 1;
						if (flag15)
						{
							string_ = text2.Substring(1, (int)text2[0]);
							num2 = 0;
							num4 = -1;
							num5 = -1;
							string string_2 = FormLogin.gstruct0_0[num].string_2;
							string string_3 = FormLogin.gstruct0_0[num].string_3;
							string text3 = Class10.smethod_1(FormLogin.gstruct0_0[num].string_4, 1, false);
							bool flag16 = text3 == string.Empty;
							if (flag16)
							{
								text3 = FormLogin.gstruct0_0[num].string_0;
							}
							Class97.smethod_0("Đang đăng nhập <" + text3 + "> đợi chút xíu...");
							for (int i = 0; i < FormLogin.string_4.Length; i++)
							{
								string[] array2 = FormLogin.string_4[i].Split(new char[]
								{
									'|'
								});
								bool flag17 = array2[0] != string_2;
								if (!flag17)
								{
									num5 = i;
									for (int j = 1; j < array2.Length; j++)
									{
										bool flag18 = !(array2[j] == string_3);
										if (!flag18)
										{
											num4 = j - 1;
											goto IL_42B;
										}
									}
								}
							}
							Class97.smethod_0("Lỗi dữ liệu không đúng Phân đà và Server, không thể login.");
						}
					}
					goto IL_D87;
				}
				IL_42B:
				FormLogin.gstruct0_0[num].int_1 = 0;
				FormLogin.gstruct0_0[num].int_2 = 0;
				FormLogin.gstruct0_0[num].uint_0 = 0U;
				FormLogin.gstruct0_0[num].uint_1 = 0U;
				FormLogin.gstruct0_0[num].uint_2 = 0U;
				FormLogin.gstruct0_0[num].uint_3 = 0U;
				FormLogin.gstruct0_0[num].int_0 = 0;
				num3 = 0U;
				Process process2 = null;
				try
				{
					process2 = ((FormLogin.int_10 <= 0) ? Class97.smethod_6() : Class97.smethod_3());
				}
				catch
				{
				}
				bool flag19 = !Class22.smethod_52(process);
				if (flag19)
				{
					Class22.smethod_53(process);
					Thread.Sleep(100);
				}
				process = process2;
				bool flag20 = process != null;
				if (flag20)
				{
					int num12 = 0;
					int num13 = 0;
					for (;;)
					{
						bool flag21 = false;
						bool flag22 = num12 == 0;
						GStruct8[] array3;
						if (flag22)
						{
							array3 = Class22.smethod_62(process.Id, "WIN_CLASS:#32770|CTR_CLASS:Button", 0);
							bool flag23 = array3 != null && array3.Length != 0 && array3[0].gstruct7_0 != null;
							if (flag23)
							{
								for (int k = 0; k < array3[0].gstruct7_0.Length; k++)
								{
									bool flag24 = array3[0].gstruct7_0[k].int_0 == 1;
									if (flag24)
									{
										Class22.smethod_4(array3[0].gstruct7_0[k].uint_0, 32U);
										Thread.Sleep(300);
										flag21 = true;
										break;
									}
								}
							}
							num12 = 1;
							bool flag25 = flag21;
							if (flag25)
							{
								Class46.smethod_0();
								continue;
							}
						}
						bool flag26 = num13 != 0;
						if (flag26)
						{
							break;
						}
						array3 = Class22.smethod_62(process.Id, "CTR_INSTANCE:1", 0);
						bool flag27 = array3 != null && array3.Length != 0;
						if (flag27)
						{
							for (int j = 0; j < array3.Length; j++)
							{
								bool flag28 = array3[j].gstruct7_0 == null;
								if (!flag28)
								{
									for (int l = 0; l < array3[j].gstruct7_0.Length; l++)
									{
										bool flag29 = array3[j].gstruct7_0[l].int_0 == 1;
										if (flag29)
										{
											Class22.smethod_4(array3[j].gstruct7_0[l].uint_0, 32U);
											Thread.Sleep(300);
											flag21 = true;
										}
									}
								}
							}
						}
						num13 = 1;
						bool flag30 = !flag21;
						if (flag30)
						{
							break;
						}
						Class46.smethod_0();
					}
					IL_6F3:
					int num14 = 0;
					int id = process.Id;
					while (num3 == 0U)
					{
						try
						{
							num3 = (uint)((int)process.MainModule.BaseAddress);
						}
						catch
						{
						}
						num14++;
						bool flag31 = num14 <= 10;
						if (!flag31)
						{
							goto IL_D60;
						}
						Thread.Sleep(300);
					}
					uint num15 = 0U;
					GStruct8[] array4 = Class22.smethod_62(id, "WIN_CLASS:" + Class53.string_21, 0);
					bool flag32 = array4 != null && array4.Length != 0;
					if (flag32)
					{
						num15 = array4[0].uint_0;
					}
					FormLogin.gstruct0_0[num].int_1 = id;
					FormLogin.gstruct0_0[num].int_2 = Class22.OpenProcess(2035711, false, id);
					FormLogin.gstruct0_0[num].process_0 = process;
					FormLogin.gstruct0_0[num].uint_0 = num15;
					FormLogin.gstruct0_0[num].uint_1 = num3;
					bool flag33 = Class49.smethod_2(ref FormLogin.gstruct0_0[num]) >= 0;
					if (flag33)
					{
						GStruct0 gstruct2 = FormLogin.gstruct0_0[num];
						bool flag34 = Class49.smethod_15(gstruct2);
						if (flag34)
						{
							Thread.Sleep(100 + num6);
							bool flag35 = Class49.smethod_16(gstruct2);
							if (flag35)
							{
								Thread.Sleep(100 + num6);
								bool flag36 = Class49.smethod_17(gstruct2, num5);
								if (flag36)
								{
									Thread.Sleep(200 + num6);
									bool flag37 = Class49.smethod_18(gstruct2, num4);
									if (flag37)
									{
										Thread.Sleep(200 + num6);
										bool flag38 = Class49.smethod_19(gstruct2);
										if (flag38)
										{
											Thread.Sleep(200 + num6);
											bool flag39 = Class49.smethod_20(gstruct2, gstruct2.string_0);
											if (flag39)
											{
												Thread.Sleep(100);
												bool flag40 = Class49.smethod_21(gstruct2, string_);
												if (flag40)
												{
													Thread.Sleep(100);
													bool flag41 = Class49.smethod_22(gstruct2);
													if (flag41)
													{
														uint num16 = 2699940U;
														uint num17 = 4880U;
														uint num18 = 472U;
														int num19 = (int)(6 + Convert.ToByte(FormLogin.int_4 <= 0) * 14);
														int m = 0;
														string a = string.Empty;
														while (m < num19)
														{
															bool flag42 = !(a == string.Empty);
															if (flag42)
															{
																break;
															}
															uint num20 = Class22.smethod_30(gstruct2.uint_1 + num16, gstruct2.int_2);
															a = Class22.smethod_28(num20 + num17 + num18, gstruct2.int_2, 40);
															Thread.Sleep(100);
															m++;
														}
														Thread.Sleep(600 + num6);
														bool flag43 = Class49.smethod_23(gstruct2, gstruct2.int_4 - 1);
														if (flag43)
														{
															Thread.Sleep(200 + num6);
															string text4 = string.Empty;
															bool flag44 = false;
															num14 = 0;
															long long_3 = Class12.smethod_27();
															string text5;
															for (;;)
															{
																bool flag45 = Class12.bool_0;
																if (flag45)
																{
																	goto Block_65;
																}
																bool flag46 = Class46.bool_0;
																if (flag46)
																{
																	break;
																}
																bool flag47 = num14 % 60 != 0 || Class49.smethod_24(gstruct2) || num14 != 0;
																if (!flag47)
																{
																	goto IL_BC0;
																}
																Thread.Sleep(100);
																text5 = Class49.smethod_25(gstruct2);
																bool flag48 = 0 > text5.IndexOf("Xin nhËp vµo Tµi") && 0 > text5.IndexOf("KÕt nèi m¸y chñ th") && 0 > text5.IndexOf("HÖ thèng ®ang bËn");
																if (!flag48)
																{
																	goto IL_BB0;
																}
																bool flag49 = 0 <= text5.IndexOf("Xin h·y n¹p tµi kho¶n") || 0 <= text5.IndexOf("Tµi kho¶n nµy ®· bÞ khãa") || 0 <= text5.IndexOf("Tµi kho¶n nµy hiÖn ®ang") || 0 <= text5.IndexOf("Tµi kho¶n hoÆc MËt khÈu");
																if (flag49)
																{
																	goto Block_76;
																}
																int num11 = Class49.smethod_31(gstruct2);
																bool flag50 = num11 > 1;
																if (flag50)
																{
																	uint num21 = Class22.smethod_30(Class9.uint_0, gstruct2.int_2);
																	uint num22 = Class22.smethod_30(num21 + Class9.uint_2, gstruct2.int_2) * Class9.uint_4;
																	uint num23 = Class22.smethod_30(Class9.uint_3, gstruct2.int_2);
																	uint num24 = num23 + num22;
																	text4 = Class22.smethod_28(num24 + Class9.uint_5, gstruct2.int_2, 40);
																	bool flag51 = text4 != null && text4 != string.Empty && text4.Length > 5;
																	if (flag51)
																	{
																		goto Block_80;
																	}
																}
																long num25 = Class12.smethod_28(long_3);
																bool flag52 = num25 <= (long)FormLogin.int_7;
																if (!flag52)
																{
																	goto IL_BA2;
																}
																Class46.int_2 = (int)((long)FormLogin.int_7 - num25);
																num14++;
															}
															continue;
															IL_BC0:
															goto IL_D60;
															IL_BBF:
															goto IL_BC0;
															IL_BB0:
															Class97.smethod_0(Class10.smethod_1(text5, 1, false));
															goto IL_BBF;
															IL_BA2:
															Class97.smethod_0("Không thể đăng nhập, đang thử lại...");
															goto IL_BBF;
															IL_BC5:
															string string_4 = "[" + Class10.smethod_1(text4, 1, false) + "] Đã đăng nhập...";
															Class12.smethod_29(ref Class12.string_16, string_4);
															bool flag53 = FormLogin.bool_0;
															if (flag53)
															{
																Class12.smethod_29(ref FormLogin.string_0, string_4);
															}
															FormLogin.gstruct0_0[num].string_4 = text4;
															FormLogin.gstruct0_0[num].int_0 = 1;
															bool flag54 = flag44 && text4 != FormLogin.gstruct0_0[num].string_4;
															if (flag54)
															{
																Class20.smethod_1();
															}
															bool flag55 = FormLogin.int_8 > 0;
															if (flag55)
															{
																Class22.ShowWindow(num15, Class22.int_20);
															}
															num14 = 0;
															while (!Class12.bool_0 && Class46.int_3 > 0 && num14 < 15)
															{
																num14++;
																Thread.Sleep(100);
															}
															Class46.int_3 = id;
															new Thread(new ThreadStart(Class46.smethod_4)).Start();
															goto IL_D87;
															Block_65:
															goto IL_BC5;
															Block_76:
															Class97.smethod_0(Class10.smethod_1(text5, 1, false));
															goto IL_CC3;
															Block_80:
															flag44 = true;
															goto IL_BC5;
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
					else
					{
						FormLogin.gstruct0_0[num].int_1 = 0;
						FormLogin.gstruct0_0[num].process_0 = null;
					}
					goto IL_CB2;
					goto IL_6F3;
				}
				IL_D60:
				Class46.int_2 = 0;
				num2++;
				bool flag56 = num2 < 3;
				if (flag56)
				{
					continue;
				}
				Class97.smethod_0("Không thể login !");
				goto IL_CC3;
				IL_CB2:
				goto IL_D60;
				IL_CC3:
				Class22.smethod_53(process);
				bool flag57 = FormLogin.gstruct0_0 != null && 0 <= num && num < FormLogin.gstruct0_0.Length;
				if (flag57)
				{
					FormLogin.gstruct0_0[num].int_1 = 0;
					FormLogin.gstruct0_0[num].process_0 = null;
				}
				IL_D87:
				Class12.smethod_38(ref Class46.int_0, num);
				bool flag58 = FormLogin.bool_0;
				if (flag58)
				{
					Class12.smethod_37(ref Class46.int_1, num);
				}
				process = null;
				num = -1;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00075C6C File Offset: 0x00073E6C
		private static void smethod_4()
		{
			int num = 0;
			while (!Class12.bool_0 && Class46.int_3 > 0 && num < 20)
			{
				Thread.Sleep(100);
				num++;
			}
			bool flag = Class46.int_3 > 0;
			if (flag)
			{
				Form1.string_21 = null;
				Class12.smethod_37(ref ThemXoaDanhsach.int_0, Class46.int_3);
			}
			Class46.int_3 = 0;
			Form1.int_130 = 0;
			Form1.bool_12 = true;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00075CE0 File Offset: 0x00073EE0
		public static string smethod_5()
		{
			int num = 0;
			int[] array = Class22.smethod_24(Class53.string_21, null, false);
			bool flag = array != null;
			if (flag)
			{
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						GStruct8[] array2 = Class22.smethod_62(array[i], "WIN_CLASS:Sword3 Class", 0);
						bool flag2 = array2 == null || array2.Length == 0;
						if (flag2)
						{
							Class22.smethod_48(array[i]);
							Thread.Sleep(100);
							num++;
						}
					}
					catch
					{
					}
				}
			}
			bool flag3 = !(Class53.string_19 == string.Empty) && Class53.string_19 != null;
			if (flag3)
			{
				string processName = Class53.string_19;
				bool flag4 = Class12.smethod_1(Class53.string_19.ToUpper(), ".EXE") > 0;
				if (flag4)
				{
					string[] array3 = Class12.smethod_14(Class53.string_19, '.');
					processName = array3[0];
				}
				Process[] processesByName = Process.GetProcessesByName(processName);
				bool flag5 = processesByName == null || processesByName.Length == 0;
				if (flag5)
				{
					processesByName = Process.GetProcessesByName(Class53.string_19 + "\u00a0");
					bool flag6 = processesByName == null || processesByName.Length == 0;
					if (flag6)
					{
						goto IL_189;
					}
				}
				for (int j = 0; j < processesByName.Length; j++)
				{
					try
					{
						GStruct8[] array4 = Class22.smethod_62(processesByName[j].Id, "WIN_CLASS:Sword3 Class", 0);
						bool flag7 = array4 == null || array4.Length == 0;
						if (flag7)
						{
							Class22.smethod_48(processesByName[j].Id);
							num++;
						}
					}
					catch
					{
					}
				}
			}
			IL_189:
			string empty = string.Empty;
			bool flag8 = num != 0;
			string result;
			if (flag8)
			{
				result = "Đã thoát " + num.ToString() + " game hư đang chạy ngầm.";
			}
			else
			{
				result = "Không tìm thấy game hư chạy ngầm nào.";
			}
			return result;
		}

		// Token: 0x0400016C RID: 364
		public static int[] int_0;

		// Token: 0x0400016D RID: 365
		public static int[] int_1;

		// Token: 0x0400016E RID: 366
		public static bool bool_0;

		// Token: 0x0400016F RID: 367
		public static int int_2;

		// Token: 0x04000170 RID: 368
		public static bool bool_1;

		// Token: 0x04000171 RID: 369
		public static bool bool_2;

		// Token: 0x04000172 RID: 370
		private static int int_3;
	}
}
