using ParkingLot.Model;
using ParkingLot.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkingLot.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{

        public Login ()
		{

            InitializeComponent();
            BindingContext = new loginViewModel();

		}

        private void Recover_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecoverP());
        }

      
    }
}