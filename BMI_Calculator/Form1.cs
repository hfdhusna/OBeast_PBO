using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            double Weight;
            double Height;
            double BMI;
            Height = double.Parse(heightBox.Text);
            Weight = double.Parse(weightBox.Text);
            BMI = (Weight) / ((Height/100) * (Height/100));
            if (BMI < 18.5)
            {
                result.Text = BMI + "\n Underweight" + "\nPlease Take Some Multivitamin To Get Your Ideal Weight";
            }
            else if (BMI > 18.5 && BMI < 24.5)
            {
                result.Text = BMI + "\nIdeal Weight" + "\nKeep up the good habit";
            }
            else if (BMI > 24.5 && BMI < 32.5)
            {
                result.Text = BMI + "\nOverweight" + "\nPlease take calorie deficit program ";
            }
            else
            {
                result.Text = BMI + "\nObesity" + "\nPlease consider a profesional help ";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
