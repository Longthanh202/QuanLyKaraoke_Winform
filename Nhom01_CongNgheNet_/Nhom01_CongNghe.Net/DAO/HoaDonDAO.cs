using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Nhom01_CongNghe.Net.DTO;

namespace Nhom01_CongNghe.Net.DAO
{
    public class HoaDonDAO
    {
        DBConnect conn = new DBConnect();
        public int LayHoaDonTuMaPhong(int maphong)
        {
            DataTable data = conn.ExecuteDataTable("select * from HOADON WHERE MAPHONG = " + maphong + "AND TRANGTHAI = 0");
            if(data.Rows.Count > 0)
            {
                HoaDon hd = new HoaDon(data.Rows[0]);
                return hd.MaHoaDon;
            }
            return -1;
        }
    }
}
