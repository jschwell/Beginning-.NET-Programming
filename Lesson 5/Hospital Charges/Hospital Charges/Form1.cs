using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Charges
{
    public partial class Form1 : Form
    {
        // Constant fields
        private const decimal BASE_CHARGE = 350.0m;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalcStayCharges(int days)
        {
            // Calculate and return stay charges.
            return BASE_CHARGE * days;
        }

        private decimal CalcMiscCharges(decimal medCharges, decimal surgicalCharges, decimal labFees, decimal rehabCharges)
        {
            // Calculate and return misc charges.
            return medCharges + surgicalCharges + labFees + rehabCharges;
        }

        private decimal CalcTotalCharges(int days, decimal medCharges, decimal surgicalCharges, decimal labFees, decimal rehabCharges)
        {
            // Calculate and return total charges.
            return CalcStayCharges(days) + CalcMiscCharges(medCharges, surgicalCharges, labFees, rehabCharges);
        }

        private bool InputIsValid(ref int days, ref decimal medCharges, ref decimal surgicalCharges, ref decimal labFees, ref decimal rehabCharges)
        {
            // Flag variable to indicate whether the input is good
            bool inputGood = false;

            // Test out variables
            if (int.TryParse(txtDaysSpent.Text, out days))
            {
                if(days > 0)
                {
                    if (decimal.TryParse(txtMedCharges.Text, out medCharges))
                    {
                        if (decimal.TryParse(txtSurgicalCharges.Text, out surgicalCharges))
                        {
                            if (decimal.TryParse(txtLabFees.Text, out labFees))
                            {
                                if (decimal.TryParse(txtRehabCharges.Text, out rehabCharges))
                                {
                                    // Both inputs are good.
                                    inputGood = true;
                                }
                                else
                                {
                                    // Display an error message for rehabCharges.
                                    MessageBox.Show("Please enter a valid Rehabilitation charge.");
                                }
                            }
                            else
                            {
                                // Display an error message for labFees.
                                MessageBox.Show("Please enter a valid lab fee.");
                            }
                        }
                        else
                        {
                            // Display an error message for surgicalCharges.
                            MessageBox.Show("Please enter a valid surgical charge.");
                        }
                    }
                    else
                    {
                        // Display an error message for medCharges.
                        MessageBox.Show("Please enter a valid medication charge.");
                    }
                }
                else
                {
                    // Display an error message for days.
                    MessageBox.Show("Please enter a positive number of days.");
                }
            }
            else
            {
                // Display an error message for days.
                MessageBox.Show("Please enter a valid number of days.");
            }

            return inputGood;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
            int days = 0;
            decimal medCharges = 0m;
            decimal surgicalCharges = 0m;
            decimal labFees = 0m;
            decimal rehabCharges = 0m;
            decimal total;

            if (InputIsValid(ref days, ref medCharges, ref surgicalCharges, ref labFees, ref rehabCharges))
            {
                // Get the total charges.
                total = CalcTotalCharges(days, medCharges, surgicalCharges, labFees, rehabCharges);

                // Display total.
                lblTotal.Text = total.ToString("c");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes and labels.
            txtDaysSpent.Text = "";
            txtMedCharges.Text = "";
            txtSurgicalCharges.Text = "";
            txtLabFees.Text = "";
            txtRehabCharges.Text = "";
            lblTotal.Text = "";

            // Reset focus.
            txtDaysSpent.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
