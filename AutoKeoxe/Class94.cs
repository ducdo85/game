using System;

namespace AutoKeoxe
{
	// Token: 0x0200005B RID: 91
	internal class Class94
	{
		// Token: 0x06000546 RID: 1350 RVA: 0x000EC5A8 File Offset: 0x000EA7A8
		static Class94()
		{
			uint[,] array_ = new uint[3, 2];
			Class11.smethod_4(array_, 372728);
			Class94.uint_0 = array_;
			uint[,] array_2 = new uint[3, 2];
			Class11.smethod_4(array_2, 372761);
			Class94.uint_1 = array_2;
			uint[,] array_3 = new uint[4, 2];
			Class11.smethod_4(array_3, 372794);
			Class94.uint_2 = array_3;
			uint[,] array_4 = new uint[52, 2];
			Class11.smethod_4(array_4, 372835);
			Class94.uint_3 = array_4;
			uint[,] array_5 = new uint[84, 2];
			Class11.smethod_4(array_5, 373261);
			Class94.uint_4 = array_5;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x000EC71C File Offset: 0x000EA91C
		public static bool smethod_0(uint[] uint_5)
		{
			long num = Class60.smethod_21(Class94.uint_4, uint_5);
			long num2 = Class60.smethod_21(Class94.uint_3, uint_5);
			return num < num2;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000EC74C File Offset: 0x000EA94C
		public static uint[,] smethod_1(uint[] uint_5)
		{
			uint[,] array = new uint[3, 2];
			int num = Class60.smethod_20(Class94.uint_0, uint_5);
			array[0, 0] = Class94.uint_0[num, 0];
			array[0, 1] = Class94.uint_0[num, 1];
			num = Class60.smethod_20(Class94.uint_1, uint_5);
			array[1, 0] = Class94.uint_1[num, 0];
			array[1, 1] = Class94.uint_1[num, 1];
			num = Class60.smethod_20(Class94.uint_2, uint_5);
			array[2, 0] = Class94.uint_2[num, 0];
			array[2, 1] = Class94.uint_2[num, 1];
			int num2 = Class60.smethod_20(array, uint_5);
			int num3 = num2;
			uint[,] result;
			if (num3 != 0)
			{
				if (num3 != 1)
				{
					result = Class94.uint_2;
				}
				else
				{
					result = Class94.uint_1;
				}
			}
			else
			{
				result = Class94.uint_0;
			}
			return result;
		}

		// Token: 0x04000409 RID: 1033
		public static GStruct23[] gstruct23_0 = new GStruct23[]
		{
			new GStruct23
			{
				int_0 = 333,
				uint_0 = new uint[]
				{
					42240U,
					92160U
				},
				string_0 = "T©y"
			},
			new GStruct23
			{
				int_0 = 333,
				uint_0 = new uint[]
				{
					49408U,
					102464U
				},
				string_0 = "®«ng|§«ng"
			},
			new GStruct23
			{
				int_0 = 333,
				uint_0 = new uint[]
				{
					41265U,
					102756U
				},
				string_0 = "Nam"
			}
		};

		// Token: 0x0400040A RID: 1034
		public static uint[,] uint_0;

		// Token: 0x0400040B RID: 1035
		public static uint[,] uint_1;

		// Token: 0x0400040C RID: 1036
		public static uint[,] uint_2;

		// Token: 0x0400040D RID: 1037
		private static uint[,] uint_3;

		// Token: 0x0400040E RID: 1038
		private static uint[,] uint_4;
	}
}
