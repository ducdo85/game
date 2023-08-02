using System;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000031 RID: 49
	internal class Class52
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0007B338 File Offset: 0x00079538
		public static void smethod_0(GStruct49 gstruct49_0)
		{
			Class70.smethod_52(gstruct49_0, "Xãa Sms...", 1);
			for (int i = 0; i < 10; i++)
			{
				bool flag = Class52.smethod_2(gstruct49_0, false) == string.Empty;
				if (flag)
				{
					break;
				}
				Class70.smethod_12(gstruct49_0.int_137, gstruct49_0.uint_55);
				Thread.Sleep(150);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0007B39C File Offset: 0x0007959C
		public static bool smethod_1(GStruct49 gstruct49_0)
		{
			uint num = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_168.uint_0, gstruct49_0.int_137);
			return num2 > 0U;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0007B3E0 File Offset: 0x000795E0
		public static string smethod_2(GStruct49 gstruct49_0, bool bool_0 = false)
		{
			string text = string.Empty;
			uint num = Class22.smethod_30(Class53.gstruct51_165.uint_0, gstruct49_0.int_137);
			uint num2 = Class22.smethod_30(num + Class53.gstruct51_167.uint_0, gstruct49_0.int_137);
			bool flag = num2 > 0U;
			string result;
			if (flag)
			{
				for (uint num3 = 0U; num3 < 10U; num3 += 1U)
				{
					uint num4 = Class22.smethod_30(num2 + num3 * 4U, gstruct49_0.int_137);
					bool flag2 = num4 == 0U;
					if (!flag2)
					{
						string text2 = Class22.smethod_28(num4, gstruct49_0.int_137, 78);
						bool flag3 = text2 == null || text2 == string.Empty;
						if (!flag3)
						{
							if (bool_0)
							{
								int num5 = (int)Class22.smethod_30(num4 + Class53.gstruct51_170.uint_0, gstruct49_0.int_137);
								bool flag4 = num5 <= 0;
								if (flag4)
								{
									goto IL_108;
								}
								text2 = num5.ToString() + ";" + text2;
							}
							bool flag5 = text != string.Empty;
							if (flag5)
							{
								text += "|";
							}
							text += text2;
						}
					}
					IL_108:;
				}
				result = text;
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x0400017D RID: 381
		private static string[] string_0 = new string[]
		{
			"mêi tæ ®éi",
			"giao dÞch"
		};
	}
}
