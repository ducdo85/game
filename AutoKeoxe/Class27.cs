using System;

namespace AutoKeoxe
{
	// Token: 0x02000019 RID: 25
	internal class Class27
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00018020 File Offset: 0x00016220
		public static int smethod_0(GStruct40[] gstruct40_3, string string_0)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < gstruct40_3.GetLength(0);
				if (!flag)
				{
					goto IL_33;
				}
				bool flag2 = string_0 == gstruct40_3[num].string_0;
				if (flag2)
				{
					break;
				}
				num++;
			}
			return gstruct40_3[num].int_0;
			IL_33:
			return -1;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001807C File Offset: 0x0001627C
		public static string smethod_1(GStruct40[] gstruct40_3, int int_18)
		{
			for (int i = 0; i < gstruct40_3.GetLength(0); i++)
			{
				bool flag = int_18 == gstruct40_3[i].int_0;
				if (flag)
				{
					return gstruct40_3[i].string_0;
				}
			}
			return null;
		}

		// Token: 0x040000C6 RID: 198
		public static int int_0 = 1187916127;

		// Token: 0x040000C7 RID: 199
		public static int int_1 = 112;

		// Token: 0x040000C8 RID: 200
		public static int int_2 = 113;

		// Token: 0x040000C9 RID: 201
		public static int int_3 = 118;

		// Token: 0x040000CA RID: 202
		public static int int_4 = 119;

		// Token: 0x040000CB RID: 203
		public static int int_5 = 120;

		// Token: 0x040000CC RID: 204
		public static int int_6 = 121;

		// Token: 0x040000CD RID: 205
		public static int int_7 = 107;

		// Token: 0x040000CE RID: 206
		public static int int_8 = 187;

		// Token: 0x040000CF RID: 207
		public static int int_9 = 109;

		// Token: 0x040000D0 RID: 208
		public static int int_10 = 189;

		// Token: 0x040000D1 RID: 209
		public static int int_11 = 90;

		// Token: 0x040000D2 RID: 210
		public static int int_12 = 88;

		// Token: 0x040000D3 RID: 211
		public static int int_13 = 75;

		// Token: 0x040000D4 RID: 212
		public static int int_14 = 65;

		// Token: 0x040000D5 RID: 213
		public static int int_15 = 83;

		// Token: 0x040000D6 RID: 214
		public static int int_16 = 70;

		// Token: 0x040000D7 RID: 215
		public static int int_17 = 71;

		// Token: 0x040000D8 RID: 216
		public static GStruct40[] gstruct40_0 = new GStruct40[]
		{
			new GStruct40
			{
				string_0 = "A",
				int_0 = 65
			},
			new GStruct40
			{
				string_0 = "S",
				int_0 = 83
			},
			new GStruct40
			{
				string_0 = "Z",
				int_0 = 90
			},
			new GStruct40
			{
				string_0 = "X",
				int_0 = 88
			},
			new GStruct40
			{
				string_0 = "4",
				int_0 = 52
			},
			new GStruct40
			{
				string_0 = "5",
				int_0 = 53
			},
			new GStruct40
			{
				string_0 = "6",
				int_0 = 54
			},
			new GStruct40
			{
				string_0 = "7",
				int_0 = 55
			},
			new GStruct40
			{
				string_0 = "8",
				int_0 = 56
			},
			new GStruct40
			{
				string_0 = "9",
				int_0 = 57
			}
		};

		// Token: 0x040000D9 RID: 217
		public static GStruct40[] gstruct40_1 = new GStruct40[]
		{
			new GStruct40
			{
				string_0 = "1",
				int_0 = 49
			},
			new GStruct40
			{
				string_0 = "2",
				int_0 = 50
			},
			new GStruct40
			{
				string_0 = "3",
				int_0 = 51
			},
			new GStruct40
			{
				string_0 = "4",
				int_0 = 52
			},
			new GStruct40
			{
				string_0 = "5",
				int_0 = 53
			},
			new GStruct40
			{
				string_0 = "6",
				int_0 = 54
			},
			new GStruct40
			{
				string_0 = "7",
				int_0 = 55
			},
			new GStruct40
			{
				string_0 = "8",
				int_0 = 56
			},
			new GStruct40
			{
				string_0 = "9",
				int_0 = 57
			}
		};

		// Token: 0x040000DA RID: 218
		public static GStruct40[] gstruct40_2 = new GStruct40[]
		{
			new GStruct40
			{
				string_0 = "F2",
				int_0 = 113
			},
			new GStruct40
			{
				string_0 = "A",
				int_0 = 65
			}
		};
	}
}
