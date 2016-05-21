using TransportPro.Entities;

namespace TransportPro.BC
{
    public class RutaBC
    {
        public Ruta[] DameRuta(Coordenada origen, Coordenada destino)
        {
            return null;
        }

        private ParaderoBC ParaderoBC => _ParaderoBC ?? (_ParaderoBC = new ParaderoBC());
        private ParaderoBC _ParaderoBC;
    }
}