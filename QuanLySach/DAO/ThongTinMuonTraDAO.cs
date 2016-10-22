using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class ThongTinMuonTraDAO
    {
        public static SqlConnection con;

        public static DataTable LoadData()
        {
            string sTruyVan = "select * from tblThongTinMuonTra";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            return dt;
        }

        public static bool ThemThongTinMuon(ThonTinMuonTraDTO thongtin)
        {
            string sTruyVan = string.Format(@"insert into tblThongTinMuonTra values({0},{1}, N'{2}', {3}, '{4}', {5})", thongtin.IDSach, thongtin.IDThe,
                                                                                                                      thongtin.TinhTrang, thongtin.TienDatCoc,
                                                                                                                      thongtin.NgayHenTra, thongtin.SoLuong
                                                                                                                        );
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }

        public static bool XoaThongTinMuon(ThonTinMuonTraDTO thontin)
        {
            string sTruyVan = string.Format("delete from tblThongTinMuonTra where IDThe={0} and IDSach={1}", thontin.IDThe,thontin.IDSach);
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }

        public static DataTable TimKiemSach(string tensach)
        {
            string sTruyVan = string.Format("select * from tblDauSach where TenSach like '%{0}%'", tensach);
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }

        public static DataTable TimKiemSachMuon(int IDThe)
        {
            string sTruyVan = string.Format("select * from tblDauSach where IDThe={0}", IDThe);
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayDataTable(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
    }
}
