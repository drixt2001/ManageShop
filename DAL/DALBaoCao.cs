using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBaoCao
    {
        DatabaseConnects CSDL = new DatabaseConnects();

        string[] name = { };
        object[] value = { };

        
        public DataTable BCThang_Top5SP(int MaHD)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@thang"; value[0] = MaHD;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_Top5SP", name, value, 1);

        }



        public DataTable BCThang_Top5SPBanItNhat(DateTime from, DateTime end)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@fromDay"; value[0] = from;
            name[1] = "@endDay"; value[1] = end;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_Top5SPBanIt", name, value, 2);
        }

        public DataTable BCSanPhamBanDuoc(DateTime from, DateTime end)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@fromDay"; value[0] = from;
            name[1] = "@endDay"; value[1] = end;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_SanPhamBanDuoc", name, value, 2);

        }

        public DataTable BCTop5DoanhThu(DateTime from, DateTime end)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@fromDay"; value[0] = from;
            name[1] = "@endDay"; value[1] = end;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_Top5DoanhThu", name, value, 2);

        }

        public DataTable BCDoanhThu(DateTime from, DateTime end)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@fromDay"; value[0] = from;
            name[1] = "@endDay"; value[1] = end;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_DoanhThu", name, value, 2);

        }

        public DataTable BCTop5DoanhThuIt(DateTime from, DateTime end)
        {
            name = new string[2];
            value = new object[2];

            name[0] = "@fromDay"; value[0] = from;
            name[1] = "@endDay"; value[1] = end;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_Top5ItDoanhThu", name, value, 2);

        }

        public DataTable BCAll_Top5KhachHang()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_Top5KhachHang");

        }

        public DataTable BCAll_Top5KhachHangIt()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_Top5KhachHangIt");

        }

        public DataTable GET_Thang()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_GETThang");

        }

        public DataTable GET_Nam()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_GETNam");

        }


        public DataTable DuBao_SanPham(int mahang)
        {
            name = new string[1];
            value = new object[1];

            name[0] = "@mahang"; value[0] = mahang;
            return CSDL.SQL_LaydulieuDK("P_BaoCao_DuBaoSP", name, value, 1);
        }

        public DataTable DuBaoALL_SanPham()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_DuBaoSPALL");

        }

        public DataTable DuBaoDay_SanPham()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_DuBaoSPDay");

        }

        public DataTable DuBaoDayNext_SanPham()
        {
            return CSDL.SQL_Laydulieu("P_BaoCao_DuBaoSPDayNext");

        }
    }
}
