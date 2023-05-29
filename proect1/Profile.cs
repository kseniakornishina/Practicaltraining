using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proect1
{
    public partial class Profile : Form
    {
        private User _user;

        public Profile()
        {
            InitializeComponent();
           
        }
        
        
        public Profile(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = !panel3.Visible;
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_menu t = new Main_menu();
            Close();
            t.Show();
            t.Location = Location;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 y = new Form1();
            Close();
            y.Show();
            y.Location = Location; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_page o = new Data_page();
            List<User> list = DataBase.Users;
           
            for(int i = 0; i < list.Count; i++)
            {
                if(list[i].I == _user.I && list[i].F == _user.F && list[i].O == _user.O)
                {
                    string iName = textBox1.Text;
                    string fName = textBox2.Text;

                    list[i] = new User(list[i].ID, iName, fName, list[i].O);

                }
            }
            DataBase.Users = list;  
            Close();
            o.Show();
            o.Location = Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_page r = new Data_page();
            Close();
            r.Show();
            r.Location = Location;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            label1.Text = _user.I;
            textBox1.Text = _user.I;
            label2.Text = _user.F;
            textBox2.Text = _user.F;
            label3.Text = _user.O;
            textBox3.Text = _user.O;
        }
        

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form.Close();
        }
    }
}
