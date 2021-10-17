using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProducto.Formularios.Formularios_Inventario
{
    public partial class FrmAgregarCompra : Form
    {
        public List<Inventario> listaInventario = new List<Inventario>();
        public FrmAgregarCompra()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario(){
                Unidades = (int)nudUnidades.Value,
                CostoUnitario = nudCostoU.Value,
                FechaAdquisicion = dtpFechaAdquisicion.Value,
                CostoTotal = nudCostoU.Value*nudUnidades.Value
            };
            listaInventario.Add(Inv);

            Dispose();
        }
    }
}
