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
            //Globals.fileWriter.Close();
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //sample log append
            using (StreamWriter w = File.AppendText("logfile.txt"))
            {
                Globals.Log("this is only a test!", w);
                w.Close();
            }
            

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
