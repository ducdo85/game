namespace AutoKeoxe
{
	// Token: 0x0200006C RID: 108
	public partial class FormDame : global::System.Windows.Forms.Form
	{
		// Token: 0x06000861 RID: 2145 RVA: 0x0013F73C File Offset: 0x0013D93C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormDame));
			this.checkBoxSkill1 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxSkill2 = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.comboBoxKieudanh = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxTuDanhbinhthuong = new global::System.Windows.Forms.CheckBox();
			this.comboBoxSkill1 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxSkill2 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxTenAc = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.checkBoxAllwayAttack = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPageChieu12 = new global::System.Windows.Forms.TabPage();
			this.tabPageSendKey = new global::System.Windows.Forms.TabPage();
			this.textBoxDeLay = new global::System.Windows.Forms.TextBox();
			this.comboBoxF_3 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxF_2 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxF_1 = new global::System.Windows.Forms.ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBoxF_3 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxF_2 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxF_1 = new global::System.Windows.Forms.CheckBox();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.buttonNotCheckAll = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxKieuXuatchieu = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.labelTocdo = new global::System.Windows.Forms.Label();
			this.textBoxTocdo = new global::System.Windows.Forms.TextBox();
			this.checkBoxCtrlShift = new global::System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPageChieu12.SuspendLayout();
			this.tabPageSendKey.SuspendLayout();
			this.tabPage1.SuspendLayout();
			base.SuspendLayout();
			this.checkBoxSkill1.AutoSize = true;
			this.checkBoxSkill1.Location = new global::System.Drawing.Point(9, 25);
			this.checkBoxSkill1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxSkill1.Name = "checkBoxSkill1";
			this.checkBoxSkill1.Size = new global::System.Drawing.Size(89, 24);
			this.checkBoxSkill1.TabIndex = 0;
			this.checkBoxSkill1.Text = "Chiêu 1";
			this.checkBoxSkill1.UseVisualStyleBackColor = true;
			this.checkBoxSkill1.CheckedChanged += new global::System.EventHandler(this.checkBoxSkill1_CheckedChanged);
			this.checkBoxSkill2.AutoSize = true;
			this.checkBoxSkill2.Location = new global::System.Drawing.Point(9, 60);
			this.checkBoxSkill2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxSkill2.Name = "checkBoxSkill2";
			this.checkBoxSkill2.Size = new global::System.Drawing.Size(89, 24);
			this.checkBoxSkill2.TabIndex = 1;
			this.checkBoxSkill2.Text = "Chiêu 2";
			this.checkBoxSkill2.UseVisualStyleBackColor = true;
			this.checkBoxSkill2.CheckedChanged += new global::System.EventHandler(this.checkBoxSkill2_CheckedChanged);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.comboBoxKieudanh.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKieudanh.DropDownWidth = 280;
			this.comboBoxKieudanh.FormattingEnabled = true;
			this.comboBoxKieudanh.Location = new global::System.Drawing.Point(141, 2);
			this.comboBoxKieudanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxKieudanh.Name = "comboBoxKieudanh";
			this.comboBoxKieudanh.Size = new global::System.Drawing.Size(445, 28);
			this.comboBoxKieudanh.TabIndex = 325;
			this.comboBoxKieudanh.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxKieudanh_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(4, 45);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(84, 20);
			this.label1.TabIndex = 326;
			this.label1.Text = "Phím đánh";
			this.buttonClose.Location = new global::System.Drawing.Point(465, 514);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(108, 40);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "OK";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxTuDanhbinhthuong.AutoSize = true;
			this.checkBoxTuDanhbinhthuong.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.checkBoxTuDanhbinhthuong.Location = new global::System.Drawing.Point(9, 80);
			this.checkBoxTuDanhbinhthuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTuDanhbinhthuong.Name = "checkBoxTuDanhbinhthuong";
			this.checkBoxTuDanhbinhthuong.Size = new global::System.Drawing.Size(460, 24);
			this.checkBoxTuDanhbinhthuong.TabIndex = 329;
			this.checkBoxTuDanhbinhthuong.Text = "Tự động chuyển sang đánh bình thường khi không bấm phím";
			this.checkBoxTuDanhbinhthuong.UseVisualStyleBackColor = true;
			this.checkBoxTuDanhbinhthuong.CheckedChanged += new global::System.EventHandler(this.checkBoxTuDanhbinhthuong_CheckedChanged);
			this.comboBoxSkill1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSkill1.DropDownWidth = 200;
			this.comboBoxSkill1.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxSkill1.FormattingEnabled = true;
			this.comboBoxSkill1.Location = new global::System.Drawing.Point(111, 20);
			this.comboBoxSkill1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxSkill1.Name = "comboBoxSkill1";
			this.comboBoxSkill1.Size = new global::System.Drawing.Size(242, 28);
			this.comboBoxSkill1.TabIndex = 350;
			this.comboBoxSkill1.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxSkill1_SelectedIndexChanged);
			this.comboBoxSkill2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSkill2.DropDownWidth = 200;
			this.comboBoxSkill2.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxSkill2.FormattingEnabled = true;
			this.comboBoxSkill2.Location = new global::System.Drawing.Point(111, 57);
			this.comboBoxSkill2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxSkill2.Name = "comboBoxSkill2";
			this.comboBoxSkill2.Size = new global::System.Drawing.Size(242, 28);
			this.comboBoxSkill2.TabIndex = 351;
			this.comboBoxSkill2.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxSkill2_SelectedIndexChanged);
			this.comboBoxTenAc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTenAc.DropDownWidth = 120;
			this.comboBoxTenAc.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxTenAc.FormattingEnabled = true;
			this.comboBoxTenAc.Location = new global::System.Drawing.Point(141, 300);
			this.comboBoxTenAc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenAc.Name = "comboBoxTenAc";
			this.comboBoxTenAc.Size = new global::System.Drawing.Size(148, 28);
			this.comboBoxTenAc.TabIndex = 353;
			this.comboBoxTenAc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxTenAc_SelectedIndexChanged);
			this.label3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(141, 40);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(99, 28);
			this.label3.TabIndex = 356;
			this.label3.Text = "SPACE";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxAllwayAttack.AutoSize = true;
			this.checkBoxAllwayAttack.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxAllwayAttack.Location = new global::System.Drawing.Point(9, 115);
			this.checkBoxAllwayAttack.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxAllwayAttack.Name = "checkBoxAllwayAttack";
			this.checkBoxAllwayAttack.Size = new global::System.Drawing.Size(403, 24);
			this.checkBoxAllwayAttack.TabIndex = 357;
			this.checkBoxAllwayAttack.Text = "Không đánh người, đánh quái nhưng vẫn dame được";
			this.checkBoxAllwayAttack.UseVisualStyleBackColor = true;
			this.checkBoxAllwayAttack.CheckedChanged += new global::System.EventHandler(this.checkBoxAllwayAttack_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(4, 8);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(92, 20);
			this.label2.TabIndex = 358;
			this.label2.Text = "Kiểu đánh";
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 160);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(584, 129);
			this.richTextBox1.TabIndex = 359;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.tabControl1.Controls.Add(this.tabPageChieu12);
			this.tabControl1.Controls.Add(this.tabPageSendKey);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new global::System.Drawing.Point(8, 342);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(580, 163);
			this.tabControl1.TabIndex = 354;
			this.tabPageChieu12.Controls.Add(this.comboBoxSkill1);
			this.tabPageChieu12.Controls.Add(this.comboBoxSkill2);
			this.tabPageChieu12.Controls.Add(this.checkBoxSkill2);
			this.tabPageChieu12.Controls.Add(this.checkBoxSkill1);
			this.tabPageChieu12.Location = new global::System.Drawing.Point(4, 29);
			this.tabPageChieu12.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageChieu12.Name = "tabPageChieu12";
			this.tabPageChieu12.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageChieu12.Size = new global::System.Drawing.Size(572, 130);
			this.tabPageChieu12.TabIndex = 0;
			this.tabPageChieu12.Text = "Đánh chiêu 1 2 dưới";
			this.tabPageChieu12.UseVisualStyleBackColor = true;
			this.tabPageSendKey.Controls.Add(this.textBoxDeLay);
			this.tabPageSendKey.Controls.Add(this.comboBoxF_3);
			this.tabPageSendKey.Controls.Add(this.comboBoxF_2);
			this.tabPageSendKey.Controls.Add(this.comboBoxF_1);
			this.tabPageSendKey.Controls.Add(this.label4);
			this.tabPageSendKey.Controls.Add(this.checkBoxF_3);
			this.tabPageSendKey.Controls.Add(this.checkBoxF_2);
			this.tabPageSendKey.Controls.Add(this.checkBoxF_1);
			this.tabPageSendKey.Location = new global::System.Drawing.Point(4, 29);
			this.tabPageSendKey.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageSendKey.Name = "tabPageSendKey";
			this.tabPageSendKey.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageSendKey.Size = new global::System.Drawing.Size(572, 130);
			this.tabPageSendKey.TabIndex = 1;
			this.tabPageSendKey.Text = "Đánh ra liên tiếp chiêu ở phím tắt";
			this.tabPageSendKey.UseVisualStyleBackColor = true;
			this.textBoxDeLay.ForeColor = global::System.Drawing.Color.DarkRed;
			this.textBoxDeLay.Location = new global::System.Drawing.Point(384, 83);
			this.textBoxDeLay.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDeLay.Name = "textBoxDeLay";
			this.textBoxDeLay.Size = new global::System.Drawing.Size(86, 26);
			this.textBoxDeLay.TabIndex = 366;
			this.textBoxDeLay.TextChanged += new global::System.EventHandler(this.textBoxDeLay_TextChanged);
			this.comboBoxF_3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxF_3.FormattingEnabled = true;
			this.comboBoxF_3.Location = new global::System.Drawing.Point(84, 86);
			this.comboBoxF_3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxF_3.Name = "comboBoxF_3";
			this.comboBoxF_3.Size = new global::System.Drawing.Size(66, 28);
			this.comboBoxF_3.TabIndex = 364;
			this.comboBoxF_3.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxF_3_SelectedIndexChanged);
			this.comboBoxF_2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxF_2.FormattingEnabled = true;
			this.comboBoxF_2.Location = new global::System.Drawing.Point(84, 45);
			this.comboBoxF_2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxF_2.Name = "comboBoxF_2";
			this.comboBoxF_2.Size = new global::System.Drawing.Size(66, 28);
			this.comboBoxF_2.TabIndex = 362;
			this.comboBoxF_2.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxF_2_SelectedIndexChanged);
			this.comboBoxF_1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxF_1.FormattingEnabled = true;
			this.comboBoxF_1.Location = new global::System.Drawing.Point(84, 3);
			this.comboBoxF_1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxF_1.Name = "comboBoxF_1";
			this.comboBoxF_1.Size = new global::System.Drawing.Size(66, 28);
			this.comboBoxF_1.TabIndex = 360;
			this.comboBoxF_1.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxF_1_SelectedIndexChanged);
			this.label4.ForeColor = global::System.Drawing.Color.Black;
			this.label4.Location = new global::System.Drawing.Point(159, 8);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(354, 111);
			this.label4.TabIndex = 360;
			this.label4.Text = "Thời gian giữa 2 lần send liên tiếp (mili giây). Canh chỉnh sao cho phù hợp tốc độ xuất chiêu, nhanh quá thì nó chỉ đánh được 1 chiêu, chậm quá thì lãng phí.";
			this.checkBoxF_3.AutoSize = true;
			this.checkBoxF_3.Location = new global::System.Drawing.Point(4, 89);
			this.checkBoxF_3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxF_3.Name = "checkBoxF_3";
			this.checkBoxF_3.Size = new global::System.Drawing.Size(73, 24);
			this.checkBoxF_3.TabIndex = 365;
			this.checkBoxF_3.Text = "Send";
			this.checkBoxF_3.UseVisualStyleBackColor = true;
			this.checkBoxF_3.CheckedChanged += new global::System.EventHandler(this.checkBoxF_3_CheckedChanged);
			this.checkBoxF_2.AutoSize = true;
			this.checkBoxF_2.Location = new global::System.Drawing.Point(4, 48);
			this.checkBoxF_2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxF_2.Name = "checkBoxF_2";
			this.checkBoxF_2.Size = new global::System.Drawing.Size(73, 24);
			this.checkBoxF_2.TabIndex = 363;
			this.checkBoxF_2.Text = "Send";
			this.checkBoxF_2.UseVisualStyleBackColor = true;
			this.checkBoxF_2.CheckedChanged += new global::System.EventHandler(this.checkBoxF_2_CheckedChanged);
			this.checkBoxF_1.AutoSize = true;
			this.checkBoxF_1.Location = new global::System.Drawing.Point(4, 6);
			this.checkBoxF_1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxF_1.Name = "checkBoxF_1";
			this.checkBoxF_1.Size = new global::System.Drawing.Size(73, 24);
			this.checkBoxF_1.TabIndex = 361;
			this.checkBoxF_1.Text = "Send";
			this.checkBoxF_1.UseVisualStyleBackColor = true;
			this.checkBoxF_1.CheckedChanged += new global::System.EventHandler(this.checkBoxF_1_CheckedChanged);
			this.tabPage1.Controls.Add(this.buttonNotCheckAll);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(572, 130);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Loại trừ ac dame";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.buttonNotCheckAll.Location = new global::System.Drawing.Point(291, 78);
			this.buttonNotCheckAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonNotCheckAll.Name = "buttonNotCheckAll";
			this.buttonNotCheckAll.Size = new global::System.Drawing.Size(170, 40);
			this.buttonNotCheckAll.TabIndex = 365;
			this.buttonNotCheckAll.Text = "Bỏ check tất cả ac";
			this.buttonNotCheckAll.UseVisualStyleBackColor = true;
			this.buttonNotCheckAll.Click += new global::System.EventHandler(this.buttonNotCheckAll_Click);
			this.label5.ForeColor = global::System.Drawing.Color.Black;
			this.label5.Location = new global::System.Drawing.Point(286, 5);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(278, 69);
			this.label5.TabIndex = 361;
			this.label5.Text = "Nếu muốn loại trừ ac nào đó, không muốn nó dame kết hợp thì check vào tên ac";
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(2, 2);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(275, 119);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.columnHeader_0.Text = "Nhân vật";
			this.columnHeader_0.Width = 160;
			this.comboBoxKieuXuatchieu.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKieuXuatchieu.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.comboBoxKieuXuatchieu.FormattingEnabled = true;
			this.comboBoxKieuXuatchieu.Location = new global::System.Drawing.Point(292, 300);
			this.comboBoxKieuXuatchieu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxKieuXuatchieu.Name = "comboBoxKieuXuatchieu";
			this.comboBoxKieuXuatchieu.Size = new global::System.Drawing.Size(238, 28);
			this.comboBoxKieuXuatchieu.TabIndex = 352;
			this.comboBoxKieuXuatchieu.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxKieuXuatchieu_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.Location = new global::System.Drawing.Point(4, 306);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(126, 20);
			this.label6.TabIndex = 361;
			this.label6.Text = "Chọn riêng ac";
			this.labelTocdo.AutoSize = true;
			this.labelTocdo.Location = new global::System.Drawing.Point(249, 43);
			this.labelTocdo.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTocdo.Name = "labelTocdo";
			this.labelTocdo.Size = new global::System.Drawing.Size(125, 20);
			this.labelTocdo.TabIndex = 362;
			this.labelTocdo.Text = "Tốc độ (mili giây)";
			this.textBoxTocdo.Location = new global::System.Drawing.Point(388, 37);
			this.textBoxTocdo.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTocdo.Name = "textBoxTocdo";
			this.textBoxTocdo.Size = new global::System.Drawing.Size(67, 26);
			this.textBoxTocdo.TabIndex = 363;
			this.textBoxTocdo.TextChanged += new global::System.EventHandler(this.textBoxTocdo_TextChanged);
			this.checkBoxCtrlShift.AutoSize = true;
			this.checkBoxCtrlShift.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxCtrlShift.Location = new global::System.Drawing.Point(9, 520);
			this.checkBoxCtrlShift.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCtrlShift.Name = "checkBoxCtrlShift";
			this.checkBoxCtrlShift.Size = new global::System.Drawing.Size(377, 24);
			this.checkBoxCtrlShift.TabIndex = 364;
			this.checkBoxCtrlShift.Text = "Sử dụng CTRL + SHIFT để tắt/bật dame kết hợp";
			this.checkBoxCtrlShift.UseVisualStyleBackColor = true;
			this.checkBoxCtrlShift.CheckedChanged += new global::System.EventHandler(this.checkBoxCtrlShift_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(591, 562);
			base.Controls.Add(this.checkBoxCtrlShift);
			base.Controls.Add(this.textBoxTocdo);
			base.Controls.Add(this.labelTocdo);
			base.Controls.Add(this.comboBoxTenAc);
			base.Controls.Add(this.comboBoxKieudanh);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.comboBoxKieuXuatchieu);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBoxAllwayAttack);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBoxTuDanhbinhthuong);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormDame";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dame Ket Hop";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormDame_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageChieu12.ResumeLayout(false);
			this.tabPageChieu12.PerformLayout();
			this.tabPageSendKey.ResumeLayout(false);
			this.tabPageSendKey.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400086A RID: 2154
		private global::System.Windows.Forms.CheckBox checkBoxSkill1;

		// Token: 0x0400086B RID: 2155
		private global::System.Windows.Forms.CheckBox checkBoxSkill2;

		// Token: 0x0400086C RID: 2156
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400086D RID: 2157
		private global::System.Windows.Forms.ComboBox comboBoxKieudanh;

		// Token: 0x0400086E RID: 2158
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400086F RID: 2159
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000870 RID: 2160
		private global::System.Windows.Forms.CheckBox checkBoxTuDanhbinhthuong;

		// Token: 0x04000871 RID: 2161
		private global::System.Windows.Forms.ComboBox comboBoxSkill1;

		// Token: 0x04000872 RID: 2162
		private global::System.Windows.Forms.ComboBox comboBoxSkill2;

		// Token: 0x04000873 RID: 2163
		private global::System.Windows.Forms.ComboBox comboBoxTenAc;

		// Token: 0x04000874 RID: 2164
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000875 RID: 2165
		private global::System.Windows.Forms.CheckBox checkBoxAllwayAttack;

		// Token: 0x04000876 RID: 2166
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000877 RID: 2167
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000878 RID: 2168
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000879 RID: 2169
		private global::System.Windows.Forms.TabPage tabPageChieu12;

		// Token: 0x0400087A RID: 2170
		private global::System.Windows.Forms.TabPage tabPageSendKey;

		// Token: 0x0400087B RID: 2171
		private global::System.Windows.Forms.TextBox textBoxDeLay;

		// Token: 0x0400087C RID: 2172
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400087D RID: 2173
		private global::System.Windows.Forms.CheckBox checkBoxF_3;

		// Token: 0x0400087E RID: 2174
		private global::System.Windows.Forms.CheckBox checkBoxF_2;

		// Token: 0x0400087F RID: 2175
		private global::System.Windows.Forms.CheckBox checkBoxF_1;

		// Token: 0x04000880 RID: 2176
		private global::System.Windows.Forms.ComboBox comboBoxKieuXuatchieu;

		// Token: 0x04000881 RID: 2177
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000882 RID: 2178
		private global::System.Windows.Forms.ComboBox comboBoxF_3;

		// Token: 0x04000883 RID: 2179
		private global::System.Windows.Forms.ComboBox comboBoxF_2;

		// Token: 0x04000884 RID: 2180
		private global::System.Windows.Forms.ComboBox comboBoxF_1;

		// Token: 0x04000885 RID: 2181
		private global::System.Windows.Forms.Label labelTocdo;

		// Token: 0x04000886 RID: 2182
		private global::System.Windows.Forms.TextBox textBoxTocdo;

		// Token: 0x04000887 RID: 2183
		private global::System.Windows.Forms.CheckBox checkBoxCtrlShift;

		// Token: 0x04000888 RID: 2184
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000889 RID: 2185
		private global::System.Windows.Forms.Button buttonNotCheckAll;

		// Token: 0x0400088A RID: 2186
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400088B RID: 2187
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400088C RID: 2188
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040008A0 RID: 2208
		private global::System.ComponentModel.IContainer components;
	}
}
