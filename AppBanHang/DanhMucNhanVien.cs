using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanHang
{
    public partial class DanhMucNhanVien : Form
    {
        BLLNhanVien NV = new BLLNhanVien();
        string from;

        public DanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void DanhMucNhanVien_Load(object sender, EventArgs e)
        {
            ReloadData();
            OnOffEdit("Off");

            
            MainView.Columns[0].Width = 40;
            MainView.Columns[1].Width = 140;
            MainView.Columns[2].Width = 115;
            MainView.Columns[3].Width = 100;
            MainView.Columns[4].Width = 155;
            MainView.Columns[5].Width = 95;
            MainView.Columns[6].Width = 100;
            MainView.Columns[7].Width = 120;
            NgayvaoDateP.CustomFormat = "dd/MM/yyyy";
        }

        private void ReloadData()
        {
            MainView.DataSource = NV.NhanVien_Select();
            CBChucvu.DataSource = NV.ChucDanh_Select();
            CBChucvu.DisplayMember = "Tên Chức Danh";
            CBChucvu.ValueMember = "Mã CD";

            
            MainView_CellClick(this.MainView, new DataGridViewCellEventArgs(0, 0));
        }

        private void MainView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int MaCD = 0;
            DataGridViewRow row = MainView.Rows[rowIndex];
            TBMa.Text = MainView.Rows[rowIndex].Cells[0].Value.ToString();
            TBTen.Text = MainView.Rows[rowIndex].Cells[1].Value.ToString();

            DataTable chucvu = NV.ChucDanh_Select();
            for (int i = 0; i < chucvu.Rows.Count; i++)
            {
                if (chucvu.Rows[i][1].ToString() == MainView.Rows[rowIndex].Cells[2].Value.ToString())
                {
                    MaCD = int.Parse(chucvu.Rows[i][0].ToString());
                }

            }

            CBChucvu.SelectedValue = MaCD;

            usernameTB.Text = MainView.Rows[rowIndex].Cells[3].Value.ToString();
            DataTable u = NV.GetUser(usernameTB.Text);
            PassTB.Text = u.Rows[0][1].ToString();
            TBSDT.Text = MainView.Rows[rowIndex].Cells[5].Value.ToString();
            TBQue.Text = MainView.Rows[rowIndex].Cells[6].Value.ToString();
            NgayvaoDateP.Value = DateTime.Parse(MainView.Rows[rowIndex].Cells[7].Value.ToString());
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
                CBChucvu.Enabled = true;

                usernameTB.Enabled = true;
                PassTB.Enabled = true;
                PassTB.UseSystemPasswordChar = false;

                TBSDT.Enabled = true;
                TBQue.Enabled = true;
                NgayvaoDateP.Enabled = true;

                BTNLuu.Visible = true;
                BTNDong.Visible = true;
            }
            else if (tt == "Off")
            {
                TBMa.Enabled = false;
                TBTen.Enabled = false;
                CBChucvu.Enabled = false;

                usernameTB.Enabled = false;
                PassTB.Enabled = false;
                PassTB.UseSystemPasswordChar = true;

                TBSDT.Enabled = false;
                TBQue.Enabled = false;
                NgayvaoDateP.Enabled = false;

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

        }

        private void BTNSua_Click(object sender, EventArgs e)
        {
            from = "Edit";
            OnOffEdit("On");
            usernameTB.Enabled = false;
        }

        private void BTNLuu_Click(object sender, EventArgs e)
        {
            int Ma = int.Parse(TBMa.Text);
            string ten = TBTen.Text;
            int machucvu = int.Parse(CBChucvu.SelectedValue.ToString());
            string SDT = TBSDT.Text;
            string que = TBQue.Text;
            DateTime ngayvao = NgayvaoDateP.Value.Date;
            if (from == "Add")
            {
                NV.TaiKhoan_Insert(usernameTB.Text, PassTB.Text);
                DataTable UID = NV.TaiKhoan_GetUID(usernameTB.Text);
                int maTK = int.Parse(UID.Rows[0][0].ToString());
                NV.NhanVien_Insert(Ma, ten, machucvu, maTK, SDT, que, ngayvao);
            }
            if (from == "Edit")
            {
                NV.TaiKhoan_Update(usernameTB.Text, PassTB.Text);
                DataTable UID = NV.TaiKhoan_GetUID(usernameTB.Text);
                int maTK = int.Parse(UID.Rows[0][0].ToString());
                NV.NhanVien_Update(Ma, ten, machucvu, maTK, SDT, que, ngayvao);

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
                NV.NhanVien_Delete(Ma);
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            ReloadData();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TBPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
