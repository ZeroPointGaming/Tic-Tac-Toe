using System;using System.Collections.Generic;using System.ComponentModel;using System.Data;using System.Drawing;using System.Linq;using System.Text;using System.Threading.Tasks;using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form
    {
        bool CurrentPlayer = true; int TurnTicker = 0;
        public Form1() { InitializeComponent(); }

        private void ButtonClicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (CurrentPlayer)
                btn.Text = "X";
            else
                btn.Text = "O";

            CurrentPlayer = !CurrentPlayer;
            btn.Enabled = false;
            TurnTicker++;

            CheckForWin();
        }

        private void CheckForWin()
        {
            bool Winner = false;

            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                Winner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                Winner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                Winner = true;

            else if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                Winner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                Winner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                Winner = true;

            else if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                Winner = true;
            else if ((c1.Text == b2.Text) && (b2.Text == a3.Text) && (!a3.Enabled))
                Winner = true;

            if (Winner)
            {
                DisabledBtns();

                string wnr = "";
                if (CurrentPlayer)
                    wnr = "O";
                else
                    wnr = "X";

                MessageBox.Show(wnr + " Is the winner!");
            }
            else {
                if(TurnTicker == 9)
                    MessageBox.Show("The game is a Draw!");
                   }
        }

        private void DisabledBtns() { try { foreach (Control c in Controls) { Button btn = (Button)c; btn.Enabled = false; btnNew.Enabled = true; btnAbout.Enabled = true; } } catch { } }
        private void btnNew_Click(object sender, EventArgs e) { a1.Enabled = true; a1.Text = ""; a2.Enabled = true; a2.Text = ""; a3.Enabled = true; a3.Text = ""; b1.Enabled = true; b1.Text = ""; b2.Enabled = true; b2.Text = ""; b3.Enabled = true; b3.Text = ""; c1.Enabled = true; c1.Text = ""; c2.Enabled = true; c2.Text = ""; c3.Enabled = true; c3.Text = ""; TurnTicker = 0; CurrentPlayer = true; }
        private void btnAbout_Click(object sender, EventArgs e) { MessageBox.Show("Designed By Lord Comfy in collaboration with DeadMan Development", "About"); }
    }}
