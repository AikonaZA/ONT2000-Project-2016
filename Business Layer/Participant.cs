using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Layer;
using System.Data;

namespace Business_Layer
{
    public class Participant
    {
        private int participantID;
        private string participantLastName;
        private string participantFirstName;
        private string participantGender;
        private int countryID;


        private DataAccessLayer dal = new DataAccessLayer();
        public Participant()
        {
        }
        public Participant(int participantID, string participantFirstName, string participantLastName, string participantGender, int countryID)
        {
            this.participantID = participantID;
            this.participantFirstName = participantFirstName;
            this.participantLastName = participantLastName;
            this.participantGender = participantGender;
            this.countryID = countryID;
        }

        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }

        public string ParticipantLastName
        {
            get { return participantLastName; }
            set { participantLastName = value; }
        }

        public string ParticipantFirstName
        {
            get { return participantFirstName; }
            set { participantFirstName = value; }
        }

        public string ParticipantGender
        {
            get { return participantGender; }
            set { participantGender = value; }
        }

        public string CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }
        public void AddParticipant()
        {
            dal.AddDiscpline(this);
        }

        public void ChangeParticipant()
        {
            dal.ChangeDiscpline(this);
        }

        public DataTable GetAllParticipants()
        {
            return dal.GetAllParticipants();
        }
    }
}
