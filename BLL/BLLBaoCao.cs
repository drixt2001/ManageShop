using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class BLLBaoCao
    {
        DALBaoCao BC = new DALBaoCao();

        public DataTable BCTop5KhachHang()
        {
            return BC.BCAll_Top5KhachHang();
        }

        public DataTable BCTop5KhachHangIt()
        {
            return BC.BCAll_Top5KhachHangIt();
        }

        public DataTable GET_Thang()

        {
            return BC.GET_Thang();
        }

        public DataTable GET_Nam()

        {
            return BC.GET_Nam();
        }

        public DataTable BCThang_Top5SP(int thang)
        {
            return BC.BCThang_Top5SP(thang);
        }
        public DataTable BCSanPhamBanDuoc(DateTime from, DateTime end)
        {
            return BC.BCSanPhamBanDuoc(from, end);
        }

        public DataTable BCTop5DoanhThu(DateTime from, DateTime end)
        {
            return BC.BCTop5DoanhThu(from, end);
        }

        public DataTable BCDoanhThu(DateTime from, DateTime end)
        {
            return BC.BCDoanhThu(from, end);
        }

        public DataTable BCTop5DoanhThuIt(DateTime from, DateTime end)
        {
            return BC.BCTop5DoanhThuIt(from, end);
        }

        public DataTable BCThang_Top5SPItNhat(DateTime from, DateTime end)
        {
            return BC.BCThang_Top5SPBanItNhat(from, end);
        }

        public DataTable DuBao_SP(int mahang)

        {
            return BC.DuBao_SanPham(mahang);
        }

        public DataTable DuBao_ALLSP()
        {
            return BC.DuBaoALL_SanPham();
        }

        public DataTable DuBaoDay_ALLSP()
        {
            return BC.DuBaoDay_SanPham();
        }

        public DataTable DuBaoDayNext_ALLSP()
        {
            return BC.DuBaoDayNext_SanPham();
        }
    }
}
