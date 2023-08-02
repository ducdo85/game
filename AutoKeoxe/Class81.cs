using System;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000050 RID: 80
	internal class Class81
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x000E29DC File Offset: 0x000E0BDC
		public static int smethod_0(ref GStruct49[] gstruct49_0, GStruct49 gstruct49_1)
		{
			bool flag = gstruct49_0 == null || gstruct49_0.Length == 0;
			int result;
			if (flag)
			{
				gstruct49_0 = new GStruct49[]
				{
					gstruct49_1
				};
				result = 0;
			}
			else
			{
				GStruct49[] array = new GStruct49[gstruct49_0.Length + 1];
				for (int i = 0; i < gstruct49_0.Length; i++)
				{
					bool flag2 = gstruct49_1.int_136 != gstruct49_0[i].int_136;
					if (!flag2)
					{
						gstruct49_0[i] = gstruct49_1;
						return i;
					}
					ref GStruct49 ptr = ref array[i];
					ptr = gstruct49_0[i];
				}
				int num = array.Length - 1;
				array[num] = gstruct49_1;
				gstruct49_0 = array;
				result = num;
			}
			return result;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x000E2A9C File Offset: 0x000E0C9C
		public static bool smethod_1(ref GStruct49[] gstruct49_0, GStruct49 gstruct49_1)
		{
			bool flag = gstruct49_0 == null || gstruct49_0.Length == 0;
			bool result;
			if (flag)
			{
				gstruct49_0 = null;
				result = true;
			}
			else
			{
				GStruct49[] array = new GStruct49[gstruct49_0.Length];
				int num = 0;
				for (int i = 0; i < gstruct49_0.Length; i++)
				{
					bool flag2 = gstruct49_1.int_136 != gstruct49_0[i].int_136;
					if (flag2)
					{
						ref GStruct49 ptr = ref array[num];
						ptr = gstruct49_0[i];
						num++;
					}
				}
				bool flag3 = num != 0;
				if (flag3)
				{
					bool flag4 = num != gstruct49_0.Length;
					if (flag4)
					{
						GStruct49[] array2 = new GStruct49[num];
						for (int j = 0; j < num; j++)
						{
							ref GStruct49 ptr2 = ref array2[j];
							ptr2 = array[j];
						}
						gstruct49_0 = array2;
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else
				{
					gstruct49_0 = null;
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x000E2B98 File Offset: 0x000E0D98
		public static int smethod_2(ListView listView_0, int int_0, GStruct49[] gstruct49_0)
		{
			bool flag = int_0 >= 0 && listView_0.Items.Count > int_0;
			if (flag)
			{
				int num = Class12.smethod_11(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
				bool flag2 = num > 0 && gstruct49_0 != null && gstruct49_0.Length != 0;
				if (flag2)
				{
					for (int i = 0; i < gstruct49_0.Length; i++)
					{
						bool flag3 = gstruct49_0[i].int_136 == num;
						if (flag3)
						{
							return i;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000E2C4C File Offset: 0x000E0E4C
		public static int smethod_3(GStruct49[] gstruct49_0, int int_0)
		{
			bool flag = int_0 > 0 && gstruct49_0 != null && gstruct49_0.Length != 0;
			if (flag)
			{
				for (int i = 0; i < gstruct49_0.Length; i++)
				{
					bool flag2 = gstruct49_0[i].int_136 == int_0;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x000E2CA4 File Offset: 0x000E0EA4
		public static int smethod_4(ListView listView_0, MouseEventArgs mouseEventArgs_0, int int_0 = 0)
		{
			try
			{
				ListViewItem itemAt = listView_0.GetItemAt(mouseEventArgs_0.X, mouseEventArgs_0.Y);
				bool flag = itemAt != null;
				if (flag)
				{
					string text = itemAt.SubItems[int_0].Text;
					for (int i = 0; i < listView_0.Items.Count; i++)
					{
						string text2 = listView_0.Items[i].SubItems[int_0].Text;
						bool flag2 = text == text2;
						if (flag2)
						{
							return i;
						}
					}
				}
			}
			catch
			{
			}
			return -1;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000E2D50 File Offset: 0x000E0F50
		public static void smethod_5(ListView listView_0, GStruct49 gstruct49_0)
		{
			string text = Class10.smethod_1(gstruct49_0.string_22, 1, false) + "|...|...|...|" + gstruct49_0.int_136.ToString();
			string[] array = text.Split(new char[]
			{
				'|'
			});
			ListViewItem listViewItem = new ListViewItem(array[0]);
			bool flag = array.Length > 1;
			if (flag)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			listView_0.Items.Add(listViewItem);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000E2DEC File Offset: 0x000E0FEC
		public static int smethod_6(ListView listView_0, GStruct49[] gstruct49_0, int int_0)
		{
			bool flag = int_0 >= 0 && gstruct49_0 != null;
			if (flag)
			{
				bool flag2 = int_0 < gstruct49_0.Length;
				if (flag2)
				{
					string b = gstruct49_0[int_0].int_136.ToString();
					int num = 0;
					for (;;)
					{
						bool flag3 = num < listView_0.Items.Count;
						if (!flag3)
						{
							goto IL_A1;
						}
						bool flag4 = listView_0.Items[num].SubItems[listView_0.Items[num].SubItems.Count - 1].Text == b;
						if (flag4)
						{
							break;
						}
						num++;
					}
					return num;
					IL_A1:
					return -1;
				}
			}
			return -1;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000E2EAC File Offset: 0x000E10AC
		public static int smethod_7(ListView listView_0, GStruct49 gstruct49_0)
		{
			string b = gstruct49_0.int_136.ToString();
			int num = 0;
			for (;;)
			{
				bool flag = num < listView_0.Items.Count;
				if (!flag)
				{
					goto IL_6B;
				}
				bool flag2 = listView_0.Items[num].SubItems[listView_0.Items[num].SubItems.Count - 1].Text == b;
				if (flag2)
				{
					break;
				}
				num++;
			}
			return num;
			IL_6B:
			return -1;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000E2F38 File Offset: 0x000E1138
		public static GStruct49 smethod_8(ListView listView_0, int int_0, GStruct49[] gstruct49_0)
		{
			bool flag = gstruct49_0 != null;
			if (flag)
			{
				int num = Class12.smethod_11(listView_0.Items[int_0].SubItems[listView_0.Items[int_0].SubItems.Count - 1].Text);
				for (int i = 0; i < gstruct49_0.Length; i++)
				{
					bool flag2 = gstruct49_0[i].int_136 == num;
					if (flag2)
					{
						return gstruct49_0[i];
					}
				}
			}
			return new GStruct49
			{
				int_136 = 0,
				string_22 = null
			};
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000E2FE0 File Offset: 0x000E11E0
		public static int smethod_9(ListView listView_0, int int_0)
		{
			int index = listView_0.Items[int_0].SubItems.Count - 1;
			return Class12.smethod_11(listView_0.Items[int_0].SubItems[index].Text);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x000E302C File Offset: 0x000E122C
		public static int smethod_10(ListView listView_0, int int_0)
		{
			string b = int_0.ToString();
			for (int i = 0; i < listView_0.Items.Count; i++)
			{
				bool flag = listView_0.Items[i].SubItems[listView_0.Items[i].SubItems.Count - 1].Text == b;
				if (flag)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
