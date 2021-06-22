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
    public partial class Change_Discipline : Form
    {
        public Change_Discipline()
        {
            InitializeComponent();
        }
        Business_Layer.Discipline discipline;

        private void Change_Discpline_Load(object sender, EventArgs e)
        {
            cmbDiscpline.DataSource = discipline.GetAllDiscipline();
            cmbDiscpline.DisplayMember = "StaffName";
            cmbDiscpline.ValueMember = "StaffID";
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            discipline = new Discipline(cmbDiscpline.SelectedIndex.ToString(), txtDiscplineID.Text, txtDiscplineName.Text);
            discipline.ChangeStaff();
        }
    }
}
