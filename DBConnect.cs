using Npgsql;
using System.Data;
namespace EventManager
{
    class DBConnect
    {
        private NpgsqlConnection conn;

        public void Connect()
        {
            try
            {
                conn = new NpgsqlConnection(Settings.connString);
                conn.Open();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Disconnect()
        {
            try
            {
                conn.Close();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ConnState()
        {
            if(conn.State == ConnectionState.Closed)
            {
                Connect();
            }
            if(conn.State != ConnectionState.Closed)
            {
                Disconnect();
            }
        }

        public NpgsqlConnection GetConn()
        {
            return conn;
        }
    }
}