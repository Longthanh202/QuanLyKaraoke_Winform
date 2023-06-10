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

namespace Nhom01_CongNghe.Net
{
    public partial class Report_DoanhSo : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand sql_cmd = new SqlCommand();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        public string Ngay { get; set; }
        public Report_DoanhSo(string Ngay)
        {
            InitializeComponent();
            this.Ngay = Ngay;
        }
        public Report_DoanhSo()
        {
            InitializeComponent();
        }

        private void Report_DoanhSo_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection(@"Data Source=LEVI\SQLEXPRESS ;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True");
            connect.Open();
            sql_cmd.Connection = connect;
            sql_cmd.CommandType = CommandType.StoredProcedure;

            sql_cmd.CommandText = "DOANHSOBANHANG";
            sql_cmd.Parameters.Clear();

            sql_cmd.Parameters.AddWithValue("@NgayKiemTra", Ngay);
            sqlda.SelectCommand = sql_cmd;

            DataTable dt = new DataTable("DOANHSOBANHANG");
            sqlda.Fill(dt);


            CrystalReport_DoanhSo rpt = new CrystalReport_DoanhSo();
            rpt.SetDataSource(dt);

            rpt.SetDatabaseLogon("sa", "123", @"LEVI\SQLEXPRESS", "Ql_PHONGKARAOKE");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
