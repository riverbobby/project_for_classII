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
            //next line for testing
            Globals.CurrentCustomerID = 2;
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
                createdOnLabel.Text = Globals.CurrentCustomer.CreateDate.ToString();
                createdByLabel.Text = Globals.CurrentCustomer.CreatedBy;
                lastUpdateOnLabel.Text = Globals.CurrentCustomer.LastUpdate.ToString();
                updatedByLabel.Text = Globals.CurrentCustomer.LastUpdateBy;
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
    }
}
