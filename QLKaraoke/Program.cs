using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKaraoke
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
            //Application.Run(new frmTrangChu());
            //Application.Run(new frmDatPhong());
            //Application.Run(new frmQuanLy());
            //Application.Run(new frmDanhMuc());
            //Application.Run(new frmDichVu());
           //Application.Run(new frmTraPhong());
           //Application.Run(new frmQuanLy());
          // Application.Run(new frmIn("HD1"));
            //Application.Run(new frmBills());
            
            

        }
    }
}
