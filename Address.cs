using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinTownleySoftwareII
{
    class Address
    {
        public int AddressID { get; set; }
        public string AddressField { get; set; }
        public string AddressField2 { get; set; }
        public int CityID { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //constructor for current address
        public Address(int addressID, string addressField, string addressField2, 
            int cityID, string postalCode, string phone, DateTime createDate, 
            string createdBy, DateTime updated, string updatedBy)
        {
            AddressID = addressID;
            AddressField = addressField;
            AddressField2 = addressField2;
            CityID = cityID;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = updated;
            LastUpdateBy = updatedBy;

        }

    }
}
