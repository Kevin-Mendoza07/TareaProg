using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public class PromedioSimpleMetodos : InventoryCalculator,IInventoryCalculator
    {

        public override decimal CostoInvFinal()
        {
            decimal promSimple, suma = 0M, promSimpleSalida, sumSalidas = 0M,UnidadesDisponibles=0M;
            int TotalExistencia = 0;
            int matdisponibles = 0;

            for(int j=0; j<inventarioModel.listaInv.Count;j++){

                suma += inventarioModel.listaInv[j].CostoUnitario;
                TotalExistencia = inventarioModel.listaInv[j].Id; 

            }
            promSimple = suma / TotalExistencia;

            for(int i = 0; i < inventarioModel.listaSalidas.Count; i++)
            {
                sumSalidas += inventarioModel.listaSalidas[i].Unidades;
                
            }
            UnidadesDisponibles = suma - sumSalidas;

            return promSimple * UnidadesDisponibles;
            
        }

        public override decimal CostoMatDisponibles()
        {
            decimal invFinal = 0;
            decimal MatUsado = 0;
            decimal TotalMatDisponible = 0M;

            invFinal = CostoInvFinal();
            MatUsado = CostoMatUsados();

            TotalMatDisponible = invFinal + MatUsado;

            return TotalMatDisponible;
        }

        public override decimal CostoMatUsados()
        {
            int unidadesDis = 0, suma=0;
            decimal sumcostuni = 0M;
            decimal promSimple = 0M;
            int compras = 0;

            for(int i = 0; i < inventarioModel.listaInv.Count; i++)
            {
                suma+= inventarioModel.listaInv[i].Unidades;

            }
            for(int j = 0; j < inventarioModel.listaInv.Count; j++)
            {
                sumcostuni += inventarioModel.listaInv[j].Unidades;
                compras = inventarioModel.listaInv[j].Id;

            }
            promSimple = sumcostuni / compras;

            return suma * promSimple;
        }
        }
    }

