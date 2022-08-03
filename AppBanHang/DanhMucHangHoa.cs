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
    public partial class DanhMucHangHoa : Form
    {
        BLLHangHoa HH = new BLLHangHoa();
        string from;

        public DanhMucHangHoa()
        {
            InitializeComponent();
        }

        private void DanhMucHangHoa_Load(object sender, EventArgs e)
        {
            ReloadData();
            MainView.Columns[3].DefaultCellStyle.Format = "N0";
            MainView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            MainView.Columns[3].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);
            OnOffEdit("Off");
            MainView.Columns[0].Width = 100;
            MainView.Columns[1].Width = 350;
            MainView.Columns[2].Width = 125;
            MainView.Columns[3].Width = 275;
        }

        private void ReloadData()
        {
            MainView.DataSource = HH.HangHoa_Select();
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = MainView.Rows[rowIndex];
            TBMaHang.Text = MainView.Rows[rowIndex].Cells[0].Value.ToString();
            TBTenHang.Text = MainView.Rows[rowIndex].Cells[1].Value.ToString();
            TBDVT.Text = MainView.Rows[rowIndex].Cells[2].Value.ToString();
            TBDonGia.Text = MainView.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void OnOffEdit(string tt)
        {
            if (tt == "On")
            {
                TBMaHang.Enabled = false;
                TBTenHang.Enabled = true;
                TBDVT.Enabled = true;
                TBDonGia.Enabled = true;

                BTNLuu.Visible = true;
                BTNDong.Visible = true;
            }
            else if (tt == "Off")
            {
                TBMaHang.Enabled = false;
                TBTenHang.Enabled = false;
                TBDVT.Enabled = false;
                TBDonGia.Enabled = false;

                BTNLuu.Visible = false;
                BTNDong.Visible = false;
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

        private void BTNThem_Click(object sender, EventArgs e)
        {
            from = "Add";
            OnOffEdit("On");
            TBMaHang.Text = GetIDnext().ToString();
            TBTenHang.Text = "";
            TBDVT.Text = "";
            TBDonGia.Text = "";
        }

        private void BTNSua_Click(object sender, EventArgs e)
        {
            from = "Edit";
            OnOffEdit("On");
        }

        private void BTNLuu_Click(object sender, EventArgs e)
        {
            int MaHH = int.Parse(TBMaHang.Text);
            string Ten = TBTenHang.Text;
            string DTV = TBDVT.Text;
            double DG = double.Parse(TBDonGia.Text);

            if (from == "Add")
            {
                HH.HangHoa_Insert(MaHH, Ten, DTV, DG);
            }
            if (from == "Edit")
            {

                HH.HangHoa_Update(MaHH, Ten, DTV, DG);
            }

            OnOffEdit("Off");
            ReloadData();
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
            int Ma = int.Parse(TBMaHang.Text);
            string Ten = TBTenHang.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa công ty " + Ten + "?", "Xóa Công Ty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HH.HangHoa_Delete(Ma);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ReloadData();
        }
    }
}
