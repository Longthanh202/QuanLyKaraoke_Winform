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
using CrystalDecisions.CrystalReports.Engine;
using Nhom01_CongNghe.Net.DAO;
using Nhom01_CongNghe.Net.DTO;


namespace Nhom01_CongNghe.Net
{
    public partial class frmHoaDon : Form
    {
        dulieu dl = new dulieu();
        SqlConnection connect = new SqlConnection(@"Data Source=LEVI\SQLEXPRESS ;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True");
        SqlCommand sql_cmd = new SqlCommand();
        SqlDataAdapter sqlda = new SqlDataAdapter();
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void LoadCbb_HoaDon()
        {
            DataSet ds = dl.LoadHoaDon();
            cbb_HoaDon.DataSource = ds.Tables["HOADON"];
            cbb_HoaDon.DisplayMember = "MAHD";
            cbb_HoaDon.ValueMember = "MAHD";
            connect = new SqlConnection(@"Data Source=LEVI\SQLEXPRESS ;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True");
            connect.Open();
            sql_cmd.Connection = connect;
            sql_cmd.CommandType = CommandType.StoredProcedure;
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadCbb_HoaDon();
        }
        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            sql_cmd.CommandText = "XuatChiTietHoaDon";
            sql_cmd.Parameters.Clear();
            int mahd =(int)cbb_HoaDon.SelectedValue;
            sql_cmd.Parameters.AddWithValue("@mahd",mahd);
            sqlda.SelectCommand = sql_cmd;
            
            DataTable dt = new DataTable("HOADON");
            sqlda.Fill(dt);

            report_ChiTietHoaDon rpt = new report_ChiTietHoaDon();
            rpt.SetDataSource(dt);

            rpt.SetDatabaseLogon("sa", "123", @"LEVI\SQLEXPRESS", "Ql_PHONGKARAOKE");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
