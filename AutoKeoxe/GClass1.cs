using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000091 RID: 145
	public class GClass1
	{
		// Token: 0x06000BD3 RID: 3027 RVA: 0x001953F4 File Offset: 0x001935F4
		public static void smethod_0()
		{
			byte[] array = null;
			int num = 0;
			byte[] array2 = new byte[4];
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			Class8[] array3 = null;
			Class69[] array4 = null;
			Class69[] array5 = null;
			Class69[] array6 = null;
			Class69[] array7 = null;
			Class69[] array8 = null;
			Class69[] array9 = null;
			long num8 = 0L;
			long num9 = 0L;
			int num10 = 300;
			for (;;)
			{
				GClass1.GStruct15 gstruct = default(GClass1.GStruct15);
				GClass1.iplistipconnect = null;
				gstruct.string_0 = null;
				gstruct.string_1 = null;
				gstruct.bool_0 = false;
				gstruct.long_1 = string.Empty;
				gstruct.long_0 = 0L;
				gstruct.int_0 = 0;
				gstruct.uint_0 = 0U;
				GClass1.gstruct15_0 = gstruct;
				GClass1.int_3 = 0;
				int num11 = 0;
				int num12 = 0;
				int num13 = 0;
				GClass1.long_2 = 0L;
				GClass1.int_1 = 0;
				GClass1.ProcessIDCurren = Class22.smethod_56();
				for (;;)
				{
					bool flag = num10 > 1300;
					if (flag)
					{
						num10 = 1300;
					}
					Thread.Sleep(1300);
					bool flag2 = Class12.bool_0;
					if (flag2)
					{
						goto Block_2;
					}
					bool flag3 = GClass1.int_1 == 2;
					if (flag3)
					{
						break;
					}
					num2--;
					bool flag4 = num2 <= 0;
					if (flag4)
					{
						GClass1.bool_1 = (GClass1.bool_1 || GClass1.smethod_2());
						num2 = 1800;
					}
					bool flag5 = !Form1.bool_2 || Class12.uint_0 == 0U;
					if (!flag5)
					{
						bool flag6 = GClass1.bool_1;
						if (flag6)
						{
							Form1.gstruct49_0 = null;
						}
						else
						{
							int num14 = Class12.int_1;
							uint uint_ = Class12.uint_0;
							bool flag7 = array3 == null || array == null;
							if (flag7)
							{
								array = new byte[8];
								array3 = new Class8[Class104.string_0.Length];
								int num15 = Class104.string_1.Length;
								array4 = new Class69[num15];
								array5 = new Class69[num15];
								array6 = new Class69[num15];
								array7 = new Class69[num15];
								array8 = new Class69[num15];
								array9 = new Class69[num15];
								Class29.smethod_0();
								GClass1.long_3 = 0L;
								string text = GClass1.smethod_1(num14, uint_ + 256U, false);
								text = Class12.smethod_53(GClass1.smethod_1(num14, uint_ + 768U, false));
								bool flag8 = text != string.Empty;
								if (flag8)
								{
									array = Encoding.ASCII.GetBytes(text);
								}
								uint num16 = uint_ + 1024U + 8U;
								Class22.ReadProcessMemory(num14, num16, array2, 4, ref num);
								int num17 = BitConverter.ToInt32(array2, 0);
								bool flag9 = num17 > 0;
								if (flag9)
								{
									text = GClass1.smethod_1(num14, num16, true);
									Class12.long_0 = Class12.smethod_36(text);
								}
							}
							bool flag10 = num4 == 0;
							if (flag10)
							{
								num4 = 1;
								bool flag11 = num13 == 0;
								if (flag11)
								{
									Class12.string_16 = new string[]
									{
										"Đang kiểm tra phiên bản, xin chờ chút xíu..."
									};
								}
								else
								{
									Class12.string_16 = new string[]
									{
										"Đang kiểm tra phiên bản, xin chờ chút xíu..."
									};
								}
								for (int i = 0; i < array4.Length; i++)
								{
									array4[i] = new Class69
									{
										object_0 = "version.txt",
										string_1 = Class104.string_1[i],
										bool_0 = false,
										int_0 = i + 1
									};
									new Thread(new ThreadStart(array4[i].method_6)).Start();
								}
								Thread.Sleep(200);
								num10 += 200;
							}
							bool flag12 = num4 == 1 || num4 == -1;
							if (flag12)
							{
								bool flag13 = GClass1.string_1 == null || GClass1.string_1 == string.Empty;
								if (flag13)
								{
									bool flag14 = num4 != -1;
									if (flag14)
									{
										int num18 = array4.Length;
										for (int j = 0; j < array4.Length; j++)
										{
											bool flag15 = array4[j] == null || array4[j].bool_0;
											if (flag15)
											{
												num18--;
											}
										}
										bool flag16 = num18 <= 0;
										if (flag16)
										{
											num4 = -1;
										}
									}
									else
									{
										bool flag17 = num13 >= 3;
										if (flag17)
										{
											bool flag18 = !GClass1.bool_0;
											if (flag18)
											{
												goto Block_26;
											}
											num4 = 2;
										}
										else
										{
											num13++;
											num4 = 0;
										}
									}
									continue;
								}
								num4 = 2;
							}
							int num19 = num4;
							int num20 = num19;
							if (num20 != 2)
							{
								if (num20 == 3)
								{
									bool flag19 = Class12.smethod_28(num8) > 43200000L;
									if (flag19)
									{
										num4 = 0;
										num8 = 0L;
									}
								}
							}
							else
							{
								Class12.smethod_29(ref Class12.string_16, Class12.smethod_0(Class12.char_21));
								GClass1.int_1 = 1;
								GClass1.bool_0 = true;
								num4 = 3;
								num13 = 0;
								num8 = Class12.smethod_27();
							}
							num3--;
							bool flag20 = num3 <= 0 && (GClass1.bool_0 || num4 == 3);
							if (flag20)
							{
								for (int k = 0; k < array3.Length; k++)
								{
									array3[k] = new Class8
									{
										string_0 = Class104.string_0[k]
									};
									new Thread(new ThreadStart(array3[k].method_0)).Start();
									Thread.Sleep(150);
								}
								num3 = 1800;
								bool flag21 = GClass1.gstruct15_0.bool_0;
								if (flag21)
								{
									GClass1.gstruct15_0.bool_0 = (GClass1.gstruct15_0.long_1 != string.Empty && GClass1.gstruct15_0.uint_0 != 0U && GClass1.gstruct15_0.long_0 > GClass1.long_1 && GClass1.long_1 > 636758336219996160L);
									GClass1.int_1 = 1;
								}
							}
							bool flag22 = GClass1.long_1 <= 0L;
							if (flag22)
							{
								bool flag23 = num3 > 100;
								if (flag23)
								{
									num3 = 100;
								}
							}
							else
							{
								bool flag24 = num6 == 0 && Class29.long_0 > 0L && Class29.bool_0;
								if (flag24)
								{
									num6 = 1;
									string object_ = Class29.string_1 + Class12.smethod_53(Class12.string_5) + Class29.long_0.ToString() + Class12.smethod_53(string.Concat<char>(Class12.char_11));
									for (int l = 0; l < array5.Length; l++)
									{
										array5[l] = new Class69
										{
											object_0 = object_,
											string_1 = Class104.string_1[l],
											bool_0 = false,
											int_0 = l + 1
										};
										new Thread(new ThreadStart(array5[l].method_3)).Start();
									}
									Thread.Sleep(300);
									num10 += 500;
								}
								bool flag25 = GClass1.int_3 == 0 && GClass1.gstruct15_0.long_1 == string.Empty;
								if (flag25)
								{
									GClass1.int_3 = 1;
									string object_2 = "license/" + Form1.string_10 + ".txt";
									bool flag26 = Form1.string_10.IndexOf(Form1.string_9) != 0;
									if (flag26)
									{
										for (int m = 0; m < array6.Length; m++)
										{
											array6[m] = new Class69
											{
												object_0 = object_2,
												string_1 = Class104.string_1[m],
												bool_0 = false,
												int_0 = m + 1,
												byte_0 = array
											};
											new Thread(new ThreadStart(array6[m].method_5)).Start();
										}
									}
									Thread.Sleep(300);
									num10 += 200;
								}
								bool flag27 = GClass1.int_3 == 1;
								if (flag27)
								{
									bool flag28 = false;
									for (int n = 0; n < array6.Length; n++)
									{
										bool flag29 = array6[n] != null && !array6[n].bool_0;
										if (flag29)
										{
											flag28 = true;
											break;
										}
									}
									bool flag30 = !flag28 || GClass1.gstruct15_0.uint_0 > 0U;
									if (flag30)
									{
										GClass1.int_3 = 2;
										GClass1.int_1 = 1;
									}
								}
								bool flag31 = num11 == 0 && GClass1.long_2 <= 0L && GClass1.gstruct15_0.long_1 != string.Empty && GClass1.gstruct15_0.bool_0;
								if (flag31)
								{
									num11 = 1;
									string object_3 = string.Concat(new string[]
									{
										"license/",
										Form1.string_10,
										"_",
										GClass1.gstruct15_0.long_1,
										".txt"
									});
									for (int num21 = 0; num21 < array7.Length; num21++)
									{
										array7[num21] = new Class69
										{
											object_0 = object_3,
											string_1 = Class104.string_1[num21],
											bool_0 = false,
											int_0 = num21 + 1
										};
										new Thread(new ThreadStart(array7[num21].method_4)).Start();
									}
									Thread.Sleep(500);
								}
								bool flag32 = num7 >= 10;
								if (flag32)
								{
									bool flag33 = num12 == 0 && GClass1.gstruct16_0 == null;
									if (flag33)
									{
										num12 = 1;
										for (int num22 = 0; num22 < array9.Length; num22++)
										{
											array9[num22] = new Class69
											{
												string_1 = Class104.string_1[num22],
												object_0 = "mayphu.txt",
												bool_0 = false,
												int_0 = num22 + 1
											};
											new Thread(new ThreadStart(array9[num22].method_0)).Start();
											Thread.Sleep(500);
										}
										num9 = Class12.smethod_27();
									}
									else
									{
										bool flag34 = num12 > 0 && Class12.smethod_28(num9) > 21600000L;
										if (flag34)
										{
											num12 = 0;
											GClass1.gstruct16_0 = null;
										}
									}
									bool flag35 = num7 >= 20;
									if (flag35)
									{
										bool flag36 = num5 <= 0;
										if (flag36)
										{
											num5 = 600;
											for (int num23 = 0; num23 < array8.Length; num23++)
											{
												array8[num23] = new Class69
												{
													string_1 = Class104.string_1[num23],
													object_0 = "quangcao.txt",
													bool_0 = false,
													int_0 = num23 + 1
												};
												new Thread(new ThreadStart(array8[num23].method_2)).Start();
												Thread.Sleep(300);
											}
										}
										num5--;
									}
									else
									{
										num7++;
									}
								}
								else
								{
									num7++;
								}
							}
						}
					}
				}
			}
			Block_2:
			return;
			Block_26:
			Class12.string_16 = new string[]
			{
				"Không thể kiểm tra phiên bản."
			};
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00195E6C File Offset: 0x0019406C
		private static string smethod_1(int int_4, uint uint_0, bool bool_2 = false)
		{
			int num = 0;
			byte[] array = new byte[4];
			string result = string.Empty;
			Class22.ReadProcessMemory(int_4, uint_0, array, 4, ref num);
			int num2 = BitConverter.ToInt32(array, 0);
			bool flag = num2 > 0;
			if (flag)
			{
				byte[] array2 = new byte[num2];
				Class22.ReadProcessMemory(int_4, uint_0 + 4U, array2, num2, ref num);
				result = ((!bool_2) ? Class10.smethod_4(array2) : Class10.smethod_3(array2));
				bool flag2 = array2[0] > 0;
				if (flag2)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						array2[i] = 0;
					}
					Class22.WriteProcessMemory(int_4, uint_0, array2, num2, ref num);
				}
			}
			return result;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00195F18 File Offset: 0x00194118
		private static bool smethod_2()
		{
			bool flag = false;
			bool result;
			try
			{
				string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
				string path = environmentVariable + "\\" + Class12.smethod_71(Class12.smethod_53(Class12.string_14));
				string string_ = Class12.smethod_0(Class12.char_26);
				string text = Class12.smethod_16(string_);
				string[] files = Directory.GetFiles(path, Class12.smethod_0(Class12.char_24));
				bool flag2 = files != null;
				if (flag2)
				{
					files = Directory.GetFiles(path, Class12.smethod_0(Class12.char_25));
				}
				bool flag3 = files != null;
				if (flag3)
				{
					foreach (string string_2 in files)
					{
						string text2 = Class12.smethod_33(string_2, 0, 0, 1);
						bool flag4 = text2 != null && text2 != string.Empty;
						if (flag4)
						{
							for (int j = 0; j < Class12.string_15.Length; j++)
							{
								string object_ = Class12.smethod_71(Class12.smethod_53(Class12.string_15[j]));
								flag = (flag || 0 <= Class12.smethod_1(text2, object_));
							}
							bool flag5 = flag;
							if (flag5)
							{
								Class62.smethod_10(Class53.string_3, text, Class12.smethod_27(), "", 0);
								Class12.smethod_20(string_2);
								Class12.smethod_34(string_2, string.Empty, 1);
							}
						}
					}
				}
				bool flag6 = !flag;
				if (flag6)
				{
					long num = Class62.smethod_5(text, 0, "0");
					long num2 = Class12.smethod_28(num);
					bool flag7 = num2 < 295000L;
					if (flag7)
					{
						flag = true;
					}
				}
				bool flag8 = !flag;
				if (flag8)
				{
					Class62.smethod_10(Class53.string_3, text, 0, "", 0);
				}
				Class62.smethod_10(Class53.string_3, string_, DateTime.Now.AddYears(15).Ticks, "", 0);
				result = flag;
			}
			catch
			{
				result = flag;
			}
			return result;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00196130 File Offset: 0x00194330
		public static string[] smethod_3()
		{
			string text = Class12.smethod_0(Class12.char_14);
			bool flag = !Class29.bool_0;
			string[] result;
			if (flag)
			{
				result = new string[]
				{
					text,
					Class12.smethod_0(Class12.char_15)
				};
			}
			else
			{
				DateTime dateTime = new DateTime(Class12.long_0);
				string text2 = Class12.smethod_0(Class12.char_16);
				bool flag2 = GClass1.long_1 > 0L;
				if (flag2)
				{
					text2 = ((int)new TimeSpan(Class12.long_0 - GClass1.long_1).TotalDays).ToString();
				}
				string str = Class12.smethod_53(Class12.string_7);
				string str2 = null;
				for (int i = 0; i < Class29.string_0.Length; i++)
				{
					bool flag3 = i > 0;
					if (flag3)
					{
						str2 += str;
					}
					str2 += Class29.string_0[i];
				}
				uint num = Class12.smethod_6(str2 + str + Class29.long_0.ToString());
				bool flag4 = (ulong)num != (ulong)GClass1.long_3 || Class12.long_0 <= 0L;
				if (flag4)
				{
					text = Class12.smethod_0(Class12.char_17);
				}
				string text3 = string.Concat(new string[]
				{
					Class12.smethod_0(Class12.char_18),
					dateTime.Day.ToString(),
					Class12.smethod_53(Class12.string_4),
					dateTime.Month.ToString(),
					Class12.smethod_53(Class12.string_4),
					dateTime.Year.ToString(),
					" ",
					Class12.smethod_53(Class12.string_8),
					text2,
					Class12.smethod_0(Class12.char_19),
					Class12.smethod_53(Class12.string_9)
				});
				result = new string[]
				{
					text,
					text3
				};
			}
			return result;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0019630C File Offset: 0x0019450C
		public static string smethod_4()
		{
			try
			{
				bool flag = GClass1.gstruct15_0.long_0 == 0L;
				if (flag)
				{
					return Class12.smethod_0(Class12.char_15);
				}
				DateTime d = new DateTime(GClass1.long_1);
				DateTime d2 = new DateTime(GClass1.gstruct15_0.long_0);
				int num = (int)(d2 - d).TotalDays;
				return string.Concat(new string[]
				{
					Class12.smethod_53(Class12.string_11),
					Class10.smethod_1(GClass1.gstruct15_0.string_1, 1, false),
					Class12.smethod_53(Class12.string_12),
					" ",
					num.ToString(),
					Class12.smethod_0(Class12.char_19),
					Class53.string_7,
					Class12.smethod_0(Class12.char_18),
					d2.Day.ToString(),
					Class12.smethod_53(Class12.string_4),
					d2.Month.ToString(),
					Class12.smethod_53(Class12.string_4),
					d2.Year.ToString(),
					" ",
					d2.ToShortTimeString(),
					Class53.string_7,
					Class12.smethod_0(Class12.char_20),
					Form1.string_10
				});
			}
			catch
			{
			}
			return string.Concat('\u0001');
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0019649C File Offset: 0x0019469C
		public static int smethod_5(GStruct49 gstruct49_0)
		{
			try
			{
				return GClass1.smethod_6(gstruct49_0);
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x001964D0 File Offset: 0x001946D0
		public static int smethod_6(GStruct49 gstruct49_0)
		{
			int num = 0;
			bool flag = Class29.bool_0;
			string[] array = Class29.string_0;
			int num2 = 0;
			byte[] array2 = new byte[4];
			new byte[8];
			try
			{
				string[] array3 = null;
				uint num3 = 4U;
				Class22.ReadProcessMemory(Class12.int_1, Class12.uint_0 + num3 * 256U, array2, array2.Length, ref num2);
				int num4 = BitConverter.ToInt32(array2, 0);
				Class22.ReadProcessMemory(Class12.int_1, Class12.uint_0 + num3 * 256U + 4U, array2, array2.Length, ref num2);
				BitConverter.ToInt32(array2, 0);
				Class22.ReadProcessMemory(Class12.int_1, Class12.uint_0 + num3 * 256U + 32U, array2, array2.Length, ref num2);
				int num5 = BitConverter.ToInt32(array2, 0);
				bool flag2 = num5 > 0 && num5 < 999;
				if (flag2)
				{
					byte[] array4 = new byte[num5];
					Class22.ReadProcessMemory(Class12.int_1, Class12.uint_0 + num3 * 256U + 36U, array4, array4.Length, ref num2);
					string text = Class12.smethod_15(Class10.smethod_3(array4));
					array3 = text.Split(new char[]
					{
						'\u0001'
					});
				}
				bool flag3 = array != null && array.Length >= 6 && array3 != null && array3.Length >= array.Length;
				if (flag3)
				{
					string text2 = null;
					for (int i = 0; i < array.Length; i++)
					{
						flag = (flag && array[i] == array3[i]);
						text2 = text2 + array3[i] + Class12.smethod_53(Class12.string_7);
					}
					text2 += Class29.long_0.ToString();
					long num6 = Class12.smethod_36(array3[array3.Length - 1]);
					uint num7 = Class12.smethod_6(text2);
					bool flag4 = Class29.bool_0 && (ulong)num7 == (ulong)GClass1.long_3 && GClass1.long_1 > 637134962330000000L && Class12.long_0 > GClass1.long_1 && Class12.long_0 == num6 && num4 > 14;
					if (flag4)
					{
						return 1;
					}
					num = -1;
				}
			}
			catch
			{
			}
			bool flag5 = !GClass1.gstruct15_0.bool_0 || GClass1.gstruct15_0.long_1 == string.Empty || GClass1.gstruct15_0.uint_0 == 0U || GClass1.gstruct15_0.string_1 == null || GClass1.gstruct15_0.string_1 == string.Empty || GClass1.gstruct15_0.string_0 == null || GClass1.gstruct15_0.string_0 == string.Empty;
			int result;
			if (flag5)
			{
				result = num;
			}
			else
			{
				int length = GClass1.gstruct15_0.string_0.Length;
				bool flag6 = GClass1.long_2 > 0L && length > 0;
				if (flag6)
				{
					string text3 = Class83.smethod_16(gstruct49_0);
					string text4 = Class26.smethod_10(gstruct49_0);
					uint num8 = Class36.smethod_13(gstruct49_0);
					bool flag7 = GClass1.checktype == "bang";
					if (flag7)
					{
						bool flag8 = GClass1.long_2 <= 0L || length <= 0;
						if (flag8)
						{
							result = -1;
						}
						else
						{
							bool flag9 = GClass1.gstruct15_0.string_1 != text4 && GClass1.gstruct15_0.string_0 != text3;
							if (flag9)
							{
								result = -1;
							}
							else
							{
								bool flag10 = length < text3.Length;
								if (flag10)
								{
									text3 = text3.Substring(0, length);
								}
								string text5 = text3;
								bool flag11 = GClass1.gstruct15_0.string_2 != null && GClass1.gstruct15_0.string_2 != string.Empty;
								if (flag11)
								{
									text5 = text5 + "\u0001" + Class12.smethod_15(GClass1.gstruct15_0.string_2);
								}
								uint num9 = 2U * Class12.smethod_6(string.Concat(new string[]
								{
									text4,
									text3,
									Class12.smethod_15(GClass1.gstruct15_0.string_2),
									GClass1.gstruct15_0.long_0.ToString(),
									Class12.smethod_36(GClass1.gstruct15_0.long_1).ToString()
								})) / 2U;
								int num10 = (int)Convert.ToByte((ulong)num9 == (ulong)GClass1.long_2 && text3 == GClass1.gstruct15_0.string_0);
								bool flag12 = text5 != null;
								if (flag12)
								{
									length = text5.Length;
									text5 = string.Empty;
									for (int j = 0; j < length; j++)
									{
										text5 += "\0";
									}
								}
								result = num10 * 2;
							}
						}
					}
					else
					{
						bool flag13 = GClass1.checktype == "server";
						if (flag13)
						{
							bool flag14 = GClass1.long_2 <= 0L || length <= 0;
							if (flag14)
							{
								result = -1;
							}
							else
							{
								bool flag15 = GClass1.gstruct15_0.string_2 == null && GClass1.gstruct15_0.string_2 == string.Empty && text3 != Class12.smethod_15(GClass1.gstruct15_0.string_2);
								if (flag15)
								{
									result = -1;
								}
								else
								{
									bool flag16 = length < text3.Length;
									if (flag16)
									{
										text3 = text3.Substring(0, length);
									}
									string text6 = text3;
									bool flag17 = GClass1.gstruct15_0.string_2 != null && GClass1.gstruct15_0.string_2 != string.Empty;
									if (flag17)
									{
										text6 = text6 + "\u0001" + Class12.smethod_15(GClass1.gstruct15_0.string_2);
									}
									uint value = 2U * Class12.smethod_6(string.Concat(new string[]
									{
										GClass1.gstruct15_0.string_1,
										text3,
										Class12.smethod_15(GClass1.gstruct15_0.string_2),
										GClass1.gstruct15_0.long_0.ToString(),
										Class12.smethod_36(GClass1.gstruct15_0.long_1).ToString()
									}));
									Console.WriteLine(value);
									uint num11 = 2U * Class12.smethod_6(string.Concat(new string[]
									{
										GClass1.gstruct15_0.string_1,
										text3,
										Class12.smethod_15(GClass1.gstruct15_0.string_2),
										GClass1.gstruct15_0.long_0.ToString(),
										Class12.smethod_36(GClass1.gstruct15_0.long_1).ToString()
									})) / 2U;
									int num10 = (int)Convert.ToByte((ulong)num11 == (ulong)GClass1.long_2 && text3 == GClass1.gstruct15_0.string_0);
									bool flag18 = text6 != null;
									if (flag18)
									{
										length = text6.Length;
										text6 = string.Empty;
										for (int k = 0; k < length; k++)
										{
											text6 += "\0";
										}
									}
									result = num10 * 2;
								}
							}
						}
						else
						{
							result = -1;
						}
					}
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x04000DA6 RID: 3494
		public static string TenWeb = null;

		// Token: 0x04000DA7 RID: 3495
		public static string LienMay = null;

		// Token: 0x04000DA8 RID: 3496
		public static string checktype = null;

		// Token: 0x04000DA9 RID: 3497
		public static long long_0 = -1L;

		// Token: 0x04000DAA RID: 3498
		public static int int_0 = 0;

		// Token: 0x04000DAB RID: 3499
		public static GClass1.GStruct16[] gstruct16_0 = null;

		// Token: 0x04000DAC RID: 3500
		public static int int_1 = 0;

		// Token: 0x04000DAD RID: 3501
		public static bool bool_0 = false;

		// Token: 0x04000DAE RID: 3502
		public static long long_1 = 0L;

		// Token: 0x04000DAF RID: 3503
		public static bool bool_1 = false;

		// Token: 0x04000DB0 RID: 3504
		public static string string_0 = null;

		// Token: 0x04000DB1 RID: 3505
		public static string string_1 = null;

		// Token: 0x04000DB2 RID: 3506
		public static string string_2 = null;

		// Token: 0x04000DB3 RID: 3507
		public static long long_2 = 0L;

		// Token: 0x04000DB4 RID: 3508
		public static long long_3 = 0L;

		// Token: 0x04000DB5 RID: 3509
		public static int int_2 = 0;

		// Token: 0x04000DB6 RID: 3510
		public static GClass1.GStruct15 gstruct15_0 = default(GClass1.GStruct15);

		// Token: 0x04000DB7 RID: 3511
		public static int int_3 = 0;

		// Token: 0x04000DB8 RID: 3512
		public static GStruct28[] iplistipconnect = null;

		// Token: 0x04000DB9 RID: 3513
		public static int ProcessIDCurren = -1;

		// Token: 0x04000DBA RID: 3514
		public static int SetData_1 = 0;

		// Token: 0x04000DBB RID: 3515
		public static int GameLimit = 24;

		// Token: 0x04000DBC RID: 3516
		public static string datasign = string.Empty;

		// Token: 0x04000DBD RID: 3517
		public static bool testsend = false;

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x06000C4A RID: 3146
		[SuppressUnmanagedCodeSecurity]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void SendProtocol(uint This, object ScriptFileName, object szFunName, object cFormat, uint args);

		// Token: 0x02000103 RID: 259
		public struct GStruct15
		{
			// Token: 0x04001275 RID: 4725
			public string string_0;

			// Token: 0x04001276 RID: 4726
			public string string_1;

			// Token: 0x04001277 RID: 4727
			public uint uint_0;

			// Token: 0x04001278 RID: 4728
			public long long_0;

			// Token: 0x04001279 RID: 4729
			public string long_1;

			// Token: 0x0400127A RID: 4730
			public int int_0;

			// Token: 0x0400127B RID: 4731
			public bool bool_0;

			// Token: 0x0400127C RID: 4732
			public uint[] uint_1;

			// Token: 0x0400127D RID: 4733
			public string string_2;

			// Token: 0x0400127E RID: 4734
			public string[] IPList;

			// Token: 0x0400127F RID: 4735
			public string IPAuth;
		}

		// Token: 0x02000104 RID: 260
		public struct GStruct16
		{
			// Token: 0x04001280 RID: 4736
			public long long_0;

			// Token: 0x04001281 RID: 4737
			public int int_0;

			// Token: 0x04001282 RID: 4738
			public int int_1;

			// Token: 0x04001283 RID: 4739
			public int int_2;

			// Token: 0x04001284 RID: 4740
			public string string_0;

			// Token: 0x04001285 RID: 4741
			public int int_3;

			// Token: 0x04001286 RID: 4742
			public string string_1;

			// Token: 0x04001287 RID: 4743
			public uint uint_0;
		}
	}
}
