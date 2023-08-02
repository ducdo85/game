namespace AutoKeoxe
{
	// Token: 0x0200008C RID: 140
	public partial class FormTuyenchien : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B97 RID: 2967 RVA: 0x0018FD18 File Offset: 0x0018DF18
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTuyenchien));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxThemAcc = new global::System.Windows.Forms.ComboBox();
			this.buttonThemAcc = new global::System.Windows.Forms.Button();
			this.buttonXoaAcc = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button5 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.buttonEp = new global::System.Windows.Forms.Button();
			this.buttonBoep = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			base.SuspendLayout();
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.ForeColor = global::System.Drawing.Color.Black;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(4, 140);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(290, 193);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.columnHeader_0.Text = "Check vào Bang cần tuyên chiến";
			this.columnHeader_0.Width = 170;
			this.comboBoxThemAcc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThemAcc.DropDownWidth = 120;
			this.comboBoxThemAcc.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.comboBoxThemAcc.FormattingEnabled = true;
			this.comboBoxThemAcc.Location = new global::System.Drawing.Point(87, 343);
			this.comboBoxThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThemAcc.Name = "comboBoxThemAcc";
			this.comboBoxThemAcc.Size = new global::System.Drawing.Size(208, 28);
			this.comboBoxThemAcc.TabIndex = 63;
			this.comboBoxThemAcc.DropDown += new global::System.EventHandler(this.comboBoxThemAcc_DropDown);
			this.buttonThemAcc.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonThemAcc.Location = new global::System.Drawing.Point(4, 342);
			this.buttonThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThemAcc.Name = "buttonThemAcc";
			this.buttonThemAcc.Size = new global::System.Drawing.Size(75, 35);
			this.buttonThemAcc.TabIndex = 64;
			this.buttonThemAcc.Text = "Thêm";
			this.buttonThemAcc.UseVisualStyleBackColor = true;
			this.buttonThemAcc.Click += new global::System.EventHandler(this.buttonThemAcc_Click);
			this.buttonXoaAcc.ForeColor = global::System.Drawing.Color.Black;
			this.buttonXoaAcc.Location = new global::System.Drawing.Point(304, 223);
			this.buttonXoaAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaAcc.Name = "buttonXoaAcc";
			this.buttonXoaAcc.Size = new global::System.Drawing.Size(105, 58);
			this.buttonXoaAcc.TabIndex = 65;
			this.buttonXoaAcc.Text = "Xóa";
			this.buttonXoaAcc.UseVisualStyleBackColor = true;
			this.buttonXoaAcc.Click += new global::System.EventHandler(this.buttonXoaAcc_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Location = new global::System.Drawing.Point(304, 158);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(105, 58);
			this.button1.TabIndex = 66;
			this.button1.Text = "Xóa hết";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.Location = new global::System.Drawing.Point(304, 503);
			this.button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(105, 58);
			this.button2.TabIndex = 67;
			this.button2.Text = "Đóng";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button3.ForeColor = global::System.Drawing.Color.Blue;
			this.button3.Location = new global::System.Drawing.Point(304, 318);
			this.button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(105, 58);
			this.button3.TabIndex = 68;
			this.button3.Text = "Hướng dẫn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.checkBox1.BackColor = global::System.Drawing.Color.DarkSeaGreen;
			this.checkBox1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBox1.Location = new global::System.Drawing.Point(4, 89);
			this.checkBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(405, 29);
			this.checkBox1.TabIndex = 69;
			this.checkBox1.Text = "Ac đổi màu tự động tuyên chiến (14 phút 1 lần)";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 9);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(278, 20);
			this.label1.TabIndex = 71;
			this.label1.Text = "Thời gian tuyên chiến xong (hh:mm:ss)";
			this.textBox1.BackColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(304, 5);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(103, 26);
			this.textBox1.TabIndex = 72;
			this.button5.ForeColor = global::System.Drawing.Color.DarkRed;
			this.button5.Location = new global::System.Drawing.Point(4, 38);
			this.button5.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(222, 35);
			this.button5.TabIndex = 73;
			this.button5.Text = "khởi tạo lại kế tiếp >>";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(236, 45);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(58, 20);
			this.label2.TabIndex = 75;
			this.label2.Text = "Kế tiếp";
			this.textBox2.BackColor = global::System.Drawing.Color.White;
			this.textBox2.Location = new global::System.Drawing.Point(304, 40);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new global::System.Drawing.Size(103, 26);
			this.textBox2.TabIndex = 76;
			this.buttonEp.Location = new global::System.Drawing.Point(4, 452);
			this.buttonEp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonEp.Name = "buttonEp";
			this.buttonEp.Size = new global::System.Drawing.Size(292, 58);
			this.buttonEp.TabIndex = 77;
			this.buttonEp.Text = "ép vào mục { luôn đánh bang hội } trong nút mở rộng";
			this.buttonEp.UseVisualStyleBackColor = true;
			this.buttonEp.Click += new global::System.EventHandler(this.buttonEp_Click);
			this.buttonBoep.Location = new global::System.Drawing.Point(4, 520);
			this.buttonBoep.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonBoep.Name = "buttonBoep";
			this.buttonBoep.Size = new global::System.Drawing.Size(292, 43);
			this.buttonBoep.TabIndex = 78;
			this.buttonBoep.Text = "bỏ ép { luôn đánh bang hội }";
			this.buttonBoep.UseVisualStyleBackColor = true;
			this.buttonBoep.Click += new global::System.EventHandler(this.buttonBoep_Click);
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 385);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(403, 56);
			this.richTextBox1.TabIndex = 79;
			this.richTextBox1.Text = "";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(418, 574);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.buttonBoep);
			base.Controls.Add(this.buttonEp);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.comboBoxThemAcc);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.buttonThemAcc);
			base.Controls.Add(this.buttonXoaAcc);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTuyenchien";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TUYEN CHIEN";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTuyenchien_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000D3A RID: 3386
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000D3B RID: 3387
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000D3C RID: 3388
		private global::System.Windows.Forms.ComboBox comboBoxThemAcc;

		// Token: 0x04000D3D RID: 3389
		private global::System.Windows.Forms.Button buttonThemAcc;

		// Token: 0x04000D3E RID: 3390
		private global::System.Windows.Forms.Button buttonXoaAcc;

		// Token: 0x04000D3F RID: 3391
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000D40 RID: 3392
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000D41 RID: 3393
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000D42 RID: 3394
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000D43 RID: 3395
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x04000D44 RID: 3396
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000D45 RID: 3397
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000D46 RID: 3398
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000D47 RID: 3399
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000D48 RID: 3400
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000D49 RID: 3401
		private global::System.Windows.Forms.Button buttonEp;

		// Token: 0x04000D4A RID: 3402
		private global::System.Windows.Forms.Button buttonBoep;

		// Token: 0x04000D4B RID: 3403
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000D4C RID: 3404
		private global::System.Windows.Forms.RichTextBox richTextBox1;
	}
}
