using Domain.Entities;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore.Processes
{
    public abstract class InventoryCalculator
    {
        public InventarioModel inventarioModel { get; set; }

        protected List<Inventario> listCalculos = new List<Inventario>();

        protected Inventario[] Calculos;
        public abstract decimal CostoInvFinal();
        public abstract decimal CostoMatUsados();
        public abstract decimal CostoMatDisponibles();

        public Inventario[] ConvertEntradas()
        {
            Calculos = inventarioModel.listaInv.ToArray();
            return Calculos;
        }
        public Inventario[] ConvertSalidas()
        {
            Calculos = inventarioModel.listaSalidas.ToArray();
            return Calculos;
        }
        public List<Inventario> SortListSalidas()
        {
            List<Inventario> sortedSalidas = inventarioModel.listaSalidas.OrderBy(x => x.FechaAdquisicion).ToList();
            return sortedSalidas;
        }
        public List<Inventario> SortListEntradas()
        {
            List<Inventario> sorted = inventarioModel.listaInv.OrderBy(x => x.FechaAdquisicion).ToList();
            return sorted;
        }
        public class SortInventoryByDate : IComparer<Inventario>
        {
            public int Compare(Inventario x, Inventario y)
            {
                if(x.FechaAdquisicion < y.FechaAdquisicion)
                {
                    return -1;

                } else if(x.FechaAdquisicion > y.FechaAdquisicion)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

    }
}
