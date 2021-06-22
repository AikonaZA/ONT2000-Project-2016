using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Business_Layer
{
    public class Country
    {
        private string countryName;
        private string countryId;
        private DataAccessLayer dal = new DataAccessLayer();

        public Country()
        {
        }
        public string GetCountryID
        {
            get { return countryId; }
            set { countryId = value; }
        }
        public string GetCountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
      
       
        public Country(string countryId, string countryName)
        {
            this.countryId = countryId;
            this.countryName = countryName;
           
        }
        public void AddCountry()
        {
            dal.AddCountry(this);
        }
        public void ChangeCountry()
        {
            dal.ChangeCountry(this);
        }

        public DataTable GetAllCountries()
        {
            return dal.GetAllCountries();
        }
    }
}

