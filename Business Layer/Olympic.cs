using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Olympic
    {
        private int olympicId;
        private string olympicYear;
        private string olympicDesc;
        private int CountryID;
        private DataAccessLayer dal = new DataAccessLayer();

        public Olympic() { }

        public Olympic(int CountryID, string olympicYear)
        {
            this.CountryID = CountryID;
            this.olympicYear = olympicYear;
        }

        public int GetOlympicId
        {
            get { return olympicId; }
            set { olympicId = value; }
        }
        public string GetOlympicDescp
        {
            get { return olympicDesc; }
            set { olympicDesc = value; }
        }

        public string GetOlympicYear
        {
            get { return olympicYear; }
            set { olympicYear = value; }
        }
        public int GetCoutryID
        {
            get { return CountryID; }
            set { CountryID = value; }
        }



        public DataTable GetAllCountries()
        {
            return dal.GetAllCountries();
        }
        public void AddOlympic()
        {
            dal.AddOlympic(this);
        }
        public DataTable GetAllYears()
        {
            return dal.GetAllYears();
        }
    }
}
