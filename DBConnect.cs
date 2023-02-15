using Npgsql;
using System;
namespace EventManager
{
    class DBConnect
    {
        private NpgsqlConnection conn;

        public void Connect()
        {
            try
            {
                conn = new NpgsqlConnection(Settings.connString);
                conn.Open();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Disconnect()
        {
            conn.Close();
        }

        public NpgsqlConnection GetConn()
        {
            return conn;
        }
    }
}