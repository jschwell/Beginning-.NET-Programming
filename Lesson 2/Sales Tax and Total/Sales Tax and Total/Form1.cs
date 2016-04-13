using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Tax_and_Total
{
    public partial class Form1 : Form
    {
        private const decimal STATE_TAX_RATE = 0.04m;
        private const decimal COUNTY_TAX_RATE = 0.02m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Set variables.
                decimal purchasePrice;
                decimal stateTax;
                decimal countyTax;
                decimal totalTax;
                decimal totalPrice;

                // Get the purchase price.
                purchasePrice = decimal.Parse(txtPurchasePrice.Text);

                // Calculate the price.
                stateTax = purchasePrice * STATE_TAX_RATE;
                countyTax = purchasePrice * COUNTY_TAX_RATE;
                totalTax = stateTax + countyTax;
                totalPrice = purchasePrice + totalTax;

                // Display the prices.
                txtPurchasePrice.Text = purchasePrice.ToString("c");
                lblStateTax.Text = stateTax.ToString("c");
                lblCountyTax.Text = countyTax.ToString("c");
                lblTotalTax.Text = totalTax.ToString("c");
                lblTotalPrice.Text = totalPrice.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Set focus to clear button.
            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear controls.
            txtPurchasePrice.Text = "";
            lblStateTax.Text = "";
            lblCountyTax.Text = "";
            lblTotalTax.Text = "";
            lblTotalPrice.Text = "";

            // Set focus to text box.
            txtPurchasePrice.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
