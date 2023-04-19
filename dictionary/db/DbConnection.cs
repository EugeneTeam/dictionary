using Npgsql;

namespace DB
{
    class DbConnection
    {
        public static void Connect()
        {
            string ConnectionString = DbConnection.GetConnectString();

            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();



                connection.Close();
            }
        }

        public static NpgsqlConnection? OpenConnection()
        {
            string ConncetionString = DbConnection.GetConnectString();
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(ConncetionString);
                connection.Open();
                return connection;
            } 
            catch (NpgsqlException exception) 
            {
                Console.WriteLine(exception.Message);
            }
            return null;
        }

        public static void CloseConnection(NpgsqlConnection? connection)
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            catch (NpgsqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static string GetConnectString()
        {
            var ConnectionOptions = new
            {
                Host = "localhost",
                Port = 5432,
                Database = "dictionary",
                Username = "postgres",
                Password = "mysecretpassword"
            };

            string ConnectionString = string.Format(
                "Host={0};Port={1};Database={2};Username={3};Password={4}",
                    ConnectionOptions.Host,
                    ConnectionOptions.Port,
                    ConnectionOptions.Database,
                    ConnectionOptions.Username,
                    ConnectionOptions.Password
                );

            return ConnectionString;
        }
    }
}