using System;
using System.Collections.Generic;
using System.Net;

namespace AutoKeoxe
{
	// Token: 0x02000092 RID: 146
	public class GClass2 : WebClient
	{
		// Token: 0x06000BDC RID: 3036 RVA: 0x00196C63 File Offset: 0x00194E63
		public GClass2()
		{
			this.class68_0 = new GClass2.Class68();
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00196C78 File Offset: 0x00194E78
		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = base.GetWebRequest(address);
			bool flag = webRequest is HttpWebRequest;
			if (flag)
			{
				string text = this.class68_0[address];
				bool flag2 = text != null;
				if (flag2)
				{
					((HttpWebRequest)webRequest).Headers.Set("cookie", text);
				}
			}
			return webRequest;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x00196CD0 File Offset: 0x00194ED0
		protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			WebResponse webResponse = base.GetWebResponse(request, result);
			string[] values = webResponse.Headers.GetValues("Set-Cookie");
			bool flag = values != null && values.Length != 0;
			if (flag)
			{
				string text = "";
				string[] array = values;
				foreach (string str in array)
				{
					text += str;
				}
				this.class68_0[webResponse.ResponseUri] = text;
			}
			return webResponse;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x00196D58 File Offset: 0x00194F58
		protected override WebResponse GetWebResponse(WebRequest request)
		{
			WebResponse webResponse = base.GetWebResponse(request);
			string[] values = webResponse.Headers.GetValues("Set-Cookie");
			bool flag = values != null;
			if (flag)
			{
				bool flag2 = values.Length != 0;
				if (flag2)
				{
					string text = "";
					string[] array = values;
					foreach (string str in array)
					{
						text += str;
					}
					this.class68_0[webResponse.ResponseUri] = text;
				}
			}
			return webResponse;
		}

		// Token: 0x04000DBE RID: 3518
		private GClass2.Class68 class68_0;

		// Token: 0x02000105 RID: 261
		private class Class68
		{
			// Token: 0x1700000D RID: 13
			public string this[Uri uri_0]
			{
				get
				{
					string text;
					bool flag = this.dictionary_0.TryGetValue(uri_0.Host, out text);
					string result;
					if (flag)
					{
						result = text;
					}
					else
					{
						result = null;
					}
					return result;
				}
				set
				{
					this.dictionary_0[uri_0.Host] = value;
				}
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x0019BC58 File Offset: 0x00199E58
			public Class68()
			{
				this.dictionary_0 = new Dictionary<string, string>();
			}

			// Token: 0x04001288 RID: 4744
			private Dictionary<string, string> dictionary_0;
		}
	}
}
