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
    public partial class DanhMucKhachHang : Form
    {
        BLLKhachHang KH = new BLLKhachHang();
        string from;

        public DanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void DanhMucKhachHang_Load(object sender, EventArgs e)
        {
            ReloadData();
            OnOffEdit("Off");
            MainView.Columns[0].Width = 130;
            MainView.Columns[1].Width = 250;
            MainView.Columns[2].Width = 150;
            MainView.Columns[3].Width = 100;
            MainView.Columns[4].Width = 215;
        }

        private void ReloadData()
        {
            MainView.DataSource = KH.KhachHang_Select();
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = MainView.Rows[rowIndex];
            TBMa.Text = MainView.Rows[rowIndex].Cells[0].Value.ToString();
            TBTen.Text = MainView.Rows[rowIndex].Cells[1].Value.ToString();
            TBDonVi.Text = MainView.Rows[rowIndex].Cells[2].Value.ToString();
            TBMST.Text = MainView.Rows[rowIndex].Cells[3].Value.ToString();
            TBDiaChi.Text = MainView.Rows[rowIndex].Cells[4].Value.ToString();
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


        private void OnOffEdit(string tt)
        {
            if (tt == "On")
            {
                TBMa.Enabled = false;
                TBTen.Enabled = true;
                TBDonVi.Enabled = true;
                TBMST.Enabled = true;
                TBDiaChi.Enabled = true;

                BTNLuu.Visible = true;
                BTNDong.Visible = true;
            }
            else if (tt == "Off")
            {
                TBMa.Enabled = false;
                TBTen.Enabled = false;
                TBDonVi.Enabled = false;
                TBMST.Enabled = false;
                TBDiaChi.Enabled = false;

                BTNLuu.Visible = false;
                BTNDong.Visible = false;
            }
        }

        private void BTNThem_Click(object sender, EventArgs e)
        {
            from = "Add";
            OnOffEdit("On");
            TBMa.Text = GetIDnext().ToString();
            TBTen.Text = "";
            TBDonVi.Text = "";
            TBMST.Text = "";
            TBDiaChi.Text = "";
        }

        private void BTNSua_Click(object sender, EventArgs e)
        {
            from = "Edit";
            OnOffEdit("On");
        }

        private void BTNLuu_Click(object sender, EventArgs e)
        {
            int Ma = int.Parse(TBMa.Text);
            string ten = TBTen.Text;
            string donvi = TBDonVi.Text;
            int mst = int.Parse(TBMST.Text);
            string diachi = TBDiaChi.Text;

            if (from == "Add")
            {
                KH.KhachHang_Insert(Ma, ten, donvi, mst, diachi);
            }
            if (from == "Edit")
            {

                KH.KhachHang_Update(Ma, ten, donvi, mst, diachi);
            }

            OnOffEdit("Off");
            ReloadData();
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
            int Ma = int.Parse(TBMa.Text);
            string Ten = TBTen.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa công ty " + Ten + "?", "Xóa Công Ty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                KH.KhachHang_Delete(Ma);

            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ReloadData();
        }
    }
}
