using System;
using System.Runtime.InteropServices;

namespace AutoKeoxe
{
	// Token: 0x020000DD RID: 221
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct Struct7
	{
		// Token: 0x040010F9 RID: 4345
		public byte byte_0;

		// Token: 0x040010FA RID: 4346
		public byte byte_1;

		// Token: 0x040010FB RID: 4347
		public byte byte_2;

		// Token: 0x040010FC RID: 4348
		public byte byte_3;

		// Token: 0x040010FD RID: 4349
		public uint uint_0;

		// Token: 0x040010FE RID: 4350
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public uint[] uint_1;
	}
}
