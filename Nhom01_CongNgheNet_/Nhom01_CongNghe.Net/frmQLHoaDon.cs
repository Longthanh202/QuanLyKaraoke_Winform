using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom01_CongNghe.Net.DAO;
using Nhom01_CongNghe.Net.DTO;

namespace Nhom01_CongNghe.Net
{
    public partial class frmQLHoaDon : Form
    {
        dulieu dl = new dulieu();
        DataSet ds;
        public frmQLHoaDon()
        {
            InitializeComponent();
            btnLuu.Visible = btnSua.Visible=btnThem.Visible=btnXoa.Visible= false;
        }
        private void LoadHoaDon()
        {
            ds = dl.LoadHoaDon();
            gv_1.DataSource = ds.Tables["HOADON"];
            DataColumn[] key = new DataColumn[1];
            key[0] = ds.Tables["HOADON"].Columns[0];
            ds.Tables["HOADON"].PrimaryKey = key;
            databingding();
            
        }
        private void databingding()
        {
            txtgiora.Clear();
            txtgiovao.Clear();
            txtmahd.Clear();
            txtmaphong.Clear();
            txttrangthai.Clear();
            txtTenKhach.Clear(); ;
            txttienphong.Clear();
            txttiendichvu.Clear(); ;
            txttongtien.Clear();


            txtmahd.DataBindings.Add("Text", gv_1.DataSource,"MAHD");
            txtgiovao.DataBindings.Add("Text", gv_1.DataSource, "GIOVAO");
            txtgiora.DataBindings.Add("Text", gv_1.DataSource, "GIORA");
            txtmaphong.DataBindings.Add("Text", gv_1.DataSource, "MAPHONG");
            txttrangthai.DataBindings.Add("Text", gv_1.DataSource, "TRANGTHAI"); ;
            txtTenKhach.DataBindings.Add("Text", gv_1.DataSource, "TENKHACHHANG");
            txttienphong.DataBindings.Add("Text", gv_1.DataSource, "TIENPHONG");
            txttiendichvu.DataBindings.Add("Text", gv_1.DataSource,"TIENDICHVU");
            txttongtien.DataBindings.Add("Text", gv_1.DataSource, "TONGTIEN");
        }
        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            gv_1.AllowUserToAddRows = false;
            gv_1.ReadOnly = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            gv_1.AllowUserToAddRows = true;
            gv_1.ReadOnly = false;
            for (int i = 0; i < gv_1.Rows.Count - 1; i++)
            {
                gv_1.Rows[i].ReadOnly = true;
            }
            gv_1.FirstDisplayedScrollingRowIndex = gv_1.Rows.Count - 1;
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            gv_1.ReadOnly = false;
            for (int i = 0; i < gv_1.Rows.Count - 1; i++)
            {
                gv_1.Rows[i].ReadOnly = false;
            }
            gv_1.Columns[0].ReadOnly = true;
            gv_1.AllowUserToAddRows = false;

            btnThem.Enabled = btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Xác nhận muốn xóa!", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (tb == DialogResult.Yes)
            {
                DataTable ds_acc = new DataTable();
                string strSelect = "select * from HOADON";
                dl.XoaDuLieu_Dgv(ds, "Accounts", txtmahd.Text, strSelect);

            }
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strSelect = "select *from HOADON";
                dl.LuuDataGridView(strSelect, ds, "DOADON");
                databingding();
                MessageBox.Show("Xử lý thành công!!!");
                btnThem.Enabled = btnXoa.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Xử lý thất bại!!!");
            }
        }
    }
}
