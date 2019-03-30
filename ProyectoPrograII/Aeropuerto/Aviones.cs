using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograII.Aeropuerto
{
    public class Aviones
    {
        //Encapsulamiento 
        public string CodigodeAvion;

        private string TipodeAvion;

        private string ClasedeAvion;

        private string LugarSalidaAvion;

        private string LugarDestinoAvion;

        private string FechayHoraSalidaAvion;

        private string FechayHoraLlegadaAvion;

        private bool Escala;

        private int NumerodePasajerosyTripulacion;

        private string TipodeEmergencia;

        private double Latitud = 0;

        private double Longitud = 0;

        private double Distancia = 0;

        private double TiempoEstimadoLlegada = 0;

        



        //Constructor

        public Aviones(string CodigodeAvion, string TipodeAvion, string ClasedeAvion, string LugarSalidaAvion, string LugarDestinoAvion,
        string FechayHoraSalidaAvion, string FechayHoraLlegadaAvion)
        {
            this.CodigodeAvion = CodigodeAvion;
            this.TipodeAvion = TipodeAvion;
            this.ClasedeAvion = ClasedeAvion;
            this.LugarSalidaAvion = LugarSalidaAvion;
            this.LugarDestinoAvion = LugarDestinoAvion;
            this.FechayHoraSalidaAvion = FechayHoraSalidaAvion;
            this.FechayHoraLlegadaAvion = FechayHoraLlegadaAvion;
            //this.Escala = Escala;
            //this.NumerodePasajerosyTripulacion = NumerodePasajerosyTripulacion;
            //this.TipodeEmergencia = TipodeEmergencia;
            //this.Latitud = Latitud;
            //this.Longitud = Longitud;
            //this.Distancia = Distancia;
            //this.TiempoEstimadoLlegada = TiempoEstimadoLlegada;

        }

        public string codigodeavion
        {
            get
            {
                return CodigodeAvion;
            }

            set
            {
                CodigodeAvion = value;
            }
        }

        public string tipodeavion
        {
            get
            {
                return TipodeAvion;
            }
            set
            {
                TipodeAvion = value;
            }
        }

        public string clasedeavion
        {
            get
            {
                return ClasedeAvion;
            }
            set
            {
                ClasedeAvion = value;
            }

        }

        public string lugarsalidaavion
        {
            get
            {
                return LugarSalidaAvion;
            }
            set
            {
                LugarSalidaAvion = value;
            }
        }

        public string lugardestinoavion
        {
            get
            {
                return LugarDestinoAvion;
            }
            set
            {
                LugarDestinoAvion = value;
            }
        }
        public string fechayhorasalidaavion
        {
            get
            {
                return FechayHoraSalidaAvion;
            }
            set
            {
                FechayHoraSalidaAvion = value;
            }
        }

        public string fechayhorallegadaavion
        {
            get
            {
                return FechayHoraLlegadaAvion;

            }
            set
            {
                FechayHoraLlegadaAvion = value;
            }
        }

        public bool escala
        {
            get
            {
                return Escala;
            }

            set
            {
                Escala = value;
            }
        }

        public int numerodepasajerosytripulacion
        {
            get
            {
                return NumerodePasajerosyTripulacion;
            }
            set
            {
                NumerodePasajerosyTripulacion = value;
            }
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

        public double tiempoestimadollegada
        {
            get
            {
                return TiempoEstimadoLlegada;
            }
            set
            {
                TiempoEstimadoLlegada = value;
            }
        }


    }
}
