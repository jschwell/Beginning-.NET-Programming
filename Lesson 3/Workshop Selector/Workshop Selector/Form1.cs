using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop_Selector
{
    public partial class Form1 : Form
    {
        // Constant fields
        const int HANDLING_STRESS_DAYS = 3;
        const int TIME_MANAGEMENT_DAYS = 3;
        const int SUPERVISION_SKILLS_DAYS = 3;
        const int NEGOTIATION_DAYS = 5;
        const int HOW_TO_INTERVIEW_DAYS = 1;

        const decimal HANDLING_STRESS_FEE = 1000m;
        const decimal TIME_MANAGEMENT_FEE = 800m;
        const decimal SUPERVISION_SKILLS_FEE = 1500m;
        const decimal NEGOTIATION_FEE = 1300m;
        const decimal HOW_TO_INTERVIEW_FEE = 500m;

        const decimal AUSTIN_FEE = 150m;
        const decimal CHICAGO_FEE = 225m;
        const decimal DALLAS_FEE = 175m;
        const decimal ORLANDO_FEE = 300m;
        const decimal PHOENIX_FEE = 175m;
        const decimal RALEIGH_FEE = 150m;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Local variables
            string workshop;
            string location;

            int days = 0;

            decimal registration = 0m;
            decimal lodging = 0m;
            decimal total;
            
            // Check if lbWorkshop has a selected item.
            if (lbWorkshop.SelectedIndex != -1)
            {
                // Check if lbLocation has a selected item.           
                if (lbLocation.SelectedIndex != -1)
                {
                    // Get the selected items.
                    workshop = lbWorkshop.SelectedItem.ToString();
                    location = lbLocation.SelectedItem.ToString();

                    // Determine registration fee and number of days.
                    switch (workshop)
                    {
                        case "Handling Stress":
                            registration = HANDLING_STRESS_FEE;
                            days = HANDLING_STRESS_DAYS;
                            break;

                        case "Time Management":
                            registration = TIME_MANAGEMENT_FEE;
                            days = TIME_MANAGEMENT_DAYS;
                            break;

                        case "Supervision Skills":
                            registration = SUPERVISION_SKILLS_FEE;
                            days = SUPERVISION_SKILLS_DAYS;
                            break;

                        case "Negotiation":
                            registration = NEGOTIATION_FEE;
                            days = NEGOTIATION_DAYS;
                            break;

                        case "How to Interview":
                            registration = HOW_TO_INTERVIEW_FEE;
                            days = HOW_TO_INTERVIEW_DAYS;
                            break;
                    }

                    // Determine lodging fee.
                    switch (location)
                    {
                        case "Austin":
                            lodging = AUSTIN_FEE * days;
                            break;

                        case "Chicago":
                            lodging = CHICAGO_FEE * days;
                            break;

                        case "Dallas":
                            lodging = DALLAS_FEE * days;
                            break;

                        case "Orlando":
                            lodging = ORLANDO_FEE * days;
                            break;

                        case "Phoenix":
                            lodging = PHOENIX_FEE * days;
                            break;

                        case "Raleigh":
                            lodging = RALEIGH_FEE * days;
                            break;
                    }

                    // Calculate total cost.
                    total = registration + lodging;

                    // Display costs.
                    lblRegistration.Text = registration.ToString("c");
                    lblLodging.Text = lodging.ToString("c");
                    lblTotal.Text = total.ToString("c");
                }
                else
                {
                    // No location was selected.
                    MessageBox.Show("Please select a location.");
                }                   
            }
            else
            {
                // No workshop was selected.
                MessageBox.Show("Please select a workshop.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear labels and selected items.
            lblRegistration.Text = "";
            lblLodging.Text = "";
            lblTotal.Text = "";

            lbWorkshop.SelectedIndex = -1;
            lbLocation.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
