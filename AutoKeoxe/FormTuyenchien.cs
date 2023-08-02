using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x0200008C RID: 140
	public partial class FormTuyenchien : Form
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x0018EC9C File Offset: 0x0018CE9C
		public FormTuyenchien()
		{
			FormTuyenchien.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0018ECFC File Offset: 0x0018CEFC
		public static GStruct29[] smethod_0()
		{
			string text = Class62.smethod_6(FormTuyenchien.string_0, 0, "");
			bool flag = text != null && !(text == string.Empty);
			GStruct29[] result;
			if (flag)
			{
				string text2 = Class12.smethod_71(text);
				bool flag2 = text2 == null || text2 == string.Empty;
				if (flag2)
				{
					result = null;
				}
				else
				{
					string[] array = text2.Split(new char[]
					{
						'|'
					});
					GStruct29[] array2 = null;
					foreach (string text3 in array)
					{
						bool flag3 = text3 == null || text3 == string.Empty || text3.Length < 3;
						if (!flag3)
						{
							int num = text3.IndexOf("=");
							bool flag4 = num != 1;
							if (!flag4)
							{
								int num2 = (int)Convert.ToByte(text3[0] == '1');
								string b = text3.Substring(2);
								bool flag5 = array2 == null;
								if (flag5)
								{
									array2 = new GStruct29[]
									{
										new GStruct29
										{
											int_0 = num2,
											string_0 = b
										}
									};
								}
								else
								{
									bool flag6 = false;
									for (int j = 0; j < array2.Length; j++)
									{
										bool flag7 = array2[j].string_0 == b;
										if (flag7)
										{
											flag6 = true;
											break;
										}
									}
									bool flag8 = !flag6;
									if (flag8)
									{
										Array.Resize<GStruct29>(ref array2, array2.Length + 1);
										ref GStruct29 ptr = ref array2[array2.Length - 1];
										ptr = new GStruct29
										{
											int_0 = num2,
											string_0 = b
										};
									}
								}
							}
						}
					}
					result = array2;
				}
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0018EED8 File Offset: 0x0018D0D8
		public static void smethod_1(GStruct29[] gstruct29_1)
		{
			string text = string.Empty;
			bool flag = gstruct29_1 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct29_1.Length; i++)
				{
					bool flag2 = gstruct29_1[i].string_0 != null && !(gstruct29_1[i].string_0 == string.Empty);
					if (flag2)
					{
						bool flag3 = text != null && text != string.Empty;
						if (flag3)
						{
							text += "|";
						}
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							gstruct29_1[i].int_0,
							"=",
							gstruct29_1[i].string_0
						});
					}
				}
				text = Class12.smethod_70(text);
			}
			Class62.smethod_10(Class53.string_3, FormTuyenchien.string_0, text, "", 0);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0018EFC5 File Offset: 0x0018D1C5
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormTuyenchien.smethod_1(FormTuyenchien.gstruct29_0);
			FormTuyenchien.bool_0 = false;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0018EFDC File Offset: 0x0018D1DC
		private void FormTuyenchien_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.int_0 > 0 && this.int_1 > 0;
				if (flag)
				{
					int num = this.int_0 - base.Width - 2;
					int num2 = this.int_1 + this.int_3 - base.Height;
					bool flag2 = num < 0;
					if (flag2)
					{
						num = 0;
					}
					bool flag3 = num2 < 0;
					if (flag3)
					{
						num2 = 0;
					}
					base.SetBounds(num, num2, base.Width, base.Height);
				}
				this.checkBox1.Checked = FormTuyenchien.bool_1;
				FormTuyenchien.gstruct29_0 = FormTuyenchien.smethod_0();
				this.timer_0.Interval = 300;
				this.timer_0.Enabled = true;
				this.bool_2 = true;
				this.bool_3 = true;
				base.TopMost = true;
			}
			catch
			{
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0018F0C0 File Offset: 0x0018D2C0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormTuyenchien.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = this.bool_3;
				if (flag2)
				{
					this.bool_3 = false;
					this.method_0();
				}
				bool flag3 = this.long_1 != FormTuyenchien.long_0;
				if (flag3)
				{
					this.long_1 = FormTuyenchien.long_0;
					bool flag4 = FormTuyenchien.long_0 != 0L;
					if (flag4)
					{
						TimeSpan timeSpan = new TimeSpan(FormTuyenchien.long_0);
						TimeSpan timeSpan2 = new TimeSpan(FormTuyenchien.long_0 + new TimeSpan(0, 0, 14, 0, 0).Ticks);
						this.textBox1.Text = string.Concat(new string[]
						{
							timeSpan.Hours.ToString(),
							":",
							timeSpan.Minutes.ToString(),
							":",
							timeSpan.Seconds.ToString()
						});
						this.textBox2.Text = string.Concat(new string[]
						{
							timeSpan2.Hours.ToString(),
							":",
							timeSpan2.Minutes.ToString(),
							":",
							timeSpan2.Seconds.ToString()
						});
					}
					else
					{
						DateTime dateTime = DateTime.Now.AddMinutes(14.0);
						this.textBox1.Text = "0";
						this.textBox2.Text = string.Concat(new string[]
						{
							dateTime.Hour.ToString(),
							":",
							dateTime.Minute.ToString(),
							":",
							dateTime.Second.ToString()
						});
					}
				}
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0018F2B8 File Offset: 0x0018D4B8
		private void method_0()
		{
			this.listView1.Items.Clear();
			bool flag = FormTuyenchien.gstruct29_0 == null;
			if (!flag)
			{
				for (int i = 0; i < FormTuyenchien.gstruct29_0.Length; i++)
				{
					this.method_1(Class10.smethod_1(FormTuyenchien.gstruct29_0[i].string_0, 1, false));
				}
				for (int j = 0; j < FormTuyenchien.gstruct29_0.Length; j++)
				{
					bool flag2 = j < this.listView1.Items.Count && FormTuyenchien.gstruct29_0[j].int_0 > 0;
					if (flag2)
					{
						this.listView1.Items[j].Checked = true;
					}
				}
			}
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0018F380 File Offset: 0x0018D580
		public void method_1(string string_2)
		{
			try
			{
				ListViewItem value = new ListViewItem(string_2);
				this.listView1.Items.Add(value);
			}
			catch
			{
			}
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0018F3C0 File Offset: 0x0018D5C0
		private void comboBoxThemAcc_DropDown(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class26.smethod_5(Form1.gstruct49_0[i]);
					Class98.smethod_24(Form1.gstruct49_0[i], ref FormTuyenchien.string_1);
				}
			}
			this.bool_2 = false;
			string text = this.comboBoxThemAcc.Text;
			string text2 = string.Empty;
			this.comboBoxThemAcc.Items.Clear();
			bool flag2 = FormTuyenchien.string_1 != null;
			if (flag2)
			{
				Array.Sort<string>(FormTuyenchien.string_1);
				for (int j = 0; j < FormTuyenchien.string_1.Length; j++)
				{
					string text3 = Class10.smethod_1(FormTuyenchien.string_1[j], 1, false);
					this.comboBoxThemAcc.Items.Add(text3);
					bool flag3 = text2 == null || text2 == string.Empty || text == text3;
					if (flag3)
					{
						text2 = text3;
					}
				}
			}
			this.comboBoxThemAcc.Text = text2;
			this.bool_2 = true;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0018F4DC File Offset: 0x0018D6DC
		private void buttonThemAcc_Click(object sender, EventArgs e)
		{
			string text = this.comboBoxThemAcc.Text;
			bool flag = FormTuyenchien.string_1 == null || text == null || text == string.Empty;
			if (!flag)
			{
				string text2 = null;
				for (int i = 0; i < FormTuyenchien.string_1.Length; i++)
				{
					bool flag2 = text == Class10.smethod_1(FormTuyenchien.string_1[i], 1, false);
					if (flag2)
					{
						text2 = FormTuyenchien.string_1[i];
						break;
					}
				}
				bool flag3 = text2 == null || text2 == string.Empty;
				if (!flag3)
				{
					bool flag4 = FormTuyenchien.gstruct29_0 != null;
					if (flag4)
					{
						bool flag5 = false;
						for (int j = 0; j < FormTuyenchien.gstruct29_0.Length; j++)
						{
							bool flag6 = text2 == FormTuyenchien.gstruct29_0[j].string_0;
							if (flag6)
							{
								flag5 = true;
								break;
							}
						}
						bool flag7 = !flag5;
						if (flag7)
						{
							Array.Resize<GStruct29>(ref FormTuyenchien.gstruct29_0, FormTuyenchien.gstruct29_0.Length + 1);
							ref GStruct29 ptr = ref FormTuyenchien.gstruct29_0[FormTuyenchien.gstruct29_0.Length - 1];
							ptr = new GStruct29
							{
								int_0 = 1,
								string_0 = text2
							};
						}
					}
					else
					{
						FormTuyenchien.gstruct29_0 = new GStruct29[]
						{
							new GStruct29
							{
								int_0 = 1,
								string_0 = text2
							}
						};
					}
					bool flag8 = this.listView1.Items.Count != 0;
					if (flag8)
					{
						bool flag9 = false;
						for (int k = 0; k < this.listView1.Items.Count; k++)
						{
							bool flag10 = text == this.listView1.Items[k].SubItems[0].Text;
							if (flag10)
							{
								flag9 = true;
								break;
							}
						}
						bool flag11 = !flag9;
						if (flag11)
						{
							this.method_1(text);
							this.listView1.Items[this.listView1.Items.Count - 1].Checked = true;
						}
					}
					else
					{
						this.method_1(text);
						this.listView1.Items[0].Checked = true;
					}
					this.listView1.Items[this.listView1.Items.Count - 1].Checked = true;
					this.listView1.Items[this.listView1.Items.Count - 1].Selected = true;
				}
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0018F780 File Offset: 0x0018D980
		private void buttonXoaAcc_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.SelectedIndices.Count <= 0;
			if (!flag)
			{
				bool flag2 = FormTuyenchien.gstruct29_0 == null;
				if (flag2)
				{
					bool flag3 = this.listView1.Items.Count > 0;
					if (flag3)
					{
						this.listView1.Items.Clear();
					}
				}
				else
				{
					int num = this.listView1.SelectedIndices[0];
					string text = this.listView1.Items[num].SubItems[0].Text;
					int num2 = 0;
					for (int i = 0; i < FormTuyenchien.gstruct29_0.Length; i++)
					{
						bool flag4 = text != Class10.smethod_1(FormTuyenchien.gstruct29_0[i].string_0, 1, false);
						if (flag4)
						{
							FormTuyenchien.gstruct29_0[num2].int_0 = FormTuyenchien.gstruct29_0[i].int_0;
							FormTuyenchien.gstruct29_0[num2].string_0 = FormTuyenchien.gstruct29_0[i].string_0;
							num2++;
						}
					}
					bool flag5 = num2 != 0;
					if (flag5)
					{
						bool flag6 = num2 != FormTuyenchien.gstruct29_0.Length;
						if (flag6)
						{
							Array.Resize<GStruct29>(ref FormTuyenchien.gstruct29_0, num2);
							this.listView1.Items.RemoveAt(num);
							bool flag7 = this.listView1.Items.Count <= num;
							if (flag7)
							{
								num = this.listView1.Items.Count - 1;
							}
							bool flag8 = 0 <= num;
							if (flag8)
							{
								this.listView1.Items[num].Selected = true;
							}
						}
					}
					else
					{
						FormTuyenchien.gstruct29_0 = null;
						this.listView1.Items.Clear();
					}
				}
			}
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0018F960 File Offset: 0x0018DB60
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = this.listView1.Items.Count > 0;
			if (flag)
			{
				this.listView1.Items.Clear();
			}
			FormTuyenchien.gstruct29_0 = null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0018F99C File Offset: 0x0018DB9C
		private void button2_Click(object sender, EventArgs e)
		{
			FormTuyenchien.bool_0 = false;
			base.Close();
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0018F9AC File Offset: 0x0018DBAC
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = this.bool_2 && this.timer_0.Enabled;
			if (flag)
			{
				int index = e.Index;
				string text = this.listView1.Items[index].SubItems[0].Text;
				bool flag2 = FormTuyenchien.gstruct29_0 == null || FormTuyenchien.gstruct29_0.Length <= index || text != Class10.smethod_1(FormTuyenchien.gstruct29_0[index].string_0, 1, false);
				if (flag2)
				{
					this.listView1.Items.Clear();
					FormTuyenchien.gstruct29_0 = null;
				}
				else
				{
					FormTuyenchien.gstruct29_0[index].int_0 = (int)Convert.ToByte(e.NewValue == CheckState.Checked);
				}
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0018FA70 File Offset: 0x0018DC70
		private void button3_Click(object sender, EventArgs e)
		{
			string string_ = "ᘁ㒞ᗍᚾ㒆ᘛᘔᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘏᘎᘛᘔᗍᘕ㒆ᘖᗙᗍᚾᘖ㑮ᘢᗍᘘᘖ㑴ᘛᗧᖷᖷᗚᗍᗻᘔᚏᘛᗍᘠᚎᘐᘕᗍᘡᘟᘜᘛᘔᗍᘏᘎᘛᘔᗍᘝᘕ㑐ᘖᗍᘐᚠᗍᘠ㑢ᘛᖷᗚᗍᗽᘕ㑐ᘖᗍᘐᘕ㑺ᘛᗍᘡᘟ᝝㒈ᘐᗍᘎᘐᗍᚾ㒂ᘖᗍᘚᚍᘢᗍᘙᚍᗍᘁᘟ᝝㒌ᘛᘔᗍᗹᚐᘜᗍᘕᘜ㑤ᘐᗍᗯᘎᘛᘔᗍᘐᘕ㒔ᖷᗚᗍᗽᘕ㑐ᘖᗍᘐᘕ㑺ᘛᗍᘡᘟ᝝㒈ᘐᗍᘡᚗᘛᗍᘏᘎᘛᘔᗍᘕ㒆ᘖᗍᘐ㑔ᘛᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗛᖷᖷᗻᘔᘢᘦᚗᘛᗍᘡ㑜ᘐᗧᖷᖷᘁᘕ㒊ᘖᗍᘔᘖᘎᘛᗍᘔᘖ㒜ᘎᗍᗟᗍᘙ㑔ᘛᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘙᚍᗍᗞᗢᗍᘝᘕᚧᘡᗙᗍᘑᘜᗍᚾᚠᗍᘎᘢᘡᘜᗍᘠ㑪ᗍᘡ㒞ᗍᚾ㒆ᘛᘔᗍᘡᘢᘦᚗᘛᗍᘐᘕᘖ㑬ᘛᗍᘙ㑎ᘖᗍ㒌ᗍᘝᘕᚧᘡᗍᘡᘕ㒖ᗍᗞᗡᗍᚾ㑰ᗍᘏ㑐ᘜᗍᚾ㑐ᘚᗍᘘᘕᚡᘛᘔᗍᘏ㑸ᗍᘔᘖᚎᘛᗍᚾᘜ㑎ᘛᗛᖷ";
			string string_2 = Class12.smethod_53(string_);
			FormTip.smethod_0(Form1.string_1, string_2, 300000, 360, 260, false, base.Left, base.Top, false, false, false);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0018FAB8 File Offset: 0x0018DCB8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.bool_2 && this.timer_0.Enabled;
			if (flag)
			{
				FormTuyenchien.bool_1 = this.checkBox1.Checked;
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0018FAF0 File Offset: 0x0018DCF0
		private void button5_Click(object sender, EventArgs e)
		{
			FormTuyenchien.long_0 = 0L;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0018FAFC File Offset: 0x0018DCFC
		private void buttonEp_Click(object sender, EventArgs e)
		{
			Class7.string_4 = null;
			string text = string.Empty;
			int num = 0;
			bool flag = FormTuyenchien.gstruct29_0 != null;
			if (flag)
			{
				for (int i = 0; i < FormTuyenchien.gstruct29_0.Length; i++)
				{
					bool flag2 = FormTuyenchien.gstruct29_0[i].int_0 > 0;
					if (flag2)
					{
						bool flag3 = Class7.string_4 == null;
						if (flag3)
						{
							Class7.string_4 = new string[1];
						}
						else
						{
							Array.Resize<string>(ref Class7.string_4, Class7.string_4.Length + 1);
						}
						Class7.string_4[Class7.string_4.Length - 1] = FormTuyenchien.gstruct29_0[i].string_0;
						num++;
						object obj = text;
						text = string.Concat(new object[]
						{
							obj,
							num,
							". ",
							Class10.smethod_1(FormTuyenchien.gstruct29_0[i].string_0, 1, false),
							Class53.string_7
						});
					}
				}
			}
			Class7.uint_1 = Class7.smethod_2(Class7.string_4);
			Class7.smethod_1(Class7.string_4, Class7.string_0);
			Class7.int_1 = 1;
			Class62.smethod_10(Class53.string_3, "flagLuonDanhBHO", Class7.int_1, "", 0);
			bool flag4 = text == string.Empty || text == null;
			if (flag4)
			{
				text = Class12.smethod_53("ᓤᓿᔤᙬᔝᓜᔟᖯᓜᔞᔝᔪᔣᓜᔪᖜᔫᓜᗍᙬ㎟ᔟᓜᔟᔤ㎉ᔪᓨᓜᔞ㍝ᔪᓜᔟ㍣ᔪᓜᔬᔤ㍟ᔥᓜᔟᔤᔡᔟᔧᓜᔟᔤ㎉ᔪᓜᔰᖦᔪᓜᔞᔝᔪᔣᓜᔰᔮᔫᔪᔣᓜᔠᔝᔪᔤᓜᔯᖝᔟᔤᓜᔰᔮᖦᔪᓥ");
			}
			string text2 = Class12.smethod_53("ᗏᖢᓟᖨᔯᓟᔗᓟᔡᔠᔭᔦᓟᔵᖟᔮᓟᔣᔠᔭᔧᓟᔲᖠᔢᔧᓟᔫᔴᖳᔭᓟᗐᖠᔭᔧᓟᔡᔠᔭᔦᓟᔧ㎘ᔨᓟᓧᔡ㍤ᔬᓟᔭᖹᔳᓟᔌ㎞ᓟᔱ㎘ᔭᔦᓟ㎞ᓟᔡ㍢ᔭᔦᓟᓰᓟᗐ㎂ᓟᔷᔤᔬᓟᔫ㍠ᔨᓨᓹᓉᓉ").Replace("X", num.ToString()) + text;
			this.richTextBox1.Text = text2;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0018FCA0 File Offset: 0x0018DEA0
		private void buttonBoep_Click(object sender, EventArgs e)
		{
			Class7.int_1 = 0;
			Class62.smethod_10(Class53.string_3, "flagLuonDanhBHO", Class7.int_1, "", 0);
			this.richTextBox1.Text = Class12.smethod_53("ᖭᖀᒽᓿ㍬ᒽᔀᔅᔂᔀᔈᒽᔘᒽᔉᔒᖑᔋᒽᖮᕾᔋᔅᒽᓿᓾᔋᔄᒽᔅ㍶ᔆᒽᔚᒽᔑᔏᔌᔋᔄᒽᔋᖗᔑᒽᔊ㍼ᒽᔏ㍶ᔋᔄ");
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0018FCE0 File Offset: 0x0018DEE0
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x04000D2C RID: 3372
		public static bool bool_0 = false;

		// Token: 0x04000D2D RID: 3373
		public static bool bool_1 = false;

		// Token: 0x04000D2E RID: 3374
		public static long long_0 = Class62.smethod_5("TC_TimeNext", 0, "");

		// Token: 0x04000D2F RID: 3375
		public static GStruct29[] gstruct29_0 = null;

		// Token: 0x04000D30 RID: 3376
		public int int_0 = 0;

		// Token: 0x04000D31 RID: 3377
		public int int_1 = 0;

		// Token: 0x04000D32 RID: 3378
		public int int_2;

		// Token: 0x04000D33 RID: 3379
		public int int_3;

		// Token: 0x04000D34 RID: 3380
		private bool bool_2 = false;

		// Token: 0x04000D35 RID: 3381
		private bool bool_3 = false;

		// Token: 0x04000D36 RID: 3382
		private long long_1 = -1L;

		// Token: 0x04000D37 RID: 3383
		private static string string_0 = "tbNameBhoTC";

		// Token: 0x04000D38 RID: 3384
		private static string[] string_1 = null;

		// Token: 0x04000D39 RID: 3385
		private IContainer icontainer_0 = null;
	}
}
