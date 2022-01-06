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

            buttonCToF.BackColor = Color.LightCyan;
            buttonKToP.BackColor = Color.LightCyan;
            buttonLToG.BackColor = Color.LightCyan;
            buttonMToF.BackColor = Color.LightCyan;
            buttonFToC.BackColor = Color.LightSkyBlue;
            buttonPToK.BackColor = Color.LightSkyBlue;
            buttonGToL.BackColor = Color.LightSkyBlue;
            buttonFtoM.BackColor = Color.LightSkyBlue;
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
                outputValue.BackColor = Color.LightSkyBlue;
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
                outputValue.BackColor = Color.LightCyan;
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
                outputValue.BackColor = Color.LightSkyBlue;
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
                outputValue.BackColor = Color.LightCyan;
            }
        }

        private void buttonPToK_Click(object sender, EventArgs e)
        {
            string poundsInput = inputValue.Text;
            if (!Double.TryParse(poundsInput, out double pounds))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid weight.");
            }
            else
            {
                double kilograms = pounds / 2.2;
                outputValue.Text = String.Format($"{kilograms:n2}");
                outputValue.BackColor = Color.LightSkyBlue;
            }
        }

        private void buttonKToP_Click(object sender, EventArgs e)
        {
            string kilogramsInput = inputValue.Text;
            if (!Double.TryParse(kilogramsInput, out double kilograms))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid weight.");
            } else
            {
                double pounds = kilograms * 2.2;
                outputValue.Text = String.Format($"{pounds:n2}");
                outputValue.BackColor = Color.LightCyan;
            }
        }

        private void buttonGToL_Click(object sender, EventArgs e)
        {
            string inputGallons = inputValue.Text;
            if (!Double.TryParse(inputGallons, out double gallons))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid measurement.");
            } else
            {
                double liters = gallons * 3.78;
                outputValue.Text = String.Format($"{liters:n2}");
                outputValue.BackColor = Color.LightSkyBlue;
            }
        }

        private void buttonLToG_Click(object sender, EventArgs e)
        {
            string inputLiters = inputValue.Text;
            if (!Double.TryParse(inputLiters, out double liters))
            {
                MessageBox.Show("That's not a valid entry.  Please enter a valid measurement.");
            } else
            {
                double gallons = liters / 3.78;
                outputValue.Text = String.Format($"{gallons:n2}");
                outputValue.BackColor = Color.LightCyan;
            }
        }
    }
}
