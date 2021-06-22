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
    public partial class Olympic_Details : Form
    {
        public Olympic_Details()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Add_Olympic_Details add = new Add_Olympic_Details();
            add.Show();
            this.Hide();
        }

        private void bntChange_Click(object sender, EventArgs e)
        {
            Change_Olympic_Details change = new Change_Olympic_Details();
            change.Show();
            this.Hide();
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            Delete_Olympic_Details delete = new Delete_Olympic_Details();
            delete.Show();
            this.Show();
        }
    }
}
