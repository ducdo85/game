using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000032 RID: 50
	internal class Class53
	{
		// Token: 0x060002FD RID: 765 RVA: 0x0007B534 File Offset: 0x00079734
		static Class53()
		{
			string[,] array = new string[5, 3];
			array[0, 0] = "Ngò Hoa Ngäc Lé Hoµn";
			array[0, 1] = "Thõa Tiªn MËt";
			array[1, 0] = "Cöu ChuyÓn Hoµn Hån ®an";
			array[1, 1] = "Håi Thiªn ®an";
			array[1, 2] = "Kim S¸ng D­îc";
			array[2, 0] = "¤ ®Çu Hoµn thÇn ®an";
			array[2, 1] = "§¹i Bæ t¸n";
			array[2, 2] = "Ng­ng ThÇn ®an";
			array[3, 0] = "Ng©n KiÒu Khø ®éc ®an";
			array[3, 1] = "Ho¾c H­¬ng ChÝnh khÝ hoµn";
			array[4, 0] = "Tam Hoa T¸n";
			Class53.string_24 = array;
			Class53.gstruct44_0 = new GStruct44[]
			{
				new GStruct44
				{
					byte_0 = new byte[]
					{
						144,
						236,
						100,
						80
					}
				},
				new GStruct44
				{
					byte_0 = new byte[]
					{
						182,
						204,
						93,
						138
					}
				},
				new GStruct44
				{
					byte_0 = new byte[]
					{
						132,
						11,
						31,
						92
					}
				}
			};
			Class53.uint_7 = 70432U;
			Class53.uint_8 = 70436U;
			Class53.uint_9 = 70440U;
			Class53.uint_10 = 4368U;
			Class53.uint_11 = 4372U;
			Class53.uint_12 = 4412U;
			Class53.int_5 = 638081743;
			Class53.int_6 = 304985748;
			Class53.uint_13 = new uint[]
			{
				1648U,
				1660U
			};
			Class53.gstruct51_1 = new GStruct51
			{
				string_0 = "KEY_PRESS_COUNT",
				int_0 = 1,
				int_4 = 4,
				int_2 = 4,
				int_7 = 1
			};
			Class53.gstruct51_2 = new GStruct51
			{
				string_0 = "INFECT_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 2
			};
			Class53.gstruct51_3 = new GStruct51
			{
				string_0 = "INFECT_LENGTH",
				int_4 = 4,
				int_0 = 1,
				int_2 = 23
			};
			Class53.gstruct51_4 = new GStruct51
			{
				string_0 = "KTabFileLoad",
				int_4 = 0,
				int_0 = 1,
				int_2 = 4
			};
			Class53.gstruct51_5 = new GStruct51
			{
				string_0 = "ENGINE_HANDLE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_6 = new GStruct51
			{
				string_0 = "MOUSE_POS",
				int_4 = 1,
				int_0 = 1,
				int_2 = 2
			};
			Class53.gstruct51_7 = new GStruct51
			{
				string_0 = "MSVCR80_invalid_parameter_noinfo",
				int_4 = 4,
				int_0 = 1,
				int_2 = 9,
				int_7 = 1
			};
			Class53.gstruct51_8 = new GStruct51
			{
				string_0 = "FUNC_BAO_DANH",
				int_4 = 0,
				int_0 = 1,
				int_2 = 0
			};
			Class53.gstruct51_9 = new GStruct51
			{
				string_0 = "NPC_COUNT_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_7 = 1
			};
			Class53.gstruct51_10 = new GStruct51
			{
				string_0 = "NPC_COUNT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_11 = new GStruct51
			{
				string_0 = "KPLAYER_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_12 = new GStruct51
			{
				string_0 = "KPLAYER_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 10
			};
			Class53.gstruct51_13 = new GStruct51
			{
				string_0 = "PLAYER_INDEX_OFF",
				int_0 = 1,
				int_4 = 4,
				int_2 = 31
			};
			Class53.gstruct51_14 = new GStruct51
			{
				string_0 = "NPC_BASE_ADD",
				int_0 = 1,
				int_4 = 4,
				int_2 = 37
			};
			Class53.gstruct51_15 = new GStruct51
			{
				string_0 = "NPC_DATA_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 43
			};
			Class53.gstruct51_16 = new GStruct51
			{
				string_0 = "NPC_NAME_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 50
			};
			Class53.gstruct51_17 = new GStruct51
			{
				string_0 = "NPC_SEX_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_18 = new GStruct51
			{
				string_0 = "KSHOP_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_19 = new GStruct51
			{
				string_0 = "KITEM_INFO_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 38,
				int_7 = 1
			};
			Class53.gstruct51_20 = new GStruct51
			{
				string_0 = "KITEM_INFO_KEY",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2,
				int_1 = 1,
				int_5 = 1,
				int_3 = 4
			};
			Class53.gstruct51_21 = new GStruct51
			{
				string_0 = "KINFO_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 20,
				int_1 = 1,
				int_5 = 4,
				int_3 = 17
			};
			Class53.gstruct51_22 = new GStruct51
			{
				string_0 = "KINFO_TEXT",
				int_0 = 1,
				int_4 = 4,
				int_2 = 33,
				int_1 = 1,
				int_5 = 4,
				int_3 = 23
			};
			Class53.gstruct51_23 = new GStruct51
			{
				string_0 = "NPC_LEVEL_CAPTION",
				int_0 = 1,
				int_4 = 4,
				int_2 = 4
			};
			Class53.gstruct51_24 = new GStruct51
			{
				string_0 = "NPC_EXP_1",
				int_0 = 1,
				int_4 = 4,
				int_2 = 18
			};
			Class53.gstruct51_25 = default(GStruct51);
			Class53.gstruct51_26 = new GStruct51
			{
				string_0 = "NPC_GOLD",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_27 = new GStruct51
			{
				string_0 = "MAPID_BASE_ADDR",
				int_4 = 4,
				int_0 = 1,
				int_2 = -4
			};
			Class53.gstruct51_28 = new GStruct51
			{
				string_0 = "MAP_NAME_BASE_ADDR",
				int_4 = 4,
				int_0 = 1,
				int_2 = 6,
				int_7 = 1
			};
			Class53.gstruct51_29 = new GStruct51
			{
				string_0 = "MAP_NAME_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 6,
				int_7 = 0
			};
			Class53.gstruct51_30 = new GStruct51
			{
				string_0 = "KNPC_BASE_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 18,
				int_7 = 0
			};
			Class53.gstruct51_31 = new GStruct51
			{
				string_0 = "ATTACK_RANGE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 2,
				int_7 = 0
			};
			Class53.gstruct51_32 = new GStruct51
			{
				string_0 = "BUFF_BASE_ADDR",
				int_4 = 4,
				int_0 = 1,
				int_2 = 7,
				int_7 = 1
			};
			Class53.gstruct51_33 = new GStruct51
			{
				string_0 = "BUFF_BASE_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 13,
				int_7 = 0
			};
			Class53.gstruct51_34 = new GStruct51
			{
				string_0 = "BUFF_BASE_OFFSET",
				int_4 = 1,
				int_0 = 1,
				int_2 = 19,
				int_7 = 0
			};
			Class53.gstruct51_35 = new GStruct51
			{
				string_0 = "BUFF_DOING_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_36 = new GStruct51
			{
				string_0 = "BUFF_SKILL_ID_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 18
			};
			Class53.gstruct51_37 = new GStruct51
			{
				string_0 = "BUFF_POS_X_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 28
			};
			Class53.gstruct51_38 = new GStruct51
			{
				string_0 = "BUFF_POS_Y_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 34
			};
			Class53.gstruct51_39 = new GStruct51
			{
				string_0 = "BUFF_COUNT_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 4
			};
			Class53.gstruct51_40 = new GStruct51
			{
				string_0 = "BUFF_COMPARE_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 4
			};
			Class53.gstruct51_41 = new GStruct51
			{
				string_0 = "BUFF_TIME_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 39
			};
			Class53.gstruct51_42 = new GStruct51
			{
				string_0 = "BUFF_TIME_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_43 = new GStruct51
			{
				string_0 = "CHAR_FIGHT_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 10
			};
			Class53.gstruct51_44 = new GStruct51
			{
				string_0 = "RIDE_HORSE_OFFSE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 6
			};
			Class53.gstruct51_45 = new GStruct51
			{
				string_0 = "HP1_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 4
			};
			Class53.gstruct51_46 = new GStruct51
			{
				string_0 = "MP1_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_47 = new GStruct51
			{
				string_0 = "HP2_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 48
			};
			Class53.gstruct51_48 = new GStruct51
			{
				string_0 = "MP2_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 66
			};
			Class53.gstruct51_49 = new GStruct51
			{
				string_0 = "NPC_INDEX_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 17
			};
			Class53.gstruct51_50 = new GStruct51
			{
				string_0 = "NPC_EXISTS_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 16
			};
			Class53.gstruct51_51 = new GStruct51
			{
				uint_0 = 0U
			};
			Class53.gstruct51_52 = new GStruct51
			{
				uint_0 = 0U
			};
			Class53.gstruct51_53 = new GStruct51
			{
				uint_0 = 0U
			};
			Class53.gstruct51_54 = new GStruct51
			{
				string_0 = "NPC_COLOR_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15
			};
			Class53.gstruct51_55 = new GStruct51
			{
				string_0 = "NPC_DOING_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_56 = new GStruct51
			{
				string_0 = "KILLER_STATUS_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 35
			};
			Class53.gstruct51_57 = new GStruct51
			{
				string_0 = "POS_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 17
			};
			Class53.gstruct51_58 = new GStruct51
			{
				string_0 = "POS_X_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 4
			};
			Class53.gstruct51_59 = new GStruct51
			{
				string_0 = "POS_Y_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 7
			};
			Class53.gstruct51_60 = new GStruct51
			{
				string_0 = "KNPC_NAME_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 15
			};
			Class53.gstruct51_61 = default(GStruct51);
			Class53.gstruct51_62 = default(GStruct51);
			Class53.gstruct51_63 = default(GStruct51);
			Class53.gstruct51_64 = default(GStruct51);
			Class53.gstruct51_65 = default(GStruct51);
			Class53.gstruct51_66 = new GStruct51
			{
				string_0 = "NPC_PROFILE_STATUS_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_67 = new GStruct51
			{
				string_0 = "SCRIPT_LEFT_SKILL_BASE_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_68 = new GStruct51
			{
				string_0 = "KPLAYER_LEFT_SKILL",
				int_0 = 1,
				int_4 = 1,
				int_2 = 66
			};
			Class53.gstruct51_69 = new GStruct51
			{
				string_0 = "SCRIPT_RIGHT_SKILL_BASE_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_70 = new GStruct51
			{
				string_0 = "KPLAYER_RIGHT_SKILL",
				int_0 = 1,
				int_4 = 1,
				int_2 = 63
			};
			Class53.gstruct51_71 = new GStruct51
			{
				string_0 = "TOTAL_POIN_SKILL_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_72 = new GStruct51
			{
				string_0 = "m_nPeopleIdx",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15
			};
			Class53.gstruct51_73 = new GStruct51
			{
				string_0 = "MONEY_1_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 4
			};
			Class53.gstruct51_74 = new GStruct51
			{
				string_0 = "MONEY_2_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 18
			};
			Class53.gstruct51_75 = new GStruct51
			{
				string_0 = "MONEY_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 16
			};
			Class53.gstruct51_76 = new GStruct51
			{
				string_0 = "STATS_TOTAL_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_77 = default(GStruct51);
			Class53.gstruct51_78 = default(GStruct51);
			Class53.gstruct51_79 = default(GStruct51);
			Class53.gstruct51_80 = default(GStruct51);
			Class53.gstruct51_81 = default(GStruct51);
			Class53.gstruct51_82 = default(GStruct51);
			Class53.gstruct51_83 = default(GStruct51);
			Class53.gstruct51_84 = default(GStruct51);
			Class53.gstruct51_85 = new GStruct51
			{
				uint_0 = 48U
			};
			Class53.gstruct51_86 = new GStruct51
			{
				string_0 = "TONG_GLOBAL_BASE_ADDR"
			};
			Class53.gstruct51_87 = new GStruct51
			{
				string_0 = "TONG_GLOBAL_BASE_SIZE"
			};
			Class53.gstruct51_88 = new GStruct51
			{
				string_0 = "TONG_NAME_2ID",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_89 = new GStruct51
			{
				string_0 = "TONG_NAME_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_3 = 2,
				int_5 = 4
			};
			Class53.gstruct51_90 = new GStruct51
			{
				string_0 = "FUNC_SWITCH_KETHOP",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_8 = 1
			};
			Class53.gstruct51_91 = new GStruct51
			{
				string_0 = "SORTCUT_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_92 = new GStruct51
			{
				string_0 = "SORTCUT_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8,
				int_7 = 1
			};
			Class53.gstruct51_93 = new GStruct51
			{
				string_0 = "SORTCUT_NAME_OFF",
				int_0 = 1,
				int_4 = 1,
				int_2 = 15
			};
			Class53.gstruct51_94 = new GStruct51
			{
				string_0 = "SERVER_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 18,
				int_7 = 1
			};
			Class53.gstruct51_95 = new GStruct51
			{
				string_0 = "SERVER_NAME_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 19,
				int_1 = 1,
				int_3 = 10,
				int_5 = 4
			};
			Class53.gstruct51_96 = new GStruct51
			{
				string_0 = "CHECK_STATUS_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_97 = new GStruct51
			{
				string_0 = "KITEM_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_98 = new GStruct51
			{
				string_0 = "KITEM_NEXT_SEARCH_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 7
			};
			Class53.gstruct51_99 = new GStruct51
			{
				string_0 = "KITEM_ID_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12,
				int_1 = 1,
				int_5 = 4,
				int_3 = 15
			};
			Class53.gstruct51_100 = new GStruct51
			{
				string_0 = "KITEM_POS_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 1,
				int_3 = 2
			};
			Class53.gstruct51_101 = new GStruct51
			{
				string_0 = "KITEM_SET_PRICE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 3,
				int_1 = 1,
				int_3 = 3,
				int_5 = 1
			};
			Class53.gstruct51_102 = new GStruct51
			{
				string_0 = "KPLAYER_MOVEITEM",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_103 = new GStruct51
			{
				string_0 = "ITEM_IDKEY",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_104 = new GStruct51
			{
				string_0 = "FUNC_SHOP_BUY",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15,
				int_8 = 1
			};
			Class53.gstruct51_105 = new GStruct51
			{
				string_0 = "ITEM_BASE_ADD",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_106 = new GStruct51
			{
				string_0 = "ITEM_DATA_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_107 = new GStruct51
			{
				string_0 = "ITEM_NAME_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 15
			};
			Class53.gstruct51_108 = new GStruct51
			{
				string_0 = "ITEM_KIND",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_109 = new GStruct51
			{
				string_0 = "ITEM_COLOR",
				int_0 = 1,
				int_4 = 1,
				int_2 = 13
			};
			Class53.gstruct51_110 = new GStruct51
			{
				string_0 = "ITEM_GENRE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12
			};
			Class53.gstruct51_111 = new GStruct51
			{
				string_0 = "ITEM_WIDTH",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12
			};
			Class53.gstruct51_112 = new GStruct51
			{
				string_0 = "ITEM_HEIGHT",
				int_0 = 1,
				int_4 = 1,
				int_2 = 8
			};
			Class53.gstruct51_113 = new GStruct51
			{
				string_0 = "ITEM_PRICE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_114 = new GStruct51
			{
				string_0 = "ITEM_LEVEL",
				int_0 = 1,
				int_4 = 1,
				int_2 = 11
			};
			Class53.gstruct51_115 = new GStruct51
			{
				string_0 = "ITEM_SERIES",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12
			};
			Class53.gstruct51_116 = new GStruct51
			{
				string_0 = "ITEM_INTRO",
				int_0 = 1,
				int_4 = 4,
				int_2 = 10
			};
			Class53.gstruct51_117 = new GStruct51
			{
				string_0 = "ITEM_REQUIRE_ATTRIB",
				int_0 = 1,
				int_4 = 4,
				int_2 = 20
			};
			Class53.gstruct51_118 = new GStruct51
			{
				string_0 = "ITEM_MAGIC_ATTRIB",
				int_0 = 1,
				int_4 = 4,
				int_2 = 20
			};
			Class53.gstruct51_119 = new GStruct51
			{
				string_0 = "ITEM_DURATION",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15
			};
			Class53.gstruct51_120 = new GStruct51
			{
				string_0 = "ITEM_LOCK_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 5
			};
			Class53.gstruct51_121 = new GStruct51
			{
				string_0 = "ITEM_USE_FUNC_ADD",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_122 = new GStruct51
			{
				string_0 = "ITEM_THROW_FUNC_ADD",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_123 = new GStruct51
			{
				string_0 = "ITEM_HOLD_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 11,
				int_1 = 1,
				int_5 = 4,
				int_3 = 10
			};
			Class53.gstruct51_124 = new GStruct51
			{
				string_0 = "OBJECT_COUNT_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9,
				int_7 = 1
			};
			Class53.gstruct51_125 = new GStruct51
			{
				string_0 = "OBJECT_COUNT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 11
			};
			Class53.gstruct51_126 = new GStruct51
			{
				string_0 = "OBJECT_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_127 = new GStruct51
			{
				string_0 = "OBJECT_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_128 = new GStruct51
			{
				string_0 = "OBJECT_KIND_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 15
			};
			Class53.gstruct51_129 = new GStruct51
			{
				string_0 = "OBJECT_COLOR_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 80
			};
			Class53.gstruct51_130 = new GStruct51
			{
				string_0 = "OBJECT_SIZE_X_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 46
			};
			Class53.gstruct51_131 = new GStruct51
			{
				string_0 = "OBJECT_SIZE_Y_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 67
			};
			Class53.gstruct51_132 = new GStruct51
			{
				string_0 = "OBJECT_STACKCOUNT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13
			};
			Class53.gstruct51_133 = new GStruct51
			{
				string_0 = "OBJECT_POS_X",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_134 = new GStruct51
			{
				string_0 = "OBJECT_POS_Y",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_135 = new GStruct51
			{
				string_0 = "m_nObjectIdx",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_136 = new GStruct51
			{
				string_0 = "OBJECT_SERI_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 3
			};
			Class53.gstruct51_137 = new GStruct51
			{
				string_0 = "OBJECT_TIME_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_138 = new GStruct51
			{
				string_0 = "OBJECT_NAME_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12
			};
			Class53.gstruct51_139 = new GStruct51
			{
				string_0 = "OBJECT_TYPE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_140 = new GStruct51
			{
				string_0 = "OBJ_EXIST",
				int_0 = 1,
				int_4 = 4,
				int_2 = 14
			};
			Class53.gstruct51_141 = new GStruct51
			{
				string_0 = "OBJ_GROWN",
				int_0 = 1,
				int_4 = 1,
				int_2 = 10
			};
			Class53.gstruct51_142 = new GStruct51
			{
				string_0 = "PICKUP_OBJECT_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_143 = new GStruct51
			{
				string_0 = "MENU_00_01_FLAG_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_144 = new GStruct51
			{
				string_0 = "FUNC_MENU_0_CLICK_INDEX",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0,
				int_1 = 1,
				int_5 = 0,
				int_3 = 0
			};
			Class53.gstruct51_145 = new GStruct51
			{
				string_0 = "FUNC_MENU_1_CLICK_INDEX",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0,
				int_1 = 1,
				int_5 = 0,
				int_3 = -1
			};
			Class53.gstruct51_146 = new GStruct51
			{
				string_0 = "MENU_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2
			};
			Class53.gstruct51_147 = new GStruct51
			{
				string_0 = "MENU_0_COUNT_BASE_OFFSET",
				int_0 = 1,
				int_1 = 1,
				int_4 = 4,
				int_5 = 4,
				int_2 = 2,
				int_3 = -4,
				int_7 = 1
			};
			Class53.gstruct51_148 = new GStruct51
			{
				string_0 = "MENU_0_COUNT_SIZE",
				int_0 = 1,
				int_1 = 1,
				int_4 = 4,
				int_5 = 4,
				int_2 = 20,
				int_3 = 11
			};
			Class53.gstruct51_149 = new GStruct51
			{
				string_0 = "MENU_1_COUNT_BASE_OFFSET",
				int_0 = 1,
				int_1 = 1,
				int_4 = 4,
				int_5 = 4,
				int_2 = 2,
				int_3 = -4,
				int_7 = 1
			};
			Class53.gstruct51_150 = new GStruct51
			{
				string_0 = "MENU_1_COUNT_SIZE",
				int_0 = 2,
				int_4 = 4,
				int_2 = 20,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2
			};
			Class53.gstruct51_151 = new GStruct51
			{
				string_0 = "MENU_1_VISABLE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_152 = new GStruct51
			{
				string_0 = "DIALOG_FUNC_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2,
				int_7 = 1
			};
			Class53.gstruct51_153 = new GStruct51
			{
				string_0 = "DIALOG_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 21,
				int_7 = 1
			};
			Class53.gstruct51_154 = new GStruct51
			{
				string_0 = "DIALOG_INDEX_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_155 = new GStruct51
			{
				string_0 = "DIALOG_COUNT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_156 = new GStruct51
			{
				string_0 = "DIALOG_TEXT_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2,
				int_1 = 1,
				int_5 = 1,
				int_3 = 2
			};
			Class53.gstruct51_157 = new GStruct51
			{
				string_0 = "DIALOG_TEXT_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2
			};
			Class53.gstruct51_158 = new GStruct51
			{
				string_0 = "BOX_THUTHAP_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = -4,
				int_7 = 1
			};
			Class53.gstruct51_159 = new GStruct51
			{
				string_0 = "BOX_THUTHAP_SHOW",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_160 = new GStruct51
			{
				string_0 = "SKILL_DIRECT_SHORTCUT_BASE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 5,
				int_7 = 1
			};
			Class53.gstruct51_161 = new GStruct51
			{
				string_0 = "SKILL_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 16
			};
			Class53.gstruct51_162 = new GStruct51
			{
				string_0 = "SKILL_START_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_163 = new GStruct51
			{
				string_0 = "SKILL_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 12
			};
			Class53.gstruct51_164 = new GStruct51
			{
				string_0 = "SKILL_INC_LEVEL_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 21,
				int_1 = 1,
				int_5 = 4,
				int_3 = 20,
				int_8 = 1
			};
			Class53.gstruct51_165 = new GStruct51
			{
				string_0 = "SMS_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8
			};
			Class53.gstruct51_166 = new GStruct51
			{
				string_0 = "SMS_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15
			};
			Class53.gstruct51_167 = new GStruct51
			{
				string_0 = "SMS_TEXT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15,
				int_1 = 1,
				int_5 = 1,
				int_3 = 3
			};
			Class53.gstruct51_168 = new GStruct51
			{
				string_0 = "SMS_FLAG_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 3,
				int_1 = 1,
				int_5 = 4,
				int_3 = 6
			};
			Class53.gstruct51_169 = new GStruct51
			{
				string_0 = "CLEAR_SMS_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 19,
				int_1 = 1,
				int_5 = 4,
				int_3 = 6,
				int_8 = 1
			};
			Class53.gstruct51_170 = new GStruct51
			{
				uint_0 = 1100U
			};
			Class53.gstruct51_171 = new GStruct51
			{
				string_0 = "BOX_TEXT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 5
			};
			Class53.gstruct51_172 = new GStruct51
			{
				string_0 = "BOX_GLOBAL_ENTER_NUMBER",
				int_0 = 1,
				int_4 = 4,
				int_2 = 6,
				int_7 = 1
			};
			Class53.gstruct51_173 = new GStruct51
			{
				string_0 = "BOX_GLOBAL_ENTER_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_174 = new GStruct51
			{
				string_0 = "FLAG_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12,
				int_7 = 1
			};
			Class53.gstruct51_175 = new GStruct51
			{
				string_0 = "FLAG_BOX_TITLE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 23,
				int_7 = 1
			};
			Class53.gstruct51_176 = new GStruct51
			{
				string_0 = "FLAG_BOXENTER_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 29,
				int_8 = 1
			};
			Class53.gstruct51_177 = new GStruct51
			{
				string_0 = "BOX_VANSUTHONG_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 11,
				int_7 = 1
			};
			Class53.gstruct51_178 = new GStruct51
			{
				string_0 = "FLAG_IS_STICK",
				int_0 = 1,
				int_4 = 4,
				int_2 = 5,
				int_7 = 1
			};
			Class53.gstruct51_179 = new GStruct51
			{
				string_0 = "BOX_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 6,
				int_7 = 1
			};
			Class53.gstruct51_180 = new GStruct51
			{
				string_0 = "BOX_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 14,
				int_1 = 1,
				int_5 = 4,
				int_3 = 15
			};
			Class53.gstruct51_181 = new GStruct51
			{
				string_0 = "BOX_OPEN_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 17,
				int_1 = 1,
				int_5 = 1,
				int_3 = 14
			};
			Class53.gstruct51_182 = new GStruct51
			{
				string_0 = "OPEN_FUNC_SPEC",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_183 = new GStruct51
			{
				string_0 = "BOX_COUNT_ITEM_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 4,
				int_3 = 6
			};
			Class53.gstruct51_184 = new GStruct51
			{
				string_0 = "BOX_COUNT_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_185 = new GStruct51
			{
				string_0 = "BOX_ACCEPT_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 18,
				int_8 = 1
			};
			Class53.gstruct51_186 = new GStruct51
			{
				string_0 = "BOX_INC_POINT_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 14,
				int_1 = 1,
				int_5 = 4,
				int_3 = 7,
				int_8 = 1
			};
			Class53.gstruct51_187 = new GStruct51
			{
				string_0 = "BOX_UNLOCK_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_188 = new GStruct51
			{
				string_0 = "TONG_ENTER_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_189 = new GStruct51
			{
				string_0 = "TONG_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9
			};
			Class53.gstruct51_190 = new GStruct51
			{
				string_0 = "TONG_PUSH_MONEY_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 8
			};
			Class53.gstruct51_191 = new GStruct51
			{
				string_0 = "TONG_PUSH_MONEY_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = -4,
				int_7 = 1
			};
			Class53.gstruct51_192 = new GStruct51
			{
				string_0 = "TONG_PUSH_MONEY_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 1,
				int_8 = 1
			};
			Class53.gstruct51_193 = new GStruct51
			{
				string_0 = "TONG_BASE_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 8,
				int_7 = 1
			};
			Class53.gstruct51_194 = new GStruct51
			{
				string_0 = "TONG_FUNC_GET_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_8 = 1
			};
			Class53.gstruct51_195 = new GStruct51
			{
				string_0 = "TONG_FUNC_ACCEPT_CHANGE_COLOR",
				int_0 = 1,
				int_4 = 0,
				int_2 = -19
			};
			Class53.gstruct51_196 = new GStruct51
			{
				string_0 = "TONG_SPEC_FUNC",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_197 = new GStruct51
			{
				string_0 = "TONG_TUYENCHI_BASE_ADDR"
			};
			Class53.gstruct51_198 = new GStruct51
			{
				uint_0 = 32U
			};
			Class53.gstruct51_199 = new GStruct51
			{
				uint_0 = 4U
			};
			Class53.gstruct51_200 = default(GStruct51);
			Class53.gstruct51_201 = new GStruct51
			{
				string_0 = "TEAM_CREATE",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0,
				int_8 = 1
			};
			Class53.gstruct51_202 = new GStruct51
			{
				string_0 = "TEAM_MEMBER",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_203 = new GStruct51
			{
				string_0 = "TEAM_LIST_NAME_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_7 = 1
			};
			Class53.gstruct51_204 = new GStruct51
			{
				string_0 = "TEAM_CAPTAIN_NAME_OFF",
				int_0 = 1,
				int_4 = 4,
				int_2 = 14
			};
			Class53.gstruct51_205 = new GStruct51
			{
				string_0 = "TEAM_CAPTAIN_NAME_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 19
			};
			Class53.gstruct51_206 = new GStruct51
			{
				string_0 = "TEAM_LEAVE_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_207 = new GStruct51
			{
				string_0 = "LASTCHANEL_TOP_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_208 = new GStruct51
			{
				string_0 = "LASTCHANEL_BOTTOM_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 17
			};
			Class53.gstruct51_209 = new GStruct51
			{
				string_0 = "LASTCHANEL_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_210 = new GStruct51
			{
				string_0 = "LASTCHANEL_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 1,
				int_8 = 1
			};
			Class53.gstruct51_211 = new GStruct51
			{
				string_0 = "LASTCHANEL_COUNT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_212 = new GStruct51
			{
				string_0 = "LASTCHANEL_GETTEXT_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 11
			};
			Class53.gstruct51_213 = new GStruct51
			{
				string_0 = "LASTCHANEL_TEXT_SIZE",
				int_0 = 1,
				int_4 = 1,
				int_2 = 43
			};
			Class53.gstruct51_214 = new GStruct51
			{
				string_0 = "LASTCHANEL_ITEM_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2
			};
			Class53.gstruct51_215 = new GStruct51
			{
				string_0 = "LASTCHANEL_TABBUTTON_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_216 = new GStruct51
			{
				string_0 = "LASTCHANEL_TABBUTTON_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 12
			};
			Class53.gstruct51_217 = new GStruct51
			{
				string_0 = "PLAYER_CHAT_FUNC_ADD",
				int_0 = 1,
				int_4 = 4,
				int_2 = 30,
				int_1 = 1,
				int_5 = 4,
				int_3 = 18,
				int_8 = 1
			};
			Class53.gstruct51_218 = new GStruct51
			{
				string_0 = "PLAYER_SAY_FUNC_ADDR",
				int_0 = 1,
				int_1 = 1,
				int_4 = 4,
				int_5 = 4,
				int_2 = 1,
				int_3 = 1,
				int_8 = 1
			};
			Class53.gstruct51_219 = new GStruct51
			{
				string_0 = "PLAYER_PRINT_FUNC_ADD",
				int_0 = 1,
				int_1 = 1,
				int_4 = 4,
				int_5 = 4,
				int_2 = 20,
				int_3 = 8,
				int_8 = 1
			};
			Class53.gstruct51_220 = new GStruct51
			{
				string_0 = "REPLY_INVITE_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_221 = new GStruct51
			{
				string_0 = "DOSCRIPT_FUNC_ADD",
				int_0 = 1,
				int_4 = 4,
				int_2 = 15,
				int_8 = 1
			};
			Class53.gstruct51_222 = new GStruct51
			{
				string_0 = "CLICKTO_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_223 = new GStruct51
			{
				string_0 = "RUNTO_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_224 = new GStruct51
			{
				string_0 = "FUNC_SPEC_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 16
			};
			Class53.gstruct51_225 = new GStruct51
			{
				string_0 = "FUNC_SPEC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 21,
				int_8 = 1
			};
			Class53.gstruct51_226 = new GStruct51
			{
				string_0 = "TRADE_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 1,
				int_8 = 1
			};
			Class53.gstruct51_227 = new GStruct51
			{
				string_0 = "TRADE_ACCEPT_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_228 = new GStruct51
			{
				string_0 = "TRADE_APPLY_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_229 = new GStruct51
			{
				string_0 = "TRADE_PUT_MONEY_FUNC_ADDR",
				int_0 = 1,
				int_4 = 0,
				int_2 = 0
			};
			Class53.gstruct51_230 = new GStruct51
			{
				string_0 = "TRADE_GET_MONEY_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 19
			};
			Class53.gstruct51_231 = new GStruct51
			{
				string_0 = "TRADE_PUT_MONEY_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 7
			};
			Class53.gstruct51_232 = new GStruct51
			{
				string_0 = "KYTRANCAC_CLOSE_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 3,
				int_1 = 1,
				int_5 = 4,
				int_3 = 3,
				int_8 = 1
			};
			Class53.gstruct51_233 = new GStruct51
			{
				string_0 = "FOLLOW_INDEX_FUNC_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 14,
				int_8 = 1
			};
			Class53.gstruct51_234 = new GStruct51
			{
				string_0 = "RETURNCITY_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 26,
				int_1 = 1,
				int_3 = 16,
				int_5 = 4,
				int_7 = 1
			};
			Class53.gstruct51_235 = new GStruct51
			{
				string_0 = "RETURNCITY_SIZE",
				int_0 = 2,
				int_4 = 4,
				int_2 = 38,
				int_1 = 1,
				int_5 = 4,
				int_3 = 29
			};
			Class53.gstruct51_236 = new GStruct51
			{
				string_0 = "KSHOP_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_237 = new GStruct51
			{
				string_0 = "REPAIR_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 7,
				int_8 = 1
			};
			Class53.gstruct51_238 = new GStruct51
			{
				string_0 = "REPAIR_MONEY_FUNC",
				int_0 = 1,
				int_4 = 4,
				int_2 = 1,
				int_8 = 1
			};
			Class53.gstruct51_239 = new GStruct51
			{
				string_0 = "HELP_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 7,
				int_1 = 1,
				int_5 = 4,
				int_3 = 4,
				int_7 = 1
			};
			Class53.gstruct51_240 = new GStruct51
			{
				string_0 = "HELP_BASE_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_1 = 1,
				int_5 = 4,
				int_3 = 10
			};
			Class53.gstruct51_241 = new GStruct51
			{
				string_0 = "HELP_COUNT_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_1 = 1,
				int_5 = 4,
				int_3 = 2
			};
			Class53.gstruct51_242 = new GStruct51
			{
				string_0 = "STRING_INPUT_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 7
			};
			Class53.gstruct51_243 = new GStruct51
			{
				string_0 = "MAP_EXIST_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 2
			};
			Class53.gstruct51_244 = new GStruct51
			{
				string_0 = "MAP_NEXT_SIZE",
				int_4 = 4,
				int_0 = 1,
				int_2 = 29
			};
			Class53.gstruct51_245 = new GStruct51
			{
				string_0 = "CPU_GIAM_MUC_1",
				int_4 = 0,
				int_0 = 1,
				int_2 = 13
			};
			Class53.gstruct51_246 = new GStruct51
			{
				string_0 = "CPU_GIAM_MUC_2",
				int_4 = 0,
				int_0 = 1,
				int_2 = 4
			};
			Class53.gstruct51_247 = new GStruct51
			{
				string_0 = "CPU_SLEEP_1",
				int_4 = 0,
				int_0 = 1,
				int_2 = 2
			};
			Class53.gstruct51_248 = new GStruct51
			{
				string_0 = "CPU_SLEEP_2",
				int_4 = 0,
				int_0 = 1,
				int_2 = 2
			};
			Class53.gstruct51_249 = new GStruct51
			{
				string_0 = "CPU_SLEEP_3",
				int_4 = 0,
				int_0 = 2,
				int_2 = 2
			};
			Class53.gstruct51_250 = new GStruct51
			{
				string_0 = "FLAG_SHOW_GAME",
				int_0 = 1,
				int_4 = 0,
				int_2 = 9
			};
			Class53.gstruct51_251 = new GStruct51
			{
				string_0 = "DANHHIEU_STATUS_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2
			};
			Class53.gstruct51_252 = new GStruct51
			{
				string_0 = "TONGKIM_SOLUONG_NGUOI",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_253 = new GStruct51
			{
				string_0 = "GET_TICK_COUNT",
				int_0 = 1,
				int_4 = 4,
				int_2 = 9,
				int_7 = 1
			};
			Class53.gstruct51_254 = new GStruct51
			{
				string_0 = "TONGKIM_THOIGIAN_BATDAU",
				int_0 = 1,
				int_4 = 4,
				int_2 = 10,
				int_7 = 1
			};
			Class53.gstruct51_255 = new GStruct51
			{
				string_0 = "TONGKIM_THOIGIAN_HIENTAI",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_256 = new GStruct51
			{
				string_0 = "TONGKIM_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = -4,
				int_7 = 1
			};
			Class53.gstruct51_257 = new GStruct51
			{
				string_0 = "TONGKIM_PLAYER_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_7 = 1
			};
			Class53.gstruct51_258 = new GStruct51
			{
				string_0 = "TONGKIM_POINT_MAX_OFFSET",
				int_0 = 1,
				int_4 = 1,
				int_2 = 2
			};
			Class53.gstruct51_259 = new GStruct51
			{
				string_0 = "GATEWAY_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 5,
				int_7 = 1
			};
			Class53.gstruct51_260 = new GStruct51
			{
				string_0 = "GATEWAY_CONNECT_OFFSET",
				int_0 = 1,
				int_4 = 4,
				int_2 = 2,
				int_5 = 4,
				int_1 = 1,
				int_3 = 2
			};
			Class53.gstruct51_261 = new GStruct51
			{
				string_0 = "BOX_SHORTCUT_SIZE",
				int_0 = 1,
				int_4 = 4,
				int_2 = 29
			};
			Class53.gstruct51_262 = new GStruct51
			{
				string_0 = "BOX_CHETAO_BASE_ADDR",
				int_0 = 1,
				int_4 = 4,
				int_2 = 13,
				int_7 = 1
			};
			Class53.gstruct51_263 = new GStruct51
			{
				string_0 = "SKILL_INFO_BASE_0_ADDR",
				string_1 = "81 ?? ?? ?? ?? ?? 0F 87 ?? ?? ?? ?? 8B ?? C1 ?? 08 8B",
				int_0 = 1,
				int_4 = 4,
				int_2 = 19,
				int_7 = 1
			};
			Class53.gstruct51_264 = new GStruct51
			{
				string_0 = "FUNC_MENU_0_CLOSE"
			};
			Class53.gstruct51_265 = new GStruct51
			{
				string_0 = "QUEST_BASE_ADDR"
			};
			Class53.gstruct51_266 = new GStruct51
			{
				string_0 = "QUEST_PRISE_0_SIZE"
			};
			Class53.gstruct51_267 = new GStruct51
			{
				string_0 = "QUEST_PRISE_1_SIZE"
			};
			Class53.gstruct51_268 = new GStruct51
			{
				string_0 = "QUEST_PRISE_2_SIZE"
			};
			Class53.bool_0 = false;
			Class53.bool_1 = false;
			Class53.string_25 = null;
			Class53.string_26 = null;
			Class53.int_7 = 0;
			Class53.int_8 = 0;
			int[,] array_ = new int[5, 5];
			Class11.smethod_4(array_, 251794);
			Class53.int_9 = array_;
			int[,] array_2 = new int[5, 10];
			Class11.smethod_4(array_2, 251903);
			Class53.int_10 = array_2;
			Class53.gstruct51_269 = new GStruct51
			{
				string_0 = "represent2.dll",
				int_0 = 1,
				int_4 = 0,
				int_2 = 3,
				int_1 = 1,
				int_5 = 0,
				int_3 = 7
			};
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0007F148 File Offset: 0x0007D348
		public static string smethod_0()
		{
			string text = string.Empty;
			int[] array = Class22.smethod_24(Class53.string_21, null, false);
			bool flag = array != null && array.Length != 0;
			if (flag)
			{
				int i = 0;
				while (i < array.Length)
				{
					try
					{
						Process processById = Process.GetProcessById(array[i]);
						text = processById.MainModule.FileName;
						bool flag2 = text == null || !(text != string.Empty);
						if (!flag2)
						{
							return text;
						}
					}
					catch
					{
					}
					IL_68:
					i++;
					continue;
					goto IL_68;
				}
			}
			return text;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0007F1E8 File Offset: 0x0007D3E8
		public static GStruct37[] smethod_1()
		{
			return new GStruct37[]
			{
				new GStruct37
				{
					int_0 = 1,
					int_1 = 43,
					int_2 = 0,
					string_0 = "Không thể phá hủy"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 139,
					int_2 = 0,
					string_0 = "Kỹ năng  Võ công vốn có"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 58,
					int_2 = 1,
					string_0 = "Bỏ qua né tránh: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 117,
					int_2 = 15,
					string_0 = "Phản đòn cận chiến: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 120,
					int_2 = 5,
					string_0 = "Phản đòn tầm xa: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 134,
					int_2 = 8,
					string_0 = "Chuyển hóa sát thương thành nội lực: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 135,
					int_2 = 1,
					string_0 = "May mắn: +(x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 166,
					int_2 = 250,
					string_0 = "Tỉ lệ công kích chính xác: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 111,
					int_2 = 25,
					string_0 = "Tốc độ di chuyển: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 115,
					int_2 = 10,
					string_0 = "Tốc độ đánh - ngoại công: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 116,
					int_2 = 30,
					string_0 = "Tốc độ đánh - nội công: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 239,
					int_2 = 200,
					string_0 = "Tốc độ đánh - ngoại công (Dương): +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 240,
					int_2 = 140,
					string_0 = "Tốc độ đánh - nội công (Dương): +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 114,
					int_2 = 10,
					string_0 = "Kháng tất cả: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 136,
					int_2 = 3,
					string_0 = "Hút sinh lực: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 137,
					int_2 = 3,
					string_0 = "Hút nội lực: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 106,
					int_2 = 30,
					string_0 = "Thời gian làm chậm: -(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 110,
					int_2 = 30,
					string_0 = "Thời gian choáng: -(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 108,
					int_2 = 30,
					string_0 = "Thời gian trúng độc: -(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 113,
					int_2 = 30,
					string_0 = "Thời gian phục hồi: -(x)"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 245,
					int_2 = 80,
					string_0 = "Thời gian phục hồi (Dương): -(x)"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 237,
					int_2 = 60,
					string_0 = "Triệt tiêu sát thương (Dương): +(x)"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 104,
					int_2 = 15,
					string_0 = "Phòng thủ vật lý: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 101,
					int_2 = 25,
					string_0 = "Kháng độc: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 102,
					int_2 = 20,
					string_0 = "Kháng hỏa: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 103,
					int_2 = 20,
					string_0 = "Kháng lôi: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 105,
					int_2 = 20,
					string_0 = "Kháng băng: +(x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 121,
					int_2 = 50,
					string_0 = "Sát thương vật lý - ngoại công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 126,
					int_2 = 80,
					string_0 = "Sát thương vật lý - ngoại công: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 168,
					int_2 = 100,
					string_0 = "Sát thương vật lý - nội công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 244,
					int_2 = 80,
					string_0 = "Sát thương vật lý - nội công: +(x) %"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 123,
					int_2 = 50,
					string_0 = "Băng sát - ngoại công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 169,
					int_2 = 80,
					string_0 = "Băng sát - nội công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 122,
					int_2 = 50,
					string_0 = "Hỏa sát - ngoại công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 170,
					int_2 = 80,
					string_0 = "Hỏa sát - nội công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 124,
					int_2 = 50,
					string_0 = "Lôi sát - ngoại công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 171,
					int_2 = 80,
					string_0 = "Lôi sát - nội công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 125,
					int_2 = 15,
					string_0 = "Độc sát - ngoại công: +(x) điểm/lần"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 172,
					int_2 = 15,
					string_0 = "Độc sát - nội công: +(x) điểm/lần"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 85,
					int_2 = 100,
					string_0 = "Sinh lực tối đa: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 99,
					int_2 = 10,
					string_0 = "Sinh khí: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 89,
					int_2 = 100,
					string_0 = "Nội lực tối đa: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 100,
					int_2 = 10,
					string_0 = "Nội công: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 93,
					int_2 = 160,
					string_0 = "Thể lực tối đa: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 97,
					int_2 = 10,
					string_0 = "Sức mạnh: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 98,
					int_2 = 10,
					string_0 = "Thân pháp: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 88,
					int_2 = 3,
					string_0 = "Phục hồi sinh lực mỗi nửa giây: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 1,
					int_1 = 92,
					int_2 = 1,
					string_0 = "Phục hồi nội lực mỗi nửa giây: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 96,
					int_2 = 5,
					string_0 = "Phục hồi thể lực mỗi nửa giây: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 220,
					int_2 = 8,
					string_0 = "Tạo thành thời gian choáng: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 219,
					int_2 = 40,
					string_0 = "Tạo thành sát thương có thời gian hoạt động: +(x) điểm"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 221,
					int_2 = 15,
					string_0 = "Xem nhẹ độc phòng của đối phương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 222,
					int_2 = 15,
					string_0 = "Xem nhẹ hỏa phòng của đối phương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 223,
					int_2 = 15,
					string_0 = "Xem nhẹ lôi phòng của đối phương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 224,
					int_2 = 15,
					string_0 = "Xem nhẹ phổ phòng của đối phương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 225,
					int_2 = 15,
					string_0 = "Xem nhẹ băng phòng của đối phương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 70,
					int_2 = 5,
					string_0 = "Tấn công chí mạng: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 226,
					int_2 = 10,
					string_0 = "Xác suất hóa giải sát thương: (x) %"
				},
				new GStruct37
				{
					int_0 = 0,
					int_1 = 227,
					int_2 = 8,
					string_0 = "Xác suất trọng kích: (x) %"
				}
			};
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0007FEF0 File Offset: 0x0007E0F0
		private static GStruct51[] smethod_2()
		{
			return new GStruct51[]
			{
				Class66.gstruct51_16,
				Class66.gstruct51_17,
				Class66.gstruct51_18,
				Class66.gstruct51_19,
				Class66.gstruct51_20,
				Class66.gstruct51_21,
				Class66.gstruct51_22,
				Class66.gstruct51_23,
				Class66.gstruct51_24,
				Class66.gstruct51_25,
				Class66.gstruct51_26,
				Class66.gstruct51_27,
				Class66.gstruct51_28,
				Class66.gstruct51_29,
				Class66.gstruct51_30,
				Class66.gstruct51_31,
				Class53.gstruct51_259,
				Class53.gstruct51_260,
				Class53.gstruct51_1,
				Class53.gstruct51_250,
				Class53.gstruct51_262,
				Class53.gstruct51_247,
				Class53.gstruct51_248,
				Class53.gstruct51_249,
				Class53.gstruct51_245,
				Class53.gstruct51_246,
				Class53.gstruct51_243,
				Class53.gstruct51_244,
				Class53.gstruct51_242,
				Class53.gstruct51_261,
				Class53.gstruct51_4,
				Class53.gstruct51_2,
				Class53.gstruct51_3,
				Class53.gstruct51_6,
				Class53.gstruct51_5,
				Class53.gstruct51_7,
				Class53.gstruct51_251,
				Class53.gstruct51_252,
				Class53.gstruct51_253,
				Class53.gstruct51_254,
				Class53.gstruct51_255,
				Class53.gstruct51_256,
				Class53.gstruct51_257,
				Class53.gstruct51_258,
				Class53.gstruct51_11,
				Class53.gstruct51_12,
				Class53.gstruct51_13,
				Class53.gstruct51_18,
				Class53.gstruct51_19,
				Class53.gstruct51_20,
				Class53.gstruct51_21,
				Class53.gstruct51_22,
				Class53.gstruct51_9,
				Class53.gstruct51_10,
				Class53.gstruct51_14,
				Class53.gstruct51_15,
				Class53.gstruct51_16,
				Class53.gstruct51_17,
				Class53.gstruct51_23,
				Class53.gstruct51_26,
				Class53.gstruct51_27,
				Class53.gstruct51_28,
				Class53.gstruct51_29,
				Class53.gstruct51_30,
				Class53.gstruct51_31,
				Class53.gstruct51_32,
				Class53.gstruct51_33,
				Class53.gstruct51_34,
				Class53.gstruct51_35,
				Class53.gstruct51_36,
				Class53.gstruct51_37,
				Class53.gstruct51_38,
				Class53.gstruct51_39,
				Class53.gstruct51_40,
				Class53.gstruct51_41,
				Class53.gstruct51_42,
				Class53.gstruct51_43,
				Class53.gstruct51_44,
				Class53.gstruct51_45,
				Class53.gstruct51_46,
				Class53.gstruct51_47,
				Class53.gstruct51_48,
				Class53.gstruct51_49,
				Class53.gstruct51_50,
				Class53.gstruct51_54,
				Class53.gstruct51_55,
				Class53.gstruct51_56,
				Class53.gstruct51_57,
				Class53.gstruct51_58,
				Class53.gstruct51_59,
				Class53.gstruct51_60,
				Class53.gstruct51_66,
				Class53.gstruct51_72,
				Class53.gstruct51_73,
				Class53.gstruct51_74,
				Class53.gstruct51_75,
				Class53.gstruct51_233,
				Class53.gstruct51_76,
				Class53.gstruct51_90,
				Class53.gstruct51_91,
				Class53.gstruct51_92,
				Class53.gstruct51_93,
				Class53.gstruct51_94,
				Class53.gstruct51_95,
				Class53.gstruct51_96,
				Class53.gstruct51_234,
				Class53.gstruct51_235,
				Class53.gstruct51_97,
				Class53.gstruct51_98,
				Class53.gstruct51_99,
				Class53.gstruct51_100,
				Class53.gstruct51_101,
				Class53.gstruct51_102,
				Class53.gstruct51_105,
				Class53.gstruct51_106,
				Class53.gstruct51_107,
				Class53.gstruct51_108,
				Class53.gstruct51_109,
				Class53.gstruct51_111,
				Class53.gstruct51_112,
				Class53.gstruct51_110,
				Class53.gstruct51_113,
				Class53.gstruct51_114,
				Class53.gstruct51_115,
				Class53.gstruct51_116,
				Class53.gstruct51_118,
				Class53.gstruct51_117,
				Class53.gstruct51_119,
				Class53.gstruct51_120,
				Class53.gstruct51_121,
				Class53.gstruct51_122,
				Class53.gstruct51_123,
				Class53.gstruct51_103,
				Class53.gstruct51_104,
				Class53.gstruct51_124,
				Class53.gstruct51_125,
				Class53.gstruct51_126,
				Class53.gstruct51_127,
				Class53.gstruct51_128,
				Class53.gstruct51_129,
				Class53.gstruct51_130,
				Class53.gstruct51_131,
				Class53.gstruct51_132,
				Class53.gstruct51_133,
				Class53.gstruct51_134,
				Class53.gstruct51_135,
				Class53.gstruct51_136,
				Class53.gstruct51_137,
				Class53.gstruct51_138,
				Class53.gstruct51_139,
				Class53.gstruct51_140,
				Class53.gstruct51_141,
				Class53.gstruct51_142,
				Class53.gstruct51_143,
				Class53.gstruct51_145,
				Class53.gstruct51_144,
				Class53.gstruct51_146,
				Class53.gstruct51_147,
				Class53.gstruct51_148,
				Class53.gstruct51_149,
				Class53.gstruct51_150,
				Class53.gstruct51_151,
				Class53.gstruct51_153,
				Class53.gstruct51_155,
				Class53.gstruct51_154,
				Class53.gstruct51_152,
				Class53.gstruct51_156,
				Class53.gstruct51_157,
				Class53.gstruct51_158,
				Class53.gstruct51_159,
				Class53.gstruct51_263,
				Class53.gstruct51_160,
				Class53.gstruct51_67,
				Class53.gstruct51_68,
				Class53.gstruct51_69,
				Class53.gstruct51_70,
				Class53.gstruct51_71,
				Class53.gstruct51_161,
				Class53.gstruct51_163,
				Class53.gstruct51_162,
				Class53.gstruct51_164,
				Class53.gstruct51_165,
				Class53.gstruct51_166,
				Class53.gstruct51_167,
				Class53.gstruct51_168,
				Class53.gstruct51_169,
				Class53.gstruct51_179,
				Class53.gstruct51_180,
				Class53.gstruct51_181,
				Class53.gstruct51_182,
				Class53.gstruct51_183,
				Class53.gstruct51_184,
				Class53.gstruct51_185,
				Class53.gstruct51_186,
				Class53.gstruct51_187,
				Class53.gstruct51_232,
				Class53.gstruct51_236,
				Class53.gstruct51_237,
				Class53.gstruct51_238,
				Class53.gstruct51_171,
				Class53.gstruct51_172,
				Class53.gstruct51_173,
				Class53.gstruct51_174,
				Class53.gstruct51_175,
				Class53.gstruct51_176,
				Class53.gstruct51_177,
				Class53.gstruct51_178,
				Class53.gstruct51_188,
				Class53.gstruct51_89,
				Class53.gstruct51_88,
				Class53.gstruct51_189,
				Class53.gstruct51_190,
				Class53.gstruct51_191,
				Class53.gstruct51_192,
				Class53.gstruct51_196,
				Class53.gstruct51_193,
				Class53.gstruct51_194,
				Class53.gstruct51_195,
				Class53.gstruct51_201,
				Class53.gstruct51_202,
				Class53.gstruct51_203,
				Class53.gstruct51_204,
				Class53.gstruct51_205,
				Class53.gstruct51_206,
				Class53.gstruct51_220,
				Class53.gstruct51_226,
				Class53.gstruct51_227,
				Class53.gstruct51_228,
				Class53.gstruct51_229,
				Class53.gstruct51_231,
				Class53.gstruct51_230,
				Class53.gstruct51_207,
				Class53.gstruct51_208,
				Class53.gstruct51_209,
				Class53.gstruct51_210,
				Class53.gstruct51_211,
				Class53.gstruct51_212,
				Class53.gstruct51_213,
				Class53.gstruct51_214,
				Class53.gstruct51_215,
				Class53.gstruct51_216,
				Class53.gstruct51_225,
				Class53.gstruct51_224,
				Class53.gstruct51_221,
				Class53.gstruct51_217,
				Class53.gstruct51_218,
				Class53.gstruct51_219,
				Class53.gstruct51_222,
				Class53.gstruct51_223,
				Class53.gstruct51_239,
				Class53.gstruct51_240,
				Class53.gstruct51_241,
				Class53.gstruct51_264,
				Class53.gstruct51_265
			};
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00080D64 File Offset: 0x0007EF64
		public static uint[] smethod_3()
		{
			return new uint[]
			{
				Class53.gstruct51_109.uint_0,
				Class53.gstruct51_110.uint_0,
				Class53.gstruct51_114.uint_0,
				Class53.gstruct51_115.uint_0,
				Class53.gstruct51_111.uint_0,
				Class53.gstruct51_112.uint_0,
				Class53.gstruct51_113.uint_0,
				Class53.gstruct51_117.uint_0,
				Class53.gstruct51_117.uint_0 + 4U,
				Class53.gstruct51_117.uint_0 + 8U,
				Class53.gstruct51_117.uint_0 + 12U,
				Class53.gstruct51_118.uint_0,
				Class53.gstruct51_118.uint_0 + 4U,
				Class53.gstruct51_118.uint_0 + 8U,
				Class53.gstruct51_118.uint_0 + 12U,
				Class53.gstruct51_118.uint_0 + 16U,
				Class53.gstruct51_118.uint_0 + 12U,
				Class53.gstruct51_118.uint_0 + 16U,
				Class53.gstruct51_118.uint_0 + 20U,
				Class53.gstruct51_118.uint_0 + 24U,
				Class53.gstruct51_118.uint_0 + 28U,
				Class53.gstruct51_118.uint_0 + 32U,
				Class53.gstruct51_118.uint_0 + 36U
			};
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00080EDC File Offset: 0x0007F0DC
		private static int smethod_4(GStruct51[] gstruct51_270, ref string string_27, ref string string_28)
		{
			int num = 0;
			string str = '\r'.ToString() + "\n";
			for (int i = 0; i < gstruct51_270.Length; i++)
			{
				bool flag = gstruct51_270[i].uint_0 == 0U;
				if (flag)
				{
					string_27 = string_27 + i.ToString() + "; ";
					num++;
				}
				bool flag2 = Form1.bool_1 && gstruct51_270[i].string_0 != null;
				if (flag2)
				{
					string[] array = gstruct51_270[i].string_0.Split(new char[]
					{
						'.'
					});
					array[0] = array[array.Length - 1];
					string text = "\t";
					bool flag3 = array[0].Length < 16;
					if (flag3)
					{
						text += text;
					}
					while (array[0].Length < 20)
					{
						string[] array2;
						(array2 = array)[0] = array2[0] + " ";
					}
					string str2 = string.Concat(new string[]
					{
						i.ToString(),
						". ",
						array[0],
						" ",
						text,
						"= ",
						Class12.smethod_45(gstruct51_270[i].uint_0, 8, false, false)
					});
					string_28 = string_28 + str2 + str;
				}
			}
			return num;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00081058 File Offset: 0x0007F258
		public static bool smethod_5(string string_27, string string_28 = null)
		{
			Class53.bool_0 = false;
			Class53.bool_1 = false;
			Class53.bool_1 = true;
			return Class53.bool_0;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00081084 File Offset: 0x0007F284
		public static string smethod_6(string string_27, bool bool_2, bool bool_3)
		{
			return string.Empty;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0008109C File Offset: 0x0007F29C
		public static void smethod_7()
		{
			Class53.string_25 = null;
			Class53.string_26 = null;
			Class53.bool_0 = false;
			Class53.bool_1 = false;
			string text = "RZhJst04DARDN+IEkFjo/tfqTOr9dtheiI+iMBSqil5VsU/19o48pz3L58pab68T+XtewfPM3++njXnevqLv3+9VPNfu4/f7PuOde/X8Pccabx/3/LZHz3VGvL2f2erpUZMNNd4aTz+7t1x75zsPb6yHQ9aMlpsT3Ji/lT5WvmP0ttrfSpusrLH7+VZW66O9ffedv3Nm1ci3x6zI+tu0znpHOxmZf0tju5REtn9LvR1SHDWI6pmnCHKeGS6xYf+WFqWxEJHnt1LrbMLki3+vFV/itR0r/lbypJ87q7VvKdqIsgN9zt/KDYCDKPdvpXrf7xpz7d9BcWqMN3J2K5kc2Dm707nxjFa54qyKl3iJbq7qI+kx5SgSrL+lsfZdWqc/SXlH0hIC5qe9fitzEx1ljKhvZfLn7qG+T182J0aut0y70Zxoey0xtnol0ZxpC3vdl7bxDkA0JrG/s7UTM59DeyvGAHu09hnsW7vRwzc6h+58EiRZWtF3PwVEKcdu+83RCOLhvBrbir4cHhtIdjKZ5wC1NwJkjJr8UsKgA69JEShcB/Ixx3F7Ucsx5gu0NuFQqdNqr5bG2k9yKFCdm7bt+HaBkt6icyqo/S1xNp+tZlvffqp6kMNsogqA593WbnkAEOHWe3F0kcbwvDVpznHJelJ2pox2k3cYEBBxoZpB1+wzVreX64Cs8whCoDZzvMynezongxb2sG7nKegZew6WdgMtD7nVmTsB2tn7GeA5mAfaT+v5fQ5+420K3s+ps4ff6eZE2Ezj04Ep6IjVQGZrLjRaUoTLaA4AX2Omx4LMZxB0jYtawEhxApI4SQnjTCpz0Ue9mDzgsDwtYaNyOFJ2oQ8NzhlvVtvBG3yTYeLDFqIA0HiOnQGid8ab5WOomMN+DwljojQUzT6tBcGMHgQ195lCr7uFdp5drU0yF9IJQqIxNrzx0MgFovYEQyUUoAg6S299Jg1qVswrOZMuh2WRP2/f5yVOTmaXBkHkmC2Bypr9Pb5KOTYD/69rFLs3+FmQhzwDfIiALeGUMLjkf0if9ADCJCf2Tcjx44INiU0YVm44HteIddohQNZuOSoaFLPuAm8wBQwtWHmH51HAojggmGquAVYcVh/JdbAPlkICwqmmNqA8si+iOcIFSmWIZM5hWYmczCgr7RcxMUGZT2TEZ9CqkNJS9MVJ4mCB0Wui0QkUngRMp8E2cz5OdItFJp2W8m8FsZEpHFY8IGCiI+/s2bUmzYIwJPEp8nbWqE1T0VCYcrqkSdkDLZtOFYiEIKG9J4w4oJfpdEPMskZKa+VMMQsMDx1Qm/iANAyh0GT58SrFQIwIjXfhhDaloQnbZnHQ5VnCYLgpG0xw31oeNKknZzF4oNsFGbQnZX5p41EGKhgkZJRWg+veCK4rufAlycNJuWCS+Z4rxpTB0aBTe90QlJ1hZhfGg9E6AA9qkumWbEtdyI7vAcM0jzTirxcI8i43A0r6gM1glGgmDStqhTdIYFiwz4BWf8WSizeAZ5vsQcDUGIzBSHdukDXY5vXjFAf2bkRPWzqsALJttMVKNDyBpOOO2GNLiEzEweAUeMm/orN2w5jcWdBYwHbEvLpTPfEu1IDt+gVYA5wW3iLeDfdAEHBh0ps3xSZ8SS9ozQvyZHGwmyk0hSrtr9HXkj5I3zHEExX6oNjiI640SLfMOxWUbK6HQInYpkEjA9gALqKJ+pwcP9+RdOicIaaJryw2zIc6UV9tnImABuKJH4fUlSFKCYX0lxY54UNDM24xmyiAJdrnJSgzFLPO7Ql1h5kOqRr4cvyhLnRYi3ieffG7YTpw+D1B93FrpAGABfc+zK+CT8PQG2tEpoyUTcT4MVOwyzAtRFBK0dmgK/2dwlDFUVjzPR8zU0SG+AgRLOAmIrVSRmyyq9K9EJnl61rDdd2HEQONRvrMxNmai2Y1pqTK9CIJwOMdN/SJNKZ+6qr2+URDZ4yZI32qdqgtfEMCaOqUSEEh6QGNV+3SqwY0RGgaI8vOOwoOHXbw+ZElPdUVAPopOyP1IKiMNjQD1JUN/TuDQSMsMIEH7Dpq3uZn2/Mu0iA+I+FlEnKY6TRFg4zO+ihhgyJiYQZTdF/xK/VSQOG/HN69mQRItDsyIYVgNm+B+xUUUM+UzrxiCMw20NUA0MT1QGQIhLZjSAs4W7QIGlHq9JRgWvNl7+5O6PJ+2dIw8aoyWto/hbcgYvgEMfGBpQAxtTY4KSJnArFA3NbXOBQOs5RyGgMnNzCn0ENqr+VzkKhNdjtd03R4yUBoKO8dZaKWnrbHb+aBHsBMkFcQuobQRtBc4oMlYVpA1a/FpbCS2dKLMM1To0ZSesfoVz7kaEidHjFCkJrtnOoTGd9B7M5haurBwVTzNCRaSRsKOBiukuwoD57AJS4I3dtDvbDJNW2oPZimJ6/XH3kU9eFUwMkpjPcFpxef4Wtk6d9Hy8QIBkAA+2o5AVAbAHxerBy5Ku8gM+iblxx5iu95MJ65rmKiNoxPau0bdK8RRpsEuszK7zkxBmbGMa6Urizv99lf3mpEkmCBTlsiB0IHYkbWLqdBe7nvBjBa3rXu7bPfG4JqqvuDylp4e4TgeZWITBRpYQYCjNBfbrngSlJlUmFPKjlYKbUVpxPe60CmlTal7VD6EvWg8NjdhcFo9zpFT0zx0g6Ow3pZP+Qes33coxHVuw448PR77OzX2oOA6IIGYlcWRpBnSXqv2uQUMcHQD+x6viFsqlVSmtC0uSTxAXQuDrNfgYGduJ03nYeMVfpUfGCd70YMjABKK+7eEBZ8pR7Ny4XejnU8zFIzg5zNYUxPHJZek0ZP4JWr0eF1XyH8PJsdU7d4bNdjIMTQ43WSXiD06EM80YXxqHo6hfSqo3lkaur+/4C6RiN7/H83V36wGlzEIvY/SM5hzSkO/tm7xcMhosAz0Qo1i+Dpnq6TlboOjEC9GJpHv72jp8rFubO3vAcOJjOW5lX7eGcLTqIyaiE2sUGTGOsH8nN2KCMydR0kjMr3P0by3uAzfIKBuJxPW1E03jqfhl+O4TgCiQ+mGkf/X8QBYI/XOUcTK6TjkbjkIEDadcYq87VgAF4LPBn8TxsIAq5moLiNw5T380wzxM83/wM=";
			string text2 = Class12.smethod_71(text);
			bool flag = text2 != null && !(text2 == string.Empty);
			if (flag)
			{
				string[] array = text2.Split(new char[]
				{
					'\u0001'
				});
				string[,] array2 = new string[array.Length, 2];
				for (int i = 0; i < array.Length; i++)
				{
					bool flag2 = array[i] != null && !(array[i] == string.Empty);
					if (flag2)
					{
						string[] array3 = array[i].Split(new char[]
						{
							'='
						});
						bool flag3 = array3.Length > 1;
						if (flag3)
						{
							array2[i, 0] = array3[0];
							array2[i, 1] = array3[1];
						}
					}
				}
				Class102.smethod_1(ref Class66.gstruct51_0, array2);
				Class102.smethod_1(ref Class66.gstruct51_16, array2);
				Class102.smethod_1(ref Class66.gstruct51_17, array2);
				Class102.smethod_1(ref Class66.gstruct51_18, array2);
				Class102.smethod_1(ref Class66.gstruct51_19, array2);
				Class102.smethod_1(ref Class66.gstruct51_20, array2);
				Class102.smethod_1(ref Class66.gstruct51_21, array2);
				Class102.smethod_1(ref Class66.gstruct51_22, array2);
				Class102.smethod_1(ref Class66.gstruct51_23, array2);
				Class102.smethod_1(ref Class66.gstruct51_24, array2);
				Class102.smethod_1(ref Class66.gstruct51_25, array2);
				Class102.smethod_1(ref Class66.gstruct51_26, array2);
				Class102.smethod_1(ref Class66.gstruct51_27, array2);
				Class102.smethod_1(ref Class66.gstruct51_28, array2);
				Class102.smethod_1(ref Class66.gstruct51_29, array2);
				Class102.smethod_1(ref Class66.gstruct51_30, array2);
				Class102.smethod_1(ref Class66.gstruct51_31, array2);
				Class102.smethod_1(ref Class53.gstruct51_6, array2);
				Class102.smethod_1(ref Class53.gstruct51_5, array2);
				Class102.smethod_1(ref Class53.gstruct51_7, array2);
				Class102.smethod_1(ref Class53.gstruct51_246, array2);
				Class102.smethod_1(ref Class53.gstruct51_245, array2);
				Class102.smethod_1(ref Class53.gstruct51_247, array2);
				Class102.smethod_1(ref Class53.gstruct51_248, array2);
				Class102.smethod_1(ref Class53.gstruct51_249, array2);
				Class102.smethod_1(ref Class53.gstruct51_243, array2);
				Class102.smethod_1(ref Class53.gstruct51_244, array2);
				Class102.smethod_1(ref Class53.gstruct51_1, array2);
				Class102.smethod_1(ref Class53.gstruct51_250, array2);
				Class102.smethod_1(ref Class53.gstruct51_262, array2);
				Class102.smethod_1(ref Class53.gstruct51_260, array2);
				Class102.smethod_1(ref Class53.gstruct51_259, array2);
				Class102.smethod_1(ref Class53.gstruct51_261, array2);
				Class102.smethod_1(ref Class53.gstruct51_242, array2);
				Class102.smethod_1(ref Class53.gstruct51_4, array2);
				Class102.smethod_1(ref Class53.gstruct51_2, array2);
				Class102.smethod_1(ref Class53.gstruct51_3, array2);
				Class102.smethod_1(ref Class53.gstruct51_251, array2);
				Class102.smethod_1(ref Class53.gstruct51_252, array2);
				Class102.smethod_1(ref Class53.gstruct51_253, array2);
				Class102.smethod_1(ref Class53.gstruct51_254, array2);
				Class102.smethod_1(ref Class53.gstruct51_255, array2);
				Class102.smethod_1(ref Class53.gstruct51_256, array2);
				Class102.smethod_1(ref Class53.gstruct51_258, array2);
				Class102.smethod_1(ref Class53.gstruct51_257, array2);
				Class102.smethod_1(ref Class53.gstruct51_11, array2);
				Class102.smethod_1(ref Class53.gstruct51_12, array2);
				Class102.smethod_1(ref Class53.gstruct51_13, array2);
				Class102.smethod_1(ref Class53.gstruct51_18, array2);
				Class102.smethod_1(ref Class53.gstruct51_19, array2);
				Class102.smethod_1(ref Class53.gstruct51_20, array2);
				Class102.smethod_1(ref Class53.gstruct51_21, array2);
				Class102.smethod_1(ref Class53.gstruct51_22, array2);
				Class102.smethod_1(ref Class53.gstruct51_9, array2);
				Class102.smethod_1(ref Class53.gstruct51_10, array2);
				Class102.smethod_1(ref Class53.gstruct51_14, array2);
				Class102.smethod_1(ref Class53.gstruct51_15, array2);
				Class102.smethod_1(ref Class53.gstruct51_16, array2);
				Class102.smethod_1(ref Class53.gstruct51_49, array2);
				Class102.smethod_1(ref Class53.gstruct51_17, array2);
				Class102.smethod_1(ref Class53.gstruct51_23, array2);
				Class102.smethod_1(ref Class53.gstruct51_24, array2);
				Class53.gstruct51_25.uint_0 = Class53.gstruct51_24.uint_0 + 8U;
				Class102.smethod_1(ref Class53.gstruct51_26, array2);
				Class102.smethod_1(ref Class53.gstruct51_27, array2);
				Class102.smethod_1(ref Class53.gstruct51_28, array2);
				Class102.smethod_1(ref Class53.gstruct51_29, array2);
				Class102.smethod_1(ref Class53.gstruct51_30, array2);
				Class102.smethod_1(ref Class53.gstruct51_31, array2);
				Class102.smethod_1(ref Class53.gstruct51_32, array2);
				Class102.smethod_1(ref Class53.gstruct51_33, array2);
				Class102.smethod_1(ref Class53.gstruct51_34, array2);
				Class102.smethod_1(ref Class53.gstruct51_35, array2);
				Class102.smethod_1(ref Class53.gstruct51_36, array2);
				Class102.smethod_1(ref Class53.gstruct51_37, array2);
				Class102.smethod_1(ref Class53.gstruct51_38, array2);
				Class102.smethod_1(ref Class53.gstruct51_39, array2);
				Class102.smethod_1(ref Class53.gstruct51_40, array2);
				Class102.smethod_1(ref Class53.gstruct51_41, array2);
				Class102.smethod_1(ref Class53.gstruct51_42, array2);
				Class102.smethod_1(ref Class53.gstruct51_43, array2);
				Class102.smethod_1(ref Class53.gstruct51_44, array2);
				Class102.smethod_1(ref Class53.gstruct51_45, array2);
				Class102.smethod_1(ref Class53.gstruct51_46, array2);
				Class102.smethod_1(ref Class53.gstruct51_47, array2);
				Class102.smethod_1(ref Class53.gstruct51_48, array2);
				Class102.smethod_1(ref Class53.gstruct51_50, array2);
				bool flag4 = Class53.gstruct51_50.uint_0 > 0U;
				if (flag4)
				{
					Class53.gstruct51_51.uint_0 = Class53.gstruct51_50.uint_0 + 4U;
					Class53.gstruct51_52.uint_0 = Class53.gstruct51_50.uint_0 + 8U;
					Class53.gstruct51_53.uint_0 = Class53.gstruct51_50.uint_0 + 12U;
				}
				Class102.smethod_1(ref Class53.gstruct51_54, array2);
				Class102.smethod_1(ref Class53.gstruct51_55, array2);
				Class102.smethod_1(ref Class53.gstruct51_56, array2);
				Class102.smethod_1(ref Class53.gstruct51_57, array2);
				Class102.smethod_1(ref Class53.gstruct51_58, array2);
				Class102.smethod_1(ref Class53.gstruct51_59, array2);
				Class102.smethod_1(ref Class53.gstruct51_60, array2);
				bool flag5 = Class53.gstruct51_60.uint_0 > 0U;
				if (flag5)
				{
					Class53.gstruct51_61.uint_0 = Class53.gstruct51_60.uint_0 - 8U;
					Class53.gstruct51_62.uint_0 = Class53.gstruct51_60.uint_0 - 12U;
					Class53.gstruct51_63.uint_0 = 152U;
					Class53.gstruct51_64.uint_0 = 184U;
					Class53.gstruct51_65.uint_0 = 88U;
				}
				Class102.smethod_1(ref Class53.gstruct51_66, array2);
				Class102.smethod_1(ref Class53.gstruct51_72, array2);
				Class102.smethod_1(ref Class53.gstruct51_73, array2);
				Class102.smethod_1(ref Class53.gstruct51_74, array2);
				Class102.smethod_1(ref Class53.gstruct51_75, array2);
				Class102.smethod_1(ref Class53.gstruct51_233, array2);
				Class102.smethod_1(ref Class53.gstruct51_76, array2);
				bool flag6 = Class53.gstruct51_76.uint_0 > 0U;
				if (flag6)
				{
					uint num = 8U;
					uint num2 = 32U;
					Class53.gstruct51_77.uint_0 = Class53.gstruct51_76.uint_0 + num;
					Class53.gstruct51_78.uint_0 = Class53.gstruct51_76.uint_0 + num2;
					Class53.gstruct51_79.uint_0 = Class53.gstruct51_76.uint_0 + num + 4U;
					Class53.gstruct51_80.uint_0 = Class53.gstruct51_76.uint_0 + num2 + 4U;
					Class53.gstruct51_81.uint_0 = Class53.gstruct51_76.uint_0 + num + 8U;
					Class53.gstruct51_82.uint_0 = Class53.gstruct51_76.uint_0 + num2 + 8U;
					Class53.gstruct51_83.uint_0 = Class53.gstruct51_76.uint_0 + num + 12U;
					Class53.gstruct51_84.uint_0 = Class53.gstruct51_76.uint_0 + num2 + 12U;
				}
				Class102.smethod_1(ref Class53.gstruct51_90, array2);
				Class102.smethod_1(ref Class53.gstruct51_91, array2);
				Class102.smethod_1(ref Class53.gstruct51_92, array2);
				Class102.smethod_1(ref Class53.gstruct51_93, array2);
				Class102.smethod_1(ref Class53.gstruct51_94, array2);
				Class102.smethod_1(ref Class53.gstruct51_95, array2);
				Class102.smethod_1(ref Class53.gstruct51_96, array2);
				Class102.smethod_1(ref Class53.gstruct51_234, array2);
				Class102.smethod_1(ref Class53.gstruct51_235, array2);
				Class102.smethod_1(ref Class53.gstruct51_97, array2);
				Class102.smethod_1(ref Class53.gstruct51_98, array2);
				Class102.smethod_1(ref Class53.gstruct51_99, array2);
				Class102.smethod_1(ref Class53.gstruct51_100, array2);
				Class102.smethod_1(ref Class53.gstruct51_101, array2);
				Class102.smethod_1(ref Class53.gstruct51_102, array2);
				Class102.smethod_1(ref Class53.gstruct51_105, array2);
				Class102.smethod_1(ref Class53.gstruct51_106, array2);
				Class102.smethod_1(ref Class53.gstruct51_107, array2);
				Class102.smethod_1(ref Class53.gstruct51_108, array2);
				Class102.smethod_1(ref Class53.gstruct51_109, array2);
				Class102.smethod_1(ref Class53.gstruct51_111, array2);
				Class102.smethod_1(ref Class53.gstruct51_112, array2);
				Class102.smethod_1(ref Class53.gstruct51_110, array2);
				Class102.smethod_1(ref Class53.gstruct51_113, array2);
				Class102.smethod_1(ref Class53.gstruct51_114, array2);
				Class102.smethod_1(ref Class53.gstruct51_115, array2);
				Class102.smethod_1(ref Class53.gstruct51_116, array2);
				Class102.smethod_1(ref Class53.gstruct51_118, array2);
				Class102.smethod_1(ref Class53.gstruct51_117, array2);
				Class102.smethod_1(ref Class53.gstruct51_119, array2);
				Class102.smethod_1(ref Class53.gstruct51_120, array2);
				Class102.smethod_1(ref Class53.gstruct51_121, array2);
				Class102.smethod_1(ref Class53.gstruct51_122, array2);
				Class102.smethod_1(ref Class53.gstruct51_123, array2);
				Class102.smethod_1(ref Class53.gstruct51_103, array2);
				Class102.smethod_1(ref Class53.gstruct51_104, array2);
				Class102.smethod_1(ref Class53.gstruct51_124, array2);
				Class102.smethod_1(ref Class53.gstruct51_125, array2);
				Class102.smethod_1(ref Class53.gstruct51_126, array2);
				Class102.smethod_1(ref Class53.gstruct51_127, array2);
				Class102.smethod_1(ref Class53.gstruct51_128, array2);
				Class102.smethod_1(ref Class53.gstruct51_129, array2);
				Class102.smethod_1(ref Class53.gstruct51_130, array2);
				Class102.smethod_1(ref Class53.gstruct51_131, array2);
				Class102.smethod_1(ref Class53.gstruct51_132, array2);
				Class102.smethod_1(ref Class53.gstruct51_133, array2);
				Class102.smethod_1(ref Class53.gstruct51_134, array2);
				Class102.smethod_1(ref Class53.gstruct51_135, array2);
				Class102.smethod_1(ref Class53.gstruct51_136, array2);
				Class102.smethod_1(ref Class53.gstruct51_137, array2);
				Class102.smethod_1(ref Class53.gstruct51_138, array2);
				Class102.smethod_1(ref Class53.gstruct51_139, array2);
				Class102.smethod_1(ref Class53.gstruct51_140, array2);
				Class102.smethod_1(ref Class53.gstruct51_141, array2);
				Class102.smethod_1(ref Class53.gstruct51_142, array2);
				Class102.smethod_1(ref Class53.gstruct51_143, array2);
				Class102.smethod_1(ref Class53.gstruct51_145, array2);
				Class102.smethod_1(ref Class53.gstruct51_144, array2);
				Class102.smethod_1(ref Class53.gstruct51_146, array2);
				Class102.smethod_1(ref Class53.gstruct51_147, array2);
				Class102.smethod_1(ref Class53.gstruct51_148, array2);
				Class102.smethod_1(ref Class53.gstruct51_149, array2);
				Class102.smethod_1(ref Class53.gstruct51_150, array2);
				Class102.smethod_1(ref Class53.gstruct51_151, array2);
				Class102.smethod_1(ref Class53.gstruct51_153, array2);
				Class102.smethod_1(ref Class53.gstruct51_155, array2);
				Class102.smethod_1(ref Class53.gstruct51_154, array2);
				Class102.smethod_1(ref Class53.gstruct51_152, array2);
				Class102.smethod_1(ref Class53.gstruct51_156, array2);
				Class102.smethod_1(ref Class53.gstruct51_157, array2);
				Class102.smethod_1(ref Class53.gstruct51_158, array2);
				Class102.smethod_1(ref Class53.gstruct51_159, array2);
				Class102.smethod_1(ref Class53.gstruct51_263, array2);
				Class102.smethod_1(ref Class53.gstruct51_160, array2);
				Class102.smethod_1(ref Class53.gstruct51_68, array2);
				Class102.smethod_1(ref Class53.gstruct51_71, array2);
				Class102.smethod_1(ref Class53.gstruct51_70, array2);
				Class102.smethod_1(ref Class53.gstruct51_67, array2);
				Class102.smethod_1(ref Class53.gstruct51_69, array2);
				Class102.smethod_1(ref Class53.gstruct51_161, array2);
				Class102.smethod_1(ref Class53.gstruct51_163, array2);
				Class102.smethod_1(ref Class53.gstruct51_162, array2);
				Class102.smethod_1(ref Class53.gstruct51_164, array2);
				Class102.smethod_1(ref Class53.gstruct51_165, array2);
				Class102.smethod_1(ref Class53.gstruct51_166, array2);
				Class102.smethod_1(ref Class53.gstruct51_167, array2);
				Class102.smethod_1(ref Class53.gstruct51_168, array2);
				Class102.smethod_1(ref Class53.gstruct51_169, array2);
				Class102.smethod_1(ref Class53.gstruct51_171, array2);
				Class102.smethod_1(ref Class53.gstruct51_172, array2);
				Class102.smethod_1(ref Class53.gstruct51_173, array2);
				Class102.smethod_1(ref Class53.gstruct51_174, array2);
				Class102.smethod_1(ref Class53.gstruct51_175, array2);
				Class102.smethod_1(ref Class53.gstruct51_176, array2);
				Class102.smethod_1(ref Class53.gstruct51_178, array2);
				Class102.smethod_1(ref Class53.gstruct51_179, array2);
				Class102.smethod_1(ref Class53.gstruct51_180, array2);
				Class102.smethod_1(ref Class53.gstruct51_181, array2);
				Class102.smethod_1(ref Class53.gstruct51_182, array2);
				Class102.smethod_1(ref Class53.gstruct51_183, array2);
				Class102.smethod_1(ref Class53.gstruct51_184, array2);
				Class102.smethod_1(ref Class53.gstruct51_185, array2);
				Class102.smethod_1(ref Class53.gstruct51_186, array2);
				Class102.smethod_1(ref Class53.gstruct51_187, array2);
				Class102.smethod_1(ref Class53.gstruct51_177, array2);
				Class102.smethod_1(ref Class53.gstruct51_232, array2);
				Class102.smethod_1(ref Class53.gstruct51_236, array2);
				Class102.smethod_1(ref Class53.gstruct51_237, array2);
				Class102.smethod_1(ref Class53.gstruct51_238, array2);
				Class102.smethod_1(ref Class53.gstruct51_86, array2);
				Class102.smethod_1(ref Class53.gstruct51_87, array2);
				Class102.smethod_1(ref Class53.gstruct51_188, array2);
				Class102.smethod_1(ref Class53.gstruct51_89, array2);
				Class102.smethod_1(ref Class53.gstruct51_189, array2);
				Class102.smethod_1(ref Class53.gstruct51_88, array2);
				Class102.smethod_1(ref Class53.gstruct51_190, array2);
				Class102.smethod_1(ref Class53.gstruct51_191, array2);
				Class102.smethod_1(ref Class53.gstruct51_192, array2);
				Class102.smethod_1(ref Class53.gstruct51_196, array2);
				Class102.smethod_1(ref Class53.gstruct51_193, array2);
				Class102.smethod_1(ref Class53.gstruct51_194, array2);
				Class102.smethod_1(ref Class53.gstruct51_195, array2);
				Class102.smethod_1(ref Class53.gstruct51_197, array2);
				Class102.smethod_1(ref Class53.gstruct51_201, array2);
				Class102.smethod_1(ref Class53.gstruct51_202, array2);
				Class102.smethod_1(ref Class53.gstruct51_203, array2);
				Class102.smethod_1(ref Class53.gstruct51_204, array2);
				Class102.smethod_1(ref Class53.gstruct51_205, array2);
				Class102.smethod_1(ref Class53.gstruct51_206, array2);
				Class102.smethod_1(ref Class53.gstruct51_220, array2);
				Class102.smethod_1(ref Class53.gstruct51_226, array2);
				Class102.smethod_1(ref Class53.gstruct51_227, array2);
				Class102.smethod_1(ref Class53.gstruct51_228, array2);
				Class102.smethod_1(ref Class53.gstruct51_229, array2);
				Class102.smethod_1(ref Class53.gstruct51_231, array2);
				Class102.smethod_1(ref Class53.gstruct51_230, array2);
				Class102.smethod_1(ref Class53.gstruct51_207, array2);
				Class102.smethod_1(ref Class53.gstruct51_208, array2);
				Class102.smethod_1(ref Class53.gstruct51_209, array2);
				Class102.smethod_1(ref Class53.gstruct51_210, array2);
				Class102.smethod_1(ref Class53.gstruct51_211, array2);
				Class102.smethod_1(ref Class53.gstruct51_212, array2);
				Class102.smethod_1(ref Class53.gstruct51_213, array2);
				Class102.smethod_1(ref Class53.gstruct51_214, array2);
				Class102.smethod_1(ref Class53.gstruct51_215, array2);
				Class102.smethod_1(ref Class53.gstruct51_216, array2);
				Class102.smethod_1(ref Class53.gstruct51_225, array2);
				Class102.smethod_1(ref Class53.gstruct51_224, array2);
				Class102.smethod_1(ref Class53.gstruct51_221, array2);
				Class102.smethod_1(ref Class53.gstruct51_217, array2);
				Class102.smethod_1(ref Class53.gstruct51_218, array2);
				Class102.smethod_1(ref Class53.gstruct51_219, array2);
				Class102.smethod_1(ref Class53.gstruct51_222, array2);
				Class102.smethod_1(ref Class53.gstruct51_223, array2);
				Class102.smethod_1(ref Class53.gstruct51_239, array2);
				Class102.smethod_1(ref Class53.gstruct51_240, array2);
				Class102.smethod_1(ref Class53.gstruct51_241, array2);
				Class102.smethod_1(ref Class53.gstruct51_264, array2);
				Class102.smethod_1(ref Class53.gstruct51_265, array2);
				Class102.smethod_1(ref Class53.gstruct51_266, array2);
				Class102.smethod_1(ref Class53.gstruct51_267, array2);
				Class102.smethod_1(ref Class53.gstruct51_268, array2);
				GStruct51[] gstruct51_ = Class53.smethod_2();
				Class53.bool_0 = (Class53.smethod_4(gstruct51_, ref Class53.string_25, ref Class53.string_26) == 0);
				Class53.uint_0 = null;
				bool flag7 = Class53.bool_0;
				if (flag7)
				{
					Class53.uint_0 = Class53.smethod_3();
				}
				Class53.bool_1 = true;
			}
			else
			{
				Class53.bool_0 = false;
				Class53.bool_1 = true;
				Class53.string_25 = "0";
				Class53.string_26 = "Chưa có dữ liệu data game.";
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000820F8 File Offset: 0x000802F8
		public static GStruct49 smethod_8(int int_11)
		{
			GStruct49 gstruct = default(GStruct49);
			gstruct.int_136 = 0;
			gstruct.uint_16 = 0U;
			gstruct.uint_17 = 0U;
			gstruct.gstruct42_0 = null;
			gstruct.bool_25 = false;
			bool flag = !Class53.bool_1 || !Class53.bool_0;
			GStruct49 result;
			if (flag)
			{
				result = gstruct;
			}
			else
			{
				try
				{
					gstruct.process_0 = Process.GetProcessById(int_11);
					gstruct.uint_7 = (uint)((int)gstruct.process_0.MainModule.BaseAddress);
					uint[] array = Class22.smethod_61(int_11, "engine.dll|lualibdll.dll|rainbow.dll|msvcr80.dll");
					gstruct.uint_8 = array[0];
					gstruct.uint_9 = array[1];
					gstruct.uint_10 = array[2];
					gstruct.uint_11 = array[3];
				}
				catch
				{
					Class12.smethod_29(ref Class12.string_16, "Khởi tạo game thất bại.");
					return gstruct;
				}
				gstruct.int_137 = Class22.OpenProcess(2035711, false, int_11);
				gstruct.string_22 = Class36.smethod_5(gstruct);
				gstruct.string_20 = Class26.smethod_10(gstruct);
				gstruct.string_21 = Class26.smethod_7(gstruct);
				gstruct.int_97 = 500;
				gstruct.uint_5 = Class22.smethod_63(int_11, Class53.string_21);
				bool flag2 = gstruct.uint_5 != null && gstruct.uint_5.Length != 0;
				if (flag2)
				{
					gstruct.uint_4 = gstruct.uint_5[0];
				}
				else
				{
					GStruct8[] array2 = Class22.smethod_62(int_11, "WIN_CLASS:" + Class53.string_21, 0);
					bool flag3 = array2 != null && array2.Length != 0;
					if (flag3)
					{
						gstruct.uint_4 = array2[0].uint_0;
					}
				}
				uint num = 3164U;
				bool flag4 = num < Class53.gstruct51_143.uint_0;
				if (flag4)
				{
					num = Class53.gstruct51_143.uint_0;
				}
				gstruct.uint_17 = 0U;
				gstruct.uint_16 = Class22.smethod_1(gstruct.int_137, Class70.uint_0 + num + 4096U, GEnum1.flag_2);
				bool flag5 = gstruct.uint_16 == 0U;
				if (flag5)
				{
					result = gstruct;
				}
				else
				{
					gstruct.uint_21 = 0U;
					gstruct.uint_20 = Class22.smethod_1(gstruct.int_137, 12288U, GEnum1.flag_2);
					bool flag6 = gstruct.uint_20 > 0U;
					if (flag6)
					{
						gstruct.uint_15 = Class22.smethod_1(gstruct.int_137, 4096U, GEnum1.flag_2);
						gstruct.uint_14 = Class22.smethod_1(gstruct.int_137, 512U, GEnum1.flag_2);
						gstruct.uint_18 = Class22.smethod_1(gstruct.int_137, 256U, GEnum1.flag_2);
						gstruct.int_136 = int_11 * (int)Convert.ToByte(gstruct.uint_7 != 0U && gstruct.uint_16 != 0U && gstruct.uint_4 > 0U);
						bool flag7 = gstruct.int_136 == 0;
						if (flag7)
						{
							result = gstruct;
						}
						else
						{
							gstruct.uint_19 = Class22.smethod_1(gstruct.int_137, 4096U, GEnum1.flag_2);
							Class70.smethod_8(ref gstruct);
							Class53.smethod_9(ref gstruct, null);
							Class76.long_0 = 0L;
							result = gstruct;
						}
					}
					else
					{
						result = gstruct;
					}
				}
			}
			return result;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00082404 File Offset: 0x00080604
		public static void smethod_9(ref GStruct49 gstruct49_0, string string_27 = null)
		{
			bool flag = false;
			for (;;)
			{
				try
				{
					Class53.smethod_10(ref gstruct49_0, string_27, flag);
					break;
				}
				catch
				{
					bool flag2 = !flag;
					if (!flag2)
					{
						break;
					}
					flag = true;
				}
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00082448 File Offset: 0x00080648
		private static void smethod_10(ref GStruct49 gstruct49_0, string string_27 = null, bool bool_2 = false)
		{
			bool flag = string_27 == null || string_27 == string.Empty;
			if (flag)
			{
				string_27 = Class53.string_10 + "\\" + Class12.smethod_44(gstruct49_0.string_22) + ".cfg";
			}
			string[] array = null;
			if (bool_2)
			{
				Class12.smethod_20(string_27);
			}
			else
			{
				string text = Class12.smethod_33(string_27, 0, 0, 3);
				bool flag2 = text != null && text != string.Empty;
				if (flag2)
				{
					array = text.Split(new char[]
					{
						'|'
					});
				}
			}
			gstruct49_0.bool_22 = false;
			bool flag3 = Class53.string_6 != null;
			if (flag3)
			{
				for (int i = 0; i < Class53.string_6.Length; i++)
				{
					bool flag4 = gstruct49_0.string_22 == Class53.string_6[i];
					if (flag4)
					{
						gstruct49_0.bool_22 = true;
						break;
					}
				}
			}
			string[] array2 = Class53.smethod_21(array, "AscBomThuoc", null, false);
			bool flag5 = array2 != null && array2.Length != 0;
			if (flag5)
			{
				array2[0] = Class12.smethod_15(array2[0]);
				bool flag6 = array2[0] != string.Empty && array2[0] != null;
				if (flag6)
				{
					string[] array3 = array2[0].Split(new char[]
					{
						'|'
					});
					gstruct49_0.gstruct42_0 = new GStruct42[array3.Length];
					for (int j = 0; j < array3.Length; j++)
					{
						string[] array4 = array3[j].Split(new char[]
						{
							':'
						});
						gstruct49_0.gstruct42_0[j].int_0 = Class12.smethod_11(array4[0]);
						string[] array5 = array4[1].Split(new char[]
						{
							'/'
						});
						gstruct49_0.gstruct42_0[j].gstruct41_0 = new GStruct41[array5.Length];
						for (int k = 0; k < array5.Length; k++)
						{
							string[] array6 = array5[k].Split(new char[]
							{
								'='
							});
							gstruct49_0.gstruct42_0[j].gstruct41_0[k].int_0 = Class12.smethod_11(array6[0]);
							gstruct49_0.gstruct42_0[j].gstruct41_0[k].string_0 = array6[1];
						}
					}
				}
			}
			gstruct49_0.string_15 = string.Empty;
			string[] array7 = Class53.smethod_21(array, "PassRuong", null, false);
			bool flag7 = array7 != null && array7.Length != 0;
			if (flag7)
			{
				gstruct49_0.string_15 = Class12.smethod_15(array7[0]);
			}
			string[] string_28 = array;
			int[] array8 = new int[1];
			gstruct49_0.int_37 = Class53.smethod_19(string_28, "flagXepdo", array8)[0];
			gstruct49_0.int_38 = Class53.smethod_19(array, "TimerXepdo", new int[]
			{
				15000
			})[0];
			string[] string_29 = array;
			array8 = new int[1];
			gstruct49_0.int_39 = Class53.smethod_19(string_29, "flagNhatTrongthanh", array8)[0];
			string[] string_30 = array;
			array8 = new int[1];
			gstruct49_0.int_40 = Class53.smethod_19(string_30, "flagNhatTheoThuoctinh", array8)[0];
			string[] string_31 = array;
			array8 = new int[1];
			gstruct49_0.int_41 = Class53.smethod_19(string_31, "flagThoahetThuoctinh", array8)[0];
			gstruct49_0.int_42 = Class53.smethod_19(array, "flagKhongNhatdoTim", new int[]
			{
				1
			})[0];
			string[] string_32 = array;
			array8 = new int[2];
			gstruct49_0.int_43 = Class53.smethod_19(string_32, "GiuNhan", array8);
			string[] string_33 = array;
			array8 = new int[2];
			gstruct49_0.int_44 = Class53.smethod_19(string_33, "GiuDC", array8);
			string[] string_34 = array;
			array8 = new int[2];
			gstruct49_0.int_45 = Class53.smethod_19(string_34, "GiuNB", array8);
			gstruct49_0.int_51 = Class53.smethod_19(array, "flagPhamviNhatdo", new int[]
			{
				1
			})[0];
			gstruct49_0.int_52 = Class53.smethod_19(array, "PhamviNhatdo", new int[]
			{
				600
			})[0];
			string[] string_35 = array;
			string string_36 = "RuongCatdo";
			int[] array9 = new int[5];
			array9[0] = 1;
			gstruct49_0.int_53 = Class53.smethod_19(string_35, string_36, array9);
			gstruct49_0.string_5 = null;
			string[] array10 = Class53.smethod_21(array, "tbKeepItem", null, false);
			bool flag8 = array10 != null && array10.Length != 0;
			if (flag8)
			{
				array10[0] = Class12.smethod_15(array10[0]);
				bool flag9 = array10[0] != string.Empty && array10[0] != null;
				if (flag9)
				{
					gstruct49_0.string_5 = array10[0].Split(new char[]
					{
						'|'
					});
				}
			}
			gstruct49_0.int_2 = 0;
			string[] string_37 = array;
			array8 = new int[1];
			gstruct49_0.int_54 = Class53.smethod_19(string_37, "Luomrac", array8)[0];
			string[] string_38 = array;
			array8 = new int[1];
			gstruct49_0.int_55 = Class53.smethod_19(string_38, "LuomracAccept", array8)[0];
			string[] string_39 = array;
			array8 = new int[1];
			gstruct49_0.int_56 = Class53.smethod_19(string_39, "LuomracThuoctinh", array8)[0];
			string[] string_40 = array;
			array8 = new int[2];
			gstruct49_0.int_46 = Class53.smethod_19(string_40, "flagVeBando", array8);
			gstruct49_0.int_47 = Class53.smethod_19(array, "GiudoTheoCap", new int[]
			{
				0,
				9
			});
			string[] string_41 = array;
			array8 = new int[2];
			gstruct49_0.int_48 = Class53.smethod_19(string_41, "GiudoTheoHe", array8);
			string[] string_42 = array;
			array8 = new int[1];
			gstruct49_0.int_49 = Class53.smethod_19(string_42, "GiudoTim", array8)[0];
			string[] string_43 = array;
			array8 = new int[1];
			gstruct49_0.int_50 = Class53.smethod_19(string_43, "GiudoTheoThuoctinh", array8)[0];
			gstruct49_0.gstruct37_0 = Class53.smethod_1();
			int[] array11 = Class53.smethod_19(array, "tbFlagItemMagic", null);
			int[] array12 = Class53.smethod_19(array, "tbValueItemMagic", null);
			int[] array13 = Class53.smethod_19(array, "tbValueDong", null);
			bool flag10 = array11 != null && array11.Length == gstruct49_0.gstruct37_0.Length && array12 != null && array12.Length == gstruct49_0.gstruct37_0.Length;
			if (flag10)
			{
				for (int l = 0; l < gstruct49_0.gstruct37_0.Length; l++)
				{
					gstruct49_0.gstruct37_0[l].int_0 = array11[l];
					gstruct49_0.gstruct37_0[l].int_2 = array12[l];
				}
			}
			bool flag11 = array13 != null && array13.Length == gstruct49_0.gstruct37_0.Length;
			if (flag11)
			{
				for (int m = 0; m < gstruct49_0.gstruct37_0.Length; m++)
				{
					gstruct49_0.gstruct37_0[m].int_3 = array13[m];
				}
			}
			gstruct49_0.int_18 = Class53.smethod_19(array, "SinhlucThoat", new int[]
			{
				200
			})[0];
			string[] string_44 = array;
			array8 = new int[1];
			gstruct49_0.int_19 = Class53.smethod_19(string_44, "flagSinhlucThoat", array8)[0];
			string[] string_45 = array;
			array8 = new int[2];
			gstruct49_0.int_60 = Class53.smethod_19(string_45, "TDPKhiHetruong", array8);
			gstruct49_0.int_57 = Class53.smethod_19(array, "flagTranhBossvang", new int[]
			{
				1
			})[0];
			string[] string_46 = array;
			array8 = new int[1];
			gstruct49_0.int_58 = Class53.smethod_19(string_46, "AnTTL", array8)[0];
			gstruct49_0.int_59 = Class53.smethod_19(array, "TDPKhiSaiMap", new int[]
			{
				1
			})[0];
			gstruct49_0.int_61 = Class53.smethod_19(array, "flagNhatdos", new int[]
			{
				1
			})[0];
			string[] string_47 = array;
			array8 = new int[1];
			gstruct49_0.int_62 = Class53.smethod_19(string_47, "flagNhatdoIndex", array8)[0];
			string[] string_48 = array;
			array8 = new int[1];
			gstruct49_0.int_63 = Class53.smethod_19(string_48, "flagCanThuocLag", array8)[0];
			gstruct49_0.int_64 = Class53.smethod_19(array, "fThuocTocdo", new int[]
			{
				0,
				0,
				3
			});
			gstruct49_0.string_7 = null;
			gstruct49_0.string_8 = null;
			string[] array14 = Class53.smethod_21(array, "ThuocTocdoDanh", null, false);
			bool flag12 = array14 != null && array14.Length != 0;
			if (flag12)
			{
				array14[0] = Class12.smethod_15(array14[0]);
				bool flag13 = array14[0] != string.Empty && array14[0] != null;
				if (flag13)
				{
					gstruct49_0.string_7 = array14[0].Split(new char[]
					{
						'|'
					});
				}
			}
			array14 = Class53.smethod_21(array, "ThuocTocdoThuong", null, false);
			bool flag14 = array14 != null && array14.Length != 0;
			if (flag14)
			{
				array14[0] = Class12.smethod_15(array14[0]);
				bool flag15 = array14[0] != string.Empty && array14[0] != null;
				if (flag15)
				{
					gstruct49_0.string_8 = array14[0].Split(new char[]
					{
						'|'
					});
				}
			}
			gstruct49_0.string_6 = null;
			array14 = Class53.smethod_21(array, "tbThuocLag", null, false);
			bool flag16 = array14 != null && array14.Length != 0;
			if (flag16)
			{
				array14[0] = Class12.smethod_15(array14[0]);
				bool flag17 = array14[0] != string.Empty && array14[0] != null;
				if (flag17)
				{
					gstruct49_0.string_6 = array14[0].Split(new char[]
					{
						'|'
					});
				}
			}
			bool flag18 = gstruct49_0.string_6 == null;
			if (flag18)
			{
				string text2 = "L«i Phßng hoµn|Tr­êng MÖnh hoµn|Gia Bµo hoµn|Cao Trung hoµn|§éc Phßng hoµn|Cao ThiÓm hoµn|Háa Phßng hoµn|Gia Bµo hoµn|B¨ng Phßng hoµn|Háa Phßng hoµn|B¸ch Qu¶ Lé|Thiªn s¬n  B¶o Lé|Thiªn s¬n B¶o Lé";
				gstruct49_0.string_6 = text2.Split(new char[]
				{
					'|'
				});
			}
			gstruct49_0.string_4 = null;
			array14 = Class53.smethod_21(array, "IBadlist", null, false);
			bool flag19 = array14 != null && array14.Length != 0;
			if (flag19)
			{
				array14[0] = Class12.smethod_15(array14[0]);
				bool flag20 = array14[0] != string.Empty && array14[0] != null;
				if (flag20)
				{
					gstruct49_0.string_4 = array14[0].Split(new char[]
					{
						'|'
					});
				}
			}
			bool flag21 = gstruct49_0.string_4 == null;
			if (flag21)
			{
				gstruct49_0.string_4 = new string[]
				{
					"Th­ëng",
					"Ph¹t",
					"ThÇn bÝ ®å chÝ",
					"§Æc Th¸m B¶o R­¬ng"
				};
			}
			gstruct49_0.int_67 = Class53.smethod_19(array, "TienGuiBho", new int[]
			{
				0,
				15,
				100000
			});
			gstruct49_0.int_65 = Class53.smethod_19(array, "flagTienMangtheo", new int[]
			{
				1
			})[0];
			gstruct49_0.int_66 = Class53.smethod_19(array, "TienMangtheo", new int[]
			{
				15000
			})[0];
			string[] string_49 = array;
			string string_50 = "TheoSau";
			int[] array15 = new int[3];
			array15[1] = 200;
			gstruct49_0.int_68 = Class53.smethod_19(string_49, string_50, array15);
			gstruct49_0.string_9 = string.Empty;
			array14 = Class53.smethod_21(array, "NameTheoSau", null, false);
			bool flag22 = array14 != null && array14.Length != 0;
			if (flag22)
			{
				gstruct49_0.string_9 = Class12.smethod_15(array14[0]);
			}
			string[] string_51 = array;
			array8 = new int[2];
			gstruct49_0.int_138 = Class53.smethod_19(string_51, "GanChieuTrai", array8);
			string[] string_52 = array;
			array8 = new int[2];
			gstruct49_0.int_139 = Class53.smethod_19(string_52, "GanChieuPhai", array8);
			gstruct49_0.int_140 = Class53.smethod_19(array, "Tran1Phai", new int[]
			{
				0,
				10000,
				90000
			});
			gstruct49_0.int_141 = Class53.smethod_19(array, "Tran2Phai", new int[]
			{
				0,
				10000,
				80000
			});
			gstruct49_0.int_142 = Class53.smethod_19(array, "Tran3Phai", new int[]
			{
				0,
				10000,
				70000
			});
			bool flag23 = gstruct49_0.int_140[1] == 10000 || gstruct49_0.int_141[1] == 10000 || gstruct49_0.int_142[1] == 10000;
			if (flag23)
			{
				gstruct49_0.int_140[1] = 0;
				gstruct49_0.int_141[1] = 0;
				gstruct49_0.int_142[1] = 0;
				int[] array16 = Class77.smethod_2(gstruct49_0);
				bool flag24 = array16 != null;
				if (flag24)
				{
					bool flag25 = array16.Length != 0;
					if (flag25)
					{
						gstruct49_0.int_140[0] = (int)Convert.ToByte(Class77.smethod_16(gstruct49_0, array16[0]) > 0);
						gstruct49_0.int_140[1] = array16[0];
					}
					bool flag26 = array16.Length > 1;
					if (flag26)
					{
						gstruct49_0.int_141[0] = (int)Convert.ToByte(Class77.smethod_16(gstruct49_0, array16[1]) > 0);
						gstruct49_0.int_141[1] = array16[1];
					}
					bool flag27 = array16.Length > 2;
					if (flag27)
					{
						gstruct49_0.int_142[0] = (int)Convert.ToByte(Class77.smethod_16(gstruct49_0, array16[2]) > 0);
						gstruct49_0.int_142[1] = array16[2];
					}
				}
			}
			int num = Class77.smethod_13(gstruct49_0);
			int num2 = Class77.smethod_14(gstruct49_0);
			string[] string_53 = array;
			array8 = new int[]
			{
				0,
				0,
				600,
				0,
				0,
				0,
				600,
				0,
				0,
				0,
				600,
				0
			};
			array8[1] = num;
			array8[5] = num;
			array8[9] = num;
			int[] array17 = Class53.smethod_19(string_53, "tbChuyenTR", array8);
			gstruct49_0.gstruct46_0 = new GStruct46[]
			{
				new GStruct46
				{
					int_0 = array17[0],
					int_1 = array17[1],
					int_2 = array17[2],
					int_3 = array17[3]
				},
				new GStruct46
				{
					int_0 = array17[4],
					int_1 = array17[5],
					int_2 = array17[6],
					int_3 = array17[7]
				},
				new GStruct46
				{
					int_0 = array17[8],
					int_1 = array17[9],
					int_2 = array17[10],
					int_3 = array17[11]
				}
			};
			string[] string_54 = array;
			array8 = new int[]
			{
				0,
				0,
				600,
				0,
				0,
				0,
				600,
				0,
				0,
				0,
				600,
				0
			};
			array8[1] = num2;
			array8[5] = num2;
			array8[9] = num2;
			int[] array18 = Class53.smethod_19(string_54, "tbChuyenPH", array8);
			gstruct49_0.gstruct46_1 = new GStruct46[]
			{
				new GStruct46
				{
					int_0 = array18[0],
					int_1 = array18[1],
					int_2 = array18[2],
					int_3 = array18[3]
				},
				new GStruct46
				{
					int_0 = array18[4],
					int_1 = array18[5],
					int_2 = array18[6],
					int_3 = array18[7]
				},
				new GStruct46
				{
					int_0 = array18[8],
					int_1 = array18[9],
					int_2 = array18[10],
					int_3 = array18[11]
				}
			};
			int[] array19 = Class53.smethod_19(array, "GapBossChieu", new int[]
			{
				0,
				num,
				1,
				100
			});
			gstruct49_0.gstruct46_2 = new GStruct46
			{
				int_0 = array19[0],
				int_1 = array19[1],
				int_3 = array19[2],
				int_2 = array19[3]
			};
			gstruct49_0.string_10 = "null";
			string[] array20 = Class53.smethod_21(array, "tRaovat", null, false);
			bool flag28 = array20 != null && array20.Length != 0;
			if (flag28)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag29 = array20[0] != string.Empty && array20[0] != null;
				if (flag29)
				{
					gstruct49_0.string_10 = array20[0];
				}
			}
			gstruct49_0.int_69 = Class53.smethod_19(array, "fRao", new int[]
			{
				0,
				0,
				30000,
				0,
				1
			});
			gstruct49_0.gstruct47_0.string_0 = Class53.string_22;
			array20 = Class53.smethod_21(array, "NhatQuaName", null, false);
			bool flag30 = array20 != null && array20.Length != 0;
			if (flag30)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag31 = array20[0] != string.Empty && array20[0] != null;
				if (flag31)
				{
					gstruct49_0.gstruct47_0.string_0 = array20[0];
				}
			}
			int[] array21 = Class53.smethod_19(array, "tbNhatQua", new int[]
			{
				0,
				0,
				12,
				5,
				1,
				150,
				0,
				20000,
				1
			});
			gstruct49_0.gstruct47_0.int_0 = 0;
			gstruct49_0.gstruct47_0.int_2 = array21[1];
			gstruct49_0.gstruct47_0.int_3 = array21[2];
			gstruct49_0.gstruct47_0.int_4 = array21[3];
			gstruct49_0.gstruct47_0.int_5 = array21[4];
			gstruct49_0.gstruct47_0.int_1 = array21[5];
			gstruct49_0.gstruct47_0.int_6 = array21[6];
			gstruct49_0.gstruct47_0.int_7 = array21[7];
			gstruct49_0.gstruct47_0.int_8 = array21[8];
			string[] string_55 = array;
			string string_56 = "BosST";
			int[] array22 = new int[5];
			array22[2] = 80;
			gstruct49_0.int_133 = Class53.smethod_19(string_55, string_56, array22);
			string[] string_57 = array;
			array8 = new int[1];
			gstruct49_0.int_134 = Class53.smethod_19(string_57, "STHaucan", array8)[0];
			string[] string_58 = array;
			array8 = new int[1];
			gstruct49_0.int_135 = Class53.smethod_19(string_58, "VSTClick", array8)[0];
			string[] string_59 = array;
			array8 = new int[1];
			gstruct49_0.int_126 = Class53.smethod_19(string_59, "fNotDame", array8)[0];
			string[] string_60 = array;
			array8 = new int[5];
			gstruct49_0.int_127 = Class53.smethod_19(string_60, "DameChieu12", array8);
			string[] string_61 = array;
			array8 = new int[7];
			gstruct49_0.int_128 = Class53.smethod_19(string_61, "DMBoom", array8);
			gstruct49_0.int_129 = Class53.smethod_19(array, "tbKeyXuat", new int[]
			{
				0,
				0,
				0,
				114,
				115,
				116
			});
			gstruct49_0.int_130 = Class53.smethod_19(array, "tbCaudame", new int[]
			{
				0,
				250
			});
			int[] array23 = Class53.smethod_19(array, "tbTienSkill", new int[]
			{
				0,
				0,
				0,
				8000,
				0,
				1,
				6,
				120,
				1,
				400
			});
			gstruct49_0.gstruct48_0 = new GStruct48
			{
				int_0 = array23[0],
				int_1 = array23[1],
				int_2 = array23[2],
				int_3 = array23[3],
				int_4 = array23[4],
				int_5 = array23[5],
				int_6 = array23[6],
				int_7 = array23[7],
				int_8 = array23[8],
				int_9 = array23[9]
			};
			string[] string_62 = array;
			array8 = new int[2];
			gstruct49_0.int_131 = Class53.smethod_19(string_62, "fQuangthuoc", array8);
			gstruct49_0.int_131[1] = 0;
			gstruct49_0.int_74 = Class53.smethod_19(array, "flagTuGiaidoc", new int[]
			{
				0,
				4500,
				1
			});
			string[] string_63 = array;
			array8 = new int[1];
			gstruct49_0.int_79 = Class53.smethod_19(string_63, "RuongBH", array8)[0];
			string[] string_64 = array;
			string string_65 = "ChThuoc";
			int[] array24 = new int[5];
			array24[3] = 5;
			gstruct49_0.int_76 = Class53.smethod_19(string_64, string_65, array24);
			array20 = Class53.smethod_21(array, "fTenThuoc", null, false);
			gstruct49_0.string_14 = "H·y chän 1 vËt phÈm";
			bool flag32 = array20 != null && array20.Length != 0;
			if (flag32)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag33 = array20[0] != string.Empty && array20[0] != null;
				if (flag33)
				{
					gstruct49_0.string_14 = array20[0];
				}
			}
			string[] string_66 = array;
			array8 = new int[1];
			gstruct49_0.int_78 = Class53.smethod_19(string_66, "MuaFree", array8)[0];
			string[] string_67 = array;
			array8 = new int[1];
			gstruct49_0.int_77 = Class53.smethod_19(string_67, "MuaKTC", array8)[0];
			string[] string_68 = array;
			string[] string_69 = new string[3];
			array20 = Class53.smethod_21(string_68, "tbKTCTabName", string_69, false);
			string[] string_70 = array;
			array8 = new int[1];
			gstruct49_0.int_70 = Class53.smethod_19(string_70, "flagMuaNgamy", array8)[0];
			gstruct49_0.int_71 = Class53.smethod_19(array, "flagMuaThuocHP", new int[]
			{
				0,
				0,
				40
			});
			gstruct49_0.string_11 = "H·y mua tr­íc 1 b×nh thuèc";
			array20 = Class53.smethod_21(array, "TenHP", null, false);
			bool flag34 = array20 != null && array20.Length != 0;
			if (flag34)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag35 = array20[0] != string.Empty && array20[0] != null;
				if (flag35)
				{
					gstruct49_0.string_11 = array20[0];
				}
			}
			gstruct49_0.int_72 = Class53.smethod_19(array, "flagMuaThuocMP", new int[]
			{
				0,
				0,
				15
			});
			gstruct49_0.string_12 = "H·y mua tr­íc 1 b×nh thuèc";
			array20 = Class53.smethod_21(array, "TenMP", null, false);
			bool flag36 = array20 != null && array20.Length != 0;
			if (flag36)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag37 = array20[0] != string.Empty && array20[0] != null;
				if (flag37)
				{
					gstruct49_0.string_12 = array20[0];
				}
			}
			gstruct49_0.int_73 = Class53.smethod_19(array, "flagMuaGiaiDoc", new int[]
			{
				0,
				0,
				10
			});
			gstruct49_0.string_13 = "H·y mua tr­íc 1 b×nh thuèc";
			array20 = Class53.smethod_21(array, "TenGiaiDoc", null, false);
			bool flag38 = array20 != null && array20.Length != 0;
			if (flag38)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag39 = array20[0] != string.Empty && array20[0] != null;
				if (flag39)
				{
					gstruct49_0.string_13 = array20[0];
				}
			}
			string[] string_71 = array;
			string string_72 = "GanTenthuoc";
			int[] array25 = new int[5];
			array25[1] = 2;
			gstruct49_0.int_75 = Class53.smethod_19(string_71, string_72, array25);
			gstruct49_0.int_92 = Class53.smethod_19(array, "flagDoiPk", new int[]
			{
				1
			})[0];
			gstruct49_0.int_93 = Class53.smethod_19(array, "flagXuongngua", new int[]
			{
				1
			})[0];
			string[] string_73 = array;
			array8 = new int[1];
			gstruct49_0.int_94 = Class53.smethod_19(string_73, "ChetNamIm", array8)[0];
			string[] string_74 = array;
			array8 = new int[1];
			gstruct49_0.int_100 = Class53.smethod_19(string_74, "flagDanhphim", array8)[0];
			string[] string_75 = array;
			array8 = new int[1];
			gstruct49_0.int_119 = Class53.smethod_19(string_75, "flagTuCastBua", array8)[0];
			string[] string_76 = array;
			array8 = new int[1];
			gstruct49_0.int_103 = Class53.smethod_19(string_76, "flagTuPT", array8)[0];
			gstruct49_0.int_95 = Class53.smethod_19(array, "flagTiepcanF", new int[]
			{
				1
			})[0];
			gstruct49_0.int_96 = Class53.smethod_19(array, "ValueTiepcan", new int[]
			{
				512
			})[0];
			gstruct49_0.int_98 = Class53.smethod_19(array, "flagTamQuet_", new int[]
			{
				1
			})[0];
			gstruct49_0.int_99 = Class53.smethod_19(array, "ValueTamQuet_s", new int[]
			{
				550
			})[0];
			gstruct49_0.int_104 = Class53.smethod_19(array, "TDPKhiPk", new int[]
			{
				1,
				9
			});
			string[] string_77 = array;
			array8 = new int[1];
			gstruct49_0.int_105 = Class53.smethod_19(string_77, "flagTuChayMuaThuocHoaSon", array8)[0];
			string[] string_78 = array;
			array8 = new int[2];
			gstruct49_0.int_12 = Class53.smethod_19(string_78, "fBanEvent", array8);
			int num3 = 0;
			array14 = Class53.smethod_21(array, "MoTuiThuoc", null, false);
			bool flag40 = array14 != null && array14.Length != 0;
			if (flag40)
			{
				string text3 = Class12.smethod_15(array14[0]);
				bool flag41 = array14[0] != string.Empty && array14[0] != null;
				if (flag41)
				{
					string[] array26 = text3.Split(new char[]
					{
						'|'
					});
					GStruct34[] array27 = new GStruct34[array26.Length];
					for (int n = 0; n < array27.Length; n++)
					{
						string text4 = array26[n];
						bool flag42 = text4 == null || text4 == string.Empty;
						if (!flag42)
						{
							string[] array28 = text4.Split(new char[]
							{
								'\u0001'
							});
							bool flag43 = array28.Length < 8;
							if (!flag43)
							{
								array27[num3].string_0 = array28[0];
								array27[num3].int_6 = Class12.smethod_11(array28[1]);
								array27[num3].int_0 = Class12.smethod_11(array28[2]);
								array27[num3].int_5 = Class12.smethod_11(array28[3]);
								array27[num3].int_8 = new int[]
								{
									1,
									1
								};
								string[] array29 = array28[4].Split(new char[]
								{
									'_'
								});
								bool flag44 = array29 != null;
								if (flag44)
								{
									array27[num3].int_8 = new int[array29.Length];
									for (int num4 = 0; num4 < array29.Length; num4++)
									{
										array27[num3].int_8[num4] = Class12.smethod_11(array29[num4]);
									}
								}
								array27[num3].int_3 = Class12.smethod_11(array28[5]);
								array27[num3].int_4 = Class12.smethod_11(array28[6]);
								array27[num3].int_7 = Class12.smethod_11(array28[7]);
								bool flag45 = array28.Length > 8;
								if (flag45)
								{
									array27[num3].int_1 = Class12.smethod_11(array28[8]);
								}
								bool flag46 = array28.Length > 9;
								if (flag46)
								{
									array27[num3].int_2 = Class12.smethod_11(array28[9]);
								}
								num3++;
							}
						}
					}
					bool flag47 = num3 > 0;
					if (flag47)
					{
						gstruct49_0.gstruct34_0 = new GStruct34[num3];
						for (int num5 = 0; num5 < num3; num5++)
						{
							gstruct49_0.gstruct34_0[num5].string_0 = array27[num5].string_0;
							gstruct49_0.gstruct34_0[num5].int_6 = array27[num5].int_6;
							gstruct49_0.gstruct34_0[num5].int_0 = array27[num5].int_0;
							gstruct49_0.gstruct34_0[num5].int_5 = array27[num5].int_5;
							gstruct49_0.gstruct34_0[num5].int_8 = new int[]
							{
								1,
								1
							};
							bool flag48 = array27[num5].int_8 != null;
							if (flag48)
							{
								gstruct49_0.gstruct34_0[num5].int_8 = new int[array27[num5].int_8.Length];
								for (int num6 = 0; num6 < array27[num5].int_8.Length; num6++)
								{
									gstruct49_0.gstruct34_0[num5].int_8[num6] = array27[num5].int_8[num6];
								}
							}
							gstruct49_0.gstruct34_0[num5].int_3 = array27[num5].int_3;
							gstruct49_0.gstruct34_0[num5].int_4 = array27[num5].int_4;
							gstruct49_0.gstruct34_0[num5].int_7 = array27[num5].int_7;
							gstruct49_0.gstruct34_0[num5].int_1 = array27[num5].int_1;
							gstruct49_0.gstruct34_0[num5].int_2 = array27[num5].int_2;
						}
					}
				}
			}
			bool flag49 = num3 == 0;
			if (flag49)
			{
				gstruct49_0.gstruct34_0 = new GStruct34[]
				{
					new GStruct34
					{
						string_0 = "Håi thiªn t¸i t¹o lÔ bao",
						int_0 = 0,
						int_1 = 0,
						int_2 = 0,
						int_3 = 60000,
						int_4 = 0,
						int_5 = 5,
						int_6 = 1,
						int_7 = 0,
						int_8 = new int[]
						{
							1,
							1
						}
					}
				};
			}
			gstruct49_0.int_101 = Class53.smethod_19(array, "fNgamyBuff", new int[]
			{
				0,
				0,
				0,
				101,
				800,
				400,
				0,
				0
			});
			gstruct49_0.int_106 = Class53.smethod_19(array, "BomHPDiem", new int[]
			{
				0,
				1000,
				1500,
				1
			});
			gstruct49_0.int_107 = Class53.smethod_19(array, "BomMPDiem", new int[]
			{
				0,
				200,
				2500,
				1
			});
			gstruct49_0.int_109 = Class53.smethod_19(array, "BomHPRatio", new int[]
			{
				1,
				85,
				1500,
				1
			});
			gstruct49_0.int_110 = Class53.smethod_19(array, "BomM2HPRatio", new int[]
			{
				1,
				75,
				1500,
				1
			});
			gstruct49_0.int_111 = Class53.smethod_19(array, "BomMPRatio", new int[]
			{
				1,
				25,
				2500,
				1
			});
			gstruct49_0.int_112 = Class53.smethod_19(array, "BomM2MPRatio", new int[]
			{
				0,
				0,
				1500,
				1
			});
			string[] string_79 = array;
			array8 = new int[1];
			gstruct49_0.int_108 = Class53.smethod_19(string_79, "flagUuTienBomCuuChuyen", array8)[0];
			gstruct49_0.int_113 = Class53.smethod_19(array, "HPTdp", new int[]
			{
				0,
				40
			});
			gstruct49_0.int_114 = Class53.smethod_19(array, "MPTdp", new int[]
			{
				0,
				30
			});
			string[] string_80 = array;
			array8 = new int[1];
			gstruct49_0.int_115 = Class53.smethod_19(string_80, "flagTDPKhiSoluongMau", array8)[0];
			string[] string_81 = array;
			array8 = new int[1];
			gstruct49_0.int_116 = Class53.smethod_19(string_81, "TDPSoluongMauConlai", array8)[0];
			string[] string_82 = array;
			array8 = new int[1];
			gstruct49_0.int_117 = Class53.smethod_19(string_82, "flagTDPKhiSoluongMana", array8)[0];
			string[] string_83 = array;
			array8 = new int[1];
			gstruct49_0.int_118 = Class53.smethod_19(string_83, "TDPSoluongManaConlai", array8)[0];
			gstruct49_0.string_16 = "Ngò Hoa Ngäc Lé Hoµn";
			gstruct49_0.string_17 = "¤ ®Çu Hoµn thÇn ®an";
			array20 = Class53.smethod_21(array, "TenMauMuc2", null, false);
			bool flag50 = array20 != null && array20.Length != 0;
			if (flag50)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag51 = array20[0] != string.Empty && array20[0] != null;
				if (flag51)
				{
					gstruct49_0.string_16 = array20[0];
				}
			}
			array20 = Class53.smethod_21(array, "TenManaMuc2", null, false);
			bool flag52 = array20 != null && array20.Length != 0;
			if (flag52)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag53 = array20[0] != string.Empty && array20[0] != null;
				if (flag53)
				{
					gstruct49_0.string_17 = array20[0];
				}
			}
			gstruct49_0.string_18 = null;
			array14 = Class53.smethod_21(array, "DanhsachCuusat", null, false);
			bool flag54 = array14 != null && array14.Length != 0;
			if (flag54)
			{
				array14[0] = Class12.smethod_15(array14[0]);
				bool flag55 = array14[0] != string.Empty && array14[0] != null;
				if (flag55)
				{
					gstruct49_0.string_18 = array14[0].Split(new char[]
					{
						'|'
					});
				}
			}
			string[] string_84 = array;
			array8 = new int[1];
			gstruct49_0.int_120 = Class53.smethod_19(string_84, "flagCuusatTheodanhsach", array8)[0];
			gstruct49_0.string_19 = null;
			array20 = Class53.smethod_21(array, "PTDanhsach", null, false);
			bool flag56 = array20 != null && array20.Length != 0;
			if (flag56)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag57 = array20[0] != string.Empty && array20[0] != null;
				if (flag57)
				{
					gstruct49_0.string_19 = array20[0].Split(new char[]
					{
						'|'
					});
				}
			}
			string[] string_85 = array;
			array8 = new int[1];
			gstruct49_0.int_122 = Class53.smethod_19(string_85, "fTuchayToadoVA", array8)[0];
			string[] string_86 = array;
			array8 = new int[1];
			gstruct49_0.int_123 = Class53.smethod_19(string_86, "fClickNTT", array8)[0];
			string[] string_87 = array;
			array8 = new int[5];
			gstruct49_0.int_125 = Class53.smethod_19(string_87, "fDenToado", array8);
			gstruct49_0.int_124 = new int[]
			{
				gstruct49_0.int_125[2],
				gstruct49_0.int_125[3],
				gstruct49_0.int_125[4]
			};
			string[] string_88 = array;
			array8 = new int[5];
			gstruct49_0.int_121 = Class53.smethod_19(string_88, "PTflag", array8);
			gstruct49_0.int_89 = Class53.smethod_19(array, "GiamCpuLevel", new int[]
			{
				1
			})[0];
			gstruct49_0.int_1 = Class53.smethod_19(array, "fBaoBoss", new int[]
			{
				1
			})[0];
			int int_ = Class36.smethod_29(gstruct49_0);
			string[] string_89 = array;
			array8 = new int[1];
			gstruct49_0.int_88 = Class53.smethod_19(string_89, "KieuDanh", array8)[0];
			gstruct49_0.int_90 = Class53.smethod_19(array, "tbNguhanh", Class53.smethod_14(int_));
			int[] array30 = new int[Class77.gstruct55_0.Length];
			for (int num7 = 0; num7 < Class77.gstruct55_0.Length; num7++)
			{
				array30[num7] = Class77.gstruct55_0[num7].int_0;
			}
			gstruct49_0.int_91 = Class53.smethod_19(array, "tbMonPhai", array30);
			gstruct49_0.string_23 = Class77.smethod_18(gstruct49_0, null);
			gstruct49_0.int_3 = null;
			gstruct49_0.int_4 = null;
			int[] array31 = Class53.smethod_19(array, "tbValueMagic", null);
			bool flag58 = gstruct49_0.string_23 == "NGUDOC" || gstruct49_0.string_23 == "THIENNHAN" || gstruct49_0.string_23 == "CONLON";
			if (flag58)
			{
				gstruct49_0.int_4 = Class53.smethod_17(gstruct49_0.string_23);
				bool flag59 = array31 != null;
				if (flag59)
				{
					int num8 = 0;
					int[] array32 = new int[array31.Length];
					int[] array33 = new int[array31.Length];
					for (int num9 = 0; num9 < array32.Length; num9++)
					{
						bool flag60 = array31[num9] > 0;
						if (flag60)
						{
							int num10 = Class77.smethod_16(gstruct49_0, array31[num9]);
							bool flag61 = num10 > 0;
							if (flag61)
							{
								array32[num8] = array31[num9];
								array33[num8] = num10;
								num8++;
							}
						}
					}
					bool flag62 = num8 > 0;
					if (flag62)
					{
						bool flag63 = num8 > 4;
						if (flag63)
						{
							num8 = 4;
						}
						gstruct49_0.int_3 = new int[num8, 2];
						for (int num11 = 0; num11 < num8; num11++)
						{
							gstruct49_0.int_3[num11, 0] = array32[num11];
							gstruct49_0.int_3[num11, 1] = array33[num11];
						}
					}
				}
			}
			string[] string_90 = array;
			array8 = new int[1];
			gstruct49_0.int_5 = Class53.smethod_19(string_90, "flagBuffDoituong", array8)[0];
			string[] string_91 = array;
			array8 = new int[1];
			gstruct49_0.int_6 = Class53.smethod_19(string_91, "flagChiBuffKhongDanh", array8)[0];
			gstruct49_0.int_80 = (int)Convert.ToByte(gstruct49_0.string_23 == "VODANG") * Class53.smethod_19(array, "flagTuGiaiBua", new int[]
			{
				1
			})[0];
			gstruct49_0.int_81 = Class53.smethod_19(array, "flagGiaibuaBangsat", new int[]
			{
				1
			})[0];
			string[] string_92 = array;
			array8 = new int[1];
			gstruct49_0.int_82 = Class53.smethod_19(string_92, "flagGiaibuaTheoThoigian", array8)[0];
			byte b = Convert.ToByte(gstruct49_0.string_23 == "THIENNHAN");
			string[] string_93 = array;
			array8 = new int[1];
			gstruct49_0.int_83 = (int)b * Class53.smethod_19(string_93, "flagTNXuatChieu120", array8)[0];
			string[] string_94 = array;
			array8 = new int[2];
			gstruct49_0.int_84 = Class53.smethod_19(string_94, "flagCLon", array8);
			bool flag64 = gstruct49_0.int_84 == null;
			if (flag64)
			{
				gstruct49_0.int_84 = new int[2];
			}
			gstruct49_0.int_84[0] = (int)Convert.ToByte(gstruct49_0.string_23 == "CONLON") * gstruct49_0.int_84[0];
			gstruct49_0.int_84[1] = (int)Convert.ToByte(gstruct49_0.string_23 == "CONLON") * gstruct49_0.int_84[1];
			gstruct49_0.int_85 = Class53.smethod_19(array, "TimerTuGiaibua", new int[]
			{
				6500
			})[0];
			gstruct49_0.int_87 = Class53.smethod_19(array, "TimerTheoThoigian", new int[]
			{
				28000
			})[0];
			gstruct49_0.int_86 = Class53.smethod_19(array, "TamBuffbua", new int[]
			{
				440
			})[0];
			gstruct49_0.string_0 = "Tæng qu¶n ThÝ luyÖn ph­êng";
			array20 = Class53.smethod_21(array, "ClickNPCName", null, false);
			bool flag65 = array20 != null && array20.Length != 0;
			if (flag65)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag66 = array20[0] != string.Empty && array20[0] != null;
				if (flag66)
				{
					gstruct49_0.string_0 = array20[0];
				}
			}
			gstruct49_0.int_7 = Class53.smethod_19(array, "ClickNPCSolan", new int[]
			{
				0,
				3
			});
			gstruct49_0.int_9 = Class53.smethod_19(array, "tbClickNpcMenu", new int[]
			{
				1,
				2,
				1,
				1
			});
			string[] string_95 = array;
			array8 = new int[1];
			gstruct49_0.int_8 = Class53.smethod_19(string_95, "fClickNpcMenu", array8)[0];
			gstruct49_0.int_10 = Class53.smethod_19(array, "ClickNPCTocdo", new int[]
			{
				300
			})[0];
			gstruct49_0.int_11 = Class53.smethod_19(array, "ClickLocTocdo", new int[]
			{
				300
			})[0];
			string[] string_96 = array;
			string string_97 = "fClickNPC_Sudung";
			int[] array34 = new int[4];
			array34[2] = 1;
			gstruct49_0.int_13 = Class53.smethod_19(string_96, string_97, array34);
			string[] string_98 = array;
			array8 = new int[1];
			gstruct49_0.int_15 = Class53.smethod_19(string_98, "flagClickNpcSau", array8)[0];
			gstruct49_0.int_14 = Class53.smethod_19(array, "MenuVatphamNpc", new int[]
			{
				1,
				2
			});
			gstruct49_0.string_1 = "CÈm nang t©n thñ";
			array20 = Class53.smethod_21(array, "TenVatphamNpc", null, false);
			bool flag67 = array20 != null && array20.Length != 0;
			if (flag67)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag68 = array20[0] != string.Empty && array20[0] != null;
				if (flag68)
				{
					gstruct49_0.string_1 = array20[0];
				}
			}
			gstruct49_0.int_16 = Class53.smethod_19(array, "fClickNPC_Nop", new int[]
			{
				0,
				1
			});
			gstruct49_0.gstruct31_0 = null;
			array20 = Class53.smethod_21(array, "ClickNPC_Nop", null, false);
			bool flag69 = array20 != null && array20.Length != 0;
			if (flag69)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag70 = array20[0] != null && array20[0] != string.Empty;
				if (flag70)
				{
					array20 = array20[0].Split(new char[]
					{
						'|'
					});
					gstruct49_0.gstruct31_0 = new GStruct31[array20.Length];
					int num12 = 0;
					for (int num13 = 0; num13 < array20.Length; num13++)
					{
						bool flag71 = array20[num13] != null && !(array20[num13] == string.Empty);
						if (flag71)
						{
							string[] array35 = array20[num13].Split(new char[]
							{
								'='
							});
							bool flag72 = array35.Length == 2;
							if (flag72)
							{
								ref GStruct31 ptr = ref gstruct49_0.gstruct31_0[num12];
								ptr = new GStruct31
								{
									string_0 = array35[0],
									int_4 = Class12.smethod_11(array35[1])
								};
								num12++;
							}
						}
					}
					bool flag73 = num12 == 0;
					if (flag73)
					{
						gstruct49_0.gstruct31_0 = null;
					}
					else
					{
						bool flag74 = num12 < gstruct49_0.gstruct31_0.Length;
						if (flag74)
						{
							Array.Resize<GStruct31>(ref gstruct49_0.gstruct31_0, num12);
						}
					}
				}
			}
			gstruct49_0.int_17 = Class53.smethod_19(array, "fClickNPC_MuaVP", new int[]
			{
				0,
				1,
				1,
				1,
				0
			});
			gstruct49_0.string_2 = null;
			array20 = Class53.smethod_21(array, "ClickNPC_TabKTC", null, false);
			bool flag75 = array20 != null && array20.Length != 0;
			if (flag75)
			{
				gstruct49_0.string_2 = Class12.smethod_15(array20[0]);
			}
			gstruct49_0.gstruct31_1 = default(GStruct31);
			array20 = Class53.smethod_21(array, "ClickNPC_Mua", null, false);
			bool flag76 = array20 != null && array20.Length != 0;
			if (flag76)
			{
				array20[0] = Class12.smethod_15(array20[0]);
				bool flag77 = array20[0] != null && array20[0] != string.Empty;
				if (flag77)
				{
					array20 = array20[0].Split(new char[]
					{
						'='
					});
					gstruct49_0.gstruct31_1.string_0 = array20[0];
					gstruct49_0.gstruct31_1.int_4 = Class12.smethod_11(array20[1]);
				}
			}
			string[] string_99 = array;
			array8 = new int[1];
			gstruct49_0.int_33 = Class53.smethod_19(string_99, "XulyDosat", array8)[0];
			string[] string_100 = array;
			array8 = new int[1];
			gstruct49_0.int_25 = Class53.smethod_19(string_100, "flagTrains", array8)[0];
			string[] string_101 = array;
			array8 = new int[1];
			gstruct49_0.int_26 = Class53.smethod_19(string_101, "flagTucheHT", array8)[0];
			gstruct49_0.int_27 = Class53.smethod_19(array, "DanhQuaiTrain", new int[]
			{
				1
			})[0];
			string[] string_102 = array;
			array8 = new int[1];
			gstruct49_0.int_32 = Class53.smethod_19(string_102, "MapIDTrain", array8)[0];
			gstruct49_0.int_28 = Class53.smethod_19(array, "TDPHettien", new int[]
			{
				1
			})[0];
			string[] string_103 = array;
			array8 = new int[1];
			gstruct49_0.int_29 = Class53.smethod_19(string_103, "ToadoVong", array8)[0];
			gstruct49_0.int_30 = Class53.smethod_19(array, "DanhTrenDuongdi", new int[]
			{
				1
			})[0];
			string[] string_104 = array;
			array8 = new int[1];
			gstruct49_0.int_31 = Class53.smethod_19(string_104, "QuayQuai", array8)[0];
			array20 = Class53.smethod_21(array, "ToadoTrain", null, false);
			bool flag78 = array20 != null && array20.Length != 0;
			if (flag78)
			{
				array20 = Class12.smethod_15(array20[0]).Split(new char[]
				{
					'|'
				});
				int num14 = 0;
				uint[,] array36 = new uint[array20.Length, 2];
				for (int num15 = 0; num15 < array20.Length; num15++)
				{
					string[] array37 = array20[num15].Split(new char[]
					{
						';'
					});
					bool flag79 = array37.Length > 1;
					if (flag79)
					{
						uint num16 = Class12.smethod_12(array37[0]);
						uint num17 = Class12.smethod_12(array37[1]);
						bool flag80 = num16 != 0U && num17 > 0U;
						if (flag80)
						{
							array36[num14, 0] = num16;
							array36[num14, 1] = num17;
							num14++;
						}
					}
				}
				bool flag81 = num14 > 0;
				if (flag81)
				{
					gstruct49_0.uint_0 = new uint[num14, 2];
					for (int num18 = 0; num18 < num14; num18++)
					{
						gstruct49_0.uint_0[num18, 0] = array36[num18, 0];
						gstruct49_0.uint_0[num18, 1] = array36[num18, 1];
					}
				}
			}
			string[] string_105 = array;
			array8 = new int[1];
			gstruct49_0.int_34 = Class53.smethod_19(string_105, "flagChayPkNguoidung", array8)[0];
			string[] string_106 = array;
			array8 = new int[2];
			gstruct49_0.int_20 = Class53.smethod_19(string_106, "fTinSu", array8);
			string[] string_107 = array;
			array8 = new int[1];
			gstruct49_0.int_35 = Class53.smethod_19(string_107, "MapIDPk1", array8)[0];
			string[] string_108 = array;
			array8 = new int[1];
			gstruct49_0.int_36 = Class53.smethod_19(string_108, "MapIDPk2", array8)[0];
			array20 = Class53.smethod_21(array, "ToadoPk1", null, false);
			bool flag82 = array20 != null && array20.Length != 0;
			if (flag82)
			{
				array20 = Class12.smethod_15(array20[0]).Split(new char[]
				{
					'|'
				});
				int num19 = 0;
				uint[,] array38 = new uint[array20.Length, 2];
				for (int num20 = 0; num20 < array20.Length; num20++)
				{
					string[] array39 = array20[num20].Split(new char[]
					{
						';'
					});
					bool flag83 = array39.Length > 1;
					if (flag83)
					{
						uint num21 = Class12.smethod_12(array39[0]);
						uint num22 = Class12.smethod_12(array39[1]);
						bool flag84 = num21 != 0U && num22 > 0U;
						if (flag84)
						{
							array38[num19, 0] = num21;
							array38[num19, 1] = num22;
							num19++;
						}
					}
				}
				bool flag85 = num19 > 0;
				if (flag85)
				{
					gstruct49_0.uint_2 = new uint[num19, 2];
					for (int num23 = 0; num23 < num19; num23++)
					{
						gstruct49_0.uint_2[num23, 0] = array38[num23, 0];
						gstruct49_0.uint_2[num23, 1] = array38[num23, 1];
					}
				}
			}
			array20 = Class53.smethod_21(array, "ToadoPk2", null, false);
			bool flag86 = array20 != null && array20.Length != 0;
			if (flag86)
			{
				array20 = Class12.smethod_15(array20[0]).Split(new char[]
				{
					'|'
				});
				int num24 = 0;
				uint[,] array40 = new uint[array20.Length, 2];
				for (int num25 = 0; num25 < array20.Length; num25++)
				{
					string[] array41 = array20[num25].Split(new char[]
					{
						';'
					});
					bool flag87 = array41.Length > 1;
					if (flag87)
					{
						uint num26 = Class12.smethod_12(array41[0]);
						uint num27 = Class12.smethod_12(array41[1]);
						bool flag88 = num26 != 0U && num27 > 0U;
						if (flag88)
						{
							array40[num24, 0] = num26;
							array40[num24, 1] = num27;
							num24++;
						}
					}
				}
				bool flag89 = num24 > 0;
				if (flag89)
				{
					gstruct49_0.uint_3 = new uint[num24, 2];
					for (int num28 = 0; num28 < num24; num28++)
					{
						gstruct49_0.uint_3[num28, 0] = array40[num28, 0];
						gstruct49_0.uint_3[num28, 1] = array40[num28, 1];
					}
				}
			}
			gstruct49_0.bool_5 = true;
			gstruct49_0.int_21 = 5;
			gstruct49_0.byte_0 = new byte[11];
			gstruct49_0.gstruct45_0 = new GStruct45[2];
			array20 = Class53.smethod_21(array, "TenVukhi", null, false);
			bool flag90 = array20 != null && array20.Length != 0;
			if (flag90)
			{
				array20 = Class12.smethod_15(array20[0]).Split(new char[]
				{
					'|'
				});
				gstruct49_0.gstruct45_0[0].string_0 = array20[0];
				bool flag91 = array20.Length > 1;
				if (flag91)
				{
					gstruct49_0.gstruct45_0[1].string_0 = array20[1];
				}
			}
			string[] string_109 = array;
			string string_110 = "tbVukhi0";
			int[] array42 = new int[5];
			array42[3] = 500;
			int[] array43 = Class53.smethod_19(string_109, string_110, array42);
			gstruct49_0.gstruct45_0[0].int_0 = array43[0];
			gstruct49_0.gstruct45_0[0].int_1 = array43[1];
			gstruct49_0.gstruct45_0[0].int_3 = array43[2];
			gstruct49_0.gstruct45_0[0].int_2 = array43[3];
			gstruct49_0.gstruct45_0[0].int_4 = array43[4];
			gstruct49_0.gstruct45_0[0].int_5 = Class53.smethod_19(array, "TTVukhi0", null);
			string[] string_111 = array;
			string string_112 = "tbVukhi1";
			int[] array44 = new int[5];
			array44[3] = 500;
			array43 = Class53.smethod_19(string_111, string_112, array44);
			gstruct49_0.gstruct45_0[1].int_0 = array43[0];
			gstruct49_0.gstruct45_0[1].int_1 = array43[1];
			gstruct49_0.gstruct45_0[1].int_3 = array43[2];
			gstruct49_0.gstruct45_0[1].int_2 = array43[3];
			gstruct49_0.gstruct45_0[1].int_4 = array43[4];
			gstruct49_0.gstruct45_0[1].int_5 = Class53.smethod_19(array, "TTVukhi1", null);
			bool flag92 = gstruct49_0.gstruct45_0[0].int_5 == null || gstruct49_0.gstruct45_0[0].int_5.Length != Class53.uint_0.Length;
			if (flag92)
			{
				gstruct49_0.gstruct45_0[0].int_5 = null;
				gstruct49_0.gstruct45_0[0].string_0 = null;
			}
			bool flag93 = gstruct49_0.gstruct45_0[1].int_5 == null || gstruct49_0.gstruct45_0[1].int_5.Length != Class53.uint_0.Length;
			if (flag93)
			{
				gstruct49_0.gstruct45_0[1].int_5 = null;
				gstruct49_0.gstruct45_0[1].string_0 = null;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00085514 File Offset: 0x00083714
		public static void smethod_11(int int_11)
		{
			int num = 0;
			while (!Class12.bool_0 && Class53.int_8 > 0 && num < 10)
			{
				num++;
				Thread.Sleep(30);
			}
			try
			{
				Class53.int_8 = int_11;
				new Thread(new ThreadStart(Class53.smethod_12)).Start();
			}
			catch
			{
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00085588 File Offset: 0x00083788
		private static void smethod_12()
		{
			int num = Class53.int_8;
			Class53.int_8 = 0;
			int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag = num2 < 0;
			if (!flag)
			{
				Form1.gstruct49_0[num2].bool_2 = true;
				GStruct49 gstruct = Form1.gstruct49_0[num2];
				string[] array = new string[]
				{
					"-------------------------------------------",
					"<color=yellow>" + Form1.string_1.ToUpper() + " - http://canhtrang.com/",
					"-------------------------------------------",
					"<color=green>+ PhÝm Ctrl + Z: Më r­¬ng",
					"<color=green>+ PhÝm Ctrl + X: Më t¹p ho¸",
					"<color=green>+ PhÝm Ctrl + F: Qu¨ng ®å (+ Alt)",
					"<color=green>+ PhÝm Ctrl + G: Gép ®å",
					"<color=green>+ PhÝm Ctrl + K: Xãa SMS",
					"<color=green>+ PhÝm sè 1 ..9: Combo nhåi thuèc",
					"<color=yellow>+ PhÝm Ctrl + A: ChuyÓn ®å (theo size)",
					"<color=yellow>+ PhÝm Ctrl + S: ChuyÓn ®å (theo tªn)",
					"<color=green>+ PhÝm - vµ + : ChuyÒn thuèc r­¬ng Bang héi",
					"<color=green>+ PhÝm F7, F8: BËt t¾t ®¸nh qu¸i - ng­êi ",
					"<color=green>+ PhÝm F10: Gi¶m cÊu h×nh CPU (tab phô trî)",
					"<bclr=blue><color=green>Yªu cÇu: Stick sö dông phÝm t¾t (phô trî)"
				};
				bool flag2 = Form1.int_65 == 0;
				if (flag2)
				{
					for (int i = 0; i < array.Length; i++)
					{
						Class70.smethod_52(gstruct, array[i], 1);
						bool flag3 = array[i].IndexOf("F7") > 0;
						if (flag3)
						{
							string text = Class83.smethod_22(gstruct);
							bool flag4 = text != null && text != string.Empty && text.IndexOf("F7") > 0;
							if (flag4)
							{
								text = text.Replace("F7,", "F7 -");
								Class83.smethod_23(gstruct, text);
							}
						}
						Thread.Sleep(80);
					}
				}
				num2 = Class81.smethod_3(Form1.gstruct49_0, num);
				bool flag5 = 0 <= num2;
				if (flag5)
				{
					Form1.gstruct49_0[num2].bool_2 = false;
					Class47.smethod_0(gstruct, gstruct.int_89, -1);
					Class83.smethod_40(gstruct);
				}
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00085768 File Offset: 0x00083968
		public static void smethod_13(GStruct49 gstruct49_0, string string_27 = null)
		{
			string str = null;
			bool flag = gstruct49_0.gstruct45_0 == null;
			if (flag)
			{
				gstruct49_0.gstruct45_0 = new GStruct45[2];
			}
			str = str + "|TenVukhi;" + Class12.smethod_16(gstruct49_0.gstruct45_0[0].string_0 + "|" + gstruct49_0.gstruct45_0[1].string_0);
			int[] object_ = new int[]
			{
				gstruct49_0.gstruct45_0[0].int_0,
				gstruct49_0.gstruct45_0[0].int_1,
				gstruct49_0.gstruct45_0[0].int_3,
				gstruct49_0.gstruct45_0[0].int_2,
				gstruct49_0.gstruct45_0[0].int_4
			};
			Class53.smethod_18(ref str, "tbVukhi0", object_);
			object_ = new int[]
			{
				gstruct49_0.gstruct45_0[1].int_0,
				gstruct49_0.gstruct45_0[1].int_1,
				gstruct49_0.gstruct45_0[1].int_3,
				gstruct49_0.gstruct45_0[1].int_2,
				gstruct49_0.gstruct45_0[1].int_4
			};
			Class53.smethod_18(ref str, "tbVukhi1", object_);
			Class53.smethod_18(ref str, "TTVukhi0", gstruct49_0.gstruct45_0[0].int_5);
			Class53.smethod_18(ref str, "TTVukhi1", gstruct49_0.gstruct45_0[1].int_5);
			Class53.smethod_18(ref str, "flagXepdo", gstruct49_0.int_37);
			Class53.smethod_18(ref str, "TimerXepdo", gstruct49_0.int_38);
			Class53.smethod_18(ref str, "flagNhatTrongthanh", gstruct49_0.int_39);
			Class53.smethod_18(ref str, "flagNhatTheoThuoctinh", gstruct49_0.int_40);
			Class53.smethod_18(ref str, "flagThoahetThuoctinh", gstruct49_0.int_41);
			Class53.smethod_18(ref str, "flagKhongNhatdoTim", gstruct49_0.int_42);
			Class53.smethod_18(ref str, "GiuNhan", gstruct49_0.int_43);
			Class53.smethod_18(ref str, "GiuDC", gstruct49_0.int_44);
			Class53.smethod_18(ref str, "GiuNB", gstruct49_0.int_45);
			Class53.smethod_18(ref str, "flagPhamviNhatdo", gstruct49_0.int_51);
			Class53.smethod_18(ref str, "RuongCatdo", gstruct49_0.int_53);
			bool flag2 = gstruct49_0.string_5 != null && gstruct49_0.string_5.Length != 0;
			if (flag2)
			{
				string text = null;
				for (int i = 0; i < gstruct49_0.string_5.Length; i++)
				{
					bool flag3 = gstruct49_0.string_5[i] != null && gstruct49_0.string_5[i] != string.Empty;
					if (flag3)
					{
						bool flag4 = text != null;
						if (flag4)
						{
							text += "|";
						}
						text += gstruct49_0.string_5[i];
					}
				}
				bool flag5 = text != null;
				if (flag5)
				{
					str = str + "|tbKeepItem;" + Class12.smethod_16(text);
				}
			}
			Class53.smethod_18(ref str, "PhamviNhatdo", gstruct49_0.int_52);
			Class53.smethod_18(ref str, "flagVeBando", gstruct49_0.int_46);
			Class53.smethod_18(ref str, "GiudoTheoCap", gstruct49_0.int_47);
			Class53.smethod_18(ref str, "GiudoTheoHe", gstruct49_0.int_48);
			Class53.smethod_18(ref str, "GiudoTim", gstruct49_0.int_49);
			Class53.smethod_18(ref str, "GiudoTheoThuoctinh", gstruct49_0.int_50);
			Class53.smethod_18(ref str, "Luomrac", gstruct49_0.int_54);
			Class53.smethod_18(ref str, "LuomracAccept", gstruct49_0.int_55);
			Class53.smethod_18(ref str, "LuomracThuoctinh", gstruct49_0.int_56);
			Class53.smethod_18(ref str, "SinhlucThoat", gstruct49_0.int_18);
			Class53.smethod_18(ref str, "flagSinhlucThoat", gstruct49_0.int_19);
			Class53.smethod_18(ref str, "TDPKhiHetruong", gstruct49_0.int_60);
			Class53.smethod_18(ref str, "flagTranhBossvang", gstruct49_0.int_57);
			Class53.smethod_18(ref str, "AnTTL", gstruct49_0.int_58);
			Class53.smethod_18(ref str, "TDPKhiSaiMap", gstruct49_0.int_59);
			Class53.smethod_18(ref str, "GiamCpuLevel", gstruct49_0.int_89);
			Class53.smethod_18(ref str, "flagNhatdos", gstruct49_0.int_61);
			Class53.smethod_18(ref str, "flagNhatdoIndex", gstruct49_0.int_62);
			Class53.smethod_18(ref str, "flagCanThuocLag", gstruct49_0.int_63);
			Class53.smethod_18(ref str, "fThuocTocdo", gstruct49_0.int_64);
			Class53.smethod_18(ref str, "flagBuffDoituong", gstruct49_0.int_5);
			Class53.smethod_18(ref str, "flagChiBuffKhongDanh", gstruct49_0.int_6);
			Class53.smethod_18(ref str, "flagTuGiaiBua", gstruct49_0.int_80);
			Class53.smethod_18(ref str, "flagGiaibuaBangsat", gstruct49_0.int_81);
			Class53.smethod_18(ref str, "flagGiaibuaTheoThoigian", gstruct49_0.int_82);
			Class53.smethod_18(ref str, "flagTNXuatChieu120", gstruct49_0.int_83);
			Class53.smethod_18(ref str, "flagCLon", gstruct49_0.int_84);
			Class53.smethod_18(ref str, "TimerTuGiaibua", gstruct49_0.int_85);
			Class53.smethod_18(ref str, "TimerTheoThoigian", gstruct49_0.int_87);
			Class53.smethod_18(ref str, "TamBuffbua", gstruct49_0.int_86);
			Class53.smethod_18(ref str, "flagTuGiaidoc", gstruct49_0.int_74);
			Class53.smethod_18(ref str, "TheoSau", gstruct49_0.int_68);
			str = str + "|NameTheoSau;" + Class12.smethod_16(gstruct49_0.string_9);
			Class53.smethod_18(ref str, "GanChieuTrai", gstruct49_0.int_138);
			Class53.smethod_18(ref str, "GanChieuPhai", gstruct49_0.int_139);
			int[] object_2 = new int[]
			{
				gstruct49_0.gstruct46_0[0].int_0,
				gstruct49_0.gstruct46_0[0].int_1,
				gstruct49_0.gstruct46_0[0].int_2,
				gstruct49_0.gstruct46_0[0].int_3,
				gstruct49_0.gstruct46_0[1].int_0,
				gstruct49_0.gstruct46_0[1].int_1,
				gstruct49_0.gstruct46_0[1].int_2,
				gstruct49_0.gstruct46_0[1].int_3,
				gstruct49_0.gstruct46_0[2].int_0,
				gstruct49_0.gstruct46_0[2].int_1,
				gstruct49_0.gstruct46_0[2].int_2,
				gstruct49_0.gstruct46_0[2].int_3
			};
			Class53.smethod_18(ref str, "tbChuyenTR", object_2);
			int[] object_3 = new int[]
			{
				gstruct49_0.gstruct46_1[0].int_0,
				gstruct49_0.gstruct46_1[0].int_1,
				gstruct49_0.gstruct46_1[0].int_2,
				gstruct49_0.gstruct46_1[0].int_3,
				gstruct49_0.gstruct46_1[1].int_0,
				gstruct49_0.gstruct46_1[1].int_1,
				gstruct49_0.gstruct46_1[1].int_2,
				gstruct49_0.gstruct46_1[1].int_3,
				gstruct49_0.gstruct46_1[2].int_0,
				gstruct49_0.gstruct46_1[2].int_1,
				gstruct49_0.gstruct46_1[2].int_2,
				gstruct49_0.gstruct46_1[2].int_3
			};
			Class53.smethod_18(ref str, "tbChuyenPH", object_3);
			int[] object_4 = new int[]
			{
				gstruct49_0.gstruct46_2.int_0,
				gstruct49_0.gstruct46_2.int_1,
				gstruct49_0.gstruct46_2.int_3,
				gstruct49_0.gstruct46_2.int_2
			};
			Class53.smethod_18(ref str, "GapBossChieu", object_4);
			Class53.smethod_18(ref str, "Tran1Phai", gstruct49_0.int_140);
			Class53.smethod_18(ref str, "Tran2Phai", gstruct49_0.int_141);
			Class53.smethod_18(ref str, "Tran3Phai", gstruct49_0.int_142);
			str = str + "|NhatQuaName;" + Class12.smethod_16(gstruct49_0.gstruct47_0.string_0);
			int[] object_5 = new int[]
			{
				gstruct49_0.gstruct47_0.int_0,
				gstruct49_0.gstruct47_0.int_2,
				gstruct49_0.gstruct47_0.int_3,
				gstruct49_0.gstruct47_0.int_4,
				gstruct49_0.gstruct47_0.int_5,
				gstruct49_0.gstruct47_0.int_1,
				gstruct49_0.gstruct47_0.int_6,
				gstruct49_0.gstruct47_0.int_7,
				gstruct49_0.gstruct47_0.int_8
			};
			Class53.smethod_18(ref str, "tbNhatQua", object_5);
			Class53.smethod_18(ref str, "BosST", gstruct49_0.int_133);
			Class53.smethod_18(ref str, "STHaucan", gstruct49_0.int_134);
			Class53.smethod_18(ref str, "VSTClick", gstruct49_0.int_135);
			Class53.smethod_18(ref str, "fNotDame", gstruct49_0.int_126);
			Class53.smethod_18(ref str, "DameChieu12", gstruct49_0.int_127);
			Class53.smethod_18(ref str, "DMBoom", gstruct49_0.int_128);
			Class53.smethod_18(ref str, "tbKeyXuat", gstruct49_0.int_129);
			Class53.smethod_18(ref str, "tbCaudame", gstruct49_0.int_130);
			int[] object_6 = new int[]
			{
				gstruct49_0.gstruct48_0.int_0,
				gstruct49_0.gstruct48_0.int_1,
				gstruct49_0.gstruct48_0.int_2,
				gstruct49_0.gstruct48_0.int_3,
				gstruct49_0.gstruct48_0.int_4,
				gstruct49_0.gstruct48_0.int_5,
				gstruct49_0.gstruct48_0.int_6,
				gstruct49_0.gstruct48_0.int_7,
				gstruct49_0.gstruct48_0.int_8,
				gstruct49_0.gstruct48_0.int_9
			};
			Class53.smethod_18(ref str, "tbTienSkill", object_6);
			Class53.smethod_18(ref str, "fQuangthuoc", gstruct49_0.int_131);
			Class53.smethod_18(ref str, "TienGuiBho", gstruct49_0.int_67);
			Class53.smethod_18(ref str, "flagTienMangtheo", gstruct49_0.int_65);
			Class53.smethod_18(ref str, "TienMangtheo", gstruct49_0.int_66);
			Class53.smethod_18(ref str, "RuongBH", gstruct49_0.int_79);
			Class53.smethod_18(ref str, "flagMuaNgamy", gstruct49_0.int_70);
			Class53.smethod_18(ref str, "fRao", gstruct49_0.int_69);
			str = str + "|tRaovat;" + Class12.smethod_16(gstruct49_0.string_10);
			Class53.smethod_18(ref str, "ChThuoc", gstruct49_0.int_76);
			str = str + "|fTenThuoc;" + Class12.smethod_16(gstruct49_0.string_14);
			Class53.smethod_18(ref str, "flagMuaThuocHP", gstruct49_0.int_71);
			str = str + "|TenHP;" + Class12.smethod_16(gstruct49_0.string_11);
			Class53.smethod_18(ref str, "flagMuaThuocMP", gstruct49_0.int_72);
			str = str + "|TenMP;" + Class12.smethod_16(gstruct49_0.string_12);
			Class53.smethod_18(ref str, "flagMuaGiaiDoc", gstruct49_0.int_73);
			str = str + "|TenGiaiDoc;" + Class12.smethod_16(gstruct49_0.string_13);
			Class53.smethod_18(ref str, "MuaFree", gstruct49_0.int_78);
			Class53.smethod_18(ref str, "MuaKTC", gstruct49_0.int_77);
			Class53.smethod_18(ref str, "GanTenthuoc", gstruct49_0.int_75);
			Class53.smethod_18(ref str, "fNgamyBuff", gstruct49_0.int_101);
			Class53.smethod_18(ref str, "BomHPDiem", gstruct49_0.int_106);
			Class53.smethod_18(ref str, "BomMPDiem", gstruct49_0.int_107);
			Class53.smethod_18(ref str, "BomHPRatio", gstruct49_0.int_109);
			Class53.smethod_18(ref str, "BomM2HPRatio", gstruct49_0.int_110);
			Class53.smethod_18(ref str, "BomMPRatio", gstruct49_0.int_111);
			Class53.smethod_18(ref str, "BomM2MPRatio", gstruct49_0.int_112);
			Class53.smethod_18(ref str, "flagDoiPk", gstruct49_0.int_92);
			Class53.smethod_18(ref str, "flagXuongngua", gstruct49_0.int_93);
			Class53.smethod_18(ref str, "ChetNamIm", gstruct49_0.int_94);
			Class53.smethod_18(ref str, "fBaoBoss", gstruct49_0.int_1);
			Class53.smethod_18(ref str, "flagTuCastBua", gstruct49_0.int_119);
			int[] array = null;
			bool flag6 = gstruct49_0.int_3 != null;
			if (flag6)
			{
				array = new int[gstruct49_0.int_3.GetLength(0)];
				for (int j = 0; j < array.Length; j++)
				{
					array[j] = gstruct49_0.int_3[j, 0];
				}
			}
			Class53.smethod_18(ref str, "tbValueMagic", array);
			Class53.smethod_18(ref str, "flagDanhphim", gstruct49_0.int_100);
			Class53.smethod_18(ref str, "flagTuPT", gstruct49_0.int_103);
			Class53.smethod_18(ref str, "flagTiepcanF", gstruct49_0.int_95);
			Class53.smethod_18(ref str, "ValueTiepcan", gstruct49_0.int_96);
			Class53.smethod_18(ref str, "flagTamQuet_", gstruct49_0.int_98);
			Class53.smethod_18(ref str, "ValueTamQuet_s", gstruct49_0.int_99);
			Class53.smethod_18(ref str, "TDPKhiPk", gstruct49_0.int_104);
			Class53.smethod_18(ref str, "flagTuChayMuaThuocHoaSon", gstruct49_0.int_105);
			Class53.smethod_18(ref str, "fBanEvent", gstruct49_0.int_12);
			string text2 = string.Empty;
			bool flag7 = gstruct49_0.gstruct34_0 != null;
			if (flag7)
			{
				for (int k = 0; k < gstruct49_0.gstruct34_0.Length; k++)
				{
					bool flag8 = text2 != string.Empty;
					if (flag8)
					{
						text2 += "|";
					}
					bool flag9 = gstruct49_0.gstruct34_0[k].int_8 == null;
					if (flag9)
					{
						gstruct49_0.gstruct34_0[k].int_8 = new int[]
						{
							1,
							1
						};
					}
					string text3 = string.Empty;
					for (int l = 0; l < gstruct49_0.gstruct34_0[k].int_8.Length; l++)
					{
						bool flag10 = text3 != string.Empty;
						if (flag10)
						{
							text3 += "_";
						}
						text3 += gstruct49_0.gstruct34_0[k].int_8[l].ToString();
					}
					object obj = text2;
					text2 = string.Concat(new object[]
					{
						obj,
						gstruct49_0.gstruct34_0[k].string_0,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_6,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_0,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_5,
						'\u0001',
						text3,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_3,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_4,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_7,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_1,
						'\u0001',
						gstruct49_0.gstruct34_0[k].int_2
					});
				}
				text2 = Class12.smethod_16(text2);
			}
			str = str + "|MoTuiThuoc;" + text2;
			Class53.smethod_18(ref str, "HPTdp", gstruct49_0.int_113);
			Class53.smethod_18(ref str, "MPTdp", gstruct49_0.int_114);
			Class53.smethod_18(ref str, "flagUuTienBomCuuChuyen", gstruct49_0.int_108);
			Class53.smethod_18(ref str, "flagTDPKhiSoluongMau", gstruct49_0.int_115);
			Class53.smethod_18(ref str, "TDPSoluongMauConlai", gstruct49_0.int_116);
			Class53.smethod_18(ref str, "flagTDPKhiSoluongMana", gstruct49_0.int_117);
			Class53.smethod_18(ref str, "TDPSoluongManaConlai", gstruct49_0.int_118);
			Class53.smethod_18(ref str, "KieuDanh", gstruct49_0.int_88);
			Class53.smethod_18(ref str, "tbNguhanh", gstruct49_0.int_90);
			Class53.smethod_18(ref str, "tbMonPhai", gstruct49_0.int_91);
			Class53.smethod_18(ref str, "flagCuusatTheodanhsach", gstruct49_0.int_120);
			str = str + "|TenMauMuc2;" + Class12.smethod_16(gstruct49_0.string_16);
			str = str + "|TenManaMuc2;" + Class12.smethod_16(gstruct49_0.string_17);
			bool flag11 = gstruct49_0.string_18 != null && gstruct49_0.string_18.Length != 0;
			if (flag11)
			{
				string text4 = null;
				for (int m = 0; m < gstruct49_0.string_18.Length; m++)
				{
					bool flag12 = gstruct49_0.string_18[m] != null && gstruct49_0.string_18[m] != string.Empty;
					if (flag12)
					{
						bool flag13 = text4 != null;
						if (flag13)
						{
							text4 += "|";
						}
						text4 += gstruct49_0.string_18[m];
					}
				}
				bool flag14 = text4 != null;
				if (flag14)
				{
					str = str + "|DanhsachCuusat;" + Class12.smethod_16(text4);
				}
			}
			str = str + "|PassRuong;" + Class12.smethod_16(gstruct49_0.string_15);
			bool flag15 = gstruct49_0.string_19 != null && gstruct49_0.string_19.Length != 0;
			if (flag15)
			{
				string text5 = null;
				for (int n = 0; n < gstruct49_0.string_19.Length; n++)
				{
					bool flag16 = gstruct49_0.string_19[n] != null && gstruct49_0.string_19[n] != string.Empty;
					if (flag16)
					{
						bool flag17 = text5 != null;
						if (flag17)
						{
							text5 += "|";
						}
						text5 += gstruct49_0.string_19[n];
					}
				}
				bool flag18 = text5 != null;
				if (flag18)
				{
					str = str + "|PTDanhsach;" + Class12.smethod_16(text5);
				}
			}
			Class53.smethod_18(ref str, "PTflag", gstruct49_0.int_121);
			Class53.smethod_18(ref str, "fDenToado", gstruct49_0.int_125);
			Class53.smethod_18(ref str, "fTuchayToadoVA", gstruct49_0.int_122);
			Class53.smethod_18(ref str, "fClickNTT", gstruct49_0.int_123);
			Class53.smethod_18(ref str, "ClickNPCSolan", gstruct49_0.int_7);
			Class53.smethod_18(ref str, "tbClickNpcMenu", gstruct49_0.int_9);
			Class53.smethod_18(ref str, "fClickNpcMenu", gstruct49_0.int_8);
			str = str + "|ClickNPCName;" + Class12.smethod_16(gstruct49_0.string_0);
			Class53.smethod_18(ref str, "ClickNPCTocdo", gstruct49_0.int_10);
			Class53.smethod_18(ref str, "ClickLocTocdo", gstruct49_0.int_11);
			str = str + "|TenVatphamNpc;" + Class12.smethod_16(gstruct49_0.string_1);
			Class53.smethod_18(ref str, "MenuVatphamNpc", gstruct49_0.int_14);
			Class53.smethod_18(ref str, "fClickNPC_Sudung", gstruct49_0.int_13);
			Class53.smethod_18(ref str, "flagClickNpcSau", gstruct49_0.int_15);
			Class53.smethod_18(ref str, "fClickNPC_Nop", gstruct49_0.int_16);
			bool flag19 = gstruct49_0.gstruct31_0 != null;
			if (flag19)
			{
				string text6 = string.Empty;
				for (int num = 0; num < gstruct49_0.gstruct31_0.Length; num++)
				{
					bool flag20 = gstruct49_0.gstruct31_0[num].int_4 > 0 && gstruct49_0.gstruct31_0[num].string_0 != null && !(gstruct49_0.gstruct31_0[num].string_0 == string.Empty);
					if (flag20)
					{
						bool flag21 = text6 != null && text6 != string.Empty;
						if (flag21)
						{
							text6 += "|";
						}
						object obj2 = text6;
						text6 = string.Concat(new object[]
						{
							obj2,
							gstruct49_0.gstruct31_0[num].string_0,
							"=",
							gstruct49_0.gstruct31_0[num].int_4
						});
					}
				}
				bool flag22 = text6 != null && text6 != string.Empty;
				if (flag22)
				{
					str = str + "|ClickNPC_Nop;" + Class12.smethod_16(text6);
				}
			}
			Class53.smethod_18(ref str, "fClickNPC_MuaVP", gstruct49_0.int_17);
			bool flag23 = gstruct49_0.string_2 != null && gstruct49_0.string_2 != string.Empty;
			if (flag23)
			{
				str = str + "|ClickNPC_TabKTC;" + Class12.smethod_16(gstruct49_0.string_2);
			}
			bool flag24 = gstruct49_0.gstruct31_1.int_4 > 0 && gstruct49_0.gstruct31_1.string_0 != null && gstruct49_0.gstruct31_1.string_0 != string.Empty;
			if (flag24)
			{
				str = str + "|ClickNPC_Mua;" + Class12.smethod_16(gstruct49_0.gstruct31_1.string_0 + "=" + gstruct49_0.gstruct31_1.int_4.ToString());
			}
			Class53.smethod_18(ref str, "flagTrains", gstruct49_0.int_25);
			Class53.smethod_18(ref str, "flagTucheHT", gstruct49_0.int_26);
			Class53.smethod_18(ref str, "DanhQuaiTrain", gstruct49_0.int_27);
			Class53.smethod_18(ref str, "TDPHettien", gstruct49_0.int_28);
			Class53.smethod_18(ref str, "ToadoVong", gstruct49_0.int_29);
			Class53.smethod_18(ref str, "MapIDTrain", gstruct49_0.int_32);
			Class53.smethod_18(ref str, "XulyDosat", gstruct49_0.int_33);
			string text7 = null;
			bool flag25 = gstruct49_0.uint_0 != null;
			if (flag25)
			{
				for (int num2 = 0; num2 < gstruct49_0.uint_0.GetLength(0); num2++)
				{
					bool flag26 = text7 != null;
					if (flag26)
					{
						text7 += "|";
					}
					object obj3 = text7;
					text7 = string.Concat(new object[]
					{
						obj3,
						gstruct49_0.uint_0[num2, 0],
						";",
						gstruct49_0.uint_0[num2, 1]
					});
				}
				str = str + "|ToadoTrain;" + Class12.smethod_16(text7);
			}
			Class53.smethod_18(ref str, "SoDiemTrinhsat", gstruct49_0.int_21);
			Class53.smethod_18(ref str, "flagChayPkNguoidung", gstruct49_0.int_34);
			Class53.smethod_18(ref str, "fTinSu", gstruct49_0.int_20);
			Class53.smethod_18(ref str, "MapIDPk1", gstruct49_0.int_35);
			Class53.smethod_18(ref str, "MapIDPk2", gstruct49_0.int_36);
			text7 = null;
			bool flag27 = gstruct49_0.uint_2 != null;
			if (flag27)
			{
				for (int num3 = 0; num3 < gstruct49_0.uint_2.GetLength(0); num3++)
				{
					bool flag28 = text7 != null;
					if (flag28)
					{
						text7 += "|";
					}
					object obj4 = text7;
					text7 = string.Concat(new object[]
					{
						obj4,
						gstruct49_0.uint_2[num3, 0],
						";",
						gstruct49_0.uint_2[num3, 1]
					});
				}
				str = str + "|ToadoPk1;" + Class12.smethod_16(text7);
			}
			text7 = null;
			bool flag29 = gstruct49_0.uint_3 != null;
			if (flag29)
			{
				for (int num4 = 0; num4 < gstruct49_0.uint_3.GetLength(0); num4++)
				{
					bool flag30 = text7 != null;
					if (flag30)
					{
						text7 += "|";
					}
					object obj5 = text7;
					text7 = string.Concat(new object[]
					{
						obj5,
						gstruct49_0.uint_3[num4, 0],
						";",
						gstruct49_0.uint_3[num4, 1]
					});
				}
				str = str + "|ToadoPk2;" + Class12.smethod_16(text7);
			}
			bool flag31 = gstruct49_0.gstruct37_0 != null;
			if (flag31)
			{
				int[] array2 = new int[gstruct49_0.gstruct37_0.Length];
				int[] array3 = new int[gstruct49_0.gstruct37_0.Length];
				int[] array4 = new int[gstruct49_0.gstruct37_0.Length];
				for (int num5 = 0; num5 < gstruct49_0.gstruct37_0.Length; num5++)
				{
					array2[num5] = gstruct49_0.gstruct37_0[num5].int_0;
					array3[num5] = gstruct49_0.gstruct37_0[num5].int_2;
					array4[num5] = gstruct49_0.gstruct37_0[num5].int_3;
				}
				Class53.smethod_18(ref str, "tbFlagItemMagic", array2);
				Class53.smethod_18(ref str, "tbValueItemMagic", array3);
				Class53.smethod_18(ref str, "tbValueDong", array4);
			}
			bool flag32 = gstruct49_0.string_7 != null && gstruct49_0.string_7.Length != 0;
			if (flag32)
			{
				string text8 = null;
				for (int num6 = 0; num6 < gstruct49_0.string_7.Length; num6++)
				{
					bool flag33 = gstruct49_0.string_7[num6] != null && gstruct49_0.string_7[num6] != string.Empty;
					if (flag33)
					{
						bool flag34 = text8 != null;
						if (flag34)
						{
							text8 += "|";
						}
						text8 += gstruct49_0.string_7[num6];
					}
				}
				bool flag35 = text8 != null;
				if (flag35)
				{
					str = str + "|ThuocTocdoDanh;" + Class12.smethod_16(text8);
				}
			}
			bool flag36 = gstruct49_0.string_8 != null && gstruct49_0.string_8.Length != 0;
			if (flag36)
			{
				string text9 = null;
				for (int num7 = 0; num7 < gstruct49_0.string_8.Length; num7++)
				{
					bool flag37 = gstruct49_0.string_8[num7] != null && gstruct49_0.string_8[num7] != string.Empty;
					if (flag37)
					{
						bool flag38 = text9 != null;
						if (flag38)
						{
							text9 += "|";
						}
						text9 += gstruct49_0.string_8[num7];
					}
				}
				bool flag39 = text9 != null;
				if (flag39)
				{
					str = str + "|ThuocTocdoThuong;" + Class12.smethod_16(text9);
				}
			}
			bool flag40 = gstruct49_0.string_6 != null && gstruct49_0.string_6.Length != 0;
			if (flag40)
			{
				string text10 = null;
				for (int num8 = 0; num8 < gstruct49_0.string_6.Length; num8++)
				{
					bool flag41 = gstruct49_0.string_6[num8] != null && gstruct49_0.string_6[num8] != string.Empty;
					if (flag41)
					{
						bool flag42 = text10 != null;
						if (flag42)
						{
							text10 += "|";
						}
						text10 += gstruct49_0.string_6[num8];
					}
				}
				bool flag43 = text10 != null;
				if (flag43)
				{
					str = str + "|tbThuocLag;" + Class12.smethod_16(text10);
				}
			}
			bool flag44 = gstruct49_0.string_4 != null && gstruct49_0.string_4.Length != 0;
			if (flag44)
			{
				string text11 = null;
				for (int num9 = 0; num9 < gstruct49_0.string_4.Length; num9++)
				{
					bool flag45 = gstruct49_0.string_4[num9] != null && gstruct49_0.string_4[num9] != string.Empty;
					if (flag45)
					{
						bool flag46 = text11 != null;
						if (flag46)
						{
							text11 += "|";
						}
						text11 += gstruct49_0.string_4[num9];
					}
				}
				bool flag47 = text11 != null;
				if (flag47)
				{
					str = str + "|IBadlist;" + Class12.smethod_16(text11);
				}
			}
			bool flag48 = gstruct49_0.gstruct42_0 != null && gstruct49_0.gstruct42_0.Length != 0;
			if (flag48)
			{
				string text12 = null;
				for (int num10 = 0; num10 < gstruct49_0.gstruct42_0.Length; num10++)
				{
					GStruct41[] gstruct41_ = gstruct49_0.gstruct42_0[num10].gstruct41_0;
					bool flag49 = gstruct41_ == null;
					if (!flag49)
					{
						string text13 = null;
						for (int num11 = 0; num11 < gstruct41_.Length; num11++)
						{
							bool flag50 = text13 != null;
							if (flag50)
							{
								text13 += "/";
							}
							text13 = text13 + gstruct41_[num11].int_0.ToString() + "=" + gstruct41_[num11].string_0;
						}
						bool flag51 = text12 != null;
						if (flag51)
						{
							text12 += "|";
						}
						text12 = text12 + gstruct49_0.gstruct42_0[num10].int_0.ToString() + ":" + text13;
					}
				}
				bool flag52 = text12 != null;
				if (flag52)
				{
					str = str + "|AscBomThuoc;" + Class12.smethod_16(text12);
				}
			}
			bool flag53 = string_27 != null && !(string_27 == string.Empty);
			if (flag53)
			{
				string[] array5 = Class12.smethod_14(string_27, '\\');
				Class12.smethod_23(array5[0]);
				Class12.smethod_34(string_27, str, 3);
			}
			else
			{
				Class12.smethod_23(Class53.string_10);
				Class12.smethod_34(Class53.string_10 + "\\" + Class12.smethod_44(gstruct49_0.string_22) + ".cfg", str, 3);
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000876F0 File Offset: 0x000858F0
		public static int[] smethod_14(int int_11)
		{
			int[] array = new int[5];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Class53.int_9[int_11, i];
			}
			return array;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00087730 File Offset: 0x00085930
		public static int[] smethod_15(int int_11)
		{
			int[] array = new int[10];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Class53.int_10[int_11, i];
			}
			return array;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00087770 File Offset: 0x00085970
		public static int[] smethod_16(GStruct49 gstruct49_0, string string_27 = null)
		{
			bool flag = string_27 == null || string_27 == string.Empty;
			if (flag)
			{
				string_27 = Class77.smethod_18(gstruct49_0, null);
			}
			int[] array = new int[7];
			string text = string_27;
			string a = text;
			if (!(a == "NGUDOC"))
			{
				if (!(a == "THIENNHAN"))
				{
					if (a == "CONLON")
					{
						bool flag2 = Class77.smethod_16(gstruct49_0, 394) > 0;
						if (flag2)
						{
							array[0] = 394;
						}
						bool flag3 = Class77.smethod_16(gstruct49_0, 392) > 0;
						if (flag3)
						{
							array[1] = 392;
						}
						bool flag4 = Class77.smethod_16(gstruct49_0, 174) > 0;
						if (flag4)
						{
							array[2] = 174;
						}
						bool flag5 = Class77.smethod_16(gstruct49_0, 393) > 0;
						if (flag5)
						{
							array[3] = 393;
						}
						bool flag6 = Class77.smethod_16(gstruct49_0, 175) > 0;
						if (flag6)
						{
							array[4] = 175;
						}
						bool flag7 = Class77.smethod_16(gstruct49_0, 90) > 0;
						if (flag7)
						{
							array[5] = 90;
						}
					}
				}
				else
				{
					bool flag8 = Class77.smethod_16(gstruct49_0, 391) > 0;
					if (flag8)
					{
						array[0] = 391;
					}
					bool flag9 = Class77.smethod_16(gstruct49_0, 136) > 0;
					if (flag9)
					{
						array[1] = 136;
					}
					bool flag10 = Class77.smethod_16(gstruct49_0, 137) > 0;
					if (flag10)
					{
						array[2] = 137;
					}
					bool flag11 = Class77.smethod_16(gstruct49_0, 140) > 0;
					if (flag11)
					{
						array[3] = 140;
					}
					bool flag12 = Class77.smethod_16(gstruct49_0, 364) > 0;
					if (flag12)
					{
						array[4] = 364;
					}
					bool flag13 = Class77.smethod_16(gstruct49_0, 143) > 0;
					if (flag13)
					{
						array[5] = 143;
					}
				}
			}
			else
			{
				bool flag14 = Class77.smethod_16(gstruct49_0, 73) > 0;
				if (flag14)
				{
					array[0] = 73;
				}
				bool flag15 = Class77.smethod_16(gstruct49_0, 390) > 0;
				if (flag15)
				{
					array[1] = 390;
				}
				bool flag16 = Class77.smethod_16(gstruct49_0, 356) > 0;
				if (flag16)
				{
					array[2] = 356;
				}
				bool flag17 = Class77.smethod_16(gstruct49_0, 72) > 0;
				if (flag17)
				{
					array[3] = 72;
				}
				bool flag18 = Class77.smethod_16(gstruct49_0, 64) > 0;
				if (flag18)
				{
					array[4] = 64;
				}
				bool flag19 = Class77.smethod_16(gstruct49_0, 70) > 0;
				if (flag19)
				{
					array[5] = 70;
				}
				bool flag20 = Class77.smethod_16(gstruct49_0, 67) > 0;
				if (flag20)
				{
					array[6] = 67;
				}
			}
			return array;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000879DC File Offset: 0x00085BDC
		public static int[,] smethod_17(string string_27)
		{
			int[,] result = null;
			if (!(string_27 == "CONLON"))
			{
				if (!(string_27 == "THIENNHAN"))
				{
					if (string_27 == "NGUDOC")
					{
						int[,] array = new int[7, 2];
						Class11.smethod_4(array, 246342);
						result = array;
					}
				}
				else
				{
					int[,] array2 = new int[6, 2];
					Class11.smethod_4(array2, 246411);
					result = array2;
				}
			}
			else
			{
				int[,] array3 = new int[6, 2];
				Class11.smethod_4(array3, 246472);
				result = array3;
			}
			return result;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00087A74 File Offset: 0x00085C74
		private static void smethod_18(ref string string_27, string string_28, object object_0)
		{
			try
			{
				int[] array = null;
				bool flag = object_0 == null;
				if (flag)
				{
					object_0 = string.Empty;
				}
				string[] array2 = typeof(int).ToString().Split(new char[]
				{
					'.'
				});
				string value = array2[array2.Length - 1].ToUpper();
				string text = object_0.GetType().ToString().ToUpper();
				bool flag2 = 0 < text.IndexOf(value);
				if (flag2)
				{
					int[] array3;
					if (Class12.smethod_1(text, "[") > 0)
					{
						array3 = (int[])object_0;
					}
					else
					{
						(array3 = new int[1])[0] = Class12.smethod_11(object_0.ToString());
					}
					array = array3;
				}
				bool flag3 = string_27 != null && string_27 != string.Empty;
				if (flag3)
				{
					string_27 += "|";
				}
				string_27 += string_28;
				bool flag4 = array != null;
				if (flag4)
				{
					for (int i = 0; i < array.Length; i++)
					{
						string_27 = string_27 + ";" + array[i].ToString();
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00087BA8 File Offset: 0x00085DA8
		public static int[] smethod_19(string[] string_27, string string_28, int[] int_11)
		{
			string_28 = string_28.ToUpper();
			bool flag = string_27 != null && string_27.Length != 0;
			if (flag)
			{
				for (int i = 0; i < string_27.Length; i++)
				{
					bool flag2 = string_27[i] == null || !(string_27[i] != "");
					if (!flag2)
					{
						string[] array = string_27[i].Split(new char[]
						{
							';'
						});
						bool flag3 = !(array[0].Trim().ToUpper() == string_28);
						if (!flag3)
						{
							int[] array2 = null;
							bool flag4 = array.Length > 1;
							if (flag4)
							{
								array2 = new int[array.Length - 1];
								for (int j = 1; j < array.Length; j++)
								{
									bool flag5 = array[j] != null && !(array[j] == string.Empty);
									if (!flag5)
									{
										array2 = null;
										break;
									}
									array2[j - 1] = Class12.smethod_11(array[j].Trim());
								}
							}
							bool flag6 = array2 == null;
							if (flag6)
							{
								break;
							}
							return array2;
						}
					}
				}
			}
			return int_11;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00087CCC File Offset: 0x00085ECC
		public static uint[,] smethod_20(string[] string_27, string string_28, uint[,] uint_14)
		{
			string_28 = string_28.ToUpper();
			bool flag = string_27 != null && string_27.Length != 0;
			if (flag)
			{
				for (int i = 0; i < string_27.Length; i++)
				{
					bool flag2 = string_27[i] == null || !(string_27[i] != "");
					if (!flag2)
					{
						string[] array = string_27[i].Split(new char[]
						{
							';'
						});
						bool flag3 = !(array[0].Trim().ToUpper() == string_28);
						if (!flag3)
						{
							uint[,] array2 = null;
							bool flag4 = array.Length > 1;
							if (flag4)
							{
								array2 = new uint[array.Length - 1, 2];
								int num = 0;
								for (int j = 1; j < array.Length; j++)
								{
									string text = array[j].Trim();
									bool flag5 = !(text == "");
									if (flag5)
									{
										string[] array3 = text.Split(new char[]
										{
											','
										});
										bool flag6 = array3.Length > 1;
										if (flag6)
										{
											array2[num, 0] = Class12.smethod_12(array3[0].Trim());
											array2[num, 1] = Class12.smethod_12(array3[1].Trim());
										}
										num++;
									}
								}
								bool flag7 = num == 0;
								if (flag7)
								{
									array2 = null;
								}
								else
								{
									bool flag8 = num < array2.GetLength(0);
									if (flag8)
									{
										uint[,] array4 = new uint[num, 2];
										for (int k = 0; k < num; k++)
										{
											array4[k, 0] = array2[k, 0];
											array4[k, 1] = array2[k, 1];
										}
										array2 = array4;
									}
								}
							}
							return array2;
						}
					}
				}
			}
			return uint_14;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00087EA0 File Offset: 0x000860A0
		public static string[] smethod_21(string[] string_27, string string_28, string[] string_29, bool bool_2 = false)
		{
			string_28 = string_28.ToUpper();
			bool flag = string_27 != null && string_27.Length != 0;
			if (flag)
			{
				for (int i = 0; i < string_27.Length; i++)
				{
					bool flag2 = string_27[i] == null || !(string_27[i] != "");
					if (!flag2)
					{
						string[] array = string_27[i].Split(new char[]
						{
							';'
						});
						bool flag3 = !(array[0].Trim().ToUpper() == string_28);
						if (!flag3)
						{
							bool flag4 = array.Length < 2;
							if (flag4)
							{
								return null;
							}
							string[] array2 = new string[array.Length - 1];
							int num = 0;
							for (int j = 1; j < array.Length; j++)
							{
								string text = array[j].Trim();
								bool flag5 = !bool_2 || !(text == "");
								if (flag5)
								{
									array2[num] = text;
									num++;
								}
							}
							bool flag6 = num == 0;
							if (flag6)
							{
								return null;
							}
							bool flag7 = num == array2.Length;
							if (flag7)
							{
								return array2;
							}
							string[] array3 = new string[num];
							for (int k = 0; k < num; k++)
							{
								array3[k] = array2[k];
							}
							return array3;
						}
					}
				}
			}
			return string_29;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00088008 File Offset: 0x00086208
		private static bool smethod_22(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_35(gstruct49_0.int_136, Class53.gstruct51_269.string_0);
			uint[] array = Class22.smethod_64(gstruct49_0.int_137, num, ".text|slowfbeq|default", false);
			bool flag = array != null && array[0] > 0U;
			bool result;
			if (flag)
			{
				int num2 = 0;
				byte[] array2 = new byte[array[0]];
				bool flag2 = Class22.ReadProcessMemory(gstruct49_0.int_137, num + array[1], array2, array2.Length, ref num2);
				if (flag2)
				{
					Class102.smethod_4(array[1], array2, ref Class53.gstruct51_269, 0L, 0U, 0, false);
					result = (Class53.gstruct51_269.uint_0 > 0U);
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
			return result;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000880B0 File Offset: 0x000862B0
		public static bool smethod_23(GStruct49 gstruct49_0, bool bool_2)
		{
			bool flag = Class53.gstruct51_269.uint_0 == 0U && !Class53.smethod_22(Form1.gstruct49_0[0]);
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num = 0;
				byte[] array2;
				if (!bool_2)
				{
					byte[] array = new byte[2];
					array[0] = 15;
					array2 = array;
					array[1] = 135;
				}
				else
				{
					byte[] array3 = new byte[2];
					array3[0] = 144;
					array2 = array3;
					array3[1] = 233;
				}
				byte[] array4 = array2;
				uint num2 = Class22.smethod_35(gstruct49_0.int_136, Class53.gstruct51_269.string_0);
				bool flag2 = num2 == 0U;
				result = (!flag2 && Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_269.uint_0, array4, array4.Length, ref num));
			}
			return result;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00088164 File Offset: 0x00086364
		public static void smethod_24(bool bool_2)
		{
			string str = "SYSTEM\\CurrentControlSet\\services\\Tcpip\\Parameters";
			string text = "ForwardBufferMemory";
			string text2 = "NumForwardPackets";
			string text3 = "DisableTaskOffload";
			string text4 = "SOFTWARE\\Microsoft\\MSMQ\\Parameters";
			string text5 = "TCPNoDelay";
			string str2 = str + "\\Interfaces";
			string text6 = "TcpAckFrequency";
			string[] array = Class62.smethod_8(str2, false);
			bool flag = !bool_2;
			if (flag)
			{
				Class62.smethod_12(str, text, 0);
				Class62.smethod_12(str, text2, 0);
				Class62.smethod_12(str, text3, 0);
				Class62.smethod_12(str, text5, 0);
				bool flag2 = array != null;
				if (flag2)
				{
					for (int i = 0; i < array.Length; i++)
					{
						Class62.smethod_12(str2 + "\\" + array[i], text6, 0);
					}
				}
				Class62.smethod_12(text4, text5, 0);
			}
			else
			{
				int num = 0;
				int num2 = 0;
				int num3 = 582;
				int num4 = 148992;
				try
				{
					NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
					NetworkInterface[] array2 = allNetworkInterfaces;
					foreach (NetworkInterface networkInterface in array2)
					{
						bool flag3 = networkInterface.Supports(NetworkInterfaceComponent.IPv4);
						if (flag3)
						{
							IPInterfaceProperties ipproperties = networkInterface.GetIPProperties();
							IPv4InterfaceProperties ipv4Properties = ipproperties.GetIPv4Properties();
							bool flag4 = ipv4Properties != null;
							if (flag4)
							{
								num += ipv4Properties.Mtu;
								num2++;
							}
						}
					}
				}
				catch
				{
				}
				bool flag5 = num2 > 0;
				if (flag5)
				{
					num /= num2;
					num3 = num * 100;
					num3 /= 256;
					num4 = num3 * 256;
				}
				Class62.smethod_10(str, text2, num3, "DWORD", 0);
				Class62.smethod_10(str, text, num4, "DWORD", 0);
				Class62.smethod_10(str, text3, 0, "DWORD", 0);
				Class62.smethod_10(str, text5, 1, "DWORD", 0);
				bool flag6 = array != null;
				if (flag6)
				{
					for (int k = 0; k < array.Length; k++)
					{
						Class62.smethod_10(str2 + "\\" + array[k], text6, 1, "DWORD", 0);
					}
				}
				Class62.smethod_10(text4, text5, 1, "DWORD", 0);
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000883B8 File Offset: 0x000865B8
		public static void smethod_25(string string_27, string string_28, bool bool_2 = false, string string_29 = "", int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0)
		{
			try
			{
				Class12.smethod_34(string_27, string_28, 1);
				if (bool_2)
				{
					string text = "Software\\Microsoft\\Notepad";
					bool flag = string_29 != "";
					if (flag)
					{
						Class62.smethod_10(text, "lfFaceName", string_29, "", 1);
					}
					bool flag2 = int_11 != 0;
					if (flag2)
					{
						Class62.smethod_10(text, "iPointSize", int_11 * 10, "DWORD", 1);
					}
					bool flag3 = int_12 != 0;
					if (flag3)
					{
						Class62.smethod_10(text, "iWindowPosDX", int_12, "DWORD", 1);
					}
					bool flag4 = int_13 != 0;
					if (flag4)
					{
						Class62.smethod_10(text, "iWindowPosDY", int_13, "DWORD", 1);
					}
					bool flag5 = int_14 != 0;
					if (flag5)
					{
						Class62.smethod_10(text, "iWindowPosX", int_14, "DWORD", 1);
					}
					bool flag6 = int_15 != 0;
					if (flag6)
					{
						Class62.smethod_10(text, "iWindowPosY", int_15, "DWORD", 1);
					}
					Class62.smethod_10(text, "fWrap", 0, "DWORD", 1);
					Class62.smethod_10(text, "lfItalic", 0, "DWORD", 1);
					Class22.smethod_40("Notepad.exe", "", string_27, 0, false, false);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00088520 File Offset: 0x00086720
		public static string smethod_26(string string_27 = "", string string_28 = "", string string_29 = "", string string_30 = "")
		{
			string result = "";
			string initialDirectory = string_27;
			bool flag = string_27 == "";
			if (flag)
			{
				initialDirectory = Class53.string_8;
			}
			bool flag2 = string_29 == "";
			if (flag2)
			{
				string_29 = "*.txt";
			}
			string text = string.Concat(new string[]
			{
				"Request files (",
				string_29,
				")|",
				string_29,
				"|All files (*.*)|*.*"
			});
			bool flag3 = string_30 != null && string_30 != "";
			if (flag3)
			{
				bool flag4 = string_30.IndexOf("|") < 0;
				if (flag4)
				{
					string_30 = string_30 + "|" + string_30;
				}
				text = string_30 + "|" + text;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = initialDirectory;
			openFileDialog.Filter = text;
			openFileDialog.FileName = string_28;
			openFileDialog.FilterIndex = 1;
			openFileDialog.RestoreDirectory = true;
			bool flag5 = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag5)
			{
				result = openFileDialog.FileName;
			}
			return result;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00088628 File Offset: 0x00086828
		public static string smethod_27(string string_27 = "", string string_28 = "")
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			string result = string.Empty;
			string text = string.Empty;
			bool flag = string_28 != null;
			if (flag)
			{
				string[] array = string_28.Split(new char[]
				{
					'.'
				});
				text = array[array.Length - 1];
			}
			text = ((!(text == string.Empty)) ? string.Concat(new string[]
			{
				text,
				" file (*.",
				text,
				")|*.",
				text
			}) : "xyz files (*.xyz)|*.xyz");
			saveFileDialog.Filter = text + "|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.InitialDirectory = string_27;
			saveFileDialog.FileName = string_28;
			bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag2)
			{
				Stream stream;
				bool flag3 = (stream = saveFileDialog.OpenFile()) != null;
				if (flag3)
				{
					result = saveFileDialog.FileName;
					stream.Close();
				}
			}
			return result;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00088728 File Offset: 0x00086928
		public static string smethod_28(string string_27)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
			{
				SelectedPath = string_27,
				ShowNewFolderButton = true
			};
			DialogResult dialogResult = folderBrowserDialog.ShowDialog();
			bool flag = dialogResult != DialogResult.OK;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				result = folderBrowserDialog.SelectedPath;
			}
			return result;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00088771 File Offset: 0x00086971
		public static void smethod_29()
		{
		}

		// Token: 0x0400017E RID: 382
		public static int int_0 = 1500;

		// Token: 0x0400017F RID: 383
		public static byte[] byte_0 = Class12.smethod_46("_mouse drag", true);

		// Token: 0x04000180 RID: 384
		public static uint[] uint_0 = null;

		// Token: 0x04000181 RID: 385
		public static uint uint_1 = 0U;

		// Token: 0x04000182 RID: 386
		public static uint uint_2 = 3U;

		// Token: 0x04000183 RID: 387
		public static uint uint_3 = 4U;

		// Token: 0x04000184 RID: 388
		public static uint uint_4 = 5U;

		// Token: 0x04000185 RID: 389
		public static uint uint_5 = 6U;

		// Token: 0x04000186 RID: 390
		public static string string_0 = null;

		// Token: 0x04000187 RID: 391
		public static string string_1 = null;

		// Token: 0x04000188 RID: 392
		public static string string_2 = null;

		// Token: 0x04000189 RID: 393
		public static GStruct51[] gstruct51_0 = null;

		// Token: 0x0400018A RID: 394
		public static GStruct50[] gstruct50_0 = null;

		// Token: 0x0400018B RID: 395
		public static string string_3 = Class12.smethod_71("C/Z3Cwl3DHKN8Y70Ts2vSAUA");

		// Token: 0x0400018C RID: 396
		public static string string_4 = Class12.smethod_71("83dz8/H0cwUA");

		// Token: 0x0400018D RID: 397
		public static string string_5 = Class12.smethod_71("c0nMywhOTM7wyU/MLCkqBQA=");

		// Token: 0x0400018E RID: 398
		public static string[] string_6 = Class12.smethod_15(Class62.smethod_6(Class53.string_5, 0, "")).Split(new char[]
		{
			'|'
		});

		// Token: 0x0400018F RID: 399
		public static char[] char_0 = new char[]
		{
			'ᓦ',
			'ᓘ',
			'ᓝ',
			'ᓓ',
			'ᓘ',
			'ᓡ'
		};

		// Token: 0x04000190 RID: 400
		public static char[] char_1 = new char[]
		{
			'ᓰ',
			'ᓶ',
			'ᓰ',
			'ᓱ',
			'ᓢ',
			'ᓪ',
			'ᒰ',
			'ᒯ',
			'ᓙ',
			'ᓡ',
			'ᓯ',
			'ᓦ',
			'ᓳ',
			'ᓢ',
			'ᓯ',
			'ᓰ',
			'ᓙ',
			'ᓢ',
			'ᓱ',
			'ᓠ'
		};

		// Token: 0x04000191 RID: 401
		public static string string_7 = '\r'.ToString() + "\n";

		// Token: 0x04000192 RID: 402
		public static string string_8 = Directory.GetCurrentDirectory().ToString();

		// Token: 0x04000193 RID: 403
		public static string string_9 = Class53.string_8 + "\\Config";

		// Token: 0x04000194 RID: 404
		public static string string_10 = Class53.string_9 + "\\AllUser";

		// Token: 0x04000195 RID: 405
		public static string string_11 = Class53.string_9 + "\\Combo";

		// Token: 0x04000196 RID: 406
		public static string string_12 = Class53.string_9 + "\\Skill";

		// Token: 0x04000197 RID: 407
		public static string string_13 = Class53.string_9 + "\\OfflineName.txt";

		// Token: 0x04000198 RID: 408
		public static string string_14 = Class53.string_9 + "\\Medicin.txt";

		// Token: 0x04000199 RID: 409
		public static string string_15 = Class53.string_9 + "\\tbMayphu.txt";

		// Token: 0x0400019A RID: 410
		public static string string_16 = Class53.string_8 + "\\Map";

		// Token: 0x0400019B RID: 411
		public static string string_17 = "GameData.dat";

		// Token: 0x0400019C RID: 412
		public static string string_18 = string.Empty;

		// Token: 0x0400019D RID: 413
		public static string string_19 = string.Empty;

		// Token: 0x0400019E RID: 414
		public static string string_20 = "GameSum";

		// Token: 0x0400019F RID: 415
		public static string string_21 = "Sword3 Class";

		// Token: 0x040001A0 RID: 416
		public static string string_22 = "Qu¶ H";

		// Token: 0x040001A1 RID: 417
		public static int int_1 = 600;

		// Token: 0x040001A2 RID: 418
		public static int[] int_2 = new int[]
		{
			7,
			8,
			9,
			10,
			11,
			12,
			22,
			26,
			27,
			28,
			54,
			58,
			59,
			60,
			63,
			64,
			65,
			66
		};

		// Token: 0x040001A3 RID: 419
		public static int[] int_3 = new int[]
		{
			35300,
			33300,
			32300,
			31300,
			30300,
			28300,
			27300,
			26300,
			25300,
			24300,
			22300,
			21300,
			20300,
			19300,
			18300,
			17300,
			16300,
			16300,
			15300,
			15300
		};

		// Token: 0x040001A4 RID: 420
		public static int[] int_4 = new int[]
		{
			45300,
			43300,
			42300,
			40300,
			39300,
			37300,
			36300,
			35300,
			33300,
			32300,
			30300,
			29300,
			27300,
			26300,
			25300,
			24300,
			23300,
			22300,
			21300,
			20300
		};

		// Token: 0x040001A5 RID: 421
		public static uint[] uint_6 = new uint[]
		{
			1749327351U,
			2228031257U,
			4243888759U,
			1673389038U,
			2125211990U,
			2733778391U,
			1348791440U,
			3009527130U,
			3847658661U,
			2579403001U,
			1940221416U,
			2863624449U,
			2043181059U,
			2529356268U,
			3058263379U,
			1197734020U,
			2569642226U,
			2059715740U,
			2321403062U,
			3672844282U,
			63513748U,
			692461516U,
			2531711669U,
			790030748U
		};

		// Token: 0x040001A6 RID: 422
		public static string[] string_23 = new string[]
		{
			"None",
			"Đứng im",
			"Đi bộ",
			"Chạy",
			"Nhảy",
			"Buff",
			"Đánh phép thuật",
			"Đánh",
			"Ngồi",
			"Bị đánh",
			"Chết",
			"Phòng thủ",
			"Nghỉ ngơi",
			"SpecialSkill",
			"Special1",
			"Special2",
			"Special3",
			"Special4",
			"Chạy tấn công",
			"Đánh liên tiếp",
			"Nhảy tấn công",
			"Về dưỡng sức"
		};

		// Token: 0x040001A7 RID: 423
		public static string[,] string_24;

		// Token: 0x040001A8 RID: 424
		public static GStruct44[] gstruct44_0;

		// Token: 0x040001A9 RID: 425
		public static uint uint_7;

		// Token: 0x040001AA RID: 426
		public static uint uint_8;

		// Token: 0x040001AB RID: 427
		public static uint uint_9;

		// Token: 0x040001AC RID: 428
		public static uint uint_10;

		// Token: 0x040001AD RID: 429
		public static uint uint_11;

		// Token: 0x040001AE RID: 430
		public static uint uint_12;

		// Token: 0x040001AF RID: 431
		public static int int_5;

		// Token: 0x040001B0 RID: 432
		public static int int_6;

		// Token: 0x040001B1 RID: 433
		public static uint[] uint_13;

		// Token: 0x040001B2 RID: 434
		public static GStruct51 gstruct51_1;

		// Token: 0x040001B3 RID: 435
		public static GStruct51 gstruct51_2;

		// Token: 0x040001B4 RID: 436
		public static GStruct51 gstruct51_3;

		// Token: 0x040001B5 RID: 437
		public static GStruct51 gstruct51_4;

		// Token: 0x040001B6 RID: 438
		public static GStruct51 gstruct51_5;

		// Token: 0x040001B7 RID: 439
		public static GStruct51 gstruct51_6;

		// Token: 0x040001B8 RID: 440
		public static GStruct51 gstruct51_7;

		// Token: 0x040001B9 RID: 441
		public static GStruct51 gstruct51_8;

		// Token: 0x040001BA RID: 442
		public static GStruct51 gstruct51_9;

		// Token: 0x040001BB RID: 443
		public static GStruct51 gstruct51_10;

		// Token: 0x040001BC RID: 444
		public static GStruct51 gstruct51_11;

		// Token: 0x040001BD RID: 445
		public static GStruct51 gstruct51_12;

		// Token: 0x040001BE RID: 446
		public static GStruct51 gstruct51_13;

		// Token: 0x040001BF RID: 447
		public static GStruct51 gstruct51_14;

		// Token: 0x040001C0 RID: 448
		public static GStruct51 gstruct51_15;

		// Token: 0x040001C1 RID: 449
		public static GStruct51 gstruct51_16;

		// Token: 0x040001C2 RID: 450
		public static GStruct51 gstruct51_17;

		// Token: 0x040001C3 RID: 451
		public static GStruct51 gstruct51_18;

		// Token: 0x040001C4 RID: 452
		public static GStruct51 gstruct51_19;

		// Token: 0x040001C5 RID: 453
		public static GStruct51 gstruct51_20;

		// Token: 0x040001C6 RID: 454
		public static GStruct51 gstruct51_21;

		// Token: 0x040001C7 RID: 455
		public static GStruct51 gstruct51_22;

		// Token: 0x040001C8 RID: 456
		public static GStruct51 gstruct51_23;

		// Token: 0x040001C9 RID: 457
		public static GStruct51 gstruct51_24;

		// Token: 0x040001CA RID: 458
		public static GStruct51 gstruct51_25;

		// Token: 0x040001CB RID: 459
		public static GStruct51 gstruct51_26;

		// Token: 0x040001CC RID: 460
		public static GStruct51 gstruct51_27;

		// Token: 0x040001CD RID: 461
		public static GStruct51 gstruct51_28;

		// Token: 0x040001CE RID: 462
		public static GStruct51 gstruct51_29;

		// Token: 0x040001CF RID: 463
		public static GStruct51 gstruct51_30;

		// Token: 0x040001D0 RID: 464
		public static GStruct51 gstruct51_31;

		// Token: 0x040001D1 RID: 465
		public static GStruct51 gstruct51_32;

		// Token: 0x040001D2 RID: 466
		public static GStruct51 gstruct51_33;

		// Token: 0x040001D3 RID: 467
		public static GStruct51 gstruct51_34;

		// Token: 0x040001D4 RID: 468
		public static GStruct51 gstruct51_35;

		// Token: 0x040001D5 RID: 469
		public static GStruct51 gstruct51_36;

		// Token: 0x040001D6 RID: 470
		public static GStruct51 gstruct51_37;

		// Token: 0x040001D7 RID: 471
		public static GStruct51 gstruct51_38;

		// Token: 0x040001D8 RID: 472
		public static GStruct51 gstruct51_39;

		// Token: 0x040001D9 RID: 473
		public static GStruct51 gstruct51_40;

		// Token: 0x040001DA RID: 474
		public static GStruct51 gstruct51_41;

		// Token: 0x040001DB RID: 475
		public static GStruct51 gstruct51_42;

		// Token: 0x040001DC RID: 476
		public static GStruct51 gstruct51_43;

		// Token: 0x040001DD RID: 477
		public static GStruct51 gstruct51_44;

		// Token: 0x040001DE RID: 478
		public static GStruct51 gstruct51_45;

		// Token: 0x040001DF RID: 479
		public static GStruct51 gstruct51_46;

		// Token: 0x040001E0 RID: 480
		public static GStruct51 gstruct51_47;

		// Token: 0x040001E1 RID: 481
		public static GStruct51 gstruct51_48;

		// Token: 0x040001E2 RID: 482
		public static GStruct51 gstruct51_49;

		// Token: 0x040001E3 RID: 483
		public static GStruct51 gstruct51_50;

		// Token: 0x040001E4 RID: 484
		public static GStruct51 gstruct51_51;

		// Token: 0x040001E5 RID: 485
		public static GStruct51 gstruct51_52;

		// Token: 0x040001E6 RID: 486
		public static GStruct51 gstruct51_53;

		// Token: 0x040001E7 RID: 487
		public static GStruct51 gstruct51_54;

		// Token: 0x040001E8 RID: 488
		public static GStruct51 gstruct51_55;

		// Token: 0x040001E9 RID: 489
		public static GStruct51 gstruct51_56;

		// Token: 0x040001EA RID: 490
		public static GStruct51 gstruct51_57;

		// Token: 0x040001EB RID: 491
		public static GStruct51 gstruct51_58;

		// Token: 0x040001EC RID: 492
		public static GStruct51 gstruct51_59;

		// Token: 0x040001ED RID: 493
		public static GStruct51 gstruct51_60;

		// Token: 0x040001EE RID: 494
		public static GStruct51 gstruct51_61;

		// Token: 0x040001EF RID: 495
		public static GStruct51 gstruct51_62;

		// Token: 0x040001F0 RID: 496
		public static GStruct51 gstruct51_63;

		// Token: 0x040001F1 RID: 497
		public static GStruct51 gstruct51_64;

		// Token: 0x040001F2 RID: 498
		public static GStruct51 gstruct51_65;

		// Token: 0x040001F3 RID: 499
		public static GStruct51 gstruct51_66;

		// Token: 0x040001F4 RID: 500
		public static GStruct51 gstruct51_67;

		// Token: 0x040001F5 RID: 501
		public static GStruct51 gstruct51_68;

		// Token: 0x040001F6 RID: 502
		public static GStruct51 gstruct51_69;

		// Token: 0x040001F7 RID: 503
		public static GStruct51 gstruct51_70;

		// Token: 0x040001F8 RID: 504
		public static GStruct51 gstruct51_71;

		// Token: 0x040001F9 RID: 505
		public static GStruct51 gstruct51_72;

		// Token: 0x040001FA RID: 506
		public static GStruct51 gstruct51_73;

		// Token: 0x040001FB RID: 507
		public static GStruct51 gstruct51_74;

		// Token: 0x040001FC RID: 508
		public static GStruct51 gstruct51_75;

		// Token: 0x040001FD RID: 509
		public static GStruct51 gstruct51_76;

		// Token: 0x040001FE RID: 510
		public static GStruct51 gstruct51_77;

		// Token: 0x040001FF RID: 511
		public static GStruct51 gstruct51_78;

		// Token: 0x04000200 RID: 512
		public static GStruct51 gstruct51_79;

		// Token: 0x04000201 RID: 513
		public static GStruct51 gstruct51_80;

		// Token: 0x04000202 RID: 514
		public static GStruct51 gstruct51_81;

		// Token: 0x04000203 RID: 515
		public static GStruct51 gstruct51_82;

		// Token: 0x04000204 RID: 516
		public static GStruct51 gstruct51_83;

		// Token: 0x04000205 RID: 517
		public static GStruct51 gstruct51_84;

		// Token: 0x04000206 RID: 518
		public static GStruct51 gstruct51_85;

		// Token: 0x04000207 RID: 519
		public static GStruct51 gstruct51_86;

		// Token: 0x04000208 RID: 520
		public static GStruct51 gstruct51_87;

		// Token: 0x04000209 RID: 521
		public static GStruct51 gstruct51_88;

		// Token: 0x0400020A RID: 522
		public static GStruct51 gstruct51_89;

		// Token: 0x0400020B RID: 523
		public static GStruct51 gstruct51_90;

		// Token: 0x0400020C RID: 524
		public static GStruct51 gstruct51_91;

		// Token: 0x0400020D RID: 525
		public static GStruct51 gstruct51_92;

		// Token: 0x0400020E RID: 526
		public static GStruct51 gstruct51_93;

		// Token: 0x0400020F RID: 527
		public static GStruct51 gstruct51_94;

		// Token: 0x04000210 RID: 528
		public static GStruct51 gstruct51_95;

		// Token: 0x04000211 RID: 529
		public static GStruct51 gstruct51_96;

		// Token: 0x04000212 RID: 530
		public static GStruct51 gstruct51_97;

		// Token: 0x04000213 RID: 531
		public static GStruct51 gstruct51_98;

		// Token: 0x04000214 RID: 532
		public static GStruct51 gstruct51_99;

		// Token: 0x04000215 RID: 533
		public static GStruct51 gstruct51_100;

		// Token: 0x04000216 RID: 534
		public static GStruct51 gstruct51_101;

		// Token: 0x04000217 RID: 535
		public static GStruct51 gstruct51_102;

		// Token: 0x04000218 RID: 536
		public static GStruct51 gstruct51_103;

		// Token: 0x04000219 RID: 537
		public static GStruct51 gstruct51_104;

		// Token: 0x0400021A RID: 538
		public static GStruct51 gstruct51_105;

		// Token: 0x0400021B RID: 539
		public static GStruct51 gstruct51_106;

		// Token: 0x0400021C RID: 540
		public static GStruct51 gstruct51_107;

		// Token: 0x0400021D RID: 541
		public static GStruct51 gstruct51_108;

		// Token: 0x0400021E RID: 542
		public static GStruct51 gstruct51_109;

		// Token: 0x0400021F RID: 543
		public static GStruct51 gstruct51_110;

		// Token: 0x04000220 RID: 544
		public static GStruct51 gstruct51_111;

		// Token: 0x04000221 RID: 545
		public static GStruct51 gstruct51_112;

		// Token: 0x04000222 RID: 546
		public static GStruct51 gstruct51_113;

		// Token: 0x04000223 RID: 547
		public static GStruct51 gstruct51_114;

		// Token: 0x04000224 RID: 548
		public static GStruct51 gstruct51_115;

		// Token: 0x04000225 RID: 549
		public static GStruct51 gstruct51_116;

		// Token: 0x04000226 RID: 550
		public static GStruct51 gstruct51_117;

		// Token: 0x04000227 RID: 551
		public static GStruct51 gstruct51_118;

		// Token: 0x04000228 RID: 552
		public static GStruct51 gstruct51_119;

		// Token: 0x04000229 RID: 553
		public static GStruct51 gstruct51_120;

		// Token: 0x0400022A RID: 554
		public static GStruct51 gstruct51_121;

		// Token: 0x0400022B RID: 555
		public static GStruct51 gstruct51_122;

		// Token: 0x0400022C RID: 556
		public static GStruct51 gstruct51_123;

		// Token: 0x0400022D RID: 557
		public static GStruct51 gstruct51_124;

		// Token: 0x0400022E RID: 558
		public static GStruct51 gstruct51_125;

		// Token: 0x0400022F RID: 559
		public static GStruct51 gstruct51_126;

		// Token: 0x04000230 RID: 560
		public static GStruct51 gstruct51_127;

		// Token: 0x04000231 RID: 561
		public static GStruct51 gstruct51_128;

		// Token: 0x04000232 RID: 562
		public static GStruct51 gstruct51_129;

		// Token: 0x04000233 RID: 563
		public static GStruct51 gstruct51_130;

		// Token: 0x04000234 RID: 564
		public static GStruct51 gstruct51_131;

		// Token: 0x04000235 RID: 565
		public static GStruct51 gstruct51_132;

		// Token: 0x04000236 RID: 566
		public static GStruct51 gstruct51_133;

		// Token: 0x04000237 RID: 567
		public static GStruct51 gstruct51_134;

		// Token: 0x04000238 RID: 568
		public static GStruct51 gstruct51_135;

		// Token: 0x04000239 RID: 569
		public static GStruct51 gstruct51_136;

		// Token: 0x0400023A RID: 570
		public static GStruct51 gstruct51_137;

		// Token: 0x0400023B RID: 571
		public static GStruct51 gstruct51_138;

		// Token: 0x0400023C RID: 572
		public static GStruct51 gstruct51_139;

		// Token: 0x0400023D RID: 573
		public static GStruct51 gstruct51_140;

		// Token: 0x0400023E RID: 574
		public static GStruct51 gstruct51_141;

		// Token: 0x0400023F RID: 575
		public static GStruct51 gstruct51_142;

		// Token: 0x04000240 RID: 576
		public static GStruct51 gstruct51_143;

		// Token: 0x04000241 RID: 577
		public static GStruct51 gstruct51_144;

		// Token: 0x04000242 RID: 578
		public static GStruct51 gstruct51_145;

		// Token: 0x04000243 RID: 579
		public static GStruct51 gstruct51_146;

		// Token: 0x04000244 RID: 580
		public static GStruct51 gstruct51_147;

		// Token: 0x04000245 RID: 581
		public static GStruct51 gstruct51_148;

		// Token: 0x04000246 RID: 582
		public static GStruct51 gstruct51_149;

		// Token: 0x04000247 RID: 583
		public static GStruct51 gstruct51_150;

		// Token: 0x04000248 RID: 584
		public static GStruct51 gstruct51_151;

		// Token: 0x04000249 RID: 585
		public static GStruct51 gstruct51_152;

		// Token: 0x0400024A RID: 586
		public static GStruct51 gstruct51_153;

		// Token: 0x0400024B RID: 587
		public static GStruct51 gstruct51_154;

		// Token: 0x0400024C RID: 588
		public static GStruct51 gstruct51_155;

		// Token: 0x0400024D RID: 589
		public static GStruct51 gstruct51_156;

		// Token: 0x0400024E RID: 590
		public static GStruct51 gstruct51_157;

		// Token: 0x0400024F RID: 591
		public static GStruct51 gstruct51_158;

		// Token: 0x04000250 RID: 592
		public static GStruct51 gstruct51_159;

		// Token: 0x04000251 RID: 593
		public static GStruct51 gstruct51_160;

		// Token: 0x04000252 RID: 594
		public static GStruct51 gstruct51_161;

		// Token: 0x04000253 RID: 595
		public static GStruct51 gstruct51_162;

		// Token: 0x04000254 RID: 596
		public static GStruct51 gstruct51_163;

		// Token: 0x04000255 RID: 597
		public static GStruct51 gstruct51_164;

		// Token: 0x04000256 RID: 598
		public static GStruct51 gstruct51_165;

		// Token: 0x04000257 RID: 599
		public static GStruct51 gstruct51_166;

		// Token: 0x04000258 RID: 600
		public static GStruct51 gstruct51_167;

		// Token: 0x04000259 RID: 601
		public static GStruct51 gstruct51_168;

		// Token: 0x0400025A RID: 602
		public static GStruct51 gstruct51_169;

		// Token: 0x0400025B RID: 603
		public static GStruct51 gstruct51_170;

		// Token: 0x0400025C RID: 604
		public static GStruct51 gstruct51_171;

		// Token: 0x0400025D RID: 605
		public static GStruct51 gstruct51_172;

		// Token: 0x0400025E RID: 606
		public static GStruct51 gstruct51_173;

		// Token: 0x0400025F RID: 607
		public static GStruct51 gstruct51_174;

		// Token: 0x04000260 RID: 608
		public static GStruct51 gstruct51_175;

		// Token: 0x04000261 RID: 609
		public static GStruct51 gstruct51_176;

		// Token: 0x04000262 RID: 610
		public static GStruct51 gstruct51_177;

		// Token: 0x04000263 RID: 611
		public static GStruct51 gstruct51_178;

		// Token: 0x04000264 RID: 612
		public static GStruct51 gstruct51_179;

		// Token: 0x04000265 RID: 613
		public static GStruct51 gstruct51_180;

		// Token: 0x04000266 RID: 614
		public static GStruct51 gstruct51_181;

		// Token: 0x04000267 RID: 615
		public static GStruct51 gstruct51_182;

		// Token: 0x04000268 RID: 616
		public static GStruct51 gstruct51_183;

		// Token: 0x04000269 RID: 617
		public static GStruct51 gstruct51_184;

		// Token: 0x0400026A RID: 618
		public static GStruct51 gstruct51_185;

		// Token: 0x0400026B RID: 619
		public static GStruct51 gstruct51_186;

		// Token: 0x0400026C RID: 620
		public static GStruct51 gstruct51_187;

		// Token: 0x0400026D RID: 621
		public static GStruct51 gstruct51_188;

		// Token: 0x0400026E RID: 622
		public static GStruct51 gstruct51_189;

		// Token: 0x0400026F RID: 623
		public static GStruct51 gstruct51_190;

		// Token: 0x04000270 RID: 624
		public static GStruct51 gstruct51_191;

		// Token: 0x04000271 RID: 625
		public static GStruct51 gstruct51_192;

		// Token: 0x04000272 RID: 626
		public static GStruct51 gstruct51_193;

		// Token: 0x04000273 RID: 627
		public static GStruct51 gstruct51_194;

		// Token: 0x04000274 RID: 628
		public static GStruct51 gstruct51_195;

		// Token: 0x04000275 RID: 629
		public static GStruct51 gstruct51_196;

		// Token: 0x04000276 RID: 630
		public static GStruct51 gstruct51_197;

		// Token: 0x04000277 RID: 631
		public static GStruct51 gstruct51_198;

		// Token: 0x04000278 RID: 632
		public static GStruct51 gstruct51_199;

		// Token: 0x04000279 RID: 633
		public static GStruct51 gstruct51_200;

		// Token: 0x0400027A RID: 634
		public static GStruct51 gstruct51_201;

		// Token: 0x0400027B RID: 635
		public static GStruct51 gstruct51_202;

		// Token: 0x0400027C RID: 636
		public static GStruct51 gstruct51_203;

		// Token: 0x0400027D RID: 637
		public static GStruct51 gstruct51_204;

		// Token: 0x0400027E RID: 638
		public static GStruct51 gstruct51_205;

		// Token: 0x0400027F RID: 639
		public static GStruct51 gstruct51_206;

		// Token: 0x04000280 RID: 640
		public static GStruct51 gstruct51_207;

		// Token: 0x04000281 RID: 641
		public static GStruct51 gstruct51_208;

		// Token: 0x04000282 RID: 642
		public static GStruct51 gstruct51_209;

		// Token: 0x04000283 RID: 643
		public static GStruct51 gstruct51_210;

		// Token: 0x04000284 RID: 644
		public static GStruct51 gstruct51_211;

		// Token: 0x04000285 RID: 645
		public static GStruct51 gstruct51_212;

		// Token: 0x04000286 RID: 646
		public static GStruct51 gstruct51_213;

		// Token: 0x04000287 RID: 647
		public static GStruct51 gstruct51_214;

		// Token: 0x04000288 RID: 648
		public static GStruct51 gstruct51_215;

		// Token: 0x04000289 RID: 649
		public static GStruct51 gstruct51_216;

		// Token: 0x0400028A RID: 650
		public static GStruct51 gstruct51_217;

		// Token: 0x0400028B RID: 651
		public static GStruct51 gstruct51_218;

		// Token: 0x0400028C RID: 652
		public static GStruct51 gstruct51_219;

		// Token: 0x0400028D RID: 653
		public static GStruct51 gstruct51_220;

		// Token: 0x0400028E RID: 654
		public static GStruct51 gstruct51_221;

		// Token: 0x0400028F RID: 655
		public static GStruct51 gstruct51_222;

		// Token: 0x04000290 RID: 656
		public static GStruct51 gstruct51_223;

		// Token: 0x04000291 RID: 657
		public static GStruct51 gstruct51_224;

		// Token: 0x04000292 RID: 658
		public static GStruct51 gstruct51_225;

		// Token: 0x04000293 RID: 659
		public static GStruct51 gstruct51_226;

		// Token: 0x04000294 RID: 660
		public static GStruct51 gstruct51_227;

		// Token: 0x04000295 RID: 661
		public static GStruct51 gstruct51_228;

		// Token: 0x04000296 RID: 662
		public static GStruct51 gstruct51_229;

		// Token: 0x04000297 RID: 663
		public static GStruct51 gstruct51_230;

		// Token: 0x04000298 RID: 664
		public static GStruct51 gstruct51_231;

		// Token: 0x04000299 RID: 665
		public static GStruct51 gstruct51_232;

		// Token: 0x0400029A RID: 666
		public static GStruct51 gstruct51_233;

		// Token: 0x0400029B RID: 667
		public static GStruct51 gstruct51_234;

		// Token: 0x0400029C RID: 668
		public static GStruct51 gstruct51_235;

		// Token: 0x0400029D RID: 669
		public static GStruct51 gstruct51_236;

		// Token: 0x0400029E RID: 670
		public static GStruct51 gstruct51_237;

		// Token: 0x0400029F RID: 671
		public static GStruct51 gstruct51_238;

		// Token: 0x040002A0 RID: 672
		public static GStruct51 gstruct51_239;

		// Token: 0x040002A1 RID: 673
		public static GStruct51 gstruct51_240;

		// Token: 0x040002A2 RID: 674
		public static GStruct51 gstruct51_241;

		// Token: 0x040002A3 RID: 675
		public static GStruct51 gstruct51_242;

		// Token: 0x040002A4 RID: 676
		public static GStruct51 gstruct51_243;

		// Token: 0x040002A5 RID: 677
		public static GStruct51 gstruct51_244;

		// Token: 0x040002A6 RID: 678
		public static GStruct51 gstruct51_245;

		// Token: 0x040002A7 RID: 679
		public static GStruct51 gstruct51_246;

		// Token: 0x040002A8 RID: 680
		public static GStruct51 gstruct51_247;

		// Token: 0x040002A9 RID: 681
		public static GStruct51 gstruct51_248;

		// Token: 0x040002AA RID: 682
		public static GStruct51 gstruct51_249;

		// Token: 0x040002AB RID: 683
		public static GStruct51 gstruct51_250;

		// Token: 0x040002AC RID: 684
		public static GStruct51 gstruct51_251;

		// Token: 0x040002AD RID: 685
		public static GStruct51 gstruct51_252;

		// Token: 0x040002AE RID: 686
		public static GStruct51 gstruct51_253;

		// Token: 0x040002AF RID: 687
		public static GStruct51 gstruct51_254;

		// Token: 0x040002B0 RID: 688
		public static GStruct51 gstruct51_255;

		// Token: 0x040002B1 RID: 689
		public static GStruct51 gstruct51_256;

		// Token: 0x040002B2 RID: 690
		public static GStruct51 gstruct51_257;

		// Token: 0x040002B3 RID: 691
		public static GStruct51 gstruct51_258;

		// Token: 0x040002B4 RID: 692
		public static GStruct51 gstruct51_259;

		// Token: 0x040002B5 RID: 693
		public static GStruct51 gstruct51_260;

		// Token: 0x040002B6 RID: 694
		public static GStruct51 gstruct51_261;

		// Token: 0x040002B7 RID: 695
		public static GStruct51 gstruct51_262;

		// Token: 0x040002B8 RID: 696
		public static GStruct51 gstruct51_263;

		// Token: 0x040002B9 RID: 697
		public static GStruct51 gstruct51_264;

		// Token: 0x040002BA RID: 698
		public static GStruct51 gstruct51_265;

		// Token: 0x040002BB RID: 699
		public static GStruct51 gstruct51_266;

		// Token: 0x040002BC RID: 700
		public static GStruct51 gstruct51_267;

		// Token: 0x040002BD RID: 701
		public static GStruct51 gstruct51_268;

		// Token: 0x040002BE RID: 702
		public static bool bool_0;

		// Token: 0x040002BF RID: 703
		public static bool bool_1;

		// Token: 0x040002C0 RID: 704
		public static string string_25;

		// Token: 0x040002C1 RID: 705
		public static string string_26;

		// Token: 0x040002C2 RID: 706
		public static int int_7;

		// Token: 0x040002C3 RID: 707
		public static int int_8;

		// Token: 0x040002C4 RID: 708
		private static int[,] int_9;

		// Token: 0x040002C5 RID: 709
		private static int[,] int_10;

		// Token: 0x040002C6 RID: 710
		public static GStruct51 gstruct51_269;
	}
}
