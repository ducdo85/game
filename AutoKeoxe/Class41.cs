using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000025 RID: 37
	internal class Class41
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0005FA90 File Offset: 0x0005DC90
		static Class41()
		{
			uint[,] array_ = new uint[22, 2];
			Class11.smethod_4(array_, 184866);
			Class41.uint_0 = array_;
			uint[,] array_2 = new uint[26, 2];
			Class11.smethod_4(array_2, 185052);
			Class41.uint_1 = array_2;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0005FAE8 File Offset: 0x0005DCE8
		public static void smethod_0()
		{
			Class41.bool_0 = true;
			long long_ = Class12.smethod_27();
			while (!Class12.bool_0 && Class41.int_0 != null)
			{
				bool flag = Class41.int_0 != null && (Class41.int_1 == 0 || Class12.smethod_28(long_) > 3000L);
				if (flag)
				{
					Class41.int_1 = Class41.int_0[0];
					Class12.smethod_38(ref Class41.int_0, Class41.int_1);
					new Thread(new ThreadStart(Class41.smethod_1)).Start();
					Thread.Sleep(150);
					long_ = Class12.smethod_27();
				}
				Thread.Sleep(300);
			}
			Class41.bool_0 = false;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0005FB9C File Offset: 0x0005DD9C
		public static void smethod_1()
		{
			int int_ = Class41.int_1;
			Class41.int_1 = 0;
			for (;;)
			{
				try
				{
					Class41.smethod_2(int_);
					break;
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0005FBE0 File Offset: 0x0005DDE0
		private static void smethod_2(int int_2)
		{
			uint[,] array = new uint[3, 4];
			Class11.smethod_4(array, 184001);
			uint[,] array2 = array;
			string string_ = "ThuyÒn phu";
			string text = "MËt ®å thÇn bÝ";
			bool flag = false;
			int num = 0;
			int num2 = 0;
			GStruct49 gstruct = default(GStruct49);
			bool flag2 = false;
			long long_ = 0L;
			long long_2 = 0L;
			for (;;)
			{
				IL_9FE:
				Thread.Sleep(100);
				int num3 = Class81.smethod_3(Form1.gstruct49_0, int_2);
				bool flag3 = Class12.bool_0 || num3 < 0 || !Form1.gstruct49_0[num3].bool_25;
				if (flag3)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num3];
				bool flag4 = flag2;
				if (flag4)
				{
					bool flag5 = !gstruct.bool_15;
					if (flag5)
					{
						break;
					}
				}
				else
				{
					bool bool_ = gstruct.bool_15;
					if (bool_)
					{
						break;
					}
					flag2 = true;
					Form1.gstruct49_0[num3].bool_15 = true;
					Class70.smethod_52(gstruct, "<bclr=blue><color=green>Lªn thuyÒn PL§: Tù ®éng nép lÖnh bµi PL§, lÖnh bµi Thuû tÆc, hoÆc MËt ®å ThÇn bÝ.", 1);
				}
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct.int_137) * Class53.gstruct51_15.uint_0;
				uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num7 = num6 + num5;
				int num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num10 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
				string string_2 = Class22.smethod_28(gstruct.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct.int_137, 60);
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
					Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
				};
				bool flag6 = array3[0] == 0U || array3[1] == 0U;
				if (!flag6)
				{
					int num11 = Class83.smethod_39(gstruct);
					bool flag7 = num9 != 0 && num8 != 0 && num8 != 10 && num8 != 21 && num10 != 0 && array3[0] > 0U && array3[1] > 0U && num11 > 1;
					if (flag7)
					{
						bool flag8 = num10 == 337 || num10 == 338 || num10 == 339 || Class12.smethod_1(string_2, "BÕn thuyÒn") == 0;
						if (flag8)
						{
							break;
						}
						bool flag9 = num10 != 336;
						if (flag9)
						{
							bool flag10 = !Class35.smethod_140(gstruct, 336, null, null, false);
							if (flag10)
							{
								break;
							}
							Thread.Sleep(300);
						}
						else
						{
							uint[] uint_ = new uint[]
							{
								array2[Form1.int_104, 0],
								array2[Form1.int_104, 1]
							};
							uint[] array4 = new uint[]
							{
								array2[Form1.int_104, 2],
								array2[Form1.int_104, 3]
							};
							long num12 = Class60.smethod_18(array3, uint_);
							long num13 = Class60.smethod_18(array3, array4);
							uint num14 = 90000U;
							bool flag11 = num12 <= (long)((ulong)num14) || num13 <= (long)((ulong)num14);
							if (flag11)
							{
								Class14.smethod_2(gstruct, false);
								bool flag12 = num12 > (long)((ulong)num14);
								if (flag12)
								{
									Class70.smethod_61(gstruct, uint_);
									Thread.Sleep(300);
								}
								uint[] uint_2 = null;
								bool flag13 = num2 <= 0 || Class12.smethod_28(long_) > 3000L;
								if (flag13)
								{
									num2 = Class98.smethod_15(gstruct, string_, ref uint_2, 3, false, -1, null);
									bool flag14 = num2 <= 0;
									if (flag14)
									{
										goto IL_9D6;
									}
									long_ = Class12.smethod_27();
								}
								array3 = new uint[]
								{
									Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num7 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								num12 = Class60.smethod_18(array3, uint_2);
								bool flag15 = num12 > 10500L;
								if (flag15)
								{
									Class70.smethod_61(gstruct, uint_2);
									Thread.Sleep(300);
								}
								Class86.smethod_8(gstruct, -1);
								Class86.Class88.smethod_2(gstruct, null);
								int i = 0;
								byte[] bytes = BitConverter.GetBytes(num2);
								Class22.WriteProcessMemory(gstruct.int_137, num7 + Class53.gstruct51_72.uint_0, bytes, bytes.Length, ref i);
								i = 0;
								while (Class86.smethod_0(gstruct) < 0 && i < 100)
								{
									Thread.Sleep(10);
									i++;
								}
								int num15 = Class86.smethod_1(gstruct, -1);
								int num16 = num15;
								int num17 = num16;
								if (num17 != 0)
								{
									if (num17 != 1)
									{
										bool flag16 = !flag;
										if (flag16)
										{
											string text2 = "tham gia ho¹t ®éng|hËn nhiÖm vô Tiªu diÖt|bµi häc ®Ých ®¸ng";
											bool flag17 = !(flag = (Class86.smethod_6(gstruct, text2 + "|KÕt thóc", false, false, false, false) > 0));
											if (flag17)
											{
												string[] array5 = text2.Split(new char[]
												{
													'|'
												});
												for (int j = 0; j < num15; j++)
												{
													string string_3 = Class86.smethod_3(gstruct, j, -1, 128);
													for (int k = 0; k < array5.Length; k++)
													{
														bool flag18 = 0 > Class12.smethod_1(string_3, array5[k]);
														if (!flag18)
														{
															Thread.Sleep(100);
															goto IL_9FE;
														}
													}
												}
											}
											Thread.Sleep(300);
											flag = true;
										}
										string[] array6 = new string[]
										{
											"Lªn thuyÒn",
											"cã lÖnh bµi",
											"nép lÖnh bµi",
											"ng lÖnh bµi"
										};
										int num18 = Class79.smethod_31(gstruct, text, 3, true, false);
										bool flag19 = num18 > 199;
										if (flag19)
										{
											array6 = new string[]
											{
												"Lªn thuyÒn",
												"200",
												"cã lÖnh bµi",
												"nép lÖnh bµi",
												"ng lÖnh bµi"
											};
										}
										bool flag20 = false;
										bool flag21 = false;
										bool flag22 = false;
										int num19 = 0;
										for (;;)
										{
											IL_659:
											i = 0;
											while (i < 10 && Class86.smethod_0(gstruct) < 0)
											{
												i++;
												Thread.Sleep(30);
											}
											int num20 = Class86.smethod_1(gstruct, -1);
											bool flag23 = num20 == 0 || array6 == null || array6.Length == 0;
											if (flag23)
											{
												break;
											}
											for (int l = 0; l < array6.Length; l++)
											{
												bool flag24 = array6[l] == null || array6[l] == string.Empty;
												if (!flag24)
												{
													string text3 = array6[l].ToLower();
													int m = 0;
													while (m < num20)
													{
														string text4 = Class86.smethod_3(gstruct, m, -1, 128);
														string text5 = text4.ToLower();
														bool flag25 = text5.IndexOf(text3) < 0;
														if (flag25)
														{
															m++;
														}
														else
														{
															bool flag26 = !flag22;
															if (flag26)
															{
																flag22 = (text3 == "200");
															}
															bool flag27 = !flag21;
															if (flag27)
															{
																flag21 = (0 <= text5.IndexOf("Thñy TÆc".ToLower()));
															}
															array6[l] = null;
															Class86.smethod_5(gstruct, m);
															i = 0;
															while (i < 100)
															{
																i++;
																Thread.Sleep(10);
																bool flag28 = Class86.smethod_0(gstruct) < 0;
																if (flag28)
																{
																	break;
																}
																string text6 = Class86.smethod_3(gstruct, m, -1, 128);
																bool flag29 = text6 != null && text6 != string.Empty && text6 != text4;
																if (flag29)
																{
																	break;
																}
															}
															flag20 = true;
															Thread.Sleep(10 + Class86.int_0);
															if (Class45.smethod_8(gstruct))
															{
																goto IL_824;
															}
															goto IL_659;
														}
													}
												}
											}
											break;
										}
										IL_824:
										for (;;)
										{
											bool flag30 = flag20;
											if (!flag30)
											{
												goto IL_932;
											}
											bool flag31 = !Class45.smethod_8(gstruct);
											if (flag31)
											{
												break;
											}
											uint num21 = 3U;
											uint num22 = 12U;
											string string_4 = "LÖnh bµi Phong L¨ng §é";
											bool flag32 = !flag22;
											if (flag32)
											{
												bool flag33 = flag21;
												if (flag33)
												{
													string_4 = "LÖnh Bµi Thñy TÆc";
												}
											}
											else
											{
												string_4 = text;
											}
											Class45.smethod_16(gstruct, num21, num22, string_4, 1, false, false, !flag22);
											bool flag34 = flag22;
											if (!flag34)
											{
												goto IL_8D2;
											}
											num18 = Class79.smethod_31(gstruct, text, (int)num22, true, false);
											bool flag35 = num18 < 200;
											if (!flag35)
											{
												goto IL_8D1;
											}
											num19++;
											bool flag36 = num19 < 20;
											if (!flag36)
											{
												goto IL_8D0;
											}
										}
										continue;
										IL_932:
										Thread.Sleep(300);
										Class86.smethod_8(gstruct, -1);
										bool flag37 = Class45.smethod_8(gstruct);
										if (flag37)
										{
											Class45.smethod_11(gstruct);
										}
										continue;
										IL_8D2:
										Class45.smethod_13(gstruct, true);
										Thread.Sleep(100);
										i = 0;
										while (i < 10)
										{
											int num23 = Class86.smethod_0(gstruct);
											bool flag38 = 0 > num23;
											if (!flag38)
											{
												Class86.smethod_5(gstruct, Class86.smethod_1(gstruct, num23) - 1);
												break;
											}
											i++;
											Thread.Sleep(30);
										}
										continue;
										IL_8D1:
										goto IL_8D2;
										continue;
										IL_8D0:
										goto IL_8D1;
										goto IL_824;
									}
									Class86.smethod_5(gstruct, 0);
									Thread.Sleep(10 + Class86.int_0);
									continue;
								}
								IL_9D6:
								Thread.Sleep(300);
								num++;
								bool flag39 = num > 15;
								if (flag39)
								{
									Class60.smethod_12(gstruct, true);
								}
							}
							else
							{
								bool flag40 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_2) > 4000L;
								if (flag40)
								{
									Class14.smethod_1(gstruct, array4);
									long_2 = Class12.smethod_27();
								}
							}
						}
					}
					else
					{
						Thread.Sleep(300);
					}
				}
			}
			bool flag41 = flag2;
			if (flag41)
			{
				Class86.smethod_8(gstruct, -1);
				Class70.smethod_52(gstruct, "<bclr=blue><color=green>KÕt thóc lªn thuyÒn Phong L¨ng ®é!", 1);
				int num24 = Class81.smethod_3(Form1.gstruct49_0, int_2);
				bool flag42 = 0 <= num24;
				if (flag42)
				{
					Form1.gstruct49_0[num24].bool_15 = false;
				}
			}
		}

		// Token: 0x04000155 RID: 341
		public static int[] int_0 = null;

		// Token: 0x04000156 RID: 342
		public static bool bool_0 = false;

		// Token: 0x04000157 RID: 343
		private static int int_1 = 0;

		// Token: 0x04000158 RID: 344
		public static uint[,] uint_0;

		// Token: 0x04000159 RID: 345
		public static uint[,] uint_1;
	}
}
