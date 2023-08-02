using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace AutoKeoxe
{
	// Token: 0x0200000B RID: 11
	internal class Class13
	{
		// Token: 0x0600007C RID: 124 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		static Class13()
		{
			Class13.int_0 = int.MaxValue;
			Class13.int_1 = int.MinValue;
			Class13.memoryStream_0 = new MemoryStream(0);
			Class13.memoryStream_1 = new MemoryStream(0);
			Class13.object_0 = new object();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		private static string smethod_0(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			bool flag = num >= 0;
			if (flag)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000CA64 File Offset: 0x0000AC64
		private static byte[] smethod_1(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				bool flag = num < 0;
				if (flag)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				bool flag2 = num >= 0;
				if (!flag2)
				{
					return null;
				}
				num += 15;
				bool flag3 = fullName[num] == 'n' || fullName[num] == 'N';
				if (flag3)
				{
					return null;
				}
				string s = fullName.Substring(num, 16);
				long value = long.Parse(s, NumberStyles.HexNumber);
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse(bytes);
				return bytes;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000CB20 File Offset: 0x0000AD20
		internal static byte[] smethod_2(Stream stream_0)
		{
			object obj = Class13.object_0;
			byte[] result;
			lock (obj)
			{
				result = Class13.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000CB68 File Offset: 0x0000AD68
		internal static byte[] smethod_3(long long_0, Stream stream_0)
		{
			byte[] result;
			try
			{
				result = Class13.smethod_2(stream_0);
			}
			catch
			{
				result = Class13.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		internal static byte[] smethod_4(long long_0, object object_1)
		{
			Stream stream = object_1 as Stream;
			Stream stream2 = stream;
			MemoryStream memoryStream = null;
			for (int i = 1; i < 4; i++)
			{
				stream.ReadByte();
			}
			ushort num = (ushort)stream.ReadByte();
			num = ~num;
			bool flag = (num & 2) > 0;
			if (flag)
			{
				DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				stream.Read(array, 0, 8);
				descryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				stream.Read(array2, 0, 8);
				bool flag2 = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					bool flag3 = array3[j] > 0;
					if (flag3)
					{
						flag2 = false;
						break;
					}
				}
				bool flag4 = flag2;
				if (flag4)
				{
					array2 = Class13.smethod_1(Assembly.GetExecutingAssembly());
				}
				descryptoServiceProvider.Key = array2;
				bool flag5 = Class13.memoryStream_0 == null;
				if (flag5)
				{
					bool flag6 = Class13.int_0 == int.MaxValue;
					if (flag6)
					{
						Class13.memoryStream_0.Capacity = (int)stream.Length;
					}
					else
					{
						Class13.memoryStream_0.Capacity = Class13.int_0;
					}
				}
				Class13.memoryStream_0.Position = 0L;
				ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
				int inputBlockSize = cryptoTransform.InputBlockSize;
				int outputBlockSize = cryptoTransform.OutputBlockSize;
				byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
				byte[] array5 = new byte[cryptoTransform.InputBlockSize];
				int num2 = (int)stream.Position;
				while ((long)(num2 + inputBlockSize) < stream.Length)
				{
					stream.Read(array5, 0, inputBlockSize);
					int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
					Class13.memoryStream_0.Write(array4, 0, count);
					num2 += inputBlockSize;
				}
				stream.Read(array5, 0, (int)(stream.Length - (long)num2));
				byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - (long)num2));
				Class13.memoryStream_0.Write(array6, 0, array6.Length);
				stream2 = Class13.memoryStream_0;
				stream2.Position = 0L;
				memoryStream = Class13.memoryStream_0;
			}
			bool flag7 = (num & 8) > 0;
			if (flag7)
			{
				bool flag8 = Class13.memoryStream_1 == null;
				if (flag8)
				{
					bool flag9 = Class13.int_1 != int.MinValue;
					if (flag9)
					{
						Class13.memoryStream_1.Capacity = Class13.int_1;
					}
					else
					{
						Class13.memoryStream_1.Capacity = (int)stream2.Length * 2;
					}
				}
				Class13.memoryStream_1.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = new byte[1000];
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					bool flag10 = num4 > 0;
					if (flag10)
					{
						Class13.memoryStream_1.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				memoryStream = Class13.memoryStream_1;
			}
			bool flag11 = memoryStream == null;
			byte[] result;
			if (flag11)
			{
				byte[] array7 = new byte[stream.Length - stream.Position];
				stream.Read(array7, 0, array7.Length);
				result = array7;
			}
			else
			{
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x04000053 RID: 83
		private static readonly object object_0;

		// Token: 0x04000054 RID: 84
		private static readonly int int_0;

		// Token: 0x04000055 RID: 85
		private static readonly int int_1;

		// Token: 0x04000056 RID: 86
		private static readonly MemoryStream memoryStream_0 = null;

		// Token: 0x04000057 RID: 87
		private static readonly MemoryStream memoryStream_1 = null;

		// Token: 0x04000058 RID: 88
		private static readonly byte byte_0;
	}
}
