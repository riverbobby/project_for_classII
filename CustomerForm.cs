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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            if (Globals.CurrentCustomerID != -1)
            {
                //populating current address from CurrentAddressID
                LookupCustomer(Globals.CurrentCustomerID);
                customerIdTextBox.Text = Globals.CurrentCustomer.CustomerID.ToString();
                nameTextBox.Text = Globals.CurrentCustomer.Name;
                addressComboBox.SelectedValue = Globals.CurrentCustomer.AddressID;
                string[] arr = { "No", "Yes" };
                activeComboBox.DataSource = arr;
                activeComboBox.SelectedIndex = Globals.CurrentCustomer.Active;
                createdOnLabel.Text = $"created on {Globals.CurrentCustomer.CreateDate.ToString()}";
                createdByLabel.Text = $"by {Globals.CurrentCustomer.CreatedBy}";
                lastUpdateOnLabel.Text = $"updated on {Globals.CurrentCustomer.LastUpdate.ToString()}";
                updatedByLabel.Text = $"by {Globals.CurrentCustomer.LastUpdateBy}";
            }
            else
            {
                customerIdTextBox.Text = "Auto generated when saved";
                string[] arr = { "No", "Yes" };
                activeComboBox.DataSource = arr;

            }

        }
        private void LookupCustomer(int ID)
        {
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"SELECT * FROM customer WHERE customerId = {ID}";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Globals.CurrentCustomer = new Customer(rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetInt32(2), rdr.GetInt32(3), rdr.GetDateTime(4), rdr.GetString(5),
                        rdr.GetDateTime(6), rdr.GetString(7));
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
        }
        private void LoadAddresses(BindingList<Address> addresses)
        {
            try
            {
                addresses.Clear();
                Globals.conn.Open();
                // Perform database operations
                string sql = "SELECT * FROM address";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    addresses.Add(new Address(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2),
                        rdr.GetInt32(3), rdr.GetString(4), rdr.GetString(5),
                        rdr.GetDateTime(6), rdr.GetString(7), rdr.GetDateTime(8), rdr.GetString(9)));

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
        private void CustomerForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadAddresses(Globals.Addresses);
            addressComboBox.DataSource = Globals.Addresses;
            addressComboBox.DisplayMember = "AddressField";
            addressComboBox.ValueMember = "AddressID";

        }

        private void addAddressButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentAddressID = -1;
            this.Hide();
            Globals.AddressForm1 = new AddressForm();
            Globals.AddressForm1.Show();

        }
        private void updateAddressButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentAddressID = (int)addressComboBox.SelectedValue;
            this.Hide();
            Globals.AddressForm1 = new AddressForm();
            Globals.AddressForm1.Show();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentCustomerID = -1;
            this.Close();
            if (Application.OpenForms.OfType<AppointmentForm>().Any())
            {
                Globals.AppointmentForm1.Show();
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validating fields
            StringBuilder message = new StringBuilder();
            bool valid = true;
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                message.Append("Please enter a valid name\n");
                valid = false;
            }
            if (valid)
            {
                int active;
                if (activeComboBox.SelectedValue.ToString() == "Yes")
                {
                    active = 1;
                }
                else
                {
                    active = 2;
                }
                //if new customer
                if (Globals.CurrentCustomerID == -1)
                {
                    DateTime theDate = DateTime.UtcNow;
                    string myBuilder = $"\'0\', \'{nameTextBox.Text}\', \'{addressComboBox.SelectedValue}\', " +
                        $"\'{active}\', \'{Globals.toSqlDate(theDate)}\', " +
                        $"\'{Globals.CurrentUser.UserName}\', \'{Globals.toSqlDate(theDate)}\', " +
                        $"\'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Insert($"customer", myBuilder))
                    {
                        this.Close();
                        if (Application.OpenForms.OfType<AppointmentForm>().Any())
                        {
                            Globals.AppointmentForm1.Show();
                        }
                        else
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
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
                    string myBuilder = $"customerName = \'{nameTextBox.Text}\', addressId = \'{addressComboBox.SelectedValue}\', " +
                        $"active = \'{active}\', lastUpdate = \'{Globals.toSqlDate(theDate)}\', " +
                        $"lastUpdateBy = \'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Update($"customer", myBuilder, "customerId", Globals.CurrentCustomer.CustomerID))
                    {
                        Globals.CurrentAddressID = -1;
                        this.Close();
                        if (Application.OpenForms.OfType<AppointmentForm>().Any())
                        {
                            Globals.AppointmentForm1.Show();
                        }
                        else
                        {
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
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
    }
}
