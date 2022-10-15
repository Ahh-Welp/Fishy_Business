using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishy_Business
{
    public partial class FrmStart : Form
    {
        private Rectangle titleRec;
        public Image Title;
        public string display = "display1";

        private void General_MouseClick(object sender, MouseEventArgs e)
        {
            if (display == "display1")
            {
                TmrChange.Enabled = true;
                Lbl1.Text = "As you continue through the seasons, the fish will become more aware of your presence," + Environment.NewLine + "and you'll have less time to catch them." + Environment.NewLine + "When you see a ( ! ), press the space bar to catch the fish." + Environment.NewLine + "" + Environment.NewLine + "You can view all this information again by pressing ( i ).";
                Lbl2.Text = "Click anywhere to start the game.";
            }

            if (display == "display2")
            {
                this.Close();
                new FishyFrm().Show();
            }
        }


        public FrmStart()
        {
            InitializeComponent();
            Lbl1.Text = "Welcome to Goin' Fishing!" + Environment.NewLine + "" + Environment.NewLine + "Your aim is to become a master fisher and catch every single fish. Each season has four" + Environment.NewLine + "different fish to catch, and once you catch all four fish, the season will change. Make sure" + Environment.NewLine + "to not run out of bait though! Duplicate fish can be used to create more bait." + Environment.NewLine + "" + Environment.NewLine + "You can view all fish you have caught in your enclyclopaedia by pressing E or clicking on" + Environment.NewLine + "the encyclopaedia button.";
            Lbl2.Text = "Click anywhere to continue";
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

    }
}

