using System;
using System.Collections.Generic;
using System.Text;
using ParkingLot.Model;

namespace ParkingLot.ViewModel
{
    class parqueoViewModel
    {
		public List<Parqueo> parqueos { get; set; }

		public parqueoViewModel() {
			parqueos = new List<Parqueo> {
				new Parqueo{

					idParqueo= 1,
					nombreParqueo="Parqueo Ulacit",
					cantEspacios=10,
					ubicacion="ulacit"

					},
				new Parqueo{

					idParqueo= 2,
					nombreParqueo="Parqueo San Jose",
					cantEspacios=10,
					ubicacion="San Jose",

					},
				new Parqueo{

					idParqueo= 3,
					nombreParqueo="Parqueo Mall San Pedro",
					cantEspacios=10,
					ubicacion="Mall San Pedro"

					}

			};



		}

    }
}
