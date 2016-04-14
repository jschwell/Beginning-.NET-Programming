//Program Author:  
//Assignment Number: FINAL
//Date Created: 11/28/12
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JMSales
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        string[] salesPersonID = new string[5] {"101","105", "109","112","115"};
	    double[] sales = new double[5];

		private void MainForm_Load(object sender, EventArgs e)
		{
            // Loads listbox with salespersonIDs
            foreach (String value in salesPersonID)
            {
                lstbxSalesID.Items.Add(value);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Declare variables
            double salesAmount;

            // Check if lstbxSalesID has a selected item.
            if (lstbxSalesID.SelectedIndex != -1)
            {
                // Check if salesTB is a valid number then a positive number.     
                if (double.TryParse(salesTB.Text, out salesAmount))
                {
                    if (salesAmount > 0)
                    {
                        // Add the sales amount to the corresponding array element.
                        sales[lstbxSalesID.SelectedIndex] += salesAmount;

                        // Display that the amount has been added.
                        MessageBox.Show(salesAmount.ToString("c") + " has been added to Sales ID " +
                            lstbxSalesID.SelectedItem.ToString() + ".");

                        // Clear and set the focus to the text box.
                        salesTB.Text = "";
                        salesTB.Focus();
                    }
                    else
                    {
                        // The sales amount is a negative number.
                        MessageBox.Show("Please enter a positive sales amount.");
                    }
                }
                else
                {
                    // The sales amount is not a number.
                    MessageBox.Show("Please enter a valid sales amount.");
                }
            }
            else
            {
                // The listbox doesn't have a selected item.
                MessageBox.Show("Please select a Sales ID.");
            }
        }

		private void createReportBtn_Click(object sender, EventArgs e)
		{
            // Declare variable to hold total.
            double total = 0;

            // Clear the listbox.
            lstBxSalesReport.Items.Clear();

            // Add category names to listbox.
            lstBxSalesReport.Items.Add("Sales ID \t\t Total Sales");

            //prints out sales total for each sales person
            //loop through arrays to report content
            for (int index = 0; index < salesPersonID.Length; index++)
            {
                lstBxSalesReport.Items.Add(salesPersonID[index] + " \t\t " + sales[index].ToString("c"));

                // Add the array value to the total.
                total += sales[index];
            }

            // Add blank row for looks.
            lstBxSalesReport.Items.Add("");

            // Add total sales to listbox.
            lstBxSalesReport.Items.Add("Total Sales \t " + total.ToString("c"));
        }

        
		private void exitBtn1_Click(object sender, EventArgs e)
		{
            // Close the form.
			this.Close();
		}

        private void btnSaveSales_Click(object sender, EventArgs e)
        {
            //Write sales to a text file - Sales.txt
            try
            {
                // Declare variable for loop counter
                int index = 0;

                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Open file to create data.
                outputFile = File.CreateText("Sales.txt");

                // Write the array's contents into the file.
                while (index < sales.Length)
                {
                    outputFile.WriteLine(sales[index]);
                    index++;
                }

                // Close the file.
                outputFile.Close();

                // Display successful save message.
                MessageBox.Show("Sales have been saved to the file.");
            }
            catch (Exception ex)
            {
                // Display error message.
                MessageBox.Show(ex.Message);
            }
        }
    }
}
