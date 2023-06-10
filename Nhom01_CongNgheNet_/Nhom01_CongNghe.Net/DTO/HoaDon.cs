using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class HoaDon
    {
        private int maHoaDon, trangThai, maPhong;
        string tenKhachHang;
        float tienPhong, tienDichVu;
        public float TienPhong
        {
            get { return tienPhong; }
            set { tienPhong = value; }
        }
        public float TienDichVu
        {
            get { return tienDichVu; }
            set { tienDichVu = value; }
        }
        public float TongTien
        {
            get { return TienPhong + TienDichVu; }
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

        public int MaHoaDon
        {
            get { return maHoaDon; }
            set { maHoaDon = value; }
        }
        public string TenKhachHang
        {
            get { return tenKhachHang; }
            set { tenKhachHang = value; }
        }
        DateTime? gioVao;

        public DateTime? GioVao
        {
            get { return gioVao; }
            set { gioVao = value; }
        }
        DateTime? gioRa;

        public DateTime? GioRa
        {
            get { return gioRa; }
            set { gioRa = value; }
        }
        public HoaDon()
        {
            
            MaHoaDon = TrangThai = MaPhong = 0;
            GioVao = GioRa = null/*new DateTime(01/01/1900)*/;
            TenKhachHang = "";
            TienDichVu = 0;
            TienPhong = 0;
        }
        public HoaDon(int mahd, DateTime? giovao, DateTime? giora, int trangthai, int maphong,string tenKH,float tienphong, float tiendichvu)
        {
            this.MaHoaDon = mahd;
            this.GioVao = giovao;
            this.GioRa = giora;
            this.TrangThai = trangthai;
            this.MaPhong = maphong;
            this.TenKhachHang = tenKH;
            this.TienPhong = tienphong;
            this.TienDichVu = tiendichvu;
        }
        public HoaDon(DataRow row)
        {
            this.MaHoaDon = (int)row["MAHD"];
            this.GioVao = (DateTime?)row["GIOVAO"];
            this.GioRa = (DateTime?)row["GIORA"];
            this.TrangThai = (int)row["TRANGTHAI"];
        }
    }
}
