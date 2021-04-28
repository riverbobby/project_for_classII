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
            customersRadioButton.Checked = true;
            //formatting dateTimePicker
            dateTimePicker.CustomFormat = "MM/yyyy";
            dateTimePicker.ShowUpDown = true;
            //populating comboBox
            comboBox.DataSource = Globals.Users;
            comboBox.DisplayMember = "UserName";
            comboBox.ValueMember = "UserID";
            //formatting displayDataGridView
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            //loading displayDataGridView
            RefreshDisplay();
        }
        private void customersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
        private void appointmentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
        private void appointments1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (appointmentsRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                appointmentsRadioButton.Checked = true;
            }
        }
        private void appointments2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (appointmentsRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                appointmentsRadioButton.Checked = true;
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (appointments2RadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                appointments2RadioButton.Checked = true;
            }
        }
        private void reportRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
        private void report1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (reportRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                reportRadioButton.Checked = true;
            }
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (report1RadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                report1RadioButton.Checked = true;
            }

        }
        private void report2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (reportRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                reportRadioButton.Checked = true;
            }

        }
        private void report3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (reportRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                reportRadioButton.Checked = true;
            }

        }
        private void calendarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RefreshDisplay();
        }
        private void calendarWeekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (calendarRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                calendarRadioButton.Checked = true;
            }
        }
        private void calendarMonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (calendarRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                calendarRadioButton.Checked = true;
            }
        }
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (calendarRadioButton.Checked)
            {
                RefreshDisplay();
            }
            else
            {
                calendarRadioButton.Checked = true;
            }
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
                RefreshDisplay();
            }
            else
            {
                if (Globals.Delete("appointment", "appointmentId", Globals.CurrentAppointmentID))
                {
                    appointmentsRadioButton.Checked = true;
                }
                RefreshDisplay();
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
                Globals.CurrentCustomerID = (int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value;
                LookupCustomer(Globals.CurrentCustomerID);
                displayDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            }
            else
            {
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
                displayTitleLabel.Text = "All Customers";
                addButton.Text = "Add New Customer";
            }
            else
            {
                addButton.Text = "Add New Appointment";
                LoadAppointments(Globals.Appointments);
                if (appointmentsRadioButton.Checked)
                {
                    if (appointments1RadioButton.Checked)
                    {
                        displayDataGridView.DataSource = Globals.Appointments;
                        displayTitleLabel.Text = "All Appointments";
                    }
                    else
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        comboBox.ValueMember = "UserID";
                        //following lambda statement used for LINQ filtering that are for the selected consultant
                        foreach (Appointment app in Globals.Appointments.Where<Appointment>(i => i.UserID == (int)comboBox.SelectedValue))
                        {
                            display.Add(app);
                        }
                        displayDataGridView.DataSource = display;
                        displayTitleLabel.Text = "Appointments by Consultant";
                    }
                }
                else if (reportRadioButton.Checked)
                {
                    if (report1RadioButton.Checked)
                    {
                        BindingList<string> unique = new BindingList<string>();
                        BindingList<string> strings = new BindingList<string>();
                        int month = (int)dateTimePicker.Value.Month;
                        int year = (int)dateTimePicker.Value.Year;
                        //following lambda is used for LINQ filtering of appointments occuring in selected month and year
                        foreach (Appointment i in Globals.Appointments.Where<Appointment>(app => app.Start.Month == month && app.Start.Year == year))
                        {
                            if (!unique.Contains(i.TypeOfAppointment))
                            {
                                unique.Add(i.TypeOfAppointment);
                            }
                        }
                        strings.Append($"There are {unique.Count} appointment types in the selected month:");
                        int count;
                        foreach (string i in unique)
                        {
                            count = 0; 
                            foreach (Appointment j in Globals.Appointments)
                            {
                                if (i == j.TypeOfAppointment)
                                {
                                    ++count;
                                }
                            }
                            strings.Add($"{count} of type {i}");
                        }
                        var result = strings.Select(s => new { value = s }).ToList();
                        displayDataGridView.DataSource = result;
                        displayDataGridView.ColumnHeadersVisible = false;
                        displayTitleLabel.Text = "Number of Appointment Types by Month";
                    }
                    else if (report2RadioButton.Checked)
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        //following lambda is used for LINQ filtering of appointments that occur after the current DateTime
                        foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => app.Start >= DateTime.Now))
                        {
                            display.Add(app);
                        }
                        displayDataGridView.DataSource = display;
                        displayTitleLabel.Text = "Upcoming Appointments";
                    }
                    else
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        //following lambda statement used for LINQ filtering of appointments that occur before the current DateTime
                        foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => app.End <= DateTime.Now))
                        {
                            display.Add(app);
                        }
                        displayDataGridView.DataSource = display;
                        displayTitleLabel.Text = "Past Appointments";
                    }
                }
                else
                {
                    if (calendarWeekRadioButton.Checked)
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        TimeSpan timeSpan = new TimeSpan(-(int)monthCalendar.SelectionStart.DayOfWeek,
                            -(int)monthCalendar.SelectionStart.Hour, -(int)monthCalendar.SelectionStart.Minute,
                            -(int)monthCalendar.SelectionStart.Second);
                        DateTime weekBegin = monthCalendar.SelectionStart.Add(timeSpan);
                        DateTime weekEnd = weekBegin.AddDays(7);
                        //following lambda statement used for LINQ filtering appointments that occur in the selected week
                        foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => DateTime.Compare(app.Start, weekBegin) > 0 && DateTime.Compare(app.End, weekEnd) < 0))
                        {
                            display.Add(app);
                        }
                        displayDataGridView.DataSource = display;
                        displayTitleLabel.Text = "Appointments for Selected Week";
                    }
                    else
                    {
                        BindingList<Appointment> display = new BindingList<Appointment>();
                        int month = (int)monthCalendar.SelectionStart.Month;
                        int year = (int)monthCalendar.SelectionStart.Year;
                        //following lambda is used for LINQ filtering of appointments occuring in selected month and year
                        foreach (Appointment i in Globals.Appointments.Where<Appointment>(app => app.Start.Month == month && app.Start.Year == year))
                        {
                            display.Add(i);
                        }
                        displayDataGridView.DataSource = display;
                        displayTitleLabel.Text = "Appointments for Selected Month";
                    }
                }
            }
        }
        private void ResetGlobals()
        {
            Globals.CurrentAppointmentID = -1;
            Globals.CurrentCustomerID = -1;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;



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
