
namespace AppBanHang
{
    partial class DanhMucCongTy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTNThem = new System.Windows.Forms.Button();
            this.BTNSua = new System.Windows.Forms.Button();
            this.BTNXoa = new System.Windows.Forms.Button();
            this.BTNLuu = new System.Windows.Forms.Button();
            this.BTNDong = new System.Windows.Forms.Button();
            this.MainView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMaCTY = new System.Windows.Forms.TextBox();
            this.TBTenCTY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBMST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNThem
            // 
            this.BTNThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNThem.ForeColor = System.Drawing.Color.CadetBlue;
            this.BTNThem.Location = new System.Drawing.Point(13, 12);
            this.BTNThem.Name = "BTNThem";
            this.BTNThem.Size = new System.Drawing.Size(60, 60);
            this.BTNThem.TabIndex = 0;
            this.BTNThem.Text = "Thêm";
            this.BTNThem.UseVisualStyleBackColor = true;
            this.BTNThem.Click += new System.EventHandler(this.BTNThem_Click);
            // 
            // BTNSua
            // 
            this.BTNSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSua.ForeColor = System.Drawing.Color.CadetBlue;
            this.BTNSua.Location = new System.Drawing.Point(13, 78);
            this.BTNSua.Name = "BTNSua";
            this.BTNSua.Size = new System.Drawing.Size(60, 60);
            this.BTNSua.TabIndex = 1;
            this.BTNSua.Text = "Sửa";
            this.BTNSua.UseVisualStyleBackColor = true;
            this.BTNSua.Click += new System.EventHandler(this.BTNSua_Click);
            // 
            // BTNXoa
            // 
            this.BTNXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNXoa.ForeColor = System.Drawing.Color.IndianRed;
            this.BTNXoa.Location = new System.Drawing.Point(13, 144);
            this.BTNXoa.Name = "BTNXoa";
            this.BTNXoa.Size = new System.Drawing.Size(60, 60);
            this.BTNXoa.TabIndex = 2;
            this.BTNXoa.Text = "Xóa";
            this.BTNXoa.UseVisualStyleBackColor = true;
            this.BTNXoa.Click += new System.EventHandler(this.BTNXoa_Click);
            // 
            // BTNLuu
            // 
            this.BTNLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLuu.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BTNLuu.Location = new System.Drawing.Point(13, 248);
            this.BTNLuu.Name = "BTNLuu";
            this.BTNLuu.Size = new System.Drawing.Size(60, 60);
            this.BTNLuu.TabIndex = 3;
            this.BTNLuu.Text = "Lưu";
            this.BTNLuu.UseVisualStyleBackColor = true;
            this.BTNLuu.Visible = false;
            this.BTNLuu.Click += new System.EventHandler(this.BTNLuu_Click);
            // 
            // BTNDong
            // 
            this.BTNDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDong.ForeColor = System.Drawing.Color.IndianRed;
            this.BTNDong.Location = new System.Drawing.Point(13, 314);
            this.BTNDong.Name = "BTNDong";
            this.BTNDong.Size = new System.Drawing.Size(60, 60);
            this.BTNDong.TabIndex = 4;
            this.BTNDong.Text = "Hủy";
            this.BTNDong.UseVisualStyleBackColor = true;
            this.BTNDong.Visible = false;
            this.BTNDong.Click += new System.EventHandler(this.BTNDong_Click);
            // 
            // MainView
            // 
            this.MainView.AllowUserToAddRows = false;
            this.MainView.AllowUserToDeleteRows = false;
            this.MainView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainView.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainView.EnableHeadersVisualStyles = false;
            this.MainView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainView.Location = new System.Drawing.Point(467, 12);
            this.MainView.Name = "MainView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MainView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MainView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainView.Size = new System.Drawing.Size(891, 520);
            this.MainView.TabIndex = 5;
            this.MainView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Công Ty";
            // 
            // TBMaCTY
            // 
            this.TBMaCTY.Location = new System.Drawing.Point(22, 39);
            this.TBMaCTY.Name = "TBMaCTY";
            this.TBMaCTY.Size = new System.Drawing.Size(159, 20);
            this.TBMaCTY.TabIndex = 7;
            // 
            // TBTenCTY
            // 
            this.TBTenCTY.Location = new System.Drawing.Point(22, 106);
            this.TBTenCTY.Name = "TBTenCTY";
            this.TBTenCTY.Size = new System.Drawing.Size(297, 20);
            this.TBTenCTY.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Công Ty";
            // 
            // TBDiaChi
            // 
            this.TBDiaChi.Location = new System.Drawing.Point(22, 172);
            this.TBDiaChi.Name = "TBDiaChi";
            this.TBDiaChi.Size = new System.Drawing.Size(297, 20);
            this.TBDiaChi.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa Chỉ";
            // 
            // TBSDT
            // 
            this.TBSDT.Location = new System.Drawing.Point(22, 238);
            this.TBSDT.Name = "TBSDT";
            this.TBSDT.Size = new System.Drawing.Size(159, 20);
            this.TBSDT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Số Điện Thoại";
            // 
            // TBMST
            // 
            this.TBMST.Location = new System.Drawing.Point(22, 304);
            this.TBMST.Name = "TBMST";
            this.TBMST.Size = new System.Drawing.Size(159, 20);
            this.TBMST.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã Số Thuế";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBMST);
            this.groupBox1.Controls.Add(this.TBMaCTY);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBSDT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TBTenCTY);
            this.groupBox1.Controls.Add(this.TBDiaChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(93, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 362);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // DanhMucCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 625);
            this.Controls.Add(this.MainView);
            this.Controls.Add(this.BTNDong);
            this.Controls.Add(this.BTNLuu);
            this.Controls.Add(this.BTNXoa);
            this.Controls.Add(this.BTNSua);
            this.Controls.Add(this.BTNThem);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "DanhMucCongTy";
            this.Text = "Danh Mục Công Ty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhMucCongTy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhMucCongTy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNThem;
        private System.Windows.Forms.Button BTNSua;
        private System.Windows.Forms.Button BTNXoa;
        private System.Windows.Forms.Button BTNLuu;
        private System.Windows.Forms.Button BTNDong;
        private System.Windows.Forms.DataGridView MainView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMaCTY;
        private System.Windows.Forms.TextBox TBTenCTY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBMST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}