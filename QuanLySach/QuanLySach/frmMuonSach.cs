using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QuanLySach
{
    public partial class frmMuonSach : Form
    {
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            LoadDuLieuSach();
        }
        private void LoadDuLieuSach()
        {
            dgvSach.DataSource = DauSachDAO.LoadSach();
            dgvSach.Columns["IDSach"].HeaderText = "Mã sách";
            dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
            dgvSach.Columns["TenTacGia"].HeaderText = "Tên tác giả";
            dgvSach.Columns["TheLoaiSach"].HeaderText = "Thể loại sách";
            dgvSach.Columns["NgonNgu"].HeaderText = "Ngôn ngữ";
            dgvSach.Columns["Gia"].HeaderText = "Giá";
            dgvSach.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvSach.Columns["SoLuongConLai"].HeaderText = "Số lượng còn lại";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("Yêu cầu chọn số lượng");
                return;
            }
            DataGridViewRow dgvr = dgvSach.SelectedRows[0];
            ListViewItem lvi = new ListViewItem(dgvr.Cells["IDSach"].Value.ToString());
            lvi.SubItems.Add(dgvr.Cells["TenSach"].Value.ToString());
            lvi.SubItems.Add(txtSoLuong.Text);
            lsvSachMuon.Items.Add(lvi);
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lsvSachMuon.Items)
            {
                ThonTinMuonTraDTO ttmt = new ThonTinMuonTraDTO();
                ttmt.IDSach = int.Parse(item.SubItems[0].ToString());
                ttmt.IDThe = int.Parse(txtIDThe.Text);
                ttmt.NgayHenTra = dtpHanTra.Value;
                ttmt.SoLuong = int.Parse(item.SubItems[2].ToString());
                ThongTinMuonTraDAO.ThemThongTinMuon(ttmt);
            }
            this.Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lsvSachMuon.Items.Remove(lsvSachMuon.SelectedItems[0]);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Chọn mục cần xóa");
            }
           
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
