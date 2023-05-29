using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proect1
{
    public partial class Changes : Form
    {
        public Changes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile h = new Profile();
            Close();
            h.Show();
            h.Location = Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_page data_Page = new Data_page();
            Close();
            data_Page.Show();
            data_Page.Location=Location;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            Close();
            profile.Show();
            profile.Location = Location;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_menu main_Menu = new Main_menu();
            Close();
            main_Menu.Show();
            main_Menu.Location = Location;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1  form1 = new Form1();
            Close();
            form1.Show();
            form1.Location = Location;
        }
    }
}
