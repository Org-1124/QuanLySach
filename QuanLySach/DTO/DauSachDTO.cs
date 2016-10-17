using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DauSachDTO
    {
        private int _IDSach;
        public int IDSach
        {
            get { return _IDSach; }
            set { _IDSach = value; }
        }
        private string _TenSach;

        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }
        private string _TenTacGia;

        public string TenTacGia
        {
            get { return _TenTacGia; }
            set { _TenTacGia = value; }
        }
        private string _TheLoaiSach;

        public string TheLoaiSach
        {
            get { return _TheLoaiSach; }
            set { _TheLoaiSach = value; }
        }
        private string _NgonNgu;
        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }
        private int _Gia;
        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        private string _GhiChu;
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        private int _SoLuongConLai;
        public int SoLuongConLai
        {
            get { return _SoLuongConLai; }
            set { _SoLuongConLai = value; }
        }
    }
}
