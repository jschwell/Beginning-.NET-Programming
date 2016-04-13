using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calories_from_Fat_and_Carbs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double FatCalories(double fatGrams)
        {
            // Calculate and return fat calories.
            return fatGrams * 9;
        }
        
        private double CarbCalories(double carbGrams)
        {
            // Calculate and return carb calories.
            return carbGrams * 4;
        }

        private bool InputIsValid(ref double fatGrams, ref double carbGrams)
        {
            // Flag variable to indicate whether the input is good.
            bool inputGood = false;

            // Test out both variables
            if (double.TryParse(txtFatGrams.Text, out fatGrams))
            {
                if(fatGrams >= 0)
                {
                    if (double.TryParse(txtCarbGrams.Text, out carbGrams))
                    {
                        if(carbGrams >= 0)
                        {
                            // Both inputs are good.
                            inputGood = true;
                        }
                        else
                        {
                            // Display an error message for carbGrams.
                            MessageBox.Show("Please enter a positive number for Carbohydrate Grams.");
                        }
                    }
                    else
                    {
                        // Display an error message for carbGrams.
                        MessageBox.Show("Please enter a valid number for Carbohydrate Grams.");
                    }
                }
                else
                {
                    // Display an error message for fatGrams.
                    MessageBox.Show("Please enter a positive number for Fat Grams.");
                }
            }
            else
            {
                // Display an error message for fatGrams.
                MessageBox.Show("Please enter a valid number for Fat Grams.");
            }

            return inputGood;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
            double fatGrams = 0.0;
            double carbGrams = 0.0;
            double fatCalories;
            double carbCalories;

            if (InputIsValid(ref fatGrams, ref carbGrams))
            {
                // Get the calories from fat.
                fatCalories = FatCalories(fatGrams);

                // Get the calories from carbs.
                carbCalories = CarbCalories(carbGrams);

                // Display results.
                lblFatCalories.Text = fatCalories.ToString();
                lblCarbCalories.Text = carbCalories.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and labels.
            txtFatGrams.Text = "";
            txtCarbGrams.Text = "";
            lblFatCalories.Text = "";
            lblCarbCalories.Text = "";

            // Reset focus.
            txtFatGrams.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
