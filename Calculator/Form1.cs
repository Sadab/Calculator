using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnOne.Text;

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            inputLabel.Text += btnZero.Text;
        }
        
    }
}
