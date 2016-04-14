using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highest_and_Lowest_Pay_Rate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

        }

        private void btnHighestPay_Click(object sender, EventArgs e)
        {
            // Declare variable to hold highest pay rate.
            decimal maxPay;

            // Get highest pay rate.
            maxPay = (decimal) this.employeeTableAdapter.MaxPay();

            // Display the highest pay rate.
            MessageBox.Show("Highest Pay Rate: " + maxPay.ToString("c"));
        }

        private void btnLowestPay_Click(object sender, EventArgs e)
        {
            // Declare variable to hold lowest pay rate.
            decimal minPay;

            // Get lowest pay rate.
            minPay = (decimal)this.employeeTableAdapter.MinPay();

            // Display the lowest pay rate.
            MessageBox.Show("Lowest Pay Rate: " + minPay.ToString("c"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
