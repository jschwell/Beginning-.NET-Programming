using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuition_Increase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Declare constants
            const decimal STARTING_TUITION = 6000.00m;
            const decimal INCREASE_RATE = 0.02m;
            const int ENDING_YEAR = 5;

            // Local variables
            int years;
            decimal tuition;

            tuition = STARTING_TUITION;

            // Calculate tuition during next five years
            for (years = 1; years <= ENDING_YEAR; years++)
            {
                // Calculate the year's tuition
                tuition += (tuition * INCREASE_RATE);

                // Add the year's tuition to ListBox
                lbTuition.Items.Add("Year " + years + " - Projected Tuition: " + tuition.ToString("c"));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
