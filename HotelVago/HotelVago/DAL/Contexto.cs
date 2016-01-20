using HotelVago.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelVago.DAL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("ConexionHotelVago")
        {

        }
        //Definicion de tablas a partir de las entidades
        public DbSet<Huesped> huesped { get; set; }
        public DbSet<Habitacion> habitacion { get; set; }
        public DbSet<Reservacion> reservacion { get; set; }
    }
}