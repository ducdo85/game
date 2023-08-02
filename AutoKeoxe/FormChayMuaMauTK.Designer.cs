namespace AutoKeoxe
{
	// Token: 0x02000068 RID: 104
	public partial class FormChayMuaMauTK : global::System.Windows.Forms.Form
	{
		// Token: 0x0600080A RID: 2058 RVA: 0x0013650C File Offset: 0x0013470C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormChayMuaMauTK));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBoxCong1 = new global::System.Windows.Forms.TextBox();
			this.textBoxCong2 = new global::System.Windows.Forms.TextBox();
			this.buttonLay1 = new global::System.Windows.Forms.Button();
			this.buttonLay2 = new global::System.Windows.Forms.Button();
			this.buttonPhim = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.textBoxText = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(252, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lấy Tọa độ vị trí cổng hậu doanh";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(5, 41);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(211, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tọa độ ngoài, xa mép cổng";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(5, 66);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(221, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tọa độ ngoài, gần mép cổng";
			this.textBoxCong1.Location = new global::System.Drawing.Point(160, 38);
			this.textBoxCong1.Name = "textBoxCong1";
			this.textBoxCong1.ReadOnly = true;
			this.textBoxCong1.Size = new global::System.Drawing.Size(87, 27);
			this.textBoxCong1.TabIndex = 3;
			this.textBoxCong2.Location = new global::System.Drawing.Point(160, 63);
			this.textBoxCong2.Name = "textBoxCong2";
			this.textBoxCong2.ReadOnly = true;
			this.textBoxCong2.Size = new global::System.Drawing.Size(87, 27);
			this.textBoxCong2.TabIndex = 4;
			this.buttonLay1.Location = new global::System.Drawing.Point(256, 35);
			this.buttonLay1.Name = "buttonLay1";
			this.buttonLay1.Size = new global::System.Drawing.Size(59, 23);
			this.buttonLay1.TabIndex = 5;
			this.buttonLay1.Text = "Lấy (1)";
			this.buttonLay1.UseVisualStyleBackColor = true;
			this.buttonLay1.Click += new global::System.EventHandler(this.buttonLay1_Click);
			this.buttonLay2.Location = new global::System.Drawing.Point(256, 61);
			this.buttonLay2.Name = "buttonLay2";
			this.buttonLay2.Size = new global::System.Drawing.Size(59, 23);
			this.buttonLay2.TabIndex = 6;
			this.buttonLay2.Text = "Lấy (2)";
			this.buttonLay2.UseVisualStyleBackColor = true;
			this.buttonLay2.Click += new global::System.EventHandler(this.buttonLay2_Click);
			this.buttonPhim.Location = new global::System.Drawing.Point(61, 109);
			this.buttonPhim.Name = "buttonPhim";
			this.buttonPhim.Size = new global::System.Drawing.Size(137, 26);
			this.buttonPhim.TabIndex = 7;
			this.buttonPhim.Text = "Phim hướng dẫn";
			this.buttonPhim.UseVisualStyleBackColor = true;
			this.buttonPhim.Click += new global::System.EventHandler(this.buttonPhim_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(204, 109);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(111, 26);
			this.buttonClose.TabIndex = 8;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.textBoxText.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.textBoxText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxText.Location = new global::System.Drawing.Point(182, 10);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.ReadOnly = true;
			this.textBoxText.Size = new global::System.Drawing.Size(128, 20);
			this.textBoxText.TabIndex = 9;
			this.textBoxText.Text = "...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 21f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(326, 147);
			base.Controls.Add(this.textBoxText);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonPhim);
			base.Controls.Add(this.buttonLay2);
			base.Controls.Add(this.buttonLay1);
			base.Controls.Add(this.textBoxCong2);
			base.Controls.Add(this.textBoxCong1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormChayMuaMauTK";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CONG HAU DOANH";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormChayMuaMauTK_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007F4 RID: 2036
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040007F5 RID: 2037
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040007F6 RID: 2038
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040007F7 RID: 2039
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040007F8 RID: 2040
		private global::System.Windows.Forms.TextBox textBoxCong1;

		// Token: 0x040007F9 RID: 2041
		private global::System.Windows.Forms.TextBox textBoxCong2;

		// Token: 0x040007FA RID: 2042
		private global::System.Windows.Forms.Button buttonLay1;

		// Token: 0x040007FB RID: 2043
		private global::System.Windows.Forms.Button buttonLay2;

		// Token: 0x040007FC RID: 2044
		private global::System.Windows.Forms.Button buttonPhim;

		// Token: 0x040007FD RID: 2045
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040007FE RID: 2046
		private global::System.Windows.Forms.TextBox textBoxText;

		// Token: 0x04000800 RID: 2048
		private global::System.ComponentModel.IContainer components;
	}
}
