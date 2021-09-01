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
    public partial class frmTrangChu : Form
    {
        DBConnect conn = new DBConnect();
        public string m_connect = @"Data Source=NGUYENDETHUONGV;Initial Catalog=QuanLyQuanKaraoke;Persist Security Info=True;User ID=sa;Password=sql2012";
        SqlConnection con = null;
        public delegate void NewHome();
        public event NewHome OnNewHome;

        string quyen = "";
        string tenNV = "";
        public frmTrangChu()
        {
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);
        }

        public frmTrangChu(string quyen,string ten)
        {
            
            this.quyen = quyen;
            this.tenNV = ten;
            
            InitializeComponent();
            try
            {
                SqlClientPermission ss = new SqlClientPermission(System.Security.Permissions.PermissionState.Unrestricted);
                ss.Demand();
            }
            catch (Exception)
            {

                throw;
            }
            SqlDependency.Stop(m_connect);
            SqlDependency.Start(m_connect);
            con = new SqlConnection(m_connect);

        }

        private void miNguoiDung_Click(object sender, EventArgs e)
        {
            frmDangNhap a = new frmDangNhap();
            a.ShowDialog();
        }
        public void load_HD()
        {
            DataTable dt = new DataTable();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT   mahd,makh,maphong,giobd,tinhtrang  from hoadon", con);
            cmd.Notification = null;

            SqlDependency de = new SqlDependency(cmd);
            de.OnChange += new OnChangeEventHandler(de_OnChange);

            dt.Load(cmd.ExecuteReader(CommandBehavior.CloseConnection));
            //dgv.DataSource = dt;

        }
        public void de_OnChange(object sender, SqlNotificationEventArgs e)
        {
            SqlDependency de = sender as SqlDependency;
            de.OnChange -= de_OnChange;
            if (OnNewHome != null)
            {
                OnNewHome();
            }
        }
        public void frmMain_OnNewHome()
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;
            if (i.InvokeRequired)//tab
            {
                NewHome dd = new NewHome(frmMain_OnNewHome);
                i.BeginInvoke(dd, null);
                return;
            }
            load_HD();
        }
        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            OnNewHome += new NewHome(frmMain_OnNewHome);
            load_HD();
            //dgv.ReadOnly = true;
            label1.Text += tenNV;   
            if (String.Compare(quyen, "QL", true) == 0)
            {
                miQuanLy.Enabled = true;
            }
            else if(String.Compare(quyen, "NV", true) == 0)
            {
                miQuanLy.Enabled = false;
            }
            else
            {
                //MessageBox.Show("Bạn chưa đăng nhập.");
                //miQuanLy.Enabled = miDanhMuc.Enabled = miDatPhong.Enabled = false;
            }

               
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhMuc a = new frmDanhMuc(quyen);
            a.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy a = new frmQuanLy();
            a.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatPhong a = new frmDatPhong();
            a.Show();
        }

        private void frmTrangChu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show(this.Parent.ToString());
            //this.Parent.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                MessageBox.Show("Trả phòng ở dòng " + e.ColumnIndex.ToString());
            }
        }
        public void traPhong()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTraPhong a = new frmTraPhong(tenNV);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDichVu a = new frmDichVu();
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDatPhong a = new frmDatPhong();
            a.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn.closeConnection();
            string strSQL = " delete from  chitiethoadon delete from  chitietdichvu   update doanhthu set tien = 0 delete from hoadon delete from khachhang where TenKH =N''";
            conn.updateToDB(strSQL);
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            frmBills a = new frmBills();
            a.Show();

        }
    }
}
