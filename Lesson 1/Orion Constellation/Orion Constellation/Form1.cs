using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orion_Constellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showStarNamesButton_Click(object sender, EventArgs e)
        {
            alnilamLabel.Visible = true;
            alnitakLabel.Visible = true;
            betelgeuseLabel.Visible = true;
            meissaLabel.Visible = true;
            mintakaLabel.Visible = true;
            rigelLabel.Visible = true;
            saiphLabel.Visible = true;
        }

        private void hideStarNamesButton_Click(object sender, EventArgs e)
        {
            alnilamLabel.Visible = false;
            alnitakLabel.Visible = false;
            betelgeuseLabel.Visible = false;
            meissaLabel.Visible = false;
            mintakaLabel.Visible = false;
            rigelLabel.Visible = false;
            saiphLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
