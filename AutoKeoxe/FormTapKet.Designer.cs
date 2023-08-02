namespace AutoKeoxe
{
	// Token: 0x02000084 RID: 132
	public partial class FormTapKet : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x0017DACC File Offset: 0x0017BCCC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormTapKet));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader_6 = new global::System.Windows.Forms.ColumnHeader();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBoxMenu = new global::System.Windows.Forms.TextBox();
			this.buttonHelp = new global::System.Windows.Forms.Button();
			this.comboBoxChon = new global::System.Windows.Forms.ComboBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.buttonSua = new global::System.Windows.Forms.Button();
			this.checkBoxNhapSL = new global::System.Windows.Forms.CheckBox();
			this.textBoxNhapSL = new global::System.Windows.Forms.TextBox();
			this.checkBoxMatMa = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.comboBoxNpc = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0,
				this.columnHeader_1,
				this.columnHeader_2,
				this.columnHeader_3,
				this.columnHeader_4,
				this.columnHeader_5,
				this.columnHeader_6
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(6, 148);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(628, 167);
			this.listView1.TabIndex = 218;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader_0.Text = "STT";
			this.columnHeader_0.Width = 35;
			this.columnHeader_1.Text = "NPC / Vật phẩm";
			this.columnHeader_1.Width = 130;
			this.columnHeader_2.Text = "Tọa độ";
			this.columnHeader_3.Text = "Menu";
			this.columnHeader_3.Width = 40;
			this.columnHeader_4.Text = "Bản đồ";
			this.columnHeader_4.Width = 50;
			this.columnHeader_5.Text = "Nhập số lượng";
			this.columnHeader_5.Width = 50;
			this.columnHeader_6.Text = "Có mật mã";
			this.columnHeader_6.Width = 30;
			this.buttonThem.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonThem.Location = new global::System.Drawing.Point(51, 522);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(154, 48);
			this.buttonThem.TabIndex = 219;
			this.buttonThem.Text = "Thêm vào";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(480, 325);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(140, 40);
			this.buttonXoa.TabIndex = 220;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.buttonClose.Location = new global::System.Drawing.Point(480, 525);
			this.buttonClose.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(140, 45);
			this.buttonClose.TabIndex = 222;
			this.buttonClose.Text = "Đóng";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(39, 445);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(205, 20);
			this.label1.TabIndex = 223;
			this.label1.Text = "Có click vào các dòng menu";
			this.textBoxMenu.Location = new global::System.Drawing.Point(279, 440);
			this.textBoxMenu.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxMenu.Name = "textBoxMenu";
			this.textBoxMenu.Size = new global::System.Drawing.Size(110, 26);
			this.textBoxMenu.TabIndex = 224;
			this.buttonHelp.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.buttonHelp.Location = new global::System.Drawing.Point(480, 468);
			this.buttonHelp.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonHelp.Name = "buttonHelp";
			this.buttonHelp.Size = new global::System.Drawing.Size(140, 45);
			this.buttonHelp.TabIndex = 225;
			this.buttonHelp.Text = "Hướng dẫn";
			this.buttonHelp.UseVisualStyleBackColor = true;
			this.buttonHelp.Click += new global::System.EventHandler(this.buttonHelp_Click);
			this.comboBoxChon.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChon.FormattingEnabled = true;
			this.comboBoxChon.Location = new global::System.Drawing.Point(12, 360);
			this.comboBoxChon.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxChon.Name = "comboBoxChon";
			this.comboBoxChon.Size = new global::System.Drawing.Size(378, 28);
			this.comboBoxChon.TabIndex = 226;
			this.comboBoxChon.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxChon_MouseDown);
			this.richTextBox1.Location = new global::System.Drawing.Point(6, 5);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(626, 132);
			this.richTextBox1.TabIndex = 227;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.buttonSua.Location = new global::System.Drawing.Point(228, 522);
			this.buttonSua.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new global::System.Drawing.Size(112, 48);
			this.buttonSua.TabIndex = 228;
			this.buttonSua.Text = "Sửa";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new global::System.EventHandler(this.buttonSua_Click);
			this.checkBoxNhapSL.AutoSize = true;
			this.checkBoxNhapSL.Location = new global::System.Drawing.Point(12, 478);
			this.checkBoxNhapSL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxNhapSL.Name = "checkBoxNhapSL";
			this.checkBoxNhapSL.Size = new global::System.Drawing.Size(159, 24);
			this.checkBoxNhapSL.TabIndex = 230;
			this.checkBoxNhapSL.Text = "Có nhập số lượng";
			this.checkBoxNhapSL.UseVisualStyleBackColor = true;
			this.textBoxNhapSL.Location = new global::System.Drawing.Point(279, 475);
			this.textBoxNhapSL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxNhapSL.Name = "textBoxNhapSL";
			this.textBoxNhapSL.Size = new global::System.Drawing.Size(110, 26);
			this.textBoxNhapSL.TabIndex = 231;
			this.checkBoxMatMa.AutoSize = true;
			this.checkBoxMatMa.Location = new global::System.Drawing.Point(15, 403);
			this.checkBoxMatMa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxMatMa.Name = "checkBoxMatMa";
			this.checkBoxMatMa.Size = new global::System.Drawing.Size(353, 24);
			this.checkBoxMatMa.TabIndex = 232;
			this.checkBoxMatMa.Text = "Có cần nhập mật mã ngẫu nhiên khi click npc";
			this.checkBoxMatMa.UseVisualStyleBackColor = true;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(4, 326);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(194, 20);
			this.label2.TabIndex = 233;
			this.label2.Text = "Đây là npc hay vật phẩm ?";
			this.comboBoxNpc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxNpc.FormattingEnabled = true;
			this.comboBoxNpc.Location = new global::System.Drawing.Point(228, 320);
			this.comboBoxNpc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxNpc.Name = "comboBoxNpc";
			this.comboBoxNpc.Size = new global::System.Drawing.Size(162, 28);
			this.comboBoxNpc.TabIndex = 234;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(638, 575);
			base.Controls.Add(this.comboBoxNpc);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.checkBoxMatMa);
			base.Controls.Add(this.textBoxNhapSL);
			base.Controls.Add(this.checkBoxNhapSL);
			base.Controls.Add(this.textBoxMenu);
			base.Controls.Add(this.buttonSua);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.comboBoxChon);
			base.Controls.Add(this.buttonHelp);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.Name = "FormTapKet";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "TAP KET";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormTapKet_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000BE8 RID: 3048
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000BE9 RID: 3049
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000BEA RID: 3050
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000BEB RID: 3051
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000BEC RID: 3052
		private global::System.Windows.Forms.Button buttonClose;

		// Token: 0x04000BED RID: 3053
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000BEE RID: 3054
		private global::System.Windows.Forms.ColumnHeader columnHeader_1;

		// Token: 0x04000BEF RID: 3055
		private global::System.Windows.Forms.ColumnHeader columnHeader_2;

		// Token: 0x04000BF0 RID: 3056
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000BF1 RID: 3057
		private global::System.Windows.Forms.TextBox textBoxMenu;

		// Token: 0x04000BF2 RID: 3058
		private global::System.Windows.Forms.ColumnHeader columnHeader_3;

		// Token: 0x04000BF3 RID: 3059
		private global::System.Windows.Forms.ColumnHeader columnHeader_4;

		// Token: 0x04000BF4 RID: 3060
		private global::System.Windows.Forms.Button buttonHelp;

		// Token: 0x04000BF5 RID: 3061
		private global::System.Windows.Forms.ComboBox comboBoxChon;

		// Token: 0x04000BF6 RID: 3062
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000BF7 RID: 3063
		private global::System.Windows.Forms.Button buttonSua;

		// Token: 0x04000BF8 RID: 3064
		private global::System.Windows.Forms.CheckBox checkBoxNhapSL;

		// Token: 0x04000BF9 RID: 3065
		private global::System.Windows.Forms.TextBox textBoxNhapSL;

		// Token: 0x04000BFA RID: 3066
		private global::System.Windows.Forms.ColumnHeader columnHeader_5;

		// Token: 0x04000BFB RID: 3067
		private global::System.Windows.Forms.CheckBox checkBoxMatMa;

		// Token: 0x04000BFC RID: 3068
		private global::System.Windows.Forms.ColumnHeader columnHeader_6;

		// Token: 0x04000BFD RID: 3069
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000BFE RID: 3070
		private global::System.Windows.Forms.ComboBox comboBoxNpc;

		// Token: 0x04000C09 RID: 3081
		private global::System.ComponentModel.IContainer components;
	}
}
