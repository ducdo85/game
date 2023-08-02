namespace AutoKeoxe
{
	// Token: 0x0200007E RID: 126
	public partial class FormPT : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x0016C750 File Offset: 0x0016A950
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.FormPT));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.comboBoxAcc = new global::System.Windows.Forms.ComboBox();
			this.buttonThem = new global::System.Windows.Forms.Button();
			this.buttonXoa = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.buttonThoat = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.checkBoxPTtheoBHO = new global::System.Windows.Forms.CheckBox();
			this.checkBoxTheoDSnhom = new global::System.Windows.Forms.CheckBox();
			this.checkBoxLuonLamDoitruong = new global::System.Windows.Forms.CheckBox();
			this.checkBoxHienThiSonguoi = new global::System.Windows.Forms.CheckBox();
			this.buttonApdungAll = new global::System.Windows.Forms.Button();
			this.buttonAllAc = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new global::System.Drawing.Point(15, 42);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(366, 241);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
			this.columnHeader_0.Text = "Nhân vật";
			this.columnHeader_0.Width = 200;
			this.comboBoxAcc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAcc.FormattingEnabled = true;
			this.comboBoxAcc.Location = new global::System.Drawing.Point(15, 294);
			this.comboBoxAcc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboBoxAcc.Name = "comboBoxAcc";
			this.comboBoxAcc.Size = new global::System.Drawing.Size(206, 28);
			this.comboBoxAcc.TabIndex = 2;
			this.comboBoxAcc.DropDown += new global::System.EventHandler(this.comboBoxAcc_DropDown);
			this.buttonThem.Location = new global::System.Drawing.Point(232, 291);
			this.buttonThem.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new global::System.Drawing.Size(82, 35);
			this.buttonThem.TabIndex = 3;
			this.buttonThem.Text = "Thêm";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new global::System.EventHandler(this.buttonThem_Click);
			this.buttonXoa.Location = new global::System.Drawing.Point(318, 291);
			this.buttonXoa.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new global::System.Drawing.Size(63, 35);
			this.buttonXoa.TabIndex = 4;
			this.buttonXoa.Text = "Xóa";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new global::System.EventHandler(this.buttonXoa_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.buttonThoat.Location = new global::System.Drawing.Point(232, 528);
			this.buttonThoat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new global::System.Drawing.Size(148, 40);
			this.buttonThoat.TabIndex = 6;
			this.buttonThoat.Text = "Đóng";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new global::System.EventHandler(this.buttonThoat_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 11);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(130, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Danh sách nhóm";
			this.checkBoxPTtheoBHO.AutoSize = true;
			this.checkBoxPTtheoBHO.Location = new global::System.Drawing.Point(45, 434);
			this.checkBoxPTtheoBHO.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxPTtheoBHO.Name = "checkBoxPTtheoBHO";
			this.checkBoxPTtheoBHO.Size = new global::System.Drawing.Size(184, 24);
			this.checkBoxPTtheoBHO.TabIndex = 8;
			this.checkBoxPTtheoBHO.Text = "Mời PT theo bang hội";
			this.checkBoxPTtheoBHO.UseVisualStyleBackColor = true;
			this.checkBoxPTtheoBHO.CheckedChanged += new global::System.EventHandler(this.checkBoxPTtheoBHO_CheckedChanged);
			this.checkBoxTheoDSnhom.AutoSize = true;
			this.checkBoxTheoDSnhom.Location = new global::System.Drawing.Point(45, 394);
			this.checkBoxTheoDSnhom.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxTheoDSnhom.Name = "checkBoxTheoDSnhom";
			this.checkBoxTheoDSnhom.Size = new global::System.Drawing.Size(276, 24);
			this.checkBoxTheoDSnhom.TabIndex = 9;
			this.checkBoxTheoDSnhom.Text = "Mời hoặc nhận PT theo danh sách";
			this.checkBoxTheoDSnhom.UseVisualStyleBackColor = true;
			this.checkBoxTheoDSnhom.CheckedChanged += new global::System.EventHandler(this.checkBoxTheoDSnhom_CheckedChanged);
			this.checkBoxLuonLamDoitruong.AutoSize = true;
			this.checkBoxLuonLamDoitruong.Location = new global::System.Drawing.Point(15, 354);
			this.checkBoxLuonLamDoitruong.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxLuonLamDoitruong.Name = "checkBoxLuonLamDoitruong";
			this.checkBoxLuonLamDoitruong.Size = new global::System.Drawing.Size(175, 24);
			this.checkBoxLuonLamDoitruong.TabIndex = 10;
			this.checkBoxLuonLamDoitruong.Text = "Luôn làm đội trưởng";
			this.checkBoxLuonLamDoitruong.UseVisualStyleBackColor = true;
			this.checkBoxLuonLamDoitruong.CheckedChanged += new global::System.EventHandler(this.checkBoxLuonLamDoitruong_CheckedChanged);
			this.checkBoxHienThiSonguoi.AutoSize = true;
			this.checkBoxHienThiSonguoi.Location = new global::System.Drawing.Point(15, 474);
			this.checkBoxHienThiSonguoi.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.checkBoxHienThiSonguoi.Name = "checkBoxHienThiSonguoi";
			this.checkBoxHienThiSonguoi.Size = new global::System.Drawing.Size(238, 24);
			this.checkBoxHienThiSonguoi.TabIndex = 11;
			this.checkBoxHienThiSonguoi.Text = "Hiển thị số người trong nhóm";
			this.checkBoxHienThiSonguoi.UseVisualStyleBackColor = true;
			this.checkBoxHienThiSonguoi.CheckedChanged += new global::System.EventHandler(this.checkBoxHienThiSonguoi_CheckedChanged);
			this.buttonApdungAll.Location = new global::System.Drawing.Point(15, 528);
			this.buttonApdungAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonApdungAll.Name = "buttonApdungAll";
			this.buttonApdungAll.Size = new global::System.Drawing.Size(208, 40);
			this.buttonApdungAll.TabIndex = 13;
			this.buttonApdungAll.Text = "Áp dụng cho tất cả ac";
			this.buttonApdungAll.UseVisualStyleBackColor = true;
			this.buttonApdungAll.Click += new global::System.EventHandler(this.buttonApdungAll_Click);
			this.buttonAllAc.Location = new global::System.Drawing.Point(232, 332);
			this.buttonAllAc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.buttonAllAc.Name = "buttonAllAc";
			this.buttonAllAc.Size = new global::System.Drawing.Size(148, 55);
			this.buttonAllAc.TabIndex = 14;
			this.buttonAllAc.Text = "Thêm tất cả ac trên auto";
			this.buttonAllAc.UseVisualStyleBackColor = true;
			this.buttonAllAc.Click += new global::System.EventHandler(this.buttonAllAc_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(402, 582);
			base.Controls.Add(this.buttonAllAc);
			base.Controls.Add(this.buttonApdungAll);
			base.Controls.Add(this.checkBoxHienThiSonguoi);
			base.Controls.Add(this.checkBoxLuonLamDoitruong);
			base.Controls.Add(this.checkBoxTheoDSnhom);
			base.Controls.Add(this.checkBoxPTtheoBHO);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.buttonThoat);
			base.Controls.Add(this.buttonXoa);
			base.Controls.Add(this.buttonThem);
			base.Controls.Add(this.comboBoxAcc);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormPT";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "PT";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.FormPT_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000ADF RID: 2783
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000AE0 RID: 2784
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x04000AE1 RID: 2785
		private global::System.Windows.Forms.ComboBox comboBoxAcc;

		// Token: 0x04000AE2 RID: 2786
		private global::System.Windows.Forms.Button buttonThem;

		// Token: 0x04000AE3 RID: 2787
		private global::System.Windows.Forms.Button buttonXoa;

		// Token: 0x04000AE4 RID: 2788
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04000AE5 RID: 2789
		private global::System.Windows.Forms.Button buttonThoat;

		// Token: 0x04000AE6 RID: 2790
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000AE7 RID: 2791
		private global::System.Windows.Forms.CheckBox checkBoxPTtheoBHO;

		// Token: 0x04000AE8 RID: 2792
		private global::System.Windows.Forms.CheckBox checkBoxTheoDSnhom;

		// Token: 0x04000AE9 RID: 2793
		private global::System.Windows.Forms.CheckBox checkBoxLuonLamDoitruong;

		// Token: 0x04000AEA RID: 2794
		private global::System.Windows.Forms.CheckBox checkBoxHienThiSonguoi;

		// Token: 0x04000AEB RID: 2795
		private global::System.Windows.Forms.Button buttonApdungAll;

		// Token: 0x04000AEC RID: 2796
		private global::System.Windows.Forms.Button buttonAllAc;

		// Token: 0x04000AF5 RID: 2805
		private global::System.ComponentModel.IContainer components;
	}
}
