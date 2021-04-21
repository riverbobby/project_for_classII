﻿using System;
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
                        //Hide LoginForm
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.Show();



                    }
                    //if (rdr.GetString(1) == passwordTextBox.Text)
                    //{
                    //    //allow login
                    //    MessageBox.Show("login begin");

                    //    Globals.CurrentUserID = rdr.GetInt32(0);
                    //    MessageBox.Show($"{Globals.CurrentUserID} is loggin in...");
                    //}
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

                    //if (cmd..Equals(passwordTextBox))
                    //{
                    //    //allow login
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Please enter a valid username and password\n");
                    //}
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
                    Globals.Log("Insuccessful login attempt.", w);
                    w.Close();
                }

            }

            //sample log append
            //using (StreamWriter w = File.AppendText("logfile.txt"))
            //{
            //    Globals.Log("this is only a test!", w);
            //    w.Close();
            //}


            //sample insert to MySQL
            //try
            //{
            //    MessageBox.Show("Connecting to MySQL database");
            //    Globals.conn.Open();
            //    // Perform databaase operations
            //    string sql = "INSERT INTO user (x, y, z) VALUES ('x', 'y', 'z')";
            //    MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
            //    cmd.ExecuteNonQuery();
            //}
            //catch (Exemption ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //Globals.conn.Close();
            //MessageBox.Show("Done.");

            //sample read from MySQL
            //try
            //{
            //    MessageBox.Show("Connecting to MySQL database");
            //    Globals.conn.Open();
            //    // Perform databaase operations
            //    string sql = "SELECT userName, password FROM user WHERE userId='1'";
            //    MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
            //    MySqlDataReader rdr = cmd.ExecuteReader();

            //    while (rdr.Read())
            //    {
            //        MessageBox.Show(rdr[0]+" --"+rdr[1]);
            //    }
            //    rdr.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error connecting to MySQL...");
            //}
            //Globals.conn.Close();
            //MessageBox.Show("Done");

            //string messageBuilder = "Please fix the folling issues:\n";
            //bool invalid = false;
            //if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            //{
            //    invalid = true;
            //    messageBuilder += "Please enter a username\n";
            //}
        }
    }
}
