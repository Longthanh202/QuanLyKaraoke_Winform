using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;
using Nhom01_CongNghe.Net.DTO;

namespace Nhom01_CongNghe.Net.DAO
{
    class dulieu
    {
        string strCon;
        SqlConnection Con;
        public dulieu()
        {
            strCon = @"Data Source=LEVI\SQLEXPRESS ;Initial Catalog=Ql_PHONGKARAOKE;Integrated Security=True";
            Con = new SqlConnection(strCon);
        }
        public DataTable LoadTaiKhoan(string tenDN)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select TENDANGNHAP,TENHIENTHI,MATKHAU from TAIKHOAN where TENDANGNHAP='" + tenDN + "';";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoadDanhMucSanPham()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select *from DANHMUCSANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoadSanPham(string MADANHMUCSP)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select MASP,TENSP, GIA, MADANHMUC,HINHANH, DVT, SOLUONG from SANPHAM where MADANHMUC = " + MADANHMUCSP + "; ";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int TaoHoaDon(string MaPhong, string tenkhach)
        {
            int kp = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "insert into HOADON(GIOVAO,MAPHONG,TRANGTHAI,TENKHACHHANG) values (GETDATE()," + MaPhong + ", 0, N'" + tenkhach + "'); ";
                SqlCommand cmd = new SqlCommand(select, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                kp = 1;
            }
            catch (Exception)
            {
                kp = 0;
            }
            return kp;
        }
        public int UpdateTrangThaiDatPhong(string maphong)
        {
            int kp = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string update = "update PHONG set TRANGTHAI = 1 where MAPHONG = " + maphong + "; ";
                SqlCommand cmd = new SqlCommand(update, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                kp = 1;
            }
            catch (Exception)
            {
                kp = 0;
            }
            return kp;
        }
        public DataSet LoadHoaDon()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select * from HOADON";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HOADON");
                Con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void XoaDuLieu_Dgv(DataSet ds, string TenBang, string KhoaChinh, string strSelect)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                DataRow dr = ds.Tables[TenBang].Rows.Find(KhoaChinh);
                if (dr != null)
                {
                    dr.Delete();
                }
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, TenBang);
                Con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("loi");
            }
        }
        public void LuuDataGridView(string strSelect, DataSet ds, string TenBang)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, TenBang);
                Con.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("loi");
            }
        }
        public DataTable TimHoaDonMoiNhat()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "SELECT MAX(MAHD) FROM HOADON";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable max = new DataTable();
                da.Fill(max);
                Con.Close();
                return max;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int InsertChiTietHD(string strInsert)
        {
            int kp = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(strInsert, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                kp = 1;
            }
            catch (Exception)
            {
                kp = 0;
            }
            return kp;
        }
        public int DeleteChiTietHD(string strDelete)
        {
            int kp = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(strDelete, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                kp = 1;
            }
            catch (Exception)
            {
                kp = 0;
            }
            return kp;
        }
        public DataSet LoadLoaiPhong()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select *from LOAIPHONG";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LOAIPHONG");
                Con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public DataTable LoadLoaiPhong_DT()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select *from LOAIPHONG";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public DataTable LoadPhong()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select *from PHONG";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //----------------form quan ly san pham
        public DataTable LoadDonViTinh()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string strSelect = "select DVT from SANPHAM group by(DVT);";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, Con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                Con.Close();
                return ds;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable LoadSanPham()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select *from SANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet LoadDanhMucSanPham_()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                string select = "select *from DANHMUCSANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(select, Con);
                DataSet dt = new DataSet();
                da.Fill(dt, "DANHMUCSANPHAM");
                Con.Close();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int ThemSanPham(SanPham s)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {

                int kq = 0;
                string strInsert = "insert into SANPHAM values(N'" + s.TenSanPham + "', " + s.Gia + ", " + s.MaDanhMuc + ", '" + s.HinhAnh + "', N'" + s.DonViTinh + "', '" + s.SoLuong + "')";
                SqlCommand cmd = new SqlCommand(strInsert, Con);
                kq = cmd.ExecuteNonQuery();
                //kq = 1;
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int SuaSanPham(SanPham s)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                int kq = 0;
                string strUpdate = "update SANPHAM set TENSP = N'" + s.TenSanPham + "',GIA = " + s.Gia + ",MADANHMUC = " + s.MaDanhMuc + "" +
                    ",HINHANH = '" + s.HinhAnh + "',DVT = N'" + s.DonViTinh + "' where MASP = " + s.MaSanPham + "; ";
                SqlCommand cmd = new SqlCommand(strUpdate, Con);
                kq = cmd.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int XoaSanPham(string s)
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            try
            {
                int kq = 0;
                string strDelete = "delete SANPHAM where MASP=" + s + "; ";
                SqlCommand cmd = new SqlCommand(strDelete, Con);
                kq = cmd.ExecuteNonQuery();
                Con.Close();
                return kq;
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
