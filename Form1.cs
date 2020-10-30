using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exxercise_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtTerms.Text == "") //checks for empty value
            {
                MessageBox.Show("Enter the Value to caliculate PI :");
            }
            else
            {
                double PI; //for calculate pi value
                int i, denomnator; //denomnator
                int terms; //terms for input the integer terms
                terms = Convert.ToInt32(txtTerms.Text);
                // initialize the variables PI and base
                PI = 0;
                denomnator = 1;
                // use a loop to calculate value of PI
                for (i = 1; i <= terms; i++) //llop upto terms
                {
                    PI = PI + 4 * Math.Pow(-1, (i - 1)) / denomnator;
                    denomnator = denomnator + 2;
                } // end loop
                  // print approximate value of PI
                
                label2.Text = "Approximate value of pi " + terms;
                label1.Text = "= " + PI;

               
                // prompt the user to enter the repetition choice cout « "\nEnter 'y/Y' to repeat the calculation for new n: "; cin » choice; cout « endl;
            }
        }

        private void txtTerms_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
