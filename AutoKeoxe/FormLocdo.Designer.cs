namespace AutoKeoxe
{
	// Token: 0x02000073 RID: 115
	public partial class FormLocdo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x001500F0 File Offset: 0x0014E2F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormLocdo));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxBando = new global::System.Windows.Forms.CheckBox();
			this.checkBoxGiudoTheoCap = new global::System.Windows.Forms.CheckBox();
			this.comboBoxCap = new global::System.Windows.Forms.ComboBox();
			this.checkBoxGiudoTheoHe = new global::System.Windows.Forms.CheckBox();
			this.comboBoxHe = new global::System.Windows.Forms.ComboBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.checkBoxGiudoTheoThuoctinh = new global::System.Windows.Forms.CheckBox();
			this.textBoxMin = new global::System.Windows.Forms.TextBox();
			this.buttonSua = new global::System.Windows.Forms.Button();
			this.textBoxName = new global::System.Windows.Forms.TextBox();
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.checkBoxGiudoTim = new global::System.Windows.Forms.CheckBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.buttonBoCheck = new global::System.Windows.Forms.Button();
			this.textBoxDongDC = new global::System.Windows.Forms.TextBox();
			this.textBoxDongNB = new global::System.Windows.Forms.TextBox();
			this.checkBoxNgocBoi = new global::System.Windows.Forms.CheckBox();
			this.textBoxDongNhan = new global::System.Windows.Forms.TextBox();
			this.checkBoxDaychuyen = new global::System.Windows.Forms.CheckBox();
			this.checkBoxGiuTrangsuc = new global::System.Windows.Forms.CheckBox();
			this.checkBoxThoahet = new global::System.Windows.Forms.CheckBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.buttonXj = new global::System.Windows.Forms.Button();
			this.buttonS = new global::System.Windows.Forms.Button();
			this.buttonO = new global::System.Windows.Forms.Button();
			this.buttonAppdungAll2 = new global::System.Windows.Forms.Button();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.comboBoxTenVatpham = new global::System.Windows.Forms.ComboBox();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.labelVidu = new global::System.Windows.Forms.Label();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxNhatTrongthanh = new global::System.Windows.Forms.CheckBox();
			this.comboBoxBando = new global::System.Windows.Forms.ComboBox();
			this.checkBoxNhatTheoThuoctinh = new global::System.Windows.Forms.CheckBox();
			this.checkBoxKhongNhatdoTim = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBoxTocdoNhat = new global::System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(420, 746);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(90, 34);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxBando.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxBando.Location = new global::System.Drawing.Point(189, 5);
			this.checkBoxBando.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBando.Name = "checkBoxBando";
			this.checkBoxBando.Size = new global::System.Drawing.Size(327, 49);
			this.checkBoxBando.TabIndex = 9;
			this.checkBoxBando.Text = "Bán đồ khi về thành - chỉ áp dụng khi có check vào Train - tab Điều khiển";
			this.checkBoxBando.UseVisualStyleBackColor = true;
			this.checkBoxBando.CheckedChanged += new global::System.EventHandler(this.checkBoxBando_CheckedChanged);
			this.checkBoxGiudoTheoCap.AutoSize = true;
			this.checkBoxGiudoTheoCap.Location = new global::System.Drawing.Point(242, 43);
			this.checkBoxGiudoTheoCap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGiudoTheoCap.Name = "checkBoxGiudoTheoCap";
			this.checkBoxGiudoTheoCap.Size = new global::System.Drawing.Size(148, 24);
			this.checkBoxGiudoTheoCap.TabIndex = 32;
			this.checkBoxGiudoTheoCap.Text = "Giữ đồ theo cấp";
			this.checkBoxGiudoTheoCap.UseVisualStyleBackColor = true;
			this.checkBoxGiudoTheoCap.CheckedChanged += new global::System.EventHandler(this.checkBoxGiudoTheoCap_CheckedChanged);
			this.comboBoxCap.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCap.FormattingEnabled = true;
			this.comboBoxCap.Location = new global::System.Drawing.Point(414, 40);
			this.comboBoxCap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxCap.Name = "comboBoxCap";
			this.comboBoxCap.Size = new global::System.Drawing.Size(74, 28);
			this.comboBoxCap.TabIndex = 30;
			this.comboBoxCap.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxCap_SelectedIndexChanged);
			this.checkBoxGiudoTheoHe.AutoSize = true;
			this.checkBoxGiudoTheoHe.Location = new global::System.Drawing.Point(242, 78);
			this.checkBoxGiudoTheoHe.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGiudoTheoHe.Name = "checkBoxGiudoTheoHe";
			this.checkBoxGiudoTheoHe.Size = new global::System.Drawing.Size(140, 24);
			this.checkBoxGiudoTheoHe.TabIndex = 33;
			this.checkBoxGiudoTheoHe.Text = "Giữ đồ theo hệ";
			this.checkBoxGiudoTheoHe.UseVisualStyleBackColor = true;
			this.checkBoxGiudoTheoHe.CheckedChanged += new global::System.EventHandler(this.checkBoxGiudoTheoHe_CheckedChanged);
			this.comboBoxHe.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxHe.FormattingEnabled = true;
			this.comboBoxHe.Location = new global::System.Drawing.Point(414, 77);
			this.comboBoxHe.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxHe.Name = "comboBoxHe";
			this.comboBoxHe.Size = new global::System.Drawing.Size(73, 28);
			this.comboBoxHe.TabIndex = 31;
			this.comboBoxHe.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxHe_SelectedIndexChanged);
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(4, 182);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(487, 366);
			this.listView1.TabIndex = 34;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 45;
			this.columnHeader_1.Text = "Thuộc tính";
			this.columnHeader_1.Width = 225;
			this.columnHeader_2.Text = "Min";
			this.columnHeader_2.Width = 35;
			this.checkBoxGiudoTheoThuoctinh.AutoSize = true;
			this.checkBoxGiudoTheoThuoctinh.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxGiudoTheoThuoctinh.Location = new global::System.Drawing.Point(4, 112);
			this.checkBoxGiudoTheoThuoctinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGiudoTheoThuoctinh.Name = "checkBoxGiudoTheoThuoctinh";
			this.checkBoxGiudoTheoThuoctinh.Size = new global::System.Drawing.Size(226, 24);
			this.checkBoxGiudoTheoThuoctinh.TabIndex = 35;
			this.checkBoxGiudoTheoThuoctinh.Text = "Giữ đồ theo thuộc tính dưới";
			this.checkBoxGiudoTheoThuoctinh.UseVisualStyleBackColor = true;
			this.checkBoxGiudoTheoThuoctinh.CheckedChanged += new global::System.EventHandler(this.checkBoxGiudoTheoThuoctinh_CheckedChanged);
			this.textBoxMin.Location = new global::System.Drawing.Point(374, 555);
			this.textBoxMin.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new global::System.Drawing.Size(48, 26);
			this.textBoxMin.TabIndex = 38;
			this.buttonSua.Location = new global::System.Drawing.Point(426, 554);
			this.buttonSua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new global::System.Drawing.Size(68, 32);
			this.buttonSua.TabIndex = 39;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new global::System.EventHandler(this.buttonSua_Click);
			this.textBoxName.ForeColor = global::System.Drawing.Color.Blue;
			this.textBoxName.Location = new global::System.Drawing.Point(166, 555);
			this.textBoxName.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.ReadOnly = true;
			this.textBoxName.Size = new global::System.Drawing.Size(200, 26);
			this.textBoxName.TabIndex = 40;
			this.buttonApdungAll.ForeColor = global::System.Drawing.Color.Black;
			this.buttonApdungAll.Location = new global::System.Drawing.Point(198, 746);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(213, 34);
			this.buttonApdungAll.TabIndex = 41;
			this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.checkBoxGiudoTim.AutoSize = true;
			this.checkBoxGiudoTim.Location = new global::System.Drawing.Point(242, 5);
			this.checkBoxGiudoTim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGiudoTim.Name = "checkBoxGiudoTim";
			this.checkBoxGiudoTim.Size = new global::System.Drawing.Size(107, 24);
			this.checkBoxGiudoTim.TabIndex = 42;
			this.checkBoxGiudoTim.Text = "Giữ đồ tím";
			this.checkBoxGiudoTim.UseVisualStyleBackColor = true;
			this.checkBoxGiudoTim.CheckedChanged += new global::System.EventHandler(this.checkBoxGiudoTim_CheckedChanged);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 109);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(510, 631);
			this.tabControl1.TabIndex = 43;
			this.tabPage1.Controls.Add(this.buttonBoCheck);
			this.tabPage1.Controls.Add(this.textBoxDongDC);
			this.tabPage1.Controls.Add(this.textBoxDongNB);
			this.tabPage1.Controls.Add(this.checkBoxNgocBoi);
			this.tabPage1.Controls.Add(this.textBoxDongNhan);
			this.tabPage1.Controls.Add(this.checkBoxDaychuyen);
			this.tabPage1.Controls.Add(this.checkBoxGiuTrangsuc);
			this.tabPage1.Controls.Add(this.checkBoxThoahet);
			this.tabPage1.Controls.Add(this.textBoxName);
			this.tabPage1.Controls.Add(this.checkBoxGiudoTim);
			this.tabPage1.Controls.Add(this.checkBoxGiudoTheoThuoctinh);
			this.tabPage1.Controls.Add(this.checkBoxGiudoTheoCap);
			this.tabPage1.Controls.Add(this.comboBoxCap);
			this.tabPage1.Controls.Add(this.textBoxMin);
			this.tabPage1.Controls.Add(this.checkBoxGiudoTheoHe);
			this.tabPage1.Controls.Add(this.comboBoxHe);
			this.tabPage1.Controls.Add(this.buttonSua);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(502, 598);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Bảng thuộc tính ";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.buttonBoCheck.Location = new global::System.Drawing.Point(4, 554);
			this.buttonBoCheck.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBoCheck.Name = "buttonBoCheck";
			this.buttonBoCheck.Size = new global::System.Drawing.Size(153, 32);
			this.buttonBoCheck.TabIndex = 49;
			this.buttonBoCheck.Text = "Bỏ check tất cả";
			this.buttonBoCheck.UseVisualStyleBackColor = true;
			this.buttonBoCheck.Click += new global::System.EventHandler(this.buttonBoCheck_Click);
			this.textBoxDongDC.Location = new global::System.Drawing.Point(180, 75);
			this.textBoxDongDC.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDongDC.Name = "textBoxDongDC";
			this.textBoxDongDC.Size = new global::System.Drawing.Size(38, 26);
			this.textBoxDongDC.TabIndex = 48;
			this.textBoxDongDC.TextChanged += new global::System.EventHandler(this.textBoxDongDC_TextChanged);
			this.textBoxDongNB.Location = new global::System.Drawing.Point(180, 40);
			this.textBoxDongNB.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDongNB.Name = "textBoxDongNB";
			this.textBoxDongNB.Size = new global::System.Drawing.Size(38, 26);
			this.textBoxDongNB.TabIndex = 47;
			this.textBoxDongNB.TextChanged += new global::System.EventHandler(this.textBoxDongNB_TextChanged);
			this.checkBoxNgocBoi.AutoSize = true;
			this.checkBoxNgocBoi.Location = new global::System.Drawing.Point(4, 40);
			this.checkBoxNgocBoi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxNgocBoi.Name = "checkBoxNgocBoi";
			this.checkBoxNgocBoi.Size = new global::System.Drawing.Size(150, 24);
			this.checkBoxNgocBoi.TabIndex = 46;
			this.checkBoxNgocBoi.Text = "Giữ ngọc bội, >=";
			this.checkBoxNgocBoi.UseVisualStyleBackColor = true;
			this.checkBoxNgocBoi.CheckedChanged += new global::System.EventHandler(this.checkBoxNgocBoi_CheckedChanged);
			this.textBoxDongNhan.Location = new global::System.Drawing.Point(180, 5);
			this.textBoxDongNhan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDongNhan.Name = "textBoxDongNhan";
			this.textBoxDongNhan.Size = new global::System.Drawing.Size(38, 26);
			this.textBoxDongNhan.TabIndex = 46;
			this.textBoxDongNhan.TextChanged += new global::System.EventHandler(this.textBoxDongNhan_TextChanged);
			this.checkBoxDaychuyen.AutoSize = true;
			this.checkBoxDaychuyen.Location = new global::System.Drawing.Point(6, 75);
			this.checkBoxDaychuyen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDaychuyen.Name = "checkBoxDaychuyen";
			this.checkBoxDaychuyen.Size = new global::System.Drawing.Size(170, 24);
			this.checkBoxDaychuyen.TabIndex = 45;
			this.checkBoxDaychuyen.Text = "Giữ dây chuyền, >=";
			this.checkBoxDaychuyen.UseVisualStyleBackColor = true;
			this.checkBoxDaychuyen.CheckedChanged += new global::System.EventHandler(this.checkBoxDaychuyen_CheckedChanged);
			this.checkBoxGiuTrangsuc.AutoSize = true;
			this.checkBoxGiuTrangsuc.Location = new global::System.Drawing.Point(4, 5);
			this.checkBoxGiuTrangsuc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxGiuTrangsuc.Name = "checkBoxGiuTrangsuc";
			this.checkBoxGiuTrangsuc.Size = new global::System.Drawing.Size(166, 24);
			this.checkBoxGiuTrangsuc.TabIndex = 44;
			this.checkBoxGiuTrangsuc.Text = "Giữ nhẫn, dòng >=";
			this.checkBoxGiuTrangsuc.UseVisualStyleBackColor = true;
			this.checkBoxGiuTrangsuc.CheckedChanged += new global::System.EventHandler(this.checkBoxGiuTrangsuc_CheckedChanged);
			this.checkBoxThoahet.AutoSize = true;
			this.checkBoxThoahet.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxThoahet.Location = new global::System.Drawing.Point(4, 148);
			this.checkBoxThoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxThoahet.Name = "checkBoxThoahet";
			this.checkBoxThoahet.Size = new global::System.Drawing.Size(389, 24);
			this.checkBoxThoahet.TabIndex = 43;
			this.checkBoxThoahet.Text = "Thỏa mãn đúng hết điều kiện thuộc tính thì mới giữ";
			this.checkBoxThoahet.UseVisualStyleBackColor = true;
			this.checkBoxThoahet.CheckedChanged += new global::System.EventHandler(this.checkBoxThoahet_CheckedChanged);
			this.tabPage2.Controls.Add(this.buttonXj);
			this.tabPage2.Controls.Add(this.buttonS);
			this.tabPage2.Controls.Add(this.buttonO);
			this.tabPage2.Controls.Add(this.buttonAppdungAll2);
			this.tabPage2.Controls.Add(this.listView2);
			this.tabPage2.Controls.Add(this.buttonThem);
			this.tabPage2.Controls.Add(this.comboBoxTenVatpham);
			this.tabPage2.Controls.Add(this.buttonXoa);
			this.tabPage2.Controls.Add(this.labelVidu);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(502, 598);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Vật phẩm không nhặt";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.buttonXj.Location = new global::System.Drawing.Point(408, 412);
			this.buttonXj.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXj.Name = "buttonXj";
			this.buttonXj.Size = new global::System.Drawing.Size(90, 32);
			this.buttonXj.TabIndex = 47;
			this.buttonXj.Text = "Xóa hết";
			this.buttonXj.UseVisualStyleBackColor = true;
			this.buttonXj.Click += new global::System.EventHandler(this.buttonXj_Click);
			this.buttonS.Location = new global::System.Drawing.Point(134, 531);
			this.buttonS.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonS.Name = "buttonS";
			this.buttonS.Size = new global::System.Drawing.Size(126, 55);
			this.buttonS.TabIndex = 46;
			this.buttonS.Text = "Save";
			this.buttonS.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonS.UseVisualStyleBackColor = true;
			this.buttonS.Click += new global::System.EventHandler(this.buttonS_Click);
			this.buttonO.Location = new global::System.Drawing.Point(4, 531);
			this.buttonO.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonO.Name = "buttonO";
			this.buttonO.Size = new global::System.Drawing.Size(126, 55);
			this.buttonO.TabIndex = 45;
			this.buttonO.Text = "Open";
			this.buttonO.TextImageRelation = global::System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonO.UseVisualStyleBackColor = true;
			this.buttonO.Click += new global::System.EventHandler(this.buttonO_Click);
			this.buttonAppdungAll2.ForeColor = global::System.Drawing.Color.Black;
			this.buttonAppdungAll2.Location = new global::System.Drawing.Point(286, 546);
			this.buttonAppdungAll2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAppdungAll2.Name = "buttonAppdungAll2";
			this.buttonAppdungAll2.Size = new global::System.Drawing.Size(210, 40);
			this.buttonAppdungAll2.TabIndex = 44;
			this.buttonAppdungAll2.Text = "Áp dụng cho tất cả ac";
			this.buttonAppdungAll2.UseVisualStyleBackColor = true;
			this.buttonAppdungAll2.Click += new global::System.EventHandler(this.buttonAppdungAll2_Click);
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_3,
				this.columnHeader_4
			});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(2, 2);
			this.listView2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(493, 399);
			this.listView2.TabIndex = 35;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.listView2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView2_MouseUp);
			this.columnHeader_3.Text = "No";
			this.columnHeader_3.Width = 45;
			this.columnHeader_4.Text = "Tên vật phẩm";
			this.columnHeader_4.Width = 260;
			this.buttonThem.Location = new global::System.Drawing.Point(262, 412);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(78, 32);
			this.buttonThem.TabIndex = 40;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.comboBoxTenVatpham.FormattingEnabled = true;
			this.comboBoxTenVatpham.Location = new global::System.Drawing.Point(4, 412);
			this.comboBoxTenVatpham.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenVatpham.Name = "comboBoxTenVatpham";
			this.comboBoxTenVatpham.Size = new global::System.Drawing.Size(253, 28);
			this.comboBoxTenVatpham.TabIndex = 36;
			this.comboBoxTenVatpham.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenVatpham_MouseDown);
			this.buttonXoa.Location = new global::System.Drawing.Point(345, 412);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(60, 32);
			this.buttonXoa.TabIndex = 41;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.labelVidu.AutoSize = true;
			this.labelVidu.Location = new global::System.Drawing.Point(6, 458);
			this.labelVidu.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelVidu.Name = "labelVidu";
			this.labelVidu.Size = new global::System.Drawing.Size(468, 60);
			this.labelVidu.TabIndex = 42;
			this.labelVidu.Text = "Tên vật phẩm không nhặt có thể ghi rút gọn.\r\nVí dụ ghi: Phúc Duyên\r\nThì sẽ không nhặt tất cả các loại Phúc Duyên (đại, trung và tiểu)...";
			this.tabPage3.Controls.Add(this.label1);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Size = new global::System.Drawing.Size(502, 598);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Lưu ý chung";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.label1.Location = new global::System.Drawing.Point(4, 5);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(489, 248);
			this.label1.TabIndex = 0;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.checkBoxNhatTrongthanh.AutoSize = true;
			this.checkBoxNhatTrongthanh.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxNhatTrongthanh.Location = new global::System.Drawing.Point(4, 5);
			this.checkBoxNhatTrongthanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxNhatTrongthanh.Name = "checkBoxNhatTrongthanh";
			this.checkBoxNhatTrongthanh.Size = new global::System.Drawing.Size(155, 24);
			this.checkBoxNhatTrongthanh.TabIndex = 45;
			this.checkBoxNhatTrongthanh.Text = "Nhặt trong thành";
			this.checkBoxNhatTrongthanh.UseVisualStyleBackColor = true;
			this.checkBoxNhatTrongthanh.CheckedChanged += new global::System.EventHandler(this.checkBoxNhatTrongthanh_CheckedChanged);
			this.comboBoxBando.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBando.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxBando.FormattingEnabled = true;
			this.comboBoxBando.Location = new global::System.Drawing.Point(300, 57);
			this.comboBoxBando.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxBando.Name = "comboBoxBando";
			this.comboBoxBando.Size = new global::System.Drawing.Size(208, 28);
			this.comboBoxBando.TabIndex = 46;
			this.comboBoxBando.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxBando_SelectedIndexChanged);
			this.checkBoxNhatTheoThuoctinh.AutoSize = true;
			this.checkBoxNhatTheoThuoctinh.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxNhatTheoThuoctinh.Location = new global::System.Drawing.Point(4, 75);
			this.checkBoxNhatTheoThuoctinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxNhatTheoThuoctinh.Name = "checkBoxNhatTheoThuoctinh";
			this.checkBoxNhatTheoThuoctinh.Size = new global::System.Drawing.Size(266, 24);
			this.checkBoxNhatTheoThuoctinh.TabIndex = 47;
			this.checkBoxNhatTheoThuoctinh.Text = "Nhặt theo bảng thuộc tính ở dưới";
			this.checkBoxNhatTheoThuoctinh.UseVisualStyleBackColor = true;
			this.checkBoxNhatTheoThuoctinh.CheckedChanged += new global::System.EventHandler(this.checkBoxNhatTheoThuoctinh_CheckedChanged);
			this.checkBoxKhongNhatdoTim.AutoSize = true;
			this.checkBoxKhongNhatdoTim.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxKhongNhatdoTim.Location = new global::System.Drawing.Point(4, 40);
			this.checkBoxKhongNhatdoTim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongNhatdoTim.Name = "checkBoxKhongNhatdoTim";
			this.checkBoxKhongNhatdoTim.Size = new global::System.Drawing.Size(164, 24);
			this.checkBoxKhongNhatdoTim.TabIndex = 48;
			this.checkBoxKhongNhatdoTim.Text = "Không nhặt đồ tím";
			this.checkBoxKhongNhatdoTim.UseVisualStyleBackColor = true;
			this.checkBoxKhongNhatdoTim.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongNhatdoTim_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label2.Location = new global::System.Drawing.Point(4, 752);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(128, 20);
			this.label2.TabIndex = 50;
			this.label2.Text = "Tốc độ nhặt (ms)";
			this.textBoxTocdoNhat.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxTocdoNhat.Location = new global::System.Drawing.Point(140, 748);
			this.textBoxTocdoNhat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTocdoNhat.Name = "textBoxTocdoNhat";
			this.textBoxTocdoNhat.Size = new global::System.Drawing.Size(48, 26);
			this.textBoxTocdoNhat.TabIndex = 47;
			this.textBoxTocdoNhat.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxTocdoNhat.TextChanged += new global::System.EventHandler(this.textBoxTocdoNhat_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(518, 786);
			base.Controls.Add(this.textBoxTocdoNhat);
			base.Controls.Add(this.checkBoxNhatTheoThuoctinh);
			base.Controls.Add(this.buttonApdungAll);
			base.Controls.Add(this.comboBoxBando);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBoxBando);
			base.Controls.Add(this.checkBoxKhongNhatdoTim);
			base.Controls.Add(this.checkBoxNhatTrongthanh);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.buttonClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormLocdo";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NHAT DO";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormLocdo_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000946 RID: 2374
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000947 RID: 2375
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000948 RID: 2376
		private global::System.Windows.Forms.CheckBox checkBoxBando;

		// Token: 0x04000949 RID: 2377
		private global::System.Windows.Forms.CheckBox checkBoxGiudoTheoCap;

		// Token: 0x0400094A RID: 2378
		private global::System.Windows.Forms.ComboBox comboBoxCap;

		// Token: 0x0400094B RID: 2379
		private global::System.Windows.Forms.CheckBox checkBoxGiudoTheoHe;

		// Token: 0x0400094C RID: 2380
		private global::System.Windows.Forms.ComboBox comboBoxHe;

		// Token: 0x0400094D RID: 2381
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400094E RID: 2382
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400094F RID: 2383
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000950 RID: 2384
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000951 RID: 2385
		private global::System.Windows.Forms.CheckBox checkBoxGiudoTheoThuoctinh;

		// Token: 0x04000952 RID: 2386
		private global::System.Windows.Forms.TextBox textBoxMin;

		// Token: 0x04000953 RID: 2387
		private global::System.Windows.Forms.Button buttonSua;

		// Token: 0x04000954 RID: 2388
		private global::System.Windows.Forms.TextBox textBoxName;

		// Token: 0x04000955 RID: 2389
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x04000956 RID: 2390
		private global::System.Windows.Forms.CheckBox checkBoxGiudoTim;

		// Token: 0x04000957 RID: 2391
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000958 RID: 2392
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000959 RID: 2393
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400095A RID: 2394
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x0400095B RID: 2395
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x0400095C RID: 2396
		private global::System.Windows.Forms.ComboBox comboBoxTenVatpham;

		// Token: 0x0400095D RID: 2397
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x0400095E RID: 2398
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x0400095F RID: 2399
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000960 RID: 2400
		private global::System.Windows.Forms.Label labelVidu;

		// Token: 0x04000961 RID: 2401
		private global::System.Windows.Forms.Button buttonAppdungAll2;

		// Token: 0x04000962 RID: 2402
		private global::System.Windows.Forms.CheckBox checkBoxNhatTrongthanh;

		// Token: 0x04000963 RID: 2403
		private global::System.Windows.Forms.ComboBox comboBoxBando;

		// Token: 0x04000964 RID: 2404
		private global::System.Windows.Forms.CheckBox checkBoxNhatTheoThuoctinh;

		// Token: 0x04000965 RID: 2405
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000966 RID: 2406
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000967 RID: 2407
		private global::System.Windows.Forms.CheckBox checkBoxKhongNhatdoTim;

		// Token: 0x04000968 RID: 2408
		private global::System.Windows.Forms.CheckBox checkBoxThoahet;

		// Token: 0x04000969 RID: 2409
		private global::System.Windows.Forms.CheckBox checkBoxGiuTrangsuc;

		// Token: 0x0400096A RID: 2410
		private global::System.Windows.Forms.CheckBox checkBoxNgocBoi;

		// Token: 0x0400096B RID: 2411
		private global::System.Windows.Forms.CheckBox checkBoxDaychuyen;

		// Token: 0x0400096C RID: 2412
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400096D RID: 2413
		private global::System.Windows.Forms.TextBox textBoxTocdoNhat;

		// Token: 0x0400096E RID: 2414
		private global::System.Windows.Forms.TextBox textBoxDongDC;

		// Token: 0x0400096F RID: 2415
		private global::System.Windows.Forms.TextBox textBoxDongNB;

		// Token: 0x04000970 RID: 2416
		private global::System.Windows.Forms.TextBox textBoxDongNhan;

		// Token: 0x04000971 RID: 2417
		private global::System.Windows.Forms.Button buttonBoCheck;

		// Token: 0x04000972 RID: 2418
		private global::System.Windows.Forms.Button buttonS;

		// Token: 0x04000973 RID: 2419
		private global::System.Windows.Forms.Button buttonO;

		// Token: 0x04000974 RID: 2420
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000975 RID: 2421
		private global::System.Windows.Forms.Button buttonXj;
	}
}
