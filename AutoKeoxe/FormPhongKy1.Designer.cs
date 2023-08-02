namespace AutoKeoxe
{
	// Token: 0x0200007D RID: 125
	public partial class FormPhongKy1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A0F RID: 2575 RVA: 0x0016B920 File Offset: 0x00169B20
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormPhongKy1));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonXoaPk2 = new global::System.Windows.Forms.Button();
			this.buttonXoaPk = new global::System.Windows.Forms.Button();
			this.label23 = new global::System.Windows.Forms.Label();
			this.listViewPk2 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.label22 = new global::System.Windows.Forms.Label();
			this.listViewPk1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonStopWritePathPk2 = new global::System.Windows.Forms.Button();
			this.buttonWritePathPk2 = new global::System.Windows.Forms.Button();
			this.buttonSavePathPk2 = new global::System.Windows.Forms.Button();
			this.buttonOpenPathPk2 = new global::System.Windows.Forms.Button();
			this.buttonStopWritePathPk = new global::System.Windows.Forms.Button();
			this.buttonWritePathPk = new global::System.Windows.Forms.Button();
			this.buttonSavePathPk = new global::System.Windows.Forms.Button();
			this.buttonOpenPathPk = new global::System.Windows.Forms.Button();
			this.buttonXoahet1 = new global::System.Windows.Forms.Button();
			this.buttonXoahet2 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonXoaPk2.Location = new global::System.Drawing.Point(369, 440);
			this.buttonXoaPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaPk2.Name = "buttonXoaPk2";
			this.buttonXoaPk2.Size = new global::System.Drawing.Size(124, 35);
			this.buttonXoaPk2.TabIndex = 254;
			this.buttonXoaPk2.Text = "Xóa";
			this.buttonXoaPk2.UseVisualStyleBackColor = true;
			this.buttonXoaPk2.Click += new global::System.EventHandler(this.buttonXoaPk2_Click);
			this.buttonXoaPk.Location = new global::System.Drawing.Point(123, 440);
			this.buttonXoaPk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaPk.Name = "buttonXoaPk";
			this.buttonXoaPk.Size = new global::System.Drawing.Size(128, 35);
			this.buttonXoaPk.TabIndex = 253;
			this.buttonXoaPk.Text = "Xóa";
			this.buttonXoaPk.UseVisualStyleBackColor = true;
			this.buttonXoaPk.Click += new global::System.EventHandler(this.buttonXoaPk_Click);
			this.label23.AutoSize = true;
			this.label23.Location = new global::System.Drawing.Point(12, 14);
			this.label23.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new global::System.Drawing.Size(164, 20);
			this.label23.TabIndex = 249;
			this.label23.Text = "#Đường dẫn ra tọa độ";
			this.listViewPk2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewPk2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listViewPk2.FullRowSelect = true;
			this.listViewPk2.GridLines = true;
			this.listViewPk2.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewPk2.HideSelection = false;
			this.listViewPk2.Location = new global::System.Drawing.Point(262, 85);
			this.listViewPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewPk2.MultiSelect = false;
			this.listViewPk2.Name = "listViewPk2";
			this.listViewPk2.Size = new global::System.Drawing.Size(232, 350);
			this.listViewPk2.TabIndex = 246;
			this.listViewPk2.UseCompatibleStateImageBehavior = false;
			this.listViewPk2.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "N";
			this.columnHeader_0.Width = 35;
			this.columnHeader_1.Text = "Tọa độ";
			this.columnHeader_1.Width = 95;
			this.label22.AutoSize = true;
			this.label22.Location = new global::System.Drawing.Point(261, 14);
			this.label22.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new global::System.Drawing.Size(175, 20);
			this.label22.TabIndex = 247;
			this.label22.Text = "##Tọa độ điểm trinh sát";
			this.listViewPk1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewPk1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_2,
				this.columnHeader_3
			});
			this.listViewPk1.FullRowSelect = true;
			this.listViewPk1.GridLines = true;
			this.listViewPk1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewPk1.HideSelection = false;
			this.listViewPk1.Location = new global::System.Drawing.Point(18, 85);
			this.listViewPk1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listViewPk1.MultiSelect = false;
			this.listViewPk1.Name = "listViewPk1";
			this.listViewPk1.Size = new global::System.Drawing.Size(232, 348);
			this.listViewPk1.TabIndex = 248;
			this.listViewPk1.UseCompatibleStateImageBehavior = false;
			this.listViewPk1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_2.Text = "N";
			this.columnHeader_2.Width = 35;
			this.columnHeader_3.Text = "Tọa độ";
			this.columnHeader_3.Width = 95;
			this.buttonStopWritePathPk2.Location = new global::System.Drawing.Point(448, 43);
			this.buttonStopWritePathPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStopWritePathPk2.Name = "buttonStopWritePathPk2";
			this.buttonStopWritePathPk2.Size = new global::System.Drawing.Size(45, 35);
			this.buttonStopWritePathPk2.TabIndex = 259;
			this.buttonStopWritePathPk2.UseVisualStyleBackColor = true;
			this.buttonStopWritePathPk2.Click += new global::System.EventHandler(this.buttonStopWritePathPk2_Click);
			this.buttonWritePathPk2.Location = new global::System.Drawing.Point(396, 43);
			this.buttonWritePathPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonWritePathPk2.Name = "buttonWritePathPk2";
			this.buttonWritePathPk2.Size = new global::System.Drawing.Size(45, 35);
			this.buttonWritePathPk2.TabIndex = 258;
			this.buttonWritePathPk2.UseVisualStyleBackColor = true;
			this.buttonWritePathPk2.Click += new global::System.EventHandler(this.buttonWritePathPk2_Click);
			this.buttonSavePathPk2.Location = new global::System.Drawing.Point(315, 43);
			this.buttonSavePathPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSavePathPk2.Name = "buttonSavePathPk2";
			this.buttonSavePathPk2.Size = new global::System.Drawing.Size(45, 35);
			this.buttonSavePathPk2.TabIndex = 257;
			this.buttonSavePathPk2.UseVisualStyleBackColor = true;
			this.buttonSavePathPk2.Click += new global::System.EventHandler(this.buttonSavePathPk2_Click);
			this.buttonOpenPathPk2.Location = new global::System.Drawing.Point(264, 43);
			this.buttonOpenPathPk2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOpenPathPk2.Name = "buttonOpenPathPk2";
			this.buttonOpenPathPk2.Size = new global::System.Drawing.Size(45, 35);
			this.buttonOpenPathPk2.TabIndex = 256;
			this.buttonOpenPathPk2.UseVisualStyleBackColor = true;
			this.buttonOpenPathPk2.Click += new global::System.EventHandler(this.buttonOpenPathPk2_Click);
			this.buttonStopWritePathPk.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonStopWritePathPk.Image");
			this.buttonStopWritePathPk.Location = new global::System.Drawing.Point(186, 43);
			this.buttonStopWritePathPk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonStopWritePathPk.Name = "buttonStopWritePathPk";
			this.buttonStopWritePathPk.Size = new global::System.Drawing.Size(45, 35);
			this.buttonStopWritePathPk.TabIndex = 255;
			this.buttonStopWritePathPk.UseVisualStyleBackColor = true;
			this.buttonStopWritePathPk.Click += new global::System.EventHandler(this.buttonStopWritePathPk_Click);
			this.buttonWritePathPk.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonWritePathPk.Image");
			this.buttonWritePathPk.Location = new global::System.Drawing.Point(136, 43);
			this.buttonWritePathPk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonWritePathPk.Name = "buttonWritePathPk";
			this.buttonWritePathPk.Size = new global::System.Drawing.Size(45, 35);
			this.buttonWritePathPk.TabIndex = 252;
			this.buttonWritePathPk.UseVisualStyleBackColor = true;
			this.buttonWritePathPk.Click += new global::System.EventHandler(this.buttonWritePathPk_Click);
			this.buttonSavePathPk.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSavePathPk.Image");
			this.buttonSavePathPk.Location = new global::System.Drawing.Point(69, 43);
			this.buttonSavePathPk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSavePathPk.Name = "buttonSavePathPk";
			this.buttonSavePathPk.Size = new global::System.Drawing.Size(45, 35);
			this.buttonSavePathPk.TabIndex = 251;
			this.buttonSavePathPk.UseVisualStyleBackColor = true;
			this.buttonSavePathPk.Click += new global::System.EventHandler(this.buttonSavePathPk_Click);
			this.buttonOpenPathPk.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonOpenPathPk.Image");
			this.buttonOpenPathPk.Location = new global::System.Drawing.Point(18, 43);
			this.buttonOpenPathPk.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOpenPathPk.Name = "buttonOpenPathPk";
			this.buttonOpenPathPk.Size = new global::System.Drawing.Size(45, 35);
			this.buttonOpenPathPk.TabIndex = 250;
			this.buttonOpenPathPk.UseVisualStyleBackColor = true;
			this.buttonOpenPathPk.Click += new global::System.EventHandler(this.buttonOpenPathPk_Click);
			this.buttonXoahet1.Location = new global::System.Drawing.Point(18, 440);
			this.buttonXoahet1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoahet1.Name = "buttonXoahet1";
			this.buttonXoahet1.Size = new global::System.Drawing.Size(96, 35);
			this.buttonXoahet1.TabIndex = 260;
			this.buttonXoahet1.Text = "Xóa hết";
			this.buttonXoahet1.UseVisualStyleBackColor = true;
			this.buttonXoahet1.Click += new global::System.EventHandler(this.buttonXoahet1_Click);
			this.buttonXoahet2.Location = new global::System.Drawing.Point(262, 440);
			this.buttonXoahet2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoahet2.Name = "buttonXoahet2";
			this.buttonXoahet2.Size = new global::System.Drawing.Size(98, 35);
			this.buttonXoahet2.TabIndex = 261;
			this.buttonXoahet2.Text = "Xóa hết";
			this.buttonXoahet2.UseVisualStyleBackColor = true;
			this.buttonXoahet2.Click += new global::System.EventHandler(this.buttonXoahet2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(501, 485);
			base.Controls.Add(this.buttonXoahet2);
			base.Controls.Add(this.buttonXoahet1);
			base.Controls.Add(this.buttonXoaPk2);
			base.Controls.Add(this.buttonXoaPk);
			base.Controls.Add(this.label23);
			base.Controls.Add(this.buttonStopWritePathPk2);
			base.Controls.Add(this.buttonWritePathPk2);
			base.Controls.Add(this.buttonSavePathPk2);
			base.Controls.Add(this.buttonOpenPathPk2);
			base.Controls.Add(this.listViewPk2);
			base.Controls.Add(this.buttonStopWritePathPk);
			base.Controls.Add(this.label22);
			base.Controls.Add(this.buttonWritePathPk);
			base.Controls.Add(this.listViewPk1);
			base.Controls.Add(this.buttonSavePathPk);
			base.Controls.Add(this.buttonOpenPathPk);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormPhongKy1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TOA DO PHONG KY";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormPhongKy1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000AC8 RID: 2760
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000AC9 RID: 2761
		private global::System.Windows.Forms.Button buttonXoaPk2;

		// Token: 0x04000ACA RID: 2762
		private global::System.Windows.Forms.Button buttonXoaPk;

		// Token: 0x04000ACB RID: 2763
		private global::System.Windows.Forms.Label label23;

		// Token: 0x04000ACC RID: 2764
		private global::System.Windows.Forms.Button buttonStopWritePathPk2;

		// Token: 0x04000ACD RID: 2765
		private global::System.Windows.Forms.Button buttonWritePathPk2;

		// Token: 0x04000ACE RID: 2766
		private global::System.Windows.Forms.Button buttonSavePathPk2;

		// Token: 0x04000ACF RID: 2767
		private global::System.Windows.Forms.Button buttonOpenPathPk2;

		// Token: 0x04000AD0 RID: 2768
		private global::System.Windows.Forms.ListView listViewPk2;

		// Token: 0x04000AD1 RID: 2769
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000AD2 RID: 2770
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000AD3 RID: 2771
		private global::System.Windows.Forms.Button buttonStopWritePathPk;

		// Token: 0x04000AD4 RID: 2772
		private global::System.Windows.Forms.Label label22;

		// Token: 0x04000AD5 RID: 2773
		private global::System.Windows.Forms.Button buttonWritePathPk;

		// Token: 0x04000AD6 RID: 2774
		private global::System.Windows.Forms.ListView listViewPk1;

		// Token: 0x04000AD7 RID: 2775
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000AD8 RID: 2776
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000AD9 RID: 2777
		private global::System.Windows.Forms.Button buttonSavePathPk;

		// Token: 0x04000ADA RID: 2778
		private global::System.Windows.Forms.Button buttonOpenPathPk;

		// Token: 0x04000ADB RID: 2779
		private global::System.Windows.Forms.Button buttonXoahet1;

		// Token: 0x04000ADC RID: 2780
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000ADD RID: 2781
		private global::System.Windows.Forms.Button buttonXoahet2;
	}
}
