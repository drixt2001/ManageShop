using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHangHoa
    {

        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        public DataTable Select_HangHoa()

        {
            return CSDL.SQL_Laydulieu("P_Select_HangHoa");

        }

        public DataTable SelectWhere_HangHoa(int MaHH)

        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_HangHoa"; value[0] = MaHH;
            return CSDL.SQL_Laydulieu("P_SelectWhere_HangHoa");

        }

        public int Insert_HangHoa(int MaHang, string TenHang, string DVT, double DonGia)

        {
            name = new string[4];
            value = new object[4];

            name[0] = "@MaHang"; value[0] = MaHang;
            name[1] = "@Tenhang"; value[1] = TenHang;
            name[2] = "@Dongia"; value[2] = DonGia;
            name[3] = "@DVT"; value[3] = DVT;
            return CSDL.SQL_Thuchien("P_Insert_HangHoa", name, value, 4);

        }

        public int Update_HangHoa(int MaHang, string TenHang, string DVT, double DonGia)

        {

            name = new string[4];
            value = new object[4];

            name[0] = "@MaHang"; value[0] = MaHang;
            name[1] = "@Tenhang"; value[1] = TenHang;
            name[2] = "@Dongia"; value[2] = DonGia;
            name[3] = "@DVT"; value[3] = DVT;
            return CSDL.SQL_Thuchien("P_Update_HangHoa", name, value, 4);

        }

        public int Delete_HangHoa(int MaHang)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_HangHoa"; value[0] = MaHang;
            return CSDL.SQL_Thuchien("P_Delete_HangHoa", name, value, 1);

        }
    }
}
