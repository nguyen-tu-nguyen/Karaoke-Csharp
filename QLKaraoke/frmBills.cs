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
    public partial class frmBills : Form
    {
        DBConnect conn = new DBConnect();
        //string quyenn = "";

        DataSet dsHD;
        public frmBills()
        {
            InitializeComponent();
        }

        private void frmBills_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            load_DV();
        }
        public void load_DV()
        {
            string strSelect = "select mahd, maphong, tinhtrang from hoadon";
            dsHD = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(strSelect, conn.Con);
            da.Fill(dsHD);
            dgv.DataSource = dsHD.Tables[0];
        }
        string ma = "";

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = "";
            int n = e.RowIndex;
            string stt = dgv.Rows[n].Cells[2].Value.ToString().Trim();
            if (String.Compare(stt, "Returned") == 0)
            {
                button2.Enabled = true;
                ma = dgv.Rows[n].Cells[0].Value.ToString();
                //MessageBox.Show(ma);
                
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmIn a = new frmIn(ma);
            a.Show();
        }
    }
}
