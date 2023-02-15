using System.Data;
using Npgsql;
namespace EventManager
{
    class DBOperations
    {
        private DBConnect DBConnection = new DBConnect();
        public void DBInsert(OperationsManager opsManager)
        {
            string sqlcommand = $"INSERT INTO {opsManager.table} (name, surname, company, accessnumber) VALUES (@name, @surname, @company, @accessnumber);";
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

        public void DBSelect(OperationsManager opsManager)
        {
            string sqlcommand = $"SELECT * FROM {opsManager.table} WHERE personid = @personid";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("personid", opsManager.personID);
                command.ExecuteNonQuery();
            }
            DBConnection.Disconnect();
        }

        public void DBDelete(OperationsManager opsManager)
        {
            string sqlcommand =  $"DELETE FROM {opsManager.table} WHERE personid=(@personID)";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("personid", opsManager.personID);
                command.ExecuteNonQuery();
            }
            DBConnection.Disconnect();
        }

        public void DBUpdate(OperationsManager opsManager)
        {
            string sqlcommand =  $@"UPDATE {opsManager.table}
                SET name = @name, surname = @surname, company = @company, accessNumber = @accessNumber
                WHERE personid = @personid";
            DBConnection.Connect();
            using (NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn()))
            {
                command.Parameters.AddWithValue("personid", opsManager.personID);
                command.Parameters.AddWithValue("name", opsManager.name);
                command.Parameters.AddWithValue("surname", opsManager.surname);
                command.Parameters.AddWithValue("company", opsManager.company);
                command.Parameters.AddWithValue("accessNumber", opsManager.accessnumber);

                command.ExecuteNonQuery();
            }
            DBConnection.Disconnect();
        }
    }
}