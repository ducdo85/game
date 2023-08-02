using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000052 RID: 82
	internal class Class83
	{
		// Token: 0x060004F3 RID: 1267 RVA: 0x000E3BFC File Offset: 0x000E1DFC
		public static uint smethod_0(GStruct49 gstruct49_0, string string_1 = "\\settings\\shop\\type.txt")
		{
			uint num = Class22.smethod_1(gstruct49_0.int_137, 86016U, GEnum1.flag_2);
			bool flag = num == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				uint num2 = 128U;
				uint num3 = num + num2;
				uint num4 = num3 - num2;
				uint num5 = num3 + 32U;
				int num6 = 0;
				byte[] array = new byte[6];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_4.uint_0 + 11U, array, array.Length, ref num6);
				byte[] array2 = Class12.smethod_46(string_1, true);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num + 4U, array2, array2.Length, ref num6);
				string string_2 = string.Concat(new string[]
				{
					"6068",
					Class12.smethod_45(num4 + 4U, 8, false, true),
					"B9",
					Class12.smethod_45(num5, 8, false, true),
					"FF 15 00 00 00 0061C6 05",
					Class12.smethod_45(num4, 8, false, true),
					"01",
					Class70.smethod_10(gstruct49_0.uint_97)
				});
				array2 = Class12.smethod_8(string_2, true);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3, array2, array2.Length, ref num6);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3 + 11U, array, array.Length, ref num6);
				Class70.smethod_12(gstruct49_0.int_137, num3);
				int i = 0;
				byte[] array3 = new byte[4];
				uint num7 = 0U;
				bool flag2 = false;
				while (i < 10)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num4, array3, 1, ref num6);
					bool flag3 = array3[0] <= 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + 12U, array3, 4, ref num6);
						num7 = BitConverter.ToUInt32(array3, 0);
						flag2 = true;
						break;
					}
					i++;
					Thread.Sleep(100);
				}
				bool flag4 = flag2;
				if (flag4)
				{
					Class22.smethod_2(gstruct49_0.int_137, num);
				}
				result = num7;
			}
			return result;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x000E3DE0 File Offset: 0x000E1FE0
		public static Struct23[] smethod_1(GStruct49 gstruct49_0)
		{
			uint num = Class83.smethod_0(gstruct49_0, "\\settings\\shop\\type.txt");
			bool flag = num > 0U;
			Struct23[] result;
			if (flag)
			{
				int num2 = 0;
				byte[] array = new byte[512];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
				string text = Class10.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
				string[] array2 = text.Split(new char[]
				{
					'\n'
				});
				bool flag2 = array2.Length > 1 && Class12.smethod_1(array2[0].ToUpper(), "TYPENAME") >= 0;
				if (flag2)
				{
					int num3 = 0;
					Struct23[] array3 = null;
					int num4 = 1;
					while (num4 < array2.Length && array2[num4] != null && !(array2[num4] == string.Empty))
					{
						string[] array4 = array2[num4].Split(new char[]
						{
							'\t'
						});
						bool flag3 = array4.Length == 2;
						if (flag3)
						{
							int int_ = Class12.smethod_11(array4[1]);
							num3++;
							bool flag4 = num3 != 1;
							if (flag4)
							{
								Array.Resize<Struct23>(ref array3, num3);
								ref Struct23 ptr = ref array3[num3 - 1];
								ptr = new Struct23
								{
									int_0 = int_,
									string_0 = array4[0]
								};
							}
							else
							{
								array3 = new Struct23[]
								{
									new Struct23
									{
										int_0 = int_,
										string_0 = array4[0]
									}
								};
							}
						}
						num4++;
					}
					result = array3;
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x000E3F98 File Offset: 0x000E2198
		public static string smethod_2(GStruct49 gstruct49_0)
		{
			uint num = Class83.smethod_0(gstruct49_0, "\\settings\\shop\\type.txt");
			bool flag = num == 0U;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				int num2 = 0;
				byte[] array = new byte[80];
				Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, array.Length, ref num2);
				string text = Class10.smethod_3(array).Replace("\r", "\n").Replace("\n\n", "\n");
				string[] array2 = text.Split(new char[]
				{
					'\n'
				});
				text = string.Empty;
				bool flag2 = array2.Length > 1 && Class12.smethod_1(array2[0].ToUpper(), "TYPENAME") == 0;
				if (flag2)
				{
					array2 = array2[1].Split(new char[]
					{
						'\t'
					});
					text = array2[0];
				}
				result = text;
			}
			return result;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000E4070 File Offset: 0x000E2270
		public static int smethod_3(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_1.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				bool flag2 = !Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_1.uint_0, array, 4, ref num);
				if (flag2)
				{
					result = -1;
				}
				else
				{
					result = BitConverter.ToInt32(array, 0);
				}
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000E40E4 File Offset: 0x000E22E4
		public static bool smethod_4(GStruct49 gstruct49_0)
		{
			bool flag = Class83.string_0 == string.Empty || Class83.string_0 == null || Class12.smethod_28(Class83.long_0) > 600000L;
			if (flag)
			{
				Class83.string_0 = Class83.smethod_2(gstruct49_0);
				bool flag2 = (Class83.string_0 == null || Class83.string_0 == string.Empty) && Form1.string_4 != null && 0 <= Form1.int_0 && Form1.int_0 < Form1.string_4.GetLength(0);
				if (flag2)
				{
					Class83.string_0 = Form1.string_4[Form1.int_0, 1];
				}
				Class83.long_0 = Class12.smethod_27();
			}
			return Class70.smethod_26(gstruct49_0, Class83.string_0);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000E41A0 File Offset: 0x000E23A0
		public static uint smethod_5(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_5.uint_0 == 0U;
			uint result;
			if (flag)
			{
				result = 0U;
			}
			else
			{
				bool flag2 = gstruct49_0.uint_8 == 0U;
				if (flag2)
				{
					gstruct49_0.uint_8 = Class22.smethod_37(gstruct49_0.int_136, "engine.dll");
					bool flag3 = gstruct49_0.uint_8 == 0U;
					if (flag3)
					{
						return 0U;
					}
					int num = Class81.smethod_3(Form1.gstruct49_0, gstruct49_0.int_136);
					bool flag4 = 0 <= num;
					if (flag4)
					{
						Form1.gstruct49_0[num].uint_8 = gstruct49_0.uint_8;
					}
				}
				int num2 = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_8 + Class53.gstruct51_5.uint_0, array, 4, ref num2);
				result = BitConverter.ToUInt32(array, 0);
			}
			return result;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000E4270 File Offset: 0x000E2470
		public static uint smethod_6(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_5.uint_0 > 0U;
			uint result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				uint num2 = 0U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_8 + Class53.gstruct51_5.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num3 > 0U;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class53.gstruct51_6.uint_0, array, 4, ref num);
					num2 = BitConverter.ToUInt32(array, 0);
				}
				result = num2;
			}
			else
			{
				result = 0U;
			}
			return result;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000E4304 File Offset: 0x000E2504
		public static bool smethod_7(GStruct49 gstruct49_0, uint uint_3)
		{
			bool flag = Class53.gstruct51_6.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = Class83.smethod_5(gstruct49_0);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = false;
				}
				else
				{
					int num2 = 0;
					byte[] bytes = BitConverter.GetBytes(uint_3);
					uint uint_4 = num + Class53.gstruct51_6.uint_0;
					result = Class22.WriteProcessMemory(gstruct49_0.int_137, uint_4, bytes, bytes.Length, ref num2);
				}
			}
			return result;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000E4370 File Offset: 0x000E2570
		public static bool smethod_8(GStruct49 gstruct49_0, int[] int_0)
		{
			bool flag = Class53.gstruct51_6.uint_0 > 0U;
			bool result;
			if (flag)
			{
				uint num = Class83.smethod_5(gstruct49_0);
				bool flag2 = num == 0U;
				if (flag2)
				{
					result = false;
				}
				else
				{
					uint value = (uint)((int_0[1] << 16) + int_0[0]);
					int num2 = 0;
					byte[] bytes = BitConverter.GetBytes(value);
					uint uint_ = num + Class53.gstruct51_6.uint_0;
					result = Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, bytes, bytes.Length, ref num2);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000E43EC File Offset: 0x000E25EC
		public static bool smethod_9(GStruct49 gstruct49_0, int int_0, int int_1)
		{
			bool flag = Class53.gstruct51_6.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num = Class83.smethod_5(gstruct49_0);
				bool flag2 = num > 0U;
				if (flag2)
				{
					uint value = (uint)((int_1 << 16) + int_0);
					int num2 = 0;
					byte[] bytes = BitConverter.GetBytes(value);
					uint uint_ = num + Class53.gstruct51_6.uint_0;
					result = Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, bytes, bytes.Length, ref num2);
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000E4460 File Offset: 0x000E2660
		public static uint[] smethod_10(uint[] uint_3, uint[] uint_4)
		{
			uint[] array = new uint[2];
			int num = (int)(400U - (uint_3[0] - uint_4[0]));
			int num2 = (int)(300U - (uint_3[1] - uint_4[1]) / 2U);
			return new uint[]
			{
				(uint)num,
				(uint)num2
			};
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000E44A8 File Offset: 0x000E26A8
		public static uint[] smethod_11(uint[] uint_3, int int_0, int int_1)
		{
			uint[] array = new uint[2];
			int num = (int)(uint_3[0] - (uint)(400 - int_0));
			int num2 = (int)(uint_3[1] - (uint)((300 - int_1) * 2));
			return new uint[]
			{
				(uint)num,
				(uint)num2
			};
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000E44EC File Offset: 0x000E26EC
		public static int smethod_12(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_5.uint_0 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				int num2 = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_8 + Class53.gstruct51_5.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num3 > 0U;
				if (flag2)
				{
					uint uint_ = num3 + Class53.gstruct51_6.uint_0 + Class83.uint_2;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 1, ref num);
					num2 = (int)array[0];
				}
				result = num2;
			}
			return result;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000E4584 File Offset: 0x000E2784
		public static int smethod_13(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_6.uint_0 > 0U;
			int result;
			if (flag)
			{
				uint num = Class83.smethod_5(gstruct49_0);
				bool flag2 = num > 0U;
				if (flag2)
				{
					int num2 = 0;
					byte[] array = new byte[4];
					uint uint_ = num + Class53.gstruct51_6.uint_0 + Class83.uint_2;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num2);
					result = BitConverter.ToInt32(array, 0);
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

		// Token: 0x06000501 RID: 1281 RVA: 0x000E4600 File Offset: 0x000E2800
		public static void smethod_14(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_6.uint_0 > 0U;
			if (flag)
			{
				uint num = Class83.smethod_5(gstruct49_0);
				bool flag2 = num > 0U;
				if (flag2)
				{
					int num2 = 0;
					byte[] byte_ = new byte[4];
					uint uint_ = num + Class53.gstruct51_6.uint_0 + Class83.uint_2;
					Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, byte_, 4, ref num2);
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000E4663 File Offset: 0x000E2863
		public static void smethod_15(uint uint_3, uint uint_4)
		{
			Class22.SendMessage(uint_3, Class22.int_30, Class22.int_33, uint_4);
			Class22.SendMessage(uint_3, Class22.int_31, Class22.int_33, uint_4);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000E468C File Offset: 0x000E288C
		public static string smethod_16(GStruct49 gstruct49_0)
		{
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_94.uint_0 + Class53.gstruct51_95.uint_0;
			return Class22.smethod_28(uint_, gstruct49_0.int_137, 40);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000E46CC File Offset: 0x000E28CC
		public static bool smethod_17(GStruct49 gstruct49_0)
		{
			return Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_96.uint_0, gstruct49_0.int_137) > 0U;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000E4700 File Offset: 0x000E2900
		public static uint smethod_18(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			return Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000E474C File Offset: 0x000E294C
		public static uint smethod_19(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			return Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x000E4798 File Offset: 0x000E2998
		public static string smethod_20(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			bool flag = num3 > 0U;
			string result;
			if (flag)
			{
				uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + (num3 - 1U) * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= (int)Class83.uint_1;
				bool flag2 = num6 > 0;
				if (flag2)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_1;
					string text = Class22.smethod_29(uint_, gstruct49_0.int_137, num6);
					bool flag3 = text.IndexOf('\0') > 0;
					if (flag3)
					{
						uint uint_2 = Class22.smethod_30(Class53.gstruct51_214.uint_0, gstruct49_0.int_137) + 28U;
						string str = Class22.smethod_28(uint_2, gstruct49_0.int_137, num6);
						text = text.Replace('\0'.ToString(), "<" + str + ">");
					}
					result = Class83.smethod_33(text, null, " ");
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

		// Token: 0x06000508 RID: 1288 RVA: 0x000E48EC File Offset: 0x000E2AEC
		public static void smethod_21(GStruct49 gstruct49_0, string string_1)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			bool flag = num3 == 0U;
			if (!flag)
			{
				uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + (num3 - 1U) * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= (int)Class83.uint_1;
				bool flag2 = num6 > 0;
				if (flag2)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_1;
					bool flag3 = string_1 == null || string_1 == string.Empty;
					if (flag3)
					{
						string_1 = "0K...";
					}
					bool flag4 = string_1.Length > num6;
					if (flag4)
					{
						string_1 = string_1.Substring(0, num6);
					}
					int num7 = 0;
					byte[] array = Class12.smethod_46(string_1, true);
					num6 = array.Length + (int)Class83.uint_1;
					Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num7);
					array = BitConverter.GetBytes(num6);
					Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + 24U, array, array.Length, ref num7);
				}
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000E4A3C File Offset: 0x000E2C3C
		public static string smethod_22(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			bool flag = num3 == 0U;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + (num3 - 1U) * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= (int)Class83.uint_0;
				bool flag2 = num6 > 0;
				if (flag2)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
					string text = Class22.smethod_29(uint_, gstruct49_0.int_137, num6);
					bool flag3 = Class12.smethod_1(text, '\0') > 0;
					if (flag3)
					{
						uint uint_2 = Class22.smethod_30(Class53.gstruct51_214.uint_0, gstruct49_0.int_137) + 28U;
						string str = Class22.smethod_28(uint_2, gstruct49_0.int_137, num6);
						text = text.Replace('\0'.ToString(), "<" + str + ">");
					}
					result = Class83.smethod_33(text, null, " ");
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000E4B94 File Offset: 0x000E2D94
		public static void smethod_23(GStruct49 gstruct49_0, string string_1)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			bool flag = num3 == 0U;
			if (!flag)
			{
				uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
				uint num5 = Class22.smethod_30(num4 + (num3 - 1U) * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= (int)Class83.uint_0;
				bool flag2 = num6 > 0;
				if (flag2)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
					bool flag3 = string_1 == null || string_1 == string.Empty;
					if (flag3)
					{
						string_1 = "0K..";
					}
					bool flag4 = string_1.Length > num6;
					if (flag4)
					{
						string_1 = string_1.Substring(0, num6);
					}
					int num7 = 0;
					byte[] array = Class12.smethod_46(string_1, true);
					num6 = array.Length + (int)Class83.uint_0;
					Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num7);
					array = BitConverter.GetBytes(num6);
					Class22.WriteProcessMemory(gstruct49_0.int_137, num5 + 24U, array, array.Length, ref num7);
				}
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000E4CE4 File Offset: 0x000E2EE4
		public static string smethod_24(GStruct49 gstruct49_0, uint uint_3)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num3 + uint_3 * 4U, gstruct49_0.int_137);
			int num5 = (int)Class22.smethod_30(num4 + 24U, gstruct49_0.int_137);
			num5 -= 11;
			bool flag = num5 > 0;
			string result;
			if (flag)
			{
				uint uint_4 = num4 + Class53.gstruct51_213.uint_0 + Class83.uint_1;
				string text = Class22.smethod_29(uint_4, gstruct49_0.int_137, num5);
				bool flag2 = text.IndexOf('\0') > 0;
				if (flag2)
				{
					uint num6 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
					bool flag3 = uint_3 == num6 - 1U;
					if (flag3)
					{
						uint uint_5 = Class22.smethod_30(Class53.gstruct51_214.uint_0, gstruct49_0.int_137) + 28U;
						string str = Class22.smethod_28(uint_5, gstruct49_0.int_137, num5);
						text = text.Replace('\0'.ToString(), "<" + str + ">");
					}
				}
				result = Class83.smethod_33(text, null, " ");
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000E4E2C File Offset: 0x000E302C
		public static string smethod_25(GStruct49 gstruct49_0, uint uint_3)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num3 + uint_3 * 4U, gstruct49_0.int_137);
			int num5 = (int)Class22.smethod_30(num4 + 24U, gstruct49_0.int_137);
			num5 -= 19;
			bool flag = num5 <= 0;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				uint uint_4 = num4 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
				string text = Class22.smethod_29(uint_4, gstruct49_0.int_137, num5);
				bool flag2 = Class12.smethod_1(text, '\0') > 0;
				if (flag2)
				{
					uint num6 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
					bool flag3 = uint_3 == num6 - 1U;
					if (flag3)
					{
						uint uint_5 = Class22.smethod_30(Class53.gstruct51_214.uint_0, gstruct49_0.int_137) + 28U;
						string str = Class22.smethod_28(uint_5, gstruct49_0.int_137, num5);
						text = text.Replace('\0'.ToString(), "<" + str + ">");
					}
				}
				result = Class83.smethod_33(text, null, " ");
			}
			return result;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000E4F7C File Offset: 0x000E317C
		public static string[] smethod_26(GStruct49 gstruct49_0, uint uint_3)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			bool flag = num3 <= uint_3;
			if (flag)
			{
				uint_3 = num3;
			}
			uint num5 = num3 - uint_3;
			int num6 = 0;
			string[] array = new string[uint_3];
			for (uint num7 = num5; num7 < num3; num7 += 1U)
			{
				uint num8 = num5 + (num3 - num7) - 1U;
				uint num9 = Class22.smethod_30(num4 + num8 * 4U, gstruct49_0.int_137);
				int num10 = (int)Class22.smethod_30(num9 + 24U, gstruct49_0.int_137);
				num10 -= 19;
				bool flag2 = num10 > 0;
				if (flag2)
				{
					uint uint_4 = num9 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
					string text = Class22.smethod_29(uint_4, gstruct49_0.int_137, num10);
					bool flag3 = !(text == string.Empty);
					if (flag3)
					{
						array[num6] = Class83.smethod_33(text, null, " ");
						num6++;
					}
				}
			}
			return array;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000E50C0 File Offset: 0x000E32C0
		public static string smethod_27(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			string text = null;
			for (uint num5 = 0U; num5 < num3; num5 += 1U)
			{
				uint num6 = Class22.smethod_30(num4 + num5 * 4U, gstruct49_0.int_137);
				int num7 = (int)Class22.smethod_30(num6 + 24U, gstruct49_0.int_137);
				num7 -= 11;
				bool flag = num7 > 0;
				if (flag)
				{
					uint uint_ = num6 + Class53.gstruct51_213.uint_0 + Class83.uint_1;
					string text2 = Class22.smethod_29(uint_, gstruct49_0.int_137, num7);
					bool flag2 = !(text2 == "");
					if (flag2)
					{
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							"(",
							num5,
							")",
							Class83.smethod_33(text2, null, " "),
							Class53.string_7
						});
					}
				}
			}
			return text;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000E520C File Offset: 0x000E340C
		public static string smethod_28(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_211.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			string text = string.Empty;
			for (uint num5 = 0U; num5 < num3; num5 += 1U)
			{
				uint num6 = Class22.smethod_30(num4 + num5 * 4U, gstruct49_0.int_137);
				int num7 = (int)Class22.smethod_30(num6 + 24U, gstruct49_0.int_137);
				num7 -= 19;
				bool flag = num7 > 0;
				if (flag)
				{
					uint uint_ = num6 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
					string text2 = Class22.smethod_29(uint_, gstruct49_0.int_137, num7);
					bool flag2 = !(text2 == "");
					if (flag2)
					{
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							"(",
							num5,
							")",
							Class83.smethod_33(text2, null, " "),
							Class53.string_7
						});
					}
				}
			}
			return text;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000E535C File Offset: 0x000E355C
		public static string smethod_29(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_208.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			string text = null;
			for (uint num4 = 0U; num4 < 256U; num4 += 1U)
			{
				uint num5 = Class22.smethod_30(num3 + num4 * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= 11;
				bool flag = num6 > 0;
				if (flag)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_1;
					string text2 = Class22.smethod_29(uint_, gstruct49_0.int_137, num6);
					bool flag2 = !(text2 == "");
					if (flag2)
					{
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							"(",
							num4,
							")",
							Class83.smethod_33(text2, null, " "),
							Class53.string_7
						});
					}
				}
			}
			return text;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000E5490 File Offset: 0x000E3690
		public static string smethod_30(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_209.uint_0, gstruct49_0.int_137);
			uint num2 = num + Class53.gstruct51_207.uint_0;
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_212.uint_0, gstruct49_0.int_137);
			string text = null;
			for (uint num4 = 0U; num4 < 256U; num4 += 1U)
			{
				uint num5 = Class22.smethod_30(num3 + num4 * 4U, gstruct49_0.int_137);
				int num6 = (int)Class22.smethod_30(num5 + 24U, gstruct49_0.int_137);
				num6 -= 19;
				bool flag = num6 > 0;
				if (flag)
				{
					uint uint_ = num5 + Class53.gstruct51_213.uint_0 + Class83.uint_0;
					string text2 = Class22.smethod_29(uint_, gstruct49_0.int_137, num6);
					bool flag2 = !(text2 == "");
					if (flag2)
					{
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							"(",
							num4,
							")",
							Class83.smethod_33(text2, null, " "),
							Class53.string_7
						});
					}
				}
			}
			return text;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000E55C4 File Offset: 0x000E37C4
		public static void smethod_31(GStruct49 gstruct49_0, object object_0, bool bool_0 = true, uint uint_3 = 3U)
		{
			bool flag = object_0 != null && gstruct49_0.uint_17 != 0U && gstruct49_0.uint_84 != 0U && Class53.gstruct51_210.uint_0 > 0U;
			if (flag)
			{
				uint uint_4 = Class53.gstruct51_207.uint_0;
				if (bool_0)
				{
					uint_3 = 3U;
					uint_4 = Class53.gstruct51_208.uint_0;
				}
				string[] array = new string[]
				{
					"Cong bo",
					"Abc"
				};
				string string_ = object_0.GetType().ToString().ToUpper();
				bool flag2 = Class12.smethod_1(string_, "[") <= 0;
				if (flag2)
				{
					array[1] = object_0.ToString();
				}
				else
				{
					array = (string[])object_0;
				}
				Class22.smethod_31(gstruct49_0.uint_84 + 2U, gstruct49_0.int_137, uint_3, 4);
				Class22.smethod_31(gstruct49_0.uint_84 + 7U, gstruct49_0.int_137, (uint)array[1].Length, 4);
				Class22.smethod_31(gstruct49_0.uint_84 + 19U, gstruct49_0.int_137, uint_4, 4);
				int num = 0;
				byte[] array2 = Class12.smethod_46(array[0], true);
				uint num2 = gstruct49_0.uint_84 - Class70.uint_1;
				bool flag3 = Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array2, array2.Length, ref num);
				array2 = Class12.smethod_46(array[1], true);
				bool flag4 = Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + 80U, array2, array2.Length, ref num);
				bool flag5 = flag3 && flag4;
				if (flag5)
				{
					Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_84);
				}
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000E5730 File Offset: 0x000E3930
		public static void smethod_32(GStruct49 gstruct49_0, uint uint_3)
		{
			bool flag = gstruct49_0.uint_17 != 0U && gstruct49_0.uint_85 > 0U;
			if (flag)
			{
				Class22.smethod_31(gstruct49_0.uint_85 + 2U, gstruct49_0.int_137, uint_3, 4);
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_85);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000E5780 File Offset: 0x000E3980
		private static string smethod_33(string string_1, byte[] byte_0, string string_2 = "")
		{
			bool flag = string_1 != null && string_1 != "";
			if (flag)
			{
				bool flag2 = byte_0 == null;
				if (flag2)
				{
					byte_0 = new byte[30];
					byte b = 0;
					while ((int)b < byte_0.Length)
					{
						byte_0[(int)b] = b;
						b += 1;
					}
				}
				for (int i = 0; i < byte_0.Length; i++)
				{
					string text = string_1;
					char c = (char)byte_0[i];
					string_1 = text.Replace(c.ToString(), string_2);
				}
			}
			return string_1;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000E580C File Offset: 0x000E3A0C
		public static bool smethod_34(GStruct49 gstruct49_0, int int_0 = -1)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_250.uint_0 >= 0U;
			bool result;
			if (flag)
			{
				int num = 0;
				byte[] byte_ = new byte[4];
				bool flag2 = int_0 >= 0;
				if (flag2)
				{
					bool flag3 = int_0 != 0;
					if (flag3)
					{
						bool flag4 = int_0 <= 0;
						if (flag4)
						{
							result = false;
						}
						else
						{
							byte_ = new byte[]
							{
								235
							};
							uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_250.uint_0 + 7U;
							result = Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, byte_, 1, ref num);
						}
					}
					else
					{
						byte_ = new byte[]
						{
							2
						};
						result = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_250.uint_0 + 6U, byte_, 1, ref num);
					}
				}
				else
				{
					byte_ = new byte[]
					{
						1,
						116
					};
					result = Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_250.uint_0 + 6U, byte_, 2, ref num);
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000E591C File Offset: 0x000E3B1C
		public static int smethod_35(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_252.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_252.uint_0;
				if (bool_0)
				{
					num2 -= 4U;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array, 4, ref num);
				result = BitConverter.ToInt32(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000E5990 File Offset: 0x000E3B90
		public static int smethod_36(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_253.uint_0 != 0U && Class53.gstruct51_254.uint_0 != 0U && Class53.gstruct51_255.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_253.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				int num2 = BitConverter.ToInt32(array, 0);
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_255.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 4, ref num);
				int num3 = BitConverter.ToInt32(array, 0);
				int num4 = num2 - num3;
				uint uint_3 = gstruct49_0.uint_7 + Class53.gstruct51_254.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, array, 4, ref num);
				int num5 = BitConverter.ToInt32(array, 0);
				bool flag2 = num4 > num5 * 1000;
				int num7;
				if (flag2)
				{
					int num6 = num4 / 1000;
					if (bool_0)
					{
						num6 /= 60;
					}
					num7 = num6 + 1;
				}
				else
				{
					int num8 = num4 / 1000;
					int num9 = num5 - num8;
					if (bool_0)
					{
						num9 /= 60;
					}
					num7 = num9 + 1;
				}
				result = num7;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000E5AD8 File Offset: 0x000E3CD8
		public static int smethod_37(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_257.uint_0 > 0U;
			int result;
			if (flag)
			{
				int num = 0;
				byte[] array = new byte[4];
				int num2 = 0;
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_257.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num3 > 0U;
				if (flag2)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + 4U, array, 4, ref num);
					num2 = BitConverter.ToInt32(array, 0);
				}
				result = num2;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000E5B74 File Offset: 0x000E3D74
		public static int smethod_38(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.uint_7 != 0U && Class53.gstruct51_256.uint_0 > 0U;
			if (flag)
			{
				bool flag2 = Class53.gstruct51_258.uint_0 == 0U;
				if (!flag2)
				{
					int num = 0;
					byte[] array = new byte[4];
					uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_256.uint_0 + Class53.gstruct51_258.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
					return BitConverter.ToInt32(array, 0);
				}
			}
			return 0;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000E5C08 File Offset: 0x000E3E08
		public static int smethod_39(GStruct49 gstruct49_0)
		{
			bool flag = gstruct49_0.int_136 > 0 && Class53.gstruct51_259.uint_0 != 0U && Class53.gstruct51_260.uint_0 > 0U;
			int result;
			if (flag)
			{
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_259.uint_0 + Class53.gstruct51_260.uint_0;
				int num = 0;
				byte[] array = new byte[2];
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 2, ref num);
				bool flag2 = num != 0;
				if (flag2)
				{
					result = (int)array[0] + (int)array[1] * 256;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = 999;
			}
			return result;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000E5CA4 File Offset: 0x000E3EA4
		public static void smethod_40(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] byte_ = new byte[4];
			byte[] byte_2 = new byte[1];
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class86.uint_0, byte_2, 1, ref num);
			for (uint num2 = 0U; num2 < 18U; num2 += 1U)
			{
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_179.uint_0 + num2 * 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				bool flag = BitConverter.ToUInt32(array, 0) > 0U;
				if (flag)
				{
					Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, byte_, 4, ref num);
				}
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000E5D4C File Offset: 0x000E3F4C
		public static void smethod_41(GStruct49 gstruct49_0, bool bool_0)
		{
			bool flag = gstruct49_0.uint_7 == 0U;
			if (!flag)
			{
				int num = 0;
				uint uint_ = 24976U + gstruct49_0.uint_7;
				byte[] array = new byte[3];
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 3, ref num);
				bool flag2 = !bool_0;
				byte[] array3;
				byte[] byte_;
				if (flag2)
				{
					byte[] array2 = new byte[3];
					array2[0] = 194;
					array2[1] = 24;
					array3 = array2;
					byte_ = new byte[]
					{
						85,
						139,
						236
					};
				}
				else
				{
					array3 = new byte[]
					{
						85,
						139,
						236
					};
					byte[] array4 = new byte[3];
					array4[0] = 194;
					array4[1] = 24;
					byte_ = array4;
				}
				int num2 = 0;
				for (;;)
				{
					bool flag3 = num2 < array.Length;
					if (!flag3)
					{
						goto IL_CE;
					}
					bool flag4 = array[num2] == array3[num2];
					if (!flag4)
					{
						break;
					}
					num2++;
				}
				return;
				IL_CE:
				Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, byte_, 3, ref num);
			}
		}

		// Token: 0x040003B5 RID: 949
		private static uint uint_0 = 19U;

		// Token: 0x040003B6 RID: 950
		private static uint uint_1 = 11U;

		// Token: 0x040003B7 RID: 951
		private static string string_0 = null;

		// Token: 0x040003B8 RID: 952
		private static uint uint_2 = 4U;

		// Token: 0x040003B9 RID: 953
		private static long long_0 = 0L;
	}
}
