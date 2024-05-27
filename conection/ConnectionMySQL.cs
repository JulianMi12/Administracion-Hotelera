using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Hotelera
{
    internal class ConnectionMySQL : Connection
    {
        private MySqlConnection connection;
        private static ConnectionMySQL instance;
        private string strConnection;
        public ConnectionMySQL()
        {
            strConnection = "Database=" + database +
                "; DataSource=" + server +
                "; User Id=" + user +
                "; Password=" + password;

            connection = new MySqlConnection(strConnection);
        }

        public static ConnectionMySQL GetInstance()
        {
            if (instance == null)
            {
                instance = new ConnectionMySQL();
            }
            return instance;
        }

        public MySqlConnection getConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
            return connection;
        }

        public void closeConnection() { connection.Close(); }
    }
}
