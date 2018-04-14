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
        nuevoUsuarioModel usuarioMod = new nuevoUsuarioModel();
        

        public event PropertyChangedEventHandler PropertyChanged;

        public nuevoUsuarioModel nuevoUsuarioModel
        {
            get { return usuarioMod; }
            set
            {
                usuarioMod = value;
                OnPropertyChanged();
            }
        }

        public Command CreateAccountCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (nuevoUsuarioModel.Nombre != null && nuevoUsuarioModel.Apellido!= null && nuevoUsuarioModel.Usuario !=null && nuevoUsuarioModel.Contrasena !=null && nuevoUsuarioModel.Placa != null && nuevoUsuarioModel.Correo!=null)
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Se creo existosamente la contraseña", "Okay");
                        // Open next page
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Error, verifica la informacion", "Okay");
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
