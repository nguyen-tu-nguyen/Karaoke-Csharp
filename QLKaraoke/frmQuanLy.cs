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
    public partial class frmQuanLy : Form
    {
        DBConnect conn = new DBConnect();
        DataSet ds_HD,dsNhanVien;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void load_HD()
        {
            string strSelect = "select MaNV,tennv,chucvu from nhanvien";
            ds_HD = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(ds_HD);
            //dgv.DataSource = ds_HD.Tables[0];


        }
        public void load()
        {
            string strSelect = "select * from hoadon";
            ds_HD = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(ds_HD);
            //dgv.DataSource = ds_HD.Tables[0];
        }
        public void load_NV()
        {
            string strSelect = "select MaNV,tennv,chucvu from nhanvien";
            dsNhanVien = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsNhanVien);
            dgv.DataSource = dsNhanVien.Tables[0];


        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            load_NV();
            string tien = "";
            lblDV.Text = lblTienNV.Text = "";
            try
            {
                string strSQL = "select CAST(tien as int) as N'TongTien' from doanhthu where loai='1'";
                SqlDataReader dr = conn.getDataReader(strSQL);
                while (dr.Read())
                {
                    tien += dr["TongTien"].ToString();
                }
                lblThuc.Text = tien+" VND";
            }
            catch { 
                MessageBox.Show("Lỗi");
            }
            //load_GridView2();
        //    load_GridView();
           
        }
        
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string ma;
        string tienNV;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            ma = "";
            tienNV = "";
            int n = e.RowIndex;
            //string stt = dgv.Rows[r].Cells[2].Value.ToString().Trim();
           // MessageBox.Show(stt);
            ma = dgv.Rows[r].Cells[1].Value.ToString().Trim();
            //MessageBox.Show(ma);
            //MessageBox.Show(ma);
            try
            {
                conn.closeConnection();
                string strSQL = "select cast(sum(tongtien) as int) as N'Tong' from chitiethoadon where nhanvientt = N'" + ma + "'";
                SqlDataReader dr = conn.getDataReader(strSQL);
                while (dr.Read())
                {
                    tienNV += dr["Tong"].ToString().Trim();
                }
                if(String.Compare(tienNV,"")==0)
                { lblTienNV.Text = "0 VND"; }
                else{
                lblTienNV.Text = tienNV + " VND";}
            }
            catch
            {
                lblTienNV.Text = "0 VND";
            }

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int r, c;
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                r = dgv.CurrentCell.RowIndex;
                c = dgv.CurrentCell.ColumnIndex;
            }
            catch { 

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTienTheoGio.Text = "";
            string tientg = "";
            int giobd = Convert.ToInt32(cboGioBD.SelectedItem), giokt = Convert.ToInt32(cboGioKT.SelectedItem);
            int phutbd = Convert.ToInt32(cboPhutBD.SelectedItem), phutkt = Convert.ToInt32(cboPhutKT.SelectedItem);
            if (giobd < giokt)
            {
                try
                {
                    conn.closeConnection();
                    string strSQL = "select cast(sum(tongtien) as int) as N'Tong' from chitiethoadon where  ("+giobd+"<=datepart(hh,giokt) and datepart(hh,giokt) <="+giokt+") and  ("+phutbd+"<=datepart(mi,giokt) and datepart(mi,giokt) <="+phutkt+") ";
                    SqlDataReader dr = conn.getDataReader(strSQL);
                    while (dr.Read())
                    {
                        tientg += dr["Tong"].ToString().Trim();
                    }
                    if (String.Compare(tientg, "") == 0)
                    { lblTienTheoGio.Text = "0 VND"; }
                    else
                    {
                        lblTienTheoGio.Text = tientg + " VND";
                    }
                }
                catch
                {
                    lblTienTheoGio.Text = "0 VND";
                }
            }
            else if (giobd == giokt)
            {
                if (phutbd<phutkt)
                {
                    try
                    {
                        conn.closeConnection();
                        string strSQL = "select cast(sum(tongtien) as int) as N'Tong' from chitiethoadon where  (" + giobd + "<=datepart(hh,giokt) and datepart(hh,giokt) <=" + giokt + ") and  (" + phutbd + "<=datepart(mi,giokt) and datepart(mi,giokt) <=" + phutkt + ") ";
                        SqlDataReader dr = conn.getDataReader(strSQL);
                        while (dr.Read())
                        {
                            tientg += dr["Tong"].ToString().Trim();
                        }
                        if (String.Compare(tientg, "") == 0)
                        { lblTienTheoGio.Text = "0 VND"; }
                        else
                        {
                            lblTienTheoGio.Text = tientg + " VND";
                        }
                    }
                    catch
                    {
                        lblTienTheoGio.Text = "0 VND";
                    }
                }
                else { MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc duyệt"); }


            }
            else { MessageBox.Show("Thời gian bắt đầu phải nhỏ hơn thời gian kết thúc duyệt"); }
            
            //MessageBox.Show(giobd.ToString()+":"+phutbd.ToString()+"\n"+giokt.ToString()+":"+phutkt.ToString());
           
        }
    }
}
