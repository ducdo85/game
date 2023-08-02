namespace AutoKeoxe
{
	// Token: 0x0200008A RID: 138
	public partial class FormTutim : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B55 RID: 2901 RVA: 0x00189A54 File Offset: 0x00187C54
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTutim));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.buttonChonWeb = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBoxTukhoa = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonTim = new global::System.Windows.Forms.Button();
			this.buttonHuongdan = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(2, 117);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(370, 509);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "STT";
			this.columnHeader_0.Width = 40;
			this.columnHeader_1.Text = "Tên web";
			this.columnHeader_1.Width = 145;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonThoat.Location = new global::System.Drawing.Point(296, 723);
			this.buttonThoat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(76, 35);
			this.buttonThoat.TabIndex = 6;
			this.buttonThoat.Text = "Đóng";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.buttonChonWeb.Location = new global::System.Drawing.Point(4, 637);
			this.buttonChonWeb.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonChonWeb.Name = "buttonChonWeb";
			this.buttonChonWeb.Size = new global::System.Drawing.Size(236, 40);
			this.buttonChonWeb.TabIndex = 7;
			this.buttonChonWeb.Text = "Lấy web đang chọn";
			this.buttonChonWeb.UseVisualStyleBackColor = true;
			this.buttonChonWeb.Click += new global::System.EventHandler(this.buttonChonWeb_Click);
			this.richTextBox1.BackColor = global::System.Drawing.Color.White;
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 5);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(367, 106);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			this.textBoxTukhoa.Location = new global::System.Drawing.Point(18, 723);
			this.textBoxTukhoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTukhoa.Name = "textBoxTukhoa";
			this.textBoxTukhoa.Size = new global::System.Drawing.Size(188, 26);
			this.textBoxTukhoa.TabIndex = 9;
			this.textBoxTukhoa.TextChanged += new global::System.EventHandler(this.textBoxTukhoa_TextChanged);
			this.textBoxTukhoa.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.textBoxTukhoa_KeyDown);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(14, 691);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(324, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Nhập từ khóa tìm hoặc Id lic bang hội cần tìm";
			this.buttonTim.Location = new global::System.Drawing.Point(218, 723);
			this.buttonTim.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTim.Name = "buttonTim";
			this.buttonTim.Size = new global::System.Drawing.Size(69, 35);
			this.buttonTim.TabIndex = 11;
			this.buttonTim.Text = "Tìm";
			this.buttonTim.UseVisualStyleBackColor = true;
			this.buttonTim.Click += new global::System.EventHandler(this.buttonTim_Click);
			this.buttonHuongdan.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.buttonHuongdan.Location = new global::System.Drawing.Point(249, 637);
			this.buttonHuongdan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonHuongdan.Name = "buttonHuongdan";
			this.buttonHuongdan.Size = new global::System.Drawing.Size(123, 40);
			this.buttonHuongdan.TabIndex = 12;
			this.buttonHuongdan.Text = "Hướng dẫn";
			this.buttonHuongdan.UseVisualStyleBackColor = true;
			this.buttonHuongdan.Click += new global::System.EventHandler(this.buttonHuongdan_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(378, 769);
			base.Controls.Add(this.buttonHuongdan);
			base.Controls.Add(this.textBoxTukhoa);
			base.Controls.Add(this.buttonTim);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.buttonChonWeb);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormTutim";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FIND WEB";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTutim_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000CDE RID: 3294
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000CDF RID: 3295
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000CE0 RID: 3296
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000CE1 RID: 3297
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000CE2 RID: 3298
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000CE3 RID: 3299
		private global::System.Windows.Forms.Button buttonChonWeb;

		// Token: 0x04000CE4 RID: 3300
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000CE5 RID: 3301
		private global::System.Windows.Forms.TextBox textBoxTukhoa;

		// Token: 0x04000CE6 RID: 3302
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000CE7 RID: 3303
		private global::System.Windows.Forms.Button buttonTim;

		// Token: 0x04000CE8 RID: 3304
		private global::System.Windows.Forms.Button buttonHuongdan;

		// Token: 0x04000CF1 RID: 3313
		private global::System.ComponentModel.IContainer components;
	}
}
