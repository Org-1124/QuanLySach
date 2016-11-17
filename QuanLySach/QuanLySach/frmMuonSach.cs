using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class frmMuonSach : Form
    {
        QuanLySachEntities database = new QuanLySachEntities();
        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            if (database.tblPhieuMuons.Count() == 0) txtPhieuMuon.Text = "1";
            else
                txtPhieuMuon.Text = (database.tblPhieuMuons.Max(n => n.IDPhieuMuon) + 1).ToString();
            LoadDuLieu();
            // load combobox
            cboThe.DataSource = database.tblDocGias.ToList();
            cboThe.DisplayMember = "HoTen";
            cboThe.ValueMember = "IDThe";
        }
        void LoadDuLieu()
        {
            dgvAnBan.DataSource = database.tblDauSaches.ToList();
            dgvAnBan.Columns["IDSach"].HeaderText = "ID Sách";
            dgvAnBan.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvAnBan.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvAnBan.Columns["TheLoaiSach"].HeaderText = "Thể Loại Sách";
            dgvAnBan.Columns["NgonNgu"].HeaderText = "Ngôn Ngữ";
            dgvAnBan.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvAnBan.Columns["SoLuongConLai"].HeaderText = "Số lượng còn";
        }
        tblDauSach sc;
        DataGridViewRow row;
        private void dgvAnBan_Click(object sender, EventArgs e)
        {
            row = dgvAnBan.SelectedRows[0];
            sc = (tblDauSach)row.DataBoundItem;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text=="")
            {
                MessageBox.Show("Mời bạn nhập số lượng");
                return;
            }
            if (sc == null)
            {
                MessageBox.Show("Yêu cầu chọn ấn bản");
                return;
            }
            ListViewItem item = new ListViewItem(sc.IDSach.ToString());
            item.SubItems.Add(sc.TenSach);
            item.SubItems.Add(txtSoLuong.Text);
            lsvSachMuon.Items.Add(item);
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem_Click(null, null);
        }
        private void xóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvSachMuon.SelectedItems[0];
                lsvSachMuon.Items.Remove(item);
            }
            catch
            {
                MessageBox.Show("Mời bạn chọn ấn bản cần xóa");
            }
        }
        private void dgvAnBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvAnBan.DataSource = database.tblDauSaches.Where(n => n.TenSach.Contains(txtTimKiem.Text)).ToList();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            tblPhieuMuon pm = new tblPhieuMuon();
            pm.IDPhieuMuon = int.Parse(txtPhieuMuon.Text);
            pm.IDThe = (int)cboThe.SelectedValue;
            pm.NgayMuon = DateTime.Now.Date;
            database.tblPhieuMuons.Add(pm);
            foreach(ListViewItem item in lsvSachMuon.Items)
            {
                int idsach = int.Parse(item.SubItems[0].Text);
                int soluong = int.Parse(item.SubItems[2].Text);
                List<tblAnBan> anbans = database.tblAnBans.Where(n => n.IDSach == idsach ).Take(soluong).ToList();
                // thay doi trang thai cua cac an ban
                foreach(tblAnBan ab in anbans)
                {
                    ab.TrangThai = 0;
                    ab.IDPhieuMuon = int.Parse(txtPhieuMuon.Text);
                }
                tblDauSach dausach = database.tblDauSaches.SingleOrDefault(n => n.IDSach == idsach);
                dausach.SoLuongConLai -= int.Parse(item.SubItems[2].Text);
                if(dausach.SoLuongConLai<0)
                {
                    MessageBox.Show("Số sách lấy phải ít số còn lại trong kho");
                    return;
                }
            }
            database.SaveChanges();
            MessageBox.Show("Hoàn tất mượn sách");
            this.Close();

        }
    }
}
