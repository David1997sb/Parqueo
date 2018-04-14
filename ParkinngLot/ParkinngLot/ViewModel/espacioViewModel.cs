using System;
using System.Collections.Generic;
using System.Text;
using ParkingLot.Model;

namespace ParkingLot.ViewModel
{
    class espacioViewModel
    {
		public List<espacioModel> espacios { get; set; }

		public espacioViewModel (){ //constructor
			espacios = new List<espacioModel>
			{
				new espacioModel{
					idEspacio=1,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
				new espacioModel{
					idEspacio=2,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},

				new espacioModel{
					idEspacio=3,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},


			new espacioModel{
					idEspacio=4,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},

			new espacioModel{
					idEspacio=5,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=6,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=7,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=8,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=9,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=10,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=1

				},
			new espacioModel{
					idEspacio=1,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=2,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=3,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=4,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=5,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=6,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=7,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=8,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=9,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=10,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=2

				},
			new espacioModel{
					idEspacio=1,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=2,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=3,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=4,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=5,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=6,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=7,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=8,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=9,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				},
			new espacioModel{
					idEspacio=10,
					estado="disponible",
					horaEntrada= DateTime.Today,
					horaSalida= DateTime.Today,
					tiempoReserva=DateTime.Today,
					usuario="",
					parqueo=3

				}
			
			};

			 void buscaEspacio(int id) {
				foreach (var x in espacios)
				{
					if (x.idEspacio == id) {
						 //do Something
					}

				}
			}
			
		}


		


    }
}
