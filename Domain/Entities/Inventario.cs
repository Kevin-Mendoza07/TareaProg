using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Inventario
    {
        public int Id { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public int Unidades { get; set; }
        public decimal CostoTotal { get; set; }
        public decimal CostoUnitario { get; set; }
        public int UnidadesUtilizadas { get; set; }

        

    }
}
