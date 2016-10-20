using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace QuanLySach
{
    public partial class frmDocGia : Form
    {
        public frmDocGia()
        {
            InitializeComponent();
            dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
            SetHeaderColumn();
            btnluu.Visible = false;
        }
        int luu = 0;
        public void SetHeaderColumn()
        {
            dgvDocGia.Columns["IdThe"].HeaderText = "Mã Thẻ";
            dgvDocGia.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvDocGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvDocGia.Columns["Email"].HeaderText = "Email";
            dgvDocGia.Columns["Sdt"].HeaderText = "Điện Thoại";
            dgvDocGia.Columns["LoaiThe"].HeaderText = "Loại Thẻ";
            dgvDocGia.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void LamMoi()
        {
            txthoten.Text = ""; txtsdt.Text = "";
            txtdiachi.Text = ""; txttrangthai.Text = "";
            txtemail.Text = "";
            txtloaithe.Text = "";
        }

        private void dgvDocGia_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvDocGia.SelectedRows[0];
            txtidthe.Text = dr.Cells["IdThe"].Value.ToString();
            txtdiachi.Text = dr.Cells["DiaChi"].Value.ToString();
            txtemail.Text = dr.Cells["Email"].Value.ToString();
            txthoten.Text = dr.Cells["HoTen"].Value.ToString();
            txtloaithe.Text = dr.Cells["LoaiThe"].Value.ToString();
            txtsdt.Text = dr.Cells["Sdt"].Value.ToString();
            txttrangthai.Text = dr.Cells["TrangThai"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnluu.Visible = true;
            txtidthe.Enabled = false;
            LamMoi();
            DataTable maxid = new DataTable();
            maxid = DocGiaDAO.ID_DocGiaMax();
            int iddg = (int)maxid.Rows[0][0];
            iddg++;
            txtidthe.Text = iddg.ToString();
            luu = 1;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtidthe.Text == "")
                MessageBox.Show("Bạn chưa chọn độc giả cần sửa");
            btnluu.Visible = true;
            txtidthe.Enabled = false;
            luu = 2;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (luu == 0)
            {
                MessageBox.Show("Bạn chưa thao tác");
            }
            else
            {
                DocGiaDTO dg = new DocGiaDTO();
                dg.IdThe = int.Parse(txtidthe.Text);
                dg.HoTen = txthoten.Text;
                dg.Email = txtemail.Text;
                dg.DiaChi = txtdiachi.Text;
                dg.LoaiThe = txtloaithe.Text;
                dg.Sdt = txtsdt.Text;
                dg.TrangThai = txttrangthai.Text;
                if (luu == 1)
                {
                    DocGiaDAO.ThemDocGia(dg);
                    dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
                    MessageBox.Show("Thêm thành công");
                }
                if (luu == 2)
                {
                    DocGiaDAO.SuaDocGia(dg);
                    dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
                    MessageBox.Show("Sửa thành công");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtidthe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn ");
            }
            else
            {
                DocGiaDTO dg = new DocGiaDTO();
                dg.IdThe = int.Parse(txtidthe.Text);
                DocGiaDAO.XoaDocGia(dg);
                dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
                MessageBox.Show("Đã xóa thành công");
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "")
            {
                dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
            }
            else
                dgvDocGia.DataSource = DocGiaDAO.SearchDocGia(txttimkiem.Text);
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txttimkiem.Text == "")
                {
                    dgvDocGia.DataSource = DocGiaDAO.LoadDataDocGia();
                }
                else
                    dgvDocGia.DataSource = DocGiaDAO.SearchDocGia(txttimkiem.Text);
            }
        }
    }
}
