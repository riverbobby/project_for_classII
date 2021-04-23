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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
            //populating countries combobox
            BindingList<Country> countries = new BindingList<Country>();
            try
            {
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
            displayDataGridView.DataSource = countries;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        //testing button
        private void testingButton_Click(object sender, EventArgs e)
        {
            //deleted next line for testing
            //Globals.CurrentAddressID = -1;
            this.Close();
            Globals.AddressForm1 = new AddressForm();
            Globals.AddressForm1.Show();
        }
    }
}
