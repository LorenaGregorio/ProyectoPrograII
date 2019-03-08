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
        private string CodigodeAvion;

        private string TipodeAvion;

        private string ClasedeAvion;

        private string LugarSalidaAvion;

        private string LugarDestinoAvion;

        private string FechayHoraSalidaAvion;

        private string FechayHoraLlegadaAvion;

        private string Escala;

        private int NumerodePasajerosyTripulacion;

        

        //Constructor

        public Aviones(string CodigodeAvion, string TipodeAvion, string ClasedeAvion, string LugarSalidaAvion, string LugarDestinoAvion,
        string FechayHoraSalidaAvion, string FechayHoraLlegadaAvion, string Escala, int NumerodePasajerosyTripulacion)
        {
            this.CodigodeAvion = CodigodeAvion;
            this.TipodeAvion = TipodeAvion;
            this.ClasedeAvion = ClasedeAvion;
            this.LugarSalidaAvion = LugarSalidaAvion;
            this.LugarDestinoAvion = LugarDestinoAvion;
            this.FechayHoraSalidaAvion = FechayHoraSalidaAvion;
            this.FechayHoraLlegadaAvion = FechayHoraLlegadaAvion;
            this.Escala = Escala;
            this.NumerodePasajerosyTripulacion = NumerodePasajerosyTripulacion;
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

        public string escala
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


    }
}
