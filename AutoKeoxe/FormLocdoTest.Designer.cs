namespace AutoKeoxe
{
	// Token: 0x02000074 RID: 116
	public partial class FormLocdoTest : global::System.Windows.Forms.Form
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x0015227C File Offset: 0x0015047C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormLocdoTest));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.textBoxMin = new global::System.Windows.Forms.TextBox();
			this.buttonSua = new global::System.Windows.Forms.Button();
			this.textBoxName = new global::System.Windows.Forms.TextBox();
			this.checkBoxThoahet = new global::System.Windows.Forms.CheckBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.checkBox2 = new global::System.Windows.Forms.CheckBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.checkBox3 = new global::System.Windows.Forms.CheckBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.checkBox4 = new global::System.Windows.Forms.CheckBox();
			this.textBox5 = new global::System.Windows.Forms.TextBox();
			this.checkBox5 = new global::System.Windows.Forms.CheckBox();
			this.textBox6 = new global::System.Windows.Forms.TextBox();
			this.checkBox6 = new global::System.Windows.Forms.CheckBox();
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.checkBoxBanVpHoagkimTest = new global::System.Windows.Forms.CheckBox();
			this.textBoxDong = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
			this.checkBoxCoNopVP = new global::System.Windows.Forms.CheckBox();
			this.comboBoxNopVP = new global::System.Windows.Forms.ComboBox();
			this.textBoxSoluongNop = new global::System.Windows.Forms.TextBox();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.linkLabelLuuy = new global::System.Windows.Forms.LinkLabel();
			this.buttonBoCheck = new global::System.Windows.Forms.Button();
			this.checkBoxLocTrangbi = new global::System.Windows.Forms.CheckBox();
			this.comboBoxLocTrangbi = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(408, 825);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(152, 40);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(18, 418);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(540, 301);
			this.listView1.TabIndex = 34;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 45;
			this.columnHeader_1.Text = "Thuộc tính";
			this.columnHeader_1.Width = 220;
			this.columnHeader_2.Text = "Min";
			this.columnHeader_2.Width = 33;
			this.columnHeader_3.Text = "Dòng";
			this.columnHeader_3.Width = 40;
			this.textBoxMin.Location = new global::System.Drawing.Point(400, 729);
			this.textBoxMin.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new global::System.Drawing.Size(48, 26);
			this.textBoxMin.TabIndex = 38;
			this.buttonSua.Location = new global::System.Drawing.Point(492, 729);
			this.buttonSua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new global::System.Drawing.Size(68, 32);
			this.buttonSua.TabIndex = 39;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new global::System.EventHandler(this.buttonSua_Click);
			this.textBoxName.ForeColor = global::System.Drawing.Color.Blue;
			this.textBoxName.Location = new global::System.Drawing.Point(18, 729);
			this.textBoxName.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new global::System.Drawing.Size(372, 26);
			this.textBoxName.TabIndex = 40;
			this.checkBoxThoahet.AutoSize = true;
			this.checkBoxThoahet.ForeColor = global::System.Drawing.Color.Purple;
			this.checkBoxThoahet.Location = new global::System.Drawing.Point(18, 386);
			this.checkBoxThoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxThoahet.Name = "checkBoxThoahet";
			this.checkBoxThoahet.Size = new global::System.Drawing.Size(407, 24);
			this.checkBoxThoahet.TabIndex = 43;
			this.checkBoxThoahet.Text = "Lọc đúng hết điều kiện thuộc tính dưới đây thì mới giữ";
			this.checkBoxThoahet.UseVisualStyleBackColor = true;
			this.checkBoxThoahet.CheckedChanged += new global::System.EventHandler(this.checkBoxThoahet_CheckedChanged);
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox1.Location = new global::System.Drawing.Point(18, 220);
			this.checkBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox1.TabIndex = 44;
			this.checkBox1.Text = "Dòng 1";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.textBox1.ForeColor = global::System.Drawing.Color.Black;
			this.textBox1.Location = new global::System.Drawing.Point(132, 220);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(48, 26);
			this.textBox1.TabIndex = 45;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox2.ForeColor = global::System.Drawing.Color.Black;
			this.textBox2.Location = new global::System.Drawing.Point(132, 255);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(48, 26);
			this.textBox2.TabIndex = 47;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.checkBox2.AutoSize = true;
			this.checkBox2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox2.Location = new global::System.Drawing.Point(18, 258);
			this.checkBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox2.TabIndex = 46;
			this.checkBox2.Text = "Dòng 2";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new global::System.EventHandler(this.checkBox2_CheckedChanged);
			this.textBox3.ForeColor = global::System.Drawing.Color.Black;
			this.textBox3.Location = new global::System.Drawing.Point(326, 220);
			this.textBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(48, 26);
			this.textBox3.TabIndex = 51;
			this.textBox3.TextChanged += new global::System.EventHandler(this.textBox3_TextChanged);
			this.checkBox3.AutoSize = true;
			this.checkBox3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox3.Location = new global::System.Drawing.Point(225, 220);
			this.checkBox3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox3.TabIndex = 50;
			this.checkBox3.Text = "Dòng 3";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new global::System.EventHandler(this.checkBox3_CheckedChanged);
			this.textBox4.ForeColor = global::System.Drawing.Color.Black;
			this.textBox4.Location = new global::System.Drawing.Point(326, 255);
			this.textBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(48, 26);
			this.textBox4.TabIndex = 49;
			this.textBox4.TextChanged += new global::System.EventHandler(this.textBox4_TextChanged);
			this.checkBox4.AutoSize = true;
			this.checkBox4.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox4.Location = new global::System.Drawing.Point(225, 258);
			this.checkBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox4.TabIndex = 48;
			this.checkBox4.Text = "Dòng 4";
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new global::System.EventHandler(this.checkBox4_CheckedChanged);
			this.textBox5.ForeColor = global::System.Drawing.Color.Black;
			this.textBox5.Location = new global::System.Drawing.Point(510, 220);
			this.textBox5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new global::System.Drawing.Size(48, 26);
			this.textBox5.TabIndex = 55;
			this.textBox5.TextChanged += new global::System.EventHandler(this.textBox5_TextChanged);
			this.checkBox5.AutoSize = true;
			this.checkBox5.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox5.Location = new global::System.Drawing.Point(410, 220);
			this.checkBox5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox5.TabIndex = 54;
			this.checkBox5.Text = "Dòng 5";
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new global::System.EventHandler(this.checkBox5_CheckedChanged);
			this.textBox6.ForeColor = global::System.Drawing.Color.Black;
			this.textBox6.Location = new global::System.Drawing.Point(510, 255);
			this.textBox6.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new global::System.Drawing.Size(48, 26);
			this.textBox6.TabIndex = 53;
			this.textBox6.TextChanged += new global::System.EventHandler(this.textBox6_TextChanged);
			this.checkBox6.AutoSize = true;
			this.checkBox6.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox6.Location = new global::System.Drawing.Point(410, 258);
			this.checkBox6.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new global::System.Drawing.Size(87, 24);
			this.checkBox6.TabIndex = 52;
			this.checkBox6.Text = "Dòng 6";
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new global::System.EventHandler(this.checkBox6_CheckedChanged);
			this.buttonApdungAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonApdungAll.Location = new global::System.Drawing.Point(186, 825);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(213, 40);
			this.buttonApdungAll.TabIndex = 56;
			this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.checkBoxBanVpHoagkimTest.AutoSize = true;
			this.checkBoxBanVpHoagkimTest.ForeColor = global::System.Drawing.Color.Red;
			this.checkBoxBanVpHoagkimTest.Location = new global::System.Drawing.Point(18, 345);
			this.checkBoxBanVpHoagkimTest.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBanVpHoagkimTest.Name = "checkBoxBanVpHoagkimTest";
			this.checkBoxBanVpHoagkimTest.Size = new global::System.Drawing.Size(316, 24);
			this.checkBoxBanVpHoagkimTest.TabIndex = 190;
			this.checkBoxBanVpHoagkimTest.Text = "Bán luôn trang bị hoàng kim (cẩn thận !)";
			this.checkBoxBanVpHoagkimTest.UseVisualStyleBackColor = true;
			this.checkBoxBanVpHoagkimTest.CheckedChanged += new global::System.EventHandler(this.checkBoxBanVpHoagkimTest_CheckedChanged);
			this.textBoxDong.Location = new global::System.Drawing.Point(458, 729);
			this.textBoxDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDong.Name = "textBoxDong";
			this.textBoxDong.Size = new global::System.Drawing.Size(28, 26);
			this.textBoxDong.TabIndex = 191;
			this.label1.Location = new global::System.Drawing.Point(18, 769);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(542, 48);
			this.label1.TabIndex = 192;
			this.label1.Text = "Giá trị của Dòng (kế bên Min): Ghi 0 nếu không xét điều kiện dòng, tức là dòng nào cũng được";
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_4,
				this.columnHeader_5,
				this.columnHeader_6
			});
			this.listView2.ForeColor = global::System.Drawing.Color.Black;
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(18, 45);
			this.listView2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(540, 107);
			this.listView2.TabIndex = 194;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_4.Text = "No";
			this.columnHeader_4.Width = 45;
			this.columnHeader_5.Text = "Tên vật phẩm cần nộp";
			this.columnHeader_5.Width = 200;
			this.columnHeader_6.Text = "Số lượng mỗi lần nộp";
			this.columnHeader_6.Width = 90;
			this.checkBoxCoNopVP.AutoSize = true;
			this.checkBoxCoNopVP.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxCoNopVP.Location = new global::System.Drawing.Point(18, 6);
			this.checkBoxCoNopVP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCoNopVP.Name = "checkBoxCoNopVP";
			this.checkBoxCoNopVP.Size = new global::System.Drawing.Size(243, 24);
			this.checkBoxCoNopVP.TabIndex = 195;
			this.checkBoxCoNopVP.Text = "Có nộp vật phẩm trước khi lọc";
			this.checkBoxCoNopVP.UseVisualStyleBackColor = true;
			this.checkBoxCoNopVP.CheckedChanged += new global::System.EventHandler(this.checkBoxCoNopVP_CheckedChanged);
			this.comboBoxNopVP.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNopVP.FormattingEnabled = true;
			this.comboBoxNopVP.Location = new global::System.Drawing.Point(186, 162);
			this.comboBoxNopVP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxNopVP.Name = "comboBoxNopVP";
			this.comboBoxNopVP.Size = new global::System.Drawing.Size(302, 28);
			this.comboBoxNopVP.TabIndex = 203;
			this.comboBoxNopVP.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxNopVP_MouseDown);
			this.textBoxSoluongNop.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxSoluongNop.Location = new global::System.Drawing.Point(496, 163);
			this.textBoxSoluongNop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSoluongNop.Name = "textBoxSoluongNop";
			this.textBoxSoluongNop.Size = new global::System.Drawing.Size(61, 26);
			this.textBoxSoluongNop.TabIndex = 204;
			this.textBoxSoluongNop.Text = "1";
			this.buttonXoa.Location = new global::System.Drawing.Point(18, 162);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(68, 32);
			this.buttonXoa.TabIndex = 205;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonThem.Location = new global::System.Drawing.Point(94, 162);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(87, 32);
			this.buttonThem.TabIndex = 206;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.linkLabelLuuy.AutoSize = true;
			this.linkLabelLuuy.Location = new global::System.Drawing.Point(274, 11);
			this.linkLabelLuuy.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelLuuy.Name = "linkLabelLuuy";
			this.linkLabelLuuy.Size = new global::System.Drawing.Size(272, 20);
			this.linkLabelLuuy.TabIndex = 207;
			this.linkLabelLuuy.TabStop = true;
			this.linkLabelLuuy.Text = "==> click ở đây để xem ngay lưu ý <==";
			this.linkLabelLuuy.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLuuy_LinkClicked);
			this.buttonBoCheck.Location = new global::System.Drawing.Point(18, 825);
			this.buttonBoCheck.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBoCheck.Name = "buttonBoCheck";
			this.buttonBoCheck.Size = new global::System.Drawing.Size(153, 40);
			this.buttonBoCheck.TabIndex = 208;
			this.buttonBoCheck.Text = "Bỏ check tất cả";
			this.buttonBoCheck.UseVisualStyleBackColor = true;
			this.buttonBoCheck.Click += new global::System.EventHandler(this.buttonBoCheck_Click);
			this.checkBoxLocTrangbi.AutoSize = true;
			this.checkBoxLocTrangbi.ForeColor = global::System.Drawing.Color.Red;
			this.checkBoxLocTrangbi.Location = new global::System.Drawing.Point(18, 308);
			this.checkBoxLocTrangbi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLocTrangbi.Name = "checkBoxLocTrangbi";
			this.checkBoxLocTrangbi.Size = new global::System.Drawing.Size(334, 24);
			this.checkBoxLocTrangbi.TabIndex = 209;
			this.checkBoxLocTrangbi.Text = "Chỉ lọc lấy trang bị ở bên, còn lại bán tất cả";
			this.checkBoxLocTrangbi.UseVisualStyleBackColor = true;
			this.checkBoxLocTrangbi.CheckedChanged += new global::System.EventHandler(this.checkBoxLocTrangbi_CheckedChanged);
			this.comboBoxLocTrangbi.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLocTrangbi.FormattingEnabled = true;
			this.comboBoxLocTrangbi.Location = new global::System.Drawing.Point(372, 305);
			this.comboBoxLocTrangbi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxLocTrangbi.Name = "comboBoxLocTrangbi";
			this.comboBoxLocTrangbi.Size = new global::System.Drawing.Size(186, 28);
			this.comboBoxLocTrangbi.TabIndex = 210;
			this.comboBoxLocTrangbi.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxLocTrangbi_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(567, 871);
			base.Controls.Add(this.comboBoxLocTrangbi);
			base.Controls.Add(this.checkBoxLocTrangbi);
			base.Controls.Add(this.buttonBoCheck);
			base.Controls.Add(this.linkLabelLuuy);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.textBoxSoluongNop);
			base.Controls.Add(this.comboBoxNopVP);
			base.Controls.Add(this.checkBoxCoNopVP);
			base.Controls.Add(this.listView2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBoxDong);
			base.Controls.Add(this.checkBoxBanVpHoagkimTest);
			base.Controls.Add(this.buttonApdungAll);
			base.Controls.Add(this.textBox5);
			base.Controls.Add(this.checkBox5);
			base.Controls.Add(this.textBox6);
			base.Controls.Add(this.checkBox6);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.checkBoxThoahet);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.textBoxName);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.textBoxMin);
			base.Controls.Add(this.buttonSua);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormLocdoTest";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOC TRANG BI TEST";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormLocdoTest_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000977 RID: 2423
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000978 RID: 2424
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000979 RID: 2425
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400097A RID: 2426
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400097B RID: 2427
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x0400097C RID: 2428
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x0400097D RID: 2429
		private global::System.Windows.Forms.TextBox textBoxMin;

		// Token: 0x0400097E RID: 2430
		private global::System.Windows.Forms.Button buttonSua;

		// Token: 0x0400097F RID: 2431
		private global::System.Windows.Forms.TextBox textBoxName;

		// Token: 0x04000980 RID: 2432
		private global::System.Windows.Forms.CheckBox checkBoxThoahet;

		// Token: 0x04000981 RID: 2433
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000982 RID: 2434
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000983 RID: 2435
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000984 RID: 2436
		private global::System.Windows.Forms.CheckBox checkBox2;

		// Token: 0x04000985 RID: 2437
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000986 RID: 2438
		private global::System.Windows.Forms.CheckBox checkBox3;

		// Token: 0x04000987 RID: 2439
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x04000988 RID: 2440
		private global::System.Windows.Forms.CheckBox checkBox4;

		// Token: 0x04000989 RID: 2441
		private global::System.Windows.Forms.TextBox textBox5;

		// Token: 0x0400098A RID: 2442
		private global::System.Windows.Forms.CheckBox checkBox5;

		// Token: 0x0400098B RID: 2443
		private global::System.Windows.Forms.TextBox textBox6;

		// Token: 0x0400098C RID: 2444
		private global::System.Windows.Forms.CheckBox checkBox6;

		// Token: 0x0400098D RID: 2445
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x0400098E RID: 2446
		private global::System.Windows.Forms.CheckBox checkBoxBanVpHoagkimTest;

		// Token: 0x0400098F RID: 2447
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000990 RID: 2448
		private global::System.Windows.Forms.TextBox textBoxDong;

		// Token: 0x04000991 RID: 2449
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000992 RID: 2450
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x04000993 RID: 2451
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000994 RID: 2452
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x04000995 RID: 2453
		private global::System.Windows.Forms.CheckBox checkBoxCoNopVP;

		// Token: 0x04000996 RID: 2454
		private global::System.Windows.Forms.ComboBox comboBoxNopVP;

		// Token: 0x04000997 RID: 2455
		private global::System.Windows.Forms.TextBox textBoxSoluongNop;

		// Token: 0x04000998 RID: 2456
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000999 RID: 2457
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x0400099A RID: 2458
		private global::System.Windows.Forms.ColumnHeader columnHeader_6;

		// Token: 0x0400099B RID: 2459
		private global::System.Windows.Forms.LinkLabel linkLabelLuuy;

		// Token: 0x0400099C RID: 2460
		private global::System.Windows.Forms.Button buttonBoCheck;

		// Token: 0x0400099D RID: 2461
		private global::System.Windows.Forms.CheckBox checkBoxLocTrangbi;

		// Token: 0x0400099E RID: 2462
		private global::System.Windows.Forms.ComboBox comboBoxLocTrangbi;

		// Token: 0x040009BB RID: 2491
		private global::System.ComponentModel.IContainer components;
	}
}
