using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000029 RID: 41
	internal class Class45
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00070CAC File Offset: 0x0006EEAC
		public static int[] smethod_0(uint uint_0 = 3U)
		{
			int[,] array = new int[11, 3];
			Class11.smethod_4(array, 208194);
			int[,] array2 = array;
			int num = 0;
			for (;;)
			{
				bool flag = num < array2.GetLength(0);
				if (!flag)
				{
					goto IL_47;
				}
				bool flag2 = (ulong)uint_0 == (ulong)((long)array2[num, 0]);
				if (flag2)
				{
					break;
				}
				num++;
			}
			return new int[]
			{
				array2[num, 1],
				array2[num, 2]
			};
			IL_47:
			return new int[]
			{
				6,
				10
			};
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00070D3C File Offset: 0x0006EF3C
		public static bool smethod_1(uint uint_0)
		{
			int[] array = new int[]
			{
				3,
				4,
				9,
				10,
				11,
				23
			};
			for (int i = 0; i < array.Length; i++)
			{
				bool flag = (ulong)uint_0 == (ulong)((long)array[i]);
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00070D88 File Offset: 0x0006EF88
		private static uint smethod_2(uint uint_0)
		{
			bool flag = uint_0 == 0U || uint_0 == 1U;
			uint result;
			if (flag)
			{
				result = 3U;
			}
			else
			{
				switch (uint_0)
				{
				case 2U:
					result = 1U;
					break;
				case 3U:
					result = 7U;
					break;
				case 4U:
					result = 6U;
					break;
				case 5U:
					result = 4U;
					break;
				case 6U:
					result = 2U;
					break;
				case 7U:
					result = 0U;
					break;
				case 8U:
					result = 5U;
					break;
				case 9U:
					result = 9U;
					break;
				case 10U:
					result = 10U;
					break;
				default:
					result = 11U;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00070E08 File Offset: 0x0006F008
		public static bool smethod_3(GStruct49 gstruct49_0, string string_1 = null)
		{
			bool flag = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137) == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				string text = Class45.smethod_4(gstruct49_0);
				bool flag2 = text != null && !(text == string.Empty);
				if (flag2)
				{
					string[] array = new string[]
					{
						Class12.smethod_53("ᓥᓑᓟ"),
						Class12.smethod_53("ᓚᓖ")
					};
					string[] array2 = text.Split(new char[]
					{
						' ',
						'"'
					});
					int i = 0;
					for (;;)
					{
						bool flag3 = i < array2.Length;
						if (!flag3)
						{
							goto IL_EC;
						}
						for (int j = 0; j < array.Length; j++)
						{
							bool flag4 = !(array2[i].ToLower() == array[j]);
							if (!flag4)
							{
								goto IL_CE;
							}
						}
						i++;
					}
					IL_CE:
					string_1 = array2[i];
					goto IL_1B8;
					IL_EC:
					string[] array3 = new string[]
					{
						"gâ",
						"nhËp"
					};
					for (int k = 0; k < array3.Length; k++)
					{
						bool flag5 = false;
						for (i = 0; i < array2.Length; i++)
						{
							bool flag6 = !flag5;
							if (flag6)
							{
								bool flag7 = 0 <= array2[i].ToLower().IndexOf(array3[k]);
								if (flag7)
								{
									flag5 = true;
								}
							}
							else
							{
								bool flag8 = array2[i] == null || !(array2[i] != string.Empty);
								if (!flag8)
								{
									string_1 = array2[i];
									goto IL_1A4;
								}
							}
						}
					}
					IL_1A4:
					IL_1B8:;
				}
				bool flag10;
				bool flag9 = flag10 = (string_1 != string.Empty && string_1 != null);
				if (flag10)
				{
					bool flag11 = string_1[0] > '፻';
					if (flag11)
					{
						string_1 = Class12.smethod_53(string_1);
					}
					Class45.smethod_5(gstruct49_0, string_1, true);
				}
				result = flag9;
			}
			return result;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00071018 File Offset: 0x0006F218
		public static string smethod_4(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 == 0U || Class53.gstruct51_172.uint_0 == 0U || Class53.gstruct51_173.uint_0 == 0U || Class53.gstruct51_171.uint_0 == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, gstruct49_0.int_137);
				bool flag2 = num > 0U;
				if (flag2)
				{
					uint num2 = num + Class53.gstruct51_173.uint_0 - 40U;
					uint uint_ = num2 - 12U;
					int num3 = 0;
					byte[] array = new byte[1];
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num3);
					int num4 = (int)array[0];
					bool flag3 = num4 <= 0;
					if (flag3)
					{
						num4 = 1;
					}
					array = new byte[num4];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array, num4, ref num3);
					result = Class10.smethod_3(array);
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00071108 File Offset: 0x0006F308
		public static int smethod_5(GStruct49 gstruct49_0, string string_1, bool bool_0 = false)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_172.uint_0 != 0U && Class53.gstruct51_173.uint_0 != 0U && Class53.gstruct51_171.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num2 > 0U;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_173.uint_0 + Class53.gstruct51_171.uint_0, array, 4, ref num);
					uint num3 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num3 > 0U;
					if (flag3)
					{
						byte[] array2 = Class12.smethod_46(string_1, true);
						byte[] array3 = new byte[1];
						byte[] byte_ = new byte[]
						{
							(byte)string_1.Length
						};
						int num4 = 0;
						while (num4 <= 100 && array3[0] == 0)
						{
							num4++;
							Thread.Sleep(1);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, 1, ref num);
						}
						bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, num3 - 52U, byte_, 1, ref num);
						bool flag5 = Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num3 - 71U, array3, 2, ref num);
						bool flag6 = array3[0] == 0;
						if (flag6)
						{
							array3[0] = 1;
							Class22.WriteProcessMemory(gstruct49_0.int_137, num3 - 71U, array3, 1, ref num);
						}
						if (bool_0)
						{
							Thread.Sleep(10);
							Class22.smethod_4(gstruct49_0.uint_4, 13U);
						}
						result = (int)Convert.ToByte(flag5 && flag4);
					}
					else
					{
						if (bool_0)
						{
							Class22.smethod_4(gstruct49_0.uint_4, 13U);
						}
						result = 0;
					}
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000712F0 File Offset: 0x0006F4F0
		public static string smethod_6(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 == 0U || Class53.gstruct51_172.uint_0 == 0U || Class53.gstruct51_173.uint_0 == 0U || Class53.gstruct51_171.uint_0 == 0U;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_172.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num2 == 0U;
				if (flag2)
				{
					result = null;
				}
				else
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_173.uint_0 + Class53.gstruct51_171.uint_0, array, 4, ref num);
					uint num3 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num3 > 0U;
					if (flag3)
					{
						int num4 = 0;
						byte[] array2 = new byte[1];
						while (num4 <= 300 && array2[0] == 0)
						{
							num4++;
							Thread.Sleep(1);
							Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array2, 1, ref num);
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, num3 - 52U, array2, 1, ref num);
						bool flag4 = array2[0] > 0;
						if (flag4)
						{
							byte[] byte_ = new byte[(int)array2[0]];
							Class22.ReadProcessMemory(gstruct49_0.int_137, num3, byte_, (int)array2[0], ref num);
							result = Class10.smethod_3(byte_);
						}
						else
						{
							result = string.Empty;
						}
					}
					else
					{
						result = null;
					}
				}
			}
			return result;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00071464 File Offset: 0x0006F664
		public static uint smethod_7(GStruct49 gstruct49_0, int int_2)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_12.uint_0;
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_261.uint_0, gstruct49_0.int_137);
			uint result = 0U;
			bool flag = num2 > 0U;
			if (flag)
			{
				result = Class22.smethod_30(num2 + (uint)(int_2 * 4), gstruct49_0.int_137);
			}
			return result;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000714D0 File Offset: 0x0006F6D0
		public static bool smethod_8(GStruct49 gstruct49_0)
		{
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_179.uint_0 + Class53.gstruct51_180.uint_0 + Class53.gstruct51_181.uint_0;
			uint num = Class22.smethod_30(uint_, gstruct49_0.int_137);
			return num > 0U;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0007151C File Offset: 0x0006F71C
		public static int smethod_9(GStruct49 gstruct49_0)
		{
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_158.uint_0;
			uint num = Class22.smethod_30(uint_, gstruct49_0.int_137);
			bool flag = num == 0U;
			int result;
			if (flag)
			{
				result = -1000;
			}
			else
			{
				uint uint_2 = num + Class53.gstruct51_159.uint_0;
				result = (int)(Class22.smethod_30(uint_2, gstruct49_0.int_137) - 1U);
			}
			return result;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0007157C File Offset: 0x0006F77C
		public static void smethod_10(GStruct49 gstruct49_0)
		{
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_158.uint_0;
			uint num = Class22.smethod_30(uint_, gstruct49_0.int_137);
			bool flag = num > 0U;
			if (flag)
			{
				uint uint_2 = num + Class53.gstruct51_159.uint_0;
				int num2 = 0;
				byte[] array = new byte[4];
				array[0] = 1;
				byte[] byte_ = array;
				Class22.WriteProcessMemory(gstruct49_0.int_137, uint_2, byte_, 4, ref num2);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000715E4 File Offset: 0x0006F7E4
		public static bool smethod_11(GStruct49 gstruct49_0)
		{
			bool flag;
			bool result = flag = Class45.smethod_8(gstruct49_0);
			if (flag)
			{
				Class22.smethod_4(gstruct49_0.uint_4, 27U);
				Thread.Sleep(999);
			}
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0;
			bool flag2 = Class22.smethod_30(uint_, gstruct49_0.int_137) > 0U;
			if (flag2)
			{
				Class22.smethod_4(gstruct49_0.uint_4, 27U);
			}
			return result;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00071654 File Offset: 0x0006F854
		public static int smethod_12(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_184.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_156.uint_0, gstruct49_0.int_137);
			return (int)Class22.smethod_30(num2 + Class53.gstruct51_183.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000716AC File Offset: 0x0006F8AC
		public static bool smethod_13(GStruct49 gstruct49_0, bool bool_0)
		{
			return Class70.smethod_110(gstruct49_0, bool_0);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000716C8 File Offset: 0x0006F8C8
		public static uint smethod_14(GStruct49 gstruct49_0)
		{
			bool flag = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				int num4 = Class79.smethod_4(gstruct49_0);
				int num5 = 0;
				uint num6 = 1U;
				while ((ulong)num6 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num4 <= num5;
					if (flag2)
					{
						break;
					}
					uint num7 = num2 + num6 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
					uint num8 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num8 == 0U;
					if (!flag3)
					{
						uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] > 0;
							if (flag5)
							{
								num5++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag6 = array[0] == 1;
								if (flag6)
								{
									return num6;
								}
							}
						}
					}
					num6 += 1U;
				}
				result = 0U;
			}
			return result;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00071884 File Offset: 0x0006FA84
		public static int smethod_15(GStruct49 gstruct49_0, uint uint_0 = 3U)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
			bool flag = BitConverter.ToInt32(array2, 0) > 0;
			int result;
			if (flag)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
				int num4 = Class79.smethod_4(gstruct49_0);
				int num5 = 0;
				uint num6 = 1U;
				while ((ulong)num6 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num4 <= num5;
					if (flag2)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array2, 0);
					bool flag3 = num7 == 0U;
					if (!flag3)
					{
						uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] == 0;
							if (!flag5)
							{
								num5++;
								uint num9 = num2 + num6 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag6 = array[0] != 1;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
									byte b = array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0, array, 1, ref num);
									byte b2 = array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_111.uint_0, array, 1, ref num);
									uint uint_ = (uint)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_112.uint_0, array, 1, ref num);
									uint uint_2 = (uint)array[0];
									uint num10 = uint_0;
									uint[] array3 = Class79.smethod_26(gstruct49_0, num10, uint_, uint_2);
									bool flag7 = array3 == null;
									if (flag7)
									{
										num10 = 3U;
										array3 = Class79.smethod_26(gstruct49_0, num10, uint_, uint_2);
										bool flag8 = array3 == null;
										if (flag8)
										{
											return -1;
										}
									}
									int num11 = 0;
									while (!Class12.bool_0)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
										bool flag9 = BitConverter.ToInt32(array2, 0) > 0;
										if (!flag9)
										{
											return 1;
										}
										bool flag10 = num11 % 5 == 0;
										if (flag10)
										{
											Class70.smethod_46(gstruct49_0, array3[0], array3[1], num10, array3[0], array3[1], num10);
										}
										bool flag11 = num11 > 30;
										if (flag11)
										{
											break;
										}
										num11++;
										Thread.Sleep(100);
									}
								}
							}
						}
					}
					num6 += 1U;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
				result = (int)Convert.ToByte(BitConverter.ToInt32(array2, 0) <= 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00071BE4 File Offset: 0x0006FDE4
		public static int smethod_16(GStruct49 gstruct49_0, uint uint_0, uint uint_1, string string_1, int int_2 = -1, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false)
		{
			bool flag = string_1 != null && !(string_1 == string.Empty);
			int result;
			if (flag)
			{
				int num = 1;
				int num2 = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num2);
				uint num3 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array2, 0);
				int num5 = 1;
				string[] array3 = string_1.Split(new char[]
				{
					'|'
				});
				string[] array4 = new string[array3.Length];
				for (int i = 0; i < array3.Length; i++)
				{
					bool flag2 = array3[i] == null;
					if (flag2)
					{
						array3[i] = string.Empty;
					}
					bool flag3 = num5 < array3[i].Length;
					if (flag3)
					{
						num5 = array3[i].Length;
					}
					array4[i] = array3[i].Trim().ToLower();
				}
				num5 += 2;
				byte[] byte_ = new byte[num5];
				Class45.smethod_21(gstruct49_0);
				bool flag4 = Class45.smethod_1(uint_0) && Class45.smethod_1(uint_1) && uint_0 != uint_1;
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = 1U;
				while ((ulong)num8 < (ulong)((long)Class53.int_1) && num6 > num7)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num2);
					uint num9 = BitConverter.ToUInt32(array2, 0);
					bool flag5 = num9 == 0U;
					if (!flag5)
					{
						uint num10 = num4 + num9 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num2);
						bool flag6 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
							bool flag7 = array[0] == 0;
							if (!flag7)
							{
								num7++;
								uint num11 = num3 + num8 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
								uint num12 = (uint)array[0];
								bool flag8 = num12 != uint_0;
								if (!flag8)
								{
									if (bool_1)
									{
										bool flag9 = Class53.gstruct51_120.uint_0 == 0U;
										if (flag9)
										{
											num = -5;
											break;
										}
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_120.uint_0, array2, 4, ref num2);
										int num13 = BitConverter.ToInt32(array2, 0);
										bool flag10 = num13 != -2;
										if (flag10)
										{
											goto IL_71A;
										}
									}
									bool flag12;
									bool flag11 = !(flag12 = (array3 == null));
									if (flag11)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, byte_, num5, ref num2);
										string text = Class10.smethod_3(byte_);
										string string_2 = text.ToLower();
										for (int j = 0; j < array3.Length; j++)
										{
											bool flag13 = text == array3[j] || (!bool_0 && Class12.smethod_1(string_2, array4[j]) == 0);
											if (flag13)
											{
												flag12 = true;
												break;
											}
										}
										bool flag14 = !flag12;
										if (flag14)
										{
											goto IL_71A;
										}
									}
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num2);
									uint num14 = (uint)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0, array, 1, ref num2);
									uint num15 = (uint)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_111.uint_0, array, 1, ref num2);
									uint num16 = (uint)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_112.uint_0, array, 1, ref num2);
									uint num17 = (uint)array[0];
									uint[] array5 = Class79.smethod_26(gstruct49_0, uint_1, num16, num17);
									bool flag15 = array5 != null;
									if (flag15)
									{
										int k = 0;
										bool flag16 = flag4;
										if (flag16)
										{
											Class70.smethod_46(gstruct49_0, num14, num15, uint_0, array5[0], array5[1], uint_1);
											while (k < 30)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
												uint num18 = (uint)array[0];
												bool flag17 = num12 != num18;
												if (flag17)
												{
													break;
												}
												Thread.Sleep(10);
												k++;
											}
											bool flag18 = int_2 >= 0;
											if (flag18)
											{
												int_2--;
												bool flag19 = int_2 <= 0;
												if (flag19)
												{
													num = 1;
													break;
												}
											}
										}
										else
										{
											if (bool_2)
											{
												int num19 = int_2;
												bool flag20 = num19 <= 0;
												if (flag20)
												{
													num19 = 1;
												}
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num2);
												int num20 = BitConverter.ToInt32(array2, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array2, 0, ref num2);
												int num21 = (int)array2[0];
												int num22 = 0;
												while (!Class12.bool_0 && num20 > num19 && num21 > 1)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num2);
													int num23 = BitConverter.ToInt32(array2, 0);
													bool flag21 = num22 > 30 || num23 > 0;
													if (flag21)
													{
														break;
													}
													bool flag22 = num22 % 8 == 0;
													if (flag22)
													{
														Class70.smethod_71(gstruct49_0, num9, (uint)num19, 89);
													}
													Thread.Sleep(100);
													num22++;
												}
											}
											int num24 = 0;
											while (!Class12.bool_0)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num2);
												int num25 = BitConverter.ToInt32(array2, 0);
												bool flag23 = num25 > 0;
												if (flag23)
												{
													break;
												}
												bool flag24 = num24 % 6 == 0;
												if (flag24)
												{
													Class70.smethod_46(gstruct49_0, num14, num15, num12, num14, num15, num12);
												}
												bool flag25 = num24 <= 40;
												if (!flag25)
												{
													num = -2;
													goto IL_73D;
												}
												Thread.Sleep(100);
												num24++;
											}
											num24 = 0;
											while (!Class12.bool_0)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num2);
												bool flag26 = BitConverter.ToInt32(array2, 0) == 0;
												if (flag26)
												{
													break;
												}
												bool flag27 = num24 % 6 == 0;
												if (flag27)
												{
													Class70.smethod_46(gstruct49_0, array5[0], array5[1], uint_1, array5[0], array5[1], uint_1);
												}
												bool flag28 = num24 <= 40;
												if (!flag28)
												{
													Class70.smethod_46(gstruct49_0, num14, num15, num12, num14, num15, num12);
													num = -2;
													goto IL_73D;
												}
												Thread.Sleep(100);
												num24++;
											}
											bool flag29 = int_2 >= 0;
											if (flag29)
											{
												int_2--;
												bool flag30 = int_2 <= 0;
												if (flag30)
												{
													num = 1;
													break;
												}
											}
										}
									}
									else
									{
										bool flag31 = num16 <= 1U && num17 <= 1U;
										if (flag31)
										{
											num = 0;
											break;
										}
									}
								}
							}
						}
					}
					IL_71A:
					num8 += 1U;
				}
				IL_73D:
				result = num;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0007233C File Offset: 0x0007053C
		public static int smethod_17(GStruct49 gstruct49_0, uint uint_0, uint uint_1, string string_1, int int_2 = -1, bool bool_0 = false, bool bool_1 = false)
		{
			bool flag = string_1 != null && !(string_1 == string.Empty);
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[1];
				byte[] array2 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array2, 0);
				int num4 = 1;
				string[] array3 = string_1.Split(new char[]
				{
					'|'
				});
				string[] array4 = new string[array3.Length];
				for (int i = 0; i < array3.Length; i++)
				{
					bool flag2 = array3[i] == null;
					if (flag2)
					{
						array3[i] = string.Empty;
					}
					bool flag3 = num4 < array3[i].Length;
					if (flag3)
					{
						num4 = array3[i].Length;
					}
					array4[i] = array3[i].Trim().ToLower();
				}
				num4 += 2;
				byte[] array5 = new byte[num4];
				Class45.smethod_21(gstruct49_0);
				bool flag4 = Class45.smethod_1(uint_0) && Class45.smethod_1(uint_1);
				if (flag4)
				{
				}
				int num5 = Class79.smethod_4(gstruct49_0);
				int num6 = 0;
				int num7 = 0;
				uint num8 = 1U;
				uint num14;
				uint num15;
				for (;;)
				{
					bool flag5 = (ulong)num8 < (ulong)((long)Class53.int_1) && num5 > num6;
					if (flag5)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num);
						uint num9 = BitConverter.ToUInt32(array2, 0);
						bool flag6 = num9 > 0U;
						if (flag6)
						{
							uint num10 = num3 + num9 * Class53.gstruct51_106.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
							bool flag7 = BitConverter.ToInt32(array2, 0) == 0;
							if (flag7)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, 1, ref num);
								bool flag8 = array[0] > 0;
								if (flag8)
								{
									num6++;
									uint num11 = num2 + num8 * 20U;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
									bool flag9 = (uint)array[0] == uint_0;
									if (flag9)
									{
										bool flag10 = bool_1 && Class53.gstruct51_120.uint_0 > 0U;
										if (flag10)
										{
											int num12 = (int)Class22.smethod_30(num10 + Class53.gstruct51_120.uint_0, gstruct49_0.int_137);
											bool flag11 = num12 != -2;
											if (flag11)
											{
												goto IL_6C2;
											}
										}
										bool flag12 = false;
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array5, array5.Length, ref num);
										string text = Class10.smethod_3(array5);
										foreach (string text2 in array3)
										{
											bool flag13 = !(text2 == "*");
											if (!flag13)
											{
												flag12 = true;
												break;
											}
											bool flag14 = bool_0;
											int num13 = Class12.smethod_1(text2, "*");
											bool flag15 = num13 > 0;
											if (flag15)
											{
												text2 = text2.Substring(0, num13);
												flag14 = false;
											}
											bool flag16 = text == text2 || (!flag14 && Class12.smethod_1(text, text2) == 0);
											if (flag16)
											{
												flag12 = true;
												break;
											}
										}
										bool flag17 = flag12;
										if (flag17)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
											num14 = (uint)array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0, array, 1, ref num);
											num15 = (uint)array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_111.uint_0, array, 1, ref num);
											uint num16 = (uint)array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_112.uint_0, array, 1, ref num);
											uint num17 = (uint)array[0];
											uint[] array6 = Class79.smethod_26(gstruct49_0, uint_1, num16, num17);
											bool flag18 = array6 != null;
											if (flag18)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
												int num18 = BitConverter.ToInt32(array2, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array2, 1, ref num);
												int num19 = (int)array2[0];
												int num20 = 0;
												bool flag19 = num18 > 0 && num19 > 1 && int_2 > 0 && num18 > int_2;
												if (flag19)
												{
													while (!Class12.bool_0)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
														int num21 = BitConverter.ToInt32(array2, 0);
														bool flag20 = num21 > 0;
														if (flag20)
														{
															break;
														}
														bool flag21 = num20 % 8 == 0;
														if (flag21)
														{
															Class70.smethod_71(gstruct49_0, num9, (uint)int_2, 89);
														}
														bool flag22 = num20 <= 30;
														if (!flag22)
														{
															goto IL_50C;
														}
														Thread.Sleep(100);
														num20++;
													}
													num7 = int_2;
												}
												else
												{
													while (!Class12.bool_0)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
														int num22 = BitConverter.ToInt32(array2, 0);
														bool flag23 = num22 > 0;
														if (flag23)
														{
															break;
														}
														bool flag24 = num20 % 6 == 0;
														if (flag24)
														{
															Class70.smethod_46(gstruct49_0, num14, num15, uint_0, num14, num15, uint_0);
														}
														bool flag25 = num20 <= 40;
														if (!flag25)
														{
															goto IL_59D;
														}
														Thread.Sleep(100);
														num20++;
													}
													num7 = ((num18 <= 0 || num19 <= 1) ? (num7 + 1) : (num7 + num18));
												}
												num20 = 0;
												while (!Class12.bool_0)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array2, 4, ref num);
													bool flag26 = BitConverter.ToInt32(array2, 0) == 0;
													if (flag26)
													{
														break;
													}
													bool flag27 = num20 % 6 == 0;
													if (flag27)
													{
														Class70.smethod_46(gstruct49_0, array6[0], array6[1], uint_1, array6[0], array6[1], uint_1);
													}
													bool flag28 = num20 <= 40;
													if (!flag28)
													{
														goto IL_645;
													}
													Thread.Sleep(100);
													num20++;
												}
												bool flag29 = int_2 > 0 && num7 >= int_2;
												if (flag29)
												{
													goto Block_40;
												}
											}
											else
											{
												bool flag30 = num16 <= 1U && num17 <= 1U;
												if (flag30)
												{
													goto Block_42;
												}
											}
										}
									}
								}
							}
						}
						IL_6C2:
						num8 += 1U;
						continue;
						goto IL_6C2;
					}
					goto IL_699;
				}
				IL_50C:
				int num23 = -5;
				goto IL_6D9;
				IL_59D:
				num23 = -2;
				goto IL_6D9;
				IL_645:
				Class70.smethod_46(gstruct49_0, num14, num15, uint_0, num14, num15, uint_0);
				num23 = -4;
				goto IL_6D9;
				Block_40:
				num23 = 1;
				goto IL_6D9;
				Block_42:
				num23 = 0;
				goto IL_6D9;
				IL_699:
				num23 = ((num7 > 0) ? 1 : 2);
				IL_6D9:
				result = num23;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00072A30 File Offset: 0x00070C30
		private static uint[,] smethod_18(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint[,] array2 = new uint[num4, 2];
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				uint num7 = num2 + num6 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					uint num9 = num3 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array, 0) == 0;
					if (flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag4 = array[0] > 0;
						if (flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							array2[num5, 0] = num6;
							array2[num5, 1] = (uint)array[0];
							num5++;
						}
					}
				}
				num6 += 1U;
			}
			return array2;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00072BD8 File Offset: 0x00070DD8
		public static void smethod_19()
		{
			int int_ = Class45.int_0;
			Class45.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_41 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_41;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_41 = true;
						flag = true;
					}
					Class45.smethod_20(int_);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00072C9C File Offset: 0x00070E9C
		private static void smethod_20(int int_2)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			long num3 = 0L;
			for (;;)
			{
				num--;
				Thread.Sleep(600);
				bool bool_ = Class12.bool_0;
				if (bool_)
				{
					break;
				}
				bool flag = num <= 0;
				if (flag)
				{
					int num4 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag2 = num4 < 0;
					if (flag2)
					{
						break;
					}
					num = 30;
					gstruct = Form1.gstruct49_0[num4];
				}
				bool flag3 = num3 > 0L && Class12.smethod_28(num3) > 10000L;
				if (flag3)
				{
					Class45.string_0 = null;
					num3 = 0L;
				}
				int num5 = Class70.smethod_3(gstruct, Class70.uint_50, 4);
				bool flag4 = num5 <= 0;
				if (!flag4)
				{
					string text = null;
					uint num6 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137) + Class53.gstruct51_97.uint_0;
					uint num7 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct.int_137);
					bool flag5 = num5 <= 2;
					int num8;
					int num9;
					uint num10;
					if (flag5)
					{
						num3 = Class12.smethod_27();
						bool flag6 = num5 == 2;
						if (flag6)
						{
							Class70.smethod_52(gstruct, "<bclr=white><color=red>TÊt c¶ ac cïng Qu¨ng ®å...", 1);
						}
						else
						{
							Class70.smethod_52(gstruct, "<bclr=white><color=red>Qu¨ng ®å...<bclr=blue><color=green>(hoÆc bÊm phÝm CTRL + ALT + F ®Ó tÊt c¶ ac cßn l¹i cïng qu¨ng theo)", 1);
						}
						bool flag7 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct.int_137) > 0U;
						if (flag7)
						{
							num8 = Class79.smethod_4(gstruct);
							num9 = 0;
							num10 = 1U;
							while ((ulong)num10 < (ulong)((long)Class53.int_1))
							{
								bool flag8 = num8 <= num9;
								if (flag8)
								{
									break;
								}
								Class22.ReadProcessMemory(gstruct.int_137, num6 + (num10 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num2);
								uint num11 = BitConverter.ToUInt32(array, 0);
								bool flag9 = num11 == 0U;
								if (!flag9)
								{
									uint num12 = num7 + num11 * Class53.gstruct51_106.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num2);
									bool flag10 = BitConverter.ToInt32(array, 0) != 0;
									if (!flag10)
									{
										Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
										bool flag11 = array[0] > 0;
										if (flag11)
										{
											num9++;
											uint num13 = num6 + num10 * 20U;
											Class22.ReadProcessMemory(gstruct.int_137, num13 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
											int num14 = (int)array[0];
											bool flag12 = num14 == 1;
											if (flag12)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num2);
												text = Class10.smethod_3(array2);
												break;
											}
										}
									}
								}
								num10 += 1U;
							}
							bool flag13 = num5 <= 2;
							if (flag13)
							{
								Class45.string_0 = text;
							}
							goto IL_35B;
						}
						Class70.smethod_52(gstruct, "<bclr=blue><color=white>H·y cÇm 1 vËt phÈm, sau ®ã bÊm Ctrl + F (hoÆc Ctrl + Alt + F) ®Ó tiÕn hµnh vøt bá.", 1);
					}
					else
					{
						long long_ = Class12.smethod_27();
						while (Class12.smethod_28(long_) < 10000L)
						{
							text = Class45.string_0;
							bool flag14 = text == null || !(text != string.Empty);
							if (!flag14)
							{
								Class70.smethod_52(gstruct, "<bclr=white><color=red>Qu¨ng ®å...", 1);
								goto IL_35B;
							}
							Thread.Sleep(100);
						}
					}
					IL_347:
					Class70.smethod_2(gstruct, Class70.uint_50, 0, 4);
					continue;
					IL_35B:
					num8 = Class79.smethod_4(gstruct);
					num9 = 0;
					uint num15 = 255U;
					uint num16 = 255U;
					num10 = 1U;
					for (;;)
					{
						bool flag15 = (ulong)num10 < (ulong)((long)Class53.int_1) && num8 > num9;
						if (!flag15)
						{
							goto IL_6E8;
						}
						bool flag16 = Class70.smethod_3(gstruct, Class70.uint_50, 4) != 0 && text != null && !(text == string.Empty);
						if (!flag16)
						{
							goto IL_682;
						}
						int num17 = 0;
						while (!Class12.bool_0)
						{
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num2);
							bool flag17 = BitConverter.ToInt32(array, 0) == 0;
							if (flag17)
							{
								break;
							}
							bool flag18 = num17 % 10 == 0;
							if (flag18)
							{
								Class70.smethod_121(gstruct);
							}
							bool flag19 = num17 <= 100;
							if (!flag19)
							{
								goto IL_431;
							}
							Thread.Sleep(30);
							num17++;
						}
						bool flag20 = num8 > num9;
						if (!flag20)
						{
							goto IL_67F;
						}
						Class22.ReadProcessMemory(gstruct.int_137, num6 + (num10 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num2);
						uint num18 = BitConverter.ToUInt32(array, 0);
						bool flag21 = num18 > 0U;
						if (flag21)
						{
							uint num19 = num7 + num18 * Class53.gstruct51_106.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num2);
							bool flag22 = BitConverter.ToInt32(array, 0) == 0;
							if (flag22)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_107.uint_0, array, 1, ref num2);
								bool flag23 = array[0] > 0;
								if (flag23)
								{
									num9++;
									bool flag24 = (char)array[0] == text[0];
									if (flag24)
									{
										uint num20 = num6 + num10 * 20U;
										Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num2);
										uint num21 = (uint)array[0];
										bool flag25 = num21 == 3U;
										if (flag25)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num19 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num2);
											string a = Class10.smethod_3(array2);
											bool flag26 = !(a != text);
											if (flag26)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num2);
												uint num22 = (uint)array[0];
												Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_100.uint_0, array, 1, ref num2);
												uint num23 = (uint)array[0];
												num17 = 0;
												while (!Class12.bool_0)
												{
													Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num2);
													bool flag27 = BitConverter.ToInt32(array, 0) > 0;
													if (flag27)
													{
														break;
													}
													bool flag28 = num17 % 5 == 0;
													if (flag28)
													{
														Class70.smethod_46(gstruct, num22, num23, num21, num22, num23, num21);
													}
													Thread.Sleep(80);
													num17++;
													bool flag29 = num17 <= 42;
													if (!flag29)
													{
														goto IL_653;
													}
												}
												num15 = num22;
												num16 = num23;
											}
										}
									}
								}
							}
						}
						num10 += 1U;
					}
					IL_78B:
					Class70.smethod_52(gstruct, "<bclr=white><color=red>Qu¨ng ®å kÕt thóc !", 1);
					goto IL_347;
					IL_431:
					Class70.smethod_52(gstruct, "<bclr=blue><color=white>Kh«ng thÓ qu¨ng <" + text + ">", 1);
					goto IL_78B;
					IL_653:
					Class70.smethod_52(gstruct, "<bclr=blue><color=white>>Kh«ng thÓ cÇm vËt phÈm <" + text + ">", 1);
					goto IL_78B;
					IL_6E8:
					bool flag30 = num15 != 255U && num5 > 2 && Class70.smethod_3(gstruct, Class70.uint_50, 4) > 0;
					if (flag30)
					{
						Thread.Sleep(100);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num2);
						bool flag31 = BitConverter.ToInt32(array, 0) > 0;
						if (flag31)
						{
							Class70.smethod_121(gstruct);
						}
					}
					goto IL_78B;
					IL_6E7:
					goto IL_6E8;
					IL_682:
					Thread.Sleep(100);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num2);
					bool flag32 = num15 != 255U && BitConverter.ToInt32(array, 0) > 0;
					if (flag32)
					{
						Class70.smethod_46(gstruct, num15, num16, 3U, num15, num16, 3U);
					}
					bool flag33 = num5 <= 2;
					if (flag33)
					{
						Class45.string_0 = null;
					}
					IL_67F:
					goto IL_6E7;
					goto IL_347;
				}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00073464 File Offset: 0x00071664
		public static int smethod_21(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
			bool flag = BitConverter.ToInt32(array, 0) > 0;
			int result;
			if (flag)
			{
				uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_97.uint_0;
				uint num3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
				int num4 = Class79.smethod_4(gstruct49_0);
				int num5 = 0;
				uint num6 = 1U;
				while ((ulong)num6 < (ulong)((long)Class53.int_1))
				{
					bool flag2 = num4 <= num5;
					if (flag2)
					{
						break;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array, 0);
					bool flag3 = num7 == 0U;
					if (!flag3)
					{
						uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] == 0;
							if (!flag5)
							{
								num5++;
								uint num9 = num2 + num6 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								uint num10 = (uint)array[0];
								bool flag6 = num10 != 1U;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
									byte b = array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0, array, 1, ref num);
									byte b2 = array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_111.uint_0, array, 1, ref num);
									int uint_ = (int)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_112.uint_0, array, 1, ref num);
									int uint_2 = (int)array[0];
									uint[] array2 = Class79.smethod_26(gstruct49_0, 3U, (uint)uint_, (uint)uint_2);
									bool flag7 = array2 == null;
									if (flag7)
									{
										return -1;
									}
									int i = 0;
									while (i < 100)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
										bool flag8 = BitConverter.ToInt32(array, 0) > 0;
										if (!flag8)
										{
											return 1;
										}
										bool flag9 = i % 30 == 0;
										if (flag9)
										{
											Class70.smethod_46(gstruct49_0, array2[0], array2[1], 3U, array2[0], array2[1], 3U);
										}
										i++;
										Thread.Sleep(10);
									}
									return -1;
								}
							}
						}
					}
					num6 += 1U;
				}
				result = 0;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0007374C File Offset: 0x0007194C
		private static uint smethod_22(uint[,] uint_0, uint uint_1)
		{
			bool flag = uint_0 != null;
			if (flag)
			{
				for (int i = 0; i < uint_0.GetLength(0); i++)
				{
					bool flag2 = uint_0[i, 0] == uint_1;
					if (flag2)
					{
						return uint_0[i, 1];
					}
				}
			}
			return 0U;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000737A0 File Offset: 0x000719A0
		public static void smethod_23()
		{
			int int_ = Class45.int_1;
			Class45.int_1 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = !Class12.bool_0 && num >= 0;
					if (!flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_40 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_40;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_40 = true;
						flag = true;
					}
					Class45.smethod_24(int_);
				}
				catch
				{
				}
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00073864 File Offset: 0x00071A64
		private static void smethod_24(int int_2)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = 12000;
			byte[] array = new byte[4];
			long num5 = 0L;
			uint[,] array2 = null;
			uint num6 = 0U;
			uint num7 = 0U;
			uint num8 = 0U;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			for (;;)
			{
				for (;;)
				{
					num2--;
					Thread.Sleep(300);
					bool bool_ = Class12.bool_0;
					if (bool_)
					{
						return;
					}
					bool flag = num2 <= 0;
					if (flag)
					{
						int num14 = Class81.smethod_3(Form1.gstruct49_0, int_2);
						bool flag2 = num14 < 0;
						if (flag2)
						{
							return;
						}
						num2 = 30;
						gstruct = Form1.gstruct49_0[num14];
					}
					int num15 = Class70.smethod_3(gstruct, Class70.uint_21, 4);
					bool flag3 = num15 == 0;
					if (flag3)
					{
						break;
					}
					bool flag4 = num3 != num15;
					if (flag4)
					{
						num3 = num15;
						num5 = Class12.smethod_27();
						array2 = null;
						string str = string.Empty;
						switch (num15)
						{
						case 1:
							str = "ChuyÓn ®å (kÝch th­íc)";
							break;
						case 2:
							str = "ChuyÓn ®å (cïng lo¹i)";
							break;
						case 3:
							str = "Gép vËt phÈm";
							break;
						}
						Class70.smethod_52(gstruct, "<color=yellow>" + str + ": <color=red>B¾t ®Çu..", 1);
						Class79.smethod_24(gstruct, 3U);
					}
					bool flag5 = num15 != 3;
					if (!flag5)
					{
						goto IL_430;
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
					uint num16 = BitConverter.ToUInt32(array, 0);
					uint num17 = num16 + Class53.gstruct51_97.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
					uint num18 = BitConverter.ToUInt32(array, 0);
					bool flag6 = array2 == null;
					if (flag6)
					{
						num6 = 0U;
						num7 = 0U;
						num8 = 0U;
						array2 = Class45.smethod_18(gstruct);
						bool flag7 = array2 == null;
						if (flag7)
						{
							goto Block_10;
						}
						Class70.smethod_52(gstruct, "H·y cÇm vËt phÈm mÉu.", 1);
					}
					bool flag8 = num7 == 0U;
					if (flag8)
					{
						bool flag9 = Class12.smethod_28(num5) <= (long)num4;
						if (!flag9)
						{
							goto IL_429;
						}
						int num19 = Class70.smethod_3(gstruct, Class70.uint_21, 4);
						bool flag10 = num19 != num15;
						if (flag10)
						{
							goto Block_13;
						}
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
						bool flag11 = BitConverter.ToUInt32(array, 0) == 0U;
						if (flag11)
						{
							continue;
						}
						num6 = Class45.smethod_14(gstruct);
						for (int i = 0; i < array2.GetLength(0); i++)
						{
							bool flag12 = num6 == array2[i, 0];
							if (flag12)
							{
								num7 = array2[i, 1];
								break;
							}
						}
						bool flag13 = num7 == 0U;
						if (flag13)
						{
							continue;
						}
						uint num20 = num17 + num6 * 20U;
						Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
						uint num21 = BitConverter.ToUInt32(array, 0);
						bool flag14 = num21 > 0U;
						if (!flag14)
						{
							goto IL_428;
						}
						uint num22 = num18 + num21 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_108.uint_0, array, 1, ref num);
						num9 = (int)array[0];
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_110.uint_0, array, 1, ref num);
						num10 = (int)array[0];
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class79.uint_1, array, 4, ref num);
						num11 = BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class79.uint_1 + 4U, array, 4, ref num);
						BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_111.uint_0, array, 1, ref num);
						num12 = (int)array[0];
						Class22.ReadProcessMemory(gstruct.int_137, num22 + Class53.gstruct51_112.uint_0, array, 1, ref num);
						num13 = (int)array[0];
						Class70.smethod_52(gstruct, "H·y ®Æt vµo r­¬ng ®Ých.", 1);
					}
					bool flag15 = num8 == 0U;
					if (flag15)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num17 + num6 * 20U + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
						bool flag16 = array[0] == 1;
						if (flag16)
						{
							continue;
						}
						bool flag17 = (uint)array[0] == num7;
						if (flag17)
						{
							goto Block_20;
						}
						num8 = (uint)array[0];
					}
					for (;;)
					{
						int num23 = 0;
						int num24 = Class79.smethod_4(gstruct);
						int num25 = 0;
						uint num26 = 0U;
						for (;;)
						{
							num26 += 1U;
							bool flag18 = num24 <= num25 || (long)Class53.int_1 <= (long)((ulong)num26);
							if (flag18)
							{
								break;
							}
							Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_21 * 4U, array, 1, ref num);
							num15 = (int)array[0];
							bool flag19 = num15 != 0;
							if (!flag19)
							{
								goto IL_985;
							}
							uint num27 = num17 + num26 * 20U;
							Class22.ReadProcessMemory(gstruct.int_137, num27 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
							uint num28 = BitConverter.ToUInt32(array, 0);
							bool flag20 = num28 == 0U;
							if (!flag20)
							{
								uint num29 = num18 + num28 * Class53.gstruct51_106.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
								bool flag21 = BitConverter.ToInt32(array, 0) != 0;
								if (!flag21)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_107.uint_0, array, 1, ref num);
									bool flag22 = array[0] == 0;
									if (!flag22)
									{
										num25++;
										Class22.ReadProcessMemory(gstruct.int_137, num27 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
										bool flag23 = (uint)array[0] != num7;
										if (!flag23)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_111.uint_0, array, 1, ref num);
											uint num30 = (uint)array[0];
											Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_112.uint_0, array, 1, ref num);
											uint num31 = (uint)array[0];
											bool flag24 = (ulong)num30 == (ulong)((long)num12) && (ulong)num31 == (ulong)((long)num13);
											bool flag25 = num15 == 2;
											if (flag25)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_108.uint_0, array, 1, ref num);
												int num32 = (int)array[0];
												Class22.ReadProcessMemory(gstruct.int_137, num29 + Class53.gstruct51_110.uint_0, array, 1, ref num);
												int num33 = (int)array[0];
												Class22.ReadProcessMemory(gstruct.int_137, num29 + Class79.uint_1, array, 4, ref num);
												int num34 = BitConverter.ToInt32(array, 0);
												Class22.ReadProcessMemory(gstruct.int_137, num29 + Class79.uint_1 + 4U, array, 4, ref num);
												BitConverter.ToInt32(array, 0);
												flag24 = (num32 == num9 && num33 == num10 && num34 == num11);
											}
											bool flag26 = !flag24;
											if (!flag26)
											{
												uint[] array3 = Class79.smethod_26(gstruct, num8, num30, num31);
												bool flag27 = array3 != null;
												if (!flag27)
												{
													goto IL_97D;
												}
												Class22.ReadProcessMemory(gstruct.int_137, num27 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
												byte b = array[0];
												Class22.ReadProcessMemory(gstruct.int_137, num27 + Class53.gstruct51_100.uint_0, array, 1, ref num);
												byte b2 = array[0];
												int num35 = 0;
												int j = 0;
												while (!Class12.bool_0)
												{
													Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 1, ref num);
													int num36 = (int)array[0];
													bool flag28 = num36 <= 0;
													if (!flag28)
													{
														num35 = 1;
														break;
													}
													bool flag29 = j % 8 == 0;
													if (flag29)
													{
														Class70.smethod_46(gstruct, (uint)b, (uint)b2, num7, (uint)b, (uint)b2, num7);
													}
													bool flag30 = j > 60;
													if (flag30)
													{
														break;
													}
													Thread.Sleep(10);
													j++;
												}
												bool flag31 = num35 == 0;
												if (!flag31)
												{
													j = 0;
													while (!Class12.bool_0)
													{
														Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 1, ref num);
														bool flag32 = array[0] > 0;
														if (!flag32)
														{
															num35 = 0;
															num23++;
															break;
														}
														Class22.ReadProcessMemory(gstruct.int_137, num27 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
														bool flag33 = BitConverter.ToInt32(array, 0) != 0;
														if (!flag33)
														{
															num35 = 0;
															break;
														}
														bool flag34 = j % 8 == 0;
														if (flag34)
														{
															Class70.smethod_46(gstruct, array3[0], array3[1], num8, array3[0], array3[1], num8);
														}
														bool flag35 = j > 60;
														if (flag35)
														{
															break;
														}
														j++;
														Thread.Sleep(10);
													}
													bool flag36 = num35 <= 0;
													if (!flag36)
													{
														Class70.smethod_46(gstruct, (uint)b, (uint)b2, num7, (uint)b, (uint)b2, num7);
														for (j = 0; j < 100; j++)
														{
															Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
															bool flag37 = BitConverter.ToInt32(array, 0) == 0;
															if (flag37)
															{
																break;
															}
															Thread.Sleep(10);
														}
													}
												}
											}
										}
									}
								}
							}
						}
						bool flag38 = num23 <= 0;
						if (flag38)
						{
							goto Block_44;
						}
					}
					IL_97D:
					num3 = -1;
					IL_985:;
				}
				bool flag39 = num5 > 0L;
				if (flag39)
				{
					Class70.smethod_52(gstruct, "KÕt thóc !", 1);
				}
				num5 = 0L;
				num3 = -1;
				array2 = null;
				Thread.Sleep(200);
				continue;
				Block_13:
				num3 = -1;
				continue;
				IL_430:
				Class45.smethod_25(gstruct);
				num5 = 1L;
				continue;
				Block_20:
				num7 = 0U;
				num6 = 0U;
				continue;
				Block_44:
				num3 = -1;
				continue;
				IL_9B1:
				Class70.smethod_2(gstruct, Class70.uint_21, 0, 4);
				continue;
				IL_429:
				IL_428:
				Block_10:
				goto IL_9B1;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0007423C File Offset: 0x0007243C
		public static void smethod_25(GStruct49 gstruct49_0)
		{
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[4];
			uint num6;
			for (;;)
			{
				Thread.Sleep(10);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num4 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				uint num5 = BitConverter.ToUInt32(array, 0);
				num6 = num5 + num4 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
				int num7 = BitConverter.ToInt32(array, 0);
				int num8 = Class83.smethod_39(gstruct49_0);
				bool flag = num7 <= 0 || num8 <= 1;
				if (!flag)
				{
					goto IL_FF;
				}
				bool flag2 = num2 >= 10;
				if (flag2)
				{
					break;
				}
				num2++;
				Thread.Sleep(100);
			}
			goto IL_359;
			IL_FF:
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
			int num9 = BitConverter.ToInt32(array, 0);
			bool flag3 = num9 == 11 || num9 == 22;
			if (!flag3)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
				uint num10 = BitConverter.ToUInt32(array, 0);
				uint num3;
				uint num11 = num3 + Class53.gstruct51_97.uint_0;
				uint[] array2 = null;
				int num12 = 0;
				uint num13 = 0U;
				for (;;)
				{
					num13 += 1U;
					int num14 = Class79.smethod_4(gstruct49_0);
					bool flag4 = Class12.bool_0 || num14 <= num12 || (long)Class53.int_1 <= (long)((ulong)num13) || Class70.smethod_3(gstruct49_0, Class70.uint_21, 4) != 3;
					if (flag4)
					{
						break;
					}
					uint num15 = num11 + num13 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num15 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
					uint num16 = BitConverter.ToUInt32(array, 0);
					bool flag5 = num16 == 0U;
					if (!flag5)
					{
						uint num17 = num10 + num16 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
						bool flag6 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag6)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag7 = array[0] == 0;
							if (!flag7)
							{
								num12++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num15 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag8 = array[0] != 3;
								if (!flag8)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_119.uint_0, array, 4, ref num);
									int num18 = BitConverter.ToInt32(array, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num17 + Class53.gstruct51_119.uint_0 + 4U, array, 4, ref num);
									int num19 = BitConverter.ToInt32(array, 0);
									bool flag9 = num18 > 0 && num19 > 0 && num19 > num18;
									if (flag9)
									{
										int num20 = Class45.smethod_26(gstruct49_0, ref array2, num13);
										bool flag10 = num20 > 0;
										if (flag10)
										{
											num13 = 0U;
											num12 = 0;
										}
									}
								}
							}
						}
					}
				}
				Class79.smethod_24(gstruct49_0, 3U);
			}
			IL_359:
			Class70.smethod_2(gstruct49_0, Class70.uint_21, 0, 4);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000745B0 File Offset: 0x000727B0
		private static int smethod_26(GStruct49 gstruct49_0, ref uint[] uint_0, uint uint_1)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			int num2 = Class70.smethod_3(gstruct49_0, Class70.uint_21, 4);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
			uint num4 = BitConverter.ToUInt32(array, 0);
			uint num5 = num3 + uint_1 * 20U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
			uint num6 = BitConverter.ToUInt32(array, 0);
			bool flag = num6 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
				byte b = array[0];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
				byte b2 = array[0];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_100.uint_0, array, 1, ref num);
				byte b3 = array[0];
				uint num7 = num4 + num6 * Class53.gstruct51_106.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_111.uint_0, array, 1, ref num);
				byte b4 = array[0];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_112.uint_0, array, 1, ref num);
				byte b5 = array[0];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num);
				byte b6 = array2[0];
				string text = Class10.smethod_3(array2);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class79.uint_1, array, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class79.uint_1 + 4U, array, 4, ref num);
				uint num9 = BitConverter.ToUInt32(array, 0);
				int num10 = 0;
				int num11 = 0;
				int num12 = Class79.smethod_4(gstruct49_0);
				array2 = new byte[text.Length + 2];
				uint num13 = 1U;
				while ((ulong)num13 < (ulong)((long)Class53.int_1) && num12 > num11 && Class70.smethod_3(gstruct49_0, Class70.uint_21, 4) == num2)
				{
					uint num14 = num3 + num13 * 20U;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
					uint num15 = BitConverter.ToUInt32(array, 0);
					bool flag2 = num15 == 0U;
					if (!flag2)
					{
						uint num16 = num4 + num15 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
						bool flag3 = BitConverter.ToInt32(array, 0) != 0;
						if (!flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							byte b7 = array[0];
							num11++;
							bool flag4 = num13 == uint_1 || b7 != b6;
							if (!flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num);
								string a = Class10.smethod_3(array2);
								bool flag5 = a != text;
								if (!flag5)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
									bool flag6 = array[0] != b;
									if (!flag6)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_108.uint_0, array, 1, ref num);
										bool flag7 = array[0] == 0;
										if (!flag7)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_111.uint_0, array, 1, ref num);
											byte b8 = array[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_112.uint_0, array, 1, ref num);
											byte b9 = array[0];
											bool flag8 = b4 != b8 || b5 != b9;
											if (!flag8)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class79.uint_1, array, 4, ref num);
												uint num17 = BitConverter.ToUInt32(array, 0);
												Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class79.uint_1 + 4U, array, 4, ref num);
												uint num18 = BitConverter.ToUInt32(array, 0);
												bool flag9 = num17 != num8 || num18 != num9;
												if (!flag9)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_119.uint_0, array, 4, ref num);
													int num19 = BitConverter.ToInt32(array, 0);
													Class22.ReadProcessMemory(gstruct49_0.int_137, num16 + Class53.gstruct51_119.uint_0 + 4U, array, 4, ref num);
													int num20 = BitConverter.ToInt32(array, 0);
													bool flag10 = num19 <= 0 || num20 <= 0 || num20 <= num19;
													if (!flag10)
													{
														bool flag11 = uint_0 != null;
														if (flag11)
														{
															bool flag12 = false;
															for (int i = 0; i < uint_0.Length; i++)
															{
																bool flag13 = uint_0[i] == num13;
																if (flag13)
																{
																	flag12 = true;
																	break;
																}
															}
															bool flag14 = flag12;
															if (flag14)
															{
																goto IL_715;
															}
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
														uint num21 = (uint)array[0];
														Class22.ReadProcessMemory(gstruct49_0.int_137, num14 + Class53.gstruct51_100.uint_0, array, 1, ref num);
														uint num22 = (uint)array[0];
														int num23 = 0;
														int num24 = 0;
														while (!Class12.bool_0)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
															bool flag15 = BitConverter.ToInt32(array, 0) <= 0;
															if (!flag15)
															{
																num24 = 1;
																break;
															}
															bool flag16 = num23 % 8 == 0;
															if (flag16)
															{
																Class70.smethod_46(gstruct49_0, num21, num22, (uint)b, num21, num22, (uint)b);
															}
															bool flag17 = num23 <= 60;
															if (!flag17)
															{
																Class12.smethod_40(ref uint_0, num13);
																break;
															}
															Thread.Sleep(10);
															num23++;
														}
														num23 = 0;
														while (!Class12.bool_0 && num24 > 0)
														{
															Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_123.uint_0, array, 4, ref num);
															bool flag18 = BitConverter.ToInt32(array, 0) != 0;
															if (!flag18)
															{
																num10++;
																break;
															}
															bool flag19 = num23 % 8 == 0;
															if (flag19)
															{
																Class70.smethod_46(gstruct49_0, (uint)b2, (uint)b3, (uint)b, (uint)b2, (uint)b3, (uint)b);
															}
															bool flag20 = num23 <= 60;
															if (!flag20)
															{
																Class70.smethod_46(gstruct49_0, num21, num22, (uint)b, num21, num22, (uint)b);
																Class12.smethod_40(ref uint_0, num13);
																break;
															}
															num23++;
															Thread.Sleep(10);
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num);
														bool flag21 = BitConverter.ToUInt32(array, 0) == 0U;
														if (flag21)
														{
															break;
														}
														Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_119.uint_0, array, 4, ref num);
														int num25 = BitConverter.ToInt32(array, 0);
														Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_119.uint_0 + 4U, array, 4, ref num);
														int num26 = BitConverter.ToInt32(array, 0);
														bool flag22 = num26 <= num25;
														if (flag22)
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
						}
					}
					IL_715:
					num13 += 1U;
				}
				result = num10;
			}
			return result;
		}

		// Token: 0x04000169 RID: 361
		public static int int_0;

		// Token: 0x0400016A RID: 362
		private static string string_0;

		// Token: 0x0400016B RID: 363
		public static int int_1;
	}
}
