namespace QuanLySach
{
    partial class frmMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDThe = new System.Windows.Forms.TextBox();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.grp = new System.Windows.Forms.GroupBox();
            this.lsvSachMuon = new System.Windows.Forms.ListView();
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.grp.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpHanTra);
            this.panel1.Controls.Add(this.btnHoanThanh);
            this.panel1.Controls.Add(this.txtIDThe);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Thẻ";
            // 
            // txtIDThe
            // 
            this.txtIDThe.Location = new System.Drawing.Point(93, 16);
            this.txtIDThe.Name = "txtIDThe";
            this.txtIDThe.Size = new System.Drawing.Size(163, 20);
            this.txtIDThe.TabIndex = 1;
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Location = new System.Drawing.Point(523, 13);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(75, 23);
            this.btnHoanThanh.TabIndex = 2;
            this.btnHoanThanh.Text = "Hoàn tất";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(628, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 445);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 445);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 445);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSoLuong);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnTimKiem);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(622, 39);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvSach);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(622, 387);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(90, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(163, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(280, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(520, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(424, 8);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(76, 20);
            this.txtSoLuong.TabIndex = 6;
            // 
            // dgvSach
            // 
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSach.Location = new System.Drawing.Point(0, 0);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(622, 387);
            this.dgvSach.TabIndex = 0;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.lsvSachMuon);
            this.grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp.Location = new System.Drawing.Point(0, 0);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(341, 445);
            this.grp.TabIndex = 0;
            this.grp.TabStop = false;
            this.grp.Text = "Sách mượn";
            // 
            // lsvSachMuon
            // 
            this.lsvSachMuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colTenSach,
            this.colSoLuong});
            this.lsvSachMuon.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvSachMuon.FullRowSelect = true;
            this.lsvSachMuon.GridLines = true;
            this.lsvSachMuon.Location = new System.Drawing.Point(3, 16);
            this.lsvSachMuon.Name = "lsvSachMuon";
            this.lsvSachMuon.Size = new System.Drawing.Size(335, 426);
            this.lsvSachMuon.TabIndex = 0;
            this.lsvSachMuon.UseCompatibleStateImageBehavior = false;
            this.lsvSachMuon.View = System.Windows.Forms.View.Details;
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên sách";
            this.colTenSach.Width = 200;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 68;
            // 
            // colID
            // 
            this.colID.Text = "Mã sách";
            this.colID.Width = 63;
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(375, 16);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(128, 20);
            this.dtpHanTra.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày trả";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 26);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 496);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMuonSach";
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.frmMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.grp.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.ListView lsvSachMuon;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}

