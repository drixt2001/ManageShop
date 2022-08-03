
namespace AppBanHang.UI
{
    partial class ManagerUI
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
            this.Ten = new System.Windows.Forms.Label();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.TK = new System.Windows.Forms.Label();
            this.BTNPhimTat = new System.Windows.Forms.Button();
            this.BTNDuBao = new System.Windows.Forms.Button();
            this.BTNNhanVien = new System.Windows.Forms.Button();
            this.BTNKhachHang = new System.Windows.Forms.Button();
            this.BTNReport = new System.Windows.Forms.Button();
            this.BTNHangHoa = new System.Windows.Forms.Button();
            this.BTNCongTy = new System.Windows.Forms.Button();
            this.BTNHoaDon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(144, 29);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(55, 20);
            this.Ten.TabIndex = 9;
            this.Ten.Text = "Chào: ";
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBTN.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogoutBTN.Location = new System.Drawing.Point(669, 20);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(100, 40);
            this.LogoutBTN.TabIndex = 8;
            this.LogoutBTN.Text = "Đăng Xuất";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Location = new System.Drawing.Point(144, 72);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(88, 20);
            this.TK.TabIndex = 10;
            this.TK.Text = "Tài Khoản: ";
            // 
            // BTNPhimTat
            // 
            this.BTNPhimTat.BackColor = System.Drawing.Color.LightSlateGray;
            this.BTNPhimTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPhimTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPhimTat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNPhimTat.Image = global::AppBanHang.Properties.Resources.keyboard;
            this.BTNPhimTat.Location = new System.Drawing.Point(611, 141);
            this.BTNPhimTat.Margin = new System.Windows.Forms.Padding(30);
            this.BTNPhimTat.Name = "BTNPhimTat";
            this.BTNPhimTat.Size = new System.Drawing.Size(150, 150);
            this.BTNPhimTat.TabIndex = 3;
            this.BTNPhimTat.Text = "Phím Tắt";
            this.BTNPhimTat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNPhimTat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNPhimTat.UseVisualStyleBackColor = false;
            this.BTNPhimTat.Click += new System.EventHandler(this.BTNPhimTat_Click);
            // 
            // BTNDuBao
            // 
            this.BTNDuBao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNDuBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDuBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDuBao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNDuBao.Image = global::AppBanHang.Properties.Resources.line_chart__1_;
            this.BTNDuBao.Location = new System.Drawing.Point(611, 331);
            this.BTNDuBao.Margin = new System.Windows.Forms.Padding(30);
            this.BTNDuBao.Name = "BTNDuBao";
            this.BTNDuBao.Size = new System.Drawing.Size(150, 150);
            this.BTNDuBao.TabIndex = 7;
            this.BTNDuBao.Text = "Dự Báo";
            this.BTNDuBao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNDuBao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNDuBao.UseVisualStyleBackColor = false;
            this.BTNDuBao.Click += new System.EventHandler(this.BTNDuBao_Click);
            // 
            // BTNNhanVien
            // 
            this.BTNNhanVien.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNNhanVien.Image = global::AppBanHang.Properties.Resources.cashier;
            this.BTNNhanVien.Location = new System.Drawing.Point(231, 331);
            this.BTNNhanVien.Margin = new System.Windows.Forms.Padding(30);
            this.BTNNhanVien.Name = "BTNNhanVien";
            this.BTNNhanVien.Size = new System.Drawing.Size(150, 150);
            this.BTNNhanVien.TabIndex = 5;
            this.BTNNhanVien.Text = "Nhân Viên";
            this.BTNNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNNhanVien.UseVisualStyleBackColor = false;
            this.BTNNhanVien.Click += new System.EventHandler(this.BTNNhanVien_Click);
            // 
            // BTNKhachHang
            // 
            this.BTNKhachHang.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNKhachHang.Image = global::AppBanHang.Properties.Resources.customer_review;
            this.BTNKhachHang.Location = new System.Drawing.Point(421, 141);
            this.BTNKhachHang.Margin = new System.Windows.Forms.Padding(30);
            this.BTNKhachHang.Name = "BTNKhachHang";
            this.BTNKhachHang.Size = new System.Drawing.Size(150, 150);
            this.BTNKhachHang.TabIndex = 2;
            this.BTNKhachHang.Text = "Khách Hàng";
            this.BTNKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNKhachHang.UseVisualStyleBackColor = false;
            this.BTNKhachHang.Click += new System.EventHandler(this.BTNKhachHang_Click);
            // 
            // BTNReport
            // 
            this.BTNReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNReport.Image = global::AppBanHang.Properties.Resources.clipboard;
            this.BTNReport.Location = new System.Drawing.Point(421, 331);
            this.BTNReport.Margin = new System.Windows.Forms.Padding(30);
            this.BTNReport.Name = "BTNReport";
            this.BTNReport.Size = new System.Drawing.Size(150, 150);
            this.BTNReport.TabIndex = 6;
            this.BTNReport.Text = "Báo Cáo";
            this.BTNReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNReport.UseVisualStyleBackColor = false;
            this.BTNReport.Click += new System.EventHandler(this.BTNReport_Click);
            // 
            // BTNHangHoa
            // 
            this.BTNHangHoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHangHoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNHangHoa.Image = global::AppBanHang.Properties.Resources.box;
            this.BTNHangHoa.Location = new System.Drawing.Point(41, 331);
            this.BTNHangHoa.Margin = new System.Windows.Forms.Padding(30);
            this.BTNHangHoa.Name = "BTNHangHoa";
            this.BTNHangHoa.Size = new System.Drawing.Size(150, 150);
            this.BTNHangHoa.TabIndex = 4;
            this.BTNHangHoa.Text = "Hàng Hóa";
            this.BTNHangHoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNHangHoa.UseVisualStyleBackColor = false;
            this.BTNHangHoa.Click += new System.EventHandler(this.BTNHangHoa_Click);
            // 
            // BTNCongTy
            // 
            this.BTNCongTy.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCongTy.Image = global::AppBanHang.Properties.Resources.office_building;
            this.BTNCongTy.Location = new System.Drawing.Point(231, 141);
            this.BTNCongTy.Margin = new System.Windows.Forms.Padding(30);
            this.BTNCongTy.Name = "BTNCongTy";
            this.BTNCongTy.Size = new System.Drawing.Size(150, 150);
            this.BTNCongTy.TabIndex = 1;
            this.BTNCongTy.Text = "Công Ty";
            this.BTNCongTy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNCongTy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNCongTy.UseVisualStyleBackColor = false;
            this.BTNCongTy.Click += new System.EventHandler(this.BTNCongTy_Click);
            // 
            // BTNHoaDon
            // 
            this.BTNHoaDon.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNHoaDon.Image = global::AppBanHang.Properties.Resources.bill;
            this.BTNHoaDon.Location = new System.Drawing.Point(41, 141);
            this.BTNHoaDon.Margin = new System.Windows.Forms.Padding(30);
            this.BTNHoaDon.Name = "BTNHoaDon";
            this.BTNHoaDon.Size = new System.Drawing.Size(150, 150);
            this.BTNHoaDon.TabIndex = 0;
            this.BTNHoaDon.Text = "Hóa Đơn";
            this.BTNHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNHoaDon.UseVisualStyleBackColor = true;
            this.BTNHoaDon.Click += new System.EventHandler(this.BTNHoaDon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppBanHang.Properties.Resources.cashier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNPhimTat);
            this.Controls.Add(this.BTNDuBao);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.BTNNhanVien);
            this.Controls.Add(this.BTNKhachHang);
            this.Controls.Add(this.BTNReport);
            this.Controls.Add(this.BTNHangHoa);
            this.Controls.Add(this.BTNCongTy);
            this.Controls.Add(this.BTNHoaDon);
            this.KeyPreview = true;
            this.Name = "ManagerUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Quản Lý";
            this.Load += new System.EventHandler(this.ManagerUI_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManagerUI_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNNhanVien;
        private System.Windows.Forms.Button BTNKhachHang;
        private System.Windows.Forms.Button BTNReport;
        private System.Windows.Forms.Button BTNHangHoa;
        private System.Windows.Forms.Button BTNCongTy;
        private System.Windows.Forms.Button BTNHoaDon;
        private System.Windows.Forms.Button LogoutBTN;
        public System.Windows.Forms.Label Ten;
        public System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button BTNDuBao;
        private System.Windows.Forms.Button BTNPhimTat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}