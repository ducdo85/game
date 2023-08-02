using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200001A RID: 26
	internal static class Program
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00018490 File Offset: 0x00016690
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[Program.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000184DC File Offset: 0x000166DC
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				Application.Run(new Form1());
			}
			catch
			{
			}
		}

		// Token: 0x040000DB RID: 219
		private static Random random = new Random();
	}
}
