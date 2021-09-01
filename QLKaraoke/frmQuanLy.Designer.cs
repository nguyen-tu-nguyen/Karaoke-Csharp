namespace QLKaraoke
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTienNV = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cboGioBD = new System.Windows.Forms.ComboBox();
            this.cboPhutBD = new System.Windows.Forms.ComboBox();
            this.cboGioKT = new System.Windows.Forms.ComboBox();
            this.cboPhutKT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTienTheoGio = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblThuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Nhanvientt";
            this.Column5.HeaderText = "Nhân Viên";
            this.Column5.Name = "Column5";
            // 
            // Tongtien
            // 
            this.Tongtien.HeaderText = "Tiền Tổng";
            this.Tongtien.Name = "Tongtien";
            // 
            // TienDV
            // 
            this.TienDV.HeaderText = "Tiền DV";
            this.TienDV.Name = "TienDV";
            // 
            // TienPhong
            // 
            this.TienPhong.HeaderText = "Tiền Phòng";
            this.TienPhong.Name = "TienPhong";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioKT";
            this.Column4.HeaderText = "Giờ KT";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioBD";
            this.Column3.HeaderText = "Giờ BĐ";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Maphong";
            this.Column2.HeaderText = "Phòng";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            // 
            // C1
            // 
            this.C1.DataPropertyName = "MaHD";
            this.C1.HeaderText = "Mã HD";
            this.C1.Name = "C1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(465, 230);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDV);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.lblTienNV);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh Thu Theo NV";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.e,
            this.Column7});
            this.dgv.Location = new System.Drawing.Point(3, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(458, 164);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "manv";
            this.Column6.HeaderText = "Mã";
            this.Column6.Name = "Column6";
            // 
            // e
            // 
            this.e.DataPropertyName = "tennv";
            this.e.HeaderText = "Họ tên";
            this.e.Name = "e";
            this.e.Width = 240;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "chucvu";
            this.Column7.HeaderText = "Chức vụ";
            this.Column7.Name = "Column7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doanh thu của nhân viên này là ";
            // 
            // lblTienNV
            // 
            this.lblTienNV.AutoSize = true;
            this.lblTienNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNV.ForeColor = System.Drawing.Color.Red;
            this.lblTienNV.Location = new System.Drawing.Point(283, 167);
            this.lblTienNV.Name = "lblTienNV";
            this.lblTienNV.Size = new System.Drawing.Size(100, 22);
            this.lblTienNV.TabIndex = 2;
            this.lblTienNV.Text = "100000000";
            this.lblTienNV.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDV.ForeColor = System.Drawing.Color.Red;
            this.lblDV.Location = new System.Drawing.Point(404, 167);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(50, 22);
            this.lblDV.TabIndex = 3;
            this.lblDV.Text = "đồng";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTienTheoGio);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cboPhutKT);
            this.tabPage3.Controls.Add(this.cboGioKT);
            this.tabPage3.Controls.Add(this.cboPhutBD);
            this.tabPage3.Controls.Add(this.cboGioBD);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 204);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Doanh Thu Theo Thời Gian";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cboGioBD
            // 
            this.cboGioBD.FormattingEnabled = true;
            this.cboGioBD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboGioBD.Location = new System.Drawing.Point(103, 23);
            this.cboGioBD.Name = "cboGioBD";
            this.cboGioBD.Size = new System.Drawing.Size(80, 28);
            this.cboGioBD.TabIndex = 0;
            // 
            // cboPhutBD
            // 
            this.cboPhutBD.FormattingEnabled = true;
            this.cboPhutBD.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboPhutBD.Location = new System.Drawing.Point(265, 23);
            this.cboPhutBD.Name = "cboPhutBD";
            this.cboPhutBD.Size = new System.Drawing.Size(80, 28);
            this.cboPhutBD.TabIndex = 1;
            // 
            // cboGioKT
            // 
            this.cboGioKT.FormattingEnabled = true;
            this.cboGioKT.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboGioKT.Location = new System.Drawing.Point(103, 84);
            this.cboGioKT.Name = "cboGioKT";
            this.cboGioKT.Size = new System.Drawing.Size(80, 28);
            this.cboGioKT.TabIndex = 2;
            // 
            // cboPhutKT
            // 
            this.cboPhutKT.FormattingEnabled = true;
            this.cboPhutKT.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboPhutKT.Location = new System.Drawing.Point(265, 84);
            this.cboPhutKT.Name = "cboPhutKT";
            this.cboPhutKT.Size = new System.Drawing.Size(80, 28);
            this.cboPhutKT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "giờ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "giờ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "phút";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "phút";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(47, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(47, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "đến";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Lọc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Doanh thu là";
            // 
            // lblTienTheoGio
            // 
            this.lblTienTheoGio.AutoSize = true;
            this.lblTienTheoGio.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTheoGio.ForeColor = System.Drawing.Color.Red;
            this.lblTienTheoGio.Location = new System.Drawing.Point(278, 158);
            this.lblTienTheoGio.Name = "lblTienTheoGio";
            this.lblTienTheoGio.Size = new System.Drawing.Size(20, 22);
            this.lblTienTheoGio.TabIndex = 12;
            this.lblTienTheoGio.Text = "0";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::QLKaraoke.Properties.Resources.money_background_blank_area_hundred_dollars_make_325520391;
            this.tabPage1.Controls.Add(this.lblThuc);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh Thu";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblThuc
            // 
            this.lblThuc.AutoSize = true;
            this.lblThuc.Font = new System.Drawing.Font("Goudy Stout", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuc.ForeColor = System.Drawing.Color.Red;
            this.lblThuc.Location = new System.Drawing.Point(119, 161);
            this.lblThuc.Name = "lblThuc";
            this.lblThuc.Size = new System.Drawing.Size(0, 40);
            this.lblThuc.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(204, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "doanh thu";
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 262);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblThuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn e;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTienNV;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTienTheoGio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhutKT;
        private System.Windows.Forms.ComboBox cboGioKT;
        private System.Windows.Forms.ComboBox cboPhutBD;
        private System.Windows.Forms.ComboBox cboGioBD;



    }
}