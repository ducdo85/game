namespace AutoKeoxe
{
	// Token: 0x02000069 RID: 105
	public partial class FormClickNPC : global::System.Windows.Forms.Form
	{
		// Token: 0x06000814 RID: 2068 RVA: 0x001371E4 File Offset: 0x001353E4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormClickNPC));
			this.comboBoxVatpham = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxMenuVatpham = new global::System.Windows.Forms.TextBox();
			this.checkBoxCosudungVatpham = new global::System.Windows.Forms.CheckBox();
			this.checkBoxDoithoaiTruoc = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.buttonDong = new global::System.Windows.Forms.Button();
			this.labelTenac = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.checkBoxCoMuaVatpham = new global::System.Windows.Forms.CheckBox();
			this.comboBoxMuaVP = new global::System.Windows.Forms.ComboBox();
			this.textBoxSoluongMua = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.linkLabelMuaPhaohoa = new global::System.Windows.Forms.LinkLabel();
			this.checkBoxRuthettien = new global::System.Windows.Forms.CheckBox();
			this.checkBoxClickNpcNopVP = new global::System.Windows.Forms.CheckBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxNop = new global::System.Windows.Forms.ComboBox();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBoxSoluongNop = new global::System.Windows.Forms.TextBox();
			this.checkBoxMuaKTC = new global::System.Windows.Forms.CheckBox();
			this.comboBoxTabKTC = new global::System.Windows.Forms.ComboBox();
			this.buttonSuaNopVP = new global::System.Windows.Forms.Button();
			this.checkBoxTach = new global::System.Windows.Forms.CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBoxMuaKhiHet = new global::System.Windows.Forms.CheckBox();
			this.textBoxMuaKhicon = new global::System.Windows.Forms.TextBox();
			this.checkBoxCoNhapSL = new global::System.Windows.Forms.CheckBox();
			this.textBoxCoNhapSL = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.comboBoxVatpham.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVatpham.DropDownWidth = 200;
			this.comboBoxVatpham.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxVatpham.FormattingEnabled = true;
			this.comboBoxVatpham.Location = new global::System.Drawing.Point(220, 175);
			this.comboBoxVatpham.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxVatpham.Name = "comboBoxVatpham";
			this.comboBoxVatpham.Size = new global::System.Drawing.Size(253, 28);
			this.comboBoxVatpham.TabIndex = 199;
			this.comboBoxVatpham.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxVatpham_SelectedIndexChanged);
			this.comboBoxVatpham.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxVatpham_MouseDown);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.MidnightBlue;
			this.label1.Location = new global::System.Drawing.Point(460, 148);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(92, 20);
			this.label1.TabIndex = 200;
			this.label1.Text = "_click menu";
			this.textBoxMenuVatpham.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxMenuVatpham.Location = new global::System.Drawing.Point(480, 177);
			this.textBoxMenuVatpham.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMenuVatpham.Name = "textBoxMenuVatpham";
			this.textBoxMenuVatpham.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxMenuVatpham.TabIndex = 201;
			this.textBoxMenuVatpham.TextChanged += new global::System.EventHandler(this.textBoxMenuVatpham_TextChanged);
			this.checkBoxCosudungVatpham.AutoSize = true;
			this.checkBoxCosudungVatpham.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxCosudungVatpham.ForeColor = global::System.Drawing.Color.MidnightBlue;
			this.checkBoxCosudungVatpham.Location = new global::System.Drawing.Point(4, 178);
			this.checkBoxCosudungVatpham.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCosudungVatpham.Name = "checkBoxCosudungVatpham";
			this.checkBoxCosudungVatpham.Size = new global::System.Drawing.Size(220, 24);
			this.checkBoxCosudungVatpham.TabIndex = 202;
			this.checkBoxCosudungVatpham.Text = "1a. Có sử dụng vật phẩm";
			this.checkBoxCosudungVatpham.UseVisualStyleBackColor = true;
			this.checkBoxCosudungVatpham.CheckedChanged += new global::System.EventHandler(this.checkBoxCosudungVatpham_CheckedChanged);
			this.checkBoxDoithoaiTruoc.AutoSize = true;
			this.checkBoxDoithoaiTruoc.ForeColor = global::System.Drawing.Color.MidnightBlue;
			this.checkBoxDoithoaiTruoc.Location = new global::System.Drawing.Point(4, 214);
			this.checkBoxDoithoaiTruoc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDoithoaiTruoc.Name = "checkBoxDoithoaiTruoc";
			this.checkBoxDoithoaiTruoc.Size = new global::System.Drawing.Size(323, 24);
			this.checkBoxDoithoaiTruoc.TabIndex = 203;
			this.checkBoxDoithoaiTruoc.Text = "1b. Click Npc xong mới sử dụng vật phẩm";
			this.checkBoxDoithoaiTruoc.UseVisualStyleBackColor = true;
			this.checkBoxDoithoaiTruoc.CheckedChanged += new global::System.EventHandler(this.checkBoxDoithoaiTruoc_CheckedChanged);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonApdungAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonApdungAll.Location = new global::System.Drawing.Point(177, 691);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(212, 49);
			this.buttonApdungAll.TabIndex = 207;
			this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.buttonDong.Location = new global::System.Drawing.Point(398, 691);
			this.buttonDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDong.Name = "buttonDong";
			this.buttonDong.Size = new global::System.Drawing.Size(158, 49);
			this.buttonDong.TabIndex = 208;
			this.buttonDong.Text = "Đóng";
			this.buttonDong.UseVisualStyleBackColor = true;
			this.buttonDong.Click += new global::System.EventHandler(this.buttonDong_Click);
			this.labelTenac.AutoSize = true;
			this.labelTenac.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelTenac.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTenac.ForeColor = global::System.Drawing.Color.Red;
			this.labelTenac.Location = new global::System.Drawing.Point(4, 140);
			this.labelTenac.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTenac.Name = "labelTenac";
			this.labelTenac.Size = new global::System.Drawing.Size(72, 20);
			this.labelTenac.TabIndex = 210;
			this.labelTenac.Text = "Tên ac:";
			this.richTextBox1.BackColor = global::System.Drawing.Color.Gainsboro;
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 3);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(548, 127);
			this.richTextBox1.TabIndex = 211;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.checkBoxCoMuaVatpham.AutoSize = true;
			this.checkBoxCoMuaVatpham.ForeColor = global::System.Drawing.Color.Indigo;
			this.checkBoxCoMuaVatpham.Location = new global::System.Drawing.Point(4, 289);
			this.checkBoxCoMuaVatpham.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCoMuaVatpham.Name = "checkBoxCoMuaVatpham";
			this.checkBoxCoMuaVatpham.Size = new global::System.Drawing.Size(185, 24);
			this.checkBoxCoMuaVatpham.TabIndex = 212;
			this.checkBoxCoMuaVatpham.Text = "2a. Có mua vật phẩm";
			this.checkBoxCoMuaVatpham.UseVisualStyleBackColor = true;
			this.checkBoxCoMuaVatpham.CheckedChanged += new global::System.EventHandler(this.checkBoxCoMuaVatpham_CheckedChanged);
			this.comboBoxMuaVP.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMuaVP.DropDownWidth = 200;
			this.comboBoxMuaVP.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxMuaVP.FormattingEnabled = true;
			this.comboBoxMuaVP.Location = new global::System.Drawing.Point(220, 285);
			this.comboBoxMuaVP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxMuaVP.Name = "comboBoxMuaVP";
			this.comboBoxMuaVP.Size = new global::System.Drawing.Size(253, 28);
			this.comboBoxMuaVP.TabIndex = 213;
			this.comboBoxMuaVP.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxMuaVP_SelectedIndexChanged);
			this.comboBoxMuaVP.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxMuaVP_MouseDown);
			this.textBoxSoluongMua.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxSoluongMua.Location = new global::System.Drawing.Point(480, 286);
			this.textBoxSoluongMua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSoluongMua.Name = "textBoxSoluongMua";
			this.textBoxSoluongMua.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxSoluongMua.TabIndex = 214;
			this.textBoxSoluongMua.Text = "1";
			this.textBoxSoluongMua.TextChanged += new global::System.EventHandler(this.textBoxSoluongMua_TextChanged);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.DarkSlateGray;
			this.label3.Location = new global::System.Drawing.Point(4, 655);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(291, 20);
			this.label3.TabIndex = 215;
			this.label3.Text = "(ví dụ như mua lệnh bài phi tốc tống kim)";
			this.linkLabelMuaPhaohoa.AutoSize = true;
			this.linkLabelMuaPhaohoa.Location = new global::System.Drawing.Point(314, 655);
			this.linkLabelMuaPhaohoa.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelMuaPhaohoa.Name = "linkLabelMuaPhaohoa";
			this.linkLabelMuaPhaohoa.Size = new global::System.Drawing.Size(102, 20);
			this.linkLabelMuaPhaohoa.TabIndex = 217;
			this.linkLabelMuaPhaohoa.TabStop = true;
			this.linkLabelMuaPhaohoa.Text = "=> Xem phim";
			this.linkLabelMuaPhaohoa.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMuaPhaohoa_LinkClicked);
			this.checkBoxRuthettien.AutoSize = true;
			this.checkBoxRuthettien.ForeColor = global::System.Drawing.Color.Indigo;
			this.checkBoxRuthettien.Location = new global::System.Drawing.Point(4, 325);
			this.checkBoxRuthettien.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxRuthettien.Name = "checkBoxRuthettien";
			this.checkBoxRuthettien.Size = new global::System.Drawing.Size(203, 24);
			this.checkBoxRuthettien.TabIndex = 218;
			this.checkBoxRuthettien.Text = "2b. Rút hết tiền khi mua";
			this.checkBoxRuthettien.UseVisualStyleBackColor = true;
			this.checkBoxRuthettien.CheckedChanged += new global::System.EventHandler(this.checkBoxRuthettien_CheckedChanged);
			this.checkBoxClickNpcNopVP.AutoSize = true;
			this.checkBoxClickNpcNopVP.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxClickNpcNopVP.Location = new global::System.Drawing.Point(4, 435);
			this.checkBoxClickNpcNopVP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxClickNpcNopVP.Name = "checkBoxClickNpcNopVP";
			this.checkBoxClickNpcNopVP.Size = new global::System.Drawing.Size(172, 24);
			this.checkBoxClickNpcNopVP.TabIndex = 220;
			this.checkBoxClickNpcNopVP.Text = "3. Có nộp vật phẩm";
			this.checkBoxClickNpcNopVP.UseVisualStyleBackColor = true;
			this.checkBoxClickNpcNopVP.CheckedChanged += new global::System.EventHandler(this.checkBoxClickNpcNopVP_CheckedChanged);
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(220, 428);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(332, 166);
			this.listView1.TabIndex = 221;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "Tên vật phẩm nộp";
			this.columnHeader_0.Width = 170;
			this.columnHeader_1.Text = "SL";
			this.columnHeader_1.Width = 25;
			this.comboBoxNop.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNop.DropDownWidth = 200;
			this.comboBoxNop.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxNop.FormattingEnabled = true;
			this.comboBoxNop.Location = new global::System.Drawing.Point(4, 471);
			this.comboBoxNop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxNop.Name = "comboBoxNop";
			this.comboBoxNop.Size = new global::System.Drawing.Size(205, 28);
			this.comboBoxNop.TabIndex = 222;
			this.comboBoxNop.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxNop_MouseDown);
			this.buttonThem.Location = new global::System.Drawing.Point(135, 515);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(76, 35);
			this.buttonThem.TabIndex = 223;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(135, 560);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(76, 35);
			this.buttonXoa.TabIndex = 224;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(4, 518);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(72, 20);
			this.label2.TabIndex = 225;
			this.label2.Text = "Số lượng";
			this.textBoxSoluongNop.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxSoluongNop.Location = new global::System.Drawing.Point(82, 515);
			this.textBoxSoluongNop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSoluongNop.Name = "textBoxSoluongNop";
			this.textBoxSoluongNop.Size = new global::System.Drawing.Size(43, 26);
			this.textBoxSoluongNop.TabIndex = 226;
			this.textBoxSoluongNop.Text = "1";
			this.checkBoxMuaKTC.AutoSize = true;
			this.checkBoxMuaKTC.ForeColor = global::System.Drawing.Color.Indigo;
			this.checkBoxMuaKTC.Location = new global::System.Drawing.Point(220, 325);
			this.checkBoxMuaKTC.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMuaKTC.Name = "checkBoxMuaKTC";
			this.checkBoxMuaKTC.Size = new global::System.Drawing.Size(191, 24);
			this.checkBoxMuaKTC.TabIndex = 227;
			this.checkBoxMuaKTC.Text = "2c. Mua ở KTC, tab =>";
			this.checkBoxMuaKTC.UseVisualStyleBackColor = true;
			this.checkBoxMuaKTC.CheckedChanged += new global::System.EventHandler(this.checkBoxMuaKTC_CheckedChanged);
			this.comboBoxTabKTC.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTabKTC.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxTabKTC.FormattingEnabled = true;
			this.comboBoxTabKTC.Location = new global::System.Drawing.Point(420, 322);
			this.comboBoxTabKTC.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTabKTC.Name = "comboBoxTabKTC";
			this.comboBoxTabKTC.Size = new global::System.Drawing.Size(134, 28);
			this.comboBoxTabKTC.TabIndex = 228;
			this.comboBoxTabKTC.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxTabKTC_SelectedIndexChanged);
			this.buttonSuaNopVP.Location = new global::System.Drawing.Point(39, 560);
			this.buttonSuaNopVP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSuaNopVP.Name = "buttonSuaNopVP";
			this.buttonSuaNopVP.Size = new global::System.Drawing.Size(88, 35);
			this.buttonSuaNopVP.TabIndex = 229;
			this.buttonSuaNopVP.Text = "Sửa";
			this.buttonSuaNopVP.UseVisualStyleBackColor = true;
			this.buttonSuaNopVP.Click += new global::System.EventHandler(this.buttonSuaNopVP_Click);
			this.checkBoxTach.AutoSize = true;
			this.checkBoxTach.Location = new global::System.Drawing.Point(220, 605);
			this.checkBoxTach.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTach.Name = "checkBoxTach";
			this.checkBoxTach.Size = new global::System.Drawing.Size(234, 24);
			this.checkBoxTach.TabIndex = 230;
			this.checkBoxTach.Text = "Tách vật phẩm trước khi nộp";
			this.checkBoxTach.UseVisualStyleBackColor = true;
			this.checkBoxTach.CheckedChanged += new global::System.EventHandler(this.checkBoxTach_CheckedChanged);
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.Indigo;
			this.label4.Location = new global::System.Drawing.Point(460, 260);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(78, 20);
			this.label4.TabIndex = 231;
			this.label4.Text = "_số lượng";
			this.checkBoxMuaKhiHet.AutoSize = true;
			this.checkBoxMuaKhiHet.ForeColor = global::System.Drawing.Color.Indigo;
			this.checkBoxMuaKhiHet.Location = new global::System.Drawing.Point(220, 362);
			this.checkBoxMuaKhiHet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMuaKhiHet.Name = "checkBoxMuaKhiHet";
			this.checkBoxMuaKhiHet.Size = new global::System.Drawing.Size(276, 24);
			this.checkBoxMuaKhiHet.TabIndex = 232;
			this.checkBoxMuaKhiHet.Text = "2d. Chỉ mua khi hành trang còn <=";
			this.checkBoxMuaKhiHet.UseVisualStyleBackColor = true;
			this.checkBoxMuaKhiHet.CheckedChanged += new global::System.EventHandler(this.checkBoxMuaKhiHet_CheckedChanged);
			this.textBoxMuaKhicon.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxMuaKhicon.Location = new global::System.Drawing.Point(510, 358);
			this.textBoxMuaKhicon.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMuaKhicon.Name = "textBoxMuaKhicon";
			this.textBoxMuaKhicon.Size = new global::System.Drawing.Size(43, 26);
			this.textBoxMuaKhicon.TabIndex = 233;
			this.textBoxMuaKhicon.Text = "1";
			this.textBoxMuaKhicon.TextChanged += new global::System.EventHandler(this.textBoxMuaKhicon_TextChanged);
			this.checkBoxCoNhapSL.AutoSize = true;
			this.checkBoxCoNhapSL.ForeColor = global::System.Drawing.Color.MidnightBlue;
			this.checkBoxCoNhapSL.Location = new global::System.Drawing.Point(344, 214);
			this.checkBoxCoNhapSL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCoNhapSL.Name = "checkBoxCoNhapSL";
			this.checkBoxCoNhapSL.Size = new global::System.Drawing.Size(159, 24);
			this.checkBoxCoNhapSL.TabIndex = 234;
			this.checkBoxCoNhapSL.Text = "Có nhập số lượng";
			this.checkBoxCoNhapSL.UseVisualStyleBackColor = true;
			this.checkBoxCoNhapSL.CheckedChanged += new global::System.EventHandler(this.checkBoxCoNhapSL_CheckedChanged);
			this.textBoxCoNhapSL.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxCoNhapSL.Location = new global::System.Drawing.Point(510, 211);
			this.textBoxCoNhapSL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxCoNhapSL.Name = "textBoxCoNhapSL";
			this.textBoxCoNhapSL.Size = new global::System.Drawing.Size(43, 26);
			this.textBoxCoNhapSL.TabIndex = 235;
			this.textBoxCoNhapSL.TextChanged += new global::System.EventHandler(this.textBoxCoNhapSL_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(561, 751);
			base.Controls.Add(this.comboBoxTabKTC);
			base.Controls.Add(this.textBoxCoNhapSL);
			base.Controls.Add(this.checkBoxCoNhapSL);
			base.Controls.Add(this.textBoxMuaKhicon);
			base.Controls.Add(this.checkBoxMuaKhiHet);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.checkBoxTach);
			base.Controls.Add(this.buttonSuaNopVP);
			base.Controls.Add(this.checkBoxMuaKTC);
			base.Controls.Add(this.textBoxSoluongNop);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.comboBoxNop);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.checkBoxClickNpcNopVP);
			base.Controls.Add(this.checkBoxRuthettien);
			base.Controls.Add(this.linkLabelMuaPhaohoa);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.comboBoxMuaVP);
			base.Controls.Add(this.textBoxSoluongMua);
			base.Controls.Add(this.checkBoxCoMuaVatpham);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.labelTenac);
			base.Controls.Add(this.buttonDong);
			base.Controls.Add(this.buttonApdungAll);
			base.Controls.Add(this.comboBoxVatpham);
			base.Controls.Add(this.checkBoxDoithoaiTruoc);
			base.Controls.Add(this.checkBoxCosudungVatpham);
			base.Controls.Add(this.textBoxMenuVatpham);
			base.Controls.Add(this.label1);
			this.ForeColor = global::System.Drawing.Color.Navy;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormClickNPC";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "CLICK NPC";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormClickNPC_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000803 RID: 2051
		private global::System.Windows.Forms.ComboBox comboBoxVatpham;

		// Token: 0x04000804 RID: 2052
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000805 RID: 2053
		private global::System.Windows.Forms.TextBox textBoxMenuVatpham;

		// Token: 0x04000806 RID: 2054
		private global::System.Windows.Forms.CheckBox checkBoxCosudungVatpham;

		// Token: 0x04000807 RID: 2055
		private global::System.Windows.Forms.CheckBox checkBoxDoithoaiTruoc;

		// Token: 0x04000808 RID: 2056
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000809 RID: 2057
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x0400080A RID: 2058
		private global::System.Windows.Forms.Button buttonDong;

		// Token: 0x0400080B RID: 2059
		private global::System.Windows.Forms.Label labelTenac;

		// Token: 0x0400080C RID: 2060
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400080D RID: 2061
		private global::System.Windows.Forms.CheckBox checkBoxCoMuaVatpham;

		// Token: 0x0400080E RID: 2062
		private global::System.Windows.Forms.ComboBox comboBoxMuaVP;

		// Token: 0x0400080F RID: 2063
		private global::System.Windows.Forms.TextBox textBoxSoluongMua;

		// Token: 0x04000810 RID: 2064
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000811 RID: 2065
		private global::System.Windows.Forms.LinkLabel linkLabelMuaPhaohoa;

		// Token: 0x04000812 RID: 2066
		private global::System.Windows.Forms.CheckBox checkBoxRuthettien;

		// Token: 0x04000813 RID: 2067
		private global::System.Windows.Forms.CheckBox checkBoxClickNpcNopVP;

		// Token: 0x04000814 RID: 2068
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000815 RID: 2069
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000816 RID: 2070
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000817 RID: 2071
		private global::System.Windows.Forms.ComboBox comboBoxNop;

		// Token: 0x04000818 RID: 2072
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000819 RID: 2073
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x0400081A RID: 2074
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400081B RID: 2075
		private global::System.Windows.Forms.TextBox textBoxSoluongNop;

		// Token: 0x0400081C RID: 2076
		private global::System.Windows.Forms.CheckBox checkBoxMuaKTC;

		// Token: 0x0400081D RID: 2077
		private global::System.Windows.Forms.ComboBox comboBoxTabKTC;

		// Token: 0x0400081E RID: 2078
		private global::System.Windows.Forms.Button buttonSuaNopVP;

		// Token: 0x0400081F RID: 2079
		private global::System.Windows.Forms.CheckBox checkBoxTach;

		// Token: 0x04000820 RID: 2080
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000821 RID: 2081
		private global::System.Windows.Forms.CheckBox checkBoxMuaKhiHet;

		// Token: 0x04000822 RID: 2082
		private global::System.Windows.Forms.TextBox textBoxMuaKhicon;

		// Token: 0x04000823 RID: 2083
		private global::System.Windows.Forms.CheckBox checkBoxCoNhapSL;

		// Token: 0x04000824 RID: 2084
		private global::System.Windows.Forms.TextBox textBoxCoNhapSL;

		// Token: 0x04000832 RID: 2098
		private global::System.ComponentModel.IContainer components;
	}
}
