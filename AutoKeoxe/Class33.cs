using System;
using System.Diagnostics;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200001D RID: 29
	internal class Class33
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		public void method_0()
		{
			string text = Class53.string_8 + Class12.smethod_53("ᓣᓓᓶᓮᓰᓵᓣᓈᓼᓻᓶᓝᓓᓉᓚᒸᓀᓣᓈᓼᓻᓶᓝᓓᓉᓚᒵᓬᓿᓬ");
			bool flag = !Class12.smethod_17(text);
			if (flag)
			{
				Class33.string_1 = Class12.smethod_53("ᓒᕭᔃᒪᓭᓲᕳᓺᒪᓋᓿᓾᓹᓠᓖᓌᓝᒻᓃᒪᔀᕪᓹᒪᓾᓲᘺᒪᓷ㍯ᓭᒪᓢ").Replace("X", text);
			}
			else
			{
				bool flag2 = Class29.bool_0 && Class12.long_0 >= GClass1.long_1 && GClass1.long_1 > 0L;
				if (flag2)
				{
					uint num = 4194304U;
					uint num2 = 4194304U;
					uint num3 = 4319353U;
					uint num4 = 4318750U;
					uint num5 = 4316631U;
					bool flag3 = Class33.uint_0 == 0U;
					if (flag3)
					{
						int num6 = Class22.smethod_56();
						uint uint_ = Class22.smethod_37(num6, Class12.smethod_53("ᓨᓦᓘᓥᒦᒥᒡᓗᓟᓟ"));
						Class33.uint_0 = Class22.GetProcAddress(uint_, Class12.smethod_53("ᒺᓝᓢᓘᓋᓝᓢᓘᓣᓫᒵ"));
						bool flag4 = Class33.uint_0 == 0U;
						if (flag4)
						{
							Class33.string_1 = Class12.smethod_53("ᓞᓻᖇᔁᓺᒳᔇᓻ㍖ᒳᓿᔂᓴᓷᒳᔀᔂᓷᔈᓿᒳᔈᔆᓸᔅᓆᓅᓁᓷᓿᓿᒿᒳᓾ㍒ᔇᒳᔇᓻᖍᓶᒴ");
							return;
						}
						int int_ = Class22.OpenProcess(2035711, false, num6);
						int num7 = 0;
						byte[] array = new byte[1];
						Class22.ReadProcessMemory(int_, Class33.uint_0 + 5U, array, 1, ref num7);
						Class33.byte_0 = array[0];
					}
					int num8 = 0;
					int int_2 = 0;
					uint num9 = 0U;
					uint num10 = 0U;
					byte[] array2 = new byte[1];
					string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
					string string_ = environmentVariable + Class12.smethod_53("ᓙᓰᓶᓰᓱᓢᓪᒰᒯᓙᓷᓜᓰᓟᓩᓳᒫᓱᓵᓱ");
					string string_2 = environmentVariable + Class12.smethod_53("ᓜᓳᓹᓳᓴᓥᓭᒳᒲᓜᓺᓟᓳᓢᓬᓶᓬᓯᓧᒮᓴᓸᓴ");
					string string_3 = "ᗞᗣᗟᗂᗛᗒᗣᗃᗝᗸᗹᗄᗘᖼᗥᗃᗴᗑᗚᗃᗗᗨᘆᘃᗙᗵᗀᗂᗞᗣᗟᗂᗛᗒᗣᗃᗝᗸᗹᗄᗘᖼᗦᗸᗴᗑᗒᗃᗗᗘᘇᗒᗮᗓᗡᗴᗱᖿᗔᗷᗥᖻᘂᘀᗱᗥᗹᖼᗱᗎᗥᖿᗝᗡᗴᗸᗘᘊᗨᗃᗳᗐᗙᗶᗟᗧᘅᘅᗲᗏᗐᗈᗥᗼᗣᗿᗤᗡᗅᗖᗱᗺᗢᗷᗰᗔᗤᖾᗜᗠᗳᗷᗞᘉᗧᗂᗲᗏᗘᗼᗞᗦᘄᘄᗱᗎᗖᗇᗤᗸᘄᗳᗮᗨᗡᘄᗳᗐᗠᖺᗟᗣᗶᗺᗚᘅᗣᗅᗵᗒᗛᗸᗚᗢᘇᘇᗴᗑᗒᗃᗯᗻᗡᘇᗮᗤᗥᗶᗳᗽᘅᖾᗚᗏᗵᗄᗩᗸᗰᖾᗚᗢᘇᘉᗨᗡᗸᗃᗗᗨᘆᘆᗳᗓᗄᗹᗲᗥᗇᖿᗮᗹᘁᗁᗝᗒᗸᗀᗥᗴᗳᗁᗝᗥᘃᘅᗤᗤᗻᗆᗚᗤᘂᘂᗶᗔᗨᗏᗟᖻᗠᗶᗤᖾᗣᗟᗡᗵᗼᗓᗠᗥᘄᗸᗘᗔᗑᗹᗚᗓᗜᘁᗝᗗᘅᘆᗲᗏᗘᗖᗞᗖᘄᖾᗥᗷᗥᘇᗴᗓᗚᗠᗗᘊᗘᖿᗚᗐᗘᘂᗝᗔᗔᗡᗛᗡᗔᗪᗜᘈᗖᖿᗝᗶᗻᗌ";
					string string_4 = "ᒶᓪᓩᓤᓋᓁᒷᓈᒕᒦᒣᒮ";
					string[] array3 = Class12.smethod_14(text, '\\');
					Process process = null;
					Class12.smethod_34(string_, Class12.smethod_53(string_3), 1);
					Class12.smethod_34(string_2, Class12.smethod_53(string_4), 1);
					GStruct4 gstruct = Class22.smethod_41(text, array3[0], false, null);
					bool flag5 = !Class12.bool_0 && gstruct.uint_0 > 0U;
					if (flag5)
					{
						int processId = (int)gstruct.uint_0;
						try
						{
							process = Process.GetProcessById(processId);
						}
						catch
						{
						}
						int id = process.Id;
						int_2 = Class22.OpenProcess(2035711, false, id);
						int num11 = 0;
						for (;;)
						{
							bool flag6 = !Class12.bool_0;
							if (!flag6)
							{
								goto IL_291;
							}
							num10 = Class22.smethod_1(int_2, 512U, GEnum1.flag_2);
							bool flag7 = num10 == 0U;
							if (!flag7)
							{
								goto IL_290;
							}
							num11++;
							bool flag8 = num11 <= 600;
							if (!flag8)
							{
								break;
							}
							Class22.smethod_45(process);
							Thread.Sleep(1);
							Class22.smethod_43(process);
						}
						Class33.string_1 = Class12.smethod_53("ᓅ㍐ᓢᒙᒪᒥᒙᓤ㌸ᓭᒙᓭᓡᕳᓜᒧ");
						goto IL_8AF;
						IL_290:
						IL_291:
						num11 = 0;
						for (;;)
						{
							bool flag9 = !Class12.bool_0;
							if (!flag9)
							{
								goto IL_32E;
							}
							Class22.ReadProcessMemory(int_2, Class33.uint_0 + 5U, array2, 1, ref num8);
							bool flag10 = array2[0] != Class33.byte_0;
							if (!flag10)
							{
								goto IL_32D;
							}
							num11++;
							bool flag11 = num11 <= 3000;
							if (!flag11)
							{
								break;
							}
							Class22.smethod_45(process);
							Thread.Sleep(1);
							Class22.smethod_43(process);
						}
						Class33.string_1 = Class12.smethod_53("ᓅ㍐ᓢᒙᒪᒥᒙᓤ㌸ᓭᒙᓭᓡᕳᓜᒧ").Replace("1", "2");
						goto IL_8A5;
						IL_32D:
						IL_32E:
						string text2 = string.Concat(new string[]
						{
							"3E 8D 44 24 04 8B 00 85 C0 74 21 81 38 56 42 6F 78 75 19 81 78 04 54 72 61 79 75 10A3",
							Class12.smethod_45(num10, 8, false, true),
							"90 9080 3D",
							Class12.smethod_45(num10, 8, false, true),
							"0075 F7 8B FF 55 8B ECE9 00 00 00 00"
						});
						array2 = Class12.smethod_8(text2, false);
						Class22.WriteProcessMemory(int_2, num10 + 4U, array2, array2.Length, ref num8);
						num9 = (uint)(array2.Length + 16);
						uint num12 = num10 + (uint)array2.Length;
						uint uint_2 = Class33.uint_0 - num12 + 1U;
						Class22.smethod_31(num12, int_2, uint_2, 4);
						array2 = new byte[]
						{
							233
						};
						uint uint_3 = num10 - (Class33.uint_0 + 1U);
						Class22.WriteProcessMemory(int_2, Class33.uint_0, array2, 1, ref num8);
						bool flag12 = !Class22.smethod_31(Class33.uint_0 + 1U, int_2, uint_3, 4);
						if (flag12)
						{
							Class22.smethod_53(process);
							Class33.string_1 = Class12.smethod_53("ᓘᓰ㌫ᓱᒨᖙᖂᓶᓯᒨᓸᓰᓱᕲᓶᒨᓪ㌫ᓶᒨᓉᓽᓼᓷᓞᓔᓊᓛᒹᒶᓁ");
						}
						else
						{
							Class22.smethod_45(process);
							num11 = 0;
							bool flag16;
							do
							{
								bool flag13 = !Class12.bool_0;
								if (!flag13)
								{
									goto IL_4B9;
								}
								bool flag14 = Class22.smethod_30(num10, int_2) == 0U;
								if (!flag14)
								{
									goto IL_4B0;
								}
								num11++;
								Thread.Sleep(1);
								bool flag15 = num11 <= 5000;
								if (!flag15)
								{
									goto IL_49C;
								}
								flag16 = (num11 % 300 == 0 && Class22.smethod_52(process));
							}
							while (!flag16);
							goto IL_89B;
							IL_49C:
							Class33.string_1 = Class12.smethod_53("ᓛᓿᕫᒪᓾᓲ㍧ᓳᒪᓱᓳᓫᓸᒪᓵᓳ㍍ᓷᒪᓾᓼᓫᒶᒪᓵ㍉ᓾᒪᓾᓲᖄᓭᒸ");
							goto IL_89B;
							IL_4B0:
							Class22.smethod_43(process);
							IL_4B9:
							try
							{
								num = (uint)((int)process.MainModule.BaseAddress);
							}
							catch
							{
							}
							uint num13 = num + (num3 - num2);
							num11 = 0;
							for (;;)
							{
								bool flag17 = !Class12.bool_0;
								if (!flag17)
								{
									goto IL_572;
								}
								Class22.ReadProcessMemory(int_2, num13 + 5U, array2, 1, ref num8);
								bool flag18 = array2[0] != 87;
								if (!flag18)
								{
									goto IL_571;
								}
								num11++;
								bool flag19 = num11 <= 3000;
								if (!flag19)
								{
									break;
								}
								Class22.smethod_45(process);
								Thread.Sleep(1);
								Class22.smethod_43(process);
							}
							Class33.string_1 = Class12.smethod_53("ᓅ㍐ᓢᒙᒪᒥᒙᓤ㌸ᓭᒙᓭᓡᕳᓜᒧ").Replace("1", "3");
							goto IL_891;
							IL_571:
							IL_572:
							uint num14 = num10 + num9;
							array2 = Class12.smethod_46(string_, true);
							Class22.WriteProcessMemory(int_2, num14, array2, array2.Length, ref num8);
							num9 += (uint)(array2.Length + 16);
							num12 = num10 + num9;
							text2 = "B8" + Class12.smethod_45(num14, 8, false, true) + "3E 8B 4D E0 53 8A 18 88 19 40 41 84 DB 75 F6 5B 68 01 00 00 04E9 00 00 00 00";
							array2 = Class12.smethod_8(text2, true);
							Class22.WriteProcessMemory(int_2, num10 + num9, array2, array2.Length, ref num8);
							uint num15 = num10 + num9 - (num13 + 5U);
							uint num16 = num10 + num9 + (uint)array2.Length - 4U;
							uint num17 = num13 - num16 + 1U;
							num9 += (uint)(array2.Length + 16);
							array2 = new byte[]
							{
								233
							};
							Class22.WriteProcessMemory(int_2, num13, array2, 1, ref num8);
							Class22.smethod_31(num13 + 1U, int_2, num15, 4);
							Class22.smethod_31(num16, int_2, num17, 4);
							num13 = num + (num4 - num2);
							Class22.ReadProcessMemory(int_2, num13 + 5U, array2, 1, ref num8);
							bool flag20 = array2[0] != 106;
							if (flag20)
							{
								Class33.string_1 = "Không kiểm tra được F2, kết thúc.";
							}
							else
							{
								uint num18 = num10 + num9;
								array2 = Class12.smethod_46(string_2, true);
								Class22.WriteProcessMemory(int_2, num18, array2, array2.Length, ref num8);
								num9 += (uint)(array2.Length + 16);
								num12 = num10 + num9;
								text2 = "B8" + Class12.smethod_45(num18, 8, false, true) + "3E 8D 8D 98 F7 FF FF 53 8A 18 88 19 40 41 84 DB 75 F6 5B 68 01 00 00 04E9 00 00 00 00";
								array2 = Class12.smethod_8(text2, true);
								Class22.WriteProcessMemory(int_2, num10 + num9, array2, array2.Length, ref num8);
								num15 = num10 + num9 - (num13 + 5U);
								num16 = num10 + num9 + (uint)array2.Length - 4U;
								num17 = num13 - num16 + 1U;
								num9 += (uint)(array2.Length + 16);
								array2 = new byte[]
								{
									233
								};
								Class22.WriteProcessMemory(int_2, num13, array2, 1, ref num8);
								Class22.smethod_31(num13 + 1U, int_2, num15, 4);
								Class22.smethod_31(num16, int_2, num17, 4);
								uint num19 = num10 + num9;
								num9 += 80U;
								uint num20 = num10 + num9;
								bool flag21 = Class33.string_0 == null || Class33.string_0 == string.Empty;
								if (flag21)
								{
									Class33.string_0 = "SBLV";
								}
								array2 = Class12.smethod_46(Class33.string_0, true);
								Class22.WriteProcessMemory(int_2, num19, array2, array2.Length, ref num8);
								uint num21 = num + (num5 - num2);
								num15 = num20 - (num21 + 5U);
								array2 = Class12.smethod_8("E9" + Class12.smethod_45(num15, 8, false, true), false);
								Class22.WriteProcessMemory(int_2, num21, array2, array2.Length, ref num8);
								text2 = "60 8B 4C 24 28 80 39 00 74 2C 33 C0 8A 19 40 41 84 DB 75 F8 83 F8 0F 7E 1D 48 49 8A 19 85 C0 74 15 80 FB 7C 75 F341BF" + Class12.smethod_45(num19, 8, false, true) + "8A 1F 88 19 41 47 84 DB 75 F6 61 E9";
								uint num22 = (uint)(text2.Replace(" ", string.Empty).Length / 2);
								num17 = num21 - (num20 + num22) + 1U;
								text2 += Class12.smethod_45(num17, 8, false, true);
								array2 = Class12.smethod_8(text2, true);
								Class22.WriteProcessMemory(int_2, num20, array2, array2.Length, ref num8);
							}
							IL_891:
							IL_89B:;
						}
						IL_8A5:
						IL_8AF:
						bool flag22 = num10 > 0U;
						if (flag22)
						{
							array2 = new byte[]
							{
								139,
								byte.MaxValue,
								85,
								139,
								236
							};
							Class22.WriteProcessMemory(int_2, Class33.uint_0, array2, array2.Length, ref num8);
							Class22.smethod_31(num10, int_2, 0U, 4);
						}
						Class22.smethod_45(process);
						Class22.smethod_32(int_2);
					}
					else
					{
						Class33.string_1 = Class12.smethod_53("ᔅᔢᖮᔨᔡᓚᔮᔢ㍽ᓚᔧ㎙ᓚᔛᔯᔮᔩᓦᓚᔥᔣ㍽ᔧᓚᔮᔬᔛᓚᔲᔟᔧᓚᔛᔯᔮᔩᓚᔮᔬᔩᔨᔡᓚᔮᔢᙪᓚᔧ㎟ᔝᓚᔦᔩᔡᔣᔨᓚᔝᖭᓚᔰ㍟ᔨᓚᗋ㍻ᓚᔡᖦᓚᔢᔛᔳᓚᔥᔢᖮᔨᔡᓚᓹ");
					}
				}
				else
				{
					Class33.string_1 = Class12.smethod_53("ᓗᓼ㍝ᒴᓷᖇᒴᔈᓼ㍗ᒴᔇ㎁ᒴᓸ㍹ᔂᓻᒴᖥᙄ㍷ᓷᒴᓿᓼᓽᒴᖥᖗᔂᓻᒴᓿᖑᒴᔀᓽᓷᒴᓼᓸᓸ");
				}
			}
		}

		// Token: 0x040000E9 RID: 233
		public static string string_0 = Class62.smethod_6("SBLV", 0, "SBLV");

		// Token: 0x040000EA RID: 234
		public static string string_1 = null;

		// Token: 0x040000EB RID: 235
		private static uint uint_0 = 0U;

		// Token: 0x040000EC RID: 236
		private static byte byte_0 = 0;
	}
}
