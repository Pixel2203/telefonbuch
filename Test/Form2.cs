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
        private string args = "";
        public Form2(string arg, UserEntry ent)
        {
            InitializeComponent();
            if(arg == "rw")
            {
                ent = DatabaseManager.getCityData(ent);
                insertDataIntoTextboxes(ent);
                args = arg;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(args == "rw")
            {
                this.Close();
                return;
            }
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }
        private void insertDataIntoTextboxes(UserEntry entry) {
            this.input_city.Text = entry.OrtName;
            this.input_email.Text = entry.Email;
            this.input_vorname.Text = entry.Vorname;
            this.input_nachname.Text = entry.Nachname;
            this.input_postleitzahl.Text = entry.Plz;
            this.input_telefon.Text = entry.Telefon;
            this.input_HR.Text = entry.Hausnummer;
            this.input_straße.Text = entry.Strasse;
        }
        private UserEntry getDataFromTextboxes() {
            return new UserEntry(
                "",
                this.input_vorname.Text,
                this.input_nachname.Text,
                this.input_straße.Text,
                this.input_HR.Text,
                this.input_telefon.Text,
                this.input_email.Text,
                "",
                this.input_city.Text,
                this.input_postleitzahl.Text

                );
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            
        }

        private void createButton_Click_1(object sender, EventArgs e)
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
                /*
                if (!string.IsNullOrEmpty(vorname) &&
                    !string.IsNullOrEmpty(nachname) &&
                    !string.IsNullOrEmpty(postleitzahl) &&
                    !string.IsNullOrEmpty(city) &&
                    !string.IsNullOrEmpty(straße) &&
                    !string.IsNullOrEmpty(HR) &&
                    !string.IsNullOrEmpty(telefon) &&
                    !string.IsNullOrEmpty(email))
                {
                    DatabaseManager.addUserToDatabase(getDataFromTextboxes());
                    MessageBox.Show("Datensatz erfolgreich erstellt.");
                }
                else
                {
                    MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.");
                }
                */
                DatabaseManager.addUserToDatabase(getDataFromTextboxes());
                MessageBox.Show("Datensatz erfolgreich erstellt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einfügen der Daten: " + ex.Message);
            }
        }
    }

}
