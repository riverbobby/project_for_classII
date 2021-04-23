using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinTownleySoftwareII
{
    class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string TypeOfAppointment { get; set; }
        public string URL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //constructor for current appointment
        public Appointment(int appointmentID, int customerID, int userID, string title, 
            string description, string location, string contact, string type, string url, 
            DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime updated, 
            string updatedBy)
        {
            AppointmentID = appointmentID;
            CustomerID = customerID;
            UserID = userID;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            TypeOfAppointment = type;
            URL = url;
            Start = start.ToLocalTime();
            End = end.ToLocalTime();
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = updated;
            LastUpdateBy = updatedBy;

        }

    }
}
