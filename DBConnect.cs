using Npgsql;
using System;
namespace EventManager
{
    class DBConnect
    {
        string connString = "Host=localhost;Port=5432;Username=postgres;Password=123456;Database=PropertyManager";
        private NpgsqlConnection? conn;

        public void Connect()
        {
            try
            {
                conn = new NpgsqlConnection(connString);
                conn.Open();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }        
    }
}