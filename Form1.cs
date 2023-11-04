using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TTF ttf;
        private Table table;

        private const string DATA_PATH = "C:\\Users\\andre\\Desktop\\Informatic\\Sem 3\\HomeWork\\GOLOSA\\GOLOSA.txt";
        private const string DATA_FOLDER = "C:\\Users\\andre\\Desktop\\Informatic\\Sem 3\\HomeWork\\GOLOSA";
        public Form1()
        {
            ttf = new TTF();
            table = new Table();

            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}