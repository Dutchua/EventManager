using System;
using Npgsql;
namespace EventManager
{
    class EventManager
    {
        DBOperations ops = new DBOperations();
        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.Run();

        }

        public void Run()
        {
            OperationsManager opmanager = new OperationsManager();
            opmanager.operation = "INSERT";
            opmanager.personID = 1;
            opmanager.name = "Josh";
            opmanager.surname = "Jennings";
            opmanager.company = "BBD";
            opmanager.accessnumber = "5125591f-e21b-4e1e-9c6b-3f65606ed79d";
            opmanager.table = "attendeeDetails";
            ChooseOperation(opmanager);

        }

        public void ChooseOperation(OperationsManager opmanager)
        {
            switch (opmanager.operation)
            {
                case "SELECT":
                    ops.DBSelect(opmanager);
                    break;
                case "INSERT":
                    ops.DBInsert(opmanager);
                    break;
                default:
                    Console.WriteLine("Please choose a valid Query");
                    break;
            }
        }
    }
}