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


        }

        public OperationsManager getData()
        {
            OperationsManager opmanager = new OperationsManager();
            opmanager.personID = 1;
            opmanager.name = "Josh";
            opmanager.surname = "Jennings";
            opmanager.company = "BBD";
            opmanager.accessnumber = "5125591f-e21b-4e1e-9c6b-3f65606ed79d";
            return opmanager;
        }
    }
}