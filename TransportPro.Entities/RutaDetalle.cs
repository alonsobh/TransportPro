using TransportPro.Entities.Helpers;

namespace TransportPro.Entities
{
    public class RutaDetalle
    {
        public Paradero ParaderoOrigen { get; set; }

        public Paradero ParaderoDestino { get; set; }

        public Linea Linea { get; set; }

        public double Distancia => Distance.GetDistance(ParaderoOrigen.Coordenada, ParaderoDestino.Coordenada);
    }
}