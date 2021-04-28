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
            //formatting dateTimePicker
            dateTimePicker.CustomFormat = "MM/yyyy";
            dateTimePicker.ShowUpDown = true;
            //populating comboBox
            comboBox.DataSource = Globals.Users;
            comboBox.DisplayMember = "UserName";
            comboBox.ValueMember = "UserID";
            comboBox.SelectedValue = Globals.CurrentUser.UserID;
        }
        private void customersButton_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadCustomers(Globals.Customers);
            displayDataGridView.DataSource = Globals.Customers;
            displayTitleLabel.Text = "All Customers";
            addButton.Text = "Add New Customer";
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 0;
            displayDataGridView.Columns["Name"].DisplayIndex = 1;
            displayDataGridView.Columns["AddressId"].DisplayIndex = 2;
            displayDataGridView.Columns["Active"].DisplayIndex = 3;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 4;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 5;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 6;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 7;
        }

        private void allAppointmentsButton_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
            displayDataGridView.DataSource = Globals.Appointments;
            displayTitleLabel.Text = "All Appointments";
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }

        private void consultantButton_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
            BindingList<Appointment> display = new BindingList<Appointment>();
            //following lambda statement used for LINQ filtering that are for the selected consultant
            foreach (Appointment app in Globals.Appointments.Where<Appointment>(i => i.UserID == (int)comboBox.SelectedValue))
            {
                display.Add(app);
            }
            displayDataGridView.DataSource = display;
            displayTitleLabel.Text = "Appointments by Consultant";
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }
        private void report1Button_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
            BindingList<string> unique = new BindingList<string>();
            BindingList<string> strings = new BindingList<string>();
            int month = (int)dateTimePicker.Value.Month;
            int year = (int)dateTimePicker.Value.Year;
            //following lambda is used for LINQ filtering of appointments occuring in selected month and year
            foreach (Appointment i in Globals.Appointments.Where<Appointment>(app => ((int)app.Start.Month == month && (int)app.Start.Year == year)))
            {
                if (!unique.Contains(i.TypeOfAppointment))
                {
                    unique.Add(i.TypeOfAppointment);
                }
            }
            strings.Add($"There are {unique.Count} appointment types in the selected month:");
            int count;
            foreach (string i in unique)
            {
                count = 0;
                foreach (Appointment j in Globals.Appointments.Where<Appointment>(app => ((int)app.Start.Month == month && (int)app.Start.Year == year)))
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
        private void report2Button_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
            BindingList<Appointment> display = new BindingList<Appointment>();
            //following lambda is used for LINQ filtering of appointments that occur after the current DateTime
            foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => app.Start >= DateTime.Now))
            {
                display.Add(app);
            }
            displayDataGridView.DataSource = display;
            displayTitleLabel.Text = "Upcoming Appointments";
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }

        private void report3Button_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
            BindingList<Appointment> display = new BindingList<Appointment>();
            //following lambda statement used for LINQ filtering of appointments that occur before the current DateTime
            foreach (Appointment app in Globals.Appointments.Where<Appointment>(app => app.End <= DateTime.Now))
            {
                display.Add(app);
            }
            displayDataGridView.DataSource = display;
            displayTitleLabel.Text = "Past Appointments";
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }
        private void weekButton_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
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
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }
        private void monthButton_Click(object sender, EventArgs e)
        {
            ResetGlobals();
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            displayDataGridView.ColumnHeadersVisible = true;
            displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
            displayDataGridView.RowHeadersVisible = false;
            displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            addButton.Text = "Add New Appointment";
            LoadAppointments(Globals.Appointments);
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
            //formatting headers in displayDataGridView
            displayDataGridView.Columns["AppointmentID"].DisplayIndex = 0;
            displayDataGridView.Columns["CustomerID"].DisplayIndex = 1;
            displayDataGridView.Columns["UserID"].DisplayIndex = 2;
            displayDataGridView.Columns["TypeOfAppointment"].DisplayIndex = 3;
            displayDataGridView.Columns["Start"].DisplayIndex = 4;
            displayDataGridView.Columns["End"].DisplayIndex = 5;
            displayDataGridView.Columns["Title"].DisplayIndex = 6;
            displayDataGridView.Columns["Description"].DisplayIndex = 7;
            displayDataGridView.Columns["Location"].DisplayIndex = 8;
            displayDataGridView.Columns["Contact"].DisplayIndex = 9;
            displayDataGridView.Columns["URL"].DisplayIndex = 10;
            displayDataGridView.Columns["CreateDate"].DisplayIndex = 11;
            displayDataGridView.Columns["CreatedBy"].DisplayIndex = 12;
            displayDataGridView.Columns["LastUpdate"].DisplayIndex = 13;
            displayDataGridView.Columns["LastUpdateBy"].DisplayIndex = 14;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (displayTitleLabel.Text == "All Customers")
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
            if (displayTitleLabel.Text == "All Customers")
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
            if (displayTitleLabel.Text == "All Customers")
            {
                Globals.Delete("customer", "customerId", Globals.CurrentCustomerID);
                ResetGlobals();
                displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                displayDataGridView.ColumnHeadersVisible = true;
                displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
                displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
                displayDataGridView.RowHeadersVisible = false;
                displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            else
            {
                Globals.Delete("appointment", "appointmentId", Globals.CurrentAppointmentID); 
                ResetGlobals();
                displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                displayDataGridView.ColumnHeadersVisible = true;
                displayDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
                displayDataGridView.DefaultCellStyle.SelectionForeColor = displayDataGridView.DefaultCellStyle.ForeColor;
                displayDataGridView.RowHeadersVisible = false;
                displayDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            if (displayTitleLabel.Text == "All Customers")
            {
                Globals.CurrentCustomerID = (int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value;
                LookupCustomer(Globals.CurrentCustomerID);
                displayDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else if (displayTitleLabel.Text == "Number of Appointment Types by Month")
            {
                displayDataGridView.DefaultCellStyle.SelectionBackColor = displayDataGridView.DefaultCellStyle.BackColor;
            }
            else
            {
                Globals.CurrentAppointmentID = (int)displayDataGridView.Rows[e.RowIndex].Cells[0].Value;
                LookupAppointment(Globals.CurrentAppointmentID);
                displayDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
                editButton.Enabled = true;
                deleteButton.Enabled = true;
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
