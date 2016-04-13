using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors_Game
{
    public partial class Form1 : Form
    {
        // Field variable
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get random number on load.
            Random rand = new Random();
            randomNumber = rand.Next(3) + 1;
        }

        private string ComputerChoice()
        {
            // Declare variable
            string choice = "";

            // Determine computer's choice
            switch (randomNumber)
            {
                case 1:
                    choice = "Rock";
                    break;
                case 2:
                    choice = "Paper";
                    break;
                case 3:
                    choice = "Scissors";
                    break;
            }

            return choice;
        }

        private void DisplayResults(string computerChoice, string playerChoice)
        {
            // Display computer and player choices.
            lblComputerChoice.Text = computerChoice;
            lblPlayerChoice.Text = playerChoice;

            // Determine outcome and display results.
            if (computerChoice == "Rock" && playerChoice == "Scissors")
            {
                lblOutcome.Text = "Rock smashes scissors." + Environment.NewLine
                    + "Computer wins.";
            }
            else if (playerChoice == "Rock" && computerChoice == "Scissors")
            {
                lblOutcome.Text = "Rock smashes scissors." + Environment.NewLine
                    + "You win.";
            }
            else if (computerChoice == "Scissors" && playerChoice == "Paper")
            {
                lblOutcome.Text = "Scissors cuts paper." + Environment.NewLine
                    + "Computer wins.";
            }
            else if (playerChoice == "Scissors" && computerChoice == "Paper")
            {
                lblOutcome.Text = "Scissors cuts paper." + Environment.NewLine
                    + "You win.";
            }
            else if (computerChoice == "Paper" && playerChoice == "Rock")
            {
                lblOutcome.Text = "Paper wraps rock." + Environment.NewLine
                    + "Computer wins.";
            }
            else if (playerChoice == "Paper" && computerChoice == "Rock")
            {
                lblOutcome.Text = "Paper wraps rock." + Environment.NewLine
                    + "You win.";
            }
            else
            {
                lblOutcome.Text = "It's a tie. Please play again.";
            }
        }

        private void GenerateNumber()
        {
            // Generate a new random number.
            Random rand = new Random();
            randomNumber = rand.Next(3) + 1;
        }

        private void GenerateResults(string playerChoice)
        {
            // Declare variables
            string computerChoice;

            // Get computer choice
            computerChoice = ComputerChoice();

            // Display choices.
            DisplayResults(computerChoice, playerChoice);

            // Generate a new number.
            GenerateNumber();
        }

        private void picRock_Click(object sender, EventArgs e)
        {
            // Declare variables
            string playerChoice = "Rock";

            // Send choice to GenerateResults()
            GenerateResults(playerChoice);
        }

        private void picPaper_Click(object sender, EventArgs e)
        {
            // Declare variables
            string playerChoice = "Paper";

            // Send choice to GenerateResults()
            GenerateResults(playerChoice);
        }

        private void picScissors_Click(object sender, EventArgs e)
        {
            // Declare variables
            string playerChoice = "Scissors";

            // Send choice to GenerateResults()
            GenerateResults(playerChoice);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the labels.
            lblPlayerChoice.Text = "";
            lblComputerChoice.Text = "";
            lblOutcome.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
