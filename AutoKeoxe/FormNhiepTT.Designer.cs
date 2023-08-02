namespace AutoKeoxe
{
	// Token: 0x0200007B RID: 123
	public partial class FormNhiepTT : global::System.Windows.Forms.Form
	{
		// Token: 0x060009DA RID: 2522 RVA: 0x0016630C File Offset: 0x0016450C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormNhiepTT));
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.checkBoxTuchuyenThanh = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTDP = new global::System.Windows.Forms.CheckBox();
			this.checkBoxLongHH = new global::System.Windows.Forms.CheckBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboBoxAn = new global::System.Windows.Forms.ComboBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBoxSL = new global::System.Windows.Forms.TextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonThoat.Location = new global::System.Drawing.Point(400, 632);
			this.buttonThoat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(105, 42);
			this.buttonThoat.TabIndex = 6;
			this.buttonThoat.Text = "Đóng";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 15);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(198, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Báo danh Vượt ải tại thành";
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(288, 9);
			this.comboBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(224, 28);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(6, 89);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(133, 441);
			this.listView1.TabIndex = 9;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.listView1_ItemCheck);
			this.columnHeader_0.Text = "Khung giờ";
			this.columnHeader_0.Width = 70;
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(146, 51);
			this.comboBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(367, 28);
			this.comboBox2.TabIndex = 11;
			this.comboBox2.SelectedIndexChanged += new global::System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.richTextBox1.Location = new global::System.Drawing.Point(146, 89);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(367, 409);
			this.richTextBox1.TabIndex = 12;
			this.richTextBox1.Text = "";
			this.checkBoxTuchuyenThanh.AutoSize = true;
			this.checkBoxTuchuyenThanh.Location = new global::System.Drawing.Point(153, 508);
			this.checkBoxTuchuyenThanh.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTuchuyenThanh.Name = "checkBoxTuchuyenThanh";
			this.checkBoxTuchuyenThanh.Size = new global::System.Drawing.Size(282, 24);
			this.checkBoxTuchuyenThanh.TabIndex = 13;
			this.checkBoxTuchuyenThanh.Text = "Tự chuyển qua thành khác nếu đầy";
			this.checkBoxTuchuyenThanh.UseVisualStyleBackColor = true;
			this.checkBoxTuchuyenThanh.CheckedChanged += new global::System.EventHandler(this.checkBoxTuchuyenThanh_CheckedChanged);
			this.checkBoxTDP.AutoSize = true;
			this.checkBoxTDP.Location = new global::System.Drawing.Point(153, 543);
			this.checkBoxTDP.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTDP.Name = "checkBoxTDP";
			this.checkBoxTDP.Size = new global::System.Drawing.Size(300, 24);
			this.checkBoxTDP.TabIndex = 14;
			this.checkBoxTDP.Text = "Tự thổ địa phù về nếu đang chiến đấu";
			this.checkBoxTDP.UseVisualStyleBackColor = true;
			this.checkBoxTDP.CheckedChanged += new global::System.EventHandler(this.checkBoxTDP_CheckedChanged);
			this.checkBoxLongHH.AutoSize = true;
			this.checkBoxLongHH.Location = new global::System.Drawing.Point(153, 582);
			this.checkBoxLongHH.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLongHH.Name = "checkBoxLongHH";
			this.checkBoxLongHH.Size = new global::System.Drawing.Size(75, 24);
			this.checkBoxLongHH.TabIndex = 15;
			this.checkBoxLongHH.Text = "Tự ăn";
			this.checkBoxLongHH.UseVisualStyleBackColor = true;
			this.checkBoxLongHH.CheckedChanged += new global::System.EventHandler(this.checkBoxLongHH_CheckedChanged);
			this.button1.Location = new global::System.Drawing.Point(6, 48);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(135, 35);
			this.button1.TabIndex = 16;
			this.button1.Text = "Xóa khung giờ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.Location = new global::System.Drawing.Point(4, 545);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(138, 62);
			this.label2.TabIndex = 17;
			this.label2.Text = "Báo danh sớm (-) hoặc trễ (+) hơn";
			this.numericUpDown1.Location = new global::System.Drawing.Point(9, 614);
			this.numericUpDown1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 59;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown1.Minimum = new decimal(new int[]
			{
				59,
				0,
				0,
				int.MinValue
			});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(74, 26);
			this.numericUpDown1.TabIndex = 18;
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(88, 620);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(41, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "phút";
			this.comboBoxAn.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAn.FormattingEnabled = true;
			this.comboBoxAn.Location = new global::System.Drawing.Point(243, 578);
			this.comboBoxAn.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxAn.Name = "comboBoxAn";
			this.comboBoxAn.Size = new global::System.Drawing.Size(184, 28);
			this.comboBoxAn.TabIndex = 20;
			this.comboBoxAn.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxAn_SelectedIndexChanged);
			this.comboBoxAn.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.comboBoxAn_MouseDown);
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.Location = new global::System.Drawing.Point(225, 620);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(171, 20);
			this.label4.TabIndex = 21;
			this.label4.Text = "{ Long huyết hoàn ... }";
			this.textBoxSL.Location = new global::System.Drawing.Point(432, 578);
			this.textBoxSL.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBoxSL.Name = "textBoxSL";
			this.textBoxSL.Size = new global::System.Drawing.Size(36, 26);
			this.textBoxSL.TabIndex = 22;
			this.textBoxSL.Text = "2";
			this.textBoxSL.TextChanged += new global::System.EventHandler(this.textBoxSL_TextChanged);
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(477, 583);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(29, 20);
			this.label5.TabIndex = 23;
			this.label5.Text = "cái";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(516, 680);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.textBoxSL);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.comboBoxAn);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.checkBoxLongHH);
			base.Controls.Add(this.checkBoxTDP);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.checkBoxTuchuyenThanh);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.comboBox2);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormNhiepTT";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Vuot ai";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormNhiepTT_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A87 RID: 2695
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000A88 RID: 2696
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000A89 RID: 2697
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000A8A RID: 2698
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000A8B RID: 2699
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000A8C RID: 2700
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000A8D RID: 2701
		private global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x04000A8E RID: 2702
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000A8F RID: 2703
		private global::System.Windows.Forms.CheckBox checkBoxTuchuyenThanh;

		// Token: 0x04000A90 RID: 2704
		private global::System.Windows.Forms.CheckBox checkBoxTDP;

		// Token: 0x04000A91 RID: 2705
		private global::System.Windows.Forms.CheckBox checkBoxLongHH;

		// Token: 0x04000A92 RID: 2706
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000A93 RID: 2707
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000A94 RID: 2708
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000A95 RID: 2709
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000A96 RID: 2710
		private global::System.Windows.Forms.ComboBox comboBoxAn;

		// Token: 0x04000A97 RID: 2711
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000A98 RID: 2712
		private global::System.Windows.Forms.TextBox textBoxSL;

		// Token: 0x04000A99 RID: 2713
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000AAC RID: 2732
		private global::System.ComponentModel.IContainer components;
	}
}
