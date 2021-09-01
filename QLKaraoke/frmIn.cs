using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    public partial class frmIn : Form
    {
        public frmIn()
        {
            InitializeComponent();
        }
        public frmIn(string ten)
        {
            
            InitializeComponent();
            HoaDon a = new HoaDon();
            crystalReportViewer1.ReportSource = a;
            a.SetDatabaseLogon("sa","sql2012","NGUYENDETHUONGV","QuanLyquankaraoke");
            a.SetParameterValue("LocHoaDon", ten);
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
            
        }
        private void frmIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
