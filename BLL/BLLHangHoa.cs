using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLHangHoa
    {

        DALHangHoa HangHoa = new DALHangHoa();

        public DataTable HangHoa_Select()

        {
            return HangHoa.Select_HangHoa();
        }

        public DataTable HangHoa_SelectWhere(int MaHH)
        {
            return HangHoa.SelectWhere_HangHoa(MaHH);
        }

        public int HangHoa_Insert(int MaHang, string TenHang, string DVT, double DonGia)
        {
            return HangHoa.Insert_HangHoa(MaHang, TenHang, DVT, DonGia);
        }


        public int HangHoa_Update(int MaHang, string TenHang, string DVT, double DonGia)

        {
            return HangHoa.Update_HangHoa(MaHang, TenHang, DVT, DonGia);
        }

        public int HangHoa_Delete(int MaHang)
        {
            return HangHoa.Delete_HangHoa(MaHang);
        }
    }
}
