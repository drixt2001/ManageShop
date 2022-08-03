using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLDongDonHang
    {
        DALDongDonHang DongDonHang = new DALDongDonHang();

        public DataTable DongDonHang_Select()

        {
            return DongDonHang.Select_DongDonHang();
        }

        public DataTable DongDonHang_SelectWhere(int MaHD)
        {
            return DongDonHang.SelectWhere_DongDonHang(MaHD);
        }

        public int DongDonHang_Insert(int MaHD, int MaHang, int SoLuong)
        {
            return DongDonHang.Insert_DongDonHang(MaHD, MaHang, SoLuong);
        }


        public int DongDonHang_Update(int MaHD, int MaHang, int SoLuong)

        {
            return DongDonHang.Update_DongDonHang(MaHD, MaHang, SoLuong);
        }

        public int DongDonHang_Delete(int MaHD, int MaHang)
        {
            return DongDonHang.Delete_DongDonHang(MaHD, MaHang);
        }

        public int DongDonHang_DeleteALL(int MaHD)
        {
            return DongDonHang.Delete_DongDonHangALL(MaHD);
        }
    }
}
