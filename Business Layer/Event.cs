using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Business_Layer
{
    public class Event
    {
        private int eventId;
        private string eventDescrp;
        private string displineID;
        private DateTime StartDate;
        private DateTime endDate;
        private string staduim;
        DataAccessLayer dal = new DataAccessLayer();

        public Event()
        {
        }
        public int GetEventID
        {
            get { return eventId; }
            set { eventId = value; }
        }
        public string DisplineID
        {
            get { return displineID; }
            set { displineID = value; }
        }
        public string GetEventDescrp
        {
            get { return eventDescrp; }
            set { eventDescrp = value; }
        }
        public DateTime GetStartDate
        {
            get { return StartDate; }
            set { StartDate = value; }
        }
        public DateTime GetEndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string GetStadium
        {
            get { return staduim; }
            set { staduim = value; }
        }
        public DataTable GetAllCountries()
        {
            return dal.GetAllCountries();
        }
        public DataTable GetCountryEvents(string country)
        {
            return dal.GetEventsforCountry(country);
        }
        public DataTable GetAllEvents()
        {
            return dal.GetAllEvents();
        }
        public DataTable GetAllDiscpline()
        {
            return dal.GetAllDisciplines();
        }
        public void AddEvent()
        {
            dal.AddEvent(this);
        }
    }
}
