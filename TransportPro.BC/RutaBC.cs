using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

            var distancia = Distance.GetDistance(origen.Coordenada, destino.Coordenada);

            var lineas = LineaBC.DameLineas(origen);

            var paraderosMasCercanos =
                lineas
                .SelectMany(l => l.Paraderos.Select(p => new { Paradero = p, Linea = l, Distancia = Distance.GetDistance(p.Coordenada, destino.Coordenada) }))
                .Where(p => p.Paradero.Codigo != origen.Codigo
                                && p.Distancia < distancia)
                .OrderBy(p => p.Distancia)
                .ToArray();
            foreach (var paraderoMasCercano in paraderosMasCercanos)
            {
                var rutaDetalle = DameDetalle(paraderoMasCercano.Paradero, destino);
                if (rutaDetalle == null)
                    continue;
                var detalle = DameDetalle(origen, paraderoMasCercano.Paradero, paraderoMasCercano.Linea);
                detalle.AddRange(rutaDetalle);
                return detalle;
            }

            return null;
        }

        private List<RutaDetalle> DameDetalle(Paradero origen, Paradero destino, Linea linea)
        {
            var add = false;
            var list = new List<RutaDetalle>();
            foreach (var paradero in linea.Paraderos)
            {
                if (new[] { origen.Codigo, destino.Codigo }.Contains(paradero.Codigo))
                    add = !add;

            }
            return null;
        }


        private ParaderoBC ParaderoBC { get { return _paraderoBC ?? (_paraderoBC = new ParaderoBC()); } }
        private ParaderoBC _paraderoBC;
        private LineaBC LineaBC { get { return _lineaBC ?? (_lineaBC = new LineaBC()); } }

        private LineaBC _lineaBC;
    }
}