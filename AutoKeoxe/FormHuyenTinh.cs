using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeoxe
{
	// Token: 0x02000070 RID: 112
	public partial class FormHuyenTinh : Form
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x0014A649 File Offset: 0x00148849
		public FormHuyenTinh()
		{
			FormHuyenTinh.bool_0 = true;
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0014A678 File Offset: 0x00148878
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0014B52C File Offset: 0x0014972C
		private void FormHuyenTinh_Load(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
			bool flag = 0 <= num;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				bool flag2 = gstruct.byte_0[0] > 0;
				if (flag2)
				{
					this.textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
				}
				else
				{
					bool bool_ = gstruct.bool_6;
					if (bool_)
					{
						this.textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
					}
				}
				this.checkBoxNguyenlieuBH.Checked = (Class23.int_1 > 0);
				this.method_0(gstruct.byte_0);
			}
			else
			{
				this.groupBoxNangCap.Enabled = false;
				this.buttonBatdauNangcap.Enabled = false;
				this.buttonChetaoHuyentinh.Enabled = false;
				this.textBoxHT.Text = "Chưa chọn ac nào, hãy chọn 1 ac rồi vào đây thiết lập";
			}
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			FormHuyenTinh.bool_1 = true;
			base.TopMost = true;
			base.Top = Cursor.Position.Y - base.Height - 10;
			base.Left = Cursor.Position.X - base.Width - 10;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0014B66C File Offset: 0x0014986C
		private void method_0(byte[] byte_0)
		{
			this.buttonBatdauNangcap.Enabled = (byte_0[0] == 0);
			this.checkBoxC1.Checked = (byte_0[1] > 0);
			this.checkBoxC2.Checked = (byte_0[2] > 0);
			this.checkBoxC3.Checked = (byte_0[3] > 0);
			this.checkBoxC4.Checked = (byte_0[4] > 0);
			this.checkBoxC5.Checked = (byte_0[5] > 0);
			this.checkBoxC6.Checked = (byte_0[6] > 0);
			this.checkBoxC7.Checked = (byte_0[7] > 0);
			this.checkBoxC8.Checked = (byte_0[8] > 0);
			this.checkBoxC9.Checked = (byte_0[9] > 0);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0014B72F File Offset: 0x0014992F
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			FormHuyenTinh.int_0 = 0;
			FormHuyenTinh.bool_0 = false;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0014B740 File Offset: 0x00149940
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = !FormHuyenTinh.bool_0;
			if (flag)
			{
				base.Close();
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0012D391 File Offset: 0x0012B591
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0014B764 File Offset: 0x00149964
		private void buttonStopNangcapHT_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
			bool flag = num >= 0;
			if (flag)
			{
				Form1.gstruct49_0[num].byte_0[0] = 0;
				this.buttonBatdauNangcap.Enabled = true;
				this.textBoxHT.Text = "Kết thúc nâng cấp!";
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0014B7C0 File Offset: 0x001499C0
		private void buttonBatdauNangcap_Click(object sender, EventArgs e)
		{
			bool flag = Class23.int_0 <= 0;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.buttonBatdauNangcap.Enabled = false;
					Form1.gstruct49_0[num].byte_0[0] = 1;
					Class23.int_0 = Form1.gstruct49_0[num].int_136;
					this.textBoxHT.Text = "Đang tiến hành nâng cấp huyền tinh...";
					new Thread(new ThreadStart(new Class23().method_0)).Start();
				}
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0014B860 File Offset: 0x00149A60
		private void buttonChetaoHuyentinh_Click(object sender, EventArgs e)
		{
			bool flag = Class23.int_0 <= 0;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.textBoxHT.Text = "Đang tiến hành chế tạo huyền tinh...";
					Class23.int_0 = Form1.gstruct49_0[num].int_136;
					new Thread(new ThreadStart(new Class23().method_1)).Start();
				}
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0014B8E0 File Offset: 0x00149AE0
		private void buttonDungChetao_Click(object sender, EventArgs e)
		{
			bool flag = Class23.int_0 <= 0;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].bool_6 = false;
					this.textBoxHT.Text = "Kết thúc chế tạo.";
				}
			}
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0014B940 File Offset: 0x00149B40
		private void checkBoxNguyenlieuBH_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				Class23.int_1 = (int)Convert.ToByte(this.checkBoxNguyenlieuBH.Checked);
				Class62.smethod_10(Class53.string_3, "flagNguyenlieuBH", Class23.int_1, "", 0);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0014B994 File Offset: 0x00149B94
		private void checkBoxC1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[1] = Convert.ToByte(this.checkBoxC1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0014BA10 File Offset: 0x00149C10
		private void checkBoxC2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[2] = Convert.ToByte(this.checkBoxC2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0014BA8C File Offset: 0x00149C8C
		private void checkBoxC3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[3] = Convert.ToByte(this.checkBoxC3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0014BB08 File Offset: 0x00149D08
		private void checkBoxC4_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[4] = Convert.ToByte(this.checkBoxC4.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0014BB84 File Offset: 0x00149D84
		private void checkBoxC5_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[5] = Convert.ToByte(this.checkBoxC5.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x0014BC00 File Offset: 0x00149E00
		private void checkBoxC6_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[6] = Convert.ToByte(this.checkBoxC6.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0014BC7C File Offset: 0x00149E7C
		private void checkBoxC7_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[7] = Convert.ToByte(this.checkBoxC7.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x0014BCF8 File Offset: 0x00149EF8
		private void checkBoxC8_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[8] = Convert.ToByte(this.checkBoxC8.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x0014BD74 File Offset: 0x00149F74
		private void checkBoxC9_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && FormHuyenTinh.bool_1;
			if (flag)
			{
				int num = Class81.smethod_3(Form1.gstruct49_0, FormHuyenTinh.int_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].byte_0[9] = Convert.ToByte(this.checkBoxC9.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x0014BDF0 File Offset: 0x00149FF0
		private void linkLabelPhimCheTaoHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = "https://youtu.be/LLMBuNwXzLw";
			new string[1];
			Class22.smethod_40(Class62.smethod_0(), "", string_, 0, false, false);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x0014BE20 File Offset: 0x0014A020
		private void linkLabelHDHT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string string_ = "=========================================|CHẾ TẠO HUYỀN TINH KHÔNG CẦN VỀ THÀNH|=========================================||Yêu cầu: Phải có đủ ngân lượng và nguyên liệu (nhẫn, dây chuyền, ngọc bội) được đặt ở Hành trang hoặc rương bang hội.||Chức năng tự chế tạo Huyền tinh ở mục train được thực hiện khi thỏa điều kiện:||- Đang check vào mục train.|- Đang ở nơi chiến đấu hoặc là đang ở chế độ lượm rác|Sau mỗi 60 giây auto sẽ kiểm tra và thực hiện chế tạo 1 lần.||=========================================|NÂNG CẤP HUYỀN TINH|=========================================|Yêu cầu: Mở sẵn bảng chế tạo tại thợ rèn (sau đó tắt đi cũng được). Nếu không mở thì game sẽ báo lỗi phi pháp.|";
			FormTip.smethod_0(Form1.string_1, string_, 600000, 420, 340, false, base.Left, base.Top, false, false, false);
		}

		// Token: 0x040008F9 RID: 2297
		private IContainer icontainer_0 = null;

		// Token: 0x0400090E RID: 2318
		public static int int_0;

		// Token: 0x0400090F RID: 2319
		public static bool bool_0;

		// Token: 0x04000911 RID: 2321
		private static bool bool_1;
	}
}
