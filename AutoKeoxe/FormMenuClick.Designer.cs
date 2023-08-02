namespace AutoKeoxe
{
	// Token: 0x02000079 RID: 121
	public partial class FormMenuClick : global::System.Windows.Forms.Form
	{
		// Token: 0x060009C0 RID: 2496 RVA: 0x00164914 File Offset: 0x00162B14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormMenuClick));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.comboBoxDong = new global::System.Windows.Forms.ComboBox();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonDong = new global::System.Windows.Forms.Button();
			this.buttonSua = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxDiengiai = new global::System.Windows.Forms.TextBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonXoahet = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.buttonVidu = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 6);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(304, 69);
			this.richTextBox1.TabIndex = 19;
			this.richTextBox1.Text = "Thứ tự dòng menu được tính từ số 1 trở đi (dòng menu đầu tiên là số 1).\nKhi menu hiển thị, auto sẽ tự động click lần lượt các dòng theo thứ tự từ trên xuống.";
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.ForeColor = global::System.Drawing.Color.Black;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(4, 86);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(186, 272);
			this.listView1.TabIndex = 20;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Click dòng thứ";
			this.columnHeader_0.Width = 100;
			this.buttonXoa.Location = new global::System.Drawing.Point(206, 302);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(105, 40);
			this.buttonXoa.TabIndex = 21;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.comboBoxDong.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDong.FormattingEnabled = true;
			this.comboBoxDong.Location = new global::System.Drawing.Point(132, 375);
			this.comboBoxDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxDong.Name = "comboBoxDong";
			this.comboBoxDong.Size = new global::System.Drawing.Size(58, 28);
			this.comboBoxDong.TabIndex = 23;
			this.buttonThem.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonThem.Location = new global::System.Drawing.Point(4, 369);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(118, 40);
			this.buttonThem.TabIndex = 22;
			this.buttonThem.Text = "Thêm dòng";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonDong.Location = new global::System.Drawing.Point(206, 446);
			this.buttonDong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDong.Name = "buttonDong";
			this.buttonDong.Size = new global::System.Drawing.Size(105, 58);
			this.buttonDong.TabIndex = 25;
			this.buttonDong.Text = "Đóng";
			this.buttonDong.UseVisualStyleBackColor = true;
			this.buttonDong.Click += new global::System.EventHandler(this.buttonDong_Click);
			this.buttonSua.Location = new global::System.Drawing.Point(206, 368);
			this.buttonSua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new global::System.Drawing.Size(105, 40);
			this.buttonSua.TabIndex = 24;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new global::System.EventHandler(this.buttonSua_Click);
			this.label1.Location = new global::System.Drawing.Point(3, 420);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(226, 55);
			this.label1.TabIndex = 27;
			this.label1.Text = "Diễn giải: auto sẽ lần lượt click menu các dòng sau";
			this.textBoxDiengiai.Location = new global::System.Drawing.Point(8, 471);
			this.textBoxDiengiai.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxDiengiai.Name = "textBoxDiengiai";
			this.textBoxDiengiai.ReadOnly = true;
			this.textBoxDiengiai.Size = new global::System.Drawing.Size(182, 26);
			this.textBoxDiengiai.TabIndex = 28;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonXoahet.Location = new global::System.Drawing.Point(206, 252);
			this.buttonXoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoahet.Name = "buttonXoahet";
			this.buttonXoahet.Size = new global::System.Drawing.Size(105, 40);
			this.buttonXoahet.TabIndex = 29;
			this.buttonXoahet.Text = "Xóa hết";
			this.buttonXoahet.UseVisualStyleBackColor = true;
			this.buttonXoahet.Click += new global::System.EventHandler(this.buttonXoahet_Click);
			this.label2.Location = new global::System.Drawing.Point(201, 89);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(110, 82);
			this.label2.TabIndex = 30;
			this.label2.Text = "Nhận nhiệm vụ 90 sát thủ Liên Hình Thái";
			this.buttonVidu.Location = new global::System.Drawing.Point(206, 175);
			this.buttonVidu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonVidu.Name = "buttonVidu";
			this.buttonVidu.Size = new global::System.Drawing.Size(105, 40);
			this.buttonVidu.TabIndex = 31;
			this.buttonVidu.Text = "Xem ví dụ";
			this.buttonVidu.UseVisualStyleBackColor = true;
			this.buttonVidu.Click += new global::System.EventHandler(this.buttonVidu_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(315, 512);
			base.Controls.Add(this.buttonDong);
			base.Controls.Add(this.buttonVidu);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonXoahet);
			base.Controls.Add(this.textBoxDiengiai);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonSua);
			base.Controls.Add(this.comboBoxDong);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.richTextBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "FormMenuClick";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MENU CLICK";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormMenuClick_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A62 RID: 2658
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000A63 RID: 2659
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000A64 RID: 2660
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000A65 RID: 2661
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000A66 RID: 2662
		private global::System.Windows.Forms.ComboBox comboBoxDong;

		// Token: 0x04000A67 RID: 2663
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000A68 RID: 2664
		private global::System.Windows.Forms.Button buttonDong;

		// Token: 0x04000A69 RID: 2665
		private global::System.Windows.Forms.Button buttonSua;

		// Token: 0x04000A6A RID: 2666
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A6B RID: 2667
		private global::System.Windows.Forms.TextBox textBoxDiengiai;

		// Token: 0x04000A6C RID: 2668
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A6D RID: 2669
		private global::System.Windows.Forms.Button buttonXoahet;

		// Token: 0x04000A6E RID: 2670
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000A6F RID: 2671
		private global::System.Windows.Forms.Button buttonVidu;

		// Token: 0x04000A75 RID: 2677
		private global::System.ComponentModel.IContainer components;
	}
}
