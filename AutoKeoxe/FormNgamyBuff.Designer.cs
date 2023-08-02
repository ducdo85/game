namespace AutoKeoxe
{
	// Token: 0x0200007A RID: 122
	public partial class FormNgamyBuff : global::System.Windows.Forms.Form
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x00165904 File Offset: 0x00163B04
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormNgamyBuff));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxnttk = new global::System.Windows.Forms.CheckBox();
			this.comboBoxNgaMyBuff = new global::System.Windows.Forms.ComboBox();
			this.labelPhimKethop = new global::System.Windows.Forms.Label();
			this.buttonPhim = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(234, 215);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(150, 42);
			this.buttonClose.TabIndex = 14;
			this.buttonClose.Text = "OK";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxnttk.AutoSize = true;
			this.checkBoxnttk.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxnttk.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxnttk.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxnttk.Location = new global::System.Drawing.Point(18, 60);
			this.checkBoxnttk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxnttk.Name = "checkBoxnttk";
			this.checkBoxnttk.Size = new global::System.Drawing.Size(276, 25);
			this.checkBoxnttk.TabIndex = 335;
			this.checkBoxnttk.Text = "Buff chiêu Ngọc Tuyền Tâm Kinh";
			this.checkBoxnttk.UseVisualStyleBackColor = false;
			this.checkBoxnttk.CheckedChanged += new global::System.EventHandler(this.checkBoxnttk_CheckedChanged);
			this.comboBoxNgaMyBuff.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNgaMyBuff.DropDownWidth = 120;
			this.comboBoxNgaMyBuff.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxNgaMyBuff.FormattingEnabled = true;
			this.comboBoxNgaMyBuff.Location = new global::System.Drawing.Point(18, 18);
			this.comboBoxNgaMyBuff.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxNgaMyBuff.Name = "comboBoxNgaMyBuff";
			this.comboBoxNgaMyBuff.Size = new global::System.Drawing.Size(388, 28);
			this.comboBoxNgaMyBuff.TabIndex = 339;
			this.comboBoxNgaMyBuff.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxNgaMyBuff_SelectedIndexChanged);
			this.labelPhimKethop.Enabled = false;
			this.labelPhimKethop.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.labelPhimKethop.Location = new global::System.Drawing.Point(18, 100);
			this.labelPhimKethop.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPhimKethop.Name = "labelPhimKethop";
			this.labelPhimKethop.Size = new global::System.Drawing.Size(390, 111);
			this.labelPhimKethop.TabIndex = 340;
			this.labelPhimKethop.Text = "Lưu ý: Game phải ở chế độ Phím Kết Hợp thì mới sử dụng được chiêu Ngọc Tuyền Tâm Kinh.\r\n\r\nCách thiết lập phím kết hợp trong game:\r\nBấm Esc -> Tùy chọn hệ thống -> Phím kết hợp";
			this.buttonPhim.Location = new global::System.Drawing.Point(18, 215);
			this.buttonPhim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPhim.Name = "buttonPhim";
			this.buttonPhim.Size = new global::System.Drawing.Size(192, 42);
			this.buttonPhim.TabIndex = 341;
			this.buttonPhim.Text = "Phim Hướng dẫn";
			this.buttonPhim.UseVisualStyleBackColor = true;
			this.buttonPhim.Click += new global::System.EventHandler(this.buttonPhim_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(422, 275);
			base.Controls.Add(this.buttonPhim);
			base.Controls.Add(this.labelPhimKethop);
			base.Controls.Add(this.comboBoxNgaMyBuff);
			base.Controls.Add(this.checkBoxnttk);
			base.Controls.Add(this.buttonClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormNgamyBuff";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NGA MY BUFF";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormNgamyBuff_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A78 RID: 2680
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A79 RID: 2681
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000A7A RID: 2682
		private global::System.Windows.Forms.CheckBox checkBoxnttk;

		// Token: 0x04000A7B RID: 2683
		private global::System.Windows.Forms.ComboBox comboBoxNgaMyBuff;

		// Token: 0x04000A7C RID: 2684
		private global::System.Windows.Forms.Label labelPhimKethop;

		// Token: 0x04000A7D RID: 2685
		private global::System.Windows.Forms.Button buttonPhim;

		// Token: 0x04000A84 RID: 2692
		private global::System.ComponentModel.IContainer components;
	}
}
