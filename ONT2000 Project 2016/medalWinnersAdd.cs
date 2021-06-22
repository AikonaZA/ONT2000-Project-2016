using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace ONT2000_Project_2016
{
    public partial class Add_medal_Winners : Form
    {
        Business_Layer.Discipline discipline;
        Business_Layer.Participant part;
        Business_Layer.EventMedal em;
        public Add_medal_Winners()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string medal = "";
            if (cmbMedal.Text == "Gold")
                medal = "G";
            else
                if (cmbMedal.Text == "Silver")
                medal = "S";
            else
                medal = "B";

            em.InsertEventMedal((int)cmbEvent.SelectedValue, medal, int.Parse(txtMedalNo.Text), (int)cmbParticipant.SelectedValue);
            cmbMedal.Text = "";
            cmbDiscipline.Text = "";
            cmbEvent.Text = "";
            cmbParticipant.Text = "";
            txtMedalNo.Text = "";
        }

        private void Add_medal_Winners_Load(object sender, EventArgs e)
        {
            cmbDiscipline.DataSource = discipline.GetAllDiscipline();
            cmbDiscipline.DisplayMember = "DisciplineName";
            cmbDiscipline.ValueMember = "DisciplineID";
            cmbParticipant.DataSource = part.GetAllParticipants();
            cmbParticipant.DisplayMember = "ParticipantName";
            cmbParticipant.ValueMember = "ParticipantID";
        }

        private void cmbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEvent.DataSource = discipline.getEventsinDiscipline(cmbDiscipline.SelectedValue.ToString());
            cmbEvent.DisplayMember = "EventDescription";
            cmbEvent.ValueMember = "EventID";
        }
    }
}
