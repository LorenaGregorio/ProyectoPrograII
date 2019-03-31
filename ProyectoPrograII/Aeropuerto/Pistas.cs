using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograII.Aeropuerto
{
    public class Pistas : PlandeVuelo
    {

        // constructor
        public Pistas(string CodigodeAvion, string TipodeAccion, string ClasedeAvion, string LugarSalida_LlegadaAvion, string Fecha, bool Escala, string Pista_Categoria, string TipodeEmergencia, double Latitud, double Longitud, double Distancia, double TiempoEstimadoLlegada) 
            : base(CodigodeAvion, TipodeAccion, ClasedeAvion, LugarSalida_LlegadaAvion, Fecha, Escala, Pista_Categoria, TipodeEmergencia, Latitud, Longitud, Distancia, TiempoEstimadoLlegada)
        {

        }
    }
}
