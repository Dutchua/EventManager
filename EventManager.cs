using System;
using Npgsql;
namespace EventManager
{
    class EventManager
    {
        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.Run();

        }

        public void Run()
        {
            DBOperations ops = new DBOperations();
            ops.DBSelect("AttendeeDetails");
        }
    }
}