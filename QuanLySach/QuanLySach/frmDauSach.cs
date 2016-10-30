using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace QuanLySach
{
    public partial class frmDauSach : Form
    {
        enum Luachon
        {
            Them,Sua,Xoa,Luu
        }
        Luachon lc;
        public frmDauSach()
        {
            InitializeComponent();
            btnLuu.Visible = false;
            btnHuy.Visible = false;
        }

        private void SuaHeaaderText()
        {
            dgvSach.Columns["IDSach"].HeaderText = "Mã Sách";
            dgvSach.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvSach.Columns["TenTacGia"].HeaderText = "Tác Giả";
            dgvSach.Columns["TheLoaiSach"].HeaderText = "Thể Loại";
            dgvSach.Columns["NgonNgu"].HeaderText = "Ngôn Ngữ";
            dgvSach.Columns["Gia"].HeaderText = "Giá Mượn";
            dgvSach.Columns["SoLuongConLai"].HeaderText = "Số Lượng Còn Lại";
            dgvSach.Columns["GhiChu"].HeaderText = "Ghi Chú";
        }
        private void LoadDuLieu()
        {
            dgvSach.DataSource = DauSachDAO.LoadSach();
            DataTable dt = (DataTable)dgvSach.DataSource;
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ac.Add(dt.Rows[i][1].ToString());
            }
            txtTimKiem.AutoCompleteCustomSource = ac;
            ReadOnly();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
            SuaHeaaderText();
        }

        private void dgvSach_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvSach.SelectedRows[0];
            txtIDSach.Text = dr.Cells["IDSach"].Value.ToString();
            txtTenSach.Text = dr.Cells["TenSach"].Value.ToString();
            txtTacGia.Text = dr.Cells["TenTacGia"].Value.ToString();
            txtTheLoai.Text = dr.Cells["TheLoaiSach"].Value.ToString();
            txtNgonNgu.Text = dr.Cells["NgonNgu"].Value.ToString();
            txtGiaMuon.Text = dr.Cells["Gia"].Value.ToString();
            txtSoLuong.Text = dr.Cells["SoLuongConLai"].Value.ToString();
            txtGhiChu.Text = dr.Cells["GhiChu"].Value.ToString();
        }
        private void AnButton()
        {
            btnLuu.Visible = true;
            btnHuy.Visible = true;
            btnThem.Visible = false;
            btnXoa.Visible = false;
            btnSua.Visible = false;
        }
        private void HienButton()
        {
            btnLuu.Visible = false;
            btnHuy.Visible = false;
            btnThem.Visible = true;
            btnXoa.Visible = true;
            btnSua.Visible = true;
        }
        private void UnReadOnly()
        {
            txtTenSach.ReadOnly=false;
            txtTacGia.ReadOnly=false;
            txtTheLoai.ReadOnly=false;
            txtNgonNgu.ReadOnly=false;
            txtGiaMuon.ReadOnly = false;
            txtSoLuong.ReadOnly=false;
            txtGhiChu.ReadOnly = false;
        }
        private void ReadOnly()
        {
            txtTenSach.ReadOnly=true;
            txtTacGia.ReadOnly=true;
            txtTheLoai.ReadOnly=true;
            txtNgonNgu.ReadOnly=true;
            txtGiaMuon.ReadOnly = true;
            txtSoLuong.ReadOnly=true;
            txtGhiChu.ReadOnly = true;
        }
        private void Xoatxt()
        {
            txtIDSach.Text = "";
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtTheLoai.Text = "";
            txtNgonNgu.Text = "";
            txtGhiChu.Text = "";
            txtGiaMuon.Text = "";
            txtSoLuong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtIDSach.Text = (DauSachDAO.IDMax() + 1).ToString();
            lc = Luachon.Them;
            AnButton();
            UnReadOnly();
            Xoatxt();
        }
        private void ThemSach()
        {
            DauSachDTO ds = new DauSachDTO();
            ds.IDSach = int.Parse(txtIDSach.Text);
            ds.TenSach = txtTenSach.Text;
            ds.TenTacGia = txtTacGia.Text;
            ds.TheLoaiSach = txtTheLoai.Text;
            ds.NgonNgu = txtNgonNgu.Text;
            ds.Gia = int.Parse(txtGiaMuon.Text);
            ds.SoLuongConLai = int.Parse(txtSoLuong.Text);
            ds.GhiChu = txtGhiChu.Text;
            DauSachDAO.ThemDS(ds);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtIDSach.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn Sách");
                return;
            }
            lc = Luachon.Sua;
            AnButton();
            UnReadOnly();
        }
        private void SuaSach()
        {
            DauSachDTO ds = new DauSachDTO();
            ds.IDSach = int.Parse(txtIDSach.Text);
            ds.TenSach = txtTenSach.Text;
            ds.TenTacGia = txtTacGia.Text;
            ds.TheLoaiSach = txtTheLoai.Text;
            ds.NgonNgu = txtNgonNgu.Text;
            ds.Gia = int.Parse(txtGiaMuon.Text);
            ds.SoLuongConLai = int.Parse(txtSoLuong.Text);
            ds.GhiChu = txtGhiChu.Text;
            DauSachDAO.SuaDS(ds);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDSach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn học sinh");
                return;
            }
            lc = Luachon.Xoa;
            AnButton();
            Xoatxt();
            ReadOnly();

        }
        private void XoaSach()
        {
            DauSachDTO ds = new DauSachDTO();
            ds.IDSach = int.Parse(txtIDSach.Text);
            DauSachDAO.XoaDS(ds);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (txtTenSach.Text == "") kt = false;
            else if (txtTheLoai.Text == "") kt = false;
            else if (txtNgonNgu.Text == "") kt = false;
            else if (txtGiaMuon.Text == "") kt = false;
            else if (txtSoLuong.Text == "") kt = false;
            if (kt == false)
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin");
                return;
            }
            switch (lc)
            {
                case Luachon.Them:
                    ThemSach();
                    LoadDuLieu();
                    break;
                case Luachon.Sua:
                    SuaSach();
                    LoadDuLieu();
                    break;
                case Luachon.Xoa:
                    XoaSach();
                    LoadDuLieu();
                    break;

            }
            HienButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Xoatxt();
            HienButton();
            ReadOnly();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = DauSachDAO.TimKiemSach(txtTimKiem.Text);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGiaMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
