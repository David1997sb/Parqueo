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
	public partial class ParkingView : ContentPage
	{
		public ParkingView ()
		{
			InitializeComponent ();
            btnParqueo1.Clicked += BtnParqueo1_Clicked;
            btnParqueo2.Clicked += BtnParqueo2_Clicked;
            btnParqueo3.Clicked += BtnParqueo3_Clicked;
		}

        private void BtnParqueo3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservationView());
        }

        private void BtnParqueo2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservationView());
        }

        private void BtnParqueo1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ReservationView());
        }
    }
}