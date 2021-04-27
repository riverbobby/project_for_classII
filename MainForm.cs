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
            RefreshDisplay();
            //formatting dateTimePicker
            dateTimePicker.CustomFormat = "MM/yyyy";
            dateTimePicker.ShowUpDown = true;
            //populating comboBox
            LoadUsers(Globals.Users);
            comboBox.DataSource = Globals.Users;
            comboBox.DisplayMember = "UserName";
            comboBox.ValueMember = "UserID";
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
            displayTitleLabel.Text = "All Customers";
            addButton.Text = "Add New Customer";
        }
        private void appointmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetGlobals();
            LoadAppointments(Globals.Appointments);
            displayDataGridView.DataSource = Globals.Appointments;
            displayTitleLabel.Text = "All Appointments";
            addButton.Text = "Add New Appointment";
        }
        private void appointments1RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void appointments2RadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (customersRadioButton.Checked)
            {
                ResetGlobals();
                this.Close();
                Globals.CustomerForm1 = new CustomerForm();
                Globals.CustomerForm1.Show();
            }
            else
            {
                ResetGlobals();
                this.Close();
                Globals.AppointmentForm1 = new AppointmentForm();
                Globals.AppointmentForm1.Show();
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            if (customersRadioButton.Checked)
            {
                this.Close();
                Globals.CustomerForm1 = new CustomerForm();
                Globals.CustomerForm1.Show();
            }
            else
            {
                this.Close();
                Globals.AppointmentForm1 = new AppointmentForm();
                Globals.AppointmentForm1.Show();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (customersRadioButton.Checked)
            {
                if (Globals.Delete("customer", "customerId", Globals.CurrentCustomerID))
                {
                    customersRadioButton.Checked = true;
                }
            }
            else
            {
                if (Globals.Delete("appointment", "appointmentId", Globals.CurrentAppointmentID))
                {
                    appointmentsRadioButton.Checked = true;
                }
            }
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void displayDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
            if (customersRadioButton.Checked)
            {
                MessageBox.Show($"{(int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value}");
                Globals.CurrentCustomerID = (int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value;
                LookupCustomer(Globals.CurrentCustomerID);
                displayDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            }
            else
            {
                MessageBox.Show($"{(int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value}");
                Globals.CurrentAppointmentID = (int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value;
                LookupAppointment(Globals.CurrentAppointmentID);
                displayDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            }
        }
        private void RefreshDisplay()
        {
            ResetGlobals();
            //decision tree for what to populate in displayDataGridView
            if (customersRadioButton.Checked)
            {
                LoadCustomers(Globals.Customers);
                displayDataGridView.DataSource = Globals.Customers;
            }
            else
            {
                LoadAppointments(Globals.Appointments);
                if (appointmentsRadioButton.Checked)
                {
                    if (appointments1RadioButton.Checked)
                    {
                        displayDataGridView.DataSource = Globals.Appointments;
                    }
                    else
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        //following lambda statement used
                        foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => app.UserID == (int)comboBox.SelectedValue))
                        {
                            display.Add(app);
                        }
                        displayDataGridView.DataSource = display;
                    }
                }
                else if (reportRadioButton.Checked)
                {
                    if (report1RadioButton.Checked)
                    {

                    }
                    else if (report2RadioButton.Checked)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {

                }
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
        private void LoadUsers(BindingList<User> users)
        {
            try
            {
                users.Clear();
                Globals.conn.Open();
                // Perform database operations
                string sql = "SELECT * FROM user";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    users.Add(new User(rdr.GetInt32(0), rdr.GetString(1)));

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MySQL...");
            }
            Globals.conn.Close();
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
        private void LookupAppointment(int ID)
        {
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"SELECT * FROM appointment WHERE appointmentId = {ID}";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Globals.CurrentAppointment = new Appointment(rdr.GetInt32(0), rdr.GetInt32(1),
                        rdr.GetInt32(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5),
                        rdr.GetString(6), rdr.GetString(7), rdr.GetString(8), rdr.GetDateTime(9),
                        rdr.GetDateTime(10), rdr.GetDateTime(11), rdr.GetString(12), rdr.GetDateTime(13),
                        rdr.GetString(14));
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
