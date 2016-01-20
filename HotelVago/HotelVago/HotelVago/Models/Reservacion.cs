using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelVago.Models
{
    public class Reservacion
    {
        public int reservacionID { get; set; }//llave primaria

        [DataType(DataType.Date)]
        public DateTime fechaDeIngreso { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaDeSalida { get; set; }
        public int numeroDeHabitacion { get; set; }

        //llave foranea con Huesped.
        public int habitacionID { get; set; }
        public Habitacion habitacion { get; set; }

        //Lave foranea con Habitacion.
        public int huespedID { get; set; }
        public Huesped huesped { get; set; }

    }
}