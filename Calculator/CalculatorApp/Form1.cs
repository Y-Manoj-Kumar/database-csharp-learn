using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {

        // initialising global variables

        string first = ""; // a
        string second = ""; //b    input vlaues
        char function; // for storing the respective operation
        double result = 0.0; // hold the result 
        string userInput = "";

        bool isFirstCalculated = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = ""; // += is used to add the upcoming value
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            first = "";
            second = "";           // resetting every single value 
            userInput = "";
            result = 0.0;
            calculatorDisplay.Text = "0";
            
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            HandleInputs();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            HandleInputs();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            HandleInputs();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            HandleInputs();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            //check if first and userinput is empty 
            if (first == "" || userInput =="")
            {
                return;
            }

            Calculate();
            userInput = "";
        }
        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text = "";
            userInput += "0"; 
            calculatorDisplay.Text += userInput;
        }


        private void Calculate()
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            // Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                calculatorDisplay.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    calculatorDisplay.Text = "Please enter correct input";
                }
                else
                {
                    result = firstNum / secondNum;
                    calculatorDisplay.Text = result.ToString();
                }

            }
            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                calculatorDisplay.Text = result.ToString();
            }

            //send result to first
            first = result.ToString();  // Here result is resetting to first
        }

        public void HandleInputs()
        {
            //check if userinput is empty
            if (userInput == "")
            {
                return;
            }

            //user presses this button after second input
            if (first != "")
            {
                //first = 1
                //second and user input = 2
                Calculate();

                //send result to first
                first = result.ToString();

                //reset user input
                userInput = "";
            }
            else
            {
                //user presses this button after first input
                //user input = 1
                first = userInput;
                userInput = "";
            }

        }
    }
}
