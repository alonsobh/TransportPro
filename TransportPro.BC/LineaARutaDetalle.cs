using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TransportPro.Entities;

namespace TransportPro.BC
{
    public static class LineaARutaDetalle
    {

        public static List<RutaDetalle> DameDetalle(Paradero origen, Paradero destino, Linea linea)
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
    }
}
