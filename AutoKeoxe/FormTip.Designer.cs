namespace AutoKeoxe
{
	// Token: 0x02000089 RID: 137
	public partial class FormTip : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x00188D1C File Offset: 0x00186F1C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTip));
			this.checkBoxKhongHienthi = new global::System.Windows.Forms.CheckBox();
			this.buttonDong = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.richTextBoxStatus = new global::System.Windows.Forms.RichTextBox();
			this.buttonCopy = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.checkBoxKhongHienthi.AutoSize = true;
			this.checkBoxKhongHienthi.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.checkBoxKhongHienthi.Location = new global::System.Drawing.Point(4, 389);
			this.checkBoxKhongHienthi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongHienthi.Name = "checkBoxKhongHienthi";
			this.checkBoxKhongHienthi.Size = new global::System.Drawing.Size(291, 24);
			this.checkBoxKhongHienthi.TabIndex = 1;
			this.checkBoxKhongHienthi.Text = "Không hiện bảng thông báo này nữa";
			this.checkBoxKhongHienthi.UseVisualStyleBackColor = false;
			this.checkBoxKhongHienthi.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongHienthi_CheckedChanged);
			this.buttonDong.Location = new global::System.Drawing.Point(549, 385);
			this.buttonDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDong.Name = "buttonDong";
			this.buttonDong.Size = new global::System.Drawing.Size(116, 32);
			this.buttonDong.TabIndex = 2;
			this.buttonDong.Text = "Đóng";
			this.buttonDong.UseVisualStyleBackColor = true;
			this.buttonDong.Click += new global::System.EventHandler(this.buttonDong_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.richTextBoxStatus.BackColor = global::System.Drawing.Color.White;
			this.richTextBoxStatus.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBoxStatus.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.richTextBoxStatus.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBoxStatus.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBoxStatus.Name = "richTextBoxStatus";
			this.richTextBoxStatus.Size = new global::System.Drawing.Size(662, 379);
			this.richTextBoxStatus.TabIndex = 3;
			this.richTextBoxStatus.Text = "Hướng dẫn sử dụng";
			this.buttonCopy.Location = new global::System.Drawing.Point(424, 385);
			this.buttonCopy.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonCopy.Name = "buttonCopy";
			this.buttonCopy.Size = new global::System.Drawing.Size(116, 32);
			this.buttonCopy.TabIndex = 4;
			this.buttonCopy.Text = "Copy";
			this.buttonCopy.UseVisualStyleBackColor = true;
			this.buttonCopy.Click += new global::System.EventHandler(this.buttonCopy_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(666, 420);
			base.Controls.Add(this.buttonCopy);
			base.Controls.Add(this.checkBoxKhongHienthi);
			base.Controls.Add(this.richTextBoxStatus);
			base.Controls.Add(this.buttonDong);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormTip";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HUONG DAN";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTip_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CC1 RID: 3265
		private global::System.Windows.Forms.CheckBox checkBoxKhongHienthi;

		// Token: 0x04000CC2 RID: 3266
		private global::System.Windows.Forms.Button buttonDong;

		// Token: 0x04000CC3 RID: 3267
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CC4 RID: 3268
		private global::System.Windows.Forms.RichTextBox richTextBoxStatus;

		// Token: 0x04000CC5 RID: 3269
		private global::System.Windows.Forms.Button buttonCopy;

		// Token: 0x04000CDA RID: 3290
		private global::System.ComponentModel.IContainer components;
	}
}
