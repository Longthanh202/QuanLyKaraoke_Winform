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
    public partial class frmOder : Form
    {
        

        DAO.dulieu dl = new DAO.dulieu();
        DAO.PhongDAO pDao = new DAO.PhongDAO();

        List<DTO.ChiTietHoaDon> ds_ChiTietHoaDon = new List<DTO.ChiTietHoaDon>();
        List<DTO.ChiTietDatMon> ds_datMon = new List<DTO.ChiTietDatMon>();
        DTO.ChiTietDatMon dm = new DTO.ChiTietDatMon();
        DTO.ChiTietHoaDon ct = new DTO.ChiTietHoaDon();

        public frmOder()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            SetButton();
            Button btn = (Button)sender;
            KiemTraPhong(btn);
            if(btn.BackColor == Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))))
            {
                btn.BackColor = Color.Blue;
                txtTenPhong.Text = btn.Text;
                txtMaPhong.Text = btn.Name;
            }
        }
        string TrangThaiPhong(int a)
        {
            if (a == 0)
                return "Trống";
            else
                return "Có người";
        }
        private void KiemTraPhong(Button btn)
        {
            if(btn.BackColor == Color.Red)
            {
                btn.Enabled = false;
            }
            else
            {
                btn.Enabled=true;
            }
        }
        //load danh sach phong
        void LoadDS_Phong()
        {
            flpPhong.Controls.Clear();
            List<DTO.Phong> lstPhong = pDao.LoadDanhSachPhong();
            foreach (DTO.Phong item in lstPhong)
            {
                Button btn = new Button() { Width = 140, Height = 140 };
                btn.Font= new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
                btn.ForeColor = System.Drawing.SystemColors.ButtonFace; ;
                btn.Text = item.TenPhong ; /*+ Environment.NewLine + TrangThaiPhong(item.TrangThai);*/
                btn.Click += btn_Click;
                btn.Name = item.MaPhong.ToString();
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case 0:
                        btn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); ;
                        break;
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                }
                KiemTraPhong(btn);
                flpPhong.Controls.Add(btn);
            }
        }
        private int TimMaPhong()
        {
            foreach(Button btn in flpPhong.Controls)
            {
                if(btn.BackColor==Color.Blue)
                {
                    return int.Parse(btn.Name.ToString());
                }
            }
            return 0;
        }
        private void LoadTabPage()
        {
            tabControl1.Controls.Clear();
            DataTable dt = dl.LoadDanhMucSanPham();
            
            foreach (DataRow dr in dt.Rows)
            {
                DataTable dt_SP = new DataTable();
                dt_SP = dl.LoadSanPham(dr[0].ToString());
                DTO.SanPham sp = new DTO.SanPham();
                //===============
                TableLayoutPanel tbl_item = new TableLayoutPanel();
                tbl_item.AutoScroll = true;
                tbl_item.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                tbl_item.BackColor = Color.Cyan;
                tbl_item.ColumnCount = 1;               
                tbl_item.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 835F));
                tbl_item.RowCount = dt_SP.Rows.Count;
                for (int i = 0; i < dt_SP.Rows.Count; i++)
                {
                    tbl_item.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
                }              
                tbl_item.Size = new System.Drawing.Size(835, 563);
                tbl_item.TabIndex = 0;
                int frm = 1;
                //================================= 
                foreach (DataRow d in dt_SP.Rows)
                {
                    sp.MaSanPham = d[0].ToString();
                    sp.TenSanPham = d[1].ToString();
                    sp.Gia = d[2].ToString();
                    sp.MaDanhMuc = d[3].ToString();
                    sp.HinhAnh = d[4].ToString();
                    sp.DonViTinh = d[5].ToString();
                    sp.SoLuong = int.Parse(d[6].ToString());
                    frmChiTietSanPham f = new frmChiTietSanPham();
                    f.Gui_SanPhan(sp.MaSanPham, sp.TenSanPham, sp.Gia, sp.MaDanhMuc, sp.HinhAnh, sp.DonViTinh, sp.SoLuong.ToString());
                    f.Gui_phong(cbbHD.Text);
                    f.Tag = frm;
                    f.GuiDonDat = new frmChiTietSanPham.TruyenDon(LoadDonDat);
                    f.GuiDonHuy = new frmChiTietSanPham.TruyenDon(LoadDonHuy);
                    frm++;
                    Panel pn = new Panel();
                    pn.Width = 850;
                    pn.Height = 550;
                    openForm1(f, pn);
                    tbl_item.Controls.Add(pn);
                }
                TabPage tp = new TabPage();
                tp.Anchor = System.Windows.Forms.AnchorStyles.None;
                tp.AutoScroll = false;
                tp.Controls.Add(tbl_item);
                tp.Location = new System.Drawing.Point(4, 32);
                tp.Name = dr[0].ToString();
                tp.Padding = new System.Windows.Forms.Padding(3);
                tp.Size = new System.Drawing.Size(850, 594);
                tp.TabIndex = 0;
                tp.Text = dr[1].ToString();
                tp.UseVisualStyleBackColor = true;
                tabControl1.Controls.Add(tp);                
            }
        }
        private void openForm1(Form f_Opsion, Panel pn)
        {
            f_Opsion.TopLevel = false;
            f_Opsion.FormBorderStyle = FormBorderStyle.None;
            f_Opsion.Dock = DockStyle.Fill;
            pn.Controls.Add(f_Opsion);
            pn.Tag = f_Opsion;
            f_Opsion.BringToFront();
            f_Opsion.Show();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmOder_Load(object sender, EventArgs e)
        {
            cbbHD.Items.Add(0);
            cbbHD.SelectedItem=0;
            cbbHD.Show();
            LoadDS_Phong();
            LoadTabPage();
        }
        private void SetButton()
        {
            foreach(Button btn in flpPhong.Controls)
            {
                if(btn.BackColor==Color.Blue)
                {
                    btn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
                }
            }
        }
        //dat phong
        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            int kq=dl.TaoHoaDon(txtMaPhong.Text,txtTenKhachHang.Text);
            kq = dl.UpdateTrangThaiDatPhong(txtMaPhong.Text);
            DataTable dt = dl.TimHoaDonMoiNhat();
            foreach(DataRow dr in dt.Rows)
            {
                cbbHD.Text = dr[0].ToString();
            }
            if(kq==1)
            {
                MessageBox.Show("Đã đặt phòng thành công,!!!chọn món đi ạ (^ v ^)");
                LoadDS_Phong();
            }
            else
            {
                MessageBox.Show("Đã đặt thất bại (-_-)");
            }
        }

        private void cbbHD_Click(object sender, EventArgs e)
        {
            DataSet ds = dl.LoadHoaDon();
            cbbHD.DataSource = ds.Tables[0];
            cbbHD.ValueMember = "MAHD";
            cbbHD.DisplayMember = "MAHD";
        }
        private string MaSanPham,TenSanPham;

        private void cbbHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbHD.Text=="0")
            {
                tabControl1.Enabled = false;
            }
            else
            {
                tabControl1.Enabled = true;
            }
        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
             LoadTabPage();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmMenu f = new frmMenu();
            //f.Show();
        }
        //load hoa don tu frmsanpham
        
        private void LoadDonDat(int mahoadon, int masp, int sl, float dongia, string tenSP)
        {
            ct = new DTO.ChiTietHoaDon();
            dm = new DTO.ChiTietDatMon();
            ct.MaHD = mahoadon;
            ct.MaSP = masp;
            ct.Sl = sl;
            ct.DonGia = dongia;
            dm.MaSP = masp;
            dm.TenSP = tenSP;
            dm.SoLuong = sl;
            ds_datMon.Add(dm);
            ds_ChiTietHoaDon.Add(ct);
            txtChitietDatmon.Text = "";
            foreach(DTO.ChiTietDatMon item in ds_datMon)
            {
                txtChitietDatmon.Text += item.TenSP + "(" + item.SoLuong + "); ";
            }
        }
        //huy dat mon
        DTO.ChiTietHoaDon ctHuy = new DTO.ChiTietHoaDon();
        DTO.ChiTietDatMon huyDm = new DTO.ChiTietDatMon();

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int kq=0;
            foreach (DTO.ChiTietHoaDon hd in ds_ChiTietHoaDon)
            {
                string strInsert = "insert into CHITIETHOADON values (" + cbbHD.Text + "," + hd.MaSP + "," + hd.Sl + "," + hd.DonGia + "," + hd.ThanhTien + ")";
                kq = dl.InsertChiTietHD(strInsert);              
            }
            if (kq == 0)
            {
                MessageBox.Show("Đặt thất bại !!!");
            }
            else
            {
                MessageBox.Show("Đặt thành công!!!(^ . ^)");
                LoadTabPage();
                txtChitietDatmon.Text = "";
            }
        }
        private void LoadLoaiPhong()
        {
            DataSet ds = dl.LoadLoaiPhong();
            dataGridView1.DataSource = ds.Tables["LOAIPHONG"];
        }
        private void btn_GioiThieuPhong_Click(object sender, EventArgs e)
        {
            LoadLoaiPhong();
            pn_gioiThieu.Visible = true;
        }

        private void btn_dongGioiThieu_Click(object sender, EventArgs e)
        {
            pn_gioiThieu.Visible = false;
        }

        private void LoadDonHuy(int mahoadon, int masp, int sl, float dongia, string tenSP)
        {
            ctHuy = new DTO.ChiTietHoaDon();
            huyDm = new DTO.ChiTietDatMon();
            ctHuy.MaHD = mahoadon;
            ctHuy.MaSP = masp;
            ctHuy.Sl = sl;
            ctHuy.DonGia = dongia;
            huyDm.MaSP = masp;
            huyDm.TenSP = tenSP;
            huyDm.SoLuong = sl;
            foreach(DTO.ChiTietDatMon item in ds_datMon)
            {
                if(item.MaSP==huyDm.MaSP)
                {
                    ds_datMon.Remove(item);
                    break;
                }
            }
            txtChitietDatmon.Text = "";
            foreach (DTO.ChiTietDatMon item in ds_datMon)
            {
                txtChitietDatmon.Text += item.TenSP + "(" + item.SoLuong + "); ";
            }
            foreach (DTO.ChiTietHoaDon item in ds_ChiTietHoaDon)
            {
                if (item.MaSP == ctHuy.MaSP)
                {
                    ds_ChiTietHoaDon.Remove(item);
                    break;
                }
            }
        }
    }
}
