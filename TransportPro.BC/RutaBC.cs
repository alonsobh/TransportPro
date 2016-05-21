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

            var paraderosMasCercanos =
                lineas
                .SelectMany(l => l.Paraderos.Select(p => new { Paradero = p, Linea = l, Distancia = Distance.GetDistance(p.Coordenada, destino.Coordenada) + Distance.GetDistance(p.Coordenada, origen.Coordenada) }))
                .Where(p => p.Paradero.Codigo != origen.Codigo)
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
                    var detalle = DameDetalle(origen, paraderoMasCercano.Paradero, paraderoMasCercano.Linea);
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
                    var detalle = DameDetalle(origen, paraderoMasCercano.Paradero, paraderoMasCercano.Linea);
                    detalle.AddRange(rutaDetalle);
                    return detalle;
                }

            }

            return null;
        }

        private bool getMinimal = false;

        private List<RutaDetalle> DameDetalle(Paradero origen, Paradero destino, Linea linea)
        {
            var add = false;
            var list = new List<RutaDetalle>();
            var insert = false;
            var resetAdd = false;
            Paradero old = null;
            foreach (var paradero in linea.Paraderos)
            {
                if (resetAdd)
                    add = false;
                if (new[] { origen.Codigo, destino.Codigo }.Contains(paradero.Codigo))
                {
                    add = !add;
                    if (add)
                    {
                        if (destino.Codigo == paradero.Codigo)
                            insert = true;
                        old = null;
                    }
                    else
                    {
                        resetAdd = true;
                        add = true;
                    }
                }
                if (add && old != null)
                {
                    if (insert)
                        list.Insert(0, new RutaDetalle { Linea = linea.Codigo, Empresa = linea.Empresa.Nombre, ParaderoOrigen = paradero, ParaderoDestino = old });
                    else
                        list.Add(new RutaDetalle { Linea = linea.Codigo, Empresa = linea.Empresa.Nombre, ParaderoOrigen = old, ParaderoDestino = paradero });
                }
                old = paradero;
            }
            return list;
        }


        private ParaderoBC ParaderoBC { get { return _paraderoBC ?? (_paraderoBC = new ParaderoBC()); } }
        private ParaderoBC _paraderoBC;
        private LineaBC LineaBC { get { return _lineaBC ?? (_lineaBC = new LineaBC()); } }

        private LineaBC _lineaBC;
    }
}