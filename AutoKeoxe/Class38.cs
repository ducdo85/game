using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000022 RID: 34
	internal class Class38
	{
		// Token: 0x06000260 RID: 608 RVA: 0x000581D4 File Offset: 0x000563D4
		static Class38()
		{
			Class38.Struct16 @struct = new Class38.Struct16
			{
				int_0 = 223,
				string_0 = "VÖ binh",
				uint_0 = new uint[]
				{
					50433U,
					101080U
				}
			};
			uint[,] array = new uint[5, 2];
			Class11.smethod_4(array, 173639);
			@struct.uint_2 = array;
			@struct.uint_1 = new uint[]
			{
				50537U,
				101022U
			};
			@struct.int_1 = 130;
			Class38.struct16_0 = @struct;
			Class38.Struct16 struct2 = new Class38.Struct16
			{
				int_0 = Class38.int_0,
				string_0 = "d­îc|phu",
				uint_0 = new uint[]
				{
					52640U,
					104288U
				}
			};
			uint[,] array2 = new uint[5, 2];
			Class11.smethod_4(array2, 173732);
			struct2.uint_2 = array2;
			struct2.uint_1 = new uint[]
			{
				51803U,
				103870U
			};
			struct2.int_1 = 140;
			Class38.struct16_1 = struct2;
			Class38.Struct16 struct3 = new Class38.Struct16
			{
				int_0 = 222,
				string_0 = "VÖ binh",
				uint_0 = new uint[]
				{
					50433U,
					101080U
				}
			};
			uint[,] array3 = new uint[6, 2];
			Class11.smethod_4(array3, 173829);
			struct3.uint_2 = array3;
			struct3.uint_1 = new uint[]
			{
				50533U,
				100992U
			};
			struct3.int_1 = 130;
			Class38.struct16_2 = struct3;
			Class38.Struct16 struct4 = new Class38.Struct16
			{
				int_0 = Class38.int_0,
				string_0 = "d­îc|phu",
				uint_0 = new uint[]
				{
					42272U,
					93408U
				}
			};
			uint[,] array4 = new uint[9, 2];
			Class11.smethod_4(array4, 173930);
			struct4.uint_2 = array4;
			struct4.uint_1 = new uint[]
			{
				42447U,
				93736U
			};
			struct4.int_1 = 310;
			Class38.struct16_3 = struct4;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0005849C File Offset: 0x0005669C
		public static void smethod_0(int int_1)
		{
			GStruct49 gstruct = default(GStruct49);
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = -1;
			uint num8 = 0U;
			uint[] array = null;
			int num9 = 0;
			long num10 = 0L;
			long long_ = 0L;
			long num11 = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			int num12 = -1;
			int num13 = 0;
			int num14 = 0;
			int num15 = -1;
			int num16 = 0;
			bool flag3 = false;
			int num17 = 0;
			int num18 = 0;
			int num19 = -1;
			int[] array2 = new int[4];
			int num20 = 0;
			byte[] byte_ = new byte[4];
			byte[] array3 = new byte[4];
			bool flag4 = false;
			bool flag5 = false;
			int[] array4 = new int[10];
			for (int i = 0; i < array4.Length; i++)
			{
				array4[i] = 4;
			}
			for (;;)
			{
				Thread.Sleep(200);
				int num21 = Class81.smethod_3(Form1.gstruct49_0, int_1);
				bool flag6 = Class12.bool_0 || num21 < 0 || Form1.int_20 != 2 || Form1.int_24 != 1;
				if (flag6)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num21];
				bool flag7 = !gstruct.bool_25 || gstruct.bool_54 || gstruct.int_133[0] > 0 || gstruct.int_20[0] > 0;
				if (flag7)
				{
					break;
				}
				bool flag8 = !gstruct.bool_15 && Class70.smethod_3(gstruct, Class70.uint_48, 4) <= 0;
				if (flag8)
				{
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array4[0]);
					uint num22 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_13.uint_0, array3, 4, ref array4[1]);
					uint num23 = BitConverter.ToUInt32(array3, 0);
					uint num24 = num23 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array4[2]);
					uint num25 = BitConverter.ToUInt32(array3, 0);
					uint num26 = num25 + num24;
					Class22.ReadProcessMemory(gstruct.int_137, num26, array3, 4, ref array4[3]);
					uint num27 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_55.uint_0, array3, 4, ref array4[4]);
					int num28 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_50.uint_0, array3, 4, ref array4[5]);
					int num29 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array4[6]);
					int num30 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_43.uint_0, array3, 4, ref array4[7]);
					int num31 = BitConverter.ToInt32(array3, 0);
					int num32 = Class83.smethod_12(gstruct);
					bool flag9 = (gstruct.int_136 != Class76.gstruct49_0.int_136 && gstruct.int_136 != Class44.gstruct33_0.int_0) || (num32 != 1 && num32 != 2);
					if (flag9)
					{
						bool flag10 = num18 <= 0;
						if (flag10)
						{
							array2[0] = 0;
							array2[1] = 0;
							array2[2] = 0;
							array2[3] = 0;
						}
						num18 = 0;
						int num33 = Class83.smethod_39(gstruct);
						bool flag11 = num29 != 0 && num28 != 0 && num30 != 0 && num28 != 10 && num28 != 21 && num33 > 1;
						if (flag11)
						{
							uint[] array5 = new uint[]
							{
								Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							uint[] array6 = new uint[2];
							bool flag12 = array5[0] == 0U || array5[1] == 0U;
							if (!flag12)
							{
								bool flag13 = !flag4;
								if (flag13)
								{
									int num34 = 7;
									int j = 0;
									for (;;)
									{
										bool flag14 = j <= num34;
										if (!flag14)
										{
											goto IL_440;
										}
										bool flag15 = array4[j] == 0;
										if (flag15)
										{
											break;
										}
										j++;
									}
									continue;
									IL_440:
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num20);
									bool flag16 = array3[0] > 0;
									if (flag16)
									{
										flag = false;
										array3[0] = 0;
										Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num20);
									}
									bool flag17 = num15 != num30 || (num7 != Class44.gstruct33_0.int_4 && Form1.int_21 > 0);
									if (flag17)
									{
										bool flag18 = num17 > 0;
										if (flag18)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
										}
										num17 = 0;
										flag = false;
										flag2 = false;
										int num35 = 0;
										while (num15 != num30)
										{
											int num36 = Class83.smethod_39(gstruct);
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num20);
											num22 = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_13.uint_0, array3, 4, ref num20);
											num23 = BitConverter.ToUInt32(array3, 0);
											num24 = num23 * Class53.gstruct51_15.uint_0;
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num20);
											num25 = BitConverter.ToUInt32(array3, 0);
											num26 = num25 + num24;
											Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_50.uint_0, array3, 4, ref num20);
											num29 = BitConverter.ToInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num20);
											num30 = BitConverter.ToInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_43.uint_0, array3, 4, ref num20);
											num31 = BitConverter.ToInt32(array3, 0);
											Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
											num17 = 0;
											bool flag19 = num31 > 0 || num35 > 8 || (num36 != 0 && num36 != 1 && num29 > 0 && num30 > 0);
											if (flag19)
											{
												break;
											}
											num35++;
											Thread.Sleep(100);
										}
										num15 = num30;
										num7 = Class44.gstruct33_0.int_4;
									}
									else
									{
										bool flag20 = num12 != num31;
										if (flag20)
										{
											num5 = 0;
											array = null;
											int num37 = 0;
											while (num31 == 0 && num37 < 30 && num31 != num12)
											{
												Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num20);
												num22 = BitConverter.ToUInt32(array3, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_13.uint_0, array3, 4, ref num20);
												num23 = BitConverter.ToUInt32(array3, 0);
												num24 = num23 * Class53.gstruct51_15.uint_0;
												Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num20);
												num25 = BitConverter.ToUInt32(array3, 0);
												num26 = num25 + num24;
												Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_43.uint_0, array3, 4, ref num20);
												num31 = BitConverter.ToInt32(array3, 0);
												Thread.Sleep(10);
												num37++;
											}
											num12 = num31;
											bool flag21 = num31 <= 0;
											if (flag21)
											{
												Thread.Sleep(150);
												Class86.smethod_8(gstruct, -1);
												continue;
											}
										}
										int num38 = 600;
										bool flag22 = gstruct.int_98 > 0;
										if (flag22)
										{
											num38 = gstruct.int_99;
										}
										bool flag23 = gstruct.int_136 != Class44.gstruct33_0.int_0;
										if (flag23)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num20);
											gstruct.int_97 = BitConverter.ToInt32(array3, 0);
										}
										int num39 = gstruct.int_97;
										bool flag24 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
										if (flag24)
										{
											num39 = gstruct.int_96;
										}
										bool flag25 = num39 <= 0;
										if (flag25)
										{
											num39 = 500;
										}
										int num40 = Form1.int_23;
										bool flag26 = gstruct.int_136 != Class44.gstruct33_0.int_0;
										if (flag26)
										{
											bool flag27 = num39 <= 180 && num40 < Form1.int_51;
											if (flag27)
											{
												num40 = Form1.int_51;
											}
											bool flag28 = gstruct.int_131[0] > 0 && Form1.int_27 > 0 && num40 > 180;
											if (flag28)
											{
												num40 = 180;
											}
											bool flag29 = flag5;
											if (flag29)
											{
												bool flag30 = num31 > 0;
												if (flag30)
												{
													num40 = gstruct.gstruct48_0.int_9;
												}
												flag5 = false;
											}
										}
										uint[] array7 = array5;
										bool bool_ = false;
										bool flag31 = false;
										int num41 = 0;
										bool flag32 = num31 <= 0 || num30 != Class38.int_0;
										if (flag32)
										{
											bool flag33 = num30 == Class38.struct16_0.int_0 || num30 == Class38.struct16_2.int_0;
											if (flag33)
											{
												Class38.Struct16 @struct = Class38.struct16_0;
												bool flag34 = num30 == Class38.struct16_2.int_0;
												if (flag34)
												{
													@struct = Class38.struct16_2;
												}
												bool flag35 = Class60.smethod_18(array5, @struct.uint_1) > 90000L;
												if (flag35)
												{
													num++;
													bool flag36 = num <= 3;
													if (flag36)
													{
														for (j = 0; j < 3; j++)
														{
															array5 = new uint[]
															{
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															bool flag37 = Class60.smethod_18(array5, @struct.uint_1) >= 90000L;
															if (!flag37)
															{
																goto IL_2DB3;
															}
															Class60.smethod_22(gstruct, @struct.uint_2, array5, @struct.uint_1, @struct.int_0, false, 8000, false);
															num31 = (int)Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137);
															bool flag38 = num31 > 0;
															if (flag38)
															{
																break;
															}
														}
													}
													else
													{
														num = 0;
														bool flag39 = Class12.smethod_28(long_) > 6000L;
														if (flag39)
														{
															Class14.smethod_1(gstruct, @struct.uint_1);
															long_ = Class12.smethod_27();
														}
													}
													continue;
												}
												IL_2DB3:
												num = 0;
												int num42 = 0;
												while (!Class12.bool_0 && num42 < 50)
												{
													num30 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
													bool flag40 = num30 != @struct.int_0;
													if (flag40)
													{
														break;
													}
													array5 = new uint[]
													{
														Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													bool flag41 = Class60.smethod_18(array5, @struct.uint_1) < 12500L;
													if (flag41)
													{
														break;
													}
													Class70.smethod_61(gstruct, @struct.uint_1);
													Thread.Sleep(300);
													num42++;
												}
												for (int k = 0; k < 3; k++)
												{
													Class60.smethod_25(gstruct, @struct.int_1);
													Thread.Sleep(300);
													int num43 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
													bool flag42 = num43 != num30;
													if (flag42)
													{
														break;
													}
												}
												Thread.Sleep(600);
												Class86.smethod_8(gstruct, -1);
											}
											else
											{
												Class38.Struct16 struct2 = Class38.struct16_1;
												bool flag43 = Form1.int_25 > 0;
												if (flag43)
												{
													struct2 = Class38.struct16_3;
												}
												bool flag44 = num30 != struct2.int_0;
												if (flag44)
												{
													Class60.smethod_10(gstruct, "<color=yellow>Cong Thanh Chien Tam Tru...");
													Thread.Sleep(300);
												}
												else
												{
													bool flag45 = Form1.int_113 > 0 && gstruct.int_136 == Class44.gstruct33_0.int_0 && ((Form1.int_6 <= 0 && Form1.int_7 <= 0) || Class44.gstruct33_1.int_4 <= 0);
													if (flag45)
													{
														Class60.smethod_10(gstruct, "<color=pink>CTC Ac chÝnh ng­êi dïng tù ®iÒu khiÓn..");
														Thread.Sleep(300);
													}
													else
													{
														Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num20);
														int num44 = (int)array3[0];
														bool flag46 = num44 > 0;
														if (flag46)
														{
															bool value = false;
															bool flag47 = num31 == 0;
															if (flag47)
															{
																value = (Class91.smethod_0(gstruct, true, null) != 1);
															}
															array3[0] = Convert.ToByte(value);
															Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num20);
														}
														else
														{
															Class60.smethod_29(gstruct, false);
															bool flag48 = !flag || num3 < 0 || num3 != Class79.smethod_4(gstruct);
															if (flag48)
															{
																bool flag49 = !Form1.bool_4;
																if (flag49)
																{
																	num2++;
																	int num45 = Class38.smethod_1(gstruct);
																	bool flag50 = num45 <= 0 && num2 < 6;
																	if (flag50)
																	{
																		Class60.smethod_13(gstruct);
																		Thread.Sleep(300);
																		continue;
																	}
																}
																num2 = 0;
																flag = true;
																num3 = Class79.smethod_4(gstruct);
																uint num46 = num22 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
																uint num47 = Class22.smethod_30(num46 + Class53.gstruct51_74.uint_0, gstruct.int_137);
																bool flag51 = num47 == 0U;
																if (!flag51)
																{
																	bool flag52 = !flag2 && gstruct.string_15 != null && gstruct.string_15 != string.Empty;
																	if (flag52)
																	{
																		uint num48 = Class12.smethod_12(gstruct.string_15);
																		bool flag53 = num48 > 0U;
																		if (flag53)
																		{
																			Class70.smethod_117(gstruct, num48);
																			flag2 = true;
																			Thread.Sleep(300);
																		}
																	}
																	bool flag54 = Form1.int_61[0] <= 0;
																	if (flag54)
																	{
																		bool flag55 = num47 > 6000000U;
																		if (flag55)
																		{
																			num47 = 6000000U;
																		}
																	}
																	else
																	{
																		bool flag56 = (ulong)num47 > (ulong)((long)(Form1.int_61[1] * 10000));
																		if (flag56)
																		{
																			num47 = (uint)(Form1.int_61[1] * 10000);
																		}
																	}
																	Class70.smethod_37(gstruct, num47);
																	Thread.Sleep(100);
																}
															}
															else
															{
																num2 = 0;
																bool flag57 = Class60.smethod_18(array5, Class38.uint_1) <= 90000L;
																if (flag57)
																{
																	num = 0;
																	int num42 = 0;
																	while (!Class12.bool_0 && num42 < 50)
																	{
																		num30 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																		num31 = (int)Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137);
																		bool flag58 = num30 != struct2.int_0 || num31 > 0;
																		if (flag58)
																		{
																			break;
																		}
																		array5 = new uint[]
																		{
																			Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																			Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																		};
																		bool flag59 = Class60.smethod_18(array5, Class38.uint_1) < 12500L;
																		if (flag59)
																		{
																			break;
																		}
																		Class70.smethod_61(gstruct, Class38.uint_1);
																		Thread.Sleep(300);
																		num42++;
																	}
																	for (int l = 0; l < 3; l++)
																	{
																		Class60.smethod_25(gstruct, struct2.int_1);
																		Thread.Sleep(300);
																		int num49 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																		num31 = (int)Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137);
																		bool flag60 = num49 != num30 || num31 > 0;
																		if (flag60)
																		{
																			break;
																		}
																	}
																	Thread.Sleep(600);
																	Class86.smethod_8(gstruct, -1);
																}
																else
																{
																	bool flag61 = Class12.smethod_28(long_) > 6000L;
																	if (flag61)
																	{
																		Class14.smethod_1(gstruct, Class38.uint_1);
																		long_ = Class12.smethod_27();
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
											flag = false;
											bool flag62 = Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137) == 0U;
											if (!flag62)
											{
												bool flag63 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && (Class44.gstruct33_1.int_3 > 0 || Form1.int_22 > 0) && Class44.gstruct33_1.int_4 > 0 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0);
												bool flag64 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_6 > 0 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class44.gstruct33_0.int_4 == num30 && Class44.gstruct33_0.int_3 > 0;
												bool flag65 = !gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0);
												array5 = new uint[]
												{
													Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
													Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
												};
												bool flag66 = !flag64 || gstruct.int_136 == Class44.gstruct33_0.int_0;
												if (flag66)
												{
													bool flag67 = gstruct.int_68 != null && gstruct.int_68[0] > 0 && !FormMayphu.bool_3;
													if (flag67)
													{
														bool flag68 = num11 <= 0L || Class12.smethod_28(num11) >= 1000L;
														if (flag68)
														{
															uint[] array8 = Class60.smethod_26(gstruct, ref num4);
															bool flag69 = array8 != null;
															if (flag69)
															{
																num11 = 0L;
																long num50 = Class60.smethod_18(array5, array8);
																bool flag70 = num50 < 8000L;
																if (flag70)
																{
																	goto IL_2500;
																}
																bool flag71 = num50 < 15000L || num50 < (long)(gstruct.int_68[1] * gstruct.int_68[1]);
																if (flag71)
																{
																	bool flag72 = num28 <= 3 && num50 > 7500L;
																	if (flag72)
																	{
																		bool flag73 = num17 > 0;
																		if (flag73)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																		}
																		num17 = 0;
																		Class70.smethod_61(gstruct, array8);
																		Thread.Sleep(200);
																		goto IL_31DB;
																	}
																}
																else
																{
																	bool flag74 = num50 < 360000L;
																	if (flag74)
																	{
																		Class14.smethod_2(gstruct, false);
																		bool flag75 = num17 > 0;
																		if (flag75)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																		}
																		num17 = 0;
																		Class70.smethod_61(gstruct, array8);
																		Thread.Sleep(200);
																		continue;
																	}
																	bool flag76 = num50 < 1200000L;
																	if (flag76)
																	{
																		bool flag77 = Class12.smethod_28(long_) > 3000L;
																		if (flag77)
																		{
																			Class14.smethod_1(gstruct, array8);
																			long_ = Class12.smethod_27();
																		}
																		continue;
																	}
																}
															}
															else
															{
																num11 = Class12.smethod_27();
															}
														}
													}
													bool flag78 = flag63;
													if (flag78)
													{
														int num51 = FormMayphu.smethod_10(gstruct, ref long_, ref num5, ref array);
														bool flag79 = num51 <= 0;
														if (flag79)
														{
															Thread.Sleep(100);
															continue;
														}
														num28 = (int)Class22.smethod_30(num26 + Class53.gstruct51_55.uint_0, gstruct.int_137);
														bool flag80 = num28 < 3;
														if (flag80)
														{
															array5 = new uint[]
															{
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															bool flag81 = Class60.smethod_18(array5, Class44.gstruct33_1.uint_4) > 5625L;
															if (flag81)
															{
																bool flag82 = num17 > 0;
																if (flag82)
																{
																	Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																}
																num17 = 0;
																Class70.smethod_61(gstruct, Class44.gstruct33_1.uint_4);
																Thread.Sleep(150);
															}
														}
													}
												}
												else
												{
													array5 = new uint[]
													{
														Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
														Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
													};
													long num52 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
													bool flag83 = gstruct.int_130[0] > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0 && num31 == Class44.gstruct33_0.int_3 && num31 > 0;
													if (flag83)
													{
														int num53 = gstruct.int_130[1] + Form1.int_23;
														bool flag84 = num52 <= (long)(num53 * num53) && Class64.smethod_0(gstruct, Class44.gstruct33_0.uint_4, gstruct.int_130[1]) > 0;
														if (flag84)
														{
															goto IL_2F4B;
														}
													}
													bool flag85 = flag3 || num52 > (long)(num40 * num40);
													if (!flag85)
													{
														Class14.smethod_2(gstruct, false);
														int num54 = num6;
														num6 = 0;
														num5 = 0;
														bool flag86 = num31 > 0 && !gstruct.bool_22 && gstruct.int_93 == 1 && Form1.int_102 > 0 && (Form1.int_31 > 0 || Form1.int_30 > 0 || Form1.int_32 > 0) && Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137) > 0U;
														if (flag86)
														{
															Class60.smethod_30(gstruct);
														}
														bool flag87 = num10 <= 0L || Class12.smethod_28(num10) >= 1500L;
														if (flag87)
														{
															uint[] array9 = new uint[]
															{
																array5[0],
																array5[1]
															};
															bool flag88 = Class44.smethod_5(num27, ref array5, ref num8) > 0;
															if (flag88)
															{
																long num55 = Class60.smethod_18(array9, Class44.gstruct33_0.uint_4);
																long num56 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																bool flag89 = num56 <= (long)(num40 * num40);
																if (flag89)
																{
																	num10 = Class12.smethod_27();
																	bool flag90 = num17 > 0;
																	if (flag90)
																	{
																		Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																	}
																	num17 = 0;
																	Class44.smethod_6(gstruct, array5, Class44.gstruct33_0.uint_4, num55 <= 5625L);
																	goto IL_31DB;
																}
																bool flag91 = num54 > 0;
																if (flag91)
																{
																	uint[] uint_ = Class60.smethod_5(array5, Class44.gstruct33_0.uint_4, -100);
																	Class70.smethod_61(gstruct, uint_);
																	Thread.Sleep(120);
																}
																goto IL_303E;
															}
															else
															{
																num10 = 0L;
																bool flag92 = num17 == 0 && Class60.smethod_18(array9, Class44.gstruct33_0.uint_4) > (long)(Form1.int_23 * Form1.int_23);
																if (flag92)
																{
																	num9++;
																	bool flag93 = num9 > 3;
																	if (flag93)
																	{
																		Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
																		Thread.Sleep(150);
																		num9 = 0;
																	}
																}
																bool flag94 = Form1.int_27 > 0 && num31 > 0 && gstruct.int_131[0] > 0 && Class70.smethod_3(gstruct, Class70.uint_31, 4) == 0;
																if (flag94)
																{
																	Class70.smethod_2(gstruct, Class70.uint_31, 1, 4);
																}
															}
														}
														num5 = 0;
														array = null;
														array7 = Class44.gstruct33_0.uint_4;
														bool_ = true;
														goto IL_1728;
													}
													IL_303E:
													flag3 = (num52 > 40000L);
													Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
													num17 = 0;
													bool flag95 = array == null;
													if (flag95)
													{
														array = new uint[]
														{
															array5[0],
															array5[1]
														};
														num5 = 0;
													}
													bool flag96 = num5 > 6;
													if (flag96)
													{
														long num57 = Class60.smethod_18(array, array5);
														array = null;
														bool flag97 = num57 < 180000L;
														if (flag97)
														{
															Class14.smethod_2(gstruct, false);
															Class60.smethod_2(gstruct, array5, Class44.gstruct33_0.uint_4, 600);
															goto IL_31DB;
														}
														num5 = 0;
													}
													bool flag98 = num52 > (long)(Form1.int_101 * Form1.int_101);
													if (flag98)
													{
														Class60.smethod_29(gstruct, false);
													}
													bool flag99 = num52 >= 900000L || num6 >= 6;
													if (flag99)
													{
														bool flag100 = Class44.gstruct33_0.uint_4 != null && (!Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 3000L);
														if (flag100)
														{
															Class14.smethod_1(gstruct, Class44.gstruct33_0.uint_4);
															long_ = Class12.smethod_27();
															num5++;
															num6 = 0;
														}
														continue;
													}
													num6++;
													Class14.smethod_2(gstruct, false);
													Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
													Thread.Sleep(150);
													goto IL_31DB;
												}
												IL_2500:
												bool flag101 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
												if (flag101)
												{
													long num58 = Class12.smethod_28(long_3);
													bool flag102 = num58 < 300L;
													if (flag102)
													{
														continue;
													}
													bool flag103 = num58 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
													if (flag103)
													{
														Thread.Sleep(80);
														long_3 = Class12.smethod_27();
														continue;
													}
												}
												for (int m = 0; m < Class53.int_0; m++)
												{
													Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num20);
													bool flag104 = array3[0] == 0;
													if (flag104)
													{
														break;
													}
													Thread.Sleep(1);
												}
												bool bool_2 = gstruct.bool_22;
												if (bool_2)
												{
													bool flag105 = gstruct.int_136 != Class44.gstruct33_0.int_0;
													if (flag105)
													{
														Class60.smethod_29(gstruct, false);
													}
												}
												else
												{
													bool flag106 = gstruct.int_128[0] > 0 && gstruct.int_128[1] > 0 && gstruct.int_128[2] > 0;
													bool flag107 = gstruct.int_128[0] > 0 && gstruct.int_128[3] > 0 && gstruct.int_128[4] > 0;
													bool flag108 = gstruct.int_128[0] > 0 && gstruct.int_128[5] > 0 && gstruct.int_128[6] > 0;
													flag31 = ((flag106 || flag107 || flag108) && gstruct.string_23 == "DUONGMON");
													bool flag109 = FormDame.int_6 <= 0 || gstruct.int_126 != 0 || flag31;
													if (!flag109)
													{
														bool flag110 = flag65 || FormDame.int_10 > 0;
														if (flag110)
														{
															int num59 = 0;
															bool flag111 = FormDame.int_9 == 0;
															if (!flag111)
															{
																bool flag112 = Class44.gstruct33_0.int_8 == 1 || (flag63 && Class44.gstruct33_1.int_8 == 1);
																bool flag113 = FormDame.int_9 != 1;
																if (flag113)
																{
																	bool flag114 = FormDame.int_9 != 2 || flag112;
																	if (!flag114)
																	{
																		bool flag115 = num17 > 0;
																		if (flag115)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																		}
																		num17 = 0;
																		goto IL_2873;
																	}
																}
																else
																{
																	bool flag116 = flag112;
																	if (flag116)
																	{
																		goto IL_2883;
																	}
																	bool flag117 = FormDame.int_11 > 0;
																	if (!flag117)
																	{
																		bool flag118 = num17 > 0;
																		if (flag118)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																		}
																		num17 = 0;
																		goto IL_2873;
																	}
																}
																goto IL_172D;
																IL_2873:
																goto IL_2874;
															}
															IL_2883:
															uint num60 = 0U;
															uint[] uint_2 = null;
															uint[] array10 = null;
															bool flag119 = flag63;
															if (flag119)
															{
																uint num61 = Class44.gstruct33_1.uint_5 >> 16;
																uint num62 = Class44.gstruct33_1.uint_5 - (num61 << 16);
																uint_2 = Class83.smethod_11(Class44.gstruct33_1.uint_4, (int)num62, (int)num61);
																uint[] array11 = Class83.smethod_10(array5, uint_2);
																num60 = (array11[1] << 16) + array11[0];
																array10 = Class44.gstruct33_1.uint_4;
																Class83.smethod_7(gstruct, num60);
																Thread.Sleep(10);
															}
															else
															{
																bool flag120 = gstruct.int_136 != Class44.gstruct33_0.int_0 && gstruct.int_136 != Class76.gstruct49_0.int_136 && Class44.gstruct33_0.uint_5 > 0U;
																if (flag120)
																{
																	uint num63 = Class44.gstruct33_0.uint_5 >> 16;
																	uint num64 = Class44.gstruct33_0.uint_5 - (num63 << 16);
																	uint_2 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)num64, (int)num63);
																	uint[] array12 = Class83.smethod_10(array5, uint_2);
																	num60 = (array12[1] << 16) + array12[0];
																	array10 = Class44.gstruct33_0.uint_4;
																	Class83.smethod_7(gstruct, num60);
																	Thread.Sleep(10);
																}
															}
															Class60.smethod_30(gstruct);
															bool flag121 = gstruct.int_127[0] == 2;
															if (flag121)
															{
																Class60.smethod_0(gstruct.uint_4, gstruct.int_129, FormDame.int_12);
															}
															else
															{
																bool flag122 = gstruct.int_127[0] == 1;
																if (flag122)
																{
																	bool flag123 = gstruct.int_127[1] > 0 && gstruct.int_127[2] > 0;
																	bool flag124 = gstruct.int_127[3] > 0 && gstruct.int_127[4] > 0;
																	bool flag125 = !flag123 || flag124;
																	if (flag125)
																	{
																		bool flag126 = flag124 && !flag123;
																		if (flag126)
																		{
																			num59 = gstruct.int_127[4];
																		}
																		else
																		{
																			bool flag127 = flag123 && flag124;
																			if (flag127)
																			{
																				num59 = ((0 > num16 || num16 > 25) ? gstruct.int_127[4] : gstruct.int_127[2]);
																				bool flag128 = num16 > 35;
																				if (flag128)
																				{
																					num16 = 0;
																				}
																				num16++;
																			}
																		}
																	}
																	else
																	{
																		num59 = gstruct.int_127[2];
																	}
																}
																bool flag129 = num59 <= 0;
																if (flag129)
																{
																	num59 = Class77.smethod_13(gstruct);
																}
																bool flag130 = gstruct.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
																if (flag130)
																{
																	Class77.smethod_9(gstruct, null);
																}
																Class77.smethod_5(gstruct, num59, 6, 1);
																for (int n = 0; n < 3; n++)
																{
																	Class22.smethod_76(gstruct.uint_4, 117);
																	bool flag131 = n < 2;
																	if (flag131)
																	{
																		Thread.Sleep(60);
																	}
																}
															}
															bool flag132 = num60 != 0U && gstruct.int_136 != Class76.gstruct49_0.int_136;
															if (flag132)
															{
																bool flag133 = gstruct.int_95 <= 0;
																if (flag133)
																{
																	Class22.smethod_30(num26 + Class53.gstruct51_31.uint_0, gstruct.int_137);
																	int num65 = Class77.smethod_13(gstruct);
																	bool flag134 = num65 == 53 || num65 <= 1;
																	if (flag134)
																	{
																		goto IL_31DB;
																	}
																	bool flag135 = num65 <= 100;
																	if (flag135)
																	{
																	}
																}
																string string_ = Class83.smethod_20(gstruct);
																bool flag136 = Class12.smethod_2(string_, "iÓm qu¸ x", false);
																if (flag136)
																{
																	uint[] uint_3 = Class60.smethod_5(array10, uint_2, -1 * (Form1.int_23 - 50));
																	long num66 = Class60.smethod_18(array5, uint_3);
																	bool flag137 = num66 > 7000L;
																	if (flag137)
																	{
																		Class70.smethod_61(gstruct, uint_3);
																		Thread.Sleep(150);
																		Class83.smethod_21(gstruct, "0K..");
																	}
																}
															}
														}
														IL_2874:
														goto IL_2875;
													}
													IL_172D:
													bool flag138 = flag65;
													if (flag138)
													{
														bool flag139 = Class44.smethod_7(gstruct, ref num19) || Class83.smethod_12(gstruct) == 1;
														if (flag139)
														{
															Thread.Sleep(100);
															num17 = 0;
														}
														else
														{
															num30 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
															array5 = new uint[]
															{
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															uint[] uint_4 = array5;
															bool flag140 = flag64 && Class44.gstruct33_0.int_4 == num30 && Class44.gstruct33_0.int_3 > 0 && Class44.gstruct33_0.uint_4 != null;
															if (flag140)
															{
																uint_4 = Class44.gstruct33_0.uint_4;
																num38 += num40;
															}
															uint num67 = 0U;
															bool flag141 = Form1.int_33 > 0 && (flag63 || flag64);
															if (flag141)
															{
																bool flag142 = !flag63;
																if (flag142)
																{
																	bool flag143 = flag64 && Class44.gstruct33_0.int_4 == num30 && Class44.gstruct33_0.uint_3 != num27;
																	if (flag143)
																	{
																		num67 = Class44.gstruct33_0.uint_3;
																	}
																}
																else
																{
																	bool flag144 = Class44.gstruct33_1.int_4 == num30 && Class44.gstruct33_1.uint_3 != num27;
																	if (flag144)
																	{
																		num67 = Class44.gstruct33_1.uint_3;
																	}
																}
																bool flag145 = num67 == 0U && Form1.int_34 <= 0;
																if (flag145)
																{
																	goto IL_31DB;
																}
															}
															bool flag146 = gstruct.int_119 <= 0 || gstruct.int_3 == null;
															if (flag146)
															{
																bool flag147;
																flag65 = (flag147 = (!gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0)));
																if (flag147)
																{
																	int[,] array13 = Class7.smethod_5(gstruct, num67, num38, uint_4, null, false, false, false);
																	bool flag148 = array13 != null;
																	if (flag148)
																	{
																		bool flag149 = array13[0, 0] == -100;
																		if (flag149)
																		{
																			continue;
																		}
																		int num68 = 0;
																		int num70;
																		for (;;)
																		{
																			bool flag150 = array13[num68, 1] > 0;
																			if (!flag150)
																			{
																				goto IL_1AEB;
																			}
																			array6 = new uint[]
																			{
																				(uint)array13[num68, 4],
																				(uint)array13[num68, 5]
																			};
																			bool flag151 = !flag64;
																			if (flag151)
																			{
																				bool flag152 = Class60.smethod_18(array5, array6) > (long)(num39 * num39) && gstruct.int_95 <= 0;
																				if (!flag152)
																				{
																					goto IL_19F9;
																				}
																				bool flag153 = gstruct.int_88 != 1 || num68 != 0;
																				if (flag153)
																				{
																					break;
																				}
																				num68 = 1;
																			}
																			else
																			{
																				int num69 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																				num70 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																				bool flag154 = num69 - num39 > 0;
																				if (!flag154)
																				{
																					goto IL_1AE8;
																				}
																				bool flag155 = num70 > num69;
																				if (flag155)
																				{
																					int num71 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																					bool flag156 = num71 + (num69 - num39) <= num40 + 10;
																					if (flag156)
																					{
																						goto Block_194;
																					}
																				}
																				bool flag157 = gstruct.int_88 == 1 && num68 == 0;
																				if (!flag157)
																				{
																					goto IL_1AA3;
																				}
																				num68 = 1;
																			}
																		}
																		IL_1EC0:
																		goto IL_1EC6;
																		IL_1B1C:
																		int num72 = array13[num68, 0];
																		num41 = array13[num68, 1];
																		array13[num68, 2];
																		bool flag158 = Form1.int_50 > 0 && (num72 <= 0 || num72 == array2[0]) && array2[1] > 0 && array2[2] == num30 && array2[3] > 0;
																		if (flag158)
																		{
																			int num73 = array2[0];
																			int num74 = array2[1];
																			uint num75 = num25 + (uint)(num74 * (int)Class53.gstruct51_15.uint_0);
																			Class22.ReadProcessMemory(gstruct.int_137, num75 + Class53.gstruct51_50.uint_0, array3, 4, ref num20);
																			bool flag159 = BitConverter.ToInt32(array3, 0) > 0;
																			if (flag159)
																			{
																				Class22.ReadProcessMemory(gstruct.int_137, num75 + Class53.gstruct51_45.uint_0, array3, 4, ref num20);
																				long num76 = (long)BitConverter.ToInt32(array3, 0);
																				bool flag160 = num76 != 0L;
																				if (flag160)
																				{
																					Class22.ReadProcessMemory(gstruct.int_137, num75 + Class53.gstruct51_43.uint_0, array3, 4, ref num20);
																					bool flag161 = num73 <= 0 || BitConverter.ToInt32(array3, 0) > 0;
																					if (flag161)
																					{
																						array6 = new uint[]
																						{
																							Class22.smethod_30(num75 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																							Class22.smethod_30(num75 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																						};
																						long num77 = Class60.smethod_18(array5, array6);
																						bool flag162 = flag64;
																						if (flag162)
																						{
																							int num78 = (int)Math.Sqrt((double)num77);
																							int num79 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																							bool flag163 = num78 - num39 > 0;
																							if (flag163)
																							{
																								bool flag164 = num79 > num78;
																								if (flag164)
																								{
																									int num80 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
																									bool flag165 = num80 + (num78 - num39) <= num40 + 10;
																									if (flag165)
																									{
																										num72 = num73;
																										num41 = num74;
																									}
																								}
																							}
																							else
																							{
																								num72 = num73;
																								num41 = num74;
																							}
																						}
																						else
																						{
																							bool flag166 = num77 <= (long)(num39 * num39);
																							if (flag166)
																							{
																								num72 = num73;
																								num41 = num74;
																							}
																						}
																					}
																				}
																			}
																		}
																		array2[0] = num72;
																		array2[1] = num41;
																		array2[2] = num30;
																		array2[3] = 0;
																		bool flag167 = num41 <= 0;
																		if (flag167)
																		{
																			goto IL_1EC0;
																		}
																		array2[3] = 1;
																		num17 = 1;
																		num18 = 1;
																		Class60.smethod_30(gstruct);
																		for (int num81 = 0; num81 < Class53.int_0; num81++)
																		{
																			Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num20);
																			bool flag168 = array3[0] == 0;
																			if (flag168)
																			{
																				break;
																			}
																			Thread.Sleep(1);
																		}
																		bool flag169 = gstruct.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct, (uint)num41) <= 0;
																		if (flag169)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num20);
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num39), 4, ref num20);
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num20);
																		}
																		flag5 = (gstruct.gstruct48_0.int_0 > 0 && gstruct.gstruct48_0.int_1 > 0 && gstruct.gstruct48_0.int_8 > 0 && gstruct.gstruct48_0.int_9 > 0);
																		goto IL_1EC0;
																		IL_1AE9:
																		goto IL_1B1C;
																		IL_1AE8:
																		goto IL_1AE9;
																		IL_1AA3:
																		bool flag170 = num40 + num39 <= num70;
																		if (flag170)
																		{
																			bool flag171 = num17 > 0;
																			if (flag171)
																			{
																				Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																			}
																			num17 = 0;
																			goto IL_1EC0;
																		}
																		IL_19F9:
																		Block_194:
																		goto IL_1B1C;
																		IL_1AEB:
																		bool flag172 = num17 > 0;
																		if (flag172)
																		{
																			Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																		}
																		num17 = 0;
																	}
																	else
																	{
																		flag65 = false;
																	}
																	IL_1EC6:;
																}
																else
																{
																	flag65 = false;
																}
															}
															else
															{
																int[,] array13 = (gstruct.int_5 <= 0) ? Class7.smethod_6(gstruct, num67, num38, uint_4, null, false, false, false) : Class7.smethod_5(gstruct, num67, num38, uint_4, null, false, false, false);
																bool flag173 = array13 != null && array13[0, 0] >= 0;
																if (flag173)
																{
																	int num82 = -1;
																	int int_2 = Class44.gstruct33_0.int_4;
																	num17 = 0;
																	bool flag174 = false;
																	bool flag175 = false;
																	while (Class83.smethod_12(gstruct) != 1)
																	{
																		int num83 = 0;
																		int num84 = 400;
																		while (num83 <= 0)
																		{
																			num82++;
																			bool flag176 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num82 && gstruct.int_4 != null;
																			if (!flag176)
																			{
																				IL_327D:
																				bool flag177 = num17 > 0 || gstruct.int_6 > 0 || !flag174;
																				if (flag177)
																				{
																					bool flag178 = flag174 && num17 <= 0 && gstruct.int_6 > 0;
																					if (flag178)
																					{
																						Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																					}
																				}
																				else
																				{
																					long num85 = 0L;
																					array5 = new uint[]
																					{
																						Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																						Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																					};
																					num41 = -1;
																					bool flag179 = false;
																					num39 = gstruct.int_97;
																					bool flag180 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
																					if (flag180)
																					{
																						num39 = gstruct.int_96;
																					}
																					bool flag181 = num39 <= 0;
																					if (flag181)
																					{
																						num39 = 500;
																					}
																					for (int num86 = 0; num86 < array13.GetLength(0); num86++)
																					{
																						int num87 = array13[num86, 0];
																						int num88 = array13[num86, 1];
																						int num89 = num39;
																						bool flag182 = num88 <= 0;
																						if (!flag182)
																						{
																							uint num90 = num25 + (uint)(num88 * (int)Class53.gstruct51_15.uint_0);
																							Class22.ReadProcessMemory(gstruct.int_137, num90 + Class53.gstruct51_50.uint_0, array3, 4, ref num20);
																							bool flag183 = BitConverter.ToInt32(array3, 0) <= 0;
																							if (!flag183)
																							{
																								bool flag184 = num87 > 0;
																								if (flag184)
																								{
																									Class22.ReadProcessMemory(gstruct.int_137, num90 + Class53.gstruct51_43.uint_0, array3, 4, ref num20);
																									bool flag185 = BitConverter.ToInt32(array3, 0) <= 0;
																									if (flag185)
																									{
																										goto IL_36C4;
																									}
																								}
																								bool flag186 = flag179 && num87 <= 0 && num41 > 0;
																								if (flag186)
																								{
																									break;
																								}
																								Class22.ReadProcessMemory(gstruct.int_137, num90 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num20);
																								array6[0] = BitConverter.ToUInt32(array3, 0);
																								Class22.ReadProcessMemory(gstruct.int_137, num90 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num20);
																								array6[1] = BitConverter.ToUInt32(array3, 0);
																								long num91 = Class60.smethod_18(array5, array6);
																								bool flag187 = num41 > 0 && num85 < num91;
																								if (!flag187)
																								{
																									bool flag188 = flag64;
																									if (flag188)
																									{
																										int num92 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																										int num93 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																										int num94 = num92 - num40 + 10;
																										bool flag189 = num92 > num40 && num89 < num94 && (num93 > num92 || (num93 < num92 && num89 < num93));
																										if (flag189)
																										{
																											num89 = num94;
																										}
																									}
																									bool flag190 = num91 <= (long)(num89 * num89) || gstruct.int_95 > 0;
																									if (flag190)
																									{
																										bool flag191 = num87 > 0;
																										if (flag191)
																										{
																											flag179 = true;
																										}
																										num41 = num88;
																										num85 = num91;
																										num39 = num89;
																									}
																								}
																							}
																						}
																						IL_36C4:;
																					}
																					bool flag192 = num41 > 0;
																					if (flag192)
																					{
																						Class60.smethod_30(gstruct);
																						for (int num95 = 0; num95 < Class53.int_0; num95++)
																						{
																							Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num20);
																							bool flag193 = array3[0] == 0;
																							if (flag193)
																							{
																								break;
																							}
																							Thread.Sleep(1);
																						}
																						Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num20);
																						Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num39), 4, ref num20);
																						Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num20);
																					}
																				}
																				goto IL_31DB;
																			}
																			num83 = gstruct.int_3[num82, 0];
																			bool flag194 = num83 > 0;
																			if (flag194)
																			{
																				num84 = Class77.smethod_20(gstruct, num83, gstruct.int_3[num82, 1]);
																				break;
																			}
																		}
																		num28 = (int)Class22.smethod_30(num26 + Class53.gstruct51_55.uint_0, gstruct.int_137);
																		num29 = (int)Class22.smethod_30(num26 + Class53.gstruct51_50.uint_0, gstruct.int_137);
																		num31 = (int)Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, gstruct.int_137);
																		int num96 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
																		bool flag195 = num31 > 0 && num30 == num96 && num28 != 11 && num28 != 22 && num29 != 0;
																		if (!flag195)
																		{
																			bool flag196 = num17 > 0;
																			if (flag196)
																			{
																				Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																			}
																			num17 = 0;
																			goto IL_31DB;
																		}
																		for (int num97 = 0; num97 < array13.GetLength(0); num97++)
																		{
																			bool flag197 = !Class44.smethod_7(gstruct, ref num19) && Class83.smethod_12(gstruct) != 1;
																			if (!flag197)
																			{
																				Thread.Sleep(100);
																				num17 = 0;
																				goto IL_31DB;
																			}
																			int num72 = array13[num97, 0];
																			num41 = array13[num97, 1];
																			bool flag198 = num41 <= 0;
																			if (!flag198)
																			{
																				uint num98 = num25 + (uint)(num41 * (int)Class53.gstruct51_15.uint_0);
																				Class22.ReadProcessMemory(gstruct.int_137, num98 + Class53.gstruct51_50.uint_0, array3, 4, ref num20);
																				bool flag199 = BitConverter.ToInt32(array3, 0) <= 0;
																				if (!flag199)
																				{
																					bool flag200 = num72 > 0;
																					if (flag200)
																					{
																						Class22.ReadProcessMemory(gstruct.int_137, num98 + Class53.gstruct51_43.uint_0, array3, 4, ref num20);
																						bool flag201 = BitConverter.ToInt32(array3, 0) <= 0;
																						if (flag201)
																						{
																							goto IL_24AC;
																						}
																					}
																					flag174 = true;
																					bool flag202 = !flag175 || num72 > 0;
																					if (!flag202)
																					{
																						goto IL_327D;
																					}
																					bool flag203 = num72 > 0;
																					if (flag203)
																					{
																						flag175 = true;
																					}
																					bool flag204 = Class98.smethod_31(gstruct, num41, num83) != 0;
																					if (!flag204)
																					{
																						num39 = num84;
																						Class22.ReadProcessMemory(gstruct.int_137, num98 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num20);
																						array6[0] = BitConverter.ToUInt32(array3, 0);
																						Class22.ReadProcessMemory(gstruct.int_137, num98 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num20);
																						array6[1] = BitConverter.ToUInt32(array3, 0);
																						array5 = new uint[]
																						{
																							Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																							Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																						};
																						bool flag205 = flag64;
																						if (flag205)
																						{
																							array5 = new uint[]
																							{
																								Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																								Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																							};
																							long num99 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
																							bool flag206 = int_2 != Class44.gstruct33_0.int_4 || num99 > (long)(num40 * num40);
																							if (flag206)
																							{
																								Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
																								goto IL_31DB;
																							}
																							int num100 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array6));
																							int num101 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array6));
																							int num102 = num100 - num40 + 10;
																							bool flag207 = num100 > num40 && num39 < num102 && (num101 > num100 || (num101 < num100 && num39 < num101));
																							if (flag207)
																							{
																								num39 = num102;
																							}
																						}
																						bool flag208 = Class60.smethod_18(array5, array6) > (long)(num39 * num39) && gstruct.int_95 <= 0;
																						if (!flag208)
																						{
																							for (int num103 = 0; num103 < Class53.int_0; num103++)
																							{
																								Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num20);
																								bool flag209 = array3[0] == 0;
																								if (flag209)
																								{
																									break;
																								}
																								Thread.Sleep(1);
																							}
																							Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(num83), 4, ref num20);
																							Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num39), 4, ref num20);
																							Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num41), 4, ref num20);
																							Thread.Sleep(10);
																							num17 = 1;
																						}
																					}
																				}
																			}
																			IL_24AC:;
																		}
																	}
																	continue;
																}
															}
														}
													}
												}
												IL_2875:
												goto IL_31DB;
												IL_1728:
												goto IL_2500;
												IL_2F4B:
												bool flag210 = !gstruct.bool_58 || gstruct.int_83 <= 0;
												if (flag210)
												{
													continue;
												}
												bool flag211 = Form1.int_99 != 0;
												if (flag211)
												{
													bool flag212 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
													if (flag212)
													{
														Class36.smethod_54(gstruct, null, true, 10);
														bool flag213 = Class12.smethod_28(long_2) > gstruct.long_8;
														if (flag213)
														{
															Class36.smethod_55(gstruct);
															long_2 = Class12.smethod_27();
														}
													}
												}
												else
												{
													bool flag214 = num41 > 0 && Class12.smethod_28(long_2) > gstruct.long_8;
													if (flag214)
													{
														Class36.smethod_54(gstruct, array6, false, 10);
														Class36.smethod_55(gstruct);
														long_2 = Class12.smethod_27();
													}
												}
												continue;
												IL_31DB:
												bool flag215 = !flag65 && gstruct.int_136 != Class44.gstruct33_0.int_0 && Class36.smethod_58(gstruct, new int[]
												{
													0,
													1
												}) > 0U;
												if (flag215)
												{
													bool flag216 = num17 > 0;
													if (flag216)
													{
														Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
													}
													num17 = 0;
												}
												bool flag217 = flag31 && num41 <= 0;
												if (flag217)
												{
													FormDuongMon.smethod_0(gstruct, ref num13, array7, ref num14, bool_);
												}
												goto IL_2F4B;
											}
										}
									}
								}
								else
								{
									flag4 = false;
									Thread.Sleep(300);
								}
							}
						}
						else
						{
							bool flag218 = num33 <= 1;
							if (flag218)
							{
								flag2 = false;
							}
							flag4 = (num28 == 10 || num28 == 21);
							Thread.Sleep(60);
						}
					}
					else
					{
						bool flag219 = num17 > 0;
						if (flag219)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_72.uint_0, byte_, 4, ref num20);
						}
						bool flag220 = Form1.int_121 > 0;
						if (flag220)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num20);
						}
						num17 = 0;
						num18 = 0;
					}
				}
				else
				{
					flag = false;
				}
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0005BDB8 File Offset: 0x00059FB8
		public static int smethod_1(GStruct49 gstruct49_0)
		{
			bool flag = Class38.string_0 == null || Class38.string_0 == string.Empty || Class38.uint_0 == null || Class38.string_0[0] == '\0';
			if (!flag)
			{
				int int_ = gstruct49_0.int_136;
				int result = 0;
				int num = 0;
				int num2 = -1;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				byte[] array = new byte[4];
				byte[] array2 = new byte[4];
				GStruct1[] array3 = null;
				Class60.smethod_10(gstruct49_0, "Mua thuèc, xin chê chøt xÝu...");
				long long_ = 0L;
				int num9 = 0;
				int num10 = 0;
				int num11 = 0;
				int num12;
				uint num17;
				for (;;)
				{
					Thread.Sleep(300);
					num12 = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num12 < 0 || !Form1.gstruct49_0[num12].bool_25;
					if (flag2)
					{
						break;
					}
					gstruct49_0 = Form1.gstruct49_0[num12];
					bool flag3 = (gstruct49_0.int_71[0] > 0 && gstruct49_0.int_71[2] > 0) || (gstruct49_0.int_72[0] > 0 && gstruct49_0.int_72[2] > 0) || (gstruct49_0.int_73[0] > 0 && gstruct49_0.int_73[2] > 0);
					if (!flag3)
					{
						goto IL_830;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num8);
					uint num13 = BitConverter.ToUInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_13.uint_0, array2, 4, ref num8);
					uint num14 = BitConverter.ToUInt32(array2, 0);
					uint num15 = num14 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num8);
					uint num16 = BitConverter.ToUInt32(array2, 0);
					num17 = num16 + num15;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_55.uint_0, array2, 4, ref num8);
					int num18 = BitConverter.ToInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_50.uint_0, array2, 4, ref num8);
					int num19 = BitConverter.ToInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num8);
					int num20 = BitConverter.ToInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_43.uint_0, array2, 4, ref num8);
					int num21 = BitConverter.ToInt32(array2, 0);
					bool flag4 = num18 != 10 && num18 != 21;
					if (!flag4)
					{
						goto IL_82B;
					}
					bool flag5 = num19 != 0 && num18 != 0 && num20 != 0;
					if (flag5)
					{
						bool flag6 = num21 <= 0;
						if (!flag6)
						{
							goto IL_7FE;
						}
						bool flag7 = Class79.smethod_25(gstruct49_0, 3U) == 0;
						if (flag7)
						{
							goto Block_18;
						}
						bool flag8 = num3 == 0;
						if (flag8)
						{
							Class70.smethod_2(gstruct49_0, Class70.uint_32, 1, 4);
							Class22.WriteProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_72.uint_0, array, 4, ref num8);
							num3 = 1;
						}
						Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						bool flag9 = array4[0] == 0U || array4[1] == 0U;
						if (!flag9)
						{
							bool flag10 = Class60.smethod_18(array4, Class38.uint_0) > 90000L;
							if (!flag10)
							{
								goto IL_3D8;
							}
							bool flag11 = Class12.smethod_28(long_) > 4000L;
							if (flag11)
							{
								Class14.smethod_1(gstruct49_0, Class38.uint_0);
								long_ = Class12.smethod_27();
							}
						}
					}
					else
					{
						Thread.Sleep(300);
						num++;
						bool flag12 = num <= 3;
						if (!flag12)
						{
							goto IL_825;
						}
					}
				}
				return 0;
				Block_18:
				goto IL_C35;
				IL_3D8:
				int i = 0;
				while (!Class12.bool_0)
				{
					uint[] array4 = new uint[]
					{
						Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag13 = Class60.smethod_18(array4, Class38.uint_0) < 22500L;
					if (flag13)
					{
						break;
					}
					Class70.smethod_61(gstruct49_0, Class38.uint_0);
					Thread.Sleep(300);
					i++;
					bool flag14 = i <= 15;
					if (!flag14)
					{
						result = -3;
						Class60.smethod_12(gstruct49_0, true);
						goto IL_BD9;
					}
				}
				uint[] array5 = null;
				bool flag15 = num2 > 0;
				if (flag15)
				{
					string text = Class98.smethod_16(gstruct49_0, num2, ref array5, 30);
					bool flag16 = text == null || Class12.smethod_1(text, Class38.string_0) < 0;
					if (flag16)
					{
						num2 = 0;
						array5 = null;
					}
				}
				bool flag17 = num2 <= 0;
				if (flag17)
				{
					num2 = Class98.smethod_15(gstruct49_0, Class38.string_0, ref array5, 3, false, -1, null);
					bool flag18 = num2 <= 0;
					if (flag18)
					{
						result = -4;
						Class60.smethod_12(gstruct49_0, true);
						goto IL_BD9;
					}
				}
				for (;;)
				{
					for (i = 0; i < 10; i++)
					{
						bool flag19 = array5 == null;
						if (flag19)
						{
							break;
						}
						uint[] array4 = new uint[]
						{
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num17 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						bool flag20 = Class60.smethod_18(array4, array5) < 11250L;
						if (flag20)
						{
							break;
						}
						Class70.smethod_61(gstruct49_0, array5);
						Thread.Sleep(300);
					}
					for (;;)
					{
						IL_773:
						Class86.smethod_8(gstruct49_0, -1);
						Thread.Sleep(100);
						Class36.smethod_10(gstruct49_0, (uint)num2);
						Thread.Sleep(800);
						bool flag21 = 0 <= Class86.smethod_0(gstruct49_0);
						if (flag21)
						{
							Class86.smethod_6(gstruct49_0, "ua", false, false, false, false);
							Thread.Sleep(800);
						}
						bool flag22 = num4 == 0;
						if (flag22)
						{
							bool flag23 = gstruct49_0.string_15 != null && gstruct49_0.string_15 != string.Empty;
							if (flag23)
							{
								uint num22 = Class12.smethod_12(gstruct49_0.string_15);
								bool flag24 = num22 > 0U;
								if (flag24)
								{
									Class70.smethod_117(gstruct49_0, num22);
									Thread.Sleep(100);
								}
							}
							uint num13;
							uint num23 = num13 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
							long num24 = (long)((ulong)Class22.smethod_30(num23 + Class53.gstruct51_74.uint_0, gstruct49_0.int_137));
							bool flag25 = num24 > 0L;
							if (flag25)
							{
								bool flag26 = Form1.int_61[0] > 0;
								if (flag26)
								{
									bool flag27 = num24 > (long)(Form1.int_61[1] * 10000);
									if (flag27)
									{
										num24 = (long)(Form1.int_61[1] * 10000);
									}
								}
								else
								{
									bool flag28 = num24 > 6000000L;
									if (flag28)
									{
										num24 = 6000000L;
									}
								}
								Class70.smethod_37(gstruct49_0, (uint)num24);
							}
							num4 = 1;
						}
						i = 0;
						while (!Class45.smethod_8(gstruct49_0))
						{
							i++;
							Thread.Sleep(60);
							bool flag29 = i <= 10;
							if (!flag29)
							{
								num5++;
								bool flag30 = num5 < 2;
								if (flag30)
								{
									goto IL_773;
								}
								goto IL_771;
							}
						}
						goto Block_43;
					}
					IL_771:
					num5 = 0;
					num6++;
					bool flag31 = num6 < 2;
					if (!flag31)
					{
						goto IL_7BA;
					}
					num12 = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag32 = 0 <= num12;
					if (!flag32)
					{
						goto IL_7B9;
					}
					Class60.smethod_12(gstruct49_0, true);
				}
				Block_43:
				num7 = 2;
				bool flag33 = array3 == null;
				if (flag33)
				{
					array3 = Class17.smethod_1(gstruct49_0);
					bool flag34 = array3 == null;
					if (flag34)
					{
						result = -7;
						goto IL_BD9;
					}
				}
				num9 = 0;
				num10 = 0;
				goto IL_840;
				IL_7B9:
				IL_7BA:
				result = -6;
				goto IL_BD9;
				IL_7FE:
				result = 1;
				goto IL_828;
				IL_825:
				result = -1;
				IL_828:
				goto IL_82D;
				IL_82B:
				result = -1;
				IL_82D:
				goto IL_832;
				IL_830:
				result = 1;
				IL_832:
				goto IL_BD9;
				IL_840:
				num12 = Class81.smethod_3(Form1.gstruct49_0, int_);
				bool flag35 = !Class12.bool_0 && num12 >= 0 && Form1.gstruct49_0[num12].bool_25;
				if (!flag35)
				{
					goto IL_BD9;
				}
				gstruct49_0 = Form1.gstruct49_0[num12];
				num11 = -1;
				bool flag36 = num9 != 0;
				int[] array6;
				string text2;
				if (flag36)
				{
					bool flag37 = num9 != 1;
					if (flag37)
					{
						bool flag38 = num9 == 2;
						if (flag38)
						{
							goto IL_C35;
						}
						result = 1;
						goto IL_BD9;
					}
					else
					{
						array6 = gstruct49_0.int_72;
						text2 = gstruct49_0.string_12;
					}
				}
				else
				{
					array6 = gstruct49_0.int_71;
					text2 = gstruct49_0.string_11;
				}
				IL_904:
				bool flag39 = array6[0] > 0 && array6[2] > 0 && text2 != null && text2 != string.Empty;
				if (flag39)
				{
					text2 = text2.Trim();
					string object_ = text2.ToUpper();
					int num25 = -1;
					for (int j = 0; j < array3.Length; j++)
					{
						bool flag40 = 0 <= Class12.smethod_1(array3[j].string_0.ToUpper(), object_);
						if (flag40)
						{
							num25 = array3[j].int_0;
						}
						bool flag41 = text2 == array3[j].string_0.Trim();
						if (flag41)
						{
							num11 = array3[j].int_0;
							break;
						}
					}
					bool flag42 = num11 < 0;
					if (flag42)
					{
						num11 = num25;
						bool flag43 = num11 < 0;
						if (flag43)
						{
							num9++;
							goto IL_840;
						}
					}
					int num26 = Class79.smethod_31(gstruct49_0, text2, 3, false, false);
					int num27 = array6[2] - num26;
					bool flag44 = num27 > 0;
					if (flag44)
					{
						string text3 = string.Empty;
						uint num28 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
						uint num29 = Class22.smethod_30(num28 + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
						byte[] array7 = new byte[15];
						int num30 = Class79.smethod_4(gstruct49_0);
						for (int k = 0; k < num27; k++)
						{
							Class70.smethod_41(gstruct49_0, num11);
							Thread.Sleep(8 + Form1.int_112);
							bool flag45 = (k == 0 || k % 8 != 0) && k + 1 != num27;
							if (!flag45)
							{
								int num31 = Class79.smethod_4(gstruct49_0);
								bool flag46 = num31 == num30;
								if (flag46)
								{
									num10++;
									bool flag47 = num10 > 10;
									if (flag47)
									{
										result = 1;
										goto IL_BD9;
									}
								}
								else
								{
									num30 = num31;
									num10 = 0;
								}
								try
								{
									bool flag48 = Class12.bool_0 || !Form1.gstruct49_0[num12].bool_25;
									if (flag48)
									{
										goto IL_BD9;
									}
								}
								catch
								{
								}
								uint num32 = 0U;
								while (num32 < 2U)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + num32 * 4U, array, 4, ref num8);
									uint uint_ = BitConverter.ToUInt32(array, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array7, array7.Length, ref num8);
									text3 = Class10.smethod_3(array7);
									bool flag49 = !(text3 != string.Empty);
									if (flag49)
									{
										num32 += 1U;
									}
									else
									{
										Class52.smethod_0(gstruct49_0);
										bool flag50 = Class12.smethod_1(text3, "ho¶ng trèng") <= 0 || Class79.smethod_25(gstruct49_0, 3U) != 0;
										if (flag50)
										{
											break;
										}
										result = 1;
										goto IL_BD9;
									}
								}
							}
						}
						goto IL_840;
					}
				}
				num9++;
				goto IL_840;
				IL_BD9:
				Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
				bool flag51 = num7 > 0;
				if (flag51)
				{
					bool flag52 = Form1.int_55 > 0 && Form1.int_57 > 0;
					if (flag52)
					{
						Class79.smethod_37(gstruct49_0, 0, 0, num7 < 2);
					}
					Class45.smethod_11(gstruct49_0);
				}
				Class70.smethod_52(gstruct49_0, "Mua thuèc kÕt thóc !", 1);
				return result;
				IL_C35:
				array6 = gstruct49_0.int_73;
				text2 = gstruct49_0.string_13;
				goto IL_904;
			}
			Class60.smethod_10(gstruct49_0, Class10.smethod_2("<color=yellow>Không thể mua thuốc, bạn cần vào mục CTC Tam trụ để lấy tên hiệu thuốc..."));
			return 1;
		}

		// Token: 0x04000149 RID: 329
		public static string string_0 = Class62.smethod_6("TenHieuthuocTamtru", 0, "");

		// Token: 0x0400014A RID: 330
		public static uint[] uint_0 = new uint[]
		{
			Class62.smethod_4("ToadoHieuthuocTamtru_0", 0, "0"),
			Class62.smethod_4("ToadoHieuthuocTamtru_1", 0, "0")
		};

		// Token: 0x0400014B RID: 331
		public static uint[] uint_1 = new uint[]
		{
			Class62.smethod_4("ToadoCongTamtru_0", 0, "0"),
			Class62.smethod_4("ToadoCongTamtru_1", 0, "0")
		};

		// Token: 0x0400014C RID: 332
		public static int int_0 = 221;

		// Token: 0x0400014D RID: 333
		public static Class38.Struct16 struct16_0;

		// Token: 0x0400014E RID: 334
		public static Class38.Struct16 struct16_1;

		// Token: 0x0400014F RID: 335
		public static Class38.Struct16 struct16_2;

		// Token: 0x04000150 RID: 336
		public static Class38.Struct16 struct16_3;

		// Token: 0x020000EE RID: 238
		public struct Struct16
		{
			// Token: 0x04001233 RID: 4659
			public int int_0;

			// Token: 0x04001234 RID: 4660
			public string string_0;

			// Token: 0x04001235 RID: 4661
			public uint[] uint_0;

			// Token: 0x04001236 RID: 4662
			public uint[] uint_1;

			// Token: 0x04001237 RID: 4663
			public int int_1;

			// Token: 0x04001238 RID: 4664
			public uint[,] uint_2;
		}
	}
}
