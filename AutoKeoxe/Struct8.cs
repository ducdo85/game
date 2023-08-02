using System;
using System.Runtime.InteropServices;

namespace AutoKeoxe
{
	// Token: 0x020000DE RID: 222
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct8
	{
		// Token: 0x040010FF RID: 4351
		public uint uint_0;

		// Token: 0x04001100 RID: 4352
		public Struct9 struct9_0;

		// Token: 0x04001101 RID: 4353
		public byte byte_0;

		// Token: 0x04001102 RID: 4354
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
		public byte[] byte_1;

		// Token: 0x04001103 RID: 4355
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] uint_1;

		// Token: 0x04001104 RID: 4356
		public byte byte_2;
	}
}
