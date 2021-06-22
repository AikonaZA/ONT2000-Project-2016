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
    public partial class Change_Country : Form
    {
        public Change_Country()
        {
            InitializeComponent();
        }
        Business_Layer.Country country;

        private void Change_Country_Load(object sender, EventArgs e)
        {
            cmbCountry.DataSource = country.GetAllCountries();
            cmbCountry.DisplayMember = "Country_Name";
            cmbCountry.ValueMember = "Country_IDKey";
        }
    }
}
