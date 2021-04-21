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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void testingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityForm cityForm = new CityForm();
            cityForm.Show();
        }
    }
}
