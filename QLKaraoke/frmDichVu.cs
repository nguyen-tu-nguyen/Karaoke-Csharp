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
    public partial class frmDichVu : Form
    {
        DBConnect conn = new DBConnect();
        public frmDichVu()
        {
            InitializeComponent();
        }
        public void load_Phong()
        {
            string str = "SELECT distinct maphong from hoadon where tinhtrang = 'Booked'";
            SqlDataReader db = conn.getDataReader(str);
            while (db.Read())
            {
                cboPhong.Items.Add(db["MaPhong"].ToString());
            }
            db.Close();
        }
        public void load_DV()
        {
            string str = "SELECT tenloaidv from dichvu";
            SqlDataReader db = conn.getDataReader(str);
            while (db.Read())
            {
                cboDichVu.Items.Add(db["tenLoaiDV"].ToString());
            }
            db.Close();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();
            cboDichVu.Items.Clear();

            txtTen.ReadOnly = true;
            load_DV();
            txtGia.Text = txtTen.Text = txtSL.Text = "";
            cboDichVu.Enabled = txtSL.Enabled = btnThem.Enabled = false;
            load_Phong();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDichVu.Enabled = txtSL.Enabled = btnThem.Enabled = true;

        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = "",gia ="";
            string strSQL = "select maloaidv,CAST(giatien as int) as N'Tien' from dichvu where tenloaidv=N'" + Convert.ToString(cboDichVu.SelectedItem) + "'";
            SqlDataReader dr = conn.getDataReader(strSQL);
            while (dr.Read())
            {
                ma+= dr["maloaidv"].ToString();
               // gia += (Convert.ToInt32(dr["giatien"].ToString())).ToString();
                gia += dr["tien"].ToString();
                //(Convert.ToInt32(dr["giatien"].ToString())).ToString()

            }
            dr.Close();
            txtTen.Text = ma;
            txtGia.Text = gia;

        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sl=1;
            double tien = 0;
            if (txtSL.Text == "")
            {
                
            }
            else
            {
                sl = Convert.ToInt32(txtSL.Text);
            }
            try
            {
                tien = sl * Convert.ToInt64(txtGia.Text);
            }
            catch { }
            
            try
            {
                conn.closeConnection();
                string strSQL = "insert into ChiTietDichVu values ('" + Convert.ToString(cboPhong.SelectedItem) + "','" + txtTen.Text.Trim() + "'," + sl.ToString() + "," + tien.ToString() + ") ";
                conn.updateToDB(strSQL);
                MessageBox.Show("Giá của dịch vụ là: " + tien.ToString() + " VND");
                frmDichVu_Load(sender, e);
            }
            catch{
                MessageBox.Show("Đã chốt bill, không thể sửa!");
                frmDichVu_Load(sender, e);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
