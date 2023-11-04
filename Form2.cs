using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool FLAG = false;
            if (textBox1.Text.Length == 0) { MessageBox.Show("Введите ФАМИЛИЮ"); FLAG = true; }
            if (textBox2.Text.Length == 0) { MessageBox.Show("Введите ИМЯ"); FLAG = true; }
            if (textBox3.Text.Length == 0) { MessageBox.Show("Введите ОТЧЕСТВО"); FLAG = true; }
            if (textBox4.Text.Length == 0) { MessageBox.Show("Введите СЕРИЮ и НОМЕР ПАСПОРТА"); FLAG = true; }

            if (!FLAG)
            {
                Public.Firstname = textBox1.Text;
                Public.Lastname = textBox2.Text;
                Public.Secondname = textBox3.Text;
                Public.Passport = textBox4.Text;

                this.Hide();
                Form3 g = new Form3();
                g.Show();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox4.KeyPress += textBox4_KeyPress;
            textBox3.KeyPress += textBox3_KeyPress;
            textBox2.KeyPress += textBox3_KeyPress;
            textBox1.KeyPress += textBox3_KeyPress;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
