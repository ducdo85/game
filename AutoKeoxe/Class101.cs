using System;

namespace AutoKeoxe
{
	// Token: 0x02000005 RID: 5
	internal class Class101
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00006F6C File Offset: 0x0000516C
		public static bool smethod_0(int int_0)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < Class101.struct28_0.Length;
				if (!flag)
				{
					goto IL_34;
				}
				bool flag2 = int_0 == Class101.struct28_0[num].int_0;
				if (flag2)
				{
					break;
				}
				num++;
			}
			return true;
			IL_34:
			return false;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00006FBC File Offset: 0x000051BC
		public static uint[] smethod_1(int int_0, uint[] uint_0, int int_1, uint[] uint_1)
		{
			bool flag = !Class101.smethod_0(int_0) || !Class101.smethod_0(int_1);
			uint[] result;
			if (flag)
			{
				result = null;
			}
			else
			{
				bool flag2 = false;
				int i = 0;
				for (;;)
				{
					bool flag3 = i < Class101.struct28_0.Length;
					if (!flag3)
					{
						goto IL_82;
					}
					bool flag4 = Class101.struct28_0[i].int_0 != int_0 || Class101.struct28_0[i].int_1 != int_1;
					if (!flag4)
					{
						break;
					}
					i++;
				}
				int num = i;
				goto IL_1ED;
				IL_82:
				int[] array = null;
				for (i = 0; i < Class101.struct28_0.Length; i++)
				{
					bool flag5 = Class101.struct28_0[i].int_0 == int_1;
					if (flag5)
					{
						Class12.smethod_37(ref array, Class101.struct28_0[i].int_1);
					}
				}
				bool flag6 = array == null;
				if (flag6)
				{
					return null;
				}
				flag2 = true;
				int num2 = 0;
				for (;;)
				{
					bool flag7 = num2 < array.Length;
					if (!flag7)
					{
						goto IL_163;
					}
					int num3 = array[num2];
					for (i = 0; i < Class101.struct28_0.Length; i++)
					{
						bool flag8 = Class101.struct28_0[i].int_0 != int_0 || Class101.struct28_0[i].int_1 != num3;
						if (!flag8)
						{
							goto IL_143;
						}
					}
					num2++;
				}
				IL_143:
				num = i;
				goto IL_1EC;
				IL_163:
				int_1 = ((int_0 != 927 && int_0 != 930) ? 931 : 932);
				i = 0;
				for (;;)
				{
					bool flag9 = i < Class101.struct28_0.Length;
					if (!flag9)
					{
						goto IL_1CE;
					}
					bool flag10 = Class101.struct28_0[i].int_0 == int_0 && Class101.struct28_0[i].int_1 == int_1;
					if (flag10)
					{
						break;
					}
					i++;
				}
				num = i;
				goto IL_1EC;
				IL_1CE:
				return null;
				IL_1EC:
				IL_1ED:
				int length = Class101.struct28_0[num].uint_0.GetLength(0);
				bool flag11 = length != 1;
				if (flag11)
				{
					int num4 = -1;
					long num5 = -1L;
					for (i = 0; i < length; i++)
					{
						bool flag12 = !flag2;
						long num6;
						if (flag12)
						{
							uint[] uint_2 = new uint[]
							{
								Class101.struct28_0[num].uint_0[i, 3],
								Class101.struct28_0[num].uint_0[i, 4]
							};
							num6 = Class60.smethod_18(uint_2, uint_1);
						}
						else
						{
							uint[] uint_3 = new uint[]
							{
								Class101.struct28_0[num].uint_0[i, 0],
								Class101.struct28_0[num].uint_0[i, 1]
							};
							num6 = Class60.smethod_18(uint_0, uint_3);
						}
						bool flag13 = num4 < 0 || num6 < num5;
						if (flag13)
						{
							num5 = num6;
							num4 = i;
						}
					}
					result = new uint[]
					{
						Class101.struct28_0[num].uint_0[num4, 0],
						Class101.struct28_0[num].uint_0[num4, 1],
						Class101.struct28_0[num].uint_0[num4, 2]
					};
				}
				else
				{
					result = new uint[]
					{
						Class101.struct28_0[num].uint_0[0, 0],
						Class101.struct28_0[num].uint_0[0, 1],
						Class101.struct28_0[num].uint_0[0, 2]
					};
				}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00007384 File Offset: 0x00005584
		public static int smethod_2(int int_0, int int_1 = 0)
		{
			int num = 0;
			for (;;)
			{
				bool flag = num < Class101.struct29_0.Length;
				if (!flag)
				{
					goto IL_4D;
				}
				bool flag2 = (int_1 == 0 && int_0 == Class101.struct29_0[num].int_0) || int_0 == Class101.struct29_0[num].int_1;
				if (flag2)
				{
					break;
				}
				num++;
			}
			return num;
			IL_4D:
			return -1;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000073EC File Offset: 0x000055EC
		public static void smethod_3()
		{
			string text = Class12.smethod_15(Class62.smethod_6("tbXpCongthanh", 0, "0"));
			bool flag = text == null || text == string.Empty;
			if (flag)
			{
				text = Class12.smethod_15(Class12.smethod_33(Class53.string_9 + "\\XaphuCT.txt", 1, 1, 1));
			}
			bool flag2 = text == null || text == string.Empty;
			if (!flag2)
			{
				string[] array = text.Split(new char[]
				{
					'|'
				});
				bool flag3 = array.Length != 7;
				if (!flag3)
				{
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(new char[]
						{
							';'
						});
						bool flag4 = array2.Length != 4;
						if (!flag4)
						{
							int num = Class12.smethod_11(array2[0]);
							for (int j = 0; j < Class101.struct29_0.Length; j++)
							{
								bool flag5 = num == Class101.struct29_0[j].int_0;
								if (flag5)
								{
									Class101.struct29_0[j].string_0 = array2[1];
									Class101.struct29_0[j].uint_0 = new uint[]
									{
										Class12.smethod_12(array2[2]),
										Class12.smethod_12(array2[3])
									};
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00007558 File Offset: 0x00005758
		public static void smethod_4()
		{
			string text = null;
			for (int i = 0; i < Class101.struct29_0.Length; i++)
			{
				string text2 = string.Empty;
				string text3 = string.Empty;
				bool flag = Class101.struct29_0[i].string_0 != null;
				if (flag)
				{
					text2 = Class101.struct29_0[i].string_0;
				}
				bool flag2 = Class101.struct29_0[i].uint_0 != null;
				if (flag2)
				{
					text3 = Class101.struct29_0[i].uint_0[0].ToString() + ";" + Class101.struct29_0[i].uint_0[1].ToString();
				}
				bool flag3 = text != null;
				if (flag3)
				{
					text += "|";
				}
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					Class101.struct29_0[i].int_0,
					";",
					text2,
					";",
					text3
				});
			}
			string text4 = Class12.smethod_16(text);
			Class62.smethod_10(Class53.string_3, "tbXpCongthanh", text4, "", 0);
			Class12.smethod_34(Class53.string_9 + "\\XaphuCT.txt", text4, 1);
		}

		// Token: 0x0400000A RID: 10
		public static Class101.Struct28[] struct28_0 = new Class101.Struct28[]
		{
			new Class101.Struct28
			{
				int_0 = 926,
				int_1 = 931,
				uint_0 = new uint[,]
				{
					{
						62591U,
						111948U,
						10U,
						49089U,
						114530U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 926,
				int_1 = 929,
				uint_0 = new uint[,]
				{
					{
						60215U,
						102946U,
						60U,
						51752U,
						121284U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 926,
				int_1 = 928,
				uint_0 = new uint[,]
				{
					{
						52867U,
						117368U,
						270U,
						52550U,
						90290U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 931,
				int_1 = 928,
				uint_0 = new uint[,]
				{
					{
						61745U,
						115530U,
						300U,
						60847U,
						89656U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 931,
				int_1 = 932,
				uint_0 = new uint[,]
				{
					{
						59558U,
						96972U,
						90U,
						59702U,
						117338U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 931,
				int_1 = 929,
				uint_0 = new uint[,]
				{
					{
						49258U,
						102396U,
						180U,
						55294U,
						121566U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 931,
				int_1 = 926,
				uint_0 = new uint[,]
				{
					{
						49089U,
						114530U,
						210U,
						62591U,
						111948U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 929,
				int_1 = 931,
				uint_0 = new uint[,]
				{
					{
						55294U,
						121566U,
						300U,
						49258U,
						102396U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 929,
				int_1 = 926,
				uint_0 = new uint[,]
				{
					{
						51752U,
						121284U,
						290U,
						60215U,
						102946U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 929,
				int_1 = 927,
				uint_0 = new uint[,]
				{
					{
						62543U,
						117344U,
						10U,
						58651U,
						120200U
					},
					{
						61848U,
						106546U,
						45U,
						50223U,
						117756U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 927,
				int_1 = 929,
				uint_0 = new uint[,]
				{
					{
						58651U,
						120200U,
						270U,
						62543U,
						117344U
					},
					{
						50223U,
						117756U,
						210U,
						61848U,
						106546U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 927,
				int_1 = 932,
				uint_0 = new uint[,]
				{
					{
						64664U,
						116708U,
						300U,
						50354U,
						116010U
					},
					{
						64396U,
						104626U,
						60U,
						49931U,
						111512U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 932,
				int_1 = 931,
				uint_0 = new uint[,]
				{
					{
						59702U,
						117338U,
						300U,
						59558U,
						96972U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 932,
				int_1 = 927,
				uint_0 = new uint[,]
				{
					{
						50354U,
						116010U,
						180U,
						64664U,
						116708U
					},
					{
						49931U,
						111512U,
						200U,
						64396U,
						104626U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 932,
				int_1 = 930,
				uint_0 = new uint[,]
				{
					{
						63495U,
						104826U,
						10U,
						52704U,
						118798U
					},
					{
						60085U,
						99912U,
						45U,
						49935U,
						117436U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 930,
				int_1 = 932,
				uint_0 = new uint[,]
				{
					{
						52704U,
						118798U,
						200U,
						63495U,
						104826U
					},
					{
						49935U,
						117436U,
						210U,
						60085U,
						99912U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 930,
				int_1 = 928,
				uint_0 = new uint[,]
				{
					{
						64579U,
						117034U,
						300U,
						64857U,
						98502U
					},
					{
						64723U,
						112854U,
						300U,
						64895U,
						104208U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 928,
				int_1 = 931,
				uint_0 = new uint[,]
				{
					{
						60847U,
						89656U,
						90U,
						61745U,
						115530U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 928,
				int_1 = 930,
				uint_0 = new uint[,]
				{
					{
						64857U,
						98502U,
						40U,
						64579U,
						117034U
					},
					{
						64895U,
						104208U,
						40U,
						64723U,
						112854U
					}
				}
			},
			new Class101.Struct28
			{
				int_0 = 928,
				int_1 = 926,
				uint_0 = new uint[,]
				{
					{
						52550U,
						90290U,
						90U,
						52867U,
						117368U
					}
				}
			}
		};

		// Token: 0x0400000B RID: 11
		public static Class101.Struct29[] struct29_0 = new Class101.Struct29[]
		{
			new Class101.Struct29
			{
				int_0 = 78,
				int_1 = 931,
				string_2 = "Tương Dương",
				string_1 = "T­¬ng D­¬ng"
			},
			new Class101.Struct29
			{
				int_0 = 80,
				int_1 = 932,
				string_2 = "Dương Châu",
				string_1 = "D­¬ng Ch©u"
			},
			new Class101.Struct29
			{
				int_0 = 1,
				int_1 = 929,
				string_2 = "Phượng Tường",
				string_1 = "Ph­îng T­êng"
			},
			new Class101.Struct29
			{
				int_0 = 162,
				int_1 = 928,
				string_2 = "Đại Lý",
				string_1 = "§¹i Lý"
			},
			new Class101.Struct29
			{
				int_0 = 11,
				int_1 = 926,
				string_2 = "Thành Đô",
				string_1 = "Thµnh §«"
			},
			new Class101.Struct29
			{
				int_0 = 176,
				int_1 = 930,
				string_2 = "Lâm An",
				string_1 = "L©m An"
			},
			new Class101.Struct29
			{
				int_0 = 37,
				int_1 = 927,
				string_2 = "Biện Kinh",
				string_1 = "BiÖn Kinh"
			}
		};

		// Token: 0x020000E6 RID: 230
		public struct Struct28
		{
			// Token: 0x0400120E RID: 4622
			public int int_0;

			// Token: 0x0400120F RID: 4623
			public uint[,] uint_0;

			// Token: 0x04001210 RID: 4624
			public int int_1;
		}

		// Token: 0x020000E7 RID: 231
		public struct Struct29
		{
			// Token: 0x04001211 RID: 4625
			public string string_0;

			// Token: 0x04001212 RID: 4626
			public uint[] uint_0;

			// Token: 0x04001213 RID: 4627
			public int int_0;

			// Token: 0x04001214 RID: 4628
			public int int_1;

			// Token: 0x04001215 RID: 4629
			public string string_1;

			// Token: 0x04001216 RID: 4630
			public string string_2;
		}
	}
}
