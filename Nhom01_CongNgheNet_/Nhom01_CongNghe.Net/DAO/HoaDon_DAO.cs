using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Nhom01_CongNghe.Net.DTO;

namespace Nhom01_CongNghe.Net.DAO
{
    class HoaDon_DAO
    {
        string strCon;
        SqlConnection Con;
        public HoaDon_DAO()
        {
            strCon = @"Data Source=LEVI\SQLEXPRESS;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True";
            Con = new SqlConnection(strCon);
        }
        public DataTable ChiTietHoaDon(string MaHD)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select ct.MAHD,ct.MASP,sp.TENSP,ct.SOLUONG,ct.DONGIA,ct.THANHTIEN " +
                                " from CHITIETHOADON ct, SANPHAM sp " +
                                " where ct.MASP = sp.MASP and ct.MAHD = " + MaHD + ";";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable HoaDon(string MaPhong)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select * from HOADON where MAPHONG=" + MaPhong + " and TRANGTHAI=0";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int ThemGioRa(string maHD)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            int kq = 0;
            try
            {
                string strUpDate = "update HOADON set GIORA = GETDATE() where MAHD = " + maHD + ";";
                SqlCommand cmd = new SqlCommand(strUpDate, Con);
                kq = cmd.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return kq;
            }

        }
        public DataTable LoadLoaiPhong(string maphong)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select  LOAIPHONG from PHONG where MAPHONG=" + maphong + "; ";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public DataSet Load_CbbChuyenPhong()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select MAPHONG, TENPHONG from PHONG where TRANGTHAI=0;";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataSet dt = new DataSet();
                da.Fill(dt, "CbbPhong");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int ChuyenPhong_UpDateTime(HoaDon h, string maPhong)
        {
            int kq = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                string strUpdate = "update HOADON set GIOVAO = GETDATE(), GIORA = NULL, MAPHONG=" + maPhong + " where MAHD = " + h.MaHoaDon + "; ";
                SqlCommand cmd1 = new SqlCommand(strUpdate, Con);
                kq = cmd1.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int ChuyenPhong(HoaDon h, float tienPhong)
        {
            int kq = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                string strInsert = "insert into HOADONPHU values('" + h.MaHoaDon + "', '" + h.GioVao + "'," +
                    " '" + h.GioRa + "', '" + h.MaPhong + "'," + tienPhong + ")";
                SqlCommand cmd = new SqlCommand(strInsert, Con);
                kq = cmd.ExecuteNonQuery();

                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public DataTable HoaDonPhu(string maHD)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select *from HOADONPHU where MAHD=" + maHD + " ;";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoaiPhong()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select  * from LOAIPHONG ";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int upDateHoaDon(HoaDon hd)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            int kq = 0;
            try
            {
                string strUpDate = "update HOADON set TRANGTHAI = 1, TONGTIEN = " + hd.TongTien + "," +
                    "TIENPHONG=" + hd.TienPhong + ", TIENDICHVU=" + hd.TienDichVu + " where MAHD = " + hd.MaHoaDon + "; ";
                SqlCommand cmd = new SqlCommand(strUpDate, Con);
                kq = cmd.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return kq;
            }
        }
        public int upDatePhong(string maPhong)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            int kq = 0;
            try
            {
                string strUpDate = "update PHONG set TRANGTHAI = 0 where MAPHONG = " + maPhong + "; ";
                SqlCommand cmd = new SqlCommand(strUpDate, Con);
                kq = cmd.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return kq;
            }
        }
    }
}
