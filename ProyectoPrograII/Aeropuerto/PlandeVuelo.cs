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
        private string TipodeAccion;

        private string NumerodePista;

        private string FechadeEntrada;

        private string FechadeSalida;
        
        //constructor

        public PlandeVuelo(string TipodeAccion, string NumerodePista, string FechadeEntrada, string FechadeSalida)
        {
            this.TipodeAccion = TipodeAccion;
            this.NumerodePista = NumerodePista;
            this.FechadeEntrada = FechadeEntrada;
            this.FechadeSalida = FechadeSalida;
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
        public string fechadesalida
        {
            get
            {
                return FechadeSalida;
            }
            set
            {
                FechadeSalida = value;
            }
        }

        public string fechadeentrada
        {
            get
            {
                return FechadeEntrada;
            }
            set
            {
                FechadeEntrada = value;
            }
        }

        
   
      
        

    }
}
