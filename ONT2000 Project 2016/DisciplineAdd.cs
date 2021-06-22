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
    public partial class Add_Discipline : Form
    {
        
        public Add_Discipline()
        {
            InitializeComponent();
        }
        Business_Layer.Discipline discipline;
        private void Add_Discpline_Load(object sender, EventArgs e)
        {

        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            discipline = new Discipline(txtDisciplineID.Text, txtDisciplineName.Text);
            discipline.AddDiscipline();
        }
    }
}
