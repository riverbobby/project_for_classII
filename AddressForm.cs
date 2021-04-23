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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
            //next line for testing
            Globals.CurrentAddressID = 2;
            if (Globals.CurrentAddressID != -1)
            {
                //populating current address from CurrentAddressID
                LookupAddress(Globals.CurrentAddressID);
                addressIdTextBox.Text = Globals.CurrentAddress.AddressID.ToString();
                addressTextBox.Text = Globals.CurrentAddress.AddressField;
                address2TextBox.Text = Globals.CurrentAddress.AddressField2;
                cityComboBox.SelectedValue = Globals.CurrentAddress.CityID;
                postalCodeTextBox.Text = Globals.CurrentAddress.PostalCode;
                phoneTextBox.Text = Globals.CurrentAddress.Phone;
                createdOnLabel.Text = Globals.CurrentAddress.CreateDate.ToString();
                createdByLabel.Text = Globals.CurrentAddress.CreatedBy;
                lastUpdateOnLabel.Text = Globals.CurrentAddress.LastUpdate.ToString();
                updatedByLabel.Text = Globals.CurrentAddress.LastUpdateBy;
            }
            else
            {
                addressIdTextBox.Text = "Auto generated when saved";
            }
        }
        private void LookupAddress(int ID)
        {
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"SELECT * FROM address WHERE addressId = {ID}";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Globals.CurrentAddress = new Address(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5),
                        rdr.GetDateTime(6), rdr.GetString(7), rdr.GetDateTime(8), rdr.GetString(9));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
        }
        private void LoadCities(BindingList<City> Cities)
        {
            try
            {
                Cities.Clear();
                Globals.conn.Open();
                // Perform database operations
                string sql = "SELECT * FROM city";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Cities.Add(new City(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2),
                        rdr.GetDateTime(3), rdr.GetString(4), rdr.GetDateTime(5), rdr.GetString(6)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
        }

        //refreshes combobox when form is loaded or hidden
        private void AddressForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadCities(Globals.Cities);
            cityComboBox.DataSource = Globals.Cities;
            cityComboBox.DisplayMember = "CityName";
            cityComboBox.ValueMember = "CityID";

        }

        private void addCityButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Globals.CityForm1 = new CityForm();
            Globals.CityForm1.Show();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validating fields
            StringBuilder message = new StringBuilder();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                message.Append("Please enter a valid address\n");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text))
            {
                message.Append("Please enter a valid postal code\n");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                message.Append("Please enter a valid phone number\n");
                valid = false;
            }
            if (valid)
            {
                //if new address
                if (Globals.CurrentAddressID == -1)
                {
                    DateTime theDate = DateTime.UtcNow;
                    string myBuilder = $"\'0\', \'{addressTextBox.Text}\', \'{address2TextBox.Text}\', " +
                        $"\'{cityComboBox.SelectedValue}\', \'{postalCodeTextBox.Text}\', " +
                        $"\'{phoneTextBox.Text}\', \'{Globals.toSqlDate(theDate)}\', " +
                        $"\'{Globals.CurrentUser.UserName}\', \'{Globals.toSqlDate(theDate)}\', " +
                        $"\'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Insert($"address", myBuilder))
                    {
                        this.Close();
                        Globals.AddressForm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save at this time");
                    }

                }
                //if updating address
                else
                {
                    DateTime theDate = DateTime.UtcNow;
                    string myBuilder = $"address = \'{addressTextBox.Text}\', address2 = \'{address2TextBox.Text}\', " +
                        $"cityId = \'{cityComboBox.SelectedValue}\', postalCode = \'{postalCodeTextBox.Text}\', " +
                        $"phone = \'{phoneTextBox.Text}\', lastUpdate = \'{Globals.toSqlDate(theDate)}\', " +
                        $"lastUpdateBy = \'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Update($"address", myBuilder, "addressId", Globals.CurrentAddress.AddressID))
                    {
                        Globals.CurrentAddressID = -1;
                        this.Close();
                        Globals.AddressForm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save at this time");
                    }
                }

            }
            else
            {
                MessageBox.Show(message.ToString());
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.CustomerForm1.Show();
        }
    }
}
