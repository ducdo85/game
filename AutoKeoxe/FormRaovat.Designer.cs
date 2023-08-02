namespace AutoKeoxe
{
	// Token: 0x02000080 RID: 128
	public partial class FormRaovat : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x0016FAAC File Offset: 0x0016DCAC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormRaovat));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.comboBoxRaoVat = new global::System.Windows.Forms.ComboBox();
			this.textBoxTimeRaoVat = new global::System.Windows.Forms.TextBox();
			this.textBoxTextRaoVat = new global::System.Windows.Forms.TextBox();
			this.checkBoxRaoVat = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkBoxBomNoiluc = new global::System.Windows.Forms.CheckBox();
			this.checkBoxRaoHinhanh = new global::System.Windows.Forms.CheckBox();
			this.groupBoxRaovat = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.checkBoxAceptBH = new global::System.Windows.Forms.CheckBox();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.label3 = new global::System.Windows.Forms.Label();
			this.buttonXoaDanhAc = new global::System.Windows.Forms.Button();
			this.comboBoxKhongdanhAc = new global::System.Windows.Forms.ComboBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBoxRaovat.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonClose.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.ForeColor = global::System.Drawing.Color.Black;
			this.buttonClose.Location = new global::System.Drawing.Point(241, 339);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(77, 26);
			this.buttonClose.TabIndex = 139;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.comboBoxRaoVat.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRaoVat.DropDownWidth = 80;
			this.comboBoxRaoVat.FormattingEnabled = true;
			this.comboBoxRaoVat.Location = new global::System.Drawing.Point(222, 80);
			this.comboBoxRaoVat.Name = "comboBoxRaoVat";
			this.comboBoxRaoVat.Size = new global::System.Drawing.Size(84, 28);
			this.comboBoxRaoVat.TabIndex = 212;
			this.comboBoxRaoVat.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxRaoVat_SelectedIndexChanged);
			this.textBoxTimeRaoVat.Location = new global::System.Drawing.Point(246, 105);
			this.textBoxTimeRaoVat.Name = "textBoxTimeRaoVat";
			this.textBoxTimeRaoVat.Size = new global::System.Drawing.Size(60, 26);
			this.textBoxTimeRaoVat.TabIndex = 210;
			this.textBoxTimeRaoVat.Text = "30000";
			this.textBoxTimeRaoVat.TextChanged += new global::System.EventHandler(this.textBoxTimeRaoVat_TextChanged);
			this.textBoxTextRaoVat.BackColor = global::System.Drawing.Color.White;
			this.textBoxTextRaoVat.Location = new global::System.Drawing.Point(9, 12);
			this.textBoxTextRaoVat.Multiline = true;
			this.textBoxTextRaoVat.Name = "textBoxTextRaoVat";
			this.textBoxTextRaoVat.Size = new global::System.Drawing.Size(297, 64);
			this.textBoxTextRaoVat.TabIndex = 211;
			this.textBoxTextRaoVat.Text = ":@TËp trung MCQ nhanh";
			this.textBoxTextRaoVat.TextChanged += new global::System.EventHandler(this.textBoxTextRaoVat_TextChanged);
			this.checkBoxRaoVat.AutoSize = true;
			this.checkBoxRaoVat.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxRaoVat.Location = new global::System.Drawing.Point(15, 345);
			this.checkBoxRaoVat.Name = "checkBoxRaoVat";
			this.checkBoxRaoVat.Size = new global::System.Drawing.Size(149, 24);
			this.checkBoxRaoVat.TabIndex = 209;
			this.checkBoxRaoVat.Text = "Bắt đầu rao vặt";
			this.checkBoxRaoVat.UseVisualStyleBackColor = true;
			this.checkBoxRaoVat.CheckedChanged += new global::System.EventHandler(this.checkBoxRaoVat_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(77, 108);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(261, 20);
			this.label1.TabIndex = 213;
			this.label1.Text = "Thời gian giữa 2 lần rao (mili giây)";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(128, 83);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(137, 20);
			this.label2.TabIndex = 214;
			this.label2.Text = "Chọn tầng số rao";
			this.checkBoxBomNoiluc.AutoSize = true;
			this.checkBoxBomNoiluc.Location = new global::System.Drawing.Point(11, 133);
			this.checkBoxBomNoiluc.Name = "checkBoxBomNoiluc";
			this.checkBoxBomNoiluc.Size = new global::System.Drawing.Size(147, 24);
			this.checkBoxBomNoiluc.TabIndex = 215;
			this.checkBoxBomNoiluc.Text = "Có bơm nội lực";
			this.checkBoxBomNoiluc.UseVisualStyleBackColor = true;
			this.checkBoxBomNoiluc.CheckedChanged += new global::System.EventHandler(this.checkBoxBomNoiluc_CheckedChanged);
			this.checkBoxRaoHinhanh.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.checkBoxRaoHinhanh.Location = new global::System.Drawing.Point(11, 153);
			this.checkBoxRaoHinhanh.Name = "checkBoxRaoHinhanh";
			this.checkBoxRaoHinhanh.Size = new global::System.Drawing.Size(282, 34);
			this.checkBoxRaoHinhanh.TabIndex = 216;
			this.checkBoxRaoHinhanh.Text = "Rao vặt có hình ảnh (bạn phải rao trước trong game 1 lần, auto gửi phím enter để rao)";
			this.checkBoxRaoHinhanh.UseVisualStyleBackColor = true;
			this.checkBoxRaoHinhanh.CheckedChanged += new global::System.EventHandler(this.checkBoxRaoHinhanh_CheckedChanged);
			this.groupBoxRaovat.Controls.Add(this.button1);
			this.groupBoxRaovat.Controls.Add(this.checkBoxRaoHinhanh);
			this.groupBoxRaovat.Controls.Add(this.checkBoxBomNoiluc);
			this.groupBoxRaovat.Controls.Add(this.label2);
			this.groupBoxRaovat.Controls.Add(this.label1);
			this.groupBoxRaovat.Controls.Add(this.comboBoxRaoVat);
			this.groupBoxRaovat.Controls.Add(this.textBoxTimeRaoVat);
			this.groupBoxRaovat.Controls.Add(this.textBoxTextRaoVat);
			this.groupBoxRaovat.Location = new global::System.Drawing.Point(4, 2);
			this.groupBoxRaovat.Name = "groupBoxRaovat";
			this.groupBoxRaovat.Size = new global::System.Drawing.Size(314, 194);
			this.groupBoxRaovat.TabIndex = 217;
			this.groupBoxRaovat.TabStop = false;
			this.button1.BackColor = global::System.Drawing.SystemColors.Control;
			this.button1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(8, 80);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(58, 23);
			this.button1.TabIndex = 469;
			this.button1.Text = "Mặc định";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.checkBoxAceptBH.Location = new global::System.Drawing.Point(9, 23);
			this.checkBoxAceptBH.Name = "checkBoxAceptBH";
			this.checkBoxAceptBH.Size = new global::System.Drawing.Size(147, 37);
			this.checkBoxAceptBH.TabIndex = 218;
			this.checkBoxAceptBH.Text = "Tự động cho ac vào bang (đội trưởng trở lên)";
			this.checkBoxAceptBH.UseVisualStyleBackColor = true;
			this.checkBoxAceptBH.CheckedChanged += new global::System.EventHandler(this.checkBoxAceptBH_CheckedChanged);
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(162, 23);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(135, 59);
			this.listView2.TabIndex = 219;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 115;
			this.label3.Location = new global::System.Drawing.Point(26, 63);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(115, 31);
			this.label3.TabIndex = 220;
			this.label3.Text = "Danh sách ac không duyệt vào bang =>";
			this.buttonXoaDanhAc.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXoaDanhAc.ForeColor = global::System.Drawing.Color.Black;
			this.buttonXoaDanhAc.Location = new global::System.Drawing.Point(272, 87);
			this.buttonXoaDanhAc.Name = "buttonXoaDanhAc";
			this.buttonXoaDanhAc.Size = new global::System.Drawing.Size(25, 21);
			this.buttonXoaDanhAc.TabIndex = 467;
			this.buttonXoaDanhAc.Text = "X";
			this.buttonXoaDanhAc.UseVisualStyleBackColor = false;
			this.buttonXoaDanhAc.Click += new global::System.EventHandler(this.buttonXoaDanhAc_Click);
			this.comboBoxKhongdanhAc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKhongdanhAc.DropDownWidth = 125;
			this.comboBoxKhongdanhAc.FormattingEnabled = true;
			this.comboBoxKhongdanhAc.Location = new global::System.Drawing.Point(162, 88);
			this.comboBoxKhongdanhAc.Name = "comboBoxKhongdanhAc";
			this.comboBoxKhongdanhAc.Size = new global::System.Drawing.Size(104, 28);
			this.comboBoxKhongdanhAc.TabIndex = 466;
			this.comboBoxKhongdanhAc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxKhongdanhAc_SelectedIndexChanged);
			this.comboBoxKhongdanhAc.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxKhongdanhAc_MouseDown);
			this.groupBox1.Controls.Add(this.buttonXoaDanhAc);
			this.groupBox1.Controls.Add(this.comboBoxKhongdanhAc);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.listView2);
			this.groupBox1.Controls.Add(this.checkBoxAceptBH);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 205);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(311, 122);
			this.groupBox1.TabIndex = 468;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tuyển member bang hội";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(10f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(325, 385);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.groupBoxRaovat);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.checkBoxRaoVat);
			this.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormRaovat";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RAO VAT";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormRaovat_Load);
			this.groupBoxRaovat.ResumeLayout(false);
			this.groupBoxRaovat.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000B12 RID: 2834
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000B13 RID: 2835
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000B14 RID: 2836
		private global::System.Windows.Forms.ComboBox comboBoxRaoVat;

		// Token: 0x04000B15 RID: 2837
		private global::System.Windows.Forms.TextBox textBoxTimeRaoVat;

		// Token: 0x04000B16 RID: 2838
		private global::System.Windows.Forms.TextBox textBoxTextRaoVat;

		// Token: 0x04000B17 RID: 2839
		private global::System.Windows.Forms.CheckBox checkBoxRaoVat;

		// Token: 0x04000B18 RID: 2840
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000B19 RID: 2841
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000B1A RID: 2842
		private global::System.Windows.Forms.CheckBox checkBoxBomNoiluc;

		// Token: 0x04000B1B RID: 2843
		private global::System.Windows.Forms.CheckBox checkBoxRaoHinhanh;

		// Token: 0x04000B1C RID: 2844
		private global::System.Windows.Forms.GroupBox groupBoxRaovat;

		// Token: 0x04000B1D RID: 2845
		private global::System.Windows.Forms.CheckBox checkBoxAceptBH;

		// Token: 0x04000B1E RID: 2846
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x04000B1F RID: 2847
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000B20 RID: 2848
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000B21 RID: 2849
		private global::System.Windows.Forms.Button buttonXoaDanhAc;

		// Token: 0x04000B22 RID: 2850
		private global::System.Windows.Forms.ComboBox comboBoxKhongdanhAc;

		// Token: 0x04000B23 RID: 2851
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000B24 RID: 2852
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000B25 RID: 2853
		private global::System.Windows.Forms.Button button1;
	}
}
