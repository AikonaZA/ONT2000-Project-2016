using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONT2000_Project_2016
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Olympic_Details olympic = new Olympic_Details();
            olympic.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Particapant praticipant = new Particapant();
            praticipant.Show();
            this.Close();
        }

        private void bntCountry_Click(object sender, EventArgs e)
        {
            Country country = new Country();
            country.Show();
            this.Close();
        }

        private void bntDiscpline_Click(object sender, EventArgs e)
        {
            Discpline discpline = new Discpline();
            discpline.Show();
            this.Close();

        }

        private void bntTeam_Click(object sender, EventArgs e)
        {
            Team team = new Team();
            team.Show();
            this.Close();
        }

        private void bntEvent_Click(object sender, EventArgs e)
        {
            Event evn = new Event();
            evn.Show();
            this.Close();
        }

        private void bntMedalWinners_Click(object sender, EventArgs e)
        {
            Medal_Winners medal = new Medal_Winners();
            medal.Show();
            this.Close();
        }
    }
}
