using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLKaraoke
{
    public partial class frmDanhMuc : Form
    {
        DBConnect conn = new DBConnect();
        string quyenn = "";
        DataSet dsPhong, dsNhanVien, dsDichVu,dsPhong2;
        public frmDanhMuc()
        {
            InitializeComponent();
        }
        public frmDanhMuc(string quyen)
        {
            quyenn = quyen;
            InitializeComponent();
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            
            txtMP.Text = txtLoaiPhong.Text = "";
            Image chung = Image.FromFile("N:\\CNN\\BaiTapLon\\QLQuanKaraoke\\QLKaraoke\\Resources\\acou.jpg");
            pictureBox1.Image = chung;
            txtMP.ReadOnly = true;
            load_Phong();
            load_DV();
            load_NV();
            dgvPhong.Enabled = false;
            if (String.Compare(quyenn, "QL", true) == 0)
            {
                btnXoa.Enabled = button7.Enabled = false;
                btnLuu.Enabled = btnThem.Enabled  = button1.Enabled = true;
            }
            else 
            {
                btnLuu.Enabled = btnThem.Enabled = btnXoa.Enabled = button1.Enabled  = false;
            }
            dgvPhong.ReadOnly = dgvNhanVien.ReadOnly = dgvDichVu.ReadOnly = true;
        }
        public void load_Phong()
        {
            string strSelect = "select * from phong";
            dsPhong = new DataSet();
            SqlDataAdapter da= new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsPhong);
            dgvPhong.DataSource = dsPhong.Tables[0];

        }
        public void load_DV()
        {
            string strSelect = "select * from dichvu";
            dsDichVu = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsDichVu);
            dgvDichVu.DataSource = dsDichVu.Tables[0];
           
           

        }
        public void load_NV()
        {
            string strSelect = "select MaNV,tennv,chucvu from nhanvien";
            dsNhanVien = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsNhanVien);
            dgvNhanVien.DataSource = dsNhanVien.Tables[0];
            

        }

        private void tabPhong_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dgvDichVu.Enabled = dgvNhanVien.Enabled = dgvPhong.Enabled=btnXoa.Enabled = button7.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtLoaiPhong.Text == null || !((String.Compare(txtLoaiPhong.Text, "Standard", true) == 0) || (String.Compare(txtLoaiPhong.Text, "Standard15", true) == 0) || (String.Compare(txtLoaiPhong.Text, "VIP", true) == 0) || (String.Compare(txtLoaiPhong.Text, "VIP15", true) == 0)))
            { MessageBox.Show("Loại phòng không hợp lệ. Cập nhập không thành công !!!"); }
            else
            {
                conn.closeConnection();
                string strSQL = " UPDATE Phong SET loaiphong = '"+txtLoaiPhong.Text.Trim()+"' where maphong = '"+txtMP.Text.Trim()+"'";
                conn.updateToDB(strSQL);
                MessageBox.Show("Cập nhập thành công!");
                load_Phong();
                frmDanhMuc_Load(sender, e);
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvPhong_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;
            txtMP.Text = dgvPhong.Rows[numrow].Cells[0].Value.ToString();
            txtLoaiPhong.Text = dgvPhong.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn Xóa?", "Xóa Nè!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.closeConnection();
                    string strSQL = " delete from phong where maphong = '" + txtMP.Text.Trim() + "'";
                    conn.updateToDB(strSQL);
                    MessageBox.Show("Xóa thành công!");
                    load_Phong();
                    frmDanhMuc_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Phòng này đang được đặt");
                }
            }

            

   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.Compare(button7.Text, "Thêm", true) == 0)
            {
                button7.Text = "Xong";
                txtMP.ReadOnly = false;
                dgvDichVu.Enabled = false;
                txtMP.Text = txtLoaiPhong.Text = null;
                txtMP.Focus();
            }
            else
            {
                if ((txtMP.Text == "") && (txtLoaiPhong.Text == ""))
                {
                    button7.Text = "Thêm";
                    txtMP.ReadOnly = true;
                }
                else if ((txtMP.Text == "") || (txtLoaiPhong.Text == ""))
                {
                    txtMP.ReadOnly = false;
                    dgvDichVu.Enabled = false;
                    MessageBox.Show("Phải nhập đủ trường");
                }
                else if (!((String.Compare(txtLoaiPhong.Text, "Standard", true) == 0) || (String.Compare(txtLoaiPhong.Text, "Standard15", true) == 0) || (String.Compare(txtLoaiPhong.Text, "VIP", true) == 0) || (String.Compare(txtLoaiPhong.Text, "VIP15", true) == 0)))
                {
                    MessageBox.Show("Loại phòng không hợp lệ. Cập nhập không thành công !!!");
                }
                else
                {
                    try
                    {
                        conn.closeConnection();
                        string strSQL = "insert into Phong values ('" + txtMP.Text.Trim() + "','" + txtLoaiPhong.Text.Trim() + "',null)";
                        conn.updateToDB(strSQL);
                        MessageBox.Show("Thêm thành công!");
                        load_Phong();
                        frmDanhMuc_Load(sender, e);
                        button7.Text = "Thêm";
                        txtMP.ReadOnly = true;
                    }
                    catch
                    {
                        MessageBox.Show("Đã có phòng này!");

                    }
                }
                    
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.Compare(button3.Text, "Thêm", true) == 0)
            {
                button3.Text = "Xong";
                txtMP.Text = txtLoaiPhong.Text = null;
                txtMP.Focus();
            }
            else
            {
                if ((txtMDV.Text == "") && (txtLoaiDV.Text == "") && (txtGia.Text == ""))
                {
                    button3.Text = "Thêm";
                }
                else if ((txtMDV.Text == "") || (txtLoaiDV.Text == "") || (txtGia.Text == ""))
                {
                    txtMP.ReadOnly = false;
                    dgvDichVu.Enabled = false;
                    MessageBox.Show("Phải nhập đủ trường");
                }
                else
                {
                    try
                    {
                        conn.closeConnection();
                        string strSQL = "insert into DichVu values ('"+txtMDV.Text.Trim()+"',N'"+txtLoaiDV.Text.Trim()+"','"+txtGia.Text+"')";
                        conn.updateToDB(strSQL);
                        MessageBox.Show("Thêm thành công!");
                        load_DV();
                        txtLoaiDV.Text = txtMDV.Text = txtGia.Text = "";
                        button3.Text = "Thêm";
                    }
                    catch
                    {
                        MessageBox.Show("Đã có dịch vụ này!");

                    }
                }

            }

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
                
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == 0)
            {
                Image chung = Image.FromFile("E:\\CNNBaiTapLon\\64237295_1760624157416153_3283221572571103232_n - Copy.jpg");
               // pnlHinh.BackgroundImage;
                pictureBox1.Image = chung;
               
            }
            else if (numrow == 1)
            {
                Image chung = Image.FromFile("E:\\CNNBaiTapLon\\nhut.png");
                pictureBox1.Image = chung;
            }
            else if (numrow == 2)
            {
                Image chung = Image.FromFile("E:\\CNNBaiTapLon\\binh.png");
                pictureBox1.Image = chung;
            }
            else
            {
                Image chung = Image.FromFile("N:\\CNN\\BaiTapLon\\QLQuanKaraoke\\QLKaraoke\\Resources\\acou.jpg");
                pictureBox1.Image = chung;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hello a = new hello();
            a.Show();

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void load_PhongChuaDat()
        {
            string strSelect = "SELECT * from Phong where NOT EXISTS (SELECT maphong FROM hoadon WHERE phong.maphong = hoadon.maphong AND tinhtrang ='Booked');";
            dsPhong2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsPhong2);
            dgvPhong.DataSource = dsPhong2.Tables[0];

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.Compare(button2.Text.Trim(), "Lọc", true) == 0)
            {
                button2.Text = "Đầy đủ";
                load_PhongChuaDat();
            }
            else {
                button2.Text = "Lọc";
                load_Phong();
            }


            
        }
    }
}
