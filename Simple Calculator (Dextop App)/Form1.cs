using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDApp
{
    public partial class Form1 : Form
    {
       double variable;
       double result = 0;
        string operatr = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void button26_Click(object sender, EventArgs e)
        {          
            inputTextBox.Text = inputTextBox.Text + 0;
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text+1;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                variable = Convert.ToDouble(inputTextBox.Text);
                inputTextBox.Clear();
                operatrTextBox.Text = operatrTextBox.Text + "+";
                operatr = "+";
            }
            catch(Exception)
            {
                operatrTextBox.Text = "+";
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operatr)
                {
                    case "+":
                        result = variable + Convert.ToDouble(inputTextBox.Text);
                        outputTextBox.Text = variable + " + " + Convert.ToDouble(inputTextBox.Text) + " = " + result.ToString();
                        break;
                    case "-":
                        result = variable - Convert.ToDouble(inputTextBox.Text);
                        outputTextBox.Text = variable + " - " + Convert.ToDouble(inputTextBox.Text) + " = " + result.ToString();
                        break;
                    case "*":
                        result = variable * Convert.ToDouble(inputTextBox.Text);
                        outputTextBox.Text = variable + " * " + Convert.ToDouble(inputTextBox.Text) + " = " + result.ToString();
                        break;
                    case "/":
                        result = variable / Convert.ToDouble(inputTextBox.Text);
                        outputTextBox.Text = variable + " / " + Convert.ToDouble(inputTextBox.Text) + " = " + result.ToString();
                        break;
                }
                operatrTextBox.Clear();
            }
            catch(Exception)
            {
                outputTextBox.Text = "Syntax Error"; 
            }            
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 2;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 3;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 4;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 5;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 7;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 8;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + 9;
        }
       
    
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                variable = Convert.ToDouble(inputTextBox.Text);
                inputTextBox.Clear();
                operatrTextBox.Text = operatrTextBox.Text + "-";
                operatr = "-";
            }
            catch(Exception) 
            {
                operatrTextBox.Text = "-";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                variable = Convert.ToDouble(inputTextBox.Text);
                inputTextBox.Clear();
                operatrTextBox.Text = operatrTextBox.Text + "*";
                operatr = "*";
            }
            catch(Exception)
            {
                operatrTextBox.Text = "*";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                variable = Convert.ToDouble(inputTextBox.Text);
                inputTextBox.Clear();
                operatrTextBox.Text = operatrTextBox.Text + "/";
                operatr = "/";
            }
            catch(Exception)
            {
                operatrTextBox.Text = "/";
            }
        }
   
        private void button9_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            operatrTextBox.Clear();
            outputTextBox.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            operatrTextBox.Clear();
            outputTextBox.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text + ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(inputTextBox.Text);
                double result = 1 / value;
                operatrTextBox.Text = " reciproc (" + value + ")";
                outputTextBox.Text = result.ToString();
            }
            catch(Exception)
            {
                inputTextBox.Text = " reciproc (0)";
                outputTextBox.Text = "Can not Divided By Zero";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double route = Convert.ToDouble(inputTextBox.Text);
                inputTextBox.Clear();
                inputTextBox.Text = "Sqrt (" + route + ")";
                outputTextBox.Text = (Math.Sqrt(route)).ToString();
            }
            catch(Exception)
            {
                inputTextBox.Text = " Sqrt (0)";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(inputTextBox.Text.Length>0)
            {
                inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length-1);
            }
        }
        }
    }
