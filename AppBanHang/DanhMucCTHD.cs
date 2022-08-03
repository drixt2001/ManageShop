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

namespace AppBanHang
{
    public partial class DanhMucCTHD : Form
    {
        int rowIndex;

        BLLCongTy CTY = new BLLCongTy();
        BLLHangHoa HH = new BLLHangHoa();
        BLLDongDonHang CTHD = new BLLDongDonHang();
        BLLKhachHang KH = new BLLKhachHang();
        BLLNhanVien NV = new BLLNhanVien();
        BLLHoaDonBanHang HD = new BLLHoaDonBanHang();

        
        int MaHD;
        int congty;
        int khachhang;
        string httt;
        int nv;
        DateTime ngay;
        public string from;

        public DanhMucCTHD()
        {
            InitializeComponent();
        }

        private void DanhMucCTHD_Load(object sender, EventArgs e)
        {
            HienThiCB();
            XemDataCB(from);
            HienThiDataCTHD();
            MainView.Columns[1].Width = 250;
            MainView.Columns[5].Width = 172;
        }

        private void HienThiDataCTHD()
        {
            int maHD = int.Parse(TBMa.Text);
            MainView.DataSource = CTHD.DongDonHang_SelectWhere(maHD);

            MainView.Columns[3].DefaultCellStyle.Format = "N0";
            MainView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MainView.Columns[5].DefaultCellStyle.Format = "N0";
            MainView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
            TinhTong();
            

        }

        private void XemDataCB(string from)
        {
            if(from == "View")
            {
                OnOffEdit("Off");
                CBCongTy.SelectedValue = congty;
                CBKhachHang.SelectedValue = khachhang;
                CBHTTT.SelectedItem = httt;
                CBNhanVien.SelectedValue = nv;
                DatePickerNgayLap.Value = ngay;
                BTNDong.Visible = true;
            }
            else if(from == "Add")
            {
                OnOffEdit("On");
                DatePickerNgayLap.Value = DateTime.Now;
                TaoHD();
                BTNHuy.Visible = true;
                BTNDong.Visible = false;

            } else if(from == "Edit")
            {
                OnOffEdit("On");
                CBCongTy.SelectedValue = congty;
                CBKhachHang.SelectedValue = khachhang;
                CBHTTT.SelectedItem = httt;
                CBNhanVien.SelectedValue = nv;
                DatePickerNgayLap.Value = ngay;
                BTNDong.Visible = true;
            }
            
        }

        public void TTHD(int congty, int khachhang, string httt, int nv, DateTime ngay)
        {
            this.congty = congty;
            this.khachhang = khachhang;
            this.httt = httt;
            this.nv = nv;
            this.ngay = ngay;

        }

        private void HienThiCB()
        {
            MaHD = int.Parse(TBMa.Text);
            CBCongTy.DataSource = CTY.CongTy_Select();
            CBCongTy.DisplayMember = "Tên Công Ty";
            CBCongTy.ValueMember = "Mã Công Ty";

            CBKhachHang.DataSource = KH.KhachHang_Select();
            CBKhachHang.DisplayMember = "Họ và Tên";
            CBKhachHang.ValueMember = "Mã Khách Hàng";

            CBHTTT.SelectedIndex = 0;

            CBNhanVien.DataSource = NV.NhanVien_Select();
            CBNhanVien.DisplayMember = "Tên NV";
            CBNhanVien.ValueMember = "Mã NV";

            DatePickerNgayLap.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            CBHangHoa.DataSource = HH.HangHoa_Select();
            CBHangHoa.DisplayMember = "Tên Hàng Hóa";
            CBHangHoa.ValueMember = "Mã Hàng";
            CBHangHoa_SelectedIndexChanged(this.CBHangHoa, new EventArgs());
        }

        private void CBHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable hang = new DataTable();
            hang = HH.HangHoa_Select();
            for(int i = 0; i < hang.Rows.Count; i++)
            {
                if(hang.Rows[i][0].ToString() == CBHangHoa.SelectedValue.ToString())
                {
                    double tien = double.Parse(hang.Rows[i][3].ToString());
                    TBDonGia.Text = tien.ToString("0,0");
                }
            }   
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            rowIndex = e.RowIndex;
            if(MainView.Rows.Count > 0)
            {
                DataGridViewRow row = MainView.Rows[rowIndex];
                CBHangHoa.SelectedValue = int.Parse(MainView.Rows[rowIndex].Cells[0].Value.ToString());
                NRSoLuong.Value = int.Parse(MainView.Rows[rowIndex].Cells[4].Value.ToString());
            }
               
        }


