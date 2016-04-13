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

namespace Population_Data
{
    public partial class Form1 : Form
    {
        // Constant field
        private const int STARTING_YEAR = 1950;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadData(List<double> dataList)
        {
            try
            {
                // Open the text file
                StreamReader inputFile = File.OpenText("USPopulation.txt");

                // Read the names into the list
                while (!inputFile.EndOfStream)
                {
                    dataList.Add(double.Parse(inputFile.ReadLine()));
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

        private void GetAnnualChange(List<double> firstList, List<double> secondList)
        {
            // Find the annual change and set the value into secondList
            for (int index = 1; index < firstList.Count; index++)
            {
                secondList.Add(firstList[index] - firstList[index - 1]);
            }
        }

        private double CalcAverage(List<double> dataList)
        {
            // Declare variables
            double total = 0;
            double average;

            // Calculate the total
            foreach (int value in dataList)
            {
                total += value;
            }

            // Calculate the average annual change
            average = total / dataList.Count;

            // Return the average
            return average;
        }

        private int GreatestIncrease(List<double> dataList)
        {
            // Declare variable to hold the year with the greatest change
            // and initialize to indicate the first year in the array.
            int year = 1;

            // Declare variable to hold the greatest change
            // and intialize it with the first value in the array.
            double greatestChange = dataList[0];

            // Find the greatest change in the array
            for (int index = 1; index < dataList.Count; index++)
            {
                if (dataList[index] > greatestChange)
                {
                    greatestChange = dataList[index];
                    year = index + 1;
                }
            }

            // Return the year with the greatest change
            return year + STARTING_YEAR;
        }

        private int LeastIncrease(List<double> dataList)
        {
            // Declare variable to hold the year with the least change
            // and initialize to indicate the first year in the array.
            int year = 1;

            // Declare variable to hold the least change
            // and intialize it with the first value in the array.
            double leastChange = dataList[0];

            // Find the least change in the array
            for (int index = 1; index < dataList.Count; index++)
            {
                if (dataList[index] < leastChange)
                {
                    leastChange = dataList[index];
                    year = index + 1;
                }
            }

            // Return the year with the least change
            return year + STARTING_YEAR;
        }

        private void DisplayResults(double average, int highest, int lowest)
        {
            // Display average
            lblAverage.Text = average.ToString("n2");

            // Add the highest value to the starting year and display it.
            lblGreatest.Text = highest.ToString();

            // Add the lowest value to the starting year and display it.
            lblLeast.Text = lowest.ToString();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            // Declare variables
            double average;
            int highest;
            int lowest;

            // Create list to hold population data
            List<double> populationData = new List<double>();

            // Create a list to hold the annual change
            List<double> annualChange = new List<double>();

            // Read the population data from the file into the list.
            ReadData(populationData);

            // Get the annual change
            GetAnnualChange(populationData, annualChange);

            // Calculate the average annual change
            average = CalcAverage(annualChange);

            // Find the year with the greatest increase in population
            highest = GreatestIncrease(annualChange);

            // Find the year with the least increase in population
            lowest = LeastIncrease(annualChange);

            // Display results.
            DisplayResults(average, highest, lowest);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear labels.
            lblAverage.Text = "";
            lblGreatest.Text = "";
            lblLeast.Text = "";

            // Reset focus.
            btnGetData.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
