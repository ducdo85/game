namespace AutoKeoxe
{
	// Token: 0x020000E0 RID: 224
	public partial class ThemXoaDanhsach : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x001983BC File Offset: 0x001965BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.ThemXoaDanhsach));
			this.buttonAddAll = new global::System.Windows.Forms.Button();
			this.buttonTrave = new global::System.Windows.Forms.Button();
			this.buttonDemqua = new global::System.Windows.Forms.Button();
			this.listView2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonXoatatca = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.labelThongtin = new global::System.Windows.Forms.Label();
			this.buttonStickAll = new global::System.Windows.Forms.Button();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonXoahet = new global::System.Windows.Forms.Button();
			this.listViewOff = new global::System.Windows.Forms.ListView();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.buttonAddAll.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonAddAll.ForeColor = global::System.Drawing.Color.Red;
			this.buttonAddAll.Location = new global::System.Drawing.Point(6, 435);
			this.buttonAddAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAddAll.Name = "buttonAddAll";
			this.buttonAddAll.Size = new global::System.Drawing.Size(118, 40);
			this.buttonAddAll.TabIndex = 16;
			this.buttonAddAll.Text = "Thêm tất cả";
			this.buttonAddAll.UseVisualStyleBackColor = false;
			this.buttonAddAll.Click += new global::System.EventHandler(this.buttonAddAll_Click);
			this.buttonTrave.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonTrave.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonTrave.Location = new global::System.Drawing.Point(176, 391);
			this.buttonTrave.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonTrave.Name = "buttonTrave";
			this.buttonTrave.Size = new global::System.Drawing.Size(82, 40);
			this.buttonTrave.TabIndex = 13;
			this.buttonTrave.Text = "Xóa 1";
			this.buttonTrave.UseVisualStyleBackColor = false;
			this.buttonTrave.Click += new global::System.EventHandler(this.buttonTrave_Click);
			this.buttonDemqua.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonDemqua.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonDemqua.Location = new global::System.Drawing.Point(6, 391);
			this.buttonDemqua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDemqua.Name = "buttonDemqua";
			this.buttonDemqua.Size = new global::System.Drawing.Size(160, 40);
			this.buttonDemqua.TabIndex = 12;
			this.buttonDemqua.Text = "Thêm 1 ac";
			this.buttonDemqua.UseVisualStyleBackColor = false;
			this.buttonDemqua.Click += new global::System.EventHandler(this.buttonDemqua_Click);
			this.listView2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView2.FullRowSelect = true;
			this.listView2.GridLines = true;
			this.listView2.HideSelection = false;
			this.listView2.Location = new global::System.Drawing.Point(174, 34);
			this.listView2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView2.MultiSelect = false;
			this.listView2.Name = "listView2";
			this.listView2.Size = new global::System.Drawing.Size(168, 346);
			this.listView2.TabIndex = 10;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = global::System.Windows.Forms.View.Details;
			this.listView2.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView2_MouseUp);
			this.columnHeader_0.Text = "Nhân vật";
			this.columnHeader_0.Width = 105;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_1
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(3, 34);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(166, 346);
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_1.Text = "Nhân vật";
			this.columnHeader_1.Width = 105;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonXoatatca.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXoatatca.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonXoatatca.Location = new global::System.Drawing.Point(261, 391);
			this.buttonXoatatca.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoatatca.Name = "buttonXoatatca";
			this.buttonXoatatca.Size = new global::System.Drawing.Size(84, 40);
			this.buttonXoatatca.TabIndex = 17;
			this.buttonXoatatca.Text = "Xóa hết";
			this.buttonXoatatca.UseVisualStyleBackColor = false;
			this.buttonXoatatca.Click += new global::System.EventHandler(this.buttonXoatatca_Click);
			this.buttonClose.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonClose.ForeColor = global::System.Drawing.SystemColors.WindowText;
			this.buttonClose.Location = new global::System.Drawing.Point(261, 435);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(84, 40);
			this.buttonClose.TabIndex = 18;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.labelThongtin.AutoSize = true;
			this.labelThongtin.ForeColor = global::System.Drawing.Color.Black;
			this.labelThongtin.Location = new global::System.Drawing.Point(6, 6);
			this.labelThongtin.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelThongtin.Name = "labelThongtin";
			this.labelThongtin.Size = new global::System.Drawing.Size(75, 20);
			this.labelThongtin.TabIndex = 19;
			this.labelThongtin.Text = "Thông tin";
			this.buttonStickAll.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonStickAll.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonStickAll.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonStickAll.Location = new global::System.Drawing.Point(134, 435);
			this.buttonStickAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStickAll.Name = "buttonStickAll";
			this.buttonStickAll.Size = new global::System.Drawing.Size(124, 40);
			this.buttonStickAll.TabIndex = 158;
			this.buttonStickAll.Text = "Stick tất cả";
			this.buttonStickAll.UseVisualStyleBackColor = false;
			this.buttonStickAll.Click += new global::System.EventHandler(this.buttonStickAll_Click);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(2, 0);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(358, 518);
			this.tabControl1.TabIndex = 159;
			this.tabPage1.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.tabPage1.Controls.Add(this.buttonStickAll);
			this.tabPage1.Controls.Add(this.buttonClose);
			this.tabPage1.Controls.Add(this.buttonAddAll);
			this.tabPage1.Controls.Add(this.labelThongtin);
			this.tabPage1.Controls.Add(this.buttonDemqua);
			this.tabPage1.Controls.Add(this.buttonTrave);
			this.tabPage1.Controls.Add(this.buttonXoatatca);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Controls.Add(this.listView2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(350, 485);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ac đang online";
			this.tabPage2.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.buttonXoahet);
			this.tabPage2.Controls.Add(this.listViewOff);
			this.tabPage2.Controls.Add(this.buttonXoa);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(350, 485);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Ac offline hoặc bị diss";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Black;
			this.label1.Location = new global::System.Drawing.Point(6, 6);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(292, 20);
			this.label1.TabIndex = 160;
			this.label1.Text = "Các ac bị diss hoặc thoát được lưu ở đây";
			this.buttonXoahet.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXoahet.Location = new global::System.Drawing.Point(186, 429);
			this.buttonXoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoahet.Name = "buttonXoahet";
			this.buttonXoahet.Size = new global::System.Drawing.Size(159, 40);
			this.buttonXoahet.TabIndex = 161;
			this.buttonXoahet.Text = "Xóa hết";
			this.buttonXoahet.UseVisualStyleBackColor = false;
			this.buttonXoahet.Click += new global::System.EventHandler(this.buttonXoahet_Click);
			this.listViewOff.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listViewOff.FullRowSelect = true;
			this.listViewOff.GridLines = true;
			this.listViewOff.HideSelection = false;
			this.listViewOff.Location = new global::System.Drawing.Point(3, 38);
			this.listViewOff.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewOff.MultiSelect = false;
			this.listViewOff.Name = "listViewOff";
			this.listViewOff.Size = new global::System.Drawing.Size(340, 376);
			this.listViewOff.TabIndex = 160;
			this.listViewOff.UseCompatibleStateImageBehavior = false;
			this.listViewOff.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_2.Text = "STT";
			this.columnHeader_2.Width = 40;
			this.columnHeader_3.Text = "Nhân vật";
			this.columnHeader_3.Width = 165;
			this.buttonXoa.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonXoa.Location = new global::System.Drawing.Point(9, 429);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(168, 40);
			this.buttonXoa.TabIndex = 160;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = false;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(356, 515);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "ThemXoaDanhsach";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "DANH SACH";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.ThemXoaDanhsach_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400111A RID: 4378
		private global::System.Windows.Forms.Button buttonAddAll;

		// Token: 0x0400111B RID: 4379
		private global::System.Windows.Forms.Button buttonTrave;

		// Token: 0x0400111C RID: 4380
		private global::System.Windows.Forms.Button buttonDemqua;

		// Token: 0x0400111D RID: 4381
		private global::System.Windows.Forms.ListView listView2;

		// Token: 0x0400111E RID: 4382
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400111F RID: 4383
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04001120 RID: 4384
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04001121 RID: 4385
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04001122 RID: 4386
		private global::System.Windows.Forms.Button buttonXoatatca;

		// Token: 0x04001123 RID: 4387
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04001124 RID: 4388
		private global::System.Windows.Forms.Label labelThongtin;

		// Token: 0x04001125 RID: 4389
		private global::System.Windows.Forms.Button buttonStickAll;

		// Token: 0x04001126 RID: 4390
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04001127 RID: 4391
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04001128 RID: 4392
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04001129 RID: 4393
		private global::System.Windows.Forms.ListView listViewOff;

		// Token: 0x0400112A RID: 4394
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x0400112B RID: 4395
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x0400112C RID: 4396
		private global::System.Windows.Forms.Button buttonXoahet;

		// Token: 0x0400112D RID: 4397
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x0400112E RID: 4398
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400112F RID: 4399
		private global::System.Windows.Forms.Label label1;
	}
}
