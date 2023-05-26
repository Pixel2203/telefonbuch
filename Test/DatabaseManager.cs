using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
    public MySqlDataReader requestFromDatabase(string sql)
    {
        MySqlCommand cmd = this.connection.CreateCommand();
        cmd.CommandText = sql;
        MySqlDataReader reader = cmd.ExecuteReader();
        return reader;
    }
}
