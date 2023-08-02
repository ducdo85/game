using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000028 RID: 40
	internal class Class44
	{
		// Token: 0x0600028E RID: 654 RVA: 0x0006F9A4 File Offset: 0x0006DBA4
		public static void smethod_0()
		{
			for (;;)
			{
				try
				{
					bool flag = Class12.bool_0;
					if (flag)
					{
						break;
					}
					Class44.smethod_1();
				}
				catch
				{
				}
				Thread.Sleep(999);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0006F9F0 File Offset: 0x0006DBF0
		public static void smethod_1()
		{
			GStruct49 gstruct = default(GStruct49);
			GStruct33 gstruct2 = default(GStruct33);
			uint[] array = gstruct2.uint_4 = new uint[2];
			Class44.gstruct33_0 = gstruct2;
			int num = -1;
			int num2 = -1;
			int num3 = 0;
			string[] array2 = new string[]
			{
				"<color=yellow>Ac chÝnh: XXX bÞ mÊt kÕt nèi.",
				"<color=yellow>Ac chÝnh: XXX ®ang ho¹t ®éng."
			};
			long long_ = 0L;
			long long_2 = 0L;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			byte[] byte_ = new byte[1];
			byte[] byte_2 = new byte[2];
			byte[] array3 = new byte[4];
			while (!Class12.bool_0)
			{
				Thread.Sleep(200);
				bool flag = Class12.smethod_28(long_2) > 6000L;
				if (flag)
				{
					Class44.uint_0 = Class44.smethod_2();
					long_2 = Class12.smethod_27();
					Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_2 * 4U, byte_, 1, ref num4);
					Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_3 * 4U, byte_2, 2, ref num4);
				}
				bool flag2 = Form1.int_52 != 0;
				if (flag2)
				{
					bool flag3 = Form1.int_6 > 0 || Form1.int_7 > 0;
					if (flag3)
					{
						bool flag4 = Form1.int_6 <= 0 && Form1.int_7 > 0;
						if (flag4)
						{
							FormMayphu.smethod_5(gstruct);
						}
						bool flag5 = Class44.gstruct33_1.int_9 > 0;
						if (flag5)
						{
							Class44.smethod_8(Class44.gstruct33_1.int_9);
						}
						bool flag6 = Class12.smethod_28(long_) > 30000L;
						if (flag6)
						{
							Class83.smethod_32(gstruct, 0U);
							long_ = Class12.smethod_27();
						}
						Class44.gstruct33_1.int_9 = 0;
					}
					bool flag7 = num != gstruct.int_136;
					if (flag7)
					{
						num = gstruct.int_136;
						Class44.smethod_3();
						Class44.smethod_4("<color=yellow>Ac chÝnh: " + gstruct.string_22);
						num3 = -100;
					}
					num3--;
					bool flag8 = num3 <= 0;
					if (flag8)
					{
						int num7 = Class81.smethod_3(Form1.gstruct49_0, Form1.int_52);
						bool flag9 = num7 < 0 || Class22.smethod_52(Form1.gstruct49_0[num7].process_0);
						if (flag9)
						{
							Form1.int_52 = 0;
							continue;
						}
						gstruct = Form1.gstruct49_0[num7];
						num3 = 10;
					}
					Class44.gstruct33_0.uint_1 = gstruct.uint_7;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num4);
					uint num8 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_13.uint_0, array3, 4, ref num4);
					uint num9 = BitConverter.ToUInt32(array3, 0);
					uint num10 = num9 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num4);
					uint num11 = BitConverter.ToUInt32(array3, 0);
					uint num12 = num11 + num10;
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_50.uint_0, array3, 4, ref num4);
					Class44.gstruct33_0.int_6 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num4);
					int num13 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num4);
					uint num14 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num4);
					uint num15 = BitConverter.ToUInt32(array3, 0);
					bool flag10 = num13 <= 0 || num14 == 0U || num15 == 0U;
					if (flag10)
					{
						Thread.Sleep(10);
						continue;
					}
					bool flag11 = Class44.gstruct33_0.int_6 <= 0 && num5 <= 60;
					if (flag11)
					{
						num5++;
						Thread.Sleep(10);
						continue;
					}
					num5 = 0;
					bool flag12 = num2 != Class44.gstruct33_0.int_6;
					if (flag12)
					{
						bool flag13 = Class44.gstruct33_0.int_6 <= 0;
						if (flag13)
						{
							Class44.gstruct33_0.bool_0 = true;
							num6++;
							bool flag14 = num6 < 3;
							if (flag14)
							{
								continue;
							}
						}
						num2 = Class44.gstruct33_0.int_6;
						Class44.smethod_4(array2[num2].Replace("XXX", gstruct.string_22));
					}
					num6 = 0;
					Class44.gstruct33_0.int_0 = gstruct.int_136;
					Class44.gstruct33_0.int_1 = gstruct.int_137;
					Class44.gstruct33_0.process_0 = gstruct.process_0;
					Class44.gstruct33_0.uint_0 = gstruct.uint_4;
					Class44.gstruct33_0.uint_2 = Class22.smethod_30(num12, gstruct.int_137);
					bool flag15 = Form1.int_6 > 0 || Form1.int_7 > 0;
					if (flag15)
					{
						Class44.gstruct33_0.uint_5 = Class44.gstruct33_1.uint_5;
						Class44.gstruct33_0.int_7 = Class44.gstruct33_1.int_7;
					}
					else
					{
						Class44.gstruct33_0.uint_5 = Class83.smethod_6(gstruct);
					}
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_43.uint_0, array3, 4, ref num4);
					Class44.gstruct33_0.int_3 = BitConverter.ToInt32(array3, 0);
					bool flag16 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 > 0;
					if (flag16)
					{
						Class44.gstruct33_0.int_2 = Class44.gstruct33_1.int_2;
					}
					else
					{
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_56.uint_0, array3, 4, ref num4);
						Class44.gstruct33_0.int_2 = BitConverter.ToInt32(array3, 0);
					}
					Class44.gstruct33_0.long_0 = Class12.smethod_27();
					bool flag17 = Class44.gstruct33_0.uint_4 == null;
					if (flag17)
					{
						Class44.gstruct33_0.uint_4 = new uint[2];
					}
					Class44.gstruct33_0.uint_4[0] = num14;
					Class44.gstruct33_0.uint_4[1] = num15;
					Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_54.uint_0, array3, 4, ref num4);
					Class44.gstruct33_0.int_5 = BitConverter.ToInt32(array3, 0);
					Class44.gstruct33_0.string_0 = Class22.smethod_28(num12 + Class53.gstruct51_16.uint_0, gstruct.int_137, 32);
					bool flag18 = num13 != Class44.gstruct33_0.int_4;
					if (flag18)
					{
						Class44.gstruct33_0.int_4 = num13;
						Class44.smethod_3();
					}
					Class44.gstruct33_0.bool_0 = (num11 == 0U || Class44.gstruct33_0.int_6 == 0 || Class44.gstruct33_0.int_4 == 0 || Class44.gstruct33_0.string_0 == string.Empty || Class44.gstruct33_0.string_1 == string.Empty);
					bool flag19 = Class44.gstruct33_0.int_4 != 162;
					if (flag19)
					{
						bool flag20 = Class44.gstruct33_0.int_4 != 321;
						if (flag20)
						{
							Class44.gstruct33_0.string_1 = Class22.smethod_28(gstruct.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct.int_137, 48);
						}
						else
						{
							Class44.gstruct33_0.string_1 = "Tr­êng B¹ch s¬n Nam";
						}
					}
					else
					{
						Class44.gstruct33_0.string_1 = "§¹i Lý";
					}
					uint uint_ = 0U;
					bool flag21 = Class44.gstruct33_0.int_3 > 0;
					if (flag21)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num12 + Class53.gstruct51_72.uint_0, array3, 4, ref num4);
						uint num16 = BitConverter.ToUInt32(array3, 0);
						bool flag22 = num16 > 0U;
						if (flag22)
						{
							uint num17 = num11 + num16 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_50.uint_0, array3, 4, ref num4);
							bool flag23 = BitConverter.ToUInt32(array3, 0) > 0U;
							if (flag23)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num17 + Class53.gstruct51_52.uint_0, array3, 4, ref num4);
								uint num18 = BitConverter.ToUInt32(array3, 0);
								bool flag24 = num18 <= 1U;
								if (flag24)
								{
									uint_ = Class22.smethod_30(num17, gstruct.int_137);
								}
							}
						}
					}
					Class44.gstruct33_0.uint_3 = uint_;
				}
				else
				{
					bool flag25 = Class76.gstruct49_0.int_136 > 0;
					if (flag25)
					{
						Class44.gstruct33_0.uint_5 = Class83.smethod_6(Class76.gstruct49_0);
						uint[] array4 = Class36.smethod_30(Class76.gstruct49_0);
						bool flag26 = array4 != null;
						if (flag26)
						{
							Class44.gstruct33_0.uint_4 = new uint[]
							{
								array4[0],
								array4[1]
							};
						}
					}
					Class44.gstruct33_0.int_0 = 0;
					Class44.gstruct33_0.uint_2 = 0U;
					Class44.gstruct33_0.uint_3 = 0U;
					Class44.gstruct33_0.int_4 = 0;
					Class44.gstruct33_0.bool_0 = false;
					num = -1;
				}
				Class22.WriteProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_4 * 4U, byte_, 1, ref num4);
				Class22.WriteProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_5 * 4U, byte_2, 2, ref num4);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0007031C File Offset: 0x0006E51C
		private static uint[] smethod_2()
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				bool flag2 = Form1.gstruct49_0.Length != 0;
				if (flag2)
				{
					uint[] array = new uint[Form1.gstruct49_0.Length];
					for (int i = 0; i < array.Length; i++)
					{
						GStruct49 gstruct = Form1.gstruct49_0[i];
						uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
						uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, gstruct.int_137);
						uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
						uint uint_ = num3 + num2 * Class53.gstruct51_15.uint_0;
						array[i] = Class22.smethod_30(uint_, gstruct.int_137);
					}
					return array;
				}
			}
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00070408 File Offset: 0x0006E608
		private static void smethod_3()
		{
			try
			{
				bool flag = Form1.gstruct49_0 == null;
				if (!flag)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag2 = Form1.gstruct49_0[i].int_136 != Class44.gstruct33_0.int_0;
						if (flag2)
						{
							Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_17, 1, 4);
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00070490 File Offset: 0x0006E690
		private static void smethod_4(string string_0)
		{
			bool flag = Form1.int_65 > 0 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						int num = 0;
						while (Form1.gstruct49_0[i].bool_2 && num < 30)
						{
							Thread.Sleep(10);
							num++;
						}
						bool flag2 = !Form1.gstruct49_0[i].bool_2;
						if (flag2)
						{
							Class70.smethod_52(Form1.gstruct49_0[i], string_0, 1);
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0007054C File Offset: 0x0006E74C
		public static int smethod_5(uint uint_1, ref uint[] uint_2, ref uint uint_3)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_11.uint_0, Class44.gstruct33_0.int_1);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_13.uint_0, Class44.gstruct33_0.int_1) * Class53.gstruct51_15.uint_0;
			uint num3 = Class22.smethod_30(Class53.gstruct51_14.uint_0, Class44.gstruct33_0.int_1);
			uint num4 = num3 + num2;
			uint num5 = num3 + uint_3 * Class53.gstruct51_15.uint_0;
			uint num6 = Class22.smethod_30(num5, Class44.gstruct33_0.int_1);
			uint num7 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, Class44.gstruct33_0.int_1);
			uint num8 = Class22.smethod_30(num4 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, Class44.gstruct33_0.int_1);
			bool flag = num7 == 0U || num8 == 0U;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				bool flag2 = Class44.gstruct33_0.uint_4 == null;
				if (flag2)
				{
					Class44.gstruct33_0.uint_4 = new uint[2];
				}
				Class44.gstruct33_0.uint_4[0] = num7;
				Class44.gstruct33_0.uint_4[1] = num8;
				bool flag3 = num6 != uint_1;
				if (flag3)
				{
					int num9 = 0;
					byte[] array = new byte[4];
					uint num10 = Class44.gstruct33_0.uint_1;
					bool flag4 = num10 == 0U;
					if (flag4)
					{
						num10 = 4194304U;
					}
					uint uint_4 = num10 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
					Class22.ReadProcessMemory(Class44.gstruct33_0.int_1, uint_4, array, 4, ref num9);
					bool flag5 = num9 != 4;
					if (flag5)
					{
						return 0;
					}
					int num11 = BitConverter.ToInt32(array, 0);
					bool flag6 = num11 <= 1;
					if (flag6)
					{
						return 0;
					}
					int num12 = (int)Class22.smethod_30(num + Class53.gstruct51_13.uint_0, Class44.gstruct33_0.int_1);
					int num13 = 0;
					uint_3 = 0U;
					for (uint num14 = 1U; num14 < 256U; num14 += 1U)
					{
						bool flag7 = num14 % 50U == 0U;
						if (flag7)
						{
							Thread.Sleep(10);
						}
						bool flag8 = num11 <= num13;
						if (flag8)
						{
							break;
						}
						bool flag9 = (ulong)num14 == (ulong)((long)num12);
						if (flag9)
						{
							num13++;
						}
						else
						{
							num5 = num3 + num14 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(Class44.gstruct33_0.int_1, num5 + Class53.gstruct51_16.uint_0, array, 4, ref num9);
							bool flag10 = array[0] == 0 || num9 != 4;
							if (!flag10)
							{
								num13++;
								Class22.ReadProcessMemory(Class44.gstruct33_0.int_1, num5 + Class53.gstruct51_50.uint_0, array, 4, ref num9);
								bool flag11 = num9 == 4 && BitConverter.ToInt32(array, 0) > 0;
								if (flag11)
								{
									num6 = Class22.smethod_30(num5, Class44.gstruct33_0.int_1);
									bool flag12 = uint_1 == num6;
									if (flag12)
									{
										uint_3 = num14;
										break;
									}
								}
							}
						}
					}
					bool flag13 = uint_3 == 0U;
					if (flag13)
					{
						return -1;
					}
				}
				long num15 = Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4);
				uint_2 = new uint[]
				{
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, Class44.gstruct33_0.int_1),
					Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, Class44.gstruct33_0.int_1)
				};
				long num16 = Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4);
				int num17 = Form1.int_23;
				bool flag14 = num17 < 200;
				if (flag14)
				{
					num17 = 200;
				}
				bool flag15 = num16 - num15 > 22500L && (long)(num17 * num17) <= num16 && num16 <= 1000000L;
				if (flag15)
				{
					result = 1;
				}
				else
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00070954 File Offset: 0x0006EB54
		public static void smethod_6(GStruct49 gstruct49_0, uint[] uint_1, uint[] uint_2, bool bool_2 = false)
		{
			bool flag = uint_2 != null && uint_2[0] != 0U && uint_2[1] > 0U;
			if (flag)
			{
				bool flag2 = uint_1 != null && uint_1[0] != 0U && uint_1[1] > 0U;
				long num = Class60.smethod_18(uint_1, uint_2);
				bool flag3 = flag2 && (bool_2 || num < 14400L);
				if (flag3)
				{
					uint[] uint_3 = Class60.smethod_5(uint_1, uint_2, -150);
					Class70.smethod_61(gstruct49_0, uint_3);
				}
				else
				{
					Class70.smethod_61(gstruct49_0, uint_2);
				}
				Thread.Sleep(60);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000709D8 File Offset: 0x0006EBD8
		public static bool smethod_7(GStruct49 gstruct49_0, ref int int_1)
		{
			bool flag = Class76.gstruct49_0.int_136 != gstruct49_0.int_136;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = Form1.int_63 > 0;
				if (flag2)
				{
					result = (48 < Class44.gstruct33_0.int_7 && Class44.gstruct33_0.int_7 < 58);
				}
				else
				{
					int num = Class83.smethod_3(gstruct49_0);
					bool flag3 = int_1 != num;
					int_1 = num;
					result = flag3;
				}
			}
			return result;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00070A4C File Offset: 0x0006EC4C
		public static void smethod_8(int int_1)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				int num = 0;
				while (Form1.gstruct49_0.Length > num)
				{
					bool flag2 = !Form1.gstruct49_0[num].bool_25;
					if (!flag2)
					{
						bool flag3 = int_1 == 1 || int_1 == 2;
						if (flag3)
						{
							Form1.gstruct49_0[num].int_76[4] = int_1;
						}
						else
						{
							bool flag4 = int_1 != 3 && int_1 != 4;
							if (flag4)
							{
								bool flag5 = int_1 != 5;
								if (flag5)
								{
									bool flag6 = 100 > int_1 || int_1 > 102;
									if (flag6)
									{
										if (int_1 != 103)
										{
											if (int_1 == 104)
											{
												for (int i = 0; i < 100; i++)
												{
													bool flag7 = Class44.int_0 <= 0;
													if (flag7)
													{
														break;
													}
													Thread.Sleep(1);
												}
												Class44.int_0 = Form1.gstruct49_0[num].int_136;
												new Thread(new ThreadStart(Class44.smethod_9)).Start();
											}
										}
										else
										{
											int num2 = 0;
											byte[] byte_ = new byte[]
											{
												Convert.ToByte(Form1.gstruct49_0[num].bool_25)
											};
											Class22.WriteProcessMemory(Form1.gstruct49_0[num].int_137, Form1.gstruct49_0[num].uint_15 + Class70.uint_33 * 4U, byte_, 1, ref num2);
										}
									}
									else
									{
										Form1.int_104 = int_1 - 100;
										Class12.smethod_37(ref Class41.int_0, Form1.gstruct49_0[num].int_136);
										bool flag8 = !Class41.bool_0;
										if (flag8)
										{
											Class41.smethod_0();
										}
									}
								}
								else
								{
									new Thread(new ThreadStart(FormClickNPC.smethod_1)).Start();
								}
							}
							else
							{
								Form1.int_104 = int_1;
								Form1.gstruct49_0[num].bool_55 = Form1.gstruct49_0[num].bool_25;
							}
						}
					}
					num++;
				}
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00070C68 File Offset: 0x0006EE68
		private static void smethod_9()
		{
			int num = Class44.int_0;
			Class44.int_0 = 0;
			int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag = 0 <= num2;
			if (flag)
			{
				Class60.smethod_14(Form1.gstruct49_0[num2], true);
			}
		}

		// Token: 0x04000163 RID: 355
		public static GStruct33 gstruct33_0;

		// Token: 0x04000164 RID: 356
		public static GStruct33 gstruct33_1;

		// Token: 0x04000165 RID: 357
		public static bool bool_0;

		// Token: 0x04000166 RID: 358
		public static bool bool_1;

		// Token: 0x04000167 RID: 359
		public static uint[] uint_0;

		// Token: 0x04000168 RID: 360
		private static int int_0;
	}
}
