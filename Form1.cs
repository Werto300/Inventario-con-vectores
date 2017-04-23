using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Form1 : Form
    {
        Inventario Inven = new Inventario();
        Producto Produc;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Inven.Agregar(Produc = new Producto(Convert.ToInt32(txtCodigoAg.Text),txtNombreAg.Text, 
                Convert.ToInt32(txtCantidadAg.Text), Convert.ToInt32(txtPrecioAg.Text)));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inven.Eliminar(Convert.ToInt32(txtEliminar.Text));
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Producto buscado = Inven.Buscar(Convert.ToInt32(txtBusqueda.Text));
            if (buscado != null)
            {
                txtCodigoAg.Text = Convert.ToString(buscado.regresaCodigo());
                txtNombreAg.Text = Convert.ToString(buscado.regresaNombre());
                txtCantidadAg.Text = Convert.ToString(buscado.regresaCantidad());
                txtPrecioAg.Text = Convert.ToString(buscado.regresaPrecio());
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = Inven.Reporte();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Inven.Insertar(Produc = new Producto(Convert.ToInt32(txtCodigoAg.Text), txtNombreAg.Text,
                Convert.ToInt32(txtCantidadAg.Text), Convert.ToInt32(txtPrecioAg.Text)),
                Convert.ToInt32(txtInsertar.Text));
        }
    }
}
