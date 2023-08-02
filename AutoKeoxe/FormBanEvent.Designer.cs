namespace AutoKeoxe
{
	// Token: 0x02000066 RID: 102
	public partial class FormBanEvent : global::System.Windows.Forms.Form
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x0012F130 File Offset: 0x0012D330
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormBanEvent));
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxTenTuiMauHotro = new global::System.Windows.Forms.ComboBox();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.label37 = new global::System.Windows.Forms.Label();
			this.textBoxTocdoban = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.buttonXoa.Location = new global::System.Drawing.Point(134, 485);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(80, 35);
			this.buttonXoa.TabIndex = 235;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonThem.Location = new global::System.Drawing.Point(4, 485);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(120, 35);
			this.buttonThem.TabIndex = 234;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(4, 109);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(300, 328);
			this.listView1.TabIndex = 233;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Tên";
			this.columnHeader_0.Width = 180;
			this.comboBoxTenTuiMauHotro.DropDownWidth = 252;
			this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
			this.comboBoxTenTuiMauHotro.Location = new global::System.Drawing.Point(4, 443);
			this.comboBoxTenTuiMauHotro.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
			this.comboBoxTenTuiMauHotro.Size = new global::System.Drawing.Size(298, 28);
			this.comboBoxTenTuiMauHotro.TabIndex = 232;
			this.comboBoxTenTuiMauHotro.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenTuiMauHotro_MouseDown);
			this.buttonClose.Location = new global::System.Drawing.Point(225, 485);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(80, 35);
			this.buttonClose.TabIndex = 236;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label37.AutoSize = true;
			this.label37.ForeColor = global::System.Drawing.Color.Maroon;
			this.label37.Location = new global::System.Drawing.Point(3, 8);
			this.label37.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label37.Name = "label37";
			this.label37.Size = new global::System.Drawing.Size(201, 20);
			this.label37.TabIndex = 357;
			this.label37.Text = "Thời gian kiểm tra (mili giây)";
			this.textBoxTocdoban.Location = new global::System.Drawing.Point(214, 3);
			this.textBoxTocdoban.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxTocdoban.Name = "textBoxTocdoban";
			this.textBoxTocdoban.Size = new global::System.Drawing.Size(88, 26);
			this.textBoxTocdoban.TabIndex = 358;
			this.textBoxTocdoban.TextChanged += new global::System.EventHandler(this.textBoxTocdoban_TextChanged);
			this.label1.ForeColor = global::System.Drawing.Color.DarkSlateGray;
			this.label1.Location = new global::System.Drawing.Point(0, 37);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(310, 65);
			this.label1.TabIndex = 359;
			this.label1.Text = "Nếu lâu lâu mới bán hoặc ăn thì để cao lên cỡ 3000 - 6000 nhé (vì để thấp thì %cpu sẽ cao dễ gây diss game)";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(310, 526);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBoxTocdoban);
			base.Controls.Add(this.label37);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBoxTenTuiMauHotro);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "FormBanEvent";
			this.Text = "VAT PHAM RAC";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormBanEvent_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007B2 RID: 1970
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x040007B3 RID: 1971
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x040007B4 RID: 1972
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040007B5 RID: 1973
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x040007B6 RID: 1974
		private global::System.Windows.Forms.ComboBox comboBoxTenTuiMauHotro;

		// Token: 0x040007B7 RID: 1975
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x040007B8 RID: 1976
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040007B9 RID: 1977
		private global::System.Windows.Forms.Label label37;

		// Token: 0x040007BA RID: 1978
		private global::System.Windows.Forms.TextBox textBoxTocdoban;

		// Token: 0x040007BB RID: 1979
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040007C5 RID: 1989
		private global::System.ComponentModel.IContainer components;
	}
}
