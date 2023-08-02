namespace AutoKeoxe
{
	// Token: 0x0200006F RID: 111
	public partial class FormHaucanTuithuoc : global::System.Windows.Forms.Form
	{
		// Token: 0x060008C5 RID: 2245 RVA: 0x001493B8 File Offset: 0x001475B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormHaucanTuithuoc));
			this.checkBoxCoNhapSoluong = new global::System.Windows.Forms.CheckBox();
			this.comboBoxTenTuiMauHotro = new global::System.Windows.Forms.ComboBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.checkBoxClickMenu = new global::System.Windows.Forms.CheckBox();
			this.textBoxMothuocKhicon = new global::System.Windows.Forms.TextBox();
			this.checkBoxMoTheoThoigian = new global::System.Windows.Forms.CheckBox();
			this.checkBoxMoTheoSoluong = new global::System.Windows.Forms.CheckBox();
			this.textBoxThoigian = new global::System.Windows.Forms.TextBox();
			this.buttonAppAll = new global::System.Windows.Forms.Button();
			this.checkBoxTrangThai = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTamDung = new global::System.Windows.Forms.CheckBox();
			this.textBoxMenu = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBoxSoluongMax = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkBoxKhongMo = new global::System.Windows.Forms.CheckBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.checkBoxCoNhapSoluong.AutoSize = true;
			this.checkBoxCoNhapSoluong.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxCoNhapSoluong.CheckAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxCoNhapSoluong.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.checkBoxCoNhapSoluong.Location = new global::System.Drawing.Point(16, 258);
			this.checkBoxCoNhapSoluong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCoNhapSoluong.Name = "checkBoxCoNhapSoluong";
			this.checkBoxCoNhapSoluong.Size = new global::System.Drawing.Size(500, 24);
			this.checkBoxCoNhapSoluong.TabIndex = 210;
			this.checkBoxCoNhapSoluong.Text = "Có nhập số lượng khi mở túi thuốc (không có nhập thì đừng check)";
			this.checkBoxCoNhapSoluong.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxCoNhapSoluong.UseVisualStyleBackColor = false;
			this.checkBoxCoNhapSoluong.CheckedChanged += new global::System.EventHandler(this.checkBoxCoNhapSoluong_CheckedChanged);
			this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
			this.comboBoxTenTuiMauHotro.Location = new global::System.Drawing.Point(16, 214);
			this.comboBoxTenTuiMauHotro.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
			this.comboBoxTenTuiMauHotro.Size = new global::System.Drawing.Size(342, 28);
			this.comboBoxTenTuiMauHotro.TabIndex = 217;
			this.comboBoxTenTuiMauHotro.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenTuiMauHotro_MouseDown);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_5
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(16, 40);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(678, 165);
			this.listView1.TabIndex = 218;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "Tên túi máu, vật phẩm";
			this.columnHeader_0.Width = 130;
			this.columnHeader_1.Text = "Theo SL";
			this.columnHeader_1.Width = 65;
			this.columnHeader_2.Text = "Theo time";
			this.columnHeader_2.Width = 65;
			this.columnHeader_3.Text = "Box nhập";
			this.columnHeader_3.Width = 65;
			this.columnHeader_4.Text = "Click menu";
			this.columnHeader_4.Width = 65;
			this.columnHeader_5.Text = "TT";
			this.columnHeader_5.Width = 40;
			this.buttonThem.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonThem.Location = new global::System.Drawing.Point(369, 214);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(222, 35);
			this.buttonThem.TabIndex = 219;
			this.buttonThem.Text = "Thêm vào danh sách";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(600, 214);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(96, 35);
			this.buttonXoa.TabIndex = 220;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(552, 478);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(144, 42);
			this.buttonClose.TabIndex = 222;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.checkBoxClickMenu.AutoSize = true;
			this.checkBoxClickMenu.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxClickMenu.CheckAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxClickMenu.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxClickMenu.Location = new global::System.Drawing.Point(16, 463);
			this.checkBoxClickMenu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxClickMenu.Name = "checkBoxClickMenu";
			this.checkBoxClickMenu.Size = new global::System.Drawing.Size(378, 24);
			this.checkBoxClickMenu.TabIndex = 223;
			this.checkBoxClickMenu.Text = "Có menu và cần click vào các dòng...(ví dụ: 4,2,1)";
			this.checkBoxClickMenu.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxClickMenu.UseVisualStyleBackColor = false;
			this.checkBoxClickMenu.CheckedChanged += new global::System.EventHandler(this.checkBoxClickMenu_CheckedChanged);
			this.textBoxMothuocKhicon.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxMothuocKhicon.Location = new global::System.Drawing.Point(388, 305);
			this.textBoxMothuocKhicon.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMothuocKhicon.Name = "textBoxMothuocKhicon";
			this.textBoxMothuocKhicon.Size = new global::System.Drawing.Size(70, 26);
			this.textBoxMothuocKhicon.TabIndex = 226;
			this.textBoxMothuocKhicon.TextChanged += new global::System.EventHandler(this.textBoxMothuocKhicon_TextChanged);
			this.checkBoxMoTheoThoigian.AutoSize = true;
			this.checkBoxMoTheoThoigian.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxMoTheoThoigian.CheckAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxMoTheoThoigian.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxMoTheoThoigian.Location = new global::System.Drawing.Point(16, 352);
			this.checkBoxMoTheoThoigian.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMoTheoThoigian.Name = "checkBoxMoTheoThoigian";
			this.checkBoxMoTheoThoigian.Size = new global::System.Drawing.Size(355, 24);
			this.checkBoxMoTheoThoigian.TabIndex = 227;
			this.checkBoxMoTheoThoigian.Text = "Sử dụng theo thời gian (ms) (1giây = 1000ms)";
			this.checkBoxMoTheoThoigian.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxMoTheoThoigian.UseVisualStyleBackColor = false;
			this.checkBoxMoTheoThoigian.CheckedChanged += new global::System.EventHandler(this.checkBoxMoTheoThoigian_CheckedChanged);
			this.checkBoxMoTheoSoluong.AutoSize = true;
			this.checkBoxMoTheoSoluong.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxMoTheoSoluong.CheckAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxMoTheoSoluong.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxMoTheoSoluong.Location = new global::System.Drawing.Point(16, 306);
			this.checkBoxMoTheoSoluong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMoTheoSoluong.Name = "checkBoxMoTheoSoluong";
			this.checkBoxMoTheoSoluong.Size = new global::System.Drawing.Size(356, 24);
			this.checkBoxMoTheoSoluong.TabIndex = 228;
			this.checkBoxMoTheoSoluong.Text = "Sử dụng khi số lượng thuốc phục hồi máu còn";
			this.checkBoxMoTheoSoluong.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxMoTheoSoluong.UseVisualStyleBackColor = false;
			this.checkBoxMoTheoSoluong.CheckedChanged += new global::System.EventHandler(this.checkBoxMoTheoSoluong_CheckedChanged);
			this.textBoxThoigian.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxThoigian.Location = new global::System.Drawing.Point(388, 349);
			this.textBoxThoigian.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxThoigian.Name = "textBoxThoigian";
			this.textBoxThoigian.Size = new global::System.Drawing.Size(70, 26);
			this.textBoxThoigian.TabIndex = 229;
			this.textBoxThoigian.TextChanged += new global::System.EventHandler(this.textBoxThoigian_TextChanged);
			this.buttonAppAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonAppAll.Location = new global::System.Drawing.Point(552, 405);
			this.buttonAppAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAppAll.Name = "buttonAppAll";
			this.buttonAppAll.Size = new global::System.Drawing.Size(144, 65);
			this.buttonAppAll.TabIndex = 231;
			this.buttonAppAll.Text = "Áp dụng cho tất cả ac";
			this.buttonAppAll.UseVisualStyleBackColor = true;
			this.buttonAppAll.Click += new global::System.EventHandler(this.buttonAppAll_Click);
			this.checkBoxTrangThai.AutoSize = true;
			this.checkBoxTrangThai.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxTrangThai.CheckAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxTrangThai.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxTrangThai.Location = new global::System.Drawing.Point(16, 392);
			this.checkBoxTrangThai.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTrangThai.Name = "checkBoxTrangThai";
			this.checkBoxTrangThai.Size = new global::System.Drawing.Size(473, 24);
			this.checkBoxTrangThai.TabIndex = 234;
			this.checkBoxTrangThai.Text = "Sử dụng khi thay đổi bản đồ hoặc thay đổi trạng thái chiến đấu";
			this.checkBoxTrangThai.TextAlign = global::System.Drawing.ContentAlignment.TopLeft;
			this.checkBoxTrangThai.UseVisualStyleBackColor = false;
			this.checkBoxTrangThai.CheckedChanged += new global::System.EventHandler(this.checkBoxTrangThai_CheckedChanged);
			this.checkBoxTamDung.AutoSize = true;
			this.checkBoxTamDung.Location = new global::System.Drawing.Point(40, 426);
			this.checkBoxTamDung.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTamDung.Name = "checkBoxTamDung";
			this.checkBoxTamDung.Size = new global::System.Drawing.Size(296, 24);
			this.checkBoxTamDung.TabIndex = 237;
			this.checkBoxTamDung.Text = "Tạm dừng mọi hoạt động khi sử dụng";
			this.checkBoxTamDung.UseVisualStyleBackColor = true;
			this.checkBoxTamDung.CheckedChanged += new global::System.EventHandler(this.checkBoxTamDung_CheckedChanged);
			this.textBoxMenu.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxMenu.Location = new global::System.Drawing.Point(428, 460);
			this.textBoxMenu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMenu.Name = "textBoxMenu";
			this.textBoxMenu.Size = new global::System.Drawing.Size(68, 26);
			this.textBoxMenu.TabIndex = 241;
			this.textBoxMenu.TextChanged += new global::System.EventHandler(this.textBoxMenu_TextChanged);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label3.Location = new global::System.Drawing.Point(544, 309);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(162, 20);
			this.label3.TabIndex = 242;
			this.label3.Text = "(Số lượng mỗi lần mở)";
			this.textBoxSoluongMax.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxSoluongMax.Location = new global::System.Drawing.Point(466, 305);
			this.textBoxSoluongMax.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSoluongMax.Name = "textBoxSoluongMax";
			this.textBoxSoluongMax.Size = new global::System.Drawing.Size(68, 26);
			this.textBoxSoluongMax.TabIndex = 243;
			this.textBoxSoluongMax.TextChanged += new global::System.EventHandler(this.textBoxSoluongMax_TextChanged);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(12, 506);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(454, 20);
			this.label2.TabIndex = 245;
			this.label2.Text = "Xem và kết hợp với phần <Hậu cần - nhồi thuốc > nha các bạn !";
			this.checkBoxKhongMo.AutoSize = true;
			this.checkBoxKhongMo.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxKhongMo.Location = new global::System.Drawing.Point(16, 5);
			this.checkBoxKhongMo.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongMo.Name = "checkBoxKhongMo";
			this.checkBoxKhongMo.Size = new global::System.Drawing.Size(636, 24);
			this.checkBoxKhongMo.TabIndex = 246;
			this.checkBoxKhongMo.Text = "Không mở túi ở nơi phi chiến đấu (không áp dụng cho thay đổi bản đồ hoặc trạng thái)";
			this.checkBoxKhongMo.UseVisualStyleBackColor = true;
			this.checkBoxKhongMo.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongMo_CheckedChanged);
			this.panel1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new global::System.Drawing.Point(552, 252);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(140, 43);
			this.panel1.TabIndex = 247;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(706, 540);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.checkBoxKhongMo);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBoxSoluongMax);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBoxMenu);
			base.Controls.Add(this.checkBoxClickMenu);
			base.Controls.Add(this.checkBoxTamDung);
			base.Controls.Add(this.checkBoxTrangThai);
			base.Controls.Add(this.buttonAppAll);
			base.Controls.Add(this.textBoxThoigian);
			base.Controls.Add(this.checkBoxMoTheoSoluong);
			base.Controls.Add(this.checkBoxMoTheoThoigian);
			base.Controls.Add(this.textBoxMothuocKhicon);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.comboBoxTenTuiMauHotro);
			base.Controls.Add(this.checkBoxCoNhapSoluong);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormHaucanTuithuoc";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "MO TUI VAT PHAM";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormHaucanTuithuoc_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008DD RID: 2269
		private global::System.Windows.Forms.CheckBox checkBoxCoNhapSoluong;

		// Token: 0x040008DE RID: 2270
		private global::System.Windows.Forms.ComboBox comboBoxTenTuiMauHotro;

		// Token: 0x040008DF RID: 2271
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040008E0 RID: 2272
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040008E1 RID: 2273
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x040008E2 RID: 2274
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040008E5 RID: 2277
		private global::System.Windows.Forms.CheckBox checkBoxClickMenu;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x040008E7 RID: 2279
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x040008E8 RID: 2280
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x040008E9 RID: 2281
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x040008EA RID: 2282
		private global::System.Windows.Forms.TextBox textBoxMothuocKhicon;

		// Token: 0x040008EB RID: 2283
		private global::System.Windows.Forms.CheckBox checkBoxMoTheoThoigian;

		// Token: 0x040008EC RID: 2284
		private global::System.Windows.Forms.CheckBox checkBoxMoTheoSoluong;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.TextBox textBoxThoigian;

		// Token: 0x040008EE RID: 2286
		private global::System.Windows.Forms.Button buttonAppAll;

		// Token: 0x040008EF RID: 2287
		private global::System.Windows.Forms.CheckBox checkBoxTrangThai;

		// Token: 0x040008F0 RID: 2288
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.CheckBox checkBoxTamDung;

		// Token: 0x040008F2 RID: 2290
		private global::System.Windows.Forms.TextBox textBoxMenu;

		// Token: 0x040008F3 RID: 2291
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008F4 RID: 2292
		private global::System.Windows.Forms.TextBox textBoxSoluongMax;

		// Token: 0x040008F5 RID: 2293
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040008F6 RID: 2294
		private global::System.Windows.Forms.CheckBox checkBoxKhongMo;

		// Token: 0x040008F7 RID: 2295
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008F8 RID: 2296
		private global::System.Windows.Forms.Panel panel1;
	}
}
