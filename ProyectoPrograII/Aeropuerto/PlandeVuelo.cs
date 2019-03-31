using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograII.Aeropuerto
{
    public class PlandeVuelo
    {
        //Encapsulamiento

        private string CodigodeAvion;

        private string TipodeAccion;

        private string ClasedeAvion;

        private string LugarSalida_LlegadaAvion;

        private string Fecha;

        private bool Escala;

        private string NumerodePista;

        private string TipodeEmergencia;

        private double Latitud =0;

        private double Longitud = 0;

        private double Distancia = 0;

        private double TiempoDespegue = 0;



        private double TiempoEstimadoLlegada = 0;
      




        //constructor
        //, string NumerodePista,
        //string TipodeEmergencia, double Latitud, double Longitud, double Distancia, double TiempoEstimadoLlegada
        public PlandeVuelo(string CodigodeAvion, string TipodeAccion, string ClasedeAvion, string NumerodePista, string LugarSalida_LlegadaAvion, string Fecha, bool Escala, 
         string TipodeEmergencia, double Latitud, double Longitud, double Distancia, double TiempoEstimadoLlegada, double TiempoDespegue)    
        {
            this.CodigodeAvion = CodigodeAvion;
            this.TipodeAccion = TipodeAccion;
            this.ClasedeAvion = ClasedeAvion;
            this.NumerodePista = NumerodePista;
            this.LugarSalida_LlegadaAvion = LugarSalida_LlegadaAvion;
            this.Fecha = Fecha;
            this.Escala = Escala;
           
            this.TipodeEmergencia = TipodeEmergencia;
            this.Latitud = Latitud;
            this.Longitud = Longitud;
            this.Distancia = Distancia;
            this.TiempoEstimadoLlegada = TiempoEstimadoLlegada;
            this.TiempoDespegue = TiempoDespegue;
            


        }

        //public PlandeVuelo(string text1, string text2, string text3, string text4, string text5, bool v1, string text6, string text7, string text8, int v2, int v3, double v4, double v5)
        //{
        //    this.text1 = text1;
        //    this.text2 = text2;
        //    this.text3 = text3;
        //    this.text4 = text4;
        //    this.text5 = text5;
        //    this.v1 = v1;
        //    this.text6 = text6;
        //    this.text7 = text7;
        //    this.text8 = text8;
        //    this.v2 = v2;
        //    this.v3 = v3;
        //    this.v4 = v4;
        //    this.v5 = v5;
        //}

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


        public string tipodeaccion
        {
            get
            {
                return TipodeAccion;
            }
            set
            {
                TipodeAccion = value;
            }
        }
        public string lugarsalida_llegadaavion
        {
            get
            {
                return LugarSalida_LlegadaAvion;
            }
            set
            {
                LugarSalida_LlegadaAvion = value;
            }
        }

        public string numerodepista
        {
            get
            {
                return NumerodePista;
            }
            set
            {
                NumerodePista = value;
            }

        }
       
        public string fecha
        {
            get
            {
                return Fecha;
            }
            set
            {
                Fecha = value;
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
        public double tiempodespegue
        {
            get
            {
                return TiempoDespegue;
            }
            set
            {
                TiempoDespegue = value;
            }
        }







    }
}
