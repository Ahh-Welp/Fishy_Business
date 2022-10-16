using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fishy_Business
{
    public partial class FrmStart : Form
    {
        private Rectangle titleRec;
        public Image Title;
        public string display = "display1";
        public string PlayerName;

        public FrmStart()
        {
            InitializeComponent();
            Lbl1.Text = "Welcome to Going Fishin'!" + Environment.NewLine + "" + Environment.NewLine + "Your aim is to become a master fisher and catch every single fish. Each season has four" + Environment.NewLine + "different fish to catch, and once you catch all four fish, the season will change. Make sure" + Environment.NewLine + "to not run out of bait though! Duplicate fish can be used to create more bait." + Environment.NewLine + "" + Environment.NewLine + "You can view all fish you have caught in your enclyclopaedia by pressing E or clicking on" + Environment.NewLine + "the encyclopaedia button.";
        }

        private void PnlStart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //title and season title images
            titleRec = new Rectangle(150, 50, 350, 100);
            Title = Properties.Resources.Title;
            g.DrawImage(Title, titleRec);

        }
        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }

        private void TmrChange_Tick(object sender, EventArgs e)
        {
            display = "display2";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (display == "display1")
            {
                TmrChange.Enabled = true;
                TxtName.Visible = true;
                BtnStart.Text = "Start";
                Lbl1.Text = "As you continue through the seasons, the fish will become more aware of your presence," + Environment.NewLine + "and you'll have less time to catch them." + Environment.NewLine + "When you see a ( ! ), press the space bar to catch the fish." + Environment.NewLine + "" + Environment.NewLine + "You can view all this information again by pressing ( i )." + Environment.NewLine + "" + Environment.NewLine + "Please enter name to begin. Only whitespace and letters allowed.";
            }

            if (display == "display2")
            {
                PlayerName = TxtName.Text;
                if (PlayerName == "") //if player name is empty
                {
                    MessageBox.Show("Please enter a name!"); 
                    TxtName.Focus();
                }
                else //if player name is valid
                {
                    this.Close(); //closes form
                    new FishyFrm().Show(); //opens main form
                }
            }
        }

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

