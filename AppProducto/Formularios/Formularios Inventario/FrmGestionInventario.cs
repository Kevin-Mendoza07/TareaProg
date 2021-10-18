using Domain.Entities;
using Domain.Enums;
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
    public partial class FrmGestionInventario : Form
    {
        private InventarioModel invModel;
        public FrmGestionInventario()
        {
            invModel = new InventarioModel();
            InitializeComponent();
        }

        private void btnAgregarCompras_Click(object sender, EventArgs e)
        {
            FrmAgregarCompra frmAgregarCompra = new FrmAgregarCompra();
            frmAgregarCompra.inventarioModel = invModel;
            frmAgregarCompra.listaInventario = invModel.listaInv;
            frmAgregarCompra.ShowDialog();

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = invModel.listaInv;
        }

        private void btnAgregarSalida_Click(object sender, EventArgs e)
        {
            FrmAgregarSalidas frmAgregarSalidas = new FrmAgregarSalidas();
            frmAgregarSalidas.inventarioModel = invModel;
            frmAgregarSalidas.listInventory = invModel.listaSalidas;
            frmAgregarSalidas.ShowDialog();

            dgvSalidas.DataSource = null;
            dgvSalidas.DataSource = invModel.listaSalidas;

        }

        private void btnCMatDisponible_Click(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGestionInventario_Load(object sender, EventArgs e)
        {
            cmbEleccion.Items.AddRange(Enum.GetValues(typeof(TipoMetodo)).Cast<object>().ToArray());
        }
    }
}
