namespace AutoKeoxe
{
	// Token: 0x0200006A RID: 106
	public partial class FormCompatibility : global::System.Windows.Forms.Form
	{
		// Token: 0x0600083D RID: 2109 RVA: 0x0013C4D0 File Offset: 0x0013A6D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormCompatibility));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.buttonFix = new global::System.Windows.Forms.Button();
			this.textBoxPhienBan = new global::System.Windows.Forms.TextBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.buttonDefender = new global::System.Windows.Forms.Button();
			this.textBoxThongso = new global::System.Windows.Forms.TextBox();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.buttonXoahet = new global::System.Windows.Forms.Button();
			this.textBoxItem = new global::System.Windows.Forms.TextBox();
			this.buttonReFresh = new global::System.Windows.Forms.Button();
			this.buttonOpen = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonClose.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonClose.Location = new global::System.Drawing.Point(453, 266);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(88, 58);
			this.buttonClose.TabIndex = 14;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.buttonFix.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonFix.Location = new global::System.Drawing.Point(9, 266);
			this.buttonFix.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonFix.Name = "buttonFix";
			this.buttonFix.Size = new global::System.Drawing.Size(232, 58);
			this.buttonFix.TabIndex = 17;
			this.buttonFix.Text = "Chuyển game sang chế độ 16-bit Windows 8, 10";
			this.buttonFix.UseVisualStyleBackColor = false;
			this.buttonFix.Click += new global::System.EventHandler(this.buttonFix_Click);
			this.textBoxPhienBan.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBoxPhienBan.Location = new global::System.Drawing.Point(186, 42);
			this.textBoxPhienBan.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxPhienBan.Name = "textBoxPhienBan";
			this.textBoxPhienBan.ReadOnly = true;
			this.textBoxPhienBan.Size = new global::System.Drawing.Size(354, 26);
			this.textBoxPhienBan.TabIndex = 18;
			this.richTextBox1.Location = new global::System.Drawing.Point(9, 83);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(530, 156);
			this.richTextBox1.TabIndex = 20;
			this.richTextBox1.Text = "";
			this.buttonDefender.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonDefender.Location = new global::System.Drawing.Point(250, 266);
			this.buttonDefender.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonDefender.Name = "buttonDefender";
			this.buttonDefender.Size = new global::System.Drawing.Size(194, 58);
			this.buttonDefender.TabIndex = 23;
			this.buttonDefender.Text = "Tắt Defender trên Windows 8 và 10";
			this.buttonDefender.UseVisualStyleBackColor = false;
			this.buttonDefender.Click += new global::System.EventHandler(this.buttonDefender_Click);
			this.textBoxThongso.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBoxThongso.Location = new global::System.Drawing.Point(186, 6);
			this.textBoxThongso.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxThongso.Name = "textBoxThongso";
			this.textBoxThongso.ReadOnly = true;
			this.textBoxThongso.Size = new global::System.Drawing.Size(354, 26);
			this.textBoxThongso.TabIndex = 25;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(562, 378);
			this.tabControl1.TabIndex = 31;
			this.tabPage1.BackColor = global::System.Drawing.Color.LightSteelBlue;
			this.tabPage1.Controls.Add(this.buttonDefender);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.buttonFix);
			this.tabPage1.Controls.Add(this.buttonClose);
			this.tabPage1.Controls.Add(this.richTextBox1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.textBoxThongso);
			this.tabPage1.Controls.Add(this.textBoxPhienBan);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage1.Size = new global::System.Drawing.Size(554, 345);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sửa lỗi cash, diss game";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(4, 46);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(148, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "Phiên bản Windows";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 8);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(138, 20);
			this.label2.TabIndex = 31;
			this.label2.Text = "Thông số máy tính";
			this.tabPage2.Controls.Add(this.buttonXoahet);
			this.tabPage2.Controls.Add(this.textBoxItem);
			this.tabPage2.Controls.Add(this.buttonReFresh);
			this.tabPage2.Controls.Add(this.buttonOpen);
			this.tabPage2.Controls.Add(this.buttonXoa);
			this.tabPage2.Controls.Add(this.listView1);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 29);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPage2.Size = new global::System.Drawing.Size(554, 345);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Các khởi động cùng Windows";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.buttonXoahet.Location = new global::System.Drawing.Point(118, 295);
			this.buttonXoahet.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoahet.Name = "buttonXoahet";
			this.buttonXoahet.Size = new global::System.Drawing.Size(105, 40);
			this.buttonXoahet.TabIndex = 21;
			this.buttonXoahet.Text = "Xóa hết";
			this.buttonXoahet.UseVisualStyleBackColor = true;
			this.buttonXoahet.Click += new global::System.EventHandler(this.buttonXoahet_Click);
			this.textBoxItem.BackColor = global::System.Drawing.Color.LightGray;
			this.textBoxItem.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBoxItem.Font = new global::System.Drawing.Font("Candara", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxItem.Location = new global::System.Drawing.Point(3, 246);
			this.textBoxItem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxItem.Multiline = true;
			this.textBoxItem.Name = "textBoxItem";
			this.textBoxItem.Size = new global::System.Drawing.Size(543, 40);
			this.textBoxItem.TabIndex = 15;
			this.textBoxItem.Text = "...";
			this.buttonReFresh.Location = new global::System.Drawing.Point(420, 295);
			this.buttonReFresh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonReFresh.Name = "buttonReFresh";
			this.buttonReFresh.Size = new global::System.Drawing.Size(130, 40);
			this.buttonReFresh.TabIndex = 14;
			this.buttonReFresh.Text = "ReFresh";
			this.buttonReFresh.UseVisualStyleBackColor = true;
			this.buttonReFresh.Click += new global::System.EventHandler(this.buttonReFresh_Click);
			this.buttonOpen.Location = new global::System.Drawing.Point(255, 295);
			this.buttonOpen.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new global::System.Drawing.Size(156, 40);
			this.buttonOpen.TabIndex = 13;
			this.buttonOpen.Text = "Mở đường dẫn";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new global::System.EventHandler(this.buttonOpen_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(4, 295);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(105, 40);
			this.buttonXoa.TabIndex = 12;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(0, 0);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(548, 241);
			this.listView1.TabIndex = 11;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 25;
			this.columnHeader_1.Text = "Tên";
			this.columnHeader_1.Width = 100;
			this.columnHeader_2.Text = "Đường dẫn";
			this.columnHeader_2.Width = 220;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new global::System.Drawing.Size(566, 377);
			base.Controls.Add(this.tabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormCompatibility";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FIX CASH DISS GAME";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormCompatibility_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000835 RID: 2101
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000836 RID: 2102
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000837 RID: 2103
		private global::System.Windows.Forms.Button buttonFix;

		// Token: 0x04000838 RID: 2104
		private global::System.Windows.Forms.TextBox textBoxPhienBan;

		// Token: 0x04000839 RID: 2105
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400083A RID: 2106
		private global::System.Windows.Forms.Button buttonDefender;

		// Token: 0x0400083B RID: 2107
		private global::System.Windows.Forms.TextBox textBoxThongso;

		// Token: 0x0400083C RID: 2108
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400083D RID: 2109
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400083E RID: 2110
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400083F RID: 2111
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000840 RID: 2112
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000841 RID: 2113
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000842 RID: 2114
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000843 RID: 2115
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000844 RID: 2116
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000845 RID: 2117
		private global::System.Windows.Forms.Button buttonOpen;

		// Token: 0x04000846 RID: 2118
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000847 RID: 2119
		private global::System.Windows.Forms.Button buttonReFresh;

		// Token: 0x04000848 RID: 2120
		private global::System.Windows.Forms.TextBox textBoxItem;

		// Token: 0x04000849 RID: 2121
		private global::System.Windows.Forms.Button buttonXoahet;

		// Token: 0x04000852 RID: 2130
		private global::System.ComponentModel.IContainer components;
	}
}
