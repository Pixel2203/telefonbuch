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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    

            DatabaseManager manager = new DatabaseManager();
            bool worked = manager.EstablishConnection("127.0.0.1", "root", "", "telefonbuch");
            if (worked)
            {
                string sql = "INSERT INTO Users ('vorname','nachname','telefon','adresse','hausnummer','email','oid') VALUES ('Hans','Peter','012121032','Wilde Straße', 'wild@mail.com', '2')";
                manager.requestFromDatabase(sql);
            }
            else
            {
                Console.WriteLine("Connection to Database failed!");
            }
            
        }
    }
}
