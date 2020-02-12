using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ultraLabel1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ultraLabel4_Click(object sender, EventArgs e)
        {

        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            Principal.Text = "";
            Rate.Text = "";
            Time.Text = "";
            interestAmount.Text = "0.00 $";
            siResult.Text = "0.00 $";

            interestAmount2.Text = "0.00 $";
            ciResult.Text = "0.00 $";

        }
        private void SI_Button_Click(object sender, EventArgs e)
        {

            try
            {

                double p = double.Parse(Principal.Text);
                double r = double.Parse(Rate.Text);
                double t = double.Parse(Time.Text);

                double simpleInterest = (p * r * t) / 100;
                string s = "";
                interestAmount.Text = simpleInterest.ToString(s);

                siResult.Text = (simpleInterest + p).ToString(s);
                siResult.Text += " $";
                interestAmount.Text += " $";
            }
            catch
            {
                if (Principal.Text == "" || Rate.Text == "" || Time.Text == "")
                    MessageBox.Show("Enter valid input");


            }
        }

        private void CI_Button_Click(object sender, EventArgs e)
        {

            try
            {

                double p = double.Parse(Principal.Text);
                double r = double.Parse(Rate.Text);
                double t = double.Parse(Time.Text);

                double compoundInterest = p * Math.Pow((1 + r/100), t) ;
                string s = "";
                interestAmount2.Text = compoundInterest.ToString(s);

                ciResult.Text = (compoundInterest + p).ToString(s);
                ciResult.Text += " $";
                interestAmount2.Text += " $";
            }
            catch
            {
                if (Principal.Text == "" || Rate.Text == "" || Time.Text == "")
                    MessageBox.Show("Enter valid input");
            }
        }

    }
}
