using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number_Guessing_Game
{
    public partial class Form1 : Form
    {
        // Field variables to hold count and random number
        private int count = 0;
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get random number on load.
            Random rand = new Random();
            randomNumber = rand.Next(100) + 1;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Local variables
            int guessedNumber;

            // Get the number guessed
            if (int.TryParse(txtNumber.Text, out guessedNumber))
            {
                // Check if the number is between 1 and 100
                if (guessedNumber >= 1 && guessedNumber <= 100)
                {
                    if (guessedNumber > randomNumber)
                    {
                        // Display number is too high.
                        lblMessage.Text = guessedNumber + " is too high, try again.";

                        // Add 1 to count.
                        count++;
                    }
                    else if (guessedNumber < randomNumber)
                    {
                        // Display number is too low.
                        lblMessage.Text = guessedNumber + " is too low, try again.";

                        // Add 1 to count.
                        count++;
                    }
                    else
                    {
                        // Add 1 to count.
                        count++;

                        // Display number is correct.
                        lblMessage.Text = "Congratulations! " + guessedNumber + " is correct!" +
                            Environment.NewLine + "Number of guesses: " + count;

                        // Generate new random number.
                        Random rand = new Random();
                        randomNumber = rand.Next(100) + 1;

                        // Set count back to 0.
                        count = 0;
                    }
                }
                else
                {
                    // Number was not between 1 and 100.
                    MessageBox.Show("Please enter a number from 1-100.");
                }
            }
            else
            {
                // Number was not an integer.
                MessageBox.Show("Please enter a valid number.");
            }

            // Clear and set focus to TextBox.
            txtNumber.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
