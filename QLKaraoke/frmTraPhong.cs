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
    public partial class frmTraPhong : Form
    {
        /*Tiền phòng:
         * Standard : 3k/ph
         * Standard15 : 4k/ph
         * VIP: 5k/ph
         * VIP15 6k/ph 
         */
        DBConnect conn = new DBConnect();
        string tennv = "";
        public frmTraPhong()
        {
            tennv = "guest";
            InitializeComponent();
        }
        public frmTraPhong(string tennv)
        {
            this.tennv = tennv;
            InitializeComponent();
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = button2.Enabled = true;
            double tienphong = 0;
            string kh = "", hd = "", tiendv = "", bd = "";
            string phong = Convert.ToString(cboPhong.SelectedItem);

            string strSQL = "select * from hoadon where maphong = '" + phong + "' and tinhtrang ='Booked' ";
            SqlDataReader dr = conn.getDataReader(strSQL);
            while (dr.Read())
            {
                kh += dr["makh"].ToString();
                hd += dr["mahd"].ToString();
                bd += dr["Giobd"].ToString();
            }
            dr.Close();
            lblBD.Text = bd;
            lblKH.Text = kh;
            lblHD.Text = hd;

            string strSQL2 = "select CAST(sum(dongia) as int) as N'TongTien' from ChiTietDichVu where  maphong = '" + phong + "' ";
            SqlDataReader dr2 = conn.getDataReader(strSQL2);
            while (dr2.Read())
            {
                tiendv += dr2["tongtien"].ToString();
            }
            dr2.Close();
            
            //int tiendvmoi = Convert.ToInt32(tiendv);
            if (tiendv=="")
            {
                tiendv = "0";
            }
            lblDV.Text = tiendv.ToString();
            //tính tiền phòng
            
            string timeNow = DateTime.Now.ToShortTimeString();
            string timeNow2 = DateTime.Now.ToString("HH:mm");


            DateTime enteredDate = DateTime.Parse(bd);
            TimeSpan diff = DateTime.Now.Subtract(enteredDate);
            
            string loai = "";

            try
            {
                string strSQL3 = "select loaiphong from phong where maphong = '" + phong + "' ";
                SqlDataReader dr3 = conn.getDataReader(strSQL3);
                while (dr3.Read())
                {
                    loai += dr3["loaiphong"].ToString();
                }
                dr3.Close();
            }
            catch { MessageBox.Show("Lỗi select loại phòng"); }
            if ((60 * diff.Hours + diff.Minutes) < 30)
            {
                if (String.Compare(loai, "Standard") == 0)
                {
                    tienphong = 50;
                }
                else if (String.Compare(loai, "Standard15") == 0)
                {
                    tienphong = 100;
                }
                else if (String.Compare(loai, "VIP") == 0)
                {
                    tienphong = 120;
                }
                else if (String.Compare(loai, "VIP15") == 0)
                {
                    tienphong = 150;
                }
                else
                {
                    MessageBox.Show("Lỗi truy xuất");
                    tienphong = 0;
                }
                tienphong = Math.Abs(tienphong) * 1000;
            }
            else
            {
                if (String.Compare(loai, "Standard") == 0)
                {
                    tienphong = 3 * (60 * diff.Hours + diff.Minutes);
                }
                else if (String.Compare(loai, "Standard15") == 0)
                {
                    tienphong = 4 * (60 * diff.Hours + diff.Minutes);
                }
                else if (String.Compare(loai, "VIP") == 0)
                {
                    tienphong = 5 * (60 * diff.Hours + diff.Minutes);
                }
                else if (String.Compare(loai, "VIP15") == 0)
                {
                    tienphong = 6 * (60 * Math.Abs(diff.Hours) + Math.Abs(diff.Minutes));
                }
                else
                {
                    MessageBox.Show("Lỗi truy xuất");
                    tienphong = 0;
                }
                tienphong = Math.Abs(tienphong) * 1000;
            }
            lblPhong.Text = tienphong.ToString()+"";

            
            lblTong.Text = (tienphong + Convert.ToInt32(tiendv)).ToString() + "";
            label4.Text = label5.Text = label7.Text = "VND";

            string timeNow3 = DateTime.Now.ToString("hh:mm");
            conn.closeConnection();
            string strSQL4 = " insert into chitiethoadon values ('" + lblHD.Text + "','" + lblKH.Text + "','" + Convert.ToString(cboPhong.SelectedItem) + "','" + lblBD.Text + "','" + timeNow2 + "'," + lblDV.Text + "," + lblPhong.Text + "," + lblTong.Text + ",N'" + label.Text + "')";
            conn.updateToDB(strSQL4);

            
            
            
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            label4.Text = label5.Text = label7.Text = "";
            cboPhong.Items.Clear();
            lblBD.Text = lblDV.Text = lblHD.Text = lblKH.Text = lblPhong.Text = lblTong.Text = "";
            label.Text = tennv;
            button1.Enabled = button2.Enabled = false;

            load_Phong();
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

        private void lblKH_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //thêm bảng chi tiết hóa đơn
            //string kh = "", hd = "", phong = Convert.ToString(cboPhong.SelectedItem),bd="",kt="",tienphong="",tiendv="",tongtien="",nv="";
            
            //try
            //{
            //    string timeNow2 = DateTime.Now.ToString("hh:mm");
            //    conn.closeConnection();
            //    string strSQL = " insert into chitiethoadon values ('" + lblHD.Text + "','" + lblKH.Text + "','" + Convert.ToString(cboPhong.SelectedItem) + "','"+lblBD.Text+"','"+timeNow2+"',"+lblDV.Text+","+lblPhong.Text+","+lblTong.Text+",N'"+label.Text+"')";
            //    conn.updateToDB(strSQL);
            //}
            //catch { MessageBox.Show("Lỗi ở phần thêm chi tiết"); }

            //chuyển tình trạng phòng thành returned
            try
            {
                conn.closeConnection();
                string strSQL = "update hoadon set tinhtrang ='Returned' where maphong = '" + Convert.ToString(cboPhong.SelectedItem) + "' and tinhtrang ='Booked'";
               conn.updateToDB(strSQL);
            }
            catch { MessageBox.Show("Lỗi ở phần update"); }
            //cập nhập doanh thu
            try
            {
                conn.closeConnection();
                string strSQL = " update doanhthu set tien=tien+"+lblTong.Text+" where loai =1;";
                conn.updateToDB(strSQL);
                this.Close();
            }
            catch { }
            MessageBox.Show("--------THANH TOÁN THÀNH CÔNG--------");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            string time = "12:30";
            string timeNow = DateTime.Now.ToShortTimeString();
            string timeNow2 = DateTime.Now.ToString("HH:mm");


            DateTime enteredDate = DateTime.Parse(time);
            TimeSpan diff = DateTime.Now.Subtract(enteredDate);
            MessageBox.Show(timeNow + "\n" + timeNow2 + "\n" + enteredDate + "\n" + diff.Hours.ToString());

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show(lblHD.Text);
            frmIn a = new frmIn(lblHD.Text);
            a.Show();
        }

    }
}
