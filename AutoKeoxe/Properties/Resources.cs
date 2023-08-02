using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AutoKeoxe.Properties
{
	// Token: 0x020000E2 RID: 226
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000C24 RID: 3108 RVA: 0x0000DEC5 File Offset: 0x0000C0C5
		internal Resources()
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0019B504 File Offset: 0x00199704
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("AutoKeoxe.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0019B54C File Offset: 0x0019974C
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0019B563 File Offset: 0x00199763
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0019B56C File Offset: 0x0019976C
		internal static byte[] Sign
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Sign", Resources.resourceCulture);
				return (byte[])@object;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0019B59C File Offset: 0x0019979C
		internal static Bitmap updated
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("updated", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04001145 RID: 4421
		private static ResourceManager resourceMan;

		// Token: 0x04001146 RID: 4422
		private static CultureInfo resourceCulture;
	}
}
