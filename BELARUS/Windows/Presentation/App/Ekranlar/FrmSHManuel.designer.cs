namespace BELARUS.App.Ekranlar
{
    partial class FrmSHManuel
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
            this.tlStrUstMenu = new System.Windows.Forms.ToolStrip();
            this.TlStrpBtnBaslat = new System.Windows.Forms.ToolStripButton();
            this.TlStrpBtnDurdur = new System.Windows.Forms.ToolStripButton();
            this.stAltBar = new System.Windows.Forms.StatusStrip();
            this.LblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlStrpBarIslem = new System.Windows.Forms.ToolStripProgressBar();
            this.FaIslemler = new BELARUS.Win.FATabStrip();
            this.PnlGecmis = new BELARUS.Win.FATabStripItem();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.BNListe = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FaCekimIslemleri = new BELARUS.Win.FATabStripItem();
            this.GrdListe = new System.Windows.Forms.DataGridView();
            this.tlStrUstMenu.SuspendLayout();
            this.stAltBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaIslemler)).BeginInit();
            this.FaIslemler.SuspendLayout();
            this.PnlGecmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNListe)).BeginInit();
            this.BNListe.SuspendLayout();
            this.FaCekimIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // tlStrUstMenu
            // 
            this.tlStrUstMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tlStrUstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlStrpBtnBaslat,
            this.TlStrpBtnDurdur});
            this.tlStrUstMenu.Location = new System.Drawing.Point(0, 0);
            this.tlStrUstMenu.Name = "tlStrUstMenu";
            this.tlStrUstMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tlStrUstMenu.Size = new System.Drawing.Size(1797, 31);
            this.tlStrUstMenu.TabIndex = 23;
            this.tlStrUstMenu.Text = "toolStrip1";
            // 
            // TlStrpBtnBaslat
            // 
            this.TlStrpBtnBaslat.Image = global::BELARUS.App.Icons.Baslat;
            this.TlStrpBtnBaslat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnBaslat.Name = "TlStrpBtnBaslat";
            this.TlStrpBtnBaslat.Size = new System.Drawing.Size(77, 28);
            this.TlStrpBtnBaslat.Text = "Başlat";
            this.TlStrpBtnBaslat.Click += new System.EventHandler(this.TlStrpBtnBaslat_Click);
            // 
            // TlStrpBtnDurdur
            // 
            this.TlStrpBtnDurdur.Image = global::BELARUS.App.Icons.Durdur;
            this.TlStrpBtnDurdur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TlStrpBtnDurdur.Name = "TlStrpBtnDurdur";
            this.TlStrpBtnDurdur.Size = new System.Drawing.Size(83, 28);
            this.TlStrpBtnDurdur.Text = "Durdur";
            this.TlStrpBtnDurdur.Click += new System.EventHandler(this.TlStrpBtnDurdur_Click);
            // 
            // stAltBar
            // 
            this.stAltBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.stAltBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblDurum,
            this.TlStrpBarIslem});
            this.stAltBar.Location = new System.Drawing.Point(0, 974);
            this.stAltBar.Name = "stAltBar";
            this.stAltBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stAltBar.Size = new System.Drawing.Size(1797, 34);
            this.stAltBar.TabIndex = 22;
            this.stAltBar.Text = "statusStrip1";
            // 
            // LblDurum
            // 
            this.LblDurum.Image = global::BELARUS.App.Icons.DurumBilgi;
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(24, 28);
            // 
            // TlStrpBarIslem
            // 
            this.TlStrpBarIslem.Name = "TlStrpBarIslem";
            this.TlStrpBarIslem.Size = new System.Drawing.Size(400, 26);
            // 
            // FaIslemler
            // 
            this.FaIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FaIslemler.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FaIslemler.Items.AddRange(new BELARUS.Win.FATabStripItem[] {
            this.PnlGecmis,
            this.FaCekimIslemleri});
            this.FaIslemler.Location = new System.Drawing.Point(0, 31);
            this.FaIslemler.Name = "FaIslemler";
            this.FaIslemler.SelectedItem = this.FaCekimIslemleri;
            this.FaIslemler.Size = new System.Drawing.Size(1797, 943);
            this.FaIslemler.TabIndex = 24;
            this.FaIslemler.Text = "faTabStrip1";

            // 
            // PnlGecmis
            // 
            this.PnlGecmis.CanClose = false;
            this.PnlGecmis.Controls.Add(this.txtLog);
            this.PnlGecmis.Controls.Add(this.BNListe);
            this.PnlGecmis.IsDrawn = true;
            this.PnlGecmis.Name = "PnlGecmis";
            this.PnlGecmis.Size = new System.Drawing.Size(1795, 922);
            this.PnlGecmis.TabIndex = 1;
            this.PnlGecmis.Title = "Geçmiş";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1795, 895);
            this.txtLog.TabIndex = 32;
            this.txtLog.Text = "";
            // 
            // BNListe
            // 
            this.BNListe.AddNewItem = null;
            this.BNListe.CountItem = this.bindingNavigatorCountItem;
            this.BNListe.DeleteItem = null;
            this.BNListe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BNListe.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.BNListe.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.BNListe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.BNListe.Location = new System.Drawing.Point(0, 895);
            this.BNListe.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BNListe.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BNListe.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BNListe.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BNListe.Name = "BNListe";
            this.BNListe.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BNListe.PositionItem = this.bindingNavigatorPositionItem;
            this.BNListe.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BNListe.Size = new System.Drawing.Size(1795, 27);
            this.BNListe.TabIndex = 29;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // FaCekimIslemleri
            // 
            this.FaCekimIslemleri.Controls.Add(this.GrdListe);
            this.FaCekimIslemleri.IsDrawn = true;
            this.FaCekimIslemleri.Name = "FaCekimIslemleri";
            this.FaCekimIslemleri.Selected = true;
            this.FaCekimIslemleri.Size = new System.Drawing.Size(1795, 922);
            this.FaCekimIslemleri.TabIndex = 2;
            this.FaCekimIslemleri.Title = "Çekim İşlemleri";
            // 
            // GrdListe
            // 
            this.GrdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdListe.Location = new System.Drawing.Point(0, 0);
            this.GrdListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrdListe.Name = "GrdListe";
            this.GrdListe.RowHeadersWidth = 62;
            this.GrdListe.RowTemplate.Height = 28;
            this.GrdListe.Size = new System.Drawing.Size(1795, 922);
            this.GrdListe.TabIndex = 0;
            // 
            // FrmSHManuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 1008);
            this.Controls.Add(this.FaIslemler);
            this.Controls.Add(this.tlStrUstMenu);
            this.Controls.Add(this.stAltBar);
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "FrmSHManuel";
            this.Text = "Bittorent Sistem Takibi";
            this.Load += new System.EventHandler(this.FrmEslestirme_Load);
            this.tlStrUstMenu.ResumeLayout(false);
            this.tlStrUstMenu.PerformLayout();
            this.stAltBar.ResumeLayout(false);
            this.stAltBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FaIslemler)).EndInit();
            this.FaIslemler.ResumeLayout(false);
            this.PnlGecmis.ResumeLayout(false);
            this.PnlGecmis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNListe)).EndInit();
            this.BNListe.ResumeLayout(false);
            this.BNListe.PerformLayout();
            this.FaCekimIslemleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tlStrUstMenu;
        private System.Windows.Forms.StatusStrip stAltBar;
        private System.Windows.Forms.ToolStripStatusLabel LblDurum;
        private System.Windows.Forms.ToolStripButton TlStrpBtnBaslat;
        private System.Windows.Forms.ToolStripButton TlStrpBtnDurdur;
        private System.Windows.Forms.ToolStripProgressBar TlStrpBarIslem;
        private Win.FATabStrip FaIslemler;
        private Win.FATabStripItem PnlGecmis;
        private System.Windows.Forms.BindingNavigator BNListe;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.RichTextBox txtLog;
        private Win.FATabStripItem FaCekimIslemleri;
        private System.Windows.Forms.DataGridView GrdListe;
    }
}