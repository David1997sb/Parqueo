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
    class loginViewModel : INotifyPropertyChanged
    {
        usuarioModel usuarioMod = new usuarioModel();

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

        public Command LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (usuarioMod.nombre == "admin" && usuarioMod.password == "admin")
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Successfully Login", "Okay");
                        // Open next page
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Error Login", "Okay");
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
