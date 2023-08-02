using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AutoKeoxe
{
	// Token: 0x0200000E RID: 14
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Class16
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0000DD70 File Offset: 0x0000BF70
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				bool flag = Class16.resourceManager_0 == null;
				if (flag)
				{
					Class16.resourceManager_0 = new ResourceManager("Class16", typeof(Class16).Assembly);
				}
				return Class16.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000DDCF File Offset: 0x0000BFCF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			get
			{
				return Class16.cultureInfo_0;
			}
			set
			{
				Class16.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		internal static Bitmap Bitmap_0
		{
			get
			{
				object @object = Class16.ResourceManager_0.GetObject("0", Class16.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000DE08 File Offset: 0x0000C008
		internal static Bitmap Bitmap_1
		{
			get
			{
				object @object = Class16.ResourceManager_0.GetObject("1", Class16.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000DE38 File Offset: 0x0000C038
		internal static Bitmap Bitmap_2
		{
			get
			{
				object @object = Class16.ResourceManager_0.GetObject("2", Class16.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000DE68 File Offset: 0x0000C068
		internal static Bitmap Bitmap_3
		{
			get
			{
				object @object = Class16.ResourceManager_0.GetObject("3", Class16.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000DE98 File Offset: 0x0000C098
		internal static Bitmap Bitmap_4
		{
			get
			{
				object @object = Class16.ResourceManager_0.GetObject("nhapsoluong", Class16.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000DEC5 File Offset: 0x0000C0C5
		internal Class16()
		{
		}

		// Token: 0x0400005A RID: 90
		private static ResourceManager resourceManager_0;

		// Token: 0x0400005B RID: 91
		private static CultureInfo cultureInfo_0;
	}
}
