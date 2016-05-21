using System.Collections.Generic;
using System.Linq;
using TransportPro.Entities;
using TransportPro.Entities.Helpers;

namespace TransportPro.BC
{
    public class RutaBC
    {
        public Ruta[] DameRuta(Coordenada origen, Coordenada destino)
        {
            var masCercanoOrigen = ParaderoBC.ParaderoMasCerca(origen);
            var masCercaDestino = ParaderoBC.ParaderoMasCerca(destino);
            var detalle= DameDetalle(masCercanoOrigen, masCercaDestino);
            return new[] {new Ruta() {Detalle = detalle.ToArray()}};
        }

        private List<RutaDetalle> DameDetalle(Paradero origen, Paradero destino)
        {
            if (origen.Codigo == destino.Codigo)
                return new List<RutaDetalle>();

            var distancia = Distance.GetDistance(origen.Coordenada, destino.Coordenada);

            var lineas = LineaBC.DameLineas(origen);

            var paraderosMasCercanos =
                lineas.SelectMany(p => p.Paraderos)
                    .Where(p => p.Codigo != origen.Codigo
                                && Distance.GetDistance(p.Coordenada, destino.Coordenada) < distancia)
                    .OrderBy(p => Distance.GetDistance(p.Coordenada, destino.Coordenada))
                    .ToArray();
            foreach (var paraderoMasCercano in paraderosMasCercanos)
            {
                var rutaDetalle = DameDetalle(paraderoMasCercano, destino);
                if (rutaDetalle == null)
                    continue;
                var detalle = new RutaDetalle { ParaderoOrigen = origen, ParaderoDestino = paraderoMasCercano };
                var resultado = new List<RutaDetalle> { detalle };
                resultado.AddRange(rutaDetalle);
                return resultado;
            }

            return null;
        }


        private ParaderoBC ParaderoBC => _paraderoBC ?? (_paraderoBC = new ParaderoBC());
        private ParaderoBC _paraderoBC;

        private LineaBC LineaBC => _lineaBC ?? (_lineaBC = new LineaBC());
        private LineaBC _lineaBC;
    }
}