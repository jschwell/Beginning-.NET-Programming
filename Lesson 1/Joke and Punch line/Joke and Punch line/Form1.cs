using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joke_and_Punch_line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = "Why shouldn't you argue with a decimal?";
        }

        private void punchLineButton_Click(object sender, EventArgs e)
        {
            jokeLabel.Text = "Decimals always have a point.";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
