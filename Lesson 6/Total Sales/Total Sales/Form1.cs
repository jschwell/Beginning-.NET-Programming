using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadSales(decimal[] iArray)
        {
            try
            {
                // Declare variable for loop counter
                int index = 0;

                // Declare a StreamReader variable
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                // Read the file's contents into the array.
                while (index < iArray.Length && !inputFile.EndOfStream)
                {
                    iArray[index] = decimal.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // Display error message.
                MessageBox.Show(ex.Message);
            }
        }

        private decimal CalcTotal(decimal[] iArray)
        {
            // Declare variable to hold total
            decimal total = 0;

            // Calculate the total of the scores.
            foreach (decimal value in iArray)
            {
                total += value;
            }

            // Return the total.
            return total;
        }

        private void DisplayResults(decimal[] iArray, decimal total)
        {
            // Display the sales.
            foreach (decimal value in iArray)
            {
                lbSales.Items.Add(value.ToString("c"));
            }

            // Display the total.
            lblTotalSales.Text = total.ToString("c");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Create an array
            const int SIZE = 7;
            decimal[] sales = new decimal[SIZE];

            // Declare variables
            decimal total;

            // Read the sales from the file into the array.
            ReadSales(sales);

            // Get the total sales.
            total = CalcTotal(sales);

            // Display the results.
            DisplayResults(sales, total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear form.
            lblTotalSales.Text = "";
            lbSales.Items.Clear();

            // Reset focus.
            btnCalc.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
