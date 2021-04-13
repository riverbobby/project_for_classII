using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using MySql.Data.MySqlClient;

namespace JustinTownleySoftwareII
{
    static class Globals
    {
        public static int CurrentUserID { get; set; }
        public static int CurrentAppointmentID { get; set; }
        public static int CurrentCustomerID { get; set; }
        public static int CurrentAddressID { get; set; }
        public static int CurrentCityID { get; set; }
        public static int CurrentCountryID { get; set; }
        //MySql globals
        public static string connStr = "server=wgudb.ucertify.com;user=U075EN;database=U075EN;port=3306;password=53688947876";
        public static MySqlConnection conn;
        //StreamWriter globals
        public static StreamWriter fileWriter;
        public static string fileName = "logfile.txt";

    }
}
