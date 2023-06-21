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

            // Nachricht für das Popup-Fenster
            string nachricht = "Hallo, das ist eine Testnachricht!";

            // Titel des Popup-Fensters
            string titel = "Popup-Nachricht";

            // Anzeigen des Popup-Fensters
            MessageBox.Show(nachricht, titel);

            // Programm beenden
            Environment.Exit(0);

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

                string vorname = input_vorname.Text;
                string nachname = input_nachname.Text;
                string postleitzahl = input_postleitzahl.Text;
                string city = input_city.Text;
                string straße = input_straße.Text;
                string HR = input_HR.Text;
                string telefon = input_telefon.Text;
                string email = input_email.Text;

                // Überprüfen Sie, ob alle Eingabefelder nicht leer sind
                if (!string.IsNullOrEmpty(vorname) &&
                    !string.IsNullOrEmpty(nachname) &&
                    !string.IsNullOrEmpty(postleitzahl) &&
                    !string.IsNullOrEmpty(city) &&
                    !string.IsNullOrEmpty(straße) &&
                    !string.IsNullOrEmpty(HR) &&
                    !string.IsNullOrEmpty(telefon) &&
                    !string.IsNullOrEmpty(email))
                {
                    // Hier können Sie den Datensatz erstellen
                    string insertQuery = "INSERT INTO users (Vorname, Nachname, Postleitzahl, City, Straße, HR, Telefon, Email) " +
                        "VALUES ('" + vorname + "', '" + nachname + "', '" + postleitzahl + "', '" + city + "', '" +
                        straße + "', '" + HR + "', '" + telefon + "', '" + email + "')";
                    DatabaseManager.insertIntoDatabase;

                    MessageBox.Show("Datensatz erfolgreich erstellt.");
                }
                else
                {
                    MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einfügen der Daten: " + ex.Message);
            }
        }
    }
}
            


