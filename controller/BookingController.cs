using Administracion_Hotelera;
using Administracion_Hotelera.model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Bookingera.controller
{
    internal class BookingController
    {
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();
        private List<Booking> bookings;

        public BookingController()
        {
            bookings = new List<Booking>();
        }

        public List<Booking> getAllBookings()
        {
            bookings = new List<Booking>();
            string QUERY = "SELECT b.*, h.name AS name_hotel, CONCAT(r.type, ', ', r.location)" +
                " AS type_room FROM bookings b JOIN hotels h ON b.id_hotel = h.id" +
                " JOIN rooms r ON b.id_room = r.id;";
            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = cn.getConnection();
                mReader = command.ExecuteReader();

                Booking booking = null;
                while (mReader.Read())
                {
                    booking = new Booking();
                    booking.id = mReader.GetInt16("id");
                    booking.id_hotel = mReader.GetInt16("id_hotel");
                    booking.id_room = mReader.GetInt16("id_room");
                    booking.id_passenger = mReader.GetInt32("id_passenger");
                    booking.date_start = mReader.GetDateTime("date_start");
                    booking.date_end = mReader.GetDateTime("date_end");
                    booking.name_hotel = mReader.GetString("name_hotel");
                    booking.type_room = mReader.GetString("type_room");
                    bookings.Add(booking);
                }

                mReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return bookings;
        }

        public Booking getBookingById(int id)
        {
            string QUERY = "SELECT b.*, " +
                "h.name AS name_hotel, h.city AS  city_hotel, " +
                "r.location AS location_room, r.type AS type_room, r.capacity AS capacity_room, " +
                "r.value AS value_room, r.tax AS tax_room, " +
                "p.type_doc AS type_doc_pssg, p.id AS doc_pssg, p.first_name AS first_name_pssg, " +
                "p.last_name AS last_name_pssg, p.phone AS phone_pssg, p.email AS email_pssg " +
                "FROM bookings b " +
                "JOIN hotels h ON b.id_hotel = h.id " +
                "JOIN rooms r ON b.id_room = r.id " +
                "JOIN passenger p ON b.id_passenger = p.id " +
                "WHERE b.id = " + id;
            MySqlDataReader mReader = null;
            Booking booking = null;

            try
            {
                if (id != 0)
                {
                    MySqlCommand command = new MySqlCommand(QUERY);
                    command.Connection = cn.getConnection();
                    mReader = command.ExecuteReader();

                    while (mReader.Read())
                    {
                        booking = new Booking();
                        booking.id = mReader.GetInt32("id");
                        booking.name_hotel = mReader.GetString("name_hotel");
                        booking.city_hotel = mReader.GetString("city_hotel");
                        booking.location_room = mReader.GetString("location_room");
                        booking.type_room = mReader.GetString("type_room");
                        booking.capacity_room = mReader.GetInt16("capacity_room");
                        booking.date_start = mReader.GetDateTime("date_start");
                        booking.date_end = mReader.GetDateTime("date_end");
                        booking.value_room = mReader.GetFloat("value_room");
                        booking.tax_room = mReader.GetFloat("tax_room");
                        booking.type_doc_pssg = mReader.GetString("type_doc_pssg");
                        booking.first_name_pssg = mReader.GetString("first_name_pssg");
                        booking.last_name_pssg = mReader.GetString("last_name_pssg");
                        booking.phone_pssg = mReader.GetString("phone_pssg");
                        booking.email_pssg = mReader.GetString("email_pssg");
                    }

                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return booking;
        }

        internal bool addBooking(Booking newBooking)
        {
            string QUERY = "INSERT INTO bookings (id_hotel, id_room, id_passenger, date_start, " +
                "date_end) VALUES (@id_hotel, @id_room, @id_passenger, @date_start, @date_end);";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@id_hotel", newBooking.id_hotel));
            command.Parameters.Add(new MySqlParameter("@id_room", newBooking.id_room));
            command.Parameters.Add(new MySqlParameter("@id_passenger", newBooking.id_passenger));
            command.Parameters.Add(new MySqlParameter("@date_start", newBooking.date_start));
            command.Parameters.Add(new MySqlParameter("@date_end", newBooking.date_end));
            
            return command.ExecuteNonQuery() > 0;
        }
        internal bool updateBooking(Booking newBooking)
        {
            string QUERY = "UPDATE bookings SET " +
                "date_start=@date_start, " +
                "date_end=@date_end, " +
                "WHERE id=@id;";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@date_start", newBooking.date_start));
            command.Parameters.Add(new MySqlParameter("@date_end", newBooking.date_end)); 
            command.Parameters.Add(new MySqlParameter("@id", newBooking.id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
