using System;
using Npgsql;
namespace EventManager
{
    class EventManager
    {
        protected DBConnect DBConnection = new DBConnect();

        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.Run();

        }

        public void Run()
        {
            DBConnection.Connect();
            DBOperations ops = new DBOperations();
        }

        public void Execute(string sqlcommand)
        {
            NpgsqlCommand command = new NpgsqlCommand(sqlcommand, DBConnection.GetConn());
            command.ExecuteNonQuery();
        }
    }
}