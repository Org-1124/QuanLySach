using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
namespace DTO
{
    public class ThonTinMuonTraDTO
    {
        private int _iDSach;
        private int _iDThe;

        public int IDSach
        {
            get
            {
                return _iDSach;
            }

            set
            {
                _iDSach = value;
            }
        }

        public int IDThe
        {
            get
            {
                return _iDThe;
            }

            set
            {
                _iDThe = value;
            }
        }

        public string TinhTrang
        {
            get
            {
                return _tinhTrang;
            }

            set
            {
                _tinhTrang = value;
            }
        }

        public int TienDatCoc
        {
            get
            {
                return _tienDatCoc;
            }

            set
            {
                _tienDatCoc = value;
            }
        }

        public DateTime NgayHenTra
        {
            get
            {
                return _ngayHenTra;
            }

            set
            {
                _ngayHenTra = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return _soLuong;
            }

            set
            {
                _soLuong = value;
            }
        }

        private string _tinhTrang;

        private int _tienDatCoc;

        private DateTime _ngayHenTra;

        private int _soLuong;
    }
}
