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
    public partial class Add_Event : Form
    {
        Business_Layer.Event ev;
        public Add_Event()
        {
            InitializeComponent();
        }

        private void Add_Event_Load(object sender, EventArgs e)
        {
            cmbDiscpline.DataSource = ev.GetAllEvents();
            cmbDiscpline.DisplayMember = "Events_Name";
            cmbDiscpline.ValueMember = "Events_IDKey";
        }

        private void btnAddIndviEvent_Click(object sender, EventArgs e)
        {
            ev = new Event(cmbDiscpline.SelectedIndex.ToString(), txtEvent.Text, dateTimePickerStartDate.Value.ToShortDateString(), dateTimePickerEndDate.Value.ToShortDateString(), txtSadiumEvents.Text);
            ev.AddEvent();
        }
    }
}
