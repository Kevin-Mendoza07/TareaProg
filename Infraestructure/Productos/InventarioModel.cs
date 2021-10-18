using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infraestructure.Productos
{
    public class InventarioModel
    {
        public List<Inventario> listaInv = new List<Inventario>();

        public List<Inventario> listaSalidas = new List<Inventario>();
        public int GetLastId()
        {
            Inventario[] tmp = listaInv.ToArray();
            return tmp == null ? 0 : tmp[tmp.Length - 1].Id;
        }

        public List<Inventario> GetInventarios()
        {
            return listaInv;
        }
        
    }
}
