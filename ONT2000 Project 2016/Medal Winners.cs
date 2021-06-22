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
    public partial class Medal_Winners : Form
    {
        public Medal_Winners()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add_medal_Winners Add = new Add_medal_Winners();
            Add.Show();
            this.Hide();
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            Change_Medal_Winners change = new Change_Medal_Winners();
            change.Show();
            this.Show();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            Delete_Medal_Winners delete = new Delete_Medal_Winners();
            delete.Show();
            this.Hide();
        }
    }
}
