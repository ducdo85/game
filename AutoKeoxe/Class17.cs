using System;

namespace AutoKeoxe
{
	// Token: 0x0200000F RID: 15
	internal class Class17
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		static Class17()
		{
			string[] array = new string[3];
			array[0] = Class12.smethod_15(Class62.smethod_6("KTCTabName0", 0, ""));
			array[1] = Class12.smethod_15(Class62.smethod_6("KTCTabName1", 0, ""));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000DF18 File Offset: 0x0000C118
		public static GStruct1 smethod_0(GStruct49 gstruct49_0, int int_0)
		{
			int num = 0;
			byte[] array = new byte[4];
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_19.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_20.uint_0 - 4U, array, 4, ref num);
			uint num3 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, Class53.gstruct51_11.uint_0, array, 4, ref num);
			uint num4 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num4 + Class53.gstruct51_18.uint_0, array, 4, ref num);
			uint num5 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3 + num5 * 4U, array, 4, ref num);
			uint num6 = BitConverter.ToUInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num6 + (uint)(int_0 * 4), array, 4, ref num);
			uint num7 = BitConverter.ToUInt32(array, 0) * Class53.gstruct51_22.uint_0;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2 + Class53.gstruct51_20.uint_0, array, 4, ref num);
			uint num8 = BitConverter.ToUInt32(array, 0) + num7;
			Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + 12U, array, 4, ref num);
			int int_ = BitConverter.ToInt32(array, 0);
			Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + 36U, array, 4, ref num);
			uint uint_ = BitConverter.ToUInt32(array, 0);
			array = new byte[64];
			Class22.ReadProcessMemory(gstruct49_0.int_137, num8 + 48U, array, array.Length, ref num);
			string text = Class10.smethod_3(array);
			return new GStruct1
			{
				string_0 = text,
				int_0 = int_0,
				int_1 = int_,
				uint_0 = uint_
			};
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		public static GStruct1[] smethod_1(GStruct49 gstruct49_0)
		{
			GStruct1[] array = null;
			int num = 0;
			int num2 = 0;
			string a = null;
			for (int i = 0; i < 400; i++)
			{
				GStruct1 gstruct = Class17.smethod_0(gstruct49_0, i);
				bool flag = gstruct.string_0 == string.Empty;
				if (!flag)
				{
					bool flag2 = !(a == gstruct.string_0);
					if (flag2)
					{
						num2 = 0;
					}
					else
					{
						num2++;
						bool flag3 = num2 > 10;
						if (flag3)
						{
							break;
						}
					}
					a = gstruct.string_0;
					num++;
					Array.Resize<GStruct1>(ref array, num);
					array[num - 1] = gstruct;
				}
			}
			return array;
		}

		// Token: 0x0400005C RID: 92
		public static string[] string_0;
	}
}
