using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Verwaltung : Form
    {
        public Verwaltung()
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Startseite form3 = new Startseite();
            form3.Show();
            this.Hide();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
                try
                {
                    DatabaseManager manager = new DatabaseManager();
                 
                    string insertQuery = "INSERT INTO users () VALUES (" + input_vorname.Text + "," + input_nachname.Text + "," +
                    "" + input_postleitzahl.Text + "," + input_city.Text + "," + input_straße + "," +
                    "" + input_HR.Text + "," + input_telefon.Text + "," + input_email.Text + ")";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Einfügen der Daten: " + ex.Message);
                }
            }    
        }
    }


