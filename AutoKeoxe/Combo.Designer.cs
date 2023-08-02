namespace AutoKeoxe
{
	// Token: 0x02000061 RID: 97
	public partial class Combo : global::System.Windows.Forms.Form
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x000F167C File Offset: 0x000EF87C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.Combo));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.comboBoxPhim = new global::System.Windows.Forms.ComboBox();
			this.comboBoxThuoc = new global::System.Windows.Forms.ComboBox();
			this.buttonApdung = new global::System.Windows.Forms.Button();
			this.labelStatus = new global::System.Windows.Forms.Label();
			this.checkBoxDungchung = new global::System.Windows.Forms.CheckBox();
			this.labelXoaPhim = new global::System.Windows.Forms.Label();
			this.labelXoaThuoc = new global::System.Windows.Forms.Label();
			this.labelThemThuoc = new global::System.Windows.Forms.Label();
			this.buttonXoaFilecauhinh = new global::System.Windows.Forms.Button();
			this.buttonTaoPhim = new global::System.Windows.Forms.Button();
			this.buttonPhimHuongdan = new global::System.Windows.Forms.Button();
			this.labelTile = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBoxPhiChiendau = new global::System.Windows.Forms.CheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.numericUpDown1.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.numericUpDown1.Location = new global::System.Drawing.Point(506, 234);
			this.numericUpDown1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 10000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(124, 26);
			this.numericUpDown1.TabIndex = 72;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Value = new decimal(array2);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.numericUpDown1.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.numericUpDown1_KeyUp);
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(180, 40);
			this.listView2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(450, 187);
			this.listView2.TabIndex = 66;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.listView2.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
			this.listView2.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listView2_MouseDown);
			this.columnHeader_0.Text = "Tên thuốc";
			this.columnHeader_0.Width = 210;
			this.columnHeader_1.Text = "Số lượng";
			this.columnHeader_1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader_1.Width = 70;
			this.numericUpDown2.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.numericUpDown2.Location = new global::System.Drawing.Point(396, 318);
			this.numericUpDown2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown2;
			int[] array3 = new int[4];
			array3[0] = 10;
			numericUpDown3.Maximum = new decimal(array3);
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown2;
			int[] array4 = new int[4];
			array4[0] = 1;
			numericUpDown4.Minimum = new decimal(array4);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(78, 26);
			this.numericUpDown2.TabIndex = 76;
			global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.numericUpDown2;
			int[] array5 = new int[4];
			array5[0] = 1;
			numericUpDown5.Value = new decimal(array5);
			this.numericUpDown2.ValueChanged += new global::System.EventHandler(this.numericUpDown2_ValueChanged);
			this.numericUpDown2.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.numericUpDown2_KeyUp);
			this.columnHeader_2.Text = "Phím bơm";
			this.columnHeader_2.Width = 85;
			this.listView1.BackColor = global::System.Drawing.SystemColors.Info;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(9, 40);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(160, 187);
			this.listView1.TabIndex = 65;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			this.listView1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
			this.comboBoxPhim.BackColor = global::System.Drawing.Color.White;
			this.comboBoxPhim.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPhim.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.comboBoxPhim.FormattingEnabled = true;
			this.comboBoxPhim.Location = new global::System.Drawing.Point(117, 234);
			this.comboBoxPhim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxPhim.Name = "comboBoxPhim";
			this.comboBoxPhim.Size = new global::System.Drawing.Size(52, 28);
			this.comboBoxPhim.TabIndex = 73;
			this.comboBoxThuoc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThuoc.DropDownWidth = 225;
			this.comboBoxThuoc.FormattingEnabled = true;
			this.comboBoxThuoc.Location = new global::System.Drawing.Point(182, 234);
			this.comboBoxThuoc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThuoc.Name = "comboBoxThuoc";
			this.comboBoxThuoc.Size = new global::System.Drawing.Size(319, 28);
			this.comboBoxThuoc.TabIndex = 69;
			this.comboBoxThuoc.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxThuoc_MouseDown);
			this.buttonApdung.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonApdung.ForeColor = global::System.Drawing.Color.Black;
			this.buttonApdung.Location = new global::System.Drawing.Point(488, 448);
			this.buttonApdung.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdung.Name = "buttonApdung";
			this.buttonApdung.Size = new global::System.Drawing.Size(134, 58);
			this.buttonApdung.TabIndex = 78;
			this.buttonApdung.Text = "Đóng";
			this.buttonApdung.UseVisualStyleBackColor = false;
			this.buttonApdung.Click += new global::System.EventHandler(this.buttonApdung_Click);
			this.labelStatus.AutoSize = true;
			this.labelStatus.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelStatus.ForeColor = global::System.Drawing.Color.Black;
			this.labelStatus.Location = new global::System.Drawing.Point(4, 8);
			this.labelStatus.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new global::System.Drawing.Size(492, 20);
			this.labelStatus.TabIndex = 81;
			this.labelStatus.Text = "Bấm nút tạo phím, sau đó thêm tên thuốc và số lượng vào danh sách";
			this.labelStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.checkBoxDungchung.AutoSize = true;
			this.checkBoxDungchung.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxDungchung.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.checkBoxDungchung.Location = new global::System.Drawing.Point(9, 322);
			this.checkBoxDungchung.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDungchung.Name = "checkBoxDungchung";
			this.checkBoxDungchung.Size = new global::System.Drawing.Size(311, 24);
			this.checkBoxDungchung.TabIndex = 85;
			this.checkBoxDungchung.Text = "Các nhân vật còn lại đều bơm theo tỉ lệ:";
			this.checkBoxDungchung.UseVisualStyleBackColor = false;
			this.checkBoxDungchung.CheckedChanged += new global::System.EventHandler(this.checkBoxDungchung_CheckedChanged);
			this.labelXoaPhim.AutoSize = true;
			this.labelXoaPhim.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelXoaPhim.ForeColor = global::System.Drawing.Color.Blue;
			this.labelXoaPhim.Location = new global::System.Drawing.Point(15, 278);
			this.labelXoaPhim.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelXoaPhim.Name = "labelXoaPhim";
			this.labelXoaPhim.Size = new global::System.Drawing.Size(92, 20);
			this.labelXoaPhim.TabIndex = 77;
			this.labelXoaPhim.Text = "[ Xóa phím ]";
			this.labelXoaPhim.Click += new global::System.EventHandler(this.labelXoaPhim_Click);
			this.labelXoaThuoc.AutoSize = true;
			this.labelXoaThuoc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelXoaThuoc.ForeColor = global::System.Drawing.Color.Blue;
			this.labelXoaThuoc.Location = new global::System.Drawing.Point(300, 278);
			this.labelXoaThuoc.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelXoaThuoc.Name = "labelXoaThuoc";
			this.labelXoaThuoc.Size = new global::System.Drawing.Size(98, 20);
			this.labelXoaThuoc.TabIndex = 75;
			this.labelXoaThuoc.Text = "[ Xóa thuốc ]";
			this.labelXoaThuoc.Click += new global::System.EventHandler(this.labelXoaThuoc_Click);
			this.labelThemThuoc.AutoSize = true;
			this.labelThemThuoc.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelThemThuoc.ForeColor = global::System.Drawing.Color.Blue;
			this.labelThemThuoc.Location = new global::System.Drawing.Point(177, 278);
			this.labelThemThuoc.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelThemThuoc.Name = "labelThemThuoc";
			this.labelThemThuoc.Size = new global::System.Drawing.Size(109, 20);
			this.labelThemThuoc.TabIndex = 74;
			this.labelThemThuoc.Text = "[ Thêm thuốc ]";
			this.labelThemThuoc.Click += new global::System.EventHandler(this.labelThemThuoc_Click);
			this.buttonXoaFilecauhinh.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXoaFilecauhinh.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonXoaFilecauhinh.Location = new global::System.Drawing.Point(9, 466);
			this.buttonXoaFilecauhinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaFilecauhinh.Name = "buttonXoaFilecauhinh";
			this.buttonXoaFilecauhinh.Size = new global::System.Drawing.Size(162, 40);
			this.buttonXoaFilecauhinh.TabIndex = 84;
			this.buttonXoaFilecauhinh.Text = "Xóa file cấu hình";
			this.buttonXoaFilecauhinh.UseVisualStyleBackColor = false;
			this.buttonXoaFilecauhinh.Click += new global::System.EventHandler(this.buttonXoaFilecauhinh_Click);
			this.buttonTaoPhim.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonTaoPhim.Location = new global::System.Drawing.Point(9, 234);
			this.buttonTaoPhim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTaoPhim.Name = "buttonTaoPhim";
			this.buttonTaoPhim.Size = new global::System.Drawing.Size(104, 32);
			this.buttonTaoPhim.TabIndex = 86;
			this.buttonTaoPhim.Text = "Tạo phím";
			this.buttonTaoPhim.UseVisualStyleBackColor = true;
			this.buttonTaoPhim.Click += new global::System.EventHandler(this.buttonTaoPhim_Click);
			this.buttonPhimHuongdan.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonPhimHuongdan.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonPhimHuongdan.Location = new global::System.Drawing.Point(182, 466);
			this.buttonPhimHuongdan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPhimHuongdan.Name = "buttonPhimHuongdan";
			this.buttonPhimHuongdan.Size = new global::System.Drawing.Size(150, 40);
			this.buttonPhimHuongdan.TabIndex = 87;
			this.buttonPhimHuongdan.Text = "Phim hướng dẫn";
			this.buttonPhimHuongdan.UseVisualStyleBackColor = false;
			this.buttonPhimHuongdan.Click += new global::System.EventHandler(this.buttonPhimHuongdan_Click);
			this.labelTile.AutoSize = true;
			this.labelTile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.labelTile.ForeColor = global::System.Drawing.Color.Blue;
			this.labelTile.Location = new global::System.Drawing.Point(483, 325);
			this.labelTile.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTile.Name = "labelTile";
			this.labelTile.Size = new global::System.Drawing.Size(81, 20);
			this.labelTile.TabIndex = 89;
			this.labelTile.Text = "(giải thích)";
			this.labelTile.Click += new global::System.EventHandler(this.labelTile_Click);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.label3.Location = new global::System.Drawing.Point(510, 271);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(72, 20);
			this.label3.TabIndex = 86;
			this.label3.Text = "Số lượng";
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(51, 402);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(298, 46);
			this.label2.TabIndex = 246;
			this.label2.Text = "Xem và kết hợp với mở túi thuốc ở phần Hậu cần nha các bạn !";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(357, 325);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(26, 20);
			this.label4.TabIndex = 247;
			this.label4.Text = "1 /";
			this.checkBoxPhiChiendau.AutoSize = true;
			this.checkBoxPhiChiendau.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxPhiChiendau.Location = new global::System.Drawing.Point(9, 362);
			this.checkBoxPhiChiendau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhiChiendau.Name = "checkBoxPhiChiendau";
			this.checkBoxPhiChiendau.Size = new global::System.Drawing.Size(410, 24);
			this.checkBoxPhiChiendau.TabIndex = 248;
			this.checkBoxPhiChiendau.Text = "Sử dụng được luôn ở trong thành và nơi phi chiến đấu";
			this.checkBoxPhiChiendau.UseVisualStyleBackColor = true;
			this.checkBoxPhiChiendau.CheckedChanged += new global::System.EventHandler(this.checkBoxPhiChiendau_CheckedChanged);
			this.button1.BackColor = global::System.Drawing.SystemColors.Control;
			this.button1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.button1.Location = new global::System.Drawing.Point(488, 372);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(134, 58);
			this.button1.TabIndex = 249;
			this.button1.Text = "Áp dụng cho tất cả ac";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(634, 523);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.checkBoxPhiChiendau);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.labelTile);
			base.Controls.Add(this.numericUpDown2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.checkBoxDungchung);
			base.Controls.Add(this.buttonPhimHuongdan);
			base.Controls.Add(this.buttonXoaFilecauhinh);
			base.Controls.Add(this.buttonTaoPhim);
			base.Controls.Add(this.comboBoxPhim);
			base.Controls.Add(this.buttonApdung);
			base.Controls.Add(this.labelStatus);
			base.Controls.Add(this.labelXoaPhim);
			base.Controls.Add(this.labelXoaThuoc);
			base.Controls.Add(this.labelThemThuoc);
			base.Controls.Add(this.listView2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBoxThuoc);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "Combo";
			this.Text = "COMBO NHOI THUOC";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.Combo_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000418 RID: 1048
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000419 RID: 1049
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x0400041B RID: 1051
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400041C RID: 1052
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x0400041D RID: 1053
		private global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x0400041E RID: 1054
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x0400041F RID: 1055
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000420 RID: 1056
		private global::System.Windows.Forms.ComboBox comboBoxPhim;

		// Token: 0x04000421 RID: 1057
		private global::System.Windows.Forms.ComboBox comboBoxThuoc;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.Button buttonApdung;

		// Token: 0x04000423 RID: 1059
		private global::System.Windows.Forms.Label labelStatus;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.Button buttonXoaFilecauhinh;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.CheckBox checkBoxDungchung;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.Label labelXoaThuoc;

		// Token: 0x04000427 RID: 1063
		private global::System.Windows.Forms.Label labelThemThuoc;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.Label labelXoaPhim;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.Button buttonTaoPhim;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.Button buttonPhimHuongdan;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400042C RID: 1068
		private global::System.Windows.Forms.Label labelTile;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400042E RID: 1070
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400042F RID: 1071
		private global::System.Windows.Forms.CheckBox checkBoxPhiChiendau;

		// Token: 0x04000430 RID: 1072
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400043B RID: 1083
		private global::System.ComponentModel.IContainer components;
	}
}
