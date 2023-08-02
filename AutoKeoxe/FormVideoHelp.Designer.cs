namespace AutoKeoxe
{
	// Token: 0x0200008E RID: 142
	public partial class FormVideoHelp : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x00192BA4 File Offset: 0x00190DA4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormVideoHelp));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.checkBoxKhongHienthi = new global::System.Windows.Forms.CheckBox();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.Thongtin = new global::System.Windows.Forms.Label();
			this.buttonHelp = new global::System.Windows.Forms.Button();
			this.linkLabelLinkWeb = new global::System.Windows.Forms.LinkLabel();
			this.textBoxLink = new global::System.Windows.Forms.TextBox();
			this.textBoxDienGiai = new global::System.Windows.Forms.TextBox();
			this.buttonCopy = new global::System.Windows.Forms.Button();
			this.buttonXem = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.checkBoxKhongHienthi.AutoSize = true;
			this.checkBoxKhongHienthi.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxKhongHienthi.Location = new global::System.Drawing.Point(8, 565);
			this.checkBoxKhongHienthi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
			this.checkBoxKhongHienthi.Size = new global::System.Drawing.Size(316, 24);
			this.checkBoxKhongHienthi.TabIndex = 48;
			this.checkBoxKhongHienthi.Text = "Không hiển thị bảng hướng dẫn này nữa";
			this.checkBoxKhongHienthi.UseVisualStyleBackColor = true;
			this.checkBoxKhongHienthi.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongHienthi_CheckedChanged);
			this.buttonClose.Location = new global::System.Drawing.Point(464, 551);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(118, 40);
			this.buttonClose.TabIndex = 49;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.Thongtin.AutoSize = true;
			this.Thongtin.ForeColor = global::System.Drawing.Color.Red;
			this.Thongtin.Location = new global::System.Drawing.Point(24, 832);
			this.Thongtin.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Thongtin.Name = "Thongtin";
			this.Thongtin.Size = new global::System.Drawing.Size(21, 20);
			this.Thongtin.TabIndex = 50;
			this.Thongtin.Text = "...";
			this.buttonHelp.Location = new global::System.Drawing.Point(408, 5);
			this.buttonHelp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new global::System.Drawing.Size(180, 46);
			this.buttonHelp.TabIndex = 52;
			this.buttonHelp.Text = "Các cập nhật mới";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new global::System.EventHandler(this.buttonHelp_Click);
			this.linkLabelLinkWeb.AutoSize = true;
			this.linkLabelLinkWeb.Location = new global::System.Drawing.Point(8, 531);
			this.linkLabelLinkWeb.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelLinkWeb.Name = "linkLabelLinkWeb";
			this.linkLabelLinkWeb.Size = new global::System.Drawing.Size(159, 20);
			this.linkLabelLinkWeb.TabIndex = 143;
			this.linkLabelLinkWeb.TabStop = true;
			this.linkLabelLinkWeb.Text = "http://canhtrang.com/";
			this.linkLabelLinkWeb.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLinkWeb_LinkClicked);
			this.textBoxLink.BackColor = global::System.Drawing.SystemColors.Info;
			this.textBoxLink.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxLink.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.textBoxLink.Location = new global::System.Drawing.Point(8, 29);
			this.textBoxLink.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxLink.Name = "textBoxLink";
			this.textBoxLink.Size = new global::System.Drawing.Size(392, 19);
			this.textBoxLink.TabIndex = 370;
			this.textBoxDienGiai.BackColor = global::System.Drawing.SystemColors.Info;
			this.textBoxDienGiai.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxDienGiai.Location = new global::System.Drawing.Point(8, 5);
			this.textBoxDienGiai.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDienGiai.Name = "textBoxDienGiai";
			this.textBoxDienGiai.Size = new global::System.Drawing.Size(392, 19);
			this.textBoxDienGiai.TabIndex = 369;
			this.buttonCopy.Location = new global::System.Drawing.Point(408, 502);
			this.buttonCopy.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new global::System.Drawing.Size(174, 40);
			this.buttonCopy.TabIndex = 367;
			this.buttonCopy.Text = "Copy link phim";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new global::System.EventHandler(this.buttonCopy_Click);
			this.buttonXem.Location = new global::System.Drawing.Point(171, 502);
			this.buttonXem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXem.Name = "buttonXem";
			this.buttonXem.Size = new global::System.Drawing.Size(228, 40);
			this.buttonXem.TabIndex = 366;
			this.buttonXem.Text = "Xem phim";
			this.buttonXem.UseVisualStyleBackColor = true;
			this.buttonXem.Click += new global::System.EventHandler(this.buttonXem_Click);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listView1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(8, 65);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(580, 428);
			this.listView1.TabIndex = 365;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 30;
			this.columnHeader_1.Text = "Diễn giải";
			this.columnHeader_1.Width = 230;
			this.columnHeader_2.Text = "Link phim";
			this.columnHeader_2.Width = 105;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(591, 600);
			base.Controls.Add(this.textBoxLink);
			base.Controls.Add(this.textBoxDienGiai);
			base.Controls.Add(this.buttonCopy);
			base.Controls.Add(this.buttonXem);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.linkLabelLinkWeb);
			base.Controls.Add(this.buttonHelp);
			base.Controls.Add(this.Thongtin);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.checkBoxKhongHienthi);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormVideoHelp";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHIM HUONG DAN";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormVideoHelp_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000D74 RID: 3444
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000D75 RID: 3445
		private global::System.Windows.Forms.CheckBox checkBoxKhongHienthi;

		// Token: 0x04000D76 RID: 3446
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000D77 RID: 3447
		private global::System.Windows.Forms.Label Thongtin;

		// Token: 0x04000D78 RID: 3448
		private global::System.Windows.Forms.Button buttonHelp;

		// Token: 0x04000D79 RID: 3449
		private global::System.Windows.Forms.LinkLabel linkLabelLinkWeb;

		// Token: 0x04000D7A RID: 3450
		private global::System.Windows.Forms.TextBox textBoxLink;

		// Token: 0x04000D7B RID: 3451
		private global::System.Windows.Forms.TextBox textBoxDienGiai;

		// Token: 0x04000D7C RID: 3452
		private global::System.Windows.Forms.Button buttonCopy;

		// Token: 0x04000D7D RID: 3453
		private global::System.Windows.Forms.Button buttonXem;

		// Token: 0x04000D7E RID: 3454
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000D7F RID: 3455
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000D80 RID: 3456
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000D81 RID: 3457
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000D82 RID: 3458
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;
	}
}
