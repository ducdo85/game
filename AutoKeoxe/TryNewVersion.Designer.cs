namespace AutoKeoxe
{
	// Token: 0x020000E1 RID: 225
	public partial class TryNewVersion : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C0D RID: 3085 RVA: 0x001993C0 File Offset: 0x001975C0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::AutoKeoxe.TryNewVersion));
			this.buttonDownload = new global::System.Windows.Forms.Button();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.components);
			this.textBoxStatus = new global::System.Windows.Forms.TextBox();
			this.linkLabelLinkWeb = new global::System.Windows.Forms.LinkLabel();
			this.linkLabelBlog = new global::System.Windows.Forms.LinkLabel();
			this.buttonAutoTrain = new global::System.Windows.Forms.Button();
			this.linkLabelTaiTructiep = new global::System.Windows.Forms.LinkLabel();
			base.SuspendLayout();
			this.buttonDownload.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonDownload.ForeColor = global::System.Drawing.Color.DarkRed;
			this.buttonDownload.Location = new global::System.Drawing.Point(135, 60);
			this.buttonDownload.Name = "buttonDownload";
			this.buttonDownload.Size = new global::System.Drawing.Size(186, 36);
			this.buttonDownload.TabIndex = 1;
			this.buttonDownload.Text = "Cập nhật";
			this.buttonDownload.UseVisualStyleBackColor = false;
			this.buttonDownload.Click += new global::System.EventHandler(this.buttonDownload_Click);
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.textBoxStatus.Location = new global::System.Drawing.Point(2, 1);
			this.textBoxStatus.Multiline = true;
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxStatus.Size = new global::System.Drawing.Size(320, 58);
			this.textBoxStatus.TabIndex = 9;
			this.textBoxStatus.Text = "Bạn vui lòng tắt Antivirus nếu có trước khi tải cập nhật. Bấm tải trực tiếp nếu không cập nhật được";
			this.linkLabelLinkWeb.AutoSize = true;
			this.linkLabelLinkWeb.Location = new global::System.Drawing.Point(7, 104);
			this.linkLabelLinkWeb.Name = "linkLabelLinkWeb";
			this.linkLabelLinkWeb.Size = new global::System.Drawing.Size(114, 13);
			this.linkLabelLinkWeb.TabIndex = 141;
			this.linkLabelLinkWeb.TabStop = true;
			this.linkLabelLinkWeb.Text = "http://canhtrang.com/";
			this.linkLabelLinkWeb.Visible = false;
			this.linkLabelLinkWeb.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLinkWeb_LinkClicked);
			this.linkLabelBlog.AutoSize = true;
			this.linkLabelBlog.Location = new global::System.Drawing.Point(7, 121);
			this.linkLabelBlog.Name = "linkLabelBlog";
			this.linkLabelBlog.Size = new global::System.Drawing.Size(114, 13);
			this.linkLabelBlog.TabIndex = 142;
			this.linkLabelBlog.TabStop = true;
			this.linkLabelBlog.Text = "http://canhtrang.com/";
			this.linkLabelBlog.Visible = false;
			this.linkLabelBlog.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBlog_LinkClicked);
			this.buttonAutoTrain.Location = new global::System.Drawing.Point(140, 102);
			this.buttonAutoTrain.Name = "buttonAutoTrain";
			this.buttonAutoTrain.Size = new global::System.Drawing.Size(85, 36);
			this.buttonAutoTrain.TabIndex = 143;
			this.buttonAutoTrain.Text = "Tải auto train (KYTrain)";
			this.buttonAutoTrain.UseVisualStyleBackColor = true;
			this.buttonAutoTrain.Visible = false;
			this.buttonAutoTrain.Click += new global::System.EventHandler(this.buttonAutoTrain_Click);
			this.linkLabelTaiTructiep.AutoSize = true;
			this.linkLabelTaiTructiep.Location = new global::System.Drawing.Point(7, 64);
			this.linkLabelTaiTructiep.Name = "linkLabelTaiTructiep";
			this.linkLabelTaiTructiep.Size = new global::System.Drawing.Size(67, 13);
			this.linkLabelTaiTructiep.TabIndex = 145;
			this.linkLabelTaiTructiep.TabStop = true;
			this.linkLabelTaiTructiep.Text = "Tải thủ công";
			this.linkLabelTaiTructiep.Visible = false;
			this.linkLabelTaiTructiep.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTaiTructiep_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(324, 97);
			base.Controls.Add(this.buttonAutoTrain);
			base.Controls.Add(this.textBoxStatus);
			base.Controls.Add(this.linkLabelBlog);
			base.Controls.Add(this.linkLabelLinkWeb);
			base.Controls.Add(this.buttonDownload);
			base.Controls.Add(this.linkLabelTaiTructiep);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "TryNewVersion";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Cập nhật Auto";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			base.Load += new global::System.EventHandler(this.TryNewVersion_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001131 RID: 4401
		private global::System.Windows.Forms.Button buttonDownload;

		// Token: 0x04001132 RID: 4402
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x04001133 RID: 4403
		private global::System.Windows.Forms.TextBox textBoxStatus;

		// Token: 0x04001134 RID: 4404
		private global::System.Windows.Forms.LinkLabel linkLabelLinkWeb;

		// Token: 0x04001135 RID: 4405
		private global::System.Windows.Forms.LinkLabel linkLabelBlog;

		// Token: 0x04001136 RID: 4406
		private global::System.Windows.Forms.Button buttonAutoTrain;

		// Token: 0x04001137 RID: 4407
		private global::System.Windows.Forms.LinkLabel linkLabelTaiTructiep;

		// Token: 0x04001143 RID: 4419
		private global::System.ComponentModel.IContainer components;
	}
}
