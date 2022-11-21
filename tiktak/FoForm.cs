using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiktak
{
    public partial class FoForm : Form
    {
        public FoForm()
        {
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnJatekKezdes_Click(object sender, EventArgs e)
        {
            JatekForm j = new JatekForm();
            j.Show();
            this.Hide();
        }


    }
}
