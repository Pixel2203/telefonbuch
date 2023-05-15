using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DatabaseManager
{
    private MySqlConnection connection;
    public DatabaseManager()
    {
    }
    public bool ConnectToDatabase(string serverIP, string uID, string password, string database)
    {
        this.connection = new MySqlConnection();
        this.connection.ConnectionString = "server=" + serverIP + ";uid=" + uID + ";pwd=" + password + ";database=" + database;
        this.connection.Open();
        return true;
    }
    public bool DisconnectFromDatabase()
    {
        return true;
    }
}
