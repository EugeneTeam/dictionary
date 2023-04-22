using dictionary;
using dictionary.Entities;

namespace dictionary.DB.Init
{
    internal class CreateDb
    {
        public static void Init() {
            var connection = DbConnection.OpenConnection();
            if (connection != null)
            {
                using (connection) {
                    Word.Init(connection);
                }
            }
        }
    }
}
