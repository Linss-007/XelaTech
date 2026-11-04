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
    public partial class ActualizarEquipo : Form
    {
        Equipo equipoActual = null;
        public ActualizarEquipo()
        {
            InitializeComponent();
        }

        private void ActualizarEquipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Equipos equipos = new Equipos();
            equipos.Show();
        }

        private void btnVolverEquipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarCampos(bool visible)
        {
            lblInfoEquipo.Visible = visible;
            txbMarcaEquipo.Visible = visible;
            txbModeloEquipo.Visible = visible;
            cbxEstadoEquipo.Visible = visible;
            txbAccesEquipo.Visible = visible;
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            equipoActual = Datos.BuscarEquipo(txbBuscarEquipo.Text);
            if (equipoActual != null)
            {
                MessageBox.Show("El codigo ha sido encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblInfoEquipo.Text = "Tipo: " + Textos.De(equipoActual.TipoEquipo) + " | Serie: " + equipoActual.NumSerie + Environment.NewLine +
                                     "Propietario: " + equipoActual.Propietario.Codigo + " - " + equipoActual.Propietario.NombreCompleto;
                txbMarcaEquipo.Text = equipoActual.Marca;
                txbModeloEquipo.Text = equipoActual.Modelo;
                cbxEstadoEquipo.SelectedIndex = (int)equipoActual.EstadoFisico;
                txbAccesEquipo.Text = equipoActual.Accesorios;
                MostrarCampos(true);
            }
            else
            {
                MessageBox.Show("El codigo no se ha podido encontrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MostrarCampos(false);
            }
        }

        private void btnActuEquipo_Click(object sender, EventArgs e)
        {
            if (equipoActual == null)
            {
                MessageBox.Show("No se ha ingresado un codigo a buscar o no se ha encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbxEstadoEquipo.SelectedIndex < 0)
            {
                MessageBox.Show("El estado físico debe ser uno de los disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            estadoFisico estadoIng = (estadoFisico)(cbxEstadoEquipo.SelectedIndex);
            string error = equipoActual.ActualizarInfo(txbMarcaEquipo.Text, txbModeloEquipo.Text, estadoIng, txbAccesEquipo.Text);
            if (error != null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El equipo se ha actualizado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                equipoActual = null;
                txbBuscarEquipo.Clear();
                txbMarcaEquipo.Clear();
                txbModeloEquipo.Clear();
                txbAccesEquipo.Clear();
                MostrarCampos(false);
            }
        }
    }
}
