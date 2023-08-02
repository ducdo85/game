using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AutoKeoxe
{
	// Token: 0x02000090 RID: 144
	public class GClass0
	{
		// Token: 0x06000BC7 RID: 3015
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int int_5, GClass0.Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

		// Token: 0x06000BC8 RID: 3016
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

		// Token: 0x06000BC9 RID: 3017
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_5, IntPtr intptr_2, IntPtr intptr_3);

		// Token: 0x06000BCA RID: 3018
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern IntPtr GetModuleHandle(string string_0);

		// Token: 0x06000BCB RID: 3019 RVA: 0x00194CCF File Offset: 0x00192ECF
		public static void smethod_0()
		{
			GClass0.intptr_0 = GClass0.smethod_2(GClass0.delegate0_0);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x00194CE1 File Offset: 0x00192EE1
		public static void smethod_1()
		{
			GClass0.UnhookWindowsHookEx(GClass0.intptr_0);
			GClass0.bool_1 = false;
			GClass0.bool_2 = false;
			GClass0.int_4 = 0;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00194D04 File Offset: 0x00192F04
		private static IntPtr smethod_2(GClass0.Delegate0 delegate0_1)
		{
			IntPtr result;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				using (ProcessModule mainModule = currentProcess.MainModule)
				{
					result = GClass0.SetWindowsHookEx(13, delegate0_1, GClass0.GetModuleHandle(mainModule.ModuleName), 0U);
				}
			}
			return result;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00194D6C File Offset: 0x00192F6C
		private static IntPtr smethod_3(int int_5, IntPtr intptr_1, IntPtr intptr_2)
		{
			try
			{
				return GClass0.smethod_4(int_5, intptr_1, intptr_2);
			}
			catch
			{
			}
			return IntPtr.Zero;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00194DA4 File Offset: 0x00192FA4
		private static IntPtr smethod_4(int int_5, IntPtr intptr_1, IntPtr intptr_2)
		{
			bool flag = int_5 >= 0;
			if (flag)
			{
				GClass0.int_4 = Marshal.ReadInt32(intptr_2);
				bool flag2 = Class22.int_22 != (int)intptr_1;
				if (flag2)
				{
					bool flag3 = Class22.int_23 == (int)intptr_1;
					if (flag3)
					{
						bool flag4 = GClass0.int_4 == 32;
						if (flag4)
						{
							Class44.gstruct33_0.int_8 = 0;
						}
						bool flag5 = GClass0.int_4 == 162 || GClass0.int_4 == 163;
						if (flag5)
						{
							GClass0.bool_1 = false;
						}
						else
						{
							bool flag6 = GClass0.int_4 != 164 && GClass0.int_4 != 165;
							if (flag6)
							{
								bool flag7 = GClass0.int_4 == 160 || GClass0.int_4 == 161;
								if (flag7)
								{
									GClass0.bool_4 = false;
								}
							}
							else
							{
								GClass0.bool_3 = false;
							}
						}
						bool flag8 = GClass0.int_4 <= 48 || 58 <= GClass0.int_4;
						if (flag8)
						{
							GClass0.bool_2 = false;
						}
						GClass0.int_4 = 0;
					}
				}
				else
				{
					GClass0.int_1 = GClass0.int_4;
					bool flag9 = GClass0.int_4 == 32;
					if (flag9)
					{
						Class44.gstruct33_0.int_8 = 1;
						GClass0.bool_2 = true;
					}
					else
					{
						bool flag10 = 48 < GClass0.int_4 && GClass0.int_4 < 58 && Class76.gstruct49_0.int_136 > 0;
						if (flag10)
						{
							GClass0.smethod_5(GClass0.int_4);
						}
					}
					bool flag11 = GClass0.int_4 == Class27.int_7 || GClass0.int_4 == Class27.int_8;
					if (flag11)
					{
						Class44.gstruct33_0.int_9 = 1;
						Class76.int_2 = 1;
					}
					else
					{
						bool flag12 = GClass0.int_4 == Class27.int_9 || GClass0.int_4 == Class27.int_10;
						if (flag12)
						{
							Class44.gstruct33_0.int_9 = 2;
							Class76.int_2 = 2;
						}
					}
					bool flag13 = GClass0.int_4 == 162 || GClass0.int_4 == 163;
					if (flag13)
					{
						GClass0.bool_1 = true;
					}
					else
					{
						bool flag14 = GClass0.int_4 == 164 || GClass0.int_4 == 165;
						if (flag14)
						{
							GClass0.bool_3 = true;
						}
						else
						{
							bool flag15 = GClass0.int_4 == 160 || GClass0.int_4 == 161;
							if (flag15)
							{
								GClass0.bool_4 = true;
							}
						}
					}
				}
				bool flag16 = Class76.gstruct49_0.int_136 > 0;
				if (flag16)
				{
					bool flag17 = GClass0.bool_1;
					if (flag17)
					{
						bool flag18 = GClass0.int_4 != Class27.int_11;
						if (flag18)
						{
							bool flag19 = GClass0.int_4 == Class27.int_12;
							if (flag19)
							{
								Class76.int_1 = 2;
							}
							else
							{
								bool flag20 = GClass0.int_4 == Class27.int_13;
								if (flag20)
								{
									Class76.int_1 = 3;
								}
								else
								{
									bool flag21 = GClass0.int_4 == Class27.int_14;
									if (flag21)
									{
										Class70.smethod_2(Class76.gstruct49_0, Class70.uint_21, 1, 4);
									}
									else
									{
										bool flag22 = GClass0.int_4 != Class27.int_15;
										if (flag22)
										{
											bool flag23 = GClass0.int_4 == Class27.int_16;
											if (flag23)
											{
												bool flag24 = !GClass0.bool_3;
												if (flag24)
												{
													Class76.int_1 = 5;
												}
												else
												{
													Class76.int_1 = 6;
												}
											}
											else
											{
												bool flag25 = GClass0.int_4 == Class27.int_17;
												if (flag25)
												{
													Class70.smethod_2(Class76.gstruct49_0, Class70.uint_21, 3, 4);
												}
												else
												{
													bool flag26 = GClass0.int_4 == Class27.int_1;
													if (flag26)
													{
														Class76.int_1 = 7;
													}
													else
													{
														bool flag27 = GClass0.int_4 == 9;
														if (flag27)
														{
															GClass0.bool_0 = true;
														}
														else
														{
															bool flag28 = !GClass0.bool_3;
															if (flag28)
															{
																bool flag29 = GClass0.bool_4 && FormDame.int_8 > 0;
																if (flag29)
																{
																	FormDame.int_7 = (int)(1 - Convert.ToByte(FormDame.int_7 > 0));
																}
															}
															else
															{
																bool flag30 = Form1.int_62 > 0;
																if (flag30)
																{
																	Form1.int_142 = 1;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											Class70.smethod_2(Class76.gstruct49_0, Class70.uint_21, 2, 4);
										}
									}
								}
							}
						}
						else
						{
							Class76.int_1 = 1;
						}
						bool flag31 = GClass0.bool_2;
						if (flag31)
						{
							FormTest.int_0 = 32;
						}
					}
					bool flag32 = GClass0.bool_2;
					if (flag32)
					{
						Class70.smethod_2(Class76.gstruct49_0, Class70.uint_21, 0, 4);
						bool flag33 = Form1.gstruct49_0 != null;
						if (flag33)
						{
							try
							{
								for (int i = 0; i < Form1.gstruct49_0.Length; i++)
								{
									Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_50, 0, 4);
								}
							}
							catch
							{
							}
						}
						bool flag34 = !FormPhongKy1.bool_1;
						if (flag34)
						{
							bool flag35 = FormPhongKy1.bool_2;
							if (flag35)
							{
								FormPhongKy1.bool_4 = true;
							}
						}
						else
						{
							FormPhongKy1.bool_3 = true;
						}
					}
				}
			}
			else
			{
				GClass0.int_4 = 0;
			}
			GClass0.int_2 = Class76.int_3;
			Class44.gstruct33_0.int_7 = GClass0.int_4;
			return GClass0.CallNextHookEx(GClass0.intptr_0, int_5, intptr_1, intptr_2);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x001952C8 File Offset: 0x001934C8
		private static void smethod_5(int int_5)
		{
			int num = int_5 - 49;
			bool flag = num < 0 || num > 8;
			if (!flag)
			{
				int num2 = 0;
				byte[] byte_ = new byte[]
				{
					1
				};
				bool flag2 = Form1.gstruct49_0 == null;
				if (!flag2)
				{
					try
					{
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							bool bool_ = Form1.gstruct49_0[i].bool_25;
							if (bool_)
							{
								Class22.WriteProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_15 + Class70.uint_45 * 4U + (uint)num, byte_, 1, ref num2);
							}
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x04000D9A RID: 3482
		private const int int_0 = 13;

		// Token: 0x04000D9B RID: 3483
		public static int int_1 = 0;

		// Token: 0x04000D9C RID: 3484
		public static int int_2 = 0;

		// Token: 0x04000D9D RID: 3485
		public static int int_3 = 121;

		// Token: 0x04000D9E RID: 3486
		public static bool bool_0 = false;

		// Token: 0x04000D9F RID: 3487
		public static IntPtr intptr_0 = IntPtr.Zero;

		// Token: 0x04000DA0 RID: 3488
		private static int int_4 = 0;

		// Token: 0x04000DA1 RID: 3489
		private static bool bool_1 = false;

		// Token: 0x04000DA2 RID: 3490
		private static bool bool_2 = false;

		// Token: 0x04000DA3 RID: 3491
		private static bool bool_3 = false;

		// Token: 0x04000DA4 RID: 3492
		private static bool bool_4 = false;

		// Token: 0x04000DA5 RID: 3493
		private static GClass0.Delegate0 delegate0_0 = new GClass0.Delegate0(GClass0.smethod_3);

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x06000C46 RID: 3142
		private delegate IntPtr Delegate0(int nCode, IntPtr wParam, IntPtr lParam);
	}
}
