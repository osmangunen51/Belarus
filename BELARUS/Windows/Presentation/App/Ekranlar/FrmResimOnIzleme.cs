using System;
using System.Drawing;
using System.Windows.Forms;

namespace BELARUS.App.Ekranlar
{
    public partial class FrmResimOnIzleme : Form
    {
        public Image Image { get; set; }
        public FrmResimOnIzleme()
        {
            InitializeComponent();
        }

        private void FrmResimOnIzleme_Load(object sender, EventArgs e)
        {
            ImgOnIzleme.Image = Image;
        }
    }
}
