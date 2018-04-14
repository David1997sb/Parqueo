using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Model
{
	class espacioModel
	{
		public int idEspacio { get; set; }
		public string estado { get; set; }
		public DateTime horaEntrada{get; set;}
		public DateTime horaSalida { get; set; }
		public DateTime tiempoReserva { get; set; }
		public string usuario { get; set; }
		public int parqueo { get; set; }

    }
}
