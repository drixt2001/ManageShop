using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALNhanVien
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };


        public int Insert_TaiKhoan(string username, string pass)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@username"; value[0] = username;
            name[1] = "@password"; value[1] = pass;

            return CSDL.SQL_Thuchien("Z_Insert_TaiKhoan", name, value, 2);

        }

        public int Update_TaiKhoan(string username, string pass)
        {

            name = new string[2];
            value = new object[2];

            name[0] = "@username"; value[0] = username;
            name[1] = "@password"; value[1] = pass;

            return CSDL.SQL_Thuchien("Z_Update_TaiKhoan", name, value, 2);

        }

        public DataTable GETUID_TaiKhoan(string username)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@username"; value[0] = username;
            return CSDL.SQL_LaydulieuDK("Z_GET_UID", name, value, 1);

        }

        public DataTable GETUTaiKhoan(string u)
        {
            name = new string[1];
            value = new object[1];
            name[0] = "@u"; value[0] = u;
            return CSDL.SQL_LaydulieuDK("Z_GETUser", name, value, 1);

        }
        //

        public DataTable Select_ChucVu()
        {
            return CSDL.SQL_Laydulieu("Z_Select_ChucDanh");

        }

        public DataTable Select_NhanVien()
        {
            return CSDL.SQL_Laydulieu("P_Select_NhanVien");

        }

        public DataTable SelectWhere_NhanVien(int MaNV)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_NhanVien"; value[0] = MaNV;
            return CSDL.SQL_Laydulieu("P_SelectWhere_NhanVien");

        }

        public int Insert_NhanVien(int MaNV, string TenNV, int MaCD, int MaUser, string SDT, String Que, DateTime Ngayvao)
        {
            name = new string[7];
            value = new object[7];

            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@MaCD"; value[2] = MaCD;
            name[3] = "@MaUser"; value[3] = MaUser;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@Quequan"; value[5] = Que;
            name[6] = "@NgayVaoLam"; value[6] = Ngayvao;

            return CSDL.SQL_Thuchien("P_Insert_NhanVien", name, value, 7);

        }

        public int Update_NhanVien(int MaNV, string TenNV, int MaCD, int MaUser, string SDT, String Que, DateTime Ngayvao)
        {

            name = new string[7];
            value = new object[7];

            name[0] = "@MaNV"; value[0] = MaNV;
            name[1] = "@TenNV"; value[1] = TenNV;
            name[2] = "@MaCD"; value[2] = MaCD;
            name[3] = "@MaUser"; value[3] = MaUser;
            name[4] = "@SDT"; value[4] = SDT;
            name[5] = "@Quequan"; value[5] = Que;
            name[6] = "@NgayVaoLam"; value[6] = Ngayvao;

            return CSDL.SQL_Thuchien("P_Update_NhanVien", name, value, 7);

        }

        public int Delete_NhanVien(int MaNV)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_NhanVien"; value[0] = MaNV;
            return CSDL.SQL_Thuchien("P_Delete_NhanVien", name, value, 1);
        }
    }
}
