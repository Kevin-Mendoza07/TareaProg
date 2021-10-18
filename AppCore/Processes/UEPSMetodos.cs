using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public class UEPSMetodos : InventoryCalculator, IInventoryCalculator
    {
        public override decimal CostoInvFinal()
        {
            throw new NotImplementedException();
        }

        public override decimal CostoMatDisponibles()
        {
            throw new NotImplementedException();
        }

        public override decimal CostoMatUsados()
        {
            List<Inventario> list = new List<Inventario>();
            List<Inventario> lista = new List<Inventario>();
            list = SortListSalidas();
            lista = SortListEntradas();
            decimal suma = 0;
            for(int i = lista.Count - 1; i < list.Count; i++)
            {
                suma += lista[i].Unidades - list[i].Unidades;
            }
            return suma;

        }
    }
}
