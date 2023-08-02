using System;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000018 RID: 24
	internal class Class26
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00016F00 File Offset: 0x00015100
		public static void smethod_0()
		{
			bool flag = Class26.bool_0;
			if (!flag)
			{
				Class26.bool_0 = true;
				bool flag2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 <= 0;
				if (flag2)
				{
					Class12.string_16 = new string[]
					{
						Class12.smethod_53("ᓫᓴᓷᓲᓟᓹᔚᔞᖏᔓᓅᔈᔍᔎ㍤ᔓᓟᓅᓭᖈᔞᓅᔈᔍ㍲ᔓᓅᔙᔗᙕ㎀ᔈᓅᔙᖏᔓᓅᔆᔈᓅᖶ㍺ᔎᓅᔒᖅᔚᓅ㎄ᓅᔕᔍᖒᔆᓅᔙᔗᖏᔓᓓ")
					};
				}
				else
				{
					bool flag3 = FormTuyenchien.gstruct29_0 != null;
					if (flag3)
					{
						bool flag4 = FormDoiMauBang.int_2 != FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 || FormDoiMauBang.gstruct2_0.int_3 <= 0;
						if (flag4)
						{
							FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.gstruct49_0);
							bool flag5 = FormDoiMauBang.gstruct2_0.int_3 <= 0;
							if (flag5)
							{
								goto IL_18E;
							}
							FormDoiMauBang.int_2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136;
						}
						for (int i = 0; i < FormTuyenchien.gstruct29_0.Length; i++)
						{
							bool flag6 = FormTuyenchien.gstruct29_0[i].int_0 > 0 && FormTuyenchien.gstruct29_0[i].string_0 != null && FormTuyenchien.gstruct29_0[i].string_0 != string.Empty;
							if (flag6)
							{
								Class26.smethod_2(FormDoiMauBang.gstruct2_0.gstruct49_0, FormTuyenchien.gstruct29_0[i].string_0);
								Thread.Sleep(300);
							}
						}
					}
					else
					{
						Class12.string_16 = new string[]
						{
							Class12.smethod_53("ᓵᓾᔁᓼᓩᔃᔤᔨᖙᔝᓏᔒᔗᔘ㍮ᔝᓩᓏᓷᖒᔨᓏᔒᔗ㍼ᔝᓏᔣᖙᔝᓏᓱᔐᔝᔖᓏᔗ㎈ᔘᓏᔒ㍖ᔝᓏᔣᔤᔨᖙᔝᓏᔣᔡᔞᔝᔖᓏᔝᖩᔣᓏᔓᔐᔝᔗᓏᔢᖐᔒᔗᓝ")
						};
					}
				}
				IL_18E:
				Class26.bool_0 = false;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000170A4 File Offset: 0x000152A4
		public static void smethod_1()
		{
			bool flag = Class26.bool_0;
			if (!flag)
			{
				Class26.bool_0 = true;
				bool flag2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 > 0 && FormTuyenchien.gstruct29_0 != null;
				if (flag2)
				{
					bool flag3 = FormDoiMauBang.int_2 != FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 || FormDoiMauBang.gstruct2_0.int_3 <= 0;
					if (flag3)
					{
						FormDoiMauBang.gstruct2_0.int_3 = GClass1.smethod_5(FormDoiMauBang.gstruct2_0.gstruct49_0);
						bool flag4 = FormDoiMauBang.gstruct2_0.int_3 <= 0;
						if (flag4)
						{
							goto IL_14F;
						}
						FormDoiMauBang.int_2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136;
					}
					for (int i = 0; i < FormTuyenchien.gstruct29_0.Length; i++)
					{
						bool flag5 = FormTuyenchien.gstruct29_0[i].int_0 > 0 && FormTuyenchien.gstruct29_0[i].string_0 != null && FormTuyenchien.gstruct29_0[i].string_0 != string.Empty;
						if (flag5)
						{
							Class26.smethod_2(FormDoiMauBang.gstruct2_0.gstruct49_0, FormTuyenchien.gstruct29_0[i].string_0);
							Thread.Sleep(300);
						}
					}
				}
				IL_14F:
				Class26.bool_0 = false;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00017208 File Offset: 0x00015408
		public static bool smethod_2(GStruct49 gstruct49_0, object object_0)
		{
			bool flag = !Class70.smethod_18(gstruct49_0, object_0);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int i = 0;
				while (i < 10)
				{
					i++;
					Thread.Sleep(100);
					bool flag2 = 0 <= Class86.smethod_0(gstruct49_0);
					if (flag2)
					{
						Class86.smethod_6(gstruct49_0, "X|c", false, false, false, false);
						break;
					}
				}
				i = 0;
				while (i < 10 && 0 <= Class86.smethod_0(gstruct49_0))
				{
					i++;
					Thread.Sleep(100);
					Class86.smethod_5(gstruct49_0, 0);
				}
				result = true;
			}
			return result;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000172A4 File Offset: 0x000154A4
		public static int smethod_3(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_86.uint_0 + gstruct49_0.uint_7, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_205.uint_0 + Class53.gstruct51_87.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class26.uint_0 + 4U, array, 4, ref num);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00017324 File Offset: 0x00015524
		public static string smethod_4(GStruct49 gstruct49_0, uint uint_3)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_86.uint_0 + gstruct49_0.uint_7, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_205.uint_0 + Class53.gstruct51_87.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class26.uint_0, array, 4, ref num);
			uint num4 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + uint_3 * 4U, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			byte[] array2 = new byte[12];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + Class26.uint_1, array2, array2.Length, ref num);
			return Class10.smethod_3(array2);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000173F0 File Offset: 0x000155F0
		public static string[] smethod_5(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[12];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_86.uint_0 + gstruct49_0.uint_7, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_205.uint_0 + Class53.gstruct51_87.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class26.uint_0 + 4U, array, 4, ref num);
			int num4 = BitConverter.ToInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + Class26.uint_0, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			string[] array3 = null;
			uint num6 = 0U;
			do
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + num6 * 4U, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class26.uint_1, array2, array2.Length, ref num);
				string text = Class10.smethod_3(array2);
				bool flag = text == string.Empty;
				if (flag)
				{
					break;
				}
				bool flag2 = array3 == null;
				if (flag2)
				{
					array3 = new string[1];
				}
				else
				{
					Array.Resize<string>(ref array3, array3.Length + 1);
				}
				array3[array3.Length - 1] = text;
				num6 += 1U;
			}
			while ((ulong)num6 < (ulong)((long)num4));
			return array3;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00017540 File Offset: 0x00015740
		public static void smethod_6()
		{
			int int_ = Class26.int_0;
			uint num = Class26.uint_2;
			int num2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = Class12.smethod_46(Class26.string_0, false);
			byte[] bytes = BitConverter.GetBytes(Class26.long_0);
			Class26.int_0 = 0;
			uint uint_ = num + Class70.uint_51 * 4U;
			uint uint_2 = num + Class70.uint_51 * 4U + 1U;
			uint uint_3 = num + Class70.uint_51 * 4U + 2U;
			uint uint_4 = num + Class70.uint_51 * 4U + 12U;
			Class22.ReadProcessMemory(int_, uint_, array, 1, ref num2);
			int num3 = (int)array[0];
			array[0] = (byte)array2.Length;
			Class22.WriteProcessMemory(int_, uint_2, array, 1, ref num2);
			Class22.WriteProcessMemory(int_, uint_3, bytes, bytes.Length, ref num2);
			Class22.WriteProcessMemory(int_, uint_4, array2, array2.Length, ref num2);
			bool flag = num3 > 0;
			if (!flag)
			{
				array[0] = 1;
				Class22.WriteProcessMemory(int_, uint_, array, 1, ref num2);
				Class22.ReadProcessMemory(int_, Class53.gstruct51_11.uint_0, array, 4, ref num2);
				uint num4 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(int_, num4 + Class53.gstruct51_13.uint_0, array, 4, ref num2);
				uint num5 = BitConverter.ToUInt32(array, 0);
				uint num6 = num5 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(int_, Class53.gstruct51_14.uint_0, array, 4, ref num2);
				uint num7 = BitConverter.ToUInt32(array, 0);
				uint num8 = num7 + num6;
				Class12.smethod_27();
				int num9 = 0;
				do
				{
					Class22.ReadProcessMemory(int_, uint_3, bytes, bytes.Length, ref num2);
					long num10 = BitConverter.ToInt64(bytes, 0);
					bool flag2 = DateTime.Now.Ticks > num10;
					if (flag2)
					{
						break;
					}
					Class22.ReadProcessMemory(int_, uint_2, array, 1, ref num2);
					int num11 = (int)array[0];
					bool flag3 = num11 == 0;
					if (flag3)
					{
						break;
					}
					bool flag4 = array2 == null || array2.Length != num11;
					if (flag4)
					{
						array2 = new byte[num11];
					}
					Class22.ReadProcessMemory(int_, uint_4, array2, num11, ref num2);
					Class22.WriteProcessMemory(int_, num8 + Class53.gstruct51_251.uint_0, array2, num11, ref num2);
					Thread.Sleep(80);
					num9++;
				}
				while (num9 < 1000);
				array[0] = 0;
				Class22.WriteProcessMemory(int_, uint_, array, 1, ref num2);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00017770 File Offset: 0x00015970
		public static string smethod_7(GStruct49 gstruct49_0)
		{
			uint uint_ = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_189.uint_0;
			return Class22.smethod_28(uint_, gstruct49_0.int_137, 40);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000177B4 File Offset: 0x000159B4
		public static byte[] smethod_8(GStruct49 gstruct49_0, int int_2 = -1)
		{
			uint uint_ = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137) + Class53.gstruct51_189.uint_0;
			bool flag = int_2 <= 0;
			if (flag)
			{
				int_2 = 8;
			}
			int num = 0;
			byte[] array = new byte[int_2];
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num);
			return array;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00017814 File Offset: 0x00015A14
		public static uint smethod_9(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_189.uint_0;
			uint uint_ = num3 + 40U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
			return BitConverter.ToUInt32(array, 0);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00017880 File Offset: 0x00015A80
		public static string smethod_10(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint num3 = num2 + Class53.gstruct51_189.uint_0;
			uint uint_ = num3 + 60U;
			return Class22.smethod_28(uint_, gstruct49_0.int_137, 40);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000178E4 File Offset: 0x00015AE4
		public static bool smethod_11(GStruct49 gstruct49_0, uint uint_3)
		{
			bool flag = gstruct49_0.uint_16 == 0U || Class53.gstruct51_196.uint_0 == 0U || gstruct49_0.uint_89 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = Class22.smethod_31(gstruct49_0.uint_89 + 2U, gstruct49_0.int_137, uint_3, 4);
				result = (flag2 && Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_89));
			}
			return result;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0001794C File Offset: 0x00015B4C
		public static bool smethod_12(GStruct49 gstruct49_0, string string_1 = null, uint uint_3 = 32769U, uint uint_4 = 4U, uint uint_5 = 0U)
		{
			bool flag = gstruct49_0.uint_93 == 0U || Class53.gstruct51_191.uint_0 == 0U;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = string_1 == null || !(string_1 != string.Empty);
				if (flag2)
				{
					string_1 = Class26.smethod_10(gstruct49_0);
					bool flag3 = string_1 == null || !(string_1 != string.Empty);
					if (flag3)
					{
						uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
						Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
						GStruct51 gstruct51_ = Class53.gstruct51_15;
						uint num2 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
						int i = 0;
						uint num3 = 0U;
						byte[] array = new byte[15];
						for (;;)
						{
							num3 += 1U;
							bool flag4 = Class12.bool_0 || num3 > 255U;
							if (flag4)
							{
								break;
							}
							uint num4 = num2 + num3 * Class53.gstruct51_15.uint_0;
							bool flag5 = Class22.smethod_30(num4 + Class53.gstruct51_52.uint_0, gstruct49_0.int_137) != 1U;
							if (!flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_89.uint_0, array, 1, ref i);
								bool flag6 = array[0] == 0;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_89.uint_0, array, array.Length, ref i);
									string text = Class10.smethod_3(array);
									i = 3;
									int length = text.Length;
									while (i < length)
									{
										bool flag7 = Class37.smethod_2(gstruct49_0).IndexOf("- l·nh") <= 0;
										if (!flag7)
										{
											goto IL_23B;
										}
										i++;
										text = Encoding.UTF7.GetString(array, 0, i);
										bool flag8 = Class70.smethod_75(gstruct49_0, text, uint_3, uint_4, uint_5);
										if (!flag8)
										{
											goto IL_237;
										}
										Thread.Sleep(300);
										string text2 = Class83.smethod_22(gstruct49_0);
										bool flag9 = text2 != null && text2.IndexOf("kh«ng tån t¹i") <= 0;
										if (flag9)
										{
											Class83.smethod_23(gstruct49_0, "0K..");
											Thread.Sleep(300);
										}
										else
										{
											Class70.smethod_52(gstruct49_0, ".", 1);
										}
									}
								}
							}
						}
						return false;
						IL_237:
						return false;
						IL_23B:
						result = true;
					}
					else
					{
						result = Class70.smethod_75(gstruct49_0, string_1, 32769U, 4U, 0U);
					}
				}
				else
				{
					result = Class70.smethod_75(gstruct49_0, string_1, 32769U, 4U, 0U);
				}
			}
			return result;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00017BD8 File Offset: 0x00015DD8
		public static void smethod_13()
		{
			int int_ = Class26.int_1;
			Class26.int_1 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_17;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_49 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_49;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_49 = true;
						flag = true;
					}
					Class26.smethod_14(int_);
				}
				catch
				{
				}
				Thread.Sleep(600);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00017CB8 File Offset: 0x00015EB8
		private static void smethod_14(int int_2)
		{
			GStruct49 gstruct = default(GStruct49);
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[4];
			long long_ = 0L;
			long long_2 = 0L;
			bool flag = false;
			for (;;)
			{
				Thread.Sleep(400);
				num--;
				bool flag2 = Class12.bool_0;
				if (flag2)
				{
					break;
				}
				bool flag3 = num <= 0;
				if (flag3)
				{
					num = 3;
					int num3 = Class81.smethod_3(Form1.gstruct49_0, int_2);
					bool flag4 = num3 < 0 || !Form1.gstruct49_0[num3].bool_17;
					if (flag4)
					{
						break;
					}
					gstruct = Form1.gstruct49_0[num3];
					bool flag5 = Class12.smethod_28(long_) > 45000L;
					if (flag5)
					{
						Class70.smethod_52(gstruct, "<bclr=blue><color=green>Tù ®éng cho phÐp vµo bang khi cã ac xin gia nhËp bang héi.", 1);
						long_ = Class12.smethod_27();
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_165.uint_0, array, 4, ref num2);
					uint num4 = BitConverter.ToUInt32(array, 0);
					bool flag6 = num4 == 0U;
					if (!flag6)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num4 + Class53.gstruct51_167.uint_0, array, 4, ref num2);
						uint num5 = BitConverter.ToUInt32(array, 0);
						bool flag7 = num5 == 0U;
						if (!flag7)
						{
							string text = string.Empty;
							for (uint num6 = 0U; num6 < 9U; num6 += 1U)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num5 + num6 * 4U, array, 4, ref num2);
								uint num7 = BitConverter.ToUInt32(array, 0);
								bool flag8 = num7 == 0U;
								if (!flag8)
								{
									text = Class22.smethod_28(num7, gstruct.int_137, 45);
									bool flag9 = text == null || text == string.Empty;
									if (!flag9)
									{
										string text2 = text.ToLower();
										bool flag10 = text2.IndexOf("p gia nh") <= 0 || text2.IndexOf("p bang h") <= 0;
										if (!flag10)
										{
											Class70.smethod_52(gstruct, "<bclr=blue><color=yellow>" + text, 1);
											Thread.Sleep(300);
											bool flag11 = FormRaovat.string_0 != null;
											if (flag11)
											{
												for (int i = 0; i < FormRaovat.string_0.Length; i++)
												{
													bool flag12 = 0 > text.IndexOf(FormRaovat.string_0[i]);
													if (!flag12)
													{
														Class70.smethod_50(gstruct, FormRaovat.string_0[i], "§i chç kh¸c ch¬i cho tui mÇn viÖc !");
														Thread.Sleep(600);
														flag = true;
														goto IL_290;
													}
												}
											}
											Class70.smethod_16(gstruct, num7, 1);
											Thread.Sleep(1500);
											flag = true;
										}
									}
								}
							}
							IL_290:
							bool flag13 = !flag && Class12.smethod_28(long_2) <= 45000L;
							if (!flag13)
							{
								for (int j = 0; j < 10; j++)
								{
									bool flag14 = Class52.smethod_2(gstruct, false) == string.Empty;
									if (flag14)
									{
										break;
									}
									Class70.smethod_12(gstruct.int_137, gstruct.uint_55);
									Thread.Sleep(150);
								}
								long_2 = Class12.smethod_27();
								flag = false;
							}
						}
					}
				}
				else
				{
					Thread.Sleep(400);
				}
			}
		}

		// Token: 0x040000BE RID: 190
		private static uint uint_0 = 260U;

		// Token: 0x040000BF RID: 191
		private static uint uint_1 = 28U;

		// Token: 0x040000C0 RID: 192
		public static bool bool_0 = false;

		// Token: 0x040000C1 RID: 193
		public static int int_0 = 0;

		// Token: 0x040000C2 RID: 194
		public static uint uint_2 = 0U;

		// Token: 0x040000C3 RID: 195
		public static long long_0 = 0L;

		// Token: 0x040000C4 RID: 196
		public static string string_0 = null;

		// Token: 0x040000C5 RID: 197
		public static int int_1 = 0;
	}
}
