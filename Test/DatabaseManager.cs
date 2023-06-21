using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Test;
class DatabaseManager
{
    private static MySqlConnection connection;
    public static bool EstablishConnection(string serverIP, string uID, string password, string database)
    {
        try
        {
            connection = new MySqlConnection();
            connection.ConnectionString = "server=" + serverIP + ";uid=" + uID + ";pwd=" + password + ";database=" + database;
            connection.Open();
            return true;
        }
        catch (MySqlException e)
        {

            return false;
        }

    }
    public static bool DisconnectFromDatabase()
    {
        connection.Close();
        return true;
    }
    public static List<UserEntry> getUsersFromDatabase(string sql)
    {
        MySqlCommand cmd = connection.CreateCommand();
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
            string ortname = "";
            string plz = "";
            if(ortid != "-"){
                ortname = reader.GetString("name") ?? "-";
                plz = reader.GetInt32("plz").ToString() ?? "-";
            }
            list.Add(new UserEntry(vorname,nachname,strasse,hausnummer,telefon,email,ortid,ortname,plz));
        }
        reader.Close();
        return list;
    }

    public static void addUserToDatabase(UserEntry newUser) {

       
        int ortId = 0;
        string getOrtIdSql = "SELECT ortId FROM orte WHERE name LIKE '" + newUser.OrtName + "' AND plz = '" + newUser.Plz + "'";
        MySqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = getOrtIdSql;
        MySqlDataReader ortidReader = cmd.ExecuteReader();
        try
        {
            ortidReader.Read();
            ortId = ortidReader.GetInt32("ortId");
        }
        catch (Exception ex)
        {
            ortidReader.Close();
            // City not found --> Create New City entry
            string addCitySql = "INSERT INTO orte (name,plz) VALUES ('" + newUser.OrtName+ "','" + newUser.Plz+"')";

            
            MySqlCommand addCityCMD = connection.CreateCommand();
            addCityCMD.CommandText = addCitySql;
            addCityCMD.ExecuteReader().Close();

            MySqlCommand getOrtId = connection.CreateCommand();
            getOrtId.CommandText = getOrtIdSql;
            MySqlDataReader oReader = getOrtId.ExecuteReader();
            oReader.Read();
            ortId = oReader.GetInt32("ortId");
            oReader.Close();

        }
        newUser.OrtID = ortId.ToString();
        string insertSQL = "INSERT INTO users (vorname,nachname,strasse,hausnummer,telefon,email,ortId) VALUES " +
            "('"
            + newUser.Vorname + "','"
            + newUser.Nachname + "','"
            + newUser.Strasse + "','"
            + newUser.Hausnummer + "','"
            + newUser.Telefon + "','"
            + newUser.Email + "','"
            + newUser.OrtID + "'"
            + ")";
        MySqlCommand insertCommand = connection.CreateCommand();
        insertCommand.CommandText = insertSQL;
        insertCommand.ExecuteReader();

    }
}