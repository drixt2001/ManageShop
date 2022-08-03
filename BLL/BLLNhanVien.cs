using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLNhanVien
    {
        DALNhanVien NhanVien = new DALNhanVien();


        public int TaiKhoan_Insert(string username, string pass)
        {
            return NhanVien.Insert_TaiKhoan(username, pass);
        }

        public int TaiKhoan_Update(string username, string pass)
        {
            return NhanVien.Update_TaiKhoan(username, pass);
        }

        public DataTable TaiKhoan_GetUID(string username)
        {
            return NhanVien.GETUID_TaiKhoan(username);
        }

        public DataTable GetUser(string u)
        {
            return NhanVien.GETUTaiKhoan(u);
        }
        //
        public DataTable ChucDanh_Select()
        {
            return NhanVien.Select_ChucVu();
        }


        public DataTable NhanVien_Select()
        {
            return NhanVien.Select_NhanVien();
        }

        public DataTable NhanVien_SelectWhere(int MaNV)
        {
            return NhanVien.SelectWhere_NhanVien(MaNV);
        }

        public int NhanVien_Insert(int MaNV, string TenNV, int MaCD, int MaUser, string SDT, String Que, DateTime Ngayvao)
        {
            return NhanVien.Insert_NhanVien(MaNV, TenNV, MaCD, MaUser, SDT, Que, Ngayvao);
        }


        public int NhanVien_Update(int MaNV, string TenNV, int MaCD, int MaUser, string SDT, String Que, DateTime Ngayvao)

        {
            return NhanVien.Update_NhanVien(MaNV, TenNV, MaCD, MaUser, SDT, Que, Ngayvao);
        }

        public int NhanVien_Delete(int MaNV)
        {
            return NhanVien.Delete_NhanVien(MaNV);
        }
    }
}
