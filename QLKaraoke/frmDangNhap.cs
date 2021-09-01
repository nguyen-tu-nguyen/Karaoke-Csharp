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
    public partial class frmDangNhap : Form
    {
       
        public string quyen = "";
        public string tenNV = "";
        public string tenDangNhap = "";
        SqlDataAdapter da_NV;
        DBConnect conn = new DBConnect();
        DataColumn[] quyenn = new DataColumn[2];
        public frmDangNhap()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.checkForExits("select count(*) from nhanvien where manv = '" + txtMaNV.Text + "'"))
            {
                if (conn.checkForExits("select count(*) from nhanvien where manv = '" + txtMaNV.Text + "' and matkhau = '" + txtMK.Text + "'"))
                {
                    //try
                    //{
                    //SqlCommand cmd = new SqlCommand("select * from nhanvien where manv = '" + txtMaNV.Text + "' and matkhau = '" + txtMK.Text + "'");
                    //SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);
                    
                    //    if (dt != null)
                    //    {
                    //        foreach (DataRow dr in dt.Rows)
                    //        {
                    //            quyen2 = dr["ChucVu"].ToString();
                    //        }
                    //    }
                    //}
                    //catch { }
                    string strSQL = "select chucvu,tennv from nhanvien where manv = '" + txtMaNV.Text + "' and matkhau = '" + txtMK.Text + "'";
                    SqlDataReader dr = conn.getDataReader(strSQL);
                    while (dr.Read())
                    {
                        quyen+=dr["ChucVu"].ToString();
                        tenNV+= dr["TenNV"].ToString();
                    }
                    dr.Close();
                    //MessageBox.Show(tenNV);
                    frmTrangChu a = new frmTrangChu(quyen,tenNV);
                    a.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!");
                }

                //MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("Không có tên đăng nhập này!");
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)  button1_Click(sender,e);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            quyen = "";
        }
    }
}
