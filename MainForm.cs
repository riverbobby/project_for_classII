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
            //resetting globals from selections
            ResetGlobals();
            //formatting dateTimePicker
            dateTimePicker.CustomFormat = "MM/yyyy";
            dateTimePicker.ShowUpDown = true;
            //populating displayDataGridView
            LoadCustomers(Globals.Customers);
            displayDataGridView.DataSource = Globals.Customers;
            //formatting displayDataGridView
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
        }
        private void customersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetGlobals();
            LoadCustomers(Globals.Customers);
            displayDataGridView.DataSource = Globals.Customers;
        }
        private void appointmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetGlobals();
            LoadAppointments(Globals.Appointments);
            displayDataGridView.DataSource = Globals.Appointments;
        }
        private void appointments1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appointmentsRadioButton.Checked = true;
        }
        private void appointments2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            appointmentsRadioButton.Checked = true;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            appointmentsRadioButton.Checked = true;
        }
        private void reportRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void report1RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void report2RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void report3RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void calendarRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void calendarWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void calendarMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {

        }
        private void editButton_Click(object sender, EventArgs e)
        {

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void displayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customersRadioButton.Checked)
            {
                
            }
        }
        private void ResetGlobals()
        {
            Globals.CurrentAppointmentID = -1;
            Globals.CurrentCustomerID = -1;
        }
        private void LoadCustomers(BindingList<Customer> customers)
        {
            try
            {
                customers.Clear();
                Globals.conn.Open();
                // Perform database operations
                string sql = "SELECT * FROM customer";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    customers.Add(new Customer(rdr.GetInt32(0), rdr.GetString(1),
                        rdr.GetInt32(2), rdr.GetInt32(3), rdr.GetDateTime(4), rdr.GetString(5),
                        rdr.GetDateTime(6), rdr.GetString(7)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
        }
        private void LoadAppointments(BindingList<Appointment> appointments)
        {
            try
            {
                appointments.Clear();
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
        }
    }
}
