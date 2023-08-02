namespace AutoKeoxe
{
	// Token: 0x02000076 RID: 118
	public partial class FormLuomrac : global::System.Windows.Forms.Form
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x0015D8BC File Offset: 0x0015BABC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormLuomrac));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxAccept = new global::System.Windows.Forms.CheckBox();
			this.buttonDong = new global::System.Windows.Forms.Button();
			this.buttonPhichiendau = new global::System.Windows.Forms.Button();
			this.checkBoxBanTheoThuoctinh = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBoxThoigianTre = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label1.Location = new global::System.Drawing.Point(18, 49);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(555, 269);
			this.label1.TabIndex = 0;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.checkBoxAccept.AutoSize = true;
			this.checkBoxAccept.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxAccept.Location = new global::System.Drawing.Point(141, 626);
			this.checkBoxAccept.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxAccept.Name = "checkBoxAccept";
			this.checkBoxAccept.Size = new global::System.Drawing.Size(130, 24);
			this.checkBoxAccept.TabIndex = 1;
			this.checkBoxAccept.Text = "Tôi đã hiểu rõ";
			this.checkBoxAccept.UseVisualStyleBackColor = true;
			this.checkBoxAccept.CheckedChanged += new global::System.EventHandler(this.checkBoxAccept_CheckedChanged);
			this.buttonDong.Location = new global::System.Drawing.Point(426, 612);
			this.buttonDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDong.Name = "buttonDong";
			this.buttonDong.Size = new global::System.Drawing.Size(146, 49);
			this.buttonDong.TabIndex = 2;
			this.buttonDong.Text = "Đóng";
			this.buttonDong.UseVisualStyleBackColor = true;
			this.buttonDong.Click += new global::System.EventHandler(this.buttonDong_Click);
			this.buttonPhichiendau.Location = new global::System.Drawing.Point(420, 194);
			this.buttonPhichiendau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPhichiendau.Name = "buttonPhichiendau";
			this.buttonPhichiendau.Size = new global::System.Drawing.Size(122, 52);
			this.buttonPhichiendau.TabIndex = 3;
			this.buttonPhichiendau.Text = "Làm phi chiến đấu";
			this.buttonPhichiendau.UseVisualStyleBackColor = true;
			this.buttonPhichiendau.Click += new global::System.EventHandler(this.buttonPhichiendau_Click);
			this.checkBoxBanTheoThuoctinh.AutoSize = true;
			this.checkBoxBanTheoThuoctinh.Location = new global::System.Drawing.Point(22, 14);
			this.checkBoxBanTheoThuoctinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBanTheoThuoctinh.Name = "checkBoxBanTheoThuoctinh";
			this.checkBoxBanTheoThuoctinh.Size = new global::System.Drawing.Size(339, 24);
			this.checkBoxBanTheoThuoctinh.TabIndex = 4;
			this.checkBoxBanTheoThuoctinh.Text = "Bán rác theo bảng thuộc tính Lọc vật phẩm";
			this.checkBoxBanTheoThuoctinh.UseVisualStyleBackColor = true;
			this.checkBoxBanTheoThuoctinh.CheckedChanged += new global::System.EventHandler(this.checkBoxBanTheoThuoctinh_CheckedChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(184, 217);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(135, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Thời gian trễ (ms):";
			this.textBoxThoigianTre.Location = new global::System.Drawing.Point(330, 212);
			this.textBoxThoigianTre.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxThoigianTre.Name = "textBoxThoigianTre";
			this.textBoxThoigianTre.Size = new global::System.Drawing.Size(67, 26);
			this.textBoxThoigianTre.TabIndex = 6;
			this.textBoxThoigianTre.TextChanged += new global::System.EventHandler(this.textBoxThoigianTre_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 43);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(379, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Cách 1: làm thủ công bằng tay (tỉ lệ thành công cao )";
			this.button1.Location = new global::System.Drawing.Point(420, 58);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(122, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "Xem phim";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(16, 68);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(392, 26);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "https://youtu.be/dDYR4Al3LIg";
			this.label4.Location = new global::System.Drawing.Point(12, 134);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(516, 74);
			this.label4.TabIndex = 10;
			this.label4.Text = "Cách 2: để auto tự làm, cách này tỉ lệ thành công thấp. \r\nLưu ý:Nên chỉnh lại <Thời gian trễ> nhỏ xuống hoặc cao hơn nếu làm phi chiến đấu không thành công.";
			this.groupBox1.Controls.Add(this.buttonPhichiendau);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxThoigianTre);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 337);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(566, 258);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cách làm phi chiến đấu";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(582, 669);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.checkBoxBanTheoThuoctinh);
			base.Controls.Add(this.buttonDong);
			base.Controls.Add(this.checkBoxAccept);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormLuomrac";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "LUOM RAC PHI SHOP";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormLuomrac_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A18 RID: 2584
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A19 RID: 2585
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A1A RID: 2586
		private global::System.Windows.Forms.CheckBox checkBoxAccept;

		// Token: 0x04000A1B RID: 2587
		private global::System.Windows.Forms.Button buttonDong;

		// Token: 0x04000A1C RID: 2588
		private global::System.Windows.Forms.Button buttonPhichiendau;

		// Token: 0x04000A1D RID: 2589
		private global::System.Windows.Forms.CheckBox checkBoxBanTheoThuoctinh;

		// Token: 0x04000A1E RID: 2590
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000A1F RID: 2591
		private global::System.Windows.Forms.TextBox textBoxThoigianTre;

		// Token: 0x04000A20 RID: 2592
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000A21 RID: 2593
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000A22 RID: 2594
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000A23 RID: 2595
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000A24 RID: 2596
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A25 RID: 2597
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
