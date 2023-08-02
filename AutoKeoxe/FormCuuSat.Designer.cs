namespace AutoKeoxe
{
	// Token: 0x0200006B RID: 107
	public partial class FormCuuSat : global::System.Windows.Forms.Form
	{
		// Token: 0x06000855 RID: 2133 RVA: 0x0013E694 File Offset: 0x0013C894
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormCuuSat));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxThemAcc = new global::System.Windows.Forms.ComboBox();
			this.buttonThemAcc = new global::System.Windows.Forms.Button();
			this.buttonXoaAcc = new global::System.Windows.Forms.Button();
			this.checkBoxCuusatTheoDs = new global::System.Windows.Forms.CheckBox();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1
			});
			this.listView1.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(12, 29);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(334, 264);
			this.listView1.TabIndex = 2;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "No";
			this.columnHeader_0.Width = 40;
			this.columnHeader_1.Text = "Tên nhân vật";
			this.columnHeader_1.Width = 160;
			this.comboBoxThemAcc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThemAcc.DropDownWidth = 120;
			this.comboBoxThemAcc.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.comboBoxThemAcc.FormattingEnabled = true;
			this.comboBoxThemAcc.Location = new global::System.Drawing.Point(9, 303);
			this.comboBoxThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxThemAcc.Name = "comboBoxThemAcc";
			this.comboBoxThemAcc.Size = new global::System.Drawing.Size(187, 28);
			this.comboBoxThemAcc.TabIndex = 63;
			this.comboBoxThemAcc.DropDown += new global::System.EventHandler(this.comboBoxThemAcc_DropDown);
			this.buttonThemAcc.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonThemAcc.Location = new global::System.Drawing.Point(207, 302);
			this.buttonThemAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThemAcc.Name = "buttonThemAcc";
			this.buttonThemAcc.Size = new global::System.Drawing.Size(75, 35);
			this.buttonThemAcc.TabIndex = 64;
			this.buttonThemAcc.Text = "Thêm";
			this.buttonThemAcc.UseVisualStyleBackColor = true;
			this.buttonThemAcc.Click += new global::System.EventHandler(this.buttonThemAcc_Click);
			this.buttonXoaAcc.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.buttonXoaAcc.Location = new global::System.Drawing.Point(285, 302);
			this.buttonXoaAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoaAcc.Name = "buttonXoaAcc";
			this.buttonXoaAcc.Size = new global::System.Drawing.Size(63, 35);
			this.buttonXoaAcc.TabIndex = 65;
			this.buttonXoaAcc.Text = "Xóa";
			this.buttonXoaAcc.UseVisualStyleBackColor = true;
			this.buttonXoaAcc.Click += new global::System.EventHandler(this.buttonXoaAcc_Click);
			this.checkBoxCuusatTheoDs.AutoSize = true;
			this.checkBoxCuusatTheoDs.BackColor = global::System.Drawing.SystemColors.Control;
			this.checkBoxCuusatTheoDs.ForeColor = global::System.Drawing.Color.Red;
			this.checkBoxCuusatTheoDs.Location = new global::System.Drawing.Point(3, 435);
			this.checkBoxCuusatTheoDs.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxCuusatTheoDs.Name = "checkBoxCuusatTheoDs";
			this.checkBoxCuusatTheoDs.Size = new global::System.Drawing.Size(337, 24);
			this.checkBoxCuusatTheoDs.TabIndex = 68;
			this.checkBoxCuusatTheoDs.Text = "Cừu sát theo danh sách ở trên (gặp là bụp)";
			this.checkBoxCuusatTheoDs.UseVisualStyleBackColor = false;
			this.checkBoxCuusatTheoDs.CheckedChanged += new global::System.EventHandler(this.checkBoxCuusatTheoDs_CheckedChanged);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.groupBox1.Controls.Add(this.listView1);
			this.groupBox1.Controls.Add(this.comboBoxThemAcc);
			this.groupBox1.Controls.Add(this.buttonThemAcc);
			this.groupBox1.Controls.Add(this.buttonXoaAcc);
			this.groupBox1.Location = new global::System.Drawing.Point(3, 80);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new global::System.Drawing.Size(369, 349);
			this.groupBox1.TabIndex = 73;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách cừu sát";
			this.label3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.ForeColor = global::System.Drawing.Color.DarkRed;
			this.label3.Location = new global::System.Drawing.Point(3, 2);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(369, 69);
			this.label3.TabIndex = 77;
			this.label3.Text = "Lưu ý:  Danh sách cừu sát chỉ nên có trên dưới 5 ac thôi vì nếu càng nhiều thì sẽ làm % cpu tăng cao, dẫn đến lag và diss game.";
			this.label3.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(378, 468);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.checkBoxCuusatTheoDs);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormCuuSat";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CUU SAT";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormCuuSat_Load);
			this.groupBox1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000855 RID: 2133
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000856 RID: 2134
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000857 RID: 2135
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000858 RID: 2136
		private global::System.Windows.Forms.ComboBox comboBoxThemAcc;

		// Token: 0x04000859 RID: 2137
		private global::System.Windows.Forms.Button buttonThemAcc;

		// Token: 0x0400085A RID: 2138
		private global::System.Windows.Forms.Button buttonXoaAcc;

		// Token: 0x0400085B RID: 2139
		private global::System.Windows.Forms.CheckBox checkBoxCuusatTheoDs;

		// Token: 0x0400085C RID: 2140
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400085D RID: 2141
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400085E RID: 2142
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000867 RID: 2151
		private global::System.ComponentModel.IContainer components;
	}
}
