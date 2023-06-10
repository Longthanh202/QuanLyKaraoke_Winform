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
    public partial class frmQuanTri : Form
    {
        public frmQuanTri()
        {
            InitializeComponent();
        }

        private void SetButtonDefault()
        {
            foreach (Control item in pnButton.Controls)
            {
                if (item is Button)
                {
                    item.ForeColor = System.Drawing.Color.White;
                    item.BackColor = System.Drawing.Color.Navy;
                }
            }
        }

        private Form FormOpsion;
        private void openForm(Form f_Opsion)
        {
            if (FormOpsion != null)
            {
                FormOpsion.Close();
            }
            FormOpsion = f_Opsion;
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;
            pnMain.Controls.Add(f_Opsion);
            pnMain.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btn_Phong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btn_Phong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));

            openForm(new frmQLPhong());
        }

        private void btnQLSP_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnQLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnQLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new frmQLSanPham());
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new frmTaiKhoan());
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            btnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            btnHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new frmQLHoaDon());
        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            SetButtonDefault();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetButtonDefault();
            button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            openForm(new DSHOADON());
        }
    }
}
