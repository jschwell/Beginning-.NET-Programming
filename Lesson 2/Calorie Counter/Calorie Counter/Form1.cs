using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Counter
{
    public partial class Form1 : Form
    {
        // Field variables.
        private const int BANANA_CALORIES = 115;
        private const int APPLE_CALORIES = 80;
        private const int ORANGE_CALORIES = 90;
        private const int PEAR_CALORIES = 120;

        private int total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ibBanana_Click(object sender, EventArgs e)
        {
            // Add the calories for the banana.
            total += BANANA_CALORIES;

            // Display the total.
            lblTotalCalories.Text = total.ToString();
        }

        private void ibApple_Click(object sender, EventArgs e)
        {
            // Add the calories for the apple.
            total += APPLE_CALORIES;

            // Display the total.
            lblTotalCalories.Text = total.ToString();
        }

        private void ibOrange_Click(object sender, EventArgs e)
        {
            // Add the calories for the orange.
            total += ORANGE_CALORIES;

            // Display the total.
            lblTotalCalories.Text = total.ToString();
        }

        private void ibPear_Click(object sender, EventArgs e)
        {
            // Add the calories for the pear.
            total += PEAR_CALORIES;

            // Display the total.
            lblTotalCalories.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset total to 0.
            total = 0;

            // Display 0
            lblTotalCalories.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
