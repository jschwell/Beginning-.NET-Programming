using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void queenHeartsPictureBox_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Queen of Hearts";
        }

        private void aceSpadesPictureBox_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Ace of Spades";
        }

        private void tenDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Ten of Diamonds";
        }

        private void twoClubsPictureBox_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Two of Clubs";
        }

        private void jackDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            nameLabel.Text = "Jack of Diamonds";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
