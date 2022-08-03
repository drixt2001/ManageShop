
namespace AppBanHang.UI
{
    partial class NVUI
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
            this.BTNKhachHang = new System.Windows.Forms.Button();
            this.BTNCongTy = new System.Windows.Forms.Button();
            this.BTNHoaDon = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TK = new System.Windows.Forms.Label();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Label();
            this.BTNPhimTat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNKhachHang
            // 
            this.BTNKhachHang.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNKhachHang.Image = global::AppBanHang.Properties.Resources.customer_review;
            this.BTNKhachHang.Location = new System.Drawing.Point(482, 181);
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
            // BTNCongTy
            // 
            this.BTNCongTy.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCongTy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNCongTy.Image = global::AppBanHang.Properties.Resources.office_building;
            this.BTNCongTy.Location = new System.Drawing.Point(272, 181);
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
            this.BTNHoaDon.Location = new System.Drawing.Point(62, 181);
            this.BTNHoaDon.Margin = new System.Windows.Forms.Padding(30);
            this.BTNHoaDon.Name = "BTNHoaDon";
            this.BTNHoaDon.Size = new System.Drawing.Size(150, 150);
            this.BTNHoaDon.TabIndex = 0;
            this.BTNHoaDon.Text = "Hóa Đơn";
            this.BTNHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNHoaDon.UseVisualStyleBackColor = false;
            this.BTNHoaDon.Click += new System.EventHandler(this.BTNHoaDon_Click);
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Location = new System.Drawing.Point(168, 88);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(88, 20);
            this.TK.TabIndex = 6;
            this.TK.Text = "Tài Khoản: ";
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBTN.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogoutBTN.Location = new System.Drawing.Point(749, 38);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(92, 28);
            this.LogoutBTN.TabIndex = 4;
            this.LogoutBTN.Text = "Đăng Xuất";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(168, 38);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(55, 20);
            this.Ten.TabIndex = 5;
            this.Ten.Text = "Chào: ";
            // 
            // BTNPhimTat
            // 
            this.BTNPhimTat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNPhimTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPhimTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPhimTat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNPhimTat.Image = global::AppBanHang.Properties.Resources.keyboard;
            this.BTNPhimTat.Location = new System.Drawing.Point(692, 181);
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppBanHang.Properties.Resources.cashier;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(62, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // NVUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(898, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNPhimTat);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.BTNKhachHang);
            this.Controls.Add(this.BTNCongTy);
            this.Controls.Add(this.BTNHoaDon);
            this.Name = "NVUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Bán Hàng";
            this.Load += new System.EventHandler(this.NVUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNKhachHang;
        private System.Windows.Forms.Button BTNCongTy;
        private System.Windows.Forms.Button BTNHoaDon;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button LogoutBTN;
        public System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Button BTNPhimTat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}