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
    public partial class Calculator : Form
    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button_Click18(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button_Click16(object sender, EventArgs e)
        {
            operation_pressed = false;
            equation.Text = " ";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
                    // end switch
            }
            
        }

        private void button_Click17(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;

        }

        private void BtnConversion_Click(object sender, EventArgs e)
        {
            double distance, convertedDistance;
            if (double.TryParse(txtDistance.Text, out distance)) 
            {
                if(lstFrom.SelectedIndex != -1)
                {
                    if(lstTo.SelectedIndex != -1)
                    {
                    if(lstFrom.SelectedIndex == 0 && lstTo.SelectedIndex == 0 )
                        {
                            MessageBox.Show("Must select different distance units");
                        }

                        if (lstFrom.SelectedIndex == 0 && lstTo.SelectedIndex == 1)
                        {
                            convertedDistance = distance * .62;
                            lblConvertedDistance.Text = convertedDistance.ToString();
                        }

                        if (lstFrom.SelectedIndex == 1&& lstTo.SelectedIndex == 0)
                        {
                            convertedDistance = distance * 1.609;
                            lblConvertedDistance.Text = convertedDistance.ToString();
                        }
                        if (lstFrom.SelectedIndex == 1 &&lstTo.SelectedIndex == 0)
                        {
                            MessageBox.Show("Must select different distance units");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must select item: to");
                    }
                }
                  else
                {
                    MessageBox.Show("Must select item: From ");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number for the distance");
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button20_Click(object sender, EventArgs e)
        {
            double KGs = (Double)numericUpDown2.Value;
            double Answer2 = KGs * 2.20462;
            label7.Text = Answer2.ToString() + "Pounds";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            double Pound = (Double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label7.Text = Answer.ToString() + "KGs";
         }

        private void Button21_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label7.Text = "Answer:";
        }
    }
}
