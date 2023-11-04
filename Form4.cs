using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private string[] vibors = { "1", "2", "3" };
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Public.Vibor = comboBox1.Text;
            User student = new User();
            student.createUser1(Public.Firstname, Public.Lastname, Public.Secondname, Public.Passport, Public.Vibor);

            TTF manager = new TTF();
            manager.writeLineInFile("C:\\Users\\andre\\Desktop\\Informatic\\Sem 3\\HomeWork\\GOLOSA\\GOLOSA.txt", student.getInfo1(), true);
            this.Hide();
            Form5 j = new Form5();
            j.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = vibors;
            comboBox1.SelectedIndex = 0;
        }

        static void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            Public.Vibor = comboBox.SelectedItem.ToString();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && Char.IsLetter(e.KeyChar)) return;
            else
                e.Handled=true;
        }
    }
}
