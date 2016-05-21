using System;
using System.Linq;

namespace TransportPro.Entities
{
    [Serializable]
    public class Ruta
    {
        //public double Distancia = Detalle.Sum(p => p.Distancia);

        public RutaDetalle[] Detalle { get; set; }
    }
}