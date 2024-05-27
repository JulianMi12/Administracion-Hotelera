using Administracion_Hotelera.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Hotelera.controller
{
    internal class PassengerController
    {
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();
        private List<Passenger> passengers;

        public PassengerController()
        {
            passengers = new List<Passenger>();
        }

        public Passenger getPassengerById(int id)
        {
            string QUERY = "SELECT * FROM passengers ";
            MySqlDataReader mReader = null;
            Passenger Passenger = null;

            try
            {
                if (id != 0)
                {
                    QUERY = QUERY + "WHERE id = " + id;
                    MySqlCommand command = new MySqlCommand(QUERY);
                    command.Connection = cn.getConnection();
                    mReader = command.ExecuteReader();

                    if (mReader.HasRows)
                    {
                        Passenger = new Passenger();
                        Passenger.id = mReader.GetInt16("id");
                        Passenger.first_name = mReader.GetString("first_name");
                        Passenger.last_name = mReader.GetString("last_name");
                        Passenger.date_birth = mReader.GetDateTime("date_birth");
                        Passenger.gender = mReader.GetString("gender");
                        Passenger.type_doc = mReader.GetString("type_doc");
                        Passenger.email = mReader.GetString("email");
                        Passenger.phone = mReader.GetString("phone");
                        Passenger.emergency_contact = mReader.GetString("emergency_contact");
                    }

                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Passenger;
        }

        internal bool addPassenger(Passenger newPassenger)
        {
            try
            {
                string QUERY = "INSERT INTO passenger (id, first_name, last_name, date_birth, gender, " +
                "type_doc, email, phone, emergency_contact) VALUES (@id, @first_name, @last_name, " +
                "@date_birth, @gender, @type_doc, @email, @phone, @emergency_contact);";

                MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
                command.Parameters.Add(new MySqlParameter("@id", newPassenger.id));
                command.Parameters.Add(new MySqlParameter("@first_name", newPassenger.first_name));
                command.Parameters.Add(new MySqlParameter("@last_name", newPassenger.last_name));
                command.Parameters.Add(new MySqlParameter("@date_birth", newPassenger.date_birth));
                command.Parameters.Add(new MySqlParameter("@gender", newPassenger.gender));
                command.Parameters.Add(new MySqlParameter("@type_doc", newPassenger.type_doc));
                command.Parameters.Add(new MySqlParameter("@email", newPassenger.email));
                command.Parameters.Add(new MySqlParameter("@phone", newPassenger.phone));
                command.Parameters.Add(new MySqlParameter("@emergency_contact", newPassenger.emergency_contact));

                return command.ExecuteNonQuery() > 0;
            } 
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            return false;
        }
        internal bool updatePassenger(Passenger newPassenger)
        {
            string QUERY = "UPDATE passengers SET " +
                "first_name=@first_name, " +
                "last_name=@last_name, " +
                "date_birth=@date_birth, " +
                "gender=@gender, " +
                "type_doc=@type_doc, " +
                "usr_id=@usr_id, " +
                "email=@email " +
                "phone=@phone " +
                "emergency_contact=@emergency_contact " +
                "WHERE id=@id;";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@first_name", newPassenger.first_name));
            command.Parameters.Add(new MySqlParameter("@last_name", newPassenger.last_name));
            command.Parameters.Add(new MySqlParameter("@date_birth", newPassenger.date_birth));
            command.Parameters.Add(new MySqlParameter("@gender", newPassenger.gender));
            command.Parameters.Add(new MySqlParameter("@type_doc", newPassenger.type_doc));
            command.Parameters.Add(new MySqlParameter("@usr_id", newPassenger.usr_id));
            command.Parameters.Add(new MySqlParameter("@email", newPassenger.email));
            command.Parameters.Add(new MySqlParameter("@phone", newPassenger.phone));
            command.Parameters.Add(new MySqlParameter("@emergency_contact", newPassenger.emergency_contact));
            command.Parameters.Add(new MySqlParameter("@id", newPassenger.id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
