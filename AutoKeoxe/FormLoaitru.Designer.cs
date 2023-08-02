namespace AutoKeoxe
{
	// Token: 0x02000072 RID: 114
	public partial class FormLoaitru : global::System.Windows.Forms.Form
	{
		// Token: 0x060008F0 RID: 2288 RVA: 0x0014CD5C File Offset: 0x0014AF5C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormLoaitru));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxAcc = new global::System.Windows.Forms.ComboBox();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.buttonXoahet = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(3, 62);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(179, 183);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			this.columnHeader_0.Text = "Nhân vật";
			this.columnHeader_0.Width = 146;
			this.comboBoxAcc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAcc.FormattingEnabled = true;
			this.comboBoxAcc.Location = new global::System.Drawing.Point(61, 261);
			this.comboBoxAcc.Name = "comboBoxAcc";
			this.comboBoxAcc.Size = new global::System.Drawing.Size(121, 21);
			this.comboBoxAcc.TabIndex = 2;
			this.comboBoxAcc.DropDown += new global::System.EventHandler(this.comboBoxAcc_DropDown);
			this.buttonThem.Location = new global::System.Drawing.Point(3, 256);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(52, 28);
			this.buttonThem.TabIndex = 3;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonXoa.Location = new global::System.Drawing.Point(188, 127);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(70, 38);
			this.buttonXoa.TabIndex = 4;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.label1.Location = new global::System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(252, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Những ac nằm trong danh sách này luôn ở chế độ KHÔNG tự vệ (không đánh), ví dụ ac nga my buff... chỉ dùng theo sau để buff hỗ trợ.";
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonThoat.Location = new global::System.Drawing.Point(188, 246);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(70, 38);
			this.buttonThoat.TabIndex = 6;
			this.buttonThoat.Text = "Đóng";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.buttonXoahet.Location = new global::System.Drawing.Point(188, 62);
			this.buttonXoahet.Name = "buttonXoahet";
			this.buttonXoahet.Size = new global::System.Drawing.Size(70, 38);
			this.buttonXoahet.TabIndex = 7;
			this.buttonXoahet.Text = "Xóa hết";
			this.buttonXoahet.UseVisualStyleBackColor = true;
			this.buttonXoahet.Click += new global::System.EventHandler(this.buttonXoahet_Click);
			this.button1.ForeColor = global::System.Drawing.Color.DarkRed;
			this.button1.Location = new global::System.Drawing.Point(188, 175);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(70, 38);
			this.button1.TabIndex = 8;
			this.button1.Text = "Thêm tất cả ac";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(263, 296);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.buttonXoahet);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.comboBoxAcc);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormLoaitru";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Danh sach loai tru";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormLoaitru_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000928 RID: 2344
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000929 RID: 2345
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400092A RID: 2346
		private global::System.Windows.Forms.ComboBox comboBoxAcc;

		// Token: 0x0400092B RID: 2347
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x0400092C RID: 2348
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x0400092D RID: 2349
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400092E RID: 2350
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400092F RID: 2351
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000930 RID: 2352
		private global::System.Windows.Forms.Button buttonXoahet;

		// Token: 0x04000931 RID: 2353
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000937 RID: 2359
		private global::System.ComponentModel.IContainer components;
	}
}
