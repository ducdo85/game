using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000075 RID: 117
	public partial class FormLogin : Form
	{
		// Token: 0x06000954 RID: 2388 RVA: 0x001573B8 File Offset: 0x001555B8
		public FormLogin()
		{
			FormLogin.bool_0 = true;
			FormLogin.string_0 = null;
			try
			{
				this.InitializeComponent();
				base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			}
			catch
			{
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00157420 File Offset: 0x00155620
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			base.Hide();
			Class20.smethod_1();
			this.int_0 = 0;
			this.int_1 = 0;
			FormLogin.bool_0 = false;
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00157444 File Offset: 0x00155644
		private void FormLogin_Load(object sender, EventArgs e)
		{
			try
			{
				this.method_0();
			}
			catch
			{
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00157474 File Offset: 0x00155674
		private void method_0()
		{
			FormLogin.bool_3 = false;
			bool flag = this.int_0 >= 0 && this.int_1 >= 0;
			if (flag)
			{
				int num = this.int_0 - base.Width;
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
			string text = string.Empty;
			string text2 = string.Empty;
			for (int i = 0; i < FormLogin.string_4.Length; i++)
			{
				string text3 = FormLogin.string_4[i];
				bool flag4 = text3 == null || text3 == string.Empty;
				if (!flag4)
				{
					string[] array = text3.Split(new char[]
					{
						'|'
					});
					this.comboBoxPhanda.Items.Add(array[0]);
					bool flag5 = (FormLogin.string_4.Length <= 1 || i != 0) && text2 == string.Empty && array.Length > 1;
					if (flag5)
					{
						text = array[0];
						text2 = array[1];
						for (int j = 1; j < array.Length; j++)
						{
							this.comboBoxServer.Items.Add(array[j]);
						}
					}
				}
			}
			this.comboBoxPhanda.Text = text;
			this.comboBoxServer.Text = text2;
			for (int k = 0; k < 6; k++)
			{
				this.comboBoxNhanVat.Items.Add(k + 1);
			}
			this.comboBoxNhanVat.Text = "1";
			bool flag6 = FormLogin.gstruct0_0 != null;
			if (flag6)
			{
				for (int l = 0; l < FormLogin.gstruct0_0.Length; l++)
				{
					bool bool_ = FormLogin.gstruct0_0[l].int_1 > 0 && !Class22.smethod_52(FormLogin.gstruct0_0[l].process_0);
					this.method_2(FormLogin.gstruct0_0[l], bool_);
				}
			}
			this.checkBoxThuNho.Checked = (FormLogin.int_8 > 0);
			this.checkBoxHanSudung.Checked = (FormLogin.int_4 > 0);
			this.textBoxTimeOpenGame.Text = FormLogin.int_6.ToString();
			this.textBoxTimerDangNhap.Text = FormLogin.int_7.ToString();
			this.checkBoxTuDangNhap.Checked = (FormLogin.int_5 > 0);
			this.checkBoxLog1ac.Checked = (FormLogin.int_9 > 0);
			this.checkBoxFileKhac.Checked = (FormLogin.int_10 > 0);
			this.textBoxFile.Text = FormLogin.string_1;
			this.textBox1.Text = Class33.string_0;
			bool flag7 = Class97.string_1 != null && Class97.string_1 != string.Empty;
			if (flag7)
			{
				this.textBoxCmd.Text = Class97.string_1;
			}
			Thread.Sleep(100);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			this.method_8("LOGIN: CAP NHAT DANH SACH");
			FormLogin.bool_3 = true;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x001577D8 File Offset: 0x001559D8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormLogin.bool_0;
			if (flag)
			{
				base.Close();
			}
			else
			{
				bool flag2 = FormLogin.string_0 != null && FormLogin.string_0.Length != 0;
				if (flag2)
				{
					this.textBoxStatus.Text = FormLogin.string_0[0];
					Class12.smethod_30(ref FormLogin.string_0, FormLogin.string_0[0], false);
				}
				bool flag3 = this.int_11 != Class46.int_2;
				if (flag3)
				{
					this.textBoxTimer.Text = "Đang chờ: " + Class46.int_2.ToString();
					this.int_11 = Class46.int_2;
				}
				bool flag4 = Class33.string_1 != null;
				if (flag4)
				{
					Class12.smethod_61(this.richTextBox1, Class33.string_1, false);
					Class33.string_1 = null;
				}
				bool flag5 = Class46.int_1 != null && Class46.int_1.Length != 0;
				if (flag5)
				{
					int num = Class46.int_1[0];
					Class12.smethod_38(ref Class46.int_1, num);
					bool flag6 = 0 <= num && num < this.listView1.Items.Count;
					if (flag6)
					{
						string text = FormLogin.gstruct0_0[num].string_0;
						string text2 = FormLogin.gstruct0_0[num].string_4;
						bool flag7 = text2 != null && text2 != string.Empty;
						if (flag7)
						{
							text = Class10.smethod_1(text2, 1, false);
						}
						this.listView1.Items[num].SubItems[1].Text = text;
						bool flag8 = !Class22.smethod_52(FormLogin.gstruct0_0[num].process_0);
						if (flag8)
						{
							this.listView1.Items[num].ForeColor = Color.Blue;
						}
						else
						{
							this.listView1.Items[num].ForeColor = Color.Black;
						}
						this.listView1.Items[num].Checked = false;
					}
				}
				bool flag9 = FormLogin.gstruct0_0 == null;
				if (!flag9)
				{
					for (int i = 0; i < FormLogin.gstruct0_0.Length; i++)
					{
						bool flag10 = Class22.smethod_52(FormLogin.gstruct0_0[i].process_0);
						if (flag10)
						{
							bool flag11 = this.listView1.Items[i].ForeColor != Color.Black;
							if (flag11)
							{
								this.listView1.Items[i].ForeColor = Color.Black;
								FormLogin.gstruct0_0[i].int_1 = 0;
							}
						}
						else
						{
							bool flag12 = this.listView1.Items[i].ForeColor != Color.Blue;
							if (flag12)
							{
								this.listView1.Items[i].ForeColor = Color.Blue;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00157AD8 File Offset: 0x00155CD8
		public static string smethod_0(string string_5)
		{
			bool flag = string_5 == null || string_5 == "";
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				string text = "";
				char[] array = string_5.ToCharArray();
				for (int i = 0; i < array.Length; i++)
				{
					text += ('ÿ' - array[i]).ToString();
				}
				result = text;
			}
			return result;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00157B4C File Offset: 0x00155D4C
		private string method_1(string string_5)
		{
			bool flag = string_5 == string.Empty;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string text = Class12.smethod_15(string_5);
				byte b = (byte)text.Length;
				bool flag2 = b > 3 && text[(int)(b - 1)] == '\u0003';
				if (flag2)
				{
					result = string_5;
				}
				else
				{
					result = Class12.smethod_16(((char)string_5.Length).ToString() + string_5 + "\u0003");
				}
			}
			return result;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00157BC4 File Offset: 0x00155DC4
		public static int smethod_1(ref GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
		{
			bool flag = gstruct0_1 != null && gstruct0_1.Length != 0;
			int result;
			if (flag)
			{
				GStruct0[] array = new GStruct0[gstruct0_1.Length + 1];
				for (int i = 0; i < gstruct0_1.Length; i++)
				{
					GStruct0 gstruct = gstruct0_1[i];
					bool flag2 = !(gstruct.string_3 == gstruct0_2.string_3) || !(gstruct.string_2 == gstruct0_2.string_2) || !(gstruct.string_0 == gstruct0_2.string_0) || gstruct.int_4 != gstruct0_2.int_4;
					if (!flag2)
					{
						return -1;
					}
					ref GStruct0 ptr = ref array[i];
					ptr = gstruct0_1[i];
				}
				int num = array.Length - 1;
				array[num] = gstruct0_2;
				gstruct0_1 = array;
				result = num;
			}
			else
			{
				gstruct0_1 = new GStruct0[]
				{
					gstruct0_2
				};
				result = 0;
			}
			return result;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00157CC0 File Offset: 0x00155EC0
		public static bool smethod_2(ref GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
		{
			bool flag = gstruct0_1 != null && gstruct0_1.Length != 0;
			bool result;
			if (flag)
			{
				GStruct0[] array = new GStruct0[gstruct0_1.Length];
				int num = 0;
				for (int i = 0; i < gstruct0_1.Length; i++)
				{
					GStruct0 gstruct = gstruct0_1[i];
					bool flag2 = !(gstruct.string_3 == gstruct0_2.string_3) || !(gstruct.string_2 == gstruct0_2.string_2) || !(gstruct.string_0 == gstruct0_2.string_0) || gstruct.int_4 != gstruct0_2.int_4;
					if (flag2)
					{
						ref GStruct0 ptr = ref array[num];
						ptr = gstruct0_1[i];
						num++;
					}
				}
				bool flag3 = num == 0;
				if (flag3)
				{
					gstruct0_1 = null;
					result = true;
				}
				else
				{
					bool flag4 = num != gstruct0_1.Length;
					if (flag4)
					{
						GStruct0[] array2 = new GStruct0[num];
						for (int j = 0; j < num; j++)
						{
							ref GStruct0 ptr2 = ref array2[j];
							ptr2 = array[j];
						}
						gstruct0_1 = array2;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			else
			{
				gstruct0_1 = null;
				result = true;
			}
			return result;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00157E04 File Offset: 0x00156004
		public static int smethod_3(GStruct0[] gstruct0_1, GStruct0 gstruct0_2)
		{
			bool flag = gstruct0_1 != null && gstruct0_1.Length != 0;
			if (flag)
			{
				for (int i = 0; i < gstruct0_1.Length; i++)
				{
					GStruct0 gstruct = gstruct0_1[i];
					bool flag2 = gstruct.string_3 == gstruct0_2.string_3 && gstruct.string_2 == gstruct0_2.string_2 && gstruct.string_0 == gstruct0_2.string_0 && gstruct.int_4 == gstruct0_2.int_4;
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00157E9C File Offset: 0x0015609C
		private void method_2(GStruct0 gstruct0_1, bool bool_6 = false)
		{
			int num = 0;
			try
			{
				bool flag = this.listView1.Items != null;
				if (flag)
				{
					num = this.listView1.Items.Count;
				}
			}
			catch
			{
			}
			string[] array = new string[]
			{
				num.ToString(),
				Class10.smethod_1(gstruct0_1.string_4, 1, false),
				gstruct0_1.string_0,
				gstruct0_1.int_4.ToString(),
				gstruct0_1.string_3,
				gstruct0_1.string_2
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			bool flag2 = array.Length > 1;
			if (flag2)
			{
				for (int i = 1; i < array.Length; i++)
				{
					ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[i]);
					listViewItem.SubItems.Add(item);
				}
			}
			this.listView1.Items.Add(listViewItem);
			if (bool_6)
			{
				this.listView1.Items[this.listView1.Items.Count - 1].ForeColor = Color.Blue;
			}
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00157FC4 File Offset: 0x001561C4
		private void method_3(ListView listView_0, int int_12 = 0)
		{
			bool flag = listView_0.Items == null;
			if (!flag)
			{
				int count = listView_0.Items.Count;
				bool flag2 = count != 0;
				if (flag2)
				{
					bool flag3 = int_12 >= count;
					if (flag3)
					{
						int_12 = count - 1;
					}
					listView_0.TopItem = listView_0.Items[int_12];
					listView_0.Items[int_12].Focused = true;
					listView_0.Items[int_12].Selected = true;
				}
			}
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00158040 File Offset: 0x00156240
		private void buttonXoaTK_Click(object sender, EventArgs e)
		{
			int num = -1;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					num = i;
					break;
				}
			}
			bool flag = num < 0;
			if (!flag)
			{
				GStruct0 gstruct = new GStruct0
				{
					string_0 = this.listView1.Items[num].SubItems[2].Text,
					int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
					string_3 = this.listView1.Items[num].SubItems[4].Text,
					string_2 = this.listView1.Items[num].SubItems[5].Text
				};
				int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					FormLogin.smethod_2(ref FormLogin.gstruct0_0, gstruct);
					this.listView1.Items.RemoveAt(num);
					bool flag3 = this.listView1.Items.Count != 0;
					if (flag3)
					{
						bool flag4 = num > this.listView1.Items.Count - 1;
						if (flag4)
						{
							num = this.listView1.Items.Count - 1;
						}
						this.listView1.Items[num].Focused = true;
						this.listView1.Items[num].Selected = true;
						for (int j = num; j < this.listView1.Items.Count; j++)
						{
							this.listView1.Items[j].SubItems[0].Text = j.ToString();
						}
						this.textBoxStatus.Text = "Đã xóa tài khoản " + gstruct.string_0;
						FormLogin.bool_2 = true;
					}
					else
					{
						FormLogin.bool_2 = true;
					}
				}
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00158288 File Offset: 0x00156488
		private void buttonSuaTK_Click(object sender, EventArgs e)
		{
			int num = -1;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					num = i;
					break;
				}
			}
			bool flag = num < 0;
			if (!flag)
			{
				GStruct0 gstruct0_ = new GStruct0
				{
					string_0 = this.listView1.Items[num].SubItems[2].Text,
					int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
					string_3 = this.listView1.Items[num].SubItems[4].Text,
					string_2 = this.listView1.Items[num].SubItems[5].Text
				};
				int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct0_);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					bool flag3 = !(this.textBoxTaiKhoan.Text == "");
					if (flag3)
					{
						string a = this.method_1(this.textBoxPassword.Text);
						bool flag4 = a == "";
						if (flag4)
						{
							this.textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
						}
						else
						{
							FormLogin.gstruct0_0[num2].string_0 = this.textBoxTaiKhoan.Text;
							FormLogin.gstruct0_0[num2].string_1 = a;
							FormLogin.gstruct0_0[num2].int_4 = Class12.smethod_11(this.comboBoxNhanVat.Text);
							FormLogin.gstruct0_0[num2].string_2 = this.comboBoxPhanda.Text;
							FormLogin.gstruct0_0[num2].string_3 = this.comboBoxServer.Text;
							this.listView1.Items[num].SubItems[2].Text = this.textBoxTaiKhoan.Text;
							this.listView1.Items[num].SubItems[3].Text = this.comboBoxNhanVat.Text;
							this.listView1.Items[num].SubItems[4].Text = this.comboBoxServer.Text;
							this.listView1.Items[num].SubItems[5].Text = this.comboBoxPhanda.Text;
							this.textBoxStatus.Text = "Đã sửa tài khoản tại dòng " + num.ToString() + ":" + num2.ToString();
							FormLogin.bool_2 = true;
						}
					}
					else
					{
						this.textBoxStatus.Text = "Chưa nhập ID tài khoản.";
					}
				}
			}
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00158593 File Offset: 0x00156793
		private void buttonLuuDanhsach_Click(object sender, EventArgs e)
		{
			Class20.smethod_1();
			this.textBoxStatus.Text = "Đã lưu tệp danh sách: " + FormLogin.string_3;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x001585B8 File Offset: 0x001567B8
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = -1;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					num = i;
					break;
				}
			}
			bool flag = num < 0;
			if (!flag)
			{
				GStruct0 gstruct = new GStruct0
				{
					string_0 = this.listView1.Items[num].SubItems[2].Text,
					int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
					string_3 = this.listView1.Items[num].SubItems[4].Text,
					string_2 = this.listView1.Items[num].SubItems[5].Text
				};
				int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					FormLogin.bool_3 = false;
					this.comboBoxServer.Items.Clear();
					for (int j = 0; j < FormLogin.string_4.Length; j++)
					{
						string text = FormLogin.string_4[j];
						bool flag3 = text == null || text == string.Empty;
						if (!flag3)
						{
							string[] array = text.Split(new char[]
							{
								'|'
							});
							bool flag4 = gstruct.string_2 == array[0];
							if (flag4)
							{
								for (int k = 1; k < array.Length; k++)
								{
									this.comboBoxServer.Items.Add(array[k]);
								}
							}
						}
					}
					this.textBoxTaiKhoan.Text = gstruct.string_0;
					this.comboBoxNhanVat.Text = gstruct.int_4.ToString();
					this.comboBoxServer.Text = gstruct.string_3;
					this.comboBoxPhanda.Text = gstruct.string_2;
					this.textBoxPassword.Text = FormLogin.gstruct0_0[num2].string_1;
					Thread.Sleep(100);
					FormLogin.bool_3 = true;
				}
			}
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00158820 File Offset: 0x00156A20
		private void labelThem_Click(object sender, EventArgs e)
		{
			bool flag = this.textBoxTaiKhoan.Text == "";
			if (flag)
			{
				this.textBoxStatus.Text = "Chưa nhập ID tài khoản.";
			}
			else
			{
				string a = this.method_1(this.textBoxPassword.Text);
				bool flag2 = a == string.Empty;
				if (flag2)
				{
					this.textBoxStatus.Text = "Chưa nhập PASSWORD tài khoản.";
				}
				else
				{
					GStruct0 gstruct = new GStruct0
					{
						string_0 = this.textBoxTaiKhoan.Text,
						string_1 = a,
						int_4 = Class12.smethod_11(this.comboBoxNhanVat.Text),
						string_2 = this.comboBoxPhanda.Text,
						string_3 = this.comboBoxServer.Text
					};
					int num = FormLogin.smethod_1(ref FormLogin.gstruct0_0, gstruct);
					bool flag3 = num < 0;
					if (flag3)
					{
						this.textBoxStatus.Text = "Tài khoản [" + gstruct.string_0 + "] đã tồn tại.";
					}
					else
					{
						this.method_2(gstruct, false);
						this.method_3(this.listView1, this.listView1.Items.Count - 1);
						this.textBoxStatus.Text = "Đã thêm tài khoản " + gstruct.string_0;
						FormLogin.bool_2 = true;
					}
				}
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0015897C File Offset: 0x00156B7C
		private void buttonLen_Click(object sender, EventArgs e)
		{
			int num = -1;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					num = i;
					break;
				}
			}
			bool flag = num <= 0;
			if (!flag)
			{
				GStruct0 gstruct = new GStruct0
				{
					string_0 = this.listView1.Items[num].SubItems[2].Text,
					int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
					string_3 = this.listView1.Items[num].SubItems[4].Text,
					string_2 = this.listView1.Items[num].SubItems[5].Text
				};
				int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct);
				bool flag2 = num2 < 0;
				if (!flag2)
				{
					for (int j = 1; j < this.listView1.Items[num].SubItems.Count; j++)
					{
						string text = this.listView1.Items[num].SubItems[j].Text;
						this.listView1.Items[num].SubItems[j].Text = this.listView1.Items[num - 1].SubItems[j].Text;
						this.listView1.Items[num - 1].SubItems[j].Text = text;
					}
					Color backColor = this.listView1.Items[num].BackColor;
					Color foreColor = this.listView1.Items[num].ForeColor;
					this.listView1.Items[num].BackColor = this.listView1.Items[num - 1].BackColor;
					this.listView1.Items[num].ForeColor = this.listView1.Items[num - 1].ForeColor;
					this.listView1.Items[num - 1].BackColor = backColor;
					this.listView1.Items[num - 1].ForeColor = foreColor;
					this.listView1.Items[num - 1].Focused = true;
					this.listView1.Items[num - 1].Selected = true;
					num--;
					int index = this.listView1.TopItem.Index;
					bool flag3 = num < index && index > 0;
					if (flag3)
					{
						bool flag4 = index < 10;
						if (flag4)
						{
							this.listView1.TopItem = this.listView1.Items[0];
						}
						else
						{
							this.listView1.TopItem = this.listView1.Items[index - 10];
						}
					}
					gstruct = FormLogin.gstruct0_0[num2];
					ref GStruct0 ptr = ref FormLogin.gstruct0_0[num2];
					ptr = FormLogin.gstruct0_0[num2 - 1];
					FormLogin.gstruct0_0[num2 - 1] = gstruct;
					FormLogin.bool_2 = true;
				}
			}
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00158D2C File Offset: 0x00156F2C
		private void buttonXuong_Click(object sender, EventArgs e)
		{
			int num = -1;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool selected = this.listView1.Items[i].Selected;
				if (selected)
				{
					num = i;
					break;
				}
			}
			bool flag = num < 0 || this.listView1.Items.Count - 1 <= num;
			if (!flag)
			{
				GStruct0 gstruct = new GStruct0
				{
					string_0 = this.listView1.Items[num].SubItems[2].Text,
					int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
					string_3 = this.listView1.Items[num].SubItems[4].Text,
					string_2 = this.listView1.Items[num].SubItems[5].Text
				};
				int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					for (int j = 1; j < this.listView1.Items[num].SubItems.Count; j++)
					{
						string text = this.listView1.Items[num].SubItems[j].Text;
						this.listView1.Items[num].SubItems[j].Text = this.listView1.Items[num + 1].SubItems[j].Text;
						this.listView1.Items[num + 1].SubItems[j].Text = text;
					}
					Color backColor = this.listView1.Items[num].BackColor;
					Color foreColor = this.listView1.Items[num].ForeColor;
					this.listView1.Items[num].BackColor = this.listView1.Items[num + 1].BackColor;
					this.listView1.Items[num].ForeColor = this.listView1.Items[num + 1].ForeColor;
					this.listView1.Items[num + 1].BackColor = backColor;
					this.listView1.Items[num + 1].ForeColor = foreColor;
					this.listView1.Items[num + 1].Focused = true;
					this.listView1.Items[num + 1].Selected = true;
					num++;
					bool flag3 = num > this.listView1.TopItem.Index + 8;
					if (flag3)
					{
						this.listView1.TopItem = this.listView1.Items[num];
					}
					gstruct = FormLogin.gstruct0_0[num2];
					ref GStruct0 ptr = ref FormLogin.gstruct0_0[num2];
					ptr = FormLogin.gstruct0_0[num2 + 1];
					FormLogin.gstruct0_0[num2 + 1] = gstruct;
					FormLogin.bool_2 = true;
				}
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x001590BC File Offset: 0x001572BC
		private void textBoxTimeOpenGame_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_6 = Class12.smethod_11(this.textBoxTimeOpenGame.Text);
				Class62.smethod_10(Class53.string_3, "TimerOpenGame", FormLogin.int_6, "", 0);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00159110 File Offset: 0x00157310
		private void textBoxTimerDangNhap_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_7 = Class12.smethod_11(this.textBoxTimerDangNhap.Text);
				Class62.smethod_10(Class53.string_3, "TimeDangNhap", FormLogin.int_7, "", 0);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00159164 File Offset: 0x00157364
		private void buttonThoatGameAll_Click(object sender, EventArgs e)
		{
			bool flag = false;
			int[] array = Class22.smethod_24(Class53.string_21, null, false);
			bool flag2 = array != null;
			if (flag2)
			{
				bool flag3 = !flag;
				if (flag3)
				{
					string text = "Bạn chắc chắn muốn thoát hết game ?";
					bool flag4 = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) == DialogResult.No;
					if (flag4)
					{
						return;
					}
					flag = true;
				}
				for (int i = 0; i < array.Length; i++)
				{
					Class22.smethod_48(array[i]);
					Thread.Sleep(60);
				}
			}
			bool flag5 = Class53.string_19 == null || Class53.string_19 == string.Empty;
			if (!flag5)
			{
				string processName = Class53.string_19;
				bool flag6 = Class12.smethod_1(Class53.string_19.ToUpper(), ".EXE") > 0;
				if (flag6)
				{
					string[] array2 = Class12.smethod_14(Class53.string_19, '.');
					processName = array2[0];
				}
				for (;;)
				{
					Process[] processesByName = Process.GetProcessesByName(processName);
					bool flag7 = processesByName == null || processesByName.Length == 0;
					if (flag7)
					{
						processesByName = Process.GetProcessesByName(Class53.string_19 + "\u00a0");
						bool flag8 = processesByName == null || processesByName.Length == 0;
						if (flag8)
						{
							break;
						}
					}
					bool flag9 = !flag;
					if (flag9)
					{
						string text2 = "Bạn chắc chắn muốn thoát hết game ?";
						bool flag10 = MessageBox.Show(text2, Form1.string_1, MessageBoxButtons.YesNo) == DialogResult.No;
						if (flag10)
						{
							break;
						}
						flag = true;
					}
					try
					{
						for (int j = 0; j < processesByName.Length; j++)
						{
							Class22.smethod_53(processesByName[j]);
						}
					}
					catch
					{
						continue;
					}
					goto IL_17C;
				}
				return;
				IL_17C:
				this.textBoxStatus.Text = "Đã thoát hết game.";
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00159318 File Offset: 0x00157518
		private void buttonPhimHuongdan_Click(object sender, EventArgs e)
		{
			string str = "https://youtu.be/dleEtu8n5fY";
			this.textBoxStatus.Text = "Link phim Hướng dẫn: " + str;
			Class22.smethod_40(Class62.smethod_0(), "", str, 0, false, false);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00159358 File Offset: 0x00157558
		private void method_4()
		{
			uint num = FormLogin.uint_0;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_20);
				Thread.Sleep(150);
				Class22.ShowWindow(num, Class22.int_18);
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0015939C File Offset: 0x0015759C
		private void method_5()
		{
			uint num = FormLogin.uint_0;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_21);
				Thread.Sleep(150);
				Class22.ShowWindow(num, Class22.int_19);
				Class22.SetForegroundWindow(num);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x001593E4 File Offset: 0x001575E4
		private void method_6()
		{
			uint num = FormLogin.uint_0;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_20);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0015940C File Offset: 0x0015760C
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = FormLogin.bool_4;
			if (flag)
			{
				e.NewValue = e.CurrentValue;
			}
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00159430 File Offset: 0x00157630
		private void listView1_MouseDown(object sender, MouseEventArgs e)
		{
			FormLogin.bool_4 = true;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0015943C File Offset: 0x0015763C
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			FormLogin.bool_4 = false;
			bool flag = e.Button != MouseButtons.Right || FormLogin.gstruct0_0 == null || FormLogin.gstruct0_0.Length == 0;
			if (!flag)
			{
				int num = -1;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						num = i;
						break;
					}
				}
				bool flag2 = num < 0 || this.listView1.Items.Count <= num;
				if (!flag2)
				{
					GStruct0 gstruct0_ = new GStruct0
					{
						string_0 = this.listView1.Items[num].SubItems[2].Text,
						int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
						string_3 = this.listView1.Items[num].SubItems[4].Text,
						string_2 = this.listView1.Items[num].SubItems[5].Text
					};
					int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct0_);
					bool flag3 = num2 >= 0;
					if (flag3)
					{
						bool flag4 = FormLogin.gstruct0_0[num2].int_1 != 0 && !Class22.smethod_52(FormLogin.gstruct0_0[num2].process_0);
						if (flag4)
						{
							FormLogin.uint_0 = FormLogin.gstruct0_0[num2].uint_0;
							new Thread(new ThreadStart(this.method_4)).Start();
						}
						else
						{
							Class46.bool_1 = true;
							Thread.Sleep(100);
							Class12.smethod_37(ref Class46.int_0, num2);
							Class46.bool_1 = false;
						}
					}
				}
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00159640 File Offset: 0x00157840
		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			bool flag = e.Button != MouseButtons.Left || FormLogin.gstruct0_0 == null || FormLogin.gstruct0_0.Length == 0;
			if (!flag)
			{
				int num = -1;
				for (int i = 0; i < this.listView1.Items.Count; i++)
				{
					bool selected = this.listView1.Items[i].Selected;
					if (selected)
					{
						num = i;
						break;
					}
				}
				bool flag2 = num >= 0 && this.listView1.Items.Count > num;
				if (flag2)
				{
					GStruct0 gstruct0_ = new GStruct0
					{
						string_0 = this.listView1.Items[num].SubItems[2].Text,
						int_4 = Class12.smethod_11(this.listView1.Items[num].SubItems[3].Text),
						string_3 = this.listView1.Items[num].SubItems[4].Text,
						string_2 = this.listView1.Items[num].SubItems[5].Text
					};
					int num2 = FormLogin.smethod_3(FormLogin.gstruct0_0, gstruct0_);
					bool flag3 = num2 >= 0 && !Class22.smethod_52(FormLogin.gstruct0_0[num2].process_0);
					if (flag3)
					{
						FormLogin.uint_0 = FormLogin.gstruct0_0[num2].uint_0;
						new Thread(new ThreadStart(this.method_5)).Start();
					}
				}
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x001597F8 File Offset: 0x001579F8
		private void checkBoxThuNho_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_8 = (int)Convert.ToByte(this.checkBoxThuNho.Checked);
				Class62.smethod_10(Class53.string_3, "flagThuNho", FormLogin.int_8, "", 0);
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0015984C File Offset: 0x00157A4C
		private void comboBoxPhanda_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !FormLogin.bool_3;
			if (!flag)
			{
				this.comboBoxServer.Items.Clear();
				string text = this.comboBoxPhanda.Text;
				for (int i = 0; i < FormLogin.string_4.Length; i++)
				{
					string text2 = FormLogin.string_4[i];
					bool flag2 = text2 == null || text2 == string.Empty;
					if (!flag2)
					{
						string[] array = text2.Split(new char[]
						{
							'|'
						});
						bool flag3 = !(text == array[0]);
						if (!flag3)
						{
							bool flag4 = array.Length > 1;
							if (flag4)
							{
								for (int j = 1; j < array.Length; j++)
								{
									this.comboBoxServer.Items.Add(array[j]);
								}
								this.comboBoxServer.Text = array[1];
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00159944 File Offset: 0x00157B44
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			Class46.bool_1 = true;
			Thread.Sleep(100);
			bool flag = false;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				bool @checked = this.listView1.Items[i].Checked;
				if (@checked)
				{
					flag = true;
					Class12.smethod_37(ref Class46.int_0, i);
				}
			}
			bool flag2 = !flag;
			if (flag2)
			{
				int num = -1;
				for (int j = 0; j < this.listView1.Items.Count; j++)
				{
					bool selected = this.listView1.Items[j].Selected;
					if (selected)
					{
						num = j;
						break;
					}
				}
				bool flag3 = 0 <= num;
				if (flag3)
				{
					Class12.smethod_37(ref Class46.int_0, num);
				}
				Class46.bool_1 = false;
			}
			else
			{
				Class46.bool_1 = false;
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00159A30 File Offset: 0x00157C30
		private void checkBoxTuDangNhap_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_5 = (int)Convert.ToByte(this.checkBoxTuDangNhap.Checked);
				Class62.smethod_10(Class53.string_3, "flagTuDangNhap", FormLogin.int_5, "", 0);
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0011F6A4 File Offset: 0x0011D8A4
		private void buttonMoGame_Click(object sender, EventArgs e)
		{
			Class97.smethod_1();
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00159A84 File Offset: 0x00157C84
		private void buttonStopLogin_Click(object sender, EventArgs e)
		{
			Class46.bool_0 = true;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00159A90 File Offset: 0x00157C90
		private void linkLabelCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.bool_5 = !this.bool_5;
			for (int i = 0; i < this.listView1.Items.Count; i++)
			{
				this.listView1.Items[i].Checked = this.bool_5;
			}
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00159AEB File Offset: 0x00157CEB
		private void buttonGameHu_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(this.method_7)).Start();
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00159B05 File Offset: 0x00157D05
		private void method_7()
		{
			FormLogin.string_0 = new string[]
			{
				Class46.smethod_5()
			};
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00159B1C File Offset: 0x00157D1C
		private void checkBoxLog1ac_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_9 = (int)Convert.ToByte(this.checkBoxLog1ac.Checked);
				Class62.smethod_10(Class53.string_3, "fLog1ac", FormLogin.int_9, "", 0);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00159B70 File Offset: 0x00157D70
		private void checkBoxFileKhac_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !FormLogin.bool_3;
				if (!flag2)
				{
					FormLogin.int_10 = (int)Convert.ToByte(this.checkBoxFileKhac.Checked);
					Class62.smethod_10(Class53.string_3, "flagFileKhac", FormLogin.int_10, "", 0);
				}
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00159BDC File Offset: 0x00157DDC
		private void buttonBrowseGameKhac_Click(object sender, EventArgs e)
		{
			string text = Class53.string_18;
			bool flag = text == string.Empty;
			if (!flag)
			{
				bool flag2 = text == null;
				if (!flag2)
				{
					goto IL_33;
				}
			}
			text = Class53.string_8;
			IL_33:
			string text2 = Class53.smethod_26(text, string.Empty, "*.exe", "");
			this.textBoxFile.Text = text2;
			FormLogin.string_1 = text2;
			Class62.smethod_10(Class53.string_3, "PathFileKhac", FormLogin.string_1, "", 0);
			bool flag3 = text2 != null;
			if (flag3)
			{
				bool flag4 = !(text2 != string.Empty);
				if (!flag4)
				{
					Class22.smethod_71(text2, true);
				}
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00159C94 File Offset: 0x00157E94
		private void buttonThoatGame_Click(object sender, EventArgs e)
		{
			bool flag = FormLogin.gstruct0_0 != null && this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count != 0;
			if (flag)
			{
				int num = this.listView1.SelectedIndices[0];
				bool flag2 = num >= 0 && FormLogin.gstruct0_0.Length > num && !Class22.smethod_52(FormLogin.gstruct0_0[num].process_0);
				if (flag2)
				{
					Class22.smethod_53(FormLogin.gstruct0_0[num].process_0);
				}
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00159D28 File Offset: 0x00157F28
		private void checkBoxHanSudung_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				FormLogin.int_4 = (int)Convert.ToByte(this.checkBoxHanSudung.Checked);
				Class62.smethod_10(Class53.string_3, "flagKhongcoHsd", FormLogin.int_4, "", 0);
			}
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00159D7C File Offset: 0x00157F7C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.textBox1.Text = Clipboard.GetText();
			}
			catch
			{
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00159DB4 File Offset: 0x00157FB4
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class33.string_0 = this.textBox1.Text;
				Class62.smethod_10(Class53.string_3, "SBLV", Class33.string_0, "", 0);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00159DFE File Offset: 0x00157FFE
		private void buttonOpenAuto_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(new Class33().method_0)).Start();
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00159E1C File Offset: 0x0015801C
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_8(string string_5)
		{
			base.Text = string_5;
		}

		// Token: 0x040009BD RID: 2493
		public static GStruct0[] gstruct0_0 = null;

		// Token: 0x040009BE RID: 2494
		public static string[] string_0 = null;

		// Token: 0x040009BF RID: 2495
		public static bool bool_0 = false;

		// Token: 0x040009C0 RID: 2496
		public static bool bool_1 = false;

		// Token: 0x040009C1 RID: 2497
		public static bool bool_2 = false;

		// Token: 0x040009C2 RID: 2498
		public int int_0;

		// Token: 0x040009C3 RID: 2499
		public int int_1;

		// Token: 0x040009C4 RID: 2500
		public int int_2;

		// Token: 0x040009C5 RID: 2501
		public int int_3;

		// Token: 0x040009C6 RID: 2502
		public static int int_4 = Class62.smethod_3("flagKhongcoHsd", 0, "0");

		// Token: 0x040009C7 RID: 2503
		public static int int_5 = Class62.smethod_3("flagTuDangNhap", 0, "0");

		// Token: 0x040009C8 RID: 2504
		public static int int_6 = Class62.smethod_3("TimerOpenGame", 0, "4000");

		// Token: 0x040009C9 RID: 2505
		public static int int_7 = Class62.smethod_3("TimeDangNhap", 0, "16000");

		// Token: 0x040009CA RID: 2506
		public static int int_8 = Class62.smethod_3("flagThuNho", 0, "1");

		// Token: 0x040009CB RID: 2507
		public static int int_9 = Class62.smethod_3("fLog1ac", 0, "0");

		// Token: 0x040009CC RID: 2508
		public static int int_10 = Class62.smethod_3("flagFileKhac", 0, "0");

		// Token: 0x040009CD RID: 2509
		public static string string_1 = Class62.smethod_6("PathFileKhac", 0, "");

		// Token: 0x040009CE RID: 2510
		public static string string_2 = Class53.string_8 + "\\Login";

		// Token: 0x040009CF RID: 2511
		public static string string_3 = FormLogin.string_2 + "\\Login.txt";

		// Token: 0x040009D0 RID: 2512
		public static string[] string_4 = new string[]
		{
			"JX Tình Huynh Đệ|Huynh Đệ|Tương Phùng"
		};

		// Token: 0x040009D1 RID: 2513
		private static bool bool_3 = false;

		// Token: 0x040009D2 RID: 2514
		private static bool bool_4 = false;

		// Token: 0x040009D3 RID: 2515
		private int int_11 = 0;

		// Token: 0x040009D4 RID: 2516
		private static uint uint_0 = 0U;

		// Token: 0x040009D5 RID: 2517
		private bool bool_5 = false;

		// Token: 0x040009D6 RID: 2518
		private IContainer icontainer_0 = null;
	}
}
