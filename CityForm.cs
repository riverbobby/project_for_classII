using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace JustinTownleySoftwareII
{
    public partial class CityForm : Form
    {
        public CityForm()
        {
            InitializeComponent();
            cityIdTextBox.Text = "Auto generated when saved";
        }

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryForm countryForm = new CountryForm();
            countryForm.Show();
        }
        private void LoadCountries(BindingList<Country> countries)
        {
            try
            {
                countries.Clear();
                Globals.conn.Open();
                // Perform databaase operations
                string sql = "SELECT * FROM country";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    countries.Add(new Country(rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetDateTime(2), rdr.GetString(3), rdr.GetDateTime(4), rdr.GetString(5)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.AddressForm1.Show();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                message.Append("Please enter a valid city name\n");
                valid = false;
            }
            if (valid)
            {
                DateTime theDate = DateTime.UtcNow;
                string myBuilder = $"\'0\', \'{cityTextBox.Text}\', \'{countryComboBox.SelectedValue}\', " +
                    $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\', " +
                    $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\'";
                if (Globals.Insert($"city", myBuilder))
                {
                    this.Close();
                    Globals.AddressForm1.Show();
                }
                else
                {
                    MessageBox.Show("Unable to save at this time");
                }

            }
            else
            {
                MessageBox.Show(message.ToString());
            }
            

        }

        private void CityForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadCountries(Globals.Countries);
            //populating form
            countryComboBox.DataSource = Globals.Countries;
            countryComboBox.DisplayMember = "CountryName";
            countryComboBox.ValueMember = "CountryID";
        }
    }
}
