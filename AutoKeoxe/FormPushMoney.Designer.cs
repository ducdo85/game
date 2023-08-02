namespace AutoKeoxe
{
	// Token: 0x0200007F RID: 127
	public partial class FormPushMoney : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x0016DD88 File Offset: 0x0016BF88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormPushMoney));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonPush = new global::System.Windows.Forms.Button();
			this.textBoxTen = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkBoxTudong = new global::System.Windows.Forms.CheckBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.Location = new global::System.Drawing.Point(360, 440);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(105, 46);
			this.buttonClose.TabIndex = 346;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.textBox1.Location = new global::System.Drawing.Point(290, 337);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(114, 26);
			this.textBox1.TabIndex = 353;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(285, 377);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(90, 20);
			this.label1.TabIndex = 354;
			this.label1.Text = "0 vạn lượng";
			this.buttonPush.Location = new global::System.Drawing.Point(168, 440);
			this.buttonPush.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonPush.Name = "buttonPush";
			this.buttonPush.Size = new global::System.Drawing.Size(170, 46);
			this.buttonPush.TabIndex = 356;
			this.buttonPush.Text = "Gửi tiền";
			this.buttonPush.UseVisualStyleBackColor = true;
			this.buttonPush.Click += new global::System.EventHandler(this.buttonPush_Click);
			this.textBoxTen.BackColor = global::System.Drawing.Color.Gainsboro;
			this.textBoxTen.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxTen.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxTen.ForeColor = global::System.Drawing.Color.Maroon;
			this.textBoxTen.Location = new global::System.Drawing.Point(8, 12);
			this.textBoxTen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTen.Name = "textBoxTen";
			this.textBoxTen.Size = new global::System.Drawing.Size(459, 19);
			this.textBoxTen.TabIndex = 357;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(82, 342);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(195, 20);
			this.label2.TabIndex = 358;
			this.label2.Text = "Gửi tiền thủ công bằng tay";
			this.checkBoxTudong.AutoSize = true;
			this.checkBoxTudong.Location = new global::System.Drawing.Point(8, 243);
			this.checkBoxTudong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTudong.Name = "checkBoxTudong";
			this.checkBoxTudong.Size = new global::System.Drawing.Size(301, 24);
			this.checkBoxTudong.TabIndex = 359;
			this.checkBoxTudong.Text = "Tự động gửi lên bang khi hành trang >";
			this.checkBoxTudong.UseVisualStyleBackColor = true;
			this.checkBoxTudong.CheckedChanged += new global::System.EventHandler(this.checkBoxTudong_CheckedChanged);
			this.richTextBox1.Location = new global::System.Drawing.Point(8, 42);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(457, 159);
			this.richTextBox1.TabIndex = 361;
			this.richTextBox1.Text = "";
			this.textBox2.Location = new global::System.Drawing.Point(328, 240);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(74, 26);
			this.textBox2.TabIndex = 362;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(414, 245);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(34, 20);
			this.label3.TabIndex = 363;
			this.label3.Text = "vạn";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(414, 342);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(48, 20);
			this.label4.TabIndex = 364;
			this.label4.Text = "lượng";
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label5.Location = new global::System.Drawing.Point(36, 278);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(339, 20);
			this.label5.TabIndex = 365;
			this.label5.Text = "(cần phải stick vào tên ac để auto đang chạy...)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(486, 502);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.checkBoxTudong);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBoxTen);
			base.Controls.Add(this.buttonPush);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormPushMoney";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "GUI TIEN LEN BANG";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormPushMoney_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000AF8 RID: 2808
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000AF9 RID: 2809
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000AFA RID: 2810
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000AFB RID: 2811
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000AFC RID: 2812
		private global::System.Windows.Forms.Button buttonPush;

		// Token: 0x04000AFD RID: 2813
		private global::System.Windows.Forms.TextBox textBoxTen;

		// Token: 0x04000AFE RID: 2814
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000AFF RID: 2815
		private global::System.Windows.Forms.CheckBox checkBoxTudong;

		// Token: 0x04000B00 RID: 2816
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000B01 RID: 2817
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000B02 RID: 2818
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000B03 RID: 2819
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000B04 RID: 2820
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000B07 RID: 2823
		private global::System.ComponentModel.IContainer components;
	}
}
