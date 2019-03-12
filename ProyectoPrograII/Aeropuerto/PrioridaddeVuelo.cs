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

        private double Latitud;

        private double Longitud;

        private double Distancia;

        private double TiempoLlegada;

        //constructor

        public PrioridaddeVuelo(string TipodeEmergencia, double Latitud, double Longitud, double Distancia, double TiempoLlegada)
        {
            this.TipodeEmergencia = TipodeEmergencia;
            this.Latitud = Latitud;
            this.Longitud = Longitud;
            this.Distancia = Distancia;
            this.TiempoLlegada = TiempoLlegada;
            
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

        public double latitud
        {
            get
            {
                return Latitud;

            }
            set
            {
                Latitud = value;
            }
        }

        public double longitud
        {
            get
            {
                return Longitud;
            }
            set
            {
                Longitud = value;
            }
        }
        public double distancia
        {
            get
            {
                return Distancia;
            }
            set
            {
                Distancia = value;
            }
        }

        public double tiempollegada
        {
            get
            {
                return TiempoLlegada;
            }
            set
            {
                TiempoLlegada = value;
            }
        }

       


    }
}
