using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Nhom01_CongNghe.Net.DAO;
using Nhom01_CongNghe.Net.DTO;


namespace Nhom01_CongNghe.Net
{
    public partial class frmQLSanPham : Form
    {
        dulieu dl = new dulieu();
        List<SanPham> ds_SanPham = new List<SanPham>();
        List<SanPham> ds_SanPhamAdd = new List<SanPham>(); 
        List<SanPham> ds_SanPhamUpdate = new List<SanPham>();
        
        List<string> ds_SanPhamDelete = new List<string>();
        List<string> dsTenSP = new List<string>();
        SanPham sp_current = new SanPham();

        public frmQLSanPham()
        {
            InitializeComponent();
        }
        private void LoadCbb_DonViTinh()
        {
            DataTable tb_dvt= dl.LoadDonViTinh();
            if(tb_dvt!=null &&tb_dvt.Rows.Count>0)
            {
                cbb_DVT.Items.Clear();
                foreach(DataRow dr in tb_dvt.Rows)
                {
                    cbb_DVT.Items.Add(dr[0].ToString());
                }
            }
        }
        private void LoadCbb_DanhMucSanPham()
        {
            DataSet ds_DM = dl.LoadDanhMucSanPham_();
            if(ds_DM!=null)
            {
                cbb_DanhMucSanPham.DataSource = ds_DM.Tables["DANHMUCSANPHAM"];
                cbb_DanhMucSanPham.DisplayMember = "TENDANHMUC";
                cbb_DanhMucSanPham.ValueMember = "MADANHMUC";
            }
        }
        private void KhoiTaoImagesList()
        {
            image_list.Images.Clear();
            image_list = new ImageList() { ImageSize = new Size(180, 120) };
        }
        private void LoadSanPham()
        {
            DataTable tb_sanPham = dl.LoadSanPham();
            
            if (tb_sanPham.Rows.Count > 0 && tb_sanPham!=null)
            {
                foreach (DataRow dr in tb_sanPham.Rows)
                {
                    SanPham t = new SanPham();
                    t.MaSanPham = dr["MASP"].ToString();
                    t.TenSanPham = dr["TENSP"].ToString();
                    t.Gia = dr["GIA"].ToString();
                    t.MaDanhMuc = dr["MADANHMUC"].ToString();
                    t.HinhAnh = dr["HINHANH"].ToString();
                    t.DonViTinh = dr["DVT"].ToString();
                    t.SoLuong = int.Parse(dr["SOLUONG"].ToString());
                    ds_SanPham.Add(t);
                    dsTenSP.Add(t.TenSanPham);
                }


            }
        }

