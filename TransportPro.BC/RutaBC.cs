using TransportPro.Entities;

namespace TransportPro.BC
{
    public class RutaBC
    {
        public Ruta[] DameRuta(Coordenada origen, Coordenada destino)
        {
            var masCercano = ParaderoBC.ParaderoMasCerca(origen);

            var masCercaDestino = ParaderoBC.ParaderoMasCerca(destino);

            return null;
        }

        private ParaderoBC ParaderoBC => _ParaderoBC ?? (_ParaderoBC = new ParaderoBC());
        private ParaderoBC _ParaderoBC;
    }
}