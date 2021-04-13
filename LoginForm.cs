using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustinTownleySoftwareII
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Globals.fileWriter.Close();
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string messageBuilder = "Please fix the folling issues:\n";
            bool invalid = false;
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                invalid = true;
                messageBuilder += "Please enter a username\n";
            }
            Globals.fileWriter
        }
    }
}
