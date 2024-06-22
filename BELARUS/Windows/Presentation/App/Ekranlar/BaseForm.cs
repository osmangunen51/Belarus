using System;
using System.Windows.Forms;

namespace BELARUS.App.Ekranlar
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}