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
    public partial class Change_Event : Form
    {
        Business_Layer.Event ev;
        public Change_Event()
        {
            InitializeComponent();
        }

        private void txtSadiumEvents_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_Event_Load(object sender, EventArgs e)
        {
            cmbDiscpline.DataSource = ev.GetAllEvents();
            cmbDiscpline.DisplayMember = "StaffName";
            cmbDiscpline.ValueMember = "StaffID";
        }

        private void btnAddIndviEvent_Click(object sender, EventArgs e)
        {
            ev = new Event(cmbDiscpline.SelectedIndex.ToString(), txtEvent.Text, dateTimePickerStartDate.Value.ToShortDateString(), dateTimePickerEndDate.Value.ToShortDateString(), txtSadiumEvents.Text);
            ev.AddEvent();
        }
    }
}
