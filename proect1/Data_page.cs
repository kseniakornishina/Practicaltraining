using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proect1
{
    public partial class Data_page : Form
    {
        private List<User> _users;
        public Data_page()
        {
            InitializeComponent();
            _users = DataBase.Users;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hiding_panel.Visible = !hiding_panel.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Profile u = new Profile(_users[0]);
            Close();
            u.Show();
            u.Location = Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_menu i = new Main_menu();
            Close();
            i.Show();
            i.Location = Location;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            Close();
            x.Show();
            x.Location = Location;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile k = new Profile(_users[0]);
            Close();
            k.Show();
            k.Location = Location;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Changes changes = new Changes();
            Close();
            changes.Show();
            changes.Location = Location;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profile w = new Profile(_users[1]);
            Close();
            w.Show();
            w.Location = Location;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Profile l = new Profile(_users[2]);
            Close();
            l.Show();
            l.Location = Location;
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Profile j = new Profile(_users[3]);
            Close();
            j.Show();
            j.Location = Location;
        }

        private void Data_page_Load(object sender, EventArgs e)
        {

            _users = DataBase.Users;
            label1.Text = _users[0].I;
            label2.Text = _users[0].F;
            label3.Text = _users[0].O;
            label4.Text = _users[1].I;
            label5.Text = _users[1].F;
            label6.Text = _users[1].O;
            label7.Text = _users[2].I;
            label8.Text = _users[2].F;
            label9.Text = _users[2].O;
            label10.Text = _users[3].I;
            label11.Text = _users[3].F;
            label12.Text = _users[3].O;
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Data_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form.Close();
        }
    }
}
