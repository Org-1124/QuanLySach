using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DauSachDAO
    {
        public static SqlConnection con;
        public static DataTable LoadSach()
        {
            string sTruyVan = "select *from tblDauSach";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }


        public static int IDMax()
        {
            string sTruyVan = "select Max(IDSach) from tblDauSach";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            try
            {
                return int.Parse(dt.Rows[0][0].ToString());
            }
            catch
            {
                return 0;
            }
        }

        public static bool SuaDS(DauSachDTO ds)
        {
            try
            {
                string sTruyVan = string.Format("update tblDauSach set TenSach=N'{0}',TentacGia=N'{1}',TheLoaiSach=N'{2}',NgonNgu=N'{3}',Gia={4},SoLuongConLai={5},GhiChu=N'{6}' where IDSach={7}", ds.TenSach, ds.TenTacGia, ds.TheLoaiSach, ds.NgonNgu, ds.Gia, ds.SoLuongConLai, ds.GhiChu, ds.IDSach);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }

            catch
            {
                return false;
            }
        }

        public static bool XoaDS(DauSachDTO ds)
        {
            try
            {
                string sTruyVan = string.Format("delete tblDauSach where IDSach = {0}",ds.IDSach);
                con = DataProvider.KetNoi();
                DataProvider.ThucThiTruyVan(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemDS(DauSachDTO ds)
        {
            string sTruyVan = string.Format("insert into tblDauSach values ({0},N'{1}',N'{2}',N'{3}',N'{4}',{5},{6},N'{7}')",ds.IDSach,ds.TenSach,ds.TenTacGia,ds.TheLoaiSach,ds.NgonNgu,ds.Gia,ds.SoLuongConLai,ds.GhiChu);
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }

        public static DataTable TimKiemSach(string p)
        {
            string sTruyVan = string.Format("select * from tblDauSach where TenSach like N'%{0}%'", p);
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
    }
}
