using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class TaiKhoan
    {
        public string LoaiTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string TenHienThi { get; set; }
        public string MatKhau { get; set; }
        public TaiKhoan()
        {
            TenDangNhap = TenHienThi = MatKhau =LoaiTaiKhoan= "";
        }
        public TaiKhoan(string tendangnhap,string tenhienthi,string matkhau,string loaitaikhoan)
        {
            TenDangNhap = tendangnhap;
            TenHienThi = tenhienthi;
            MatKhau = matkhau;
            LoaiTaiKhoan = loaitaikhoan;
        }

    }
}
