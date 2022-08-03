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
    public partial class DanhMucDuBao : Form
    {
        string tieuchi;
        BLLHangHoa HH = new BLLHangHoa();
        BLLBaoCao BC = new BLLBaoCao();

        public DanhMucDuBao()
        {
            InitializeComponent();
        }

        private void DanhMucDuBao_Load(object sender, EventArgs e)
        {
            DataTable Hang = HH.HangHoa_Select();
            DataTable a = Hang.DefaultView.ToTable(true, "Mã Hàng", "Tên Hàng Hóa");
            Main.DataSource = a;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "X";
            checkColumn.HeaderText = "Chọn";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            Main.Columns.Add(checkColumn);

            Main.Columns[0].Width = 100;
            Main.Columns[1].Width = 300;
            Main.Columns[2].Width = 55;
        }

        private void BTNDuBao_Click(object sender, EventArgs e)
        {
            
            switch (tieuchi)
            {
                case "Thang":
                    DataTable x = BC.DuBao_ALLSP();
                    DataTable z = x.Clone();

                    for (int i = 0; i < Main.Rows.Count; i++)
                    {
                        object check = Main.Rows[i].Cells[2].Value;

                        if (check != null)
                        {
                            bool c = bool.Parse(check.ToString());
                            if (c == true)
                            {
                                string matam = Main.Rows[i].Cells[0].Value.ToString();

                                foreach (DataRow dr in x.Rows)
                                {
                                    if (dr["MaHang"].ToString() == matam)
                                        z.Rows.Add(dr.ItemArray);
                                }
                            }
                        }
                    }

                    DuBao dbaothang = new DuBao();
                    dbaothang.SetDataSource(z);
                    crystalReportViewer1.ReportSource = dbaothang;
                    break;
                case "Nay":
                    DataTable n = BC.DuBaoDay_ALLSP();
                    DataTable k = n.Clone();

                    for (int i = 0; i < Main.Rows.Count; i++)
                    {
                        object check = Main.Rows[i].Cells[2].Value;

                        if (check != null)
                        {
                            bool c = bool.Parse(check.ToString());
                            if (c == true)
                            {
                                string matam = Main.Rows[i].Cells[0].Value.ToString();

                                foreach (DataRow dr in n.Rows)
                                {
                                    if (dr["MaHang"].ToString() == matam)
                                        k.Rows.Add(dr.ItemArray);
                                }
                            }
                        }
                    }

                    DuBaoNgay dbaongay = new DuBaoNgay();
                    dbaongay.SetDataSource(k);
                    crystalReportViewer1.ReportSource = dbaongay;
                    break;

                case "Mai":
                    DataTable o = BC.DuBaoDayNext_ALLSP();
                    DataTable p = o.Clone();

                    for (int i = 0; i < Main.Rows.Count; i++)
                    {
                        object check = Main.Rows[i].Cells[2].Value;

                        if (check != null)
                        {
                            bool c = bool.Parse(check.ToString());
                            if (c == true)
                            {
                                string matam = Main.Rows[i].Cells[0].Value.ToString();

                                foreach (DataRow dr in o.Rows)
                                {
                                    if (dr["MaHang"].ToString() == matam)
                                        p.Rows.Add(dr.ItemArray);
                                }
                            }
                        }
                    }

                    DuBaoNgay dbmai = new DuBaoNgay();
                    dbmai.SetDataSource(p);
                    crystalReportViewer1.ReportSource = dbmai;
                    break;
            }
            
        }

        private void ThangToiR_CheckedChanged(object sender, EventArgs e)
        {
            tieuchi = "Thang";
        }

        private void HomNayR_CheckedChanged(object sender, EventArgs e)
        {
            tieuchi = "Nay";
        }

        private void NgayMaiR_CheckedChanged(object sender, EventArgs e)
        {
            tieuchi = "Mai";
        }

        private void CheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckAll.Checked == true)
            {
                for(int i =0;i< Main.Rows.Count; i++)
                {
                    Main.Rows[i].Cells[2].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < Main.Rows.Count; i++)
                {
                    Main.Rows[i].Cells[2].Value = false;
                }
            }
            checkSelect();
        }

        private void Main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            checkSelect();
        }

        private void checkSelect()
        {
            //    object check;
            //    for (int i = 0; i < Main.Rows.Count; i++)
            //    {
            //        check = Main.Rows[i].Cells[2].Value;
            //        if (bool.Parse(check.ToString()) == true && bool.Parse(check.ToString()) != null)
            //        {
            //            Main.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
            //        }
            //        else
            //        {
            //            Main.Rows[i].DefaultCellStyle.BackColor = Color.White;
            //        }
            //    }
        }
    }
}
