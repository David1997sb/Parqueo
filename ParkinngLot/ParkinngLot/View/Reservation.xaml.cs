using ParkingLot.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinalUI.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservation : ContentPage
    {
        espacioViewModel espacio = new espacioViewModel();
        public Reservation()
        {
            InitializeComponent();
            llenaEspacio1();
            llenaEspacio2();
            llenaEspacio3();
            llenaEspacio4();
            llenaEspacio5();
            llenaEspacio6();
            llenaEspacio7();
            llenaEspacio8();
            llenaEspacio9();
            llenaEspacio10();
        }

        public void llenaEspacio1()
        {
            foreach (var x in espacio.espacios)
            {
                int id = 1;
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo1.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo1.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo1.BackgroundColor = Color.LightYellow;
                    }
                }
            }
        }

        public void llenaEspacio2()
        {
            int id = 2;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo2.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo2.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo2.BackgroundColor = Color.LightYellow;
                    }
                }
            }
        }
        public void llenaEspacio3()
        {
            int id = 3;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo3.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo3.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo3.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }

        public void llenaEspacio4()
        {
            int id = 4;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo4.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo4.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo4.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }

        public void llenaEspacio5()
        {
            int id = 5;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo5.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Ocupado")
                    {
                        btnCampo5.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo5.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }
        public void llenaEspacio6()
        {
            int id = 6;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo6.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo6.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo6.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }
        public void llenaEspacio7()
        {
            int id = 7;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo7.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo7.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo7.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }
        public void llenaEspacio8()
        {
            int id = 8;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo8.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo8.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo8.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }

        public void llenaEspacio9()
        {
            int id = 9;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo9.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo9.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo9.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }
        public void llenaEspacio10()
        {
            int id = 10;
            foreach (var x in espacio.espacios)
            {
                if (x.idEspacio == id)
                {
                    if (x.estado == "Disponible")
                    {
                        btnCampo10.BackgroundColor = Color.LightGreen;

                    }
                    else if (x.estado == "Reservado")
                    {
                        btnCampo10.BackgroundColor = Color.Red;

                    }
                    else
                    {
                        btnCampo10.BackgroundColor = Color.LightYellow;
                    }
                }

            }
        }
    }
}