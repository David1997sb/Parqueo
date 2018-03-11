using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
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
            /**
             * Este codigo es para el .cs del view del login para poder hacer el post hacia el webservice
             *
            var info = "Tiene que ser el json del usuario y la contrasena";
            string json = JsonConvert.SerializeObject(info);
            var content = new StringContent(json);
            var client = new HttpClient();
            HttpResponseMessage response;
            response = await client.PostAsync("uri del endpoint",content);
             */
        }

        public void cerrarSesion()
        { //codigo para hacer un get
            var session = new HttpRequestMessage();
            session.RequestUri = new Uri("endpoint del API");
            session.Method = HttpMethod.Get;
            session.Headers.Add("Accept", "application/json");
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
            //Se tiene que hacer un insert a la base de datos, hacia la tabla usuario 
           
        }
    }
}
