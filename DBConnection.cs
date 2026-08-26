using MySql.Data.MySqlClient;

namespace Aura_dectionary
{
    public class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString =
                "server=localhost;database=dictionary_db;uid=root;pwd=;";

            return new MySqlConnection(connectionString);
        }
    }
}