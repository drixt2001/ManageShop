
namespace AppBanHang
{
    partial class Login
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
            this.userTB = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.passTB = new System.Windows.Forms.TextBox();
            this.autologTB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // userTB
            // 
            this.userTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTB.Location = new System.Drawing.Point(117, 224);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(214, 22);
            this.userTB.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.Image = global::AppBanHang.Properties.Resources.premium_beer_logo_vector_4480367;
            this.logo.Location = new System.Drawing.Point(144, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(160, 160);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // loginBTN
            // 
            this.loginBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.CadetBlue;
            this.loginBTN.Location = new System.Drawing.Point(178, 379);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(100, 36);
            this.loginBTN.TabIndex = 3;
            this.loginBTN.Text = "Đăng Nhập";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTB.Location = new System.Drawing.Point(117, 290);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(214, 22);
            this.passTB.TabIndex = 1;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // autologTB
            // 
            this.autologTB.AutoSize = true;
            this.autologTB.Location = new System.Drawing.Point(117, 337);
            this.autologTB.Name = "autologTB";
            this.autologTB.Size = new System.Drawing.Size(118, 17);
            this.autologTB.TabIndex = 2;
            this.autologTB.Text = "Ghi nhớ đăng nhập";
            this.autologTB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(454, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autologTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.logo);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập Hệ Thống";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.CheckBox autologTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}