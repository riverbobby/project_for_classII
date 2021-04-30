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
using System.IO;
using System.Globalization;

namespace JustinTownleySoftwareII
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool invalid = false;
            if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) || (string.IsNullOrWhiteSpace(passwordTextBox.Text)))
            {
                invalid = true;
                if (CultureInfo.CurrentUICulture.Name == "es-MX")
                {
                    MessageBox.Show("Ingrese un nombre de usuario y contraseña válidos\n");
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and password\n");
                }
            }
            else
            {
                try
                {
                    Globals.conn.Open();
                    // query to lookup userId and password
                    string sql = $"SELECT password, userId, userName FROM user WHERE userName='{usernameTextBox.Text}'";
                    MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    rdr.Read();
                    if (rdr.GetString(0) == passwordTextBox.Text)
                    {
                        rdr.Read();
                        int userID = rdr.GetInt32(1);
                        rdr.Read();
                        string userName = rdr.GetString(2);
                        Globals.CurrentUser = new User(userID, userName);
                        //append log of successful login
                        using (StreamWriter w = File.AppendText("logfile.txt"))
                        {
                            Globals.Log($"User # {Globals.CurrentUser.UserID}--{Globals.CurrentUser.UserName} has successfully logged in.", w);
                            w.Close();
                        }
                        rdr.Close();
                        Globals.conn.Close();
                        //load Users
                        LoadUsers(Globals.Users);
                        //check for appointments in the next 15 minutes
                        LoadAppointments(Globals.Appointments);
                        LoadCustomers(Globals.Customers);
                        CheckAppointments(Globals.Appointments);
                        //hide LoginForm
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();



                    }
                    else
                    {
                        invalid = true;
                        if (CultureInfo.CurrentUICulture.Name == "es-MX")
                        {
                            MessageBox.Show("Ingrese un nombre de usuario y contraseña válidos\n");
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid username and password\n");
                        }
                    }
                    rdr.Close();
                }
                catch (Exception ex)
                {
                    invalid = true;
                    if (CultureInfo.CurrentUICulture.Name == "es-MX")
                    {
                        MessageBox.Show("Error al conectarse a MySQL...\n");
                    }
                    else
                    {
                        MessageBox.Show("Error connecting to MySQL...\n");
                    }
                }
                Globals.conn.Close();
            }
            if (invalid)
            {
                using (StreamWriter w = File.AppendText("logfile.txt"))
                {
                    Globals.Log("Unsuccessful login attempt.", w);
                    w.Close();
                }
            }
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
        private void CheckAppointments(BindingList<Appointment> appointments)
        {
            StringBuilder messageBuilder = new StringBuilder();
            //the next 3 lambdas are to use LINQ to filter appointments, users, and customers
            foreach (Appointment i in Globals.Appointments.Where<Appointment>(app => app.Start >= DateTime.Now && app.Start <= DateTime.Now.AddMinutes(15)))
            {
                foreach (User j in Globals.Users.Where<User>(user => user.UserID == i.UserID))
                {
                    foreach (Customer k in Globals.Customers.Where<Customer>(customer => customer.CustomerID == i.CustomerID))
                    {
                        messageBuilder.Append($"-User {j.UserName} has an appointment that begins at {i.Start.ToShortTimeString()} with {k.Name}\n");
                    }

                }
            }
            if (messageBuilder.Length != 0)
            {
                MessageBox.Show(messageBuilder.ToString());
            }
        }

    }
}
