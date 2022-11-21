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
            if (tbJatekosNev1.Text == "" || tbJatekosNev2.Text == "")
            {
                MessageBox.Show("Kérlek írj bele nevet!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbValaszto1.Text == "" || cbValaszto2.Text == "")
            {
                MessageBox.Show("Kérlek jelöld meg, hogy melyikkel szeretnél lenni", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JatekForm j = new JatekForm();
                j.Show();
                this.Hide();
            }


        }

        private void cbValaszto1_Click(object sender, EventArgs e)
        {
            cbValaszto1.Items.Add("X");
            cbValaszto1.Items.Add("O");
        }

        private void cbValaszto1_SelectedValueChanged(object sender, EventArgs e)
        {
            cbValaszto1.Items.Add("X");
        }

        

        private void FoForm_Load(object sender, EventArgs e)
        {
            cbValaszto1.Items.Add("X");
            cbValaszto1.Items.Add("O");

            cbValaszto2.Items.Add("X");
            cbValaszto2.Items.Add("O");
            
        }

        private void cbValaszto1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbValaszto1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
