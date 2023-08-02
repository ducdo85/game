using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoKeoxe
{
	// Token: 0x020000D6 RID: 214
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[ComImport]
	internal interface Interface0
	{
		// Token: 0x06000BE0 RID: 3040
		void imethod_0([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out IntPtr intptr_0, int int_1);

		// Token: 0x06000BE1 RID: 3041
		void imethod_1(out IntPtr intptr_0);

		// Token: 0x06000BE2 RID: 3042
		void imethod_2(IntPtr intptr_0);

		// Token: 0x06000BE3 RID: 3043
		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000BE4 RID: 3044
		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000BE5 RID: 3045
		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000BE6 RID: 3046
		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000BE7 RID: 3047
		void imethod_7([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0);

		// Token: 0x06000BE8 RID: 3048
		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		// Token: 0x06000BE9 RID: 3049
		void imethod_9(out short short_0);

		// Token: 0x06000BEA RID: 3050
		void imethod_10(short short_0);

		// Token: 0x06000BEB RID: 3051
		void imethod_11(out int int_0);

		// Token: 0x06000BEC RID: 3052
		void imethod_12(int int_0);

		// Token: 0x06000BED RID: 3053
		void imethod_13([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder stringBuilder_0, int int_0, out int int_1);

		// Token: 0x06000BEE RID: 3054
		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06000BEF RID: 3055
		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		// Token: 0x06000BF0 RID: 3056
		void imethod_16(IntPtr intptr_0, int int_0);

		// Token: 0x06000BF1 RID: 3057
		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}
}
