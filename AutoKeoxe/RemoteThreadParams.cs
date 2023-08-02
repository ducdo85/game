using System;
using System.Runtime.InteropServices;

namespace AutoKeoxe
{
	// Token: 0x020000D7 RID: 215
	public struct RemoteThreadParams
	{
		// Token: 0x040010C6 RID: 4294
		public uint Param1;

		// Token: 0x040010C7 RID: 4295
		[MarshalAs(UnmanagedType.LPStr)]
		public string Param2;

		// Token: 0x040010C8 RID: 4296
		[MarshalAs(UnmanagedType.LPStr)]
		public string Param3;

		// Token: 0x040010C9 RID: 4297
		[MarshalAs(UnmanagedType.LPStr)]
		public string Param4;

		// Token: 0x040010CA RID: 4298
		public int Param5;
	}
}
