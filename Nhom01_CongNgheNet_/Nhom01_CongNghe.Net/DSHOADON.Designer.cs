
namespace Nhom01_CongNghe.Net
{
    partial class DSHOADON
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
            this.btnXuatHoaDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatDoanhSo = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.BackColor = System.Drawing.Color.Blue;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatHoaDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(778, 12);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(269, 49);
            this.btnXuatHoaDon.TabIndex = 1;
            this.btnXuatHoaDon.Text = "Xuất danh sách hóa đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = false;
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnXuatDoanhSo);
            this.panel1.Controls.Add(this.btnXuatHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 70);
            this.panel1.TabIndex = 5;
            // 
            // btnXuatDoanhSo
            // 
            this.btnXuatDoanhSo.BackColor = System.Drawing.Color.Blue;
            this.btnXuatDoanhSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatDoanhSo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnXuatDoanhSo.Location = new System.Drawing.Point(503, 12);
            this.btnXuatDoanhSo.Name = "btnXuatDoanhSo";
            this.btnXuatDoanhSo.Size = new System.Drawing.Size(269, 49);
            this.btnXuatDoanhSo.TabIndex = 1;
            this.btnXuatDoanhSo.Text = "Xuất doanh số bán hàng";
            this.btnXuatDoanhSo.UseVisualStyleBackColor = false;
            this.btnXuatDoanhSo.Click += new System.EventHandler(this.btnXuatDoanhSo_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 70);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1059, 549);
            this.pnMain.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(439, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // DSHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 619);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSHOADON";
            this.Text = "DSHOADON";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnXuatHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXuatDoanhSo;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}