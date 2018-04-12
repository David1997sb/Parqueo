using ParkingLot.Model;
using ParkinngLot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace ParkingLot.ViewModel
{
    class createAccountViewModel : INotifyPropertyChanged
    {
        usuarioModel usuarioMod = new usuarioModel();
        ManejoDeSesiones sesiones = new ManejoDeSesiones();

        public event PropertyChangedEventHandler PropertyChanged;

        public usuarioModel usuarioModel
        {
            get { return usuarioMod; }
            set
            {
                usuarioMod = value;
                OnPropertyChanged();
            }
        }

        public Command createUserCommand
        {
            get
            {
                return new Command(async () =>
                {
                    string nombre = usuarioMod.Nombre;
                    string apellido = usuarioMod.apellido;
                    string placa = usuarioMod.placa;
                    string usuario = usuarioMod.usuario1;
                    string contrasena = usuarioMod.Contrasena;
                    string correo = usuarioMod.correo;
                    bool success = true; //await sesiones.postCreateUserAsync(usuario, contrasena, placa, nombre, apellido, correo);
                    if (success == true)
                    {
                        await App.Current.MainPage.DisplayAlert("Notification", "Successfully creation account", "Okay");
                        // Open next page
                    }
                    else
                    {
                        await App.Current.MainPage.DisplayAlert("Notification", "Error creating account", "Okay");
                    }
                });
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
