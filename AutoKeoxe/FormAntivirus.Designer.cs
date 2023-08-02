namespace AutoKeoxe
{
	// Token: 0x02000065 RID: 101
	public partial class FormAntivirus : global::System.Windows.Forms.Form
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x0012E7CC File Offset: 0x0012C9CC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormAntivirus));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonTieudiet = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.linkLabelTaiBKAV = new global::System.Windows.Forms.LinkLabel();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.buttonMothumuc = new global::System.Windows.Forms.Button();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.checkBoxKhongHienCanhbao = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(6, 54);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(650, 172);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "PID";
			this.columnHeader_1.Text = "Tệp";
			this.columnHeader_1.Width = 275;
			this.columnHeader_2.Text = "Tình trạng";
			this.columnHeader_2.Width = 80;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(4, 17);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(575, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cảnh báo: Danh sách dưới đây là các file có thể đã bị nhiễm keylog";
			this.buttonTieudiet.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonTieudiet.Location = new global::System.Drawing.Point(508, 231);
			this.buttonTieudiet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTieudiet.Name = "buttonTieudiet";
			this.buttonTieudiet.Size = new global::System.Drawing.Size(150, 55);
			this.buttonTieudiet.TabIndex = 2;
			this.buttonTieudiet.Text = "Tiêu diệt";
			this.buttonTieudiet.UseVisualStyleBackColor = true;
			this.buttonTieudiet.Click += new global::System.EventHandler(this.buttonTieudiet_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(508, 420);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(150, 46);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(6, 289);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(103, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cách xử lý:";
			this.linkLabelTaiBKAV.AutoSize = true;
			this.linkLabelTaiBKAV.Location = new global::System.Drawing.Point(6, 446);
			this.linkLabelTaiBKAV.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelTaiBKAV.Name = "linkLabelTaiBKAV";
			this.linkLabelTaiBKAV.Size = new global::System.Drawing.Size(174, 20);
			this.linkLabelTaiBKAV.TabIndex = 5;
			this.linkLabelTaiBKAV.TabStop = true;
			this.linkLabelTaiBKAV.Text = "Tải BKAV Home tại đây";
			this.linkLabelTaiBKAV.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTaiBKAV_LinkClicked);
			this.textBox1.Location = new global::System.Drawing.Point(9, 397);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(290, 26);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "http://www.bkav.com.vn/download";
			this.buttonMothumuc.Location = new global::System.Drawing.Point(350, 231);
			this.buttonMothumuc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonMothumuc.Name = "buttonMothumuc";
			this.buttonMothumuc.Size = new global::System.Drawing.Size(150, 55);
			this.buttonMothumuc.TabIndex = 7;
			this.buttonMothumuc.Text = "Mở thư mục có keylog";
			this.buttonMothumuc.UseVisualStyleBackColor = true;
			this.buttonMothumuc.Click += new global::System.EventHandler(this.buttonMothumuc_Click);
			this.richTextBox1.Location = new global::System.Drawing.Point(9, 326);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(648, 55);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "1. Bấm nút Tiêu diệt để tạm thời làm keylog ngưng hoạt động (chưa xóa hết keylog)\n2. Tải trình quét virus BKAV Home bên dưới về cài đặt và quét keylog.";
			this.checkBoxKhongHienCanhbao.AutoSize = true;
			this.checkBoxKhongHienCanhbao.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxKhongHienCanhbao.Location = new global::System.Drawing.Point(6, 234);
			this.checkBoxKhongHienCanhbao.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxKhongHienCanhbao.Name = "checkBoxKhongHienCanhbao";
			this.checkBoxKhongHienCanhbao.Size = new global::System.Drawing.Size(285, 24);
			this.checkBoxKhongHienCanhbao.TabIndex = 10;
			this.checkBoxKhongHienCanhbao.Text = "Không hiện bảng cảnh báo này nữa";
			this.checkBoxKhongHienCanhbao.UseVisualStyleBackColor = true;
			this.checkBoxKhongHienCanhbao.CheckedChanged += new global::System.EventHandler(this.checkBoxKhongHienCanhbao_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(664, 477);
			base.Controls.Add(this.checkBoxKhongHienCanhbao);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.buttonMothumuc);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.linkLabelTaiBKAV);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonTieudiet);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormAntivirus";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AutoKeoXe PHAT HIEN CO VIRUS - KEYLOG";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormAntivirus_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007A2 RID: 1954
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040007A3 RID: 1955
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040007A4 RID: 1956
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040007A5 RID: 1957
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x040007A6 RID: 1958
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040007A7 RID: 1959
		private global::System.Windows.Forms.Button buttonTieudiet;

		// Token: 0x040007A8 RID: 1960
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040007A9 RID: 1961
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040007AA RID: 1962
		private global::System.Windows.Forms.LinkLabel linkLabelTaiBKAV;

		// Token: 0x040007AB RID: 1963
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040007AC RID: 1964
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x040007AD RID: 1965
		private global::System.Windows.Forms.Button buttonMothumuc;

		// Token: 0x040007AE RID: 1966
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x040007AF RID: 1967
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007B0 RID: 1968
		private global::System.Windows.Forms.CheckBox checkBoxKhongHienCanhbao;
	}
}
