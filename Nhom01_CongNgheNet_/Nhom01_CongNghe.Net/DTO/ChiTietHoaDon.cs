using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class ChiTietHoaDon
    {
        private int maHD, maSP, sl;

        public int Sl
        {
            get { return sl; }
            set { sl = value; }
        }

        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        public int MaHD
        {
            get { return maHD; }
            set { maHD = value; }
        }
        private float donGia, thanhTien;

        public float ThanhTien
        {
            get { return Sl*DonGia; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public ChiTietHoaDon(int mahd, int masp, int sl, float dongia)
        {
            this.MaHD = mahd;
            this.MaSP = masp;
            this.Sl = sl;
            this.DonGia = dongia;
        }
        public ChiTietHoaDon()
        {
            MaHD = maSP = Sl = 0;
            DonGia = 0f;
        }
        public ChiTietHoaDon(DataRow row)
        {
            this.MaHD = (int)row["MAHD"];
            this.MaSP = (int)row["MASP"];
            this.Sl = (int)row["SOLUONG"];
            this.DonGia = (float)row["DONGIA"];
        }
    }
}
