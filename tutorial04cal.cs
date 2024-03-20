using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inputs = textBox1.Text.Split(' ');
                if (inputs.Length != 3)
                {
                    MessageBox.Show("Invalid input. Please enter in the format 'number1 operator number2'.");
                    return;
                }

                int num1 = int.Parse(inputs[0]);
                int num2 = int.Parse(inputs[2]);
                string operation = inputs[1];

                int result = 0;
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "x":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Cannot divide by zero.");
                        break;
                    default:
                        MessageBox.Show("Invalid operator.");
                        return;
                }

                txtResult.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integers.");
            }
        }
    }
}
