namespace QuanLySach
{
    partial class frmTraSach
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
            this.pn = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbAnBan = new System.Windows.Forms.RadioButton();
            this.rdbDocGia = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvAnBan = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAnBan = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.colIDAnBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDThe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnBan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.Controls.Add(this.btnHoanTat);
            this.pn.Controls.Add(this.rdbDocGia);
            this.pn.Controls.Add(this.rdbAnBan);
            this.pn.Controls.Add(this.btnTimKiem);
            this.pn.Controls.Add(this.txtTimKiem);
            this.pn.Controls.Add(this.label1);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1055, 77);
            this.pn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1055, 348);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(216, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(187, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(426, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbAnBan
            // 
            this.rdbAnBan.AutoSize = true;
            this.rdbAnBan.Location = new System.Drawing.Point(216, 54);
            this.rdbAnBan.Name = "rdbAnBan";
            this.rdbAnBan.Size = new System.Drawing.Size(59, 17);
            this.rdbAnBan.TabIndex = 3;
            this.rdbAnBan.TabStop = true;
            this.rdbAnBan.Text = "Ấn bản";
            this.rdbAnBan.UseVisualStyleBackColor = true;
            // 
            // rdbDocGia
            // 
            this.rdbDocGia.AutoSize = true;
            this.rdbDocGia.Location = new System.Drawing.Point(341, 54);
            this.rdbDocGia.Name = "rdbDocGia";
            this.rdbDocGia.Size = new System.Drawing.Size(62, 17);
            this.rdbDocGia.TabIndex = 4;
            this.rdbDocGia.TabStop = true;
            this.rdbDocGia.Text = "Độc giả";
            this.rdbDocGia.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvAnBan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(788, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 348);
            this.panel3.TabIndex = 0;
            // 
            // lsvAnBan
            // 
            this.lsvAnBan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDAnBan,
            this.colTenSach,
            this.colIDThe});
            this.lsvAnBan.ContextMenuStrip = this.contextMenuStrip2;
            this.lsvAnBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAnBan.Location = new System.Drawing.Point(0, 0);
            this.lsvAnBan.Name = "lsvAnBan";
            this.lsvAnBan.Size = new System.Drawing.Size(267, 348);
            this.lsvAnBan.TabIndex = 0;
            this.lsvAnBan.UseCompatibleStateImageBehavior = false;
            this.lsvAnBan.View = System.Windows.Forms.View.Details;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvAnBan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(788, 348);
            this.panel4.TabIndex = 2;
            // 
            // dgvAnBan
            // 
            this.dgvAnBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnBan.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAnBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAnBan.Location = new System.Drawing.Point(0, 0);
            this.dgvAnBan.MultiSelect = false;
            this.dgvAnBan.Name = "dgvAnBan";
            this.dgvAnBan.ReadOnly = true;
            this.dgvAnBan.RowHeadersVisible = false;
            this.dgvAnBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnBan.Size = new System.Drawing.Size(788, 348);
            this.dgvAnBan.TabIndex = 0;
            this.dgvAnBan.Click += new System.EventHandler(this.dgvAnBan_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(91, 26);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(97, 26);
            // 
            // trảToolStripMenuItem
            // 
            this.trảToolStripMenuItem.Name = "trảToolStripMenuItem";
            this.trảToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trảToolStripMenuItem.Text = "Hủy";
            this.trảToolStripMenuItem.Click += new System.EventHandler(this.trảToolStripMenuItem_Click);
            // 
            // trảToolStripMenuItem1
            // 
            this.trảToolStripMenuItem1.Name = "trảToolStripMenuItem1";
            this.trảToolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
            this.trảToolStripMenuItem1.Text = "Trả";
            this.trảToolStripMenuItem1.Click += new System.EventHandler(this.trảToolStripMenuItem1_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(583, 18);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // colIDAnBan
            // 
            this.colIDAnBan.Text = "ID Ấn bản";
            // 
            // colTenSach
            // 
            this.colTenSach.Text = "Tên Sách";
            this.colTenSach.Width = 124;
            // 
            // colIDThe
            // 
            this.colIDThe.Text = "Mã Độc Giả";
            this.colIDThe.Width = 78;
            // 
            // frmTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn);
            this.Name = "frmTraSach";
            this.Text = "frmTraSach";
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnBan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.RadioButton rdbDocGia;
        private System.Windows.Forms.RadioButton rdbAnBan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvAnBan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvAnBan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trảToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem trảToolStripMenuItem;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.ColumnHeader colIDAnBan;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colIDThe;
    }
}