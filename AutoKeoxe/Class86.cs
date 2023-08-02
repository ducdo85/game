using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000055 RID: 85
	internal class Class86
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x000E79A4 File Offset: 0x000E5BA4
		public static int smethod_0(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_147.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			int result = -1;
			bool flag = num2 != 0U && num3 > 0U;
			if (flag)
			{
				result = 2;
			}
			else
			{
				bool flag2 = num2 == 0U;
				if (flag2)
				{
					bool flag3 = num3 != 0U && Class86.Class88.smethod_0(gstruct49_0) > 0;
					if (flag3)
					{
						result = 1;
					}
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000E7A58 File Offset: 0x000E5C58
		public static int smethod_1(GStruct49 gstruct49_0, int int_1 = -1)
		{
			bool flag = int_1 < 0 || int_1 > 1;
			if (flag)
			{
				int_1 = Class86.smethod_0(gstruct49_0);
			}
			bool flag2 = int_1 != 0;
			int result;
			if (flag2)
			{
				bool flag3 = int_1 > 0;
				if (flag3)
				{
					result = Class86.Class88.smethod_0(gstruct49_0);
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				result = Class86.Class87.smethod_0(gstruct49_0);
			}
			return result;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x000E7AA8 File Offset: 0x000E5CA8
		public static string smethod_2(GStruct49 gstruct49_0, int int_1 = -1)
		{
			bool flag = int_1 < 0 || int_1 > 1;
			if (flag)
			{
				int_1 = Class86.smethod_0(gstruct49_0);
			}
			bool flag2 = int_1 != 0;
			string result;
			if (flag2)
			{
				bool flag3 = int_1 > 0;
				if (flag3)
				{
					result = Class86.Class88.smethod_1(gstruct49_0);
				}
				else
				{
					result = string.Empty;
				}
			}
			else
			{
				result = Class86.Class87.smethod_1(gstruct49_0, 96);
			}
			return result;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000E7AFC File Offset: 0x000E5CFC
		public static string smethod_3(GStruct49 gstruct49_0, int int_1, int int_2 = -1, byte byte_0 = 128)
		{
			bool flag = int_2 < 0 || int_2 > 1;
			if (flag)
			{
				int_2 = Class86.smethod_0(gstruct49_0);
			}
			bool flag2 = int_2 == 0;
			string result;
			if (flag2)
			{
				result = Class86.smethod_4(gstruct49_0, int_1, 0, byte_0);
			}
			else
			{
				bool flag3 = int_2 > 0;
				if (flag3)
				{
					result = Class86.smethod_4(gstruct49_0, int_1, 1, byte_0);
				}
				else
				{
					result = string.Empty;
				}
			}
			return result;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000E7B54 File Offset: 0x000E5D54
		public static string smethod_4(GStruct49 gstruct49_0, int int_1, int int_2, byte byte_0 = 128)
		{
			uint num = Class53.gstruct51_147.uint_0;
			uint num2 = Class53.gstruct51_148.uint_0;
			bool flag = int_2 > 0;
			if (flag)
			{
				num = Class53.gstruct51_149.uint_0;
				num2 = Class53.gstruct51_150.uint_0;
			}
			bool flag2 = gstruct49_0.uint_7 != 0U && num != 0U && num2 != 0U && Class53.gstruct51_146.uint_0 > 0U;
			string result;
			if (flag2)
			{
				int num3 = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + num, array, 4, ref num3);
				uint num4 = BitConverter.ToUInt32(array, 0);
				bool flag3 = num4 > 0U;
				if (flag3)
				{
					uint uint_ = num4 + num2 + (Class53.gstruct51_146.uint_0 - 4U);
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num3);
					uint num5 = BitConverter.ToUInt32(array, 0);
					uint uint_2 = num5 + (uint)(int_1 * 4);
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 4, ref num3);
					uint num6 = BitConverter.ToUInt32(array, 0);
					uint uint_3 = num6 + 28U;
					int num7 = 0;
					byte[] byte_ = new byte[(int)byte_0];
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_3, byte_, (int)byte_0, ref num7);
					result = Class10.smethod_3(byte_);
				}
				else
				{
					result = string.Empty;
				}
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000E7C94 File Offset: 0x000E5E94
		public static bool smethod_5(GStruct49 gstruct49_0, int int_1)
		{
			int num = Class86.smethod_0(gstruct49_0);
			bool flag = 0 > num;
			return !flag && Class70.smethod_59(gstruct49_0, int_1, (int)Convert.ToByte(num == 1));
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000E7CCC File Offset: 0x000E5ECC
		public static int smethod_6(GStruct49 gstruct49_0, string string_1, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			int i = 0;
			int num = 0;
			byte[] array = new byte[1];
			while (i < 150)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array, 1, ref num);
				bool flag = array[0] == 0;
				if (flag)
				{
					break;
				}
				Thread.Sleep(10);
				i++;
			}
			i = 0;
			array[0] = 1;
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array, 1, ref num);
			try
			{
				i = Class86.smethod_7(gstruct49_0, string_1, bool_0, bool_1, bool_2, bool_3);
			}
			catch
			{
			}
			array[0] = 0;
			Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array, 1, ref num);
			return i;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x000E7DA4 File Offset: 0x000E5FA4
		private static int smethod_7(GStruct49 gstruct49_0, string string_1, bool bool_0 = false, bool bool_1 = false, bool bool_2 = false, bool bool_3 = false)
		{
			bool flag = string_1 != null && !(string_1 == string.Empty);
			int result;
			if (flag)
			{
				string[] array = Class12.smethod_67(string_1, '\0', '\u0006', ' ').Split(new char[]
				{
					'|'
				});
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				string text = null;
				byte[] array2 = new byte[4];
				num2 = 0;
				for (;;)
				{
					IL_44B:
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num2);
					int num4 = BitConverter.ToInt32(array2, 0);
					bool flag2 = num3 != 0;
					if (flag2)
					{
						bool flag3 = num3 != num4;
						if (flag3)
						{
							break;
						}
					}
					else
					{
						num3 = num4;
					}
					int num5 = Class86.smethod_0(gstruct49_0);
					bool flag4 = num5 < 0;
					if (flag4)
					{
						break;
					}
					bool flag5 = num5 > 0;
					if (flag5)
					{
						num5 = 1;
					}
					num2 = Class86.smethod_1(gstruct49_0, num5);
					bool flag6 = num2 <= 0;
					if (flag6)
					{
						break;
					}
					int num6 = 0;
					string text2 = null;
					string[] array3 = new string[num2];
					while (!Class12.bool_0)
					{
						for (int i = 0; i < num2; i++)
						{
							string text3 = Class86.smethod_3(gstruct49_0, i, num5, 128);
							array3[i] = Class12.smethod_67(text3, '\0', '\u0006', ' ');
							text2 += text3;
						}
						bool flag7 = text != null && !(text != text2);
						if (!flag7)
						{
							text = text2;
							break;
						}
						num6++;
						bool flag8 = num6 > 10;
						if (flag8)
						{
							goto Block_11;
						}
						text2 = null;
					}
					int num7 = 0;
					if (bool_3)
					{
						while (array3 != null && array != null && array.Length > num7)
						{
							string text4 = array[num7];
							bool flag9 = text4 != null && !(text4 == string.Empty);
							if (flag9)
							{
								int i = 0;
								while (i < array3.Length)
								{
									string text5 = array3[num7];
									bool flag10 = text5 == null || text5 == string.Empty || !Class12.smethod_2(text5, text4, false) || ((text4 == "®«ng" || text4 == "§«ng") && 0 <= text5.IndexOf("Ho¹t ") && 0 <= string_1.IndexOf("hµnh "));
									if (flag10)
									{
										i++;
									}
									else
									{
										num++;
										Class70.smethod_59(gstruct49_0, i, num5);
										if (bool_2)
										{
											goto Block_35;
										}
										num6 = 0;
										int num8 = num5;
										while (num5 == num8 && num6 < 60)
										{
											num6++;
											Thread.Sleep(10);
											num5 = Class86.smethod_0(gstruct49_0);
										}
										Thread.Sleep(250 + Class86.int_0);
										if (bool_1)
										{
											Class12.smethod_30(ref array, text4, true);
										}
										goto IL_44B;
									}
								}
							}
							num7++;
						}
						break;
					}
					while (array3 != null && array3.Length > num7 && array != null)
					{
						string text6 = array3[num7];
						bool flag11 = text6 != null && !(text6 == string.Empty);
						if (flag11)
						{
							int i = 0;
							while (i < array.Length)
							{
								string text4 = array[i];
								bool flag12 = text4 == null || text4 == string.Empty || !Class12.smethod_2(text6, text4, false) || ((text4 == "®«ng" || text4 == "§«ng") && 0 <= text6.IndexOf("Ho¹t ") && 0 <= string_1.IndexOf("hµnh "));
								if (flag12)
								{
									i++;
								}
								else
								{
									num++;
									Class70.smethod_59(gstruct49_0, num7, num5);
									if (bool_2)
									{
										goto Block_39;
									}
									num6 = 0;
									int num8 = num5;
									while (num5 == num8 && num6 < 60)
									{
										num6++;
										Thread.Sleep(10);
										num5 = Class86.smethod_0(gstruct49_0);
									}
									Thread.Sleep(250 + Class86.int_0);
									if (bool_1)
									{
										Class12.smethod_30(ref array, text4, true);
									}
									goto IL_44B;
								}
							}
						}
						num7++;
					}
					break;
				}
				Block_11:
				Block_35:
				Block_39:
				result = num;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x000E8210 File Offset: 0x000E6410
		public static void smethod_8(GStruct49 gstruct49_0, int int_1 = -1)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[1];
			Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array2, 1, ref num);
			bool flag = array2[0] > 0;
			if (!flag)
			{
				array2[0] = 1;
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array2, 1, ref num);
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				while (Class86.Class89.smethod_4(gstruct49_0))
				{
					bool flag2 = num4 < 100;
					if (!flag2)
					{
						num3 = 1;
						break;
					}
					bool flag3 = num4 % 10 == 0;
					if (flag3)
					{
						Class22.smethod_4(gstruct49_0.uint_4, 32U);
					}
					Thread.Sleep(10);
					num4++;
				}
				int num5 = 0;
				for (;;)
				{
					num5++;
					bool flag4 = num5 > 6;
					if (flag4)
					{
						break;
					}
					int num6 = Class86.smethod_0(gstruct49_0);
					bool flag5 = num6 < 0;
					if (flag5)
					{
						break;
					}
					int num7 = Class86.smethod_1(gstruct49_0, num6);
					bool flag6 = num7 <= 0;
					if (flag6)
					{
						break;
					}
					string[] array3 = new string[num7];
					for (int i = 0; i < num7; i++)
					{
						array3[i] = Class86.smethod_4(gstruct49_0, i, num6, 128);
						bool flag7 = 0 <= Class12.smethod_1(array3[i], "100 m¶nh") || (0 <= Class12.smethod_1(array3[i], "Öm vô lÇn nµy khã qu¸") && 0 <= Class12.smethod_1(array3[i], "a muèn hñy bá kh«ng lµm n"));
						if (flag7)
						{
							goto Block_9;
						}
					}
					int num8 = num7 - 1;
					for (int j = 0; j < num7; j++)
					{
						string string_ = Class12.smethod_67(array3[num7 - j - 1], '\0', '\u0006', ' ').ToLower();
						for (int k = 0; k < Class86.string_0.Length; k++)
						{
							bool flag8 = 0 > Class12.smethod_1(string_, Class86.string_0[k].ToLower());
							if (!flag8)
							{
								num8 = num7 - j - 1;
								goto IL_210;
							}
						}
					}
					IL_210:
					Class70.smethod_59(gstruct49_0, num8, num6);
					bool flag9 = 0 > int_1;
					if (flag9)
					{
						Thread.Sleep(10 + Class86.int_0);
					}
					else
					{
						Thread.Sleep(1 + int_1);
					}
					num2++;
				}
				Block_9:
				bool flag10 = num3 > 0;
				if (flag10)
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num);
					bool flag11 = BitConverter.ToUInt32(array, 0) > 0U;
					if (flag11)
					{
						Class70.smethod_59(gstruct49_0, 0, 1);
						Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_73);
					}
				}
				array2[0] = 0;
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_15 + Class70.uint_39 * 4U, array2, 1, ref num);
			}
		}

		// Token: 0x040003BC RID: 956
		public static uint uint_0 = 2685128U;

		// Token: 0x040003BD RID: 957
		public static int int_0 = -1;

		// Token: 0x040003BE RID: 958
		private static string[] string_0 = new string[]
		{
			"Õt thóc",
			"Ta quªn",
			"êi khái",
			"nghÜ l¹i",
			"suy nghÜ k",
			"h«ng muèn",
			"Ch­a Muèn",
			"h©n tiÖn",
			"Ta kh«ng",
			"Kh«ng ®",
			"Kh«ng",
			"L¸t n÷a",
			"§­îc råi",
			"biÕt råi",
			"Mét L¸t",
			"chuÈn bÞ chót"
		};

		// Token: 0x020000F8 RID: 248
		public class Class87
		{
			// Token: 0x06000C37 RID: 3127 RVA: 0x0019B6E4 File Offset: 0x001998E4
			public static int smethod_0(GStruct49 gstruct49_0)
			{
				int num = 0;
				byte[] array = new byte[4];
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_147.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_148.uint_0 + Class53.gstruct51_146.uint_0, array, 4, ref num);
				return BitConverter.ToInt32(array, 0);
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x0019B75C File Offset: 0x0019995C
			public static string smethod_1(GStruct49 gstruct49_0, int int_0 = 96)
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_147.uint_0, gstruct49_0.int_137);
				uint num2 = num + Class53.gstruct51_148.uint_0 + Class53.gstruct51_146.uint_0;
				uint num3 = num2 + 2712U;
				return Class22.smethod_29(num3 + 4U, gstruct49_0.int_137, int_0);
			}
		}

		// Token: 0x020000F9 RID: 249
		public class Class88
		{
			// Token: 0x06000C3A RID: 3130 RVA: 0x0019B7BC File Offset: 0x001999BC
			public static int smethod_0(GStruct49 gstruct49_0)
			{
				int num = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_149.uint_0, array, 4, ref num);
				uint num2 = BitConverter.ToUInt32(array, 0);
				uint uint_ = num2 + Class53.gstruct51_150.uint_0 + Class53.gstruct51_146.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
				return BitConverter.ToInt32(array, 0);
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x0019B834 File Offset: 0x00199A34
			public static string smethod_1(GStruct49 gstruct49_0)
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_149.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_156.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_156.uint_0 - 4U, gstruct49_0.int_137);
				uint num4 = Class22.smethod_30(num3 + Class53.gstruct51_157.uint_0, gstruct49_0.int_137);
				int num5 = (int)Class22.smethod_30(num4 - 12U, gstruct49_0.int_137);
				bool flag = num5 <= 10;
				if (flag)
				{
					num5 = 512;
				}
				return Class22.smethod_29(num4, gstruct49_0.int_137, num5);
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x0019B8E4 File Offset: 0x00199AE4
			public static bool smethod_2(GStruct49 gstruct49_0, string string_0 = null)
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_149.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_156.uint_0, gstruct49_0.int_137);
				uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_156.uint_0 - 4U, gstruct49_0.int_137);
				uint uint_ = Class22.smethod_30(num3 + Class53.gstruct51_157.uint_0, gstruct49_0.int_137);
				int num4 = 0;
				byte[] array = Class12.smethod_46(string_0, true);
				return Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num4);
			}
		}

		// Token: 0x020000FA RID: 250
		public class Class89
		{
			// Token: 0x06000C3E RID: 3134 RVA: 0x0019B980 File Offset: 0x00199B80
			public static string smethod_0(GStruct49 gstruct49_0)
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_153.uint_0 + Class53.gstruct51_156.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_157.uint_0, gstruct49_0.int_137);
				int num3 = (int)Class22.smethod_30(num2 - 12U, gstruct49_0.int_137);
				bool flag = num3 <= 0;
				string result;
				if (flag)
				{
					result = Class22.smethod_28(num2, gstruct49_0.int_137, 512);
				}
				else
				{
					result = Class22.smethod_29(num2, gstruct49_0.int_137, num3);
				}
				return result;
			}

			// Token: 0x06000C3F RID: 3135 RVA: 0x0019BA14 File Offset: 0x00199C14
			public static bool smethod_1(GStruct49 gstruct49_0, string string_0 = null)
			{
				uint num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_153.uint_0 + Class53.gstruct51_156.uint_0, gstruct49_0.int_137);
				uint num2 = Class22.smethod_30(num + Class53.gstruct51_157.uint_0, gstruct49_0.int_137);
				int num3 = 0;
				byte[] array = Class12.smethod_46(string_0, true);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2, array, array.Length, ref num3);
				byte[] array2 = new byte[4];
				array = array2;
				return Class22.WriteProcessMemory(gstruct49_0.int_137, num2 - 12U, array, array.Length, ref num3);
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x0019BAA8 File Offset: 0x00199CA8
			public static int smethod_2(GStruct49 gstruct49_0)
			{
				return (int)Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_153.uint_0 + Class53.gstruct51_155.uint_0, gstruct49_0.int_137);
			}

			// Token: 0x06000C41 RID: 3137 RVA: 0x0019BAE4 File Offset: 0x00199CE4
			public static int smethod_3(GStruct49 gstruct49_0)
			{
				return (int)Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_153.uint_0 + Class53.gstruct51_154.uint_0, gstruct49_0.int_137);
			}

			// Token: 0x06000C42 RID: 3138 RVA: 0x0019BB20 File Offset: 0x00199D20
			public static bool smethod_4(GStruct49 gstruct49_0)
			{
				int num = Class86.Class89.smethod_2(gstruct49_0);
				bool flag = num > 0;
				if (flag)
				{
					int num2 = Class86.Class89.smethod_3(gstruct49_0);
					bool flag2 = num2 <= num;
					if (flag2)
					{
						return true;
					}
				}
				int num3 = 0;
				byte[] array = new byte[4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_151.uint_0, array, 4, ref num3);
				uint num4 = BitConverter.ToUInt32(array, 0);
				bool flag3 = num4 != 0U && Class86.Class88.smethod_0(gstruct49_0) > 0;
				if (flag3)
				{
					num4 = 0U;
				}
				return num4 > 0U;
			}

			// Token: 0x06000C43 RID: 3139 RVA: 0x0019BBB0 File Offset: 0x00199DB0
			public static bool smethod_5(GStruct49 gstruct49_0)
			{
				int num = 0;
				for (;;)
				{
					bool flag = !Class86.Class89.smethod_4(gstruct49_0);
					if (flag)
					{
						break;
					}
					bool flag2 = num >= 20;
					if (flag2)
					{
						break;
					}
					Class22.smethod_4(gstruct49_0.uint_4, 32U);
					Thread.Sleep(100);
					num++;
				}
				return !Class86.Class89.smethod_4(gstruct49_0);
			}
		}
	}
}
