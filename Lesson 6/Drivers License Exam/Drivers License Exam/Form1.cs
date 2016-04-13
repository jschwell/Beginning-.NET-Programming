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

namespace Drivers_License_Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadAnswers(string[] iArray, ref int index)
        {
            try
            {
                // Declare a StreamReader variable
                StreamReader inputFile;

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("StudentAnswers.txt");

                // Read the file's contents into the array.
                while (index < iArray.Length && !inputFile.EndOfStream)
                {
                    iArray[index] = inputFile.ReadLine();
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

        private bool InputIsValid(string[] firstArray, int count)
        {
            // Flag variable to indicate whether the input is good.
            bool inputGood = false;

            // Test if the length of the array is same as the number of answers in the file
            if (firstArray.Length == count)
            {
                inputGood = true;
            }
            else
            {
                // Display error message if student answer count doesn't match the array length
                MessageBox.Show("The file contains an invalid number of answers.");
            }

            return inputGood;
        }

        private void CompareAnswers(string[] firstArray, string[] secondArray, ref int correct, ref int incorrect)
        {
            for (int index = 0; index < firstArray.Length; index++)
            {
                // Check if the values match
                if (String.Compare(firstArray[index], secondArray[index], true) == 0)
                {
                    // Add one to the number of correct answers
                    correct++;
                }
                else
                {
                    // Add one to the number of incorrect answers and display the problem number
                    incorrect++;
                    lbQuestions.Items.Add(index + 1);
                }
            }
        }

        private void DisplayResults(int correct, int incorrect)
        {
            // Check if the student passed by answering 15 or more questions correct
            if (correct >= 15)
            {
                lblMessage.Text = "Pass";
            }
            else
            {
                lblMessage.Text = "Fail";
            }

            // Display number of correct and incorrect questions
            lblCorrect.Text = correct.ToString();
            lblIncorrect.Text = incorrect.ToString();

            // If all answers are correct, indicate it in the listbox
            if (lbQuestions.Items.Count == 0)
            {
                lbQuestions.Items.Add("All answers are correct");
            }
        }

        private void btnGetScore_Click(object sender, EventArgs e)
        {
            // Create arrays
            const int SIZE = 20;
            string[] studentAnswers = new string[SIZE];
            string[] testAnswers = {"B", "D", "A", "A", "C",
                                    "A", "B", "A", "C", "D",
                                    "B", "C", "D", "A", "D",
                                    "C", "C", "B", "D", "A"};

            // Declare variables
            int answerCount = 0;
            int correctAnswers = 0;
            int incorrectAnswers = 0;

            // Clear list box
            lbQuestions.Items.Clear();

            // Get Student Answers
            ReadAnswers(studentAnswers, ref answerCount);
            
            if (InputIsValid(testAnswers, answerCount))
            {
                // Compare test answers to student answers
                CompareAnswers(testAnswers, studentAnswers, ref correctAnswers, ref incorrectAnswers);

                // Display results.
                DisplayResults(correctAnswers, incorrectAnswers);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear labels and listbox
            lblMessage.Text = "";
            lblCorrect.Text = "";
            lblIncorrect.Text = "";
            lbQuestions.Items.Clear();

            // Reset focus
            btnGetScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
