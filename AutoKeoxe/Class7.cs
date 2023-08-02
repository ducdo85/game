using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000043 RID: 67
	internal class Class7
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x000B65E0 File Offset: 0x000B47E0
		public static string[] smethod_0(string string_6)
		{
			string string_7 = Class53.string_10 + "\\" + string_6;
			string text = Class12.smethod_33(string_7, 0, 0, 1);
			bool flag = text != null && !(text == string.Empty);
			string[] result;
			if (flag)
			{
				string text2 = Class12.smethod_15(text);
				bool flag2 = text2 != null && !(text2 == string.Empty);
				if (flag2)
				{
					result = text2.Split(new char[]
					{
						'|'
					});
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000B6664 File Offset: 0x000B4864
		public static void smethod_1(string[] string_6, string string_7)
		{
			string text = string.Empty;
			bool flag = string_6 != null;
			if (flag)
			{
				for (int i = 0; i < string_6.Length; i++)
				{
					bool flag2 = string_6[i] != null && !(string_6[i] == string.Empty);
					if (flag2)
					{
						bool flag3 = text != null && text != string.Empty;
						if (flag3)
						{
							text += "|";
						}
						text += string_6[i];
					}
				}
			}
			bool flag4 = text != string.Empty;
			if (flag4)
			{
				text = Class12.smethod_16(text);
			}
			Class12.smethod_23(Class53.string_10);
			Class12.smethod_34(Class53.string_10 + "\\" + string_7, text, 1);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000B6720 File Offset: 0x000B4920
		public static uint[] smethod_2(string[] string_6)
		{
			bool flag = string_6 == null;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				uint[] array = new uint[string_6.Length];
				for (int i = 0; i < string_6.Length; i++)
				{
					array[i] = Class12.smethod_6(string_6[i]);
				}
				result = array;
			}
			return result;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000B676C File Offset: 0x000B496C
		public static bool smethod_3(GStruct49 gstruct49_0)
		{
			bool flag = Class44.uint_0 == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = 1114;
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
				int num6 = (int)Class22.smethod_30(num5 + Class53.gstruct51_54.uint_0, gstruct49_0.int_137);
				bool flag2 = num6 <= 0;
				if (flag2)
				{
					result = false;
				}
				else
				{
					int num7 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
					uint[] array = new uint[]
					{
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					int num8 = 0;
					byte[] array2 = new byte[4];
					uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num8);
					int num9 = BitConverter.ToInt32(array2, 0);
					int num10 = 0;
					uint num11 = 0U;
					uint[] array3 = null;
					byte[] array4 = new byte[2];
					Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array4, 2, ref num8);
					for (uint num12 = 1U; num12 < 256U; num12 += 1U)
					{
						bool flag3 = num9 <= num10;
						if (flag3)
						{
							break;
						}
						uint num13 = num4 + num12 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_16.uint_0, array2, 4, ref num8);
						bool flag4 = array2[0] == 0;
						if (!flag4)
						{
							num10++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_50.uint_0, array2, 4, ref num8);
							bool flag5 = BitConverter.ToInt32(array2, 0) <= 0;
							if (!flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_52.uint_0, array2, 4, ref num8);
								int num14 = BitConverter.ToInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_43.uint_0, array2, 4, ref num8);
								int num15 = BitConverter.ToInt32(array2, 0);
								bool flag6 = num14 != 1 || num15 <= 0;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num13 + Class53.gstruct51_55.uint_0, array2, 4, ref num8);
									int num16 = BitConverter.ToInt32(array2, 0);
									bool flag7 = num16 == 10 || num16 == 21;
									if (!flag7)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num13, array2, 4, ref num8);
										int num17 = BitConverter.ToInt32(array2, 0);
										bool flag8 = num17 == -1 || num17 == 0;
										if (!flag8)
										{
											try
											{
												bool flag9 = Class44.uint_0 == null;
												if (flag9)
												{
													return false;
												}
												for (int i = 0; i < Class44.uint_0.Length; i++)
												{
													bool flag10 = (long)num17 == (long)((ulong)Class44.uint_0[i]);
													if (flag10)
													{
														bool flag11 = (long)num17 == (long)((ulong)Class44.gstruct33_0.uint_2);
														if (flag11)
														{
															num11 = num12;
														}
														bool flag12 = array3 != null;
														if (flag12)
														{
															int num18 = array3.Length;
															Array.Resize<uint>(ref array3, num18 + 1);
															array3[num18] = num12;
														}
														else
														{
															array3 = new uint[]
															{
																num12
															};
														}
														break;
													}
												}
											}
											catch
											{
												return false;
											}
										}
									}
								}
							}
						}
					}
					bool flag13 = array3 == null;
					if (!flag13)
					{
						int num19 = -1;
						uint[] array5 = new uint[2];
						uint[] array6 = new uint[2];
						int num20 = (int)Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
						int num21 = 400;
						bool flag14 = gstruct49_0.int_101[1] == num;
						if (flag14)
						{
							num21 = 470;
						}
						bool flag15 = gstruct49_0.int_101[2] != 0 || num11 == 0U || Class44.gstruct33_0.int_3 <= 0 || Class44.gstruct33_0.int_4 != num7;
						if (flag15)
						{
							goto IL_90C;
						}
						bool flag16 = (long)num20 != (long)((ulong)num11) && array4[0] != 0 && array4[1] > 0;
						if (flag16)
						{
							int int_ = Class44.gstruct33_0.int_1;
							uint num22 = Class22.smethod_30(Class53.gstruct51_27.uint_0, int_);
							bool flag17 = (ulong)num22 == (ulong)((long)num7);
							if (flag17)
							{
								uint num23 = Class22.smethod_30(Class53.gstruct51_11.uint_0, int_);
								uint num24 = Class22.smethod_30(num23 + Class53.gstruct51_13.uint_0, int_) * Class53.gstruct51_15.uint_0;
								uint num25 = Class22.smethod_30(Class53.gstruct51_14.uint_0, int_);
								uint num26 = num25 + num24;
								int num27 = (int)Class22.smethod_30(num26 + Class53.gstruct51_43.uint_0, int_);
								int num28 = (int)Class22.smethod_30(num26 + Class53.gstruct51_54.uint_0, int_);
								bool flag18 = num27 > 0 && num28 == num6;
								if (flag18)
								{
									for (int j = 0; j < 10; j++)
									{
										array5[0] = Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, int_);
										array5[1] = Class22.smethod_30(num26 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, int_);
										array[0] = Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
										array[1] = Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
										long num29 = Class60.smethod_18(array, array5);
										bool flag19 = num29 <= 1000000L;
										if (!flag19)
										{
											goto IL_C8D;
										}
										bool flag20 = (j == 0 && num29 <= (long)(num21 * num21)) || num29 < 22500L;
										if (flag20)
										{
											break;
										}
										int int_2 = gstruct49_0.int_137;
										uint uint_2 = num5 + Class53.gstruct51_72.uint_0;
										byte[] byte_ = new byte[4];
										Class22.WriteProcessMemory(int_2, uint_2, byte_, 4, ref num8);
										Class70.smethod_61(gstruct49_0, array5);
										Thread.Sleep(150);
									}
									long num30 = (long)((ulong)Class22.smethod_30(num26 + Class53.gstruct51_45.uint_0, int_));
									long num31 = (long)((ulong)Class22.smethod_30(num26 + Class53.gstruct51_47.uint_0, int_));
									long num32 = (long)((ulong)Class22.smethod_30(num26 + Class53.gstruct51_47.uint_0 + 4U, int_));
									bool flag21 = num32 > num31 && num32 < 300000L;
									if (flag21)
									{
										num31 = num32;
									}
									bool flag22 = num31 > 100L;
									if (flag22)
									{
										long num33 = 100L * num30 / num31;
										bool flag23 = num33 <= (long)gstruct49_0.int_101[3] || gstruct49_0.int_101[3] > 99;
										if (flag23)
										{
											num19 = (int)num11;
											array6[0] = array5[0];
											array6[1] = array5[1];
											goto IL_73E;
										}
									}
								}
							}
							IL_C8D:
							num11 = 0U;
							goto IL_90C;
						}
						goto IL_B88;
						IL_73E:
						bool flag24 = num19 > 0;
						if (flag24)
						{
							for (int k = 0; k < 10; k++)
							{
								int int_3 = gstruct49_0.int_137;
								uint uint_3 = num5 + Class53.gstruct51_72.uint_0;
								byte[] byte_2 = new byte[4];
								Class22.WriteProcessMemory(int_3, uint_3, byte_2, 4, ref num8);
								int num34 = (int)Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
								bool flag25 = num34 <= 3;
								if (flag25)
								{
									break;
								}
								Thread.Sleep(60);
							}
							bool flag26 = gstruct49_0.int_101[1] != num;
							if (flag26)
							{
								uint value = uint.MaxValue;
								uint value2 = (uint)num19;
								bool flag27 = num19 == num20;
								if (flag27)
								{
									value = array[0];
									value2 = array[1];
								}
								byte[] bytes = BitConverter.GetBytes(value);
								byte[] bytes2 = BitConverter.GetBytes(value2);
								byte[] array7 = new byte[4];
								array7[0] = 5;
								byte[] byte_3 = array7;
								byte[] bytes3 = BitConverter.GetBytes(gstruct49_0.int_101[1]);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_37.uint_0, bytes, 4, ref num8);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_38.uint_0, bytes2, 4, ref num8);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_36.uint_0, bytes3, 4, ref num8);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_35.uint_0, byte_3, 4, ref num8);
							}
							else
							{
								uint[] array8 = Class83.smethod_10(array, array6);
								uint uint_4 = (array8[1] << 16) + array8[0];
								Class83.smethod_7(gstruct49_0, uint_4);
								Thread.Sleep(10);
								Class77.smethod_9(gstruct49_0, null);
								Class77.smethod_5(gstruct49_0, num, 6, 1);
								Class22.smethod_76(gstruct49_0.uint_4, 117);
							}
							Thread.Sleep(30);
							return true;
						}
						return false;
						IL_90C:
						bool flag28 = array4[0] > 0 && array4[1] > 0 && (gstruct49_0.int_101[2] == 1 || num11 == 0U);
						if (flag28)
						{
							uint num35 = 0U;
							long num36 = -1L;
							long num37 = -1L;
							for (int l = 0; l < array3.Length; l++)
							{
								bool flag29 = (long)num20 == (long)((ulong)array3[l]);
								if (!flag29)
								{
									uint num38 = num4 + array3[l] * Class53.gstruct51_15.uint_0;
									int num39 = (int)Class22.smethod_30(num38 + Class53.gstruct51_54.uint_0, gstruct49_0.int_137);
									bool flag30 = num6 != num39;
									if (!flag30)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num38 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array2, 4, ref num8);
										array5[0] = BitConverter.ToUInt32(array2, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num38 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array2, 4, ref num8);
										array5[1] = BitConverter.ToUInt32(array2, 0);
										long num40 = Class60.smethod_18(array, array5);
										bool flag31 = num40 > (long)(num21 * num21);
										if (!flag31)
										{
											bool flag32 = gstruct49_0.int_101[3] > 99;
											if (flag32)
											{
												bool flag33 = num35 == 0U || num40 < num37;
												if (flag33)
												{
													num35 = array3[l];
													num37 = num40;
													array6[0] = array5[0];
													array6[1] = array5[1];
												}
											}
											else
											{
												long num41 = (long)((ulong)Class22.smethod_30(num38 + Class53.gstruct51_45.uint_0, gstruct49_0.int_137));
												long num42 = (long)((ulong)Class22.smethod_30(num38 + Class53.gstruct51_47.uint_0, gstruct49_0.int_137));
												long num43 = (long)((ulong)Class22.smethod_30(num38 + Class53.gstruct51_47.uint_0 + 4U, gstruct49_0.int_137));
												bool flag34 = num43 > num42 && num43 < 300000L;
												if (flag34)
												{
													num42 = num43;
												}
												long num44 = num41;
												bool flag35 = num42 > 100L;
												if (flag35)
												{
													num44 = 100L * num41 / num42;
												}
												bool flag36 = num44 <= (long)gstruct49_0.int_101[3] && (num35 == 0U || num44 < num36 || (num44 == num36 && num40 < num37));
												if (flag36)
												{
													num35 = array3[l];
													num37 = num40;
													num36 = num44;
													array6[0] = array5[0];
													array6[1] = array5[1];
												}
											}
										}
									}
								}
							}
							bool flag37 = num35 > 0U;
							if (flag37)
							{
								num19 = (int)num35;
								goto IL_73E;
							}
						}
						IL_B88:
						Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_43.uint_0, array2, 4, ref num8);
						bool flag38 = BitConverter.ToInt32(array2, 0) > 0;
						if (flag38)
						{
							array6[0] = array[0];
							array6[1] = array[1];
							bool flag39 = gstruct49_0.int_101[3] <= 99;
							if (flag39)
							{
								long num45 = (long)((ulong)Class22.smethod_30(num5 + Class53.gstruct51_45.uint_0, gstruct49_0.int_137));
								long num46 = (long)((ulong)Class22.smethod_30(num5 + Class53.gstruct51_47.uint_0, gstruct49_0.int_137));
								long num47 = (long)((ulong)Class22.smethod_30(num5 + Class53.gstruct51_47.uint_0 + 4U, gstruct49_0.int_137));
								bool flag40 = num47 > num46 && num47 < 300000L;
								if (flag40)
								{
									num46 = num47;
								}
								bool flag41 = num46 <= 100L || 100L * num45 / num46 <= (long)gstruct49_0.int_101[3];
								if (flag41)
								{
									num19 = num20;
								}
							}
							else
							{
								num19 = num20;
							}
						}
						goto IL_73E;
					}
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000B7424 File Offset: 0x000B5624
		public static int smethod_4(int int_4, int int_5, uint[] uint_2)
		{
			try
			{
				int num = 0;
				byte[] array = new byte[1];
				bool flag = Class7.gstruct24_0 != null;
				if (flag)
				{
					for (int i = 0; i < Class7.gstruct24_0.Length; i++)
					{
						bool flag2 = Class7.gstruct24_0[i].int_0 == 0 || int_5 != Class7.gstruct24_0[i].int_1;
						if (!flag2)
						{
							Class22.ReadProcessMemory(int_4, Class7.gstruct24_0[i].uint_0, array, 1, ref num);
							bool flag3 = array[0] > 0;
							if (flag3)
							{
								long num2 = Class60.smethod_18(uint_2, Class7.gstruct24_0[i].uint_1);
								bool flag4 = num2 < 360000L;
								if (flag4)
								{
									return 1;
								}
							}
							else
							{
								Class7.gstruct24_0[i].int_0 = 0;
								Class7.gstruct24_0[i].int_1 = 0;
							}
						}
					}
				}
				return 0;
			}
			catch
			{
			}
			return -1;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x000B7540 File Offset: 0x000B5740
		public static int[,] smethod_5(GStruct49 gstruct49_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			byte[] array = new byte[4];
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_30.uint_0;
			uint num3 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3;
			uint num6 = num + Class53.gstruct51_30.uint_0;
			uint num7 = Class22.smethod_30(num5 + Class53.gstruct51_88.uint_0, gstruct49_0.int_137);
			int num8 = 0;
			long num9 = (long)(int_4 * int_4);
			int num10 = (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			int num11 = (int)Class22.smethod_30(num5 + Class53.gstruct51_54.uint_0, gstruct49_0.int_137);
			int num12 = (int)Class22.smethod_30(num5 + Class53.gstruct51_56.uint_0, gstruct49_0.int_137);
			bool flag = uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0U || uint_3[1] == 0U;
			if (flag)
			{
				uint_3 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_38 * 4U, array, 4, ref num8);
			int num13 = BitConverter.ToInt32(array, 0);
			int num14 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag2 = !bool_3 && ((926 <= num14 && num14 <= 932) || num14 == Class38.int_0);
			bool flag3 = (463 < num14 && num14 < 472) || (479 < num14 && num14 < 496);
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[60];
			byte[] array5 = new byte[2];
			byte[] array6 = new byte[1];
			byte[] array7 = new byte[2];
			long[,,] array8 = new long[2, 5, 10];
			int[,] array9 = new int[2, 11];
			int[] array10 = new int[2];
			byte[] array11 = new byte[4];
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_2 * 4U, array6, 1, ref num8);
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array5, 2, ref num8);
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_3 * 4U, array7, 2, ref num8);
			uint uint_4 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_4, array, 4, ref num8);
			int num15 = BitConverter.ToInt32(array, 0);
			bool flag4 = num15 > 1;
			int[,] result;
			if (flag4)
			{
				uint[] array12 = new uint[2];
				int num16 = 0;
				int num17 = 0;
				uint num18 = 0U;
				num18 = 1U;
				int num21;
				int num28;
				long num30;
				int num31;
				int num32;
				int num33;
				for (;;)
				{
					bool flag5 = num18 < 256U;
					if (!flag5)
					{
						goto IL_103C;
					}
					bool flag6 = !bool_1 && num18 % 2U == 0U;
					if (flag6)
					{
						int num19 = Class83.smethod_12(gstruct49_0);
						bool flag7 = num19 == 1;
						if (flag7)
						{
							break;
						}
					}
					bool flag8 = num15 > num17;
					if (flag8)
					{
						bool flag9 = (ulong)num18 != (ulong)((long)num10);
						if (flag9)
						{
							uint num20 = num4 + num18 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_52.uint_0, array, 4, ref num8);
							num21 = BitConverter.ToInt32(array, 0);
							uint num22 = num20 + Class53.gstruct51_16.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num22, array, 4, ref num8);
							bool flag10 = array[0] != 0 || (num21 == 1 && Form1.int_117 > 0);
							if (flag10)
							{
								num17++;
								bool flag11 = array[0] == 84 && array[2] == 211;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_50.uint_0, array, 4, ref num8);
								bool flag12 = BitConverter.ToInt32(array, 0) > 0;
								if (flag12)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_43.uint_0, array, 4, ref num8);
									int num23 = BitConverter.ToInt32(array, 0);
									int num24 = num21;
									int num25 = num24;
									int num26;
									if (num25 != 0)
									{
										if (num25 != 1)
										{
											num26 = 0;
										}
										else
										{
											num26 = ((num23 > 0 && array5[0] != 0 && array5[1] != 0) ? 1 : 0);
										}
									}
									else
									{
										num26 = 1;
									}
									bool flag13 = num26 != 0;
									if (flag13)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_55.uint_0, array, 4, ref num8);
										int num27 = BitConverter.ToInt32(array, 0);
										bool flag14 = num27 != 10 && num27 != 21;
										if (flag14)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20, array11, 4, ref num8);
											num28 = BitConverter.ToInt32(array11, 0);
											bool flag15 = num28 != -1 && num28 != 0;
											if (flag15)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_54.uint_0, array, 4, ref num8);
												int num29 = BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_45.uint_0, array, 4, ref num8);
												num30 = (long)BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_26.uint_0 + 8U, array, 4, ref num8);
												num31 = BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_26.uint_0 + 12U, array, 4, ref num8);
												num32 = BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_51.uint_0, array, 4, ref num8);
												num33 = BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num8);
												array12[0] = BitConverter.ToUInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num8);
												array12[1] = BitConverter.ToUInt32(array, 0);
												bool flag16 = false;
												bool flag17 = flag3 && Form1.int_116 > 0 && num21 <= 0;
												if (flag17)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num18 * 8U, array, 4, ref num8);
													bool flag18 = (ulong)BitConverter.ToUInt32(array, 0) == (ulong)((long)num28);
													if (flag18)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num18 * 8U + 4U, array2, 1, ref num8);
														bool flag19 = array2[0] > 0;
														if (flag19)
														{
															goto IL_1385;
														}
													}
													else
													{
														array2[0] = 0;
														bool flag20 = flag11;
														if (flag20)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + 5U, array, 4, ref num8);
															bool flag21 = BitConverter.ToUInt32(array, 0) == 3580454990U;
															if (flag21)
															{
																array2[0] = 1;
															}
														}
														bool flag22 = array2[0] <= 0;
														if (flag22)
														{
															uint num34 = num4 + num18 * Class53.gstruct51_15.uint_0 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0;
															for (uint num35 = 0U; num35 < 6U; num35 += 1U)
															{
																Class22.ReadProcessMemory(gstruct49_0.int_137, num34 + Class53.gstruct51_3.uint_0 * num35, array, 4, ref num8);
																bool flag23 = BitConverter.ToInt32(array, 0) == 45;
																if (flag23)
																{
																	array2[0] = 1;
																	break;
																}
															}
														}
														Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num18 * 8U, array11, 4, ref num8);
														Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num18 * 8U + 4U, array2, 1, ref num8);
														bool flag24 = array2[0] > 0;
														if (flag24)
														{
															int num36 = 0;
															while (Class7.bool_0 && num36 < 10)
															{
																Thread.Sleep(10);
																num36++;
															}
															Class7.bool_0 = true;
															int num37 = 1;
															bool flag25 = Class7.gstruct24_0 == null;
															if (flag25)
															{
																Class7.gstruct24_0 = new GStruct24[1];
															}
															else
															{
																num37 = Class7.gstruct24_0.Length + 1;
																Array.Resize<GStruct24>(ref Class7.gstruct24_0, num37);
															}
															Class7.gstruct24_0[num37 - 1].int_0 = num28;
															Class7.gstruct24_0[num37 - 1].int_1 = num14;
															Class7.gstruct24_0[num37 - 1].uint_0 = num22;
															Class7.gstruct24_0[num37 - 1].int_2 = 1;
															Class7.gstruct24_0[num37 - 1].uint_1 = new uint[]
															{
																array12[0],
																array12[1]
															};
															Class7.bool_0 = false;
															goto IL_1385;
														}
													}
													bool flag26 = Class7.smethod_4(gstruct49_0.int_137, num14, array12) > 0;
													if (flag26)
													{
														goto IL_1385;
													}
												}
												while (!flag16 && (uint_2 == 0U || (long)num28 != (long)((ulong)uint_2)))
												{
													long num38 = Class60.smethod_18(uint_3, array12);
													bool flag27 = num38 > num9;
													if (flag27)
													{
														goto IL_1385;
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_53.uint_0, array, 4, ref num8);
													int num39 = BitConverter.ToInt32(array, 0);
													bool flag28 = num39 < 0 || num39 > 4;
													if (flag28)
													{
														goto IL_1385;
													}
													Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_85.uint_0, array, 4, ref num8);
													int num40 = BitConverter.ToInt32(array, 0);
													bool flag29 = num21 <= 0;
													if (flag29)
													{
														bool flag30 = Form1.int_31 <= 0 || (num11 > 0 && num29 == num11 && num29 != 4);
														if (flag30)
														{
															goto IL_1385;
														}
														bool flag31 = flag2;
														if (flag31)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_16.uint_0, array4, array4.Length, ref num8);
															string text = Class10.smethod_3(array4);
															bool flag32 = !(text == string.Empty) && Class12.smethod_1(text, "[" + gstruct49_0.string_20 + "]") > 0;
															if (flag32)
															{
																goto IL_1385;
															}
															bool flag33 = Form1.int_32 > 0 && Form1.int_36 > 0;
															if (flag33)
															{
																flag16 = true;
																continue;
															}
														}
														else
														{
															bool flag34 = false;
															bool flag35 = int_5 != null;
															if (flag35)
															{
																for (int i = 0; i < int_5.Length; i++)
																{
																	bool flag36 = num28 == int_5[i];
																	if (flag36)
																	{
																		flag34 = true;
																		break;
																	}
																}
															}
															bool flag37 = flag34;
															if (flag37)
															{
																goto IL_1385;
															}
															bool flag38 = Form1.int_32 > 0 || num30 <= 0L;
															if (flag38)
															{
																bool flag39 = num31 > 0 && num32 > 15 && num33 > 0;
																if (flag39)
																{
																	bool flag40 = Form1.int_36 > 0;
																	if (flag40)
																	{
																		flag16 = true;
																		continue;
																	}
																}
																else
																{
																	bool flag41 = !bool_2 || num33 <= 95 || num30 <= 0L;
																	if (flag41)
																	{
																		goto IL_1385;
																	}
																}
															}
														}
													}
													else
													{
														bool flag42 = Form1.int_30 <= 0 || num23 <= 0 || num13 > 0 || num29 == 0 || num11 == 0 || (Form1.int_35 <= 0 && (num27 == 3 || num27 == 4));
														if (flag42)
														{
															goto IL_1385;
														}
														bool flag43 = Form1.int_86 > 0;
														if (flag43)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_51.uint_0, array, 4, ref num8);
															int num41 = BitConverter.ToInt32(array, 0);
															bool flag44 = num41 < Form1.int_87;
															if (flag44)
															{
																goto IL_1385;
															}
														}
														bool flag45 = Class7.int_3 > 0 && Class7.string_5 != null;
														if (flag45)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_16.uint_0, array3, array3.Length, ref num8);
															string a = Class10.smethod_3(array3);
															bool flag46 = false;
															for (int j = 0; j < Class7.string_5.Length; j++)
															{
																bool flag47 = a == Class7.string_5[j];
																if (flag47)
																{
																	flag46 = true;
																	break;
																}
															}
															bool flag48 = flag46;
															if (flag48)
															{
																goto IL_1385;
															}
														}
														bool flag49 = array5[0] == 0 || array5[1] == 0;
														if (flag49)
														{
															goto IL_1385;
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_88.uint_0, array, 4, ref num8);
														uint num42 = BitConverter.ToUInt32(array, 0);
														bool flag50 = num42 > 0U;
														if (flag50)
														{
															bool flag51 = Form1.int_103 > 0 && num42 == num7;
															if (flag51)
															{
																goto IL_1385;
															}
															bool flag52 = Class7.int_2 > 0 && Class7.uint_0 != null && !FormMayphu.bool_4;
															if (flag52)
															{
																bool flag53 = false;
																for (int k = 0; k < Class7.uint_0.Length; k++)
																{
																	bool flag54 = num42 == Class7.uint_0[k];
																	if (flag54)
																	{
																		flag53 = true;
																		break;
																	}
																}
																bool flag55 = flag53;
																if (flag55)
																{
																	goto IL_1385;
																}
															}
															bool flag56 = Class7.int_1 > 0 && Class7.uint_1 != null;
															if (flag56)
															{
																for (int l = 0; l < Class7.uint_1.Length; l++)
																{
																	bool flag57 = num42 != Class7.uint_1[l];
																	if (!flag57)
																	{
																		goto IL_E85;
																	}
																}
															}
														}
														bool flag58 = !flag2 || (num7 == num42 && num7 != 0U && num42 > 0U);
														if (flag58)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_61.uint_0, array, 4, ref num8);
															uint num43 = BitConverter.ToUInt32(array, 0);
															Class22.ReadProcessMemory(gstruct49_0.int_137, num20, array, 4, ref num8);
															uint num44 = BitConverter.ToUInt32(array, 0);
															bool flag59 = num43 == num44;
															if (flag59)
															{
																Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_62.uint_0, array, 4, ref num8);
																gstruct49_0.gstruct43_0.uint_2 = BitConverter.ToUInt32(array, 0);
																bool flag60 = gstruct49_0.gstruct43_0.uint_2 == 2U;
																if (flag60)
																{
																	goto IL_E85;
																}
															}
															bool flag61 = num29 == num11 && num29 != 4;
															if (flag61)
															{
																goto IL_1385;
															}
															Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_56.uint_0, array, 4, ref num8);
															int num45 = BitConverter.ToInt32(array, 0);
															bool flag62 = num12 + num45 <= 1;
															if (flag62)
															{
																goto IL_1385;
															}
														}
													}
													IL_E85:
													try
													{
														bool flag63 = num21 > 1;
														if (flag63)
														{
															num21 = 1;
														}
														long num46 = array8[num21, num39, 2];
														bool flag64 = num46 <= 0L || num46 >= num38;
														if (flag64)
														{
															array10[num21]++;
															array8[num21, num39, 0] = (long)((ulong)(num18 + (uint)array6[0]));
															array8[num21, num39, 1] = (long)num28;
															array8[num21, num39, 2] = num38;
															array8[num21, num39, 3] = (long)((ulong)array12[0]);
															array8[num21, num39, 4] = (long)((ulong)array12[1]);
															array8[num21, num39, 5] = (long)num31;
															array8[num21, num39, 6] = (long)num32;
															array8[num21, num39, 7] = (long)num33;
															array8[num21, num39, 8] = num30;
															array8[num21, num39, 9] = (long)num40;
															num16++;
														}
													}
													catch
													{
													}
													goto IL_1385;
													goto IL_E85;
												}
												goto Block_108;
											}
										}
									}
								}
							}
						}
						else
						{
							num17++;
						}
						IL_1385:
						num18 += 1U;
						continue;
						goto IL_1385;
					}
					goto IL_103B;
				}
				array9[0, 0] = -100;
				array9[1, 1] = -100;
				goto IL_1395;
				Block_108:
				array9[0, 0] = num21;
				array9[0, 1] = (int)num18;
				array9[0, 2] = num28;
				array9[0, 3] = (int)Class60.smethod_18(uint_3, array12);
				array9[0, 4] = (int)array12[0];
				array9[0, 5] = (int)array12[1];
				array9[0, 6] = num31;
				array9[0, 7] = num32;
				array9[0, 8] = num33;
				array9[0, 9] = (int)num30;
				array9[1, 1] = -1;
				goto IL_1395;
				IL_103B:
				IL_103C:
				bool flag65 = num16 == 0;
				if (flag65)
				{
					return null;
				}
				int num47 = 2;
				int num48;
				int num49;
				for (;;)
				{
					num47--;
					bool flag66 = num47 < 0;
					if (flag66)
					{
						break;
					}
					bool flag67 = array10[num47] == 0;
					if (!flag67)
					{
						bool flag68 = gstruct49_0.int_88 > 0;
						if (flag68)
						{
							for (int m = 0; m < gstruct49_0.int_90.Length; m++)
							{
								num48 = gstruct49_0.int_90[m];
								bool flag69 = array8[num47, num48, 0] <= 0L;
								if (!flag69)
								{
									goto IL_10C4;
								}
							}
						}
						else
						{
							num49 = -1;
							long num50 = -1L;
							for (int n = 0; n < 5; n++)
							{
								bool flag70 = array8[num47, n, 0] > 0L;
								if (flag70)
								{
									bool flag71 = num50 > array8[num47, n, 2] && array7[1] > 0;
									bool flag72 = num50 < array8[num47, n, 2] && array7[1] <= 0;
									bool flag73 = num50 < 0L || flag71 || flag72;
									if (flag73)
									{
										num49 = n + (int)array7[1] - (int)array7[0];
										num50 = array8[num47, n, 2];
									}
								}
							}
							bool flag74 = 0 <= num49;
							if (flag74)
							{
								goto Block_120;
							}
						}
					}
				}
				goto IL_1383;
				IL_10C4:
				array9[0, 0] = num47;
				array9[0, 1] = (int)array8[num47, num48, 0];
				array9[0, 2] = (int)array8[num47, num48, 1];
				array9[0, 3] = (int)array8[num47, num48, 2];
				array9[0, 4] = (int)array8[num47, num48, 3];
				array9[0, 5] = (int)array8[num47, num48, 4];
				array9[0, 6] = (int)array8[num47, num48, 5];
				array9[0, 7] = (int)array8[num47, num48, 6];
				array9[0, 8] = (int)array8[num47, num48, 7];
				array9[0, 9] = (int)array8[num47, num48, 8];
				array9[0, 10] = (int)array8[num47, num48, 9];
				goto IL_1383;
				Block_120:
				array9[0, 0] = num47;
				array9[0, 1] = (int)array8[num47, num49, 0];
				array9[0, 2] = (int)array8[num47, num49, 1];
				array9[0, 3] = (int)array8[num47, num49, 2];
				array9[0, 4] = (int)array8[num47, num49, 3];
				array9[0, 5] = (int)array8[num47, num49, 4];
				array9[0, 6] = (int)array8[num47, num49, 5];
				array9[0, 7] = (int)array8[num47, num49, 6];
				array9[0, 8] = (int)array8[num47, num49, 7];
				array9[0, 9] = (int)array8[num47, num49, 8];
				array9[0, 10] = (int)array8[num47, num49, 9];
				IL_1383:
				IL_1395:
				bool flag75 = array9[1, 1] != -1 && array9[0, 1] > 0;
				if (flag75)
				{
					int num51 = -1;
					int num52 = -1;
					long num53 = -1L;
					bool flag76 = gstruct49_0.int_88 > 0;
					if (flag76)
					{
						for (int num54 = 0; num54 <= 1; num54++)
						{
							for (int num55 = 0; num55 < 5; num55++)
							{
								bool flag77 = array8[num54, num55, 0] > 0L && (long)array9[0, 1] != array8[num54, num55, 0] && (num53 < 0L || num53 > array8[num54, num55, 2]);
								if (flag77)
								{
									num51 = num54;
									num52 = num55;
									num53 = array8[num54, num55, 2];
								}
							}
						}
					}
					bool flag78 = 0 <= num51 && 0 <= num52;
					if (flag78)
					{
						array9[1, 0] = num51;
						array9[1, 1] = (int)array8[num51, num52, 0];
						array9[1, 2] = (int)array8[num51, num52, 1];
						array9[1, 3] = (int)array8[num51, num52, 2];
						array9[1, 4] = (int)array8[num51, num52, 3];
						array9[1, 5] = (int)array8[num51, num52, 4];
						array9[1, 6] = (int)array8[num51, num52, 5];
						array9[1, 7] = (int)array8[num51, num52, 6];
						array9[1, 8] = (int)array8[num51, num52, 7];
						array9[1, 9] = (int)array8[num51, num52, 8];
						array9[1, 10] = (int)array8[num51, num52, 9];
					}
				}
				result = array9;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000B8AE4 File Offset: 0x000B6CE4
		public static int[,] smethod_6(GStruct49 gstruct49_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			Console.WriteLine("smethod_6");
			int num = 0;
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_30.uint_0;
			uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num5 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num6 = num5 + num4;
			uint num7 = num2 + Class53.gstruct51_30.uint_0;
			uint num8 = Class22.smethod_30(num6 + Class53.gstruct51_88.uint_0, gstruct49_0.int_137);
			long num9 = (long)(int_4 * int_4);
			int num10 = (int)Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			int num11 = (int)Class22.smethod_30(num6 + Class53.gstruct51_54.uint_0, gstruct49_0.int_137);
			int num12 = (int)Class22.smethod_30(num6 + Class53.gstruct51_56.uint_0, gstruct49_0.int_137);
			bool flag = uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0U || uint_3[1] == 0U;
			if (flag)
			{
				uint_3 = new uint[]
				{
					Class22.smethod_30(num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
			}
			int num13 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag2 = !bool_3 && ((926 <= num13 && num13 <= 932) || num13 == Class38.int_0);
			bool flag3 = (463 < num13 && num13 < 472) || (479 < num13 && num13 < 496);
			byte[] array = new byte[1];
			byte[] array2 = new byte[16];
			byte[] array3 = new byte[60];
			int num14 = 11;
			int[,] array4 = new int[2, num14];
			long[,] array5 = null;
			long[,] array6 = null;
			int num15 = 0;
			int num16 = 0;
			byte[] array7 = new byte[4];
			byte[] array8 = new byte[4];
			uint uint_4 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_4, array7, 4, ref num);
			int num17 = BitConverter.ToInt32(array7, 0);
			bool flag4 = num17 <= 1;
			int[,] result;
			if (flag4)
			{
				result = null;
			}
			else
			{
				uint[] array9 = new uint[2];
				int num18 = 0;
				int num19 = 0;
				uint num20 = 0U;
				long num21 = 0L;
				for (num20 = 1U; num20 < 256U; num20 += 1U)
				{
					bool flag5 = bool_1 || num20 % 2U != 0U || Class83.smethod_12(gstruct49_0) != 1;
					if (!flag5)
					{
						array4[0, 0] = -100;
						array4[1, 0] = -100;
						return array4;
					}
					bool flag6 = num17 <= num19;
					if (flag6)
					{
						break;
					}
					bool flag7 = (ulong)num20 != (ulong)((long)num10);
					if (flag7)
					{
						uint num22 = num5 + num20 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_52.uint_0, array7, 4, ref num);
						int num23 = BitConverter.ToInt32(array7, 0);
						uint num24 = num22 + Class53.gstruct51_16.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num24, array7, 4, ref num);
						bool flag8 = array7[0] == 0 && (num23 != 1 || Form1.int_117 <= 0);
						if (!flag8)
						{
							bool flag9 = array7[0] == 84 && array7[2] == 211;
							num19++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_50.uint_0, array7, 4, ref num);
							bool flag10 = BitConverter.ToInt32(array7, 0) <= 0;
							if (!flag10)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_43.uint_0, array7, 4, ref num);
								int num25 = BitConverter.ToInt32(array7, 0);
								bool flag11 = num23 > 0 && num25 <= 0;
								if (!flag11)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_55.uint_0, array7, 4, ref num);
									int num26 = BitConverter.ToInt32(array7, 0);
									bool flag12 = num26 == 10 || num26 == 21;
									if (!flag12)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num22, array8, 4, ref num);
										int num27 = BitConverter.ToInt32(array8, 0);
										bool flag13 = num27 == -1 || num27 == 0;
										if (!flag13)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_54.uint_0, array7, 4, ref num);
											int num28 = BitConverter.ToInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_45.uint_0, array7, 4, ref num);
											long num29 = (long)BitConverter.ToInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_26.uint_0 + 8U, array7, 4, ref num);
											int num30 = BitConverter.ToInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_26.uint_0 + 12U, array7, 4, ref num);
											int num31 = BitConverter.ToInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_51.uint_0, array7, 4, ref num);
											int num32 = BitConverter.ToInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array7, 4, ref num);
											array9[0] = BitConverter.ToUInt32(array7, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array7, 4, ref num);
											array9[1] = BitConverter.ToUInt32(array7, 0);
											int num33 = 0;
											bool flag14 = false;
											bool flag15 = flag3 && Form1.int_116 > 0 && num23 <= 0;
											if (!flag15)
											{
												goto IL_7F1;
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num20 * 8U, array7, 4, ref num);
											bool flag16 = (ulong)BitConverter.ToUInt32(array7, 0) == (ulong)((long)num27);
											if (!flag16)
											{
												array[0] = 0;
												bool flag17 = flag9;
												if (flag17)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, num24 + 5U, array7, 4, ref num);
													bool flag18 = BitConverter.ToUInt32(array7, 0) == 3580454990U;
													if (flag18)
													{
														array[0] = 1;
													}
												}
												bool flag19 = array[0] <= 0;
												if (flag19)
												{
													uint num34 = num5 + num20 * Class53.gstruct51_15.uint_0 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0;
													for (uint num35 = 0U; num35 < 6U; num35 += 1U)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num34 + Class53.gstruct51_3.uint_0 * num35, array7, 4, ref num);
														bool flag20 = BitConverter.ToInt32(array7, 0) == 45;
														if (flag20)
														{
															array[0] = 1;
															break;
														}
													}
												}
												Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num20 * 8U, array8, 4, ref num);
												Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_14 + num20 * 8U + 4U, array, 1, ref num);
												bool flag21 = array[0] > 0;
												if (flag21)
												{
													num33 = 1;
													int num36 = 0;
													while (Class7.bool_0 && num36 < 15)
													{
														Thread.Sleep(10);
														num36++;
													}
													Class7.bool_0 = true;
													int num37 = 1;
													bool flag22 = Class7.gstruct24_0 != null;
													if (flag22)
													{
														num37 = Class7.gstruct24_0.Length + 1;
														Array.Resize<GStruct24>(ref Class7.gstruct24_0, num37);
													}
													else
													{
														Class7.gstruct24_0 = new GStruct24[1];
													}
													Class7.gstruct24_0[num37 - 1].int_0 = num27;
													Class7.gstruct24_0[num37 - 1].int_1 = num13;
													Class7.gstruct24_0[num37 - 1].int_2 = 1;
													Class7.gstruct24_0[num37 - 1].uint_1 = new uint[]
													{
														array9[0],
														array9[1]
													};
													Class7.bool_0 = false;
												}
												goto IL_7F1;
											}
											IL_820:
											bool flag23 = false;
											bool flag24 = int_5 != null;
											if (flag24)
											{
												for (int i = 0; i < int_5.Length; i++)
												{
													bool flag25 = (ulong)num20 == (ulong)((long)int_5[i]);
													if (flag25)
													{
														flag23 = true;
														break;
													}
												}
											}
											bool flag26 = flag23;
											if (flag26)
											{
												goto IL_FC7;
											}
											bool flag27 = num30 > 0 && num31 > 15 && num32 > 0;
											bool flag28 = Form1.int_32 > 0 || num29 <= 0L;
											if (flag28)
											{
												bool flag29 = flag27;
												if (flag29)
												{
													bool flag30 = Form1.int_36 > 0;
													if (flag30)
													{
														flag14 = true;
														goto IL_A7E;
													}
												}
												else
												{
													bool flag31 = !bool_2 || num32 <= 95 || num29 <= 0L;
													if (flag31)
													{
														goto IL_FC7;
													}
												}
											}
											goto IL_8E8;
											IL_A7E:
											for (;;)
											{
												bool flag32 = !flag14 && (uint_2 == 0U || (long)num27 != (long)((ulong)uint_2));
												if (!flag32)
												{
													goto IL_F24;
												}
												num21 = Class60.smethod_18(uint_3, array9);
												bool flag33 = num21 > num9;
												if (flag33)
												{
													goto Block_54;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_53.uint_0, array7, 4, ref num);
												int num38 = BitConverter.ToInt32(array7, 0);
												bool flag34 = num38 < 0 || num38 > 4;
												if (flag34)
												{
													goto Block_56;
												}
												bool flag35 = num23 <= 0;
												if (!flag35)
												{
													goto IL_BDC;
												}
												bool flag36 = Form1.int_31 <= 0 || (num11 > 0 && num28 == num11 && num28 != 4);
												if (flag36)
												{
													goto Block_61;
												}
												bool flag37 = !flag2;
												if (flag37)
												{
													break;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_16.uint_0, array3, array3.Length, ref num);
												string text = Class10.smethod_3(array3);
												bool flag38 = !(text == string.Empty) && Class12.smethod_1(text, "[" + gstruct49_0.string_20 + "]") > 0;
												if (flag38)
												{
													goto Block_64;
												}
												bool flag39 = Form1.int_32 > 0 && Form1.int_36 > 0;
												if (!flag39)
												{
													goto IL_BD6;
												}
												flag14 = true;
											}
											goto IL_820;
											IL_F1F:
											goto IL_8E8;
											IL_BDC:
											bool flag40 = Form1.int_30 <= 0 || num25 <= 0 || num28 == 0 || num11 == 0 || (Form1.int_35 <= 0 && (num26 == 3 || num26 == 4));
											if (flag40)
											{
												goto IL_FC6;
											}
											bool flag41 = Form1.int_86 > 0;
											if (flag41)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_51.uint_0, array7, 4, ref num);
												int num39 = BitConverter.ToInt32(array7, 0);
												bool flag42 = num39 < Form1.int_87;
												if (flag42)
												{
													goto IL_FC6;
												}
											}
											bool flag43 = Class7.int_3 > 0 && Class7.string_5 != null;
											if (flag43)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num);
												string a = Class10.smethod_3(array2);
												flag23 = false;
												for (int j = 0; j < Class7.string_5.Length; j++)
												{
													bool flag44 = a == Class7.string_5[j];
													if (flag44)
													{
														flag23 = true;
														break;
													}
												}
												bool flag45 = flag23;
												if (flag45)
												{
													goto IL_FC6;
												}
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_88.uint_0, array7, 4, ref num);
											uint num40 = BitConverter.ToUInt32(array7, 0);
											bool flag46 = num40 > 0U;
											if (flag46)
											{
												bool flag47 = Form1.int_103 > 0 && num40 == num8;
												if (flag47)
												{
													goto IL_FC6;
												}
												bool flag48 = Class7.int_2 > 0 && Class7.uint_0 != null && !FormMayphu.bool_4;
												if (flag48)
												{
													flag23 = false;
													for (int k = 0; k < Class7.uint_0.Length; k++)
													{
														bool flag49 = num40 == Class7.uint_0[k];
														if (flag49)
														{
															flag23 = true;
															break;
														}
													}
													bool flag50 = flag23;
													if (flag50)
													{
														goto IL_FC6;
													}
												}
												bool flag51 = Class7.int_1 > 0 && Class7.uint_1 != null;
												if (flag51)
												{
													for (int l = 0; l < Class7.uint_1.Length; l++)
													{
														bool flag52 = num40 != Class7.uint_1[l];
														if (!flag52)
														{
															goto IL_8E8;
														}
													}
												}
											}
											bool flag53 = !flag2 || (num8 == num40 && num8 != 0U && num40 > 0U);
											if (flag53)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_61.uint_0, array7, 4, ref num);
												uint num41 = BitConverter.ToUInt32(array7, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22, array7, 4, ref num);
												uint num42 = BitConverter.ToUInt32(array7, 0);
												bool flag54 = num41 == num42;
												if (flag54)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_62.uint_0, array7, 4, ref num);
													gstruct49_0.gstruct43_0.uint_2 = BitConverter.ToUInt32(array7, 0);
													bool flag55 = gstruct49_0.gstruct43_0.uint_2 == 2U;
													if (flag55)
													{
														goto IL_8E8;
													}
												}
												bool flag56 = num28 == num11 && num28 != 4;
												if (flag56)
												{
													goto IL_FC6;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num22 + Class53.gstruct51_56.uint_0, array7, 4, ref num);
												int num43 = BitConverter.ToInt32(array7, 0);
												bool flag57 = num12 + num43 <= 1;
												if (flag57)
												{
													goto IL_FC6;
												}
											}
											IL_BD6:
											goto IL_F1F;
											IL_FC6:
											goto IL_FC7;
											Block_64:
											Block_61:
											Block_56:
											Block_54:
											goto IL_FC6;
											IL_F24:
											array4[0, 0] = num23;
											array4[0, 1] = (int)num20;
											array4[0, 2] = num27;
											array4[0, 3] = (int)Class60.smethod_18(uint_3, array9);
											array4[0, 4] = (int)array9[0];
											array4[0, 5] = (int)array9[1];
											array4[0, 6] = num30;
											array4[0, 7] = num31;
											array4[0, 8] = num32;
											array4[0, 9] = (int)num29;
											array4[0, 10] = num33;
											array4[1, 1] = -1;
											return array4;
											IL_7F1:
											goto IL_A7E;
											IL_8E8:
											try
											{
												bool flag58 = num14 < 11;
												if (flag58)
												{
													num14 = 11;
												}
												bool flag59 = num23 != 0;
												if (flag59)
												{
													num16 = Class12.smethod_39(ref array6, 1, num14);
													array6[num16 - 1, 0] = (long)num23;
													array6[num16 - 1, 1] = (long)((ulong)num20);
													array6[num16 - 1, 2] = (long)num27;
													array6[num16 - 1, 3] = num21;
													array6[num16 - 1, 4] = (long)((ulong)array9[0]);
													array6[num16 - 1, 5] = (long)((ulong)array9[1]);
													array6[num16 - 1, 6] = (long)num30;
													array6[num16 - 1, 7] = (long)num31;
													array6[num16 - 1, 8] = (long)num32;
													array6[num16 - 1, 9] = num29;
												}
												else
												{
													num15 = Class12.smethod_39(ref array5, 1, num14);
													array5[num15 - 1, 0] = (long)num23;
													array5[num15 - 1, 1] = (long)((ulong)num20);
													array5[num15 - 1, 2] = (long)num27;
													array5[num15 - 1, 3] = num21;
													array5[num15 - 1, 4] = (long)((ulong)array9[0]);
													array5[num15 - 1, 5] = (long)((ulong)array9[1]);
													array5[num15 - 1, 6] = (long)num30;
													array5[num15 - 1, 7] = (long)num31;
													array5[num15 - 1, 8] = (long)num32;
													array5[num15 - 1, 9] = num29;
													array5[num15 - 1, 10] = (long)num33;
												}
												num18++;
											}
											catch
											{
											}
										}
									}
								}
							}
						}
					}
					else
					{
						num19++;
					}
					IL_FC7:;
				}
				bool flag60 = num18 == 0;
				if (flag60)
				{
					result = null;
				}
				else
				{
					array4 = new int[num15 + num16, num14];
					bool flag61 = num16 > 0;
					if (flag61)
					{
						for (;;)
						{
							IL_10F1:
							for (int m = 0; m < num16 - 1; m++)
							{
								for (int n = m; n < num16; n++)
								{
									bool flag62 = array6[n, 3] >= array6[m, 3];
									if (!flag62)
									{
										for (int num44 = 0; num44 < num14; num44++)
										{
											long num45 = array6[m, num44];
											array6[m, num44] = array6[n, num44];
											array6[n, num44] = num45;
										}
										goto IL_10F1;
									}
								}
								for (int num46 = 0; num46 < num14; num46++)
								{
									array4[m, num46] = (int)array6[m, num46];
								}
							}
							break;
						}
						for (int num47 = 0; num47 < num14; num47++)
						{
							array4[num16 - 1, num47] = (int)array6[num16 - 1, num47];
						}
					}
					bool flag63 = num15 > 0;
					if (flag63)
					{
						for (;;)
						{
							IL_121E:
							for (int num48 = 0; num48 < num15 - 1; num48++)
							{
								for (int num49 = num48; num49 < num15; num49++)
								{
									bool flag64 = array5[num49, 3] >= array5[num48, 3];
									if (!flag64)
									{
										for (int num50 = 0; num50 < num14; num50++)
										{
											long num45 = array5[num48, num50];
											array5[num48, num50] = array5[num49, num50];
											array5[num49, num50] = num45;
										}
										goto IL_121E;
									}
								}
								for (int num51 = 0; num51 < num14; num51++)
								{
									array4[num16 + num48, num51] = (int)array5[num48, num51];
								}
							}
							break;
						}
						for (int num52 = 0; num52 < num14; num52++)
						{
							array4[num16 + num15 - 1, num52] = (int)array5[num15 - 1, num52];
						}
					}
					result = array4;
				}
			}
			return result;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000B9D74 File Offset: 0x000B7F74
		public static string smethod_7(GStruct49 gstruct49_0, uint[] uint_2 = null)
		{
			int num = 0;
			byte[] array = new byte[4];
			uint uint_3 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array, 4, ref num);
			int num2 = BitConverter.ToInt32(array, 0);
			bool flag = num2 > 1;
			string result;
			if (flag)
			{
				string text = null;
				long num3 = 0L;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				bool flag2 = uint_2 == null;
				if (flag2)
				{
					uint_2 = Class36.smethod_30(gstruct49_0);
				}
				uint num5 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				int num7 = 0;
				byte[] array2 = new byte[2];
				Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array2, 2, ref num);
				int num8 = 1;
				for (;;)
				{
					bool flag3 = num8 < 256;
					if (!flag3)
					{
						goto IL_32C;
					}
					bool flag4 = text != null && num8 > 40;
					if (flag4)
					{
						break;
					}
					bool flag5 = num2 > num7;
					if (!flag5)
					{
						goto IL_32B;
					}
					bool flag6 = num8 != num6;
					if (flag6)
					{
						uint num9 = num4 + (uint)(num8 * (int)Class53.gstruct51_15.uint_0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_16.uint_0, array, 4, ref num);
						bool flag7 = array[0] > 0;
						if (flag7)
						{
							num7++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_50.uint_0, array, 4, ref num);
							bool flag8 = BitConverter.ToInt32(array, 0) > 0 && Class22.smethod_30(num9 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137) > 0U;
							if (flag8)
							{
								int num10 = (int)Class22.smethod_30(num9 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
								bool flag9 = num10 != 10 && num10 != 21;
								if (flag9)
								{
									int num11 = (int)Class22.smethod_30(num9 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
									bool flag10 = num11 == 1 && array2[0] != 0 && array2[1] > 0;
									if (flag10)
									{
										uint[] array3 = new uint[]
										{
											Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										long num12 = Class60.smethod_18(uint_2, array3);
										bool flag11 = num12 != 0L && (text == null || num12 <= 1690000L) && (text == null || num3 > num12);
										if (flag11)
										{
											string text2 = Class22.smethod_28(num9 + Class53.gstruct51_16.uint_0, gstruct49_0.int_137, 32);
											for (int i = 0; i < gstruct49_0.string_18.Length; i++)
											{
												bool flag12 = text2 == gstruct49_0.string_18[i];
												if (flag12)
												{
													text = text2;
													num3 = num12;
													break;
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
						num7++;
					}
					num8++;
				}
				return text;
				IL_32B:
				IL_32C:
				result = text;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000BA0C8 File Offset: 0x000B82C8
		public static uint[] smethod_8(GStruct49 gstruct49_0, uint uint_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num2 = 0;
			byte[] array = new byte[4];
			uint uint_3 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array, 4, ref num2);
			byte[] array2 = new byte[2];
			Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, array2, 2, ref num2);
			int num3 = BitConverter.ToInt32(array, 0);
			bool flag = num3 <= 1 || array2[0] == 0 || array2[1] == 0;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				int num6 = 0;
				uint num7 = 1U;
				while (num7 < 256U)
				{
					bool flag2 = num3 <= num6;
					if (flag2)
					{
						break;
					}
					bool flag3 = (ulong)num7 != (ulong)((long)num5);
					if (flag3)
					{
						uint num8 = num + num7 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_16.uint_0, array, 4, ref num2);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num6++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_50.uint_0, array, 4, ref num2);
							bool flag5 = BitConverter.ToInt32(array, 0) <= 0;
							if (!flag5)
							{
								uint num9 = Class22.smethod_30(num8, gstruct49_0.int_137);
								bool flag6 = uint_2 == num9;
								if (flag6)
								{
									uint num10 = Class22.smethod_30(num8 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
									bool flag7 = num10 == 0U || array2[0] > 0;
									if (flag7)
									{
										uint num11 = Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
										uint num12 = Class22.smethod_30(num8 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
										return new uint[]
										{
											num7,
											num10,
											0U,
											num11,
											num12
										};
									}
								}
							}
						}
					}
					else
					{
						num6++;
					}
					IL_241:
					num7 += 1U;
					continue;
					goto IL_241;
				}
				result = null;
			}
			return result;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000BA338 File Offset: 0x000B8538
		public static int[,] smethod_9(GStruct49 gstruct49_0, uint uint_2, int int_4 = 600, uint[] uint_3 = null, int[] int_5 = null, bool bool_1 = false)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_30.uint_0;
			uint num3 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3;
			uint num6 = num + Class53.gstruct51_30.uint_0;
			Class22.smethod_30(num5 + Class53.gstruct51_88.uint_0, gstruct49_0.int_137);
			long num7 = (long)(int_4 * int_4);
			int num8 = (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			int num9 = (int)Class22.smethod_30(num5 + Class53.gstruct51_54.uint_0, gstruct49_0.int_137);
			int num10 = (int)Class22.smethod_30(num5 + Class53.gstruct51_56.uint_0, gstruct49_0.int_137);
			bool flag = uint_3 == null || uint_3.Length != 2 || uint_3[0] == 0U || uint_3[1] == 0U;
			if (flag)
			{
				uint_3 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
			}
			int num11 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag2 = (926 <= num11 && num11 <= 932) || num11 == Class38.int_0;
			new byte[1];
			new byte[10];
			new byte[16];
			byte[] array = new byte[60];
			int num12 = 10;
			int[,] array2 = new int[2, 10];
			long[,] array3 = null;
			long[,] array4 = null;
			int num13 = 0;
			int num14 = 0;
			int num15 = 0;
			byte[] array5 = new byte[4];
			uint uint_4 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_4, array5, 4, ref num15);
			int num16 = BitConverter.ToInt32(array5, 0);
			bool flag3 = num16 > 1;
			int[,] result;
			if (flag3)
			{
				uint[] array6 = new uint[2];
				int num17 = 0;
				int num18 = 0;
				uint num19 = 0U;
				for (num19 = 1U; num19 < 256U; num19 += 1U)
				{
					bool flag4 = bool_1 || num19 % 2U != 0U || Class83.smethod_12(gstruct49_0) != 1;
					if (!flag4)
					{
						array2[0, 0] = -100;
						array2[1, 0] = -100;
						return array2;
					}
					bool flag5 = num16 <= num18;
					if (flag5)
					{
						break;
					}
					bool flag6 = (ulong)num19 == (ulong)((long)num8);
					if (flag6)
					{
						num18++;
					}
					else
					{
						uint num20 = num4 + num19 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_16.uint_0, array5, 4, ref num15);
						bool flag7 = array5[0] == 0;
						if (!flag7)
						{
							num18++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_50.uint_0, array5, 4, ref num15);
							bool flag8 = BitConverter.ToInt32(array5, 0) <= 0;
							if (!flag8)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_52.uint_0, array5, 4, ref num15);
								int num21 = BitConverter.ToInt32(array5, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_43.uint_0, array5, 4, ref num15);
								int num22 = BitConverter.ToInt32(array5, 0);
								bool flag9 = num21 < 0 || (num21 > 0 && num22 <= 0);
								if (!flag9)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_55.uint_0, array5, 4, ref num15);
									int num23 = BitConverter.ToInt32(array5, 0);
									bool flag10 = num23 == 10 || num23 == 21;
									if (!flag10)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num20, array5, 4, ref num15);
										int num24 = BitConverter.ToInt32(array5, 0);
										bool flag11 = num24 == -1 || num24 == 0;
										if (!flag11)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_54.uint_0, array5, 4, ref num15);
											int num25 = BitConverter.ToInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_45.uint_0, array5, 4, ref num15);
											long num26 = (long)BitConverter.ToInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_26.uint_0 + 8U, array5, 4, ref num15);
											int num27 = BitConverter.ToInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_26.uint_0 + 12U, array5, 4, ref num15);
											int num28 = BitConverter.ToInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_51.uint_0, array5, 4, ref num15);
											int num29 = BitConverter.ToInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array5, 4, ref num15);
											array6[0] = BitConverter.ToUInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array5, 4, ref num15);
											array6[1] = BitConverter.ToUInt32(array5, 0);
											bool flag12 = false;
											for (;;)
											{
												bool flag13 = !flag12 && (uint_2 == 0U || (long)num24 != (long)((ulong)uint_2));
												if (!flag13)
												{
													goto IL_834;
												}
												long num30 = Class60.smethod_18(uint_3, array6);
												bool flag14 = num30 > num7;
												if (flag14)
												{
													break;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_53.uint_0, array5, 4, ref num15);
												int num31 = BitConverter.ToInt32(array5, 0);
												bool flag15 = num31 < 0 || num31 > 4;
												if (flag15)
												{
													break;
												}
												bool flag16 = num21 <= 0;
												if (!flag16)
												{
													goto IL_71A;
												}
												bool flag17 = gstruct49_0.int_27 <= 0 || (num9 > 0 && num25 == num9 && num25 != 4);
												if (flag17)
												{
													break;
												}
												bool flag18 = !flag2;
												if (!flag18)
												{
													goto IL_6AD;
												}
												bool flag19 = false;
												bool flag20 = int_5 != null;
												if (flag20)
												{
													for (int i = 0; i < int_5.Length; i++)
													{
														bool flag21 = (ulong)num19 == (ulong)((long)int_5[i]);
														if (flag21)
														{
															flag19 = true;
															break;
														}
													}
												}
												bool flag22 = flag19;
												if (flag22)
												{
													break;
												}
												bool flag23 = Form1.int_32 > 0 || num26 <= 0L;
												if (!flag23)
												{
													goto IL_6AA;
												}
												bool flag24 = num27 <= 0 || num28 <= 15 || num29 <= 0;
												if (flag24)
												{
													break;
												}
												bool flag25 = Form1.int_36 > 0;
												if (!flag25)
												{
													goto IL_6A9;
												}
												flag12 = true;
											}
											IL_A4D:
											goto IL_A6E;
											IL_71A:
											bool flag26 = num22 <= 0 || num25 == 0 || num9 == 0;
											if (flag26)
											{
												goto IL_A4D;
											}
											bool flag27 = num25 != num9 || num25 == 4;
											if (flag27)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_56.uint_0, array5, 4, ref num15);
												int num32 = BitConverter.ToInt32(array5, 0);
												bool flag28 = num10 + num32 > 1;
												if (flag28)
												{
													goto IL_8C2;
												}
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_61.uint_0, array5, 4, ref num15);
											uint num33 = BitConverter.ToUInt32(array5, 0);
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20, array5, 4, ref num15);
											uint num34 = BitConverter.ToUInt32(array5, 0);
											bool flag29 = num33 != num34;
											if (flag29)
											{
												goto IL_A4D;
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_62.uint_0, array5, 4, ref num15);
											gstruct49_0.gstruct43_0.uint_2 = BitConverter.ToUInt32(array5, 0);
											bool flag30 = gstruct49_0.gstruct43_0.uint_2 != 2U;
											if (flag30)
											{
												goto IL_A4D;
											}
											goto IL_82F;
											IL_6AD:
											Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_16.uint_0, array, array.Length, ref num15);
											string text = Class10.smethod_3(array);
											bool flag31 = !(text == string.Empty) && Class12.smethod_1(text, "[" + gstruct49_0.string_20 + "]") > 0;
											if (!flag31)
											{
												goto IL_714;
											}
											goto IL_A4D;
											IL_8C2:
											try
											{
												bool flag32 = num12 < 10;
												if (flag32)
												{
													num12 = 10;
												}
												bool flag33 = num21 == 0;
												if (flag33)
												{
													num13 = Class12.smethod_39(ref array3, 1, num12);
													array3[num13 - 1, 0] = (long)num21;
													array3[num13 - 1, 1] = (long)((ulong)num19);
													array3[num13 - 1, 2] = (long)num24;
													long num30;
													array3[num13 - 1, 3] = num30;
													array3[num13 - 1, 4] = (long)((ulong)array6[0]);
													array3[num13 - 1, 5] = (long)((ulong)array6[1]);
													array3[num13 - 1, 6] = (long)num27;
													array3[num13 - 1, 7] = (long)num28;
													array3[num13 - 1, 8] = (long)num29;
													array3[num13 - 1, 9] = num26;
												}
												else
												{
													num14 = Class12.smethod_39(ref array4, 1, num12);
													array4[num14 - 1, 0] = (long)num21;
													array4[num14 - 1, 1] = (long)((ulong)num19);
													array4[num14 - 1, 2] = (long)num24;
													long num30;
													array4[num14 - 1, 3] = num30;
													array4[num14 - 1, 4] = (long)((ulong)array6[0]);
													array4[num14 - 1, 5] = (long)((ulong)array6[1]);
													array4[num14 - 1, 6] = (long)num27;
													array4[num14 - 1, 7] = (long)num28;
													array4[num14 - 1, 8] = (long)num29;
													array4[num14 - 1, 9] = num26;
												}
												num17++;
											}
											catch
											{
											}
											goto IL_A4D;
											IL_82F:
											goto IL_8C2;
											IL_714:
											goto IL_82F;
											IL_6AA:
											goto IL_714;
											IL_6A9:
											goto IL_6AA;
											IL_834:
											array2[0, 0] = num21;
											array2[0, 1] = (int)num19;
											array2[0, 2] = num24;
											array2[0, 3] = (int)Class60.smethod_18(uint_3, array6);
											array2[0, 4] = (int)array6[0];
											array2[0, 5] = (int)array6[1];
											array2[0, 6] = num27;
											array2[0, 7] = num28;
											array2[0, 8] = num29;
											array2[0, 9] = (int)num26;
											array2[1, 1] = -1;
											return array2;
										}
									}
								}
							}
						}
					}
					IL_A6E:;
				}
				bool flag34 = num17 != 0;
				if (flag34)
				{
					array2 = new int[num13 + num14, num12];
					bool flag35 = num14 > 0;
					if (flag35)
					{
						for (;;)
						{
							IL_B94:
							for (int j = 0; j < num14 - 1; j++)
							{
								for (int k = j; k < num14; k++)
								{
									bool flag36 = array4[k, 3] >= array4[j, 3];
									if (!flag36)
									{
										for (int l = 0; l < num12; l++)
										{
											long num35 = array4[j, l];
											array4[j, l] = array4[k, l];
											array4[k, l] = num35;
										}
										goto IL_B94;
									}
								}
								for (int m = 0; m < num12; m++)
								{
									array2[j, m] = (int)array4[j, m];
								}
							}
							break;
						}
						for (int n = 0; n < num12; n++)
						{
							array2[num14 - 1, n] = (int)array4[num14 - 1, n];
						}
					}
					bool flag37 = num13 > 0;
					if (flag37)
					{
						for (;;)
						{
							IL_CC1:
							for (int num36 = 0; num36 < num13 - 1; num36++)
							{
								for (int num37 = num36; num37 < num13; num37++)
								{
									bool flag38 = array3[num37, 3] >= array3[num36, 3];
									if (!flag38)
									{
										for (int num38 = 0; num38 < num12; num38++)
										{
											long num35 = array3[num36, num38];
											array3[num36, num38] = array3[num37, num38];
											array3[num37, num38] = num35;
										}
										goto IL_CC1;
									}
								}
								for (int num39 = 0; num39 < num12; num39++)
								{
									array2[num14 + num36, num39] = (int)array3[num36, num39];
								}
							}
							break;
						}
						for (int num40 = 0; num40 < num12; num40++)
						{
							array2[num14 + num13 - 1, num40] = (int)array3[num13 - 1, num40];
						}
					}
					result = array2;
				}
				else
				{
					result = null;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x000BB074 File Offset: 0x000B9274
		public static int smethod_10(GStruct49 gstruct49_0, uint uint_2)
		{
			bool flag = gstruct49_0.gstruct48_0.int_0 == 0 || gstruct49_0.gstruct48_0.int_1 <= 0 || uint_2 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				bool flag2 = gstruct49_0.gstruct48_0.int_6 > 0;
				if (flag2)
				{
					byte[] array = new byte[8];
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_26 * 4U, array, 8, ref num);
					long num2 = BitConverter.ToInt64(array, 0);
					long ticks = DateTime.Now.Ticks;
					long num3 = (long)new TimeSpan(ticks - num2).TotalMilliseconds;
					bool flag3 = num2 > 0L && num3 <= (long)(gstruct49_0.gstruct48_0.int_6 * 1000);
					if (flag3)
					{
						return 0;
					}
					array = BitConverter.GetBytes(ticks);
					Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_26 * 4U, array, 8, ref num);
				}
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
				uint num4 = BitConverter.ToUInt32(array2, 0);
				bool flag4 = num4 > 0U;
				if (flag4)
				{
					uint num5 = num4 + uint_2 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num5, array2, 4, ref num);
					int num6 = BitConverter.ToInt32(array2, 0);
					bool flag5 = num6 != 0;
					if (flag5)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_52.uint_0, array2, 4, ref num);
						bool flag6 = BitConverter.ToInt32(array2, 0) == 0 && gstruct49_0.gstruct48_0.int_5 == 0;
						if (flag6)
						{
							result = 0;
						}
						else
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
							uint num7 = BitConverter.ToUInt32(array2, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
							uint num8 = BitConverter.ToUInt32(array2, 0) * Class53.gstruct51_15.uint_0;
							uint num9 = num4 + num8;
							uint[] array3 = new uint[2];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array2, 4, ref num);
							array3[0] = BitConverter.ToUInt32(array2, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array2, 4, ref num);
							array3[1] = BitConverter.ToUInt32(array2, 0);
							uint[] array4 = new uint[2];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array2, 4, ref num);
							array4[0] = BitConverter.ToUInt32(array2, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array2, 4, ref num);
							array4[1] = BitConverter.ToUInt32(array2, 0);
							bool flag7 = gstruct49_0.gstruct48_0.int_2 == 0;
							if (flag7)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_24 * 4U, array2, 4, ref num);
								bool flag8 = BitConverter.ToInt32(array2, 0) != num6;
								if (flag8)
								{
									array2 = BitConverter.GetBytes(num6);
									Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_24 * 4U, array2, 4, ref num);
									goto IL_4D9;
								}
							}
							bool flag9 = gstruct49_0.gstruct48_0.int_2 == 1;
							if (flag9)
							{
								byte[] array5 = new byte[8];
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_25 * 4U, array5, 8, ref num);
								long num10 = BitConverter.ToInt64(array5, 0);
								long ticks2 = DateTime.Now.Ticks;
								long num11 = (long)new TimeSpan(ticks2 - num10).TotalMilliseconds;
								bool flag10 = num10 == 0L || num11 > (long)gstruct49_0.gstruct48_0.int_3;
								if (flag10)
								{
									array5 = BitConverter.GetBytes(ticks2);
									Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_25 * 4U, array5, 8, ref num);
									goto IL_4D9;
								}
							}
							bool flag11 = gstruct49_0.gstruct48_0.int_2 == 2;
							if (flag11)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_24 * 4U, array2, 4, ref num);
								bool flag12 = BitConverter.ToInt32(array2, 0) == num6;
								if (flag12)
								{
									long num12 = Class60.smethod_18(array4, array3);
									long num13 = (long)(gstruct49_0.gstruct48_0.int_7 * gstruct49_0.gstruct48_0.int_7);
									bool flag13 = num12 <= num13;
									if (flag13)
									{
										goto IL_4D0;
									}
								}
								else
								{
									array2 = BitConverter.GetBytes(num6);
									Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_24 * 4U, array2, 4, ref num);
								}
								goto IL_4D9;
							}
							IL_4D0:
							return 0;
							IL_4D9:
							int i = 0;
							int num14 = 0;
							byte[] byte_ = new byte[4];
							while (i < 30)
							{
								bool flag14 = num14 >= 5;
								if (flag14)
								{
									break;
								}
								Class22.WriteProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_72.uint_0, byte_, 4, ref num);
								Thread.Sleep(10);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_55.uint_0, array2, 4, ref num);
								num14 = ((array2[0] == 1) ? (num14 + 1) : 0);
								i++;
							}
							bool flag15 = gstruct49_0.gstruct48_0.int_4 > 0;
							if (flag15)
							{
								uint[] array6 = Class83.smethod_10(array4, array3);
								uint uint_3 = (array6[1] << 16) + array6[0];
								Class83.smethod_7(gstruct49_0, uint_3);
								Class77.smethod_9(gstruct49_0, null);
								Class77.smethod_5(gstruct49_0, gstruct49_0.gstruct48_0.int_1, 6, 1);
								Thread.Sleep(120);
								Class22.smethod_76(gstruct49_0.uint_4, 117);
							}
							else
							{
								Class22.WriteProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(gstruct49_0.gstruct48_0.int_1), 4, ref num);
								Class22.WriteProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(uint_2), 4, ref num);
							}
							Thread.Sleep(100);
							result = 1;
						}
					}
					else
					{
						result = 0;
					}
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x04000346 RID: 838
		public static bool bool_0 = false;

		// Token: 0x04000347 RID: 839
		public static int[] int_0 = null;

		// Token: 0x04000348 RID: 840
		public static GStruct24[] gstruct24_0 = null;

		// Token: 0x04000349 RID: 841
		public static string string_0 = "BhoAttack.txt";

		// Token: 0x0400034A RID: 842
		public static string string_1 = "BhoNoAttack.txt";

		// Token: 0x0400034B RID: 843
		public static string string_2 = "PlrNoAttack.txt";

		// Token: 0x0400034C RID: 844
		public static int int_1 = 0;

		// Token: 0x0400034D RID: 845
		public static int int_2 = 0;

		// Token: 0x0400034E RID: 846
		public static int int_3 = 0;

		// Token: 0x0400034F RID: 847
		public static string[] string_3 = null;

		// Token: 0x04000350 RID: 848
		public static string[] string_4 = null;

		// Token: 0x04000351 RID: 849
		public static uint[] uint_0 = null;

		// Token: 0x04000352 RID: 850
		public static uint[] uint_1 = null;

		// Token: 0x04000353 RID: 851
		public static string[] string_5 = null;
	}
}
