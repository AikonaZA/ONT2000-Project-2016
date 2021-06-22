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
    public partial class Country : Form
    {
        Business_Layer.Country country;
        public Country()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryAdd addCountry = new CountryAdd();
            addCountry.Show();
            this.Hide();
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            Change_Country change = new Change_Country();
            change.Show();
            this.Hide();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            Delete_Country delete = new Delete_Country();
            delete.Show();
            this.Hide();
        }

        private void Country_Load(object sender, EventArgs e)
        {
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //put all countries in datagrid view 
            DGVCountry.DataSource = country.GetAllCountries();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
