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
            var detalle = DameDetalle(masCercanoOrigen, masCercaDestino);
            return new[] { new Ruta() { Detalle = detalle.ToArray() } };
        }

        private List<RutaDetalle> DameDetalle(Paradero origen, Paradero destino)
        {
            if (origen.Codigo == destino.Codigo)
                return new List<RutaDetalle>();

            var lineas = LineaBC.DameLineas(origen);
            var distance = Distance.GetDistance(origen.Coordenada, destino.Coordenada);
            var paraderosMasCercanos =
                lineas
                .SelectMany(l => l.Paraderos.Select(p => new { Paradero = p, Linea = l, Distancia = Distance.GetDistance(p.Coordenada, destino.Coordenada) + Distance.GetDistance(p.Coordenada, origen.Coordenada) }))
                .Where(p => p.Paradero.Codigo != origen.Codigo
                    && Distance.GetDistance(p.Paradero.Coordenada, destino.Coordenada) < distance)
                .OrderBy(p => p.Distancia)
                .ToArray();
            if (getMinimal)
            {
                var list = new List<List<RutaDetalle>>();


                foreach (var paraderoMasCercano in paraderosMasCercanos)
                {
                    var rutaDetalle = DameDetalle(paraderoMasCercano.Paradero, destino);
                    if (rutaDetalle == null)
                        continue;
                    var detalle = LineaARutaDetalle.DameDetalle(origen, paraderoMasCercano.Paradero, paraderoMasCercano.Linea);
                    detalle.AddRange(rutaDetalle);
                    list.Add(detalle);
                }
                return list.OrderBy(p => p.Sum(d => d.Distancia)).First();
            }
            else
            {
                foreach (var paraderoMasCercano in paraderosMasCercanos)
                {
                    var rutaDetalle = DameDetalle(paraderoMasCercano.Paradero, destino);
                    if (rutaDetalle == null)
                        continue;
                    var detalle = LineaARutaDetalle.DameDetalle(origen, paraderoMasCercano.Paradero, paraderoMasCercano.Linea);
                    detalle.AddRange(rutaDetalle);
                    return detalle;
                }

            }

            return new List<RutaDetalle>();
        }

        private bool getMinimal = false;


        private ParaderoBC ParaderoBC { get { return _paraderoBC ?? (_paraderoBC = new ParaderoBC()); } }
        private ParaderoBC _paraderoBC;
        private LineaBC LineaBC { get { return _lineaBC ?? (_lineaBC = new LineaBC()); } }

        private LineaBC _lineaBC;
    }
}