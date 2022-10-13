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
        public string TxtDisplay = "1"; //string to change text display
        private Rectangle titleRec;
        public Image Title;

        private void PnlStart_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtDisplay == "1")
            {
                TxtDisplay = "2";
            }
            
            if (TxtDisplay == "2")
            {
                this.Close();
                new FishyFrm().Show();
            }
        }


        public FrmStart()
        {
            InitializeComponent();
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
    }
}

