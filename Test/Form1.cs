using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        List<string> items = new List<string>();
        DatabaseManager databaseManager = new DatabaseManager();
        private void Form1_Load(object sender, EventArgs e)
        {
          

            items.AddRange(new string[] { "Cat", "Dog", "Carrots", "Brocolli" });

            foreach (string str in items)
            {
                listBox1.Items.Add(str);

            }
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.ToUpper();
            listBox1.Items.Clear();

            string sql = "SELECT * FROM users, orte " +
                         "WHERE VORNAME = '"+inputText+ "' " +
                         "OR NACHNAME = '" + inputText + "' " +
                         "OR STRASSE = '"+inputText+ "' " +
                         "OR STADT = '"+inputText+ "' " +
                         "OR TELEFON = '"+inputText+ "' " +
                         "OR EMAIL = '"+inputText+ "' " +
                         "OR orte.ID = users.ORTID AND orte.NAME = '"+inputText+"'";

            //MySqlDataReader reader = databaseManager.requestFromDatabase(sql);
            List<string> foundItems = new List<string>();

            foreach (string str in items)
            {
                if (str.ToUpper().Contains(textBox1.Text.ToUpper()))
                {
                    listBox1.Items.Add(str);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();

            //load user data
        }

        private void button2_Click(object sender, EventArgs e)
        {
             new Form2().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        
             
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
