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
    public partial class JatekForm : Form
    {
        string[,] tabla = new string[3, 3];

        Button[,] gombok = new Button[3, 3];



        TicTacToe ticTac;
        FoForm fo;
        public JatekForm(FoForm fo)
        {
            InitializeComponent();
            ticTac = new TicTacToe(fo.nev1, fo.nev2);
            //ticTac = new TicTacToe("asdasd", "hfghfgh");
            this.fo = fo;
            lblJatekos1.Text = $"Az első játékos: {fo.nev1}";
            lblJatekos2.Text = $"A második játékos: {fo.nev2}";
            gombok[0, 0] = btn1;
            gombok[0, 1] = btn2;
            gombok[0, 2] = btn3;
            gombok[1, 0] = btn4;
            gombok[1, 1] = btn5;
            gombok[1, 2] = btn6;
            gombok[2, 0] = btn7;
            gombok[2, 1] = btn8;
            gombok[2, 2] = btn9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                     tabla[i, j] = $"";
                    gombok[i, j].Text = "";
                }
            }
            
            

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickedTest(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string nev = ticTac.KiLep();
            if (!ticTac.Gyozelem && !ticTac.Dontetlen)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (btn == gombok[i, j])
                        {

                            if (ticTac.Lepes(i, j))
                            {
                                btn.Text = $"{(nev == fo.nev1 ? 'X' : 'O')}";
                                lblJelenlegi.Text = $"{(nev == fo.nev1 ? fo.nev1 : fo.nev2)}";
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(ticTac.Dontetlen ? "Vége a játéknak, Döntetlen" : $"Vége a játéknak, nyert {ticTac.Nyertes}");
            }
            
            

        }
    }
}
