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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            loadTaiKhoan();
            load_Data();
        }
        DBConnect conn = new DBConnect();
        SqlDataAdapter ada;
        DataColumn[] primary = new DataColumn[1];       
        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {           
            this.Hide();          
        }
        void loadTaiKhoan()
        {
            string query = "SELECT TENDANGNHAP, TENHIENTHI, LOAITAIKHOAN FROM TAIKHOAN";
            DataTable tb = conn.ExecuteDataTable(query);
            dgvDanhSachTK.DataSource = tb;
        }
        public void load_Data()
        {
            string query = "select * from TAIKHOAN";
            ada = conn.getDataAdapter(query, "TAIKHOAN");
            primary[0] = conn.DSet.Tables["TAIKHOAN"].Columns[0];
            conn.DSet.Tables["TAIKHOAN"].PrimaryKey = primary;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == string.Empty || txtMatKhau.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập ten dang nhap va mat khau");
                txtTenDangNhap.Focus();
                return;
            }
            try
            {
                DataRow row = conn.DSet.Tables["TAIKHOAN"].Rows.Find(txtTenDangNhap.Text.Trim());
                if (row != null)
                {
                    MessageBox.Show("Tai khoan này đã tồn tại");
                    return;
                }
                DataRow newrow = conn.DSet.Tables["TAIKHOAN"].NewRow();
                newrow["TENDANGNHAP"] = txtTenDangNhap.Text.Trim();
                newrow["TENHIENTHI"] = txtTenHienThi.Text;
                newrow["MATKHAU"] = txtMatKhau.Text.Trim();
                newrow["LOAITAIKHOAN"] = "user";
                conn.DSet.Tables["TAIKHOAN"].Rows.Add(newrow);
                SqlCommandBuilder cmdbd = new SqlCommandBuilder(ada);
                ada.Update(conn.DSet, "TAIKHOAN");
                MessageBox.Show("Thêm thành công");
                loadTaiKhoan();
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenDangNhap.Text =="")
                {
                    MessageBox.Show("Ban hay chon tai khoan muon xoa");
                }
                else
                {
                    DataRow r = conn.DSet.Tables["TAIKHOAN"].Rows.Find(txtTenDangNhap.Text.Trim());
                    if (r != null)
                    {
                        r.Delete();
                    }
                    SqlCommandBuilder cmdbd = new SqlCommandBuilder(ada);
                    ada.Update(conn.DSet, "TAIKHOAN");                   
                    MessageBox.Show("Xoa thành công");
                    txtTenDangNhap.Clear();
                    txtTenHienThi.Clear();
                    loadTaiKhoan();
                }
            }
            catch
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void dgvDanhSachTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDanhSachTK.CurrentRow.Index;
            txtTenDangNhap.Text = dgvDanhSachTK.Rows[i].Cells[0].Value.ToString();
            txtTenHienThi.Text = dgvDanhSachTK.Rows[i].Cells[1].Value.ToString();
        }
    }
}
