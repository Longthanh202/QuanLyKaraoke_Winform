
namespace Nhom01_CongNghe.Net
{
    partial class frmQLSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTenHDV = new System.Windows.Forms.Label();
            this.col_picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DVT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_TenHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaDanhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_MaHDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_maTour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.image_list = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbb_DVT = new System.Windows.Forms.ComboBox();
            this.cbb_DanhMucSanPham = new System.Windows.Forms.ComboBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.lv_Sp = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.picture_item = new System.Windows.Forms.PictureBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMadanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgayVaoLam = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLoaiHDV = new System.Windows.Forms.Label();
            this.lblMaHDV = new System.Windows.Forms.Label();
            this.col_SOLUONG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_item)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenHDV
            // 
            this.lblTenHDV.AutoSize = true;
            this.lblTenHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenHDV.ForeColor = System.Drawing.Color.Black;
            this.lblTenHDV.Location = new System.Drawing.Point(258, 36);
            this.lblTenHDV.Name = "lblTenHDV";
            this.lblTenHDV.Size = new System.Drawing.Size(125, 23);
            this.lblTenHDV.TabIndex = 0;
            this.lblTenHDV.Text = "Tên sản phẩm";
            // 
            // col_picture
            // 
            this.col_picture.Text = "Picture";
            this.col_picture.Width = 140;
            // 
            // col_DVT
            // 
            this.col_DVT.Text = "Đơn vị tính";
            this.col_DVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_DVT.Width = 163;
            // 
            // col_TenHinh
            // 
            this.col_TenHinh.Text = "Tên hình";
            this.col_TenHinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_TenHinh.Width = 144;
            // 
            // col_MaDanhMuc
            // 
            this.col_MaDanhMuc.Text = "Mã danh mục";
            this.col_MaDanhMuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_MaDanhMuc.Width = 171;
            // 
            // col_Gia
            // 
            this.col_Gia.Text = "Giá";
            this.col_Gia.Width = 214;
            // 
            // col_MaHDV
            // 
            this.col_MaHDV.Text = "Tên sản ";
            this.col_MaHDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_MaHDV.Width = 98;
            // 
            // col_maTour
            // 
            this.col_maTour.Text = "Mã sản phẩm";
            this.col_maTour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_maTour.Width = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(592, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá";
            // 
            // image_list
            // 
            this.image_list.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.image_list.ImageSize = new System.Drawing.Size(16, 16);
            this.image_list.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 64);
            this.panel2.TabIndex = 12;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnXoa.Location = new System.Drawing.Point(1059, 10);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 43);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.BackColor = System.Drawing.Color.Red;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSua.Location = new System.Drawing.Point(882, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 43);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLuu.BackColor = System.Drawing.Color.Blue;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLuu.Location = new System.Drawing.Point(528, 10);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 43);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.BackColor = System.Drawing.Color.Red;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnThem.Location = new System.Drawing.Point(705, 10);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbb_DVT
            // 
            this.cbb_DVT.BackColor = System.Drawing.Color.White;
            this.cbb_DVT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_DVT.ForeColor = System.Drawing.Color.Black;
            this.cbb_DVT.FormattingEnabled = true;
            this.cbb_DVT.Location = new System.Drawing.Point(262, 131);
            this.cbb_DVT.Name = "cbb_DVT";
            this.cbb_DVT.Size = new System.Drawing.Size(298, 31);
            this.cbb_DVT.TabIndex = 2;
            // 
            // cbb_DanhMucSanPham
            // 
            this.cbb_DanhMucSanPham.BackColor = System.Drawing.Color.White;
            this.cbb_DanhMucSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbb_DanhMucSanPham.ForeColor = System.Drawing.Color.Black;
            this.cbb_DanhMucSanPham.FormattingEnabled = true;
            this.cbb_DanhMucSanPham.Location = new System.Drawing.Point(154, 202);
            this.cbb_DanhMucSanPham.Name = "cbb_DanhMucSanPham";
            this.cbb_DanhMucSanPham.Size = new System.Drawing.Size(339, 31);
            this.cbb_DanhMucSanPham.TabIndex = 2;
            this.cbb_DanhMucSanPham.SelectedIndexChanged += new System.EventHandler(this.cbb_DanhMucSanPham_SelectedIndexChanged);
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.BackColor = System.Drawing.Color.White;
            this.txtHinhAnh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtHinhAnh.ForeColor = System.Drawing.Color.Black;
            this.txtHinhAnh.Location = new System.Drawing.Point(959, 184);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(267, 30);
            this.txtHinhAnh.TabIndex = 1;
            // 
            // lv_Sp
            // 
            this.lv_Sp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Sp.BackColor = System.Drawing.Color.White;
            this.lv_Sp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_picture,
            this.col_maTour,
            this.col_MaHDV,
            this.col_Gia,
            this.col_MaDanhMuc,
            this.col_TenHinh,
            this.col_DVT,
            this.col_SOLUONG});
            this.lv_Sp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lv_Sp.ForeColor = System.Drawing.Color.Black;
            this.lv_Sp.FullRowSelect = true;
            this.lv_Sp.GridLines = true;
            this.lv_Sp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Sp.HideSelection = false;
            this.lv_Sp.LabelWrap = false;
            this.lv_Sp.Location = new System.Drawing.Point(6, 240);
            this.lv_Sp.MaximumSize = new System.Drawing.Size(1800, 800);
            this.lv_Sp.Name = "lv_Sp";
            this.lv_Sp.Size = new System.Drawing.Size(1221, 353);
            this.lv_Sp.TabIndex = 11;
            this.lv_Sp.UseCompatibleStateImageBehavior = false;
            this.lv_Sp.View = System.Windows.Forms.View.Details;
            this.lv_Sp.SelectedIndexChanged += new System.EventHandler(this.lv_Sp_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnOpenFile);
            this.panel3.Controls.Add(this.picture_item);
            this.panel3.Controls.Add(this.cbb_DVT);
            this.panel3.Controls.Add(this.cbb_DanhMucSanPham);
            this.panel3.Controls.Add(this.txtHinhAnh);
            this.panel3.Controls.Add(this.txtTenSP);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.txtGia);
            this.panel3.Controls.Add(this.txtMadanhMuc);
            this.panel3.Controls.Add(this.txtMaSP);
            this.panel3.Controls.Add(this.lblGioiTinh);
            this.panel3.Controls.Add(this.lblNgayVaoLam);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblSDT);
            this.panel3.Controls.Add(this.lblLoaiHDV);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblTenHDV);
            this.panel3.Controls.Add(this.lblMaHDV);
            this.panel3.Location = new System.Drawing.Point(2, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 233);
            this.panel3.TabIndex = 13;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::Nhom01_CongNghe.Net.Properties.Resources.icon_file;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpenFile.Location = new System.Drawing.Point(885, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(56, 47);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // picture_item
            // 
            this.picture_item.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_item.Location = new System.Drawing.Point(959, 10);
            this.picture_item.Name = "picture_item";
            this.picture_item.Size = new System.Drawing.Size(267, 172);
            this.picture_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_item.TabIndex = 4;
            this.picture_item.TabStop = false;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.Color.White;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(262, 63);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(298, 30);
            this.txtTenSP.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.Location = new System.Drawing.Point(596, 73);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(250, 30);
            this.txtGia.TabIndex = 1;
            // 
            // txtMadanhMuc
            // 
            this.txtMadanhMuc.BackColor = System.Drawing.Color.White;
            this.txtMadanhMuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMadanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtMadanhMuc.Location = new System.Drawing.Point(57, 131);
            this.txtMadanhMuc.Name = "txtMadanhMuc";
            this.txtMadanhMuc.Size = new System.Drawing.Size(172, 30);
            this.txtMadanhMuc.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.Color.White;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(57, 63);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(172, 30);
            this.txtMaSP.TabIndex = 1;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGioiTinh.Location = new System.Drawing.Point(1920, 46);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(92, 23);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "Loại Tour";
            // 
            // lblNgayVaoLam
            // 
            this.lblNgayVaoLam.AutoSize = true;
            this.lblNgayVaoLam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayVaoLam.ForeColor = System.Drawing.Color.Black;
            this.lblNgayVaoLam.Location = new System.Drawing.Point(258, 105);
            this.lblNgayVaoLam.Name = "lblNgayVaoLam";
            this.lblNgayVaoLam.Size = new System.Drawing.Size(103, 23);
            this.lblNgayVaoLam.TabIndex = 0;
            this.lblNgayVaoLam.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lọc sản phẩm:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSDT.ForeColor = System.Drawing.Color.Black;
            this.lblSDT.Location = new System.Drawing.Point(53, 105);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(176, 23);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Danh mục sản phẩm";
            // 
            // lblLoaiHDV
            // 
            this.lblLoaiHDV.AutoSize = true;
            this.lblLoaiHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLoaiHDV.ForeColor = System.Drawing.Color.Black;
            this.lblLoaiHDV.Location = new System.Drawing.Point(861, 187);
            this.lblLoaiHDV.Name = "lblLoaiHDV";
            this.lblLoaiHDV.Size = new System.Drawing.Size(93, 23);
            this.lblLoaiHDV.TabIndex = 0;
            this.lblLoaiHDV.Text = "Hình ảnh:";
            // 
            // lblMaHDV
            // 
            this.lblMaHDV.AutoSize = true;
            this.lblMaHDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMaHDV.Location = new System.Drawing.Point(2012, 46);
            this.lblMaHDV.Name = "lblMaHDV";
            this.lblMaHDV.Size = new System.Drawing.Size(82, 23);
            this.lblMaHDV.TabIndex = 0;
            this.lblMaHDV.Text = "Mã Tour";
            // 
            // col_SOLUONG
            // 
            this.col_SOLUONG.Text = "Số lượng";
            this.col_SOLUONG.Width = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(592, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(596, 131);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(250, 30);
            this.txtSoLuong.TabIndex = 1;
            // 
            // frmQLSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1239, 691);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lv_Sp);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLSanPham";
            this.Text = "frmQLSanPham";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenHDV;
        private System.Windows.Forms.ColumnHeader col_picture;
        private System.Windows.Forms.ColumnHeader col_DVT;
        private System.Windows.Forms.ColumnHeader col_TenHinh;
        private System.Windows.Forms.ColumnHeader col_MaDanhMuc;
        private System.Windows.Forms.ColumnHeader col_Gia;
        private System.Windows.Forms.ColumnHeader col_MaHDV;
        private System.Windows.Forms.ColumnHeader col_maTour;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.PictureBox picture_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList image_list;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbb_DVT;
        private System.Windows.Forms.ComboBox cbb_DanhMucSanPham;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.ListView lv_Sp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLoaiHDV;
        private System.Windows.Forms.Label lblMaHDV;
        private System.Windows.Forms.TextBox txtMadanhMuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader col_SOLUONG;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
    }
}