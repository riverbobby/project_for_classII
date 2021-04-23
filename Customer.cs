using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinTownleySoftwareII
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        public int Active { get; set; }

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //constructor for current customer
        public Customer(int customerID, string name, int addressID, int active,
            DateTime createDate, string createdBy, DateTime updated, string updatedBy)
        {
            CustomerID = customerID;
            Name = name;
            AddressID = addressID;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = updated;
            LastUpdateBy = updatedBy;

        }
    }
}
