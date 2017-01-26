using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormsXtraTreeList
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            frmTreeListFirstTest form = new frmTreeListFirstTest();
            form.Show();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            frmTreeListMenu form = new frmTreeListMenu();
            form.Show();
        }

        private void btnOpen3_Click(object sender, EventArgs e)
        {
            frmTreeListColumns form = new frmTreeListColumns();
            form.Show();
        }
    }
}
