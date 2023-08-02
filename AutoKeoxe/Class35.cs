using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x0200001F RID: 31
	internal class Class35
	{
		// Token: 0x0600018B RID: 395 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		static Class35()
		{
			uint[,] array_ = new uint[5, 2];
			Class11.smethod_4(array_, 159991);
			Class35.uint_0 = array_;
			uint[,] array_2 = new uint[5, 2];
			Class11.smethod_4(array_2, 160040);
			Class35.uint_1 = array_2;
			uint[,] array_3 = new uint[5, 2];
			Class11.smethod_4(array_3, 160089);
			Class35.uint_2 = array_3;
			uint[,] array_4 = new uint[5, 2];
			Class11.smethod_4(array_4, 160138);
			Class35.uint_3 = array_4;
			uint[,] array_5 = new uint[5, 2];
			Class11.smethod_4(array_5, 160187);
			Class35.uint_4 = array_5;
			uint[,] array_6 = new uint[5, 2];
			Class11.smethod_4(array_6, 160236);
			Class35.uint_5 = array_6;
			uint[,] array_7 = new uint[5, 2];
			Class11.smethod_4(array_7, 160285);
			Class35.uint_6 = array_7;
			Class35.struct15_0 = new Class35.Struct15[]
			{
				new Class35.Struct15
				{
					int_0 = 11,
					string_0 = Class35.string_13,
					uint_0 = Class35.uint_0
				},
				new Class35.Struct15
				{
					int_0 = 78,
					string_0 = Class35.string_9,
					uint_0 = Class35.uint_1
				},
				new Class35.Struct15
				{
					int_0 = 1,
					string_0 = Class35.string_11,
					uint_0 = Class35.uint_2
				},
				new Class35.Struct15
				{
					int_0 = 162,
					string_0 = Class35.string_12,
					uint_0 = Class35.uint_3
				},
				new Class35.Struct15
				{
					int_0 = 37,
					string_0 = Class35.string_15,
					uint_0 = Class35.uint_4
				},
				new Class35.Struct15
				{
					int_0 = 80,
					string_0 = Class35.string_10,
					uint_0 = Class35.uint_5
				},
				new Class35.Struct15
				{
					int_0 = 176,
					string_0 = Class35.string_14,
					uint_0 = Class35.uint_6
				}
			};
			Class35.int_2 = new int[]
			{
				75,
				225,
				226,
				227,
				321,
				322,
				336,
				340,
				144,
				93,
				124,
				152,
				320,
				319
			};
			Class35.random_0 = new Random();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000213F8 File Offset: 0x0001F5F8
		private static void smethod_0(ref Class35.Struct14[] struct14_1, Class35.Struct14[] struct14_2, bool bool_0 = false)
		{
			bool flag = struct14_2 == null;
			if (!flag)
			{
				bool flag2 = struct14_1 != null;
				if (flag2)
				{
					int num = struct14_1.Length;
					int num2 = struct14_2.Length;
					if (bool_0)
					{
						Array.Resize<Class35.Struct14>(ref struct14_2, num + num2);
						for (int i = 0; i < num; i++)
						{
							ref Class35.Struct14 ptr = ref struct14_2[num2 + i];
							ptr = struct14_1[i];
						}
						num2 = struct14_2.Length;
						struct14_1 = new Class35.Struct14[num2];
						for (int j = 0; j < num2; j++)
						{
							ref Class35.Struct14 ptr2 = ref struct14_1[j];
							ptr2 = struct14_2[j];
						}
					}
					else
					{
						Array.Resize<Class35.Struct14>(ref struct14_1, num + num2);
						for (int k = 0; k < num2; k++)
						{
							ref Class35.Struct14 ptr3 = ref struct14_1[num + k];
							ptr3 = struct14_2[k];
						}
					}
				}
				else
				{
					struct14_1 = struct14_2;
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000214FC File Offset: 0x0001F6FC
		private static Class35.Struct14 smethod_1(string string_74)
		{
			bool flag = string_74 == null;
			if (!flag)
			{
				bool flag2 = string_74 == string.Empty;
				if (!flag2)
				{
					goto IL_2C;
				}
			}
			string_74 = "Sinh T";
			IL_2C:
			return new Class35.Struct14
			{
				int_0 = 355,
				string_0 = "§Êu Tr­êng Sinh",
				string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y",
				string_4 = string_74
			};
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00021574 File Offset: 0x0001F774
		private static Class35.Struct14[] smethod_2(string string_74 = null)
		{
			bool flag = string_74 == null || string_74 == string.Empty;
			if (flag)
			{
				string_74 = "dông thuËt|" + Class35.string_7;
			}
			return new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "danh|he Tèng",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "danh|he Tèng",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "danh|he Tèng",
					string_3 = null,
					string_4 = string_74
				}
			};
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00021680 File Offset: 0x0001F880
		private static Class35.Struct14[] smethod_3(string string_74, int int_3 = -1)
		{
			return new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 520,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Ph­îng T",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 521,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Thµnh",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 522,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn BiÖn K",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 523,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn T­¬ng D",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 524,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn D­¬ng C",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 525,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn §¹i L",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 526,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn L©m A",
					string_3 = null,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = int_3,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_4 = string_74
				}
			};
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000218AC File Offset: 0x0001FAAC
		private static Class35.Struct14[] smethod_4(string string_74 = null, string string_75 = null)
		{
			bool flag = string_74 == null || string_74 == string.Empty;
			if (flag)
			{
				string_74 = Class35.string_4;
			}
			bool flag2 = string_75 == null || string_75 == string.Empty;
			if (flag2)
			{
				string_75 = Class35.string_5;
			}
			return new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = string_75
				},
				new Class35.Struct14
				{
					int_0 = 175,
					string_0 = Class35.string_25,
					string_2 = "T©y S¬n",
					string_3 = null,
					string_4 = string_75
				}
			};
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00021DC0 File Offset: 0x0001FFC0
		private static Class35.Struct14[] smethod_5(string string_74 = null)
		{
			bool flag = string_74 == null || string_74 == string.Empty;
			if (flag)
			{
				string_74 = Class35.string_6;
			}
			return new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 59,
					string_0 = "Thiªn V­¬ng Ban",
					string_2 = "Thiªn V­¬ng",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 103,
					string_0 = "ThiÕu L©m ph¸i",
					string_2 = "ThiÕu L©m",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 25,
					string_0 = "§­êng M«n",
					string_2 = "§­êng M«n",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 183,
					string_0 = "Ngò §éc Gi¸o",
					string_2 = "Ngò §éc",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 13,
					string_0 = "Nga My ph¸i",
					string_2 = "Nga M",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 154,
					string_0 = "Thóy Yªn m«n",
					string_2 = "Thóy Yªn",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 49,
					string_0 = "Thiªn NhÉn Gi¸o",
					string_2 = "Thiªn NhÉn",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 115,
					string_0 = "C¸i Bang",
					string_2 = "C¸i Bang",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 81,
					string_0 = "Vâ §ang Ph¸i",
					string_2 = "Vâ §ang",
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 131,
					string_0 = "C«n L«n ph¸i",
					string_2 = "C«n L«n",
					string_4 = string_74
				}
			};
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0002203C File Offset: 0x0002023C
		private static Class35.Struct14[] smethod_6(string string_74 = null)
		{
			bool flag = string_74 == null || string_74 == string.Empty;
			if (flag)
			{
				string_74 = "dông thuËt|Êp 9| 90";
			}
			string text = "rang k|rang s";
			string text2 = string.Concat(new string[]
			{
				string_74,
				"|",
				text,
				"|",
				text
			});
			return new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 875,
					string_0 = Class35.string_50,
					string_2 = Class35.string_51,
					string_3 = Class35.string_51,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 322,
					string_0 = Class35.string_52,
					string_2 = "¬n B¾c",
					string_3 = "¬n B¾c",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 321,
					string_0 = Class35.string_52,
					string_2 = "¬n Nam",
					string_3 = "¬n Nam",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 75,
					string_0 = Class35.string_63,
					string_2 = Class35.string_65,
					string_3 = Class35.string_64,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 227,
					string_0 = Class35.string_55,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 225,
					string_0 = Class35.string_53,
					string_2 = Class35.string_56,
					string_3 = "Sa M¹c Mª",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 226,
					string_0 = Class35.string_54,
					string_2 = Class35.string_57,
					string_3 = "Sa M¹c Mª",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 336,
					string_0 = Class35.string_30,
					string_2 = Class35.string_31,
					string_3 = Class35.string_31,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 340,
					string_0 = Class35.string_32,
					string_2 = Class35.string_32,
					string_3 = Class35.string_32,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 144,
					string_0 = Class35.string_33,
					string_2 = "Çng 4",
					string_3 = "TÇng 4 D­îc",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 93,
					string_0 = Class35.string_34,
					string_2 = "TiÕn Cóc",
					string_3 = "TiÕn Cóc",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 124,
					string_0 = Class35.string_35,
					string_2 = "¸n Viªn",
					string_3 = "C¸n Viªn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 152,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = text2
				}
			};
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000226F4 File Offset: 0x000208F4
		private static void smethod_7()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = Class35.string_68
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "3x",
					string_3 = "Thæ PhØ",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng §én",
					string_2 = "4x",
					string_3 = "§iÓm Th­¬ng",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy §éng",
					string_2 = "5x",
					string_3 = "H­ëng Thñy",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 158,
					string_0 = "Mª Cung CÊm §Þa",
					string_2 = "6x",
					string_3 = null,
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "7x",
					string_3 = "L©m Du",
					string_4 = Class35.string_67
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|Êp 9| 90"), false);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002291C File Offset: 0x00020B1C
		private static void smethod_8()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "dông thuËt|Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "dông thuËt|Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "dông thuËt|Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa-S¬n-Ph",
					string_4 = "ö dông thuËt"
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ÊÔ½£¹È",
					string_2 = "Mª cung KiÕm mé"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 20"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c thôc ®¹o",
					string_3 = "KiÕm C¸c Thôc §¹o",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 20"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ phØ ®éng",
					string_2 = "Thæ phØ ®éng",
					string_3 = "Thæ PhØ ®éng",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 30"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 30"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÒm th­¬ng ®éng tÇng 1",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 40"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÒm th­¬ng ®éng tÇng 2",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 40"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung tÇng 1",
					string_3 = "ThiÕt Th¸p mª cung",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 40"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 50"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 60"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 60"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "dông thuËt|luyÖn c«ng|70"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 70"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch ®éng",
					string_3 = "Nh¹n Th¹ch ®éng",
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 80"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 80"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "ch©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = "dông thuËt|n¬i luyÖn c«ng|c«ng 80"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00022F1C File Offset: 0x0002111C
		private static void smethod_9()
		{
			string str = "dông thuËt";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n MËt",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "|Êp 8"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", -1), false);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002330C File Offset: 0x0002150C
		private static void smethod_10()
		{
			string str = "thÇn hµnh";
			string text = str + "|Tèng Kim";
			string str2 = str + "|n n¬i luyÖn|";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,sè 1|45664,95840,sè 2|49664,95616,sè 3",
					string_3 = "ChiÕn Long",
					string_4 = str + "|ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 977,
					string_0 = "Cæ Loa Thµnh",
					string_2 = "POS|59520,97248,HuyÒn V|61347,114306,Thanh L|49791,114310,Chu T­|49600,102496,B¹ch H",
					string_3 = "Cæ Loa Th|Cæng",
					string_4 = str + "|Cæ Loa"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 1",
					string_3 = "TuyÕt B¸o",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung tÇng 1",
					string_3 = "ThiÕt Th¸p",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "¸y §éng §×nh hå tÇng 1",
					string_3 = null,
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 67,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "¸y §éng §×nh hå tÇng 2",
					string_3 = null,
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 149,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt b¸o ®éng tÇng 5",
					string_3 = null,
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 130,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 6",
					string_3 = null,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 997,
					string_0 = "¶i Chi L¨ng",
					string_2 = "¶i Chi L",
					string_3 = null,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch ®éng",
					string_3 = "Nh¹n Th¹ch ®éng",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "ch©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 124,
					string_0 = Class35.string_35,
					string_2 = "C¸n Viªn",
					string_3 = "C¸n Viªn",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 200,
					string_0 = "Cæ D­¬ng §éng",
					string_2 = "Cæ D­¬ng",
					string_3 = "Cæ D­¬ng",
					string_4 = str2 + "8x"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00024368 File Offset: 0x00022568
		private static void smethod_11()
		{
			string str = "dông thuËt";
			str + "|Tèng Kim";
			string text = str + "|Êp 90";
			string str2 = str + "|Õn n¬i luyÖn c|";
			string string_ = str + "|u tr­êng Sinh T";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 997,
					string_0 = "Tr­êng B¹ch S¬n T©y",
					string_2 = "¬n T©y",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Tr­êng B¹ch S¬n §«ng",
					string_2 = "¬n §«ng",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c thôc ®¹o",
					string_3 = "KiÕm C¸c Thôc §¹o",
					string_4 = str2 + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ phØ ®éng",
					string_2 = "Thæ phØ ®éng",
					string_3 = "Thæ PhØ ®éng",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = str2 + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÒm th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÒm th­¬ng ®éng tÇng 2",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str2 + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung tÇng 1",
					string_3 = "ThiÕt Th¸p mª cung",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str2 + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch ®éng",
					string_3 = "Nh¹n Th¹ch ®éng",
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "ch©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = str
				},
				Class35.smethod_1(string_)
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00024A28 File Offset: 0x00022C28
		private static void smethod_12(bool bool_0)
		{
			Class35.smethod_11();
			string str = "ChiÕn Long";
			if (bool_0)
			{
				str += "|thÇn hµnh";
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = str
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00024AB0 File Offset: 0x00022CB0
		private static void smethod_13(bool bool_0 = false, bool bool_1 = false)
		{
			Class35.smethod_11();
			string str = "dông thuËt|Õn n¬i luyÖn c|";
			string str2 = "Tiªu Kh«ng §éng";
			string str3 = "M¹c TÝch §éng ";
			string str4 = "L¹c V©n §éng";
			string str5 = "Liªn Hoa th¸p t";
			string str6 = str5 + "Çng ";
			string str7 = "H¾c Méc Nhai";
			string text = "TuyÖt T×nh Cèc";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				Class35.smethod_1("thÇn hµnh|Sinh T"),
				new Class35.Struct14
				{
					int_0 = 54,
					string_0 = "Nam Nh¹c trÊn",
					string_2 = "Nam Nh¹c",
					string_4 = "dông thuËt"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str + "2x"
				},
				new Class35.Struct14
				{
					int_0 = 429,
					string_0 = str2,
					string_2 = str2 + " 2",
					string_3 = str2 + " 2",
					string_4 = str + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 420,
					string_0 = str2,
					string_2 = str2,
					string_3 = str2,
					string_4 = str + "3x"
				},
				new Class35.Struct14
				{
					int_0 = 421,
					string_0 = str3 + "1",
					string_2 = str3 + "1",
					string_3 = str3 + "1",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 422,
					string_0 = str3 + "2",
					string_2 = str3 + "2",
					string_3 = str3 + "2",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 423,
					string_0 = str3 + "3",
					string_2 = str3 + "3",
					string_3 = str3 + "3",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 430,
					string_0 = str3 + "4",
					string_2 = str3 + "4",
					string_3 = str3 + "4",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 431,
					string_0 = str3 + "5",
					string_2 = str3 + "5",
					string_3 = str3 + "5",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 432,
					string_0 = str3 + "6",
					string_2 = str3 + "6",
					string_3 = str3 + "6",
					string_4 = str + "4x"
				},
				new Class35.Struct14
				{
					int_0 = 433,
					string_0 = str4 + " 2",
					string_2 = str4 + " 2",
					string_3 = str4 + " 2",
					string_4 = str + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 424,
					string_0 = str4,
					string_2 = str4,
					string_3 = str4,
					string_4 = str + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 434,
					string_0 = str5,
					string_2 = str6 + "1",
					string_3 = str6 + "1",
					string_4 = str + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 435,
					string_0 = str5,
					string_2 = str6 + "2",
					string_3 = str6 + "5",
					string_4 = str + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 436,
					string_0 = str5,
					string_2 = str6 + "3",
					string_3 = str6 + "6",
					string_4 = str + "5x"
				},
				new Class35.Struct14
				{
					int_0 = 983,
					string_0 = "T­êng V©n ®éng ",
					string_2 = "T­êng V©n ®éng NEW",
					string_3 = null,
					string_4 = str + "6x"
				},
				new Class35.Struct14
				{
					int_0 = 995,
					string_0 = str7,
					string_2 = str7 + "|L©m Du Mâm",
					string_3 = null,
					string_4 = str + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 996,
					string_0 = text,
					string_2 = text,
					string_3 = text,
					string_4 = str + "7x"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = str + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str + "8x"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8x"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			bool flag = bool_1 || bool_0;
			if (flag)
			{
				int[] array = new int[]
				{
					181,
					199,
					203,
					204,
					198
				};
				for (int i = 0; i < Class35.struct14_0.Length; i++)
				{
					for (int j = 0; j < array.Length; j++)
					{
						bool flag2 = Class35.struct14_0[i].int_0 == array[j];
						if (flag2)
						{
							Class35.struct14_0[i].int_0 = -1;
							break;
						}
					}
				}
			}
			if (bool_0)
			{
				struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 19,
						string_0 = "KiÕm C¸c T©y Na",
						string_2 = "KiÕm C¸c T©y Nam",
						string_3 = "KiÕm C¸c",
						string_4 = str + "2x"
					},
					new Class35.Struct14
					{
						int_0 = 4,
						string_0 = "Kim Quang ®éng",
						string_2 = "Kim Quang",
						string_3 = "Kim Quang",
						string_4 = str + "3x"
					},
					new Class35.Struct14
					{
						int_0 = 22,
						string_0 = "B¹ch V©n ®éng",
						string_2 = "B¹ch V©n",
						string_3 = "B¹ch V©n",
						string_4 = str + "3x"
					},
					new Class35.Struct14
					{
						int_0 = 982,
						string_0 = "§iÓm Th­¬ng ®én",
						string_2 = "Òm th­¬ng ®éng tÇng NEW",
						string_3 = null,
						string_4 = str + "4x"
					},
					new Class35.Struct14
					{
						int_0 = 23,
						string_0 = "ThÇn Tiªn ®éng",
						string_2 = "ThÇn Tiªn",
						string_3 = "ThÇn Tiªn",
						string_4 = str + "4x"
					},
					new Class35.Struct14
					{
						int_0 = 5,
						string_0 = "Kinh Hoµng ®éng",
						string_2 = "Kinh Hoµng",
						string_3 = "Kinh Hoµng",
						string_4 = str + "4x"
					},
					new Class35.Struct14
					{
						int_0 = 182,
						string_0 = "NghiÖt Long ®én",
						string_2 = "Öt Long",
						string_3 = "NghiÖt Long",
						string_4 = str + "5x"
					},
					new Class35.Struct14
					{
						int_0 = 24,
						string_0 = "H­ëng Thñy ®éng",
						string_2 = "§Õn H­ëng Thñy",
						string_3 = "H­ëng Thñy",
						string_4 = str + "5x"
					},
					new Class35.Struct14
					{
						int_0 = 981,
						string_0 = "H­ëng Thñy ®éng",
						string_2 = "H­ëng Thñy §éng NEW",
						string_3 = null,
						string_4 = str + "5x"
					},
					new Class35.Struct14
					{
						int_0 = 114,
						string_0 = "108 La H¸n trËn",
						string_2 = "108 La h¸n trËn",
						string_3 = null,
						string_4 = str + "5x"
					},
					new Class35.Struct14
					{
						int_0 = 196,
						string_0 = "D­¬ng Gi¸c ®éng",
						string_2 = "Du¬ng Gi¸c",
						string_3 = null,
						string_4 = str + "6x"
					},
					new Class35.Struct14
					{
						int_0 = 169,
						string_0 = "Long Nh·n ®éng",
						string_2 = "Long Nh·n",
						string_3 = "Long Nh·n",
						string_4 = str + "7x"
					},
					new Class35.Struct14
					{
						int_0 = 142,
						string_0 = Class35.string_33,
						string_2 = "D­îc V­¬ng §éng TÇng 2",
						string_3 = null,
						string_4 = str + "7x"
					}
				};
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000257D8 File Offset: 0x000239D8
		private static void smethod_14()
		{
			string str = "n nhanh n¬i";
			string text = str + "|hµnh th";
			string text2 = str + "|h«n tran";
			string text3 = str + "|M«n ph¸i";
			string text4 = str + "|Tèng Kim";
			string str2 = str + "|cµy cÊp|";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 59,
					string_0 = "Thiªn V­¬ng Ban",
					string_2 = "Thiªn V­¬ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 103,
					string_0 = "ThiÕu L©m ph¸i",
					string_2 = "ThiÕu L©m",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 25,
					string_0 = "§­êng M«n",
					string_2 = "§­êng M«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 183,
					string_0 = "Ngò §éc Gi¸o",
					string_2 = "Ngò §éc",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 13,
					string_0 = "Nga My ph¸i",
					string_2 = "Nga M",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 154,
					string_0 = "Thóy Yªn m«n",
					string_2 = "Thóy Yªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 49,
					string_0 = "Thiªn NhÉn Gi¸o",
					string_2 = "Thiªn NhÉn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 115,
					string_0 = "C¸i Bang",
					string_2 = "C¸i Bang",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 81,
					string_0 = "Vâ §ang Ph¸i",
					string_2 = "Vâ §ang",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 131,
					string_0 = "C«n L«n ph¸i",
					string_2 = "C«n L«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa-S¬n-Ph",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ÊÔ½£¹È",
					string_2 = "Mª cung KiÕm mé"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_4 = str2 + "c«ng 2x"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c thôc ®¹o",
					string_3 = "KiÕm C¸c Thôc §¹o",
					string_4 = str2 + "c«ng 2x"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ phØ ®éng",
					string_2 = "Thæ phØ ®éng",
					string_3 = "Thæ PhØ ®éng",
					string_4 = str2 + "c«ng 3x"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = str2 + "c«ng 3x"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÒm th­¬ng ®éng tÇng 1",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = str2 + "c«ng 4x"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÒm th­¬ng ®éng tÇng 2",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = str2 + "c«ng 4x"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung tÇng 1",
					string_3 = "ThiÕt Th¸p mª cung",
					string_4 = str2 + "c«ng 5x"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "c«ng 5x"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "c«ng 6x"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "c«ng 6x"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "dông thuËt|luyÖn c«ng|7x"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str2 + "c«ng 7x"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch ®éng",
					string_3 = "Nh¹n Th¹ch ®éng",
					string_4 = str2 + "c«ng 8x"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str2 + "c«ng 8x"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "ch©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "c«ng 8x"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|å 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00026578 File Offset: 0x00024778
		private static void smethod_15()
		{
			string text = "thÞ, th«n trÊn,Map 9x";
			string text2 = text + "|hµnh thÞ";
			string text3 = text + "|h«n trang";
			string text4 = text + "|«n ph¸i";
			string text5 = "Tèng Kim|" + text;
			string str = "LuyÖn C«ng S¬ C";
			string str2 = str + "|KÕ";
			string text6 = str2 + "|KÕ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 59,
					string_0 = "Thiªn V­¬ng Ban",
					string_2 = "Thiªn V­¬ng",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 103,
					string_0 = "ThiÕu L©m ph¸i",
					string_2 = "ThiÕu L©m",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 25,
					string_0 = "§­êng M«n",
					string_2 = "§­êng M«n",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 183,
					string_0 = "Ngò §éc Gi¸o",
					string_2 = "Ngò §éc",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 13,
					string_0 = "Nga My ph¸i",
					string_2 = "Nga M",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 154,
					string_0 = "Thóy Yªn m«n",
					string_2 = "Thóy Yªn",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 49,
					string_0 = "Thiªn NhÉn Gi¸o",
					string_2 = "Thiªn NhÉn",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 115,
					string_0 = "C¸i Bang",
					string_2 = "C¸i Bang",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 81,
					string_0 = "Vâ §ang ph¸i",
					string_2 = "Vâ §ang",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 131,
					string_0 = "C«n L«n ph¸i",
					string_2 = "C«n L«n",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vò L¨ng s¬n",
					string_2 = "Vò L¨ng S¬n",
					string_3 = "Vò L¨ng S¬n",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u §«ng",
					string_3 = "Phôc Ng­u §«ng",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng S¬n",
					string_3 = "Thôc C­¬ng S¬n",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u T©y",
					string_3 = "Phôc Ng­u T©y",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn",
					string_3 = "Hoµng Hµ Nguyªn",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn",
					string_3 = null,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "¸c b¸ ®Þa",
					string_3 = null,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = null,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = Class35.string_27,
					string_3 = Class35.string_27,
					string_4 = text6
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(text + "|Êp 90"), false);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000271B4 File Offset: 0x000253B4
		private static void smethod_16()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 999,
					string_0 = "Chî §en",
					string_2 = "Chî §en",
					string_3 = null,
					string_4 = "thÞ vµ th«n"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "Çn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÒm Th­¬ng ®éng",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = "i ®Õn b¶n ®å luyÖn|Êp 8"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("i ®Õn b¶n ®å luyÖn|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", -1), false);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00027928 File Offset: 0x00025B28
		private static void smethod_17()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = "dông thuËt|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = "dông thuËt|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = "dông thuËt|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = "dông thuËt|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "dông thuËt|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = "dông thuËt|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = "dông thuËt|Êp 8"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", -1), false);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00027CCC File Offset: 0x00025ECC
		private static void smethod_18()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 355,
					string_0 = "§Êu Tr­êng Sinh",
					string_2 = "POS|50304,78016,KÕt 1|38592,100992,KÕt 2|49440,99520,KÕt 3|38976,78464,KÕt 4",
					string_4 = "ng Sinh T"
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa S¬n",
					string_4 = "Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = "Map Train|Map luyÖn 3x"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = "Map Train|Map luyÖn 3x"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o §éng",
					string_3 = Class35.string_36,
					string_4 = "Map Train|Map luyÖn 3x"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = "Map Train|Map luyÖn 3x"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = "Map Train|Map luyÖn 4x"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = "Map Train|Map luyÖn 4x"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = "Map Train|Map luyÖn 4x"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = "Thiªn TÇm th¸p tÇng 2",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 40,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "m th¸p tÇng 3",
					string_3 = "Thiªn TÇm th¸p tÇng 3",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "§Þa ®¹o hÇu viªn",
					string_3 = "HËu ViÖn TÝn T­íng Tù",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T",
					string_3 = "Thiªn T",
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "§¸y §éng §×nh Hå TÇng 1",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 67,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "§¸y §éng §×nh Hå TÇng 2",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 116,
					string_0 = "T­êng V©n ®éng",
					string_2 = "Tuêng V©n §éng TÇng 1",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "B¸ §Þa",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 5x"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n T­¬ng D­¬ng",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 1",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­uêng V©n §éng TÇng 2",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o §éng TÇng 4",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn TÇm Th¸p TÇng 4",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 6x"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 149,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt b¸o ®éng tÇng 5",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn l¨ng tÇng 2",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn Giang",
					string_3 = "Tr­êng Giang",
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ §éng TÇng 2",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o ®éng",
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­uîc V­u¬ng §éng TÇng 2",
					string_3 = null,
					string_4 = "Map Train|Map luyÖn 7x"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa m¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "Map Train|Map luyÖn 8x"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "Ch©n nói tr­êng b¹ch",
					string_3 = Class35.string_52,
					string_4 = "Map Train|Map luyÖn 8x"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh khª",
					string_3 = "Thanh Khª",
					string_4 = "Map Train|Map luyÖn 8x"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "ng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "Map Train|Map luyÖn 8x"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = "Map Train|Map luyÖn 8x"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "Du¬ng Trung",
					string_3 = "Du¬ng Trung",
					string_4 = "Map Train|Map luyÖn 8x"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00028964 File Offset: 0x00026B64
		private static void smethod_19()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|43328,100032,ChÝnh Kh|43584,93568,Ngäc N|50080,91424,T­ NiÖm|48576,101088|TriÒu D­",
					string_4 = "Hoa S¬n"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("thÇn hµnh|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00028A0C File Offset: 0x00026C0C
		private static void smethod_20()
		{
			string str = "luyÖn c«ng";
			string text = str + "|hµnh thÞ";
			string text2 = str + "|h«n trang";
			string text3 = str + "|m«n ph¸i";
			string text4 = str + "|h«ng cã cµy";
			string string_ = str + "|- 90";
			string str2 = str + "|- ";
			string text5 = str + "|Méc Nha";
			string text6 = "n¬i ho¹t";
			string text7 = text6 + "|Tèng K";
			string text8 = text6 + "|- Uyªn ¦¬ng";
			string text9 = text6 + "|B¶o Tiªu Th";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1031,
					string_0 = "Sa M¹c 4",
					string_2 = "Sa M¹c 4",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 1032,
					string_0 = "Sa M¹c 5",
					string_2 = "Sa M¹c 5",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 1033,
					string_0 = "Sa M¹c 6",
					string_2 = "Sa M¹c 6",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 200,
					string_0 = "Cæ D­¬ng §éng",
					string_2 = "Cæ D­¬ng",
					string_3 = "Cæ D­¬ng",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c",
					string_3 = Class35.string_59,
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "Ch©n nói",
					string_3 = Class35.string_52,
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Th",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 59,
					string_0 = "Thiªn V­¬ng Ban",
					string_2 = "Thiªn V­¬ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 103,
					string_0 = "ThiÕu L©m ph¸i",
					string_2 = "ThiÕu L©m",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 25,
					string_0 = "§­êng M«n",
					string_2 = "§­êng M«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 183,
					string_0 = "Ngò §éc Gi¸o",
					string_2 = "Ngò §éc",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 13,
					string_0 = "Nga My ph¸i",
					string_2 = "Nga M",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 154,
					string_0 = "Thóy Yªn m«n",
					string_2 = "Thóy Yªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 49,
					string_0 = "Thiªn NhÉn Gi¸o",
					string_2 = "Thiªn NhÉn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 115,
					string_0 = "C¸i Bang",
					string_2 = "C¸i Bang",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 81,
					string_0 = "Vâ §ang ph¸i",
					string_2 = "Vâ §ang",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 131,
					string_0 = "C«n L«n ph¸i",
					string_2 = "C«n L«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str2 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c Thôc",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang",
					string_4 = str2 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vò L¨ng s¬n|Vu L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str2 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy",
					string_4 = str2 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str2 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str2 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str2 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str2 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str2 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str2 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str2 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str2 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Kª Qu¸n ®éng",
					string_3 = "Kª Qu¸n",
					string_4 = str2 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "TÝn T­íng Tù",
					string_3 = "TÝn T­íng Tù",
					string_4 = str2 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = str2 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = str2 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str2 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 194,
					string_0 = "Ngäc Hoa ®éng",
					string_2 = "Ngäc Hoa",
					string_3 = "Ngäc Hoa",
					string_4 = str2 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n MËt",
					string_3 = null,
					string_4 = str2 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng",
					string_3 = null,
					string_4 = str2 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La H¸n trËn",
					string_3 = null,
					string_4 = str2 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = "Thiªn Phô S¬n",
					string_3 = null,
					string_4 = str2 + "1"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = str2 + "1"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = str2 + "1"
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = "H¾c Méc Nhai Na",
					string_2 = "Méc Nhai N|Méc Nhai (N",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = "H¾c Méc Nhai §«",
					string_2 = "Méc Nhai §|Méc Nhai (§",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = "H¾c Méc Nhai B¾",
					string_2 = "Méc Nhai B|Méc Nhai (B",
					string_3 = null,
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 989,
					string_0 = "Uyªn ¦¬ng Cèc",
					string_2 = "POS|49087,99974,V« T×nh|38689,100630,ThiÕt Thñ|39200,78208,L·nh HuyÕt|50171,77970,Truy MÖnh",
					string_4 = text8
				},
				new Class35.Struct14
				{
					int_0 = 1035,
					string_0 = "B¶o Tiªu Thµnh",
					string_2 = "POS|65504,124832,phÝa §«ng|52384,107104,phÝa T©y|53440,124064,phÝa Nam|64640,104288,phÝa B¾c",
					string_4 = text9
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3(text6, -1), false);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002A1CC File Offset: 0x000283CC
		private static void smethod_21()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = "luyÖn c«ng|g cÊp 120"
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = "luyÖn kü n¨ng"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c §Þa|Þa BiÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 200,
					string_0 = "Cæ D­¬ng §éng",
					string_2 = "Cæ D­¬ng",
					string_3 = "Cæ D­¬ng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 140,
					string_0 = "D­îc V­¬ng Cèc",
					string_2 = "D­îc V­¬ng Cèc",
					string_3 = "D­îc V­¬ng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 141,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng §éng (TÇng 1)|D­îc V­¬ng ®éng tÇng 1",
					string_3 = "D­îc V­¬ng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn",
					string_3 = "Hoµng Hµ",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 1)|iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 2)|iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 3)|iÓm Th­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p Mª Cung",
					string_3 = "ThiÕt Th¸p",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 132,
					string_0 = "B¨ng HuyÖt ®éng",
					string_2 = "B¨ng HuyÖt ®éng",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n|MËt ®¹o Nha m«n T­¬ng D­¬ng",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p (TÇng 3)|m th¸p tÇng 3",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La H¸n trËn",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng (TÇng 2)|TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng §éng (TÇng 2)|D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = "luyÖn c«ng|d­íi cÊp 9|Êp 7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|g cÊp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0002B480 File Offset: 0x00029680
		private static void smethod_22()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = null,
					string_4 = Class35.string_70 + "|" + Class35.string_66
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = Class35.string_70 + "|" + Class35.string_66
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = Class35.string_68
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", -1), false);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0002B5F8 File Offset: 0x000297F8
		private static void smethod_23()
		{
			Class35.smethod_22();
			string value = "vÞ trÝ kh¸c";
			int num = 0;
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_4.IndexOf(value) >= 0;
				if (flag)
				{
					bool flag2 = num == 0;
					if (flag2)
					{
						ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
						ptr = Class35.smethod_1(null);
					}
					else
					{
						bool flag3 = num == 1 || num == 2;
						if (flag3)
						{
							Class35.struct14_0[i].int_0 = 959;
							Class35.struct14_0[i].string_0 = "ChiÕn Long §éng";
							Class35.struct14_0[i].string_2 = "ChiÕn Long";
							Class35.struct14_0[i].string_4 = "ChiÕn Long";
							Class35.struct14_0[i].string_3 = null;
						}
						else
						{
							Class35.struct14_0[i].int_0 = -1;
							Class35.struct14_0[i].string_0 = null;
							Class35.struct14_0[i].string_2 = null;
							Class35.struct14_0[i].string_4 = null;
							Class35.struct14_0[i].string_3 = null;
						}
					}
					num++;
				}
			}
			bool flag4 = num < 2;
			if (flag4)
			{
				Class35.Struct14[] struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 959,
						string_0 = "ChiÕn Long §éng",
						string_2 = "ChiÕn Long",
						string_3 = "ChiÕn Long",
						string_4 = "ChiÕn Long"
					},
					Class35.smethod_1(null)
				};
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002B7D8 File Offset: 0x000299D8
		private static void smethod_24()
		{
			string text = "dông thuËt|cÊp 8";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0002BB60 File Offset: 0x00029D60
		private static void smethod_25()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c",
					string_3 = Class35.string_59,
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = "LuyÖn C«ng|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = "LuyÖn C«ng|Êp 8"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_71), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0002BF84 File Offset: 0x0002A184
		private static void smethod_26()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 875,
					string_0 = Class35.string_50,
					string_2 = Class35.string_51,
					string_3 = Class35.string_51,
					string_4 = Class35.string_68
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0002C038 File Offset: 0x0002A238
		private static void smethod_27()
		{
			string str = "luyÖn c«ng|t©n thñ|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 523,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn T­¬ng D",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 521,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Thµnh",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 520,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Ph­îng T",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 525,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn §¹i L",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 524,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn D­¬ng C",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 522,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn BiÖn K",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 526,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn L©m A",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = "vÞ trÝ kh"
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = null,
					string_4 = Class35.string_73 + "|" + Class35.string_66
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = Class35.string_73 + "|" + Class35.string_66
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = "§Êu Tr­êng Sinh",
					string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464|T©y",
					string_4 = "dông thuËt|Sinh Tö"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_71), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002C9E0 File Offset: 0x0002ABE0
		private static void smethod_28()
		{
			string text = "ThÞ --- Th|hµnh thÞ";
			string text2 = "ThÞ --- Th|h«n trang";
			string str = "n b¶n ®å luyÖn c|t©n thñ|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 175,
					string_0 = Class35.string_25,
					string_2 = "T©y S¬n",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Þa biÓu",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("n b¶n ®å luyÖn c|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("n¬i chuyÓn si|vÞ trÝ kh", 55), false);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0002D520 File Offset: 0x0002B720
		private static void smethod_29()
		{
			string string_ = "2x - 9x|cÊp 90";
			string str = "2x - 9x|2x-8x|";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Þa biÓu",
					string_3 = Class35.string_59,
					string_4 = str + "cÊp 80"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "cÊp 80"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "cÊp 80"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "cÊp 80"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "cÊp 80"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str + "Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "Êp 7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002DB94 File Offset: 0x0002BD94
		private static void smethod_30()
		{
			Class35.smethod_29();
			string value = "2x - 9x|cÊp 90";
			string value2 = "2x - 9x|cÊp 90|rang k|rang s";
			string text = "2x - 9x|2x-8x|";
			string str = "dông thuËt|90";
			string text2 = str + "|rang k|rang s";
			string newValue = "1x-8x|";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(value2);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = text2;
				}
				else
				{
					bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf(value);
					if (flag2)
					{
						Class35.struct14_0[i].string_4 = str;
					}
					else
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, newValue);
						}
					}
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002DCBC File Offset: 0x0002BEBC
		private static void smethod_31()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = "luyÖn c«ng|[40"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬",
					string_3 = null,
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "luyÖn c«ng|[70"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = "luyÖn c«ng|[70"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|[90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		private static void smethod_32()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 2,
					string_0 = "Hoa S¬n",
					string_2 = "Hoa S¬n",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 140,
					string_0 = "D­îc V­¬ng Cèc",
					string_2 = "D­îc V­¬ng Cèc",
					string_3 = "D­îc V­¬ng",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o",
					string_3 = "TuyÕt B¸o",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = "dông thuËt|[CÊp|[10"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "H­ëng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T»m",
					string_3 = "Thiªn T©m",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "Mª Cung ThiÕp",
					string_3 = "ThiÕt Th¸p mª",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 149,
					string_0 = Class35.string_36,
					string_2 = "5 TuyÕt B¸o",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 51,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh §éng",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng §éng TÇng 2",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "dông thuËt|[CÊp|[70"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = Class35.string_52,
					string_3 = Class35.string_52,
					string_4 = "dông thuËt|[CÊp|[70|Trang K"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Þa BiÓu",
					string_3 = Class35.string_59,
					string_4 = "dông thuËt|[CÊp|[70|Trang K"
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 1]"
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 1]"
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 1]"
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 1]"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 2]"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 2]"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "MÉu S¬n",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 2]"
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = "UyÓn Phông S¬n",
					string_2 = "UyÓn Phông S¬n",
					string_3 = null,
					string_4 = "dông thuËt|[CÊp|Sinh]|Sinh 2]"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|[CÊp|[90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0002ED24 File Offset: 0x0002CF24
		private static void smethod_33(bool bool_0)
		{
			string str = "dông thuËt|2x |Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				},
				Class35.smethod_1("Sinh T"),
				new Class35.Struct14
				{
					int_0 = 999,
					string_0 = "§Êu Tr­êng Sinh",
					string_2 = "Tr­êng Sinh T",
					string_3 = null,
					string_4 = "Tr­êng Sinh T"
				},
				new Class35.Struct14
				{
					int_0 = 989,
					string_0 = "§Êu Tr­êng §Ém",
					string_2 = "POS|52480,107296,TrÝ 1|57536,106272,TrÝ 2|58816,114112,TrÝ 3|52800,113376,TrÝ 4",
					string_3 = null,
					string_4 = "m M¸u"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa| BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = Class35.string_49,
					string_2 = "L©m Du Quan 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 1001,
					string_0 = Class35.string_49,
					string_2 = "L©m Du Quan 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 1002,
					string_0 = Class35.string_49,
					string_2 = "L©m Du Quan 3",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				}
			};
			bool flag = !bool_0;
			if (flag)
			{
				Class35.struct14_0[0].int_0 = -1;
			}
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0002F590 File Offset: 0x0002D790
		private static void smethod_34()
		{
			Class35.smethod_33(true);
			string str = "dông thuËt|2x |Êp ";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa-S¬n",
					string_4 = "Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 118,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 130,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 6",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				Class35.smethod_1("Sinh T")
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0002F984 File Offset: 0x0002DB84
		private static void smethod_35()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_56,
					string_3 = Class35.string_59,
					string_4 = Class35.string_68
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "POS|46176,93632,Ph¸i 1|49888,97120,Ph¸i 2|49280,93536,Ph¸i 3|47392,99200,Ph¸i 4",
					string_4 = "dông thuËt|nhÆt Qu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0002FA78 File Offset: 0x0002DC78
		private static void smethod_36()
		{
			string str = "dông thuËt";
			string str2 = str + "|luyÖn c«ng|cÊp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Þa biÓu",
					string_3 = Class35.string_59,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch",
					string_3 = "Nh¹n Th¹ch ®éng",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str2 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", 55), false);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00030350 File Offset: 0x0002E550
		private static void smethod_37()
		{
			Class35.smethod_36();
			string str = "dông thuËt";
			string str2 = str + "|luyÖn c«ng";
			string text = str2 + "|rang k";
			string value = str + "|cÊp 90";
			string value2 = str2 + "|rang k|rang s";
			string value3 = str + "|luyÖn c«ng|cÊp ";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 > Class35.struct14_0[i].string_4.IndexOf(value2);
				if (flag)
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(value);
					if (flag2)
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(value3);
						if (flag3)
						{
							Class35.struct14_0[i].int_0 = -1;
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = text;
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = text;
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00030470 File Offset: 0x0002E670
		private static void smethod_38()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ThÝ KiÕm Cèc",
					string_2 = "KiÕm Gia",
					string_3 = null,
					string_4 = "dông thuËt"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = "dông thuËt|T©n Thñ|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "dông thuËt|T©n Thñ|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = "dông thuËt|T©n Thñ|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "dông thuËt|T©n Thñ|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = "dông thuËt|T©n Thñ|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c",
					string_3 = "KiÕm C¸c",
					string_4 = "dông thuËt|T©n Thñ|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = "dông thuËt|T©n Thñ|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = "dông thuËt|T©n Thñ|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ PhØ",
					string_3 = "Thæ PhØ",
					string_4 = "dông thuËt|T©n Thñ|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = "dông thuËt|T©n Thñ|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = "dông thuËt|T©n Thñ|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = "dông thuËt|T©n Thñ|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = "dông thuËt|T©n Thñ|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = "dông thuËt|T©n Thñ|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = "dông thuËt|T©n Thñ|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = "dông thuËt|T©n Thñ|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = "dông thuËt|T©n Thñ|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = "dông thuËt|T©n Thñ|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = "dông thuËt|T©n Thñ|Êp 7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt| 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh|dông thuËt", 55), false);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00030ACC File Offset: 0x0002ECCC
		private static void smethod_39(bool bool_0, bool bool_1 = true, bool bool_2 = true, bool bool_3 = false)
		{
			string str = "g - Thµnh th|";
			string text = str + "ChiÕn Long";
			string text2 = str + "hµnh thÞ";
			string text3 = str + "h«n trang";
			string text4 = str + "Tèng - Kim";
			string str2 = "luyÖn c«ng|";
			string string_ = str2 + "cÊp 90";
			string str3 = str2 + "t©n thñ|cÊp ";
			string str4 = "Ho¹t ®«ng";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = -1
				},
				new Class35.Struct14
				{
					int_0 = -1
				},
				new Class35.Struct14
				{
					int_0 = -1
				},
				new Class35.Struct14
				{
					int_0 = 78,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_9,
					string_2 = Class35.string_9,
					string_3 = Class35.string_9,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 80,
					string_1 = Class35.string_1[4],
					string_0 = Class35.string_10,
					string_2 = Class35.string_10,
					string_3 = Class35.string_10,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 1,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_11,
					string_2 = Class35.string_11,
					string_3 = Class35.string_11,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 162,
					string_1 = Class35.string_1[3],
					string_0 = Class35.string_12,
					string_2 = Class35.string_12,
					string_3 = Class35.string_12,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 11,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_13,
					string_2 = Class35.string_13,
					string_3 = Class35.string_13,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 176,
					string_1 = Class35.string_1[2],
					string_0 = Class35.string_14,
					string_2 = Class35.string_14,
					string_3 = Class35.string_14,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 37,
					string_1 = Class35.string_1[0],
					string_0 = Class35.string_15,
					string_2 = Class35.string_15,
					string_3 = Class35.string_15,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 53,
					string_0 = Class35.string_17,
					string_2 = "Ba L¨ng",
					string_3 = "Ba L¨ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 20,
					string_0 = Class35.string_18,
					string_2 = "Giang T©n",
					string_3 = "Giang T©n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 99,
					string_0 = Class35.string_19,
					string_2 = "VÜnh L¹c",
					string_3 = "VÜnh L¹c",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Chu Tiªn",
					string_3 = "Chu Tiªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 101,
					string_0 = Class35.string_21,
					string_2 = "§¹o H­¬ng",
					string_3 = "§¹o H­¬ng",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 121,
					string_0 = Class35.string_22,
					string_2 = "Long M«n",
					string_3 = "Long M«n",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 153,
					string_0 = Class35.string_23,
					string_2 = "Th¹ch Cæ",
					string_3 = "Th¹ch Cæ",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 174,
					string_0 = Class35.string_24,
					string_2 = "Long TuyÒn",
					string_3 = "Long TuyÒn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 175,
					string_0 = Class35.string_25,
					string_2 = "T©y S¬n",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text4
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			if (bool_2)
			{
				for (int i = 0; i < Class35.struct14_0.Length; i++)
				{
					bool flag = Class35.struct14_0[i].int_0 == -1;
					if (flag)
					{
						ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
						ptr = Class35.smethod_1(str4 + "|Sinh T");
						break;
					}
				}
			}
			if (bool_0)
			{
				for (int j = 0; j < Class35.struct14_0.Length; j++)
				{
					bool flag2 = Class35.struct14_0[j].int_0 == -1;
					if (flag2)
					{
						Class35.struct14_0[j].int_0 = 959;
						Class35.struct14_0[j].string_0 = "ChiÕn Long §éng";
						Class35.struct14_0[j].string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n";
						Class35.struct14_0[j].string_3 = "ChiÕn Long";
						Class35.struct14_0[j].string_4 = text;
						break;
					}
				}
			}
			if (bool_1)
			{
				for (int k = 0; k < Class35.struct14_0.Length; k++)
				{
					bool flag3 = Class35.struct14_0[k].int_0 == -1;
					if (flag3)
					{
						Class35.struct14_0[k].int_0 = -1;
						Class35.struct14_0[k].string_3 = "VANTIEU";
						Class35.struct14_0[k].string_4 = str4 + "|VËn Tiªu";
						break;
					}
				}
			}
			if (bool_3)
			{
				Class35.Struct14[] struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 224,
						string_0 = Class35.string_47,
						string_2 = "Sa M¹c ®Þa|i BiÓu",
						string_3 = Class35.string_59,
						string_4 = str3 + "8"
					},
					new Class35.Struct14
					{
						int_0 = 198,
						string_0 = Class35.string_26,
						string_2 = "Thanh Khª",
						string_3 = "Thanh Khª",
						string_4 = str3 + "8"
					},
					new Class35.Struct14
					{
						int_0 = 320,
						string_0 = Class35.string_27,
						string_2 = "h©n nói Tr­êng B¹ch",
						string_3 = Class35.string_52,
						string_4 = str3 + "8"
					},
					new Class35.Struct14
					{
						int_0 = 181,
						string_0 = Class35.string_28,
						string_2 = "L­ìng Thñy",
						string_3 = "L­ìng Thñy",
						string_4 = str3 + "8"
					},
					new Class35.Struct14
					{
						int_0 = 201,
						string_0 = Class35.string_29,
						string_2 = "B¨ng Hµ",
						string_3 = "B¨ng Hµ",
						string_4 = str3 + "8"
					},
					new Class35.Struct14
					{
						int_0 = 79,
						string_0 = "MËt ®¹o Nha m«n",
						string_2 = "T­¬ng D­¬ng Nha M«n",
						string_3 = null,
						string_4 = str3 + "6"
					},
					new Class35.Struct14
					{
						int_0 = 56,
						string_0 = "S¬n Ph¸i",
						string_2 = "s¬n Ph",
						string_3 = "s¬n Ph",
						string_4 = str3 + "6"
					},
					new Class35.Struct14
					{
						int_0 = 166,
						string_0 = "Thiªn TÇm th¸p",
						string_2 = "m Th¸p tÇng 3",
						string_3 = null,
						string_4 = str3 + "6"
					},
					new Class35.Struct14
					{
						int_0 = 319,
						string_0 = Class35.string_49,
						string_2 = "L©m Du",
						string_3 = Class35.string_49,
						string_4 = str3 + "7"
					},
					new Class35.Struct14
					{
						int_0 = 123,
						string_0 = "L·o Hæ ®éng",
						string_2 = "L·o Hæ",
						string_3 = "L·o Hæ",
						string_4 = str3 + "7"
					},
					new Class35.Struct14
					{
						int_0 = 206,
						string_0 = "TÇn L¨ng tÇng 2",
						string_2 = "TÇn L¨ng tÇng 2",
						string_3 = "TÇn L¨ng tÇng 2",
						string_4 = str3 + "7"
					}
				};
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000316B0 File Offset: 0x0002F8B0
		private static void smethod_40()
		{
			Class35.smethod_39(false, true, false, false);
			string text = "Ho¹t ®«ng]|Tèng - Kim";
			string str = "Ho¹t ®«ng Bang";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				Class35.smethod_1(str + "|Sinh T"),
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = null,
					string_4 = str + "|ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|41216,102784,kÕt 1|49408,102464,kÕt 2|42240,92160,kÕt 3",
					string_4 = str + "|Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, true);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00031860 File Offset: 0x0002FA60
		private static void smethod_41()
		{
			Class35.smethod_39(true, true, true, false);
			string text = "g - Thµnh th|";
			string newValue = "Thµnh  Th«n| Th«n|";
			string str = "Ho¹t ®«ng|Ho¹t ®«ng|";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("ChiÕn Long");
				if (flag)
				{
					Class35.struct14_0[i].string_4 = str + "|ChiÕn Long";
				}
				else
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf("Tèng - Kim");
					if (flag2)
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, newValue);
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = str + "|Tèng Kim";
					}
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00031980 File Offset: 0x0002FB80
		private static void smethod_42()
		{
			string str = "luyÖn c«ng|t©n thñ|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1011,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|41216,102784,kÕt 1|49408,102464,kÕt 2|42240,92160,kÕt 3",
					string_4 = "o¹t B¶o R|Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 1009,
					string_0 = "Khu vùc c©u c¸",
					string_2 = "C©u C¸",
					string_4 = "C©u C¸"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn|L¨ng tÇng",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung",
					string_3 = "ThiÕt Th¸p mª cung",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T",
					string_3 = "Thiªn T",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00032578 File Offset: 0x00030778
		private static void smethod_43()
		{
			Class35.smethod_42();
			string str = "lµm nhiÖm v";
			string str2 = "éng PK";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 != 1009;
				if (flag)
				{
					bool flag2 = Class35.struct14_0[i].int_0 == 1011;
					if (flag2)
					{
						Class35.struct14_0[i].int_0 = 998;
						Class35.struct14_0[i].string_2 = "POS|42560,92384,kÕt 1|41376,101952,kÕt 2|49344,102336,kÕt 3";
						Class35.struct14_0[i].string_4 = str2 + "|Hoa S¬n";
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = str + "|C©u C¸";
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				Class35.smethod_1(str2 + "|Sinh T"),
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = "ChiÕn Long",
					string_4 = str2 + "|ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = str + "|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00032710 File Offset: 0x00030910
		private static void smethod_44()
		{
			Class35.smethod_42();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 875;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -10;
					break;
				}
			}
			string str = "luyÖn c«ng|t©n thñ|Êp ";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vò L¨ng s¬n",
					string_2 = "Vò L¨ng S¬n",
					string_3 = "Vò L¨ng S¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Kª Qu¸n",
					string_3 = "Kª Qu¸n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "TÝn T­íng tö",
					string_3 = "TÝn T­íng Tù",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 194,
					string_0 = "Ngäc Hoa ®éng",
					string_2 = "Ngäc Hoa",
					string_3 = "Ngäc Hoa",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬",
					string_3 = "Tróc T¬",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str + "8"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, true);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00032CE8 File Offset: 0x00030EE8
		private static void smethod_45()
		{
			Class35.smethod_42();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("t©n thñ");
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -1;
					Class35.struct14_0[i].string_2 = null;
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00032D5C File Offset: 0x00030F5C
		private static void smethod_46()
		{
			string str = "dông thuËt|t©n thñ| ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn|L¨ng tÇng",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p mª cung",
					string_3 = "ThiÕt Th¸p mª cung",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T",
					string_3 = "Thiªn T",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000338D0 File Offset: 0x00031AD0
		private static void smethod_47()
		{
			Class35.struct14_0 = null;
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00033934 File Offset: 0x00031B34
		private static void smethod_48()
		{
			string str = "thÇn hµnh c";
			string str2 = "rang k|rang s";
			string text = str + "|Êp 9";
			string str3 = text + "|" + str2;
			string str4 = str3 + "|" + str2;
			string text2 = str4 + "|" + str2;
			string str5 = str + "|new";
			string text3 = str5 + "|" + str2;
			string str6 = str + "|t©n thñ|Êp ";
			string text4 = str + "|luyÖn c«ng mí";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = "Cæ Nam Tr­êng B",
					string_2 = "Cæ B¹ch S¬n N",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1001,
					string_0 = "Cæ B¾c Tr­êng B",
					string_2 = "Cæ B¹ch S¬n B",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1002,
					string_0 = "Cæ M¹c Cao QuËt",
					string_2 = "Cæ M¹c Cao Q",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1003,
					string_0 = "Sa M¹c Cæ 1",
					string_2 = "Cæ Sa M¹c Mª Cung 1",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1004,
					string_0 = "Sa M¹c Cæ 2",
					string_2 = "Cæ Sa M¹c Mª Cung 2",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1005,
					string_0 = "Sa M¹c Cæ 3",
					string_2 = "Cæ Sa M¹c Mª Cung 3",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1006,
					string_0 = "Cæ ®éng D­îc V­",
					string_2 = "Cæ D­îc V­¬ng ®éng tÇng 4",
					string_5 = Class35.string_2,
					string_4 = str5
				},
				new Class35.Struct14
				{
					int_0 = 1007,
					string_0 = "Cæ ®éng Kho¶ La",
					string_2 = "Cæ Kháa Lang",
					string_5 = Class35.string_2,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 1008,
					string_0 = "Cæ L¨ng ®é",
					string_2 = "Cæ Phong L¨ng",
					string_5 = Class35.string_2,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 1009,
					string_0 = "Cæ ®éng TiÕn Có",
					string_2 = "Cæ TiÕn Cóc",
					string_5 = Class35.string_2,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = str6 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str6 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str6 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str6 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str6 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 997,
					string_0 = "TuyÕt S¬n B¾c",
					string_2 = "TuyÕt S¬n B",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Vu S¬n Nam",
					string_2 = "Vu S¬n N",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str6 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str6 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str6 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str6 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str6 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str6 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str6 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str6 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str6 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str6 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str6 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du Q",
					string_3 = Class35.string_49,
					string_4 = str6 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 990,
					string_0 = Class35.string_49,
					string_2 = "L©m Du §",
					string_3 = Class35.string_49,
					string_4 = str6 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str6 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str6 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 989,
					string_1 = Class35.string_1[3],
					string_0 = "Ph­îng Hoµng Th",
					string_2 = "Ph­îng Hoµng Thµnh",
					string_3 = null,
					string_4 = Class35.string_4
				},
				new Class35.Struct14
				{
					int_0 = 977,
					string_0 = "B¶n §å Hßa B×nh",
					string_2 = "Hßa B×nh",
					string_3 = "n b¶n ®å ho¹t",
					string_4 = "n b¶n ®å ho¹t"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(text), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_5 == null || Class35.struct14_0[i].string_5 == string.Empty;
				if (flag)
				{
					Class35.struct14_0[i].string_5 = "ThÇn Hµnh Phï";
				}
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000345AC File Offset: 0x000327AC
		private static void smethod_49()
		{
			string str = "thÇn hµnh";
			string string_ = str + "|Êp 9";
			string str2 = str + "|t©n thñ|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1002,
					string_0 = "Tr­êng B¹ch S¬n T©y",
					string_2 = "Tr­êng B¹ch S¬n T©y",
					string_4 = string_
				},
				new Class35.Struct14
				{
					int_0 = 1003,
					string_0 = "Tr­êng B¹ch S¬n §«ng",
					string_2 = "Tr­êng B¹ch S¬n §«ng",
					string_4 = string_
				},
				new Class35.Struct14
				{
					int_0 = 1004,
					string_0 = "M¹c-Cao-QuËt 2",
					string_2 = "M¹c-Cao-QuËt 2",
					string_4 = string_
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du Q",
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 990,
					string_0 = Class35.string_49,
					string_2 = "L©m Du §",
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str2 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00034D3C File Offset: 0x00032F3C
		private static void smethod_50()
		{
			Class35.smethod_48();
			string str = "dông thuËt|";
			string text = str + "hµnh Cæ §¹i Th";
			string text2 = str + "TÝch M«n ph";
			string str2 = str + "cÊp 90";
			string text3 = str2 + "|Trang k";
			string text4 = str + "cÊp 80";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = "TuyÕt S¬n Nam",
					string_2 = "TuyÕt S¬n N",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = "TuyÕt S¬n B¾c",
					string_2 = "TuyÕt S¬n B",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 997,
					string_0 = "TuyÕt S¬n §«ng",
					string_2 = "TuyÕt S¬n §",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "TuyÕt S¬n T©y",
					string_2 = "TuyÕt S¬n T",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 999,
					string_0 = "Vu S¬n B¾c",
					string_2 = "Vu S¬n B",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = "Vu S¬n Nam",
					string_2 = "Vu S¬n N",
					string_3 = null,
					string_4 = "dông thuËt|c«ng mí"
				},
				new Class35.Struct14
				{
					int_0 = 977,
					string_1 = "b¾c",
					string_0 = "B¶n §å Hßa B×nh",
					string_2 = "cæ thµnh - h¸i qu¶ trung",
					string_4 = str,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 749,
					string_1 = "b¾c",
					string_0 = "Thµnh Cæ Ph­îng",
					string_2 = "Ph­îng T­êng",
					string_3 = "Ph­îng T­êng",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 750,
					string_1 = "®«ng|§«ng",
					string_0 = "Thµnh Cæ Thµnh ",
					string_2 = "Thµnh §«",
					string_3 = "Thµnh §«",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 751,
					string_1 = "®«ng|§«ng",
					string_0 = "Thµnh Cæ BiÖn K",
					string_2 = "BiÖn Kinh",
					string_3 = "BiÖn Kinh",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 752,
					string_1 = "b¾c",
					string_0 = "Thµnh Cæ §¹i Lý",
					string_2 = "§¹i Lý",
					string_3 = "§¹i Lý",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 753,
					string_1 = "b¾c",
					string_0 = "Thµnh Cæ T­¬ng ",
					string_2 = "T­¬ng D­¬ng",
					string_3 = "T­¬ng D­¬ng",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 754,
					string_1 = "t©m",
					string_0 = "Thµnh Cæ D­¬ng",
					string_2 = "D­¬ng Ch©u",
					string_3 = "D­¬ng Ch©u",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 755,
					string_1 = "nam",
					string_0 = "Thµnh Cæ L©m An",
					string_2 = "L©m An",
					string_3 = "L©m An",
					string_4 = text,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 100,
					string_0 = Class35.string_20,
					string_2 = "Thµnh Th",
					string_4 = "Thµnh Th",
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 737,
					string_0 = "Tµng TÝch Thiªn",
					string_2 = "Thiªn V­¬ng",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 736,
					string_0 = "Tµng TÝch ThiÕu",
					string_2 = "ThiÕu L©m",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 739,
					string_0 = "Tµng TÝch §­êng",
					string_2 = "§­êng M«n",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 738,
					string_0 = "Tµng TÝch Ngò §",
					string_2 = "Ngò §éc",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 735,
					string_0 = "Tµng TÝch Nga M",
					string_2 = "Nga M",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 740,
					string_0 = "Tµng TÝch Thóy ",
					string_2 = "Thóy Yªn",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 742,
					string_0 = "Tµng TÝch Thiªn",
					string_2 = "Thiªn NhÉn",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 741,
					string_0 = "Tµng TÝch C¸i B",
					string_2 = "C¸i Bang",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 748,
					string_0 = "Tµng TÝch Vâ §a",
					string_2 = "Vâ §ang",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 747,
					string_0 = "Tµng TÝch C«n L",
					string_2 = "C«n L«n",
					string_4 = text2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 716,
					string_0 = "Cæ B¾c Tr­êng B",
					string_2 = "B¾c Tr­êng B",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 715,
					string_0 = "Cæ Nam Tr­êng B",
					string_2 = "Nam Tr­êng B",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 722,
					string_0 = "Cæ ®éng Kho¶ La",
					string_2 = "Xi V­u",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 720,
					string_0 = "Sa M¹c Cæ 3",
					string_2 = "Sa M¹c Cæ 3",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 718,
					string_0 = "Sa M¹c Cæ 1",
					string_2 = "Sa M¹c Cæ 1",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 719,
					string_0 = "Sa M¹c Cæ 2",
					string_2 = "Sa M¹c Cæ 2",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 723,
					string_0 = "Cæ L¨ng ®é",
					string_2 = "Cæ L¨ng ®é",
					string_4 = str2,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 717,
					string_0 = "Cæ M¹c Cao QuËt",
					string_2 = "M¹c Cao QuËt",
					string_4 = text3,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 721,
					string_0 = "Cæ ®éng D­îc V­",
					string_2 = "D­îc V­¬ng tÇng 4",
					string_4 = text3,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 724,
					string_0 = "Cæ ®éng TiÕn Có",
					string_2 = "TiÕn Cóc",
					string_4 = text3,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 734,
					string_0 = "Ch©n nói Hoang",
					string_2 = "Ch©n nói Hoang",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 731,
					string_0 = "Sa m¹c Cæ",
					string_2 = "Cæ §¹i Sa M¹",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 730,
					string_0 = "Cæ ®éng Thanh k",
					string_2 = "Thanh Khª",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 733,
					string_0 = "Cæ ®éng L­ìng T",
					string_2 = "L­ìng Thñy",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 728,
					string_0 = "Cæ ®éng B¨ng Hµ",
					string_2 = "B¨ng Hµ",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 727,
					string_0 = "Cæ ®éng Vò L¨ng",
					string_2 = "Vò L¨ng",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 725,
					string_0 = "Cæ ®éng D­¬ng T",
					string_2 = "D­¬ng Trung",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 729,
					string_0 = "Cæ ®éng Nh¹n Th",
					string_2 = "Nh¹n Th¹ch",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 726,
					string_0 = "Cæ ®éng Phi Thi",
					string_2 = "Phi Thiªn",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 732,
					string_0 = "Cæ ®éng Phï Dun",
					string_2 = "Phï Dung",
					string_4 = text4,
					string_5 = Class35.string_2
				},
				new Class35.Struct14
				{
					int_0 = 714,
					string_0 = "Cæ ®éng S¬n B¶o",
					string_2 = "S¬n B¶o",
					string_4 = text4,
					string_5 = Class35.string_2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_5 == null || Class35.struct14_0[i].string_5 == string.Empty;
				if (flag)
				{
					Class35.struct14_0[i].string_5 = "ThÇn Hµnh Phï";
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00035C1C File Offset: 0x00033E1C
		private static void smethod_51()
		{
			string string_ = "dông thuËt|Êp 9";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_56,
					string_3 = "Sa M¹c Mª",
					string_4 = string_
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00035CCC File Offset: 0x00033ECC
		private static void smethod_52(bool bool_0 = false)
		{
			string str = "luyÖn c«ng";
			string string_ = str + "|cÊp 9";
			string str2 = str + "|cÊp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 151,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 7",
					string_3 = null,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha m«n",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str2 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			bool flag = !bool_0;
			if (!flag)
			{
				Class35.Struct14[] struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 179,
						string_0 = "La Tiªu s¬n",
						string_2 = "La Tiªu s¬n",
						string_3 = "La Tiªu s¬n",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 70,
						string_0 = "Vu L¨ng s¬n",
						string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
						string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 3,
						string_0 = "KiÕm C¸c T©y B¾",
						string_2 = "KiÕm C¸c T©y B",
						string_3 = "KiÕm C¸c",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 14,
						string_0 = "M·nh Hæ ®éng",
						string_2 = "M·nh Hæ",
						string_3 = "M·nh Hæ",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 19,
						string_0 = "KiÕm C¸c T©y Na",
						string_2 = "KiÕm C¸c T©y Nam",
						string_3 = "KiÕm C¸c",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 43,
						string_0 = "KiÕm C¸c Trung",
						string_2 = "KiÕm C¸c Trung Nguyªn",
						string_3 = null,
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 71,
						string_0 = "B¹ch Thñy ®éng",
						string_2 = "B¹ch Thñy",
						string_3 = "B¹ch Thñy ®éng",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 83,
						string_0 = "Háa Lang ®éng",
						string_2 = "Háa Lang",
						string_3 = "Háa Lang ®éng",
						string_4 = str2 + "2"
					},
					new Class35.Struct14
					{
						int_0 = 73,
						string_0 = "Phôc L­u ®éng",
						string_2 = "Phôc L­u",
						string_3 = "Phôc L­u ®éng",
						string_4 = str2 + "2"
					}
				};
				for (int i = 0; i < Class35.struct14_0.Length; i++)
				{
					bool flag2 = Class35.struct14_0[i].int_0 == 76;
					if (flag2)
					{
						Class35.struct14_0[i].int_0 = 207;
						Class35.struct14_0[i].string_0 = "TÇn L¨ng tÇng 3";
						Class35.struct14_0[i].string_2 = "TÇn L¨ng tÇng 3";
						Class35.struct14_0[i].string_3 = null;
						Class35.struct14_0[i].string_4 = str2 + "8";
					}
					else
					{
						bool flag3 = Class35.struct14_0[i].int_0 != 123;
						if (flag3)
						{
							bool flag4 = Class35.struct14_0[i].int_0 == 206;
							if (flag4)
							{
								Class35.struct14_0[i].int_0 = 76;
								Class35.struct14_0[i].string_0 = "S¬n B¶o ®éng";
								Class35.struct14_0[i].string_2 = "S¬n B¶o";
								Class35.struct14_0[i].string_3 = "S¬n B¶o";
								Class35.struct14_0[i].string_4 = str2 + "7";
							}
						}
						else
						{
							Class35.struct14_0[i].int_0 = 9;
							Class35.struct14_0[i].string_0 = "Tr­êng Giang Ng";
							Class35.struct14_0[i].string_2 = "Tr­uêng Nguyªn|Tr­êng Giang";
							Class35.struct14_0[i].string_3 = "Tr­êng Giang";
							Class35.struct14_0[i].string_4 = str2 + "7";
						}
					}
				}
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00036B18 File Offset: 0x00034D18
		private static void smethod_53()
		{
			string str = "thÇn hµnh";
			string str2 = str + "|c luyÖn c";
			string str3 = str2 + "|cÊp ";
			string string_ = str3 + "9";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				Class35.smethod_1(null),
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str3 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str3 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = str3 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = str3 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str3 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = str3 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "m Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str3 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str3 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str3 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha m«n",
					string_3 = null,
					string_4 = str3 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str3 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str3 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str3 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str3 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str3 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str3 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00037410 File Offset: 0x00035610
		private static void smethod_54()
		{
			Class35.smethod_53();
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa-S¬n",
					string_4 = "Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000374C4 File Offset: 0x000356C4
		private static void smethod_55()
		{
			string str = "luyÖn c«ng|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 151,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 7",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 207,
					string_0 = "TÇn L¨ng tÇng 3",
					string_2 = "TÇn L¨ng tÇng 3",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n|Vò Di s¬n",
					string_3 = "Vò Di s¬n|Vò Di s¬n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u S¬n §«ng",
					string_3 = "Phôc Ng­u s¬n  nam",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 136,
					string_0 = "Kho¸i Ho¹t L©m",
					string_2 = "Kho¸i Ho¹t L©m",
					string_3 = "Sa M¹c",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 141,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 1",
					string_3 = "D­îc V­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 1",
					string_3 = "TuyÕt B¸o",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn §Çu",
					string_3 = "Hoµng Hµ",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Mª cung Kª Qu¸n",
					string_3 = "Kª Qu¸n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 135,
					string_0 = "KiÕn TÝnh Phong",
					string_2 = "KiÕn TÝnh Phong s¬n",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 168,
					string_0 = "Phông Nh·n ®éng",
					string_2 = "Phông Nh·n",
					string_3 = "Phông Nh·n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 180,
					string_0 = "Long Cung ®éng",
					string_2 = "Long Cung",
					string_3 = "Long Cung",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 1|th¸p mª cung tÇng 1",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 39,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 2|th¸p mª cung tÇng 2",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 40,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 3|th¸p mª cung tÇng 3",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "¸y §éng §×nh Hå TÇng 1",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 67,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "¸y §éng §×nh Hå TÇng 2",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 116,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 1",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 1",
					string_3 = "L­u Tiªn ®éng",
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 132,
					string_0 = "B¨ng HuyÖt ®éng",
					string_2 = "B¨ng HuyÖt ®éng",
					string_3 = null,
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 194,
					string_0 = "Ngäc Hoa ®éng",
					string_2 = "Ngäc Hoa",
					string_3 = "Ngäc Hoa",
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "¸c b¸ ®ia ®¹o",
					string_3 = null,
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "TÝn T­íng tö",
					string_3 = "TÝn T­íng Tù",
					string_4 = str + "5|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 51,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh ®éng tÇng 1",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 52,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 158,
					string_0 = "Mª cung cÊm ®Þa",
					string_2 = "Mª cung cÊm ®ia",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha m«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 118,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 119,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 4",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 126,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 127,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 128,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 4",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 4",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 1",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c §éng",
					string_3 = null,
					string_4 = str + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 120,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 5",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 129,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 5",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 130,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 6",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 897,
					string_0 = "Casio Las Vegas",
					string_2 = "Casio",
					string_3 = null,
					string_4 = "Casio"
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y",
					string_4 = "Hoa S¬n"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0003943C File Offset: 0x0003763C
		private static void smethod_56()
		{
			string text = "luyÖn c«ng";
			string text2 = text + "|Êp ";
			string text3 = "thÇn hµnh";
			text3 + "|Tèng Kim";
			string text4 = text3 + "|n n¬i luyÖn|";
			text3 + "|n n¬i luyÖn|";
			Class35.smethod_55();
			int[] array = new int[]
			{
				14,
				71,
				83,
				73,
				92,
				74,
				136,
				145,
				4,
				122,
				6,
				91,
				168,
				180,
				5,
				39,
				40,
				66,
				67,
				116,
				125,
				147,
				194,
				12,
				51,
				52,
				158,
				126,
				127,
				128,
				147,
				26,
				196,
				9,
				27,
				129,
				130,
				897,
				998,
				959
			};
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < array.Length; j++)
				{
					bool flag2 = Class35.struct14_0[i].int_0 == array[j];
					if (flag2)
					{
						flag = true;
						break;
					}
				}
				bool flag3 = flag;
				if (flag3)
				{
					Class35.struct14_0[i].int_0 = 0;
					Class35.struct14_0[i].string_4 = null;
					Class35.struct14_0[i].string_2 = null;
					Class35.struct14_0[i].string_3 = null;
					Class35.struct14_0[i].string_0 = null;
				}
				else
				{
					bool flag4 = Class35.struct14_0[i].string_4.IndexOf(text2 + "9") != 0;
					if (flag4)
					{
						bool flag5 = Class35.struct14_0[i].string_4.IndexOf(text2) == 0;
						if (flag5)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text2, text4);
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, text3);
					}
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 1",
					string_3 = "L­u Tiªn ®éng",
					string_4 = text4 + "6"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00039678 File Offset: 0x00037878
		private static bool smethod_57(int int_3, int[] int_4)
		{
			for (int i = 0; i < int_4.Length; i++)
			{
				bool flag = int_4[i] == int_3;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000396B0 File Offset: 0x000378B0
		private static void smethod_58()
		{
			string str = "luyÖn c«ng|Êp ";
			string str2 = "|rang k|rang s";
			string text = "luyÖn c«ng|Êp 90";
			string text2 = "luyÖn c«ng|Êp 90" + str2;
			string str3 = "luyÖn c«ng|t©n thñ|cÊp ";
			Class35.smethod_55();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "9|rang");
				if (flag)
				{
					Class35.struct14_0[i].string_4 = text2;
				}
				else
				{
					bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "9");
					if (flag2)
					{
						Class35.struct14_0[i].string_4 = text;
					}
					else
					{
						bool flag3 = 0 > Class35.struct14_0[i].string_4.IndexOf(str + "8");
						if (flag3)
						{
							bool flag4 = 0 > Class35.struct14_0[i].string_4.IndexOf(str + "7");
							if (flag4)
							{
								bool flag5 = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "6");
								if (flag5)
								{
									string str4 = str3 + "6";
									bool flag6 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
									{
										26,
										126,
										127,
										128,
										147,
										196
									});
									if (flag6)
									{
										str4 += str2;
									}
									Class35.struct14_0[i].string_4 = str4;
								}
								else
								{
									bool flag7 = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "5");
									if (flag7)
									{
										string str5 = str3 + "5";
										bool flag8 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
										{
											116,
											125,
											132,
											147,
											163,
											12,
											194
										});
										if (flag8)
										{
											str5 += str2;
										}
										Class35.struct14_0[i].string_4 = str5;
									}
									else
									{
										bool flag9 = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "4");
										if (flag9)
										{
											string str6 = str3 + "4";
											bool flag10 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
											{
												91,
												135,
												168,
												180
											});
											if (flag10)
											{
												str6 += str2;
											}
											Class35.struct14_0[i].string_4 = str6;
										}
										else
										{
											bool flag11 = 0 > Class35.struct14_0[i].string_4.IndexOf(str + "3");
											if (flag11)
											{
												bool flag12 = 0 <= Class35.struct14_0[i].string_4.IndexOf(str + "2");
												if (flag12)
												{
													Class35.struct14_0[i].string_4 = str3 + "2";
												}
											}
											else
											{
												string str7 = str3 + "3";
												bool flag13 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
												{
													136,
													141,
													145
												});
												if (flag13)
												{
													str7 += str2;
												}
												Class35.struct14_0[i].string_4 = str7;
											}
										}
									}
								}
							}
							else
							{
								string str8 = str3 + "7";
								bool flag14 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
								{
									129,
									130,
									142
								});
								if (flag14)
								{
									str8 += str2;
								}
								Class35.struct14_0[i].string_4 = str8;
							}
						}
						else
						{
							string str9 = str3 + "8";
							bool flag15 = Class35.smethod_57(Class35.struct14_0[i].int_0, new int[]
							{
								181,
								199,
								205,
								207,
								204
							});
							if (flag15)
							{
								str9 += str2;
							}
							Class35.struct14_0[i].string_4 = str9;
						}
					}
				}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00039B24 File Offset: 0x00037D24
		private static void smethod_59()
		{
			string str = "thÇn hµnh|";
			string str2 = str + "n¬i luyÖn|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				Class35.smethod_1(null),
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang ®éng",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n|Vò Di s¬n",
					string_3 = "Vò Di s¬n|Vò Di s¬n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn §Çu",
					string_3 = "Hoµng Hµ",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = null,
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 1",
					string_3 = "ThiÕt Th¸p",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 39,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 2",
					string_3 = null,
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 40,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 51,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh ®éng tÇng 1",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 52,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 158,
					string_0 = "Mª cung cÊm ®Þa",
					string_2 = "Mª cung cÊm ®ia",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "MËt ®¹o Nha m«n T­¬ng D­¬ng",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 118,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 119,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 4",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 126,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 127,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 3",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 128,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 4",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 4",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 1",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c §éng",
					string_3 = null,
					string_4 = str2 + "6|rang sau"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 120,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 5",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 129,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 5",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 130,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 6",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str2 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0003AE34 File Offset: 0x00039034
		private static void smethod_60()
		{
			Class35.smethod_55();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 != 336;
				if (flag)
				{
					bool flag2 = Class35.struct14_0[i].int_0 == 959;
					if (flag2)
					{
						Class35.struct14_0[i].int_0 = -1;
					}
				}
				else
				{
					Class35.struct14_0[i].string_2 = "Phong L¨ng";
				}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0003AEC4 File Offset: 0x000390C4
		private static void smethod_61()
		{
			string text = "luyÖn c«ng|80";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				Class35.smethod_1(null),
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­¬ng Thñy|L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2("Tèng Kim"), false);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0003B1CC File Offset: 0x000393CC
		private static void smethod_62(bool bool_0 = false, bool bool_1 = false)
		{
			Class35.smethod_55();
			Class35.Struct14[] array = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y",
					string_4 = "Hoa S¬n"
				},
				new Class35.Struct14
				{
					int_0 = 2,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa S¬n",
					string_4 = "Hoa S¬n"
				}
			};
			bool flag = !bool_1;
			if (flag)
			{
				array[1].int_0 = -1;
			}
			Class35.smethod_0(ref Class35.struct14_0, array, false);
			if (bool_0)
			{
				int num = 0;
				for (;;)
				{
					bool flag2 = num < Class35.struct14_0.Length;
					if (!flag2)
					{
						goto IL_F2;
					}
					bool flag3 = Class35.struct14_0[num].int_0 == 959;
					if (flag3)
					{
						break;
					}
					num++;
				}
				ref Class35.Struct14 ptr = ref Class35.struct14_0[num];
				ptr = Class35.smethod_1(null);
				IL_F2:;
			}
			else
			{
				array = new Class35.Struct14[]
				{
					Class35.smethod_1(null)
				};
				Class35.smethod_0(ref Class35.struct14_0, array, false);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0003B314 File Offset: 0x00039514
		private static void smethod_63()
		{
			Class35.smethod_55();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 959;
				if (flag)
				{
					Class35.struct14_0[i] = default(Class35.Struct14);
					break;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 984,
					string_0 = "TÇn Thñy Hoµng",
					string_2 = "POS|43360,113376,Thanh Long|40960,113408,Chu T­íc|43392,110944,HuyÒn V|40992,110944,Kú L©n",
					string_4 = "L¨ng Mé"
				},
				Class35.smethod_1(null)
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0003B3D4 File Offset: 0x000395D4
		private static void smethod_64()
		{
			Class35.smethod_55();
			int i = 0;
			while (i < Class35.struct14_0.Length)
			{
				bool flag = Class35.struct14_0[i].int_0 != 959;
				if (!flag)
				{
					goto IL_53;
				}
				bool flag2 = Class35.struct14_0[i].int_0 != 175;
				if (!flag2)
				{
					goto IL_53;
				}
				IL_69:
				i++;
				continue;
				IL_53:
				Class35.struct14_0[i].string_2 = "ChiÕn Long";
				goto IL_69;
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 991,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0003B4C0 File Offset: 0x000396C0
		private static void smethod_65()
		{
			Class35.smethod_55();
			string str = "b¶n ®å míi";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = str,
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = str + "|rang ",
					string_4 = null
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = str + "|rang ",
					string_4 = null
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0003B7AC File Offset: 0x000399AC
		private static void smethod_66(bool bool_0)
		{
			Class35.smethod_55();
			string str = "luyÖn c«ng|Êp ";
			string text = "dông thuËt|cÊp 9";
			string str2 = "dông thuËt|n¬i luyÖn c|cÊp ";
			if (bool_0)
			{
				str2 = "T©n Thñ|luyÖn c«ng cÊp ";
			}
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 175;
				if (flag)
				{
					ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
					ptr = Class35.smethod_1(null);
				}
				else
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(str + "9");
					if (flag2)
					{
						for (int j = 2; j < 9; j++)
						{
							bool flag3 = Class35.struct14_0[i].string_4 == str + j.ToString();
							if (flag3)
							{
								Class35.struct14_0[i].string_4 = str2 + j.ToString();
								break;
							}
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = text;
					}
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 539,
					string_0 = "Tr­êng Ca M«n c",
					string_2 = null,
					string_3 = "Ca M«n",
					string_4 = null
				},
				Class35.smethod_1(null)
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0003B950 File Offset: 0x00039B50
		private static void smethod_67()
		{
			Class35.smethod_55();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 959;
				if (flag)
				{
					Class35.struct14_0[i].string_4 = "N¬i T×m H";
				}
				bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf("luyÖn c«ng");
				if (flag2)
				{
					string[] array = Class35.struct14_0[i].string_4.Split(new char[]
					{
						'|'
					});
					bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf("9");
					if (flag3)
					{
						Class35.struct14_0[i].string_4 = "b¶n ®å 90";
					}
					else
					{
						Class35.struct14_0[i].string_4 = "b¶n ®å cµy";
					}
					for (int j = 1; j < array.Length; j++)
					{
						ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
						ptr.string_4 = ptr.string_4 + "|" + array[j];
					}
				}
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0003BA94 File Offset: 0x00039C94
		private static void smethod_68()
		{
			Class35.smethod_55();
			char c = '\u0001';
			int i = 0;
			while (i < Class35.struct14_0.Length)
			{
				bool flag = Class35.struct14_0[i].int_0 == 959;
				if (flag)
				{
					Class35.struct14_0[i].string_4 = string.Concat(new string[]
					{
						"N¬i",
						c.ToString(),
						"T×m",
						c.ToString(),
						"H"
					});
					Class35.struct14_0[i].string_2 = string.Concat(new string[]
					{
						"La",
						c.ToString(),
						"Tiªu|Vò",
						c.ToString(),
						"Di|T­êng",
						c.ToString(),
						"V©n"
					});
				}
				bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(Class35.string_4);
				if (flag2)
				{
					bool flag3 = 0 > Class35.struct14_0[i].string_4.IndexOf(Class35.string_5);
					if (flag3)
					{
						bool flag4 = 0 > Class35.struct14_0[i].string_4.IndexOf(Class35.string_6);
						if (flag4)
						{
							bool flag5 = 0 > Class35.struct14_0[i].string_4.IndexOf("luyÖn c«ng");
							if (!flag5)
							{
								string[] array = Class35.struct14_0[i].string_4.Split(new char[]
								{
									'|'
								});
								bool flag6 = 0 > Class35.struct14_0[i].string_4.IndexOf("9");
								if (flag6)
								{
									Class35.struct14_0[i].string_4 = string.Concat(new string[]
									{
										"b¶n",
										c.ToString(),
										"®å",
										c.ToString(),
										"cµy"
									});
									for (int j = 1; j < array.Length; j++)
									{
										ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
										ptr.string_4 = ptr.string_4 + "|" + array[j];
									}
								}
								else
								{
									Class35.struct14_0[i].string_4 = string.Concat(new string[]
									{
										"b¶n",
										c.ToString(),
										"®å",
										c.ToString(),
										"90"
									});
									for (int k = 1; k < array.Length; k++)
									{
										ref Class35.Struct14 ptr2 = ref Class35.struct14_0[i];
										ptr2.string_4 = ptr2.string_4 + "|" + array[k].Replace(' ', '\u0001');
									}
									bool flag7 = Class35.struct14_0[i].string_2 != null && Class35.struct14_0[i].string_2.Length > 0;
									if (flag7)
									{
										Class35.struct14_0[i].string_2 = Class35.struct14_0[i].string_2.Replace(' ', '\u0001');
									}
								}
							}
						}
						else
						{
							Class35.struct14_0[i].string_4 = Class35.string_3 + "|«n" + c.ToString() + "ph¸i";
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = Class35.string_3 + "|Th«n" + c.ToString() + "trang";
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = Class35.string_3 + "|hµnh" + c.ToString() + "thÞ";
					bool flag8 = Class35.struct14_0[i].string_2 != null && Class35.struct14_0[i].string_2.Length > 0;
					if (flag8)
					{
						Class35.struct14_0[i].string_2 = Class35.struct14_0[i].string_2.Replace(' ', '\u0001');
					}
				}
				IL_420:
				i++;
				continue;
				goto IL_420;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0003BED8 File Offset: 0x0003A0D8
		private static void smethod_69(bool bool_0 = false)
		{
			string str = "N¬i Muèn|";
			string string_ = str + "hµnh thÞ";
			string string_2 = str + "h«n trang";
			string string_3 = str + "«n ph¸i";
			string text = str + "Êp 9";
			text + "|rang s|rang k";
			string str2 = "N¬i Muèn|n 10 => 8|c«ng ";
			string string_4 = "TÝnh N¨ng|Thao T¸c|" + Class35.string_7;
			if (bool_0)
			{
				string_4 = str + "|" + Class35.string_7;
			}
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = "N¬i Muèn|å Míi"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "a M¹c ®Þa|i BiÓu",
					string_3 = "a M¹c Mª Cung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "T©y B¾c",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c trung",
					string_3 = null,
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu S¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o",
					string_3 = Class35.string_36,
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = null,
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p",
					string_3 = "Thiªn TÇm th¸p",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n MËt",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c §éng",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 180,
					string_0 = "Long Cung ®éng",
					string_2 = "Long Cung",
					string_3 = "Long Cung",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ThÝ KiÕm Cèc",
					string_2 = "KiÕm Gia Mª Cung",
					string_3 = null,
					string_4 = "TÝnh N¨ng"
				},
				new Class35.Struct14
				{
					int_0 = 934,
					string_0 = "Thiªn Tr× MËt C¶nh",
					string_2 = "Thiªn Tr× MËt C¶nh",
					string_4 = "TÝnh N¨ng"
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "T­ Qu¸ Nhai",
					string_2 = "n T­ Qu¸ Nhai",
					string_4 = "TÝnh N¨ng"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "TÝnh N¨ng|VËn Tiªu|Hé Tèn"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(text), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_3), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(string_4), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("TÝnh N¨ng|NhiÖm Vô B¾c", -1), false);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0003D478 File Offset: 0x0003B678
		private static void smethod_70()
		{
			Class35.smethod_69(false);
			string str = "N¬i Muèn";
			string value = str + "|Êp 9";
			string text = "N¬i Muèn|n 10 => 8|c«ng ";
			string text2 = str + "|LuyÖn C«n|CÊp ";
			string text3 = text2 + "9|rang s|rang k";
			string str2 = "TÝnh N¨ng";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 179;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -2;
				}
				else
				{
					bool flag2 = Class35.struct14_0[i].int_0 != -1;
					if (flag2)
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(value);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = (Class35.struct14_0[i].string_4 = text3);
						}
						else
						{
							bool flag4 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
							if (flag4)
							{
								Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, text2);
							}
						}
					}
					else
					{
						Class35.struct14_0[i].string_3 = "VANTIEU";
						Class35.struct14_0[i].string_4 = str2 + "|VËn Tiªu|Hé Tèn";
					}
				}
			}
			string str3 = "HD Bang Vµ ¡n Ev";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1005,
					string_0 = "V­ên §µo",
					string_2 = "V­ên §µo 1",
					string_3 = null,
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1006,
					string_0 = "V­ên §µo 2",
					string_2 = "V­ên §µo 2",
					string_3 = null,
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = str3 + "|HD Bang Hoi"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "ChuyÓn Bao L",
					string_3 = "La Tiªu s¬n",
					string_4 = str2 + "|Hé Tèng"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = str2 + "|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
		private static void smethod_71(bool bool_0 = false)
		{
			Class35.smethod_69(false);
			string str = "Ho¹t §éng";
			string str2 = "§Æc BiÖt";
			Class35.Struct14 @struct = default(Class35.Struct14);
			if (bool_0)
			{
				@struct = new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = str2 + "|ChiÕn Long"
				};
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				@struct,
				new Class35.Struct14
				{
					int_0 = 1004,
					string_0 = "§¹i ChiÕn V­ên ",
					string_2 = "POS|58368,109056,§«ng|51840,101920,T©y|51616,109152,Nam|58176,101760,B¾c",
					string_3 = "ChiÕn V­ên",
					string_4 = str + "|Vuån "
				},
				new Class35.Struct14
				{
					int_0 = 1005,
					string_0 = "Map ¡n Ch¬i Bó ",
					string_2 = "Bó §¸ Eve",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 1006,
					string_0 = "ThÇn Cç Tr­êng ",
					string_2 = "Thµnh Cç",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 1007,
					string_0 = "§¶o §µo Hoa",
					string_2 = "§µo Hoa",
					string_3 = null,
					string_4 = str2
				},
				Class35.smethod_1(str + "|Êu Tr­êng")
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0003D974 File Offset: 0x0003BB74
		private static void smethod_72(bool bool_0 = false)
		{
			Class35.smethod_69(false);
			string str = "N¬i Muèn";
			string text = str + "|Êp 9";
			string value = text + "|rang s|rang k";
			string text2 = "N¬i Muèn|n 10 => 8|c«ng ";
			string text3 = str + "|LuyÖn C«n|CÊp ";
			string str2 = text3 + "9";
			string text4 = str2 + "|rang s|rang k";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(value);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = (Class35.struct14_0[i].string_4 = text4);
				}
				else
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(text);
					if (flag2)
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text2);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text2, text3);
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = (Class35.struct14_0[i].string_4 = str2);
					}
				}
			}
			if (bool_0)
			{
				string str3 = str + "|boss H";
				string str4 = str3 + "|rang k";
				string text5 = str4 + "|rang k";
				Class35.Struct14[] struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 202,
						string_0 = "Phï Dung ®éng",
						string_2 = "Phï Dung",
						string_3 = "Phï Dung",
						string_4 = str3
					},
					new Class35.Struct14
					{
						int_0 = 76,
						string_0 = "S¬n B¶o ®éng",
						string_2 = "S¬n B¶o",
						string_3 = "S¬n B¶o",
						string_4 = str3
					},
					new Class35.Struct14
					{
						int_0 = 10,
						string_0 = "Nh¹n Th¹ch ®éng",
						string_2 = "Nh¹n Th¹ch",
						string_3 = "Nh¹n Th¹ch",
						string_4 = str3
					},
					new Class35.Struct14
					{
						int_0 = 198,
						string_0 = Class35.string_26,
						string_2 = "Thanh Khª",
						string_3 = "Thanh Khª",
						string_4 = str3
					},
					new Class35.Struct14
					{
						int_0 = 199,
						string_0 = "Vò L¨ng ®éng",
						string_2 = "Vò L¨ng",
						string_3 = "Vò L¨ng",
						string_4 = str3
					},
					new Class35.Struct14
					{
						int_0 = 204,
						string_0 = "Phi Thiªn ®éng",
						string_2 = "Phi Thiªn",
						string_3 = "Phi Thiªn",
						string_4 = str4
					},
					new Class35.Struct14
					{
						int_0 = 203,
						string_0 = "V« Danh ®éng",
						string_2 = "V« Danh",
						string_3 = "V« Danh",
						string_4 = str4
					},
					new Class35.Struct14
					{
						int_0 = 181,
						string_0 = Class35.string_28,
						string_2 = "ng Thñy|L­´ng Thñy",
						string_3 = "L­ìng Thñy",
						string_4 = str4
					},
					new Class35.Struct14
					{
						int_0 = 205,
						string_0 = "D­¬ng Trung ®én",
						string_2 = "¬ng Trung",
						string_3 = "¬ng Trung",
						string_4 = text5
					},
					new Class35.Struct14
					{
						int_0 = 224,
						string_0 = Class35.string_47,
						string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
						string_3 = Class35.string_59,
						string_4 = text5
					},
					new Class35.Struct14
					{
						int_0 = 342,
						string_0 = "Vi s¬n ®¶o",
						string_2 = "Vi S¬n|T©y S¬n",
						string_3 = null,
						string_4 = text5
					},
					new Class35.Struct14
					{
						int_0 = 341,
						string_0 = "M¹c B¾c Th¶o Ng",
						string_2 = "M¹c B¾c T",
						string_3 = null,
						string_4 = text5
					}
				};
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0003DEA0 File Offset: 0x0003C0A0
		private static void smethod_73()
		{
			Class35.smethod_69(false);
			string str = "LuyÖn C«ng";
			string text = "TÝnh N¨ng";
			string text2 = "N¬i Muèn|Êp 9";
			string value = text2 + "|rang s|rang k";
			string str2 = str + "|Êp 9";
			string text3 = str2 + "|rang s|rang k";
			string text4 = "N¬i Muèn|n 10 => 8|c«ng ";
			string newValue = str + "|10 §Õn 8|c«ng ";
			string text5 = "N¬i Muèn|";
			string newValue2 = "ThÞ - Th«n|";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(value);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = (Class35.struct14_0[i].string_4 = text3);
				}
				else
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(text2);
					if (flag2)
					{
						bool flag3 = 0 > Class35.struct14_0[i].string_4.IndexOf(text4);
						if (flag3)
						{
							bool flag4 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text5);
							if (flag4)
							{
								Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text5, newValue2);
							}
							else
							{
								bool flag5 = Class35.struct14_0[i].string_4 == text || Class35.struct14_0[i].string_4.IndexOf(text) == 0;
								if (flag5)
								{
									Class35.struct14_0[i].int_0 = -1;
									Class35.struct14_0[i].string_3 = null;
								}
							}
						}
						else
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text4, newValue);
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = (Class35.struct14_0[i].string_4 = str2);
					}
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0003E0E0 File Offset: 0x0003C2E0
		private static void smethod_74()
		{
			Class35.smethod_69(false);
			string text = "TÝnh N¨ng";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_4 == text || Class35.struct14_0[i].string_4.IndexOf(text) == 0;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -1;
					Class35.struct14_0[i].string_2 = null;
					Class35.struct14_0[i].string_0 = null;
					Class35.struct14_0[i].string_4 = null;
				}
			}
			string str = "ho¹t ®éng|Ho¹t §éng";
			string text2 = "N¬i Muèn|cÊp 90|Æc BiÖt";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = str + "|ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ThÝ KiÕm Cèc",
					string_2 = "KiÕm Gia Mª Cung",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "n T­ Qu¸ Nhai",
					string_2 = "n T­ Qu¸ Nhai",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = text2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0003E3F0 File Offset: 0x0003C5F0
		private static void smethod_75()
		{
			Class35.smethod_74();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("10 => 8");
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -1;
					Class35.struct14_0[i].string_2 = null;
					Class35.struct14_0[i].string_0 = null;
					Class35.struct14_0[i].string_4 = null;
				}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0003E488 File Offset: 0x0003C688
		private static void smethod_76()
		{
			Class35.smethod_69(true);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_4 == "TÝnh N¨ng" || Class35.struct14_0[i].string_4.IndexOf("TÝnh N¨ng") == 0;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -1;
					Class35.struct14_0[i].string_2 = null;
					Class35.struct14_0[i].string_0 = null;
					Class35.struct14_0[i].string_4 = null;
				}
			}
			string text = "i Ho¹t ";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "ChiÕn Long",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ThÝ KiÕm Cèc",
					string_2 = "KiÕm Gia Mª Cung",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 968,
					string_0 = "NguyÖt Ca §¶o",
					string_2 = "n NguyÖt Ca",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "n T­ Qu¸ Nhai",
					string_2 = "n T­ Qu¸ Nhai",
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0003E668 File Offset: 0x0003C868
		private static void smethod_77(bool bool_0 = false)
		{
			Class35.smethod_69(false);
			string str = "i Ho¹t";
			int num = 0;
			int num2 = -1;
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 > Class35.struct14_0[i].string_4.IndexOf("10 => 8") && 0 > Class35.struct14_0[i].string_4.IndexOf("TÝnh N¨ng");
				if (!flag)
				{
					switch (num)
					{
					case 0:
					{
						ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
						ptr = new Class35.Struct14
						{
							int_0 = 949,
							string_0 = "ThÝ KiÕm Cèc",
							string_2 = "KiÕm Gia",
							string_3 = null,
							string_4 = str
						};
						break;
					}
					case 1:
					{
						ref Class35.Struct14 ptr2 = ref Class35.struct14_0[i];
						ptr2 = new Class35.Struct14
						{
							int_0 = -1,
							string_3 = "VANTIEU",
							string_4 = str + "|VËn Tiªu P"
						};
						break;
					}
					case 2:
					{
						ref Class35.Struct14 ptr3 = ref Class35.struct14_0[i];
						ptr3 = new Class35.Struct14
						{
							int_0 = 959,
							string_0 = "ChiÕn Long §éng",
							string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
							string_3 = "ChiÕn Long",
							string_4 = str + "|ChiÕn Long"
						};
						break;
					}
					case 3:
					{
						ref Class35.Struct14 ptr4 = ref Class35.struct14_0[i];
						ptr4 = new Class35.Struct14
						{
							int_0 = 21,
							string_0 = "Thanh Thµnh s¬n",
							string_2 = "POS|92224,116736,muèn ®i VËn Ti|62368,111968,muèn ®i Tr¶ T|85334,121740,muèn ®i C­íp T",
							string_4 = "VËn Tiªu - Thanh Thµnh"
						};
						break;
					}
					case 4:
					{
						ref Class35.Struct14 ptr5 = ref Class35.struct14_0[i];
						ptr5 = new Class35.Struct14
						{
							int_0 = 968,
							string_0 = "NguyÖt Ca §¶o",
							string_2 = "NguyÖt Ca",
							string_4 = "==>"
						};
						break;
					}
					default:
					{
						Class35.struct14_0[i].int_0 = -1;
						Class35.struct14_0[i].string_2 = null;
						Class35.struct14_0[i].string_0 = null;
						Class35.struct14_0[i].string_4 = null;
						bool flag2 = num2 < 0;
						if (flag2)
						{
							num2 = i;
						}
						break;
					}
					}
					num++;
				}
			}
			if (bool_0)
			{
				bool flag3 = 0 <= num2;
				if (flag3)
				{
					ref Class35.Struct14 ptr6 = ref Class35.struct14_0[num2];
					ptr6 = Class35.smethod_1(null);
				}
				else
				{
					Class35.Struct14[] struct14_ = new Class35.Struct14[]
					{
						Class35.smethod_1(null)
					};
					Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0003E970 File Offset: 0x0003CB70
		private static void smethod_78()
		{
			Class35.smethod_69(false);
			Class35.Struct14 @struct = Class35.smethod_1(null);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("10 => 8") || 0 <= Class35.struct14_0[i].string_4.IndexOf("TÝnh N¨ng");
				if (flag)
				{
					Class35.struct14_0[i] = @struct;
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0003E9F4 File Offset: 0x0003CBF4
		private static void smethod_79()
		{
			string str = "nh n¨ng";
			string string_ = str + "|Tèng Kim";
			string str2 = "n¬i muèn";
			string string_2 = str2 + "|hµnh th";
			string string_3 = str2 + "|h«n tran";
			string string_4 = str2 + "|m«n ph";
			string string_5 = str2 + "|cÊp 90";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 2,
					string_0 = "Hoa S¬n",
					string_2 = "Hoa S¬n",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "TÝnh N¨ng|VËn Tiªu"
				},
				new Class35.Struct14
				{
					int_0 = 934,
					string_0 = "Ngän nói Tr­êng",
					string_2 = "Thiªn Tr×",
					string_3 = null,
					string_4 = str
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_5), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_2, string_3), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_4), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(string_), false);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0003EB5C File Offset: 0x0003CD5C
		private static void smethod_80(bool bool_0 = false)
		{
			string str = "dông thuËt";
			string string_ = str + "|Thµnh thÞ";
			string string_2 = str + "|Th«n trang";
			string string_3 = str + "|m«n ph¸i";
			string string_4 = str + "|Tèng Kim";
			string str2 = str + "|luyÖn c«ng";
			string text = str2 + "|cÊp 80";
			string text2 = str2 + "|cÊp 70";
			string text3 = str2 + "|cÊp 60";
			string text4 = str2 + "|cÊp 50";
			string text5 = str2 + "|cÊp 40";
			string text6 = str2 + "|cÊp 30";
			string text7 = str2 + "|cÊp 20";
			string string_5 = str2 + "|cÊp 90";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 0,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §|Sa M¹c Mª Cung",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha m«n",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 3",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				}
			};
			if (bool_0)
			{
				Class35.struct14_0[0].int_0 = 959;
			}
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_5), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_3), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(string_4), false);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0003FA94 File Offset: 0x0003DC94
		private static void smethod_81()
		{
			Class35.smethod_80(false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_5 == "CÈm nang t©n thñ";
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -1;
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0003FAF0 File Offset: 0x0003DCF0
		private static void smethod_82()
		{
			string str = "dông thuËt";
			string str2 = str + "|luyÖn c«ng|cÊp ";
			Class35.smethod_80(false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 6;
				if (flag)
				{
					Class35.struct14_0[i].string_4 = str2 + "40";
				}
				bool flag2 = Class35.struct14_0[i].int_0 == 94 || Class35.struct14_0[i].int_0 == 68;
				if (flag2)
				{
					Class35.struct14_0[i].string_4 = str2 + "70";
				}
				bool flag3 = Class35.struct14_0[i].string_5 == "CÈm nang t©n thñ";
				if (flag3)
				{
					Class35.struct14_0[i].int_0 = -1;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str2 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = "ChiÕn Long",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = "B¸t Qu¸i TrËn",
					string_2 = " TrËn",
					string_3 = " TrËn",
					string_4 = "dông thuËt"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0003FD88 File Offset: 0x0003DF88
		private static void smethod_83()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = Class35.string_68
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_37,
					string_2 = Class35.string_37,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = "Æc biÖt",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "T©y B¾c",
					string_3 = "KiÕm C¸c",
					string_4 = "c«ng c¬ b¶n| 20",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = "c«ng c¬ b¶n| 30",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = "c«ng c¬ b¶n| 40",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = "c«ng c¬ b¶n| 50",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = "c«ng c¬ b¶n| 60",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = "c«ng c¬ b¶n| 70",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = "c«ng c¬ b¶n| 80",
					string_5 = "CÈm nang t©n thñ"
				},
				new Class35.Struct14
				{
					int_0 = 340,
					string_0 = Class35.string_32,
					string_2 = Class35.string_32,
					string_3 = Class35.string_32,
					string_4 = "c«ng c¬ b¶n| 90",
					string_5 = "CÈm nang t©n thñ"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00040390 File Offset: 0x0003E590
		private static void smethod_84()
		{
			string str = "LuyÖn C«ng S";
			string str2 = str + "|KÕ";
			string text = str2 + "|KÕ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c [20",
					string_3 = "KiÕm C¸c",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u §«ng",
					string_3 = "Phôc Ng­u s¬n",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u T©y",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn",
					string_3 = "Hoµng Hµ",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn",
					string_3 = "L­u Tiªn ®éng",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "¸c b¸ ®Þa ®¹o",
					string_3 = null,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("Êp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000407E8 File Offset: 0x0003E9E8
		private static void smethod_85()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Tèng Kim"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = "dông thuËt|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 342,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "Vi S¬n",
					string_3 = null,
					string_4 = "dông thuËt"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_68), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00040C54 File Offset: 0x0003EE54
		private static void smethod_86()
		{
			string str = "luyÖn c«ng|t©n thñ|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = "ThÝ KiÕm Cèc",
					string_2 = "KiÕm Gia",
					string_3 = null,
					string_4 = "Õn vÞ trÝ"
				},
				new Class35.Struct14
				{
					int_0 = 934,
					string_0 = "Ngän nói Tr­êng",
					string_2 = "Thiªn Tr× MËt C¶nh",
					string_4 = "Õn vÞ trÝ"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "kinh nghiÖm ca|TÝnh N¨ng|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(Class35.string_71), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0004144C File Offset: 0x0003F64C
		private static void smethod_87()
		{
			(new Class35.Struct14[11])[0] = new Class35.Struct14
			{
				int_0 = 341,
				string_0 = "M¹c B¾c Th¶o Ng",
				string_2 = "M¹c B¾c T",
				string_3 = null,
				string_4 = "dông thuËt"
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000414BC File Offset: 0x0003F6BC
		private static void smethod_88()
		{
			string str = "dông thuËt|Êp 9|Trang|Trang|Trang";
			string str2 = "dông thuËt|Êp 20=|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 919,
					string_0 = Class35.string_39,
					string_2 = Class35.string_39,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 920,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 921,
					string_0 = Class35.string_41,
					string_2 = Class35.string_41,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = Class35.string_43,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 924,
					string_0 = Class35.string_44,
					string_2 = Class35.string_44,
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 950,
					string_0 = Class35.string_46,
					string_2 = Class35.string_46,
					string_3 = null,
					string_4 = str + "|Trang"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str2 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str2 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str2 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str2 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str2 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str2 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str2 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str2 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|d­íi 90|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.Struct14[] struct14_ = Class35.smethod_3("vÞ trÝ kh¸c", 55);
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00041D80 File Offset: 0x0003FF80
		private static void smethod_89()
		{
			Class35.smethod_88();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("Êp 9");
				if (flag)
				{
					string str = string.Empty;
					bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf("rang k") || 0 <= Class35.struct14_0[i].string_4.IndexOf("rang s");
					if (flag2)
					{
						str = "|" + Class35.string_66;
					}
					Class35.struct14_0[i].string_4 = "dông thuËt|trªn 90|Êp 9" + str;
				}
				else
				{
					bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf("Êp 20=");
					if (flag3)
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace("Êp 20=", "d­íi 90");
					}
				}
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00041EA8 File Offset: 0x000400A8
		private static void smethod_90()
		{
			Class35.smethod_89();
			int i = 0;
			while (i < Class35.struct14_0.Length)
			{
				bool flag = Class35.struct14_0[i].int_0 != 323 && Class35.struct14_0[i].int_0 != 324;
				if (!flag)
				{
					goto IL_6C;
				}
				bool flag2 = Class35.struct14_0[i].int_0 != 325;
				if (!flag2)
				{
					goto IL_6C;
				}
				IL_7E:
				i++;
				continue;
				IL_6C:
				Class35.struct14_0[i].int_0 = -1;
				goto IL_7E;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00041F4C File Offset: 0x0004014C
		private static void smethod_91()
		{
			string str = "i 9x|cÊp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "80"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "80"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "80"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "80"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "80"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "20"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng 1",
					string_3 = "L¨ng TÇn",
					string_4 = str + "20"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn L¨ng",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = str + "30"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "30"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 2)|iÓm Th­¬ng §éng TÇng 2",
					string_3 = null,
					string_4 = str + "40"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 1)|iÓm Th­¬ng §éng TÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str + "40"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn TÇm Th¸p|Thiªn T©m Th¸p",
					string_3 = "Thiªn TÇm th¸p",
					string_4 = str + "50"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p mª cung",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "50"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str + "60"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng TÇng 2",
					string_3 = null,
					string_4 = str + "60"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str + "70"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "70"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("trªn 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00042514 File Offset: 0x00040714
		private static void smethod_92()
		{
			Class35.smethod_91();
			string value = "i 9x|cÊp ";
			string text = "Giê Ho¹t";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(value);
				if (flag)
				{
					Class35.struct14_0[i].int_0 = 959;
					Class35.struct14_0[i].string_2 = "ChiÕn Long";
					Class35.struct14_0[i].string_4 = text;
				}
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000425AC File Offset: 0x000407AC
		private static void smethod_93()
		{
			string text = "rang k|rang s";
			string str = "dông thuËt";
			string text2 = str + "|boss H";
			string text3 = text2 + "|" + text;
			string text4 = string.Concat(new string[]
			{
				text2,
				"|",
				text,
				"|",
				text
			});
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 336,
					string_0 = Class35.string_30,
					string_2 = Class35.string_31,
					string_3 = Class35.string_31,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 75,
					string_0 = Class35.string_62,
					string_2 = Class35.string_65,
					string_3 = Class35.string_64,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 322,
					string_0 = Class35.string_52,
					string_2 = "¬n B¾c",
					string_3 = Class35.string_60,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 225,
					string_0 = Class35.string_53,
					string_2 = "c s¬n  ®éng 1|c s¬n ®éng 1|Sa M¹c 1|Sa M¹c Mª Cung 1",
					string_3 = "Sa M¹c Mª",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 226,
					string_0 = Class35.string_54,
					string_2 = "c s¬n  ®éng 2|c s¬n ®éng 2|Sa M¹c 2|Sa M¹c Mª Cung 2",
					string_3 = "Sa M¹c Mª",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 227,
					string_0 = Class35.string_55,
					string_2 = "c s¬n  ®éng 3|c s¬n ®éng 3|Sa M¹c 3|Sa M¹c Mª Cung 3",
					string_3 = "Sa M¹c Mª",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "ng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "Du¬ng Trung",
					string_3 = "Du¬ng Trung",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 321,
					string_0 = Class35.string_52,
					string_2 = "¬n Nam",
					string_3 = Class35.string_61,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 340,
					string_0 = Class35.string_32,
					string_2 = Class35.string_32,
					string_3 = Class35.string_32,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa m¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "dông thuËt|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|luyÖn c«ng"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00042BF4 File Offset: 0x00040DF4
		private static void smethod_94()
		{
			string text = "rang k|rang s";
			string str = "dông thuËt";
			string text2 = str + "|boss H";
			string text3 = text2 + "|" + text;
			string text4 = string.Concat(new string[]
			{
				text2,
				"|",
				text,
				"|",
				text
			});
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "ng Thñy|L­´ng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "¬ng Trung",
					string_3 = "¬ng Trung",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "dông thuËt|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("n b¶n ®å luyÖn c«ng"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00042FE8 File Offset: 0x000411E8
		private static void smethod_95(string string_74 = null)
		{
			string str = "dông thuËt";
			string str2 = str + "|boss H";
			string str3 = str2 + "|rang k";
			string text = str3 + "|rang k";
			Class35.Struct14 @struct = new Class35.Struct14
			{
				int_0 = 341,
				string_0 = "M¹c B¾c Th¶o Ng",
				string_2 = "M¹c B¾c T",
				string_3 = null,
				string_4 = str
			};
			bool flag = string_74 != null;
			if (flag)
			{
				bool flag2 = string_74 != string.Empty;
				if (flag2)
				{
					@struct.string_4 = string_74;
				}
			}
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 336,
					string_0 = Class35.string_30,
					string_2 = Class35.string_31,
					string_3 = Class35.string_31,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 75,
					string_0 = Class35.string_62,
					string_2 = Class35.string_65,
					string_3 = Class35.string_64,
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 322,
					string_0 = Class35.string_52,
					string_2 = "¬n B¾c",
					string_3 = Class35.string_60,
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 225,
					string_0 = Class35.string_53,
					string_2 = Class35.string_56,
					string_3 = "Sa M¹c Mª",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 226,
					string_0 = Class35.string_54,
					string_2 = Class35.string_57,
					string_3 = "Sa M¹c Mª",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 227,
					string_0 = Class35.string_55,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "ng Thñy|L­´ng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "¬ng Trung",
					string_3 = "¬ng Trung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 321,
					string_0 = Class35.string_52,
					string_2 = "¬n Nam",
					string_3 = Class35.string_61,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 340,
					string_0 = Class35.string_32,
					string_2 = Class35.string_32,
					string_3 = Class35.string_32,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = text
				},
				@struct,
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = str + "|VËn Tiªu."
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEUBANG",
					string_4 = str + "|VËn Tiªu B"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00043664 File Offset: 0x00041864
		private static void smethod_96()
		{
			Class35.smethod_94();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 341;
				if (flag)
				{
					Class35.struct14_0[i].string_4 = "dông thuËt|boss H|rang k|rang k|rang k|rang s|rang s|rang s";
				}
				bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf("luyÖn c«ng");
				if (flag2)
				{
					string str = string.Empty;
					bool flag3 = Class35.struct14_0[i].string_4.IndexOf("|") > 0;
					if (flag3)
					{
						str = "|rang kÕ|rang sau";
					}
					Class35.struct14_0[i].string_4 = "dông thuËt| 90" + str;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 875,
					string_0 = Class35.string_50,
					string_2 = Class35.string_51,
					string_3 = Class35.string_50,
					string_4 = "dông thuËt|cÊp 90"
				},
				new Class35.Struct14
				{
					int_0 = 342,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "Vi S¬n|T©y S¬n",
					string_3 = null,
					string_4 = "dông thuËt|boss H|rang k|rang k"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000437E8 File Offset: 0x000419E8
		private static void smethod_97()
		{
			Class35.smethod_94();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 341;
				if (flag)
				{
					Class35.struct14_0[i].string_4 = "dông thuËt|boss H|rang k|rang k|rang k|rang s|rang s|rang s";
				}
				bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf("luyÖn c«ng");
				if (flag2)
				{
					string str = string.Empty;
					bool flag3 = Class35.struct14_0[i].string_4.IndexOf("|") > 0;
					if (flag3)
					{
						str = "|rang kÕ|rang sau";
					}
					Class35.struct14_0[i].string_4 = "dông thuËt| 90" + str;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,Cæng 1|45664,95840,Cæng 2|49664,95616,Cæng 3",
					string_3 = null,
					string_4 = "dông thuËt|ChiÕn long"
				},
				new Class35.Struct14
				{
					int_0 = 342,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "Vi S¬n|T©y S¬n",
					string_3 = null,
					string_4 = "dông thuËt|boss H|rang k|rang k"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00043968 File Offset: 0x00041B68
		private static void smethod_98(bool bool_0 = false)
		{
			string str = "dông thuËt";
			string str2 = str + "|boss H";
			string str3 = str2 + "|rang k";
			string text = str3 + "|rang k";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = str2
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "ng Thñy|L­´ng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "¬ng Trung",
					string_3 = "¬ng Trung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa biÓu|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "dông thuËt|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|luyÖn c«ng|90"), false);
			if (bool_0)
			{
				Class35.Struct14[] struct14_ = new Class35.Struct14[]
				{
					new Class35.Struct14
					{
						int_0 = 341,
						string_0 = "M¹c B¾c Th¶o Ng",
						string_2 = "M¹c B¾c T",
						string_4 = text
					},
					new Class35.Struct14
					{
						int_0 = 342,
						string_0 = "Vi s¬n ®¶o",
						string_2 = "Vi S¬n|T©y S¬n",
						string_3 = null,
						string_4 = text
					}
				};
				Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
			}
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00043D98 File Offset: 0x00041F98
		private static void smethod_99(bool bool_0 = false, bool bool_1 = false)
		{
			Class35.smethod_98(false);
			string str = "dông thuËt";
			string text = str + "|boss|rang k|rang k|rang k";
			Class35.Struct14[] array = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_3 = null,
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "T©y S¬n|Vi s¬n",
					string_3 = null,
					string_4 = text
				}
			};
			if (bool_0)
			{
				array[0].string_2 = text;
			}
			if (bool_1)
			{
				array[1].int_0 = 342;
			}
			Class35.smethod_0(ref Class35.struct14_0, array, false);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00043E84 File Offset: 0x00042084
		private static void smethod_100()
		{
			Class35.smethod_98(false);
			string text = "dông thuËt|boss H|rang k|rang k";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_3 = null,
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00043EF8 File Offset: 0x000420F8
		private static void smethod_101()
		{
			Class35.smethod_42();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 875;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -10;
					break;
				}
			}
			string str = "luyÖn c«ng|t©n thñ|Êp ";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vò L¨ng s¬n",
					string_2 = "Vò L¨ng S¬n",
					string_3 = "Vò L¨ng S¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u T©y",
					string_3 = "Phôc Ng­u T©y",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 141,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 1",
					string_3 = "D­îc V­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 136,
					string_0 = "Kho¸i Ho¹t L©m",
					string_2 = "Kho¸i Ho¹t L©m",
					string_3 = "Sa M¹c",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str + "3"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0004424C File Offset: 0x0004244C
		private static void smethod_102()
		{
			Class35.smethod_42();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 875;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = -10;
					break;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = null,
					string_4 = "b¶n ®å kh¸c"
				},
				new Class35.Struct14
				{
					int_0 = 342,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "Vi S¬n",
					string_3 = null,
					string_4 = "b¶n ®å kh¸c"
				},
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_3 = null,
					string_4 = "b¶n ®å kh¸c"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00044398 File Offset: 0x00042598
		private static void smethod_103()
		{
			Class35.smethod_28();
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_4 == null || Class35.struct14_0[i].string_4 == string.Empty;
				if (!flag)
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(Class35.string_7);
					if (flag2)
					{
						bool flag3 = !(Class35.struct14_0[i].string_4 == Class35.string_6);
						if (flag3)
						{
							string[] array = Class35.struct14_0[i].string_4.Split(new char[]
							{
								'|'
							});
							bool flag4 = 0 > array[0].IndexOf("---");
							if (!flag4)
							{
								array[0] = "ThÞ & Th«n Tr";
								Class35.struct14_0[i].string_4 = string.Empty;
								for (int j = 0; j < array.Length; j++)
								{
									bool flag5 = Class35.struct14_0[i].string_4 != string.Empty;
									if (flag5)
									{
										Class35.Struct14[] array2 = Class35.struct14_0;
										int num = i;
										array2[num].string_4 = array2[num].string_4 + "|";
									}
									Class35.Struct14[] array3 = Class35.struct14_0;
									int num2 = i;
									array3[num2].string_4 = array3[num2].string_4 + array[j];
								}
							}
						}
						else
						{
							Class35.struct14_0[i].string_4 = "dông thuËt|thÇn hµnh|«n ph¸i";
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = "ThÞ & Th«n Tr|" + Class35.string_7;
					}
				}
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0004456C File Offset: 0x0004276C
		private static void smethod_104()
		{
			string text = "Õn thµnh thÞ th«n trÊn";
			string newValue = "hµnh ThÞ & Th«n TrÊ";
			string text2 = " b¶n ®å luyÖn c«ng";
			string newValue2 = "Map LuyÖn C«ng";
			Class35.smethod_109();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, newValue);
				}
				else
				{
					bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text2);
					if (flag2)
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text2, newValue2);
					}
				}
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00044658 File Offset: 0x00042858
		private static void smethod_105()
		{
			string string_ = "b¶n ®å kh|hµnh thÞ";
			string string_2 = "b¶n ®å kh|h«n tr";
			string string_3 = "b¶n ®å kh|«n ph¸i";
			string str = "b¶n ®å kh|luyÖn c«ng";
			string text = "b¶n ®å kh|§Æc BiÖt|®Æc biÖt|trªn 90|luyÖn c«ng";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1000,
					string_0 = "Nh¹n M«n Quan",
					string_2 = "POS|58112,109056,Cæng 1|51712,109056,Cæng 2|58368,102400,Cæng 3",
					string_4 = "b¶n ®å kh|n¬i H¸i"
				},
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,Cæng 1|45664,95840,Cæng 2|49664,95616,Cæng 3",
					string_3 = null,
					string_4 = "b¶n ®å kh|H¸i-Qu¶|nhÆt H¹t"
				},
				new Class35.Struct14
				{
					int_0 = 990,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,Cæng 1|45664,95840,Cæng 2|49664,95616,Cæng 3",
					string_3 = null,
					string_4 = "b¶n ®å kh|H¸i-Qu¶|nhÆt H¹t"
				},
				new Class35.Struct14
				{
					int_0 = 996,
					string_0 = Class35.string_52,
					string_2 = "s¬n T©y",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 995,
					string_0 = Class35.string_52,
					string_2 = "s¬n §«ng",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 918,
					string_0 = Class35.string_38,
					string_2 = Class35.string_38,
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "POS|41216,102784,Cæng Nam|49408,102464,Cæng §«ng|42240,92160,Cæng T©y",
					string_4 = "b¶n ®å kh|§Æc BiÖt"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c Thôc §¹o",
					string_3 = "KiÕm C¸c",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Kª Qu¸n ®éng",
					string_3 = "Kª Qu¸n",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "TÝn T­íng Tù",
					string_3 = "TÝn T­íng Tù",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 194,
					string_0 = "Ngäc Hoa ®éng",
					string_2 = "Ngäc Hoa",
					string_3 = "Ngäc Hoa",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n MËt",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La H¸n trËn",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c",
					string_3 = Class35.string_59,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "Ch©n nói",
					string_3 = Class35.string_52,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Th",
					string_3 = "L­ìng Thñy",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "TÇng 3 D­",
					string_3 = null,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 922,
					string_0 = Class35.string_42,
					string_2 = Class35.string_42,
					string_3 = null,
					string_4 = str + "|Êp 110"
				},
				new Class35.Struct14
				{
					int_0 = 923,
					string_0 = Class35.string_43,
					string_2 = "Þa MÉu S¬n",
					string_3 = null,
					string_4 = str + "|Êp 110"
				},
				new Class35.Struct14
				{
					int_0 = 917,
					string_0 = Class35.string_40,
					string_2 = Class35.string_40,
					string_3 = null,
					string_4 = str + "|Êp 110"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "b¶n ®å kh|VËn Tiªu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|Êp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_3), false);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000455E0 File Offset: 0x000437E0
		private static void smethod_106()
		{
			Class35.smethod_105();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 == 959 || Class35.struct14_0[i].int_0 == 990;
				if (flag)
				{
					Class35.struct14_0[i].int_0 = 0;
					Class35.struct14_0[i].string_0 = null;
					Class35.struct14_0[i].string_4 = null;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 989,
					string_0 = "§Êu Tr­êng S©m ",
					string_2 = "POS|50400,77984,ng 1 giê|49120,99904,ng 5 giê|38624,100960,ng 7 giê|39200,78208,ng 11 giê",
					string_3 = null,
					string_4 = "Êu Tr­êng"
				},
				new Class35.Struct14
				{
					int_0 = 54,
					string_0 = "Nam Nh¹c trÊn",
					string_2 = "Nam nh¹c",
					string_4 = "Th«n trang"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00045714 File Offset: 0x00043914
		private static void smethod_107()
		{
			string string_ = "hµnh thÞ";
			string string_2 = "h«n trang";
			string string_3 = "«n ph¸i";
			string str = "cÊp 10 ®Õn 80|c«ng ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "i BiÓu|a M¹c ®Þa",
					string_3 = "a M¹c Mª Cung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "T©y B¾c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c trung",
					string_3 = null,
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu S¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "§iÓm Th­¬ng ®éng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "TÇm th¸p tÇng 1",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n MËt",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c §éng",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh C",
					string_3 = "Linh C",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "¹i Tï",
					string_3 = "¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("C«ng 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_3), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2("Tèng Kim"), false);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00046118 File Offset: 0x00044318
		private static void smethod_108()
		{
			string str = "chuyÓn ®Õn thµnh thÞ th«n tr";
			string string_ = str + "|Thµnh thÞ";
			string string_2 = str + "|Th«n trang";
			string string_3 = str + "|Tèng Kim";
			string string_4 = str + "|m«n ph¸i";
			string str2 = "i ®Õn b¶n ®å luyÖn c";
			string str3 = str2 + "|t©n thñ|luyÖn c«ng tõ cÊp";
			string text = str3 + "|c«ng cÊp 80";
			string text2 = str3 + "|c«ng cÊp 70";
			string text3 = str3 + "|c«ng cÊp 60";
			string text4 = str3 + "|c«ng cÊp 50";
			string text5 = str3 + "|c«ng cÊp 40";
			string text6 = str3 + "|c«ng cÊp 30";
			string text7 = str3 + "|c«ng cÊp 20";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng",
					string_3 = "Vu L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng|Vu L¨ng",
					string_3 = "Vò L¨ng|Vu L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 200,
					string_0 = "Cæ D­¬ng §éng",
					string_2 = "Cæ D­¬ng",
					string_3 = "Cæ D­¬ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 207,
					string_0 = "TÇn L¨ng tÇng 3",
					string_2 = "TÇn L¨ng tÇng 3",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o §éng",
					string_3 = Class35.string_36,
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n T",
					string_3 = "Phôc Ng­u S¬n T",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u S¬n §«ng",
					string_3 = "Phôc Ng­u s¬n  nam",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Kª Qu¸n",
					string_3 = "Kª Qu¸n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 180,
					string_0 = "Long Cung ®éng",
					string_2 = "Long Cung",
					string_3 = "Long Cung",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt th¸p",
					string_3 = "ThiÕt Th¸p",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m ®éng",
					string_3 = "Thiªn T©m ®éng",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 194,
					string_0 = "Ngäc Hoa ®éng",
					string_2 = "Ngäc Hoa",
					string_3 = "Ngäc Hoa",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "¸c b¸",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 116,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 1",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "y §éng §×nh Hå",
					string_3 = null,
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha m«n",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 3",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng tÇng 2",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "D­¬ng Gi¸c",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 148,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 4",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 1",
					string_3 = "L­u Tiªn ®éng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2|D­îc V­¬ng §éng tÇng 2",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = text2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str2 + "|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_4), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(string_3), false);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00047520 File Offset: 0x00045720
		private static void smethod_109()
		{
			string str = "Õn thµnh thÞ th«n trÊn";
			string string_ = str + "|Thµnh thÞ";
			string string_2 = str + "|Th«n trang";
			string string_3 = str + "|Tèng Kim";
			string string_4 = str + "|m«n ph¸i";
			string str2 = " b¶n ®å luyÖn c«ng";
			string str3 = str2 + "|t©n thñ";
			string text = str3 + "|cÊp 80";
			string text2 = str3 + "|cÊp 70";
			string text3 = str3 + "|cÊp 60";
			string text4 = str3 + "|cÊp 50";
			string text5 = str3 + "|cÊp 40";
			string text6 = str3 + "|cÊp 30";
			string text7 = str3 + "|cÊp 20";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = text7
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di S¬n",
					string_2 = "Vò Di S¬n",
					string_3 = "Vò Di S¬n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = text5
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m ®éng",
					string_3 = "Thiªn T©m",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p",
					string_3 = "Thiªn TÇm th¸p",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p mª cung",
					string_3 = "ThiÕt Th¸p",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = text4
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m th¸p tÇng 3",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = text2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str2 + "|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(string_, string_2), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(string_4), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(string_3), false);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00048070 File Offset: 0x00046270
		private static void smethod_110()
		{
			Class35.smethod_109();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf("Tèng Kim");
				if (flag)
				{
					Class35.struct14_0[i].string_4 = "Tèng Kim";
				}
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000480D8 File Offset: 0x000462D8
		private static void smethod_111()
		{
			string text = "Õn thµnh thÞ th«n trÊn";
			string newValue = "thuËt thÇn";
			Class35.smethod_109();
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, newValue);
				}
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0004815C File Offset: 0x0004635C
		private static void smethod_112(bool bool_0 = false)
		{
			Class35.smethod_109();
			string str = "Õn thµnh thÞ th«n trÊn";
			string value = str + "|Thµnh thÞ";
			string value2 = str + "|Th«n trang";
			str + "|Tèng Kim";
			string value3 = str + "|m«n ph¸i";
			string str2 = " b¶n ®å luyÖn c«ng";
			string value4 = str2 + "|cÊp 90";
			string value5 = str2 + "|cÊp 90|rang k|rang s";
			string value6 = str2 + "|t©n thñ";
			string str3 = "n b¶n ®å luyÖn c";
			string text = str3 + "|cÊp 90";
			string text2 = str3 + "|cÊp 90|rang k|rang s";
			string text3 = str3 + "|cña t©n thñ";
			int i = 0;
			while (i < Class35.struct14_0.Length)
			{
				bool flag = 0 > Class35.struct14_0[i].string_4.IndexOf(value);
				if (flag)
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(value2);
					if (flag2)
					{
						bool flag3 = 0 > Class35.struct14_0[i].string_4.IndexOf(value3);
						if (flag3)
						{
							bool flag4 = 0 > Class35.struct14_0[i].string_4.IndexOf("Tèng Kim");
							if (flag4)
							{
								bool flag5 = 0 > Class35.struct14_0[i].string_4.IndexOf(value5);
								if (flag5)
								{
									bool flag6 = 0 > Class35.struct14_0[i].string_4.IndexOf(value4);
									if (flag6)
									{
										bool flag7 = 0 > Class35.struct14_0[i].string_4.IndexOf(value6);
										if (!flag7)
										{
											int num = -1;
											string[] array = Class35.struct14_0[i].string_4.Split(new char[]
											{
												'|'
											});
											for (int j = 0; j < array.Length; j++)
											{
												bool flag8 = 0 <= array[j].IndexOf("cÊp ");
												if (flag8)
												{
													num = j;
													break;
												}
											}
											bool flag9 = 0 <= num;
											if (flag9)
											{
												Class35.struct14_0[i].string_4 = text3;
												for (int k = num; k < array.Length; k++)
												{
													ref Class35.Struct14 ptr = ref Class35.struct14_0[i];
													ptr.string_4 = ptr.string_4 + "|" + array[k];
												}
											}
										}
									}
									else
									{
										Class35.struct14_0[i].string_4 = text;
									}
								}
								else
								{
									Class35.struct14_0[i].string_4 = text2;
								}
							}
							else
							{
								Class35.struct14_0[i].string_4 = "Tèng Kim";
							}
						}
						else
						{
							Class35.struct14_0[i].string_4 = "M«n ph¸i";
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = "T©n thñ th«n";
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = "Thµnh thÞ";
				}
				IL_30A:
				i++;
				continue;
				goto IL_30A;
			}
			Class35.Struct14 @struct = default(Class35.Struct14);
			if (bool_0)
			{
				@struct = new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = "ChiÕn Long",
					string_4 = "ChiÕn Long"
				};
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 355,
					string_0 = "§Êu Tr­êng Sinh",
					string_5 = "LÖnh bµi T©n Thñ",
					string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y",
					string_4 = "Sinh T"
				},
				@struct
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00048554 File Offset: 0x00046754
		private static void smethod_113()
		{
			string str = "luyÖn c«ng|tõ 10|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = Class35.string_8
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|tõ 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00048C90 File Offset: 0x00046E90
		private static void smethod_114(string string_74 = null, string string_75 = null)
		{
			bool flag = string_75 == null || string_75 == string.Empty;
			if (flag)
			{
				string_75 = "POS|40611,103722,KÕt 1|49472,102368,KÕt 2|41952,92416,KÕt 3";
			}
			bool flag2 = string_74 == null || string_74 == string.Empty;
			if (flag2)
			{
				string_74 = "B¶n ®å Ho¹|Hoa S¬n P";
			}
			string string_76 = "dông thuËt|cÊp 90";
			string str = "dông thuËt|luyÖn c«ng|Êp ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 207,
					string_0 = "TÇn L¨ng tÇng 3",
					string_2 = "TÇn L¨ng tÇng 3",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 151,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 7",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = str + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 3,
					string_0 = "KiÕm C¸c T©y B¾",
					string_2 = "KiÕm C¸c T©y B",
					string_3 = "KiÕm C¸c",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 43,
					string_0 = "KiÕm C¸c Trung",
					string_2 = "KiÕm C¸c Trung Nguyªn",
					string_3 = null,
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 71,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 73,
					string_0 = "Phôc L­u ®éng",
					string_2 = "Phôc L­u",
					string_3 = "Phôc L­u ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 83,
					string_0 = "Háa Lang ®éng",
					string_2 = "Háa Lang",
					string_3 = "Háa Lang ®éng",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 8,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1",
					string_3 = "TÇn L¨ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 74,
					string_0 = "Miªu LÜnh",
					string_2 = "Miªu LÜnh",
					string_3 = "Miªu LÜnh",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u S¬n §«ng",
					string_3 = "Phôc Ng­u s¬n  nam",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 136,
					string_0 = "Kho¸i Ho¹t L©m",
					string_2 = "Kho¸i Ho¹t L©m",
					string_3 = "Sa M¹c",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 141,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 1",
					string_3 = "D­îc V­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 1",
					string_3 = "TuyÕt B¸o",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 122,
					string_0 = "Hoµng Hµ Nguyªn",
					string_2 = "Hoµng Hµ Nguyªn §Çu",
					string_3 = "Hoµng Hµ",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 172,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "iÓm Th­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 135,
					string_0 = "KiÕn TÝnh Phong",
					string_2 = "KiÕn TÝnh Phong s¬n",
					string_3 = null,
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 91,
					string_0 = "Mª cung Kª Qu¸n",
					string_2 = "Mª cung Kª Qu¸n",
					string_3 = "Kª Qu¸n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 168,
					string_0 = "Phông Nh·n ®éng",
					string_2 = "Phông Nh·n",
					string_3 = "Phông Nh·n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 180,
					string_0 = "Long Cung ®éng",
					string_2 = "Long Cung",
					string_3 = "Long Cung",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p|Thiªn tÇm th¸p",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p tÇng 1",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 39,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p tÇng 2",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 40,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p tÇng 3",
					string_3 = "ThiÕt Th¸p",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m ®éng",
					string_3 = "Thiªn T©m",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 116,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §én",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "×nh hå tÇng 1",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 67,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "×nh hå tÇng 1",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 12,
					string_0 = "§Þa ®¹o hËu viÖ",
					string_2 = "hËu viÖn TÝn",
					string_3 = "HËu ViÖn TÝn T­íng Tù",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn",
					string_3 = "L­u Tiªn ®éng",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 132,
					string_0 = "B¨ng HuyÖt ®éng",
					string_2 = "B¨ng HuyÖt ®éng",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n MËt",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La H¸n trËn",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "D­¬ng Gi¸c",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng tÇng 2",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 118,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng tÇng 3",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 119,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng tÇng 4",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "L©m Du Quan T©y",
					string_2 = "L©m Du Quan T©y",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 999,
					string_0 = "L©m Du Quan §«n",
					string_2 = "L©m Du Quan §«ng",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o ®éng",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 120,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 5",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = string_75,
					string_4 = string_74
				},
				new Class35.Struct14
				{
					int_0 = 933,
					string_0 = "B¶n ®å Sinh Tö",
					string_2 = "Sinh T",
					string_4 = "B¶n ®å Ho¹"
				},
				Class35.smethod_1("B¶n ®å Ho¹|Tranh §o¹t")
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_76), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", 55), false);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0004A94C File Offset: 0x00048B4C
		private static void smethod_115()
		{
			Class35.smethod_114(null, null);
			bool flag = false;
			string text = "vÞ trÝ kh¸c";
			int i = 0;
			while (i < Class35.struct14_0.Length)
			{
				bool flag2 = Class35.struct14_0[i].int_0 != 333;
				if (flag2)
				{
					bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text);
					if (flag3)
					{
						bool flag4 = flag;
						if (flag4)
						{
							Class35.struct14_0[i].int_0 = -1;
							Class35.struct14_0[i].string_4 = null;
						}
						else
						{
							Class35.struct14_0[i].int_0 = 933;
							Class35.struct14_0[i].string_4 = text;
							Class35.struct14_0[i].string_2 = "Sinh T";
							Class35.struct14_0[i].string_0 = "B¶n ®å Sinh Tö";
							Class35.struct14_0[i].string_3 = null;
						}
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = text + "|Hoa S¬n P";
				}
				IL_111:
				i++;
				continue;
				goto IL_111;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0004AA84 File Offset: 0x00048C84
		private static void smethod_116()
		{
			string string_ = "POS|40576,103904,TrÝ 1|41920,92576,TrÝ 2|48960,102656,TrÝ 3";
			string string_2 = "dông thuËt|Hoa S¬n P";
			Class35.smethod_114(string_2, string_);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0004AAA8 File Offset: 0x00048CA8
		private static void smethod_117()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "ChiÕn Long",
					string_3 = "ChiÕn Long",
					string_4 = "dông thuËt"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", 55), false);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0004AB74 File Offset: 0x00048D74
		private static void smethod_118(string string_74 = null, string string_75 = null, bool bool_0 = false)
		{
			int num = 71;
			int num2 = 8;
			int num3 = 171;
			int num4 = 24;
			if (bool_0)
			{
				num = 0;
				num2 = 0;
				num3 = 0;
				num4 = 0;
			}
			string text = "i ®Õn b¶n ®å l|n c«ng cÊp ";
			bool flag = string_75 == null || string_75 == string.Empty;
			if (flag)
			{
				string_75 = text;
			}
			bool flag2 = string_74 == null || string_74 == string.Empty;
			if (flag2)
			{
				string_74 = text + "9";
			}
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = string_75 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = string_75 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = string_75 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = string_75 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = string_75 + "8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm C¸c T©y Nam",
					string_3 = "KiÕm C¸c",
					string_4 = string_75 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = string_75 + "2"
				},
				new Class35.Struct14
				{
					int_0 = num,
					string_0 = "B¹ch Thñy ®éng",
					string_2 = "B¹ch Thñy",
					string_3 = "B¹ch Thñy ®éng",
					string_4 = string_75 + "2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di s¬n|Vu Di s¬n",
					string_3 = "Vò Di s¬n",
					string_4 = string_75 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = "Thæ PhØ ®éng",
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = string_75 + "3"
				},
				new Class35.Struct14
				{
					int_0 = num2,
					string_0 = "L¨ng TÇn Thñy H",
					string_2 = "TÇn l¨ng tÇng 1",
					string_3 = "tÇng 1 TÇn L¨ng",
					string_4 = string_75 + "3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh S¬n",
					string_3 = "Thanh Thµnh s¬n",
					string_4 = string_75 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "§iÓm Th­¬ng s¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = string_75 + "4"
				},
				new Class35.Struct14
				{
					int_0 = num3,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng (TÇng 1)|iÓm Th­¬ng ®éng tÇng 1",
					string_3 = "iÓm Th­¬ng ®éng",
					string_4 = string_75 + "4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = string_75 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p|Thiªn tÇm th¸p",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = string_75 + "5"
				},
				new Class35.Struct14
				{
					int_0 = num4,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy",
					string_3 = "H­ëng Thñy",
					string_4 = string_75 + "5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n MËt",
					string_3 = null,
					string_4 = string_75 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = string_75 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = string_75 + "6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = string_75 + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = text + "7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = null,
					string_4 = string_75 + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(string_74 + "9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_3("vÞ trÝ kh¸c", 55), false);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0004B3B4 File Offset: 0x000495B4
		private static void smethod_119()
		{
			Class35.smethod_118(null, null, false);
			string text = "L©m Du Quan 3";
			string text2 = "L©m Du Quan 2";
			string str = "i ®Õn b¶n ®å l|n c«ng cÊp ";
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 1003,
					string_0 = text2,
					string_2 = text2,
					string_3 = text2,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 1004,
					string_0 = text,
					string_2 = text,
					string_3 = text,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 355,
					string_0 = "§Êu Tr­êng Sinh",
					string_2 = "POS|50304,78016,KÕt 1|38592,100992,KÕt 2|49440,99520,KÕt 3|38976,78464,KÕt 4",
					string_4 = "tr­êng sinh"
				},
				new Class35.Struct14
				{
					int_0 = 179,
					string_0 = "La Tiªu s¬n",
					string_2 = "La Tiªu s¬n",
					string_3 = "La Tiªu s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 14,
					string_0 = "M·nh Hæ ®éng",
					string_2 = "M·nh Hæ",
					string_3 = "M·nh Hæ",
					string_4 = str + "2"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 4,
					string_0 = "Kim Quang ®éng",
					string_2 = "Kim Quang",
					string_3 = "Kim Quang",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 136,
					string_0 = "Kho¸i Ho¹t L©m",
					string_2 = "Kho¸i Ho¹t L©m",
					string_3 = "Sa M¹c",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 90,
					string_0 = "Phôc Ng­u S¬n §",
					string_2 = "Phôc Ng­u S¬n §«ng",
					string_3 = "Phôc Ng­u s¬n  nam",
					string_4 = str + "3"
				},
				new Class35.Struct14
				{
					int_0 = 41,
					string_0 = "Phôc Ng­u S¬n T",
					string_2 = "Phôc Ng­u S¬n",
					string_3 = "Phôc Ng­u S¬n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 6,
					string_0 = "Táa V©n ®éng",
					string_2 = "Táa V©n",
					string_3 = "Táa V©n",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 180,
					string_0 = "Long Cung ®éng",
					string_2 = "Long Cung",
					string_3 = "Long Cung",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str + "4"
				},
				new Class35.Struct14
				{
					int_0 = 165,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn tÇm th¸p tÇng 2",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 3",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 125,
					string_0 = "L­u Tiªn ®éng t",
					string_2 = "L­u Tiªn ®éng tÇng 1",
					string_3 = "L­u Tiªn ®éng",
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 132,
					string_0 = "B¨ng HuyÖt ®éng",
					string_2 = "B¨ng HuyÖt ®éng",
					string_3 = null,
					string_4 = str + "5"
				},
				new Class35.Struct14
				{
					int_0 = 119,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 4",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 114,
					string_0 = "108 La H¸n trËn",
					string_2 = "108 La h¸n trËn",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 51,
					string_0 = "Th¸nh ®éng tÇng",
					string_2 = "Th¸nh ®éng tÇng 1",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 26,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 1",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c §éng",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 147,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 4",
					string_3 = null,
					string_4 = str + "6"
				},
				new Class35.Struct14
				{
					int_0 = 9,
					string_0 = "Tr­êng Giang Ng",
					string_2 = "Tr­uêng Nguyªn|Tr­êng Giang",
					string_3 = "Tr­êng Giang",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 27,
					string_0 = "Tróc T¬ ®éng tÇ",
					string_2 = "Tróc T¬ ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 76,
					string_0 = "S¬n B¶o ®éng",
					string_2 = "S¬n B¶o",
					string_3 = "S¬n B¶o",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 120,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n ®éng tÇng 5",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 2",
					string_3 = null,
					string_4 = str + "7"
				},
				new Class35.Struct14
				{
					int_0 = 68,
					string_0 = "Thanh Loa ®¶o",
					string_2 = "Thanh Loa",
					string_3 = null,
					string_4 = str + "7"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0004BEA8 File Offset: 0x0004A0A8
		private static void smethod_120()
		{
			Class35.smethod_118(null, null, false);
			string str = "dông thuËt";
			string str2 = str + "|i ®Õn b¶n ®å luy";
			string str3 = str2 + "|cÊp 90";
			string text = str3 + "|rang";
			string newValue = str2 + "|t©n thñ|n c«ng cÊp ";
			string text2 = str + "|qu¶ H|n¬i nhÆt qu";
			string text3 = "i ®Õn b¶n ®å l|n c«ng cÊp ";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_4.IndexOf(text3) >= 0;
				if (flag)
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf("9");
					if (flag2)
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text3, newValue);
					}
					else
					{
						bool flag3 = 0 > Class35.struct14_0[i].string_4.IndexOf("rang");
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = str3;
						}
						else
						{
							Class35.struct14_0[i].string_4 = text;
						}
					}
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng S¬n",
					string_3 = "Thôc C­¬ng S¬n",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 200,
					string_0 = "Cæ D­¬ng §éng",
					string_2 = "Cæ D­¬ng",
					string_3 = "Cæ D­¬ng",
					string_4 = text2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		private static void smethod_121()
		{
			Class35.smethod_118(null, null, false);
			string str = "trang - Thµnh th|";
			string text = str + "hµnh thÞ";
			string text2 = str + "h«n trang";
			string text3 = str + "«n ph¸i";
			string text4 = str + "Tèng - Kim";
			string str2 = "aps luyÖn";
			string str3 = str2 + "|cÊp 90";
			string text5 = str3 + "|Trang k|Trang s";
			string str4 = str2 + "|t©n thñ|cÊp ";
			string text6 = "Kinh nghiÖm ca";
			string text7 = "NguyÖt TrÊn - §µo Hoa";
			string text8 = "i ®Õn b¶n ®å l|n c«ng cÊp ";
			string b = "dông thuËt|" + Class35.string_7;
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = !(Class35.struct14_0[i].string_4 == Class35.string_4);
				if (flag)
				{
					bool flag2 = !(Class35.struct14_0[i].string_4 == Class35.string_5);
					if (flag2)
					{
						bool flag3 = Class35.struct14_0[i].string_4 == Class35.string_6;
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = text3;
						}
						else
						{
							bool flag4 = Class35.struct14_0[i].string_4 == b;
							if (flag4)
							{
								Class35.struct14_0[i].string_4 = text4;
							}
							else
							{
								bool flag5 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text8 + "9|rang");
								if (flag5)
								{
									Class35.struct14_0[i].string_4 = text5;
								}
								else
								{
									bool flag6 = Class35.struct14_0[i].string_4 == text8 + "9";
									if (flag6)
									{
										Class35.struct14_0[i].string_4 = str3;
									}
									else
									{
										bool flag7 = 0 <= Class35.struct14_0[i].string_4.IndexOf("vÞ trÝ kh¸c");
										if (flag7)
										{
											Class35.struct14_0[i].string_4 = text7;
										}
										else
										{
											bool flag8 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text8);
											if (flag8)
											{
												Class35.struct14_0[i].string_4 = str4 + Class35.struct14_0[i].string_4.Replace(text8, string.Empty);
											}
										}
									}
								}
							}
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = text2;
					}
				}
				else
				{
					Class35.struct14_0[i].string_4 = text;
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 934,
					string_0 = "Ngän nói Tr­êng",
					string_2 = "hiªn Tr× MËt C",
					string_3 = null,
					string_4 = text6
				},
				new Class35.Struct14
				{
					int_0 = 949,
					string_0 = Class35.string_45,
					string_2 = Class35.string_45,
					string_3 = null,
					string_4 = text5
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0004C418 File Offset: 0x0004A618
		private static void smethod_122()
		{
			Class35.struct14_0 = null;
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4("thÞ th«n|Thµnh thÞ", "thÞ th«n|Th«n trang"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5("thÞ th«n|ph¸i"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2("b¸o danh|Tèng"), false);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0004C474 File Offset: 0x0004A674
		private static void smethod_123()
		{
			string text = "n¨ng hç|hu vùc luyÖn|c«ng 80";
			string text2 = "dông thuËt|Kim";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Kh",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­",
					string_3 = Class35.string_52,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = text2
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0004C630 File Offset: 0x0004A830
		private static void smethod_124()
		{
			string str = "dông thuËt|t©n thñ";
			string text = "n vÞ trÝ kh";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®Þa|i BiÓu",
					string_3 = Class35.string_59,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str + "|Êp 8"
				},
				new Class35.Struct14
				{
					int_0 = 19,
					string_0 = "KiÕm C¸c T©y Na",
					string_2 = "KiÕm c¸c",
					string_3 = "KiÕm C¸c",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "L¨ng TÇn",
					string_3 = "L¨ng TÇn",
					string_4 = str + "|Êp 2"
				},
				new Class35.Struct14
				{
					int_0 = 193,
					string_0 = "Vò Di s¬n",
					string_2 = "Vò Di",
					string_3 = "Vò Di",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "Thæ phØ",
					string_3 = "Thæ PhØ",
					string_4 = str + "|Êp 3"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 167,
					string_0 = "§iÓm Th­¬ng s¬n",
					string_2 = "iÓm Th­¬ng S¬n",
					string_3 = "§iÓm Th­¬ng s¬n",
					string_4 = str + "|Êp 4"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 164,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m",
					string_3 = "TÇm th¸p tÇng 1",
					string_4 = str + "|Êp 5"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "T­¬ng D­¬ng Nha M«n",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "s¬n Ph",
					string_3 = "s¬n Ph",
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "m Th¸p tÇng 3",
					string_3 = null,
					string_4 = str + "|Êp 6"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "L©m Du",
					string_3 = Class35.string_49,
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 206,
					string_0 = "TÇn L¨ng tÇng 2",
					string_2 = "TÇn L¨ng tÇng 2",
					string_3 = "TÇn L¨ng tÇng 2",
					string_4 = str + "|Êp 7"
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "b¸o danh|ghi danh",
					string_3 = null,
					string_4 = "Õn vÞ trÝ|Tèng"
				},
				new Class35.Struct14
				{
					int_0 = 523,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn T­¬ng D",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 521,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Thµnh",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 520,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn Ph­îng T",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 525,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn §¹i L",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 524,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn D­¬ng C",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 522,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn BiÖn K",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 526,
					string_0 = "Minh NguyÖt trÊ",
					string_2 = "nguyÖt trÊn L©m A",
					string_3 = null,
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|cÊp 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0004CF68 File Offset: 0x0004B168
		private static void smethod_125()
		{
			string str = "dông thuËt";
			string text = str + "| 80";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = "Sa M¹c ®|Sa M¹c §",
					string_3 = Class35.string_59,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 320,
					string_0 = Class35.string_27,
					string_2 = "h©n nói Tr­êng B¹ch",
					string_3 = Class35.string_52,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 10,
					string_0 = "Nh¹n Th¹ch ®éng",
					string_2 = "Nh¹n Th¹ch",
					string_3 = "Nh¹n Th¹ch",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 143,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng ®éng tÇng 3",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 151,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o ®éng tÇng 7",
					string_3 = null,
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 181,
					string_0 = Class35.string_28,
					string_2 = "L­¬ng Thñy|L­ìng Thñy",
					string_3 = "L­ìng Thñy",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 198,
					string_0 = Class35.string_26,
					string_2 = "Thanh Khª",
					string_3 = "Thanh Khª",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vu L¨ng|Vò L¨ng",
					string_3 = "Vu L¨ng|Vò L¨ng",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = text
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "| 90"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0004D388 File Offset: 0x0004B588
		private static void smethod_126()
		{
			Class35.smethod_11();
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 333,
					string_0 = "Hoa S¬n ph¸i",
					string_2 = "Hoa-S¬n",
					string_4 = "Hoa S¬n"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0004D3F0 File Offset: 0x0004B5F0
		private static void smethod_127()
		{
			Class35.struct14_0 = null;
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = 0 <= Class35.struct14_0[i].string_4.IndexOf(Class35.string_4);
				if (flag)
				{
					Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(Class35.string_4, "thµnh thÞ");
				}
				else
				{
					bool flag2 = 0 <= Class35.struct14_0[i].string_4.IndexOf(Class35.string_5);
					if (flag2)
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(Class35.string_5, "th«n");
					}
					else
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(Class35.string_8);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(Class35.string_8, "tèng kim");
						}
					}
				}
			}
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("c«ng 90"), false);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0004D578 File Offset: 0x0004B778
		private static void smethod_128()
		{
			Class35.smethod_98(false);
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].string_3 == "VANTIEU";
				if (flag)
				{
					Class35.struct14_0[i].string_4 = "dông thuËt|Ho¹t|VËn tiªu";
				}
				bool flag2 = Class35.struct14_0[i].string_2 == "danh";
				if (flag2)
				{
					Class35.struct14_0[i].string_4 = "dông thuËt|Ho¹t|tèng kim";
				}
			}
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 341,
					string_0 = "M¹c B¾c Th¶o Ng",
					string_2 = "M¹c B¾c T",
					string_4 = "dông thuËt|boss H|rang k|rang k"
				},
				new Class35.Struct14
				{
					int_0 = 342,
					string_0 = "Vi s¬n ®¶o",
					string_2 = "Vi S¬n|T©y S¬n",
					string_3 = null,
					string_4 = "dông thuËt|boss H|rang k|rang k"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0004D6AC File Offset: 0x0004B8AC
		private static void smethod_129()
		{
			string str = "dông thuËt";
			string str2 = str + "|n¬i luyÖn c«n|cÊp ";
			string str3 = str + "| 90";
			string text = str3 + "|rang k|rang s";
			string text2 = str + "|hµnh thÞ";
			string text3 = str + "|Th«n trang";
			string str4 = str + "|cÊp 90 (New)";
			str4 + "|rang k";
			string str5 = str + "|ho¹t ®éng";
			string str6 = "VËn Tiªu Bang H";
			string text4 = "Tiªu Côc sè ";
			string text5 = "Th¶o KhÊu sè ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 30,
					string_1 = Class35.string_1[3],
					string_0 = "Phóc Thµnh",
					string_2 = "Phóc Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 47,
					string_1 = Class35.string_1[3],
					string_0 = "Léc Thµnh",
					string_2 = "Léc Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 137,
					string_1 = Class35.string_1[3],
					string_0 = "Thä Thµnh",
					string_2 = "Thä Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 139,
					string_1 = Class35.string_1[3],
					string_0 = "Sµi Thµnh",
					string_2 = "Sµi Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 190,
					string_1 = Class35.string_1[0],
					string_0 = "§µ Thµnh",
					string_2 = "§µ Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 185,
					string_1 = Class35.string_1[2],
					string_0 = "Hµ Thµnh",
					string_2 = "Hµ Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 160,
					string_1 = Class35.string_1[0],
					string_0 = "L¹c D­¬ng",
					string_2 = "L¹c D­¬ng",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 989,
					string_1 = Class35.string_1[0],
					string_0 = "Kinh Thµnh",
					string_2 = "Kinh Thµnh",
					string_4 = text2
				},
				new Class35.Struct14
				{
					int_0 = 1062,
					string_0 = "(Block)Ba L¨ng huyÖn",
					string_2 = "(Block)Ba L¨ng huyÖn",
					string_4 = text3
				},
				new Class35.Struct14
				{
					int_0 = 1079,
					string_0 = "TuyÕt Nam S¬n 1",
					string_2 = "TuyÕt Nam S¬n 1",
					string_3 = "TuyÕt Nam S¬n 1",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1080,
					string_0 = "TuyÕt Nam S¬n 2",
					string_2 = "TuyÕt Nam S¬n 2",
					string_3 = "TuyÕt Nam S¬n 2",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1081,
					string_0 = "TuyÕt Nam S¬n 3",
					string_2 = "TuyÕt Nam S¬n 3",
					string_3 = "TuyÕt Nam S¬n 3",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1082,
					string_0 = "TuyÕt Nam S¬n 4",
					string_2 = "TuyÕt Nam S¬n 4",
					string_3 = "TuyÕt Nam S¬n 4",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1091,
					string_0 = "§¹i Hoang M¹c 5",
					string_2 = "§¹i Hoang M¹c 5",
					string_3 = "§¹i Hoang M¹c 5",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1092,
					string_0 = "§¹i Hoang M¹c 6",
					string_2 = "§¹i Hoang M¹c 6",
					string_3 = "§¹i Hoang M¹c 6",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1093,
					string_0 = "§¹i Hoang M¹c 7",
					string_2 = "§¹i Hoang M¹c 7",
					string_3 = "§¹i Hoang M¹c 7",
					string_4 = str3
				},
				new Class35.Struct14
				{
					int_0 = 1094,
					string_0 = "§¹i Hoang M¹c 8",
					string_2 = "§¹i Hoang M¹c 8",
					string_3 = "§¹i Hoang M¹c 8",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1095,
					string_0 = "B×nh An S¬n 1",
					string_2 = "B×nh An S¬n 1",
					string_3 = "B×nh An S¬n 1",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1096,
					string_0 = "B×nh An S¬n 2",
					string_2 = "B×nh An S¬n 2",
					string_3 = "B×nh An S¬n 2",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 1097,
					string_0 = "B×nh An S¬n 3",
					string_2 = "B×nh An S¬n 3",
					string_3 = "B×nh An S¬n 3",
					string_4 = text
				},
				new Class35.Struct14
				{
					int_0 = 323,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = str5 + "|Kim"
				},
				new Class35.Struct14
				{
					int_0 = 324,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = str5 + "|Kim"
				},
				new Class35.Struct14
				{
					int_0 = 325,
					string_0 = Class35.string_16,
					string_2 = "danh",
					string_3 = null,
					string_4 = str5 + "|Kim"
				},
				new Class35.Struct14
				{
					int_0 = 977,
					string_0 = "B¶n §å Hßa B×nh",
					string_2 = "Hßa B×nh",
					string_3 = "b¶n ®å H¸i Qu¶",
					string_4 = str5 + "|h¸i qu¶"
				},
				new Class35.Struct14
				{
					int_0 = 1100,
					string_0 = "V¹n Tiªu TrËn",
					string_2 = string.Concat(new string[]
					{
						"POS|52768,90496,",
						text4,
						"1|61024,90432,",
						text4,
						"2|62944,99584,",
						text4,
						"3|63456,104672,",
						text4,
						"4|62560,109632,",
						text5,
						"1|60416,104864,",
						text5,
						"2|57632,92928,",
						text5,
						"3|53056,98784,",
						text5,
						"4"
					}),
					string_3 = str6,
					string_4 = str5 + "|" + str6
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "| 90"), false);
			for (int i = 1000; i < 1060; i++)
			{
				string text6 = null;
				string text7 = null;
				string text8 = null;
				string text9 = null;
				bool flag = 1001 > i || i > 1008;
				if (flag)
				{
					bool flag2 = 1009 <= i && i <= 1016;
					if (flag2)
					{
						text6 = "Thæ PhØ §éng " + (i - 1008).ToString();
						text7 = text6;
						text8 = text7;
						text9 = str2 + "30";
					}
					else
					{
						bool flag3 = 1017 > i || i > 1024;
						if (flag3)
						{
							bool flag4 = 1025 > i || i > 1032;
							if (flag4)
							{
								bool flag5 = 1033 > i || i > 1040;
								if (flag5)
								{
									bool flag6 = 1041 <= i && i <= 1048;
									if (flag6)
									{
										text6 = "L©m Du Quan " + (i - 1040).ToString();
										text7 = text6;
										text8 = text6;
										text9 = str2 + "70";
									}
									else
									{
										bool flag7 = 1049 > i || i > 1056;
										if (flag7)
										{
											bool flag8 = 1057 <= i && i <= 1061;
											if (flag8)
											{
												string[] array = new string[]
												{
													"Kim",
													"Mộc",
													"Thủy",
													"Hỏa",
													"Thổ"
												};
												text6 = array[i - 1057] + " - Tr­êng S¬";
												text7 = text6;
												text8 = text6;
												text9 = str5 + "|Ngò Hµnh T";
											}
										}
										else
										{
											text6 = "L­ìng Thñy §éng " + (i - 1048).ToString();
											text7 = text6;
											text8 = text6;
											text9 = str2 + "80";
										}
									}
								}
								else
								{
									text6 = "TÇng 3 Thiªn TÇ";
									text7 = "TÇm Th¸p " + (i - 1032).ToString();
									text8 = "TÇng 3 Thiªn TÇm Th¸p " + (i - 1032).ToString();
									text9 = str2 + "60";
								}
							}
							else
							{
								text6 = "Thiªn T©m Th¸p ";
								text7 = "T©m Th¸p " + (i - 1024).ToString();
								text8 = text7;
								text9 = str2 + "50";
							}
						}
						else
						{
							text6 = "§iÓm Th­¬ng S¬n";
							text7 = "Th­¬ng S¬n " + (i - 1016).ToString();
							text8 = text7;
							text9 = str2 + "40";
						}
					}
				}
				else
				{
					text6 = "KiÕm C¸c T©y Na";
					text7 = "C¸c T©y Nam " + (i - 1000).ToString();
					text8 = text7;
					text9 = str2 + "20";
				}
				bool flag9 = text9 != null && text9 != string.Empty;
				if (flag9)
				{
					Array.Resize<Class35.Struct14>(ref Class35.struct14_0, Class35.struct14_0.Length + 1);
					ref Class35.Struct14 ptr = ref Class35.struct14_0[Class35.struct14_0.Length - 1];
					ptr = new Class35.Struct14
					{
						int_0 = i,
						string_0 = text6,
						string_2 = text7,
						string_3 = text8,
						string_4 = text9
					};
				}
			}
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0004E31C File Offset: 0x0004C51C
		private static void smethod_130()
		{
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 998,
					string_0 = "Hoa S¬n ChiÕn",
					string_2 = "POS|41216,102784,kÕt 1|49408,102464,kÕt 2|42240,92160,kÕt 3",
					string_4 = "o¹t B¶o R|Hoa S¬n"
				},
				Class35.smethod_1("S¨n H¹t Ho|Sinh T"),
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "ChiÕn Long §éng",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = null,
					string_4 = "ChiÕn Long"
				},
				new Class35.Struct14
				{
					int_0 = -1,
					string_3 = "VANTIEU",
					string_4 = "VËn Tiªu|Hé Tèn|TÝnh N¨ng"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("luyÖn c«ng|cÊp 9"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0004E44C File Offset: 0x0004C64C
		private static void smethod_131()
		{
			string str = "TÝnh N¨ng|";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 968,
					string_0 = "NguyÖt Ca §¶o",
					string_2 = "n NguyÖt Ca",
					string_4 = str + "NguyÖt Ca"
				},
				new Class35.Struct14
				{
					int_0 = 355,
					string_0 = "Doanh tr¹i (cao",
					string_2 = "POS|50304,78016,B¾c|38592,100992,Nam|49440,99520,§«ng|38976,78464,T©y",
					string_4 = str + "Gi¶i Cøu"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(str + "Tèng Kim"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("ThÞ & Th«n|9X"), false);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0004E550 File Offset: 0x0004C750
		private static void smethod_132()
		{
			Class35.smethod_58();
			string text = "luyÖn c«ng|Êp 90";
			string text2 = "luyÖn c«ng|t©n thñ";
			string newValue = "dông thuËt|Êp 90";
			string newValue2 = "dông thuËt|luyÖn c«ng";
			for (int i = 0; i < Class35.struct14_0.Length; i++)
			{
				bool flag = Class35.struct14_0[i].int_0 != 959;
				if (flag)
				{
					bool flag2 = 0 > Class35.struct14_0[i].string_4.IndexOf(text);
					if (flag2)
					{
						bool flag3 = 0 <= Class35.struct14_0[i].string_4.IndexOf(text2);
						if (flag3)
						{
							Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text2, newValue2);
						}
					}
					else
					{
						Class35.struct14_0[i].string_4 = Class35.struct14_0[i].string_4.Replace(text, newValue);
					}
				}
				else
				{
					Class35.struct14_0[i].int_0 = -1;
					Class35.struct14_0[i].string_0 = null;
					Class35.struct14_0[i].string_2 = null;
					Class35.struct14_0[i].string_4 = null;
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0004E6AC File Offset: 0x0004C8AC
		private static void smethod_133()
		{
			Class35.smethod_33(false);
			Class35.Struct14[] struct14_ = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 959,
					string_0 = "S¬ vµ Trung",
					string_2 = "POS|54243,101038,La Tiªu|45664,95840,Vò Di|49664,95616,T­êng V©n",
					string_3 = "S¬ CÊp",
					string_4 = "S¬ CÊp"
				},
				new Class35.Struct14
				{
					int_0 = 977,
					string_0 = "Cao vµ Hoµng K",
					string_2 = "Cao CÊp",
					string_3 = "Cao CÊp",
					string_4 = "Cao CÊp"
				},
				Class35.smethod_1("Sinh T")
			};
			Class35.smethod_0(ref Class35.struct14_0, struct14_, false);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0004E780 File Offset: 0x0004C980
		private static void smethod_134()
		{
			string str = "N¬i Muèn";
			string str2 = str + "|Khu Vùc LuyÖn C";
			string str3 = str2 + "| ";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 199,
					string_0 = "Vò L¨ng ®éng",
					string_2 = "Vò L¨ng",
					string_3 = "Vò L¨ng",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 202,
					string_0 = "Phï Dung ®éng",
					string_2 = "Phï Dung",
					string_3 = "Phï Dung",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 201,
					string_0 = Class35.string_29,
					string_2 = "B¨ng Hµ",
					string_3 = "B¨ng Hµ",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 204,
					string_0 = "Phi Thiªn ®éng",
					string_2 = "Phi Thiªn",
					string_3 = "Phi Thiªn",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 205,
					string_0 = "D­¬ng Trung ®én",
					string_2 = "D­¬ng Trung",
					string_3 = "D­¬ng Trung",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 203,
					string_0 = "V« Danh ®éng",
					string_2 = "V« Danh",
					string_3 = "V« Danh",
					string_4 = str3 + "80"
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = Class35.string_49,
					string_3 = Class35.string_49,
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 55,
					string_0 = "§µo Hoa Nguyªn",
					string_2 = "§µo Hoa Nguyªn",
					string_3 = null,
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 142,
					string_0 = Class35.string_33,
					string_2 = "D­îc V­¬ng",
					string_3 = null,
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 72,
					string_0 = "§¹i Tï ®éng",
					string_2 = "§¹i Tï",
					string_3 = "§¹i Tï",
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 169,
					string_0 = "Long Nh·n ®éng",
					string_2 = "Long Nh·n",
					string_3 = "Long Nh·n",
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 123,
					string_0 = "L·o Hæ ®éng",
					string_2 = "L·o Hæ",
					string_3 = "L·o Hæ",
					string_4 = str3 + "70"
				},
				new Class35.Struct14
				{
					int_0 = 117,
					string_0 = "T­êng V©n ®éng",
					string_2 = "T­êng V©n §éng",
					string_3 = null,
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 166,
					string_0 = "Thiªn TÇm th¸p",
					string_2 = "Thiªn T©m Th¸p",
					string_3 = null,
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 79,
					string_0 = "MËt ®¹o Nha m«n",
					string_2 = "Nha M«n",
					string_3 = null,
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 196,
					string_0 = "D­¬ng Gi¸c ®éng",
					string_2 = "Du¬ng Gi¸c",
					string_3 = null,
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 56,
					string_0 = "S¬n Ph¸i",
					string_2 = "S¬n Ph¸i",
					string_3 = "s¬n Ph",
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 94,
					string_0 = "Linh Cèc ®éng",
					string_2 = "Linh Cèc",
					string_3 = "Linh Cèc",
					string_4 = str3 + "60"
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy ®éng",
					string_2 = "H­ëng Thñy ®éng",
					string_3 = "H­ëng Thñy",
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 42,
					string_0 = "Thiªn T©m ®éng",
					string_2 = "Thiªn T©m",
					string_3 = "Thiªn T©m",
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 38,
					string_0 = "ThiÕt th¸p tÇng",
					string_2 = "ThiÕt Th¸p Mª Cung",
					string_3 = "ThiÕt Th¸p",
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 182,
					string_0 = "NghiÖt Long ®én",
					string_2 = "NghiÖt Long",
					string_3 = "NghiÖt Long",
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 66,
					string_0 = "§¸y §éng §×nh h",
					string_2 = "§éng §×nh Hå",
					string_3 = null,
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 163,
					string_0 = "¸c b¸ ®Þa ®¹o",
					string_2 = "¸c B¸",
					string_3 = null,
					string_4 = str3 + "50"
				},
				new Class35.Struct14
				{
					int_0 = 173,
					string_0 = "§iÓm Th­¬ng ®én",
					string_2 = "§iÓm Th­¬ng §éng TÇng 3",
					string_3 = null,
					string_4 = str3 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 21,
					string_0 = "Thanh Thµnh s¬n",
					string_2 = "Thanh Thµnh",
					string_3 = "Thanh Thµnh",
					string_4 = str3 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 23,
					string_0 = "ThÇn Tiªn ®éng",
					string_2 = "ThÇn Tiªn",
					string_3 = "ThÇn Tiªn",
					string_4 = str3 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 5,
					string_0 = "Kinh Hoµng ®éng",
					string_2 = "Kinh Hoµng",
					string_3 = "Kinh Hoµng",
					string_4 = str3 + "40"
				},
				new Class35.Struct14
				{
					int_0 = 22,
					string_0 = "B¹ch V©n ®éng",
					string_2 = "B¹ch V©n",
					string_3 = "B¹ch V©n",
					string_4 = str3 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 77,
					string_0 = "YÕn Tö ®éng",
					string_2 = "YÕn Tö",
					string_3 = "YÕn Tö",
					string_4 = str3 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 92,
					string_0 = "Thôc C­¬ng s¬n",
					string_2 = "Thôc C­¬ng",
					string_3 = "Thôc C­¬ng",
					string_4 = str3 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 145,
					string_0 = Class35.string_36,
					string_2 = "TuyÕt B¸o §éng",
					string_3 = Class35.string_36,
					string_4 = str3 + "30"
				},
				new Class35.Struct14
				{
					int_0 = 140,
					string_0 = "D­îc V­¬ng Cèc",
					string_2 = "D­îc V­¬ng Cèc",
					string_3 = "D­îc V­¬ng",
					string_4 = str3 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 7,
					string_0 = "TÇn L¨ng",
					string_2 = "TÇn L¨ng",
					string_3 = "L¨ng TÇn",
					string_4 = str3 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 70,
					string_0 = "Vu L¨ng s¬n",
					string_2 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_3 = "Vu L¨ng s¬n|Vò L¨ng s¬n",
					string_4 = str3 + "20"
				},
				new Class35.Struct14
				{
					int_0 = 2,
					string_0 = "Hoa S¬n",
					string_2 = "Hoa S¬n",
					string_3 = null,
					string_4 = str3 + "20"
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(str + "|Thµnh ThÞ", str + "|Th«n"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(str + "|M«n ph¸i"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(str + "|Tèng Kim"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str3 + "90"), false);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0004F370 File Offset: 0x0004D570
		private static void smethod_135()
		{
			string str = "dông thuËt";
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 977,
					string_0 = "B¶n §å Hßa B×nh",
					string_2 = "h¸i qu¶",
					string_4 = str
				},
				new Class35.Struct14
				{
					int_0 = 1018,
					string_0 = "BÝ C¶nh Gia Lon",
					string_2 = "BÝ C¶nh",
					string_4 = str
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(str + "|Thµnh th", str + "|Th«n tr"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(str + "|M«n ph¸i"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(str + "|Tèng Kim"), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6(str + "|p 90"), false);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0004F484 File Offset: 0x0004D684
		private static void config_THP()
		{
			Class35.smethod_8();
			Class35.struct14_0 = new Class35.Struct14[]
			{
				new Class35.Struct14
				{
					int_0 = 224,
					string_0 = Class35.string_47,
					string_2 = Class35.string_58,
					string_3 = "Sa M¹c Mª",
					string_4 = Class35.string_68
				},
				new Class35.Struct14
				{
					int_0 = 170,
					string_0 = Class35.string_48,
					string_2 = "3x",
					string_3 = "Thæ PhØ",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 171,
					string_0 = "§iÓm Th­¬ng §én",
					string_2 = "4x",
					string_3 = "§iÓm Th­¬ng",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 24,
					string_0 = "H­ëng Thñy §éng",
					string_2 = "5x",
					string_3 = "H­ëng Thñy",
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 158,
					string_0 = "Mª Cung CÊm §Þa",
					string_2 = "6x",
					string_3 = null,
					string_4 = Class35.string_67
				},
				new Class35.Struct14
				{
					int_0 = 319,
					string_0 = Class35.string_49,
					string_2 = "7x",
					string_3 = "L©m Du",
					string_4 = Class35.string_67
				}
			};
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_4(null, null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_5(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_2(null), false);
			Class35.smethod_0(ref Class35.struct14_0, Class35.smethod_6("dông thuËt|ªn 90"), false);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0004F6B4 File Offset: 0x0004D8B4
		public static bool smethod_136()
		{
			Class35.string_0 = Class35.string_1;
			int num = Class35.int_1;
			int num2 = num;
			if (num2 != 1)
			{
				Class35.smethod_8();
			}
			else
			{
				Class35.smethod_8();
				Class35.smethod_80(false);
			}
			return Class35.string_0 != null && Class35.struct14_0 != null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0004F708 File Offset: 0x0004D908
		public static int smethod_137(object object_0)
		{
			bool flag = object_0 == null;
			int result;
			if (flag)
			{
				result = -1;
			}
			else
			{
				string text = object_0.ToString();
				bool flag2 = !(text == string.Empty);
				if (flag2)
				{
					int num = -1;
					int num2 = -1;
					string[] array = typeof(string).ToString().Split(new char[]
					{
						'.'
					});
					string value = array[array.Length - 1].ToUpper();
					bool flag4;
					bool flag3 = !(flag4 = (0 <= object_0.GetType().ToString().ToUpper().IndexOf(value)));
					if (flag3)
					{
						num2 = Class12.smethod_11(text);
						bool flag5 = num2 <= 0;
						if (flag5)
						{
							return -1;
						}
					}
					bool flag6 = Class35.struct14_0 == null && !Class35.smethod_136();
					if (flag6)
					{
						result = -1;
					}
					else
					{
						for (int i = 0; i < Class35.struct14_0.Length; i++)
						{
							bool flag7 = !flag4;
							if (flag7)
							{
								bool flag8 = num2 > 0 && num2 == Class35.struct14_0[i].int_0;
								if (flag8)
								{
									num = i;
									break;
								}
							}
							else
							{
								bool flag9 = text == Class35.struct14_0[i].string_0 || text == Class35.struct14_0[i].string_2 || Class12.smethod_1(text, Class35.struct14_0[i].string_0) == 0 || Class12.smethod_1(Class35.struct14_0[i].string_0, text) == 0 || Class12.smethod_1(text, Class35.struct14_0[i].string_2) == 0 || Class12.smethod_1(Class35.struct14_0[i].string_2, text) == 0;
								if (flag9)
								{
									num = i;
									break;
								}
							}
						}
						result = num;
					}
				}
				else
				{
					result = -1;
				}
			}
			return result;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0004F8F8 File Offset: 0x0004DAF8
		private static string smethod_138(object object_0, uint[] uint_7)
		{
			bool flag = uint_7 == null;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = Class35.smethod_137(object_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Class35.struct14_0 == null && !Class35.smethod_136();
					if (flag3)
					{
						result = null;
					}
					else
					{
						int num2 = Class35.struct14_0[num].int_0;
						bool flag4 = num2 > 0;
						if (flag4)
						{
							int num3 = Class43.smethod_0(num2);
							for (int i = 0; i < Class35.struct15_0.Length; i++)
							{
								bool flag5 = num2 != Class35.struct15_0[i].int_0 && num3 != Class35.struct15_0[i].int_0;
								if (!flag5)
								{
									int num4 = -1;
									long num5 = -1L;
									uint[,] array = Class35.struct15_0[i].uint_0;
									for (int j = 0; j < array.GetLength(0); j++)
									{
										bool flag6 = array[j, 0] > 0U;
										if (flag6)
										{
											long num6 = Class60.smethod_18(uint_7, new uint[]
											{
												array[j, 0],
												array[j, 1]
											});
											bool flag7 = num4 < 0 || num6 < num5;
											if (flag7)
											{
												num4 = j;
												num5 = num6;
											}
										}
									}
									bool flag8 = 0 <= num4;
									if (flag8)
									{
										return Class35.string_0[num4];
									}
								}
							}
							result = null;
						}
						else
						{
							result = null;
						}
					}
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0004FA90 File Offset: 0x0004DC90
		private static int smethod_139(int int_3)
		{
			for (int i = 0; i < Class35.int_2.Length; i++)
			{
				bool flag = int_3 == Class35.int_2[i];
				if (flag)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0004FAD0 File Offset: 0x0004DCD0
		public static bool smethod_140(GStruct49 gstruct49_0, object object_0, string string_74 = null, uint[] uint_7 = null, bool bool_0 = false)
		{
			int num = 0;
			byte[] array = new byte[4];
			new byte[256];
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			bool flag = num != 4;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				uint num2 = BitConverter.ToUInt32(array, 0);
				Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
				uint num3 = BitConverter.ToUInt32(array, 0);
				uint num4 = num3 * Class53.gstruct51_15.uint_0;
				Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
				bool flag2 = num == 4;
				if (flag2)
				{
					uint num5 = BitConverter.ToUInt32(array, 0);
					uint num6 = num5 + num4;
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
					int num7 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
					int num8 = BitConverter.ToInt32(array, 0);
					Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
					int num9 = BitConverter.ToInt32(array, 0);
					int num10 = Class83.smethod_39(gstruct49_0);
					bool flag3 = num8 != 0 && num9 != 0 && num7 != 0 && num10 > 1;
					if (flag3)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
						int num11 = BitConverter.ToInt32(array, 0);
						int num12 = 0;
						int num13;
						string text;
						int num14;
						for (;;)
						{
							num13 = Class35.smethod_137(object_0);
							bool flag4 = num13 < 0;
							if (flag4)
							{
								break;
							}
							bool flag5 = Class35.struct14_0 != null || Class35.smethod_136();
							if (!flag5)
							{
								goto IL_B0E;
							}
							text = Class35.struct14_0[num13].string_4;
							bool flag6 = text != null && !(text == string.Empty);
							if (!flag6)
							{
								goto IL_B09;
							}
							num14 = Class35.struct14_0[num13].int_0;
							bool flag7 = num14 == 977 && num9 != 78 && num9 != 977 && num12 == 0;
							if (!flag7)
							{
								goto IL_230;
							}
							object_0 = 78;
							string_74 = "b¾c";
							num12 = 1;
						}
						return false;
						IL_230:
						string text2 = Class35.struct14_0[num13].string_2;
						bool flag8 = text2.IndexOf("POS") == 0;
						if (flag8)
						{
							string[] array2 = text2.Split(new char[]
							{
								'|',
								',',
								';'
							});
							bool flag9 = array2.Length > 3;
							if (flag9)
							{
								int num15 = array2.Length / 3;
								uint[] array3 = new uint[2];
								uint[] array4 = new uint[2];
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_58.uint_0, array, 4, ref num);
								array4[0] = BitConverter.ToUInt32(array, 0);
								Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_57.uint_0 + Class53.gstruct51_59.uint_0, array, 4, ref num);
								array4[1] = BitConverter.ToUInt32(array, 0);
								bool flag10 = uint_7 != null;
								if (flag10)
								{
									array4[0] = uint_7[0];
									array4[1] = uint_7[1];
								}
								else
								{
									bool flag11 = Class44.gstruct33_0.uint_4 != null && Class44.gstruct33_0.uint_4[0] != 0U && Class44.gstruct33_0.uint_4[1] > 0U;
									if (flag11)
									{
										array4[0] = Class44.gstruct33_0.uint_4[0];
										array4[1] = Class44.gstruct33_0.uint_4[1];
									}
								}
								long num16 = -1L;
								string text3 = null;
								for (int i = 0; i < num15; i++)
								{
									array3[0] = Class12.smethod_12(array2[1 + i * 3]);
									array3[1] = Class12.smethod_12(array2[1 + i * 3 + 1]);
									long num17 = Class60.smethod_18(array4, array3);
									bool flag12 = text3 == null || text3 == string.Empty || num16 > num17;
									if (flag12)
									{
										text3 = array2[1 + i * 3 + 2];
										num16 = num17;
									}
								}
								bool flag13 = text3 != null;
								if (flag13)
								{
									text2 = text3;
								}
							}
						}
						text = (((num14 == 959 || num14 == 990) && string_74 != null && string_74 != string.Empty) ? (text + "|" + string_74) : (text + "|" + text2));
						string text4 = Class35.struct14_0[num13].string_5;
						bool flag14 = true;
						bool flag15 = string_74 == null || string_74 == string.Empty;
						if (flag15)
						{
							bool flag16 = Class12.smethod_62(uint_7);
							if (flag16)
							{
								string_74 = Class35.smethod_138(num14, uint_7);
							}
							bool flag17 = string_74 == null;
							if (flag17)
							{
								string_74 = Class35.struct14_0[num13].string_1;
							}
						}
						if (bool_0)
						{
							string[] array5 = text.Split(new char[]
							{
								'|'
							});
							bool flag18 = array5.Length > 1;
							if (flag18)
							{
								text = "håi sinh|u R­¬ng| r­¬ng|iÓm Quay L¹i";
								for (int j = 1; j < array5.Length; j++)
								{
									text = text + "|" + array5[j];
								}
								text += "|Õt thóc";
							}
						}
						bool flag19 = flag14 && string_74 != null;
						if (flag19)
						{
							text = text + "|" + string_74;
						}
						int num18 = 0;
						int num19 = Class35.random_0.Next(10, 100);
						while (num18 < 40 && Class70.smethod_3(gstruct49_0, Class70.uint_5, 4) > 0)
						{
							num18++;
							Thread.Sleep(40 + num19);
						}
						Class70.smethod_2(gstruct49_0, Class70.uint_5, 1, 4);
						int num20 = 0;
						string text5 = "ThÇn Hµnh Phï";
						bool flag21;
						bool flag20 = flag21 = (text4 != null && text4 != string.Empty);
						if (flag21)
						{
							text5 = text4;
						}
						bool flag22 = false;
						uint num21 = (uint)Class70.smethod_3(gstruct49_0, Class70.uint_19, 4);
						bool flag23 = !flag20 && num21 > 0U;
						if (flag23)
						{
							Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
							uint num22 = BitConverter.ToUInt32(array, 0);
							uint num23 = num22 + Class53.gstruct51_97.uint_0;
							Class22.ReadProcessMemory(gstruct49_0.int_137, num23 + (num21 * 5U + Class53.gstruct51_99.uint_0) * 4U, array, 4, ref num);
							uint num24 = BitConverter.ToUInt32(array, 0);
							uint num25 = (uint)Class70.smethod_3(gstruct49_0, Class70.uint_19 + 1U, 4);
							bool flag24 = num24 != 0U && num24 == num25;
							if (flag24)
							{
								uint num26 = num23 + num21 * 20U;
								Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_100.uint_0 - 8U, array, 1, ref num);
								int num27 = (int)array[0];
								bool flag25 = num27 == 3;
								if (flag25)
								{
									Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_105.uint_0, array, 4, ref num);
									bool flag26 = num != 4;
									if (flag26)
									{
										return false;
									}
									uint num28 = BitConverter.ToUInt32(array, 0);
									uint num29 = num28 + num24 * Class53.gstruct51_106.uint_0;
									byte[] array6 = new byte[text5.Length + 2];
									Class22.ReadProcessMemory(gstruct49_0.int_137, num29 + Class53.gstruct51_107.uint_0, array6, array6.Length, ref num);
									string text6 = Class10.smethod_3(array6).Replace(" ", string.Empty).ToLower();
									bool flag27 = text6.IndexOf(text5.Replace(" ", string.Empty).ToLower()) >= 0;
									if (flag27)
									{
										Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_100.uint_0 - 4U, array, 1, ref num);
										int num30 = (int)array[0];
										Class22.ReadProcessMemory(gstruct49_0.int_137, num26 + Class53.gstruct51_100.uint_0, array, 1, ref num);
										int num31 = (int)array[0];
										Class86.smethod_8(gstruct49_0, -1);
										Thread.Sleep(100);
										flag22 = Class70.smethod_43(gstruct49_0, num25, num30, num31, 3);
									}
								}
							}
						}
						bool flag28 = !flag22;
						if (flag28)
						{
							Class86.smethod_8(gstruct49_0, -1);
							Thread.Sleep(100);
							flag22 = Class70.smethod_44(gstruct49_0, text5, false, -1, flag20);
						}
						bool flag29 = flag22;
						if (flag29)
						{
							int k = 0;
							while (k < 7)
							{
								k++;
								bool flag30 = 0 > Class86.smethod_0(gstruct49_0);
								if (!flag30)
								{
									k = 0;
									break;
								}
								Thread.Sleep(100 + Class86.int_0);
							}
							bool flag31 = k <= 0;
							if (flag31)
							{
								Console.WriteLine("text : " + text);
								num20 = Class86.smethod_6(gstruct49_0, text, false, flag14, false, bool_0);
								Console.WriteLine("num19 : " + num20.ToString());
								bool flag32 = !bool_0 && num20 > 0;
								if (flag32)
								{
									Thread.Sleep(300);
									int num32 = num11;
									int num33 = num9;
									int num34 = 0;
									int num35 = 0;
									while (!Class12.bool_0 && num34 < 10)
									{
										num34++;
										Thread.Sleep(60 + Class86.int_0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
										bool flag33 = num == 4;
										if (!flag33)
										{
											return false;
										}
										num2 = BitConverter.ToUInt32(array, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_13.uint_0, array, 4, ref num);
										num3 = BitConverter.ToUInt32(array, 0);
										num4 = num3 * Class53.gstruct51_15.uint_0;
										Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_14.uint_0, array, 4, ref num);
										bool flag34 = num == 4;
										if (!flag34)
										{
											return false;
										}
										num5 = BitConverter.ToUInt32(array, 0);
										num6 = num5 + num4;
										Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_55.uint_0, array, 4, ref num);
										num7 = BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num);
										num8 = BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + Class53.gstruct51_43.uint_0, array, 4, ref num);
										num32 = BitConverter.ToInt32(array, 0);
										Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_27.uint_0, array, 4, ref num);
										num33 = BitConverter.ToInt32(array, 0);
										num10 = Class83.smethod_39(gstruct49_0);
										bool flag35 = num8 != 0 && num33 != 0 && num7 != 0 && num10 > 1;
										if (flag35)
										{
											bool flag36 = num11 > 0 || num35 > 3 || num33 != num9 || num32 != num11;
											if (flag36)
											{
												break;
											}
											num35++;
										}
										else
										{
											num35 = 0;
										}
									}
									bool flag37 = num33 != num9 || num32 != num11;
									if (flag37)
									{
										num20 = 1;
									}
									num11 = num32;
								}
							}
							bool flag38 = num11 == 0 && 0 <= Class86.smethod_0(gstruct49_0);
							if (flag38)
							{
								Class86.smethod_8(gstruct49_0, -1);
								bool flag39 = Form1.int_119 <= 0 && Class37.smethod_0(gstruct49_0) == num9;
								if (flag39)
								{
									Class35.smethod_143(gstruct49_0, -1);
								}
							}
						}
						Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
						return num20 > 0;
						IL_B09:
						return false;
						IL_B0E:
						result = false;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0005060C File Offset: 0x0004E80C
		public static bool smethod_141(GStruct49 gstruct49_0, string string_74)
		{
			int num = 0;
			int num2 = Class35.random_0.Next(10, 100);
			while (num < 40 && Class70.smethod_3(gstruct49_0, Class70.uint_5, 4) > 0)
			{
				num++;
				Thread.Sleep(40 + num2);
			}
			int num3 = 0;
			Class37.smethod_0(gstruct49_0);
			bool flag = Class70.smethod_44(gstruct49_0, "ThÇn Hµnh Phï", false, -1, false);
			if (flag)
			{
				int i = 0;
				while (i < 7)
				{
					i++;
					bool flag2 = 0 > Class86.smethod_0(gstruct49_0);
					if (!flag2)
					{
						i = 0;
						break;
					}
					Thread.Sleep(100 + Class86.int_0);
				}
				bool flag3 = i <= 0;
				if (flag3)
				{
					Thread.Sleep(230);
					num3 = Class86.smethod_6(gstruct49_0, string_74, false, true, false, false);
					bool flag4 = num3 > 0;
					if (flag4)
					{
						Thread.Sleep(300);
						Class60.smethod_11(gstruct49_0, 15000);
					}
				}
				Class86.smethod_8(gstruct49_0, -1);
			}
			Class70.smethod_2(gstruct49_0, Class70.uint_5, 0, 4);
			return num3 > 0;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00050720 File Offset: 0x0004E920
		public static int smethod_142(GStruct49 gstruct49_0, int int_3 = 1)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < Class35.struct14_0.Length;
				if (!flag)
				{
					goto IL_67;
				}
				bool flag2 = (int_3 != 53 && Class35.struct14_0[num].string_3 == "VANTIEU") || (int_3 == 53 && Class35.struct14_0[num].string_3 == "VANTIEUBANG");
				if (flag2)
				{
					break;
				}
				num++;
			}
			Class35.smethod_141(gstruct49_0, Class35.struct14_0[num].string_4);
			return 1;
			IL_67:
			return 0;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000507BC File Offset: 0x0004E9BC
		public static void smethod_143(GStruct49 gstruct49_0, int int_3 = -1)
		{
			bool flag = Class70.smethod_1(gstruct49_0, Class70.uint_18) >= 60 && (int_3 <= 0 || Class35.smethod_139(int_3) >= 0);
			if (flag)
			{
				string str = "Ac phô kh«ng thÓ ®i b»ng ThÇn Hµnh phï, qua tab Cµi game cña auto chän l¹i WEB, t¾t th«ng b¸o nµy trong më réng nÕu muèn.";
				Class70.smethod_52(gstruct49_0, "<bclr=blue><color=green>" + str, 1);
				bool flag2 = Class44.gstruct33_0.int_0 > 0 && Class44.gstruct33_0.int_0 != gstruct49_0.int_136;
				if (flag2)
				{
					Class70.smethod_50(gstruct49_0, Class44.gstruct33_0.string_0, str);
				}
				Class70.smethod_0(gstruct49_0, Class70.uint_18);
			}
		}

		// Token: 0x040000ED RID: 237
		public static int int_0 = Class62.smethod_3("fChayboLThuydong", 0, "0");

		// Token: 0x040000EE RID: 238
		public static int int_1 = 0;

		// Token: 0x040000EF RID: 239
		public static string[] string_0 = null;

		// Token: 0x040000F0 RID: 240
		public static Class35.Struct14[] struct14_0 = null;

		// Token: 0x040000F1 RID: 241
		private static string[] string_1 = new string[]
		{
			"®«ng|§«ng",
			"t©y",
			"nam",
			"b¾c",
			"t©m"
		};

		// Token: 0x040000F2 RID: 242
		private static string string_2 = "ThÇn Hµnh Phï (Thµnh Cæ)|ThÇn Hµnh Phï (B¶n §å Ho¹t §éng)";

		// Token: 0x040000F3 RID: 243
		private static string string_3 = "dông thuËt|thÞ vµ th«n|ThÞ - Th«n|thµnh thÞ th«n trÊn|ThÞ & Th«n|khu vùc phi|dông thÇn hµnh";

		// Token: 0x040000F4 RID: 244
		private static string string_4 = Class35.string_3 + "|hµnh thÞ";

		// Token: 0x040000F5 RID: 245
		private static string string_5 = Class35.string_3 + "|h«n trang|h«n tr";

		// Token: 0x040000F6 RID: 246
		private static string string_6 = Class35.string_3 + "|«n ph¸i";

		// Token: 0x040000F7 RID: 247
		private static string string_7 = "Tèng Kim|Phong V©n|Tèng-Kim|ng Tèng";

		// Token: 0x040000F8 RID: 248
		private static string string_8 = Class35.string_3 + "|" + Class35.string_7;

		// Token: 0x040000F9 RID: 249
		private static string string_9 = "T­¬ng D­¬ng";

		// Token: 0x040000FA RID: 250
		private static string string_10 = "D­¬ng Ch©u";

		// Token: 0x040000FB RID: 251
		private static string string_11 = "Ph­îng T­êng";

		// Token: 0x040000FC RID: 252
		private static string string_12 = "§¹i Lý";

		// Token: 0x040000FD RID: 253
		private static string string_13 = "Thµnh §«";

		// Token: 0x040000FE RID: 254
		private static string string_14 = "L©m An";

		// Token: 0x040000FF RID: 255
		private static string string_15 = "BiÖn Kinh";

		// Token: 0x04000100 RID: 256
		private static string string_16 = "§iÓm b¸o danh";

		// Token: 0x04000101 RID: 257
		private static string string_17 = "Ba L¨ng huyÖn";

		// Token: 0x04000102 RID: 258
		private static string string_18 = "Giang T©n Th«n";

		// Token: 0x04000103 RID: 259
		private static string string_19 = "VÜnh L¹c trÊn";

		// Token: 0x04000104 RID: 260
		private static string string_20 = "Chu Tiªn trÊn";

		// Token: 0x04000105 RID: 261
		private static string string_21 = "§¹o H­¬ng th«n";

		// Token: 0x04000106 RID: 262
		private static string string_22 = "Long M«n trÊn";

		// Token: 0x04000107 RID: 263
		private static string string_23 = "Th¹ch Cæ trÊn";

		// Token: 0x04000108 RID: 264
		private static string string_24 = "Long TuyÒn th«n";

		// Token: 0x04000109 RID: 265
		private static string string_25 = "T©y S¬n th«n";

		// Token: 0x0400010A RID: 266
		private static string string_26 = "Thanh khª ®éng";

		// Token: 0x0400010B RID: 267
		private static string string_27 = "Ch©n nói Tr­êng";

		// Token: 0x0400010C RID: 268
		private static string string_28 = "L­ìng Thñy ®éng";

		// Token: 0x0400010D RID: 269
		private static string string_29 = "B¨ng Hµ ®éng";

		// Token: 0x0400010E RID: 270
		private static string string_30 = "Phong L¨ng ®é";

		// Token: 0x0400010F RID: 271
		private static string string_31 = "Phong L¨ng";

		// Token: 0x04000110 RID: 272
		private static string string_32 = "M¹c Cao QuËt";

		// Token: 0x04000111 RID: 273
		private static string string_33 = "D­îc V­¬ng ®éng";

		// Token: 0x04000112 RID: 274
		private static string string_34 = "TiÕn Cóc ®éng";

		// Token: 0x04000113 RID: 275
		private static string string_35 = "C¸n Viªn ®éng";

		// Token: 0x04000114 RID: 276
		private static string string_36 = "TuyÕt B¸o ®éng";

		// Token: 0x04000115 RID: 277
		private static string string_37 = "TÝch HuyÕt Cèc";

		// Token: 0x04000116 RID: 278
		private static string string_38 = "¸c Nh©n Cèc";

		// Token: 0x04000117 RID: 279
		private static string string_39 = "Thùc Cèt Nhai";

		// Token: 0x04000118 RID: 280
		private static string string_40 = "H¾c Méc Nhai";

		// Token: 0x04000119 RID: 281
		private static string string_41 = "Thiªn Phô S¬n";

		// Token: 0x0400011A RID: 282
		private static string string_42 = "Bµn Long S¬n";

		// Token: 0x0400011B RID: 283
		private static string string_43 = "§Þa MÉu S¬n";

		// Token: 0x0400011C RID: 284
		private static string string_44 = "UyÓn Ph­îng S¬n";

		// Token: 0x0400011D RID: 285
		private static string string_45 = "Mª Cung KiÕm Gia";

		// Token: 0x0400011E RID: 286
		private static string string_46 = "¸c Lang Cèc";

		// Token: 0x0400011F RID: 287
		private static string string_47 = "Sa m¹c ®Þa biÓu";

		// Token: 0x04000120 RID: 288
		private static string string_48 = "Thæ PhØ §éng";

		// Token: 0x04000121 RID: 289
		private static string string_49 = "L©m Du Quan";

		// Token: 0x04000122 RID: 290
		private static string string_50 = "H¾c Sa ®éng";

		// Token: 0x04000123 RID: 291
		private static string string_51 = "H¾c Sa";

		// Token: 0x04000124 RID: 292
		private static string string_52 = "Tr­êng B¹ch s¬n";

		// Token: 0x04000125 RID: 293
		private static string string_53 = "Sa M¹c 1";

		// Token: 0x04000126 RID: 294
		private static string string_54 = "Sa M¹c 2";

		// Token: 0x04000127 RID: 295
		private static string string_55 = "Sa M¹c 3";

		// Token: 0x04000128 RID: 296
		private static string string_56 = Class35.string_53 + "|Sa M¹c Mª Cung 1|c s¬n  ®éng 1|c s¬n ®éng 1";

		// Token: 0x04000129 RID: 297
		private static string string_57 = Class35.string_54 + "|Sa M¹c Mª Cung 2|c s¬n  ®éng 2|c s¬n ®éng 2";

		// Token: 0x0400012A RID: 298
		private static string string_58 = Class35.string_55 + "|Sa M¹c Mª Cung 3|c s¬n  ®éng 3|c s¬n ®éng 3";

		// Token: 0x0400012B RID: 299
		private static string string_59 = "Sa M¹c Mª Cung";

		// Token: 0x0400012C RID: 300
		private static string string_60 = "Tr­êng B¹ch s¬n B¾c";

		// Token: 0x0400012D RID: 301
		private static string string_61 = "Tr­êng B¹ch s¬n Nam";

		// Token: 0x0400012E RID: 302
		private static string string_62 = "Kho¶ Lang ®éng";

		// Token: 0x0400012F RID: 303
		private static string string_63 = "Kho¶ Lang §éng";

		// Token: 0x04000130 RID: 304
		private static string string_64 = "Kho¶ Lang|Kháa Lang";

		// Token: 0x04000131 RID: 305
		private static string string_65 = "Kho¶ Lang|Kháa Lang|Xi V­u";

		// Token: 0x04000132 RID: 306
		private static string string_66 = "rang kÕ|rang sa";

		// Token: 0x04000133 RID: 307
		private static string string_67 = "dông thuËt|luyÖn c«ng";

		// Token: 0x04000134 RID: 308
		private static string string_68 = "dông thuËt|Êp 9";

		// Token: 0x04000135 RID: 309
		private static string string_69 = Class35.string_68 + "|" + Class35.string_66;

		// Token: 0x04000136 RID: 310
		private static string string_70 = Class35.string_69 + "|" + Class35.string_66;

		// Token: 0x04000137 RID: 311
		private static string string_71 = "luyÖn c«ng|Êp 9";

		// Token: 0x04000138 RID: 312
		private static string string_72 = Class35.string_71 + "|" + Class35.string_66;

		// Token: 0x04000139 RID: 313
		private static string string_73 = Class35.string_72 + "|" + Class35.string_66;

		// Token: 0x0400013A RID: 314
		private static uint[,] uint_0;

		// Token: 0x0400013B RID: 315
		private static uint[,] uint_1;

		// Token: 0x0400013C RID: 316
		private static uint[,] uint_2;

		// Token: 0x0400013D RID: 317
		private static uint[,] uint_3;

		// Token: 0x0400013E RID: 318
		private static uint[,] uint_4;

		// Token: 0x0400013F RID: 319
		private static uint[,] uint_5;

		// Token: 0x04000140 RID: 320
		private static uint[,] uint_6;

		// Token: 0x04000141 RID: 321
		private static Class35.Struct15[] struct15_0;

		// Token: 0x04000142 RID: 322
		private static int[] int_2;

		// Token: 0x04000143 RID: 323
		private static Random random_0;

		// Token: 0x020000EC RID: 236
		public struct Struct14
		{
			// Token: 0x04001229 RID: 4649
			public int int_0;

			// Token: 0x0400122A RID: 4650
			public string string_0;

			// Token: 0x0400122B RID: 4651
			public string string_1;

			// Token: 0x0400122C RID: 4652
			public string string_2;

			// Token: 0x0400122D RID: 4653
			public string string_3;

			// Token: 0x0400122E RID: 4654
			public string string_4;

			// Token: 0x0400122F RID: 4655
			public string string_5;
		}

		// Token: 0x020000ED RID: 237
		public struct Struct15
		{
			// Token: 0x04001230 RID: 4656
			public string string_0;

			// Token: 0x04001231 RID: 4657
			public int int_0;

			// Token: 0x04001232 RID: 4658
			public uint[,] uint_0;
		}
	}
}
