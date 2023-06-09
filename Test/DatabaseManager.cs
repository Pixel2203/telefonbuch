﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
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
        MySqlDataReader reader =runCommandWithReader(sql);
        List<UserEntry> list = new List<UserEntry>();
        while (reader.Read())
        {
            string userId = reader.GetString("userId");
            string vorname = reader.GetString("vorname");
            string nachname = reader.GetString("nachname");
            string strasse = reader.GetString("strasse");
            string hausnummer = reader.GetInt32("hausnummer").ToString();
            string telefon = reader.GetString("telefon");
            string email = reader.GetString("email");
            string ortid = "-";
            try
            {
                ortid = reader.GetString("ortId");
            }catch (Exception e) { }
            string ortname = "";
            string plz = "";

            list.Add(new UserEntry(userId,vorname,nachname,
                strasse,hausnummer,telefon,email,ortid,ortname,plz));
        }
        reader.Close();
        return list;
    }
    public static void deleteUser(string userId)
    {
        string sql = "DELETE FROM users WHERE userId= '" 
                    + userId + "'";
        runCommand(sql);
    }

    public static void addUserToDatabase(UserEntry newUser) {
        
        if(newUser.OrtName != null && newUser.OrtName != string.Empty && newUser.OrtName != "-")
        {
            int ortId;
            try
            {
                Ort ort = getOrtByAttributes(newUser.OrtName, newUser.Plz); 
                if(ort == null)
                {
                    createOrt(newUser.OrtName, newUser.Plz);
                    ortId = int.Parse(getOrtByAttributes(newUser.OrtName, newUser.Plz).ortid);

                }
                else
                {
                    ortId = int.Parse(ort.ortid);
                }
            }
            catch (Exception ex)
            {
                // City not found --> Create New City entry
                createOrt(newUser.OrtName, newUser.Plz);
                ortId = int.Parse(getOrtByAttributes(newUser.OrtName, newUser.Plz).ortid);
            }
            newUser.OrtID = ortId.ToString();
        }
        else
        {
            string sql =
            "INSERT INTO users " +
            "(vorname,nachname,strasse,hausnummer,telefon,email,ortId) " +
            "VALUES " +
            "('"
            + newUser.Vorname + "','"
            + newUser.Nachname + "','"
            + newUser.Strasse + "','"
            + newUser.Hausnummer + "','"
            + newUser.Telefon + "','"
            + newUser.Email + "', NULL"
            + ")";
            MySqlCommand insert = connection.CreateCommand();
            insert.CommandText = sql;
            insert.ExecuteReader().Close();
            return;
        }
       
        
        string insertSQL = 
            "INSERT INTO users " +
            "(vorname,nachname,strasse,hausnummer,telefon,email,ortId) " +
            "VALUES " +
            "('"
            + newUser.Vorname + "','"
            + newUser.Nachname + "','"
            + newUser.Strasse + "','"
            + newUser.Hausnummer + "','"
            + newUser.Telefon + "','"
            + newUser.Email + "','"
            + newUser.OrtID + "'"
            + ")";
        runCommand(insertSQL);

    }
    public static UserEntry getCityData(UserEntry ent)
    {
        string sql = "SELECT name,plz FROM orte,users WHERE users.ortId = orte.ortId AND users.userId =" + ent.UserID + " AND users.ortId IS NOT NULL";
        MySqlDataReader reader = runCommandWithReader(sql);
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
    public static void updateUser(UserEntry user)
    {
        Ort ort = getOrtByAttributes(user.OrtName, user.Plz);
        string sql = "";
        if (ort != null)
        {
            user.OrtID = ort.ortid;
            sql = "UPDATE users SET vorname='"
           + user.Vorname + "' , nachname='"
           + user.Nachname + "' , strasse='"
           + user.Strasse + "' , telefon='"
           + user.Telefon + "' , email='"
           + user.Email + "' , hausnummer='"
           + user.Hausnummer + "' , ortId='"
           + user.OrtID + "' WHERE userId=" + user.UserID;
        }
        else if(user.OrtName != null && user.OrtName != string.Empty && user.OrtName != "-")
        {
            createOrt(user.OrtName, user.Plz);
            user.OrtID = getOrtByAttributes(user.OrtName, user.Plz).ortid;
            sql = "UPDATE users SET vorname='"
           + user.Vorname + "' , nachname='"
           + user.Nachname + "' , strasse='"
           + user.Strasse + "' , telefon='"
           + user.Telefon + "' , email='"
           + user.Email + "' , hausnummer='"
           + user.Hausnummer + "' , ortId='"
           + user.OrtID + "' WHERE userId=" + user.UserID;
        }
        else
        {
            // City cannot be found because it is empty
           sql = "UPDATE users SET vorname='"
           + user.Vorname + "' , nachname='"
           + user.Nachname + "' , strasse='"
           + user.Strasse + "' , telefon='"
           + user.Telefon + "' , email='"
           + user.Email + "' , hausnummer='"
           + user.Hausnummer + "', ortId=NULL WHERE userId=" + user.UserID;
        }

        runCommand(sql);


    }
    private static void createOrt(string ortname, string plz)
    {
        string addCitySql = "INSERT INTO orte (name,plz) VALUES ('" + ortname  + "','" +plz + "')";
        runCommand(addCitySql);
    }
    private static Ort getOrtById(string ortId)
    {
        string sql = "SELECT * FROM orte WHERE ortId=" + ortId;
        MySqlDataReader r = runCommandWithReader(sql);
        try
        {
            string name = r.GetString("name");
            string plz = r.GetInt32("plz").ToString();
            string ortid = r.GetInt32("ortId").ToString();
            r.Close();
            return new Ort(ortid,name,plz);  
        }
        catch (Exception)
        {
            r.Close();
            return null;
        }
    }
    private static Ort getOrtByAttributes(string name, string plz)
    {
        string sql = "SELECT * FROM orte WHERE name='" + name + "' AND plz ='" + plz + "'";
        MySqlDataReader r = runCommandWithReader(sql);
        r.Read();
        
        try
        {
            string ortId = r.GetString("ortId");
            r.Close();
            return new Ort(ortId, name, plz);
        }
        catch (Exception)
        {
            r.Close();
            return null;
        }
    }
    private static void runCommand(string sql)
    {
        MySqlCommand addCityCMD = connection.CreateCommand();
        addCityCMD.CommandText = sql;
        addCityCMD.ExecuteReader().Close();
    }
    private static MySqlDataReader runCommandWithReader(string sql)
    {
        MySqlCommand ort = connection.CreateCommand();
        ort.CommandText = sql;
        MySqlDataReader r = ort.ExecuteReader();
        return r;
    }
    class Ort
    {
        public string ortid;
        public string name;
        public string plz;
        public Ort(string ortid, string name, string plz)
        {
            this.ortid = ortid;
            this.name = name;
            this.plz = plz;
        }
    }
}