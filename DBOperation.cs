using System.Data;
using Npgsql;
namespace EventManager
{
    class DBOperations
    {
        private DBConnect DBConnection = new DBConnect();
        public void DBInsert(string table, OperationsManager opsManager)
        {
            string sqlcommand = $"INSERT INTO {table} (name, surname, company, accessnumber) VALUES (@name, @surname, @company, @accessnumber);";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("name", opsManager.name);
                command.Parameters.AddWithValue("surname", opsManager.surname);
                command.Parameters.AddWithValue("company", opsManager.company);
                command.Parameters.AddWithValue("accessnumber", opsManager.accessnumber);
                command.ExecuteNonQuery();
            }
            DBConnection.Disconnect();
        }

        public void DBSelect(string table, OperationsManager opsManager)
        {
            string sqlcommand = $"SELECT * FROM {table} WHERE personid = @personid";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("personid", opsManager.personID);
            }
            DBConnection.Disconnect();
        }
    }
}