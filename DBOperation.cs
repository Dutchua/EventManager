using System.Data;
using Npgsql;
namespace EventManager
{
    class DBOperations
    {
        private DBConnect DBConnection = new DBConnect();
        public void DBInsert(string table)
        {
            string sqlcommand = $"INSERT INTO {table} (name, surname, company, accessnumber) VALUES (@name, @surname, @company, @accessnumber);";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("name", "Josh");
                command.Parameters.AddWithValue("surname", "Jennings");
                command.Parameters.AddWithValue("company", "BBD");
                command.Parameters.AddWithValue("accessnumber", "789456123");
                command.ExecuteNonQuery();
            }
            DBConnection.Disconnect();
        }

        public void DBSelect(string table)
        {
            string sqlcommand = $"SELECT * FROM {table} WHERE personid = @personid";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("personid", 1);
            }
            DBConnection.Disconnect();
        }
    }
}