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
            string userId = reader.GetString("userId");
            string vorname = reader.GetString("vorname");
            string nachname = reader.GetString("nachname");
            string strasse = reader.GetString("strasse");
            string hausnummer = reader.GetInt32("hausnummer").ToString() ?? "-";
            string telefon = reader.GetString("telefon");
            string email = reader.GetString("email") ?? "-";
            string ortid = "-";
            try
            {
                ortid = reader.GetString("ortId");
            }catch (Exception e) { }
            string ortname = "";
            string plz = "";

            list.Add(new UserEntry(userId,vorname,nachname,strasse,hausnummer,telefon,email,ortid,ortname,plz));
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
    public static UserEntry getCityData(UserEntry ent)
    {
        MySqlCommand addCityCMD = connection.CreateCommand();
        addCityCMD.CommandText = "SELECT name,plz FROM orte,users WHERE users.ortId = orte.ortId AND users.userId =" + ent.UserID + " AND users.ortId IS NOT NULL";
        MySqlDataReader reader = addCityCMD.ExecuteReader();
        reader.Read();
        try
        {
            ent.OrtName = reader.GetString("name");
            ent.Plz = reader.GetString("plz");
        }
        catch (Exception e)
        {
        }
        reader.Close();
        return ent;
    }
}