using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Business_Layer
{
    public class DataAccessLayer
    {
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbAdapter;
        private string connection;

        public DataAccessLayer()
        {
            connection = "Data Source = localhost; Initial Catalog = BayWest; Integrated Security = SSPI;";
            dbConnection = new SqlConnection(connection);

        }

        public string Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public int AddDiscipline(Discipline discpline)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_AddDiscpline '" + discpline.DisciplineID + "','" + discpline.DisciplineName + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public int ChangeDiscipline(Discipline discpline)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_ChangeDiscpline '" + discpline.DisciplineID + "','" + discpline.DisciplineName + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public DataTable GetAllDiscipline()
        {
            DataTable dtDiscpline = new DataTable();
            string sql = "sp_AllDiscpline";
            dbCommand = new SqlCommand(sql, dbConnection);
            dbAdapter = new SqlDataAdapter(dbCommand);
            dbAdapter.Fill(dtDiscpline);
            return dtDiscpline;
        }

        public int AddParticipant(Participant participant)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_AddParticipant '" + participant.ParticipantID + "','" + participant.ParticipantFirstName + "','" + participant.ParticipantGender + "' , '" + participant.CountryID + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public int AddEvent(Event events)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_AddEvent '" + events.DisplineID + "','" + events.GetEventDescrp + "','" + events.GetStartDate + "' , '" + events.GetEndDate + "','" + events.GetStadium + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public int ChangeEvent(Event events)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_ChangeEvent '" + events.DisplineID + "','" + events.GetEventDescrp + "','" + events.GetStartDate + "' , '" + events.GetEndDate + "','" + events.GetStadium + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public int AddOlympic(Olympic olympic)
        {
            if (dbConnection.State == ConnectionState.Closed)
            {
                dbConnection.Open();
            }
            string sql = "sp_AddOlympic '" + olympic.GetOlympicDescp + "','" + olympic.GetAllYears() + "'";
            dbCommand = new SqlCommand(sql, dbConnection);
            int x = dbCommand.ExecuteNonQuery();
            return x;
        }

        public void InsertEventMedal(int eventID, string medal, int medalNo, int participantID)
        {
            if (dbConnection.State == ConnectionState.Closed)
                dbConnection.Open();
            dbCommand = new SqlCommand("sp_InsertEventMedal " + eventID + ", '" + medal + "', " + medalNo + "," + participantID, dbConnection);
            dbCommand.ExecuteNonQuery();
        }

        public DataTable GetEventsinDiscipline(string disciplineID)
        {
            DataTable dtEvents = new DataTable();

            // Setup the SQL statement for the command to fill the datatable in the DataTable
            dbCommand = new SqlCommand("sp_GetEventsinDiscipline '" + disciplineID + "'", dbConnection);
            dbAdapter = new SqlDataAdapter(dbCommand);

            dbAdapter.Fill(dtEvents);
            return dtEvents;
        }

        public DataTable GetAllCountries()
        {
            DataTable dtCountries = new DataTable();
            dbCommand = new SqlCommand("sp_GetAllCountries", dbConnection);
            dbAdapter = new SqlDataAdapter(dbCommand);
            dbAdapter.Fill(dtCountries);
            return dtCountries;

        }

        public DataTable GetEventsforCountry(string country)
        {
            DataTable dtEventsCountry = new DataTable();
            {

                // Setup the SQL statement for the command to fill the datatable in the Dataset 

                dbCommand = new SqlCommand("sp_GetEventsforCountry '" + country + "'", dbConnection);
                dbAdapter = new SqlDataAdapter(dbCommand); dbAdapter.Fill(dtEventsCountry);
                return dtEventsCountry;

            }
        }

        public DataTable GetCountryEventParticipants(string country, string eventNo)
        {
            DataTable dtEventParticipants = new DataTable();
            {

                // Setup the SQL statement for the command to fill the datatable in the Dataset 

                dbCommand = new SqlCommand("sp_GetCountryEventParticipants'" + country + "', '" + eventNo + "'", dbConnection);
                dbAdapter = new SqlDataAdapter(dbCommand); dbAdapter.Fill(dtEventParticipants);
            }
        }
    }
}


