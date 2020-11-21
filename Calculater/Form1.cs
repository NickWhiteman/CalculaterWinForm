using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int numberFirst = 0;
        public string operation;
        public string prevNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateDisplay.Text += ((Button)sender).Text;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if(Number1.Text != "" && CalculateDisplay.Text != "" && Operation.Text != "")
            {
                string newNumber = prevNumber;
                CalculateDisplay.Text = ResultEquals(Number1.Text, newNumber, operation) + "";
            }
            
            if (CalculateDisplay.Text == "" && Number1.Text != "" && Operation.Text != "")
            {
                operation = "+";
                Operation.Text = "+";
            }
            else
            {
                numberFirst = Convert.ToInt32(CalculateDisplay.Text);
                operation = "+";
                CalculateDisplay.Text = "";
                Number1.Text = numberFirst + "";
                Operation.Text = "+";
                prevNumber = Number1.Text;
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (Number1.Text != "" && CalculateDisplay.Text != "" && Operation.Text != "")
            {
                string newNumber = prevNumber;
                CalculateDisplay.Text = ResultEquals(Number1.Text, newNumber, operation) + "";
            }

            if (CalculateDisplay.Text == "" && Number1.Text != "" && Operation.Text != "" && Operation.Text != "")
            {
                operation = "-";
                Operation.Text = "-";
            }
            else
            {
                numberFirst = Convert.ToInt32(CalculateDisplay.Text);
                operation = "-";
                CalculateDisplay.Text = "";
                Number1.Text = numberFirst + "";
                Operation.Text = "-";
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (Number1.Text != "" && CalculateDisplay.Text != "" && Operation.Text != "")
            {
                string newNumber = prevNumber;
                CalculateDisplay.Text = ResultEquals(Number1.Text, newNumber, operation) + "";
                Operation.Text = "";
            }

            if (CalculateDisplay.Text == "" && Number1.Text != "" && Operation.Text != "")
            {
                operation = "/";
                Operation.Text = "/";
            }
            else
            {
                numberFirst = Convert.ToInt32(CalculateDisplay.Text);
                operation = "/";
                CalculateDisplay.Text = "";
                Number1.Text = numberFirst + "";
                Operation.Text = "/";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            if (Number1.Text != "" && CalculateDisplay.Text != "" && Operation.Text != "")
            {
                string newNumber = prevNumber;
                CalculateDisplay.Text = ResultEquals(Number1.Text, newNumber, operation) + "";
                Operation.Text = "";
            }

            if (CalculateDisplay.Text == "" && Number1.Text != "" && Operation.Text != "")
            {
                operation = "*";
                Operation.Text = "*";
            }
            else
            {
                numberFirst = Convert.ToInt32(CalculateDisplay.Text);
                operation = "*";
                CalculateDisplay.Text = "";
                Number1.Text = numberFirst + "";
                Operation.Text = "*";
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (Number1.Text != "" && CalculateDisplay.Text != "" && Operation.Text != "")
            {
                string newNumber = prevNumber;
                CalculateDisplay.Text = ResultEquals(Number1.Text, newNumber, operation) + "";
                Operation.Text = "";
            }

            if (CalculateDisplay.Text == "" && Number1.Text != "" && Operation.Text != "")
            {
                operation = "^";
                Operation.Text = "^";
            }
            else
            {
                numberFirst = Convert.ToInt32(CalculateDisplay.Text);
                operation = "^";
                CalculateDisplay.Text = "";
                Number1.Text = numberFirst + "";
                Operation.Text = "^";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numberFirst = Convert.ToInt32(CalculateDisplay.Text);
            CalculateDisplay.Text = "";
            Number1.Text = numberFirst + "";
            Operation.Text = "";
        }

        private void Result_Click(object sender, EventArgs e)
        {
            if (
                Number1.Text == "" ||
                CalculateDisplay.Text == "" ||
                operation == "" ||
                (Number1.Text == "" && operation == "") ||
                (CalculateDisplay.Text == "" && operation == "")
                )
            {
                Number1.Text = "Error :Value is empty";
                Error.Text = "Clear me =>";
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        CalculateDisplay.Text = (MathCalculater.Addition(Convert.ToInt32(Number1.Text), Convert.ToInt32(CalculateDisplay.Text))) + "";
                        break;

                    case "-":
                        CalculateDisplay.Text = (MathCalculater.Subtraction(Convert.ToInt32(Number1.Text), Convert.ToInt32(CalculateDisplay.Text))) + "";
                        break;

                    case "*":
                        CalculateDisplay.Text = (MathCalculater.Multiplication(Convert.ToInt32(Number1.Text), Convert.ToInt32(CalculateDisplay.Text))) + "";
                        break;

                    case "/":
                        if ( Number1.Text != "" && CalculateDisplay.Text == "0")
                        {
                            Number1.Text = "";
                            Operation.Text = "";
                            Error.Text = "Sorry, Error! On 0 division is imposible";
                        }
                        else if (Convert.ToInt32(Number1.Text) % 2 != 0)
                        {
                            CalculateDisplay.Text = Convert.ToDouble(Number1.Text) / Convert.ToDouble(CalculateDisplay.Text) + "";
                        }
                        else
                        {
                            CalculateDisplay.Text = (MathCalculater.Division(Convert.ToInt32(Number1.Text), Convert.ToInt32(CalculateDisplay.Text))) + "";
                        }
                        break;

                    case "^":
                        CalculateDisplay.Text = (MathCalculater.Sqrt(Convert.ToInt32(Number1.Text), Convert.ToInt32(CalculateDisplay.Text))) + "";
                        break;

                    default:
                        Error.Text = "Я хз что ты сделал и как ты меня сломал";
                        break;
                }
            }
            Number1.Text = "";
            Operation.Text = "";
            Error.Text = "";
            operation = "";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            numberFirst = 0;
            CalculateDisplay.Text = "";
            operation = "";
            Number1.Text = "";
            Error.Text = "";
        }

        public static double ResultEquals(string number, string number2, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = MathCalculater.Addition(Convert.ToInt32(number), Convert.ToInt32(number2));
                    break;

                case "-":
                    result = MathCalculater.Subtraction(Convert.ToInt32(number), Convert.ToInt32(number2));
                    break;

                case "*":
                    result = MathCalculater.Multiplication(Convert.ToInt32(number), Convert.ToInt32(number2));
                    break;

                case "/":
                    if (Convert.ToInt32(number) % 2 != 0)
                    {
                        result = Convert.ToDouble(number) / Convert.ToDouble(number2);
                    }
                    else
                    {
                        result = MathCalculater.Division(Convert.ToInt32(number), Convert.ToInt32(number2));
                    }
                    break;

                case "^":
                    result = MathCalculater.Sqrt(Convert.ToInt32(number), Convert.ToInt32(number2));
                    break;

                default:
                    break;
            }
            return result;
        }

        private void buttonPlusMin_Click(object sender, EventArgs e)
        {
            CalculateDisplay.Text = (Convert.ToInt32(CalculateDisplay.Text) * (- 1)) + "";
        }
    }
}
