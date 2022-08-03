using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDongDonHang
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        public DataTable Select_DongDonHang()

        {
            return CSDL.SQL_Laydulieu("P_Select_DongDonHang");

        }

        public DataTable SelectWhere_DongDonHang(int MaHD)

        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_HoaDon"; value[0] = MaHD;
            return CSDL.SQL_LaydulieuDK("P_SelectWhere_DongDonHang", name, value, 1);
        }

        public int Insert_DongDonHang(int MaHD, int MaHang, int SoLuong)

        {
            name = new string[3];
            value = new object[3];

            name[0] = "@SoHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            name[2] = "@SoLuong"; value[2] = SoLuong;
           

            return CSDL.SQL_Thuchien("P_Insert_DongDonHang", name, value, 3);

        }

        public int Update_DongDonHang(int MaHD, int MaHang, int SoLuong)
        {

            name = new string[3];
            value = new object[3];

            name[0] = "@SoHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            name[2] = "@SoLuong"; value[2] = SoLuong;

            return CSDL.SQL_Thuchien("P_Update_DongDonHang", name, value, 3);

        }

        public int Delete_DongDonHang(int MaHD, int MaHang)
        {

            name = new string[2];
            value = new object[2];

            name[0] = "@SoHD"; value[0] = MaHD;
            name[1] = "@MaHang"; value[1] = MaHang;
            return CSDL.SQL_Thuchien("P_Delete_DongDonHang", name, value, 2);

        }

        public int Delete_DongDonHangALL(int MaHD)
        {

            name = new string[1];
            value = new object[1];

            name[0] = "@SoHD"; value[0] = MaHD;
            return CSDL.SQL_Thuchien("P_Delete_DongDonHangALL", name, value, 1);

        }
    }
}
