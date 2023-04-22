using dictionary.DB;
using Npgsql;

namespace dictionary.Entities
{
    class Word
    {
        public static Dictionary<int, string>? Search(string search)
        {
            var connection = DbConnection.OpenConnection();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            if (connection != null ) 
            {
                using(connection)
                {
                    string queryString = string.Format("SELECT * FROM \"words\" WHERE \"name\" LIKE '%{0}%';", search);
                    var commandResult = new NpgsqlCommand(queryString, connection);
                    NpgsqlDataReader read = commandResult.ExecuteReader();
                    while (read.Read())
                    {
                        int index = read.GetInt32(0);
                        string value = read.GetString(1);
                        dictionary.Add(index, value);
                    }
                }
            }
            return dictionary;
        }

        public static Dictionary<int, string>? GetList(int? limit = Constants.DEFAULT_LIMIT, int? offset = Constants.DEFAULT_OFFSET)
        {
            var connection = DbConnection.OpenConnection();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            if (connection != null)
            {
                using (connection)
                {
                    string queryString = string.Format("SELECT * FROM \"words\" LIMIT {0} OFFSET {1}", limit, offset);
                    var commandResult = new NpgsqlCommand(queryString, connection);
                    NpgsqlDataReader read = commandResult.ExecuteReader();

                    while (read.Read())
                    {
                        int index = read.GetInt32(0);
                        string value = read.GetString(1);
                        dictionary.Add(index, value);
                    }
                }
            }
            return dictionary;
        }

        public static Int32? Count()
        {
            var connection = DbConnection.OpenConnection();
            if (connection != null)
            {
                using (connection)
                {
                    string queryString = "SELECT COUNT(*) FROM \"words\";";
                    NpgsqlCommand command = new NpgsqlCommand(queryString, connection);
                    var commandResult = command.ExecuteScalar();
                    if (commandResult != null)
                    {
                        return Convert.ToInt32(commandResult);
                    }
                }
            }
            return null;
        }

        public static bool Add(string name)
        {
            var connection = DbConnection.OpenConnection();
            if (connection != null)
            {
                using (connection)
                {
                    string queryString = string.Format("INSERT INTO \"Words\" (\"id\", \"name\") VALUES (DEFAULT, '{0}');", name);
                    var commandResult = new NpgsqlCommand(queryString, connection);
                    commandResult.ExecuteNonQuery();
                    return true;
                }
            }
            return false;
        }

        public static void Init(NpgsqlConnection connection) 
        {
            const string queryString = "CREATE TABLE IF NOT EXISTS Words (id SERIAL PRIMARY KEY, Name varchar NOT NULL);";
            var commandResult = new NpgsqlCommand(queryString, connection);
            commandResult.ExecuteNonQuery();
        }
    }
}
