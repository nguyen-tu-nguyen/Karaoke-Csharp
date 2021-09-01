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
    public partial class hello : Form
    {
        public hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rp a = new rp();
            crystalReportViewer1.ReportSource = a;
            crystalReportViewer1.Refresh();

        }
    }
}
