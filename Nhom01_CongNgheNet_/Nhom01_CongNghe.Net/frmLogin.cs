using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom01_CongNghe.Net
{
    public partial class frmLogin : Form
    {     
        public frmLogin()
        {
            InitializeComponent();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DBConnect d = new DBConnect();
            string sql = "select * from TAIKHOAN where TENDANGNHAP = N'" + txtUserName.Text + "'and MATKHAU = N'" + txtPassword.Text + "'";
            DataTable dt = d.ExecuteDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                this.Hide();
                //frmMain f = new frmMain(dt.Rows[0][0].ToString(),dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                frmMenu f = new frmMenu();
                f.Gui_Tk(dt.Rows[0][0].ToString(),dt.Rows[0][3].ToString());
                f.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}
