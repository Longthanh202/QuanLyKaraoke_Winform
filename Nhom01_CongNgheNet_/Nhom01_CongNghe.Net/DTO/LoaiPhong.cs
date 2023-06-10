using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class LoaiPhong
    {
        public string MaLoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public string DonGia { get; set; }
        public LoaiPhong()
        {
            MaLoaiPhong = TenLoaiPhong = DonGia = "";

        }
        public LoaiPhong(string maloaiphong,string tenloaiphong,string dongia)
        {
            MaLoaiPhong = maloaiphong;TenLoaiPhong = tenloaiphong;DonGia = dongia;
        }
    }
}
