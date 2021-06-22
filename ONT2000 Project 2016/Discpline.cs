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
    public partial class Discpline : Form
    {
        public Discpline()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add_Discipline addDiscipline = new Add_Discipline();
            addDiscipline.Show();
            this.Hide();
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            Change_Discipline changeDiscipline = new Change_Discipline();
            changeDiscipline.Show();
            this.Hide();
        }

        internal object GetAllDiscpline()
        {
            throw new NotImplementedException();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            Delete_Discpline delete = new Delete_Discpline();
            delete.Show();
            this.Hide();
        }
    }
}
