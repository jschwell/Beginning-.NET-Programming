using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Job_Estimator
{
    public partial class Form1 : Form
    {
        private const double WALL_SPACE_FACTOR = 115;
        private const double GALLONS_OF_PAINT = 1;
        private const double HOURS_OF_LABOR = 8;

        private const decimal LABOR_HOURLY_COST = 20.00m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Set variables
                double wallSpace;
                decimal paintGallonPrice;
                double gallons;
                double laborHours;
                decimal paintTotalPrice;
                decimal laborCharges;
                decimal total;

                // Get data from text boxes.
                wallSpace = double.Parse(txtWallSpace.Text);
                paintGallonPrice = decimal.Parse(txtPaintGallonCost.Text);

                // Calculate data.
                gallons = wallSpace / WALL_SPACE_FACTOR * GALLONS_OF_PAINT;
                laborHours = wallSpace / WALL_SPACE_FACTOR * HOURS_OF_LABOR;
                paintTotalPrice = (decimal)gallons * paintGallonPrice;
                laborCharges = (decimal)laborHours * LABOR_HOURLY_COST;
                total = paintTotalPrice + laborCharges;

                // Display the data.
                txtPaintGallonCost.Text = paintGallonPrice.ToString("c");
                lblGallons.Text = gallons.ToString("n2");
                lblLaborHours.Text = laborHours.ToString("n2");
                lblPaintTotalCost.Text = paintTotalPrice.ToString("c");
                lblLaborCost.Text = laborCharges.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Set focus to the clear button.
            btnClear.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear controls.
            txtWallSpace.Text = "";
            txtPaintGallonCost.Text = "";
            lblGallons.Text = "";
            lblLaborHours.Text = "";
            lblPaintTotalCost.Text = "";
            lblLaborCost.Text = "";
            lblTotal.Text = "";

            // Set focus to text box.
            txtWallSpace.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
