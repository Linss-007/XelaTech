using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XelaTech
{
    public partial class RegistroRepuesto : Form
    {
        public RegistroRepuesto()
        {
            InitializeComponent();
        }

        private void RegistroRepuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Repuestos repuestos = new Repuestos();
            repuestos.Show();
        }

        private void btnVolverRepuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegRepuesto_Click(object sender, EventArgs e)
        {
            string codigoIng = txbCodRepuesto.Text;
            string nombreIng = txbNomRepuesto.Text;
            if (!codigoIng.StartsWith("rep", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El código debe empezar con rep", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Datos.BuscarRepuesto(codigoIng) != null)
            {
                MessageBox.Show("El código ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxCategoriaRep.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int existenciaIng;
            if (!int.TryParse(txbExistRepuesto.Text, out existenciaIng))
            {
                MessageBox.Show("La existencia debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbExistRepuesto.Clear();
                return;
            }
            int minimaIng;
            if (!int.TryParse(txbMinRepuesto.Text, out minimaIng))
            {
                MessageBox.Show("La existencia mínima debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMinRepuesto.Clear();
                return;
            }
            double costoIng;
            if (!Textos.TryNumero(txbCostoRepuesto.Text, out costoIng))
            {
                MessageBox.Show("El costo unitario debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbCostoRepuesto.Clear();
                return;
            }
            double precioIng;
            if (!Textos.TryNumero(txbPrecioRepuesto.Text, out precioIng))
            {
                MessageBox.Show("El precio de venta debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbPrecioRepuesto.Clear();
                return;
            }
            categoria categoriaIng = (categoria)(cbxCategoriaRep.SelectedIndex);
            Repuesto repuesto = new Repuesto(codigoIng, nombreIng, categoriaIng, existenciaIng, minimaIng, costoIng, precioIng);
            if (repuesto.Codigo != codigoIng)
            {
                txbCodRepuesto.Clear();
            }
            else if (repuesto.Nombre != nombreIng)
            {
                txbNomRepuesto.Clear();
            }
            else if (repuesto.Existencia != existenciaIng)
            {
                txbExistRepuesto.Clear();
            }
            else if (repuesto.ExistenciaMin != minimaIng)
            {
                txbMinRepuesto.Clear();
            }
            else if (repuesto.CostoUnitario != costoIng)
            {
                txbCostoRepuesto.Clear();
            }
            else if (repuesto.PrecioVenta != precioIng)
            {
                txbPrecioRepuesto.Clear();
            }
            else
            {
                repuesto.RegistrarRepuesto(repuesto);
                MessageBox.Show("El repuesto se ha registrado (estado del inventario: " + repuesto.EstadoStock + ")", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpiarRepuesto_Click(sender, e);
            }
        }

        private void btnLimpiarRepuesto_Click(object sender, EventArgs e)
        {
            txbCodRepuesto.Clear();
            txbNomRepuesto.Clear();
            txbExistRepuesto.Clear();
            txbMinRepuesto.Clear();
            txbCostoRepuesto.Clear();
            txbPrecioRepuesto.Clear();
            cbxCategoriaRep.SelectedIndex = -1;
        }
    }
}
