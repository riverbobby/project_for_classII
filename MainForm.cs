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
            BindingList<Appointment> appointments = new BindingList<Appointment>();
            try
            {
                Globals.conn.Open();
                // Perform databaase operations
                string sql = "SELECT * FROM appointment";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    appointments.Add(new Appointment(rdr.GetInt32(0), rdr.GetInt32(1),
                        rdr.GetInt32(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5),
                        rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetDateTime(9),
                        rdr.GetDateTime(10), rdr.GetDateTime(11), rdr.GetString(12), rdr.GetDateTime(13),
                        rdr.GetString(14)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
            displayDataGridView.DataSource = appointments;
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
            //Globals.CurrentCustomerID = -1;
            this.Close();
            Globals.AppointmentForm1 = new AppointmentForm();
            Globals.AppointmentForm1.Show();
        }
    }
}
