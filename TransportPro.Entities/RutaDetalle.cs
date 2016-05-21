using TransportPro.Entities.Helpers;

namespace TransportPro.Entities
{
    public class RutaDetalle
    {
        public Paradero ParaderoOrigen { get; set; }

        public Paradero ParaderoDestino { get; set; }

        public string Linea { get; set; }

        public string Empresa { get; set; }

        public double Distancia => Distance.GetDistance(ParaderoOrigen.Coordenada, ParaderoDestino.Coordenada);
    }
}