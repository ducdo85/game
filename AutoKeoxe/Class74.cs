using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace AutoKeoxe
{
	// Token: 0x02000048 RID: 72
	internal class Class74
	{
		// Token: 0x06000474 RID: 1140 RVA: 0x000C4D74 File Offset: 0x000C2F74
		public void method_0(object object_0)
		{
			try
			{
				NetworkStream networkStream = (NetworkStream)object_0;
				byte[] buffer = new byte[]
				{
					1
				};
				while (!Class12.bool_0 && Class72.int_0 > 0 && 0L <= this.long_0)
				{
					bool flag = Class12.smethod_28(this.long_0) > 1000L;
					if (flag)
					{
						networkStream.Write(buffer, 0, 1);
						this.long_0 = Class12.smethod_27();
					}
					Thread.Sleep(300);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000C4E10 File Offset: 0x000C3010
		public void method_1()
		{
			bool flag = Class72.string_2 != null && !(Class72.string_2 == string.Empty);
			if (flag)
			{
				bool flag2 = Class72.string_1 == null || Class72.string_1 == string.Empty;
				if (flag2)
				{
					Class72.string_1 = "127.0.0.0";
				}
				int num = 256;
				byte[] buffer = new byte[]
				{
					1
				};
				byte[] array = new byte[num];
				byte[] bytes = Encoding.ASCII.GetBytes(Class72.string_1 + "...");
				bool flag3 = false;
				int num2 = 0;
				for (;;)
				{
					Thread.Sleep(600);
					bool flag4 = Class12.bool_0 || Class72.int_0 <= 0;
					if (flag4)
					{
						break;
					}
					bool flag5 = !flag3;
					if (flag5)
					{
						Class72.string_0 = Class72.smethod_2() + "\tChờ kết nối đến " + Class72.string_2 + "...";
						flag3 = true;
					}
					try
					{
						this.tcpClient_0 = new TcpClient(Class72.string_2, Class72.int_3);
						this.networkStream_0 = this.tcpClient_0.GetStream();
						this.networkStream_0.Write(bytes, 0, bytes.Length);
						Class72.string_0 = Class72.smethod_2() + "\tKết nối thành công";
						flag3 = false;
						this.long_0 = 0L;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_0), this.networkStream_0);
						int num3 = 0;
						for (;;)
						{
							num3++;
							Class72.long_0 += 1L;
							Thread.Sleep(130);
							bool flag6 = !Class12.bool_0 && Class72.int_0 > 0;
							if (!flag6)
							{
								break;
							}
							this.long_0 = Class12.smethod_27();
							int num4 = this.networkStream_0.Read(array, 0, array.Length);
							bool flag7 = num4 > 0;
							if (flag7)
							{
								string @string = Encoding.ASCII.GetString(array, 0, num4);
								bool flag8 = @string != string.Empty && @string != null;
								if (flag8)
								{
									bool flag9 = num2 == 0;
									if (flag9)
									{
										bool flag10 = @string[0] == 'U' && @string[1] == 'P';
										if (flag10)
										{
											array = new byte[2048];
											num2 = 1;
										}
									}
									else
									{
										num2++;
										bool flag11 = @string[0] == '@' || num2 > 300;
										if (flag11)
										{
											array = new byte[num];
											num2 = 0;
										}
									}
									Class72.smethod_4(@string);
								}
								num3 = 0;
							}
							this.networkStream_0.Write(buffer, 0, 1);
							if (num3 >= 60)
							{
								goto Block_21;
							}
						}
						this.networkStream_0.Close();
						return;
						Block_21:;
					}
					catch
					{
					}
					bool flag12 = !flag3;
					if (flag12)
					{
						Class72.string_0 = Class72.smethod_2() + "\tGián đoạn.";
					}
					this.method_2();
					Thread.Sleep(999);
				}
				Class72.string_0 = Class72.smethod_2() + "\tKết thúc.";
				this.method_2();
			}
			else
			{
				Class72.string_0 = "Chưa thiết lập IP máy phụ.";
				this.method_2();
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000C514C File Offset: 0x000C334C
		public void method_2()
		{
			try
			{
				this.networkStream_0.Close();
			}
			catch
			{
			}
			try
			{
				this.tcpClient_0.Close();
			}
			catch
			{
			}
		}

		// Token: 0x04000396 RID: 918
		public TcpClient tcpClient_0 = null;

		// Token: 0x04000397 RID: 919
		public NetworkStream networkStream_0 = null;

		// Token: 0x04000398 RID: 920
		private long long_0 = 0L;
	}
}
