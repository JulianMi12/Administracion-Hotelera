using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_Hotelera.model
{
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public Boolean status { get; set; }
        public string statusDesc
        {
            get
            {
                return status ? "Habilitado" : "Deshabilitado";
            }
        }

    }
}
