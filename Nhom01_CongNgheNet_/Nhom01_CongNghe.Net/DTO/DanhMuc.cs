using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom01_CongNghe.Net.DTO
{
    class DanhMuc
    {
        private int maDanhMuc;

        public int MaDanhMuc
        {
            get { return maDanhMuc; }
            set { maDanhMuc = value; }
        }
        private string tenDanhMuc;

        public string TenDanhMuc
        {
            get { return tenDanhMuc; }
            set { tenDanhMuc = value; }
        }
        public DanhMuc(int madanhmuc, string tendanhmuc)
        {
            this.MaDanhMuc = madanhmuc;
            this.TenDanhMuc = TenDanhMuc;
        }       
    }
}
