using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nhom01_CongNghe.Net.DTO;
using System.Data;

namespace Nhom01_CongNghe.Net.DAO
{
    class CTHD_DAO
    {
        DBConnect conn = new DBConnect();
        public List<ChiTietHoaDon> LayDS_CTHD(int mahd, int masp)
        {
            List<ChiTietHoaDon> lstCTHD = new List<ChiTietHoaDon>();
            DataTable data = conn.ExecuteDataTable("select * from CHITIETHOADON where MAHD = " + mahd + "AND MASP = " + masp);
            foreach(DataRow item in data.Rows)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon(item);
                lstCTHD.Add(cthd);
            }
            return lstCTHD;
        }
    }
}
