using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelVago.Models
{
    //Solo hago una prueba
    public class Habitacion
    {
        public int habitacionID { get; set; }
        public string tamañoHabitacion { get; set; }
        public Boolean estado { get; set; }


        //una Habitación ouede tener muchas Recervaciones
        public ICollection<Reservacion> reservaciones;
    }
}