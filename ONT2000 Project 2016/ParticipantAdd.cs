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
    public partial class Add_Participant : Form
    {
        Business_Layer.Participant participant;
        public Add_Participant()
        {
            InitializeComponent();
        }

        private void Add_Participant_Load(object sender, EventArgs e)
        {
            cmbParticapantCountry.DataSource = participant.GetAllParticipants();
            cmbParticapantCountry.DisplayMember = "Country_Name";
            cmbParticapantCountry.ValueMember = "Country_IDKey";
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            participant = new Participant(int.Parse(txtParticapantID.Text), txtParticapantName.Text, txtParticapantSurname.Text, cmbParticapantGender.Text, int.Parse(cmbParticapantCountry.Text));
            participant.AddParticipant();

        }
    }
}
