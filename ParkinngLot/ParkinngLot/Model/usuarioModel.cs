using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingLot.Model
{
    class usuarioModel: INotifyPropertyChanged
    {
        public static string nombre { get; set; }
        public string apellido { get; set; }
        public string placa { get; set; }
        public string usuario1 { get; set; }
        public static string contrasena { get; set; }
        public string correo { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

