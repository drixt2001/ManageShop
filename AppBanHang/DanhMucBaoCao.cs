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
using System.Data.OleDb;

namespace AppBanHang
{
    public partial class DanhMucBaoCao : Form
    {
        string check;
        BLLBaoCao BC = new BLLBaoCao();
        BLLHangHoa HH = new BLLHangHoa();
        bool loadcheck = false;
        public DanhMucBaoCao()
        {
            InitializeComponent();
        }

        private void Top5SP_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DanhMucBaoCao_Load(object sender, EventArgs e)
        {
            CBThang.DataSource = BC.GET_Thang();
            CBThang.ValueMember = "Tháng";
            CBThang.DisplayMember = "Tháng";
            CBNam.DataSource = BC.GET_Nam();
            CBNam.ValueMember = "Năm";
            CBNam.DisplayMember = "Năm";
            FromDatePicker.CustomFormat = "dd/MM/yyyy";
            ToDatePicker.CustomFormat = "dd/MM/yyyy";
            loadcheck = true;
            Top5SPSL.Checked = true;
            CBNam.SelectedIndex = 1;
            CBNam.SelectedIndex = 0;
        }


        private void FromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            FromDatePicker.Value = FromDatePicker.Value.Date;      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThongKeSP a = new ThongKeSP();
            ThongKeKH b = new ThongKeKH();
            ThongKeDT c = new ThongKeDT();
            if (check == "SL")
            {
                a.SetDataSource(BC.BCSanPhamBanDuoc(FromDatePicker.Value, ToDatePicker.Value));
                crystalReportViewer1.ReportSource = a;

            } else if (check == "DT")
            {
                a.SetDataSource(BC.BCTop5DoanhThu(FromDatePicker.Value, ToDatePicker.Value));
                crystalReportViewer1.ReportSource = a;
            } else if (check == "ISL")
            {
                a.SetDataSource(BC.BCThang_Top5SPItNhat(FromDatePicker.Value, ToDatePicker.Value));
                crystalReportViewer1.ReportSource = a;
            } else if (check == "IDT")
            {
                a.SetDataSource(BC.BCTop5DoanhThuIt(FromDatePicker.Value, ToDatePicker.Value));
                crystalReportViewer1.ReportSource = a;
            } else if (check == "KHNhieu")
            {
                b.SetDataSource(BC.BCTop5KhachHang());
                (b.ReportDefinition.ReportObjects["TOP"] as TextObject).Text = "TOP KHÁCH HÀNG MUA NHIỀU NHẤT";
                crystalReportViewer1.ReportSource = b;
            } else if (check == "KHIt")
            {
                b.SetDataSource(BC.BCTop5KhachHangIt());
                (b.ReportDefinition.ReportObjects["TOP"] as TextObject).Text = "TOP KHÁCH HÀNG MUA ÍT NHẤT";

                crystalReportViewer1.ReportSource = b;
            } else if (check == "TongDT")
            {
                c.SetDataSource(BC.BCDoanhThu(FromDatePicker.Value, ToDatePicker.Value));
                crystalReportViewer1.ReportSource = c;
                //(b.ReportDefinition.ReportObjects["TOP"] as TextObject).Text = "TOP KHÁCH HÀNG MUA ÍT NHẤT";

            }

        }

        

        private void ToDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ToDatePicker.Value = ToDatePicker.Value.Date;
        }

        private void SoLuongR_CheckedChanged(object sender, EventArgs e)
        {
            check = "SL";
        }

        private void DoanhThuR_CheckedChanged(object sender, EventArgs e)
        {
            check = "DT";
        }

        private void It5SPSL_CheckedChanged(object sender, EventArgs e)
        {
            check = "ISL";
        }

        private void It5SPDT_CheckedChanged(object sender, EventArgs e)
        {
            check = "IDT";
        }

        private void BTNDuBao_Click(object sender, EventArgs e)
        {
           

            //var fileName = @"D:\DataAdmin.xlsx";
            //var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;IMEX=1;HDR=NO;TypeGuessRows=0;ImportMixedTypes=Text\""; ;
            //using (var conn = new OleDbConnection(connectionString))
            //{
            //    conn.Open();

            //    var sheets = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            //    using (var cmd = conn.CreateCommand())
            //    {
            //        cmd.CommandText = "SELECT * FROM [" + sheets.Rows[0]["TABLE_NAME"].ToString() + "] ";
            //        var adapter = new OleDbDataAdapter(cmd);
            //        var ds = new DataSet();
            //        adapter.Fill(ds);
            //        dataGridView1.DataSource = ds.Tables[0];
            //    }
            //}


        }

        private void CBHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Namcheck.Checked = false;
            thangCheck.Checked = true;
            string thangnam = CBThang.SelectedValue.ToString();
            string stthang = thangnam.Substring(0, 2);
            string stnam = thangnam.Substring(3, 4);
            int thang = 0;
            int nam = 0;
            Int32.TryParse(stthang, out thang);
            Int32.TryParse(stnam, out nam);

            if (loadcheck == true)
            {
                int max = DateTime.DaysInMonth(nam, thang);

                FromDatePicker.Value = new DateTime(nam, thang, 01);
                ToDatePicker.Value = new DateTime(nam, thang, max);
            }

        }

        private void CBNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Namcheck.Checked = true;
            thangCheck.Checked = false;
            string stnam = CBNam.SelectedValue.ToString();
            int nam = 0;
            Int32.TryParse(stnam, out nam);

            if (loadcheck == true)
            {
                FromDatePicker.Value = new DateTime(nam, 01, 01);
                ToDatePicker.Value = new DateTime(nam, 12, 31);
            }
        }

        private void KHMuaNhieu_CheckedChanged(object sender, EventArgs e)
        {
            check = "KHNhieu";
        }

        private void KHMuaIt_CheckedChanged(object sender, EventArgs e)
        {
            check = "KHIt";
        }

        private void TongDoanhThu_CheckedChanged(object sender, EventArgs e)
        {
            check = "TongDT";
        }

        private void Today_CheckedChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (Today.Checked == true)
            {
                FromDatePicker.Value = new DateTime(today.Year, today.Month, today.Day);
                ToDatePicker.Value = new DateTime(today.Year, today.Month, today.Day+1);
            }
        }
    }
}
