using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200004F RID: 79
	internal class Class80
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x000DCD18 File Offset: 0x000DAF18
		public static void smethod_0(int int_0)
		{
			GStruct49 gstruct = default(GStruct49);
			new Random();
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int num6 = 0;
			int num7 = 0;
			bool flag5 = false;
			bool flag6 = false;
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			uint num8 = 0U;
			uint[] array = null;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			long num14 = 0L;
			long num15 = 0L;
			long long_4 = 0L;
			int num16 = 0;
			int num17 = 0;
			int num18 = 0;
			bool flag7 = false;
			bool flag8 = false;
			int num19 = 0;
			int num20 = 0;
			int num21 = -1;
			int[] array2 = new int[4];
			int num22 = 0;
			byte[] byte_ = new byte[4];
			byte[] array3 = new byte[4];
			string text = null;
			uint[,] array4 = new uint[7, 3];
			Class11.smethod_4(array4, 354318);
			uint[,] array5 = array4;
			int num23 = 0;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			int[] array6 = new int[10];
			int num24;
			for (int i = 0; i < array6.Length; i = num24 + 1)
			{
				array6[i] = 4;
				num24 = i;
			}
			for (;;)
			{
				uint num30;
				int num32;
				int num34;
				int num35;
				int num38;
				uint[] array7;
				for (;;)
				{
					IL_102:
					Thread.Sleep(200);
					int num25 = Class81.smethod_3(Form1.gstruct49_0, int_0);
					bool flag12 = Class12.bool_0 || num25 < 0 || Form1.int_20 != 2;
					if (flag12)
					{
						return;
					}
					gstruct = Form1.gstruct49_0[num25];
					bool flag13 = !gstruct.bool_25 || gstruct.bool_54 || gstruct.int_25 > 0 || gstruct.int_133[0] > 0 || gstruct.int_20[0] > 0;
					if (flag13)
					{
						return;
					}
					bool flag14 = !gstruct.bool_15 && Class70.smethod_3(gstruct, Class70.uint_48, 4) <= 0;
					if (!flag14)
					{
						goto IL_54EC;
					}
					bool flag15 = Form1.int_24 == 1;
					if (flag15)
					{
						goto Block_12;
					}
					bool flag16 = Form1.int_24 != 2;
					if (!flag16)
					{
						goto IL_54E0;
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array6[0]);
					uint num26 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_13.uint_0, array3, 4, ref array6[1]);
					uint num27 = BitConverter.ToUInt32(array3, 0);
					uint num28 = num27 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array6[2]);
					uint num29 = BitConverter.ToUInt32(array3, 0);
					num30 = num29 + num28;
					Class22.ReadProcessMemory(gstruct.int_137, num30, array3, 4, ref array6[3]);
					uint num31 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_55.uint_0, array3, 4, ref array6[4]);
					num32 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_50.uint_0, array3, 4, ref array6[5]);
					int num33 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array6[6]);
					num34 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_43.uint_0, array3, 4, ref array6[7]);
					num35 = BitConverter.ToInt32(array3, 0);
					int num36 = 7;
					int num37 = Class83.smethod_12(gstruct);
					bool flag17 = (gstruct.int_136 == Class76.gstruct49_0.int_136 || gstruct.int_136 == Class44.gstruct33_0.int_0) && (num37 == 1 || num37 == 2);
					if (flag17)
					{
						break;
					}
					bool flag18 = num20 <= 0;
					if (flag18)
					{
						array2[0] = 0;
						array2[1] = 0;
						array2[2] = 0;
						array2[3] = 0;
					}
					num20 = 0;
					num38 = Class83.smethod_39(gstruct);
					bool flag19 = num33 != 0 && num32 != 0 && num34 != 0 && num38 > 1 && num32 != 10 && num32 != 21;
					if (!flag19)
					{
						goto IL_54A9;
					}
					int j = 0;
					for (;;)
					{
						bool flag20 = j <= num36;
						if (!flag20)
						{
							break;
						}
						bool flag21 = array6[j] == 0;
						if (flag21)
						{
							goto Block_27;
						}
						num24 = j;
						j = num24 + 1;
					}
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num22);
					bool flag22 = array3[0] > 0;
					if (flag22)
					{
						flag = false;
						array3[0] = 0;
						Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num22);
					}
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num22);
					int num39 = (int)array3[0];
					bool flag23 = num39 > 0 || flag9;
					if (flag23)
					{
						goto Block_29;
					}
					array7 = new uint[]
					{
						Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
						Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
					};
					bool flag24 = array7[0] == 0U || array7[1] == 0U;
					if (!flag24)
					{
						bool flag25 = flag10;
						if (flag25)
						{
							goto Block_33;
						}
						bool flag26 = num == num34 && (num2 == Class44.gstruct33_0.int_4 || Form1.int_21 <= 0);
						if (!flag26)
						{
							goto IL_1D82;
						}
						bool flag27 = num4 != Form1.int_106;
						if (flag27)
						{
							flag5 = false;
							num7 = 0;
							num4 = Form1.int_106;
						}
						int num40 = 600;
						bool flag28 = gstruct.int_98 > 0;
						if (flag28)
						{
							num40 = gstruct.int_99;
						}
						Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num22);
						int num41 = BitConverter.ToInt32(array3, 0);
						int num42 = num41;
						bool flag29 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
						if (flag29)
						{
							num42 = gstruct.int_96;
						}
						bool flag30 = num42 <= 0;
						if (flag30)
						{
							num42 = 400;
						}
						Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_44 * 4U, array3, 1, ref num22);
						int num43 = (int)array3[0];
						bool flag31 = num43 > 0 && num42 > num41 && num41 > 0;
						if (flag31)
						{
							num42 = num41;
						}
						int num44 = Form1.int_23;
						bool flag32 = gstruct.int_136 != Class44.gstruct33_0.int_0;
						if (flag32)
						{
							bool flag33 = num42 <= 180 && num44 < Form1.int_51;
							if (flag33)
							{
								num44 = Form1.int_51;
							}
							bool flag34 = gstruct.int_131[0] > 0 && Form1.int_27 > 0 && num44 > 180;
							if (flag34)
							{
								num44 = 180;
							}
							bool flag35 = flag11;
							if (flag35)
							{
								bool flag36 = num35 > 0;
								if (flag36)
								{
									num44 = gstruct.gstruct48_0.int_9;
								}
								flag11 = false;
							}
						}
						uint[] uint_ = array7;
						bool bool_ = false;
						int num45 = 0;
						bool flag37 = false;
						bool flag38 = false;
						bool flag39 = (Form1.int_45 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_0 > 0 && 926 <= Class44.gstruct33_0.int_4 && Class44.gstruct33_0.int_4 <= 932 && num23 != Class44.gstruct33_0.int_4) || num4 != Form1.int_106;
						if (flag39)
						{
							flag5 = false;
							num7 = 0;
							num4 = Form1.int_106;
							num16 = 0;
							num23 = Class44.gstruct33_0.int_4;
						}
						bool flag40 = num3 != num35;
						if (flag40)
						{
							Thread.Sleep(100);
							array = null;
							num9 = 0;
							int num46 = 0;
							while (num35 == 0 && num46 < 30 && num35 != num3)
							{
								Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num22);
								bool flag41 = num22 == 4;
								if (flag41)
								{
									num26 = BitConverter.ToUInt32(array3, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_13.uint_0, array3, 4, ref num22);
									num27 = BitConverter.ToUInt32(array3, 0);
									num28 = num27 * Class53.gstruct51_15.uint_0;
									Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num22);
									bool flag42 = num22 == 4;
									if (flag42)
									{
										num29 = BitConverter.ToUInt32(array3, 0);
										num30 = num29 + num28;
										Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_43.uint_0, array3, 4, ref num22);
										num35 = BitConverter.ToInt32(array3, 0);
										Thread.Sleep(10);
										num24 = num46;
										num46 = num24 + 1;
										continue;
									}
								}
								goto IL_102;
							}
							goto Block_64;
						}
						goto IL_99B;
					}
				}
				bool flag43 = num19 > 0;
				if (flag43)
				{
					Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
				}
				bool flag44 = Form1.int_121 > 0;
				if (flag44)
				{
					Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num22);
				}
				num19 = 0;
				num20 = 0;
				continue;
				IL_54EC:
				flag = false;
				IL_54A6:
				Block_27:
				continue;
				Block_12:
				Class38.smethod_0(int_0);
				continue;
				IL_54E0:
				Class19.smethod_0(int_0);
				continue;
				IL_54A9:
				bool flag45 = num38 <= 1;
				if (flag45)
				{
					flag4 = false;
				}
				flag10 = (num32 == 10 || num32 == 21);
				Thread.Sleep(60);
				continue;
				Block_29:
				bool value = false;
				bool flag46 = num35 == 0;
				if (flag46)
				{
					value = (flag9 = (Class91.smethod_0(gstruct, true, null) != 1));
				}
				array3[0] = Convert.ToByte(value);
				Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num22);
				continue;
				Block_33:
				flag10 = false;
				Thread.Sleep(300);
				continue;
				Block_64:
				num3 = num35;
				bool flag47 = num35 <= 0;
				if (flag47)
				{
					Thread.Sleep(150);
					Class86.smethod_8(gstruct, -1);
					continue;
				}
				IL_99B:
				bool flag48 = Class101.smethod_0(num34);
				if (flag48)
				{
					flag2 = false;
					flag3 = false;
					flag = false;
					num7 = 0;
					num6 = 0;
					uint[] array8 = new uint[2];
					bool flag49 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && (Class44.gstruct33_1.int_3 > 0 || Form1.int_22 > 0) && Class44.gstruct33_1.int_4 > 0 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0);
					bool flag50 = Form1.int_21 > 0 && (Form1.int_22 > 0 || Class44.gstruct33_0.int_3 > 0) && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_6 > 0;
					uint num31;
					int num44;
					uint[] uint_;
					bool bool_;
					if (flag50)
					{
						num34 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
						array7 = new uint[]
						{
							Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						bool flag51 = Class44.gstruct33_0.int_4 != num34 || !Class101.smethod_0(num34);
						if (flag51)
						{
							bool flag52 = Class101.smethod_0(Class44.gstruct33_0.int_4);
							if (flag52)
							{
								array7 = new uint[]
								{
									Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								uint[] array9 = Class101.smethod_1(num34, array7, Class44.gstruct33_0.int_4, Class44.gstruct33_0.uint_4);
								bool flag53 = array9 != null;
								if (flag53)
								{
									uint[] array10 = new uint[]
									{
										array9[0],
										array9[1]
									};
									int int_ = (int)array9[2];
									long num47 = (long)((ulong)Class36.smethod_0(array7, array10));
									bool flag54 = num47 >= 90000L;
									if (flag54)
									{
										bool flag55 = array == null;
										if (flag55)
										{
											array = new uint[]
											{
												array7[0],
												array7[1]
											};
											num9 = 0;
										}
										Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
										num19 = 0;
										Class60.smethod_29(gstruct, false);
										bool flag56 = num9 > 6;
										if (flag56)
										{
											long num48 = Class60.smethod_18(array, array7);
											array = null;
											bool flag57 = num48 < 180000L;
											if (flag57)
											{
												Class60.smethod_2(gstruct, array7, array10, 600);
												continue;
											}
											num9 = 0;
										}
										bool flag58 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 6000L;
										if (flag58)
										{
											num24 = num9;
											num9 = num24 + 1;
											Class14.smethod_1(gstruct, array10);
											long_ = Class12.smethod_27();
										}
										continue;
									}
									num9 = 0;
									num9 = 0;
									array = null;
									Class14.smethod_2(gstruct, false);
									for (int k = 0; k < 10; k = num24 + 1)
									{
										array7 = new uint[]
										{
											Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										num47 = Class60.smethod_18(array7, array10);
										bool flag59 = num47 < 11500L || (ulong)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137) != (ulong)((long)num34);
										if (flag59)
										{
											break;
										}
										Class70.smethod_61(gstruct, array10);
										Thread.Sleep(300);
										num24 = k;
									}
									for (int l = 0; l < 5; l = num24 + 1)
									{
										Class60.smethod_25(gstruct, int_);
										Thread.Sleep(300);
										uint num49 = Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
										bool flag60 = (ulong)num49 != (ulong)((long)num34);
										if (flag60)
										{
											break;
										}
										num24 = l;
									}
									continue;
								}
							}
						}
						else
						{
							long num47 = Class60.smethod_18(array7, Class44.gstruct33_0.uint_4);
							bool flag61 = gstruct.int_130[0] > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0 && num35 == Class44.gstruct33_0.int_3 && num35 > 0;
							if (flag61)
							{
								int num50 = gstruct.int_130[1] + Form1.int_23;
								bool flag62 = num47 <= (long)(num50 * num50) && Class64.smethod_0(gstruct, Class44.gstruct33_0.uint_4, gstruct.int_130[1]) > 0;
								if (flag62)
								{
									goto IL_1FD7;
								}
							}
							bool flag63 = flag8 || num47 > (long)(num44 * num44);
							if (!flag63)
							{
								Class14.smethod_2(gstruct, false);
								int num51 = num10;
								num10 = 0;
								array = null;
								num9 = 0;
								bool flag64 = num35 > 0 && !gstruct.bool_22 && gstruct.int_93 == 1 && Form1.int_102 > 0 && (Form1.int_31 > 0 || Form1.int_30 > 0 || Form1.int_32 > 0) && Class22.smethod_30(num30 + Class53.gstruct51_43.uint_0, gstruct.int_137) > 0U;
								if (flag64)
								{
									Class60.smethod_30(gstruct);
								}
								bool flag65 = num15 <= 0L || Class12.smethod_28(num15) >= 1500L;
								if (flag65)
								{
									uint[] uint_2 = new uint[]
									{
										array7[0],
										array7[1]
									};
									bool flag66 = Class44.smethod_5(num31, ref array7, ref num8) > 0;
									if (flag66)
									{
										long num52 = Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4);
										long num53 = Class60.smethod_18(array7, Class44.gstruct33_0.uint_4);
										bool flag67 = num53 <= (long)(num44 * num44);
										if (flag67)
										{
											num15 = Class12.smethod_27();
											bool flag68 = num19 > 0;
											if (flag68)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
											}
											num19 = 0;
											Class44.smethod_6(gstruct, array7, Class44.gstruct33_0.uint_4, num52 <= 5625L);
											goto IL_2D32;
										}
										bool flag69 = num51 > 0;
										if (flag69)
										{
											uint[] uint_3 = Class60.smethod_5(array7, Class44.gstruct33_0.uint_4, -100);
											Class70.smethod_61(gstruct, uint_3);
											Thread.Sleep(120);
										}
										goto IL_2B8D;
									}
									else
									{
										num15 = 0L;
										bool flag70 = num19 == 0 && Class60.smethod_18(uint_2, Class44.gstruct33_0.uint_4) > (long)(Form1.int_23 * Form1.int_23);
										if (flag70)
										{
											num24 = num11;
											num11 = num24 + 1;
											bool flag71 = num11 > 3;
											if (flag71)
											{
												Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
												Thread.Sleep(150);
												num11 = 0;
											}
										}
										bool flag72 = Form1.int_27 > 0 && num35 > 0 && gstruct.int_131[0] > 0 && Class70.smethod_3(gstruct, Class70.uint_31, 4) == 0;
										if (flag72)
										{
											Class70.smethod_2(gstruct, Class70.uint_31, 1, 4);
										}
									}
								}
								num9 = 0;
								array = null;
								uint_ = Class44.gstruct33_0.uint_4;
								bool_ = true;
								goto IL_111E;
							}
							IL_2B8D:
							flag8 = (num47 > 40000L);
							Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
							num19 = 0;
							bool flag73 = array == null;
							if (flag73)
							{
								array = new uint[]
								{
									array7[0],
									array7[1]
								};
								num9 = 0;
							}
							bool flag74 = num9 > 6;
							if (flag74)
							{
								long num54 = Class60.smethod_18(array, array7);
								array = null;
								bool flag75 = num54 < 180000L;
								if (flag75)
								{
									Class14.smethod_2(gstruct, false);
									Class60.smethod_2(gstruct, array7, Class44.gstruct33_0.uint_4, 600);
									goto IL_2D32;
								}
								num9 = 0;
							}
							bool flag76 = num47 > (long)(Form1.int_101 * Form1.int_101);
							if (flag76)
							{
								Class60.smethod_29(gstruct, false);
							}
							bool flag77 = num47 >= 900000L || num10 >= 6;
							if (flag77)
							{
								bool flag78 = Class44.gstruct33_0.uint_4 != null && (!Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 4000L);
								if (flag78)
								{
									Class14.smethod_1(gstruct, Class44.gstruct33_0.uint_4);
									long_ = Class12.smethod_27();
									num24 = num9;
									num9 = num24 + 1;
									num10 = 0;
								}
								continue;
							}
							num24 = num10;
							num10 = num24 + 1;
							Class14.smethod_2(gstruct, false);
							Class70.smethod_61(gstruct, Class44.gstruct33_0.uint_4);
							Thread.Sleep(150);
							goto IL_2D32;
						}
						IL_111E:
						goto IL_140F;
					}
					bool flag79 = gstruct.int_68 != null && gstruct.int_68[0] > 0 && !FormMayphu.bool_3;
					if (flag79)
					{
						bool flag80 = num14 <= 0L || Class12.smethod_28(num14) >= 1000L;
						if (flag80)
						{
							uint[] array11 = Class60.smethod_26(gstruct, ref num13);
							bool flag81 = array11 != null;
							if (flag81)
							{
								num14 = 0L;
								long num55 = Class60.smethod_18(array7, array11);
								bool flag82 = num55 < 8000L;
								if (flag82)
								{
									goto IL_2DD4;
								}
								bool flag83 = num55 >= 15000L && num55 >= (long)(gstruct.int_68[1] * gstruct.int_68[1]);
								if (flag83)
								{
									bool flag84 = num55 < 360000L;
									if (flag84)
									{
										bool flag85 = num19 > 0;
										if (flag85)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
										}
										num19 = 0;
										Class14.smethod_2(gstruct, false);
										Class70.smethod_61(gstruct, array11);
										Thread.Sleep(200);
										continue;
									}
									bool flag86 = num55 < 1200000L;
									if (flag86)
									{
										bool flag87 = Class12.smethod_28(long_) > 3000L;
										if (flag87)
										{
											Class14.smethod_1(gstruct, array11);
											long_ = Class12.smethod_27();
										}
										continue;
									}
								}
								else
								{
									bool flag88 = num32 <= 3 && num55 > 7500L;
									if (flag88)
									{
										bool flag89 = num19 > 0;
										if (flag89)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
										}
										num19 = 0;
										Class70.smethod_61(gstruct, array11);
										Thread.Sleep(200);
										goto IL_2D32;
									}
								}
							}
							else
							{
								num14 = Class12.smethod_27();
							}
						}
					}
					bool flag90 = flag49;
					if (flag90)
					{
						int num56 = FormMayphu.smethod_9(gstruct, ref long_, ref num9, ref array);
						bool flag91 = num56 <= 0;
						if (flag91)
						{
							Thread.Sleep(100);
							continue;
						}
						num32 = (int)Class22.smethod_30(num30 + Class53.gstruct51_55.uint_0, gstruct.int_137);
						bool flag92 = num32 < 3;
						if (flag92)
						{
							array7 = new uint[]
							{
								Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
								Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
							};
							bool flag93 = Class60.smethod_18(array7, Class44.gstruct33_1.uint_4) > 5625L;
							if (flag93)
							{
								bool flag94 = num19 > 0;
								if (flag94)
								{
									Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
								}
								num19 = 0;
								Class70.smethod_61(gstruct, Class44.gstruct33_1.uint_4);
								Thread.Sleep(150);
							}
						}
					}
					goto IL_140F;
					IL_1FD7:
					bool flag95 = !gstruct.bool_58 || gstruct.int_83 <= 0;
					if (flag95)
					{
						continue;
					}
					bool flag96 = Form1.int_99 != 0;
					int num45;
					if (flag96)
					{
						bool flag97 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
						if (flag97)
						{
							Class36.smethod_54(gstruct, null, true, 10);
							bool flag98 = Class12.smethod_28(long_2) > gstruct.long_8;
							if (flag98)
							{
								Class36.smethod_55(gstruct);
								long_2 = Class12.smethod_27();
							}
						}
					}
					else
					{
						bool flag99 = num45 > 0 && Class12.smethod_28(long_2) > gstruct.long_8;
						if (flag99)
						{
							Class36.smethod_54(gstruct, array8, false, 10);
							Class36.smethod_55(gstruct);
							long_2 = Class12.smethod_27();
						}
					}
					continue;
					IL_2D32:
					bool flag38;
					bool flag100 = !flag38 && gstruct.int_136 != Class44.gstruct33_0.int_0 && Class36.smethod_58(gstruct, new int[]
					{
						0,
						1
					}) > 0U;
					if (flag100)
					{
						bool flag101 = num19 > 0;
						if (flag101)
						{
							Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
						}
						num19 = 0;
					}
					bool flag37;
					bool flag102 = flag37 && num45 <= 0;
					if (flag102)
					{
						FormDuongMon.smethod_0(gstruct, ref num17, uint_, ref num18, bool_);
					}
					goto IL_1FD7;
					IL_2DD4:
					num35 = (int)Class22.smethod_30(num30 + Class53.gstruct51_43.uint_0, gstruct.int_137);
					bool flag103 = num35 <= 0;
					if (flag103)
					{
						continue;
					}
					bool flag104 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_6 > 0 && Class44.gstruct33_0.int_4 == num34;
					flag38 = (!gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0));
					bool flag105 = gstruct.int_101[0] > 0 && gstruct.int_101[1] > 0 && gstruct.string_23 == "NGAMY";
					if (flag105)
					{
						long num57 = Class12.smethod_28(long_3);
						bool flag106 = num57 < 300L;
						if (flag106)
						{
							continue;
						}
						bool flag107 = num57 > (long)gstruct.int_101[4] && Class7.smethod_3(gstruct);
						if (flag107)
						{
							long_3 = Class12.smethod_27();
							continue;
						}
					}
					for (int m = 0; m < Class53.int_0; m = num24 + 1)
					{
						Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num22);
						bool flag108 = array3[0] == 0;
						if (flag108)
						{
							break;
						}
						Thread.Sleep(1);
						num24 = m;
					}
					bool bool_2 = gstruct.bool_22;
					if (bool_2)
					{
						bool flag109 = gstruct.int_136 != Class44.gstruct33_0.int_0;
						if (flag109)
						{
							Class60.smethod_29(gstruct, false);
						}
					}
					else
					{
						bool flag110 = gstruct.int_128[0] > 0 && gstruct.int_128[1] > 0 && gstruct.int_128[2] > 0;
						bool flag111 = gstruct.int_128[0] > 0 && gstruct.int_128[3] > 0 && gstruct.int_128[4] > 0;
						bool flag112 = gstruct.int_128[0] > 0 && gstruct.int_128[5] > 0 && gstruct.int_128[6] > 0;
						flag37 = ((flag110 || flag111 || flag112) && gstruct.string_23 == "DUONGMON");
						bool flag113 = FormDame.int_6 <= 0 || gstruct.int_126 != 0 || flag37;
						if (!flag113)
						{
							bool flag114 = flag38 || FormDame.int_10 > 0;
							if (flag114)
							{
								int num58 = 0;
								bool flag115 = FormDame.int_9 == 0;
								if (!flag115)
								{
									bool flag116 = Class44.gstruct33_0.int_8 == 1 || (flag49 && Class44.gstruct33_1.int_8 == 1);
									bool flag117 = FormDame.int_9 == 1;
									if (flag117)
									{
										bool flag118 = flag116;
										if (flag118)
										{
											goto IL_4F94;
										}
										bool flag119 = FormDame.int_11 > 0;
										if (!flag119)
										{
											bool flag120 = num19 > 0;
											if (flag120)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
											}
											num19 = 0;
											goto IL_31E2;
										}
									}
									else
									{
										bool flag121 = FormDame.int_9 != 2 || flag116;
										if (!flag121)
										{
											bool flag122 = num19 > 0;
											if (flag122)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
											}
											num19 = 0;
											goto IL_31E2;
										}
									}
									goto IL_31EF;
									IL_31E2:
									goto IL_31E3;
								}
								IL_4F94:
								uint num59 = 0U;
								uint[] array12 = null;
								uint[] uint_4 = null;
								bool flag123 = !flag49;
								if (flag123)
								{
									bool flag124 = gstruct.int_136 != Class44.gstruct33_0.int_0 && gstruct.int_136 != Class76.gstruct49_0.int_136 && Class44.gstruct33_0.uint_5 > 0U;
									if (flag124)
									{
										uint num60 = Class44.gstruct33_0.uint_5 >> 16;
										uint int_2 = Class44.gstruct33_0.uint_5 - (num60 << 16);
										array12 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)int_2, (int)num60);
										uint[] array13 = Class83.smethod_10(array7, array12);
										num59 = (array13[1] << 16) + array13[0];
										uint_4 = Class44.gstruct33_0.uint_4;
										Class83.smethod_7(gstruct, num59);
										Thread.Sleep(10);
									}
								}
								else
								{
									uint num61 = Class44.gstruct33_1.uint_5 >> 16;
									uint int_3 = Class44.gstruct33_1.uint_5 - (num61 << 16);
									array12 = Class83.smethod_11(Class44.gstruct33_1.uint_4, (int)int_3, (int)num61);
									uint[] array14 = Class83.smethod_10(array7, array12);
									num59 = (array14[1] << 16) + array14[0];
									uint_4 = Class44.gstruct33_1.uint_4;
									Class83.smethod_7(gstruct, num59);
									Thread.Sleep(10);
								}
								Class60.smethod_30(gstruct);
								bool flag125 = gstruct.int_127[0] != 2;
								if (flag125)
								{
									bool flag126 = gstruct.int_127[0] > 0;
									if (flag126)
									{
										bool flag127 = gstruct.int_127[1] > 0 && gstruct.int_127[2] > 0;
										bool flag128 = gstruct.int_127[3] > 0 && gstruct.int_127[4] > 0;
										bool flag129 = !flag127 || flag128;
										if (flag129)
										{
											bool flag130 = flag128 && !flag127;
											if (flag130)
											{
												num58 = gstruct.int_127[4];
											}
											else
											{
												bool flag131 = flag127 && flag128;
												if (flag131)
												{
													num58 = ((0 > num12 || num12 > 25) ? gstruct.int_127[4] : gstruct.int_127[2]);
													bool flag132 = num12 > 35;
													if (flag132)
													{
														num12 = 0;
													}
													num24 = num12;
													num12 = num24 + 1;
												}
											}
										}
										else
										{
											num58 = gstruct.int_127[2];
										}
									}
									bool flag133 = num58 <= 0;
									if (flag133)
									{
										num58 = Class77.smethod_13(gstruct);
									}
									bool flag134 = gstruct.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
									if (flag134)
									{
										Class77.smethod_9(gstruct, null);
									}
									Class77.smethod_5(gstruct, num58, 6, 1);
									for (int n = 0; n < 3; n = num24 + 1)
									{
										Class22.smethod_76(gstruct.uint_4, 117);
										bool flag135 = n < 2;
										if (flag135)
										{
											Thread.Sleep(60);
										}
										num24 = n;
									}
								}
								else
								{
									Class60.smethod_0(gstruct.uint_4, gstruct.int_129, FormDame.int_12);
								}
								bool flag136 = num59 != 0U && gstruct.int_136 != Class76.gstruct49_0.int_136;
								if (flag136)
								{
									bool flag137 = gstruct.int_95 <= 0;
									if (flag137)
									{
										Class22.smethod_30(num30 + Class53.gstruct51_31.uint_0, gstruct.int_137);
										int num62 = Class77.smethod_13(gstruct);
										bool flag138 = num62 == 53 || num62 <= 1;
										if (flag138)
										{
											goto IL_2D32;
										}
										bool flag139 = num62 <= 100;
										if (flag139)
										{
										}
									}
									string string_ = Class83.smethod_20(gstruct);
									bool flag140 = Class12.smethod_2(string_, "iÓm qu¸ x", false);
									if (flag140)
									{
										uint[] array15 = Class60.smethod_5(uint_4, array12, -1 * (Form1.int_23 - 50));
										long num63 = Class60.smethod_18(array7, array15);
										bool flag141 = num63 > 7000L;
										if (flag141)
										{
											Class70.smethod_61(gstruct, array15);
											Thread.Sleep(150);
											Class83.smethod_21(gstruct, "0K..");
										}
									}
								}
							}
							IL_31E3:
							goto IL_31E4;
						}
						IL_31EF:
						bool flag142 = flag38;
						if (flag142)
						{
							bool flag143 = Class44.smethod_7(gstruct, ref num21) || Class83.smethod_12(gstruct) == 1;
							if (flag143)
							{
								Thread.Sleep(100);
								num19 = 0;
							}
							else
							{
								num34 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
								array7 = new uint[]
								{
									Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								uint[] uint_5 = array7;
								bool flag144 = flag104 && Class44.gstruct33_0.int_4 == num34 && Class44.gstruct33_0.int_3 > 0 && Class44.gstruct33_0.uint_4 != null;
								int num40;
								if (flag144)
								{
									uint_5 = Class44.gstruct33_0.uint_4;
									num40 += num44;
								}
								uint num64 = 0U;
								bool flag145 = Form1.int_33 > 0 && (flag49 || flag104);
								if (flag145)
								{
									bool flag146 = !flag49;
									if (flag146)
									{
										bool flag147 = flag104 && Class44.gstruct33_0.int_4 == num34 && Class44.gstruct33_0.uint_3 != num31;
										if (flag147)
										{
											num64 = Class44.gstruct33_0.uint_3;
										}
									}
									else
									{
										bool flag148 = Class44.gstruct33_1.int_4 == num34 && Class44.gstruct33_1.uint_3 != num31;
										if (flag148)
										{
											num64 = Class44.gstruct33_1.uint_3;
										}
									}
									bool flag149 = num64 == 0U && Form1.int_34 <= 0;
									if (flag149)
									{
										goto IL_2D32;
									}
								}
								bool flag150 = gstruct.int_119 > 0 && gstruct.int_3 != null;
								if (flag150)
								{
									int[,] array16 = (gstruct.int_5 > 0) ? Class7.smethod_5(gstruct, num64, num40, uint_5, null, false, false, false) : Class7.smethod_6(gstruct, num64, num40, uint_5, null, false, false, false);
									bool flag151 = array16 != null && array16[0, 0] >= 0;
									if (flag151)
									{
										int num65 = -1;
										int int_4 = Class44.gstruct33_0.int_4;
										num19 = 0;
										bool flag152 = false;
										bool flag153 = false;
										int num42;
										for (;;)
										{
											int num66 = 0;
											int num67 = 400;
											while (num66 <= 0)
											{
												num24 = num65;
												num65 = num24 + 1;
												bool flag154 = gstruct.int_3 != null && gstruct.int_3.GetLength(0) > num65 && gstruct.int_4 != null;
												if (!flag154)
												{
													goto IL_3581;
												}
												num66 = gstruct.int_3[num65, 0];
												bool flag155 = num66 > 0;
												if (flag155)
												{
													num67 = Class77.smethod_20(gstruct, num66, gstruct.int_3[num65, 1]);
													break;
												}
											}
											num32 = (int)Class22.smethod_30(num30 + Class53.gstruct51_55.uint_0, gstruct.int_137);
											int num33 = (int)Class22.smethod_30(num30 + Class53.gstruct51_50.uint_0, gstruct.int_137);
											num35 = (int)Class22.smethod_30(num30 + Class53.gstruct51_43.uint_0, gstruct.int_137);
											int num68 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
											bool flag156 = num35 > 0 && num34 == num68 && num32 != 11 && num32 != 22 && num33 != 0;
											if (!flag156)
											{
												goto IL_3B6E;
											}
											for (int num69 = 0; num69 < array16.GetLength(0); num69 = num24 + 1)
											{
												bool flag157 = !Class44.smethod_7(gstruct, ref num21) && Class83.smethod_12(gstruct) != 1;
												if (!flag157)
												{
													goto IL_3B2D;
												}
												int num70 = array16[num69, 0];
												num45 = array16[num69, 1];
												bool flag158 = num45 <= 0;
												if (!flag158)
												{
													uint num29;
													uint num71 = num29 + (uint)(num45 * (int)Class53.gstruct51_15.uint_0);
													Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_50.uint_0, array3, 4, ref num22);
													bool flag159 = BitConverter.ToInt32(array3, 0) <= 0;
													if (!flag159)
													{
														bool flag160 = num70 > 0;
														if (flag160)
														{
															Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_43.uint_0, array3, 4, ref num22);
															bool flag161 = BitConverter.ToInt32(array3, 0) <= 0;
															if (flag161)
															{
																goto IL_3B32;
															}
														}
														flag152 = true;
														bool flag162 = !flag153 || num70 > 0;
														if (!flag162)
														{
															goto IL_3B2B;
														}
														bool flag163 = num70 > 0;
														if (flag163)
														{
															flag153 = true;
														}
														bool flag164 = Class98.smethod_31(gstruct, num45, num66) != 0;
														if (!flag164)
														{
															num42 = num67;
															Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num22);
															array8[0] = BitConverter.ToUInt32(array3, 0);
															Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num22);
															array8[1] = BitConverter.ToUInt32(array3, 0);
															array7 = new uint[]
															{
																Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															bool flag165 = flag104;
															if (flag165)
															{
																array7 = new uint[]
																{
																	Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																	Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
																};
																long num72 = Class60.smethod_18(array7, Class44.gstruct33_0.uint_4);
																bool flag166 = int_4 != Class44.gstruct33_0.int_4 || num72 > (long)(num44 * num44);
																if (flag166)
																{
																	goto Block_378;
																}
																int num73 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array8));
																int num74 = (int)Math.Sqrt((double)Class60.smethod_18(array7, array8));
																int num75 = num73 - num44 + 10;
																bool flag167 = num73 > num44 && num42 < num75 && (num74 > num73 || (num74 < num73 && num42 < num74));
																if (flag167)
																{
																	num42 = num75;
																}
															}
															bool flag168 = Class60.smethod_18(array7, array8) > (long)(num42 * num42) && gstruct.int_95 <= 0;
															if (!flag168)
															{
																for (int num76 = 0; num76 < Class53.int_0; num76 = num24 + 1)
																{
																	Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num22);
																	bool flag169 = array3[0] == 0;
																	if (flag169)
																	{
																		break;
																	}
																	Thread.Sleep(1);
																	num24 = num76;
																}
																Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(num66), 4, ref num22);
																Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num42), 4, ref num22);
																Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num45), 4, ref num22);
																Thread.Sleep(10);
																num19 = 1;
															}
														}
													}
												}
												IL_3B32:
												num24 = num69;
											}
										}
										IL_4209:
										goto IL_420A;
										IL_3BA7:
										bool flag170 = num19 > 0 || gstruct.int_6 > 0 || !flag152;
										if (flag170)
										{
											bool flag171 = flag152 && num19 <= 0 && gstruct.int_6 > 0;
											if (flag171)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
											}
											goto IL_4209;
										}
										long num77 = 0L;
										array7 = new uint[]
										{
											Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
											Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
										};
										num45 = -1;
										flag153 = false;
										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num22);
										int num78 = BitConverter.ToInt32(array3, 0);
										num42 = num78;
										bool flag172 = gstruct.int_95 > 0 && gstruct.int_96 > 0;
										if (flag172)
										{
											num42 = gstruct.int_96;
										}
										bool flag173 = num42 <= 0;
										if (flag173)
										{
											num42 = 400;
										}
										Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_44 * 4U, array3, 1, ref num22);
										int num79 = (int)array3[0];
										bool flag174 = num79 > 0 && num42 > num78 && num78 > 0;
										if (flag174)
										{
											num42 = num78;
										}
										for (int num80 = 0; num80 < array16.GetLength(0); num80 = num24 + 1)
										{
											int num81 = array16[num80, 0];
											int num82 = array16[num80, 1];
											int num83 = num42;
											bool flag175 = num82 <= 0;
											if (!flag175)
											{
												uint num29;
												uint num71 = num29 + (uint)(num82 * (int)Class53.gstruct51_15.uint_0);
												Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_50.uint_0, array3, 4, ref num22);
												bool flag176 = BitConverter.ToInt32(array3, 0) <= 0;
												if (!flag176)
												{
													bool flag177 = num81 > 0;
													if (flag177)
													{
														Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_43.uint_0, array3, 4, ref num22);
														bool flag178 = BitConverter.ToInt32(array3, 0) <= 0;
														if (flag178)
														{
															goto IL_408F;
														}
													}
													bool flag179 = flag153 && num81 <= 0 && num45 > 0;
													if (flag179)
													{
														break;
													}
													Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num22);
													array8[0] = BitConverter.ToUInt32(array3, 0);
													Class22.ReadProcessMemory(gstruct.int_137, num71 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num22);
													array8[1] = BitConverter.ToUInt32(array3, 0);
													long num84 = Class60.smethod_18(array7, array8);
													bool flag180 = num45 > 0 && num77 < num84;
													if (!flag180)
													{
														bool flag181 = flag104;
														if (flag181)
														{
															int num85 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array8));
															int num86 = (int)Math.Sqrt((double)Class60.smethod_18(array7, array8));
															int num87 = num85 - num44 + 10;
															bool flag182 = num85 > num44 && num83 < num87 && (num86 > num85 || (num86 < num85 && num83 < num86));
															if (flag182)
															{
																num83 = num87;
															}
														}
														bool flag183 = num84 <= (long)(num83 * num83) || gstruct.int_95 > 0;
														if (flag183)
														{
															bool flag184 = num81 > 0;
															if (flag184)
															{
																flag153 = true;
															}
															num45 = num82;
															num77 = num84;
															num42 = num83;
														}
													}
												}
											}
											IL_408F:
											num24 = num80;
										}
										bool flag185 = num45 <= 0;
										if (flag185)
										{
											goto IL_4209;
										}
										Class60.smethod_30(gstruct);
										for (int num88 = 0; num88 < Class53.int_0; num88 = num24 + 1)
										{
											Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num22);
											bool flag186 = array3[0] == 0;
											if (flag186)
											{
												break;
											}
											Thread.Sleep(1);
											num24 = num88;
										}
										Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num22);
										Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num42), 4, ref num22);
										Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num45), 4, ref num22);
										goto IL_4209;
										IL_3B2B:
										IL_3581:
										goto IL_3BA7;
										IL_3B6E:
										bool flag187 = num19 > 0;
										if (flag187)
										{
											Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
										}
										num19 = 0;
										goto IL_4209;
										IL_3B2D:
										Thread.Sleep(100);
										num19 = 0;
										goto IL_4209;
										Block_378:
										Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
									}
									IL_420A:;
								}
								else
								{
									bool flag188;
									flag38 = (flag188 = (!gstruct.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0)));
									if (flag188)
									{
										int[,] array16 = Class7.smethod_5(gstruct, num64, num40, uint_5, null, false, false, false);
										bool flag189 = array16 != null;
										if (flag189)
										{
											bool flag190 = array16[0, 0] == -100;
											if (flag190)
											{
												continue;
											}
											int num89 = 0;
											int num42;
											int num91;
											for (;;)
											{
												bool flag191 = array16[num89, 1] > 0;
												if (!flag191)
												{
													goto IL_44CB;
												}
												array8 = new uint[]
												{
													(uint)array16[num89, 4],
													(uint)array16[num89, 5]
												};
												bool flag192 = !flag104;
												if (flag192)
												{
													bool flag193 = Class60.smethod_18(array7, array8) > (long)(num42 * num42) && gstruct.int_95 <= 0;
													if (!flag193)
													{
														goto IL_437D;
													}
													bool flag194 = gstruct.int_88 != 1 || num89 != 0;
													if (flag194)
													{
														break;
													}
													num89 = 1;
												}
												else
												{
													int num90 = (int)Math.Sqrt((double)Class60.smethod_18(array7, array8));
													num91 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array8));
													bool flag195 = num90 - num42 > 0;
													if (!flag195)
													{
														goto IL_44C8;
													}
													bool flag196 = num91 > num90;
													if (flag196)
													{
														int num92 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array7));
														bool flag197 = num92 + (num90 - num42) <= num44 + 10;
														if (flag197)
														{
															goto Block_434;
														}
													}
													bool flag198 = gstruct.int_88 == 1 && num89 == 0;
													if (!flag198)
													{
														goto IL_446F;
													}
													num89 = 1;
												}
											}
											IL_4B92:
											goto IL_4B98;
											IL_4504:
											int num93 = array16[num89, 0];
											num45 = array16[num89, 1];
											array16[num89, 2];
											bool flag199 = gstruct.int_95 > 0 && array2[1] > 0;
											uint num29;
											if (flag199)
											{
												int num94 = array2[0];
												int num95 = array2[1];
												uint num96 = num29 + (uint)(num95 * (int)Class53.gstruct51_15.uint_0);
												Class22.ReadProcessMemory(gstruct.int_137, num96 + Class53.gstruct51_50.uint_0, array3, 4, ref num22);
												bool flag200 = BitConverter.ToInt32(array3, 0) > 0;
												if (flag200)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num96 + Class53.gstruct51_45.uint_0, array3, 4, ref num22);
													long num97 = (long)BitConverter.ToInt32(array3, 0);
													bool flag201 = num97 != 0L;
													if (flag201)
													{
														bool flag202 = Class22.smethod_30(num96 + Class53.gstruct51_52.uint_0, gstruct.int_137) != 3U;
														if (flag202)
														{
															array8 = new uint[]
															{
																Class22.smethod_30(num96 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num96 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															long num98 = Class60.smethod_18(array7, array8);
															bool flag203 = num98 <= (long)((num42 - 100) * (num42 - 100));
															if (flag203)
															{
																num93 = num94;
																num45 = num95;
															}
														}
													}
												}
											}
											bool flag204 = Form1.int_50 > 0 && (num93 <= 0 || num93 == array2[0]) && array2[1] > 0 && array2[2] == num34 && array2[3] > 0;
											if (flag204)
											{
												int num99 = array2[0];
												int num100 = array2[1];
												uint num101 = num29 + (uint)(num100 * (int)Class53.gstruct51_15.uint_0);
												Class22.ReadProcessMemory(gstruct.int_137, num101 + Class53.gstruct51_50.uint_0, array3, 4, ref num22);
												bool flag205 = BitConverter.ToInt32(array3, 0) > 0;
												if (flag205)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num101 + Class53.gstruct51_45.uint_0, array3, 4, ref num22);
													long num102 = (long)BitConverter.ToInt32(array3, 0);
													bool flag206 = num102 != 0L;
													if (flag206)
													{
														Class22.ReadProcessMemory(gstruct.int_137, num101 + Class53.gstruct51_43.uint_0, array3, 4, ref num22);
														bool flag207 = num99 <= 0 || BitConverter.ToInt32(array3, 0) > 0;
														if (flag207)
														{
															array8 = new uint[]
															{
																Class22.smethod_30(num101 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
																Class22.smethod_30(num101 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
															};
															long num103 = Class60.smethod_18(array7, array8);
															bool flag208 = !flag104;
															if (flag208)
															{
																bool flag209 = num103 <= (long)(num42 * num42);
																if (flag209)
																{
																	num93 = num99;
																	num45 = num100;
																}
															}
															else
															{
																int num104 = (int)Math.Sqrt((double)num103);
																int num105 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array8));
																bool flag210 = num104 - num42 > 0;
																if (flag210)
																{
																	bool flag211 = num105 > num104;
																	if (flag211)
																	{
																		int num106 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array7));
																		bool flag212 = num106 + (num104 - num42) <= num44 + 10;
																		if (flag212)
																		{
																			num93 = num99;
																			num45 = num100;
																		}
																	}
																}
																else
																{
																	num93 = num99;
																	num45 = num100;
																}
															}
														}
													}
												}
											}
											array2[0] = num93;
											array2[1] = num45;
											array2[2] = num34;
											array2[3] = 0;
											bool flag213 = num45 <= 0;
											if (flag213)
											{
												goto IL_4B92;
											}
											array2[3] = 1;
											num19 = 1;
											num20 = 1;
											Class60.smethod_30(gstruct);
											for (int num107 = 0; num107 < Class53.int_0; num107 = num24 + 1)
											{
												Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num22);
												bool flag214 = array3[0] == 0;
												if (flag214)
												{
													break;
												}
												Thread.Sleep(1);
												num24 = num107;
											}
											bool flag215 = gstruct.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct, (uint)num45) <= 0;
											if (flag215)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct)), 4, ref num22);
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num42), 4, ref num22);
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num45), 4, ref num22);
											}
											flag11 = (gstruct.gstruct48_0.int_0 > 0 && gstruct.gstruct48_0.int_1 > 0 && gstruct.gstruct48_0.int_8 > 0 && gstruct.gstruct48_0.int_9 > 0);
											goto IL_4B92;
											IL_44C9:
											goto IL_4504;
											IL_44C8:
											goto IL_44C9;
											IL_446F:
											bool flag216 = num44 + num42 <= num91;
											if (flag216)
											{
												bool flag217 = num19 > 0;
												if (flag217)
												{
													Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
												}
												num19 = 0;
												goto IL_4B92;
											}
											IL_437D:
											Block_434:
											goto IL_4504;
											IL_44CB:
											bool flag218 = num19 > 0;
											if (flag218)
											{
												Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
											}
											num19 = 0;
										}
										else
										{
											flag38 = false;
										}
										IL_4B98:;
									}
									else
									{
										flag38 = false;
									}
								}
							}
						}
					}
					IL_31E4:
					goto IL_2D32;
					IL_140F:
					goto IL_2DD4;
				}
				bool flag219 = num35 > 0;
				if (flag219)
				{
					flag = false;
					flag7 = true;
					bool flag220 = num34 == 221 || num34 == 539;
					if (flag220)
					{
						Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
						bool flag221 = Class50.smethod_0(gstruct, null) > 0;
						if (flag221)
						{
							continue;
						}
					}
					int int_5 = Class101.struct29_0[Form1.int_106].int_0;
					bool flag222 = Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0 && Class35.smethod_140(gstruct, int_5, null, null, false);
					if (flag222)
					{
						Thread.Sleep(300);
						Class60.smethod_11(gstruct, 15000);
						bool flag223 = Class22.smethod_30(num30 + Class53.gstruct51_43.uint_0, gstruct.int_137) == 0U;
						if (flag223)
						{
							continue;
						}
					}
					bool flag224 = Class60.smethod_14(gstruct, true);
					if (flag224)
					{
						Thread.Sleep(300);
						Class60.smethod_11(gstruct, 15000);
						bool flag225 = Class22.smethod_30(num30 + Class53.gstruct51_43.uint_0, gstruct.int_137) == 0U;
						if (flag225)
						{
							continue;
						}
					}
					uint[] array17 = Class43.smethod_10(array7, num34, "Xa phu", true);
					bool flag226 = array17 != null;
					if (flag226)
					{
						bool flag227 = Class12.smethod_28(long_) > 4000L;
						if (flag227)
						{
							Class14.smethod_1(gstruct, array17);
							long_ = Class12.smethod_27();
						}
						continue;
					}
				}
				bool flag228 = Form1.int_113 > 0 && gstruct.int_136 == Class44.gstruct33_0.int_0 && ((Form1.int_6 <= 0 && Form1.int_7 <= 0) || Class44.gstruct33_1.int_4 <= 0);
				if (flag228)
				{
					Class60.smethod_10(gstruct, "CTC Ac chÝnh ng­êi dïng tù ®iÒu khiÓn..");
					Thread.Sleep(300);
					continue;
				}
				bool flag229 = Class56.smethod_1(num34) == null;
				if (!flag229)
				{
					Class50.smethod_5(gstruct, 11);
					flag6 = true;
					continue;
				}
				bool flag230 = flag6;
				if (flag230)
				{
					flag6 = (Class91.smethod_0(gstruct, true, null) <= 0);
					continue;
				}
				int num108 = Class79.smethod_4(gstruct);
				bool flag231 = !flag || num5 < 0 || num5 != num108;
				if (!flag231)
				{
					bool flag232 = flag7;
					if (flag232)
					{
						long num109 = (long)((ulong)Class22.smethod_30(num30 + Class53.gstruct51_45.uint_0, gstruct.int_137));
						long num110 = (long)((ulong)(Class22.smethod_30(num30 + Class53.gstruct51_47.uint_0, gstruct.int_137) + 1U));
						long num111 = (long)((ulong)(Class22.smethod_30(num30 + Class53.gstruct51_47.uint_0 + 4U, gstruct.int_137) + 1U));
						long num112 = (long)((ulong)Class22.smethod_30(num30 + Class53.gstruct51_46.uint_0, gstruct.int_137));
						long num113 = (long)((ulong)(Class22.smethod_30(num30 + Class53.gstruct51_48.uint_0, gstruct.int_137) + 1U));
						long num114 = (long)((ulong)(Class22.smethod_30(num30 + Class53.gstruct51_48.uint_0 + 4U, gstruct.int_137) + 1U));
						bool flag233 = num111 > num110 && num111 < 150000L;
						if (flag233)
						{
							num110 = num111;
						}
						bool flag234 = num114 > num113 && num114 < 150000L;
						if (flag234)
						{
							num113 = num114;
						}
						double num115 = (double)(num109 * 100L / num110);
						double num116 = (double)(num112 * 100L / num113);
						bool flag235 = ((num110 > 100L && gstruct.int_106[0] > 0 && gstruct.int_106[1] > 0 && num109 <= (long)gstruct.int_106[1]) || (gstruct.int_109[0] > 0 && gstruct.int_109[1] > 0 && num115 <= (double)gstruct.int_109[1])) && Class32.smethod_6(gstruct, 0, 1, false) > 0;
						if (flag235)
						{
							Thread.Sleep(600);
						}
						bool flag236 = ((num113 > 50L && gstruct.int_107[0] > 0 && gstruct.int_107[1] > 0 && num112 <= (long)gstruct.int_107[1]) || (gstruct.int_111[0] > 0 && gstruct.int_111[1] > 0 && num116 <= (double)gstruct.int_111[1])) && Class32.smethod_6(gstruct, 1, 1, false) > 0;
						if (flag236)
						{
							Thread.Sleep(300);
						}
						Thread.Sleep(150);
						num5 = Class79.smethod_4(gstruct);
						flag7 = false;
					}
					int int_6 = Class101.struct29_0[Form1.int_106].int_0;
					uint[] array18 = Class101.struct29_0[Form1.int_106].uint_0;
					string text2 = Class101.struct29_0[Form1.int_106].string_0;
					string string_2 = Class101.struct29_0[Form1.int_106].string_1;
					string string_3 = Class101.struct29_0[Form1.int_108].string_1;
					bool flag237 = Form1.int_45 > 0 && Class44.gstruct33_0.int_0 != gstruct.int_136 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_6 > 0 && 926 <= Class44.gstruct33_0.int_4 && Class44.gstruct33_0.int_4 <= 932;
					if (flag237)
					{
						for (int j = 0; j < Class101.struct29_0.Length; j = num24 + 1)
						{
							bool flag238 = Class44.gstruct33_0.int_4 == Class101.struct29_0[j].int_1;
							if (flag238)
							{
								text2 = Class101.struct29_0[j].string_0;
								string_2 = Class101.struct29_0[j].string_1;
								int_6 = Class101.struct29_0[j].int_0;
								array18 = Class101.struct29_0[j].uint_0;
								break;
							}
							num24 = j;
						}
					}
					bool flag239 = text != null && text != string.Empty;
					if (flag239)
					{
						text2 = text;
					}
					bool flag240 = Form1.int_105 > 0 && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
					if (flag240)
					{
						Class86.smethod_8(gstruct, -1);
						Thread.Sleep(100);
						bool flag241 = Class60.smethod_17(gstruct, "ThÇn Hµnh", false);
						if (flag241)
						{
							Thread.Sleep(300);
							string[] array19 = new string[]
							{
								"ThÊt Thµnh",
								"ThÊt-Thµnh",
								"¹i ChiÕn",
								"tr­êng ThÊt",
								"hiÕn tr­êng",
								"o b¶n ®å C«ng T",
								"Ok Ta"
							};
							string text3 = string.Empty;
							int num117 = 0;
							int num118;
							int num119;
							for (;;)
							{
								num24 = num117;
								num117 = num24 + 1;
								Thread.Sleep(100);
								bool flag242 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
								if (flag242)
								{
									Class45.smethod_3(gstruct, null);
								}
								num118 = Class86.smethod_0(gstruct);
								bool flag243 = 0 <= num118;
								if (flag243)
								{
									num119 = Class86.smethod_1(gstruct, num118);
									for (int j = 0; j < num119; j = num24 + 1)
									{
										text3 += Class86.smethod_3(gstruct, j, num118, 128);
										num24 = j;
									}
									bool flag244 = text3 != string.Empty;
									if (flag244)
									{
										break;
									}
								}
								bool flag245 = num117 <= 10;
								if (!flag245)
								{
									goto IL_1B94;
								}
							}
							bool flag246 = num119 > 0;
							if (flag246)
							{
								for (int num120 = 0; num120 < num119; num120 = num24 + 1)
								{
									string string_4 = Class86.smethod_3(gstruct, num120, num118, 128).ToLower();
									for (int num121 = 0; num121 < array19.Length; num121 = num24 + 1)
									{
										bool flag247 = !(array19[num121] != "hiÕn tr­êng") || 0 > Class12.smethod_1(string_4, array19[num121].ToLower());
										if (!flag247)
										{
											goto IL_4BC8;
										}
										num24 = num121;
									}
									num24 = num120;
								}
							}
							num117 = 0;
							bool flag248 = Form1.int_109 > 0;
							if (flag248)
							{
								Class86.smethod_5(gstruct, Form1.int_109 - 1);
							}
							for (;;)
							{
								num24 = num117;
								num117 = num24 + 1;
								Thread.Sleep(100);
								num118 = Class86.smethod_0(gstruct);
								bool flag249 = 0 <= num118;
								if (flag249)
								{
									string text4 = string.Empty;
									num119 = Class86.smethod_1(gstruct, num118);
									for (int j = 0; j < num119; j = num24 + 1)
									{
										text4 += Class86.smethod_3(gstruct, j, num118, 128);
										num24 = j;
									}
									bool flag250 = text3 != text4 && text4 != string.Empty;
									if (flag250)
									{
										break;
									}
								}
								bool flag251 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
								if (flag251)
								{
									Class45.smethod_3(gstruct, null);
								}
								bool flag252 = num117 <= 10;
								if (!flag252)
								{
									goto IL_1D31;
								}
							}
							Thread.Sleep(300);
							bool flag253 = num119 == 1;
							if (flag253)
							{
								Class86.smethod_5(gstruct, 0);
								continue;
							}
							goto IL_4BC8;
							IL_1D31:
							goto IL_20CA;
							IL_4BC8:
							string text5 = string_2;
							int num122 = 0;
							num24 = num6;
							num6 = num24 + 1;
							bool flag254 = num6 > 3;
							if (flag254)
							{
								bool flag255 = Form1.int_107 > 0;
								if (flag255)
								{
									text5 = string_3;
								}
								bool flag256 = num6 > 6;
								if (flag256)
								{
									num6 = 0;
								}
							}
							text5 = text5.ToLower();
							for (;;)
							{
								IL_4F83:
								bool flag257 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
								if (flag257)
								{
									Class45.smethod_3(gstruct, null);
									Thread.Sleep(450);
								}
								string b = null;
								int num123 = Class86.smethod_0(gstruct);
								int num124 = Class86.smethod_1(gstruct, num123);
								int num125 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
								int num126 = 0;
								IL_4F19:
								while (num126 < array19.Length)
								{
									string object_ = array19[num126].ToLower();
									int j = 0;
									while (j < num124)
									{
										string text6 = Class86.smethod_3(gstruct, j, num123, 128);
										bool flag258 = j == 0;
										if (flag258)
										{
											b = text6;
										}
										string string_5 = text6.ToLower();
										bool flag259 = Class12.smethod_1(string_5, object_) < 0;
										if (flag259)
										{
											num24 = j;
											j = num24 + 1;
										}
										else
										{
											Class86.smethod_5(gstruct, j);
											for (int num127 = 0; num127 < 8; num127 = num24 + 1)
											{
												Thread.Sleep(100);
												bool flag260 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
												if (flag260)
												{
													Class45.smethod_3(gstruct, null);
													Thread.Sleep(450);
												}
												int num128 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
												bool flag261 = num125 == num128;
												if (!flag261)
												{
													goto IL_4EC6;
												}
												int num129 = Class86.smethod_0(gstruct);
												bool flag262 = 0 <= num129;
												if (flag262)
												{
													int num130 = Class86.smethod_1(gstruct, num129);
													bool flag263 = num123 != num129 || num130 != num124;
													if (flag263)
													{
														break;
													}
													string a = Class86.smethod_3(gstruct, 0, num129, 128);
													bool flag264 = a != b;
													if (flag264)
													{
														break;
													}
												}
												num24 = num127;
											}
											Thread.Sleep(300);
											bool flag265 = num122 != 0;
											if (flag265)
											{
												IL_4F07:
												num24 = num126;
												num126 = num24 + 1;
												goto IL_4F19;
											}
											array19 = new string[]
											{
												text5
											};
											Thread.Sleep(150);
											num122 = 1;
											goto IL_4F83;
										}
									}
									goto IL_4F07;
								}
								goto Block_482;
							}
							continue;
							Block_482:
							Class86.smethod_8(gstruct, -1);
							continue;
							IL_4EC6:
							bool flag266 = Class86.Class89.smethod_4(gstruct);
							if (flag266)
							{
								Class22.smethod_4(gstruct.uint_4, 32U);
							}
							continue;
							IL_1B94:;
						}
					}
					IL_20CA:
					bool flag267 = Form1.int_107 <= 0 || num16 < Form1.int_39 || (Form1.int_40 <= 0 && num16 >= Form1.int_39 * 2);
					if (flag267)
					{
						bool flag268 = num16 >= Form1.int_39 * 2;
						if (flag268)
						{
							num16 = 0;
						}
					}
					else
					{
						array18 = Class101.struct29_0[Form1.int_108].uint_0;
						text2 = Class101.struct29_0[Form1.int_108].string_0;
						string_2 = Class101.struct29_0[Form1.int_108].string_1;
						int_6 = Class101.struct29_0[Form1.int_108].int_0;
						flag5 = true;
						bool flag269 = text != null && text != string.Empty;
						if (flag269)
						{
							text2 = text;
						}
					}
					int[] array20 = Class60.smethod_9(num34);
					bool flag270 = array20 != null && num35 <= 0;
					if (!flag270)
					{
						bool flag271 = flag2 || Class70.smethod_3(gstruct, Class70.uint_19, 4) <= 0;
						if (flag271)
						{
							bool flag272 = !flag3 && !Class32.smethod_0(num34);
							if (flag272)
							{
								flag3 = true;
								bool flag273 = Class60.smethod_14(gstruct, true);
								if (flag273)
								{
									goto IL_4BA7;
								}
							}
							goto IL_2B42;
						}
						flag2 = true;
						bool flag274 = Class35.smethod_140(gstruct, int_6, null, array18, false);
						if (!flag274)
						{
							goto IL_2B42;
						}
						IL_4BA7:
						bool flag275 = num34 != 2;
						if (flag275)
						{
							continue;
						}
						break;
						IL_2B42:
						int int_7 = 1;
						array20 = Class60.smethod_9(string_2);
						bool flag276 = array20 != null;
						if (flag276)
						{
							int_7 = Class60.int_0[array20[0], array20[1]];
						}
						flag9 = (Class50.smethod_5(gstruct, int_7) > 0);
						flag3 = false;
						flag2 = false;
						goto IL_4BA7;
					}
					bool flag277 = num34 != int_6;
					if (flag277)
					{
						bool flag278 = !flag2 && Class70.smethod_3(gstruct, Class70.uint_19, 4) > 0;
						if (flag278)
						{
							flag2 = true;
							flag9 = Class35.smethod_140(gstruct, int_6, null, array18, false);
						}
						bool flag279 = !flag9;
						if (flag279)
						{
							flag9 = (Class50.smethod_5(gstruct, int_6) > 0);
						}
						continue;
					}
					bool flag280 = array18 == null;
					if (flag280)
					{
						for (int num131 = 0; num131 < array5.GetLength(0); num131 = num24 + 1)
						{
							bool flag281 = (long)int_6 == (long)((ulong)array5[num131, 0]);
							if (flag281)
							{
								array18 = new uint[]
								{
									array5[num131, 1],
									array5[num131, 2]
								};
								break;
							}
							num24 = num131;
						}
						bool flag282 = array18 == null;
						if (flag282)
						{
							bool flag283 = Class12.smethod_28(long_4) > 8000L;
							if (flag283)
							{
								string string_6 = Class101.struct29_0[Form1.int_106].string_1;
								string string_7 = "<bclr=blue><color=green>[ " + string_6 + "] ch­a cã täa ®é Xa phu C«ng thµnh chiÕn, vµo B¶ng 1 - CTC bÊm nót LÊy vÞ trÝ Xa phu ®Ó lÊy täa ®é";
								string string_8 = "<bclr=blue><color=green>NÕu vµo ®­îc CTC b»ng ThÇn Hµnh phï, th× qua tab Cµi game cña auto chän l¹i cho ®óng WEB ®ang ch¬i.";
								Class70.smethod_52(gstruct, string_7, 1);
								Class70.smethod_52(gstruct, string_8, 1);
							}
							continue;
						}
					}
					bool flag284 = !flag5 && num7 < 6;
					if (flag284)
					{
						uint[] uint_6 = Class43.smethod_10(array18, int_6, "R­¬ng chøa ®å", true);
						flag5 = (Class91.smethod_0(gstruct, true, uint_6) > 0);
						num24 = num7;
						num7 = num24 + 1;
						continue;
					}
					long num132 = Class60.smethod_18(array7, array18);
					bool flag285 = num132 > 90000L;
					if (flag285)
					{
						bool flag286 = array == null;
						if (flag286)
						{
							array = new uint[]
							{
								array7[0],
								array7[1]
							};
							num9 = 0;
						}
						bool flag287 = num9 > 6;
						if (flag287)
						{
							bool flag288 = array != null && Class60.smethod_18(array, array7) < 180000L;
							array = null;
							bool flag289 = flag288;
							if (flag289)
							{
								Class60.smethod_2(gstruct, array7, Class44.gstruct33_0.uint_4, 600);
								continue;
							}
							num9 = 0;
						}
						bool flag290 = !Class14.smethod_3(gstruct) || Class12.smethod_28(long_) > 4000L;
						if (flag290)
						{
							num24 = num9;
							num9 = num24 + 1;
							Class14.smethod_1(gstruct, array18);
							long_ = Class12.smethod_27();
						}
						continue;
					}
					array = null;
					uint[] array21 = null;
					int num133 = 0;
					bool flag291 = text2 != null && text2 != string.Empty;
					if (flag291)
					{
						num133 = Class80.smethod_1(gstruct, text2, ref array21);
						bool flag292 = num133 > 0;
						if (flag292)
						{
							string text7 = Class98.smethod_16(gstruct, num133, ref array21, 60).Trim();
							bool flag293 = text7 == string.Empty || text7 == "Xa phu" || text7.Length <= 7;
							if (flag293)
							{
								num133 = 0;
							}
						}
					}
					bool flag294 = num133 <= 0;
					if (flag294)
					{
						string text8 = Class80.smethod_2(gstruct);
						bool flag295 = text8 != null && text8 != string.Empty;
						if (flag295)
						{
							text = text8;
						}
						Class60.smethod_10(gstruct, "Khong tim thay Xa phu Cong thanh chien, auto tu dong thiet lap lai.");
						continue;
					}
					for (int num134 = 0; num134 < 10; num134 = num24 + 1)
					{
						array7 = new uint[]
						{
							Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
							Class22.smethod_30(num30 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
						};
						long num47 = Class60.smethod_18(array7, array21);
						bool flag296 = num47 <= 11500L;
						if (flag296)
						{
							break;
						}
						Class70.smethod_61(gstruct, array21);
						Thread.Sleep(300);
						num24 = num134;
					}
					Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num133), 4, ref num22);
					Thread.Sleep(600);
					int num135 = Class86.smethod_0(gstruct);
					int num136 = Class86.smethod_1(gstruct, num135);
					bool flag297 = 0 <= Class86.smethod_0(gstruct) && num136 > 0 && 0 <= num135;
					if (flag297)
					{
						int[] array22 = new int[2];
						int[] array23 = array22;
						string[] array24 = new string[]
						{
							"Ok Ta",
							"Vµo",
							"chiÕn tr­êng",
							"ThÊt-Thµnh"
						};
						int num137 = -1;
						int num138 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
						int j = 0;
						IL_2976:
						while (j < array24.Length)
						{
							string object_2 = array24[j].ToLower();
							for (int num139 = 0; num139 < num136; num139 = num24 + 1)
							{
								string string_9 = Class86.smethod_3(gstruct, num139, num135, 128).ToLower();
								bool flag298 = 0 > Class12.smethod_1(string_9, object_2);
								if (!flag298)
								{
									num137 = num139;
									Class86.smethod_5(gstruct, num137);
									for (int num140 = 0; num140 < 15; num140 = num24 + 1)
									{
										bool flag299 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
										if (flag299)
										{
											Class45.smethod_3(gstruct, null);
											Thread.Sleep(450);
										}
										int num141 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
										bool flag300 = num138 == num141;
										if (!flag300)
										{
											bool flag301 = Class86.Class89.smethod_4(gstruct);
											if (flag301)
											{
												Class22.smethod_4(gstruct.uint_4, 32U);
											}
											goto IL_54A6;
										}
										Thread.Sleep(60);
										num24 = num140;
									}
									IL_295A:
									num136 = Class86.smethod_1(gstruct, num135);
									num24 = j;
									j = num24 + 1;
									goto IL_2976;
								}
								num24 = num139;
							}
							goto IL_295A;
						}
						bool flag302 = num137 < 0;
						if (flag302)
						{
							int[] array25 = new int[3];
							array25[0] = 3;
							array23 = array25;
						}
						int num142 = array23.Length;
						for (j = 0; j < num142; j = num24 + 1)
						{
							Class86.smethod_5(gstruct, array23[j]);
							for (int num143 = 0; num143 < 15; num143 = num24 + 1)
							{
								int num144 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct.int_137);
								bool flag303 = num138 == num144;
								if (!flag303)
								{
									bool flag304 = Class86.Class89.smethod_4(gstruct);
									if (flag304)
									{
										Class22.smethod_4(gstruct.uint_4, 32U);
									}
									goto IL_54A6;
								}
								Thread.Sleep(60);
								num24 = num143;
							}
							num24 = j;
						}
						bool flag305 = Form1.int_107 > 0;
						if (flag305)
						{
							num24 = num16;
							num16 = num24 + 1;
						}
					}
					Class86.smethod_8(gstruct, -1);
					continue;
					goto IL_20CA;
				}
				bool flag306 = !Form1.bool_4 && Class34.smethod_3(gstruct, Form1.int_98 <= 0) == 0;
				if (flag306)
				{
					Thread.Sleep(300);
					continue;
				}
				flag = true;
				bool flag307 = gstruct.int_65 > 0;
				if (flag307)
				{
					Class60.smethod_3(gstruct, ref flag4);
				}
				num5 = Class79.smethod_4(gstruct);
				continue;
				IL_1D82:
				flag = false;
				flag2 = false;
				flag3 = false;
				flag4 = false;
				array = null;
				int num145 = 0;
				for (;;)
				{
					bool flag308 = num != num34;
					if (!flag308)
					{
						goto IL_1F66;
					}
					int num146 = Class83.smethod_39(gstruct);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num22);
					bool flag309 = num22 != 4;
					if (flag309)
					{
						break;
					}
					uint num26 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_13.uint_0, array3, 4, ref num22);
					uint num27 = BitConverter.ToUInt32(array3, 0);
					uint num28 = num27 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num22);
					bool flag310 = num22 != 4;
					if (flag310)
					{
						break;
					}
					uint num29 = BitConverter.ToUInt32(array3, 0);
					num30 = num29 + num28;
					Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_50.uint_0, array3, 4, ref num22);
					int num33 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num22);
					num34 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_43.uint_0, array3, 4, ref num22);
					num35 = BitConverter.ToInt32(array3, 0);
					Class22.WriteProcessMemory(gstruct.int_137, num30 + Class53.gstruct51_72.uint_0, byte_, 4, ref num22);
					num19 = 0;
					bool flag311 = num35 <= 0 && num145 <= 8 && (num146 == 0 || num146 == 1 || num33 <= 0 || num34 <= 0);
					if (!flag311)
					{
						goto IL_1F65;
					}
					num24 = num145;
					num145 = num24 + 1;
					Thread.Sleep(100);
				}
				continue;
				IL_1F66:
				num = num34;
				num2 = Class44.gstruct33_0.int_4;
				continue;
				IL_1F65:
				goto IL_1F66;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000E2224 File Offset: 0x000E0424
		private static int smethod_1(GStruct49 gstruct49_0, string string_0, ref uint[] uint_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
			Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
			uint[] array3 = new uint[]
			{
				Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
				Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
			};
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
			int num6 = BitConverter.ToInt32(array, 0);
			bool flag = num6 <= 1;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num7 = 0;
				new uint[2];
				string b = string_0.Trim().ToLower();
				for (uint num8 = 1U; num8 < 256U; num8 += 1U)
				{
					bool flag2 = num6 <= num7;
					if (flag2)
					{
						break;
					}
					uint num9 = num4 + num8 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_16.uint_0, array, 4, ref num);
					bool flag3 = array[0] == 0;
					if (!flag3)
					{
						num7++;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_50.uint_0, array, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array, 0) <= 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_52.uint_0, array, 4, ref num);
							uint num10 = BitConverter.ToUInt32(array, 0);
							bool flag5 = num10 == 3U;
							if (flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num);
								string a = Class10.smethod_3(array2).Trim().ToLower();
								bool flag6 = !(a != b);
								if (flag6)
								{
									uint_0 = new uint[2];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
									uint_0[0] = BitConverter.ToUInt32(array, 0);
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
									uint_0[1] = BitConverter.ToUInt32(array, 0);
									return (int)num8;
								}
							}
						}
					}
				}
				result = 0;
			}
			return result;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000E2560 File Offset: 0x000E0760
		private static string smethod_2(GStruct49 gstruct49_0)
		{
			string[] array = new string[]
			{
				"Xa Phu C«ng Thµnh",
				"Çu C«ng Thµnh ChiÕn",
				"ThÊt thµnh",
				"tiÕp dÉn"
			};
			uint[,] array2 = new uint[7, 3];
			Class11.smethod_4(array2, 359931);
			uint[,] array3 = array2;
			int num = 0;
			byte[] array4 = new byte[4];
			byte[] array5 = new byte[60];
			uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num5 = num4 + num3 * Class53.gstruct51_15.uint_0;
			Class22.smethod_30(num5 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_50.uint_0, gstruct49_0.int_137);
			int num6 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(num5 + Class53.gstruct51_43.uint_0, gstruct49_0.int_137);
			uint[] array6 = new uint[]
			{
				Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct49_0.int_137),
				Class22.smethod_30(num5 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct49_0.int_137)
			};
			int num7 = -1;
			for (int i = 0; i < array3.GetLength(0); i++)
			{
				bool flag = (long)num6 == (long)((ulong)array3[i, 0]);
				if (flag)
				{
					num7 = i;
					break;
				}
			}
			bool flag2 = num7 < 0;
			string result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				uint[] uint_ = new uint[]
				{
					array3[num7, 1],
					array3[num7, 2]
				};
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array4, 4, ref num);
				int num8 = BitConverter.ToInt32(array4, 0);
				bool flag3 = num8 > 1;
				if (flag3)
				{
					int num9 = 0;
					long num10 = 0L;
					uint[] array7 = new uint[2];
					string text = null;
					for (uint num11 = 1U; num11 < 256U; num11 += 1U)
					{
						bool flag4 = num8 <= num9;
						if (flag4)
						{
							break;
						}
						uint num12 = num4 + num11 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array4, 4, ref num);
						bool flag5 = array4[0] == 0;
						if (!flag5)
						{
							num9++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_52.uint_0, array4, 4, ref num);
							uint num13 = BitConverter.ToUInt32(array4, 0);
							bool flag6 = num13 != 3U;
							if (!flag6)
							{
								uint[] array8 = new uint[2];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array4, 4, ref num);
								array8[0] = BitConverter.ToUInt32(array4, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array4, 4, ref num);
								array8[1] = BitConverter.ToUInt32(array4, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_16.uint_0, array5, array5.Length, ref num);
								string text2 = Class10.smethod_3(array5);
								string string_ = text2.ToLower();
								bool flag7 = false;
								for (int j = 0; j < array.Length; j++)
								{
									bool flag8 = 0 <= Class12.smethod_1(string_, array[j].ToLower());
									if (flag8)
									{
										flag7 = true;
										break;
									}
								}
								bool flag9 = !flag7;
								if (!flag9)
								{
									array7[0] = array8[0];
									array7[1] = array8[1];
									text = text2;
									break;
								}
								string text3 = text2.Trim();
								bool flag10 = !(text3 == "Xa phu") && text3.Length > 7;
								if (flag10)
								{
									long num14 = Class60.smethod_18(uint_, array8);
									bool flag11 = num14 < 22500L && (text == null || num14 < num10);
									if (flag11)
									{
										num10 = num14;
										array7[0] = array8[0];
										array7[1] = array8[1];
										text = text2;
									}
								}
							}
						}
					}
					result = text;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}
	}
}
