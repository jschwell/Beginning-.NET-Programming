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

namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        // Field variable to hold the file path
        string filePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Get file path and display it.
                filePath = saveFile.FileName;
                lblFilePath.Text = filePath;

                // Declare a StreamWriter variable.
                StreamWriter outputFile;

                // Create file and close it.
                outputFile = File.CreateText(@filePath);
                outputFile.Close();

                // Set focus to textbox.
                txtMaxCount.Focus();
            }
            else
            {
                // The operation was canceled.
                MessageBox.Show("Operation canceled.");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Get file path and display it.
                filePath = openFile.FileName;
                lblFilePath.Text = filePath;

                // Set focus to read button.
                btnRead.Focus();
            }
            else
            {
                // The operation was canceled.
                MessageBox.Show("Operation canceled.");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Local variables
            int randomNumber;
            int maxCount;

            // Get user entered number.
            if (int.TryParse(txtMaxCount.Text, out maxCount))
            {
                // Check to see if maxCount is positive.
                if (maxCount > 0)
                {
                    // Check if there is a filepath.
                    if (filePath != "")
                    {
                        try
                        {
                            // Create a Random object.
                            Random rand = new Random();

                            // Declare a StreamWriter variable.
                            StreamWriter outputFile;

                            // Open file to append data.
                            outputFile = File.AppendText(@filePath);

                            for (int count = 1; count <= maxCount; count++)
                            {
                                // Get a random number from 1 - 100
                                randomNumber = rand.Next(100) + 1;

                                // Write number to file.
                                outputFile.WriteLine(randomNumber);
                            }

                            // Close file.
                            outputFile.Close();

                            // Display that the numbers were written.
                            MessageBox.Show(maxCount + " numbers were written to " + filePath);

                            // Clear TextBox and set the focus.
                            txtMaxCount.Text = "";
                            btnRead.Focus();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        // No file was chosen.
                        MessageBox.Show("Please create or choose an existing file.");
                    }
                }
                else
                {
                    // A positive value was not entered.
                    MessageBox.Show("Please enter a positive number.");
                }
            }
            else
            {
                // An integer was not entered.
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Local variables
            int number;
            int total = 0;
            int count = 0;

            // Check if there is a filepath
            if (filePath != "")
            {
                try
                {
                    // Declare a StreamReader variable.
                    StreamReader inputFile;

                    // Clear any previous items in ListBox
                    lbNumbers.Items.Clear();

                    // Open the file
                    inputFile = File.OpenText(@filePath);

                    while (!inputFile.EndOfStream)
                    {
                        // Get a number.
                        number = int.Parse(inputFile.ReadLine());

                        // Add the number to the ListBox.
                        lbNumbers.Items.Add(number);

                        // Add number to total.
                        total += number;

                        // Add 1 to count.
                        count++;
                    }

                    // Close the file.
                    inputFile.Close();

                    //Display total.
                    lblTotal.Text = total.ToString();

                    //Display number of random numbers.
                    lblCount.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // No file was chosen.
                MessageBox.Show("Please choose a file.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear TextBox, Labels, and ListBox.
            txtMaxCount.Text = "";
            lblFilePath.Text = "";
            lblTotal.Text = "";
            lblCount.Text = "";
            lbNumbers.Items.Clear();

            // Reset filePath location
            filePath = "";

            // Set focus to Open Button
            btnOpen.Focus();
        }

        private void btnClearFile_Click(object sender, EventArgs e)
        {
            // Check if there is a filepath
            if (filePath != "")
            {
                try
                {
                    // Declare a StreamWriter variable.
                    StreamWriter outputFile;

                    // Overwrite file data and close it.
                    outputFile = File.CreateText(@filePath);
                    outputFile.Close();

                    // Clear controls related to old file data and set focus to TextBox.
                    lblTotal.Text = "";
                    lblCount.Text = "";
                    lbNumbers.Items.Clear();
                    txtMaxCount.Focus();

                    // Display that the file was cleared.
                    MessageBox.Show("The file was cleared.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // No file was chosen.
                MessageBox.Show("Please choose a file to clear.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
