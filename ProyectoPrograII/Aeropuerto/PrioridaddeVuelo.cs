using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograII.Aeropuerto
{
    public class PrioridaddeVuelo
    {
        //encapsulamiento
        private string TipodeEmergencia;

        private string UbicaciondeVuelo;

        //constructor

        public PrioridaddeVuelo(string TipodeEmergencia, string UbicaciondeVuelo)
        {
            this.TipodeEmergencia = TipodeEmergencia;
            this.UbicaciondeVuelo = UbicaciondeVuelo;
        }

        public string tipodeemergencia
        {
            get
            {
                return TipodeEmergencia;
            }
            set
            {
                TipodeEmergencia = value;
            }

        }

        public string ubicaciondevuelo
        {
            get
            {
                return UbicaciondeVuelo;

            }
            set
            {
                UbicaciondeVuelo = value;
            }
        }


    }
}
