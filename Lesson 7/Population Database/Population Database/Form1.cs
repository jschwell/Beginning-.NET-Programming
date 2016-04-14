using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDataSet.City);

        }

        private void btnAscPopulation_Click(object sender, EventArgs e)
        {
            // Sort the table by population in ascending order
            this.cityTableAdapter.FillByAscPopulation(this.cityDataSet.City);
        }

        private void btnDescPopulation_Click(object sender, EventArgs e)
        {
            // Sort the table by population in descending order
            this.cityTableAdapter.FillByDescPopulation(this.cityDataSet.City);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            // Sort the table by city
            this.cityTableAdapter.FillByCity(this.cityDataSet.City);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            // Declare variable to hold total population.
            double totalPopulation;

            // Get the total population.
            totalPopulation = (double)this.cityTableAdapter.TotalPopulation();

            // Display the total population.
            MessageBox.Show("Total Population: " + totalPopulation.ToString("n0"));
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            // Declare variable to hold average population.
            double averagePopulation;

            // Get the average population.
            averagePopulation = (double)this.cityTableAdapter.AveragePopulation();

            // Display the average population.
            MessageBox.Show("Average Population: " + averagePopulation.ToString("n0"));
        }

        private void btnMaxPopulation_Click(object sender, EventArgs e)
        {
            // Declare variable to hold highest population.
            double maxPopulation;

            // Get the highest population.
            maxPopulation = (double)this.cityTableAdapter.MaxPopulation();

            // Display the highest population.
            MessageBox.Show("Highest Population: " + maxPopulation.ToString("n0"));
        }

        private void btnMinPopulation_Click(object sender, EventArgs e)
        {
            // Declare variable to hold lowest population.
            double minPopulation;

            // Get the lowest population.
            minPopulation = (double)this.cityTableAdapter.MinPopulation();

            // Display the lowest population.
            MessageBox.Show("Lowest Population: " + minPopulation.ToString("n0"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
