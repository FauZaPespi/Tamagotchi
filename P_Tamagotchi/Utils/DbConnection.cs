using System.Data.SQLite;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Utils
{
    public class DbConnection
    {
        private static DbConnection _instance = null;
        private SQLiteConnection connection = null;
        private DbConnection()
        {
            InitDB();
        }

        public static DbConnection GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DbConnection();
            }
            return _instance;
        }

        public SQLiteConnection GetConnection()
        {
            if (connection == null)
            {
                InitDB();
            }
            return connection;
        }

        private void InitDB()
        {
            string template = "";
            var connectionString = new SQLiteConnectionStringBuilder()
            {
                DataSource = "tamagotchi.db"
            }.ToString();

            connection = new SQLiteConnection(connectionString);

            Console.WriteLine(connectionString.ToString());
            try
            {
                connection = new SQLiteConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong when creating the connection: {ex}");
            }

            if (connection == null)
            {
                Console.WriteLine("La connexion est nulle, arrêt de l'initialisation.");
                return;
            }

            try
            {
                connection.Open();
            }
            catch (Exception ex1)
            {
                Console.WriteLine($"Something went wrong when opening the connection: {ex1}");
            }

            Console.WriteLine("Connexion à la base de données établie avec succès.");
        }
        private void CloseDB()
        {
            if (connection != null)
            {
                connection.Close();
                connection = null;
                Console.WriteLine("Connexion à la base de données fermée.");
            }
            else { Console.WriteLine("Initialisez la base de données avant de la fermer."); }
        }

        public void Execute(string sql)
        {
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public SQLiteDataReader Query(string sql)
        {
            var command = new SQLiteCommand(sql, connection);
            return command.ExecuteReader(); // le caller doit gérer la fermeture du reader ET du command
        }

    }
}
