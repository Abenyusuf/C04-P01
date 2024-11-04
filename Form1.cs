// Ahmed Benyusuf
// Class and Section (CS 313 01)
// Assignment (Program 01 Chapter 04)
// Description of the Program: This program will use the input of the amount of books and output the amount of points the user has earned
// Extra credit was also completed using a checkbox




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {
            // (Sorry i accidentally clicked this.)
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            // This will exit and close the form
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Creates a double to be used for calculations 
            double zero, five, fifteen, thirty, sixty, books, result;
            zero = 0;
            five = 1;
            fifteen = 2;
            thirty = 3;
            sixty = 4;

            if (double.TryParse(InputTextbox.Text, out books)) // Convert the input into the double books
            {
                // Checks to see if the amount of books will suit the amount of points
                if (books == zero)
                {
                    result = 0;
                }
                else if (books == five)
                {
                    result = 5;
                }
                else if (books == fifteen)
                {
                    result = 15;
                }
                else if (books == thirty)
                {
                    result = 30;
                }
                else if (books >= sixty)
                {
                    result = 60;
                }
                else
                {
                    OutputLabel.Text = "Invalid input";  
                    // This is used to handle invalid numeric input
                    return; 
                    // This will exit the method early since input is invalid
                }

                // Checks if user is over 55 is checked, and double the points if true
                if (AgeCheck.Checked)
                {
                    result *= 2; 
                    // If the user is over 55 and the box is checked this will double the points
                }

                // Displays the result in the OutputLabel
                OutputLabel.Text = result.ToString();
            }
            else
            {
                OutputLabel.Text = "Invalid number"; 
                // This will handle invalid numeric input
            }
        }
    }
}
