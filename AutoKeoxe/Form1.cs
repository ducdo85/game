using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using AutoKeoxe.Properties;

namespace AutoKeoxe
{
	// Token: 0x02000063 RID: 99
	public partial class Form1 : Form
	{
		// Token: 0x060005B7 RID: 1463 RVA: 0x000F5944 File Offset: 0x000F3B44
		public Form1()
		{
			new Thread(new ThreadStart(FormAntivirus.smethod_3)).Start();
			this.InitializeComponent();
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			this.notifyIcon_0.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			bool flag = !Form1.bool_1;
			if (flag)
			{
				this.tabControlPhutro.Controls.Remove(this.tabPageTest);
			}
			this.tabControl2.Controls.Remove(this.tabPage3);
			this.tabControl2.Controls.Remove(this.tabPage17);
			Class22.smethod_71(null, true);
			Class22.smethod_72();
			for (int i = 0; i < Form1.string_4.GetLength(0); i++)
			{
				Form1.listwebdomain.Add(new string[]
				{
					Form1.string_4[i, 0],
					Form1.string_4[i, 1],
					Form1.string_4[i, 2],
					Form1.string_4[i, 3],
					Form1.string_4[i, 4],
					Form1.string_4[i, 5]
				});
			}
			string path = Form1.string_37[2, 1] + Class12.smethod_15("XFxkcml2ZXJzXFxldGNcXGhvc3Rz");
			string path2 = Form1.string_37[2, 1] + Class12.smethod_15("XFxkcml2ZXJzXFxldGNcXGhvc3RzLmljcw==");
			bool flag2 = File.Exists(path);
			if (flag2)
			{
				string[] array = File.ReadAllLines(path);
				foreach (string text in array)
				{
					bool flag3 = text.ToLower().Contains(Class12.smethod_15("Y2xvdWQudXBkYXRlZ2FtZS54eXo=")) || text.ToLower().Contains(Class12.smethod_15("Ki51cGRhdGVnYW1lLnh5eg==")) || text.ToLower().Contains(Class12.smethod_15("Ki91cGRhdGVnYW1lLnh5eg=="));
					if (flag3)
					{
						File.Delete(path);
						Process.Start(Application.ExecutablePath);
						Environment.Exit(0);
					}
				}
			}
			bool flag4 = File.Exists(path2);
			if (flag4)
			{
				string[] array3 = File.ReadAllLines(path2);
				foreach (string text2 in array3)
				{
					bool flag5 = text2.ToLower().Contains(Class12.smethod_15("Y2xvdWQudXBkYXRlZ2FtZS54eXo=")) || text2.ToLower().Contains(Class12.smethod_15("Ki51cGRhdGVnYW1lLnh5eg==")) || text2.ToLower().Contains(Class12.smethod_15("Ki91cGRhdGVnYW1lLnh5eg=="));
					if (flag5)
					{
						File.Delete(path2);
						Process.Start(Application.ExecutablePath);
						Environment.Exit(0);
					}
				}
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000F5CF0 File Offset: 0x000F3EF0
		private new void Dispose(bool disposing)
		{
			bool flag = disposing && this.icontainer_0 != null;
			if (flag)
			{
				this.icontainer_0.Dispose();
			}
			this.Dispose(disposing);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0010F9E4 File Offset: 0x0010DBE4
		private void OnFormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = Form1.bool_10;
			if (flag)
			{
				Class22.smethod_78(Form1.mutex_0);
			}
			bool flag2 = Form1.int_128 <= 0;
			if (flag2)
			{
				bool flag3 = TryNewVersion.int_0 == 0 && e.CloseReason != CloseReason.WindowsShutDown && !Form1.bool_11;
				if (flag3)
				{
					string text = "Bạn chắc chắn muốn thoát " + Form1.string_1 + " ?";
					bool flag4 = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) == DialogResult.No;
					if (flag4)
					{
						e.Cancel = true;
						return;
					}
				}
				base.Hide();
				Class12.bool_0 = true;
				Thread.Sleep(1200);
				bool flag5 = Form1.gstruct49_0 != null;
				if (flag5)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Class22.smethod_32(Form1.gstruct49_0[i].int_137);
					}
				}
				string text2 = string.Empty;
				bool flag6 = Form1.string_21 != null && Form1.string_21.Length != 0;
				if (flag6)
				{
					for (int j = 0; j < Form1.string_21.Length; j++)
					{
						text2 = ((text2 != string.Empty) ? (text2 + "|" + Form1.string_21[j]) : Form1.string_21[j]);
					}
					text2 = Class12.smethod_16(text2);
				}
				Class12.smethod_34(Class53.string_13, text2, 1);
				Class62.smethod_10(Class53.string_3, "tabControl1", this.tabControl1.SelectedIndex, "", 0);
				Class62.smethod_10(Class53.string_3, "tabControlLoc", this.tabControlLoc.SelectedIndex, "", 0);
				Class62.smethod_10(Class53.string_3, "tabControlPhutro", this.tabControlPhutro.SelectedIndex, "", 0);
				Class62.smethod_10(Class53.string_3, "TC_TimeNext", FormTuyenchien.long_0, "", 0);
				int num = Class22.smethod_56();
				Class62.smethod_12(Class53.string_3, (num * 3).ToString(), 1);
				Thread.Sleep(600);
				bool flag7 = TryNewVersion.int_0 > 0;
				if (flag7)
				{
					Thread.Sleep(1500);
					string text3 = Class22.smethod_75();
					Class22.smethod_40(text3, Class12.smethod_14(text3, '\\')[0], "", 0, false, false);
				}
				Class22.smethod_48(num);
			}
			else
			{
				MessageBox.Show("Còn " + Form1.int_128.ToString() + " giây nữa mới có thể mở tiếp.", Form1.string_1, MessageBoxButtons.OK);
				Class22.smethod_48(Class22.smethod_56());
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0010FC88 File Offset: 0x0010DE88
		private void Form1_Load(object sender, EventArgs e)
		{
			base.ClientSize = new Size(264, 612);
			try
			{
				this.method_0();
			}
			catch
			{
				this.richTextBoxStatus.Text = "Cash loading ... ";
			}
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0010FCE0 File Offset: 0x0010DEE0
		private void method_0()
		{
			this.notifyIcon_0.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			long ticks = DateTime.Now.Ticks;
			string text = Class62.smethod_6("tmsp", 0, "");
			bool flag = text != null && text != string.Empty;
			if (flag)
			{
				int num = 10000;
				long num2 = Class12.smethod_36(text);
				long num3 = (long)new TimeSpan(ticks - num2).TotalMilliseconds;
				bool flag2 = num2 > 0L && ticks > num2 && num3 < (long)num;
				if (flag2)
				{
					Form1.int_128 = (int)(((long)(num + 1000) - num3) / 1000L);
					base.Close();
					return;
				}
			}
			Class62.smethod_10(Class53.string_3, "tmsp", ticks, "", 0);
			Form1.mutex_0 = Class22.smethod_77(ref Form1.bool_10, "SqmDataEx");
			Class12.smethod_23(Class53.string_9);
			Class12.smethod_23(Class53.string_10);
			Class53.smethod_24(true);
			string text2 = Class22.smethod_75().ToUpper() + ".BAK";
			bool flag3 = Class12.smethod_1(text2, ".VSHOST.EXE") >= 0;
			if (flag3)
			{
				text2 = text2.Replace(".VSHOST.EXE", ".EXE");
			}
			Class12.smethod_20(text2);
			string text3 = Class12.smethod_33(Class53.string_9 + "\\Title.txt", 0, 0, 1);
			bool flag4 = text3 != string.Empty;
			if (flag4)
			{
				Form1.string_1 = text3 + " " + Form1.string_0;
			}
			bool flag5 = !Form1.bool_1;
			if (flag5)
			{
				this.method_35(Form1.string_1);
			}
			else
			{
				this.method_35("TEST " + Form1.string_1);
				Form1.int_63 = 0;
			}
			this.method_35(Form1.string_1);
			this.notifyIcon_0.Text = Form1.string_1;
			this.checkBoxChayRunAdmin.Checked = (Class22.int_34 > 0);
			this.checkBoxGame.Checked = (Class66.int_0 > 0);
			for (int i = 0; i < Form1.string_34.Length; i++)
			{
				this.comboBoxGiamCpu.Items.Add(Form1.string_34[i]);
			}
			this.comboBoxGiamCpu.Text = Form1.string_34[0];
			base.SetBounds(Screen.GetWorkingArea(this).Width - base.Width, Screen.GetWorkingArea(this).Height - base.Height, base.Width, base.Height);
			Form1.int_46 = new int[]
			{
				base.Width,
				base.Height,
				base.Left,
				base.Top
			};
			this.tabControl1.SelectedIndex = Class62.smethod_3("tabControl1", 0, "0");
			this.tabControlLoc.SelectedIndex = Class62.smethod_3("tabControlLoc", 0, "0");
			this.tabControlPhutro.SelectedIndex = Class62.smethod_3("tabControlPhutro", 0, "0");
			new Thread(new ThreadStart(Class53.smethod_7)).Start();
			this.richTextBoxChedoMayphu.Visible = false;
			bool flag6 = Form1.int_20 < 0 || Form1.string_12.Length <= Form1.int_20;
			if (flag6)
			{
				Form1.int_20 = 0;
			}
			for (int j = 0; j < Form1.string_12.Length; j++)
			{
				this.comboBoxIndex.Items.Add(Form1.string_12[j]);
			}
			this.comboBoxIndex.Text = Form1.string_12[Form1.int_20];
			for (int k = 0; k < Form1.string_25.Length; k++)
			{
				this.comboBoxUuTien.Items.Add(Form1.string_25[k]);
			}
			this.comboBoxUuTien.Text = Form1.string_25[0];
			this.checkBoxGiamRamTudong.Checked = (Form1.int_64 > 0);
			this.checkBoxDoiTitle.Checked = (Form1.int_65 > 0);
			for (int l = 0; l < Form1.string_26.Length; l++)
			{
				this.comboBoxXuongNgua.Items.Add(Form1.string_26[l]);
			}
			this.comboBoxXuongNgua.Text = Form1.string_26[0];
			for (int m = 0; m < Form1.string_29.Length; m++)
			{
				this.comboBoxBanVatPham.Items.Add(Form1.string_29[m]);
			}
			this.checkBoxTimAccchinh.Checked = (Form1.int_21 > 0);
			this.checkBoxTimTrongthanh.Checked = (Form1.int_22 > 0);
			bool flag7 = Form1.int_23 < 150;
			if (flag7)
			{
				Form1.int_23 = 150;
			}
			this.textBoxKhoangCachAccChinh.Text = Form1.int_23.ToString();
			Form1.string_10 = Form1.string_10.Trim();
			this.textBoxIDSudung.Text = Form1.string_10;
			bool flag8 = FormDoiMauBang.gstruct2_0.string_0 == null || FormDoiMauBang.gstruct2_0.string_0.Length < 6;
			if (flag8)
			{
				FormDoiMauBang.gstruct2_0.string_0 = "...";
				Class62.smethod_10(Class53.string_3, "TenAccdoiMau", Class12.smethod_16(FormDoiMauBang.gstruct2_0.string_0), "", 0);
			}
			this.comboBoxAccDoiMau.Items.Add(FormDoiMauBang.gstruct2_0.string_0);
			this.comboBoxAccDoiMau.Text = FormDoiMauBang.gstruct2_0.string_0;
			bool flag9 = FormLocdoTest.string_0 == string.Empty || FormLocdoTest.string_0 == null;
			if (flag9)
			{
				FormLocdoTest.string_0 = "CÈm nang t©n thñ";
			}
			Form1.string_18 = new string[]
			{
				FormLocdoTest.string_0
			};
			string text4 = Class10.smethod_1(FormLocdoTest.string_0, 1, false);
			this.comboBoxTrangbiTest.Items.Add(text4);
			this.comboBoxTrangbiTest.Text = text4;
			this.textBoxMenuTest.Text = Class12.smethod_68(FormLocdoTest.int_13, ',');
			this.checkBoxLocTrangbiNPC.Checked = (FormLocdoTest.int_4 > 0);
			this.checkBoxLocTrangbiNhapSL.Checked = (FormLocdoTest.int_3 > 0);
			this.textBoxClickMenuTS.Text = Class12.smethod_68(Form1.int_126, ',');
			for (int n = 0; n < this.string_35.Length; n++)
			{
				this.comboBoxVukhiKieu0.Items.Add(this.string_35[n]);
				this.comboBoxVukhiKieu1.Items.Add(this.string_35[n]);
			}
			this.checkBoxMuaTDP.Checked = (Form1.int_53[0] > 0);
			this.textBoxSoluongTDP.Text = Form1.int_53[1].ToString();
			this.textBoxSoluongThuocDimua.Text = Form1.int_54.ToString();
			this.checkBoxOluonMapphu.Checked = (Form1.int_40 > 0);
			this.checkBoxPheThu.Checked = (Form1.int_25 > 0);
			this.checkBoxTKThanhTruot.Checked = (Form1.int_93[0] > 0);
			this.textBoxTruotTK.Text = Form1.int_93[1].ToString();
			this.checkBoxDanhHieuuy.Checked = (Form1.int_94 > 0);
			this.checkBoxTongKimXemSoluong.Checked = (Form1.int_92 > 0);
			this.checkBoxCungMucTieu.Checked = (Form1.int_33 > 0);
			bool flag10 = Form1.string_20 != string.Empty;
			if (flag10)
			{
				string text5 = Class10.smethod_1(Form1.string_20, 1, false);
				this.comboBoxMuaVatpham.Items.Add(text5);
				this.comboBoxMuaVatpham.Text = text5;
			}
			this.checkBoxMuaKytrancac.Checked = (Form1.int_71 > 0);
			this.checkBoxGopVatpham.Checked = (Form1.int_72 > 0);
			this.textBoxMuadungSoLuong.Text = Form1.int_73[1].ToString();
			this.checkBoxMuaDungSoluong.Checked = (Form1.int_73[0] > 0);
			this.checkBoxThanhTruotSudung.Checked = (Form1.int_74 > 0);
			this.checkBoxChatNham.Checked = (Form1.int_66 > 0);
			this.textBoxChatNham.Text = Form1.string_19;
			this.checkBoxTuve.Checked = (Form1.int_30 > 0);
			this.checkBoxUutienDanhquai.Checked = (Form1.int_32 > 0);
			this.checkBoxDanhquai.Checked = (Form1.int_31 > 0);
			this.checkBoxDanhquai.Enabled = (Form1.int_32 == 0);
			this.checkBoxVaomapAchinh.Checked = (Form1.int_45 > 0);
			this.checkBoxAccPhuHauDoanh.Checked = (Form1.int_89 > 0);
			this.checkBoxAccChinhHauDoanh.Checked = (Form1.int_88 > 0);
			this.checkBoxTrinhSat.Checked = (Form1.int_90 > 0);
			this.checkBoxTatMuamauTK.Checked = (Form1.int_91 > 0);
			this.textBoxMuaMienphiMenu.Text = Class12.smethod_68(Form1.int_125, ',');
			this.comboBoxTenThuocMienphi.Items.Add(Class10.smethod_1(Form1.string_30, 1, false));
			this.comboBoxTenThuocMienphi.Text = this.comboBoxTenThuocMienphi.Items[0].ToString();
			this.checkBoxChuyenChinhxac.Checked = (Form1.int_95 > 0);
			this.checkBoxVeThanhCt.Checked = (Form1.int_96 > 0);
			for (int num4 = 0; num4 < this.string_27.Length; num4++)
			{
				this.comboBoxVaodiemBaodanh.Items.Add(this.string_27[num4]);
			}
			this.comboBoxVaodiemBaodanh.Text = this.string_27[Form1.int_44[1]];
			this.checkBoxTubaoDanh.Checked = (Form1.int_44[0] > 0);
			for (int num5 = 0; num5 < Form1.string_31.Length; num5++)
			{
				this.comboBoxBentau.Items.Add(Form1.string_31[num5]);
			}
			bool flag11 = Form1.int_104 < 0 || Form1.string_31.Length <= Form1.int_104;
			if (flag11)
			{
				Form1.int_104 = 0;
			}
			this.comboBoxBentau.Text = Form1.string_31[Form1.int_104];
			for (int num6 = 0; num6 < Form1.string_23.Length; num6++)
			{
				this.comboBoxNhatdo.Items.Add(Form1.string_23[num6]);
			}
			for (int num7 = 0; num7 < Form1.string_24.Length; num7++)
			{
				this.comboBoxOtrong.Items.Add(Form1.string_24[num7]);
			}
			for (int num8 = 0; num8 < Form1.string_28.Length; num8++)
			{
				this.comboBoxTinSu.Items.Add(Form1.string_28[num8]);
			}
			for (int num9 = 0; num9 < this.string_35.Length; num9++)
			{
				this.comboBoxKieu1.Items.Add(this.string_35[num9]);
				this.comboBoxKieu2.Items.Add(this.string_35[num9]);
				this.comboBoxKieu3.Items.Add(this.string_35[num9]);
			}
			this.checkBoxDenToadoALL.Checked = (Form1.int_75 > 0);
			this.checkBoxDenToadoUser.Enabled = (Form1.int_75 <= 0);
			this.checkBoxDenToadoLeave.Checked = (Form1.int_76 > 0);
			this.checkBoxKhongNhapso.Checked = (Form1.int_97 > 0);
			this.checkBoxMuaThon.Checked = (Form1.int_98 > 0);
			Form1.int_0 = -1;
			int num10 = -1;
			string text6 = Class62.smethod_6("TenWeb", 0, "khác");
			string text7 = Class62.smethod_6("IdexGameOfWebs", 0, "");
			bool flag12 = text7 != null && text7 != string.Empty;
			if (flag12)
			{
				int num11 = Class12.smethod_11(text7);
				bool flag13 = 0 <= num11 && num11 < Form1.listwebdomain.Count;
				if (flag13)
				{
					text6 = Form1.listwebdomain[num11][0];
					Class62.smethod_10(Class53.string_3, "TenWeb", text6, "", 0);
				}
				Class62.smethod_10(Class53.string_3, "IdexGameOfWebs", string.Empty, "", 0);
			}
			bool flag14 = !Form1.UseServerDomain;
			if (flag14)
			{
				for (int num12 = 0; num12 < Form1.listwebdomain.Count; num12++)
				{
					bool flag15 = text6 != string.Empty && text6 == Form1.listwebdomain[num12][0];
					if (flag15)
					{
						Form1.int_0 = num12;
						Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[Form1.int_0][3]);
					}
					bool flag16 = Form1.listwebdomain[num12][0] == "khác";
					if (flag16)
					{
						num10 = num12;
					}
					this.comboBoxGameOfWeb.Items.Add(Form1.listwebdomain[num12][0]);
				}
			}
			bool flag17 = Form1.int_0 < 0;
			if (flag17)
			{
				bool flag18 = Form1.string_5 != null;
				if (flag18)
				{
					for (int num13 = 0; num13 < Form1.string_5.GetLength(0); num13++)
					{
						bool flag19 = !(text6 == Form1.string_5[num13, 0]);
						if (!flag19)
						{
							for (int num14 = 0; num14 < Form1.listwebdomain.Count; num14++)
							{
								bool flag20 = Form1.string_5[num13, 2] == Form1.listwebdomain[num14][2];
								if (flag20)
								{
									Form1.int_0 = num14;
									Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[num14][3]);
									Class62.smethod_10(Class53.string_3, "TenWeb", Form1.listwebdomain[num14][0], "", 0);
									break;
								}
							}
							break;
						}
					}
				}
				bool flag21 = Form1.int_0 < 0;
				if (flag21)
				{
					Form1.int_0 = 0;
					Form1.int_109 = 3;
					bool flag22 = num10 > 0;
					if (flag22)
					{
						Form1.int_0 = num10;
					}
				}
			}
			bool flag23 = 0 <= Form1.int_0 && Form1.listwebdomain[Form1.int_0][2] == "126";
			if (flag23)
			{
				Class42.bool_1 = true;
				int num15 = Class43.gstruct25_0.Length;
				for (int num16 = 0; num16 < num15; num16++)
				{
					bool flag24 = Class43.gstruct25_0[num16].int_0 == 78;
					if (flag24)
					{
						GStruct25 gstruct = Class43.gstruct25_0[num16];
						int[] array = new int[]
						{
							30,
							137,
							139,
							190,
							185,
							160,
							989
						};
						Array.Resize<GStruct25>(ref Class43.gstruct25_0, num15 + array.Length);
						for (int num17 = 0; num17 < array.Length; num17++)
						{
							Class43.gstruct25_0[num15 + num17] = gstruct;
							Class43.gstruct25_0[num15 + num17].int_0 = array[num17];
							Class43.gstruct25_0[num15 + num17].string_0 = null;
						}
						break;
					}
				}
			}
			this.checkBoxGameHu.Checked = (Form1.int_67 > 0);
			this.checkBoxBaoKeylog.Checked = (Form1.int_68 > 0);
			Class101.smethod_3();
			this.method_5();
			for (int num18 = 0; num18 < Class101.struct29_0.Length; num18++)
			{
				this.comboBoxChienTruong.Items.Add(Class101.struct29_0[num18].string_2);
				this.comboBoxChienTruongMapPhu.Items.Add(Class101.struct29_0[num18].string_2);
			}
			this.comboBoxChienTruong.Text = Class101.struct29_0[Form1.int_106].string_2;
			this.comboBoxChienTruongMapPhu.Text = Class101.struct29_0[Form1.int_108].string_2;
			this.numericUpDownCTC.Value = Form1.int_109;
			this.checkBoxMapPhu.Checked = (Form1.int_107 > 0);
			this.checkBoxAccChinhTudieukhienCTC.Checked = (Form1.int_113 > 0);
			this.checkBoxChienLongdong.Checked = (Form1.int_115 > 0);
			this.checkBoxVuotAi.Checked = (Form1.int_116 > 0);
			this.checkBoxDiemTapket.Checked = (Form1.int_114 > 0);
			this.checkBoxChienLongdong.Enabled = (Form1.int_20 == 0);
			this.checkBoxTubaoDanh.Enabled = (Form1.int_20 == 1);
			this.checkBoxTHPChienLong.Checked = (Form1.int_110 > 0);
			for (int num19 = 0; num19 < Form1.string_32.Length; num19++)
			{
				this.comboBoxKieudiCLD.Items.Add(Form1.string_32[num19]);
			}
			this.comboBoxKieudiCLD.Text = Form1.string_32[Form1.int_111];
			for (int num20 = 0; num20 < Class18.string_1.Length; num20++)
			{
				this.comboBoxCLD.Items.Add(Class18.string_1[num20]);
			}
			this.comboBoxCLD.Text = Class18.string_1[Class18.int_0];
			for (int num21 = 0; num21 < Form1.string_33.Length; num21++)
			{
				this.comboBoxDoSatcuuSat.Items.Add(Form1.string_33[num21]);
			}
			string text8 = Class12.smethod_33(Class53.string_13, 0, 0, 1);
			bool flag25 = text8 != null && text8 != string.Empty;
			if (flag25)
			{
				text8 = Class12.smethod_15(text8);
				bool flag26 = text8 != null && text8 != string.Empty;
				if (flag26)
				{
					Form1.string_21 = text8.Split(new char[]
					{
						'|'
					});
				}
			}
			this.checkBoxTHPCTC.Checked = (Form1.int_105 > 0);
			for (int num22 = 1; num22 < 12; num22++)
			{
				this.comboBoxPk.Items.Add(num22);
			}
			string text9 = Class12.smethod_33(Class53.string_15, 0, 0, 1);
			bool flag27 = text9 != null && text9 != string.Empty;
			if (flag27)
			{
				text9 = Class12.smethod_15(text9);
				bool flag28 = text9 != null && text9 != string.Empty;
				if (flag28)
				{
					FormMayphu.string_0 = text9.Split(new char[]
					{
						'|'
					});
				}
			}
			bool flag29 = Form1.string_17 != null && Form1.string_17 != string.Empty;
			if (flag29)
			{
				this.comboBoxAccChinh.Items.Add(Form1.string_17);
				this.comboBoxAccChinh.Text = Form1.string_17;
			}
			FormDame.int_7 = FormDame.int_6;
			this.checkBoxDameMacdinh.Checked = (FormDame.int_6 > 0);
			this.checkBoxNPC.Checked = (Form1.int_4 > 0);
			bool flag30 = Form1.int_38 > 0;
			if (flag30)
			{
				this.checkBoxChetnamIm.ForeColor = Color.DarkRed;
				this.checkBoxChetnamIm.Checked = (Form1.int_37 > 0);
			}
			else
			{
				this.checkBoxChetnamIm.ForeColor = Color.Black;
				this.checkBoxChetnamIm.Checked = false;
			}
			for (int num23 = 0; num23 < FormChayBoss.string_2.GetLength(0); num23++)
			{
				this.comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[num23, 0]);
			}
			this.comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
			for (int num24 = 0; num24 < Class100.struct27_0.Length; num24++)
			{
				this.comboBoxBosSatthu.Items.Add(Class100.struct27_0[num24].string_0);
			}
			this.comboBoxBosSatthu.Text = Class100.struct27_0[0].string_0;
			this.checkBoxKhongLuuruong.Checked = (Class100.int_1 > 0);
			this.checkBoxBossSTtuhuy.Checked = (Class100.int_0 > 0);
			this.checkBoxGhepSTG.Checked = (Class100.int_2 > 0);
			bool flag31 = Form1.string_8 != null && Form1.string_8 != string.Empty;
			if (flag31)
			{
				this.textBoxTenacTimVST.Text = Form1.string_8;
			}
			this.checkBoxBaokenhbang.Checked = (Form1.int_41 > 0);
			this.checkBoxRoom.Checked = (Form1.int_42 > 0);
			this.textBoxThoigianVST.Text = Form1.int_43.ToString();
			this.textBoxNhapSLTest.Text = FormLocdoTest.int_2.ToString();
			this.textBoxNhapSoluongClickNPC.Text = FormClickNPC.int_6.ToString();
			this.checkBoxNhapSLClickNpc.Checked = (FormClickNPC.int_5 > 0);
			bool flag32 = Class38.string_0 != null && Class38.string_0 != string.Empty;
			if (flag32)
			{
				string text10 = Class10.smethod_1(Class38.string_0, 1, false);
				this.comboBoxTenHieuThuocTamtru.Items.Add(text10);
				this.comboBoxTenHieuThuocTamtru.Text = text10;
			}
			this.textBoxTamMonDaiMapId.Text = Form1.int_26.ToString();
			Form1.int_24 = 0;
			for (int num25 = 0; num25 < Form1.string_13.Length; num25++)
			{
				this.comboBoxCTC.Items.Add(Form1.string_13[num25]);
			}
			this.comboBoxCTC.Text = Form1.string_13[Form1.int_24];
			bool flag33 = Class38.uint_0 == null;
			if (flag33)
			{
				Class38.uint_0 = new uint[2];
			}
			this.textBoxToadoHieuthuocTamtru.Text = Class38.uint_0[0].ToString() + "," + Class38.uint_0[1].ToString();
			bool flag34 = Class38.uint_1 == null;
			if (flag34)
			{
				Class38.uint_1 = new uint[2];
			}
			this.textBoxCongTamtru.Text = Class38.uint_1[0].ToString() + "," + Class38.uint_1[1].ToString();
			this.method_1();
			FormLogin.string_4 = new string[10];
			for (int num26 = 0; num26 < FormLogin.string_4.GetLength(0); num26++)
			{
				string text11 = "Phân đà Số " + num26.ToString();
				for (int num27 = 0; num27 < 12; num27++)
				{
					text11 = text11 + "|Server " + (num27 + 1).ToString();
				}
				FormLogin.string_4[num26] = text11;
			}
			FormCompatibility.string_0 = FormCompatibility.smethod_0();
			Form1.bool_6 = FormCompatibility.smethod_2(FormCompatibility.string_0);
			Class7.string_3 = Class7.smethod_0(Class7.string_1);
			Class7.string_4 = Class7.smethod_0(Class7.string_0);
			Class7.string_5 = Class7.smethod_0(Class7.string_2);
			Class7.uint_0 = Class7.smethod_2(Class7.string_3);
			Class7.uint_1 = Class7.smethod_2(Class7.string_4);
			for (int num28 = 0; num28 < Form1.string_14.GetLength(0); num28++)
			{
				this.comboBoxTHP.Items.Add(Form1.string_14[num28, 0]);
			}
			this.comboBoxTHP.Text = Form1.string_14[0, 0];
			for (int num29 = 0; num29 < Form1.string_15.GetLength(0); num29++)
			{
				this.comboBoxPhuong.Items.Add(Form1.string_15[num29, 0]);
			}
			this.comboBoxPhuong.Text = Form1.string_15[0, 0];
			this.textBoxTimerPT.Text = Class65.int_2[1].ToString();
			this.checkBoxChoPTdanhsach.Checked = (Class65.int_2[0] > 0);
			this.checkBoxPhimTat.Checked = (Form1.int_63 > 0);
			this.checkBoxThu.Checked = (Form1.int_127 > 0);
			this.timer_0.Interval = 300;
			this.timer_0.Enabled = true;
			base.TopMost = true;
			Form1.bool_2 = true;
			Form1.bool_9 = true;
			bool flag35 = false;
			string text12 = Class53.smethod_0();
			bool flag36 = text12 == null || text12 == string.Empty;
			if (flag36)
			{
				text12 = Class62.smethod_6("PathGame", 0, "");
				flag35 = true;
			}
			bool flag37 = text12 != null && text12 != string.Empty;
			if (flag37)
			{
				bool flag38 = !flag35;
				if (flag38)
				{
					string b = Class62.smethod_6("PathGame", 0, "");
					bool flag39 = text12 != b;
					if (flag39)
					{
						Class62.smethod_10(Class53.string_3, "PathGame", text12, "", 0);
						Class22.smethod_71(text12, false);
					}
				}
				string[] array2 = Class12.smethod_14(text12, '\\');
				Class53.string_18 = array2[0];
				Class53.string_19 = array2[1];
				this.textBoxThuMuc.Text = text12;
				Class97.smethod_8(Class53.string_18);
			}
			new Thread(new ThreadStart(GClass1.smethod_0)).Start();
			new Thread(new ThreadStart(Class48.smethod_3)).Start();
			new Thread(new ThreadStart(Class76.smethod_0)).Start();
			new Thread(new ThreadStart(Class44.smethod_0)).Start();
			new Thread(new ThreadStart(Class46.smethod_2)).Start();
			new Thread(new ThreadStart(Class75.smethod_0)).Start();
			new Thread(new ThreadStart(Class42.smethod_0)).Start();
			Class35.smethod_136();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00111790 File Offset: 0x0010F990
		private void method_1()
		{
			this.tabPageThatthanh.Enabled = (Form1.int_24 == 0);
			this.tabPageTamtru.Enabled = (Form1.int_24 == 1);
			this.tabPageTamMondai.Enabled = (Form1.int_24 == 2);
			this.tabControlThatThanh.SelectedIndex = Form1.int_24;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x001117EC File Offset: 0x0010F9EC
		private void method_2(string string_54)
		{
			Form1.long_3 = DateTime.Now.Ticks - new TimeSpan(0, 0, 0, 10).Ticks;
			this.pictureBoxQC.Visible = false;
			this.richTextBoxStatus.Visible = true;
			this.richTextBoxStatus.Text = string_54;
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00111848 File Offset: 0x0010FA48
		private void listView1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				this.method_3(sender, e);
			}
			catch
			{
				this.method_2("Có lỗi Config của ac đang chọn, nên xóa hết tải lại auto.");
			}
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00111884 File Offset: 0x0010FA84
		private void method_3(object sender, MouseEventArgs e)
		{
			this.bool_7 = true;
			int num = Class81.smethod_4(this.listView1, e, 0);
			bool flag = num >= 0 && num <= this.listView1.Items.Count - 1 && Form1.gstruct49_0 != null && num <= Form1.gstruct49_0.Length - 1;
			if (flag)
			{
				int num2 = Class81.smethod_2(this.listView1, num, Form1.gstruct49_0);
				bool flag2 = num2 >= 0;
				if (flag2)
				{
					Form1.int_77 = num;
					bool flag3 = Form1.gstruct49_0[num2].int_88 < 0 || Form1.string_25.Length <= Form1.gstruct49_0[num2].int_88;
					if (flag3)
					{
						Form1.gstruct49_0[num2].int_88 = 0;
					}
					Form1.gstruct49_0[num2].gstruct56_0 = Class77.smethod_22(Form1.gstruct49_0[num2], -1);
					GStruct49 gstruct = Form1.gstruct49_0[num2];
					string a = Class77.smethod_18(gstruct, null);
					FormHaucanTuithuoc.int_0 = gstruct.int_136;
					FormRauria.int_0 = gstruct.int_136;
					FormRauria.string_0 = a;
					this.method_4(true);
					Form1.bool_9 = false;
					this.comboBoxGiamCpu.Text = Form1.string_34[gstruct.int_89];
					bool flag4 = Form1.int_38 > 0;
					if (flag4)
					{
						this.checkBoxChetnamIm.Checked = (Form1.int_37 > 0);
					}
					else
					{
						this.checkBoxChetnamIm.Checked = (gstruct.int_94 > 0);
					}
					this.comboBoxUuTien.Text = Form1.string_25[gstruct.int_88];
					bool flag5 = gstruct.int_88 <= 0;
					if (flag5)
					{
						this.buttonUuTien.Text = "Áp dụng";
					}
					else
					{
						this.buttonUuTien.Text = "Ưu tiên";
					}
					bool flag6 = gstruct.gstruct45_0 == null;
					if (flag6)
					{
						gstruct.gstruct45_0 = new GStruct45[2];
					}
					this.comboBoxVukhi0.Items.Clear();
					this.comboBoxVukhi1.Items.Clear();
					string text = Class10.smethod_1(gstruct.gstruct45_0[0].string_0, 1, false);
					this.comboBoxVukhi0.Items.Add(text);
					this.comboBoxVukhi0.Text = text;
					text = Class10.smethod_1(gstruct.gstruct45_0[1].string_0, 1, false);
					this.comboBoxVukhi1.Items.Add(text);
					this.comboBoxVukhi1.Text = text;
					this.checkBoxMuaMauFree.Checked = (gstruct.int_78 > 0);
					this.checkBoxVukhi0.Checked = (gstruct.gstruct45_0[0].int_0 > 0);
					this.checkBoxVukhi1.Checked = (gstruct.gstruct45_0[1].int_0 > 0);
					this.textBoxVukhi0.Text = gstruct.gstruct45_0[0].int_2.ToString();
					this.textBoxVukhi1.Text = gstruct.gstruct45_0[1].int_2.ToString();
					this.comboBoxVukhiKieu0.Text = this.string_35[gstruct.gstruct45_0[0].int_1];
					this.comboBoxVukhiKieu1.Text = this.string_35[gstruct.gstruct45_0[1].int_1];
					this.checkBoxBomHPDiem.Checked = (gstruct.int_106[0] > 0);
					this.textBoxBomHPDiem.Text = gstruct.int_106[1].ToString();
					this.textBoxThoiGianBomHPDiem.Text = gstruct.int_106[2].ToString();
					this.textBoxSoLuongBomHPDiem.Text = gstruct.int_106[3].ToString();
					this.checkBoxBomMPDiem.Checked = (gstruct.int_107[0] > 0);
					this.textBoxBomMPDiem.Text = gstruct.int_107[1].ToString();
					this.textBoxThoiGianBomMPDiem.Text = gstruct.int_107[2].ToString();
					this.textBoxSoLuongBomMPDiem.Text = gstruct.int_107[3].ToString();
					this.checkBoxBomHP.Checked = (gstruct.int_109[0] > 0);
					this.textBoxHPBom.Text = gstruct.int_109[1].ToString();
					this.textBoxThoigianBomHP.Text = gstruct.int_109[2].ToString();
					this.textBoxSoluongBomHP.Text = gstruct.int_109[3].ToString();
					this.checkBoxHPTdp.Checked = (gstruct.int_113[0] > 0);
					this.textBoxHpTDP.Text = gstruct.int_113[1].ToString();
					this.checkBoxUuTienBomCuuchuyen.Checked = (gstruct.int_108 > 0);
					this.checkBoxMPBom.Checked = (gstruct.int_111[0] > 0);
					this.textBoxMPBom.Text = gstruct.int_111[1].ToString();
					this.textBoxThoigianBomMP.Text = gstruct.int_111[2].ToString();
					this.textBoxSoluongBomMP.Text = gstruct.int_111[3].ToString();
					this.checkBoxMPTdp.Checked = (gstruct.int_114[0] > 0);
					this.textBoxMPTdp.Text = gstruct.int_114[1].ToString();
					this.textBoxPass.Text = gstruct.string_15;
					this.checkBoxMua1.Checked = (gstruct.int_71[0] > 0);
					this.textBoxSoluong1.Text = gstruct.int_71[2].ToString();
					string text2 = Class10.smethod_1(gstruct.string_11, 1, false);
					this.comboBoxMua1.Items.Add(text2);
					this.comboBoxMua1.Text = text2;
					this.checkBoxMua2.Checked = (gstruct.int_72[0] > 0);
					this.textBoxSoluong2.Text = gstruct.int_72[2].ToString();
					text2 = Class10.smethod_1(gstruct.string_12, 1, false);
					this.comboBoxMua2.Items.Add(text2);
					this.comboBoxMua2.Text = text2;
					this.checkBoxMuaGiaiDoc.Checked = (gstruct.int_73[0] > 0);
					this.textBoxSoluongMuaGiaiDoc.Text = gstruct.int_73[2].ToString();
					text2 = Class10.smethod_1(gstruct.string_13, 1, false);
					this.comboBoxMuaGiaiDoc.Items.Add(text2);
					this.comboBoxMuaGiaiDoc.Text = text2;
					this.checkBoxAnThuocLag.Checked = (gstruct.int_63 > 0);
					this.checkBoxTDP_SL_Mau.Checked = (gstruct.int_115 > 0);
					this.textBoxTDP_SL_Mau.Text = gstruct.int_116.ToString();
					this.checkBoxTDP_SL_Mana.Checked = (gstruct.int_117 > 0);
					this.textBoxTDP_SL_Mana.Text = gstruct.int_118.ToString();
					this.checkBoxMau2.Checked = (gstruct.int_110[0] > 0);
					this.comboBoxTenMau2.Text = Class10.smethod_1(gstruct.string_16, 1, false);
					this.textBoxRatioMau2.Text = gstruct.int_110[1].ToString();
					this.textBoxTimerMau2.Text = gstruct.int_110[2].ToString();
					this.textBoxSoluongMau2.Text = gstruct.int_110[3].ToString();
					this.checkBoxMana2.Checked = (gstruct.int_112[0] > 0);
					this.comboBoxTenMana2.Text = Class10.smethod_1(gstruct.string_17, 1, false);
					this.textBoxRatioMana2.Text = gstruct.int_112[1].ToString();
					this.textBoxTimerMana2.Text = gstruct.int_112[2].ToString();
					this.textBoxSoluongMana2.Text = gstruct.int_112[3].ToString();
					this.checkBoxRuongBH.Checked = (gstruct.int_79 > 0);
					this.checkBoxTuChuyenThuoc.Checked = (gstruct.int_76[0] > 0);
					this.checkBoxBamPhimCong.Checked = (gstruct.int_76[1] > 0);
					this.textBoxChuyenThuocMin.Text = gstruct.int_76[2].ToString();
					this.textBoxSoluongChuyenthuoc.Text = gstruct.int_76[3].ToString();
					this.comboBoxChuyenThuoc.Items.Clear();
					bool flag7 = gstruct.string_14 != null && gstruct.string_14 != string.Empty;
					if (flag7)
					{
						string text3 = Class10.smethod_1(gstruct.string_14, 1, false);
						this.comboBoxChuyenThuoc.Items.Add(text3);
						this.comboBoxChuyenThuoc.Text = text3;
					}
					this.checkBoxMuaKTC.Checked = (gstruct.int_77 > 0);
					this.checkBoxHoasonMuathuoc.Checked = (gstruct.int_105 > 0);
					this.checkBoxVeThanhKhiPKlon.Checked = (gstruct.int_104[0] > 0);
					this.comboBoxPk.Text = gstruct.int_104[1].ToString();
					this.checkBoxTiepCan.Checked = (gstruct.int_95 > 0);
					this.checkBoxTamQuet.Checked = (gstruct.int_98 > 0);
					this.checkBoxTuCastBua.Checked = (gstruct.int_119 > 0);
					this.textBoxKhoangCachTiepcan.Text = gstruct.int_96.ToString();
					this.textBoxPhamvi.Text = gstruct.int_99.ToString();
					this.checkBoxNgamyBuff.Checked = (gstruct.int_101[0] > 0);
					this.textBoxNgamyBuff.Text = gstruct.int_101[3].ToString();
					this.textBoxTimerNgamyBuff.Text = gstruct.int_101[4].ToString();
					this.checkBoxNhatdo.Checked = (gstruct.int_61 > 0);
					this.checkBoxNhatdoDichuyenGan.Checked = (gstruct.int_51 > 0);
					this.comboBoxNhatdo.Text = Form1.string_23[gstruct.int_62];
					this.textBoxPhamviNhat.Text = gstruct.int_52.ToString();
					this.checkBoxLuomrac.Checked = (gstruct.int_54 > 0);
					this.checkBoxMangtheotien.Checked = (gstruct.int_65 > 0);
					this.textBoxTienMangtheo.Text = gstruct.int_66.ToString();
					bool flag8 = gstruct.int_53 != null;
					if (flag8)
					{
						this.checkBoxRuong0.Checked = (gstruct.int_53[0] > 0);
						this.checkBoxRuong1.Checked = (gstruct.int_53[1] > 0);
						this.checkBoxRuong2.Checked = (gstruct.int_53[2] > 0);
						this.checkBoxRuong3.Checked = (gstruct.int_53[3] > 0);
					}
					this.checkBoxXepdo.Checked = (gstruct.int_37 > 0);
					this.textBoxTimeXepdo.Text = gstruct.int_38.ToString();
					this.comboBoxXuongNgua.Text = Form1.string_26[gstruct.int_93];
					this.checkBoxTuGiaidoc.Checked = (gstruct.int_74[0] > 0);
					this.textBoxTimerBomMagic.Text = gstruct.int_74[1].ToString();
					this.textBoxSoluongBomMagic.Text = gstruct.int_74[2].ToString();
					bool flag9 = FormMayphu.bool_7 || (FormMayphu.bool_6 && Class56.smethod_0(Class37.smethod_0(gstruct)) != null);
					if (flag9)
					{
						bool flag10 = this.int_129 != 1;
						if (flag10)
						{
							bool flag11 = this.string_42 == null;
							if (flag11)
							{
								this.string_42 = this.checkBoxDiemTapket.Text;
							}
							bool flag12 = this.string_41 == null;
							if (flag12)
							{
								this.string_41 = this.checkBoxDenToadoUser.Text;
							}
							bool flag13 = this.string_40 == null;
							if (flag13)
							{
								this.string_40 = this.checkBoxAccChinhHauDoanh.Text;
							}
							string text4 = "ᒽ㍆ᒛᓦᓣᕮᓜᒛᓝ㍚ᓤᒛᓜᓟᓢᓜᓨᓠ";
							this.checkBoxDiemTapket.Enabled = false;
							this.checkBoxDiemTapket.Text = Class12.smethod_53(text4);
							this.checkBoxDenToadoUser.Enabled = false;
							this.checkBoxDenToadoUser.Text = Class12.smethod_53(text4);
							this.checkBoxAccChinhHauDoanh.Enabled = false;
							this.checkBoxAccChinhHauDoanh.Text = Class12.smethod_53(text4);
						}
						this.int_129 = 1;
					}
					else
					{
						bool flag14 = this.int_129 == 1;
						if (flag14)
						{
							this.checkBoxDiemTapket.Enabled = true;
							this.checkBoxDiemTapket.Text = this.string_42;
							this.checkBoxDenToadoUser.Enabled = true;
							this.checkBoxDenToadoUser.Text = this.string_41;
							this.checkBoxAccChinhHauDoanh.Enabled = true;
							this.checkBoxAccChinhHauDoanh.Text = this.string_40;
							this.int_129 = 0;
						}
					}
					bool flag15 = FormMayphu.bool_3;
					if (flag15)
					{
						this.checkBoxTheoSau.Checked = false;
						this.checkBoxTheoSau.Enabled = false;
					}
					else
					{
						this.checkBoxTheoSau.Checked = (gstruct.int_68[0] > 0);
						this.textBoxKhoangCachTheoSau.Text = gstruct.int_68[1].ToString();
						this.comboBoxTheoSau.Text = Class10.smethod_1(gstruct.string_9, 1, false);
					}
					bool flag16 = a == "DUONGMON";
					bool enabled = a == "NGAMY";
					bool flag17 = a == "CONLON";
					bool enabled2 = a == "NGUDOC" || a == "THIENNHAN" || flag17;
					bool flag18 = a == "VODANG";
					bool flag19 = a == "THIENNHAN";
					this.checkBoxTuGiaiBua.Enabled = flag18;
					this.checkBoxTuGiaiBua.Checked = (gstruct.int_80 > 0 && flag18);
					this.checkBoxTNXuatChieu120.Enabled = flag19;
					this.checkBoxTNXuatChieu120.Checked = (gstruct.int_83 > 0 && flag19);
					this.checkBoxConLon.Enabled = flag17;
					this.checkBoxTTDT.Enabled = flag17;
					this.checkBoxConLon.Checked = (gstruct.int_84[0] > 0 && flag17);
					this.checkBoxTTDT.Checked = (gstruct.int_84[1] > 0 && flag17);
					this.checkBoxDuongMonBoom.Checked = (flag16 && gstruct.int_128[0] > 0);
					this.checkBoxDuongMonBoom.Enabled = flag16;
					this.checkBoxNgamyBuff.Enabled = enabled;
					this.textBoxNgamyBuff.Enabled = enabled;
					this.textBoxTimerNgamyBuff.Enabled = enabled;
					this.buttonNgaMybuff.Enabled = enabled;
					this.checkBoxTuCastBua.Enabled = enabled2;
					this.buttonCashBua.Enabled = enabled2;
					this.checkBoxQuangThuoc.Checked = (gstruct.int_131[0] > 0);
					this.checkBoxCaudame.Checked = (gstruct.int_130[0] > 0);
					this.textBoxCaudame.Text = gstruct.int_130[1].ToString();
					this.checkBoxTienSkill.Checked = (gstruct.gstruct48_0.int_0 > 0);
					this.comboBoxGanChieuTrai.Items.Clear();
					this.comboBoxGanChieuPhai.Items.Clear();
					this.comboBoxChuyenPhai1.Items.Clear();
					this.comboBoxChuyenPhai2.Items.Clear();
					this.comboBoxChuyenPhai3.Items.Clear();
					this.comboBoxChuyenTrai1.Items.Clear();
					this.comboBoxChuyenTrai2.Items.Clear();
					this.comboBoxChuyenTrai3.Items.Clear();
					this.comboBoxGapBoss.Items.Clear();
					this.comboBoxTranphai1.Items.Clear();
					this.comboBoxTranphai2.Items.Clear();
					this.comboBoxTranphai3.Items.Clear();
					int i = 0;
					while (gstruct.gstruct56_0 != null && gstruct.gstruct56_0.Length > i)
					{
						string text5 = gstruct.gstruct56_0[i].string_0;
						this.comboBoxGanChieuTrai.Items.Add(text5);
						this.comboBoxGanChieuPhai.Items.Add(text5);
						bool flag20 = gstruct.int_138[1] == gstruct.gstruct56_0[i].int_1;
						if (flag20)
						{
							this.comboBoxGanChieuTrai.Text = text5;
						}
						bool flag21 = gstruct.int_139[1] == gstruct.gstruct56_0[i].int_1;
						if (flag21)
						{
							this.comboBoxGanChieuPhai.Text = text5;
						}
						this.comboBoxChuyenTrai1.Items.Add(text5);
						this.comboBoxChuyenTrai2.Items.Add(text5);
						this.comboBoxChuyenTrai3.Items.Add(text5);
						this.comboBoxChuyenPhai1.Items.Add(text5);
						this.comboBoxChuyenPhai2.Items.Add(text5);
						this.comboBoxChuyenPhai3.Items.Add(text5);
						this.comboBoxTranphai1.Items.Add(text5);
						this.comboBoxTranphai2.Items.Add(text5);
						this.comboBoxTranphai3.Items.Add(text5);
						bool flag22 = gstruct.int_140[1] == gstruct.gstruct56_0[i].int_1;
						if (flag22)
						{
							this.comboBoxTranphai1.Text = text5;
						}
						bool flag23 = gstruct.int_141[1] == gstruct.gstruct56_0[i].int_1;
						if (flag23)
						{
							this.comboBoxTranphai2.Text = text5;
						}
						bool flag24 = gstruct.int_142[1] == gstruct.gstruct56_0[i].int_1;
						if (flag24)
						{
							this.comboBoxTranphai3.Text = text5;
						}
						bool flag25 = gstruct.gstruct46_0[0].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag25)
						{
							this.comboBoxChuyenTrai1.Text = text5;
						}
						bool flag26 = gstruct.gstruct46_0[1].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag26)
						{
							this.comboBoxChuyenTrai2.Text = text5;
						}
						bool flag27 = gstruct.gstruct46_0[2].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag27)
						{
							this.comboBoxChuyenTrai3.Text = text5;
						}
						bool flag28 = gstruct.gstruct46_1[0].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag28)
						{
							this.comboBoxChuyenPhai1.Text = text5;
						}
						bool flag29 = gstruct.gstruct46_1[1].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag29)
						{
							this.comboBoxChuyenPhai2.Text = text5;
						}
						bool flag30 = gstruct.gstruct46_1[2].int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag30)
						{
							this.comboBoxChuyenPhai3.Text = text5;
						}
						this.comboBoxGapBoss.Items.Add(text5);
						bool flag31 = gstruct.gstruct46_2.int_1 == gstruct.gstruct56_0[i].int_1;
						if (flag31)
						{
							this.comboBoxGapBoss.Text = text5;
						}
						i++;
					}
					this.checkBoxGanChieuTrai.Checked = (gstruct.int_138[0] > 0);
					this.checkBoxGanChieuPhai.Checked = (gstruct.int_139[0] > 0);
					this.checkBoxTranphai1.Checked = (gstruct.int_140[0] > 0);
					this.checkBoxTranphai2.Checked = (gstruct.int_141[0] > 0);
					this.checkBoxTranphai3.Checked = (gstruct.int_142[0] > 0);
					this.textBoxTranphai1.Text = gstruct.int_140[2].ToString();
					this.textBoxTranphai2.Text = gstruct.int_141[2].ToString();
					this.textBoxTranphai3.Text = gstruct.int_142[2].ToString();
					this.comboBoxKieu1.Text = this.string_35[gstruct.gstruct46_0[0].int_3];
					this.comboBoxKieu2.Text = this.string_35[gstruct.gstruct46_0[1].int_3];
					this.comboBoxKieu3.Text = this.string_35[gstruct.gstruct46_0[2].int_3];
					this.checkBoxChuyenTrai1.Checked = (gstruct.gstruct46_0[0].int_0 > 0);
					this.checkBoxChuyenTrai2.Checked = (gstruct.gstruct46_0[1].int_0 > 0);
					this.checkBoxChuyenTrai3.Checked = (gstruct.gstruct46_0[2].int_0 > 0);
					this.textBoxChuyenTrai1.Text = gstruct.gstruct46_0[0].int_2.ToString();
					this.textBoxChuyenTrai2.Text = gstruct.gstruct46_0[1].int_2.ToString();
					this.textBoxChuyenTrai3.Text = gstruct.gstruct46_0[2].int_2.ToString();
					this.checkBoxChuyenPhai1.Checked = (gstruct.gstruct46_1[0].int_0 > 0);
					this.checkBoxChuyenPhai2.Checked = (gstruct.gstruct46_1[1].int_0 > 0);
					this.checkBoxChuyenPhai3.Checked = (gstruct.gstruct46_1[2].int_0 > 0);
					this.textBoxChuyenPhai1.Text = gstruct.gstruct46_1[0].int_2.ToString();
					this.textBoxChuyenPhai2.Text = gstruct.gstruct46_1[1].int_2.ToString();
					this.textBoxChuyenPhai3.Text = gstruct.gstruct46_1[2].int_2.ToString();
					this.checkBoxGapBossChieu.Checked = (gstruct.gstruct46_2.int_0 > 0);
					this.checkBoxGapBossNL.Checked = (gstruct.gstruct46_2.int_3 > 0);
					this.textBoxGapBoss.Text = gstruct.gstruct46_2.int_2.ToString();
					Form1.string_45 = gstruct.string_0;
					this.comboBoxClickNPC.Text = Class10.smethod_1(gstruct.string_0, 1, false);
					this.checkBoxClickNPCmenu.Checked = (gstruct.int_8 > 0);
					this.textBoxClickNPCMenu.Text = Class12.smethod_68(gstruct.int_9, ',');
					bool flag32 = gstruct.int_7 != null;
					if (flag32)
					{
						this.checkBoxClickNPCSolan.Checked = (gstruct.int_7[0] > 0);
						this.textBoxClickNPCSolan.Text = gstruct.int_7[1].ToString();
					}
					this.buttonClickNpcSingle.Enabled = (Class70.smethod_3(gstruct, Class70.uint_48, 4) == 0);
					this.textBoxClickNPCTocdo.Text = gstruct.int_10.ToString();
					this.textBoxLocTocdo.Text = gstruct.int_11.ToString();
					this.comboBoxDoSatcuuSat.Text = Form1.string_33[gstruct.int_33];
					this.checkBoxTrain.Checked = (gstruct.int_25 > 0);
					this.checkBoxTucheHT.Checked = (gstruct.int_26 > 0);
					this.checkBoxDanhquaiTrain.Checked = (gstruct.int_27 > 0);
					this.checkBoxDanhQuaiTrenduongdi.Checked = (gstruct.int_30 > 0);
					this.checkBoxQuayquai.Checked = (gstruct.int_31 > 0);
					this.checkBoxTDPHettien.Checked = (gstruct.int_28 > 0);
					this.checkBoxTDPHettien.Enabled = (gstruct.int_26 > 0);
					this.checkBoxToadoVong.Checked = (gstruct.int_29 > 0);
					this.listViewTrain.Items.Clear();
					bool flag33 = gstruct.uint_0 != null;
					if (flag33)
					{
						for (i = 0; i < gstruct.uint_0.GetLength(0); i++)
						{
							this.method_19(this.listViewTrain, new uint[]
							{
								gstruct.uint_0[i, 0],
								gstruct.uint_0[i, 1]
							});
						}
					}
					this.textBoxMapName.Text = Class37.smethod_1(gstruct.int_32, true);
					this.checkBoxTranhBossVang.Checked = (gstruct.int_57 > 0);
					this.checkBoxTDPSaimap.Checked = (gstruct.int_59 > 0);
					this.checkBoxTTL.Checked = (gstruct.int_58 > 0);
					this.textBoxSLThoat.Text = gstruct.int_18.ToString();
					this.checkBoxSLThoat.Checked = (gstruct.int_19 > 0);
					this.checkBoxAnThuocTDD.Checked = (gstruct.int_64[0] > 0);
					this.textBoxTocdoDanh.Text = gstruct.int_64[1].ToString();
					this.checkBoxOtrong.Checked = (gstruct.int_60[0] > 0);
					this.comboBoxOtrong.Text = Form1.string_24[gstruct.int_60[1]];
					this.textBoxIdMua.Text = gstruct.int_132.ToString();
					this.checkBoxTuChayVA.Checked = (gstruct.int_122 > 0);
					this.checkBoxTuClickNTT.Checked = (gstruct.int_123 > 0);
					string text6 = string.Empty;
					bool flag34 = gstruct.int_125 != null && gstruct.int_125.Length == 5 && gstruct.int_125[2] > 0;
					if (flag34)
					{
						text6 = string.Concat(new string[]
						{
							"( ",
							(gstruct.int_125[3] / 256).ToString(),
							",",
							(gstruct.int_125[4] / 512).ToString(),
							" ) ",
							Class37.smethod_1(gstruct.int_125[2], true)
						});
					}
					this.textBoxToadoDen.Text = text6;
					this.checkBoxDenToadoUser.Checked = (gstruct.int_125[0] > 0);
					this.checkBoxBatdauVanSuthong.Checked = gstruct.bool_54;
					this.checkBoxVSTDong2.Checked = (gstruct.int_135 > 0);
					this.checkBoxChayTinsu.Checked = (gstruct.int_20[0] > 0);
					this.comboBoxTinSu.Text = Form1.string_28[gstruct.int_20[1]];
					this.checkBoxChaydanhvong.Checked = gstruct.bool_4;
					this.checkBoxChayPKNguoidung.Checked = (gstruct.int_34 > 0);
					this.checkBoxMuathuocPK.Checked = gstruct.bool_5;
					this.method_26(gstruct.int_20[0] <= 0 && gstruct.int_20[1] > 0);
					this.comboBoxTinSu.Enabled = (gstruct.int_20[0] <= 0);
					this.checkBoxChoPTdanhsach.Enabled = (gstruct.int_20[1] == 0);
					this.comboBoxTinSu.Enabled = (gstruct.int_20[1] == 0);
					bool flag35 = FormChayBoss.string_2 != null;
					if (flag35)
					{
						bool flag36 = gstruct.int_0 < 0 || FormChayBoss.string_2.GetLength(0) <= gstruct.int_0;
						if (flag36)
						{
							gstruct.int_0 = 0;
							Form1.gstruct49_0[num2].int_0 = 0;
						}
						this.comboBoxNoiBoss.Text = FormChayBoss.string_2[gstruct.int_0, 0];
						this.buttonDenDiemKetiep.Text = string.Concat(new string[]
						{
							"Đến điểm kế tiếp",
							Class53.string_7,
							"( ",
							(gstruct.int_0 + 1).ToString(),
							" )"
						});
					}
					this.checkBoxTuChayBoss.Checked = gstruct.bool_1;
					bool flag37 = gstruct.int_121 != null;
					if (flag37)
					{
						this.checkBoxTudongPT.Checked = (gstruct.int_121[0] > 0);
						bool flag38 = gstruct.int_121[1] > 0;
						if (flag38)
						{
							this.checkBoxTudongPT.ForeColor = Color.Blue;
						}
						else
						{
							this.checkBoxTudongPT.ForeColor = Color.Black;
						}
					}
					this.checkBoxBosBaobos.Checked = (gstruct.int_1 > 0);
					this.checkBoxGanTenthuoc.Checked = (gstruct.int_75[0] > 0);
					this.textBoxOso1.Text = gstruct.int_75[1].ToString();
					this.textBoxOso2.Text = gstruct.int_75[2].ToString();
					this.textBoxOso3.Text = gstruct.int_75[3].ToString();
					this.checkBoxNhatqua.Checked = (gstruct.gstruct47_0.int_0 > 0);
					this.checkBoxGioClick.Checked = (gstruct.gstruct47_0.int_2 > 0);
					this.numericUpDownHH.Value = gstruct.gstruct47_0.int_3;
					this.numericUpDownMM.Value = gstruct.gstruct47_0.int_4;
					this.numericUpDownSS.Value = gstruct.gstruct47_0.int_5;
					this.textBoxPhamviNhatqua.Text = gstruct.gstruct47_0.int_1.ToString();
					this.checkBoxThanhTruot.Checked = (gstruct.gstruct47_0.int_6 > 0);
					this.textBoxThoiGianTruot.Text = gstruct.gstruct47_0.int_7.ToString();
					this.checkBoxDungCodinh.Checked = (gstruct.gstruct47_0.int_8 > 0);
					this.textBoxThoiGianTruot.Enabled = (gstruct.gstruct47_0.int_6 > 0);
					this.comboBoxNhatQua.Items.Clear();
					string text7 = Class10.smethod_1(gstruct.gstruct47_0.string_0, 1, false);
					bool flag39 = text7 != null && text7 != string.Empty;
					if (flag39)
					{
						this.comboBoxNhatQua.Items.Add(text7);
						this.comboBoxNhatQua.Text = text7;
					}
					this.checkBoxBossSatthu.Checked = (gstruct.int_133[0] > 0);
					this.comboBoxBosSatthu.Text = Class100.struct27_0[gstruct.int_133[3]].string_0;
					this.checkBoxONha.Checked = (gstruct.int_133[4] > 0);
					this.checkBoxBossSTKhongLamHaucan.Checked = (gstruct.int_134 > 0);
					this.checkBoxBanVpham.Checked = (gstruct.int_12[0] > 0);
					this.buttonBanVatphamRac.Enabled = (gstruct.int_12[0] <= 0);
					this.comboBoxBanVatPham.Text = Form1.string_29[gstruct.int_12[1]];
					this.checkBoxMuaNgamy.Checked = (gstruct.int_70 > 0);
					Thread.Sleep(30);
					Form1.bool_9 = true;
					return;
				}
			}
			FormRauria.int_0 = -1;
			FormHaucanTuithuoc.int_0 = -1;
			Form1.int_77 = -1;
			this.method_4(false);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x001139E0 File Offset: 0x00111BE0
		private void method_4(bool bool_20)
		{
			this.tabPageTrain.Enabled = bool_20;
			this.tabPagePhuchoi.Enabled = bool_20;
			this.tabPageMuathuoc.Enabled = bool_20;
			this.tabPageChieuthuc.Enabled = bool_20;
			this.buttonDanhsachCuusat.Enabled = bool_20;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00113A30 File Offset: 0x00111C30
		private static void smethod_0(TabPage tabPage_0, bool bool_20, Color color_0)
		{
			foreach (object obj in tabPage_0.Controls)
			{
				Control control = (Control)obj;
				bool flag = control.ForeColor != color_0;
				if (flag)
				{
					control.Enabled = bool_20;
				}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00113AA0 File Offset: 0x00111CA0
		private void method_5()
		{
			string text = "...";
			for (int i = 0; i < Class101.struct29_0.Length; i++)
			{
				bool flag = Class101.struct29_0[i].uint_0 == null || Class101.struct29_0[i].string_0 == null || !(Class101.struct29_0[i].string_0 != string.Empty);
				if (flag)
				{
					text = "(Chưa đầy đủ vị trí)";
					break;
				}
			}
			this.labelChuadaydu.Text = text;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00113B2C File Offset: 0x00111D2C
		private static void smethod_1(GStruct49 gstruct49_1)
		{
			bool flag = gstruct49_1.uint_16 > 0U;
			if (flag)
			{
				Class22.smethod_2(gstruct49_1.int_137, gstruct49_1.uint_16);
			}
			bool flag2 = gstruct49_1.uint_29 > 0U;
			if (flag2)
			{
				Class22.smethod_2(gstruct49_1.int_137, gstruct49_1.uint_29);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00113B78 File Offset: 0x00111D78
		private void method_6(string string_54, int int_149 = 0, bool bool_20 = false, int[] int_150 = null)
		{
			try
			{
				FormTip formTip = new FormTip();
				formTip.string_0 = string_54;
				formTip.bool_1 = !bool_20;
				bool flag = int_150 == null || int_150.Length != 4;
				if (flag)
				{
					int_150 = new int[]
					{
						base.Left,
						base.Top,
						base.Width,
						base.Height
					};
				}
				formTip.int_0 = int_150[0];
				formTip.int_1 = int_150[1];
				formTip.int_2 = int_150[2];
				formTip.int_3 = int_150[3];
				formTip.int_4 = int_149;
				formTip.Show();
			}
			catch
			{
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00113C30 File Offset: 0x00111E30
		private void timer_0_Tick(object sender, EventArgs e)
		{
			bool flag = this.bool_14;
			if (!flag)
			{
				this.bool_14 = true;
				try
				{
					bool flag2 = Class12.bool_0 || Form1.bool_11;
					if (flag2)
					{
						Class12.bool_0 = true;
						base.Close();
						return;
					}
					bool flag3 = Class86.int_0 < 0 || DateTime.Now.Ticks - this.long_2 > 1800000000L;
					if (flag3)
					{
						this.long_2 = DateTime.Now.Ticks;
						bool flag4 = Form1.int_69 == 0;
						if (flag4)
						{
							Class86.int_0 = (int)Class48.smethod_1("volam.zing.vn");
						}
						else
						{
							Class86.int_0 = Form1.int_70 + 1;
						}
						bool flag5 = Class86.int_0 >= 200;
						if (flag5)
						{
							bool flag6 = Class86.int_0 > 1500;
							if (flag6)
							{
								Class86.int_0 = 1500;
							}
						}
						else
						{
							Class86.int_0 = 200;
						}
					}
					bool flag7 = FormDame.int_8 > 0 && FormDame.int_6 != FormDame.int_7;
					if (flag7)
					{
						FormDame.int_6 = FormDame.int_7;
						this.checkBoxDameMacdinh.Checked = (FormDame.int_6 > 0);
						bool flag8 = !Class22.smethod_52(Class76.gstruct49_0.process_0);
						if (flag8)
						{
							DateTime now = DateTime.Now;
							string str = string.Concat(new string[]
							{
								now.Hour.ToString(),
								":",
								now.Minute.ToString(),
								":",
								now.Second.ToString(),
								" ",
								now.Millisecond.ToString()
							});
							string text = "<color=pink>" + Form1.string_16[FormDame.int_6] + "<color=green> Dame kÕt hîp| " + str;
							bool flag9 = Form1.int_120 != 0;
							if (flag9)
							{
								Class70.smethod_52(Class76.gstruct49_0, text, 1);
							}
							else
							{
								Class70.smethod_55(Class76.gstruct49_0, text, null);
							}
						}
					}
					bool flag10 = !Form1.bool_9;
					if (flag10)
					{
						long num = Class12.smethod_28(Form1.long_1);
						bool flag11 = num <= 3000L;
						if (flag11)
						{
							bool flag12 = num > 1200L;
							if (flag12)
							{
								Form1.bool_9 = true;
							}
						}
						else
						{
							Form1.long_1 = Class12.smethod_27();
						}
					}
					bool flag13 = TryNewVersion.int_0 == 2;
					if (flag13)
					{
						base.Close();
						return;
					}
					bool flag14 = Class76.bool_0 || this.int_132 != Form1.int_63;
					if (flag14)
					{
						this.int_132 = Form1.int_63;
						GClass0.smethod_1();
						bool flag15 = Form1.int_63 > 0;
						if (flag15)
						{
							Thread.Sleep(300);
							GClass0.smethod_0();
						}
						Class76.bool_0 = false;
					}
					bool flag16 = Form1.bool_3;
					if (flag16)
					{
						Form1.bool_3 = false;
						Class7.uint_1 = Class7.smethod_2(Class7.string_4);
						Class7.uint_0 = Class7.smethod_2(Class7.string_3);
						Class7.smethod_1(Class7.string_4, Class7.string_0);
						Class7.smethod_1(Class7.string_3, Class7.string_1);
						Class7.smethod_1(Class7.string_5, Class7.string_2);
					}
					this.method_7();
				}
				catch
				{
				}
				this.bool_14 = false;
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00113FA8 File Offset: 0x001121A8
		private void method_7()
		{
			bool flag = FormTuychon.int_2 > 1;
			if (flag)
			{
				FormTuychon.int_2 = 0;
				bool flag2 = Form1.int_38 > 0;
				if (flag2)
				{
					this.checkBoxChetnamIm.ForeColor = Color.DarkRed;
				}
				else
				{
					this.checkBoxChetnamIm.ForeColor = Color.Black;
				}
			}
			bool flag3 = FormMenuClick.bool_1;
			if (flag3)
			{
				bool flag4 = !(FormMenuClick.string_0 == Form1.string_38);
				if (flag4)
				{
					bool flag5 = !(FormMenuClick.string_0 == Form1.string_39);
					if (flag5)
					{
						bool flag6 = !(FormMenuClick.string_0 == FormLocdoTest.string_1);
						if (flag6)
						{
							bool flag7 = FormMenuClick.string_0.IndexOf("PID:") == 0;
							if (flag7)
							{
								FormMenuClick.bool_1 = false;
								int num = Class12.smethod_11(FormMenuClick.string_0.Split(new char[]
								{
									':'
								})[1]);
								bool flag8 = Form1.gstruct49_0 != null;
								if (flag8)
								{
									for (int i = 0; i < Form1.gstruct49_0.Length; i++)
									{
										bool flag9 = Form1.gstruct49_0[i].int_136 == num;
										if (flag9)
										{
											Form1.gstruct49_0[i].int_9 = FormMenuClick.smethod_0(null);
											Class53.smethod_13(Form1.gstruct49_0[i], null);
											break;
										}
									}
								}
								this.textBoxClickNPCMenu.Text = Class12.smethod_68(FormMenuClick.int_2, ',');
							}
						}
						else
						{
							FormMenuClick.bool_1 = false;
							FormLocdoTest.int_13 = FormMenuClick.smethod_0(FormLocdoTest.string_1);
							this.textBoxMenuTest.Text = Class12.smethod_68(FormLocdoTest.int_13, ',');
						}
					}
					else
					{
						FormMenuClick.bool_1 = false;
						Form1.int_126 = FormMenuClick.smethod_0(Form1.string_39);
						this.textBoxClickMenuTS.Text = Class12.smethod_68(Form1.int_126, ',');
					}
				}
				else
				{
					FormMenuClick.bool_1 = false;
					Form1.int_125 = FormMenuClick.smethod_0(Form1.string_38);
					this.textBoxMuaMienphiMenu.Text = Class12.smethod_68(Form1.int_125, ',');
				}
			}
			bool flag10 = !FormTip.bool_0;
			if (flag10)
			{
				bool flag11 = !this.bool_13;
				if (flag11)
				{
					this.bool_13 = true;
					string text = Class62.smethod_6("UpdateNew", 0, "");
					bool flag12 = Class12.smethod_11(text) != Form1.string_7.Length && Form1.string_7 != null && Form1.string_7 != string.Empty;
					if (flag12)
					{
						new FormTip
						{
							string_0 = Form1.string_7,
							string_1 = "PHIEN BAN MOI"
						}.Show();
					}
				}
				else
				{
					bool flag13 = !Form1.bool_15 && GClass1.string_2 != null && GClass1.string_2 != string.Empty;
					if (flag13)
					{
						Form1.bool_15 = true;
						string text2 = "LuuY";
						bool flag14 = Class62.smethod_6(text2, 0, "") != GClass1.string_2;
						if (flag14)
						{
							new FormTip
							{
								string_0 = GClass1.string_2,
								string_2 = text2,
								string_1 = "LUU Y"
							}.Show();
						}
					}
				}
			}
			bool flag15 = Form1.int_139 != Form1.int_7 || Form1.int_138 != Form1.int_6;
			if (flag15)
			{
				Form1.int_138 = Form1.int_6;
				Form1.int_139 = Form1.int_7;
				bool flag16 = Form1.int_7 > 0 || Form1.int_6 > 0;
				this.richTextBoxChedoMayphu.Visible = flag16;
				bool flag17 = !flag16;
				if (flag17)
				{
					this.checkBoxDenToadoUser.Enabled = !flag16;
					this.textBoxToadoDen.Enabled = !flag16;
					this.checkBoxDenToadoLeave.Enabled = !flag16;
					this.checkBoxDenToadoALL.Enabled = !flag16;
					Form1.bool_16 = false;
				}
			}
			bool flag18 = FormMayphu.bool_1 && Form1.bool_16 != FormMayphu.bool_1 && (Form1.int_7 > 0 || Form1.int_6 > 0);
			if (flag18)
			{
				Form1.bool_16 = FormMayphu.bool_1;
				bool flag19 = false;
				this.checkBoxDenToadoUser.Enabled = !flag19;
				this.textBoxToadoDen.Enabled = !flag19;
				this.checkBoxDenToadoLeave.Enabled = !flag19;
				this.checkBoxDenToadoALL.Enabled = !flag19;
			}
			bool flag20 = 0 <= Form1.int_0 && this.int_133 != Form1.int_0 && Form1.listwebdomain != null && Form1.int_0 < Form1.listwebdomain.Count;
			if (flag20)
			{
				this.int_133 = Form1.int_0;
				bool flag21 = Form1.string_3 != Form1.listwebdomain[Form1.int_0][0];
				if (flag21)
				{
					Form1.string_3 = Form1.listwebdomain[Form1.int_0][0];
					this.comboBoxGameOfWeb.Text = Form1.string_3;
					Class62.smethod_10(Class53.string_3, "TenWeb", Form1.string_3, "", 0);
				}
				bool flag22 = Form1.listwebdomain[Form1.int_0][4] != null;
				if (flag22)
				{
					int num2 = Form1.listwebdomain[Form1.int_0][4].IndexOf("/");
					bool flag23 = num2 > 0;
					if (flag23)
					{
						Class97.string_1 = Form1.listwebdomain[Form1.int_0][4].Substring(num2 + 1);
					}
				}
				this.method_15(Form1.string_3, new string[]
				{
					"vltkmienphi.net",
					"volampk.net"
				});
				this.method_16();
				bool flag24 = Form1.string_6 != null;
				if (flag24)
				{
					for (int j = 0; j < Form1.string_6.Length; j++)
					{
						string a = Form1.string_6[j].ToLower();
						string[] array = Form1.string_3.ToLower().Split(new char[]
						{
							'-',
							'|'
						});
						for (int k = 0; k < array.Length; k++)
						{
							bool flag25 = a == array[k].Trim();
							if (flag25)
							{
								Form1.bool_11 = !Form1.bool_10;
								break;
							}
						}
					}
				}
			}
			bool flag26 = base.WindowState == FormWindowState.Minimized && !this.notifyIcon_0.Visible && Form1.int_127 <= 0;
			if (flag26)
			{
				this.notifyIcon_0.Visible = true;
				base.Hide();
			}
			bool flag27 = !FormAntivirus.bool_0 && !FormAntivirus.bool_1 && FormAntivirus.gstruct53_0 != null && FormAntivirus.gstruct53_0.Length != 0;
			if (flag27)
			{
				try
				{
					FormAntivirus formAntivirus = new FormAntivirus();
					formAntivirus.Show();
				}
				catch
				{
				}
			}
			bool flag28 = Form1.int_142 == 1;
			if (flag28)
			{
				Form1.int_142 = 2;
				this.buttonSuadoTaicho.Enabled = false;
				new Thread(new ThreadStart(this.method_14)).Start();
			}
			else
			{
				bool flag29 = Form1.int_142 > 2;
				if (flag29)
				{
					Form1.int_142 = 0;
					this.buttonSuadoTaicho.Enabled = true;
				}
			}
			bool flag30 = FormXaphuCT.int_0 == -2;
			if (flag30)
			{
				FormXaphuCT.int_0 = 0;
				this.method_5();
			}
			bool flag31 = Class71.string_0 != null && Class71.string_0.Length > 1;
			if (flag31)
			{
				this.textBoxMapNameVST.Text = Class10.smethod_1(Class71.string_0[0], 1, false);
				this.textBoxToadoVST.Text = Class71.string_0[1];
				Class71.string_0 = null;
			}
			bool flag32 = Class12.string_16 != null && Class12.string_16.Length != 0;
			if (flag32)
			{
				bool flag33 = Class12.string_16[0] == null || Class12.string_16[0] == string.Empty;
				if (flag33)
				{
					Class12.smethod_30(ref Class12.string_16, Class12.string_16[0], false);
				}
				else
				{
					string text3 = Class12.string_16[0].Replace("|", Class53.string_7);
					bool flag34 = Class12.smethod_1(text3, "MESS:") == 0;
					if (flag34)
					{
						Class12.smethod_30(ref Class12.string_16, Class12.string_16[0], false);
						text3 = text3.Replace("MESS:", "");
						MessageBox.Show(text3, string.Empty, MessageBoxButtons.OK);
					}
					else
					{
						bool flag35 = Class12.smethod_1(text3, "FORM:") == 0;
						if (flag35)
						{
							bool flag36 = !FormTip.bool_0;
							if (flag36)
							{
								Class12.smethod_30(ref Class12.string_16, Class12.string_16[0], false);
								text3 = text3.Replace("FORM:", "");
								FormTip.smethod_0(Form1.string_1, text3, 60000, 360, 180, false, base.Left, base.Top, false, false, false);
							}
						}
						else
						{
							Class12.smethod_30(ref Class12.string_16, Class12.string_16[0], false);
							this.method_2(text3);
						}
					}
				}
			}
			bool flag37 = !GClass1.bool_0 && !Form1.bool_1;
			if (!flag37)
			{
				long num3 = Class12.smethod_28(Form1.long_3);
				bool flag38 = Class24.gstruct14_0 != null && num3 > Form1.long_4;
				if (flag38)
				{
					Form1.long_4 = (long)this.method_12();
					Form1.long_3 = Class12.smethod_27();
				}
				bool flag39 = FormLogin.gstruct0_0 != null && FormLogin.gstruct0_0.Length != 0;
				if (flag39)
				{
					bool flag40 = Form1.int_134 < 0 || FormLogin.gstruct0_0.Length <= Form1.int_134;
					if (flag40)
					{
						Form1.int_134 = 0;
					}
					GStruct0 gstruct = FormLogin.gstruct0_0[Form1.int_134];
					bool flag41 = gstruct.int_1 != 0 && !Class22.smethod_52(gstruct.process_0);
					if (flag41)
					{
						bool flag42 = Class49.smethod_31(gstruct) > 0 && gstruct.int_0 <= 0;
						if (flag42)
						{
							FormLogin.gstruct0_0[Form1.int_134].int_0 = 1;
						}
					}
					else
					{
						bool flag43 = gstruct.int_1 > 0;
						if (flag43)
						{
							FormLogin.gstruct0_0[Form1.int_134].int_1 = 0;
						}
						bool flag44 = FormLogin.int_5 > 0;
						if (flag44)
						{
							bool flag45 = gstruct.int_0 > 0;
							if (flag45)
							{
								string str = gstruct.string_0;
								bool flag46 = gstruct.string_4 != null && gstruct.string_4 != string.Empty;
								if (flag46)
								{
									str = Class10.smethod_1(gstruct.string_4, 1, false);
								}
								this.method_2("[" + str + "] sẽ đăng nhập lại trong vài giây nữa...");
								Class12.smethod_37(ref Class46.int_0, Form1.int_134);
							}
						}
						else
						{
							bool flag47 = gstruct.int_0 > 0;
							if (flag47)
							{
								FormLogin.gstruct0_0[Form1.int_134].int_0 = 0;
							}
						}
					}
					Form1.int_134++;
				}
				bool flag48 = GClass1.int_1 == 1;
				if (flag48)
				{
					GClass1.int_1 = 0;
					this.buttonAdd.Visible = true;
					this.buttonAdd.Enabled = true;
					string[] array2 = GClass1.smethod_3();
					this.labelThongtinDK.Text = array2[0];
					this.textBoxHSD.Text = array2[1];
					bool flag49 = GClass1.int_3 == 2;
					if (flag49)
					{
						this.richTextBoxBHO.Text = GClass1.smethod_4();
					}
					bool flag50 = !Form1.CheckTenWeb && Form1.UseServerDomain;
					if (flag50)
					{
						bool flag51 = GClass1.LienMay == null || GClass1.LienMay == "True";
						if (flag51)
						{
							FormMayphu.bool_1 = false;
						}
						else
						{
							FormMayphu.bool_1 = true;
						}
						int num4 = -1;
						bool flag52 = GClass1.TenWeb == "All";
						if (flag52)
						{
							string a2 = Class62.smethod_6("TenWeb", 0, "khác");
							for (int l = 0; l < Form1.listwebdomain.Count; l++)
							{
								bool flag53 = a2 != string.Empty && a2 == Form1.listwebdomain[l][0];
								if (flag53)
								{
									Form1.string_3 = Form1.listwebdomain[l][0];
									Form1.int_0 = l;
									Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[Form1.int_0][3]);
								}
								bool flag54 = Form1.listwebdomain[l][0] == "khác";
								if (flag54)
								{
									num4 = l;
								}
								this.comboBoxGameOfWeb.Items.Add(Form1.listwebdomain[l][0]);
							}
							bool flag55 = Form1.int_0 < 0;
							if (flag55)
							{
								bool flag56 = Form1.string_5 != null;
								if (flag56)
								{
									for (int m = 0; m < Form1.string_5.GetLength(0); m++)
									{
										bool flag57 = !(a2 == Form1.string_5[m, 0]);
										if (!flag57)
										{
											for (int n = 0; n < Form1.listwebdomain.Count; n++)
											{
												bool flag58 = Form1.string_5[m, 2] == Form1.listwebdomain[n][2];
												if (flag58)
												{
													Form1.int_0 = n;
													Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[n][3]);
													Class62.smethod_10(Class53.string_3, "TenWeb", Form1.listwebdomain[n][0], "", 0);
													break;
												}
											}
											break;
										}
									}
								}
								bool flag59 = Form1.int_0 < 0;
								if (flag59)
								{
									Form1.int_0 = 0;
									Form1.int_109 = 3;
									bool flag60 = num4 > 0;
									if (flag60)
									{
										Form1.int_0 = num4;
									}
								}
							}
							bool flag61 = 0 <= Form1.int_0 && Form1.listwebdomain[Form1.int_0][2] == "126";
							if (flag61)
							{
								Class42.bool_1 = true;
								int num5 = Class43.gstruct25_0.Length;
								for (int num6 = 0; num6 < num5; num6++)
								{
									bool flag62 = Class43.gstruct25_0[num6].int_0 == 78;
									if (flag62)
									{
										GStruct25 gstruct2 = Class43.gstruct25_0[num6];
										int[] array3 = new int[]
										{
											30,
											137,
											139,
											190,
											185,
											160,
											989
										};
										Array.Resize<GStruct25>(ref Class43.gstruct25_0, num5 + array3.Length);
										for (int num7 = 0; num7 < array3.Length; num7++)
										{
											Class43.gstruct25_0[num5 + num7] = gstruct2;
											Class43.gstruct25_0[num5 + num7].int_0 = array3[num7];
											Class43.gstruct25_0[num5 + num7].string_0 = null;
										}
										break;
									}
								}
							}
							this.comboBoxGameOfWeb.SelectedIndex = Form1.int_0;
							Form1.CheckTenWeb = true;
							this.buttonTuTimWeb.Enabled = true;
						}
						else
						{
							for (int num8 = 0; num8 < Form1.listwebdomain.Count; num8++)
							{
								bool flag63 = GClass1.TenWeb != string.Empty && GClass1.TenWeb == Form1.listwebdomain[num8][0];
								if (flag63)
								{
									Form1.int_0 = num8;
									Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[Form1.int_0][3]);
								}
								bool flag64 = Form1.listwebdomain[num8][0] == "khác";
								if (flag64)
								{
									num4 = num8;
								}
							}
							bool flag65 = Form1.int_0 < 0;
							if (flag65)
							{
								bool flag66 = Form1.string_5 != null;
								if (flag66)
								{
									for (int num9 = 0; num9 < Form1.string_5.GetLength(0); num9++)
									{
										bool flag67 = !(GClass1.TenWeb == Form1.string_5[num9, 0]);
										if (!flag67)
										{
											for (int num10 = 0; num10 < Form1.listwebdomain.Count; num10++)
											{
												bool flag68 = Form1.string_5[num9, 2] == Form1.listwebdomain[num10][2];
												if (flag68)
												{
													Form1.int_0 = num10;
													Form1.int_109 = Class12.smethod_11(Form1.listwebdomain[num10][3]);
													Class62.smethod_10(Class53.string_3, "TenWeb", Form1.listwebdomain[num10][0], "", 0);
													break;
												}
											}
											break;
										}
									}
								}
								bool flag69 = Form1.int_0 < 0;
								if (flag69)
								{
									Form1.int_0 = 0;
									Form1.int_109 = 3;
									bool flag70 = num4 > 0;
									if (flag70)
									{
										Form1.int_0 = num4;
									}
								}
							}
							bool flag71 = 0 <= Form1.int_0 && Form1.listwebdomain[Form1.int_0][2] == "126";
							if (flag71)
							{
								Class42.bool_1 = true;
								int num11 = Class43.gstruct25_0.Length;
								for (int num12 = 0; num12 < num11; num12++)
								{
									bool flag72 = Class43.gstruct25_0[num12].int_0 == 78;
									if (flag72)
									{
										GStruct25 gstruct3 = Class43.gstruct25_0[num12];
										int[] array4 = new int[]
										{
											30,
											137,
											139,
											190,
											185,
											160,
											989
										};
										Array.Resize<GStruct25>(ref Class43.gstruct25_0, num11 + array4.Length);
										for (int num13 = 0; num13 < array4.Length; num13++)
										{
											Class43.gstruct25_0[num11 + num13] = gstruct3;
											Class43.gstruct25_0[num11 + num13].int_0 = array4[num13];
											Class43.gstruct25_0[num11 + num13].string_0 = null;
										}
										break;
									}
								}
							}
							Form1.string_3 = GClass1.TenWeb;
							this.comboBoxGameOfWeb.Items.Add(Form1.string_3);
							this.comboBoxGameOfWeb.SelectedIndex = 0;
							Form1.CheckTenWeb = true;
							this.buttonTuTimWeb.Enabled = false;
						}
					}
				}
				bool flag73 = GClass1.string_0 != null && GClass1.string_0 != string.Empty && !FormTip.bool_0;
				if (flag73)
				{
					string[] array5 = Form1.string_0.Split(new char[]
					{
						'.'
					});
					bool flag74 = array5.Length < 2;
					if (flag74)
					{
						array5 = new string[]
						{
							Form1.string_0,
							"000"
						};
					}
					while (array5[0].Length < 3)
					{
						array5[0] = "0" + array5[0];
					}
					while (array5[1].Length < 3)
					{
						string[] array6;
						(array6 = array5)[1] = array6[1] + "0";
					}
					string[] array7 = GClass1.string_0.Split(new char[]
					{
						'.'
					});
					bool flag75 = array7.Length < 2;
					if (flag75)
					{
						array7 = new string[]
						{
							GClass1.string_0,
							"000"
						};
					}
					while (array7[0].Length < 3)
					{
						array7[0] = "0" + array7[0];
					}
					while (array7[1].Length < 3)
					{
						string[] array8;
						(array8 = array7)[1] = array8[1] + "0";
					}
					while (array5[0].Length != array7[0].Length)
					{
						bool flag76 = array5[0].Length < array7[0].Length;
						if (flag76)
						{
							array5[0] = "0" + array5[0];
						}
						else
						{
							array7[0] = "0" + array7[0];
						}
					}
					while (array5[1].Length != array7[1].Length)
					{
						bool flag77 = array5[1].Length >= array7[1].Length;
						if (flag77)
						{
							string[] array9;
							(array9 = array7)[1] = array9[1] + "0";
						}
						else
						{
							string[] array10;
							(array10 = array5)[1] = array10[1] + "0";
						}
					}
					Form1.int_2 = Class12.smethod_11(array5[0]) * 10000 + Class12.smethod_11(array5[1]);
					Form1.int_3 = Class12.smethod_11(array7[0]) * 10000 + Class12.smethod_11(array7[1]);
					bool flag78 = Form1.int_2 < Form1.int_3;
					if (flag78)
					{
						Form1.bool_0 = true;
						string text4 = string.Concat(new string[]
						{
							"ĐÃ CÓ BẢN CẬP NHẬT||Phiên bản hiện tại là ",
							Form1.string_1,
							", hiện đã có phiên bản mới hơn là ",
							Form1.string_1.Replace(Form1.string_0, GClass1.string_0),
							"||Bạn hãy vào tab Phụ trợ, bấm nút ",
							this.buttonCapnhat.Text,
							" để update lên phiên bản mới hơn này nhé !"
						});
						FormTip.smethod_0(Form1.string_1, text4, 45000, 280, 160, false, base.Left, base.Top, false, false, false);
					}
					GClass1.string_0 = null;
				}
				bool flag79 = GClass0.bool_0;
				if (flag79)
				{
					GClass0.bool_0 = false;
					int num14 = Class81.smethod_3(Form1.gstruct49_0, Class76.gstruct49_0.int_136);
					bool flag80 = FormMagic.int_1 > 0 && 0 <= num14 && Form1.gstruct49_0[num14].int_3 != null;
					if (flag80)
					{
						Form1.gstruct49_0[num14].int_119 = (int)(1 - Convert.ToByte(Form1.gstruct49_0[num14].int_119 > 0));
						Class70.smethod_52(Form1.gstruct49_0[num14], "<color=white>Cash bïa: <color=green>" + Form1.string_16[Form1.gstruct49_0[num14].int_119], 1);
					}
				}
				bool flag81 = GClass0.int_1 == Class27.int_6;
				if (flag81)
				{
					int num15 = Form1.int_145 + 1;
					bool flag82 = num15 > 2;
					if (flag82)
					{
						num15 = 0;
					}
					GClass0.int_1 = 0;
					this.method_21(num15);
				}
				else
				{
					bool flag83 = GClass0.int_1 == Class27.int_4;
					if (flag83)
					{
						bool flag84 = Class76.gstruct49_0.int_136 > 0;
						if (flag84)
						{
							bool @checked;
							Form1.int_30 = (int)Convert.ToByte(@checked = (Form1.int_30 <= 0));
							this.checkBoxTuve.Checked = @checked;
							this.bool_17 = false;
							new Thread(new ThreadStart(this.method_8)).Start();
						}
						GClass0.int_1 = 0;
					}
					else
					{
						bool flag85 = GClass0.int_1 != Class27.int_3;
						if (flag85)
						{
							bool flag86 = GClass0.int_1 == Class27.int_2;
							if (flag86)
							{
								GClass0.int_1 = 0;
								bool flag87 = Class76.gstruct49_0.int_136 > 0 && FormAchinh.int_0 > 0 && FormAchinh.string_0 != null && FormAchinh.string_0 != string.Empty;
								if (flag87)
								{
									bool flag88 = FormAchinh.int_1 > 0 && Form1.gstruct49_0 != null;
									if (flag88)
									{
										for (int num16 = 0; num16 < Form1.gstruct49_0.Length; num16++)
										{
											bool flag89 = FormAchinh.string_0 == Class10.smethod_1(Form1.gstruct49_0[num16].string_22, 1, false);
											if (flag89)
											{
												GStruct8[] array11 = Class22.smethod_62(Form1.gstruct49_0[num16].int_136, "WIN_CLASS:" + Class53.string_21, 0);
												bool flag90 = array11 != null && array11.Length != 0;
												if (flag90)
												{
													Form1.uint_1 = array11[0].uint_0;
													new Thread(new ThreadStart(this.method_10)).Start();
												}
											}
										}
										Form1.uint_0 = Class44.gstruct33_0.uint_0;
										new Thread(new ThreadStart(this.method_9)).Start();
									}
									string text5 = Form1.string_17;
									Form1.string_17 = FormAchinh.string_0;
									this.comboBoxAccChinh.Items.Add(Form1.string_17);
									this.comboBoxAccChinh.Text = Form1.string_17;
									FormAchinh.string_0 = text5;
									Class62.smethod_10(Class53.string_3, "AccChinhNameA", Class12.smethod_16(Form1.string_17), "", 0);
									Class62.smethod_10(Class53.string_3, "AccChinh2", Class12.smethod_16(FormAchinh.string_0), "", 0);
								}
							}
						}
						else
						{
							bool flag91 = Class76.gstruct49_0.int_136 > 0;
							if (flag91)
							{
								bool checked2;
								Form1.int_31 = (int)Convert.ToByte(checked2 = (Form1.int_31 <= 0));
								this.checkBoxDanhquai.Checked = checked2;
								this.bool_17 = true;
								new Thread(new ThreadStart(this.method_8)).Start();
							}
							GClass0.int_1 = 0;
						}
					}
				}
				bool flag92 = Form1.int_140 <= 0;
				if (flag92)
				{
					Form1.int_140 = 1;
					bool flag93 = Form1.int_64 > 0;
					if (flag93)
					{
						new Thread(new ThreadStart(TryNewVersion.smethod_4)).Start();
					}
				}
				bool flag94 = Form1.int_144 > 1;
				if (flag94)
				{
					Form1.int_144 = 0;
					this.buttonGiamCPUAll.Enabled = true;
				}
				bool flag95 = FormChayBoss.bool_1;
				if (flag95)
				{
					FormChayBoss.bool_1 = false;
					this.comboBoxNoiBoss.Items.Clear();
					for (int num17 = 0; num17 < FormChayBoss.string_2.GetLength(0); num17++)
					{
						this.comboBoxNoiBoss.Items.Add(FormChayBoss.string_2[num17, 0]);
					}
					this.comboBoxNoiBoss.Text = FormChayBoss.string_2[0, 0];
					bool flag96 = Form1.gstruct49_0 != null;
					if (flag96)
					{
						for (int num18 = 0; num18 < Form1.gstruct49_0.Length; num18++)
						{
							Form1.gstruct49_0[num18].bool_1 = false;
							Form1.gstruct49_0[num18].int_0 = 0;
						}
					}
					this.checkBoxTuChayBoss.Checked = false;
				}
				bool flag97 = FormChayBoss.string_0 != null;
				if (flag97)
				{
					this.checkBoxTuChayBoss.Checked = false;
					this.comboBoxNoiBoss.Text = FormChayBoss.string_0;
					FormChayBoss.string_0 = null;
				}
				bool flag98 = Form1.int_124 != FormDame.int_9;
				if (flag98)
				{
					Form1.int_124 = FormDame.int_9;
					this.labelKieudame.Text = "( " + (FormDame.int_9 + 1).ToString() + " )";
				}
				bool flag99 = Form1.int_122 != null && Form1.int_122.Length != 0;
				if (flag99)
				{
					int num19 = Form1.int_122[0];
					int num20 = Class81.smethod_10(this.listView1, num19);
					Class12.smethod_38(ref Form1.int_122, num19);
					bool flag100 = 0 <= num20;
					if (flag100)
					{
						this.listView1.Items[num20].Checked = false;
					}
				}
				while (ThemXoaDanhsach.int_0 != null && ThemXoaDanhsach.int_0.Length != 0)
				{
					int num21 = ThemXoaDanhsach.int_0[0];
					Class12.smethod_38(ref ThemXoaDanhsach.int_0, num21);
					GStruct49 gstruct4 = Class53.smethod_8(num21);
					bool flag101 = gstruct4.int_136 != 0;
					if (flag101)
					{
						Class12.smethod_29(ref Form1.string_22, gstruct4.int_136.ToString() + "==" + gstruct4.string_22);
						Class12.smethod_30(ref Form1.string_21, gstruct4.string_22, false);
						string text6 = this.comboBoxAccChinh.Text;
						bool flag102 = text6 != string.Empty && text6 != null && Class10.smethod_1(gstruct4.string_22, 1, false) == text6;
						if (flag102)
						{
							Form1.int_52 = gstruct4.int_136;
						}
						bool flag103 = FormDoiMauBang.gstruct2_0.string_0 != null && FormDoiMauBang.gstruct2_0.string_0 != string.Empty && Class10.smethod_1(gstruct4.string_22, 1, false) == FormDoiMauBang.gstruct2_0.string_0;
						if (flag103)
						{
							FormDoiMauBang.gstruct2_0.gstruct49_0 = gstruct4;
							FormDoiMauBang.gstruct2_0.uint_0 = 0U;
						}
						Class81.smethod_5(this.listView1, gstruct4);
						Class81.smethod_0(ref Form1.gstruct49_0, gstruct4);
						bool flag104 = gstruct4.int_2 > 0;
						if (flag104)
						{
							FormMayphu.int_0 = gstruct4.int_136;
							new Thread(new ThreadStart(FormMayphu.smethod_3)).Start();
							Thread.Sleep(150);
						}
						Class53.smethod_11(num21);
					}
				}
				while (ThemXoaDanhsach.int_1 != null && ThemXoaDanhsach.int_1.Length != 0)
				{
					int num22 = ThemXoaDanhsach.int_1[0];
					bool flag105 = num22 == Class44.gstruct33_0.int_0 || num22 == Form1.int_52;
					if (flag105)
					{
						Form1.int_52 = 0;
						Class44.gstruct33_0.int_0 = 0;
					}
					bool flag106 = num22 == FormDoiMauBang.gstruct2_0.gstruct49_0.int_136;
					if (flag106)
					{
						FormDoiMauBang.gstruct2_0.gstruct49_0 = new GStruct49
						{
							int_136 = 0
						};
						FormDoiMauBang.gstruct2_0.uint_0 = 0U;
					}
					Class12.smethod_38(ref ThemXoaDanhsach.int_1, num22);
					int num23 = Class81.smethod_3(Form1.gstruct49_0, num22);
					bool flag107 = num23 >= 0;
					if (flag107)
					{
						GStruct49 gstruct5 = Form1.gstruct49_0[num23];
						Class12.smethod_30(ref Form1.string_22, gstruct5.int_136.ToString() + "==" + gstruct5.string_22, false);
						Class22.smethod_32(gstruct5.int_137);
						Class81.smethod_1(ref Form1.gstruct49_0, gstruct5);
					}
					int num24 = Class81.smethod_10(this.listView1, num22);
					bool flag108 = num24 >= 0;
					if (flag108)
					{
						this.listView1.Items.RemoveAt(num24);
					}
				}
				bool flag109 = this.listView1.Items == null || this.listView1.Items.Count <= 0;
				if (flag109)
				{
					Form1.int_136 = 0;
				}
				else
				{
					int num25 = 0;
					int num26;
					GStruct49 gstruct6;
					for (;;)
					{
						bool flag110 = this.listView1.Items.Count > Form1.int_131;
						if (!flag110)
						{
							goto IL_2723;
						}
						num26 = Class81.smethod_2(this.listView1, Form1.int_131, Form1.gstruct49_0);
						bool flag111 = num26 >= 0;
						if (flag111)
						{
							gstruct6 = Form1.gstruct49_0[num26];
							bool flag112 = Class76.int_4 > 0 && Class76.int_4 <= num26;
							if (flag112)
							{
								bool flag113 = gstruct6.bool_25 || gstruct6.long_1 == 0L;
								if (flag113)
								{
									this.method_2(Class10.smethod_1(gstruct6.string_22, 1, false) + Class12.smethod_15("OiBRdcOhIHPhu5EgbMaw4bujbmcgY2hvIHBow6lwIGPhu6dhIGFkZ2FtZQ=="));
									Form1.gstruct49_0[num26].bool_25 = false;
									this.listView1.Items[Form1.int_131].Checked = false;
									bool flag114 = gstruct6.long_1 == 0L;
									if (flag114)
									{
										Form1.gstruct49_0[num26].long_1 = Class12.smethod_27();
									}
								}
								else
								{
									bool flag115 = Class12.smethod_28(gstruct6.long_1) > 30000L;
									if (flag115)
									{
										break;
									}
								}
							}
							else
							{
								bool flag116 = !gstruct6.bool_40 && Class45.int_1 <= 0;
								if (flag116)
								{
									Class45.int_1 = gstruct6.int_136;
									new Thread(new ThreadStart(Class45.smethod_23)).Start();
								}
								bool flag117 = !gstruct6.bool_41 && Class45.int_0 <= 0;
								if (flag117)
								{
									Class45.int_0 = gstruct6.int_136;
									new Thread(new ThreadStart(Class45.smethod_19)).Start();
								}
								bool flag118 = !gstruct6.bool_48 && gstruct6.int_69[0] > 0 && FormRaovat.int_1 <= 0;
								if (flag118)
								{
									FormRaovat.int_1 = gstruct6.int_136;
									new Thread(new ThreadStart(FormRaovat.smethod_0)).Start();
								}
								bool flag119 = !gstruct6.bool_49 && gstruct6.bool_17 && Class26.int_1 <= 0;
								if (flag119)
								{
									Class26.int_1 = gstruct6.int_136;
									new Thread(new ThreadStart(Class26.smethod_13)).Start();
								}
								bool flag120 = Class22.smethod_52(gstruct6.process_0);
								if (flag120)
								{
									goto Block_191;
								}
								string text7 = "Khác";
								int num27 = Class36.smethod_31(gstruct6);
								int num28 = Class36.smethod_28(gstruct6);
								bool flag121 = num27 == 0 || num27 == 10 || num27 == 21;
								bool flag122 = gstruct6.uint_50 == 0U || gstruct6.uint_83 == 0U;
								if (flag122)
								{
									text7 = "HƯ";
									num28 = 12345;
									bool flag123 = Form1.gstruct49_0 != null && Form1.gstruct49_0.Length > 1;
									if (flag123)
									{
										Class22.smethod_53(gstruct6.process_0);
										goto IL_272B;
									}
									bool flag124 = !FormTip.bool_0;
									if (flag124)
									{
										bool flag125 = Form1.int_136 == 0;
										if (flag125)
										{
											string string_ = string.Concat(new string[]
											{
												"[",
												Class10.smethod_1(gstruct6.string_22, 1, false),
												"] đang chạy trên game hư không dùng được.||Cách xử lý làm theo thứ tự sau:|1. Mở 1 game khác, để đó.|2. Thoát [",
												Class10.smethod_1(gstruct6.string_22, 1, false),
												"] và thoát game hư ở trên.|3. Log lại ac ở game vừa mới mở.|4. Xong, xài bình thường."
											});
											this.method_2(string_);
											FormTip.smethod_0(Form1.string_1, string_, 600000, 320, 160, false, base.Left, base.Top, false, false, false);
										}
										Form1.int_136 = 1;
									}
								}
								else
								{
									bool flag126 = num28 <= 0;
									if (flag126)
									{
										text7 = "Out";
									}
									else
									{
										bool flag127 = num27 < Class53.string_23.Length;
										if (flag127)
										{
											text7 = Class53.string_23[num27];
										}
									}
								}
								bool flag128 = this.listView1.Items[Form1.int_131].SubItems[1].Text != text7;
								if (flag128)
								{
									this.listView1.Items[Form1.int_131].SubItems[1].Text = text7;
								}
								int num29 = Class37.smethod_0(gstruct6);
								text7 = ((num28 == 12345) ? "Log ac thứ 2 rồi thóat game và ac này." : ((Class56.smethod_0(num29) == null || Class36.smethod_27(gstruct6) > 0) ? Class10.smethod_1(Class37.smethod_2(gstruct6), 1, false) : "Hậu doanh"));
								bool flag129 = this.listView1.Items[Form1.int_131].SubItems[2].Text != text7;
								if (flag129)
								{
									this.listView1.Items[Form1.int_131].SubItems[2].Text = text7;
								}
								Color color = Color.Black;
								bool flag130 = num28 > 0;
								if (flag130)
								{
									bool flag131 = num28 != 12345;
									if (flag131)
									{
										bool flag132 = !flag121;
										if (flag132)
										{
											bool flag133 = gstruct6.int_2 > 0;
											if (flag133)
											{
												color = Color.DarkCyan;
											}
											else
											{
												bool flag134 = !gstruct6.bool_54;
												if (flag134)
												{
													bool flag135 = gstruct6.int_136 == Class44.gstruct33_0.int_0;
													if (flag135)
													{
														color = Color.Blue;
													}
													else
													{
														bool flag136 = gstruct6.int_136 == Class76.gstruct49_0.int_136;
														if (flag136)
														{
															color = Color.DarkViolet;
														}
													}
												}
												else
												{
													color = Color.DarkGoldenrod;
												}
											}
										}
										else
										{
											color = Color.Purple;
										}
									}
									else
									{
										color = Color.DarkGray;
									}
								}
								else
								{
									color = Color.RoyalBlue;
								}
								bool flag137 = this.listView1.Items[Form1.int_131].ForeColor != color;
								if (flag137)
								{
									this.listView1.Items[Form1.int_131].ForeColor = color;
								}
								bool flag138 = Form1.int_131 == Form1.int_77 && Form1.bool_1;
								if (flag138)
								{
									uint[] array12 = Class36.smethod_30(gstruct6);
									bool flag139 = array12 != null;
									if (flag139)
									{
										this.textBoxRealPosXY.Text = array12[0].ToString() + "," + array12[1].ToString();
										this.textBoxScrPosXY.Text = (array12[0] / 256U).ToString() + "," + (array12[1] / 512U).ToString();
									}
									uint num30 = Class83.smethod_6(gstruct6);
									this.textBoxRealMouseXY.Text = num30.ToString();
									uint num31 = num30 >> 16;
									uint num32 = num30 - (num31 << 16);
									this.textBoxScrMouseXY.Text = num32.ToString() + "," + num31.ToString();
									string text8 = Class37.smethod_0(gstruct6).ToString();
									bool flag140 = this.textBoxMapId.Text != text8;
									if (flag140)
									{
										this.textBoxMapId.Text = text8;
									}
								}
								string text9 = "-1";
								bool flag141 = Class44.gstruct33_0.int_0 > 0 && num29 == Class44.gstruct33_0.int_4;
								if (flag141)
								{
									bool flag142 = Class44.gstruct33_0.int_0 != gstruct6.int_136;
									if (flag142)
									{
										uint[] array13 = Class36.smethod_30(gstruct6);
										bool flag143 = array13 != null;
										if (flag143)
										{
											long num33 = Class60.smethod_18(array13, Class44.gstruct33_0.uint_4);
											text9 = ((int)Math.Sqrt((double)num33)).ToString();
										}
									}
									else
									{
										text9 = "0";
									}
								}
								bool flag144 = this.listView1.Items[Form1.int_131].SubItems[3].Text != text9;
								if (flag144)
								{
									this.listView1.Items[Form1.int_131].SubItems[3].Text = text9;
								}
							}
							IL_272B:
							Form1.int_131++;
							num25++;
							if (num25 >= 5)
							{
								goto IL_274D;
							}
							continue;
							goto IL_272B;
						}
						goto IL_2705;
					}
					Class22.smethod_53(Form1.gstruct49_0[num26].process_0);
					Class81.smethod_1(ref Form1.gstruct49_0, Form1.gstruct49_0[num26]);
					Class46.bool_2 = true;
					goto IL_274D;
					Block_191:
					string text10 = gstruct6.int_136.ToString() + "==";
					bool flag145 = Form1.string_22 != null;
					if (flag145)
					{
						for (int num34 = 0; num34 < Form1.string_22.Length; num34++)
						{
							bool flag146 = Class12.smethod_1(Form1.string_22[num34], text10) == 0;
							if (flag146)
							{
								Class12.smethod_29(ref Form1.string_21, Form1.string_22[num34].Replace(text10, ""));
								Class12.smethod_30(ref Form1.string_22, Form1.string_22[num34], false);
								break;
							}
						}
					}
					Class81.smethod_1(ref Form1.gstruct49_0, gstruct6);
					this.listView1.Items.RemoveAt(Form1.int_131);
					goto IL_274D;
					IL_2705:
					this.listView1.Items.RemoveAt(Form1.int_131);
					Form1.int_131 = 0;
					goto IL_274D;
					IL_2723:
					Form1.int_131 = 0;
					IL_274D:;
				}
				bool flag147 = Form1.bool_12;
				if (flag147)
				{
					while (Form1.int_130 < this.listView1.Items.Count)
					{
						bool checked3 = this.listView1.Items[Form1.int_130].Checked;
						if (!checked3)
						{
							this.listView1.Items[Form1.int_130].Checked = true;
							break;
						}
						Form1.int_130++;
					}
					bool flag148 = this.listView1.Items.Count <= Form1.int_130;
					if (flag148)
					{
						Form1.bool_12 = false;
					}
				}
				bool flag149 = Form1.int_123 != null && Form1.int_123.Length != 0 && this.listView1.Items != null && Class12.smethod_28(Form1.long_0) > 4000L;
				if (flag149)
				{
					int num35 = Form1.int_123[0];
					try
					{
						for (int num36 = 0; num36 < this.listView1.Items.Count; num36++)
						{
							int count = this.listView1.Items[num36].SubItems.Count;
							int num37 = Class12.smethod_11(this.listView1.Items[num36].SubItems[count - 1].Text);
							bool flag150 = num35 == num37;
							if (flag150)
							{
								bool flag151 = !this.listView1.Items[num36].Checked;
								if (flag151)
								{
									this.listView1.Items[num36].Checked = true;
								}
								Form1.long_0 = Class12.smethod_27();
								break;
							}
						}
					}
					catch
					{
					}
					Class12.smethod_38(ref Form1.int_123, num35);
				}
				bool flag152 = !GClass1.bool_0;
				if (!flag152)
				{
					Form1.int_141++;
					bool flag153 = Form1.int_141 > 100;
					if (flag153)
					{
						int num38 = 0;
						byte[] array14 = new byte[1];
						Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_4 * 4U, array14, 1, ref num38);
						int num39 = (int)array14[0];
						Class22.ReadProcessMemory(Class12.int_1, Class12.uint_1 + Class53.uint_5 * 4U, array14, 1, ref num38);
						int num40 = (int)array14[0];
						bool flag154 = num39 > 0;
						if (flag154)
						{
							this.buttonAdd.BackColor = Color.Red;
						}
						else
						{
							bool flag155 = num40 == 0;
							if (flag155)
							{
								this.buttonAdd.BackColor = Color.DarkRed;
							}
						}
						Form1.int_141 = 0;
					}
				}
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00116A88 File Offset: 0x00114C88
		private void method_8()
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				string[] array = new string[]
				{
					"TAT",
					"BAT"
				};
				string[] array2 = new string[]
				{
					"<color=pink>",
					"<color=green>"
				};
				string text = null;
				bool flag2 = this.bool_17;
				string text2;
				if (flag2)
				{
					text2 = "®¸nh qu¸i ( F7) => " + array[Form1.int_31];
					text = "<color=yellow>§¸nh qu¸i. ( F7): " + array2[Form1.int_31] + array[Form1.int_31];
				}
				else
				{
					text2 = "®¸nh ng­êi ( F8) => " + array[Form1.int_30];
					text = "<color=white>§¸nh ng­êi ( F8): " + array2[Form1.int_30] + array[Form1.int_30];
				}
				Class26.string_0 = text2;
				Class26.long_0 = DateTime.Now.AddSeconds(6.0).Ticks;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					try
					{
						bool bool_ = Form1.gstruct49_0[i].bool_25;
						if (bool_)
						{
							Class36.smethod_10(Form1.gstruct49_0[i], 0U);
							int num = 0;
							while (Class26.int_0 > 0 && num < 20)
							{
								Thread.Sleep(10);
								num++;
							}
							Class70.smethod_52(Form1.gstruct49_0[i], text, 1);
							Class26.int_0 = Form1.gstruct49_0[i].int_137;
							Class26.uint_2 = Form1.gstruct49_0[i].uint_15;
							new Thread(new ThreadStart(Class26.smethod_6)).Start();
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00116C60 File Offset: 0x00114E60
		private void buttonAdd_Click(object sender, EventArgs e)
		{
			bool flag = GClass1.string_1 == null || GClass1.string_1 == string.Empty;
			if (flag)
			{
				this.method_2(Class12.smethod_15("S2jDtG5nIHjDoWMgxJHhu4tuaCDEkcaw4bujYyBwaGnDqm4gYuG6o24gYXV0byDEkWFuZyBz4butIGThu6VuZyBuw6puIGtow7RuZyB0aOG7gyB0aeG6v3AgdOG7pWMuLi4="));
			}
			else
			{
				bool flag2 = !Form1.bool_0 && Form1.int_3 <= Form1.int_2;
				if (flag2)
				{
					bool flag3 = !GClass1.bool_1;
					if (flag3)
					{
						bool flag4 = Class53.bool_0;
						if (flag4)
						{
							bool flag5 = Form1.int_63 > 0;
							if (flag5)
							{
								GClass0.smethod_1();
								GClass0.smethod_0();
							}
							bool flag6 = ThemXoaDanhsach.bool_0;
							if (flag6)
							{
								ThemXoaDanhsach.bool_0 = false;
							}
							else
							{
								try
								{
									new ThemXoaDanhsach
									{
										int_2 = base.Left,
										int_3 = base.Top,
										int_4 = base.Width,
										int_5 = base.Height
									}.Show();
								}
								catch
								{
								}
							}
						}
						else
						{
							Class12.string_16 = new string[]
							{
								"Data dữ liệu có lỗi."
							};
						}
					}
					else
					{
						this.buttonAdd.Visible = false;
						this.buttonAdd.Enabled = false;
					}
				}
				else
				{
					GClass1.string_0 = GClass1.string_1;
				}
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00116DB4 File Offset: 0x00114FB4
		private void buttonBrowseGame_Click(object sender, EventArgs e)
		{
			string text = Class53.string_8;
			string text2 = string.Empty;
			string text3 = Class53.smethod_0();
			bool flag = text3 == null || text3 == string.Empty;
			if (flag)
			{
				text3 = Class62.smethod_6("PathGame", 0, "");
			}
			bool flag2 = text3 != null && text3 != string.Empty;
			if (flag2)
			{
				string[] array = Class12.smethod_14(text3, '\\');
				text = array[0];
				text2 = array[1];
			}
			string text4 = "Game.exe";
			bool flag3 = Form1.listwebdomain != null && 0 <= Form1.int_0 && Form1.int_0 < Form1.listwebdomain.Count && Form1.listwebdomain[Form1.int_0][4] != null && Form1.listwebdomain[Form1.int_0][4] != string.Empty;
			if (flag3)
			{
				text4 = Form1.listwebdomain[Form1.int_0][4].Split(new char[]
				{
					'/'
				})[0];
			}
			string text5 = "*.exe|*.exe|Game.exe|Game.exe|Games.exe|Games.exe|vlbs.exe|vlbs.exe|Game.dat|Game.dat";
			bool flag4 = text4 != null;
			if (flag4)
			{
				text5 = string.Concat(new string[]
				{
					text4,
					"|",
					text4,
					"|",
					text5
				});
			}
			string text6 = Class53.smethod_26(text, text2, "*.exe", text5);
			bool flag5 = text6 != null && !(text6 == string.Empty);
			if (flag5)
			{
				string[] array2 = Class12.smethod_14(text6, '\\');
				Class53.string_18 = array2[0];
				Class53.string_19 = array2[1];
				Class22.smethod_71(text6, false);
				Class62.smethod_10(Class53.string_3, "PathGame", text6, "", 0);
				this.textBoxThuMuc.Text = text6;
				Class97.string_0 = text6;
			}
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00116F66 File Offset: 0x00115166
		private void buttonToShortcut_Click(object sender, EventArgs e)
		{
			Class22.smethod_74("AutoKeoXe");
			this.method_2("Đã tạo shortcut auto lên desktop.");
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00116F80 File Offset: 0x00115180
		private void buttonThumucAuto_Click(object sender, EventArgs e)
		{
			string environmentVariable = Environment.GetEnvironmentVariable(Class12.smethod_0(Class53.char_0));
			Class22.smethod_40(environmentVariable + "\\explorer.exe", Class53.string_8, Class53.string_8, 0, false, false);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00116FBC File Offset: 0x001151BC
		private void checkBoxPhimTat_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = Form1.bool_9;
			if (flag)
			{
				Form1.int_63 = (int)Convert.ToByte(this.checkBoxPhimTat.Checked);
				Class62.smethod_10(Class53.string_3, "flagPhimtat", Form1.int_63, "", 0);
			}
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0011700A File Offset: 0x0011520A
		private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
		{
			base.Show();
			base.WindowState = FormWindowState.Normal;
			this.notifyIcon_0.Visible = false;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0011702C File Offset: 0x0011522C
		private void buttonDangky_Click(object sender, EventArgs e)
		{
			string text = "Hãy chọn 1 ac trước đã rồi bấm nút!";
			bool flag = false;
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag2 = 0 <= num;
			if (flag2)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text2 = Class26.smethod_10(gstruct);
				string text3 = Class83.smethod_16(gstruct);
				int[] array = new int[]
				{
					gstruct.int_136
				};
				GStruct28[] array2 = Class48.smethod_0(array);
				string text4 = string.Empty;
				bool flag3 = array2 != null;
				if (flag3)
				{
					for (int i = 0; i < array2.Length; i++)
					{
						bool flag4 = gstruct.int_136 == array2[i].int_0 && array2[i].string_2 != null && array2[i].string_2 != string.Empty;
						if (flag4)
						{
							bool flag5 = text4 != string.Empty;
							if (flag5)
							{
								text4 += ",";
							}
							text4 += array2[i].string_2.Replace(" ", string.Empty);
						}
					}
				}
				text = string.Concat(new string[]
				{
					"Nhân vật: ",
					Class10.smethod_1(gstruct.string_22, 1, false),
					Class53.string_7,
					"Bang hội:|",
					text2,
					"|Tên server:|",
					text3,
					Class53.string_7,
					"IP:|",
					text4
				});
				flag = true;
			}
			FormTip.smethod_0("Thông tin đăng ký", text, 300000, 230, 140, false, -1, -1, flag, false, false);
			try
			{
				Clipboard.SetText("<3 " + this.richTextBoxBHO.Text);
			}
			catch
			{
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00117220 File Offset: 0x00115420
		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left && Form1.gstruct49_0 != null && Form1.gstruct49_0.Length != 0 && Form1.int_77 >= 0 && Form1.int_77 < this.listView1.Items.Count;
			if (flag)
			{
				Form1.uint_1 = Form1.gstruct49_0[Form1.int_77].uint_4;
				new Thread(new ThreadStart(this.method_10)).Start();
			}
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x001172A4 File Offset: 0x001154A4
		private void listView1_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_7 = false;
			bool flag = e.Button == MouseButtons.Right && Form1.gstruct49_0 != null && Form1.gstruct49_0.Length != 0 && Form1.int_77 >= 0 && Form1.int_77 < this.listView1.Items.Count;
			if (flag)
			{
				Form1.uint_0 = Form1.gstruct49_0[Form1.int_77].uint_4;
				new Thread(new ThreadStart(this.method_9)).Start();
			}
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00117330 File Offset: 0x00115530
		private void method_9()
		{
			uint num = Form1.uint_0;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_20);
				Thread.Sleep(100);
				Class22.ShowWindow(num, Class22.int_18);
			}
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00117370 File Offset: 0x00115570
		private void method_10()
		{
			uint num = Form1.uint_1;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_21);
				Class22.ShowWindow(num, Class22.int_19);
				Thread.Sleep(200);
				Class22.SetForegroundWindow(num);
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x001173B8 File Offset: 0x001155B8
		private void method_11()
		{
			uint num = Form1.uint_2;
			bool flag = num > 0U;
			if (flag)
			{
				Class22.ShowWindow(num, Class22.int_20);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x001173E0 File Offset: 0x001155E0
		private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			bool flag = this.bool_7;
			if (flag)
			{
				e.NewValue = e.CurrentValue;
			}
			else
			{
				int num = Class81.smethod_9(this.listView1, e.Index);
				bool flag2 = num != 0;
				if (flag2)
				{
					int num2 = Class81.smethod_3(Form1.gstruct49_0, num);
					bool flag3 = num2 >= 0;
					if (flag3)
					{
						bool flag4 = e.NewValue != CheckState.Unchecked && Class53.bool_1;
						if (flag4)
						{
							Form1.gstruct49_0[num2].bool_25 = true;
							Form1.gstruct49_0[num2].long_7 = Class12.smethod_27();
							Class12.smethod_37(ref Class75.int_1, Form1.gstruct49_0[num2].int_136);
						}
						else
						{
							Form1.gstruct49_0[num2].bool_25 = false;
							e.NewValue = CheckState.Unchecked;
						}
					}
					else
					{
						this.listView1.Items.RemoveAt(e.Index);
					}
				}
				else
				{
					this.listView1.Items.RemoveAt(e.Index);
				}
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x001174F0 File Offset: 0x001156F0
		private void checkBoxChatNham_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_66 = (int)Convert.ToByte(this.checkBoxChatNham.Checked);
					Class62.smethod_10(Class53.string_3, "flagChatNhamEx", Form1.int_66, "", 0);
					bool flag2 = Form1.int_66 > 0;
					if (flag2)
					{
						bool flag3 = !(Form1.string_19.ToLower() == "item");
						if (!flag3)
						{
							int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
							bool flag4 = 0 <= num;
							if (flag4)
							{
								string text = Class79.smethod_40(Form1.gstruct49_0[num]);
								string text2 = Class12.smethod_16(text);
								Class12.smethod_34("ItemName.txt", string.Concat(new string[]
								{
									text,
									Class53.string_7,
									"==================================",
									Class53.string_7,
									text2
								}), 1);
							}
						}
					}
				}
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00117614 File Offset: 0x00115814
		private void textBoxChatNham_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.string_19 = this.textBoxChatNham.Text;
				Class62.smethod_10(Class53.string_3, "textChatNhams", Form1.string_19, "", 0);
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00117668 File Offset: 0x00115868
		private void buttonCapnhat_Click(object sender, EventArgs e)
		{
			bool flag = TryNewVersion.bool_0;
			if (flag)
			{
				TryNewVersion.bool_0 = false;
			}
			else
			{
				try
				{
					new TryNewVersion
					{
						int_2 = base.Left,
						int_3 = base.Top,
						int_4 = base.Width,
						int_5 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x001176E0 File Offset: 0x001158E0
		private void buttonIDApdung_Click(object sender, EventArgs e)
		{
			string text = this.textBoxIDSudung.Text;
			bool flag = !(text == Form1.string_10);
			if (flag)
			{
				Form1.string_10 = text.Trim();
				GClass1.int_1 = 2;
				Class62.smethod_10(Class53.string_3, "textIDSudung", Form1.string_10, "", 0);
				this.richTextBoxBHO.Text = "ID [" + Form1.string_10 + "] sẽ được sử dụng. Tắt mở lại auto nếu chưa nhận lic mới.";
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0011775C File Offset: 0x0011595C
		private void buttonTrial_Click(object sender, EventArgs e)
		{
			bool flag = !(Form1.string_9 == Form1.string_10);
			if (flag)
			{
				Form1.string_10 = Form1.string_9;
				GClass1.int_1 = 2;
				Class62.smethod_10(Class53.string_3, "textIDSudung", Form1.string_10, "", 0);
				this.textBoxIDSudung.Text = Form1.string_10;
				this.richTextBoxBHO.Text = "Chưa đăng ký hoặc auto hết hạn sử dụng.";
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x001177D0 File Offset: 0x001159D0
		private void checkBoxTimAccchinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				Form1.int_21 = (int)Convert.ToByte(this.checkBoxTimAccchinh.Checked);
				Class62.smethod_10(Class53.string_3, "flagTimAccchinh", Form1.int_21, "", 0);
				bool flag2 = Form1.gstruct49_0 == null;
				if (!flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool bool_ = Form1.gstruct49_0[i].bool_25;
						if (bool_)
						{
							Class14.smethod_2(Form1.gstruct49_0[i], false);
							Class36.smethod_10(Form1.gstruct49_0[i], 0U);
						}
					}
				}
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00117898 File Offset: 0x00115A98
		private void checkBoxTimTrongthanh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				Form1.int_22 = (int)Convert.ToByte(this.checkBoxTimTrongthanh.Checked);
				Class62.smethod_10(Class53.string_3, "flagTimtrongthanh", Form1.int_22, "", 0);
				bool flag2 = Form1.gstruct49_0 == null;
				if (!flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool bool_ = Form1.gstruct49_0[i].bool_25;
						if (bool_)
						{
							Class14.smethod_2(Form1.gstruct49_0[i], false);
							Class36.smethod_10(Form1.gstruct49_0[i], 0U);
						}
					}
				}
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00117960 File Offset: 0x00115B60
		private void comboBoxAccChinh_MouseDown(object sender, MouseEventArgs e)
		{
			Form1.bool_18 = true;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				bool flag2 = false;
				this.comboBoxAccChinh.Items.Clear();
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag3 = Form1.string_17 == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
					if (flag3)
					{
						flag2 = true;
					}
					this.comboBoxAccChinh.Items.Add(Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
				}
				bool flag4 = !flag2 && Form1.string_17 != string.Empty;
				if (flag4)
				{
					this.comboBoxAccChinh.Items.Add(Form1.string_17);
				}
				this.comboBoxAccChinh.Text = Form1.string_17;
			}
			Form1.bool_18 = false;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00117A4C File Offset: 0x00115C4C
		private void comboBoxAccChinh_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Form1.bool_18;
			if (!flag)
			{
				Form1.string_17 = this.comboBoxAccChinh.Text;
				bool flag2 = Form1.string_17 != null && !(Form1.string_17 == string.Empty) && Form1.gstruct49_0 != null && Form1.gstruct49_0.Length != 0;
				if (flag2)
				{
					int num = 0;
					for (;;)
					{
						bool flag3 = num < Form1.gstruct49_0.Length;
						if (!flag3)
						{
							goto IL_92;
						}
						bool flag4 = Form1.string_17 == Class10.smethod_1(Form1.gstruct49_0[num].string_22, 1, false);
						if (flag4)
						{
							break;
						}
						num++;
					}
					Form1.int_52 = Form1.gstruct49_0[num].int_136;
					goto IL_B7;
					IL_92:
					return;
				}
				Form1.int_52 = 0;
				IL_B7:
				Class62.smethod_10(Class53.string_3, "AccChinhNameA", Class12.smethod_16(Form1.string_17), "", 0);
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00117B30 File Offset: 0x00115D30
		private void buttonOff_Click(object sender, EventArgs e)
		{
			Form1.long_4 = (long)this.method_12();
			Form1.long_3 = Class12.smethod_27();
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00117B4C File Offset: 0x00115D4C
		private int method_12()
		{
			bool flag = Class24.gstruct14_0 != null;
			int result;
			if (flag)
			{
				int num = 0;
				GStruct14 gstruct;
				for (;;)
				{
					num++;
					Form1.int_137++;
					bool flag2 = Form1.int_137 < 0 || Class24.gstruct14_0.Length <= Form1.int_137;
					if (flag2)
					{
						Form1.int_137 = 0;
					}
					gstruct = Class24.gstruct14_0[Form1.int_137];
					bool flag3 = gstruct.string_0 != null && !(gstruct.string_0 == string.Empty) && !gstruct.bool_0;
					if (flag3)
					{
						break;
					}
					bool flag4 = Class24.gstruct14_0.Length > num;
					if (!flag4)
					{
						goto IL_A1;
					}
				}
				int num2 = gstruct.int_1;
				bool flag5 = num2 < 1000;
				if (flag5)
				{
					num2 = 30000;
				}
				bool flag6 = gstruct.int_0 <= 0;
				if (flag6)
				{
					this.pictureBoxQC.Visible = true;
					this.richTextBoxStatus.Visible = false;
					bool flag7 = this.pictureBoxQC.ImageLocation != gstruct.string_0;
					if (flag7)
					{
						this.pictureBoxQC.ImageLocation = gstruct.string_0;
					}
				}
				else
				{
					this.richTextBoxStatus.Visible = true;
					this.pictureBoxQC.Visible = false;
					this.richTextBoxStatus.Text = gstruct.string_2;
				}
				return num2;
				IL_A1:
				result = 1000;
			}
			else
			{
				result = 3000;
			}
			return result;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00117CC8 File Offset: 0x00115EC8
		private void buttonFormTest_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				FormTest.gstruct49_0 = Form1.gstruct49_0[num];
			}
			FormTest.bool_1 = true;
			bool flag2 = !FormTest.bool_0;
			if (flag2)
			{
				new FormTest
				{
					int_3 = Form1.int_46[0],
					int_4 = Form1.int_46[1],
					int_1 = base.Left,
					int_2 = base.Top
				}.Show();
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00088771 File Offset: 0x00086971
		private void buttonTest_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00117D5C File Offset: 0x00115F5C
		private void checkBoxTuve_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				Form1.int_30 = (int)Convert.ToByte(this.checkBoxTuve.Checked);
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Class36.smethod_10(Form1.gstruct49_0[i], 0U);
					}
				}
				Class62.smethod_10(Class53.string_3, "flagDanhnguoi", Form1.int_30, "", 0);
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00117DF8 File Offset: 0x00115FF8
		private void checkBoxDanhquai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				Form1.int_31 = (int)Convert.ToByte(this.checkBoxDanhquai.Checked);
				bool flag2 = Form1.gstruct49_0 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Class36.smethod_10(Form1.gstruct49_0[i], 0U);
					}
				}
				Class62.smethod_10(Class53.string_3, "flagDanhquai", Form1.int_31, "", 0);
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00117E94 File Offset: 0x00116094
		private void checkBoxUutienDanhquai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				Form1.int_32 = (int)Convert.ToByte(this.checkBoxUutienDanhquai.Checked);
				Class62.smethod_10(Class53.string_3, "flagUutienBoss", Form1.int_32, "", 0);
				bool flag2 = Form1.int_32 > 0 && Form1.int_31 == 0;
				if (flag2)
				{
					this.checkBoxDanhquai.Checked = true;
					Form1.int_31 = 1;
				}
				this.checkBoxDanhquai.Enabled = (Form1.int_32 == 0);
				bool flag3 = Form1.gstruct49_0 != null;
				if (flag3)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Class36.smethod_10(Form1.gstruct49_0[i], 0U);
					}
				}
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00117F74 File Offset: 0x00116174
		private void checkBoxTiepCan_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_95 = (int)Convert.ToByte(this.checkBoxTiepCan.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00117FF4 File Offset: 0x001161F4
		private void checkBoxTamQuet_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_98 = (int)Convert.ToByte(this.checkBoxTamQuet.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00118080 File Offset: 0x00116280
		private void textBoxKhoangCachTiepcan_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxKhoangCachTiepcan.Text);
					bool flag3 = num2 < 1;
					if (flag3)
					{
						num2 = 1;
					}
					else
					{
						bool flag4 = num2 > 1000;
						if (flag4)
						{
							num2 = 1000;
						}
					}
					Form1.gstruct49_0[num].int_96 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00118128 File Offset: 0x00116328
		private void textBoxPhamvi_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxPhamvi.Text);
					bool flag3 = num2 >= 1;
					if (flag3)
					{
						bool flag4 = num2 > 1000;
						if (flag4)
						{
							num2 = 1000;
						}
					}
					else
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_99 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x001181D0 File Offset: 0x001163D0
		private void checkBoxChetnamIm_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = (int)Convert.ToByte(this.checkBoxChetnamIm.Checked);
				bool flag2 = Form1.int_38 > 0;
				if (flag2)
				{
					Form1.int_37 = num;
				}
				else
				{
					int num2 = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num2 >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num2].int_94 = num;
						Class53.smethod_13(Form1.gstruct49_0[num2], null);
					}
				}
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0011826C File Offset: 0x0011646C
		private void checkBoxNgamyBuff_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_101[0] = (int)Convert.ToByte(this.checkBoxNgamyBuff.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x001182EC File Offset: 0x001164EC
		private void textBoxNgamyBuff_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_101[3] = Class12.smethod_11(this.textBoxNgamyBuff.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0011836C File Offset: 0x0011656C
		private void textBoxTimerNgamyBuff_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxTimerNgamyBuff.Text);
					bool flag3 = num2 < 100;
					if (flag3)
					{
						num2 = 100;
					}
					Form1.gstruct49_0[num].int_101[4] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00118400 File Offset: 0x00116600
		private void checkBoxTuCastBua_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_119 = (int)Convert.ToByte(this.checkBoxTuCastBua.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00118480 File Offset: 0x00116680
		private void buttonCashBua_Click(object sender, EventArgs e)
		{
			bool flag = FormMagic.bool_0;
			if (flag)
			{
				FormMagic.bool_0 = false;
			}
			else
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					FormMagic.int_0 = Form1.gstruct49_0[num].int_136;
					FormMagic.string_0 = Class77.smethod_18(Form1.gstruct49_0[num], null);
					try
					{
						new FormMagic().Show();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00118514 File Offset: 0x00116714
		private void buttonLoaitruAccBuff_Click(object sender, EventArgs e)
		{
			bool flag = FormLoaitru.bool_0;
			if (flag)
			{
				FormLoaitru.bool_0 = false;
			}
			else
			{
				try
				{
					new FormLoaitru
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0011859C File Offset: 0x0011679C
		private void comboBoxNhatdo_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxNhatdo.Text;
					for (int i = 0; i < Form1.string_23.Length; i++)
					{
						bool flag3 = Form1.string_23[i] == text;
						if (flag3)
						{
							Form1.gstruct49_0[num].int_62 = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00118650 File Offset: 0x00116850
		private void checkBoxNhatdo_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_61 = (int)Convert.ToByte(this.checkBoxNhatdo.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x001186D0 File Offset: 0x001168D0
		private void comboBoxAccDoiMau_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				Form1.bool_18 = true;
				bool flag2 = false;
				string text = this.comboBoxAccDoiMau.Text;
				this.comboBoxAccDoiMau.Items.Clear();
				this.comboBoxAccDoiMau.Items.Add("...");
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag3 = text == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
					if (flag3)
					{
						flag2 = true;
					}
					this.comboBoxAccDoiMau.Items.Add(Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
				}
				bool flag4 = !flag2 && text != "" && text != "...";
				if (flag4)
				{
					this.comboBoxAccDoiMau.Items.Add(text);
				}
				this.comboBoxAccDoiMau.Text = text;
				Form1.bool_18 = false;
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x001187DC File Offset: 0x001169DC
		private void comboBoxAccDoiMau_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.bool_18;
			if (!flag)
			{
				FormDoiMauBang.gstruct2_0.uint_0 = 0U;
				string text = this.comboBoxAccDoiMau.Text;
				bool flag2 = Form1.gstruct49_0 != null && text != null && text != string.Empty;
				if (flag2)
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag3 = !(text == Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false));
						if (!flag3)
						{
							FormDoiMauBang.gstruct2_0.gstruct49_0 = Form1.gstruct49_0[i];
							FormDoiMauBang.gstruct2_0.string_0 = Class10.smethod_1(Form1.gstruct49_0[i].string_22, 1, false);
							goto IL_105;
						}
					}
				}
				FormDoiMauBang.gstruct2_0.string_0 = "...";
				FormDoiMauBang.gstruct2_0.gstruct49_0 = new GStruct49
				{
					int_136 = 0
				};
				IL_105:
				Class62.smethod_10(Class53.string_3, "TenAccdoiMau", Class12.smethod_16(FormDoiMauBang.gstruct2_0.string_0), "", 0);
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00118914 File Offset: 0x00116B14
		private void comboBoxUuTien_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = -1;
				string text = this.comboBoxUuTien.Text;
				for (int i = 0; i < Form1.string_25.Length; i++)
				{
					bool flag2 = text == Form1.string_25[i];
					if (flag2)
					{
						num = i;
						break;
					}
				}
				bool flag3 = num < 0;
				if (!flag3)
				{
					int num2 = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag4 = num2 >= 0;
					if (flag4)
					{
						bool flag5 = num <= 0;
						if (flag5)
						{
							this.buttonUuTien.Text = "Áp dụng";
						}
						else
						{
							this.buttonUuTien.Text = "Ưu tiên";
						}
						Form1.gstruct49_0[num2].int_88 = num;
						Class53.smethod_13(Form1.gstruct49_0[num2], null);
					}
				}
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00118A10 File Offset: 0x00116C10
		private void checkBoxMangtheotien_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_65 = (int)Convert.ToByte(this.checkBoxMangtheotien.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00118AA8 File Offset: 0x00116CA8
		private void textBoxTienMangtheo_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_66 = Class12.smethod_11(this.textBoxTienMangtheo.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00118B40 File Offset: 0x00116D40
		private void textBoxPass_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].string_15 = this.textBoxPass.Text;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00118BBC File Offset: 0x00116DBC
		private void checkBoxMua1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_71[0] = (int)Convert.ToByte(this.checkBoxMua1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00118C54 File Offset: 0x00116E54
		private void method_13(ComboBox comboBox_0)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				Form1.string_18 = new string[]
				{
					"Kim S¸ng D­îc (tiÓu)",
					"Ng­ng ThÇn ®an (tiÓu)",
					"Long §µm Hãa §éc ®an"
				};
				bool flag2 = false;
				for (int i = 0; i < Form1.string_18.Length; i++)
				{
					bool flag3 = Form1.string_18[i] == gstruct.string_11;
					if (flag3)
					{
						flag2 = true;
						break;
					}
				}
				bool flag4 = !flag2;
				if (flag4)
				{
					Array.Resize<string>(ref Form1.string_18, Form1.string_18.Length + 1);
					Form1.string_18[Form1.string_18.Length - 1] = gstruct.string_11;
				}
				flag2 = false;
				for (int j = 0; j < Form1.string_18.Length; j++)
				{
					bool flag5 = Form1.string_18[j] == gstruct.string_12;
					if (flag5)
					{
						flag2 = true;
						break;
					}
				}
				bool flag6 = !flag2;
				if (flag6)
				{
					Array.Resize<string>(ref Form1.string_18, Form1.string_18.Length + 1);
					Form1.string_18[Form1.string_18.Length - 1] = gstruct.string_12;
				}
				flag2 = false;
				for (int k = 0; k < Form1.string_18.Length; k++)
				{
					bool flag7 = Form1.string_18[k] == gstruct.string_13;
					if (flag7)
					{
						flag2 = true;
						break;
					}
				}
				bool flag8 = !flag2;
				if (flag8)
				{
					Array.Resize<string>(ref Form1.string_18, Form1.string_18.Length + 1);
					Form1.string_18[Form1.string_18.Length - 1] = gstruct.string_13;
				}
				GStruct49 gstruct2 = gstruct;
				int[] array = new int[1];
				Class79.smethod_35(gstruct2, ref Form1.string_18, 3, array, false);
				Array.Sort<string>(Form1.string_18);
				Form1.bool_9 = false;
				string text = null;
				string text2 = comboBox_0.Text;
				comboBox_0.Items.Clear();
				for (int l = 0; l < Form1.string_18.Length; l++)
				{
					string text3 = Class10.smethod_1(Form1.string_18[l], 1, false);
					comboBox_0.Items.Add(text3);
					bool flag9 = text2 == text3;
					if (flag9)
					{
						text = text2;
					}
				}
				bool flag10 = text2 != null && text2 != string.Empty && text == null;
				if (flag10)
				{
					comboBox_0.Items.Add(text2);
					text = text2;
				}
				comboBox_0.Text = text;
				Thread.Sleep(10);
				Form1.bool_9 = true;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00118EEC File Offset: 0x001170EC
		private void comboBoxMua1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				this.method_13(this.comboBoxMua1);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00118F20 File Offset: 0x00117120
		private void comboBoxMua1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxMua1.Text;
					for (int i = 0; i < Form1.string_18.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(Form1.string_18[i], 1, false);
						if (flag3)
						{
							Form1.gstruct49_0[num].string_11 = Form1.string_18[i];
							Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00119004 File Offset: 0x00117204
		private void textBoxSoluong1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_71[2] = Class12.smethod_11(this.textBoxSoluong1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0011909C File Offset: 0x0011729C
		private void checkBoxMua2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_72[0] = (int)Convert.ToByte(this.checkBoxMua2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00119134 File Offset: 0x00117334
		private void comboBoxMua2_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				this.method_13(this.comboBoxMua2);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00119168 File Offset: 0x00117368
		private void comboBoxTenThuocMienphi_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				this.method_13(this.comboBoxTenThuocMienphi);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0011919C File Offset: 0x0011739C
		private void comboBoxTenThuocMienphi_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				string text = this.comboBoxTenThuocMienphi.Text;
				for (int i = 0; i < Form1.string_18.Length; i++)
				{
					bool flag2 = text == Class10.smethod_1(Form1.string_18[i], 1, false);
					if (flag2)
					{
						Form1.string_30 = Form1.string_18[i];
						Class62.smethod_10(Class53.string_3, "TenMauFree", Form1.string_30, "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00119238 File Offset: 0x00117438
		private void comboBoxMua2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxMua2.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < Form1.string_18.Length;
						if (!flag3)
						{
							goto IL_92;
						}
						bool flag4 = text == Class10.smethod_1(Form1.string_18[num2], 1, false);
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].string_12 = Form1.string_18[num2];
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
					IL_92:;
				}
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00119320 File Offset: 0x00117520
		private void textBoxSoluong2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_72[2] = Class12.smethod_11(this.textBoxSoluong2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x001193B8 File Offset: 0x001175B8
		private void checkBoxMuaTDP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_53[0] = (int)Convert.ToByte(this.checkBoxMuaTDP.Checked);
				Class62.smethod_10(Class53.string_3, "flagMuaTDP_0", Form1.int_53[0], "", 0);
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00119454 File Offset: 0x00117654
		private void textBoxSoluongTDP_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_53[1] = Class12.smethod_11(this.textBoxSoluongTDP.Text);
				Class62.smethod_10(Class53.string_3, "flagMuaTDP_1", Form1.int_53[1], "", 0);
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x001194F0 File Offset: 0x001176F0
		private void textBoxSoluongThuocDimua_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_54 = Class12.smethod_11(this.textBoxSoluongThuocDimua.Text);
				Class62.smethod_10(Class53.string_3, "ValueThuocDimua", Form1.int_54, "", 0);
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00119588 File Offset: 0x00117788
		private void checkBoxBomHP_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_109[0] = (int)Convert.ToByte(this.checkBoxBomHP.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00119608 File Offset: 0x00117808
		private void textBoxHPBom_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_109[1] = Class12.smethod_11(this.textBoxHPBom.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00119688 File Offset: 0x00117888
		private void textBoxThoigianBomHP_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_109[2] = Class12.smethod_11(this.textBoxThoigianBomHP.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00119708 File Offset: 0x00117908
		private void textBoxSoluongBomHP_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxSoluongBomHP.Text);
					bool flag3 = num2 < 0 || num2 > 60;
					if (flag3)
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_109[3] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x001197A4 File Offset: 0x001179A4
		private void checkBoxMPBom_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_111[0] = (int)Convert.ToByte(this.checkBoxMPBom.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00119824 File Offset: 0x00117A24
		private void textBoxMPBom_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_111[1] = Class12.smethod_11(this.textBoxMPBom.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x001198B4 File Offset: 0x00117AB4
		private void textBoxThoigianBomMP_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_111[2] = Class12.smethod_11(this.textBoxThoigianBomMP.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00119934 File Offset: 0x00117B34
		private void textBoxSoluongBomMP_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxSoluongBomMP.Text);
					bool flag3 = num2 < 0 || num2 > 60;
					if (flag3)
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_111[3] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x001199D0 File Offset: 0x00117BD0
		private void checkBoxBomHPDiem_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_106[0] = (int)Convert.ToByte(this.checkBoxBomHPDiem.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00119A50 File Offset: 0x00117C50
		private void textBoxBomHPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_106[1] = Class12.smethod_11(this.textBoxBomHPDiem.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00119AD0 File Offset: 0x00117CD0
		private void textBoxThoiGianBomHPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_106[2] = Class12.smethod_11(this.textBoxThoiGianBomHPDiem.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00119B50 File Offset: 0x00117D50
		private void textBoxSoLuongBomHPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxSoLuongBomHPDiem.Text);
					bool flag3 = num2 < 0 || num2 > 60;
					if (flag3)
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_106[3] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00119BEC File Offset: 0x00117DEC
		private void checkBoxBomMPDiem_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_107[0] = (int)Convert.ToByte(this.checkBoxBomMPDiem.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00119C6C File Offset: 0x00117E6C
		private void textBoxBomMPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_107[1] = Class12.smethod_11(this.textBoxBomMPDiem.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00119CEC File Offset: 0x00117EEC
		private void textBoxThoiGianBomMPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_107[2] = Class12.smethod_11(this.textBoxThoiGianBomMPDiem.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00119D6C File Offset: 0x00117F6C
		private void textBoxSoLuongBomMPDiem_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxSoLuongBomMPDiem.Text);
					bool flag3 = num2 < 0 || num2 > 60;
					if (flag3)
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_107[3] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00119E08 File Offset: 0x00118008
		private void checkBoxHPTdp_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_113[0] = (int)Convert.ToByte(this.checkBoxHPTdp.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00119E88 File Offset: 0x00118088
		private void textBoxHpTDP_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_113[1] = Class12.smethod_11(this.textBoxHpTDP.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00119F08 File Offset: 0x00118108
		private void checkBoxMPTdp_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_114[0] = (int)Convert.ToByte(this.checkBoxMPTdp.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00119F88 File Offset: 0x00118188
		private void textBoxMPTdp_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_114[1] = Class12.smethod_11(this.textBoxMPTdp.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0011A018 File Offset: 0x00118218
		private void buttonTatcaLuuruong_Click(object sender, EventArgs e)
		{
			Class44.gstruct33_0.int_9 = 103;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				int num = 0;
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					byte[] byte_ = new byte[]
					{
						Convert.ToByte(Form1.gstruct49_0[i].bool_25)
					};
					Class22.WriteProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_15 + Class70.uint_33 * 4U, byte_, 1, ref num);
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0011A0B0 File Offset: 0x001182B0
		private void buttonTatcaTDP_Click(object sender, EventArgs e)
		{
			Class44.gstruct33_0.int_9 = 104;
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool bool_ = Form1.gstruct49_0[i].bool_25;
					if (bool_)
					{
						Class60.smethod_14(Form1.gstruct49_0[i], true);
					}
				}
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0011A118 File Offset: 0x00118318
		private void buttonBungThuoc_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				bool flag2 = Form1.gstruct49_0[num].uint_16 == 0U;
				if (flag2)
				{
					Form1.gstruct49_0[num].uint_17 = 0U;
					Form1.gstruct49_0[num].uint_16 = Class22.smethod_1(Form1.gstruct49_0[num].int_137, 512U, GEnum1.flag_2);
					bool flag3 = Form1.gstruct49_0[num].uint_16 == 0U;
					if (flag3)
					{
						return;
					}
					Class70.smethod_8(ref Form1.gstruct49_0[num]);
				}
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string[,] array = new string[5, 3];
				array[0, 0] = "Ngò Hoa Ngäc Lé Hoµn";
				array[0, 1] = "Thõa Tiªn MËt";
				array[1, 0] = "Cöu ChuyÓn Hoµn Hån ®an";
				array[1, 1] = "Håi Thiªn ®an";
				array[1, 2] = "Kim S¸ng D­îc";
				array[2, 0] = "¤ ®Çu Hoµn thÇn ®an";
				array[2, 1] = "§¹i Bæ t¸n";
				array[2, 2] = "Ng­ng ThÇn ®an";
				array[3, 0] = "Ng©n KiÒu Khø ®éc ®an";
				array[3, 1] = "Ho¾c H­¬ng ChÝnh khÝ hoµn";
				array[4, 0] = "Tam Hoa T¸n";
				string[,] array2 = array;
				for (int i = 0; i < array2.GetLength(0); i++)
				{
					for (int j = 0; j < array2.GetLength(1); j++)
					{
						bool flag4 = array2[i, j] != null;
						if (flag4)
						{
							uint num2 = Class79.smethod_30(gstruct, array2[i, j], false, 3U, true);
							bool flag5 = num2 > 0U;
							if (flag5)
							{
								Class70.smethod_103(gstruct, num2);
								Thread.Sleep(300);
								break;
							}
						}
					}
				}
			}
			else
			{
				FormTip.smethod_0(Form1.string_1, "Hãy chọn 1 ac rồi bấm nút < Bung thuốc > này.", 60000, 250, 100, false, -1, -1, false, false, false);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0011A328 File Offset: 0x00118528
		private void buttonSuadoTaicho_Click(object sender, EventArgs e)
		{
			bool flag = Form1.int_142 == 0;
			if (flag)
			{
				Form1.int_142 = 1;
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0011A348 File Offset: 0x00118548
		private void method_14()
		{
			bool flag = false;
			bool flag2 = Form1.gstruct49_0 != null;
			if (flag2)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool bool_ = Form1.gstruct49_0[i].bool_25;
					if (bool_)
					{
						Class70.smethod_52(Form1.gstruct49_0[i], "§ang kiÓm tra söa ®å tÊt c¶.", 1);
						Class79.smethod_37(Form1.gstruct49_0[i], 0, 0, true);
						Class60.smethod_3(Form1.gstruct49_0[i], ref flag);
					}
				}
			}
			Thread.Sleep(300);
			Form1.int_142 = 3;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0011A3E8 File Offset: 0x001185E8
		private void buttonComboNhoithuoc_Click(object sender, EventArgs e)
		{
			bool flag = !Combo.bool_0;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (flag2)
				{
					FormTip.smethod_0(Form1.string_1, "Hãy chọn 1 ac rồi bấm nút Combox này.", 60000, 250, 100, false, -1, -1, false, false, false);
				}
				else
				{
					try
					{
						new Combo
						{
							int_0 = base.Left,
							int_1 = base.Top,
							int_2 = base.Width,
							int_3 = base.Height,
							gstruct49_0 = default(GStruct49),
							gstruct49_0 = Form1.gstruct49_0[num]
						}.Show();
					}
					catch
					{
					}
				}
			}
			else
			{
				Combo.bool_0 = false;
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0011A4CC File Offset: 0x001186CC
		private void checkBoxAccPhuHauDoanh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_89 = (int)Convert.ToByte(this.checkBoxAccPhuHauDoanh.Checked);
				Class62.smethod_10(Class53.string_3, "flagAccPhuChoAccChinh", Form1.int_89, "", 0);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0011A52C File Offset: 0x0011872C
		private void checkBoxAccChinhHauDoanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_88 = (int)Convert.ToByte(this.checkBoxAccChinhHauDoanh.Checked);
					Class62.smethod_10(Class53.string_3, "flagAccChinhRoiHauDoanh", Form1.int_88, "", 0);
				}
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0011A598 File Offset: 0x00118798
		private void comboBoxBentau_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				string text = this.comboBoxBentau.Text;
				for (int i = 0; i < Form1.string_31.Length; i++)
				{
					bool flag2 = text == Form1.string_31[i];
					if (flag2)
					{
						Form1.int_104 = i;
						break;
					}
				}
				Class62.smethod_10(Class53.string_3, "flagIndexBentau", Form1.int_104, "", 0);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0011A624 File Offset: 0x00118824
		private void buttonNopLenhbai_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (flag)
			{
				FormTip.smethod_0(Form1.string_1, "Hãy chọn 1 ac rồi bấm nút lệnh này.", 4000, 250, 80, false, -1, -1, false, false, false);
			}
			else
			{
				bool flag2 = Form1.int_104 != 8;
				if (flag2)
				{
					bool flag3 = Form1.int_104 != 7;
					if (flag3)
					{
						bool flag4 = Form1.int_104 != 6;
						if (flag4)
						{
							bool bool_ = Form1.gstruct49_0[num].bool_25;
							if (bool_)
							{
								bool flag5 = Form1.int_20 != 0 || Form1.gstruct49_0[num].bool_15;
								if (!flag5)
								{
									bool flag6 = Form1.int_104 <= 2;
									if (flag6)
									{
										Class12.smethod_37(ref Class41.int_0, Form1.gstruct49_0[num].int_136);
										bool flag7 = !Class41.bool_0;
										if (flag7)
										{
											Class41.smethod_0();
										}
									}
									else
									{
										bool flag8 = Form1.int_104 != 3 && Form1.int_104 != 4;
										if (flag8)
										{
											bool flag9 = Form1.int_104 == 5;
											if (flag9)
											{
												FormClickNPC.int_7 = Form1.gstruct49_0[num].int_136;
												new Thread(new ThreadStart(FormClickNPC.smethod_2)).Start();
											}
										}
										else
										{
											Form1.gstruct49_0[num].bool_55 = Form1.gstruct49_0[num].bool_25;
										}
									}
								}
							}
							else
							{
								FormTip.smethod_0(Form1.string_1, "Hãy stick vào ac rồi bấm nút lệnh này.", 4000, 250, 80, false, -1, -1, false, false, false);
							}
						}
						else
						{
							string text = null;
							int num2 = Class86.smethod_0(Form1.gstruct49_0[num]);
							bool flag10 = num2 >= 0;
							if (flag10)
							{
								bool flag11 = num2 >= 1;
								int num3;
								if (flag11)
								{
									num3 = Class86.Class88.smethod_0(Form1.gstruct49_0[num]);
									bool flag12 = num3 > 0;
									if (flag12)
									{
										for (int i = 0; i < num3; i++)
										{
											bool flag13 = text != null;
											if (flag13)
											{
												text += Class53.string_7;
											}
											text += Class86.smethod_3(Form1.gstruct49_0[num], i, 1, 128);
										}
									}
								}
								num3 = Class86.Class87.smethod_0(Form1.gstruct49_0[num]);
								bool flag14 = num2 != 1 && num3 > 0;
								if (flag14)
								{
									for (int j = 0; j < num3; j++)
									{
										bool flag15 = text != null;
										if (flag15)
										{
											text += Class53.string_7;
										}
										text += Class86.smethod_3(Form1.gstruct49_0[num], j, 0, 128);
									}
								}
							}
							string text2 = Form1.string_1;
							bool flag16 = text == null;
							if (flag16)
							{
								text = "Không có menu text nào. Bạn hãy click vào xa phu rồi bấm nút này để lấy menu.";
							}
							else
							{
								Clipboard.SetText(text);
								text2 = "ĐÃ COPY VÀO CLIBOARD";
							}
							FormTip.smethod_0(text2, text, 9999999, 300, 160, false, -1, -1, false, false, false);
						}
					}
					else
					{
						string text3 = Class79.smethod_40(Form1.gstruct49_0[num]);
						bool flag17 = text3 != null && text3 != string.Empty;
						if (flag17)
						{
							Clipboard.SetText(text3);
							string text4 = "ĐÃ COPY VÀO CLIBOARD";
							FormTip.smethod_0(text4, text3, 9999999, 300, 160, true, -1, -1, false, false, false);
						}
					}
				}
				else
				{
					string text5 = Class70.smethod_122(Form1.gstruct49_0[num], false);
					bool flag18 = text5 != null && text5 != string.Empty;
					if (flag18)
					{
						Clipboard.SetText(text5);
						string text6 = "ĐÃ COPY VÀO CLIBOARD";
						FormTip.smethod_0(text6, text5, 9999999, 300, 160, true, -1, -1, false, false, false);
					}
				}
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0011AA10 File Offset: 0x00118C10
		private void buttonNopLenhbaiAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.int_20 != 0 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				bool flag2 = Form1.int_104 <= 2;
				if (flag2)
				{
					bool flag3 = false;
					Class44.gstruct33_0.int_9 = 100 + Form1.int_104;
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						bool flag4 = !Form1.gstruct49_0[i].bool_15 && Form1.gstruct49_0[i].bool_25;
						if (flag4)
						{
							Class12.smethod_37(ref Class41.int_0, Form1.gstruct49_0[i].int_136);
							flag3 = true;
						}
					}
					bool flag5 = flag3 && !Class41.bool_0;
					if (flag5)
					{
						Class41.smethod_0();
					}
				}
				else
				{
					bool flag6 = Form1.int_104 == 3 || Form1.int_104 == 4;
					if (flag6)
					{
						Class44.gstruct33_0.int_9 = Form1.int_104;
						for (int j = 0; j < Form1.gstruct49_0.Length; j++)
						{
							Form1.gstruct49_0[j].bool_55 = Form1.gstruct49_0[j].bool_25;
						}
					}
					else
					{
						bool flag7 = Form1.int_104 == 5;
						if (flag7)
						{
							Class44.gstruct33_0.int_9 = Form1.int_104;
							new Thread(new ThreadStart(FormClickNPC.smethod_1)).Start();
						}
					}
				}
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0011AB88 File Offset: 0x00118D88
		private void buttonVaotraiStop_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				Form1.gstruct49_0[num].bool_15 = false;
				Form1.gstruct49_0[num].bool_55 = false;
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0011ABDC File Offset: 0x00118DDC
		private void buttonVaotraiStopAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].bool_15 = false;
					Form1.gstruct49_0[i].bool_55 = false;
				}
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0011AC34 File Offset: 0x00118E34
		private void buttonThongke_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_3(Form1.gstruct49_0, Class76.gstruct49_0.int_136);
			bool flag = num < 0;
			if (flag)
			{
				num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (flag2)
				{
					FormTip.smethod_0(Form1.string_1, "Chọn 1 ac rồi bấm nút Thống kê.", 600000, 200, 120, false, -1, -1, false, false, false);
					return;
				}
			}
			bool flag3 = Form1.gstruct49_0[num].uint_16 == 0U;
			if (flag3)
			{
				Form1.gstruct49_0[num].uint_17 = 0U;
				Form1.gstruct49_0[num].uint_16 = Class22.smethod_1(Form1.gstruct49_0[num].int_137, 512U, GEnum1.flag_2);
				bool flag4 = Form1.gstruct49_0[num].uint_16 == 0U;
				if (flag4)
				{
					return;
				}
				Class70.smethod_8(ref Form1.gstruct49_0[num]);
			}
			new Thread(new ThreadStart(new Class5
			{
				gstruct49_0 = Form1.gstruct49_0[num],
				string_0 = null
			}.method_2)).Start();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0011AD60 File Offset: 0x00118F60
		private void buttonApDungMuaThuocAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				bool flag2 = Form1.gstruct49_0[num].int_75 == null;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_75 = new int[5];
				}
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag3 = i != num;
					if (flag3)
					{
						int num2 = Form1.gstruct49_0[num].int_71.Length;
						Form1.gstruct49_0[i].int_71 = new int[num2];
						for (int j = 0; j < num2; j++)
						{
							Form1.gstruct49_0[i].int_71[j] = Form1.gstruct49_0[num].int_71[j];
						}
						int num3 = Form1.gstruct49_0[num].int_72.Length;
						Form1.gstruct49_0[i].int_72 = new int[num3];
						for (int k = 0; k < num3; k++)
						{
							Form1.gstruct49_0[i].int_72[k] = Form1.gstruct49_0[num].int_72[k];
						}
						int num4 = Form1.gstruct49_0[num].int_73.Length;
						for (int l = 0; l < num4; l++)
						{
							Form1.gstruct49_0[i].int_73[l] = Form1.gstruct49_0[num].int_73[l];
						}
						Form1.gstruct49_0[i].string_11 = Form1.gstruct49_0[num].string_11;
						Form1.gstruct49_0[i].string_12 = Form1.gstruct49_0[num].string_12;
						Form1.gstruct49_0[i].string_13 = Form1.gstruct49_0[num].string_13;
						Form1.gstruct49_0[i].int_105 = Form1.gstruct49_0[num].int_105;
						Form1.gstruct49_0[i].int_66 = Form1.gstruct49_0[num].int_66;
						Form1.gstruct49_0[i].int_77 = Form1.gstruct49_0[num].int_77;
						Form1.gstruct49_0[i].int_75 = new int[Form1.gstruct49_0[num].int_75.Length];
						for (int m = 0; m < Form1.gstruct49_0[num].int_75.Length; m++)
						{
							Form1.gstruct49_0[i].int_75[m] = Form1.gstruct49_0[num].int_75[m];
						}
						for (int n = 0; n < Form1.gstruct49_0[num].int_76.Length; n++)
						{
							Form1.gstruct49_0[i].int_76[n] = Form1.gstruct49_0[num].int_76[n];
						}
						Form1.gstruct49_0[i].string_14 = Form1.gstruct49_0[num].string_14;
						Form1.gstruct49_0[i].int_78 = Form1.gstruct49_0[num].int_78;
						Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_23, 1, 4);
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0011B108 File Offset: 0x00119308
		private void buttonAppDungBomMauAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = i != num;
					if (flag2)
					{
						for (int j = 0; j < Form1.gstruct49_0[num].int_109.Length; j++)
						{
							Form1.gstruct49_0[i].int_109[j] = Form1.gstruct49_0[num].int_109[j];
						}
						for (int k = 0; k < Form1.gstruct49_0[num].int_110.Length; k++)
						{
							Form1.gstruct49_0[i].int_110[k] = Form1.gstruct49_0[num].int_110[k];
						}
						for (int l = 0; l < Form1.gstruct49_0[num].int_111.Length; l++)
						{
							Form1.gstruct49_0[i].int_111[l] = Form1.gstruct49_0[num].int_111[l];
						}
						for (int m = 0; m < Form1.gstruct49_0[num].int_112.Length; m++)
						{
							Form1.gstruct49_0[i].int_112[m] = Form1.gstruct49_0[num].int_112[m];
						}
						for (int n = 0; n < Form1.gstruct49_0[num].int_106.Length; n++)
						{
							Form1.gstruct49_0[i].int_106[n] = Form1.gstruct49_0[num].int_106[n];
						}
						for (int num2 = 0; num2 < Form1.gstruct49_0[num].int_107.Length; num2++)
						{
							Form1.gstruct49_0[i].int_107[num2] = Form1.gstruct49_0[num].int_107[num2];
						}
						for (int num3 = 0; num3 < Form1.gstruct49_0[num].int_113.Length; num3++)
						{
							Form1.gstruct49_0[i].int_113[num3] = Form1.gstruct49_0[num].int_113[num3];
						}
						for (int num4 = 0; num4 < Form1.gstruct49_0[num].int_114.Length; num4++)
						{
							Form1.gstruct49_0[i].int_114[num4] = Form1.gstruct49_0[num].int_114[num4];
						}
						for (int num5 = 0; num5 < Form1.gstruct49_0[num].int_104.Length; num5++)
						{
							Form1.gstruct49_0[i].int_104[num5] = Form1.gstruct49_0[num].int_104[num5];
						}
						Form1.gstruct49_0[i].int_108 = Form1.gstruct49_0[num].int_108;
						Form1.gstruct49_0[i].string_16 = Form1.gstruct49_0[num].string_16;
						Form1.gstruct49_0[i].string_17 = Form1.gstruct49_0[num].string_17;
						Form1.gstruct49_0[i].int_115 = Form1.gstruct49_0[num].int_115;
						Form1.gstruct49_0[i].int_116 = Form1.gstruct49_0[num].int_116;
						Form1.gstruct49_0[i].int_117 = Form1.gstruct49_0[num].int_117;
						Form1.gstruct49_0[i].int_118 = Form1.gstruct49_0[num].int_118;
						Form1.gstruct49_0[i].int_58 = Form1.gstruct49_0[num].int_58;
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0011B544 File Offset: 0x00119744
		private void checkBoxTuGiaidoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_74[0] = (int)Convert.ToByte(this.checkBoxTuGiaidoc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0011B5C4 File Offset: 0x001197C4
		private void textBoxTimerBomMagic_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxTimerBomMagic.Text);
					bool flag3 = num2 < 1000 || num2 > 15000;
					if (flag3)
					{
						num2 = 1000;
					}
					Form1.gstruct49_0[num].int_74[1] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0011B668 File Offset: 0x00119868
		private void textBoxSoluongBomMagic_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxSoluongBomMagic.Text);
					bool flag3 = num2 < 1 || num2 > 60;
					if (flag3)
					{
						num2 = 1;
					}
					Form1.gstruct49_0[num].int_74[2] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0011B704 File Offset: 0x00119904
		private void checkBoxMuaGiaiDoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_73[0] = (int)Convert.ToByte(this.checkBoxMuaGiaiDoc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0011B79C File Offset: 0x0011999C
		private void textBoxSoluongMuaGiaiDoc_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_73[2] = Class12.smethod_11(this.textBoxSoluongMuaGiaiDoc.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0011B834 File Offset: 0x00119A34
		private void comboBoxMuaGiaiDoc_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				this.method_13(this.comboBoxMuaGiaiDoc);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0011B868 File Offset: 0x00119A68
		private void comboBoxMuaGiaiDoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxMuaGiaiDoc.Text;
					for (int i = 0; i < Form1.string_18.Length; i++)
					{
						bool flag3 = text == Class10.smethod_1(Form1.string_18[i], 1, false);
						if (flag3)
						{
							Form1.gstruct49_0[num].string_13 = Form1.string_18[i];
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0011B94C File Offset: 0x00119B4C
		private void checkBoxMuaKTC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_77 = (int)Convert.ToByte(this.checkBoxMuaKTC.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0011B9E4 File Offset: 0x00119BE4
		private void comboBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = -1;
				string text = this.comboBoxIndex.Text;
				for (int i = 0; i < Form1.string_12.Length; i++)
				{
					bool flag2 = text == Form1.string_12[i];
					if (flag2)
					{
						num = i;
						break;
					}
				}
				bool flag3 = Form1.int_20 == num;
				if (!flag3)
				{
					this.checkBoxTatmuaAll.Checked = false;
					Form1.bool_4 = false;
					Form1.int_20 = num;
					this.checkBoxChienLongdong.Enabled = (num == 0);
					this.checkBoxTubaoDanh.Enabled = (Form1.int_20 == 1);
					Class62.smethod_10(Class53.string_3, "IndexPK", Form1.int_20, "", 0);
					string text2 = null;
					bool flag4 = Form1.int_20 == 0;
					if (flag4)
					{
						text2 = "Chế độ WAR dùng để đánh ở thành thị, sơn động, map train...";
					}
					else
					{
						bool flag5 = Form1.int_20 != 1;
						if (flag5)
						{
							bool flag6 = Form1.int_20 == 2;
							if (flag6)
							{
								text2 = "Chế độ CTC dùng để đánh Chiến trường Công thành chiến (thất thành và tam trụ)";
							}
							else
							{
								bool flag7 = Form1.int_20 == 3;
								if (flag7)
								{
									text2 = "Chế độ ĐƠN ĐẤU: tối ưu tốc độ đánh (chỉ có đánh và bơm máu), thường dùng trong liên đấu. Chế độ này auto không tự mua máu, không tìm ac...";
								}
							}
						}
						else
						{
							text2 = "Chế độ TK dùng để đánh Tống Kim và Phong Hỏa liên thành.";
						}
					}
					bool flag8 = text2 != null;
					if (flag8)
					{
						Class12.string_16 = new string[]
						{
							text2
						};
					}
				}
			}
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0011BB44 File Offset: 0x00119D44
		private void checkBoxGiamRamTudong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_64 = (int)Convert.ToByte(this.checkBoxGiamRamTudong.Checked);
				TryNewVersion.bool_1 = (Form1.int_64 > 0);
				Class62.smethod_10(Class53.string_3, "flagGiamRamtudong", Form1.int_64, "", 0);
				new Thread(new ThreadStart(TryNewVersion.smethod_4)).Start();
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0011BBC8 File Offset: 0x00119DC8
		private void comboBoxGameOfWeb_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Form1.int_0;
				string text = this.comboBoxGameOfWeb.Text;
				for (int i = 0; i < Form1.listwebdomain.Count; i++)
				{
					bool flag2 = text == Form1.listwebdomain[i][0] && Form1.int_0 != i;
					if (flag2)
					{
						Form1.int_0 = i;
						this.int_133 = -1;
						break;
					}
				}
				bool flag3 = num == Form1.int_0;
				if (!flag3)
				{
					this.checkBoxMuaMauFree.Checked = false;
					bool flag4 = Form1.gstruct49_0 == null;
					if (!flag4)
					{
						for (int j = 0; j < Form1.gstruct49_0.Length; j++)
						{
							bool flag5 = Form1.gstruct49_0[j].int_78 > 0;
							if (flag5)
							{
								Form1.gstruct49_0[j].int_78 = 0;
								Class53.smethod_13(Form1.gstruct49_0[j], null);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0011BCEC File Offset: 0x00119EEC
		private string method_15(string string_54, string[] string_55)
		{
			string text = null;
			bool flag = string_55 != null;
			if (flag)
			{
				for (int i = 0; i < string_55.Length; i++)
				{
					bool flag2 = string_54 == string_55[i];
					if (flag2)
					{
						char c = (char)new Random().Next(14, 30);
						text = string.Concat(new string[]
						{
							"K",
							c.ToString(),
							"Y",
							c.ToString(),
							"Keo-xe"
						});
						this.method_35(text + " " + Form1.string_0);
						Class12.smethod_34(Class53.string_9 + "\\Title.txt", text, 1);
						break;
					}
				}
			}
			bool flag3 = text == null;
			if (flag3)
			{
				Class12.smethod_20(Class53.string_9 + "\\Title.txt");
			}
			return text;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0011BDD4 File Offset: 0x00119FD4
		private void method_16()
		{
			int num = -1;
			for (int i = 0; i < Form1.listwebdomain.Count; i++)
			{
				bool flag = Form1.string_3 == Form1.listwebdomain[i][0];
				if (flag)
				{
					num = i;
					break;
				}
			}
			bool flag2 = num >= 0;
			if (flag2)
			{
				Class18.int_1 = -1;
				Class35.int_1 = Class12.smethod_11(Form1.listwebdomain[num][2]);
				Console.WriteLine("Class35.int_1 : " + Class35.int_1.ToString());
				Class35.smethod_136();
				string text = Form1.listwebdomain[num][3];
				bool flag3 = text != null && !(text == string.Empty);
				if (flag3)
				{
					Form1.int_109 = Class12.smethod_11(text);
					this.numericUpDownCTC.Value = Form1.int_109;
					string a = Form1.listwebdomain[num][5];
					bool flag4 = a == "0" || a == "1";
					if (flag4)
					{
						int num2 = Class12.smethod_11(a);
						Form1.bool_9 = false;
						this.checkBoxTHPCTC.Checked = (num2 > 0);
						Thread.Sleep(60);
						Form1.int_105 = num2;
						Class62.smethod_10(Class53.string_3, "flagTHPCTC", Form1.int_105, "", 0);
						Form1.bool_9 = true;
					}
				}
				else
				{
					Form1.int_105 = 0;
					this.checkBoxTHPCTC.Checked = false;
				}
			}
			else
			{
				this.method_2("Không thể cập nhật thần hành phù.");
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0011BF70 File Offset: 0x0011A170
		private void checkBoxGanChieuTrai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_138[0] = (int)Convert.ToByte(this.checkBoxGanChieuTrai.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					bool flag3 = Form1.gstruct49_0[num].int_138[0] > 0 && Form1.gstruct49_0[num].int_138[1] > 0;
					if (flag3)
					{
						Class77.smethod_15(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].int_138[1], false);
						Class70.smethod_31(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].int_138[1]);
					}
				}
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0011C074 File Offset: 0x0011A274
		private void checkBoxGanChieuPhai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_139[0] = (int)Convert.ToByte(this.checkBoxGanChieuPhai.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					bool flag3 = Form1.gstruct49_0[num].int_139[0] > 0 && Form1.gstruct49_0[num].int_139[1] > 0;
					if (flag3)
					{
						Class77.smethod_15(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].int_139[1], true);
						Class70.smethod_32(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].int_139[1]);
					}
				}
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0011C178 File Offset: 0x0011A378
		private void comboBoxGanChieuTrai_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxGanChieuTrai.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct56_0 == null;
					if (!flag3)
					{
						int num2 = 0;
						for (;;)
						{
							bool flag4 = num2 < Form1.gstruct49_0[num].gstruct56_0.Length;
							if (!flag4)
							{
								goto IL_C1;
							}
							bool flag5 = text == Form1.gstruct49_0[num].gstruct56_0[num2].string_0;
							if (flag5)
							{
								break;
							}
							num2++;
						}
						Form1.gstruct49_0[num].int_138[1] = Form1.gstruct49_0[num].gstruct56_0[num2].int_1;
						bool flag6 = Form1.gstruct49_0[num].int_138[0] > 0;
						if (flag6)
						{
							Class77.smethod_15(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].gstruct56_0[num2].int_1, false);
							Class70.smethod_31(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].gstruct56_0[num2].int_1);
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
						IL_C1:;
					}
				}
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0011C308 File Offset: 0x0011A508
		private void comboBoxGanChieuPhai_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxGanChieuPhai.Text;
					bool flag3 = Form1.gstruct49_0[num].gstruct56_0 == null;
					if (!flag3)
					{
						int num2 = 0;
						for (;;)
						{
							bool flag4 = num2 < Form1.gstruct49_0[num].gstruct56_0.Length;
							if (!flag4)
							{
								goto IL_C1;
							}
							bool flag5 = text == Form1.gstruct49_0[num].gstruct56_0[num2].string_0;
							if (flag5)
							{
								break;
							}
							num2++;
						}
						Form1.gstruct49_0[num].int_139[1] = Form1.gstruct49_0[num].gstruct56_0[num2].int_1;
						bool flag6 = Form1.gstruct49_0[num].int_139[0] > 0;
						if (flag6)
						{
							Class77.smethod_15(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].gstruct56_0[num2].int_1, true);
							Class70.smethod_32(Form1.gstruct49_0[num], (uint)Form1.gstruct49_0[num].gstruct56_0[num2].int_1);
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
						IL_C1:;
					}
				}
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0011C498 File Offset: 0x0011A698
		private void checkBoxTrinhSat_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_90 = (int)Convert.ToByte(this.checkBoxTrinhSat.Checked);
				Class62.smethod_10(Class53.string_3, "flagRabangTrinhsat", Form1.int_90, "", 0);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0011C4F8 File Offset: 0x0011A6F8
		private void buttonGiaiThichHaucan_Click(object sender, EventArgs e)
		{
			string text = "- Ô bên trái là chỉ số % hoặc điểm.|- Ô bên phải là số lượng bình thuốc ăn một lần.|- Ô ở giữa là thời gian (mili giây) giữa 2 lần sử dụng thuốc.||Ví dụ mục Tự ăn giải độc, bạn ghi 4500 và 2. Thì khi dính độc, ac sẽ ăn 2 bình, sau đó chờ 4,5 giây (nếu còn dính độc) thì lại ăn tiếp 2 bình...||Mục <Gán thiết lập chung cho tất cả> là chỉ cần thiết lập cho 1 acc, rồi bấm nút này thì tất cả các ac còn lại sẽ có thiết lập giống y chang ac này.";
			FormTip.smethod_0("HAU CAN BOM THUOC", text, 999000, 370, 210, false, Cursor.Position.X, Cursor.Position.Y - 210, false, false, false);
			string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(text2);
			if (flag)
			{
				text2 = Class62.smethod_0();
			}
			Class22.smethod_40(text2, "", "http://canhtrang.com/phuchoi.htm", 0, false, false);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0011C588 File Offset: 0x0011A788
		private void checkBoxAnThuocLag_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_63 = (int)Convert.ToByte(this.checkBoxAnThuocLag.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0011C608 File Offset: 0x0011A808
		private void checkBoxTheoSau_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				bool flag2 = !this.checkBoxTheoSau.Checked || !FormMayphu.bool_3;
				if (flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_68[0] = (int)Convert.ToByte(this.checkBoxTheoSau.Checked && !FormMayphu.bool_3);
						this.labelTheoSauAll.Enabled = true;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
				else
				{
					FormTip.smethod_0(Form1.string_1, Class12.smethod_0(Class12.char_10), 60000, 250, 100, false, -1, -1, false, false, false);
				}
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0011C6F0 File Offset: 0x0011A8F0
		private void comboBoxTheoSau_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTheoSau.Text;
					bool flag3 = Form1.string_43 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.string_43.Length; i++)
						{
							bool flag4 = Class10.smethod_1(Form1.string_43[i], 1, false) == text;
							if (flag4)
							{
								Form1.gstruct49_0[num].string_9 = Form1.string_43[i];
								Class53.smethod_13(Form1.gstruct49_0[num], null);
								break;
							}
						}
					}
					this.labelTheoSauAll.Enabled = true;
				}
			}
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0011C7D4 File Offset: 0x0011A9D4
		private void textBoxKhoangCachTheoSau_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_68[1] = Class12.smethod_11(this.textBoxKhoangCachTheoSau.Text);
						this.labelTheoSauAll.Enabled = true;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0011C870 File Offset: 0x0011AA70
		private void labelTheoSauAll_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				bool flag2 = FormMayphu.bool_3;
				if (flag2)
				{
					FormTip.smethod_0(Form1.string_1, Class12.smethod_0(Class12.char_10), 600000, 250, 80, false, -1, -1, false, false, false);
				}
				else
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num < 0;
					if (!flag3)
					{
						GStruct49 gstruct = Form1.gstruct49_0[num];
						bool flag4 = Form1.gstruct49_0 != null;
						if (flag4)
						{
							for (int i = 0; i < Form1.gstruct49_0.Length; i++)
							{
								bool flag5 = i != num;
								if (flag5)
								{
									Form1.gstruct49_0[i].int_68 = new int[]
									{
										gstruct.int_68[0],
										gstruct.int_68[1],
										gstruct.int_68[2]
									};
									Form1.gstruct49_0[i].string_9 = gstruct.string_9;
									Class53.smethod_13(Form1.gstruct49_0[i], null);
								}
							}
						}
						this.labelTheoSauAll.Enabled = false;
					}
				}
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0011C9BC File Offset: 0x0011ABBC
		private void comboBoxTheoSau_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				Form1.bool_9 = false;
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text = gstruct.string_9;
				string text2 = null;
				this.comboBoxTheoSau.Items.Clear();
				Form1.string_43 = null;
				Class98.smethod_25(Form1.gstruct49_0[num], ref Form1.string_43, 1, null);
				bool flag2 = Form1.string_43 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.string_43.Length; i++)
					{
						bool flag3 = Form1.string_43[i] == text;
						if (flag3)
						{
							text2 = text;
						}
						this.comboBoxTheoSau.Items.Add(Class10.smethod_1(Form1.string_43[i], 1, false));
					}
				}
				bool flag4 = text2 == null && text != null && text != string.Empty;
				if (flag4)
				{
					this.comboBoxTheoSau.Items.Add(Class10.smethod_1(text, 1, false));
					text2 = text;
				}
				this.comboBoxTheoSau.Items.Add("");
				bool flag5 = text2 != null && text2 != string.Empty;
				if (flag5)
				{
					this.comboBoxTheoSau.Text = Class10.smethod_1(text2, 1, false);
				}
				Form1.bool_9 = true;
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0011CB1C File Offset: 0x0011AD1C
		private void checkBoxClickNPCmenu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_8 = (int)Convert.ToByte(this.checkBoxClickNPCmenu.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0011CB9C File Offset: 0x0011AD9C
		public static int[] smethod_2(string string_54)
		{
			bool flag = !(string_54 == string.Empty) && string_54 != null;
			int[] result;
			if (flag)
			{
				string[] array = string_54.Split(new char[]
				{
					',',
					'.',
					':',
					'/',
					'|',
					'=',
					'-',
					'+',
					';'
				});
				int[] array2 = new int[array.Length];
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i] = Class12.smethod_11(array[i]);
				}
				result = array2;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0011CC14 File Offset: 0x0011AE14
		private void checkBoxClickNPCSolan_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_7 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_7 = new int[]
						{
							0,
							3
						};
					}
					Form1.gstruct49_0[num].int_7[0] = (int)Convert.ToByte(this.checkBoxClickNPCSolan.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0011CCCC File Offset: 0x0011AECC
		private void textBoxClickNPCSolan_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_7 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_7 = new int[]
						{
							0,
							3
						};
					}
					Form1.gstruct49_0[num].int_7[1] = Class12.smethod_11(this.textBoxClickNPCSolan.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0011CD84 File Offset: 0x0011AF84
		private void textBoxClickNPCTocdo_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxClickNPCTocdo.Text);
					bool flag3 = num2 < 0 || num2 > 15000;
					if (flag3)
					{
						num2 = 300;
					}
					Form1.gstruct49_0[num].int_10 = num2;
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_49, num2, 4);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0011CE40 File Offset: 0x0011B040
		private void comboBoxClickNPC_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				Form1.bool_9 = false;
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text = gstruct.string_0;
				string text2 = null;
				this.comboBoxClickNPC.Items.Clear();
				Form1.string_44 = null;
				Class98.smethod_25(Form1.gstruct49_0[num], ref Form1.string_44, 3, null);
				bool flag2 = Form1.string_44 != null;
				if (flag2)
				{
					Array.Sort<string>(Form1.string_44);
					for (int i = 0; i < Form1.string_44.Length; i++)
					{
						bool flag3 = Form1.string_44[i] == text;
						if (flag3)
						{
							text2 = text;
						}
						this.comboBoxClickNPC.Items.Add(Class10.smethod_1(Form1.string_44[i], 1, false));
					}
				}
				bool flag4 = text2 == null && text != string.Empty;
				if (flag4)
				{
					this.comboBoxClickNPC.Items.Add(Class10.smethod_1(text, 1, false));
					text2 = text;
				}
				this.comboBoxClickNPC.Items.Add("");
				bool flag5 = text2 != null && text2 != string.Empty;
				if (flag5)
				{
					this.comboBoxClickNPC.Text = Class10.smethod_1(text2, 1, false);
				}
				Thread.Sleep(10);
				Form1.bool_9 = true;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0011CFB0 File Offset: 0x0011B1B0
		private void comboBoxClickNPC_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				string text = this.comboBoxClickNPC.Text;
				bool flag2 = Form1.string_44 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.string_44.Length; i++)
					{
						bool flag3 = Class10.smethod_1(Form1.string_44[i], 1, false) == text;
						if (flag3)
						{
							Form1.string_45 = Form1.string_44[i];
							break;
						}
					}
				}
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag4 = num >= 0;
				if (flag4)
				{
					Form1.gstruct49_0[num].string_0 = Form1.string_45;
				}
			}
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0011D07A File Offset: 0x0011B27A
		private void buttonHuongdanHLP_Click(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0011D084 File Offset: 0x0011B284
		private void method_17()
		{
			bool flag = FormVideoHelp.bool_0;
			if (flag)
			{
				FormVideoHelp.bool_0 = false;
			}
			else
			{
				try
				{
					new FormVideoHelp
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0011D0FC File Offset: 0x0011B2FC
		private void checkBoxGioClick_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].gstruct47_0.int_2 = (int)Convert.ToByte(this.checkBoxGioClick.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0011D18C File Offset: 0x0011B38C
		private void numericUpDownHH_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct47_0.int_3 = (int)this.numericUpDownHH.Value;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0011D210 File Offset: 0x0011B410
		private void numericUpDownMM_ValueChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct47_0.int_4 = (int)this.numericUpDownMM.Value;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0011D294 File Offset: 0x0011B494
		private void numericUpDownSS_ValueChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].gstruct47_0.int_5 = (int)this.numericUpDownSS.Value;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0011D324 File Offset: 0x0011B524
		private void numericUpDownCTC_ValueChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_109 = (int)this.numericUpDownCTC.Value;
					Class62.smethod_10(Class53.string_3, "IdexMenuTHPChientruong", Form1.int_109, "", 0);
				}
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0011D390 File Offset: 0x0011B590
		private void comboBoxChienTruong_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.comboBoxChienTruong.Text;
			for (int i = 0; i < Class101.struct29_0.Length; i++)
			{
				bool flag = Class101.struct29_0[i].string_2 == text;
				if (flag)
				{
					bool flag2 = Form1.int_106 != i;
					if (flag2)
					{
						Form1.int_106 = i;
						Class62.smethod_10(Class53.string_3, "IdexChientruongChinh", Form1.int_106, "", 0);
					}
					break;
				}
			}
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0011D418 File Offset: 0x0011B618
		private void comboBoxChienTruongMapPhu_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.comboBoxChienTruongMapPhu.Text;
			for (int i = 0; i < Class101.struct29_0.Length; i++)
			{
				bool flag = Class101.struct29_0[i].string_2 == text;
				if (flag)
				{
					bool flag2 = Form1.int_108 != i;
					if (flag2)
					{
						Form1.int_108 = i;
						Class62.smethod_10(Class53.string_3, "IdexChientruongPhu", Form1.int_108, "", 0);
					}
					break;
				}
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0011D4A0 File Offset: 0x0011B6A0
		private void checkBoxTHPCTC_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_105 = (int)Convert.ToByte(this.checkBoxTHPCTC.Checked);
					Class62.smethod_10(Class53.string_3, "flagTHPCTC", Form1.int_105, "", 0);
				}
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0011D50C File Offset: 0x0011B70C
		private void checkBoxMapPhu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_107 = (int)Convert.ToByte(this.checkBoxMapPhu.Checked);
				Class62.smethod_10(Class53.string_3, "flagSudungMapphuEx", Form1.int_107, "", 0);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0011D56C File Offset: 0x0011B76C
		private void checkBoxAccChinhTudieukhienCTC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_113 = (int)Convert.ToByte(this.checkBoxAccChinhTudieukhienCTC.Checked);
					Class62.smethod_10(Class53.string_3, "CTCAchinhTudieuKhien", Form1.int_113, "", 0);
				}
			}
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0011D5D8 File Offset: 0x0011B7D8
		private void checkBoxChienLongdong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class18.int_1 = -1;
				Form1.int_115 = (int)Convert.ToByte(this.checkBoxChienLongdong.Checked);
				Class62.smethod_10(Class53.string_3, "flagDanhChienlongdong", Form1.int_115, "", 0);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0011D63C File Offset: 0x0011B83C
		private void comboBoxCLD_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				string text = this.comboBoxCLD.Text;
				for (int i = 0; i < Class18.string_1.Length; i++)
				{
					bool flag2 = text == Class18.string_1[i];
					if (flag2)
					{
						bool flag3 = Class18.int_0 != i;
						if (flag3)
						{
							Class18.int_0 = i;
							Class62.smethod_10(Class53.string_3, "IndexChienlongdong", Class18.int_0, "", 0);
						}
						break;
					}
				}
			}
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0011D6DC File Offset: 0x0011B8DC
		private void method_18(ListView listView_0, int int_149 = 0)
		{
			bool flag = listView_0.Items == null;
			if (!flag)
			{
				int count = listView_0.Items.Count;
				bool flag2 = count != 0;
				if (flag2)
				{
					bool flag3 = int_149 >= count;
					if (flag3)
					{
						int_149 = count - 1;
					}
					listView_0.TopItem = listView_0.Items[int_149];
					listView_0.Items[int_149].Focused = true;
					listView_0.Items[int_149].Selected = true;
				}
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0011D758 File Offset: 0x0011B958
		private void method_19(ListView listView_0, uint[] uint_3)
		{
			int num = 0;
			bool flag = listView_0.Items != null;
			if (flag)
			{
				num = listView_0.Items.Count;
			}
			string[] array = new string[]
			{
				num.ToString(),
				uint_3[0].ToString() + "," + uint_3[1].ToString()
			};
			ListViewItem listViewItem = new ListViewItem(array[0]);
			ListViewItem.ListViewSubItem item = new ListViewItem.ListViewSubItem(listViewItem, array[1]);
			listViewItem.SubItems.Add(item);
			listView_0.Items.Add(listViewItem);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0011D7E8 File Offset: 0x0011B9E8
		private void listViewTrain_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.listView1.Items == null;
			if (flag)
			{
				Form1.int_143 = -1;
			}
			else
			{
				Form1.int_143 = Class81.smethod_4(this.listViewTrain, e, 1);
			}
			bool flag2 = 0 <= Form1.int_143;
			if (flag2)
			{
				string text = this.listViewTrain.Items[Form1.int_143].SubItems[1].Text;
			}
			this.buttonXoaToadoTrain.Text = "Xóa (" + Form1.int_143.ToString() + ")";
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0011D87C File Offset: 0x0011BA7C
		private void buttonLayToadoTrain_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				int num2 = Class37.smethod_0(Form1.gstruct49_0[num]);
				bool flag2 = num2 != Form1.gstruct49_0[num].int_32 && Form1.gstruct49_0[num].int_32 > 0;
				if (flag2)
				{
					this.listViewTrain.Items.Clear();
					Form1.gstruct49_0[num].uint_0 = null;
				}
				Form1.gstruct49_0[num].int_32 = num2;
				this.textBoxMapName.Text = Class37.smethod_1(num2, true);
				uint[] array = Class36.smethod_30(Form1.gstruct49_0[num]);
				bool flag3 = Form1.gstruct49_0[num].uint_0 != null;
				if (flag3)
				{
					for (int i = 0; i < Form1.gstruct49_0[num].uint_0.GetLength(0); i++)
					{
						bool flag4 = Form1.gstruct49_0[num].uint_0[i, 0] == array[0] && Form1.gstruct49_0[num].uint_0[i, 1] == array[1];
						if (flag4)
						{
							return;
						}
					}
				}
				Class12.smethod_54(ref Form1.gstruct49_0[num].uint_0, array);
				this.method_19(this.listViewTrain, array);
				bool flag5 = 0 <= Form1.int_143 && Form1.int_143 < this.listViewTrain.Items.Count;
				if (flag5)
				{
					this.listViewTrain.Items[Form1.int_143].Selected = false;
					this.listViewTrain.Items[Form1.int_143].Focused = false;
				}
				Form1.int_143 = this.listViewTrain.Items.Count - 1;
				this.method_18(this.listViewTrain, Form1.int_143);
				Class53.smethod_13(Form1.gstruct49_0[num], null);
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0011DA98 File Offset: 0x0011BC98
		private void buttonXoaToadoTrain_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				bool flag2 = Form1.int_143 < 0 || this.listViewTrain.Items == null || this.listViewTrain.Items.Count <= 0;
				if (flag2)
				{
					Form1.int_143 = -1;
				}
				else
				{
					string[] array = this.listViewTrain.Items[Form1.int_143].SubItems[1].Text.Split(new char[]
					{
						','
					});
					bool flag3 = array.Length < 2;
					if (!flag3)
					{
						uint[] uint_ = new uint[]
						{
							Class12.smethod_12(array[0]),
							Class12.smethod_12(array[1])
						};
						this.listViewTrain.Items.RemoveAt(Form1.int_143);
						Class12.smethod_55(ref Form1.gstruct49_0[num].uint_0, uint_);
						bool flag4 = Form1.gstruct49_0[num].uint_0 != null && this.listViewTrain.Items.Count != 0;
						if (flag4)
						{
							for (int i = 0; i < this.listViewTrain.Items.Count; i++)
							{
								this.listViewTrain.Items[i].SubItems[0].Text = i.ToString();
							}
							bool flag5 = this.listViewTrain.Items.Count <= Form1.int_143;
							if (flag5)
							{
								Form1.int_143 = this.listViewTrain.Items.Count - 1;
							}
							this.listViewTrain.Items[Form1.int_143].Focused = true;
							this.listViewTrain.Items[Form1.int_143].Selected = true;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
						}
						else
						{
							this.listViewTrain.Items.Clear();
							Form1.int_143 = -1;
						}
					}
				}
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0011DCBC File Offset: 0x0011BEBC
		private void checkBoxTrain_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_25 = (int)Convert.ToByte(this.checkBoxTrain.Checked);
					Form1.gstruct49_0[num].bool_11 = true;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0011DD4C File Offset: 0x0011BF4C
		private void checkBoxNhatdoDichuyenGan_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_51 = (int)Convert.ToByte(this.checkBoxNhatdoDichuyenGan.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0011DDCC File Offset: 0x0011BFCC
		private void buttonDoctep_Click(object sender, EventArgs e)
		{
			string text = Class53.string_8 + "\\Toado";
			Class12.smethod_23(text);
			string a = Class53.smethod_26(text, "", "*.xyz", "");
			bool flag = a == string.Empty;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.int_143 = -1;
					this.listViewTrain.Items.Clear();
					Form1.bool_9 = false;
					string text2 = Class12.smethod_15(Class12.smethod_33(a, 0, 0, 1));
					bool flag3 = !(text2 == string.Empty);
					if (flag3)
					{
						string[] array = text2.Split(new char[]
						{
							'|'
						});
						bool flag4 = array.Length >= 2;
						if (flag4)
						{
							Form1.gstruct49_0[num].int_32 = Class12.smethod_11(array[0]);
							bool flag5 = Form1.gstruct49_0[num].int_32 != 0;
							if (flag5)
							{
								Form1.gstruct49_0[num].uint_0 = null;
								string[] array2 = array[1].Split(new char[]
								{
									':'
								});
								bool flag6 = array2 != null && array2.Length != 0;
								if (flag6)
								{
									Form1.gstruct49_0[num].uint_0 = new uint[array2.Length, 2];
									for (int i = 0; i < array2.Length; i++)
									{
										string[] array3 = array2[i].Split(new char[]
										{
											';'
										});
										bool flag7 = array3.Length == 2;
										if (flag7)
										{
											for (int j = 0; j < 2; j++)
											{
												Form1.gstruct49_0[num].uint_0[i, j] = Class12.smethod_12(array3[j]);
											}
										}
									}
								}
								this.textBoxMapName.Text = Class37.smethod_1(Form1.gstruct49_0[num].int_32, true);
								bool flag8 = Form1.gstruct49_0[num].uint_0 != null;
								if (flag8)
								{
									for (int k = 0; k < Form1.gstruct49_0[num].uint_0.GetLength(0); k++)
									{
										this.method_19(this.listViewTrain, new uint[]
										{
											Form1.gstruct49_0[num].uint_0[k, 0],
											Form1.gstruct49_0[num].uint_0[k, 1]
										});
									}
								}
								Form1.bool_9 = true;
								return;
							}
						}
					}
					Form1.gstruct49_0[num].int_32 = 0;
					Form1.gstruct49_0[num].uint_0 = null;
					this.textBoxMapName.Text = string.Empty;
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0011E0B0 File Offset: 0x0011C2B0
		private void buttonLuutep_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string text = Class53.string_8 + "\\Toado";
				Class12.smethod_23(text);
				string a = Class53.smethod_27(text, Class10.smethod_1(gstruct.string_22, 1, false) + ".xyz");
				bool flag2 = a == string.Empty;
				if (!flag2)
				{
					string text2 = string.Empty;
					bool flag3 = gstruct.uint_0 != null;
					if (flag3)
					{
						for (int i = 0; i < gstruct.uint_0.GetLength(0); i++)
						{
							bool flag4 = text2 != string.Empty;
							if (flag4)
							{
								text2 += ":";
							}
							object obj = text2;
							text2 = string.Concat(new object[]
							{
								obj,
								gstruct.uint_0[i, 0],
								";",
								gstruct.uint_0[i, 1]
							});
						}
					}
					string text3 = gstruct.int_32.ToString() + "|" + text2;
					Class12.smethod_34(a, Class12.smethod_16(text3), 2);
				}
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0011E210 File Offset: 0x0011C410
		private void buttonApdungAllTrain_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				bool flag2 = Form1.gstruct49_0[num].int_60 == null;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_60 = new int[2];
				}
				bool flag3 = Form1.gstruct49_0[num].int_53 == null;
				if (flag3)
				{
					Form1.gstruct49_0[num].int_53 = new int[5];
				}
				GStruct49 gstruct = Form1.gstruct49_0[num];
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag4 = i == num;
					if (!flag4)
					{
						Form1.gstruct49_0[i].int_32 = gstruct.int_32;
						Form1.gstruct49_0[i].uint_0 = null;
						Form1.gstruct49_0[i].int_33 = gstruct.int_33;
						Form1.gstruct49_0[i].int_57 = gstruct.int_57;
						Form1.gstruct49_0[i].int_59 = gstruct.int_59;
						Form1.gstruct49_0[i].int_60 = new int[]
						{
							gstruct.int_60[0],
							gstruct.int_60[1]
						};
						Form1.gstruct49_0[i].int_19 = gstruct.int_19;
						Form1.gstruct49_0[i].int_18 = gstruct.int_18;
						Form1.gstruct49_0[i].int_61 = gstruct.int_61;
						Form1.gstruct49_0[i].int_51 = gstruct.int_51;
						Form1.gstruct49_0[i].int_52 = gstruct.int_52;
						Form1.gstruct49_0[i].int_40 = gstruct.int_40;
						Form1.gstruct49_0[i].int_62 = gstruct.int_62;
						Form1.gstruct49_0[i].int_53 = new int[5];
						for (int j = 0; j < 5; j++)
						{
							Form1.gstruct49_0[i].int_53[j] = gstruct.int_53[j];
						}
						Form1.gstruct49_0[i].uint_0 = null;
						bool flag5 = gstruct.uint_0 != null;
						if (flag5)
						{
							Form1.gstruct49_0[i].uint_0 = new uint[gstruct.uint_0.GetLength(0), 2];
							for (int k = 0; k < gstruct.uint_0.GetLength(0); k++)
							{
								Form1.gstruct49_0[i].uint_0[k, 0] = gstruct.uint_0[k, 0];
								Form1.gstruct49_0[i].uint_0[k, 1] = gstruct.uint_0[k, 1];
							}
						}
						Form1.gstruct49_0[i].int_25 = gstruct.int_25;
						Form1.gstruct49_0[i].int_26 = gstruct.int_26;
						Form1.gstruct49_0[i].int_28 = gstruct.int_28;
						Form1.gstruct49_0[i].int_29 = gstruct.int_29;
						Form1.gstruct49_0[i].int_27 = gstruct.int_27;
						Form1.gstruct49_0[i].int_30 = gstruct.int_30;
						Form1.gstruct49_0[i].int_31 = gstruct.int_31;
						Form1.gstruct49_0[i].bool_11 = true;
						Form1.gstruct49_0[i].int_38 = gstruct.int_38;
						Form1.gstruct49_0[i].int_37 = gstruct.int_37;
						Class53.smethod_13(Form1.gstruct49_0[i], null);
					}
				}
				this.method_2("Đã áp dụng mục Train cho tất cả ac (ngoại trừ mục Lượm rác)");
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0011E620 File Offset: 0x0011C820
		private void checkBoxTranhBossVang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_57 = (int)Convert.ToByte(this.checkBoxTranhBossVang.Checked);
					Form1.gstruct49_0[num].bool_11 = true;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0011E6B0 File Offset: 0x0011C8B0
		private void checkBoxTDPSaimap_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_59 = (int)Convert.ToByte(this.checkBoxTDPSaimap.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0011E730 File Offset: 0x0011C930
		private void checkBoxMuathuocPK_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].bool_5 = this.checkBoxMuathuocPK.Checked;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0011E7AC File Offset: 0x0011C9AC
		private void checkBoxChaydanhvong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].bool_4 = this.checkBoxChaydanhvong.Checked;
				}
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0011E814 File Offset: 0x0011CA14
		private void checkBoxChayPKNguoidung_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_34 = (int)Convert.ToByte(this.checkBoxChayPKNguoidung.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class65.int_0 = Form1.gstruct49_0[num].int_136;
				}
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0011E8A8 File Offset: 0x0011CAA8
		private void comboBoxDoSatcuuSat_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxDoSatcuuSat.Text;
					for (int i = 0; i < Form1.string_33.Length; i++)
					{
						bool flag3 = text == Form1.string_33[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_33 = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0011E95C File Offset: 0x0011CB5C
		private void buttonXoaIDAcChinh_Click(object sender, EventArgs e)
		{
			this.comboBoxAccChinh.Items.Clear();
			Class44.gstruct33_0.int_0 = 0;
			Form1.string_17 = string.Empty;
			Form1.int_52 = 0;
			Class62.smethod_10(Class53.string_3, "AccChinhNameA", string.Empty, "", 0);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0011E9B4 File Offset: 0x0011CBB4
		private void buttonBaoToado_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				uint[] array = Class36.smethod_30(gstruct);
				int num2 = Class37.smethod_0(gstruct);
				int num3 = num2;
				string text;
				if (num3 != 321)
				{
					if (num3 != 322)
					{
						text = Class37.smethod_2(gstruct);
					}
					else
					{
						text = "Tr­êng B¹ch s¬n B¾c";
					}
				}
				else
				{
					text = "Tr­êng B¹ch s¬n Nam";
				}
				string text2 = string.Concat(new string[]
				{
					"§ang ë (",
					(array[0] / 256U).ToString(),
					",",
					(array[1] / 512U).ToString(),
					") ",
					text
				});
				Class70.smethod_55(gstruct, text2, "CH_CHATROOM");
				Class70.smethod_55(gstruct, text2, "CH_TONG");
				try
				{
					Clipboard.SetText(Class10.smethod_1(text2, 1, false));
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0011EAD4 File Offset: 0x0011CCD4
		private void buttonHDD_Click(object sender, EventArgs e)
		{
			bool flag = Dangky.int_0 > 0;
			if (flag)
			{
				Dangky.int_0 = 0;
			}
			else
			{
				new Dangky().Show();
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0011EB04 File Offset: 0x0011CD04
		private void method_20()
		{
			bool flag = FormRauria.bool_0;
			if (flag)
			{
				FormRauria.bool_0 = false;
			}
			else
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					FormRauria.int_0 = Form1.gstruct49_0[num].int_136;
					FormRauria.string_0 = Class77.smethod_18(Form1.gstruct49_0[num], null);
				}
				else
				{
					FormRauria.int_0 = 0;
					FormRauria.string_0 = null;
				}
				try
				{
					new FormRauria
					{
						int_2 = base.Left,
						int_3 = base.Top,
						int_4 = base.Width,
						int_5 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0011EBDC File Offset: 0x0011CDDC
		private void buttonMorong_Click(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0011EBDC File Offset: 0x0011CDDC
		private void richTextBoxChedoMayphu_MouseClick(object sender, MouseEventArgs e)
		{
			this.method_20();
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0011EBE8 File Offset: 0x0011CDE8
		private void buttonUuTien_Click(object sender, EventArgs e)
		{
			bool flag = FormUutienNguHanh.int_0 > 0;
			if (flag)
			{
				FormUutienNguHanh.int_0 = 0;
			}
			else
			{
				int num = -1;
				int num2 = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num2 < 0;
				if (flag2)
				{
					string text = this.comboBoxUuTien.Text;
					for (int i = 0; i < Form1.string_25.Length; i++)
					{
						bool flag3 = text == Form1.string_25[i];
						if (flag3)
						{
							num = i;
							break;
						}
					}
					bool flag4 = num < 0 || num > 0;
					if (flag4)
					{
						return;
					}
				}
				else
				{
					num = Form1.gstruct49_0[num2].int_88;
				}
				bool flag5 = num <= 0;
				if (flag5)
				{
					bool flag6 = FormTuychon.bool_0;
					if (flag6)
					{
						FormTuychon.bool_0 = false;
					}
					else
					{
						try
						{
							FormTuychon.int_1 = 3;
							FormTuychon formTuychon = new FormTuychon();
							formTuychon.Show();
						}
						catch
						{
						}
					}
				}
				else
				{
					try
					{
						FormUutienNguHanh.int_0 = Form1.gstruct49_0[num2].int_136;
						FormUutienNguHanh.string_0 = Class77.smethod_18(Form1.gstruct49_0[num2], null);
						new FormUutienNguHanh
						{
							int_1 = base.Left,
							int_2 = base.Top
						}.Show();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0011ED5C File Offset: 0x0011CF5C
		private void checkBoxOluonMapphu_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_40 = (int)Convert.ToByte(this.checkBoxOluonMapphu.Checked);
					Class62.smethod_10(Class53.string_3, "flagOLuonMapPhu", Form1.int_40, "", 0);
				}
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0011EDC8 File Offset: 0x0011CFC8
		private void buttonBungTuimau_Click(object sender, EventArgs e)
		{
			bool flag = FormHaucanTuithuoc.bool_0;
			if (flag)
			{
				FormHaucanTuithuoc.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormHaucanTuithuoc.int_0 = Form1.gstruct49_0[num].int_136;
						new FormHaucanTuithuoc
						{
							int_2 = base.Left,
							int_3 = base.Top,
							int_4 = base.Width,
							int_5 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0011EE78 File Offset: 0x0011D078
		private void checkBoxVeThanhKhiPKlon_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_104[0] = (int)Convert.ToByte(this.checkBoxVeThanhKhiPKlon.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0011EEF8 File Offset: 0x0011D0F8
		private void buttonGiamCPUAll_Click(object sender, EventArgs e)
		{
			this.method_21(-1);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0011EF04 File Offset: 0x0011D104
		private void method_21(int int_149 = -1)
		{
			bool flag = Form1.int_144 > 0;
			if (!flag)
			{
				this.buttonGiamCPUAll.Enabled = false;
				bool flag2 = 0 <= int_149;
				if (flag2)
				{
					Form1.int_145 = int_149;
				}
				else
				{
					Form1.int_145 = 0;
					string text = this.comboBoxGiamCpu.Text;
					for (int i = 0; i < Form1.string_34.Length; i++)
					{
						bool flag3 = Form1.string_34[i] == text;
						if (flag3)
						{
							Form1.int_145 = i;
							break;
						}
					}
				}
				Form1.int_144 = 1;
				new Thread(new ThreadStart(this.method_22)).Start();
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0011EFAC File Offset: 0x0011D1AC
		private void method_22()
		{
			bool flag = Form1.gstruct49_0 == null;
			if (flag)
			{
				Form1.int_144 = 2;
			}
			else
			{
				for (;;)
				{
					try
					{
						bool flag2 = Form1.int_145 < 0;
						if (flag2)
						{
							Form1.int_145 = 0;
						}
						GStruct49 gstruct = default(GStruct49);
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							bool flag3 = Form1.gstruct49_0[i].int_136 == Class44.gstruct33_0.int_0;
							if (flag3)
							{
								Form1.gstruct49_0[i].int_89 = 0;
								gstruct = Form1.gstruct49_0[i];
								Class47.smethod_0(gstruct, 0, Form1.int_145);
								Class70.smethod_52(gstruct, "<color=green>Ac chÝnh: <color=red>T¾t", 1);
								Class53.smethod_13(gstruct, null);
							}
							else
							{
								Form1.gstruct49_0[i].int_89 = Form1.int_145;
								gstruct = Form1.gstruct49_0[i];
								Class47.smethod_0(gstruct, Form1.int_145, -1);
								Class53.smethod_13(gstruct, null);
							}
						}
					}
					catch
					{
						Thread.Sleep(100);
						continue;
					}
					break;
				}
				Form1.int_144 = 2;
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0011F0E0 File Offset: 0x0011D2E0
		private void comboBoxGiamCpu_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				int num2 = -1;
				string text = this.comboBoxGiamCpu.Text;
				for (int i = 0; i < Form1.string_34.Length; i++)
				{
					bool flag2 = Form1.string_34[i] == text;
					if (flag2)
					{
						num2 = i;
						break;
					}
				}
				bool flag3 = num2 != Form1.gstruct49_0[num].int_89;
				if (flag3)
				{
					Form1.gstruct49_0[num].int_89 = num2;
					GStruct49 gstruct = Form1.gstruct49_0[num];
					Class47.smethod_0(gstruct, num2, -1);
					Class53.smethod_13(gstruct, null);
				}
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0011F1A8 File Offset: 0x0011D3A8
		private void checkBoxDameMacdinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				FormDame.int_7 = (int)Convert.ToByte(this.checkBoxDameMacdinh.Checked);
				FormDame.int_6 = FormDame.int_7;
				Class62.smethod_10(Class53.string_3, "flagDameMacdinh", FormDame.int_6, "", 0);
				bool flag2 = FormDame.int_6 > 0 && Form1.int_63 <= 0;
				if (flag2)
				{
					Form1.int_63 = 1;
					GClass0.smethod_0();
					this.checkBoxPhimTat.Checked = true;
				}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0011F248 File Offset: 0x0011D448
		private void buttonDame_Click(object sender, EventArgs e)
		{
			bool flag = FormDame.bool_0;
			if (flag)
			{
				FormDame.bool_0 = false;
			}
			else
			{
				try
				{
					FormDame.int_5 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormDame.int_5 = Form1.gstruct49_0[num].int_136;
					}
					new FormDame
					{
						int_1 = Cursor.Position.X,
						int_2 = Cursor.Position.Y,
						int_3 = base.Width,
						int_4 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0011F310 File Offset: 0x0011D510
		private void buttonAnhet_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(this.method_23)).Start();
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0011F32C File Offset: 0x0011D52C
		private void method_23()
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					try
					{
						bool flag2 = Form1.gstruct49_0[i].int_136 != Class44.gstruct33_0.int_0;
						if (flag2)
						{
							int num = 0;
							while (Form1.uint_0 != 0U && num < 30)
							{
								Thread.Sleep(10);
								num++;
							}
							Form1.uint_0 = Form1.gstruct49_0[i].uint_4;
							new Thread(new ThreadStart(this.method_9)).Start();
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0011F3FC File Offset: 0x0011D5FC
		private void checkBoxTuChayBoss_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].bool_1 = this.checkBoxTuChayBoss.Checked;
					}
				}
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0011F470 File Offset: 0x0011D670
		private void buttonSuaXoa_Click(object sender, EventArgs e)
		{
			bool flag = FormChayBoss.bool_0;
			if (flag)
			{
				FormChayBoss.bool_0 = false;
			}
			else
			{
				try
				{
					new FormChayBoss
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0011F4E8 File Offset: 0x0011D6E8
		private int method_24()
		{
			string text = this.comboBoxNoiBoss.Text;
			bool flag = FormChayBoss.string_2 != null;
			if (flag)
			{
				for (int i = 0; i < FormChayBoss.string_2.GetLength(0); i++)
				{
					bool flag2 = text == FormChayBoss.string_2[i, 0];
					if (flag2)
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0011F550 File Offset: 0x0011D750
		private void buttonBossAll_Click(object sender, EventArgs e)
		{
			int num = -1;
			bool @checked;
			bool flag = @checked = this.checkBoxTuChayBoss.Checked;
			if (@checked)
			{
				num = this.method_24();
			}
			bool flag2 = Form1.gstruct49_0 == null;
			if (!flag2)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool bool_ = Form1.gstruct49_0[i].bool_25;
					if (bool_)
					{
						Form1.gstruct49_0[i].int_0 = num;
						Form1.gstruct49_0[i].bool_1 = flag;
					}
				}
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0011F5E4 File Offset: 0x0011D7E4
		private void comboBoxNoiBoss_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						int num2 = this.method_24();
						Form1.gstruct49_0[num].int_0 = num2;
						this.buttonDenDiemKetiep.Text = string.Concat(new string[]
						{
							"Đến điểm kế tiếp",
							Class53.string_7,
							"( ",
							(num2 + 1).ToString(),
							" )"
						});
					}
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0011F6A4 File Offset: 0x0011D8A4
		private void buttonMoGame_Click(object sender, EventArgs e)
		{
			Class97.smethod_1();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0011F6B0 File Offset: 0x0011D8B0
		private void textBoxPhamviNhat_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_52 = Class12.smethod_11(this.textBoxPhamviNhat.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0011F730 File Offset: 0x0011D930
		private void checkBoxLuomrac_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.gstruct49_0[num].int_54 = (int)Convert.ToByte(this.checkBoxLuomrac.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					bool flag3 = Form1.gstruct49_0[num].int_54 <= 0;
					if (!flag3)
					{
						bool flag4 = FormLuomrac.bool_0;
						if (flag4)
						{
							FormLuomrac.bool_0 = false;
						}
						else
						{
							try
							{
								FormLuomrac.int_0 = Form1.gstruct49_0[num].int_136;
								new FormLuomrac
								{
									int_1 = Cursor.Position.X,
									int_2 = Cursor.Position.Y,
									int_3 = base.Width,
									int_4 = base.Height
								}.Show();
							}
							catch
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0011F86C File Offset: 0x0011DA6C
		private void checkBoxSLThoat_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_19 = (int)Convert.ToByte(this.checkBoxSLThoat.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0011F8EC File Offset: 0x0011DAEC
		private void textBoxSLThoat_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_18 = Class12.smethod_11(this.textBoxSLThoat.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0011F96C File Offset: 0x0011DB6C
		private void comboBoxXuongNgua_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxXuongNgua.Text;
					for (int i = 0; i < Form1.string_26.Length; i++)
					{
						bool flag3 = text == Form1.string_26[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_93 = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							bool flag4 = i == 0 && !Class36.smethod_19(Form1.gstruct49_0[num]);
							if (flag4)
							{
								Class70.smethod_57(Form1.gstruct49_0[num], "Switch([[horse]])");
							}
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0011FA5C File Offset: 0x0011DC5C
		private void checkBoxPheThu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_25 = (int)Convert.ToByte(this.checkBoxPheThu.Checked);
				}
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0011FAA8 File Offset: 0x0011DCA8
		private void checkBoxAnThuocTDD_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_64[0] = (int)Convert.ToByte(this.checkBoxAnThuocTDD.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0011FB38 File Offset: 0x0011DD38
		private void textBoxTocdoDanh_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_64[1] = Class12.smethod_11(this.textBoxTocdoDanh.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0011FBB8 File Offset: 0x0011DDB8
		private void buttonThuocTDD_Click(object sender, EventArgs e)
		{
			bool flag = FormThuocTocdoDanh.bool_0;
			if (flag)
			{
				FormThuocTocdoDanh.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormThuocTocdoDanh.int_0 = Form1.gstruct49_0[num].int_136;
						new FormThuocTocdoDanh
						{
							int_2 = Cursor.Position.X,
							int_3 = Cursor.Position.Y,
							int_4 = base.Width,
							int_5 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0011FC7C File Offset: 0x0011DE7C
		private void buttonThuocLag_Click(object sender, EventArgs e)
		{
			bool flag = FormThuocLag.bool_0;
			if (flag)
			{
				FormThuocLag.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormThuocLag.int_0 = Form1.gstruct49_0[num].int_136;
						new FormThuocLag
						{
							int_2 = Cursor.Position.X,
							int_3 = Cursor.Position.Y,
							int_4 = base.Width,
							int_5 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0011FD40 File Offset: 0x0011DF40
		private void buttonPhimHDCTC_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/5H9Ita4GE9k?t=473";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0011FD68 File Offset: 0x0011DF68
		private void comboBoxTenHieuThuocTamtru_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				Form1.bool_9 = false;
				this.comboBoxTenHieuThuocTamtru.Items.Clear();
				Form1.string_46 = null;
				Class98.smethod_25(Form1.gstruct49_0[num], ref Form1.string_46, 3, null);
				bool flag2 = Form1.string_46 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.string_46.Length; i++)
					{
						this.comboBoxTenHieuThuocTamtru.Items.Add(Class10.smethod_1(Form1.string_46[i], 1, false));
					}
				}
				Thread.Sleep(10);
				Form1.bool_9 = true;
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0011FE24 File Offset: 0x0011E024
		private void comboBoxTenHieuThuocTamtru_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_46 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					bool flag3 = false;
					string text = this.comboBoxTenHieuThuocTamtru.Text;
					for (int i = 0; i < Form1.string_46.Length; i++)
					{
						bool flag4 = text == Class10.smethod_1(Form1.string_46[i], 1, false);
						if (flag4)
						{
							Class38.string_0 = Form1.string_46[i];
							Class62.smethod_10(Class53.string_3, "TenHieuthuocTamtru", Class38.string_0, "", 0);
							flag3 = true;
							break;
						}
					}
					bool flag5 = flag3;
					if (flag5)
					{
						int num2 = Class98.smethod_13(Form1.gstruct49_0[num], Class38.string_0, 3, false, -1, 80);
						Class38.uint_0 = Class98.smethod_19(Form1.gstruct49_0[num], num2);
						bool flag6 = Class38.uint_0 == null;
						if (flag6)
						{
							Class38.uint_0 = new uint[2];
						}
						this.textBoxToadoHieuthuocTamtru.Text = Class38.uint_0[0].ToString() + "," + Class38.uint_0[1].ToString();
						Class62.smethod_10(Class53.string_3, "ToadoHieuthuocTamtru_0", Class38.uint_0[0], "", 0);
						Class62.smethod_10(Class53.string_3, "ToadoHieuthuocTamtru_1", Class38.uint_0[1], "", 0);
					}
				}
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0011FFCC File Offset: 0x0011E1CC
		private void buttonLayvitriCongTamtru_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				Class38.uint_1 = Class36.smethod_30(Form1.gstruct49_0[num]);
				this.textBoxCongTamtru.Text = Class38.uint_1[0].ToString() + "," + Class38.uint_1[1].ToString();
				Class62.smethod_10(Class53.string_3, "ToadoCongTamtru_0", Class38.uint_1[0], "", 0);
				Class62.smethod_10(Class53.string_3, "ToadoCongTamtru_1", Class38.uint_1[1], "", 0);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00120090 File Offset: 0x0011E290
		private void buttonPhimHdTamtru_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/NHJWNV6zKJI";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x001200B8 File Offset: 0x0011E2B8
		private void checkBoxTDP_SL_Mau_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_115 = (int)Convert.ToByte(this.checkBoxTDP_SL_Mau.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00120138 File Offset: 0x0011E338
		private void checkBoxTDP_SL_Mana_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_117 = (int)Convert.ToByte(this.checkBoxTDP_SL_Mana.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x001201B8 File Offset: 0x0011E3B8
		private void textBoxTDP_SL_Mau_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_116 = Class12.smethod_11(this.textBoxTDP_SL_Mau.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00120238 File Offset: 0x0011E438
		private void textBoxTDP_SL_Mana_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_118 = Class12.smethod_11(this.textBoxTDP_SL_Mana.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x001202B8 File Offset: 0x0011E4B8
		private void comboBoxTenMau2_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.bool_9 = false;
					Form1.string_47 = Class79.smethod_34(Form1.gstruct49_0[num], null, 3);
					this.comboBoxTenMau2.Items.Clear();
					bool flag3 = Form1.string_47 != null;
					if (flag3)
					{
						Array.Sort<string>(Form1.string_47);
						for (int i = 0; i < Form1.string_47.Length; i++)
						{
							this.comboBoxTenMau2.Items.Add(Class10.smethod_1(Form1.string_47[i], 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x001203A0 File Offset: 0x0011E5A0
		private void comboBoxTenMana2_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.bool_9 = false;
					Form1.string_48 = Class79.smethod_34(Form1.gstruct49_0[num], null, 3);
					this.comboBoxTenMana2.Items.Clear();
					bool flag3 = Form1.string_48 != null;
					if (flag3)
					{
						Array.Sort<string>(Form1.string_48);
						for (int i = 0; i < Form1.string_48.Length; i++)
						{
							this.comboBoxTenMana2.Items.Add(Class10.smethod_1(Form1.string_48[i], 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00120488 File Offset: 0x0011E688
		private void comboBoxTenMau2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_47 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenMau2.Text;
					bool flag3 = !(text == string.Empty);
					if (flag3)
					{
						for (int i = 0; i < Form1.string_47.Length; i++)
						{
							bool flag4 = text == Class10.smethod_1(Form1.string_47[i], 1, false);
							if (flag4)
							{
								Form1.gstruct49_0[num].string_16 = Form1.string_47[i];
								Class53.smethod_13(Form1.gstruct49_0[num], null);
								break;
							}
						}
					}
					else
					{
						Form1.gstruct49_0[num].string_16 = string.Empty;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00120594 File Offset: 0x0011E794
		private void comboBoxTenMana2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_48 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxTenMana2.Text;
					bool flag3 = !(text == string.Empty);
					if (flag3)
					{
						for (int i = 0; i < Form1.string_48.Length; i++)
						{
							bool flag4 = text == Class10.smethod_1(Form1.string_48[i], 1, false);
							if (flag4)
							{
								Form1.gstruct49_0[num].string_17 = Form1.string_48[i];
								Class53.smethod_13(Form1.gstruct49_0[num], null);
								break;
							}
						}
					}
					else
					{
						Form1.gstruct49_0[num].string_17 = string.Empty;
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x001206A0 File Offset: 0x0011E8A0
		private void checkBoxMau2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_110[0] = (int)Convert.ToByte(this.checkBoxMau2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00120720 File Offset: 0x0011E920
		private void textBoxRatioMau2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_110[1] = Class12.smethod_11(this.textBoxRatioMau2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x001207A0 File Offset: 0x0011E9A0
		private void textBoxTimerMau2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_110[2] = Class12.smethod_11(this.textBoxTimerMau2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00120820 File Offset: 0x0011EA20
		private void textBoxSoluongMau2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_110[3] = Class12.smethod_11(this.textBoxSoluongMau2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x001208A0 File Offset: 0x0011EAA0
		private void checkBoxMana2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_112[0] = (int)Convert.ToByte(this.checkBoxMana2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00120920 File Offset: 0x0011EB20
		private void textBoxRatioMana2_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_112[1] = Class12.smethod_11(this.textBoxRatioMana2.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x001209B0 File Offset: 0x0011EBB0
		private void textBoxTimerMana2_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_112[2] = Class12.smethod_11(this.textBoxTimerMana2.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00120A40 File Offset: 0x0011EC40
		private void textBoxSoluongMana2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_112[3] = Class12.smethod_11(this.textBoxSoluongMana2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00120AC0 File Offset: 0x0011ECC0
		private void checkBoxDuongMonBoom_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_128[0] = (int)Convert.ToByte(this.checkBoxDuongMonBoom.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00120B40 File Offset: 0x0011ED40
		private void buttonThietLapDuongMon_Click(object sender, EventArgs e)
		{
			bool flag = FormDuongMon.bool_0;
			if (flag)
			{
				FormDuongMon.bool_0 = false;
			}
			else
			{
				try
				{
					int num = -1;
					int num2 = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num2;
					if (flag2)
					{
						string a = Class77.smethod_18(Form1.gstruct49_0[num2], null);
						bool flag3 = a == "DUONGMON";
						if (flag3)
						{
							num = Form1.gstruct49_0[num2].int_136;
						}
					}
					bool flag4 = num <= 0 && Form1.gstruct49_0 != null;
					if (flag4)
					{
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							string a2 = Class77.smethod_18(Form1.gstruct49_0[i], null);
							bool flag5 = a2 == "DUONGMON";
							if (flag5)
							{
								num = Form1.gstruct49_0[i].int_136;
								break;
							}
						}
					}
					FormDuongMon.int_2 = num;
					new FormDuongMon
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00120C94 File Offset: 0x0011EE94
		private void checkBoxUuTienBomCuuchuyen_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_108 = (int)Convert.ToByte(this.checkBoxUuTienBomCuuchuyen.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00120D20 File Offset: 0x0011EF20
		private void checkBoxOtrong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_60[0] = (int)Convert.ToByte(this.checkBoxOtrong.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00120DA0 File Offset: 0x0011EFA0
		private void comboBoxOtrong_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxOtrong.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < Form1.string_24.Length;
						if (!flag3)
						{
							goto IL_81;
						}
						bool flag4 = text == Form1.string_24[num2];
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].int_60[1] = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_81:;
				}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00120E5C File Offset: 0x0011F05C
		private void buttonThoatHetgame_Click(object sender, EventArgs e)
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
						break;
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00121000 File Offset: 0x0011F200
		private void comboBoxTrangbiTest_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					this.comboBoxTrangbiTest.Items.Clear();
					Form1.string_18 = null;
					GStruct49 gstruct = Form1.gstruct49_0[num];
					Form1.bool_9 = false;
					bool flag3 = FormLocdoTest.int_4 > 0;
					if (flag3)
					{
						Class98.smethod_25(gstruct, ref Form1.string_18, 3, null);
					}
					else
					{
						Form1.string_18 = Class79.smethod_34(gstruct, null, 3);
					}
					bool flag4 = Form1.string_18 != null;
					if (flag4)
					{
						Array.Sort<string>(Form1.string_18);
						for (int i = 0; i < Form1.string_18.Length; i++)
						{
							this.comboBoxTrangbiTest.Items.Add(Class10.smethod_1(Form1.string_18[i], 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00121110 File Offset: 0x0011F310
		private void comboBoxTrangbiTest_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				string text = this.comboBoxTrangbiTest.Text;
				int num = 0;
				for (;;)
				{
					bool flag2 = num < Form1.string_18.Length;
					if (!flag2)
					{
						goto IL_68;
					}
					bool flag3 = text == Class10.smethod_1(Form1.string_18[num], 1, false);
					if (flag3)
					{
						break;
					}
					num++;
				}
				FormLocdoTest.string_0 = Form1.string_18[num];
				Class62.smethod_10(Class53.string_3, "TenVatPhamNhanTrangbiTest", Class12.smethod_16(FormLocdoTest.string_0), "", 0);
				IL_68:;
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x001211B8 File Offset: 0x0011F3B8
		private void buttonTatcaNhanTrangbiTest_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null && FormLocdoTest.string_0 != null;
			if (flag)
			{
				bool flag2 = FormLocdoTest.string_0 == string.Empty;
				if (!flag2)
				{
					int num = Class12.smethod_11(this.textBoxLocTocdo.Text);
					try
					{
						int i = 0;
						while (i < Form1.gstruct49_0.Length)
						{
							bool flag3 = !Form1.gstruct49_0[i].bool_25;
							if (flag3)
							{
								Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_10, 0, 4);
							}
							else
							{
								bool flag4 = Class70.smethod_3(Form1.gstruct49_0[i], Class70.uint_10, 4) > 0;
								if (!flag4)
								{
									Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_10, 1, 4);
									Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_11, num, 4);
									Form1.gstruct49_0[i].int_11 = num;
									int num2 = 0;
									for (;;)
									{
										bool flag5 = num2 >= 50;
										if (flag5)
										{
											break;
										}
										bool flag6 = FormLocdoTest.int_1 <= 0;
										if (flag6)
										{
											break;
										}
										Thread.Sleep(10);
										num2++;
									}
									IL_13B:
									FormLocdoTest.int_1 = Form1.gstruct49_0[i].int_136;
									new Thread(new ThreadStart(FormLocdoTest.smethod_2)).Start();
									goto IL_169;
									goto IL_13B;
								}
							}
							IL_16A:
							i++;
							continue;
							IL_169:
							goto IL_16A;
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00121370 File Offset: 0x0011F570
		private void buttonDungTatcaTrangbiTest_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_10, 0, 4);
				}
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x001213BC File Offset: 0x0011F5BC
		private void buttonNhanTrangbiTest_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					bool flag3 = !gstruct.bool_25;
					if (flag3)
					{
						Class70.smethod_2(gstruct, Class70.uint_10, 0, 4);
					}
					else
					{
						bool flag4 = Class70.smethod_3(gstruct, Class70.uint_10, 4) <= 0;
						if (flag4)
						{
							Class70.smethod_2(gstruct, Class70.uint_10, 1, 4);
							Class70.smethod_2(gstruct, Class70.uint_11, gstruct.int_11, 4);
							FormLocdoTest.int_1 = gstruct.int_136;
							new Thread(new ThreadStart(FormLocdoTest.smethod_2)).Start();
						}
					}
				}
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0012149C File Offset: 0x0011F69C
		private void buttonLocTrangbi_Click(object sender, EventArgs e)
		{
			bool flag = FormLocdoTest.bool_2;
			if (flag)
			{
				FormLocdoTest.bool_2 = false;
			}
			else
			{
				try
				{
					FormLocdoTest.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormLocdoTest.int_0 = Form1.gstruct49_0[num].int_136;
					}
					new FormLocdoTest
					{
						int_14 = base.Left,
						int_15 = base.Top,
						int_16 = base.Width,
						int_17 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00121554 File Offset: 0x0011F754
		private void buttonPhimHDLoc_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/Dup5PcJOV5Y";
			string text2 = "https://youtu.be/Gq7CMQV16Fg";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
			string text3 = string.Concat(new string[]
			{
				"Xem 2 video hướng dẫn tại: ",
				Class53.string_7,
				text,
				Class53.string_7,
				text2
			});
			FormTip.smethod_0(Form1.string_1, text3, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x001215CC File Offset: 0x0011F7CC
		private void buttonThietlapClickNpc_Click(object sender, EventArgs e)
		{
			bool flag = FormClickNPC.bool_0;
			if (flag)
			{
				FormClickNPC.bool_0 = false;
			}
			else
			{
				try
				{
					FormClickNPC.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormClickNPC.int_0 = Form1.gstruct49_0[num].int_136;
					}
					new FormClickNPC
					{
						int_1 = base.Left,
						int_2 = base.Top,
						int_3 = base.Width,
						int_4 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00121684 File Offset: 0x0011F884
		private void checkBoxTongKimXemSoluong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_92 = (int)Convert.ToByte(this.checkBoxTongKimXemSoluong.Checked);
				Class62.smethod_10(Class53.string_3, "TongKimXemSoluong", Form1.int_92, "", 0);
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x001216E4 File Offset: 0x0011F8E4
		private void linkLabelTrangchu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = this.comboBoxGameOfWeb.Text;
			bool flag = text == "khác";
			if (!flag)
			{
				string[] array = text.Split(new char[]
				{
					'+',
					' ',
					','
				});
				string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
				bool flag2 = !Class12.smethod_17(text2);
				if (flag2)
				{
					text2 = Class62.smethod_0();
				}
				foreach (string text in array)
				{
					bool flag3 = text == string.Empty || text == null;
					if (!flag3)
					{
						text = text.Trim();
						bool flag4 = text.Length >= 6;
						if (flag4)
						{
							bool flag5 = Class12.smethod_1(text, "://") < 0;
							if (flag5)
							{
								text = "http://" + text;
							}
							Class22.smethod_40(text2, "", text, 0, false, false);
						}
					}
				}
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x001217E0 File Offset: 0x0011F9E0
		private void buttonHuongDan_Click(object sender, EventArgs e)
		{
			string text = "TRAIN:|Đem ac đến bãi cần train. Bấm nút lấy tọa độ train, tọa độ ở đây lấy theo đường thẳng, ac đi đến cuối sẽ đi ngược lại.|Check vào mục train. Xong bấm áp dụng tất cả ac.||NHỮNG LƯU Ý:||- Nếu ac chạy tới quái lại giựt về tọa độ train mà không đánh, là do Khoảng cách tìm ac chính quá thấp + giá trị Tiếp cận thấp, bạn chỉnh 2 cái này lên cao tí, hoặc bỏ đừng check vào tiếp cận.||- Khi ac về thành, sẽ tự bán đồ theo mục lọc đồ (của phần nhặt đồ, bảng 1. Yêu cầu: check vào phần nhặt đồ), bán đồ xong sẽ cất đồ. Sau đó tự mua máu theo phần Hậu cần rồi lên lại bãi.||- Ac sẽ tự lên bãi theo cách: Trở lại điểm cũ -> Nếu không thành công sẽ đi Xa phu nơi đi qua -> Nếu không thành công sẽ tiếp tục đi bằng Thần hành phù (do đó auto không cần thiết phải có mục đi xa phu).||- Chức năng TĐP khi còn bao nhiêu bình máu, mana trong mục Hậu cần vẫn áp dụng khi train.||- Với các bản đồ đặc biệt thì auto TĐP, ví dụ như Mạc Bắc Thảo Nguyên, Vi Sơn đảo... mà thay vào đó là chức năng tự chạy về mua thuốc khi hết thuốc.||- Thổ địa phù khi sai map: Nếu 2 map liên thông thì ac sẽ tự chạy vào map train (ví dụ La Tiêu Sơn -> Lưỡng Thủy động là liên thông), còn không liên thông thì ac sẽ thổ địa phù.||- Khoảng cách giữa ac chính và ac phụ dưới nút [A] của auto vẫn được áp dụng trong mục train này (không nhỏ hơn 150).||- Chức năng thoát game khi sinh lực thấp được chuyển qua tab Hậu cần, phục hồi|";
			FormTip.smethod_0(Form1.string_1, text, 600000, 400, 320, false, -1, -1, false, false, false);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00121818 File Offset: 0x0011FA18
		private void checkBoxRuong0_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_53 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_53 = new int[5];
					}
					Form1.gstruct49_0[num].int_53[0] = (int)Convert.ToByte(this.checkBoxRuong0.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x001218CC File Offset: 0x0011FACC
		private void checkBoxRuong1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_53 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_53 = new int[5];
					}
					Form1.gstruct49_0[num].int_53[1] = (int)Convert.ToByte(this.checkBoxRuong1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00121980 File Offset: 0x0011FB80
		private void checkBoxRuong2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_53 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_53 = new int[5];
					}
					Form1.gstruct49_0[num].int_53[2] = (int)Convert.ToByte(this.checkBoxRuong2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00121A34 File Offset: 0x0011FC34
		private void checkBoxRuong3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					bool flag3 = Form1.gstruct49_0[num].int_53 == null;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_53 = new int[5];
					}
					Form1.gstruct49_0[num].int_53[3] = (int)Convert.ToByte(this.checkBoxRuong3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00121AE8 File Offset: 0x0011FCE8
		private void buttonKhongcat_Click(object sender, EventArgs e)
		{
			bool flag = FormKhongCatdo.bool_0;
			if (flag)
			{
				FormKhongCatdo.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormKhongCatdo.int_0 = Form1.gstruct49_0[num].int_136;
						new FormKhongCatdo
						{
							int_2 = Cursor.Position.X,
							int_3 = Cursor.Position.Y,
							int_4 = base.Width,
							int_5 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00121BAC File Offset: 0x0011FDAC
		private void checkBoxXepdo_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_37 = (int)Convert.ToByte(this.checkBoxXepdo.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00121C2C File Offset: 0x0011FE2C
		private void buttonTimTrongthanh_Click(object sender, EventArgs e)
		{
			string text = "* Check vào Tìm ac chính: ac phụ sẽ tìm đi theo ac chính bất cứ nơi đâu.||* Ô kế bên tìm ac chính: giá trị biễu diễn khoảng cách sẽ tìm ac chính, nếu khoảng cách ac phụ và ac chính lớn hơn giá trị này thì ac phụ sẽ tiến hành tìm.||* Check vào Tìm trong thành: ac chính ở trong thành thì ac phụ cũng tìm theo.||* Khi săn boss hoặc pk nhau, thì lưu ý 2 điểm:|1. Nên bỏ check tìm trong thành: Vì nếu vẫn để tìm trong thành, mà ac chính lỡ chết thì ac phụ lại Thổ địa phù về hết.||2. Nên check vào mục <ưu tiên đi xa phu trước, thần hành phù sau> trong nút Mở rộng: Sẽ tiện lợi hơn khi check vào mục này, vì ac nếu có Thổ địa phù về thành thì sẽ quay lại điểm cũ từ xa phu, do đó sẽ tập trung nhanh hơn.|";
			FormTip.smethod_0(Form1.string_1, text, 600000, 370, 280, false, base.Left, base.Top, false, false, false);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00121C6C File Offset: 0x0011FE6C
		private void buttonLayVitriXaphuCTQ_Click(object sender, EventArgs e)
		{
			bool flag = FormXaphuCT.bool_0;
			if (flag)
			{
				FormXaphuCT.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormXaphuCT.int_0 = Form1.gstruct49_0[num].int_136;
						new FormXaphuCT
						{
							int_2 = base.Left,
							int_3 = base.Top,
							int_4 = base.Width,
							int_5 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00121D1C File Offset: 0x0011FF1C
		private void textBoxTimeXepdo_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_38 = Class12.smethod_11(this.textBoxTimeXepdo.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00121DA8 File Offset: 0x0011FFA8
		private void checkBoxNPC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_4 = (int)Convert.ToByte(this.checkBoxNPC.Checked);
				Class62.smethod_10(Class53.string_3, "flagCoClickVaoNPC", Form1.int_4, "", 0);
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00121E08 File Offset: 0x00120008
		private void textBoxOso1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_75[1] = Class12.smethod_11(this.textBoxOso1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00121E88 File Offset: 0x00120088
		private void textBoxOso2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_75[2] = Class12.smethod_11(this.textBoxOso2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00121F08 File Offset: 0x00120108
		private void textBoxOso3_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_75[3] = Class12.smethod_11(this.textBoxOso3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00121F88 File Offset: 0x00120188
		private void checkBoxGanTenthuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_75[0] = (int)Convert.ToByte(this.checkBoxGanTenthuoc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00122008 File Offset: 0x00120208
		private void buttonDenDiemKetiep_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || FormChayBoss.string_2 == null;
			if (!flag)
			{
				int num = -1;
				int length = FormChayBoss.string_2.GetLength(0);
				Form1.bool_9 = false;
				string text = this.comboBoxNoiBoss.Text;
				for (int i = 0; i < length; i++)
				{
					bool flag2 = text == FormChayBoss.string_2[i, 0];
					if (flag2)
					{
						num = i;
						break;
					}
				}
				int num2 = num + 1;
				bool flag3 = length <= num2;
				if (flag3)
				{
					num2 = 0;
				}
				int num3 = num2;
				int num4 = 0;
				while (FormChayBoss.string_2[num2, 0] == "...")
				{
					num2++;
					bool flag4 = length <= num2;
					if (flag4)
					{
						num2 = 0;
						num4 = 1;
					}
					bool flag5 = num4 > 0 && num3 <= num2;
					if (flag5)
					{
						break;
					}
				}
				this.comboBoxNoiBoss.Text = FormChayBoss.string_2[num2, 0];
				Thread.Sleep(100);
				bool flag6 = Form1.gstruct49_0 != null;
				if (flag6)
				{
					for (int j = 0; j < Form1.gstruct49_0.Length; j++)
					{
						Form1.gstruct49_0[j].int_0 = num2;
					}
				}
				this.buttonDenDiemKetiep.Text = string.Concat(new string[]
				{
					"Đến điểm kế tiếp",
					Class53.string_7,
					"( ",
					(num2 + 1).ToString(),
					" )"
				});
				Form1.bool_9 = true;
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x001221AC File Offset: 0x001203AC
		private void checkBoxTudongPT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_121[0] = (int)Convert.ToByte(this.checkBoxTudongPT.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0012222C File Offset: 0x0012042C
		private void checkBoxTucheHT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_26 = (int)Convert.ToByte(this.checkBoxTucheHT.Checked);
					this.checkBoxTDPHettien.Enabled = (Form1.gstruct49_0[num].int_26 > 0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x001222CC File Offset: 0x001204CC
		private void checkBoxTuGiaiBua_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_80 = (int)Convert.ToByte(this.checkBoxTuGiaiBua.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0012234C File Offset: 0x0012054C
		private void checkBoxTNXuatChieu120_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_83 = (int)Convert.ToByte(this.checkBoxTNXuatChieu120.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x001223D8 File Offset: 0x001205D8
		private void buttonSkill120vd_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormTuychon.int_1 = 0;
						FormTuychon.int_0 = Form1.gstruct49_0[num].int_136;
						FormTuychon formTuychon = new FormTuychon();
						formTuychon.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00122460 File Offset: 0x00120660
		private void buttonSkill120tn_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 1;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x001224B0 File Offset: 0x001206B0
		private void buttonDanhsachCuusat_Click(object sender, EventArgs e)
		{
			bool flag = !FormCuuSat.bool_0;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (flag2)
				{
					FormTip.smethod_0("HUONG DAN", "Bạn hãy chọn 1 ac rồi bấm nút Lập danh sách để thiết lập.", 4000, 250, 80, false, -1, -1, false, false, false);
				}
				else
				{
					FormCuuSat.int_0 = Form1.gstruct49_0[num].int_136;
					try
					{
						new FormCuuSat
						{
							int_1 = base.Left,
							int_2 = base.Top,
							int_3 = base.Width,
							int_4 = base.Height
						}.Show();
					}
					catch
					{
					}
				}
			}
			else
			{
				FormCuuSat.bool_0 = false;
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00122588 File Offset: 0x00120788
		private void checkBoxDanhquaiTrain_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_27 = (int)Convert.ToByte(this.checkBoxDanhquaiTrain.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00122614 File Offset: 0x00120814
		private void checkBoxTDPHettien_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_28 = (int)Convert.ToByte(this.checkBoxTDPHettien.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00122694 File Offset: 0x00120894
		private void checkBoxToadoVong_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_29 = (int)Convert.ToByte(this.checkBoxToadoVong.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00122720 File Offset: 0x00120920
		private void linkLabelPhimChaynhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string str = "https://youtu.be/GP7cr4qJIHA";
			Class22.smethod_40(Class62.smethod_0(), "", str, 0, false, false);
			string text = "Xem video hướng dẫn tại: " + Class53.string_7 + str;
			FormTip.smethod_0(Form1.string_1, text, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00122778 File Offset: 0x00120978
		private void textBoxTenacTimVST_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.string_8 = this.textBoxTenacTimVST.Text;
				Class62.smethod_10(Class53.string_3, "TenAcCantimVST", Class12.smethod_16(Form1.string_8), "", 0);
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x001227D4 File Offset: 0x001209D4
		private void checkBoxBaokenhbang_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_41 = (int)Convert.ToByte(this.checkBoxBaokenhbang.Checked);
				Class62.smethod_10(Class53.string_3, "flagBaoKenhBangVST", Form1.int_41, "", 0);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00122834 File Offset: 0x00120A34
		private void textBoxThoigianVST_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_43 = Class12.smethod_11(this.textBoxThoigianVST.Text);
				bool flag2 = Form1.int_43 < 1;
				if (flag2)
				{
					Form1.int_43 = 1;
				}
				Class62.smethod_10(Class53.string_3, "ThoigianVST", Form1.int_43, "", 0);
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x001228A4 File Offset: 0x00120AA4
		private void buttonPasteVST_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Clipboard.GetText();
				bool flag = text != null;
				if (flag)
				{
					bool flag2 = !(text == string.Empty);
					if (flag2)
					{
						text = text.Replace("/", "").Replace(" ", "");
						this.textBoxTenacTimVST.Text = text;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00122928 File Offset: 0x00120B28
		private void buttonCopyVST_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.textBoxToadoVST.Text != null && this.textBoxToadoVST.Text != string.Empty;
				if (flag)
				{
					Clipboard.SetText(this.textBoxToadoVST.Text);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0012298C File Offset: 0x00120B8C
		private void checkBoxRoom_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_42 = (int)Convert.ToByte(this.checkBoxRoom.Checked);
					Class62.smethod_10(Class53.string_3, "flagBaoKenhRoomVST", Form1.int_42, "", 0);
				}
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x001229F8 File Offset: 0x00120BF8
		private void checkBoxCungMucTieu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_33 = (int)Convert.ToByte(this.checkBoxCungMucTieu.Checked);
					Class62.smethod_10(Class53.string_3, "flagCungMuctieu", Form1.int_33, "", 0);
				}
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00122A64 File Offset: 0x00120C64
		private void buttonMuctieu_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 202;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00122AB8 File Offset: 0x00120CB8
		private void textBoxNhapSLTest_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					FormLocdoTest.int_2 = Class12.smethod_11(this.textBoxNhapSLTest.Text);
					Class62.smethod_10(Class53.string_3, "NhapSoluongTest", FormLocdoTest.int_2, "", 0);
				}
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00122B24 File Offset: 0x00120D24
		private void textBoxNhapSoluongClickNPC_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				FormClickNPC.int_6 = Class12.smethod_11(this.textBoxNhapSoluongClickNPC.Text);
				Class62.smethod_10(Class53.string_3, "iNhapSoluongClickNPC", FormClickNPC.int_6, "", 0);
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00122B84 File Offset: 0x00120D84
		private void checkBoxNhapSLClickNpc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				FormClickNPC.int_5 = (int)Convert.ToByte(this.checkBoxNhapSLClickNpc.Checked);
				Class62.smethod_10(Class53.string_3, "fNhapSoluongClickNPC", FormClickNPC.int_5, "", 0);
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00122BE4 File Offset: 0x00120DE4
		private void checkBoxDanhQuaiTrenduongdi_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_30 = (int)Convert.ToByte(this.checkBoxDanhQuaiTrenduongdi.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00122C64 File Offset: 0x00120E64
		private void checkBoxQuayquai_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_31 = (int)Convert.ToByte(this.checkBoxQuayquai.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00122CE4 File Offset: 0x00120EE4
		private int method_25(ComboBox comboBox_0, GStruct56[] gstruct56_0)
		{
			string text = comboBox_0.Text;
			bool flag = gstruct56_0 != null;
			if (flag)
			{
				for (int i = 0; i < gstruct56_0.Length; i++)
				{
					bool flag2 = gstruct56_0[i].string_0 == text;
					if (flag2)
					{
						return gstruct56_0[i].int_1;
					}
				}
			}
			return 0;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00122D48 File Offset: 0x00120F48
		private void buttonLogin_Click(object sender, EventArgs e)
		{
			bool flag = FormLogin.bool_0;
			if (flag)
			{
				FormLogin.bool_0 = false;
			}
			else
			{
				try
				{
					new FormLogin
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00122DC0 File Offset: 0x00120FC0
		private void buttonFixGameTuthoat_Click(object sender, EventArgs e)
		{
			bool flag = FormCompatibility.bool_0;
			if (flag)
			{
				FormCompatibility.bool_0 = false;
			}
			else
			{
				try
				{
					new FormCompatibility
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00122E48 File Offset: 0x00121048
		private void checkBoxGameHu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_67 = (int)Convert.ToByte(this.checkBoxGameHu.Checked);
				Class62.smethod_10(Class53.string_3, "flagLoaiboGameHu", Form1.int_67, "", 0);
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00122EA8 File Offset: 0x001210A8
		private void checkBoxTranphai1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_140[0] = (int)Convert.ToByte(this.checkBoxTranphai1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00122F28 File Offset: 0x00121128
		private void checkBoxTranphai2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_141[0] = (int)Convert.ToByte(this.checkBoxTranphai2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00122FA8 File Offset: 0x001211A8
		private void checkBoxTranphai3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_142[0] = (int)Convert.ToByte(this.checkBoxTranphai3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00123028 File Offset: 0x00121228
		private void comboBoxTranphai1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_140[1] = this.method_25(this.comboBoxTranphai1, Form1.gstruct49_0[num].gstruct56_0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x001230B4 File Offset: 0x001212B4
		private void comboBoxTranphai2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_141[1] = this.method_25(this.comboBoxTranphai2, Form1.gstruct49_0[num].gstruct56_0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00123140 File Offset: 0x00121340
		private void comboBoxTranphai3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_142[1] = this.method_25(this.comboBoxTranphai3, Form1.gstruct49_0[num].gstruct56_0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x001231CC File Offset: 0x001213CC
		private void textBoxTranphai1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_140[2] = Class12.smethod_11(this.textBoxTranphai1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0012324C File Offset: 0x0012144C
		private void textBoxTranphai2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_141[2] = Class12.smethod_11(this.textBoxTranphai2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x001232CC File Offset: 0x001214CC
		private void textBoxTranphai3_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_142[2] = Class12.smethod_11(this.textBoxTranphai3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0012334C File Offset: 0x0012154C
		private void comboBoxChuyenThuoc_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				Form1.bool_9 = false;
				Form1.string_18 = null;
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					int[] array = new int[1];
					Class79.smethod_35(gstruct, ref Form1.string_18, -1, array, false);
				}
				else
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						GStruct49 gstruct2 = Form1.gstruct49_0[i];
						int[] array2 = new int[1];
						Class79.smethod_35(gstruct2, ref Form1.string_18, -1, array2, false);
					}
				}
				bool flag3 = Form1.string_18 != null;
				if (flag3)
				{
					Array.Sort<string>(Form1.string_18);
					this.comboBoxChuyenThuoc.Items.Clear();
					for (int j = 0; j < Form1.string_18.Length; j++)
					{
						this.comboBoxChuyenThuoc.Items.Add(Class10.smethod_1(Form1.string_18[j], 1, false));
					}
				}
				Thread.Sleep(10);
				Form1.bool_9 = true;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00123498 File Offset: 0x00121698
		private void comboBoxChuyenThuoc_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxChuyenThuoc.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < Form1.string_18.Length;
						if (!flag3)
						{
							goto IL_8F;
						}
						bool flag4 = text == Class10.smethod_1(Form1.string_18[num2], 1, false);
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].string_14 = Form1.string_18[num2];
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_8F:;
				}
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00123564 File Offset: 0x00121764
		private void checkBoxTubaoDanh_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_44[0] = (int)Convert.ToByte(this.checkBoxTubaoDanh.Checked);
				}
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x001235B0 File Offset: 0x001217B0
		private void comboBoxVaodiemBaodanh_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				string text = this.comboBoxVaodiemBaodanh.Text;
				for (int i = 0; i < this.string_27.Length; i++)
				{
					bool flag2 = text == this.string_27[i];
					if (flag2)
					{
						bool flag3 = Form1.int_44[1] != i;
						if (flag3)
						{
							Form1.int_44[1] = i;
							Class62.smethod_10(Class53.string_3, "BaodanhTK", Form1.int_44[1], "", 0);
						}
						break;
					}
				}
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00123658 File Offset: 0x00121858
		private void checkBoxVaomapAchinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_45 = (int)Convert.ToByte(this.checkBoxVaomapAchinh.Checked);
				Class62.smethod_10(Class53.string_3, "flagVaoMapCTCCoAcchinh", Form1.int_45, "", 0);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x001236B8 File Offset: 0x001218B8
		private void buttonTuTimWeb_Click(object sender, EventArgs e)
		{
			bool flag = Form1.string_4 == null;
			if (!flag)
			{
				bool flag2 = FormTutim.bool_0;
				if (flag2)
				{
					FormTutim.bool_0 = false;
				}
				else
				{
					try
					{
						new FormTutim
						{
							int_0 = base.Left,
							int_1 = base.Top,
							int_2 = base.Width,
							int_3 = base.Height
						}.Show();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00123740 File Offset: 0x00121940
		private void checkBoxTatMuamauTK_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_91 = (int)Convert.ToByte(this.checkBoxTatMuamauTK.Checked);
				Class62.smethod_10(Class53.string_3, "flagTatMuamauTK", Form1.int_91, "", 0);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x001237A0 File Offset: 0x001219A0
		private void buttonToadoPK_Click(object sender, EventArgs e)
		{
			bool flag = FormPhongKy1.bool_0;
			if (flag)
			{
				FormPhongKy1.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormPhongKy1.int_4 = Form1.gstruct49_0[num].int_136;
						new FormPhongKy1
						{
							int_0 = base.Left,
							int_1 = base.Top,
							int_2 = base.Width,
							int_3 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00123850 File Offset: 0x00121A50
		private void checkBoxBatdauVanSuthong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].bool_54 = this.checkBoxBatdauVanSuthong.Checked;
				}
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x001238B8 File Offset: 0x00121AB8
		private void buttonPhimTat_Click(object sender, EventArgs e)
		{
			bool flag = FormPhimtat.bool_0;
			if (flag)
			{
				FormPhimtat.bool_0 = false;
			}
			else
			{
				try
				{
					new FormPhimtat
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00123940 File Offset: 0x00121B40
		private void checkBoxNhatqua_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(this.checkBoxNhatqua.Checked);
					int num3 = Form1.gstruct49_0[num].gstruct47_0.int_6;
					Form1.gstruct49_0[num].gstruct47_0.int_0 = num2;
					uint[] array = Class36.smethod_30(Form1.gstruct49_0[num]);
					Form1.gstruct49_0[num].gstruct47_0.int_9 = (int)array[0];
					Form1.gstruct49_0[num].gstruct47_0.int_10 = (int)array[1];
					GStruct49 gstruct = Form1.gstruct49_0[num];
					Class70.smethod_2(gstruct, Class70.uint_13, num2, 4);
					Class70.smethod_2(gstruct, Class70.uint_14, num3, 4);
					Class70.smethod_2(gstruct, Class70.uint_15, gstruct.gstruct47_0.int_8, 4);
					Class70.smethod_2(gstruct, Class70.uint_16, gstruct.gstruct47_0.int_9, 4);
					Class70.smethod_2(gstruct, Class70.uint_16 + 1U, gstruct.gstruct47_0.int_10, 4);
					Class70.smethod_2(gstruct, Class70.uint_16 + 2U, Class37.smethod_0(gstruct), 4);
				}
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00123AA8 File Offset: 0x00121CA8
		private void checkBoxBossSatthu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_133[0] = (int)Convert.ToByte(this.checkBoxBossSatthu.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00123B28 File Offset: 0x00121D28
		private void comboBoxTinSu_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = 0;
					string text = this.comboBoxTinSu.Text;
					for (int i = 0; i < Form1.string_28.Length; i++)
					{
						bool flag3 = text == Form1.string_28[i];
						if (flag3)
						{
							num2 = i;
							break;
						}
					}
					Form1.gstruct49_0[num].int_20[1] = num2;
					this.method_26(num2 > 0 && Form1.gstruct49_0[num].int_20[0] <= 0);
					this.checkBoxChoPTdanhsach.Enabled = (num2 == 0);
					this.comboBoxTinSu.Enabled = (num2 == 0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00123C30 File Offset: 0x00121E30
		private void checkBoxChayTinsu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(this.checkBoxChayTinsu.Checked);
					Form1.gstruct49_0[num].int_20[0] = num2;
					this.method_26(num2 <= 0 && Form1.gstruct49_0[num].int_20[1] > 0);
					this.comboBoxTinSu.Enabled = (num2 <= 0);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00123CEB File Offset: 0x00121EEB
		private void method_26(bool bool_20)
		{
			this.checkBoxMuathuocPK.Enabled = bool_20;
			this.checkBoxChaydanhvong.Enabled = bool_20;
			this.checkBoxChayPKNguoidung.Enabled = bool_20;
			this.buttonToadoPK.Enabled = bool_20;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00123D24 File Offset: 0x00121F24
		private void checkBoxONha_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_133[4] = (int)Convert.ToByte(this.checkBoxONha.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00123DA4 File Offset: 0x00121FA4
		private void comboBoxBosSatthu_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxBosSatthu.Text;
					for (int i = 0; i < Class100.struct27_0.Length; i++)
					{
						bool flag3 = text == Class100.struct27_0[i].string_0;
						if (flag3)
						{
							Form1.gstruct49_0[num].int_133[3] = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00123E64 File Offset: 0x00122064
		private void buttonSatthuAll_Click(object sender, EventArgs e)
		{
			int num = 0;
			string text = this.comboBoxBosSatthu.Text;
			for (int i = 0; i < Class100.struct27_0.Length; i++)
			{
				bool flag = text == Class100.struct27_0[i].string_0;
				if (flag)
				{
					num = i;
					break;
				}
			}
			int num2 = (int)Convert.ToByte(this.checkBoxBossSatthu.Checked);
			int num3 = (int)Convert.ToByte(this.checkBoxONha.Checked);
			bool flag2 = Form1.gstruct49_0 != null;
			if (flag2)
			{
				for (int j = 0; j < Form1.gstruct49_0.Length; j++)
				{
					Form1.gstruct49_0[j].int_133[0] = num2;
					Form1.gstruct49_0[j].int_133[3] = num;
					Form1.gstruct49_0[j].int_133[4] = num3;
					Class53.smethod_13(Form1.gstruct49_0[j], null);
				}
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00123F60 File Offset: 0x00122160
		private void buttonNhatquaAll_Click(object sender, EventArgs e)
		{
			string text = null;
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = 0 <= num;
			if (flag)
			{
				text = Form1.gstruct49_0[num].gstruct47_0.string_0;
			}
			int num2 = (int)Convert.ToByte(this.checkBoxNhatqua.Checked);
			int num3 = (int)Convert.ToByte(this.checkBoxGioClick.Checked);
			int num4 = (int)this.numericUpDownHH.Value;
			int num5 = (int)this.numericUpDownMM.Value;
			int num6 = (int)this.numericUpDownSS.Value;
			int num7 = Class12.smethod_11(this.textBoxPhamviNhatqua.Text);
			int num8 = (int)Convert.ToByte(this.checkBoxThanhTruot.Checked);
			int num9 = Class12.smethod_11(this.textBoxThoiGianTruot.Text);
			int num10 = (int)Convert.ToByte(this.checkBoxDungCodinh.Checked);
			bool flag2 = Form1.gstruct49_0 == null;
			if (!flag2)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag3 = text != null && text != string.Empty && i != num;
					if (flag3)
					{
						Form1.gstruct49_0[i].gstruct47_0.string_0 = text;
					}
					Form1.gstruct49_0[i].gstruct47_0.int_0 = num2;
					Form1.gstruct49_0[i].gstruct47_0.int_2 = num3;
					Form1.gstruct49_0[i].gstruct47_0.int_3 = num4;
					Form1.gstruct49_0[i].gstruct47_0.int_4 = num5;
					Form1.gstruct49_0[i].gstruct47_0.int_5 = num6;
					Form1.gstruct49_0[i].gstruct47_0.int_1 = num7;
					Form1.gstruct49_0[i].gstruct47_0.int_6 = num8;
					Form1.gstruct49_0[i].gstruct47_0.int_7 = num9;
					Form1.gstruct49_0[i].gstruct47_0.int_8 = num10;
					uint[] array = Class36.smethod_30(Form1.gstruct49_0[i]);
					Form1.gstruct49_0[i].gstruct47_0.int_9 = (int)array[0];
					Form1.gstruct49_0[i].gstruct47_0.int_10 = (int)array[1];
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_15, num10, 4);
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_16, Form1.gstruct49_0[i].gstruct47_0.int_9, 4);
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_16 + 1U, Form1.gstruct49_0[i].gstruct47_0.int_10, 4);
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_16 + 2U, Class37.smethod_0(Form1.gstruct49_0[i]), 4);
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_13, num2, 4);
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_14, num8, 4);
					Class53.smethod_13(Form1.gstruct49_0[i], null);
				}
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x001242C0 File Offset: 0x001224C0
		private void buttonTinsuAll_Click(object sender, EventArgs e)
		{
			int num = 0;
			int num2 = (int)Convert.ToByte(this.checkBoxChayTinsu.Checked);
			bool @checked = this.checkBoxMuathuocPK.Checked;
			bool checked2 = this.checkBoxChaydanhvong.Checked;
			string text = this.comboBoxTinSu.Text;
			for (int i = 0; i < Form1.string_28.Length; i++)
			{
				bool flag = text == Form1.string_28[i];
				if (flag)
				{
					num = i;
					break;
				}
			}
			bool flag2 = Form1.gstruct49_0 == null;
			if (!flag2)
			{
				for (int j = 0; j < Form1.gstruct49_0.Length; j++)
				{
					bool flag3 = num > 1;
					if (flag3)
					{
						Form1.gstruct49_0[j].bool_5 = @checked;
						Form1.gstruct49_0[j].bool_4 = checked2;
					}
					Form1.gstruct49_0[j].int_20[1] = num;
					Form1.gstruct49_0[j].int_20[0] = num2;
					Class53.smethod_13(Form1.gstruct49_0[j], null);
				}
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x001243E0 File Offset: 0x001225E0
		private void checkBoxKhongLuuruong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class100.int_1 = (int)Convert.ToByte(this.checkBoxKhongLuuruong.Checked);
				Class62.smethod_10(Class53.string_3, "BosSatthuKhongLuuRuong", Class100.int_1, "", 0);
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00124440 File Offset: 0x00122640
		private void checkBoxGhepSTG_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class100.int_2 = (int)Convert.ToByte(this.checkBoxGhepSTG.Checked);
				Class62.smethod_10(Class53.string_3, "TuGhepSTG", Class100.int_2, "", 0);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x001244A0 File Offset: 0x001226A0
		private void buttonGhepSTG_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					GStruct49 gstruct = Form1.gstruct49_0[num];
					bool bool_ = gstruct.bool_25;
					if (bool_)
					{
						bool flag3 = gstruct.int_133[0] > 0;
						if (flag3)
						{
							string text = "Ac đang chạy boss sát thủ, chỉ cần check vào mục [v] Tự ghép STG, thì khi nào ac về thành nhận nhiệm vụ lúc đó ac sẽ tự ghép Sát thủ giản luôn.";
							FormTip.smethod_0(Form1.string_1, text, 600000, 400, 140, false, base.Left, base.Top, false, false, false);
						}
						else
						{
							bool flag4 = Form1.int_20 != 0;
							if (flag4)
							{
								string text2 = "Chức năng này chỉ sử dụng được khi ở chế độ WAR.";
								FormTip.smethod_0(Form1.string_1, text2, 600000, 300, 80, false, base.Left, base.Top, false, false, false);
							}
							else
							{
								Class100.int_3 = gstruct.int_136;
								new Thread(new ThreadStart(Class100.smethod_2)).Start();
							}
						}
					}
				}
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x001245C0 File Offset: 0x001227C0
		private void checkBoxBossSTtuhuy_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class100.int_0 = (int)Convert.ToByte(this.checkBoxBossSTtuhuy.Checked);
				Class62.smethod_10(Class53.string_3, "BosSatthuTuHuyNhiemvu", Class100.int_0, "", 0);
				bool flag2 = Class100.int_0 > 0;
				if (flag2)
				{
					string text = "Tự hủy nhiệm vụ hiện tại và nhận nhiệm vụ mới. Điều kiện để auto tự Kích hoạt tự hủy nhiệm vụ là:||- Đây là ac không có tổ đội, hoặc là đội trưởng|- Ac đang đứng nơi vị trí boss xuất hiện.|- Sau 60 giây nếu boss không xuất hiện thì sẽ tự hủy.||Do vậy, nếu đang săn boss tổ đội thì ac đội trưởng (chủ PT) phải đi săn boss luôn chứ không được ở nhà nhé.";
					FormTip.smethod_0(Form1.string_1, text, 600000, 360, 200, false, base.Left, base.Top, false, false, false);
				}
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00124660 File Offset: 0x00122860
		private void buttonNgaMybuff_Click(object sender, EventArgs e)
		{
			bool flag = FormNgamyBuff.bool_0;
			if (flag)
			{
				FormNgamyBuff.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormNgamyBuff.int_4 = Form1.gstruct49_0[num].int_136;
						new FormNgamyBuff
						{
							int_0 = Cursor.Position.X,
							int_1 = Cursor.Position.Y,
							int_2 = base.Width,
							int_3 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00124724 File Offset: 0x00122924
		private void checkBoxGopVatpham_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_72 = (int)Convert.ToByte(this.checkBoxGopVatpham.Checked);
				Class62.smethod_10(Class53.string_3, "flagMuaGop", Form1.int_72, "", 0);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00124784 File Offset: 0x00122984
		private void checkBoxMuaKytrancac_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_71 = (int)Convert.ToByte(this.checkBoxMuaKytrancac.Checked);
				Class62.smethod_10(Class53.string_3, "flagMuaKTC", Form1.int_71, "", 0);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x001247E4 File Offset: 0x001229E4
		private void comboBoxMuaVatpham_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.bool_9 = false;
					Form1.string_18 = Class79.smethod_34(Form1.gstruct49_0[num], null, 3);
					this.comboBoxMuaVatpham.Items.Clear();
					bool flag3 = Form1.string_18 != null;
					if (flag3)
					{
						Array.Sort<string>(Form1.string_18);
						for (int i = 0; i < Form1.string_18.Length; i++)
						{
							this.comboBoxMuaVatpham.Items.Add(Class10.smethod_1(Form1.string_18[i], 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x001248CC File Offset: 0x00122ACC
		private void comboBoxMuaVatpham_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_18 == null;
			if (!flag)
			{
				string text = this.comboBoxMuaVatpham.Text;
				for (int i = 0; i < Form1.string_18.Length; i++)
				{
					bool flag2 = text == Class10.smethod_1(Form1.string_18[i], 1, false);
					if (flag2)
					{
						Form1.string_20 = Form1.string_18[i];
						Class62.smethod_10(Class53.string_3, "NameMuaGop", Form1.string_20, "", 0);
						break;
					}
				}
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00124968 File Offset: 0x00122B68
		private void pictureBoxQC_Click(object sender, EventArgs e)
		{
			bool flag = Class24.gstruct14_0 == null || this.pictureBoxQC.ImageLocation == string.Empty || this.pictureBoxQC.ImageLocation == null;
			if (!flag)
			{
				bool flag2 = Class24.gstruct14_0.Length <= Form1.int_137 || Class24.gstruct14_0[Form1.int_137].string_2 == null || Class24.gstruct14_0[Form1.int_137].string_2 == string.Empty;
				if (flag2)
				{
					Form1.int_137 = -1;
					for (int i = 0; i < Class24.gstruct14_0.Length; i++)
					{
						bool flag3 = Class24.gstruct14_0[i].string_2 != null && Class24.gstruct14_0[i].string_2 != string.Empty;
						if (flag3)
						{
							Form1.int_137 = i;
							break;
						}
					}
				}
				bool flag4 = Form1.int_137 >= 0;
				if (flag4)
				{
					string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
					bool flag5 = !Class12.smethod_17(text);
					if (flag5)
					{
						text = Class62.smethod_0();
					}
					Class22.smethod_40(text, "", Class24.gstruct14_0[Form1.int_137].string_2, 0, false, false);
				}
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00124ABC File Offset: 0x00122CBC
		private void textBoxIdMua_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_132 = Class12.smethod_11(this.textBoxIdMua.Text);
					}
				}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00124B34 File Offset: 0x00122D34
		private void buttonHelp_Click(object sender, EventArgs e)
		{
			bool flag = TryNewVersion.bool_0;
			if (flag)
			{
				TryNewVersion.bool_0 = false;
			}
			else
			{
				try
				{
					new TryNewVersion
					{
						int_2 = base.Left,
						int_3 = base.Top,
						int_4 = base.Width,
						int_5 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00124BAC File Offset: 0x00122DAC
		private void comboBoxPk_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_104[1] = Class12.smethod_11(this.comboBoxPk.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00124C2C File Offset: 0x00122E2C
		private void checkBoxMuaDungSoluong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_73[0] = (int)Convert.ToByte(this.checkBoxMuaDungSoluong.Checked);
					Class62.smethod_10(Class53.string_3, "MDSL0", Form1.int_73[0], "", 0);
				}
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00124C9C File Offset: 0x00122E9C
		private void textBoxMuadungSoLuong_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_73[1] = Class12.smethod_11(this.textBoxMuadungSoLuong.Text);
					Class62.smethod_10(Class53.string_3, "MDSL1", Form1.int_73[1], "", 0);
				}
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00124D0C File Offset: 0x00122F0C
		private void buttonHelpMua_Click(object sender, EventArgs e)
		{
			string text = "HƯỚNG DẪN MUA GỘP VÀ SỬ DỤNG||1. Chọn tên vật phẩm cần mua.|2. Nhập số lượng nếu mua gộp sử dụng theo số lượng.|3. Bấm nút mua.||XỬ LÝ KHI MUA SAI VẬT PHẨM TRONG KỲ TRÂN CÁC||1. Bấm vào tab [Hậu cần -> Mua thuốc] của auto.|2. Bấm nút [ Bảo vật]|3. Lấy giá trị sai số theo hướng dẫn trong đó|Sau khi lấy xong giá trị sai số thì phần [ Event - Mua dùng ] sẽ hoạt động đúng||[v] Bỏ qua bước nhập Mã KTC:||Khi vật phẩm có mặt trong Kỳ trân các nhưng auto không chắc chắn xác định được thứ tự vật phẩm thì sẽ yêu cầu mã xác nhận (xuất hiện dòng chữ nhấp nháy trên đầu nhân vật yêu cầu nhập mã).||Nếu sau khi nhập mã, nhân vật mua được vật phẩm mà không bị diss game thì bạn có thể check mục bỏ qua để khỏi yêu cầu nhập mã lần nữa. Ngược lại nếu bị diss game thì vật phẩm này không mua được bằng auto.";
			FormTip.smethod_0(Form1.string_1, text, 600000, 420, 340, false, base.Left, base.Top, false, false, false);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00124D4B File Offset: 0x00122F4B
		private void checkBoxBoquaMaKTC_CheckedChanged(object sender, EventArgs e)
		{
			Form1.bool_5 = this.checkBoxBoquaMaKTC.Checked;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00124D60 File Offset: 0x00122F60
		private void buttonStopNhatqua_Click(object sender, EventArgs e)
		{
			this.checkBoxNhatqua.Checked = false;
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].gstruct47_0.int_0 = 0;
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_13, 0, 4);
				}
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00124DCF File Offset: 0x00122FCF
		private void buttonTHP_Click(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00124DDC File Offset: 0x00122FDC
		private void method_27()
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				Form1.int_147 = 0;
				string text = this.comboBoxTHP.Text;
				for (int i = 0; i < Form1.string_14.GetLength(0); i++)
				{
					bool flag2 = text == Form1.string_14[i, 0];
					if (flag2)
					{
						Form1.string_49 = Form1.string_14[i, 1];
						Form1.int_147 = Class12.smethod_11(Form1.string_49);
						break;
					}
				}
				bool flag3 = Form1.int_147 > 0;
				if (flag3)
				{
					int num = -1;
					Form1.string_49 = this.comboBoxPhuong.Text;
					for (int j = 0; j < Form1.string_15.GetLength(0); j++)
					{
						bool flag4 = Form1.string_49 == Form1.string_15[j, 0];
						if (flag4)
						{
							Form1.string_49 = Form1.string_15[j, 1];
							num = j;
							break;
						}
					}
					bool flag5 = Form1.int_147 == 162 && num != 3 && num != 4;
					if (flag5)
					{
						Form1.string_49 = "b¾c";
					}
					else
					{
						bool flag6 = Form1.int_147 == 76 && (num == 1 || num == 4);
						if (flag6)
						{
							Form1.string_49 = "®«ng|§«ng";
						}
					}
				}
				bool flag7 = Class44.gstruct33_0.int_0 > 0;
				if (flag7)
				{
					Form1.int_146 = Class44.gstruct33_0.int_0;
					new Thread(new ThreadStart(Form1.smethod_3)).Start();
					Thread.Sleep(100);
				}
				try
				{
					for (int k = 0; k < Form1.gstruct49_0.Length; k++)
					{
						bool flag8 = Form1.gstruct49_0[k].bool_25 && Form1.gstruct49_0[k].int_136 != Class44.gstruct33_0.int_0;
						if (flag8)
						{
							int num2 = 0;
							while (Form1.int_146 > 0 && num2 < 10)
							{
								Thread.Sleep(60);
								num2++;
							}
							Form1.int_146 = Form1.gstruct49_0[k].int_136;
							new Thread(new ThreadStart(Form1.smethod_3)).Start();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00125054 File Offset: 0x00123254
		private static void smethod_3()
		{
			int num = Form1.int_146;
			int num2 = Form1.int_147;
			string string_ = Form1.string_49;
			Form1.int_146 = 0;
			int num3 = Class81.smethod_3(Form1.gstruct49_0, num);
			bool flag = num3 >= 0;
			if (flag)
			{
				bool flag2 = num2 <= 0;
				if (flag2)
				{
					Class35.smethod_141(Form1.gstruct49_0[num3], string_);
				}
				else
				{
					Class35.smethod_140(Form1.gstruct49_0[num3], num2, string_, null, false);
				}
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x001250D0 File Offset: 0x001232D0
		private void buttonPT_Click(object sender, EventArgs e)
		{
			bool flag = FormPT.bool_0;
			if (flag)
			{
				FormPT.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormPT.gstruct49_0 = Form1.gstruct49_0[num];
						new FormPT
						{
							int_0 = Cursor.Position.X,
							int_1 = Cursor.Position.Y,
							int_2 = base.Width,
							int_3 = base.Height
						}.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00125190 File Offset: 0x00123390
		private void checkBoxBosBaobos_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_1 = (int)Convert.ToByte(this.checkBoxBosBaobos.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00125210 File Offset: 0x00123410
		private void comboBoxTHP_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9 && this.comboBoxTHP.Text == "Hướng dẫn";
			if (flag)
			{
				string text = "Các bạn bấm phím tương ứng ký tự đầu tiên của tên map để nhảy nhanh đến mục cần chọn.||Ví dụ đi Sa mạc 1 thì bạn gõ số 1, đi Dương Châu thì bạn gõ chữ D .v.v..";
				FormTip.smethod_0(Form1.string_1, text, 60000, 250, 120, false, -1, -1, false, false, false);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00125274 File Offset: 0x00123474
		private void textBoxSoluongChuyenthuoc_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_76[3] = Class12.smethod_11(this.textBoxSoluongChuyenthuoc.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x001252F4 File Offset: 0x001234F4
		private void textBoxChuyenThuocMin_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_76[2] = Class12.smethod_11(this.textBoxChuyenThuocMin.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00125374 File Offset: 0x00123574
		private void checkBoxTuChuyenThuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_76[0] = (int)Convert.ToByte(this.checkBoxTuChuyenThuoc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x001253F4 File Offset: 0x001235F4
		private void checkBoxRuongBH_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_79 = (int)Convert.ToByte(this.checkBoxRuongBH.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00125474 File Offset: 0x00123674
		private void buttonHDChuyenthuoc_Click(object sender, EventArgs e)
		{
			string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(text);
			if (flag)
			{
				text = Class62.smethod_0();
			}
			Class22.smethod_40(text, "", "https://youtu.be/XRljjxiuyk8", 0, false, false);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x001254C0 File Offset: 0x001236C0
		private void checkBoxBamPhimCong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_76[1] = (int)Convert.ToByte(this.checkBoxBamPhimCong.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00125540 File Offset: 0x00123740
		private void checkBoxTTL_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_58 = (int)Convert.ToByte(this.checkBoxTTL.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x001255C0 File Offset: 0x001237C0
		private void buttonLuuCauhinhAll_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				string str = string.Empty;
				bool flag2 = gstruct.string_23 != null && gstruct.string_23 != string.Empty;
				if (flag2)
				{
					str = gstruct.string_23 + "_";
				}
				string text = Form1.string_50;
				bool flag3 = Form1.string_50 == null || Form1.string_50 == string.Empty;
				if (flag3)
				{
					text = Class53.string_8 + "\\Save";
				}
				Class12.smethod_23(text);
				string text2 = Class53.smethod_27(text, str + Class10.smethod_1(gstruct.string_22, 1, false) + ".txt");
				bool flag4 = text2 != null && text2 != string.Empty;
				if (flag4)
				{
					Class53.smethod_13(gstruct, text2);
				}
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x001256BC File Offset: 0x001238BC
		private void buttonDocCauhinh_Click(object sender, EventArgs e)
		{
			string text = Form1.string_50;
			bool flag = Form1.string_50 == null || Form1.string_50 == string.Empty;
			if (flag)
			{
				text = Class53.string_8 + "\\Save";
			}
			Class12.smethod_23(text);
			string a = Class53.smethod_26(text, "", "*.txt", "");
			bool flag2 = !(a == string.Empty);
			if (flag2)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag3 = 0 <= num;
				if (flag3)
				{
					Class53.smethod_9(ref Form1.gstruct49_0[num], a);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0012577C File Offset: 0x0012397C
		private void buttonAchinh_Click(object sender, EventArgs e)
		{
			bool flag = FormAchinh.bool_0;
			if (flag)
			{
				FormAchinh.bool_0 = false;
			}
			else
			{
				try
				{
					new FormAchinh
					{
						int_2 = base.Left,
						int_3 = base.Top,
						int_4 = base.Width,
						int_5 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x001257F4 File Offset: 0x001239F4
		private void buttonBoss_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 201;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00125848 File Offset: 0x00123A48
		private void buttonNamIm_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 203;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0012589C File Offset: 0x00123A9C
		private void buttonBaoBoss_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 5;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x001258EC File Offset: 0x00123AEC
		private void checkBoxChayRunAdmin_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class22.int_34 = (int)Convert.ToByte(this.checkBoxChayRunAdmin.Checked);
				Class62.smethod_10(Class53.string_3, "RunAdmin", Class22.int_34, "", 0);
				Class22.smethod_71(null, true);
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00125954 File Offset: 0x00123B54
		private void buttonHuongdanCanhbos_Click(object sender, EventArgs e)
		{
			string str = "https://youtu.be/bEpu8rfT7A8";
			string text = "Phim Hướng dẫn xem ở đây:|" + str + "||* Trường hợp check vào [v] Tất cả ac luôn đến tọa độ:|Nếu muốn ac A đến tọa độ, nhưng lại không muốn ac B đến|=> Bạn phải  bấm nút < xóa > để cho ac B rỗng tọa độ nhé.||* Trường hợp kéo nhiều máy, thì ở máy phụ bạn phải lấy tọa độ trước hoặc phải check vào mục [v] Máy phụ đến tọa độ.||Lưu ý: Tất cả các chức năng trong auto, nếu là chữ màu nâu đỏ thì nó được áp dụng cho toàn cục, còn chữ đen hoặc xanh thì áp dụng cho từng ac";
			FormTip.smethod_0(Form1.string_1, text, 600000, 360, 240, false, base.Left, base.Top, false, false, false);
			string text2 = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(text2);
			if (flag)
			{
				text2 = Class62.smethod_0();
			}
			Class22.smethod_40(text2, "", str, 0, false, false);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x001259DC File Offset: 0x00123BDC
		private void checkBoxDenToadoUser_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_125[0] = (int)Convert.ToByte(this.checkBoxDenToadoUser.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00125A5C File Offset: 0x00123C5C
		private void checkBoxDenToadoALL_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_75 = (int)Convert.ToByte(this.checkBoxDenToadoALL.Checked);
					Class62.smethod_10(Class53.string_3, "fDenToado", Form1.int_75, "", 0);
					this.checkBoxDenToadoUser.Enabled = (Form1.int_75 <= 0);
				}
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00125ADC File Offset: 0x00123CDC
		private void buttonXoaToado_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				int[] array = Form1.gstruct49_0[num].int_125 = new int[5];
				array = (Form1.gstruct49_0[num].int_124 = new int[3]);
				Class53.smethod_13(Form1.gstruct49_0[num], null);
				this.textBoxToadoDen.Text = string.Empty;
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00125B64 File Offset: 0x00123D64
		private void buttonLayToado_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				GStruct49 gstruct = Form1.gstruct49_0[num];
				int num2 = Class37.smethod_0(gstruct);
				string text = Class37.smethod_2(gstruct);
				uint[] array = Class36.smethod_30(gstruct);
				bool flag2 = gstruct.int_125 != null;
				if (!flag2)
				{
					goto IL_165;
				}
				bool flag3 = gstruct.int_125.Length != 5;
				if (flag3)
				{
					goto IL_165;
				}
				Form1.gstruct49_0[num].int_125[2] = num2;
				Form1.gstruct49_0[num].int_125[3] = (int)array[0];
				Form1.gstruct49_0[num].int_125[4] = (int)array[1];
				IL_BE:
				Form1.gstruct49_0[num].int_124 = new int[]
				{
					num2,
					(int)array[0],
					(int)array[1]
				};
				Class53.smethod_13(Form1.gstruct49_0[num], null);
				string text2 = string.Concat(new string[]
				{
					"( ",
					(array[0] / 256U).ToString(),
					",",
					(array[1] / 512U).ToString(),
					" ) ",
					Class10.smethod_1(text, 1, false)
				});
				this.textBoxToadoDen.Text = text2;
				return;
				IL_165:
				Form1.gstruct49_0[num].int_125 = new int[]
				{
					(int)Convert.ToByte(this.checkBoxDenToadoUser.Checked),
					0,
					num2,
					(int)array[0],
					(int)array[1]
				};
				goto IL_BE;
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00125D18 File Offset: 0x00123F18
		private void textBoxKhoangCachAccChinh_Leave(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_23 = Class12.smethod_11(this.textBoxKhoangCachAccChinh.Text);
				bool flag2 = Form1.int_23 < 150;
				if (flag2)
				{
					Form1.int_23 = 150;
				}
				bool flag3 = this.textBoxKhoangCachAccChinh.Text != Form1.int_23.ToString();
				if (flag3)
				{
					this.textBoxKhoangCachAccChinh.Text = Form1.int_23.ToString();
				}
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00125DA4 File Offset: 0x00123FA4
		private void textBoxKhoangCachAccChinh_TextChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_23 = Class12.smethod_11(this.textBoxKhoangCachAccChinh.Text);
					bool flag2 = Form1.int_23 < 150;
					if (flag2)
					{
						Form1.int_23 = 150;
					}
					Class62.smethod_10(Class53.string_3, "KhoangcachAccchinh", Form1.int_23, "", 0);
				}
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00125E28 File Offset: 0x00124028
		private void checkBoxLocTrangbiNPC_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				FormLocdoTest.int_4 = (int)Convert.ToByte(this.checkBoxLocTrangbiNPC.Checked);
				Class62.smethod_10(Class53.string_3, "DayLaNPC", FormLocdoTest.int_4, "", 0);
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00125E88 File Offset: 0x00124088
		private void checkBoxLocTrangbiNhapSL_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				FormLocdoTest.int_3 = (int)Convert.ToByte(this.checkBoxLocTrangbiNhapSL.Checked);
				Class62.smethod_10(Class53.string_3, "fCoNhapSLTest", FormLocdoTest.int_3, "", 0);
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00125EE6 File Offset: 0x001240E6
		private void buttonDoSat_Click(object sender, EventArgs e)
		{
			Class76.bool_1 = true;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00125EF0 File Offset: 0x001240F0
		private void checkBoxDanhHieuuy_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_94 = (int)Convert.ToByte(this.checkBoxDanhHieuuy.Checked);
				Class62.smethod_10(Class53.string_3, "fHieuUyTK", Form1.int_94, "", 0);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00125F50 File Offset: 0x00124150
		private void checkBoxTKThanhTruot_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_93[0] = (int)Convert.ToByte(this.checkBoxTKThanhTruot.Checked);
					Class62.smethod_10(Class53.string_3, "TruotTK0", Form1.int_93[0], "", 0);
				}
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00125FC0 File Offset: 0x001241C0
		private void textBoxTruotTK_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_93[1] = Class12.smethod_11(this.textBoxTruotTK.Text);
				bool flag2 = Form1.int_93[1] < 100;
				if (flag2)
				{
					Form1.int_93[1] = 100;
				}
				bool flag3 = Form1.int_93[1] > 300;
				if (flag3)
				{
					Form1.int_93[1] = 300;
				}
				Class62.smethod_10(Class53.string_3, "TruotTK1", Form1.int_93[1], "", 0);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00126058 File Offset: 0x00124258
		private void checkBoxThanhTruotSudung_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					Form1.int_74 = (int)Convert.ToByte(this.checkBoxThanhTruotSudung.Checked);
					Class62.smethod_10(Class53.string_3, "fThanhTruotSudung", Form1.int_74, "", 0);
				}
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x001260C4 File Offset: 0x001242C4
		private void linkLabelPhimCauca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string str = "https://youtu.be/mf3c182vvUk";
			Class22.smethod_40(Class62.smethod_0(), "", str, 0, false, false);
			string text = "Xem video hướng dẫn câu cá tại: " + Class53.string_7 + str;
			FormTip.smethod_0(Form1.string_1, text, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0012611C File Offset: 0x0012431C
		private void buttonKyTranCac_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormTuychon.int_0 = Form1.gstruct49_0[num].int_136;
					}
					FormTuychon.int_1 = 6;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x001261A8 File Offset: 0x001243A8
		private void buttonMuathuocBaovat_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool flag2 = Form1.gstruct49_0[i].bool_25 && Form1.gstruct49_0[i].int_77 > 0;
					if (flag2)
					{
						Class34.smethod_1(Form1.gstruct49_0[i], true);
					}
				}
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0012621C File Offset: 0x0012441C
		private void checkBoxVuotAi_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_116 = (int)Convert.ToByte(this.checkBoxVuotAi.Checked);
				Class62.smethod_10(Class53.string_3, "flagPhandame", Form1.int_116, "", 0);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0012627C File Offset: 0x0012447C
		private void buttonThoatGame_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = 0 <= num;
			if (flag)
			{
				Class22.smethod_53(Form1.gstruct49_0[num].process_0);
			}
			Class46.smethod_5();
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x001262C8 File Offset: 0x001244C8
		private void buttonDiemTapket_Click(object sender, EventArgs e)
		{
			bool flag = FormTapKet.bool_0;
			if (flag)
			{
				FormTapKet.bool_0 = false;
			}
			else
			{
				try
				{
					FormTapKet.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormTapKet.int_0 = Form1.gstruct49_0[num].int_136;
					}
					new FormTapKet
					{
						int_1 = Cursor.Position.X,
						int_2 = Cursor.Position.Y,
						int_3 = base.Width,
						int_4 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00126390 File Offset: 0x00124590
		private void checkBoxDiemTapket_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_114 = (int)Convert.ToByte(this.checkBoxDiemTapket.Checked);
					Class62.smethod_10(Class53.string_3, "flagDiemTapket", Form1.int_114, "", 0);
				}
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x001263FC File Offset: 0x001245FC
		private void checkBoxConLon_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_84[0] = (int)Convert.ToByte(this.checkBoxConLon.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0012648C File Offset: 0x0012468C
		private void checkBoxBossSTKhongLamHaucan_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_134 = (int)Convert.ToByte(this.checkBoxBossSTKhongLamHaucan.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00126518 File Offset: 0x00124718
		private void buttonHuyenTinh_Click(object sender, EventArgs e)
		{
			bool flag = FormHuyenTinh.bool_0;
			if (flag)
			{
				FormHuyenTinh.bool_0 = false;
			}
			else
			{
				try
				{
					FormHuyenTinh.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormHuyenTinh.int_0 = Form1.gstruct49_0[num].int_136;
					}
					FormHuyenTinh formHuyenTinh = new FormHuyenTinh();
					formHuyenTinh.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0012659C File Offset: 0x0012479C
		private void buttonRaovat_Click(object sender, EventArgs e)
		{
			bool flag = FormRaovat.bool_0;
			if (flag)
			{
				FormRaovat.bool_0 = false;
			}
			else
			{
				try
				{
					FormRaovat.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormRaovat.int_0 = Form1.gstruct49_0[num].int_136;
					}
					FormRaovat formRaovat = new FormRaovat();
					formRaovat.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00126620 File Offset: 0x00124820
		private void method_28(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = "https://youtu.be/dleEtu8n5fY";
			Class12.string_16 = new string[1];
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00126658 File Offset: 0x00124858
		private void checkBoxChoPTdanhsach_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class65.int_2[0] = (int)Convert.ToByte(this.checkBoxChoPTdanhsach.Checked);
				Class62.smethod_10(Class53.string_3, "flagChodoiPT1", Class65.int_2[0], "", 0);
			}
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x001266BC File Offset: 0x001248BC
		private void textBoxTimerPT_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Class65.int_2[1] = Class12.smethod_11(this.textBoxTimerPT.Text);
				Class62.smethod_10(Class53.string_3, "flagChodoiPT2", Class65.int_2[1], "", 0);
			}
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00126720 File Offset: 0x00124920
		private void linkLabelHelpTinsu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = "HƯỚNG DẪN CHẠY TÍN SỨ THIÊN BẢO KHỐ||Để đảm bảo PT chạy không bị rớt ac, bạn phải:|1. Check vào mục [v] Chờ đủ PT (s)|2. Check vào mục [v] PT ở Điều khiển - bảng 1.||Trong phần thiết lập PT [...] ở bảng 1, bạn chọn:||1. Check vào mục [v] Mời hoặc nhận PT theo danh sách|2. Ép tất cả ac cần chạy Tín sứ vào danh sách nhóm (bấm nút Thêm).|3. Lựa ra 1 ac trong danh sách nhóm, check vào [v] Luôn làm đội trưởng.||Xong tiến hành chạy tín sứ thiên bảo khố. Ac đội trưởng khi vào phía trong dịch quan, sẽ tự PT và kiểm tra tổ đội, nếu PT đầy đủ trong danh sách thì sẽ bắt đầu nhiệm vụ.";
			FormTip.smethod_0(Form1.string_1, text, 600000, 420, 340, false, base.Left, base.Top, false, false, false);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00126760 File Offset: 0x00124960
		private void checkBoxQuangThuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_131[0] = (int)Convert.ToByte(this.checkBoxQuangThuoc.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x001267E0 File Offset: 0x001249E0
		private void buttonQuangThuoc_Click(object sender, EventArgs e)
		{
			bool flag = FormTuychon.bool_0;
			if (flag)
			{
				FormTuychon.bool_0 = false;
			}
			else
			{
				try
				{
					FormTuychon.int_1 = 7;
					FormTuychon formTuychon = new FormTuychon();
					formTuychon.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00126830 File Offset: 0x00124A30
		private void buttonHelpClickNpc_Click(object sender, EventArgs e)
		{
			string text = "https://youtu.be/Dup5PcJOV5Y";
			string text2 = "https://youtu.be/YNTAHZLx7NY";
			Class22.smethod_40(Class62.smethod_0(), "", text, 0, false, false);
			string text3 = string.Concat(new string[]
			{
				"Xem 2 video hướng dẫn tại: ",
				Class53.string_7,
				text,
				Class53.string_7,
				text2
			});
			FormTip.smethod_0(Form1.string_1, text3, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x001268A8 File Offset: 0x00124AA8
		private void buttonClickNpcSingle_Click(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class70.smethod_3(Form1.gstruct49_0[num], Class70.uint_48, 4);
					bool flag3 = num2 <= 0;
					if (flag3)
					{
						FormClickNPC.int_8 = Form1.gstruct49_0[num].int_136;
						new Thread(new ThreadStart(FormClickNPC.smethod_3)).Start();
					}
				}
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0012694C File Offset: 0x00124B4C
		private void buttonClickNpcAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null || Form1.string_45 == null || Form1.string_45 == string.Empty;
			if (!flag)
			{
				int[] array = Form1.smethod_2(this.textBoxClickNPCMenu.Text);
				int num = (int)Convert.ToByte(this.checkBoxClickNPCmenu.Checked);
				int num2 = Class12.smethod_11(this.textBoxClickNPCTocdo.Text);
				int[] array2 = new int[]
				{
					(int)Convert.ToByte(this.checkBoxClickNPCSolan.Checked),
					Class12.smethod_11(this.textBoxClickNPCSolan.Text)
				};
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Form1.gstruct49_0[i].string_0 = Form1.string_45;
						Form1.gstruct49_0[i].int_8 = num;
						Form1.gstruct49_0[i].int_10 = num2;
						Form1.gstruct49_0[i].int_7 = array2;
						Form1.gstruct49_0[i].int_9 = null;
						bool flag2 = array != null;
						if (flag2)
						{
							Form1.gstruct49_0[i].int_9 = new int[array.Length];
							for (int j = 0; j < array.Length; j++)
							{
								Form1.gstruct49_0[i].int_9[j] = array[j];
							}
						}
						bool flag3 = !Form1.gstruct49_0[i].bool_25 || Class70.smethod_3(Form1.gstruct49_0[i], Class70.uint_48, 4) != 0;
						if (!flag3)
						{
							for (int k = 0; k < 50; k++)
							{
								bool flag4 = FormClickNPC.int_8 <= 0;
								if (flag4)
								{
									break;
								}
								Thread.Sleep(10);
							}
							FormClickNPC.int_8 = Form1.gstruct49_0[i].int_136;
							new Thread(new ThreadStart(FormClickNPC.smethod_3)).Start();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00126B7C File Offset: 0x00124D7C
		private void buttonClickNpcStopAll_Click(object sender, EventArgs e)
		{
			this.buttonClickNpcSingle.Enabled = true;
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_48, 0, 4);
						Form1.gstruct49_0[i].bool_8 = false;
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00126C00 File Offset: 0x00124E00
		private void buttonMuaGopAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					try
					{
						bool flag2 = !Form1.gstruct49_0[i].bool_47 && !Form1.gstruct49_0[i].bool_51;
						if (flag2)
						{
							Form1.gstruct49_0[i].bool_51 = true;
							Class40.int_0 = Form1.gstruct49_0[i].int_136;
							new Thread(new ThreadStart(Class40.smethod_2)).Start();
							Thread.Sleep(150);
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00126CCC File Offset: 0x00124ECC
		private void buttonMuaSudungAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					try
					{
						bool flag2 = !Form1.gstruct49_0[i].bool_52 && !Form1.gstruct49_0[i].bool_53;
						if (flag2)
						{
							Form1.gstruct49_0[i].bool_53 = true;
							Class40.int_1 = Form1.gstruct49_0[i].int_136;
							new Thread(new ThreadStart(Class40.smethod_4)).Start();
							Thread.Sleep(150);
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00126D98 File Offset: 0x00124F98
		private void comboBoxBanVatPham_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxBanVatPham.Text;
					for (int i = 0; i < Form1.string_29.Length; i++)
					{
						bool flag3 = text == Form1.string_29[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].int_12[1] = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00126E50 File Offset: 0x00125050
		private void checkBoxBanVpham_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_12[0] = (int)Convert.ToByte(this.checkBoxBanVpham.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.buttonBanVatphamRac.Enabled = !this.checkBoxBanVpham.Checked;
				}
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00126EEC File Offset: 0x001250EC
		private void buttonDsBanVatpham_Click(object sender, EventArgs e)
		{
			bool flag = FormBanEvent.bool_1;
			if (flag)
			{
				FormBanEvent.bool_1 = false;
			}
			else
			{
				try
				{
					new FormBanEvent
					{
						int_2 = Cursor.Position.X,
						int_3 = Cursor.Position.Y,
						int_4 = base.Width,
						int_5 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00126F74 File Offset: 0x00125174
		private void buttonOpenAllWeb_Click(object sender, EventArgs e)
		{
			string text = Environment.GetEnvironmentVariable("programfiles") + "\\Google\\Chrome\\Application\\chrome.exe";
			bool flag = !Class12.smethod_17(text);
			if (flag)
			{
				text = Class62.smethod_0();
			}
			int num = Class12.smethod_11(this.textBoxDelta.Text);
			int num2 = Class12.smethod_11(this.textBoxStart.Text);
			this.textBoxStart.Text = (num2 + num).ToString();
			do
			{
				string text2 = Form1.listwebdomain[num2][0];
				bool flag2 = !(text2 == "khác");
				if (flag2)
				{
					foreach (string text2 in text2.Split(new char[]
					{
						'+',
						' ',
						','
					}))
					{
						bool flag3 = text2 == string.Empty || text2 == null;
						if (!flag3)
						{
							text2 = text2.Trim();
							bool flag4 = text2.Length >= 6;
							if (flag4)
							{
								bool flag5 = Class12.smethod_1(text2, "://") < 0;
								if (flag5)
								{
									text2 = "http://" + text2;
								}
								Class22.smethod_40(text, "", text2, 0, false, false);
							}
						}
					}
				}
				num2++;
				num--;
			}
			while (num2 < Form1.string_4.GetLength(0) && num > 0);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x001270E4 File Offset: 0x001252E4
		private void comboBoxTrinhsat_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				Form1.bool_9 = false;
				string text = this.comboBoxTrinhsat.Text;
				string text2 = string.Empty;
				this.comboBoxTrinhsat.Items.Clear();
				this.comboBoxTrinhsat.Items.Add(string.Empty);
				Form1.string_51 = null;
				Class98.smethod_25(Form1.gstruct49_0[num], ref Form1.string_51, 3, null);
				bool flag2 = Form1.string_51 != null;
				if (flag2)
				{
					for (int i = 0; i < Form1.string_51.Length; i++)
					{
						string text3 = Class10.smethod_1(Form1.string_51[i], 1, false);
						bool flag3 = text3 == text;
						if (flag3)
						{
							text2 = text3;
						}
						this.comboBoxTrinhsat.Items.Add(text3);
					}
					bool flag4 = text2 == string.Empty;
					if (flag4)
					{
						text2 = Class10.smethod_1(Form1.string_51[0], 1, false);
					}
				}
				bool flag5 = text2 != string.Empty;
				if (flag5)
				{
					this.comboBoxTrinhsat.Text = text2;
				}
				Thread.Sleep(3);
				Form1.bool_9 = true;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00127220 File Offset: 0x00125420
		private void comboBoxTrinhsat_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_51 == null;
			if (!flag)
			{
				string text = this.comboBoxTrinhsat.Text;
				bool flag2 = text != null && !(text == string.Empty);
				if (flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num < 0;
					if (!flag3)
					{
						bool flag4 = false;
						for (int i = 0; i < Form1.string_51.Length; i++)
						{
							bool flag5 = text == Class10.smethod_1(Form1.string_51[i], 1, false);
							if (flag5)
							{
								Class56.string_0 = Form1.string_51[i];
								flag4 = true;
								break;
							}
						}
						bool flag6 = flag4;
						if (flag6)
						{
							int num2 = Class98.smethod_13(Form1.gstruct49_0[num], Class56.string_0, 3, false, -1, 80);
							Class56.uint_2 = Class98.smethod_19(Form1.gstruct49_0[num], num2);
							bool flag7 = Class56.uint_2 != null && (Class56.uint_2[0] == 0U || Class56.uint_2[1] == 0U);
							if (flag7)
							{
								Class56.uint_2 = null;
							}
							bool flag8 = Class56.uint_2 == null;
							if (flag8)
							{
								this.labelToadoTrinhsat.Text = "{ ... mặc định }";
								Class56.string_0 = null;
								this.comboBoxTrinhsat.Items.Clear();
							}
							else
							{
								this.labelToadoTrinhsat.Text = "Tọa độ: " + (Class56.uint_2[0] / 256U).ToString() + "," + (Class56.uint_2[1] / 512U).ToString();
							}
						}
					}
				}
				else
				{
					Class56.string_0 = null;
					this.labelToadoTrinhsat.Text = "{ ... mặc định }";
				}
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x001273FC File Offset: 0x001255FC
		private void checkBoxBaoKeylog_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_68 = (int)Convert.ToByte(this.checkBoxBaoKeylog.Checked);
				FormAntivirus.bool_1 = false;
				Class62.smethod_10(Class53.string_3, "BaoKeylog", Form1.int_68, "", 0);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00127460 File Offset: 0x00125660
		private void checkBoxDenToadoLeave_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_76 = (int)Convert.ToByte(this.checkBoxDenToadoLeave.Checked);
					Class62.smethod_10(Class53.string_3, "fDenToadoLeave", Form1.int_76, "", 0);
				}
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x001274CC File Offset: 0x001256CC
		private void checkBoxTHPChienLong_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_110 = (int)Convert.ToByte(this.checkBoxTHPChienLong.Checked);
				Class62.smethod_10(Class53.string_3, "flagThpCLD", Form1.int_110, "", 0);
			}
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0012752C File Offset: 0x0012572C
		private void comboBoxCTC_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_24 = 0;
					for (int i = 0; i < Form1.string_13.Length; i++)
					{
						bool flag2 = this.comboBoxCTC.Text == Form1.string_13[i];
						if (flag2)
						{
							Form1.int_24 = i;
							break;
						}
					}
					this.method_1();
				}
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x001275B0 File Offset: 0x001257B0
		private void buttonLayMapTamMondai_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (flag)
			{
				FormTip.smethod_0(Form1.string_1, "Hãy chọn 1 ac đang đứng trong Tam môn đài rồi lấy map id.", 60000, 250, 100, false, -1, -1, false, false, false);
			}
			else
			{
				int num2 = Class37.smethod_0(Form1.gstruct49_0[num]);
				bool flag2 = num2 > 0;
				if (flag2)
				{
					Form1.int_26 = num2;
					Class62.smethod_10(Class53.string_3, "TamMonDaiMapID", Form1.int_26, "", 0);
					this.textBoxTamMonDaiMapId.Text = Form1.int_26.ToString();
				}
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00127658 File Offset: 0x00125858
		private void buttonMapTamMondaiMacdinh_Click(object sender, EventArgs e)
		{
			Form1.int_26 = 221;
			this.textBoxTamMonDaiMapId.Text = Form1.int_26.ToString();
			Class62.smethod_10(Class53.string_3, "TamMonDaiMapID", Form1.int_26, "", 0);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x001276A8 File Offset: 0x001258A8
		private void buttonResetAuto_Click(object sender, EventArgs e)
		{
			string text = string.Concat(new string[]
			{
				"Sau khi reset cấu hình auto, bạn phải thiết lập lại các thông số cho ac (như chiêu thức, mua máu, ...).",
				Class53.string_7,
				Class53.string_7,
				"Tuy có vẻ hơi mất công và cực nhọc, nhưng điều này sẽ giúp sửa các lỗi thiết lập cấu hình (mà bạn lỡ out ac A log ac B trên cùng 1 game) trước đây, làm cho auto và game nhanh nhẹ hơn.",
				Class53.string_7,
				Class53.string_7,
				"Vậy bạn có chắc chắn muốn reset ?"
			});
			bool flag = MessageBox.Show(text, Form1.string_1, MessageBoxButtons.YesNo) != DialogResult.No;
			if (flag)
			{
				new Thread(new ThreadStart(this.method_29)).Start();
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00127728 File Offset: 0x00125928
		private void method_29()
		{
			try
			{
				this.method_31();
				this.method_30();
			}
			catch
			{
			}
			TryNewVersion.int_0 = 2;
			Form1.string_21 = null;
			Form1.int_128 = 0;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00127770 File Offset: 0x00125970
		private void method_30()
		{
			string[] array = new string[]
			{
				Class12.smethod_0(Class12.char_30).ToLower(),
				Class12.smethod_0(Class12.char_31).ToLower()
			};
			string[] files = Directory.GetFiles(Class53.string_9, "*.*", SearchOption.AllDirectories);
			bool flag = files == null || files.Length == 0;
			if (!flag)
			{
				for (int i = 0; i < files.Length; i++)
				{
					bool flag2 = files[i] == null || files[i] == string.Empty;
					if (!flag2)
					{
						string[] array2 = files[i].Split(new char[]
						{
							'\\'
						});
						string text = array2[array2.Length - 1];
						bool flag3 = text == null || text == string.Empty;
						if (!flag3)
						{
							text = text.ToLower();
							for (int j = 0; j < array.Length; j++)
							{
								bool flag4 = text == array[j];
								if (flag4)
								{
									text = null;
									break;
								}
							}
							bool flag5 = text != null;
							if (flag5)
							{
								Class12.smethod_20(files[i]);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00127894 File Offset: 0x00125A94
		private void method_31()
		{
			string[] array = new string[]
			{
				"PathGame",
				"textIDSudung",
				"TenWeb"
			};
			for (int i = 0; i < 2; i++)
			{
				string[] array2 = Class62.smethod_9(Class53.string_3, i > 0, false, 0);
				bool flag = array2 == null;
				if (!flag)
				{
					for (int j = 0; j < array2.Length; j++)
					{
						bool flag2 = false;
						for (int k = 0; k < array.Length; k++)
						{
							bool flag3 = array[k].ToLower() == array2[j].ToLower();
							if (flag3)
							{
								flag2 = true;
								break;
							}
						}
						bool flag4 = !flag2;
						if (flag4)
						{
							Class62.smethod_12(Class53.string_3, array2[j], (byte)i);
						}
					}
				}
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0012796C File Offset: 0x00125B6C
		private void buttonTamMonDaiHD_Click(object sender, EventArgs e)
		{
			string str = "https://youtu.be/fWjrqZWKKDQ";
			Class22.smethod_40(Class62.smethod_0(), "", str, 0, false, false);
			str = "Dán vào trình duyệt link sau nếu không xem được:" + str;
			FormTip.smethod_0(Form1.string_1, str, 60000, 250, 100, false, -1, -1, false, false, false);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x001279C0 File Offset: 0x00125BC0
		private void checkBoxMuaMauFree_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_78 = (int)Convert.ToByte(this.checkBoxMuaMauFree.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, 1, 4);
				}
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00127A58 File Offset: 0x00125C58
		private void checkBoxChuyenChinhxac_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					Form1.int_95 = (int)Convert.ToByte(this.checkBoxChuyenChinhxac.Checked);
					Class62.smethod_10(Class53.string_3, "fChuyenThuocChinhxacTen", Form1.int_95, "", 0);
				}
			}
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00127AC4 File Offset: 0x00125CC4
		private void checkBoxVeThanhCt_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_96 = (int)Convert.ToByte(this.checkBoxVeThanhCt.Checked);
				Class62.smethod_10(Class53.string_3, "fChuyenThuocTruocMua", Form1.int_96, "", 0);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00127B24 File Offset: 0x00125D24
		private void checkBoxVukhi0_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct45_0[0].int_0 = (int)Convert.ToByte(this.checkBoxVukhi0.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00127BB0 File Offset: 0x00125DB0
		private void checkBoxVukhi1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct45_0[1].int_0 = (int)Convert.ToByte(this.checkBoxVukhi1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00127C3C File Offset: 0x00125E3C
		private void comboBoxVukhiKieu0_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxVukhiKieu0.Text;
					for (int i = 0; i < this.string_35.Length; i++)
					{
						bool flag3 = text == this.string_35[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].gstruct45_0[0].int_1 = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00127D00 File Offset: 0x00125F00
		private void comboBoxVukhiKieu1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxVukhiKieu1.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < this.string_35.Length;
						if (!flag3)
						{
							goto IL_83;
						}
						bool flag4 = text == this.string_35[num2];
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].gstruct45_0[1].int_1 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_83:;
				}
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00127DC8 File Offset: 0x00125FC8
		private void textBoxVukhi0_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct45_0[0].int_2 = Class12.smethod_11(this.textBoxVukhi0.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00127E54 File Offset: 0x00126054
		private void textBoxVukhi1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct45_0[1].int_2 = Class12.smethod_11(this.textBoxVukhi1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00127EE0 File Offset: 0x001260E0
		private void comboBoxVukhi0_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.bool_9 = false;
					this.comboBoxVukhi0.Items.Clear();
					GStruct49 gstruct = Form1.gstruct49_0[num];
					int[] object_ = new int[]
					{
						1,
						2,
						3
					};
					int[] array = new int[1];
					Form1.gstruct57_0 = Class79.smethod_36(gstruct, object_, array, true);
					bool flag3 = Form1.gstruct57_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct57_0.Length; i++)
						{
							this.comboBoxVukhi0.Items.Add(Class10.smethod_1(Form1.gstruct57_0[i].string_0, 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00127FEC File Offset: 0x001261EC
		private void comboBoxVukhi1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.gstruct49_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					Form1.bool_9 = false;
					this.comboBoxVukhi1.Items.Clear();
					GStruct49 gstruct = Form1.gstruct49_0[num];
					int[] object_ = new int[]
					{
						1,
						2,
						3
					};
					int[] array = new int[1];
					Form1.gstruct57_0 = Class79.smethod_36(gstruct, object_, array, true);
					bool flag3 = Form1.gstruct57_0 != null;
					if (flag3)
					{
						for (int i = 0; i < Form1.gstruct57_0.Length; i++)
						{
							this.comboBoxVukhi1.Items.Add(Class10.smethod_1(Form1.gstruct57_0[i].string_0, 1, false));
						}
					}
					Thread.Sleep(10);
					Form1.bool_9 = true;
				}
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x001280F8 File Offset: 0x001262F8
		private void comboBoxVukhi0_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.gstruct57_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxVukhi0.Text;
					for (int i = 0; i < Form1.gstruct57_0.Length; i++)
					{
						bool flag3 = !(text == Class10.smethod_1(Form1.gstruct57_0[i].string_0, 1, false));
						if (!flag3)
						{
							Form1.gstruct49_0[num].gstruct45_0[0].string_0 = Form1.gstruct57_0[i].string_0;
							Form1.gstruct49_0[num].gstruct45_0[0].int_5 = null;
							bool flag4 = Form1.gstruct57_0[i].int_0 != null;
							if (flag4)
							{
								Form1.gstruct49_0[num].gstruct45_0[0].int_5 = new int[Form1.gstruct57_0[i].int_0.Length];
								for (int j = 0; j < Form1.gstruct57_0[i].int_0.Length; j++)
								{
									Form1.gstruct49_0[num].gstruct45_0[0].int_5[j] = Form1.gstruct57_0[i].int_0[j];
								}
							}
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x001282B8 File Offset: 0x001264B8
		private void comboBoxVukhi1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.gstruct57_0 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxVukhi1.Text;
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < Form1.gstruct57_0.Length;
						if (!flag3)
						{
							goto IL_9B;
						}
						bool flag4 = text == Class10.smethod_1(Form1.gstruct57_0[num2].string_0, 1, false);
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].gstruct45_0[1].string_0 = Form1.gstruct57_0[num2].string_0;
					Form1.gstruct49_0[num].gstruct45_0[1].int_5 = null;
					bool flag5 = Form1.gstruct57_0[num2].int_0 != null;
					if (flag5)
					{
						Form1.gstruct49_0[num].gstruct45_0[1].int_5 = new int[Form1.gstruct57_0[num2].int_0.Length];
						for (int i = 0; i < Form1.gstruct57_0[num2].int_0.Length; i++)
						{
							Form1.gstruct49_0[num].gstruct45_0[1].int_5[i] = Form1.gstruct57_0[num2].int_0[i];
						}
					}
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_9B:;
				}
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00128470 File Offset: 0x00126670
		private void textBoxLocTocdo_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class12.smethod_11(this.textBoxLocTocdo.Text);
					bool flag3 = num2 < 0 || num2 > 15000;
					if (flag3)
					{
						num2 = 100;
					}
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_11, num2, 4);
					Form1.gstruct49_0[num].int_11 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00128528 File Offset: 0x00126728
		private void buttonTatcaMuamau_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				Class56.int_0 = 1;
				Class56.long_0 = Class12.smethod_27();
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool bool_ = Form1.gstruct49_0[i].bool_25;
					if (bool_)
					{
						Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 1, 4);
					}
				}
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00128598 File Offset: 0x00126798
		private void buttonStopMuamau_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				Class56.int_0 = 2;
				Class56.long_0 = Class12.smethod_27();
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Class70.smethod_2(Form1.gstruct49_0[i], Class70.uint_22, 0, 4);
				}
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x001285F4 File Offset: 0x001267F4
		private void buttonCongHauDoanh_Click(object sender, EventArgs e)
		{
			bool flag = FormChayMuaMauTK.bool_0;
			if (flag)
			{
				FormChayMuaMauTK.bool_0 = false;
			}
			else
			{
				try
				{
					FormChayMuaMauTK.int_0 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormChayMuaMauTK.int_0 = Form1.gstruct49_0[num].int_136;
					}
					FormChayMuaMauTK formChayMuaMauTK = new FormChayMuaMauTK();
					formChayMuaMauTK.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00128678 File Offset: 0x00126878
		private void buttonStopSudung_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				Form1.gstruct49_0[num].bool_51 = false;
				Form1.gstruct49_0[num].bool_53 = false;
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x001286CC File Offset: 0x001268CC
		private void buttonStopSudungAll_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].bool_51 = false;
					Form1.gstruct49_0[i].bool_53 = false;
				}
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00128724 File Offset: 0x00126924
		private void buttonBatdauMua_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0 && !Form1.gstruct49_0[num].bool_47 && !Form1.gstruct49_0[num].bool_51;
			if (flag)
			{
				Form1.gstruct49_0[num].bool_51 = true;
				Class40.int_0 = Form1.gstruct49_0[num].int_136;
				new Thread(new ThreadStart(Class40.smethod_2)).Start();
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x001287B8 File Offset: 0x001269B8
		private void buttonBatdauSudung_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0 && !Form1.gstruct49_0[num].bool_52 && !Form1.gstruct49_0[num].bool_53;
			if (flag)
			{
				Form1.gstruct49_0[num].bool_53 = true;
				Class40.int_1 = Form1.gstruct49_0[num].int_136;
				new Thread(new ThreadStart(Class40.smethod_4)).Start();
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0012884C File Offset: 0x00126A4C
		private void checkBoxCaudame_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_130[0] = (int)Convert.ToByte(this.checkBoxCaudame.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x001288CC File Offset: 0x00126ACC
		private void textBoxCaudame_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_130[1] = Class12.smethod_11(this.textBoxCaudame.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0012894C File Offset: 0x00126B4C
		private void comboBoxKieudiCLD_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				string text = this.comboBoxKieudiCLD.Text;
				int num = 0;
				for (;;)
				{
					bool flag2 = num < Form1.string_32.Length;
					if (!flag2)
					{
						goto IL_5A;
					}
					bool flag3 = text == Form1.string_32[num];
					if (flag3)
					{
						break;
					}
					num++;
				}
				Form1.int_111 = num;
				Class62.smethod_10(Class53.string_3, "flagKieuDiCLD", Form1.int_111, "", 0);
				IL_5A:;
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x001289E0 File Offset: 0x00126BE0
		private void buttonBanVatphamRac_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				FormBanEvent.int_0 = Form1.gstruct49_0[num].int_136;
				FormBanEvent.smethod_3();
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00128A2C File Offset: 0x00126C2C
		private void buttonTatCaBanVatPhamRac_Click(object sender, EventArgs e)
		{
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				this.buttonTatCaBanVatPhamRac.Enabled = false;
				try
				{
					for (int i = 0; i < Form1.gstruct49_0.Length; i++)
					{
						for (int j = 0; j < 100; j++)
						{
							bool flag2 = FormBanEvent.int_0 <= 0;
							if (flag2)
							{
								break;
							}
							Thread.Sleep(30);
						}
						bool bool_ = Form1.gstruct49_0[i].bool_25;
						if (bool_)
						{
							FormBanEvent.int_0 = Form1.gstruct49_0[i].int_136;
							new Thread(new ThreadStart(FormBanEvent.smethod_3)).Start();
						}
					}
				}
				catch
				{
				}
				Thread.Sleep(100);
				this.buttonTatCaBanVatPhamRac.Enabled = true;
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00128B18 File Offset: 0x00126D18
		private void buttonTangdiem_Click(object sender, EventArgs e)
		{
			bool flag = FormTangdiem.bool_0;
			if (flag)
			{
				FormTangdiem.bool_0 = false;
			}
			else
			{
				try
				{
					new FormTangdiem
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00128B90 File Offset: 0x00126D90
		private void buttonBuffLaiTranphai_Click(object sender, EventArgs e)
		{
			int num = 0;
			byte[] byte_ = new byte[]
			{
				1
			};
			bool flag = Form1.gstruct49_0 == null;
			if (!flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					bool bool_ = Form1.gstruct49_0[i].bool_25;
					if (bool_)
					{
						Class22.WriteProcessMemory(Form1.gstruct49_0[i].int_137, Form1.gstruct49_0[i].uint_15 + Class70.uint_41 * 4U, byte_, 1, ref num);
					}
				}
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00128C1C File Offset: 0x00126E1C
		private void checkBoxTatBuffTamthoi_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.bool_8 = this.checkBoxTatBuffTamthoi.Checked;
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00128C54 File Offset: 0x00126E54
		private void checkBoxTTDT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_84[1] = (int)Convert.ToByte(this.checkBoxTTDT.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00128CD4 File Offset: 0x00126ED4
		private void buttonTongKimClickMenu_Click(object sender, EventArgs e)
		{
			bool flag = FormMenuClick.bool_0;
			if (flag)
			{
				FormMenuClick.bool_0 = false;
			}
			else
			{
				try
				{
					FormMenuClick.string_0 = Form1.string_39;
					FormMenuClick.int_2 = Form1.int_126;
					new FormMenuClick
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y
					}.Show();
				}
				catch
				{
					FormMenuClick.string_0 = null;
					FormMenuClick.bool_1 = false;
					FormMenuClick.bool_0 = false;
				}
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00128D68 File Offset: 0x00126F68
		private void buttonMenuLocClick_Click(object sender, EventArgs e)
		{
			bool flag = FormMenuClick.bool_0;
			if (flag)
			{
				FormMenuClick.bool_0 = false;
			}
			else
			{
				try
				{
					FormMenuClick.string_0 = FormLocdoTest.string_1;
					FormMenuClick.int_2 = FormLocdoTest.int_13;
					new FormMenuClick
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y
					}.Show();
				}
				catch
				{
					FormMenuClick.string_0 = null;
					FormMenuClick.bool_1 = false;
					FormMenuClick.bool_0 = false;
				}
			}
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00128DFC File Offset: 0x00126FFC
		private void buttonNpcClickMenu_Click(object sender, EventArgs e)
		{
			bool flag = FormMenuClick.bool_0;
			if (flag)
			{
				FormMenuClick.bool_0 = false;
			}
			else
			{
				try
				{
					bool flag2 = this.timer_0.Enabled && Form1.bool_9;
					if (flag2)
					{
						int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
						bool flag3 = num >= 0;
						if (flag3)
						{
							FormMenuClick.string_0 = "PID:" + Form1.gstruct49_0[num].int_136.ToString();
							FormMenuClick.int_2 = Form1.gstruct49_0[num].int_9;
							new FormMenuClick
							{
								int_0 = Cursor.Position.X,
								int_1 = Cursor.Position.Y
							}.Show();
						}
					}
				}
				catch
				{
					FormMenuClick.string_0 = null;
					FormMenuClick.bool_1 = false;
					FormMenuClick.bool_0 = false;
				}
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00128F00 File Offset: 0x00127100
		private void checkBoxChuyenTrai1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[0].int_0 = (int)Convert.ToByte(this.checkBoxChuyenTrai1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00128F8C File Offset: 0x0012718C
		private void comboBoxChuyenTrai1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[0].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenTrai1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00129028 File Offset: 0x00127228
		private void comboBoxKieu1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < this.string_35.Length;
						if (!flag3)
						{
							goto IL_7F;
						}
						bool flag4 = this.comboBoxKieu1.Text == this.string_35[num2];
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].gstruct46_0[0].int_3 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_7F:;
				}
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x001290EC File Offset: 0x001272EC
		private void textBoxChuyenTrai1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[0].int_2 = Class12.smethod_11(this.textBoxChuyenTrai1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00129178 File Offset: 0x00127378
		private void checkBoxChuyenTrai2_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].gstruct46_0[1].int_0 = (int)Convert.ToByte(this.checkBoxChuyenTrai2.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00129210 File Offset: 0x00127410
		private void comboBoxChuyenTrai2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[1].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenTrai2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x001292AC File Offset: 0x001274AC
		private void comboBoxKieu2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					for (int i = 0; i < this.string_35.Length; i++)
					{
						bool flag3 = this.comboBoxKieu2.Text == this.string_35[i];
						if (flag3)
						{
							Form1.gstruct49_0[num].gstruct46_0[1].int_3 = i;
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00129368 File Offset: 0x00127568
		private void textBoxChuyenTrai2_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].gstruct46_0[1].int_2 = Class12.smethod_11(this.textBoxChuyenTrai2.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00129400 File Offset: 0x00127600
		private void checkBoxChuyenTrai3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[2].int_0 = (int)Convert.ToByte(this.checkBoxChuyenTrai3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0012948C File Offset: 0x0012768C
		private void comboBoxChuyenTrai3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[2].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenTrai3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00129528 File Offset: 0x00127728
		private void comboBoxKieu3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					int num2 = 0;
					for (;;)
					{
						bool flag3 = num2 < this.string_35.Length;
						if (!flag3)
						{
							goto IL_7F;
						}
						bool flag4 = this.comboBoxKieu3.Text == this.string_35[num2];
						if (flag4)
						{
							break;
						}
						num2++;
					}
					Form1.gstruct49_0[num].gstruct46_0[2].int_3 = num2;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					IL_7F:;
				}
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x001295EC File Offset: 0x001277EC
		private void textBoxChuyenTrai3_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_0[2].int_2 = Class12.smethod_11(this.textBoxChuyenTrai3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00129678 File Offset: 0x00127878
		private void checkBoxChuyenPhai1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[0].int_0 = (int)Convert.ToByte(this.checkBoxChuyenPhai1.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00129704 File Offset: 0x00127904
		private void comboBoxChuyenPhai1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[0].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenPhai1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x001297A0 File Offset: 0x001279A0
		private void textBoxChuyenPhai1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[0].int_2 = Class12.smethod_11(this.textBoxChuyenPhai1.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0012982C File Offset: 0x00127A2C
		private void checkBoxChuyenPhai2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[1].int_0 = (int)Convert.ToByte(this.checkBoxChuyenPhai2.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x001298B8 File Offset: 0x00127AB8
		private void comboBoxChuyenPhai2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[1].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenPhai2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00129954 File Offset: 0x00127B54
		private void textBoxChuyenPhai2_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[1].int_2 = Class12.smethod_11(this.textBoxChuyenPhai2.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x001299E0 File Offset: 0x00127BE0
		private void checkBoxChuyenPhai3_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[2].int_0 = (int)Convert.ToByte(this.checkBoxChuyenPhai3.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00129A6C File Offset: 0x00127C6C
		private void comboBoxChuyenPhai3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[2].int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxChuyenPhai3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00129B08 File Offset: 0x00127D08
		private void textBoxChuyenPhai3_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_1[2].int_2 = Class12.smethod_11(this.textBoxChuyenPhai3.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00129B94 File Offset: 0x00127D94
		private void checkBoxGapBossChieu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_2.int_0 = (int)Convert.ToByte(this.checkBoxGapBossChieu.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00129C18 File Offset: 0x00127E18
		private void comboBoxGapBoss_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_2.int_1 = Class77.smethod_12(Form1.gstruct49_0[num].gstruct56_0, this.comboBoxGapBoss.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00129CAC File Offset: 0x00127EAC
		private void checkBoxGapBossNL_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_2.int_3 = (int)Convert.ToByte(this.checkBoxGapBossNL.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00129D30 File Offset: 0x00127F30
		private void textBoxGapBoss_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct46_2.int_2 = Class12.smethod_11(this.textBoxGapBoss.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00129DB4 File Offset: 0x00127FB4
		private void textBoxClickNPCMenu_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9 && !FormMenuClick.bool_0;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_9 = Class12.smethod_69(this.textBoxClickNPCMenu.Text, new char[]
					{
						',',
						';',
						'.',
						'/',
						':',
						'-'
					});
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00129E50 File Offset: 0x00128050
		private void textBoxMenuTest_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				bool flag2 = FormMenuClick.bool_0;
				if (!flag2)
				{
					FormLocdoTest.int_13 = Class12.smethod_69(this.textBoxMenuTest.Text, new char[]
					{
						',',
						';',
						'.',
						'/',
						':',
						'-'
					});
					Class62.smethod_10(Class53.string_3, FormLocdoTest.string_1, Class12.smethod_68(FormLocdoTest.int_13, ','), "", 0);
				}
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00129ED4 File Offset: 0x001280D4
		private void textBoxMuaMienphiMenu_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				bool flag2 = FormMenuClick.bool_0;
				if (!flag2)
				{
					Form1.int_125 = Class12.smethod_69(this.textBoxMuaMienphiMenu.Text, new char[]
					{
						',',
						';',
						'.',
						'/',
						':',
						'-'
					});
					Class62.smethod_10(Class53.string_3, Form1.string_38, Class12.smethod_68(Form1.int_125, ','), "", 0);
				}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00129F58 File Offset: 0x00128158
		private void textBoxClickMenuTS_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9 && !FormMenuClick.bool_0;
			if (flag)
			{
				Form1.int_126 = Class12.smethod_69(this.textBoxClickMenuTS.Text, new char[]
				{
					',',
					';',
					'.',
					'/',
					':',
					'-'
				});
				Class62.smethod_10(Class53.string_3, Form1.string_39, Class12.smethod_68(Form1.int_126, ','), "", 0);
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00129FD4 File Offset: 0x001281D4
		private void checkBoxThanhTruot_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(this.checkBoxThanhTruot.Checked);
					Form1.gstruct49_0[num].gstruct47_0.int_6 = num2;
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_14, num2, 4);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.textBoxThoiGianTruot.Enabled = (num2 > 0);
				}
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0012A084 File Offset: 0x00128284
		private void textBoxThoiGianTruot_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct47_0.int_7 = Class12.smethod_11(this.textBoxThoiGianTruot.Text);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0012A108 File Offset: 0x00128308
		private void checkBoxDungCodinh_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = (int)Convert.ToByte(this.checkBoxDungCodinh.Checked);
					Form1.gstruct49_0[num].gstruct47_0.int_8 = num2;
					uint[] array = Class36.smethod_30(Form1.gstruct49_0[num]);
					Form1.gstruct49_0[num].gstruct47_0.int_9 = (int)array[0];
					Form1.gstruct49_0[num].gstruct47_0.int_10 = (int)array[1];
					GStruct49 gstruct = Form1.gstruct49_0[num];
					Class70.smethod_2(gstruct, Class70.uint_15, num2, 4);
					Class70.smethod_2(gstruct, Class70.uint_16, gstruct.gstruct47_0.int_9, 4);
					Class70.smethod_2(gstruct, Class70.uint_16 + 1U, gstruct.gstruct47_0.int_10, 4);
					Class70.smethod_2(gstruct, Class70.uint_16 + 2U, Class37.smethod_0(gstruct), 4);
					Class53.smethod_13(gstruct, null);
				}
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0012A238 File Offset: 0x00128438
		private void textBoxPhamviNhatqua_TextChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].gstruct47_0.int_1 = Class12.smethod_11(this.textBoxPhamviNhatqua.Text);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0012A2C8 File Offset: 0x001284C8
		private void buttonResetTenNhatQua_Click(object sender, EventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num >= 0;
			if (flag)
			{
				string text = Class53.string_22;
				Form1.gstruct49_0[num].gstruct47_0.string_0 = text;
				Class53.smethod_13(Form1.gstruct49_0[num], null);
				text = Class10.smethod_1(text, 1, false);
				this.comboBoxNhatQua.Items.Clear();
				this.comboBoxNhatQua.Items.Add(text);
				this.comboBoxNhatQua.Text = text;
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0012A360 File Offset: 0x00128560
		private void comboBoxNhatQua_MouseDown(object sender, MouseEventArgs e)
		{
			int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
			bool flag = num < 0;
			if (!flag)
			{
				Form1.string_52 = new string[]
				{
					Class53.string_22
				};
				Class99.smethod_0(Form1.gstruct49_0[num], ref Form1.string_52);
				Class99.smethod_1(Form1.gstruct49_0[num], ref Form1.string_52);
				Class99.smethod_2(Form1.gstruct49_0[num], ref Form1.string_52, 0);
				string text = this.comboBoxNhatQua.Text;
				Form1.bool_9 = false;
				this.comboBoxNhatQua.Items.Clear();
				for (int i = 0; i < Form1.string_52.Length; i++)
				{
					string text2 = Class10.smethod_1(Form1.string_52[i], 1, false);
					this.comboBoxNhatQua.Items.Add(text2);
					bool flag2 = text2 == text;
					if (flag2)
					{
						this.comboBoxNhatQua.Text = text;
					}
				}
				Form1.bool_9 = true;
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0012A468 File Offset: 0x00128668
		private void comboBoxNhatQua_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled || !Form1.bool_9 || Form1.string_52 == null;
			if (!flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num < 0;
				if (!flag2)
				{
					string text = this.comboBoxNhatQua.Text;
					for (int i = 0; i < Form1.string_52.Length; i++)
					{
						bool flag3 = Class10.smethod_1(Form1.string_52[i], 1, false) == text;
						if (flag3)
						{
							Form1.gstruct49_0[num].gstruct47_0.string_0 = Form1.string_52[i];
							Class53.smethod_13(Form1.gstruct49_0[num], null);
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0012A535 File Offset: 0x00128735
		private void buttonVang_Click(object sender, EventArgs e)
		{
			FormDoiMauBang.smethod_0(1U);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0012A53F File Offset: 0x0012873F
		private void buttonXanh_Click(object sender, EventArgs e)
		{
			FormDoiMauBang.smethod_0(3U);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0012A549 File Offset: 0x00128749
		private void buttonTim_Click(object sender, EventArgs e)
		{
			FormDoiMauBang.smethod_0(2U);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0012A554 File Offset: 0x00128754
		private void buttonTudoiMaubang_Click(object sender, EventArgs e)
		{
			bool flag = FormDoiMauBang.bool_0;
			if (flag)
			{
				FormDoiMauBang.bool_0 = false;
			}
			else
			{
				bool flag2 = FormDoiMauBang.gstruct2_0.gstruct49_0.int_136 == 0 || FormDoiMauBang.gstruct2_0.gstruct49_0.string_22 == null || FormDoiMauBang.gstruct2_0.gstruct49_0.string_22 == string.Empty;
				if (flag2)
				{
					FormTip.smethod_0("Đổi màu", "Hãy chọn trước tên ac đổi màu.", 300000, 230, 140, false, -1, -1, false, false, false);
				}
				else
				{
					try
					{
						new FormDoiMauBang
						{
							int_0 = Cursor.Position.X,
							int_1 = Cursor.Position.Y
						}.Show();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0012A630 File Offset: 0x00128830
		private void method_32()
		{
			bool flag = FormLocdo.bool_0;
			if (flag)
			{
				FormLocdo.bool_0 = false;
			}
			else
			{
				try
				{
					FormLocdo.int_4 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormLocdo.int_4 = Form1.gstruct49_0[num].int_136;
					}
					new FormLocdo
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0012A6E8 File Offset: 0x001288E8
		private void labelLocdo_Click(object sender, EventArgs e)
		{
			this.method_32();
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0012A6E8 File Offset: 0x001288E8
		private void labelLocBando_Click(object sender, EventArgs e)
		{
			this.method_32();
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0012A6F4 File Offset: 0x001288F4
		private void buttonBandoCTC_Click(object sender, EventArgs e)
		{
			string text = "09XFDlyObTi2MC9dwTnj8KJSLPJcNQpEAIKKaricMh/ubs9T8M7MyyDTFJ/Di3IVHPOo5qKAjGMbHu5eDPR8CIgxNy8d5ukQaKBAAwctSBSOTHi4a2Em0D17iXMLYcdSzRwcsawbknF4ATDgj0w4vAW7Ai4A";
			FormTip.smethod_0(Form1.string_1, Class12.smethod_71(text), 600000, 380, 180, false, base.Left, base.Top, false, false, true);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0012A738 File Offset: 0x00128938
		private void checkBoxTuChayVA_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_122 = (int)Convert.ToByte(this.checkBoxTuChayVA.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0012A7B8 File Offset: 0x001289B8
		private void buttonBatGiaodichAll_Click(object sender, EventArgs e)
		{
			this.bool_19 = !this.bool_19;
			bool flag = this.bool_19;
			if (flag)
			{
				this.buttonBatGiaodichAll.Text = "Tắt giao dịch tất cả";
			}
			else
			{
				this.buttonBatGiaodichAll.Text = "Bật giao dịch tất cả";
			}
			new Thread(new ThreadStart(this.method_33)).Start();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0012A81C File Offset: 0x00128A1C
		private void method_33()
		{
			int num = -1;
			for (;;)
			{
				num++;
				try
				{
					bool flag = Form1.gstruct49_0 == null || Form1.gstruct49_0.Length <= num;
					if (flag)
					{
						break;
					}
					GStruct49 gstruct = Form1.gstruct49_0[num];
					uint num2 = Class22.smethod_30(Class53.gstruct51_11.uint_0, gstruct.int_137);
					uint num3 = Class22.smethod_30(num2 + Class53.gstruct51_13.uint_0, gstruct.int_137) * Class53.gstruct51_15.uint_0;
					uint num4 = Class22.smethod_30(Class53.gstruct51_14.uint_0, gstruct.int_137);
					uint num5 = num4 + num3;
					uint num6 = Class22.smethod_30(num5 + Class53.gstruct51_66.uint_0, gstruct.int_137);
					bool flag2 = (this.bool_19 && num6 == 0U) || (!this.bool_19 && num6 > 0U);
					if (flag2)
					{
						Class70.smethod_57(gstruct, "Switch([[trade]])");
					}
				}
				catch
				{
					num = -1;
				}
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0012A92C File Offset: 0x00128B2C
		private void linkLabelPhimPhichiendau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string str = "https://youtu.be/dDYR4Al3LIg";
			Class22.smethod_40(Class62.smethod_0(), "", str, 0, false, false);
			string text = "Copy link sau dán vào trình duyệt nếu không tự chạy: " + Class53.string_7 + str;
			FormTip.smethod_0(Form1.string_1, text, 600000, 250, 80, false, -1, -1, false, false, false);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0012A984 File Offset: 0x00128B84
		private void checkBoxTienSkill_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					Form1.gstruct49_0[num].gstruct48_0.int_0 = (int)Convert.ToByte(this.checkBoxTienSkill.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0012AA08 File Offset: 0x00128C08
		private void buttonTienSkill_Click(object sender, EventArgs e)
		{
			bool flag = FormTienSkill.bool_0;
			if (flag)
			{
				FormTienSkill.bool_0 = false;
			}
			else
			{
				try
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						FormTienSkill.int_0 = Form1.gstruct49_0[num].int_136;
						FormTienSkill formTienSkill = new FormTienSkill();
						formTienSkill.Show();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0012AA88 File Offset: 0x00128C88
		private void linkLabelMuaMienphiMn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			bool flag = FormMenuClick.bool_0;
			if (flag)
			{
				FormMenuClick.bool_0 = false;
			}
			else
			{
				try
				{
					FormMenuClick.string_0 = Form1.string_38;
					FormMenuClick.int_2 = Form1.int_125;
					new FormMenuClick
					{
						int_0 = Cursor.Position.X,
						int_1 = Cursor.Position.Y
					}.Show();
				}
				catch
				{
					FormMenuClick.string_0 = null;
					FormMenuClick.bool_1 = false;
					FormMenuClick.bool_0 = false;
				}
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0012AB1C File Offset: 0x00128D1C
		private void checkBoxKhongNhapso_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_97 = (int)Convert.ToByte(this.checkBoxKhongNhapso.Checked);
				Class62.smethod_10(Class53.string_3, "flagMuaMpKhongNhapSo", Form1.int_97, "", 0);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0012AB7C File Offset: 0x00128D7C
		private void checkBoxHoasonMuathuoc_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_105 = (int)Convert.ToByte(this.checkBoxHoasonMuathuoc.Checked);
					Class70.smethod_2(Form1.gstruct49_0[num], Class70.uint_23, Form1.gstruct49_0[num].int_105, 4);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0012AC24 File Offset: 0x00128E24
		private void checkBoxMuaThon_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_98 = (int)Convert.ToByte(this.checkBoxMuaThon.Checked);
				Class62.smethod_10(Class53.string_3, "flagMuaThonTran", Form1.int_98, "", 0);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0012AC84 File Offset: 0x00128E84
		private void checkBoxMuaNgamy_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = 0 <= num;
				if (flag2)
				{
					Form1.gstruct49_0[num].int_70 = (int)Convert.ToByte(this.checkBoxMuaNgamy.Checked);
					Class53.smethod_13(Form1.gstruct49_0[num], null);
				}
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0012AD04 File Offset: 0x00128F04
		private void checkBoxTatmuaAll_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.bool_4 = this.checkBoxTatmuaAll.Checked;
				bool flag2 = !Form1.bool_4;
				if (flag2)
				{
					this.checkBoxTatmuaAll.BackColor = SystemColors.Control;
					this.checkBoxTatmuaAll.ForeColor = Color.Green;
				}
				else
				{
					this.checkBoxTatmuaAll.BackColor = Color.DarkGreen;
					this.checkBoxTatmuaAll.ForeColor = Color.White;
				}
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0012AD94 File Offset: 0x00128F94
		private void checkBoxDoiTitle_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_65 = (int)Convert.ToByte(this.checkBoxDoiTitle.Checked);
				Class62.smethod_10(Class53.string_3, "flagDoiTitle", Form1.int_65, "", 0);
				bool flag2 = Form1.int_65 > 0;
				if (flag2)
				{
					this.method_35(new Random().Next(10000, 10000000).ToString() + " " + Form1.string_0);
				}
				else
				{
					this.method_35(Form1.string_1);
				}
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0012AE44 File Offset: 0x00129044
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string text = Class12.smethod_71("fZI/TwIxGMb3+xTvB0AGR1cXE5WJsBCHWgi9wPUMXAmMxsE4GMNIWCCEGA1Eok7XGIfqfY9+E5/ecR5Kwta79v09f9qaWVHD6gVF3VC2SJipFFgzrLl5o0PqhDae+RQJZfWIH1Gl9f1EJyHDwup7TmdWj/GNOeqb6b7tKgDAnvpB2fNqOJtJBlDnxIUaWn0jcyGKGP4BIfdJet4BVWz8qagtzLvzLJq87YyEVKcLOs6pXJgVgg3MDGTRDCkyzyBXhVkW0tzG853EcImjQC7TGUeKN+VcCRs/Smr5WTApmCoXjgorvzpW3xVqDTXEiI0X0Z6ApdxN22d5xq9RsrZ6vtWZM+cMNZI1dbPeXv7WfZ6WXO9vVVLkc7gJB96nQLHiqpmKQurZ+GP3dtKGMZjMIHHpXgs0xz4NcKMl6jEFlzCEu50475gN3KsCTY+ok/rHTE7j5lVSJ2v9/zMskUzrjCDwwIAF7FqlzFvnB9E3FjE/dPsuRPkH");
			FormTip.smethod_0("Chuyen chinh xac", text, 300000, 340, 300, false, -1, -1, false, false, false);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0012AE80 File Offset: 0x00129080
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			int num = (int)Convert.ToByte(this.checkBoxTuChayVA.Checked);
			bool flag = Form1.gstruct49_0 != null;
			if (flag)
			{
				for (int i = 0; i < Form1.gstruct49_0.Length; i++)
				{
					Form1.gstruct49_0[i].int_122 = num;
					Class53.smethod_13(Form1.gstruct49_0[i], null);
				}
			}
			bool flag2 = num > 0;
			if (flag2)
			{
				string text = "Vượt ải để chế độ WAR, và lưu ý:||Nếu check [v] Tìm ac chính, thì chỉ có ac chính chạy tọa độ.||Còn nếu bỏ (không) check [ ] Tìm ac chính, thì tất cả đều chạy tọa độ.||Có thể kết hợp chức năng [v] Đi đến điểm tập kết khác => để click Npc Nhiếp Thí Trần tự đi vượt ải (thiết lập click menu 1,1,1 )";
				FormTip.smethod_0(Form1.string_1, text, 90000, 310, 200, false, -1, -1, false, false, false);
			}
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0012AF20 File Offset: 0x00129120
		private void buttonMd_Click(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					int num2 = Class77.smethod_13(Form1.gstruct49_0[num]);
					int num3 = Class77.smethod_16(Form1.gstruct49_0[num], num2);
					int num4 = Class77.smethod_20(Form1.gstruct49_0[num], num2, num3);
					Form1.gstruct49_0[num].int_96 = num4 - 12;
					Class53.smethod_13(Form1.gstruct49_0[num], null);
					this.textBoxKhoangCachTiepcan.Text = (num4 - 12).ToString();
				}
			}
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0012AFEC File Offset: 0x001291EC
		private void buttonNhiepTT_Click(object sender, EventArgs e)
		{
			bool flag = FormNhiepTT.bool_0;
			if (flag)
			{
				FormNhiepTT.bool_0 = false;
			}
			else
			{
				try
				{
					new FormNhiepTT
					{
						int_8 = Cursor.Position.X,
						int_9 = Cursor.Position.Y,
						int_10 = base.Width,
						int_11 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0012B074 File Offset: 0x00129274
		private void checkBoxTuClickNTT_CheckedChanged(object sender, EventArgs e)
		{
			bool enabled = this.timer_0.Enabled;
			if (enabled)
			{
				bool flag = !Form1.bool_9;
				if (!flag)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = num >= 0;
					if (flag2)
					{
						Form1.gstruct49_0[num].int_123 = (int)Convert.ToByte(this.checkBoxTuClickNTT.Checked);
						Class53.smethod_13(Form1.gstruct49_0[num], null);
					}
				}
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0012B0FF File Offset: 0x001292FF
		private void buttonTC_Click(object sender, EventArgs e)
		{
			new Thread(new ThreadStart(Class26.smethod_0)).Start();
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0012B11C File Offset: 0x0012931C
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = FormTuyenchien.bool_0;
			if (flag)
			{
				FormTuyenchien.bool_0 = false;
			}
			else
			{
				try
				{
					new FormTuyenchien
					{
						int_0 = base.Left,
						int_1 = base.Top,
						int_2 = base.Width,
						int_3 = base.Height
					}.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0012B194 File Offset: 0x00129394
		private void buttonDongtien_Click(object sender, EventArgs e)
		{
			bool flag = FormPushMoney.int_0 > 0;
			if (flag)
			{
				FormPushMoney.int_0 = 0;
			}
			else
			{
				try
				{
					FormPushMoney.int_1 = 0;
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag2 = 0 <= num;
					if (flag2)
					{
						FormPushMoney.int_1 = Form1.gstruct49_0[num].int_136;
					}
					FormPushMoney formPushMoney = new FormPushMoney();
					formPushMoney.Show();
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0012B21C File Offset: 0x0012941C
		private void checkBoxVSTDong2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				bool flag2 = !Form1.bool_9;
				if (!flag2)
				{
					int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
					bool flag3 = num >= 0;
					if (flag3)
					{
						Form1.gstruct49_0[num].int_135 = (int)Convert.ToByte(this.checkBoxVSTDong2.Checked);
					}
				}
			}
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0012B294 File Offset: 0x00129494
		private void buttonReset1ac_Click(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9 && this.int_148 <= 0;
			if (flag)
			{
				int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
				bool flag2 = num >= 0;
				if (flag2)
				{
					this.int_148 = Form1.gstruct49_0[num].int_136;
					this.string_53 = Form1.gstruct49_0[num].string_22;
					new Thread(new ThreadStart(this.method_34)).Start();
					Thread.Sleep(100);
				}
				else
				{
					Class12.string_16 = new string[]
					{
						"Hãy chọn 1 ac lỗi cần xóa cấu hình..."
					};
				}
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0012B354 File Offset: 0x00129554
		private void method_34()
		{
			bool flag = this.int_148 != 0 && this.string_53 != null && !(this.string_53 == string.Empty);
			if (flag)
			{
				string text = Class53.string_10 + "\\" + Class12.smethod_44(this.string_53) + ".cfg";
				ThemXoaDanhsach.int_1 = new int[]
				{
					this.int_148
				};
				int i = 0;
				int num = Form1.gstruct49_0.Length;
				while (i < 10)
				{
					i++;
					Thread.Sleep(100);
					bool flag2 = Form1.gstruct49_0 == null;
					if (flag2)
					{
						break;
					}
					try
					{
						bool flag3 = Form1.gstruct49_0.Length == num;
						if (!flag3)
						{
							bool flag4 = false;
							for (int j = 0; j < Form1.gstruct49_0.Length; j++)
							{
								bool flag5 = Form1.gstruct49_0[j].int_136 == this.int_148;
								if (flag5)
								{
									flag4 = true;
									break;
								}
							}
							bool flag6 = !flag4;
							if (flag6)
							{
								break;
							}
						}
					}
					catch
					{
					}
				}
				Class12.smethod_20(text);
				Thread.Sleep(100);
				ThemXoaDanhsach.int_0 = new int[]
				{
					this.int_148
				};
				Class12.string_16 = new string[]
				{
					"Đã xóa lỗi cấu hình ac <" + Class10.smethod_1(this.string_53, 1, false) + "> về mặc định..."
				};
				this.int_148 = 0;
				this.string_53 = null;
			}
			else
			{
				this.int_148 = 0;
				this.string_53 = null;
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0012B4EC File Offset: 0x001296EC
		private void buttonCopyPosXY_Click(object sender, EventArgs e)
		{
			bool flag = this.listViewTrain.Items.Count <= 0;
			if (!flag)
			{
				string text = string.Empty;
				for (int i = 0; i < this.listViewTrain.Items.Count; i++)
				{
					bool flag2 = text != string.Empty && text != null;
					if (flag2)
					{
						text += Class53.string_7;
					}
					text += this.listViewTrain.Items[i].SubItems[1].Text;
				}
				bool flag3 = !(text != string.Empty);
				if (!flag3)
				{
					try
					{
						int num = Class81.smethod_2(this.listView1, Form1.int_77, Form1.gstruct49_0);
						bool flag4 = 0 <= num;
						if (flag4)
						{
							object obj = text;
							text = string.Concat(new object[]
							{
								obj,
								Class53.string_7,
								"MAP_ID: ",
								Form1.gstruct49_0[num].int_32,
								Class53.string_7
							});
						}
						Clipboard.SetText(text);
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0012B634 File Offset: 0x00129834
		private void checkBoxGame_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.timer_0.Enabled;
			if (!flag)
			{
				Class66.int_0 = (int)Convert.ToByte(this.checkBoxGame.Checked);
				Class62.smethod_10(Class53.string_3, "fixgCash", Class66.int_0, "", 0);
				bool flag2 = Form1.gstruct49_0 == null;
				if (!flag2)
				{
					try
					{
						for (int i = 0; i < Form1.gstruct49_0.Length; i++)
						{
							int num = 0;
							while (Class66.int_1 > 0 && num < 6)
							{
								num++;
								Thread.Sleep(100);
							}
							Class66.int_1 = Form1.gstruct49_0[i].int_136;
							new Thread(new ThreadStart(Class66.smethod_39)).Start();
						}
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0012B724 File Offset: 0x00129924
		private void checkBoxThu_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.timer_0.Enabled && Form1.bool_9;
			if (flag)
			{
				Form1.int_127 = (int)Convert.ToByte(this.checkBoxThu.Checked);
				Class62.smethod_10(Class53.string_3, "fThunhoAuto", Form1.int_127, "", 0);
				bool flag2 = Form1.int_127 > 0;
				if (flag2)
				{
					base.WindowState = FormWindowState.Minimized;
				}
			}
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x000F47EB File Offset: 0x000F29EB
		private void method_35(string string_54)
		{
			base.Text = string_54;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0012B798 File Offset: 0x00129998
		// Note: this type is marked as 'beforefieldinit'.
		static Form1()
		{
			string[,] array = new string[1, 6];
			array[0, 0] = "2009.thiendiavolam.com";
			array[0, 1] = "MÆt n¹ di thuËt";
			array[0, 2] = "1";
			array[0, 4] = "game.exe";
			Form1.string_4 = array;
			string[,] array2 = new string[1, 6];
			array2[0, 0] = "2009.thiendiavolam.com";
			array2[0, 1] = "MÆt n¹ di thuËt";
			array2[0, 2] = "65";
			array2[0, 3] = "";
			array2[0, 4] = "game.exe";
			array2[0, 5] = "";
			Form1.string_5 = array2;
			Form1.string_6 = new string[]
			{
				"2009.thiendiavolam.com"
			};
			Form1.string_7 = "Phiên bản " + Form1.string_1 + ":||Mọi đóng góp ý kiến xin liên hệ:||- Web: http://canhtrang.com/|";
			Form1.int_2 = 0;
			Form1.int_3 = 1;
			Form1.bool_2 = false;
			Form1.bool_3 = false;
			Form1.bool_4 = false;
			Form1.int_4 = Class62.smethod_3("flagCoClickVaoNPC", 0, "1");
			Form1.int_5 = Class62.smethod_3("SaisoBaovat", 0, "0");
			Form1.int_6 = 0;
			Form1.int_7 = 0;
			Form1.int_8 = Class62.smethod_3("flagBaoroom", 0, "0");
			Form1.int_9 = Class62.smethod_3("flagKhoaChatmat", 0, "1");
			Form1.int_10 = Class62.smethod_3("KhongHienThiVideoHelp", 0, "0");
			Form1.int_11 = Class62.smethod_3("flagLienthongMapAB", 0, "1");
			Form1.int_12 = Class62.smethod_3("SoluongThuocMoilanMo", 0, "10");
			Form1.int_13 = Class62.smethod_3("PCDKhongMoTui", 0, "1");
			Form1.int_14 = Class62.smethod_3("flagBaoCuusatMat", 0, "1");
			Form1.int_15 = Class62.smethod_3("flagBaoCuusatBang", 0, "1");
			Form1.int_16 = Class62.smethod_3("flagBaoCuusatPhucan", 0, "0");
			Form1.int_17 = Class62.smethod_3("LuonGanPhimtat", 0, "0");
			Form1.int_18 = 1;
			Form1.int_19 = Class62.smethod_3("flagKhongChaybo", 0, "1");
			Form1.int_20 = Class62.smethod_3("IndexPK", 0, "0");
			Form1.int_21 = Class62.smethod_3("flagTimAccchinh", 0, "1");
			Form1.int_22 = Class62.smethod_3("flagTimtrongthanh", 0, "1");
			Form1.int_23 = Class62.smethod_3("KhoangcachAccchinh", 0, "200");
			Form1.int_24 = 0;
			Form1.int_25 = 0;
			Form1.int_26 = Class62.smethod_3("TamMonDaiMapID", 0, "221");
			Form1.int_27 = Class62.smethod_3("fQuangThuocAchinh", 0, "1");
			Form1.int_28 = Class62.smethod_3("fQuangThuocTDP", 0, "0");
			Form1.int_29 = Class62.smethod_3("fMuaNoiChiendau", 0, "0");
			Form1.int_30 = Class62.smethod_3("flagDanhnguoi", 0, "1");
			Form1.int_31 = Class62.smethod_3("flagDanhquai", 0, "1");
			Form1.int_32 = Class62.smethod_3("flagUutienBoss", 0, "0");
			Form1.int_33 = Class62.smethod_3("flagCungMuctieu", 0, "1");
			Form1.int_34 = Class62.smethod_3("flagTutimMuctieu", 0, "1");
			Form1.int_35 = 1;
			Form1.int_36 = Class62.smethod_3("BossTruocNguoiSau", 0, "0");
			Form1.int_37 = Class62.smethod_3("ChetNamImAll", 0, "0");
			Form1.int_38 = Class62.smethod_3("fNamImONOFF", 0, "0");
			Form1.int_39 = 10;
			Form1.int_40 = Class62.smethod_3("flagOLuonMapPhu", 0, "1");
			Form1.string_8 = Class12.smethod_15(Class62.smethod_6("TenAcCantimVST", 0, ""));
			Form1.int_41 = Class62.smethod_3("flagBaoKenhBangVST", 0, "0");
			Form1.int_42 = Class62.smethod_3("flagBaoKenhRoomVST", 0, "1");
			Form1.int_43 = Class62.smethod_3("ThoigianVST", 0, "30");
			Form1.int_44 = new int[]
			{
				0,
				Class62.smethod_3("BaodanhTK", 0, "0")
			};
			Form1.int_45 = Class62.smethod_3("flagVaoMapCTCCoAcchinh", 0, "1");
			Form1.gstruct49_0 = null;
			Form1.int_46 = null;
			Form1.string_9 = "nhap_id_vao_day";
			Form1.string_10 = Class62.smethod_6("textIDSudung", 0, Form1.string_9);
			Form1.string_11 = Class62.smethod_6("textFindWeb", 0, "");
			Form1.int_47 = Class62.smethod_3("flagPassKeoNhieumay", 0, "1");
			Form1.int_48 = Class62.smethod_3("PassKeoNhieumay", 0, "1234");
			Form1.int_49 = Class62.smethod_3("Mahoatoado", 0, "0");
			Form1.int_50 = Class62.smethod_3("flagDanhDenchet", 0, "0");
			Form1.int_51 = Class62.smethod_3("KCAcdanhTiepcan", 0, "350");
			Form1.string_12 = new string[]
			{
				"WAR (PK -Boss)",
				"TK (Tống Kim - PHLT)",
				"CTC (Chiến trường CTC)",
				"ĐƠN ĐẤU"
			};
			Form1.string_13 = new string[]
			{
				"Đánh Thất thành",
				"Đánh Tam trụ",
				"Đánh Tam môn đài"
			};
			string[,] array3 = new string[37, 2];
			array3[0, 0] = "Lâm An";
			array3[0, 1] = "176";
			array3[1, 0] = "Biện Kinh";
			array3[1, 1] = "37";
			array3[2, 0] = "Dương Châu";
			array3[2, 1] = "80";
			array3[3, 0] = "Phượng Tường";
			array3[3, 1] = "01";
			array3[4, 0] = "DĐại Lý";
			array3[4, 1] = "162";
			array3[5, 0] = "Thành Đô";
			array3[5, 1] = "11";
			array3[6, 0] = "Tương Dương";
			array3[6, 1] = "78";
			array3[7, 0] = "...";
			array3[7, 1] = "";
			array3[8, 0] = "Ba Lăng huyện";
			array3[8, 1] = "53";
			array3[9, 0] = "Giang Tân thôn";
			array3[9, 1] = "20";
			array3[10, 0] = "Đạo Hương thôn";
			array3[10, 1] = "101";
			array3[11, 0] = "Chu Tiên trấn";
			array3[11, 1] = "100";
			array3[12, 0] = "Long Tuyền thôn";
			array3[12, 1] = "174";
			array3[13, 0] = "Thạch Cổ trấn";
			array3[13, 1] = "153";
			array3[14, 0] = "Vĩnh Lạc trấn";
			array3[14, 1] = "99";
			array3[15, 0] = "Long Môn trấn";
			array3[15, 1] = "121";
			array3[16, 0] = "...";
			array3[16, 1] = "";
			array3[17, 0] = "Bắc Trường Bạch";
			array3[17, 1] = "322";
			array3[18, 0] = "Nam Trường Bạch";
			array3[18, 1] = "321";
			array3[19, 0] = "Khỏa Lang động";
			array3[19, 1] = "75";
			array3[20, 0] = "Phong Lăng độ";
			array3[20, 1] = "336";
			array3[21, 0] = "Mạc Cao Quật";
			array3[21, 1] = "340";
			array3[22, 0] = "1 Sa mạc";
			array3[22, 1] = "225";
			array3[23, 0] = "2 Sa mạc";
			array3[23, 1] = "226";
			array3[24, 0] = "3 Sa mạc";
			array3[24, 1] = "227";
			array3[25, 0] = "Sa mạc địa biểu";
			array3[25, 1] = "224";
			array3[26, 0] = "...";
			array3[26, 1] = "";
			array3[27, 0] = "Vận tiêu 1";
			array3[27, 1] = "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 1";
			array3[28, 0] = "Vận tiêu 2";
			array3[28, 1] = "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 2";
			array3[29, 0] = "Vận tiêu 3";
			array3[29, 1] = "b¶n ®å kh|iÓm VËn Tiªu|Ën tiªu cæng 3";
			array3[30, 0] = "...";
			array3[30, 1] = "";
			array3[31, 0] = "Đông Sinh Tử đấu trường";
			array3[31, 1] = "dông thuËt|Sinh T|§«ng|®«ng";
			array3[32, 0] = "Tây Sinh Tử đấu trường";
			array3[32, 1] = "dông thuËt|Sinh T|T©y";
			array3[33, 0] = "Nam Sinh Tử đấu trường";
			array3[33, 1] = "dông thuËt|Sinh T|Nam";
			array3[34, 0] = "Bắc Sinh Tử đấu trường";
			array3[34, 1] = "dông thuËt|Sinh T|B¾c";
			array3[35, 0] = "...";
			array3[35, 1] = "";
			array3[36, 0] = "Hướng dẫn";
			array3[36, 1] = "";
			Form1.string_14 = array3;
			string[,] array4 = new string[5, 2];
			array4[0, 0] = "Đông";
			array4[0, 1] = "®«ng|§«ng";
			array4[1, 0] = "Tây";
			array4[1, 1] = "t©y";
			array4[2, 0] = "Nam";
			array4[2, 1] = "nam";
			array4[3, 0] = "Bắc";
			array4[3, 1] = "b¾c";
			array4[4, 0] = "T.Tâm";
			array4[4, 1] = "t©m";
			Form1.string_15 = array4;
			Form1.string_16 = new string[]
			{
				"T¾t",
				"BËt"
			};
			Form1.int_52 = 0;
			Form1.string_17 = Class12.smethod_15(Class62.smethod_6("AccChinhNameA", 0, ""));
			Form1.string_18 = null;
			Form1.int_53 = new int[]
			{
				Class62.smethod_3("flagMuaTDP_0", 0, "1"),
				Class62.smethod_3("flagMuaTDP_1", 0, "4")
			};
			Form1.int_54 = Class62.smethod_3("ValueThuocDimua", 0, "10");
			Form1.int_55 = Class62.smethod_3("flagSuadoTaichoEx", 0, "1");
			Form1.int_56 = Class62.smethod_3("flagKhongSuaTK", 0, "1");
			Form1.int_57 = Class62.smethod_3("flagLuonSuaMua", 0, "1");
			Form1.int_58 = Class62.smethod_3("flagSudoBachKim", 0, "1");
			Form1.int_59 = Class62.smethod_3("fSuaPhichiendau", 0, "0");
			Form1.int_60 = new int[]
			{
				Class62.smethod_3("fSuado1_0", 0, "95"),
				Class62.smethod_3("fSuado1_1", 0, "10")
			};
			Form1.int_61 = new int[]
			{
				Class62.smethod_3("RuttienMax_00", 0, "0"),
				Class62.smethod_3("RuttienMax_01", 0, "500")
			};
			Form1.int_62 = Class62.smethod_3("flagPhimTatSuado", 0, "0");
			Form1.int_63 = 1;
			Form1.int_64 = Class62.smethod_3("flagGiamRamtudong", 0, "0");
			Form1.int_65 = 0;
			Form1.int_66 = Class62.smethod_3("flagChatNhamEx", 0, "0");
			Form1.string_19 = Class62.smethod_6("textChatNhams", 0, "(dz)AutoKeoXe");
			Form1.int_67 = Class62.smethod_3("flagLoaiboGameHu", 0, "0");
			Form1.int_68 = Class62.smethod_3("BaoKeylog", 0, "0");
			Form1.int_69 = Class62.smethod_3("fNguoiChoiTuGiam", 0, "1");
			Form1.int_70 = Class62.smethod_3("vGiamDelay", 0, "400");
			Form1.string_20 = Class62.smethod_6("NameMuaGop", 0, "");
			Form1.int_71 = Class62.smethod_3("flagMuaKTC", 0, "0");
			Form1.int_72 = Class62.smethod_3("flagMuaGop", 0, "1");
			Form1.bool_5 = false;
			Form1.int_73 = new int[]
			{
				Class62.smethod_3("MDSL0", 0, "0"),
				Class62.smethod_3("MDSL1", 0, "1")
			};
			Form1.int_74 = Class62.smethod_3("fThanhTruotSudung", 0, "0");
			Form1.int_75 = Class62.smethod_3("fDenToado", 0, "0");
			Form1.int_76 = Class62.smethod_3("fDenToadoLeave", 0, "1");
			Form1.bool_6 = false;
			Form1.string_21 = null;
			Form1.string_22 = null;
			Form1.int_77 = -1;
			Form1.string_23 = new string[]
			{
				"Tiền và HK-BK",
				"<= 1 ô",
				"<= 1 ô màu",
				"<= 2 ô",
				"<= 2 ô màu",
				"<= 3 ô",
				"<= 3 ô màu",
				"<= 4 ô",
				"<= 4 ô màu",
				"Đồ màu",
				"Tất cả"
			};
			Form1.string_24 = new string[]
			{
				"1 ô",
				"2 ô",
				"3 ô",
				"4 ô",
				"6 ô"
			};
			Form1.string_25 = new string[]
			{
				"Khoảng cách",
				"Ngũ hành"
			};
			Form1.string_26 = new string[]
			{
				"Trên ngựa",
				"Xuống ngựa",
				"Tự động",
				"Người dùng điều khiển"
			};
			Form1.int_78 = 150;
			Form1.string_28 = new string[]
			{
				"Thiên Bảo khố",
				"Phong Kỳ"
			};
			Form1.string_29 = new string[]
			{
				"Bán",
				"Sử dụng (ăn)"
			};
			Form1.int_79 = Class62.smethod_3("nDobenOut", 0, "1");
			Form1.int_80 = Class62.smethod_3("nDobenThap", 0, "5");
			Form1.int_81 = Class62.smethod_3("flagThodiaphuDobenThap", 0, "1");
			Form1.int_82 = Class62.smethod_3("ThoigianSua", 0, "60");
			Form1.int_83 = Class62.smethod_3("flagDoiPKTheoAccChinh", 0, "1");
			Form1.int_84 = Class62.smethod_3("flagTrolaiDiemcu", 0, "0");
			Form1.int_85 = Class62.smethod_3("fMatmaXaphu", 0, "0");
			Form1.int_86 = Class62.smethod_3("flagKhongDanhCapnho", 0, "1");
			Form1.int_87 = Class62.smethod_3("ValueCapBoqua", 0, "10");
			Form1.int_88 = Class62.smethod_3("flagAccChinhRoiHauDoanh", 0, "0");
			Form1.int_89 = Class62.smethod_3("flagAccPhuChoAccChinh", 0, "1");
			Form1.int_90 = Class62.smethod_3("flagRabangTrinhsat", 0, "0");
			Form1.int_91 = 0;
			Form1.int_92 = Class62.smethod_3("TongKimXemSoluong", 0, "1");
			Form1.int_93 = new int[]
			{
				Class62.smethod_3("TruotTK0", 0, "0"),
				Class62.smethod_3("TruotTK1", 0, "100")
			};
			Form1.int_94 = Class62.smethod_3("fHieuUyTK", 0, "1");
			Form1.int_95 = Class62.smethod_3("fChuyenThuocChinhxacTen", 0, "1");
			Form1.int_96 = Class62.smethod_3("fChuyenThuocTruocMua", 0, "0");
			Form1.string_30 = Class62.smethod_6("TenMauFree", 0, "[Hay chon ten thuoc mien phi]");
			Form1.int_97 = Class62.smethod_3("flagMuaMpKhongNhapSo", 0, "0");
			Form1.int_98 = Class62.smethod_3("flagMuaThonTran", 0, "0");
			Form1.int_99 = Class62.smethod_3("flagTNBamPhim", 0, "0");
			Form1.int_100 = Class62.smethod_3("TNIdexPhim", 0, "0");
			Form1.int_101 = Class62.smethod_3("KhoangCachLenNguaEx", 0, "500");
			Form1.int_102 = Class62.smethod_3("flagXuongNguaSansang", 0, "1");
			Form1.int_103 = Class62.smethod_3("KhongdanhCungBang", 0, "0");
			Form1.int_104 = Class62.smethod_3("flagIndexBentau", 0, "1");
			Form1.string_31 = new string[]
			{
				"1. Đi Bến 1 - Phong lăng độ",
				"2. Đi Bến 2 - Phong lăng độ",
				"3. Đi Bến 3 - Phong lăng độ",
				"4. Đi Vi Sơn đảo",
				"5. Đi Vi Sơn đảo - Tự mua LB ở KTC",
				"6. Click vào NPC gần nhất",
				"7. Lấy Menu Text trong game",
				"8. Lấy tất cả tên Item",
				"9. Lấy thông tin xung quanh"
			};
			Form1.int_105 = Class62.smethod_3("flagTHPCTC", 0, "0");
			Form1.int_106 = Class62.smethod_3("IdexChientruongChinh", 0, "0");
			Form1.int_107 = Class62.smethod_3("flagSudungMapphuEx", 0, "0");
			Form1.int_108 = Class62.smethod_3("IdexChientruongPhu", 0, "1");
			Form1.int_109 = 3;
			Form1.int_110 = Class62.smethod_3("flagThpCLD", 0, "0");
			Form1.int_111 = Class62.smethod_3("flagKieuDiCLD", 0, "0");
			Form1.int_112 = 10;
			Form1.int_113 = Class62.smethod_3("CTCAchinhTudieuKhien", 0, "0");
			Form1.int_114 = 0;
			Form1.int_115 = 0;
			Form1.int_116 = Class62.smethod_3("flagPhandame", 0, "0");
			Form1.int_117 = Class62.smethod_3("flagDanhKhongten", 0, "0");
			Form1.int_118 = Class62.smethod_3("PhamviKhinhcong", 0, "300");
			Form1.int_119 = Class62.smethod_3("fThongbaoTHP", 0, "0");
			Form1.int_120 = Class62.smethod_3("fTatBaoDame", 0, "0");
			Form1.int_121 = Class62.smethod_3("fBatMouseDrag", 0, "0");
			Form1.string_32 = new string[]
			{
				"Thần Hành Phù lên",
				"Đi xa phu lên CLĐ"
			};
			Form1.string_33 = new string[]
			{
				"Tránh xa",
				"Thổ địa phù",
				"Đánh trả",
				"Thoát game"
			};
			Form1.string_34 = new string[]
			{
				"Giảm CPU mức 0 (khôi phục ban đầu)",
				"Giảm CPU mức 1 (khoảng 1/3 lần)",
				"Giảm CPU mức 2 (khoảng 1/2 lần)"
			};
			Form1.string_36 = Environment.GetEnvironmentVariable("windir");
			string[,] array5 = new string[4, 2];
			array5[0, 0] = "dllhostex";
			array5[1, 0] = "ClearRam";
			array5[2, 0] = "TasksHostServices";
			array5[2, 1] = Form1.string_36 + "\\System32";
			array5[3, 0] = "spoolsv";
			array5[3, 1] = Form1.string_36 + "\\SpeechsTracing";
			Form1.string_37 = array5;
			Form1.bool_8 = false;
			Form1.int_122 = null;
			Form1.int_123 = null;
			Form1.bool_9 = false;
			Form1.int_124 = -1;
			Form1.mutex_0 = null;
			Form1.bool_10 = false;
			Form1.bool_11 = false;
			Form1.string_38 = "tbDongMenuMuamau";
			Form1.int_125 = Class12.smethod_69(Class62.smethod_6(Form1.string_38, 0, "2,1"), null);
			Form1.string_39 = "ClickMenuTrinhsat";
			Form1.int_126 = Class12.smethod_69(Class62.smethod_6(Form1.string_39, 0, "1,1"), null);
			Form1.int_127 = Class62.smethod_3("fThunhoAuto", 0, "0");
			Form1.int_128 = 0;
			Form1.bool_12 = false;
			Form1.int_130 = -1;
			Form1.int_131 = 0;
			Form1.long_0 = 0L;
			Form1.long_1 = 0L;
			Form1.int_134 = 0;
			Form1.int_135 = 0;
			Form1.int_136 = 0;
			Form1.long_3 = 0L;
			Form1.long_4 = 15000L;
			Form1.int_137 = -1;
			Form1.int_138 = -1;
			Form1.int_139 = -1;
			Form1.int_140 = -1;
			Form1.bool_15 = false;
			Form1.bool_16 = false;
			Form1.int_141 = 0;
			Form1.uint_0 = 0U;
			Form1.uint_1 = 0U;
			Form1.uint_2 = 0U;
			Form1.bool_18 = false;
			Form1.int_142 = 0;
			Form1.string_43 = null;
			Form1.string_44 = null;
			Form1.string_45 = string.Empty;
			Form1.int_143 = -1;
			Form1.int_144 = 0;
			Form1.int_145 = -1;
			Form1.string_46 = null;
			Form1.string_47 = null;
			Form1.string_48 = null;
			Form1.int_146 = 0;
			Form1.int_147 = 0;
			Form1.string_49 = null;
			Form1.string_50 = null;
			Form1.string_51 = null;
			Form1.gstruct57_0 = null;
			Form1.string_52 = null;
		}

		// Token: 0x0400044F RID: 1103
		private IContainer icontainer_0 = null;

		// Token: 0x04000695 RID: 1685
		public static string string_0 = "1.07";

		// Token: 0x04000696 RID: 1686
		public static string string_1 = "\u0081AutoKeoxe " + Form1.string_0;

		// Token: 0x04000697 RID: 1687
		public static string string_2 = "AutoKeoxe.exe";

		// Token: 0x04000698 RID: 1688
		public static string string_200 = "AutoKeoxe.exe";

		// Token: 0x04000699 RID: 1689
		public static bool UseServerDomain = false;

		// Token: 0x0400069A RID: 1690
		public static bool CheckTenWeb = false;

		// Token: 0x0400069B RID: 1691
		public static bool bool_0 = false;

		// Token: 0x0400069C RID: 1692
		public static bool bool_1 = false;

		// Token: 0x0400069D RID: 1693
		public static string string_3 = string.Empty;

		// Token: 0x0400069E RID: 1694
		public static int int_0 = -1;

		// Token: 0x0400069F RID: 1695
		public static int int_1 = 0;

		// Token: 0x040006A0 RID: 1696
		public static List<string[]> listwebdomain = new List<string[]>();

		// Token: 0x040006A1 RID: 1697
		public static string[,] string_4;

		// Token: 0x040006A2 RID: 1698
		private static string[,] string_5;

		// Token: 0x040006A3 RID: 1699
		public static string[] string_6;

		// Token: 0x040006A4 RID: 1700
		public static string string_7;

		// Token: 0x040006A5 RID: 1701
		public static int int_2;

		// Token: 0x040006A6 RID: 1702
		public static int int_3;

		// Token: 0x040006A7 RID: 1703
		public static bool bool_2;

		// Token: 0x040006A8 RID: 1704
		public static bool bool_3;

		// Token: 0x040006A9 RID: 1705
		public static bool bool_4;

		// Token: 0x040006AA RID: 1706
		public static int int_4;

		// Token: 0x040006AB RID: 1707
		public static int int_5;

		// Token: 0x040006AC RID: 1708
		public static int int_6;

		// Token: 0x040006AD RID: 1709
		public static int int_7;

		// Token: 0x040006AE RID: 1710
		public static int int_8;

		// Token: 0x040006AF RID: 1711
		public static int int_9;

		// Token: 0x040006B0 RID: 1712
		public static int int_10;

		// Token: 0x040006B1 RID: 1713
		public static int int_11;

		// Token: 0x040006B2 RID: 1714
		public static int int_12;

		// Token: 0x040006B3 RID: 1715
		public static int int_13;

		// Token: 0x040006B4 RID: 1716
		public static int int_14;

		// Token: 0x040006B5 RID: 1717
		public static int int_15;

		// Token: 0x040006B6 RID: 1718
		public static int int_16;

		// Token: 0x040006B7 RID: 1719
		public static int int_17;

		// Token: 0x040006B8 RID: 1720
		public static int int_18;

		// Token: 0x040006B9 RID: 1721
		public static int int_19;

		// Token: 0x040006BA RID: 1722
		public static int int_20;

		// Token: 0x040006BB RID: 1723
		public static int int_21;

		// Token: 0x040006BC RID: 1724
		public static int int_22;

		// Token: 0x040006BD RID: 1725
		public static int int_23;

		// Token: 0x040006BE RID: 1726
		public static int int_24;

		// Token: 0x040006BF RID: 1727
		public static int int_25;

		// Token: 0x040006C0 RID: 1728
		public static int int_26;

		// Token: 0x040006C1 RID: 1729
		public static int int_27;

		// Token: 0x040006C2 RID: 1730
		public static int int_28;

		// Token: 0x040006C3 RID: 1731
		public static int int_29;

		// Token: 0x040006C4 RID: 1732
		public static int int_30;

		// Token: 0x040006C5 RID: 1733
		public static int int_31;

		// Token: 0x040006C6 RID: 1734
		public static int int_32;

		// Token: 0x040006C7 RID: 1735
		public static int int_33;

		// Token: 0x040006C8 RID: 1736
		public static int int_34;

		// Token: 0x040006C9 RID: 1737
		public static int int_35;

		// Token: 0x040006CA RID: 1738
		public static int int_36;

		// Token: 0x040006CB RID: 1739
		public static int int_37;

		// Token: 0x040006CC RID: 1740
		public static int int_38;

		// Token: 0x040006CD RID: 1741
		public static int int_39;

		// Token: 0x040006CE RID: 1742
		public static int int_40;

		// Token: 0x040006CF RID: 1743
		public static string string_8;

		// Token: 0x040006D0 RID: 1744
		public static int int_41;

		// Token: 0x040006D1 RID: 1745
		public static int int_42;

		// Token: 0x040006D2 RID: 1746
		public static int int_43;

		// Token: 0x040006D3 RID: 1747
		public static int[] int_44;

		// Token: 0x040006D4 RID: 1748
		public static int int_45;

		// Token: 0x040006D5 RID: 1749
		public static GStruct49[] gstruct49_0;

		// Token: 0x040006D6 RID: 1750
		public static int[] int_46;

		// Token: 0x040006D7 RID: 1751
		public static string string_9;

		// Token: 0x040006D8 RID: 1752
		public static string string_10;

		// Token: 0x040006D9 RID: 1753
		public static string string_11;

		// Token: 0x040006DA RID: 1754
		public static int int_47;

		// Token: 0x040006DB RID: 1755
		public static int int_48;

		// Token: 0x040006DC RID: 1756
		public static int int_49;

		// Token: 0x040006DD RID: 1757
		public static int int_50;

		// Token: 0x040006DE RID: 1758
		public static int int_51;

		// Token: 0x040006DF RID: 1759
		public static string[] string_12;

		// Token: 0x040006E0 RID: 1760
		public static string[] string_13;

		// Token: 0x040006E1 RID: 1761
		public static string[,] string_14;

		// Token: 0x040006E2 RID: 1762
		public static string[,] string_15;

		// Token: 0x040006E3 RID: 1763
		private static string[] string_16;

		// Token: 0x040006E4 RID: 1764
		public static int int_52;

		// Token: 0x040006E5 RID: 1765
		public static string string_17;

		// Token: 0x040006E6 RID: 1766
		private static string[] string_18;

		// Token: 0x040006E7 RID: 1767
		public static int[] int_53;

		// Token: 0x040006E8 RID: 1768
		public static int int_54;

		// Token: 0x040006E9 RID: 1769
		public static int int_55;

		// Token: 0x040006EA RID: 1770
		public static int int_56;

		// Token: 0x040006EB RID: 1771
		public static int int_57;

		// Token: 0x040006EC RID: 1772
		public static int int_58;

		// Token: 0x040006ED RID: 1773
		public static int int_59;

		// Token: 0x040006EE RID: 1774
		public static int[] int_60;

		// Token: 0x040006EF RID: 1775
		public static int[] int_61;

		// Token: 0x040006F0 RID: 1776
		public static int int_62;

		// Token: 0x040006F1 RID: 1777
		public static int int_63;

		// Token: 0x040006F2 RID: 1778
		public static int int_64;

		// Token: 0x040006F3 RID: 1779
		public static int int_65;

		// Token: 0x040006F4 RID: 1780
		public static int int_66;

		// Token: 0x040006F5 RID: 1781
		public static string string_19;

		// Token: 0x040006F6 RID: 1782
		public static int int_67;

		// Token: 0x040006F7 RID: 1783
		public static int int_68;

		// Token: 0x040006F8 RID: 1784
		public static int int_69;

		// Token: 0x040006F9 RID: 1785
		public static int int_70;

		// Token: 0x040006FA RID: 1786
		public static string string_20;

		// Token: 0x040006FB RID: 1787
		public static int int_71;

		// Token: 0x040006FC RID: 1788
		public static int int_72;

		// Token: 0x040006FD RID: 1789
		public static bool bool_5;

		// Token: 0x040006FE RID: 1790
		public static int[] int_73;

		// Token: 0x040006FF RID: 1791
		public static int int_74;

		// Token: 0x04000700 RID: 1792
		public static int int_75;

		// Token: 0x04000701 RID: 1793
		public static int int_76;

		// Token: 0x04000702 RID: 1794
		public static bool bool_6;

		// Token: 0x04000703 RID: 1795
		public static string[] string_21;

		// Token: 0x04000704 RID: 1796
		private static string[] string_22;

		// Token: 0x04000705 RID: 1797
		public static int int_77;

		// Token: 0x04000706 RID: 1798
		private bool bool_7 = false;

		// Token: 0x04000707 RID: 1799
		public static string[] string_23;

		// Token: 0x04000708 RID: 1800
		public static string[] string_24;

		// Token: 0x04000709 RID: 1801
		public static string[] string_25;

		// Token: 0x0400070A RID: 1802
		public static string[] string_26;

		// Token: 0x0400070B RID: 1803
		public static int int_78;

		// Token: 0x0400070C RID: 1804
		private string[] string_27 = new string[]
		{
			"Bên Tống",
			"Bên Kim"
		};

		// Token: 0x0400070D RID: 1805
		private static string[] string_28;

		// Token: 0x0400070E RID: 1806
		public static string[] string_29;

		// Token: 0x0400070F RID: 1807
		public static int int_79;

		// Token: 0x04000710 RID: 1808
		public static int int_80;

		// Token: 0x04000711 RID: 1809
		public static int int_81;

		// Token: 0x04000712 RID: 1810
		public static int int_82;

		// Token: 0x04000713 RID: 1811
		public static int int_83;

		// Token: 0x04000714 RID: 1812
		public static int int_84;

		// Token: 0x04000715 RID: 1813
		public static int int_85;

		// Token: 0x04000716 RID: 1814
		public static int int_86;

		// Token: 0x04000717 RID: 1815
		public static int int_87;

		// Token: 0x04000718 RID: 1816
		public static int int_88;

		// Token: 0x04000719 RID: 1817
		public static int int_89;

		// Token: 0x0400071A RID: 1818
		public static int int_90;

		// Token: 0x0400071B RID: 1819
		public static int int_91;

		// Token: 0x0400071C RID: 1820
		public static int int_92;

		// Token: 0x0400071D RID: 1821
		public static int[] int_93;

		// Token: 0x0400071E RID: 1822
		public static int int_94;

		// Token: 0x0400071F RID: 1823
		public static int int_95;

		// Token: 0x04000720 RID: 1824
		public static int int_96;

		// Token: 0x04000721 RID: 1825
		public static string string_30;

		// Token: 0x04000722 RID: 1826
		public static int int_97;

		// Token: 0x04000723 RID: 1827
		public static int int_98;

		// Token: 0x04000724 RID: 1828
		public static int int_99;

		// Token: 0x04000725 RID: 1829
		public static int int_100;

		// Token: 0x04000726 RID: 1830
		public static int int_101;

		// Token: 0x04000727 RID: 1831
		public static int int_102;

		// Token: 0x04000728 RID: 1832
		public static int int_103;

		// Token: 0x04000729 RID: 1833
		public static int int_104;

		// Token: 0x0400072A RID: 1834
		public static string[] string_31;

		// Token: 0x0400072B RID: 1835
		public static int int_105;

		// Token: 0x0400072C RID: 1836
		public static int int_106;

		// Token: 0x0400072D RID: 1837
		public static int int_107;

		// Token: 0x0400072E RID: 1838
		public static int int_108;

		// Token: 0x0400072F RID: 1839
		public static int int_109;

		// Token: 0x04000730 RID: 1840
		public static int int_110;

		// Token: 0x04000731 RID: 1841
		public static int int_111;

		// Token: 0x04000732 RID: 1842
		public static int int_112;

		// Token: 0x04000733 RID: 1843
		public static int int_113;

		// Token: 0x04000734 RID: 1844
		public static int int_114;

		// Token: 0x04000735 RID: 1845
		public static int int_115;

		// Token: 0x04000736 RID: 1846
		public static int int_116;

		// Token: 0x04000737 RID: 1847
		public static int int_117;

		// Token: 0x04000738 RID: 1848
		public static int int_118;

		// Token: 0x04000739 RID: 1849
		public static int int_119;

		// Token: 0x0400073A RID: 1850
		public static int int_120;

		// Token: 0x0400073B RID: 1851
		public static int int_121;

		// Token: 0x0400073C RID: 1852
		private static string[] string_32;

		// Token: 0x0400073D RID: 1853
		private static string[] string_33;

		// Token: 0x0400073E RID: 1854
		public static string[] string_34;

		// Token: 0x0400073F RID: 1855
		private string[] string_35 = new string[]
		{
			"Time",
			"NL<=",
			"NL >",
			"SL<=",
			"SL >",
			"% NL+SL>",
			"Công kích <=",
			"Công kích >"
		};

		// Token: 0x04000740 RID: 1856
		public static string string_36;

		// Token: 0x04000741 RID: 1857
		public static string[,] string_37;

		// Token: 0x04000742 RID: 1858
		public static bool bool_8;

		// Token: 0x04000743 RID: 1859
		public static int[] int_122;

		// Token: 0x04000744 RID: 1860
		public static Point point_0;

		// Token: 0x04000745 RID: 1861
		private static int[] int_123;

		// Token: 0x04000746 RID: 1862
		private static bool bool_9;

		// Token: 0x04000747 RID: 1863
		private static int int_124;

		// Token: 0x04000748 RID: 1864
		public static Mutex mutex_0;

		// Token: 0x04000749 RID: 1865
		public static bool bool_10;

		// Token: 0x0400074A RID: 1866
		public static bool bool_11;

		// Token: 0x0400074B RID: 1867
		private static string string_38;

		// Token: 0x0400074C RID: 1868
		public static int[] int_125;

		// Token: 0x0400074D RID: 1869
		private static string string_39;

		// Token: 0x0400074E RID: 1870
		public static int[] int_126;

		// Token: 0x0400074F RID: 1871
		private string string_40 = null;

		// Token: 0x04000750 RID: 1872
		private string string_41 = null;

		// Token: 0x04000751 RID: 1873
		private string string_42 = null;

		// Token: 0x04000752 RID: 1874
		private static int int_127;

		// Token: 0x04000753 RID: 1875
		private static int int_128;

		// Token: 0x04000754 RID: 1876
		private int int_129 = -1;

		// Token: 0x04000755 RID: 1877
		public static bool bool_12;

		// Token: 0x04000756 RID: 1878
		public static int int_130;

		// Token: 0x04000757 RID: 1879
		private bool bool_13 = false;

		// Token: 0x04000758 RID: 1880
		private bool bool_14 = false;

		// Token: 0x04000759 RID: 1881
		private static int int_131;

		// Token: 0x0400075A RID: 1882
		private static long long_0;

		// Token: 0x0400075B RID: 1883
		private static long long_1;

		// Token: 0x0400075C RID: 1884
		private int int_132 = -1;

		// Token: 0x0400075D RID: 1885
		private int int_133 = -1;

		// Token: 0x0400075E RID: 1886
		private long long_2 = 0L;

		// Token: 0x0400075F RID: 1887
		private static int int_134;

		// Token: 0x04000760 RID: 1888
		private static int int_135;

		// Token: 0x04000761 RID: 1889
		private static int int_136;

		// Token: 0x04000762 RID: 1890
		private static long long_3;

		// Token: 0x04000763 RID: 1891
		private static long long_4;

		// Token: 0x04000764 RID: 1892
		private static int int_137;

		// Token: 0x04000765 RID: 1893
		private static int int_138;

		// Token: 0x04000766 RID: 1894
		private static int int_139;

		// Token: 0x04000767 RID: 1895
		private static int int_140;

		// Token: 0x04000768 RID: 1896
		private static bool bool_15;

		// Token: 0x04000769 RID: 1897
		private static bool bool_16;

		// Token: 0x0400076A RID: 1898
		private static int int_141;

		// Token: 0x0400076B RID: 1899
		private bool bool_17 = false;

		// Token: 0x0400076C RID: 1900
		private static uint uint_0;

		// Token: 0x0400076D RID: 1901
		private static uint uint_1;

		// Token: 0x0400076E RID: 1902
		private static uint uint_2;

		// Token: 0x0400076F RID: 1903
		private static bool bool_18;

		// Token: 0x04000770 RID: 1904
		public static int int_142;

		// Token: 0x04000771 RID: 1905
		private static string[] string_43;

		// Token: 0x04000772 RID: 1906
		private static string[] string_44;

		// Token: 0x04000773 RID: 1907
		public static string string_45;

		// Token: 0x04000774 RID: 1908
		private static int int_143;

		// Token: 0x04000775 RID: 1909
		private static int int_144;

		// Token: 0x04000776 RID: 1910
		private static int int_145;

		// Token: 0x04000777 RID: 1911
		private static string[] string_46;

		// Token: 0x04000778 RID: 1912
		private static string[] string_47;

		// Token: 0x04000779 RID: 1913
		private static string[] string_48;

		// Token: 0x0400077A RID: 1914
		private static int int_146;

		// Token: 0x0400077B RID: 1915
		private static int int_147;

		// Token: 0x0400077C RID: 1916
		private static string string_49;

		// Token: 0x0400077D RID: 1917
		private static string string_50;

		// Token: 0x0400077E RID: 1918
		private static string[] string_51;

		// Token: 0x0400077F RID: 1919
		private static GStruct57[] gstruct57_0;

		// Token: 0x04000780 RID: 1920
		private static string[] string_52;

		// Token: 0x04000781 RID: 1921
		private bool bool_19 = false;

		// Token: 0x04000782 RID: 1922
		private int int_148 = 0;

		// Token: 0x04000784 RID: 1924
		private string string_53 = null;

		// Token: 0x04000785 RID: 1925
		public string linkweb = null;

		// Token: 0x04000786 RID: 1926
		public string linkpage = null;
	}
}
