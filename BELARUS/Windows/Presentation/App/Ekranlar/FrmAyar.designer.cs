namespace BELARUS.App.Ekranlar
{
    partial class FrmAyar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyar));
            this.stAltBar = new System.Windows.Forms.StatusStrip();
            this.LblDurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlStrUstMenu = new System.Windows.Forms.ToolStrip();
            this.BtnKaydet = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSistemCalismaZamanAraligi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.stAltBar.SuspendLayout();
            this.tlStrUstMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stAltBar
            // 
            this.stAltBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stAltBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblDurum});
            this.stAltBar.Location = new System.Drawing.Point(0, 1058);
            this.stAltBar.Name = "stAltBar";
            this.stAltBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.stAltBar.Size = new System.Drawing.Size(1475, 26);
            this.stAltBar.TabIndex = 13;
            this.stAltBar.Text = "statusStrip1";
            // 
            // LblDurum
            // 
            this.LblDurum.Image = global::BELARUS.App.Icons.DurumBilgi;
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(20, 20);
            // 
            // tlStrUstMenu
            // 
            this.tlStrUstMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlStrUstMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnKaydet});
            this.tlStrUstMenu.Location = new System.Drawing.Point(0, 0);
            this.tlStrUstMenu.Name = "tlStrUstMenu";
            this.tlStrUstMenu.Size = new System.Drawing.Size(1475, 27);
            this.tlStrUstMenu.TabIndex = 14;
            this.tlStrUstMenu.Text = "toolStrip1";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.Image")));
            this.BtnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(79, 24);
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxtSistemCalismaZamanAraligi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 49);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1047, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Dk.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSistemCalismaZamanAraligi
            // 
            this.TxtSistemCalismaZamanAraligi.Location = new System.Drawing.Point(213, 7);
            this.TxtSistemCalismaZamanAraligi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSistemCalismaZamanAraligi.Name = "TxtSistemCalismaZamanAraligi";
            this.TxtSistemCalismaZamanAraligi.Size = new System.Drawing.Size(824, 22);
            this.TxtSistemCalismaZamanAraligi.TabIndex = 9;
            this.TxtSistemCalismaZamanAraligi.Tag = "AyrSistemCalismaZamanAraligi";
            this.TxtSistemCalismaZamanAraligi.Text = "1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sistem Çalışma Zaman Aralığı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(0, 27);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(1475, 32);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Sistem Ayarları";
            // 
            // FrmAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 1084);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tlStrUstMenu);
            this.Controls.Add(this.stAltBar);
            this.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.Name = "FrmAyar";
            this.Text = "FrmGenelAyarlar";
            this.Load += new System.EventHandler(this.FrmGenelAyarlar_Load);
            this.stAltBar.ResumeLayout(false);
            this.stAltBar.PerformLayout();
            this.tlStrUstMenu.ResumeLayout(false);
            this.tlStrUstMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip stAltBar;
        private System.Windows.Forms.ToolStripStatusLabel LblDurum;
        private System.Windows.Forms.ToolStrip tlStrUstMenu;
        private System.Windows.Forms.ToolStripButton BtnKaydet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox TxtSistemCalismaZamanAraligi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}