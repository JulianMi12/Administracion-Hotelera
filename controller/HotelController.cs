using Administracion_Hotelera.model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Hotelera.controller
{
    internal class HotelController
    {
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();
        private List<Hotel> hotels;

        public HotelController()
        {
            hotels = new List<Hotel>();
        }

        public List<Hotel> getAllHotels()
        {
            hotels = new List<Hotel>();
            string QUERY = "SELECT * FROM hotels;";
            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = cn.getConnection();
                mReader = command.ExecuteReader();

                Hotel hotel = null;
                while (mReader.Read())
                {
                    hotel = new Hotel();
                    hotel.id = mReader.GetInt16("id");
                    hotel.name = mReader.GetString("name");
                    hotel.city = mReader.GetString("city");
                    hotel.status = mReader.GetBoolean("status");
                    hotels.Add(hotel);
                }

                mReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return hotels;
        }

        public Hotel getHotelById(int id)
        {
            string QUERY = "SELECT * FROM hotels ";
            MySqlDataReader mReader = null;
            Hotel hotel = null;

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
                        mReader.Read();
                        hotel = new Hotel();
                        hotel.id = mReader.GetInt16("id");
                        hotel.name = mReader.GetString("name");
                        hotel.city = mReader.GetString("city");
                        hotel.status = mReader.GetBoolean("status");
                    }

                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return hotel;
        }

        internal bool addHotel(Hotel newHotel)
        {
            string QUERY = "INSERT INTO hotels (name, city, status) VALUES (" +
                "@name, @city, @status);";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@name", newHotel.name));
            command.Parameters.Add(new MySqlParameter("@city", newHotel.city));
            command.Parameters.Add(new MySqlParameter("@status", newHotel.status));

            return command.ExecuteNonQuery() > 0;
        }

        internal bool updateHotel(Hotel newHotel)
        {
            string QUERY = "UPDATE hotels SET " +
                "name=@name, " +
                "city=@city, " +
                "status=@status " +
                "WHERE id=@id;";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@name", newHotel.name));
            command.Parameters.Add(new MySqlParameter("@city", newHotel.city));
            command.Parameters.Add(new MySqlParameter("@status", newHotel.status));
            command.Parameters.Add(new MySqlParameter("@id", newHotel.id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
