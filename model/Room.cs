using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Hotelera.model
{
    public class Room
    {
        public int id { get; set; }
        public int id_hotel { get; set; }
        public Boolean status { get; set; }
        public float value { get; set; }
        public float tax { get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        public string location { get; set; }
        public string statusDescAdmin
        {
            get
            {
                return status ? "Habilitado" : "Deshabilitado";
            }
        }

        public string capacityView
        {
            get
            {
                return capacity + " Personas";
            }
        }

        //Booking
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }
        public string city { get; set; }
        public string hotel { get; set; }
    }
}
