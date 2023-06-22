using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            List<UserEntry> entry = DatabaseManager.getUsersFromDatabase("SELECT * FROM users");
            foreach(UserEntry ent in entry)
            {
                listBox1.Items.Add(ent);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.ToUpper();
            listBox1.Items.Clear();
            listBox1.DisplayMember = "display";
            listBox1.ValueMember = "userId";
            string sql = "SELECT DISTINCT * FROM users " +
                         "WHERE vorname LIKE '" + inputText + "%' " +
                         "OR nachname LIKE '" + inputText + "%' " +
                         "OR strasse LIKE '" + inputText + "%' " +
                         "OR telefon LIKE '" + inputText + "%' " +
                         "OR email LIKE '" + inputText + "%' ";
                            
            List<UserEntry> reader = DatabaseManager.getUsersFromDatabase(sql);
            List<string> foundItems = new List<string>();
            foreach(UserEntry entry in reader)
            {
            
                listBox1.Items.Add(entry) ;
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserEntry ent = (UserEntry)listBox1.SelectedItem;
            Debug.WriteLine(ent.Vorname);
            Form2 form2 = new Form2("rw" , ent);
            form2.Show();

            //load user data
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
