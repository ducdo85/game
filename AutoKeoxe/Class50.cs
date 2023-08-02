using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200002F RID: 47
	internal class Class50
	{
		// Token: 0x060002EB RID: 747 RVA: 0x0007855C File Offset: 0x0007675C
		static Class50()
		{
			Class50.Struct20[] array = new Class50.Struct20[2];
			ref Class50.Struct20 ptr = ref array[0];
			Class50.Struct20 @struct = new Class50.Struct20
			{
				int_0 = 221,
				string_0 = "truyÒn tèng"
			};
			uint[,] array_ = new uint[8, 2];
			Class11.smethod_4(array_, 234434);
			@struct.uint_0 = array_;
			ptr = @struct;
			ref Class50.Struct20 ptr2 = ref array[1];
			Class50.Struct20 struct2 = new Class50.Struct20
			{
				int_0 = 539,
				string_0 = "DÞch tr¹m",
				string_1 = "Rêi khái"
			};
			uint[,] array_2 = new uint[4, 2];
			Class11.smethod_4(array_2, 234515);
			struct2.uint_0 = array_2;
			ptr2 = struct2;
			Class50.struct20_0 = array;
			uint[,] array_3 = new uint[6, 2];
			Class11.smethod_4(array_3, 234556);
			Class50.uint_0 = array_3;
			uint[,] array_4 = new uint[8, 2];
			Class11.smethod_4(array_4, 234613);
			Class50.uint_1 = array_4;
			uint[,] array_5 = new uint[8, 2];
			Class11.smethod_4(array_5, 234686);
			Class50.uint_2 = array_5;
			uint[,] array_6 = new uint[5, 2];
			Class11.smethod_4(array_6, 234759);
			Class50.uint_3 = array_6;
			uint[,] array_7 = new uint[10, 2];
			Class11.smethod_4(array_7, 234808);
			Class50.uint_4 = array_7;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000786B8 File Offset: 0x000768B8
		public static int smethod_0(GStruct49 gstruct49_0, uint[,] uint_5 = null)
		{
			int num = 0;
			byte[] array = new byte[4];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			long num5 = 0L;
			string string_ = "Xa phu|DÞch tr¹m|truyÒn tèng";
			string text = null;
			long num16;
			for (;;)
			{
				Thread.Sleep(300);
				bool bool_ = Class12.bool_0;
				if (bool_)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				bool flag = num != 4;
				if (!flag)
				{
					uint num6 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_13.uint_0, array, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array, 0);
					uint num8 = num7 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
					bool flag2 = num != 4;
					if (!flag2)
					{
						uint num9 = BitConverter.ToUInt32(array, 0);
						uint num10 = num9 + num8;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_55.uint_0, array, 4, ref num);
						int num11 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_50.uint_0, array, 4, ref num);
						int num12 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
						int num13 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_43.uint_0, array, 4, ref num);
						BitConverter.ToInt32(array, 0);
						int num14 = Class83.smethod_39(gstruct49_0);
						bool flag3 = num12 == 0 || num11 == 0 || num13 == 0 || num14 <= 1;
						if (flag3)
						{
							num2++;
							bool flag4 = num2 >= 6;
							if (flag4)
							{
								goto Block_8;
							}
						}
						else
						{
							num2 = 0;
							bool flag5 = uint_5 == null;
							if (flag5)
							{
								for (int i = 0; i < Class50.struct20_0.Length; i++)
								{
									bool flag6 = Class50.struct20_0[i].int_0 == num13;
									if (flag6)
									{
										uint_5 = Class50.struct20_0[i].uint_0;
										string_ = Class50.struct20_0[i].string_0;
										num4 = Class50.struct20_0[i].int_0;
										text = Class50.struct20_0[i].string_1;
									}
								}
							}
							bool flag7 = uint_5 != null;
							if (!flag7)
							{
								goto IL_4D4;
							}
							bool flag8 = num4 != 0;
							if (flag8)
							{
								bool flag9 = num13 != num4;
								if (flag9)
								{
									goto Block_13;
								}
							}
							else
							{
								num4 = num13;
							}
							uint[] array2 = new uint[]
							{
								Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							int num15 = Class60.smethod_20(uint_5, array2);
							bool flag10 = num15 >= 0;
							if (!flag10)
							{
								goto IL_4CF;
							}
							uint[] uint_6 = new uint[]
							{
								uint_5[num15, 0],
								uint_5[num15, 1]
							};
							num16 = Class60.smethod_18(array2, uint_6);
							bool flag11 = num16 > 300000L;
							if (flag11)
							{
								bool flag12 = Class12.smethod_28(num5) > 6000L;
								if (flag12)
								{
									bool flag13 = num5 > 0L;
									if (flag13)
									{
										goto Block_17;
									}
									Class60.smethod_29(gstruct49_0, false);
									Class14.smethod_1(gstruct49_0, uint_6);
									num5 = Class12.smethod_27();
								}
							}
							else
							{
								Class14.smethod_2(gstruct49_0, false);
								bool flag14 = num16 > 22500L;
								if (!flag14)
								{
									goto IL_3C4;
								}
								bool flag15 = num3 < 10;
								if (!flag15)
								{
									goto IL_3BC;
								}
								num3++;
								Class70.smethod_61(gstruct49_0, uint_6);
							}
						}
					}
				}
			}
			return 0;
			Block_8:
			return 0;
			Block_13:
			return 1;
			Block_17:
			return 2;
			IL_3BC:
			return 3;
			IL_3C4:
			bool flag16 = num16 > 7500L;
			if (flag16)
			{
				uint[] uint_6;
				Class70.smethod_61(gstruct49_0, uint_6);
				Thread.Sleep(450);
			}
			int num17 = Class98.smethod_13(gstruct49_0, string_, 3, false, -1, 80);
			bool flag17 = num17 > 0;
			if (flag17)
			{
				bool flag18 = false;
				for (;;)
				{
					int num18 = 0;
					byte[] bytes = BitConverter.GetBytes(num17);
					uint num10;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_72.uint_0, bytes, 4, ref num18);
					Thread.Sleep(300);
					for (int j = 0; j < 10; j++)
					{
						Thread.Sleep(150);
						bool flag19 = 0 <= Class86.smethod_0(gstruct49_0) && Class86.smethod_1(gstruct49_0, -1) > 0;
						if (flag19)
						{
							goto Block_23;
						}
					}
					bool flag20 = flag18;
					if (flag20)
					{
						goto Block_26;
					}
					flag18 = true;
				}
				Block_23:
				bool flag21 = text == null;
				if (flag21)
				{
					Class86.smethod_5(gstruct49_0, 0);
				}
				else
				{
					Class86.smethod_6(gstruct49_0, text, false, false, false, false);
				}
				return 1;
				Block_26:
				return -2;
			}
			return -1;
			IL_4CF:
			return 0;
			IL_4D4:
			return 0;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00078BB0 File Offset: 0x00076DB0
		private static uint[] smethod_1(int int_0, uint[] uint_5)
		{
			uint[] result = null;
			uint[,] array = null;
			for (int i = 0; i < Class43.gstruct25_0.Length; i++)
			{
				bool flag = int_0 != Class43.gstruct25_0[i].int_0;
				if (!flag)
				{
					GStruct22[] gstruct22_ = Class43.gstruct25_0[i].gstruct22_0;
					for (int j = 0; j < gstruct22_.Length; j++)
					{
						bool flag2 = gstruct22_[j].string_0 == "NgoaiThanh";
						if (flag2)
						{
							array = gstruct22_[j].uint_0;
							break;
						}
					}
					break;
				}
			}
			bool flag3 = array != null;
			if (flag3)
			{
				int num = Class60.smethod_20(array, uint_5);
				result = new uint[]
				{
					array[num, 0],
					array[num, 1]
				};
			}
			return result;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00078C94 File Offset: 0x00076E94
		public static int smethod_2(GStruct49 gstruct49_0, string string_0, uint[] uint_5 = null, uint[,] uint_6 = null, int int_0 = 0)
		{
			int result = 0;
			for (int i = 0; i < 6; i++)
			{
				bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_5, 4) <= 0;
				if (flag)
				{
					break;
				}
				Thread.Sleep(100);
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_5, 1, 4);
			try
			{
				result = Class50.smethod_3(gstruct49_0, string_0, uint_5, uint_6, int_0);
			}
			catch
			{
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
			return result;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00078D20 File Offset: 0x00076F20
		private static int smethod_3(GStruct49 gstruct49_0, string string_0, uint[] uint_5 = null, uint[,] uint_6 = null, int int_0 = 0)
		{
			string text = Class22.smethod_28(gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct49_0.int_137, 60);
			int num = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag = Class12.smethod_1(text, "iÓm b¸o d") > 0;
			bool flag2 = num == 333;
			bool flag3 = num == 933;
			bool flag4 = num == 977;
			bool flag5 = num == 977 && 0 <= text.IndexOf("Cas");
			int int_ = gstruct49_0.int_136;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			long long_ = 0L;
			long long_2 = 0L;
			uint[] array = null;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			int num5 = 0;
			string string_ = "D­îc th­¬ng";
			string string_2 = "Qu©n Nhu";
			uint[,] array2 = new uint[4, 2];
			Class11.smethod_4(array2, 231863);
			uint[,] array3 = array2;
			int num12;
			int[] array5;
			for (;;)
			{
				IL_B51:
				Thread.Sleep(300);
				int num6 = Class81.smethod_3(Form1.gstruct49_0, int_);
				bool flag9 = Class12.bool_0 || num6 < 0 || Class22.smethod_52(Form1.gstruct49_0[num6].process_0) || !Form1.gstruct49_0[num6].bool_25;
				if (flag9)
				{
					break;
				}
				gstruct49_0 = Form1.gstruct49_0[num6];
				uint num7 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num8 = Class22.smethod_30(num7 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num9 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num10 = num9 + num8;
				int num11 = (int)Class22.smethod_30(num10 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
				bool flag10 = num11 <= 0;
				if (!flag10)
				{
					goto IL_770;
				}
				num12 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				int num13 = (int)Class22.smethod_30(num10 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num14 = (int)Class22.smethod_30(num10 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				uint[] array4 = new uint[]
				{
					Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag11 = array4[0] == 0U || array4[1] == 0U;
				if (!flag11)
				{
					int num15 = Class83.smethod_39(gstruct49_0);
					bool flag12 = num14 != 0 && num13 != 0 && num13 != 10 && num13 != 21 && num12 != 0 && num15 > 1;
					if (!flag12)
					{
						goto IL_767;
					}
					bool flag13 = num == num12;
					if (!flag13)
					{
						goto IL_75F;
					}
					array5 = Class60.smethod_9(string_0);
					bool flag14 = array5 == null;
					if (flag14)
					{
						int num16 = Class98.smethod_13(gstruct49_0, "Xa phu", 3, !flag, -1, 80);
						bool flag15 = num16 <= 0;
						long num17;
						if (flag15)
						{
							bool flag16 = !flag2;
							if (flag16)
							{
								bool flag17 = flag4;
								if (flag17)
								{
									num16 = Class98.smethod_13(gstruct49_0, string_2, 3, false, -1, 80);
								}
							}
							else
							{
								num16 = Class98.smethod_13(gstruct49_0, string_, 3, false, -1, 80);
							}
							bool flag18 = num16 <= 0;
							if (flag18)
							{
								bool flag19 = !flag6 && uint_6 != null && (int_0 == 0 || int_0 == num12);
								if (flag19)
								{
									int length = uint_6.GetLength(0);
									uint[] array6 = new uint[]
									{
										uint_6[length - 1, 0],
										uint_6[length - 1, 1]
									};
									num17 = Class60.smethod_18(array4, array6);
									num11 = (int)Class22.smethod_30(num10 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
									bool flag20 = num17 > 60000L && num11 <= 0;
									if (flag20)
									{
										Class60.smethod_22(gstruct49_0, uint_6, null, array6, num12, true, 0, false);
										continue;
									}
									flag6 = true;
								}
								bool flag21 = uint_5 == null;
								if (flag21)
								{
									uint_5 = new uint[]
									{
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
								}
								array = Class43.smethod_10(uint_5, num12, "Xa phu", true);
								bool flag22 = array == null;
								if (flag22)
								{
									bool flag23 = flag2;
									if (flag23)
									{
										array = Class43.smethod_10(uint_5, num12, "HIEUTHUOC", true);
									}
									else
									{
										bool flag24 = !flag5;
										if (flag24)
										{
											bool flag25 = flag3;
											if (flag25)
											{
												array = new uint[]
												{
													53040U,
													117298U
												};
											}
											else
											{
												bool flag26 = flag4;
												if (flag26)
												{
													int num18 = 0;
													byte[] byte_ = new byte[4];
													Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, byte_, 4, ref num18);
													bool flag27 = Class10.smethod_3(byte_) == "Cæ L";
													if (flag27)
													{
														int num19 = Class60.smethod_20(array3, array4);
														array = new uint[]
														{
															array3[num19, 0],
															array3[num19, 1]
														};
													}
												}
											}
										}
										else
										{
											array = new uint[]
											{
												49472U,
												105888U
											};
										}
									}
									bool flag28 = array == null;
									if (flag28)
									{
										goto Block_34;
									}
								}
								long num20 = Class60.smethod_18(array4, array);
								bool flag29 = num20 > 90000L;
								if (flag29)
								{
									Class60.smethod_29(gstruct49_0, false);
									flag7 = false;
									uint[,] array7 = Class42.smethod_1(num12, array4, array, "XAPHU", true);
									bool flag30 = array7 != null;
									if (flag30)
									{
										flag7 = true;
										for (int i = 0; i < 3; i++)
										{
											array4 = new uint[]
											{
												Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
												Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
											};
											bool flag31 = Class60.smethod_22(gstruct49_0, array7, array4, array, num12, true, 0, false) > 0;
											if (flag31)
											{
												goto IL_7AD;
											}
											Thread.Sleep(300);
											num11 = (int)Class22.smethod_30(num10 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
											bool flag32 = num11 <= 0;
											if (!flag32)
											{
												goto IL_6B2;
											}
											Thread.Sleep(300);
										}
									}
									bool flag33 = Class12.smethod_28(long_) > 6000L;
									if (flag33)
									{
										int num21 = Class14.smethod_1(gstruct49_0, array);
										long_ = Class12.smethod_27();
										bool flag34 = num21 <= 0;
										if (flag34)
										{
											Class60.smethod_12(gstruct49_0, true);
										}
									}
									continue;
								}
								bool flag35 = num20 > 22500L;
								if (flag35)
								{
									Class70.smethod_61(gstruct49_0, array);
									Thread.Sleep(500);
								}
							}
						}
						IL_7AD:
						array4 = new uint[]
						{
							Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						bool flag36 = num16 <= 0;
						if (flag36)
						{
							num16 = Class98.smethod_13(gstruct49_0, "Xa phu", 3, !flag, -1, 80);
							bool flag37 = num16 <= 0 && flag2;
							if (flag37)
							{
								num16 = Class98.smethod_13(gstruct49_0, string_, 3, false, -1, 80);
							}
							bool flag38 = num16 <= 0;
							if (flag38)
							{
								goto Block_46;
							}
						}
						bool flag39 = array == null;
						if (flag39)
						{
							array = Class98.smethod_19(gstruct49_0, num16);
							bool flag40 = array == null;
							if (flag40)
							{
								goto Block_48;
							}
						}
						long num22 = 160000L;
						num17 = Class60.smethod_18(array4, array);
						bool flag41 = num17 <= num22;
						if (flag41)
						{
							bool flag42 = num17 > 0L;
							if (flag42)
							{
								int j = 0;
								while (j < 10)
								{
									array4 = new uint[]
									{
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									num17 = Class60.smethod_18(array4, array);
									bool flag43 = num17 <= 11250L;
									if (flag43)
									{
										break;
									}
									j++;
									Class70.smethod_61(gstruct49_0, array);
									Thread.Sleep(300);
								}
								num2 = 0;
								Class86.smethod_8(gstruct49_0, -1);
								Thread.Sleep(100);
								bool flag44 = flag8;
								if (flag44)
								{
									Class60.smethod_12(gstruct49_0, true);
									Class36.smethod_10(gstruct49_0, (uint)num16);
								}
								else
								{
									Class36.smethod_10(gstruct49_0, (uint)num16);
								}
								Thread.Sleep(300);
								int num23 = 0;
								while (Class86.smethod_0(gstruct49_0) < 0)
								{
									bool flag45 = Form1.int_85 > 0 && Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) > 0U;
									if (flag45)
									{
										string text2 = Class45.smethod_4(gstruct49_0);
										bool flag46 = text2 != null && text2 != string.Empty;
										if (flag46)
										{
											int num24 = Class12.smethod_10(text2, false, false);
											bool flag47 = num24 > 0;
											if (flag47)
											{
												Class45.smethod_5(gstruct49_0, num24.ToString(), true);
												Thread.Sleep(300);
											}
										}
									}
									num23++;
									Thread.Sleep(100);
									bool flag48 = num23 <= 10;
									if (!flag48)
									{
										num4++;
										bool flag49 = num4 <= 3;
										if (flag49)
										{
											Class60.smethod_12(gstruct49_0, true);
											goto IL_B51;
										}
										goto IL_7A4;
									}
								}
								bool flag50 = flag2 || flag3;
								if (flag50)
								{
									string_0 = "Rêi khái";
								}
								else
								{
									bool flag51 = flag4;
									if (flag51)
									{
										string_0 = "Rêi khái|X¸c nh";
									}
								}
								num2 = (int)Convert.ToByte(Class86.smethod_6(gstruct49_0, string_0, false, false, false, false) > 0);
								bool flag52 = num2 > 0;
								if (flag52)
								{
									break;
								}
								Class86.smethod_8(gstruct49_0, -1);
								bool flag53 = num5 != 0;
								if (flag53)
								{
									break;
								}
								bool flag54 = !flag;
								if (flag54)
								{
									bool flag55 = flag5;
									if (flag55)
									{
										string_0 = "hµnh thÞ|Thµnh §«";
									}
								}
								else
								{
									string_0 = "hµnh thÞ|hµnh ph|Thµnh §«";
								}
								num5++;
							}
							else
							{
								Class60.smethod_12(gstruct49_0, true);
							}
						}
						else
						{
							bool flag56 = !flag7 || num3 >= 3;
							if (flag56)
							{
								bool flag57 = Class12.smethod_28(long_2) > 3500L;
								if (flag57)
								{
									Class14.smethod_1(gstruct49_0, array);
									long_2 = Class12.smethod_27();
								}
							}
							else
							{
								num3++;
							}
						}
						continue;
						goto IL_7AD;
					}
					goto IL_733;
				}
			}
			goto IL_B59;
			Block_34:
			num2 = -2;
			goto IL_B59;
			IL_6B2:
			num2 = 2;
			goto IL_B59;
			IL_733:
			int num25 = Class60.int_0[array5[0], array5[1]];
			num2 = ((num12 == num25) ? 1 : Class50.smethod_5(gstruct49_0, num25));
			goto IL_B59;
			IL_75F:
			num2 = 1;
			goto IL_B59;
			IL_767:
			num2 = -2;
			goto IL_B59;
			IL_770:
			num2 = 2;
			goto IL_B59;
			IL_7A4:
			num2 = -3;
			goto IL_B59;
			Block_46:
			return -3;
			Block_48:
			return -3;
			IL_B59:
			bool flag58 = Class70.smethod_3(gstruct49_0, Class70.uint_20, 4) > 0;
			if (flag58)
			{
				uint num7 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num8 = Class22.smethod_30(num7 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num9 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num10 = num9 + num8;
				int num26 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				int num27 = (int)Class22.smethod_30(num10 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				int num28 = (int)Class22.smethod_30(num10 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				int num29 = Class83.smethod_39(gstruct49_0);
				int num30 = (int)Class22.smethod_30(num10 + Class53.gstruct51_44.uint_0, gstruct49_0.int_137);
				bool flag59 = num26 > 0 && num27 > 0 && num28 > 0 && num29 > 1 && num30 <= 0;
				if (flag59)
				{
					Class70.smethod_57(gstruct49_0, "Switch([[horse]])");
				}
			}
			return num2;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000799A0 File Offset: 0x00077BA0
		public static int smethod_4(GStruct49 gstruct49_0, int int_0)
		{
			string text = null;
			bool flag = 224 > int_0 || int_0 > 227;
			if (flag)
			{
				if (int_0 != 181)
				{
					if (int_0 != 321)
					{
						if (int_0 != 322)
						{
							int num = Class35.smethod_137(int_0);
							bool flag2 = 0 <= num;
							if (flag2)
							{
								bool flag3 = Class35.struct14_0[num].string_3 != null;
								if (flag3)
								{
									text = Class35.struct14_0[num].string_3;
								}
							}
							else
							{
								text = Class37.smethod_1(int_0, false) + "|" + Class44.gstruct33_0.string_1;
							}
						}
						else
						{
							text = "Tr­êng B¹ch s¬n B";
						}
					}
					else
					{
						text = "Tr­êng B¹ch s¬n N";
					}
				}
				else
				{
					text = "La Tiªu s¬n";
				}
			}
			else
			{
				text = "Sa M¹c Mª Cung";
			}
			int num2 = 0;
			bool flag4 = text != null;
			if (flag4)
			{
				Class14.smethod_2(gstruct49_0, false);
				num2 = Class50.smethod_2(gstruct49_0, "h÷ng n¬i ®· ®i q|" + text, null, null, 0);
				Class86.smethod_8(gstruct49_0, -1);
				bool flag5 = num2 > 0;
				if (flag5)
				{
					Class60.smethod_11(gstruct49_0, 15000);
				}
			}
			return num2;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00079ACC File Offset: 0x00077CCC
		public static int smethod_5(GStruct49 gstruct49_0, int int_0)
		{
			int result = 0;
			for (int i = 0; i < 6; i++)
			{
				bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_5, 4) <= 0;
				if (flag)
				{
					break;
				}
				Thread.Sleep(100);
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_5, 1, 4);
			try
			{
				result = Class50.smethod_6(gstruct49_0, int_0);
			}
			catch
			{
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
			return result;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00079B54 File Offset: 0x00077D54
		private static int smethod_6(GStruct49 gstruct49_0, int int_0)
		{
			int[] array = Class60.smethod_9(int_0);
			bool flag = array != null;
			int result;
			if (flag)
			{
				string[,] array2 = new string[3, 5];
				array2[0, 0] = "2";
				array2[0, 1] = "DÞch tr¹m Xa phu";
				array2[0, 2] = "ng thµnh";
				array2[0, 3] = "83745";
				array2[0, 4] = "114757";
				array2[1, 0] = "949";
				array2[1, 1] = "Phu x";
				array2[1, 3] = "51264";
				array2[1, 4] = "101984";
				array2[2, 0] = "897";
				array2[2, 1] = "Xa phu";
				array2[2, 2] = "ng thµnh";
				array2[2, 3] = "49472";
				array2[2, 4] = "105888";
				string[,] array3 = array2;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				long long_ = 0L;
				bool flag2 = false;
				bool flag3 = false;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				string text = "D­îc th­¬ng";
				string text2 = "Qu©n Nhu";
				uint[,] array4 = new uint[3, 2];
				Class11.smethod_4(array4, 233036);
				uint[,] array5 = array4;
				uint[,] array6 = new uint[4, 2];
				Class11.smethod_4(array6, 233069);
				uint[,] array7 = array6;
				for (;;)
				{
					Thread.Sleep(300);
					int num7 = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
					bool flag4 = Class12.bool_0 || num7 < 0 || Class22.smethod_52(Form1.gstruct49_0[num7].process_0) || !Form1.gstruct49_0[num7].bool_25 || Class44.bool_0;
					if (flag4)
					{
						break;
					}
					gstruct49_0 = Form1.gstruct49_0[num7];
					int num8 = Class83.smethod_12(gstruct49_0);
					bool flag5 = num8 == 1;
					if (!flag5)
					{
						uint num9 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
						uint num10 = Class22.smethod_30(num9 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
						uint num11 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
						uint num12 = num11 + num10;
						int num13 = (int)Class22.smethod_30(num12 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
						int num14 = (int)Class22.smethod_30(num12 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
						int num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
						int num16 = Class83.smethod_39(gstruct49_0);
						bool flag6 = num13 > 0 && num14 > 0 && num15 > 0 && num16 > 1;
						if (flag6)
						{
							num2 = 0;
							bool flag7 = false;
							bool flag8 = num14 != 10 && num14 != 21;
							if (!flag8)
							{
								goto IL_7F0;
							}
							uint[] array8 = new uint[]
							{
								Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							bool flag9 = array8[0] == 0U || array8[1] == 0U;
							if (!flag9)
							{
								bool flag10 = int_0 != num15;
								if (flag10)
								{
									bool flag11 = num4 == num15;
									if (flag11)
									{
										bool flag12 = num5 == 3;
										if (flag12)
										{
											Class60.smethod_12(gstruct49_0, true);
										}
										bool flag13 = num5 > 5 || num6 > 3;
										if (flag13)
										{
											goto Block_20;
										}
									}
									else
									{
										num5 = 0;
										num6 = 0;
										num4 = num15;
									}
									int num17 = 0;
									string string_ = "Xa phu";
									string text3 = "hµnh thÞ";
									bool flag14 = Class56.smethod_1(num15) == null;
									uint[] array9;
									int[] array10;
									if (flag14)
									{
										bool flag15 = num15 != 933;
										if (flag15)
										{
											bool flag16 = num15 != 333;
											if (flag16)
											{
												bool flag17 = num15 == 977;
												if (flag17)
												{
													int num18 = 0;
													byte[] byte_ = new byte[4];
													Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, byte_, 4, ref num18);
													string a = Class10.smethod_3(byte_);
													bool flag18 = a == "Cæ L";
													if (flag18)
													{
														int num19 = Class60.smethod_20(array7, array8);
														array9 = new uint[]
														{
															array7[num19, 0],
															array7[num19, 1]
														};
														string_ = text2;
														text3 = "Rêi khái|X¸c nh";
														goto IL_C9B;
													}
												}
												for (int i = 0; i < array3.GetLength(0); i++)
												{
													bool flag19 = !(num15.ToString() == array3[i, 0]);
													if (!flag19)
													{
														string_ = array3[i, 1];
														text3 = array3[i, 2];
														array9 = new uint[]
														{
															Class12.smethod_12(array3[i, 3]),
															Class12.smethod_12(array3[i, 4])
														};
														num17 = Class60.int_0[array[0], 0];
														goto IL_C9B;
													}
												}
												array10 = Class60.smethod_9(num15);
												bool flag20 = array10 != null;
												if (flag20)
												{
													array9 = Class43.smethod_10(array8, num15, string_, true);
													bool flag21 = array9 == null;
													if (flag21)
													{
														goto Block_29;
													}
													num17 = ((array[0] != array10[0]) ? ((array10[1] > 0) ? Class60.int_0[array10[0], array10[1] - 1] : ((Class60.int_0[array[0], 0] == Class60.int_0[array10[0], 0]) ? Class60.int_0[array[0], 1] : Class60.int_0[array[0], 0])) : ((array10[1] > array[1]) ? Class60.int_0[array10[0], array10[1] - 1] : Class60.int_0[array10[0], array10[1] + 1]));
												}
												else
												{
													array9 = Class43.smethod_10(array8, num15, string_, true);
													bool flag22 = array9 == null;
													if (flag22)
													{
														string text4 = Class22.smethod_28(gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct49_0.int_137, 48);
														bool flag23 = !(text4 != string.Empty) || (0 > Class12.smethod_1(text4, "tr­êng li") && 0 > Class12.smethod_1(text4, "tr­êng §¹"));
														if (flag23)
														{
															goto Block_37;
														}
														array9 = new uint[]
														{
															46752U,
															96704U
														};
														flag7 = true;
													}
													else
													{
														flag7 = true;
													}
												}
											}
											else
											{
												int num20 = 0;
												bool flag24 = Form1.string_3.IndexOf("vltrungnguyen") != 0;
												if (flag24)
												{
													num20 = Class60.smethod_20(array5, array8);
												}
												array9 = new uint[]
												{
													array5[num20, 0],
													array5[num20, 1]
												};
												string_ = text;
												text3 = "Rêi khái";
											}
										}
										else
										{
											string_ = "Xa phu";
											text3 = "Rêi khái";
											array9 = new uint[]
											{
												53040U,
												117298U
											};
										}
									}
									else
									{
										int num21 = (int)Class60.smethod_21(Class56.uint_4, array8);
										int num22 = (int)Class60.smethod_21(Class56.uint_5, array8);
										int length = Class56.uint_5.GetLength(0);
										array9 = new uint[]
										{
											Class56.uint_5[length - 1, 0],
											Class56.uint_5[length - 1, 1]
										};
										bool flag25 = num21 > 0 && num21 < num22;
										if (flag25)
										{
											length = Class56.uint_4.GetLength(0);
											array9 = new uint[]
											{
												Class56.uint_4[length - 1, 0],
												Class56.uint_4[length - 1, 1]
											};
										}
										text3 = "hµnh thÞ|hµnh ph";
										bool flag26 = flag3 || (int_0 != 99 && int_0 != 121);
										if (flag26)
										{
											num17 = Class60.int_0[array[0], 0];
											bool flag27 = num17 == 1 || num17 == 37;
											if (flag27)
											{
												num17 = 11;
											}
										}
										else
										{
											num17 = int_0;
											flag3 = true;
										}
									}
									IL_C9B:
									array10 = Class60.smethod_9(num15);
									int num23 = Class98.smethod_13(gstruct49_0, string_, 3, array10 != null && array10[1] == 0, -1, 80);
									bool flag28 = num23 > 0;
									if (!flag28)
									{
										goto IL_D06;
									}
									array9 = Class98.smethod_19(gstruct49_0, num23);
									long num24 = Class60.smethod_18(array8, array9);
									bool flag29 = num24 > 0L && num24 < 90000L;
									if (!flag29)
									{
										goto IL_D06;
									}
									IL_818:
									uint num25 = Class36.smethod_41(gstruct49_0, false);
									bool flag30 = num25 < 500U;
									if (flag30)
									{
										bool flag31 = !flag2 && gstruct49_0.string_15 != null && gstruct49_0.string_15 != string.Empty;
										if (flag31)
										{
											uint num26 = Class12.smethod_12(gstruct49_0.string_15);
											bool flag32 = num26 > 0U;
											if (flag32)
											{
												Class70.smethod_117(gstruct49_0, num26);
												flag2 = true;
												Thread.Sleep(300);
											}
										}
										uint num27 = 500U - num25;
										uint num28 = Class36.smethod_41(gstruct49_0, true);
										bool flag33 = num28 >= num27;
										if (flag33)
										{
											bool flag34 = num27 > 100000U;
											if (flag34)
											{
												num27 = 100000U;
											}
											Class70.smethod_37(gstruct49_0, num27);
											Thread.Sleep(300);
										}
									}
									string text5 = null;
									int num29 = Class35.smethod_137(num17);
									bool flag35 = 0 <= num29 && Class35.struct14_0[num29].string_3 != null;
									if (flag35)
									{
										text5 = Class35.struct14_0[num29].string_3;
									}
									bool flag36 = flag7 || text5 == null || text5 == string.Empty || text5 == "Kh«ng x¸c ®Þnh";
									if (flag36)
									{
										int[] array11 = Class60.smethod_9(int_0);
										bool flag37 = array11 == null;
										if (flag37)
										{
											text5 = " ";
										}
										else
										{
											num15 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
											int[] array12 = Class60.smethod_9(num15);
											text5 = ((array12 == null || array12[0] != array11[0] || array11[1] <= array12[1]) ? Class60.string_0[array11[0], 0] : Class60.string_0[array11[0], array11[1]]);
											text5 += "| b¾c";
										}
									}
									bool flag38 = text3 != null && text3 != string.Empty;
									if (flag38)
									{
										text3 += "|";
									}
									text3 = text3 + text5 + "|KÕt thóc";
									for (;;)
									{
										IL_C4B:
										Class14.smethod_2(gstruct49_0, false);
										int j;
										for (j = 0; j < 10; j++)
										{
											bool flag39 = array9 == null;
											if (flag39)
											{
												break;
											}
											Class70.smethod_61(gstruct49_0, array9);
											Thread.Sleep(300);
											array8 = new uint[]
											{
												Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
												Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
											};
											long num30 = Class60.smethod_18(array8, array9);
											bool flag40 = num30 < 11250L;
											if (flag40)
											{
												break;
											}
										}
										bool flag41 = num23 <= 0;
										if (flag41)
										{
											num23 = Class98.smethod_13(gstruct49_0, string_, 3, array10 != null && array10[1] == 0, -1, 80);
											bool flag42 = num23 <= 0;
											if (flag42)
											{
												goto Block_70;
											}
											num3 = 0;
										}
										Class86.smethod_8(gstruct49_0, -1);
										Thread.Sleep(100);
										Class36.smethod_10(gstruct49_0, (uint)num23);
										Thread.Sleep(150);
										j = 0;
										while (Class86.smethod_0(gstruct49_0) < 0)
										{
											j++;
											Thread.Sleep(100);
											bool flag43 = Form1.int_85 > 0 && Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) > 0U;
											if (flag43)
											{
												string text6 = Class45.smethod_4(gstruct49_0);
												bool flag44 = text6 != null && text6 != string.Empty;
												if (flag44)
												{
													int num31 = Class12.smethod_10(text6, false, false);
													bool flag45 = num31 > 0;
													if (flag45)
													{
														Class45.smethod_5(gstruct49_0, num31.ToString(), true);
														Thread.Sleep(300);
													}
												}
											}
											bool flag46 = j < 10;
											if (!flag46)
											{
												j++;
												bool flag47 = j <= 8;
												if (!flag47)
												{
													num3++;
													bool flag48 = num3 <= 4;
													if (!flag48)
													{
														goto IL_C49;
													}
													bool flag49 = num3 % 2 != 0;
													if (flag49)
													{
														goto IL_C4B;
													}
													goto IL_C44;
												}
											}
										}
										goto Block_78;
									}
									IL_C44:
									Class60.smethod_12(gstruct49_0, true);
									continue;
									Block_70:
									num3++;
									bool flag50 = num3 <= 4;
									if (flag50)
									{
										bool flag51 = num3 % 3 == 0;
										if (flag51)
										{
											Class60.smethod_12(gstruct49_0, true);
										}
										continue;
									}
									goto IL_C82;
									Block_78:
									Thread.Sleep(100);
									bool flag52 = Class86.smethod_6(gstruct49_0, text3, false, false, false, false) > 0;
									if (flag52)
									{
										Thread.Sleep(100);
										Class60.smethod_11(gstruct49_0, 15000);
										num6++;
									}
									else
									{
										Class86.smethod_8(gstruct49_0, -1);
										num5++;
										num3 = 0;
									}
									continue;
									IL_D06:
									int num32 = (int)Class22.smethod_30(num12 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
									Class22.smethod_28(gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct49_0.int_137, 20);
									uint[,] array13 = Class42.smethod_1(num15, array8, array9, "XAPHU", true);
									bool flag53 = array13 != null && num32 <= 0;
									if (flag53)
									{
										for (int k = 0; k < 3; k++)
										{
											array8 = new uint[]
											{
												Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
												Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
											};
											bool flag54 = Class60.smethod_22(gstruct49_0, array13, array8, array9, num15, true, 0, false) > 0;
											if (flag54)
											{
												goto IL_818;
											}
											Thread.Sleep(300);
											bool flag55 = Class22.smethod_30(num12 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137) <= 0U;
											if (!flag55)
											{
												goto IL_E35;
											}
											Thread.Sleep(300);
										}
									}
									bool flag56 = Class12.smethod_28(long_) > 6000L;
									if (flag56)
									{
										int num33 = Class14.smethod_1(gstruct49_0, array9);
										long_ = Class12.smethod_27();
										bool flag57 = num33 <= 0;
										if (flag57)
										{
											Class60.smethod_12(gstruct49_0, true);
										}
									}
									continue;
									goto IL_C9B;
								}
								goto IL_7E9;
							}
						}
						else
						{
							num2++;
							bool flag58 = num2 >= 3;
							if (flag58)
							{
								goto Block_46;
							}
						}
					}
				}
				goto IL_F45;
				Block_20:
				num = -1;
				goto IL_F45;
				Block_29:
				num = -2;
				goto IL_F45;
				Block_37:
				num = -1;
				goto IL_F45;
				IL_7E9:
				num = 1;
				goto IL_F45;
				IL_7F0:
				num = -1;
				goto IL_F45;
				Block_46:
				num = -1;
				goto IL_F45;
				IL_C49:
				num = -4;
				goto IL_F45;
				IL_C82:
				num = -4;
				goto IL_F45;
				IL_E35:
				num = 2;
				IL_F45:
				result = num;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0007AAB4 File Offset: 0x00078CB4
		public static int smethod_7(GStruct49 gstruct49_0)
		{
			int[] array = Class60.smethod_9(Class37.smethod_0(gstruct49_0));
			bool flag = array != null;
			int result;
			if (flag)
			{
				bool flag2 = array[1] != 0;
				if (flag2)
				{
					uint[,] array2 = null;
					int num = Class37.smethod_0(gstruct49_0);
					int num2 = num;
					int num3 = num2;
					if (num3 <= 53)
					{
						if (num3 != 20)
						{
							if (num3 == 53)
							{
								array2 = Class50.uint_0;
							}
						}
						else
						{
							array2 = Class50.uint_1;
						}
					}
					else if (num3 != 121)
					{
						if (num3 != 153)
						{
							if (num3 == 174)
							{
								array2 = Class50.uint_4;
							}
						}
						else
						{
							array2 = Class50.uint_3;
						}
					}
					else
					{
						array2 = Class50.uint_2;
					}
					bool flag3 = array2 != null;
					if (flag3)
					{
						int num4 = 0;
						while (num4 < 3 && Class60.smethod_22(gstruct49_0, array2, null, null, num, true, 0, false) <= 0)
						{
							num4++;
							Thread.Sleep(300);
						}
					}
					result = Class50.smethod_5(gstruct49_0, Class60.int_0[array[0], 0]);
				}
				else
				{
					result = 1;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x04000176 RID: 374
		public static Class50.Struct20[] struct20_0;

		// Token: 0x04000177 RID: 375
		private static uint[,] uint_0;

		// Token: 0x04000178 RID: 376
		private static uint[,] uint_1;

		// Token: 0x04000179 RID: 377
		private static uint[,] uint_2;

		// Token: 0x0400017A RID: 378
		private static uint[,] uint_3;

		// Token: 0x0400017B RID: 379
		private static uint[,] uint_4;

		// Token: 0x020000F4 RID: 244
		public struct Struct20
		{
			// Token: 0x0400125C RID: 4700
			public int int_0;

			// Token: 0x0400125D RID: 4701
			public string string_0;

			// Token: 0x0400125E RID: 4702
			public string string_1;

			// Token: 0x0400125F RID: 4703
			public uint[,] uint_0;
		}
	}
}
