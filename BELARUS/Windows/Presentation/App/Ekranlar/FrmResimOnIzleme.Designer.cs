
namespace BELARUS.App.Ekranlar
{
    partial class FrmResimOnIzleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResimOnIzleme));
            this.ImgOnIzleme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgOnIzleme)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgOnIzleme
            // 
            this.ImgOnIzleme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgOnIzleme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgOnIzleme.Location = new System.Drawing.Point(0, 0);
            this.ImgOnIzleme.Name = "ImgOnIzleme";
            this.ImgOnIzleme.Size = new System.Drawing.Size(946, 670);
            this.ImgOnIzleme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImgOnIzleme.TabIndex = 16;
            this.ImgOnIzleme.TabStop = false;
            // 
            // FrmResimOnIzleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 670);
            this.Controls.Add(this.ImgOnIzleme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmResimOnIzleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ön İzleme";
            this.Load += new System.EventHandler(this.FrmResimOnIzleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgOnIzleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgOnIzleme;
    }
}