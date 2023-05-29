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
    public partial class Registration : Form
    {
        
        public Registration()
        {
            InitializeComponent();
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || textBox4.Text == String.Empty || textBox3.Text == String.Empty || textBox2.Text == String.Empty)
            {
                MessageBox.Show("Поле ввода пустое");
                return;
            }
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("Пароли не равны");
                return ;

            }
            for (int i = 0; textBox1.Text.Length > i; i++)
            {
                if (char.IsNumber(textBox1.Text[i]))
                {
                    MessageBox.Show("В имени есть цифра");
                    return;
                }
            }
            try
            {
                int j = int.Parse(textBox4.Text);
                Main_menu f = new Main_menu();
                Close();
                f.Show();
                f.Location = Location;

            }
            catch (Exception)
            {
                MessageBox.Show("есть буквы");
                return ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 W = new Form1();
            Close();
            W.Show();
            W.Location=Location;
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.form.Close();
        }
    }
}
