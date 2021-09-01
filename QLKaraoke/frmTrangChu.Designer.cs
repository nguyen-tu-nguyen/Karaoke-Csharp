namespace QLKaraoke
{
    partial class frmTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.miQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.miDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDatPhong,
            this.miQuanLy,
            this.miDanhMuc,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // miDatPhong
            // 
            this.miDatPhong.Image = global::QLKaraoke.Properties.Resources.svn_added;
            this.miDatPhong.Name = "miDatPhong";
            this.miDatPhong.Size = new System.Drawing.Size(91, 20);
            this.miDatPhong.Text = "Đặt phòng";
            this.miDatPhong.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // miQuanLy
            // 
            this.miQuanLy.Image = global::QLKaraoke.Properties.Resources.coins;
            this.miQuanLy.Name = "miQuanLy";
            this.miQuanLy.Size = new System.Drawing.Size(117, 20);
            this.miQuanLy.Text = "Xem doanh thu";
            this.miQuanLy.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // miDanhMuc
            // 
            this.miDanhMuc.Image = global::QLKaraoke.Properties.Resources.damage;
            this.miDanhMuc.Name = "miDanhMuc";
            this.miDanhMuc.Size = new System.Drawing.Size(90, 20);
            this.miDanhMuc.Text = "Danh mục";
            this.miDanhMuc.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Image = global::QLKaraoke.Properties.Resources.lock1;
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QLKaraoke.Properties.Resources.svn_deleted;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::QLKaraoke.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh ";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xin chào, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Image = global::QLKaraoke.Properties.Resources.check;
            this.button1.Location = new System.Drawing.Point(755, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 205);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QLKaraoke.Properties.Resources._39919;
            this.button2.Location = new System.Drawing.Point(755, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 205);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Image = global::QLKaraoke.Properties.Resources.micro;
            this.btnDatPhong.Location = new System.Drawing.Point(451, 45);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(198, 205);
            this.btnDatPhong.TabIndex = 5;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXemHD
            // 
            this.btnXemHD.Image = global::QLKaraoke.Properties.Resources.micro1;
            this.btnXemHD.Location = new System.Drawing.Point(444, 313);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(205, 205);
            this.btnXemHD.TabIndex = 6;
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKaraoke.Properties.Resources.acou___Copy1;
            this.ClientSize = new System.Drawing.Size(1247, 688);
            this.Controls.Add(this.btnXemHD);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miDatPhong;
        private System.Windows.Forms.ToolStripMenuItem miQuanLy;
        private System.Windows.Forms.ToolStripMenuItem miDanhMuc;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}