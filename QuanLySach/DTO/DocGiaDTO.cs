using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocGiaDTO
    {
        private int _IdThe;

        public int IdThe
        {
            get { return _IdThe; }
            set { _IdThe = value; }
        }

        private string _Sdt;

        public string Sdt
        {
            get { return _Sdt; }
            set { _Sdt = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _LoaiThe;

        public string LoaiThe
        {
            get { return _LoaiThe; }
            set { _LoaiThe = value; }
        }
        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
    }
}
