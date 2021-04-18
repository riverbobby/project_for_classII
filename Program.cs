using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace JustinTownleySoftwareII
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //starting mySQL connection
            Globals.conn = new MySqlConnection(Globals.connStr);
            //try
            //{
            //    Globals.conn.Open();
            //    // Perform databaase operations
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error connecting to MySQL...");
            //}
            //Globals.conn.Close();

            //setting local language from CultureInfo

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
