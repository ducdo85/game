using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000015 RID: 21
	internal class Class23
	{
		// Token: 0x0600012E RID: 302 RVA: 0x000151E0 File Offset: 0x000133E0
		public void method_0()
		{
			int num = Class23.int_0;
			Class23.int_0 = 0;
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			string text = "HuyÒn Tinh Kho¸ng Th¹ch".ToLower();
			byte[] array = new byte[text.Length + 3];
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			GStruct49 gstruct = default(GStruct49);
			int num3 = 0;
			int num4;
			for (;;)
			{
				Thread.Sleep(300);
				num4 = Class81.smethod_3(Form1.gstruct49_0, num);
				bool flag3 = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25 || Form1.gstruct49_0[num4].byte_0[0] == 0;
				if (flag3)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num4];
				uint num5 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num7 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num8 = num7 + num6 * Class53.gstruct51_15.uint_0;
				int num9 = (int)Class22.smethod_30(num8 + Class53.gstruct51_55.uint_0, gstruct.int_137);
				int num10 = (int)Class22.smethod_30(num8 + Class53.gstruct51_50.uint_0, gstruct.int_137);
				int num11 = Class83.smethod_39(gstruct);
				bool flag4 = num9 == 10 || num9 == 21 || num10 == 0 || num11 <= 1;
				if (!flag4)
				{
					uint num12 = num5 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
					bool flag5 = !flag;
					if (flag5)
					{
						num4 = Class81.smethod_3(Form1.gstruct49_0, num);
						bool flag6 = 0 <= num4;
						if (flag6)
						{
							Form1.gstruct49_0[num4].bool_15 = true;
						}
						bool flag7 = gstruct.string_15 != null && gstruct.string_15 != string.Empty;
						if (flag7)
						{
							uint num13 = Class12.smethod_12(gstruct.string_15);
							bool flag8 = num13 > 0U;
							if (flag8)
							{
								Class70.smethod_117(gstruct, num13);
								Thread.Sleep(100);
							}
							Thread.Sleep(350);
						}
						long num14 = (long)((ulong)Class22.smethod_30(num12 + Class53.gstruct51_74.uint_0, gstruct.int_137));
						bool flag9 = num14 > 0L;
						if (flag9)
						{
							Class70.smethod_37(gstruct, (uint)num14);
						}
						flag = true;
						Class70.smethod_52(gstruct, "<color=yellow>Bat dau nang cap Huyen tinh...", 1);
					}
					uint num15 = num5 + Class53.gstruct51_97.uint_0;
					uint num16 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
					int num17 = -1;
					for (int i = 1; i < 10; i++)
					{
						bool flag10 = gstruct.byte_0[i] > 0;
						if (flag10)
						{
							num17 = i;
							break;
						}
					}
					bool flag11 = num17 < 0;
					if (flag11)
					{
						break;
					}
					bool flag12 = !flag2;
					if (flag12)
					{
						Class70.smethod_52(gstruct, Class10.smethod_2("<color=yellow>Nâng cấp huyền tinh " + num17.ToString() + " -> " + (num17 + 1).ToString()), 1);
						flag2 = true;
					}
					int num18 = 0;
					uint[] array4 = new uint[3];
					uint[] array5 = array4;
					int num19 = Class79.smethod_4(gstruct);
					int num20 = 0;
					uint num21 = 1U;
					uint num25;
					for (;;)
					{
						bool flag13 = (ulong)num21 < (ulong)((long)Class53.int_1) && num19 > num20;
						if (!flag13)
						{
							goto IL_831;
						}
						Class22.ReadProcessMemory(gstruct.int_137, num15 + (num21 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
						uint num22 = BitConverter.ToUInt32(array3, 0);
						bool flag14 = num22 > 0U;
						if (flag14)
						{
							uint num23 = num16 + num22 * Class53.gstruct51_106.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
							bool flag15 = BitConverter.ToInt32(array3, 0) == 0;
							if (flag15)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
								bool flag16 = array2[0] > 0;
								if (flag16)
								{
									num20++;
									uint num24 = num15 + num21 * 20U;
									Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
									num25 = (uint)array2[0];
									bool flag17 = num25 == 1U || num25 == 3U;
									if (flag17)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_108.uint_0, array2, 1, ref num2);
										bool flag18 = array2[0] == 6;
										if (flag18)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_111.uint_0, array2, 1, ref num2);
											int num26 = (int)array2[0];
											Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_112.uint_0, array2, 1, ref num2);
											int num27 = (int)array2[0];
											bool flag19 = num26 == 1 && num27 == 1;
											if (flag19)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_119.uint_0, array3, 4, ref num2);
												int num28 = BitConverter.ToInt32(array3, 0);
												bool flag20 = num28 > 0;
												if (flag20)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_114.uint_0, array2, 1, ref num2);
													bool flag21 = (int)array2[0] == num17;
													if (flag21)
													{
														Class22.ReadProcessMemory(gstruct.int_137, num23 + Class53.gstruct51_107.uint_0, array, array.Length, ref num2);
														string string_ = Class10.smethod_3(array).ToLower();
														bool flag22 = Class12.smethod_1(string_, text) >= 0;
														if (flag22)
														{
															bool flag23 = num28 != 1;
															if (flag23)
															{
																uint[] array6 = Class79.smethod_26(gstruct, 3U, 1U, 1U);
																bool flag24 = array6 != null;
																if (flag24)
																{
																	goto Block_32;
																}
															}
															else
															{
																bool flag25 = false;
																for (int j = 0; j < array5.Length; j++)
																{
																	bool flag26 = array5[j] == num22;
																	if (flag26)
																	{
																		flag25 = true;
																		break;
																	}
																}
																bool flag27 = !flag25;
																if (flag27)
																{
																	array5[num18] = num22;
																	num18++;
																	bool flag28 = num18 > 2;
																	if (flag28)
																	{
																		goto Block_45;
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
							}
						}
						num21 += 1U;
					}
					continue;
					Block_45:
					num3++;
					Class70.smethod_69(gstruct, array5[0], array5[1], array5[2]);
					bool flag29 = num3 < 5;
					if (flag29)
					{
						continue;
					}
					num3 = 0;
					string string_2 = Class83.smethod_20(gstruct);
					bool flag30 = Class12.smethod_2(string_2, "phi ph", false);
					if (flag30)
					{
						Class83.smethod_21(gstruct, "_open");
						bool flag31 = Class70.smethod_64(gstruct);
						if (flag31)
						{
							Thread.Sleep(800);
							Class45.smethod_11(gstruct);
						}
					}
					continue;
					Block_32:
					bool flag32 = num25 != 1U;
					if (flag32)
					{
						int num29 = 0;
						while (!Class12.bool_0 && Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) == 0U)
						{
							bool flag33 = num29 % 20 == 0;
							if (flag33)
							{
								uint num22;
								Class70.smethod_71(gstruct, num22, 1U, 89);
							}
							bool flag34 = num29 > 1500;
							if (flag34)
							{
								Class70.smethod_52(gstruct, Class10.smethod_2("Không thể tách vật phẩm !"), 1);
								bool flag35 = Class45.smethod_8(gstruct);
								if (flag35)
								{
									Class45.smethod_11(gstruct);
								}
								Thread.Sleep(300);
								num29 = 0;
							}
							Thread.Sleep(10);
							num29++;
						}
					}
					int num30 = 0;
					while (!Class12.bool_0 && Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) > 0U)
					{
						bool flag36 = num30 % 20 == 0;
						if (flag36)
						{
							uint[] array6;
							Class70.smethod_46(gstruct, array6[0], array6[1], 3U, array6[0], array6[1], 3U);
						}
						bool flag37 = num30 > 1500;
						if (flag37)
						{
							Class70.smethod_52(gstruct, Class10.smethod_2("Không thể đặt vật phẩm xuống !"), 1);
							bool flag38 = Class45.smethod_8(gstruct);
							if (flag38)
							{
								Class45.smethod_11(gstruct);
							}
							Thread.Sleep(300);
							num30 = 0;
						}
						Thread.Sleep(10);
						num30++;
					}
					continue;
					IL_831:
					num4 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag39 = 0 <= num4;
					if (flag39)
					{
						Form1.gstruct49_0[num4].byte_0[num17] = 0;
						flag2 = false;
					}
				}
			}
			Class70.smethod_52(gstruct, "<color=yellow>Ket thuc nang cap Huyen tinh !", 1);
			num4 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag40 = 0 <= num4;
			if (flag40)
			{
				bool flag41 = Class45.smethod_8(gstruct);
				if (flag41)
				{
					Class45.smethod_11(gstruct);
				}
				Form1.gstruct49_0[num4].byte_0 = new byte[11];
				Form1.gstruct49_0[num4].byte_0[10] = 1;
				Form1.gstruct49_0[num4].bool_15 = false;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00015AE4 File Offset: 0x00013CE4
		public void method_1()
		{
			int num = Class23.int_0;
			Class23.int_0 = 0;
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			int num3 = 0;
			int num4 = -1;
			int int_ = 0;
			long long_ = 0L;
			uint num5 = 0U;
			uint num6 = 0U;
			uint num7 = 0U;
			int num8 = 0;
			byte[] array = new byte[4];
			GStruct49 gstruct = default(GStruct49);
			int num9;
			for (;;)
			{
				IL_55E:
				num2--;
				Thread.Sleep(200);
				bool flag3 = num2 <= 0;
				if (flag3)
				{
					num9 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag4 = Class12.bool_0 || num9 < 0;
					if (flag4)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num9];
					bool flag5 = !gstruct.bool_25 || (num4 != -1 && num4 != gstruct.int_26);
					if (flag5)
					{
						break;
					}
					bool flag6 = flag;
					if (flag6)
					{
						bool flag7 = !gstruct.bool_6;
						if (flag7)
						{
							break;
						}
					}
					else
					{
						Form1.gstruct49_0[num9].bool_6 = true;
						num4 = gstruct.int_26;
						Class70.smethod_52(gstruct, Class10.smethod_2("<color=yellow>Bắt đầu chế tạo Huyền tinh..."), 1);
						flag = true;
					}
					int_ = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					num2 = 10;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num8);
				uint num10 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num8);
				uint num11 = BitConverter.ToUInt32(array, 0);
				uint num12 = num10 + Class53.gstruct51_97.uint_0;
				uint[] array2 = new uint[3];
				int num13 = Class79.smethod_4(gstruct);
				int num14 = 0;
				uint num15 = 1U;
				while ((ulong)num15 < (ulong)((long)Class53.int_1))
				{
					bool flag8 = array2[0] == 0U || array2[1] == 0U || array2[2] == 0U;
					if (!flag8)
					{
						bool flag9 = num5 == array2[0] && num6 == array2[1] && num7 == array2[2];
						if (flag9)
						{
							num3++;
							string string_ = Class83.smethod_20(gstruct);
							bool flag10 = Class12.smethod_2(string_, "phi ph", false);
							if (flag10)
							{
								Class83.smethod_21(gstruct, "0K..");
								flag2 = Class70.smethod_64(gstruct);
								Thread.Sleep(300);
							}
							else
							{
								bool flag11 = !Class32.smethod_0(int_) && Class12.smethod_28(long_) > 600L;
								if (flag11)
								{
									bool flag13;
									bool flag12 = flag13 = (Class12.smethod_2(string_, "kh«ng ", false) && (Class12.smethod_2(string_, "TiÒn", false) || Class12.smethod_2(string_, "l­îng", false)));
									if (flag13)
									{
										Class83.smethod_21(gstruct, "0K..");
									}
									else
									{
										flag12 = (Class36.smethod_41(gstruct, false) < 1000U);
									}
									bool flag14 = flag12;
									if (flag14)
									{
										bool flag15 = !Class60.smethod_14(gstruct, true) && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
										if (flag15)
										{
											Class35.smethod_140(gstruct, 37, "®«ng|§«ng", null, false);
										}
										Thread.Sleep(300);
									}
									long_ = Class12.smethod_27();
								}
							}
							bool flag16 = num3 > 12;
							if (flag16)
							{
								goto Block_38;
							}
						}
						else
						{
							num5 = array2[0];
							num6 = array2[1];
							num7 = array2[2];
							num3 = 0;
						}
						Class70.smethod_67(gstruct, array2[0], array2[1], array2[2]);
						goto IL_55E;
					}
					bool flag17 = num13 <= num14;
					if (flag17)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct.int_137, num12 + (num15 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num8);
					uint num16 = BitConverter.ToUInt32(array, 0);
					bool flag18 = num16 > 0U;
					if (flag18)
					{
						uint num17 = num11 + num16 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num8);
						bool flag19 = BitConverter.ToInt32(array, 0) == 0;
						if (flag19)
						{
							Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_107.uint_0, array, 1, ref num8);
							bool flag20 = array[0] > 0;
							if (flag20)
							{
								num14++;
								uint num18 = num12 + num15 * 20U;
								Class22.ReadProcessMemory(gstruct.int_137, num18 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num8);
								uint num19 = (uint)array[0];
								bool flag21 = num19 == 3U || (num19 == 23U && Class23.int_1 > 0);
								if (flag21)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_108.uint_0, array, 1, ref num8);
									bool flag22 = array[0] == 0;
									if (flag22)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_110.uint_0, array, 1, ref num8);
										uint num20 = (uint)array[0];
										bool flag23 = (array2[0] == 0U && num20 == 3U) || (array2[1] == 0U && num20 == 9U) || (array2[2] == 0U && num20 == 4U);
										if (flag23)
										{
											uint num21 = num20;
											uint num22 = num21;
											if (num22 != 3U)
											{
												if (num22 != 4U)
												{
													array2[1] = num16;
												}
												else
												{
													array2[2] = num16;
												}
											}
											else
											{
												array2[0] = num16;
											}
										}
									}
								}
							}
						}
					}
					num15 += 1U;
				}
				break;
			}
			goto IL_566;
			Block_38:
			Class83.smethod_31(gstruct, "Khong the che tao Huyen tinh", true, 3U);
			IL_566:
			num9 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag24 = 0 <= num9;
			if (flag24)
			{
				Form1.gstruct49_0[num9].bool_6 = false;
				bool flag25 = flag2;
				if (flag25)
				{
					Class45.smethod_11(gstruct);
				}
				Class70.smethod_52(gstruct, Class10.smethod_2("<color=yellow>Kết thúc chế tạo !"), 1);
			}
		}

		// Token: 0x04000095 RID: 149
		public static int int_0 = 0;

		// Token: 0x04000096 RID: 150
		public static int int_1 = Class62.smethod_3("flagNguyenlieuBH", 0, "0");
	}
}
