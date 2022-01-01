using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metric_Unit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFToC_Click(object sender, EventArgs e)
        {
            string fahrenheitInput = inputValue.Text;
            //Input validation
            if (!double.TryParse(fahrenheitInput, out double fahrenheit))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid temperature.");
            } else
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                outputValue.Text = celsius.ToString();
            }
            

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            outputValue.Text = "";
            inputValue.Text = "";
        }

        private void buttonCToF_Click(object sender, EventArgs e)
        {
            string celsiusInput = inputValue.Text;
            //Input Validation
            if (!double.TryParse(celsiusInput, out double celsius))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid temperature.");
            }
            else
            {
                double fahrenheit = ((celsius * 9 / 5) + 32);
                outputValue.Text = fahrenheit.ToString();
            }
        }

        private void buttonFtoM_Click(object sender, EventArgs e)
        {
            string feetInput = inputValue.Text;
            //Input Validation
            if (!double.TryParse(feetInput, out double feet))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid measurement.");
            }
            else
            {
                double meters = feet/3.28;
                //string metersOut = meters.ToString();
                outputValue.Text = String.Format($"{meters:n2}");
            }
        }

        private void buttonMToF_Click(object sender, EventArgs e)
        {
            string metersInput = inputValue.Text;
            //Input Validation
            if (!double.TryParse(metersInput, out double meters))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid measurement.");
            }
            else
            {
                double feet = meters*3.28;
                //string metersOut = meters.ToString();
                outputValue.Text = String.Format($"{feet:n2}");
            }
        }
    }
}
