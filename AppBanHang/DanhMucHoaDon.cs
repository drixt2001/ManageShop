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
    public partial class DanhMucHoaDon : Form
    {
        public static string from;
        BLLHoaDonBanHang HD = new BLLHoaDonBanHang();
        BLLDongDonHang CTHD = new BLLDongDonHang();
        int MaHD, MaKH, MaCTY, MaNV;
        string HTTT;
        DateTime NgayLap;

        public DanhMucHoaDon()
        {
            InitializeComponent();
        }

        private void DanhMucHoaDon_Load(object sender, EventArgs e)
        {
            ReloadData();
            CauHinh();
        }

        private void CauHinh()
        {
            MainView.Columns[0].Width = 40;
            MainView.Columns[1].Width = 150;
            MainView.Columns[2].Width = 40;
            MainView.Columns[3].Width = 300;
            MainView.Columns[4].Width = 100;
            MainView.Columns[5].Width = 40;
            MainView.Columns[6].Width = 300;
            MainView.Columns[7].Width = 40;
            MainView.Columns[8].Width = 190;

        }

        private void ReloadData()
        {
            MainView.DataSource = HD.HoaDonBanHang_Select();
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = e.RowIndex;
            if(MainView.Rows.Count > 0 && rowIndex >= 0)
            {
                DataGridViewRow row = MainView.Rows[rowIndex];
                MaHD = int.Parse(MainView.Rows[rowIndex].Cells[0].Value.ToString());
                MaKH = int.Parse(MainView.Rows[rowIndex].Cells[2].Value.ToString());
                MaCTY = int.Parse(MainView.Rows[rowIndex].Cells[5].Value.ToString());
                MaNV = int.Parse(MainView.Rows[rowIndex].Cells[7].Value.ToString());
                NgayLap = DateTime.Parse(MainView.Rows[rowIndex].Cells[1].Value.ToString());
                HTTT = MainView.Rows[rowIndex].Cells[4].Value.ToString();

                if(Program.userlevel == "1")
                {
                    BTNSua.Visible = true;
                    BTNXoa.Visible = true;

                } else
                {
                    if (MaNV.ToString() == Program.user)
                    {
                        BTNSua.Visible = true;
                        BTNXoa.Visible = true;
                    }
                    else
                    {
                        BTNSua.Visible = false;
                        BTNXoa.Visible = false;
                    }
                }

            }
            

        }

        private void BTNSua_Click(object sender, EventArgs e)
        {
            DanhMucCTHD CTHD = new DanhMucCTHD();
            CTHD.TBMa.Text = MaHD.ToString();
            CTHD.from = "Edit";
            CTHD.TTHD(MaCTY, MaKH, HTTT, MaNV, NgayLap);
            DialogResult dr = CTHD.ShowDialog();
            if(dr == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
            int Ma = MaHD;

            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa hóa đơn " + Ma + "?", "Xóa Công Ty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CTHD.DongDonHang_DeleteALL(Ma);
                HD.HoaDonBanHang_Delete(Ma);
                
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ReloadData();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNDong_Click(object sender, EventArgs e)
        {

        }

        private void DanhMucHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home:
                    this.Close();
                    break;
                case Keys.Add:
                    BTNThem.PerformClick();
                    break;
                case Keys.E:
                    BTNSua.PerformClick();
                    break;
                case Keys.Delete:
                    BTNXoa.PerformClick();
                    break;
                case Keys.O:
                    BTNXem.PerformClick();
                    break;
                case Keys.Escape:
                    BTNDong.PerformClick();
                    break;
                case Keys.F12:
                    BackBTN.PerformClick();
                    break;
            }
        }

        private void TBSeacrh_TextChanged(object sender, EventArgs e)
        {
            MainView.DataSource = HD.HoaDonBanHang_SelectWhere(TBSeacrh.Text);
        }

        private void BTNThem_Click(object sender, EventArgs e)
        {
            DanhMucCTHD CTHD = new DanhMucCTHD();  
            CTHD.TBMa.Text = GetIDnext().ToString();
            CTHD.from = "Add";
            DialogResult dr = CTHD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ReloadData();
            }
        }

        private int GetIDnext()
        {
            int IDmax = 0;
            for (int i = 0; i < MainView.Rows.Count; i++)
            {
                int IDnow = int.Parse(MainView.Rows[i].Cells[0].Value.ToString());
                if (IDnow >= IDmax)
                {
                    IDmax = IDnow;
                }
            }
            return IDmax + 1;
        }

        private void BTNXem_Click(object sender, EventArgs e)
        {
            DanhMucCTHD CTHD = new DanhMucCTHD();
            CTHD.TBMa.Text = MaHD.ToString();
            CTHD.from = "View";
            CTHD.TTHD(MaCTY, MaKH, HTTT, MaNV, NgayLap);
            DialogResult dr = CTHD.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ReloadData();
            }
        }
    }
}
