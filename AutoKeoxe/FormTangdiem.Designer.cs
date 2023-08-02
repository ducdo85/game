namespace AutoKeoxe
{
	// Token: 0x02000083 RID: 131
	public partial class FormTangdiem : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x0017C7B8 File Offset: 0x0017A9B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTangdiem));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.listViewMonPhai = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.label1 = new global::System.Windows.Forms.Label();
			this.listViewTiemNang = new global::System.Windows.Forms.ListView();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.listViewKyNang = new global::System.Windows.Forms.ListView();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.textBoxTiemNang = new global::System.Windows.Forms.TextBox();
			this.buttonDocLuu = new global::System.Windows.Forms.Button();
			this.buttonLuu = new global::System.Windows.Forms.Button();
			this.buttonTangdiem = new global::System.Windows.Forms.Button();
			this.buttonTangAll = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.textBoxKyNang = new global::System.Windows.Forms.TextBox();
			this.comboBoxAc = new global::System.Windows.Forms.ComboBox();
			this.buttonXuong = new global::System.Windows.Forms.Button();
			this.buttonLen = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelTong = new global::System.Windows.Forms.Label();
			this.buttonXoaAll = new global::System.Windows.Forms.Button();
			this.buttonStop = new global::System.Windows.Forms.Button();
			this.buttonReFresh = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.listViewMonPhai.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewMonPhai.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listViewMonPhai.ForeColor = global::System.Drawing.Color.Red;
			this.listViewMonPhai.FullRowSelect = true;
			this.listViewMonPhai.GridLines = true;
			this.listViewMonPhai.HideSelection = false;
			this.listViewMonPhai.Location = new global::System.Drawing.Point(4, 71);
			this.listViewMonPhai.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewMonPhai.MultiSelect = false;
			this.listViewMonPhai.Name = "listViewMonPhai";
			this.listViewMonPhai.Size = new global::System.Drawing.Size(190, 293);
			this.listViewMonPhai.TabIndex = 4;
			this.listViewMonPhai.UseCompatibleStateImageBehavior = false;
			this.listViewMonPhai.View = global::System.Windows.Forms.View.Details;
			this.listViewMonPhai.SelectedIndexChanged += new global::System.EventHandler(this.listViewMonPhai_SelectedIndexChanged);
			this.columnHeader_0.Text = "Môn phái";
			this.columnHeader_0.Width = 85;
			this.label1.Location = new global::System.Drawing.Point(3, 6);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(302, 51);
			this.label1.TabIndex = 5;
			this.label1.Text = "Hãy thiết lập mẫu điểm cho từng môn phái, auto tự động dò để tăng theo";
			this.listViewTiemNang.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewTiemNang.CheckBoxes = true;
			this.listViewTiemNang.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listViewTiemNang.FullRowSelect = true;
			this.listViewTiemNang.GridLines = true;
			this.listViewTiemNang.HideSelection = false;
			this.listViewTiemNang.Location = new global::System.Drawing.Point(4, 368);
			this.listViewTiemNang.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewTiemNang.MultiSelect = false;
			this.listViewTiemNang.Name = "listViewTiemNang";
			this.listViewTiemNang.Size = new global::System.Drawing.Size(190, 142);
			this.listViewTiemNang.TabIndex = 7;
			this.listViewTiemNang.UseCompatibleStateImageBehavior = false;
			this.listViewTiemNang.View = global::System.Windows.Forms.View.Details;
			this.listViewTiemNang.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listViewTiemNang_ItemCheck);
			this.listViewTiemNang.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listViewTiemNang_MouseUp);
			this.columnHeader_1.Text = "Tiềm năng";
			this.columnHeader_1.Width = 85;
			this.columnHeader_2.Text = "Điểm";
			this.columnHeader_2.Width = 39;
			this.listViewKyNang.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewKyNang.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_3,
				this.columnHeader_4
			});
			this.listViewKyNang.FullRowSelect = true;
			this.listViewKyNang.GridLines = true;
			this.listViewKyNang.HideSelection = false;
			this.listViewKyNang.Location = new global::System.Drawing.Point(204, 71);
			this.listViewKyNang.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewKyNang.MultiSelect = false;
			this.listViewKyNang.Name = "listViewKyNang";
			this.listViewKyNang.Size = new global::System.Drawing.Size(410, 324);
			this.listViewKyNang.TabIndex = 8;
			this.listViewKyNang.UseCompatibleStateImageBehavior = false;
			this.listViewKyNang.View = global::System.Windows.Forms.View.Details;
			this.listViewKyNang.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listViewKyNang_MouseUp);
			this.columnHeader_3.Text = "Tăng kỹ năng cho chiêu thức";
			this.columnHeader_3.Width = 200;
			this.columnHeader_4.Text = "Điểm";
			this.columnHeader_4.Width = 40;
			this.textBoxTiemNang.Location = new global::System.Drawing.Point(134, 520);
			this.textBoxTiemNang.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTiemNang.Name = "textBoxTiemNang";
			this.textBoxTiemNang.Size = new global::System.Drawing.Size(60, 26);
			this.textBoxTiemNang.TabIndex = 9;
			this.textBoxTiemNang.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxTiemNang.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.textBoxTiemNang_KeyUp);
			this.buttonDocLuu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonDocLuu.Location = new global::System.Drawing.Point(412, 2);
			this.buttonDocLuu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDocLuu.Name = "buttonDocLuu";
			this.buttonDocLuu.Size = new global::System.Drawing.Size(90, 58);
			this.buttonDocLuu.TabIndex = 16;
			this.buttonDocLuu.Text = "Đọc mẫu";
			this.buttonDocLuu.UseVisualStyleBackColor = true;
			this.buttonDocLuu.Click += new global::System.EventHandler(this.buttonDocLuu_Click);
			this.buttonLuu.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.buttonLuu.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonLuu.Location = new global::System.Drawing.Point(310, 2);
			this.buttonLuu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLuu.Name = "buttonLuu";
			this.buttonLuu.Size = new global::System.Drawing.Size(98, 58);
			this.buttonLuu.TabIndex = 17;
			this.buttonLuu.Text = "Lưu mẫu";
			this.buttonLuu.UseVisualStyleBackColor = true;
			this.buttonLuu.Click += new global::System.EventHandler(this.buttonLuu_Click);
			this.buttonTangdiem.Location = new global::System.Drawing.Point(204, 503);
			this.buttonTangdiem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTangdiem.Name = "buttonTangdiem";
			this.buttonTangdiem.Size = new global::System.Drawing.Size(100, 58);
			this.buttonTangdiem.TabIndex = 18;
			this.buttonTangdiem.Text = "Tăng đểm ac chọn";
			this.buttonTangdiem.UseVisualStyleBackColor = true;
			this.buttonTangdiem.Click += new global::System.EventHandler(this.buttonTangdiem_Click);
			this.buttonTangAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonTangAll.Location = new global::System.Drawing.Point(310, 503);
			this.buttonTangAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTangAll.Name = "buttonTangAll";
			this.buttonTangAll.Size = new global::System.Drawing.Size(98, 58);
			this.buttonTangAll.TabIndex = 19;
			this.buttonTangAll.Text = "Tăng tất cả ac";
			this.buttonTangAll.UseVisualStyleBackColor = true;
			this.buttonTangAll.Click += new global::System.EventHandler(this.buttonTangAll_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(520, 503);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(90, 58);
			this.buttonClose.TabIndex = 20;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.textBoxKyNang.Location = new global::System.Drawing.Point(507, 400);
			this.textBoxKyNang.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxKyNang.Name = "textBoxKyNang";
			this.textBoxKyNang.Size = new global::System.Drawing.Size(58, 26);
			this.textBoxKyNang.TabIndex = 21;
			this.textBoxKyNang.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxKyNang.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.textBoxKyNang_KeyUp);
			this.comboBoxAc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAc.FormattingEnabled = true;
			this.comboBoxAc.Location = new global::System.Drawing.Point(204, 454);
			this.comboBoxAc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxAc.Name = "comboBoxAc";
			this.comboBoxAc.Size = new global::System.Drawing.Size(296, 28);
			this.comboBoxAc.TabIndex = 23;
			this.buttonXuong.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXuong.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonXuong.Image");
			this.buttonXuong.Location = new global::System.Drawing.Point(50, 517);
			this.buttonXuong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXuong.Name = "buttonXuong";
			this.buttonXuong.Size = new global::System.Drawing.Size(38, 35);
			this.buttonXuong.TabIndex = 411;
			this.buttonXuong.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXuong.UseVisualStyleBackColor = false;
			this.buttonXuong.Click += new global::System.EventHandler(this.buttonXuong_Click);
			this.buttonLen.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonLen.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonLen.Image");
			this.buttonLen.ImageAlign = global::System.Drawing.ContentAlignment.BottomCenter;
			this.buttonLen.Location = new global::System.Drawing.Point(4, 517);
			this.buttonLen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLen.Name = "buttonLen";
			this.buttonLen.Size = new global::System.Drawing.Size(38, 35);
			this.buttonLen.TabIndex = 410;
			this.buttonLen.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonLen.UseVisualStyleBackColor = false;
			this.buttonLen.Click += new global::System.EventHandler(this.buttonLen_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(202, 405);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(203, 20);
			this.label3.TabIndex = 414;
			this.label3.Text = "Tiêu tốn tổng điểm kỹ năng:";
			this.labelTong.AutoSize = true;
			this.labelTong.Location = new global::System.Drawing.Point(410, 405);
			this.labelTong.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelTong.Name = "labelTong";
			this.labelTong.Size = new global::System.Drawing.Size(21, 20);
			this.labelTong.TabIndex = 415;
			this.labelTong.Text = "...";
			this.buttonXoaAll.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonXoaAll.Location = new global::System.Drawing.Point(510, 2);
			this.buttonXoaAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaAll.Name = "buttonXoaAll";
			this.buttonXoaAll.Size = new global::System.Drawing.Size(105, 58);
			this.buttonXoaAll.TabIndex = 416;
			this.buttonXoaAll.Text = "Xóa về mặc định";
			this.buttonXoaAll.UseVisualStyleBackColor = true;
			this.buttonXoaAll.Click += new global::System.EventHandler(this.buttonXoaAll_Click);
			this.buttonStop.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonStop.Location = new global::System.Drawing.Point(412, 503);
			this.buttonStop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new global::System.Drawing.Size(90, 58);
			this.buttonStop.TabIndex = 417;
			this.buttonStop.Text = "Dừng tất cả";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new global::System.EventHandler(this.buttonStop_Click);
			this.buttonReFresh.Location = new global::System.Drawing.Point(510, 451);
			this.buttonReFresh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonReFresh.Name = "buttonReFresh";
			this.buttonReFresh.Size = new global::System.Drawing.Size(100, 35);
			this.buttonReFresh.TabIndex = 418;
			this.buttonReFresh.Text = "Refresh";
			this.buttonReFresh.UseVisualStyleBackColor = true;
			this.buttonReFresh.Click += new global::System.EventHandler(this.buttonReFresh_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(628, 569);
			base.Controls.Add(this.buttonReFresh);
			base.Controls.Add(this.labelTong);
			base.Controls.Add(this.buttonStop);
			base.Controls.Add(this.buttonXoaAll);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.buttonXuong);
			base.Controls.Add(this.buttonLen);
			base.Controls.Add(this.comboBoxAc);
			base.Controls.Add(this.textBoxKyNang);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonTangAll);
			base.Controls.Add(this.buttonTangdiem);
			base.Controls.Add(this.buttonLuu);
			base.Controls.Add(this.buttonDocLuu);
			base.Controls.Add(this.textBoxTiemNang);
			base.Controls.Add(this.listViewTiemNang);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.listViewMonPhai);
			base.Controls.Add(this.listViewKyNang);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTangdiem";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tang diem";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTangdiem_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000BCD RID: 3021
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000BCE RID: 3022
		private global::System.Windows.Forms.ListView listViewMonPhai;

		// Token: 0x04000BCF RID: 3023
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000BD0 RID: 3024
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BD1 RID: 3025
		private global::System.Windows.Forms.ListView listViewTiemNang;

		// Token: 0x04000BD2 RID: 3026
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000BD3 RID: 3027
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000BD4 RID: 3028
		private global::System.Windows.Forms.ListView listViewKyNang;

		// Token: 0x04000BD5 RID: 3029
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000BD6 RID: 3030
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000BD7 RID: 3031
		private global::System.Windows.Forms.TextBox textBoxTiemNang;

		// Token: 0x04000BD8 RID: 3032
		private global::System.Windows.Forms.Button buttonDocLuu;

		// Token: 0x04000BD9 RID: 3033
		private global::System.Windows.Forms.Button buttonLuu;

		// Token: 0x04000BDA RID: 3034
		private global::System.Windows.Forms.Button buttonTangdiem;

		// Token: 0x04000BDB RID: 3035
		private global::System.Windows.Forms.Button buttonTangAll;

		// Token: 0x04000BDC RID: 3036
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000BDD RID: 3037
		private global::System.Windows.Forms.TextBox textBoxKyNang;

		// Token: 0x04000BDE RID: 3038
		private global::System.Windows.Forms.ComboBox comboBoxAc;

		// Token: 0x04000BDF RID: 3039
		private global::System.Windows.Forms.Button buttonLen;

		// Token: 0x04000BE0 RID: 3040
		private global::System.Windows.Forms.Button buttonXuong;

		// Token: 0x04000BE1 RID: 3041
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000BE2 RID: 3042
		private global::System.Windows.Forms.Label labelTong;

		// Token: 0x04000BE3 RID: 3043
		private global::System.Windows.Forms.Button buttonXoaAll;

		// Token: 0x04000BE4 RID: 3044
		private global::System.Windows.Forms.Button buttonStop;

		// Token: 0x04000BE5 RID: 3045
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000BE6 RID: 3046
		private global::System.Windows.Forms.Button buttonReFresh;
	}
}
