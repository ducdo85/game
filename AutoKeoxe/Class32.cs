using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200001C RID: 28
	internal class Class32
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00019E20 File Offset: 0x00018020
		public static bool smethod_0(int int_4)
		{
			return int_4 == 336 || int_4 == 341 || int_4 == 342 || int_4 == 962 || int_4 == 963 || (337 <= int_4 && int_4 <= 339) || (387 <= int_4 && int_4 <= 395) || (209 <= int_4 && int_4 <= 211) || (849 <= int_4 && int_4 <= 862) || (464 <= int_4 && int_4 <= 471) || (480 <= int_4 && int_4 <= 495) || (926 <= int_4 && int_4 <= 932);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00019EE0 File Offset: 0x000180E0
		public static void smethod_1()
		{
			int int_ = Class32.int_1;
			Class32.int_1 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_33 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_33;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_33 = true;
						flag = true;
					}
					Class32.smethod_2(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00019FC0 File Offset: 0x000181C0
		public static void smethod_2(int int_4)
		{
			int num = 0;
			int num2 = -1;
			GStruct49 gstruct = default(GStruct49);
			long long_ = 0L;
			long long_2 = 0L;
			int num3 = 0;
			int num4 = -1;
			int num5 = 0;
			byte[] array = new byte[4];
			new byte[4];
			new byte[4];
			int[] array2 = new int[10];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = 4;
			}
			for (;;)
			{
				num--;
				Thread.Sleep(300);
				bool flag = num <= 0;
				if (flag)
				{
					num2 = Class81.smethod_3(Form1.gstruct49_0, int_4);
					bool flag2 = Class12.bool_0 || num2 < 0 || !Form1.gstruct49_0[num2].bool_25;
					if (flag2)
					{
						break;
					}
					num = 3;
				}
				gstruct = Form1.gstruct49_0[num2];
				bool flag3 = Form1.int_66 > 0 && gstruct.int_69[0] <= 0 && Class12.smethod_28(long_2) > 30000L;
				if (flag3)
				{
					string str = Form1.string_19;
					bool flag4 = Class70.smethod_3(gstruct, Class70.uint_48, 4) > 0;
					if (flag4)
					{
						str = Form1.string_1 + " click npc ghÐp nép vËt phÈm event - htt p:// kimyen . n e t";
					}
					else
					{
						bool flag5 = Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_10 * 4U, array, 1, ref num5) && num5 > 0 && array[0] > 0;
						if (flag5)
						{
							str = Form1.string_1 + " ®ang läc vËt phÈm theo ®iÒu kiÖn - htt p:// kimyen . n e t";
						}
					}
					Class70.smethod_57(gstruct, "Chat('CH_NEARBY', '" + str + "')");
					long_2 = Class12.smethod_27();
				}
				bool flag6 = gstruct.int_115 <= 0 && gstruct.int_117 <= 0;
				if (!flag6)
				{
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array, 4, ref array2[0]);
					uint num6 = BitConverter.ToUInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num6 + Class53.gstruct51_13.uint_0, array, 4, ref array2[1]);
					uint num7 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array, 4, ref array2[2]);
					uint num8 = BitConverter.ToUInt32(array, 0);
					uint num9 = num8 + num7;
					Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_50.uint_0, array, 4, ref array2[3]);
					int num10 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_55.uint_0, array, 4, ref array2[4]);
					int num11 = BitConverter.ToInt32(array, 0);
					int num12 = Class83.smethod_39(gstruct);
					bool flag7 = num10 != 0 && num12 > 1 && num11 != 0 && num11 != 10 && num11 != 21;
					if (flag7)
					{
						Class22.ReadProcessMemory(gstruct.int_137, num9 + Class53.gstruct51_43.uint_0, array, 4, ref array2[5]);
						BitConverter.ToInt32(array, 0);
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref array2[6]);
						int int_5 = BitConverter.ToInt32(array, 0);
						bool flag8 = Class12.smethod_28(long_) < 1000L;
						if (!flag8)
						{
							int num13 = 6;
							int num14 = 0;
							for (;;)
							{
								bool flag9 = num14 <= num13;
								if (!flag9)
								{
									goto IL_381;
								}
								bool flag10 = array2[num14] == 0;
								if (flag10)
								{
									break;
								}
								num14++;
							}
							continue;
							IL_381:
							int num15 = Class79.smethod_4(gstruct);
							bool flag11 = 0 <= num4 && num4 <= num15;
							if (flag11)
							{
								num4 = num15;
							}
							else
							{
								num4 = num15;
								bool flag12 = false;
								bool flag13 = gstruct.int_115 > 0;
								if (flag13)
								{
									flag12 = (Class32.smethod_5(gstruct, 0, false)[0] <= gstruct.int_116);
								}
								bool flag14 = !flag12 && gstruct.int_117 > 0;
								if (flag14)
								{
									flag12 = (Class32.smethod_5(gstruct, 1, false)[0] <= gstruct.int_118);
								}
								bool flag15 = !flag12;
								if (flag15)
								{
									num3 = 0;
									bool bool_ = gstruct.bool_12;
									if (bool_)
									{
										num2 = Class81.smethod_3(Form1.gstruct49_0, int_4);
										bool flag16 = 0 <= num2;
										if (flag16)
										{
											Form1.gstruct49_0[num2].bool_12 = false;
											gstruct = Form1.gstruct49_0[num2];
										}
									}
								}
								else
								{
									num3++;
									long_ = Class12.smethod_27();
									bool flag17 = !Class32.smethod_0(int_5) && num3 < 4;
									if (flag17)
									{
										Class60.smethod_14(gstruct, true);
										Thread.Sleep(300);
									}
									else
									{
										bool flag18 = !gstruct.bool_12;
										if (flag18)
										{
											num2 = Class81.smethod_3(Form1.gstruct49_0, int_4);
											bool flag19 = 0 <= num2;
											if (flag19)
											{
												Form1.gstruct49_0[num2].bool_12 = true;
												gstruct = Form1.gstruct49_0[num2];
											}
										}
									}
								}
							}
						}
					}
					else
					{
						Thread.Sleep(100);
					}
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001A4CC File Offset: 0x000186CC
		public static void smethod_3()
		{
			int int_ = Class32.int_0;
			Class32.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_35 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_35;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_35 = true;
						flag = true;
					}
					Class32.smethod_4(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001A5AC File Offset: 0x000187AC
		public static void smethod_4(int int_4)
		{
			long long_ = 0L;
			long long_2 = 0L;
			long long_3 = 0L;
			long long_4 = 0L;
			long long_5 = 0L;
			long long_6 = 0L;
			long long_7 = 0L;
			long long_8 = 0L;
			long long_9 = 0L;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			GStruct49 gstruct = default(GStruct49);
			int[] array = new int[]
			{
				7,
				8,
				9,
				10,
				11,
				12,
				54
			};
			long long_10 = 0L;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			bool flag8 = false;
			bool flag9 = false;
			bool flag10 = false;
			bool flag11 = false;
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			int num6 = 0;
			byte[] array2 = new byte[1];
			byte[] array3 = new byte[4];
			byte[] array4 = new byte[9];
			int num7 = 0;
			int[] array5 = new int[10];
			for (int i = 0; i < array5.Length; i++)
			{
				array5[i] = 4;
			}
			for (;;)
			{
				num7--;
				Thread.Sleep(100);
				bool bool_ = Class12.bool_0;
				if (bool_)
				{
					break;
				}
				bool flag12 = num7 <= 0;
				if (flag12)
				{
					num5 = Class81.smethod_3(Form1.gstruct49_0, int_4);
					bool flag13 = num5 < 0 || !Form1.gstruct49_0[num5].bool_25;
					if (flag13)
					{
						break;
					}
					num7 = 10;
				}
				gstruct = Form1.gstruct49_0[num5];
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array3, 4, ref array5[0]);
				uint num8 = BitConverter.ToUInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_13.uint_0, array3, 4, ref array5[1]);
				uint num9 = BitConverter.ToUInt32(array3, 0) * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array3, 4, ref array5[2]);
				uint num10 = BitConverter.ToUInt32(array3, 0);
				uint num11 = num10 + num9;
				Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_50.uint_0, array3, 4, ref array5[3]);
				int num12 = BitConverter.ToInt32(array3, 0);
				Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_55.uint_0, array3, 4, ref array5[4]);
				int num13 = BitConverter.ToInt32(array3, 0);
				int num14 = Class83.smethod_39(gstruct);
				bool flag14 = num12 == 0 || num14 <= 1 || num13 == 0 || num13 == 10 || num13 == 21;
				if (flag14)
				{
					Thread.Sleep(100);
				}
				else
				{
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array3, 4, ref array5[5]);
					int num15 = BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_43.uint_0, array3, 4, ref array5[6]);
					int num16 = BitConverter.ToInt32(array3, 0);
					int num17 = 6;
					int num18 = 0;
					for (;;)
					{
						bool flag15 = num18 <= num17;
						if (!flag15)
						{
							goto IL_301;
						}
						bool flag16 = array5[num18] == 0;
						if (flag16)
						{
							break;
						}
						num18++;
					}
					continue;
					IL_301:
					bool flag17 = num3 != num16;
					if (flag17)
					{
						int num19 = 0;
						while (num16 == 0 && num19 < 30 && num16 != num3)
						{
							Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_43.uint_0, array3, 4, ref num6);
							num16 = BitConverter.ToInt32(array3, 0);
							Thread.Sleep(10);
							num19++;
						}
						bool flag18 = num3 != num16;
						if (flag18)
						{
							flag2 = true;
							flag3 = true;
							flag7 = false;
							flag8 = false;
							num3 = num16;
							continue;
						}
					}
					bool flag20;
					bool flag19 = (flag20 = (num != num15)) && num15 > 0;
					if (flag19)
					{
						flag2 = true;
						flag3 = true;
						flag7 = false;
						flag8 = false;
						flag5 = false;
						flag9 = Class101.smethod_0(num15);
						flag10 = (Class56.smethod_0(num15) != null);
						flag11 = (0 <= Class56.smethod_2(num15));
						flag6 = Class32.smethod_0(num15);
					}
					num = num15;
					int num20 = -1;
					Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_45 * 4U, array4, 9, ref num6);
					for (;;)
					{
						num20++;
						bool flag21 = num20 > 8;
						if (flag21)
						{
							break;
						}
						bool flag22 = array4[num20] == 0;
						if (!flag22)
						{
							bool flag23 = gstruct.bool_25 && (Combo.int_6 != 0 || num16 != 0) && (Combo.int_5 != 0 || gstruct.int_136 == Class76.gstruct49_0.int_136);
							if (flag23)
							{
								int num21 = -1;
								int num22 = 1;
								int num23 = 49 + num20;
								GStruct41[] array6 = null;
								bool flag24 = Class76.gstruct49_0.gstruct42_0 == null;
								if (flag24)
								{
									bool flag25 = gstruct.gstruct42_0 != null;
									if (flag25)
									{
										for (int j = 0; j < gstruct.gstruct42_0.Length; j++)
										{
											bool flag26 = num23 == gstruct.gstruct42_0[j].int_0;
											if (flag26)
											{
												num21 = j;
												break;
											}
										}
										bool flag27 = 0 <= num21;
										if (flag27)
										{
											array6 = gstruct.gstruct42_0[num21].gstruct41_0;
										}
									}
								}
								else
								{
									for (int k = 0; k < Class76.gstruct49_0.gstruct42_0.Length; k++)
									{
										bool flag28 = num23 == Class76.gstruct49_0.gstruct42_0[k].int_0;
										if (flag28)
										{
											num21 = k;
											break;
										}
									}
									bool flag29 = 0 <= num21;
									if (flag29)
									{
										array6 = Class76.gstruct49_0.gstruct42_0[num21].gstruct41_0;
									}
								}
								bool flag30 = 0 <= num21 && array6 != null;
								if (flag30)
								{
									bool flag31 = gstruct.int_136 != Class76.gstruct49_0.int_136;
									if (flag31)
									{
										num22 = Combo.int_4;
									}
									for (int l = 0; l < array6.Length; l++)
									{
										int num24 = array6[l].int_0 / num22;
										int num25 = array6[l].int_0 % num22;
										bool flag32 = num25 > 0;
										if (flag32)
										{
											num25 = 1;
										}
										Class32.smethod_7(gstruct, array6[l].string_0, num24 + num25, -1, -1);
									}
								}
							}
							array2[0] = 0;
							Class22.WriteProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_45 * 4U + (uint)num20, array2, 1, ref num6);
						}
					}
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_45.uint_0, array3, 4, ref array5[0]);
					long num26 = (long)BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_47.uint_0, array3, 4, ref array5[1]);
					long num27 = (long)BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_47.uint_0 + 4U, array3, 4, ref array5[2]);
					long num28 = (long)BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_46.uint_0, array3, 4, ref array5[3]);
					long num29 = (long)BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_48.uint_0, array3, 4, ref array5[4]);
					long num30 = (long)BitConverter.ToInt32(array3, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_48.uint_0 + 4U, array3, 4, ref array5[5]);
					long num31 = (long)BitConverter.ToInt32(array3, 0);
					num17 = 5;
					num18 = 0;
					for (;;)
					{
						bool flag33 = num18 <= num17;
						if (!flag33)
						{
							goto IL_7CE;
						}
						bool flag34 = array5[num18] == 0;
						if (flag34)
						{
							break;
						}
						num18++;
					}
					continue;
					IL_7CE:
					bool flag35 = num28 > num27 && num28 < 5000000L;
					if (flag35)
					{
						num27 = num28;
					}
					bool flag36 = num31 > num30 && num31 < 5000000L;
					if (flag36)
					{
						num30 = num31;
					}
					bool flag37 = num16 == 0 || num27 <= 0L || num30 <= 0L;
					if (flag37)
					{
						bool flag38 = flag && flag20 && num27 < 100L;
						if (flag38)
						{
							Class32.smethod_6(gstruct, 0, 1, false);
						}
						flag = false;
						flag5 = false;
					}
					else
					{
						flag = true;
						double num32 = (double)(num26 * 100L / num27);
						double num33 = (double)(num29 * 100L / num30);
						bool flag39 = !flag6 && !flag5 && !flag9 && ((gstruct.int_113[0] > 0 && gstruct.int_113[1] > 0 && num32 <= (double)gstruct.int_113[1]) || (gstruct.int_114[0] > 0 && gstruct.int_114[1] > 0 && num33 <= (double)gstruct.int_114[1])) && Class12.smethod_28(long_) > 300L;
						if (flag39)
						{
							Class60.smethod_14(gstruct, false);
							num2++;
							bool flag40 = num2 > 3;
							if (flag40)
							{
								string string_ = Class83.smethod_20(gstruct);
								bool flag41 = Class12.smethod_1(string_, "ph¸t huy t¸c dông t¹i") > 0;
								if (flag41)
								{
									flag5 = true;
									Class83.smethod_21(gstruct, "0K..");
								}
								num2 = 0;
							}
							long_ = Class12.smethod_27();
						}
						bool flag42 = false;
						bool flag43 = false;
						bool flag44 = !flag7 && gstruct.int_110[0] > 0 && num32 <= (double)gstruct.int_110[1] && gstruct.string_16 != null && gstruct.string_16 != string.Empty && (long)gstruct.int_110[2] <= Class12.smethod_28(long_7);
						if (flag44)
						{
							flag7 = (Class32.smethod_7(gstruct, gstruct.string_16, gstruct.int_110[3], -1, 1) <= 0);
							long_7 = Class12.smethod_27();
						}
						bool flag45 = !flag8 && gstruct.int_112[0] > 0 && num33 <= (double)gstruct.int_112[1] && gstruct.string_17 != null && gstruct.string_17 != string.Empty && (long)gstruct.int_112[2] <= Class12.smethod_28(long_8);
						if (flag45)
						{
							flag8 = (Class32.smethod_7(gstruct, gstruct.string_17, gstruct.int_112[3], -1, 1) <= 0);
							long_8 = Class12.smethod_27();
						}
						bool flag46 = gstruct.int_106[0] > 0 && gstruct.int_106[1] > 0 && num26 <= (long)gstruct.int_106[1] && (long)gstruct.int_106[2] <= Class12.smethod_28(long_5);
						if (flag46)
						{
							bool flag47 = false;
							bool flag48 = gstruct.int_108 > 0 && flag3;
							if (flag48)
							{
								flag3 = (flag47 = (Class32.smethod_6(gstruct, 0, gstruct.int_106[3], true) > 0));
							}
							bool flag49 = !flag47;
							if (flag49)
							{
								flag42 = (Class32.smethod_6(gstruct, 0, gstruct.int_106[3], false) <= 0);
							}
							long_5 = Class12.smethod_27();
						}
						bool flag50 = gstruct.int_109[0] > 0 && gstruct.int_109[1] > 0 && num32 <= (double)gstruct.int_109[1] && (long)gstruct.int_109[2] <= Class12.smethod_28(long_3);
						if (flag50)
						{
							bool flag51 = false;
							bool flag52 = gstruct.int_108 > 0 && flag3;
							if (flag52)
							{
								flag3 = (flag51 = (Class32.smethod_6(gstruct, 0, gstruct.int_109[3], true) > 0));
							}
							bool flag53 = !flag51;
							if (flag53)
							{
								flag42 = (Class32.smethod_6(gstruct, 0, gstruct.int_109[3], false) <= 0);
							}
							long_3 = Class12.smethod_27();
						}
						bool flag54 = gstruct.int_107[0] > 0 && gstruct.int_107[1] > 0 && num29 <= (long)gstruct.int_107[1] && (long)gstruct.int_107[2] <= Class12.smethod_28(long_6);
						if (flag54)
						{
							bool flag55 = flag2;
							if (flag55)
							{
								flag2 = (Class32.smethod_6(gstruct, 1, gstruct.int_107[3], true) > 0);
							}
							bool flag56 = !flag2;
							if (flag56)
							{
								flag43 = (Class32.smethod_6(gstruct, 1, gstruct.int_107[3], false) <= 0);
							}
							long_6 = Class12.smethod_27();
						}
						bool flag57 = gstruct.int_111[0] > 0 && gstruct.int_111[1] > 0 && num33 <= (double)gstruct.int_111[1] && (long)gstruct.int_111[2] <= Class12.smethod_28(long_4);
						if (flag57)
						{
							bool flag58 = flag2;
							if (flag58)
							{
								flag2 = (Class32.smethod_6(gstruct, 1, gstruct.int_111[3], true) > 0);
							}
							bool flag59 = !flag2;
							if (flag59)
							{
								flag43 = (Class32.smethod_6(gstruct, 1, gstruct.int_111[3], false) <= 0);
							}
							long_4 = Class12.smethod_27();
						}
						bool flag60 = Form1.int_20 == 0 && gstruct.int_25 > 0 && gstruct.int_19 > 0 && num26 <= (long)gstruct.int_18;
						if (flag60)
						{
							bool flag61 = Class44.gstruct33_0.int_0 > 0;
							if (flag61)
							{
								Class70.smethod_50(gstruct, Class44.gstruct33_0.string_0, Class10.smethod_2("Thoát game vì Sinh lực thấp, Thím có thể thiết lập lại trong mục Hậu cần - Phục hồi nhé."));
								Thread.Sleep(600);
							}
							Class70.smethod_57(gstruct, "ExitGame()");
							Thread.Sleep(100);
							Class22.smethod_53(gstruct.process_0);
						}
						int num34 = Class79.smethod_4(gstruct);
						bool flag62 = num4 != num34;
						if (flag62)
						{
							num4 = num34;
							flag8 = false;
							flag7 = false;
							flag4 = false;
						}
						bool flag63 = num16 > 0 && ((flag42 && gstruct.int_115 > 0) || (flag43 && gstruct.int_117 > 0)) && !flag9 && !flag10 && !flag11 && Class12.smethod_28(long_2) > 800L;
						if (flag63)
						{
							bool flag64 = !flag6 && !flag5;
							if (flag64)
							{
								Class60.smethod_14(gstruct, false);
							}
							else
							{
								num5 = Class81.smethod_3(Form1.gstruct49_0, int_4);
								bool flag65 = 0 <= num5;
								if (flag65)
								{
									Form1.gstruct49_0[num5].bool_12 = true;
								}
							}
							long_2 = Class12.smethod_27();
						}
						bool flag66 = gstruct.int_74[0] > 0 && Class12.smethod_28(long_10) > (long)gstruct.int_74[1];
						if (flag66)
						{
							for (int m = 0; m < array.Length; m++)
							{
								for (uint num35 = 0U; num35 < 6U; num35 += 1U)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num35, array3, 4, ref num6);
									int num36 = BitConverter.ToInt32(array3, 0);
									bool flag67 = num36 == array[m];
									if (flag67)
									{
										Class32.smethod_6(gstruct, 3, gstruct.int_74[2], true);
										long_10 = Class12.smethod_27();
										break;
									}
								}
							}
						}
						bool flag68 = gstruct.int_58 <= 0 || num16 <= 0 || flag4 || Class12.smethod_28(long_9) <= 30000L;
						if (!flag68)
						{
							int num37 = 0;
							for (uint num38 = 0U; num38 < 6U; num38 += 1U)
							{
								uint num39 = Class53.gstruct51_57.uint_0 + Class53.gstruct51_2.uint_0 + Class53.gstruct51_3.uint_0 * num38;
								int num40 = (int)Class22.smethod_30(num11 + num39 + 20U, gstruct.int_137);
								bool flag69 = num40 == 1;
								if (flag69)
								{
									num37++;
									Class22.ReadProcessMemory(gstruct.int_137, num11 + num39, array3, 4, ref num6);
									int num41 = BitConverter.ToInt32(array3, 0);
									bool flag70 = num41 == 67;
									if (flag70)
									{
										num37 = -1;
										break;
									}
								}
							}
							bool flag71 = num37 != -1 && num37 < 6;
							if (flag71)
							{
								flag4 = !Class32.smethod_8(gstruct);
							}
							long_9 = Class12.smethod_27();
						}
					}
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001B5A8 File Offset: 0x000197A8
		public static int[] smethod_5(GStruct49 gstruct49_0, int int_4, bool bool_0 = false)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			int[] array3 = new int[2];
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				uint num7 = num3 + num6 * 20U;
				Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
				uint num8 = BitConverter.ToUInt32(array2, 0);
				bool flag2 = num8 == 0U;
				if (!flag2)
				{
					uint num9 = num2 + num8 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num9, array2, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array2, 0) == 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
						bool flag4 = BitConverter.ToInt32(array2, 0) != 0;
						if (!flag4)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_107.uint_0, array, 1, ref num);
							bool flag5 = array[0] == 0;
							if (!flag5)
							{
								num5++;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num7 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								int num10 = (int)array[0];
								bool flag6 = num10 != 3;
								if (!flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_111.uint_0, array, 1, ref num);
									int num11 = (int)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_112.uint_0, array, 1, ref num);
									int num12 = (int)array[0];
									array3[1] += num12 * num11;
									bool flag7 = num11 != 1 || num12 != 1;
									if (!flag7)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_108.uint_0, array, 1, ref num);
										bool flag8 = array[0] != 1;
										if (!flag8)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_110.uint_0, array2, 4, ref num);
											int num13 = BitConverter.ToInt32(array2, 0);
											bool flag9 = num13 == int_4 || (!bool_0 && num13 > 0 && (num13 % 2 == 0 || num13 == 9));
											if (flag9)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_119.uint_0, array2, 4, ref num);
												int num14 = BitConverter.ToInt32(array2, 0);
												bool flag10 = num14 <= 0;
												if (flag10)
												{
													num14 = 1;
												}
												array3[0] += num14;
											}
										}
									}
								}
							}
						}
					}
				}
				num6 += 1U;
			}
			return array3;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		public static int smethod_6(GStruct49 gstruct49_0, int int_4, int int_5 = 1, bool bool_0 = false)
		{
			int num = 0;
			uint num2 = 1U;
			int num3 = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num3);
			uint num4 = BitConverter.ToUInt32(array2, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num3);
			uint num5 = BitConverter.ToUInt32(array2, 0) + Class53.gstruct51_97.uint_0;
			for (;;)
			{
				int num6 = Class79.smethod_4(gstruct49_0);
				int num7 = 0;
				uint num8 = num2;
				uint num9;
				int num12;
				int num16;
				int num17;
				int num18;
				for (;;)
				{
					bool flag = (ulong)num8 < (ulong)((long)Class53.int_1) && num6 > num7;
					if (!flag)
					{
						return num;
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, num5 + (num8 * 5U + Class53.gstruct51_99.uint_0) * 4U, array2, 4, ref num3);
					num9 = BitConverter.ToUInt32(array2, 0);
					bool flag2 = num9 == 0U || num3 != 4;
					if (!flag2)
					{
						uint num10 = num4 + num9 * Class53.gstruct51_106.uint_0;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num3);
						bool flag3 = BitConverter.ToInt32(array2, 0) != 0 || num3 != 4;
						if (!flag3)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_107.uint_0, array, 1, ref num3);
							bool flag4 = array[0] == 0 || num3 == 0;
							if (!flag4)
							{
								num7++;
								uint num11 = num5 + num8 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num3);
								num12 = (int)array[0];
								bool flag5 = num12 != 3 || num3 == 0;
								if (!flag5)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_108.uint_0, array, 1, ref num3);
									bool flag6 = array[0] != 1 || num3 == 0;
									if (!flag6)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_110.uint_0, array2, 4, ref num3);
										bool flag7 = num3 != 4;
										if (!flag7)
										{
											int num13 = BitConverter.ToInt32(array2, 0);
											bool flag8 = num13 != int_4 && (bool_0 || num13 <= 0 || (num13 % 2 != 0 && num13 != 9));
											if (!flag8)
											{
												Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_111.uint_0, array, 1, ref num3);
												int num14 = (int)array[0];
												bool flag9 = num14 != 1 || num3 == 0;
												if (!flag9)
												{
													Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_112.uint_0, array, 1, ref num3);
													int num15 = (int)array[0];
													bool flag10 = num15 != 1 || num3 == 0;
													if (!flag10)
													{
														Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num3);
														num16 = (int)array[0];
														Class22.ReadProcessMemory(gstruct49_0.int_137, num11 + Class53.gstruct51_100.uint_0, array, 1, ref num3);
														num17 = (int)array[0];
														Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_119.uint_0, array2, 4, ref num3);
														num18 = BitConverter.ToInt32(array2, 0);
														bool flag11 = num3 != 4;
														if (!flag11)
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
					num8 += 1U;
				}
				Class70.smethod_43(gstruct49_0, num9, num16, num17, num12);
				num++;
				bool flag12 = num < int_5;
				if (!flag12)
				{
					break;
				}
				num2 = num8 + (uint)Convert.ToByte(num18 <= 0);
			}
			return num;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001BC60 File Offset: 0x00019E60
		public static int smethod_7(GStruct49 gstruct49_0, string string_0, int int_4 = 1, int int_5 = -1, int int_6 = 1)
		{
			bool flag = string_0 != null && !(string_0 == string.Empty);
			int result;
			if (flag)
			{
				int num = 0;
				uint num2 = 1U;
				int num3 = 0;
				byte[] array = new byte[4];
				byte[] array2 = new byte[1];
				int num4 = string_0.Length + 3;
				byte[] byte_ = new byte[num4];
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num3);
				uint num5 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num3);
				uint num6 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
				for (;;)
				{
					int num7 = Class79.smethod_4(gstruct49_0);
					int num8 = 0;
					uint num9 = num2;
					uint num11;
					int num13;
					int num16;
					int num17;
					for (;;)
					{
						bool flag2 = (ulong)num9 < (ulong)((long)Class53.int_1) && num7 > num8;
						if (!flag2)
						{
							goto IL_33B;
						}
						uint num10 = num6 + num9 * 20U;
						Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_99.uint_0 * 4U, array, 4, ref num3);
						num11 = BitConverter.ToUInt32(array, 0);
						bool flag3 = num11 == 0U || num3 != 4;
						if (!flag3)
						{
							uint num12 = num5 + num11 * Class53.gstruct51_106.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num3);
							bool flag4 = BitConverter.ToInt32(array, 0) != 0 || num3 != 4;
							if (!flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_107.uint_0, array2, 1, ref num3);
								bool flag5 = array2[0] == 0 || num3 == 0;
								if (!flag5)
								{
									num8++;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 8U, array2, 1, ref num3);
									num13 = (int)array2[0];
									bool flag6 = num13 != 3 || num3 == 0;
									if (!flag6)
									{
										bool flag7 = int_6 > 0;
										if (flag7)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_111.uint_0, array2, 1, ref num3);
											int num14 = (int)array2[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_112.uint_0, array2, 1, ref num3);
											int num15 = (int)array2[0];
											bool flag8 = num14 * num15 != int_6;
											if (flag8)
											{
												goto IL_340;
											}
										}
										Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_107.uint_0, byte_, num4, ref num3);
										string a = Class10.smethod_3(byte_);
										bool flag9 = a != string_0 || num3 == 0;
										if (!flag9)
										{
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0 - 4U, array2, 1, ref num3);
											num16 = (int)array2[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num10 + Class53.gstruct51_100.uint_0, array2, 1, ref num3);
											num17 = (int)array2[0];
											Class22.ReadProcessMemory(gstruct49_0.int_137, num12 + Class53.gstruct51_119.uint_0, array, 4, ref num3);
											bool flag10 = num3 != 4;
											if (!flag10)
											{
												break;
											}
										}
									}
								}
							}
						}
						IL_340:
						num9 += 1U;
					}
					int num18 = BitConverter.ToInt32(array, 0);
					Class70.smethod_43(gstruct49_0, num11, num16, num17, num13);
					num++;
					bool flag11 = num < int_4;
					if (!flag11)
					{
						break;
					}
					num2 = num9 + (uint)Convert.ToByte(num18 <= 0);
				}
				IL_33B:
				result = num;
			}
			else
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001BFE0 File Offset: 0x0001A1E0
		public static bool smethod_8(GStruct49 gstruct49_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			string text = "Tiªn Th¶o Lé".ToLower();
			byte[] array2 = new byte[text.Length + 3];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1))
			{
				bool flag = num4 <= num5;
				if (flag)
				{
					break;
				}
				Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				bool flag2 = num7 == 0U;
				if (!flag2)
				{
					uint num8 = num2 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
					bool flag3 = BitConverter.ToInt32(array, 0) != 0;
					if (!flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag4 = array[0] == 0;
						if (!flag4)
						{
							num5++;
							uint num9 = num3 + num6 * 20U;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
							int num10 = (int)array[0];
							bool flag5 = num10 == 3;
							if (flag5)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num);
								string string_ = Class10.smethod_3(array2).Replace("Ù", string.Empty).ToLower();
								bool flag6 = Class12.smethod_1(string_, text) >= 0;
								if (flag6)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
									int num11 = (int)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0, array, 1, ref num);
									int num12 = (int)array[0];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_119.uint_0, array, 4, ref num);
									BitConverter.ToInt32(array, 0);
									Class70.smethod_43(gstruct49_0, num7, num11, num12, num10);
									return true;
								}
							}
						}
					}
				}
				num6 += 1U;
			}
			return false;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001C274 File Offset: 0x0001A474
		public static void smethod_9(GStruct49 gstruct49_0)
		{
			try
			{
				Class32.smethod_10(gstruct49_0);
			}
			catch
			{
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		private static void smethod_10(GStruct49 gstruct49_0)
		{
			int num = 0;
			string[] array = new string[]
			{
				gstruct49_0.string_11,
				gstruct49_0.string_12,
				gstruct49_0.string_13
			};
			int num2 = 0;
			byte[] array2 = new byte[80];
			uint num3 = Class22.smethod_30(Class53.gstruct51_105.uint_0, gstruct49_0.int_137);
			Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			GStruct51 gstruct51_ = Class53.gstruct51_97;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				bool flag = text == null || text == string.Empty;
				if (!flag)
				{
					text = array[i].Trim();
					string object_ = Class10.smethod_1(array[i], 1, false).ToUpper();
					bool flag2 = gstruct49_0.int_75.Length <= i + 1;
					if (!flag2)
					{
						uint num4 = (uint)gstruct49_0.int_75[i + 1];
						bool flag3 = num4 == 0U || num4 > 9U;
						if (!flag3)
						{
							bool flag4 = false;
							for (int j = 0; j < 9; j++)
							{
								uint num5 = Class45.smethod_7(gstruct49_0, j);
								bool flag5 = num5 > 0U;
								if (flag5)
								{
									uint num6 = num3 + num5 * Class53.gstruct51_106.uint_0;
									Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num2);
									string text2 = Class10.smethod_3(array2);
									string string_ = Class10.smethod_1(text2, 1, false);
									bool flag6 = 0 <= Class12.smethod_1(text2, text) || 0 <= Class12.smethod_1(string_, object_);
									if (flag6)
									{
										flag4 = true;
										break;
									}
								}
							}
							bool flag7 = flag4;
							if (!flag7)
							{
								uint num7 = Class79.smethod_30(gstruct49_0, text, false, 3U, false);
								bool flag8 = num7 > 0U;
								if (flag8)
								{
									num = 300;
									uint uint_ = Class79.smethod_1(gstruct49_0, num7);
									uint num8 = Class79.smethod_6(gstruct49_0, uint_);
									uint num9 = Class79.smethod_7(gstruct49_0, uint_);
									bool flag9 = true;
									int num10 = 0;
									for (;;)
									{
										bool flag10 = !Class12.bool_0;
										if (!flag10)
										{
											break;
										}
										bool flag11 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) > 0U;
										if (flag11)
										{
											goto Block_12;
										}
										bool flag12 = num10 % 30 == 0;
										if (flag12)
										{
											Class70.smethod_46(gstruct49_0, num8, num9, 3U, num8, num9, 3U);
										}
										Thread.Sleep(3);
										num10++;
										bool flag13 = num10 > 300;
										if (flag13)
										{
											goto Block_14;
										}
									}
									break;
									IL_267:
									bool flag14 = !flag9;
									if (flag14)
									{
										goto IL_330;
									}
									num10 = 0;
									num4 -= 1U;
									for (;;)
									{
										bool flag15 = !Class12.bool_0;
										if (!flag15)
										{
											goto IL_2F7;
										}
										bool flag16 = Class22.smethod_30(Class53.gstruct51_123.uint_0, gstruct49_0.int_137) <= 0U;
										if (flag16)
										{
											break;
										}
										bool flag17 = num10 % 30 == 0;
										if (flag17)
										{
											Class70.smethod_46(gstruct49_0, num4, 0U, 7U, num4, 0U, 7U);
										}
										Thread.Sleep(3);
										num10++;
										bool flag18 = num10 > 300;
										if (flag18)
										{
											goto Block_19;
										}
									}
									IL_2FE:
									bool flag19 = !flag9;
									if (flag19)
									{
										Class70.smethod_46(gstruct49_0, num8, num9, 3U, num8, num9, 3U);
									}
									goto IL_32F;
									Block_19:
									flag9 = false;
									goto IL_2FE;
									IL_2F7:
									break;
									Block_14:
									flag9 = false;
									Block_12:
									goto IL_267;
								}
								bool flag20 = num <= 0;
								if (flag20)
								{
									num = 60;
								}
								IL_32F:;
							}
						}
					}
				}
				IL_330:;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001C5F8 File Offset: 0x0001A7F8
		private static void smethod_11(GStruct49 gstruct49_0)
		{
			int num = 0;
			int num2 = 0;
			byte[] byte_ = new byte[4];
			uint num3 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct49_0.int_137);
			uint num4 = Class22.smethod_30(num3 + Class53.gstruct51_13.uint_0, gstruct49_0.int_137);
			uint num5 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct49_0.int_137);
			uint num6 = num5 + num4 * Class53.gstruct51_15.uint_0;
			int num7 = 0;
			while (num7 < 300 && num < 1000)
			{
				Class22.WriteProcessMemory(gstruct49_0.int_137, gstruct49_0.uint_7 + Class53.gstruct51_178.uint_0, byte_, 4, ref num2);
				Class22.WriteProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_72.uint_0, byte_, 4, ref num2);
				num7 = ((Class22.smethod_30(num6 + Class53.gstruct51_55.uint_0, gstruct49_0.int_137) < 3U) ? (num7 + 1) : 0);
				num++;
				Thread.Sleep(1);
			}
			Thread.Sleep(100);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001C704 File Offset: 0x0001A904
		private static void smethod_12(GStruct49 gstruct49_0, int int_4)
		{
			uint num = 0U;
			int num2 = 0;
			for (;;)
			{
				bool flag = num == 0U;
				if (!flag)
				{
					break;
				}
				num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_158.uint_0, gstruct49_0.int_137);
				Thread.Sleep(1);
				num2++;
				if (num2 > 300)
				{
					return;
				}
			}
			int num3 = -1;
			long long_ = Class12.smethod_27();
			while (Class12.smethod_28(long_) <= (long)int_4)
			{
				Thread.Sleep(100);
				num = Class22.smethod_30(gstruct49_0.uint_7 + Class53.gstruct51_158.uint_0, gstruct49_0.int_137);
				int num4 = (int)Class22.smethod_30(num + Class53.gstruct51_159.uint_0, gstruct49_0.int_137);
				bool flag2 = num4 > 1;
				if (flag2)
				{
					bool flag3 = num3 < 0 && num4 > 100;
					if (flag3)
					{
						break;
					}
					num3 = 0;
				}
				else
				{
					num3++;
					bool flag4 = num3 > 3;
					if (flag4)
					{
						break;
					}
				}
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0001C800 File Offset: 0x0001AA00
		public static void smethod_13()
		{
			int int_ = Class32.int_2;
			Class32.int_2 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_29 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_29;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_29 = true;
						flag = true;
					}
					Class32.smethod_14(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
		private static void smethod_14(int int_4)
		{
			GStruct49 gstruct = default(GStruct49);
			long[] array = null;
			long[] array2 = null;
			long[] array3 = null;
			bool[] array4 = null;
			int[] array5 = null;
			int[] array6 = null;
			int[] array7 = null;
			byte[] array8 = new byte[4];
			int num = 0;
			int num2 = 300;
			int num3 = -1;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			long long_ = 0L;
			for (;;)
			{
				int num15;
				int num16;
				int num18;
				for (;;)
				{
					IL_4D:
					Thread.Sleep(100 + num2);
					int num9 = Class81.smethod_3(Form1.gstruct49_0, int_4);
					bool flag = Class12.bool_0 || num9 < 0 || !Form1.gstruct49_0[num9].bool_25;
					if (flag)
					{
						return;
					}
					gstruct = Form1.gstruct49_0[num9];
					num2 = 300;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array8, 4, ref num);
					bool flag2 = num != 4;
					if (!flag2)
					{
						uint num10 = BitConverter.ToUInt32(array8, 0);
						Class22.ReadProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_13.uint_0, array8, 4, ref num);
						uint num11 = BitConverter.ToUInt32(array8, 0);
						uint num12 = num11 * Class53.gstruct51_15.uint_0;
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array8, 4, ref num);
						bool flag3 = num != 4;
						if (!flag3)
						{
							uint num13 = BitConverter.ToUInt32(array8, 0);
							uint num14 = num13 + num12;
							Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_43.uint_0, array8, 4, ref num);
							num15 = BitConverter.ToInt32(array8, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_55.uint_0, array8, 4, ref num);
							num16 = BitConverter.ToInt32(array8, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num14 + Class53.gstruct51_50.uint_0, array8, 4, ref num);
							int num17 = BitConverter.ToInt32(array8, 0);
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array8, 4, ref num);
							num18 = BitConverter.ToInt32(array8, 0);
							int num19 = Class83.smethod_39(gstruct);
							bool flag4 = num17 == 0 || num16 == 0 || num19 <= 1 || num18 == 0;
							if (flag4)
							{
								goto Block_9;
							}
							bool flag5 = num15 <= 0 || num7 != num18;
							if (flag5)
							{
								num7 = num18;
								num8 = 0;
							}
							bool flag6 = num15 > 0 && gstruct.int_131[0] > 0 && gstruct.int_136 != Class44.gstruct33_0.int_0 && Class70.smethod_3(gstruct, Class70.uint_31, 4) == 1;
							if (!flag6)
							{
								goto IL_40D;
							}
							bool flag7 = false;
							int num20 = Class79.smethod_4(gstruct);
							for (int i = 0; i < Class53.string_24.GetLength(0); i++)
							{
								for (int j = 0; j < Class53.string_24.GetLength(1); j++)
								{
									bool flag8 = Class53.string_24[i, j] != null;
									if (flag8)
									{
										uint num21 = Class79.smethod_30(gstruct, Class53.string_24[i, j], false, 3U, true);
										bool flag9 = num21 > 0U;
										if (flag9)
										{
											Class70.smethod_103(gstruct, num21);
											flag7 = true;
											Thread.Sleep(300);
											break;
										}
									}
								}
							}
							Class70.smethod_2(gstruct, Class70.uint_31, 2, 4);
							bool flag10 = flag7 && Form1.int_28 > 0 && num8 < 4 && (num18 == 336 || !Class32.smethod_0(num18));
							if (flag10)
							{
								for (int k = 0; k < 8; k++)
								{
									Thread.Sleep(150);
									bool flag11 = Class79.smethod_4(gstruct) < num20;
									if (flag11)
									{
										break;
									}
									num16 = (int)Class22.smethod_30(num14 + Class53.gstruct51_55.uint_0, gstruct.int_137);
									num15 = (int)Class22.smethod_30(num14 + Class53.gstruct51_43.uint_0, gstruct.int_137);
									bool flag12 = num16 != 10 && num16 != 21 && num15 != 0;
									if (!flag12)
									{
										goto IL_4D;
									}
								}
								goto IL_3FD;
							}
							goto IL_40C;
						}
					}
				}
				continue;
				Block_9:
				Thread.Sleep(100);
				continue;
				IL_40D:
				bool flag13 = num16 == 10 || num16 == 21;
				if (flag13)
				{
					continue;
				}
				bool flag14 = num5 > 0;
				if (flag14)
				{
					num5--;
					bool flag15 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
					if (flag15)
					{
						Class22.smethod_4(gstruct.uint_4, 13U);
						Thread.Sleep(10);
					}
					bool flag16 = num5 == 0;
					if (flag16)
					{
						Class86.smethod_8(gstruct, -1);
					}
				}
				bool flag17 = num6 >= 10 || Class70.smethod_3(gstruct, Class70.uint_5, 4) <= 0;
				if (!flag17)
				{
					num6++;
					Thread.Sleep(10);
					continue;
				}
				num6 = 0;
				bool flag18 = gstruct.gstruct34_0 == null;
				if (flag18)
				{
					continue;
				}
				bool flag19 = num3 != gstruct.gstruct34_0.Length;
				if (flag19)
				{
					num3 = gstruct.gstruct34_0.Length;
					bool flag20 = num3 == 0;
					if (flag20)
					{
						continue;
					}
					array = new long[num3];
					array2 = new long[num3];
					array3 = new long[num3];
					array5 = new int[num3];
					array4 = new bool[num3];
					array6 = new int[num3];
					array7 = new int[num3];
				}
				for (int l = 0; l < num3; l++)
				{
					bool flag21 = gstruct.gstruct34_0[l].int_4 > 0;
					if (flag21)
					{
						num2 = 0;
						break;
					}
				}
				bool flag22 = num3 <= num4;
				if (flag22)
				{
					num4 = 0;
				}
				GStruct34 gstruct2 = gstruct.gstruct34_0[num4];
				bool flag23 = gstruct2.int_7 > 0 && gstruct2.int_8 != null;
				int num22 = Class79.smethod_4(gstruct);
				int num23 = 0;
				int num24 = 0;
				int num25 = 400;
				bool flag24 = Form1.int_69 > 0;
				if (flag24)
				{
					num25 = 900;
				}
				bool flag25 = Form1.int_13 <= 0 || num15 > 0;
				if (flag25)
				{
					bool flag26 = gstruct2.int_4 > 0 && ((!array4[num4] && array5[num4] != num22) || Class12.smethod_28(array[num4]) >= 300L);
					if (flag26)
					{
						array[num4] = Class12.smethod_27();
						array4[num4] = false;
						int[] array9 = Class32.smethod_5(gstruct, 2, false);
						bool flag27 = gstruct2.int_5 >= array9[0];
						if (flag27)
						{
							bool flag28 = array9[1] > 59;
							if (flag28)
							{
								array5[num4] = num22;
								continue;
							}
							while (Class60.smethod_17(gstruct, gstruct2.string_0, true))
							{
								bool flag29 = num5 <= 0;
								if (flag29)
								{
									num5 = 8;
								}
								int m = 0;
								num22 = Class79.smethod_4(gstruct);
								while (m < num25)
								{
									int num26 = Class79.smethod_4(gstruct);
									bool flag30 = num26 <= num22 && gstruct2.int_6 != 0 && (!flag23 || 0 > Class86.smethod_0(gstruct));
									if (!flag30)
									{
										goto IL_B6E;
									}
									bool flag31 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
									if (flag31)
									{
										break;
									}
									Thread.Sleep(1);
									m++;
								}
								bool flag32 = Class45.smethod_5(gstruct, Form1.int_12.ToString(), true) <= 0;
								if (flag32)
								{
									int num27 = Class79.smethod_4(gstruct);
									bool flag33 = num27 <= num22;
									if (flag33)
									{
										bool flag34 = num23 == 0;
										if (flag34)
										{
											num23++;
											continue;
										}
										int num28 = Class60.smethod_27(gstruct, gstruct2.string_0, Form1.int_12, true);
										bool flag35 = num28 > 0;
										if (!flag35)
										{
											goto IL_B62;
										}
									}
								}
								goto IL_B6E;
							}
							array4[num4] = (Class79.smethod_31(gstruct, gstruct2.string_0, 3, false, false) <= 0);
							bool flag36 = array4[num4] && Form1.int_29 > 0 && Class12.smethod_28(long_) > 30000L;
							if (flag36)
							{
								Class34.smethod_1(gstruct, false);
								long_ = Class12.smethod_27();
							}
							goto IL_B62;
						}
						else
						{
							array5[num4] = num22;
						}
					}
					bool flag37 = array2[num4] == 0L;
					if (flag37)
					{
						array2[num4] = Class12.smethod_27();
					}
					bool flag38 = gstruct2.int_0 > 0;
					if (flag38)
					{
						bool flag39 = Class12.smethod_28(array2[num4]) >= (long)gstruct2.int_3;
						if (flag39)
						{
							array2[num4] = Class12.smethod_27();
							while (Class60.smethod_17(gstruct, gstruct2.string_0, true))
							{
								bool flag40 = num5 <= 0;
								if (flag40)
								{
									num5 = 8;
								}
								int m = 0;
								num22 = Class79.smethod_4(gstruct);
								while (m < num25)
								{
									int num29 = Class79.smethod_4(gstruct);
									bool flag41 = num29 <= num22 && gstruct2.int_6 != 0 && (!flag23 || 0 > Class86.smethod_0(gstruct));
									if (!flag41)
									{
										goto IL_B6E;
									}
									bool flag42 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
									if (flag42)
									{
										break;
									}
									Thread.Sleep(1);
									m++;
								}
								bool flag43 = Class45.smethod_5(gstruct, Form1.int_12.ToString(), true) <= 0;
								if (flag43)
								{
									int num30 = Class79.smethod_4(gstruct);
									bool flag44 = num30 <= num22;
									if (flag44)
									{
										bool flag45 = num24 == 0;
										if (flag45)
										{
											num24++;
											continue;
										}
										int num28 = Class60.smethod_27(gstruct, gstruct2.string_0, Form1.int_12, true);
										bool flag46 = num28 <= 0;
										if (flag46)
										{
											break;
										}
									}
								}
								goto IL_B6E;
							}
							goto IL_B62;
						}
					}
					else
					{
						array2[num4] = Class12.smethod_27();
					}
					goto IL_98E;
				}
				goto IL_98E;
				IL_B62:
				num4++;
				continue;
				IL_B6E:
				int num31 = 0;
				while (flag23 && num31 < 10)
				{
					Thread.Sleep(100);
					bool flag47 = 0 > Class86.smethod_0(gstruct);
					if (!flag47)
					{
						for (int n = 0; n < gstruct2.int_8.Length; n++)
						{
							int num32 = gstruct2.int_8[n] - 1;
							bool flag48 = 0 <= num32;
							if (flag48)
							{
								Class86.smethod_5(gstruct, num32);
								Thread.Sleep(50 + Class86.int_0);
							}
						}
						break;
					}
					num31++;
				}
				array5[num4] = Class79.smethod_4(gstruct);
				goto IL_B62;
				IL_98E:
				bool flag49 = gstruct2.int_1 > 0 && (array7[num4] != num18 || array6[num4] != num15);
				if (flag49)
				{
					bool flag50 = Class12.smethod_28(array3[num4]) >= 800L;
					if (flag50)
					{
						array7[num4] = num18;
						array6[num4] = num15;
						array3[num4] = Class12.smethod_27();
						while (Class60.smethod_17(gstruct, gstruct2.string_0, true))
						{
							bool flag51 = num5 <= 0;
							if (flag51)
							{
								num5 = 8;
							}
							for (int m = 0; m < num25; m++)
							{
								int num33 = Class79.smethod_4(gstruct);
								bool flag52 = num33 <= num22 && gstruct2.int_6 != 0 && (!flag23 || 0 > Class86.smethod_0(gstruct));
								if (!flag52)
								{
									goto IL_B6E;
								}
								bool flag53 = Class22.smethod_30(gstruct.uint_7 + Class53.gstruct51_172.uint_0, gstruct.int_137) > 0U;
								if (flag53)
								{
									break;
								}
								Thread.Sleep(1);
							}
							bool flag54 = Class45.smethod_5(gstruct, Form1.int_12.ToString(), true) <= 0;
							if (flag54)
							{
								int num34 = Class79.smethod_4(gstruct);
								bool flag55 = num34 <= num22;
								if (flag55)
								{
									bool flag56 = num24 == 0;
									if (flag56)
									{
										num24++;
										continue;
									}
									int num28 = Class60.smethod_27(gstruct, gstruct2.string_0, Form1.int_12, true);
									bool flag57 = num28 <= 0;
									if (flag57)
									{
										break;
									}
								}
							}
							goto IL_B6E;
						}
					}
				}
				else
				{
					array3[num4] = Class12.smethod_27();
				}
				goto IL_B62;
				IL_40C:
				goto IL_40D;
				IL_3FD:
				num8++;
				Class60.smethod_14(gstruct, true);
				goto IL_40C;
				goto IL_3FD;
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0001D508 File Offset: 0x0001B708
		public static void smethod_15()
		{
			int int_ = Class32.int_3;
			Class32.int_3 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25;
					if (flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_43 = false;
						}
						break;
					}
					bool flag4 = !flag;
					if (flag4)
					{
						bool bool_ = Form1.gstruct49_0[num].bool_43;
						if (bool_)
						{
							break;
						}
						Form1.gstruct49_0[num].bool_43 = true;
						flag = true;
					}
					Class32.smethod_16(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
		private static void smethod_16(int int_4)
		{
			int num = 0;
			byte[] array = new byte[1];
			byte[] array2 = new byte[4];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			long long_ = 0L;
			GStruct49 gstruct = default(GStruct49);
			for (;;)
			{
				for (;;)
				{
					IL_2E:
					num2--;
					Thread.Sleep(200);
					bool bool_ = Class12.bool_0;
					if (bool_)
					{
						return;
					}
					bool flag = num2 <= 0;
					if (flag)
					{
						num3 = Class81.smethod_3(Form1.gstruct49_0, int_4);
						bool flag2 = num3 < 0 || !Form1.gstruct49_0[num3].bool_25;
						if (flag2)
						{
							return;
						}
						num2 = 6;
					}
					bool flag3 = false;
					int num5 = Form1.gstruct49_0[num3].int_76[4];
					Form1.gstruct49_0[num3].int_76[4] = 0;
					gstruct = Form1.gstruct49_0[num3];
					bool flag4 = gstruct.string_14 == null || gstruct.string_14 == string.Empty || (gstruct.int_76[1] <= 0 && gstruct.int_76[0] <= 0);
					if (flag4)
					{
						break;
					}
					int num6 = Class79.smethod_4(gstruct);
					bool flag5 = gstruct.int_76[1] > 0 && num5 > 0;
					if (flag5)
					{
						flag3 = true;
					}
					else
					{
						bool flag6 = gstruct.int_76[0] <= 0;
						if (flag6)
						{
							goto Block_11;
						}
						long num7 = Class12.smethod_28(long_);
						bool flag7 = num7 < 300L || (num4 == num6 && num7 < 1500L);
						if (flag7)
						{
							continue;
						}
						num5 = 1;
					}
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_11.uint_0, array2, 4, ref num);
					uint num8 = BitConverter.ToUInt32(array2, 0);
					Class22.ReadProcessMemory(gstruct.int_137, num8 + Class53.gstruct51_13.uint_0, array2, 4, ref num);
					uint num9 = BitConverter.ToUInt32(array2, 0) * Class53.gstruct51_15.uint_0;
					Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_14.uint_0, array2, 4, ref num);
					uint num10 = BitConverter.ToUInt32(array2, 0);
					uint num11 = num10 + num9;
					Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_43.uint_0, array2, 4, ref num);
					bool flag8 = BitConverter.ToInt32(array2, 0) <= 0 && !flag3;
					if (!flag8)
					{
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
						int num12 = BitConverter.ToInt32(array2, 0);
						string string_ = gstruct.string_14;
						int num13 = gstruct.int_76[2];
						int num14 = gstruct.int_76[3];
						bool flag9 = num14 <= 0;
						if (flag9)
						{
							num14 = 1;
						}
						bool flag10 = flag3;
						if (flag10)
						{
							num13 = num14;
						}
						Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_105.uint_0, array2, 4, ref num);
						uint num15 = BitConverter.ToUInt32(array2, 0);
						uint num16 = num8 + Class53.gstruct51_97.uint_0;
						uint[,] array3 = new uint[num6, 3];
						byte[] array4 = new byte[string_.Length + 4];
						int num17 = 0;
						int num18 = 0;
						int num19 = 0;
						uint num20 = 1U;
						for (;;)
						{
							bool flag11 = (ulong)num20 < (ulong)((long)Class53.int_1);
							if (!flag11)
							{
								break;
							}
							Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_55.uint_0, array, 1, ref num);
							int num21 = (int)array[0];
							Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
							int num22 = BitConverter.ToInt32(array2, 0);
							int num23 = Class83.smethod_39(gstruct);
							bool flag12 = num21 == 0 || num21 == 10 || num21 == 21 || num23 <= 1 || num22 != num12;
							if (flag12)
							{
								goto Block_24;
							}
							bool flag13 = num6 > num19;
							if (!flag13)
							{
								break;
							}
							uint num24 = num16 + num20 * 20U;
							Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_99.uint_0 * 4U, array2, 4, ref num);
							uint num25 = BitConverter.ToUInt32(array2, 0);
							bool flag14 = num25 == 0U;
							if (!flag14)
							{
								uint num26 = num15 + num25 * Class53.gstruct51_106.uint_0;
								Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_106.uint_0 - 4U, array2, 4, ref num);
								bool flag15 = BitConverter.ToInt32(array2, 0) != 0;
								if (!flag15)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_107.uint_0, array, 1, ref num);
									bool flag16 = array[0] == 0;
									if (!flag16)
									{
										num19++;
										bool flag17 = (char)array[0] != string_[0];
										if (!flag17)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num24 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
											uint num27 = (uint)array[0];
											bool flag18 = num27 != 23U && num27 != 3U && num27 != 1U;
											if (!flag18)
											{
												Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_108.uint_0, array, 1, ref num);
												bool flag19 = array[0] == 0;
												if (!flag19)
												{
													Class22.ReadProcessMemory(gstruct.int_137, num26 + Class53.gstruct51_107.uint_0, array4, array4.Length, ref num);
													string text = Class10.smethod_3(array4);
													bool flag20 = text != string_ && (Form1.int_95 > 0 || string_[0] != text[0] || text.IndexOf(string_) < 0);
													if (!flag20)
													{
														bool flag21 = num5 < 2;
														if (flag21)
														{
															bool flag22 = num27 == 3U;
															if (flag22)
															{
																bool flag23 = num13 > num17;
																if (!flag23)
																{
																	goto IL_5B0;
																}
																num17++;
															}
															else
															{
																array3[num18, 0] = num27;
																array3[num18, 1] = num25;
																array3[num18, 2] = num20;
																num18++;
															}
														}
														else
														{
															bool flag24 = num27 != 23U;
															if (flag24)
															{
																array3[num18, 0] = num27;
																array3[num18, 1] = num25;
																array3[num18, 2] = num20;
																num18++;
															}
														}
													}
												}
											}
										}
									}
								}
							}
							num20 += 1U;
						}
						IL_635:
						uint num28 = 23U;
						int num29 = num18;
						bool flag25 = num5 < 2;
						if (flag25)
						{
							num28 = 3U;
							num29 = num14 - num17;
							bool flag26 = num29 > num18;
							if (flag26)
							{
								num29 = num18;
							}
						}
						bool flag27 = num29 > 0 && num18 > 0;
						if (flag27)
						{
							for (int i = 0; i < num18; i++)
							{
								Class22.ReadProcessMemory(gstruct.int_137, num11 + Class53.gstruct51_55.uint_0, array, 1, ref num);
								int num30 = (int)array[0];
								Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array2, 4, ref num);
								int num31 = BitConverter.ToInt32(array2, 0);
								int num32 = Class83.smethod_39(gstruct);
								bool flag28 = num30 == 0 || num30 == 10 || num30 == 21 || num32 <= 1 || num31 != num12;
								if (flag28)
								{
									goto IL_2E;
								}
								bool flag29 = num29 <= 0;
								if (flag29)
								{
									break;
								}
								uint num33 = array3[i, 1];
								uint num34 = array3[i, 2];
								uint num35 = num15 + num33 * Class53.gstruct51_106.uint_0;
								uint num36 = num16 + num34 * 20U;
								Class22.ReadProcessMemory(gstruct.int_137, num36 + Class53.gstruct51_100.uint_0 - 4U, array2, 4, ref num);
								uint uint_ = BitConverter.ToUInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num36 + Class53.gstruct51_100.uint_0, array2, 4, ref num);
								uint uint_2 = BitConverter.ToUInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num35 + Class53.gstruct51_111.uint_0, array2, 4, ref num);
								uint uint_3 = BitConverter.ToUInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num35 + Class53.gstruct51_112.uint_0, array2, 4, ref num);
								uint uint_4 = BitConverter.ToUInt32(array2, 0);
								Class22.ReadProcessMemory(gstruct.int_137, num16 + num34 * 20U + Class53.gstruct51_100.uint_0 - 8U, array2, 4, ref num);
								uint num37 = BitConverter.ToUInt32(array2, 0);
								bool flag30 = num37 != num28;
								if (flag30)
								{
									uint[] array5 = Class79.smethod_26(gstruct, num28, uint_3, uint_4);
									bool flag31 = array5 == null;
									if (flag31)
									{
										break;
									}
									uint num38 = num37;
									for (int j = 0; j < 1000; j++)
									{
										bool flag32 = num38 == 1U;
										if (flag32)
										{
											num38 = num28;
											uint_ = array5[0];
											uint_2 = array5[1];
										}
										bool flag33 = j % 100 == 0;
										if (flag33)
										{
											Class22.ReadProcessMemory(gstruct.int_137, num16 + num34 * 20U + Class53.gstruct51_100.uint_0 - 8U, array2, 4, ref num);
											uint num39 = BitConverter.ToUInt32(array2, 0);
											bool flag34 = num39 != num38;
											if (flag34)
											{
												bool flag35 = num39 != num28;
												if (flag35)
												{
													goto Block_59;
												}
												IL_966:
												num29--;
												goto IL_96E;
											}
											else
											{
												Class70.smethod_46(gstruct, uint_, uint_2, num38, array5[0], array5[1], num28);
											}
										}
										Class22.ReadProcessMemory(gstruct.int_137, num16 + num34 * 20U + Class53.gstruct51_100.uint_0 - 8U, array2, 4, ref num);
										uint num40 = BitConverter.ToUInt32(array2, 0);
										bool flag36 = num40 == num28 || num40 != num37;
										if (flag36)
										{
											break;
										}
										num38 = num40;
										Thread.Sleep(1);
									}
									goto IL_966;
								}
								else
								{
									num29--;
								}
								IL_96E:;
							}
							goto IL_983;
						}
						goto IL_984;
						goto IL_635;
					}
				}
				Thread.Sleep(300);
				continue;
				Block_11:
				Thread.Sleep(300);
				continue;
				IL_984:
				long_ = Class12.smethod_27();
				num4 = Class79.smethod_4(gstruct);
				continue;
				IL_983:
				goto IL_984;
				goto IL_983;
				IL_5B0:
				long_ = Class12.smethod_27();
				num4 = Class79.smethod_4(gstruct);
				Block_24:
				continue;
				Block_59:
				goto IL_983;
			}
		}

		// Token: 0x040000E5 RID: 229
		public static int int_0;

		// Token: 0x040000E6 RID: 230
		public static int int_1;

		// Token: 0x040000E7 RID: 231
		public static int int_2;

		// Token: 0x040000E8 RID: 232
		public static int int_3;
	}
}
