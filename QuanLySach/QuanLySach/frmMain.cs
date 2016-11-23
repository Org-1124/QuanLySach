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
    public partial class frmMain : Form
    {
        TabPage tab;
        public frmMain()
        {
            InitializeComponent();
        }

        private void thôngTinĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabForm.TabPages.Count != 0) tabForm.TabPages.Remove(tab);
            frmDocGia frm = new frmDocGia();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            
            frm.Dock = DockStyle.Fill;
            tab = new TabPage("Quản lý độc giả                     ");
            tab.Controls.Add(frm);
            tabForm.TabPages.Add(tab);
            frm.Visible = true;
        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabForm.TabPages.Count != 0) tabForm.TabPages.Remove(tab);
            frmDauSach frm = new frmDauSach();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tab = new TabPage("Quản lý đầu sách                 ");
            tab.Controls.Add(frm);
            tabForm.TabPages.Add(tab);
            frm.Visible = true;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabForm.TabPages.Count != 0) tabForm.TabPages.Remove(tab);
            frmMuonSach frm = new frmMuonSach();
            frm.TopLevel = false; 
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tab = new TabPage("Quản lý mượn trả               ");
            tab.Controls.Add(frm);
            tabForm.TabPages.Add(tab);
            frm.Visible = true;
        }

        private void tabForm_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("✖", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            
            e.Graphics.DrawString(this.tabForm.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabForm.TabPages.Count; i++)
            {
                Rectangle r = tabForm.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabForm.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

    }
}
