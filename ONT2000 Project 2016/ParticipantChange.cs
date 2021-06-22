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
    public partial class Change_Participant : Form
    {
        Business_Layer.Participant participant;
        Business_Layer.Country country;
        public Change_Participant()
        {
            InitializeComponent();
        }

        private void Change_Participant_Load(object sender, EventArgs e)
        {
            cmbParticipant.DataSource = participant.GetAllParticipants;
            cmbParticipant.DisplayMember = "Participant_Name";
            cmbParticipant.ValueMember = "Participant_IDKey";

            cmbParticapantCountry.DataSource = country.GetAllCountries();
            cmbParticapantCountry.DisplayMember = "Country_Name";
            cmbParticapantCountry.ValueMember = "Country_IDKey";
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            participant = new Particapant(cmbParticipant.SelectedIndex.ToString(), txtParticapantName.Text, txtParticapantSurname.Text, cmbParticapantCountry.Text, cmbParticapantGender.Text);
            participant.ChangeParticipant();
        }

        private void cmbParticapantCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
