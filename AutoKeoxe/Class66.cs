using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000040 RID: 64
	internal class Class66
	{
		// Token: 0x06000395 RID: 917 RVA: 0x000AE320 File Offset: 0x000AC520
		static Class66()
		{
			uint[,] array_ = new uint[5, 2];
			Class11.smethod_4(array_, 311984);
			Class66.uint_1 = array_;
			Class66.gstruct51_27 = new GStruct51
			{
				string_0 = "GAME_DISABE_CASH_17",
				byte_0 = Class12.smethod_8("89 46 10 B8 01 00 00 00", true),
				int_4 = 0,
				int_0 = 1,
				int_2 = 13
			};
			Class66.gstruct51_28 = new GStruct51
			{
				string_0 = "GAME_DISABE_CASH_18",
				byte_0 = Class12.smethod_8("8B 45 F8 8B 0C 82", true),
				int_4 = 0,
				int_0 = 1,
				int_2 = 11
			};
			Class66.gstruct51_29 = new GStruct51
			{
				string_0 = "GAME_DISABE_CASH_19",
				byte_0 = Class12.smethod_8("8B 45 F8 8B 0C 82", true),
				int_4 = 0,
				int_0 = 2,
				int_2 = 11
			};
			Class66.gstruct51_30 = new GStruct51
			{
				string_0 = "GAME_DISABE_CASH_20",
				byte_0 = Class12.smethod_8("8B 12 8B 42 10", true),
				int_4 = 0,
				int_0 = 1,
				int_2 = 39
			};
			Class66.gstruct51_31 = new GStruct51
			{
				string_0 = "GAME_DISABE_CASH_21",
				byte_0 = Class12.smethod_8("8B 12 8B 42 10", true),
				int_4 = 0,
				int_0 = 2,
				int_2 = 39
			};
			Class66.uint_2 = new uint[]
			{
				5733873U,
				5821081U,
				5821129U,
				5821177U
			};
			Class66.uint_3 = new uint[]
			{
				5487116U,
				5488471U
			};
			Class66.uint_4 = new uint[]
			{
				4392437U,
				4420261U
			};
			Class66.uint_5 = new uint[]
			{
				4617779U,
				4757496U,
				4759208U
			};
			Class66.uint_6 = 5170458U;
			Class66.uint_7 = new uint[]
			{
				4388439U,
				4417002U
			};
			Class66.uint_8 = new uint[]
			{
				4417105U,
				4388533U
			};
			uint[,] array_2 = new uint[3, 2];
			Class11.smethod_4(array_2, 312235);
			Class66.uint_9 = array_2;
			Class66.int_1 = 0;
			Class66.uint_10 = 0U;
			Class66.int_2 = 0;
			Class66.uint_11 = 0U;
			Class66.int_3 = 0;
			Class66.uint_12 = 0U;
			Class66.int_4 = 0;
			Class66.random_0 = new Random();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x000AED78 File Offset: 0x000ACF78
		private static void smethod_0(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = Class53.gstruct51_7.uint_0 > 0U;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_7.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num3 == 1347469363U;
				if (flag2)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, new byte[]
					{
						51,
						192,
						195,
						144
					}, 4, ref num);
				}
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000AEE18 File Offset: 0x000AD018
		private static uint smethod_1(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0 = true)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_11 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("80 38 00 74 05", false);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_11 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 24U) + 5U;
				uint num5 = num2 - (num3 + 35U) + 10U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 11 3D 00 10 FE 7F 7D 0A 80 38 00 74 0BE9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"E9",
					Class12.smethod_45(num5, 8, false, true)
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num6 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num6, ref num);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					array3 = BitConverter.GetBytes(num3 - num2 - 5U);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000AF018 File Offset: 0x000AD218
		private static uint smethod_2(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0 = true)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_8 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						128,
						56,
						0,
						117,
						4
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_8 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 23U) + 9U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 12 3D 00 10 FE 7F 7D 0B 80 38 000F 85",
					Class12.smethod_45(num4, 8, false, true),
					"EB 06FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 59 C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000AF208 File Offset: 0x000AD408
		private static uint smethod_3(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0 = true)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_10 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 45 FC 8B 4D 08", false);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_10 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 25U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"8B 45 FC 8B 4D 08 3D 00 00 01 00 7E 0C 3D 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"8B E5 5D C2 04 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000AF3F8 File Offset: 0x000AD5F8
		private static uint smethod_4(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 != 0U && gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						83,
						139,
						92,
						36,
						12
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 25U) + 5U;
				string string_ = string.Concat(new string[]
				{
					"53 8B 5C 24 0C 81 FB 00 00 01 00 7E 0C 81 FB 00 10 FE 7F0F 8C",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"5B C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000AF5E8 File Offset: 0x000AD7E8
		private static uint smethod_5(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						87,
						139,
						249,
						139,
						8
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 55U) + 5U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 31 3D 00 10 FE 7F 7D 2A 57 8B F9 8B 08 83 F9 01 74 1A 83 F9 02 74 15 8B 48 08 81 F9 00 00 01 00 7E 0F 81 F9 00 10 FE 7F 7D 07 8B 08E9",
					Class12.smethod_45(num4, 8, false, true),
					"5FFF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"81 FF 00 00 01 00 7E 08 81 FF 00 10 FE 7F 7C 05 BF 00 00 01 00 81 FB 00 00 01 00 7E 0D 81 FB 00 10 FE 7F 7C 05 BB 00 00 01 00 C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000AF7D4 File Offset: 0x000AD9D4
		private static uint smethod_6(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 != 0U && gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						139,
						81,
						68,
						131,
						194,
						20
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 41U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 21 3D 00 00 01 00 7E 1A 81 F9 00 10 FE 7F 7D 12 3D 00 10 FE 7F 7D 0B 8B 51 44 83 C2 14E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000AF9CC File Offset: 0x000ADBCC
		private static uint smethod_7(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						139,
						68,
						148,
						16,
						139,
						4,
						131
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 38U) + 7U;
				string string_ = "8B 44 94 10 81 FB 00 00 01 00 7E 0D 81 FB 00 10 FE 7F 7D 05 8B 04 83 EB 08 33 C0FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					byte[] array4 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144
					};
					array4[1] = array3[0];
					array4[2] = array3[1];
					array4[3] = array3[2];
					array4[4] = array3[3];
					array = array4;
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000AFBAC File Offset: 0x000ADDAC
		private static uint smethod_8(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						57,
						118,
						8,
						117,
						27
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 49U) + 5U;
				string string_ = string.Concat(new string[]
				{
					"81 FE 00 00 01 00 7E 29 81 FE 00 10 FE 7F 7D 21 39 76 08 75 22 66 83 7E 0C 00 74 10 81 FF 00 00 01 00 7E 0D 81 FF 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000AFD98 File Offset: 0x000ADF98
		private static uint smethod_9(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						131,
						56,
						3,
						117,
						5
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 33U) + 10U;
				uint num5 = num2 - (num3 + 38U) + 5U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 07 3D 00 10 FE 7F 7C 0AFF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"83 C0 10 C3 83 38 030F 85",
					Class12.smethod_45(num4, 8, false, true),
					"E9",
					Class12.smethod_45(num5, 8, false, true)
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num6 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num6, ref num);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000AFFA4 File Offset: 0x000AE1A4
		private static uint smethod_10(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						133,
						192,
						116,
						23,
						131,
						56,
						6
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 84U) + 29U;
				string string_ = "85 C0 74 48 3D 00 00 01 00 7E 3B 3D 00 10 FE 7F 7D 34 83 38 06 75 35 8B 40 08 3D 00 00 01 00 7E 25 3D 00 10 FE 7F 7D 1E 8B 08 81 F9 00 00 01 00 7E 14 81 F9 00 10 FE 7F 7D 0C 66 83 79 0C 00 75 0B 33 C0 B0 01 C3FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "33 C0 C3E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					byte[] array4 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144
					};
					array4[1] = array3[0];
					array4[2] = array3[1];
					array4[3] = array3[2];
					array4[4] = array3[3];
					array = array4;
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000B0184 File Offset: 0x000AE384
		private static uint smethod_11(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 != 0U && gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				byte[] array2 = Class12.smethod_8("66 83 7E 0C 00", true);
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 49 08 8B 31", true);
				}
				byte[] array3 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array3, array3.Length, ref num);
				bool flag3 = array3[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						bool flag4 = array3[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = 58U;
				uint num5 = num2 - (num3 + num4) + 5U;
				uint num6 = num2 - (num3 + 100U) + 15U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 5C 81 F9 00 10 FE 7F 7D 54 8B 49 08 81 F9 00 00 01 00 7E 49 81 F9 00 10 FE 7F 7D 41 8B 31 81 FE 00 00 01 00 7E 37 81 FE 00 10 FE 7F 7D 2FE9",
					Class12.smethod_45(num5, 8, false, true),
					"81 FE 00 00 01 00 7E 22 81 FF 00 00 01 00 7E 1A 81 FE 00 10 FE 7F 7D 12 81 FF 00 10 FE 7F 7D 0A 66 83 7E 0C 00E9",
					Class12.smethod_45(num6, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"5E C3"
				});
				byte[] array4 = Class12.smethod_8(string_, false);
				int num7 = array4.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array4, num7, ref num);
				gstruct49_0.uint_21 += (uint)(num7 + 4);
				if (bool_0)
				{
					array4 = BitConverter.GetBytes(num3 - num2 - 5U);
					array = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3]
					};
					array4 = BitConverter.GetBytes(num3 + num4 - num2 - 15U);
					array2 = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + 10U, array2, array2.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000B03FC File Offset: 0x000AE5FC
		private static bool smethod_12(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 > 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						133,
						192
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[1] != 192;
				if (flag3)
				{
					result = false;
				}
				else
				{
					bool flag4 = array2[0] != 133 && array2[0] != 51;
					if (flag4)
					{
						result = false;
					}
					else
					{
						bool flag5 = !bool_0 || array2[0] != 133;
						if (flag5)
						{
							bool flag6 = !bool_0 && array2[0] == 51;
							if (flag6)
							{
								array2[0] = 133;
								Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array2, 1, ref num);
							}
						}
						else
						{
							array2[0] = 51;
							Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array2, 1, ref num);
						}
						result = true;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000B052C File Offset: 0x000AE72C
		private static uint smethod_13(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 != 0U && gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 4E 08 8B 11", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 98U) + 13U;
				string string_ = string.Concat(new string[]
				{
					"81 FE 00 00 01 00 7E 5A 81 FE 00 10 FE 7F 7D 52 8B 4E 08 81 F9 00 00 01 00 7E 47 81 F9 00 10 FE 7F 7D 3F 8B 11 81 FA 00 00 01 00 7E 35 81 FA 00 10 FE 7F 7D 2D 8B 0A 81 F9 00 00 01 00 7E 23 81 F9 00 10 FE 7F 7D 1B 8B 51 18 81 FA 00 00 01 00 7E 10 81 FA 00 10 FE 7F 7D 08 8B 04 82E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 5E C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000B0718 File Offset: 0x000AE918
		private static uint smethod_14(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 40 08 8B 48 04", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 95U) + 14U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 58 3D 00 10 FE 7F 7D 51 8B 40 08 3D 00 00 01 00 7E 47 3D 00 10 FE 7F 7D 40 8B 48 04 85 C9 74 3F 81 F9 00 00 01 00 7E 31 81 F9 00 10 FE 7F 7D 29 8B 10 81 FA 00 00 01 00 7E 1F 81 FA 00 10 FE 7F 7D 17 8B 12 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"83 C8 FF C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000B0908 File Offset: 0x000AEB08
		private static uint smethod_15(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U || gstruct49_0.uint_9 == 0U || gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 4C 24 04 8B 01", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 88U) + 5U;
				string string_ = "8B 4C 24 04 81 F9 00 00 01 00 7E 3E 81 F9 00 10 FE 7F 7D 36 8B 01 85 C0 74 1A 83 F8 04 75 14 8B 41 08 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 8B 40 04 C3 8B 49 08 81 F9 00 00 01 00 7E 0B 81 F9 00 10 FE 7F 7D 03 8B 01 C3 33 C0FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "C3E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000B0ADC File Offset: 0x000AECDC
		private static uint smethod_16(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 != 0U && gstruct49_0.uint_9 != 0U && gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 44 24 04 8B 10", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_9 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 45U) + 10U;
				string string_ = string.Concat(new string[]
				{
					"8B 44 24 04 8B 4C 24 08 3D 00 00 01 00 7E 1E 3D 00 10 FE 7F 7D 17 81 F9 00 00 01 00 7E 0F 81 F9 00 10 FE 7F 7D 07 8B 10E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 40 C3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000B0CD0 File Offset: 0x000AEED0
		private static uint smethod_17(GStruct49 gstruct49_0, uint uint_13, byte byte_0, bool bool_0)
		{
			bool flag = uint_13 == 0U;
			uint uint_14;
			if (flag)
			{
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				string text = Class12.smethod_45(byte_0, 2, false, false);
				int num = 0;
				byte[] array = Class12.smethod_8("55 8B EC 83 EC" + text, true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 27U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 13 81 F9 00 10 FE 7F 7D 0B 55 8B EC83 EC",
					text,
					"E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 C2 04 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000B0EE0 File Offset: 0x000AF0E0
		private static uint smethod_18(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						139,
						66,
						16,
						byte.MaxValue,
						208
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 51U) + 5U;
				string string_ = "81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09 58 5A 59FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000B10C8 File Offset: 0x000AF2C8
		private static uint smethod_19(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = new byte[]
					{
						139,
						17,
						139,
						200,
						139,
						66,
						16,
						byte.MaxValue,
						208
					};
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 71U) + 9U;
				string string_ = "81 F9 00 00 01 00 7E 31 81 F9 00 10 FE 7F 7D 29 8B 11 8B C8 81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09 58 5A 58FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					byte[] array4 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144,
						144,
						144
					};
					array4[1] = array3[0];
					array4[2] = array3[1];
					array4[3] = array3[2];
					array4[4] = array3[3];
					array = array4;
				}
				bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		private static uint smethod_20(GStruct49 gstruct49_0, uint uint_13, bool bool_0)
		{
			bool flag = uint_13 > 0U;
			uint uint_14;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[]
				{
					139,
					17,
					139,
					82,
					16
				};
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 58U) + 5U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 32 81 F9 00 10 FE 7F 7D 2A 8B 11 81 FA 00 00 01 00 7E 20 81 FA 00 10 FE 7F 7D 18 8B 52 10 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"83 C4 08 C2 04 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000B14AC File Offset: 0x000AF6AC
		private static uint smethod_21(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B 4D 08 8B 14 99", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 43U) + 6U;
				uint num5 = num2 - (num3 + 54U) - 26U;
				string string_ = string.Concat(new string[]
				{
					"8B 4D 08 81 F9 00 00 01 00 7E 20 81 F9 00 10 FE 7F 7D 18 8B 14 99 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"E9",
					Class12.smethod_45(num5, 8, false, true)
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num6 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num6, ref num);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000B16D4 File Offset: 0x000AF8D4
		private static uint smethod_22(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0)
		{
			bool flag = gstruct51_32.uint_0 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("8B F1 83 7E 04 03", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 25U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"81 FE 00 00 01 00 7E 11 81 FE 00 10 FE 7F 7D 09 83 7E 04 03E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"5EC3"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000B18D8 File Offset: 0x000AFAD8
		private static uint smethod_23(GStruct49 gstruct49_0, uint uint_13, bool bool_0)
		{
			bool flag = uint_13 > 0U;
			uint uint_14;
			if (flag)
			{
				int num = 0;
				byte[] array = Class12.smethod_8("8B 4F 20 8B 47 1C", true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 27U) + 6U;
				uint num5 = num2 - (num3 + 40U) + 32U;
				string string_ = string.Concat(new string[]
				{
					"81 FF 00 00 01 00 7E 13 81 FF 00 10 FE 7F 7D 0B 8B 4F 20 8B 47 1CE9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0E9",
					Class12.smethod_45(num5, 8, false, true)
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num6 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num6, ref num);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000B1AE4 File Offset: 0x000AFCE4
		private static uint smethod_24(GStruct49 gstruct49_0, uint uint_13, bool bool_0)
		{
			bool flag = uint_13 == 0U;
			uint uint_14;
			if (flag)
			{
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = Class12.smethod_8("8B 45 F8 8B 0C 82", true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 43U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"81 FA 00 00 01 00 7E 23 81 FA 00 10 FE 7F 7D 1B 8B 45 F8 8B 0C 82 81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"8B 45 FC 8B E5 5D C2 04 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000B1CD0 File Offset: 0x000AFED0
		private static uint smethod_25(GStruct49 gstruct49_0, uint uint_13, bool bool_0)
		{
			bool flag = uint_13 == 0U;
			uint uint_14;
			if (flag)
			{
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = Class12.smethod_8("8B 12 8B 42 10", true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 69U) + 7U;
				string string_ = "81 FA 00 00 01 00 7E 2F 81 FA 00 10 FE 7F 7D 27 8B 12 81 FA 00 00 01 00 7E 1D 81 FA 00 10 FE 7F 7D 15 8B 42 10 3D 00 00 01 00 7E 0B 3D 00 10 FE 7F 7D 04 FF D0 EB 09FF 05" + Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true) + "59 59 59E9" + Class12.smethod_45(num4, 8, false, true);
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3]
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000B1E98 File Offset: 0x000B0098
		private static uint smethod_26(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			uint[] array = new uint[]
			{
				246944U,
				247008U,
				744240U
			};
			int num = -1;
			for (;;)
			{
				int num2;
				byte[] array2;
				byte[] array3;
				uint num3;
				for (;;)
				{
					IL_1B:
					num++;
					bool flag = array.Length <= num;
					if (flag)
					{
						goto Block_1;
					}
					num2 = 0;
					array2 = Class12.smethod_8("55 8B EC 51 89 4D FC", true);
					array3 = new byte[array2.Length];
					num3 = gstruct49_0.uint_7 + array[num];
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, array3.Length, ref num2);
					bool flag2 = array3[0] != 233;
					if (flag2)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							bool flag3 = array3[i] == array2[i];
							if (!flag3)
							{
								goto IL_1B;
							}
						}
						break;
					}
					break;
				}
				gstruct49_0.uint_21 += 16U;
				uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num5 = num3 - (num4 + 28U) + 7U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 14 81 F9 00 10 FE 7F 7D 0C 55 8B EC 51 89 4D FCE9",
					Class12.smethod_45(num5, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"C3"
				});
				byte[] array4 = Class12.smethod_8(string_, false);
				int num6 = array4.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num6, ref num2);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num4 - num3 - 5U;
					array4 = BitConverter.GetBytes(value);
					byte[] array5 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144
					};
					array5[1] = array4[0];
					array5[2] = array4[1];
					array5[3] = array4[2];
					array5[4] = array4[3];
					array2 = array5;
				}
				bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num2);
				}
			}
			Block_1:
			return gstruct49_0.uint_21;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000B20B0 File Offset: 0x000B02B0
		private static uint smethod_27(GStruct49 gstruct49_0, uint uint_13, byte byte_0, bool bool_0 = true)
		{
			bool flag = uint_13 == 0U;
			uint uint_14;
			if (flag)
			{
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = Class12.smethod_8("55 8B EC 83 EC 0C 89 4D F4", true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 36U, array2, 1, ref num);
				bool flag2 = array2[0] == byte_0;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
					bool flag3 = array2[0] != 233;
					if (flag3)
					{
						for (int i = 0; i < array2.Length; i++)
						{
							bool flag4 = array2[i] != array[i];
							if (flag4)
							{
								return gstruct49_0.uint_21;
							}
						}
					}
					gstruct49_0.uint_21 += 16U;
					uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num4 = num2 - (num3 + 202U) + 5U;
					string string_ = string.Concat(new string[]
					{
						"55 8B EC 83 EC 0C 89 4D F4 8B 45 F4 3D 00 00 01 00 0F 8E 8A 00 00 00 3D 00 10 FE 7F 0F 8D 7F 0000 00 8B 48 04 81 F9 00 00 01 00 7E 74 81 F9 00 10 FE 7F 7D 6C 8B 51 04 89 55 F8 8B 45 F4 8B 4804 89 4D FC 8B 55 F8 81 FA 00 00 01 00 7E 52 81 FA 00 10 FE 7F 7D 4A0F BE 42",
						Class12.smethod_45(byte_0, 2, false, false),
						"85 C0 75 48 8B 4D F8 8B 55 08 81 FA 00 00 01 00 7E 34 81 FA 00 10 FE 7F 7D 2C 8B 41 0C 33 C9 3B02 0F 9C C1 0F B6 D1 85 D2 74 0B 8B 45 F8 8B 48 08 89 4D F8 EB 0E 8B 55 F8 89 55 FC 8B 45 F8 8B08 89 4D F8 EB A3FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"8B 45 FC 3D 00 00 01 00 7E 09 3D 00 10 FE 7F 7D 02 EB 05B8",
						Class12.smethod_45(gstruct49_0.uint_20 + 4U, 8, false, true),
						"8B E5 5D C2 04 00E9",
						Class12.smethod_45(num4, 8, false, true)
					});
					byte[] array3 = Class12.smethod_8(string_, false);
					int num5 = array3.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
					gstruct49_0.uint_21 += (uint)(num5 + 4);
					if (bool_0)
					{
						uint value = num3 - num2 - 5U;
						array3 = BitConverter.GetBytes(value);
						array = new byte[]
						{
							233,
							array3[0],
							array3[1],
							array3[2],
							array3[3],
							195
						};
					}
					bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
					if (flag5)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
					}
					uint_14 = gstruct49_0.uint_21;
				}
				else
				{
					uint_14 = gstruct49_0.uint_21;
				}
			}
			return uint_14;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000B22FC File Offset: 0x000B04FC
		private static uint smethod_28(GStruct49 gstruct49_0, GStruct51 gstruct51_32, bool bool_0 = true)
		{
			bool flag = gstruct51_32.uint_0 > 0U;
			uint uint_;
			if (flag)
			{
				int num = 0;
				byte[] array = gstruct51_32.byte_0;
				bool flag2 = array == null;
				if (flag2)
				{
					array = Class12.smethod_8("89 46 10 B8 01 00 00 00", true);
				}
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + gstruct51_32.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag3 = array2[0] != 233;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = array2[i] != array[i];
						if (flag4)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num4 = num2 - (num3 + 27U) + 8U;
				string string_ = string.Concat(new string[]
				{
					"81 FE 00 00 01 00 7E 13 81 FE 00 10 FE 7F 7D 0B 89 46 10 33 C0 40E9",
					Class12.smethod_45(num4, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"5E C2 08 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num5 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array3, num5, ref num);
				gstruct49_0.uint_21 += (uint)(num5 + 4);
				if (bool_0)
				{
					uint value = num3 - num2 - 5U;
					array3 = BitConverter.GetBytes(value);
					byte[] array4 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144,
						144
					};
					array4[1] = array3[0];
					array4[2] = array3[1];
					array4[3] = array3[2];
					array4[4] = array3[3];
					array = array4;
				}
				bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
				}
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x000B2508 File Offset: 0x000B0708
		private static uint smethod_29(GStruct49 gstruct49_0, uint uint_13, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 != 0U && uint_13 > 0U;
			uint uint_14;
			if (flag)
			{
				int num = 0;
				uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_147.uint_0;
				byte[] array = Class12.smethod_8("8B 0D" + Class12.smethod_45(num2, 8, false, true), true);
				byte[] array2 = Class12.smethod_8("8B 15" + Class12.smethod_45(num2, 8, false, true), true);
				byte[] array3 = new byte[array.Length];
				uint num3 = gstruct49_0.uint_7 + uint_13;
				uint num4 = num3 + 11U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, array3.Length, ref num);
				bool flag2 = array3[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array3.Length; i++)
					{
						bool flag3 = array3[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num5 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num6 = num5 + 27U;
				uint num7 = num3 - (num5 + 27U) + 6U;
				uint num8 = num4 - (num6 + 27U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"8B 0D",
					Class12.smethod_45(num2, 8, false, true),
					"81 F9 00 00 01 00 7E 28 81 F9 00 10 FE 7F 7D 20E9",
					Class12.smethod_45(num7, 8, false, true),
					"8B 15",
					Class12.smethod_45(num2, 8, false, true),
					"81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num8, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 8B 4D F4 64 89 0D 00 00 00 00 59 8B E5 5D C3"
				});
				byte[] array4 = Class12.smethod_8(string_, false);
				int num9 = array4.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num5, array4, num9, ref num);
				gstruct49_0.uint_21 += (uint)(num9 + 4);
				if (bool_0)
				{
					array4 = BitConverter.GetBytes(num5 - (num3 + 5U));
					array = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
					array4 = BitConverter.GetBytes(num6 - (num4 + 5U));
					array2 = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
				}
				bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array, array.Length, ref num);
					Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array2, array2.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000B2810 File Offset: 0x000B0A10
		private static uint smethod_30(GStruct49 gstruct49_0, uint uint_13, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 != 0U && uint_13 > 0U;
			uint uint_14;
			if (flag)
			{
				int num = 0;
				string text = "8B 91";
				byte[] array = Class12.smethod_8(text, true);
				byte[] array2 = new byte[4];
				byte[] array3 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array3, array3.Length, ref num);
				bool flag2 = array3[0] == 233;
				uint num3;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 1U, array2, array2.Length, ref num);
					num3 = BitConverter.ToUInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + num2 + 5U + 18U, array2, array2.Length, ref num);
				}
				else
				{
					for (int i = 0; i < array3.Length; i++)
					{
						bool flag3 = array3[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 2U, array2, array2.Length, ref num);
				}
				num3 = BitConverter.ToUInt32(array2, 0);
				gstruct49_0.uint_21 += 16U;
				uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num5 = num2 - (num4 + 74U) + 9U;
				string string_ = string.Concat(new string[]
				{
					"81 F9 00 00 01 00 7E 35 81 F9 00 10 FE 7F 7D 2D",
					text,
					Class12.smethod_45(num3, 8, false, true),
					"81 FA 00 00 01 00 7E 1F 81 FA 00 10 FE 7F 7D 17 8B 04 82 85 C0 74 18 3D 00 00 01 00 7E 09 3D 00 10 FE 7F 7D 02 EB 08 33 C0FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"E9",
					Class12.smethod_45(num5, 8, false, true)
				});
				byte[] array4 = Class12.smethod_8(string_, false);
				int num6 = array4.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num6, ref num);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				bool flag4 = !bool_0;
				if (flag4)
				{
					array2 = Class12.smethod_8(text + Class12.smethod_45(num3, 8, false, true), true);
				}
				else
				{
					uint value = num4 - num2 - 5U;
					array4 = BitConverter.GetBytes(value);
					array2 = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
				}
				bool flag5 = num3 != 0U && ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233));
				if (flag5)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000B2AC4 File Offset: 0x000B0CC4
		private static uint smethod_31(GStruct49 gstruct49_0, uint uint_13, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 != 0U && uint_13 > 0U;
			uint uint_14;
			if (flag)
			{
				int num = 0;
				string text = "8B 88";
				byte[] array = Class12.smethod_8(text, true);
				byte[] array2 = new byte[4];
				byte[] array3 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array3, array3.Length, ref num);
				bool flag2 = array3[0] == 233;
				uint num3;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 1U, array2, array2.Length, ref num);
					num3 = BitConverter.ToUInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + num2 + 5U + 16U, array2, array2.Length, ref num);
				}
				else
				{
					for (int i = 0; i < array3.Length; i++)
					{
						bool flag3 = array3[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 2U, array2, array2.Length, ref num);
				}
				num3 = BitConverter.ToUInt32(array2, 0);
				gstruct49_0.uint_21 += 16U;
				uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num5 = num2 - (num4 + 41U) + 6U;
				uint num6 = num2 - (num4 + 57U) - 25U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 22 3D 00 10 FE 7F 7D 1B",
					text,
					Class12.smethod_45(num3, 8, false, true),
					"81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num5, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"33 C0 89 45 F4E9",
					Class12.smethod_45(num6, 8, false, true)
				});
				byte[] array4 = Class12.smethod_8(string_, false);
				int num7 = array4.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num7, ref num);
				gstruct49_0.uint_21 += (uint)(num7 + 4);
				if (bool_0)
				{
					uint value = num4 - num2 - 5U;
					array4 = BitConverter.GetBytes(value);
					array2 = new byte[]
					{
						233,
						array4[0],
						array4[1],
						array4[2],
						array4[3],
						144
					};
				}
				else
				{
					array2 = Class12.smethod_8(text + Class12.smethod_45(num3, 8, false, true), true);
				}
				bool flag4 = num3 != 0U && ((!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233));
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				}
				uint_14 = gstruct49_0.uint_21;
			}
			else
			{
				uint_14 = gstruct49_0.uint_21;
			}
			return uint_14;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000B2D9C File Offset: 0x000B0F9C
		private static uint smethod_32(GStruct49 gstruct49_0, uint uint_13, uint uint_14, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 == 0U || uint_13 == 0U;
			uint uint_15;
			if (flag)
			{
				uint_15 = gstruct49_0.uint_21;
			}
			else
			{
				int num = 0;
				byte[] array = Class12.smethod_8("7D 19 8B 45 F4", true);
				byte[] array2 = new byte[array.Length];
				uint num2 = gstruct49_0.uint_7 + uint_13;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				byte[] array3 = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + 7U, array3, 4, ref num);
				bool flag4 = (long)BitConverter.ToInt32(array3, 0) != (long)((ulong)uint_14);
				if (flag4)
				{
					uint_15 = gstruct49_0.uint_21;
				}
				else
				{
					gstruct49_0.uint_21 += 16U;
					uint num3 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num4 = num2 - (num3 + 74U) + 25U;
					uint num5 = num2 - (num3 + 85U) + 27U;
					string string_ = string.Concat(new string[]
					{
						"7D 4E 8B 45 F4 3D 00 00 01 00 7E 3E 3D 00 10 FE 7F 7D 378B 88",
						Class12.smethod_45(uint_14, 8, false, true),
						"81 F9 00 00 01 00 7E 29 81 F9 00 10 FE 7F 7D 21 8B 55 F8 8B 04 91 3D 00 00 01 00 7E 14 3D 00 10 FE 7F 7D 0D 8B 4D FC 03 08 89 4D FCE9",
						Class12.smethod_45(num4, 8, false, true),
						"FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"E9",
						Class12.smethod_45(num5, 8, false, true)
					});
					byte[] array4 = Class12.smethod_8(string_, false);
					int num6 = array4.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array4, num6, ref num);
					gstruct49_0.uint_21 += (uint)(num6 + 4);
					if (bool_0)
					{
						uint value = num3 - num2 - 5U;
						array4 = BitConverter.GetBytes(value);
						array = new byte[]
						{
							233,
							array4[0],
							array4[1],
							array4[2],
							array4[3]
						};
					}
					bool flag5 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
					if (flag5)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num);
					}
					uint_15 = gstruct49_0.uint_21;
				}
			}
			return uint_15;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000B3000 File Offset: 0x000B1200
		private static uint smethod_33(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint[] array = new uint[]
				{
					5664480U,
					5675472U
				};
				int num = 0;
				int num2 = 0;
				string text = "A1" + Class12.smethod_45(Class53.gstruct51_11.uint_0, 8, false, true);
				string text2 = "8B 15" + Class12.smethod_45(Class53.gstruct51_14.uint_0, 8, false, true);
				while (array.Length > num2)
				{
					gstruct49_0.uint_21 += 16U;
					byte[] array2 = Class12.smethod_8(text, true);
					byte[] array3 = new byte[array2.Length];
					uint num3 = gstruct49_0.uint_7 + (array[num2] - 4194304U);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, array3.Length, ref num);
					bool flag2 = array3[0] != 233;
					if (flag2)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							bool flag3 = array3[i] == array2[i];
							if (!flag3)
							{
								goto IL_251;
							}
						}
						goto IL_116;
					}
					goto IL_116;
					IL_251:
					num2++;
					continue;
					IL_116:
					uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num5 = num3 - (num4 + 46U) + 11U;
					string string_ = string.Concat(new string[]
					{
						text,
						"3D 00 00 01 00 7E 22 3D 00 10 FE 7F 7D 1B",
						text2,
						"81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
						Class12.smethod_45(num5, 8, false, true),
						"FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"C2 04 00"
					});
					byte[] array4 = Class12.smethod_8(string_, false);
					int num6 = array4.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num6, ref num);
					gstruct49_0.uint_21 += (uint)(num6 + 4);
					if (bool_0)
					{
						uint value = num4 - num3 - 5U;
						array4 = BitConverter.GetBytes(value);
						array2 = new byte[]
						{
							233,
							array4[0],
							array4[1],
							array4[2],
							array4[3]
						};
					}
					bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
					if (flag4)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num);
						goto IL_251;
					}
					goto IL_251;
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000B3280 File Offset: 0x000B1480
		private static uint smethod_34(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				uint[] array = new uint[]
				{
					5775311U,
					5775344U
				};
				int num = 0;
				int num2 = 0;
				while (array.Length > num2)
				{
					gstruct49_0.uint_21 += 16U;
					byte[] array2 = Class12.smethod_8("B8 01000000", true);
					byte[] array3 = new byte[array2.Length];
					uint num3 = gstruct49_0.uint_7 + (array[num2] - 4194304U);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, array3.Length, ref num);
					bool flag2 = array3[0] != 233;
					if (flag2)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							bool flag3 = array3[i] == array2[i];
							if (!flag3)
							{
								goto IL_1F3;
							}
						}
						goto IL_CA;
					}
					goto IL_CA;
					IL_1F3:
					num2++;
					continue;
					IL_CA:
					uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num5 = num3 - (num4 + 23U) + 5U;
					string string_ = string.Concat(new string[]
					{
						"33 C0 40 81 F9 00 00 01 00 7E 0C 81 F9 00 10 FE 7F0F 8C",
						Class12.smethod_45(num5, 8, false, true),
						"FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"33 C0 C3"
					});
					byte[] array4 = Class12.smethod_8(string_, false);
					int num6 = array4.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num6, ref num);
					gstruct49_0.uint_21 += (uint)(num6 + 4);
					if (bool_0)
					{
						uint value = num4 - num3 - 5U;
						array4 = BitConverter.GetBytes(value);
						array2 = new byte[]
						{
							233,
							array4[0],
							array4[1],
							array4[2],
							array4[3]
						};
					}
					bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
					if (flag4)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num);
						goto IL_1F3;
					}
					goto IL_1F3;
				}
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000B34AC File Offset: 0x000B16AC
		private static uint smethod_35(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint num = 5674078U;
				int num2 = 0;
				byte[] array = Class12.smethod_8("8B 48 08 89 4C 24 10", true);
				byte[] array2 = new byte[array.Length];
				uint num3 = gstruct49_0.uint_7 + (num - 4194304U);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num2);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num5 = num3 - (num4 + 26U) + 7U;
				uint num6 = num3 - (num4 + 37U) + 31U;
				string string_ = string.Concat(new string[]
				{
					"3D 00 00 01 00 7E 13 3D 00 10 FE 7F 7D 0C 8B 48 08 89 4C 24 10E9",
					Class12.smethod_45(num5, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"E9",
					Class12.smethod_45(num6, 8, false, true)
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num7 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array3, num7, ref num2);
				gstruct49_0.uint_21 += (uint)(num7 + 4);
				if (bool_0)
				{
					uint value = num4 - num3 - 5U;
					array3 = BitConverter.GetBytes(value);
					byte[] array4 = new byte[]
					{
						233,
						0,
						0,
						0,
						0,
						144,
						144
					};
					array4[1] = array3[0];
					array4[2] = array3[1];
					array4[3] = array3[2];
					array4[4] = array3[3];
					array = array4;
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array, array.Length, ref num2);
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000B36D0 File Offset: 0x000B18D0
		private static uint smethod_36(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 > 0U;
			uint uint_;
			if (flag)
			{
				uint[] array = new uint[]
				{
					5722133U,
					5985340U,
					6196267U,
					6197195U
				};
				int num = 0;
				int num2 = 0;
				while (array.Length > num2)
				{
					gstruct49_0.uint_21 += 16U;
					byte[] array2 = Class12.smethod_8("8B 07 8B 10 6A 01", true);
					byte[] array3 = new byte[array2.Length];
					uint num3 = gstruct49_0.uint_7 + (array[num2] - 4194304U);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array3, array3.Length, ref num);
					bool flag2 = array3[0] != 233;
					if (flag2)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							bool flag3 = array3[i] == array2[i];
							if (!flag3)
							{
								goto IL_215;
							}
						}
						goto IL_C5;
					}
					goto IL_C5;
					IL_215:
					num2++;
					continue;
					IL_C5:
					uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num5 = num3 - (num4 + 57U) + 6U;
					uint num6 = num3 - (num4 + 70U) + 10U;
					string string_ = string.Concat(new string[]
					{
						"81 FF 00 00 01 00 7E 31 81 FF 00 10 FE 7F 7D 29 8B 07 3D 00 00 01 00 7E 20 3D 00 10 FE 7F 7D 19 8B 10 81 FA 00 00 01 00 7E 0F 81 FA 00 10 FE 7F 7D 07 6A 01E9",
						Class12.smethod_45(num5, 8, false, true),
						"FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"33 DBE9",
						Class12.smethod_45(num6, 8, false, true)
					});
					byte[] array4 = Class12.smethod_8(string_, false);
					int num7 = array4.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array4, num7, ref num);
					gstruct49_0.uint_21 += (uint)(num7 + 4);
					if (bool_0)
					{
						uint value = num4 - num3 - 5U;
						array4 = BitConverter.GetBytes(value);
						array2 = new byte[]
						{
							233,
							array4[0],
							array4[1],
							array4[2],
							array4[3],
							144
						};
					}
					bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
					if (flag4)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num);
						goto IL_215;
					}
					goto IL_215;
				}
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000B3920 File Offset: 0x000B1B20
		private static uint smethod_37(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint num = 6280975U;
				int num2 = 0;
				byte[] array = Class12.smethod_8("8B 45 08 8B 0C 98", true);
				byte[] array2 = new byte[array.Length];
				uint num3 = gstruct49_0.uint_7 + (num - 4194304U);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num2);
				bool flag2 = array2[0] != 233;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag3 = array2[i] != array[i];
						if (flag3)
						{
							return gstruct49_0.uint_21;
						}
					}
				}
				gstruct49_0.uint_21 += 16U;
				uint num4 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
				uint num5 = num3 - (num4 + 41U) + 6U;
				string string_ = string.Concat(new string[]
				{
					"8B 45 08 3D 00 00 01 00 7E 1F 3D 00 10 FE 7F 7D 18 8B 0C 98 81 F9 00 00 01 00 7E 0D 81 F9 00 10 FE 7F 7D 05E9",
					Class12.smethod_45(num5, 8, false, true),
					"FF 05",
					Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
					"59 5F 5E 5B 8B E5 5D C2 20 00"
				});
				byte[] array3 = Class12.smethod_8(string_, false);
				int num6 = array3.Length;
				Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array3, num6, ref num2);
				gstruct49_0.uint_21 += (uint)(num6 + 4);
				if (bool_0)
				{
					uint value = num4 - num3 - 5U;
					array3 = BitConverter.GetBytes(value);
					array = new byte[]
					{
						233,
						array3[0],
						array3[1],
						array3[2],
						array3[3],
						144
					};
				}
				bool flag4 = (!bool_0 && array2[0] == 233) || (bool_0 && array2[0] != 233);
				if (flag4)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array, array.Length, ref num2);
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000B3B20 File Offset: 0x000B1D20
		private static uint smethod_38(GStruct49 gstruct49_0, bool bool_0 = true)
		{
			bool flag = gstruct49_0.uint_20 == 0U;
			uint uint_;
			if (flag)
			{
				uint_ = gstruct49_0.uint_21;
			}
			else
			{
				uint[] array = new uint[]
				{
					4392027U,
					4419851U
				};
				int num = 0;
				while (array.Length > num)
				{
					uint num2 = array[num];
					int num3 = 0;
					byte[] array2 = Class12.smethod_8("8B 0C 88 8B 55 F8", true);
					byte[] array3 = new byte[array2.Length];
					uint num4 = gstruct49_0.uint_7 + (num2 - 4194304U);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4, array3, array3.Length, ref num3);
					bool flag2 = array3[0] != 233;
					if (flag2)
					{
						for (int i = 0; i < array3.Length; i++)
						{
							bool flag3 = array3[i] == array2[i];
							if (!flag3)
							{
								goto IL_208;
							}
						}
						goto IL_CA;
					}
					goto IL_CA;
					IL_208:
					num++;
					continue;
					IL_CA:
					gstruct49_0.uint_21 += 16U;
					uint num5 = gstruct49_0.uint_20 + gstruct49_0.uint_21;
					uint num6 = num4 - (num5 + 57U) + 6U;
					string string_ = string.Concat(new string[]
					{
						"3D 00 00 01 00 7E 32 3D 00 10 FE 7F 7D 2B 8B 0C 88 81 F9 00 00 01 00 7E 20 81 F9 00 10 FE 7F 7D 18 8B 55 F8 81 FA 00 00 01 00 7E 0D 81 FA 00 10 FE 7F 7D 05E9",
						Class12.smethod_45(num6, 8, false, true),
						"FF 05",
						Class12.smethod_45(gstruct49_0.uint_20 + Class66.uint_0, 8, false, true),
						"8B E5 5D C2 04 00"
					});
					byte[] array4 = Class12.smethod_8(string_, false);
					int num7 = array4.Length;
					Class22.WriteProcessMemory(gstruct49_0.int_137, num5, array4, num7, ref num3);
					gstruct49_0.uint_21 += (uint)(num7 + 4);
					if (bool_0)
					{
						uint value = num5 - num4 - 5U;
						array4 = BitConverter.GetBytes(value);
						array2 = new byte[]
						{
							233,
							array4[0],
							array4[1],
							array4[2],
							array4[3],
							144
						};
					}
					bool flag4 = (!bool_0 && array3[0] == 233) || (bool_0 && array3[0] != 233);
					if (flag4)
					{
						Class22.WriteProcessMemory(gstruct49_0.int_137, num4, array2, array2.Length, ref num3);
						goto IL_208;
					}
					goto IL_208;
				}
				uint_ = gstruct49_0.uint_21;
			}
			return uint_;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000B3D58 File Offset: 0x000B1F58
		public static void smethod_39()
		{
			int num = Class66.int_1;
			Class66.int_1 = 0;
			bool flag = num > 0;
			if (flag)
			{
				int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
				bool flag2 = 0 <= num2;
				if (flag2)
				{
					Class66.smethod_44(Form1.gstruct49_0[num2]);
				}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000B3DA4 File Offset: 0x000B1FA4
		private static uint smethod_40(GStruct49 gstruct49_0, string string_0 = "lualibdll.dll")
		{
			uint result = 0U;
			try
			{
				string fileName = gstruct49_0.process_0.MainModule.FileName;
				string string_ = Class12.smethod_14(fileName, '\\')[0] + "\\" + string_0;
				string string_2 = Class12.smethod_7(string_);
				result = Class12.smethod_6(string_2);
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000B3E0C File Offset: 0x000B200C
		private static GStruct51[] smethod_41()
		{
			return new GStruct51[]
			{
				Class66.gstruct51_3,
				Class66.gstruct51_4,
				Class66.gstruct51_5,
				Class66.gstruct51_6,
				Class66.gstruct51_7,
				Class66.gstruct51_8,
				Class66.gstruct51_9,
				Class66.gstruct51_10,
				Class66.gstruct51_11,
				Class66.gstruct51_12,
				Class66.gstruct51_13,
				Class66.gstruct51_14,
				Class66.gstruct51_15
			};
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		private static GStruct51[] smethod_42()
		{
			return new GStruct51[]
			{
				Class66.gstruct51_1
			};
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000B3EEC File Offset: 0x000B20EC
		private static GStruct51[] smethod_43()
		{
			return new GStruct51[]
			{
				Class66.gstruct51_2
			};
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000B3F10 File Offset: 0x000B2110
		public static uint smethod_44(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_20 == 0U;
			uint result;
			if (flag)
			{
				result = 1U;
			}
			else
			{
				int num = 0;
				bool flag2 = gstruct49_0.uint_7 == 0U;
				if (flag2)
				{
					gstruct49_0.uint_7 = 4194304U;
				}
				bool flag3 = gstruct49_0.uint_8 == 0U;
				if (flag3)
				{
					gstruct49_0.uint_8 = Class22.smethod_37(gstruct49_0.int_136, "engine.dll");
				}
				bool flag4 = gstruct49_0.uint_9 == 0U;
				if (flag4)
				{
					gstruct49_0.uint_9 = Class22.smethod_37(gstruct49_0.int_136, "lualibdll.dll");
				}
				bool flag5 = gstruct49_0.uint_10 == 0U;
				if (flag5)
				{
					gstruct49_0.uint_10 = Class22.smethod_37(gstruct49_0.int_136, "rainbow.dll");
				}
				bool flag6 = gstruct49_0.uint_12 == 0U;
				if (flag6)
				{
					uint num2 = Class22.smethod_37(gstruct49_0.int_136, "kernel32.dll");
					gstruct49_0.uint_12 = Class22.GetProcAddress(num2, "ReadProcessMemory");
				}
				bool flag7 = gstruct49_0.uint_13 == 0U;
				if (flag7)
				{
					uint num3 = Class22.smethod_37(gstruct49_0.int_136, "ntdll.dll");
					gstruct49_0.uint_13 = Class22.GetProcAddress(num3, "ZwReadVirtualMemory");
				}
				int num4 = 0;
				int num5 = 0;
				uint num6 = 0U;
				for (;;)
				{
					bool flag8 = true;
					bool flag9 = Class66.uint_10 != 0U || num5 > 0;
					if (flag9)
					{
						bool flag10 = num6 == 0U;
						if (flag10)
						{
							num6 = Class66.smethod_40(gstruct49_0, "lualibdll.dll");
						}
						bool flag11 = true;
						GStruct51[] array = Class66.smethod_41();
						for (int i = 0; i < array.Length; i++)
						{
							bool flag12 = array[i].uint_0 == 0U;
							if (flag12)
							{
								flag11 = false;
								break;
							}
						}
						bool flag13 = flag11;
						if (flag13)
						{
							flag8 = (Class66.uint_10 != num6 && num5 <= 0);
						}
					}
					bool flag14 = !flag8 || num5 > 1;
					if (flag14)
					{
						break;
					}
					bool flag15 = Class66.int_2 <= 0 || num4 >= 10;
					if (flag15)
					{
						Class66.int_2 = 1;
						uint[] array2 = Class22.smethod_66(gstruct49_0.int_137, gstruct49_0.uint_9, ".text");
						byte[] array3 = new byte[array2[0]];
						Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_9 + array2[1], array3, array3.Length, ref num);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_3, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_4, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_5, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_6, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_7, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_8, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_9, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_10, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_11, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_12, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_13, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_14, 0L, 0U, 0, true);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_15, 0L, 0U, 0, true);
						Thread.Sleep(300);
						Class66.int_2 = 0;
						num5++;
					}
					else
					{
						num4++;
						Thread.Sleep(Class66.random_0.Next(10, 200) + 100);
					}
				}
				bool flag16 = num5 == 1;
				if (flag16)
				{
					Class66.uint_10 = num6;
				}
				num4 = 0;
				num5 = 0;
				num6 = 0U;
				for (;;)
				{
					bool flag17 = true;
					bool flag18 = Class66.uint_11 != 0U || num5 > 0;
					if (flag18)
					{
						bool flag19 = num6 == 0U;
						if (flag19)
						{
							num6 = Class66.smethod_40(gstruct49_0, "rainbow.dll");
						}
						bool flag20 = true;
						GStruct51[] array4 = Class66.smethod_42();
						for (int j = 0; j < array4.Length; j++)
						{
							bool flag21 = array4[j].uint_0 == 0U;
							if (flag21)
							{
								flag20 = false;
								break;
							}
						}
						bool flag22 = flag20;
						if (flag22)
						{
							flag17 = (Class66.uint_11 != num6 && num5 <= 0);
						}
					}
					bool flag23 = !flag17 || num5 > 1;
					if (flag23)
					{
						break;
					}
					bool flag24 = Class66.int_3 <= 0 || num4 >= 10;
					if (flag24)
					{
						Class66.int_3 = 1;
						uint[] array2 = Class22.smethod_66(gstruct49_0.int_137, gstruct49_0.uint_10, ".text");
						byte[] array3 = new byte[array2[0]];
						Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_10 + array2[1], array3, array3.Length, ref num);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_1, 0L, 0U, 0, true);
						Thread.Sleep(200);
						Class66.int_3 = 0;
						num5++;
					}
					else
					{
						num4++;
						Thread.Sleep(Class66.random_0.Next(10, 200) + 100);
					}
				}
				bool flag25 = num5 == 1;
				if (flag25)
				{
					Class66.uint_11 = num6;
				}
				num4 = 0;
				num5 = 0;
				num6 = 0U;
				for (;;)
				{
					bool flag26 = true;
					bool flag27 = Class66.uint_12 != 0U || num5 > 0;
					if (flag27)
					{
						bool flag28 = num6 == 0U;
						if (flag28)
						{
							num6 = Class66.smethod_40(gstruct49_0, "msvcr80.dll");
						}
						bool flag29 = true;
						GStruct51[] array5 = Class66.smethod_43();
						for (int k = 0; k < array5.Length; k++)
						{
							bool flag30 = array5[k].uint_0 == 0U;
							if (flag30)
							{
								flag29 = false;
								break;
							}
						}
						bool flag31 = flag29;
						if (flag31)
						{
							flag26 = (Class66.uint_12 != num6 && num5 <= 0);
						}
					}
					bool flag32 = !flag26 || num5 > 1;
					if (flag32)
					{
						break;
					}
					bool flag33 = Class66.int_4 <= 0 || num4 >= 10;
					if (flag33)
					{
						Class66.int_4 = 1;
						uint[] array2 = Class22.smethod_66(gstruct49_0.int_137, gstruct49_0.uint_11, ".text");
						byte[] array3 = new byte[array2[0]];
						Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_11 + array2[1], array3, array3.Length, ref num);
						Class102.smethod_4(array2[1], array3, ref Class66.gstruct51_2, 0L, 0U, 0, true);
						Thread.Sleep(100);
						Class66.int_4 = 0;
						num5++;
					}
					else
					{
						num4++;
						Thread.Sleep(Class66.random_0.Next(10, 200) + 100);
					}
				}
				bool flag34 = num5 == 1;
				if (flag34)
				{
					Class66.uint_12 = num6;
				}
				gstruct49_0.uint_21 = 32U;
				bool bool_ = Class66.int_0 > 0;
				byte[] bytes = BitConverter.GetBytes(gstruct49_0.uint_12);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_20 + 4U, bytes, 4, ref num);
				bytes = BitConverter.GetBytes(gstruct49_0.uint_13);
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_20 + 8U, bytes, 4, ref num);
				Class66.smethod_0(gstruct49_0, true);
				gstruct49_0.uint_21 = Class66.smethod_1(gstruct49_0, Class66.gstruct51_2, true);
				gstruct49_0.uint_21 = Class66.smethod_2(gstruct49_0, Class66.gstruct51_0, true);
				gstruct49_0.uint_21 = Class66.smethod_3(gstruct49_0, Class66.gstruct51_1, true);
				gstruct49_0.uint_21 = Class66.smethod_4(gstruct49_0, Class66.gstruct51_3, true);
				gstruct49_0.uint_21 = Class66.smethod_5(gstruct49_0, Class66.gstruct51_4, true);
				gstruct49_0.uint_21 = Class66.smethod_6(gstruct49_0, Class66.gstruct51_5, true);
				gstruct49_0.uint_21 = Class66.smethod_7(gstruct49_0, Class66.gstruct51_6, true);
				gstruct49_0.uint_21 = Class66.smethod_8(gstruct49_0, Class66.gstruct51_7, true);
				gstruct49_0.uint_21 = Class66.smethod_9(gstruct49_0, Class66.gstruct51_8, true);
				gstruct49_0.uint_21 = Class66.smethod_10(gstruct49_0, Class66.gstruct51_9, true);
				gstruct49_0.uint_21 = Class66.smethod_11(gstruct49_0, Class66.gstruct51_10, true);
				Class66.smethod_12(gstruct49_0, Class66.gstruct51_11, true);
				gstruct49_0.uint_21 = Class66.smethod_13(gstruct49_0, Class66.gstruct51_12, true);
				gstruct49_0.uint_21 = Class66.smethod_14(gstruct49_0, Class66.gstruct51_13, true);
				gstruct49_0.uint_21 = Class66.smethod_15(gstruct49_0, Class66.gstruct51_14, true);
				gstruct49_0.uint_21 = Class66.smethod_16(gstruct49_0, Class66.gstruct51_15, true);
				gstruct49_0.uint_21 = Class66.smethod_18(gstruct49_0, Class66.gstruct51_18, bool_);
				gstruct49_0.uint_21 = Class66.smethod_19(gstruct49_0, Class66.gstruct51_19, bool_);
				for (int l = 0; l < Class66.uint_2.GetLength(0); l++)
				{
					gstruct49_0.uint_21 = Class66.smethod_20(gstruct49_0, Class66.uint_2[l] - 4194304U, bool_);
				}
				gstruct49_0.uint_21 = Class66.smethod_21(gstruct49_0, Class66.gstruct51_21, bool_);
				gstruct49_0.uint_21 = Class66.smethod_22(gstruct49_0, Class66.gstruct51_22, bool_);
				for (int m = 0; m < Class66.uint_3.GetLength(0); m++)
				{
					gstruct49_0.uint_21 = Class66.smethod_23(gstruct49_0, Class66.uint_3[m] - 4194304U, bool_);
				}
				gstruct49_0.uint_21 = Class66.smethod_28(gstruct49_0, Class66.gstruct51_27, bool_);
				for (int n = 0; n < Class66.uint_4.GetLength(0); n++)
				{
					gstruct49_0.uint_21 = Class66.smethod_24(gstruct49_0, Class66.uint_4[n] - 4194304U, bool_);
				}
				for (int num7 = 0; num7 < Class66.uint_5.GetLength(0); num7++)
				{
					gstruct49_0.uint_21 = Class66.smethod_25(gstruct49_0, Class66.uint_5[num7] - 4194304U, bool_);
				}
				gstruct49_0.uint_21 = Class66.smethod_26(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_29(gstruct49_0, Class66.uint_6 - 4194304U, bool_);
				for (int num8 = 0; num8 < Class66.uint_7.Length; num8++)
				{
					gstruct49_0.uint_21 = Class66.smethod_30(gstruct49_0, Class66.uint_7[num8] - 4194304U, bool_);
				}
				for (int num9 = 0; num9 < Class66.uint_8.Length; num9++)
				{
					gstruct49_0.uint_21 = Class66.smethod_31(gstruct49_0, Class66.uint_8[num9] - 4194304U, bool_);
				}
				for (int num10 = 0; num10 < Class66.uint_9.GetLength(0); num10++)
				{
					gstruct49_0.uint_21 = Class66.smethod_32(gstruct49_0, Class66.uint_9[num10, 0] - 4194304U, Class66.uint_9[num10, 1], bool_);
				}
				gstruct49_0.uint_21 = Class66.smethod_17(gstruct49_0, Class66.gstruct51_25.uint_0, 8, bool_);
				gstruct49_0.uint_21 = Class66.smethod_17(gstruct49_0, Class66.gstruct51_26.uint_0, 8, bool_);
				gstruct49_0.uint_21 = Class66.smethod_17(gstruct49_0, Class66.gstruct51_16.uint_0, 12, bool_);
				gstruct49_0.uint_21 = Class66.smethod_17(gstruct49_0, Class66.gstruct51_17.uint_0, 12, bool_);
				for (int num11 = 0; num11 < Class66.uint_1.GetLength(0); num11++)
				{
					gstruct49_0.uint_21 = Class66.smethod_27(gstruct49_0, Class66.uint_1[num11, 0] - 4194304U, (byte)Class66.uint_1[num11, 1], bool_);
				}
				gstruct49_0.uint_21 = Class66.smethod_33(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_34(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_35(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_36(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_37(gstruct49_0, bool_);
				gstruct49_0.uint_21 = Class66.smethod_38(gstruct49_0, bool_);
				result = 1U;
			}
			return result;
		}

		// Token: 0x04000303 RID: 771
		public static int int_0 = Class62.smethod_3("fixgCash", 0, "0");

		// Token: 0x04000304 RID: 772
		public static uint uint_0 = 12U;

		// Token: 0x04000305 RID: 773
		public static GStruct51 gstruct51_0 = new GStruct51
		{
			string_0 = "ENGINE_DISABLE_CASH_1",
			string_1 = "8B ?? ?? ?? ?? ?? ?? ?? ?? 33 C0 59 C3 57 8B",
			byte_0 = Class12.smethod_8("80 38 00 75 04", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 4
		};

		// Token: 0x04000306 RID: 774
		public static GStruct51 gstruct51_1 = new GStruct51
		{
			string_0 = "RAINBOW_CASH_1",
			string_1 = "3B 48 38 72 04",
			byte_0 = Class12.smethod_8("8B 45 FC 8B 4D 08", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x04000307 RID: 775
		public static GStruct51 gstruct51_2 = new GStruct51
		{
			string_0 = "MSVCR80_CASH_2",
			string_1 = "40 3B CE 75 F5",
			byte_0 = Class12.smethod_8("80 38 00 74 05", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x04000308 RID: 776
		public static GStruct51 gstruct51_3 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_1",
			string_1 = "3C 3D 56 57 75",
			byte_0 = Class12.smethod_8("53 8B 5C 24 0C", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};

		// Token: 0x04000309 RID: 777
		public static GStruct51 gstruct51_4 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_2",
			string_1 = "83 F9 06 77 ?? ?? FF",
			byte_0 = Class12.smethod_8("57 8B F9 8B 08", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x0400030A RID: 778
		public static GStruct51 gstruct51_5 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_3",
			string_1 = "89 ?? ?? 8B ?? ?? 89 ?? ?? C7",
			byte_0 = Class12.smethod_8("8B 51 44 83 C2 14", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x0400030B RID: 779
		public static GStruct51 gstruct51_6 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_4",
			string_1 = "5E 5F 5D 5B 81 C4 ?? ?? ?? ?? C3",
			byte_0 = Class12.smethod_8("8B 44 94 10 8B 04 83", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};

		// Token: 0x0400030C RID: 780
		public static GStruct51 gstruct51_7 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_5",
			string_1 = "66 ?? ?? ?? 00 75 ?? 8B ?? ?? E8",
			byte_0 = Class12.smethod_8("39 76 08 75 1B", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x0400030D RID: 781
		public static GStruct51 gstruct51_8 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_6",
			string_1 = "39 ?? ?? 74 ?? 8B ?? ?? 85 ?? 75",
			byte_0 = Class12.smethod_8("83 38 03 75 05", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x0400030E RID: 782
		public static GStruct51 gstruct51_9 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_7",
			string_1 = "75 12 8B 40 08 8B 08",
			byte_0 = Class12.smethod_8("85 C0 74 17 83 38 06", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -7
		};

		// Token: 0x0400030F RID: 783
		public static GStruct51 gstruct51_10 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_8",
			string_1 = "EB 03 8B 71 08",
			byte_0 = Class12.smethod_8("8B 49 08 8B 31", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x04000310 RID: 784
		public static GStruct51 gstruct51_11 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_9",
			string_1 = "83 C7 01 83 FF 02 75 73",
			byte_0 = Class12.smethod_8("85 C0", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -15
		};

		// Token: 0x04000311 RID: 785
		public static GStruct51 gstruct51_12 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_10",
			string_1 = "8B 0A 8B 51 18 8B 04 82 8B C8",
			byte_0 = Class12.smethod_8("8B 4E 08 8B 11", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -5
		};

		// Token: 0x04000312 RID: 786
		public static GStruct51 gstruct51_13 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_11",
			string_1 = "85 C9 74 10 8B 10 8B 12",
			byte_0 = Class12.smethod_8("8B 40 08 8B 48 04", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x04000313 RID: 787
		public static GStruct51 gstruct51_14 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_12",
			string_1 = "85 C0 74 0C 83 F8 04",
			byte_0 = Class12.smethod_8("8B 4C 24 04 8B 01", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x04000314 RID: 788
		public static GStruct51 gstruct51_15 = new GStruct51
		{
			string_0 = "LUALIBDLL_CASH_13",
			string_1 = "8B 4C 24 08 3B 11 74 03",
			byte_0 = Class12.smethod_8("8B 44 24 04 8B 10", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x04000315 RID: 789
		public static GStruct51 gstruct51_16 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_1",
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};

		// Token: 0x04000316 RID: 790
		public static GStruct51 gstruct51_17 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_2",
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};

		// Token: 0x04000317 RID: 791
		public static GStruct51 gstruct51_18 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_3",
			int_4 = 0,
			int_0 = 1,
			int_2 = 6
		};

		// Token: 0x04000318 RID: 792
		public static GStruct51 gstruct51_19 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_5",
			byte_0 = Class12.smethod_8("8B 11 8B C8 8B 42 10 FF D0", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 23
		};

		// Token: 0x04000319 RID: 793
		public static GStruct51 gstruct51_20 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_6",
			byte_0 = Class12.smethod_8("8B 11 8B 52 10", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 2
		};

		// Token: 0x0400031A RID: 794
		public static GStruct51 gstruct51_21 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_7",
			byte_0 = Class12.smethod_8("8B 4D 08 8B 14 99", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 10
		};

		// Token: 0x0400031B RID: 795
		public static GStruct51 gstruct51_22 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_8",
			byte_0 = Class12.smethod_8("8B F1 83 7E 04 03", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = -6
		};

		// Token: 0x0400031C RID: 796
		public static GStruct51 gstruct51_23 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_9",
			byte_0 = Class12.smethod_8("8B 4F 20 8B 47 1C", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};

		// Token: 0x0400031D RID: 797
		public static GStruct51 gstruct51_24 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_10",
			byte_0 = Class12.smethod_8("8B 4F 20 8B 47 1C", true),
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};

		// Token: 0x0400031E RID: 798
		public static GStruct51 gstruct51_25 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_13",
			byte_0 = Class12.smethod_8("55 8B EC 83 EC 08", true),
			int_4 = 0,
			int_0 = 1,
			int_2 = 0
		};

		// Token: 0x0400031F RID: 799
		public static GStruct51 gstruct51_26 = new GStruct51
		{
			string_0 = "GAME_DISABE_CASH_14",
			byte_0 = Class12.smethod_8("55 8B EC 83 EC 08", true),
			int_4 = 0,
			int_0 = 2,
			int_2 = 0
		};

		// Token: 0x04000320 RID: 800
		public static uint[,] uint_1;

		// Token: 0x04000321 RID: 801
		public static GStruct51 gstruct51_27;

		// Token: 0x04000322 RID: 802
		public static GStruct51 gstruct51_28;

		// Token: 0x04000323 RID: 803
		public static GStruct51 gstruct51_29;

		// Token: 0x04000324 RID: 804
		public static GStruct51 gstruct51_30;

		// Token: 0x04000325 RID: 805
		public static GStruct51 gstruct51_31;

		// Token: 0x04000326 RID: 806
		private static uint[] uint_2;

		// Token: 0x04000327 RID: 807
		private static uint[] uint_3;

		// Token: 0x04000328 RID: 808
		private static uint[] uint_4;

		// Token: 0x04000329 RID: 809
		private static uint[] uint_5;

		// Token: 0x0400032A RID: 810
		private static uint uint_6;

		// Token: 0x0400032B RID: 811
		private static uint[] uint_7;

		// Token: 0x0400032C RID: 812
		private static uint[] uint_8;

		// Token: 0x0400032D RID: 813
		private static uint[,] uint_9;

		// Token: 0x0400032E RID: 814
		public static int int_1;

		// Token: 0x0400032F RID: 815
		private static uint uint_10;

		// Token: 0x04000330 RID: 816
		private static int int_2;

		// Token: 0x04000331 RID: 817
		private static uint uint_11;

		// Token: 0x04000332 RID: 818
		private static int int_3;

		// Token: 0x04000333 RID: 819
		private static uint uint_12;

		// Token: 0x04000334 RID: 820
		private static int int_4;

		// Token: 0x04000335 RID: 821
		private static Random random_0;
	}
}
