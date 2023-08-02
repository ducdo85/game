namespace AutoKeoxe
{
	// Token: 0x02000064 RID: 100
	public partial class FormAchinh : global::System.Windows.Forms.Form
	{
		// Token: 0x060007C1 RID: 1985 RVA: 0x0012CC3C File Offset: 0x0012AE3C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormAchinh));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.comboBoxAc = new global::System.Windows.Forms.ComboBox();
			this.checkBoxBamPhim = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.checkBoxAnhien = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(164, 194);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(176, 42);
			this.buttonClose.TabIndex = 14;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.comboBoxAc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAc.FormattingEnabled = true;
			this.comboBoxAc.Location = new global::System.Drawing.Point(164, 9);
			this.comboBoxAc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxAc.Name = "comboBoxAc";
			this.comboBoxAc.Size = new global::System.Drawing.Size(174, 28);
			this.comboBoxAc.TabIndex = 20;
			this.comboBoxAc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxAc_SelectedIndexChanged);
			this.comboBoxAc.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxAc_MouseDown);
			this.checkBoxBamPhim.AutoSize = true;
			this.checkBoxBamPhim.Location = new global::System.Drawing.Point(10, 58);
			this.checkBoxBamPhim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBamPhim.Name = "checkBoxBamPhim";
			this.checkBoxBamPhim.Size = new global::System.Drawing.Size(219, 24);
			this.checkBoxBamPhim.TabIndex = 23;
			this.checkBoxBamPhim.Text = "Đổi ac chính khi bấm phím";
			this.checkBoxBamPhim.UseVisualStyleBackColor = true;
			this.checkBoxBamPhim.CheckedChanged += new global::System.EventHandler(this.checkBoxBamPhim_CheckedChanged);
			this.label1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(252, 54);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(87, 31);
			this.label1.TabIndex = 24;
			this.label1.Text = "F2";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(4, 14);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(141, 20);
			this.label2.TabIndex = 25;
			this.label2.Text = "Ac chính dự phòng";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(14, 151);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(315, 20);
			this.label3.TabIndex = 26;
			this.label3.Text = "Lưu ý: check vào sử dụng phím tắt ở phụ trợ";
			this.checkBoxAnhien.AutoSize = true;
			this.checkBoxAnhien.Location = new global::System.Drawing.Point(9, 97);
			this.checkBoxAnhien.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxAnhien.Name = "checkBoxAnhien";
			this.checkBoxAnhien.Size = new global::System.Drawing.Size(285, 24);
			this.checkBoxAnhien.TabIndex = 27;
			this.checkBoxAnhien.Text = "Ẩn ac chính cũ và hiện ac chính mới";
			this.checkBoxAnhien.UseVisualStyleBackColor = true;
			this.checkBoxAnhien.CheckedChanged += new global::System.EventHandler(this.checkBoxAnhien_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(351, 246);
			base.Controls.Add(this.checkBoxAnhien);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBoxBamPhim);
			base.Controls.Add(this.comboBoxAc);
			base.Controls.Add(this.buttonClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormAchinh";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AC_CHINH_DU_PHONG";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormAchinh_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000788 RID: 1928
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000789 RID: 1929
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x0400078A RID: 1930
		private global::System.Windows.Forms.ComboBox comboBoxAc;

		// Token: 0x0400078B RID: 1931
		private global::System.Windows.Forms.CheckBox checkBoxBamPhim;

		// Token: 0x0400078C RID: 1932
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400078D RID: 1933
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400078E RID: 1934
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400078F RID: 1935
		private global::System.Windows.Forms.CheckBox checkBoxAnhien;

		// Token: 0x04000798 RID: 1944
		private global::System.ComponentModel.IContainer components;
	}
}
