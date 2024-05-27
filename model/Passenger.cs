using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Hotelera.model
{
    internal class Passenger
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_birth { get; set; }
        public string gender { get; set; }
        public string type_doc { get; set; }
        public string usr_id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string emergency_contact { get; set; }
    }
}
