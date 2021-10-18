using AppCore.Processes;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Factories
{
    public static class InventoryFactory
    {
        public static IInventoryCalculator CreateInstance(InventoryCalculator inv)
        {
            if (inv is null)
            {
                throw new ArgumentNullException(nameof(inv));
            }
            if (inv is PEPSMetodos)
            {
                return new PEPSMetodos();

            }else if(inv is UEPSMetodos)
            {
                return new UEPSMetodos();

            }else if(inv is PromedioPonderadoMetodos)
            {
                return new PromedioPonderadoMetodos();

            }else if(inv is PromedioSimpleMetodos)
            {
                return new PromedioSimpleMetodos();
            }
            else
            {
                throw new Exception(nameof(inv));
            }
        } 
    }
}
