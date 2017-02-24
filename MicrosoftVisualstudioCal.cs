using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Cal
{
    public partial class Form1 : Form
    {
        Double Value = 0; // Number's value
        String Operation = ""; // Operation
        bool operation_pressed = false; // When pressed
        public Form1()
        {
            InitializeComponent();// run component
        }


        private void button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || (operation_pressed)) // If the result text is 0 or the operation was press, clear the result
            {
                result.Clear();

            }
            operation_pressed = false; // after it true make the operation pressed back to false
            Button b = (Button)sender ; // get information from the button
            result.Text = result.Text + b.Text;// print out the result text and button text that press
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result.Text = "0"; // Return the result to 0 once press CE
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;// Get the information when click
            Operation = b.Text; //The operation string is the press button
            Value = Double.Parse(result.Text);// convert the result text to value
            operation_pressed = true; // Clear the result for the next number
            equation.Text = Value + " " + Operation; // print out the value and operation in the label
        }

        private void button24_Click(object sender, EventArgs e)
        {
            equation.Text = ""; // Return the label back to nothing 
            switch(Operation)// 
            {
                case"+": // when it + it does +
                    result.Text = (Value + Double.Parse(result.Text)).ToString();
                    break;
                case"-":
                    result.Text = (Value - Double.Parse(result.Text)).ToString();
                    break;
                case"*":
                    result.Text = (Value * Double.Parse(result.Text)).ToString();
                    break;
                case"/":
                    result.Text = (Value / Double.Parse(result.Text)).ToString();
                    break;
          
            }
         
        }


        private void button22_Click_1(object sender, EventArgs e)
        {
            result.Clear();
            Value = 0;
        }
    }
}
