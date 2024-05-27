using Administracion_Hotelera.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Hotelera.controller
{
    internal class UserController
    {
        private List<User> users;
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();


        public UserController()
        {
            users = new List<User>();

        }

        public Boolean login(string username, string password)
        {
            string QUERY = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "';";
            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = cn.getConnection();
                mReader = command.ExecuteReader();

                if (mReader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
