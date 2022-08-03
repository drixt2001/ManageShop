using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALKhachHang
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        public DataTable Select_KhachHang()

        {
            return CSDL.SQL_Laydulieu("P_Select_KhachHang");

        }

        public DataTable SelectWhere_KhachHang(int MaKH)

        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_KhachHang"; value[0] = MaKH;
            return CSDL.SQL_Laydulieu("P_SelectWhere_KhachHang");

        }

        public int Insert_KhachHang(int MaKH, string HoTen, string DonVi, int MST, string DiaChi)

        {
            name = new string[5];
            value = new object[5];

            name[0] = "@MaKH"; value[0] = MaKH;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@DonVi"; value[2] = DonVi;
            name[3] = "@MaSoThue"; value[3] = MST;
            name[4] = "@DiaChi"; value[4] = DiaChi;


            return CSDL.SQL_Thuchien("P_Insert_KhachHang", name, value, 5);

        }

        public int Update_KhachHang(int MaKH, string HoTen, string DonVi, int MST, string DiaChi)

        {

            name = new string[5];
            value = new object[5];

            name[0] = "@MaKH"; value[0] = MaKH;
            name[1] = "@HoTen"; value[1] = HoTen;
            name[2] = "@DonVi"; value[2] = DonVi;
            name[3] = "@MaSoThue"; value[3] = MST;
            name[4] = "@DiaChi"; value[4] = DiaChi;

            return CSDL.SQL_Thuchien("P_Update_KhachHang", name, value, 5);

        }

        public int Delete_KhachHang(int MaKH)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_KhachHang"; value[0] = MaKH;
            return CSDL.SQL_Thuchien("P_Delete_KhachHang", name, value, 1);

        }
    }
}
