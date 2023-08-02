using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200004A RID: 74
	internal class Class76
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x000C837C File Offset: 0x000C657C
		public static void smethod_0()
		{
			Process currentProcess = Process.GetCurrentProcess();
			byte[] array = new byte[8];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = 8;
			}
			int int_ = Class22.OpenProcess(2035711, false, currentProcess.Id);
			uint num = Class22.smethod_1(int_, 4096U, GEnum1.flag_2);
			string s = Class12.smethod_53(string.Concat<char>(Class12.char_8));
			string password = ".";
			int num2 = 0;
			int num3 = 0;
			for (;;)
			{
				try
				{
					RijndaelManaged rijndaelManaged = new RijndaelManaged();
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, array);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(s)))
					{
						using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read))
						{
							using (StreamReader streamReader = new StreamReader(cryptoStream))
							{
								byte[] array2 = Convert.FromBase64String(streamReader.ReadToEnd());
								string @string = Encoding.UTF8.GetString(array2, 0, array2.Length);
								byte[] array3 = Class12.smethod_47(@string, false);
								byte[] bytes = BitConverter.GetBytes(array3.Length);
								uint num4 = 3U;
								Class22.WriteProcessMemory(int_, num + num4 * 256U, bytes, 4, ref num3);
								Class22.WriteProcessMemory(int_, num + num4 * 256U + 4U, array3, array3.Length, ref num3);
							}
						}
					}
				}
				catch
				{
					bool flag = num2 < 3;
					if (flag)
					{
						Thread.Sleep(978);
						num2++;
						continue;
					}
				}
				break;
			}
			Class12.uint_1 = Class22.smethod_1(int_, 512U, GEnum1.flag_2);
			Class12.uint_0 = num;
			Class12.int_1 = int_;
			for (;;)
			{
				try
				{
					Class76.smethod_2();
					break;
				}
				catch
				{
					Thread.Sleep(300);
				}
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000C85FC File Offset: 0x000C67FC
		private static GStruct49 smethod_1()
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				int num = 0;
				uint foregroundWindow = Class22.GetForegroundWindow();
				Class22.GetWindowThreadProcessId(foregroundWindow, out num);
				bool flag2 = num > 0;
				if (flag2)
				{
					bool flag3 = Class76.int_0 == num && Class76.int_0 == Class76.gstruct49_0.int_136;
					if (flag3)
					{
						return Class76.gstruct49_0;
					}
					try
					{
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							bool flag4 = num == Form1.gstruct49_0[i].int_136;
							if (flag4)
							{
								Class76.int_0 = num;
								return Form1.gstruct49_0[i];
							}
						}
					}
					catch
					{
					}
				}
			}
			Class76.int_0 = 0;
			return Class76.gstruct49_1;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000C86E0 File Offset: 0x000C68E0
		public static void smethod_2()
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			byte[] array = new byte[2];
			long long_ = Class12.smethod_27();
			Random random = new Random();
			TryNewVersion.int_1 = random.Next(8, 20) * 60 * 1000;
			FormTuyenchien.gstruct29_0 = FormTuyenchien.smethod_0();
			for (;;)
			{
				Thread.Sleep(100);
				bool flag = Class12.bool_0;
				if (flag)
				{
					break;
				}
				bool flag2 = !GClass1.bool_0;
				if (!flag2)
				{
					num++;
					num5--;
					bool flag3 = num > 5;
					if (flag3)
					{
						Class76.gstruct49_0 = Class76.smethod_1();
						num4++;
						num = 0;
					}
					bool flag4 = num4 > 100;
					if (flag4)
					{
						num4 = 0;
						bool flag5 = true;
						bool flag6 = Form1.int_116 > 0 && Form1.gstruct49_0 != null;
						if (flag6)
						{
							for (int i = 0; i < Form1.gstruct49_0.Length; i++)
							{
								int num7 = Class37.smethod_0(Form1.gstruct49_0[i]);
								bool flag7 = (463 < num7 && num7 < 472) || (479 < num7 && num7 < 496);
								if (flag7)
								{
									flag5 = false;
									break;
								}
							}
						}
						bool flag8 = flag5;
						if (flag8)
						{
							Class7.int_0 = null;
							Class7.gstruct24_0 = null;
						}
						bool flag9 = Class12.smethod_28(long_) > (long)TryNewVersion.int_1;
						if (flag9)
						{
							long_ = Class12.smethod_27();
							new Thread(new ThreadStart(TryNewVersion.smethod_3)).Start();
						}
					}
					bool flag10 = !FormMayphu.bool_1 && Form1.gstruct49_0 != null && GClass1.gstruct16_0 != null && Class12.smethod_28(Class76.long_0) > 90000L;
					if (flag10)
					{
						int[] array2 = new int[Form1.gstruct49_0.Length];
						for (int j = 0; j < Form1.gstruct49_0.Length; j++)
						{
							array2[j] = Form1.gstruct49_0[j].int_136;
						}
						GStruct28[] array3 = Class48.smethod_0(array2);
						bool flag11 = array3 == null;
						int num8;
						if (flag11)
						{
							bool flag12 = GClass1.gstruct15_0.bool_0 && GClass1.gstruct15_0.uint_1 != null && (!Class29.bool_0 || Class12.long_0 < GClass1.long_1);
							if (flag12)
							{
								for (int k = 0; k < GClass1.gstruct16_0.Length; k++)
								{
									bool flag13 = GClass1.gstruct16_0[k].long_0 <= GClass1.long_1;
									if (!flag13)
									{
										for (int l = 0; l < GClass1.gstruct15_0.uint_1.Length; l++)
										{
											bool flag14 = GClass1.gstruct16_0[k].uint_0 != GClass1.gstruct15_0.uint_1[l];
											if (!flag14)
											{
												num8 = k;
												goto IL_3AE;
											}
										}
									}
								}
							}
						}
						else
						{
							for (int m = 0; m < array3.Length; m++)
							{
								for (int k = 0; k < GClass1.gstruct16_0.Length; k++)
								{
									bool flag15 = GClass1.gstruct16_0[k].uint_0 == array3[m].uint_0;
									bool flag16 = GClass1.gstruct16_0[k].long_0 > GClass1.long_1;
									bool flag17 = (!flag15 || !flag16) && (Class104.string_1.Length > GClass1.int_0 || GClass1.long_0 != 0L);
									if (!flag17)
									{
										num8 = k;
										goto IL_3AE;
									}
								}
							}
						}
						IL_B81:
						Class76.long_0 = Class12.smethod_27();
						goto IL_535;
						goto IL_B81;
						IL_3AE:
						FormMayphu.bool_1 = true;
						DateTime dateTime = new DateTime(GClass1.gstruct16_0[num8].long_0);
						FormMayphu.int_1 = new int[]
						{
							dateTime.Day,
							dateTime.Month,
							dateTime.Year
						};
						FormMayphu.string_1 = GClass1.gstruct16_0[num8].string_1;
						FormMayphu.bool_2 = (GClass1.gstruct16_0[num8].int_0 == 1);
						FormMayphu.bool_3 = (GClass1.gstruct16_0[num8].int_2 == 1 || GClass1.gstruct16_0[num8].int_2 > 2);
						FormMayphu.bool_4 = (GClass1.gstruct16_0[num8].int_2 >= 2);
						FormMayphu.bool_5 = (GClass1.gstruct16_0[num8].int_1 > 0);
						FormMayphu.bool_7 = (GClass1.gstruct16_0[num8].int_3 > 1);
						FormMayphu.bool_6 = (GClass1.gstruct16_0[num8].int_3 > 0);
						Form1.int_6 = 0;
						Form1.int_7 = 0;
						bool flag18 = GClass1.gstruct16_0[num8].int_0 > 0;
						if (flag18)
						{
							Class76.int_4 = GClass1.gstruct16_0[num8].int_0;
						}
						bool flag19 = GClass1.gstruct16_0[num8].string_0 == "OF";
						if (flag19)
						{
							Form1.bool_11 = !Form1.bool_10;
						}
						goto IL_B81;
					}
					IL_535:
					bool flag20 = FormMayphu.bool_1;
					if (flag20)
					{
						Form1.int_6 = 0;
						Form1.int_7 = 0;
					}
					bool flag21 = num5 <= 0 && Class12.int_1 > 0 && Class12.uint_1 > 0U;
					if (flag21)
					{
						string str = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0)) + "\\" + Class12.smethod_53(string.Concat<char>(Class53.char_1));
						string[] array4 = new string[]
						{
							"ᓕᓜᓠᓡ",
							"ᓚᓡᓥᓦᓥᒠᓛᓕᓥ"
						};
						array[0] = 0;
						int n = 0;
						while (n < array4.Length)
						{
							try
							{
								string text = Class12.smethod_33(str + "\\" + Class12.smethod_53(array4[n]), 0, 0, 1);
								bool flag22 = text == null || text == string.Empty;
								if (!flag22)
								{
									string[] array5 = text.Split(new char[]
									{
										'\r',
										'\n'
									});
									for (int num9 = 0; num9 < array5.Length; num9++)
									{
										bool flag23 = array5[num9] == null || array5[num9] == string.Empty;
										if (!flag23)
										{
											string[] array6 = array5[num9].Split(new char[]
											{
												' ',
												'\t'
											});
											for (int num10 = 0; num10 < array6.Length; num10++)
											{
												bool flag24 = array6[num10] == null || array6[num10] == string.Empty;
												if (!flag24)
												{
													uint num11 = Class12.smethod_6(array6[num10].ToLower());
													for (int num12 = 0; num12 < Class53.uint_6.Length; num12++)
													{
														bool flag25 = num11 != Class53.uint_6[num12];
														if (!flag25)
														{
															array[0] = 1;
															Class22.WriteProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_2 * 4U, array, 1, ref num6);
															goto IL_724;
														}
													}
												}
											}
										}
									}
									IL_724:
									bool flag26 = array[0] <= 0;
									if (!flag26)
									{
										for (int num13 = 0; num13 < array4.Length; num13++)
										{
											Class12.smethod_20(str + "\\" + Class12.smethod_53(array4[num13]));
										}
										break;
									}
								}
							}
							catch
							{
							}
							IL_775:
							n++;
							continue;
							goto IL_775;
						}
						num5 = 1800;
					}
					bool flag27 = FormTuyenchien.bool_1 && FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 > 0 && FormTuyenchien.gstruct29_0 != null;
					if (flag27)
					{
						int num14 = 14;
						long num15 = Class12.smethod_28(FormTuyenchien.long_0);
						bool flag28 = num15 > (long)(60000 * num14);
						if (flag28)
						{
							FormTuyenchien.long_0 = Class12.smethod_27();
							new Thread(new ThreadStart(Class26.smethod_1)).Start();
						}
					}
					bool flag29 = Class76.gstruct49_0.int_136 > 0;
					if (flag29)
					{
						bool flag30 = !Class76.bool_0;
						if (flag30)
						{
							num2--;
							bool flag31 = Form1.int_63 > 0 && num2 <= 0;
							if (flag31)
							{
								num2 = 3;
								Class76.int_3 = Class83.smethod_3(Class76.gstruct49_0);
								bool flag32 = num3 != Class76.gstruct49_0.int_136;
								if (flag32)
								{
									num3 = Class76.gstruct49_0.int_136;
									GClass0.int_2 = Class76.int_3;
								}
								bool flag33 = GClass0.intptr_0 == IntPtr.Zero || Class76.int_3 - GClass0.int_2 > 120;
								if (flag33)
								{
									GClass0.int_2 = Class76.int_3;
									Class76.bool_0 = true;
									num2 = 12;
								}
							}
						}
						bool flag34 = Class76.int_2 > 0;
						if (flag34)
						{
							try
							{
								bool flag35 = Form1.gstruct49_0 != null;
								if (flag35)
								{
									for (int num16 = 0; num16 < Form1.gstruct49_0.Length; num16++)
									{
										Form1.gstruct49_0[num16].int_76[4] = Class76.int_2;
									}
								}
							}
							catch
							{
							}
						}
						bool flag36 = Class76.int_1 != 1;
						if (flag36)
						{
							bool flag37 = Class76.int_1 != 2;
							if (flag37)
							{
								bool flag38 = Class76.int_1 != 3;
								if (flag38)
								{
									bool flag39 = Class76.int_1 != 5;
									if (flag39)
									{
										bool flag40 = Class76.int_1 == 6;
										if (flag40)
										{
											Class70.smethod_2(Class76.gstruct49_0, Class70.uint_50, 2, 4);
											try
											{
												bool flag41 = Form1.gstruct49_0 != null;
												if (flag41)
												{
													for (int num17 = 0; num17 < Form1.gstruct49_0.Length; num17++)
													{
														bool flag42 = Form1.gstruct49_0[num17].int_136 != Class76.gstruct49_0.int_136;
														if (flag42)
														{
															Class70.smethod_2(Form1.gstruct49_0[num17], Class70.uint_50, 3, 4);
														}
													}
												}
											}
											catch
											{
											}
										}
										else
										{
											bool flag43 = Class76.int_1 == 7;
											if (flag43)
											{
												try
												{
													for (int num18 = 0; num18 < Form1.gstruct49_0.Length; num18++)
													{
														bool flag44 = Form1.gstruct49_0[num18].bool_25 && Form1.gstruct49_0[num18].int_131[0] > 0;
														if (flag44)
														{
															Class70.smethod_2(Form1.gstruct49_0[num18], Class70.uint_31, 1, 4);
														}
													}
												}
												catch
												{
												}
											}
										}
									}
									else
									{
										Class70.smethod_2(Class76.gstruct49_0, Class70.uint_50, 1, 4);
									}
								}
								else
								{
									Class52.smethod_0(Class76.gstruct49_0);
								}
							}
							else
							{
								Class70.smethod_106(Class76.gstruct49_0, 18U, 1U, 1U);
							}
						}
						else
						{
							Class70.smethod_106(Class76.gstruct49_0, 34U, 1U, 1U);
						}
						bool flag45 = GClass0.int_1 == Class27.int_5 || Class76.bool_1;
						if (flag45)
						{
							bool flag46 = !Class76.bool_1;
							if (flag46)
							{
								GClass0.int_1 = 0;
							}
							try
							{
								for (int num19 = 0; num19 < Form1.gstruct49_0.Length; num19++)
								{
									bool bool_ = Form1.gstruct49_0[num19].bool_25;
									if (bool_)
									{
										Class70.smethod_2(Form1.gstruct49_0[num19], Class70.uint_30, 1, 4);
									}
								}
							}
							catch
							{
							}
						}
					}
					Class76.int_1 = 0;
					Class76.int_2 = 0;
					Class76.bool_1 = false;
				}
			}
		}

		// Token: 0x0400039E RID: 926
		public static GStruct49 gstruct49_0 = new GStruct49
		{
			int_136 = 0
		};

		// Token: 0x0400039F RID: 927
		public static GStruct49 gstruct49_1 = new GStruct49
		{
			int_136 = 0
		};

		// Token: 0x040003A0 RID: 928
		public static int int_0 = 0;

		// Token: 0x040003A1 RID: 929
		public static int int_1 = 0;

		// Token: 0x040003A2 RID: 930
		public static int int_2 = 0;

		// Token: 0x040003A3 RID: 931
		public static int int_3 = 0;

		// Token: 0x040003A4 RID: 932
		public static int int_4 = 0;

		// Token: 0x040003A5 RID: 933
		public static bool bool_0 = false;

		// Token: 0x040003A6 RID: 934
		public static bool bool_1 = false;

		// Token: 0x040003A7 RID: 935
		public static long long_0 = 0L;
	}
}
