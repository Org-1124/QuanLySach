namespace QuanLySach
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabForm = new System.Windows.Forms.TabControl();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thôngTinĐộcGiảToolStripMenuItem,
            this.thôngTinSáchToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.trảSáchToolStripMenuItem,
            this.trợGiúpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thôngTinĐộcGiảToolStripMenuItem
            // 
            this.thôngTinĐộcGiảToolStripMenuItem.Name = "thôngTinĐộcGiảToolStripMenuItem";
            this.thôngTinĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.thôngTinĐộcGiảToolStripMenuItem.Text = "Thông tin độc giả";
            this.thôngTinĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thôngTinĐộcGiảToolStripMenuItem_Click);
            // 
            // thôngTinSáchToolStripMenuItem
            // 
            this.thôngTinSáchToolStripMenuItem.Name = "thôngTinSáchToolStripMenuItem";
            this.thôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.thôngTinSáchToolStripMenuItem.Text = "Thông tin sách";
            this.thôngTinSáchToolStripMenuItem.Click += new System.EventHandler(this.thôngTinSáchToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.thôngTinToolStripMenuItem.Text = "Mượn sách";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem1
            // 
            this.trợGiúpToolStripMenuItem1.Name = "trợGiúpToolStripMenuItem1";
            this.trợGiúpToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem1.Text = "Trợ giúp";
            // 
            // tabForm
            // 
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabForm.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabForm.Location = new System.Drawing.Point(0, 24);
            this.tabForm.Name = "tabForm";
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(1251, 585);
            this.tabForm.TabIndex = 1;
            this.tabForm.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabForm_DrawItem);
            this.tabForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabForm_MouseDown);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 609);
            this.Controls.Add(this.tabForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
    }
}

