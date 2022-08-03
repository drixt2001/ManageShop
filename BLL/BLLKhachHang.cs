using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLKhachHang
    {
        DALKhachHang KhachHang = new DALKhachHang();

        public DataTable KhachHang_Select()

        {
            return KhachHang.Select_KhachHang();
        }

        public DataTable KhachHang_SelectWhere(int MaKH)
        {
            return KhachHang.SelectWhere_KhachHang(MaKH);
        }

        public int KhachHang_Insert(int MaKH, string HoTen, string DonVi, int MST, string DiaChi)
        {
            return KhachHang.Insert_KhachHang(MaKH, HoTen, DonVi, MST, DiaChi);
        }


        public int KhachHang_Update(int MaKH, string HoTen, string DonVi, int MST, string DiaChi)

        {
            return KhachHang.Update_KhachHang(MaKH, HoTen, DonVi, MST, DiaChi);
        }

        public int KhachHang_Delete(int MaKH)
        {
            return KhachHang.Delete_KhachHang(MaKH);
        }
    }
}
