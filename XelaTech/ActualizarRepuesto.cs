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
    public partial class ActualizarRepuesto : Form
    {
        Repuesto repuestoActual = null;
        public ActualizarRepuesto()
        {
            InitializeComponent();
        }

        private void ActualizarRepuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Repuestos repuestos = new Repuestos();
            repuestos.Show();
        }

        private void btnVolverRepuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCampos(bool visible)
        {
            txbNomRepuesto.Visible = visible;
            cbxCategoriaRep.Visible = visible;
            txbMinRepuesto.Visible = visible;
            txbCostoRepuesto.Visible = visible;
            txbPrecioRepuesto.Visible = visible;
            lblExistRepuesto.Visible = visible;
            txtReponerRepuesto.Visible = visible;
            txbReponerRepuesto.Visible = visible;
        }

        private void MostrarExistencia()
        {
            lblExistRepuesto.Text = "Existencia actual: " + repuestoActual.Existencia + " (" + repuestoActual.EstadoStock + ")";
        }

        private void btnBuscarRepuesto_Click(object sender, EventArgs e)
        {
            repuestoActual = Datos.BuscarRepuesto(txbBuscarRepuesto.Text);
            if (repuestoActual != null)
            {
                MessageBox.Show("El codigo ha sido encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNomRepuesto.Text = repuestoActual.Nombre;
                cbxCategoriaRep.SelectedIndex = (int)repuestoActual.Categoria;
                txbMinRepuesto.Text = repuestoActual.ExistenciaMin.ToString();
                txbCostoRepuesto.Text = repuestoActual.CostoUnitario.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                txbPrecioRepuesto.Text = repuestoActual.PrecioVenta.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
                txbReponerRepuesto.Clear();
                MostrarExistencia();
                MostrarCampos(true);
            }
            else
            {
                MessageBox.Show("El codigo no se ha podido encontrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarCampos(false);
            }
        }

        private void btnActuRepuesto_Click(object sender, EventArgs e)
        {
            if (repuestoActual == null)
            {
                MessageBox.Show("No se ha ingresado un codigo a buscar o no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxCategoriaRep.SelectedIndex < 0)
            {
                MessageBox.Show("La categoría debe ser una de las disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string error = repuestoActual.ActualizarInfo(txbNomRepuesto.Text, categoriaIng, minimaIng, costoIng, precioIng);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El repuesto se ha actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarExistencia();
            }
        }

        private void btnReponerRepuesto_Click(object sender, EventArgs e)
        {
            if (repuestoActual == null)
            {
                MessageBox.Show("No se ha ingresado un codigo a buscar o no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidadIng;
            if (!int.TryParse(txbReponerRepuesto.Text, out cantidadIng))
            {
                MessageBox.Show("La cantidad a reponer debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbReponerRepuesto.Clear();
                return;
            }
            string error = repuestoActual.Reponer(cantidadIng);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se repusieron " + cantidadIng + " unidades. Nueva existencia: " + repuestoActual.Existencia, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbReponerRepuesto.Clear();
                MostrarExistencia();
            }
        }
    }
}
