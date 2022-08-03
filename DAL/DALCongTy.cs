using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALCongTy
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        public DataTable Select_CongTy()

        {
            return CSDL.SQL_Laydulieu("P_Select_CongTy");

        }

        public DataTable SelectWhere_CongTy(int MaCty)

        {
            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_CongTy"; value[0] = MaCty;

            return CSDL.SQL_Laydulieu("P_SelectWhere_CongTy");

        }

        public int Insert_CongTy(int MaCty, string TenCty, string Diachi, string SDT, string MST)

        {
            name = new string[5];
            value = new object[5];

            name[0] = "@Macty"; value[0] = MaCty;
            name[1] = "@Tencty"; value[1] = TenCty;
            name[2] = "@Diachi"; value[2] = Diachi;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@MST"; value[4] = MST;

            return CSDL.SQL_Thuchien("P_Insert_CongTy", name, value, 5);

        }

        public int Update_CongTy(int MaCty, string TenCty, string Diachi, string SDT, string MST)

        {

            name = new string[5];

            value = new object[5];

            name[0] = "@Macty"; value[0] = MaCty;
            name[1] = "@Tencty"; value[1] = TenCty;
            name[2] = "@Diachi"; value[2] = Diachi;
            name[3] = "@SDT"; value[3] = SDT;
            name[4] = "@MST"; value[4] = MST;

            return CSDL.SQL_Thuchien("P_Update_CongTy", name, value, 5);

        }

        public int Delete_CongTy(int MaCty)

        {

            name = new string[1];
            value = new object[1];

            name[0] = "@Ma_CongTy"; value[0] = MaCty;

            return CSDL.SQL_Thuchien("P_Delete_CongTy", name, value, 1);

        }

    }
}
