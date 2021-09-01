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
    public partial class frmDatPhong : Form
    {
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada_Phong = new SqlDataAdapter();
        DataSet ds_Phong;
        DataColumn[] primarykey1 = new DataColumn[1];
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
          
            txtBD.Focus();
            cboLoai.Items.Clear();
            cboLoai.SelectedText = "";
            load_comboLoai();
            txtMa.Text=txtSDT.Text=txtTen.Text = null;
            txtMa.ReadOnly = true;
            //cboPhong.Enabled = txtMa.Enabled = false;
            txtTen.Enabled= txtSDT.Enabled = false;
            txtBD.Enabled = false;
            btnDat.Enabled = false;
            
            //createTable_Phong();
            //loadPhong();
           
            //load_comboPhong();


        }
        private void loadPhong() {
            string strSQL = "SELECT * FROM tblPHIEUNHAP";
            ds_Phong = new DataSet();
            SqlDataAdapter da_PN = new SqlDataAdapter(strSQL, conn.Con);
            da_PN.Fill(ds_Phong, "Phong");
            cboPhong.DataSource = ds_Phong.Tables[0];
            cboPhong.DisplayMember = "MaPhong";
            cboPhong.ValueMember = "MaPhong";
        }
        public void createTable_Phong()
        {
            //tao 1 database co ten lop de cap nhat du lieu
            string strSQL = "select * from Phong";
            ada_Phong = conn.getDataAdapter(strSQL, "Phong");
            //tao khoa chinh cho bang lop cua datasset
            primarykey1[0] = conn.DSet.Tables["Phong"].Columns["MaPhong"];
            conn.DSet.Tables["Phong"].PrimaryKey = primarykey1;
        }
        private void load_comboPhong()
        {
            string str = "SELECT * from Phong";
            SqlDataReader db = conn.getDataReader(str);
            while (db.Read())
            {
                cboPhong.Items.Add(db["MAPhong"].ToString());
            }
            db.Close();
        }
        private void load_comboLoai()
        {
            string strSQL = "select distinct loaiphong from phong";
            SqlDataReader dr = conn.getDataReader(strSQL);
            while (dr.Read())
            {
                cboLoai.Items.Add(dr["LoaiPhong"].ToString());
            }
            dr.Close();
        }

        
        private void btnDat_Click(object sender, EventArgs e)
        {
            string temp_ma="";
            string temp_time="";
            conn.closeConnection();
            if (String.Compare(txtBD.Text, "  :", true) == 0)
            {
                temp_time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            }
            else
            {
                temp_time = txtBD.Text;
            }
            temp_ma = txtMa.Text;
            if (conn.checkForExits("select count(*) from khachhang where makh = '" + txtMa.Text + "'"))
            {
                //conn.closeConnection();
                //string strMa = "SELECT COUNT(*) FROM HoaDon";
                //int sl = conn.getCount(strMa) + 1;
                //string mahd = "HD" + sl;
                //string strSQL = " insert into hoadon values ('" + mahd + "','" + txtMa.Text + "','" + Convert.ToString(cboPhong.SelectedItem).Trim() + "','" + temp_time + "','Booked')";
                //conn.updateToDB(strSQL);
            }
            
            else
            {
                

                    try
                    {
                        conn.closeConnection();
                        string strSQL = " insert into khachhang values ('" + txtMa.Text + "',N'" + txtTen.Text + "','" + txtSDT.Text + "')";
                        conn.updateToDB(strSQL);
                        
                    }
                    catch { MessageBox.Show("Lỗi ở phần thêm khách"); }
                    //try
                    //{
                    //    conn.closeConnection();
                    //    string strMa = "SELECT COUNT(*) FROM HoaDon";
                    //    int sl = conn.getCount(strMa) + 1;
                    //    string mahd = "HD" + sl;
                    //    string strSQL = " insert into hoadon values ('" + mahd + "','" + txtMa.Text + "','" + Convert.ToString(cboPhong.SelectedItem).Trim() + "','" + temp_time + "','Booked')";
                    //    conn.updateToDB(strSQL);
                    //}
                    //catch { MessageBox.Show("Lỗi ở phần thêm hóa đơn"); }
                    
            }
            if (!conn.checkForExits("select count(*) from hoadon where maphong = '" + Convert.ToString(cboPhong.SelectedItem).Trim() + "' and tinhtrang ='Booked'"))
            {
                try
                {
                    conn.closeConnection();
                    string strMa = "SELECT COUNT(*) FROM HoaDon";
                    int sl = conn.getCount(strMa) + 1;
                    string mahd = "HD" + sl;
                    string strSQL = " insert into hoadon values ('" + mahd + "','" + txtMa.Text + "','" + Convert.ToString(cboPhong.SelectedItem).Trim() + "','" + temp_time + "','Booked')";
                    conn.updateToDB(strSQL);
                }
                catch { MessageBox.Show("Lỗi ở phần thêm hóa đơn"); }
                MessageBox.Show("Đã đặt phòng " + Convert.ToString(cboPhong.SelectedItem) + "\nMã khách: " + txtMa.Text + "\nGiờ bắt đầu: " + temp_time);
                frmDatPhong_Load(sender, e);
            
            }

            else
            {
                MessageBox.Show("Phòng chưa được trả!");
            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhong.Text = "";
            cboPhong.Items.Clear();
            
            //MessageBox.Show(Convert.ToString(cboLoai.SelectedItem));
            string str = "SELECT * from Phong where LoaiPhong= '" + Convert.ToString(cboLoai.SelectedItem) + "' and NOT EXISTS (SELECT maphong FROM hoadon WHERE phong.maphong = hoadon.maphong AND tinhtrang ='Booked');";
            SqlDataReader db = conn.getDataReader(str);
            while (db.Read())
            {
                cboPhong.Items.Add(db["MaPhong"].ToString());
            }
            db.Close();
            cboPhong.Enabled = true;
        }

        private void frmDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Parent.Show();
        }

        private void txtTen_Leave(object sender, EventArgs e)
        {

            
        }

        private void txtTen_Leave_1(object sender, EventArgs e)
        {
            conn.closeConnection();
            if (conn.checkForExits("select count(*) from khachhang where tenkh = N'" + txtTen.Text + "'"))
            {
                string strSQL = "select makh,sodienthoai from khachhang where tenkh = N'" + txtTen.Text + "'";
                SqlDataReader dr = conn.getDataReader(strSQL);
                while (dr.Read())
                {
                    txtMa.Text = dr["Makh"].ToString();
                    txtSDT.Text = dr["SoDienThoai"].ToString();
                }
                //load_comboLoai();

            }
            else
            {
                txtMa.Text= txtSDT.Text = "";
                string strMa = "SELECT COUNT(*) FROM KHachhang";
                int sl = conn.getCount(strMa) + 1;
                string makh = "KH" + sl;
                txtMa.Text = makh;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(ctr, "Số điện thoại nhập chữ số");
            }
            else
                errorProvider1.Clear();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTen.Enabled = txtMa.Enabled = txtBD.Enabled = txtSDT.Enabled = btnDat.Enabled = txtMa.Enabled = true;
            txtTen.Focus();
        }

        private void cboPhong_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString());
        }

        private void txtBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control ctr = (Control)sender;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
               
            }
            else
                errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBD.TextLength.ToString());
        }

        private void txtBD_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
