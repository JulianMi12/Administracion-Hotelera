using Administracion_Hotelera;
using Administracion_Hotelera.model;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Administracion_Roomera.controller
{
    internal class RoomController
    {
        private ConnectionMySQL cn = ConnectionMySQL.GetInstance();
        private List<Room> rooms;

        public RoomController()
        {
            rooms = new List<Room>();
        }

        public List<Room> getBookingRooms(Room filter)
        {
            rooms = new List<Room>();
            string QUERY = "SELECT r.*, h.name AS hotel, h.city FROM rooms r JOIN hotels h ON r.id_hotel = h.id ";
            MySqlDataReader mReader = null;

            try
            {
                if (filter != null)
                {
                    bool date = false, city = false;

                    if ((filter.date_start != DateTime.MinValue && filter.date_start  != null)
                        || (filter.date_end != DateTime.MinValue && filter.date_end != null))
                    {
                        date = true;
                    }
                    if (!string.IsNullOrEmpty(filter.city) && !filter.city.Equals(" "))
                    {
                        city = true;
                    }

                    if (date || city || filter.capacity != 0)
                    {
                        QUERY = QUERY + "WHERE r.status = true ";
                        if (filter.date_start != DateTime.MinValue && filter.date_start != null)
                        {
                            QUERY = QUERY + "AND r.id NOT IN (SELECT DISTINCT id_room FROM bookings WHERE date_start > '" + filter.date_start.ToString("yyyy-MM-dd") + "') ";
                        }
                        /*if (filter.date_end != DateTime.MinValue && filter.date_end != null)
                        {
                            if (flag) { QUERY = QUERY + "AND "; }
                            flag = true;
                            QUERY = QUERY + "b.date_end <=  '" + filter.date_end + "' ";
                        }*/
                        if (filter.capacity != 0)
                        {
                            QUERY = QUERY + "AND r.capacity >=  " + filter.capacity + " ";
                        }
                        if (city)
                        {
                            QUERY = QUERY + "AND h.city = '" + filter.city + "' ";
                        }
                    }
                }

                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = cn.getConnection();
                mReader = command.ExecuteReader();

                Room room = null;
                while (mReader.Read())
                {
                    room = new Room();
                    room.id = mReader.GetInt16("id");
                    room.id_hotel = mReader.GetInt16("id_hotel");
                    room.status = mReader.GetBoolean("status");
                    room.value = mReader.GetFloat("value");
                    room.tax = mReader.GetFloat("tax");
                    room.type = mReader.GetString("type");
                    room.capacity = mReader.GetInt16("capacity");
                    room.location = mReader.GetString("location");
                    room.city = mReader.GetString("city");
                    room.hotel = mReader.GetString("hotel");
                    rooms.Add(room);
                }

                mReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rooms;
        }

        public List<Room> getRoomsByHotel(int id_hotel)
        {
            rooms = new List<Room>();
            string QUERY = "SELECT * FROM rooms WHERE id_hotel = '" + id_hotel + "';";
            MySqlDataReader mReader = null;

            try
            {
                MySqlCommand command = new MySqlCommand(QUERY);
                command.Connection = cn.getConnection();
                mReader = command.ExecuteReader();

                Room room = null;
                while (mReader.Read())
                {
                    room = new Room();
                    room.id = mReader.GetInt16("id");
                    room.id_hotel = mReader.GetInt16("id_hotel");
                    room.status = mReader.GetBoolean("status");
                    room.value = mReader.GetFloat("value");
                    room.tax = mReader.GetFloat("tax");
                    room.type = mReader.GetString("type");
                    room.capacity  = mReader.GetInt16("capacity");
                    room.location = mReader.GetString("location");
                    rooms.Add(room);
                }

                mReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rooms;
        }

        public Room getRoomById(int id)
        {
            string QUERY = "SELECT * FROM rooms ";
            MySqlDataReader mReader = null;
            Room room = null;

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
                        room = new Room();
                        room.id = mReader.GetInt16("id");
                        room.id_hotel = mReader.GetInt16("id_hotel");
                        room.status = mReader.GetBoolean("status");
                        room.value = mReader.GetFloat("value");
                        room.tax = mReader.GetFloat("tax");
                        room.type = mReader.GetString("type");
                        room.capacity = mReader.GetInt16("capacity");
                        room.location = mReader.GetString("location");
                    }

                    mReader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return room;
        }

        internal bool addRoom(Room newRoom)
        {
            string QUERY = "INSERT INTO rooms (id_hotel, status, value, tax, type, capacity, " +
                "location) VALUES (@id_hotel, @status, @value, @tax, @type, @capacity, @location);";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@id_hotel", newRoom.id_hotel));
            command.Parameters.Add(new MySqlParameter("@status", newRoom.status));
            command.Parameters.Add(new MySqlParameter("@value", newRoom.value));
            command.Parameters.Add(new MySqlParameter("@tax", newRoom.tax));
            command.Parameters.Add(new MySqlParameter("@type", newRoom.type));
            command.Parameters.Add(new MySqlParameter("@capacity", newRoom.capacity));
            command.Parameters.Add(new MySqlParameter("@location", newRoom.location));

            return command.ExecuteNonQuery() > 0;
        }
        internal bool updateRoom(Room newRoom)
        {
            string QUERY = "UPDATE rooms SET " +
                "status=@status, " +
                "value=@value, " +
                "tax=@tax, " +
                "type=@type, " +
                "capacity=@capacity, " +
                "location=@location " +
                "WHERE id=@id;";

            MySqlCommand command = new MySqlCommand(QUERY, cn.getConnection());
            command.Parameters.Add(new MySqlParameter("@status", newRoom.status));
            command.Parameters.Add(new MySqlParameter("@value", newRoom.value));
            command.Parameters.Add(new MySqlParameter("@tax", newRoom.tax));
            command.Parameters.Add(new MySqlParameter("@type", newRoom.type));
            command.Parameters.Add(new MySqlParameter("@capacity", newRoom.capacity));
            command.Parameters.Add(new MySqlParameter("@location", newRoom.location));
            command.Parameters.Add(new MySqlParameter("@id", newRoom.id));

            return command.ExecuteNonQuery() > 0;
        }
    }
}
