using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000060 RID: 96
	internal class Class99
	{
		// Token: 0x0600057A RID: 1402 RVA: 0x000EFF1C File Offset: 0x000EE11C
		public static void smethod_0(GStruct49 gstruct49_0, ref string[] string_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0);
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
			int num3 = BitConverter.ToInt32(array, 0);
			int num4 = 0;
			string[] array3 = null;
			int num5 = 1;
			while (num5 < 256 && num3 > num4)
			{
				uint num6 = num2 + (uint)(num5 * (int)Class53.gstruct51_15.uint_0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, 4, ref num);
				bool flag = array[0] == 0;
				if (!flag)
				{
					num4++;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_52.uint_0, array, 4, ref num);
					uint num7 = BitConverter.ToUInt32(array, 0);
					bool flag2 = num7 != 3U;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num);
						string text = Class10.smethod_3(array2);
						bool flag3 = string_0 != null;
						if (flag3)
						{
							bool flag4 = false;
							for (int i = 0; i < string_0.Length; i++)
							{
								bool flag5 = string_0[i] == text;
								if (flag5)
								{
									flag4 = true;
									break;
								}
							}
							bool flag6 = flag4;
							if (flag6)
							{
								goto IL_1E1;
							}
						}
						bool flag7 = array3 != null;
						if (flag7)
						{
							bool flag8 = false;
							for (int j = 0; j < array3.Length; j++)
							{
								bool flag9 = array3[j] == text;
								if (flag9)
								{
									flag8 = true;
									break;
								}
							}
							bool flag10 = flag8;
							if (flag10)
							{
								goto IL_1E1;
							}
							Array.Resize<string>(ref array3, array3.Length + 1);
						}
						else
						{
							array3 = new string[1];
						}
						array3[array3.Length - 1] = text;
					}
				}
				IL_1E1:
				num5++;
			}
			bool flag11 = array3 != null;
			if (flag11)
			{
				Array.Sort<string>(array3);
				int num8 = 0;
				bool flag12 = string_0 == null;
				if (flag12)
				{
					string_0 = new string[array3.Length];
				}
				else
				{
					num8 = string_0.Length;
					Array.Resize<string>(ref string_0, string_0.Length + array3.Length);
				}
				for (int k = 0; k < array3.Length; k++)
				{
					string_0[k + num8] = array3[k];
				}
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000F019C File Offset: 0x000EE39C
		public static void smethod_1(GStruct49 gstruct49_0, ref string[] string_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[60];
			uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_124.uint_0 + Class53.gstruct51_125.uint_0 + 4U;
			Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 4, ref num);
			int num2 = BitConverter.ToInt32(array, 0);
			bool flag = num2 <= 0;
			if (!flag)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_126.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				int num4 = 0;
				string[] array3 = null;
				uint num5 = 0U;
				while (num5 < 256U && num2 > num4)
				{
					uint num6 = num3 + num5 * Class53.gstruct51_127.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6, array, 4, ref num);
					int num7 = BitConverter.ToInt32(array, 0);
					bool flag2 = num7 <= 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_138.uint_0, array2, 1, ref num);
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_137.uint_0, array, 4, ref num);
						bool flag3 = array2[0] == 0 || BitConverter.ToInt32(array, 0) <= 0;
						if (!flag3)
						{
							num4++;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_128.uint_0, array, 4, ref num);
							int num8 = BitConverter.ToInt32(array, 0);
							bool flag4 = num8 == 4;
							if (!flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_138.uint_0, array2, array2.Length, ref num);
								string text = Class10.smethod_3(array2);
								bool flag5 = string_0 != null;
								if (flag5)
								{
									bool flag6 = false;
									for (int i = 0; i < string_0.Length; i++)
									{
										bool flag7 = string_0[i] == text;
										if (flag7)
										{
											flag6 = true;
											break;
										}
									}
									bool flag8 = flag6;
									if (flag8)
									{
										goto IL_24B;
									}
								}
								bool flag9 = array3 == null;
								if (flag9)
								{
									array3 = new string[1];
								}
								else
								{
									bool flag10 = false;
									for (int j = 0; j < array3.Length; j++)
									{
										bool flag11 = array3[j] == text;
										if (flag11)
										{
											flag10 = true;
											break;
										}
									}
									bool flag12 = flag10;
									if (flag12)
									{
										goto IL_24B;
									}
									Array.Resize<string>(ref array3, array3.Length + 1);
								}
								array3[array3.Length - 1] = text;
							}
						}
					}
					IL_24B:
					num5 += 1U;
				}
				bool flag13 = array3 != null;
				if (flag13)
				{
					Array.Sort<string>(array3);
					int num9 = 0;
					bool flag14 = string_0 == null;
					if (flag14)
					{
						string_0 = new string[array3.Length];
					}
					else
					{
						num9 = string_0.Length;
						Array.Resize<string>(ref string_0, string_0.Length + array3.Length);
					}
					for (int k = 0; k < array3.Length; k++)
					{
						string_0[k + num9] = array3[k];
					}
				}
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000F0488 File Offset: 0x000EE688
		public static void smethod_2(GStruct49 gstruct49_0, ref string[] string_0, int int_1 = 0)
		{
			int num = 0;
			byte[] array = new byte[4];
			byte[] array2 = new byte[80];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num2 = BitConverter.ToUInt32(array, 0) + Class53.gstruct51_97.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			string[] array3 = null;
			int num4 = Class79.smethod_4(gstruct49_0);
			int num5 = 0;
			uint num6 = 1U;
			while ((ulong)num6 < (ulong)((long)Class53.int_1) && num4 > num5)
			{
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + (num6 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
				uint num7 = BitConverter.ToUInt32(array, 0);
				bool flag = num7 == 0U;
				if (!flag)
				{
					uint num8 = num3 + num7 * Class53.gstruct51_106.uint_0;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_106.uint_0 - 4U, array, 4, ref num);
					bool flag2 = BitConverter.ToInt32(array, 0) != 0;
					if (!flag2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array, 1, ref num);
						bool flag3 = array[0] == 0;
						if (!flag3)
						{
							num5++;
							uint num9 = num2 + num6 * 20U;
							bool flag4 = int_1 > 0;
							if (flag4)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num9 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								bool flag5 = (int)array[0] != int_1;
								if (flag5)
								{
									goto IL_28A;
								}
							}
							Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_108.uint_0, array, 1, ref num);
							bool flag6 = array[0] == 0;
							if (!flag6)
							{
								Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + Class53.gstruct51_107.uint_0, array2, array2.Length, ref num);
								string text = Class10.smethod_3(array2);
								bool flag7 = string_0 != null;
								if (flag7)
								{
									bool flag8 = false;
									for (int i = 0; i < string_0.Length; i++)
									{
										bool flag9 = string_0[i] == text;
										if (flag9)
										{
											flag8 = true;
											break;
										}
									}
									bool flag10 = flag8;
									if (flag10)
									{
										goto IL_28A;
									}
								}
								bool flag11 = array3 != null;
								if (flag11)
								{
									bool flag12 = false;
									for (int j = 0; j < array3.Length; j++)
									{
										bool flag13 = array3[j] == text;
										if (flag13)
										{
											flag12 = true;
											break;
										}
									}
									bool flag14 = flag12;
									if (flag14)
									{
										goto IL_28A;
									}
									Array.Resize<string>(ref array3, array3.Length + 1);
								}
								else
								{
									array3 = new string[1];
								}
								array3[array3.Length - 1] = text;
							}
						}
					}
				}
				IL_28A:
				num6 += 1U;
			}
			bool flag15 = array3 != null;
			if (flag15)
			{
				Array.Sort<string>(array3);
				int num10 = 0;
				bool flag16 = string_0 != null;
				if (flag16)
				{
					num10 = string_0.Length;
					Array.Resize<string>(ref string_0, string_0.Length + array3.Length);
				}
				else
				{
					string_0 = new string[array3.Length];
				}
				for (int k = 0; k < array3.Length; k++)
				{
					string_0[k + num10] = array3[k];
				}
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000F07B4 File Offset: 0x000EE9B4
		public static void smethod_3()
		{
			int int_ = Class99.int_0;
			Class99.int_0 = 0;
			bool flag = false;
			for (;;)
			{
				try
				{
					int num = Class81.smethod_3(Form1.gstruct49_0, int_);
					bool flag2 = !Class12.bool_0 && num >= 0 && Form1.gstruct49_0[num].bool_25 && Form1.gstruct49_0[num].gstruct47_0.int_0 > 0;
					if (!flag2)
					{
						bool flag3 = 0 <= num;
						if (flag3)
						{
							Form1.gstruct49_0[num].bool_45 = false;
							Form1.gstruct49_0[num].gstruct47_0.int_0 = 0;
							Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_13, 0, 4);
							Class70.smethod_52(Form1.gstruct49_0[num], "<color=green><bclr=blue>KÕt thóc nhÆt qu¶ !", 1);
						}
						break;
					}
					bool flag4 = flag;
					if (!flag4)
					{
						bool flag5 = !Form1.gstruct49_0[num].bool_45;
						if (!flag5)
						{
							break;
						}
						bool flag6 = Class70.smethod_3(Form1.gstruct49_0[num], Class70.uint_13, 4) != 0;
						if (!flag6)
						{
							Form1.gstruct49_0[num].gstruct47_0.int_0 = 0;
							continue;
						}
						flag = true;
						Form1.gstruct49_0[num].bool_45 = true;
						Class70.smethod_52(Form1.gstruct49_0[num], "<color=green><bclr=blue>NhÆt qu¶ Huy Hoµng, Hoµng Kim...", 1);
					}
					Class99.smethod_4(int_);
				}
				catch
				{
				}
				Thread.Sleep(300);
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x000F0960 File Offset: 0x000EEB60
		private static void smethod_4(int int_1)
		{
			GStruct49 gstruct = default(GStruct49);
			bool flag = false;
			int num = 0;
			string text = Class53.string_22.ToLower();
			int num2 = 0;
			byte[] array = new byte[4];
			byte[] array2 = null;
			int num3 = 0;
			int num4 = -1;
			int num5 = 0;
			uint num6 = 0U;
			uint[] array3 = new uint[2];
			for (;;)
			{
				num3--;
				Thread.Sleep(100);
				bool flag2 = num3 <= 0;
				if (flag2)
				{
					num = Class81.smethod_3(Form1.gstruct49_0, int_1);
					bool flag3 = Class12.bool_0 || num < 0 || !Form1.gstruct49_0[num].bool_25 || Form1.gstruct49_0[num].gstruct47_0.int_0 <= 0;
					if (flag3)
					{
						flag = true;
					}
				}
				gstruct = Form1.gstruct49_0[num];
				DateTime now = DateTime.Now;
				int hour = now.Hour;
				int minute = now.Minute;
				int second = now.Second;
				long ticks = new TimeSpan(hour, minute, second).Ticks;
				long ticks2 = new TimeSpan(gstruct.gstruct47_0.int_3, gstruct.gstruct47_0.int_4, gstruct.gstruct47_0.int_5).Ticks;
				uint num7 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
				uint num8 = Class22.smethod_30(num7 + Class53.gstruct51_13.uint_0, gstruct.int_137);
				uint num9 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
				uint num10 = num9 + num8 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_13 * 4U, array, 4, ref num2);
				bool flag4 = array[0] == 0;
				if (flag4)
				{
					flag = true;
				}
				bool flag5 = flag || num4 != gstruct.gstruct47_0.int_2;
				if (flag5)
				{
					num4 = gstruct.gstruct47_0.int_2;
					bool flag6 = flag;
					if (flag6)
					{
						break;
					}
				}
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_15 * 4U, array, 1, ref num2);
				int num11 = (int)array[0];
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_16 * 4U, array, 4, ref num2);
				array3[0] = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + (Class70.uint_16 + 1U) * 4U, array, 4, ref num2);
				array3[1] = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + (Class70.uint_16 + 2U) * 4U, array, 4, ref num2);
				int num12 = BitConverter.ToInt32(array, 0);
				Class22.ReadProcessMemory(gstruct.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num2);
				int num13 = BitConverter.ToInt32(array, 0);
				uint[] array4 = new uint[2];
				uint[] array5 = new uint[]
				{
					Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
					Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
				};
				int num14 = Class83.smethod_12(gstruct);
				bool flag7 = num14 == 1;
				if (flag7)
				{
					int num15 = 5;
					bool flag8 = num5 >= num15;
					if (flag8)
					{
						bool flag9 = num11 > 0;
						if (flag9)
						{
							Class70.smethod_2(gstruct, Class70.uint_16, (int)array5[0], 4);
							Class70.smethod_2(gstruct, Class70.uint_16 + 1U, (int)array5[1], 4);
							Class70.smethod_2(gstruct, Class70.uint_16 + 2U, num13, 4);
							byte[] array6 = Class12.smethod_46("Täa ®é míi: " + array5[0].ToString() + "," + array5[1].ToString(), true);
							Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array6, array6.Length, ref num2);
						}
						num6 = 0U;
					}
					else
					{
						bool flag10 = num11 > 0;
						if (flag10)
						{
							byte[] array6 = Class12.smethod_46("§Þnh l¹i quanh ®iÓm: " + (num15 - num5).ToString(), true);
							Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array6, array6.Length, ref num2);
						}
					}
					num5++;
				}
				else
				{
					num5 = 0;
					bool flag11 = gstruct.gstruct47_0.int_2 > 0;
					if (flag11)
					{
						long num16 = ticks2 - ticks;
						byte[] array6 = Class12.smethod_46(string.Concat(new string[]
						{
							hour.ToString(),
							".",
							minute.ToString(),
							".",
							second.ToString(),
							"(",
							(num16 / 10000000L).ToString(),
							")"
						}), true);
						Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array6, array6.Length, ref num2);
						bool flag12 = num16 > 0L;
						if (flag12)
						{
							continue;
						}
					}
					uint uint_ = gstruct.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
					Class22.ReadProcessMemory(gstruct.int_137, uint_, array, 4, ref num2);
					int num17 = BitConverter.ToInt32(array, 0);
					bool flag13 = num17 <= 1;
					if (!flag13)
					{
						int num18 = 0;
						long num19 = 0L;
						string text2 = text;
						bool flag14 = gstruct.gstruct47_0.string_0 != null && gstruct.gstruct47_0.string_0 != string.Empty;
						if (flag14)
						{
							text2 = gstruct.gstruct47_0.string_0.ToLower();
						}
						bool flag15 = array2 == null || array2.Length != text2.Length + 5;
						if (flag15)
						{
							array2 = new byte[text2.Length + 5];
						}
						bool flag16 = num6 > 0U;
						if (!flag16)
						{
							goto IL_6DA;
						}
						string text3 = Class98.smethod_16(gstruct, (int)num6, ref array4, 60);
						bool flag17 = text3 != null && text3 != string.Empty && 0 <= Class12.smethod_1(text3, text2);
						if (!flag17)
						{
							goto IL_6DA;
						}
						bool flag18 = num11 > 0 && array3[0] != 0U && array3[1] > 0U;
						if (flag18)
						{
							uint num20 = num9 + num6 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num2);
							array4[0] = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num2);
							array4[1] = BitConverter.ToUInt32(array, 0);
							long num21 = Class60.smethod_18(array3, array4);
							bool flag19 = num21 > (long)(gstruct.gstruct47_0.int_1 * gstruct.gstruct47_0.int_1);
							if (flag19)
							{
								goto IL_A64;
							}
						}
						IL_6DF:
						bool flag20 = num6 > 0U;
						if (flag20)
						{
							uint num20 = num9 + num6 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num2);
							array4[0] = BitConverter.ToUInt32(array, 0);
							Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num2);
							array4[1] = BitConverter.ToUInt32(array, 0);
							for (int i = 0; i < 5; i++)
							{
								array5 = new uint[]
								{
									Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, gstruct.int_137),
									Class22.smethod_30(num10 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, gstruct.int_137)
								};
								long num22 = Class60.smethod_18(array5, array4);
								bool flag21 = num22 <= 7500L;
								if (flag21)
								{
									break;
								}
								Class70.smethod_61(gstruct, array4);
								Thread.Sleep(150);
							}
							bool flag22 = gstruct.gstruct47_0.int_6 > 0;
							if (flag22)
							{
								Class45.smethod_10(gstruct);
							}
							Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_72.uint_0, BitConverter.GetBytes(num6), 4, ref num2);
							bool flag23 = gstruct.gstruct47_0.int_6 <= 0;
							if (!flag23)
							{
								bool flag24 = false;
								int i = 0;
								while (i < 600)
								{
									int num23 = Class45.smethod_9(gstruct);
									bool flag25 = num23 <= 0;
									if (!flag25)
									{
										flag24 = true;
										break;
									}
									i++;
									Thread.Sleep(1);
								}
								i = 0;
								long long_ = Class12.smethod_27();
								int num24 = -16777215;
								while (flag24 && Class12.smethod_28(long_) < (long)gstruct.gstruct47_0.int_7)
								{
									Thread.Sleep(1);
									string text4 = Class98.smethod_16(gstruct, (int)num6, ref array4, 60);
									bool flag26 = text4 != null && !(text4 == string.Empty);
									if (!flag26)
									{
										num6 = 0U;
										break;
									}
									int num25 = Class45.smethod_9(gstruct);
									bool flag27 = num24 != -16777215 && num25 <= num24;
									if (flag27)
									{
										bool flag28 = i > 300 && num25 <= num24;
										if (flag28)
										{
											break;
										}
									}
									else
									{
										i = 0;
										num24 = num25;
									}
									byte[] array6 = Class12.smethod_46(num25.ToString(), true);
									Class22.WriteProcessMemory(gstruct.int_137, num10 + Class53.gstruct51_251.uint_0, array6, array6.Length, ref num2);
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_13 * 4U, array, 1, ref num2);
									bool flag29 = array[0] > 0;
									if (!flag29)
									{
										flag = true;
										break;
									}
									Class22.ReadProcessMemory(gstruct.int_137, gstruct.uint_15 + Class70.uint_14 * 4U, array, 1, ref num2);
									bool flag30 = array[0] == 0;
									if (flag30)
									{
										break;
									}
									i++;
								}
							}
						}
						else
						{
							bool flag31 = num11 > 0 && num12 == num13 && array3[0] != 0U && array3[1] > 0U;
							if (flag31)
							{
								long num21 = Class60.smethod_18(array3, array5);
								bool flag32 = num21 > 11200L;
								if (flag32)
								{
									Class70.smethod_61(gstruct, array3);
									Thread.Sleep(200);
								}
							}
						}
						continue;
						IL_A64:
						num6 = 0U;
						uint num26 = 1U;
						while (num26 < 256U && num17 > num18)
						{
							uint num20 = num9 + num26 * Class53.gstruct51_15.uint_0;
							Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_16.uint_0, array, 4, ref num2);
							bool flag33 = array[0] == 0;
							if (!flag33)
							{
								num18++;
								Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_52.uint_0, array, 4, ref num2);
								uint num27 = BitConverter.ToUInt32(array, 0);
								bool flag34 = num27 != 3U;
								if (!flag34)
								{
									Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num2);
									array4[0] = BitConverter.ToUInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num2);
									array4[1] = BitConverter.ToUInt32(array, 0);
									Class22.ReadProcessMemory(gstruct.int_137, num20 + Class53.gstruct51_16.uint_0, array2, array2.Length, ref num2);
									string string_ = Class10.smethod_3(array2).ToLower();
									bool flag35 = Class12.smethod_1(string_, text2) < 0;
									if (!flag35)
									{
										bool flag36 = num11 > 0 && array3[0] != 0U && array3[1] > 0U;
										long num21;
										if (flag36)
										{
											num21 = Class60.smethod_18(array3, array4);
											bool flag37 = num21 > (long)(gstruct.gstruct47_0.int_1 * gstruct.gstruct47_0.int_1);
											if (flag37)
											{
												goto IL_C18;
											}
										}
										else
										{
											num21 = Class60.smethod_18(array5, array4);
										}
										bool flag38 = num6 == 0U || num21 < num19;
										if (flag38)
										{
											num6 = num26;
											num19 = num21;
										}
									}
								}
							}
							IL_C18:
							num26 += 1U;
						}
						goto IL_6DF;
						IL_6DA:
						goto IL_A64;
					}
				}
			}
			num = Class81.smethod_3(Form1.gstruct49_0, int_1);
			bool flag39 = 0 <= num;
			if (flag39)
			{
				Form1.gstruct49_0[num].gstruct47_0.int_0 = 0;
			}
			Class70.smethod_2(gstruct, Class70.uint_13, 0, 4);
		}

		// Token: 0x04000416 RID: 1046
		public static int int_0;
	}
}
