using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000065 RID: 101
	public partial class FormAntivirus : Form
	{
		// Token: 0x060007CB RID: 1995 RVA: 0x0012D634 File Offset: 0x0012B834
		public FormAntivirus()
		{
			FormAntivirus.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0012D69C File Offset: 0x0012B89C
		private static void smethod_0()
		{
			long num = 0L;
			long num2 = 0L;
			while (!Class12.bool_0)
			{
				long ticks = DateTime.Now.Ticks;
				bool flag = num != 0L;
				if (flag)
				{
					long num3 = ticks - num;
					num = ticks;
					bool flag2 = num2 < num3;
					if (flag2)
					{
						num2 = num3;
					}
				}
				else
				{
					num = ticks;
				}
				Thread.Sleep(10);
				bool flag3 = GClass1.bool_0 && num2 != 0L && Class12.uint_1 > 0U && Class12.int_1 > 0;
				if (flag3)
				{
					int num4 = 0;
					byte b = Convert.ToByte(ticks > 0L && num > 0L && num2 > 0L && num2 < 22500000L);
					byte[] byte_ = new byte[]
					{
						b,
						1
					};
					Class22.WriteProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_1 * 4U, byte_, 2, ref num4);
					break;
				}
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0012D788 File Offset: 0x0012B988
		private static void smethod_1()
		{
			string string_ = "ᓛᓷᓮᓼᓿᓩᓺᓭᓤᓕᓱᓫᓺᓷᓻᓷᓮᓼᓤᓞᓱᓻᓽᓩᓴᓛᓼᓽᓬᓱᓷ";
			string string_2 = "ᓇᓩᓦᓡᓜᓚᓫᓄᓉᓌᓃᓠᓪᓫ";
			string string_3 = "ᓇᓜᓮᓯᓇᓪᓜᓟᓠᓟᓎᓪᓧᓰᓯᓤᓪᓩ";
			string text = Class12.smethod_53(string_);
			string[] array = Class62.smethod_9(text, true, false, 1);
			bool flag = array == null || array.Length == 0;
			if (!flag)
			{
				string[] array2 = new string[]
				{
					"kykeoxe",
					"lekeoxe",
					"jxkeoxe"
				};
				string[] array3 = null;
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = text + "\\" + array[i];
					string text3 = Class62.smethod_7(text2, Class12.smethod_53(string_3), 1, "");
					string string_4 = text2 + "\\" + Class12.smethod_53(string_2);
					string[] array4 = Class62.smethod_9(string_4, true, false, 0);
					bool flag2 = array4 == null || array4.Length == 0;
					if (!flag2)
					{
						string text4 = string.Empty;
						string text5 = string.Empty;
						for (int j = 0; j < array4.Length; j++)
						{
							bool flag3 = text3 == null || !(text3 != string.Empty);
							if (flag3)
							{
								text4 = Class62.smethod_7(string_4, array4[j], 1, "");
							}
							else
							{
								text4 = text3;
								text3 = null;
								j = -1;
							}
							text5 = text4.ToLower();
							for (int k = 0; k < array2.Length; k++)
							{
								bool flag4 = 0 <= text5.IndexOf(array2[k]);
								if (flag4)
								{
									bool flag5 = array3 != null;
									if (flag5)
									{
										Array.Resize<string>(ref array3, array3.Length + 1);
									}
									else
									{
										array3 = new string[1];
									}
									array3[array3.Length - 1] = text4.Split(new char[]
									{
										'|'
									})[0];
								}
							}
						}
					}
				}
				bool flag6 = array3 == null || array3.Length == 0;
				if (!flag6)
				{
					uint num = Class12.smethod_6(Environment.MachineName.ToLower());
					bool flag7 = num == 2974272431U || num == 3989627222U || num == 3648956035U;
					if (!flag7)
					{
						for (int l = 0; l < array3.Length; l++)
						{
							bool flag8 = Class12.smethod_17(array3[l]);
							if (flag8)
							{
								Class22.smethod_5(Class12.smethod_0(Class12.char_39));
							}
						}
					}
				}
			}
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0012D9E8 File Offset: 0x0012BBE8
		private static void smethod_2()
		{
			int num = 0;
			while (Form1.string_37.GetLength(0) > num)
			{
				try
				{
					Process[] processesByName = Process.GetProcessesByName(Form1.string_37[num, 0]);
					bool flag = processesByName == null || processesByName.Length == 0;
					if (!flag)
					{
						bool flag2 = Form1.string_37[num, 1] == null || Form1.string_37[num, 1] == string.Empty;
						if (flag2)
						{
							for (int i = 0; i < processesByName.Length; i++)
							{
								Class22.smethod_43(processesByName[i]);
							}
						}
						else
						{
							string b = Form1.string_37[num, 1].ToLower();
							for (int j = 0; j < processesByName.Length; j++)
							{
								string text = string.Empty;
								try
								{
									uint capacity = 256U;
									StringBuilder stringBuilder = new StringBuilder((int)capacity);
									text = ((Class22.QueryFullProcessImageName(processesByName[j].Handle, 0U, stringBuilder, out capacity) != 0U) ? stringBuilder.ToString() : processesByName[j].MainModule.FileName);
								}
								catch
								{
								}
								bool flag3 = text != null && !(text == string.Empty);
								if (flag3)
								{
									string[] array = Class12.smethod_14(text, '\\');
									bool flag4 = array[0].ToLower() == b;
									if (flag4)
									{
										Class22.smethod_43(processesByName[j]);
									}
								}
							}
						}
					}
				}
				catch
				{
				}
				IL_158:
				num++;
				continue;
				goto IL_158;
			}
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0012DB9C File Offset: 0x0012BD9C
		public static void smethod_3()
		{
			new Thread(new ThreadStart(FormAntivirus.smethod_0)).Start();
			new Thread(new ThreadStart(FormAntivirus.smethod_1)).Start();
			int num = 0;
			int num2 = 0;
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			bool flag = environmentVariable == null || environmentVariable == string.Empty;
			if (!flag)
			{
				Process[] array = null;
				string[,] array2 = new string[5, 3];
				array2[0, 0] = "ZXhwbG9yZXI=";
				array2[0, 1] = environmentVariable;
				array2[0, 2] = "0";
				array2[1, 0] = "c3ZjaG9zdA==";
				array2[1, 2] = "0";
				array2[2, 0] = "c3Bvb2xzdg==";
				array2[2, 2] = "0";
				array2[3, 0] = "dGFza21n";
				array2[3, 2] = "0";
				array2[4, 0] = "44Wk";
				array2[4, 2] = "0";
				string[,] array3 = array2;
				string string_ = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\DisallowRun";
				string value = "PAKeoXe".ToLower();
				for (;;)
				{
					num--;
					num2--;
					Thread.Sleep(1200);
					bool flag2 = Class12.bool_0;
					if (flag2)
					{
						break;
					}
					bool flag3 = num2 <= 0;
					if (flag3)
					{
						for (byte b = 0; b <= 1; b += 1)
						{
							string[] array4 = Class62.smethod_9(string_, b > 0, false, 0);
							bool flag4 = array4 != null && array4.Length != 0;
							if (flag4)
							{
								for (int i = 0; i < array4.Length; i++)
								{
									string text = Class62.smethod_7(string_, array4[i], 1, "");
									bool flag5 = text != null && text != string.Empty && 0 <= text.ToLower().IndexOf(value);
									if (flag5)
									{
										Class62.smethod_12(string_, array4[i], b);
									}
								}
							}
						}
						num2 = 60;
					}
					bool flag6 = Form1.int_68 <= 0 || num > 0 || FormAntivirus.bool_0;
					if (!flag6)
					{
						FormAntivirus.smethod_2();
						num = 900;
						bool flag7 = FormAntivirus.bool_1;
						if (flag7)
						{
							num = 180;
						}
						else
						{
							for (int j = 0; j < array3.GetLength(0); j++)
							{
								string processName = Class12.smethod_15(array3[j, 0]).ToLower();
								string text2 = array3[j, 1];
								bool flag8 = text2 == null || text2 == string.Empty;
								if (flag8)
								{
									text2 = environmentVariable + Class12.smethod_15("XHN5c3RlbTMy");
								}
								text2 = text2.ToLower();
								array = Process.GetProcessesByName(processName);
								bool flag9 = array == null || array.Length == 0;
								if (!flag9)
								{
									for (int k = 0; k < array.Length; k++)
									{
										int num3 = 0;
										string text3 = string.Empty;
										try
										{
											uint capacity = 256U;
											StringBuilder stringBuilder = new StringBuilder((int)capacity);
											text3 = ((Class22.QueryFullProcessImageName(array[k].Handle, 0U, stringBuilder, out capacity) != 0U) ? stringBuilder.ToString() : array[k].MainModule.FileName);
											num3 = array[k].Id;
										}
										catch
										{
										}
										bool flag10 = text3 == null || text3 == string.Empty;
										if (!flag10)
										{
											string text4 = Class12.smethod_14(text3, '\\')[0];
											bool flag11 = text4 != null && text4 != string.Empty;
											if (flag11)
											{
												text4 = text4.ToLower();
											}
											bool flag12 = text4 == text2;
											if (!flag12)
											{
												bool flag13 = FormAntivirus.gstruct53_0 == null;
												if (flag13)
												{
													FormAntivirus.gstruct53_0 = new FormAntivirus.GStruct53[]
													{
														new FormAntivirus.GStruct53
														{
															process_0 = array[k],
															int_0 = num3,
															string_0 = text3
														}
													};
												}
												else
												{
													bool flag14 = false;
													for (int l = 0; l < FormAntivirus.gstruct53_0.Length; l++)
													{
														bool flag15 = FormAntivirus.gstruct53_0[l].int_0 == num3;
														if (flag15)
														{
															flag14 = true;
															break;
														}
													}
													bool flag16 = !flag14;
													if (flag16)
													{
														Array.Resize<FormAntivirus.GStruct53>(ref FormAntivirus.gstruct53_0, FormAntivirus.gstruct53_0.Length + 1);
														FormAntivirus.gstruct53_0[FormAntivirus.gstruct53_0.Length - 1].int_0 = num3;
														FormAntivirus.gstruct53_0[FormAntivirus.gstruct53_0.Length - 1].process_0 = array[k];
														FormAntivirus.gstruct53_0[FormAntivirus.gstruct53_0.Length - 1].string_0 = text3;
													}
												}
											}
										}
									}
								}
							}
							FormAntivirus.bool_2 = (FormAntivirus.gstruct53_0 != null && FormAntivirus.gstruct53_0.Length != 0);
						}
					}
				}
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0012E08C File Offset: 0x0012C28C
		private void FormAntivirus_Load(object sender, EventArgs e)
		{
			bool flag = FormAntivirus.gstruct53_0 != null && FormAntivirus.gstruct53_0.Length != 0;
			if (flag)
			{
				for (int i = 0; i < FormAntivirus.gstruct53_0.Length; i++)
				{
					try
					{
						this.method_0(FormAntivirus.gstruct53_0[i].int_0, FormAntivirus.gstruct53_0[i].string_0);
					}
					catch
					{
					}
				}
				this.bool_3 = true;
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0012E138 File Offset: 0x0012C338
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormAntivirus.bool_0 = false;
			FormAntivirus.gstruct53_0 = null;
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0012E148 File Offset: 0x0012C348
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = FormAntivirus.bool_0;
			if (flag)
			{
				bool flag2 = FormAntivirus.int_0 < 0;
				if (flag2)
				{
					this.buttonTieudiet.Enabled = true;
					FormAntivirus.int_0 = 0;
					this.bool_3 = true;
				}
				bool flag3 = !this.bool_3 || this.listView1.Items == null;
				if (!flag3)
				{
					this.bool_3 = false;
					for (int i = 0; i < this.listView1.Items.Count; i++)
					{
						int processId = Class12.smethod_11(this.listView1.Items[i].SubItems[0].Text);
						string text = Class12.smethod_53(this.string_0[2]);
						bool flag4 = false;
						try
						{
							Process processById = Process.GetProcessById(processId);
							bool flag5 = !Class22.smethod_52(processById);
							if (flag5)
							{
								bool flag6 = processById.Threads[0].WaitReason != ThreadWaitReason.Suspended;
								if (flag6)
								{
									text = Class12.smethod_53(this.string_0[0]);
									flag4 = true;
								}
								else
								{
									text = Class12.smethod_53(this.string_0[1]);
								}
							}
						}
						catch
						{
						}
						this.listView1.Items[i].SubItems[2].Text = text;
						bool flag7 = !flag4;
						if (flag7)
						{
							this.listView1.Items[i].ForeColor = Color.DarkGray;
						}
					}
				}
			}
			else
			{
				base.Close();
			}
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x0012E2E4 File Offset: 0x0012C4E4
		private void method_0(int int_1, string string_1)
		{
			string[] array = new string[]
			{
				int_1.ToString(),
				string_1,
				"..."
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			bool flag = array.Length > 1;
			if (flag)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			this.listView1.Items.Add(listViewItem);
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x0012E368 File Offset: 0x0012C568
		private void linkLabelTaiBKAV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = Class12.smethod_53("ᓟᓨᓞᓳᒫᓠᓬᓪᒫᓳᓫᒬᓡᓬᓴᓫᓩᓬᓞᓡ");
			Class22.smethod_40(Class62.smethod_0(), "", string_, 0, false, false);
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0012E398 File Offset: 0x0012C598
		private void buttonTieudiet_Click(object sender, EventArgs e)
		{
			bool flag = FormAntivirus.int_0 <= 0;
			if (flag)
			{
				this.buttonTieudiet.Enabled = false;
				new Thread(new ThreadStart(this.method_1)).Start();
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0012E3DC File Offset: 0x0012C5DC
		private void method_1()
		{
			bool flag = FormAntivirus.gstruct53_0 != null && FormAntivirus.gstruct53_0.Length != 0;
			if (flag)
			{
				string string_ = "ᓌᓤᓬᒫᒩᒨᒧᓃᓤᓙᓚᓑ";
				string string_2 = "ᒼᓛᓐᓒ";
				string text = Class12.smethod_53(FormCompatibility.string_1);
				string[] array = new string[]
				{
					text,
					text.Replace(Class12.smethod_53(string_2), ""),
					text.Replace(Class12.smethod_53(string_), ""),
					text.Replace(Class12.smethod_53(string_), "").Replace(Class12.smethod_53(string_2), "")
				};
				string[] array2 = Class12.smethod_15("ZXhwbG9yZXJ8c3ZjaG9zdHxzcG9vbHN2").Split(new char[]
				{
					'|'
				});
				FormAntivirus.int_0 = 1;
				for (int i = 0; i < 2; i++)
				{
					for (int j = 0; j < FormAntivirus.gstruct53_0.Length; j++)
					{
						try
						{
							Class22.smethod_43(FormAntivirus.gstruct53_0[j].process_0);
						}
						catch
						{
						}
					}
				}
				Random random = new Random();
				for (int k = 0; k < FormAntivirus.gstruct53_0.Length; k++)
				{
					try
					{
						int num = 0;
						string text2 = FormAntivirus.gstruct53_0[k].string_0;
						string str = random.Next(10000, 1000000).ToString();
						while (Class12.smethod_17(text2) && num <= 20)
						{
							bool flag2 = num % 10 == 0;
							if (flag2)
							{
								Class12.smethod_19(text2, text2 + "." + str);
							}
							num++;
							Thread.Sleep(300);
						}
					}
					catch
					{
					}
				}
				for (int l = 0; l < FormAntivirus.gstruct53_0.Length; l++)
				{
					try
					{
						Class22.smethod_53(FormAntivirus.gstruct53_0[l].process_0);
					}
					catch
					{
					}
				}
				for (int m = 0; m < FormAntivirus.gstruct53_0.Length; m++)
				{
					try
					{
						for (int n = 0; n < array.Length; n++)
						{
							for (int num2 = 0; num2 < array2.Length; num2++)
							{
								Class62.smethod_12(array[n], array2[num2], 0);
								Class62.smethod_12(array[n], array2[num2], 1);
							}
						}
					}
					catch
					{
					}
				}
				FormAntivirus.int_0 = -1;
			}
			else
			{
				FormAntivirus.int_0 = -1;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0012E6A8 File Offset: 0x0012C8A8
		private void buttonMothumuc_Click(object sender, EventArgs e)
		{
			string string_ = "ᓚᓭᓥᓡᓤᓧᓚᓧᒣᓚᓭᓚ";
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					string[] array = Class12.smethod_14(this.listView1.Items[i].SubItems[1].Text, '\\');
					Class22.smethod_40(environmentVariable + "\\" + Class12.smethod_53(string_), array[0], array[0], 0, false, false);
					break;
				}
			}
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0012E75C File Offset: 0x0012C95C
		private void checkBoxKhongHienCanhbao_CheckedChanged(object sender, EventArgs e)
		{
			FormAntivirus.bool_1 = this.checkBoxKhongHienCanhbao.Checked;
			bool flag = FormAntivirus.bool_1;
			if (flag)
			{
				MessageBox.Show(Class12.smethod_15("Q2jDuiDDvTogQuG6rXQgbOG6oWkgY+G6o25oIGLDoW8gbsOgeSDhu58gdGFiIEPDoGkgZ2FtZSBj4bunYSBhdXRvLg=="));
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0012E794 File Offset: 0x0012C994
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x0400079A RID: 1946
		public static bool bool_0;

		// Token: 0x0400079B RID: 1947
		public static bool bool_1;

		// Token: 0x0400079C RID: 1948
		public static bool bool_2;

		// Token: 0x0400079D RID: 1949
		public static FormAntivirus.GStruct53[] gstruct53_0;

		// Token: 0x0400079E RID: 1950
		private bool bool_3 = false;

		// Token: 0x0400079F RID: 1951
		private string[] string_0 = new string[]
		{
			"ᒺᓡ㌓ᓦᒒᖃ㍋ᓠᓙ",
			"ᓆ㌓ᓟᒒᓠᓙᘢᓠᓙ",
			"ᖁᕔᒑᓥᓙᓠᕒᓥ"
		};

		// Token: 0x040007A0 RID: 1952
		private static int int_0;

		// Token: 0x040007A1 RID: 1953
		private IContainer icontainer_0 = null;

		// Token: 0x020000FE RID: 254
		public struct GStruct53
		{
			// Token: 0x0400126E RID: 4718
			public Process process_0;

			// Token: 0x0400126F RID: 4719
			public int int_0;

			// Token: 0x04001270 RID: 4720
			public string string_0;
		}
	}
}
