namespace AutoKeoxe
{
	// Token: 0x0200006E RID: 110
	public partial class FormDuongMon : global::System.Windows.Forms.Form
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x001458D4 File Offset: 0x00143AD4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormDuongMon));
			this.checkBoxPhim1 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxPhim2 = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxPhim3 = new global::System.Windows.Forms.CheckBox();
			this.checkBoxDatXungQuanh = new global::System.Windows.Forms.CheckBox();
			this.textBoxKhoangCach = new global::System.Windows.Forms.TextBox();
			this.comboBoxBoom2 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxBoom1 = new global::System.Windows.Forms.ComboBox();
			this.comboBoxBoom3 = new global::System.Windows.Forms.ComboBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.comboBoxTenAc = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.comboBoxSolanNhoiboom = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.checkBoxPhim1.AutoSize = true;
			this.checkBoxPhim1.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxPhim1.Location = new global::System.Drawing.Point(21, 28);
			this.checkBoxPhim1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhim1.Name = "checkBoxPhim1";
			this.checkBoxPhim1.Size = new global::System.Drawing.Size(90, 24);
			this.checkBoxPhim1.TabIndex = 0;
			this.checkBoxPhim1.Text = "Boom 1";
			this.checkBoxPhim1.UseVisualStyleBackColor = true;
			this.checkBoxPhim1.CheckedChanged += new global::System.EventHandler(this.checkBoxPhim1_CheckedChanged);
			this.checkBoxPhim2.AutoSize = true;
			this.checkBoxPhim2.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxPhim2.Location = new global::System.Drawing.Point(21, 66);
			this.checkBoxPhim2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhim2.Name = "checkBoxPhim2";
			this.checkBoxPhim2.Size = new global::System.Drawing.Size(90, 24);
			this.checkBoxPhim2.TabIndex = 1;
			this.checkBoxPhim2.Text = "Boom 2";
			this.checkBoxPhim2.UseVisualStyleBackColor = true;
			this.checkBoxPhim2.CheckedChanged += new global::System.EventHandler(this.checkBoxPhim2_CheckedChanged);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(141, 451);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(150, 40);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "OK";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxPhim3.AutoSize = true;
			this.checkBoxPhim3.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxPhim3.Location = new global::System.Drawing.Point(21, 108);
			this.checkBoxPhim3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhim3.Name = "checkBoxPhim3";
			this.checkBoxPhim3.Size = new global::System.Drawing.Size(90, 24);
			this.checkBoxPhim3.TabIndex = 332;
			this.checkBoxPhim3.Text = "Boom 3";
			this.checkBoxPhim3.UseVisualStyleBackColor = true;
			this.checkBoxPhim3.CheckedChanged += new global::System.EventHandler(this.checkBoxPhim3_CheckedChanged);
			this.checkBoxDatXungQuanh.AutoSize = true;
			this.checkBoxDatXungQuanh.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxDatXungQuanh.Location = new global::System.Drawing.Point(26, 405);
			this.checkBoxDatXungQuanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxDatXungQuanh.Name = "checkBoxDatXungQuanh";
			this.checkBoxDatXungQuanh.Size = new global::System.Drawing.Size(255, 24);
			this.checkBoxDatXungQuanh.TabIndex = 334;
			this.checkBoxDatXungQuanh.Text = "Đặt boom xung quanh ac chính";
			this.checkBoxDatXungQuanh.UseVisualStyleBackColor = true;
			this.checkBoxDatXungQuanh.CheckedChanged += new global::System.EventHandler(this.checkBoxDatXungQuanh_CheckedChanged);
			this.textBoxKhoangCach.Location = new global::System.Drawing.Point(310, 402);
			this.textBoxKhoangCach.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxKhoangCach.Name = "textBoxKhoangCach";
			this.textBoxKhoangCach.Size = new global::System.Drawing.Size(73, 26);
			this.textBoxKhoangCach.TabIndex = 335;
			this.textBoxKhoangCach.TextChanged += new global::System.EventHandler(this.textBoxKhoangCach_TextChanged);
			this.comboBoxBoom2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBoom2.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxBoom2.FormattingEnabled = true;
			this.comboBoxBoom2.Location = new global::System.Drawing.Point(142, 65);
			this.comboBoxBoom2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxBoom2.Name = "comboBoxBoom2";
			this.comboBoxBoom2.Size = new global::System.Drawing.Size(208, 28);
			this.comboBoxBoom2.TabIndex = 353;
			this.comboBoxBoom2.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxBoom2_SelectedIndexChanged);
			this.comboBoxBoom1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBoom1.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxBoom1.FormattingEnabled = true;
			this.comboBoxBoom1.Location = new global::System.Drawing.Point(142, 28);
			this.comboBoxBoom1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxBoom1.Name = "comboBoxBoom1";
			this.comboBoxBoom1.Size = new global::System.Drawing.Size(208, 28);
			this.comboBoxBoom1.TabIndex = 352;
			this.comboBoxBoom1.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxBoom1_SelectedIndexChanged);
			this.comboBoxBoom3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBoom3.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxBoom3.FormattingEnabled = true;
			this.comboBoxBoom3.Location = new global::System.Drawing.Point(142, 102);
			this.comboBoxBoom3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxBoom3.Name = "comboBoxBoom3";
			this.comboBoxBoom3.Size = new global::System.Drawing.Size(208, 28);
			this.comboBoxBoom3.TabIndex = 354;
			this.comboBoxBoom3.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxBoom3_SelectedIndexChanged);
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 5);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(379, 138);
			this.richTextBox1.TabIndex = 355;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.comboBoxTenAc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTenAc.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxTenAc.FormattingEnabled = true;
			this.comboBoxTenAc.Location = new global::System.Drawing.Point(147, 154);
			this.comboBoxTenAc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenAc.Name = "comboBoxTenAc";
			this.comboBoxTenAc.Size = new global::System.Drawing.Size(236, 28);
			this.comboBoxTenAc.TabIndex = 356;
			this.comboBoxTenAc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxTenAc_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(2, 160);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(134, 20);
			this.label1.TabIndex = 357;
			this.label1.Text = "Chọn Đường Môn";
			this.groupBox1.Controls.Add(this.comboBoxBoom3);
			this.groupBox1.Controls.Add(this.comboBoxBoom2);
			this.groupBox1.Controls.Add(this.comboBoxBoom1);
			this.groupBox1.Controls.Add(this.checkBoxPhim3);
			this.groupBox1.Controls.Add(this.checkBoxPhim1);
			this.groupBox1.Controls.Add(this.checkBoxPhim2);
			this.groupBox1.Location = new global::System.Drawing.Point(4, 197);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(381, 154);
			this.groupBox1.TabIndex = 358;
			this.groupBox1.TabStop = false;
			this.comboBoxSolanNhoiboom.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSolanNhoiboom.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxSolanNhoiboom.FormattingEnabled = true;
			this.comboBoxSolanNhoiboom.Location = new global::System.Drawing.Point(310, 360);
			this.comboBoxSolanNhoiboom.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxSolanNhoiboom.Name = "comboBoxSolanNhoiboom";
			this.comboBoxSolanNhoiboom.Size = new global::System.Drawing.Size(73, 28);
			this.comboBoxSolanNhoiboom.TabIndex = 355;
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label2.Location = new global::System.Drawing.Point(78, 366);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(196, 20);
			this.label2.TabIndex = 359;
			this.label2.Text = "Số lần nhồi boom tại 1 chỗ";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(396, 505);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.comboBoxSolanNhoiboom);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboBoxTenAc);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.textBoxKhoangCach);
			base.Controls.Add(this.checkBoxDatXungQuanh);
			base.Controls.Add(this.buttonClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormDuongMon";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DUONG MON BOOM";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormDuongMon_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008BF RID: 2239
		private global::System.Windows.Forms.CheckBox checkBoxPhim1;

		// Token: 0x040008C0 RID: 2240
		private global::System.Windows.Forms.CheckBox checkBoxPhim2;

		// Token: 0x040008C1 RID: 2241
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040008C2 RID: 2242
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040008C3 RID: 2243
		private global::System.Windows.Forms.CheckBox checkBoxPhim3;

		// Token: 0x040008C4 RID: 2244
		private global::System.Windows.Forms.CheckBox checkBoxDatXungQuanh;

		// Token: 0x040008C5 RID: 2245
		private global::System.Windows.Forms.TextBox textBoxKhoangCach;

		// Token: 0x040008C6 RID: 2246
		private global::System.Windows.Forms.ComboBox comboBoxBoom2;

		// Token: 0x040008C7 RID: 2247
		private global::System.Windows.Forms.ComboBox comboBoxBoom1;

		// Token: 0x040008C8 RID: 2248
		private global::System.Windows.Forms.ComboBox comboBoxBoom3;

		// Token: 0x040008C9 RID: 2249
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040008CA RID: 2250
		private global::System.Windows.Forms.ComboBox comboBoxTenAc;

		// Token: 0x040008CB RID: 2251
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040008CC RID: 2252
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040008CD RID: 2253
		private global::System.Windows.Forms.ComboBox comboBoxSolanNhoiboom;

		// Token: 0x040008CE RID: 2254
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008CF RID: 2255
		private global::System.Windows.Forms.Label label2;
	}
}
