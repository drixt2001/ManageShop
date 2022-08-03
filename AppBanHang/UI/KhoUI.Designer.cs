
namespace AppBanHang.UI
{
    partial class KhoUI
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
            this.BTNHangHoa = new System.Windows.Forms.Button();
            this.BTNHoaDon = new System.Windows.Forms.Button();
            this.TK = new System.Windows.Forms.Label();
            this.LogoutBTN = new System.Windows.Forms.Button();
            this.Ten = new System.Windows.Forms.Label();
            this.BTNPhimTat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNHangHoa
            // 
            this.BTNHangHoa.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHangHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHangHoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNHangHoa.Image = global::AppBanHang.Properties.Resources.box;
            this.BTNHangHoa.Location = new System.Drawing.Point(335, 165);
            this.BTNHangHoa.Margin = new System.Windows.Forms.Padding(30);
            this.BTNHangHoa.Name = "BTNHangHoa";
            this.BTNHangHoa.Size = new System.Drawing.Size(150, 150);
            this.BTNHangHoa.TabIndex = 1;
            this.BTNHangHoa.Text = "Hàng Hóa";
            this.BTNHangHoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNHangHoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNHangHoa.UseVisualStyleBackColor = false;
            this.BTNHangHoa.Click += new System.EventHandler(this.BTNHangHoa_Click);
            // 
            // BTNHoaDon
            // 
            this.BTNHoaDon.BackColor = System.Drawing.Color.CadetBlue;
            this.BTNHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNHoaDon.Image = global::AppBanHang.Properties.Resources.bill;
            this.BTNHoaDon.Location = new System.Drawing.Point(125, 165);
            this.BTNHoaDon.Margin = new System.Windows.Forms.Padding(30);
            this.BTNHoaDon.Name = "BTNHoaDon";
            this.BTNHoaDon.Size = new System.Drawing.Size(150, 150);
            this.BTNHoaDon.TabIndex = 0;
            this.BTNHoaDon.Text = "Hóa Đơn";
            this.BTNHoaDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTNHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BTNHoaDon.UseVisualStyleBackColor = false;
            this.BTNHoaDon.MouseCaptureChanged += new System.EventHandler(this.BTNHoaDon_Click);
            // 
            // TK
            // 
            this.TK.AutoSize = true;
            this.TK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TK.Location = new System.Drawing.Point(237, 72);
            this.TK.Name = "TK";
            this.TK.Size = new System.Drawing.Size(88, 20);
            this.TK.TabIndex = 5;
            this.TK.Text = "Tài Khoản: ";
            // 
            // LogoutBTN
            // 
            this.LogoutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBTN.ForeColor = System.Drawing.Color.DarkCyan;
            this.LogoutBTN.Location = new System.Drawing.Point(595, 21);
            this.LogoutBTN.Name = "LogoutBTN";
            this.LogoutBTN.Size = new System.Drawing.Size(100, 40);
            this.LogoutBTN.TabIndex = 3;
            this.LogoutBTN.Text = "Đăng Xuất";
            this.LogoutBTN.UseVisualStyleBackColor = true;
            this.LogoutBTN.Click += new System.EventHandler(this.LogoutBTN_Click);
            // 
            // Ten
            // 
            this.Ten.AutoSize = true;
            this.Ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten.Location = new System.Drawing.Point(237, 30);
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(55, 20);
            this.Ten.TabIndex = 4;
            this.Ten.Text = "Chào: ";
            // 
            // BTNPhimTat
            // 
            this.BTNPhimTat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNPhimTat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNPhimTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPhimTat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTNPhimTat.Image = global::AppBanHang.Properties.Resources.keyboard;
            this.BTNPhimTat.Location = new System.Drawing.Point(545, 165);
            this.BTNPhimTat.Margin = new System.Windows.Forms.Padding(30);
            this.BTNPhimTat.Name = "BTNPhimTat";
            this.BTNPhimTat.Size = new System.Drawing.Size(150, 150);
            this.BTNPhimTat.TabIndex = 2;
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
            this.pictureBox1.Location = new System.Drawing.Point(125, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // KhoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNPhimTat);
            this.Controls.Add(this.TK);
            this.Controls.Add(this.LogoutBTN);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.BTNHangHoa);
            this.Controls.Add(this.BTNHoaDon);
            this.Name = "KhoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Kho Vận";
            this.Load += new System.EventHandler(this.KhoUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNHangHoa;
        private System.Windows.Forms.Button BTNHoaDon;
        public System.Windows.Forms.Label TK;
        private System.Windows.Forms.Button LogoutBTN;
        public System.Windows.Forms.Label Ten;
        private System.Windows.Forms.Button BTNPhimTat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}