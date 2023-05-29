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
    public partial class Form1 : Form
    {
       
        public Form1(  )
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
                Registration f = new Registration();
                Hide();
                f.Show();
                f.Location = Location;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Bведите данные");
            }
            else if(textBox1.Text == "1" && textBox2.Text == "2")
            {
                Main_menu C = new Main_menu();
                Hide();
                C.Show();
                C.Location = Location;
            }
            else
            {
                MessageBox.Show("НЕверно");
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
