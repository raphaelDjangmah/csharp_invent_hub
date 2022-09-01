using System;
using MySql.Data.MySqlClient;

public class DbActivities
{
    MySqlConnection connection = null;

    public DbActivities()
    {

    }

    //return values
    private string qRetText = "";
    private int qRetCode = -1;

    public int getReturnCode()
    {
        return qRetCode;
    }

    public string getReturnText()
    {
        return qRetText;
    }

    //reading from DB
    public MySqlDataReader queryDB(string query, MySqlConnection sqlConnection)
    {

        MySqlDataReader reader = null;

        try
        {
            MySqlCommand cmd = new MySqlCommand(query, sqlConnection);
            reader = cmd.ExecuteReader();
            qRetText = "Query Successfull";
            qRetCode = 1;
        }
        catch (Exception ex)
        {
            qRetCode = -1;
            qRetText = ex.Message.ToString();
        }

        return reader;
    }


    //connecting to DB
    public MySqlConnection connectDB(string databaseName)
    { 
        try
        {
            string DB = databaseName;
            const string SERVER = "localhost";
            const string USER = "root";
            string PASSWORD = "";

            string conn = "SERVER = " + SERVER + "; DATABASE = " + DB + "; UID = " + USER + "; PASSWORD = " + PASSWORD + ";" + "Convert Zero Datetime=True;";

            //string conn = String.Format("SERVER = %s; DATABASE = %s; UID = %s; PASSWORD = %s;", SERVER, DB, USER, PASSWORD);

            
            connection = new MySqlConnection(conn);
            connection.Open();

            qRetText = "DB connected Successfully ";
            qRetCode = 1;
        }
        catch (Exception e)
        {
            qRetCode = -1;
            qRetText = e.Message.ToString();
        }

        return connection;
    }

    public void closeConnection()
    {
        connection.Close();
    }
}
