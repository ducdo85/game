﻿using System;

namespace AutoKeoxe
{
	// Token: 0x02000021 RID: 33
	internal class Class37
	{
		// Token: 0x0600025B RID: 603 RVA: 0x00052AB8 File Offset: 0x00050CB8
		public static int smethod_0(GStruct49 gstruct49_0)
		{
			return (int)Class22.smethod_30(Class53.gstruct51_27.uint_0, gstruct49_0.int_137);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00052AE0 File Offset: 0x00050CE0
		public static string smethod_1(int int_0, bool bool_0 = false)
		{
			for (int i = 0; i < Class37.gstruct18_0.GetLength(0); i++)
			{
				bool flag = Class37.gstruct18_0[i].int_0 == int_0;
				if (flag)
				{
					string string_ = Class37.gstruct18_0[i].string_0;
					string result;
					if (bool_0)
					{
						result = Class10.smethod_1(string_, 1, false);
					}
					else
					{
						result = string_;
					}
					return result;
				}
			}
			return "";
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00052B58 File Offset: 0x00050D58
		public static string smethod_2(GStruct49 gstruct49_0)
		{
			bool flag = Class53.gstruct51_28.uint_0 == 0U || Class53.gstruct51_29.uint_0 == 0U;
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_28.uint_0 + Class53.gstruct51_29.uint_0;
				result = Class22.smethod_28(uint_, gstruct49_0.int_137, 60);
			}
			return result;
		}

		// Token: 0x04000148 RID: 328
		public static GStruct18[] gstruct18_0 = new GStruct18[]
		{
			new GStruct18
			{
				int_0 = 0,
				string_0 = "Kh«ng x¸c ®Þnh"
			},
			new GStruct18
			{
				int_0 = 1,
				string_0 = "Ph­îng T­êng"
			},
			new GStruct18
			{
				int_0 = 2,
				string_0 = "Hoa S¬n"
			},
			new GStruct18
			{
				int_0 = 3,
				string_0 = "KiÕm C¸c T©y B¾c"
			},
			new GStruct18
			{
				int_0 = 4,
				string_0 = "Kim Quang ®éng"
			},
			new GStruct18
			{
				int_0 = 5,
				string_0 = "Kinh Hoµng ®éng"
			},
			new GStruct18
			{
				int_0 = 6,
				string_0 = "Táa V©n ®éng"
			},
			new GStruct18
			{
				int_0 = 7,
				string_0 = "TÇn L¨ng"
			},
			new GStruct18
			{
				int_0 = 8,
				string_0 = "L¨ng TÇn Thñy Hoµng|TÇn L¨ng TÇng 1"
			},
			new GStruct18
			{
				int_0 = 9,
				string_0 = "Tr­êng Giang Nguyªn §Çu"
			},
			new GStruct18
			{
				int_0 = 10,
				string_0 = "Nh¹n Th¹ch ®éng"
			},
			new GStruct18
			{
				int_0 = 11,
				string_0 = "Thµnh §«"
			},
			new GStruct18
			{
				int_0 = 12,
				string_0 = "§Þa ®¹o hËu viÖn TÝn T­íng tù"
			},
			new GStruct18
			{
				int_0 = 13,
				string_0 = "Nga My ph¸i"
			},
			new GStruct18
			{
				int_0 = 14,
				string_0 = "M·nh Hæ ®éng"
			},
			new GStruct18
			{
				int_0 = 15,
				string_0 = "Gi¶ng Kinh §­êng"
			},
			new GStruct18
			{
				int_0 = 16,
				string_0 = "TiÒn ®iÖn"
			},
			new GStruct18
			{
				int_0 = 17,
				string_0 = "ChÝnh ®iÖn"
			},
			new GStruct18
			{
				int_0 = 18,
				string_0 = "T¶ Thiªn ®iÖn"
			},
			new GStruct18
			{
				int_0 = 19,
				string_0 = "KiÕm C¸c T©y Nam"
			},
			new GStruct18
			{
				int_0 = 20,
				string_0 = "Giang T©n Th«n"
			},
			new GStruct18
			{
				int_0 = 21,
				string_0 = "Thanh Thµnh S¬n"
			},
			new GStruct18
			{
				int_0 = 22,
				string_0 = "B¹ch V©n ®éng"
			},
			new GStruct18
			{
				int_0 = 23,
				string_0 = "ThÇn Tiªn ®éng"
			},
			new GStruct18
			{
				int_0 = 24,
				string_0 = "H­ëng Thñy ®éng"
			},
			new GStruct18
			{
				int_0 = 25,
				string_0 = "§­êng M«n"
			},
			new GStruct18
			{
				int_0 = 26,
				string_0 = "Tróc T¬ ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 27,
				string_0 = "Tróc T¬ ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 28,
				string_0 = "Tróc T¬ ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 29,
				string_0 = "¸m khÝ phßng"
			},
			new GStruct18
			{
				int_0 = 30,
				string_0 = "Háa khÝ phßng"
			},
			new GStruct18
			{
				int_0 = 31,
				string_0 = "Vâ c«ng phßng"
			},
			new GStruct18
			{
				int_0 = 32,
				string_0 = "Y d­îc phßng"
			},
			new GStruct18
			{
				int_0 = 33,
				string_0 = "Phßng kh¸ch"
			},
			new GStruct18
			{
				int_0 = 34,
				string_0 = "Phßng nghÞ sù"
			},
			new GStruct18
			{
				int_0 = 35,
				string_0 = "ChÝnh phßng"
			},
			new GStruct18
			{
				int_0 = 36,
				string_0 = "TÕ tæ ®­êng"
			},
			new GStruct18
			{
				int_0 = 37,
				string_0 = "BiÖn Kinh"
			},
			new GStruct18
			{
				int_0 = 38,
				string_0 = "ThiÕt th¸p tÇng 1"
			},
			new GStruct18
			{
				int_0 = 39,
				string_0 = "ThiÕt th¸p tÇng 2"
			},
			new GStruct18
			{
				int_0 = 40,
				string_0 = "ThiÕt th¸p tÇng 3"
			},
			new GStruct18
			{
				int_0 = 41,
				string_0 = "Phôc Ng­u S¬n T©y"
			},
			new GStruct18
			{
				int_0 = 42,
				string_0 = "Thiªn T©m ®éng"
			},
			new GStruct18
			{
				int_0 = 43,
				string_0 = "KiÕm C¸c Trung Nguyªn"
			},
			new GStruct18
			{
				int_0 = 44,
				string_0 = "ChiÕn tr­êng Tèng Kim"
			},
			new GStruct18
			{
				int_0 = 45,
				string_0 = "Thiªn NhÉn gi¸o"
			},
			new GStruct18
			{
				int_0 = 46,
				string_0 = "Thiªn NhÉn Gi¸o tÇng 1"
			},
			new GStruct18
			{
				int_0 = 47,
				string_0 = "Thiªn NhÉn Gi¸o tÇng 2"
			},
			new GStruct18
			{
				int_0 = 48,
				string_0 = "Thiªn NhÉn Gi¸o tÇng 2"
			},
			new GStruct18
			{
				int_0 = 49,
				string_0 = "Thiªn NhÉn Gi¸o tÇng 3"
			},
			new GStruct18
			{
				int_0 = 50,
				string_0 = "ThÊt S¸t ®éng"
			},
			new GStruct18
			{
				int_0 = 51,
				string_0 = "Th¸nh ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 52,
				string_0 = "Th¸nh ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 53,
				string_0 = "Ba L¨ng huyÖn"
			},
			new GStruct18
			{
				int_0 = 54,
				string_0 = "Nam Nh¹c trÊn"
			},
			new GStruct18
			{
				int_0 = 55,
				string_0 = "§µo Hoa Nguyªn"
			},
			new GStruct18
			{
				int_0 = 56,
				string_0 = "Hoµnh S¬n Ph¸i"
			},
			new GStruct18
			{
				int_0 = 57,
				string_0 = "Hoµnh S¬n ®¹i ®×nh"
			},
			new GStruct18
			{
				int_0 = 58,
				string_0 = "§éc C« KiÕm Ngäa thÊt"
			},
			new GStruct18
			{
				int_0 = 59,
				string_0 = "Thiªn V­¬ng Bang"
			},
			new GStruct18
			{
				int_0 = 60,
				string_0 = "TiÒn ®iÖn"
			},
			new GStruct18
			{
				int_0 = 61,
				string_0 = "Thiªn V­¬ng §¹i ®iÖn"
			},
			new GStruct18
			{
				int_0 = 62,
				string_0 = "TÈm cung"
			},
			new GStruct18
			{
				int_0 = 63,
				string_0 = "Phßng ®Ö tö 1"
			},
			new GStruct18
			{
				int_0 = 64,
				string_0 = "Phßng ®Ö tö 2"
			},
			new GStruct18
			{
				int_0 = 65,
				string_0 = "Thiªn V­¬ng ®¶o s¬n ®éng"
			},
			new GStruct18
			{
				int_0 = 66,
				string_0 = "§¸y §éng §×nh hå tÇng 1"
			},
			new GStruct18
			{
				int_0 = 67,
				string_0 = "§¸y §éng §×nh hå tÇng 2"
			},
			new GStruct18
			{
				int_0 = 68,
				string_0 = "Thanh Loa ®¶o"
			},
			new GStruct18
			{
				int_0 = 69,
				string_0 = "Thanh Loa ®¶o s¬n ®éng"
			},
			new GStruct18
			{
				int_0 = 70,
				string_0 = "Vò L¨ng s¬n"
			},
			new GStruct18
			{
				int_0 = 71,
				string_0 = "B¹ch Thñy ®éng"
			},
			new GStruct18
			{
				int_0 = 72,
				string_0 = "§¹i Tï ®éng"
			},
			new GStruct18
			{
				int_0 = 73,
				string_0 = "Phôc L­u ®éng"
			},
			new GStruct18
			{
				int_0 = 74,
				string_0 = "Miªu LÜnh"
			},
			new GStruct18
			{
				int_0 = 75,
				string_0 = "Kho¶ Lang ®éng"
			},
			new GStruct18
			{
				int_0 = 76,
				string_0 = "S¬n B¶o ®éng"
			},
			new GStruct18
			{
				int_0 = 77,
				string_0 = "YÕn Tö ®éng"
			},
			new GStruct18
			{
				int_0 = 78,
				string_0 = "T­¬ng D­¬ng"
			},
			new GStruct18
			{
				int_0 = 79,
				string_0 = "MËt ®¹o Nha m«n T­¬ng D­¬ng"
			},
			new GStruct18
			{
				int_0 = 80,
				string_0 = "D­¬ng Ch©u"
			},
			new GStruct18
			{
				int_0 = 81,
				string_0 = "Vâ §ang ph¸i"
			},
			new GStruct18
			{
				int_0 = 82,
				string_0 = "Mª cung §¸y giÕng"
			},
			new GStruct18
			{
				int_0 = 83,
				string_0 = "Háa Lang ®éng"
			},
			new GStruct18
			{
				int_0 = 84,
				string_0 = "Tö Tiªu ®¹i ®iÖn"
			},
			new GStruct18
			{
				int_0 = 85,
				string_0 = "ThËp Ph­¬ng ®iÖn"
			},
			new GStruct18
			{
				int_0 = 86,
				string_0 = "Phô MÉu ®iÖn"
			},
			new GStruct18
			{
				int_0 = 87,
				string_0 = "Long Hæ ®iÖn"
			},
			new GStruct18
			{
				int_0 = 88,
				string_0 = "Nh· thÊt 1"
			},
			new GStruct18
			{
				int_0 = 89,
				string_0 = "Nh· thÊt 2"
			},
			new GStruct18
			{
				int_0 = 90,
				string_0 = "Phôc Ng­u S¬n §«ng"
			},
			new GStruct18
			{
				int_0 = 91,
				string_0 = "Mª cung Kª Qu¸n ®éng"
			},
			new GStruct18
			{
				int_0 = 92,
				string_0 = "Thôc C­¬ng s¬n"
			},
			new GStruct18
			{
				int_0 = 93,
				string_0 = "TiÕn Cóc ®éng"
			},
			new GStruct18
			{
				int_0 = 94,
				string_0 = "Linh Cèc ®éng"
			},
			new GStruct18
			{
				int_0 = 95,
				string_0 = "T©n Thñ kh¸ch c¬"
			},
			new GStruct18
			{
				int_0 = 96,
				string_0 = "T©n Thñ kh¸ch c¬"
			},
			new GStruct18
			{
				int_0 = 97,
				string_0 = "Giang T©n th«n-V« Danh ®éng"
			},
			new GStruct18
			{
				int_0 = 98,
				string_0 = "Ba L¨ng huyÖn-Thanh Khª ®éng"
			},
			new GStruct18
			{
				int_0 = 99,
				string_0 = "VÜnh L¹c trÊn"
			},
			new GStruct18
			{
				int_0 = 100,
				string_0 = "Chu Tiªn trÊn"
			},
			new GStruct18
			{
				int_0 = 101,
				string_0 = "§¹o H­¬ng th«n"
			},
			new GStruct18
			{
				int_0 = 102,
				string_0 = "Th¸nh ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 103,
				string_0 = "ThiÕu L©m ph¸i"
			},
			new GStruct18
			{
				int_0 = 104,
				string_0 = "Tµng Kinh C¸c"
			},
			new GStruct18
			{
				int_0 = 105,
				string_0 = "§¹t Ma §­êng"
			},
			new GStruct18
			{
				int_0 = 106,
				string_0 = "§¹i Hïng b¶o ®iÖn"
			},
			new GStruct18
			{
				int_0 = 107,
				string_0 = "ThiÕu L©m §Ö tö phßng"
			},
			new GStruct18
			{
				int_0 = 108,
				string_0 = "ThiÕu L©m §Ö tö phßng"
			},
			new GStruct18
			{
				int_0 = 109,
				string_0 = "Ph­¬ng tr­îng ThiÒn phßng"
			},
			new GStruct18
			{
				int_0 = 110,
				string_0 = "La H¸n §­êng"
			},
			new GStruct18
			{
				int_0 = 111,
				string_0 = "Méc Nh©n H¹ng"
			},
			new GStruct18
			{
				int_0 = 112,
				string_0 = "Thiªn PhËt ®iÖn"
			},
			new GStruct18
			{
				int_0 = 113,
				string_0 = "MËt thÊt ThiÕu L©m"
			},
			new GStruct18
			{
				int_0 = 114,
				string_0 = "108 La H¸n trËn"
			},
			new GStruct18
			{
				int_0 = 115,
				string_0 = "C¸i Bang"
			},
			new GStruct18
			{
				int_0 = 116,
				string_0 = "T­êng V©n ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 117,
				string_0 = "T­êng V©n ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 118,
				string_0 = "T­êng V©n ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 119,
				string_0 = "T­êng V©n ®éng tÇng 4"
			},
			new GStruct18
			{
				int_0 = 120,
				string_0 = "T­êng V©n ®éng tÇng 5"
			},
			new GStruct18
			{
				int_0 = 121,
				string_0 = "Long M«n trÊn"
			},
			new GStruct18
			{
				int_0 = 122,
				string_0 = "Hoµng Hµ Nguyªn §Çu"
			},
			new GStruct18
			{
				int_0 = 123,
				string_0 = "L·o Hæ ®éng"
			},
			new GStruct18
			{
				int_0 = 124,
				string_0 = "C¸n Viªn ®éng"
			},
			new GStruct18
			{
				int_0 = 125,
				string_0 = "L­u Tiªn ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 126,
				string_0 = "L­u Tiªn ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 127,
				string_0 = "L­u Tiªn ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 128,
				string_0 = "L­u Tiªn ®éng tÇng 4"
			},
			new GStruct18
			{
				int_0 = 129,
				string_0 = "L­u Tiªn ®éng tÇng 5"
			},
			new GStruct18
			{
				int_0 = 130,
				string_0 = "L­u Tiªn ®éng tÇng 6"
			},
			new GStruct18
			{
				int_0 = 131,
				string_0 = "C«n L«n ph¸i"
			},
			new GStruct18
			{
				int_0 = 132,
				string_0 = "B¨ng HuyÖt ®éng"
			},
			new GStruct18
			{
				int_0 = 133,
				string_0 = "Phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 134,
				string_0 = "Phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 135,
				string_0 = "KiÕn TÝnh Phong s¬n ®éng"
			},
			new GStruct18
			{
				int_0 = 136,
				string_0 = "Kho¸i Ho¹t L©m"
			},
			new GStruct18
			{
				int_0 = 137,
				string_0 = "Thiªn Vi ®iÖn"
			},
			new GStruct18
			{
				int_0 = 138,
				string_0 = "ChÝnh ®iÖn"
			},
			new GStruct18
			{
				int_0 = 139,
				string_0 = "Tö Vi ®iÖn"
			},
			new GStruct18
			{
				int_0 = 140,
				string_0 = "D­îc V­¬ng Cèc"
			},
			new GStruct18
			{
				int_0 = 141,
				string_0 = "D­îc V­¬ng ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 142,
				string_0 = "D­îc V­¬ng ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 143,
				string_0 = "D­îc V­¬ng ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 144,
				string_0 = "D­îc V­¬ng ®éng tÇng 4"
			},
			new GStruct18
			{
				int_0 = 145,
				string_0 = "TuyÕt B¸o ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 146,
				string_0 = "TuyÕt B¸o ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 147,
				string_0 = "TuyÕt B¸o ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 148,
				string_0 = "TuyÕt B¸o ®éng tÇng 4"
			},
			new GStruct18
			{
				int_0 = 149,
				string_0 = "TuyÕt B¸o ®éng tÇng 5"
			},
			new GStruct18
			{
				int_0 = 150,
				string_0 = "TuyÕt B¸o ®éng tÇng 6"
			},
			new GStruct18
			{
				int_0 = 151,
				string_0 = "TuyÕt B¸o ®éng tÇng 7"
			},
			new GStruct18
			{
				int_0 = 152,
				string_0 = "TuyÕt B¸o ®éng tÇng 8"
			},
			new GStruct18
			{
				int_0 = 153,
				string_0 = "Th¹ch Cæ trÊn"
			},
			new GStruct18
			{
				int_0 = 154,
				string_0 = "Thóy Yªn m«n"
			},
			new GStruct18
			{
				int_0 = 155,
				string_0 = "B¸ch Hoa ®×nh"
			},
			new GStruct18
			{
				int_0 = 156,
				string_0 = "phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 157,
				string_0 = "phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 158,
				string_0 = "Mª cung cÊm ®Þa"
			},
			new GStruct18
			{
				int_0 = 159,
				string_0 = "M«n lÇu"
			},
			new GStruct18
			{
				int_0 = 160,
				string_0 = "Thñ Ngäc s¶nh"
			},
			new GStruct18
			{
				int_0 = 161,
				string_0 = "Thóy Yªn LÇu"
			},
			new GStruct18
			{
				int_0 = 162,
				string_0 = "§¹i Lý"
			},
			new GStruct18
			{
				int_0 = 163,
				string_0 = "¸c b¸ ®Þa ®¹o"
			},
			new GStruct18
			{
				int_0 = 164,
				string_0 = "Thiªn TÇm th¸p tÇng 1"
			},
			new GStruct18
			{
				int_0 = 165,
				string_0 = "Thiªn TÇm th¸p tÇng 2"
			},
			new GStruct18
			{
				int_0 = 166,
				string_0 = "Thiªn TÇm th¸p tÇng 3"
			},
			new GStruct18
			{
				int_0 = 167,
				string_0 = "§iÓm Th­¬ng s¬n"
			},
			new GStruct18
			{
				int_0 = 168,
				string_0 = "Phông Nh·n ®éng"
			},
			new GStruct18
			{
				int_0 = 169,
				string_0 = "Long Nh·n ®éng"
			},
			new GStruct18
			{
				int_0 = 170,
				string_0 = "Thæ PhØ ®éng"
			},
			new GStruct18
			{
				int_0 = 171,
				string_0 = "§iÓm Th­¬ng ®éng tÇng 1"
			},
			new GStruct18
			{
				int_0 = 172,
				string_0 = "§iÓm Th­¬ng ®éng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 173,
				string_0 = "§iÓm Th­¬ng ®éng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 174,
				string_0 = "Long TuyÒn th«n"
			},
			new GStruct18
			{
				int_0 = 175,
				string_0 = "T©y S¬n th«n"
			},
			new GStruct18
			{
				int_0 = 176,
				string_0 = "L©m An"
			},
			new GStruct18
			{
				int_0 = 177,
				string_0 = "Ngù Hoa viªn"
			},
			new GStruct18
			{
				int_0 = 178,
				string_0 = "S¬n ®éng Ngù Hoa viªn"
			},
			new GStruct18
			{
				int_0 = 179,
				string_0 = "La Tiªu s¬n"
			},
			new GStruct18
			{
				int_0 = 180,
				string_0 = "Long Cung ®éng"
			},
			new GStruct18
			{
				int_0 = 181,
				string_0 = "L­ìng Thñy ®éng"
			},
			new GStruct18
			{
				int_0 = 182,
				string_0 = "NghiÖt Long ®éng"
			},
			new GStruct18
			{
				int_0 = 183,
				string_0 = "Ngò §éc Gi¸o"
			},
			new GStruct18
			{
				int_0 = 184,
				string_0 = "XÝch YÕt tr¹i"
			},
			new GStruct18
			{
				int_0 = 185,
				string_0 = "Kim Xµ tr¹i"
			},
			new GStruct18
			{
				int_0 = 186,
				string_0 = "MÆc Thï tr¹i"
			},
			new GStruct18
			{
				int_0 = 187,
				string_0 = "Thanh Ng« tr¹i"
			},
			new GStruct18
			{
				int_0 = 188,
				string_0 = "Ng©n ThiÒm tr¹i"
			},
			new GStruct18
			{
				int_0 = 189,
				string_0 = "Tæng tr¹i"
			},
			new GStruct18
			{
				int_0 = 190,
				string_0 = "Mª cung nhËp m«n"
			},
			new GStruct18
			{
				int_0 = 191,
				string_0 = "phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 192,
				string_0 = "phßng §Ö tö"
			},
			new GStruct18
			{
				int_0 = 193,
				string_0 = "Vò Di s¬n"
			},
			new GStruct18
			{
				int_0 = 194,
				string_0 = "Ngäc Hoa ®éng"
			},
			new GStruct18
			{
				int_0 = 195,
				string_0 = "Nh¹n §·ng s¬n"
			},
			new GStruct18
			{
				int_0 = 196,
				string_0 = "D­¬ng Gi¸c ®éng"
			},
			new GStruct18
			{
				int_0 = 197,
				string_0 = "Thiªn lao"
			},
			new GStruct18
			{
				int_0 = 198,
				string_0 = "Thanh khª ®éng"
			},
			new GStruct18
			{
				int_0 = 199,
				string_0 = "Vò L¨ng ®éng"
			},
			new GStruct18
			{
				int_0 = 200,
				string_0 = "Cæ D­¬ng ®éng"
			},
			new GStruct18
			{
				int_0 = 201,
				string_0 = "B¨ng Hµ ®éng"
			},
			new GStruct18
			{
				int_0 = 202,
				string_0 = "Phï Dung ®éng"
			},
			new GStruct18
			{
				int_0 = 203,
				string_0 = "V« Danh ®éng"
			},
			new GStruct18
			{
				int_0 = 204,
				string_0 = "Phi Thiªn ®éng"
			},
			new GStruct18
			{
				int_0 = 205,
				string_0 = "D­¬ng Trung ®éng"
			},
			new GStruct18
			{
				int_0 = 206,
				string_0 = "TÇn L¨ng tÇng 2"
			},
			new GStruct18
			{
				int_0 = 207,
				string_0 = "TÇn L¨ng tÇng 3"
			},
			new GStruct18
			{
				int_0 = 208,
				string_0 = "§¹i lao"
			},
			new GStruct18
			{
				int_0 = 209,
				string_0 = "DiÔn vâ tr­êng"
			},
			new GStruct18
			{
				int_0 = 210,
				string_0 = "DiÔn vâ tr­êng"
			},
			new GStruct18
			{
				int_0 = 211,
				string_0 = "DiÔn vâ tr­êng"
			},
			new GStruct18
			{
				int_0 = 212,
				string_0 = "Hoa S¬n tuyÖt ®Ønh"
			},
			new GStruct18
			{
				int_0 = 213,
				string_0 = "L«i ®µi Bang héi 1"
			},
			new GStruct18
			{
				int_0 = 214,
				string_0 = "L«i ®µi Bang héi 2"
			},
			new GStruct18
			{
				int_0 = 215,
				string_0 = "L«i ®µi Bang héi 3"
			},
			new GStruct18
			{
				int_0 = 216,
				string_0 = "L«i ®µi Bang héi 4"
			},
			new GStruct18
			{
				int_0 = 217,
				string_0 = "L«i ®µi Bang héi 5"
			},
			new GStruct18
			{
				int_0 = 218,
				string_0 = "L«i ®µi Bang héi 6"
			},
			new GStruct18
			{
				int_0 = 219,
				string_0 = "L«i ®µi Bang héi 7"
			},
			new GStruct18
			{
				int_0 = 220,
				string_0 = "DiÔn Vâ tr­êng 8"
			},
			new GStruct18
			{
				int_0 = 221,
				string_0 = "C«ng thµnh chiÕn tr­êng"
			},
			new GStruct18
			{
				int_0 = 222,
				string_0 = "HËu ph­¬ng bªn Thñ"
			},
			new GStruct18
			{
				int_0 = 223,
				string_0 = "HËu ph­¬ng bªn C«ng"
			},
			new GStruct18
			{
				int_0 = 224,
				string_0 = "Sa m¹c ®Þa biÓu"
			},
			new GStruct18
			{
				int_0 = 225,
				string_0 = "Sa M¹c s¬n  ®éng 1"
			},
			new GStruct18
			{
				int_0 = 226,
				string_0 = "Sa M¹c s¬n  ®éng 2"
			},
			new GStruct18
			{
				int_0 = 227,
				string_0 = "Sa M¹c s¬n  ®éng 3"
			},
			new GStruct18
			{
				int_0 = 228,
				string_0 = "HËu s¬n C«n L«n"
			},
			new GStruct18
			{
				int_0 = 229,
				string_0 = "TÕ Tæ ®×nh (chiÕn ®Êu)"
			},
			new GStruct18
			{
				int_0 = 230,
				string_0 = "Trong thµnh §¹i Lý (chiÕn ®Êu)"
			},
			new GStruct18
			{
				int_0 = 231,
				string_0 = "N¬i ë Th­¬ng L­¬ng kh¸ch"
			},
			new GStruct18
			{
				int_0 = 232,
				string_0 = "N¬i ë Chu V©n TuyÒn"
			},
			new GStruct18
			{
				int_0 = 233,
				string_0 = "N¬i ë M¹c Kh«ng NguyÖt"
			},
			new GStruct18
			{
				int_0 = 234,
				string_0 = "Kim Xµ tr¹i (chiÕn ®Êu)"
			},
			new GStruct18
			{
				int_0 = 235,
				string_0 = "§µo Hoa ®¶o (1)"
			},
			new GStruct18
			{
				int_0 = 236,
				string_0 = "§µo Hoa ®¶o (2)"
			},
			new GStruct18
			{
				int_0 = 237,
				string_0 = "§µo Hoa ®¶o (3)"
			},
			new GStruct18
			{
				int_0 = 238,
				string_0 = "§µo Hoa ®¶o (4)"
			},
			new GStruct18
			{
				int_0 = 239,
				string_0 = "§µo Hoa ®¶o (5)"
			},
			new GStruct18
			{
				int_0 = 240,
				string_0 = "§µo Hoa ®¶o (6)"
			},
			new GStruct18
			{
				int_0 = 241,
				string_0 = "§µo Hoa ®¶o (7)"
			},
			new GStruct18
			{
				int_0 = 242,
				string_0 = "TÈy Tñy ®¶o (1)"
			},
			new GStruct18
			{
				int_0 = 243,
				string_0 = "TÈy Tñy ®¶o (2)"
			},
			new GStruct18
			{
				int_0 = 244,
				string_0 = "TÈy Tñy ®¶o (3)"
			},
			new GStruct18
			{
				int_0 = 245,
				string_0 = "TÈy Tñy ®¶o (4)"
			},
			new GStruct18
			{
				int_0 = 246,
				string_0 = "TÈy Tñy ®¶o (5)"
			},
			new GStruct18
			{
				int_0 = 247,
				string_0 = "TÈy Tñy ®¶o (6)"
			},
			new GStruct18
			{
				int_0 = 248,
				string_0 = "TÈy Tñy ®¶o (7)"
			},
			new GStruct18
			{
				int_0 = 249,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 250,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 251,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 252,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 253,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 254,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 255,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 256,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 257,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 258,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (1)"
			},
			new GStruct18
			{
				int_0 = 259,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 260,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 261,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 262,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 263,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 264,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 265,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 266,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 267,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 268,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (2)"
			},
			new GStruct18
			{
				int_0 = 269,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 270,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 271,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 272,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 273,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 274,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 275,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 276,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 277,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 278,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (3)"
			},
			new GStruct18
			{
				int_0 = 279,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 280,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 281,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 282,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 283,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 284,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 285,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 286,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 287,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 288,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (4)"
			},
			new GStruct18
			{
				int_0 = 289,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 290,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 291,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 292,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 293,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 294,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 295,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 296,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 297,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 298,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (5)"
			},
			new GStruct18
			{
				int_0 = 299,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 300,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 301,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 302,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 303,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 304,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 305,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 306,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 307,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 308,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (6)"
			},
			new GStruct18
			{
				int_0 = 309,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 310,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 311,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 312,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 313,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 314,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 315,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 316,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 317,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 318,
				string_0 = "TÈy Tñy ®¶o s¬n ®éng (7)"
			},
			new GStruct18
			{
				int_0 = 319,
				string_0 = "L©m Du Quan"
			},
			new GStruct18
			{
				int_0 = 320,
				string_0 = "Ch©n nói Tr­êng B¹ch"
			},
			new GStruct18
			{
				int_0 = 321,
				string_0 = "Tr­êng B¹ch s¬n Nam"
			},
			new GStruct18
			{
				int_0 = 322,
				string_0 = "Tr­êng B¹ch s¬n B¾c"
			},
			new GStruct18
			{
				int_0 = 323,
				string_0 = "§iÓm b¸o danh Tèng Kim (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 324,
				string_0 = "§iÓm b¸o danh Tèng Kim (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 325,
				string_0 = "§iÓm b¸o danh Tèng Kim (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 326,
				string_0 = "Khu vùc b×nh nguyªn (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 327,
				string_0 = "Khu vùc b×nh nguyªn (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 328,
				string_0 = "Khu vùc b×nh nguyªn (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 329,
				string_0 = "Khu vùc Hµ T©n (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 330,
				string_0 = "Khu vùc Hµ T©n (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 331,
				string_0 = "Khu vùc Hµ T©n (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 332,
				string_0 = "Thiªn Long Tù"
			},
			new GStruct18
			{
				int_0 = 333,
				string_0 = "Hoa S¬n ph¸i"
			},
			new GStruct18
			{
				int_0 = 334,
				string_0 = "Khu vùc tû vâ"
			},
			new GStruct18
			{
				int_0 = 335,
				string_0 = "Tû vâ tr­êng"
			},
			new GStruct18
			{
				int_0 = 336,
				string_0 = "Phong L¨ng ®é"
			},
			new GStruct18
			{
				int_0 = 337,
				string_0 = "BÕn thuyÒn 1"
			},
			new GStruct18
			{
				int_0 = 338,
				string_0 = "BÕn thuyÒn 2"
			},
			new GStruct18
			{
				int_0 = 339,
				string_0 = "BÕn thuyÒn 3"
			},
			new GStruct18
			{
				int_0 = 340,
				string_0 = "M¹c Cao QuËt"
			},
			new GStruct18
			{
				int_0 = 341,
				string_0 = "M¹c B¾c Th¶o Nguyªn"
			},
			new GStruct18
			{
				int_0 = 342,
				string_0 = "Vi S¬n ®¶o"
			},
			new GStruct18
			{
				int_0 = 343,
				string_0 = "MËt thÊt Hoµnh S¬n"
			},
			new GStruct18
			{
				int_0 = 344,
				string_0 = "Thµnh trÊn (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 345,
				string_0 = "Thµnh trÊn (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 346,
				string_0 = "Thµnh trÊn (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 347,
				string_0 = "S¬n cèc (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 348,
				string_0 = "S¬n cèc (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 349,
				string_0 = "S¬n cèc (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 350,
				string_0 = "Th©m l©m (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 351,
				string_0 = "Th©m l©m (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 352,
				string_0 = "Th©m l©m (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 353,
				string_0 = "Doanh tr¹i (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 354,
				string_0 = "Doanh tr¹i (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 355,
				string_0 = "Doanh tr¹i (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 356,
				string_0 = "Tr­êng ®Êu (1)"
			},
			new GStruct18
			{
				int_0 = 357,
				string_0 = "§¬n ®Êu B×nh nguyªn (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 358,
				string_0 = "§¬n ®Êu B×nh nguyªn (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 359,
				string_0 = "§¬n ®Êu B×nh nguyªn (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 360,
				string_0 = "§¬n ®Êu Hµ t©n (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 361,
				string_0 = "§¬n ®Êu Hµ t©n (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 362,
				string_0 = "§¬n ®Êu Hµ t©n (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 363,
				string_0 = "§¬n ®Êu Th©m l©m (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 364,
				string_0 = "§¬n ®Êu Th©m l©m (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 365,
				string_0 = "§¬n ®Êu Th©m l©m (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 366,
				string_0 = "§¬n ®Êu S¬n cèc (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 367,
				string_0 = "§¬n ®Êu S¬n cèc (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 368,
				string_0 = "§¬n ®Êu S¬n cèc (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 369,
				string_0 = "§¬n ®Êu Thµnh trÊn (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 370,
				string_0 = "§¬n ®Êu Thµnh trÊn (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 371,
				string_0 = "§¬n ®Êu Thµnh trÊn (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 372,
				string_0 = "§¬n ®Êu Doanh tr¹i (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 373,
				string_0 = "§¬n ®Êu Doanh tr¹i (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 374,
				string_0 = "§¬n ®Êu Doanh tr¹i (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 375,
				string_0 = "ChiÕn tr­êng Tèng Kim cò (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 376,
				string_0 = "ChiÕn tr­êng Tèng Kim cò (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 377,
				string_0 = "ChiÕn tr­êng Tèng Kim (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 378,
				string_0 = "Xung phong (S¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 379,
				string_0 = "Xung phong (Trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 380,
				string_0 = "Xung phong (Cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 381,
				string_0 = "Th©m l©m (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 382,
				string_0 = "Th©m l©m (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 383,
				string_0 = "Th©m l©m (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 384,
				string_0 = "CÇu ranh giíi (s¬ cÊp)"
			},
			new GStruct18
			{
				int_0 = 385,
				string_0 = "CÇu ranh giíi (trung cÊp)"
			},
			new GStruct18
			{
				int_0 = 386,
				string_0 = "CÇu ranh giíi (cao cÊp)"
			},
			new GStruct18
			{
				int_0 = 387,
				string_0 = "Phong Kú (60-89)"
			},
			new GStruct18
			{
				int_0 = 388,
				string_0 = "Phong Kú (90-119)"
			},
			new GStruct18
			{
				int_0 = 389,
				string_0 = "Phong Kú (trªn 120)"
			},
			new GStruct18
			{
				int_0 = 390,
				string_0 = "S¬n ThÇn miÕu (60-89)"
			},
			new GStruct18
			{
				int_0 = 391,
				string_0 = "S¬n ThÇn miÕu (90-119)"
			},
			new GStruct18
			{
				int_0 = 392,
				string_0 = "S¬n ThÇn miÕu (trªn 120)"
			},
			new GStruct18
			{
				int_0 = 393,
				string_0 = "Thiªn B¶o khè (60-89)"
			},
			new GStruct18
			{
				int_0 = 394,
				string_0 = "Thiªn B¶o khè (90-119)"
			},
			new GStruct18
			{
				int_0 = 395,
				string_0 = "Thiªn B¶o khè (trªn 120)"
			},
			new GStruct18
			{
				int_0 = 396,
				string_0 = "Liªn ®Êu (ThiÕu L©m)"
			},
			new GStruct18
			{
				int_0 = 397,
				string_0 = "§Êu tr­êng (ThiÕu L©m)"
			},
			new GStruct18
			{
				int_0 = 398,
				string_0 = "Liªn ®Êu (Thiªn V­¬ng)"
			},
			new GStruct18
			{
				int_0 = 399,
				string_0 = "§Êu tr­êng (Thiªn V­¬ng)"
			},
			new GStruct18
			{
				int_0 = 400,
				string_0 = "Liªn ®Êu (§­êng M«n)"
			},
			new GStruct18
			{
				int_0 = 401,
				string_0 = "§Êu tr­êng (§­êng M«n)"
			},
			new GStruct18
			{
				int_0 = 402,
				string_0 = "Liªn ®Êu (Ngò §éc)"
			},
			new GStruct18
			{
				int_0 = 403,
				string_0 = "§Êu tr­êng (Ngò §éc)"
			},
			new GStruct18
			{
				int_0 = 404,
				string_0 = "Liªn ®Êu (Nga My)"
			},
			new GStruct18
			{
				int_0 = 405,
				string_0 = "§Êu tr­êng (Nga My)"
			},
			new GStruct18
			{
				int_0 = 406,
				string_0 = "Liªn ®Êu (Thóy Yªn)"
			},
			new GStruct18
			{
				int_0 = 407,
				string_0 = "§Êu tr­êng (Thóy Yªn)"
			},
			new GStruct18
			{
				int_0 = 408,
				string_0 = "Liªn ®Êu (C¸i Bang)"
			},
			new GStruct18
			{
				int_0 = 409,
				string_0 = "§Êu tr­êng (C¸i Bang)"
			},
			new GStruct18
			{
				int_0 = 410,
				string_0 = "Liªn ®Êu (Thiªn NhÉn)"
			},
			new GStruct18
			{
				int_0 = 411,
				string_0 = "§Êu tr­êng (Thiªn NhÉn)"
			},
			new GStruct18
			{
				int_0 = 412,
				string_0 = "Liªn ®Êu (Vâ §ang)"
			},
			new GStruct18
			{
				int_0 = 413,
				string_0 = "§Êu tr­êng (Vâ §ang)"
			},
			new GStruct18
			{
				int_0 = 414,
				string_0 = "Liªn ®Êu (C«n L«n)"
			},
			new GStruct18
			{
				int_0 = 415,
				string_0 = "§Êu tr­êng (C«n L«n)"
			},
			new GStruct18
			{
				int_0 = 416,
				string_0 = "ThuyÒn Rång s¬ cÊp (1)"
			},
			new GStruct18
			{
				int_0 = 417,
				string_0 = "ThuyÒn Rång s¬ cÊp (2)"
			},
			new GStruct18
			{
				int_0 = 418,
				string_0 = "ThuyÒn Rång s¬ cÊp (3)"
			},
			new GStruct18
			{
				int_0 = 419,
				string_0 = "ThuyÒn Rång s¬ cÊp (4)"
			},
			new GStruct18
			{
				int_0 = 420,
				string_0 = "ThuyÒn Rång s¬ cÊp (5)"
			},
			new GStruct18
			{
				int_0 = 421,
				string_0 = "ThuyÒn Rång s¬ cÊp (6)"
			},
			new GStruct18
			{
				int_0 = 422,
				string_0 = "ThuyÒn Rång s¬ cÊp (7)"
			},
			new GStruct18
			{
				int_0 = 423,
				string_0 = "ThuyÒn Rång s¬ cÊp (8)"
			},
			new GStruct18
			{
				int_0 = 424,
				string_0 = "ThuyÒn Rång cao cÊp (1)"
			},
			new GStruct18
			{
				int_0 = 425,
				string_0 = "ThuyÒn Rång cao cÊp (2)"
			},
			new GStruct18
			{
				int_0 = 426,
				string_0 = "ThuyÒn Rång cao cÊp (3)"
			},
			new GStruct18
			{
				int_0 = 427,
				string_0 = "ThuyÒn Rång cao cÊp (4)"
			},
			new GStruct18
			{
				int_0 = 428,
				string_0 = "ThuyÒn Rång cao cÊp (5)"
			},
			new GStruct18
			{
				int_0 = 429,
				string_0 = "ThuyÒn Rång cao cÊp (6)"
			},
			new GStruct18
			{
				int_0 = 430,
				string_0 = "ThuyÒn Rång cao cÊp (7)"
			},
			new GStruct18
			{
				int_0 = 431,
				string_0 = "ThuyÒn Rång cao cÊp (8)"
			},
			new GStruct18
			{
				int_0 = 432,
				string_0 = "ThuyÒn Rång cao cÊp (9)"
			},
			new GStruct18
			{
				int_0 = 433,
				string_0 = "ThuyÒn Rång cao cÊp (10)"
			},
			new GStruct18
			{
				int_0 = 434,
				string_0 = "ThuyÒn Rång cao cÊp (11)"
			},
			new GStruct18
			{
				int_0 = 435,
				string_0 = "ThuyÒn Rång cao cÊp (12)"
			},
			new GStruct18
			{
				int_0 = 436,
				string_0 = "ThuyÒn Rång cao cÊp (13)"
			},
			new GStruct18
			{
				int_0 = 437,
				string_0 = "ThuyÒn Rång cao cÊp (14)"
			},
			new GStruct18
			{
				int_0 = 438,
				string_0 = "ThuyÒn Rång cao cÊp (15)"
			},
			new GStruct18
			{
				int_0 = 439,
				string_0 = "ThuyÒn Rång cao cÊp (16)"
			},
			new GStruct18
			{
				int_0 = 440,
				string_0 = "ThuyÒn Rång s¬ cÊp (9)"
			},
			new GStruct18
			{
				int_0 = 441,
				string_0 = "ThuyÒn Rång s¬ cÊp (10)"
			},
			new GStruct18
			{
				int_0 = 442,
				string_0 = "ThuyÒn Rång s¬ cÊp (11)"
			},
			new GStruct18
			{
				int_0 = 443,
				string_0 = "ThuyÒn Rång s¬ cÊp (12)"
			},
			new GStruct18
			{
				int_0 = 444,
				string_0 = "ThuyÒn Rång s¬ cÊp (13)"
			},
			new GStruct18
			{
				int_0 = 445,
				string_0 = "ThuyÒn Rång s¬ cÊp (14)"
			},
			new GStruct18
			{
				int_0 = 446,
				string_0 = "ThuyÒn Rång s¬ cÊp (15)"
			},
			new GStruct18
			{
				int_0 = 447,
				string_0 = "ThuyÒn Rång s¬ cÊp (16)"
			},
			new GStruct18
			{
				int_0 = 448,
				string_0 = "ThuyÒn Rång cao cÊp (17)"
			},
			new GStruct18
			{
				int_0 = 449,
				string_0 = "ThuyÒn Rång cao cÊp (18)"
			},
			new GStruct18
			{
				int_0 = 450,
				string_0 = "ThuyÒn Rång cao cÊp (19)"
			},
			new GStruct18
			{
				int_0 = 451,
				string_0 = "ThuyÒn Rång cao cÊp (20)"
			},
			new GStruct18
			{
				int_0 = 452,
				string_0 = "ThuyÒn Rång cao cÊp (21)"
			},
			new GStruct18
			{
				int_0 = 453,
				string_0 = "ThuyÒn Rång cao cÊp (22)"
			},
			new GStruct18
			{
				int_0 = 454,
				string_0 = "ThuyÒn Rång cao cÊp (23)"
			},
			new GStruct18
			{
				int_0 = 455,
				string_0 = "ThuyÒn Rång cao cÊp (24)"
			},
			new GStruct18
			{
				int_0 = 456,
				string_0 = "ThuyÒn Rång cao cÊp (25)"
			},
			new GStruct18
			{
				int_0 = 457,
				string_0 = "ThuyÒn Rång cao cÊp (26)"
			},
			new GStruct18
			{
				int_0 = 458,
				string_0 = "ThuyÒn Rång cao cÊp (27)"
			},
			new GStruct18
			{
				int_0 = 459,
				string_0 = "ThuyÒn Rång cao cÊp (28)"
			},
			new GStruct18
			{
				int_0 = 460,
				string_0 = "ThuyÒn Rång cao cÊp (29)"
			},
			new GStruct18
			{
				int_0 = 461,
				string_0 = "ThuyÒn Rång cao cÊp (30)"
			},
			new GStruct18
			{
				int_0 = 462,
				string_0 = "ThuyÒn Rång cao cÊp (31)"
			},
			new GStruct18
			{
				int_0 = 463,
				string_0 = "ThuyÒn Rång cao cÊp (32)"
			},
			new GStruct18
			{
				int_0 = 464,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 1)"
			},
			new GStruct18
			{
				int_0 = 465,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 2)"
			},
			new GStruct18
			{
				int_0 = 466,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 3)"
			},
			new GStruct18
			{
				int_0 = 467,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 4)"
			},
			new GStruct18
			{
				int_0 = 468,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 5)"
			},
			new GStruct18
			{
				int_0 = 469,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 6)"
			},
			new GStruct18
			{
				int_0 = 470,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 7)"
			},
			new GStruct18
			{
				int_0 = 471,
				string_0 = "Th¸ch thøc thêi gian (S¬ cÊp 8)"
			},
			new GStruct18
			{
				int_0 = 472,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 1)"
			},
			new GStruct18
			{
				int_0 = 473,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 2)"
			},
			new GStruct18
			{
				int_0 = 474,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 3)"
			},
			new GStruct18
			{
				int_0 = 475,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 4)"
			},
			new GStruct18
			{
				int_0 = 476,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 5)"
			},
			new GStruct18
			{
				int_0 = 477,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 6)"
			},
			new GStruct18
			{
				int_0 = 478,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 7)"
			},
			new GStruct18
			{
				int_0 = 479,
				string_0 = "Thö luyÖn tµi nghÖ (S¬ cÊp 8)"
			},
			new GStruct18
			{
				int_0 = 480,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 1)"
			},
			new GStruct18
			{
				int_0 = 481,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 2)"
			},
			new GStruct18
			{
				int_0 = 482,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 3)"
			},
			new GStruct18
			{
				int_0 = 483,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 4)"
			},
			new GStruct18
			{
				int_0 = 484,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 5)"
			},
			new GStruct18
			{
				int_0 = 485,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 6)"
			},
			new GStruct18
			{
				int_0 = 486,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 7)"
			},
			new GStruct18
			{
				int_0 = 487,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 8)"
			},
			new GStruct18
			{
				int_0 = 488,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 9)"
			},
			new GStruct18
			{
				int_0 = 489,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 10)"
			},
			new GStruct18
			{
				int_0 = 490,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 11)"
			},
			new GStruct18
			{
				int_0 = 491,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 12)"
			},
			new GStruct18
			{
				int_0 = 492,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 13)"
			},
			new GStruct18
			{
				int_0 = 493,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 14)"
			},
			new GStruct18
			{
				int_0 = 494,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 15)"
			},
			new GStruct18
			{
				int_0 = 495,
				string_0 = "Th¸ch thøc thêi gian (Cao cÊp 16)"
			},
			new GStruct18
			{
				int_0 = 496,
				string_0 = "Thö luyÖn tµi nghÖ (Cao cÊp 1)"
			},
			new GStruct18
			{
				int_0 = 497,
				string_0 = "Thö luyÖn tµi nghÖ (Cao cÊp 2)"
			},
			new GStruct18
			{
				int_0 = 498,
				string_0 = "Thö luyÖn tµi nghÖ (Cao cÊp 3)"
			},
			new GStruct18
			{
				int_0 = 499,
				string_0 = "Thö luyÖn tµi nghÖ (Cao cÊp 4)"
			},
			new GStruct18
			{
				int_0 = 875,
				string_0 = "H¾c Sa ®éng"
			},
			new GStruct18
			{
				int_0 = 917,
				string_0 = "TÝch HuyÕt Cèc"
			},
			new GStruct18
			{
				int_0 = 918,
				string_0 = "¸c Nh©n Cèc"
			},
			new GStruct18
			{
				int_0 = 919,
				string_0 = "Thùc Cèt Nhai"
			},
			new GStruct18
			{
				int_0 = 920,
				string_0 = "H¾c Méc Nhai"
			},
			new GStruct18
			{
				int_0 = 921,
				string_0 = "Thiªn Phô S¬n"
			},
			new GStruct18
			{
				int_0 = 922,
				string_0 = "Bµn Long S¬n"
			},
			new GStruct18
			{
				int_0 = 923,
				string_0 = "§Þa MÉu S¬n"
			},
			new GStruct18
			{
				int_0 = 924,
				string_0 = "UyÓn Phông S¬n"
			},
			new GStruct18
			{
				int_0 = 926,
				string_0 = "ChiÕn tr­êng Thµnh §«"
			},
			new GStruct18
			{
				int_0 = 927,
				string_0 = "ChiÕn tr­êng BiÖn Kinh"
			},
			new GStruct18
			{
				int_0 = 928,
				string_0 = "ChiÕn tr­êng §¹i Lý"
			},
			new GStruct18
			{
				int_0 = 929,
				string_0 = "ChiÕn tr­êng Ph­îng T­êng"
			},
			new GStruct18
			{
				int_0 = 930,
				string_0 = "ChiÕn tr­êng L©m An"
			},
			new GStruct18
			{
				int_0 = 931,
				string_0 = "ChiÕn tr­êng T­¬ng D­¬ng"
			},
			new GStruct18
			{
				int_0 = 932,
				string_0 = "ChiÕn tr­êng D­¬ng Ch©u"
			},
			new GStruct18
			{
				int_0 = 959,
				string_0 = "ChiÕn Long ®éng"
			},
			new GStruct18
			{
				int_0 = 999,
				string_0 = "§Êu Tr­êng Sinh Tö"
			}
		};
	}
}
