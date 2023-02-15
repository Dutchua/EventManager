using System;
using Npgsql;
namespace EventManager
{
    class EventManager : IOperations
    {
        DBOperations ops = new DBOperations();
        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.Run();

        }

        public void Run()
        {
            OperationsManager opmanager = new OperationsManager(1,"Josh", "Jennings","BBD", 
                                                                "5125591f-e21b-4e1e-9c6b-3f65606ed79d", 
                                                                "attendeeDetatils", IOperations.Operations.INSERT); 
            ChooseOperation(opmanager);

        }

        public void ChooseOperation(OperationsManager opmanager)
        {
            switch (opmanager.operation)
            {
                case IOperations.Operations.SELECT:
                    ops.DBSelect(opmanager);
                    break;
                case IOperations.Operations.INSERT:
                    ops.DBInsert(opmanager);
                    break;
                case IOperations.Operations.DELETE:
                    ops.DBDelete(opmanager);
                    break;
                case IOperations.Operations.UPDATE:
                    ops.DBUpdate(opmanager);
                    break;
                default:
                    Console.WriteLine("Please choose a valid Query");
                    break;
            }
        }
    }
}