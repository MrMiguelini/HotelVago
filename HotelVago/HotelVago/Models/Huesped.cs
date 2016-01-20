using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelVago.Models
{
    public class Huesped
    {
        public int huespedID { get; set; }
        public String nombre { get; set; }
        public String apellidoP { get; set; }
        public String apellidoM { get; set; }
        public String telefono { get; set; }

        // Huesped tiene una coleccion de reservaciones
        public ICollection<Reservacion> reservaciones { get; set; }
    }
}