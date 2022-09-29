using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7___approximate_pi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            double terms, pi = 0;
            if(double.TryParse(termsBox.Text, out terms)) 
            {
                label2.Text = "Approximate value of pi after " + terms + " terms";
                for(int i = 0; i < terms; i++)
                {
                    //Console.Write
                    if(i%2 == 0)
                    {
                        pi += 4 / (1 + (2.0 * i));
                    } else
                    {
                        pi -= 4 /( 1 + (2.0 * i));
                    }
                }
                output.Text = pi.ToString();
            } else
            {
                MessageBox.Show("Input Error");
            }
        }
    }
}
