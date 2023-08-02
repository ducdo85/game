using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000024 RID: 36
	internal class Class40
	{
		// Token: 0x06000269 RID: 617 RVA: 0x0005DA7C File Offset: 0x0005BC7C
		public static int smethod_0(GStruct49 gstruct49_0)
		{
			try
			{
				return Class40.smethod_1(gstruct49_0);
			}
			catch
			{
				Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
			}
			return 0;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0005DABC File Offset: 0x0005BCBC
		private static int smethod_1(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_32 * 4U, array, 1, ref num);
			bool flag = array[0] <= 0;
			int result;
			if (flag)
			{
				int int_ = gstruct49_0.int_136;
				int num2 = 0;
				int num3 = -1;
				bool flag2 = false;
				bool flag3 = false;
				string string_ = "Thæ ®Þa phï|Håi thµnh phï|ÍÁµØ·û";
				string text = "Chñ tiÖm t¹p hãa|T¹p Hãa|t¹p hãa";
				string[] array2 = text.Split(new char[]
				{
					'|'
				});
				int num4 = 0;
				bool flag4 = false;
				bool flag5 = false;
				bool flag6 = false;
				bool flag7 = false;
				long long_ = 0L;
				long long_2 = 0L;
				int num5 = -1;
				GStruct1[] array3 = null;
				for (;;)
				{
					Thread.Sleep(300);
					int num6 = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag8 = !Class12.bool_0 && num6 >= 0 && Form1.gstruct49_0[num6].bool_25;
					if (!flag8)
					{
						goto IL_7A3;
					}
					bool flag9 = Form1.int_53[0] != 0 && Form1.int_53[1] != 0;
					if (!flag9)
					{
						goto IL_79B;
					}
					try
					{
						array[0] = 1;
						Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_32 * 4U, array, 1, ref num);
						gstruct49_0 = Form1.gstruct49_0[num6];
					}
					catch
					{
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_13.uint_0, array, 4, ref num);
					uint num8 = BitConverter.ToUInt32(array, 0);
					uint num9 = num8 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
					uint num10 = BitConverter.ToUInt32(array, 0);
					uint num11 = num10 + num9;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_55.uint_0, array, 4, ref num);
					int num12 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_50.uint_0, array, 4, ref num);
					int num13 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
					int num14 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_43.uint_0, array, 4, ref num);
					int num15 = BitConverter.ToInt32(array, 0);
					int num16 = Class83.smethod_39(gstruct49_0);
					bool flag10 = num13 != 0 && num12 != 0 && num16 > 1;
					if (!flag10)
					{
						goto IL_793;
					}
					uint[] array4 = new uint[]
					{
						Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag11 = array4[0] == 0U || array4[1] == 0U;
					if (!flag11)
					{
						int num17 = Class79.smethod_32(gstruct49_0, string_, false, 3U);
						bool flag12 = num17 <= 0;
						if (!flag12)
						{
							goto IL_784;
						}
						bool flag13 = num12 != 10 && num12 != 21 && num15 <= 0;
						if (!flag13)
						{
							goto IL_77C;
						}
						int num18 = Class79.smethod_25(gstruct49_0, 3U);
						bool flag14 = num18 != 0;
						if (!flag14)
						{
							goto IL_774;
						}
						bool flag15 = Class60.smethod_9(num14) == null && Class43.smethod_0(num14) == 0;
						if (flag15)
						{
							bool flag16 = !flag6;
							if (!flag16)
							{
								break;
							}
							Class35.smethod_140(gstruct49_0, 1, "am", null, false);
							Thread.Sleep(300);
							flag6 = true;
						}
						else
						{
							int num19 = Form1.int_53[1];
							bool flag17 = !flag3;
							if (flag17)
							{
								Class45.smethod_11(gstruct49_0);
								flag3 = true;
							}
							bool flag18 = num19 > num18;
							if (flag18)
							{
								num19 = num18;
							}
							bool flag19 = num3 == num19 && 0 < num3;
							if (flag19)
							{
								Class45.smethod_11(gstruct49_0);
								num2 = 0;
								num3 = 0;
								flag2 = false;
							}
							else
							{
								int num20 = (int)Class36.smethod_41(gstruct49_0, false);
								bool flag20 = num20 < 2500;
								if (flag20)
								{
									uint num21 = Class36.smethod_41(gstruct49_0, true);
									bool flag21 = num21 > 0U;
									if (flag21)
									{
										bool flag22 = Form1.int_61[0] <= 0;
										if (flag22)
										{
											bool flag23 = num21 > 6000000U;
											if (flag23)
											{
												num21 = 6000000U;
											}
										}
										else
										{
											bool flag24 = (ulong)num21 > (ulong)((long)(Form1.int_61[1] * 10000));
											if (flag24)
											{
												num21 = (uint)(Form1.int_61[1] * 10000);
											}
										}
										Class70.smethod_37(gstruct49_0, num21);
										Thread.Sleep(300);
									}
								}
								bool flag25 = flag2;
								if (flag25)
								{
									bool flag26 = Class45.smethod_8(gstruct49_0);
									if (flag26)
									{
										flag5 = true;
										num3 = num19;
										Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_32 * 4U + 1U, array, 1, ref num);
										bool flag27 = array[0] == 0;
										if (flag27)
										{
											array[0] = 1;
											Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_32 * 4U + 1U, array, 1, ref num);
										}
										bool flag28 = num5 < 0 && array3 == null;
										if (flag28)
										{
											array3 = Class17.smethod_1(gstruct49_0);
											bool flag29 = array3 == null;
											if (flag29)
											{
												num5 = 0;
											}
											else
											{
												string text2 = "Thæ ®Þa phï".ToUpper();
												string text3 = "Thæ §Þa Phï".ToUpper();
												int num22 = -1;
												int num23 = 0;
												for (;;)
												{
													bool flag30 = num23 < array3.Length;
													if (!flag30)
													{
														goto IL_5F0;
													}
													string text4 = array3[num23].string_0.ToUpper().Trim();
													bool flag31 = 0 <= Class12.smethod_1(text4, text2) || 0 <= Class12.smethod_1(text4, text3);
													if (flag31)
													{
														num22 = array3[num23].int_0;
													}
													bool flag32 = !(text2 == text4) && !(text3 == text4);
													if (!flag32)
													{
														goto IL_5DE;
													}
													num23++;
												}
												IL_619:
												goto IL_61A;
												IL_5F0:
												bool flag33 = num5 < 0;
												if (flag33)
												{
													num5 = num22;
													bool flag34 = num5 < 0;
													if (flag34)
													{
														num5 = 0;
													}
												}
												goto IL_619;
												IL_5DE:
												num5 = array3[num23].int_0;
											}
											IL_61A:;
										}
										for (int i = 0; i < num19; i++)
										{
											Class70.smethod_41(gstruct49_0, num5);
											Thread.Sleep(300);
											bool flag35 = i % 3 != 0;
											if (!flag35)
											{
												string string_2 = Class52.smethod_2(gstruct49_0, false);
												bool flag36 = (Class12.smethod_1(string_2, "ho¶ng trèng") > 0 || Class12.smethod_1(string_2, "tói kh«ng") > 0) && Class79.smethod_25(gstruct49_0, 3U) == 0;
												if (flag36)
												{
													goto Block_44;
												}
												bool flag37 = Class12.smethod_1(string_2, "µng kh") <= 0 && (Class12.smethod_1(string_2, "iÒn") <= 0 || Class12.smethod_1(string_2, "kh«ng") <= 0);
												if (!flag37)
												{
													goto IL_6C7;
												}
											}
										}
									}
									else
									{
										flag2 = false;
										num2 = 0;
									}
								}
								else
								{
									int num24 = Class98.smethod_13(gstruct49_0, text, 3, false, -1, 80);
									bool flag38 = num24 <= 0;
									uint[] array5;
									if (flag38)
									{
										for (int j = 0; j < array2.Length; j++)
										{
											array5 = Class43.smethod_10(array4, num14, array2[j], false);
											bool flag39 = array5 == null;
											if (!flag39)
											{
												goto IL_7C6;
											}
										}
										goto Block_51;
									}
									array5 = Class98.smethod_19(gstruct49_0, num24);
									Class98.smethod_22(gstruct49_0, num24, 3);
									IL_7C6:
									Class86.smethod_8(gstruct49_0, -1);
									Thread.Sleep(100);
									bool flag40 = array5 != null;
									if (!flag40)
									{
										goto IL_C1B;
									}
									long num25 = Class60.smethod_18(array4, array5);
									bool flag41 = num25 > 22500L || num24 <= 0;
									if (flag41)
									{
										int num26 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
										array4 = new uint[]
										{
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										bool flag42 = !flag7 || Class12.smethod_28(long_) >= 8000L;
										if (flag42)
										{
											flag7 = false;
											uint[,] array6 = Class42.smethod_1(num26, array4, array5, "TAPHOA", false);
											bool flag43 = array6 != null;
											if (flag43)
											{
												Class60.smethod_29(gstruct49_0, false);
												num26 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
												for (int k = 0; k < 3; k++)
												{
													array4 = new uint[]
													{
														Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
														Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
													};
													bool flag44 = Class60.smethod_22(gstruct49_0, array6, array4, array5, num26, true, 0, false) <= 0;
													if (!flag44)
													{
														flag7 = true;
														long_ = Class12.smethod_27();
														break;
													}
													int num27 = (int)Class22.smethod_30(num11 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
													bool flag45 = num27 <= 0;
													if (!flag45)
													{
														goto IL_999;
													}
													Thread.Sleep(300);
												}
											}
										}
										array4 = new uint[]
										{
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										num25 = Class60.smethod_18(array4, array5);
										bool flag46 = num25 > 90000L;
										if (flag46)
										{
											Class60.smethod_29(gstruct49_0, false);
											bool flag47 = Class12.smethod_28(long_2) >= 3000L;
											if (flag47)
											{
												long_2 = Class12.smethod_27();
												bool flag48 = Class14.smethod_1(gstruct49_0, array5) <= 0;
												if (flag48)
												{
													Class60.smethod_12(gstruct49_0, true);
												}
											}
											continue;
										}
									}
									for (int l = 0; l < 10; l++)
									{
										Class70.smethod_61(gstruct49_0, array5);
										Thread.Sleep(300);
										array4 = new uint[]
										{
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										num25 = Class60.smethod_18(array4, array5);
										bool flag49 = num25 < 11250L;
										if (flag49)
										{
											break;
										}
									}
									num2++;
									bool flag50 = num2 > 10;
									if (flag50)
									{
										num2 = 0;
										Class60.smethod_12(gstruct49_0, true);
										Class60.smethod_10(gstruct49_0, "Dang tim Chu tiem tap hoa !");
									}
									else
									{
										bool flag51 = num24 <= 0;
										if (flag51)
										{
											num24 = Class98.smethod_13(gstruct49_0, text, 3, false, -1, 80);
											bool flag52 = num24 <= 0;
											if (flag52)
											{
												Class60.smethod_10(gstruct49_0, "Dang tim Chu tiem tap hoa !");
												continue;
											}
										}
										bool flag53 = flag4;
										if (flag53)
										{
											Class60.smethod_12(gstruct49_0, true);
											Class36.smethod_10(gstruct49_0, (uint)num24);
										}
										else
										{
											Class36.smethod_10(gstruct49_0, (uint)num24);
										}
										Thread.Sleep(800);
										bool flag54 = Class86.Class89.smethod_4(gstruct49_0);
										if (flag54)
										{
											Class86.Class89.smethod_5(gstruct49_0);
										}
										bool flag55 = 0 <= Class86.smethod_0(gstruct49_0);
										if (flag55)
										{
											flag2 = (Class86.smethod_6(gstruct49_0, "Giao dÞch", false, false, false, false) > 0);
										}
										num4++;
										bool flag56 = num4 > 3;
										if (flag56)
										{
											num4 = 0;
											flag4 = !flag4;
										}
										Thread.Sleep(300);
									}
								}
							}
						}
					}
				}
				int num28 = -2;
				goto IL_C47;
				Block_44:
				num28 = 1;
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
				goto IL_C47;
				IL_6C7:
				num28 = 1;
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
				goto IL_C47;
				Block_51:
				num28 = -3;
				goto IL_C47;
				IL_774:
				num28 = 3;
				goto IL_C47;
				IL_77C:
				num28 = 0;
				goto IL_C47;
				IL_784:
				num28 = (flag5 ? 1 : 2);
				goto IL_C47;
				IL_793:
				num28 = 0;
				goto IL_C47;
				IL_79B:
				num28 = 2;
				goto IL_C47;
				IL_7A3:
				num28 = 0;
				goto IL_C47;
				IL_999:
				num28 = 0;
				goto IL_C47;
				IL_C1B:
				num28 = -3;
				IL_C47:
				Class70.smethod_2(gstruct49_0, Class70.uint_32, 0, 4);
				bool flag57 = flag3;
				if (flag57)
				{
					Class45.smethod_11(gstruct49_0);
					bool flag58 = Form1.int_55 > 0 && Form1.int_57 > 0;
					if (flag58)
					{
						Class79.smethod_37(gstruct49_0, 0, 0, false);
					}
				}
				result = num28;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0005E770 File Offset: 0x0005C970
		public static void smethod_2()
		{
			int int_ = Class40.int_0;
			Class40.int_0 = 0;
			bool flag = false;
			bool flag2 = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag3 = Class12.bool_0 || flag2 || num < 0 || !Form1.gstruct49_0[num].bool_25 || !Form1.gstruct49_0[num].bool_51;
					if (flag3)
					{
						bool flag4 = 0 <= num;
						if (flag4)
						{
							Form1.gstruct49_0[num].bool_47 = false;
							Form1.gstruct49_0[num].bool_51 = false;
							Class70.smethod_52(Form1.gstruct49_0[num], "* MUA VAT PHAM KET THUC !", 1);
						}
						break;
					}
					bool flag5 = !flag;
					if (flag5)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_47;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_47 = true;
						Class70.smethod_52(Form1.gstruct49_0[num], "* BAT DAU MUA VAT PHAM", 1);
						flag = true;
					}
					Class40.smethod_3(int_);
					flag2 = true;
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0005E8AC File Offset: 0x0005CAAC
		private static void smethod_3(int int_2)
		{
			int num = 0;
			byte[] array = new byte[4];
			GStruct49 gstruct = default(GStruct49);
			Random random = new Random();
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = 0;
			int num6 = 0;
			string a = null;
			string string_ = string.Empty;
			bool flag = false;
			long long_ = 0L;
			bool flag2 = false;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			for (;;)
			{
				Thread.Sleep(300);
				int num10 = Class81.smethod_3(Form1.gstruct49_0, int_2);
				bool flag3 = Class12.bool_0 || num10 < 0 || !Form1.gstruct49_0[num10].bool_25 || !Form1.gstruct49_0[num10].bool_51;
				if (flag3)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num10];
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num11 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num12 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num13 = BitConverter.ToUInt32(array, 0);
				uint num14 = num13 + num12;
				Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num15 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_55.uint_0, array, 4, ref num);
				int num16 = BitConverter.ToInt32(array, 0);
				int num17 = Class83.smethod_39(gstruct);
				bool flag4 = num15 == 0 || num17 <= 1 || num16 == 0 || num16 == 10 || num16 == 21;
				if (!flag4)
				{
					uint[] array2 = new uint[]
					{
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num14 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					bool flag5 = array2[0] == 0U || array2[1] == 0U;
					if (!flag5)
					{
						bool flag6 = Form1.string_20 == null || Form1.string_20 == string.Empty;
						if (flag6)
						{
							string_ = "Ch­a cã tªn vËt phÈm cÇn mua";
						}
						else
						{
							bool flag7 = !(a != Form1.string_20) && num4 == Form1.int_71;
							if (!flag7)
							{
								Class45.smethod_21(gstruct);
								num3 = -1;
								num5 = 0;
								num6 = 0;
								num9 = 0;
								flag2 = (Form1.int_73[0] > 0);
								num7 = Form1.int_73[1];
								num8 = Class79.smethod_32(gstruct, Form1.string_20, true, 3U);
								string a2 = Form1.string_20.ToLower().Trim();
								bool flag8 = Form1.int_71 <= 0;
								if (flag8)
								{
									GStruct1[] array3 = Class17.smethod_1(gstruct);
									bool flag9 = array3 != null && array3.Length != 0;
									if (flag9)
									{
										for (int i = 0; i < array3.Length; i++)
										{
											string b = array3[i].string_0.ToLower().Trim();
											bool flag10 = a2 == b;
											if (flag10)
											{
												num3 = array3[i].int_0;
												a = Form1.string_20;
												num4 = Form1.int_71;
												break;
											}
										}
										goto IL_494;
									}
									string_ = "Ch­a më shop (t¹p hãa, ktc...)";
								}
								else
								{
									Struct23[] array4 = Class83.smethod_1(gstruct);
									bool flag11 = array4 != null;
									if (flag11)
									{
										int num18 = -1;
										GStruct1[] array5;
										int j;
										for (;;)
										{
											num18++;
											bool flag12 = array4.Length <= num18;
											if (flag12)
											{
												break;
											}
											Class70.smethod_26(gstruct, array4[num18].string_0);
											Thread.Sleep(300);
											Class70.smethod_27(gstruct);
											array5 = Class17.smethod_1(gstruct);
											bool flag13 = array5 == null || array5.Length == 0;
											if (!flag13)
											{
												for (j = 0; j < array5.Length; j++)
												{
													string b2 = array5[j].string_0.ToLower().Trim();
													bool flag14 = !(a2 == b2);
													if (!flag14)
													{
														goto IL_418;
													}
												}
											}
										}
										IL_481:
										goto IL_494;
										IL_418:
										num3 = array5[j].int_0;
										num5 = array5[j].int_1;
										a = Form1.string_20;
										num4 = Form1.int_71;
										num2 = array4[num18].int_0 - array4[0].int_0;
										goto IL_481;
									}
									string_ = "H·y më KTC lªn, n¬i cã b¸n vËt phÈm.";
								}
								goto IL_48F;
							}
							IL_494:
							bool flag15 = num3 >= 0;
							if (flag15)
							{
								bool flag16 = Form1.int_71 > 0 && num5 == 0 && !Form1.bool_5;
								if (flag16)
								{
									bool flag17 = num6 <= 0;
									if (flag17)
									{
										num6 = random.Next(100, 1000);
									}
									bool flag18 = gstruct.int_132 != num6;
									if (flag18)
									{
										bool flag19 = Class12.smethod_28(long_) > 15000L;
										if (flag19)
										{
											Class70.smethod_52(gstruct, string.Concat(new string[]
											{
												"MUA <color=yellow>",
												Form1.string_20,
												" <color>cÇn nhËp m· KTC lµ <color=yellow>",
												num6.ToString(),
												"<color> vµo auto (phÝa trªn cña nót <color=green>Dõng<color>). L­u ý: ®iÒu nµy cã thÓ g©y diss game nªn ph¶i c©n nh¾c kü."
											}), 1);
											long_ = Class12.smethod_27();
										}
										string_ = Form1.string_20 + " cÇn nhËp m· KTC lµ " + num6.ToString() + ". Xem H­íng dÉn ë tÇng sè kh¸c cña game.";
										goto IL_8B5;
									}
								}
								Class45.smethod_21(gstruct);
								int k = 0;
								uint num19 = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct.int_137);
								while (k < 3)
								{
									uint num20 = Class22.smethod_30(num19 + Class53.gstruct51_167.uint_0, gstruct.int_137);
									bool flag20 = num20 > 0U;
									if (flag20)
									{
										uint num21 = Class22.smethod_30(num20 + (uint)(k * 4), gstruct.int_137);
										bool flag21 = num21 != 0U && Class22.smethod_30(num21, gstruct.int_137) > 0U;
										if (flag21)
										{
											Class70.smethod_12(gstruct.int_137, gstruct.uint_55);
											Thread.Sleep(100);
										}
									}
									k++;
								}
								bool flag22 = false;
								int num22 = Class79.smethod_4(gstruct);
								for (int l = 1; l < 60; l++)
								{
									int num23 = Class79.smethod_4(gstruct);
									bool flag23 = Form1.int_71 <= 0;
									if (flag23)
									{
										Class70.smethod_41(gstruct, num3);
									}
									else
									{
										Class70.smethod_28(gstruct, num3, num2 + Form1.int_5);
									}
									k = 0;
									int num24 = 30;
									while (k < num24)
									{
										bool flag24 = Class79.smethod_4(gstruct) == num23;
										if (!flag24)
										{
											num7--;
											num9 = 0;
											break;
										}
										Thread.Sleep(10);
										k++;
									}
									bool flag25 = flag2 && num7 <= 0;
									if (flag25)
									{
										Class45.smethod_21(gstruct);
										int num25 = Class79.smethod_32(gstruct, Form1.string_20, true, 3U);
										int num26 = num25 - num8;
										num7 = Form1.int_73[1] - num26;
										bool flag26 = num7 <= 0;
										if (flag26)
										{
											flag22 = true;
											break;
										}
									}
									bool flag27 = l % 7 != 0 && k < num24;
									if (!flag27)
									{
										bool flag28 = Class79.smethod_4(gstruct) == num22;
										if (flag28)
										{
											num9++;
											bool flag29 = num9 > 3;
											if (flag29)
											{
												flag22 = true;
												break;
											}
										}
										num10 = Class81.smethod_3(Form1.gstruct49_0, int_2);
										bool flag30 = Class12.bool_0 || num10 < 0 || !Form1.gstruct49_0[num10].bool_25 || !Form1.gstruct49_0[num10].bool_51;
										if (flag30)
										{
											return;
										}
										uint num27 = Class22.smethod_30(num19 + Class53.gstruct51_167.uint_0, gstruct.int_137);
										bool flag31 = num27 > 0U;
										if (flag31)
										{
											uint num28 = Class22.smethod_30(num27, gstruct.int_137);
											bool flag32 = num28 != 0U && Class22.smethod_30(num28, gstruct.int_137) > 0U;
											if (flag32)
											{
												Class70.smethod_12(gstruct.int_137, gstruct.uint_55);
												break;
											}
										}
									}
								}
								bool flag33 = Form1.int_72 > 0 && (!flag || Class79.smethod_4(gstruct) != num22);
								if (flag33)
								{
									k = 0;
									Class70.smethod_2(gstruct, Class70.uint_21, 3, 4);
									while (!Class12.bool_0 && Class70.smethod_3(gstruct, Class70.uint_21, 4) == 3 && k < 3000)
									{
										Thread.Sleep(10);
										k++;
									}
								}
								bool flag34 = !flag22;
								if (flag34)
								{
									flag = true;
									continue;
								}
								break;
							}
							else
							{
								string_ = "Kh«ng thÊy <" + Form1.string_20 + "> trong shop";
							}
						}
						IL_8B5:
						byte[] array6 = Class12.smethod_46(string_, true);
						for (int m = 0; m < 10; m++)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_251.uint_0, array6, array6.Length, ref num);
							Thread.Sleep(100);
						}
						continue;
						IL_48F:
						goto IL_8B5;
					}
				}
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0005F1C4 File Offset: 0x0005D3C4
		public static void smethod_4()
		{
			int int_ = Class40.int_1;
			Class40.int_1 = 0;
			bool flag = false;
			bool flag2 = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag3 = Class12.bool_0 || flag2 || num < 0 || !Form1.gstruct49_0[num].bool_25 || !Form1.gstruct49_0[num].bool_53;
					if (flag3)
					{
						bool flag4 = 0 <= num;
						if (flag4)
						{
							Form1.gstruct49_0[num].bool_52 = false;
							Form1.gstruct49_0[num].bool_53 = false;
							Class70.smethod_52(Form1.gstruct49_0[num], "* SU DUNG KET THUC !", 1);
						}
						break;
					}
					bool flag5 = !flag;
					if (flag5)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_52;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_52 = true;
						Class70.smethod_52(Form1.gstruct49_0[num], "* SU DUNG ITEM", 1);
						flag = true;
					}
					Class40.smethod_5(int_);
					flag2 = true;
				}
				catch
				{
				}
				Thread.Sleep(150);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0005F300 File Offset: 0x0005D500
		public static void smethod_5(int int_2)
		{
			uint num = 1U;
			int num2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[60];
			GStruct49 gstruct = default(GStruct49);
			int num3 = 0;
			int num4 = 0;
			int num5 = -1;
			int num6 = 0;
			for (;;)
			{
				num3--;
				Thread.Sleep(40);
				bool flag = num3 <= 0;
				if (flag)
				{
					num4 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag2 = Class12.bool_0 || num4 < 0;
					if (flag2)
					{
						break;
					}
					num3 = 8;
				}
				gstruct = Form1.gstruct49_0[num4];
				bool flag3 = !gstruct.bool_25 || !gstruct.bool_53;
				if (flag3)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num2);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num2);
				uint num8 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
				string b = Form1.string_20.Trim().ToLower();
				int num9 = Class79.smethod_4(gstruct);
				bool flag4 = num9 <= 0;
				if (flag4)
				{
					break;
				}
				bool flag5 = Form1.int_73[0] > 0 && num6 <= 0;
				if (flag5)
				{
					int num10 = Class79.smethod_32(gstruct, Form1.string_20, true, 3U);
					bool flag6 = num5 < 0;
					if (flag6)
					{
						num5 = num10;
					}
					int num11 = num5 - num10;
					bool flag7 = num11 > Form1.int_73[1];
					if (flag7)
					{
						break;
					}
					num6 = Form1.int_73[1] - num11;
					bool flag8 = num6 <= 0;
					if (flag8)
					{
						break;
					}
				}
				int num12 = 0;
				uint num13 = num;
				uint num14;
				int num17;
				int num18;
				int num19;
				for (;;)
				{
					bool flag9 = (ulong)num13 >= (ulong)((long)Class53.int_1) || num9 <= num12;
					if (flag9)
					{
						return;
					}
					num14 = num7 + num13 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num2);
					bool flag10 = BitConverter.ToInt32(array, 0) == 0;
					if (flag10)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
						bool flag11 = array[0] > 0;
						if (flag11)
						{
							uint num15 = Class79.smethod_1(gstruct, num13);
							bool flag12 = num15 > 0U;
							if (flag12)
							{
								num12++;
								Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_108.uint_0, array, 4, ref num2);
								bool flag13 = BitConverter.ToInt32(array, 0) > 0;
								if (flag13)
								{
									uint num16 = num8 + num15 * 20U;
									Class22.ReadProcessMemory(gstruct.int_137, num16 + Class53.gstruct51_100.uint_0 - 8U, array, 4, ref num2);
									num17 = BitConverter.ToInt32(array, 0);
									bool flag14 = num17 == 3;
									if (flag14)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_107.uint_0, array3, array3.Length, ref num2);
										string a = Class10.smethod_3(array3).Trim().ToLower();
										bool flag15 = !(a != b);
										if (flag15)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num16 + Class53.gstruct51_100.uint_0 - 4U, array, 4, ref num2);
											num18 = BitConverter.ToInt32(array, 0);
											bool flag16 = num18 >= 0;
											if (flag16)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num16 + Class53.gstruct51_100.uint_0, array, 4, ref num2);
												num19 = BitConverter.ToInt32(array, 0);
												bool flag17 = num19 >= 0;
												if (flag17)
												{
													break;
												}
											}
										}
									}
								}
							}
						}
					}
					num13 += 1U;
				}
				int i = 0;
				while (i < 30)
				{
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_45 - 4U, array2, 1, ref num2);
					bool flag18 = array2[0] == 0;
					if (flag18)
					{
						break;
					}
					i++;
					Thread.Sleep(1);
				}
				Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_119.uint_0, array, 4, ref num2);
				int num20 = BitConverter.ToInt32(array, 0);
				int num21 = Class79.smethod_4(gstruct);
				bool flag19 = Form1.int_74 > 0;
				if (flag19)
				{
					Class45.smethod_10(gstruct);
				}
				Class70.smethod_43(gstruct, num13, num18, num19, num17);
				for (i = 0; i < 8; i++)
				{
					bool flag20 = num20 <= 0;
					if (flag20)
					{
						bool flag21 = Class79.smethod_4(gstruct) != num21;
						if (flag21)
						{
							break;
						}
					}
					else
					{
						Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_119.uint_0, array, 4, ref num2);
						bool flag22 = BitConverter.ToInt32(array, 0) != num20;
						if (flag22)
						{
							break;
						}
					}
					Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num2);
					bool flag23 = BitConverter.ToInt32(array, 0) != 0;
					if (flag23)
					{
						break;
					}
					Thread.Sleep(5);
				}
				bool flag24 = Form1.int_74 > 0;
				if (flag24)
				{
					Thread.Sleep(100);
					uint num22 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num23 = Class22.smethod_30(num22 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num24 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num25 = num24 + num23 * Class53.gstruct51_15.uint_0;
					bool flag25 = false;
					i = 0;
					while (i < 100)
					{
						int num26 = Class45.smethod_9(gstruct);
						byte[] array4 = Class12.smethod_46(num26.ToString(), true);
						Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_89.uint_0, array4, array4.Length, ref num2);
						bool flag26 = num26 <= 0;
						if (!flag26)
						{
							flag25 = true;
							break;
						}
						i++;
						Thread.Sleep(10);
					}
					i = 0;
					int num27 = -1;
					int num28 = 0;
					while (!Class12.bool_0 && flag25 && i < 1600)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num2);
						bool flag27 = BitConverter.ToInt32(array, 0) != 0;
						if (flag27)
						{
							break;
						}
						Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
						bool flag28 = array[0] == 0;
						if (flag28)
						{
							break;
						}
						bool flag29 = num20 > 0;
						if (flag29)
						{
							Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_119.uint_0, array, 4, ref num2);
							bool flag30 = BitConverter.ToInt32(array, 0) != num20;
							if (flag30)
							{
								break;
							}
						}
						int num26 = Class45.smethod_9(gstruct);
						num28 = ((num27 == num26) ? (num28 + 1) : 0);
						num27 = num26;
						flag25 = (0 < num26 && num28 < 30);
						byte[] array4 = Class12.smethod_46((num26 + 11).ToString(), true);
						Class22.WriteProcessMemory(gstruct.int_137, num25 + Class53.gstruct51_89.uint_0, array4, array4.Length, ref num2);
						i++;
						Thread.Sleep(10);
					}
					Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
					num20 = (int)array[0];
				}
				num = num13 + (uint)Convert.ToByte(num20 <= 0);
				bool flag31 = 0 <= num6;
				if (flag31)
				{
					num6--;
				}
			}
		}

		// Token: 0x04000153 RID: 339
		public static int int_0;

		// Token: 0x04000154 RID: 340
		public static int int_1;
	}
}
