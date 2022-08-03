using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLLogin
    {
        DALLogin TK = new DALLogin();

        public DataTable Login(string username, string password)
        {
            return TK.Login(username, password);
        }

        public int AutoLogin(string username)
        {
            return TK.InsertAutoLogin(username);
        }

        public DataTable CheckAutoLogin()
        {
            return TK.CheckAutoLogin();
        }
    }
}
