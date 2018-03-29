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
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
            bntLogin.Clicked += BntLogin_Clicked;
            btnSignIn.Clicked += BtnSignIn_Clicked;
        }

        private void BtnSignIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignIn());

        }

        private void BntLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}