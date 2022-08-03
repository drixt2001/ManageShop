using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;

namespace AppBanHang
{
    public partial class InHD : Form
    {
        public int SOHD;
        public double TongTien;
        
        public InHD()
        {
            InitializeComponent();
        }

        private void InHD_Load(object sender, EventArgs e)
        {
            BLLHoaDonBanHang HDBH = new BLLHoaDonBanHang();
            BaoCaoHD INHD = new BaoCaoHD();
            INHD.SetDataSource(HDBH.HoaDonBanHang_SelectALLINFO(SOHD));
            crystalReportViewer1.ReportSource = INHD;

            string TienBangChu = AppBanHang.TienBangChu.NumberToText(TongTien);
            (INHD.ReportDefinition.ReportObjects["TienBangChu"] as TextObject).Text = TienBangChu;
        }

        private void InHD_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    this.Close();
                    break; 
            }
        }
    }
}
