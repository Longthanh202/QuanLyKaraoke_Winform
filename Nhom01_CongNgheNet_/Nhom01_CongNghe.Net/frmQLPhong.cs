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
using Nhom01_CongNghe.Net.DAO;
using Nhom01_CongNghe.Net.DTO;

namespace Nhom01_CongNghe.Net
{
    public partial class frmQLPhong : Form
    {
        //dulieu dl = new dulieu();
        //List<Phong> ds_Phong = new List<Phong>();
        //List<Phong> ds_PhongSua = new List<Phong>();
        //List<Phong> ds_PhongThem = new List<Phong>();
        //List<Phong> ds_PhongXoa = new List<Phong>();
        int id;

        //List<LoaiPhong> ds_LoaiPhong = new List<LoaiPhong>();

        DBConnect conn = new DBConnect();
        SqlDataAdapter ada;
        DataColumn[] primary = new DataColumn[1];
        public frmQLPhong()
        {
            InitializeComponent();
            //btnLuu.Visible = false;
            //btnThem.Visible = false;
            //btnXoa.Visible = false;
            //btnSua.Visible = false;
            //groupBox1.Visible = false;
            Load_Data();
            load_LoaiPhong();
            loadPhong();
            
        }
        private void LoadLoaiPhong()
        {
            //DataTable tb_LoaiPhong = dl.LoadLoaiPhong_DT();
            //if (tb_LoaiPhong.Rows.Count > 0 && tb_LoaiPhong != null)
            //{
            //    foreach (DataRow dr in tb_LoaiPhong.Rows)
            //    {
            //        LoaiPhong lp = new LoaiPhong();
            //        lp.MaLoaiPhong = dr[0].ToString();
            //        lp.TenLoaiPhong = dr[1].ToString();
            //        lp.DonGia = dr[2].ToString();
            //        ds_LoaiPhong.Add(lp);
            //    }
            //}


        }
        public void Load_Data()
        {
            string query = "select * from PHONG";
            ada = conn.getDataAdapter(query, "PHONG");
            primary[0] = conn.DSet.Tables["PHONG"].Columns[0];
            conn.DSet.Tables["PHONG"].PrimaryKey = primary;
        }
        public int LayMaxMa()
        {
            string query = "select max(MAPHONG) from PHONG";
            int max = conn.TimMax(query);
            return max;
        }
        //public void ds_LoaiPhong()
        //{
        //    string query = "select * from LOAIPHONG";
        //    DataTable tb = conn.ExecuteDataTable(query);
        //    cbbLoaiPhong.DisplayMember = "TENLOAIPHONG";
        //    cbbLoaiPhong.ValueMember = "MALOAIPHONG";
        //    cbbLoaiPhong.DataSource = tb;
        //}
        //private void Load_ListViewLoaiPhong()
        //{
        //    if(ds_LoaiPhong.Count>0)
        //    {
        //        lv_LoaiPhong.Items.Clear();
        //        foreach(LoaiPhong lp in ds_LoaiPhong)
        //        {
        //            ListViewItem item = new ListViewItem(lp.MaLoaiPhong);
        //            item.SubItems.Add(lp.TenLoaiPhong);
        //            item.SubItems.Add(lp.DonGia);
        //            lv_LoaiPhong.Items.Add(item);

        //        }
        //    }
        //}
        //private void LoadListView()
        //{
        //    DataTable dt_Phong = dl.LoadPhong();
        //    if(dt_Phong.Rows.Count>0 && dt_Phong!=null)
        //    {
        //        foreach(DataRow dr in dt_Phong.Rows)
        //        {
        //            Phong p = new Phong();
        //            p.MaPhong = int.Parse(dr[0].ToString());
        //            p.TenPhong = dr[1].ToString();
        //            p.TrangThai = int.Parse(dr[2].ToString());
        //            p.MaLoaiPhong = int.Parse(dr[3].ToString());
        //            ds_Phong.Add(p);
        //        }
        //    }
        //}
        private void LoadCbbLoaiPhong()
        {
            //DataSet ds_LoaiPhong = dl.LoadLoaiPhong();
            //cboLoaiPhong.DataSource = ds_LoaiPhong.Tables["LOAIPHONG"];
            //cboLoaiPhong.DisplayMember = "TENLOAIPHONG";
            //cboLoaiPhong.ValueMember = "MALOAIPHONG";
        }
        //private void LoadListView_Phong()
        //{
        //    if(ds_Phong.Count>0)
        //    {
        //        lv.Items.Clear();
        //        foreach(Phong p in ds_Phong)
        //        {
        //            ListViewItem item = new ListViewItem(p.MaPhong.ToString());
        //            item.SubItems.Add(p.TenPhong);
        //            item.SubItems.Add(p.TrangThai.ToString());
        //            item.SubItems.Add(p.MaLoaiPhong.ToString());
        //            lv.Items.Add(item);
        //        }
        //    }
        //}

