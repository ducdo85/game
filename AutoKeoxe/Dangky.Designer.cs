namespace AutoKeoxe
{
	// Token: 0x02000062 RID: 98
	public partial class Dangky : global::System.Windows.Forms.Form
	{
		// Token: 0x060005AD RID: 1453 RVA: 0x000F4A34 File Offset: 0x000F2C34
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.Dangky));
			this.dkcopy = new global::System.Windows.Forms.Button();
			this.dkidcode = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.dksr = new global::System.Windows.Forms.RichTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.dkxoahet = new global::System.Windows.Forms.Button();
			this.dkdanvao = new global::System.Windows.Forms.Button();
			this.dkdangky = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonCapnhatlic = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.checkBoxOcungThu2 = new global::System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.dkcopy.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.dkcopy.ForeColor = global::System.Drawing.Color.Black;
			this.dkcopy.Location = new global::System.Drawing.Point(566, 5);
			this.dkcopy.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dkcopy.Name = "dkcopy";
			this.dkcopy.Size = new global::System.Drawing.Size(75, 32);
			this.dkcopy.TabIndex = 0;
			this.dkcopy.Text = "Copy";
			this.dkcopy.UseVisualStyleBackColor = false;
			this.dkcopy.Click += new global::System.EventHandler(this.dkcopy_Click);
			this.dkidcode.ForeColor = global::System.Drawing.Color.Black;
			this.dkidcode.Location = new global::System.Drawing.Point(80, 5);
			this.dkidcode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dkidcode.Name = "dkidcode";
			this.dkidcode.ReadOnly = true;
			this.dkidcode.Size = new global::System.Drawing.Size(475, 26);
			this.dkidcode.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(4, 9);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(64, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mã máy";
			this.dksr.ForeColor = global::System.Drawing.Color.Black;
			this.dksr.Location = new global::System.Drawing.Point(9, 74);
			this.dksr.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dksr.Name = "dksr";
			this.dksr.Size = new global::System.Drawing.Size(630, 112);
			this.dksr.TabIndex = 3;
			this.dksr.Text = "";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Black;
			this.label2.Location = new global::System.Drawing.Point(4, 49);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(373, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Bấm nút [Dán Serial] để điền serial vào box dưới đây";
			this.dkxoahet.BackColor = global::System.Drawing.SystemColors.Control;
			this.dkxoahet.ForeColor = global::System.Drawing.Color.Black;
			this.dkxoahet.Location = new global::System.Drawing.Point(328, 202);
			this.dkxoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dkxoahet.Name = "dkxoahet";
			this.dkxoahet.Size = new global::System.Drawing.Size(114, 40);
			this.dkxoahet.TabIndex = 5;
			this.dkxoahet.Text = "Xoá hết";
			this.dkxoahet.UseVisualStyleBackColor = false;
			this.dkxoahet.Click += new global::System.EventHandler(this.dkxoahet_Click);
			this.dkdanvao.BackColor = global::System.Drawing.SystemColors.Control;
			this.dkdanvao.ForeColor = global::System.Drawing.Color.Black;
			this.dkdanvao.Location = new global::System.Drawing.Point(208, 202);
			this.dkdanvao.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dkdanvao.Name = "dkdanvao";
			this.dkdanvao.Size = new global::System.Drawing.Size(111, 40);
			this.dkdanvao.TabIndex = 6;
			this.dkdanvao.Text = "Dán Serial";
			this.dkdanvao.UseVisualStyleBackColor = false;
			this.dkdanvao.Click += new global::System.EventHandler(this.dkdanvao_Click);
			this.dkdangky.BackColor = global::System.Drawing.SystemColors.Control;
			this.dkdangky.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.dkdangky.Location = new global::System.Drawing.Point(498, 202);
			this.dkdangky.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dkdangky.Name = "dkdangky";
			this.dkdangky.Size = new global::System.Drawing.Size(142, 40);
			this.dkdangky.TabIndex = 7;
			this.dkdangky.Text = "Đăng ký";
			this.dkdangky.UseVisualStyleBackColor = false;
			this.dkdangky.Click += new global::System.EventHandler(this.dkdangky_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonCapnhatlic.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonCapnhatlic.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.buttonCapnhatlic.Location = new global::System.Drawing.Point(9, 202);
			this.buttonCapnhatlic.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCapnhatlic.Name = "buttonCapnhatlic";
			this.buttonCapnhatlic.Size = new global::System.Drawing.Size(165, 40);
			this.buttonCapnhatlic.TabIndex = 8;
			this.buttonCapnhatlic.Text = "Cập nhật LIC mới";
			this.buttonCapnhatlic.UseVisualStyleBackColor = false;
			this.buttonCapnhatlic.Click += new global::System.EventHandler(this.buttonCapnhatlic_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 2);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(672, 302);
			this.tabControl1.TabIndex = 9;
			this.tabPage1.Controls.Add(this.dksr);
			this.tabPage1.Controls.Add(this.buttonCapnhatlic);
			this.tabPage1.Controls.Add(this.dkcopy);
			this.tabPage1.Controls.Add(this.dkdangky);
			this.tabPage1.Controls.Add(this.dkidcode);
			this.tabPage1.Controls.Add(this.dkdanvao);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dkxoahet);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(664, 269);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Đăng ký";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage2.Controls.Add(this.checkBoxOcungThu2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(664, 269);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Thông tin khác";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.checkBoxOcungThu2.AutoSize = true;
			this.checkBoxOcungThu2.Location = new global::System.Drawing.Point(9, 9);
			this.checkBoxOcungThu2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxOcungThu2.Name = "checkBoxOcungThu2";
			this.checkBoxOcungThu2.Size = new global::System.Drawing.Size(113, 24);
			this.checkBoxOcungThu2.TabIndex = 0;
			this.checkBoxOcungThu2.Text = "checkBox1";
			this.checkBoxOcungThu2.UseVisualStyleBackColor = true;
			this.checkBoxOcungThu2.CheckedChanged += new global::System.EventHandler(this.checkBoxOcungThu2_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(669, 300);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "Dangky";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "DANG KY SU DUNG";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.Dangky_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.Button dkcopy;

		// Token: 0x0400043F RID: 1087
		private global::System.Windows.Forms.TextBox dkidcode;

		// Token: 0x04000440 RID: 1088
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000441 RID: 1089
		private global::System.Windows.Forms.RichTextBox dksr;

		// Token: 0x04000442 RID: 1090
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000443 RID: 1091
		private global::System.Windows.Forms.Button dkxoahet;

		// Token: 0x04000444 RID: 1092
		private global::System.Windows.Forms.Button dkdanvao;

		// Token: 0x04000445 RID: 1093
		private global::System.Windows.Forms.Button dkdangky;

		// Token: 0x04000446 RID: 1094
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000447 RID: 1095
		private global::System.Windows.Forms.Button buttonCapnhatlic;

		// Token: 0x04000448 RID: 1096
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000449 RID: 1097
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400044A RID: 1098
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400044B RID: 1099
		private global::System.Windows.Forms.CheckBox checkBoxOcungThu2;

		// Token: 0x0400044D RID: 1101
		private global::System.ComponentModel.IContainer components;
	}
}