        public void OnOffEdit(string tt)
        {
            if (tt == "On")
            {
                TBMa.Enabled = false;
                CBCongTy.Enabled = true;
                CBKhachHang.Enabled = true;
                CBHTTT.Enabled = true;
                CBNhanVien.Enabled = true;
                DatePickerNgayLap.Enabled = true;
            }
            else if (tt == "Off")
            {
                TBMa.Enabled = false;
                CBCongTy.Enabled = false;
                CBKhachHang.Enabled = false;
                CBHTTT.Enabled = false;
                CBNhanVien.Enabled = false;
                DatePickerNgayLap.Enabled = false;
            }
        }

        private void BTNAddHH_Click(object sender, EventArgs e)
        {
            
            int maHang = int.Parse(CBHangHoa.SelectedValue.ToString());

            if(CheckHH(maHang) == false)
            {
                CTHD.DongDonHang_Insert(MaHD, maHang, Convert.ToInt32(NRSoLuong.Value));
                HienThiDataCTHD();
            } else
            {
                int slcu = int.Parse(MainView.Rows[rowIndex].Cells[4].Value.ToString());
                int slthem = Convert.ToInt32(NRSoLuong.Value);
                int slmoi = slcu + slthem;
                CTHD.DongDonHang_Update(MaHD, maHang, slmoi);
                HienThiDataCTHD();
            }
            

            
        }

        private void BTNDelHH_Click(object sender, EventArgs e)
        {
            int maHang = int.Parse(CBHangHoa.SelectedValue.ToString());
            CTHD.DongDonHang_Delete(MaHD, maHang);
            HienThiDataCTHD();
        }

        private void BTNEditHH_Click(object sender, EventArgs e)
        {
            int maHang = int.Parse(CBHangHoa.SelectedValue.ToString());
            CTHD.DongDonHang_Update(MaHD, maHang, Convert.ToInt32(NRSoLuong.Value));
            HienThiDataCTHD();
        }

        private bool CheckHH(int maHang)
        {
            for(int i = 0; i < MainView.Rows.Count; i++)
            {
                if(int.Parse(MainView.Rows[i].Cells[0].Value.ToString()) == maHang)
                {
                    return true;
                }
            }
            return false;
        }

        private void BTNLuu_Click(object sender, EventArgs e)
        {
            if (MainView.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm món hàng nào!");
            }
            else
            {
                string maKH = CBKhachHang.SelectedValue.ToString();
                string HTTT = CBHTTT.SelectedItem.ToString();
                string maCTY = CBCongTy.SelectedValue.ToString();
                string maNV = CBNhanVien.SelectedValue.ToString();
                HD.HoaDonBanHang_Update(MaHD, DatePickerNgayLap.Value, int.Parse(maKH), HTTT, int.Parse(maCTY), int.Parse(maNV));

                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void TaoHD()
        {
            string maKH = CBKhachHang.SelectedValue.ToString();
            string HTTT = CBHTTT.SelectedItem.ToString();
            string maCTY = CBKhachHang.SelectedValue.ToString();
            string maNV = CBKhachHang.SelectedValue.ToString();

            HD.HoaDonBanHang_Insert(MaHD, DatePickerNgayLap.Value, int.Parse(maKH), HTTT, int.Parse(maCTY), int.Parse(maNV));
        }

        private void BTNHuy_Click(object sender, EventArgs e)
        {
            CTHD.DongDonHang_DeleteALL(MaHD);
            HD.HoaDonBanHang_Delete(MaHD);
            this.DialogResult = DialogResult.OK;
        }

        private void TinhTong()
        {
            double Tong = 0;

            for(int i = 0; i < MainView.Rows.Count; i++)
            {
                double tien = double.Parse(MainView.Rows[i].Cells[5].Value.ToString());
                Tong = Tong + tien;
            }

            TBTongTien.Text = Tong.ToString("0,0");
        }

        private void BTNDong_Click_1(object sender, EventArgs e)
        {
            if(MainView.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm món hàng nào!");
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void BTNIn_Click(object sender, EventArgs e)
        {
            if (MainView.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa thêm món hàng nào!");
            }
            else
            {
                InHD form = new InHD();
                form.SOHD = MaHD;
                form.TongTien = double.Parse(TBTongTien.Text);
                form.Show();
            }
            
        }

        private void DanhMucCTHD_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                case Keys.Home:
                    if (MainView.Rows.Count == 0)
                    {
                        BTNHuy.PerformClick();
                    }
                    else
                    {
                        this.Close();
                    }
                    
                    break;
                case Keys.Add:
                    BTNAddHH.PerformClick();
                    break;
                case Keys.E:
                    BTNEditHH.PerformClick();
                    break;
                case Keys.Delete:
                    BTNDelHH.PerformClick();
                    break;
                case Keys.S:
                    BTNLuu.PerformClick();
                    break;
                case Keys.F4:
                    BTNDong.PerformClick();
                    this.Close();
                    break;
                case Keys.Escape:
                    BTNHuy.PerformClick();
                    break;
                case Keys.P:
                    BTNIn.PerformClick();
                    break;
            }
        }
    }
}
