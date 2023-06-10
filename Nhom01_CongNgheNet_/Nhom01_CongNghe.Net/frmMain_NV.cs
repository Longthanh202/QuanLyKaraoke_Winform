using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Nhom01_CongNghe.Net
{
    public partial class frmMain_NV : Form
    {
        DAO.dulieu dl = new DAO.dulieu();
        DAO.PhongDAO pDao = new DAO.PhongDAO();
        DAO.HoaDon_DAO dl_hd = new DAO.HoaDon_DAO();
        public delegate void TruyenAcc(string TenDangNhap,string TenHienThi,string MatKhau);
        public TruyenAcc Gui_Tk;
        public frmMain_NV()
        {
            InitializeComponent();
            Gui_Tk =new  TruyenAcc(NhanTaiKhoan);
        }
        DTO.TaiKhoan tk = new DTO.TaiKhoan();
        public void NhanTaiKhoan(string TenDangNhap, string TenHienThi, string MatKhau)
        {
            tk.TenDangNhap = TenDangNhap;
            tk.TenHienThi = TenHienThi;
            tk.MatKhau = MatKhau;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }


        //private void frmMain_Load(object sender, EventArgs e)
        //{

        //}

        private void menuSanPham_Click(object sender, EventArgs e)
        {
            //frmSanPham fSP = new frmSanPham();
            //fSP.Show();
        }

        //private void đangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát phần mềm?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void SetButton()
        //{
        //    foreach (Button btn in flpPhong.Controls)
        //    {
        //        if (btn.BackColor == Color.Blue)
        //        {
        //            btn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
        //        }
        //    }
        //}
        //Load hoa don va chi tiet hoa don khi khach tra phong
        DTO.HoaDon HD = new DTO.HoaDon();
        private void LoadHoaDon(string maPhong)
        {
            HD = new DTO.HoaDon();
            DataTable dt = dl_hd.HoaDon(maPhong);
            foreach(DataRow dr in dt.Rows)
            {
                HD.MaHoaDon = int.Parse(dr["MAHD"].ToString());
                HD.GioVao = DateTime.Parse(dr["GIOVAO"].ToString());  
                if(dr["GIORA"].ToString()=="")
                {
                    HD.GioRa = null;
                }
                else
                {
                    HD.GioRa = DateTime.Parse(dr["GIORA"].ToString());
                }
                HD.MaPhong = int.Parse(dr["MAPHONG"].ToString());
                HD.TrangThai = int.Parse(dr["TRANGTHAI"].ToString());
                HD.TenKhachHang = dr["TENKHACHHANG"].ToString();
                if(dr["TIENPHONG"].ToString()!=null && dr["TIENPHONG"].ToString()!="")
                    HD.TienPhong = float.Parse(dr["TIENPHONG"].ToString());
                if(dr["TIENDICHVU"].ToString()!=null && dr["TIENDICHVU"].ToString()!="")
                    HD.TienDichVu = float.Parse(dr["TIENDICHVU"].ToString());
            }
            txtMaHD.Text = HD.MaHoaDon.ToString();
            txtTenKH.Text = HD.TenKhachHang;
            txtTrangThai.Text = HD.TrangThai.ToString();
            txtMaPhong.Text = HD.MaPhong.ToString();
            DateTime GioVao = DateTime.Parse(HD.GioVao.ToString());
            string giovao = GioVao.ToString("dd:MM:yyyy HH:mm:ss");
            mtxtGioVao.Text = giovao.ToString();
            if(HD.GioRa!=null)
            {
                DateTime GioRa = DateTime.Parse(HD.GioRa.ToString());
                string giora = GioRa.ToString("dd:MM:yyyy HH:mm:ss");
                mtxtGioRa.Text = giora.ToString();
                btn_Dung.Enabled = false;
            }
            else
            {
                mtxtGioRa.Text = HD.GioRa.ToString();
                btn_Dung.Enabled = true;
            }
            if (txtMaHD.Text=="")
            {
                btn_Dung.Enabled = false;
            }
            else
            {
                btn_Dung.Enabled = true;
            }
        }

        
        List<DTO.ChiTietHoaDon> ds_HoaDon = new List<DTO.ChiTietHoaDon>();
        private void LoadChiTietHoaDon(string maHD)
        {
            ds_HoaDon.Clear();
            DataTable dt = dl_hd.ChiTietHoaDon(maHD);
            lvHoaDon.Items.Clear();
            foreach(DataRow dr in dt.Rows)
            {
                DTO.ChiTietHoaDon cthd = new DTO.ChiTietHoaDon();
                ListViewItem item = new ListViewItem(dr[0].ToString());
                cthd.MaHD = int.Parse(dr[0].ToString());
                item.SubItems.Add(dr[1].ToString());
                cthd.MaSP = int.Parse(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                cthd.Sl = int.Parse(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                cthd.DonGia = float.Parse(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                lvHoaDon.Items.Add(item);
                ds_HoaDon.Add(cthd);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            //SetButton();
            Button btn = (Button)sender;
            KiemTraPhong(btn);
            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.Blue;
                LoadHoaDon(btn.Name);
                LoadChiTietHoaDon(HD.MaHoaDon.ToString());               
                txtHDPHU.Text = TinhTienHoaDonPhu().ToString();
                if (mtxtGioRa.Text != "  /  /       :")
                {
                    //dl_hd.ThemGioRa(txtMaHD.Text);
                    LoadHoaDon(txtMaPhong.Text);
                    TinhThoiGianThuePhong(mtxtGioVao.Text, mtxtGioRa.Text);
                    txtHDPHU.Text = TinhTienHoaDonPhu().ToString();
                    btn_Dung.Enabled = false;
                }
            }
            else if(btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.Red;

                txtMaHD.Text ="";
                txtTenKH.Text = "";             
                txtTrangThai.Text ="";
                txtMaPhong.Text = "";
                mtxtGioVao.Text = "";
                mtxtGioRa.Text = "";
                lvHoaDon.Items.Clear();
                txtHDPHU.Text = "";
            }
            
        }
        private void LoadCbbChuyenPhong()
        {
            DataSet ds_phong=dl_hd.Load_CbbChuyenPhong();
            cboChuyenPhong.DataSource = ds_phong.Tables["CbbPhong"];
            cboChuyenPhong.DisplayMember = "TenPhong";
            cboChuyenPhong.ValueMember = "MaPhong";
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
            if (btn.BackColor == Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))))
            {
                btn.Enabled = false;
            }
            //else
            //{
            //    btn.Enabled = false;
            //}
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
                btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
                btn.Text = item.TenPhong; /*+ Environment.NewLine + TrangThaiPhong(item.TrangThai);*/
                btn.Click += btn_Click;
                btn.Name = item.MaPhong.ToString();
                btn.Tag = item;
                switch (item.TrangThai)
                {
                    case 0:
                        btn.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); 
                        break;
                    case 1:
                        btn.BackColor = Color.Red;
                        break;
                }
                KiemTraPhong(btn);
                flpPhong.Controls.Add(btn);
            }
        }


        //private string ChuanHoaGia(string Gia)
        //{
        //    //string gia = "";
        //    string gia1 = "";
        //    //for (int i = 0; i <= Gia.Length - 1; i++)
        //    //{
        //    //    if (Gia[i] == '.')
        //    //    {
        //    //        break;
        //    //    }
        //    //    gia += Gia[i];
        //    //}
        //    Stack giaChuanHoa = new Stack();
        //    int dem = 0;
        //    for (int i = Gia.Length - 1; i >= 0; i--)
        //    {
        //        if (dem < 3)
        //        {
        //            giaChuanHoa.Push(Gia[i]);
        //            dem++;
        //        }
        //        else
        //        {
        //            giaChuanHoa.Push(".");
        //            giaChuanHoa.Push(Gia[i]);
        //            dem = 1;
        //        }
        //    }
        //    while (giaChuanHoa.Count != 0)
        //    {
        //        gia1 += giaChuanHoa.Pop();
        //    }
        //    return gia1;
        //}



        private void frmMain_NV_Load(object sender, EventArgs e)
        {
            LoadDS_Phong();
            cboChuyenPhong.Enabled = false;
            btn_Dung.Enabled = false;
        }

        private void btn_Dung_Click(object sender, EventArgs e)
        {
            dl_hd.ThemGioRa(txtMaHD.Text);
            LoadHoaDon(txtMaPhong.Text);
            if (mtxtGioRa.Text == "  /  /       :")
            {
                btn_Dung.Enabled = true;
            }
            else
            {
                btn_Dung.Enabled = false;
            }
            TinhThoiGianThuePhong(mtxtGioVao.Text, mtxtGioRa.Text);
            txtHDPHU.Text = TinhTienHoaDonPhu().ToString();

        }
        private float TinhTienHoaDonPhu()
        {
            DataTable ds_HoaDonPhu = dl_hd.HoaDonPhu(HD.MaHoaDon.ToString());
            if (ds_HoaDonPhu.Rows.Count > 0 && ds_HoaDonPhu != null)
            {
                float tong = 0;
                foreach (DataRow dr in ds_HoaDonPhu.Rows)
                {
                    tong += float.Parse(dr["TONGTIEN"].ToString());
                }
                return tong;
            }
            else
                return 0;
        }
        private float TinhTienPhong(string giovao, string giora)
        {
            //DateTime GioVao =DateTime.ParseExact(giovao, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);
            string giovao_ = giovao;
            string giora_ = giora;

            //DateTime GioVao = DateTime.Parse(giovao);
            //string giovao_ = GioVao.ToString("dd:MM:yyyy HH:mm:ss");
            //DateTime GioRa = DateTime.Parse(giora);
            //string giora_ = GioRa.ToString("dd:MM:yyyy HH:mm:ss");

            //DateTime GioRa = DateTime.Parse(giora);
            //string giora_ = GioRa.ToString("dd:MM:yyyy HH:mm:ss");


            int loaiPhong = 0;
            float giaPhong = 0;
            DataTable dt = dl_hd.LoadLoaiPhong(HD.MaPhong.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                loaiPhong = int.Parse(dr[0].ToString());
            }
            DataTable ds_loaiPhong = dl_hd.LoaiPhong();
            foreach (DataRow dr in ds_loaiPhong.Rows)
            {
                int lp = int.Parse(dr[0].ToString());
                if (loaiPhong == lp)
                {
                    giaPhong = float.Parse(dr[2].ToString());
                    break;
                }
            }
            //26/11/2022 16:46
            //26/11/2022 18:16
            int ngayvao = int.Parse(giovao_[0].ToString() + giovao_[1].ToString());
            int ngayra = int.Parse(giora_[0].ToString() + giora_[1].ToString());
            int hvao = int.Parse(giovao_[11].ToString() + giovao_[12].ToString());
            int hra = int.Parse(giora_[11].ToString() + giora_[12].ToString());
            int phutvao = int.Parse(giovao_[14].ToString() + giovao_[15].ToString());
            int phutra = int.Parse(giora_[14].ToString() + giora_[15].ToString());
            int tonggio = 0;
            int tongphut = 0;
            float thanhtien = 0;
            if (ngayvao <= ngayra)
            {
                if (hvao <= hra)
                {
                    tonggio = hra - hvao;
                }
                else
                {
                    tonggio = 24 - hvao + hra;
                }
                if (phutvao <= phutra)
                {
                    tongphut = phutra - phutvao;
                }
                else
                {
                    tongphut = 60 - phutvao + phutra;
                }
            }
            thanhtien = tonggio * giaPhong;
            if (tongphut >= 45)
            {
                thanhtien += giaPhong * 3 / 4;
            }
            else if (tongphut >= 30)
            {
                thanhtien += giaPhong / 2;
            }
            else if (tongphut >= 15)
            {
                thanhtien += giaPhong / 4;
            }
            else
            {
                thanhtien += 0;
            }
            return thanhtien;
        }

        private float TinhTienPhong_2(string giovao, string giora)
        {
            //DateTime GioVao =DateTime.ParseExact(giovao, "dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);
            //string giovao_ = giovao;
            //string giora_ = giora;

            DateTime GioVao = DateTime.Parse(giovao);
            string giovao_ = GioVao.ToString("dd:MM:yyyy HH:mm:ss");
            DateTime GioRa = DateTime.Parse(giora);
            string giora_ = GioRa.ToString("dd:MM:yyyy HH:mm:ss");

            //DateTime GioRa = DateTime.Parse(giora);
            //string giora_ = GioRa.ToString("dd:MM:yyyy HH:mm:ss");


            int loaiPhong = 0;
            float giaPhong = 0;
            DataTable dt = dl_hd.LoadLoaiPhong(HD.MaPhong.ToString());
            foreach (DataRow dr in dt.Rows)
            {
                loaiPhong = int.Parse(dr[0].ToString());
            }
            DataTable ds_loaiPhong = dl_hd.LoaiPhong();
            foreach (DataRow dr in ds_loaiPhong.Rows)
            {
                int lp = int.Parse(dr[0].ToString());
                if (loaiPhong == lp)
                {
                    giaPhong = float.Parse(dr[2].ToString());
                    break;
                }
            }
            //26/11/2022 16:46
            //26/11/2022 18:16
            int ngayvao = int.Parse(giovao_[0].ToString() + giovao_[1].ToString());
            int ngayra = int.Parse(giora_[0].ToString() + giora_[1].ToString());
            int hvao = int.Parse(giovao_[11].ToString() + giovao_[12].ToString());
            int hra = int.Parse(giora_[11].ToString() + giora_[12].ToString());
            int phutvao = int.Parse(giovao_[14].ToString() + giovao_[15].ToString());
            int phutra = int.Parse(giora_[14].ToString() + giora_[15].ToString());
            int tonggio = 0;
            int tongphut = 0;
            float thanhtien = 0;
            if (ngayvao <= ngayra)
            {
                if (hvao <= hra)
                {
                    tonggio = hra - hvao;
                }
                else
                {
                    tonggio = 24 - hvao + hra;
                }
                if (phutvao <= phutra)
                {
                    tongphut = phutra - phutvao;
                }
                else
                {
                    tongphut = 60 - phutvao + phutra;
                }
            }
            thanhtien = tonggio * giaPhong;
            if (tongphut >= 45)
            {
                thanhtien += giaPhong * 3 / 4;
            }
            else if (tongphut >= 30)
            {
                thanhtien += giaPhong / 2;
            }
            else if (tongphut >= 15)
            {
                thanhtien += giaPhong / 4;
            }
            else
            {
                thanhtien += 0;
            }
            return thanhtien;
        }
        private void TinhThoiGianThuePhong(string giovao,string giora)
        {
            int giamgia = int.Parse(txtGiamGia.Text);

            txtHDPHU.Text = (TinhTienHoaDonPhu() - TinhTienHoaDonPhu() * giamgia / 100).ToString();

            float tienphong= TinhTienPhong(giovao, giora);
            tienphong= tienphong - tienphong * giamgia / 100;
            HD.TienPhong = tienphong + TinhTienHoaDonPhu();
            txtTienPhong.Text =tienphong.ToString();

            //tinh tien dich vu;
            float tiendichvu = 0;
            foreach(DTO.ChiTietHoaDon hd in ds_HoaDon)
            {
                tiendichvu += hd.ThanhTien;
            }
            HD.TienDichVu = tiendichvu-tiendichvu*giamgia/100;
            txtTienDichVu.Text = tiendichvu.ToString();
            
            txtThanhTien.Text = HD.TongTien.ToString();
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmMenu f = new frmMenu();
            //f.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int kq = dl_hd.upDateHoaDon(HD);
            kq = dl_hd.upDatePhong(HD.MaPhong.ToString());
            if(kq==1)
            {
                MessageBox.Show("Thanh toán thành công!!!");
            }
            else
            {
                MessageBox.Show("Thanh toán THẤT BẠI !!!");
            }
            LoadDS_Phong();
        }
        //Chyen phhong//
        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            if(cboChuyenPhong.Enabled==false)
            {
                LoadCbbChuyenPhong();
                cboChuyenPhong.Enabled = true;
            }
            else
            {
                if(cboChuyenPhong.SelectedIndex>=0)
                {
                    string maphong = cboChuyenPhong.SelectedValue.ToString();
                    
                    dl_hd.ThemGioRa(HD.MaHoaDon.ToString());
                    LoadHoaDon(HD.MaPhong.ToString());
                    float TienPhongHienTai = TinhTienPhong_2(HD.GioVao.ToString(),HD.GioRa.ToString());
                    int kq = 0;

                    kq = dl_hd.ChuyenPhong(HD, TienPhongHienTai);

                    kq = dl_hd.ChuyenPhong_UpDateTime(HD,maphong);
                    kq = dl.UpdateTrangThaiDatPhong(maphong);
                    kq = dl_hd.upDatePhong(HD.MaPhong.ToString());
                    HD.MaPhong = int.Parse(maphong);
                    LoadHoaDon(HD.MaPhong.ToString());
                    LoadCbbChuyenPhong();
                    if(kq==1)
                    {
                        MessageBox.Show("Chuyển phòng thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Chuyển phòng thất bại.");
                    }
                    LoadDS_Phong();
                }
                
            }
        }
    }
}

