using Domain.Entities;
using Infraestructure.Productos;
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
        public InventarioModel inventarioModel { get; set; }
        
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

            if ((int)nudUnidades.Value <= 0)
            {
                MessageBox.Show("Error, la cantidad de unidades es invalida", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if ((int)nudCostoU.Value<=0)
            {
                MessageBox.Show("Error, el costo es invalido","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
                Inventario Inv = new Inventario()
                {

                    Id = listaInventario.Count + 1,
                    Unidades = (int)nudUnidades.Value,
                    CostoUnitario = nudCostoU.Value,
                    FechaAdquisicion = dtpFechaAdquisicion.Value,
                    CostoTotal = nudCostoU.Value * nudUnidades.Value

                };
                listaInventario.Add(Inv);

                Dispose();

            
        }
            
        }
    }

