using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTTDll;

namespace tiktak
{
    public partial class FoForm : Form
    {
        public string nev1;
        public string nev2;

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
            if (tbJatekosNev1.Text == "" || tbJatekosNev2.Text == "")
            {
                MessageBox.Show("Kérlek írj bele nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nev1 = tbJatekosNev1.Text;
                nev2 = tbJatekosNev2.Text;
                
                JatekForm j = new JatekForm(this);
                j.Show();
                this.Hide();
            }

            
        }

        private void cbValaszto1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbValaszto1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        

        private void FoForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cbValaszto1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbValaszto1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
