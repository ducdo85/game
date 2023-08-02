using System;

namespace AutoKeoxe
{
	// Token: 0x0200002E RID: 46
	internal class Class5
	{
		// Token: 0x060002E6 RID: 742 RVA: 0x00077CFC File Offset: 0x00075EFC
		private bool method_0(string string_1, ref string string_2)
		{
			bool flag = string_1 == string_2;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				string text = "";
				int num = 0;
				while (num < string_1.Length && string_2.Length > num && string_1[num] == string_2[num])
				{
					text += string_1[num].ToString();
					num++;
				}
				bool flag2 = text.Length <= 4;
				if (flag2)
				{
					result = false;
				}
				else
				{
					string_2 = text;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00077D8C File Offset: 0x00075F8C
		private void method_1(int int_0, string string_1, ref Class5.Struct5[] struct5_0)
		{
			Class5.Struct5 @struct = new Class5.Struct5
			{
				int_1 = int_0,
				int_0 = 1,
				string_0 = string_1
			};
			bool flag = struct5_0 == null || struct5_0.Length == 0;
			if (flag)
			{
				struct5_0 = new Class5.Struct5[]
				{
					@struct
				};
			}
			else
			{
				Class5.Struct5[] array = new Class5.Struct5[struct5_0.Length + 1];
				int num = 0;
				for (;;)
				{
					bool flag2 = num < struct5_0.Length;
					if (!flag2)
					{
						goto IL_B8;
					}
					bool flag3 = int_0 == struct5_0[num].int_1 && this.method_0(string_1, ref struct5_0[num].string_0);
					if (flag3)
					{
						break;
					}
					ref Class5.Struct5 ptr = ref array[num];
					ptr = struct5_0[num];
					num++;
				}
				Class5.Struct5[] array2 = struct5_0;
				int num2 = num;
				array2[num2].int_0 = array2[num2].int_0 + 1;
				return;
				IL_B8:
				array[array.Length - 1] = @struct;
				struct5_0 = array;
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00077E7C File Offset: 0x0007607C
		public void method_2()
		{
			Class22.smethod_30(Class53.gstruct51_126.uint_0, this.gstruct49_0.int_137);
			uint num = Class22.smethod_30(Class53.gstruct51_14.uint_0, this.gstruct49_0.int_137);
			int num2 = 0;
			byte[] array = new byte[4];
			uint uint_ = this.gstruct49_0.uint_7 + Class53.gstruct51_9.uint_0 + Class53.gstruct51_10.uint_0 + 4U;
			Class22.ReadProcessMemory(this.gstruct49_0.int_137, uint_, array, 4, ref num2);
			int num3 = BitConverter.ToInt32(array, 0);
			Class5.Struct5[] array2 = null;
			int[] array3 = new int[6];
			int num4 = 0;
			int num5 = 0;
			for (int i = 1; i < 256; i++)
			{
				bool flag = num3 <= num5;
				if (flag)
				{
					break;
				}
				uint num6 = num + (uint)(i * (int)Class53.gstruct51_15.uint_0);
				Class22.ReadProcessMemory(this.gstruct49_0.int_137, num6 + Class53.gstruct51_16.uint_0, array, 4, ref num2);
				bool flag2 = array[0] == 0;
				if (!flag2)
				{
					num5++;
					Class22.ReadProcessMemory(this.gstruct49_0.int_137, num6 + Class53.gstruct51_50.uint_0, array, 4, ref num2);
					bool flag3 = BitConverter.ToInt32(array, 0) <= 0 || Class22.smethod_30(num6 + Class53.gstruct51_52.uint_0, this.gstruct49_0.int_137) != 1U;
					if (!flag3)
					{
						int num7 = (int)Class22.smethod_30(num6 + Class53.gstruct51_54.uint_0, this.gstruct49_0.int_137);
						bool flag4 = num7 > 4;
						if (flag4)
						{
							num7 = 5;
						}
						num4++;
						array3[num7]++;
						Class22.ReadProcessMemory(this.gstruct49_0.int_137, num6 + Class53.gstruct51_88.uint_0, array, 4, ref num2);
						uint num8 = BitConverter.ToUInt32(array, 0);
						string text = Class22.smethod_28(num6 + Class53.gstruct51_89.uint_0, this.gstruct49_0.int_137, 24);
						bool flag5 = num8 != 0U && text != null && text != string.Empty;
						if (flag5)
						{
							string text2 = string.Empty;
							for (int j = 0; j < text.Length; j++)
							{
								text2 += text[j].ToString();
								bool flag6 = Class12.smethod_6(text2) == num8;
								if (flag6)
								{
									text = text2;
									break;
								}
							}
						}
						this.method_1(num7, text, ref array2);
					}
				}
			}
			bool flag7 = array2 == null;
			if (!flag7)
			{
				string text3 = "";
				uint[] array4 = Class36.smethod_30(this.gstruct49_0);
				bool flag8 = array4 != null;
				if (flag8)
				{
					object obj = text3;
					text3 = string.Concat(new object[]
					{
						obj,
						" (",
						array4[0] / 256U,
						",",
						array4[1] / 512U,
						")"
					});
				}
				string[] array5 = new string[]
				{
					"Tr¾ng",
					"Vµng ",
					"TÝm  ",
					"Xanh ",
					"§á   ",
					"Kh¸c "
				};
				string text4 = null;
				for (int k = 0; k < array3.Length; k++)
				{
					bool flag9 = array3[k] > 0;
					if (flag9)
					{
						bool flag10 = text4 != null;
						if (flag10)
						{
							text4 += ", ";
						}
						text4 = text4 + array5[k].Replace(" ", "") + ":" + array3[k].ToString();
					}
				}
				string[] array6 = new string[array2.Length];
				bool flag11 = array2 != null;
				if (flag11)
				{
					for (int l = 0; l < array2.Length; l++)
					{
						array6[l] = string.Concat(new string[]
						{
							array5[array2[l].int_1],
							": ",
							array2[l].int_0.ToString(),
							", ",
							array2[l].string_0
						});
					}
				}
				bool flag12 = this.string_0 == null || this.string_0 == "";
				if (flag12)
				{
					Class70.smethod_57(this.gstruct49_0, "ClearMessage()");
					Class70.smethod_52(this.gstruct49_0, "-------------------------------------------", 1);
					for (int m = 0; m < array6.Length; m++)
					{
						bool flag13 = array6[m] != null;
						if (flag13)
						{
							Class70.smethod_52(this.gstruct49_0, "<color=green>" + array6[m], 1);
						}
					}
					Class70.smethod_52(this.gstruct49_0, "-------------------------------------------", 1);
					Class70.smethod_52(this.gstruct49_0, "<color=green>Map  : " + Class37.smethod_1(Class37.smethod_0(this.gstruct49_0), false) + text3, 1);
					Class70.smethod_52(this.gstruct49_0, string.Concat(new string[]
					{
						"<color=yellow>Tæng : ",
						num4.ToString(),
						"<color=green> (",
						text4,
						")"
					}), 1);
					Class70.smethod_52(this.gstruct49_0, "-------------------------------------------", 1);
				}
				this.string_0 += "|CH_CHATROOM";
				string[] array7 = this.string_0.Split(new char[]
				{
					'|'
				});
				bool flag14 = array7.Length == 0;
				if (!flag14)
				{
					string text5 = string.Concat(new string[]
					{
						"Tæng:",
						num4.ToString(),
						" (",
						text4,
						"). B¶n ®å: ",
						Class37.smethod_1(Class37.smethod_0(this.gstruct49_0), false),
						text3
					});
					for (int n = 0; n < array7.Length; n++)
					{
						bool flag15 = array7[n] != "";
						if (flag15)
						{
							string text6 = string.Concat(new string[]
							{
								"Chat('",
								array7[n],
								"', '",
								text5,
								"')"
							});
							Class70.smethod_57(this.gstruct49_0, text6);
						}
					}
				}
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000784E4 File Offset: 0x000766E4
		private static string smethod_0(string string_1)
		{
			byte[,] array = new byte[7, 2];
			Class11.smethod_4(array, 512);
			byte[,] array2 = array;
			for (int i = 0; i < array2.GetLength(0); i++)
			{
				string_1 = string_1.Replace((char)array2[i, 0], (char)array2[i, 1]);
			}
			return string_1;
		}

		// Token: 0x04000174 RID: 372
		public GStruct49 gstruct49_0 = default(GStruct49);

		// Token: 0x04000175 RID: 373
		public string string_0 = null;

		// Token: 0x020000F3 RID: 243
		private struct Struct5
		{
			// Token: 0x04001259 RID: 4697
			public int int_0;

			// Token: 0x0400125A RID: 4698
			public int int_1;

			// Token: 0x0400125B RID: 4699
			public string string_0;
		}
	}
}
