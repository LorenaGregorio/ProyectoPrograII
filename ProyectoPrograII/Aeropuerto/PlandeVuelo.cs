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

        private string Fecha;

       
        
        //constructor

        public PlandeVuelo(string TipodeAccion, string NumerodePista, string Fecha)
        {
            this.TipodeAccion = TipodeAccion;
            this.NumerodePista = NumerodePista;
            this.Fecha = Fecha;
        
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






    }
}
