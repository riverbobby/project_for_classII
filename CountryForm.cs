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
    public partial class CountryForm : Form
    {
        public CountryForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CityForm cityForm = new CityForm();
            cityForm.Show();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                MessageBox.Show("Please enter a valid country name");
            }
            else
            {
                DateTime theDate = DateTime.UtcNow;
                string myBuilder = $"\'0\', \'{countryTextBox.Text}\', " +
                    $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\', " +
                    $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\'";
                if (Globals.Insert($"country", myBuilder)) 
                {
                    this.Hide();
                    CityForm cityForm = new CityForm();
                    cityForm.Show();
                }
                else
                {
                    MessageBox.Show("Unable to save at this time");
                }
            }
        }
    }
}
