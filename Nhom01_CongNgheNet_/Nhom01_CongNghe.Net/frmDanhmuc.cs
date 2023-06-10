using Nhom01_CongNghe.Net.DAO;
using Nhom01_CongNghe.Net.DTO;
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
    public partial class frmDanhmuc : Form
    {
        public frmDanhmuc()
        {
            InitializeComponent();
        }
        DBConnect conn = new DBConnect();
        private void frmDanhmuc_Load(object sender, EventArgs e)
        {
            loadDanhMuc();                   
        }

        void loadDanhMuc()
        {
            string query = "SELECT * FROM DANHMUCSANPHAM";
            DataTable tb = conn.ExecuteDataTable(query);
            dgvDSDanhMuc.DataSource = tb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDanhMuc.Text != "")
            {
                try
                {
                    string query = "insert into DANHMUCSANPHAM values(N'" + txtTenDanhMuc.Text + "')";
                    conn.UpdateToDatabase(query);
                    MessageBox.Show("Thêm thành công");
                    loadDanhMuc();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập tên danh mục muốn thêm");
            }         
        }
        int id;
        private void btnXoa_Click(object sender, EventArgs e)
        {   
            if(txtTenDanhMuc.Text != "")
            {
                DialogResult r = MessageBox.Show("Bạn muốn xóa ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {
                    string query = "SELECT COUNT(*) FROM SANPHAM WHERE MADANHMUC = '" + id + "'";
                    int count = conn.GetCount(query);
                    if (count > 0)
                    {
                        MessageBox.Show("Danh mục này đã có sản phẩm không thể xóa", "Thông báo");
                        return;
                    }
                    try
                    {
                        query = "delete from DANHMUCSANPHAM where MADANHMUC = '" + id + "'";
                        conn.UpdateToDatabase(query);
                        MessageBox.Show("Xóa thành công");
                        loadDanhMuc();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn danh mục muốn xóa");
            }
        }

        private void dgvDSDanhMuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDSDanhMuc.CurrentRow.Index;
            id = int.Parse(dgvDSDanhMuc.Rows[i].Cells[0].Value.ToString());
            txtTenDanhMuc.Text = dgvDSDanhMuc.Rows[i].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtTenDanhMuc.Text != "")
            {
                DialogResult r = MessageBox.Show("Bạn muốn sửa ?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.Yes)
                {                  
                    try
                    {
                        string query = "update DANHMUCSANPHAM SET TENDANHMUC = N'" + txtTenDanhMuc.Text.Trim() + "' WHERE MADANHMUC = '" + id + "'";
                        conn.UpdateToDatabase(query);
                        MessageBox.Show("Cập nhật thành công");
                        loadDanhMuc();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn danh mục muốn sửa");
            }
        }

        private void frmDanhmuc_FormClosing(object sender, FormClosingEventArgs e)
        {         
            this.Hide();        
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM DANHMUCSANPHAM WHERE TENDANHMUC LIKE N'%{0}%'", txtTimKiem.Text);
            DataTable tb = conn.ExecuteDataTable(query);
            dgvDSDanhMuc.DataSource = tb;
        }
    }
}
