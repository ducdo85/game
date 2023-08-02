using System;

namespace AutoKeoxe
{
	// Token: 0x0200002B RID: 43
	internal class Class47
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00075EC8 File Offset: 0x000740C8
		public static void smethod_0(GStruct49 gstruct49_0, int int_0, int int_1 = -1)
		{
			int num = GClass1.smethod_5(gstruct49_0);
			bool flag = num > 0;
			if (flag)
			{
				Class97.bool_0 = true;
			}
			bool flag2 = num <= 0 || gstruct49_0.uint_7 == 0U || Class53.gstruct51_245.uint_0 == 0U || Class53.gstruct51_246.uint_0 == 0U;
			if (!flag2)
			{
				uint uint_ = gstruct49_0.uint_7 + Class53.gstruct51_245.uint_0;
				uint uint_2 = gstruct49_0.uint_7 + Class53.gstruct51_246.uint_0;
				int num2 = 0;
				byte[] array = new byte[2];
				int num3 = int_0;
				int num4 = num3;
				if (num4 != 1)
				{
					if (num4 != 2)
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 2, ref num2);
						bool flag3 = array[0] == 144 && array[1] == 144;
						if (flag3)
						{
							array = new byte[]
							{
								117,
								237
							};
							Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num2);
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 2, ref num2);
						bool flag4 = array[0] == 144 && array[1] == 233;
						if (flag4)
						{
							array = new byte[]
							{
								15,
								132
							};
							Class22.WriteProcessMemory(gstruct49_0.int_137, uint_2, array, array.Length, ref num2);
						}
						Class47.smethod_1(gstruct49_0, 20);
					}
					else
					{
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 2, ref num2);
						bool flag5 = array[0] == 144 && array[1] == 144;
						if (flag5)
						{
							array = new byte[]
							{
								117,
								237
							};
							Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num2);
						}
						Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 2, ref num2);
						bool flag6 = array[0] == 15 && array[1] == 132;
						if (flag6)
						{
							array = new byte[]
							{
								144,
								233
							};
							Class22.WriteProcessMemory(gstruct49_0.int_137, uint_2, array, array.Length, ref num2);
						}
						Class47.smethod_1(gstruct49_0, 60);
					}
				}
				else
				{
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_, array, 2, ref num2);
					bool flag7 = array[0] == 117 && array[1] == 237;
					if (flag7)
					{
						array = new byte[]
						{
							144,
							144
						};
						Class22.WriteProcessMemory(gstruct49_0.int_137, uint_, array, array.Length, ref num2);
					}
					Class22.ReadProcessMemory(gstruct49_0.int_137, uint_2, array, 2, ref num2);
					bool flag8 = array[0] == 144 && array[1] == 233;
					if (flag8)
					{
						array = new byte[]
						{
							15,
							132
						};
						Class22.WriteProcessMemory(gstruct49_0.int_137, uint_2, array, array.Length, ref num2);
					}
					Class47.smethod_1(gstruct49_0, 40);
				}
				bool flag9 = 0 <= int_1;
				if (flag9)
				{
					int_0 = int_1;
				}
				bool flag10 = Form1.int_65 == 0;
				if (flag10)
				{
					Class70.smethod_52(gstruct49_0, "<bclr=blue><color=green>§ang Gi¶m CPU ®en mµn h×nh: Møc " + ((int)Convert.ToByte(int_0 > 0 && int_0 < 3) * int_0).ToString() + " (bÊm F10)", 1);
				}
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00076210 File Offset: 0x00074410
		public static void smethod_1(GStruct49 gstruct49_0, int int_0)
		{
			uint num = gstruct49_0.uint_7 + Class53.gstruct51_247.uint_0;
			uint num2 = gstruct49_0.uint_7 + Class53.gstruct51_248.uint_0;
			uint num3 = gstruct49_0.uint_7 + Class53.gstruct51_249.uint_0;
			int num4 = 0;
			byte[] array = new byte[1];
			byte[] byte_ = new byte[]
			{
				(byte)int_0
			};
			Class22.ReadProcessMemory(gstruct49_0.int_137, num, array, 1, ref num4);
			bool flag = array[0] == 106;
			if (flag)
			{
				Class22.WriteProcessMemory(gstruct49_0.int_137, num + 1U, byte_, 1, ref num4);
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, num2, array, 1, ref num4);
			bool flag2 = array[0] == 106;
			if (flag2)
			{
				Class22.WriteProcessMemory(gstruct49_0.int_137, num2 + 1U, byte_, 1, ref num4);
			}
			Class22.ReadProcessMemory(gstruct49_0.int_137, num3, array, 1, ref num4);
			bool flag3 = array[0] == 106;
			if (flag3)
			{
				Class22.WriteProcessMemory(gstruct49_0.int_137, num3 + 1U, byte_, 1, ref num4);
			}
		}
	}
}
