namespace AutoKeoxe
{
	// Token: 0x02000067 RID: 103
	public partial class FormChayBoss : global::System.Windows.Forms.Form
	{
		// Token: 0x060007F1 RID: 2033 RVA: 0x0013266C File Offset: 0x0013086C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormChayBoss));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.checkBoxTuLuuRuong = new global::System.Windows.Forms.CheckBox();
			this.comboBoxTenTat = new global::System.Windows.Forms.ComboBox();
			this.textBoxToado = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonSua = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonLen = new global::System.Windows.Forms.Button();
			this.buttonXuong = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonMacdinh = new global::System.Windows.Forms.Button();
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBoxTrolaiDiemcu = new global::System.Windows.Forms.CheckBox();
			this.buttonLuu = new global::System.Windows.Forms.Button();
			this.buttonXem = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.buttonThumucAuto = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(2, 5);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(520, 424);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "Tên tắt";
			this.columnHeader_0.Width = 110;
			this.columnHeader_1.Text = "Tọa độ";
			this.columnHeader_1.Width = 80;
			this.columnHeader_2.Text = "Tên đầy đủ";
			this.columnHeader_2.Width = 130;
			this.checkBoxTuLuuRuong.AutoSize = true;
			this.checkBoxTuLuuRuong.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTuLuuRuong.Location = new global::System.Drawing.Point(4, 786);
			this.checkBoxTuLuuRuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTuLuuRuong.Name = "checkBoxTuLuuRuong";
			this.checkBoxTuLuuRuong.Size = new global::System.Drawing.Size(326, 24);
			this.checkBoxTuLuuRuong.TabIndex = 162;
			this.checkBoxTuLuuRuong.Text = "Lưu rương trước khi chạy đến tọa độ boss";
			this.checkBoxTuLuuRuong.UseVisualStyleBackColor = true;
			this.checkBoxTuLuuRuong.CheckedChanged += new global::System.EventHandler(this.checkBoxTuLuuRuong_CheckedChanged);
			this.comboBoxTenTat.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTenTat.FormattingEnabled = true;
			this.comboBoxTenTat.Location = new global::System.Drawing.Point(86, 86);
			this.comboBoxTenTat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenTat.Name = "comboBoxTenTat";
			this.comboBoxTenTat.Size = new global::System.Drawing.Size(116, 28);
			this.comboBoxTenTat.TabIndex = 163;
			this.textBoxToado.Location = new global::System.Drawing.Point(86, 126);
			this.textBoxToado.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxToado.Name = "textBoxToado";
			this.textBoxToado.Size = new global::System.Drawing.Size(116, 26);
			this.textBoxToado.TabIndex = 164;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(18, 126);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(58, 20);
			this.label1.TabIndex = 165;
			this.label1.Text = "Tọa độ";
			this.buttonThem.Location = new global::System.Drawing.Point(213, 123);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(108, 35);
			this.buttonThem.TabIndex = 166;
			this.buttonThem.Text = "Thêm mới";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(332, 83);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(68, 35);
			this.buttonXoa.TabIndex = 167;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonSua.Location = new global::System.Drawing.Point(213, 83);
			this.buttonSua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new global::System.Drawing.Size(108, 35);
			this.buttonSua.TabIndex = 168;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new global::System.EventHandler(this.buttonSua_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(18, 94);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(36, 20);
			this.label2.TabIndex = 169;
			this.label2.Text = "Tên";
			this.buttonLen.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.buttonLen.Location = new global::System.Drawing.Point(410, 83);
			this.buttonLen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLen.Name = "buttonLen";
			this.buttonLen.Size = new global::System.Drawing.Size(90, 35);
			this.buttonLen.TabIndex = 170;
			this.buttonLen.Text = "Lên";
			this.buttonLen.UseVisualStyleBackColor = true;
			this.buttonLen.Click += new global::System.EventHandler(this.buttonLen_Click);
			this.buttonXuong.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.buttonXuong.Location = new global::System.Drawing.Point(410, 123);
			this.buttonXuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXuong.Name = "buttonXuong";
			this.buttonXuong.Size = new global::System.Drawing.Size(90, 35);
			this.buttonXuong.TabIndex = 171;
			this.buttonXuong.Text = "Xuống";
			this.buttonXuong.UseVisualStyleBackColor = true;
			this.buttonXuong.Click += new global::System.EventHandler(this.buttonXuong_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonMacdinh.ForeColor = global::System.Drawing.Color.Black;
			this.buttonMacdinh.Location = new global::System.Drawing.Point(260, 848);
			this.buttonMacdinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonMacdinh.Name = "buttonMacdinh";
			this.buttonMacdinh.Size = new global::System.Drawing.Size(135, 58);
			this.buttonMacdinh.TabIndex = 172;
			this.buttonMacdinh.Text = "Xóa tọa độ về mặc định";
			this.buttonMacdinh.UseVisualStyleBackColor = true;
			this.buttonMacdinh.Click += new global::System.EventHandler(this.buttonMacdinh_Click);
			this.buttonApdungAll.ForeColor = global::System.Drawing.Color.Black;
			this.buttonApdungAll.Location = new global::System.Drawing.Point(402, 848);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(135, 58);
			this.buttonApdungAll.TabIndex = 173;
			this.buttonApdungAll.Text = "Lưu thay đổi và đóng";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.buttonXuong);
			this.groupBox1.Controls.Add(this.buttonLen);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.buttonSua);
			this.groupBox1.Controls.Add(this.buttonXoa);
			this.groupBox1.Controls.Add(this.buttonThem);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxToado);
			this.groupBox1.Controls.Add(this.comboBoxTenTat);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 443);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(520, 178);
			this.groupBox1.TabIndex = 175;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thêm bớt - Chỉnh sửa tọa độ";
			this.label3.Location = new global::System.Drawing.Point(18, 31);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(477, 43);
			this.label3.TabIndex = 172;
			this.label3.Text = "Cột tọa độ ghi 0.0 là chưa có tọa độ boss, người dùng phải tự sửa hoặc thêm vào (hoặc để 0.0 nếu muốn ac chạy lên đầu cổng)";
			this.label4.Location = new global::System.Drawing.Point(3, 6);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(534, 91);
			this.label4.TabIndex = 173;
			this.label4.Text = componentResourceManager.GetString("label4.Text");
			this.checkBoxTrolaiDiemcu.AutoSize = true;
			this.checkBoxTrolaiDiemcu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTrolaiDiemcu.Location = new global::System.Drawing.Point(393, 786);
			this.checkBoxTrolaiDiemcu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTrolaiDiemcu.Name = "checkBoxTrolaiDiemcu";
			this.checkBoxTrolaiDiemcu.Size = new global::System.Drawing.Size(136, 24);
			this.checkBoxTrolaiDiemcu.TabIndex = 177;
			this.checkBoxTrolaiDiemcu.Text = "Trở lại điểm cũ";
			this.checkBoxTrolaiDiemcu.UseVisualStyleBackColor = true;
			this.checkBoxTrolaiDiemcu.CheckedChanged += new global::System.EventHandler(this.checkBoxTrolaiDiemcu_CheckedChanged);
			this.buttonLuu.ForeColor = global::System.Drawing.Color.Purple;
			this.buttonLuu.Location = new global::System.Drawing.Point(4, 848);
			this.buttonLuu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLuu.Name = "buttonLuu";
			this.buttonLuu.Size = new global::System.Drawing.Size(108, 58);
			this.buttonLuu.TabIndex = 178;
			this.buttonLuu.Text = "Lưu để xem lại";
			this.buttonLuu.UseVisualStyleBackColor = true;
			this.buttonLuu.Click += new global::System.EventHandler(this.buttonLuu_Click);
			this.buttonXem.ForeColor = global::System.Drawing.Color.Purple;
			this.buttonXem.Location = new global::System.Drawing.Point(120, 848);
			this.buttonXem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXem.Name = "buttonXem";
			this.buttonXem.Size = new global::System.Drawing.Size(94, 58);
			this.buttonXem.TabIndex = 179;
			this.buttonXem.Text = "Xem lại file lưu";
			this.buttonXem.UseVisualStyleBackColor = true;
			this.buttonXem.Click += new global::System.EventHandler(this.buttonXem_Click);
			this.label5.Location = new global::System.Drawing.Point(6, 6);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(518, 309);
			this.label5.TabIndex = 180;
			this.label5.Text = componentResourceManager.GetString("label5.Text");
			this.buttonThumucAuto.ForeColor = global::System.Drawing.Color.Black;
			this.buttonThumucAuto.Location = new global::System.Drawing.Point(186, 320);
			this.buttonThumucAuto.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThumucAuto.Name = "buttonThumucAuto";
			this.buttonThumucAuto.Size = new global::System.Drawing.Size(135, 58);
			this.buttonThumucAuto.TabIndex = 181;
			this.buttonThumucAuto.Text = "Mở thư mục auto";
			this.buttonThumucAuto.UseVisualStyleBackColor = true;
			this.buttonThumucAuto.Click += new global::System.EventHandler(this.buttonThumucAuto_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(2, 105);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(536, 672);
			this.tabControl1.TabIndex = 182;
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(528, 639);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Tọa độ boss";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.buttonThumucAuto);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(528, 639);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chép tọa độ sang máy khác";
			this.tabPage2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(538, 926);
			base.Controls.Add(this.buttonLuu);
			base.Controls.Add(this.buttonXem);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.buttonApdungAll);
			base.Controls.Add(this.buttonMacdinh);
			base.Controls.Add(this.checkBoxTrolaiDiemcu);
			base.Controls.Add(this.checkBoxTuLuuRuong);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormChayBoss";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "BOSS";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormChayBoss_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007C8 RID: 1992
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040007C9 RID: 1993
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040007CA RID: 1994
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x040007CB RID: 1995
		private global::System.Windows.Forms.CheckBox checkBoxTuLuuRuong;

		// Token: 0x040007CC RID: 1996
		private global::System.Windows.Forms.ComboBox comboBoxTenTat;

		// Token: 0x040007CD RID: 1997
		private global::System.Windows.Forms.TextBox textBoxToado;

		// Token: 0x040007CE RID: 1998
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040007CF RID: 1999
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x040007D0 RID: 2000
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x040007D1 RID: 2001
		private global::System.Windows.Forms.Button buttonSua;

		// Token: 0x040007D2 RID: 2002
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040007D3 RID: 2003
		private global::System.Windows.Forms.Button buttonLen;

		// Token: 0x040007D4 RID: 2004
		private global::System.Windows.Forms.Button buttonXuong;

		// Token: 0x040007D5 RID: 2005
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040007D6 RID: 2006
		private global::System.Windows.Forms.Button buttonMacdinh;

		// Token: 0x040007D7 RID: 2007
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x040007D8 RID: 2008
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x040007D9 RID: 2009
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040007DA RID: 2010
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040007DB RID: 2011
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040007DC RID: 2012
		private global::System.Windows.Forms.CheckBox checkBoxTrolaiDiemcu;

		// Token: 0x040007DD RID: 2013
		private global::System.Windows.Forms.Button buttonLuu;

		// Token: 0x040007DE RID: 2014
		private global::System.Windows.Forms.Button buttonXem;

		// Token: 0x040007DF RID: 2015
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040007E0 RID: 2016
		private global::System.Windows.Forms.Button buttonThumucAuto;

		// Token: 0x040007E1 RID: 2017
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040007E2 RID: 2018
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040007E3 RID: 2019
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040007F1 RID: 2033
		private global::System.ComponentModel.IContainer components;
	}
}
