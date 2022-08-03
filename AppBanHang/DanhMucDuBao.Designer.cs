
namespace AppBanHang
{
    partial class DanhMucDuBao
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
            this.BTNDuBao = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NgayMaiR = new System.Windows.Forms.RadioButton();
            this.HomNayR = new System.Windows.Forms.RadioButton();
            this.ThangToiR = new System.Windows.Forms.RadioButton();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNDuBao
            // 
            this.BTNDuBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDuBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDuBao.ForeColor = System.Drawing.Color.DarkCyan;
            this.BTNDuBao.Location = new System.Drawing.Point(12, 609);
            this.BTNDuBao.Name = "BTNDuBao";
            this.BTNDuBao.Size = new System.Drawing.Size(492, 43);
            this.BTNDuBao.TabIndex = 26;
            this.BTNDuBao.Text = "Dự Báo";
            this.BTNDuBao.UseVisualStyleBackColor = true;
            this.BTNDuBao.Click += new System.EventHandler(this.BTNDuBao_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(510, 12);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(848, 640);
            this.crystalReportViewer1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(172, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "DỰ BÁO BÁN HÀNG";
            // 
            // Main
            // 
            this.Main.AllowUserToAddRows = false;
            this.Main.AllowUserToDeleteRows = false;
            this.Main.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Main.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Main.DefaultCellStyle = dataGridViewCellStyle2;
            this.Main.EnableHeadersVisualStyles = false;
            this.Main.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.Location = new System.Drawing.Point(12, 73);
            this.Main.MultiSelect = false;
            this.Main.Name = "Main";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Main.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Main.Size = new System.Drawing.Size(492, 420);
            this.Main.TabIndex = 30;
            this.Main.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NgayMaiR);
            this.groupBox1.Controls.Add(this.HomNayR);
            this.groupBox1.Controls.Add(this.ThangToiR);
            this.groupBox1.Location = new System.Drawing.Point(12, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 67);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu Chí";
            // 
            // NgayMaiR
            // 
            this.NgayMaiR.AutoSize = true;
            this.NgayMaiR.Location = new System.Drawing.Point(385, 26);
            this.NgayMaiR.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.NgayMaiR.Name = "NgayMaiR";
            this.NgayMaiR.Size = new System.Drawing.Size(70, 17);
            this.NgayMaiR.TabIndex = 2;
            this.NgayMaiR.TabStop = true;
            this.NgayMaiR.Text = "Ngày Mai";
            this.NgayMaiR.UseVisualStyleBackColor = true;
            this.NgayMaiR.CheckedChanged += new System.EventHandler(this.NgayMaiR_CheckedChanged);
            // 
            // HomNayR
            // 
            this.HomNayR.AutoSize = true;
            this.HomNayR.Location = new System.Drawing.Point(222, 26);
            this.HomNayR.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.HomNayR.Name = "HomNayR";
            this.HomNayR.Size = new System.Drawing.Size(69, 17);
            this.HomNayR.TabIndex = 1;
            this.HomNayR.TabStop = true;
            this.HomNayR.Text = "Hôm Nay";
            this.HomNayR.UseVisualStyleBackColor = true;
            this.HomNayR.CheckedChanged += new System.EventHandler(this.HomNayR_CheckedChanged);
            // 
            // ThangToiR
            // 
            this.ThangToiR.AutoSize = true;
            this.ThangToiR.Location = new System.Drawing.Point(39, 26);
            this.ThangToiR.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ThangToiR.Name = "ThangToiR";
            this.ThangToiR.Size = new System.Drawing.Size(96, 17);
            this.ThangToiR.TabIndex = 0;
            this.ThangToiR.TabStop = true;
            this.ThangToiR.Text = "Các Tháng Tới";
            this.ThangToiR.UseVisualStyleBackColor = true;
            this.ThangToiR.CheckedChanged += new System.EventHandler(this.ThangToiR_CheckedChanged);
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Location = new System.Drawing.Point(418, 499);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(86, 17);
            this.CheckAll.TabIndex = 32;
            this.CheckAll.Text = "Chọn Tất Cả";
            this.CheckAll.UseVisualStyleBackColor = true;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAll_CheckedChanged);
            // 
            // DanhMucDuBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.BTNDuBao);
            this.Name = "DanhMucDuBao";
            this.Text = "Dự Báo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhMucDuBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTNDuBao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NgayMaiR;
        private System.Windows.Forms.RadioButton HomNayR;
        private System.Windows.Forms.RadioButton ThangToiR;
        private System.Windows.Forms.CheckBox CheckAll;
    }
}