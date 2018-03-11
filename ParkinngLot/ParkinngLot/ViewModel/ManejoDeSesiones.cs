using System;
using System.Collections.Generic;
using System.Text;
using ParkingLot.Model;

namespace ParkingLot.ViewModel
{
    class ManejoDeSesiones
    {
            Usuario pruebaUsuario = new Usuario();
        static int idCont = 0;

        public ManejoDeSesiones()
        {
            pruebaUsuario.nombre = "David";
            pruebaUsuario.apellido= "Salas";
            pruebaUsuario.telefono = "857555555";
            pruebaUsuario.password = "pass123";
            pruebaUsuario.id = idCont++;
            Usuario.listaUsuarios.Add(pruebaUsuario);
        }
        public bool inicioDeSesion()
        {
            bool estadoUsuario = false;
            string correoUsuario = "salasbar97@gmial.com";//Esto debe de ser el valor que el usuario pone desde el view de login
            for(int i=0; i < Usuario.listaUsuarios.Count; i++)
            {
                if (Usuario.listaUsuarios[i].correo.Equals(correoUsuario)&& Usuario.listaUsuarios[i].estadoSesion.Equals("Innactivo"))
                {
                    estadoUsuario = true;
                }
            }
            return estadoUsuario;
        }

        public void cerrarSesion()
        {
            //Debe de haber una variable de tipo session en el webservice para poder saber cual es el usuario loggeado
            string usuarioDesdeWebService = "test";
            for (int i = 0; i < Usuario.listaUsuarios.Count; i++)
            {
                if (Usuario.listaUsuarios[i].correo.Equals(usuarioDesdeWebService)){
                    Usuario.listaUsuarios[i].estadoSesion = "Innactivo";
                }
            }
            }

        public void crearCuenta()
        {
            //Se tiene que hacer un insert a la base de datos, a la tabla usuario 

        }
    }
}
