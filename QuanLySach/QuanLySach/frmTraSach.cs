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
            if (!rdbAnBan.Checked && !rdbDocGia.Checked)
            {
                MessageBox.Show("Yêu cầu bạn chọn thể loại");
            }
            if (rdbAnBan.Checked)
            {
                lc = LuaChon.AnBan;
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.tblDauSach.TenSach.Contains(txtTimKiem.Text) && n.TrangThai == 0).ToList();
            }
            else
            {
                int iddocgia=0;
                int.TryParse(txtTimKiem.Text,out iddocgia);
                if(iddocgia==0)
                {
                    MessageBox.Show("Nhập mã độc giả");
                    return;
                }
                lc = LuaChon.DocGia;
                dgvAnBan.DataSource = database.tblAnBans.Where(n => n.tblPhieuMuon.IDThe == iddocgia).ToList();
            }
            dgvAnBan.Columns["tblDauSach"].Visible = false;
            dgvAnBan.Columns["tblPhieuMuon"].Visible = false;
            dgvAnBan.Columns["tblPhieuTra"].Visible = false;
            dgvAnBan.Columns["IDPhieuTra"].Visible = false;
        }
        tblAnBan anbanselected;
        private void dgvAnBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAnBan.SelectedRows[0];
            anbanselected = (tblAnBan)row.DataBoundItem;
        }

        private void trảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(anbanselected==null)
            {
                MessageBox.Show("Mời bạn chọn ấn bản");
                return;
            }
            ListViewItem item = new ListViewItem(anbanselected.IDAnBan.ToString());
            item.SubItems.Add(anbanselected.tblDauSach.TenSach);
            item.SubItems.Add(anbanselected.tblPhieuMuon.IDThe.ToString());
            lsvAnBan.Items.Add(item);
        }

        private void trảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lsvAnBan.SelectedItems[0];
                lsvAnBan.Items.Remove(item);
            }
            catch
            {
                MessageBox.Show("Yêu cầu bạn chọn sách cần chọn");
            }
          
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in lsvAnBan.Items)
            {
                int idanban = int.Parse(item.SubItems[0].Text);
                tblAnBan ab = database.tblAnBans.SingleOrDefault(n => n.IDAnBan == idanban);
                ab.TrangThai = 1;
                ab.tblPhieuMuon = null;
            }
            database.SaveChanges();
            MessageBox.Show("Đã trả thành công");
            this.Close();
        }
    }
}
