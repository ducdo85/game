namespace AutoKeoxe
{
	// Token: 0x0200008D RID: 141
	public partial class FormUutienNguHanh : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BA7 RID: 2983 RVA: 0x001917E8 File Offset: 0x0018F9E8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormUutienNguHanh));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonLen1 = new global::System.Windows.Forms.Button();
			this.buttonXuong1 = new global::System.Windows.Forms.Button();
			this.buttonUuTienMacdinh = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.groupBoxNguHanh = new global::System.Windows.Forms.GroupBox();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.buttonMacdinhMP = new global::System.Windows.Forms.Button();
			this.buttonXuongMP = new global::System.Windows.Forms.Button();
			this.buttonLenMP = new global::System.Windows.Forms.Button();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.groupBoxNguHanh.SuspendLayout();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(8, 20);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(130, 130);
			this.listView1.TabIndex = 10;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "STT";
			this.columnHeader_0.Width = 30;
			this.columnHeader_1.Text = "Ngũ hành";
			this.columnHeader_1.Width = 80;
			this.buttonLen1.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonLen1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonLen1.ForeColor = global::System.Drawing.Color.Black;
			this.buttonLen1.Location = new global::System.Drawing.Point(144, 43);
			this.buttonLen1.Name = "buttonLen1";
			this.buttonLen1.Size = new global::System.Drawing.Size(59, 28);
			this.buttonLen1.TabIndex = 134;
			this.buttonLen1.Text = "Lên";
			this.buttonLen1.UseVisualStyleBackColor = false;
			this.buttonLen1.Click += new global::System.EventHandler(this.buttonLen1_Click);
			this.buttonXuong1.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXuong1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonXuong1.ForeColor = global::System.Drawing.Color.Black;
			this.buttonXuong1.Location = new global::System.Drawing.Point(144, 76);
			this.buttonXuong1.Name = "buttonXuong1";
			this.buttonXuong1.Size = new global::System.Drawing.Size(59, 28);
			this.buttonXuong1.TabIndex = 135;
			this.buttonXuong1.Text = "Xuống";
			this.buttonXuong1.UseVisualStyleBackColor = false;
			this.buttonXuong1.Click += new global::System.EventHandler(this.buttonXuong1_Click);
			this.buttonUuTienMacdinh.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonUuTienMacdinh.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonUuTienMacdinh.ForeColor = global::System.Drawing.Color.Black;
			this.buttonUuTienMacdinh.Location = new global::System.Drawing.Point(144, 123);
			this.buttonUuTienMacdinh.Name = "buttonUuTienMacdinh";
			this.buttonUuTienMacdinh.Size = new global::System.Drawing.Size(59, 28);
			this.buttonUuTienMacdinh.TabIndex = 138;
			this.buttonUuTienMacdinh.Text = "Mặc định";
			this.buttonUuTienMacdinh.UseVisualStyleBackColor = false;
			this.buttonUuTienMacdinh.Click += new global::System.EventHandler(this.buttonUuTienMacdinh_Click);
			this.buttonClose.BackColor = global::System.Drawing.Color.SeaGreen;
			this.buttonClose.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.ForeColor = global::System.Drawing.Color.Black;
			this.buttonClose.Location = new global::System.Drawing.Point(145, 221);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(59, 28);
			this.buttonClose.TabIndex = 139;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.groupBoxNguHanh.Controls.Add(this.buttonUuTienMacdinh);
			this.groupBoxNguHanh.Controls.Add(this.buttonXuong1);
			this.groupBoxNguHanh.Controls.Add(this.buttonLen1);
			this.groupBoxNguHanh.Controls.Add(this.listView1);
			this.groupBoxNguHanh.Location = new global::System.Drawing.Point(1, 0);
			this.groupBoxNguHanh.Name = "groupBoxNguHanh";
			this.groupBoxNguHanh.Size = new global::System.Drawing.Size(210, 164);
			this.groupBoxNguHanh.TabIndex = 140;
			this.groupBoxNguHanh.TabStop = false;
			this.groupBoxNguHanh.Text = "Ngũ hành";
			this.groupBox1.Controls.Add(this.buttonClose);
			this.groupBox1.Controls.Add(this.buttonMacdinhMP);
			this.groupBox1.Controls.Add(this.buttonXuongMP);
			this.groupBox1.Controls.Add(this.buttonLenMP);
			this.groupBox1.Controls.Add(this.listView2);
			this.groupBox1.Location = new global::System.Drawing.Point(1, 168);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(210, 261);
			this.groupBox1.TabIndex = 141;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Môn phái";
			this.buttonMacdinhMP.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonMacdinhMP.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonMacdinhMP.ForeColor = global::System.Drawing.Color.Black;
			this.buttonMacdinhMP.Location = new global::System.Drawing.Point(144, 141);
			this.buttonMacdinhMP.Name = "buttonMacdinhMP";
			this.buttonMacdinhMP.Size = new global::System.Drawing.Size(59, 28);
			this.buttonMacdinhMP.TabIndex = 138;
			this.buttonMacdinhMP.Text = "Mặc định";
			this.buttonMacdinhMP.UseVisualStyleBackColor = false;
			this.buttonMacdinhMP.Click += new global::System.EventHandler(this.buttonMacdinhMP_Click);
			this.buttonXuongMP.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXuongMP.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonXuongMP.ForeColor = global::System.Drawing.Color.Black;
			this.buttonXuongMP.Location = new global::System.Drawing.Point(144, 90);
			this.buttonXuongMP.Name = "buttonXuongMP";
			this.buttonXuongMP.Size = new global::System.Drawing.Size(59, 28);
			this.buttonXuongMP.TabIndex = 135;
			this.buttonXuongMP.Text = "Xuống";
			this.buttonXuongMP.UseVisualStyleBackColor = false;
			this.buttonXuongMP.Click += new global::System.EventHandler(this.buttonXuongMP_Click);
			this.buttonLenMP.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonLenMP.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonLenMP.ForeColor = global::System.Drawing.Color.Black;
			this.buttonLenMP.Location = new global::System.Drawing.Point(144, 58);
			this.buttonLenMP.Name = "buttonLenMP";
			this.buttonLenMP.Size = new global::System.Drawing.Size(59, 28);
			this.buttonLenMP.TabIndex = 134;
			this.buttonLenMP.Text = "Lên";
			this.buttonLenMP.UseVisualStyleBackColor = false;
			this.buttonLenMP.Click += new global::System.EventHandler(this.buttonLenMP_Click);
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(8, 20);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(130, 226);
			this.listView2.TabIndex = 10;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_2.Text = "STT";
			this.columnHeader_2.Width = 30;
			this.columnHeader_3.Text = "Môn phái";
			this.columnHeader_3.Width = 80;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 21f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(213, 431);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.groupBoxNguHanh);
			this.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "FormUutienNguHanh";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UU TIEN";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormUutienNguHanh_Load);
			this.groupBoxNguHanh.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000D56 RID: 3414
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000D57 RID: 3415
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000D58 RID: 3416
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000D59 RID: 3417
		private global::System.Windows.Forms.Button buttonLen1;

		// Token: 0x04000D5A RID: 3418
		private global::System.Windows.Forms.Button buttonXuong1;

		// Token: 0x04000D5B RID: 3419
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000D5C RID: 3420
		private global::System.Windows.Forms.Button buttonUuTienMacdinh;

		// Token: 0x04000D5D RID: 3421
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000D5E RID: 3422
		private global::System.Windows.Forms.GroupBox groupBoxNguHanh;

		// Token: 0x04000D5F RID: 3423
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000D60 RID: 3424
		private global::System.Windows.Forms.Button buttonMacdinhMP;

		// Token: 0x04000D61 RID: 3425
		private global::System.Windows.Forms.Button buttonXuongMP;

		// Token: 0x04000D62 RID: 3426
		private global::System.Windows.Forms.Button buttonLenMP;

		// Token: 0x04000D63 RID: 3427
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x04000D64 RID: 3428
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000D65 RID: 3429
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000D66 RID: 3430
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;
	}
}
