using Nhom01_CongNghe.Net.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Nhom01_CongNghe.Net.DAO
{
    class PhongDAO
    {
        DBConnect conn = new DBConnect();
        public List<Phong> LoadDanhSachPhong()
        {
            List<Phong> DSPhong = new List<Phong>();
            DataTable data = conn.ExecuteDataTable("select *from PHONG where TRANGTHAI <>3");
            foreach(DataRow item in data.Rows)
            {
                Phong p = new Phong(item);
                DSPhong.Add(p);
            }
            return DSPhong;
        }
    }
}
