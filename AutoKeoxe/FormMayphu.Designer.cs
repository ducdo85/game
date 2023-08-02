namespace AutoKeoxe
{
	// Token: 0x02000078 RID: 120
	public partial class FormMayphu : global::System.Windows.Forms.Form
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x001641D4 File Offset: 0x001623D4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormMayphu));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxThemAcc = new global::System.Windows.Forms.ComboBox();
			this.buttonThemAcc = new global::System.Windows.Forms.Button();
			this.buttonXoaAcc = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.ForeColor = global::System.Drawing.Color.Black;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(14, 74);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(396, 372);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 40;
			this.columnHeader_1.Text = "Tên nhân vật";
			this.columnHeader_1.Width = 200;
			this.comboBoxThemAcc.DropDownWidth = 120;
			this.comboBoxThemAcc.ForeColor = global::System.Drawing.Color.Black;
			this.comboBoxThemAcc.FormattingEnabled = true;
			this.comboBoxThemAcc.Location = new global::System.Drawing.Point(14, 460);
			this.comboBoxThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThemAcc.Name = "comboBoxThemAcc";
			this.comboBoxThemAcc.Size = new global::System.Drawing.Size(265, 28);
			this.comboBoxThemAcc.TabIndex = 63;
			this.comboBoxThemAcc.DropDown += new global::System.EventHandler(this.comboBoxThemAcc_DropDown);
			this.buttonThemAcc.ForeColor = global::System.Drawing.Color.Black;
			this.buttonThemAcc.Location = new global::System.Drawing.Point(14, 502);
			this.buttonThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThemAcc.Name = "buttonThemAcc";
			this.buttonThemAcc.Size = new global::System.Drawing.Size(267, 40);
			this.buttonThemAcc.TabIndex = 64;
			this.buttonThemAcc.Text = "Thêm tên ac vào danh sách";
			this.buttonThemAcc.UseVisualStyleBackColor = true;
			this.buttonThemAcc.Click += new global::System.EventHandler(this.buttonThemAcc_Click);
			this.buttonXoaAcc.ForeColor = global::System.Drawing.Color.Black;
			this.buttonXoaAcc.Location = new global::System.Drawing.Point(290, 457);
			this.buttonXoaAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaAcc.Name = "buttonXoaAcc";
			this.buttonXoaAcc.Size = new global::System.Drawing.Size(118, 35);
			this.buttonXoaAcc.TabIndex = 65;
			this.buttonXoaAcc.Text = "Xóa";
			this.buttonXoaAcc.UseVisualStyleBackColor = true;
			this.buttonXoaAcc.Click += new global::System.EventHandler(this.buttonXoaAcc_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label1.Location = new global::System.Drawing.Point(9, 8);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(402, 62);
			this.label1.TabIndex = 69;
			this.label1.Text = "Danh sách ac máy phụ cần thông báo, danh sách nếu càng ít thì tốc độ thông báo càng nhanh, do đó ac nào trong danh sách không online thì xóa đi nhé.";
			this.buttonClose.ForeColor = global::System.Drawing.Color.Black;
			this.buttonClose.Location = new global::System.Drawing.Point(290, 502);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(118, 40);
			this.buttonClose.TabIndex = 70;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(426, 552);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBoxThemAcc);
			base.Controls.Add(this.buttonThemAcc);
			base.Controls.Add(this.buttonXoaAcc);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormMayphu";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DANH SACH AC MAY PHU";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormMayphu_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000A57 RID: 2647
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000A58 RID: 2648
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000A59 RID: 2649
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000A5A RID: 2650
		private global::System.Windows.Forms.ComboBox comboBoxThemAcc;

		// Token: 0x04000A5B RID: 2651
		private global::System.Windows.Forms.Button buttonThemAcc;

		// Token: 0x04000A5C RID: 2652
		private global::System.Windows.Forms.Button buttonXoaAcc;

		// Token: 0x04000A5D RID: 2653
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A5E RID: 2654
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A5F RID: 2655
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000A60 RID: 2656
		private global::System.Windows.Forms.Button buttonClose;
	}
}
