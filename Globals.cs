using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;

namespace JustinTownleySoftwareII
{
    static class Globals
    {
        public static BindingList<Country> Countries = new BindingList<Country>();
        public static BindingList<City> Cities = new BindingList<City>();
        public static BindingList<Address> Addresses = new BindingList<Address>();
        public static BindingList<Customer> Customers = new BindingList<Customer>();
        public static BindingList<Appointment> Appointments = new BindingList<Appointment>();
        public static BindingList<User> Users = new BindingList<User>();


        public static User CurrentUser { get; set; }
        public static Address CurrentAddress { get; set; }
        public static Customer CurrentCustomer { get; set; }
        public static Appointment CurrentAppointment { get; set; }
        public static int CurrentAppointmentID { get; set; }
        public static int CurrentCustomerID { get; set; }
        public static int CurrentAddressID { get; set; }
        //form globals
        public static AppointmentForm AppointmentForm1 { get; set; }

        public static CustomerForm CustomerForm1 { get; set; }
        public static AddressForm AddressForm1 { get; set; }
        public static CityForm CityForm1 { get; set; }
        //MySql globals
        public static string connStr = "server=wgudb.ucertify.com;user=U075EN;database=U075EN;port=3306;password=53688947876";
        public static MySqlConnection conn;

        //method for appending to logfile.txt
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.UtcNow.ToLongTimeString()} {DateTime.UtcNow.ToLongDateString()}");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("------------------");
        }
        //method for inserting to MySQL
        public static bool Insert(string table, string values)
        {
            bool success = false;
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"INSERT INTO {table} VALUES ({values})";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Saved");
                    success = true;
                }
                else
                {
                    MessageBox.Show("Error saving to MySQL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Globals.conn.Close();
            return success;

        }
        public static bool Update(string table, string values, string IDName, int ID)
        {
            bool success = false;
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"UPDATE {table} SET {values} WHERE {IDName} = {ID}";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Successfully Updated");
                    success = true;
                }
                else
                {
                    MessageBox.Show("Error updating to MySQL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Globals.conn.Close();
            return success;

        }
        public static bool Delete(string table, string IDName, int ID)
        {
            bool success = false;
            try
            {
                Globals.conn.Open();
                // Perform database operations
                string sql = $"DELETE FROM {table} WHERE {IDName} = {ID}";
                MySqlCommand cmd = new MySqlCommand(sql, Globals.conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Globals.conn.Close();
            return success;
        }


        //method for converting datetime to mysqldatetime
        public static string toSqlDate(DateTime pre)
        {
            return pre.ToString("yyyy-MM-dd H:mm:ss");
        }

    }
}
