using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLCongTy
    {
        DALCongTy CongTy = new DALCongTy();

        public DataTable CongTy_Select()

        {
            return CongTy.Select_CongTy();
        }

        public DataTable CongTy_SelectWhere(int Macty)
        {
            return CongTy.SelectWhere_CongTy(Macty);
        }

        public int CongTy_Insert(int Macty, string TenCty, string Diachi, string SDT, string MST)
        {
            return CongTy.Insert_CongTy(Macty, TenCty, Diachi, SDT, MST);
        }


        public int CongTy_Update(int Macty, string TenCty, string Diachi, string SDT, string MST)

        {
            return CongTy.Update_CongTy(Macty, TenCty, Diachi, SDT, MST);
        }

        public int CongTy_Delete(int Macty)
        {
            return CongTy.Delete_CongTy(Macty);
        }
    }
}
