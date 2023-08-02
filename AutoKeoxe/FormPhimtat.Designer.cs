namespace AutoKeoxe
{
	// Token: 0x0200007C RID: 124
	public partial class FormPhimtat : global::System.Windows.Forms.Form
	{
		// Token: 0x060009F1 RID: 2545 RVA: 0x00169564 File Offset: 0x00167764
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormPhimtat));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBoxKieuPhimtat = new global::System.Windows.Forms.ComboBox();
			this.buttonGanPhimALL = new global::System.Windows.Forms.Button();
			this.checkBoxLuonGanKetHop = new global::System.Windows.Forms.CheckBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(530, 792);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(104, 35);
			this.buttonClose.TabIndex = 14;
			this.buttonClose.Text = "OK";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(8, 683);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(484, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "Yêu cầu chung: phải check vào mục [v] Sử dụng phím tắt (ở phụ trợ)";
			this.comboBoxKieuPhimtat.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKieuPhimtat.DropDownWidth = 100;
			this.comboBoxKieuPhimtat.FormattingEnabled = true;
			this.comboBoxKieuPhimtat.Location = new global::System.Drawing.Point(40, 794);
			this.comboBoxKieuPhimtat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxKieuPhimtat.Name = "comboBoxKieuPhimtat";
			this.comboBoxKieuPhimtat.Size = new global::System.Drawing.Size(145, 28);
			this.comboBoxKieuPhimtat.TabIndex = 465;
			this.comboBoxKieuPhimtat.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxKieuPhimtat_SelectedIndexChanged);
			this.buttonGanPhimALL.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonGanPhimALL.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonGanPhimALL.Location = new global::System.Drawing.Point(196, 792);
			this.buttonGanPhimALL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonGanPhimALL.Name = "buttonGanPhimALL";
			this.buttonGanPhimALL.Size = new global::System.Drawing.Size(208, 35);
			this.buttonGanPhimALL.TabIndex = 467;
			this.buttonGanPhimALL.Text = "Gán lại cho tất cả ac";
			this.buttonGanPhimALL.UseVisualStyleBackColor = false;
			this.buttonGanPhimALL.Click += new global::System.EventHandler(this.buttonGanPhimALL_Click);
			this.checkBoxLuonGanKetHop.AutoSize = true;
			this.checkBoxLuonGanKetHop.ForeColor = global::System.Drawing.Color.Black;
			this.checkBoxLuonGanKetHop.Location = new global::System.Drawing.Point(12, 757);
			this.checkBoxLuonGanKetHop.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLuonGanKetHop.Name = "checkBoxLuonGanKetHop";
			this.checkBoxLuonGanKetHop.Size = new global::System.Drawing.Size(487, 24);
			this.checkBoxLuonGanKetHop.TabIndex = 466;
			this.checkBoxLuonGanKetHop.Text = "Luôn gán phím tắt (bấm esc -> tùy chọn hệ thống) trong game là";
			this.checkBoxLuonGanKetHop.UseVisualStyleBackColor = true;
			this.checkBoxLuonGanKetHop.CheckedChanged += new global::System.EventHandler(this.checkBoxLuonGanKetHop_CheckedChanged);
			this.richTextBox1.Location = new global::System.Drawing.Point(6, 2);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(634, 670);
			this.richTextBox1.TabIndex = 468;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(645, 848);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.comboBoxKieuPhimtat);
			base.Controls.Add(this.buttonGanPhimALL);
			base.Controls.Add(this.checkBoxLuonGanKetHop);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonClose);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormPhimtat";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PHIM TAT";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormPhimtat_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000AAF RID: 2735
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000AB0 RID: 2736
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000AB1 RID: 2737
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000AB2 RID: 2738
		private global::System.Windows.Forms.ComboBox comboBoxKieuPhimtat;

		// Token: 0x04000AB3 RID: 2739
		private global::System.Windows.Forms.Button buttonGanPhimALL;

		// Token: 0x04000AB4 RID: 2740
		private global::System.Windows.Forms.CheckBox checkBoxLuonGanKetHop;

		// Token: 0x04000AB5 RID: 2741
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000ABB RID: 2747
		private global::System.ComponentModel.IContainer components;
	}
}
