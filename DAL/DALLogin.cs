using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLogin
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        
        public DataTable Login(string username, string password)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@username"; value[0] = username;
            name[1] = "@password"; value[1] = password;
            return CSDL.SQL_LaydulieuDK("Z_LoginUser", name, value, 2);
        }

        public int InsertAutoLogin(string username)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@username"; value[0] = username;
            return CSDL.SQL_Thuchien("Z_Insert_AutoLogin", name, value, 1);
        }

        public DataTable CheckAutoLogin()
        {
            return CSDL.SQL_Laydulieu("Z_Check_AutoLogin");

        }
    }
}
