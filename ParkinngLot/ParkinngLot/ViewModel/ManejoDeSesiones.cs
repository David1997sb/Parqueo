using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using ParkingLot.Model;

namespace ParkingLot.ViewModel
{
    class ManejoDeSesiones
    {
            usuarioModel pruebaUsuario = new usuarioModel();
        static int idCont = 0;
        HttpClient client = new HttpClient();


        public ManejoDeSesiones()
        {
            pruebaUsuario.nombre = "David";
            pruebaUsuario.apellido= "Salas";
            pruebaUsuario.telefono = "857555555";
            pruebaUsuario.password = "pass123";
            pruebaUsuario.id = idCont++;
            usuarioModel.listaUsuarios.Add(pruebaUsuario);
        }
        public async System.Threading.Tasks.Task inicioDeSesionAsync()
        {
            /* bool estadoUsuario = false;
             string correoUsuario = "salasbar97@gmial.com";//Esto debe de ser el valor que el usuario pone desde el view de login
             for(int i=0; i < Usuario.listaUsuarios.Count; i++)
             {
                 if (Usuario.listaUsuarios[i].correo.Equals(correoUsuario)&& Usuario.listaUsuarios[i].estadoSesion.Equals("Innactivo"))
                 {
                     estadoUsuario = true;
                 }
             }*/
            // return estadoUsuario;
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["username"] = "myUser";
                data["password"] = "myPassword";

               // var response = wb.UploadValues(url, "POST", data);
                //string responseInString = Encoding.UTF8.GetString(response);
            }
            /* var info = "{'user':'david',''pass': 'esx'}";
             string json = JsonConvert.SerializeObject(info);
             var content = new StringContent(json);
             HttpResponseMessage response;
             response = await client.PostAsync("http://localhost:50289/api/usuarios/isUser", content);*/
        }   

        public void cerrarSesion()
        { //codigo para hacer un get
            var session = new HttpRequestMessage();
            session.RequestUri = new Uri("endpoint del API");
            session.Method = HttpMethod.Get;
            session.Headers.Add("Accept", "application/json");
            //Debe de haber una variable de tipo session en el webservice para poder saber cual es el usuario loggeado
            string usuarioDesdeWebService = "test";
            for (int i = 0; i < usuarioModel.listaUsuarios.Count; i++)
            {
                if (usuarioModel.listaUsuarios[i].correo.Equals(usuarioDesdeWebService)){
                    usuarioModel.listaUsuarios[i].estadoSesion = "Innactivo";
                }
            }
            }

        public void crearCuenta()
        {
            //Se tiene que hacer un insert a la base de datos, hacia la tabla usuario 
           
        }
    }
}
