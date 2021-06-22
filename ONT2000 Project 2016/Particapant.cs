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
    public partial class Particapant : Form
    {
        public Particapant()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add_Participant add = new Add_Participant();
            add.Show();
            this.Hide();
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            Change_Participant change = new Change_Participant();
            change.Show();
            this.Hide();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            Delete_Participant delete = new Delete_Participant();
            delete.Show();
            this.Hide();
        }
    }
}