        //private void lv_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(lv.SelectedItems.Count==0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        ListViewItem item = lv.SelectedItems[0];
        //        txtMaPhong.Text = item.SubItems[0].Text;
        //        txtTenPhong.Text = item.SubItems[1].Text;
        //        txtTrangThai.Text = item.SubItems[2].Text;
        //        cboLoaiPhong.SelectedValue = item.SubItems[3].Text;
        //    }
        //}

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            //LoadListView();
            //LoadCbbLoaiPhong();
            //LoadListView_Phong();

            //LoadLoaiPhong();
            //Load_ListViewLoaiPhong();

        }
        void loadPhong()
        {
            string query = "SELECT MAPHONG, TENPHONG, LOAIPHONG.TENLOAIPHONG FROM PHONG, LOAIPHONG WHERE PHONG.LOAIPHONG = LOAIPHONG.MALOAIPHONG";
            DataTable tb = conn.ExecuteDataTable(query);
            dgvDanhSachPhong.DataSource = tb;
        }
        public void load_LoaiPhong()
        {
            string query = "select * from LOAIPHONG";
            DataTable tb = conn.ExecuteDataTable(query);
            cboLoaiPhong.DisplayMember = "TENLOAIPHONG";
            cboLoaiPhong.ValueMember = "MALOAIPHONG";
            cboLoaiPhong.DataSource = tb;
        }
        private void lv_LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lv_LoaiPhong.SelectedItems.Count == 0)
            //{
            //    return;
            //}
            //else
            //{
            //    ListViewItem item = lv_LoaiPhong.SelectedItems[0];
            //    txtMaLoaiPhong.Text = item.SubItems[0].Text;
            //    txtTenLoaiPhong.Text = item.SubItems[1].Text;
            //    txtDonGia.Text = item.SubItems[2].Text;
            //}
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //LoadListView_Phong();
            //lv.Clear();
            
            int ma = LayMaxMa() + 1;
            try
            {
                if (txtTenPhong.Text != "")
                {
                    DataRow r = conn.DSet.Tables["PHONG"].NewRow();
                    r["MAPHONG"] = ma;
                    r["TENPHONG"] = txtTenPhong.Text;
                    r["TRANGTHAI"] = 0;
                    r["LOAIPHONG"] = cboLoaiPhong.SelectedValue;
                    conn.DSet.Tables["PHONG"].Rows.Add(r);
                    SqlCommandBuilder cmdbd = new SqlCommandBuilder(ada);
                    ada.Update(conn.DSet, "PHONG");
                    MessageBox.Show("Thêm thành công");
                    loadPhong();
                    
                }
                else
                {
                    MessageBox.Show("Ban chua nhap ten phong");
                }
            }
            catch
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPhong.Text == "")
                {
                    MessageBox.Show("Ban hay chon phong muon xoa");
                }
                else
                {
                    DataRow r = conn.DSet.Tables["PHONG"].Rows.Find(id);
                    if (r != null)
                    {
                        r.Delete();
                    }
                    SqlCommandBuilder cmdbd = new SqlCommandBuilder(ada);
                    ada.Update(conn.DSet, "PHONG");
                    MessageBox.Show("Xoa thành công");
                    loadPhong();
                 
                }
            }
            catch
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenPhong.Text == "")
                {
                    MessageBox.Show("Ban hay chon phong muon sua");
                }
                else
                {
                    DataRow r = conn.DSet.Tables["PHONG"].Rows.Find(id);
                    if (r != null)
                    {
                        r["TENPHONG"] = txtTenPhong.Text;
                        r["LOAIPHONG"] = cboLoaiPhong.SelectedValue;
                    }
                    SqlCommandBuilder cmdbd = new SqlCommandBuilder(ada);
                    ada.Update(conn.DSet, "PHONG");
                    MessageBox.Show("Sua thành công");
                    loadPhong();            
                }
            }
            catch
            {
                MessageBox.Show("Sua that bai");
            }
        }
         
        private void dgvDanhSachPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int i;
                
                i = dgvDanhSachPhong.CurrentRow.Index;
                id = int.Parse(dgvDanhSachPhong.Rows[i].Cells["MAPHONG"].Value.ToString());
                txtTenPhong.Text = dgvDanhSachPhong.Rows[i].Cells["TENPHONG"].Value.ToString();
                cboLoaiPhong.Text = dgvDanhSachPhong.Rows[i].Cells["LOAIPHONG"].Value.ToString();
                loadPhong();
            }
            catch
            {
                //MessageBox.Show("Lỗi!");
            }
        }
    }
}
