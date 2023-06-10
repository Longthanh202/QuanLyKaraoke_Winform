using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom01_CongNghe.Net
{
    public partial class Report_DanhSachHD : Form
    {
        public Report_DanhSachHD()
        {
            InitializeComponent();
        }

        private void Report_DanhSachHD_Load(object sender, EventArgs e)
        {
            ReportDSHD rpt = new ReportDSHD();
            rpt.SetDatabaseLogon("sa", "123", @"LEVI\SQLEXPRESS", "Ql_PHONGKARAOKE");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
