using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Model
{
    class Usuario
    {
        public string  nombre { get; set; }
        public string  apellido { get; set; }
        public string telefono { get; set; }
        public int id { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public string estadoSesion { get; set; }
        public static List<Usuario> listaUsuarios = new List<Usuario>();

    }
}
