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
    public partial class DanhMucCongTy : Form
    {
        BLLCongTy CTY = new BLLCongTy();
        string from;

        public DanhMucCongTy()
        {
            InitializeComponent();
        }

        private void DanhMucCongTy_Load(object sender, EventArgs e)
        {
            ReloadData(); 
            OnOffEdit("Off");
            MainView.Columns[0].Width = 130;
            MainView.Columns[1].Width = 350;
            MainView.Columns[2].Width = 170;
            MainView.Columns[3].Width = 100;
            MainView.Columns[4].Width = 100;
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if ((MainView.Rows.Count > 0 && rowIndex >= 0))
            {
                DataGridViewRow row = MainView.Rows[rowIndex];
                TBMaCTY.Text = MainView.Rows[rowIndex].Cells[0].Value.ToString();
                TBTenCTY.Text = MainView.Rows[rowIndex].Cells[1].Value.ToString();
                TBDiaChi.Text = MainView.Rows[rowIndex].Cells[2].Value.ToString();
                TBSDT.Text = MainView.Rows[rowIndex].Cells[3].Value.ToString();
                TBMST.Text = MainView.Rows[rowIndex].Cells[4].Value.ToString();
            }
            
        }

        private void BTNDong_Click(object sender, EventArgs e)
        {
            OnOffEdit("Off");
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }

        private void BTNThem_Click(object sender, EventArgs e)
        {
            from = "Add";
            OnOffEdit("On");
            TBMaCTY.Text = GetIDnext().ToString();
            TBTenCTY.Text = "";
            TBDiaChi.Text = "";
            TBSDT.Text = "";
            TBMST.Text = "";
        }

        private void BTNSua_Click(object sender, EventArgs e)
        {
            from = "Edit";
            OnOffEdit("On");
        }

        private void BTNLuu_Click(object sender, EventArgs e)
        {
            int MaCTY = int.Parse(TBMaCTY.Text);
            string TenCTY = TBTenCTY.Text;
            string DiaChi = TBDiaChi.Text;
            string SDT = TBSDT.Text;
            string MST = TBMST.Text;

            if (from == "Add")
            {
                CTY.CongTy_Insert(MaCTY, TenCTY, DiaChi, SDT, MST);
            }
            if(from == "Edit")
            {
                
                CTY.CongTy_Update(MaCTY, TenCTY, DiaChi, SDT, MST);
            }

            OnOffEdit("Off");
            ReloadData();
        }

        private void ReloadData()
        {
            MainView.DataSource = CTY.CongTy_Select();
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }
        private int GetIDnext()
        {
            int IDmax = 0;
            for(int i = 0;i< MainView.Rows.Count; i++)
            {
                int IDnow = int.Parse(MainView.Rows[i].Cells[0].Value.ToString());
                if(IDnow >= IDmax)
                {
                    IDmax = IDnow;
                }
            }
            return IDmax+1;
        }

        private void OnOffEdit(string tt)
        {
            if (tt == "On")
            {
                TBMaCTY.Enabled = false;
                TBTenCTY.Enabled = true;
                TBDiaChi.Enabled = true;
                TBSDT.Enabled = true;
                TBMST.Enabled = true;

                BTNLuu.Visible = true;
                BTNDong.Visible = true;
            }
            else if (tt == "Off")
            {
                TBMaCTY.Enabled = false;
                TBTenCTY.Enabled = false;
                TBDiaChi.Enabled = false;
                TBSDT.Enabled = false;
                TBMST.Enabled = false;

                BTNLuu.Visible = false;
                BTNDong.Visible = false;
            }
        }

        private void BTNXoa_Click(object sender, EventArgs e)
        {
            int MaCTY = int.Parse(TBMaCTY.Text);
            string TenCTY = TBTenCTY.Text;

            DialogResult dialogResult = MessageBox.Show("Bạn có đồng ý xóa công ty "+ TenCTY + "?", "Xóa Công Ty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CTY.CongTy_Delete(MaCTY);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ReloadData();
        }

        private void DanhMucCongTy_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Home: this.Close();
                    break;
                case Keys.Add: BTNThem.PerformClick();
                    break;
                case Keys.E:
                    BTNSua.PerformClick();
                    break;
                case Keys.Delete:
                    BTNXoa.PerformClick();
                    break;
                case Keys.S:
                    BTNLuu.PerformClick();
                    break;
                case Keys.Escape:
                    BTNDong.PerformClick();
                    break;
            }
        }
    }
}
