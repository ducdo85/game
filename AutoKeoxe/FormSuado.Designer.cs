namespace AutoKeoxe
{
	// Token: 0x02000082 RID: 130
	public partial class FormSuado : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x00178D48 File Offset: 0x00176F48
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormSuado));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.checkBoxOutGameKhidobenThap = new global::System.Windows.Forms.CheckBox();
			this.textBoxValueDobenThap = new global::System.Windows.Forms.TextBox();
			this.checkBoxThodiaphuDobenThap = new global::System.Windows.Forms.CheckBox();
			this.checkBoxKhongSuaTK = new global::System.Windows.Forms.CheckBox();
			this.checkBoxLuonSuaKhiMuathuoc = new global::System.Windows.Forms.CheckBox();
			this.checkBoxBachKim = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxPhanTram = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBoxDiem = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxPhiChiendau = new global::System.Windows.Forms.CheckBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.checkBoxPhimTat = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.checkBoxOutGameKhidobenThap.AutoSize = true;
			this.checkBoxOutGameKhidobenThap.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxOutGameKhidobenThap.Location = new global::System.Drawing.Point(8, 211);
			this.checkBoxOutGameKhidobenThap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxOutGameKhidobenThap.Name = "checkBoxOutGameKhidobenThap";
			this.checkBoxOutGameKhidobenThap.Size = new global::System.Drawing.Size(302, 24);
			this.checkBoxOutGameKhidobenThap.TabIndex = 174;
			this.checkBoxOutGameKhidobenThap.Text = "Thoát game khi không thể thổ địa phù";
			this.checkBoxOutGameKhidobenThap.UseVisualStyleBackColor = true;
			this.checkBoxOutGameKhidobenThap.CheckedChanged += new global::System.EventHandler(this.checkBoxOutGameKhidobenThap_CheckedChanged);
			this.textBoxValueDobenThap.Location = new global::System.Drawing.Point(330, 172);
			this.textBoxValueDobenThap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxValueDobenThap.Name = "textBoxValueDobenThap";
			this.textBoxValueDobenThap.Size = new global::System.Drawing.Size(52, 26);
			this.textBoxValueDobenThap.TabIndex = 146;
			this.textBoxValueDobenThap.TextChanged += new global::System.EventHandler(this.textBoxValueDobenThap_TextChanged);
			this.checkBoxThodiaphuDobenThap.AutoSize = true;
			this.checkBoxThodiaphuDobenThap.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxThodiaphuDobenThap.Location = new global::System.Drawing.Point(8, 172);
			this.checkBoxThodiaphuDobenThap.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxThodiaphuDobenThap.Name = "checkBoxThodiaphuDobenThap";
			this.checkBoxThodiaphuDobenThap.Size = new global::System.Drawing.Size(300, 24);
			this.checkBoxThodiaphuDobenThap.TabIndex = 173;
			this.checkBoxThodiaphuDobenThap.Text = "Thổ địa phù khi độ bền xuống thấp <=";
			this.checkBoxThodiaphuDobenThap.UseVisualStyleBackColor = true;
			this.checkBoxThodiaphuDobenThap.CheckedChanged += new global::System.EventHandler(this.checkBoxThodiaphuDobenThap_CheckedChanged);
			this.checkBoxKhongSuaTK.AutoSize = true;
			this.checkBoxKhongSuaTK.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.checkBoxKhongSuaTK.Location = new global::System.Drawing.Point(8, 42);
			this.checkBoxKhongSuaTK.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongSuaTK.Name = "checkBoxKhongSuaTK";
			this.checkBoxKhongSuaTK.Size = new global::System.Drawing.Size(278, 24);
			this.checkBoxKhongSuaTK.TabIndex = 334;
			this.checkBoxKhongSuaTK.Text = "Không sửa khi mua thuốc tống kim";
			this.checkBoxKhongSuaTK.UseVisualStyleBackColor = true;
			this.checkBoxKhongSuaTK.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongSuaTK_CheckedChanged);
			this.checkBoxLuonSuaKhiMuathuoc.AutoSize = true;
			this.checkBoxLuonSuaKhiMuathuoc.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.checkBoxLuonSuaKhiMuathuoc.Location = new global::System.Drawing.Point(8, 6);
			this.checkBoxLuonSuaKhiMuathuoc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLuonSuaKhiMuathuoc.Name = "checkBoxLuonSuaKhiMuathuoc";
			this.checkBoxLuonSuaKhiMuathuoc.Size = new global::System.Drawing.Size(335, 24);
			this.checkBoxLuonSuaKhiMuathuoc.TabIndex = 335;
			this.checkBoxLuonSuaKhiMuathuoc.Text = "Luôn sửa trang bị khi mua thuốc, tạp hóa...";
			this.checkBoxLuonSuaKhiMuathuoc.UseVisualStyleBackColor = true;
			this.checkBoxLuonSuaKhiMuathuoc.CheckedChanged += new global::System.EventHandler(this.checkBoxLuonSuaKhiMuathuoc_CheckedChanged);
			this.checkBoxBachKim.AutoSize = true;
			this.checkBoxBachKim.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxBachKim.Location = new global::System.Drawing.Point(8, 134);
			this.checkBoxBachKim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBachKim.Name = "checkBoxBachKim";
			this.checkBoxBachKim.Size = new global::System.Drawing.Size(338, 24);
			this.checkBoxBachKim.TabIndex = 337;
			this.checkBoxBachKim.Text = "Sửa đồ bạch kim (+6 trở đi auto không sửa)";
			this.checkBoxBachKim.UseVisualStyleBackColor = true;
			this.checkBoxBachKim.CheckedChanged += new global::System.EventHandler(this.checkBoxBachKim_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(46, 266);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(212, 20);
			this.label1.TabIndex = 339;
			this.label1.Text = "Sửa khi độ bền xuống còn ....";
			this.textBoxPhanTram.Location = new global::System.Drawing.Point(279, 262);
			this.textBoxPhanTram.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPhanTram.Name = "textBoxPhanTram";
			this.textBoxPhanTram.Size = new global::System.Drawing.Size(43, 26);
			this.textBoxPhanTram.TabIndex = 340;
			this.textBoxPhanTram.TextChanged += new global::System.EventHandler(this.textBoxPhanTram_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(333, 266);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(37, 20);
			this.label2.TabIndex = 341;
			this.label2.Text = "( %)";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(201, 302);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(66, 20);
			this.label3.TabIndex = 343;
			this.label3.Text = "hoặc <=";
			this.textBoxDiem.Location = new global::System.Drawing.Point(279, 297);
			this.textBoxDiem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDiem.Name = "textBoxDiem";
			this.textBoxDiem.Size = new global::System.Drawing.Size(43, 26);
			this.textBoxDiem.TabIndex = 342;
			this.textBoxDiem.TextChanged += new global::System.EventHandler(this.textBoxDiem_TextChanged);
			this.textBoxDiem.Leave += new global::System.EventHandler(this.textBoxDiem_Leave);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(333, 302);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(57, 20);
			this.label4.TabIndex = 344;
			this.label4.Text = "( điểm)";
			this.buttonClose.Location = new global::System.Drawing.Point(256, 454);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(128, 40);
			this.buttonClose.TabIndex = 346;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxPhiChiendau.AutoSize = true;
			this.checkBoxPhiChiendau.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.checkBoxPhiChiendau.Location = new global::System.Drawing.Point(8, 75);
			this.checkBoxPhiChiendau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhiChiendau.Name = "checkBoxPhiChiendau";
			this.checkBoxPhiChiendau.Size = new global::System.Drawing.Size(222, 24);
			this.checkBoxPhiChiendau.TabIndex = 347;
			this.checkBoxPhiChiendau.Text = "Sửa đồ ở nơi phi chiến đấu";
			this.checkBoxPhiChiendau.UseVisualStyleBackColor = true;
			this.checkBoxPhiChiendau.CheckedChanged += new global::System.EventHandler(this.checkBoxPhiChiendau_CheckedChanged);
			this.textBox1.Location = new global::System.Drawing.Point(279, 337);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(43, 26);
			this.textBox1.TabIndex = 349;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(4, 342);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(257, 20);
			this.label5.TabIndex = 348;
			this.label5.Text = "Thời gian giữa 2 lần kiểm tra sửa đồ";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(333, 343);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(51, 20);
			this.label6.TabIndex = 350;
			this.label6.Text = "( giây)";
			this.checkBoxPhimTat.AutoSize = true;
			this.checkBoxPhimTat.Location = new global::System.Drawing.Point(8, 402);
			this.checkBoxPhimTat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhimTat.Name = "checkBoxPhimTat";
			this.checkBoxPhimTat.Size = new global::System.Drawing.Size(372, 24);
			this.checkBoxPhimTat.TabIndex = 351;
			this.checkBoxPhimTat.Text = "Sử dụng phím tắt CTRL + ALT để sửa đồ tại chỗ";
			this.checkBoxPhimTat.UseVisualStyleBackColor = true;
			this.checkBoxPhimTat.CheckedChanged += new global::System.EventHandler(this.checkBoxPhimTat_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(406, 512);
			base.Controls.Add(this.checkBoxPhimTat);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.checkBoxPhiChiendau);
			base.Controls.Add(this.textBoxDiem);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.textBoxPhanTram);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.checkBoxOutGameKhidobenThap);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.checkBoxThodiaphuDobenThap);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBoxBachKim);
			base.Controls.Add(this.textBoxValueDobenThap);
			base.Controls.Add(this.checkBoxLuonSuaKhiMuathuoc);
			base.Controls.Add(this.checkBoxKhongSuaTK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormSuado";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Sua do";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormSuado_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000BA8 RID: 2984
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000BA9 RID: 2985
		private global::System.Windows.Forms.CheckBox checkBoxOutGameKhidobenThap;

		// Token: 0x04000BAA RID: 2986
		private global::System.Windows.Forms.TextBox textBoxValueDobenThap;

		// Token: 0x04000BAB RID: 2987
		private global::System.Windows.Forms.CheckBox checkBoxThodiaphuDobenThap;

		// Token: 0x04000BAC RID: 2988
		private global::System.Windows.Forms.CheckBox checkBoxKhongSuaTK;

		// Token: 0x04000BAD RID: 2989
		private global::System.Windows.Forms.CheckBox checkBoxLuonSuaKhiMuathuoc;

		// Token: 0x04000BAE RID: 2990
		private global::System.Windows.Forms.CheckBox checkBoxBachKim;

		// Token: 0x04000BAF RID: 2991
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BB0 RID: 2992
		private global::System.Windows.Forms.TextBox textBoxPhanTram;

		// Token: 0x04000BB1 RID: 2993
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000BB2 RID: 2994
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000BB3 RID: 2995
		private global::System.Windows.Forms.TextBox textBoxDiem;

		// Token: 0x04000BB4 RID: 2996
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000BB5 RID: 2997
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000BB6 RID: 2998
		private global::System.Windows.Forms.CheckBox checkBoxPhiChiendau;

		// Token: 0x04000BB7 RID: 2999
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000BB8 RID: 3000
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000BB9 RID: 3001
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000BBA RID: 3002
		private global::System.Windows.Forms.CheckBox checkBoxPhimTat;

		// Token: 0x04000BBC RID: 3004
		private global::System.ComponentModel.IContainer components;
	}
}
