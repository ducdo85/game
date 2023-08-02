using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200003A RID: 58
	internal class Class60
	{
		// Token: 0x0600034B RID: 843 RVA: 0x0009DCD8 File Offset: 0x0009BED8
		static Class60()
		{
			string[,] array = new string[8, 3];
			array[0, 0] = "T­¬ng D­¬ng";
			array[0, 1] = "Ba L¨ng huyÖn";
			array[0, 2] = "Nam Nh¹c trÊn";
			array[1, 0] = "D­¬ng Ch©u";
			array[1, 1] = "§¹o H­¬ng th«n";
			array[2, 0] = "Ph­îng T­êng";
			array[2, 1] = "Long M«n trÊn";
			array[3, 0] = "Ph­îng T­êng";
			array[3, 1] = "VÜnh L¹c trÊn";
			array[4, 0] = "§¹i L";
			array[4, 1] = "Th¹ch Cæ trÊn";
			array[5, 0] = "Thµnh §«";
			array[5, 1] = "Giang T©n Th«n";
			array[6, 0] = "L©m An";
			array[6, 1] = "Long TuyÒn th«n";
			array[7, 0] = "BiÖn Kinh";
			array[7, 1] = "Chu Tiªn trÊn";
			Class60.string_0 = array;
			string[,] array2 = new string[8, 3];
			array2[0, 0] = "T­¬ng D­¬ng";
			int[,] array_ = new int[8, 3];
			Class11.smethod_4(array_, 285638);
			Class60.int_0 = array_;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0009DE00 File Offset: 0x0009C000
		public static int smethod_0(uint uint_0, int[] int_1, int int_2)
		{
			int num = 0;
			int num2 = 0;
			int_2 += 50;
			bool flag = int_1.Length > 5;
			if (flag)
			{
				for (int i = 0; i < 3; i++)
				{
					bool flag2 = int_1[i] > 0 && int_1[i + 3] > 0;
					if (flag2)
					{
						bool flag3 = num2 != num;
						if (flag3)
						{
							num2 = num;
							Thread.Sleep(int_2);
						}
						Class22.smethod_4(uint_0, (uint)int_1[i + 3]);
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0009DE80 File Offset: 0x0009C080
		public static int smethod_1(long long_0)
		{
			bool flag = long_0 < 600000L;
			int result;
			if (flag)
			{
				result = 3000;
			}
			else
			{
				bool flag2 = long_0 >= 1000000L;
				if (flag2)
				{
					bool flag3 = long_0 >= 1500000L;
					if (flag3)
					{
						bool flag4 = long_0 >= 2000000L;
						if (flag4)
						{
							bool flag5 = long_0 >= 2500000L;
							if (flag5)
							{
								bool flag6 = long_0 < 3000000L;
								if (flag6)
								{
									result = 8000;
								}
								else
								{
									bool flag7 = long_0 >= 3500000L;
									if (flag7)
									{
										result = 10000;
									}
									else
									{
										result = 9000;
									}
								}
							}
							else
							{
								result = 7000;
							}
						}
						else
						{
							result = 6000;
						}
					}
					else
					{
						result = 5000;
					}
				}
				else
				{
					result = 4000;
				}
			}
			return result;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0009DF4C File Offset: 0x0009C14C
		public static void smethod_2(GStruct49 gstruct49_0, uint[] uint_0, uint[] uint_1, int int_1 = 1000)
		{
			bool flag = !Class12.smethod_62(uint_0) || !Class12.smethod_62(uint_1);
			if (!flag)
			{
				int value = (uint_1[0] < uint_0[0]) ? 210 : 45;
				uint num = 400U;
				double num2 = (double)Math.Abs(value) * 3.14 / 180.0;
				uint[] uint_2 = new uint[]
				{
					(uint)(uint_0[0] + num * Math.Cos(num2)),
					(uint)(uint_0[1] - num * Math.Sin(num2))
				};
				uint[] array = Class60.smethod_5(uint_0, uint_2, 150);
				int num3 = new Random().Next(100, 200);
				uint_1[0] += (uint)num3;
				uint_1[1] += (uint)num3;
				array = Class60.smethod_5(uint_1, array, int_1);
				uint num4 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num6 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num7 = num6 + num5 * Class53.gstruct51_15.uint_0;
				int num8 = 0;
				int int_2 = gstruct49_0.int_137;
				uint uint_3 = num7 + Class53.gstruct51_72.uint_0;
				byte[] byte_ = new byte[4];
				Class22.WriteProcessMemory(int_2, uint_3, byte_, 4, ref num8);
				Class14.smethod_1(gstruct49_0, array);
				int num9 = 0;
				int num10 = 0;
				while (num9 < 3 && num10 < 50)
				{
					int num11 = Class83.smethod_39(gstruct49_0);
					int num12 = (int)Class22.smethod_30(num7 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
					bool flag2 = num12 == 1 || num11 <= 1;
					if (flag2)
					{
						num9++;
					}
					Thread.Sleep(100);
					num10++;
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0009E124 File Offset: 0x0009C324
		public static void smethod_3(GStruct49 gstruct49_0, ref bool bool_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_73.uint_0, array, 4, ref num);
			uint num4 = BitConverter.ToUInt32(array, 0);
			bool flag = (ulong)num4 < (ulong)((long)gstruct49_0.int_66);
			if (flag)
			{
				bool flag2 = !bool_0 && gstruct49_0.string_15 != null && gstruct49_0.string_15 != string.Empty;
				if (flag2)
				{
					uint num5 = Class12.smethod_12(gstruct49_0.string_15);
					bool flag3 = num5 > 0U;
					if (flag3)
					{
						Class70.smethod_117(gstruct49_0, num5);
						bool_0 = true;
						Thread.Sleep(300);
					}
				}
				uint num6 = (uint)(gstruct49_0.int_66 - (int)num4);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_74.uint_0, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				bool flag4 = num7 > 0U;
				if (flag4)
				{
					bool flag5 = num6 > num7;
					if (flag5)
					{
						num6 = num7;
					}
					Class70.smethod_37(gstruct49_0, num6);
				}
			}
			else
			{
				bool flag6 = (long)gstruct49_0.int_66 < (long)((ulong)num4);
				if (flag6)
				{
					Class70.smethod_38(gstruct49_0, num4 - (uint)gstruct49_0.int_66);
				}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0009E288 File Offset: 0x0009C488
		public static void smethod_4(GStruct49 gstruct49_0, uint uint_0, int int_1 = 180)
		{
			int i = 0;
			int num = 0;
			while (i < int_1)
			{
				i++;
				Thread.Sleep(1);
				uint num2 = Class22.smethod_30(uint_0 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				bool flag = num2 == 3U;
				if (flag)
				{
					num = 1;
				}
				else
				{
					bool flag2 = num > 0 || i > 50;
					if (flag2)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0009E2EC File Offset: 0x0009C4EC
		public static uint[] smethod_5(uint[] uint_0, uint[] uint_1, int int_1 = 350)
		{
			bool flag = uint_0 == null || uint_1 == null;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				long num = (long)((ulong)uint_0[0]);
				long num2 = (long)((ulong)uint_0[1]);
				long num3 = (long)((ulong)uint_1[0]);
				long num4 = (long)((ulong)uint_1[1]);
				bool flag2 = num3 == num;
				if (flag2)
				{
					bool flag3 = num3 == 0L;
					if (flag3)
					{
						return null;
					}
					num3 += 1L;
				}
				long num5 = num3 - num;
				long num6 = num4 - num2;
				short num7 = (short)((num3 - num) / Math.Abs(num3 - num));
				bool flag4 = 0 > int_1;
				double num8;
				double num9;
				if (flag4)
				{
					num8 = (double)num7 * Math.Sqrt((double)((long)(int_1 * int_1) / (1L + num6 / num5 * (num6 / num5)))) + (double)num;
					num9 = (double)num2 + (double)(num6 / num5) * (num8 - (double)num);
				}
				else
				{
					num8 = (double)num7 * Math.Sqrt((double)((long)(int_1 * int_1) / (1L + num6 / num5 * (num6 / num5)))) + (double)num3;
					num9 = (double)num4 + (double)(num6 / num5) * (num8 - (double)num3);
				}
				result = new uint[]
				{
					(uint)num8,
					(uint)num9
				};
			}
			return result;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0009E408 File Offset: 0x0009C608
		public static uint[] smethod_6(uint[] uint_0, uint[] uint_1, int int_1)
		{
			long num = (long)((ulong)Class36.smethod_0(uint_0, uint_1));
			bool flag = int_1 <= 0 || num <= (long)(int_1 * int_1);
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num2 = (int)(Math.Sqrt((double)num) - (double)int_1);
				result = Class60.smethod_5(uint_0, uint_1, -num2);
			}
			return result;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0009E454 File Offset: 0x0009C654
		public static int smethod_7(int int_1, int int_2, ref GStruct26 gstruct26_0)
		{
			int[] array = null;
			int[] array2 = null;
			int i;
			for (;;)
			{
				Class12.smethod_37(ref array2, int_2);
				for (i = 0; i < Class43.gstruct26_0.Length; i++)
				{
					bool flag = Class43.gstruct26_0[i].int_1 != int_2;
					if (!flag)
					{
						bool flag2 = Class43.gstruct26_0[i].int_0 != int_1;
						if (!flag2)
						{
							goto IL_103;
						}
						bool flag3 = Class60.smethod_9(Class43.gstruct26_0[i].int_0) == null;
						if (!flag3)
						{
							goto IL_EF;
						}
						bool flag4 = false;
						bool flag5 = array2 != null;
						if (flag5)
						{
							for (int j = 0; j < array2.Length; j++)
							{
								bool flag6 = array2[j] == Class43.gstruct26_0[i].int_0;
								if (flag6)
								{
									flag4 = true;
									break;
								}
							}
						}
						bool flag7 = !flag4;
						if (flag7)
						{
							Class12.smethod_37(ref array, Class43.gstruct26_0[i].int_0);
						}
					}
				}
				bool flag8 = array == null || array.Length == 0;
				if (flag8)
				{
					goto Block_9;
				}
				int_2 = array[0];
				Class12.smethod_38(ref array, int_2);
			}
			IL_EF:
			return Class43.gstruct26_0[i].int_0;
			IL_103:
			gstruct26_0 = Class43.smethod_4(int_1, int_2);
			return 0;
			Block_9:
			return -1;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0009E5C0 File Offset: 0x0009C7C0
		public static void smethod_8(uint[,] uint_0, int int_1, ref uint[] uint_1, ref uint[] uint_2, ref int int_2)
		{
			uint_1 = null;
			uint_2 = null;
			int_2 = -1;
			bool flag = uint_0 != null && int_1 < uint_0.GetLength(0) && uint_0.GetLength(1) > 2;
			if (flag)
			{
				uint_1 = new uint[]
				{
					uint_0[int_1, 0],
					uint_0[int_1, 1]
				};
				int_2 = (int)uint_0[int_1, 2];
				bool flag2 = uint_0.GetLength(1) > 4;
				if (flag2)
				{
					uint_2 = new uint[]
					{
						uint_0[int_1, 3],
						uint_0[int_1, 4]
					};
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0009E650 File Offset: 0x0009C850
		public static int[] smethod_9(object object_0)
		{
			bool flag = object_0 == null;
			int[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				string text = object_0.ToString();
				bool flag2 = text == string.Empty;
				if (flag2)
				{
					result = null;
				}
				else
				{
					string[] array = typeof(string).ToString().Split(new char[]
					{
						'.'
					});
					string object_ = array[array.Length - 1].ToUpper();
					bool flag3 = Class12.smethod_1(object_0.GetType().ToString().ToUpper(), object_) >= 0;
					if (flag3)
					{
						int length = Class60.string_0.GetLength(0);
						int length2 = Class60.string_0.GetLength(1);
						for (int i = 0; i < length; i++)
						{
							for (int j = 0; j < length2; j++)
							{
								string text2 = Class60.string_0[i, j];
								bool flag4 = text2 != null && !(text2 == string.Empty);
								if (flag4)
								{
									bool flag5 = Class12.smethod_1(text2, text) == 0 || Class12.smethod_1(text, text2) == 0;
									if (flag5)
									{
										return new int[]
										{
											i,
											j
										};
									}
									string text3 = Class10.smethod_1(text, 1, false);
									string text4 = Class10.smethod_1(text2, 1, false);
									bool flag6 = Class12.smethod_1(text3, text4) == 0 || Class12.smethod_1(text4, text3) == 0;
									if (flag6)
									{
										return new int[]
										{
											i,
											j
										};
									}
								}
							}
						}
						result = null;
					}
					else
					{
						int num = Class12.smethod_11(text);
						bool flag7 = num > 0;
						if (flag7)
						{
							for (int k = 0; k < Class60.int_0.GetLength(0); k++)
							{
								for (int l = 0; l < Class60.int_0.GetLength(1); l++)
								{
									bool flag8 = num == Class60.int_0[k, l];
									if (flag8)
									{
										return new int[]
										{
											k,
											l
										};
									}
								}
							}
						}
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0009E880 File Offset: 0x0009CA80
		public static int smethod_10(GStruct49 gstruct49_0, string string_1)
		{
			bool flag = Class70.smethod_1(gstruct49_0, Class70.uint_29) >= 15;
			int result;
			if (flag)
			{
				Class70.smethod_0(gstruct49_0, Class70.uint_29);
				Class70.smethod_52(gstruct49_0, string_1, 1);
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0009E8C4 File Offset: 0x0009CAC4
		public static int smethod_11(GStruct49 gstruct49_0, int int_1 = 15000)
		{
			long long_ = Class12.smethod_27();
			while (!Class12.bool_0 && Class12.smethod_28(long_) < (long)int_1)
			{
				Thread.Sleep(60 + Class86.int_0);
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num3 = num2 * Class53.gstruct51_15.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3;
				uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
				uint num7 = Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
				uint num8 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				int num9 = Class83.smethod_39(gstruct49_0);
				bool flag = num6 == 0U || num9 <= 1 || num8 == 0U || num7 == 0U;
				if (!flag)
				{
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		public static int smethod_12(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = Class70.smethod_1(gstruct49_0, Class70.uint_27) >= 5 && Class70.smethod_7(gstruct49_0);
			int result;
			if (flag)
			{
				Class70.smethod_0(gstruct49_0, Class70.uint_27);
				bool flag2 = Class45.smethod_8(gstruct49_0);
				if (flag2)
				{
					Class45.smethod_11(gstruct49_0);
				}
				Class86.smethod_8(gstruct49_0, -1);
				uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num4 = num3 + num2;
				int num5 = 0;
				byte[] array = new byte[4];
				byte[] byte_ = array;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_72.uint_0, byte_, 4, ref num5);
				int num6 = (int)Class22.smethod_30(num4 + Class53.gstruct51_44.uint_0, gstruct49_0.int_137);
				bool flag3 = bool_0 && num6 > 0;
				if (flag3)
				{
					Class70.smethod_57(gstruct49_0, "Switch([[horse]])");
					Thread.Sleep(600);
				}
				bool flag4 = num6 == 0;
				if (flag4)
				{
					Class70.smethod_57(gstruct49_0, "Switch([[sit]])");
					Thread.Sleep(600);
				}
				uint[] array2 = new uint[]
				{
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag5 = Class70.smethod_3(gstruct49_0, Class70.uint_28, 4) <= 0;
				if (flag5)
				{
					array2[0] += 100U;
					array2[1] += 100U;
					Class70.smethod_2(gstruct49_0, Class70.uint_28, 1, 4);
				}
				else
				{
					array2[0] -= 100U;
					array2[1] -= 100U;
					Class70.smethod_2(gstruct49_0, Class70.uint_28, 0, 4);
				}
				Class70.smethod_61(gstruct49_0, array2);
				Thread.Sleep(500);
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				long num7 = Class60.smethod_18(array2, array3);
				bool flag6 = (array2[0] == array3[0] && array2[1] == array3[1]) || num7 < 11500L;
				if (flag6)
				{
					Class60.smethod_13(gstruct49_0);
				}
				result = (int)(1U + Class22.smethod_30(num4 + Class53.gstruct51_44.uint_0, gstruct49_0.int_137));
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0009ECAC File Offset: 0x0009CEAC
		public static void smethod_13(GStruct49 gstruct49_0)
		{
			bool flag = Class70.smethod_3(gstruct49_0, Class70.uint_28, 4) > 0;
			uint uint_;
			if (flag)
			{
				uint_ = 13107500U;
				Class70.smethod_2(gstruct49_0, Class70.uint_28, 0, 4);
			}
			else
			{
				uint_ = 24904160U;
				Class70.smethod_2(gstruct49_0, Class70.uint_28, 1, 4);
			}
			Class83.smethod_15(gstruct49_0.uint_4, uint_);
			Thread.Sleep(800);
			uint_ = 19661200U;
			Class83.smethod_15(gstruct49_0.uint_4, uint_);
			Thread.Sleep(300);
			Class83.smethod_14(gstruct49_0);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0009ED3C File Offset: 0x0009CF3C
		public static bool smethod_14(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			uint num4 = num3 * Class53.gstruct51_15.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			uint num6 = num5 + num4;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
			bool flag = BitConverter.ToUInt32(array, 0) == 0U;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
				int num7 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
				int num8 = BitConverter.ToInt32(array, 0);
				uint[] array2 = Class79.smethod_39(gstruct49_0);
				bool flag2 = array2 == null || !Class70.smethod_43(gstruct49_0, array2[0], (int)array2[2], (int)array2[3], 3);
				if (flag2)
				{
					result = false;
				}
				else
				{
					int num9 = 0;
					while (!bool_0 && num9 < 30)
					{
						num9++;
						Thread.Sleep(60);
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
						num2 = BitConverter.ToUInt32(array, 0);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
						num3 = BitConverter.ToUInt32(array, 0);
						num4 = num3 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
						num5 = BitConverter.ToUInt32(array, 0);
						num6 = num5 + num4;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
						bool flag3 = BitConverter.ToUInt32(array, 0) > 0U;
						if (flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
							int num10 = BitConverter.ToInt32(array, 0);
							bool flag4 = num10 > 0 && num10 != num8;
							if (flag4)
							{
								break;
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
							int num11 = BitConverter.ToInt32(array, 0);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
							int num12 = BitConverter.ToInt32(array, 0);
							bool flag5 = num11 <= 0 && num12 > 0 && num12 != num7;
							if (flag5)
							{
								break;
							}
						}
					}
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0009F028 File Offset: 0x0009D228
		public static void smethod_15(GStruct49 gstruct49_0, string[] string_1)
		{
			bool flag = string_1 == null;
			if (!flag)
			{
				string[] array = Class10.smethod_5(ref string_1, true);
				int num = 80;
				int num2 = 0;
				byte[] array2 = new byte[1];
				byte[] array3 = new byte[4];
				byte[] byte_ = new byte[num];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array3, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array3, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array3, 0);
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 1U;
				while ((ulong)num7 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num5 <= num6;
					if (flag2)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array3, 4, ref num2);
					uint num8 = BitConverter.ToUInt32(array3, 0);
					bool flag3 = num8 == 0U;
					if (!flag3)
					{
						uint num9 = num4 + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array3, 4, ref num2);
						bool flag4 = BitConverter.ToInt32(array3, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array2, 1, ref num2);
							bool flag5 = array2[0] == 0;
							if (!flag5)
							{
								num6++;
								uint num10 = num3 + num7 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num2);
								bool flag6 = array2[0] != 3;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, byte_, num, ref num2);
									string a = Class10.smethod_3(byte_).Trim();
									int num11 = -1;
									for (int i = 0; i < string_1.Length; i++)
									{
										bool flag7 = a == string_1[i] || Class10.smethod_1(a, 1, false).ToUpper() == array[i];
										if (flag7)
										{
											num11 = i;
											break;
										}
									}
									bool flag8 = num11 >= 0;
									if (flag8)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num2);
										int num12 = (int)array2[0];
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0, array2, 1, ref num2);
										int int_ = (int)array2[0];
										Class70.smethod_43(gstruct49_0, num8, num12, int_, 3);
										Thread.Sleep(30);
									}
								}
							}
						}
					}
					num7 += 1U;
				}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0009F2E4 File Offset: 0x0009D4E4
		public static bool smethod_16(GStruct49 gstruct49_0, string[] string_1)
		{
			bool flag = string_1 == null || string_1.Length == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				int num = 1;
				string[] array = new string[string_1.Length];
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2 = string_1[i] == null;
					if (flag2)
					{
						string_1[i] = string.Empty;
					}
					bool flag3 = num < string_1[i].Length;
					if (flag3)
					{
						num = string_1[i].Length;
					}
					array[i] = string_1[i].ToLower();
				}
				num += 3;
				int num2 = 0;
				int num3 = string_1.Length;
				byte[] byte_ = new byte[num];
				byte[] array2 = new byte[num3];
				byte[] array3 = new byte[1];
				byte[] array4 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array4, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array4, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array4, 4, ref num2);
				uint num5 = BitConverter.ToUInt32(array4, 0);
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = 1U;
				while ((ulong)num8 < (ulong)((long)Class53.int_1))
				{
					bool flag4 = num6 <= num7;
					if (flag4)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array4, 4, ref num2);
					uint num9 = BitConverter.ToUInt32(array4, 0);
					bool flag5 = num9 == 0U;
					if (!flag5)
					{
						uint num10 = num5 + num9 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array4, 4, ref num2);
						bool flag6 = BitConverter.ToInt32(array4, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array3, 1, ref num2);
							bool flag7 = array3[0] == 0;
							if (!flag7)
							{
								num7++;
								uint num11 = num4 + num8 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array3, 1, ref num2);
								bool flag8 = array3[0] != 3;
								if (!flag8)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, byte_, num, ref num2);
									string text = Class10.smethod_3(byte_);
									string a = text.ToLower();
									int num12 = -1;
									for (int j = 0; j < string_1.Length; j++)
									{
										bool flag9 = array2[j] <= 0 && (text == string_1[j] || a == array[j]);
										if (flag9)
										{
											num12 = j;
											break;
										}
									}
									bool flag10 = num12 < 0;
									if (!flag10)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 4U, array3, 1, ref num2);
										int num13 = (int)array3[0];
										Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0, array3, 1, ref num2);
										int int_ = (int)array3[0];
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array4, 4, ref num2);
										int num14 = BitConverter.ToInt32(array4, 0);
										Class70.smethod_43(gstruct49_0, num9, num13, int_, 3);
										Thread.Sleep(100);
										for (int k = 0; k < 30; k++)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array4, 4, ref num2);
											bool flag11 = BitConverter.ToInt32(array4, 0) != 0;
											if (flag11)
											{
												break;
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array4, 4, ref num2);
											bool flag12 = BitConverter.ToUInt32(array4, 0) == 0U;
											if (flag12)
											{
												break;
											}
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array4, 4, ref num2);
											int num15 = BitConverter.ToInt32(array4, 0);
											bool flag13 = num14 > 0 && num15 != num14;
											if (flag13)
											{
												break;
											}
											Thread.Sleep(10);
										}
										array2[num12] = 1;
										num3--;
									}
								}
							}
						}
					}
					num8 += 1U;
				}
				result = (num3 != string_1.Length);
			}
			return result;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0009F734 File Offset: 0x0009D934
		public static bool smethod_17(GStruct49 gstruct49_0, string string_1, bool bool_0 = true)
		{
			bool flag = string_1 == null || string_1 == string.Empty;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
				int num3 = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				string[] array3 = string_1.Split(new char[]
				{
					'|'
				});
				string[] array4 = new string[array3.Length];
				int num4 = 1;
				for (int i = 0; i < array3.Length; i++)
				{
					bool flag2 = array3[i] == null;
					if (flag2)
					{
						array3[i] = string.Empty;
					}
					bool flag3 = array3[i].Length > num4;
					if (flag3)
					{
						num4 = array3[i].Length;
					}
					array4[i] = array3[i].Trim().ToLower();
				}
				num4 += 3;
				byte[] byte_ = new byte[num4];
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				uint num7 = 1U;
				while ((ulong)num7 < (ulong)((long)Class53.int_1))
				{
					bool flag4 = num5 <= num6;
					if (flag4)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num7 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num3);
					uint num8 = BitConverter.ToUInt32(array2, 0);
					bool flag5 = num8 == 0U;
					if (!flag5)
					{
						uint num9 = num + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num3);
						bool flag6 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num3);
							bool flag7 = array[0] == 0;
							if (!flag7)
							{
								num6++;
								uint num10 = num2 + num7 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num3);
								int num11 = (int)array[0];
								bool flag8 = num11 != 3;
								if (!flag8)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array, 1, ref num3);
									int num12 = (int)array[0];
									bool flag9 = num12 != 1;
									if (!flag9)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array, 1, ref num3);
										int num13 = (int)array[0];
										bool flag10 = num13 != 1;
										if (!flag10)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num3);
											int num14 = (int)array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0, array, 1, ref num3);
											int int_ = (int)array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, byte_, num4, ref num3);
											string text = Class10.smethod_3(byte_);
											string text2 = null;
											bool flag11 = false;
											for (int j = 0; j < array3.Length; j++)
											{
												bool flag12 = !(text == array3[j]);
												if (!flag12)
												{
													flag11 = true;
													break;
												}
												bool flag13 = !bool_0;
												if (flag13)
												{
													bool flag14 = text2 == null;
													if (flag14)
													{
														text2 = text.ToLower();
													}
													bool flag15 = 0 <= text2.IndexOf(array4[j]);
													if (flag15)
													{
														flag11 = true;
														break;
													}
												}
											}
											bool flag16 = !flag11;
											if (!flag16)
											{
												int k = 0;
												while (k < 100)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_45 - 4U, array, 1, ref num3);
													bool flag17 = array[0] == 0;
													if (flag17)
													{
														break;
													}
													k++;
													Thread.Sleep(1);
												}
												return Class70.smethod_43(gstruct49_0, num8, num14, int_, num11);
											}
										}
									}
								}
							}
						}
					}
					num7 += 1U;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0009FB3C File Offset: 0x0009DD3C
		public static long smethod_18(uint[] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 == null || uint_1 == null || uint_0[0] == 0U || uint_0[1] == 0U || uint_1[0] == 0U || uint_1[1] == 0U;
			long result;
			if (flag)
			{
				result = 2147483647L;
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
				result = (long)((ulong)((uint)num3));
			}
			return result;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0009FBA8 File Offset: 0x0009DDA8
		public static long smethod_19(uint[] uint_0, uint uint_1, uint uint_2)
		{
			bool flag = uint_0 != null && uint_0[0] != 0U && uint_0[1] != 0U && uint_1 != 0U && uint_2 > 0U;
			long result;
			if (flag)
			{
				long num = (long)(uint_0[0] - uint_1);
				long num2 = (long)(uint_0[1] - uint_2);
				long num3 = num * num + num2 * num2;
				bool flag2 = num3 == 0L;
				if (flag2)
				{
					num3 = 1L;
				}
				result = (long)((ulong)((uint)num3));
			}
			else
			{
				result = 2147483647L;
			}
			return result;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0009FC0C File Offset: 0x0009DE0C
		public static int smethod_20(uint[,] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 != null && uint_1 != null && uint_0.GetLength(1) >= 2 && uint_1.GetLength(0) >= 2;
			int result;
			if (flag)
			{
				int num = -1;
				long num2 = -1L;
				for (int i = 0; i < uint_0.GetLength(0); i++)
				{
					uint[] uint_2 = new uint[]
					{
						uint_0[i, 0],
						uint_0[i, 1]
					};
					long num3 = Class60.smethod_18(uint_1, uint_2);
					bool flag2 = num < 0 || num3 < num2;
					if (flag2)
					{
						num = i;
						num2 = num3;
					}
				}
				result = num;
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0009FCAC File Offset: 0x0009DEAC
		public static long smethod_21(uint[,] uint_0, uint[] uint_1)
		{
			bool flag = uint_0 != null && uint_1 != null;
			long result;
			if (flag)
			{
				long num = -1L;
				long num2 = -1L;
				for (int i = 0; i < uint_0.GetLength(0); i++)
				{
					uint[] uint_2 = new uint[]
					{
						uint_0[i, 0],
						uint_0[i, 1]
					};
					long num3 = Class60.smethod_18(uint_1, uint_2);
					bool flag2 = num < 0L || num3 < num2;
					if (flag2)
					{
						num = (long)i;
						num2 = num3;
					}
				}
				result = num2;
			}
			else
			{
				result = -1L;
			}
			return result;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0009FD3C File Offset: 0x0009DF3C
		public static int smethod_22(GStruct49 gstruct49_0, uint[,] uint_0, uint[] uint_1 = null, uint[] uint_2 = null, int int_1 = -1, bool bool_0 = false, int int_2 = 0, bool bool_1 = false)
		{
			int int_3 = gstruct49_0.int_136;
			int result = 0;
			int num = 0;
			int num2 = 0;
			int num3 = 1;
			bool flag = false;
			bool flag2 = false;
			long long_ = 0L;
			long long_2 = 0L;
			long num4 = Class12.smethod_27();
			long long_3 = num4;
			uint[] array = null;
			bool flag3 = false;
			int num5 = -1;
			int num6 = 0;
			int num7 = 0;
			int num8 = -1;
			int num9 = 0;
			int num10 = 0;
			int num11 = -1;
			int num12 = 0;
			byte[] array2 = new byte[4];
			byte[] byte_ = array2;
			bool flag4 = false;
			int[] array3 = new int[10];
			for (int i = 0; i < array3.Length; i++)
			{
				array3[i] = 4;
			}
			byte[] array4 = new byte[4];
			for (;;)
			{
				uint num20;
				int num23;
				for (;;)
				{
					IL_99:
					Thread.Sleep(100);
					int num13 = Class81.smethod_3(Form1.gstruct49_0, int_3);
					bool flag5 = Class12.bool_0 || num13 < 0 || Class22.smethod_52(Form1.gstruct49_0[num13].process_0) || !Form1.gstruct49_0[num13].bool_25 || Class44.bool_0;
					if (flag5)
					{
						goto Block_6;
					}
					gstruct49_0 = Form1.gstruct49_0[num13];
					int num14 = Class83.smethod_12(gstruct49_0);
					bool flag6 = num14 != 1;
					if (!flag6)
					{
						goto IL_A8E;
					}
					num10 = 0;
					int num15 = Class83.smethod_39(gstruct49_0);
					bool flag7 = num15 > 1;
					if (!flag7)
					{
						goto IL_A72;
					}
					num9 = 0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array4, 4, ref array3[0]);
					uint num16 = BitConverter.ToUInt32(array4, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_13.uint_0, array4, 4, ref array3[1]);
					uint num17 = BitConverter.ToUInt32(array4, 0);
					uint num18 = num17 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array4, 4, ref array3[2]);
					uint num19 = BitConverter.ToUInt32(array4, 0);
					num20 = num19 + num18;
					bool flag8 = !flag4;
					if (flag8)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_72.uint_0, byte_, 4, ref num12);
						flag4 = true;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_55.uint_0, array4, 4, ref array3[3]);
					int num21 = BitConverter.ToInt32(array4, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num20 + Class53.gstruct51_50.uint_0, array4, 4, ref array3[4]);
					int num22 = BitConverter.ToInt32(array4, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array4, 4, ref array3[5]);
					num23 = BitConverter.ToInt32(array4, 0);
					bool flag9 = int_1 > 0 && num23 != int_1;
					if (flag9)
					{
						goto Block_11;
					}
					bool flag10 = num22 == 0 || num21 == 0 || num21 == 10 || num21 == 21 || num23 == 0 || gstruct49_0.long_9 > num4;
					if (flag10)
					{
						goto Block_17;
					}
					int num24 = (int)Class22.smethod_30(num20 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
					bool flag11 = bool_0 && num24 > 0;
					if (flag11)
					{
						goto Block_19;
					}
					bool flag12 = num11 != num24;
					if (flag12)
					{
						bool flag13 = 0 <= num11;
						if (flag13)
						{
							flag = false;
							uint_1 = null;
						}
						num11 = num24;
					}
					bool flag14 = int_2 > 0 && Class12.smethod_28(long_3) > (long)int_2;
					if (flag14)
					{
						goto Block_23;
					}
					int num25 = 5;
					for (int j = 0; j <= num25; j++)
					{
						bool flag15 = array3[j] != 0;
						if (!flag15)
						{
							goto IL_99;
						}
					}
					break;
				}
				uint[] array5 = new uint[]
				{
					Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				bool flag16 = num8 >= 0;
				if (flag16)
				{
					bool flag17 = num8 != num23;
					if (flag17)
					{
						goto Block_27;
					}
				}
				else
				{
					num8 = num23;
				}
				bool flag18 = Class70.smethod_3(gstruct49_0, Class70.uint_17, 4) > 0;
				if (flag18)
				{
					goto Block_28;
				}
				bool flag19 = uint_0.GetLength(0) == 1;
				if (flag19)
				{
					uint[] array6 = new uint[]
					{
						uint_0[0, 0],
						uint_0[0, 1]
					};
					long num26 = Class60.smethod_18(array5, array6);
					bool flag20 = num26 >= 22500L;
					if (!flag20)
					{
						goto IL_4F0;
					}
					bool flag21 = bool_1 || num26 <= 1000000L;
					if (flag21)
					{
						Class70.smethod_61(gstruct49_0, array6);
						Thread.Sleep(200);
					}
					else
					{
						bool flag22 = Class12.smethod_28(long_2) > 3000L;
						if (flag22)
						{
							Class14.smethod_1(gstruct49_0, array6);
							long_2 = Class12.smethod_27();
						}
					}
				}
				else
				{
					bool flag23 = !flag;
					if (flag23)
					{
						flag = true;
						bool flag24 = uint_1 != null;
						if (flag24)
						{
							num = Class60.smethod_20(uint_0, uint_1);
							num5 = num;
							flag3 = true;
						}
						else
						{
							num = Class60.smethod_20(uint_0, array5);
							num5 = num;
							uint_1 = new uint[]
							{
								uint_0[num, 0],
								uint_0[num, 1]
							};
						}
						bool flag25 = uint_2 == null;
						if (flag25)
						{
							num2 = uint_0.GetLength(0) - 1;
							uint_2 = new uint[]
							{
								uint_0[num2, 0],
								uint_0[num2, 1]
							};
						}
						else
						{
							num2 = Class60.smethod_20(uint_0, uint_2);
						}
						num3 = ((num <= num2) ? 1 : -1);
					}
					bool flag26 = !flag2;
					if (flag26)
					{
						int k = 0;
						long num27 = Class60.smethod_18(array5, uint_1);
						bool flag27 = bool_1 || num27 <= 1000000L;
						if (flag27)
						{
							bool flag28 = Class14.smethod_3(gstruct49_0);
							if (flag28)
							{
								Class14.smethod_2(gstruct49_0, false);
							}
							while (k < 5)
							{
								array5 = new uint[]
								{
									Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
									Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
								};
								num27 = Class60.smethod_18(array5, uint_1);
								bool flag29 = num27 <= 22500L;
								if (flag29)
								{
									break;
								}
								Class70.smethod_61(gstruct49_0, uint_1);
								Thread.Sleep(300);
								k++;
							}
							num23 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag30 = int_1 > 0 && num23 != int_1;
							if (flag30)
							{
								goto Block_44;
							}
							bool flag31 = !bool_1 && k > 4 && num27 > 22500L;
							if (flag31)
							{
								Class14.smethod_1(gstruct49_0, uint_1);
								Thread.Sleep(300);
							}
							flag2 = true;
						}
						else
						{
							bool flag32 = Class12.smethod_28(long_2) > 3000L;
							if (flag32)
							{
								Class14.smethod_1(gstruct49_0, uint_1);
								long_2 = Class12.smethod_27();
							}
						}
					}
					else
					{
						uint_1 = new uint[]
						{
							uint_0[num, 0],
							uint_0[num, 1]
						};
						long num27 = Class60.smethod_18(array5, uint_1);
						bool flag33 = !flag3;
						if (flag33)
						{
							bool flag34 = num27 <= 22500L;
							if (flag34)
							{
								Class60.smethod_29(gstruct49_0, false);
								num = Class60.smethod_20(uint_0, uint_1);
								bool flag35 = (num >= num5 || num3 <= 0) && (num <= num5 || num3 >= 0);
								if (flag35)
								{
									num += num3;
									num5 = num;
									num6 = 0;
									num7 = 0;
									bool flag36 = (num3 <= 0 || num2 >= num) && (num3 >= 0 || num >= num2);
									if (!flag36)
									{
										goto IL_7D7;
									}
								}
								else
								{
									num6++;
									bool flag37 = num6 % 6 == 0;
									if (flag37)
									{
										Class60.smethod_12(gstruct49_0, true);
										num7++;
										bool flag38 = num7 > 3;
										if (flag38)
										{
											goto Block_58;
										}
									}
									bool flag39 = num3 <= 0;
									if (flag39)
									{
										num++;
										bool flag40 = num2 < num;
										if (flag40)
										{
											num = num2;
										}
									}
									else
									{
										num--;
										bool flag41 = num < 0;
										if (flag41)
										{
											num = 0;
										}
									}
									num5 = num;
								}
							}
							else
							{
								bool flag42 = Class14.smethod_3(gstruct49_0);
								if (flag42)
								{
									Class14.smethod_2(gstruct49_0, false);
								}
								bool flag43 = array == null;
								if (flag43)
								{
									array = new uint[]
									{
										Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									long_ = Class12.smethod_27();
								}
								Class70.smethod_61(gstruct49_0, uint_1);
								Thread.Sleep(200);
								bool flag44 = Class12.smethod_28(long_) < 6000L;
								if (!flag44)
								{
									array5 = new uint[]
									{
										Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
										Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
									};
									num27 = Class60.smethod_18(array, array5);
									bool flag45 = num27 >= 90000L;
									if (flag45)
									{
										array = new uint[]
										{
											array5[0],
											array5[1]
										};
									}
									else
									{
										num6++;
										bool flag46 = num6 % 6 == 0;
										if (flag46)
										{
											Class60.smethod_12(gstruct49_0, true);
											num7++;
											bool flag47 = num7 > 3;
											if (flag47)
											{
												goto Block_67;
											}
										}
										Thread.Sleep(300);
										array5 = new uint[]
										{
											Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
											Class22.smethod_30(num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
										};
										num = Class60.smethod_20(uint_0, array5);
										bool flag48 = num3 <= 0;
										if (flag48)
										{
											num++;
											bool flag49 = num2 < num;
											if (flag49)
											{
												num = num2;
											}
										}
										else
										{
											num--;
											bool flag50 = num < 0;
											if (flag50)
											{
												num = 0;
											}
										}
										num5 = num;
									}
									long_ = Class12.smethod_27();
								}
							}
						}
						else
						{
							flag3 = false;
							flag2 = false;
						}
					}
				}
				continue;
				IL_A8E:
				Thread.Sleep(200);
				num10++;
				bool flag51 = num10 > 1;
				if (flag51)
				{
					flag = false;
					flag2 = false;
					uint_1 = null;
				}
				continue;
				IL_A72:
				num9++;
				bool flag52 = num9 > 10;
				if (flag52)
				{
					goto Block_71;
				}
			}
			Block_6:
			goto IL_AC0;
			Block_11:
			result = -1;
			goto IL_AC0;
			Block_17:
			result = -1;
			goto IL_AC0;
			Block_19:
			result = 1;
			goto IL_AC0;
			Block_23:
			result = 101;
			goto IL_AC0;
			Block_27:
			result = 1;
			goto IL_AC0;
			Block_28:
			Class70.smethod_2(gstruct49_0, Class70.uint_17, 0, 4);
			result = 0;
			goto IL_AC0;
			IL_4F0:
			result = 1;
			goto IL_AC0;
			Block_44:
			result = 1;
			goto IL_AC0;
			IL_7D7:
			result = 1;
			goto IL_AC0;
			Block_58:
			result = -1;
			goto IL_AC0;
			Block_67:
			result = -1;
			goto IL_AC0;
			Block_71:
			result = -1;
			IL_AC0:
			Class14.smethod_2(gstruct49_0, false);
			return result;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000A0818 File Offset: 0x0009EA18
		public static int smethod_23(GStruct49 gstruct49_0, uint[] uint_0, int int_1, uint[] uint_1 = null, int int_2 = -1)
		{
			int int_3 = gstruct49_0.int_136;
			int num = Class81.smethod_3(Form1.gstruct49_0, int_3);
			bool flag = !Class12.bool_0 && num >= 0 && !Class22.smethod_52(Form1.gstruct49_0[num].process_0) && Form1.gstruct49_0[num].bool_25;
			int result;
			if (flag)
			{
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3;
				int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				bool flag2 = num6 == int_2;
				if (flag2)
				{
					result = 1;
				}
				else
				{
					uint[] array = new uint[]
					{
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag3 = uint_1 != null;
					int i;
					if (flag3)
					{
						for (i = 0; i < 10; i++)
						{
							uint num7 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag4 = (ulong)num7 == (ulong)((long)num6) && (ulong)num7 != (ulong)((long)int_2);
							if (!flag4)
							{
								return 1;
							}
							uint[] uint_2 = new uint[]
							{
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							bool flag5 = Class60.smethod_18(uint_2, uint_1) < 11500L;
							if (flag5)
							{
								break;
							}
							Class70.smethod_61(gstruct49_0, uint_1);
							Thread.Sleep(300);
						}
						for (i = 0; i < 10; i++)
						{
							bool flag6 = Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137) != 3U;
							if (flag6)
							{
								break;
							}
							Thread.Sleep(100);
						}
					}
					i = 0;
					while (!Class12.bool_0 && i < 15)
					{
						uint num8 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
						bool flag7 = (num8 == 0U || (ulong)num8 == (ulong)((long)num6)) && (ulong)num8 != (ulong)((long)int_2);
						if (!flag7)
						{
							return 1;
						}
						uint[] uint_2 = new uint[]
						{
							Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
							Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
						};
						bool flag8 = Class60.smethod_18(uint_2, uint_0) < 11500L;
						if (flag8)
						{
							break;
						}
						Class70.smethod_61(gstruct49_0, uint_0);
						Thread.Sleep(300);
						i++;
					}
					for (i = 0; i < 10; i++)
					{
						bool flag9 = Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137) != 3U;
						if (flag9)
						{
							break;
						}
						Thread.Sleep(100);
					}
					for (int j = 0; j < 5; j++)
					{
						uint num9 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
						bool flag10 = (num9 == 0U || (ulong)num9 == (ulong)((long)num6)) && (ulong)num9 != (ulong)((long)int_2);
						if (!flag10)
						{
							return 1;
						}
						bool flag11 = Class70.smethod_7(gstruct49_0);
						if (flag11)
						{
							Class60.smethod_25(gstruct49_0, int_1);
						}
						Thread.Sleep(300);
					}
					result = 0;
				}
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000A0C38 File Offset: 0x0009EE38
		public static int smethod_24(GStruct49 gstruct49_0, uint[] uint_0, int int_1, uint[] uint_1 = null, uint[,] uint_2 = null, int int_2 = -10)
		{
			int int_3 = gstruct49_0.int_136;
			int num = Class81.smethod_3(Form1.gstruct49_0, int_3);
			bool flag = Class12.bool_0 || num < 0 || Class22.smethod_52(Form1.gstruct49_0[num].process_0) || !Form1.gstruct49_0[num].bool_25;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137) * Class53.gstruct51_15.uint_0;
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5 = num4 + num3;
				int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
				bool flag2 = num6 == int_2;
				if (flag2)
				{
					result = 1;
				}
				else
				{
					uint[] array = new uint[]
					{
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
						Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
					};
					bool flag3 = uint_2 != null;
					if (flag3)
					{
						int num7 = Class60.smethod_20(uint_2, array);
						bool flag4 = 0 < num7;
						if (flag4)
						{
							uint_0 = new uint[]
							{
								uint_2[num7, 0],
								uint_2[num7, 1]
							};
							bool flag5 = uint_2.GetLength(1) > 2;
							if (flag5)
							{
								int_1 = (int)uint_2[num7, 2];
							}
							uint_1 = null;
						}
					}
					long num8 = Class60.smethod_18(array, uint_0);
					bool flag6 = num8 <= 90000L;
					if (flag6)
					{
						long long_ = Class12.smethod_27();
						while (!Class12.bool_0)
						{
							array = new uint[]
							{
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							num8 = Class60.smethod_18(array, uint_0);
							bool flag7 = num8 < 11500L || Class12.smethod_28(long_) > 6000L;
							if (flag7)
							{
								break;
							}
							uint num9 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag8 = (num9 == 0U || (ulong)num9 == (ulong)((long)num6)) && (ulong)num9 != (ulong)((long)int_2);
							if (!flag8)
							{
								return 1;
							}
							Class70.smethod_61(gstruct49_0, uint_0);
							Thread.Sleep(300);
						}
						long_ = Class12.smethod_27();
						while (!Class12.bool_0 && uint_1 != null)
						{
							array = new uint[]
							{
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
								Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
							};
							num8 = Class60.smethod_18(array, uint_1);
							bool flag9 = num8 < 11500L || Class12.smethod_28(long_) > 6000L;
							if (flag9)
							{
								break;
							}
							uint num10 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag10 = (num10 == 0U || (ulong)num10 == (ulong)((long)num6)) && (ulong)num10 != (ulong)((long)int_2);
							if (!flag10)
							{
								return 1;
							}
							Class70.smethod_61(gstruct49_0, uint_1);
							Thread.Sleep(300);
						}
						long_ = Class12.smethod_27();
						while (Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137) > 1U && Class12.smethod_28(long_) < 1800L)
						{
							Thread.Sleep(300);
						}
						for (int i = 0; i < 5; i++)
						{
							bool flag11 = Class70.smethod_7(gstruct49_0);
							if (flag11)
							{
								Class60.smethod_25(gstruct49_0, int_1);
							}
							Thread.Sleep(350);
							uint num11 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
							bool flag12 = (num11 != 0U && (ulong)num11 != (ulong)((long)num6)) || (ulong)num11 == (ulong)((long)int_2);
							if (flag12)
							{
								return 1;
							}
						}
						result = 0;
					}
					else
					{
						Class60.smethod_29(gstruct49_0, false);
						Thread.Sleep(100);
						Class14.smethod_1(gstruct49_0, uint_0);
						result = -1;
					}
				}
			}
			return result;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000A10CC File Offset: 0x0009F2CC
		public static void smethod_25(GStruct49 gstruct49_0, int int_1)
		{
			uint[] array = Class36.smethod_30(gstruct49_0);
			bool flag = array != null;
			if (flag)
			{
				uint num = 200U;
				double num2 = (double)Math.Abs(int_1) * 3.14 / 180.0;
				uint[] uint_ = new uint[]
				{
					(uint)(array[0] + num * Math.Cos(num2)),
					(uint)(array[1] - num * Math.Sin(num2))
				};
				Class70.smethod_61(gstruct49_0, uint_);
				Thread.Sleep(150);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000A1154 File Offset: 0x0009F354
		public static uint[] smethod_26(GStruct49 gstruct49_0, ref int int_1)
		{
			bool flag = FormMayphu.bool_3 || gstruct49_0.int_68 == null || gstruct49_0.int_68[0] <= 0 || gstruct49_0.string_9 == null || gstruct49_0.string_9 == string.Empty || gstruct49_0.string_9 == gstruct49_0.string_22;
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = false;
				int num = 0;
				byte[] array = new byte[gstruct49_0.string_9.Length + 1];
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
				uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
				uint num5;
				for (;;)
				{
					bool flag3 = int_1 > 0;
					if (flag3)
					{
						num5 = num4 + (uint)(int_1 * (int)Class53.gstruct51_15.uint_0);
						uint uint_ = num5 + Class53.gstruct51_16.uint_0;
						bool flag4 = Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num) && array[0] != 0 && Class22.smethod_30(num5 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) == 1U;
						if (flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
							string text = Class10.smethod_3(array);
							bool flag5 = !(text == string.Empty) && Class12.smethod_2(text, gstruct49_0.string_9, true) && Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137) > 0U;
							if (flag5)
							{
								break;
							}
						}
					}
					bool flag6 = flag2;
					if (flag6)
					{
						goto Block_14;
					}
					int num6 = 0;
					byte[] array2 = new byte[4];
					uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array2, 4, ref num6);
					int num7 = BitConverter.ToInt32(array2, 0);
					bool flag7 = num7 > 1;
					if (!flag7)
					{
						goto IL_38D;
					}
					int num8 = 0;
					uint num9 = 1U;
					for (;;)
					{
						bool flag8 = num9 < 256U && num7 > num8;
						if (!flag8)
						{
							goto IL_378;
						}
						bool flag9 = num9 == num3;
						if (flag9)
						{
							num8++;
						}
						else
						{
							num5 = num4 + num9 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_50.uint_0, array2, 4, ref num6);
							bool flag10 = BitConverter.ToInt32(array2, 0) > 0;
							if (flag10)
							{
								num8++;
								bool flag11 = Class22.smethod_30(num5 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) == 1U;
								if (flag11)
								{
									uint uint_ = num5 + Class53.gstruct51_16.uint_0;
									bool flag12 = Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num) && array[0] > 0;
									if (flag12)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
										string text = Class10.smethod_3(array);
										bool flag13 = text != string.Empty && Class12.smethod_2(text, gstruct49_0.string_9, true);
										if (flag13)
										{
											break;
										}
									}
								}
							}
						}
						num9 += 1U;
					}
					int_1 = (int)num9;
					flag2 = true;
				}
				return new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				Block_14:
				return null;
				IL_378:
				return null;
				IL_38D:
				result = null;
			}
			return result;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000A1504 File Offset: 0x0009F704
		public static int smethod_27(GStruct49 gstruct49_0, string string_1, int int_1 = -1, bool bool_0 = false)
		{
			int num = 0;
			byte[] array = new byte[4];
			uint num3;
			for (;;)
			{
				IL_25E:
				bool flag = !bool_0 && gstruct49_0.uint_18 > 0U;
				if (flag)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_18, array, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array, 0) > 0;
					if (flag2)
					{
						break;
					}
					array[0] = 1;
					Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_18, array, 1, ref num);
					bool flag3 = !Class60.smethod_17(gstruct49_0, string_1, true);
					if (flag3)
					{
						goto Block_4;
					}
				}
				int num2 = 0;
				num3 = 0U;
				while (num3 == 0U)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
					num3 = BitConverter.ToUInt32(array, 0);
					bool flag4 = num3 > 0U;
					if (!flag4)
					{
						bool flag5 = bool_0;
						if (flag5)
						{
							bool_0 = false;
							goto IL_25E;
						}
						bool flag6 = num2 <= 300;
						if (!flag6)
						{
							goto IL_E8;
						}
					}
					num2++;
					Thread.Sleep(1);
				}
				goto Block_8;
			}
			return 0;
			Block_4:
			int result = -1;
			goto IL_266;
			IL_E8:
			result = 1;
			goto IL_266;
			Block_8:
			string text = "STRINGINPUT";
			uint uint_ = num3 + Class53.gstruct51_242.uint_0;
			array = new byte[text.Length + 1];
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
			string a = Class10.smethod_3(array).Trim().ToUpper();
			bool flag7 = !(a != text);
			if (flag7)
			{
				int num4 = Form1.int_12;
				bool flag8 = int_1 >= 0 && num4 <= int_1;
				if (flag8)
				{
					num4 = int_1 + 1;
				}
				bool flag9 = gstruct49_0.int_25 > 0 && gstruct49_0.int_60 != null && gstruct49_0.int_60[0] > 0;
				if (flag9)
				{
					int[] array2 = new int[]
					{
						1,
						2,
						3,
						4,
						6
					};
					int num5 = array2[gstruct49_0.int_60[1]];
					int num6 = Class79.smethod_25(gstruct49_0, 3U);
					int num7 = num6 - num5;
					bool flag10 = num7 < 0;
					if (flag10)
					{
						num7 = 0;
					}
					bool flag11 = num4 > num7;
					if (flag11)
					{
						num4 = num7;
					}
				}
				char[] array3 = num4.ToString().ToCharArray();
				for (int i = 0; i < array3.Length; i++)
				{
					Class22.smethod_4(gstruct49_0.uint_4, (uint)array3[i]);
					Thread.Sleep(10);
				}
				Class22.smethod_4(gstruct49_0.uint_4, 13U);
				result = 2;
			}
			else
			{
				result = 1;
			}
			IL_266:
			bool flag12 = gstruct49_0.uint_18 > 0U;
			if (flag12)
			{
				byte[] array4 = new byte[4];
				array = array4;
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_18, array, 4, ref num);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_18 + 4U, array, 4, ref num);
			}
			return result;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x000A17C8 File Offset: 0x0009F9C8
		public static void smethod_28(GStruct49 gstruct49_0)
		{
			bool flag = Class36.smethod_27(gstruct49_0) > 0 && Class60.smethod_14(gstruct49_0, true);
			if (flag)
			{
				Thread.Sleep(1 + FormLuomrac.int_5);
				Class22.smethod_53(gstruct49_0.process_0);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000A1808 File Offset: 0x0009FA08
		public static bool smethod_29(GStruct49 gstruct49_0, bool bool_0)
		{
			int num = 0;
			byte[] array = new byte[8];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_47 * 4U, array, 8, ref num);
			long long_ = BitConverter.ToInt64(array, 0);
			bool flag = Class12.smethod_28(long_) < 999L;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = false;
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
				uint num4 = num3 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
				uint num5 = BitConverter.ToUInt32(array2, 0);
				uint num6 = num5 + num4;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_44.uint_0, array2, 4, ref num);
				int num7 = BitConverter.ToInt32(array2, 0);
				bool flag3 = (bool_0 && num7 > 0) || (!bool_0 && num7 == 0 && Class70.smethod_3(gstruct49_0, Class70.uint_20, 4) > 0);
				if (flag3)
				{
					Class70.smethod_57(gstruct49_0, "Switch([[horse]])");
					flag2 = true;
				}
				array = BitConverter.GetBytes(DateTime.Now.Ticks);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_47 * 4U, array, 8, ref num);
				result = flag2;
			}
			return result;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000A1990 File Offset: 0x0009FB90
		public static bool smethod_30(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.int_93 > 2;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[8];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_47 * 4U, array, 8, ref num);
				long long_ = BitConverter.ToInt64(array, 0);
				bool flag2 = Class12.smethod_28(long_) >= 999L;
				if (flag2)
				{
					byte[] array2 = new byte[4];
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
					uint num2 = BitConverter.ToUInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
					uint num3 = BitConverter.ToUInt32(array2, 0);
					uint num4 = num3 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
					uint num5 = BitConverter.ToUInt32(array2, 0);
					uint num6 = num5 + num4;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_44.uint_0, array2, 4, ref num);
					int num7 = BitConverter.ToInt32(array2, 0);
					bool flag3 = false;
					bool flag4 = num7 <= 0;
					if (flag4)
					{
						bool flag5 = gstruct49_0.int_93 <= 0;
						if (flag5)
						{
							flag3 = true;
						}
						else
						{
							bool flag6 = gstruct49_0.int_93 == 2;
							if (flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_46 * 4U, array2, 4, ref num);
								bool flag7 = BitConverter.ToInt32(array2, 0) == 0;
								if (flag7)
								{
									flag3 = true;
								}
							}
						}
					}
					else
					{
						bool flag8 = gstruct49_0.int_93 != 1;
						if (flag8)
						{
							bool flag9 = gstruct49_0.int_93 == 2;
							if (flag9)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_46 * 4U, array2, 4, ref num);
								int num8 = BitConverter.ToInt32(array2, 0);
								bool flag10 = num8 > 0;
								if (flag10)
								{
									flag3 = true;
								}
							}
						}
						else
						{
							flag3 = true;
						}
					}
					bool flag11 = flag3;
					if (flag11)
					{
						Class70.smethod_57(gstruct49_0, "Switch([[horse]])");
					}
					array = BitConverter.GetBytes(DateTime.Now.Ticks);
					Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_47 * 4U, array, 8, ref num);
					result = flag3;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x040002E0 RID: 736
		public static string[,] string_0;

		// Token: 0x040002E1 RID: 737
		public static int[,] int_0;
	}
}
