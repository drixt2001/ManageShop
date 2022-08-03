
namespace AppBanHang
{
    partial class DanhMucHoaDon
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
            this.BTNXem = new System.Windows.Forms.Button();
            this.BTNDong = new System.Windows.Forms.Button();
            this.BTNXoa = new System.Windows.Forms.Button();
            this.BTNSua = new System.Windows.Forms.Button();
            this.BTNThem = new System.Windows.Forms.Button();
            this.BackBTN = new System.Windows.Forms.Button();
            this.TBSeacrh = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.MainView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNXem
            // 
            this.BTNXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNXem.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BTNXem.Location = new System.Drawing.Point(12, 248);
            this.BTNXem.Name = "BTNXem";
            this.BTNXem.Size = new System.Drawing.Size(60, 60);
            this.BTNXem.TabIndex = 22;
            this.BTNXem.Text = "Xem";
            this.BTNXem.UseVisualStyleBackColor = true;
            this.BTNXem.Click += new System.EventHandler(this.BTNXem_Click);
            // 
            // BTNDong
            // 
            this.BTNDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDong.ForeColor = System.Drawing.Color.IndianRed;
            this.BTNDong.Location = new System.Drawing.Point(12, 314);
            this.BTNDong.Name = "BTNDong";
            this.BTNDong.Size = new System.Drawing.Size(60, 60);
            this.BTNDong.TabIndex = 23;
            this.BTNDong.Text = "Hủy";
            this.BTNDong.UseVisualStyleBackColor = true;
            this.BTNDong.Visible = false;
            this.BTNDong.Click += new System.EventHandler(this.BTNDong_Click);
            // 
            // BTNXoa
            // 
            this.BTNXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNXoa.ForeColor = System.Drawing.Color.IndianRed;
            this.BTNXoa.Location = new System.Drawing.Point(12, 144);
            this.BTNXoa.Name = "BTNXoa";
            this.BTNXoa.Size = new System.Drawing.Size(60, 60);
            this.BTNXoa.TabIndex = 21;
            this.BTNXoa.Text = "Xóa";
            this.BTNXoa.UseVisualStyleBackColor = true;
            this.BTNXoa.Click += new System.EventHandler(this.BTNXoa_Click);
            // 
            // BTNSua
            // 
            this.BTNSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSua.ForeColor = System.Drawing.Color.CadetBlue;
            this.BTNSua.Location = new System.Drawing.Point(12, 78);
            this.BTNSua.Name = "BTNSua";
            this.BTNSua.Size = new System.Drawing.Size(60, 60);
            this.BTNSua.TabIndex = 20;
            this.BTNSua.Text = "Sửa";
            this.BTNSua.UseVisualStyleBackColor = true;
            this.BTNSua.Click += new System.EventHandler(this.BTNSua_Click);
            // 
            // BTNThem
            // 
            this.BTNThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNThem.ForeColor = System.Drawing.Color.CadetBlue;
            this.BTNThem.Location = new System.Drawing.Point(12, 12);
            this.BTNThem.Name = "BTNThem";
            this.BTNThem.Size = new System.Drawing.Size(60, 60);
            this.BTNThem.TabIndex = 19;
            this.BTNThem.Text = "Thêm";
            this.BTNThem.UseVisualStyleBackColor = true;
            this.BTNThem.Click += new System.EventHandler(this.BTNThem_Click);
            // 
            // BackBTN
            // 
            this.BackBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBTN.ForeColor = System.Drawing.Color.DarkCyan;
            this.BackBTN.Location = new System.Drawing.Point(12, 651);
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(75, 38);
            this.BackBTN.TabIndex = 25;
            this.BackBTN.Text = "<==";
            this.BackBTN.UseVisualStyleBackColor = true;
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // TBSeacrh
            // 
            this.TBSeacrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBSeacrh.Location = new System.Drawing.Point(93, 12);
            this.TBSeacrh.Name = "TBSeacrh";
            this.TBSeacrh.Size = new System.Drawing.Size(1028, 26);
            this.TBSeacrh.TabIndex = 26;
            this.TBSeacrh.TextChanged += new System.EventHandler(this.TBSeacrh_TextChanged);
            // 
            // BTNSearch
            // 
            this.BTNSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSearch.ForeColor = System.Drawing.Color.CadetBlue;
            this.BTNSearch.Location = new System.Drawing.Point(1127, 12);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(230, 26);
            this.BTNSearch.TabIndex = 27;
            this.BTNSearch.Text = "Tìm Kiếm";
            this.BTNSearch.UseVisualStyleBackColor = true;
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
            this.MainView.Location = new System.Drawing.Point(93, 44);
            this.MainView.Name = "MainView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MainView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainView.Size = new System.Drawing.Size(1265, 645);
            this.MainView.TabIndex = 28;
            this.MainView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainView_CellClick);
            // 
            // DanhMucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.MainView);
            this.Controls.Add(this.BTNSearch);
            this.Controls.Add(this.TBSeacrh);
            this.Controls.Add(this.BackBTN);
            this.Controls.Add(this.BTNXem);
            this.Controls.Add(this.BTNDong);
            this.Controls.Add(this.BTNXoa);
            this.Controls.Add(this.BTNSua);
            this.Controls.Add(this.BTNThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "DanhMucHoaDon";
            this.Text = "Danh Mục Hóa Đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhMucHoaDon_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhMucHoaDon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNXem;
        private System.Windows.Forms.Button BTNDong;
        private System.Windows.Forms.Button BTNXoa;
        private System.Windows.Forms.Button BTNSua;
        private System.Windows.Forms.Button BTNThem;
        private System.Windows.Forms.Button BackBTN;
        private System.Windows.Forms.TextBox TBSeacrh;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.DataGridView MainView;
    }
}