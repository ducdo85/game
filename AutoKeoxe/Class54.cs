using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000033 RID: 51
	internal class Class54
	{
		// Token: 0x0600031D RID: 797 RVA: 0x00088774 File Offset: 0x00086974
		static Class54()
		{
			uint[,] array_ = new uint[13, 2];
			Class11.smethod_4(array_, 261661);
			Class54.uint_0 = array_;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x000887A0 File Offset: 0x000869A0
		public static void smethod_0(int int_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			int num4 = -1;
			int num5 = 0;
			int num6 = 0;
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			GStruct26 gstruct = default(GStruct26);
			int int_ = -1;
			uint[] uint_ = null;
			uint[] uint_2 = null;
			new Random();
			GStruct49 gstruct2 = default(GStruct49);
			uint num7 = 0U;
			uint[] array = null;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			long num14 = 0L;
			long num15 = 0L;
			long long_5 = 0L;
			long long_6 = 0L;
			int num16 = 0;
			int num17 = -1;
			int num18 = 0;
			int num19 = 0;
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			bool flag12 = false;
			bool flag13 = false;
			bool flag14 = false;
			int num23 = 0;
			int num24 = 0;
			int[] array2 = new int[5];
			int num25 = 0;
			byte[] byte_ = new byte[4];
			byte[] array3 = new byte[4];
			int num26 = -1;
			int num27 = 0;
			int num28 = 0;
			int num29 = -1;
			int num30 = -1;
			int num31 = 0;
			int num32 = 0;
			bool flag15 = false;
			int[] array4 = new int[10];
			int num33;
			for (int i = 0; i < array4.Length; i = num33 + 1)
			{
				array4[i] = 4;
				num33 = i;
			}
			for (;;)
			{
				uint num39;
				int num43;
				int num44;
				int num47;
				uint[] array5;
				bool flag46;
				uint[] array6;
				bool bool_;
				bool flag47;
				bool flag48;
				int num55;
				uint[] array8;
				uint[,] array9;
				uint[] array10;
				bool flag74;
				bool flag75;
				bool flag90;
				bool flag96;
				uint[] array12;
				bool flag102;
				uint[] array13;
				long num78;
				uint[] array16;
				bool flag148;
				uint[,] array18;
				for (;;)
				{
					Thread.Sleep(100);
					int num34 = Class81.smethod_3(Form1.gstruct49_0, int_0);
					bool flag16 = Class12.bool_0 || num34 < 0 || Form1.int_20 != 0;
					if (flag16)
					{
						return;
					}
					gstruct2 = Form1.gstruct49_0[num34];
					bool flag17 = !gstruct2.bool_25 || gstruct2.int_20[0] > 0 || gstruct2.int_133[0] > 0 || gstruct2.bool_54 || gstruct2.int_25 > 0 || gstruct2.bool_55;
					if (flag17)
					{
						return;
					}
					bool flag18 = !gstruct2.bool_15 && Class70.smethod_3(gstruct2, Class70.uint_48, 4) <= 0;
					if (!flag18)
					{
						goto IL_87DC;
					}
					Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_42 * 4U, array3, 1, ref num25);
					bool flag19 = array3[0] <= 0 && !gstruct2.bool_0;
					if (!flag19)
					{
						goto IL_87CE;
					}
					bool flag20 = Class44.bool_0 && gstruct2.bool_26;
					if (flag20)
					{
						Form1.gstruct49_0[num34].bool_26 = false;
						Class14.smethod_2(gstruct2, false);
					}
					bool flag21 = gstruct2.gstruct47_0.int_0 > 0 && !gstruct2.bool_45 && Class99.int_0 <= 0;
					if (flag21)
					{
						Class99.int_0 = int_0;
						new Thread(new ThreadStart(Class99.smethod_3)).Start();
						Thread.Sleep(300);
					}
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array4[0]);
					uint num35 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num35 + Class53.gstruct51_13.uint_0, array3, 4, ref array4[1]);
					uint num36 = BitConverter.ToUInt32(array3, 0);
					uint num37 = num36 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array4[2]);
					uint num38 = BitConverter.ToUInt32(array3, 0);
					num39 = num38 + num37;
					Class22.ReadProcessMemory(gstruct2.int_137, num39, array3, 4, ref array4[3]);
					uint num40 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_55.uint_0, array3, 4, ref array4[4]);
					int num41 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_50.uint_0, array3, 4, ref array4[5]);
					int num42 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array4[6]);
					num43 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref array4[7]);
					num44 = BitConverter.ToInt32(array3, 0);
					int num45 = 7;
					int num46 = Class83.smethod_12(gstruct2);
					bool flag22 = (gstruct2.int_136 != Class76.gstruct49_0.int_136 && gstruct2.int_136 != Class44.gstruct33_0.int_0) || (num46 != 1 && num46 != 2);
					if (!flag22)
					{
						goto IL_8750;
					}
					bool flag23 = num30 != gstruct2.int_122;
					if (flag23)
					{
						num29 = -1;
						num30 = gstruct2.int_122;
					}
					bool flag24 = num24 <= 0;
					if (flag24)
					{
						array2[0] = 0;
						array2[1] = 0;
						array2[2] = 0;
						array2[3] = 0;
						array2[4] = 0;
					}
					num24 = 0;
					num47 = Class83.smethod_39(gstruct2);
					bool flag25 = num42 != 0 && num41 != 0 && num43 != 0 && num47 > 1;
					if (!flag25)
					{
						goto IL_872A;
					}
					bool flag26 = num41 != 10 && num41 != 21;
					if (!flag26)
					{
						goto IL_86EE;
					}
					int j = 0;
					for (;;)
					{
						bool flag27 = j <= num45;
						if (!flag27)
						{
							break;
						}
						bool flag28 = array4[j] == 0;
						if (flag28)
						{
							goto Block_32;
						}
						num33 = j;
						j = num33 + 1;
					}
					array5 = new uint[]
					{
						Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
						Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
					};
					bool flag29 = array5[0] == 0U || array5[1] == 0U;
					if (!flag29)
					{
						bool flag30 = !flag10;
						if (!flag30)
						{
							goto IL_1764;
						}
						bool flag31 = num == num43 && (num2 == Class44.gstruct33_0.int_4 || Form1.int_21 <= 0);
						if (!flag31)
						{
							goto IL_14FA;
						}
						bool flag32 = num3 != num44;
						if (flag32)
						{
							num16 = 0;
							num18 = 0;
							num8 = 0;
							array = null;
							flag12 = false;
							int num48 = 0;
							while (num44 == 0 && num48 < 30 && num44 != num3)
							{
								Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num25);
								num35 = BitConverter.ToUInt32(array3, 0);
								Class22.ReadProcessMemory(gstruct2.int_137, num35 + Class53.gstruct51_13.uint_0, array3, 4, ref num25);
								num36 = BitConverter.ToUInt32(array3, 0);
								num37 = num36 * Class53.gstruct51_15.uint_0;
								Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num25);
								num38 = BitConverter.ToUInt32(array3, 0);
								num39 = num38 + num37;
								Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
								num44 = BitConverter.ToInt32(array3, 0);
								Thread.Sleep(30);
								num33 = num48;
								num48 = num33 + 1;
							}
							num3 = num44;
							bool flag33 = num44 <= 0;
							if (flag33)
							{
								break;
							}
						}
						Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num25);
						bool flag34 = array3[0] > 0;
						if (flag34)
						{
							flag3 = false;
							array3[0] = 0;
							Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_23 * 4U, array3, 1, ref num25);
						}
						Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
						int num49 = (int)array3[0];
						bool flag35 = num49 <= 0;
						if (!flag35)
						{
							goto IL_14A4;
						}
						Class22.ReadProcessMemory(gstruct2.int_137, num35 + Class53.gstruct51_30.uint_0 + Class53.gstruct51_65.uint_0, array3, 4, ref num25);
						int num50 = BitConverter.ToInt32(array3, 0);
						int num51 = 600;
						bool flag36 = gstruct2.int_98 > 0;
						if (flag36)
						{
							num51 = gstruct2.int_99;
						}
						bool flag37 = gstruct2.int_136 != Class44.gstruct33_0.int_0;
						if (flag37)
						{
							Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_43 * 4U, array3, 4, ref num25);
							gstruct2.int_97 = BitConverter.ToInt32(array3, 0);
						}
						int num52 = gstruct2.int_97;
						bool flag38 = gstruct2.int_95 > 0 && gstruct2.int_96 > 0;
						if (flag38)
						{
							num52 = gstruct2.int_96;
						}
						bool flag39 = num52 <= 0;
						if (flag39)
						{
							num52 = 500;
						}
						Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_44 * 4U, array3, 1, ref num25);
						int num53 = (int)array3[0];
						bool flag40 = num53 > 0 && num52 > gstruct2.int_97 && gstruct2.int_97 > 0;
						if (flag40)
						{
							num52 = gstruct2.int_97;
						}
						int num54 = Form1.int_23;
						bool flag41 = gstruct2.int_136 != Class44.gstruct33_0.int_0;
						if (flag41)
						{
							bool flag42 = num52 <= 180 && num54 < Form1.int_51;
							if (flag42)
							{
								num54 = Form1.int_51;
							}
							bool flag43 = gstruct2.int_131[0] > 0 && Form1.int_27 > 0 && num54 > 180;
							if (flag43)
							{
								num54 = 180;
							}
							bool flag44 = flag15;
							if (flag44)
							{
								bool flag45 = num44 > 0;
								if (flag45)
								{
									num54 = gstruct2.gstruct48_0.int_9;
								}
								flag15 = false;
							}
						}
						flag46 = (464 <= num43 && num43 <= 499);
						array6 = array5;
						bool_ = false;
						flag47 = false;
						flag48 = false;
						bool flag49 = false;
						num55 = 0;
						bool flag50 = num43 == 998 || num43 == 997;
						if (flag50)
						{
							string text = Class22.smethod_28(gstruct2.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct2.int_137, 20);
							flag49 = (0 <= text.IndexOf("Tr­êng B¹ch"));
						}
						bool flag51 = !flag49 && gstruct2.int_105 > 0 && (num43 == 333 || num43 == 998) && Class12.smethod_28(long_6) > 6000L;
						if (flag51)
						{
							bool flag52 = num16 <= 0;
							if (flag52)
							{
								int[] array7 = Class34.smethod_0(gstruct2);
								num16 = ((array7 != null && (array7[0] <= 0 || array7[1] <= 0 || array7[2] <= 0)) ? 1 : 0);
							}
							bool flag53 = num16 > 0;
							if (flag53)
							{
								array8 = null;
								num4 = -1;
								array5 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								bool flag54 = 0 <= Form1.int_0 && Form1.int_0 < Form1.string_4.GetLength(0) && (num43 == 998 || 0 <= Form1.string_4[Form1.int_0, 0].IndexOf("jxbisu"));
								if (flag54)
								{
									int num56 = Class42.smethod_2(num43);
									bool flag55 = 0 <= num56;
									if (flag55)
									{
										array8 = Class42.smethod_3(Class42.gstruct19_0[num56], array5, "HIEUTHUOC", false);
									}
								}
								bool flag56 = array8 == null;
								if (flag56)
								{
									array8 = Class43.smethod_10(array5, num43, "HIEUTHUOC", true);
								}
								bool flag57 = array8 != null;
								if (flag57)
								{
									bool flag58 = num23 > 0;
									if (flag58)
									{
										Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
									}
									num23 = 0;
									long num57 = Class60.smethod_18(array5, array8);
									bool flag59 = num57 > 160000L;
									if (flag59)
									{
										array9 = Class42.smethod_1(num43, array5, array8, null, false);
										bool flag60 = array9 != null;
										if (flag60)
										{
											goto Block_83;
										}
									}
								}
							}
							num16 = 0;
							long_6 = Class12.smethod_27();
						}
						bool flag61 = gstruct2.bool_1 && (flag3 || num44 > 0) && num17 != gstruct2.int_0;
						if (flag61)
						{
							goto Block_86;
						}
						bool flag62 = Class44.gstruct33_0.int_0 == gstruct2.int_136;
						if (flag62)
						{
							Class44.gstruct33_0.bool_1 = false;
						}
						bool flag63 = num44 <= 0;
						if (flag63)
						{
							Thread.Sleep(100);
							bool flag64 = gstruct2.int_104[0] > 0 && gstruct2.int_104[1] <= num50;
							if (flag64)
							{
								goto Block_93;
							}
							int num58 = Class79.smethod_4(gstruct2);
							bool flag65 = gstruct2.int_133[0] <= 0 && (!flag3 || num4 < 0 || num4 != num58);
							if (flag65)
							{
								goto Block_98;
							}
							bool flag66 = gstruct2.int_65 > 0 && !flag12;
							if (flag66)
							{
								uint num59 = num35 + Class53.gstruct51_12.uint_0 + Class53.gstruct51_75.uint_0;
								Class22.ReadProcessMemory(gstruct2.int_137, num59 + Class53.gstruct51_73.uint_0, array3, 4, ref num25);
								uint num60 = BitConverter.ToUInt32(array3, 0);
								bool flag67 = (long)gstruct2.int_66 != (long)((ulong)num60);
								if (flag67)
								{
									Class60.smethod_3(gstruct2, ref flag5);
								}
								flag12 = true;
							}
							bool flag68 = flag8;
							if (flag68)
							{
								long num61 = (long)((ulong)Class22.smethod_30(num39 + Class53.gstruct51_45.uint_0, gstruct2.int_137));
								long num62 = (long)((ulong)(Class22.smethod_30(num39 + Class53.gstruct51_47.uint_0, gstruct2.int_137) + 1U));
								long num63 = (long)((ulong)(Class22.smethod_30(num39 + Class53.gstruct51_47.uint_0 + 4U, gstruct2.int_137) + 1U));
								long num64 = (long)((ulong)Class22.smethod_30(num39 + Class53.gstruct51_46.uint_0, gstruct2.int_137));
								long num65 = (long)((ulong)(Class22.smethod_30(num39 + Class53.gstruct51_48.uint_0, gstruct2.int_137) + 1U));
								long num66 = (long)((ulong)(Class22.smethod_30(num39 + Class53.gstruct51_48.uint_0 + 4U, gstruct2.int_137) + 1U));
								bool flag69 = num63 > num62 && num63 < 150000L;
								if (flag69)
								{
									num62 = num63;
								}
								bool flag70 = num66 > num65 && num66 < 150000L;
								if (flag70)
								{
									num65 = num66;
								}
								double num67 = (double)(num61 * 100L / num62);
								double num68 = (double)(num64 * 100L / num65);
								bool flag71 = ((num62 > 100L && gstruct2.int_106[0] > 0 && gstruct2.int_106[1] > 0 && num61 <= (long)gstruct2.int_106[1]) || (gstruct2.int_109[0] > 0 && gstruct2.int_109[1] > 0 && num67 <= (double)gstruct2.int_109[1])) && Class32.smethod_6(gstruct2, 0, 1, false) > 0;
								if (flag71)
								{
									Thread.Sleep(300);
								}
								bool flag72 = ((num65 > 50L && gstruct2.int_107[0] > 0 && gstruct2.int_107[1] > 0 && num64 <= (long)gstruct2.int_107[1]) || (gstruct2.int_111[0] > 0 && gstruct2.int_111[1] > 0 && num68 <= (double)gstruct2.int_111[1])) && Class32.smethod_6(gstruct2, 1, 1, false) > 0;
								if (flag72)
								{
									Thread.Sleep(300);
								}
								num4 = Class79.smethod_4(gstruct2);
								flag8 = false;
							}
						}
						else
						{
							flag = false;
							flag3 = false;
							flag8 = true;
							bool flag73 = ((Form1.int_115 > 0 && !Class18.smethod_0(num43)) || (gstruct2.int_104[0] > 0 && gstruct2.int_104[1] <= num50)) && !Class60.smethod_14(gstruct2, true) && Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
							if (flag73)
							{
								Class35.smethod_140(gstruct2, 162, "b¾c", null, false);
							}
						}
						uint num69 = 0U;
						uint[] uint_3 = null;
						array10 = new uint[2];
						flag74 = false;
						flag75 = false;
						num43 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
						num44 = (int)Class22.smethod_30(num39 + Class53.gstruct51_43.uint_0, gstruct2.int_137);
						bool flag76 = FormMayphu.bool_7 || (FormMayphu.bool_6 && Class56.smethod_0(num43) != null);
						bool flag77 = Form1.int_114 > 0 && num44 <= 0;
						if (flag77)
						{
							bool flag78 = flag76 && (gstruct2.int_136 != Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 == 0) && num44 == 0 && Class44.gstruct33_0.int_3 <= 0;
							if (flag78)
							{
								bool flag79 = Class12.smethod_28(long_5) > 10000L;
								if (flag79)
								{
									Class70.smethod_52(gstruct2, Class12.smethod_53(Class12.string_0), 1);
									long_5 = Class12.smethod_27();
								}
							}
							else
							{
								bool flag80 = FormTapKet.gstruct62_0 == null || FormTapKet.gstruct62_0.Length == 0;
								if (flag80)
								{
									bool flag81 = !flag14;
									if (flag81)
									{
										flag14 = true;
										FormTapKet.smethod_2();
									}
									bool flag82 = FormTapKet.gstruct62_0 == null || FormTapKet.gstruct62_0.Length == 0;
									if (flag82)
									{
										goto IL_458D;
									}
								}
								bool flag83 = !flag5 && gstruct2.string_15 != null && gstruct2.string_15 != string.Empty;
								if (flag83)
								{
									uint num70 = Class12.smethod_12(gstruct2.string_15);
									bool flag84 = num70 > 0U;
									if (flag84)
									{
										Class70.smethod_117(gstruct2, num70);
										Thread.Sleep(150);
										flag5 = true;
									}
								}
								bool flag85 = Class12.smethod_28(long_5) > 8000L;
								if (flag85)
								{
									Class70.smethod_52(gstruct2, "Ra diem tap ket.", 1);
									long_5 = Class12.smethod_27();
								}
								j = 0;
								while (j < FormTapKet.gstruct62_0.Length)
								{
									bool flag86 = num43 != FormTapKet.gstruct62_0[j].int_1 && FormTapKet.gstruct62_0[j].int_0 <= 0;
									if (flag86)
									{
										num33 = j;
										j = num33 + 1;
									}
									else
									{
										bool flag87 = gstruct2.int_65 > 0;
										if (flag87)
										{
											Class60.smethod_3(gstruct2, ref flag5);
										}
										int num71 = Class79.smethod_4(gstruct2);
										int num72 = FormTapKet.smethod_0(gstruct2.int_136);
										bool flag88 = num72 <= 0 || Class79.smethod_4(gstruct2) <= num71;
										if (flag88)
										{
											goto Block_426;
										}
										break;
									}
								}
							}
							IL_458D:
							flag14 = true;
							goto IL_460F;
							goto IL_458D;
						}
						IL_460F:
						array5 = new uint[]
						{
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
						};
						bool flag89 = gstruct2.int_125 != null && gstruct2.int_125.Length > 4 && (Form1.int_75 > 0 || gstruct2.int_125[0] > 0) && gstruct2.int_125[2] > 0 && gstruct2.int_125[3] > 0 && gstruct2.int_125[4] > 0;
						flag90 = ((Form1.int_6 > 0 || Form1.int_7 > 0) && (Form1.int_75 > 0 || gstruct2.int_125[0] > 0) && Class44.gstruct33_1.int_11 != null && Class44.gstruct33_1.int_11[0] > 0 && Class44.gstruct33_1.int_11[1] > 0 && Class44.gstruct33_1.int_11[2] > 0 && Class44.gstruct33_1.int_11[3] > 0);
						bool flag92;
						bool flag91 = (flag92 = (flag89 || flag90)) && (!flag11 || Form1.int_76 <= 0) && (!FormMayphu.bool_1 || (Form1.int_7 <= 0 && Form1.int_6 <= 0));
						if (flag91)
						{
							bool flag93 = !flag76;
							if (flag93)
							{
								goto Block_443;
							}
							flag92 = false;
							bool flag94 = Class12.smethod_28(long_5) > 10000L;
							if (flag94)
							{
								Class70.smethod_52(gstruct2, Class12.smethod_53(Class12.string_0), 1);
								long_5 = Class12.smethod_27();
							}
						}
						bool flag95 = Form1.int_115 > 0 && !Class18.smethod_0(num43);
						if (flag95)
						{
							goto Block_489;
						}
						flag96 = false;
						bool flag97 = (flag74 = ((!gstruct2.bool_1 || gstruct2.int_0 < 0 || FormChayBoss.string_2.GetLength(0) <= gstruct2.int_0 || FormChayBoss.string_2[gstruct2.int_0, 0][0] == '.' || (Class44.gstruct33_0.int_4 == num43 && Class44.gstruct33_0.int_3 > 0 && !Class44.gstruct33_0.bool_1)) && Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct2.int_136 && Class44.gstruct33_0.int_6 > 0 && Class12.smethod_62(Class44.gstruct33_0.uint_4) && (Form1.int_22 > 0 || Class44.gstruct33_0.int_3 > 0))) && gstruct2.int_136 != Class44.gstruct33_0.int_0;
						if (!flag97)
						{
							goto IL_6A51;
						}
						bool flag98 = Class44.gstruct33_0.int_4 == num43;
						if (!flag98)
						{
							goto IL_5895;
						}
						bool flag99 = Class44.gstruct33_0.uint_4 != null;
						if (!flag99)
						{
							goto IL_5890;
						}
						bool flag100 = num44 > 0;
						if (flag100)
						{
							flag4 = true;
							num27 = 0;
						}
						num5 = 0;
						bool flag101 = Form1.int_22 > 0 && Class44.gstruct33_0.int_3 <= 0 && num44 <= 0 && Class12.smethod_1(Class44.gstruct33_0.string_1, "m b¸o d") > 0;
						if (flag101)
						{
							array5 = new uint[]
							{
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
							};
							uint[] array11 = new uint[]
							{
								49213U,
								101084U
							};
							array12 = new uint[]
							{
								50192U,
								98662U
							};
							uint[] uint_4 = new uint[]
							{
								49318U,
								101744U
							};
							uint[] uint_5 = new uint[]
							{
								50579U,
								98932U
							};
							long num73 = Class60.smethod_18(array5, uint_5);
							long num74 = Class60.smethod_18(array5, uint_4);
							flag102 = (num74 < num73);
							num73 = Class60.smethod_18(Class44.gstruct33_0.uint_4, uint_5);
							num74 = Class60.smethod_18(Class44.gstruct33_0.uint_4, uint_4);
							bool flag103 = num74 < num73 != flag102;
							if (flag103)
							{
								goto Block_518;
							}
						}
						long num75 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
						bool flag104 = gstruct2.int_130[0] > 0 && gstruct2.int_136 != Class44.gstruct33_0.int_0 && num44 == Class44.gstruct33_0.int_3 && num44 > 0;
						if (flag104)
						{
							int num76 = gstruct2.int_130[1] + Form1.int_23;
							bool flag105 = num75 <= (long)(num76 * num76) && Class64.smethod_0(gstruct2, Class44.gstruct33_0.uint_4, gstruct2.int_130[1]) > 0;
							if (flag105)
							{
								goto Block_528;
							}
						}
						bool flag106 = flag9 || num75 > (long)(num54 * num54);
						if (!flag106)
						{
							Class14.smethod_2(gstruct2, false);
							int num77 = num9;
							num9 = 0;
							num27 = 0;
							num28 = 0;
							num8 = 0;
							bool flag107 = num44 > 0 && !gstruct2.bool_22 && gstruct2.int_93 == 1 && Form1.int_102 > 0 && (Form1.int_31 > 0 || Form1.int_30 > 0 || Form1.int_32 > 0) && Class22.smethod_30(num39 + Class53.gstruct51_43.uint_0, gstruct2.int_137) > 0U;
							if (flag107)
							{
								Class60.smethod_30(gstruct2);
							}
							bool flag108 = num15 <= 0L || Class12.smethod_28(num15) >= 1500L;
							if (!flag108)
							{
								goto IL_588F;
							}
							array13 = new uint[]
							{
								array5[0],
								array5[1]
							};
							bool flag109 = Class44.smethod_5(num40, ref array5, ref num7) > 0;
							if (!flag109)
							{
								goto IL_57C8;
							}
							num78 = Class60.smethod_18(array13, Class44.gstruct33_0.uint_4);
							long num79 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
							bool flag110 = num79 > (long)(num54 * num54);
							if (!flag110)
							{
								goto IL_5762;
							}
							bool flag111 = num77 > 0;
							if (flag111)
							{
								uint[] uint_6 = Class60.smethod_5(array5, Class44.gstruct33_0.uint_4, -100);
								Class70.smethod_61(gstruct2, uint_6);
								Thread.Sleep(120);
							}
						}
						flag9 = (num75 > 40000L);
						Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
						num23 = 0;
						bool flag112 = !flag6 && num43 == 336;
						if (flag112)
						{
							flag6 = true;
							int num80 = 0;
							int num81 = 0;
							long num82 = Class60.smethod_21(Class41.uint_0, array5);
							long num83 = Class60.smethod_21(Class41.uint_1, array5);
							bool flag113 = num82 < num83;
							if (flag113)
							{
								num80 = 1;
							}
							num82 = Class60.smethod_21(Class41.uint_0, Class44.gstruct33_0.uint_4);
							num83 = Class60.smethod_21(Class41.uint_1, Class44.gstruct33_0.uint_4);
							bool flag114 = num82 < num83;
							if (flag114)
							{
								num81 = 1;
							}
							bool flag115 = num80 != num81;
							if (flag115)
							{
								goto Block_677;
							}
						}
						bool flag116 = array == null;
						if (flag116)
						{
							array = new uint[]
							{
								array5[0],
								array5[1]
							};
							num8 = 0;
						}
						bool flag117 = num8 > 6;
						if (flag117)
						{
							long num84 = Class60.smethod_18(array, array5);
							array = null;
							bool flag118 = num84 < 180000L;
							if (flag118)
							{
								Class14.smethod_2(gstruct2, false);
								Class60.smethod_2(gstruct2, array5, Class44.gstruct33_0.uint_4, 600);
							}
							num8 = 0;
						}
						bool flag119 = num75 > (long)(Form1.int_101 * Form1.int_101);
						if (flag119)
						{
							Class60.smethod_29(gstruct2, false);
						}
						array5 = new uint[]
						{
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
						};
						num75 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
						bool flag120 = num75 < 600000L;
						if (flag120)
						{
							bool flag121 = num9 > 10;
							if (flag121)
							{
								uint[] array14 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								Thread.Sleep(300);
								array5 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								bool flag122 = Class60.smethod_18(array14, array5) > 600L;
								if (flag122)
								{
									num9 = 0;
								}
							}
							bool flag123 = num9 <= 10;
							if (flag123)
							{
								goto Block_685;
							}
						}
						bool flag124 = num43 == Class39.int_0;
						if (flag124)
						{
							goto Block_686;
						}
						bool flag125 = false;
						bool flag126 = Class44.gstruct33_0.int_4 == 1;
						if (flag126)
						{
							uint[] uint_7 = new uint[]
							{
								50016U,
								88321U
							};
							long num85 = Class60.smethod_18(Class44.gstruct33_0.uint_4, uint_7);
							flag125 = (num85 <= 2000000L);
						}
						else
						{
							bool flag127 = Class44.gstruct33_0.int_4 == 53;
							if (flag127)
							{
								uint[] uint_8 = new uint[]
								{
									49440U,
									105824U
								};
								long num86 = Class60.smethod_18(Class44.gstruct33_0.uint_4, uint_8);
								flag125 = (num86 <= 2000000L);
							}
						}
						bool flag128 = flag125 && !flag13;
						if (flag128)
						{
							flag13 = true;
							bool flag129 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0 && Class35.smethod_142(gstruct2, Class44.gstruct33_0.int_4) > 0;
							if (flag129)
							{
								goto Block_695;
							}
						}
						int[] array15 = Class60.smethod_9(num43);
						bool flag130 = array15 != null && num44 > 0 && Class44.gstruct33_0.int_3 <= 0 && Form1.int_22 > 0 && !flag125;
						if (flag130)
						{
							bool flag131 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
							if (flag131)
							{
								Class14.smethod_2(gstruct2, false);
								bool flag132 = Class35.smethod_140(gstruct2, Class44.gstruct33_0.int_4, null, Class44.gstruct33_0.uint_4, false);
								if (flag132)
								{
									goto Block_702;
								}
							}
							bool flag133 = Class60.smethod_14(gstruct2, true);
							if (flag133)
							{
								goto Block_703;
							}
						}
						bool flag134 = num44 <= 0 && array15 != null && Class44.gstruct33_0.int_3 > 0;
						array5 = new uint[]
						{
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
						};
						num75 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
						bool flag135 = Form1.int_84 > 0 && flag4 && flag134;
						if (flag135)
						{
							flag4 = false;
							bool flag136 = num75 < 900000L;
							if (flag136)
							{
								goto Block_707;
							}
							uint[] uint_9 = null;
							bool flag137 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_4 == num43;
							if (flag137)
							{
								uint_9 = Class44.gstruct33_0.uint_4;
							}
							bool flag138 = Class50.smethod_2(gstruct2, "®iÓm c", uint_9, null, 0) > 0;
							if (flag138)
							{
								goto Block_711;
							}
						}
						bool flag139 = num44 == 0 && Class44.gstruct33_0.int_3 > 0 && Class56.smethod_0(num43) != null;
						if (flag139)
						{
							goto Block_714;
						}
						array16 = new uint[]
						{
							Class44.gstruct33_0.uint_4[0],
							Class44.gstruct33_0.uint_4[1]
						};
						Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
						num44 = BitConverter.ToInt32(array3, 0);
						array5 = new uint[]
						{
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
							Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
						};
						num75 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
						bool flag140 = num43 == 998 || num43 == 997;
						if (flag140)
						{
							string text2 = Class22.smethod_28(gstruct2.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct2.int_137, 20);
							bool flag141 = 0 <= text2.IndexOf("Tr­êng B¹ch");
							if (flag141)
							{
								goto Block_717;
							}
						}
						int num87 = num43;
						int num88 = num87;
						if (num88 != 53)
						{
							if (num88 != 333 && num88 != 998)
							{
								bool flag142 = num28 > 0 || (num43 != 959 && num43 != 990 && num43 != 991 && (num44 != 0 || array15 == null));
								if (flag142)
								{
									goto Block_726;
								}
								num28 = 1;
								uint[,] array17 = Class42.smethod_1(num43, array5, Class44.gstruct33_0.uint_4, null, false);
								bool flag143 = array17 != null;
								if (!flag143)
								{
									goto IL_758A;
								}
								num75 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
								uint[] uint_10 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								int num89 = Class60.smethod_22(gstruct2, array17, array5, null, num43, false, Class60.smethod_1(num75), false);
								array5 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								num75 = Class60.smethod_18(array5, uint_10);
								bool flag144 = num89 > 0 && num75 > 600000L;
								if (!flag144)
								{
									goto IL_7589;
								}
								num28 = 0;
							}
							else
							{
								bool flag145 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0 && num75 > 15354505L && Form1.string_3 == "vltrungnguyen.com";
								if (flag145)
								{
									num75 = -1L;
									int num90 = -1;
									for (int k = 0; k < Class94.gstruct23_0.Length; k = num33 + 1)
									{
										long num91 = Class60.smethod_18(Class44.gstruct33_0.uint_4, Class94.gstruct23_0[k].uint_0);
										bool flag146 = num90 < 0 || num91 < num75;
										if (flag146)
										{
											num90 = k;
											num75 = num91;
										}
										num33 = k;
									}
									Class14.smethod_2(gstruct2, false);
									bool flag147 = Class35.smethod_141(gstruct2, "b¶n ®å|§Æc BiÖt|" + Class94.gstruct23_0[num90].string_0);
									if (flag147)
									{
										num9 = 0;
										Thread.Sleep(180);
										break;
									}
								}
								flag148 = Class94.smethod_0(array5);
								bool flag149 = Class94.smethod_0(Class44.gstruct33_0.uint_4);
								bool flag150 = flag148 == flag149;
								if (flag150)
								{
									bool flag151 = flag148;
									if (flag151)
									{
										goto Block_738;
									}
									long num92 = Class60.smethod_21(Class94.uint_0, array5);
									long num93 = Class60.smethod_21(Class94.uint_0, Class44.gstruct33_0.uint_4);
									long num94 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
									bool flag152 = num92 > 1500000L && num93 > 1500000L && num94 > 1500000L;
									if (!flag152)
									{
										goto IL_7830;
									}
									array18 = Class94.smethod_1(array5);
									num75 = Class60.smethod_21(array18, array5);
									bool flag153 = num75 <= 300000L;
									if (!flag153)
									{
										goto IL_780D;
									}
									Class60.smethod_22(gstruct2, array18, array5, null, num43, false, 6000, true);
									num9 = 0;
									num33 = num8;
									num8 = num33 + 1;
								}
								else
								{
									uint[,] array19 = Class94.smethod_1(Class44.gstruct33_0.uint_4);
									array18 = Class94.smethod_1(array5);
									int length = array19.GetLength(0);
									int length2 = array18.GetLength(0);
									bool flag154 = !flag148;
									long num95;
									long num96;
									if (flag154)
									{
										num95 = Class60.smethod_19(array5, array19[0, 0], array19[0, 1]);
										num95 += Class60.smethod_19(new uint[]
										{
											array19[0, 0],
											array19[0, 1]
										}, array19[length - 1, 0], array19[length - 1, 1]);
										num95 += Class60.smethod_19(Class44.gstruct33_0.uint_4, array19[length - 1, 0], array19[length - 1, 1]);
										num96 = Class60.smethod_19(array5, array18[0, 0], array18[0, 1]);
										num96 += Class60.smethod_19(new uint[]
										{
											array18[0, 0],
											array18[0, 1]
										}, array18[length2 - 1, 0], array18[length2 - 1, 1]);
										num96 += Class60.smethod_19(Class44.gstruct33_0.uint_4, array18[length2 - 1, 0], array18[length2 - 1, 1]);
									}
									else
									{
										num95 = Class60.smethod_19(array5, array19[length - 1, 0], array19[length - 1, 1]);
										num95 += Class60.smethod_19(new uint[]
										{
											array19[0, 0],
											array19[0, 1]
										}, array19[length - 1, 0], array19[length - 1, 1]);
										num95 += Class60.smethod_19(Class44.gstruct33_0.uint_4, array19[0, 0], array19[0, 1]);
										num96 = Class60.smethod_19(array5, array18[length2 - 1, 0], array18[length2 - 1, 1]);
										num96 += Class60.smethod_19(new uint[]
										{
											array18[0, 0],
											array18[0, 1]
										}, array18[length2 - 1, 0], array18[length2 - 1, 1]);
										num96 += Class60.smethod_19(Class44.gstruct33_0.uint_4, array18[0, 0], array18[0, 1]);
									}
									uint[,] array20 = (num95 <= num96) ? array19 : array18;
									uint[] array21 = new uint[]
									{
										array20[0, 0],
										array20[0, 1]
									};
									uint[] array22 = new uint[]
									{
										array20[array20.GetLength(0) - 1, 0],
										array20[array20.GetLength(0) - 1, 1]
									};
									num75 = Class60.smethod_21(array20, array5);
									bool flag155 = num75 > 300000L;
									if (flag155)
									{
										goto Block_745;
									}
									bool flag156 = !flag148;
									if (flag156)
									{
										Class60.smethod_22(gstruct2, array20, array5, array22, num43, false, 6000, true);
									}
									else
									{
										Class60.smethod_22(gstruct2, array20, array5, array21, num43, false, 6000, true);
									}
									num9 = 0;
									num33 = num8;
									num8 = num33 + 1;
								}
							}
						}
						else
						{
							bool flag157 = num27 < 6 && num44 <= 0;
							if (!flag157)
							{
								goto IL_7ECD;
							}
							uint[] uint_11 = Class44.gstruct33_0.uint_4;
							bool flag158 = Class84.gstruct21_0 == null;
							if (flag158)
							{
								Class84.gstruct21_0 = Class84.smethod_1();
							}
							bool flag159 = Class44.gstruct33_0.int_3 > 0;
							if (flag159)
							{
								uint_11 = Class84.smethod_0(uint_11);
							}
							uint[,] array23 = Class43.smethod_9(Class84.gstruct21_0, array5, uint_11, 60000);
							uint[] array24 = array5;
							int num97 = Class60.smethod_22(gstruct2, array23, array5, uint_11, 53, true, 8000, false);
							array5 = new uint[]
							{
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
							};
							bool flag160 = array24 != null && num97 > 0 && (array24[0] != array5[0] || array24[1] != array5[1]);
							if (!flag160)
							{
								goto IL_7EC9;
							}
							num33 = num27;
							num27 = num33 + 1;
						}
					}
				}
				IL_86EB:
				Block_32:
				continue;
				IL_87DC:
				flag3 = false;
				Thread.Sleep(300);
				continue;
				IL_87CE:
				Thread.Sleep(300);
				continue;
				IL_8750:
				bool flag161 = num23 > 0;
				if (flag161)
				{
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
				}
				bool flag162 = Form1.int_121 > 0;
				if (flag162)
				{
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_251.uint_0, Class53.byte_0, Class53.byte_0.Length, ref num25);
				}
				num23 = 0;
				num24 = 0;
				num29 = -1;
				continue;
				IL_872A:
				bool flag163 = num47 <= 1;
				if (flag163)
				{
					flag5 = false;
				}
				Thread.Sleep(60);
				continue;
				IL_86EE:
				bool flag164 = gstruct2.int_94 <= 0 && (Form1.int_38 <= 0 || Form1.int_37 <= 0);
				if (flag164)
				{
					num16 = 0;
				}
				flag10 = true;
				continue;
				Block_83:
				Class60.smethod_22(gstruct2, array9, array5, array8, num43, false, 8000, true);
				continue;
				Block_86:
				bool flag165 = FormChayBoss.smethod_2(gstruct2) > 0;
				if (flag165)
				{
					num17 = gstruct2.int_0;
					bool flag166 = flag3;
					if (flag166)
					{
						flag3 = (num44 <= 0);
					}
					bool flag167 = Class44.gstruct33_0.int_0 == gstruct2.int_136;
					if (flag167)
					{
						Class44.gstruct33_0.bool_1 = false;
					}
				}
				array3[0] = 0;
				Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
				continue;
				Block_93:
				int l = 0;
				byte[] array25 = Class12.smethod_46("Kh«ng thÓ tiÕp tôc v× PK qu¸ cao (vao Hau can -> phuc hoi, un-check pk cao).", true);
				while (l < 6)
				{
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_251.uint_0, array25, array25.Length, ref num25);
					Thread.Sleep(100);
					num33 = l;
					l = num33 + 1;
				}
				continue;
				Block_98:
				bool flag168 = Class56.smethod_0(num43) != null && Class12.smethod_28(long_5) > 8000L;
				if (flag168)
				{
					string text3 = Class22.smethod_28(gstruct2.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0, gstruct2.int_137, 20);
					bool flag169 = (num43 != 989 || 0 > text3.IndexOf("Ph­îng Ho")) && (num43 != 977 || (0 > text3.IndexOf("Cæ L") && 0 > text3.IndexOf("Hßa B")));
					if (flag169)
					{
						string text4 = "§ang ë b¶n ®å Tèng Kim, h·y chuyÓn auto tõ WAR -> TK ®Ó tèi ­u h¬n.";
						Class70.smethod_52(gstruct2, "<bclr=blue><color=green>" + text4, 1);
						bool flag170 = gstruct2.int_136 != Class44.gstruct33_0.int_0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.string_0 != null && Class44.gstruct33_0.string_0 != string.Empty;
						if (flag170)
						{
							Class70.smethod_50(gstruct2, Class44.gstruct33_0.string_0, text4);
						}
						long_5 = Class12.smethod_27();
					}
				}
				bool flag171 = !Form1.bool_4;
				if (flag171)
				{
					bool flag172 = Class40.smethod_0(gstruct2) == 0;
					if (flag172)
					{
						Thread.Sleep(300);
						continue;
					}
					int num98 = Class34.smethod_3(gstruct2, Form1.int_98 <= 0);
					bool flag173 = num98 < 0 && !flag7;
					if (flag173)
					{
						Thread.Sleep(300);
						flag7 = (num98 < 0);
						continue;
					}
				}
				flag3 = true;
				flag7 = false;
				flag11 = false;
				flag12 = false;
				num4 = Class79.smethod_4(gstruct2);
				continue;
				IL_14A4:
				bool value = false;
				bool flag174 = num44 == 0;
				if (flag174)
				{
					int num99 = Class91.smethod_0(gstruct2, true, null);
					value = (num99 != 1);
				}
				array3[0] = Convert.ToByte(value);
				Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
				continue;
				IL_14FA:
				num18 = 0;
				num8 = 0;
				num27 = 0;
				num28 = 0;
				array = null;
				flag5 = false;
				flag6 = false;
				flag = false;
				flag11 = false;
				flag12 = false;
				int num100 = 0;
				int num101 = 0;
				for (;;)
				{
					bool flag175 = num != num43 && num101 < 15;
					if (!flag175)
					{
						goto IL_1715;
					}
					num33 = num101;
					num101 = num33 + 1;
					Thread.Sleep(100);
					num47 = Class83.smethod_39(gstruct2);
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
					num23 = 0;
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref num25);
					uint num35 = BitConverter.ToUInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num35 + Class53.gstruct51_13.uint_0, array3, 4, ref num25);
					bool flag176 = num25 != 4;
					if (flag176)
					{
						break;
					}
					uint num36 = BitConverter.ToUInt32(array3, 0);
					uint num37 = num36 * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref num25);
					bool flag177 = num25 != 4;
					if (flag177)
					{
						break;
					}
					uint num38 = BitConverter.ToUInt32(array3, 0);
					num39 = num38 + num37;
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_50.uint_0, array3, 4, ref num25);
					int num42 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num25);
					num43 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
					num44 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_55.uint_0, array3, 4, ref num25);
					int num41 = BitConverter.ToInt32(array3, 0);
					bool flag178 = num47 <= 1 || num42 <= 0 || num43 <= 0 || num41 <= 0;
					if (flag178)
					{
						num100 = 0;
					}
					else
					{
						bool flag179 = num44 <= 0 && num100 <= 3;
						if (!flag179)
						{
							goto IL_1714;
						}
						num33 = num100;
						num100 = num33 + 1;
					}
				}
				continue;
				IL_1715:
				bool flag180 = flag2;
				if (flag180)
				{
					flag2 = (num3 == num44 && num3 <= 0);
				}
				bool flag181 = num44 == 0 && num3 > 0;
				if (flag181)
				{
					flag3 = false;
				}
				num = num43;
				num2 = Class44.gstruct33_0.int_4;
				flag13 = false;
				continue;
				IL_1714:
				goto IL_1715;
				continue;
				IL_1764:
				Thread.Sleep(300);
				flag10 = false;
				flag4 = false;
				flag13 = false;
				continue;
				IL_177C:
				num44 = (int)Class22.smethod_30(num39 + Class53.gstruct51_43.uint_0, gstruct2.int_137);
				num43 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
				bool flag182 = num44 <= 0;
				if (flag182)
				{
					bool flag183 = !flag2 && Class44.gstruct33_0.int_4 != num43 && Class60.smethod_9(num43) != null;
					if (flag183)
					{
						Class50.smethod_4(gstruct2, Class44.gstruct33_0.int_4);
						flag2 = true;
						continue;
					}
				}
				else
				{
					flag4 = true;
				}
				bool flag184 = gstruct.uint_0 == null;
				if (flag184)
				{
					int num102 = Class86.smethod_0(gstruct2);
					Class70.smethod_59(gstruct2, 0, (int)Convert.ToByte(num102 != 0));
					flag74 = false;
					flag96 = true;
					goto IL_254C;
				}
				array5 = new uint[]
				{
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
				};
				int int_2 = 0;
				bool flag185 = gstruct.uint_0.GetLength(0) > 1;
				if (flag185)
				{
					int_2 = Class60.smethod_20(gstruct.uint_0, array5);
				}
				bool flag186 = num23 > 0;
				if (flag186)
				{
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
				}
				num23 = 0;
				Class60.smethod_8(gstruct.uint_0, int_2, ref uint_, ref uint_2, ref int_);
				long num103 = Class60.smethod_18(array5, uint_);
				bool flag187 = num103 <= 90000L;
				if (flag187)
				{
					Class60.smethod_23(gstruct2, uint_, int_, uint_2, gstruct.int_1);
					continue;
				}
				bool flag188 = array == null;
				if (flag188)
				{
					array = new uint[]
					{
						array5[0],
						array5[1]
					};
					num8 = 0;
				}
				bool flag189 = num8 > 6;
				if (flag189)
				{
					long num104 = Class60.smethod_18(array, array5);
					array = null;
					bool flag190 = num104 < 180000L;
					if (flag190)
					{
						Class60.smethod_2(gstruct2, array5, uint_, 600);
						continue;
					}
				}
				bool flag191 = !Class14.smethod_3(gstruct2) || Class12.smethod_28(long_3) > 4000L;
				if (flag191)
				{
					num33 = num8;
					num8 = num33 + 1;
					Class14.smethod_1(gstruct2, uint_);
					Thread.Sleep(300);
					Class60.smethod_10(gstruct2, string.Concat(new string[]
					{
						"Acc chÝnh ",
						Class44.gstruct33_0.string_1,
						" (",
						Class44.gstruct33_0.int_4.ToString(),
						")"
					}));
					long_3 = Class12.smethod_27();
				}
				Class60.smethod_29(gstruct2, false);
				continue;
				IL_5895:
				bool flag192 = num43 != Class39.int_0 && (Class44.gstruct33_0.int_4 == Class39.int_0 || ((Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 == Class39.int_0));
				if (flag192)
				{
					Class39.smethod_2(gstruct2);
					Thread.Sleep(300);
					continue;
				}
				bool flag193 = num43 == Class39.int_0;
				if (flag193)
				{
					bool flag195;
					bool flag194 = !(flag195 = (Form1.int_22 > 0));
					if (flag194)
					{
						bool flag196 = (Form1.int_6 > 0 || Form1.int_7 > 0) && Class44.gstruct33_1.int_4 > 0 && Class44.gstruct33_1.int_4 != Class39.int_0 && Class44.gstruct33_1.int_3 > 0;
						bool flag197 = Class44.gstruct33_0.int_4 != Class39.int_0 && Class44.gstruct33_0.int_3 > 0;
						flag195 = (flag196 || flag197);
					}
					bool flag198 = flag195;
					if (flag198)
					{
						Class39.smethod_0(gstruct2);
						Thread.Sleep(300);
						continue;
					}
				}
				bool flag199 = Form1.int_115 <= 0;
				if (flag199)
				{
					bool flag200 = num43 == 221 || num43 == 539;
					if (flag200)
					{
						Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
						bool flag201 = Class50.smethod_0(gstruct2, null) > 0;
						if (flag201)
						{
							continue;
						}
					}
					bool flag202 = num43 == 336 && Class44.gstruct33_0.int_4 == 341;
					if (flag202)
					{
						long num105 = Class60.smethod_21(Class41.uint_0, array5);
						long num106 = Class60.smethod_21(Class41.uint_1, array5);
						bool flag203 = num105 > num106;
						if (flag203)
						{
							flag96 = true;
							flag74 = false;
							goto IL_254C;
						}
						gstruct = Class43.smethod_4(num43, Class44.gstruct33_0.int_4);
					}
					else
					{
						bool flag204 = num43 == 175 || num43 == 195;
						if (flag204)
						{
							string string_ = "Tèng Kim Chiªu th|Phong V©n Chiªu­ th";
							bool flag205 = Class70.smethod_44(gstruct2, string_, false, -1, false);
							if (flag205)
							{
								Thread.Sleep(300);
								Class86.smethod_5(gstruct2, 0);
								continue;
							}
						}
						bool flag206 = num43 == 175;
						if (flag206)
						{
							gstruct = Class43.smethod_4(num43, 195);
						}
						else
						{
							bool flag207 = Class43.smethod_1(num43) && !Class43.smethod_1(Class44.gstruct33_0.int_4);
							if (flag207)
							{
								int int_3 = 11;
								int[] array26 = Class60.smethod_9(Class44.gstruct33_0.int_4);
								bool flag208 = array26 != null;
								if (flag208)
								{
									int_3 = Class60.int_0[array26[0], 0];
								}
								Class50.smethod_5(gstruct2, int_3);
								continue;
							}
							bool flag209 = flag46 || (Form1.int_22 <= 0 && Class44.gstruct33_0.int_3 <= 0);
							if (flag209)
							{
								flag96 = true;
								flag74 = false;
								goto IL_254C;
							}
							bool flag210 = Class44.gstruct33_0.int_4 == 333 && Form1.string_3 == "vltrungnguyen.com" && Class56.smethod_1(num43) == null;
							if (flag210)
							{
								long num107 = -1L;
								int num108 = -1;
								for (int m = 0; m < Class94.gstruct23_0.Length; m = num33 + 1)
								{
									long num109 = Class60.smethod_18(Class44.gstruct33_0.uint_4, Class94.gstruct23_0[m].uint_0);
									bool flag211 = num108 < 0 || num109 < num107;
									if (flag211)
									{
										num108 = m;
										num107 = num109;
									}
									num33 = m;
								}
								bool flag212 = Class35.smethod_141(gstruct2, "b¶n ®å|§Æc BiÖt|" + Class94.gstruct23_0[num108].string_0);
								if (flag212)
								{
									Thread.Sleep(180);
									continue;
								}
							}
							Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
							num44 = BitConverter.ToInt32(array3, 0);
							bool flag213 = num44 > 0 && Class44.gstruct33_0.int_3 <= 0;
							if (flag213)
							{
								gstruct = Class43.smethod_4(num43, Class44.gstruct33_0.int_4);
								bool flag214 = gstruct.int_0 != num43 || gstruct.int_1 != Class44.gstruct33_0.int_4;
								if (flag214)
								{
									bool flag215 = Class12.smethod_1(Class44.gstruct33_0.string_1, "Õn thuyÒ") <= 0;
									if (flag215)
									{
										bool flag216 = Form1.int_84 > 0 && num43 != 195;
										if (flag216)
										{
											bool flag217 = !flag;
											if (flag217)
											{
												bool flag218 = !Class44.gstruct33_0.bool_0 && Class44.gstruct33_0.int_3 <= 0;
												if (flag218)
												{
													num33 = num10;
													num10 = num33 + 1;
													bool flag219 = num10 > 3;
													if (flag219)
													{
														flag = true;
														num10 = 0;
														bool flag220 = Class60.smethod_14(gstruct2, true);
														if (flag220)
														{
															continue;
														}
													}
													Thread.Sleep(80);
												}
												bool flag221 = !flag;
												if (flag221)
												{
													num5 = 0;
													goto IL_254C;
												}
											}
											bool flag222 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
											if (flag222)
											{
												Class14.smethod_2(gstruct2, false);
												bool flag223 = Class35.smethod_140(gstruct2, Class44.gstruct33_0.int_4, null, Class44.gstruct33_0.uint_4, false);
												if (flag223)
												{
													continue;
												}
											}
										}
										bool flag224 = num5 < 3 && Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
										if (flag224)
										{
											Class14.smethod_2(gstruct2, false);
											bool flag225 = Class35.smethod_140(gstruct2, Class44.gstruct33_0.int_4, null, Class44.gstruct33_0.uint_4, false);
											if (flag225)
											{
												num33 = num5;
												num5 = num33 + 1;
												bool flag226 = num43 == 195;
												if (flag226)
												{
													try
													{
														array3[0] = 1;
														Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
													}
													catch
													{
													}
												}
												continue;
											}
											num5 = 3;
										}
										bool flag227 = !Class44.gstruct33_0.bool_0 && Class44.gstruct33_0.int_3 <= 0;
										if (flag227)
										{
											num33 = num10;
											num10 = num33 + 1;
											bool flag228 = num10 > 3;
											if (flag228)
											{
												num10 = 0;
												num5 = 0;
												bool flag229 = Class60.smethod_14(gstruct2, true);
												if (flag229)
												{
													continue;
												}
											}
											Thread.Sleep(80);
										}
										flag96 = true;
										flag74 = false;
									}
									goto IL_254C;
								}
								num10 = 0;
							}
							else
							{
								bool flag230 = num44 == 0 && Class44.gstruct33_0.int_3 <= 0;
								if (flag230)
								{
									bool flag231 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
									if (flag231)
									{
										num33 = num18;
										num18 = num33 + 1;
										bool flag232 = num18 >= 5;
										if (flag232)
										{
											bool flag233 = num18 == 15 && 0 <= Class86.smethod_0(gstruct2);
											if (flag233)
											{
												Class86.smethod_8(gstruct2, -1);
											}
											else
											{
												bool flag234 = num18 > 200;
												if (flag234)
												{
													num18 = 0;
												}
											}
										}
										else
										{
											Class14.smethod_2(gstruct2, false);
											bool flag235 = Class35.smethod_140(gstruct2, Class44.gstruct33_0.int_4, null, Class44.gstruct33_0.uint_4, false);
											if (flag235)
											{
												Thread.Sleep(180);
											}
										}
									}
									Class50.smethod_5(gstruct2, Class44.gstruct33_0.int_4);
									continue;
								}
								bool flag236 = num44 == 0 && Class44.gstruct33_0.int_3 > 0;
								if (flag236)
								{
									bool flag237 = Form1.int_84 > 0 || Class70.smethod_3(gstruct2, Class70.uint_19, 4) == 0;
									if (flag237)
									{
										bool flag238 = flag4;
										if (flag238)
										{
											flag4 = false;
											uint[] uint_12 = null;
											bool flag239 = Form1.int_21 > 0 && Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_4 == num43;
											if (flag239)
											{
												uint_12 = Class44.gstruct33_0.uint_4;
											}
											bool flag240 = Class50.smethod_2(gstruct2, "®iÓm c", uint_12, null, 0) > 0;
											if (flag240)
											{
												Class60.smethod_11(gstruct2, 15000);
											}
											continue;
										}
										bool flag241 = !flag2;
										if (flag241)
										{
											flag2 = true;
											Class50.smethod_4(gstruct2, Class44.gstruct33_0.int_4);
											continue;
										}
									}
									bool flag242 = Class44.gstruct33_0.int_4 == 181 && Class35.int_0 > 0;
									bool flag243 = false;
									bool flag244 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) <= 0 || flag242;
									int num113;
									if (!flag244)
									{
										int num110 = Class44.gstruct33_0.int_4;
										int num111 = Class35.smethod_137(num110);
										bool flag245 = num111 < 0 && Class44.gstruct33_0.int_4 == 76;
										if (flag245)
										{
											num110 = 75;
											num111 = Class35.smethod_137(75);
										}
										uint[] uint_13 = null;
										bool flag246 = num110 == Class44.gstruct33_0.int_4;
										if (flag246)
										{
											uint_13 = Class44.gstruct33_0.uint_4;
										}
										bool flag247 = 0 > num111;
										if (flag247)
										{
											bool flag248 = num43 != 103 && num43 != 114 && num43 != 110 && (Class44.gstruct33_0.int_4 == 110 || Class44.gstruct33_0.int_4 == 114) && Class35.smethod_140(gstruct2, 103, null, null, false);
											if (flag248)
											{
												Thread.Sleep(300);
												Class60.smethod_11(gstruct2, 15000);
												Thread.Sleep(600);
												int num112 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
												bool flag249 = num112 != num43;
												if (flag249)
												{
													continue;
												}
											}
										}
										else
										{
											Class14.smethod_2(gstruct2, false);
											bool flag251;
											bool flag250 = ((flag251 = (Class35.struct14_0[num111].string_3 == null || Class35.struct14_0[num111].string_3 == string.Empty)) || num18 < 10) && Class35.smethod_140(gstruct2, num110, null, uint_13, false);
											if (flag250)
											{
												bool flag252 = !flag251;
												if (flag252)
												{
													num33 = num18;
													num18 = num33 + 1;
												}
												Thread.Sleep(300);
												Class60.smethod_11(gstruct2, 15000);
												Thread.Sleep(600);
											}
											bool flag253 = !flag251;
											if (flag253)
											{
												num18 = 0;
												Class50.smethod_2(gstruct2, Class35.struct14_0[num111].string_3, null, null, 0);
												continue;
											}
										}
										num113 = Class60.smethod_7(num43, Class44.gstruct33_0.int_4, ref gstruct);
										bool flag254 = num113 != 0;
										if (flag254)
										{
											gstruct = Class43.smethod_4(num43, Class44.gstruct33_0.int_4);
											bool flag255 = gstruct.int_0 != num43 || gstruct.int_1 != Class44.gstruct33_0.int_4;
											if (flag255)
											{
												bool flag256 = flag2 && num113 > 0 && num18 < 7;
												if (flag256)
												{
													uint[] uint_14 = Class44.gstruct33_0.uint_4;
													bool flag257 = Class60.smethod_7(num113, Class44.gstruct33_0.int_4, ref gstruct) == 0 && gstruct.uint_0 != null;
													if (flag257)
													{
														uint_14 = new uint[]
														{
															gstruct.uint_0[0, 0],
															gstruct.uint_0[0, 1]
														};
													}
													num33 = num18;
													num18 = num33 + 1;
													Class35.smethod_140(gstruct2, num113, null, uint_14, false);
													continue;
												}
												flag243 = (num111 < 0);
												goto IL_8218;
											}
											else
											{
												num10 = 0;
											}
										}
										goto IL_6A46;
									}
									IL_8218:
									bool flag258 = false;
									int[] array27 = Class60.smethod_9(num43);
									bool flag259 = array27 == null && Class44.gstruct33_0.int_4 > 0 && Class56.smethod_1(num43) != null && Class56.smethod_0(Class44.gstruct33_0.int_4) == null;
									if (flag259)
									{
										Class50.smethod_5(gstruct2, 11);
										Thread.Sleep(600);
										Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num25);
										int num114 = BitConverter.ToInt32(array3, 0);
										bool flag260 = num114 != num43;
										if (flag260)
										{
											array3[0] = 1;
											Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
											continue;
										}
									}
									bool flag261 = Class18.smethod_0(Class44.gstruct33_0.int_4);
									if (flag261)
									{
										Class50.smethod_2(gstruct2, "ChiÕn Long|H¸i Qu¶ H|L­ìng Thñy ", null, null, 0);
										flag258 = true;
									}
									else
									{
										bool flag262 = Class44.gstruct33_0.int_4 == 181;
										if (flag262)
										{
											Class50.smethod_2(gstruct2, "h÷ng n¬i ®· ®i q|L­ìng Thñy|" + Class44.gstruct33_0.string_1, null, null, 0);
											flag258 = true;
										}
										else
										{
											bool flag263 = Class44.gstruct33_0.int_4 != 224;
											if (flag263)
											{
												bool flag264 = Class44.gstruct33_0.int_4 != 993;
												if (flag264)
												{
													bool flag265 = num44 <= 0 && !flag2 && Class44.gstruct33_0.int_4 != num43 && array27 != null;
													if (flag265)
													{
														Class50.smethod_4(gstruct2, Class44.gstruct33_0.int_4);
														flag2 = true;
														flag258 = true;
													}
												}
												else
												{
													Class50.smethod_2(gstruct2, "NguyÖt Ca", null, null, 0);
													flag258 = true;
												}
											}
											else
											{
												Class50.smethod_2(gstruct2, "h÷ng n¬i ®· ®i q|Sa M¹c", null, null, 0);
												flag258 = true;
											}
										}
									}
									bool flag266 = flag258;
									if (flag266)
									{
										Thread.Sleep(150);
										Class60.smethod_11(gstruct2, 15000);
										int n = 0;
										while (n < 5)
										{
											int num115 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
											bool flag267 = num115 == num43;
											if (!flag267)
											{
												Thread.Sleep(100);
												goto IL_86EB;
											}
											num33 = n;
											n = num33 + 1;
											Thread.Sleep(100);
										}
									}
									int num116 = -1;
									bool flag268 = Form1.int_19 > 0;
									if (flag268)
									{
										num116 = Class43.smethod_3(Class44.gstruct33_0.int_4);
									}
									bool flag269 = 0 <= num116;
									if (flag269)
									{
										continue;
									}
									num113 = Class60.smethod_7(num43, Class44.gstruct33_0.int_4, ref gstruct);
									bool flag270 = num113 != 0;
									if (flag270)
									{
										bool flag271 = num113 > 0;
										if (flag271)
										{
											bool flag272 = array27 == null;
											if (flag272)
											{
												bool flag273 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
												if (flag273)
												{
													uint[] uint_15 = Class44.gstruct33_0.uint_4;
													bool flag274 = Class60.smethod_7(num113, Class44.gstruct33_0.int_4, ref gstruct) == 0 && gstruct.uint_0 != null;
													if (flag274)
													{
														uint_15 = new uint[]
														{
															gstruct.uint_0[0, 0],
															gstruct.uint_0[0, 1]
														};
													}
													bool flag275 = !Class35.smethod_140(gstruct2, num113, null, uint_15, false);
													if (flag275)
													{
														Class35.smethod_140(gstruct2, 1, "t©m", null, false);
													}
													continue;
												}
											}
											else
											{
												bool flag276 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0 && num18 < 5;
												if (flag276)
												{
													num33 = num18;
													num18 = num33 + 1;
													bool flag277 = Class35.smethod_140(gstruct2, num113, null, null, false);
													if (flag277)
													{
														continue;
													}
												}
												Class50.smethod_5(gstruct2, num113);
											}
										}
										bool flag278 = flag243 && Form1.int_119 <= 0;
										if (flag278)
										{
											Class35.smethod_143(gstruct2, Class44.gstruct33_0.int_4);
										}
										continue;
									}
								}
								else
								{
									bool flag279 = Form1.int_11 > 0;
									if (flag279)
									{
										gstruct = Class43.smethod_4(num43, Class44.gstruct33_0.int_4);
										bool flag280 = gstruct.int_0 == num43 && gstruct.int_1 == Class44.gstruct33_0.int_4;
										if (flag280)
										{
											goto IL_177C;
										}
									}
									bool flag281 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
									if (flag281)
									{
										num33 = num18;
										num18 = num33 + 1;
										bool flag282 = num18 >= 5;
										if (flag282)
										{
											bool flag283 = num18 == 15 && 0 <= Class86.smethod_0(gstruct2);
											if (flag283)
											{
												Class86.smethod_8(gstruct2, -1);
											}
											else
											{
												bool flag284 = num18 > 200;
												if (flag284)
												{
													num18 = 0;
												}
											}
										}
										else
										{
											Class14.smethod_2(gstruct2, false);
											bool flag285 = Class35.smethod_140(gstruct2, Class44.gstruct33_0.int_4, null, Class44.gstruct33_0.uint_4, false);
											if (flag285)
											{
												Thread.Sleep(180);
												continue;
											}
										}
									}
									gstruct = Class43.smethod_4(num43, Class44.gstruct33_0.int_4);
									bool flag286 = gstruct.int_0 != num43 || gstruct.int_1 != Class44.gstruct33_0.int_4;
									if (flag286)
									{
										int num113 = Class60.smethod_7(num43, Class44.gstruct33_0.int_4, ref gstruct);
										bool flag287 = num113 != 0;
										if (flag287)
										{
											flag4 = false;
											bool flag288 = num113 <= 0;
											if (flag288)
											{
												flag96 = true;
												flag74 = false;
												num33 = num11;
												num11 = num33 + 1;
												bool flag289 = num11 > 2;
												if (flag289)
												{
													num18 = 0;
													bool flag290 = num11 > 3;
													if (flag290)
													{
														Class60.smethod_10(gstruct2, "Ch­a ®Þnh nghÜa ®­êng ®i, ®ang thö T§P ®Ó dß ®­êng !");
														bool flag291 = !Class60.smethod_14(gstruct2, true) && Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
														if (flag291)
														{
															Class35.smethod_140(gstruct2, 1, "t©m", null, false);
														}
														num11 = 0;
													}
													continue;
												}
											}
											else
											{
												flag = false;
												bool flag292 = Class12.smethod_28(long_4) > 3000L;
												if (flag292)
												{
													flag = true;
													long_4 = Class12.smethod_27();
													bool flag293 = Class60.smethod_14(gstruct2, true);
													if (flag293)
													{
														continue;
													}
												}
												bool flag294 = num43 == 336;
												if (flag294)
												{
													long num117 = Class60.smethod_21(Class41.uint_0, array5);
													long num118 = Class60.smethod_21(Class41.uint_1, array5);
													bool flag295 = num117 > num118;
													if (flag295)
													{
														gstruct = Class43.smethod_4(num43, 121);
														goto IL_177C;
													}
												}
												flag96 = true;
												flag74 = false;
											}
											goto IL_254C;
										}
									}
								}
								IL_6A46:;
							}
						}
					}
					goto IL_177C;
				}
				goto IL_6A5C;
				Block_443:
				int num119 = gstruct2.int_125[2];
				uint[] array28 = new uint[]
				{
					(uint)gstruct2.int_125[3],
					(uint)gstruct2.int_125[4]
				};
				bool flag296 = flag90;
				if (flag296)
				{
					num119 = Class44.gstruct33_1.int_11[1];
					array28[0] = (uint)Class44.gstruct33_1.int_11[2];
					array28[1] = (uint)Class44.gstruct33_1.int_11[3];
				}
				bool flag297 = num43 != num119;
				if (flag297)
				{
					bool flag298 = Form1.int_84 > 0 || Class70.smethod_3(gstruct2, Class70.uint_19, 4) == 0;
					if (flag298)
					{
						bool flag299 = flag4;
						if (flag299)
						{
							flag4 = false;
							bool flag300 = Class50.smethod_2(gstruct2, "®iÓm c", array28, null, 0) > 0;
							if (flag300)
							{
								Class60.smethod_11(gstruct2, 15000);
							}
							continue;
						}
						bool flag301 = !flag2;
						if (flag301)
						{
							flag2 = true;
							Class50.smethod_4(gstruct2, num119);
							continue;
						}
					}
					bool flag302 = num44 == 0 && Class56.smethod_0(num43) != null;
					if (flag302)
					{
						Class56.smethod_6(gstruct2);
						Class86.smethod_8(gstruct2, -1);
						continue;
					}
					bool flag303 = Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
					if (flag303)
					{
						int num120 = num119;
						int num121 = Class35.smethod_137(num120);
						bool flag304 = num121 < 0 && num119 == 76;
						if (flag304)
						{
							num120 = 75;
							num121 = Class35.smethod_137(75);
						}
						bool flag305 = 0 <= num121 && Class35.smethod_140(gstruct2, num120, null, null, false);
						if (flag305)
						{
							Thread.Sleep(300);
							Class60.smethod_11(gstruct2, 15000);
							Thread.Sleep(600);
							int num122 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
							bool flag306 = num122 != num43;
							if (flag306)
							{
								continue;
							}
						}
						else
						{
							bool flag307 = num43 != 103 && num43 != 114 && num43 != 110 && (num119 == 110 || num119 == 114) && Class35.smethod_140(gstruct2, 103, null, null, false);
							if (flag307)
							{
								Thread.Sleep(300);
								Class60.smethod_11(gstruct2, 15000);
								Thread.Sleep(600);
								int num123 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
								bool flag308 = num123 != num43;
								if (flag308)
								{
									continue;
								}
							}
						}
						int num124 = Class60.smethod_7(num43, num119, ref gstruct);
						bool flag309 = num124 == 0;
						if (flag309)
						{
							goto IL_177C;
						}
						bool flag310 = flag2 && num124 > 0 && num19 < 5;
						if (flag310)
						{
							uint[] uint_16 = array28;
							bool flag311 = Class60.smethod_7(num124, num119, ref gstruct) == 0 && gstruct.uint_0 != null;
							if (flag311)
							{
								uint_16 = new uint[]
								{
									gstruct.uint_0[0, 0],
									gstruct.uint_0[0, 1]
								};
							}
							num33 = num19;
							num19 = num33 + 1;
							Class14.smethod_2(gstruct2, false);
							Class35.smethod_140(gstruct2, num124, null, uint_16, false);
							continue;
						}
					}
					bool flag312 = num20 < 3;
					if (flag312)
					{
						int[] array29 = Class60.smethod_9(num43);
						bool flag313 = array29 != null && Class50.smethod_4(gstruct2, num119) > 0;
						if (flag313)
						{
							num33 = num20;
							num20 = num33 + 1;
							continue;
						}
					}
					int num125 = Class60.smethod_7(num43, num119, ref gstruct);
					bool flag314 = num125 != 0;
					if (flag314)
					{
						bool flag315 = flag2 && num125 > 0 && num19 < 5;
						if (flag315)
						{
							uint[] uint_17 = array28;
							bool flag316 = Class60.smethod_7(num125, num119, ref gstruct) == 0 && gstruct.uint_0 != null;
							if (flag316)
							{
								uint_17 = new uint[]
								{
									gstruct.uint_0[0, 0],
									gstruct.uint_0[0, 1]
								};
							}
							num33 = num19;
							num19 = num33 + 1;
							Class14.smethod_2(gstruct2, false);
							Class35.smethod_140(gstruct2, num125, null, uint_17, false);
						}
						else
						{
							bool flag317 = Class12.smethod_28(long_3) > 15000L;
							if (flag317)
							{
								Class70.smethod_52(gstruct2, "<color=yellow>Khong the den toa do dinh san...", 1);
								long_3 = Class12.smethod_27();
							}
						}
						continue;
					}
					goto IL_177C;
				}
				else
				{
					flag4 = true;
					num20 = 0;
					num19 = 0;
					for (int num126 = 0; num126 < Class53.int_0; num126 = num33 + 1)
					{
						Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num25);
						bool flag318 = array3[0] == 0;
						if (flag318)
						{
							break;
						}
						Thread.Sleep(1);
						num33 = num126;
					}
					long num127 = Class60.smethod_18(array5, array28);
					bool flag319 = num127 >= 48400L;
					if (flag319)
					{
						bool flag320 = num23 > 0;
						if (flag320)
						{
							Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
						}
						num23 = 0;
						bool flag321 = num127 < 900000L && num9 < 5;
						if (flag321)
						{
							Class14.smethod_2(gstruct2, false);
							Class70.smethod_61(gstruct2, array28);
							Thread.Sleep(150);
							num33 = num9;
							num9 = num33 + 1;
							continue;
						}
						Class60.smethod_29(gstruct2, false);
						bool flag322 = Class12.smethod_28(long_3) > 4000L;
						if (flag322)
						{
							Class14.smethod_1(gstruct2, array28);
							long_3 = Class12.smethod_27();
						}
						continue;
					}
					else
					{
						num9 = 0;
						flag11 = true;
					}
				}
				IL_1A42:
				num44 = (int)Class22.smethod_30(num39 + Class53.gstruct51_43.uint_0, gstruct2.int_137);
				bool flag323 = num44 <= 0;
				if (flag323)
				{
					continue;
				}
				flag3 = false;
				flag2 = false;
				flag48 = (!gstruct2.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0));
				bool flag324 = gstruct2.int_101[0] > 0 && gstruct2.int_101[1] > 0 && gstruct2.string_23 == "NGAMY";
				if (flag324)
				{
					long num128 = Class12.smethod_28(long_2);
					bool flag325 = num128 < 300L;
					if (flag325)
					{
						continue;
					}
					bool flag326 = num128 > (long)gstruct2.int_101[4] && Class7.smethod_3(gstruct2);
					if (flag326)
					{
						Thread.Sleep(80);
						long_2 = Class12.smethod_27();
						continue;
					}
				}
				for (int num126 = 0; num126 < Class53.int_0; num126 = num33 + 1)
				{
					Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num25);
					bool flag327 = array3[0] == 0;
					if (flag327)
					{
						break;
					}
					Thread.Sleep(1);
					num33 = num126;
				}
				bool bool_2 = gstruct2.bool_22;
				if (bool_2)
				{
					bool flag328 = gstruct2.int_136 != Class44.gstruct33_0.int_0;
					if (flag328)
					{
						Class60.smethod_29(gstruct2, false);
					}
				}
				else
				{
					bool flag92;
					bool flag329 = flag92;
					int num51;
					int num54;
					uint num69;
					uint[] uint_3;
					if (!flag329)
					{
						bool flag330 = gstruct2.int_128[0] > 0 && gstruct2.int_128[1] > 0 && gstruct2.int_128[2] > 0;
						bool flag331 = gstruct2.int_128[0] > 0 && gstruct2.int_128[3] > 0 && gstruct2.int_128[4] > 0;
						bool flag332 = gstruct2.int_128[0] > 0 && gstruct2.int_128[5] > 0 && gstruct2.int_128[6] > 0;
						flag47 = ((flag330 || flag331 || flag332) && gstruct2.string_23 == "DUONGMON");
						bool flag333 = FormDame.int_6 <= 0 || gstruct2.int_126 != 0 || flag47;
						if (!flag333)
						{
							bool flag334 = flag48 || FormDame.int_10 > 0;
							if (flag334)
							{
								int num129 = 0;
								bool flag335 = FormDame.int_9 == 0;
								if (!flag335)
								{
									bool flag336 = Class44.gstruct33_0.int_8 == 1 || (flag75 && Class44.gstruct33_1.int_8 == 1);
									bool flag337 = FormDame.int_9 == 1;
									if (flag337)
									{
										bool flag338 = flag336;
										if (flag338)
										{
											goto IL_202B;
										}
										bool flag339 = FormDame.int_11 > 0;
										if (!flag339)
										{
											bool flag340 = num23 > 0;
											if (flag340)
											{
												Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
											}
											num23 = 0;
											goto IL_1E2B;
										}
									}
									else
									{
										bool flag341 = FormDame.int_9 != 2 || flag336;
										if (!flag341)
										{
											bool flag342 = num23 > 0;
											if (flag342)
											{
												Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
											}
											num23 = 0;
											goto IL_1E2B;
										}
									}
									goto IL_1E32;
									IL_1E2B:
									goto IL_1E2C;
								}
								IL_202B:
								uint num130 = 0U;
								uint[] array30 = null;
								uint[] array31 = null;
								bool flag343 = flag75;
								if (flag343)
								{
									uint num131 = Class44.gstruct33_1.uint_5 >> 16;
									uint int_4 = Class44.gstruct33_1.uint_5 - (num131 << 16);
									array30 = Class83.smethod_11(Class44.gstruct33_1.uint_4, (int)int_4, (int)num131);
									uint[] array32 = Class83.smethod_10(array5, array30);
									num130 = (array32[1] << 16) + array32[0];
									array31 = Class44.gstruct33_1.uint_4;
									Class83.smethod_7(gstruct2, num130);
									Thread.Sleep(10);
								}
								else
								{
									bool flag344 = gstruct2.int_136 != Class44.gstruct33_0.int_0 && gstruct2.int_136 != Class76.gstruct49_0.int_136 && Class44.gstruct33_0.uint_5 > 0U;
									if (flag344)
									{
										uint num132 = Class44.gstruct33_0.uint_5 >> 16;
										uint int_5 = Class44.gstruct33_0.uint_5 - (num132 << 16);
										array30 = Class83.smethod_11(Class44.gstruct33_0.uint_4, (int)int_5, (int)num132);
										uint[] array33 = Class83.smethod_10(array5, array30);
										num130 = (array33[1] << 16) + array33[0];
										array31 = Class44.gstruct33_0.uint_4;
										Class83.smethod_7(gstruct2, num130);
										Thread.Sleep(10);
									}
								}
								Class60.smethod_30(gstruct2);
								bool flag345 = gstruct2.int_127[0] == 2;
								if (flag345)
								{
									Class60.smethod_0(gstruct2.uint_4, gstruct2.int_129, FormDame.int_12);
								}
								else
								{
									bool flag346 = gstruct2.int_127[0] == 1;
									if (flag346)
									{
										bool flag347 = gstruct2.int_127[1] > 0 && gstruct2.int_127[2] > 0;
										bool flag348 = gstruct2.int_127[3] > 0 && gstruct2.int_127[4] > 0;
										bool flag349 = flag347 && !flag348;
										if (flag349)
										{
											num129 = gstruct2.int_127[2];
										}
										else
										{
											bool flag350 = flag348 && !flag347;
											if (flag350)
											{
												num129 = gstruct2.int_127[4];
											}
											else
											{
												bool flag351 = flag347 && flag348;
												if (flag351)
												{
													num129 = ((0 > num6 || num6 > 25) ? gstruct2.int_127[4] : gstruct2.int_127[2]);
													bool flag352 = num6 > 35;
													if (flag352)
													{
														num6 = 0;
													}
													num33 = num6;
													num6 = num33 + 1;
												}
											}
										}
									}
									bool flag353 = num129 <= 0;
									if (flag353)
									{
										num129 = Class77.smethod_13(gstruct2);
									}
									bool flag354 = gstruct2.int_136 != Class44.gstruct33_0.int_0 || Form1.int_6 > 0 || Form1.int_7 > 0;
									if (flag354)
									{
										Class77.smethod_9(gstruct2, null);
									}
									Class77.smethod_5(gstruct2, num129, 6, 1);
									Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_12 * 4U, array3, 1, ref num25);
									bool flag355 = array3[0] == 0 && FormDame.int_0 <= 0;
									if (flag355)
									{
										FormDame.int_0 = int_0;
										new Thread(new ThreadStart(FormDame.smethod_0)).Start();
									}
									array3[0] = 1;
									Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_12 * 4U + 1U, array3, 1, ref num25);
								}
								bool flag356 = num130 != 0U && gstruct2.int_136 != Class76.gstruct49_0.int_136;
								if (flag356)
								{
									bool flag357 = gstruct2.int_95 <= 0;
									if (flag357)
									{
										Class22.smethod_30(num39 + Class53.gstruct51_31.uint_0, gstruct2.int_137);
										int num133 = Class77.smethod_13(gstruct2);
										bool flag358 = num133 == 53 || num133 <= 1;
										if (flag358)
										{
											goto IL_44CC;
										}
									}
									string string_2 = Class83.smethod_20(gstruct2);
									bool flag359 = Class12.smethod_2(string_2, "iÓm qu¸ x", false);
									if (flag359)
									{
										uint[] array34 = Class60.smethod_5(array31, array30, -1 * (Form1.int_23 - 50));
										long num134 = Class60.smethod_18(array5, array34);
										bool flag360 = num134 > 7000L;
										if (flag360)
										{
											Class70.smethod_61(gstruct2, array34);
											Thread.Sleep(150);
											Class83.smethod_21(gstruct2, "0K..");
										}
									}
								}
							}
							IL_1E2C:
							goto IL_1E2D;
						}
						IL_1E32:
						bool flag361 = flag48;
						if (flag361)
						{
							bool flag362 = !Class44.smethod_7(gstruct2, ref num26) && Class83.smethod_12(gstruct2) != 1;
							if (flag362)
							{
								num43 = (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct2.int_137);
								array5 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								uint_3 = array5;
								bool flag363 = flag74 && Class44.gstruct33_0.int_4 == num43 && Class44.gstruct33_0.int_3 > 0 && Class44.gstruct33_0.uint_4 != null;
								if (flag363)
								{
									uint_3 = Class44.gstruct33_0.uint_4;
									num51 += num54;
								}
								num69 = 0U;
								bool flag364 = Form1.int_33 > 0 && (flag75 || flag74);
								if (flag364)
								{
									bool flag365 = flag75;
									if (flag365)
									{
										uint num40;
										bool flag366 = Class44.gstruct33_1.int_4 == num43 && Class44.gstruct33_1.uint_3 != num40;
										if (flag366)
										{
											num69 = Class44.gstruct33_1.uint_3;
										}
									}
									else
									{
										uint num40;
										bool flag367 = flag74 && Class44.gstruct33_0.int_4 == num43 && Class44.gstruct33_0.uint_3 != num40;
										if (flag367)
										{
											num69 = Class44.gstruct33_0.uint_3;
										}
									}
									bool flag368 = num69 == 0U && Form1.int_34 <= 0;
									if (flag368)
									{
										goto IL_44CC;
									}
								}
								goto IL_2AA4;
							}
							Thread.Sleep(100);
							num23 = 0;
						}
						goto IL_44CC;
					}
					IL_2AA4:
					bool flag369 = gstruct2.int_119 > 0 && gstruct2.int_3 != null;
					if (flag369)
					{
						int[,] array35 = (gstruct2.int_5 > 0) ? Class7.smethod_5(gstruct2, num69, num51, uint_3, Class7.int_0, false, false, false) : Class7.smethod_6(gstruct2, num69, num51, uint_3, null, false, false, false);
						bool flag370 = array35 != null && array35[0, 0] >= 0;
						if (flag370)
						{
							int num135 = -1;
							int int_6 = Class44.gstruct33_0.int_4;
							num23 = 0;
							bool flag371 = false;
							bool flag372 = false;
							for (;;)
							{
								int num136 = 0;
								int num137 = 400;
								while (num136 <= 0)
								{
									num33 = num135;
									num135 = num33 + 1;
									bool flag373 = gstruct2.int_3 != null && gstruct2.int_3.GetLength(0) > num135 && gstruct2.int_4 != null;
									if (!flag373)
									{
										goto IL_2C21;
									}
									num136 = gstruct2.int_3[num135, 0];
									bool flag374 = num136 > 0;
									if (flag374)
									{
										num137 = Class77.smethod_20(gstruct2, num136, gstruct2.int_3[num135, 1]);
										break;
									}
								}
								Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_55.uint_0, array3, 4, ref num25);
								int num41 = BitConverter.ToInt32(array3, 0);
								Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_50.uint_0, array3, 4, ref num25);
								int num42 = BitConverter.ToInt32(array3, 0);
								Class22.ReadProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
								num44 = BitConverter.ToInt32(array3, 0);
								Class22.ReadProcessMemory(gstruct2.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref num25);
								int num138 = BitConverter.ToInt32(array3, 0);
								bool flag375 = num44 > 0 && num43 == num138 && num41 != 11 && num41 != 22 && num42 != 0;
								if (!flag375)
								{
									goto IL_3238;
								}
								for (int num139 = 0; num139 < array35.GetLength(0); num139 = num33 + 1)
								{
									bool flag376 = Class44.smethod_7(gstruct2, ref num26) || Class83.smethod_12(gstruct2) == 1;
									if (flag376)
									{
										goto Block_313;
									}
									int num140 = array35[num139, 0];
									num55 = array35[num139, 1];
									bool flag377 = num55 <= 0;
									if (!flag377)
									{
										uint num38;
										uint num141 = num38 + (uint)(num55 * (int)Class53.gstruct51_15.uint_0);
										Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_50.uint_0, array3, 4, ref num25);
										bool flag378 = BitConverter.ToInt32(array3, 0) <= 0;
										if (!flag378)
										{
											bool flag379 = num140 > 0;
											if (flag379)
											{
												Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
												bool flag380 = BitConverter.ToInt32(array3, 0) <= 0;
												if (flag380)
												{
													goto IL_3200;
												}
											}
											flag371 = true;
											bool flag381 = !flag372 || num140 > 0;
											if (!flag381)
											{
												goto IL_31FE;
											}
											bool flag382 = num140 > 0;
											if (flag382)
											{
												flag372 = true;
											}
											bool flag383 = Class98.smethod_31(gstruct2, num55, num136) != 0;
											if (!flag383)
											{
												int num52 = num137;
												Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num25);
												array10[0] = BitConverter.ToUInt32(array3, 0);
												Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num25);
												array10[1] = BitConverter.ToUInt32(array3, 0);
												array5 = new uint[]
												{
													Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
													Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
												};
												bool flag384 = flag74;
												if (flag384)
												{
													array5 = new uint[]
													{
														Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
														Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
													};
													long num142 = Class60.smethod_18(array5, Class44.gstruct33_0.uint_4);
													bool flag385 = int_6 != Class44.gstruct33_0.int_4 || num142 > (long)(num54 * num54);
													if (flag385)
													{
														goto Block_324;
													}
													int num143 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array10));
													int num144 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array10));
													int num145 = num143 - num54 + 10;
													bool flag386 = num143 > num54 && num52 < num145 && (num144 > num143 || (num144 < num143 && num52 < num144));
													if (flag386)
													{
														num52 = num145;
													}
												}
												bool flag387 = Class60.smethod_18(array5, array10) > (long)(num52 * num52) && gstruct2.int_95 <= 0;
												if (!flag387)
												{
													for (int num126 = 0; num126 < Class53.int_0; num126 = num33 + 1)
													{
														Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num25);
														bool flag388 = array3[0] == 0;
														if (flag388)
														{
															break;
														}
														Thread.Sleep(1);
														num33 = num126;
													}
													Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(num136), 4, ref num25);
													Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num52), 4, ref num25);
													Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num55), 4, ref num25);
													Thread.Sleep(10);
													num23 = 1;
												}
											}
										}
									}
									IL_3200:
									num33 = num139;
								}
							}
							IL_3AFF:
							goto IL_3B00;
							IL_3272:
							bool flag389 = num23 <= 0 && gstruct2.int_6 <= 0 && flag371;
							if (flag389)
							{
								long num146 = 0L;
								array5 = new uint[]
								{
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
									Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
								};
								num55 = -1;
								int num147 = 0;
								int length3 = array35.GetLength(1);
								flag372 = false;
								int num52 = gstruct2.int_97;
								bool flag390 = gstruct2.int_95 > 0 && gstruct2.int_96 > 0;
								if (flag390)
								{
									num52 = gstruct2.int_96;
								}
								bool flag391 = num52 <= 0;
								if (flag391)
								{
									num52 = 500;
								}
								Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_44 * 4U, array3, 1, ref num25);
								int num148 = (int)array3[0];
								bool flag392 = num148 > 0 && num52 > gstruct2.int_97 && gstruct2.int_97 > 0;
								if (flag392)
								{
									num52 = gstruct2.int_97;
								}
								uint num38;
								for (int num149 = 0; num149 < array35.GetLength(0); num149 = num33 + 1)
								{
									int num150 = array35[num149, 0];
									int num151 = array35[num149, 1];
									int num152 = array35[num149, 2];
									int num153 = num52;
									int num154 = 0;
									bool flag393 = length3 > 10;
									if (flag393)
									{
										num154 = array35[num149, 10];
									}
									bool flag394 = num151 <= 0;
									if (!flag394)
									{
										uint num141 = num38 + (uint)(num151 * (int)Class53.gstruct51_15.uint_0);
										Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_50.uint_0, array3, 4, ref num25);
										bool flag395 = BitConverter.ToInt32(array3, 0) <= 0;
										if (!flag395)
										{
											bool flag396 = num150 > 0;
											if (flag396)
											{
												Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
												bool flag397 = BitConverter.ToInt32(array3, 0) <= 0;
												if (flag397)
												{
													goto IL_3765;
												}
											}
											bool flag398 = flag372 && num150 <= 0 && num55 > 0;
											if (flag398)
											{
												break;
											}
											Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num25);
											array10[0] = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num25);
											array10[1] = BitConverter.ToUInt32(array3, 0);
											long num155 = Class60.smethod_18(array5, array10);
											bool flag399 = num55 > 0 && num146 < num155;
											if (!flag399)
											{
												bool flag400 = flag74;
												if (flag400)
												{
													int num156 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array10));
													int num157 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array10));
													int num158 = num156 - num54 + 10;
													bool flag401 = num156 > num54 && num153 < num158 && (num157 > num156 || (num157 < num156 && num153 < num157));
													if (flag401)
													{
														num153 = num158;
													}
												}
												bool flag402 = num155 <= (long)(num153 * num153) || gstruct2.int_95 > 0;
												if (flag402)
												{
													bool flag403 = num150 > 0;
													if (flag403)
													{
														flag372 = true;
													}
													num55 = num151;
													num147 = num154;
													num146 = num155;
													num52 = num153;
												}
											}
										}
									}
									IL_3765:
									num33 = num149;
								}
								bool flag404 = num55 <= 0;
								if (!flag404)
								{
									bool flag405 = flag46 && Form1.int_116 > 0;
									if (flag405)
									{
										bool flag406 = num147 <= 0;
										if (flag406)
										{
											uint num141 = num38 + (uint)(num55 * (int)Class53.gstruct51_15.uint_0);
											Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num25);
											array10[0] = BitConverter.ToUInt32(array3, 0);
											Class22.ReadProcessMemory(gstruct2.int_137, num141 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num25);
											array10[1] = BitConverter.ToUInt32(array3, 0);
											bool flag407 = Class7.smethod_4(gstruct2.int_137, num43, array10) == 0;
											if (flag407)
											{
												uint num159 = num38 + (uint)(num55 * (int)Class53.gstruct51_15.uint_0) + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0;
												uint num161;
												for (uint num160 = 0U; num160 < 6U; num160 = num161 + 1U)
												{
													Class22.ReadProcessMemory(gstruct2.int_137, num159 + Class53.gstruct51_3.uint_0 * num160, array3, 4, ref num25);
													bool flag408 = BitConverter.ToInt32(array3, 0) == 45;
													if (flag408)
													{
														num147 = 1;
														break;
													}
													num161 = num160;
												}
											}
											else
											{
												num147 = 1;
											}
										}
										bool flag409 = num147 > 0;
										if (flag409)
										{
											num55 = 0;
											num23 = 0;
											flag47 = false;
											goto IL_3AFF;
										}
									}
									Class60.smethod_30(gstruct2);
									for (int num126 = 0; num126 < Class53.int_0; num126 = num33 + 1)
									{
										Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num25);
										bool flag410 = array3[0] == 0;
										if (flag410)
										{
											break;
										}
										Thread.Sleep(1);
										num33 = num126;
									}
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct2)), 4, ref num25);
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num52), 4, ref num25);
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num55), 4, ref num25);
								}
							}
							else
							{
								bool flag411 = flag371 && num23 <= 0 && gstruct2.int_6 > 0;
								if (flag411)
								{
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
								}
							}
							goto IL_3AFF;
							IL_31FE:
							IL_2C21:
							goto IL_3272;
							IL_3238:
							bool flag412 = num23 > 0;
							if (flag412)
							{
								Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
							}
							num23 = 0;
							goto IL_3AFF;
							Block_324:
							Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
							goto IL_3AFF;
							Block_313:
							Thread.Sleep(100);
							num23 = 0;
						}
						IL_3B00:;
					}
					else
					{
						bool flag413;
						flag48 = (flag413 = (!gstruct2.bool_22 && (Form1.int_31 > 0 || Form1.int_30 > 0)));
						if (flag413)
						{
							int[,] array35 = Class7.smethod_5(gstruct2, num69, num51, uint_3, Class7.int_0, false, false, false);
							bool flag414 = array35 != null;
							if (flag414)
							{
								bool flag415 = array35[0, 0] == -100;
								if (flag415)
								{
									continue;
								}
								int num162 = 0;
								int num52;
								int num164;
								for (;;)
								{
									bool flag416 = array35[num162, 1] > 0;
									if (!flag416)
									{
										goto IL_3DA6;
									}
									array10 = new uint[]
									{
										(uint)array35[num162, 4],
										(uint)array35[num162, 5]
									};
									bool flag417 = flag74;
									if (flag417)
									{
										int num163 = (int)Math.Sqrt((double)Class60.smethod_18(array5, array10));
										num164 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array10));
										bool flag418 = num163 - num52 > 0;
										if (!flag418)
										{
											goto IL_3D3C;
										}
										bool flag419 = num164 > num163;
										if (flag419)
										{
											int num165 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
											bool flag420 = num165 + (num163 - num52) <= num54 + 10;
											if (flag420)
											{
												goto Block_382;
											}
										}
										bool flag421 = gstruct2.int_88 == 1 && num162 == 0;
										if (!flag421)
										{
											goto IL_3CE2;
										}
										num162 = 1;
									}
									else
									{
										bool flag422 = Class60.smethod_18(array5, array10) > (long)(num52 * num52) && gstruct2.int_95 <= 0;
										if (!flag422)
										{
											goto IL_3DA4;
										}
										bool flag423 = gstruct2.int_88 != 1 || num162 != 0;
										if (flag423)
										{
											break;
										}
										num162 = 1;
									}
								}
								IL_44BC:
								goto IL_44C2;
								IL_3DE0:
								int num166 = array35[num162, 0];
								num55 = array35[num162, 1];
								int num167 = array35[num162, 2];
								bool flag424 = Form1.int_50 > 0 && (num166 <= 0 || num166 == array2[0]) && array2[1] > 0 && array2[2] == num43 && array2[3] > 0;
								uint num38;
								if (flag424)
								{
									int num168 = array2[0];
									int num169 = array2[1];
									int num170 = array2[4];
									uint num171 = num38 + (uint)(num169 * (int)Class53.gstruct51_15.uint_0);
									Class22.ReadProcessMemory(gstruct2.int_137, num171 + Class53.gstruct51_50.uint_0, array3, 4, ref num25);
									bool flag425 = BitConverter.ToInt32(array3, 0) > 0;
									if (flag425)
									{
										Class22.ReadProcessMemory(gstruct2.int_137, num171 + Class53.gstruct51_45.uint_0, array3, 4, ref num25);
										long num172 = (long)BitConverter.ToInt32(array3, 0);
										bool flag426 = num172 != 0L;
										if (flag426)
										{
											Class22.ReadProcessMemory(gstruct2.int_137, num171 + Class53.gstruct51_43.uint_0, array3, 4, ref num25);
											bool flag427 = num168 <= 0 || BitConverter.ToInt32(array3, 0) > 0;
											if (flag427)
											{
												array10 = new uint[]
												{
													Class22.smethod_30(num171 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
													Class22.smethod_30(num171 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
												};
												long num173 = Class60.smethod_18(array5, array10);
												bool flag428 = flag74;
												if (flag428)
												{
													int num174 = (int)Math.Sqrt((double)num173);
													int num175 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array10));
													bool flag429 = num174 - num52 <= 0;
													if (flag429)
													{
														num166 = num168;
														num55 = num169;
														num167 = num170;
													}
													else
													{
														bool flag430 = num175 > num174;
														if (flag430)
														{
															int num176 = (int)Math.Sqrt((double)Class60.smethod_18(Class44.gstruct33_0.uint_4, array5));
															bool flag431 = num176 + (num174 - num52) <= num54 + 10;
															if (flag431)
															{
																num166 = num168;
																num55 = num169;
																num167 = num170;
															}
														}
													}
												}
												else
												{
													bool flag432 = num173 <= (long)(num52 * num52);
													if (flag432)
													{
														num166 = num168;
														num55 = num169;
														num167 = num170;
													}
												}
											}
										}
									}
								}
								bool flag433 = flag46 && Form1.int_116 > 0;
								if (flag433)
								{
									int num177 = 0;
									uint[] array36 = new uint[2];
									uint num178 = num38 + (uint)(num55 * (int)Class53.gstruct51_15.uint_0);
									Class22.ReadProcessMemory(gstruct2.int_137, num178 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array3, 4, ref num25);
									array36[0] = BitConverter.ToUInt32(array3, 0);
									Class22.ReadProcessMemory(gstruct2.int_137, num178 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array3, 4, ref num25);
									array36[1] = BitConverter.ToUInt32(array3, 0);
									bool flag434 = Class7.smethod_4(gstruct2.int_137, num43, array36) == 0;
									if (flag434)
									{
										uint num179 = num38 + (uint)(num55 * (int)Class53.gstruct51_15.uint_0) + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0;
										uint num161;
										for (uint num180 = 0U; num180 < 6U; num180 = num161 + 1U)
										{
											Class22.ReadProcessMemory(gstruct2.int_137, num179 + Class53.gstruct51_3.uint_0 * num180, array3, 4, ref num25);
											bool flag435 = BitConverter.ToInt32(array3, 0) == 45;
											if (flag435)
											{
												num177 = 1;
												break;
											}
											num161 = num180;
										}
									}
									else
									{
										num177 = 1;
									}
									bool flag436 = num177 > 0;
									if (flag436)
									{
										num55 = 0;
										num167 = 0;
										num23 = 0;
									}
								}
								array2[0] = num166;
								array2[1] = num55;
								array2[2] = num43;
								array2[3] = 0;
								array2[4] = num167;
								bool flag437 = num55 <= 0;
								if (flag437)
								{
									goto IL_44BC;
								}
								array2[3] = 1;
								num23 = 1;
								num24 = 1;
								Class60.smethod_30(gstruct2);
								for (int num126 = 0; num126 < Class53.int_0; num126 = num33 + 1)
								{
									Class22.ReadProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_6 * 4U, array3, 1, ref num25);
									bool flag438 = array3[0] == 0;
									if (flag438)
									{
										break;
									}
									Thread.Sleep(1);
									num33 = num126;
								}
								bool flag439 = gstruct2.gstruct48_0.int_0 == 0 || Class7.smethod_10(gstruct2, (uint)num55) <= 0;
								if (flag439)
								{
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_161.uint_0 - 8U, BitConverter.GetBytes(Class77.smethod_13(gstruct2)), 4, ref num25);
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_31.uint_0, BitConverter.GetBytes(num52), 4, ref num25);
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num55), 4, ref num25);
								}
								flag15 = (gstruct2.gstruct48_0.int_0 > 0 && gstruct2.gstruct48_0.int_1 > 0 && gstruct2.gstruct48_0.int_8 > 0 && gstruct2.gstruct48_0.int_9 > 0);
								goto IL_44BC;
								IL_3DA4:
								goto IL_3DE0;
								IL_3D3C:
								goto IL_3DA4;
								IL_3CE2:
								bool flag440 = num54 + num52 <= num164;
								if (flag440)
								{
									bool flag441 = num23 > 0;
									if (flag441)
									{
										Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
									}
									num23 = 0;
									goto IL_44BC;
								}
								Block_382:
								goto IL_3DE0;
								IL_3DA6:
								bool flag442 = num23 > 0;
								if (flag442)
								{
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
								}
								num23 = 0;
							}
							else
							{
								flag48 = false;
							}
							IL_44C2:;
						}
						else
						{
							flag48 = false;
						}
					}
				}
				IL_1E2D:
				goto IL_44CC;
				IL_254C:
				flag47 = false;
				flag75 = ((Form1.int_6 > 0 || Form1.int_7 > 0) && Form1.int_21 > 0 && (Class44.gstruct33_1.int_3 > 0 || Form1.int_22 > 0) && Class44.gstruct33_1.int_4 > 0 && Class12.smethod_62(Class44.gstruct33_1.uint_4) && (gstruct2.int_136 == Class44.gstruct33_0.int_0 || Class44.gstruct33_0.int_0 <= 0));
				array5 = new uint[]
				{
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
				};
				bool flag443 = flag96;
				if (flag443)
				{
					long num181 = 0L;
					bool flag444 = num14 <= 0L || Class12.smethod_28(num14) >= 800L;
					if (flag444)
					{
						uint[] array37 = Class60.smethod_26(gstruct2, ref num13);
						bool flag445 = array37 == null;
						if (flag445)
						{
							num14 = Class12.smethod_27();
						}
						else
						{
							num14 = 0L;
							num181 = Class60.smethod_18(array5, array37);
							bool flag446 = num181 < 8000L;
							if (flag446)
							{
								num181 = 4L;
							}
							else
							{
								bool flag447 = num181 >= 15000L && num181 >= (long)(gstruct2.int_68[1] * gstruct2.int_68[1]);
								if (flag447)
								{
									bool flag448 = num181 < 360000L;
									if (flag448)
									{
										bool flag449 = num23 > 0;
										if (flag449)
										{
											Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
										}
										num23 = 0;
										Class14.smethod_2(gstruct2, false);
										Class70.smethod_61(gstruct2, array37);
										Thread.Sleep(200);
									}
									bool flag450 = num181 < 1200000L;
									if (flag450)
									{
										bool flag451 = Class12.smethod_28(long_3) > 3000L;
										if (flag451)
										{
											Class14.smethod_1(gstruct2, array37);
											long_3 = Class12.smethod_27();
										}
										continue;
									}
								}
								else
								{
									int num41 = (int)Class22.smethod_30(num39 + Class53.gstruct51_55.uint_0, gstruct2.int_137);
									bool flag452 = num41 < 3 && num181 > 7500L;
									if (flag452)
									{
										bool flag453 = num23 > 0;
										if (flag453)
										{
											Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
										}
										num23 = 0;
										Class70.smethod_61(gstruct2, array37);
										Thread.Sleep(200);
										goto IL_44CC;
									}
									num181 = 4L;
								}
							}
						}
					}
					bool flag454 = flag75;
					if (flag454)
					{
						bool flag455 = num181 != 4L;
						if (flag455)
						{
							num181 = (long)FormMayphu.smethod_11(gstruct2, ref flag4, ref long_3, ref num8, ref array);
						}
						int num41 = (int)Class22.smethod_30(num39 + Class53.gstruct51_55.uint_0, gstruct2.int_137);
						bool flag456 = num181 == 4L && num41 < 3;
						if (flag456)
						{
							array5 = new uint[]
							{
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
								Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
							};
							bool flag457 = Class60.smethod_18(array5, Class44.gstruct33_1.uint_4) > 5625L;
							if (flag457)
							{
								bool flag458 = num23 > 0;
								if (flag458)
								{
									Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
								}
								num23 = 0;
								Class70.smethod_61(gstruct2, Class44.gstruct33_1.uint_4);
								Thread.Sleep(200);
							}
						}
						Class22.smethod_30(num39 + Class53.gstruct51_56.uint_0, gstruct2.int_137);
						bool flag459 = num181 <= 0L;
						if (flag459)
						{
							continue;
						}
						bool flag460 = num181 == 2L;
						if (flag460)
						{
							num33 = num8;
							num8 = num33 + 1;
							bool flag461 = num8 < 3;
							if (flag461)
							{
								continue;
							}
						}
						bool flag462 = num44 > 0 && num181 == 4L && Form1.int_102 > 0 && gstruct2.int_93 == 1;
						if (flag462)
						{
							Class60.smethod_30(gstruct2);
						}
					}
					array = null;
					num8 = 0;
				}
				goto IL_1A42;
				IL_6A5C:
				goto IL_254C;
				IL_6A51:
				flag96 = true;
				num27 = 0;
				num28 = 0;
				goto IL_6A5C;
				IL_4572:
				num8 = 0;
				array = null;
				array6 = Class44.gstruct33_0.uint_4;
				bool_ = true;
				goto IL_254C;
				Block_677:
				flag96 = true;
				flag74 = false;
				IL_5890:
				goto IL_4572;
				IL_588F:
				goto IL_5890;
				IL_57C8:
				num15 = 0L;
				bool flag463 = num23 == 0 && Class60.smethod_18(array13, Class44.gstruct33_0.uint_4) > (long)(Form1.int_23 * Form1.int_23);
				if (flag463)
				{
					num33 = num12;
					num12 = num33 + 1;
					bool flag464 = num12 > 3;
					if (flag464)
					{
						Class70.smethod_61(gstruct2, Class44.gstruct33_0.uint_4);
						Thread.Sleep(150);
						num12 = 0;
					}
				}
				bool flag465 = Form1.int_27 > 0 && num44 > 0 && gstruct2.int_131[0] > 0 && Class70.smethod_3(gstruct2, Class70.uint_31, 4) == 0;
				if (flag465)
				{
					Class70.smethod_2(gstruct2, Class70.uint_31, 1, 4);
				}
				goto IL_588F;
				Block_426:
				continue;
				Block_489:
				int[] array38 = Class60.smethod_9(num43);
				bool flag466 = array38 != null && array38[1] == 0;
				if (flag466)
				{
					Class18.smethod_1(gstruct2, false, false);
					continue;
				}
				bool flag467 = num18 < 5 && Class70.smethod_3(gstruct2, Class70.uint_19, 4) > 0;
				if (flag467)
				{
					num33 = num18;
					num18 = num33 + 1;
					Class14.smethod_2(gstruct2, false);
					bool flag468 = Class35.smethod_140(gstruct2, 176, "b¾c", null, false);
					if (flag468)
					{
						array3[0] = 1;
						Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
						continue;
					}
				}
				bool flag469 = num44 <= 0;
				if (flag469)
				{
					bool flag470 = Class50.smethod_5(gstruct2, 176) > 0;
					if (flag470)
					{
						array3[0] = 1;
						Class22.WriteProcessMemory(gstruct2.int_137, gstruct2.uint_15 + Class70.uint_33 * 4U, array3, 1, ref num25);
					}
				}
				else
				{
					Class60.smethod_14(gstruct2, true);
				}
				continue;
				Block_518:
				uint[] array39 = array12;
				bool flag471 = flag102;
				if (flag471)
				{
					uint[] array11;
					array39 = array11;
				}
				long num182 = Class60.smethod_18(array5, array39);
				bool flag472 = num182 > 360000L;
				if (flag472)
				{
					bool flag473 = Class12.smethod_28(long_3) > 3000L;
					if (flag473)
					{
						Class14.smethod_1(gstruct2, array39);
						long_3 = Class12.smethod_27();
					}
					continue;
				}
				for (int num183 = 0; num183 < 10; num183 = num33 + 1)
				{
					array5 = new uint[]
					{
						Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
						Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
					};
					num182 = Class60.smethod_18(array5, array39);
					bool flag474 = num182 < 22500L;
					if (flag474)
					{
						break;
					}
					Class70.smethod_61(gstruct2, array39);
					Thread.Sleep(300);
					num33 = num183;
				}
				Class50.smethod_2(gstruct2, "m b¸o danh|hi danh|(T)|(K)", null, null, 0);
				continue;
				Block_686:
				int num184 = Class39.smethod_1(gstruct2);
				bool flag475 = num184 <= 0 && (!Class14.smethod_3(gstruct2) || Class12.smethod_28(long_3) > 4000L);
				if (flag475)
				{
					Class14.smethod_1(gstruct2, Class44.gstruct33_0.uint_4);
					long_3 = Class12.smethod_27();
					num33 = num8;
					num8 = num33 + 1;
					num9 = 0;
				}
				continue;
				Block_695:
				Thread.Sleep(300);
				continue;
				Block_702:
				Thread.Sleep(300);
				continue;
				Block_703:
				Thread.Sleep(300);
				continue;
				Block_711:
				Class60.smethod_11(gstruct2, 15000);
				Thread.Sleep(200);
				continue;
				Block_714:
				Class56.smethod_6(gstruct2);
				Class86.smethod_8(gstruct2, -1);
				continue;
				IL_7ED4:
				bool flag476 = gstruct2.bool_58 && gstruct2.int_83 > 0;
				if (flag476)
				{
					bool flag477 = Form1.int_99 == 0;
					if (flag477)
					{
						bool flag478 = num55 > 0 && Class12.smethod_28(long_) > gstruct2.long_8;
						if (flag478)
						{
							Class36.smethod_54(gstruct2, array10, false, 10);
							Class36.smethod_55(gstruct2);
							long_ = Class12.smethod_27();
						}
					}
					else
					{
						bool flag479 = Class44.gstruct33_0.int_7 == Class27.gstruct40_0[Form1.int_100].int_0;
						if (flag479)
						{
							Class36.smethod_54(gstruct2, null, true, 10);
							bool flag480 = Class12.smethod_28(long_) > gstruct2.long_8;
							if (flag480)
							{
								Class36.smethod_55(gstruct2);
								long_ = Class12.smethod_27();
							}
						}
					}
				}
				bool flag481 = !flag46 || flag74 || gstruct2.int_122 <= 0;
				if (flag481)
				{
					continue;
				}
				bool flag482 = num55 > 0;
				if (flag482)
				{
					num31 = 0;
					num32 = 0;
					num29 = -1;
					continue;
				}
				num33 = num31;
				num31 = num33 + 1;
				bool flag483 = num31 < 10;
				if (flag483)
				{
					continue;
				}
				array5 = new uint[]
				{
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct2.int_137),
					Class22.smethod_30(num39 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct2.int_137)
				};
				bool flag484 = num29 >= 0;
				if (flag484)
				{
					bool flag485 = Class54.uint_0.GetLength(0) <= num29;
					if (flag485)
					{
						num29 = 0;
						num32 = 0;
					}
				}
				else
				{
					num29 = Class60.smethod_20(Class54.uint_0, array5);
					num32 = 0;
				}
				uint[] array40 = new uint[]
				{
					Class54.uint_0[num29, 0],
					Class54.uint_0[num29, 1]
				};
				long num185 = Class60.smethod_18(array5, array40);
				bool flag486 = num185 < 11500L;
				if (flag486)
				{
					num33 = num29;
					num29 = num33 + 1;
					num32 = 0;
					bool flag487 = Class54.uint_0.GetLength(0) <= num29;
					if (flag487)
					{
						num29 = 0;
					}
					array40 = new uint[]
					{
						Class54.uint_0[num29, 0],
						Class54.uint_0[num29, 1]
					};
				}
				num33 = num32;
				num32 = num33 + 1;
				Class70.smethod_61(gstruct2, array40);
				Thread.Sleep(200);
				bool flag488 = num32 > 15;
				if (flag488)
				{
					num29 = -1;
					num32 = 0;
				}
				continue;
				Block_528:
				goto IL_7ED4;
				IL_44CC:
				bool flag489 = !flag48 && gstruct2.int_136 != Class44.gstruct33_0.int_0 && Class36.smethod_58(gstruct2, new int[]
				{
					0,
					1
				}) > 0U;
				if (flag489)
				{
					bool flag490 = num23 > 0;
					if (flag490)
					{
						Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
					}
					num23 = 0;
				}
				bool flag491 = flag47 && num55 <= 0;
				if (flag491)
				{
					FormDuongMon.smethod_0(gstruct2, ref num21, array6, ref num22, bool_);
				}
				goto IL_7ED4;
				Block_707:
				Class14.smethod_2(gstruct2, false);
				Class70.smethod_61(gstruct2, Class44.gstruct33_0.uint_4);
				Thread.Sleep(200);
				goto IL_44CC;
				Block_685:
				num33 = num9;
				num9 = num33 + 1;
				Class14.smethod_2(gstruct2, false);
				Class70.smethod_61(gstruct2, Class44.gstruct33_0.uint_4);
				Thread.Sleep(150);
				goto IL_44CC;
				IL_5762:
				num15 = Class12.smethod_27();
				bool flag492 = num23 > 0;
				if (flag492)
				{
					Class22.WriteProcessMemory(gstruct2.int_137, num39 + Class53.gstruct51_72.uint_0, byte_, 4, ref num25);
				}
				num23 = 0;
				Class44.smethod_6(gstruct2, array5, Class44.gstruct33_0.uint_4, num78 <= 5625L);
				goto IL_44CC;
				IL_81C9:
				bool flag493 = !Class14.smethod_3(gstruct2) || Class12.smethod_28(long_3) > 4000L;
				if (flag493)
				{
					Class14.smethod_1(gstruct2, array16);
					long_3 = Class12.smethod_27();
					num33 = num8;
					num8 = num33 + 1;
					num9 = 0;
				}
				continue;
				IL_7ECF:
				goto IL_81C9;
				IL_7ECD:
				goto IL_7ECF;
				IL_7EC9:
				num27 = 6;
				goto IL_7ECD;
				Block_745:
				bool flag494 = !flag148;
				if (flag494)
				{
					uint[] array21;
					array16[0] = array21[0];
					array16[1] = array21[1];
				}
				else
				{
					uint[] array22;
					array16[0] = array22[0];
					array16[1] = array22[1];
				}
				IL_7830:
				goto IL_7ECF;
				IL_780D:
				array16[0] = array18[0, 0];
				array16[1] = array18[0, 1];
				Block_738:
				IL_758A:
				IL_7589:
				Block_726:
				Block_717:
				goto IL_81C9;
			}
		}

		// Token: 0x040002C7 RID: 711
		private static uint[,] uint_0;
	}
}
