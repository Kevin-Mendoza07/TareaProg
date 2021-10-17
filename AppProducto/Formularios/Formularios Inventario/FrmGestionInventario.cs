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
    public partial class FrmGestionInventario : Form
    {
        List<Inventario> listaInv = new List<Inventario>();
        List<Inventario> listaSalidas = new List<Inventario>();
        public FrmGestionInventario()
        {
            InitializeComponent();
        }

        private void btnAgregarCompras_Click(object sender, EventArgs e)
        {
            FrmAgregarCompra frmAgregarCompra = new FrmAgregarCompra();
            frmAgregarCompra.listaInventario = listaInv;
            frmAgregarCompra.ShowDialog();

            dgvInventario.DataSource = null;
            dgvInventario.DataSource = listaInv;
        }

        private void btnAgregarSalida_Click(object sender, EventArgs e)
        {
            
        }
    }
}
