using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class ChiTietDatMon
    {
        int maSP;
        string tenSP;
        int soLuong;
        public int MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }
        public string TenSP
        {
            get { return tenSP; }
            set { tenSP = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public ChiTietDatMon()
        {
            MaSP = SoLuong = 0;
            TenSP = "";
        }
        public ChiTietDatMon(int masp, string tensp,int soluong)
        {
            MaSP = masp;
            TenSP = tensp;
            SoLuong = soluong;
        }
    }
}
