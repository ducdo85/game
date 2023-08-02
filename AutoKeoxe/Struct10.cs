using System;
using System.Runtime.InteropServices;

namespace AutoKeoxe
{
	// Token: 0x020000D8 RID: 216
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct10
	{
		// Token: 0x040010CB RID: 4299
		public byte byte_0;

		// Token: 0x040010CC RID: 4300
		public byte byte_1;

		// Token: 0x040010CD RID: 4301
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public byte[] byte_2;

		// Token: 0x040010CE RID: 4302
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
		public uint[] uint_0;
	}
}
