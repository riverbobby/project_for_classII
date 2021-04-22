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
            //populating cities combobox
            BindingList<City> cities = new BindingList<City>();
            try
            {
                Globals.conn.Open();
                // Perform databaase operations
                string sql = "SELECT * FROM city";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cities.Add(new City(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2),
                        rdr.GetDateTime(3), rdr.GetString(4), rdr.GetDateTime(5), rdr.GetString(6)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
            cityComboBox.DataSource = cities;
            cityComboBox.DisplayMember = "CityName";
            cityComboBox.ValueMember = "CityID";

        }
    }
}
