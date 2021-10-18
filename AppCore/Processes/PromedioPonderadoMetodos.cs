using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public class PromedioPonderadoMetodos : InventoryCalculator,IInventoryCalculator
    {
        public override decimal CostoInvFinal()
        {
            decimal promedioPonderado, suma = 0, sumaSalidas = 0;
            int existenciasTotales = 0, existenciasSalidas = 0;
            int materialesDisponibles = 0;

            for (int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                suma += inventarioModel.listaInv[i].CostoTotal;
                existenciasTotales += inventarioModel.listaInv[i].Unidades;
            }

            for (int i = 0; i < inventarioModel.listaSalidas.Count; i++)
            {
                sumaSalidas += inventarioModel.listaSalidas[i].CostoTotal;
                existenciasSalidas += inventarioModel.listaSalidas[i].Unidades;
            }

            for (int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                materialesDisponibles += inventarioModel.listaInv[i].Unidades - inventarioModel.listaSalidas[i].Unidades;
            }

            promedioPonderado = suma / existenciasTotales;
            decimal resultado = promedioPonderado * materialesDisponibles;
            return resultado;
        }

        public override decimal CostoMatDisponibles()
        {
            decimal promedioPonderado, suma = 0, sumaSalidas = 0;
            int existenciasTotales = 0, existenciasSalidas = 0;
            int materialesDisponibles = 0;

            for (int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                suma += inventarioModel.listaInv[i].CostoTotal;
                existenciasTotales += inventarioModel.listaInv[i].Unidades;
            }

            for (int i = 0; i < inventarioModel.listaSalidas.Count; i++)
            {
                sumaSalidas += inventarioModel.listaSalidas[i].CostoTotal;
                existenciasSalidas += inventarioModel.listaSalidas[i].Unidades;
            }

            for (int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                materialesDisponibles += inventarioModel.listaInv[i].Unidades - inventarioModel.listaSalidas[i].Unidades;
            }

            promedioPonderado = suma / existenciasTotales;
            

            decimal matUsados = existenciasSalidas * promedioPonderado;
            decimal invFinal = promedioPonderado * materialesDisponibles;
            decimal resultado = invFinal + matUsados;
            return resultado;
        }

        public override decimal CostoMatUsados()
        {
            decimal promedioPonderado, suma = 0, sumaSalidas = 0;
            int existenciasTotales = 0,existenciasSalidas = 0;
            int materialesDisponibles = 0;

            for (int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                suma += inventarioModel.listaInv[i].CostoTotal;
                existenciasTotales += inventarioModel.listaInv[i].Unidades;
            }
            for(int i = 0; i < inventarioModel.listaSalidas.Count; i++)
            {
                sumaSalidas += inventarioModel.listaSalidas[i].CostoTotal;
                existenciasSalidas += inventarioModel.listaSalidas[i].Unidades;
            }
            for(int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                materialesDisponibles += inventarioModel.listaInv[i].Unidades - inventarioModel.listaSalidas[i].Unidades;
            }
            promedioPonderado = suma / existenciasTotales;
         
            decimal resultado = existenciasSalidas * promedioPonderado;
            return resultado;
        }
    }
}
