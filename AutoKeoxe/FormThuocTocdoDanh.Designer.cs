namespace AutoKeoxe
{
	// Token: 0x02000087 RID: 135
	public partial class FormThuocTocdoDanh : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B36 RID: 2870 RVA: 0x00186924 File Offset: 0x00184B24
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormThuocTocdoDanh));
			this.comboBoxTenTuiMauHotro = new global::System.Windows.Forms.ComboBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonAppAll = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxGiay = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonXoaThuong = new global::System.Windows.Forms.Button();
			this.buttonThuong = new global::System.Windows.Forms.Button();
			this.listViewThuong = new global::System.Windows.Forms.ListView();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxThuong = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.comboBoxTenTuiMauHotro.DropDownWidth = 290;
			this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
			this.comboBoxTenTuiMauHotro.Location = new global::System.Drawing.Point(4, 409);
			this.comboBoxTenTuiMauHotro.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
			this.comboBoxTenTuiMauHotro.Size = new global::System.Drawing.Size(272, 28);
			this.comboBoxTenTuiMauHotro.TabIndex = 217;
			this.comboBoxTenTuiMauHotro.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenTuiMauHotro_MouseDown);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(4, 237);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(440, 164);
			this.listView1.TabIndex = 218;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Tên thuốc (dùng trong Tống Kim)";
			this.columnHeader_0.Width = 250;
			this.buttonThem.Location = new global::System.Drawing.Point(290, 406);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(86, 35);
			this.buttonThem.TabIndex = 219;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(378, 406);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(69, 35);
			this.buttonXoa.TabIndex = 220;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(334, 526);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(112, 40);
			this.buttonClose.TabIndex = 222;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonAppAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonAppAll.Location = new global::System.Drawing.Point(6, 526);
			this.buttonAppAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAppAll.Name = "buttonAppAll";
			this.buttonAppAll.Size = new global::System.Drawing.Size(320, 40);
			this.buttonAppAll.TabIndex = 231;
			this.buttonAppAll.Text = "Áp dụng tên thuốc cho tất cả ac";
			this.buttonAppAll.UseVisualStyleBackColor = true;
			this.buttonAppAll.Click += new global::System.EventHandler(this.buttonAppAll_Click);
			this.label1.Location = new global::System.Drawing.Point(2, 8);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(446, 45);
			this.label1.TabIndex = 232;
			this.label1.Text = "Chức năng ăn thuốc khi bấm phím tắt thì thiết lập trong phần <Nhồi thuốc> của hậu cần. Còn phần này là ăn tự động.";
			this.textBoxGiay.Location = new global::System.Drawing.Point(378, 468);
			this.textBoxGiay.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxGiay.Name = "textBoxGiay";
			this.textBoxGiay.Size = new global::System.Drawing.Size(66, 26);
			this.textBoxGiay.TabIndex = 236;
			this.textBoxGiay.TextChanged += new global::System.EventHandler(this.textBoxGiay_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(2, 458);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(347, 40);
			this.label2.TabIndex = 237;
			this.label2.Text = "Thời gian kiểm tra giữa 2 lần ăn thuốc (giây)\r\nNếu bị mis thì sẽ ăn lại, thường khoảng 3 - 5 giây";
			this.buttonXoaThuong.Location = new global::System.Drawing.Point(378, 177);
			this.buttonXoaThuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaThuong.Name = "buttonXoaThuong";
			this.buttonXoaThuong.Size = new global::System.Drawing.Size(69, 35);
			this.buttonXoaThuong.TabIndex = 241;
			this.buttonXoaThuong.Text = "Xóa";
			this.buttonXoaThuong.UseVisualStyleBackColor = true;
			this.buttonXoaThuong.Click += new global::System.EventHandler(this.buttonXoaThuong_Click);
			this.buttonThuong.Location = new global::System.Drawing.Point(290, 177);
			this.buttonThuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThuong.Name = "buttonThuong";
			this.buttonThuong.Size = new global::System.Drawing.Size(86, 35);
			this.buttonThuong.TabIndex = 240;
			this.buttonThuong.Text = "Thêm";
			this.buttonThuong.UseVisualStyleBackColor = true;
			this.buttonThuong.Click += new global::System.EventHandler(this.buttonThuong_Click);
			this.listViewThuong.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewThuong.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_1
			});
			this.listViewThuong.FullRowSelect = true;
			this.listViewThuong.GridLines = true;
			this.listViewThuong.HideSelection = false;
			this.listViewThuong.Location = new global::System.Drawing.Point(4, 60);
			this.listViewThuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewThuong.Name = "listViewThuong";
			this.listViewThuong.Size = new global::System.Drawing.Size(440, 111);
			this.listViewThuong.TabIndex = 239;
			this.listViewThuong.UseCompatibleStateImageBehavior = false;
			this.listViewThuong.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_1.Text = "Tên thuốc (dùng ở bản đồ thường)";
			this.columnHeader_1.Width = 250;
			this.comboBoxThuong.DropDownWidth = 290;
			this.comboBoxThuong.FormattingEnabled = true;
			this.comboBoxThuong.Location = new global::System.Drawing.Point(4, 180);
			this.comboBoxThuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThuong.Name = "comboBoxThuong";
			this.comboBoxThuong.Size = new global::System.Drawing.Size(272, 28);
			this.comboBoxThuong.TabIndex = 238;
			this.comboBoxThuong.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxThuong_MouseDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(453, 578);
			base.Controls.Add(this.buttonXoaThuong);
			base.Controls.Add(this.buttonThuong);
			base.Controls.Add(this.listViewThuong);
			base.Controls.Add(this.comboBoxThuong);
			base.Controls.Add(this.textBoxGiay);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonAppAll);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBoxTenTuiMauHotro);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormThuocTocdoDanh";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "THUOC TOC DO DANH";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormThuocTocdoDanh_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000C93 RID: 3219
		private global::System.Windows.Forms.ComboBox comboBoxTenTuiMauHotro;

		// Token: 0x04000C94 RID: 3220
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000C95 RID: 3221
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000C96 RID: 3222
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000C97 RID: 3223
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000C98 RID: 3224
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000C99 RID: 3225
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000C9A RID: 3226
		private global::System.Windows.Forms.Button buttonAppAll;

		// Token: 0x04000C9B RID: 3227
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000C9C RID: 3228
		private global::System.Windows.Forms.TextBox textBoxGiay;

		// Token: 0x04000C9D RID: 3229
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000C9E RID: 3230
		private global::System.Windows.Forms.Button buttonXoaThuong;

		// Token: 0x04000C9F RID: 3231
		private global::System.Windows.Forms.Button buttonThuong;

		// Token: 0x04000CA0 RID: 3232
		private global::System.Windows.Forms.ListView listViewThuong;

		// Token: 0x04000CA1 RID: 3233
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000CA2 RID: 3234
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000CA3 RID: 3235
		private global::System.Windows.Forms.ComboBox comboBoxThuong;
	}
}
