using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPractice
{
    public partial class calculator : Form
       

    {
        Double value = 0;
        string operation = "";
        bool operation_pressed = false;


        public calculator()
        {
            InitializeComponent();
        }

        

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operation_pressed))
                txtResult.Clear();


            operation_pressed = false;
            Button b = (Button)sender;

            if (b.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + b.Text;
            }
            else

                txtResult.Text = txtResult.Text + b.Text;
            label1.Focus();
            //Button b = (Button)sender;
            //txtResult.Text = txtResult.Text + b.Text;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equals.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + "" + operation;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(txtResult.Text);
                operation_pressed = true;
                equation.Text = value + "" + operation;
            }
        }

        private void calculator_Load(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    txtResult.Text = (value + Double.Parse(txtResult.Text)).ToString() ;
                    break;
                case "-":
                    txtResult.Text = (value - Double.Parse(txtResult.Text)).ToString();
                    break;
                case "X":
                    txtResult.Text = (value * Double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (value / Double.Parse(txtResult.Text)).ToString();
                    break;
                default :
                    break;
            }
            value = double .Parse(txtResult.Text);
            operation = "";
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            value = 0;
            equation.Text = "";

        }

        private void calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case ".":
                    decimalPoint.PerformClick();
                    break;
                case "+":
                    addition.PerformClick();
                    break;
                case "-":
                    subtraction.PerformClick();
                    break;
                case "/":
                    division.PerformClick();
                    break;
                case "*":
                    multiplication.PerformClick();
                    break;

                case " ":
                    equals.PerformClick();
                    break;
                case "=":
                    equals.PerformClick();
                    break;
                case "\r":
                    equals.PerformClick();
                    break;
                case "esc":
                    clearEntry.PerformClick();
                    break;



                default:
                    break;

            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                clearEntry.PerformClick();
            }
            


            // backspace
            if (e.KeyChar == (char)Keys.Back)
            {
                //clearEntry.PerformClick();
                btnBackspace.PerformClick();
            }
           
        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true ;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtResult.Text = button1.Text;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if ((String.Compare(txtResult.Text, " ") < 0))
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1 + 1);
            }
            else
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }
    }
}
