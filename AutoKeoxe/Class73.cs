using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000047 RID: 71
	internal class Class73
	{
		// Token: 0x06000470 RID: 1136 RVA: 0x000C4954 File Offset: 0x000C2B54
		private void method_0(object object_0)
		{
			TcpClient tcpClient = (TcpClient)object_0;
			NetworkStream stream = tcpClient.GetStream();
			byte[] array = new byte[80];
			string text = null;
			string text2 = null;
			Class72.long_0 = 0L;
			try
			{
				bool flag = false;
				while (!Class12.bool_0 && Class72.int_0 > 0)
				{
					Class72.long_0 += 1L;
					Thread.Sleep(120);
					int num = stream.Read(array, 0, array.Length);
					bool flag2 = num <= 0;
					if (!flag2)
					{
						bool flag3 = array[0] != 1;
						if (flag3)
						{
							string @string = Encoding.ASCII.GetString(array, 0, num);
							bool flag4 = 0 > @string.IndexOf("...");
							if (flag4)
							{
								Class72.string_0 = @string;
							}
							else
							{
								text = @string;
								Class72.string_0 = Class72.smethod_2() + "\t" + text + "client connect.";
							}
						}
						else
						{
							bool flag5 = !flag;
							if (flag5)
							{
								string text3 = null;
								bool bool_ = FormMayphu.bool_8;
								if (bool_)
								{
									bool flag6 = FormMayphu.long_0 == 0L || text2 == null;
									if (flag6)
									{
										FormMayphu.long_0 = Class12.smethod_27();
										text2 = "UP:" + FormMayphu.smethod_0();
									}
									bool flag7 = Class12.smethod_28(FormMayphu.long_0) >= FormMayphu.long_1;
									if (flag7)
									{
										FormMayphu.bool_8 = false;
										FormMayphu.long_0 = 0L;
										text2 = null;
									}
									else
									{
										text3 = text2;
									}
								}
								else
								{
									text3 = Class72.smethod_5();
								}
								bool flag8 = text3 != null && text3 != string.Empty;
								if (flag8)
								{
									byte[] bytes = Encoding.ASCII.GetBytes(text3);
									stream.Write(bytes, 0, bytes.Length);
								}
							}
							else
							{
								byte[] array2 = new byte[]
								{
									46,
									46,
									46,
									0
								};
								stream.Write(array2, 0, array2.Length);
								Thread.Sleep(180);
							}
							flag = (Class44.gstruct33_0.int_0 <= 0);
						}
					}
				}
			}
			catch
			{
			}
			try
			{
				bool flag9 = text != null;
				if (flag9)
				{
					Class72.string_0 = Class72.smethod_2() + "\t" + text + "client exit.";
				}
				tcpClient.Close();
			}
			catch
			{
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000C4BBC File Offset: 0x000C2DBC
		public void method_1()
		{
			bool flag = Class72.string_1 != null && !(Class72.string_1 == string.Empty);
			if (flag)
			{
				bool flag2 = Class72.int_2 <= 0;
				if (flag2)
				{
					Class72.int_2 = new Random().Next(5000, 20000);
				}
				Class72.string_0 = Class72.smethod_2() + "\tKhởi tạo server...";
				try
				{
					IPAddress localaddr = IPAddress.Parse(Class72.string_1);
					this.tcpListener_0 = new TcpListener(localaddr, Class72.int_2);
					this.tcpListener_0.Start();
					Class72.string_0 = Class72.smethod_2() + "\tThành công!";
					while (!Class12.bool_0 && Class72.int_0 > 0)
					{
						TcpClient state = this.tcpListener_0.AcceptTcpClient();
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_0), state);
						Thread.Sleep(600);
					}
					Class72.string_0 = Class72.smethod_2() + "\tKết thúc server.";
					this.method_2();
				}
				catch
				{
					this.method_2();
					bool flag3 = Class72.int_0 > 0;
					if (flag3)
					{
						Class72.string_0 = Class72.smethod_2() + "\tSever có lỗi, hãy thử đổi password khác...";
						Class72.int_0 = 0;
					}
				}
			}
			else
			{
				Class72.string_0 = "Chưa thiết lập IP máy chính.";
				this.method_2();
				Class72.int_0 = 0;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000C4D30 File Offset: 0x000C2F30
		public void method_2()
		{
			try
			{
				this.tcpListener_0.Stop();
			}
			catch
			{
			}
		}

		// Token: 0x04000395 RID: 917
		public TcpListener tcpListener_0 = null;
	}
}
