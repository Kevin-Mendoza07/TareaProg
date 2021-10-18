using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public interface IInventoryCalculator
    {
        decimal CostoInvFinal();
        decimal CostoMatDisponibles();
        decimal CostoMatUsados();
    }
}
