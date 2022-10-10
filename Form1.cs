using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace KardemirFormApplication
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

            
            table.Columns.Add("Isim", typeof(string));
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("1.", typeof(int));
            table.Columns.Add("2.", typeof(int));
            table.Columns.Add("tarih", typeof(System.DateTime));
            






            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Oguz\Desktop\test\tablo.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
               values = lines[i].ToString().Split(';');

                string[] rows = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    rows[j] = values[j].Trim();

                }
               table.Rows.Add(rows);
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text, textBox4.Text, textBox5.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            





        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}