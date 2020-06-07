using MySql.Data.MySqlClient;

namespace AutoSclad
{
    class Dibi
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=autosclad");
        public void openconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeconnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getconnection()
        {
            return connection;
        }

    }
}
