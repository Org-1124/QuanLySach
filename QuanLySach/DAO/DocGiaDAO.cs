using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DocGiaDAO
    {
        public static SqlConnection con;

        public static DataTable LoadDataDocGia()
        {
            string sTruyVan = "select IdThe,HoTen,DiaChi,Email,Sdt,LoaiThe,TrangThai from tblDocGia";
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayData(sTruyVan, con);
            return dt;
        }

        public static bool ThemDocGia(DocGiaDTO DocGia)
        {
            string sTruyVan = string.Format(@"insert into tblDocGia values({0},'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}')", DocGia.IdThe, DocGia.Sdt,
                                                                                                                      DocGia.HoTen, DocGia.Email,
                                                                                                                      DocGia.DiaChi, DocGia.LoaiThe,
                                                                                                                      DocGia.TrangThai);
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }

        public static bool SuaDocGia(DocGiaDTO DocGia)
        {
            string sTruyVan = string.Format("update tblDocGia set Sdt='{0}', HoTen=N'{1}', Email=N'{2}', DiaChi=N'{3}', LoaiThe=N'{4}', TrangThai=N'{5}' where IdThe={6}", DocGia.Sdt, DocGia.HoTen,
                                                                                                                                                                    DocGia.Email, DocGia.DiaChi,
                                                                                                                                                                    DocGia.LoaiThe, DocGia.TrangThai,
                                                                                                                                                                    DocGia.IdThe);
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }

        public static bool XoaDocGia(DocGiaDTO DocGia)
        {
            string sTruyVan = string.Format("delete from tblDocGia where IdThe={0}", DocGia.IdThe);
            con = DataProvider.KetNoi();
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);

            con = DataProvider.KetNoi();
            string sTruyVan1 = string.Format("delete from tblThongTinMuonTra where IdThe={0}", DocGia.IdThe);
            DataProvider.ThucThiTruyVan(sTruyVan1, con);
            DataProvider.DongKetNoi(con);
            return true;
        }
        public static DataTable ID_DocGiaMax()
        {
            string sTruyVan = string.Format("select Max(IdThe) from tblDocGia");
            con = DataProvider.KetNoi();
            DataTable dt = DataProvider.LayData(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt;
        }
        public static bool SearchDocGia(string tim)
        {
            con = DataProvider.KetNoi();
            string sTruyVan = string.Format("Select a.IdThe N'Mã thẻ',a.Hoten N'Họ Tên',a.DiaChi N'Địa Chỉ', a.Email, a.Sdt N'Điện Thoại', a.LoaiThe N'Loại Thẻ', a.TrangThai N'Trạng Thái' from tblDocGia a where HoTen like N'%" + tim + "%' or DiaChi like N'%" + tim + "%' or Email like '%" + tim + "%' or LoaiThe like N'%" + tim + "%' or TrangThai like N'%" + tim + "%'");
            DataProvider.ThucThiTruyVan(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return true;
        }
    }
}
