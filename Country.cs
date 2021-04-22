using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinTownleySoftwareII
{
    class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        //constructor for country
        public Country(int id, string name, DateTime createDate, string createdBy, DateTime updated, string updatedBy)
        {
            CountryID = id;
            CountryName = name;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = updated;
            LastUpdateBy = updatedBy;
        }
    }
}
