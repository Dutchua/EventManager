using System;
namespace EventManager
{
    class DBOperations
    {
        public string DBInsert(string table, string column, string value)
        {
            return $"INSERT INTO \"{table}\" ({column}) VALUES ({value})";
        }

        public string DBSelect()
        {
            return "SELECT * FROM \"AttendeeDetails\"";
        }
    }
}