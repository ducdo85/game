using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace AutoKeoxe
{
	// Token: 0x02000009 RID: 9
	internal class Class11
	{
		// Token: 0x06000026 RID: 38 RVA: 0x000092B4 File Offset: 0x000074B4
		static Class11()
		{
			bool flag = Class11.byte_0 == null;
			if (flag)
			{
				string text = "QXV0b0tlb3hlLlNpZ24=";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				Class11.byte_0 = Class13.smethod_3(97L, manifestResourceStream);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00009308 File Offset: 0x00007508
		internal static int smethod_0(int int_1)
		{
			return BitConverter.ToInt32(Class11.byte_0, int_1);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00009328 File Offset: 0x00007528
		internal static long smethod_1(int int_1)
		{
			return BitConverter.ToInt64(Class11.byte_0, int_1);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00009348 File Offset: 0x00007548
		internal static float smethod_2(int int_1)
		{
			return BitConverter.ToSingle(Class11.byte_0, int_1);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00009368 File Offset: 0x00007568
		internal static double smethod_3(int int_1)
		{
			return BitConverter.ToDouble(Class11.byte_0, int_1);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00009388 File Offset: 0x00007588
		internal static void smethod_4(Array array_0, int int_1)
		{
			bool flag = (Class11.byte_0[int_1] & 128) > 0;
			int num;
			if (flag)
			{
				bool flag2 = (Class11.byte_0[int_1] & 64) == 0;
				if (flag2)
				{
					num = ((int)Class11.byte_0[int_1] & -129) << 8;
					num |= (int)Class11.byte_0[int_1 + 1];
					int_1 += 2;
				}
				else
				{
					num = ((int)Class11.byte_0[int_1] & -193) << 24;
					num |= (int)Class11.byte_0[int_1 + 1] << 16;
					num |= (int)Class11.byte_0[int_1 + 2] << 8;
					num |= (int)Class11.byte_0[int_1 + 3];
					int_1 += 4;
				}
			}
			else
			{
				num = (int)Class11.byte_0[int_1];
				int_1++;
			}
			bool flag3 = num >= 1;
			if (flag3)
			{
				Buffer.BlockCopy(Class11.byte_0, int_1, array_0, 0, num);
			}
		}

		// Token: 0x04000010 RID: 16
		internal static readonly byte[] byte_0;

		// Token: 0x04000011 RID: 17
		internal readonly int int_0;

		// Token: 0x04000012 RID: 18
		public static readonly string string_0;
	}
}
