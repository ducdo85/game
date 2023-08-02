using System;
using System.Diagnostics;

namespace AutoKeoxe
{
	// Token: 0x02000012 RID: 18
	internal class Class20
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000122EC File Offset: 0x000104EC
		public static string smethod_0(string string_0)
		{
			bool flag = string_0 != null;
			if (flag)
			{
				bool flag2 = string_0 == "";
				if (!flag2)
				{
					string text = "";
					char[] array = string_0.ToCharArray();
					for (int i = 0; i < array.Length; i++)
					{
						text += ('ÿ' - array[i]).ToString();
					}
					return text;
				}
			}
			return "";
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00012370 File Offset: 0x00010570
		public static void smethod_1()
		{
			string text = string.Empty;
			bool flag = FormLogin.gstruct0_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormLogin.gstruct0_0.Length; i++)
				{
					GStruct0 gstruct = FormLogin.gstruct0_0[i];
					string string_ = string.Concat(new string[]
					{
						gstruct.string_0,
						"\u0002",
						gstruct.string_1,
						"\u0002",
						gstruct.int_4.ToString(),
						"\u0002",
						gstruct.string_2,
						"\u0002",
						gstruct.string_3,
						"\u0002",
						gstruct.string_4,
						"\u0002",
						gstruct.string_5,
						"\u0002",
						gstruct.string_6,
						"\u0002",
						gstruct.int_3.ToString(),
						"\u0002None"
					});
					string str = Class12.smethod_16(Class20.smethod_0(string_));
					bool flag2 = text != string.Empty;
					if (flag2)
					{
						text += "\u0001";
					}
					text += str;
				}
			}
			Class12.smethod_23(FormLogin.string_2);
			Class12.smethod_34(FormLogin.string_3, text, 1);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000124CC File Offset: 0x000106CC
		public static void smethod_2()
		{
			FormLogin.bool_1 = false;
			FormLogin.bool_2 = false;
			int num = 10;
			string text = Class12.smethod_33(FormLogin.string_3, 0, 0, 1);
			bool flag = text == string.Empty;
			if (flag)
			{
				FormLogin.bool_1 = true;
				FormLogin.bool_2 = true;
			}
			else
			{
				string[] array = text.Split(new char[]
				{
					'\u0001'
				});
				string[,] array2 = new string[array.Length, num];
				int num2 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = Class12.smethod_15(array[i]);
					bool flag2 = text2 == null || text2 == string.Empty;
					if (!flag2)
					{
						string[] array3 = Class20.smethod_0(text2).Split(new char[]
						{
							'\u0002'
						});
						bool flag3 = array3.Length >= num;
						if (flag3)
						{
							for (int j = 0; j < num; j++)
							{
								array2[num2, j] = array3[j];
							}
							num2++;
						}
					}
				}
				bool flag4 = num2 != 0;
				if (flag4)
				{
					FormLogin.gstruct0_0 = new GStruct0[num2];
					for (int k = 0; k < num2; k++)
					{
						FormLogin.gstruct0_0[k].string_0 = array2[k, 0];
						FormLogin.gstruct0_0[k].string_1 = array2[k, 1];
						FormLogin.gstruct0_0[k].int_4 = Class12.smethod_11(array2[k, 2]);
						FormLogin.gstruct0_0[k].string_2 = array2[k, 3];
						FormLogin.gstruct0_0[k].string_3 = array2[k, 4];
						FormLogin.gstruct0_0[k].string_4 = array2[k, 5];
						FormLogin.gstruct0_0[k].string_5 = array2[k, 6];
						FormLogin.gstruct0_0[k].string_6 = array2[k, 7];
						FormLogin.gstruct0_0[k].int_3 = Class12.smethod_11(array2[k, 8]);
					}
					FormLogin.bool_1 = true;
					FormLogin.bool_2 = true;
				}
				else
				{
					FormLogin.bool_1 = true;
					FormLogin.bool_2 = true;
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00012720 File Offset: 0x00010920
		public static void smethod_3()
		{
			bool flag = FormLogin.gstruct0_0 == null || FormLogin.gstruct0_0.Length == 0;
			if (!flag)
			{
				int[] array = Class22.smethod_24(Class53.string_21, null, false);
				bool flag2 = array == null;
				if (!flag2)
				{
					int i = 0;
					while (i < array.Length)
					{
						try
						{
							int num = array[i];
							GStruct8[] array2 = Class22.smethod_62(num, "WIN_CLASS:Sword3 Class", 0);
							bool flag3 = array2 == null || array2.Length == 0;
							if (!flag3)
							{
								uint uint_ = array2[0].uint_0;
								uint num2 = Class22.smethod_59(num);
								bool flag4 = num2 == 0U;
								if (!flag4)
								{
									int num3 = Class22.OpenProcess(2035711, false, num);
									bool flag5 = num3 <= 0;
									if (!flag5)
									{
										uint num4 = Class22.smethod_30(Class9.uint_0, num3);
										uint num5 = Class22.smethod_30(num4 + Class9.uint_2, num3) * Class9.uint_4;
										uint num6 = Class22.smethod_30(Class9.uint_3, num3);
										uint num7 = num6 + num5;
										string text = Class22.smethod_28(num7 + Class9.uint_5, num3, 40);
										bool flag6 = text != null && text.Length >= 6;
										if (flag6)
										{
											Process processById = Process.GetProcessById(num);
											int num8 = -1;
											bool flag7 = FormLogin.gstruct0_0 != null;
											if (flag7)
											{
												for (int j = 0; j < FormLogin.gstruct0_0.Length; j++)
												{
													bool flag8 = text == FormLogin.gstruct0_0[j].string_4;
													if (flag8)
													{
														num8 = j;
														break;
													}
												}
											}
											bool flag9 = 0 <= num8;
											if (flag9)
											{
												FormLogin.gstruct0_0[num8].int_1 = num;
												FormLogin.gstruct0_0[num8].int_2 = num3;
												FormLogin.gstruct0_0[num8].process_0 = processById;
												FormLogin.gstruct0_0[num8].uint_1 = num2;
												FormLogin.gstruct0_0[num8].uint_0 = uint_;
												Class49.smethod_2(ref FormLogin.gstruct0_0[num8]);
											}
										}
										else
										{
											Class22.smethod_32(num3);
										}
									}
								}
							}
						}
						catch
						{
						}
						IL_215:
						i++;
						continue;
						goto IL_215;
					}
				}
			}
		}
	}
}
