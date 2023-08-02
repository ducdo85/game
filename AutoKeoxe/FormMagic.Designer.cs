namespace AutoKeoxe
{
	// Token: 0x02000077 RID: 119
	public partial class FormMagic : global::System.Windows.Forms.Form
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x0015E2A4 File Offset: 0x0015C4A4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormMagic));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.checkBoxBuaXongRoidanh = new global::System.Windows.Forms.CheckBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxChieuthuc = new global::System.Windows.Forms.ComboBox();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.checkBoxChiBuff = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.checkBoxPhimTat = new global::System.Windows.Forms.CheckBox();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.checkBoxBuaXongRoidanh.AutoSize = true;
			this.checkBoxBuaXongRoidanh.Location = new global::System.Drawing.Point(10, 234);
			this.checkBoxBuaXongRoidanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxBuaXongRoidanh.Name = "checkBoxBuaXongRoidanh";
			this.checkBoxBuaXongRoidanh.Size = new global::System.Drawing.Size(514, 24);
			this.checkBoxBuaXongRoidanh.TabIndex = 7;
			this.checkBoxBuaXongRoidanh.Text = "Chỉ buff bùa và đánh vào 1 đối tượng gần nhất, không buff diện rộng";
			this.checkBoxBuaXongRoidanh.UseVisualStyleBackColor = true;
			this.checkBoxBuaXongRoidanh.CheckedChanged += new global::System.EventHandler(this.checkBoxBuaXongRoidanh_CheckedChanged);
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(10, 18);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(546, 167);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "Tên chiêu thức";
			this.columnHeader_0.Width = 270;
			this.columnHeader_1.Text = "Cấp";
			this.columnHeader_1.Width = 40;
			this.comboBoxChieuthuc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChieuthuc.DropDownWidth = 250;
			this.comboBoxChieuthuc.FormattingEnabled = true;
			this.comboBoxChieuthuc.Location = new global::System.Drawing.Point(10, 195);
			this.comboBoxChieuthuc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxChieuthuc.Name = "comboBoxChieuthuc";
			this.comboBoxChieuthuc.Size = new global::System.Drawing.Size(325, 28);
			this.comboBoxChieuthuc.TabIndex = 11;
			this.buttonThem.Location = new global::System.Drawing.Point(346, 194);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(114, 35);
			this.buttonThem.TabIndex = 12;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(470, 194);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(88, 35);
			this.buttonXoa.TabIndex = 13;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(40, 355);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(352, 42);
			this.label1.TabIndex = 14;
			this.label1.Text = "Lưu ý: Ac buff bùa các bạn không đưa vào danh sách loại trừ nhé";
			this.buttonClose.Location = new global::System.Drawing.Point(429, 386);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(136, 49);
			this.buttonClose.TabIndex = 15;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.checkBoxChiBuff.AutoSize = true;
			this.checkBoxChiBuff.Location = new global::System.Drawing.Point(10, 317);
			this.checkBoxChiBuff.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxChiBuff.Name = "checkBoxChiBuff";
			this.checkBoxChiBuff.Size = new global::System.Drawing.Size(239, 24);
			this.checkBoxChiBuff.TabIndex = 16;
			this.checkBoxChiBuff.Text = "Chỉ buff bùa chứ không đánh";
			this.checkBoxChiBuff.UseVisualStyleBackColor = true;
			this.checkBoxChiBuff.CheckedChanged += new global::System.EventHandler(this.checkBoxChiBuff_CheckedChanged);
			this.label2.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.label2.Location = new global::System.Drawing.Point(40, 265);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(518, 42);
			this.label2.TabIndex = 17;
			this.label2.Text = "Buff và đánh vào 1 đối tượng gần nhất chứ không buff đánh vào nhiều đối thủ cùng lúc, do đó tốc độ buff đủ bùa sẽ nhanh hơn.";
			this.checkBoxPhimTat.AutoSize = true;
			this.checkBoxPhimTat.ForeColor = global::System.Drawing.Color.DarkRed;
			this.checkBoxPhimTat.Location = new global::System.Drawing.Point(10, 409);
			this.checkBoxPhimTat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPhimTat.Name = "checkBoxPhimTat";
			this.checkBoxPhimTat.Size = new global::System.Drawing.Size(373, 24);
			this.checkBoxPhimTat.TabIndex = 18;
			this.checkBoxPhimTat.Text = "Sử dụng phím tắt Ctrl + TAB để bật tắt cash bùa";
			this.checkBoxPhimTat.UseVisualStyleBackColor = true;
			this.checkBoxPhimTat.CheckedChanged += new global::System.EventHandler(this.checkBoxPhimTat_CheckedChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(576, 454);
			base.Controls.Add(this.checkBoxPhimTat);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBoxChiBuff);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.comboBoxChieuthuc);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.checkBoxBuaXongRoidanh);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormMagic";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Magic";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormMagic_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A27 RID: 2599
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A28 RID: 2600
		private global::System.Windows.Forms.CheckBox checkBoxBuaXongRoidanh;

		// Token: 0x04000A29 RID: 2601
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000A2A RID: 2602
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000A2B RID: 2603
		private global::System.Windows.Forms.ComboBox comboBoxChieuthuc;

		// Token: 0x04000A2C RID: 2604
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000A2D RID: 2605
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000A2E RID: 2606
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000A2F RID: 2607
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A30 RID: 2608
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000A31 RID: 2609
		private global::System.Windows.Forms.CheckBox checkBoxChiBuff;

		// Token: 0x04000A32 RID: 2610
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000A33 RID: 2611
		private global::System.Windows.Forms.CheckBox checkBoxPhimTat;

		// Token: 0x04000A3D RID: 2621
		private global::System.ComponentModel.IContainer components;
	}
}
