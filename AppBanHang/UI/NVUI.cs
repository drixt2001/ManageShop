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
namespace AppBanHang.UI
{
    public partial class NVUI : Form
    {
        BLLLogin Log = new BLLLogin();

        public NVUI()
        {
            InitializeComponent();
        }


        private void NVUI_Load(object sender, EventArgs e)
        {

        }

        private void ManagerUI_Load(object sender, EventArgs e)
        {
            
        }
        private void BTNCongTy_Click(object sender, EventArgs e)
        {
            DanhMucCongTy form = new DanhMucCongTy();
            form.Show();
        }

        private void BTNHoaDon_Click(object sender, EventArgs e)
        {
            DanhMucHoaDon form = new DanhMucHoaDon();
            form.Show();
        }

        private void BTNKhachHang_Click(object sender, EventArgs e)
        {
            DanhMucKhachHang form = new DanhMucKhachHang();
            form.Show();
        }

        private void BTNHangHoa_Click(object sender, EventArgs e)
        {
            DanhMucHangHoa form = new DanhMucHangHoa();
            form.Show();
        }

        private void BTNNhanVien_Click(object sender, EventArgs e)
        {
            DanhMucNhanVien form = new DanhMucNhanVien();
            form.Show();
        }

        private void BTNReport_Click(object sender, EventArgs e)
        {
            DanhMucBaoCao form = new DanhMucBaoCao();
            form.Show();
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            Log.AutoLogin("");
            this.Close();
        }

        private void BTNPhimTat_Click(object sender, EventArgs e)
        {
            DanhMucPhimTat form = new DanhMucPhimTat();
            form.Show();
        }
    }
}
