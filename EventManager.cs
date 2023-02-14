using System;
namespace EventManager
{
    class EventManager
    {
        public DBConnect DBConnection = new DBConnect();

        public static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            eventManager.Run();

        }

        public void Run()
        {

        }
    }
}