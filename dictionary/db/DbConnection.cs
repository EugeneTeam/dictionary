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
            return Properties.Settings.Default.ConnectionString;
        }
    }
}
