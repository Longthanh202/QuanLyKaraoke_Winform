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
    public partial class frmMenu : Form
    {
        public delegate void TruyenAcc(string TenDangNhap,string LoaiTaiKhoan);
        public TruyenAcc Gui_Tk;
        DAO.dulieu dl = new DAO.dulieu();
        public frmMenu()
        {
            InitializeComponent();
            Gui_Tk = new TruyenAcc(NhanTaiKhoan);
        }

        string tenDN;
        DTO.TaiKhoan tk = new DTO.TaiKhoan();
        public void NhanTaiKhoan(string TenDangNhap,string LoaiTaiKhoan)
        {
            tenDN = TenDangNhap;
            tk.LoaiTaiKhoan = LoaiTaiKhoan;
        }

        public void LoadTaiKhoan()
        {
            DataTable dt = dl.LoadTaiKhoan(tenDN);
           if(dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tk.TenDangNhap = dr[0].ToString();
                    tk.TenHienThi = dr[1].ToString();
                    tk.MatKhau = dr[2].ToString();
                }
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmMain_NV f = new frmMain_NV();
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMain f = new frmMain();
            //f.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if(tk.LoaiTaiKhoan=="admin")
            {
                pt_qL.Visible = true;
                btnQuanTri.Visible = true;
                
            }
            LoadTaiKhoan();
            lblTenDN.Text = tk.TenHienThi;
        }

        private void ptbOrder_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmOder f = new frmOder();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmOder f = new frmOder();
            f.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            frmQuanTri f = new frmQuanTri();
            f.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void ptbBill_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.Show();
        }
    }
}