        private void Load_ListView()
        {
            lv_Sp.Items.Clear();
            KhoiTaoImagesList();
            int dem = 0;
            lv_Sp.SmallImageList = image_list;
            foreach (SanPham t in ds_SanPham)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = dem;
                item.SubItems.Add(t.MaSanPham);
                item.SubItems.Add(t.TenSanPham);
                item.SubItems.Add(t.Gia);
                item.SubItems.Add(t.MaDanhMuc);
                item.SubItems.Add(t.HinhAnh);
                item.SubItems.Add(t.DonViTinh);
                item.SubItems.Add(t.SoLuong.ToString());
                lv_Sp.Items.Add(item);
                dem++;
                image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + t.HinhAnh));
            }
        }

        private void Load_ListView(string MaDanhMuc)
        {
            KhoiTaoImagesList();
            lv_Sp.Items.Clear();
            int dem = 0;
            lv_Sp.SmallImageList = image_list;
            
            foreach (SanPham t in ds_SanPham)
            {
                if(t.MaDanhMuc==MaDanhMuc)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = dem;
                    item.SubItems.Add(t.MaSanPham);
                    item.SubItems.Add(t.TenSanPham);
                    item.SubItems.Add(t.Gia);
                    item.SubItems.Add(t.MaDanhMuc);
                    item.SubItems.Add(t.HinhAnh);
                    item.SubItems.Add(t.DonViTinh);
                    item.SubItems.Add(t.SoLuong.ToString());
                    lv_Sp.Items.Add(item);
                    
                    image_list.Images.Add(new Bitmap(Application.StartupPath + "\\sanpham\\" + t.HinhAnh));
                    dem++;
                }
            }
        }

        private void frmQLSanPham_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadCbb_DanhMucSanPham();
            LoadCbb_DonViTinh();
            Load_ListView();
        }

        private void cbb_DanhMucSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_DanhMucSanPham.SelectedIndex>=0)
            {
                Load_ListView(cbb_DanhMucSanPham.SelectedValue.ToString());
            }
        }

        private void lv_Sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_Sp.SelectedItems.Count==0)
            {
                return;
            }
            else
            {
                ListViewItem item = lv_Sp.SelectedItems[0];
                sp_current.MaSanPham= txtMaSP.Text = item.SubItems[1].Text;
                sp_current.TenSanPham=txtTenSP.Text = item.SubItems[2].Text;

                sp_current.Gia= txtGia.Text = item.SubItems[3].Text;
                
                sp_current.MaDanhMuc= txtMadanhMuc.Text = item.SubItems[4].Text;
                sp_current.HinhAnh= txtHinhAnh.Text = item.SubItems[5].Text;
                sp_current.DonViTinh=cbb_DVT.Text = item.SubItems[6].Text;
                sp_current.SoLuong = int.Parse(item.SubItems[7].Text);
                txtSoLuong.Text = sp_current.SoLuong.ToString();
                picture_item.Image = new Bitmap(Application.StartupPath + "\\sanpham\\" + txtHinhAnh.Text);

            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picture_item.Image = new Bitmap(openFileDialog1.FileName);
                string fileName = openFileDialog1.FileName;
                txtHinhAnh.Text = fileName.Substring(fileName.LastIndexOf("\\") + 1);
            }
        }

        private bool UpLoadFile(OpenFileDialog Upload)
        {
            try
            {
                string path = Application.StartupPath + "\\sanpham\\";
                string path_ = "..\\..\\Resources\\";
                path = path + txtHinhAnh.Text;
                path_ = path_ + txtHinhAnh.Text;
                if (!File.Exists(path_))
                    File.Copy(Upload.FileName, path_);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong debug\n " + path, "Thông báo");
                    return false;
                }
                if (!File.Exists(path))
                    File.Copy(Upload.FileName, path);
                else
                {
                    MessageBox.Show("Tập tin đã tồn tại trong resource\n" + path, "Thông báo");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private bool DeleteFile(string HinhAnh)
        {
            try
            {
                string path = Application.StartupPath + "\\HinhAnh\\";
                string path_ = "..\\..\\Resources\\";
                path = path + txtHinhAnh.Text;
                path_ = path_ + txtHinhAnh.Text;
                if (File.Exists(path_))
                    File.Delete(path_);
                else
                {
                    MessageBox.Show("Tập tin không tồn tại trong debug\n " + path_, "Thông báo");
                    return false;
                }
                if (!File.Exists(path))
                    File.Delete(path);
                else
                {
                    MessageBox.Show("Tập tin không tồn tại trong resource\n" + path, "Thông báo");
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        private void AddSanPham()
        {
            SanPham t = new SanPham();
            t.MaSanPham = txtMaSP.Text;
            t.TenSanPham = txtTenSP.Text;
            t.Gia = txtGia.Text;
            t.MaDanhMuc = txtMadanhMuc.Text;
            //t.DonViTinh = cbb_DVT.Text;
            if (cbb_DVT.SelectedIndex >= 0)
            {
                t.DonViTinh = (string)cbb_DVT.SelectedItem;
            }
            t.HinhAnh = txtHinhAnh.Text;
            t.SoLuong = int.Parse(txtSoLuong.Text);
            if (!dsTenSP.Contains(t.TenSanPham))
            {
                ds_SanPhamAdd.Add(t);
            }
            else
            {
                MessageBox.Show("Sản phẩm đã tồn tại ");
                //return;
            }
            if (sp_current.HinhAnh != t.HinhAnh)
            {
                if (txtHinhAnh.Text != null || txtHinhAnh.Text != "" && picture_item.Image != null)
                {
                    if (UpLoadFile(openFileDialog1))
                    {
                        MessageBox.Show("Upload Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Upload That bai");
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtTenSP.Text == "" && txtGia.Text == "" && txtMadanhMuc.Text == "" && txtHinhAnh.Text == "" && txtSoLuong.Text == "")
            //{
            //    MessageBox.Show("Hãy nhập đầy đủ các trường!");
            //}
            //else
            //{
                AddSanPham();
                foreach (SanPham t in ds_SanPhamAdd)
                {
                    if (!ds_SanPham.Contains(t))
                    {
                        ds_SanPham.Add(t);
                    }
                }
                Load_ListView(); 
          }
        //}

        private void UpdateSanPham()
        {
            SanPham t = new SanPham();
            t.MaSanPham = txtMaSP.Text;
            t.TenSanPham = txtTenSP.Text;
            t.Gia = txtGia.Text;
            t.MaDanhMuc = txtMadanhMuc.Text;
            if (cbb_DVT.SelectedIndex >= 0)
            {
                t.DonViTinh = (string)cbb_DVT.SelectedItem;
            }
            t.HinhAnh = txtHinhAnh.Text;
            t.SoLuong = int.Parse(txtSoLuong.Text);
            if(sp_current.HinhAnh!=t.HinhAnh)
            {
                if (txtHinhAnh.Text != null || txtHinhAnh.Text != "" && picture_item.Image != null)
                {
                    if (UpLoadFile(openFileDialog1))
                    {
                        MessageBox.Show("Upload Thành công");
                    }
                    else
                    {
                        MessageBox.Show("Upload That bai");
                    }
                }
            }
            ds_SanPhamUpdate.Add(t);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateSanPham();
            foreach (SanPham t_current in ds_SanPham)
            {
                foreach (SanPham t_apter in ds_SanPhamUpdate)
                {
                    if (t_current.MaSanPham == t_apter.MaSanPham)
                    {
                        t_current.TenSanPham = t_apter.TenSanPham;
                        t_current.Gia = t_apter.Gia;
                        t_current.MaDanhMuc = t_apter.MaDanhMuc;
                        t_current.HinhAnh = t_apter.HinhAnh;
                        t_current.HinhAnh = t_apter.HinhAnh;
                        t_current.DonViTinh = t_apter.DonViTinh;
                        t_current.SoLuong = t_apter.SoLuong;
                        MessageBox.Show("Sửa thành công");
                    }
                }
            }
            Load_ListView();
        }
        private void Delete_SanPham()
        {
            string MaSanPham = txtMaSP.Text;
            ds_SanPhamDelete.Add(MaSanPham);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int flag = 0;
            Delete_SanPham();
            foreach (SanPham t in ds_SanPham)
            {
                foreach(string maSp in ds_SanPhamDelete)
                {
                    if(t.MaSanPham==maSp)
                    {
                        ds_SanPham.Remove(t);
                        DeleteFile(t.HinhAnh);
                        MessageBox.Show("Xóa thành công.");
                        flag = 1;
                        if(flag==1)
                        {
                            Load_ListView();
                            return;
                        }
                    }
                }
            }
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int dem = 0;
            if(ds_SanPhamAdd.Count>0)
            {
                foreach(SanPham s in ds_SanPhamAdd)
                {
                    int kq = dl.ThemSanPham(s);
                    if(kq==0)
                    {
                        MessageBox.Show("Thêm thất bại.");
                        dem++;
                    }
                    else if (kq == -1)
                    {
                        MessageBox.Show("Lỗi:" + kq.ToString());
                        dem++;
                    }
                }
            }
            if (ds_SanPhamUpdate.Count > 0)
            {
                foreach (SanPham s in ds_SanPhamUpdate)
                {
                    int kq = dl.SuaSanPham(s);
                    if (kq == 0)
                    {
                        MessageBox.Show("Sữa thất bại.");
                        dem++;
                    }
                    else if(kq==-1)
                    {
                        MessageBox.Show("Lỗi:"+ kq.ToString());
                        dem++;
                    }
                }
            }
            if (ds_SanPhamDelete.Count > 0)
            {
                foreach (string s in ds_SanPhamDelete)
                {
                    int kq = dl.XoaSanPham(s);
                    if (kq == 0)
                    {
                        MessageBox.Show("Sữa thất bại.");
                        dem++;
                    }
                    else if (kq == -1)
                    {
                        MessageBox.Show("Lỗi:" + kq.ToString());
                        dem++;
                    }
                }
            }
            if(dem==0)
            {
                MessageBox.Show("Hoàn tất");
            }
        }

        private string ChuanHoaGia_In(string s)
        {
            string gia1 = "";
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] != '.')
                {
                    gia1 += s[i];
                }
            }
            return gia1;
        }
    }
}
