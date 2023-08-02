namespace AutoKeoxe
{
	// Token: 0x0200008B RID: 139
	public partial class FormTuychon : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B66 RID: 2918 RVA: 0x0018A9F8 File Offset: 0x00188BF8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTuychon));
			this.textBoxGiaiBua = new global::System.Windows.Forms.TextBox();
			this.checkBoxDinhbangsat = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.checkBoxTheoBua = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTheoThoigian = new global::System.Windows.Forms.CheckBox();
			this.textBoxThoigianGiaibua = new global::System.Windows.Forms.TextBox();
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.checkBoxApdungAllThoigian = new global::System.Windows.Forms.CheckBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBoxPhim = new global::System.Windows.Forms.ComboBox();
			this.checkBoxBamphim = new global::System.Windows.Forms.CheckBox();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.checkBoxChetNamImAll = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBossTruocNguoiSau = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTutimMuctieu = new global::System.Windows.Forms.CheckBox();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.buttonApdung = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.checkBoxChiTiet = new global::System.Windows.Forms.CheckBox();
			this.textBoxBosGiay = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.checkBoxBosPhongTan = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBosKenhBang = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBosKenhKhac = new global::System.Windows.Forms.CheckBox();
			this.tabPage7 = new global::System.Windows.Forms.TabPage();
			this.label5 = new global::System.Windows.Forms.Label();
			this.buttonBaovatXoaSaiso = new global::System.Windows.Forms.Button();
			this.textBoxSaisoBaovat = new global::System.Windows.Forms.TextBox();
			this.buttonTimSaiso = new global::System.Windows.Forms.Button();
			this.label37 = new global::System.Windows.Forms.Label();
			this.comboBox3 = new global::System.Windows.Forms.ComboBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabPage8 = new global::System.Windows.Forms.TabPage();
			this.checkBoxTDP = new global::System.Windows.Forms.CheckBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.checkBoxQuangThuoc = new global::System.Windows.Forms.CheckBox();
			this.checkBoxMuaNoiChiendau = new global::System.Windows.Forms.CheckBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage8.SuspendLayout();
			base.SuspendLayout();
			this.textBoxGiaiBua.Location = new global::System.Drawing.Point(386, 11);
			this.textBoxGiaiBua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxGiaiBua.Name = "textBoxGiaiBua";
			this.textBoxGiaiBua.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxGiaiBua.TabIndex = 169;
			this.textBoxGiaiBua.TextChanged += new global::System.EventHandler(this.textBoxGiaiBua_TextChanged);
			this.checkBoxDinhbangsat.AutoSize = true;
			this.checkBoxDinhbangsat.Location = new global::System.Drawing.Point(9, 89);
			this.checkBoxDinhbangsat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDinhbangsat.Name = "checkBoxDinhbangsat";
			this.checkBoxDinhbangsat.Size = new global::System.Drawing.Size(399, 24);
			this.checkBoxDinhbangsat.TabIndex = 2;
			this.checkBoxDinhbangsat.Text = "Tự xuất 120 khi bị đứng hình do dính băng sát, bẫy...";
			this.checkBoxDinhbangsat.UseVisualStyleBackColor = true;
			this.checkBoxDinhbangsat.CheckedChanged += new global::System.EventHandler(this.checkBoxDinhbangsat_CheckedChanged);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.checkBoxTheoBua.AutoSize = true;
			this.checkBoxTheoBua.Location = new global::System.Drawing.Point(9, 14);
			this.checkBoxTheoBua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTheoBua.Name = "checkBoxTheoBua";
			this.checkBoxTheoBua.Size = new global::System.Drawing.Size(362, 24);
			this.checkBoxTheoBua.TabIndex = 3;
			this.checkBoxTheoBua.Text = "Tự xuất skill 120 khi bị bùa, độc... sau (mili giây)";
			this.checkBoxTheoBua.UseVisualStyleBackColor = true;
			this.checkBoxTheoBua.CheckedChanged += new global::System.EventHandler(this.checkBoxTheoBua_CheckedChanged);
			this.checkBoxTheoThoigian.AutoSize = true;
			this.checkBoxTheoThoigian.Location = new global::System.Drawing.Point(9, 52);
			this.checkBoxTheoThoigian.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTheoThoigian.Name = "checkBoxTheoThoigian";
			this.checkBoxTheoThoigian.Size = new global::System.Drawing.Size(335, 24);
			this.checkBoxTheoThoigian.TabIndex = 170;
			this.checkBoxTheoThoigian.Text = "Hoặc xuất skill 120 theo thời gian (mili giây)";
			this.checkBoxTheoThoigian.UseVisualStyleBackColor = true;
			this.checkBoxTheoThoigian.CheckedChanged += new global::System.EventHandler(this.checkBoxTheoThoigian_CheckedChanged);
			this.textBoxThoigianGiaibua.Location = new global::System.Drawing.Point(386, 48);
			this.textBoxThoigianGiaibua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxThoigianGiaibua.Name = "textBoxThoigianGiaibua";
			this.textBoxThoigianGiaibua.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxThoigianGiaibua.TabIndex = 171;
			this.textBoxThoigianGiaibua.TextChanged += new global::System.EventHandler(this.textBoxThoigianGiaibua_TextChanged);
			this.buttonApdungAll.Location = new global::System.Drawing.Point(276, 22);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(166, 62);
			this.buttonApdungAll.TabIndex = 172;
			this.buttonApdungAll.Text = "Áp dụng cho tất cả ac Võ đang";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.checkBoxApdungAllThoigian.Checked = true;
			this.checkBoxApdungAllThoigian.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkBoxApdungAllThoigian.Location = new global::System.Drawing.Point(9, 29);
			this.checkBoxApdungAllThoigian.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxApdungAllThoigian.Name = "checkBoxApdungAllThoigian";
			this.checkBoxApdungAllThoigian.Size = new global::System.Drawing.Size(261, 51);
			this.checkBoxApdungAllThoigian.TabIndex = 173;
			this.checkBoxApdungAllThoigian.Text = "Không áp dụng cho tất cả ac phần thời gian (mili giây)";
			this.checkBoxApdungAllThoigian.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.buttonApdungAll);
			this.groupBox1.Controls.Add(this.checkBoxApdungAllThoigian);
			this.groupBox1.Location = new global::System.Drawing.Point(4, 129);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(459, 97);
			this.groupBox1.TabIndex = 174;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Áp dụng tất cả Võ đang";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Location = new global::System.Drawing.Point(2, 2);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(482, 272);
			this.tabControl1.TabIndex = 175;
			this.tabPage1.Controls.Add(this.checkBoxTheoThoigian);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Controls.Add(this.checkBoxDinhbangsat);
			this.tabPage1.Controls.Add(this.textBoxThoigianGiaibua);
			this.tabPage1.Controls.Add(this.checkBoxTheoBua);
			this.tabPage1.Controls.Add(this.textBoxGiaiBua);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "VĐ";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.richTextBox2);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.comboBoxPhim);
			this.tabPage2.Controls.Add(this.checkBoxBamphim);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "TN";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.richTextBox2.Location = new global::System.Drawing.Point(4, 5);
			this.richTextBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(458, 146);
			this.richTextBox2.TabIndex = 23;
			this.richTextBox2.Text = componentResourceManager.GetString("richTextBox2.Text");
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(336, 168);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(119, 20);
			this.label2.TabIndex = 22;
			this.label2.Text = "phím xuất chiêu";
			this.comboBoxPhim.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPhim.FormattingEnabled = true;
			this.comboBoxPhim.Location = new global::System.Drawing.Point(362, 192);
			this.comboBoxPhim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxPhim.Name = "comboBoxPhim";
			this.comboBoxPhim.Size = new global::System.Drawing.Size(76, 28);
			this.comboBoxPhim.TabIndex = 20;
			this.comboBoxPhim.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxPhim_SelectedIndexChanged);
			this.checkBoxBamphim.Location = new global::System.Drawing.Point(4, 165);
			this.checkBoxBamphim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBamphim.Name = "checkBoxBamphim";
			this.checkBoxBamphim.Size = new global::System.Drawing.Size(290, 63);
			this.checkBoxBamphim.TabIndex = 19;
			this.checkBoxBamphim.Text = "Bấm phím để TN xuất chiêu theo vị trí chuột của ac chính";
			this.checkBoxBamphim.UseVisualStyleBackColor = true;
			this.checkBoxBamphim.CheckedChanged += new global::System.EventHandler(this.checkBoxBamphim_CheckedChanged);
			this.tabPage3.Controls.Add(this.checkBoxChetNamImAll);
			this.tabPage3.Controls.Add(this.checkBoxBossTruocNguoiSau);
			this.tabPage3.Controls.Add(this.checkBoxTutimMuctieu);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Kiểu";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.checkBoxChetNamImAll.AutoSize = true;
			this.checkBoxChetNamImAll.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxChetNamImAll.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxChetNamImAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxChetNamImAll.Location = new global::System.Drawing.Point(9, 149);
			this.checkBoxChetNamImAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxChetNamImAll.Name = "checkBoxChetNamImAll";
			this.checkBoxChetNamImAll.Size = new global::System.Drawing.Size(266, 25);
			this.checkBoxChetNamImAll.TabIndex = 349;
			this.checkBoxChetNamImAll.Text = "Áp dụng toàn cục cho tất cả ac";
			this.checkBoxChetNamImAll.UseVisualStyleBackColor = false;
			this.checkBoxChetNamImAll.CheckedChanged += new global::System.EventHandler(this.checkBoxChetNamImAll_CheckedChanged);
			this.checkBoxBossTruocNguoiSau.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxBossTruocNguoiSau.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxBossTruocNguoiSau.Location = new global::System.Drawing.Point(9, 5);
			this.checkBoxBossTruocNguoiSau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBossTruocNguoiSau.Name = "checkBoxBossTruocNguoiSau";
			this.checkBoxBossTruocNguoiSau.Size = new global::System.Drawing.Size(326, 57);
			this.checkBoxBossTruocNguoiSau.TabIndex = 348;
			this.checkBoxBossTruocNguoiSau.Text = "Ưu tiên đánh boss trước, đánh người sau";
			this.checkBoxBossTruocNguoiSau.UseVisualStyleBackColor = false;
			this.checkBoxBossTruocNguoiSau.CheckedChanged += new global::System.EventHandler(this.checkBoxBossTruocNguoiSau_CheckedChanged);
			this.checkBoxTutimMuctieu.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxTutimMuctieu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTutimMuctieu.Location = new global::System.Drawing.Point(10, 75);
			this.checkBoxTutimMuctieu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTutimMuctieu.Name = "checkBoxTutimMuctieu";
			this.checkBoxTutimMuctieu.Size = new global::System.Drawing.Size(324, 51);
			this.checkBoxTutimMuctieu.TabIndex = 336;
			this.checkBoxTutimMuctieu.Text = "Nếu ac chính không có mục tiêu thì ac phụ tự tìm mục tiêu để đánh";
			this.checkBoxTutimMuctieu.UseVisualStyleBackColor = false;
			this.checkBoxTutimMuctieu.CheckedChanged += new global::System.EventHandler(this.checkBoxTutimMuctieu_CheckedChanged);
			this.tabPage4.Controls.Add(this.buttonApdung);
			this.tabPage4.Controls.Add(this.richTextBox1);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage4.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "KhCách";
			this.tabPage4.UseVisualStyleBackColor = true;
			this.buttonApdung.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonApdung.Location = new global::System.Drawing.Point(45, 195);
			this.buttonApdung.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdung.Name = "buttonApdung";
			this.buttonApdung.Size = new global::System.Drawing.Size(386, 35);
			this.buttonApdung.TabIndex = 6;
			this.buttonApdung.Text = "Áp dụng kiểu đánh khoảng cách tất cả ac";
			this.buttonApdung.UseVisualStyleBackColor = true;
			this.buttonApdung.Click += new global::System.EventHandler(this.buttonApdung_Click);
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 0);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(463, 187);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.tabPage5.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage5.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Sửa đồ";
			this.tabPage5.UseVisualStyleBackColor = true;
			this.tabPage6.Controls.Add(this.checkBoxChiTiet);
			this.tabPage6.Controls.Add(this.textBoxBosGiay);
			this.tabPage6.Controls.Add(this.label4);
			this.tabPage6.Controls.Add(this.groupBox2);
			this.tabPage6.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage6.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage6.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "Báo";
			this.tabPage6.UseVisualStyleBackColor = true;
			this.checkBoxChiTiet.AutoSize = true;
			this.checkBoxChiTiet.Location = new global::System.Drawing.Point(10, 195);
			this.checkBoxChiTiet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxChiTiet.Name = "checkBoxChiTiet";
			this.checkBoxChiTiet.Size = new global::System.Drawing.Size(200, 24);
			this.checkBoxChiTiet.TabIndex = 217;
			this.checkBoxChiTiet.Text = "Báo chi tiết hướng chạy";
			this.checkBoxChiTiet.UseVisualStyleBackColor = true;
			this.checkBoxChiTiet.CheckedChanged += new global::System.EventHandler(this.checkBoxChiTiet_CheckedChanged);
			this.textBoxBosGiay.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxBosGiay.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxBosGiay.Location = new global::System.Drawing.Point(177, 160);
			this.textBoxBosGiay.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxBosGiay.Name = "textBoxBosGiay";
			this.textBoxBosGiay.Size = new global::System.Drawing.Size(56, 26);
			this.textBoxBosGiay.TabIndex = 221;
			this.textBoxBosGiay.TextChanged += new global::System.EventHandler(this.textBoxBosGiay_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(6, 165);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(146, 20);
			this.label4.TabIndex = 222;
			this.label4.Text = "Thời gian báo (giây)";
			this.groupBox2.Controls.Add(this.checkBoxBosPhongTan);
			this.groupBox2.Controls.Add(this.checkBoxBosKenhBang);
			this.groupBox2.Controls.Add(this.checkBoxBosKenhKhac);
			this.groupBox2.Location = new global::System.Drawing.Point(4, 5);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new global::System.Drawing.Size(231, 148);
			this.groupBox2.TabIndex = 220;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Thiết lập chung";
			this.checkBoxBosPhongTan.AutoSize = true;
			this.checkBoxBosPhongTan.Location = new global::System.Drawing.Point(27, 72);
			this.checkBoxBosPhongTan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBosPhongTan.Name = "checkBoxBosPhongTan";
			this.checkBoxBosPhongTan.Size = new global::System.Drawing.Size(141, 24);
			this.checkBoxBosPhongTan.TabIndex = 216;
			this.checkBoxBosPhongTan.Text = "Báo Phòng tán";
			this.checkBoxBosPhongTan.UseVisualStyleBackColor = true;
			this.checkBoxBosPhongTan.CheckedChanged += new global::System.EventHandler(this.checkBoxBosPhongTan_CheckedChanged);
			this.checkBoxBosKenhBang.AutoSize = true;
			this.checkBoxBosKenhBang.Location = new global::System.Drawing.Point(27, 108);
			this.checkBoxBosKenhBang.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBosKenhBang.Name = "checkBoxBosKenhBang";
			this.checkBoxBosKenhBang.Size = new global::System.Drawing.Size(143, 24);
			this.checkBoxBosKenhBang.TabIndex = 215;
			this.checkBoxBosKenhBang.Text = "Báo kênh bang";
			this.checkBoxBosKenhBang.UseVisualStyleBackColor = true;
			this.checkBoxBosKenhBang.CheckedChanged += new global::System.EventHandler(this.checkBoxBosKenhBang_CheckedChanged);
			this.checkBoxBosKenhKhac.AutoSize = true;
			this.checkBoxBosKenhKhac.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxBosKenhKhac.Location = new global::System.Drawing.Point(27, 34);
			this.checkBoxBosKenhKhac.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBosKenhKhac.Name = "checkBoxBosKenhKhac";
			this.checkBoxBosKenhKhac.Size = new global::System.Drawing.Size(141, 24);
			this.checkBoxBosKenhKhac.TabIndex = 214;
			this.checkBoxBosKenhKhac.Text = "Báo kênh khác";
			this.checkBoxBosKenhKhac.UseVisualStyleBackColor = true;
			this.checkBoxBosKenhKhac.CheckedChanged += new global::System.EventHandler(this.checkBoxBosKenhKhac_CheckedChanged);
			this.tabPage7.Controls.Add(this.label5);
			this.tabPage7.Controls.Add(this.buttonBaovatXoaSaiso);
			this.tabPage7.Controls.Add(this.textBoxSaisoBaovat);
			this.tabPage7.Controls.Add(this.buttonTimSaiso);
			this.tabPage7.Controls.Add(this.label37);
			this.tabPage7.Controls.Add(this.comboBox3);
			this.tabPage7.Controls.Add(this.comboBox2);
			this.tabPage7.Controls.Add(this.comboBox1);
			this.tabPage7.Controls.Add(this.label1);
			this.tabPage7.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage7.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage7.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "KTC";
			this.tabPage7.UseVisualStyleBackColor = true;
			this.label5.Location = new global::System.Drawing.Point(4, 146);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(363, 72);
			this.label5.TabIndex = 360;
			this.label5.Text = "1. Bấm nút Bảo vật để mở bảng kỳ trân các lên\r\n2. Bấm nút Mua, để đó đừng bấm xác nhận\r\n3. Ở auto, bấm nút Lấy giá trị sai số ở bên dưới.";
			this.buttonBaovatXoaSaiso.Location = new global::System.Drawing.Point(370, 86);
			this.buttonBaovatXoaSaiso.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBaovatXoaSaiso.Name = "buttonBaovatXoaSaiso";
			this.buttonBaovatXoaSaiso.Size = new global::System.Drawing.Size(98, 32);
			this.buttonBaovatXoaSaiso.TabIndex = 352;
			this.buttonBaovatXoaSaiso.Text = "Mặc định";
			this.buttonBaovatXoaSaiso.UseVisualStyleBackColor = true;
			this.buttonBaovatXoaSaiso.Click += new global::System.EventHandler(this.buttonBaovatXoaSaiso_Click);
			this.textBoxSaisoBaovat.Location = new global::System.Drawing.Point(370, 125);
			this.textBoxSaisoBaovat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSaisoBaovat.Name = "textBoxSaisoBaovat";
			this.textBoxSaisoBaovat.ReadOnly = true;
			this.textBoxSaisoBaovat.Size = new global::System.Drawing.Size(94, 26);
			this.textBoxSaisoBaovat.TabIndex = 350;
			this.textBoxSaisoBaovat.Text = "0";
			this.textBoxSaisoBaovat.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.buttonTimSaiso.Location = new global::System.Drawing.Point(370, 163);
			this.buttonTimSaiso.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTimSaiso.Name = "buttonTimSaiso";
			this.buttonTimSaiso.Size = new global::System.Drawing.Size(98, 65);
			this.buttonTimSaiso.TabIndex = 351;
			this.buttonTimSaiso.Text = "Lấy giá trị sai số";
			this.buttonTimSaiso.UseVisualStyleBackColor = true;
			this.buttonTimSaiso.Click += new global::System.EventHandler(this.buttonTimSaiso_Click);
			this.label37.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.label37.Location = new global::System.Drawing.Point(4, 86);
			this.label37.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(363, 48);
			this.label37.TabIndex = 176;
			this.label37.Text = "Nếu mua SAI ở Bảo vật (không mua được), thì làm 3 bước dưới để lấy giá trị sai số fix lỗi.";
			this.comboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new global::System.Drawing.Point(315, 38);
			this.comboBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new global::System.Drawing.Size(148, 28);
			this.comboBox3.TabIndex = 359;
			this.comboBox3.SelectedIndexChanged += new global::System.EventHandler(this.comboBox3_SelectedIndexChanged);
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(164, 38);
			this.comboBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(148, 28);
			this.comboBox2.TabIndex = 357;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(10, 38);
			this.comboBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(148, 28);
			this.comboBox1.TabIndex = 355;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 8);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(439, 20);
			this.label1.TabIndex = 352;
			this.label1.Text = "[ Mua 1] [ Mua 2] [ Mua 3 ] trong Bảo vật nằm ở tab tương ứng";
			this.tabPage8.Controls.Add(this.checkBoxTDP);
			this.tabPage8.Controls.Add(this.label8);
			this.tabPage8.Controls.Add(this.label7);
			this.tabPage8.Controls.Add(this.label6);
			this.tabPage8.Controls.Add(this.checkBoxQuangThuoc);
			this.tabPage8.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage8.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage8.Size = new global::System.Drawing.Size(474, 239);
			this.tabPage8.TabIndex = 7;
			this.tabPage8.Text = "Quăng thuốc";
			this.tabPage8.UseVisualStyleBackColor = true;
			this.checkBoxTDP.AutoSize = true;
			this.checkBoxTDP.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTDP.Location = new global::System.Drawing.Point(6, 195);
			this.checkBoxTDP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTDP.Name = "checkBoxTDP";
			this.checkBoxTDP.Size = new global::System.Drawing.Size(303, 24);
			this.checkBoxTDP.TabIndex = 216;
			this.checkBoxTDP.Text = "Thổ địa phù sau khi quăng thuốc xong";
			this.checkBoxTDP.UseVisualStyleBackColor = true;
			this.checkBoxTDP.CheckedChanged += new global::System.EventHandler(this.checkBoxTDP_CheckedChanged);
			this.label8.Location = new global::System.Drawing.Point(148, 6);
			this.label8.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(318, 154);
			this.label8.TabIndex = 215;
			this.label8.Text = componentResourceManager.GetString("label8.Text");
			this.label7.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new global::System.Drawing.Point(16, 42);
			this.label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(118, 32);
			this.label7.TabIndex = 214;
			this.label7.Text = "  CTRL + F1  ";
			this.label7.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label6.Location = new global::System.Drawing.Point(8, 6);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(116, 20);
			this.label6.TabIndex = 213;
			this.label6.Text = "Phím tắt quăng";
			this.checkBoxQuangThuoc.AutoSize = true;
			this.checkBoxQuangThuoc.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxQuangThuoc.Location = new global::System.Drawing.Point(6, 160);
			this.checkBoxQuangThuoc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxQuangThuoc.Name = "checkBoxQuangThuoc";
			this.checkBoxQuangThuoc.Size = new global::System.Drawing.Size(301, 24);
			this.checkBoxQuangThuoc.TabIndex = 212;
			this.checkBoxQuangThuoc.Text = "Gặp ac chính thì tự động quăng thuốc";
			this.checkBoxQuangThuoc.UseVisualStyleBackColor = true;
			this.checkBoxQuangThuoc.CheckedChanged += new global::System.EventHandler(this.checkBoxQuangThuoc_CheckedChanged);
			this.checkBoxMuaNoiChiendau.AutoSize = true;
			this.checkBoxMuaNoiChiendau.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxMuaNoiChiendau.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxMuaNoiChiendau.Location = new global::System.Drawing.Point(6, 282);
			this.checkBoxMuaNoiChiendau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMuaNoiChiendau.Name = "checkBoxMuaNoiChiendau";
			this.checkBoxMuaNoiChiendau.Size = new global::System.Drawing.Size(393, 24);
			this.checkBoxMuaNoiChiendau.TabIndex = 349;
			this.checkBoxMuaNoiChiendau.Text = "Tự động mua ở nơi chiến đấu, lưu ý các vấn đề sau:";
			this.checkBoxMuaNoiChiendau.UseVisualStyleBackColor = false;
			this.checkBoxMuaNoiChiendau.CheckedChanged += new global::System.EventHandler(this.checkBoxMuaNoiChiendau_CheckedChanged);
			this.label3.Location = new global::System.Drawing.Point(4, 322);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(480, 51);
			this.label3.TabIndex = 350;
			this.label3.Text = "- Khi nút <Tự mở túi thuốc> đã mở hết túi thuốc\r\n- Các game không mua được ở nơi chiến đấu thì đừng check vào";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(486, 385);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.checkBoxMuaNoiChiendau);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormTuychon";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "TUY CHON";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTuychon_Load);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			this.tabPage8.ResumeLayout(false);
			this.tabPage8.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CF4 RID: 3316
		private global::System.Windows.Forms.TextBox textBoxGiaiBua;

		// Token: 0x04000CF5 RID: 3317
		private global::System.Windows.Forms.CheckBox checkBoxDinhbangsat;

		// Token: 0x04000CF6 RID: 3318
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CF7 RID: 3319
		private global::System.Windows.Forms.CheckBox checkBoxTheoBua;

		// Token: 0x04000CF8 RID: 3320
		private global::System.Windows.Forms.CheckBox checkBoxTheoThoigian;

		// Token: 0x04000CF9 RID: 3321
		private global::System.Windows.Forms.TextBox textBoxThoigianGiaibua;

		// Token: 0x04000CFA RID: 3322
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x04000CFB RID: 3323
		private global::System.Windows.Forms.CheckBox checkBoxApdungAllThoigian;

		// Token: 0x04000CFC RID: 3324
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000CFD RID: 3325
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000CFE RID: 3326
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000CFF RID: 3327
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000D00 RID: 3328
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D01 RID: 3329
		private global::System.Windows.Forms.ComboBox comboBoxPhim;

		// Token: 0x04000D02 RID: 3330
		private global::System.Windows.Forms.CheckBox checkBoxBamphim;

		// Token: 0x04000D03 RID: 3331
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000D04 RID: 3332
		private global::System.Windows.Forms.CheckBox checkBoxTutimMuctieu;

		// Token: 0x04000D05 RID: 3333
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x04000D06 RID: 3334
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000D07 RID: 3335
		private global::System.Windows.Forms.Button buttonApdung;

		// Token: 0x04000D08 RID: 3336
		private global::System.Windows.Forms.CheckBox checkBoxBossTruocNguoiSau;

		// Token: 0x04000D09 RID: 3337
		private global::System.Windows.Forms.CheckBox checkBoxChetNamImAll;

		// Token: 0x04000D0A RID: 3338
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x04000D0B RID: 3339
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000D0C RID: 3340
		private global::System.Windows.Forms.CheckBox checkBoxBosPhongTan;

		// Token: 0x04000D0D RID: 3341
		private global::System.Windows.Forms.CheckBox checkBoxBosKenhBang;

		// Token: 0x04000D0E RID: 3342
		private global::System.Windows.Forms.CheckBox checkBoxBosKenhKhac;

		// Token: 0x04000D0F RID: 3343
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x04000D10 RID: 3344
		private global::System.Windows.Forms.TextBox textBoxBosGiay;

		// Token: 0x04000D11 RID: 3345
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000D12 RID: 3346
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x04000D13 RID: 3347
		private global::System.Windows.Forms.TabPage tabPage7;

		// Token: 0x04000D14 RID: 3348
		private global::System.Windows.Forms.CheckBox checkBoxMuaNoiChiendau;

		// Token: 0x04000D15 RID: 3349
		private global::System.Windows.Forms.ComboBox comboBox3;

		// Token: 0x04000D16 RID: 3350
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x04000D17 RID: 3351
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000D18 RID: 3352
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D19 RID: 3353
		private global::System.Windows.Forms.CheckBox checkBoxChiTiet;

		// Token: 0x04000D1A RID: 3354
		private global::System.Windows.Forms.TabPage tabPage8;

		// Token: 0x04000D1B RID: 3355
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000D1C RID: 3356
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000D1D RID: 3357
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000D1E RID: 3358
		private global::System.Windows.Forms.CheckBox checkBoxQuangThuoc;

		// Token: 0x04000D1F RID: 3359
		private global::System.Windows.Forms.CheckBox checkBoxTDP;

		// Token: 0x04000D20 RID: 3360
		private global::System.Windows.Forms.Label label37;

		// Token: 0x04000D21 RID: 3361
		private global::System.Windows.Forms.Button buttonBaovatXoaSaiso;

		// Token: 0x04000D22 RID: 3362
		private global::System.Windows.Forms.TextBox textBoxSaisoBaovat;

		// Token: 0x04000D23 RID: 3363
		private global::System.Windows.Forms.Button buttonTimSaiso;

		// Token: 0x04000D24 RID: 3364
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000D25 RID: 3365
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000D2A RID: 3370
		private global::System.ComponentModel.IContainer components;
	}
}
