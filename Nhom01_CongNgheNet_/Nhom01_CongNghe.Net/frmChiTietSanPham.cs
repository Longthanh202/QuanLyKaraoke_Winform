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

namespace Nhom01_CongNghe.Net
{
    public partial class frmChiTietSanPham : Form
    {
        public delegate void TruyenSanPham(string MaSanPham, string TenSanPham, string Gia, string MaDanhMuc, string HinhAnh, string DVT, string SoLuong);
        public TruyenSanPham Gui_SanPhan;
        public delegate void TruyenPhong(string SoHD);
        public TruyenPhong Gui_phong;

        public delegate void TruyenDon(int mahoadon,int masp,int sl,float dongia, string tenSP);
        public TruyenDon GuiDonDat;
        public TruyenDon GuiDonHuy;
        DAO.dulieu dl = new DAO.dulieu();
        public frmChiTietSanPham()
        {
            InitializeComponent();
            Gui_SanPhan = new TruyenSanPham(LoadSanPham);
            Gui_phong = new TruyenPhong(LoadMaHD);
            
        }
        DTO.SanPham sp = new DTO.SanPham();
        DTO.ChiTietHoaDon hd = new DTO.ChiTietHoaDon();
        string SoHD;
        public void LoadMaHD(string SoHD)
        {
            this.SoHD = SoHD;
        }
        private void setmunberUpDown(NumericUpDown nb, int max)
        {
            nb.Maximum = max;
            if(nb.Value>max)
            {
                nb.Value = max;
            }
        }
        public void LoadSanPham(string MaSanPham, string TenSanPham, string Gia, string MaDanhMuc, string HinhAnh, string DVT, string SoLuong)
        {
            sp.MaSanPham = MaSanPham;
            sp.MaDanhMuc = MaDanhMuc;
            sp.Gia = Gia;
            sp.HinhAnh = HinhAnh;
            sp.DonViTinh = DVT;
            sp.TenSanPham = TenSanPham;
            sp.SoLuong = int.Parse(SoLuong);
            setmunberUpDown(numericUpDown1, sp.SoLuong);
        }
        //private string CatNganGia(string Gia)
        //{
        //    string gia = "";
        //    for(int i=0;i<Gia.Length-4;i++)
        //    {
        //        gia += Gia[i];
        //    }
        //    return gia;
        //}
        private string ChuanHoaGia(string Gia)
        {
            //string gia = "";
            string gia1 = "";
            //for (int i = 0; i < Gia.Length - 1; i++)
            //{
            //    if(Gia[i]=='.')
            //    {
            //        break;
            //    }
            //    gia += Gia[i];
            //}
            Stack giaChuanHoa = new Stack();
            int dem = 0;
            for(int i=Gia.Length-1;i>=0;i--)
            {
                if(dem<3)
                {
                    giaChuanHoa.Push(Gia[i]);
                    dem++;
                }
                else
                {
                    giaChuanHoa.Push(".");
                    giaChuanHoa.Push(Gia[i]);
                    dem = 0;
                }
            }
            while(giaChuanHoa.Count !=0)
            {
                gia1 += giaChuanHoa.Pop();
            }
            return gia1;
        }

        public void LoadChiTietHD()
        {
            hd.MaHD = int.Parse(SoHD) ;
            hd.MaSP = int.Parse(sp.MaSanPham);
            hd.Sl = int.Parse(numericUpDown1.Value.ToString());
            hd.DonGia = float.Parse(sp.Gia);
        }
        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            if(numericUpDown1.Value==0)
            {
                btnDat.Enabled = false;
            }
            else
            {
                btnDat.Enabled = true;
            }
            lblDVT.Text = sp.DonViTinh;
            lblGia.Text = ChuanHoaGia(sp.Gia);
            lblTen.Text = sp.TenSanPham;
            lblSLT.Text = sp.SoLuong.ToString();
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\sanpham\\" + sp.HinhAnh);
        }


        private void btnDat_Click(object sender, EventArgs e)
        {
            LoadChiTietHD();
            GuiDonDat(hd.MaHD, hd.MaSP, hd.Sl, hd.DonGia, sp.TenSanPham);
            btnHuy.Visible = true;
            btnDat.Visible = false;
            numericUpDown1.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadChiTietHD();
            GuiDonHuy(hd.MaHD, hd.MaSP, hd.Sl, hd.DonGia, sp.TenSanPham);
            btnHuy.Visible = false;
            btnDat.Visible = true;
            numericUpDown1.Enabled = true;
            numericUpDown1.Value = 0;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                btnDat.Enabled = false;
            }
            else
            {
                btnDat.Enabled = true;
            }
        }
    }
}
