﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public static StreamWriter fileWriter;
        public static string fileName = "logfile.txt";

    }
}
