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
            this.rdbTenDocGia = new System.Windows.Forms.RadioButton();
            this.rdbTenSach = new System.Windows.Forms.RadioButton();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.rdbIDDocGia = new System.Windows.Forms.RadioButton();
            this.rdbIDSach = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvAnBan = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvAnBan = new System.Windows.Forms.ListView();
            this.colIDAnBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIDThe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.huyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnBan)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn
            // 
            this.pn.Controls.Add(this.rdbTenDocGia);
            this.pn.Controls.Add(this.rdbTenSach);
            this.pn.Controls.Add(this.btnHoanTat);
            this.pn.Controls.Add(this.rdbIDDocGia);
            this.pn.Controls.Add(this.rdbIDSach);
            this.pn.Controls.Add(this.btnTimKiem);
            this.pn.Controls.Add(this.txtTimKiem);
            this.pn.Controls.Add(this.label1);
            this.pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn.Location = new System.Drawing.Point(0, 0);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(1055, 77);
            this.pn.TabIndex = 0;
            // 
            // rdbTenDocGia
            // 
            this.rdbTenDocGia.AutoSize = true;
            this.rdbTenDocGia.Location = new System.Drawing.Point(331, 54);
            this.rdbTenDocGia.Name = "rdbTenDocGia";
            this.rdbTenDocGia.Size = new System.Drawing.Size(83, 17);
            this.rdbTenDocGia.TabIndex = 7;
            this.rdbTenDocGia.TabStop = true;
            this.rdbTenDocGia.Text = "Tên độc giả";
            this.rdbTenDocGia.UseVisualStyleBackColor = true;
            // 
            // rdbTenSach
            // 
            this.rdbTenSach.AutoSize = true;
            this.rdbTenSach.Location = new System.Drawing.Point(246, 54);
            this.rdbTenSach.Name = "rdbTenSach";
            this.rdbTenSach.Size = new System.Drawing.Size(70, 17);
            this.rdbTenSach.TabIndex = 6;
            this.rdbTenSach.TabStop = true;
            this.rdbTenSach.Text = "Tên sách";
            this.rdbTenSach.UseVisualStyleBackColor = true;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(639, 19);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(75, 23);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // rdbIDDocGia
            // 
            this.rdbIDDocGia.AutoSize = true;
            this.rdbIDDocGia.Location = new System.Drawing.Point(153, 54);
            this.rdbIDDocGia.Name = "rdbIDDocGia";
            this.rdbIDDocGia.Size = new System.Drawing.Size(76, 17);
            this.rdbIDDocGia.TabIndex = 4;
            this.rdbIDDocGia.TabStop = true;
            this.rdbIDDocGia.Text = "ID Độc giả";
            this.rdbIDDocGia.UseVisualStyleBackColor = true;
            // 
            // rdbIDSach
            // 
            this.rdbIDSach.AutoSize = true;
            this.rdbIDSach.Location = new System.Drawing.Point(79, 54);
            this.rdbIDSach.Name = "rdbIDSach";
            this.rdbIDSach.Size = new System.Drawing.Size(64, 17);
            this.rdbIDSach.TabIndex = 3;
            this.rdbIDSach.TabStop = true;
            this.rdbIDSach.Text = "ID Sách";
            this.rdbIDSach.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(429, 19);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(79, 21);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(335, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
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
            this.dgvAnBan.AllowUserToResizeRows = false;
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
            // trảToolStripMenuItem1
            // 
            this.trảToolStripMenuItem1.Name = "trảToolStripMenuItem1";
            this.trảToolStripMenuItem1.Size = new System.Drawing.Size(90, 22);
            this.trảToolStripMenuItem1.Text = "Trả";
            this.trảToolStripMenuItem1.Click += new System.EventHandler(this.trảToolStripMenuItem1_Click);
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
            this.lsvAnBan.FullRowSelect = true;
            this.lsvAnBan.GridLines = true;
            this.lsvAnBan.HideSelection = false;
            this.lsvAnBan.Location = new System.Drawing.Point(0, 0);
            this.lsvAnBan.MultiSelect = false;
            this.lsvAnBan.Name = "lsvAnBan";
            this.lsvAnBan.Size = new System.Drawing.Size(267, 348);
            this.lsvAnBan.TabIndex = 0;
            this.lsvAnBan.UseCompatibleStateImageBehavior = false;
            this.lsvAnBan.View = System.Windows.Forms.View.Details;
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.huyToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(97, 26);
            // 
            // huyToolStripMenuItem
            // 
            this.huyToolStripMenuItem.Name = "huyToolStripMenuItem";
            this.huyToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.huyToolStripMenuItem.Text = "Hủy";
            this.huyToolStripMenuItem.Click += new System.EventHandler(this.huyToolStripMenuItem_Click);
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
            this.Load += new System.EventHandler(this.frmTraSach_Load);
            this.pn.ResumeLayout(false);
            this.pn.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnBan)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.RadioButton rdbIDDocGia;
        private System.Windows.Forms.RadioButton rdbIDSach;
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
        private System.Windows.Forms.ToolStripMenuItem huyToolStripMenuItem;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.ColumnHeader colIDAnBan;
        private System.Windows.Forms.ColumnHeader colTenSach;
        private System.Windows.Forms.ColumnHeader colIDThe;
        private System.Windows.Forms.RadioButton rdbTenDocGia;
        private System.Windows.Forms.RadioButton rdbTenSach;
    }
}