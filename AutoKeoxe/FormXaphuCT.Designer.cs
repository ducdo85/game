namespace AutoKeoxe
{
	// Token: 0x0200008F RID: 143
	public partial class FormXaphuCT : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BC5 RID: 3013 RVA: 0x0019459C File Offset: 0x0019279C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormXaphuCT));
			this.label19 = new global::System.Windows.Forms.Label();
			this.buttonXoaCongThanhQuan = new global::System.Windows.Forms.Button();
			this.comboBoxCongThanhQuan = new global::System.Windows.Forms.ComboBox();
			this.buttonLayCongThanhQuan = new global::System.Windows.Forms.Button();
			this.listViewXaphuCongthanh = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonTudongLayvitri = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label19.ForeColor = global::System.Drawing.Color.Black;
			this.label19.Location = new global::System.Drawing.Point(4, 391);
			this.label19.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(624, 71);
			this.label19.TabIndex = 234;
			this.label19.Text = componentResourceManager.GetString("label19.Text");
			this.buttonXoaCongThanhQuan.Location = new global::System.Drawing.Point(308, 322);
			this.buttonXoaCongThanhQuan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaCongThanhQuan.Name = "buttonXoaCongThanhQuan";
			this.buttonXoaCongThanhQuan.Size = new global::System.Drawing.Size(111, 55);
			this.buttonXoaCongThanhQuan.TabIndex = 238;
			this.buttonXoaCongThanhQuan.Text = "Xóa, bỏ qua";
			this.buttonXoaCongThanhQuan.UseVisualStyleBackColor = true;
			this.buttonXoaCongThanhQuan.Click += new global::System.EventHandler(this.buttonXoaCongThanhQuan_Click);
			this.comboBoxCongThanhQuan.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCongThanhQuan.FormattingEnabled = true;
			this.comboBoxCongThanhQuan.Location = new global::System.Drawing.Point(6, 292);
			this.comboBoxCongThanhQuan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxCongThanhQuan.Name = "comboBoxCongThanhQuan";
			this.comboBoxCongThanhQuan.Size = new global::System.Drawing.Size(290, 28);
			this.comboBoxCongThanhQuan.TabIndex = 236;
			this.comboBoxCongThanhQuan.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxCongThanhQuan_MouseDown);
			this.buttonLayCongThanhQuan.Location = new global::System.Drawing.Point(6, 334);
			this.buttonLayCongThanhQuan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonLayCongThanhQuan.Name = "buttonLayCongThanhQuan";
			this.buttonLayCongThanhQuan.Size = new global::System.Drawing.Size(292, 43);
			this.buttonLayCongThanhQuan.TabIndex = 237;
			this.buttonLayCongThanhQuan.Text = "Lấy";
			this.buttonLayCongThanhQuan.UseVisualStyleBackColor = true;
			this.buttonLayCongThanhQuan.Click += new global::System.EventHandler(this.buttonLayCongThanhQuan_Click);
			this.listViewXaphuCongthanh.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewXaphuCongthanh.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listViewXaphuCongthanh.FullRowSelect = true;
			this.listViewXaphuCongthanh.GridLines = true;
			this.listViewXaphuCongthanh.HideSelection = false;
			this.listViewXaphuCongthanh.Location = new global::System.Drawing.Point(6, 54);
			this.listViewXaphuCongthanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewXaphuCongthanh.Name = "listViewXaphuCongthanh";
			this.listViewXaphuCongthanh.Size = new global::System.Drawing.Size(622, 228);
			this.listViewXaphuCongthanh.TabIndex = 235;
			this.listViewXaphuCongthanh.UseCompatibleStateImageBehavior = false;
			this.listViewXaphuCongthanh.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Thành";
			this.columnHeader_0.Width = 85;
			this.columnHeader_1.Text = "Xa phu CTQ";
			this.columnHeader_1.Width = 180;
			this.columnHeader_2.Text = "Vị trí";
			this.columnHeader_2.Width = 100;
			this.columnHeader_3.Text = "ID";
			this.columnHeader_3.Width = 30;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonTudongLayvitri.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonTudongLayvitri.Location = new global::System.Drawing.Point(428, 322);
			this.buttonTudongLayvitri.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTudongLayvitri.Name = "buttonTudongLayvitri";
			this.buttonTudongLayvitri.Size = new global::System.Drawing.Size(201, 55);
			this.buttonTudongLayvitri.TabIndex = 240;
			this.buttonTudongLayvitri.Text = "Tự động chạy lấy vị trí xa phu vào CTC";
			this.buttonTudongLayvitri.UseVisualStyleBackColor = true;
			this.buttonTudongLayvitri.Click += new global::System.EventHandler(this.buttonTudongLayvitri_Click);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(4, 3);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(624, 43);
			this.label1.TabIndex = 241;
			this.label1.Text = "Bạn phải lấy hết vị trí xa phu vào CTC của 7 thành thì auto mới vào được chiến trường CTC bằng xa phu.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(639, 468);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonLayCongThanhQuan);
			base.Controls.Add(this.comboBoxCongThanhQuan);
			base.Controls.Add(this.buttonTudongLayvitri);
			base.Controls.Add(this.label19);
			base.Controls.Add(this.buttonXoaCongThanhQuan);
			base.Controls.Add(this.listViewXaphuCongthanh);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormXaphuCT";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "XA PHU CONG THANH QUAN";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormXaphuCT_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000D8D RID: 3469
		private global::System.Windows.Forms.Label label19;

		// Token: 0x04000D8E RID: 3470
		private global::System.Windows.Forms.Button buttonXoaCongThanhQuan;

		// Token: 0x04000D8F RID: 3471
		private global::System.Windows.Forms.ComboBox comboBoxCongThanhQuan;

		// Token: 0x04000D90 RID: 3472
		private global::System.Windows.Forms.Button buttonLayCongThanhQuan;

		// Token: 0x04000D91 RID: 3473
		private global::System.Windows.Forms.ListView listViewXaphuCongthanh;

		// Token: 0x04000D92 RID: 3474
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000D93 RID: 3475
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000D94 RID: 3476
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000D95 RID: 3477
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000D96 RID: 3478
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000D97 RID: 3479
		private global::System.Windows.Forms.Button buttonTudongLayvitri;

		// Token: 0x04000D98 RID: 3480
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000D99 RID: 3481
		private global::System.Windows.Forms.Label label1;
	}
}
