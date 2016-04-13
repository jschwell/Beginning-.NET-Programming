using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        private const decimal CLASS_A_PRICE = 15.00m;
        private const decimal CLASS_B_PRICE = 12.00m;
        private const decimal CLASS_C_PRICE = 9.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Set variables.
                double classATickets;
                double classBTickets;
                double classCTickets;
                decimal classAIncome;
                decimal classBIncome;
                decimal classCIncome;
                decimal total;

                // Get number of tickets for each class.
                classATickets = double.Parse(txtClassA.Text);
                classBTickets = double.Parse(txtClassB.Text);
                classCTickets = double.Parse(txtClassC.Text);

                // Calculate income of each class.
                classAIncome = (decimal)classATickets * CLASS_A_PRICE;
                classBIncome = (decimal)classBTickets * CLASS_B_PRICE;
                classCIncome = (decimal)classCTickets * CLASS_C_PRICE;

                // Calculate total income.
                total = classAIncome + classBIncome + classCIncome;

                // Display income.
                lblClassARevenue.Text = classAIncome.ToString("c");
                lblClassBRevenue.Text = classBIncome.ToString("c");
                lblClassCRevenue.Text = classCIncome.ToString("c");
                lblTotal.Text = total.ToString("c");
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
            // Clear the controls.
            txtClassA.Text = "";
            txtClassB.Text = "";
            txtClassC.Text = "";
            lblClassARevenue.Text = "";
            lblClassBRevenue.Text = "";
            lblClassCRevenue.Text = "";
            lblTotal.Text = "";

            // Set focus to classATextBox.
            txtClassA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
