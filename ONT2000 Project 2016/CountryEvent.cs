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
    public partial class CountryEvent : Form
    {
        public CountryEvent()
        {
            InitializeComponent();
        }
        Business_Layer.Country country;
        Business_Layer.Event ev;

        private void CountryEvent_Load(object sender, EventArgs e)
        {
            cmbCountryList.DataSource = country.GetAllCountries();
            cmbCountryList.DisplayMember = "Country_Name";
            cmbCountryList.ValueMember = "Country_IDKey";
        }

        private void cmbCountryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEvent.DataSource = ev.GetCountryEvents(cmbCountryList.SelectedValue.ToString());
            cmbEvent.DisplayMember = "EventDescription";
            cmbEvent.ValueMember = "EventNo";
        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            DGVCoutryList.DataSource = ev.GetCountryEvents(cmbCountryList.SelectedValue.ToString(), cmbEvent.SelectedValue.ToString());
    }
}
}
