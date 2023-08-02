namespace AutoKeoxe
{
	// Token: 0x02000071 RID: 113
	public partial class FormKhongCatdo : global::System.Windows.Forms.Form
	{
		// Token: 0x060008E1 RID: 2273 RVA: 0x0014BED0 File Offset: 0x0014A0D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormKhongCatdo));
			this.comboBoxTenTuiMauHotro = new global::System.Windows.Forms.ComboBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonAppAll = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.comboBoxTenTuiMauHotro.DropDownWidth = 252;
			this.comboBoxTenTuiMauHotro.FormattingEnabled = true;
			this.comboBoxTenTuiMauHotro.Location = new global::System.Drawing.Point(6, 338);
			this.comboBoxTenTuiMauHotro.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxTenTuiMauHotro.Name = "comboBoxTenTuiMauHotro";
			this.comboBoxTenTuiMauHotro.Size = new global::System.Drawing.Size(376, 28);
			this.comboBoxTenTuiMauHotro.TabIndex = 217;
			this.comboBoxTenTuiMauHotro.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxTenTuiMauHotro_MouseDown);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(6, 3);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(377, 322);
			this.listView1.TabIndex = 218;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "Tên vật phẩm không cất vào rương";
			this.columnHeader_0.Width = 230;
			this.buttonThem.Location = new global::System.Drawing.Point(6, 385);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(90, 35);
			this.buttonThem.TabIndex = 219;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(100, 385);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(90, 35);
			this.buttonXoa.TabIndex = 220;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(243, 429);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(111, 40);
			this.buttonClose.TabIndex = 222;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonAppAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonAppAll.Location = new global::System.Drawing.Point(200, 385);
			this.buttonAppAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAppAll.Name = "buttonAppAll";
			this.buttonAppAll.Size = new global::System.Drawing.Size(184, 35);
			this.buttonAppAll.TabIndex = 231;
			this.buttonAppAll.Text = "Áp dụng cho tất cả ac";
			this.buttonAppAll.UseVisualStyleBackColor = true;
			this.buttonAppAll.Click += new global::System.EventHandler(this.buttonAppAll_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(392, 477);
			base.Controls.Add(this.buttonAppAll);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBoxTenTuiMauHotro);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormKhongCatdo";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "LOAI TRU VAT PHAM";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormKhongCatdo_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000913 RID: 2323
		private global::System.Windows.Forms.ComboBox comboBoxTenTuiMauHotro;

		// Token: 0x04000914 RID: 2324
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000915 RID: 2325
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000916 RID: 2326
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000917 RID: 2327
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000918 RID: 2328
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000919 RID: 2329
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400091A RID: 2330
		private global::System.Windows.Forms.Button buttonAppAll;

		// Token: 0x04000925 RID: 2341
		private global::System.ComponentModel.IContainer components;
	}
}
