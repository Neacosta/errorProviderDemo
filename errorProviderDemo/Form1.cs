using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace errorProviderDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {//validating user input and turning on the error provider if the input is not valid
            if (passwordTextBox.Text!="Mike")
            {
                MessageBox.Show("Please enter correct password");
                passwordErrorProvider.SetError(passwordTextBox, "Password is not valid");
            }
            else
            {
                //turning off the error provider if the input is valid
                MessageBox.Show("Welcome");
                passwordErrorProvider.SetError(passwordTextBox, null);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clearing the textbox and error provider
            passwordErrorProvider.SetError(passwordTextBox, null);
            passwordTextBox.Clear();
        }
    }
}
