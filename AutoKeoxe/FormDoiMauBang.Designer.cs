namespace AutoKeoxe
{
	// Token: 0x0200006D RID: 109
	public partial class FormDoiMauBang : global::System.Windows.Forms.Form
	{
		// Token: 0x06000895 RID: 2197 RVA: 0x00143E8C File Offset: 0x0014208C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormDoiMauBang));
			this.comboBoxThemAcc = new global::System.Windows.Forms.ComboBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			this.comboBoxTenBHO = new global::System.Windows.Forms.ComboBox();
			this.checkBoxNghichMau = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTudong = new global::System.Windows.Forms.CheckBox();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.buttonHelp = new global::System.Windows.Forms.Button();
			this.labelAdminGame = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.comboBoxThemAcc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThemAcc.DropDownWidth = 120;
			this.comboBoxThemAcc.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxThemAcc.FormattingEnabled = true;
			this.comboBoxThemAcc.Location = new global::System.Drawing.Point(45, 52);
			this.comboBoxThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThemAcc.Name = "comboBoxThemAcc";
			this.comboBoxThemAcc.Size = new global::System.Drawing.Size(230, 28);
			this.comboBoxThemAcc.TabIndex = 63;
			this.comboBoxThemAcc.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxThemAcc_SelectedIndexChanged);
			this.comboBoxThemAcc.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxThemAcc_MouseDown);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new global::System.Drawing.Point(6, 17);
			this.radioButton1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(239, 24);
			this.radioButton1.TabIndex = 64;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Theo màu ac của đối phương";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new global::System.EventHandler(this.radioButton1_CheckedChanged);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new global::System.Drawing.Point(6, 97);
			this.radioButton2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(245, 24);
			this.radioButton2.TabIndex = 65;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Đổi theo màu ac của bang hội";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new global::System.EventHandler(this.radioButton2_CheckedChanged);
			this.comboBoxTenBHO.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTenBHO.DropDownWidth = 120;
			this.comboBoxTenBHO.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxTenBHO.FormattingEnabled = true;
			this.comboBoxTenBHO.Location = new global::System.Drawing.Point(45, 132);
			this.comboBoxTenBHO.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenBHO.Name = "comboBoxTenBHO";
			this.comboBoxTenBHO.Size = new global::System.Drawing.Size(230, 28);
			this.comboBoxTenBHO.TabIndex = 66;
			this.comboBoxTenBHO.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxTenBHO_SelectedIndexChanged);
			this.comboBoxTenBHO.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenBHO_MouseDown);
			this.checkBoxNghichMau.AutoSize = true;
			this.checkBoxNghichMau.Location = new global::System.Drawing.Point(45, 288);
			this.checkBoxNghichMau.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxNghichMau.Name = "checkBoxNghichMau";
			this.checkBoxNghichMau.Size = new global::System.Drawing.Size(145, 24);
			this.checkBoxNghichMau.TabIndex = 69;
			this.checkBoxNghichMau.Text = "Đổi nghịch màu";
			this.checkBoxNghichMau.UseVisualStyleBackColor = true;
			this.checkBoxNghichMau.CheckedChanged += new global::System.EventHandler(this.checkBoxNghichMau_CheckedChanged);
			this.checkBoxTudong.AutoSize = true;
			this.checkBoxTudong.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.checkBoxTudong.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxTudong.Location = new global::System.Drawing.Point(45, 214);
			this.checkBoxTudong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTudong.Name = "checkBoxTudong";
			this.checkBoxTudong.Size = new global::System.Drawing.Size(174, 24);
			this.checkBoxTudong.TabIndex = 182;
			this.checkBoxTudong.Text = "Tự động đổi màu";
			this.checkBoxTudong.UseVisualStyleBackColor = true;
			this.checkBoxTudong.CheckedChanged += new global::System.EventHandler(this.checkBoxTudong_CheckedChanged);
			this.buttonClose.Location = new global::System.Drawing.Point(186, 351);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(120, 43);
			this.buttonClose.TabIndex = 183;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.buttonHelp.Location = new global::System.Drawing.Point(48, 351);
			this.buttonHelp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new global::System.Drawing.Size(120, 43);
			this.buttonHelp.TabIndex = 184;
			this.buttonHelp.Text = "Trợ giúp";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new global::System.EventHandler(this.buttonHelp_Click);
			this.labelAdminGame.AutoSize = true;
			this.labelAdminGame.Location = new global::System.Drawing.Point(66, 246);
			this.labelAdminGame.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelAdminGame.Name = "labelAdminGame";
			this.labelAdminGame.Size = new global::System.Drawing.Size(21, 20);
			this.labelAdminGame.TabIndex = 185;
			this.labelAdminGame.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(330, 408);
			base.Controls.Add(this.labelAdminGame);
			base.Controls.Add(this.buttonHelp);
			base.Controls.Add(this.checkBoxNghichMau);
			base.Controls.Add(this.checkBoxTudong);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.comboBoxTenBHO);
			base.Controls.Add(this.radioButton2);
			base.Controls.Add(this.radioButton1);
			base.Controls.Add(this.comboBoxThemAcc);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormDoiMauBang";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ĐỔI MÀU BANG";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormDoiMauBang_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008AB RID: 2219
		private global::System.Windows.Forms.ComboBox comboBoxThemAcc;

		// Token: 0x040008AC RID: 2220
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040008AD RID: 2221
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x040008AE RID: 2222
		private global::System.Windows.Forms.RadioButton radioButton2;

		// Token: 0x040008AF RID: 2223
		private global::System.Windows.Forms.ComboBox comboBoxTenBHO;

		// Token: 0x040008B0 RID: 2224
		private global::System.Windows.Forms.CheckBox checkBoxNghichMau;

		// Token: 0x040008B1 RID: 2225
		private global::System.Windows.Forms.CheckBox checkBoxTudong;

		// Token: 0x040008B2 RID: 2226
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040008B3 RID: 2227
		private global::System.Windows.Forms.Button buttonHelp;

		// Token: 0x040008B4 RID: 2228
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008B5 RID: 2229
		private global::System.Windows.Forms.Label labelAdminGame;
	}
}
