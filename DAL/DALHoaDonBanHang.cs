using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALHoaDonBanHang
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        public DataTable Select_HoaDonBanHang()

        {
            return CSDL.SQL_Laydulieu("P_Select_HoaDonBanHang");

        }

        public DataTable SelectWhere_HoaDonBanHang(string key)

        {
            name = new string[1];
            value = new object[1];

            name[0] = "@key"; value[0] = key;
            return CSDL.SQL_LaydulieuDK("S_Tim_HoaDon", name,value, 1);

        }
        public DataTable SelectALLINFO_HoaDonBanHang(int MaHD)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_HoaDon"; value[0] = MaHD;
            return CSDL.SQL_LaydulieuDK("P_SelectAll_HoaDon", name, value, 1);

        }


        public int Insert_HoaDonBanHang(int MaHD, DateTime NgayLap, int MaKH, string HTTT, int MaCTY, int MaNV)

        {
            name = new string[6];
            value = new object[6];

            name[0] = "@SoHD"; value[0] = MaHD;
            name[1] = "@NgayLap"; value[1] = NgayLap;
            name[2] = "@MaKH"; value[2] = MaKH;
            name[3] = "@HinhThucTT"; value[3] = HTTT;
            name[4] = "@MaCTY"; value[4] = MaCTY;
            name[5] = "@MaNV"; value[5] = MaNV;

            return CSDL.SQL_Thuchien("P_Insert_HoaDonBanHang", name, value, 6);

        }

        public int Update_HoaDonBanHang(int MaHD, DateTime NgayLap, int MaKH, string HTTT, int MaCTY, int MaNV)

        {

            name = new string[6];
            value = new object[6];

            name[0] = "@SoHD"; value[0] = MaHD;
            name[1] = "@NgayLap"; value[1] = NgayLap;
            name[2] = "@MaKH"; value[2] = MaKH;
            name[3] = "@HinhThucTT"; value[3] = HTTT;
            name[4] = "@MaCTY"; value[4] = MaCTY;
            name[5] = "@MaNV"; value[5] = MaNV;

            return CSDL.SQL_Thuchien("P_Update_HoaDonBanHang", name, value, 6);

        }

        public int Delete_HoaDonBanHang(int MaHD)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_HoaDonBanHang"; value[0] = MaHD;
            return CSDL.SQL_Thuchien("P_Delete_HoaDonBanHang", name, value, 1);

        }


        
    }
}
