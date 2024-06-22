namespace BELARUS.App
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.StrpStatus = new System.Windows.Forms.StatusStrip();
            this.TlStrpDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlStrpVersiyon = new System.Windows.Forms.ToolStripStatusLabel();
            this.SystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.SystemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SystemTrayMenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemTrayMenuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.TpcIslem = new BELARUS.Win.FATabStrip();
            this.TpPGiris = new BELARUS.Win.FATabStripItem();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnSistemTakipIslemleri = new System.Windows.Forms.Button();
            this.btnUygulamaAyarlari = new System.Windows.Forms.Button();
            this.faTabStripItem2 = new BELARUS.Win.FATabStripItem();
            this.faTabStripItem3 = new BELARUS.Win.FATabStripItem();
            this.StrpStatus.SuspendLayout();
            this.SystemTrayMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).BeginInit();
            this.TpcIslem.SuspendLayout();
            this.TpPGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrpStatus
            // 
            this.StrpStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StrpStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpDurum,
            this.toolStripStatusLabel1,
            this.TlStrpVersiyon});
            this.StrpStatus.Location = new System.Drawing.Point(0, 720);
            this.StrpStatus.Name = "StrpStatus";
            this.StrpStatus.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StrpStatus.Size = new System.Drawing.Size(1003, 26);
            this.StrpStatus.TabIndex = 1;
            this.StrpStatus.Text = "statusStrip1";
            // 
            // TlStrpDurum
            // 
            this.TlStrpDurum.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpDurum.Image")));
            this.TlStrpDurum.Name = "TlStrpDurum";
            this.TlStrpDurum.Size = new System.Drawing.Size(20, 20);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(868, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // TlStrpVersiyon
            // 
            this.TlStrpVersiyon.Image = ((System.Drawing.Image)(resources.GetObject("TlStrpVersiyon.Image")));
            this.TlStrpVersiyon.Name = "TlStrpVersiyon";
            this.TlStrpVersiyon.Size = new System.Drawing.Size(98, 20);
            this.TlStrpVersiyon.Text = "Ver. 1.0.0.5";
            // 
            // SystemTray
            // 
            this.SystemTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SystemTray.ContextMenuStrip = this.SystemTrayMenu;
            this.SystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SystemTray.Icon")));
            this.SystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTray_MouseDoubleClick);
            // 
            // SystemTrayMenu
            // 
            this.SystemTrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SystemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemTrayMenuAc,
            this.SystemTrayMenuCikis});
            this.SystemTrayMenu.Name = "SystemTrayMenu";
            this.SystemTrayMenu.Size = new System.Drawing.Size(109, 52);
            // 
            // SystemTrayMenuAc
            // 
            this.SystemTrayMenuAc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SystemTrayMenuAc.Name = "SystemTrayMenuAc";
            this.SystemTrayMenuAc.Size = new System.Drawing.Size(108, 24);
            this.SystemTrayMenuAc.Text = "Aç";
            this.SystemTrayMenuAc.Click += new System.EventHandler(this.SystemTrayMenuAc_Click);
            // 
            // SystemTrayMenuCikis
            // 
            this.SystemTrayMenuCikis.Name = "SystemTrayMenuCikis";
            this.SystemTrayMenuCikis.Size = new System.Drawing.Size(108, 24);
            this.SystemTrayMenuCikis.Text = "Çıkış";
            this.SystemTrayMenuCikis.Click += new System.EventHandler(this.SystemTrayMenuCikis_Click);
            // 
            // TpcIslem
            // 
            this.TpcIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TpcIslem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.TpcIslem.Items.AddRange(new BELARUS.Win.FATabStripItem[] {
            this.TpPGiris});
            this.TpcIslem.Location = new System.Drawing.Point(0, 0);
            this.TpcIslem.Name = "TpcIslem";
            this.TpcIslem.SelectedItem = this.TpPGiris;
            this.TpcIslem.Size = new System.Drawing.Size(1003, 720);
            this.TpcIslem.TabIndex = 2;
            // 
            // TpPGiris
            // 
            this.TpPGiris.CanClose = false;
            this.TpPGiris.Controls.Add(this.btnCikis);
            this.TpPGiris.Controls.Add(this.btnSistemTakipIslemleri);
            this.TpPGiris.Controls.Add(this.btnUygulamaAyarlari);
            this.TpPGiris.IsDrawn = true;
            this.TpPGiris.Name = "TpPGiris";
            this.TpPGiris.Selected = true;
            this.TpPGiris.Size = new System.Drawing.Size(1001, 699);
            this.TpPGiris.TabIndex = 0;
            this.TpPGiris.Title = "Giriş";
            this.TpPGiris.Paint += new System.Windows.Forms.PaintEventHandler(this.TpPGiris_Paint);
            // 
            // btnCikis
            // 
            this.btnCikis.AutoEllipsis = true;
            this.btnCikis.Image = global::BELARUS.App.Icons._026_finish;
            this.btnCikis.Location = new System.Drawing.Point(318, 40);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(137, 112);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnSistemTakipIslemleri
            // 
            this.btnSistemTakipIslemleri.Image = global::BELARUS.App.Icons._004_favourites;
            this.btnSistemTakipIslemleri.Location = new System.Drawing.Point(20, 40);
            this.btnSistemTakipIslemleri.Name = "btnSistemTakipIslemleri";
            this.btnSistemTakipIslemleri.Size = new System.Drawing.Size(137, 112);
            this.btnSistemTakipIslemleri.TabIndex = 13;
            this.btnSistemTakipIslemleri.Text = "Manuel İşlemler";
            this.btnSistemTakipIslemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSistemTakipIslemleri.UseVisualStyleBackColor = true;
            this.btnSistemTakipIslemleri.Click += new System.EventHandler(this.btnSistemTakipIslemleri_Click);
            // 
            // btnUygulamaAyarlari
            // 
            this.btnUygulamaAyarlari.AutoEllipsis = true;
            this.btnUygulamaAyarlari.Image = global::BELARUS.App.Icons._017_settings;
            this.btnUygulamaAyarlari.Location = new System.Drawing.Point(169, 40);
            this.btnUygulamaAyarlari.Name = "btnUygulamaAyarlari";
            this.btnUygulamaAyarlari.Size = new System.Drawing.Size(137, 112);
            this.btnUygulamaAyarlari.TabIndex = 12;
            this.btnUygulamaAyarlari.Text = "Genel Ayarlar";
            this.btnUygulamaAyarlari.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUygulamaAyarlari.UseVisualStyleBackColor = true;
            this.btnUygulamaAyarlari.Click += new System.EventHandler(this.btnUygulamaAyarlari_Click);
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Selected = true;
            this.faTabStripItem2.Size = new System.Drawing.Size(1145, 648);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "TabStrip Page 2";
            // 
            // faTabStripItem3
            // 
            this.faTabStripItem3.IsDrawn = true;
            this.faTabStripItem3.Name = "faTabStripItem3";
            this.faTabStripItem3.Size = new System.Drawing.Size(1145, 648);
            this.faTabStripItem3.TabIndex = 2;
            this.faTabStripItem3.Title = "TabStrip Page 3";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 746);
            this.Controls.Add(this.TpcIslem);
            this.Controls.Add(this.StrpStatus);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.StrpStatus.ResumeLayout(false);
            this.StrpStatus.PerformLayout();
            this.SystemTrayMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TpcIslem)).EndInit();
            this.TpcIslem.ResumeLayout(false);
            this.TpPGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StrpStatus;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpDurum;
        private System.Windows.Forms.ToolStripStatusLabel TlStrpVersiyon;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private BELARUS.Win.FATabStrip TpcIslem;
        private BELARUS.Win.FATabStripItem TpPGiris;
        private BELARUS.Win.FATabStripItem faTabStripItem2;
        private BELARUS.Win.FATabStripItem faTabStripItem3;
        private System.Windows.Forms.NotifyIcon SystemTray;
        private System.Windows.Forms.ContextMenuStrip SystemTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem SystemTrayMenuAc;
        private System.Windows.Forms.ToolStripMenuItem SystemTrayMenuCikis;
        private System.Windows.Forms.Button btnSistemTakipIslemleri;
        private System.Windows.Forms.Button btnUygulamaAyarlari;
        private System.Windows.Forms.Button btnCikis;
    }
}