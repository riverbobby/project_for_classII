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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            startTimePicker.ShowUpDown = true;
            endTimePicker.ShowUpDown = true;
            if (Globals.CurrentAppointmentID != -1)
            {
                //populating current address from CurrentAppointmentID
                LookupAppointment(Globals.CurrentAppointmentID);
                appointmentIdTextBox.Text = Globals.CurrentAppointment.AppointmentID.ToString();
                titleTextBox.Text = Globals.CurrentAppointment.Title;
                descriptionTextBox.Text = Globals.CurrentAppointment.Description;
                locationTextBox.Text = Globals.CurrentAppointment.Location;
                contactTextBox.Text = Globals.CurrentAppointment.Contact;
                typeTextBox.Text = Globals.CurrentAppointment.TypeOfAppointment;
                urlTextBox.Text = Globals.CurrentAppointment.URL;
                startDatePicker.Value = Globals.CurrentAppointment.Start;
                startTimePicker.Value = Globals.CurrentAppointment.Start;
                endDatePicker.Value = Globals.CurrentAppointment.End;
                endTimePicker.Value = Globals.CurrentAppointment.End;
                createdOnLabel.Text = $"created on {Globals.CurrentAppointment.CreateDate.ToString()}";
                createdByLabel.Text = $"by {Globals.CurrentAppointment.CreatedBy}";
                lastUpdateOnLabel.Text = $"updated on {Globals.CurrentAppointment.LastUpdate.ToString()}";
                updatedByLabel.Text = $"by {Globals.CurrentAppointment.LastUpdateBy}";
            }
            else
            {
                appointmentIdTextBox.Text = "Auto generated when saved";
            }

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
                        rdr.GetDateTime(10), rdr.GetDateTime(11), rdr.GetString(12),rdr.GetDateTime(13), 
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

        private void AppointmentForm_VisibleChanged(object sender, EventArgs e)
        {
            LoadCustomers(Globals.Customers);
            customerComboBox.DataSource = Globals.Customers;
            customerComboBox.DisplayMember = "Name";
            customerComboBox.ValueMember = "CustomerID";
            userIdComboBox.DataSource = Globals.Users;
            userIdComboBox.DisplayMember = "UserName";
            userIdComboBox.ValueMember = "UserID";
            if (Globals.CurrentAppointmentID != -1)
            {
                customerComboBox.SelectedValue = Globals.CurrentAppointment.CustomerID;
                userIdComboBox.SelectedValue = Globals.CurrentAppointment.UserID;
            }
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

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentCustomerID = -1;
            this.Hide();
            Globals.CustomerForm1 = new CustomerForm();
            Globals.CustomerForm1.Show();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentCustomerID = (int)customerComboBox.SelectedValue;
            this.Hide();
            Globals.CustomerForm1 = new CustomerForm();
            Globals.CustomerForm1.Show();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Globals.CurrentAppointmentID = -1;
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //validating fields
            StringBuilder message = new StringBuilder();
            LoadAppointments(Globals.Appointments);
            bool valid = true;
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                message.Append("Please enter a type of appointment\n");
                valid = false;
            }
            //validating start and end times
            string timeString = $"{startDatePicker.Value.ToShortDateString()} {startTimePicker.Value.ToShortTimeString()}";
            DateTime begin = DateTime.Parse(timeString);
            timeString = $"{endDatePicker.Value.ToShortDateString()} {endTimePicker.Value.ToShortTimeString()}";
            DateTime end = DateTime.Parse(timeString);
            foreach (var appointment in Globals.Appointments)
            {
                if (begin < appointment.End && end > appointment.Start && Globals.CurrentAppointmentID != appointment.AppointmentID)
                {
                    valid = false;
                    message.Append($"appointment overlaps with appointment #{appointment.AppointmentID}\n");
                }
            }
            if ((int)begin.DayOfWeek < 1 || (int)end.DayOfWeek > 5 || begin.Hour < 8 || (end.Hour > 17 || (end.Hour == 17 && end.Minute > 0)))
            {
                valid = false;
                message.Append($"please schedule the appointment between the hours 8 AM and 5 PM, Monday - Friday\n");
            }
            if (DateTime.Compare(begin, end) > 0)
            {
                valid = false;
                message.Append($"please schedule the End of appointment after the Beginning of appointment\n");
            }
            if (valid)
            {
                //if new appointment
                if (Globals.CurrentAppointmentID == -1)
                {
                    DateTime theDate = DateTime.UtcNow;
                    string myBuilder = $"\'0\', \'{customerComboBox.SelectedValue}\', \'{userIdComboBox.SelectedValue}\', " +
                        $"\'{titleTextBox.Text}\', \'{descriptionTextBox.Text}\', \'{locationTextBox.Text}\', " +
                        $"\'{contactTextBox.Text}\', \'{typeTextBox.Text}\', \'{urlTextBox.Text}\', " +
                        $"\'{Globals.toSqlDate(begin.ToUniversalTime())}\', \'{Globals.toSqlDate(end.ToUniversalTime())}\', " +
                        $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\', " +
                        $"\'{Globals.toSqlDate(theDate)}\', \'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Insert($"appointment", myBuilder))
                    {
                        this.Close();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unable to save at this time");
                    }

                }
                //if updating appointment
                else
                {
                    DateTime theDate = DateTime.UtcNow;
                    string myBuilder = $"customerId = \'{customerComboBox.SelectedValue}\', " +
                        $"userId = \'{userIdComboBox.SelectedValue}\', title = \'{titleTextBox.Text}\', " +
                        $"description = \'{descriptionTextBox.Text}\', location = \'{locationTextBox.Text}\', " +
                        $"contact = \'{contactTextBox.Text}\', type = \'{typeTextBox.Text}\', " +
                        $"url = \'{urlTextBox.Text}\', start = \'{Globals.toSqlDate(begin.ToUniversalTime())}\', " +
                        $"end = \'{Globals.toSqlDate(end.ToUniversalTime())}\', lastUpdate = \'{Globals.toSqlDate(theDate)}\', " +
                        $"lastUpdateBy = \'{Globals.CurrentUser.UserName}\'";
                    if (Globals.Update($"appointment", myBuilder, "appointmentId", Globals.CurrentAppointment.AppointmentID))
                    {
                        Globals.CurrentAppointmentID = -1;
                        this.Close();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
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
