using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Search
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Search the table for the text that's typed into the text box
            this.employeeTableAdapter.SearchName(this.employeeDataSet.Employee, txtSearch.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Fill the table with all of the records
            this.employeeTableAdapter.Fill(this.employeeDataSet.Employee);

            // Clear and set the focus to the text box
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
