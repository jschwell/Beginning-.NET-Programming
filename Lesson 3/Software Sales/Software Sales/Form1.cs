using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Sales
{
    public partial class Form1 : Form
    {
        // Constant fields
        const decimal PACKAGE_PRICE = 99.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Local variables
            int packages;
            decimal discount;
            decimal total;

            // Check to see if value entered was an integer.
            if (int.TryParse(txtPackages.Text, out packages))
            {
                // Check to see if the integer entered was a positive value.
                if (packages > 0)
                {
                    // Determine discount.
                    if (packages >= 100)
                    {
                        discount = packages * PACKAGE_PRICE * 0.5m;
                    }
                    else if (packages >= 50)
                    {
                        discount = packages * PACKAGE_PRICE * 0.4m;
                    }
                    else if (packages >= 20)
                    {
                        discount = packages * PACKAGE_PRICE * 0.3m;
                    }
                    else if (packages >= 10)
                    {
                        discount = packages * PACKAGE_PRICE * 0.2m;
                    }
                    else
                    {
                        discount = 0;
                    }

                    // Calculate total price after discount.
                    total = packages * PACKAGE_PRICE - discount;

                    // Display discount and total price.
                    lblDiscount.Text = discount.ToString("c");
                    lblTotal.Text = total.ToString("c");
                }
                else
                {
                    // A negative integer or 0 was entered.
                    MessageBox.Show("Enter a positive value.");
                }
            }
            else
            {
                // An integer was not entered.
                MessageBox.Show("Enter a valid number.");
            }

            // Set focus to Clear button.
            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textbox and labels.
            txtPackages.Text = "";
            lblDiscount.Text = "";
            lblTotal.Text = "";

            // Set focus to TextBox.
            txtPackages.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
