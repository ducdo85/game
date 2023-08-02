namespace AutoKeoxe
{
	// Token: 0x02000075 RID: 117
	public partial class FormLogin : global::System.Windows.Forms.Form
	{
		// Token: 0x06000984 RID: 2436 RVA: 0x00159E54 File Offset: 0x00158054
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormLogin));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonXoaTK = new global::System.Windows.Forms.Button();
			this.buttonSuaTK = new global::System.Windows.Forms.Button();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBoxTaiKhoan = new global::System.Windows.Forms.TextBox();
			this.comboBoxNhanVat = new global::System.Windows.Forms.ComboBox();
			this.labelTaiKhoan = new global::System.Windows.Forms.Label();
			this.textBoxPassword = new global::System.Windows.Forms.TextBox();
			this.labelPassword = new global::System.Windows.Forms.Label();
			this.comboBoxServer = new global::System.Windows.Forms.ComboBox();
			this.comboBoxPhanda = new global::System.Windows.Forms.ComboBox();
			this.buttonLen = new global::System.Windows.Forms.Button();
			this.buttonXuong = new global::System.Windows.Forms.Button();
			this.textBoxStatus = new global::System.Windows.Forms.TextBox();
			this.buttonLuuDanhsach = new global::System.Windows.Forms.Button();
			this.labelThem = new global::System.Windows.Forms.Label();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.textBoxFile = new global::System.Windows.Forms.TextBox();
			this.buttonMoGame = new global::System.Windows.Forms.Button();
			this.buttonBrowseGameKhac = new global::System.Windows.Forms.Button();
			this.buttonThoatGame = new global::System.Windows.Forms.Button();
			this.checkBoxTuDangNhap = new global::System.Windows.Forms.CheckBox();
			this.buttonThoatGameAll = new global::System.Windows.Forms.Button();
			this.checkBoxThuNho = new global::System.Windows.Forms.CheckBox();
			this.checkBoxFileKhac = new global::System.Windows.Forms.CheckBox();
			this.buttonStopLogin = new global::System.Windows.Forms.Button();
			this.buttonLogin = new global::System.Windows.Forms.Button();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.buttonPhimHuongdan = new global::System.Windows.Forms.Button();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.label5 = new global::System.Windows.Forms.Label();
			this.textBoxCmd = new global::System.Windows.Forms.TextBox();
			this.buttonGameHu = new global::System.Windows.Forms.Button();
			this.checkBoxHanSudung = new global::System.Windows.Forms.CheckBox();
			this.checkBoxLog1ac = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxTimerDangNhap = new global::System.Windows.Forms.TextBox();
			this.textBoxTimeOpenGame = new global::System.Windows.Forms.TextBox();
			this.tabPageAutoVLBS = new global::System.Windows.Forms.TabPage();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.buttonOpenAuto = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelStatus = new global::System.Windows.Forms.Label();
			this.textBoxTimer = new global::System.Windows.Forms.TextBox();
			this.linkLabelCheckAll = new global::System.Windows.Forms.LinkLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPageAutoVLBS.SuspendLayout();
			base.SuspendLayout();
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(2, 66);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(448, 269);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
			this.listView1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 50;
			this.columnHeader_1.Text = "Nhân vật";
			this.columnHeader_1.Width = 120;
			this.columnHeader_2.Text = "ID";
			this.columnHeader_2.Width = 30;
			this.columnHeader_3.Text = "Số";
			this.columnHeader_3.Width = 25;
			this.columnHeader_4.Text = "Server";
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonXoaTK.Location = new global::System.Drawing.Point(460, 97);
			this.buttonXoaTK.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaTK.Name = "buttonXoaTK";
			this.buttonXoaTK.Size = new global::System.Drawing.Size(52, 40);
			this.buttonXoaTK.TabIndex = 171;
			this.buttonXoaTK.Text = "Xóa";
			this.buttonXoaTK.UseVisualStyleBackColor = true;
			this.buttonXoaTK.Click += new global::System.EventHandler(this.buttonXoaTK_Click);
			this.buttonSuaTK.Location = new global::System.Drawing.Point(226, 95);
			this.buttonSuaTK.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSuaTK.Name = "buttonSuaTK";
			this.buttonSuaTK.Size = new global::System.Drawing.Size(82, 35);
			this.buttonSuaTK.TabIndex = 170;
			this.buttonSuaTK.Text = "Sửa";
			this.buttonSuaTK.UseVisualStyleBackColor = true;
			this.buttonSuaTK.Click += new global::System.EventHandler(this.buttonSuaTK_Click);
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.SystemColors.Control;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label4.Location = new global::System.Drawing.Point(4, 106);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(72, 20);
			this.label4.TabIndex = 168;
			this.label4.Text = "Nhân vật";
			this.label4.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBoxTaiKhoan.Location = new global::System.Drawing.Point(92, 11);
			this.textBoxTaiKhoan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTaiKhoan.Name = "textBoxTaiKhoan";
			this.textBoxTaiKhoan.Size = new global::System.Drawing.Size(126, 26);
			this.textBoxTaiKhoan.TabIndex = 163;
			this.comboBoxNhanVat.BackColor = global::System.Drawing.SystemColors.Window;
			this.comboBoxNhanVat.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNhanVat.FormattingEnabled = true;
			this.comboBoxNhanVat.Location = new global::System.Drawing.Point(92, 98);
			this.comboBoxNhanVat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxNhanVat.Name = "comboBoxNhanVat";
			this.comboBoxNhanVat.Size = new global::System.Drawing.Size(50, 28);
			this.comboBoxNhanVat.TabIndex = 165;
			this.labelTaiKhoan.AutoSize = true;
			this.labelTaiKhoan.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelTaiKhoan.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelTaiKhoan.Location = new global::System.Drawing.Point(4, 17);
			this.labelTaiKhoan.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTaiKhoan.Name = "labelTaiKhoan";
			this.labelTaiKhoan.Size = new global::System.Drawing.Size(78, 20);
			this.labelTaiKhoan.TabIndex = 161;
			this.labelTaiKhoan.Text = "Tài khoản";
			this.labelTaiKhoan.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBoxPassword.Location = new global::System.Drawing.Point(92, 49);
			this.textBoxPassword.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new global::System.Drawing.Size(126, 26);
			this.textBoxPassword.TabIndex = 164;
			this.labelPassword.AutoSize = true;
			this.labelPassword.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelPassword.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.labelPassword.Location = new global::System.Drawing.Point(4, 52);
			this.labelPassword.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new global::System.Drawing.Size(78, 20);
			this.labelPassword.TabIndex = 162;
			this.labelPassword.Text = "Password";
			this.labelPassword.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.comboBoxServer.BackColor = global::System.Drawing.SystemColors.Control;
			this.comboBoxServer.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxServer.FormattingEnabled = true;
			this.comboBoxServer.Location = new global::System.Drawing.Point(226, 49);
			this.comboBoxServer.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxServer.Name = "comboBoxServer";
			this.comboBoxServer.Size = new global::System.Drawing.Size(163, 28);
			this.comboBoxServer.TabIndex = 167;
			this.comboBoxPhanda.BackColor = global::System.Drawing.SystemColors.Control;
			this.comboBoxPhanda.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPhanda.FormattingEnabled = true;
			this.comboBoxPhanda.Location = new global::System.Drawing.Point(226, 11);
			this.comboBoxPhanda.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxPhanda.Name = "comboBoxPhanda";
			this.comboBoxPhanda.Size = new global::System.Drawing.Size(163, 28);
			this.comboBoxPhanda.TabIndex = 166;
			this.comboBoxPhanda.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxPhanda_SelectedIndexChanged);
			this.buttonLen.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonLen.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLen.Image");
			this.buttonLen.Location = new global::System.Drawing.Point(460, 171);
			this.buttonLen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLen.Name = "buttonLen";
			this.buttonLen.Size = new global::System.Drawing.Size(52, 77);
			this.buttonLen.TabIndex = 172;
			this.buttonLen.UseVisualStyleBackColor = false;
			this.buttonLen.Click += new global::System.EventHandler(this.buttonLen_Click);
			this.buttonXuong.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXuong.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXuong.Image");
			this.buttonXuong.Location = new global::System.Drawing.Point(460, 257);
			this.buttonXuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXuong.Name = "buttonXuong";
			this.buttonXuong.Size = new global::System.Drawing.Size(52, 77);
			this.buttonXuong.TabIndex = 173;
			this.buttonXuong.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXuong.UseVisualStyleBackColor = false;
			this.buttonXuong.Click += new global::System.EventHandler(this.buttonXuong_Click);
			this.textBoxStatus.Location = new global::System.Drawing.Point(2, 2);
			this.textBoxStatus.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ReadOnly = true;
			this.textBoxStatus.Size = new global::System.Drawing.Size(349, 26);
			this.textBoxStatus.TabIndex = 174;
			this.buttonLuuDanhsach.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonLuuDanhsach.Location = new global::System.Drawing.Point(396, 11);
			this.buttonLuuDanhsach.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLuuDanhsach.Name = "buttonLuuDanhsach";
			this.buttonLuuDanhsach.Size = new global::System.Drawing.Size(110, 57);
			this.buttonLuuDanhsach.TabIndex = 175;
			this.buttonLuuDanhsach.Text = "Lưu danh sách";
			this.buttonLuuDanhsach.UseVisualStyleBackColor = true;
			this.buttonLuuDanhsach.Click += new global::System.EventHandler(this.buttonLuuDanhsach_Click);
			this.labelThem.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.labelThem.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelThem.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelThem.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.labelThem.Location = new global::System.Drawing.Point(148, 98);
			this.labelThem.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelThem.Name = "labelThem";
			this.labelThem.Size = new global::System.Drawing.Size(66, 31);
			this.labelThem.TabIndex = 176;
			this.labelThem.Text = "Thêm";
			this.labelThem.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.labelThem.Click += new global::System.EventHandler(this.labelThem_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPageAutoVLBS);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 340);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(520, 177);
			this.tabControl1.TabIndex = 180;
			this.tabPage1.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.textBoxFile);
			this.tabPage1.Controls.Add(this.buttonMoGame);
			this.tabPage1.Controls.Add(this.buttonBrowseGameKhac);
			this.tabPage1.Controls.Add(this.buttonThoatGame);
			this.tabPage1.Controls.Add(this.checkBoxTuDangNhap);
			this.tabPage1.Controls.Add(this.buttonThoatGameAll);
			this.tabPage1.Controls.Add(this.checkBoxThuNho);
			this.tabPage1.Controls.Add(this.checkBoxFileKhac);
			this.tabPage1.Controls.Add(this.buttonStopLogin);
			this.tabPage1.Controls.Add(this.buttonLogin);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(512, 144);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Quản lý";
			this.textBoxFile.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.textBoxFile.Location = new global::System.Drawing.Point(210, 38);
			this.textBoxFile.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxFile.Name = "textBoxFile";
			this.textBoxFile.ReadOnly = true;
			this.textBoxFile.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
			this.textBoxFile.Size = new global::System.Drawing.Size(295, 26);
			this.textBoxFile.TabIndex = 395;
			this.buttonMoGame.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.buttonMoGame.Location = new global::System.Drawing.Point(210, 77);
			this.buttonMoGame.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonMoGame.Name = "buttonMoGame";
			this.buttonMoGame.Size = new global::System.Drawing.Size(90, 55);
			this.buttonMoGame.TabIndex = 389;
			this.buttonMoGame.Text = "Mở game";
			this.buttonMoGame.UseVisualStyleBackColor = false;
			this.buttonMoGame.Click += new global::System.EventHandler(this.buttonMoGame_Click);
			this.buttonBrowseGameKhac.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonBrowseGameKhac.Location = new global::System.Drawing.Point(462, 3);
			this.buttonBrowseGameKhac.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBrowseGameKhac.Name = "buttonBrowseGameKhac";
			this.buttonBrowseGameKhac.Size = new global::System.Drawing.Size(45, 32);
			this.buttonBrowseGameKhac.TabIndex = 396;
			this.buttonBrowseGameKhac.Text = "***";
			this.buttonBrowseGameKhac.UseVisualStyleBackColor = true;
			this.buttonBrowseGameKhac.Click += new global::System.EventHandler(this.buttonBrowseGameKhac_Click);
			this.buttonThoatGame.ForeColor = global::System.Drawing.Color.Black;
			this.buttonThoatGame.Location = new global::System.Drawing.Point(306, 77);
			this.buttonThoatGame.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThoatGame.Name = "buttonThoatGame";
			this.buttonThoatGame.Size = new global::System.Drawing.Size(94, 55);
			this.buttonThoatGame.TabIndex = 344;
			this.buttonThoatGame.Text = "Thoát game";
			this.buttonThoatGame.UseVisualStyleBackColor = true;
			this.buttonThoatGame.Click += new global::System.EventHandler(this.buttonThoatGame_Click);
			this.checkBoxTuDangNhap.AutoSize = true;
			this.checkBoxTuDangNhap.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTuDangNhap.Location = new global::System.Drawing.Point(4, 5);
			this.checkBoxTuDangNhap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTuDangNhap.Name = "checkBoxTuDangNhap";
			this.checkBoxTuDangNhap.Size = new global::System.Drawing.Size(155, 24);
			this.checkBoxTuDangNhap.TabIndex = 388;
			this.checkBoxTuDangNhap.Text = "Tự log ac khi diss";
			this.checkBoxTuDangNhap.UseVisualStyleBackColor = true;
			this.checkBoxTuDangNhap.CheckedChanged += new global::System.EventHandler(this.checkBoxTuDangNhap_CheckedChanged);
			this.buttonThoatGameAll.Location = new global::System.Drawing.Point(402, 77);
			this.buttonThoatGameAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThoatGameAll.Name = "buttonThoatGameAll";
			this.buttonThoatGameAll.Size = new global::System.Drawing.Size(105, 55);
			this.buttonThoatGameAll.TabIndex = 177;
			this.buttonThoatGameAll.Text = "Thoát hết game";
			this.buttonThoatGameAll.UseVisualStyleBackColor = true;
			this.buttonThoatGameAll.Click += new global::System.EventHandler(this.buttonThoatGameAll_Click);
			this.checkBoxThuNho.AutoSize = true;
			this.checkBoxThuNho.Location = new global::System.Drawing.Point(3, 40);
			this.checkBoxThuNho.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxThuNho.Name = "checkBoxThuNho";
			this.checkBoxThuNho.Size = new global::System.Drawing.Size(163, 24);
			this.checkBoxThuNho.TabIndex = 184;
			this.checkBoxThuNho.Text = "Thu nhỏ khi log ac";
			this.checkBoxThuNho.UseVisualStyleBackColor = true;
			this.checkBoxThuNho.CheckedChanged += new global::System.EventHandler(this.checkBoxThuNho_CheckedChanged);
			this.checkBoxFileKhac.AutoSize = true;
			this.checkBoxFileKhac.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxFileKhac.Location = new global::System.Drawing.Point(210, 5);
			this.checkBoxFileKhac.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxFileKhac.Name = "checkBoxFileKhac";
			this.checkBoxFileKhac.Size = new global::System.Drawing.Size(239, 24);
			this.checkBoxFileKhac.TabIndex = 393;
			this.checkBoxFileKhac.Text = "Mở game thông qua file khác";
			this.checkBoxFileKhac.UseVisualStyleBackColor = true;
			this.checkBoxFileKhac.CheckedChanged += new global::System.EventHandler(this.checkBoxFileKhac_CheckedChanged);
			this.buttonStopLogin.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonStopLogin.Location = new global::System.Drawing.Point(110, 77);
			this.buttonStopLogin.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStopLogin.Name = "buttonStopLogin";
			this.buttonStopLogin.Size = new global::System.Drawing.Size(90, 55);
			this.buttonStopLogin.TabIndex = 390;
			this.buttonStopLogin.Text = "Dừng lại";
			this.buttonStopLogin.UseVisualStyleBackColor = false;
			this.buttonStopLogin.Click += new global::System.EventHandler(this.buttonStopLogin_Click);
			this.buttonLogin.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.buttonLogin.Location = new global::System.Drawing.Point(4, 77);
			this.buttonLogin.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new global::System.Drawing.Size(100, 55);
			this.buttonLogin.TabIndex = 185;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new global::System.EventHandler(this.buttonLogin_Click);
			this.tabPage3.Controls.Add(this.comboBoxPhanda);
			this.tabPage3.Controls.Add(this.buttonLuuDanhsach);
			this.tabPage3.Controls.Add(this.comboBoxNhanVat);
			this.tabPage3.Controls.Add(this.labelPassword);
			this.tabPage3.Controls.Add(this.comboBoxServer);
			this.tabPage3.Controls.Add(this.textBoxTaiKhoan);
			this.tabPage3.Controls.Add(this.buttonSuaTK);
			this.tabPage3.Controls.Add(this.labelThem);
			this.tabPage3.Controls.Add(this.buttonPhimHuongdan);
			this.tabPage3.Controls.Add(this.labelTaiKhoan);
			this.tabPage3.Controls.Add(this.textBoxPassword);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage3.Size = new global::System.Drawing.Size(512, 144);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Nhập tài khoản";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.buttonPhimHuongdan.ForeColor = global::System.Drawing.Color.Blue;
			this.buttonPhimHuongdan.Location = new global::System.Drawing.Point(396, 75);
			this.buttonPhimHuongdan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPhimHuongdan.Name = "buttonPhimHuongdan";
			this.buttonPhimHuongdan.Size = new global::System.Drawing.Size(110, 55);
			this.buttonPhimHuongdan.TabIndex = 182;
			this.buttonPhimHuongdan.Text = "Phim hướng dẫn login";
			this.buttonPhimHuongdan.UseVisualStyleBackColor = true;
			this.buttonPhimHuongdan.Click += new global::System.EventHandler(this.buttonPhimHuongdan_Click);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.textBoxCmd);
			this.tabPage2.Controls.Add(this.buttonGameHu);
			this.tabPage2.Controls.Add(this.checkBoxHanSudung);
			this.tabPage2.Controls.Add(this.checkBoxLog1ac);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.textBoxTimerDangNhap);
			this.tabPage2.Controls.Add(this.textBoxTimeOpenGame);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(512, 144);
			this.tabPage2.TabIndex = 4;
			this.tabPage2.Text = "Khác";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(315, 5);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(120, 20);
			this.label5.TabIndex = 398;
			this.label5.Text = "Command Line:";
			this.textBoxCmd.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.textBoxCmd.Location = new global::System.Drawing.Point(321, 34);
			this.textBoxCmd.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxCmd.Name = "textBoxCmd";
			this.textBoxCmd.ReadOnly = true;
			this.textBoxCmd.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.textBoxCmd.Size = new global::System.Drawing.Size(184, 26);
			this.textBoxCmd.TabIndex = 397;
			this.buttonGameHu.Location = new global::System.Drawing.Point(334, 75);
			this.buttonGameHu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonGameHu.Name = "buttonGameHu";
			this.buttonGameHu.Size = new global::System.Drawing.Size(174, 57);
			this.buttonGameHu.TabIndex = 178;
			this.buttonGameHu.Text = "Thoát hết game hư còn chạy ngầm";
			this.buttonGameHu.UseVisualStyleBackColor = true;
			this.buttonGameHu.Click += new global::System.EventHandler(this.buttonGameHu_Click);
			this.checkBoxHanSudung.AutoSize = true;
			this.checkBoxHanSudung.Location = new global::System.Drawing.Point(4, 106);
			this.checkBoxHanSudung.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxHanSudung.Name = "checkBoxHanSudung";
			this.checkBoxHanSudung.Size = new global::System.Drawing.Size(319, 24);
			this.checkBoxHanSudung.TabIndex = 391;
			this.checkBoxHanSudung.Text = "Đăng nhập game không có hạn sử dụng";
			this.checkBoxHanSudung.UseVisualStyleBackColor = true;
			this.checkBoxHanSudung.CheckedChanged += new global::System.EventHandler(this.checkBoxHanSudung_CheckedChanged);
			this.checkBoxLog1ac.AutoSize = true;
			this.checkBoxLog1ac.Location = new global::System.Drawing.Point(4, 72);
			this.checkBoxLog1ac.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLog1ac.Name = "checkBoxLog1ac";
			this.checkBoxLog1ac.Size = new global::System.Drawing.Size(166, 24);
			this.checkBoxLog1ac.TabIndex = 390;
			this.checkBoxLog1ac.Text = "Fix User32 log 1ac";
			this.checkBoxLog1ac.UseVisualStyleBackColor = true;
			this.checkBoxLog1ac.CheckedChanged += new global::System.EventHandler(this.checkBoxLog1ac_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.SystemColors.Control;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label2.Location = new global::System.Drawing.Point(2, 40);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(218, 20);
			this.label2.TabIndex = 166;
			this.label2.Text = "Thời gian chờ đăng nhập (ms)";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.SystemColors.Control;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.label1.Location = new global::System.Drawing.Point(2, 8);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(208, 20);
			this.label1.TabIndex = 164;
			this.label1.Text = "Thời gian chờ mở game (ms)";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBoxTimerDangNhap.Location = new global::System.Drawing.Point(230, 35);
			this.textBoxTimerDangNhap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTimerDangNhap.Name = "textBoxTimerDangNhap";
			this.textBoxTimerDangNhap.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxTimerDangNhap.TabIndex = 167;
			this.textBoxTimerDangNhap.TextChanged += new global::System.EventHandler(this.textBoxTimerDangNhap_TextChanged);
			this.textBoxTimeOpenGame.Location = new global::System.Drawing.Point(230, 2);
			this.textBoxTimeOpenGame.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTimeOpenGame.Name = "textBoxTimeOpenGame";
			this.textBoxTimeOpenGame.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxTimeOpenGame.TabIndex = 165;
			this.textBoxTimeOpenGame.TextChanged += new global::System.EventHandler(this.textBoxTimeOpenGame_TextChanged);
			this.tabPageAutoVLBS.Controls.Add(this.linkLabel1);
			this.tabPageAutoVLBS.Controls.Add(this.richTextBox1);
			this.tabPageAutoVLBS.Controls.Add(this.buttonOpenAuto);
			this.tabPageAutoVLBS.Controls.Add(this.textBox1);
			this.tabPageAutoVLBS.Controls.Add(this.label3);
			this.tabPageAutoVLBS.Location = new global::System.Drawing.Point(4, 29);
			this.tabPageAutoVLBS.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAutoVLBS.Name = "tabPageAutoVLBS";
			this.tabPageAutoVLBS.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageAutoVLBS.Size = new global::System.Drawing.Size(512, 144);
			this.tabPageAutoVLBS.TabIndex = 5;
			this.tabPageAutoVLBS.Text = "Test";
			this.tabPageAutoVLBS.UseVisualStyleBackColor = true;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new global::System.Drawing.Point(450, 108);
			this.linkLabel1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(52, 20);
			this.linkLabel1.TabIndex = 183;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = " ..dán ";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.richTextBox1.Location = new global::System.Drawing.Point(3, 0);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(502, 89);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			this.buttonOpenAuto.Location = new global::System.Drawing.Point(3, 100);
			this.buttonOpenAuto.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOpenAuto.Name = "buttonOpenAuto";
			this.buttonOpenAuto.Size = new global::System.Drawing.Size(120, 35);
			this.buttonOpenAuto.TabIndex = 2;
			this.buttonOpenAuto.Text = "Mở auto";
			this.buttonOpenAuto.UseVisualStyleBackColor = true;
			this.buttonOpenAuto.Click += new global::System.EventHandler(this.buttonOpenAuto_Click);
			this.textBox1.Location = new global::System.Drawing.Point(232, 103);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(211, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(158, 108);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(64, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mã máy";
			this.labelStatus.AutoSize = true;
			this.labelStatus.ForeColor = global::System.Drawing.Color.DarkRed;
			this.labelStatus.Location = new global::System.Drawing.Point(254, 37);
			this.labelStatus.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new global::System.Drawing.Size(228, 20);
			this.labelStatus.TabIndex = 178;
			this.labelStatus.Text = "Click chuột phải để login nhanh";
			this.textBoxTimer.Location = new global::System.Drawing.Point(358, 2);
			this.textBoxTimer.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTimer.Name = "textBoxTimer";
			this.textBoxTimer.ReadOnly = true;
			this.textBoxTimer.Size = new global::System.Drawing.Size(152, 26);
			this.textBoxTimer.TabIndex = 181;
			this.linkLabelCheckAll.AutoSize = true;
			this.linkLabelCheckAll.Location = new global::System.Drawing.Point(4, 37);
			this.linkLabelCheckAll.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelCheckAll.Name = "linkLabelCheckAll";
			this.linkLabelCheckAll.Size = new global::System.Drawing.Size(204, 20);
			this.linkLabelCheckAll.TabIndex = 182;
			this.linkLabelCheckAll.TabStop = true;
			this.linkLabelCheckAll.Text = "Check hoặc Uncheck tất cả";
			this.linkLabelCheckAll.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCheckAll_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(516, 515);
			base.Controls.Add(this.buttonXuong);
			base.Controls.Add(this.linkLabelCheckAll);
			base.Controls.Add(this.buttonLen);
			base.Controls.Add(this.textBoxTimer);
			base.Controls.Add(this.labelStatus);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.textBoxStatus);
			base.Controls.Add(this.buttonXoaTK);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormLogin";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "LOGIN";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormLogin_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPageAutoVLBS.ResumeLayout(false);
			this.tabPageAutoVLBS.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040009D7 RID: 2519
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040009D8 RID: 2520
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040009D9 RID: 2521
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040009DA RID: 2522
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x040009DB RID: 2523
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x040009DC RID: 2524
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x040009DD RID: 2525
		private global::System.Windows.Forms.Button buttonXoaTK;

		// Token: 0x040009DE RID: 2526
		private global::System.Windows.Forms.Button buttonSuaTK;

		// Token: 0x040009DF RID: 2527
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040009E0 RID: 2528
		private global::System.Windows.Forms.TextBox textBoxTaiKhoan;

		// Token: 0x040009E1 RID: 2529
		private global::System.Windows.Forms.ComboBox comboBoxNhanVat;

		// Token: 0x040009E2 RID: 2530
		private global::System.Windows.Forms.Label labelTaiKhoan;

		// Token: 0x040009E3 RID: 2531
		private global::System.Windows.Forms.TextBox textBoxPassword;

		// Token: 0x040009E4 RID: 2532
		private global::System.Windows.Forms.Label labelPassword;

		// Token: 0x040009E5 RID: 2533
		private global::System.Windows.Forms.ComboBox comboBoxServer;

		// Token: 0x040009E6 RID: 2534
		private global::System.Windows.Forms.ComboBox comboBoxPhanda;

		// Token: 0x040009E7 RID: 2535
		private global::System.Windows.Forms.Button buttonLen;

		// Token: 0x040009E8 RID: 2536
		private global::System.Windows.Forms.Button buttonXuong;

		// Token: 0x040009E9 RID: 2537
		private global::System.Windows.Forms.TextBox textBoxStatus;

		// Token: 0x040009EA RID: 2538
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x040009EB RID: 2539
		private global::System.Windows.Forms.Button buttonLuuDanhsach;

		// Token: 0x040009EC RID: 2540
		private global::System.Windows.Forms.Label labelThem;

		// Token: 0x040009ED RID: 2541
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x040009EE RID: 2542
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040009EF RID: 2543
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009F0 RID: 2544
		private global::System.Windows.Forms.TextBox textBoxTimeOpenGame;

		// Token: 0x040009F1 RID: 2545
		private global::System.Windows.Forms.TextBox textBoxTimerDangNhap;

		// Token: 0x040009F2 RID: 2546
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040009F3 RID: 2547
		private global::System.Windows.Forms.Button buttonThoatGameAll;

		// Token: 0x040009F4 RID: 2548
		private global::System.Windows.Forms.Button buttonPhimHuongdan;

		// Token: 0x040009F5 RID: 2549
		private global::System.Windows.Forms.Label labelStatus;

		// Token: 0x040009F6 RID: 2550
		private global::System.Windows.Forms.CheckBox checkBoxThuNho;

		// Token: 0x040009F7 RID: 2551
		private global::System.Windows.Forms.Button buttonLogin;

		// Token: 0x040009F8 RID: 2552
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040009F9 RID: 2553
		private global::System.Windows.Forms.CheckBox checkBoxTuDangNhap;

		// Token: 0x040009FA RID: 2554
		private global::System.Windows.Forms.Button buttonMoGame;

		// Token: 0x040009FB RID: 2555
		private global::System.Windows.Forms.TextBox textBoxTimer;

		// Token: 0x040009FC RID: 2556
		private global::System.Windows.Forms.Button buttonStopLogin;

		// Token: 0x040009FD RID: 2557
		private global::System.Windows.Forms.LinkLabel linkLabelCheckAll;

		// Token: 0x040009FE RID: 2558
		private global::System.Windows.Forms.Button buttonGameHu;

		// Token: 0x040009FF RID: 2559
		private global::System.Windows.Forms.CheckBox checkBoxLog1ac;

		// Token: 0x04000A00 RID: 2560
		private global::System.Windows.Forms.CheckBox checkBoxFileKhac;

		// Token: 0x04000A01 RID: 2561
		private global::System.Windows.Forms.Button buttonBrowseGameKhac;

		// Token: 0x04000A02 RID: 2562
		private global::System.Windows.Forms.TextBox textBoxFile;

		// Token: 0x04000A03 RID: 2563
		private global::System.Windows.Forms.Button buttonThoatGame;

		// Token: 0x04000A04 RID: 2564
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000A05 RID: 2565
		private global::System.Windows.Forms.CheckBox checkBoxHanSudung;

		// Token: 0x04000A06 RID: 2566
		private global::System.Windows.Forms.TabPage tabPageAutoVLBS;

		// Token: 0x04000A07 RID: 2567
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000A08 RID: 2568
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000A09 RID: 2569
		private global::System.Windows.Forms.Button buttonOpenAuto;

		// Token: 0x04000A0A RID: 2570
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000A0B RID: 2571
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000A0C RID: 2572
		private global::System.Windows.Forms.TextBox textBoxCmd;

		// Token: 0x04000A0D RID: 2573
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A0E RID: 2574
		private global::System.Windows.Forms.Label label5;
	}
}
