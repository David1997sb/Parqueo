using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingLot.Model
{
    class usuarioModel
    {
        public string  nombre { get; set; }
        public string  apellido { get; set; }
        public string telefono { get; set; }
        public string  usuario { get; set; }    
        public int id { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
        public string estadoSesion { get; set; }
        public static List<usuarioModel> listaUsuarios = new List<usuarioModel>();
    }
}
