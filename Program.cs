using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

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

            //opening filestream and streamwriter
            //FileStream log = new FileStream(Globals.fileName, FileMode.Append, FileAccess.Write);
            //Globals.fileWriter = new StreamWriter(log);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
