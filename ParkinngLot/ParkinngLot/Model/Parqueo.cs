using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Model
{
    class Parqueo
    {
        public int cantEspacios{ get; set; }
        public int  tiempoMaxReserva { get; set; }
        public int tiempoUso { get; set; }
        public string estado { get; set; }
        public int monto { get; set; }
        public string ubicacion { get; set; }
        public int idParqueo { get; set; }
    }
}
