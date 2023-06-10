
namespace Nhom01_CongNghe.Net
{
    partial class frmOder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbHD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtChitietDatmon = new System.Windows.Forms.TextBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btn_GioiThieuPhong = new System.Windows.Forms.Button();
            this.pn_gioiThieu = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_dongGioiThieu = new System.Windows.Forms.Button();
            this.pn_gioiThieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPhong
            // 
            this.flpPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpPhong.AutoScroll = true;
            this.flpPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.flpPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpPhong.Location = new System.Drawing.Point(1169, 204);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(643, 556);
            this.flpPhong.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(12, 134);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 626);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(8, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Chi tiết đặt món:";
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDatPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDatPhong.Location = new System.Drawing.Point(1383, 169);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(163, 37);
            this.btnDatPhong.TabIndex = 28;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenPhong.Enabled = false;
            this.txtTenPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.Location = new System.Drawing.Point(1207, 175);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(168, 27);
            this.txtTenPhong.TabIndex = 29;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(1170, 175);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(38, 27);
            this.txtMaPhong.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(157, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "|Hóa đơn:";
            // 
            // cbbHD
            // 
            this.cbbHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbHD.ForeColor = System.Drawing.Color.Red;
            this.cbbHD.FormattingEnabled = true;
            this.cbbHD.Location = new System.Drawing.Point(241, 44);
            this.cbbHD.Name = "cbbHD";
            this.cbbHD.Size = new System.Drawing.Size(151, 31);
            this.cbbHD.TabIndex = 30;
            this.cbbHD.SelectedIndexChanged += new System.EventHandler(this.cbbHD_SelectedIndexChanged);
            this.cbbHD.Click += new System.EventHandler(this.cbbHD_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1162, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mời nhập tên khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhachHang.Location = new System.Drawing.Point(1383, 134);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(339, 27);
            this.txtTenKhachHang.TabIndex = 29;
            // 
            // txtChitietDatmon
            // 
            this.txtChitietDatmon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChitietDatmon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtChitietDatmon.Location = new System.Drawing.Point(166, 86);
            this.txtChitietDatmon.Name = "txtChitietDatmon";
            this.txtChitietDatmon.Size = new System.Drawing.Size(951, 27);
            this.txtChitietDatmon.TabIndex = 29;
            // 
            // btnback
            // 
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnback.BackColor = System.Drawing.Color.Blue;
            this.btnback.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnback.ForeColor = System.Drawing.Color.White;
            this.btnback.Location = new System.Drawing.Point(12, 33);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 45);
            this.btnback.TabIndex = 31;
            this.btnback.Text = "Quay lại";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXacNhan.BackColor = System.Drawing.Color.Red;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXacNhan.Location = new System.Drawing.Point(180, 776);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(687, 40);
            this.btnXacNhan.TabIndex = 32;
            this.btnXacNhan.Text = "<<Xác nhận đặt mua>>";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btn_GioiThieuPhong
            // 
            this.btn_GioiThieuPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_GioiThieuPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_GioiThieuPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_GioiThieuPhong.ForeColor = System.Drawing.Color.Red;
            this.btn_GioiThieuPhong.Location = new System.Drawing.Point(1655, 12);
            this.btn_GioiThieuPhong.Name = "btn_GioiThieuPhong";
            this.btn_GioiThieuPhong.Size = new System.Drawing.Size(175, 45);
            this.btn_GioiThieuPhong.TabIndex = 31;
            this.btn_GioiThieuPhong.Text = "!!Giới thiệu!!";
            this.btn_GioiThieuPhong.UseVisualStyleBackColor = false;
            this.btn_GioiThieuPhong.Click += new System.EventHandler(this.btn_GioiThieuPhong_Click);
            // 
            // pn_gioiThieu
            // 
            this.pn_gioiThieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pn_gioiThieu.Controls.Add(this.dataGridView1);
            this.pn_gioiThieu.Controls.Add(this.btn_dongGioiThieu);
            this.pn_gioiThieu.Location = new System.Drawing.Point(883, 48);
            this.pn_gioiThieu.Name = "pn_gioiThieu";
            this.pn_gioiThieu.Size = new System.Drawing.Size(643, 264);
            this.pn_gioiThieu.TabIndex = 33;
            this.pn_gioiThieu.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(9, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(625, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_dongGioiThieu
            // 
            this.btn_dongGioiThieu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dongGioiThieu.BackColor = System.Drawing.Color.Red;
            this.btn_dongGioiThieu.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongGioiThieu.ForeColor = System.Drawing.Color.White;
            this.btn_dongGioiThieu.Location = new System.Drawing.Point(588, 5);
            this.btn_dongGioiThieu.Name = "btn_dongGioiThieu";
            this.btn_dongGioiThieu.Size = new System.Drawing.Size(47, 45);
            this.btn_dongGioiThieu.TabIndex = 31;
            this.btn_dongGioiThieu.Text = "X";
            this.btn_dongGioiThieu.UseVisualStyleBackColor = false;
            this.btn_dongGioiThieu.Click += new System.EventHandler(this.btn_dongGioiThieu_Click);
            // 
            // frmOder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1842, 801);
            this.Controls.Add(this.pn_gioiThieu);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btn_GioiThieuPhong);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.cbbHD);
            this.Controls.Add(this.txtChitietDatmon);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flpPhong);
            this.Name = "frmOder";
            this.Text = "frmOder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOder_Load);
            this.pn_gioiThieu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtChitietDatmon;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btn_GioiThieuPhong;
        private System.Windows.Forms.Panel pn_gioiThieu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_dongGioiThieu;
    }
}