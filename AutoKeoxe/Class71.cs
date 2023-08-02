using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000045 RID: 69
	internal class Class71
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x000C2CF8 File Offset: 0x000C0EF8
		public static void smethod_0(int int_0)
		{
			for (;;)
			{
				try
				{
					Class71.smethod_1(int_0);
					break;
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000C2D30 File Offset: 0x000C0F30
		public static void smethod_1(int int_0)
		{
			int num = 0;
			int num2 = 0;
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			string text = "V¹n Sù Th«ng";
			uint[] array = new uint[]
			{
				49893U,
				99823U
			};
			uint[] array2 = null;
			int num3 = 0;
			byte[] byte_ = new byte[4];
			byte[] array3 = new byte[4];
			bool flag = false;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				Thread.Sleep(400);
				int num4 = Class81.smethod_3(Form1.gstruct49_0, int_0);
				bool flag2 = Class12.bool_0 || num4 < 0 || !Form1.gstruct49_0[num4].bool_25 || !Form1.gstruct49_0[num4].bool_54;
				if (flag2)
				{
					break;
				}
				gstruct = Form1.gstruct49_0[num4];
				bool flag3 = flag;
				if (flag3)
				{
					long num5 = Class12.smethod_28(long_3);
					bool flag4 = num5 < (long)(Form1.int_43 * 1000);
					if (flag4)
					{
						long num6 = (long)Form1.int_43 - num5 / 1000L;
						bool flag5 = Class12.smethod_28(long_4) > 1000L;
						if (flag5)
						{
							bool bool_ = num6 > 3L;
							Class83.smethod_31(gstruct, num2.ToString() + ". Tiep theo con: " + num6.ToString() + " giay...", bool_, 3U);
							long_4 = Class12.smethod_27();
						}
						continue;
					}
				}
				bool flag6 = Form1.string_8 == null || Form1.string_8 == string.Empty;
				if (flag6)
				{
					bool flag7 = Class12.smethod_28(long_) > 15000L;
					if (flag7)
					{
						Class70.smethod_52(gstruct, "<color=yellow>Chua co thiet lap ten ac can tim", 1);
						long_ = Class12.smethod_27();
					}
					Thread.Sleep(150);
				}
				else
				{
					uint num7 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num8 = Class22.smethod_30(num7 + Class53.gstruct51_13.uint_0, gstruct.int_137);
					uint num9 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num10 = num9 + num8 * Class53.gstruct51_15.uint_0;
					int num11 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
					int num12 = (int)Class22.smethod_30(num10 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					int num13 = (int)Class22.smethod_30(num10 + Class53.gstruct51_55.uint_0, gstruct.int_137);
					int num14 = (int)Class22.smethod_30(num10 + Class53.gstruct51_50.uint_0, gstruct.int_137);
					int num15 = Class83.smethod_39(gstruct);
					bool flag8 = num13 == 10 || num13 == 21 || num14 == 0 || num15 <= 1;
					if (!flag8)
					{
						int num16 = num11;
						int num17 = num16;
						if (num17 != 53)
						{
							if (num17 != 54)
							{
								bool flag9 = Class35.smethod_140(gstruct, "Ba L¨ng huyÖn", null, null, false);
								if (flag9)
								{
									continue;
								}
							}
							else
							{
								uint[] uint_ = new uint[]
								{
									Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								long num18 = Class60.smethod_18(uint_, array);
								bool flag10 = num18 > 90000L;
								if (flag10)
								{
									bool flag11 = Class12.smethod_28(long_2) > 3000L;
									if (flag11)
									{
										Class14.smethod_1(gstruct, array);
										long_2 = Class12.smethod_27();
									}
									continue;
								}
								int num19 = 0;
								do
								{
									bool flag12 = num18 > 22500L;
									if (!flag12)
									{
										goto IL_3F6;
									}
									Class70.smethod_61(gstruct, array);
									Thread.Sleep(300);
									uint_ = new uint[]
									{
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
										Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
									};
									num18 = Class60.smethod_18(uint_, array);
									num19++;
								}
								while (num19 <= 10);
								continue;
								IL_3F6:
								bool flag13 = num > 0;
								if (flag13)
								{
									string text2 = Class98.smethod_16(gstruct, num, ref array2, text.Length + 10);
									bool flag14 = text2 == null || !Class12.smethod_2(text2, text, false);
									if (flag14)
									{
										num = 0;
										array2 = null;
										Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_72.uint_0, byte_, 4, ref num3);
									}
								}
								bool flag15 = num <= 0;
								if (flag15)
								{
									num = Class98.smethod_15(gstruct, text, ref array2, 3, true, -1, null);
									bool flag16 = num <= 0;
									if (flag16)
									{
										Class60.smethod_12(gstruct, true);
										text = Class71.smethod_2(gstruct);
										continue;
									}
								}
								num18 = Class60.smethod_18(uint_, array2);
								bool flag17 = num18 > 22500L;
								if (flag17)
								{
									Class70.smethod_61(gstruct, array2);
									Thread.Sleep(150);
								}
								Class86.smethod_8(gstruct, -1);
								Class86.Class89.smethod_1(gstruct, null);
								Thread.Sleep(100);
								byte[] bytes = BitConverter.GetBytes(num);
								Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_72.uint_0, bytes, 4, ref num3);
								Thread.Sleep(300);
								string text3 = string.Empty;
								num19 = 0;
								for (;;)
								{
									bool flag18 = !Class12.bool_0;
									if (!flag18)
									{
										goto IL_5D3;
									}
									Thread.Sleep(100);
									text3 = Class86.Class89.smethod_0(gstruct);
									int num20 = Class86.smethod_1(gstruct, -1);
									bool flag19 = num20 <= 0;
									if (!flag19)
									{
										goto IL_5D2;
									}
									bool flag20 = text3 == null || !(text3 != string.Empty);
									if (!flag20)
									{
										goto IL_5A6;
									}
									bool flag21 = num19 > 15;
									if (flag21)
									{
										goto Block_30;
									}
								}
								continue;
								IL_5D3:
								string b = Class86.smethod_2(gstruct, -1);
								Class86.Class89.smethod_1(gstruct, null);
								Class86.smethod_5(gstruct, gstruct.int_135);
								Thread.Sleep(300);
								num19 = 0;
								uint num21 = 0U;
								while (num21 == 0U && num19 < 10)
								{
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_7 + Class53.gstruct51_172.uint_0, array3, 4, ref num3);
									num21 = BitConverter.ToUInt32(array3, 0);
									Thread.Sleep(100);
									num19++;
								}
								text3 = Class86.Class89.smethod_0(gstruct);
								bool flag22 = Class12.smethod_2(text3, "chäc ghÑo ta", false);
								if (flag22)
								{
									Class22.smethod_4(gstruct.uint_4, 32U);
									Class70.smethod_37(gstruct, 20000U);
									Thread.Sleep(300);
									continue;
								}
								Class86.Class89.smethod_1(gstruct, null);
								Class45.smethod_5(gstruct, Form1.string_8, true);
								num19 = 0;
								string text4 = null;
								for (;;)
								{
									bool flag23 = !Class12.bool_0;
									if (!flag23)
									{
										goto IL_74A;
									}
									text3 = Class86.Class89.smethod_0(gstruct);
									text4 = Class86.Class88.smethod_1(gstruct);
									bool flag24 = !(text3 != string.Empty) && (!(text4 != string.Empty) || !(text4 != b));
									if (!flag24)
									{
										goto IL_749;
									}
									num19++;
									Thread.Sleep(100);
									bool flag25 = num19 > 15;
									if (flag25)
									{
										goto Block_38;
									}
								}
								continue;
								IL_74A:
								string text5 = null;
								string text6 = null;
								string text7 = "|" + Form1.string_8 + "| kh«ng râ tung tÝch n¬i ®©u.";
								try
								{
									int num22 = Class12.smethod_1(text4, "\0");
									bool flag26 = 0 <= num22;
									if (flag26)
									{
										string text8 = text4.Substring(num22 + 2);
										int num23 = Class12.smethod_1(text8, "\u0003,");
										bool flag27 = 0 > num23;
										if (flag27)
										{
											bool flag28 = text8 != null && text8 != string.Empty;
											if (flag28)
											{
												num19 = 0;
												int num24 = 0;
												while (num24 < text8.Length && text8[num24] >= ' ' && text8[num24] <= 'ú')
												{
													num19++;
													num24++;
												}
												bool flag29 = num19 == 0;
												if (flag29)
												{
													num19 = text8.Length;
												}
												text6 = "Không rõ vị trí";
												text5 = text8.Substring(0, num19).Trim();
												Class71.string_0 = new string[]
												{
													text5,
													text6
												};
											}
										}
										else
										{
											text5 = text8.Substring(0, num23).Trim();
											int num25 = Class12.smethod_1(text8, "(");
											int num26 = Class12.smethod_1(text8, ")");
											bool flag30 = 0 <= num25 && num25 < num26;
											if (flag30)
											{
												text6 = text8.Substring(num25 + 1, num26 - num25 - 1).Replace(" ", "");
												Class71.string_0 = new string[]
												{
													text5,
													text6
												};
											}
										}
									}
								}
								catch
								{
								}
								bool flag31 = text5 != null && text6 != null;
								if (flag31)
								{
									text7 = string.Concat(new string[]
									{
										"|",
										Form1.string_8,
										"| ë (",
										text6,
										") ",
										text5
									});
								}
								bool flag32 = Form1.gstruct49_0 != null;
								if (flag32)
								{
									for (int i = 0; i < Form1.gstruct49_0.Length; i++)
									{
										bool flag33 = gstruct.string_22 != Form1.gstruct49_0[i].string_22;
										if (flag33)
										{
											Class70.smethod_50(gstruct, Form1.gstruct49_0[i].string_22, text7);
										}
									}
								}
								bool flag34 = Form1.int_41 > 0;
								if (flag34)
								{
									Class70.smethod_57(gstruct, "Chat('CH_TONG', '<color=yellow>" + text7 + "')");
									Thread.Sleep(300);
								}
								bool flag35 = Form1.int_42 > 0;
								if (flag35)
								{
									Class70.smethod_57(gstruct, "Chat('CH_CHATROOM', '" + text7 + "')");
									Thread.Sleep(300);
								}
								num2++;
								long_3 = Class12.smethod_27();
								flag = true;
								continue;
								IL_749:
								goto IL_74A;
								Block_38:
								Class60.smethod_12(gstruct, true);
								continue;
								IL_5D2:
								goto IL_5D3;
								IL_5A6:
								Class22.smethod_4(gstruct.uint_4, 32U);
								Class70.smethod_37(gstruct, 20000U);
								Thread.Sleep(300);
								continue;
								Block_30:
								Class60.smethod_12(gstruct, true);
								continue;
							}
						}
						bool flag36 = num12 <= 0;
						if (flag36)
						{
							Class50.smethod_2(gstruct, "Nam Nh¹c trÊn", null, null, 0);
						}
						else
						{
							Class60.smethod_14(gstruct, true);
						}
					}
				}
			}
			Class70.smethod_52(gstruct, "<color=green>Ket thuc Van su thong !", 1);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000C37EC File Offset: 0x000C19EC
		private static string smethod_2(GStruct49 gstruct49_0)
		{
			string text = "V¹n";
			uint[] uint_ = new uint[]
			{
				49893U,
				99823U
			};
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
			Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
			int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			bool flag = num6 == 54;
			string result;
			if (flag)
			{
				Class22.smethod_30(num5 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
				uint[] array3 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
				};
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 4, ref num);
				int num7 = BitConverter.ToInt32(array, 0);
				bool flag2 = num7 > 1;
				if (flag2)
				{
					int num8 = 0;
					long num9 = 0L;
					uint[] array4 = new uint[2];
					string text2 = null;
					for (uint num10 = 1U; num10 < 256U; num10 += 1U)
					{
						bool flag3 = num7 <= num8;
						if (flag3)
						{
							break;
						}
						uint num11 = num4 + num10 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_16.uint_0, array, 4, ref num);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num8++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_52.uint_0, array, 4, ref num);
							uint num12 = BitConverter.ToUInt32(array, 0);
							bool flag5 = num12 == 3U;
							if (flag5)
							{
								uint[] array5 = new uint[2];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
								array5[0] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
								array5[1] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num);
								string text3 = Class10.smethod_3(array2);
								string string_ = text3.ToLower();
								bool flag6 = 0 <= Class12.smethod_1(string_, text.ToLower());
								if (flag6)
								{
									return text3;
								}
								long num13 = Class60.smethod_18(uint_, array5);
								bool flag7 = num13 < 40000L && (text2 == null || num13 < num9);
								if (flag7)
								{
									num9 = num13;
									array4[0] = array5[0];
									array4[1] = array5[1];
									text2 = text3;
								}
							}
						}
					}
					result = text2;
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

		// Token: 0x04000389 RID: 905
		public static string[] string_0;
	}
}
