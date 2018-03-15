using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

namespace webServiceXamarin
{

    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private SqlConnection con;
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();
        private SqlCommand cmd;
        public SqlDataReader dr;


        private void conexion() //realiza la conexion a la base de datos
        {

            con = new SqlConnection("server=localhost;user=sa;pwd=123456;initial catalog=xamarinDatabase");
            con.Open();
        }

        private void cerrarConexion()//cierra la conexion
        {
            con.Close();

        }

        private void comandoSQL(string query) // query a ejecutar en la base de datos
        {
            cmd = new SqlCommand(query,con);
            
        }

        private void parametros(string param, SqlDbType tipo, object value) //parametros utilizados en la base de datos
        {
            cmd.Parameters.Add(param, tipo).Value = value;

        }

        private int ejecutaQuery()//devuelve la cantidad de filas afectadas en la base de datos, despues de ejecutar el query.
        {
            int numFilas;
            numFilas = cmd.ExecuteNonQuery();
            return numFilas;

        }

        [WebMethod]  //recibe los datos de registro de un usuario y los inserta en la base de datos.
        public bool registroUsuario(int id, string nombre, string apellido, string correo, string usuario, string contrasena, string placa)
        {
            bool insertaRegistro;
            conexion();
            comandoSQL("INSERT INTO usuario(id_usuario,nombre,apellido,correo, usuario,contrasena,placa_vehiculo) VALUES(@id,@nombre,@apellido,@correo,@usuario,@contrasena,@placa);");
            parametros("@id",SqlDbType.Int,id);
            parametros("@nombre", SqlDbType.VarChar,nombre);
            parametros("@apellido", SqlDbType.VarChar, apellido);
            parametros("@correo", SqlDbType.VarChar, correo);
            parametros("@usuario", SqlDbType.VarChar, usuario);
            parametros("@contrasena", SqlDbType.VarChar, contrasena);
            parametros("@placa", SqlDbType.VarChar, placa);

            if (ejecutaQuery() > 0)
            {
                insertaRegistro = true;
            }
            else
            {
                insertaRegistro = false;
            }
            return insertaRegistro;
        }


        [WebMethod] //valida si el usuario se encuentra registrado
        public bool validaUsuario(string usuario, string contrasena)
        {
            bool existeUsuario;
            conexion();
            comandoSQL("SELECT * FROM usuario where usuario=@usuario and contrasena=@contrasena;");
            parametros("@usuario",SqlDbType.VarChar,usuario);
            parametros("@contrasena", SqlDbType.VarChar, contrasena);

            if (ejecutaQuery() > 0)
            {
                existeUsuario = true;
            }
            else
            {
                existeUsuario = false;
            }
            return existeUsuario;
        }
    }
}
