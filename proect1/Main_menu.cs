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
    public partial class Main_menu : Form
    {
      
        public Main_menu()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data_page n = new Data_page();
            Close();
            n.Show();
            n.Location = Location;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hiding_panel.Visible = !hiding_panel.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            Close();
            b.Show();
            b.Location = Location;
           

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile v = new Profile();
            Close();
            v.Show();
            v.Location = Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_page ki = new Data_page();
            Close();
            ki.Show();
            ki.Location = Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_page nl = new Data_page();
            Close();
            nl.Show();
            nl.Location = Location;
        }

        private void Main_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form.Close();
        }
    }
}
