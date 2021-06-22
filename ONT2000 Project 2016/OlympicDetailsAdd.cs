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
    public partial class Add_Olympic_Details : Form
    {
        Business_Layer.Olympic olympic;
        public Add_Olympic_Details()
        {
            InitializeComponent();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            olympic = new Olympic(int.Parse(comboBox1.Text), txtYear.Text);
            olympic.AddOlympic();
        }
    }
}
