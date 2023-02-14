using Npgsql;
using System;
namespace EventManager
{
    class DBConnect
    {
        private NpgsqlConnection conn;

        public async void connection()
        {
            var connString = "Host='localhost';Username='postgres';Password='123456';Database='PropertyManager";
            await using conn = new NpgsqlConnection(connString);
            await conn.OpenAsync()
        }

        public async void CloseConnection()
        {
            await conn.CloseAsync()
        }
    }
}