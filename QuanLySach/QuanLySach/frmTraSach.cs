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
    public partial class frmTraSach : Form
    {
        QuanLySachEntities database = new QuanLySachEntities();
        public frmTraSach()
        {
            InitializeComponent();
        }
        
        enum LuaChon
        {
            AnBan,
            DocGia
        }
        LuaChon lc;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (rdbIDSach.Checked)
            {
                lc = LuaChon.AnBan;
                int idanban = 0;
                int.TryParse(txtTimKiem.Text,out idanban);
                if(idanban==0)
                {
                    MessageBox.Show("Nhập mã ấn bản");
                    return;
                }
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.TrangThai == 0&&n.IDSach==idanban).Select(n => new ViewTraSach { IDAnBan = n.IDAnBan, IDSach = (int)n.IDSach, TenSach = n.tblDauSach.TenSach, TrangThai = n.TrangThai == 0 ? "Đang mượn" : "Có sẵn", IDDocGia = n.tblPhieuMuon.IDThe, TenDocGia = n.tblPhieuMuon.tblDocGia.HoTen }).ToList();
            }
            else if(rdbIDDocGia.Checked)
            {
                int iddocgia=0;
                int.TryParse(txtTimKiem.Text,out iddocgia);
                if(iddocgia==0)
                {
                    MessageBox.Show("Nhập mã độc giả");
                    return;
                }
                lc = LuaChon.DocGia;
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.TrangThai == 0 && n.tblPhieuMuon.IDThe==iddocgia).Select(n => new ViewTraSach { IDAnBan = n.IDAnBan, IDSach = (int)n.IDSach, TenSach = n.tblDauSach.TenSach, TrangThai = n.TrangThai == 0 ? "Đang mượn" : "Có sẵn", IDDocGia = n.tblPhieuMuon.IDThe, TenDocGia = n.tblPhieuMuon.tblDocGia.HoTen }).ToList();
            }
            else if(rdbTenDocGia.Checked)
            {
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.TrangThai == 0 && n.tblPhieuMuon.tblDocGia.HoTen.Contains(txtTimKiem.Text)).Select(n => new ViewTraSach { IDAnBan = n.IDAnBan, IDSach = (int)n.IDSach, TenSach = n.tblDauSach.TenSach, TrangThai = n.TrangThai == 0 ? "Đang mượn" : "Có sẵn", IDDocGia = n.tblPhieuMuon.IDThe, TenDocGia = n.tblPhieuMuon.tblDocGia.HoTen }).ToList();
            }
            else if(rdbTenSach.Checked)
            {
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.TrangThai == 0 && n.tblDauSach.TenSach.Contains(txtTimKiem.Text)).Select(n => new ViewTraSach { IDAnBan = n.IDAnBan, IDSach = (int)n.IDSach, TenSach = n.tblDauSach.TenSach, TrangThai = n.TrangThai == 0 ? "Đang mượn" : "Có sẵn", IDDocGia = n.tblPhieuMuon.IDThe, TenDocGia = n.tblPhieuMuon.tblDocGia.HoTen }).ToList();
            }
            else
            {
                LoadDuLieu();
            }
        }
        ViewTraSach anbanselected;
        private void dgvAnBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAnBan.SelectedRows[0];
            anbanselected = (ViewTraSach)row.DataBoundItem;
        }

        private void trảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(anbanselected==null)
            {
                MessageBox.Show("Mời bạn chọn ấn bản");
                return;
            }
            tblAnBan ab = database.tblAnBans.SingleOrDefault(n => n.IDAnBan == anbanselected.IDAnBan);
            ab.TrangThai = 1;
            tblDauSach s = database.tblDauSaches.SingleOrDefault(n => n.IDSach == anbanselected.IDSach);
            s.SoLuongConLai++;
            database.SaveChanges();
            btnTimKiem_Click(null, null);
            ListViewItem item = new ListViewItem(anbanselected.IDAnBan.ToString());
            item.SubItems.Add(anbanselected.TenSach);
            item.SubItems.Add(anbanselected.IDDocGia.ToString());
            lsvAnBan.Items.Add(item);
            anbanselected = null;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã trả thành công");
        }
        class ViewTraSach
        {
            public int IDAnBan { get; set; }
            public int IDSach { get; set; }
            
            public string TenSach { get; set; }
            public string TrangThai { get; set; }
           
            public int IDDocGia { get; set; }
            public string TenDocGia { get; set; }
           
        }
        private void frmTraSach_Load(object sender, EventArgs e)
        {
            LoadDuLieu();  
        }
        void LoadDuLieu()
        {
            List<ViewTraSach> lst = database.tblAnBans.Where(n => n.TrangThai == 0).Select(n => new ViewTraSach { IDAnBan = n.IDAnBan, IDSach = (int)n.IDSach, TenSach = n.tblDauSach.TenSach, TrangThai = n.TrangThai == 0 ? "Đang mượn" : "Có sẵn", IDDocGia = n.tblPhieuMuon.IDThe, TenDocGia = n.tblPhieuMuon.tblDocGia.HoTen }).ToList();
            dgvAnBan.DataSource = lst;
            dgvAnBan.Columns["IDAnBan"].HeaderText = "Mã ấn bản";
            dgvAnBan.Columns["IDSach"].HeaderText = "Mã sách";
            dgvAnBan.Columns["TenSach"].HeaderText = "Tên sách";
            dgvAnBan.Columns["TrangThai"].HeaderText = "Trạng thái";
            dgvAnBan.Columns["IDDocGia"].HeaderText = "Mã độc giả";
            dgvAnBan.Columns["TenDocGia"].HeaderText = "Tên độc giả";
        }

        private void huyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvAnBan.SelectedItems[0];
                lsvAnBan.Items.Remove(item);
                int idab = int.Parse(item.SubItems[0].Text);
                tblAnBan ab = database.tblAnBans.SingleOrDefault(n => n.IDAnBan == idab);
                ab.TrangThai = 0;
                tblDauSach s = database.tblDauSaches.SingleOrDefault(n => n.IDSach == anbanselected.IDSach);
                s.SoLuongConLai--;
                database.SaveChanges();
                btnTimKiem_Click(null, null);
            }
            catch
            {
                MessageBox.Show("Yêu cầu bạn chọn sách cần chọn");
            }
        }
    }
}
