using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyrtyvshin
{
    public partial class Mainform : Form
    {
        private MovieForm? _movieForm;
        private StarForm _starForm;

        public Mainform()
        {
            InitializeComponent();
        }

        private void movieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_movieForm == null || _movieForm.IsDisposed)
            {
                _movieForm = new MovieForm();
                _movieForm.MdiParent = this;
                _movieForm.FormClosed += (s, args) => _movieForm = null;
                _movieForm.WindowState = FormWindowState.Maximized;
                _movieForm.Show();
            }
            else
            {
                _movieForm.BringToFront();
                _movieForm.Focus();
            }
        }

        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_starForm == null || _starForm.IsDisposed)
            {
                _starForm = new StarForm();
                _starForm.MdiParent = this;
                _starForm.FormClosed += (s, args) => _starForm = null;
                _starForm.WindowState = FormWindowState.Maximized;
                _starForm.Show();
            }
            else
            {
                _starForm.BringToFront();
                _starForm.Focus();
            }
        }
    }
}
