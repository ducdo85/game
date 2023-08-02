using System;

namespace AutoKeoxe
{
	// Token: 0x02000053 RID: 83
	internal class Class84
	{
		// Token: 0x0600051F RID: 1311 RVA: 0x000E5E64 File Offset: 0x000E4064
		public static uint[] smethod_0(uint[] uint_0)
		{
			bool flag = Class84.gstruct21_1 == null;
			if (flag)
			{
				Class84.gstruct21_1 = Class84.smethod_2();
			}
			int num = -1;
			long num2 = -1L;
			for (int i = 0; i < Class84.gstruct21_1.Length; i++)
			{
				long num3 = Class60.smethod_21(Class84.gstruct21_1[i].uint_0, uint_0);
				bool flag2 = num < 0 || num3 < num2;
				if (flag2)
				{
					num = i;
					num2 = num3;
				}
			}
			uint[] result;
			switch (num)
			{
			case 0:
				result = new uint[]
				{
					52692U,
					103470U
				};
				break;
			case 1:
				result = new uint[]
				{
					49674U,
					104586U
				};
				break;
			case 2:
				result = new uint[]
				{
					49046U,
					99282U
				};
				break;
			default:
				result = new uint[]
				{
					52318U,
					98808U
				};
				break;
			}
			return result;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000E5F60 File Offset: 0x000E4160
		public static GStruct21[] smethod_1()
		{
			uint[,] array = new uint[12, 2];
			Class11.smethod_4(array, 363528);
			uint[,] uint_ = array;
			uint[,] array2 = new uint[10, 2];
			Class11.smethod_4(array2, 363633);
			uint[,] uint_2 = array2;
			uint[,] array3 = new uint[15, 2];
			Class11.smethod_4(array3, 363722);
			uint[,] uint_3 = array3;
			uint[,] array4 = new uint[12, 2];
			Class11.smethod_4(array4, 363851);
			uint[,] uint_4 = array4;
			uint[,] array5 = new uint[15, 2];
			Class11.smethod_4(array5, 363956);
			uint[,] uint_5 = array5;
			uint[,] array6 = new uint[9, 2];
			Class11.smethod_4(array6, 364085);
			uint[,] uint_6 = array6;
			uint[,] array7 = new uint[12, 2];
			Class11.smethod_4(array7, 364166);
			uint[,] uint_7 = array7;
			return new GStruct21[]
			{
				new GStruct21
				{
					uint_0 = uint_
				},
				new GStruct21
				{
					uint_0 = uint_2
				},
				new GStruct21
				{
					uint_0 = uint_3
				},
				new GStruct21
				{
					uint_0 = uint_4
				},
				new GStruct21
				{
					uint_0 = uint_5
				},
				new GStruct21
				{
					uint_0 = uint_6
				},
				new GStruct21
				{
					uint_0 = uint_7
				}
			};
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000E60E4 File Offset: 0x000E42E4
		public static GStruct21[] smethod_2()
		{
			uint[,] array = new uint[7, 2];
			Class11.smethod_4(array, 364303);
			uint[,] uint_ = array;
			uint[,] array2 = new uint[7, 2];
			Class11.smethod_4(array2, 364368);
			uint[,] uint_2 = array2;
			uint[,] array3 = new uint[8, 2];
			Class11.smethod_4(array3, 364433);
			uint[,] uint_3 = array3;
			uint[,] array4 = new uint[7, 2];
			Class11.smethod_4(array4, 364506);
			uint[,] uint_4 = array4;
			return new GStruct21[]
			{
				new GStruct21
				{
					uint_0 = uint_4
				},
				new GStruct21
				{
					uint_0 = uint_3
				},
				new GStruct21
				{
					uint_0 = uint_2
				},
				new GStruct21
				{
					uint_0 = uint_
				}
			};
		}

		// Token: 0x040003BA RID: 954
		public static GStruct21[] gstruct21_0;

		// Token: 0x040003BB RID: 955
		public static GStruct21[] gstruct21_1;
	}
}
