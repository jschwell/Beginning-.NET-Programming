using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Local variables
            decimal organisms;
            decimal dailyIncrease;
            int days;
            int count = 1;
            
            // Get the starting number of organisms.
            if (decimal.TryParse(txtOrganisms.Text, out organisms))
            {
                // Check to see if organisms is a positive value.
                if (organisms > 0)
                {
                    // Get the average daily increase.
                    if (decimal.TryParse(txtIncrease.Text, out dailyIncrease))
                    {
                        // Get the number of days to multiply.
                        if (int.TryParse(txtDays.Text, out days))
                        {
                            // Check to see if days is a positive value.
                            if (days > 0)
                            {
                                // Clear any previous items in ListBox
                                lbPopulation.Items.Clear();

                                // Calculate the population growth.
                                for (count = 1; count <= days; count++)
                                {
                                    // Display the day's population.
                                    lbPopulation.Items.Add("Day " +
                                        count.ToString("d2") + " - Approximate Population: " + organisms.ToString("n3"));

                                    // Add this day's population growth to number of organisms.
                                    organisms += (organisms * dailyIncrease / 100);
                                }
                            }
                            else
                            {
                                // Number was not positive.
                                MessageBox.Show("Please enter a positive number of days.");
                            }
                        }
                        else
                        {
                            // An integer was not entered.
                            MessageBox.Show("Please enter a valid number of days.");
                        }
                    }
                    else
                    {
                        // A decimal was not entered.
                        MessageBox.Show("Please enter a valid percent.");
                    }
                }
                else
                {
                    // Number was not positive.
                    MessageBox.Show("Please enter a positive number of organisms.");
                }
            }
            else
            {
                // A decimal was not entered.
                MessageBox.Show("Please enter a valid number of organisms.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear TextBoxes and ListBox
            txtOrganisms.Text = "";
            txtIncrease.Text = "";
            txtDays.Text = "";
            lbPopulation.Items.Clear();

            // Set focus to first TextBox
            txtOrganisms.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
