using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invigulus_ExamMaintenance
{
    public static class Validator
    {
        //Check if input from inputbox is provided
        public static bool IsPresent(TextBox inputBox, string name)
        {
            bool isValid = true;
            if (inputBox.Text == "") //empty input box
            {
                isValid = false;
                MessageBox.Show(name + " is required."); //show messagebox with error
                inputBox.Focus(); //Switch focus to inputbox
            }
            return isValid;
        }

        //Check if input from inputbox is a valid int and not negative
        public static bool IsNonNegativeInt(TextBox inputBox, string name)
        {
            bool isValid = true;
            int value; //parsed value
            if (!Int32.TryParse(inputBox.Text, out value)) //not an int
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }
            else if (value < 0) //input is negative
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }

            return isValid;
        }

        //Check if input from inputbox is a valid double and not negative
        public static bool IsNonNegativeDouble(TextBox inputBox, string name)
        {
            bool isValid = true;
            double value; //parsed value
            if (!Double.TryParse(inputBox.Text, out value)) //not a dobule
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }
            else if (value < 0) //negative is bad
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }

            return isValid;
        }

        //Checks if inputbox is non-negative or null
        public static bool IsNullOrNonNegInt(TextBox inputBox, string name)
        {
            bool isValid = true;
            int value; //parsed value

            if (!Int32.TryParse(inputBox.Text, out value) && !(inputBox.Text == "")) //not an int and not null
            {
                isValid = false;
                MessageBox.Show(name + " has to be a positive whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }
            else if (value < 0) //input is negative
            {
                isValid = false;
                MessageBox.Show(name + " has to be a whole number."); //show messagebox with error
                inputBox.SelectAll(); //Highlight bad input of inputbox
                inputBox.Focus(); //Switch focus to inputbox
            }

            return isValid;
        }
    }
}
