using Npgsql;

namespace dictionary.DB
{
    internal class DbConnection
    {
        
        public static NpgsqlConnection? OpenConnection()
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(DbConnection.GetConnectionString());
                connection.Open();
                return connection;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    
        private static string GetConnectionString()
        {
            var ConncetinoData = new
            {
                Host = "localhost",
                Port = 5432,
                Database = "dictionary",
                Username = "postgres",
                Password = "mysecretpassword"
            };

            return string.Format(
                "Host={0};Port={1};Database={2};Username={3};Password={4}",
                ConncetinoData.Host,
                ConncetinoData.Port,
                ConncetinoData.Database,
                ConncetinoData.Username,
                ConncetinoData.Password
                );
        }
    }
}
