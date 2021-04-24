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
    }
}
