using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

class DatabaseManager
{
    private MySqlConnection connection;
    public DatabaseManager()
    {

    }
    public bool EstablishConnection(string serverIP, string uID, string password, string database)
    {
        try
        {
            this.connection = new MySqlConnection();
            this.connection.ConnectionString = "server=" + serverIP + ";uid=" + uID + ";pwd=" + password + ";database=" + database;
            this.connection.Open();
            return true;
        }
        catch (MySqlException e)
        {

            return false;
        }

    }
    public bool DisconnectFromDatabase()
    {
        this.connection.Close();
        return true;
    }
    public List<UserEntry> requestFromDatabase(string sql)
    {
        MySqlCommand cmd = this.connection.CreateCommand();
        cmd.CommandText = sql;
        MySqlDataReader reader = cmd.ExecuteReader();
        List<UserEntry> list = new List<UserEntry>();
        while (reader.Read())
        {
            string vorname = reader.GetString("vorname");
            string nachname = reader.GetString("nachname");
            string strasse = reader.GetString("strasse");
            string hausnummer = reader.GetInt32("hausnummer").ToString() ?? "-";
            string telefon = reader.GetString("vorname");
            string email = reader.GetString("vorname") ?? "-";
            string ortid = reader.GetString("vorname") ?? "-";
            list.Add(new UserEntry(vorname,nachname,strasse,hausnummer,telefon,email,ortid));
        }
        reader.Close();
        return list;
    }
}
class UserEntry
{
    public string Vorname = "";
    public string Nachname = "";
    public string Strasse = "";
    public string Hausnummer = "";
    public string Telefon = "";
    public string Email = "";
    public string OrtID = "";
    public UserEntry(string Vorname, string Nachname, string Strasse, string Hausnummer, string Telefon, string Email, string Ordid)
    {
        this.Vorname = Vorname;
        this.Nachname = Nachname;
        this.Strasse = Strasse;
        this.Hausnummer = Hausnummer;
        this.Telefon = Telefon;
        this.Email = Email;
        this.OrtID = Ordid;
    }
}
class SampleData
{
    public static List<UserEntry> userEntries = new List<UserEntry>();
    public SampleData()
    {
        userEntries.Add(new UserEntry("Max", "Mustermann", "Musterstraße", "1", "39132719", "max-mustermann@email.com", "-"));
        userEntries.Add(new UserEntry("Maria", "Musterfrau", "Beispielweg", "10", "98765432", "maria.musterfrau@example.com", "-"));
        userEntries.Add(new UserEntry("John", "Doe", "Testgasse", "5", "5551234", "john.doe@example.com", "-"));
        userEntries.Add(new UserEntry("Sarah", "Schmidt", "Hauptstraße", "20", "12345678", "sarah.schmidt@example.com", "-"));
        userEntries.Add(new UserEntry("Thomas", "Müller", "Parkweg", "3A", "98765432", "thomas.mueller@example.com", "-"));
        userEntries.Add(new UserEntry("Laura", "Hansen", "Berggasse", "8", "5557890", "laura.hansen@example.com", "-"));

    }
}