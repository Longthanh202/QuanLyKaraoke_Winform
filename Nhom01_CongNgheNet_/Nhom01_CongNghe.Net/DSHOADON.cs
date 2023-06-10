using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Nhom01_CongNghe.Net
{
    public partial class DSHOADON : Form
    {
        public DSHOADON()
        {
            InitializeComponent();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            Report_DanhSachHD f = new Report_DanhSachHD();
            openForm1(f, pnMain);
        }
        private void openForm1(Form f_Opsion, Panel pn)
        {
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;
            pn.Controls.Add(f_Opsion);
            pn.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }

        private void btnXuatDoanhSo_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            string ngay = String.Format("{0:dd/MM/yyyy}", dateTimePicker1.Value);
            Report_DoanhSo f = new Report_DoanhSo(ngay);
            openForm1(f, pnMain);
        }
    }
}
