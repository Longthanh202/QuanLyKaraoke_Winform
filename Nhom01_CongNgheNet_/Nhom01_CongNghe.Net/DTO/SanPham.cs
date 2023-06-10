using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace Nhom01_CongNghe.Net.DTO
{
    class SanPham
    {
        private string maSanPham, maDanhMuc;

        public string MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }

        public string MaSanPham
        {
            get { return maSanPham; }
            set { maSanPham = value; }
        }
        private string tenSanPham, donViTinh,hinhAnh;

        public string TenSanPham
        {
            get { return tenSanPham; }
            set { tenSanPham = value; }
        }
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }
        private string gia;

        private int soLuong;
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string Gia
        {
            get { return gia; }
            set 
            {
                gia = value; 
            }
        }

        public SanPham()
        {
            MaDanhMuc = MaSanPham =TenSanPham = DonViTinh = HinhAnh =Gia= "";
            SoLuong = 0;
        }
        public SanPham(string MaSanPham, string TenSanPham, string Gia, string MaDanhMuc, string HinhAnh, string DVT,int SoLuong)
        {
            this.MaSanPham = MaSanPham;
            this.TenSanPham = TenSanPham;
            this.Gia = Gia;
            this.MaDanhMuc = MaDanhMuc;
            this.DonViTinh = DVT;
            this.HinhAnh = HinhAnh;
            this.SoLuong = SoLuong;
        }
        private string ChuanHoaGia_In(string s)
        {
            string gia1 = "";
            for(int i=0;i<s.Length-1;i++)
            {
                if(s[i]!='.')
                {

                    gia1 += s[i];
                }
                else
                {
                    return gia1;
                }
            }
            return gia1;
        }
    }
}
