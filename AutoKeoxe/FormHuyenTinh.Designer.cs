namespace AutoKeoxe
{
	// Token: 0x02000070 RID: 112
	public partial class FormHuyenTinh : global::System.Windows.Forms.Form
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x0014A6B0 File Offset: 0x001488B0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormHuyenTinh));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.linkLabelPhimCheTaoHT = new global::System.Windows.Forms.LinkLabel();
			this.linkLabelHDHT = new global::System.Windows.Forms.LinkLabel();
			this.buttonDungChetao = new global::System.Windows.Forms.Button();
			this.checkBoxC8 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC7 = new global::System.Windows.Forms.CheckBox();
			this.buttonChetaoHuyentinh = new global::System.Windows.Forms.Button();
			this.checkBoxC1 = new global::System.Windows.Forms.CheckBox();
			this.buttonStopNangcapHT = new global::System.Windows.Forms.Button();
			this.checkBoxNguyenlieuBH = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC3 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC9 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC6 = new global::System.Windows.Forms.CheckBox();
			this.buttonBatdauNangcap = new global::System.Windows.Forms.Button();
			this.checkBoxC4 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC2 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxC5 = new global::System.Windows.Forms.CheckBox();
			this.textBoxHT = new global::System.Windows.Forms.TextBox();
			this.groupBoxNangCap = new global::System.Windows.Forms.GroupBox();
			this.groupBoxNangCap.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonClose.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.ForeColor = global::System.Drawing.Color.Black;
			this.buttonClose.Location = new global::System.Drawing.Point(240, 232);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(76, 36);
			this.buttonClose.TabIndex = 139;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.linkLabelPhimCheTaoHT.AutoSize = true;
			this.linkLabelPhimCheTaoHT.Location = new global::System.Drawing.Point(3, 213);
			this.linkLabelPhimCheTaoHT.Name = "linkLabelPhimCheTaoHT";
			this.linkLabelPhimCheTaoHT.Size = new global::System.Drawing.Size(94, 21);
			this.linkLabelPhimCheTaoHT.TabIndex = 164;
			this.linkLabelPhimCheTaoHT.TabStop = true;
			this.linkLabelPhimCheTaoHT.Text = "Phim H.dẫn";
			this.linkLabelPhimCheTaoHT.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPhimCheTaoHT_LinkClicked);
			this.linkLabelHDHT.AutoSize = true;
			this.linkLabelHDHT.Location = new global::System.Drawing.Point(3, 190);
			this.linkLabelHDHT.Name = "linkLabelHDHT";
			this.linkLabelHDHT.Size = new global::System.Drawing.Size(90, 21);
			this.linkLabelHDHT.TabIndex = 163;
			this.linkLabelHDHT.TabStop = true;
			this.linkLabelHDHT.Text = "Hướng dẫn";
			this.linkLabelHDHT.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHDHT_LinkClicked);
			this.buttonDungChetao.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.buttonDungChetao.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.buttonDungChetao.Location = new global::System.Drawing.Point(154, 232);
			this.buttonDungChetao.Name = "buttonDungChetao";
			this.buttonDungChetao.Size = new global::System.Drawing.Size(80, 36);
			this.buttonDungChetao.TabIndex = 12;
			this.buttonDungChetao.Text = "Dừng chế tạo";
			this.buttonDungChetao.UseVisualStyleBackColor = false;
			this.buttonDungChetao.Click += new global::System.EventHandler(this.buttonDungChetao_Click);
			this.checkBoxC8.AutoSize = true;
			this.checkBoxC8.Location = new global::System.Drawing.Point(202, 53);
			this.checkBoxC8.Name = "checkBoxC8";
			this.checkBoxC8.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC8.TabIndex = 8;
			this.checkBoxC8.Text = "Cấp 8 -> 9";
			this.checkBoxC8.UseVisualStyleBackColor = true;
			this.checkBoxC8.CheckedChanged += new global::System.EventHandler(this.checkBoxC8_CheckedChanged);
			this.checkBoxC7.AutoSize = true;
			this.checkBoxC7.Location = new global::System.Drawing.Point(202, 30);
			this.checkBoxC7.Name = "checkBoxC7";
			this.checkBoxC7.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC7.TabIndex = 7;
			this.checkBoxC7.Text = "Cấp 7 -> 8";
			this.checkBoxC7.UseVisualStyleBackColor = true;
			this.checkBoxC7.CheckedChanged += new global::System.EventHandler(this.checkBoxC7_CheckedChanged);
			this.buttonChetaoHuyentinh.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.buttonChetaoHuyentinh.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.buttonChetaoHuyentinh.Location = new global::System.Drawing.Point(68, 232);
			this.buttonChetaoHuyentinh.Name = "buttonChetaoHuyentinh";
			this.buttonChetaoHuyentinh.Size = new global::System.Drawing.Size(80, 36);
			this.buttonChetaoHuyentinh.TabIndex = 11;
			this.buttonChetaoHuyentinh.Text = "Bắt đầu chế tạo";
			this.buttonChetaoHuyentinh.UseVisualStyleBackColor = false;
			this.buttonChetaoHuyentinh.Click += new global::System.EventHandler(this.buttonChetaoHuyentinh_Click);
			this.checkBoxC1.AutoSize = true;
			this.checkBoxC1.Location = new global::System.Drawing.Point(12, 30);
			this.checkBoxC1.Name = "checkBoxC1";
			this.checkBoxC1.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC1.TabIndex = 1;
			this.checkBoxC1.Text = "Cấp 1 -> 2";
			this.checkBoxC1.UseVisualStyleBackColor = true;
			this.checkBoxC1.CheckedChanged += new global::System.EventHandler(this.checkBoxC1_CheckedChanged);
			this.buttonStopNangcapHT.Location = new global::System.Drawing.Point(154, 190);
			this.buttonStopNangcapHT.Name = "buttonStopNangcapHT";
			this.buttonStopNangcapHT.Size = new global::System.Drawing.Size(80, 36);
			this.buttonStopNangcapHT.TabIndex = 11;
			this.buttonStopNangcapHT.Text = "Dừng nâng cấp";
			this.buttonStopNangcapHT.UseVisualStyleBackColor = true;
			this.buttonStopNangcapHT.Click += new global::System.EventHandler(this.buttonStopNangcapHT_Click);
			this.checkBoxNguyenlieuBH.AutoSize = true;
			this.checkBoxNguyenlieuBH.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxNguyenlieuBH.Location = new global::System.Drawing.Point(12, 108);
			this.checkBoxNguyenlieuBH.Name = "checkBoxNguyenlieuBH";
			this.checkBoxNguyenlieuBH.Size = new global::System.Drawing.Size(428, 25);
			this.checkBoxNguyenlieuBH.TabIndex = 13;
			this.checkBoxNguyenlieuBH.Text = "Có lấy nguyên liệu trong rương bang hội đem chế tạo";
			this.checkBoxNguyenlieuBH.UseVisualStyleBackColor = true;
			this.checkBoxNguyenlieuBH.CheckedChanged += new global::System.EventHandler(this.checkBoxNguyenlieuBH_CheckedChanged);
			this.checkBoxC3.AutoSize = true;
			this.checkBoxC3.Location = new global::System.Drawing.Point(12, 76);
			this.checkBoxC3.Name = "checkBoxC3";
			this.checkBoxC3.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC3.TabIndex = 3;
			this.checkBoxC3.Text = "Cấp 3 -> 4";
			this.checkBoxC3.UseVisualStyleBackColor = true;
			this.checkBoxC3.CheckedChanged += new global::System.EventHandler(this.checkBoxC3_CheckedChanged);
			this.checkBoxC9.AutoSize = true;
			this.checkBoxC9.Location = new global::System.Drawing.Point(202, 76);
			this.checkBoxC9.Name = "checkBoxC9";
			this.checkBoxC9.Size = new global::System.Drawing.Size(124, 25);
			this.checkBoxC9.TabIndex = 9;
			this.checkBoxC9.Text = "Cấp 9 -> 10";
			this.checkBoxC9.UseVisualStyleBackColor = true;
			this.checkBoxC9.CheckedChanged += new global::System.EventHandler(this.checkBoxC9_CheckedChanged);
			this.checkBoxC6.AutoSize = true;
			this.checkBoxC6.Location = new global::System.Drawing.Point(104, 76);
			this.checkBoxC6.Name = "checkBoxC6";
			this.checkBoxC6.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC6.TabIndex = 6;
			this.checkBoxC6.Text = "Cấp 6 -> 7";
			this.checkBoxC6.UseVisualStyleBackColor = true;
			this.checkBoxC6.CheckedChanged += new global::System.EventHandler(this.checkBoxC6_CheckedChanged);
			this.buttonBatdauNangcap.Location = new global::System.Drawing.Point(68, 190);
			this.buttonBatdauNangcap.Name = "buttonBatdauNangcap";
			this.buttonBatdauNangcap.Size = new global::System.Drawing.Size(80, 36);
			this.buttonBatdauNangcap.TabIndex = 10;
			this.buttonBatdauNangcap.Text = "Bắt đầu nâng cấp";
			this.buttonBatdauNangcap.UseVisualStyleBackColor = true;
			this.buttonBatdauNangcap.Click += new global::System.EventHandler(this.buttonBatdauNangcap_Click);
			this.checkBoxC4.AutoSize = true;
			this.checkBoxC4.Location = new global::System.Drawing.Point(104, 30);
			this.checkBoxC4.Name = "checkBoxC4";
			this.checkBoxC4.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC4.TabIndex = 4;
			this.checkBoxC4.Text = "Cấp 4 -> 5";
			this.checkBoxC4.UseVisualStyleBackColor = true;
			this.checkBoxC4.CheckedChanged += new global::System.EventHandler(this.checkBoxC4_CheckedChanged);
			this.checkBoxC2.AutoSize = true;
			this.checkBoxC2.Location = new global::System.Drawing.Point(12, 53);
			this.checkBoxC2.Name = "checkBoxC2";
			this.checkBoxC2.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC2.TabIndex = 2;
			this.checkBoxC2.Text = "Cấp 2 -> 3";
			this.checkBoxC2.UseVisualStyleBackColor = true;
			this.checkBoxC2.CheckedChanged += new global::System.EventHandler(this.checkBoxC2_CheckedChanged);
			this.checkBoxC5.AutoSize = true;
			this.checkBoxC5.Location = new global::System.Drawing.Point(104, 53);
			this.checkBoxC5.Name = "checkBoxC5";
			this.checkBoxC5.Size = new global::System.Drawing.Size(115, 25);
			this.checkBoxC5.TabIndex = 5;
			this.checkBoxC5.Text = "Cấp 5 -> 6";
			this.checkBoxC5.UseVisualStyleBackColor = true;
			this.checkBoxC5.CheckedChanged += new global::System.EventHandler(this.checkBoxC5_CheckedChanged);
			this.textBoxHT.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBoxHT.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxHT.Location = new global::System.Drawing.Point(6, 161);
			this.textBoxHT.Name = "textBoxHT";
			this.textBoxHT.Size = new global::System.Drawing.Size(310, 20);
			this.textBoxHT.TabIndex = 13;
			this.textBoxHT.Text = "Thông tin: ...";
			this.groupBoxNangCap.Controls.Add(this.checkBoxC8);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC7);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC1);
			this.groupBoxNangCap.Controls.Add(this.checkBoxNguyenlieuBH);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC5);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC3);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC2);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC9);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC4);
			this.groupBoxNangCap.Controls.Add(this.checkBoxC6);
			this.groupBoxNangCap.Location = new global::System.Drawing.Point(6, 12);
			this.groupBoxNangCap.Name = "groupBoxNangCap";
			this.groupBoxNangCap.Size = new global::System.Drawing.Size(310, 143);
			this.groupBoxNangCap.TabIndex = 166;
			this.groupBoxNangCap.TabStop = false;
			this.groupBoxNangCap.Text = "CHẾ TẠO VÀ NÂNG CẤP HUYỀN TINH";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 21f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(324, 275);
			base.Controls.Add(this.groupBoxNangCap);
			base.Controls.Add(this.buttonDungChetao);
			base.Controls.Add(this.linkLabelHDHT);
			base.Controls.Add(this.linkLabelPhimCheTaoHT);
			base.Controls.Add(this.buttonChetaoHuyentinh);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.textBoxHT);
			base.Controls.Add(this.buttonStopNangcapHT);
			base.Controls.Add(this.buttonBatdauNangcap);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormHuyenTinh";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HUYEN TINH";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormHuyenTinh_Load);
			this.groupBoxNangCap.ResumeLayout(false);
			this.groupBoxNangCap.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008FA RID: 2298
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040008FB RID: 2299
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040008FC RID: 2300
		private global::System.Windows.Forms.LinkLabel linkLabelPhimCheTaoHT;

		// Token: 0x040008FD RID: 2301
		private global::System.Windows.Forms.LinkLabel linkLabelHDHT;

		// Token: 0x040008FE RID: 2302
		private global::System.Windows.Forms.Button buttonDungChetao;

		// Token: 0x040008FF RID: 2303
		private global::System.Windows.Forms.CheckBox checkBoxC8;

		// Token: 0x04000900 RID: 2304
		private global::System.Windows.Forms.CheckBox checkBoxC7;

		// Token: 0x04000901 RID: 2305
		private global::System.Windows.Forms.Button buttonChetaoHuyentinh;

		// Token: 0x04000902 RID: 2306
		private global::System.Windows.Forms.CheckBox checkBoxC1;

		// Token: 0x04000903 RID: 2307
		private global::System.Windows.Forms.Button buttonStopNangcapHT;

		// Token: 0x04000904 RID: 2308
		private global::System.Windows.Forms.CheckBox checkBoxNguyenlieuBH;

		// Token: 0x04000905 RID: 2309
		private global::System.Windows.Forms.CheckBox checkBoxC3;

		// Token: 0x04000906 RID: 2310
		private global::System.Windows.Forms.CheckBox checkBoxC9;

		// Token: 0x04000907 RID: 2311
		private global::System.Windows.Forms.CheckBox checkBoxC6;

		// Token: 0x04000908 RID: 2312
		private global::System.Windows.Forms.Button buttonBatdauNangcap;

		// Token: 0x04000909 RID: 2313
		private global::System.Windows.Forms.CheckBox checkBoxC4;

		// Token: 0x0400090A RID: 2314
		private global::System.Windows.Forms.CheckBox checkBoxC2;

		// Token: 0x0400090B RID: 2315
		private global::System.Windows.Forms.CheckBox checkBoxC5;

		// Token: 0x0400090C RID: 2316
		private global::System.Windows.Forms.TextBox textBoxHT;

		// Token: 0x0400090D RID: 2317
		private global::System.Windows.Forms.GroupBox groupBoxNangCap;

		// Token: 0x04000910 RID: 2320
		private global::System.ComponentModel.IContainer components;
	}
}
