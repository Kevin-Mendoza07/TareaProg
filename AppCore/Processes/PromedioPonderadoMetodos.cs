using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public class PromedioPonderadoMetodos : InventoryCalculator,IInventoryCalculator
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
            throw new NotImplementedException();
        }
    }
}
