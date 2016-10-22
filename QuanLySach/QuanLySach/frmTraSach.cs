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
    public partial class frmTraSach : Form
    {
        public frmTraSach()
        {
            InitializeComponent();
        }

        private void frmTraSach_Load(object sender, EventArgs e)
        {
            dgvDanhSachMuonTra.DataSource = ThongTinMuonTraDAO.LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachMuonTra.DataSource = ThongTinMuonTraDAO.TimKiemSachMuon(int.Parse(txtIDThe.Text));
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThonTinMuonTraDTO ttmt = new ThonTinMuonTraDTO();
            ttmt.IDSach = (int)dgvDanhSachMuonTra.SelectedRows[0].Cells["IDSach"].Value;
            ttmt.IDThe = (int)dgvDanhSachMuonTra.SelectedRows[0].Cells["IDThe"].Value;
        }
    }
}
