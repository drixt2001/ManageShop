using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLHoaDonBanHang
    {
        DALHoaDonBanHang HoaDonBanHang = new DALHoaDonBanHang();

        public DataTable HoaDonBanHang_SelectALLINFO(int maHD)

        {
            return HoaDonBanHang.SelectALLINFO_HoaDonBanHang(maHD);
        }

        public DataTable HoaDonBanHang_Select()

        {
            return HoaDonBanHang.Select_HoaDonBanHang();
        }

        public DataTable HoaDonBanHang_SelectWhere(string key)
        {
            return HoaDonBanHang.SelectWhere_HoaDonBanHang(key);
        }

        public int HoaDonBanHang_Insert(int MaHD, DateTime NgayLap, int MaKH, string HTTT, int MaCTY, int MaNV)
        {
            return HoaDonBanHang.Insert_HoaDonBanHang(MaHD, NgayLap, MaKH, HTTT, MaCTY, MaNV);
        }


        public int HoaDonBanHang_Update(int MaHD, DateTime NgayLap, int MaKH, string HTTT, int MaCTY, int MaNV)

        {
            return HoaDonBanHang.Update_HoaDonBanHang(MaHD, NgayLap, MaKH, HTTT, MaCTY, MaNV);
        }

        public int HoaDonBanHang_Delete(int MaHD)
        {
            return HoaDonBanHang.Delete_HoaDonBanHang(MaHD);
        }
    }
}
