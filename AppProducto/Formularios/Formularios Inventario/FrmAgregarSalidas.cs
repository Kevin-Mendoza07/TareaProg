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
    public partial class FrmAgregarSalidas : Form
    {
        public List<Inventario> listInventory = new List<Inventario>();
        public FrmAgregarSalidas()
        {
           
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (nudUnidUtilizadas.Value <= 0)
            {
                MessageBox.Show("Error, la cantidad de unidades es invalida","Mensaje de Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Inventario inventory = new Inventario()
            {
                FechaAdquisicion = dtpFechaSalida.Value,
                UnidadesUtilizadas = (int)nudUnidUtilizadas.Value     
            };
            listInventory.Add(inventory);
            Dispose();
        }
    }
}
