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
    public partial class Form2 : System.Windows.Forms.Form
    {
        private string args = "";
        private string userId = "";
        public Form2(string arg, UserEntry ent)
        {
            
            InitializeComponent();
            
            args = arg;
            if (arg == "rw") 
            {

                this.Text = ent.Vorname + " " + ent.Nachname;
                createButton.Hide();
                // Add City Data to User
                ent = DatabaseManager.getCityData(ent);
                this.userId = ent.UserID;
                insertDataIntoTextboxes(ent);
            
            }else if(arg=="w")
            {
                this.Text = "Benutzer Anlegen";
                updateButton.Hide();
                button2.Hide();
            }
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
        private void createButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                UserEntry data = getDataFromTextboxes();

                // Überprüfen Sie, ob alle Eingabefelder nicht leer sind

                if (checkData(data))
                {
                    DatabaseManager.addUserToDatabase(getDataFromTextboxes());
                    MessageBox.Show("Datensatz erfolgreich erstellt.");
                }
                else
                {
                    MessageBox.Show("Daten entsprechen nicht dem richtigen Typ!");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Einfügen der Daten: " + ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UserEntry data = getDataFromTextboxes();
            if (checkData(data))
            {
                data.UserID = this.userId;
                DatabaseManager.updateUser(data);
                MessageBox.Show("Eintrag erfolgreich aktualisiert!");
            }

            
        }
        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private bool checkData(UserEntry data)
        {
            if (
                string.IsNullOrEmpty(data.Vorname) ||
                string.IsNullOrEmpty(data.Nachname) ||
                string.IsNullOrEmpty(data.Strasse) ||
                string.IsNullOrEmpty(data.Hausnummer) ||
                string.IsNullOrEmpty(data.Telefon) ||
                string.IsNullOrEmpty(data.Email) ||
                !( ( string.IsNullOrEmpty(data.Plz) && string.IsNullOrEmpty(data.OrtName) )  || ( string.Empty != data.Plz && string.Empty != data.OrtName)))
            {
                MessageBox.Show("Bitte füllen Sie alle erforderlichen Felder aus.");
                return false;
            }
            if (!IsValidEmail(data.Email))
            {
                return false;
            }
            if (data.Plz != string.Empty)
            {
                if (int.TryParse(data.Plz, out _) &&
                int.TryParse(data.Hausnummer, out _) &&
                int.TryParse(data.Telefon, out _))
                {

                    return true;
                }


            }
            else
            {
                if (int.TryParse(data.Hausnummer, out _) &&
                    int.TryParse(data.Telefon, out _))
                {
                    return true;
                }

            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Soll dieser Benutzer entfernt werden?", "Benutzer löschen", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DatabaseManager.deleteUser(this.userId);
                MessageBox.Show("Eintrag wurde gelöscht");
                this.Hide();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
