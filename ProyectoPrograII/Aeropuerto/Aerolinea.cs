using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPrograII.Aeropuerto
{
    public class Aerolinea 
    {

        //Encapsulamiento
        private string NombredeAerolinea;

        private int NumerodeAviones;


        //Constructor
        public Aerolinea(string NombredeAerolinea, int NumerodeAviones )
        {
            this.NombredeAerolinea = NombredeAerolinea;
            this.NumerodeAviones = NumerodeAviones;
           
        }


        //Inicio Nombre de Aerolinea
        public string nombredeaerolinea
        {
            get
            {
                return NombredeAerolinea;
            }

            set
            {
                NombredeAerolinea = value;
            }
        }
        //Finaliza Nombre de Aerolinea

        //Inicio Numero de Aviones
        public int numerodeaviones
        {
            get
            {
                return NumerodeAviones;
            }
            set
            {
                NumerodeAviones = value;
            }
         //Finaliza Numero de Aviones
        }

      
       

        private void Aerolinea_Load(object sender, EventArgs e)
        {

        }
    }
}
