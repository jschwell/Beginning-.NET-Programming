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

namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadNames(List<string> nameList, string fileName)
        {
            try
            {
                // Open the text file
                StreamReader inputFile = File.OpenText(fileName);

                // Read the names into the list
                while (!inputFile.EndOfStream)
                {
                    nameList.Add(inputFile.ReadLine());
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

        private bool InputIsValid(out string boyName, out string girlName)
        {
            // Flag variable to indicate whether the input is good.
            bool inputGood = false;

            // Get names from the text boxes
            boyName = txtBoy.Text;
            girlName = txtGirl.Text;

            // Test if there is a name entered in either text box
            if (boyName != "" || girlName != "")
            {
                inputGood = true;
            }
            else
            {
                // Display error message if no name is entered.
                MessageBox.Show("Enter a boy name, a girl name, or both.");

                // Reset focus.
                txtBoy.Focus();
            }

            return inputGood;
        }

        private string SearchNames(List<string> nameList, string name)
        {
            // Declare variables
            string message;
            int position;

            // Change name to have only the first letter uppercase in case
            // the user enters the name a different way.
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();

            // Search for name
            position = nameList.IndexOf(name);

            // Was name found in the the list?
            if (position != -1)
            {
                message = name + " was among the most popular.";
            }
            else
            {
                message = name + " was not among the most popular.";
            }

            return message;
        }

        private void ConvertNames(List<string> nameList)
        {
            for (int index = 0; index <nameList.Count; index++)
            {
                nameList[index] = char.ToUpper(nameList[index][0]) + nameList[index].Substring(1).ToLower();
            }
        }

        private void DisplayResults(string firstMessage, string secondMessage)
        {
            // Display either both messages or one of the messages
            if (firstMessage != "" && secondMessage != "")
            {
                lblMessage.Text = firstMessage + "\n" + secondMessage;
            }
            else if (firstMessage != "") {
                lblMessage.Text = firstMessage;
            }
            else
            {
                lblMessage.Text = secondMessage;
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Declare variables
            string boyName;
            string girlName;
            string boyMessage = "";
            string girlMessage = "";
            
            // Create a list to hold boy names
            List<string> boyNamesList = new List<string>();

            // Create a list to hold girl names
            List<string> girlNamesList = new List<string>();

            // Read the names from the files into the lists.
            ReadNames(boyNamesList, "BoyNames.txt");
            ReadNames(girlNamesList, "GirlNames.txt");

            // Convert all names to proper Capitalization
            ConvertNames(boyNamesList);
            ConvertNames(girlNamesList);

            if (InputIsValid(out boyName,out girlName ))
            {
                // Check if a boy's name was entered and compare it to the list of names
                if (boyName != "" )
                {
                    boyMessage = SearchNames(boyNamesList, boyName);
                }

                // Check if a girl's name was entered and compare it to the list of names
                if (girlName != "")
                {
                    girlMessage = SearchNames(girlNamesList, girlName);
                }

                // Display if the names matched or not.
                DisplayResults(boyMessage, girlMessage);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes and label.
            txtBoy.Text = "";
            txtGirl.Text = "";
            lblMessage.Text = "";

            // Reset focus.
            txtBoy.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
