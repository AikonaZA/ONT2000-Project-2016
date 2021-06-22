using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class EventMedal
    {
        private int eventID;
        private string medal;
        private int medalNo;
        private int participantID;
        private int eventMedalID;



        private DataAccessLayer dal = new DataAccessLayer();
        public EventMedal()
        {
        }

        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public string Medal
        {
            get { return medal; }
            set { medal = value; }
        }

        public int MedalNo
        {
            get { return medalNo; }
            set { medalNo = value; }
        }

        public int EventMedalID
        {
            get { return eventMedalID; }
            set { eventMedalID = value; }
        }

        public void InsertEventMedal(int eventID, string medal, int medalNo, int participantID)
        {
            dal.InsertEventMedal(eventID, medal, medalNo, participantID);
        }
    }
}
