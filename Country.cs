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

        //constructor for adding new country
        public Country(string name, string createdBy, DateTime updated, string updatedBy)
        {
            CountryID = 0;
            CountryName = name;
            CreateDate = DateTime.Now;
            CreatedBy = Globals.CurrentUser.UserName;
            LastUpdate = DateTime.Now;
            LastUpdateBy = Globals.CurrentUser.UserName;


        }
        //constructor for current country
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
