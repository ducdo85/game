namespace AutoKeoxe
{
	// Token: 0x02000088 RID: 136
	public partial class FormTienSkill : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B48 RID: 2888 RVA: 0x00187E44 File Offset: 0x00186044
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTienSkill));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.comboBoxChieuthuc = new global::System.Windows.Forms.ComboBox();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBoxThoigian = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.buttonThuGanChieu = new global::System.Windows.Forms.Button();
			this.comboBoxKieudanh = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxKethop = new global::System.Windows.Forms.CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.checkBoxQuai = new global::System.Windows.Forms.CheckBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.comboBoxHieuUng = new global::System.Windows.Forms.ComboBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.textBoxKhoangCach = new global::System.Windows.Forms.TextBox();
			this.checkBoxDieuchinh = new global::System.Windows.Forms.CheckBox();
			this.textBoxDieuchinh = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.comboBoxChieuthuc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChieuthuc.DropDownWidth = 220;
			this.comboBoxChieuthuc.FormattingEnabled = true;
			this.comboBoxChieuthuc.Location = new global::System.Drawing.Point(114, 223);
			this.comboBoxChieuthuc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxChieuthuc.Name = "comboBoxChieuthuc";
			this.comboBoxChieuthuc.Size = new global::System.Drawing.Size(360, 28);
			this.comboBoxChieuthuc.TabIndex = 11;
			this.comboBoxChieuthuc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxChieuthuc_SelectedIndexChanged);
			this.buttonClose.Location = new global::System.Drawing.Point(484, 568);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(117, 49);
			this.buttonClose.TabIndex = 15;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(174, 315);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(288, 20);
			this.label2.TabIndex = 17;
			this.label2.Text = "Thời gian giữa 2 lần phát tiền chiêu (ms)";
			this.textBoxThoigian.Location = new global::System.Drawing.Point(484, 311);
			this.textBoxThoigian.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxThoigian.Name = "textBoxThoigian";
			this.textBoxThoigian.Size = new global::System.Drawing.Size(88, 26);
			this.textBoxThoigian.TabIndex = 18;
			this.textBoxThoigian.TextChanged += new global::System.EventHandler(this.textBoxThoigian_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(4, 228);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(94, 20);
			this.label3.TabIndex = 21;
			this.label3.Text = "- Tiền chiêu:";
			this.richTextBox1.Location = new global::System.Drawing.Point(2, 2);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(598, 199);
			this.richTextBox1.TabIndex = 22;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.buttonThuGanChieu.Location = new global::System.Drawing.Point(484, 223);
			this.buttonThuGanChieu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThuGanChieu.Name = "buttonThuGanChieu";
			this.buttonThuGanChieu.Size = new global::System.Drawing.Size(117, 58);
			this.buttonThuGanChieu.TabIndex = 23;
			this.buttonThuGanChieu.Text = "Thử gán tay trái";
			this.buttonThuGanChieu.UseVisualStyleBackColor = true;
			this.buttonThuGanChieu.Click += new global::System.EventHandler(this.buttonThuGanChieu_Click);
			this.comboBoxKieudanh.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKieudanh.DropDownWidth = 220;
			this.comboBoxKieudanh.FormattingEnabled = true;
			this.comboBoxKieudanh.Location = new global::System.Drawing.Point(114, 263);
			this.comboBoxKieudanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxKieudanh.Name = "comboBoxKieudanh";
			this.comboBoxKieudanh.Size = new global::System.Drawing.Size(360, 28);
			this.comboBoxKieudanh.TabIndex = 24;
			this.comboBoxKieudanh.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxKieudanh_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 268);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(93, 20);
			this.label1.TabIndex = 25;
			this.label1.Text = "- Kiểu đánh:";
			this.checkBoxKethop.AutoSize = true;
			this.checkBoxKethop.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxKethop.Location = new global::System.Drawing.Point(9, 535);
			this.checkBoxKethop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKethop.Name = "checkBoxKethop";
			this.checkBoxKethop.Size = new global::System.Drawing.Size(344, 24);
			this.checkBoxKethop.TabIndex = 26;
			this.checkBoxKethop.Text = "Phát tiền chiêu theo kiểu nhấn phím kết hợp";
			this.checkBoxKethop.UseVisualStyleBackColor = true;
			this.checkBoxKethop.CheckedChanged += new global::System.EventHandler(this.checkBoxKethop_CheckedChanged);
			this.label4.ForeColor = global::System.Drawing.Color.DimGray;
			this.label4.Location = new global::System.Drawing.Point(10, 577);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(434, 46);
			this.label4.TabIndex = 27;
			this.label4.Text = "Một số chiêu thức không thể đánh bình thường mả phải kết hợp, các bạn hãy test để biết tiền chiêu là loại nào nhé";
			this.checkBoxQuai.AutoSize = true;
			this.checkBoxQuai.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.checkBoxQuai.Location = new global::System.Drawing.Point(9, 492);
			this.checkBoxQuai.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxQuai.Name = "checkBoxQuai";
			this.checkBoxQuai.Size = new global::System.Drawing.Size(443, 24);
			this.checkBoxQuai.TabIndex = 28;
			this.checkBoxQuai.Text = "Đánh cả quái và boss (nếu không chọn thì chỉ đánh người)";
			this.checkBoxQuai.UseVisualStyleBackColor = true;
			this.checkBoxQuai.CheckedChanged += new global::System.EventHandler(this.checkBoxQuai_CheckedChanged);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(194, 395);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(264, 20);
			this.label5.TabIndex = 29;
			this.label5.Text = "Thời gian khôi phục chiêu thức (giây)";
			this.comboBoxHieuUng.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxHieuUng.FormattingEnabled = true;
			this.comboBoxHieuUng.Location = new global::System.Drawing.Point(484, 391);
			this.comboBoxHieuUng.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxHieuUng.Name = "comboBoxHieuUng";
			this.comboBoxHieuUng.Size = new global::System.Drawing.Size(88, 28);
			this.comboBoxHieuUng.TabIndex = 30;
			this.comboBoxHieuUng.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxHieuUng_SelectedIndexChanged);
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(153, 355);
			this.label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(304, 20);
			this.label6.TabIndex = 31;
			this.label6.Text = "Không phát tiền chiêu khi khoảng cách <=";
			this.textBoxKhoangCach.Location = new global::System.Drawing.Point(484, 351);
			this.textBoxKhoangCach.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxKhoangCach.Name = "textBoxKhoangCach";
			this.textBoxKhoangCach.Size = new global::System.Drawing.Size(88, 26);
			this.textBoxKhoangCach.TabIndex = 32;
			this.textBoxKhoangCach.TextChanged += new global::System.EventHandler(this.textBoxKhoangCach_TextChanged);
			this.checkBoxDieuchinh.AutoSize = true;
			this.checkBoxDieuchinh.Location = new global::System.Drawing.Point(9, 445);
			this.checkBoxDieuchinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDieuchinh.Name = "checkBoxDieuchinh";
			this.checkBoxDieuchinh.Size = new global::System.Drawing.Size(449, 24);
			this.checkBoxDieuchinh.TabIndex = 33;
			this.checkBoxDieuchinh.Text = "Điều chỉnh lại khoảng cách tìm ac chính để ac không bị giật";
			this.checkBoxDieuchinh.UseVisualStyleBackColor = true;
			this.checkBoxDieuchinh.CheckedChanged += new global::System.EventHandler(this.checkBoxDieuchinh_CheckedChanged);
			this.textBoxDieuchinh.Location = new global::System.Drawing.Point(484, 442);
			this.textBoxDieuchinh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDieuchinh.Name = "textBoxDieuchinh";
			this.textBoxDieuchinh.Size = new global::System.Drawing.Size(88, 26);
			this.textBoxDieuchinh.TabIndex = 34;
			this.textBoxDieuchinh.TextChanged += new global::System.EventHandler(this.textBoxDieuchinh_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(606, 631);
			base.Controls.Add(this.textBoxDieuchinh);
			base.Controls.Add(this.checkBoxDieuchinh);
			base.Controls.Add(this.textBoxKhoangCach);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.comboBoxHieuUng);
			base.Controls.Add(this.comboBoxKieudanh);
			base.Controls.Add(this.textBoxThoigian);
			base.Controls.Add(this.comboBoxChieuthuc);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.checkBoxQuai);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.checkBoxKethop);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonThuGanChieu);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTienSkill";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TIỀN CHIÊU";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTienSkill_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CAC RID: 3244
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CAD RID: 3245
		private global::System.Windows.Forms.ComboBox comboBoxChieuthuc;

		// Token: 0x04000CAE RID: 3246
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000CAF RID: 3247
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000CB0 RID: 3248
		private global::System.Windows.Forms.TextBox textBoxThoigian;

		// Token: 0x04000CB1 RID: 3249
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000CB2 RID: 3250
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000CB3 RID: 3251
		private global::System.Windows.Forms.Button buttonThuGanChieu;

		// Token: 0x04000CB4 RID: 3252
		private global::System.Windows.Forms.ComboBox comboBoxKieudanh;

		// Token: 0x04000CB5 RID: 3253
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000CB6 RID: 3254
		private global::System.Windows.Forms.CheckBox checkBoxKethop;

		// Token: 0x04000CB7 RID: 3255
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000CB8 RID: 3256
		private global::System.Windows.Forms.CheckBox checkBoxQuai;

		// Token: 0x04000CB9 RID: 3257
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000CBA RID: 3258
		private global::System.Windows.Forms.ComboBox comboBoxHieuUng;

		// Token: 0x04000CBB RID: 3259
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000CBC RID: 3260
		private global::System.Windows.Forms.TextBox textBoxKhoangCach;

		// Token: 0x04000CBD RID: 3261
		private global::System.Windows.Forms.CheckBox checkBoxDieuchinh;

		// Token: 0x04000CBE RID: 3262
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000CBF RID: 3263
		private global::System.Windows.Forms.TextBox textBoxDieuchinh;
	}
}
