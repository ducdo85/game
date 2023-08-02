using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200005F RID: 95
	internal class Class98
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x000EDFA4 File Offset: 0x000EC1A4
		public static uint smethod_0(uint[] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 == null || uint_1 == null || uint_0[0] == 0U || uint_0[1] == 0U || uint_1[0] == 0U || uint_1[1] == 0U;
			uint result;
			if (flag)
			{
				result = 2147483647U;
			}
			else
			{
				long num = (long)(uint_0[0] - uint_1[0]);
				long num2 = (long)(uint_0[1] - uint_1[1]);
				long num3 = num * num + num2 * num2;
				bool flag2 = num3 == 0L;
				if (flag2)
				{
					num3 = 1L;
				}
				result = (uint)num3;
			}
			return result;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x000EE010 File Offset: 0x000EC210
		public static int smethod_1(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 == 0U || Class53.gstruct51_9.uint_0 == 0U || Class53.gstruct51_10.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				result = BitConverter.ToInt32(array, 0);
			}
			return result;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000EE094 File Offset: 0x000EC294
		public static int smethod_2(GStruct49 gstruct49_0, uint uint_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + uint_0 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_85.uint_0, array, 4, ref num);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000EE108 File Offset: 0x000EC308
		private static uint smethod_3(GStruct49 gstruct49_0, int int_0, uint uint_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137) + (uint)((int)((long)int_0 * (long)((ulong)Class53.gstruct51_15.uint_0)));
			return Class22.smethod_30(num + uint_0, gstruct49_0.int_137);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x000EE150 File Offset: 0x000EC350
		private static void smethod_4(GStruct49 gstruct49_0, int int_0, uint uint_0, int int_1)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137) + (uint)((int)((long)int_0 * (long)((ulong)Class53.gstruct51_15.uint_0)));
			Class22.smethod_31(num + uint_0, gstruct49_0.int_137, (uint)int_1, 4);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x000EE198 File Offset: 0x000EC398
		private static string smethod_5(GStruct49 gstruct49_0, int int_0, uint uint_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137) + (uint)((int)((long)int_0 * (long)((ulong)Class53.gstruct51_15.uint_0)));
			return Class22.smethod_28(num + uint_0, gstruct49_0.int_137, 255);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x000EE1E4 File Offset: 0x000EC3E4
		public static int smethod_6(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_26.uint_0 + 8U);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000EE20C File Offset: 0x000EC40C
		public static int smethod_7(GStruct49 gstruct49_0, int int_0)
		{
			return (int)(Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_26.uint_0 + 12U) / 4U);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x000EE234 File Offset: 0x000EC434
		public static int smethod_8(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_43.uint_0);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x000EE258 File Offset: 0x000EC458
		public static int smethod_9(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_52.uint_0);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000EE27C File Offset: 0x000EC47C
		public static int smethod_10(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_17.uint_0);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000EE2A0 File Offset: 0x000EC4A0
		public static int smethod_11(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_50.uint_0);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000EE2C4 File Offset: 0x000EC4C4
		public static int smethod_12(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_55.uint_0);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000EE2E8 File Offset: 0x000EC4E8
		public static int smethod_13(GStruct49 gstruct49_0, string string_0, int int_0 = -1, bool bool_0 = false, int int_1 = -1, int int_2 = 80)
		{
			bool flag = string_0 != null && !(string_0 == "");
			int result;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				string[] array2 = new string[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = array[i].Trim().ToLower();
				}
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2;
				int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
				int num7 = 0;
				byte[] array3 = new byte[int_2];
				byte[] array4 = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array4, 4, ref num7);
				int num8 = BitConverter.ToInt32(array4, 0);
				bool flag2 = num8 <= 0;
				if (flag2)
				{
					result = -1;
				}
				else
				{
					int num9 = (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
					int num10 = 0;
					uint num11 = 1U;
					while (num11 < 256U && num8 > num10)
					{
						bool flag3 = (ulong)num11 == (ulong)((long)num9);
						if (flag3)
						{
							num10++;
						}
						else
						{
							uint num12 = num3 + num11 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array4, 4, ref num7);
							bool flag4 = array4[0] == 0;
							if (!flag4)
							{
								num10++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_50.uint_0, array4, 4, ref num7);
								bool flag5 = BitConverter.ToInt32(array4, 0) <= 0;
								if (!flag5)
								{
									bool flag6 = 0 <= int_0;
									if (flag6)
									{
										int num13 = (int)Class22.smethod_30(num12 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137);
										bool flag7 = num13 != int_0;
										if (flag7)
										{
											goto IL_3C8;
										}
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array3, array3.Length, ref num7);
									string text = Class10.smethod_3(array3);
									bool flag8 = text == string.Empty;
									if (!flag8)
									{
										string string_ = text.Trim().ToLower();
										bool flag9 = false;
										for (int j = 0; j < array.Length; j++)
										{
											bool flag10 = array[j] == text || (!bool_0 && 0 <= Class12.smethod_1(string_, array2[j]));
											if (flag10)
											{
												flag9 = true;
												break;
											}
										}
										bool flag11 = !flag9;
										if (!flag11)
										{
											bool flag12 = int_1 > 0 && num5 > 0 && num6 > 0;
											if (!flag12)
											{
												return (int)num11;
											}
											int num14 = (int)Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137);
											int num15 = (int)Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137);
											bool flag13 = num14 > 0 && num15 > 0;
											if (flag13)
											{
												long num16 = (long)(num5 - num14);
												long num17 = (long)(num6 - num15);
												bool flag14 = num16 * num16 + num17 * num17 <= (long)int_1;
												if (flag14)
												{
													return (int)num11;
												}
											}
										}
									}
								}
							}
						}
						IL_3C8:
						num11 += 1U;
					}
					result = -1;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000EE6EC File Offset: 0x000EC8EC
		public static int smethod_14(GStruct49 gstruct49_0, string string_0, ref uint[] uint_0, int int_0 = 1)
		{
			uint_0 = null;
			bool flag = string_0 == null || string_0 == string.Empty;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[80];
				uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				byte[] array2 = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num);
				int num3 = BitConverter.ToInt32(array2, 0);
				bool flag2 = num3 <= 0;
				if (flag2)
				{
					result = -1;
				}
				else
				{
					int num4 = 0;
					for (uint num5 = 1U; num5 < 256U; num5 += 1U)
					{
						bool flag3 = num3 <= num4;
						if (flag3)
						{
							break;
						}
						uint num6 = num2 + num5 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, 4, ref num);
						bool flag4 = array2[0] == 0;
						if (!flag4)
						{
							num4++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array2, 4, ref num);
							bool flag5 = BitConverter.ToInt32(array2, 0) > 0 && (ulong)Class22.smethod_30(num6 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) == (ulong)((long)int_0);
							if (flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, array.Length, ref num);
								bool flag6 = !(Class10.smethod_3(array) != string_0);
								if (flag6)
								{
									uint_0 = new uint[]
									{
										Class22.smethod_30(num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									return (int)num5;
								}
							}
						}
					}
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000EE8FC File Offset: 0x000ECAFC
		public static int smethod_15(GStruct49 gstruct49_0, string string_0, ref uint[] uint_0, int int_0 = 3, bool bool_0 = true, int int_1 = -1, int[] int_2 = null)
		{
			uint_0 = null;
			bool flag = string_0 != null && !(string_0 == string.Empty);
			int result;
			if (flag)
			{
				string[] array = string_0.Split(new char[]
				{
					'|'
				});
				string[] array2 = new string[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = array[i].Trim();
					array2[i] = array[i].ToUpper();
				}
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2;
				uint[] uint_ = new uint[]
				{
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				int num5 = 0;
				byte[] array3 = new byte[80];
				byte[] array4 = new byte[4];
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array4, 4, ref num5);
				int num6 = BitConverter.ToInt32(array4, 0);
				bool flag2 = num6 <= 0;
				if (flag2)
				{
					result = 0;
				}
				else
				{
					long num7 = 0L;
					uint num8 = 0U;
					int num9 = 0;
					for (uint num10 = 1U; num10 < 256U; num10 += 1U)
					{
						bool flag3 = num10 % 50U == 0U;
						if (flag3)
						{
							Thread.Sleep(30);
						}
						bool flag4 = num6 <= num9;
						if (flag4)
						{
							break;
						}
						uint num11 = num3 + num10 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_16.uint_0, array4, 4, ref num5);
						bool flag5 = array4[0] == 0;
						if (!flag5)
						{
							num9++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_50.uint_0, array4, 4, ref num5);
							bool flag6 = BitConverter.ToInt32(array4, 0) <= 0 || (ulong)Class22.smethod_30(num11 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) != (ulong)((long)int_0);
							if (!flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_16.uint_0, array3, array3.Length, ref num5);
								string text = Class10.smethod_3(array3).Trim();
								string string_ = text.ToUpper();
								bool flag7 = false;
								for (int j = 0; j < array.Length; j++)
								{
									bool flag8 = text == array[j] || (!bool_0 && 0 <= Class12.smethod_1(string_, array2[j]));
									if (flag8)
									{
										flag7 = true;
										break;
									}
								}
								bool flag9 = !flag7;
								if (!flag9)
								{
									bool flag10 = int_2 != null;
									if (flag10)
									{
										for (int k = 0; k < int_2.Length; k++)
										{
											bool flag11 = (long)int_2[k] == (long)((ulong)num10);
											if (flag11)
											{
												flag7 = false;
												break;
											}
										}
									}
									bool flag12 = flag7;
									if (flag12)
									{
										uint[] array5 = new uint[]
										{
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										long num12 = Class60.smethod_18(uint_, array5);
										bool flag13 = (int_1 <= 0 || num12 <= (long)(int_1 * int_1)) && (num8 == 0U || num12 < num7);
										if (flag13)
										{
											num8 = num10;
											uint_0 = new uint[]
											{
												array5[0],
												array5[1]
											};
											num7 = num12;
										}
									}
								}
							}
						}
					}
					result = (int)num8;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000EED1C File Offset: 0x000ECF1C
		public static string smethod_16(GStruct49 gstruct49_0, int int_0, ref uint[] uint_0, int int_1 = 60)
		{
			uint_0 = null;
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			GStruct51 gstruct51_ = Class53.gstruct51_15;
			uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num3 = num2 + (uint)(int_0 * (int)Class53.gstruct51_15.uint_0);
			bool flag = Class22.smethod_30(num3 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137) <= 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				int num4 = 0;
				byte[] array = new byte[1];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_16.uint_0, array, 1, ref num4);
				bool flag2 = array[0] > 0;
				if (flag2)
				{
					array = new byte[int_1];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_16.uint_0, array, int_1, ref num4);
					uint_0 = new uint[]
					{
						Class22.smethod_30(num3 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num3 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					result = Class10.smethod_3(array);
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x000EEE7C File Offset: 0x000ED07C
		public static bool smethod_17(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			GStruct51 gstruct51_ = Class53.gstruct51_15;
			uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num3 = num2 + (uint)(int_0 * (int)Class53.gstruct51_15.uint_0);
			int num4 = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_50.uint_0, array, 4, ref num4);
			return BitConverter.ToInt32(array, 0) > 0;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000EEF1C File Offset: 0x000ED11C
		public static int smethod_18(GStruct49 gstruct49_0, string string_0, ref uint[] uint_0, int int_0 = 60000, uint[] uint_1 = null)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num3 = num2 * Class53.gstruct51_15.uint_0;
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3;
			bool flag = uint_1 == null;
			if (flag)
			{
				uint_1 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
			}
			char[] array = string_0.ToCharArray();
			int num6 = 0;
			byte[] array2 = new byte[80];
			byte[] array3 = new byte[4];
			uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array3, 4, ref num6);
			int num7 = BitConverter.ToInt32(array3, 0);
			bool flag2 = num7 <= 1;
			int result;
			if (flag2)
			{
				result = 0;
			}
			else
			{
				uint num8 = 0U;
				long num9 = 0L;
				int num10 = 0;
				for (uint num11 = 1U; num11 < 256U; num11 += 1U)
				{
					bool flag3 = num7 <= num10;
					if (flag3)
					{
						break;
					}
					bool flag4 = num11 == num2;
					if (flag4)
					{
						num10++;
					}
					else
					{
						uint num12 = num4 + num11 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array3, 4, ref num6);
						bool flag5 = array3[0] == 0;
						if (!flag5)
						{
							num10++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_50.uint_0, array3, 4, ref num6);
							bool flag6 = BitConverter.ToInt32(array3, 0) <= 0 || Class22.smethod_30(num12 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) != 3U;
							if (!flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array2, 1, ref num6);
								bool flag7 = (char)array2[0] != array[0];
								if (!flag7)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num6);
									bool flag8 = Class10.smethod_3(array2).IndexOf(string_0) == 0;
									if (flag8)
									{
										uint[] array4 = new uint[]
										{
											Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										long num13 = (long)((ulong)Class98.smethod_0(uint_1, array4));
										bool flag9 = num13 > 0L && num13 < (long)int_0 && (num8 == 0U || num13 < num9);
										if (flag9)
										{
											num8 = num11;
											num9 = num13;
											uint_0 = array4;
										}
									}
								}
							}
						}
					}
				}
				result = (int)num8;
			}
			return result;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000EF250 File Offset: 0x000ED450
		public static uint[] smethod_19(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0);
			uint num2 = Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0);
			bool flag = num == 0U || num2 == 0U;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = new uint[]
				{
					num,
					num2
				};
			}
			return result;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000EF2BC File Offset: 0x000ED4BC
		public static long[] smethod_20(GStruct49 gstruct49_0, int int_0)
		{
			return new long[]
			{
				(long)((ulong)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_45.uint_0)),
				(long)((ulong)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_47.uint_0))
			};
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000EF300 File Offset: 0x000ED500
		public static long[] smethod_21(GStruct49 gstruct49_0, int int_0)
		{
			return new long[]
			{
				(long)((ulong)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_46.uint_0)),
				(long)((ulong)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_48.uint_0))
			};
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000EF344 File Offset: 0x000ED544
		public static string smethod_22(GStruct49 gstruct49_0, int int_0, int int_1 = 0)
		{
			string result = "";
			int num = Class98.smethod_11(gstruct49_0, int_0);
			int num2 = Class98.smethod_9(gstruct49_0, int_0);
			bool flag = num > 0 && (int_1 < 0 || num2 == int_1);
			if (flag)
			{
				result = Class98.smethod_5(gstruct49_0, int_0, Class53.gstruct51_16.uint_0);
			}
			return result;
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000EF398 File Offset: 0x000ED598
		public static string smethod_23(GStruct49 gstruct49_0, int int_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num2 = num + (uint)(int_0 * (int)Class53.gstruct51_15.uint_0);
			int num3 = 0;
			byte[] array = new byte[30];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_88.uint_0, array2, 4, ref num3);
			uint num4 = BitConverter.ToUInt32(array2, 0);
			bool flag = num4 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_89.uint_0, array, array.Length, ref num3);
				string text = Class10.smethod_3(array);
				bool flag2 = !(text == string.Empty);
				if (flag2)
				{
					bool flag3 = Class12.smethod_6(text) != num4;
					if (flag3)
					{
						string text2 = string.Empty;
						int num5 = 0;
						for (;;)
						{
							bool flag4 = num5 < text.Length;
							if (!flag4)
							{
								goto IL_11F;
							}
							text2 += text[num5].ToString();
							bool flag5 = Class12.smethod_6(text2) == num4;
							if (flag5)
							{
								break;
							}
							num5++;
						}
						return text2;
						IL_11F:
						result = string.Empty;
					}
					else
					{
						result = text;
					}
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000EF4EC File Offset: 0x000ED6EC
		public static void smethod_24(GStruct49 gstruct49_0, ref string[] string_0)
		{
			byte[] array = new byte[48];
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num2 = 0;
			byte[] array2 = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num2);
			int num3 = BitConverter.ToInt32(array2, 0);
			int num4 = 0;
			for (uint num5 = 1U; num5 < 256U; num5 += 1U)
			{
				bool flag = num3 <= num4;
				if (flag)
				{
					break;
				}
				uint num6 = num + num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, 4, ref num2);
				bool flag2 = array2[0] == 0;
				if (!flag2)
				{
					num4++;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array2, 4, ref num2);
					bool flag3 = BitConverter.ToInt32(array2, 0) <= 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_88.uint_0, array2, 4, ref num2);
						uint num7 = BitConverter.ToUInt32(array2, 0);
						bool flag4 = num7 == 0U;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_89.uint_0, array, array.Length, ref num2);
							string text = Class10.smethod_3(array);
							bool flag5 = text == null || text == string.Empty;
							if (!flag5)
							{
								string text2 = string.Empty;
								bool flag6 = Class12.smethod_6(text) == num7;
								if (flag6)
								{
									text2 = text;
								}
								else
								{
									string text3 = string.Empty;
									for (int i = 0; i < text.Length; i++)
									{
										text3 += text[i].ToString();
										bool flag7 = Class12.smethod_6(text3) == num7;
										if (flag7)
										{
											text2 = text3;
											break;
										}
									}
								}
								bool flag8 = text2 == string.Empty;
								if (!flag8)
								{
									bool flag9 = string_0 != null;
									if (flag9)
									{
										bool flag10 = false;
										for (int j = 0; j < string_0.Length; j++)
										{
											bool flag11 = text2 == string_0[j];
											if (flag11)
											{
												flag10 = true;
												break;
											}
										}
										bool flag12 = !flag10;
										if (flag12)
										{
											Array.Resize<string>(ref string_0, string_0.Length + 1);
											string_0[string_0.Length - 1] = text2;
										}
									}
									else
									{
										string_0 = new string[]
										{
											text2
										};
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000EF790 File Offset: 0x000ED990
		public static void smethod_25(GStruct49 gstruct49_0, ref string[] string_0, int int_0 = -1, string[] string_1 = null)
		{
			byte[] array = new byte[53];
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num2 = 0;
			byte[] array2 = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num2);
			int num3 = BitConverter.ToInt32(array2, 0);
			int num4 = 0;
			uint num5 = 1U;
			while (num5 < 256U && num3 > num4)
			{
				uint num6 = num + num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, 4, ref num2);
				bool flag = array2[0] == 0;
				if (!flag)
				{
					num4++;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array2, 4, ref num2);
					bool flag2 = BitConverter.ToInt32(array2, 0) <= 0;
					if (!flag2)
					{
						bool flag3 = 0 <= int_0;
						if (flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_52.uint_0, array2, 4, ref num2);
							uint num7 = BitConverter.ToUInt32(array2, 0);
							bool flag4 = (ulong)num7 != (ulong)((long)int_0);
							if (flag4)
							{
								goto IL_233;
							}
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, array.Length, ref num2);
						string text = Class10.smethod_3(array);
						bool flag5 = text == string.Empty;
						if (!flag5)
						{
							bool flag6 = string_1 != null;
							if (flag6)
							{
								bool flag7 = false;
								for (int i = 0; i < string_1.Length; i++)
								{
									bool flag8 = text == string_1[i];
									if (flag8)
									{
										flag7 = true;
										break;
									}
								}
								bool flag9 = flag7;
								if (flag9)
								{
									goto IL_233;
								}
							}
							bool flag10 = string_0 != null;
							if (flag10)
							{
								bool flag11 = false;
								for (int j = 0; j < string_0.Length; j++)
								{
									bool flag12 = text == string_0[j];
									if (flag12)
									{
										flag11 = true;
										break;
									}
								}
								bool flag13 = !flag11;
								if (flag13)
								{
									Array.Resize<string>(ref string_0, string_0.Length + 1);
									string_0[string_0.Length - 1] = text;
								}
							}
							else
							{
								string_0 = new string[]
								{
									text
								};
							}
						}
					}
				}
				IL_233:
				num5 += 1U;
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000EF9F4 File Offset: 0x000EDBF4
		public static void smethod_26(GStruct49 gstruct49_0, ref GStruct23[] gstruct23_0, int int_0 = -1, string[] string_0 = null)
		{
			byte[] array = new byte[53];
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			int num2 = 0;
			byte[] array2 = new byte[4];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array2, 4, ref num2);
			int num3 = BitConverter.ToInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num2);
			int int_ = BitConverter.ToInt32(array2, 0);
			int num4 = 0;
			uint num5 = 1U;
			while (num5 < 256U && num3 > num4)
			{
				uint num6 = num + num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, 4, ref num2);
				bool flag = array2[0] == 0;
				if (!flag)
				{
					num4++;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array2, 4, ref num2);
					bool flag2 = BitConverter.ToInt32(array2, 0) <= 0;
					if (!flag2)
					{
						bool flag3 = 0 <= int_0;
						if (flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_52.uint_0, array2, 4, ref num2);
							uint num7 = BitConverter.ToUInt32(array2, 0);
							bool flag4 = (ulong)num7 != (ulong)((long)int_0);
							if (flag4)
							{
								goto IL_33A;
							}
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, array.Length, ref num2);
						string text = Class10.smethod_3(array);
						bool flag5 = text == string.Empty;
						if (!flag5)
						{
							bool flag6 = string_0 != null;
							if (flag6)
							{
								bool flag7 = false;
								for (int i = 0; i < string_0.Length; i++)
								{
									bool flag8 = text == string_0[i];
									if (flag8)
									{
										flag7 = true;
										break;
									}
								}
								bool flag9 = flag7;
								if (flag9)
								{
									goto IL_33A;
								}
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array2, 4, ref num2);
							uint num8 = BitConverter.ToUInt32(array2, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array2, 4, ref num2);
							uint num9 = BitConverter.ToUInt32(array2, 0);
							bool flag10 = gstruct23_0 == null;
							if (flag10)
							{
								gstruct23_0 = new GStruct23[]
								{
									new GStruct23
									{
										string_0 = text,
										uint_0 = new uint[]
										{
											num8,
											num9
										},
										int_0 = int_
									}
								};
							}
							else
							{
								bool flag11 = false;
								for (int j = 0; j < gstruct23_0.Length; j++)
								{
									bool flag12 = text == gstruct23_0[j].string_0;
									if (flag12)
									{
										flag11 = true;
										break;
									}
								}
								bool flag13 = !flag11;
								if (flag13)
								{
									Array.Resize<GStruct23>(ref gstruct23_0, gstruct23_0.Length + 1);
									gstruct23_0[gstruct23_0.Length - 1].string_0 = text;
									gstruct23_0[gstruct23_0.Length - 1].uint_0 = new uint[]
									{
										num8,
										num9
									};
									gstruct23_0[gstruct23_0.Length - 1].int_0 = int_;
								}
							}
						}
					}
				}
				IL_33A:
				num5 += 1U;
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000EFD5C File Offset: 0x000EDF5C
		public static int smethod_27(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_66.uint_0);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000EFD80 File Offset: 0x000EDF80
		public static int smethod_28(GStruct49 gstruct49_0, int int_0)
		{
			return (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_56.uint_0);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x000EFDA4 File Offset: 0x000EDFA4
		public static int smethod_29(GStruct49 gstruct49_0, int int_0)
		{
			int num = (int)Class98.smethod_3(gstruct49_0, int_0, Class53.gstruct51_54.uint_0);
			bool flag = num > 4;
			if (flag)
			{
				num = 5;
			}
			return num;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000EFDD4 File Offset: 0x000EDFD4
		public static int smethod_30(GStruct49 gstruct49_0, int int_0, int int_1)
		{
			uint uint_ = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * (uint)int_1;
			return (int)Class98.smethod_3(gstruct49_0, int_0, uint_);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x000EFE14 File Offset: 0x000EE014
		public static int smethod_31(GStruct49 gstruct49_0, int int_0, int int_1)
		{
			int num = 0;
			bool flag = gstruct49_0.int_4 == null;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				for (int i = 0; i < gstruct49_0.int_4.GetLength(0); i++)
				{
					bool flag2 = int_1 == gstruct49_0.int_4[i, 0];
					if (flag2)
					{
						num = gstruct49_0.int_4[i, 1];
						break;
					}
				}
				bool flag3 = num != 0;
				if (flag3)
				{
					uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
					uint num3 = num2 + (uint)(int_0 * (int)Class53.gstruct51_15.uint_0);
					for (uint num4 = 0U; num4 < 6U; num4 += 1U)
					{
						uint num5 = Class22.smethod_30(num3 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num4, gstruct49_0.int_137);
						bool flag4 = (ulong)num5 == (ulong)((long)num);
						if (flag4)
						{
							return num;
						}
					}
					result = 0;
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}
	}
}
