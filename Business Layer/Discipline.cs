using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business_Layer
{
    
    public class Discipline
    {
        private string disciplineID;
        private string disciplineName;
        private DataAccessLayer dal = new DataAccessLayer();

        public string DisciplineID
        {
            get { return disciplineID; }
            set { disciplineID = value; }
        }
        public string DisciplineName
        {
            get { return disciplineName; }
            set { disciplineName = value; }
        }
        public Discipline()
        {
        }
        public Discipline(string discplineID, string discplineName)
        {
            this.disciplineID = discplineID;
            this.disciplineName = discplineName;
            
        }
        public void AddDiscipline()
        {
            dal.AddDiscipline(this);
        }
        public void ChangeDiscipline()
        {
            dal.ChangeDiscipline(this);
        }
        public DataTable GetAllDiscipline()
        {
            return dal.GetAllDiscipline();
        }
        public DataTable getEventsinDiscipline(string disciplineID)
        {
            return dal.GetEventsinDiscipline(disciplineID);
        }
    }
}
