using ParkingLot.Model;
using ParkinngLot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace ParkingLot.ViewModel
{
    class loginViewModel : usuarioModel
    {
        public ICommand saveCommand { get; set; }
        usuarioModel user = new usuarioModel();
       

        public ICommand SaveCommand { get; set; }



        public usuarioModel usuarioModel
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (usuarioModel.Usuario == "admin" && usuarioModel.Contrasena == "admin")
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Successfully Login", "Okay");
						App.Current.MainPage = new NavigationPage(new View.Home());
						
						// Open next page
					}
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Notification", "Error Login", "Okay");
                    }
                });
            }
        }
    }
}

