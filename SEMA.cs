using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaInterface
{
    public partial class Sema : Form
    {
        public Sema()
        {
            InitializeComponent();
        }

        private void Sema_Load(object sender, EventArgs e)
        {

        }

        private void tab_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = (WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal);
        }
    }
}
