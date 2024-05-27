using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Hotelera.model
{
    public class Booking
    {
        public int id { get; set; }
        public int id_hotel { get; set; }
        public int id_room { get; set; }
        public int id_passenger { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }

        // Extra data
        //  Hotel
        public string name_hotel { get; set; }
        public string city_hotel { get; set; }
        
        //Room
        public string location_room { get; set; }
        public string type_room { get; set; }
        public int capacity_room { get; set; }
        public float value_room { get; set; }
        public float tax_room { get; set; }

        //Passeger
        public string type_doc_pssg { get; set; }
        public string doc_pssg { get; set; }
        public string first_name_pssg { get; set; }
        public string last_name_pssg { get; set; }
        public string phone_pssg { get; set; }
        public string email_pssg { get; set; }
    }
}
