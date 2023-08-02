using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000049 RID: 73
	internal class Class75
	{
		// Token: 0x06000478 RID: 1144 RVA: 0x000C51C4 File Offset: 0x000C33C4
		public static void smethod_0()
		{
			for (;;)
			{
				Thread.Sleep(300);
				bool bool_ = Class12.bool_0;
				if (bool_)
				{
					break;
				}
				bool flag = Form1.bool_2 && !Form1.bool_0 && Form1.int_3 <= Form1.int_2 && Class12.int_1 > 0 && Class12.uint_1 != 0U && Class75.int_1 != null && Class75.int_2 <= 0 && Class75.int_3 <= 0 && Class93.int_0 <= 0 && Class51.int_0 <= 0 && Class59.int_0 <= 0 && Class58.int_1 <= 0 && Class103.int_0 <= 0 && Class103.int_1 <= 0 && Class32.int_2 <= 0 && Class32.int_0 <= 0 && Class32.int_1 <= 0 && Class32.int_3 <= 0 && Class90.int_2 <= 0;
				if (flag)
				{
					try
					{
						int num = Class75.int_1[0];
						Class12.smethod_38(ref Class75.int_1, num);
						Class75.int_2 = num;
						Class75.int_3 = num;
						Class59.int_0 = num;
						Class58.int_1 = num;
						Class103.int_0 = num;
						Class103.int_1 = num;
						Class93.int_0 = num;
						Class32.int_1 = num;
						Class32.int_0 = num;
						Class32.int_2 = num;
						Class32.int_3 = num;
						Class51.int_0 = num;
						Class90.int_2 = num;
						new Thread(new ThreadStart(Class75.smethod_2)).Start();
						new Thread(new ThreadStart(Class75.smethod_1)).Start();
						new Thread(new ThreadStart(Class93.smethod_0)).Start();
						new Thread(new ThreadStart(Class51.smethod_0)).Start();
						new Thread(new ThreadStart(Class59.smethod_0)).Start();
						new Thread(new ThreadStart(Class58.smethod_1)).Start();
						new Thread(new ThreadStart(Class103.smethod_0)).Start();
						new Thread(new ThreadStart(Class103.smethod_2)).Start();
						new Thread(new ThreadStart(Class32.smethod_13)).Start();
						new Thread(new ThreadStart(Class32.smethod_3)).Start();
						new Thread(new ThreadStart(Class32.smethod_1)).Start();
						new Thread(new ThreadStart(Class32.smethod_15)).Start();
						new Thread(new ThreadStart(Class90.smethod_2)).Start();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000C545C File Offset: 0x000C365C
		private static void smethod_1()
		{
			int num = Class75.int_3;
			Class75.int_3 = 0;
			GStruct49 gstruct = default(GStruct49);
			bool flag = false;
			int num2 = 0;
			for (;;)
			{
				try
				{
					int num3 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag2 = Class12.bool_0 || num3 < 0 || !Form1.gstruct49_0[num3].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num3;
						if (flag3)
						{
							Form1.gstruct49_0[num3].bool_28 = false;
						}
						break;
					}
					bool flag4 = num2 > 0;
					if (flag4)
					{
						Class53.smethod_13(Form1.gstruct49_0[num3], null);
						num2 = 0;
					}
					bool flag5 = !flag;
					if (flag5)
					{
						bool bool_ = Form1.gstruct49_0[num3].bool_28;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num3].bool_28 = true;
						flag = true;
					}
					Form1.gstruct49_0[num3].gstruct47_0.int_0 = 0;
					gstruct = Form1.gstruct49_0[num3];
					bool flag6 = !gstruct.bool_2;
					if (flag6)
					{
						bool flag7 = Form1.int_65 == 0;
						if (flag7)
						{
							Class70.smethod_52(gstruct, "-------------------------------------------", 1);
							Class70.smethod_52(gstruct, "<color=yellow>" + Form1.string_1.ToUpper() + " FOR PRIVATE GAME", 1);
						}
						bool flag8 = gstruct.int_20[0] <= 0 || Form1.int_65 != 0;
						if (flag8)
						{
							bool flag9 = gstruct.int_133[0] <= 0;
							if (flag9)
							{
								bool flag10 = !gstruct.bool_54;
								if (flag10)
								{
									bool bool_2 = gstruct.bool_55;
									if (bool_2)
									{
										bool flag11 = Form1.int_65 == 0;
										if (flag11)
										{
											Class70.smethod_52(gstruct, "<bclr=blue><color=green>LEN VI SON DAO", 1);
										}
										Class85.smethod_0(num);
									}
									else
									{
										bool flag12 = gstruct.int_25 <= 0;
										if (flag12)
										{
											bool flag13 = Form1.int_20 != 0;
											if (flag13)
											{
												bool flag14 = Form1.int_20 != 1;
												if (flag14)
												{
													bool flag15 = Form1.int_20 == 2;
													if (flag15)
													{
														bool flag16 = Form1.int_65 == 0;
														if (flag16)
														{
															Class70.smethod_52(gstruct, "<bclr=blue><color=green>CHIEN TRUONG CONG THANH CHIEN", 1);
														}
														Class80.smethod_0(num);
													}
													bool flag17 = Form1.int_20 == 3;
													if (flag17)
													{
														bool flag18 = Form1.int_65 == 0;
														if (flag18)
														{
															Class70.smethod_52(gstruct, "<bclr=blue><color=green>CHE DO DON DAU", 1);
															Class70.smethod_52(gstruct, "<bclr=blue><color=green>ChÕ ®é nµy chØ ®¸nh vµ b¬m m¸u", 1);
														}
														Class63.smethod_0(num);
													}
												}
												else
												{
													bool flag19 = Form1.int_65 == 0;
													if (flag19)
													{
														Class70.smethod_52(gstruct, "<bclr=blue><color=green>TONG KIM - PHONG HOA LIEN THANH", 1);
													}
													Class61.smethod_0(num);
												}
											}
											else
											{
												bool flag20 = Form1.int_65 == 0;
												if (flag20)
												{
													Class70.smethod_52(gstruct, "<bclr=blue><color=green>WAR (PK -SAN BOSS)", 1);
												}
												Class54.smethod_0(num);
											}
										}
										else
										{
											Class70.smethod_52(gstruct, "<bclr=blue><color=green>T-R-A-I-N-(" + Class37.smethod_1(gstruct.int_32, false) + ")", 1);
											Class6.smethod_0(num);
										}
									}
								}
								else
								{
									bool flag21 = Form1.int_65 == 0;
									if (flag21)
									{
										Class70.smethod_52(gstruct, "<bclr=blue><color=green>VAN SU THONG", 1);
									}
									Class71.smethod_0(num);
								}
							}
							else
							{
								bool flag22 = Form1.int_65 == 0;
								if (flag22)
								{
									Class70.smethod_52(gstruct, "<bclr=blue><color=green>SAN BOSS SAT THU", 1);
								}
								Class100.smethod_0(num);
								num2 = 1;
							}
						}
						else
						{
							bool flag23 = gstruct.int_20[1] > 0;
							if (flag23)
							{
								Class70.smethod_52(gstruct, "<bclr=blue><color=green>CHAY TIN SU PHONG KY", 1);
								Class65.smethod_0(num);
							}
							else
							{
								Class70.smethod_52(gstruct, "<bclr=blue><color=green>CHAY TIN SU THIEN BAO KHO", 1);
								Class65.smethod_7(num);
							}
							num2 = 1;
							Thread.Sleep(1000);
						}
					}
					else
					{
						Thread.Sleep(100);
					}
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000C5844 File Offset: 0x000C3A44
		private static void smethod_2()
		{
			int int_ = Class75.int_2;
			Class75.int_2 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_27 = false;
							GStruct49 gstruct49_ = Form1.gstruct49_0[num];
							Class70.smethod_52(gstruct49_, "<color=yellow>" + Form1.string_1.ToUpper() + " FOR PRIVATE GAME", 1);
							Class70.smethod_52(gstruct49_, "<color=green>Webs: http://canhtrang.com/", 1);
							Class70.smethod_52(gstruct49_, "KET THUC AUTO.", 1);
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_27;
						if (bool_)
						{
							break;
						}
						flag = true;
						Form1.gstruct49_0[num].bool_27 = true;
						Class12.smethod_29(ref Class12.string_16, "[" + Class10.smethod_1(Form1.gstruct49_0[num].string_22, 1, false) + "] đang chạy.");
					}
					Class75.smethod_3(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000C59B0 File Offset: 0x000C3BB0
		private static void smethod_3(int int_5)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			byte[] byte_ = new byte[4];
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			long num2 = -1L;
			long long_ = 0L;
			long num3 = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			long long_5 = 0L;
			long long_6 = 0L;
			long long_7 = 0L;
			long long_8 = 0L;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			int num4 = 0;
			int num5 = 0;
			int num6 = -1;
			int num7 = -1;
			int num8 = 0;
			int num9 = -1;
			int num10 = -1;
			int num11 = 0;
			long[] array3 = new long[3];
			long[] array4 = array3;
			long long_9 = 0L;
			bool flag6 = false;
			int num12 = 0;
			int[] array5 = new int[10];
			for (int i = 0; i < array5.Length; i++)
			{
				array5[i] = 4;
			}
			int num13 = 0;
			int num14;
			int num21;
			string text;
			for (;;)
			{
				Thread.Sleep(200);
				num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
				bool flag7 = Class12.bool_0 || num14 < 0 || !Form1.gstruct49_0[num14].bool_25;
				if (flag7)
				{
					break;
				}
				bool flag8 = flag2;
				if (flag8)
				{
					Form1.gstruct49_0[num14].gstruct43_0 = gstruct.gstruct43_0;
					flag2 = false;
				}
				gstruct = Form1.gstruct49_0[num14];
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref array5[0]);
				uint num15 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num15 + Class53.gstruct51_13.uint_0, array, 4, ref array5[1]);
				uint num16 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref array5[2]);
				uint num17 = BitConverter.ToUInt32(array, 0);
				uint num18 = num17 + num16 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_55.uint_0, array, 4, ref array5[3]);
				int num19 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_50.uint_0, array, 4, ref array5[4]);
				int num20 = BitConverter.ToInt32(array, 0);
				bool flag9 = num20 > 0 && num19 > 0 && Class12.smethod_28(long_2) > (long)num4;
				if (flag9)
				{
					bool flag10 = GClass1.string_1 != null && !(GClass1.string_1 == string.Empty) && (flag || (!Form1.bool_0 && Form1.int_3 <= Form1.int_2));
					if (!flag10)
					{
						goto IL_5AF;
					}
					num21 = GClass1.smethod_5(gstruct);
					bool flag11 = num21 > 0;
					if (flag11)
					{
						bool flag12 = !flag;
						if (flag12)
						{
							bool flag13 = Form1.int_65 != 0;
							if (flag13)
							{
								Class70.smethod_52(gstruct, ">>", 1);
							}
							else
							{
								Class70.smethod_52(gstruct, Class12.smethod_0(Class12.char_38), 1);
							}
							bool flag14 = Form1.int_17 > 0 || Form1.int_6 > 0 || Form1.int_7 > 0;
							if (flag14)
							{
								Class70.smethod_14(gstruct, Form1.int_18 > 0);
							}
						}
						num4 = 180000;
						bool flag15 = num21 > 1 && GClass1.gstruct15_0.uint_1 != null;
						if (flag15)
						{
							GStruct28[] array6 = Class48.smethod_0(new int[]
							{
								gstruct.int_136
							});
							bool flag16 = array6 != null;
							if (flag16)
							{
								int num22 = 0;
								text = string.Empty;
								int num23 = 0;
								for (;;)
								{
									bool flag17 = num23 < array6.Length;
									if (!flag17)
									{
										break;
									}
									string string_ = array6[num23].string_2;
									bool flag18 = string_ != null && !(string_ == string.Empty);
									if (flag18)
									{
										uint num24 = Class12.smethod_6(string_.Replace(" ", string.Empty));
										bool flag19 = num24 > 0U;
										if (flag19)
										{
											for (int j = 0; j < GClass1.gstruct15_0.uint_1.Length; j++)
											{
												bool flag20 = num24 != GClass1.gstruct15_0.uint_1[j];
												if (!flag20)
												{
													goto IL_3F9;
												}
											}
											bool flag21 = text != string.Empty && text != null;
											if (flag21)
											{
												text += ",";
											}
											text += string_;
											num22++;
										}
									}
									num23++;
								}
								bool flag22 = num22 <= 0;
								if (!flag22)
								{
									goto IL_46F;
								}
								IL_3F9:;
							}
							else
							{
								num4 = 3000;
							}
						}
						IL_26DE:
						num5 = 0;
						flag = true;
						goto IL_26E7;
						goto IL_26DE;
					}
					bool flag23 = (flag || num5 <= 1) && num5 <= 3;
					if (!flag23)
					{
						goto IL_531;
					}
					num5++;
					num4 = 3000;
					IL_26E7:
					long_2 = Class12.smethod_27();
				}
				int num25 = Class83.smethod_39(gstruct);
				bool flag24 = num20 != 0 && num19 != 0 && num19 != 10 && num19 != 21 && num25 > 1;
				if (flag24)
				{
					num8 = 0;
					num3 = 0L;
					bool flag25 = !flag4;
					if (flag25)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref array5[5]);
						int num26 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_43.uint_0, array, 4, ref array5[6]);
						int num27 = BitConverter.ToInt32(array, 0);
						int num28 = 6;
						int k = 0;
						for (;;)
						{
							bool flag26 = k <= num28;
							if (!flag26)
							{
								goto IL_6CE;
							}
							bool flag27 = array5[k] == 0;
							if (flag27)
							{
								break;
							}
							k++;
						}
						continue;
						IL_6CE:
						bool flag28 = num7 != num27;
						if (flag28)
						{
							for (k = 0; k < array4.Length; k++)
							{
								array4[k] = 0L;
							}
							bool flag29 = Class60.smethod_9(num26) == null;
							if (flag29)
							{
								flag3 = true;
								long_6 = Class12.smethod_27();
							}
							num7 = num27;
							num2 = -1L;
							Class70.smethod_2(gstruct, Class70.uint_31, 0, 4);
						}
						bool flag30 = num6 != num26;
						if (flag30)
						{
							for (k = 0; k < array4.Length; k++)
							{
								array4[k] = 0L;
							}
							flag3 = true;
							long_6 = Class12.smethod_27();
							num6 = num26;
							num2 = -1L;
							long_8 = Class12.smethod_27();
						}
						bool flag31 = Class12.smethod_28(long_8) > 3000L;
						if (flag31)
						{
							long_8 = DateTime.Now.AddSeconds(30.0).Ticks;
							uint[,] array7 = Class79.smethod_38(gstruct);
							Class70.smethod_2(gstruct, Class70.uint_20, (int)array7[0, 0], 4);
							Class70.smethod_2(gstruct, Class70.uint_20 + 1U, (int)array7[0, 1], 4);
							Class70.smethod_2(gstruct, Class70.uint_19, (int)array7[1, 0], 4);
							Class70.smethod_2(gstruct, Class70.uint_19 + 1U, (int)array7[1, 1], 4);
						}
						Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_7 + Class53.gstruct51_147.uint_0, array, 4, ref num);
						uint num29 = BitConverter.ToUInt32(array, 0);
						bool flag32 = Class66.int_0 > 0 && num29 == 0U;
						if (flag32)
						{
							Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_7 + Class86.uint_0, array, 1, ref num);
							int num30 = (int)array[0];
							uint uint_ = gstruct.uint_7 + Class53.gstruct51_179.uint_0 + Class53.gstruct51_180.uint_0 + Class53.gstruct51_181.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 1, ref num);
							int num31 = (int)array[0];
							int num32 = 0;
							bool flag33 = num30 <= 0 || num31 <= 0;
							if (flag33)
							{
								bool flag34 = num30 > 0 || num31 > 0;
								if (flag34)
								{
									array[0] = 0;
									Class22.WriteProcessMemory(gstruct.int_137, uint_, array, 1, ref num);
									Class83.smethod_40(gstruct);
									num32 = 1;
								}
							}
							else
							{
								bool flag35 = num31 > 1;
								if (flag35)
								{
									array[0] = 1;
									Class22.WriteProcessMemory(gstruct.int_137, uint_, array, 1, ref num);
									num32 = 1;
								}
							}
							bool flag36 = num32 > 0;
							if (flag36)
							{
								Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_20, array, 4, ref num);
								num32 = BitConverter.ToInt32(array, 0) + 1;
								byte[] bytes = BitConverter.GetBytes(num32);
								Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_20, bytes, 4, ref num);
							}
						}
						bool flag37 = gstruct.int_67[0] > 0;
						if (flag37)
						{
							num13--;
							bool flag38 = num13 <= 0;
							if (flag38)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_88.uint_0, array, 4, ref num);
								bool flag39 = BitConverter.ToUInt32(array, 0) > 0U;
								if (flag39)
								{
									uint num33 = num15 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, num33 + Class53.gstruct51_73.uint_0, array, 4, ref num);
									int num34 = BitConverter.ToInt32(array, 0);
									int num35 = 10000;
									bool flag40 = num34 > gstruct.int_67[1] * num35;
									if (flag40)
									{
										int num36 = num34 - gstruct.int_67[1] * num35;
										bool flag41 = num36 > 10 * num35;
										if (flag41)
										{
											num36 = 10 * num35;
										}
										Class70.smethod_73(gstruct, num36);
									}
								}
								num13 = 5;
							}
						}
						int num37 = Class77.smethod_13(gstruct);
						bool flag42 = num10 != num37;
						if (flag42)
						{
							int num38 = Class77.smethod_16(gstruct, num37);
							int num39 = Class77.smethod_21(gstruct, num37);
							int num40 = Class77.smethod_20(gstruct, num37, num38) - 12;
							bool flag43 = num40 <= 0;
							if (flag43)
							{
								num40 = gstruct.int_96;
							}
							Class70.smethod_2(gstruct, Class70.uint_43, num40, 4);
							Class70.smethod_2(gstruct, Class70.uint_46, num39, 4);
							num10 = num37;
						}
						bool flag44 = gstruct.int_123 > 0 && !gstruct.bool_36 && FormNhiepTT.int_0 <= 0;
						if (flag44)
						{
							FormNhiepTT.int_0 = int_5;
							new Thread(new ThreadStart(FormNhiepTT.smethod_0)).Start();
							Thread.Sleep(100);
						}
						bool flag45 = gstruct.int_12[0] > 0 && !gstruct.bool_3 && FormBanEvent.int_0 <= 0;
						if (flag45)
						{
							FormBanEvent.int_0 = int_5;
							new Thread(new ThreadStart(FormBanEvent.smethod_2)).Start();
							Thread.Sleep(100);
						}
						bool flag46 = !gstruct.bool_39 && gstruct.gstruct45_0[0].int_0 > 0 && gstruct.gstruct45_0[1].int_0 > 0 && Class15.int_0 <= 0;
						if (flag46)
						{
							Class15.int_0 = int_5;
							new Thread(new ThreadStart(Class15.smethod_0)).Start();
							Thread.Sleep(100);
						}
						bool flag47 = (Form1.int_6 > 0 || Form1.int_7 > 0) && (Form1.int_52 <= 0 || Class44.gstruct33_0.int_0 <= 0);
						if (flag47)
						{
							bool flag48 = Form1.int_6 <= 0 && Form1.int_7 > 0;
							if (flag48)
							{
								FormMayphu.smethod_5(gstruct);
							}
							bool flag49 = Class44.gstruct33_1.int_9 > 0;
							if (flag49)
							{
								Class44.smethod_8(Class44.gstruct33_1.int_9);
								Class44.gstruct33_1.int_9 = 0;
							}
							bool flag50 = Class12.smethod_28(long_3) > 30000L;
							if (flag50)
							{
								Class83.smethod_32(gstruct, 0U);
								long_3 = Class12.smethod_27();
							}
						}
						int num41 = Class79.smethod_4(gstruct);
						bool flag51 = gstruct.int_75 != null && gstruct.int_75[0] > 0 && Class12.smethod_28(long_4) > 1000L;
						if (flag51)
						{
							bool flag52 = num9 < num41;
							if (flag52)
							{
								Class32.smethod_9(gstruct);
								long_4 = Class12.smethod_27();
							}
							num9 = num41;
						}
						bool flag53 = Class12.smethod_28(long_) > 90000L;
						if (flag53)
						{
							long_ = Class12.smethod_27();
							num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
							bool flag54 = num14 < 0;
							if (flag54)
							{
								break;
							}
							gstruct = Form1.gstruct49_0[num14];
							Class70.smethod_2(gstruct, 0U, 0, 4);
							Class70.smethod_2(gstruct, Class70.uint_5, 0, 4);
							Class70.smethod_2(gstruct, Class70.uint_6, 0, 4);
							Class70.smethod_2(gstruct, Class70.uint_31, 0, 4);
							Form1.gstruct49_0[num14].string_20 = Class26.smethod_10(gstruct);
							string text2 = Class77.smethod_18(gstruct, null);
							Form1.gstruct49_0[num14].string_23 = text2;
							bool flag55 = text2 == "NGAMY";
							if (flag55)
							{
								int num42 = 0;
								int num43 = 0;
								bool flag56 = gstruct.int_101[6] > 0;
								if (flag56)
								{
									num42 = 1114 * (int)Convert.ToByte(Class77.smethod_16(gstruct, 1114) > 0);
									num43 = 470;
								}
								bool flag57 = num42 == 0;
								if (flag57)
								{
									num42 = (int)(93 * Convert.ToByte(Class77.smethod_16(gstruct, 93) > 0));
									num43 = 400;
								}
								Form1.gstruct49_0[num14].int_101[1] = num42;
								Form1.gstruct49_0[num14].int_101[5] = num43;
							}
							bool flag58 = !gstruct.bool_57 && text2 == "VODANG";
							if (flag58)
							{
								int num44 = Class77.smethod_16(gstruct, 716);
								Form1.gstruct49_0[num14].bool_57 = (num44 > 0);
								bool flag59 = num44 < 1;
								if (flag59)
								{
									num44 = 1;
								}
								else
								{
									bool flag60 = Class53.int_3.Length < num44;
									if (flag60)
									{
										num44 = Class53.int_3.Length;
									}
								}
								Form1.gstruct49_0[num14].long_8 = (long)Class53.int_3[num44 - 1];
							}
							bool flag61 = !gstruct.bool_58 && text2 == "THIENNHAN";
							if (flag61)
							{
								int num45 = Class77.smethod_16(gstruct, 715);
								Form1.gstruct49_0[num14].bool_58 = (num45 > 0);
								bool flag62 = num45 < 1;
								if (flag62)
								{
									num45 = 1;
								}
								else
								{
									bool flag63 = Class53.int_4.Length < num45;
									if (flag63)
									{
										num45 = Class53.int_4.Length;
									}
								}
								Form1.gstruct49_0[num14].long_8 = (long)Class53.int_4[num45 - 1];
							}
							bool flag64 = !(text2 == "THIENNHAN") && !(text2 == "NGUDOC") && !(text2 == "CONLON") && gstruct.int_119 > 0;
							if (flag64)
							{
								Form1.gstruct49_0[num14].int_119 = 0;
							}
							bool flag65 = gstruct.int_3 != null;
							if (flag65)
							{
								for (k = 0; k < gstruct.int_3.GetLength(0); k++)
								{
									int num46 = Class77.smethod_16(gstruct, gstruct.int_3[k, 0]);
									Form1.gstruct49_0[num14].int_3[k, 1] = num46;
									bool flag66 = num46 <= 0;
									if (flag66)
									{
										Form1.gstruct49_0[num14].int_3[k, 0] = 0;
									}
								}
								Form1.gstruct49_0[num14].int_4 = Class53.smethod_17(text2);
							}
							bool flag67 = (gstruct.int_84[0] > 0 || gstruct.int_84[1] > 0) && text2 == "CONLON" && !gstruct.bool_18 && Class95.int_0 <= 0;
							if (flag67)
							{
								Class95.int_0 = gstruct.int_136;
								new Thread(new ThreadStart(Class95.smethod_0)).Start();
								Thread.Sleep(300);
							}
						}
						bool flag68 = Form1.int_20 == 0;
						if (flag68)
						{
							Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_56.uint_0, array, 4, ref num);
							int num47 = BitConverter.ToInt32(array, 0);
							bool flag69 = num27 > 0 && !gstruct.bool_22;
							if (flag69)
							{
								int num48 = Class70.smethod_3(gstruct, Class70.uint_30, 4);
								bool flag70 = num48 <= 0;
								if (flag70)
								{
									bool flag71 = Form1.int_21 > 0 && Form1.int_83 > 0;
									if (flag71)
									{
										uint[] uint_2 = new uint[]
										{
											Class22.smethod_30(num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										int num49 = -1;
										bool flag72 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 == num26 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && Class60.smethod_18(uint_2, Class44.gstruct33_1.uint_4) < 1000000L;
										bool flag73 = Form1.int_6 <= 0 && Form1.int_7 <= 0 && Class44.gstruct33_0.int_4 == num26 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4) < 1000000L;
										bool flag74 = flag72 && num47 != Class44.gstruct33_1.int_2;
										if (flag74)
										{
											num49 = Class44.gstruct33_1.int_2;
										}
										else
										{
											bool flag75 = flag73 && num47 != Class44.gstruct33_0.int_2;
											if (flag75)
											{
												num49 = Class44.gstruct33_0.int_2;
											}
											else
											{
												bool flag76 = !flag72 && !flag73 && num47 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136;
												if (flag76)
												{
													num49 = num47 - 1;
												}
											}
										}
										bool flag77 = num49 > 0 || (num49 == 0 && Class12.smethod_28(long_5) > 3000L);
										if (flag77)
										{
											bool flag78 = num49 < num47;
											if (flag78)
											{
												num49 = num47 - 1;
											}
											Class70.smethod_57(gstruct, "Switch([[pk]]," + num49.ToString() + ")");
											bool flag79 = num47 == 1;
											if (flag79)
											{
												long_5 = Class12.smethod_27();
											}
										}
									}
								}
								else
								{
									Class70.smethod_2(gstruct, Class70.uint_30, 0, 4);
									bool flag80 = Class44.gstruct33_0.int_0 == gstruct.int_136 || Class44.gstruct33_0.int_0 == 0 || Form1.int_21 == 0 || Form1.int_83 <= 0;
									if (flag80)
									{
										num47 = ((num47 == 2) ? 1 : 2);
										Class70.smethod_57(gstruct, "Switch([[pk]]," + num47.ToString() + ")");
										long_5 = Class12.smethod_27();
									}
								}
							}
							else
							{
								bool flag81 = num47 > 0 && Class12.smethod_28(long_5) > 5000L;
								if (flag81)
								{
									Class70.smethod_57(gstruct, "Switch([[pk]]," + (num47 - 1).ToString() + ")");
									long_5 = Class12.smethod_27();
								}
							}
						}
						bool flag82 = flag3 && Class12.smethod_28(long_6) > 3000L;
						if (flag82)
						{
							bool flag83 = gstruct.int_138[0] > 0 && gstruct.int_138[1] > 0;
							if (flag83)
							{
								int num50 = Class77.smethod_13(gstruct);
								bool flag84 = num50 != gstruct.int_138[1];
								if (flag84)
								{
									Class77.smethod_15(gstruct, (uint)gstruct.int_138[1], false);
									Class70.smethod_31(gstruct, (uint)gstruct.int_138[1]);
									Thread.Sleep(300);
								}
							}
							bool flag85 = gstruct.int_139[0] > 0 && gstruct.int_139[1] > 0;
							if (flag85)
							{
								int num51 = Class77.smethod_14(gstruct);
								bool flag86 = num51 != gstruct.int_139[1];
								if (flag86)
								{
									Class77.smethod_15(gstruct, (uint)gstruct.int_139[1], true);
									Class70.smethod_32(gstruct, (uint)gstruct.int_139[1]);
									Thread.Sleep(300);
								}
							}
							bool flag87 = gstruct.int_140[0] > 0 && gstruct.int_140[1] > 0;
							if (flag87)
							{
								int num52 = Class77.smethod_16(gstruct, gstruct.int_140[1]);
								Class70.smethod_2(gstruct, Class70.uint_7, num52, 4);
							}
							bool flag88 = gstruct.int_141[0] > 0 && gstruct.int_141[1] > 0;
							if (flag88)
							{
								int num53 = Class77.smethod_16(gstruct, gstruct.int_141[1]);
								Class70.smethod_2(gstruct, Class70.uint_8, num53, 4);
							}
							bool flag89 = gstruct.int_142[0] > 0 && gstruct.int_142[1] > 0;
							if (flag89)
							{
								int num54 = Class77.smethod_16(gstruct, gstruct.int_142[1]);
								Class70.smethod_2(gstruct, Class70.uint_9, num54, 4);
							}
							flag3 = false;
						}
						bool flag90 = Form1.int_55 > 0 && (Form1.int_59 > 0 || num27 > 0);
						if (flag90)
						{
							long ticks = new TimeSpan(0, 0, 0, Form1.int_82, 0).Ticks;
							bool flag91 = num2 <= 0L;
							if (flag91)
							{
								num2 = DateTime.Now.Ticks - ticks + new TimeSpan(0, 0, 0, 10, 0).Ticks;
							}
							bool flag92 = DateTime.Now.Ticks >= num2 + ticks;
							if (flag92)
							{
								int num55 = Class70.smethod_3(gstruct, Class70.uint_5, 4);
								bool flag93 = num55 <= 0;
								if (flag93)
								{
									GStruct32[] array8 = Class79.smethod_37(gstruct, Form1.int_60[0], Form1.int_60[1], true);
									num2 = DateTime.Now.Ticks;
									bool flag94 = array8 != null;
									if (flag94)
									{
										bool flag95 = !(array8[0].string_0 == "CHANGE");
										if (flag95)
										{
											int num56 = -1;
											for (int l = 0; l < array8.Length; l++)
											{
												bool flag96 = array8[l].int_0 <= Form1.int_80;
												if (flag96)
												{
													num56 = l;
													break;
												}
											}
											bool flag97 = num56 >= 0;
											if (flag97)
											{
												bool flag98 = false;
												bool flag99 = Form1.int_81 > 0;
												if (flag99)
												{
													Class35.smethod_140(gstruct, "Ph­îng T­êng", "t©m", null, false);
													Class60.smethod_14(gstruct, true);
													int num57 = 0;
													int num58 = 0;
													for (;;)
													{
														num57++;
														Thread.Sleep(100);
														bool flag100 = num57 > 15;
														if (flag100)
														{
															break;
														}
														Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
														num15 = BitConverter.ToUInt32(array, 0);
														Class22.ReadProcessMemory(gstruct.int_137, num15 + Class53.gstruct51_13.uint_0, array, 4, ref num);
														num16 = BitConverter.ToUInt32(array, 0);
														Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
														num17 = BitConverter.ToUInt32(array, 0);
														num18 = num17 + num16 * Class53.gstruct51_15.uint_0;
														Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_50.uint_0, array, 4, ref num);
														num20 = BitConverter.ToInt32(array, 0);
														Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_43.uint_0, array, 4, ref num);
														num27 = BitConverter.ToInt32(array, 0);
														Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
														num26 = BitConverter.ToInt32(array, 0);
														bool flag101 = num20 > 0 && num26 > 0 && num27 <= 0;
														if (flag101)
														{
															bool flag102 = num58 >= 6;
															if (flag102)
															{
																goto Block_178;
															}
															num58++;
														}
														else
														{
															num58 = 0;
														}
													}
													IL_1912:
													Class70.smethod_52(gstruct, "<color=yellow>[ Trang bi do ben thap can sua chua ]", 1);
													Class36.smethod_50(gstruct, "[ Trang bi do ben thap can sua chua ]");
													goto IL_192C;
													Block_178:
													flag98 = true;
													num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
													bool flag103 = 0 <= num14;
													if (flag103)
													{
														Form1.gstruct49_0[num14].bool_25 = false;
													}
													goto IL_1912;
												}
												IL_192C:
												bool flag104 = !flag98 && Form1.int_79 > 0;
												if (flag104)
												{
													bool flag105 = array8 != null && num56 < array8.Length && 0 <= num56;
													if (flag105)
													{
														string string_2 = string.Concat(new string[]
														{
															"Nhân vật [",
															Class10.smethod_1(gstruct.string_22, 1, false),
															"] đã thoát do có trang bị ",
															Class10.smethod_1(array8[num56].string_0, 1, false),
															" độ bền <= ",
															Form1.int_80.ToString(),
															", hãy nhanh chóng sửa chữa."
														});
														Class53.smethod_25("TrangbiDobenThap.txt", string_2, true, "Tahoma", 12, 600, 400, 200, 280);
													}
													Class22.smethod_53(gstruct.process_0);
												}
											}
										}
										else
										{
											num2 = -1L;
										}
									}
								}
							}
						}
						bool flag106 = num27 > 0;
						if (flag106)
						{
							bool flag107 = gstruct.int_64[0] > 0 && Class12.smethod_28(long_9) > (long)((1 + gstruct.int_64[2]) * 1000);
							if (flag107)
							{
								bool flag108 = !flag6;
								if (flag108)
								{
									flag6 = (num12 != Class79.smethod_4(gstruct));
								}
								bool flag109 = flag6;
								if (flag109)
								{
									uint num59 = Class22.smethod_30(num18 + Class53.uint_7, gstruct.int_137);
									uint num60 = Class22.smethod_30(num18 + Class53.uint_8, gstruct.int_137);
									bool flag110 = num59 < num60 && num60 < num59 * 3U;
									if (flag110)
									{
										num59 = num60;
									}
									bool flag111 = (ulong)num59 <= (ulong)((long)gstruct.int_64[1]);
									if (flag111)
									{
										flag6 = ((Form1.int_20 != 1 && Class56.smethod_0(num26) == null) ? Class60.smethod_16(gstruct, gstruct.string_8) : Class60.smethod_16(gstruct, gstruct.string_7));
									}
								}
								num12 = Class79.smethod_4(gstruct);
								long_9 = Class12.smethod_27();
							}
							bool flag112 = !Form1.bool_8 && Class12.smethod_28(long_7) >= 800L;
							if (flag112)
							{
								Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_41 * 4U, array2, 1, ref num);
								bool flag113 = array2[0] > 0;
								if (flag113)
								{
									for (k = 0; k < array4.Length; k++)
									{
										array4[k] = 0L;
									}
									array2[0] = 0;
									Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_41 * 4U, array2, 1, ref num);
								}
								num11++;
								int num61 = 0;
								bool flag114 = num11 >= 2 && num11 <= 3;
								if (flag114)
								{
									int num62 = num11;
									int num63 = num62;
									if (num63 != 2)
									{
										if (num63 == 3)
										{
											bool flag115 = gstruct.int_142[0] > 0 && gstruct.int_142[1] > 0 && Class12.smethod_28(array4[2]) > (long)gstruct.int_142[2] && Class70.smethod_3(gstruct, Class70.uint_9, 4) > 0;
											if (flag115)
											{
												num61 = gstruct.int_142[1];
												array4[2] = Class12.smethod_27();
											}
										}
									}
									else
									{
										bool flag116 = gstruct.int_141[0] > 0 && gstruct.int_141[1] > 0 && Class12.smethod_28(array4[1]) > (long)gstruct.int_141[2] && Class70.smethod_3(gstruct, Class70.uint_8, 4) > 0;
										if (flag116)
										{
											num61 = gstruct.int_141[1];
											array4[1] = Class12.smethod_27();
										}
									}
								}
								else
								{
									bool flag117 = gstruct.int_140[0] > 0 && gstruct.int_140[1] > 0 && Class12.smethod_28(array4[0]) > (long)gstruct.int_140[2] && Class70.smethod_3(gstruct, Class70.uint_7, 4) > 0;
									if (flag117)
									{
										num61 = gstruct.int_140[1];
										array4[0] = Class12.smethod_27();
									}
									num11 = 1;
								}
								bool flag118 = num61 > 0;
								if (flag118)
								{
									int num64 = 0;
									int num65 = 0;
									byte[] array9 = new byte[4];
									byte[] byte_2 = new byte[4];
									byte[] byte_3 = new byte[4];
									Class70.smethod_2(gstruct, Class70.uint_6, 1, 4);
									Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num);
									Class22.ReadProcessMemory(gstruct.int_137, num15 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_68.uint_0, byte_3, 4, ref num);
									Thread.Sleep(100);
									int num66 = 0;
									for (;;)
									{
										bool flag119 = num64 >= 200 || num65 >= 10;
										if (flag119)
										{
											Class36.smethod_11(gstruct, num61, 0U);
											num64 = 0;
											while (num64 < 8 && num61 > 0)
											{
												num64++;
												Thread.Sleep(100);
												for (uint num67 = 0U; num67 < 6U; num67 += 1U)
												{
													uint num68 = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num67;
													Class22.ReadProcessMemory(gstruct.int_137, num18 + num68, array9, 4, ref num);
													int num69 = BitConverter.ToInt32(array9, 0);
													bool flag120 = num69 > 0 && Class77.smethod_3(num69) == num61;
													if (flag120)
													{
														num61 = 0;
														break;
													}
												}
											}
											bool flag121 = num61 <= 0 || num66 != 0;
											if (flag121)
											{
												break;
											}
											num66 = 1;
										}
										else
										{
											num64++;
											Class22.WriteProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
											Thread.Sleep(1);
											Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_55.uint_0, array9, 1, ref num);
											num65 = ((array9[0] <= 4) ? (num65 + 1) : 0);
										}
									}
									Class22.WriteProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_31.uint_0, byte_2, 4, ref num);
									Class22.WriteProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_161.uint_0 - 8U, byte_3, 4, ref num);
									Class70.smethod_2(gstruct, Class70.uint_6, 0, 4);
									long_7 = Class12.smethod_27();
								}
							}
							uint num70 = num15 + Class53.gstruct51_30.uint_0;
							bool flag122 = Form1.int_14 > 0 || Form1.int_16 > 0 || Form1.int_15 > 0;
							if (flag122)
							{
								bool flag123 = gstruct.gstruct43_0.uint_0 != 0U && gstruct.gstruct43_0.int_0 > 0;
								if (flag123)
								{
									uint[] uint_3 = new uint[]
									{
										Class22.smethod_30(num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
										Class22.smethod_30(num18 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
									};
									bool flag124 = gstruct.string_18 != null;
									if (flag124)
									{
										bool bool_ = FormMayphu.bool_2;
										if (bool_)
										{
											int[] array10 = Class56.smethod_0(num26);
											bool flag125 = array10 != null;
											if (flag125)
											{
												bool flag126 = !flag5;
												if (flag126)
												{
													Class70.smethod_55(gstruct, "<color=green>ChÕ ®é cõu s¸t trong Tèng Kim ®· bÞ t¾t bëi adgame.", null);
													flag5 = true;
												}
												goto IL_212E;
											}
											flag5 = false;
										}
										for (int m = 0; m < gstruct.string_18.Length; m++)
										{
											bool flag127 = gstruct.gstruct43_0.string_0 != gstruct.string_18[m];
											if (!flag127)
											{
												uint num71 = num17 + (uint)(gstruct.gstruct43_0.int_0 * (int)Class53.gstruct51_15.uint_0);
												bool flag128 = Class22.smethod_30(num71 + Class53.gstruct51_50.uint_0, gstruct.int_137) == 0U || Class22.smethod_28(num70 + Class53.gstruct51_60.uint_0, gstruct.int_137, 18) != gstruct.gstruct43_0.string_0;
												if (flag128)
												{
													gstruct.gstruct43_0.int_0 = Class36.smethod_8(gstruct, gstruct.gstruct43_0.uint_0);
													bool flag129 = gstruct.gstruct43_0.int_0 == 0;
													if (flag129)
													{
														goto IL_23FB;
													}
												}
												uint[] uint_4 = new uint[]
												{
													Class22.smethod_30(num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
													Class22.smethod_30(num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
												};
												long num72 = Class60.smethod_18(uint_3, uint_4);
												bool flag130 = num72 <= 0L || num72 >= 1690000L;
												if (flag130)
												{
												}
												break;
											}
										}
									}
								}
								IL_212E:
								uint num73 = Class22.smethod_30(num70 + Class53.gstruct51_61.uint_0, gstruct.int_137);
								bool flag131 = num73 != gstruct.gstruct43_0.uint_0 || gstruct.gstruct43_0.int_0 <= 0;
								if (flag131)
								{
									bool flag132 = gstruct.gstruct43_0.uint_0 == num73 || num73 > 0U;
									if (flag132)
									{
										gstruct.gstruct43_0.uint_0 = num73;
										bool flag133 = num73 > 0U;
										if (flag133)
										{
											gstruct.gstruct43_0.int_0 = Class36.smethod_8(gstruct, num73);
											uint num71 = num17 + (uint)(gstruct.gstruct43_0.int_0 * (int)Class53.gstruct51_15.uint_0);
											bool flag134 = Class22.smethod_30(num71 + Class53.gstruct51_50.uint_0, gstruct.int_137) > 0U;
											if (flag134)
											{
												gstruct.gstruct43_0.uint_2 = Class22.smethod_30(num70 + Class53.gstruct51_62.uint_0, gstruct.int_137);
												gstruct.gstruct43_0.string_0 = Class22.smethod_28(num70 + Class53.gstruct51_60.uint_0, gstruct.int_137, 16);
												string text3 = Class36.string_1[(int)Convert.ToByte(gstruct.gstruct43_0.uint_2 == 2U)];
												bool flag135 = Form1.int_16 > 0;
												if (flag135)
												{
													Class70.smethod_57(gstruct, Class36.string_2[0].Replace("XXX", gstruct.gstruct43_0.string_0).Replace("YYY", text3));
													Thread.Sleep(100);
												}
												bool flag136 = Form1.int_14 > 0;
												if (flag136)
												{
													Class70.smethod_52(gstruct, string.Concat(new string[]
													{
														"<color=green>",
														gstruct.gstruct43_0.string_0,
														"<color=white> ",
														text3,
														" <color=red>cõu s¸t<color=white> víi b¹n."
													}), 1);
													Thread.Sleep(100);
												}
												bool flag137 = Form1.int_15 > 0;
												if (flag137)
												{
													Class70.smethod_57(gstruct, Class36.string_3.Replace("XXX", gstruct.gstruct43_0.string_0).Replace("YYY", text3));
													Thread.Sleep(100);
												}
											}
										}
									}
									else
									{
										Class70.smethod_52(gstruct, "<color=yellow>KÕt thóc cõu s¸t", 1);
										gstruct.gstruct43_0.uint_0 = num73;
										num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
										bool flag138 = num14 < 0;
										if (flag138)
										{
											break;
										}
										Form1.gstruct49_0[num14].gstruct43_0 = gstruct.gstruct43_0;
									}
								}
								flag2 = true;
								goto IL_23FB;
								goto IL_212E;
							}
							IL_23FB:
							bool flag139 = gstruct.int_120 > 0 && Class75.int_4 <= 0 && !gstruct.bool_24;
							if (flag139)
							{
								Class75.int_4 = int_5;
								new Thread(new ThreadStart(Class75.smethod_4)).Start();
							}
						}
						else
						{
							flag2 = (gstruct.gstruct43_0.uint_0 != 0U || gstruct.gstruct43_0.int_0 > 0);
							gstruct.gstruct43_0.uint_0 = 0U;
							gstruct.gstruct43_0.int_0 = 0;
							for (k = 0; k < array4.Length; k++)
							{
								array4[k] = 0L;
							}
							Thread.Sleep(100);
						}
					}
					else
					{
						flag4 = false;
						Thread.Sleep(1000);
						Class86.smethod_8(gstruct, -1);
					}
				}
				else
				{
					Class14.smethod_2(gstruct, false);
					num8++;
					bool flag140 = num8 < 4;
					if (flag140)
					{
						Thread.Sleep(100);
					}
					else
					{
						flag4 = (flag4 || num20 == 0 || num25 <= 1);
						bool flag141 = num25 > 1;
						if (flag141)
						{
							long num74 = Class12.smethod_28(num3);
							bool flag142 = gstruct.int_94 <= 0 && (Form1.int_38 <= 0 || Form1.int_37 <= 0) && num74 > 10000L;
							if (flag142)
							{
								Class22.smethod_4(gstruct.uint_4, 32U);
								Thread.Sleep(600);
								bool flag143 = num3 > 0L && num74 > 15000L;
								if (flag143)
								{
									Class70.smethod_108(gstruct);
								}
								bool flag144 = 0 <= Class86.smethod_0(gstruct);
								if (flag144)
								{
									Class86.smethod_8(gstruct, -1);
								}
							}
							num7 = -1;
						}
						else
						{
							Thread.Sleep(300);
							num3 = Class12.smethod_27();
							long_8 = num3;
						}
					}
				}
			}
			return;
			IL_46F:
			num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
			bool flag145 = 0 <= num14;
			if (flag145)
			{
				Form1.gstruct49_0[num14].bool_25 = false;
			}
			Class70.smethod_52(gstruct, Class12.smethod_0(Class12.char_37).Replace("me kh", "me (" + text + ") kh").Replace("héi,", "(" + Form1.string_10 + "),"), 1);
			return;
			IL_531:
			num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
			bool flag146 = 0 <= num14;
			if (flag146)
			{
				Form1.gstruct49_0[num14].bool_25 = false;
			}
			bool flag147 = num21 != -10;
			if (flag147)
			{
				bool flag148 = num21 < 0;
				if (flag148)
				{
					Class70.smethod_52(gstruct, "<color=white>Ch­a ®¨ng ký: <color><color=yellow>LIC ®¨ng ký cã m· x¸c thùc kh«ng ®óng, liªn hÖ http://canhtrang.com/ ®Ó ®iÒu chØnh<color>", 1);
				}
				else
				{
					Class70.smethod_52(gstruct, "<color=white>Ch­a ®¨ng ký: <color><color=yellow>Ch­a ®¨ng ký sö dông nªn kh«ng sö dông ®­îc, liªn hÖ http://canhtrang.com/ ®Ó ®iÒu chØnh<color>", 1);
				}
			}
			else
			{
				Class70.smethod_52(gstruct, Class12.smethod_0(Class12.char_29), 1);
			}
			return;
			IL_5AF:
			num14 = Class81.smethod_3(Form1.gstruct49_0, int_5);
			bool flag149 = 0 <= num14;
			if (flag149)
			{
				Form1.gstruct49_0[num14].bool_25 = false;
			}
			Class70.smethod_52(gstruct, Class10.smethod_2(Class12.smethod_0(Class12.char_34)), 1);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000C80C0 File Offset: 0x000C62C0
		private static void smethod_4()
		{
			int num = Class75.int_4;
			long long_ = 0L;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				try
				{
					Thread.Sleep(500);
					int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag = num2 < 0;
					if (flag)
					{
						break;
					}
					bool flag2 = !Class12.bool_0 && Form1.gstruct49_0[num2].bool_25 && Form1.gstruct49_0[num2].int_120 > 0;
					if (!flag2)
					{
						Form1.gstruct49_0[num2].bool_24 = false;
						Class70.smethod_52(gstruct, "<color=yellow>Cõu s¸t theo danh s¸ch: <color=green>T¾t", 1);
						break;
					}
					gstruct = Form1.gstruct49_0[num2];
					bool flag3 = !gstruct.bool_24 || Class75.int_4 > 0;
					if (flag3)
					{
						Class70.smethod_52(gstruct, "<color=yellow>Cõu s¸t theo danh s¸ch: <color=green>BËt", 1);
						Form1.gstruct49_0[num2].bool_24 = true;
						Class75.int_4 = 0;
					}
					bool flag4 = gstruct.string_18 == null || gstruct.string_18.Length == 0;
					if (!flag4)
					{
						uint num3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
						uint num4 = num3 + Class53.gstruct51_30.uint_0;
						uint num5 = Class22.smethod_30(num3 + Class53.gstruct51_13.uint_0, gstruct.int_137);
						uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
						uint num7 = num6 + num5 * Class53.gstruct51_15.uint_0;
						int num8 = (int)Class22.smethod_30(num7 + Class53.gstruct51_43.uint_0, gstruct.int_137);
						int num9 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct.int_137);
						int num10 = (int)Class22.smethod_30(num7 + Class53.gstruct51_50.uint_0, gstruct.int_137);
						bool flag5 = num8 <= 0 || num10 == 0 || num9 == 0 || num9 == 10 || num9 == 21;
						if (flag5)
						{
							Thread.Sleep(600);
						}
						else
						{
							bool flag6 = Class12.smethod_28(long_) <= 1500L;
							if (!flag6)
							{
								string text = Class7.smethod_7(gstruct, null);
								bool flag7 = text != null;
								if (flag7)
								{
									gstruct.gstruct43_0.uint_2 = Class22.smethod_30(num4 + Class53.gstruct51_62.uint_0, gstruct.int_137);
									bool flag8 = gstruct.gstruct43_0.uint_2 < 2U;
									if (flag8)
									{
										Class70.smethod_57(gstruct, "Revenge('" + text + "')");
										Thread.Sleep(300);
										long_ = Class12.smethod_27();
									}
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x04000399 RID: 921
		public static int int_0;

		// Token: 0x0400039A RID: 922
		public static int[] int_1;

		// Token: 0x0400039B RID: 923
		private static int int_2;

		// Token: 0x0400039C RID: 924
		private static int int_3;

		// Token: 0x0400039D RID: 925
		private static int int_4;
	}
}
