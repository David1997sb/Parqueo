using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ParkingLot.Model
{
    class nuevoUsuarioModel
    {
        public static string nombre { get; set; }
        public static string apellido { get; set; }
        public static string placa { get; set; }
        public static string usuario1 { get; set; }
        public static string contrasena { get; set; }
        public static string correo { get; set; }



        public string Correo
        {
            get { return correo; }
            set
            {
                if (value != correo)
                {
                    correo = value;
                    OnPropertyChanged("Correo");
                }
            }
        }

        public string Usuario
        {
            get { return usuario1; }
            set
            {
                if (value != usuario1)
                {
                    usuario1 = value;
                    OnPropertyChanged("Usuario");
                }
            }
        }


        public string Placa
        {
            get { return placa; }
            set
            {
                if (value != placa)
                {
                    placa = value;
                    OnPropertyChanged("Placa");
                }
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                if (value != apellido)
                {
                    apellido = value;
                    OnPropertyChanged("Apellido");
                }
            }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set
            {
                if (value != contrasena)
                {
                    contrasena = value;
                    OnPropertyChanged("Contrasena");
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value != nombre)
                {
                    nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
