using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class Phong
    {
        private int maPhong, trangThai, maLoaiPhong;

        public int MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public int MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private string tenPhong;

        public string TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        public Phong()
        {
            MaPhong = 0;
            TenPhong = "";
            TrangThai = 0;
            MaLoaiPhong = 0;
        }
        public Phong (int maphong, string tenphong, int trangthai, int maloaiphong)
        {
            this.MaPhong = maphong;
            this.TenPhong = tenPhong;
            this.TrangThai = trangthai;
            this.MaLoaiPhong = maloaiphong;
        }
        public Phong(DataRow row)
        {
            this.MaPhong = (int)row["MAPHONG"];
            this.TenPhong = row["TENPHONG"].ToString();
            this.TrangThai = (int)row["TRANGTHAI"];
            this.MaLoaiPhong = (int)row["LOAIPHONG"];
        }
    }
}
