using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            // If both reds are checked, make the background color red.
            if (rbFirstRed.Checked && rbSecondRed.Checked)
            {
                this.BackColor = Color.Red;
            }

            // If red and blue are checked, make the background color purple.
            else if ((rbFirstRed.Checked && rbSecondBlue.Checked) || (rbFirstBlue.Checked && rbSecondRed.Checked))
            {
                this.BackColor = Color.Purple;
            }

            // If red and yellow are checked, make the background color orange.
            else if ((rbFirstRed.Checked && rbSecondYellow.Checked) || (rbFirstYellow.Checked && rbSecondRed.Checked))
            {
                this.BackColor = Color.Orange;
            }

            // If both blues are checked, make the background color blue.
            else if (rbFirstBlue.Checked && rbSecondBlue.Checked)
            {
                this.BackColor = Color.Blue;
            }

            // If blue and yellow are checked, make the background color green.
            else if ((rbFirstBlue.Checked && rbSecondYellow.Checked) || (rbFirstYellow.Checked && rbSecondBlue.Checked))
            {
                this.BackColor = Color.Green;
            }

            // If both yellows are checked, make the background color yellow.
            else if (rbFirstYellow.Checked && rbSecondYellow.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
