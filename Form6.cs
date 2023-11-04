using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {
        DataTable dt;
        List<User> user_list;
        string filterField = "Фамилия";

        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Фамилия");
            dt.Columns.Add("Имя");
            dt.Columns.Add("Отчество");
            dt.Columns.Add("Серия Паспорта");
            dt.Columns.Add("Номер Паспорта");
            dt.Columns.Add("Голос за");

            string filename = @"C:\Users\andre\Desktop\Informatic\Sem 3\HomeWork\GOLOSA\GOLOSA.txt";
            if (File.Exists(filename))
            {
                StreamReader file = new StreamReader(filename);
                string[] values;
                string newline;
                while ((newline = file.ReadLine()) != null)
                {
                    DataRow dr = dt.NewRow();
                    values = newline.Split(' ');
                    for (int i = 0; i < values.Length; i++)
                    {
                        dr[i] = values[i];
                    }
                    dt.Rows.Add(dr);
                }
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
            }
            else MessageBox.Show("Нет файла с данными");
        }
    }
}

